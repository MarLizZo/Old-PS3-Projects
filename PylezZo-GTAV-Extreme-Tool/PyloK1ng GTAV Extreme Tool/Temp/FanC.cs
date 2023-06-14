using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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

namespace PylezZo_GTAV_Extreme_Tool.Temp
{
    public partial class FanC : DevExpress.XtraEditors.XtraForm
    {
        public FanC()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textEdit1.Text + "/cpursx.ps3?up");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textEdit1.Text + "/cpursx.ps3?dn");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("You need to have webMAN MOD installed on your PS3. \nCheck the IP Address of your PS3 in System Information on the XMB Settings - System Settings. \nThen insert it in the textBox. That's all :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void FanC_Load(object sender, EventArgs e)
        {

        }
    }
}