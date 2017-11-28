using ListViewSorter;
using Ripcord.Assets.Forms;
using Ripcord.Assets.Globals;
using Ripcord.Assets.Libraries;
using Ripcord.Assets.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ripcord
{
    public partial class frmMain : Form
    {
        private ListViewColumnSorter lvwColumnSorter = null;

        SaveFileDialog sfd = new SaveFileDialog();
        OpenFileDialog ofd = new OpenFileDialog();

        int _elapsed = 0;
        bool stop = true;

        //Check values
        int transparent = 0;
        int anonymous = 0;
        int elite = 0;
        int dead = 0;
        int alive = 0;
        int check = 0;
        int scrape_index = 0;
        int engine_index = 0;
        int check_index = 0;

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Menu = mainMenu1;
            ControlExtensions.DoubleBuffered(lvProxies, true);

            API.HWID = HWID.Generate();

            //Load Ports
            var _ports = File.ReadAllLines(Environment.CurrentDirectory + "\\assets\\ports.txt");
            foreach (string _port in _ports)
                Lists.Ports.Add(_port);

            //Load sources
            var _sources = File.ReadAllLines(Environment.CurrentDirectory + "\\assets\\sources.txt");
            foreach (string _source in _sources)
                Lists.Sources.Add(new Source(_source));
            lblTotalSources.Text = string.Format("Total sources: {0}", Lists.Sources.Count);

            Helpers.logfile = string.Format("{0}\\logs\\{1}", Environment.CurrentDirectory, Helpers.UnixTimeNow());

            lvwColumnSorter = new ListViewColumnSorter();
            lvProxies.ListViewItemSorter = lvwColumnSorter;
            lvProxies.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvProxies.AutoArrange = true;

            lvwColumnSorter._SortModifier = ListViewColumnSorter.SortModifiers.SortByText;

            cbTask.SelectedIndex++;
            cbLocationFilter.SelectedIndex++;
            cbTypeFilter.SelectedIndex++;

            Lists.Keywords.Add("Daily Free SSL Proxies");
        }

        delegate void AddItemCallback(ListView lv, ListViewItem item);
        public void AddItem(ListView lv, ListViewItem item)
        {
            if (InvokeRequired)
            {
                Invoke(new AddItemCallback(AddItem), lv, item);
            }
            else
            {
                lv.BeginUpdate();
                lv.Items.Add(item);
                lv.EndUpdate();
            }
        }

        void Prepare(string task)
        {
            lblStatus.Text = "Initializing engine...";
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            _elapsed = 0;
            stop = false;
            tCounter.Start();
            check = 0;
            alive = 0;
            transparent = 0;
            anonymous = 0;
            elite = 0;
            dead = 0;

            if(task == "Scrape")
            {
                scrape_index = 0;
                for (int i = 0; i < Globals.Bots; i++)
                    ThreadPool.QueueUserWorkItem(a => Scrape());

            } else if(task == "Check")
            {
                groupFilter.Enabled = false;
                check_index = 0;
                for (int i = 0; i < Globals.Bots; i++)
                    ThreadPool.QueueUserWorkItem(a => Check());
            }
            else if (task == "URL Harvester")
            {
                engine_index = 0;
                for (int i = 0; i < Globals.Bots; i++)
                    ThreadPool.QueueUserWorkItem(a => Harvest());
            }
        }

        void Halt()
        {
            lblStatus.Text = "Waiting for user...";
            groupFilter.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            stop = true;
            tCounter.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Prepare(cbTask.SelectedItem.ToString());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
            btnStop.Enabled = false;
        }

        private void btnLoadSources_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd.ShowDialog();

            if(result == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        Lists.Sources.Add(new Source(line));
                    }
                    lblTotalSources.Text = string.Format("Total sources: {0}", Lists.Sources.Count);
                }
            }
        }

        private void btnClearSources_Click(object sender, EventArgs e)
        {
            if (Lists.Sources.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Ripcord", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Lists.Sources.Clear();
                    lblTotalSources.Text = string.Format("Total sources: {0}", Lists.Sources.Count);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        void Harvest()
        {
            try
            {
                lblStatus.Text = "Harvesting sources, " + engine_index + " out of " + Lists.Engines.Count + " done.";
                while (engine_index < Lists.Engines.Count + 1)
                {
                    if (stop)
                        break;

                    Engine engine = Lists.Engines.ElementAt(engine_index);
                    engine_index++;
                    lblStatus.Text = "Harvesting sources, " + engine_index + " out of " + Lists.Engines.Count + " done.";
                    Lists.Sources.AddRange(Harvester.Harvest(engine, "", 0));
                    lblTotalSources.Text = string.Format("Total sources: {0}", Lists.Sources.Count);

                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch
            {
            }
            finally
            {
                lblStatus.Text = "Harvesting done.";
                Halt();
            }
        }

        void Scrape()
        {
            try
            {

                while(scrape_index < Lists.Sources.Count)
                {
                    if (stop)
                        break;

                    Source source = Lists.Sources.ElementAt(scrape_index);
                    scrape_index++;
                    lblStatus.Text = "Scraping sources, " + scrape_index + " out of " + Lists.Sources.Count + " done.";

                    List<ProxyLib> Proxies = Scraper.Scrape(source);
                    Lists.Proxies.AddRange(Proxies);

                    lblTotalProxies.Text = string.Format("Total proxies: {0}", Lists.Proxies.Count);
                    lblDeadSources.Text = string.Format("Dead sources: {0}", Lists.Sources.Where(src => !src.alive).ToList().Count);
                    lblWorkingSources.Text = string.Format("Working sources: {0}", Lists.Sources.Where(src => src.alive).ToList().Count);


                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch
            {
            }
            finally
            {
                lblStatus.Text = "Scraping done.";
                Halt();
            }
        }

        

        void Check()
        {
            lvProxies.Update();
            try
            {
                Globals.IPAddress = Helpers.GetIP();
                while (check_index < Lists.Proxies.Count)
                {

                    if (stop)
                        break;

                    ProxyLib proxy = Lists.Proxies.ElementAt(check_index);
                    check_index++;
                    proxy.Date_initiated = DateTime.Now.ToString("yyyy-mm-dd");
                    proxy.Time_initiated = DateTime.Now.ToString("hh:mm:ss tt");
                    lblStatus.Text = "Checking proxies...";
                    proxy = Checker.Judge(proxy);
                    if (proxy.Alive)
                    {
                        proxy = Checker.GetGeo(proxy);
                        alive++;

                        if (proxy.Anonymity_type == Assets.Libraries.Enums.Anonymity.Transparent)
                            transparent++;
                        else if (proxy.Anonymity_type == Assets.Libraries.Enums.Anonymity.Anonymous)
                            anonymous++;
                        else if (proxy.Anonymity_type == Assets.Libraries.Enums.Anonymity.Elite)
                            elite++;


                        Lists.Checked_proxies.Add(proxy);
                        if(!Globals.Disable_listview)
                            lvProxies.Items.Add(new ListViewItem(new string[] { proxy.Proxy, proxy.Anonymity_type.ToString(), proxy.Country, proxy.Region, proxy.City, proxy.Response_time.ToString(), proxy.Time_initiated }));
                        
                        lblTransProxies.Text = string.Format("Transparent: {0}", transparent);
                        lblAnonProxies.Text = string.Format("Anonymous: {0}", anonymous);
                        lblEliteProxies.Text = string.Format("Elite: {0}", elite);
                        lblWorkingProxies.Text = string.Format("Working proxies: {0}", alive);

                    }
                    else
                        dead++;

                    check++;
                    lblDeadProxies.Text = string.Format("Dead proxies: {0}", dead);

                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            } catch
            {

            } finally
            {

                lvProxies.EndUpdate();
                Task.Factory.StartNew(() =>
                {
                    Halt();
                });
            }
        }

        private void tCounter_Tick(object sender, EventArgs e)
        {
            _elapsed++;
            lblTimeElapsed.Text = string.Format("Time elapsed: {0}", TimeSpan.FromSeconds(_elapsed));
        }

        private void btnAnalyzeSources_Click(object sender, EventArgs e)
        {
            if(Lists.Sources.Count > 0)
            {
                SourceAnalyzer analyzer = new SourceAnalyzer();
                analyzer.ShowDialog();
            }
        }

        private void tsmiClearUncheckedProxies_Click(object sender, EventArgs e)
        {
            if (Lists.Proxies.Count > 0 && stop)
            {
                if (MessageBox.Show("Are you sure?", "Ripcord", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Lists.Proxies.Clear();
                    lblTotalProxies.Text = string.Format("Total proxies: {0}", Lists.Proxies.Count);
                }
            }
        }

        private void tsmiClearCheckedProxies_Click(object sender, EventArgs e)
        {
            if (lvProxies.Items.Count > 0 && stop)
            {
                if (MessageBox.Show("Are you sure?", "Ripcord", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvProxies.Items.Clear();
                    lblWorkingProxies.Text = string.Format("Working proxies: {0}", lvProxies.Items.Count);
                }
            }
        }

        private void tsmiCopyUncheckedProxies_Click(object sender, EventArgs e)
        {
            if (Lists.Proxies.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (ProxyLib prx in Lists.Proxies)
                    sb.AppendLine(prx.Proxy);

                Clipboard.SetText(sb.ToString());
                sb.Clear();
            }
        }

        private void tsmiCopyCheckedProxies_Click(object sender, EventArgs e)
        {
            if (lvProxies.Items.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (ListViewItem lvi in lvProxies.Items)
                    sb.AppendLine(lvi.Text);

                Clipboard.SetText(sb.ToString());
                sb.Clear();
            }
        }

        private void tsmiCopySelectedProxies_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in lvProxies.SelectedItems)
                sb.AppendLine(item.Text);

            Clipboard.SetText(sb.ToString());
            sb.Clear();
        }

        private void tsmiLoadProxiesFromFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                var proxies = File.ReadAllLines(ofd.FileName);
                foreach (string proxy in proxies)
                {
                    Match match = new Regex(Scraper.Proxy_Pattern).Match(proxy);
                    if (match.Success)
                        Lists.Proxies.Add(new ProxyLib(proxy));
                }
                Array.Clear(proxies, 0, proxies.Length);
                lblTotalProxies.Text = string.Format("Total proxies: {0}", Lists.Proxies.Count);
            }
        }

        private void tsmiLoadProxiesFromClipboard_Click(object sender, EventArgs e)
        {
            var clipboard = Clipboard.GetText().Split('\n').ToList();
            foreach (string proxy in clipboard)
            {
                Match match = new Regex(Scraper.Proxy_Pattern).Match(proxy);
                if (match.Success)
                    Lists.Proxies.Add(new ProxyLib(proxy));

            }
            lblTotalProxies.Text = string.Format("Total proxies: {0}", Lists.Proxies.Count);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            URLHarvester harvester = new URLHarvester();
            harvester.Show();
        }

        private void lvProxies_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView myListView = (ListView)sender;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }

        private void lvProxies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            btnFilter.Enabled = false;
            lvProxies.Items.Clear();

            Task.Factory.StartNew(() => {
                foreach (ProxyLib x in Lists.Checked_proxies)
                    lvProxies.Items.Add(new ListViewItem(new string[] { x.Proxy, x.Anonymity_type.ToString(), x.Country, x.Region, x.City, x.Response_time.ToString(), x.Time_initiated }));

                btnReset.Enabled = true;
                btnFilter.Enabled = true;
            });
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            btnFilter.Enabled = false;
            List<ProxyLib> filtered = new List<ProxyLib>();

            string location = cbLocationFilter.SelectedItem.ToString();
            string type = cbTypeFilter.SelectedItem.ToString();

            if (location == "All Locations")
                filtered = Lists.Checked_proxies;
            else
                filtered = Lists.Checked_proxies.Where(x => x.Country == location).ToList();

            if (cbPortFilter.Checked && txtFilterPorts.Text != "")
            {
                List<ProxyLib> _cleaned = new List<ProxyLib>();
                string[] ports = new string[] { txtFilterPorts.Text };
                if (txtFilterPorts.Text.Contains(","))
                {
                    ports = txtFilterPorts.Text.Split(',');
                }

                foreach (string port in ports)
                    _cleaned = filtered.Where(x => x.Proxy.EndsWith(":" + port)).ToList();

                filtered = _cleaned;
            }

            if (type == "Transparent")
                filtered = filtered.Where(x => x.Anonymity_type == Assets.Libraries.Enums.Anonymity.Transparent).ToList();
            else if(type == "Anonymous")
                filtered = filtered.Where(x => x.Anonymity_type == Assets.Libraries.Enums.Anonymity.Anonymous).ToList();
            else if(type == "Elite")
                filtered = filtered.Where(x => x.Anonymity_type == Assets.Libraries.Enums.Anonymity.Elite).ToList();

            if (checkSpeedFilter.Checked && numSpeedValue1.Value < numSpeedValue2.Value)
            {

                filtered = filtered.Where(x => x.Response_time >= numSpeedValue1.Value && x.Response_time <= numSpeedValue2.Value).ToList();
            }

            lvProxies.Items.Clear();

            Task.Factory.StartNew(() => {
                foreach (ProxyLib x in filtered)
                    lvProxies.Items.Add(new ListViewItem(new string[] { x.Proxy, x.Anonymity_type.ToString(), x.Country, x.Region, x.City, x.Response_time.ToString(), x.Time_initiated }));

                filtered.Clear();
                btnReset.Enabled = true;
                btnFilter.Enabled = true;
            });

        }

        private void tsmiJudgeProxy_Click(object sender, EventArgs e)
        {
            if(lvProxies.SelectedItems.Count == 1)
            {
                Task.Factory.StartNew(() => {
                    Judge jdg = new Judge(lvProxies.SelectedItems[0].Text);
                    jdg.Text = "Judge - " + lvProxies.SelectedItems[0].Text;
                    jdg.ShowDialog();
                });
                GC.Collect();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
        }

        private void checkedProxiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.FileName = "proxies.txt";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (ProxyLib x in Lists.Checked_proxies)
                        sw.WriteLine(x.Proxy);
                }
            }
        }

        private void allProxiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.FileName = "proxies.txt";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (ProxyLib x in Lists.Proxies)
                        sw.WriteLine(x.Proxy);
                }
            }
        }

        private void tsmiDeleteSelectedProxies_Click(object sender, EventArgs e)
        {
            if (stop)
            {
                foreach (ListViewItem item in lvProxies.SelectedItems)
                {
                    Lists.Checked_proxies.RemoveAll(x => x.Proxy == item.Text);
                    item.Remove();
                }
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            Settings stg = new Settings();
            stg.ShowDialog();
            
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Checkers checker = new Checkers();
            checker.ShowDialog();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            SourceAnalyzer snc = new SourceAnalyzer();
            snc.Show();
        }
    }
}
