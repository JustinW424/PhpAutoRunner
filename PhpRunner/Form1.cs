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
    public partial class Form1 : Form
    {
        public bool hidden = false;
        public bool quitFlag = false;
        public Form1()
        {
            InitializeComponent();

            InitTabControl();
        }
        public int[] g_times = new int[3];

        //user control array: each one for each tab page
        private ucTabPage[] g_ucTabPages = new ucTabPage[3];

        //tab pages on the tab control. each tab for each url
        public TabPage[] tabPages;
        public void InitTabControl()
        {
            for(int i = 0; i < 3; i++)
            {
                TabPage tabPage = new TabPage($"Script{i + 1}");
                ucTabPage w_ucTabPage = new ucTabPage(this, i);
                w_ucTabPage.Dock = DockStyle.Fill;
                g_ucTabPages[i] = w_ucTabPage;
                tabPage.Controls.Add(w_ucTabPage);

                tabControl1.TabPages.Add(tabPage);
            }
        }


        public void RefreshBrowsers()
        {
            for(int i = 0; i < 3; i++)
            {
                g_ucTabPages[i].RefreshScreen();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            util.Load_ENV();
            this.ShowInTaskbar = false;
            RefreshBrowsers();
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeVisibility();
        }

        private void settingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm(this);
            configForm.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitFlag = true;
            this.Close();
        }

        private void changeVisibility()
        {
            if (hidden)
            {
                this.Show();
                this.TopMost = true;
                hidden = !hidden;
            }
            else
            {
                this.Hide();
                hidden = !hidden;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!quitFlag)
            {
                this.Hide();
                hidden = true;
                e.Cancel = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            changeVisibility();
        }
    }
}
