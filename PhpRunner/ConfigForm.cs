using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhpRunner.utility;

namespace PhpRunner
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        public Form1 g_form;
        public ConfigForm(Form1 form)
        {
            InitializeComponent();
            g_form = form;
            LoadInfo();
        }

        private void LoadInfo()
        {
            url1.Text = util.ENV[0].url;
            url2.Text = util.ENV[1].url;
            url3.Text = util.ENV[2].url;
            interval1.Value = util.ENV[0].interval;
            interval2.Value = util.ENV[1].interval;
            interval3.Value = util.ENV[2].interval;
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            util.ENV[0].url = url1.Text;
            util.ENV[1].url = url2.Text;
            util.ENV[2].url = url3.Text;
            util.ENV[0].interval = (int)interval1.Value;
            util.ENV[1].interval = (int)interval2.Value;
            util.ENV[2].interval = (int)interval3.Value;

            util.Save_ENV();
            g_form.RefreshBrowsers();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
