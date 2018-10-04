using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hdsdump
{
    public partial class MainForm : Form
    {
        public delegate void ConfirmDownloadEvent(string url, string outfile);
        public event ConfirmDownloadEvent OnConfirm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if(this.OnConfirm != null)
            {
                this.OnConfirm(textURL.Text, textOutputFile.Text);
                this.Close();
            }
        }
    }
}
