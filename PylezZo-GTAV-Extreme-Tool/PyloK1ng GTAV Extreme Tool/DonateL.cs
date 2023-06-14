using System;
using System.IO;

namespace PylezZo_GTAV_Extreme_Tool
{
    public partial class DonateL : DevExpress.XtraEditors.XtraForm
    {
        public DonateL()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                Directory.CreateDirectory(Path.GetTempPath() + "PyloL");
                File.WriteAllText(Path.GetTempPath() + "PyloL\\settings.txt", "disabled");
            }

            this.Hide();
            Main main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/CyberModding");
        }
    }
}
