using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhpRunner.utility;
using System.Net.Http;

namespace PhpRunner
{
    public partial class ucTabPage : UserControl
    {
        public ucTabPage()
        {
            InitializeComponent();
        }
        private Form1 g_form;
        private int g_num = 0;
        private int g_totalTimes = 0;
        private DateTime g_time;

        //constructor: parent form,  the number of tab page for this on parent tab control
        // use these info to communicate with parent form
        public ucTabPage(Form1 form, int num)
        {
            InitializeComponent();
            timer.Start();
            g_form = form;
            g_num = num;
        }

        /*
         * RefreshScreen()
         *function: refresh the screen with new config info
         *  step1: stop timer and hide and clear all controls in this to erase history.
         *  step2: check url to present on browser
         *          1.true --> set timer with new info, call startScript() to show info.
         *          2.false --> hide and clear all controls.
         */
        public void RefreshScreen()
        {
            timer.Stop();
            HideControl();

            if (!string.IsNullOrEmpty(util.ENV[g_num].url))
            {
                ShowControl();
                timer.Interval = util.ENV[g_num].interval * 1000;
                timer.Start();
                startScript();
            }
            else
                HideControl();
        }

        public void ShowControl()
        {
            foreach (Control ctrl in this.Controls)
                ctrl.Show();
        }
        public void HideControl()
        {
            g_totalTimes = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() != typeof(WebBrowser))
                    ctrl.Text = string.Empty;
                ctrl.Hide();
            }
        }

        /*
         **UpdateScreen(bool flag)
         * function: update script info
         * param : bool --> flag to check whether script executed successfully 
         */
        public void UpdateScreen(bool flag)
        {
            g_totalTimes ++;
            g_time = DateTime.Now;
            urlLabel.Text = $"URL : {util.ENV[g_num].url}";
            totalTimes.Text = $"The Script has opened {g_totalTimes.ToString()} times.";
            if (flag)
                logBox.Text += $"{DateTime.Now.ToString()} Script Executed Successfully.\n";
            else
                logBox.Text += $"{DateTime.Now.ToString()} Script Failed.\n";
                
        }

        /*
         * **** USING HttpClient ****
         * startScript()
         * 
         *  function : check if http request success and then update screen 
         */
        static readonly HttpClient client = new HttpClient();
        private async void startScript()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(util.ENV[g_num].url);
                webBrowser.Navigate(util.ENV[g_num].url);
                UpdateScreen(true);

            }
            catch (Exception e)
            {
                UpdateScreen(false);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            startScript();
        }
    }
}
