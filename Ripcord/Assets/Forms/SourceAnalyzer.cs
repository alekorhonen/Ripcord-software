using Ripcord.Assets.Globals;
using Ripcord.Assets.Libraries;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ripcord.Assets.Forms
{
    public partial class SourceAnalyzer : Form
    {

        SaveFileDialog sfd = new SaveFileDialog();

        public SourceAnalyzer()
        {
            InitializeComponent();
        }

        private void SourceAnalyzer_Load(object sender, EventArgs e)
        {
            foreach (Source src in Lists.Sources)
                lvSources.Items.Add(new ListViewItem(new string[] { src.url, src.response_time.ToString(), src.proxies_gathered.ToString() }));
        }

        private void btnDeleteEmpty_Click(object sender, EventArgs e)
        {
            lvSources.Items.Clear();
            Lists.Sources.RemoveAll(src => src.proxies_gathered == 0);

            foreach (Source src in Lists.Sources)
                lvSources.Items.Add(new ListViewItem(new string[] { src.url, src.response_time.ToString(), src.proxies_gathered.ToString() }));
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lvSources.SelectedItems)
            {
                Lists.Sources.RemoveAll(src => lvi.Text == src.url);
            }
            lvSources.Items.Clear();
            foreach (Source src in Lists.Sources)
                lvSources.Items.Add(new ListViewItem(new string[] { src.url, src.response_time.ToString(), src.proxies_gathered.ToString() }));
        }

        private void btnSaveSources_Click(object sender, EventArgs e)
        {
            sfd.FileName = "sources.txt";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach(Source src in Lists.Sources)
                        sw.WriteLine(src.url);
                }
            }
        }
    }
}
