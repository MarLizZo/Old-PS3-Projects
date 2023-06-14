using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Threading;
using DevExpress.XtraEditors;

namespace PylezZo_GTAV_Extreme_Tool.Mods
{
    public partial class ModsDL : DevExpress.XtraEditors.XtraForm
    {
        public ModsDL()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        #region definitions
        public static FTPclient FtpClient;
        private static string directory;
        public static bool FTPconnected = false;
        public static string SPRXZipFile = "";
        public static string RPFZipFile = "";
        public static string ToolDir = Application.StartupPath;

        public void ConnFTP(string IP)
        {
            try
            {
                FTPclient Ftp = new FTPclient(IP);
                directory = "/";
                Ftp.CurrentDirectory = directory;
                SetFtpClient(Ftp, directory);
                FTPconnected = true;
                barStaticItem1.Caption = "FTP Connected";
                XtraMessageBox.Show("PS3 Connected and ready to receive Files via FTP :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                barStaticItem1.Caption = "FTP Connected";
            }
            catch (Exception ex)
            {
                barStaticItem1.Caption = "FTP Not Connected ...";
                FTPconnected = false;
                XtraMessageBox.Show("Error, please retry. \nImportant notes: To connect your PS3 via FTP you need to: \nInstall webMAN MOD or sMAN, or launch MultiMAN, or launch REBUG Toolbox. \nThese Homebrew has an integrated FTP service. Without one of these Apps you cannot connect. \n\nAlso you need to activate your Internet Connection, and be sure to enter the right IP Address. \n\nHere is the error commented by the sistem: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string URLRPF = "https://www.cybermodding.it/LezZo-GTA-RTM/GTA-Mods/RPF/";
        string URLSPRX = "https://www.cybermodding.it/LezZo-GTA-RTM/GTA-Mods/SPRX/";
        string Axx67RPF = "Axx67.txt";
        string AsticottiRPF = "AsticottiRPF.txt";
        string ChristmasRPF = "Christmas.txt";
        string DefianceRPF = "DefianceVPN.txt";
        string SalfetyRPF = "SalfetyRPF.txt";
        string SemjasesRPF = "Semjases.txt";
        string WebHackerRPF = "webhacker.txt";
        string SnakesRPF = "MrSnakeLoader.txt";
        string MajesticRPF = "Majestic-Loader.txt";
        string ErootiiikRPF = "EroootiiikRPF.txt";
        string SimpleManRPF = "SimpleMan.txt";
        string DaniiRPF = "Danii.txt";
        string DaniiNewRPF = "Danii_New.txt";
        string ScriptManagerRPF = "ScriptManager.txt";
        string NotYourDopeRPF = "NotYourDope.txt";
        string SephoenixRPF = "Sephoenix.txt";
        string CybermoddingRPF = "Cybermodding.txt";
        string JamesRebornRPF = "JamesReborn.txt";
        string SerenHonorRPF = "SerenHonor.txt";
        string HelldemonRPF = "Helldemon.txt";
        string JakemodzRPF = "Jakemodz.txt";
        string TgsadouiRPF = "Tgsadoui.txt";
        string EvolutionRPF = "Evolution.txt";
        //New New
        string W33DRPF = "W33D.txt";
        string DeadEditRPF = "DeadEdit.txt";
        string SombraRPF = "Sombra.txt";

        string AsticotSPRX = "AsticotSPRX";
        string CEXgaleriumSPRX = "CEX-Galerium.txt";
        string DEXgaleriumSPRX = "DEX-Galerium.txt";
        string HustleSPRX = "Hustle.txt";
        string IndipendenceSPRX = "Indipendence.txt";
        string InfernusSPRX = "Infernus.txt";
        string InsomniaSPRX = "Insomnia.txt";
        string KtronSPRX = "krton.txt";
        string SalfetyMainSPRX = "salfetyMain.txt";
        string SalfetyRecoverySPRX = "salfetyRecovery.txt";
        string UmbrellaMainSPRX = "theumbrellamain.txt";
        string UmbrellaRecoverySPRX = "theumbrellarecovery";
        string WildemodzSPRX = "wildemodzSPRX.txt";
        string YourselfSPRX = "yourself.txt";
        string ZombieModSPRX = "zombiemod.txt";
        string RandiumsSPRX = "randiums.txt";
        //New Menus
        string ProjectRainSPRX = "projectRain.txt";
        string AlfamodzSPRX = "alfamodz.txt";
        string AnarchySPRX = "anarchy.txt";
        string ProjectIllusionSPRX = "projectIllusion.txt";
        string LegendarySPRX = "legendary.txt";
        string ParanormalSPRX = "paranormal.txt";
        string PolynesiaSPRX = "polynesia.txt";
        //New New
        string LugiaSPRX = "lugia.txt";
        string SerenRemakeSPRX = "serenRemake.txt";
        string FreedomSPRX = "freedom.txt";
        string LimboSPRX = "limbo.txt";
        string LosSantosSPRX = "lossantos.txt";
        string EuphoriaSPRX = "euphoria.txt";
        string FlexSPRX = "flex.txt";
        string DestinySPRX = "destiny.txt";

        private bool iswebfree = true;

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

        private static bool CheckForInternetConnection()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
                return true;
            else
                return false;
        }
        #endregion

        private void ModsDL_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
            }
        }

        private void ModsDL_Shown(Object sender, EventArgs e)
        {
            Application.DoEvents();
            splashScreenManager2.ShowWaitForm();
            if (CheckForInternetConnection() == true)
            {
                WebClient webC = new WebClient();

                var Cyb = webC.DownloadString(URLRPF + CybermoddingRPF);
                comboBoxEdit2.Properties.Items.Insert(0, "Cybermodding Loader v" + Cyb);
                var Ast = webC.DownloadString(URLRPF + AsticottiRPF);
                comboBoxEdit2.Properties.Items.Insert(1, "Asticotti Mod Loader v" + Ast);
                var Axx = webC.DownloadString(URLRPF + Axx67RPF);
                comboBoxEdit2.Properties.Items.Insert(2, "Axx67 Mod Loader v" + Axx);
                var Chr = webC.DownloadString(URLRPF + ChristmasRPF);
                comboBoxEdit2.Properties.Items.Insert(3, "Christmas Mod Loader v" + Chr);
                var Def = webC.DownloadString(URLRPF + DefianceRPF);
                comboBoxEdit2.Properties.Items.Insert(4, "DefianceVPN Mod Loader v" + Def);
                var Salf = webC.DownloadString(URLRPF + SalfetyRPF);
                comboBoxEdit2.Properties.Items.Insert(5, "Salfety Mod Loader v" + Salf);
                var Semj = webC.DownloadString(URLRPF + SemjasesRPF);
                comboBoxEdit2.Properties.Items.Insert(6, "Semjases Mod Loader v" + Semj);
                var Webh = webC.DownloadString(URLRPF + WebHackerRPF);
                comboBoxEdit2.Properties.Items.Insert(7, "Web Hacker Mod Loader v" + Webh);
                var MrSn = webC.DownloadString(URLRPF + SnakesRPF);
                comboBoxEdit2.Properties.Items.Insert(8, "Mr Snakes Manager v" + MrSn);
                var Maj = webC.DownloadString(URLRPF + MajesticRPF);
                comboBoxEdit2.Properties.Items.Insert(9, "Majestic Mod Loader Clean v" + Maj);
                comboBoxEdit2.Properties.Items.Insert(10, "Majestic Mod Loader Custom v" + Maj);
                var Erot = webC.DownloadString(URLRPF + ErootiiikRPF);
                comboBoxEdit2.Properties.Items.Insert(11, "Erootiiik Manager v" + Erot);
                //New Loaders
                var SimpM = webC.DownloadString(URLRPF + SimpleManRPF);
                comboBoxEdit2.Properties.Items.Insert(12, "SimpleMan Manager v" + SimpM);
                var Dan = webC.DownloadString(URLRPF + DaniiRPF);
                comboBoxEdit2.Properties.Items.Insert(13, "Danii X Modz Manager v" + Dan);
                var Danew = webC.DownloadString(URLRPF + DaniiNewRPF);
                comboBoxEdit2.Properties.Items.Insert(14, "Danii X Modz Manager v" + Danew);
                var Scri = webC.DownloadString(URLRPF + ScriptManagerRPF);
                comboBoxEdit2.Properties.Items.Insert(15, "Script Manager v" + Scri);
                var NYD = webC.DownloadString(URLRPF + NotYourDopeRPF);
                comboBoxEdit2.Properties.Items.Insert(16, "NotYourDope Manager v" + NYD);
                var Sep = webC.DownloadString(URLRPF + SephoenixRPF);
                comboBoxEdit2.Properties.Items.Insert(17, "Sephoenix Manager v" + Sep);
                //New New Loaders
                var James = webC.DownloadString(URLRPF + JamesRebornRPF);
                comboBoxEdit2.Properties.Items.Insert(18, "JamesReborn Clean Loader v" + James);
                comboBoxEdit2.Properties.Items.Insert(19, "JamesReborn Antifreeze RPF v" + James);
                var SereH = webC.DownloadString(URLRPF + SerenHonorRPF);
                comboBoxEdit2.Properties.Items.Insert(20, "Serendipity Honor Loader v" + SereH);
                var Helld = webC.DownloadString(URLRPF + HelldemonRPF);
                comboBoxEdit2.Properties.Items.Insert(21, "Hell Demon Mod Loader v" + Helld);
                var jakem = webC.DownloadString(URLRPF + JakemodzRPF);
                comboBoxEdit2.Properties.Items.Insert(22, "Jakemodz Mod Loader v" + jakem);
                var tgs = webC.DownloadString(URLRPF + TgsadouiRPF);
                comboBoxEdit2.Properties.Items.Insert(23, "Tgsaudoi Mod Loader v" + tgs);
                var evo = webC.DownloadString(URLRPF + EvolutionRPF);
                comboBoxEdit2.Properties.Items.Insert(24, "Evolution Mod Loader v" + evo);
                var weed = webC.DownloadString(URLRPF + W33DRPF);
                comboBoxEdit2.Properties.Items.Insert(25, "W33D Mod Loader + Intro v" + weed);
                var deaded = webC.DownloadString(URLRPF + DeadEditRPF);
                comboBoxEdit2.Properties.Items.Insert(26, "D34DEditzz Mod Loader v" + deaded);
                var somb = webC.DownloadString(URLRPF + SombraRPF);
                comboBoxEdit2.Properties.Items.Insert(27, "Sombra Mod Loader v" + somb);

                //SPRX
                var AstSPRX = webC.DownloadString(URLSPRX + AsticotSPRX);
                comboBoxEdit1.Properties.Items.Insert(0, "Asticot Mod Menu v" + AstSPRX);
                var CEXgale = webC.DownloadString(URLSPRX + CEXgaleriumSPRX);
                comboBoxEdit1.Properties.Items.Insert(1, "CEX The Galerium Mod Menu v" + CEXgale);
                var DEXgale = webC.DownloadString(URLSPRX + DEXgaleriumSPRX);
                comboBoxEdit1.Properties.Items.Insert(2, "DEX The Galerium Mod Menu v" + DEXgale);
                var Hust = webC.DownloadString(URLSPRX + HustleSPRX);
                comboBoxEdit1.Properties.Items.Insert(3, "The Hustle Mod Menu v" + Hust);
                var Indip = webC.DownloadString(URLSPRX + IndipendenceSPRX);
                comboBoxEdit1.Properties.Items.Insert(4, "Indipendence Mod Menu v" + Indip);
                var Infer = webC.DownloadString(URLSPRX + InfernusSPRX);
                comboBoxEdit1.Properties.Items.Insert(5, "Infernus Mod Menu v" + Infer);
                var Insom = webC.DownloadString(URLSPRX + InsomniaSPRX);
                comboBoxEdit1.Properties.Items.Insert(6, "Insomnia Mod Menu v" + Insom);
                var krt = webC.DownloadString(URLSPRX + KtronSPRX);
                comboBoxEdit1.Properties.Items.Insert(7, "Ktron Mod Menu v" + krt);
                var salf = webC.DownloadString(URLSPRX + SalfetyMainSPRX);
                comboBoxEdit1.Properties.Items.Insert(8, "Salfety Main Mod Menu v" + salf);
                var salfrec = webC.DownloadString(URLSPRX + SalfetyRecoverySPRX);
                comboBoxEdit1.Properties.Items.Insert(9, "Salfety Recovery Mod Menu v" + salfrec);
                var UmbMain = webC.DownloadString(URLSPRX + UmbrellaMainSPRX);
                comboBoxEdit1.Properties.Items.Insert(10, "The Umbrella Main Mod Menu v" + UmbMain);
                var UmbRec = webC.DownloadString(URLSPRX + UmbrellaRecoverySPRX);
                comboBoxEdit1.Properties.Items.Insert(11, "The Umbrella Recovery Mod Menu v" + UmbRec);
                var wildSPRX = webC.DownloadString(URLSPRX + WildemodzSPRX);
                comboBoxEdit1.Properties.Items.Insert(12, "WildeModz Mod Menu v" + wildSPRX);
                var yours = webC.DownloadString(URLSPRX + YourselfSPRX);
                comboBoxEdit1.Properties.Items.Insert(13, "Yourself Mod Menu v" + yours);
                var zomb = webC.DownloadString(URLSPRX + ZombieModSPRX);
                comboBoxEdit1.Properties.Items.Insert(14, "GTA V Zombie Mod v" + zomb);
                var rand = webC.DownloadString(URLSPRX + RandiumsSPRX);
                comboBoxEdit1.Properties.Items.Insert(15, "Randiums Mod Menu v" + rand);
                //New SPRX
                var rain = webC.DownloadString(URLSPRX + ProjectRainSPRX);
                comboBoxEdit1.Properties.Items.Insert(16, "Project Rain Mod Menu v" + rain);
                var alfa = webC.DownloadString(URLSPRX + AlfamodzSPRX);
                comboBoxEdit1.Properties.Items.Insert(17, "AlfaModz Mod Menu v" + alfa);
                var anar = webC.DownloadString(URLSPRX + AnarchySPRX);
                comboBoxEdit1.Properties.Items.Insert(18, "Anarchy Mod Menu v" + anar);
                var ill = webC.DownloadString(URLSPRX + ProjectIllusionSPRX);
                comboBoxEdit1.Properties.Items.Insert(19, "Project Illusion Mod Menu v" + ill);
                var leg = webC.DownloadString(URLSPRX + LegendarySPRX);
                comboBoxEdit1.Properties.Items.Insert(20, "Legendary Mod Menu v" + leg);
                var par = webC.DownloadString(URLSPRX + ParanormalSPRX);
                comboBoxEdit1.Properties.Items.Insert(21, "Paranormal Mod Menu v" + par);
                var pol = webC.DownloadString(URLSPRX + PolynesiaSPRX);
                comboBoxEdit1.Properties.Items.Insert(22, "Polynesia Mod Menu v" + pol);
                //New New
                var des = webC.DownloadString(URLSPRX + DestinySPRX);
                comboBoxEdit1.Properties.Items.Insert(23, "Destiny Mod Menu v" + des);
                var eup = webC.DownloadString(URLSPRX + EuphoriaSPRX);
                comboBoxEdit1.Properties.Items.Insert(24, "Euphoria Mod Menu v" + eup);
                var fl = webC.DownloadString(URLSPRX + FlexSPRX);
                comboBoxEdit1.Properties.Items.Insert(25, "Flex Mod Menu v" + fl);
                var fr = webC.DownloadString(URLSPRX + FreedomSPRX);
                comboBoxEdit1.Properties.Items.Insert(26, "Freedom Mod Menu v" + fr);
                var li = webC.DownloadString(URLSPRX + LimboSPRX);
                comboBoxEdit1.Properties.Items.Insert(27, "Limbo Mod Menu v" + li);
                var los = webC.DownloadString(URLSPRX + LosSantosSPRX);
                comboBoxEdit1.Properties.Items.Insert(28, "Los Santos Mod Menu v" + los);
                var lu = webC.DownloadString(URLSPRX + LugiaSPRX);
                comboBoxEdit1.Properties.Items.Insert(29, "Lugia Mod Menu v" + lu);
                var ser = webC.DownloadString(URLSPRX + SerenRemakeSPRX);
                comboBoxEdit1.Properties.Items.Insert(30, "Serendipity Remake Menu v" + ser);

                splashScreenManager2.CloseWaitForm();
            }
            else
            {
                splashScreenManager2.CloseWaitForm();
                Application.DoEvents();
                Thread.Sleep(500);
                XtraMessageBox.Show("Your Internet Connection is not working, or another error occured. \nCouldn't retrieve the Mods lists from the Server..", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                labelControl6.Text = "R1 + -->";
                pictureBox8.Visible = true;
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
                pictureBox8.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 1)
            {
                labelControl6.Text = "R1 + -->";
                pictureBox9.Visible = true;
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
                pictureBox9.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 2)
            {
                labelControl6.Text = "R1 + -->";
                pictureBox9.Visible = true;
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
                pictureBox9.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 3)
            {
                labelControl6.Text = "[] + -->";
                pictureBox10.Visible = true;
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
                pictureBox10.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 4)
            {
                labelControl6.Text = "R1 + <--";
                pictureBox11.Visible = true;
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
                pictureBox11.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 5)
            {
                labelControl6.Text = "[] + -->";
                pictureBox12.Visible = true;
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
                pictureBox12.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 6)
            {
                labelControl6.Text = "R1 + -->";
                pictureBox13.Visible = true;
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
                pictureBox13.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 7)
            {
                labelControl6.Text = "R1 + <--";
                pictureBox14.Visible = true;
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
                pictureBox14.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 8)
            {
                labelControl6.Text = "R3 + <--";
                pictureBox15.Visible = true;
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
                pictureBox15.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 9)
            {
                labelControl6.Text = "R1 + -->";
                pictureBox16.Visible = true;
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
                pictureBox16.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 10)
            {
                labelControl6.Text = "R1 + <--";
                pictureBox17.Visible = true;
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
                pictureBox17.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 11)
            {
                labelControl6.Text = "R1 + <--";
                pictureBox18.Visible = true;
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
                pictureBox18.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 12)
            {
                labelControl6.Text = "[] + -->";
                pictureBox19.Visible = true;
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
                pictureBox19.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 13)
            {
                labelControl6.Text = "R1 + L1";
                pictureBox20.Visible = true;
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = true;
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
            }
            if (comboBoxEdit1.SelectedIndex == 14)
            {
                labelControl6.Text = "Dpad Left";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 15)
            {
                labelControl6.Text = "R1 + Dpad Left";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 16)
            {
                labelControl6.Text = "Dpad Left + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 17)
            {
                labelControl6.Text = "Dpad Right + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 18)
            {
                labelControl6.Text = "Dpad Right + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 19)
            {
                labelControl6.Text = "R1 + Dpad Right";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 20)
            {
                labelControl6.Text = "R3 + Dpad Left";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 21)
            {
                labelControl6.Text = "Dpad Right + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
            }
            if (comboBoxEdit1.SelectedIndex == 22)
            {
                labelControl6.Text = "Dpad Right + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 23)
            {
                labelControl6.Text = "Dpad Left + R1";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = true;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 24)
            {
                labelControl6.Text = "Dpad Right + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = true;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 25)
            {
                labelControl6.Text = "L3 + R3";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = true;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 26)
            {
                labelControl6.Text = "Dpad Left + R1";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = true;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 27)
            {
                labelControl6.Text = "Dpad Right + R1";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = true;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 28)
            {
                labelControl6.Text = "Dpad Right + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = true;
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 29)
            {
                labelControl6.Text = "Dpad Right + R1";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = true;
                pictureBox56.Visible = false;
            }
            if (comboBoxEdit1.SelectedIndex == 30)
            {
                labelControl6.Text = "Dpad Right + []";
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
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox20.Visible = false;
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
                pictureBox49.Visible = false;
                pictureBox50.Visible = false;
                pictureBox51.Visible = false;
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                pictureBox54.Visible = false;
                pictureBox55.Visible = false;
                pictureBox56.Visible = true;
            }
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit2.SelectedIndex == 0)
            {
                labelControl6.Text = "L3 + X";
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
            }
            if (comboBoxEdit2.SelectedIndex == 1)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 2)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 3)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 4)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 5)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 6)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 7)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 8)
            {
                labelControl6.Text = "R1 + R3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 9)
            {
                labelControl6.Text = "[] + <--";
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
            }
            if (comboBoxEdit2.SelectedIndex == 10)
            {
                labelControl6.Text = "[] + <--";
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
            }
            if (comboBoxEdit2.SelectedIndex == 11)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 12)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 13)
            {
                labelControl6.Text = "L1 + []";
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
            }
            if (comboBoxEdit2.SelectedIndex == 14)
            {
                labelControl6.Text = "L1 + []";
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
            }
            if (comboBoxEdit2.SelectedIndex == 15)
            {
                labelControl6.Text = "R1 + R3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 16)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 17)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 18)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 19)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 20)
            {
                labelControl6.Text = "X + <--";
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
            }
            if (comboBoxEdit2.SelectedIndex == 21)
            {
                labelControl6.Text = "R3 + -->";
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
            }
            if (comboBoxEdit2.SelectedIndex == 22)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 23)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 24)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 25)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 26)
            {
                labelControl6.Text = "R3 + L3";
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
            }
            if (comboBoxEdit2.SelectedIndex == 27)
            {
                labelControl6.Text = "R1 + L3";
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
            }
        }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            barStaticItem1.Caption = "Downloading ...";
            progressBarControl1.EditValue = e.ProgressPercentage;
            labelControl10.Text = e.TotalBytesToReceive.ToString();
            labelControl9.Text = e.BytesReceived.ToString();
        }

        private void CompletedSPRX(object sender, AsyncCompletedEventArgs e)
        {
            barStaticItem1.Caption = "Download Completed !!";
            Thread.Sleep(1000);
            progressBarControl1.EditValue = 0;
            labelControl9.Text = "...";
            labelControl10.Text = "...";
            iswebfree = true;
        }

        private void CompletedRPF(object sender, AsyncCompletedEventArgs e)
        {
            barStaticItem1.Caption = "Download Completed !!";
            Thread.Sleep(1000);
            progressBarControl1.EditValue = 0;
            labelControl9.Text = "...";
            labelControl10.Text = "...";
            iswebfree = true;
        }

        private bool IswebCFree()
        {
            if (iswebfree == true)
                return true;
            else return false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WebClient webC = new WebClient();
            
            labelControl7.Text = "Downloaded";

            if (comboBoxEdit1.SelectedIndex == 0)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlAst = webC.DownloadString(URLSPRX + "dlasticotSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + AsticotSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlAst), "Data/Asticot-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Asticot-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 1)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlcexgaler = webC.DownloadString(URLSPRX + "dlcexgaleriumSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + CEXgaleriumSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlcexgaler), "Data/CEX-COBRA-Galerium-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "CEX-COBRA-Galerium-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 2)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dldexgaler = webC.DownloadString(URLSPRX + "dldexgaleriumSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + DEXgaleriumSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dldexgaler), "Data/DEX-Galerium-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "DEX-Galerium-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 3)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlhust = webC.DownloadString(URLSPRX + "dlhustleSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + HustleSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlhust), "Data/TheHustle-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "TheHustle-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 4)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlindip = webC.DownloadString(URLSPRX + "dlindipendenceSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + IndipendenceSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlindip), "Data/Indipendence-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Indipendence-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 5)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlinfer = webC.DownloadString(URLSPRX + "dlinfernusSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + InfernusSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlinfer), "Data/Infernus-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Infernus-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 6)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlinsom = webC.DownloadString(URLSPRX + "dlinsomniaSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + InsomniaSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlinsom), "Data/Insomnia-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Insomnia-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 7)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlktron = webC.DownloadString(URLSPRX + "dlktronSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + KtronSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlktron), "Data/Ktron-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Ktron-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 8)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlsalfmain = webC.DownloadString(URLSPRX + "dlsalfetymainSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + SalfetyMainSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlsalfmain), "Data/Salfety-Main-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Salfety-Main-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 9)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlsalfrec = webC.DownloadString(URLSPRX + "dlsalfetyRecoverySPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + SalfetyRecoverySPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlsalfrec), "Data/Salfety-Recovery-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Salfety-Recovery-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 10)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlumbrmain = webC.DownloadString(URLSPRX + "dltheumbrellamainSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + UmbrellaMainSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlumbrmain), "Data/TheUmbrella-Main-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "TheUmbrella-Main-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 11)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlumbrrec = webC.DownloadString(URLSPRX + "dltheumbrellarecoverySPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + UmbrellaRecoverySPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlumbrrec), "Data/TheUmbrella-Recovery-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "TheUmbrella-Recovery-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 12)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlwild = webC.DownloadString(URLSPRX + "dlwildemodzSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + WildemodzSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlwild), "Data/WildeModz-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "WildeModz-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 13)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlyours = webC.DownloadString(URLSPRX + "dlyourselfSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + YourselfSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlyours), "Data/Yourself-SPRX-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Yourself-SPRX-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 14)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlzombie = webC.DownloadString(URLSPRX + "dlzombiemod.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + ZombieModSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlzombie), "Data/GTA5-Zombie-Mod-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "GTA5-Zombie-Mod-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 15)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlrandiums = webC.DownloadString(URLSPRX + "dlrandiumsSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + RandiumsSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlrandiums), "Data/Randiums-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Randiums-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 16)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlrain = webC.DownloadString(URLSPRX + "dlrainSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + ProjectRainSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlrain), "Data/Proj-Rain-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Proj-Rain-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 17)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlalfamodz = webC.DownloadString(URLSPRX + "dlalfamodzSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + AlfamodzSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlalfamodz), "Data/Alfamodz-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Alfamodz-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 18)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlanarchy = webC.DownloadString(URLSPRX + "dlanarchySPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + AnarchySPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlanarchy), "Data/Anarchy-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Anarchy-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 19)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlillusion = webC.DownloadString(URLSPRX + "dlillusionSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + ProjectIllusionSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlillusion), "Data/Proj-Illusion-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Proj-Illusion-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 20)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dllegendary = webC.DownloadString(URLSPRX + "dllegendarySPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + LegendarySPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dllegendary), "Data/Legendary-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Legendary-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 21)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlparanormal = webC.DownloadString(URLSPRX + "dlparanormalSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + ParanormalSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlparanormal), "Data/Paranormal-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Paranormal-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 22)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlpolynesia = webC.DownloadString(URLSPRX + "dlpolynesiaSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + PolynesiaSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlpolynesia), "Data/Polynesia-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Polynesia-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 23)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dldes = webC.DownloadString(URLSPRX + "dldestinySPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + DestinySPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dldes), "Data/Destiny-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Destiny-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 24)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dleup = webC.DownloadString(URLSPRX + "dleuphoriaSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + EuphoriaSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dleup), "Data/Euphoria-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Euphoria-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 25)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlfl = webC.DownloadString(URLSPRX + "dlflexSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + FlexSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlfl), "Data/Flex-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Flex-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 26)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlfr = webC.DownloadString(URLSPRX + "dlfreedomSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + FreedomSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlfr), "Data/Freedom-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Freedom-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 27)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlli = webC.DownloadString(URLSPRX + "dllimboSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + LimboSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlli), "Data/Limbo-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Limbo-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 28)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlls = webC.DownloadString(URLSPRX + "dllossantosSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + LosSantosSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlls), "Data/LosSantos-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "LosSantos-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 29)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dllu = webC.DownloadString(URLSPRX + "dllugiaSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + LugiaSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dllu), "Data/Lugia-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "Lugia-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit1.SelectedIndex == 30)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlser = webC.DownloadString(URLSPRX + "dlserenRemakeSPRX.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLSPRX + SerenRemakeSPRX);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlser), "Data/SerenRemake-Mod-Menu-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedSPRX);
                        SPRXZipFile = "SerenRemake-Mod-Menu-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            WebClient webC = new WebClient();
            labelControl7.Text = "Downloaded";

            if (comboBoxEdit2.SelectedIndex == 0)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlCyb = webC.DownloadString(URLRPF + "dlCybermoddingRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + CybermoddingRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlCyb), "Data/Cybermodding-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Cybermodding-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 1)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlAst = webC.DownloadString(URLRPF + "dlasticottiRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + AsticottiRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlAst), "Data/Asticotti-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Asticotti-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 2)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlAxx = webC.DownloadString(URLRPF + "dlaxx67RPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + Axx67RPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlAxx), "Data/Axx67-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Axx67-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 3)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlChr = webC.DownloadString(URLRPF + "dlchristmasRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + ChristmasRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlChr), "Data/Christmas-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Christmas-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 4)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlDef = webC.DownloadString(URLRPF + "dldefianceRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + DefianceRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlDef), "Data/DefianceVPN-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "DefianceVPN-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 5)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlSalf = webC.DownloadString(URLRPF + "dlsalfetyRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + SalfetyRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlSalf), "Data/Salfety-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Salfety-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 6)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlSemj = webC.DownloadString(URLRPF + "dlsemjasesRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + SemjasesRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlSemj), "Data/Semjases-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Semjases-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 7)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlWebh = webC.DownloadString(URLRPF + "dlwebhackerRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + WebHackerRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlWebh), "Data/WebHacker-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "WebHacker-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 8)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlMrSn = webC.DownloadString(URLRPF + "dlmrsnakesRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + SnakesRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlMrSn), "Data/MrSnakes-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "MrSnakes-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 9)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlMajclean = webC.DownloadString(URLRPF + "dlmajesticcleanRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + MajesticRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlMajclean), "Data/Majestic-Clean-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Majestic-Clean-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 10)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlMajcustom = webC.DownloadString(URLRPF + "dlmajesticcustomRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + MajesticRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlMajcustom), "Data/Majestic-Custom-RPF-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Majestic-Custom-RPF-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 11)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlErotik = webC.DownloadString(URLRPF + "dlerotiiikRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + ErootiiikRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlErotik), "Data/Erootiiik-Manager-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Erootiiik-Manager-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 12)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlSimpleMan = webC.DownloadString(URLRPF + "dlsimplemanRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + SimpleManRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlSimpleMan), "Data/SimpleMan-Loader-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "SimpleMan-Loader-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 13)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlDanii = webC.DownloadString(URLRPF + "dldaniiRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + DaniiRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlDanii), "Data/Danii-X-Modz-Loader-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Danii-X-Modz-Loader-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 14)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlDaniiNew = webC.DownloadString(URLRPF + "dldaniinewRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + DaniiNewRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlDaniiNew), "Data/Danii-X-Modz-Loader-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Danii-X-Modz-Loader-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 15)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlScriptManager = webC.DownloadString(URLRPF + "dlscriptmanagerRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + ScriptManagerRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlScriptManager), "Data/Script-Manager-Loader-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Script-Manager-Loader-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 16)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlNotYourDope = webC.DownloadString(URLRPF + "dlNotYourDopeRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + NotYourDopeRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlNotYourDope), "Data/NotYourDope-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "NotYourDope-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 17)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlJames = webC.DownloadString(URLRPF + "dlJamesRebornRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + JamesRebornRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlJames), "Data/JamesRebornClean-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "JamesRebornClean-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 18)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlJames = webC.DownloadString(URLRPF + "dlJamesRebornAllRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + JamesRebornRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlJames), "Data/JamesRebornAntifreeze-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "JamesRebornAntifreeze-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 19)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlSer = webC.DownloadString(URLRPF + "dlSerenRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + SerenHonorRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlSer), "Data/SerendipityHonor-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "SerendipityHonor-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 20)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlhell = webC.DownloadString(URLRPF + "dlHelldemonRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + HelldemonRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlhell), "Data/HellDemon-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "HellDemon-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 21)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dljake = webC.DownloadString(URLRPF + "dlJakemodzRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + JakemodzRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dljake), "Data/JakeModz-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "JakeModz-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 22)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dltgs = webC.DownloadString(URLRPF + "dlTgsRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + TgsadouiRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dltgs), "Data/Tgsaudoi-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Tgsaudoi-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 23)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlevo = webC.DownloadString(URLRPF + "dlEvolutionRPF.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + EvolutionRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlevo), "Data/Evolution-v" + UI + ".rar");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Evolution-v" + UI + ".rar";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 24)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlw33d = webC.DownloadString(URLRPF + "dlw33d.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + W33DRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlw33d), "Data/W33D-RPF-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "W33D-RPF-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 25)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dldead = webC.DownloadString(URLRPF + "dldeadedit.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + DeadEditRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dldead), "Data/D34DEditz-RPF-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "D34DEditz-RPF-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }

            if (comboBoxEdit2.SelectedIndex == 26)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        var dlsom = webC.DownloadString(URLRPF + "dlsombra.txt");
                        WebClient webClient = new WebClient();
                        var UI = webClient.DownloadString(URLRPF + SombraRPF);
                        progressBarControl1.EditValue = 0;
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                        webClient.DownloadFileAsync(new Uri(dlsom), "Data/Sombra-RPF-v" + UI + ".zip");
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedRPF);
                        RPFZipFile = "Sombra-RPF-v" + UI + ".zip";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }
        }

        void FtpClient_OnUploadCompleted(object sender, UploadCompletedArgs e)
        {
            Thread.Sleep(1000);
            barStaticItem1.Caption = "gta5.sprx Uploaded to dev_hdd0/tmp";
            Thread.Sleep(1500);
            progressBarControl1.EditValue = 0;
            labelControl9.Text = "...";
            labelControl10.Text = "...";
        }

        void RPFFtpClient_OnUploadCompleted(object sender, UploadCompletedArgs e)
        {
            Thread.Sleep(1000);
            barStaticItem1.Caption = "update.rpf Uploaded to dev_hdd0/game/BLES01807/USRDIR";
            Thread.Sleep(500);
            progressBarControl1.EditValue = 0;
            labelControl9.Text = "...";
            labelControl10.Text = "...";
        }

        void FtpClient_OnUploadProgressChanged(object sender, UploadProgressChangedArgs e)
        {
            int value = Convert.ToInt32(e.BytesUploaded);
            Int64 PercentProgress = Convert.ToInt64(value * 100) / e.TotleBytes;
            int perc = Convert.ToInt32(PercentProgress.ToString());
            barStaticItem1.Caption = "Uploading ...  " + perc + "%";
            progressBarControl1.EditValue = perc;
            labelControl10.Text = e.TotleBytes.ToString();
            labelControl9.Text = e.BytesUploaded.ToString();
        }

        private void UploadSPRX()
        {
            string target = Path.Combine("dev_hdd0/tmp", Path.GetFileName("Data/gta5.sprx"));
            FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChanged);
            FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(FtpClient_OnUploadCompleted);
            FtpClient.Upload("Data/gta5.sprx", "\\" + target);
        }

        private void UploadRPF()
        {
            string target = Path.Combine("dev_hdd0/game/BLES01807/USRDIR", Path.GetFileName("Data/update.rpf"));
            FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChanged);
            FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(RPFFtpClient_OnUploadCompleted);
            FtpClient.Upload("Data/update.rpf", "\\" + target);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (SPRXZipFile != "" && File.Exists("Data/" + SPRXZipFile))
            {
                if (FTPconnected == true)
                {
                    labelControl7.Text = "Uploaded";
                    barStaticItem1.Caption = "Uploading Downloaded SPRX ...";
                    try
                    {
                        ZipFile.ExtractToDirectory("Data/" + SPRXZipFile, Application.StartupPath);
                        UploadSPRX();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        barStaticItem1.Caption = "Error with the Upload ...";
                    }
                }
                else
                {
                    XtraMessageBox.Show("Connect from the following form, then upload by clicking another time the Upload button :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    barStaticItem1.Caption = "Connecting FTP ...";
                    FTPConnectMods conn = new FTPConnectMods();
                    conn.Show();
                }
            }
            else
            {
                XtraMessageBox.Show("SPRX not found, please redownload and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barStaticItem1.Caption = "No SPRX found ...";
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (FTPconnected == true)
            {
                if (File.Exists("Data/update.rpf"))
                {
                    labelControl7.Text = "Uploaded";
                    barStaticItem1.Caption = "Uploading RPF ...";
                    try
                    {
                        UploadRPF();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        barStaticItem1.Caption = "Error with the Upload ...";
                    }
                }
                else
                {
                    XtraMessageBox.Show("First you have to unpack the archive downloaded containing the RPF File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Unpack the .rar first ...";
                }
            }
            else
            {
                XtraMessageBox.Show("Connect from the following form, then upload by clicking another time the Upload button :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                barStaticItem1.Caption = "Connecting FTP ...";
                FTPConnectMods conn = new FTPConnectMods();
                conn.Show();
            }
        }
    }
}