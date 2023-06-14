using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.Printing;
using DevExpress.Sparkline;
using DevExpress.XtraSplashScreen;
using DevExpress.Sparkline.Core;
using DevExpress.XtraBars;
using PS3ManagerAPI;

namespace PS3_Temp
{
    public partial class WarningTemp : Form
    {

        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();

        public WarningTemp()
        {
            InitializeComponent();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarningTemp_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            System.Threading.Thread.Sleep(800);
            System.Media.SystemSounds.Beep.Play();
            System.Threading.Thread.Sleep(800);
            System.Media.SystemSounds.Beep.Play();
            System.Threading.Thread.Sleep(800);
            System.Media.SystemSounds.Beep.Play();
            PS3M_API.PS3.Notify("High Temperature!!");
        }
    }
}
