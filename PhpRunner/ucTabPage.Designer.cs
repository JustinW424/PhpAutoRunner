namespace PhpRunner
{
    partial class ucTabPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.totalTimes = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(555, 353);
            this.webBrowser.TabIndex = 0;
            // 
            // totalTimes
            // 
            this.totalTimes.AutoSize = true;
            this.totalTimes.BackColor = System.Drawing.Color.White;
            this.totalTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimes.Location = new System.Drawing.Point(170, 49);
            this.totalTimes.Name = "totalTimes";
            this.totalTimes.Size = new System.Drawing.Size(193, 18);
            this.totalTimes.TabIndex = 8;
            this.totalTimes.Text = "This script has been opened";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.BackColor = System.Drawing.Color.White;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(179, 22);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(132, 18);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "url: localhost/1.php";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(10, 77);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(522, 265);
            this.logBox.TabIndex = 6;
            this.logBox.Text = "";
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ucTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalTimes);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.webBrowser);
            this.Name = "ucTabPage";
            this.Size = new System.Drawing.Size(555, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label totalTimes;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Timer timer;
    }
}
