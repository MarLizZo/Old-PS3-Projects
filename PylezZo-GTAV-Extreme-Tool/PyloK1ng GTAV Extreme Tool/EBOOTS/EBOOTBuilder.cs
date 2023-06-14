using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
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
    public partial class EBOOTBuilder : DevExpress.XtraEditors.XtraForm
    {
        public EBOOTBuilder()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        #region definitions
        public byte[] eboot_buffer;
        public bool can_use_sprx = true;
        private string eboot_name = "";
        private string eboot_path = "";
        private BinaryWriter bw;
        private BinaryWriter bw2;
        private BinaryWriter bw3;
        private BinaryWriter bw4;
        #endregion

        private void EBOOTBuilder_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Files/EBOOT.ELF"))
            {
                if (File.Exists("Files/EBOOT.ELF.ORIGINAL"))
                {
                    File.Move("Files/EBOOT.ELF.ORIGINAL", "Files/EBOOT.ELF");
                }
            }
            else if (!File.Exists("Files/EBOOT.ELF") && !File.Exists("Files/EBOOT.ELF.ORIGINAL"))
            {
                XtraMessageBox.Show("An error occured.. Original ELF File not found. \nPlease redownload the package and do not delete any of the files! :)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (!File.Exists("Files/make_fself.exe"))
            {
                XtraMessageBox.Show("The make_fself.exe does not exists in the Tool folder. \nRedownload the Tool package and do not delete any file. \nYou can continue to use the tool anyway, but you cannot build DEX EBOOTS without the make_fself.exe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!File.Exists("Files/scetool.exe") && File.Exists("Files/zlib1.dll"))
            {
                XtraMessageBox.Show("The scetool.exe or the zlib1.dll does not exists in the Tool folder. \nRedownload the Tool package and do not delete any file. \nYou can continue to use the tool anyway, but you cannot build CEX EBOOTS without those files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists("Files/ingame_loader.exe"))
            {
                can_use_sprx = true;
            }
            else
            {
                XtraMessageBox.Show("The ingame_loader.exe does not exists in the Tool folder. \nRedownload the Tool package and do not delete any file. \nYou can continue to use the tool anyway, but you cannot use the SPRX Loader function..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                can_use_sprx = false;
            }

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
            }

            eboot_buffer = File.ReadAllBytes("Files/EBOOT.ELF");
            eboot_path = "Files/EBOOT.ELF";
            eboot_name = "EBOOT.ELF";
        }

        private void checkEdit7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit7.Checked)
            {
                if (can_use_sprx == false)
                {
                    XtraMessageBox.Show("You cannot use this because ingame_loader.exe does not exist in the tools folder!! \nRedownload the tool..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkEdit7.Checked = false;
                }
                if (!textEdit1.Text.Contains(".sprx"))
                {
                    XtraMessageBox.Show("You have to enter a file extension first (.sprx) !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    checkEdit7.Checked = false;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            barStaticItem1.Caption = "Building EBOOT ...";
            File.WriteAllBytes(eboot_path + ".ORIGINAL", eboot_buffer);
            File.Move(eboot_path, Application.StartupPath + "/" + eboot_name);

            if (checkEdit3.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                bw.BaseStream.Position = 0x578;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit4.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                bw.BaseStream.Position = 0x1306254;
                bw.Write(buffer);
                bw.Close();

                bw2 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer2 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                bw2.BaseStream.Position = 0x9A3AF8;
                bw2.Write(buffer);
                bw2.Close();

                bw3 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer3 = new byte[] { 0x48, 0, 1, 0x10 };
                bw3.BaseStream.Position = 0xA900C4;
                bw3.Write(buffer);
                bw3.Close();

                bw4 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer4 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                bw4.BaseStream.Position = 0xA9B3E0;
                bw4.Write(buffer);
                bw4.Close();
            }
            if (checkEdit5.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                bw.BaseStream.Position = 0x3F8B84;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit6.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x48, 0, 1, 0x38 };
                bw.BaseStream.Position = 0x3EA510;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit7.Checked)
            {
                if (can_use_sprx == true)
                {
                    if (textEdit1.Text.IndexOf(".sprx") == -1)
                        textEdit1.Text += ".sprx";

                    if (File.Exists("Files/ingame_loader.exe"))
                        File.Move("Files/ingame_loader.exe", "ingame_loader.exe");

                    Process sprxL = new Process();
                    sprxL.StartInfo.FileName = "ingame_loader.exe";
                    sprxL.StartInfo.WorkingDirectory = Application.StartupPath;
                    sprxL.StartInfo.Arguments = eboot_name + " " + textEdit1.Text + " sprx_ps3f.elf";
                    sprxL.StartInfo.CreateNoWindow = true;
                    sprxL.StartInfo.UseShellExecute = false;
                    sprxL.Start();
                    sprxL.WaitForExit();

                    Application.DoEvents();

                    File.Delete(Application.StartupPath + "/" + eboot_name);
                    File.Move("sprx_ps3f.elf", eboot_name);
                }
            }

            Application.DoEvents();

            if (checkEdit1.Checked)
            {
                Directory.Move("Files/data", "data");
                File.Move("Files/zlib1.dll", "zlib1.dll");
                File.Move("Files/scetool.exe", "scetool.exe");
                Process comp = new Process();
                comp.StartInfo.FileName = "scetool.exe";
                comp.StartInfo.Arguments = " --sce-type=SELF --compress-data=TRUE --skip-sections=TRUE --key-revision=0A --self-auth-id=1010000001000003 --self-vendor-id=01000002 --self-app-version=0001000000000000 --self-fw-version=0004004600000000 --self-type=APP --encrypt " + eboot_name + " CEX-BLES01807-EBOOT.BIN";
                comp.StartInfo.CreateNoWindow = true;
                comp.StartInfo.UseShellExecute = false;
                comp.Start();
                comp.WaitForExit();
             
                Application.DoEvents();

                Thread.Sleep(1000);
            }
            if (checkEdit2.Checked)
            {
                File.Move("Files/make_fself.exe", "make_fself.exe");

                Process comp = new Process();
                comp.StartInfo.FileName = "make_fself.exe";
                comp.StartInfo.WorkingDirectory = Application.StartupPath;
                comp.StartInfo.Arguments = "-c " + eboot_name + " DEX-GTAV-EBOOT.BIN";
                comp.StartInfo.CreateNoWindow = true;
                comp.StartInfo.UseShellExecute = false;
                comp.Start();
                comp.WaitForExit();

                Application.DoEvents();

                Thread.Sleep(1000);
            }

            if (File.Exists("make_fself.exe"))
                File.Move("make_fself.exe", "Files/make_fself.exe");

            if (Directory.Exists("data"))
                Directory.Move("data", @"Files/data");

            if (File.Exists("zlib1.dll"))
                File.Move("zlib1.dll", "Files/zlib1.dll");

            if (File.Exists("scetool.exe"))
                File.Move("scetool.exe", "Files/scetool.exe");

            if (File.Exists("ingame_loader.exe"))
                File.Move("ingame_loader.exe", "Files/ingame_loader.exe");

            if (File.Exists(Application.StartupPath + "/" + eboot_name))
                File.Delete(Application.StartupPath + "/" + eboot_name);

            if (File.Exists("Files/EBOOT.ELF.ORIGINAL"))
                File.Move("Files/EBOOT.ELF.ORIGINAL", "Files/EBOOT.ELF");

            splashScreenManager2.CloseWaitForm();
            barStaticItem1.Caption = "EBOOT built !! ";
            OpenFolder(Application.StartupPath);
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo { Arguments = folderPath, FileName = "explorer.exe" };
                Process.Start(startInfo);
            }
        }
    }
}