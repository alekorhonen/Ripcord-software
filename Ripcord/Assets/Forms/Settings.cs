using Ripcord.Assets.Globals;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ripcord.Assets.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnGetIP_Click(object sender, EventArgs e)
        {
            txtIPAddress.Text = Helpers.GetIP();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            Globals.Globals.Bots = Convert.ToInt32(numThreads.Value);
            Globals.Globals.timeout = Convert.ToInt32(numTimeout.Value);
            Globals.Globals.retries = Convert.ToInt32(numRetries.Value);
            Globals.Globals.Disable_listview = cbDisableListview.Checked;
            Globals.Globals.IPAddress = txtIPAddress.Text;
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            numThreads.Value = Globals.Globals.Bots;
            numTimeout.Value = Globals.Globals.timeout;
            numRetries.Value = Globals.Globals.retries;
            cbDisableListview.Checked = Globals.Globals.Disable_listview;
            txtIPAddress.Text = Globals.Globals.IPAddress;
        }
    }
}
