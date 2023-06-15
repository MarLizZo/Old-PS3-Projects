using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
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
using LezZo_BO2_Extreme_Tool_xNew.Properties;
using PS3Lib;
using LezZo_BO2_Extreme_Tool_xNew.ModMenuManager;

namespace LezZo_BO2_Extreme_Tool_xNew.ModMenuManager
{
    public partial class ModMenu : DevExpress.XtraEditors.XtraForm
    {
        public ModMenu()
        {
            InitializeComponent();
        }

        WebClient wc = new WebClient();
        private bool isgscwebfree = true;
        private bool SPRXwebfree = true;
        private bool isgamemwebfree = true;
        private static PS3API PS3 = new PS3API();
        public static FTPclient FtpClient;
        private string sprxnameuploaded = "BO2.sprx";
        private static string directory;

        private void ModMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
            }
        }

        private void ModMenu_Shown(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit3.SelectedIndex == 0)
            {
                comboBoxEdit1.Properties.Items.Clear();
                comboBoxEdit1.Properties.Items.Insert(0, "All You Need Menu");
                comboBoxEdit1.Properties.Items.Insert(1, "Host Only's Private Patch");
                comboBoxEdit1.Properties.Items.Insert(2, "Neptune Menu");
                comboBoxEdit1.Properties.Items.Insert(3, "Red Tears v2.1 Menu");
                comboBoxEdit1.Properties.Items.Insert(4, "Bossam v6");
                comboBoxEdit1.Properties.Items.Insert(5, "UMT Menu");
                comboBoxEdit1.Properties.Items.Insert(6, "White Water v5.5 Menu");
                comboBoxEdit1.Properties.Items.Insert(7, "VWS Menu");
                comboBoxEdit1.Properties.Items.Insert(8, "xRaw v7 Menu");
                comboBoxEdit1.Properties.Items.Insert(9, "Infinity v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(10, "Excellent v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(11, "Lost Memories v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(12, "Project Aqua Menu");
                comboBoxEdit1.Properties.Items.Insert(13, "Project Old School Menu");
                comboBoxEdit1.Properties.Items.Insert(14, "oCmKs Private Patch");
                comboBoxEdit1.Properties.Items.Insert(15, "Alca v3 Menu");
                comboBoxEdit1.Properties.Items.Insert(16, "Bareface Leo v2.4 Menu");
                comboBoxEdit1.Properties.Items.Insert(17, "xTayTay Menu");
                comboBoxEdit1.Properties.Items.Insert(18, "Extinct's S&D v3 Menu");
                comboBoxEdit1.Properties.Items.Insert(19, "Caked Up v1.8 Menu");
                comboBoxEdit1.Properties.Items.Insert(20, "Unknown Menu");
                comboBoxEdit1.Properties.Items.Insert(21, "Elegance v5 Menu");
                comboBoxEdit1.Properties.Items.Insert(22, "ReplayModdingTeam Menu");
                comboBoxEdit1.Properties.Items.Insert(23, "iPodModz v2.1 Menu");
                comboBoxEdit1.Properties.Items.Insert(24, "Encore v6.41 Menu");
                comboBoxEdit1.Properties.Items.Insert(25, "RDC v3 Menu");
                comboBoxEdit1.Properties.Items.Insert(26, "Velocity v2 Menu");
                comboBoxEdit1.Properties.Items.Insert(27, "Togheter Menu");
                comboBoxEdit1.Properties.Items.Insert(28, "VenoxModdingTeam Menu");
                comboBoxEdit1.Properties.Items.Insert(29, "Dark Moon Menu");
                comboBoxEdit1.Properties.Items.Insert(30, "Typhoon Menu");
                comboBoxEdit1.Properties.Items.Insert(31, "Revolution Menu");
                comboBoxEdit1.Properties.Items.Insert(32, "Project Hiqh Menu");
                comboBoxEdit1.Properties.Items.Insert(33, "Project Hydra Menu");
                comboBoxEdit1.Properties.Items.Insert(34, "CyberGhost Menu");
                comboBoxEdit1.Properties.Items.Insert(35, "Batman v6 Menu");
                comboBoxEdit1.Properties.Items.Insert(36, "Inspire v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(37, "Exploit v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(38, "AquaModdingTeam Menu");
                comboBoxEdit1.Properties.Items.Insert(39, "Blue Sky v2 Menu");
                comboBoxEdit1.Properties.Items.Insert(40, "Dubai Swag Menu");
                comboBoxEdit1.Properties.Items.Insert(41, "Foundalized Menu");
                comboBoxEdit1.Properties.Items.Insert(42, "Loz Azza v2 Menu");
                comboBoxEdit1.Properties.Items.Insert(43, "Modding In Style Menu");
                comboBoxEdit1.Properties.Items.Insert(44, "Green Phantom Menu");
                comboBoxEdit1.Properties.Items.Insert(45, "Redemption Menu");
                comboBoxEdit1.Properties.Items.Insert(46, "Resurrect Menu");
                comboBoxEdit1.Properties.Items.Insert(47, "Ride My Bicycle Menu");
                comboBoxEdit1.Properties.Items.Insert(48, "PlasmaMods Trickshot Menu");
                comboBoxEdit1.Properties.Items.Insert(49, "UnderWater v3 Menu");
                comboBoxEdit1.Properties.Items.Insert(50, "Project Rooster v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(51, "Profound v2.1.2 Menu");
                comboBoxEdit1.Properties.Items.Insert(52, "SynthBreaker Menu");
                comboBoxEdit1.Properties.Items.Insert(53, "Sagittarius v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(54, "Panacea v1 Menu");
                comboBoxEdit1.Properties.Items.Insert(55, "ArroGanT v2 Menu");
                comboBoxEdit1.Properties.Items.Insert(56, "Green Mist Menu");
                comboBoxEdit1.Properties.Items.Insert(57, "Tahhr v2.2 Menu");
            }
            else if (comboBoxEdit3.SelectedIndex == 1)
            {
                comboBoxEdit1.Properties.Items.Clear();
                comboBoxEdit1.Properties.Items.Insert(0, "Pegasus v2 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(1, "Fenix v5 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(2, "Encore v9 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(3, "Peschi Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(4, "Rawdog Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(5, "Conversion v1 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(6, "Disection Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(7, "Hells Vengeance v4 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(8, "I am Zombie v2 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(9, "RTM v2.6 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(10, "Vibenation Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(11, "oCmKs Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(12, "Gr3Zz Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(13, "Project Iconic Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(14, "Project Iconic Sentinel Menu");
                comboBoxEdit1.Properties.Items.Insert(15, "Red Evil Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(16, "CampaLand v1 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(17, "Fearness v1.3 Zombie Menu");
                comboBoxEdit1.Properties.Items.Insert(18, "Infection v1.1 Zombie Menu");
            }
            comboBoxEdit1.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            labelControl6.Text = "...";
            simpleButton1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox72.Visible = false;
            pictureBox73.Visible = false;
            pictureBox74.Visible = false;
            pictureBox75.Visible = false;
            pictureBox76.Visible = false;
            pictureBox77.Visible = false;
            pictureBox78.Visible = false;
            pictureBox79.Visible = false;
            pictureBox80.Visible = false;
            pictureBox81.Visible = false;
            pictureBox82.Visible = false;
            pictureBox83.Visible = false;
            pictureBox84.Visible = false;
            pictureBox85.Visible = false;
            pictureBox86.Visible = false;
            pictureBox87.Visible = false;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            simpleButton1.Visible = true;

            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 6)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 7)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 8)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 9)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 10)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 11)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 12)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 13)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 14)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 15)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = true;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 16)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = true;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 17)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = true;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 18)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = true;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 19)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = true;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 20)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = true;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 21)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = true;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 22)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = true;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 23)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = true;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 24)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = true;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 25)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = true;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 26)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = true;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 27)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = true;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 28)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = true;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 29)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = true;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 30)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = true;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 31)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = true;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 32)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = true;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 33)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = true;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 34)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = true;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 35)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = true;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 36)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = true;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 37)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = true;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 38)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = true;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 39)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = true;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 40)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = true;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 41)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = true;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 42)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = true;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 43)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = true;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 44)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = true;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 45)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = true;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 46)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = true;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 47)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = true;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 48)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = true;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 49)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = true;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 50)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = true;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 51)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = true;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 52)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = true;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 53)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = true;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 54)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = true;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 55)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = true;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 56)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = true;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 57)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = true;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }

            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = true;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = true;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = true;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = true;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = true;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = true;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 6)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = true;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 7)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = true;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 8)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = true;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 9)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = true;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 10)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = true;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 11)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = true;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 12)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = true;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 13)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = true;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 14)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = true;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 15)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = true;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 16)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = true;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 17)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = true;
                pictureBox87.Visible = false;
            }
            if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 18)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
                pictureBox30.Visible = false;
                pictureBox31.Visible = false;
                pictureBox32.Visible = false;
                pictureBox33.Visible = false;
                pictureBox34.Visible = false;
                pictureBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                pictureBox46.Visible = false;
                pictureBox47.Visible = false;
                pictureBox48.Visible = false;
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                pictureBox57.Visible = false;
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
                pictureBox62.Visible = false;
                pictureBox63.Visible = false;
                pictureBox64.Visible = false;
                pictureBox65.Visible = false;
                pictureBox66.Visible = false;
                pictureBox67.Visible = false;
                pictureBox68.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox72.Visible = false;
                pictureBox73.Visible = false;
                pictureBox74.Visible = false;
                pictureBox75.Visible = false;
                pictureBox76.Visible = false;
                pictureBox77.Visible = false;
                pictureBox78.Visible = false;
                pictureBox79.Visible = false;
                pictureBox80.Visible = false;
                pictureBox81.Visible = false;
                pictureBox82.Visible = false;
                pictureBox83.Visible = false;
                pictureBox84.Visible = false;
                pictureBox85.Visible = false;
                pictureBox86.Visible = false;
                pictureBox87.Visible = true;
            }

            if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 2)
            {
                labelControl6.Text = "Dpad UP";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 7)
            {
                labelControl6.Text = "L2";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 8)
            {
                labelControl6.Text = "R2";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 16)
            {
                labelControl6.Text = "R2 + O";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 20)
            {
                labelControl6.Text = "Dpad UP";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 22)
            {
                labelControl6.Text = "L1 + R2";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 23)
            {
                labelControl6.Text = "Dpad Right";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 24)
            {
                labelControl6.Text = "Dpad Down";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 25)
            {
                labelControl6.Text = "R2 + O";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 32)
            {
                labelControl6.Text = "Dpad Left";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 42)
            {
                labelControl6.Text = "Dpad UP";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 44)
            {
                labelControl6.Text = "Dpad UP";
            }
            else if (comboBoxEdit3.SelectedIndex == 0 && comboBoxEdit1.SelectedIndex == 45)
            {
                labelControl6.Text = "R2 + O";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 0)
            {
                labelControl6.Text = "L1 + O";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 1)
            {
                labelControl6.Text = "L1 + O";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 2)
            {
                labelControl6.Text = "Dpad Down";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 5)
            {
                labelControl6.Text = "Dpad Right";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 10)
            {
                labelControl6.Text = "Dpad Right";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 12)
            {
                labelControl6.Text = "L2";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 13)
            {
                labelControl6.Text = "R1 + R3";
            }
            else if (comboBoxEdit3.SelectedIndex == 1 && comboBoxEdit1.SelectedIndex == 16)
            {
                labelControl6.Text = "Dpad UP";
            }
            else
            {
                labelControl6.Text = "L1 + R3";
            }
        }

        private bool IsGscwebCFree()
        {
            if (isgscwebfree == true)
                return true;
            else return false;
        }

        private void CompletedDL(object sender, AsyncCompletedEventArgs e)
        {
            Thread.Sleep(1000);
            labelControl10.Text = "Download Completed !!";
            Thread.Sleep(1000);
            isgscwebfree = true;
            labelControl10.Text = "Injecting GSC Menu ...";
        }

        private void GSCDownloading(object sender, DownloadProgressChangedEventArgs e)
        {
            labelControl10.Text = "Downloading ...  " + e.ProgressPercentage.ToString() + "%";
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit3.SelectedIndex == 0)
            {
                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel1.Visible = true;
                        isgscwebfree = false;
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading); 
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/AllYouNeed/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch 
                    {
                        
                    }
                    Application.DoEvents();
                    Thread.Sleep(500);
                    
                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 1)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel1.Visible = true;
                        isgscwebfree = false;
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/HostOnlyPP/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 2)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Neptune/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 3)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/RedTears/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 4)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Bossam/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 5)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/UMT/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 6)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/WhiteWater/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 7)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/VWS/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 8)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/xRaw/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 9)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Infinity/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 10)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Excellent/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 11)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/LostMemories/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 12)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ProjectAqua/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 13)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/OldSchool/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 14)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/CmKsPP/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 15)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Alca/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 16)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Bareface/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 17)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/xTayTay/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 18)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ExtinctSD/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 19)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/CakedUp/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 20)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Unknown/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 21)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Elegance/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 22)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ReplayModdingTeam/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 23)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/iPodModz/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 24)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/EncoreMP/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 25)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/RDC/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 26)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Velocity/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 27)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Togheter/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 28)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/VenoxModdingTeam/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 29)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/DarkMoon/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 30)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Typhoon/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 31)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Revolution/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 32)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ProjectHiqh/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 33)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ProjectHydra/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 34)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/CyberGhost/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 35)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Batman/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 36)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Inspire/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 37)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Exploit/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 38)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/AquaModdingTeam/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 39)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/BlueSky/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 40)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/DubaiSwag/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 41)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Foundalized/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 42)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/LozAzza/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 43)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ModdingInStyle/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 44)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/GreenPhantom/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 45)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Redemption/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 46)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Resurrect/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 47)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/RideMyBicycle/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 48)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/PlasmaMods/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 49)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/UnderWater/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 50)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ProjectRooster/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 51)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Profound/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 52)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/SynthBreaker/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 53)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Sagittarius/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 54)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Panacea/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 55)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Arrogant/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 56)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/GreenMist/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 57)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/Tahhr/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        try
                        {
                            byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x140C2D0, buffer);
                            PS3.SetMemory(0x10040000, GSC);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectMp();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
            }

            // ZOMBIE GSC !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            else if (comboBoxEdit3.SelectedIndex == 1)
            {
                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Pegasus/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);
                    
                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 1)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Fenix/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 2)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/EncoreZM/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 3)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Peschi/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 4)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Rawdog/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 5)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Conversion/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 6)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Disection/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 7)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/HellsVengeance/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 8)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/IamZombie/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 9)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/RMT/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 10)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Vibenation/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 11)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/CmKs/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 12)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Gr3Zz/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 13)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Iconic/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 14)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/IconicSentinel/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 15)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/RedEvil/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 16)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Campa/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 17)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Fearness/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
                else if (comboBoxEdit1.SelectedIndex == 18)
                {
                    try
                    {
                        labelControl10.Text = "Downloading ..."; progressPanel1.Visible = true;
                        isgscwebfree = false; wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GSCDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDL);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/GSC/ZM/Infection/_clientids.gsc", @"downloads/_clientids.gsc");
                    }
                    catch
                    {

                    }
                    Application.DoEvents();
                    Thread.Sleep(500);

                    if (BO2.APIok == true)
                    {
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.ControlConsole);
                        }
                        else if (BO2.APIused == "TMAPI")
                        {
                            PS3.ChangeAPI(SelectAPI.TargetManager);
                        }
                        Application.DoEvents();
                        try
                        {
                            FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] buffer2 = br.ReadBytes((int)fs.Length);
                            byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                            PS3.SetMemory(0x10040000, buffer2);
                            PS3.SetMemory(0x140C4F8, buffer);
                            if (BO2.APIused == "CCAPI")
                            {
                                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                            }
                            labelControl10.Text = "GSC Menu Injected !!";
                        }
                        catch
                        {
                            InjectZm();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    progressPanel1.Visible = false;
                }
            }
        }

        private async Task DownloadMod(string url, string flnm)
        {
            await wc.DownloadFileTaskAsync(url, flnm);
        }

        private void InjectMp()
        {
            try
            {
                byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                PS3.SetMemory(0x140C2D0, buffer);
                PS3.SetMemory(0x10040000, GSC);
                if (BO2.APIused == "CCAPI")
                {
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                }
                labelControl10.Text = "GSC Menu Injected !!";
            }
            catch
            {
                XtraMessageBox.Show("Something goes wrong while Injecting, please retry !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelControl10.Text = "Error.. Please retry ...";
            }
        }

        private void InjectGM()
        {
            try
            {
                byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                PS3.SetMemory(0x140C2D0, buffer);
                PS3.SetMemory(0x10040000, GSC);
                if (BO2.APIused == "CCAPI")
                {
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                }
                labelControl10.Text = "GameMode Injected !!";
            }
            catch
            {
                XtraMessageBox.Show("Something goes wrong while Injecting, please retry !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelControl10.Text = "Error.. Please retry ...";
            }
        }

        private void InjectZm()
        {
            try
            {
                FileStream fs = new FileStream(@"downloads/_clientids.gsc", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                byte[] buffer2 = br.ReadBytes((int)fs.Length);
                byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                PS3.SetMemory(0x10040000, buffer2);
                PS3.SetMemory(0x140C4F8, buffer);
                if (BO2.APIused == "CCAPI")
                {
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GSC Mod Menu Injected :D");
                }
                labelControl10.Text = "GSC Menu Injected !!";
            }
            catch
            {
                XtraMessageBox.Show("Something goes wrong while Injecting, please retry !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelControl10.Text = "Error.. Please retry ...";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            simpleButton3.Visible = true;

            if (comboBoxEdit2.SelectedIndex == 0)
            {
                labelControl7.Text = "R3 + Dpad Down";
                pictureBox88.Visible = true;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 1)
            {
                labelControl7.Text = "R3 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = true;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 2)
            {
                labelControl7.Text = "R3 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = true;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 3)
            {
                labelControl7.Text = "Pre Game - L3  ---  InGame - R3 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = true;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 4)
            {
                labelControl7.Text = "Pre Game - R1  ---  InGame - R3 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = true;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 5)
            {
                labelControl7.Text = "Pre Game - L1 + Dpad UP  ---  InGame - L1 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = true;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 6)
            {
                labelControl7.Text = "Pre Game - R3  ---  InGame - R3 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = true;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 7)
            {
                labelControl7.Text = "Pre Game - R3 + Dpad UP  ---  InGame - R3 + Dpad UP  ---  Host InGame - Dpad Right";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = true;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 8)
            {
                labelControl7.Text = "Pre Game - Dpad Left  ---  InGame - R3 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = true;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 9)
            {
                labelControl7.Text = "R3 + Dpad UP";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = true;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 10)
            {
                labelControl7.Text = "R3 + Dpad Down";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = true;
                pictureBox99.Visible = false;
                pictureBox120.Visible = false;
            }
            else if (comboBoxEdit2.SelectedIndex == 11)
            {
                labelControl7.Text = "R3";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = false;
                pictureBox120.Visible = true;
            }
            else if (comboBoxEdit2.SelectedIndex == 12)
            {
                labelControl7.Text = "L1 + R3";
                pictureBox88.Visible = false;
                pictureBox89.Visible = false;
                pictureBox90.Visible = false;
                pictureBox91.Visible = false;
                pictureBox92.Visible = false;
                pictureBox93.Visible = false;
                pictureBox94.Visible = false;
                pictureBox95.Visible = false;
                pictureBox96.Visible = false;
                pictureBox97.Visible = false;
                pictureBox98.Visible = false;
                pictureBox99.Visible = true;
                pictureBox120.Visible = false;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            labelControl7.Text = "...";
            simpleButton3.Visible = false;
            pictureBox88.Visible = false;
            pictureBox89.Visible = false;
            pictureBox90.Visible = false;
            pictureBox91.Visible = false;
            pictureBox92.Visible = false;
            pictureBox93.Visible = false;
            pictureBox94.Visible = false;
            pictureBox95.Visible = false;
            pictureBox96.Visible = false;
            pictureBox97.Visible = false;
            pictureBox98.Visible = false;
            pictureBox99.Visible = false;
            pictureBox120.Visible = false;
        }

        private bool isSPRXwebCfree()
        {
            if (SPRXwebfree == true)
                return true;
            else return false;
        }

        private void CompletedSPRX(object sender, AsyncCompletedEventArgs e)
        {
            SPRXwebfree = true;
            labelControl10.Text = "Download Completed !!";
            progressPanel2.Visible = false;
        }

        private void SPRXDownloading(object sender, DownloadProgressChangedEventArgs e)
        {
            labelControl10.Text = "Downloading ...  " + e.ProgressPercentage.ToString() + "%";
        }

        private async void simpleButton4_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit2.SelectedIndex == 0)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Arkadia/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 1)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Complex/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 2)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Exo/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 3)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Jericho/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 4)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Lucid/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 5)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Paradise/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 6)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Perplexed/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 7)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Phoenix/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 8)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Suspect/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 9)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Trinity/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 10)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/YAE/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 11)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        sprxnameuploaded = "BO2.sprx";
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/OnlineCheater/BO2.sprx", @"downloads/BO2.sprx");
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
            else if (comboBoxEdit2.SelectedIndex == 12)
            {
                try
                {
                    if (isSPRXwebCfree() == true)
                    {
                        labelControl10.Text = "Downloading ...";
                        progressPanel2.Visible = true;
                        SPRXwebfree = false;
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(SPRXDownloading);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/SPRX/Extortion/BO2_ZM.sprx", @"downloads/BO2_ZM.sprx");
                        sprxnameuploaded = "BO2_ZM.sprx";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way, wait for the end before starting a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                Application.DoEvents();
            }
        }

        void FtpClient_OnUploadCompleted(object sender, UploadCompletedArgs e)
        {
            Thread.Sleep(1000);
            progressPanel2.Visible = false;
            labelControl10.Text = sprxnameuploaded + " Uploaded to dev_hdd0/tmp";
        }

        void FtpClient_OnUploadProgressChanged(object sender, UploadProgressChangedArgs e)
        {
            int value = Convert.ToInt32(e.BytesUploaded);
            Int64 PercentProgress = Convert.ToInt64(value * 100) / e.TotleBytes;
            int perc = Convert.ToInt32(PercentProgress.ToString());
            labelControl10.Text = "Uploading ...  " + perc + "%";
        }

        private void UploadSPRX()
        {
            string target = Path.Combine("dev_hdd0/tmp", Path.GetFileName(@"downloads/" + sprxnameuploaded));
            FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChanged);
            FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(FtpClient_OnUploadCompleted);
            FtpClient.Upload(@"downloads/" + sprxnameuploaded, "\\" + target);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (BO2.FTPconnected == true)
            {
                progressPanel2.Visible = true;
                labelControl10.Text = "Uploading ...";
                try
                {
                    UploadSPRX();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelControl10.Text = "Error with the Upload ...";
                }
            }
            else
            {
                XtraMessageBox.Show("Connect from the following form, then upload by clicking another the Upload button :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FTPConnect conn = new FTPConnect();
                conn.Show();
            }
        }

        public static void SetFtpClient(FTPclient client, string dir)
        {
            FtpClient = client;
            foreach (FTPfileInfo folder in client.ListDirectoryDetail(dir))//"/"))
            {
                ListViewItem item = new ListViewItem();
                item.Text = folder.Filename;
                if (folder.FileType == FTPfileInfo.DirectoryEntryTypes.Directory)
                    item.SubItems.Add("Folder");
                else
                    item.SubItems.Add("File");
            }
        }

        public static void ConnFTP(string IP)
        {
            try
            {
                FTPclient Ftp = new FTPclient(IP);
                directory = "/";
                Ftp.CurrentDirectory = directory;
                SetFtpClient(Ftp, directory);
                BO2.FTPconnected = true;
                XtraMessageBox.Show("PS3 Connected and ready to receive Files via FTP :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                BO2.FTPconnected = false;
                XtraMessageBox.Show("Error, please retry. Note: To Connect your PS3 vai FTP you need to: \nInstall webMAN MOD, or launch MultiMAN, or launch REBUG Toolbox. \nThese Homebrew has an FTP service. Without one of these Apps you cannot connect. \n\nAlso you need to activate your Internet Connection, and be sure to enter the right IP Address. \n\nHere is the error commented by the sistem: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            simpleButton7.Visible = false;
            pictureBox100.Visible = false;
            pictureBox101.Visible = false;
            pictureBox102.Visible = false;
            pictureBox103.Visible = false;
            pictureBox104.Visible = false;
            pictureBox105.Visible = false;
            pictureBox106.Visible = false;
            pictureBox107.Visible = false;
            pictureBox108.Visible = false;
            pictureBox109.Visible = false;
            pictureBox110.Visible = false;
            pictureBox111.Visible = false;
            pictureBox112.Visible = false;
            pictureBox113.Visible = false;
            pictureBox114.Visible = false;
            pictureBox115.Visible = false;
            pictureBox116.Visible = false;
            pictureBox117.Visible = false;
            pictureBox118.Visible = false;
            pictureBox119.Visible = false;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit4.SelectedIndex == 0)
            {
                XtraMessageBox.Show("Cargo Map Only!! \n??? vs Cars is a very simple gamemode to get your head around. \nThey're two teams one that will be driving and the other team will be using guns. \nIf you get eliminated by the enemy team, \nyou need to hope your team is good enough to survive and win the game for you!", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 1)
            {
                XtraMessageBox.Show("Cargo Map Only!! \nAvalanche has two teams, one team called 'Defenders' and the other called 'Runners'. \nThe 'Runners' mission is to dodge all the falling models and try to make it to the top of the slope \nand kill the 'Defenders' before they kill them. \nTeam 'Defenders' mission is to shoot as many levitating models before the 'Runners' get to the top. \nThe runners will have death machines to kill the 'Defenders' while the 'Defenders' will only have snipers!", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 2)
            {
                XtraMessageBox.Show("The main objective of Conquest is to capture and hold more objectives than the other team \nand to eliminate opponents to reduce the opponents troop count. \nBoth teams have a specific set of classes they have to choose from, 4 of the same classes, 2 unique classes for each team, 1 unique hero for each team and an earnable hero for both teams. \nAlong with a custom in-game reward system for players going on a slaying streak. \nLucky players can become Luke or Darth during the game and more skilled players can rely on earning Boba consistently. \nGood luck, May the force be with you!", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 3)
            {
                XtraMessageBox.Show("Cargo Map Only!! \nDeath Run has one 'Activator' and his job is to activate the traps at the right time so the 'Runners' die from the traps. \nThe 'Runners' need to duke the activator so he activates the traps too early or too late, \nif you succeed all 10 traps that will be in a random order you get a knife to kill the activator while he can not fight back!", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 4)
            {
                XtraMessageBox.Show("- This is Team Deathmatch \n- Spawn with a knife \n- The object of the game is to freeze all players of the opposite team by stabbing them \n- When you're frozen, You can look around (right stick is still active) to see what's going on \n- Last person on the team gets killed to initiate killcam \n- Press Dpad Left for instructions.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 5)
            {
                XtraMessageBox.Show("Free for All Only!! \nThe golden gun will always get one hit kills (collaterals aswell). \nEveryone can see the golden gun position with a world shader (an 'head icon' like carepkg & dead player ones). \n7Random guns spawn around the map with 30 seconds cooldown after a player picks em up (with correct name in the hint string & correct shader on the minimap). \nKills count towards your score only with the golden gun. \nFirst player that gets to 20 points, wins the game. \nYou can't pickup any of the random weapons while holding the golden gun. \nThe one who kills the player with the golden gun, gets awarded with it. \nIn case the player with the golden gun suicides or other specific situations (example killing simultaneously), the golden gun will respawn to its original position.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 6)
            {
                XtraMessageBox.Show("Free for All Only!! \nThis gamemode currently has a custom map edit for 'Nuketown' which includes lots of flags and invisible jump spots that you can find around the map. \nEveryone spawns in and a 15 second timer counts down to 1 and randomly picks a player to be the 'Hunter'. \nThe hunter's objective is to kill everyone alive before the game time runs out. \nThe people who aren't selected to be the hunter are the 'Survivors'. \nThe survivors objective is to survive until the game time ends. \nWhen the 'Hunter' is near a 'Survivor' the survivor will see red bars popup on his screen to show that the 'Hunter' is nearby and what direction he is coming from. \nWhen a 'Survivor' is near the 'Hunter' the hunter will see hit markers popup on his screen to show that a 'Survivor' is nearby. \nThe 'Hunter' will receive a Knife, Smoke Grenade, and has 3 options he can use. \nUp on the Dpad = Infrared Vision For: 30 Seconds \nLeft on the Dpad = Invisibility For: 20 Seconds \nDown on the Dpad = Third Person Toggle. \nBoth the 'Infrared Vision' and 'Invisibility' have cool down times after usage (2 Minutes each). \nThe 'Survivor' has no weapons but 2 Flash Grenades, 2 Concussion Grenades, and has 4 options he can use different from the hunter. \nUp on the Dpad = Slow Hunter For: 5 Seconds \nRight on the Dpad = Clone \nDown on the Dpad = Third Person Toggle \nLeft on the Dpad = Blocker \nBoth the 'Slow Hunter' and 'Clone' have cooldown times after usage (Slow Hunter = 4 Minutes, Clone = 1 Minute). \nBlockers spawn in and disappear after 5 seconds and have a cooldown after usage (90 Seconds).\n", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 7)
            {
                XtraMessageBox.Show("Carrier Map Only!! \nHell's Treadmill is a skill based timed parkour gamemode where players try to survive as long as possible on a cycling belt of carepackages. \nThere are 2 modes in Hell's Treadmill. A FFA structured mode and a Team structured mode. \nThe FFA structured mode takes place in the FFA gamemode and players try to get the highest single time. \nThe Team Structured mode takes place in the TDM gamemode and players are assigned into teams and the times of every member of each teams runs are added together. The team with the most time wins. \nNote: Latency to the host is felt far more in this gamemode than others (The lower your ping the better). You may gitch around sometimes while on the treadmill if you're not host. \nThis mode is now fully supported for Public Match play.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 8)
            {
                XtraMessageBox.Show("After 15 seconds of the game some one at random will be chosen to be a seeker. \nThe seeker has 10 minutes to find all hiders with a TAC 45. \nThe hiders have a selection of multiple models which can be used to hide. \nWhen a Seeker finds a Hider they shoot them.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 9)
            {
                XtraMessageBox.Show("Objective for the king is to protect his hill and survive. \nObjective for the other players, also known as 'Runners', is to climb the hill and kill the king or throw your combat axe and hope your lucky. \n\nSetting Up The Game: \nSet the game on TDM, I use 150 - 250 points, set the points per kill to 5, Number of lives to Unlimited, Rounds set as Unlimited! \n2.5 minutes so that way more people have the chance of being king, set heath to 30 %, might as well remove all preset classes and restrict weapons just in case.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 10)
            {
                XtraMessageBox.Show("No Info Available, sorry.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 11)
            {
                XtraMessageBox.Show("Gamemode might not work on any other gametypes except Team Deatmatch !!! \nWhen the game starts, a countdown begins and soon after a slenderman is chosen. \nThe survivors get 20 seconds to spread out. \nOnce Slenderman is released he is invisible. Slenderman can toggle visibility with a 5 second cooldown. \nThe objective for slenderman is to capture all the survivors by making them look at slender or touch him or let the time limit reach 0. \nThe objective for the survivors are to collect all the pages before the time runs out. \nI suggest using big maps, and not maps like Nuketown or Dig (as these maps are too small). \nThe survivors also have a heartbeat sensor, meaning when slenderman is near, their heartbeat will get faster depending on their distance. \nIf you are a survivor, do NOT look at or go near slenderman! That causes you to lose Sanity, and if you lose all your Sanity, you're dead! \nHowever, there are scavenger packs located around the map which lets you restore your Sanity to 75% (only for Aftermath and Cargo for the beta). Look for the floating scavenger packs and pages. \nThe game ends once slenderman or the survivors reach 5 total rounds won.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 12)
            {
                XtraMessageBox.Show("Free for All Only!! \nSupported Maps: \nNuketown\nCarrier\nExpress\n\nAs you can probably tell, the point of the mode is to survive each disaster, which is randomly selected from a list. Some of the Disasters:\nRocket Rain \n Nnja Mines \nAGRs \nFind the Safe Spot \nThe Floor is Lava \nHackers \nHeartquake \nRain Carepackages \nKill the Terrorists \nHot Potato \n\n And a lot of others disasters!", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 13)
            {
                XtraMessageBox.Show("Free for All Only!! \nThe Crusher is a very simple gamemode to get your head around. \nThey're two poles one that you need to duck under and one you need to jump over. \nIf you get hit by the pole you will fall off your podium and die. \nYou only get one life to try and survive until the last person alive or you can group as a team to try and beat The Crusher! \nThe poles will increase in speed over time so it will get harder!", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 14)
            {
                XtraMessageBox.Show("Free for All Only!! \nThe game starts and all player are given a introduction to the gamemode and are teleported to playing arena. \nShortly after a 10 second countdown will appear, when the countdown reaches 1 players are free to move and run to the weapon shed where they will choose from a large selection of 59 different weapons available to them. \nWhile this is happening there is a 10 second no damage period which prevent players from dying straight away when trying to grab a weapon. \nThe objective is to be the last one to survive whether you decide to hunt or be hunted. \nPlayers can find multiple things around the map such as bridges and zip lines around the map that allows them to hide in high areas such as trees for better area cover for targeting.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 15)
            {
                XtraMessageBox.Show("Team Deathmatch Only!! This Gamemode does not work correctly with Bots aswell as Split Screen!! \n\nShop Controls: \nDPAD Up - Open Menu \nDPAD Up / Down - Scroll Up / Down \nDPAD Left - Close Menu Anywhere \nX - Select Option \nSquare - Go Back / Exit Menu \n\nTwo Teams: Humans and Zombies. Your team could be switched when you die.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 16)
            {
                XtraMessageBox.Show("No Info Available, sorry.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ZM
            else if (comboBoxEdit4.SelectedIndex == 17)
            {
                XtraMessageBox.Show("So i thought that it would be pretty fun to have an FFA game with rayguns in the middle of a zombies game. I was right. \nThe gamemode allows you to kill each other for points, and the player with the most points at the end of the game wins. \n\nFeatures include a working minimap, killstreaks, and music for each map ( no music on tranzit ).", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 18)
            {
                XtraMessageBox.Show("No Info Available, sorry.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxEdit4.SelectedIndex == 19)
            {
                XtraMessageBox.Show("This is literally just Search and Destroy in the middle of a zombies game on a zombies map, so not much explaining to do.", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("No GameMode Selected from the list..", "GameMode Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxEdit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            simpleButton7.Visible = true;
            
            if (comboBoxEdit4.SelectedIndex == 0)
            {
                pictureBox100.Visible = true;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 1)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = true;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 2)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = true;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 3)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = true;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 4)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = true;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 5)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = true;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 6)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = true;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 7)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = true;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 8)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = true;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 9)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = true;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 10)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = true;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 11)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = true;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 12)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = true;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 13)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = true;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 14)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = true;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 15)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = true;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 16)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = true;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 17)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = true;
                pictureBox118.Visible = false;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 18)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = true;
                pictureBox119.Visible = false;
            }
            if (comboBoxEdit4.SelectedIndex == 19)
            {
                pictureBox100.Visible = false;
                pictureBox101.Visible = false;
                pictureBox102.Visible = false;
                pictureBox103.Visible = false;
                pictureBox104.Visible = false;
                pictureBox105.Visible = false;
                pictureBox106.Visible = false;
                pictureBox107.Visible = false;
                pictureBox108.Visible = false;
                pictureBox109.Visible = false;
                pictureBox110.Visible = false;
                pictureBox111.Visible = false;
                pictureBox112.Visible = false;
                pictureBox113.Visible = false;
                pictureBox114.Visible = false;
                pictureBox115.Visible = false;
                pictureBox116.Visible = false;
                pictureBox117.Visible = false;
                pictureBox118.Visible = false;
                pictureBox119.Visible = true;
            }
        }

        private bool IsGameModewebCFree()
        {
            if (isgamemwebfree == true)
                return true;
            else return false;
        }

        private void CompletedGmDL(object sender, AsyncCompletedEventArgs e)
        {
            isgamemwebfree = true;
            Thread.Sleep(1000);
            labelControl10.Text = "Download Completed !!";
            Thread.Sleep(1000);
            labelControl10.Text = "Injecting GameMode ...";
        }

        private void GMDownloading(object sender, DownloadProgressChangedEventArgs e)
        {
            labelControl10.Text = "Downloading ...  " + e.ProgressPercentage.ToString() + "%";
        }

        private async void simpleButton8_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit4.SelectedIndex == 0)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/...vsCars/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 1)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/Avalanche/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 2)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/Conquest/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 3)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/DeathRun/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 4)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/FreezeTag/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 5)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/GoldenGun/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 6)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/Haunted/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 7)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/HellsTreadmills/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 8)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/HideandSeek/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 9)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/KingofHill/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 10)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/RolltheDice/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 11)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/Slenderman/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 12)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/SurvivetheDisaster/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 13)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/TheCrusher/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 14)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/TheHungerGames/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 15)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/ZombieLandShark/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 16)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/ZombieLandModzforFun/_development_dvars.gsc", @"downloads/_development_dvars.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 17)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/ZMChaosMode/_development_dvars.gsc", @"downloads/_clientids.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 18)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/ZMPropHunt/_development_dvars.gsc", @"downloads/_clientids.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
            else if (comboBoxEdit4.SelectedIndex == 19)
            {
                try
                {
                    labelControl10.Text = "Downloading ...";
                    progressPanel3.Visible = true;
                    isgamemwebfree = false;
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GMDownloading);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedGmDL);
                    await DownloadMod("https://www.cybermodding.it/LezZo-BO2-RTM/ModManager/Gamemodes/ZMSearchandDestroy/_development_dvars.gsc", @"downloads/_clientids.gsc");
                }
                catch
                {

                }
                Application.DoEvents();
                Thread.Sleep(500);

                if (BO2.APIok == true)
                {
                    if (BO2.APIused == "CCAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.ControlConsole);
                    }
                    else if (BO2.APIused == "TMAPI")
                    {
                        PS3.ChangeAPI(SelectAPI.TargetManager);
                    }
                    try
                    {
                        byte[] GSC = File.ReadAllBytes(@"downloads/_development_dvars.gsc");
                        byte[] buffer = { 0x10, 0x04, 0x00, 0x00 };
                        PS3.SetMemory(0x140C2D0, buffer);
                        PS3.SetMemory(0x10040000, GSC);
                        if (BO2.APIused == "CCAPI")
                        {
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "GameMode Injected :D");
                        }
                        labelControl10.Text = "GameMode Injected !!";
                    }
                    catch
                    {
                        InjectGM();
                    }
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                progressPanel3.Visible = false;
            }
        }
    }
}