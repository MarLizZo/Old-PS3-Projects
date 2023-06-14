using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using DevExpress;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.UserSkins;
using DevExpress.Printing;
using DevExpress.Sparkline;
using DevExpress.XtraSplashScreen;
using DevExpress.Sparkline.Core;
using DevExpress.XtraTab;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;

namespace PylezZo_GTAV_Extreme_Tool
{
    public partial class UpdateForm : DevExpress.XtraEditors.XtraForm
    {
        public UpdateForm()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string URL = "https://www.cybermodding.it/PylezZo-Tool/";
            string appName = "PylezZo_GTAV_Tool_Update.rar";

            WebClient webc = new WebClient();
            webc.DownloadFileAsync(new Uri(URL + appName), appName);
            webc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDown);
            webc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressUpd);
        }

        private void DownloadProgressUpd(object sender, DownloadProgressChangedEventArgs e)
        {
            labelControl3.Text = e.TotalBytesToReceive.ToString();
            labelControl4.Text = e.BytesReceived.ToString();
            progressBarControl1.EditValue = e.ProgressPercentage;
        }

        private void CompletedDown(object sender, AsyncCompletedEventArgs e)
        {
            XtraMessageBox.Show("Download Completed !! \nRun the new Updated Tool and Enjoy :) \nYou will find the new Update in the Tool Folder!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            System.Threading.Thread.Sleep(1000);
            Application.Exit();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            simpleButton1_Click(sender, e);
        }
    }
}