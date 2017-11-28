using Ripcord.Assets.Globals;
using Ripcord.Assets.Libraries;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ripcord.Assets.Forms
{
    public partial class URLHarvester : Form
    {
        public URLHarvester()
        {
            InitializeComponent();
        }

        void Enable()
        {
            gbDetails.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
        }

        void Disable()
        {
            gbDetails.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void URLHarvester_Load(object sender, EventArgs e)
        {

            foreach (Engine eng in Lists.Engines)
            {
                if(eng.Enabled)
                    clbEngines.Items.Add(eng.Display_name, true);
                else
                    clbEngines.Items.Add(eng.Display_name, false);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int count = clbEngines.Items.Count - 1;
            for (int i = 0; i < count; i++)
            {
                Engine engine = Lists.Engines.FirstOrDefault(x => x.Display_name == clbEngines.Items[i].ToString());
                if (clbEngines.GetItemCheckState(2) == CheckState.Checked)
                {
                    engine.Enabled = true;
                }
                else
                    engine.Enabled = false;
            }
            this.Close();
        }

        private void clbEngines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbEngines.SelectedItems.Count > 0)
            {
                Enable();
                Engine engine = Lists.Engines.FirstOrDefault(x => x.Display_name == clbEngines.SelectedItem.ToString());
                txtDisplayName.Text = engine.Display_name;
                txtQueryString.Text = engine.Query_string;
                numStartPage.Value = engine.Page_start;
                numEndPage.Value = engine.Page_end;
                numIncPage.Value = engine.Page_increment;
                txtRegex.Text = engine.Regex;
                txtMustContain.Text = engine.URLMustContain;
                txtMustNotContain.Text = engine.URLMustNotContain;
                txtAddBeforeLink.Text = engine.AddBeforeURL;
                if (engine.RegexValueType == 1)
                    rbRegexGroups.Checked = true;
                else
                    rbRegexValue.Checked = true;
                if (engine.EnableKeywords)
                    cbEnableKeywords.Checked = true;
                else
                    cbEnableKeywords.Checked = false;
                numRegexGroup.Value = engine.GroupsNum;
            }
            else
                Disable();
        }

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDisplayName.Text = "";
            txtQueryString.Text = "";
            numStartPage.Value = 0;
            numEndPage.Value = 0;
            numIncPage.Value = 0;
            txtRegex.Text = "";
            txtMustContain.Text = "";
            txtMustNotContain.Text = "";
            cbEnableKeywords.Checked = false;
            Enable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Engine engine = new Engine(txtDisplayName.Text);
            engine.Query_string = txtQueryString.Text;
            engine.Page_start = Convert.ToInt32(numStartPage.Value);
            engine.Page_end = Convert.ToInt32(numEndPage.Value);
            engine.Page_increment = Convert.ToInt32(numIncPage.Value);
            engine.Regex = txtRegex.Text;
            engine.URLMustContain = txtMustContain.Text;
            engine.URLMustNotContain = txtMustNotContain.Text;
            engine.AddBeforeURL = txtAddBeforeLink.Text;
            engine.File_name = txtDisplayName.Text + ".ini";
            if (cbEnableKeywords.Checked)
                engine.EnableKeywords = true;
            else
                engine.EnableKeywords = false;
            IniFile ini = new IniFile(Environment.CurrentDirectory + "\\assets\\harvesters\\" + txtDisplayName.Text + ".ini");
            ini.Write("Name", txtDisplayName.Text, "Default");
            ini.Write("Query", txtQueryString.Text, "Default");
            ini.Write("PStart", numStartPage.Value.ToString(), "Default");
            ini.Write("PInc", numIncPage.Value.ToString(), "Default");
            ini.Write("PEnd", numEndPage.Value.ToString(), "Default");
            ini.Write("Regex", txtRegex.Text, "Default");
            if (rbRegexGroups.Checked)
                ini.Write("RegexValueType", "1", "Default");
            else
                ini.Write("RegexValueType", "0", "Default");
            ini.Write("GroupsNum", numRegexGroup.Value.ToString(), "Default");
            ini.Write("MustContain", txtMustContain.Text, "Default");
            ini.Write("MustNotContain", txtMustNotContain.Text, "Default");
            ini.Write("AddBeforeURL", txtAddBeforeLink.Text, "Default");
            if(cbEnableKeywords.Checked)
                ini.Write("EnableKeywords", "1", "Default");
            else
                ini.Write("EnableKeywords", "0", "Default");
            ini.Write("Enabled", "1", "Default");
            Lists.Engines.Add(engine);
            clbEngines.Items.Add(txtDisplayName.Text);
            Disable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clbEngines.SelectedItems.Count > 0)
            {
                Engine engine = Lists.Engines.FirstOrDefault(x => x.Display_name == clbEngines.SelectedItem.ToString());
                string filename = Environment.CurrentDirectory + "\\assets\\harvesters\\" + engine.File_name;
                engine.Query_string = txtQueryString.Text;
                engine.Page_start = Convert.ToInt32(numStartPage.Value);
                engine.Page_end = Convert.ToInt32(numEndPage.Value);
                engine.Page_increment = Convert.ToInt32(numIncPage.Value);
                engine.Regex = txtRegex.Text;
                engine.GroupsNum = Convert.ToInt32(numRegexGroup.Value);
                if (rbRegexGroups.Checked)
                    engine.RegexValueType = 1;
                else
                    engine.RegexValueType = 0;
                engine.URLMustContain = txtMustContain.Text;
                engine.URLMustNotContain = txtMustNotContain.Text;
                engine.AddBeforeURL = txtAddBeforeLink.Text;
                if (cbEnableKeywords.Checked)
                    engine.EnableKeywords = true;
                else
                    engine.EnableKeywords = false;


                File.Delete(filename);
                IniFile ini = new IniFile(filename);
                ini.Write("Name", txtDisplayName.Text, "Default");
                ini.Write("Query", txtQueryString.Text, "Default");
                ini.Write("PStart", numStartPage.Value.ToString(), "Default");
                ini.Write("PInc", numIncPage.Value.ToString(), "Default");
                ini.Write("PEnd", numEndPage.Value.ToString(), "Default");
                ini.Write("Regex", txtRegex.Text, "Default");
                if (rbRegexGroups.Checked)
                    ini.Write("RegexValueType", "1", "Default");
                else
                    ini.Write("RegexValueType", "0", "Default");
                ini.Write("GroupsNum", numRegexGroup.Value.ToString(), "Default");
                ini.Write("MustContain", txtMustContain.Text, "Default");
                ini.Write("MustNotContain", txtMustNotContain.Text, "Default");
                ini.Write("AddBeforeURL", txtAddBeforeLink.Text, "Default");
                if(cbEnableKeywords.Checked)
                    ini.Write("EnableKeywords", "1", "Default");
                else
                    ini.Write("EnableKeywords", "0", "Default");
                ini.Write("Enabled", "1", "Default");
            }

        }

        private void btnTestHarvester_Click(object sender, EventArgs e)
        {

            Engine engine = Lists.Engines.FirstOrDefault(x => x.Display_name == clbEngines.SelectedItem.ToString());
            TestHarvester test = new TestHarvester(engine);
            test.Show();
        }
    }
}
