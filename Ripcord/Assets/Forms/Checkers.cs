using Ripcord.Assets.Globals;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ripcord.Assets.Forms
{
    public partial class Checkers : Form
    {
        public Checkers()
        {
            InitializeComponent();

            txtJudgeURL.Text = Globals.Globals.Judge;
            cbSSL.Checked = Globals.Globals.SSL_check;
            txtSSLUrl.Text = Globals.Globals.SSL;
            txtSSLKeyword.Text = Globals.Globals.SSL_keyword;
            txtGeolocation.Text = Globals.Globals.Geolocation;
            txtGeoCountry.Text = Globals.Globals.Geolocation_country;
            txtGeoRegion.Text = Globals.Globals.Geolocation_region;
            txtGeoCity.Text = Globals.Globals.Geolocation_city;
        }

        private void btnTestJudge_Click(object sender, EventArgs e)
        {
            bool check = Helpers.CheckJudge(txtJudgeURL.Text);
            if(check)
            {
                lblJudgeStatus.Text = "Working";
                lblJudgeStatus.ForeColor = Color.Green;
            } else
            {
                lblJudgeStatus.Text = "Not working";
                lblJudgeStatus.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Globals.Globals.Judge = txtJudgeURL.Text;
            Globals.Globals.SSL_check = cbSSL.Checked;
            Globals.Globals.SSL = txtSSLUrl.Text;
            Globals.Globals.SSL_keyword = txtSSLKeyword.Text;
            Globals.Globals.Geolocation = txtGeolocation.Text;
            Globals.Globals.Geolocation_country = txtGeoCountry.Text;
            Globals.Globals.Geolocation_region = txtGeoRegion.Text;
            Globals.Globals.Geolocation_city = txtGeoCity.Text;
        }
    }
}
