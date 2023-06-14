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
    public partial class FirstWarning : DevExpress.XtraEditors.XtraForm
    {
        public FirstWarning()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstWarning_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            System.Threading.Thread.Sleep(800);
            System.Media.SystemSounds.Beep.Play();
            System.Threading.Thread.Sleep(800);
            System.Media.SystemSounds.Beep.Play();
            Main.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.CAUTION, "High Temperature!!");
        }
    }
}