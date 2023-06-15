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
using System.Diagnostics;
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

namespace LezZo_BO2_Extreme_Tool_xNew.EBOOT_Builder
{
    public partial class EB_Bl : DevExpress.XtraEditors.XtraForm
    {

        #region definitions
        public byte[] eboot_buffer;
        public bool can_use_sprx = true;
        private string eboot_name = "";
        private string eboot_path = "";
        #endregion

        public EB_Bl()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void EB_Bl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
            }
            if (BO2.EBOOTtype == "MP")
            {
                labelControl1.Text = "LezZo Black Ops II Multiplayer EBOOT Builder";
            }
            else if (BO2.EBOOTtype == "ZM")
            {
                labelControl1.Text = "LezZo Black Ops II Zombies EBOOT BUilder";
                checkEdit1.Enabled = false;
                checkEdit2.Enabled = false;
                checkEdit3.Enabled = false;
                checkEdit5.Enabled = false;
                checkEdit9.Checked = false;
                checkEdit12.Checked = false;
                checkEdit15.Enabled = false;
                checkEdit22.Enabled = false;
                labelControl2.Enabled = false;
            }
        }

        private void EB_Bl_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(@"Files/tools/make_fself.exe") || (!File.Exists(@"Files/tools/ingame_loader.exe")) || (!File.Exists(@"Files/tools/scetool.exe")))
                XtraMessageBox.Show("Missing File detected !! Do not delete any of the files in the folder.\nMissing File: make_fself.exe, ingame_loader.exe or scetool.exe\nMake_fself is needed to build DEBUG EBOOT. \nIngame_loader is needed to set SPRX Loader. \nScetool is needed to Build CEX EBOOTS.", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            if (!File.Exists(@"Files/tools/ingame_loader.exe"))
            {
                can_use_sprx = false;
            }
            
            if (BO2.EBOOTtype == "MP")
            {
                if (!File.Exists(@"Files/MP-EBOOT.ELF"))
                {
                    if (File.Exists(@"Files/MP-EBOOT.ELF.ORIGINAL"))
                    {
                        File.Move(@"Files/MP-EBOOT.ELF.ORIGINAL", @"Files/MP-EBOOT.ELF");
                    }
                }
                else if (!File.Exists(@"Files/MP-EBOOT.ELF") && !File.Exists(@"Files/MP-EBOOT.ELF.ORIGINAL"))
                {
                    XtraMessageBox.Show("An error occured.. Original ELF File not found. \nPlease redownload my Tool and do not delete any of the files! :)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
     
                eboot_buffer = File.ReadAllBytes(@"Files/MP-EBOOT.ELF");
                eboot_name = "MP-EBOOT.ELF";
                eboot_path = @"Files/MP-EBOOT.ELF";
            }
            else if (BO2.EBOOTtype == "ZM")
            {
                if (!File.Exists(@"Files/ZM-EBOOT.ELF"))
                {
                    if (File.Exists(@"Files/ZM-EBOOT.ELF.ORIGINAL"))
                    {
                        File.Move(@"Files/ZM-EBOOT.ELF.ORIGINAL", @"Files/ZM-EBOOT.ELF");
                    }
                }
                else if (!File.Exists(@"Files/ZM-EBOOT.ELF") && !File.Exists(@"Files/ZM-EBOOT.ELF.ORIGINAL"))
                {
                    XtraMessageBox.Show("An error occured.. Original ELF File not found. \nPlease redownload my Tool and do not delete any of the files! :)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                eboot_buffer = File.ReadAllBytes(@"Files/ZM-EBOOT.ELF");
                eboot_name = "ZM-EBOOT.ELF";
                eboot_path = @"Files/ZM-EBOOT.ELF";
            }
        }

        private void checkEdit17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit17.Checked)
            {
                if (can_use_sprx == false)
                {
                    XtraMessageBox.Show("You cannot use this because ingame_loader.exe does not exist in the tools folder!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkEdit17.Checked = false;
                }
                if (textEdit2.Text == "/dev_hdd0/tmp/")
                {
                    XtraMessageBox.Show("You have to enter a filename first !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    checkEdit17.Checked = false;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!checkEdit14.Checked && !checkEdit21.Checked && !checkEdit22.Checked)
            {
                XtraMessageBox.Show("You have to select an output file type!! \nSelect if you want an EBOOT CEX, DEBUG or a DEBUG Self.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                splashScreenManager2.ShowWaitForm();
                BuildEboot();
                splashScreenManager2.CloseWaitForm();
            }
            
        }

        private BinaryWriter bw;
        private BinaryWriter bw2;

        private void BuildEboot()
        {
            File.WriteAllBytes(eboot_path + ".ORIGINAL", eboot_buffer);
            File.Move(eboot_path, Application.StartupPath + "/" + eboot_name);

            if (checkEdit1.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x2c, 3, 0, 1 };
                bw.BaseStream.Position = 0x33cb4L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit2.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                bw.BaseStream.Position = 0x23c60L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit3.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x38, 0x60, 0, 1 };
                bw.BaseStream.Position = 0x683e0L;
                bw.Write(buffer);
                bw.Close();

                bw2 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer2 = new byte[4];
                buffer2[0] = 0x60;
                bw2.BaseStream.Position = 0x68604L;
                bw2.Write(buffer2);
                bw2.Close();
            }
            if (checkEdit4.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x2c, 3, 0, 1 };
                bw.BaseStream.Position = 0xdf68cL;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit5.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x38, 0xc0, 0xff, 0xff };
                bw.BaseStream.Position = 0x734d0L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit6.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[4];
                buffer[0] = 0x2c;
                buffer[1] = 4;
                bw.BaseStream.Position = 0x5e0a20L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit7.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                bw.BaseStream.Position = 0xe9e54L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit8.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x3f, 0xff, 0xff, 0 };
                bw.BaseStream.Position = 0x1cc6e98L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit9.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x43, 0x48 };
                bw.BaseStream.Position = 0x1cd03d8L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit10.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x41, 0x80 };
                bw.BaseStream.Position = 0x52fc6cL;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit11.Checked)
            {
                if (BO2.EBOOTtype == "ZM")
                {
                    bw = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer = new byte[4];
                    buffer[0] = 0x60;
                    bw.BaseStream.Position = 0x78604L;
                    bw.Write(buffer);
                    bw.Close();
                }
                else if (BO2.EBOOTtype == "MP")
                {
                    bw = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer = new byte[1];
                    bw.BaseStream.Position = 0x1cd3908L;
                    bw.Write(buffer);
                    bw.Close();
                    bw2 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer2 = new byte[] { 1 };
                    bw2.BaseStream.Position = 0x1cd330bL;
                    bw2.Write(buffer2);
                    bw2.Close();
                    BinaryWriter bw3 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer3 = new byte[] { 1 };
                    bw3.BaseStream.Position = 0x1cd3d8bL;
                    bw3.Write(buffer3);
                    bw3.Close();
                    BinaryWriter bw4 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer4 = new byte[] { 1 };
                    bw4.BaseStream.Position = 0x1cd342bL;
                    bw4.Write(buffer4);
                    bw4.Close();
                }
            }
            if (checkEdit12.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 1 };
                bw.BaseStream.Position = 0x1cc4bf8L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit16.Checked)
            {
                if (BO2.EBOOTtype == "MP")
                {
                    bw2 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer2 = new byte[] { 0x99 };
                    bw2.BaseStream.Position = 0x4fa38fL;
                    bw2.Write(buffer2);
                    bw2.Close();
                    BinaryWriter bw3 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer3 = new byte[4];
                    buffer3[0] = 0x60;
                    bw3.BaseStream.Position = 0x4fba74L;
                    bw3.Write(buffer3);
                    bw3.Close();
                    BinaryWriter bw4 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer4 = new byte[4];
                    buffer4[0] = 0x60;
                    bw4.BaseStream.Position = 0x537dd4L;
                    bw4.Write(buffer4);
                    bw4.Close();
                    BinaryWriter bw5 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer5 = new byte[4];
                    buffer5[0] = 0x60;
                    bw5.BaseStream.Position = 0x538148L;
                    bw5.Write(buffer5);
                    bw5.Close();
                    BinaryWriter bw6 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer6 = new byte[2];
                    buffer6[0] = 0x48;
                    bw6.BaseStream.Position = 0x4fb61cL;
                    bw6.Write(buffer6);
                    bw6.Close();
                    BinaryWriter bw7 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer7 = new byte[] { 0x48, 0x80 };
                    bw7.BaseStream.Position = 0x4fa3bcL;
                    bw7.Write(buffer7);
                    bw7.Close();
                    BinaryWriter bw8 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer8 = new byte[4];
                    buffer8[0] = 0x60;
                    bw8.BaseStream.Position = 0x5200e8L;
                    bw8.Write(buffer8);
                    bw8.Close();
                    BinaryWriter bw9 = new BinaryWriter(File.OpenWrite(eboot_name));
                    byte[] buffer9 = new byte[4];
                    buffer9[0] = 0x60;
                    bw9.BaseStream.Position = 0x5200f4L;
                    bw9.Write(buffer9);
                    bw9.Close();
                }
                else if (BO2.EBOOTtype == "ZM")
                {
                    //Already Written in the ELF
                }
            }
            if (checkEdit13.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                bw.BaseStream.Position = 0x3db130L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit20.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x38, 0x60, 0, 1 };
                bw.BaseStream.Position = 0x35e96cL;
                bw.Write(buffer);
                bw.Close();
                bw2 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer2 = new byte[4];
                buffer2[0] = 0x60;
                bw2.BaseStream.Position = 0x35e9a0L;
                bw2.Write(buffer2);
                bw2.Close();
                BinaryWriter bw3 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer3 = new byte[4];
                buffer3[0] = 0x60;
                bw3.BaseStream.Position = 0x35ea64L;
                bw3.Write(buffer3);
                bw3.Close();
                BinaryWriter bw4 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer4 = new byte[4];
                buffer4[0] = 0x60;
                bw4.BaseStream.Position = 0x381154L;
                bw4.Write(buffer4);
                bw4.Close();
                BinaryWriter bw5 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer5 = new byte[4];
                buffer5[0] = 0x60;
                bw5.BaseStream.Position = 0x35e9e4L;
                bw5.Write(buffer5);
                bw5.Close();
                BinaryWriter bw6 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer6 = new byte[4];
                buffer6[0] = 0x60;
                bw6.BaseStream.Position = 0x351b74L;
                bw6.Write(buffer6);
                bw6.Close();
                BinaryWriter bw7 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer7 = new byte[4];
                buffer7[0] = 0x60;
                bw7.BaseStream.Position = 0x351b4cL;
                bw7.Write(buffer7);
                bw7.Close();
                BinaryWriter bw8 = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer8 = new byte[4];
                buffer8[0] = 0x48;
                buffer8[3] = 4;
                bw8.BaseStream.Position = 0x351b58L;
                bw8.Write(buffer8);
                bw8.Close();
            }
            if (checkEdit18.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                bw.BaseStream.Position = 0x78604L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit15.Checked)
            {
                bw = new BinaryWriter(File.OpenWrite(eboot_name));
                byte[] buffer = new byte[] { 0x40, 0x00 };
                bw.BaseStream.Position = 0x4a8310L;
                bw.Write(buffer);
                bw.Close();
            }
            if (checkEdit17.Checked)
            {
                if (can_use_sprx == true)
                {
                    if (textEdit2.Text.IndexOf(".sprx") == -1)
                        textEdit2.Text += ".sprx";

                    if (File.Exists(@"Files/tools/ingame_loader.exe"))
                        File.Move(@"Files/tools/ingame_loader.exe", @"ingame_loader.exe");

                    Process sprxL = new Process();
                    sprxL.StartInfo.FileName = "ingame_loader.exe";
                    sprxL.StartInfo.WorkingDirectory = Application.StartupPath;
                    sprxL.StartInfo.Arguments = eboot_name + " " + textEdit2.Text + " sprx_ps3f.elf";
                    sprxL.StartInfo.CreateNoWindow = true;
                    sprxL.StartInfo.UseShellExecute = false;
                    sprxL.Start();
                    sprxL.WaitForExit();

                    Application.DoEvents();
                    
                    File.Delete(Application.StartupPath + "/" + eboot_name);
                    File.Move(@"sprx_ps3f.elf", eboot_name);
                }
            }

            Application.DoEvents();

            if (checkEdit21.Checked && BO2.EBOOTtype == "MP")
            {
                File.Move(@"Files/tools/make_fself.exe", @"make_fself.exe");

                Process comp = new Process();
                comp.StartInfo.FileName = "make_fself.exe";
                comp.StartInfo.WorkingDirectory = Application.StartupPath;
                comp.StartInfo.Arguments = eboot_name + " DEX-MP-EBOOT.BIN";
                comp.StartInfo.CreateNoWindow = true;
                comp.StartInfo.UseShellExecute = false;
                comp.Start();
                comp.WaitForExit();

                Application.DoEvents();

                Thread.Sleep(1000);
            }
            else if (checkEdit21.Checked && BO2.EBOOTtype == "ZM")
            {
                File.Move(@"Files/tools/make_fself.exe", @"make_fself.exe");

                Process comp = new Process();
                comp.StartInfo.FileName = "make_fself.exe";
                comp.StartInfo.WorkingDirectory = Application.StartupPath;
                comp.StartInfo.Arguments = eboot_name + " DEX-ZM-EBOOT.BIN";
                comp.StartInfo.CreateNoWindow = true;
                comp.StartInfo.UseShellExecute = false;
                comp.Start();
                comp.WaitForExit();

                Application.DoEvents();

                Thread.Sleep(1000);
            }

            if (checkEdit22.Checked && BO2.EBOOTtype == "MP")
            {
                File.Move(@"Files/tools/make_fself.exe", @"make_fself.exe");

                Process comp = new Process();
                comp.StartInfo.FileName = "make_fself.exe";
                comp.StartInfo.WorkingDirectory = Application.StartupPath;
                comp.StartInfo.Arguments = eboot_name + " DEBUG-t6mp_ps3f.self";
                comp.StartInfo.CreateNoWindow = true;
                comp.StartInfo.UseShellExecute = false;
                comp.Start();
                comp.WaitForExit();

                Application.DoEvents();

                Thread.Sleep(1000);
            }

            if (checkEdit14.Checked && BO2.EBOOTtype == "MP")
            {
                Directory.Move(@"Files/tools/data", @"data");
                File.Move(@"Files/tools/zlib1.dll", @"zlib1.dll");
                File.Move(@"Files/tools/scetool.exe", @"scetool.exe");
                Process comp = new Process();
                comp.StartInfo.FileName = "scetool.exe";
                comp.StartInfo.Arguments = " --sce-type=SELF --compress-data=TRUE --skip-sections=TRUE --key-revision=10 --self-auth-id=1010000001000003 --self-vendor-id=01000002 --self-type=NPDRM --self-app-version=0001000000000000 --self-fw-version=0004004600000000 --np-content-id=UP0002 - BLES01718_00 - CODBLOPS2PATCH09 --self-type=APP --encrypt " + eboot_name + " MP-BLES01718-EBOOT.BIN";
                comp.StartInfo.CreateNoWindow = true;
                comp.StartInfo.UseShellExecute = false;
                comp.Start();
                comp.WaitForExit();
                
                Application.DoEvents();

                Thread.Sleep(1000);
            }
            else if (checkEdit14.Checked && BO2.EBOOTtype == "ZM")
            {
                Directory.Move(@"Files/tools/data", @"data");
                File.Move(@"Files/tools/zlib1.dll", @"zlib1.dll");
                File.Move(@"Files/tools/scetool.exe", @"scetool.exe");
                Process comp = new Process();
                comp.StartInfo.FileName = "scetool.exe";
                comp.StartInfo.WorkingDirectory = Application.StartupPath;
                comp.StartInfo.Arguments = " --sce-type=SELF --compress-data=TRUE --skip-sections=TRUE --key-revision=10 --self-auth-id=1010000001000003 --self-vendor-id=01000002 --self-type=NPDRM --self-app-version=0001000000000000 --self-fw-version=0004004600000000 --np-content-id=UP0002 - BLES01718_00 - CODBLOPS2PATCH09 --self-type=APP --encrypt " + eboot_name + " ZM-BLES01718-EBOOT.BIN";
                comp.StartInfo.CreateNoWindow = true;
                comp.StartInfo.UseShellExecute = false;
                comp.Start();
                comp.WaitForExit();

                Application.DoEvents();

                Thread.Sleep(1000);
            }
            
            if (File.Exists(@"make_fself.exe"))
                File.Move(@"make_fself.exe", "Files/tools/make_fself.exe");

            if (Directory.Exists(@"data"))
                Directory.Move(@"data", @"Files/tools/data");

            if (File.Exists(@"zlib1.dll"))
                File.Move(@"zlib1.dll", "Files/tools/zlib1.dll");

            if (File.Exists(@"scetool.exe"))
                File.Move(@"scetool.exe", "Files/tools/scetool.exe");

            if (File.Exists(@"ingame_loader.exe"))
                File.Move(@"ingame_loader.exe", @"Files/tools/ingame_loader.exe");

            if (File.Exists(Application.StartupPath + "/" + eboot_name))
                File.Delete(Application.StartupPath + "/" + eboot_name);

            if (File.Exists(@"Files/MP-EBOOT.ELF.ORIGINAL"))
                File.Move(@"Files/MP-EBOOT.ELF.ORIGINAL", @"Files/MP-EBOOT.ELF");

            if (File.Exists(@"Files/ZM-EBOOT.ELF.ORIGINAL"))
                File.Move(@"Files/ZM-EBOOT.ELF.ORIGINAL", @"Files/ZM-EBOOT.ELF");
            
            OpenFolder(Application.StartupPath);
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
            };

            Process.Start(startInfo);
            }
        }

        private void checkEdit11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit11.Checked)
            {
                XtraMessageBox.Show("Force host works with a good internet connection, and with game mods with a lot of players!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkEdit14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit14.Checked)
            {
                checkEdit21.Checked = false;
                checkEdit22.Checked = false;
            }
        }

        private void checkEdit21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit21.Checked)
            {
                checkEdit14.Checked = false;
                checkEdit22.Checked = false;
            }
        }

        private void checkEdit22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit22.Checked)
            {
                checkEdit14.Checked = false;
                checkEdit21.Checked = false;
            }
        }
    }
}