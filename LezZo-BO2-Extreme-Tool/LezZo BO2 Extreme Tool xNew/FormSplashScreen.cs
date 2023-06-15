using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
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

namespace LezZo_BO2_Extreme_Tool_xNew
{
    public partial class FormSplashScreen : SplashScreen
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void FormSplashScreen_Shown(object sender, EventArgs e)
        {
            
        }
    }
}