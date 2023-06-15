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

namespace LezZo_BO2_Extreme_Tool_xNew.ModMenuManager
{
    public partial class FTPConnect : DevExpress.XtraEditors.XtraForm
    {
        public FTPConnect()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BO2.BO2ConnFTP(textEdit1.Text);
            this.Close();
        }
    }
}