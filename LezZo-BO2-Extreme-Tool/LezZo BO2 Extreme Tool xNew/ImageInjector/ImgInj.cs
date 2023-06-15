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
using PS3Lib;
using LezZo_BO2_Extreme_Tool_xNew;
using LezZo_BO2_Extreme_Tool_xNew.Properties;
using System.Net;

namespace LezZo_BO2_Extreme_Tool_xNew.ImageInjector
{
    public partial class ImgInj : DevExpress.XtraEditors.XtraForm
    {

        private static PS3API PS3 = new PS3API();
        WebClient wc = new WebClient();

        public ImgInj()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void ImgInj_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(100);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogf = new OpenFileDialog
            {
                Filter = "DDS File|*.dds",
                Title = "Image Injector",
            };
            if (dialogf.ShowDialog() == DialogResult.OK)
            {
                byte[] buffer = File.ReadAllBytes(dialogf.FileName);
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
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
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
                    byte[] buffer = Resources.Abstract_Cosmo;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 1)
            {
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
                    byte[] buffer = Resources.Abstract_Galaxy_Purple;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 2)
            {
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
                    byte[] buffer = Resources.Android_Killer;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 3)
            {
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
                    byte[] buffer = Resources.Apple_Colored;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 4)
            {
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
                    byte[] buffer = Resources.Apple_Dark;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 5)
            {
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
                    byte[] buffer = Resources.Battlefield;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 6)
            {
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
                    byte[] buffer = Resources.Black_Cat;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 7)
            {
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
                    byte[] buffer = Resources.Circuit;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 8)
            {
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
                    byte[] buffer = Resources.Crime_Scene;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 9)
            {
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
                    byte[] buffer = Resources.Hack_DedSec;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 10)
            {
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
                    byte[] buffer = Resources.Electrum;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 11)
            {
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
                    byte[] buffer = Resources.Fantasy_Planet;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 12)
            {
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
                    byte[] buffer = Resources.Green_Cubes;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 13)
            {
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
                    byte[] buffer = Resources.Green_Hole;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 14)
            {
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
                    byte[] buffer = Resources.Green_Infinity;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 15)
            {
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
                    byte[] buffer = Resources.gun;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (comboBoxEdit1.SelectedIndex == 16)
            {
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
                    byte[] buffer = Resources.Hi_Tech;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 17)
            {
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
                    byte[] buffer = Resources.lamborghini;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 18)
            {
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
                    byte[] buffer = Resources.Programming;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 19)
            {
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
                    byte[] buffer = Resources.Via_Lactea;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 20)
            {
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
                    byte[] buffer = Resources.zombies;
                    PS3.SetMemory(0xCAD88480, buffer);
                }
                else
                {
                    XtraMessageBox.Show("You are not connected to the PS3! \nGo back in the main form to Connect and Attach to the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Create a new PNG Image with Photoshop. Dimensions: 1024 x 1024 Pixel.\nNow create your image and save it as PNG.\nNow with Google search an Online Conveter PNG to DDS. I suggest this one: http://www.aconvert.com/image/png-to-dds/ \nConvert your PNG to DDS and you are good to go. Inject it with the button 'Inject your Image' :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 1)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 2)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 3)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 4)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 5)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 6)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 7)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 8)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 9)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 10)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 11)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 12)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 13)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 14)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 15)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 16)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 17)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 18)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 19)
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
            }
            else if (comboBoxEdit1.SelectedIndex == 20)
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
            }
        }
    }
}