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
using PylezZo_GTAV_Extreme_Tool.Pylo;

namespace PylezZo_GTAV_Extreme_Tool.EBOOTS
{
    public partial class FTPConnectEB : DevExpress.XtraEditors.XtraForm
    {
        public FTPConnectEB()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Functions.RPCFunc.FTPCoEB(textEdit1.Text);
            this.Close();
        }
    }
}