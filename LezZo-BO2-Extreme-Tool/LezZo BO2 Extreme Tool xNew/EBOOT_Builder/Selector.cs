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

namespace LezZo_BO2_Extreme_Tool_xNew.EBOOT_Builder
{
    public partial class Selector : DevExpress.XtraEditors.XtraForm
    {
        public Selector()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BO2.EBOOTtype = "MP";
            EB_Bl EBL = new EB_Bl();
            EBL.Show();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BO2.EBOOTtype = "ZM";
            EB_Bl EBL = new EB_Bl();
            EBL.Show();
            this.Close();
        }
    }
}