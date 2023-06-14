using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
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

namespace PylezZo_GTAV_Extreme_Tool.EBOOTS
{
    public partial class EBOOTDL : DevExpress.XtraEditors.XtraForm
    {
        public EBOOTDL()
        {
            InitializeComponent();
        }

        #region definitions
        private bool iswebfree = true;
        private string EBname = "";
        private static bool FTPconnected = false;
        public static FTPclient FtpClient;
        private static string directory;

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
                XtraMessageBox.Show("Error, please retry. Note: To Connect your PS3 vai FTP you need to: \nInstall webMAN MOD, or launch MultiMAN, or launch REBUG Toolbox. \nThese Homebrew has an FTP service. Without one of these Apps you cannot connect. \n\nAlso you need to activate your Internet Connection, and be sure to enter the right IP Address. \n\nHere is the error commented by the sistem: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion

        private void EBOOTDL_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
            }
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {

            }
            else
            {
                XtraMessageBox.Show("Your Internet Connection is not working, or there is another error. \nObviously it is needed in order to download the EBOOTS.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
        }

        private void comboBoxEdit6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit6.SelectedIndex == 0)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- No Mods. This is the original EBOOT";
            }
            else if (comboBoxEdit6.SelectedIndex == 1)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass";
            }
            else if (comboBoxEdit6.SelectedIndex == 2)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass" + Environment.NewLine + "- Object Bypass" + Environment.NewLine + "- Cash Drop Bypass ( AntiBan )" + Environment.NewLine + "- SPRX Loader (GTA.sprx)";
            }
            else if (comboBoxEdit6.SelectedIndex == 3)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass" + Environment.NewLine + "- Object Bypass" + Environment.NewLine + "- AntiBan" + Environment.NewLine + "- SPRX Loader (gta5.sprx)" + Environment.NewLine + "- No Rockstar Intro" + Environment.NewLine + "- No Timeout" + Environment.NewLine + "- Block call from Simeon" + Environment.NewLine + "- Badsport Bypass" + Environment.NewLine + "- Max value Bypass (5.0) for SET_MOVE_SPEED_MULTIPLIER and SET_SWIM_SPEED_MUTLIPLIER" + Environment.NewLine + "- Anti Teleport on Foot" + Environment.NewLine + "- Anti Get-CID" + Environment.NewLine + "- Unlock Online in Prologue" + Environment.NewLine + "- Anti FreezeBG.rpf" + Environment.NewLine + "- Anti Check MPPLY" + Environment.NewLine + "- Anti Animations" + Environment.NewLine + "- Anti PFX" + Environment.NewLine + "- Anti Give Weapons" + Environment.NewLine + "- Anti Remove Weapons" + Environment.NewLine + "- Anti Vote Kick" + Environment.NewLine + "- Anti Facebook MSG" + Environment.NewLine + "- Anti Check Cash" + Environment.NewLine + "- Anti Clear Tasks" + Environment.NewLine + "- Anti Explosion" + Environment.NewLine + "- Anti Get MAC Address" + Environment.NewLine + "- Anti Server Error" + Environment.NewLine + "- Anti Check Stats" + Environment.NewLine + "- Model Freeze Protection";
            }
        }

        private void comboBoxEdit7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit7.SelectedIndex == 0)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass";
            }
            else if (comboBoxEdit7.SelectedIndex == 1)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass" + Environment.NewLine + "- Object Bypass" + Environment.NewLine + "- Cash Drop Bypass ( AntiBan )" + Environment.NewLine + "- SPRX Loader (GTA.sprx)";
            }
            else if (comboBoxEdit7.SelectedIndex == 2)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass" + Environment.NewLine + "- Object Bypass" + Environment.NewLine + "- Cash Drop Bypass ( AntiBan )" + Environment.NewLine + "- SPRX Loader (gta5.sprx)" + Environment.NewLine + "- No Timeout" + Environment.NewLine + "- Badsport Bypass" + Environment.NewLine + "- Anti Get-CID" + Environment.NewLine + "- Unlock Online in Prologue" + Environment.NewLine + "- Anti Script Freeze" + Environment.NewLine + "- Anti Check MPPLY" + Environment.NewLine + "- Anti Limit Cash" + Environment.NewLine + "- Anti Report Cash" + Environment.NewLine + "- Anti Server Error" + Environment.NewLine + "- Anti Get MAC Address";
            }
            else if (comboBoxEdit7.SelectedIndex == 3)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass" + Environment.NewLine + "- Object Bypass" + Environment.NewLine + "- Cash Drop Bypass ( AntiBan )" + Environment.NewLine + "- SPRX Loader (GTA.sprx)" + Environment.NewLine + "- Anti Force Tasks" + Environment.NewLine + "- Anti Clear Tasks" + Environment.NewLine + "- Anti Play Sounds" + Environment.NewLine + "- Anti Wanted Level" + Environment.NewLine + "- Anti Request Vehicle Control" + Environment.NewLine + "- Anti PTFX" + Environment.NewLine + "- Anti Fire" + Environment.NewLine + "- Anti Give Weapons" + Environment.NewLine + "- Anti Remove Weapons" + Environment.NewLine + "- Anti Explosion" + Environment.NewLine + "- Anti Projectiles" + Environment.NewLine + "- Anti Kick Vote";
            }
            else if (comboBoxEdit7.SelectedIndex == 4)
            {
                memoEdit1.Text = "The Selected EBOOT Contains:" + Environment.NewLine + Environment.NewLine + "- Script Bypass" + Environment.NewLine + "- Object Bypass" + Environment.NewLine + "- AntiBan" + Environment.NewLine + "- SPRX Loader (gta5.sprx)" + Environment.NewLine + "- No Rockstar Intro" + Environment.NewLine + "- No Timeout" + Environment.NewLine + "- Badsport Bypass" + Environment.NewLine + "- Max value Bypass (5.0) for SET_MOVE_SPEED_MULTIPLIER and SET_SWIM_SPEED_MUTLIPLIER" + Environment.NewLine + "- Anti Teleport on Foot" + Environment.NewLine + "- Anti Get-CID" + Environment.NewLine + "- Unlock Online in Prologue" + Environment.NewLine + "- Anti FreezeBG.rpf" + Environment.NewLine + "- Anti Check MPPLY" + Environment.NewLine + "- Anti Animations" + Environment.NewLine + "- Anti PFX" + Environment.NewLine + "- Anti Give Weapons" + Environment.NewLine + "- Anti Remove Weapons" + Environment.NewLine + "- Anti Vote Kick" + Environment.NewLine + "- Anti Facebook MSG" + Environment.NewLine + "- Anti Check Cash" + Environment.NewLine + "- Anti Clear Tasks" + Environment.NewLine + "- Anti Explosion" + Environment.NewLine + "- Anti Get MAC Address" + Environment.NewLine + "- Anti Server Error" + Environment.NewLine + "- Anti Check Stats" + Environment.NewLine + "- Model Freeze Protection";
            }
        }

        private void DownloadProgress4(object sender, DownloadProgressChangedEventArgs e)
        {
            barStaticItem1.Caption = "Downloading ...  " + e.ProgressPercentage.ToString() + "%";
            labelControl5.Text = e.BytesReceived.ToString();
            labelControl6.Text = e.TotalBytesToReceive.ToString();
            progressBarControl4.EditValue = e.ProgressPercentage;
        }

        private void CompletedEboot(object sender, AsyncCompletedEventArgs e)
        {
            if (XtraMessageBox.Show("Download Completed! \nYou will find the EBOOT in the Data folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                progressBarControl4.EditValue = 0;
                barStaticItem1.Caption = "Waiting Command ...";
                iswebfree = true;
            }
        }

        private bool IswebCFree()
        {
            if (iswebfree == true)
                return true;
            else return false;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit6.SelectedIndex == 0)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ... ";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/CEX/ORIG/EBOOT.BIN"), "Data/1-CEX-ORIG-EBOOT.BIN");
                        EBname = "1-CEX-ORIG-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }

            if (comboBoxEdit6.SelectedIndex == 1)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ... ";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/CEX/New1/EBOOT.BIN"), @"Data/2-CEX-EBOOT.BIN");
                        EBname = "2-CEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }

            if (comboBoxEdit6.SelectedIndex == 2)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ... ";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/CEX/1/EBOOT.BIN"), @"Data/3-CEX-EBOOT.BIN");
                        EBname = "3-CEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }

            if (comboBoxEdit6.SelectedIndex == 3)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ... ";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/CEX/2/EBOOT.BIN"), @"Data/4-CEX-EBOOT.BIN");
                        EBname = "4-CEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit7.SelectedIndex == 0)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ...";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/DEX/New1/EBOOT.BIN"), @"Data/1-DEX-EBOOT.BIN");
                        EBname = "1-DEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }

            if (comboBoxEdit7.SelectedIndex == 1)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ...";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/DEX/1/EBOOT.BIN"), @"Data/1-DEX-EBOOT.BIN");
                        EBname = "1-DEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }

            if (comboBoxEdit7.SelectedIndex == 2)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ...";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/DEX/2/EBOOT.BIN"), @"Data/2-DEX-EBOOT.BIN");
                        EBname = "2-DEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }

            if (comboBoxEdit7.SelectedIndex == 3)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ...";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/DEX/3/EBOOT.BIN"), @"Data/3-DEX-EBOOT.BIN");
                        EBname = "3-DEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }

            if (comboBoxEdit7.SelectedIndex == 4)
            {
                try
                {
                    if (IswebCFree() == true)
                    {
                        iswebfree = false;
                        barStaticItem1.Caption = "Downloading ...";
                        labelControl3.Text = "Downloaded";
                        progressBarControl4.EditValue = 0;
                        WebClient webClient = new WebClient();
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedEboot);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress4);
                        webClient.DownloadFileAsync(new Uri("http://www.cybermodding.it/PylezZo-Tool/EBOOTS/DEX/4/EBOOT.BIN"), @"Data/4-DEX-EBOOT.BIN");
                        EBname = "4-DEX-EBOOT.BIN";
                    }
                    else
                    {
                        XtraMessageBox.Show("Another Download is on the way. \nWait for the end of the current Download, then retry :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barStaticItem1.Caption = "Error ...";
                    iswebfree = true;
                }
            }
        }

        void FtpClient_OnUploadCompleted(object sender, UploadCompletedArgs e)
        {
            Thread.Sleep(1000);
            barStaticItem1.Caption = "EBOOT Uploaded to dev_hdd0/game/BLES01807/USRDIR";
            Thread.Sleep(500);
            progressBarControl4.EditValue = 0;
            labelControl5.Text = "...";
            labelControl6.Text = "...";
        }

        void FtpClient_OnUploadProgressChanged(object sender, UploadProgressChangedArgs e)
        {
            int value = Convert.ToInt32(e.BytesUploaded);
            Int64 PercentProgress = Convert.ToInt64(value * 100) / e.TotleBytes;
            int perc = Convert.ToInt32(PercentProgress.ToString());
            barStaticItem1.Caption = "Uploading ...  " + perc + "%";
            progressBarControl4.EditValue = perc;
            labelControl6.Text = e.TotleBytes.ToString();
            labelControl5.Text = e.BytesUploaded.ToString();
        }

        private void UploadEBOOT()
        {
            string target = Path.Combine("dev_hdd0/game/BLES01807/USRDIR", Path.GetFileName("Data/EBOOT.BIN"));
            FtpClient.OnUploadProgressChanged += new FTPclient.UploadProgressChangedHandler(FtpClient_OnUploadProgressChanged);
            FtpClient.OnUploadCompleted += new FTPclient.UploadCompletedHandler(FtpClient_OnUploadCompleted);
            FtpClient.Upload("Data/EBOOT.BIN", "\\" + target);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (EBname != "")
            {
                if (File.Exists("Data/" + EBname))
                {
                    if (FTPconnected == true)
                    {
                        labelControl3.Text = "Uploaded";
                        UploadEBOOT();
                    }
                    else
                    {
                        FTPConnectEB conn = new FTPConnectEB();
                        conn.Show();
                    }
                }
                else
                {
                    XtraMessageBox.Show("The File does not exists in the 'Data' folder. \nPlease re-download the EBOOT and retry to Upload.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("You haven't downloaded any EBOOT. \nPlease download an EBOOT and retry to Upload.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (EBname != "")
            {
                if (File.Exists("Data/" + EBname))
                {
                    File.Move("Data/" + EBname, "Data/EBOOT.BIN");
                    if (FTPconnected == true)
                    {
                        labelControl3.Text = "Uploaded";
                        UploadEBOOT();
                    }
                    else
                    {
                        FTPConnectEB conn = new FTPConnectEB();
                        conn.Show();
                    }
                }
                else
                {
                    XtraMessageBox.Show("The File does not exists in the 'Data' folder. \nPlease re-download the EBOOT and retry to Upload.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("You haven't downloaded any EBOOT. \nPlease download an EBOOT and retry to Upload.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}