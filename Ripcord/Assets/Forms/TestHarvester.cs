using Ripcord.Assets.Libraries;
using Ripcord.Assets.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ripcord.Assets.Forms
{
    public partial class TestHarvester : Form
    {
        Engine engine;

        public TestHarvester(Engine engine)
        {
            InitializeComponent();
            this.engine = engine;
        }

        private void TestHarvester_Load(object sender, EventArgs e)
        {
            if (engine.Page_end > 0) {
                for (int i = engine.Page_start; i < engine.Page_end + 1; i += engine.Page_increment)
                {
                    try
                    {
                        var test = Harvester.Harvest(engine, "", i);
                        foreach (Source x in test)
                            textBox1.Text += x.url + Environment.NewLine;
                    }
                    catch
                    {
                        MessageBox.Show("An unknown error occured while harvesting sources.");
                    }
                }
            } else
            {
                try
                {
                    var test = Harvester.Harvest(engine, "", 0);
                    foreach (Source x in test)
                        textBox1.Text += x.url + Environment.NewLine;
                }
                catch
                {
                    MessageBox.Show("An unknown error occured while harvesting sources.");
                }
            }
        }
    }
}
