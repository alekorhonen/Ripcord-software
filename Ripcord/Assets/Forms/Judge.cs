using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Ripcord.Assets.Forms
{
    public partial class Judge : Form
    {
        int _retries = 3;
        string proxy = "";

        public Judge(string proxy)
        {
            InitializeComponent();
            this.proxy = proxy;
        }

        private string JudgeProxy(string proxy)
        {
            while (_retries > 0)
            {
                try
                {
                    HttpWebRequest httpWebRequest1 = (HttpWebRequest)WebRequest.Create(Globals.Globals.Judge.Replace("<IP>", proxy.Split(':')[0]).Replace("<PORT>", proxy.Split(':')[1]));
                    httpWebRequest1.Proxy = new WebProxy(proxy);
                    httpWebRequest1.Timeout = Globals.Globals.timeout * 1000;
                    httpWebRequest1.KeepAlive = false;

                    using (WebResponse response = httpWebRequest1.GetResponse())
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            using (StreamReader streamReader = new StreamReader(responseStream))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                } catch
                {
                    _retries--;
                }

                JudgeProxy(proxy);
            }

            return "Could not judge!";
        }

        private void Judge_Load(object sender, EventArgs e)
        {
            var jdg = JudgeProxy(proxy);
            if (jdg != "Could not judge!")
                srcJudge.Text = JudgeProxy(proxy);
            else
            {
                MessageBox.Show("An unknown error has occured while trying to judge the proxy!", "Ripcord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                srcJudge.Text = "Couldn't judge the proxy.";
            }
        }
    }
}
