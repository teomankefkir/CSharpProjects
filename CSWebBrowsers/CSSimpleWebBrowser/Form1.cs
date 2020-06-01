using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSimpleWebBrowser
{
    public partial class frmSimpleWebBrowser : Form
    {
        public frmSimpleWebBrowser()
        {
            InitializeComponent();
        }

        //form load
        private void frmSimpleWebBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
            toolStripProgressBar1.Visible = false;
        }

        //button home
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
           //webBrowser1.GoHome("https://www.google.com/");
        }

        //button refresh        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        //button back
        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //button forward
        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        //button go
        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBoxLink.Text);
            this.Text = webBrowser1.DocumentTitle.ToString();
        }

        //button stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        //full link text
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            comboBoxLink.Text = webBrowser1.Url.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusProcess.Text = webBrowser1.StatusText;
        }

        //progress
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Visible = true;
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = false;
            }
        }
    }
}