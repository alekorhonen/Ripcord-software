using Ripcord.Assets.Globals;
using Ripcord.Assets.Libraries;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ripcord.Assets.Forms
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            Create_Assets();
        }

        public string _directory = Environment.CurrentDirectory + "\\assets\\";
        public List<string> ports = new List<string>(new string[] {"8080","443","80","3128","8888","8101","8123","9000","84","8118","8008","3129","81","9090","9999","8090","4444","5007","8828","5070","8081","808","9797","8089","8088","5601","8000","1080","88","8083","8909","8082","800","3127","3124","8998","4000","7004","9145","3125"});

        void UpdateLabel(Label lb, string value)
        {
            lb.Text = value;
        }

        void Create_Assets()
        {
            string _ports = _directory + "ports.txt";
            string _sources = _directory + "sources.txt";
            string _proxies = _directory + "proxies.txt";
            txtProgress.Text += "Checking directories..." + Environment.NewLine;
            if (Directory.Exists(_directory))
            {
                txtProgress.Text += "Directory created." + Environment.NewLine;
                Directory.CreateDirectory(_directory);
            } else
                txtProgress.Text += "Directory found." + Environment.NewLine;

            pbProgress.Value++;

            if (!File.Exists(_ports))
            {
                File.CreateText(_ports);
                using (var tw = new StreamWriter(_ports, true))
                {
                    foreach (string port in ports)
                        tw.WriteLine(port);
                    tw.Close();
                }
                txtProgress.Text += "Asset file ports.txt created (1/3)." + Environment.NewLine;
            } else
                txtProgress.Text += "Asset file ports.txt found." + Environment.NewLine;

            pbProgress.Value++;

            if (!File.Exists(_sources))
            {
                File.CreateText(_sources);
                txtProgress.Text += "Asset file sources.txt created (2/3)." + Environment.NewLine;
            } else
                txtProgress.Text += "Asset file sources.txt found." + Environment.NewLine;

            pbProgress.Value++;

            if (!File.Exists(_proxies))
            {
                File.CreateText(_proxies);
                txtProgress.Text += "Asset file proxies.txt created (3/3)." + Environment.NewLine;
            } else
                txtProgress.Text += "Asset file proxies.txt found." + Environment.NewLine;

            pbProgress.Value++;

            txtProgress.Text += "Loading all harvesters." + Environment.NewLine;
            foreach (string file in Directory.EnumerateFiles(_directory + "\\harvesters", "*.ini"))
            {
                var configuration = new IniFile(file);
                if(configuration.KeyExists("Name", "Default")
                    && configuration.KeyExists("Query", "Default")
                    && configuration.KeyExists("PStart", "Default") 
                    && configuration.KeyExists("PInc", "Default")
                    && configuration.KeyExists("PEnd", "Default")
                    && configuration.KeyExists("Regex", "Default")
                    && configuration.KeyExists("Enabled", "Default"))
                {
                    Engine engine = new Engine(configuration.Read("Name", "Default"));
                    engine.File_name = Path.GetFileName(file);
                    engine.Query_string = configuration.Read("Query", "Default");
                    engine.Page_start = Convert.ToInt32(configuration.Read("PStart", "Default"));
                    engine.Page_end = Convert.ToInt32(configuration.Read("PEnd", "Default"));
                    engine.Page_increment = Convert.ToInt32(configuration.Read("PInc", "Default"));
                    engine.Regex = configuration.Read("Regex", "Default");
                    engine.RegexValueType = Convert.ToInt32(configuration.Read("RegexValueType", "Default"));
                    engine.GroupsNum = Convert.ToInt32(configuration.Read("GroupsNum", "Default"));
                    engine.URLMustContain = configuration.Read("MustContain", "Default");
                    engine.URLMustNotContain = configuration.Read("MustNotContain", "Default");
                    engine.AddBeforeURL = configuration.Read("AddBeforeURL", "Default");
                    if (configuration.Read("EnableKeywords", "Default") == "1")
                        engine.EnableKeywords = true;
                    else
                        engine.EnableKeywords = false;
                    if (configuration.Read("Enabled", "Default") == "1")
                        engine.Enabled = true;
                    else
                        engine.Enabled = false;
                    Lists.Engines.Add(engine);
                    engine = null;
                }
                configuration = null;
            }
            txtProgress.Text += string.Format("{0} Harvesters loaded.", Lists.Engines.Count) + Environment.NewLine;
            pbProgress.Value++;
            txtProgress.Text += "Ripcord initiated, ready for use." + Environment.NewLine;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
		}
    }
}
