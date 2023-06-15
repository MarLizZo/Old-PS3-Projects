using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using LezZo_BO2_Extreme_Tool_xNew.ImageInjector;
using PS3Lib;

namespace LezZo_BO2_Extreme_Tool_xNew
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        #region vars
        private static PS3API PS3 = new PS3API();
        string ConnectionMethod = "";
        byte[] CombSetClan;
        private static string timeWatch = "";
        private static WebClient WC = new WebClient();
        public static TimeSpan Elapsed;
        private static Stopwatch stopWatch = new Stopwatch();
        private static Stopwatch stopWatch1 = new Stopwatch();
        private static Stopwatch stopWatch2 = new Stopwatch();
        private static Stopwatch stopWatch3 = new Stopwatch();
        private static Thread thread_0;
        private static ThreadStart threadStart_0;
        private static Thread thread_1;
        private static ThreadStart threadStart_1;
        private static Thread thread_2;
        private static ThreadStart threadStart_2;
        private static Thread thread_3;
        private static ThreadStart threadStart_3;
        private static Thread thread_4;
        private static ThreadStart threadStart_4;
        private static Thread thread_6;
        private static Thread thread_7;
        private static ThreadStart threadStart_6;
        private static ThreadStart threadStart_7;
        private static bool bool_103 = false;
        private static bool bool_104 = false;
        private static bool bool_100 = false;
        private static bool bool_101 = false;
        private static bool bool_99 = false;
        private static bool bool_999 = false;
        private static string tx27 = "";
        private static string tx4 = "";
        private static string tx8 = "";
        private static string tx6 = "";
        private static string tx7 = "";
        private static string tx10 = "";
        private static string tx11 = "";
        private static string tx9 = "";
        private static string tx12 = "";
        private static string tx13 = "";
        private static string tx29 = "";
        private static string tx30 = "";
        private static string tx31 = "";
        private static string tx33 = "";
        private static string tx35 = "";
        private static string tx36 = "";
        private static string tx34 = "";
        private static string tx32 = "";
        private static bool bool_98 = false;
        private static bool bool_97 = false;
        private bool AimbotAlert = false;
        private bool bool_0 = false;
        private bool rpcConnected = false;
        private bool scoreperkillalert = false;
        private bool roundalert = false;
        private bool scorelimitalert = false;
        private bool livealert = false;
        private bool rapidfire = false;
        private bool zmrapidfire = false;
        private int int_blu;
        public static byte[] byte_0 = new byte[] { 1, 2, 9, 0 };
        public static byte[] byte_1 = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0x10, 0x11, 0x12, 0x13, 20, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 30, 0x1f, 0x20, 0x21, 0x23, 0x24, 0x25, 0x26, 0x27, 40, 0x29, 0x2a, 0x2b };
        public static uint ClientIntervalOffset = 22536u;
        public static uint codInt = 328u;
        public static uint NameOffset = 24667244u;
        public static uint inparty = 16461071u;
        public static uint[] codArray = new uint[] { 16377496u, 16377638u, 16377642u };
        public static uint[] partyArray = new uint[] { 16423368u, 16423470u, 16423474u };
        public static int PIndex = 0;
        public static string PlayerIP = "";
        public static string PlayerName = "";
        public static uint[] u_00 = new uint[0];
        public static uint[] offst = new uint[] { 0x1780F28 + 0x5544, 0x269180C };
        public static int length1 = 99;
        public static Regex nameValidation = new Regex("^[a-zA-Z0-9-_]+$");
        #endregion

        #region NavBars
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = true;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = true;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = true;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = true;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = true;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = true;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = true;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = true;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = true;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = true;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = true;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = true;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = true;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = true;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = true;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = true;
            groupControl17.Visible = false;
            groupControl18.Visible = false;
        }
        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = true;
            groupControl18.Visible = false;
        }
        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            groupControl3.Visible = false;
            groupControl4.Visible = false;
            groupControl5.Visible = false;
            groupControl6.Visible = false;
            groupControl7.Visible = false;
            groupControl8.Visible = false;
            groupControl9.Visible = false;
            groupControl10.Visible = false;
            groupControl11.Visible = false;
            groupControl12.Visible = false;
            groupControl13.Visible = false;
            groupControl14.Visible = false;
            groupControl15.Visible = false;
            groupControl16.Visible = false;
            groupControl17.Visible = false;
            groupControl18.Visible = true;
        }
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
            }
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            
            labelControl4.Text = System.Environment.UserName;
            textEdit4.Text = System.Environment.UserName;
            textEdit27.Text = System.Environment.UserName;
            //CheckforUpdates();
            //CheckforCommunication();

            if (splashScreenManager2.IsSplashFormVisible)
            {
                splashScreenManager2.CloseWaitForm();
            }
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                ConnectionMethod = "CCAPI";
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                RPC.PS3.ChangeAPI(SelectAPI.ControlConsole);
                BO2.PS3.ChangeAPI(SelectAPI.ControlConsole);
                checkEdit2.Checked = false;
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                ConnectionMethod = "TMAPI";
                PS3.ChangeAPI(SelectAPI.TargetManager);
                RPC.PS3.ChangeAPI(SelectAPI.TargetManager);
                BO2.PS3.ChangeAPI(SelectAPI.TargetManager);
                checkEdit1.Checked = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionMethod == "CCAPI")
                {
                    if (PS3.ConnectTarget())
                    {
                        XtraMessageBox.Show("Succesfully Connected to your PS3 ;)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        labelControl2.Text = "Connected";
                        simpleButton1.ForeColor = Color.DarkOrange;
                        labelControl9.Text = PS3.CCAPI.GetFirmwareType();
                        labelControl11.Text = PS3.CCAPI.GetFirmwareVersion();
                        labelControl13.Text = PS3.CCAPI.GetTemperatureRSX();
                        labelControl15.Text = PS3.CCAPI.GetTemperatureCELL();
                    }
                    else
                    {
                        XtraMessageBox.Show("Impossible To Connect, Noob .-.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        labelControl2.Text = "Error";
                        simpleButton1.ForeColor = Color.IndianRed;
                    }
                }
                else if (ConnectionMethod == "TMAPI")
                {
                    if (PS3.ConnectTarget())
                    {
                        XtraMessageBox.Show("Succesfully Connected to your PS3 ;)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        labelControl2.Text = "Connected";
                        simpleButton1.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        XtraMessageBox.Show("Impossible To Connect, Noob .-.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        labelControl2.Text = "Error";
                        simpleButton1.ForeColor = Color.IndianRed;
                    }
                }
                else if (ConnectionMethod == "")
                {
                    XtraMessageBox.Show("You have to select an API first..", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                XtraMessageBox.Show("Something goes wrong.. Please check if CCAPI or TMAPI are installed and running correctly.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelControl2.Text = "Error";
                simpleButton1.ForeColor = Color.IndianRed;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelControl2.Text.Contains("Connected") && ConnectionMethod == "CCAPI")
                {
                    if (PS3.AttachProcess())
                    {
                        XtraMessageBox.Show("Succesfully Attached To Process ;)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.TROPHY4, "LezZo's Tool Attached! Have Fun ;)");
                        PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Single);
                        simpleButton2.ForeColor = Color.DarkOrange;
                        labelControl2.Text = "Connected - Attached";
                        string name = PS3.Extension.ReadString(0x026C0658);
                        if (name != "")
                        {
                            labelControl4.Text = name;
                            textEdit4.Text = name;
                            textEdit27.Text = name;
                        }
                        timer1.Start();
                        PS3.Extension.WriteString(0x8E3290, "^1Cybermodding ^4<3 ");
                        byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                        PS3.SetMemory(0x37FEC, buffer);
                        bool_0 = true;
                        BO2.APIok = true;
                        BO2.APIused = "CCAPI";
                    }
                    else
                    {
                        XtraMessageBox.Show("No Game Process Founded, Noob", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        simpleButton2.ForeColor = Color.IndianRed;
                        labelControl2.Text = "Not Attached";
                    }
                }
                else if (labelControl2.Text.Contains("Connected") && ConnectionMethod == "TMAPI")
                {
                    if (PS3.AttachProcess())
                    {
                        XtraMessageBox.Show("Succesfully Attached To Process ;)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        simpleButton2.ForeColor = Color.DarkOrange;
                        labelControl2.Text = "Connected - Attached";
                        string name = PS3.Extension.ReadString(0x026C0658);
                        if (name != "")
                        {
                            labelControl4.Text = name;
                            textEdit4.Text = name;
                            textEdit27.Text = name;
                        }
                        timer1.Interval = 500;
                        timer1.Start();

                        byte[] buffer1 = Encoding.ASCII.GetBytes("^1Cybermodding ^4<3 ");
                        byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                        PS3.SetMemory(0x8E3290, buffer1);
                        PS3.SetMemory(0x37FEC, buffer);
                        bool_0 = true;
                        BO2.APIok = true;
                        BO2.APIused = "TMAPI";
                    }
                    else
                    {
                        XtraMessageBox.Show("No Game Process Founded, Noob", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        simpleButton2.ForeColor = Color.IndianRed;
                        labelControl2.Text = "Not Attached";
                    }
                }
                else
                {
                    XtraMessageBox.Show("You have to Connect first.. .-.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                XtraMessageBox.Show("Something goes wrong.. :(", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                simpleButton2.ForeColor = Color.IndianRed;
                labelControl2.Text = "Not Attached";
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (bool_0 == true)
            {
                RPC.Init();
                simpleButton3.ForeColor = Color.DarkOrange;
                labelControl2.Text = "Connected - Attached - RPC Enabled";
                rpcConnected = true;
                BO2.rpcConnected = true;
                XtraMessageBox.Show("RPC Enabled! Have Fun :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("You have to Attach first..", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            byte[] buffer2 = new byte[] { 0x99 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan2, buffer2);
            byte[] buffer3 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan3, buffer3);
            byte[] buffer4 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan4, buffer4);
            byte[] buffer5 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan5, buffer5);
            byte[] buffer6 = new byte[] { 0x48, 0x00 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan6, buffer6);
            byte[] buffer7 = new byte[] { 0x48, 0x80 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan7, buffer7);
            byte[] buffer8 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan8, buffer8);
            byte[] buffer9 = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(BO2.Offsets.Protection.AntiBan9, buffer9);

            if (XtraMessageBox.Show("Standard AntiBan enabled. \nIf you are on Multiplayer, click Yes to enable an additional AntiBan. This will results in a better protection. \nWarning: on Zombie mode this AntiBan will make you freeze!", "AntiBan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                byte[] buffer1 = new byte[] { 0x40, 0x00 };
                PS3.SetMemory(BO2.Offsets.Protection.AntiBanSC58, buffer1);
            }

            XtraMessageBox.Show("AntiBan Enabled !! \nAnyway, you will never be 100% Safe on Bo2.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.TROPHY4, "AntiBan Enabled!");
            simpleButton4.ForeColor = Color.DarkOrange;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            PS3.DisconnectTarget();
            labelControl2.Text = "Disconnected";
            timer2.Stop();
            labelControl4.Text = "...";
            labelControl9.Text = "...";
            labelControl11.Text = "...";
            labelControl13.Text = "...";
            labelControl15.Text = "...";
            labelControl4.ResetForeColor();
            simpleButton1.ResetForeColor();
            simpleButton2.ResetForeColor();
            simpleButton3.ResetForeColor();
            timer1.Stop();
            simpleButton4.ResetForeColor();
            bool_0 = false;
            rpcConnected = false;
            BO2.APIok = false;
            XtraMessageBox.Show("Ps3 Disconnetted, Bye Bye :)", "Disconnetted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            int J = rand.Next(0, 255);
            int F = rand.Next(0, 255);
            int D = rand.Next(0, 255);
            int N = rand.Next(0, 255);

            labelControl4.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ConnectionMethod == "CCAPI" && labelControl2.Text.Contains("Connected"))
            {
                PS3.CCAPI.ClearTargetInfo();
                labelControl9.Text = PS3.CCAPI.GetFirmwareType();
                labelControl11.Text = PS3.CCAPI.GetFirmwareVersion();
                labelControl13.Text = PS3.CCAPI.GetTemperatureRSX();
                labelControl15.Text = PS3.CCAPI.GetTemperatureCELL();
            }
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked && labelControl2.Text.Contains("Connected") && ConnectionMethod == "CCAPI")
            {
                timer2.Interval = 10000;
                timer2.Start();
            }
            else if (!labelControl2.Text.Contains("Connected"))
            {
                checkEdit3.Checked = false;
                timer2.Stop();
                XtraMessageBox.Show("Yo Noob, you have to Connect first .-. \nAlso this option is available for CCAPI Only.", "Fail..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text.Length == 32 && ConnectionMethod == "CCAPI" && labelControl10.Text.Contains("Connected"))
            {
                PS3.CCAPI.SetConsoleID(textEdit1.Text);
                PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.TROPHY4, "ConsoleID = " + textEdit1.Text);
            }
            else
            {
                XtraMessageBox.Show("Something goes wrong. IDPS Must be 32 characters! \nAlso this option is available only for CCAPI :(", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.HardReboot);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.ShutDown);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (checkEdit4.Checked)
            {
                if (this.spinEdit1.Value == 1)
                {
                    byte[] buffer = new byte[] { 0x00, 0x00, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 2)
                {
                    byte[] buffer = new byte[] { 0x00, 0x04, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 3)
                {
                    byte[] buffer = new byte[] { 0x00, 0x08, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 4)
                {
                    byte[] buffer = new byte[] { 0x00, 0x0D, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 5)
                {
                    byte[] buffer = new byte[] { 0x00, 0x1A, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 6)
                {
                    byte[] buffer = new byte[] { 0x00, 0x1F, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 7)
                {
                    byte[] buffer = new byte[] { 0x00, 0x2C, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 8)
                {
                    byte[] buffer = new byte[] { 0x00, 0x3B, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 9)
                {
                    byte[] buffer = new byte[] { 0x00, 0x4C, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 10)
                {
                    byte[] buffer = new byte[] { 0x00, 0x5F, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 11)
                {
                    byte[] buffer = new byte[] { 0x00, 0x76, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 12)
                {
                    byte[] buffer = new byte[] { 0x00, 0x90, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 13)
                {
                    byte[] buffer = new byte[] { 0x00, 0xC0, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 14)
                {
                    byte[] buffer = new byte[] { 0x00, 0xE0, 0x00 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 15)
                {
                    byte[] buffer = new byte[] { 0x00, 0x10, 0x01 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 16)
                {
                    byte[] buffer = new byte[] { 0x00, 0x30, 0x01 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 17)
                {
                    byte[] buffer = new byte[] { 0x00, 0x50, 0x01 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 18)
                {
                    byte[] buffer = new byte[] { 0x00, 0x9A, 0x01 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 19)
                {
                    byte[] buffer = new byte[] { 0x00, 0x9F, 0x01 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 20)
                {
                    byte[] buffer = new byte[] { 0x00, 0xF9, 0x01 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 21)
                {
                    byte[] buffer = new byte[] { 0x00, 0x30, 0x02 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 22)
                {
                    byte[] buffer = new byte[] { 0x00, 0x70, 0x02 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 23)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x02 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 24)
                {
                    byte[] buffer = new byte[] { 0x00, 0xF9, 0x02 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 25)
                {
                    byte[] buffer = new byte[] { 0x00, 0xFF, 0x02 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 26)
                {
                    byte[] buffer = new byte[] { 0x00, 0x4F, 0x03 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 27)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x03 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 28)
                {
                    byte[] buffer = new byte[] { 0x00, 0xFF, 0x03 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 29)
                {
                    byte[] buffer = new byte[] { 0x00, 0x2F, 0x04 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 30)
                {
                    byte[] buffer = new byte[] { 0x00, 0x7F, 0x04 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 31)
                {
                    byte[] buffer = new byte[] { 0x00, 0xFF, 0x04 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 32)
                {
                    byte[] buffer = new byte[] { 0x00, 0x50, 0x05 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 33)
                {
                    byte[] buffer = new byte[] { 0x00, 0x90, 0x05 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 34)
                {
                    byte[] buffer = new byte[] { 0x00, 0x00, 0x06 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 35)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x06 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 36)
                {
                    byte[] buffer = new byte[] { 0x00, 0xC0, 0x06 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 37)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x07 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 38)
                {
                    byte[] buffer = new byte[] { 0x00, 0xB0, 0x07 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 39)
                {
                    byte[] buffer = new byte[] { 0x00, 0x1F, 0x08 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 40)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x08 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 41)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x09 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 42)
                {
                    byte[] buffer = new byte[] { 0x00, 0xB0, 0x09 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 43)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x0A };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 44)
                {
                    byte[] buffer = new byte[] { 0x00, 0xD0, 0x0A };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 45)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x0B };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 46)
                {
                    byte[] buffer = new byte[] { 0x00, 0x00, 0x0C };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 47)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x0C };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 48)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x0D };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 49)
                {
                    byte[] buffer = new byte[] { 0x00, 0xF0, 0x0D };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 50)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x0E };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 51)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x0F };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 52)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x10 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 53)
                {
                    byte[] buffer = new byte[] { 0x00, 0x00, 0x11 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 54)
                {
                    byte[] buffer = new byte[] { 0x00, 0xA0, 0x11 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
                if (this.spinEdit1.Value == 55)
                {
                    byte[] buffer = new byte[] { 0x00, 0xFF, 0x12 };
                    PS3.SetMemory(0x026FD02C, buffer);
                }
            }
            if (checkEdit5.Checked)
            {
                string value = spinEdit2.Value.ToString();
                int value2 = (int)Convert.ToByte(value);
                byte[] buffer = BitConverter.GetBytes(value2);
                PS3.SetMemory(0x26FD014, buffer);
            }
            if (checkEdit6.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit3.Value.ToString()));
                PS3.SetMemory(0x26FCB70, buffer);
            }
            if (checkEdit7.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit4.Value.ToString()));
                PS3.SetMemory(0x26FC942, buffer);
            }
            if (checkEdit8.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit5.Value.ToString()));
                PS3.SetMemory(0x26FD050, buffer);
            }
            if (checkEdit9.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit6.Value.ToString()));
                PS3.SetMemory(0x26FD152, buffer);
            }
            if (checkEdit10.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit7.Value.ToString()));
                PS3.SetMemory(0x26FCBE2, buffer);
            }
            if (checkEdit11.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit8.Value.ToString()));
                PS3.SetMemory(0x26FCA44, buffer);
            }
            if (checkEdit12.Checked)
            {
                Functions.SetMemUshort(0x2706938, (ushort)(spinEdit9.Value * 64M));
            }
            if (checkEdit13.Checked)
            {
                decimal num = (((spinEdit10.Value * 86400M) + (spinEdit11.Value * 3600M)) + (spinEdit12.Value * 60M)) + spinEdit13.Value;
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(num.ToString()));
                PS3.SetMemory(0x26FD10A, buffer);
            }
            checkEdit4.Checked = false;
            checkEdit5.Checked = false;
            checkEdit6.Checked = false;
            checkEdit7.Checked = false;
            checkEdit8.Checked = false;
            checkEdit9.Checked = false;
            checkEdit10.Checked = false;
            checkEdit11.Checked = false;
            checkEdit12.Checked = false;
            checkEdit13.Checked = false;
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer);
        }

        #region UA
        private void UnlockAll()
        {
            byte[] buffer = new byte[] {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 60, 210, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x5d, 0x22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x17, 0xa9, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xfd, 0x95, 0xcd, 0x53, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x9b, 0x1a, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 0x80,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0,
                0, 0, 0xa7, 0, 0, 0, 0, 0, 0xac, 1, 0, 0, 0, 0, 0xa1, 0,
                0, 0, 0, 0, 0x35, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0,
                140, 0, 0, 0, 0, 0, 0xb2, 1, 0, 0, 0, 0, 0x27, 11, 0, 0,
                0, 0, 7, 3, 0, 0, 0, 0, 0xa4, 0, 0, 0, 0, 0, 0x88, 0,
                0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0x55, 0, 0, 0, 0, 0,
                0x1b, 0, 0, 0, 0, 0, 0x15, 0, 0, 0, 0, 0, 80, 1, 0, 0,
                0, 0, 0xc9, 0, 0, 0, 0, 0, 0x29, 0, 0, 0, 0, 0, 0x15, 0,
                0, 0, 0, 0, 0x7e, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x30, 0, 0, 0,
                0, 0, 0x31, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x27, 0,
                0, 0, 0, 0, 0xce, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0,
                0xdb, 0, 0, 0, 0, 0, 0xaf, 5, 0, 0, 0, 0, 0x76, 5, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0xa6, 15, 0, 0, 0, 0, 0x4f, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 13, 5, 0, 0, 0, 0,
                13, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 14, 3, 0, 0, 0, 0, 0x76, 0, 0, 0, 0, 0, 0x5d, 0x22,
                0, 0, 0, 0, 0xfc, 10, 0, 0, 0, 0, 0x53, 5, 0, 0, 0, 0,
                0x9f, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x5c, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0x12, 0,
                0, 0, 0, 0, 0x88, 0, 0, 0, 0, 0, 0x5c, 2, 0, 0, 0, 0,
                0xf4, 14, 0, 0, 0, 0, 0x44, 0x11, 0, 0, 0, 0, 8, 0, 0, 0,
                0, 0, 0xed, 0x1c, 0, 0, 0, 0, 110, 0x11, 0, 0, 0, 0, 0x6b, 40,
                0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0x2a, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x9d, 0, 0, 0, 0, 0, 0x15, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x10, 0,
                0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0,
                11, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0x36, 0, 0, 0,
                0, 0, 0x34, 0, 0, 0, 0, 0, 0x19, 0, 0, 0, 0, 0, 0xd9, 2,
                0, 0, 0, 0, 0x9c, 0, 0, 0, 0, 0, 0x29, 0, 0, 0, 0, 0,
                12, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0x7e, 0x11, 0, 0,
                0, 0, 11, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0,
                0, 0, 0, 0, 0x3e, 0, 0, 0, 0, 0, 0xf4, 6, 0, 0, 0, 0,
                0xf3, 0, 0, 0, 0, 0, 0x56, 0, 0, 0, 0, 0, 0xfb, 1, 0, 0,
                0, 0, 170, 0x10, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 150, 0x22,
                0, 0, 0, 0, 0x9d, 5, 0, 0, 0, 0, 0x11, 1, 0, 0, 0, 0,
                0x3b, 0, 0, 0, 0, 0, 0x15, 0, 0, 0, 0, 0, 1, 0, 0, 0,
                0, 0, 2, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 130, 0,
                0, 0, 0, 0, 0x2e, 4, 0, 0, 0, 0, 0x77, 5, 0, 0, 0, 0,
                0xf1, 0x23, 0, 0, 0, 0, 0xc4, 0, 0, 0, 0, 0, 11, 0, 0, 0,
                0, 0, 0x95, 0, 0, 0, 0, 0, 0x35, 1, 0, 0, 0, 0, 0x9b, 3,
                0, 0, 0, 0, 0x1f, 0, 0, 0, 0, 0, 0xde, 0x25, 0, 0, 0, 0,
                0xcf, 10, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0,
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0x68, 0, 0, 0, 0, 0,
                0x8f, 7, 0, 0, 0, 0, 0xb7, 2, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x2a, 0, 0, 0, 0, 0, 0x21, 8, 0, 0, 0, 0, 2, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 5, 0, 0x36, 0, 0, 0, 0, 0, 0x4c, 15, 0x13, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x47, 0xf4, 0xd7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0x77, 0,
                0, 0, 0, 0, 0xad, 0x9c, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x6c, 0xda, 0x24, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 190, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x40, 40, 0, 0x40, 0x10, 0,
                0, 0, 0, 0x40, 0x25, 0, 0x40, 0, 0, 0x80, 0x1c, 0, 0x80, 0x12, 0, 0xc0,
                11, 0, 0, 0, 0, 0x80, 0x11, 0, 0, 0, 0, 0xc0, 13, 0, 0, 0x3e,
                0x42, 0xf3, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x18, 0xe0, 0x16, 0xd9, 60, 0x15, 0x18, 0xd9, 60, 5, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0xc4, 0x24, 0xb7, 0x30, 0x4f, 0x89, 0xbb, 0x30, 0x4f,
                0xf5, 0x1a, 0, 4, 8, 0, 0, 0, 0, 0, 0x40, 0x20, 0x41, 0x6c, 60, 0xcc,
                0x53, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x40, 0x80, 0x71, 0x23, 0xf3, 0xd4, 0x16, 0x24, 0xf3, 20, 0xd6, 6, 0x40, 0xf8, 1, 0xe0,
                0, 0x40, 0x7e, 0xfc, 0xfc, 0x19, 0x74, 0x71, 0xc9, 60, 5, 0x91, 0xc9, 60, 5, 0,
                0, 160, 0, 0, 6, 0, 0x3a, 0x6d, 160, 0x7e, 0, 0x81, 0x65, 50, 0x4f, 0xad,
                0x65, 50, 0x4f, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x30,
                0x26, 170, 0xcc, 0x53, 0x6a, 0xab, 0xcc, 0x53, 0xd6, 6, 0, 0x23, 2, 0x60, 1, 0xe0,
                0xae, 0x44, 0xfd, 7, 80, 0xf4, 0x2c, 0xf3, 0x94, 0xf6, 0x2c, 0xf3, 20, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x10, 0xf3, 0xb2, 0xcb, 60, 0xb5, 0xc5, 0xcb,
                60, 0x65, 0xd1, 0, 0x30, 0x34, 0, 0x10, 0, 160, 0x2f, 0xe8, 0x7e, 6, 0xc9, 0xf2,
                50, 0x4f, 0x15, 0xfd, 50, 0x4f, 0xb1, 0x7c, 0, 4, 0x24, 0x80, 6, 0, 0x4c, 0x63,
                0xc0, 0x9f, 0x41, 0x9c, 0xbf, 0xcc, 0x53, 0x2f, 0xc2, 0xcc, 0x53, 0x65, 0x27, 0, 1, 10,
                0xc0, 3, 0xe0, 0x4d, 0x6f, 0xea, 0x67, 0x90, 0x9b, 0x30, 0xf3, 20, 0x2f, 0x31, 0xf3, 0x54,
                0x25, 4, 0x40, 0x30, 1, 0xe0, 0, 0x18, 0xae, 0x47, 0xf8, 0x19, 20, 0x60, 0xcc, 60,
                0xf5, 0x74, 0xcc, 60, 0x55, 0x2d, 0, 0x10, 12, 0, 4, 0, 0, 0, 0, 0x81,
                4, 0xa1, 0x67, 0x33, 0x4f, 0xd5, 0x69, 0x33, 0x4f, 1, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x41, 0xdd, 0xda, 0xcc, 0x53, 0xbc, 0xdb, 0xcc, 0x53, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x40, 140, 0x58, 0x37, 0xf3, 20, 0,
                0x38, 0xf3, 0xd4, 0xa8, 0, 0xc0, 0x31, 0, 40, 0, 0x58, 0x55, 0x55, 0xfd, 0x11, 0x54,
                5, 0xce, 60, 0x85, 20, 0xce, 60, 0x55, 0x4b, 0, 0x10, 20, 0, 0, 0, 0,
                0, 0, 0x81, 4, 0x4d, 0x88, 0x33, 0x4f, 0x85, 0x92, 0x33, 0x4f, 0x31, 0x11, 0, 4,
                5, 0x80, 2, 0x80, 0x55, 0x55, 0xd5, 0x1f, 0x41, 5, 0xe5, 0xcc, 0x53, 0x23, 0xe7, 0xcc,
                0x53, 14, 6, 0, 0xa1, 1, 0x20, 0, 0, 0, 0, 0x10, 0x48, 0x90, 0xde, 0x39,
                0xf3, 20, 0x9b, 0x3a, 0xf3, 0xd4, 0x25, 1, 0x80, 0x48, 0, 40, 0, 0x58, 0x55, 0x55,
                0xfd, 0x11, 0x34, 0xac, 0xce, 60, 0x85, 0xc6, 0xce, 60, 0xe5, 0x47, 0, 0x10, 20, 0,
                4, 0, 0, 0, 0, 0x81, 4, 0x95, 0xb5, 0x33, 0x4f, 0x59, 0xb9, 0x33, 0x4f, 0x81,
                0x11, 0, 4, 5, 0, 0, 0, 0, 0, 0x40, 0x20, 0x41, 0xde, 0xf1, 0xcc, 0x53,
                0xf9, 0xf2, 0xcc, 0x53, 90, 5, 0, 0x81, 1, 0, 0, 0, 0, 0, 0x10, 0x48,
                0x10, 0xe5, 60, 0xf3, 0xd4, 0x2f, 0x3d, 0xf3, 20, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x10, 0xa4, 0x55, 0xcf, 60, 0x85, 100, 0xcf, 60, 0xa5, 0x41, 0,
                0x10, 0x12, 0, 4, 0, 0, 0, 0, 0x81, 4, 0xc1, 0xdb, 0x33, 0x4f, 0xd5, 0xe2,
                0x33, 0x4f, 0xf1, 10, 0, 0x84, 2, 0x80, 0, 0, 0, 0, 0x40, 0x20, 0x41, 0x41,
                0xfb, 0xcc, 0x53, 0xd1, 0xfc, 0xcc, 0x53, 0xa8, 0x16, 0, 0xa1, 2, 0, 0, 0, 0,
                0, 0x10, 0x48, 80, 0x59, 0x3f, 0xf3, 0x54, 0xf1, 0x3f, 0xf3, 0xd4, 0x4b, 3, 0x40, 0xd0,
                0, 0x10, 0, 0, 0, 0, 4, 0x12, 0x34, 14, 0xd0, 60, 0x35, 0x5c, 0xd0, 60,
                0xc5, 0x25, 1, 0x80, 0xac, 0, 0, 0, 0, 0, 0, 0, 6, 0x5d, 0x19, 0x34,
                0x4f, 0x35, 0x1c, 0x34, 0x4f, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x80, 0x11, 0x56, 7, 0xcd, 0x53, 0xb0, 7, 0xcd, 0x53, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x60, 0x44, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xc0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x56, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x2a, 0, 0,
                0, 0, 0xc0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x2e, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 13, 0, 0, 0, 0, 0,
                2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x38, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 40, 14, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x38, 8, 0, 0, 0, 0, 80, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x30, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0xc0, 0x18, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 160, 0x4e, 0, 0, 0, 0, 0xd0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x40, 7, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x27, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0xc0, 0x24, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x42,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x21,
                0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xfc, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe4, 0, 0, 0,
                0, 0, 0x18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x2c, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x10,
                5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x20, 6, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0xd0, 5, 0, 0, 0, 0, 0xb0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x16, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 3, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 4, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x10, 0,
                0, 0, 0, 0, 0x10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0x40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 11, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0,
                0, 0xc0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0xf2, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x4c, 0, 0, 0, 0, 0, 7,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x90, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x10, 0, 0, 0, 0, 0, 0x10, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x40, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0xc0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x40, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                140, 0xda, 1, 0, 0, 0, 0x80, 0xde, 0, 0, 0, 0, 0, 0x6d, 1, 0,
                0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x7c, 0x20, 60, 0x1a, 0, 0, 0, 0x47,
                0, 0, 0, 50, 0, 0, 0x43, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x80, 0x20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x80, 7, 0, 0, 0x80, 7, 0, 0, 0, 0, 0, 15, 0, 0,
                1, 0, 0, 0x4b, 0, 0, 0, 0, 0, 0x4b, 0, 0, 0, 0, 0, 10,
                0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0x1d, 1, 0x24,
                0, 0, 0, 0x21, 0xc3, 0x75, 0, 0, 0, 0, 0x60, 0x23, 0, 0, 0, 0,
                0x80, 0x4e, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x59, 0xb0, 0xed, 0x21,
                0, 0, 0, 15, 0, 0, 0x80, 12, 0, 0, 0x10, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0xe0, 1, 0, 0, 0xe0, 1, 0, 0, 0, 0,
                0xc0, 3, 0, 0, 0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0xc0, 0x12, 0, 0,
                0, 0, 0x80, 2, 0, 0, 0, 0, 0x40, 1, 0, 0, 0, 0, 0, 0,
                0x40, 0x47, 0, 0x49, 0, 0, 0x40, 200, 0x38, 0x31, 0, 0, 0, 0, 8, 0x11,
                0, 0, 0, 0, 0xc0, 0x29, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0,
                0x51, 230, 0xab, 0x1c, 0, 0, 0x90, 4, 0, 0, 0x20, 3, 0, 0, 3, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 80, 2, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 120, 0, 0, 0, 120, 0,
                0, 0, 0, 0, 240, 0, 0, 0, 0, 0, 0xb0, 4, 0, 0, 0, 0,
                0xb0, 4, 0, 0, 0, 0, 160, 0, 0, 0, 0, 0, 80, 0, 0, 0,
                0, 0, 0, 0, 0xd0, 0x11, 0x40, 0x52, 0, 0, 0x10, 50, 0x12, 5, 0, 0,
                0, 0, 0xf8, 0, 0, 0, 0, 0, 0x30, 4, 0, 0, 0, 0, 0x77, 0x77,
                0x77, 0x77, 0, 0, 0x6a, 250, 160, 0x3f, 0, 0, 0x18, 1, 0, 0, 200, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xbc, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0,
                0, 0, 30, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0x2c, 1,
                0, 0, 0, 0, 0x2c, 1, 0, 0, 0, 0, 40, 0, 0, 0, 0, 0,
                20, 0, 0, 0, 0, 0, 0, 0, 0x34, 4, 0x90, 0xd4, 0, 0, 0x84, 8,
                0x53, 1, 0, 0, 0, 0x80, 0x73, 0, 0, 0, 0, 0x80, 0x55, 1, 0, 0,
                0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x5d, 0xfe, 0xea, 30, 0, 0, 0, 0x40, 0,
                0, 0, 50, 0, 0, 0x39, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80,
                0x29, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0x80, 7, 0, 0, 0x80, 7, 0, 0, 0, 0, 0, 15, 0, 0, 0,
                0, 0, 0x4b, 0, 0, 0, 0, 0, 0x4b, 0, 0, 0, 0, 0, 10, 0,
                0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0x1d, 1, 0x24, 0,
                0, 0, 0x21, 0xc0, 8, 0, 0, 0, 0, 0xe0, 1, 0, 0, 0, 0, 0x80,
                2, 0, 0, 0, 0, 0xe0, 0x80, 0, 0, 0, 0, 0, 0x1b, 0, 0, 0,
                0, 0, 1, 0, 0, 0, 1, 0x40, 120, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x20, 0, 0, 0, 0x20, 0, 0xc0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0x20, 1, 0,
                0, 0, 0, 160, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 80, 0x91, 0, 0, 0xf8, 1, 0, 0, 0, 0, 0x20, 0, 0,
                0, 0, 0, 200, 0, 0, 0, 0, 0, 0x60, 0x15, 0, 0, 0, 0, 0x48,
                4, 0, 0, 0, 0, 40, 0, 0, 0, 40, 0, 120, 0x1a, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 8, 0, 0x40,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x70, 0, 0, 0, 0,
                0, 0x48, 0, 0, 0, 0, 0, 0x20, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0xe4, 0x25, 0, 0, 0x7a, 0, 0, 0, 0,
                0, 6, 0, 0, 0, 0, 0, 0x24, 0, 0, 0, 0, 0, 0x12, 6, 0,
                0, 0, 0, 0x22, 1, 0, 0, 0, 0, 14, 0, 0, 0, 14, 0, 0xf2,
                3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0,
                0, 2, 0, 0x10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6,
                0, 0, 0, 0, 0, 12, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xf6, 9, 0, 0x80, 7,
                0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0x80, 1, 0, 0, 0, 0,
                0x80, 0x23, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0,
                0, 1, 0x80, 0x92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x80, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x7d,
                0, 0, 0x80, 4, 0, 0, 0, 0, 160, 0, 0, 0, 0, 0, 0x60, 1,
                0, 0, 0, 0, 0x60, 0x4f, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0,
                0x40, 0, 0, 0, 0x40, 0, 160, 0x31, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x60, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0x80, 0, 0, 0,
                0, 0, 0x40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x40, 0x6a, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x20, 0x7a, 0x21, 0, 0, 0, 0,
                180, 0x12, 0, 0, 0, 0, 0x76, 0x15, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77,
                0, 0, 0x8b, 0xce, 0x68, 0x19, 0, 0, 0xfe, 2, 0, 0, 200, 0, 0, 0,
                1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x90, 2, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0,
                30, 0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0x2c, 1, 0, 0,
                0, 0, 0x2c, 1, 0, 0, 0, 0, 40, 0, 0, 0, 0, 0, 20, 0,
                0, 0, 0, 0, 0, 0, 100, 0x35, 0xfc, 6, 0, 0, 0x84, 12, 0x1c, 7,
                0, 0, 0, 0x80, 0x1a, 2, 0, 0, 0, 0, 0xdb, 5, 0, 0, 0, 0x77,
                0x77, 0x77, 0x77, 0, 0, 0xb6, 0x7e, 0x55, 0x1b, 0, 0, 0x80, 0xbc, 0, 0, 0,
                50, 0, 0, 90, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x87, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80,
                7, 0, 0, 0x80, 7, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0,
                0x4b, 0, 0, 0, 0, 0, 0x4b, 0, 0, 0, 0, 0, 10, 0, 0, 0,
                0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0x59, 13, 0xbf, 1, 0, 0,
                0x21, 0x23, 0x62, 5, 0, 0, 0, 0x20, 100, 1, 0, 0, 0, 0x60, 0xe7, 2,
                0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0xc3, 0x12, 0x2e, 0x18, 0, 0, 0,
                0x70, 0, 0, 0x80, 12, 0, 0, 0x16, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x2a, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0xe0, 1, 0, 0, 0xe0, 1, 0, 0, 0, 0, 0xc0, 3, 0,
                0, 0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0x80,
                2, 0, 0, 0, 0, 0x40, 1, 0, 0, 0, 0, 0, 0, 0x40, 0x56, 0xc3,
                0x6f, 0, 0, 0x40, 200, 0xc0, 0x23, 0, 0, 0, 0, 8, 15, 0, 0, 0,
                0, 80, 0x13, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 230, 0x66, 0xfc,
                0x1d, 0, 0, 0xb8, 5, 0, 0, 0x20, 3, 0, 0, 6, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x10, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 120, 0, 0, 0, 120, 0, 0, 0, 0,
                0, 240, 0, 0, 0, 0, 0, 0xb0, 4, 0, 0, 0, 0, 0xb0, 4, 0,
                0, 0, 0, 160, 0, 0, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0,
                0, 0x90, 0xd5, 240, 0x1b, 0, 0, 0x10, 50, 0x4a, 0x21, 0, 0, 0, 0, 0x7e,
                0x13, 0, 0, 0, 0, 60, 0x16, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0,
                0, 0x26, 0x5d, 13, 0x16, 0, 0, 0xd0, 2, 0, 0, 200, 0, 0, 0, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x70, 2, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 30,
                0, 0, 0, 0, 0, 60, 0, 0, 0, 0, 0, 0x2c, 1, 0, 0, 0,
                0, 0x2c, 1, 0, 0, 0, 0, 40, 0, 0, 0, 0, 0, 20, 0, 0,
                0, 0, 0, 0, 0, 100, 0x35, 0xfc, 0x86, 0, 0, 0x84, 12, 0x99, 7, 0,
                0, 0, 0, 0x34, 2, 0, 0, 0, 0, 0x34, 4, 0, 0, 0, 0x77, 0x77,
                0x77, 0x77, 0, 0, 200, 0x3e, 0x42, 0x1a, 0, 0, 0, 0xc2, 0, 0, 0, 50,
                0, 0, 0x98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0xdd, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 7,
                0, 0, 0x80, 7, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0x4b,
                0, 0, 0, 0, 0, 0x4b, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0,
                0, 5, 0, 0, 0, 0, 0, 0, 0, 0x59, 13, 0xbf, 1, 0, 0, 0x21,
                0x62, 0xbf, 0, 0, 0, 0, 0xe0, 0x58, 0, 0, 0, 0, 0, 0x7f, 0, 0,
                0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 230, 0xc0, 0x22, 0x19, 0, 0, 160, 0x19,
                0, 0, 0x80, 12, 0, 0, 0x16, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0xc0, 0x30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xe0, 1, 0, 0, 0xe0, 1, 0, 0, 0, 0, 0xc0, 3, 0, 0,
                0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0x80, 2,
                0, 0, 0, 0, 0x40, 1, 0, 0, 0, 0, 0, 0, 0x40, 0x56, 0xc3, 0x6f,
                0, 0, 0x40, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xc0, 0xe8, 0x2f, 0, 0, 0, 0, 0xf8, 9, 0, 0, 0, 0, 200,
                0x1f, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x7a, 0x3d, 0xc5, 0x1d, 0,
                0, 0xd8, 5, 0, 0, 0x20, 3, 0, 0, 4, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x58, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 120, 0, 0, 0, 120, 0, 0, 0, 0, 0, 80,
                0, 0, 0, 0, 0, 0xb0, 4, 0, 0, 0, 0, 0xb0, 4, 0, 0, 0,
                0, 160, 0, 0, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0x38,
                0xf5, 0x70, 0x1b, 0, 0, 0x10, 50, 0xe2, 0x12, 0, 0, 0, 0, 150, 5, 0,
                0, 0, 0, 0x70, 9, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x56,
                0x44, 0xc0, 0x18, 0, 0, 0x90, 2, 0, 0, 200, 0, 0, 0, 1, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x60, 2, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 30, 0, 0,
                0, 0, 0, 20, 0, 0, 0, 0, 0, 0x2c, 1, 0, 0, 0, 0, 0x2c,
                1, 0, 0, 0, 0, 40, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0,
                0, 0, 0, 0x4e, 0x3d, 220, 0xc6, 0, 0, 0x84, 12, 0x48, 20, 0, 0, 0,
                0, 0xaf, 2, 0, 0, 0, 0x80, 0x2a, 10, 0, 0, 0, 0x77, 0x77, 0x77, 0x77,
                0, 0, 0xfb, 0x53, 0xa9, 0x19, 0, 0, 0, 0xe7, 1, 0, 0, 50, 0, 0,
                0x5c, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x99, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 7, 0, 0,
                0x80, 7, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0x4b, 0, 0,
                0, 0, 0, 0x4b, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 5,
                0, 0, 0, 0, 0, 0, 0x80, 0x53, 15, 0xb7, 1, 0, 0, 0x21, 0xc3, 0x88,
                0, 0, 0, 0, 0x60, 0x2e, 0, 0, 0, 0, 0x60, 0x59, 0, 0, 0, 0,
                0x77, 0x77, 0x77, 0x77, 0, 0, 0xe7, 190, 0x56, 0x19, 0, 0, 0xc0, 20, 0, 0,
                0x80, 12, 0, 0, 0x11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 160, 0x1a,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0xe0, 1, 0, 0, 0xe0, 1, 0, 0, 0, 0, 0x40, 1, 0, 0, 0, 0,
                0xc0, 0x12, 0, 0, 0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0x80, 2, 0, 0,
                0, 0, 0x40, 1, 0, 0, 0, 0, 0, 0, 0xe0, 0xd4, 0xc3, 0x6d, 0, 0,
                0x40, 200, 0x40, 0x30, 0, 0, 0, 0, 0xd0, 0x21, 0, 0, 0, 0, 80, 0x1c,
                0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x33, 0x6b, 230, 0x19, 0, 0,
                0xd0, 6, 0, 0, 0x20, 3, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x88, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 120, 0, 0, 0, 120, 0, 0, 0, 0, 0, 80, 0,
                0, 0, 0, 0, 0xb0, 4, 0, 0, 0, 0, 0xb0, 4, 0, 0, 0, 0,
                160, 0, 0, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0x38, 0xf5,
                0x70, 0x1b, 0, 0, 0x10, 50, 0x62, 12, 0, 0, 0, 0, 8, 6, 0, 0,
                0, 0, 0x56, 5, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 200, 0xac,
                0x98, 0x1c, 0, 0, 0x8e, 1, 0, 0, 200, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x24, 1, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 30, 0, 0, 0,
                0, 0, 20, 0, 0, 0, 0, 0, 0x2c, 1, 0, 0, 0, 0, 0x2c, 1,
                0, 0, 0, 0, 40, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0,
                0, 0, 0x4e, 0x3d, 220, 70, 0, 0, 0x84, 12, 0xe4, 2, 0, 0, 0, 0,
                0x6c, 0, 0, 0, 0, 0x80, 0x7b, 1, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0,
                0, 0x69, 0x29, 0x16, 0x1c, 0, 0, 0x80, 0x59, 0, 0, 0, 50, 0, 0, 0x4d,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x55, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 7, 0, 0, 0x80,
                7, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0x4b, 0, 0, 0,
                0, 0, 0x4b, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 5, 0,
                0, 0, 0, 0, 0, 0x80, 0x53, 15, 0xb7, 0, 0, 0, 0x21, 0xe3, 0x30, 1,
                0, 0, 0, 0x40, 0x8d, 0, 0, 0, 0, 0, 0xa4, 0, 0, 0, 0, 0x77,
                0x77, 0x77, 0x77, 0, 0, 0x9b, 0xae, 0xd6, 0x37, 0, 0, 160, 0x23, 0, 0, 0x80,
                12, 0, 0, 0x17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 0x2c, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe0,
                1, 0, 0, 0xe0, 1, 0, 0, 0, 0, 0x40, 1, 0, 0, 0, 0, 0xc0,
                0x12, 0, 0, 0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0x80, 2, 0, 0, 0,
                0, 0x40, 1, 0, 0, 0, 0, 0, 0, 0xe0, 0xd4, 0xc3, 0x6d, 0, 0, 0x40,
                0x88, 0xb0, 0x29, 0, 0, 0, 0, 0x60, 0x24, 0, 0, 0, 0, 0x60, 0x1a, 0,
                0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0xca, 0xef, 0xfd, 0x18, 0, 0, 0xf8,
                4, 0, 0, 0x20, 3, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0xc0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 120, 0, 0, 0, 120, 0, 0, 0, 0, 0, 80, 0, 0,
                0, 0, 0, 0xb0, 4, 0, 0, 0, 0, 0xb0, 4, 0, 0, 0, 0, 160,
                0, 0, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 0x38, 0xf5, 0x70,
                0x1b, 0, 0, 0x10, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80,
                200, 0x73, 0, 0, 0, 0, 0x30, 13, 0, 0, 0, 0, 40, 0x43, 0, 0,
                0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 60, 0xd6, 0xb3, 0x13, 0, 0, 40, 0x10,
                0, 0, 0x20, 3, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x70, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 120, 0, 0, 0, 120, 0, 0, 0, 0, 0, 80, 0, 0, 0,
                0, 0, 0xb0, 4, 0, 0, 0, 0, 0xb0, 4, 0, 0, 0, 0, 160, 0,
                0, 0, 0, 0, 80, 0, 0, 0, 0, 0, 0, 0, 40, 0xd5, 0xe1, 0x9a,
                0, 0, 0x10, 50, 0x72, 8, 0, 0, 0, 0, 0x72, 1, 0, 0, 0, 0,
                160, 5, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0xd0, 120, 0x7b, 0x16,
                0, 0, 0x4a, 1, 0, 0, 200, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x6c, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 30, 0, 0, 0, 0, 0,
                20, 0, 0, 0, 0, 0, 0x2c, 1, 0, 0, 0, 0, 0x2c, 1, 0, 0,
                0, 0, 40, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0,
                0x4a, 0x75, 0xb8, 0x66, 0, 0, 0x84, 12, 0xd1, 8, 0, 0, 0, 0, 220, 0,
                0, 0, 0, 0, 0x42, 5, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x3e,
                0xc6, 0x39, 20, 0, 0, 0x80, 0xee, 0, 0, 0, 50, 0, 0, 50, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x80, 0x58, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 7, 0, 0, 0x80, 7, 0,
                0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0x4b, 0, 0, 0, 0, 0,
                0x4b, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 5, 0, 0, 0,
                0, 0, 0, 0x80, 0x52, 0x1d, 0xae, 0, 0, 0, 0x21, 0x43, 0x73, 0, 0, 0,
                0, 0x60, 30, 0, 0, 0, 0, 0, 0x43, 0, 0, 0, 0, 0x77, 0x77, 0x77,
                0x77, 0, 0, 0x66, 0x66, 0x66, 0x16, 0, 0, 0xe0, 0x12, 0, 0, 0x80, 12, 0,
                0, 13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x16, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe0, 1, 0,
                0, 0xe0, 1, 0, 0, 0, 0, 0x40, 1, 0, 0, 0, 0, 0xc0, 0x12, 0,
                0, 0, 0, 0xc0, 0x12, 0, 0, 0, 0, 0x80, 2, 0, 0, 0, 0, 0x40,
                1, 0, 0, 0, 0, 0, 0, 160, 0x54, 0x87, 0x6b, 0, 0, 0x40, 8, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 140, 0x33, 3, 0, 0, 0, 0x80, 160, 0, 0,
                0, 0, 0x80, 0x21, 3, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x3e, 0xad,
                0xf8, 0x34, 0, 0, 0, 0x73, 0, 0, 0, 0, 0x80, 130, 110, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x37, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x80, 7, 0, 0, 0x80, 7, 0, 0,
                5, 0, 0, 0x7d, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0x19,
                0, 0, 0, 0, 0, 0x19, 0, 0, 0, 0, 0x80, 2, 0, 0, 0, 0,
                0, 5, 0x80, 1, 0x31, 0x20, 10, 0, 0, 0x21, 0xa2, 90, 0, 0, 0, 0,
                0xc0, 0x24, 0, 0, 0, 0, 160, 0x43, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77,
                0, 0, 0xbd, 0x15, 0x8e, 0x27, 0, 0, 0x60, 12, 0, 0, 0, 0, 0x40, 0x27,
                14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 11, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe0, 1, 0, 0,
                0xe0, 1, 0, 0, 0, 0, 0x40, 0x1f, 0, 0, 0, 0, 0x40, 1, 0, 0,
                0, 0, 0x40, 6, 0, 0, 0, 0, 0x40, 6, 0, 0, 0, 0, 160, 0,
                0, 0, 0, 0, 0x40, 1, 0, 0, 4, 200, 0, 0, 0x40, 200, 0x30, 0x5f,
                0, 0, 0, 0, 0x18, 0x20, 0, 0, 0, 0, 80, 0x61, 0, 0, 0, 0,
                0x77, 0x77, 0x77, 0x77, 0, 0, 0x9e, 30, 0x69, 0x2e, 0, 0, 0xc0, 10, 0, 0,
                0, 0, 0xc0, 120, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 120, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                120, 0, 0, 0, 120, 0, 0, 0, 0, 0, 0xd0, 7, 0, 0, 0, 0,
                80, 0, 0, 0, 0, 0, 0x90, 1, 0, 0, 0, 0, 0x90, 1, 0, 0,
                0, 0, 40, 0, 0, 0, 0, 0, 80, 0, 0, 0, 1, 0xb2, 0, 0,
                0x10, 50, 0xf2, 6, 0, 0, 0, 0, 0x10, 1, 0, 0, 0, 0, 0xb0, 4,
                0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 20, 7, 5, 0x31, 0, 0,
                250, 0, 0, 0, 0, 0, 0x9e, 13, 1, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x62, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 30, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0xf4, 1,
                0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 100, 0, 0, 0, 0, 0,
                100, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 20, 0, 0, 0,
                0x80, 0xec, 0, 0, 0x84, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0xd4, 1, 0, 0, 0, 0x80,
                0xa7, 0, 0, 0, 0, 0x20, 0x8a, 1, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0,
                0, 0x6a, 7, 0x87, 0x4f, 0, 0, 0xe0, 0x25, 0, 0, 0, 0, 0x60, 0xa4, 20,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x60, 11, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe0, 1, 0, 0, 0xe0,
                1, 0, 0, 1, 0, 0x40, 0x1f, 0, 0, 0, 0, 0xc0, 3, 0, 0, 0,
                0, 0x40, 6, 0, 0, 0, 0, 0x40, 6, 0, 0, 0, 0, 160, 0, 0,
                0, 0, 0, 0x40, 1, 0, 0, 0x40, 0x69, 0, 0, 0x40, 200, 0x40, 0x17, 0,
                0, 0, 0, 0x48, 4, 0, 0, 0, 0, 0x58, 0x11, 0, 0, 0, 0, 0x77,
                0x77, 0x77, 0x77, 0, 0, 0xef, 0x74, 0x54, 0x34, 0, 0, 0, 2, 0, 0, 0,
                0, 0xa8, 0x9c, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 3, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 120,
                0, 0, 0, 120, 0, 0, 0, 0, 0, 0xd0, 7, 0, 0, 0, 0, 240,
                0, 0, 0, 0, 0, 0x90, 1, 0, 0, 0, 0, 0x90, 1, 0, 0, 0,
                0, 40, 0, 0, 0, 0, 0, 80, 0, 0, 0, 80, 0x1a, 0, 0, 0x10,
                50, 0x90, 6, 0, 0, 0, 0, 90, 2, 0, 0, 0, 0, 0x16, 5, 0,
                0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 200, 0x55, 0xda, 0x38, 0, 0, 0xa8,
                0, 0, 0, 0, 0, 0x1c, 0xa4, 1, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0x9c, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 30, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0xf4, 1, 0,
                0, 0, 0, 60, 0, 0, 0, 0, 0, 100, 0, 0, 0, 0, 0, 100,
                0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0x94,
                0xc6, 0, 0, 0x84, 12, 9, 2, 0, 0, 0, 0x80, 0xa3, 0, 0, 0, 0,
                0, 0xcd, 1, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x9e, 0xaf, 6, 0x37,
                0, 0, 0, 0x1d, 0, 0, 0, 0, 0, 0xa3, 0x52, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x1d, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x80, 7, 0, 0, 0x80, 7, 0, 0, 4, 0,
                0, 0x7d, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0x19, 0, 0,
                0, 0, 0, 0x19, 0, 0, 0, 0, 0x80, 2, 0, 0, 0, 0, 0, 5,
                0, 0, 0, 0xa5, 0, 0, 0, 0x21, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x20,
                0xc0, 0, 0, 0, 0, 0, 0xea, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x76, 0x25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 30, 0, 0, 0, 30, 0, 0, 0, 0, 0, 200, 0, 0, 0,
                0, 0, 20, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 2, 0,
                0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0,
                0, 0, 0x84, 12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x7c, 6, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x80, 7, 0, 0, 0x80, 7, 0, 0, 0, 0, 0,
                50, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0x80, 2, 0, 0, 0,
                0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0x80, 0, 0,
                0, 0, 0, 0, 0, 0, 0x21, 3, 0x2d, 0, 0, 0x80, 12, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x60, 0xa6, 1, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x60, 1, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe0, 1, 0, 0, 0xe0, 1, 0,
                0, 0, 0, 0x40, 1, 0, 0, 0, 0, 0x20, 0, 0, 0, 0, 0, 0x20,
                0, 0, 0, 0, 0, 160, 0, 0, 0, 0, 0, 0x20, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x40, 8, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x30, 0xe8,
                1, 0, 0, 0x90, 1, 0, 0, 0, 0, 0, 0, 0xf4, 5, 0, 0, 0,
                0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x22, 0xa4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x1a,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 30, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0xd0, 7, 0, 0, 0,
                0, 50, 0, 0, 0, 0, 0, 50, 0, 0, 0, 0, 0, 50, 0, 0,
                0, 0, 0, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x40, 0,
                0, 0x84, 12, 0xc2, 0, 0, 0, 150, 0, 0, 0, 0, 0, 0, 0x80, 140,
                1, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0xff, 0xa6, 0x7f, 0x54, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x26, 30, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x80, 0x17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x80, 7, 0, 0, 0x80, 7, 0, 0, 0, 0, 0x80, 0,
                0, 0, 0, 0, 0x80, 2, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0,
                0x80, 0, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0x80, 0,
                0x10, 0x44, 0, 0, 0, 0x21, 0xa3, 80, 0, 0, 0, 0, 0x60, 0x13, 0, 0,
                0, 0, 0xe0, 0x11, 0, 0, 0, 0, 0x77, 0x77, 0x77, 0x77, 0, 0, 0x9e, 30,
                0xd1, 0x16, 0, 0, 0x20, 2, 0, 0, 0, 0, 0xc0, 0xb0, 7, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0xe0, 1, 0, 0, 0xe0, 1, 0, 0,
                0, 0, 0x80, 0x25, 0, 0, 0, 0, 160, 0, 0, 0, 0, 0, 0x20, 3,
                0, 0, 0, 0, 0x20, 3, 0, 0, 0, 0, 0x20, 0, 0, 0, 0, 0,
                0x40, 0, 0, 0, 0, 0, 0, 0, 0x40, 8, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x56, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                220, 0, 0, 0, 0, 0, 0x90, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xbc, 0x19, 0, 0, 0, 0, 0x10, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x42, 0x18, 0, 0, 0x80, 0x25, 0x20, 0x19, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x80, 0xf6, 0, 0, 0, 0, 160, 0x51, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 160, 0x90, 0xcf, 0, 0, 0, 0x40,
                0x49, 1, 0, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x30, 0x9b, 2, 0xc0, 0xe8, 7, 0, 0, 0x60, 9, 0xb8,
                2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 240, 80, 0, 0, 0,
                0, 80, 0x15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xf8, 0x11, 5,
                0, 0, 0, 160, 0x3f, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x10, 8, 1, 0x30, 0xa8, 7, 0,
                0, 0x58, 2, 0x84, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x5e,
                0x1a, 0, 0, 0, 0, 0xa4, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0x48, 6, 5, 0, 0, 0, 0xb0, 0x59, 0, 0, 0, 0, 0xc2, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x9b, 0x2f, 0,
                12, 0x4e, 2, 0, 0, 150, 0, 0x2c, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x3e, 9, 0, 0, 0, 0x80, 0x9d, 4, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x97, 0x66, 1, 0, 0, 0, 0xe1, 9, 0, 0, 0,
                0x80, 0x2b, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x20, 0x4d, 0x2e, 0, 3, 0x85, 0, 0, 0x80, 0x25, 0x40, 0x12, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x20, 0x75, 2, 0, 0, 0, 0x60, 0xeb, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x53, 110, 0, 0, 0, 0xe0, 0x13,
                4, 0, 0, 0, 160, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x54, 0x71, 8, 0xc0, 0xe0, 4, 0, 0, 0x60, 9, 0x20, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x88, 0xf4, 0, 0, 0, 0,
                0x30, 0x48, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 160, 0x7a, 0x39, 0,
                0, 0, 8, 40, 0, 0, 0, 0, 80, 3, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x2d, 0xc1, 2, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 12,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0x80, 0x85, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x80, 0x4a, 0x38, 0, 0, 0, 0x80, 0xd7, 1, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x80, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x42, 1, 0, 0, 0, 0, 0x60, 2, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x60, 0xfc, 0, 0, 0, 0, 0x20, 140, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x60, 220, 0x23, 0, 0, 0, 0x40, 0x75, 1,
                0, 0, 0, 0x40, 11, 0, 0, 0, 0, 0xc0, 0x27, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 160, 15, 0, 0xc0, 120, 0, 0, 0, 0, 0, 0x10, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0xd8, 0x4e, 0, 0, 0, 0, 0x88,
                0x3f, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xf8, 0x97, 15, 0, 0,
                0, 0xc0, 0x3f, 0, 0, 0, 0, 0x40, 0x12, 0, 0, 0, 0, 0x68, 4, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x7c, 0x15, 0, 0x30, 6, 0, 0, 0, 0,
                0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x52, 7, 0,
                0, 0, 0, 0x44, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 12,
                0x7b, 1, 0, 0, 0, 0x80, 7, 0, 0, 0, 0, 0x2a, 0, 0, 0, 0,
                0, 0x2c, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xaf, 0, 0, 12, 2,
                0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0x1b, 3, 0, 0, 0, 0, 0x38, 3, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x80, 200, 0xef, 0, 0, 0, 0x80, 0xb2, 1, 0, 0, 0, 0, 0x40,
                0, 0, 0, 0, 0, 0x2e, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x19,
                0, 0, 0xc3, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x60, 0xb8, 1, 0, 0, 0, 0xc0, 0x73, 1, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0xc0, 0x72, 0x74, 0, 0, 0, 0x60, 0x2a, 1, 0,
                0, 0, 0x40, 0x22, 0, 0, 0, 0, 0x80, 0x17, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 80, 20, 0, 0xc0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0xf8, 0x70, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 0xf7, 30, 0, 0, 0,
                0xb8, 0x36, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 200, 0x18, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x16, 0x71, 0, 0x30, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x42, 0x10, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x9c, 0, 0, 0, 0, 0, 0x20, 0x4a,
                5, 0, 0, 0, 0xf2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 140, 2, 0,
                0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80,
                0x60, 2, 0, 0, 0, 0x80, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x1f, 0x92, 0, 0, 0, 0x80, 0x4e, 0, 0, 0, 0, 0, 1, 0,
                0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x25, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0xce, 4, 0, 0, 0x90, 1, 0,
                0, 0, 0, 0, 0, 240, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x68, 0xb3, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 30,
                0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0,
                0, 10, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 10, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0x4f, 0, 0x80, 12, 0, 0,
                0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xd7,
                0, 0, 0, 0, 0x80, 0x26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 240, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 7, 0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 1, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xbf, 0x37, 0, 0, 0, 0xf8, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0xf8, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xaf, 4, 0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3e, 0x13, 0, 0, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0x79, 0, 0, 0xe0, 0xff, 0x1f, 0x1f, 0, 0,
                0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x67, 0, 0, 0xe0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x1f, 1, 0, 0, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x43, 0xa6, 1, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x8f, 0x10, 3, 0, 0xf8, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xdd, 0xc0, 0, 0,
                0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x80, 0, 0, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 7, 0x3d, 0, 0, 0xf8, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xef, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe3, 0xc7, 0, 0, 0xfe, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x4b, 50,
                0, 0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 15, 8, 0, 0, 0xfe, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x7f, 0xcd, 0, 0, 0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0, 0xe0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xbf, 9, 0, 0, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x1d, 0, 0, 0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 7, 0, 0, 0xe0, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 13,
                0, 0, 0, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xef, 9, 0, 0,
                0, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0x11, 0, 0, 0, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x76, 1, 0xc0,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 140,
                0x4f, 0, 0, 0x80, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x80, 10, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0x9a, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80,
                0x3e, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x20, 0x2f, 9, 0, 0, 0, 0xe0, 0x41, 2,
                0, 0, 0, 0x20, 0xb7, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0xc0, 0xb0, 15, 0, 0, 0x90, 1, 0x10, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0xa8, 6, 0, 0, 0, 0, 0x90,
                2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 160, 0x65, 0, 0, 0,
                0, 0x38, 0x19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x80, 0x25, 0, 0x30, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xfc,
                5, 0, 0, 0, 0, 0x68, 8, 0, 0, 0, 0, 30, 0x3a, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 12, 20,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x80, 0x51, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 80, 0, 0, 0, 0, 0, 7, 1, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x3e,
                0, 0, 0x63, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0xc0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x60, 0xd5, 0, 0, 0, 0, 0x40, 0x2d, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xd0, 7, 0, 0xc0, 0xf8, 0x10, 0, 0, 0x20, 1, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xb0, 0x22, 2, 0, 0, 0,
                0xd8, 0x11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0xac, 13, 0, 0x20, 0x26, 13, 0, 0, 0x1c, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x7a, 0x87,
                0, 0, 0, 0, 0xd8, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xf4, 1, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0x43, 0x71, 1, 0, 0x60, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0xe0, 0x5c, 0, 0, 0, 0, 0, 0xa8, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0xc0, 0xe0, 2, 0, 0, 0x20, 0, 8, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x90, 5, 0, 0, 0, 0, 0x60, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 40, 20, 0, 0, 0, 0, 0,
                1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x30, 40, 1, 0, 0, 100, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xd4, 3, 0, 0, 0,
                0, 0x12, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 12, 7, 0,
                0, 0, 0, 160, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x88, 0x66, 0, 0,
                0x80, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x80, 30, 0, 0, 0, 0, 0x80, 0x21, 0, 0, 0, 0, 0, 1, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x40, 6, 0, 0,
                0x43, 0x20, 0, 0, 160, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x40, 5, 0, 0, 0, 0, 0x40, 1, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x40, 0xfb, 0, 0, 0, 0, 0xe0, 14, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0xd0, 7, 0, 0xc0, 120, 0x5b, 0, 0, 0x18, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x20, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0x48, 20, 0, 0, 0, 0, 120, 0x17,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 220, 5, 0, 0x30, 0x20, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x5e, 5, 0, 0,
                0, 0, 0xe8, 7, 0, 0, 0, 0, 0x7c, 50, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 140, 0xa9, 2, 0, 0,
                6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x80, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                170, 0, 0, 0, 0, 0x80, 0xc0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe3,
                0x56, 0, 0, 0x60, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x60, 1, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x80, 80, 0, 0, 0, 0, 0x60, 0x16, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x70,
                0x17, 0, 0xc0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0xb0, 0x43, 0, 0, 0, 0, 0xf8, 1, 0,
                0, 0, 0, 0x98, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0xf4, 1, 0, 0x30, 0x60, 7, 0, 0, 6, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 8,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0,
                0, 240, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x7d, 0, 0, 12, 80, 3, 0, 0, 11,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0x10,
                1, 0, 0, 0, 0x80, 0x68, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc3, 0xae,
                0, 0, 0x60, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x36, 0, 0, 0, 0, 0x60, 0x20, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x70, 0x17,
                0, 0xc0, 120, 0x85, 0, 0, 0xe0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x80, 13, 0, 0, 0, 0, 0x10, 15, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 240, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xbf, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xef, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xef, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xef, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xef, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xef,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xef, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xef, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xfb, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 3, 0, 0, 0xc0, 0xff, 0x7f, 3,
                0, 0, 0xc0, 0xff, 0x7f, 0, 0, 0, 0xc0, 0xff, 0xff, 0x25, 0, 0, 0xc0, 0xff,
                0x3f, 8, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0xc4, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0x13,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xbf, 5, 0, 0, 0xc0, 0xff, 0xbf, 9, 0, 0, 0xc0, 0xff,
                0x3f, 1, 0, 0, 0xc0, 0xff, 0x3f, 0x90, 0, 0, 0xc0, 0xff, 0x7f, 0x24, 0, 0,
                0xc0, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0x7f, 0xb3, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0x16, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x7f, 0x86, 0, 0, 0xc0, 0xff, 0x3f, 0x10, 0, 0, 0xc0, 0xff, 0x3f, 0x2a, 0, 0,
                0xc0, 0xff, 0xbf, 50, 8, 0, 0xc0, 0xff, 0xbf, 0xa2, 1, 0, 0xc0, 0xff, 0xff, 11,
                0, 0, 0xc0, 0xff, 0xbf, 170, 0x11, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xbf, 9, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x21, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0, 0, 0,
                0xc0, 0xff, 0x3f, 4, 0, 0, 0xc0, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0x7f, 0x2b,
                0, 0, 0xc0, 0xff, 0x3f, 2, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xbf, 14, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0x3f, 15, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0x3f, 6,
                0, 0, 0xc0, 0xff, 0xbf, 1, 0, 0, 0xc0, 0xff, 0xbf, 0x10, 0, 0, 0xc0, 0xff,
                0xbf, 4, 0, 0, 0xc0, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0x7f, 0x60, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 15,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0x7f, 4, 0, 0, 0xc0, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0, 0xc0, 0xff, 0x3f, 0, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 15, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 12, 0, 0,
                0xc0, 0xff, 0xbf, 0, 0, 0, 0xc0, 0xff, 0x7f, 1, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x7f, 0x22, 2, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0x12, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xbf, 10, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0x57, 0, 0, 0xc0, 0xff, 0xff, 15, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x9f, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0, 0x40, 11, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x7f, 0, 0, 0, 0xc0, 0xff, 0xff, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 14, 0, 0, 0xc0, 0xff, 0xbf, 14, 0, 0, 0xc0, 0xff, 0x3f, 0,
                0, 0, 0xc0, 0xff, 0x7f, 9, 0x1b, 0, 0xc0, 0xff, 0x3f, 11, 0, 0, 0xc0, 0xff,
                0x3f, 1, 0, 0, 0xc0, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x7f, 0x26, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0xf3, 0, 0, 0xc0, 0xff, 0x3f, 0x3e, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xce, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 2, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 2, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 2, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x7f, 0xbf, 1, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x65, 0, 0,
                0xc0, 0xff, 0xbf, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x11,
                1, 0, 0xc0, 0xff, 0xbf, 0x66, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xbf, 0x1c, 70, 0, 0xc0, 0xff, 0x3f, 170, 0, 0, 0xc0, 0xff, 0x3f, 0x7f, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x3f, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0x7c, 0, 0, 0xc0, 0xff, 0xff, 6, 0, 0, 0xc0, 0xff,
                0xff, 0x29, 0, 0, 0xc0, 0xff, 0xbf, 0x7d, 7, 0, 0xc0, 0xff, 0xbf, 0x7f, 1, 0,
                0xc0, 0xff, 0x7f, 11, 0, 0, 0xc0, 0xff, 0xbf, 0x95, 0x10, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 8, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x3f, 1, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 1, 0, 0, 0xc0, 0xff, 0x7f, 3,
                0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 15, 0, 0, 0xc0, 0xff,
                0x7f, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x15, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 6, 0, 0, 0xc0, 0xff, 0x7f, 5, 0, 0, 0xc0, 0xff,
                0xff, 0, 0, 0, 0xc0, 0xff, 0x3f, 0x5f, 0, 0, 0xc0, 0xff, 0xbf, 0x13, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 140, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x53, 0, 0,
                0xc0, 0xff, 0x3f, 1, 0, 0, 0xc0, 0xff, 0x3f, 20, 0, 0, 0xc0, 0xff, 0x7f, 0x58,
                5, 0, 0xc0, 0xff, 0xff, 0x13, 1, 0, 0xc0, 0xff, 0x3f, 7, 0, 0, 0xc0, 0xff,
                0x7f, 0xe2, 4, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x7f, 0x16, 0, 0, 0xc0, 0xff, 0x7f, 0x12, 0, 0, 0xc0, 0xff,
                0x7f, 2, 0, 0, 0xc0, 0xff, 0x7f, 0x45, 1, 0, 0xc0, 0xff, 0x7f, 0x33, 0, 0,
                0xc0, 0xff, 0x3f, 2, 0, 0, 0xc0, 0xff, 0x3f, 130, 1, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0x16, 0, 0,
                0xc0, 0xff, 0x3f, 2, 0, 0, 0xc0, 0xff, 0x7f, 0, 0, 0, 0xc0, 0xff, 0x7f, 0x16,
                1, 0, 0xc0, 0xff, 0x7f, 0x33, 0, 0, 0xc0, 0xff, 0xff, 0, 0, 0, 0xc0, 0xff,
                0x3f, 0x11, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x13, 0, 0, 0xc0, 0xff,
                0x7f, 1, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x3f, 0, 0, 0, 0xc0, 0xff, 0xbf, 2, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xbf, 0x16, 0, 0, 0xc0, 0xff, 0xbf, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 1, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 6, 0, 0,
                0xc0, 0xff, 0x3f, 1, 0, 0, 0xc0, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0x69,
                0, 0, 0xc0, 0xff, 0x7f, 0x20, 0, 0, 0xc0, 0xff, 0x7f, 0, 0, 0, 0xc0, 0xff,
                0x7f, 0x30, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x7f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0,
                0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 1, 0, 0, 0xc0, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0, 0xc0, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 4, 0, 0, 0xc0, 0xff, 0x7f, 0, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 1, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x7f, 0x1b, 0, 0, 0xc0, 0xff, 0x3f, 0x15, 0, 0, 0xc0, 0xff, 0x7f, 2, 0, 0,
                0xc0, 0xff, 0xbf, 0x69, 1, 0, 0xc0, 0xff, 0x3f, 0x4f, 0, 0, 0xc0, 0xff, 0xff, 1,
                0, 0, 0xc0, 0xff, 0x3f, 0x3b, 2, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x3f, 2, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0x62, 0, 0, 0xc0, 0xff, 0x7f, 4,
                0, 0, 0xc0, 0xff, 0xff, 20, 0, 0, 0xc0, 0xff, 0x3f, 0x4e, 6, 0, 0xc0, 0xff,
                0xff, 0x44, 1, 0, 0xc0, 0xff, 0xbf, 8, 0, 0, 0xc0, 0xff, 0xff, 0x31, 5, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 4, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff,
                0x7f, 0, 0, 0, 0xc0, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0x7f, 0, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x25, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x3f, 3, 0, 0, 0xc0, 0xff, 0xff, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xbf, 9, 0, 0, 0xc0, 0xff, 0x7f, 3, 0, 0, 0xc0, 0xff, 0x3f, 0,
                0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 0, 0, 0,
                0xc0, 0xff, 0x3f, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f, 4,
                0, 0, 0xc0, 0xff, 0xbf, 0, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0,
                0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 15, 0xfc,
                30, 0xc2, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 7, 0xfc, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0x3f, 0, 0, 0x40, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0,
                0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0,
                0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0xc7, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x3f, 0x3f, 0, 0x5e, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf3, 3, 0xe0,
                0xc5, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x3f, 0, 0x5e, 0xfc, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf3, 3, 0xe0, 0xc5, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0x3f, 0x3f, 0, 0x5e, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf3,
                3, 0xe0, 0xc5, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0xef, 0x21, 0xfc,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0,
                0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf3, 3, 0xe0, 0xc5, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x3f, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f,
                0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xf3, 3, 0x60, 0xc4, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0x3f, 0x3f, 0, 0x5e, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0,
                0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0,
                0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x3f,
                0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0x40, 0xfc, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xf3, 3, 0xe0, 0xc5, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0,
                0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3,
                0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0,
                0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 3, 0, 0, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f,
                0, 0, 0, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0xc0,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x3f, 0, 0, 0, 0xfc, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 3, 0, 0, 0, 0, 0x68, 0x80, 0, 0, 0, 0,
                4, 1, 0, 0, 0, 0, 0, 0, 0, 0x6a, 0, 0, 0, 0, 130, 0,
                0, 0, 0, 0, 0, 0, 0x94, 0x9d, 0x9e, 0x95, 0, 0, 0, 0, 0, 0,
                0, 0x18, 0, 0, 0x40, 0xad, 0x2c, 0x80, 1, 0x83, 3, 0, 0, 0, 0x80, 10,
                8, 0, 0, 0, 0x40, 0x10, 0, 0, 0, 0, 0, 0, 0, 160, 6, 0,
                0, 0, 0x20, 8, 0, 0, 0, 0, 0, 0, 0x40, 0xd9, 0x19, 10, 0xc0, 9,
                0, 0, 0, 0, 0, 0x80, 1, 0, 0, 0xd8, 0xca, 2, 0x10, 20, 8, 0,
                0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x6a, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x18, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 160, 6, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x6a, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0x18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 160,
                6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0x80, 1, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0x6a, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x18, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 160, 6, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0x80, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x6a, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 160, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0x80, 1, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 120, 0xd9, 0x54, 0xb9, 0xb1, 0xbd, 0x8d, 0xad, 0x81,
                4, 0xb1, 0xb1, 1, 0, 0, 0, 120, 0xd5, 8, 0xe5, 0x81, 120, 0xd9, 8, 0xdd,
                220, 220, 0xe0, 1, 0, 0, 0, 120, 0xc5, 0x54, 0xcd, 0xa5, 0xb9, 0x9d, 1, 0,
                0, 0, 0, 0, 0, 0, 0, 120, 0xd9, 8, 0xdd, 220, 220, 0xe0, 1, 0,
                0, 0, 0, 0, 0, 0, 0, 120, 0xd5, 0x4c, 0xd1, 0x85, 0xd1, 0xcd, 0x81, 80,
                0xbd, 0xbd, 0xb1, 1, 0, 0, 0, 0x6c, 0xed, 0xad, 180, 0x95, 0xb1, 0x95, 0x95, 0xf5,
                0x75, 1, 0, 0, 0, 0, 0, 120, 0xc9, 80, 0xa1, 0xe1, 0x81, 20, 0xd9, 0x95,
                0xe5, 0xbd, 0xb9, 0x95, 0xf1, 0xcc, 0, 0x6c, 0xed, 0xad, 180, 0x95, 0xb1, 0x95, 0x95, 0xf5,
                0x75, 1, 0, 0, 0, 0, 0, 120, 0xd9, 0x58, 0xa5, 0xcd, 0xa5, 0xd1, 0x81, 120,
                0xd9, 0x38, 0x1d, 0x55, 1, 0, 0, 120, 0xd5, 0x38, 0x95, 0xe1, 0xd1, 0x1d, 0x95, 0xb9,
                0x55, 0xc1, 0x91, 0x85, 0xd1, 0x95, 1, 0, 0, 0, 20, 0xff, 0xff, 0x8f, 80, 3,
                0xe4, 0xff, 0xff, 0xff, 0x5f, 1, 0, 0, 0, 0, 0, 0xe0, 15, 80, 0xf3, 0xff,
                0xff, 0xff, 15, 0, 0, 0, 0, 0, 0, 240, 0xa7, 0xec, 0xf4, 4, 0xd0, 4,
                0, 0, 0, 0, 0, 0xc0, 0xfe, 0xff, 0xff, 0x6d, 0x65, 1, 12, 0x18, 0x1c, 0,
                0, 0, 0, 0x54, 0x40, 0xfe, 0xff, 0xff, 0xff, 0x15, 0, 0, 0, 0, 0, 0,
                0xfe, 0, 0x35, 0xff, 0xff, 0xff, 0xff, 0, 0, 0, 0, 0, 0, 0, 0x7f, 0xca,
                0xce, 80, 0, 0x4e, 0, 0, 0, 0, 0, 0, 0xec, 0xff, 0xff, 0xdf, 0x56, 0x16,
                0x80, 160, 0x40, 0, 0, 0, 0, 0x80, 5, 0xe4, 0xff, 0xff, 0xff, 0x5f, 1, 0,
                0, 0, 0, 0, 0xe0, 15, 80, 0xf3, 0xff, 0xff, 0xff, 15, 0, 0, 0, 0,
                0, 0, 240, 0xa7, 0xec, 12, 5, 0xe0, 4, 0, 0, 0, 0, 0, 0xc0, 0xfe,
                0xff, 0xff, 0x6d, 0x65, 1, 8, 10, 4, 0, 0, 0, 0, 0, 0x40, 0xfe, 0xff,
                0xff, 0xff, 1, 0, 0, 0, 0, 0, 0, 0xfe, 0, 0x35, 0xff, 0xff, 0xff, 0xff,
                0, 0, 0, 0, 0, 0, 0, 0x7f, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0xec, 0xff, 0xff, 0x1f, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xe4, 0xff, 0xff, 0xff, 0x1f, 0, 0, 0, 0, 0, 0, 0xe0, 15, 80,
                0xf3, 0xff, 0xff, 0xff, 15, 0, 0, 0, 0, 0, 0, 240, 7, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0xc0, 0xfe, 0xff, 0xff, 1, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x84, 110, 110, 110, 240, 0, 110, 240, 0, 0, 0,
                0, 0, 0, 0, 0, 0x84, 110, 110, 110, 240, 0, 110, 240, 0, 0, 0,
                0, 0, 0, 0, 0, 0x84, 110, 110, 110, 240, 0, 110, 240, 0, 0, 0,
                0, 0, 0, 0, 0, 0x5c, 0, 0x6a, 0x84, 110, 110, 110, 240, 0, 0, 0,
                0, 0, 0, 0, 0, 0x5c, 0, 0x6a, 0x84, 110, 110, 110, 240, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0xfe, 0xff, 0xff, 0xff, 0x41, 0x40, 0xfe, 0xff,
                0xff, 0xff, 1, 0, 0, 0, 0, 0, 0, 0xfe, 0x35, 0x35, 0xff, 0xff, 0xff, 0xff,
                0, 0, 0, 0, 0, 0, 0, 0x7f, 0xca, 0x4e, 0x4f, 0, 0, 0x80, 0x9f, 0x80,
                0x1c, 9, 12, 0xec, 0xff, 0xff, 0x1f, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                160, 0xa1, 0xe1, 0xff, 0xff, 0xff, 0x1f, 0, 0, 0, 0, 0, 0, 0xe0, 0x6f, 0x60,
                240, 0xff, 0xff, 0xff, 15, 0, 0, 0, 0, 0, 0, 240, 0xa7, 0xec, 0xf4, 4,
                0, 0, 0xf8, 9, 200, 0x91, 0xc0, 0xc0, 0xfe, 0xff, 0xff, 1, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x48, 0x48, 0xfe, 0xff, 0xff, 0xff, 1, 0, 0, 0, 0,
                0, 0, 0xfe, 0x35, 0x35, 0xff, 0xff, 0xff, 0xff, 0, 0, 0, 0, 0, 0, 0,
                0x7f, 0xca, 0x4e, 0x4f, 0, 0, 0x80, 0x9f, 0x80, 0x1c, 9, 12, 0xec, 0xff, 0xff, 0x1f,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0xe0, 0xe5, 0xe5, 0xff, 0xff, 0xff, 0x1f,
                0, 0, 0, 0, 0, 0, 0xe0, 0x5f, 0x53, 0xf3, 0xff, 0xff, 0xff, 15, 0, 0,
                0, 0, 0, 0, 240, 0xa7, 0xec, 0xf4, 4, 0, 0, 0xf8, 9, 200, 0x91, 0xc0,
                0xc0, 0xfe, 0xff, 0xff, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x56, 0x56,
                0xfe, 0xff, 0xff, 0xff, 1, 0, 0, 0, 0, 0, 0, 0xfe, 6, 6, 0xff, 0xff,
                0xff, 0xff, 0, 0, 0, 0, 0, 0, 0, 0x7f, 0xca, 0x4e, 0x4f, 0, 0, 0x80,
                0x9f, 0x80, 0x1c, 9, 12, 0xec, 0xff, 0xff, 0x1f, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 160, 0x62, 0x88, 0x2d, 0x6c, 110, 0xae, 12, 4, 0xae, 0x4c, 110, 0xee, 0xcd,
                5, 0x24, 0xa6, 0x62, 0x88, 0x2d, 0x6c, 110, 0xae, 12, 4, 0xae, 0x4c, 110, 0xee, 0xcd,
                5, 0x44, 0xa6, 0x62, 0x88, 0x2d, 0x6c, 110, 0xae, 12, 4, 0xae, 0x4c, 110, 0xee, 0xcd,
                5, 100, 0xa6, 0x62, 0x88, 0x2d, 0x6c, 110, 0xae, 12, 4, 0xae, 0x4c, 110, 0xee, 0xcd,
                5, 0x84, 0xa6, 0x62, 0x88, 0x2d, 0x6c, 110, 0xae, 12, 4, 0xae, 0x4c, 110, 0xee, 0xcd,
                5, 0xa4, 0xa6, 230, 0xff, 0xff, 0xff, 0xff, 0xff, 0xbf, 0xdd, 0xa7, 0x1b, 0xe8, 0xdf, 0x7d,
                0xdb, 0xe7, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x1f, 0, 0, 0, 0, 0, 0,
                0, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x1f, 0, 0, 0, 0, 0, 0,
                0, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24,
                0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49,
                0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc9,
                0xdf, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x92,
                0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24,
                0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49,
                0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92,
                0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24, 0x49, 0x92, 0x24,
                0x49, 0x92, 0x24, 0x49, 0x12, 0xff, 0x49, 0x92, 0x24, 0xff, 0x92, 0x24, 0xff, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xc0, 100, 0x42,
                0xed, 0xde, 0x37, 0xe0, 0x52, 0x63, 0x72, 0x2f, 0x22, 0x22, 0xb6, 0xbf, 0x8f, 0x48, 0, 0,
                0xb8, 0xff, 0x75, 0x35, 0x74, 0, 0x10, 0, 0, 0, 200, 0xf8, 0x69, 0x4d, 0xc1, 0x36,
                0x37, 0xbd, 5, 0, 0, 0, 100, 0x42, 0x6d, 0xdd, 0x37, 0xe0, 0x52, 0x63, 0x72, 0xaf,
                0xb6, 0x2a, 0xb6, 0xbf, 0xc7, 0x4c, 0, 0, 0xb8, 0xff, 0x75, 0x35, 0x74, 0, 4, 0,
                0, 0, 0xd4, 0x3b, 0x6a, 0x4d, 0xc1, 0x36, 0x37, 0xbd, 5, 0, 0x90, 0, 100, 0x42,
                0xed, 210, 0x77, 0xe0, 0x52, 0x63, 0x72, 0xaf, 0xb6, 0x2a, 0xb6, 0xbf, 0xc7, 0x4c, 0, 0,
                0xb8, 0xff, 0x75, 0x35, 0x74, 0, 0x18, 0, 0, 0, 0x9c, 0xda, 140, 0x4d, 0x59, 0x85,
                0x35, 0x80, 4, 0, 0, 0, 0x58, 0x5c, 0x45, 0x29, 0xa5, 0xc4, 0x51, 0x44, 0x7e, 0x6b,
                0xb7, 0x20, 0x49, 80, 0xfc, 0x13, 2, 0, 0xb8, 0xff, 0x75, 0x35, 0x74, 0, 4, 0,
                0, 0, 0xb8, 0xba, 0x8f, 0x4d, 9, 0xcc, 0x5c, 0x4a, 4, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x88, 0x36,
                0x94, 0x54, 0xca, 190, 0xb3, 0xd8, 0xf9, 0xff, 0xff, 0xff, 7, 0, 4, 0xd4, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 4, 0x4c, 0xd9, 170, 0xef, 1, 0, 0, 0,
                0, 0x4c, 0x69, 0x3d, 10, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0xd8, 0, 0x48, 1, 0xa5, 20, 0, 0, 0, 0, 0, 0, 0, 0,
                2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0xd7, 0x62, 14, 0x86, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0x44, 0x80, 8, 0x10, 1, 0x22, 0x40, 4, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 10, 0, 0, 0, 0xf4, 0xd4, 0x6d, 0xa7, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0xde, 0x7d, 0x5b, 0xbd, 1, 0, 0, 0, 2, 0x22, 8,
                0, 0, 0x80, 1, 0, 0, 10, 0x70, 8, 0x72, 0x1c, 0xc7, 0x7f, 30, 0x85, 0xdf,
                0x84, 0, 10, 0x70, 8, 6, 0x21, 0xfe, 0xff, 1, 15, 0x70, 8, 0, 0, 0,
                0, 6, 0x21, 0xfe, 0xff, 1, 10, 160, 5, 0, 0, 0, 0, 70, 0x21, 0xfe,
                0xff, 1, 15, 0x70, 8, 0, 0, 0, 0, 6, 0x21, 6, 0xfe, 0x81, 12, 0x70,
                8, 0, 0, 0, 0, 70, 0x21, 6, 0xfe, 0x81, 12, 0x70, 8, 0, 0, 0,
                0, 6, 0x21, 6, 0xfe, 0x41, 11, 0x70, 8, 0, 0, 0, 0, 70, 0x21, 6,
                0xfe, 0x41, 11, 0x70, 8, 0, 0, 0, 0, 6, 0x21, 6, 0xfe, 1, 10, 0x70,
                8, 0, 0, 0, 0, 70, 0x21, 6, 0xfe, 1, 10, 0x70, 8, 0, 0, 0,
                0, 6, 0x21, 6, 0xfe, 0x81, 7, 0x70, 8, 0, 0, 0, 0, 70, 0x21, 6,
                0xfe, 0x81, 7, 0x70, 8, 0, 0, 0, 0, 2, 0x22, 0xfe, 0xff, 0xa1, 5, 0xc0,
                3, 0, 0, 0, 0, 0x42, 0x22, 0xfe, 0xff, 0xa1, 5, 0xc0, 3, 0, 0, 0,
                0, 2, 2, 0xfe, 0xff, 0xa1, 5, 0xc0, 3, 0, 0, 0, 0, 4, 0x26, 0xfe,
                0xff, 0xa1, 5, 0x80, 4, 0, 0, 0, 0, 0x44, 0x26, 0xfe, 0xff, 0xa1, 5, 0x80,
                4, 0, 0, 0, 0, 4, 6, 0xfe, 0xff, 0xa1, 5, 0x80, 4, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0x80, 0x49, 0x7e, 0, 0, 0x53, 0x7d, 0, 0, 0x18,
                0x7d, 0, 0x80, 0x2d, 0x7e, 0, 0, 0x30, 0x7c, 0, 0, 0x24, 0x7d, 0, 0, 0x2c,
                0x7d, 0x9a, 0x99, 0x19, 0x80, 0x9a, 0x99, 0x19, 0x80, 0x9a, 0x99, 0x19, 0x80, 6, 0, 0,
                0, 20, 0xae, 0x47, 0x7e, 0x86, 0xeb, 0x51, 0x7d, 0x34, 0x33, 0x33, 0x7d, 0x34, 0x33, 0x33,
                0x7e, 0x34, 0x33, 0x33, 0x7c, 110, 0x34, 0x40, 0x7d, 0x60, 0xe5, 80, 0x7d, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 20, 0xae, 0x47,
                0x7e, 0x86, 0xeb, 0x51, 0x7d, 0x34, 0x33, 0x33, 0x7d, 0x34, 0x33, 0x33, 0x7e, 0x34, 0x33, 0x33,
                0x7c, 110, 0x34, 0x40, 0x7d, 0x60, 0xe5, 80, 0x7d, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x60, 0, 8, 0, 240, 0xff, 0xff, 0xff, 7, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0xcc, 0x20, 0, 11, 0, 0x18, 0, 0x19, 0, 0, 1, 0, 0, 0x20, 0, 0,
                0xe8, 0x40, 0, 0, 4, 0, 2, 0x88, 0x80, 0, 0, 0, 3, 0x18, 0x24, 0,
                0, 0, 5, 0, 0, 0, 0x10, 0, 0, 0, 0x24, 0x70, 0xa2, 0x10, 0x60, 100,
                3, 0x10, 0x10, 1, 0, 0, 0, 0, 0x6c, 0, 4, 0x80, 3, 0x80, 6, 0,
                9, 0, 0x40, 0, 0x80, 0x10, 40, 0, 0, 1, 0xd0, 0x41, 0xa3, 0xef, 0x93, 0x40,
                0x80, 0x20, 0x1b, 0x1c, 0xe3, 0x24, 0x3e, 0x89, 0, 0, 0, 0x20, 250, 0, 0, 0,
                8, 0x38, 0xb1, 0xf5, 0xbb, 0x77, 0xde, 0x41, 0xca, 6, 0xa4, 0xdf, 0xee, 0xf1, 0, 0x33,
                0xb0, 0x93, 0xd7, 0x17, 0, 0, 0, 0x8f, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 4, 0x80, 0, 0, 0, 0, 130, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0xe4, 0x34, 0x80, 0x48, 0, 0, 0x1c, 0xde,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0x80, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 14, 160, 0, 0, 0, 0, 0, 0, 0xfc, 0x80, 0,
                0x20, 0x1c, 0x56, 0x1f, 8, 0x13, 0x83, 0x83, 13, 2, 0x62, 0x68, 0xa3, 0x88, 0x61, 0xc6,
                0x70, 1, 0x80, 70, 0x80, 9, 0x10, 0x25, 0x60, 0x80, 2, 1, 4, 160, 0x34, 0x80,
                0, 0, 70, 0x80, 0x41, 0x76, 0x90, 0, 0x6a, 7, 150, 0x90, 0x5f, 0x44, 0xe4, 0x93,
                0xc3, 0x40, 0x81, 210, 0xe8, 0x60, 0, 0x3e, 0xa6, 0x2d, 2, 0x7d, 0, 0x21, 0x20, 4,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0x40, 0x5b, 0x9c, 0,
                0xd8, 0x10, 0x38, 0x23, 0x93, 0, 0x1b, 0x59, 0x71, 0x68, 0x20, 0xc4, 0x26, 5, 0, 0x71,
                0x80, 0x4c, 0x20, 0x8a, 0x6a, 0x49, 0x45, 2, 0x40, 0x41, 0x25, 0x22, 0, 0, 130, 0x30,
                0, 0, 0, 0, 0, 0, 0, 0, 0x59, 4, 0x58, 160, 8, 0x20, 0x99, 0xd6,
                140, 0x84, 0x18, 0xab, 0, 0x4e, 3, 0x6b, 0, 0, 0, 0, 0xb8, 0xe0, 0, 0,
                0x16, 0xe8, 0x62, 160, 130, 0xad, 0xa4, 0x44, 0, 0x51, 0xa2, 0x9c, 0, 0, 0, 0xe7,
                0x3e, 0x11, 0x22, 0x60, 0x4b, 0x98, 6, 0x29, 0x57, 0xbd, 4, 0xd1, 0, 15, 0x20, 0x16,
                0, 0, 0, 0, 0x41, 0x6a, 0, 0, 1, 6, 0x53, 0x10, 0x21, 0x25, 0x7a, 0x68,
                0, 0, 1, 1, 0x44, 130, 0x80, 160, 0x6d, 0x30, 0x48, 0x38, 5, 0x68, 3, 0x22,
                0x40, 0, 0, 0, 0, 0, 0, 0x10, 0x52, 0xb8, 0, 0, 14, 0x45, 0, 0,
                3, 0x86, 0x90, 0, 0, 0x51, 0x4e, 0, 0, 12, 0x11, 0xc0, 0, 0, 0x21, 0x10,
                0, 0, 0, 0, 0x18, 0, 1, 0x40, 2, 0, 1, 0xc3, 200, 0x58, 0, 11,
                40, 0x8a, 0, 1, 4, 0x39, 0x60, 0, 0, 80, 0, 0, 0, 0, 0x20, 0x80,
                0, 2, 0x8e, 0x40, 0, 0, 0, 0, 80, 0, 0, 0, 7, 4, 0, 0,
                0, 0, 12, 0, 0, 0x1c, 1, 0x80, 0, 0, 0x80, 0x30, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0
             };
             PS3.SetMemory(0x26FC870, buffer);
        }
        #endregion

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Unlock all can take some seconds. Please wait during the process.\nDo you want to proceed?", "Unlock All", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                splashScreenManager2.ShowWaitForm();
                UnlockAll();
                splashScreenManager2.CloseWaitForm();
                XtraMessageBox.Show("Unlock All Completed! Thanks to B777x for this :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            decimal num = 1 * 86400M;
            decimal num2 = 4 * 3600M;
            decimal num3 = 20 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] buffer = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, buffer);
            
            byte[] buffer1 = BitConverter.GetBytes(Convert.ToInt32(6653.ToString()));
            PS3.SetMemory(0x26FC942, buffer1);
            
            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(5005.ToString()));
            PS3.SetMemory(0x26FCB70, buffer2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(390.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(110890.ToString()));
            PS3.SetMemory(0x26FD050, buffer3);
            
            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(292.ToString()));
            PS3.SetMemory(0x26FD152, buffer4);
            
            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(766.ToString()));
            PS3.SetMemory(0x26FCBE2, buffer5);
            
            byte[] buffer6 = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer6);
            
            string value = 2.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer7 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer7);
            
            XtraMessageBox.Show("Remember: This Presetted Stat does not include Medals", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            decimal num = 3 * 86400M;
            decimal num2 = 9 * 3600M;
            decimal num3 = 11 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] buffer = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, buffer);
            
            byte[] buffer1 = BitConverter.GetBytes(Convert.ToInt32(16157.ToString()));
            PS3.SetMemory(0x26FC942, buffer1);
            
            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(25987.ToString()));
            PS3.SetMemory(0x26FCB70, buffer2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(3910.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(2348641.ToString()));
            PS3.SetMemory(0x26FD050, buffer3);
            
            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(2500.ToString()));
            PS3.SetMemory(0x26FD152, buffer4);
            
            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(1852.ToString()));
            PS3.SetMemory(0x26FCBE2, buffer5);
            
            byte[] buffer6 = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer6);
            
            string value = 9.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer7 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer7);
            
            XtraMessageBox.Show("Remember: This Presetted Stat does not include Medals", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            decimal num = 7 * 86400M;
            decimal num2 = 8 * 3600M;
            decimal num3 = 22 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);
            
            byte[] bu1 = BitConverter.GetBytes(Convert.ToInt32(48098.ToString()));
            PS3.SetMemory(0x26FC942, bu1);
            
            byte[] bu2 = BitConverter.GetBytes(Convert.ToInt32(199881.ToString()));
            PS3.SetMemory(0x26FCB70, bu2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(32218.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] bu3 = BitConverter.GetBytes(Convert.ToInt32(21470000.ToString()));
            PS3.SetMemory(0x26FD050, bu3);
            
            byte[] bu4 = BitConverter.GetBytes(Convert.ToInt32(10066.ToString()));
            PS3.SetMemory(0x26FD152, bu4);
            
            byte[] bu5 = BitConverter.GetBytes(Convert.ToInt32(3321.ToString()));
            PS3.SetMemory(0x26FCBE2, bu5);
            
            byte[] buffer = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer);
            
            string value = 11.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer1 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer1);


            XtraMessageBox.Show("Remember: This Presetted Stat does not include Medals", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            decimal num = 15 * 86400M;
            decimal num2 = 18 * 3600M;
            decimal num3 = 15 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);
            
            byte[] bu1 = BitConverter.GetBytes(Convert.ToInt32(188010.ToString()));
            PS3.SetMemory(0x26FC942, bu1);
            
            byte[] bu2 = BitConverter.GetBytes(Convert.ToInt32(919387.ToString()));
            PS3.SetMemory(0x26FCB70, bu2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(152218.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] bu3 = BitConverter.GetBytes(Convert.ToInt32(180470505.ToString()));
            PS3.SetMemory(0x26FD050, bu3);
            
            byte[] bu4 = BitConverter.GetBytes(Convert.ToInt32(49111.ToString()));
            PS3.SetMemory(0x26FD152, bu4);
            
            byte[] bu5 = BitConverter.GetBytes(Convert.ToInt32(13030.ToString()));
            PS3.SetMemory(0x26FCBE2, bu5);
            
            byte[] buffer = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer);
            
            string value = 11.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer1 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer1);
            
            XtraMessageBox.Show("Remember: This Presetted Stat does not include Medals", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0xFF, 0xFF };
            PS3.SetMemory(0x2706938, buffer);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 4, 1 };
            PS3.SetMemory(0x27078C0, buffer);
            PS3.SetMemory(0x2708219, new byte[] { 0xFF });
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x44, 0x8D, 0x88, 0x11, 0x33, 0x62, 0x44, 0xAC };
            PS3.SetMemory(0x02708522, buffer);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x27078BA, new byte[] { 0xB0 });
            PS3.SetMemory(0x27078C8, new byte[] { 0x4F });
            byte[] buffer = new byte[5];
            buffer[0] = 0x2F;
            buffer[2] = 0x74;
            PS3.SetMemory(0x27078DC, buffer);
            PS3.SetMemory(0x27078D6, new byte[] { 0x94, 0xA1, 160, 0x95, 0x9C, 0x9E });
            PS3.SetMemory(0x27078E7, new byte[] { 0x60 });
            PS3.SetMemory(0x27078EA, new byte[] { 0x60 });
            PS3.SetMemory(0x2707CCC, new byte[] { 0x30 });
            PS3.SetMemory(0x2707CDA, new byte[] { 0x2F });
            byte[] buffer2 = new byte[5];
            buffer2[0] = 0x8D;
            buffer2[2] = 0x9A;
            PS3.SetMemory(0x2707CEE, buffer2);
            PS3.SetMemory(0x2707CE8, new byte[] { 0x4A, 0xCD, 0xD0, 0x4A, 80, 0x45 });
            PS3.SetMemory(0x2707CF9, new byte[] { 0x60 });
            PS3.SetMemory(0x2707CFC, new byte[] { 0x60 });

            XtraMessageBox.Show("This mod work for Multiplayer and also for League Play! :D", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            if (checkEdit14.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit14.Value.ToString()));
                PS3.SetMemory(0x026FCD72 + 0x80, buffer);
            }
            if (checkEdit15.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit15.Value.ToString()));
                PS3.SetMemory(0x026FCD66 + 0x80, buffer);
            }
            if (checkEdit16.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit16.Value.ToString()));
                PS3.SetMemory(0x026FCD60 + 0x80, buffer);
            }
            if (checkEdit17.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit17.Value.ToString()));
                PS3.SetMemory(0x026FCD5A + 0x80, buffer);
            }
            if (checkEdit18.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit18.Value.ToString()));
                PS3.SetMemory(0x026FCD54 + 0x80, buffer);
            }
            if (checkEdit19.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit19.Value.ToString()));
                PS3.SetMemory(0x026FCD4E + 0x80, buffer);
            }
            if (checkEdit20.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit20.Value.ToString()));
                PS3.SetMemory(0x026FCD6C + 0x80, buffer);
            }
            if (checkEdit21.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit21.Value.ToString()));
                PS3.SetMemory(0x026FCDAE + 0x80, buffer);
            }
            if (checkEdit22.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit22.Value.ToString()));
                PS3.SetMemory(0x026FCDB4 + 0x80, buffer);
            }
            if (checkEdit23.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit23.Value.ToString()));
                PS3.SetMemory(0x026FCDBA + 0x80, buffer);
            }
            if (checkEdit24.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit24.Value.ToString()));
                PS3.SetMemory(0x026FCDC0 + 0x80, buffer);
            }
            if (checkEdit25.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit25.Value.ToString()));
                PS3.SetMemory(0x026FCDC6 + 0x80, buffer);
            }
            if (checkEdit26.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit26.Value.ToString()));
                PS3.SetMemory(0x026FCDCC + 0x80, buffer);
            }
            if (checkEdit27.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit27.Value.ToString()));
                PS3.SetMemory(0x026FCDD2 + 0x80, buffer);
            }
            if (checkEdit28.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit28.Value.ToString()));
                PS3.SetMemory(0x026FCDD8 + 0x80, buffer);
            }
            if (checkEdit29.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit29.Value.ToString()));
                PS3.SetMemory(0x026FCEC2 + 0x80, buffer);
            }
            if (checkEdit30.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit30.Value.ToString()));
                PS3.SetMemory(0x026FCC6A + 0x80, buffer);
            }
            if (checkEdit31.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit31.Value.ToString()));
                PS3.SetMemory(0x026FCCEE + 0x80, buffer);
            }
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit32.Value.ToString()));
            PS3.SetMemory(0x196821b, buffer);
        }

        private void simpleButton47_Click(object sender, EventArgs e)
        {
            byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit33.Value.ToString()));
            PS3.SetMemory(0x1968310, buffer);
        }

        private void simpleButton48_Click(object sender, EventArgs e)
        {
            byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit34.Value.ToString()));
            PS3.SetMemory(0x1968324, buffer);
        }

        private void simpleButton49_Click(object sender, EventArgs e)
        {
            byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(this.spinEdit35.Value.ToString()));
            PS3.SetMemory(0x1968320, buffer);
        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x0C };
            PS3.SetMemory(0x0196821B, buffer);
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x0B };
            PS3.SetMemory(0x0196821B, buffer);
        }

        private void simpleButton52_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x0A };
            PS3.SetMemory(0x0196821B, buffer);
        }

        private void simpleButton53_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x09 };
            PS3.SetMemory(0x0196821B, buffer);
        }

        private void simpleButton54_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x08 };
            PS3.SetMemory(0x0196821B, buffer);
        }

        private void simpleButton55_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x07 };
            PS3.SetMemory(0x0196821B, buffer);
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            PS3.SetMemory(0x97047c, buffer);
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            string[] strArray = new string[] { "# ZM_DLC2_TRAPPED_IN_TIME", "# ZM_DLC2_POP_GOES_THE_WEASEL", "# ZM_DLC2_FULL_LOCKDOWN", "# ZM_DLC2_GG_BRIDGE", "# ZM_DLC2_PARANORMAL_PROGRESS", "# ZM_DLC2_A_BURST_OF_FLAVOR", "# ZM_DLC2_FEED_THE_BEAST", "# ZM_DLC2_ACID_DRIP", "# ZM_DLC2_MAKING_THE_ROUNDS", "# ZM_DLC1_MONKEY_SEE_MONKEY_DOOM", "# ZM_DLC2_PRISON_SIDEQUEST", "# ZM_DLC1_I_SEE_LIVE_PEOPLE", "# ZM_DLC1_FACING_THE_DRAGON", "# ZM_DLC1_POLYARMORY", "# ZM_DLC1_IM_MY_OWN_BEST_FRIEND", "# ZM_DLC1_MAD_WITHOUT_POWER", "# ZM_DLC1_SLIPPERY_WHEN_UNDEAD", "# ZM_DLC1_SHAFTED", "# ZM_HAPPY_HOUR", "# ZM_DLC1_VERTIGONER", "# ZM_DLC1_HIGHRISE_SIDEQUEST", "# ZM_YOU_HAVE_NO_POWER_OVER_ME", "# ZM_FUEL_EFFICIENT", "# ZM_I_DONT_THINK_THEY_EXIST", "# ZM_UNDEAD_MANS_PARTY_BUS", "# ZM_STANDARD_EQUIPMENT_MAY_VARY", "# ZM_DANCE_ON_MY_GRAVE", "# ZM_TRANSIT_SIDEQUEST", "# ZM_THE_LIGHTS_OF_THEIR_EYES", "# ZM_DONT_FIRE_UNTIL_YOU_SEE", "# MP_MISC_3", "# MP_MISC_5",
            "# MP_MISC_4", "# SP_MISC_10K_SCORE_ALL", "# MP_MISC_2", "# MP_MISC_1", "# SP_BACK_TO_FUTURE", "# SP_MISC_WEAPONS", "# SP_STORY_99PERCENT", "# SP_STORY_CHLOE_LIVES", "# SP_MISC_ALL_INTEL", "# SP_STORY_MENENDEZ_CAPTURED", "# SP_STORY_HARPER_LIVES", "# SP_STORY_LINK_CIA", "# SP_STORY_OBAMA_SURVIVES", "# ZM_DLC3_WHEN_THE_REVOLUTION_COMES", "# SP_STORY_FARID_DUEL", "# SP_STORY_HARPER_FACE", "# SP_STORY_MASON_LIVES", "# SP_RTS_SOCOTRA", "# SP_RTS_PAKISTAN", "# SP_RTS_CARRIER", "# SP_RTS_DRONE", "# SP_RTS_AFGHANISTAN", "# SP_RTS_DOCKSIDE", "# SP_ONE_CHALLENGE", "# SP_ALL_CHALLENGES_IN_LEVEL", "# SP_ALL_CHALLENGES_IN_GAME", "# SP_VETERAN_FUTURE", "# SP_VETERAN_PAST", "# SP_COMPLETE_HAITI", "# SP_COMPLETE_LA", "# SP_COMPLETE_BLACKOUT", "# SP_COMPLETE_YEMEN",
            "# SP_COMPLETE_PANAMA", "# SP_COMPLETE_KARMA", "# SP_COMPLETE_PAKISTAN", "# SP_COMPLETE_NICARAGUA", "# SP_COMPLETE_AFGHANISTAN", "# SP_COMPLETE_MONSOON", "# SP_COMPLETE_ANGOLA", "# ZM_DLC3_FSIRT_AGAINST_THE_WALL", "# ZM_DLC3_AWAKEN_THE_GAZEBO", "# ZM_DLC3_MAZED_AND_CONFUSED", "# ZM_DLC3_BURIED_SIDEQUEST", "# ZM_DLC3_IM_YOUR_HUCKLEBERRY", "# ZM_DLC3_ECTOPLASMIC_RESIDUE", "# ZM_DLC3_DEATH_FROM_BELOW", "# ZM_DLC3_CANDYGRAM", "# ZM_DLC3_REVISIONIST_HISTORIAN", "# ZM_DLC4_TOMB_SIDEQUEST", "# ZM_DLC4_ALL_YOUR_BASE", "# ZM_DLC4_PLAYING_WITH_POWER", "# ZM_DLC4_OVERACHIEVER", "# ZM_DLC4_NOT_A_GOLD_DIGGER", "# ZM_DLC4_KUNG_FU_GRIP", "# ZM_DLC4_IM_ON_A_TANK", "# ZM_DLC4_SAVING_THE_DAY_ALL_DAY", "# ZM_DLC4_MASTER_OF_DISGUISE", "# ZM_DLC4_MASTER_WIZARD", "# ZM_PRISON_PERK_CHERRY" };
            
            byte[] buffer = new byte[] { 0x41, 130, 0, 0x7c, 60, 0x60, 0, 0x39, 0x38, 0x80, 0, 0, 0x3b, 0xe3, 0x73, 0xe4, 0x63, 0x43, 0, 0, 0xc3, 0xff, 0, 8 };
            byte[] buffer2 = new byte[] { 0x38, 0x60, 0xff, 0xff, 0x38, 0x80, 0, 1, 60, 160, 2, 0, 0x30, 0xa5, 80, 0, 0x4b, 0xfb, 0x27, 0xd1, 0x41, 130, 0, 0x68 };

            for (int i = 0; i < 0x5b; i++)
            {
                byte[] buffer3 = new byte[250];
                PS3.SetMemory(0x2005000, buffer3);
                PS3.SetMemory(0x2005000, Encoding.ASCII.GetBytes(strArray[i] + "\0"));
                PS3.SetMemory(0x3979FC, buffer2);
                Thread.Sleep(10);
                PS3.SetMemory(0x3979FC, buffer);
            }
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked)
            {
                PS3.Extension.WriteBytes(0x33CB4, new byte[] { 0x2C, 0x03, 0x00, 0x01 });
                checkButton1.Text = "Uav - ON";
            }
            else
            {
                PS3.Extension.WriteBytes(0x33CB4, new byte[] { 0x2C, 0x03, 0x00, 0x00 });
                checkButton1.Text = "Uav - OFF";
            }
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton2.Checked)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x00033C60, buffer);
                checkButton2.Text = "Vsat - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x40, 0x81, 0x00, 0x44 };
                PS3.SetMemory(0x00033C60, buffer);
                checkButton2.Text = "Vsat - OFF";
            }
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton3.Checked)
            {
                PS3.Extension.WriteBytes(0xEF68C, new byte[] { 0x2C, 0x03, 0x00, 0x01 });
                checkButton3.Text = "Laser - ON";
            }
            else
            {
                PS3.Extension.WriteBytes(0xEF68C, new byte[] { 0x2C, 0x03, 0x00, 0x00 });
                checkButton3.Text = "Laser - OFF";
            }
        }

        private void checkButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton4.Checked)
            {
                PS3.Extension.WriteBytes(0x000783E0, new byte[] { 0x38, 0x60, 0x00, 0x01 });
                PS3.Extension.WriteBytes(0x00078604, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                checkButton4.Text = "Red Boxes - ON";
            }
            else
            {
                PS3.Extension.WriteBytes(0x000783E0, new byte[] { 0x38, 0x60, 0x00, 0x00 });
                PS3.Extension.WriteBytes(0x00078604, new byte[] { 0x41, 0x81, 0x01, 0x0C });
                checkButton4.Text = "Red Boxes - OFF";
            }
        }

        private void checkButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton5.Checked)
            {
                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0xF9E54, buffer);
                checkButton5.Text = "No Recoil - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x48, 0x50, 0x6D, 0x65 };
                PS3.SetMemory(0xF9E54, buffer);
                checkButton5.Text = "No Recoil - OFF";
            }
        }

        private void checkButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton6.Checked)
            {
                byte[] buffer = new byte[] { 0x43, 0x48 };
                PS3.SetMemory(0x1CD03D8, buffer);
                checkButton6.Text = "Flying Deads - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0xC4, 0x48 };
                PS3.SetMemory(0x1CD03D8, buffer);
                checkButton6.Text = "Flying Deads - OFF";
            }
        }

        private void checkButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton7.Checked)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory(0x1CC4BF8, buffer);
                checkButton7.Text = "Target Finder - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory(0x1CC4BF8, buffer);
                checkButton7.Text = "Target Finder - OFF";
            }
        }

        private void checkButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton8.Checked)
            {
                byte[] buffer = new byte[] { 0x38, 0xC0, 0xFF, 0xFF };
                PS3.SetMemory(0x000834D0, buffer);
                PS3.Extension.WriteBytes(0x1CBF9F8, new byte[] { 0x00 });
                checkButton8.Text = "Wallhack - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x63, 0x26, 0x00, 0x00 };
                PS3.SetMemory(0x000834D0, buffer);
                PS3.Extension.WriteBytes(0x1CBF9F8, new byte[] { 0x01 });
                checkButton8.Text = "Wallhack - OFF";
            }
        }

        private void checkButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton9.Checked)
            {
                PS3.Extension.WriteBytes(0x01CC6E98, new byte[] { 0x3F, 0xFF, 0xFF, 0x00 });
                checkButton9.Text = "Big Names - ON";
            }
            else
            {
                PS3.Extension.WriteBytes(0x01CC6E98, new byte[] { 0x3F, 0x26, 0x66, 0x66 });
                checkButton9.Text = "Big Names - OFF";
            }
        }

        private void checkButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton10.Checked)
            {
                byte[] buffer = new byte[] { 0x2C, 0x04, 0x00, 0x00 };
                PS3.SetMemory(0x5F0A20, buffer);
                checkButton10.Text = "Steady Aim - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x2C, 0x04, 0x00, 0x02 };
                PS3.SetMemory(0x5F0A20, buffer);
                checkButton10.Text = "Steady Aim - OFF";
            }
        }

        private void checkButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton11.Checked)
            {
                byte[] buffer = new byte[] { 0x46, 0xE6, 0x00, 0x00 };
                PS3.SetMemory(0x1CC52D8, buffer);
                checkButton11.Text = "Reverse Map - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x41, 0x20, 0x00, 0x00 };
                PS3.SetMemory(0x1CC52D8, buffer);
                checkButton11.Text = "Reverse Map - OFF";
            }
        }

        private void checkButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton12.Checked)
            {
                byte[] buffer = new byte[] { 0x2C, 0x03, 0x00, 0x01 };
                PS3.SetMemory(0xEF68C, buffer);
                checkButton12.Text = "Blinking Bodies - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0xDB, 0xC1, 0x00, 0xF0 };
                PS3.SetMemory(0xEF68C, buffer);
                checkButton12.Text = "Blinking Bodies - OFF";
            }
        }

        private void checkButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton13.Checked)
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory(0x1CD6018, buffer);
                checkButton13.Text = "Force Host - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory(0x1CD6018, buffer);
                checkButton13.Text = "Force Host - OFF";
            }
        }

        private void checkButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton14.Checked)
            {
                SForceHStart(true);
                checkButton14.Text = "Super Force Host - ON";
            }
            else
            {
                SForceHStart(false);
                checkButton14.Text = "Super Force Host - OFF";
            }
        }

        public static void SForceHStart(bool toggle)
        {
            if (threadStart_4 == null)
            {
                threadStart_4 = new ThreadStart(SFHFunct);
            }
            thread_4 = new Thread(threadStart_4);
            if (toggle == true)
            {
                bool_100 = true;
                thread_4.Start();
            }
            else
            {
                bool_100 = false;
                thread_4.Abort();
            }
        }

        private static void SFHFunct()
        {
            PS3.SetMemory(0x01CD6553, new byte[] { 0x00 });
            PS3.SetMemory(0x01CD5F53, new byte[] { 0x01 });
            PS3.SetMemory(0x01CD69D3, new byte[] { 0x01 });
            PS3.SetMemory(0x19A95C0, new byte[] { 0x01 });
        }

        private void checkEdit32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit32.Checked)
            {
                byte[] buffer2 = new byte[] { 0x41, 0x82, 0x08, 0xF0 };
                PS3.SetMemory(0x37FEC, buffer2);
                byte[] buffer3 = Encoding.ASCII.GetBytes("                   ");
                PS3.SetMemory(0x8E3290, buffer3);

                byte[] buffer4 = Encoding.ASCII.GetBytes("");
                PS3.SetMemory(0x8E3290, buffer4);

                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x37FEC, buffer);
                byte[] buffer1 = Encoding.ASCII.GetBytes(textEdit2.Text);
                PS3.SetMemory(0x8E3290, buffer1);
            }
            else
            {
                byte[] buffer = new byte[] { 0x41, 0x82, 0x08, 0xF0 };
                PS3.SetMemory(0x37FEC, buffer);
                byte[] buffer1 = Encoding.ASCII.GetBytes("                   ");
                PS3.SetMemory(0x8E3290, buffer1);
            }
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC143C, new byte[] { 0x3F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 });
            simpleButton23.Text = "Default - ON";
            simpleButton24.Text = "Electric Blue";
            simpleButton25.Text = "Electric Green";
            simpleButton26.Text = "Electric Pink";
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC143C, new byte[] { 0x6F, 0x80, 0x00, 0x00, 0x6F, 0x80, 0x00 });
            simpleButton23.Text = "Default";
            simpleButton24.Text = "Electric Blue - ON";
            simpleButton25.Text = "Electric Green";
            simpleButton26.Text = "Electric Pink";
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC143C, new byte[] { 0x6F, 0x80, 0x00, 0x00, 0x3F, 0x80, 0x00, 0x00 });
            simpleButton23.Text = "Default";
            simpleButton24.Text = "Electric Blue";
            simpleButton25.Text = "Electric Green - ON";
            simpleButton26.Text = "Electric Pink";
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC143C, new byte[] { 0x1F, 0xFF, 0x00, 0x00, 0x5F, 0xFF, 0x00 });
            simpleButton23.Text = "Default";
            simpleButton24.Text = "Electric Blue";
            simpleButton25.Text = "Electric Green";
            simpleButton26.Text = "Electric Pink - ON";
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC28D8, new byte[] { 0x3F, 0x80 });
            simpleButton30.Text = "Default - ON";
            simpleButton29.Text = "Black";
            simpleButton28.Text = "Fog";
            simpleButton27.Text = "Light";
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC28D8, new byte[] { 0xFF, 0x80 });
            simpleButton30.Text = "Default";
            simpleButton29.Text = "Black - ON";
            simpleButton28.Text = "Fog";
            simpleButton27.Text = "Light";
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC28D8, new byte[] { 0x3D, 0x80 });
            simpleButton30.Text = "Default";
            simpleButton29.Text = "Black";
            simpleButton28.Text = "Fog - ON";
            simpleButton27.Text = "Light";
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x01CC28D8, new byte[] { 0x5F, 0xFF });
            simpleButton30.Text = "Default";
            simpleButton29.Text = "Black";
            simpleButton28.Text = "Fog";
            simpleButton27.Text = "Light - ON";
        }

        private void simpleButton96_Click(object sender, EventArgs e)
        {
            if (PS3.Extension.ReadString(0x026C0658) != labelControl4.Text)
            {
                labelControl4.Text = PS3.Extension.ReadString(0x026C0658);
            }
            byte[] buffer = Encoding.ASCII.GetBytes(textEdit4.Text);
            Array.Resize(ref buffer, buffer.Length + 1);
            PS3.SetMemory(0x026C0658, buffer);
            PS3.SetMemory(0x26C067F, buffer);
        }

        private void simpleButton97_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(labelControl4.Text);
            textEdit4.Text = labelControl4.Text;
            Array.Resize(ref buffer, buffer.Length + 1);
            PS3.SetMemory(0x026C0658, buffer);
            PS3.SetMemory(0x26C067F, buffer);
        }

        private void checkEdit33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit33.Checked)
            {
                tx4 = textEdit4.Text;
                FlashNameStart(true);
            }
            else
            {
                FlashNameStart(false);
            }
        }

        public static void FlashNameStart(bool toggle)
        {
            if (threadStart_2 == null)
            {
                threadStart_2 = new ThreadStart(FlashNameFunc);
            }
            thread_2 = new Thread(threadStart_2);
            if (toggle == true)
            {
                bool_99 = true;
                thread_2.Start();
            }
            else
            {
                bool_99 = false;
                thread_2.Abort();
            }
        }

        private static void FlashNameFunc()
        {
            while (bool_99)
            {
                int num = new Random().Next(0, 7);
                byte[] buffer = Encoding.ASCII.GetBytes("^" + num + tx4);
                Array.Resize<byte>(ref buffer, buffer.Length + 1);
                PS3.SetMemory(0x026C0658, buffer);
                PS3.SetMemory(0x026c067f, buffer);
            }
        }

        private byte[] Combine(byte[] Arr1, byte[] Arr2)
        {
            byte[] Res = new byte[Arr1.Length + Arr2.Length];
            Buffer.BlockCopy(Arr1, 0, Res, 0, Arr1.Length);
            Buffer.BlockCopy(Arr2, 0, Res, Arr1.Length, Arr2.Length);
            return Res;
        }

        private void SetClan(uint offset, string input)
        {
            PS3.SetMemory(offset, new byte[6]);
            if (input.Length == 1)
            {
                CombSetClan = Combine(new byte[7], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            else if (input.Length == 2)
            {
                CombSetClan = Combine(new byte[6], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            else if (input.Length == 3)
            {
                CombSetClan = Combine(new byte[5], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            else if (input.Length == 4)
            {
                CombSetClan = Combine(new byte[4], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            if (input.Length > 0)
            {
                PS3.SetMemory(offset, BitConverter.GetBytes(BitConverter.ToUInt64(CombSetClan, 0) * 64));
            }
        }

        private void simpleButton100_Click(object sender, EventArgs e)
        {
            SetClan(0x2708238, textEdit5.Text);
        }

        private void checkEdit34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit34.Checked)
            {
                tx8 = textEdit8.Text;
                tx6 = textEdit6.Text;
                tx7 = textEdit7.Text;
                tx10 = textEdit10.Text;
                tx11 = textEdit8.Text;
                tx9 = textEdit6.Text;
                tx12 = textEdit7.Text;
                tx13 = textEdit10.Text;
                stopWatch.Start();
                WatchRestStart(true);
                SkipperStart(true);
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                WatchRestStart(false);
                SkipperStart(false);
            }
        }

        #region MpSkipper
        public static void WatchRestStart(bool toggle)
        {
            if (threadStart_0 == null)
            {
                threadStart_0 = new ThreadStart(WatchRestFunct);
            }
            thread_0 = new Thread(threadStart_0);
            if (toggle == true)
            {
                bool_97 = true;
                thread_0.Start();
            }
            else
            {
                bool_97 = false;
                thread_0.Abort();
            }
        }

        private static void WatchRestFunct()
        {
            while (bool_97)
            {
                timeWatch = Convert.ToString(stopWatch.Elapsed);
                if (timeWatch.Contains("00:00:09."))
                {
                    stopWatch.Restart();
                }
            }
        }

        public static void SkipperStart(bool toggle)
        {
            if (threadStart_1 == null)
            {
                threadStart_1 = new ThreadStart(SkipperFunc);
            }
            thread_1 = new Thread(SkipperFunc);
            if (toggle == true)
            {
                bool_98 = true;
                thread_1.Start();
            }
            else
            {
                bool_98 = false;
                thread_1.Abort();
            }
        }

        private static void SkipperFunc()
        {
            while (bool_98)
            {
                if (timeWatch.Contains("00:00:00."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx8);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:01."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx6);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:02."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx7);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:03."))
                {
                   byte[] buffer = Encoding.ASCII.GetBytes(tx10);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:04."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx11);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:05."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx9);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:06."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx12);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:07."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx13);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
            }
        }
        #endregion

        private void checkButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton15.Checked)
            {
                BO2.MyFunc.ClockNameStart(true);
                checkButton15.Text = "Set Clock Name - ON";
            }
            else
            {
                BO2.MyFunc.ClockNameStart(false);
                checkButton15.Text = "Set Clock Name - OFF";
            }
        }

        #region ZmSkipper
        public static void ZmWatchRestStart(bool toggle)
        {
            if (threadStart_6 == null)
            {
                threadStart_6 = new ThreadStart(ZmWatchRestFunct);
            }
            thread_6 = new Thread(threadStart_6);
            if (toggle == true)
            {
                bool_103 = true;
                thread_6.Start();
            }
            else
            {
                bool_103 = false;
                thread_6.Abort();
            }
        }

        private static void ZmWatchRestFunct()
        {
            while (bool_103)
            {
                timeWatch = Convert.ToString(stopWatch.Elapsed);
                if (timeWatch.Contains("00:00:09."))
                {
                    stopWatch.Restart();
                }
            }
        }

        public static void ZmSkipperStart(bool toggle)
        {
            if (threadStart_7 == null)
            {
                threadStart_7 = new ThreadStart(SkipperFunc);
            }
            thread_7 = new Thread(ZmSkipperFunc);
            if (toggle == true)
            {
                bool_104 = true;
                thread_7.Start();
            }
            else
            {
                bool_104 = false;
                thread_7.Abort();
            }
        }

        private static void ZmSkipperFunc()
        {
            while (bool_104)
            {
                if (timeWatch.Contains("00:00:00."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx29);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:01."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx30);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:02."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx31);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:03."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx33);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:04."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx35);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:05."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx36);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:06."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx34);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
                if (timeWatch.Contains("00:00:07."))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(tx32);
                    Array.Resize(ref buffer, buffer.Length + 1);
                    PS3.SetMemory(0x026C0658, buffer);
                }
            }
        }
        #endregion

        private void SetClass1(uint offset, string input)
        {
            PS3.SetMemory(offset, new byte[16]);


            byte[] Multiplier = new byte[] { 0x04 };
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            PS3.SetMemory(offset, Functions.Multiply(inputBytes, Multiplier));
        }

        private void simpleButton94_Click(object sender, EventArgs e)
        {
            SetClass1(0x02707AC7 + ((uint)spinEdit36.Value - 1) * 0x10, textEdit3.Text);
        }

        private void simpleButton95_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                SetClass1(0x02707AC7 + (uint)i * 0x10, textEdit3.Text);
            }
        }

        public string GetName(int ClientNum)
        {
            return PS3.Extension.ReadString(0x1780F28 + 0x5544 + (0x5808 * (uint)ClientNum));
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            textEdit14.Text = GetName(0);
            textEdit15.Text = GetName(1);
            textEdit16.Text = GetName(2);
            textEdit17.Text = GetName(3);
            textEdit21.Text = GetName(4);
            textEdit20.Text = GetName(5);
            textEdit19.Text = GetName(6);
            textEdit18.Text = GetName(7);
            textEdit25.Text = GetName(8);
            textEdit24.Text = GetName(9);
            textEdit23.Text = GetName(10);
            textEdit22.Text = GetName(11);
        }

        private void simpleButton32_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit14.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(0x178646C, Name);
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit15.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName1, Name);
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit16.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName2, Name);
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit17.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName3, Name);
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit21.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName4, Name);
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit20.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName5, Name);
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit19.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName6, Name);
        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit18.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName7, Name);
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit25.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName8, Name);
        }

        private void simpleButton42_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit24.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName9, Name);
        }

        private void simpleButton41_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit23.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName10, Name);
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textEdit22.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(BO2.Offsets.Multiplayermods.InGameName11, Name);
        }

        private void checkEdit36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit36.Checked)
            {
                if (rpcConnected == true)
                {
                    BO2.MyFunc.iPrintBoldStart(textEdit26.Text, true);
                }
                else
                {
                    checkEdit36.Checked = false;
                    XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BO2.MyFunc.iPrintBoldStart(textEdit26.Text, false);
            }
        }

        private void checkEdit35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit35.Checked)
            {
                if (rpcConnected == true)
                {
                    BO2.MyFunc.iPrintStart(textEdit26.Text, true);
                }
                else
                {
                    checkEdit35.Checked = false;
                    XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BO2.MyFunc.iPrintStart(textEdit26.Text, false);
            }
        }

        private void simpleButton57_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                string comm = "cmd mr " + PS3.Extension.ReadInt32(15801756u) + " 3 endround";
                RPC.Call(3226648u, new object[] { 0, comm });
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.Cbuf_AddText("map_restart");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton105_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                listBoxControl1.Items.Add(GetName(i));
            }
        }

        private void checkButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton16.Checked)
            {
                byte[] buffer = new byte[] { 0x05 };
                PS3.SetMemory((uint)(0x1780F43 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "God Mode ^2ON");
                checkButton16.Text = "God Mode - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x04 };
                PS3.SetMemory((uint)(0x1780F43 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "God Mode ^1OFF");
                checkButton16.Text = "God Mode - OFF";
            }
        }

        private void checkButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton17.Checked)
            {
                BO2.MyFunc.AmmoStart(listBoxControl1.SelectedIndex, true);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Unlimited Ammo ^2ON");
                checkButton17.Text = "Unlimited Ammo - ON";
            }
            else
            {
                BO2.MyFunc.AmmoStart(listBoxControl1.SelectedIndex, false);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Unlimited Ammo ^1OFF");
                checkButton17.Text = "Unlimited Ammo - OFF";
            }
        }

        private void checkButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton18.Checked)
            {
                byte[] buffer = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
                PS3.SetMemory((uint)(0x1781470 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "All Perks ^2ON");
                checkButton18.Text = "All Perks - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 };
                PS3.SetMemory((uint)(0x1781470 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(0, "All Perks ^1OFF");
                checkButton18.Text = "All Perks - OFF";
            }
        }

        private void checkButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton19.Checked)
            {
                byte[] buffer = new byte[] { 15 };
                PS3.SetMemory((uint)(0x1786717 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "VSAT ^2ON");
                checkButton19.Text = "Vsat - ON";
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1786717 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "VSAT ^1OFF");
                checkButton19.Text = "Vsat - OFF";
            }
        }

        private void checkButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton20.Checked)
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1781487 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                PS3.SetMemory((uint)(0x178147f + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                PS3.SetMemory((uint)(0x178147b + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Remove Killstreaks ^2ON");
                checkButton20.Text = "Remove Killstreaks - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory((uint)(0x1781487 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                PS3.SetMemory((uint)(0x178147f + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                PS3.SetMemory((uint)(0x178147b + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Remove Killstreaks ^1OFF");
                checkButton20.Text = "Remove Killstreaks - OFF";
            }
        }

        private void checkButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton23.Checked)
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory((uint)(0x1780fac + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Third Person ^2ON");
                checkButton23.Text = "Third Person - ON";
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1780fac + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Third Person ^1OFF");
                checkButton23.Text = "Third Person - OFF";
            }
        }

        private void checkButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton24.Checked)
            {
                byte[] buffer = new byte[] { 15 };
                PS3.SetMemory((uint)(0x17865bf + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Freeze ^2ON");
                checkButton24.Text = "Freeze - ON";
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x17865bf + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Freeze ^1OFF");
                checkButton24.Text = "Freeze - OFF";
            }
        }

        private void checkButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton25.Checked)
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1786363 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Lag ^2ON");
                checkButton25.Text = "Lag - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 2 };
                PS3.SetMemory((uint)(0x1780F28 + 0x543B + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Lag ^1OFF");
                checkButton25.Text = "Lag - OFF";
            }
        }

        private void checkButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton26.Checked)
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory((uint)(0x1786718 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Prone ^2ON");
                checkButton26.Text = "Prone - ON";
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1786718 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Prone ^1OFF");
                checkButton26.Text = "Prone - OFF";
            }
        }

        private void checkButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton22.Checked)
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory((uint)(0x1781025 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Invisible ^2ON");
                checkButton22.Text = "Invisible - ON";
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1781025 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Invisible ^1OFF");
                checkButton22.Text = "Invisible - OFF";
            }
        }

        private void checkButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton21.Checked)
            {
                byte[] buffer = new byte[] { 0x40 };
                PS3.SetMemory((uint)(0x1786418 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Speed x2 ^2ON");
                checkButton21.Text = "Speed x2 - ON";
            }
            else
            {
                byte[] buffer = new byte[] { 0x3f };
                PS3.SetMemory((uint)(0x1786418 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Speed x2 ^1OFF");
                checkButton21.Text = "Speed x2 - OFF";
            }
        }

        private void simpleButton45_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                byte[] buffer = new byte[1];
                byte[] buffer2 = new byte[] { 0x00 };
                PS3.SetMemory((uint)(0x1780F42 + (listBoxControl1.SelectedIndex * 0x5808)), buffer2);
                PS3.SetMemory((uint)(0x178150B + (listBoxControl1.SelectedIndex * 0x5808)), buffer2);
                PS3.SetMemory((uint)(0x178102B + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "^2Default Vision");
            }
            else if (comboBoxEdit1.SelectedIndex == 1)
            {
                byte[] buffer = new byte[] { 0x10 };
                PS3.SetMemory((uint)(0x1780F42 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Night Vision ^2ON");
            }
            else if (comboBoxEdit1.SelectedIndex == 2)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory((uint)(0x178150B + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Poison Vision ^2ON");
            }
            else if (comboBoxEdit1.SelectedIndex == 3)
            {
                byte[] buffer = new byte[] { 0x04, 0x02 };
                PS3.SetMemory((uint)(0x178102B + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "Lodestar Vision ^2ON");
            }
            else if (comboBoxEdit1.SelectedIndex == 4)
            {
                byte[] buffer = new byte[] { 0x02, 0x08 };
                PS3.SetMemory((uint)(0x178102B + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
                if (rpcConnected)
                    RPC.iPrintln(-1, "VTOL Vision ^2ON");
            }
        }

        private void simpleButton59_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 70 };
            PS3.SetMemory((uint)(0x1780F58 + (listBoxControl1.SelectedIndex * 0x5808)), buffer);
            if (rpcConnected)
                RPC.iPrintln(-1, "^2Killing..");
        }

        private void simpleButton60_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.KickNoob(listBoxControl1.SelectedIndex);
                RPC.iPrintln(0, "^2Noob Kicked");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton56_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteByte((uint)(0x17811CB + (listBoxControl1.SelectedIndex * 0x5808)), byte_1[comboBoxEdit2.SelectedIndex]);
            PS3.Extension.WriteByte((uint)(0x17811AF + (listBoxControl1.SelectedIndex * 0x5808)), byte_1[comboBoxEdit2.SelectedIndex]);
            PS3.Extension.WriteByte((uint)(0x1781203 + (listBoxControl1.SelectedIndex * 0x5808)), byte_1[comboBoxEdit2.SelectedIndex]);
            PS3.Extension.WriteByte((uint)(0x1781203 + (listBoxControl1.SelectedIndex * 0x5808)), byte_1[comboBoxEdit2.SelectedIndex]);
            if (rpcConnected)
                RPC.iPrintln(-1, "^2Camo Gived");
        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit3.SelectedIndex == 0)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "MP7");
                comboBoxEdit4.Properties.Items.Insert(1, "PDW-57");
                comboBoxEdit4.Properties.Items.Insert(2, "Vector K10");
                comboBoxEdit4.Properties.Items.Insert(3, "MSMC");
                comboBoxEdit4.Properties.Items.Insert(4, "Skorpion Evo");
                comboBoxEdit4.Properties.Items.Insert(5, "PeaceKeeper");
                comboBoxEdit4.Properties.Items.Insert(6, "Chicom");
                comboBoxEdit4.Properties.Items.Insert(7, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
            else if (comboBoxEdit3.SelectedIndex == 1)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "MTAR");
                comboBoxEdit4.Properties.Items.Insert(1, "FAL DSW");
                comboBoxEdit4.Properties.Items.Insert(2, "M 27");
                comboBoxEdit4.Properties.Items.Insert(3, "Scar-H");
                comboBoxEdit4.Properties.Items.Insert(4, "M8A1");
                comboBoxEdit4.Properties.Items.Insert(5, "AN-94");
                comboBoxEdit4.Properties.Items.Insert(6, "Type 25");
                comboBoxEdit4.Properties.Items.Insert(7, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
            else if (comboBoxEdit3.SelectedIndex == 2)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "R870 MCS");
                comboBoxEdit4.Properties.Items.Insert(1, "KSG");
                comboBoxEdit4.Properties.Items.Insert(2, "S 12");
                comboBoxEdit4.Properties.Items.Insert(3, "M1216");
                comboBoxEdit4.Properties.Items.Insert(4, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
            else if (comboBoxEdit3.SelectedIndex == 3)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "MK 48");
                comboBoxEdit4.Properties.Items.Insert(1, "LSAT");
                comboBoxEdit4.Properties.Items.Insert(2, "HAMR");
                comboBoxEdit4.Properties.Items.Insert(3, "QBBLSW");
                comboBoxEdit4.Properties.Items.Insert(4, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
            else if (comboBoxEdit3.SelectedIndex == 4)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "SVU-AS");
                comboBoxEdit4.Properties.Items.Insert(1, "DSR-50");
                comboBoxEdit4.Properties.Items.Insert(2, "Ballista");
                comboBoxEdit4.Properties.Items.Insert(3, "XPR-50");
                comboBoxEdit4.Properties.Items.Insert(4, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
            else if (comboBoxEdit3.SelectedIndex == 5)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "Five Seven");
                comboBoxEdit4.Properties.Items.Insert(1, "Tac 45");
                comboBoxEdit4.Properties.Items.Insert(2, "B23R");
                comboBoxEdit4.Properties.Items.Insert(3, "Executioner");
                comboBoxEdit4.Properties.Items.Insert(4, "KAP 40");
                comboBoxEdit4.Properties.Items.Insert(5, "SMAW");
                comboBoxEdit4.Properties.Items.Insert(6, "FHJ-18 AA");
                comboBoxEdit4.Properties.Items.Insert(7, "RPG");
                comboBoxEdit4.Properties.Items.Insert(8, "Assault Shield");
                comboBoxEdit4.Properties.Items.Insert(9, "Combat Knife");
                comboBoxEdit4.Properties.Items.Insert(10, "Ballistic Kinfe");
                comboBoxEdit4.Properties.Items.Insert(11, "Crossbow");
                comboBoxEdit4.Properties.Items.Insert(12, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
            else if (comboBoxEdit3.SelectedIndex == 6)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "Grenade");
                comboBoxEdit4.Properties.Items.Insert(1, "Semtex");
                comboBoxEdit4.Properties.Items.Insert(2, "Bouncing Betty");
                comboBoxEdit4.Properties.Items.Insert(3, "C4");
                comboBoxEdit4.Properties.Items.Insert(4, "Claymore");
                comboBoxEdit4.Properties.Items.Insert(5, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
            else if (comboBoxEdit3.SelectedIndex == 7)
            {
                comboBoxEdit4.Properties.Items.Clear();
                comboBoxEdit4.Properties.Items.Insert(0, "Flashbang");
                comboBoxEdit4.Properties.Items.Insert(1, "Shock Charge");
                comboBoxEdit4.Properties.Items.Insert(2, "Black Hat");
                comboBoxEdit4.Properties.Items.Insert(3, "EMP Grenade");
                comboBoxEdit4.Properties.Items.Insert(4, "Tactical Insertion");
                comboBoxEdit4.Properties.Items.Insert(5, "Trophy Sistem");
                comboBoxEdit4.Properties.Items.Insert(6, "Default Weapon");
                comboBoxEdit4.SelectedIndex = 0;
            }
        }

        private void simpleButton61_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit4.SelectedIndex == -1)
            {
                XtraMessageBox.Show("You have to select a weapon first..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxEdit4.SelectedIndex != -1)
            {
                if (comboBoxEdit4.Text == "Default Weapon")
                {
                    BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.WEAPON_DEFAULTWEAPON);
                    if (rpcConnected == true)
                    {
                        RPC.iPrintln(0, "^2Weapon Gived");
                    }
                }
            if (comboBoxEdit4.Text == "MP7")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.MP7);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "PDW-57")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.PDW57);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Vector K10")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Vector);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "MSMC")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.MSMC);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Skorpion Evo")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Scorpion);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "PeaceKeeper")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.PeaceKeeper);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Chicom")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Chicom);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "MTAR")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.MTAR);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "FAL DSW")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.FAL);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "M 27")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.M27);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Scar-H")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.ScarH);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "M8A1")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.M8A1);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "AN-94")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.An94);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Type 25")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Type25);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "R870 MCS")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Remington);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "KSG")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.KSG);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "S 12")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.S12);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "M1216")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.M1216);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "MK 48")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.MK48);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "LSAT")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.LSAT);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "HAMR")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.HAMR);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "QBBLSW")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.QBBLSW);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "SVU-AS")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.SVU);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "DSR-50")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.DSR50);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Ballista")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Ballista);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "XPR-50")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.XPR50);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Five Seven")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.FiveSeven);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Five Seven X2")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.FiveSevenX2);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Tac 45")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.TAC45);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Tac 45 x2")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.TAC45x2);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "B23R")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.B23r);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "B23R x2")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.b23rx2);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Executioner")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Executioner);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Executioner x2")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.Executionerx2);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "KAP 40")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.KAP40);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "KAP 40 x2")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.KAP40x2);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "SMAW")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.SMAW);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "FHJ-18 AA")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.FHJ18);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "RPG")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.RPG);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Assault Shield")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.AssaultShield);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Combat Knife")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.CombatKnife);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Ballistic Kinfe")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.ballisticknife);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Crossbow")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give1(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.Weapons.crossbow);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Grenade")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give2(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.Grenade);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Semtex")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give2(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.Semtex);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Bouncing Betty")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give2(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.BouncingBetty);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "C4")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give2(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.C4);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Claymore")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give2(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.Claymore);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Flashbang")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give3(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.FlashBang);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Shock Charge")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give3(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.ShockCharge);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Black Hat")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give3(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.BlackHat);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "EMP Grenade")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give3(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.EMPGrenade);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Tactical Insertion")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give3(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.TacInsert);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            else if (comboBoxEdit4.Text == "Trophy Sistem")
            {
                BO2.MultiplayerWeapons.Multiplayer.Give3(listBoxControl1.SelectedIndex, BO2.MultiplayerWeapons.Multiplayer.LethalTactical.TrophySystem);
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "^2Weapon Gived");
                }
            }
            }
        }

        private void checkButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton27.Checked)
            {
                PS3.SetMemory(0x1CC52D8, new byte[] { 0x42, 220 });
                checkButton27.Text = "Fov - ON";
            }
            else
            {
                PS3.SetMemory(0x1CC52D8, new byte[] { 0x41, 0x20 });
                checkButton27.Text = "Fov - OFF";
            }
        }

        private void checkButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton28.Checked)
            {
                timer10.Start();
                checkButton28.Text = "Flashing Bodies - OFF";
            }
            else
            {
                timer10.Stop();
                checkButton28.Text = "Flashing Bodies - OFF";
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            int_blu++;
            byte[] buffer = new byte[8];
            buffer = new byte[7];
            buffer[0] = 0x3f;
            buffer[4] = 0xff;

            byte[] buffer2 = new byte[6];
            buffer2[0] = 0x3f;
            buffer2[4] = 0x3f;
            switch (int_blu)
            {
                case 1:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0x3f, 0xff, 0, 0, 0x3f, 0 });
                    break;

                case 2:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0x6f, 0x80, 0, 0, 0x3f, 0x80, 0, 0 });
                    break;

                case 3:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0x3f, 0x80, 0, 0, 0x6f, 0x80, 0 });
                    break;

                case 4:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0x6f, 0x80, 0, 0, 0x6f, 0x80, 0 });
                    break;

                case 5:
                    PS3.SetMemory(0x1CC143C, new byte[] { 15, 0x80, 0, 0, 0x3f, 0x80, 0 });
                    break;

                case 6:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0xff, 0xff, 0, 0, 0x3f, 0xff, 0 });
                    break;

                case 7:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0x1f, 0xff, 0, 0, 0x5f, 0xff, 0 });
                    break;

                case 8:
                    PS3.SetMemory(0x1CC143C, new byte[8]);
                    break;

                case 9:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0x3f, 0xff, 0, 0, 0x1f, 0, 0 });
                    break;

                case 10:
                    PS3.SetMemory(0x1CC143C, buffer);
                    break;
                    
                case 11:
                    PS3.SetMemory(0x1CC143C, buffer2);
                    break;

                case 12:
                    PS3.SetMemory(0x1CC143C, new byte[] { 0x3f, 0x80, 0, 0, 0x3f, 0x80, 0, 0 });
                    break;
            }
            if (this.int_blu == 12)
            {
                this.int_blu = 0;
            }
        }

        private void checkButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton29.Checked)
            {
                PS3.SetMemory((uint)(0x1780F28 + 0x54F0 + (listBoxControl1.SelectedIndex * 0x5808)), new byte[1]);
                checkButton29.Text = "Jumper Mod - ON";
                if (rpcConnected)
                    RPC.iPrintln(-1, "Jumper Mod - ^2ON");
            }
            else
            {
                byte[] buffer = new byte[] { 0x22 };
                PS3.SetMemory((uint)(0x1780F28 + 0x54F0 + (listBoxControl1.SelectedIndex * 0x5808)), new byte[] { 0x3f });
                checkButton29.Text = "Jumper Mod - OFF";
                if (rpcConnected)
                    RPC.iPrintln(-1, "Jumper Mod - ^1OFF");
            }
        }

        private void simpleButton75_Click(object sender, EventArgs e)
        {
            BO2.MyFunc.ChangeTeam(listBoxControl1.SelectedIndex, byte_0[comboBoxEdit5.SelectedIndex]);
        }

        private void simpleButton58_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                PS3.Extension.WriteBytes(0x17865BF + ((uint)i * 0x5808), new byte[] { 0x00 });
            }
            if (rpcConnected)
                RPC.iPrintln(0, "^2No Countdown");
        }

        private void simpleButton80_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x17865BF + ((uint)listBoxControl1.SelectedIndex * 0x5808), new byte[] { 0x00 });
            if (rpcConnected)
                RPC.iPrintln(0, "^2No Countdown");
        }

        private void simpleButton81_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.Call(0x313C18, new object[] { 0, string.Format("set ui_mapname mp_{0};wait 10;map mp_{1}\0", BO2.MyFunc.strMaps[comboBoxEdit6.SelectedIndex], BO2.MyFunc.strMaps[comboBoxEdit6.SelectedIndex]) });
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton71_Click(object sender, EventArgs e)
        {
            if (rpcConnected)
            {
                RPC.Call(0x313C18, new object[] { 0, BO2.MyFunc.strGameMode[comboBoxEdit7.SelectedIndex] });
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton68_Click(object sender, EventArgs e)
        {
            if (checkEdit37.Checked)
            {
                if (rpcConnected == false)
                {
                    XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BO2.MyFunc.ScoreperKill(Convert.ToString(spinEdit37.Value));
                }
            }
            if (checkEdit38.Checked)
            {
                if (rpcConnected == false)
                {
                    XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BO2.MyFunc.ScoreLimit(Convert.ToString(spinEdit38.Value));
                }
            }
            if (checkEdit39.Checked)
            {
                if (rpcConnected == false)
                {
                    XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BO2.MyFunc.TimeLimit(Convert.ToString(spinEdit39.Value));
                }
            }
            if (checkEdit40.Checked)
            {
                if (rpcConnected == false)
                {
                    XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BO2.MyFunc.RoundsLimit(Convert.ToString(spinEdit40.Value));
                }
            }
            if (checkEdit41.Checked)
            {
                if (rpcConnected == false)
                {
                    XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BO2.MyFunc.LiveLimit(Convert.ToString(spinEdit41.Value));
                }
            }
        }

        private void simpleButton69_Click(object sender, EventArgs e)
        {
            BO2.MyFunc.RemoveWeapons(listBoxControl1.SelectedIndex);
        }

        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl1.Value == 0)
            {
                byte[] buffer = new byte[] { 0x40, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl1.Value == 1)
            {
                byte[] buffer = new byte[] { 0x42, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl1.Value == 2)
            {
                byte[] buffer = new byte[] { 0x44, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl1.Value == 3)
            {
                byte[] buffer = new byte[] { 0x46, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl1.Value == 4)
            {
                byte[] buffer = new byte[] { 0x48, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
        }

        private void zoomTrackBarControl2_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl2.Value == 0)
            {
                byte[] buffer = new byte[3];
                PS3.SetMemory(0x1CA4E78, buffer);
            }
            else if (zoomTrackBarControl2.Value == 1)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 0x01;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
            else if (zoomTrackBarControl2.Value == 2)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 2;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
            else if (zoomTrackBarControl2.Value == 3)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 4;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
            else if (zoomTrackBarControl2.Value == 4)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 6;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
        }

        private void zoomTrackBarControl3_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl3.Value == 0)
            {
                byte[] buffer = new byte[] { 0x3E, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
            }
            else if (zoomTrackBarControl3.Value == 1)
            {
                byte[] buffer = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
            }
            else if (zoomTrackBarControl3.Value == 2)
            {
                byte[] buffer = new byte[] { 0x40, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
            }
        }

        private void zoomTrackBarControl4_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl4.Value == 0)
            {
                byte[] buffer = new byte[] { 0x45, 0x48 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
            else if (zoomTrackBarControl4.Value == 1)
            {
                byte[] buffer = new byte[] { 0x44, 0x48 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
            else if (zoomTrackBarControl4.Value == 2)
            {
                byte[] buffer = new byte[] { 0x43, 9 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
            else if (zoomTrackBarControl4.Value == 3)
            {
                byte[] buffer = new byte[] { 0x42, 0x48 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
        }

        private void checkButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton30.Checked)
            {
                PS3.SetMemory(0x1CAF0d8, new byte[] { 0x49, 0xff, 0xff });
                PS3.SetMemory(0x1CAF138, new byte[] { 0x49, 0xff, 0xff });
                PS3.SetMemory(0x1CAF198, new byte[] { 0x49, 0xff, 0xff });
                checkButton30.Text = "Melee Range - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Melee Range - ^2ON");
            }
            else
            {
                byte[] buffer = new byte[3];
                buffer[0] = 0x42;
                buffer[1] = 0x5c;
                PS3.SetMemory(0x1CAF0d8, buffer);
                buffer = new byte[3];
                buffer[0] = 0x41;
                buffer[1] = 0x20;
                PS3.SetMemory(0x1CAF138, buffer);
                buffer = new byte[3];
                buffer[0] = 0x41;
                buffer[1] = 0x20;
                PS3.SetMemory(0x1CAF198, buffer);
                checkButton30.Text = "Melee Range - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Melee Range - ^1OFF");
            }
        }

        private void checkButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton31.Checked)
            {
                if (rpcConnected == true)
                {
                    RPC.Cbuf_AddText("player_meleeRange 0");
                    RPC.Cbuf_AddText("player_meleeHeight 0");
                    RPC.Cbuf_AddText("player_meleeWidth 0");
                    checkButton31.Text = "No Melee - ON";
                    RPC.iPrintln(0, "No Melee - ^2ON");
                }
                else
                {
                    XtraMessageBox.Show("You have to enable RPC to use this function.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (rpcConnected == true)
                {
                    RPC.Cbuf_AddText("reset player_meleeRange");
                    RPC.Cbuf_AddText("reset player_meleeHeight");
                    RPC.Cbuf_AddText("reset player_meleeWidth");
                    checkButton31.Text = "No Melee - OFF";
                    RPC.iPrintln(0, "No Melee - ^1OFF");
                }
            }
        }

        private void checkEdit38_CheckedChanged(object sender, EventArgs e)
        {
            if (scorelimitalert == false)
            {
                XtraMessageBox.Show("You have to restart the game or wait the next game for this function to take effect.", "Score Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                scorelimitalert = true;
            }
        }

        private void spinEdit37_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit37_CheckedChanged(object sender, EventArgs e)
        {
            if (scoreperkillalert == false)
            {
                XtraMessageBox.Show("You have to restart the game or wait the next game for this function to take effect.", "Score per Kill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                scoreperkillalert = true;
            }
        }

        private void checkEdit40_CheckedChanged(object sender, EventArgs e)
        {
            if (roundalert == false)
            {
                XtraMessageBox.Show("You have to restart the game or wait the next game for this function to take effect.", "Rounds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                roundalert = true;
            }
        }

        private void simpleButton62_Click(object sender, EventArgs e)
        {
            BO2.MyFunc.Vis(-1, BO2.MyFunc.strVisions[comboBoxEdit8.SelectedIndex]);
        }

        private void checkEdit41_CheckedChanged(object sender, EventArgs e)
        {
            if (livealert == false)
            {
                XtraMessageBox.Show("You have to restart the game or wait the next Round for this function to take effect.", "Live", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                livealert = true;
            }
        }

        private void checkButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton32.Checked)
            {
                if (rapidfire == false)
                {
                    XtraMessageBox.Show("You have to set All Perks to use Rapid Fire.", "Rapid Fire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rapidfire = true;
                }
                byte[] buffer = new byte[] { 0, 2, 0, 0, 0, 0, 0x30, 0x23, 0xD7, 10, 0xD0, 1, 0x7D, 0x60 };
                PS3.SetMemory(0x1CB2AF2, buffer);
                checkButton32.Text = "Rapid Fire - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Rapid Fire - ^2ON");
            }
            else
            {
                byte[] buffer = new byte[] { 0, 2, 0, 0, 0, 0, 0x3f, 0x40, 0, 0, 0xd0, 1, 0x7d, 0x60 };
                PS3.SetMemory(0x1CB2AF2, buffer);
                checkButton32.Text = "Rapid Fire - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Rapid Fire - ^1OFF");
            }
        }
        
        private void checkButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton33.Checked)
            {
                PS3.SetMemory(0x1CA4ED8, new byte[] { 0x47 });
                checkButton33.Text = "Knockback - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Knockback - ^2ON");
            }
            else
            {
                PS3.SetMemory(0x1CA4ED8, new byte[] { 0x44 });
                checkButton33.Text = "Knockback - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Knockback - ^1OFF");
            }
        }

        private void simpleButton63_Click(object sender, EventArgs e)
        {
            listBoxControl2.Items.Clear();
            comboBoxEdit12.Properties.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                listBoxControl2.Items.Add(GetName(i));
                comboBoxEdit12.Properties.Items.Add(GetName(i));
                comboBoxEdit12.SelectedIndex = 0;
            }
        }

        private void checkButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton38.Checked)
            {
                BO2.MyFunc.SkateModStart(listBoxControl2.SelectedIndex, true);
                checkButton38.Text = "Skate Mod - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Skate Mod - ^2ON");
            }
            else
            {
                BO2.MyFunc.SkateModStart(listBoxControl2.SelectedIndex, false);
                checkButton38.Text = "Skate Mod - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Skate Mod - ^1OFF");
            }
        }

        private void checkButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton34.Checked)
            {
                BO2.MyFunc.AntiQuitStart(listBoxControl2.SelectedIndex, true);
                checkButton34.Text = "Anti Quit - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Anti Quit - ^2ON");
            }
            else
            {
                BO2.MyFunc.AntiQuitStart(listBoxControl2.SelectedIndex, false);
                checkButton34.Text = "Anti Quit - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Anti Quit - ^1OFF");
            }
        }

        private void checkButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton35.Checked)
            {
                PS3.SetMemory(0x1780F28 + 0x54F7 + (uint)(0x5808 * listBoxControl2.SelectedIndex), new byte[] { 0x40 });
                checkButton35.Text = "Weapon Fucked - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Weapon Fucked - ^2ON");
            }
            else
            {
                PS3.SetMemory(0x1780F28 + 0x54F7 + (uint)(0x5808 * listBoxControl2.SelectedIndex), new byte[] { 0xE9 });
                checkButton35.Text = "Weapon Fucked - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Weapon Fucked - ^1OFF");
            }
        }

        private void checkButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton36.Checked)
            {
                BO2.MyFunc.HeartQuakeStart(listBoxControl2.SelectedIndex, true);
                checkButton36.Text = "Heartquake - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Heartquake - ^2ON");
            }
            else
            {
                BO2.MyFunc.HeartQuakeStart(listBoxControl2.SelectedIndex, false);
                checkButton36.Text = "Heartquake - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Heartquake - ^1OFF");
            }
        }

        private void checkButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton37.Checked)
            {
                PS3.SetMemory(0x1780F28 + 0x1B + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 0xe4 });
                checkButton37.Text = "EMP - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "EMP - ^2ON");
            }
            else
            {
                PS3.SetMemory(0x1780F28 + 0x1B + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 4 });
                checkButton37.Text = "EMP - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "EMP - ^1OFF");
            }
            
        }

        private void simpleButton64_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x1780f28 + 0x42f + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 1 });
            PS3.SetMemory(0x1780f28 + 0x431 + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 1 });
            PS3.SetMemory(0x1780f28 + 0x434 + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 1 });
            if (rpcConnected)
                RPC.iPrintln(0, "^2Full Scorestreak");
        }

        private void simpleButton65_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.SpawnClone(listBoxControl2.SelectedIndex);
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton72_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.iPrintln(listBoxControl3.SelectedIndex, "^1Freeeezzzeee :D");
                Thread.Sleep(3000);
                RPC.SV_GameSendServerCommand(listBoxControl3.SelectedIndex, "^ 6 90 ");
                RPC.iPrintln(0, "^2Noob Freezed");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton66_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.smethod_6(listBoxControl2.SelectedIndex, BO2.MyFunc.strModels[comboBoxEdit9.SelectedIndex]);
                RPC.iPrintln(0, "^2Model Changed");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton67_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteByte(0x1780F28 + 0x5423 + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), BO2.MyFunc.byte_Status[comboBoxEdit10.SelectedIndex]);
        }

        private void simpleButton70_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit11.SelectedIndex == 0)
            {
                PS3.SetMemory((0x1780f28 + 40 + 4) + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 0x47, 0xff, 0xff, 0xff });
                RPC.iPrintln(0, "^2Teleported Away");
            }
            else if (comboBoxEdit11.SelectedIndex == 1)
            {
                BO2.MyFunc.TeleportClient2Client(0, listBoxControl2.SelectedIndex);
                RPC.iPrintln(0, "^2Teleported");
            }
            else if (comboBoxEdit11.SelectedIndex == 2)
            {
                BO2.MyFunc.TeleportClient2Client(listBoxControl2.SelectedIndex, 0);
                RPC.iPrintln(0, "^2Teleported");
            }
            else if (comboBoxEdit11.SelectedIndex == 3)
            {
                for (int i = 0; i < 12; i++)
                {
                    BO2.MyFunc.TeleportClient2Client(listBoxControl2.SelectedIndex, i);
                }
                RPC.iPrintln(0, "^2Teleported");
            }
        }

        private void simpleButton73_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.smethod_7(listBoxControl2.SelectedIndex, memoEdit1.Text);
                RPC.iPrintln(0, "^2Noob Kicked");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkButton39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton39.Checked)
            {
                timer11.Interval = 1000;
                timer11.Start();
                checkButton39.Text = "T-Bag - ON";
            }
            else
            {
                timer11.Stop();
                checkButton39.Text = "T-Bag - OFF";
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            PS3.SetMemory(0x1781027 + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 2 });
            Thread.Sleep(100);
            PS3.SetMemory(0x1781027 + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 6 });
            Thread.Sleep(100);
            PS3.SetMemory(0x1781027 + ((uint)(0x5808 * listBoxControl2.SelectedIndex)), new byte[] { 10 });
        }

        private void simpleButton74_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                RPC.smethod_11(comboBoxEdit12.SelectedIndex, listBoxControl2.SelectedIndex, 0x12, 0);
                RPC.iPrintln(0, "^2Noob Dead");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkButton40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton40.Checked)
            {
                RPC.SV_GameSendServerCommand(listBoxControl2.SelectedIndex, "d 100000000 20");
                RPC.iPrintln(0, "Blur - ^2ON");
                checkButton40.Text = "Blur - ON";
            }
            else
            {
                RPC.SV_GameSendServerCommand(listBoxControl2.SelectedIndex, "d 0 0");
                RPC.iPrintln(0, "Blur - ^1OFF");
                checkButton40.Text = "Blur - OFF";
            }
        }

        private void simpleButton76_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                BO2.MyFunc.AttachEntity(listBoxControl2.SelectedIndex, comboBoxEdit13.Text, comboBoxEdit14.Text);
                RPC.iPrintln(0, "^2Entity Attached");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton77_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                XtraMessageBox.Show("Sorry, an error occured. Function not available..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkEdit42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit42.Checked)
            {
                checkEdit43.Checked = false;
                checkEdit44.Checked = false;
                checkEdit45.Checked = false;
                BO2.MyFunc.clockNameColor = "^1";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void checkEdit43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit43.Checked)
            {
                checkEdit42.Checked = false;
                checkEdit44.Checked = false;
                checkEdit45.Checked = false;
                BO2.MyFunc.clockNameColor = "^4";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void checkEdit45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit45.Checked)
            {
                checkEdit43.Checked = false;
                checkEdit44.Checked = false;
                checkEdit42.Checked = false;
                BO2.MyFunc.clockNameColor = "^5";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void checkEdit44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit44.Checked)
            {
                checkEdit43.Checked = false;
                checkEdit42.Checked = false;
                checkEdit45.Checked = false;
                BO2.MyFunc.clockNameColor = "^2";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void simpleButton78_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Set Colors like this one: ^1LezZo ^2Extreme ^4Tool\n\nColor Codes:\nBlack - ^0\nRed - ^1\nGreen - ^2\nYellow - ^3\nDark Blue - ^4\nLight Blue - ^5\nPink - ^6\nWhite - ^7\nBrown - ^8", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton42.Checked)
            {
                if (AimbotAlert == false)
                {
                    if (XtraMessageBox.Show("Aimbot requires a very fast Connection between PC and PS3! \nTMAPI is preferred !! With CCAPI you should not use Aimbot. \n\nDo yu want to enable Unfair Aimbot??", "Aimbot Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        AimbotAlert = true;
                        timer4.Start();
                        checkButton42.Text = "Unfair Aimbot - ON";
                        RPC.iPrintln(0, "Unfair Aimbot ^2ON");
                    }
                }
            }
            else
            {
                timer4.Stop();
                checkButton42.Text = "Unfair Aimbot - OFF";
                RPC.iPrintln(0, "Unfair Aimbot ^1OFF");
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (BitConverter.ToUInt32(PS3.Extension.ReadBytes((uint)(0x17863A4 + (0x5808 * listBoxControl2.SelectedIndex)), 4), 0) == 0x80001000)
            {
                BO2.Aimbot.smethod_8(listBoxControl2.SelectedIndex, BO2.Aimbot.smethod_3(listBoxControl2.SelectedIndex, true));
                if (BitConverter.ToUInt32(PS3.Extension.ReadBytes((uint)(0x17863A4 + (0x5808 * listBoxControl2.SelectedIndex)), 4), 0) == 0x80001080)
                {
                    RPC.smethod_11(listBoxControl2.SelectedIndex, BO2.Aimbot.smethod_3(listBoxControl2.SelectedIndex, true), 0, BO2.Aimbot.smethod_69(listBoxControl2.SelectedIndex));
                }
            }
        }

        private void simpleButton79_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 15 };
            PS3.SetMemory((uint)(0x1786497 + (listBoxControl2.SelectedIndex * 0x5808)), buffer);
        }

        public static uint partyup = 0;
        public static bool bool_300 = true;

        public static string returnCity(string IP)
        {
            WebClient WC = new WebClient();
            return WC.DownloadString("http://freegeoip.net/xml/" + IP).Replace("<City>", ";").Split(new char[] { ';' })[1].Replace("</City>", ";").Split(new char[] { ';' })[0];
        }

        public static string returnCountry(string IP)
        {
            WebClient WC = new WebClient();
            return WC.DownloadString("http://freegeoip.net/xml/" + IP).Replace("<CountryName>", ";").Split(new char[] { ';' })[1].Replace("</CountryName>", ";").Split(new char[] { ';' })[0];
        }

        public static string returnRegionName(string IP)
        {
            WebClient WC = new WebClient();
            return WC.DownloadString("http://freegeoip.net/xml/" + IP).Replace("<RegionName>", ";").Split(new char[] { ';' })[1].Replace("</RegionName>", ";").Split(new char[] { ';' })[0];
        }

        public static string returnZipCode(string IP)
        {
            WebClient WC = new WebClient();
            return WC.DownloadString("http://freegeoip.net/xml/" + IP).Replace("<ZipCode>", ";").Split(new char[] { ';' })[1].Replace("</ZipCode>", ";").Split(new char[] { ';' })[0];
        }

        private void GrabIPAddresses(uint[] offs)
        {
            try
            {
                uint num = 0u;
                while ((ulong)num < (ulong)((long)length1))
                {
                    PlayerName = PS3.Extension.ReadString(offs[0] + num * codInt);
                    PlayerIP = convertIP(PS3.Extension.ReadBytes(offs[1] + num * codInt, 4));
                    if (nameValidation.IsMatch(PlayerName) && (PlayerName.Length > 3))
                    {
                        dataGridView1.Rows[(int)num].Cells[0].Value = PlayerName;
                    }
                    if (PlayerIP != "0.0.0.0" && PlayerIP != "255.255.255.255")
                    {
                        dataGridView1.Rows[(int)num].Cells[1].Value = PlayerIP;
                    }
                    Application.DoEvents();
                    string str2 = "";
                    string str3 = "";
                    if (PlayerIP != "0.0.0.0" && PlayerIP != "255.255.255.255" && PlayerIP != "35.7.73.34")
                    {
                        str2 = returnCountry(PlayerIP);
                    }
                    if (PlayerIP != "0.0.0.0" && PlayerIP != "255.255.255.255" && PlayerIP != "35.7.73.34")
                    {
                        str3 = returnCity(PlayerIP);
                    }
                    dataGridView1.Rows[(int)num].Cells[2].Value = str2;
                    dataGridView1.Rows[(int)num].Cells[3].Value = str3;

                    num += 1u;
                }
                ClearDataGrid(dataGridView1);
                dataGridView1.RowCount = 12;
            }
            catch
            {
                labelControl180.Text = "An error occured.. ..";
                Thread.Sleep(1000);
                labelControl180.Visible = false;
            }
        }

        private void ClearDataGrid(DataGridView dataGview)
        {
            for (int i = 0; i < dataGview.Rows.Count; i++)
            {
                bool flag = true;
                for (int j = 0; j < dataGview.Columns.Count; j++)
                {
                    object obj2 = dataGview.Rows[i].Cells[j].Value;
                    if ((obj2 != null) && (obj2.ToString().Length > 0))
                    {
                        goto Label_0056;
                    }
                }
                goto Label_0058;
            Label_0056:
                flag = false;
            Label_0058:
                if (flag)
                {
                    dataGview.Rows.RemoveAt(i--);
                }
            }
            labelControl180.Text = "Done!! IPs Grabbed :D";
            Thread.Sleep(1200);
            labelControl180.Visible = false;
        }

        private void LaunchGrabber()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 12;
            if (PS3.Extension.ReadBool(inparty))
            {
                GrabIPAddresses(partyArray);
            }
            else
            {
                GrabIPAddresses(codArray);
            }
            labelControl180.Visible = true;
        }

        private void GrabClients(uint[] offs)
        {
            try
            {
                uint num = 0u;
                while ((ulong)num < (ulong)((long)length1))
                {
                    PlayerName = PS3.Extension.ReadString(offs[0] + num * codInt);
                    if (nameValidation.IsMatch(PlayerName) && (PlayerName.Length > 3))
                    {
                        listBoxControl3.Items.Insert((int)num, PlayerName);
                    }
                    num += 1u;
                }
            }
            catch
            {
                
            }
        }

        private void LaunchGetClients()
        {
            listBoxControl3.Items.Clear();
            if (PS3.Extension.ReadBool(inparty))
            {
                GrabClients(partyArray);
            }
            else
            {
                GrabClients(codArray);
            }
        }

        private void simpleButton82_Click(object sender, EventArgs e)
        {
            LaunchGrabber();
        }

        private void simpleButton83_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void checkEdit85_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit85.Checked)
            {
                labelControl180.Visible = true;
                if (trackBarControl2.Value == 1)
                {
                    timer3.Interval = 20000;
                    timer3.Start();
                }
                else if (trackBarControl2.Value == 2)
                {
                    timer3.Interval = 30000;
                    timer3.Start();
                }
                else if (trackBarControl2.Value == 3)
                {
                    timer3.Interval = 40000;
                    timer3.Start();
                }
                else if (trackBarControl2.Value == 4)
                {
                    timer3.Interval = 50000;
                    timer3.Start();
                }
                else if (trackBarControl2.Value == 5)
                {
                    timer3.Interval = 60000;
                    timer3.Start();
                }
            }
            else
            {
                labelControl180.Visible = false;
                timer3.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            LaunchGrabber();
        }

        private static string convertIP(byte[] byte_0)
        {
            return string.Format("{0}.{1}.{2}.{3}", new object[]
            {
                byte_0[0],
                byte_0[1],
                byte_0[2],
                byte_0[3]
            });
        }

        private void simpleButton85_Click(object sender, EventArgs e)
        {
            for (uint i = 0; i < 18; i++)
            {
                BO2.MyFunc.IPHider(i);
            }
        }

        private void simpleButton86_Click(object sender, EventArgs e)
        {
            LaunchGetClients();
        }

        private void checkButton41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton41.Checked)
            {
                PS3.SetMemory(0xCD5A1B, new byte[] { 0xD0 });
                PS3.SetMemory(0x67B824, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                XtraMessageBox.Show("Anti Freeze + Anti Kick Enabled !! You are God now :D :D", "Protections", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkButton41.Text = "Anti Freeze / Kick - ON";
            }
            else
            {
                PS3.SetMemory(0xCD5A1B, new byte[] { 6 });
                PS3.SetMemory(0x67B824, new byte[] { 0x90, 0x9A, 0x00, 0x00 });
                XtraMessageBox.Show("Anti Freeze + Anti Kick Disabled. You are an human again :)", "Protections", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkButton41.Text = "Anti Freeze / Kick - OFF";
            }
        }

        private void simpleButton91_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("First of all, do not abuse of these functions. I'm watching you, remember this ;)\n\nEnabling Antifreeze, some freeze functions may not work properly.\n\nFreeze Leave - All players in the Lobby will be frozen, and anyone join will be frozen too.\n\nFreeze All - All players will be frozen, even you! Enabling Antifreeze you will not freeze.\n\nFreeze Shoot - Works if you are the Host. Anyone you shoot at, will froze.\n\nFreeze Host in Game - You have to enable it before enter in a game. It will freeze the Host.", "Freeze Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton87_Click(object sender, EventArgs e)
        {
            BO2.MyFunc.ChangeName_2("^I™™™");
            Thread.Sleep(299);
            BO2.MyFunc.ChangeName(labelControl4.Text);
        }

        private void simpleButton88_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x026C0658, new byte[] { 0x5E, 0x49, 0x99, 0x99, 0x99 });
            Thread.Sleep(29);
            BO2.MyFunc.ChangeName(labelControl4.Text);
        }

        private void simpleButton89_Click(object sender, EventArgs e)
        {
            BO2.MyFunc.ChangeName_2("^B™™™"); // or  ChangeName("^B");
            Thread.Sleep(299);
            BO2.MyFunc.ChangeName(labelControl4.Text);
        }

        private void simpleButton90_Click(object sender, EventArgs e)
        {
            BO2.MyFunc.ChangeName_2("^H");
            Thread.Sleep(299);
            BO2.MyFunc.ChangeName(labelControl4.Text);
        }

        private void checkButton43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton43.Checked)
            {
                PS3.Extension.WriteString(0x2708238, "^H");
                checkButton43.Text = "Freeze Shoot - ON";
            }
            else
            {
                PS3.Extension.WriteString(0x2708238, "");
                checkButton43.Text = "Freeze Shoot - OFF";
            }
        }

        private void checkButton44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton44.Checked)
            {
                PS3.Extension.WriteString(0x2708238, "^I");
                checkButton44.Text = "Freeze Host in Game - ON";
            }
            else
            {
                PS3.Extension.WriteString(0x2708238, labelControl4.Text);
                checkButton44.Text = "Freeze Host in Game - OFF";
            }
        }

        private void simpleButton92_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit16.SelectedIndex == 0)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, };
                PS3.SetMemory(0x026FCA8F, buffer);
            }
            else if (comboBoxEdit16.SelectedIndex == 1)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x26FCA8E, buffer);
            }
            else if (comboBoxEdit16.SelectedIndex == 2)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x26FCA8E, buffer);
            }
            else if (comboBoxEdit16.SelectedIndex == 3)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x26FCA8E, buffer);
            }
            else if (comboBoxEdit16.SelectedIndex == 4)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x26FCA8E, buffer);
            }
            else if (comboBoxEdit16.SelectedIndex == 5)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(0x026FCA8F, buffer);
            }
        }

        private void simpleButton93_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit16.SelectedIndex == 0)
            {
                byte[] buffer = new byte[] { 0x0F };
                PS3.SetMemory(0x026FC896, buffer);
                byte[] buffer1 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(0x026FCA87, buffer1);
            }
            else if (comboBoxEdit16.SelectedIndex == 1)
            {
                byte[] buffer2 = new byte[] { 0x0F };
                PS3.SetMemory(0x026FC896, buffer2);
                byte[] buffer21 = new byte[] { 0x02, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(0x026FCA87, buffer21);
            }
            else if (comboBoxEdit16.SelectedIndex == 2)
            {
                byte[] buffer = new byte[] { 0x0F };
                PS3.SetMemory(0x026FC896, buffer);
                byte[] buffer1 = new byte[] { 0x0A, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(0x026FCA87, buffer1);
            }
            else if (comboBoxEdit16.SelectedIndex == 3)
            {
                byte[] buffer = new byte[] { 0x0F };
                PS3.SetMemory(0x026FC896, buffer);
                byte[] buffer1 = new byte[] { 0x15, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(0x026FCA87, buffer1);
            }
            else if (comboBoxEdit16.SelectedIndex == 4)
            {
                byte[] buffer = new byte[] { 0x0F };
                PS3.SetMemory(0x026FC896, buffer);
                byte[] buffer1 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory(0x026FCA87, buffer1);
            }
        }

        private void simpleButton84_Click(object sender, EventArgs e)
        {
            if (checkEdit46.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit53.Value.ToString()));
                PS3.SetMemory(0x26FC90C, buffer);
            }
            else if (checkEdit47.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit52.Value.ToString()));
                PS3.SetMemory(0x26FC910, buffer);
            }
            else if (checkEdit48.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit51.Value.ToString()));
                PS3.SetMemory(0x26FC948, buffer);
            }
            else if (checkEdit49.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit50.Value.ToString()));
                PS3.SetMemory(0x26FC884, buffer);
            }
            else if (checkEdit50.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit49.Value.ToString()));
                PS3.SetMemory(0x26FC914, buffer);
            }
            else if (checkEdit51.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit42.Value.ToString()));
                PS3.SetMemory(0x26FC934, buffer);
            }
            else if (checkEdit52.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit43.Value.ToString()));
                PS3.SetMemory(0x26FC918, buffer);
            }
            else if (checkEdit53.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit44.Value.ToString()));
                PS3.SetMemory(0x26FC940, buffer);
            }
            else if (checkEdit54.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit45.Value.ToString()));
                PS3.SetMemory(0x26FC944, buffer);
            }
            else if (checkEdit55.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit46.Value.ToString()));
                PS3.SetMemory(0x26FC938, buffer);
            }
            else if (checkEdit56.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit47.Value.ToString()));
                PS3.SetMemory(0x26FC91C, buffer);
            }
            else if (checkEdit57.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit48.Value.ToString()));
                PS3.SetMemory(0x26FC93C, buffer);
            }
            checkEdit46.Checked = false;
            checkEdit47.Checked = false;
            checkEdit48.Checked = false;
            checkEdit49.Checked = false;
            checkEdit50.Checked = false;
            checkEdit51.Checked = false;
            checkEdit52.Checked = false;
            checkEdit53.Checked = false;
            checkEdit54.Checked = false;
            checkEdit55.Checked = false;
            checkEdit56.Checked = false;
            checkEdit57.Checked = false;
        }

        private void simpleButton98_Click(object sender, EventArgs e)
        {
            byte[] buffer99 = new byte[] { 0x0F };
            PS3.SetMemory(0x026FC896, buffer99);
            byte[] buffer98 = new byte[] { 0x0A, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            PS3.SetMemory(0x026FCA87, buffer98);

            byte[] buffer97 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            PS3.SetMemory(0x26FCA8E, buffer97);

            byte[] buffer = BitConverter.GetBytes(4019);
            PS3.SetMemory(0x26FC90C, buffer);

            byte[] buffer2 = BitConverter.GetBytes(59);
            PS3.SetMemory(0x26FC910, buffer2);

            byte[] buffer3 = BitConverter.GetBytes(17);
            PS3.SetMemory(0x26FC948, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(399);
            PS3.SetMemory(0x26FC884, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(198);
            PS3.SetMemory(0x26FC914, buffer5);

            byte[] buffer6 = BitConverter.GetBytes(11);
            PS3.SetMemory(0x26FC934, buffer6);

            byte[] buffer7 = BitConverter.GetBytes(22);
            PS3.SetMemory(0x26FC918, buffer7);

            byte[] buffer8 = BitConverter.GetBytes(28735);
            PS3.SetMemory(0x26FC940, buffer8);

            byte[] buffer9 = BitConverter.GetBytes(20661);
            PS3.SetMemory(0x26FC944, buffer9);

            byte[] buffer11 = BitConverter.GetBytes(39);
            PS3.SetMemory(0x26FC938, buffer11);

            byte[] buffer12 = BitConverter.GetBytes(290);
            PS3.SetMemory(0x26FC91C, buffer12);

            byte[] buffer13 = BitConverter.GetBytes(290);
            PS3.SetMemory(0x26FC93C, buffer13);
        }

        private void simpleButton99_Click(object sender, EventArgs e)
        {
            byte[] buffer99 = new byte[] { 0x0F };
            PS3.SetMemory(0x026FC896, buffer99);
            byte[] buffer98 = new byte[] { 0x15, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            PS3.SetMemory(0x026FCA87, buffer98);

            byte[] buffer97 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            PS3.SetMemory(0x26FCA8E, buffer97);

            byte[] buffer = BitConverter.GetBytes(40112);
            PS3.SetMemory(0x26FC90C, buffer);

            byte[] buffer2 = BitConverter.GetBytes(278);
            PS3.SetMemory(0x26FC910, buffer2);

            byte[] buffer3 = BitConverter.GetBytes(81);
            PS3.SetMemory(0x26FC948, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(7962);
            PS3.SetMemory(0x26FC884, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(377);
            PS3.SetMemory(0x26FC914, buffer5);

            byte[] buffer6 = BitConverter.GetBytes(1047);
            PS3.SetMemory(0x26FC934, buffer6);

            byte[] buffer7 = BitConverter.GetBytes(190);
            PS3.SetMemory(0x26FC918, buffer7);

            byte[] buffer8 = BitConverter.GetBytes(300319);
            PS3.SetMemory(0x26FC940, buffer8);

            byte[] buffer9 = BitConverter.GetBytes(269628);
            PS3.SetMemory(0x26FC944, buffer9);

            byte[] buffer11 = BitConverter.GetBytes(300);
            PS3.SetMemory(0x26FC938, buffer11);

            byte[] buffer12 = BitConverter.GetBytes(6011);
            PS3.SetMemory(0x26FC91C, buffer12);

            byte[] buffer13 = BitConverter.GetBytes(3590);
            PS3.SetMemory(0x26FC93C, buffer13);
        }

        private void simpleButton101_Click(object sender, EventArgs e)
        {
            byte[] buffer99 = new byte[] { 0x0F };
            PS3.SetMemory(0x026FC896, buffer99);
            byte[] buffer98 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            PS3.SetMemory(0x026FCA87, buffer98);

            byte[] buffer97 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            PS3.SetMemory(0x026FCA8F, buffer97);

            byte[] buffer = BitConverter.GetBytes(490805);
            PS3.SetMemory(0x26FC90C, buffer);

            byte[] buffer2 = BitConverter.GetBytes(391);
            PS3.SetMemory(0x26FC910, buffer2);

            byte[] buffer3 = BitConverter.GetBytes(81);
            PS3.SetMemory(0x26FC948, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(300960);
            PS3.SetMemory(0x26FC884, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(4179);
            PS3.SetMemory(0x26FC914, buffer5);

            byte[] buffer6 = BitConverter.GetBytes(3001);
            PS3.SetMemory(0x26FC934, buffer6);

            byte[] buffer7 = BitConverter.GetBytes(2247);
            PS3.SetMemory(0x26FC918, buffer7);

            byte[] buffer8 = BitConverter.GetBytes(6308312);
            PS3.SetMemory(0x26FC940, buffer8);

            byte[] buffer9 = BitConverter.GetBytes(4969628);
            PS3.SetMemory(0x26FC944, buffer9);

            byte[] buffer11 = BitConverter.GetBytes(2882);
            PS3.SetMemory(0x26FC938, buffer11);

            byte[] buffer12 = BitConverter.GetBytes(78015);
            PS3.SetMemory(0x26FC91C, buffer12);

            byte[] buffer13 = BitConverter.GetBytes(59289);
            PS3.SetMemory(0x26FC93C, buffer13);
        }

        private void simpleButton102_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(textEdit27.Text);
            Array.Resize(ref buffer, buffer.Length + 1);
            PS3.SetMemory(0x026C0658, buffer);
            PS3.SetMemory(0x26C067F, buffer);
        }

        private void simpleButton103_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(labelControl4.Text);
            Array.Resize(ref buffer, buffer.Length + 1);
            PS3.SetMemory(0x026C0658, buffer);
            PS3.SetMemory(0x26C067F, buffer);
        }

        public static void ZmFlashNameStart(bool toggle)
        {
            if (threadStart_3 == null)
            {
                threadStart_3 = new ThreadStart(FlashNameZmFunc);
            }
            thread_3 = new Thread(threadStart_3);
            if (toggle == true)
            {
                bool_999 = true;
                thread_3.Start();
            }
            else
            {
                bool_999 = false;
                thread_3.Abort();
            }
        }

        private static void FlashNameZmFunc()
        {
            while (bool_999)
            {
                int num = new Random().Next(0, 7);
                byte[] buffer = Encoding.ASCII.GetBytes("^" + num + tx27);
                Array.Resize<byte>(ref buffer, buffer.Length + 1);
                PS3.SetMemory(0x026C0658, buffer);
                PS3.SetMemory(0x026c067f, buffer);
            }
        }

        private void checkEdit58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit58.Checked)
            {
                tx27 = textEdit27.Text;
                ZmFlashNameStart(true);
            }
            else
            {
                ZmFlashNameStart(false);
            }
        }

        private void simpleButton104_Click(object sender, EventArgs e)
        {
            string nm = PS3.Extension.ReadString(0x026C0658);
            string clan = textEdit28.Text;
            if (nm != "")
            {
                byte[] buffer = Encoding.ASCII.GetBytes("[" + clan + "]" + nm);
                Array.Resize(ref buffer, buffer.Length + 1);
                PS3.SetMemory(0x026C0658, buffer);
                PS3.SetMemory(0x26C067F, buffer);
            }
            else
            {
                byte[] buffer = Encoding.ASCII.GetBytes("[" + clan + "]" + textEdit27.Text);
                Array.Resize(ref buffer, buffer.Length + 1);
                PS3.SetMemory(0x026C0658, buffer);
                PS3.SetMemory(0x26C067F, buffer);
            }
        }

        private void simpleButton106_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Set Colors like this one: ^1LezZo ^2Extreme ^4Tool\n\nColor Codes:\nBlack - ^0\nRed - ^1\nGreen - ^2\nYellow - ^3\nDark Blue - ^4\nLight Blue - ^5\nPink - ^6\nWhite - ^7\nBrown - ^8", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkEdit59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit34.Checked)
            {
                tx29 = textEdit29.Text;
                tx30 = textEdit30.Text;
                tx31 = textEdit31.Text;
                tx33 = textEdit33.Text;
                tx35 = textEdit35.Text;
                tx36 = textEdit36.Text;
                tx34 = textEdit34.Text;
                tx32 = textEdit32.Text;
                stopWatch.Start();
                ZmWatchRestStart(true);
                ZmSkipperStart(true);
            }
            else
            {
                stopWatch.Reset();
                stopWatch.Stop();
                ZmWatchRestStart(false);
                ZmSkipperStart(false);
            }
        }

        private void checkButton45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton45.Checked)
            {
                BO2.MyFunc.ClockNameStart(true);
                checkButton45.Text = "Set Clock Name - ON";
            }
            else
            {
                BO2.MyFunc.ClockNameStart(false);
                checkButton45.Text = "Set Clock Name - OFF";
            }
        }

        private void checkEdit63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit63.Checked)
            {
                checkEdit62.Checked = false;
                checkEdit61.Checked = false;
                checkEdit60.Checked = false;
                BO2.MyFunc.clockNameColor = "^1";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void checkEdit62_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit62.Checked)
            {
                checkEdit63.Checked = false;
                checkEdit61.Checked = false;
                checkEdit60.Checked = false;
                BO2.MyFunc.clockNameColor = "^4";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void checkEdit60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit60.Checked)
            {
                checkEdit62.Checked = false;
                checkEdit61.Checked = false;
                checkEdit63.Checked = false;
                BO2.MyFunc.clockNameColor = "^5";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void checkEdit61_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit61.Checked)
            {
                checkEdit62.Checked = false;
                checkEdit63.Checked = false;
                checkEdit60.Checked = false;
                BO2.MyFunc.clockNameColor = "^2";
            }
            else
            {
                BO2.MyFunc.clockNameColor = "";
            }
        }

        private void checkEdit64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit64.Checked)
            {
                byte[] buffer2 = new byte[] { 0x41, 0x82, 0x08, 0xF0 };
                PS3.SetMemory(0x37FEC, buffer2);
                byte[] buffer3 = Encoding.ASCII.GetBytes("                   ");
                PS3.SetMemory(0x8E3290, buffer3);

                byte[] buffer4 = Encoding.ASCII.GetBytes("");
                PS3.SetMemory(0x8E3290, buffer4);

                byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x37FEC, buffer);
                byte[] buffer1 = Encoding.ASCII.GetBytes(textEdit37.Text);
                PS3.SetMemory(0x8E3290, buffer1);
            }
            else
            {
                byte[] buffer = new byte[] { 0x41, 0x82, 0x08, 0xF0 };
                PS3.SetMemory(0x37FEC, buffer);
                byte[] buffer1 = Encoding.ASCII.GetBytes("                   ");
                PS3.SetMemory(0x8E3290, buffer1);
            }
        }

        private void simpleButton107_Click(object sender, EventArgs e)
        {
            listBoxControl4.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                listBoxControl4.Items.Add(GetName(i));
            }
        }

        private void checkButton46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton46.Checked)
            {
                byte[] buffer = new byte[] { 0x7F, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1786404 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton46.Text = "God Mode - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "God Mode ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1786404 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton46.Text = "God Mode - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "God Mode ^1OFF");
                }
            }
        }

        private void checkButton47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton47.Checked)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0x00, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1781355 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                byte[] buffer1 = new byte[] { 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1781319 + (listBoxControl4.SelectedIndex * 0x5808)), buffer1);
                byte[] buffer2 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00 };
                PS3.SetMemory((uint)(0x1781339 + (listBoxControl4.SelectedIndex * 0x5808)), buffer2);
                byte[] buffer3 = new byte[] { 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x178135D + (listBoxControl4.SelectedIndex * 0x5808)), buffer3);
                byte[] buffer4 = new byte[] { 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1781321 + (listBoxControl4.SelectedIndex * 0x5808)), buffer4);
                checkButton47.Text = "Unlimited Ammo - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Unlimited Ammo ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1781355 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                byte[] buffer1 = new byte[] { 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1781319 + (listBoxControl4.SelectedIndex * 0x5808)), buffer1);
                byte[] buffer2 = new byte[] { 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00 };
                PS3.SetMemory((uint)(0x1781339 + (listBoxControl4.SelectedIndex * 0x5808)), buffer2);
                byte[] buffer3 = new byte[] { 0x00, 0xFF, 0x00 };
                PS3.SetMemory((uint)(0x178135D + (listBoxControl4.SelectedIndex * 0x5808)), buffer3);
                byte[] buffer4 = new byte[] { 0xFF, 0x00, 0xFF };
                PS3.SetMemory((uint)(0x1781321 + (listBoxControl4.SelectedIndex * 0x5808)), buffer4);
                checkButton47.Text = "Unlimited Ammo - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Unlimited Ammo ^1OFF");
                }
            }
        }

        private void checkButton48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton48.Checked)
            {
                byte[] buffer = new byte[] { 15, 0x42, 0x40 };
                PS3.SetMemory((uint)(0x1786501 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton48.Text = "Max Points - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Max Points ^2ON");
                }
            }
            else
            {
                byte[] buffer2 = new byte[3];
                buffer2[1] = 1;
                buffer2[2] = 0xf4;
                byte[] buffer = buffer2;
                PS3.SetMemory((uint)(0x1786501 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton48.Text = "Max Points - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Max Points ^1OFF");
                }
            }
        }

        private void checkButton53_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton53.Checked)
            {
                byte[] buffer = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
                PS3.SetMemory((uint)(0x1781470 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton53.Text = "All Perks - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "All Perks ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01 };
                PS3.SetMemory((uint)(0x1781470 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton53.Text = "All Perks - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "All Perks ^1OFF");
                }
            }
        }

        private void checkButton54_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton54.Checked)
            {
                byte[] buffer = new byte[] { 0x01 };
                PS3.SetMemory((uint)(0x178634B + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton54.Text = "Invisible - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Invisible ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0x00 };
                PS3.SetMemory((uint)(0x178634B + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton54.Text = "Invisible - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Invisible ^1OFF");
                }
            }
        }

        private void checkButton49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton49.Checked)
            {
                byte[] buffer = new byte[] { 4 };
                PS3.SetMemory((uint)(0x17865BF + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton49.Text = "Freeze - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Freeze ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x17865BF + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton49.Text = "Freeze - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Freeze ^1OFF");
                }
            }
        }

        private void checkButton55_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton55.Checked)
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1786363 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton55.Text = "Lag - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Lag ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 2 };
                PS3.SetMemory((uint)(0x1786363 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton55.Text = "Lag - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Lag ^1OFF");
                }
            }
        }

        private void checkButton50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton50.Checked)
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory((uint)(0x1780fac + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton50.Text = "Third Person - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Third Person ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1780fac + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton50.Text = "Third Person - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Third Person ^1OFF");
                }
            }
        }

        private void checkButton51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton51.Checked)
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory((uint)(0x178672B + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton51.Text = "Last Stand - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Last Stand ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x178672B + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton51.Text = "Last Stand - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Last Stand ^1OFF");
                }
            }
        }

        private void checkButton52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton52.Checked)
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory((uint)(0x1780F28 + 0x57F0 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton52.Text = "Prone - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Prone ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory((uint)(0x1780F28 + 0x57F0 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton52.Text = "Prone - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Prone ^1OFF");
                }
            }
        }

        private void simpleButton108_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 70 };
            PS3.SetMemory((uint)(0x1780F58 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
            if (rpcConnected == true)
            {
                RPC.iPrintln(0, "^2Noob Dead");
            }
        }

        private void simpleButton109_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0xFF };
            PS3.SetMemory((uint)(0x178108F + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
            if (rpcConnected == true)
            {
                RPC.iPrintln(0, "^2Noob Kicked");
            }
        }

        private void checkButton56_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton56.Checked)
            {
                byte[] buffer = new byte[] { 0x40 };
                PS3.SetMemory((uint)(0x1780F28 + 0x54F0  + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton56.Text = "Speed x2 - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Speed x2 ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0x3F };
                PS3.SetMemory((uint)(0x1780F28 + 0x54F0 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton56.Text = "Speed x2 - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Speed x2 ^1OFF");
                }
            }
        }

        private void checkButton57_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton57.Checked)
            {
                byte[] buffer = new byte[] { 0x3E };
                PS3.SetMemory((uint)(0x1780F28 + 0x54F0 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton57.Text = "Slow Speed - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Slow Speed ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0x3F };
                PS3.SetMemory((uint)(0x1780F28 + 0x54F0 + (listBoxControl4.SelectedIndex * 0x5808)), buffer);
                checkButton57.Text = "Slow Speed - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Slow Speed ^1OFF");
                }
            }
        }

        private void checkButton58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton58.Checked)
            {
                BO2.MyFunc.ZmHeartQuakeStart(listBoxControl4.SelectedIndex, true);
                checkButton58.Text = "Heartquake - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Heartquake ^2ON");
                }
            }
            else
            {
                BO2.MyFunc.ZmHeartQuakeStart(listBoxControl4.SelectedIndex, false);
                checkButton58.Text = "Heartquake - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Heartquake ^1OFF");
                }
            }
        }

        private void checkButton60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton60.Checked)
            {
                BO2.MyFunc.SkateModStart(listBoxControl4.SelectedIndex, true);
                checkButton60.Text = "Skate Mode - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Skate Mode ^2ON");
                }
            }
            else
            {
                BO2.MyFunc.SkateModStart(listBoxControl4.SelectedIndex, false);
                checkButton60.Text = "Skate Mode - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Skate Mode ^1OFF");
                }
            }
        }

        private void simpleButton110_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(0x1781170 + (0x5808 * listBoxControl4.SelectedIndex)), new byte[0x188]);
            if (rpcConnected == true)
            {
                RPC.iPrintln(0, "^2Weapons Removed");
            }
        }

        private void checkButton61_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton61.Checked)
            {
                BO2.MyFunc.TBagStart(listBoxControl4.SelectedIndex, true);
                checkButton61.Text = "T-Bag - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "T-Bag ^2ON");
                }
            }
            else
            {
                BO2.MyFunc.TBagStart(listBoxControl4.SelectedIndex, false);
                checkButton61.Text = "T-Bag - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "T-Bag ^1OFF");
                }
            }
        }

        private void checkEdit65_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit65.Checked)
            {
                if (rpcConnected == true)
                {
                    BO2.MyFunc.ClientiPrintBoldStart(textEdit38.Text, true);
                }
                else
                {
                    checkEdit65.Checked = false;
                    XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BO2.MyFunc.ClientiPrintBoldStart(textEdit38.Text, false);
            }
        }

        private void simpleButton111_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteByte(0x1780F28 + 0x5423, BO2.MyFunc.byte_Status[comboBoxEdit18.SelectedIndex]);
            if (rpcConnected)
            {
                RPC.iPrintln(0, "^2Status Changed");
            }
        }

        private void simpleButton112_Click(object sender, EventArgs e)
        {
            if (rpcConnected)
            {
                RPC.smethod_6(listBoxControl4.SelectedIndex, comboBoxEdit19.Text);
                RPC.iPrintln(0, "^2Model Changed");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton113_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit21.SelectedIndex == 0)
            {
                if (BO2.MyFunc.ZombieMap() == "Tranzit")
                {
                    BO2.MyFunc.ZmTranzitWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Die Rise")
                {
                    BO2.MyFunc.ZmDieRiseWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "MOTD")
                {
                    BO2.MyFunc.ZmMOTDWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Buried")
                {
                    BO2.MyFunc.ZmBuriedWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Origins")
                {
                    BO2.MyFunc.ZmOriginsWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else
                {
                    XtraMessageBox.Show("These function works only in game. If you are already in game, you are playing in a map not supported :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit21.SelectedIndex == 1)
            {
                if (BO2.MyFunc.ZombieMap() == "Tranzit")
                {
                    BO2.MyFunc.ZmSecTranzitWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Die Rise")
                {
                    BO2.MyFunc.ZmSecDieRiseWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "MOTD")
                {
                    BO2.MyFunc.ZmSecMOTDWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Buried")
                {
                    BO2.MyFunc.ZmSecBuriedWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Origins")
                {
                    BO2.MyFunc.ZmSecOriginsWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else
                {
                    XtraMessageBox.Show("These function works only in game. If you are already in game, you are playing in a map not supported :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit21.SelectedIndex == 2)
            {
                if (BO2.MyFunc.ZombieMap() == "Tranzit")
                {
                    BO2.MyFunc.ZmEqTranzitWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Die Rise")
                {
                    BO2.MyFunc.ZmEqDieRiseWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "MOTD")
                {
                    BO2.MyFunc.ZmEqMOTDWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Buried")
                {
                    XtraMessageBox.Show("Sorry there are problem with equipment on buried. Will fix this.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (BO2.MyFunc.ZombieMap() == "Origins")
                {
                    BO2.MyFunc.ZmEqOriginsWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else
                {
                    XtraMessageBox.Show("These function works only in game. If you are already in game, you are playing in a map not supported :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxEdit21.SelectedIndex == 3)
            {
                if (BO2.MyFunc.ZombieMap() == "Tranzit")
                {
                    BO2.MyFunc.ZmR3TranzitWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Die Rise")
                {
                    BO2.MyFunc.ZmR3DieRiseWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "MOTD")
                {
                    BO2.MyFunc.ZmR3MOTDWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Buried")
                {
                    BO2.MyFunc.ZmR3BuriedWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else if (BO2.MyFunc.ZombieMap() == "Origins")
                {
                    BO2.MyFunc.ZmR3OriginsWeap(listBoxControl4.SelectedIndex, comboBoxEdit20.SelectedIndex);
                }
                else
                {
                    XtraMessageBox.Show("These function works only in game. If you are already in game, you are playing in a map not supported :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton114_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            PS3.SetMemory(0x1786497 + (uint)(0x5808 * listBoxControl1.SelectedIndex), buffer);
            if (rpcConnected)
            {
                RPC.iPrintln(0, "^2Deranked");
            }
        }

        private void simpleButton115_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x97047C, new byte[1]);
        }

        private void simpleButton116_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x1968203, new byte[] { 5 });
            PS3.SetMemory(0x1968203, new byte[] { 7 });
            PS3.SetMemory(0x1968203, new byte[] { 5 });
            PS3.SetMemory(0x1968203, new byte[] { 7 });
        }

        private void comboBoxEdit21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit21.SelectedIndex == 0)
            {
                comboBoxEdit20.Properties.Items.Clear();
                comboBoxEdit20.Properties.Items.AddRange(BO2.MyFunc.zmWeapons());
                comboBoxEdit20.SelectedIndex = 0;
            }
            else if (comboBoxEdit21.SelectedIndex == 1)
            {
                comboBoxEdit20.Properties.Items.Clear();
                comboBoxEdit20.Properties.Items.AddRange(BO2.MyFunc.zmWeapons());
                comboBoxEdit20.SelectedIndex = 0;
            }
            else if (comboBoxEdit21.SelectedIndex == 2)
            {
                comboBoxEdit20.Properties.Items.Clear();
                comboBoxEdit20.Properties.Items.AddRange(BO2.MyFunc.zmEquip);
                comboBoxEdit20.SelectedIndex = 0;
            }
            else if (comboBoxEdit21.SelectedIndex == 3)
            {
                comboBoxEdit20.Properties.Items.Clear();
                comboBoxEdit20.Properties.Items.AddRange(BO2.MyFunc.zmR3);
                comboBoxEdit20.SelectedIndex = 0;
            }
        }

        private void simpleButton117_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit22.SelectedIndex == 0)
            {
                BO2.MyFunc.TeleportClient2Client(0, listBoxControl4.SelectedIndex);
            }
            else if (comboBoxEdit22.SelectedIndex == 1)
            {
                BO2.MyFunc.TeleportClient2Client(listBoxControl4.SelectedIndex, 0);
            }
            else if (comboBoxEdit22.SelectedIndex == 2)
            {
                BO2.MyFunc.TeleportClient2Client(listBoxControl4.SelectedIndex, 0);
                BO2.MyFunc.TeleportClient2Client(listBoxControl4.SelectedIndex, 1);
                BO2.MyFunc.TeleportClient2Client(listBoxControl4.SelectedIndex, 2);
                BO2.MyFunc.TeleportClient2Client(listBoxControl4.SelectedIndex, 3);
            }
        }

        private void zoomTrackBarControl8_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl8.Value == 0)
            {
                byte[] buffer = new byte[] { 0x40, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl8.Value == 1)
            {
                byte[] buffer = new byte[] { 0x42, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl8.Value == 2)
            {
                byte[] buffer = new byte[] { 0x44, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl8.Value == 3)
            {
                byte[] buffer = new byte[] { 0x46, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
            else if (zoomTrackBarControl8.Value == 4)
            {
                byte[] buffer = new byte[] { 0x48, 0x9C };
                PS3.SetMemory(0x005BE0B4, buffer);
            }
        }

        private void zoomTrackBarControl7_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl7.Value == 0)
            {
                byte[] buffer = new byte[3];
                PS3.SetMemory(0x1CA4E78, buffer);
            }
            else if (zoomTrackBarControl7.Value == 1)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 0x01;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
            else if (zoomTrackBarControl7.Value == 2)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 2;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
            else if (zoomTrackBarControl7.Value == 3)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 4;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
            else if (zoomTrackBarControl7.Value == 4)
            {
                byte[] buffer = new byte[3];
                buffer[2] = 6;
                byte[] buffer2 = buffer;
                PS3.SetMemory(0x1CA4E78, buffer2);
            }
        }

        private void zoomTrackBarControl5_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl5.Value == 0)
            {
                byte[] buffer = new byte[] { 0x45, 0x48 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
            else if (zoomTrackBarControl5.Value == 1)
            {
                byte[] buffer = new byte[] { 0x44, 0x48 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
            else if (zoomTrackBarControl5.Value == 2)
            {
                byte[] buffer = new byte[] { 0x43, 9 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
            else if (zoomTrackBarControl5.Value == 3)
            {
                byte[] buffer = new byte[] { 0x42, 0x48 };
                PS3.SetMemory(0x1CAF9D8, buffer);
            }
        }

        private void zoomTrackBarControl6_EditValueChanged(object sender, EventArgs e)
        {
            if (zoomTrackBarControl6.Value == 0)
            {
                byte[] buffer = new byte[] { 0x3E, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
            }
            else if (zoomTrackBarControl6.Value == 1)
            {
                byte[] buffer = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
            }
            else if (zoomTrackBarControl6.Value == 2)
            {
                byte[] buffer = new byte[] { 0x40, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
            }
        }

        private void checkButton63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton63.Checked)
            {
                PS3.SetMemory(0x1CAF0d8, new byte[] { 0x49, 0xff, 0xff });
                PS3.SetMemory(0x1CAF138, new byte[] { 0x49, 0xff, 0xff });
                PS3.SetMemory(0x1CAF198, new byte[] { 0x49, 0xff, 0xff });
                checkButton63.Text = "Melee Range - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Melee Range - ^2ON");
            }
            else
            {
                byte[] buffer = new byte[3];
                buffer[0] = 0x42;
                buffer[1] = 0x5c;
                PS3.SetMemory(0x1CAF0d8, buffer);
                buffer = new byte[3];
                buffer[0] = 0x41;
                buffer[1] = 0x20;
                PS3.SetMemory(0x1CAF138, buffer);
                buffer = new byte[3];
                buffer[0] = 0x41;
                buffer[1] = 0x20;
                PS3.SetMemory(0x1CAF198, buffer);
                checkButton63.Text = "Melee Range - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Melee Range - ^1OFF");
            }
        }

        private void checkButton59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton59.Checked)
            {
                PS3.SetMemory(0x1CA4ED8, new byte[] { 0x47 });
                checkButton59.Text = "Knockback - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Knockback - ^2ON");
            }
            else
            {
                PS3.SetMemory(0x1CA4ED8, new byte[] { 0x44 });
                checkButton59.Text = "Knockback - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Knockback - ^1OFF");
            }
        }

        private void checkButton62_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton62.Checked)
            {
                if (zmrapidfire == false)
                {
                    XtraMessageBox.Show("You have to set All Perks to use Rapid Fire.", "Rapid Fire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    zmrapidfire = true;
                }
                byte[] buffer = new byte[] { 0, 2, 0, 0, 0, 0, 0x30, 0x23, 0xD7, 10, 0xD0, 1, 0x7D, 0x60 };
                PS3.SetMemory(0x1CB2AF2, buffer);
                checkButton62.Text = "Rapid Fire - ON";
                if (rpcConnected)
                    RPC.iPrintln(0, "Rapid Fire - ^2ON");
            }
            else
            {
                byte[] buffer = new byte[] { 0, 2, 0, 0, 0, 0, 0x3f, 0x40, 0, 0, 0xd0, 1, 0x7d, 0x60 };
                PS3.SetMemory(0x1CB2AF2, buffer);
                checkButton62.Text = "Rapid Fire - OFF";
                if (rpcConnected)
                    RPC.iPrintln(0, "Rapid Fire - ^1OFF");
            }
        }

        private void simpleButton118_Click(object sender, EventArgs e)
        {
            if (rpcConnected == true)
            {
                BO2.MyFunc.ZmRoundLimit("Fast_restart");
            }
            else
            {
                XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton119_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x26FCA80, BitConverter.GetBytes(Convert.ToInt32(spinEdit54.Value)));
        }

        private void checkButton64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton64.Checked)
            {
                PS3.SetMemory(0x100502CC, new byte[] {
                            0x4F, 0x20, 0x22, 0x5E, 0x38, 90, 0x6F, 0x6D, 0x62, 0x69, 0x65, 0x20, 0x53, 0x74, 0x6F, 0x70,
                            0x20, 0x53, 0x70, 0x61, 0x77, 110, 0x69, 110, 0x67, 0x20, 0x5E, 50, 0x4F, 110, 0x22, 0
                         });
                PS3.SetMemory(0x1CA5178, new byte[1]);
                checkButton64.Text = "Stop Spawning - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Spawning ^2Stopped");
                }
            }
            else
            {
                PS3.SetMemory(0x100502CC, new byte[] {
                            0x4F, 0x20, 0x22, 0x5E, 0x38, 90, 0x6F, 0x6D, 0x62, 0x69, 0x65, 0x20, 0x53, 0x74, 0x6F, 0x70,
                            0x20, 0x53, 0x70, 0x61, 0x77, 110, 0x69, 110, 0x67, 0x20, 0x5E, 0x31, 0x4F, 0x66, 0x66, 0x22,
                            0
                         });
                PS3.SetMemory(0x1CA5178, new byte[] { 1 });
                checkButton64.Text = "Stop Spawning - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Spawning ^1Restored");
                }
            }
        }

        private void checkButton66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton66.Checked)
            {
                byte[] buffer = new byte[] { 0x3E, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
                checkButton66.Text = "Slow Motion - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Slow Motion ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0x3F, 0x80 };
                PS3.SetMemory(0x1CB7BF8, buffer);
                checkButton66.Text = "Slow Motion - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Slow Motion ^1OFF");
                }
            }
        }

        private void checkButton65_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton65.Checked)
            {
                byte[] buffer = new byte[] { 0x38, 0x60, 0, 5 };
                PS3.SetMemory(0x5D5C68, buffer);
                checkButton65.Text = "Fly Mode - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Fly Mode ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0x80, 0x7D, 0, 4 };
                PS3.SetMemory(0x5D5C68, buffer);
                checkButton65.Text = "Fly Mode - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Fly Mode ^1OFF");
                }
            }
        }

        private void checkEdit67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit67.Checked)
            {
                if (rpcConnected == true)
                {
                    BO2.MyFunc.ZmiPrintBoldStart(textEdit39.Text, true);
                }
                else
                {
                    checkEdit67.Checked = false;
                    XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BO2.MyFunc.ZmiPrintBoldStart(textEdit39.Text, false);
            }
        }

        private void checkEdit66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit66.Checked)
            {
                if (rpcConnected == true)
                {
                    BO2.MyFunc.ZmiPrintStart(textEdit39.Text, true);
                }
                else
                {
                    checkEdit66.Checked = false;
                    XtraMessageBox.Show("You have to enable RPC to use this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BO2.MyFunc.ZmiPrintStart(textEdit39.Text, false);
            }
        }

        private void checkButton68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit68.Checked)
            {
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                PS3.SetMemory(0xF9E54, buffer);
                checkButton68.Text = "No Recoil - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "No Recoil ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[] { 0x48, 80, 0x6D, 0x65 };
                PS3.SetMemory(0xF9E54, buffer);
                checkButton68.Text = "No Recoil - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "No Recoil ^2OFF");
                }
            }
        }

        private void checkButton67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit67.Checked)
            {
                PS3.SetMemory(0xEF68C, new byte[] { 0x2c, 3, 0, 1 });
                checkButton67.Text = "Laser - ON";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Laser ^2ON");
                }
            }
            else
            {
                byte[] buffer = new byte[4];
                buffer[0] = 0x2c;
                buffer[1] = 3;
                PS3.SetMemory(0xEF68C, buffer);
                checkButton67.Text = "Laser - OFF";
                if (rpcConnected == true)
                {
                    RPC.iPrintln(0, "Laser ^1OFF");
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("This is the latest and last version of this tool. \nNo updates available.", "Updates info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Feature disabled, server is offline :( Source code still available tho!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //ModMenuManager.ModMenu mod = new ModMenuManager.ModMenu();
            //mod.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            EBOOT_Builder.Selector sel = new EBOOT_Builder.Selector();
            sel.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImageInjector.ImgInj img = new ImgInj();
            img.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton120_Click(object sender, EventArgs e)
        {
            if (checkEdit87.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit72.Value.ToString()));
                PS3.SetMemory(0x026FCCCA + 0x80, buffer);
            }
            if (checkEdit86.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit71.Value.ToString()));
                PS3.SetMemory(0x026FCB92 + 0x80, buffer);
            }
            if (checkEdit84.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit70.Value.ToString()));
                PS3.SetMemory(0x026FCCE8 + 0x80, buffer);
            }
            if (checkEdit83.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit69.Value.ToString()));
                PS3.SetMemory(0x026FCD2A + 0x80, buffer);
            }
            if (checkEdit82.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit68.Value.ToString()));
                PS3.SetMemory(0x026FCB98 + 0x80, buffer);
            }
            if (checkEdit81.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit67.Value.ToString()));
                PS3.SetMemory(0x026FCD06 + 0x80, buffer);
            }
            if (checkEdit80.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit66.Value.ToString()));
                PS3.SetMemory(0x026FCC46 + 0x80, buffer);
            }
            if (checkEdit79.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit65.Value.ToString()));
                PS3.SetMemory(0x026FCBFE + 0x80, buffer);
            }
            if (checkEdit78.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit64.Value.ToString()));
                PS3.SetMemory(0x026FCCFA + 0x80, buffer);
            }
            if (checkEdit77.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit63.Value.ToString()));
                PS3.SetMemory(0x026FCEB0 + 0x80, buffer);
            }
            if (checkEdit76.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit62.Value.ToString()));
                PS3.SetMemory(0x026FCC04 + 0x80, buffer);
            }
            if (checkEdit75.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit61.Value.ToString()));
                PS3.SetMemory(0x026FCBA4 + 0x80, buffer);
            }
            if (checkEdit74.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit60.Value.ToString()));
                PS3.SetMemory(0x026FCD9C + 0x80, buffer);
            }
            if (checkEdit73.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit59.Value.ToString()));
                PS3.SetMemory(0x026FCB8C + 0x80, buffer);
            }
            if (checkEdit72.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit58.Value.ToString()));
                PS3.SetMemory(0x026FCDDE + 0x80, buffer);
            }
            if (checkEdit71.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit57.Value.ToString()));
                PS3.SetMemory(0x026FCD96 + 0x80, buffer);
            }
            if (checkEdit70.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit56.Value.ToString()));
                PS3.SetMemory(0x026FCCBE + 0x80, buffer);
            }
            if (checkEdit69.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit55.Value.ToString()));
                PS3.SetMemory(0x026FCD36 + 0x80, buffer);
            }
            checkEdit87.Checked = false;
            checkEdit86.Checked = false;
            checkEdit84.Checked = false;
            checkEdit83.Checked = false;
            checkEdit82.Checked = false;
            checkEdit81.Checked = false;
            checkEdit80.Checked = false;
            checkEdit79.Checked = false;
            checkEdit78.Checked = false;
            checkEdit77.Checked = false;
            checkEdit76.Checked = false;
            checkEdit75.Checked = false;
            checkEdit74.Checked = false;
            checkEdit73.Checked = false;
            checkEdit72.Checked = false;
            checkEdit71.Checked = false;
            checkEdit70.Checked = false;
            checkEdit69.Checked = false;
        }

        private void simpleButton121_Click(object sender, EventArgs e)
        {
            if (checkEdit105.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit90.Value.ToString()));
                PS3.SetMemory(0x026FCE20 + 0x80, buffer);
            }
            if (checkEdit104.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit89.Value.ToString()));
                PS3.SetMemory(0x026FCC88 + 0x80, buffer);
            }
            if (checkEdit103.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit88.Value.ToString()));
                PS3.SetMemory(0x026FCC76 + 0x80, buffer);
            }
            if (checkEdit102.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit87.Value.ToString()));
                PS3.SetMemory(0x026FCBD4 + 0x80, buffer);
            }
            if (checkEdit101.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit86.Value.ToString()));
                PS3.SetMemory(0x026FCBBC + 0x80, buffer);
            }
            if (checkEdit100.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit85.Value.ToString()));
                PS3.SetMemory(0x026FCBE0 + 0x80, buffer);
            }
            if (checkEdit99.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit84.Value.ToString()));
                PS3.SetMemory(0x026FCECE + 0x80, buffer);
            }
            if (checkEdit98.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit83.Value.ToString()));
                PS3.SetMemory(0x026FCBC8 + 0x80, buffer);
            }
            if (checkEdit97.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit82.Value.ToString()));
                PS3.SetMemory(0x026FCD48 + 0x80, buffer);
            }
            if (checkEdit96.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit81.Value.ToString()));
                PS3.SetMemory(0x026FCD3C + 0x80, buffer);
            }
            if (checkEdit95.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit80.Value.ToString()));
                PS3.SetMemory(0x026FCBCE + 0x80, buffer);
            }
            if (checkEdit94.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit79.Value.ToString()));
                PS3.SetMemory(0x026FCBF8 + 0x80, buffer);
            }
            if (checkEdit93.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit78.Value.ToString()));
                PS3.SetMemory(0x026FCCDC + 0x80, buffer);
            }
            if (checkEdit92.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit77.Value.ToString()));
                PS3.SetMemory(0x026FCC10 + 0x80, buffer);
            }
            if (checkEdit91.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit76.Value.ToString()));
                PS3.SetMemory(0x026FCDA2 + 0x80, buffer);
            }
            if (checkEdit90.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit75.Value.ToString()));
                PS3.SetMemory(0x026FCCC4 + 0x80, buffer);
            }
            if (checkEdit89.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit74.Value.ToString()));
                PS3.SetMemory(0x026FCC1C + 0x80, buffer);
            }
            if (checkEdit88.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit73.Value.ToString()));
                PS3.SetMemory(0x026FCC58 + 0x80, buffer);
            }
            checkEdit105.Checked = false;
            checkEdit104.Checked = false;
            checkEdit103.Checked = false;
            checkEdit102.Checked = false;
            checkEdit101.Checked = false;
            checkEdit100.Checked = false;
            checkEdit99.Checked = false;
            checkEdit98.Checked = false;
            checkEdit97.Checked = false;
            checkEdit96.Checked = false;
            checkEdit95.Checked = false;
            checkEdit94.Checked = false;
            checkEdit93.Checked = false;
            checkEdit92.Checked = false;
            checkEdit91.Checked = false;
            checkEdit90.Checked = false;
            checkEdit89.Checked = false;
            checkEdit88.Checked = false;
        }

        private void simpleButton122_Click(object sender, EventArgs e)
        {
            if (checkEdit123.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit108.Value.ToString()));
                PS3.SetMemory(0x026FCBEC + 0x80, buffer);
            }
            if (checkEdit122.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit107.Value.ToString()));
                PS3.SetMemory(0x026FCD7E + 0x80, buffer);
            }
            if (checkEdit121.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit106.Value.ToString()));
                PS3.SetMemory(0x026FCDA8 + 0x80, buffer);
            }
            if (checkEdit120.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit105.Value.ToString()));
                PS3.SetMemory(0x026FCD1E + 0x80, buffer);
            }
            if (checkEdit119.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit104.Value.ToString()));
                PS3.SetMemory(0x026FCC82 + 0x80, buffer);
            }
            if (checkEdit118.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit103.Value.ToString()));
                PS3.SetMemory(0x026FCBDA + 0x80, buffer);
            }
            if (checkEdit117.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit102.Value.ToString()));
                PS3.SetMemory(0x026FCBB0 + 0x80, buffer);
            }
            if (checkEdit116.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit101.Value.ToString()));
                PS3.SetMemory(0x026FCC3A + 0x80, buffer);
            }
            if (checkEdit115.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit100.Value.ToString()));
                PS3.SetMemory(0x026FCCB8 + 0x80, buffer);
            }
            if (checkEdit114.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit99.Value.ToString()));
                PS3.SetMemory(0x026FCC28 + 0x80, buffer);
            }
            if (checkEdit113.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit98.Value.ToString()));
                PS3.SetMemory(0x026FCE02 + 0x80, buffer);
            }
            if (checkEdit112.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit97.Value.ToString()));
                PS3.SetMemory(0x026FCD8A + 0x80, buffer);
            }
            if (checkEdit111.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit96.Value.ToString()));
                PS3.SetMemory(0x026FCC40 + 0x80, buffer);
            }
            if (checkEdit110.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit95.Value.ToString()));
                PS3.SetMemory(0x026FCCD6 + 0x80, buffer);
            }
            if (checkEdit109.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit94.Value.ToString()));
                PS3.SetMemory(0x026FCDE4 + 0x80, buffer);
            }
            if (checkEdit108.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit93.Value.ToString()));
                PS3.SetMemory(0x026FCCF4 + 0x80, buffer);
            }
            if (checkEdit107.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit92.Value.ToString()));
                PS3.SetMemory(0x026FCC70 + 0x80, buffer);
            }
            if (checkEdit106.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit91.Value.ToString()));
                PS3.SetMemory(0x026FCC5E + 0x80, buffer);
            }
            checkEdit123.Checked = false;
            checkEdit122.Checked = false;
            checkEdit121.Checked = false;
            checkEdit120.Checked = false;
            checkEdit119.Checked = false;
            checkEdit118.Checked = false;
            checkEdit117.Checked = false;
            checkEdit116.Checked = false;
            checkEdit115.Checked = false;
            checkEdit114.Checked = false;
            checkEdit113.Checked = false;
            checkEdit112.Checked = false;
            checkEdit111.Checked = false;
            checkEdit110.Checked = false;
            checkEdit109.Checked = false;
            checkEdit108.Checked = false;
            checkEdit107.Checked = false;
            checkEdit106.Checked = false;
        }

        private void simpleButton123_Click(object sender, EventArgs e)
        {
            if (checkEdit141.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit126.Value.ToString()));
                PS3.SetMemory(0x026FCD78 + 0x80, buffer);
            }
            if (checkEdit140.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit125.Value.ToString()));
                PS3.SetMemory(0x026FCD24 + 0x80, buffer);
            }
            if (checkEdit139.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit124.Value.ToString()));
                PS3.SetMemory(0x026FCE08 + 0x80, buffer);
            }
            if (checkEdit138.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit123.Value.ToString()));
                PS3.SetMemory(0x026FCE1A + 0x80, buffer);
            }
            if (checkEdit137.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit122.Value.ToString()));
                PS3.SetMemory(0x026FCC0A + 0x80, buffer);
            }
            if (checkEdit136.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit121.Value.ToString()));
                PS3.SetMemory(0x026FCDF6 + 0x80, buffer);
            }
            if (checkEdit135.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit120.Value.ToString()));
                PS3.SetMemory(0x026FCE14 + 0x80, buffer);
            }
            if (checkEdit134.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit119.Value.ToString()));
                PS3.SetMemory(0x026FCC22 + 0x80, buffer);
            }
            if (checkEdit133.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit118.Value.ToString()));
                PS3.SetMemory(0x026FCC34 + 0x80, buffer);
            }
            if (checkEdit132.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit117.Value.ToString()));
                PS3.SetMemory(0x026FCBF2 + 0x80, buffer);
            }
            if (checkEdit131.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit116.Value.ToString()));
                PS3.SetMemory(0x026FCCD0 + 0x80, buffer);
            }
            if (checkEdit130.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit115.Value.ToString()));
                PS3.SetMemory(0x026FCCAC + 0x80, buffer);
            }
            if (checkEdit129.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit114.Value.ToString()));
                PS3.SetMemory(0x026FCDF0 + 0x80, buffer);
            }
            if (checkEdit128.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit113.Value.ToString()));
                PS3.SetMemory(0x026FCBE6 + 0x80, buffer);
            }
            if (checkEdit127.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit112.Value.ToString()));
                PS3.SetMemory(0x026FCD30 + 0x80, buffer);
            }
            if (checkEdit126.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit111.Value.ToString()));
                PS3.SetMemory(0x026FCCF4 + 0x80, buffer);
            }
            if (checkEdit125.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit110.Value.ToString()));
                PS3.SetMemory(0x026FCD90 + 0x80, buffer);
            }
            if (checkEdit124.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit109.Value.ToString()));
                PS3.SetMemory(0x026FCBC2 + 0x80, buffer);
            }
            checkEdit141.Checked = false;
            checkEdit140.Checked = false;
            checkEdit139.Checked = false;
            checkEdit138.Checked = false;
            checkEdit137.Checked = false;
            checkEdit136.Checked = false;
            checkEdit135.Checked = false;
            checkEdit134.Checked = false;
            checkEdit133.Checked = false;
            checkEdit132.Checked = false;
            checkEdit131.Checked = false;
            checkEdit130.Checked = false;
            checkEdit129.Checked = false;
            checkEdit128.Checked = false;
            checkEdit127.Checked = false;
            checkEdit126.Checked = false;
            checkEdit125.Checked = false;
            checkEdit124.Checked = false;
        }

        private void simpleButton124_Click(object sender, EventArgs e)
        {
            if (checkEdit159.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit144.Value.ToString()));
                PS3.SetMemory(0x026FCB9E + 0x80, buffer);
            }
            if (checkEdit158.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit143.Value.ToString()));
                PS3.SetMemory(0x026FCDEA + 0x80, buffer);
            }
            if (checkEdit157.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit142.Value.ToString()));
                PS3.SetMemory(0x026FCD42 + 0x80, buffer);
            }
            if (checkEdit156.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit141.Value.ToString()));
                PS3.SetMemory(0x026FCD0C + 0x80, buffer);
            }
            if (checkEdit155.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit140.Value.ToString()));
                PS3.SetMemory(0x026FCC16 + 0x80, buffer);
            }
            if (checkEdit154.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit139.Value.ToString()));
                PS3.SetMemory(0x026FCD00 + 0x80, buffer);
            }
            if (checkEdit153.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit138.Value.ToString()));
                PS3.SetMemory(0x026FCE14 + 0x80, buffer);
            }
            if (checkEdit152.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit137.Value.ToString()));
                PS3.SetMemory(0x026FCEC8 + 0x80, buffer); //Victory
            }
            if (checkEdit151.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit136.Value.ToString()));
                PS3.SetMemory(0x026FCC2E + 0x80, buffer);
            }
            if (checkEdit150.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit135.Value.ToString()));
                PS3.SetMemory(0x026FCC4C + 0x80, buffer);
            }
            if (checkEdit149.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit134.Value.ToString()));
                PS3.SetMemory(0x026FCC9A + 0x80, buffer);
            }
            if (checkEdit148.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit133.Value.ToString()));
                PS3.SetMemory(0x026FCBB6 + 0x80, buffer);
            }
            if (checkEdit147.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit132.Value.ToString()));
                PS3.SetMemory(0x026FCE80 + 0x80, buffer);
            }
            if (checkEdit146.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit131.Value.ToString()));
                PS3.SetMemory(0x026FCEA4 + 0x80, buffer);
            }
            if (checkEdit145.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit130.Value.ToString()));
                PS3.SetMemory(0x026FCE92 + 0x80, buffer);
            }
            if (checkEdit144.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit129.Value.ToString()));
                PS3.SetMemory(0x026FCE68 + 0x80, buffer);
            }
            if (checkEdit143.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit128.Value.ToString()));
                PS3.SetMemory(0x026FCE26 + 0x80, buffer);
            }
            if (checkEdit142.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit127.Value.ToString()));
                PS3.SetMemory(0x026FCE32 + 0x80, buffer);
            }
            checkEdit159.Checked = false;
            checkEdit158.Checked = false;
            checkEdit157.Checked = false;
            checkEdit156.Checked = false;
            checkEdit155.Checked = false;
            checkEdit154.Checked = false;
            checkEdit153.Checked = false;
            checkEdit152.Checked = false;
            checkEdit151.Checked = false;
            checkEdit150.Checked = false;
            checkEdit149.Checked = false;
            checkEdit148.Checked = false;
            checkEdit147.Checked = false;
            checkEdit146.Checked = false;
            checkEdit145.Checked = false;
            checkEdit144.Checked = false;
            checkEdit143.Checked = false;
            checkEdit142.Checked = false;
        }

        private void simpleButton125_Click(object sender, EventArgs e)
        {
            if (checkEdit162.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit147.Value.ToString()));
                PS3.SetMemory(0x026FCE74 + 0x80, buffer);
            }
            if (checkEdit161.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit146.Value.ToString()));
                PS3.SetMemory(0x026FCE38 + 0x80, buffer);
            }
            if (checkEdit160.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit145.Value.ToString()));
                PS3.SetMemory(0x026FCE4A + 0x80, buffer);
            }
            if (checkEdit165.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit150.Value.ToString()));
                PS3.SetMemory(0x026FCE7A + 0x80, buffer);
            }
            if (checkEdit164.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit149.Value.ToString()));
                PS3.SetMemory(0x026FCE50 + 0x80, buffer);
            }
            if (checkEdit163.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit148.Value.ToString()));
                PS3.SetMemory(0x026FCE44 + 0x80, buffer);
            }
            if (checkEdit168.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit153.Value.ToString()));
                PS3.SetMemory(0x026FCE98 + 0x80, buffer);
            }
            if (checkEdit167.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit152.Value.ToString()));
                PS3.SetMemory(0x026FCE62 + 0x80, buffer);
            }
            if (checkEdit166.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit151.Value.ToString()));
                PS3.SetMemory(0x026FCE8C + 0x80, buffer);
            }
            if (checkEdit171.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit156.Value.ToString()));
                PS3.SetMemory(0x026FCE56 + 0x80, buffer);
            }
            if (checkEdit169.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit154.Value.ToString()));
                PS3.SetMemory(0x026FCE3E + 0x80, buffer);
            }
            if (checkEdit170.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit155.Value.ToString()));
                PS3.SetMemory(0x026FCE5C + 0x80, buffer);
            }
            if (checkEdit172.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(spinEdit157.Value.ToString()));
                PS3.SetMemory(0x026FCE86 + 0x80, buffer);
            }
            checkEdit162.Checked = false;
            checkEdit161.Checked = false;
            checkEdit160.Checked = false;
            checkEdit165.Checked = false;
            checkEdit164.Checked = false;
            checkEdit163.Checked = false;
            checkEdit168.Checked = false;
            checkEdit167.Checked = false;
            checkEdit166.Checked = false;
            checkEdit171.Checked = false;
            checkEdit169.Checked = false;
            checkEdit170.Checked = false;
            checkEdit172.Checked = false;
        }

        #region Prest Stats
        private void NoobStat()
        {
            decimal num = 1 * 86400M;
            decimal num2 = 4 * 3600M;
            decimal num3 = 20 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] buffer = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, buffer);

            byte[] buffer1 = BitConverter.GetBytes(Convert.ToInt32(6653.ToString()));
            PS3.SetMemory(0x26FC942, buffer1);

            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(5005.ToString()));
            PS3.SetMemory(0x26FCB70, buffer2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(390.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(110890.ToString()));
            PS3.SetMemory(0x26FD050, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(292.ToString()));
            PS3.SetMemory(0x26FD152, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(766.ToString()));
            PS3.SetMemory(0x26FCBE2, buffer5);

            byte[] buffer6 = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer6);

            string value = 2.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer7 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer7);
        }

        private void LegitStat()
        {
            decimal num = 3 * 86400M;
            decimal num2 = 9 * 3600M;
            decimal num3 = 11 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] buffer = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, buffer);

            byte[] buffer1 = BitConverter.GetBytes(Convert.ToInt32(16157.ToString()));
            PS3.SetMemory(0x26FC942, buffer1);

            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(25987.ToString()));
            PS3.SetMemory(0x26FCB70, buffer2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(3910.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(2348641.ToString()));
            PS3.SetMemory(0x26FD050, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(2500.ToString()));
            PS3.SetMemory(0x26FD152, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(1852.ToString()));
            PS3.SetMemory(0x26FCBE2, buffer5);

            byte[] buffer6 = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer6);

            string value = 9.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer7 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer7);
        }

        private void ProStat()
        {
            decimal num = 7 * 86400M;
            decimal num2 = 8 * 3600M;
            decimal num3 = 22 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);

            byte[] bu1 = BitConverter.GetBytes(Convert.ToInt32(48098.ToString()));
            PS3.SetMemory(0x26FC942, bu1);

            byte[] bu2 = BitConverter.GetBytes(Convert.ToInt32(199881.ToString()));
            PS3.SetMemory(0x26FCB70, bu2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(32218.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] bu3 = BitConverter.GetBytes(Convert.ToInt32(21470000.ToString()));
            PS3.SetMemory(0x26FD050, bu3);

            byte[] bu4 = BitConverter.GetBytes(Convert.ToInt32(10066.ToString()));
            PS3.SetMemory(0x26FD152, bu4);

            byte[] bu5 = BitConverter.GetBytes(Convert.ToInt32(3321.ToString()));
            PS3.SetMemory(0x26FCBE2, bu5);

            byte[] buffer = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer);

            string value = 11.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer1 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer1);
        }

        private void InsaneStat()
        {
            decimal num = 15 * 86400M;
            decimal num2 = 18 * 3600M;
            decimal num3 = 15 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);

            byte[] bu1 = BitConverter.GetBytes(Convert.ToInt32(188010.ToString()));
            PS3.SetMemory(0x26FC942, bu1);

            byte[] bu2 = BitConverter.GetBytes(Convert.ToInt32(919387.ToString()));
            PS3.SetMemory(0x26FCB70, bu2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(152218.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] bu3 = BitConverter.GetBytes(Convert.ToInt32(180470505.ToString()));
            PS3.SetMemory(0x26FD050, bu3);

            byte[] bu4 = BitConverter.GetBytes(Convert.ToInt32(49111.ToString()));
            PS3.SetMemory(0x26FD152, bu4);

            byte[] bu5 = BitConverter.GetBytes(Convert.ToInt32(13030.ToString()));
            PS3.SetMemory(0x26FCBE2, bu5);

            byte[] buffer = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer);

            string value = 11.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer1 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer1);
        }

        private void NoobStat2()
        {
            decimal num = 1 * 86400M;
            decimal num2 = 4 * 3600M;
            decimal num3 = 20 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] buffer = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, buffer);

            byte[] buffer1 = BitConverter.GetBytes(Convert.ToInt32(6653.ToString()));
            PS3.SetMemory(0x26FC942, buffer1);

            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(5005.ToString()));
            PS3.SetMemory(0x26FCB70, buffer2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(390.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(110890.ToString()));
            PS3.SetMemory(0x26FD050, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(292.ToString()));
            PS3.SetMemory(0x26FD152, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(766.ToString()));
            PS3.SetMemory(0x26FCBE2, buffer5);

            byte[] buffer6 = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer6);

            string value = 2.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer7 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer7);
        }

        private void LegitStat2()
        {
            decimal num = 3 * 86400M;
            decimal num2 = 9 * 3600M;
            decimal num3 = 11 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] buffer = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, buffer);

            byte[] buffer1 = BitConverter.GetBytes(Convert.ToInt32(16157.ToString()));
            PS3.SetMemory(0x26FC942, buffer1);

            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(25987.ToString()));
            PS3.SetMemory(0x26FCB70, buffer2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(3910.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(2348641.ToString()));
            PS3.SetMemory(0x26FD050, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(2500.ToString()));
            PS3.SetMemory(0x26FD152, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(1852.ToString()));
            PS3.SetMemory(0x26FCBE2, buffer5);

            byte[] buffer6 = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer6);

            string value = 9.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer7 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer7);
        }

        private void ProStat2()
        {
            decimal num = 7 * 86400M;
            decimal num2 = 8 * 3600M;
            decimal num3 = 22 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);

            byte[] bu1 = BitConverter.GetBytes(Convert.ToInt32(48098.ToString()));
            PS3.SetMemory(0x26FC942, bu1);

            byte[] bu2 = BitConverter.GetBytes(Convert.ToInt32(199881.ToString()));
            PS3.SetMemory(0x26FCB70, bu2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(32218.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] bu3 = BitConverter.GetBytes(Convert.ToInt32(21470000.ToString()));
            PS3.SetMemory(0x26FD050, bu3);

            byte[] bu4 = BitConverter.GetBytes(Convert.ToInt32(10066.ToString()));
            PS3.SetMemory(0x26FD152, bu4);

            byte[] bu5 = BitConverter.GetBytes(Convert.ToInt32(3321.ToString()));
            PS3.SetMemory(0x26FCBE2, bu5);

            byte[] buffer = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer);

            string value = 11.ToString();
            int value2 = (int)Convert.ToByte(value);
            byte[] buffer1 = BitConverter.GetBytes(value2);
            PS3.SetMemory(0x26FD014, buffer1);
        }

        private void InsaneStat2()
        {
            decimal num = 15 * 86400M;
            decimal num2 = 18 * 3600M;
            decimal num3 = 15 * 60M;
            decimal num4 = num + num2 + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);

            byte[] bu1 = BitConverter.GetBytes(Convert.ToInt32(188010.ToString()));
            PS3.SetMemory(0x26FC942, bu1);

            byte[] bu2 = BitConverter.GetBytes(Convert.ToInt32(919387.ToString()));
            PS3.SetMemory(0x26FCB70, bu2);

            byte[] head = BitConverter.GetBytes(Convert.ToInt32(152218.ToString()));
            PS3.SetMemory(0x26FCA44, head);

            byte[] bu3 = BitConverter.GetBytes(Convert.ToInt32(180470505.ToString()));
            PS3.SetMemory(0x26FD050, bu3);

            byte[] bu4 = BitConverter.GetBytes(Convert.ToInt32(49111.ToString()));
            PS3.SetMemory(0x26FD152, bu4);

            byte[] bu5 = BitConverter.GetBytes(Convert.ToInt32(13030.ToString()));
            PS3.SetMemory(0x26FCBE2, bu5);

            byte[] buffer = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, buffer);
        }

        private void NoobMedals()
        {
                byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCD72 + 0x80, buffer);

                byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCD66 + 0x80, buffer2);

                byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCD60 + 0x80, buffer3);

                byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCD5A + 0x80, buffer4);

                byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCD54 + 0x80, buffer5);

                byte[] buffer6 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
                PS3.SetMemory(0x026FCD4E + 0x80, buffer6);

                byte[] buffer7 = BitConverter.GetBytes(Convert.ToInt32(16.ToString()));
                PS3.SetMemory(0x026FCD6C + 0x80, buffer7);

                byte[] buffer8 = BitConverter.GetBytes(Convert.ToInt32(34.ToString()));
                PS3.SetMemory(0x026FCDAE + 0x80, buffer8);

                byte[] buffer9 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
                PS3.SetMemory(0x026FCDB4 + 0x80, buffer9);

                byte[] buffer11 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCDBA + 0x80, buffer11);

                byte[] buffer22 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCDC0 + 0x80, buffer22);

                byte[] buffer33 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCDC6 + 0x80, buffer33);

                byte[] buffer44 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCDCC + 0x80, buffer44);

                byte[] buffer55 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCDD2 + 0x80, buffer55);

                byte[] buffer66 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCDD8 + 0x80, buffer66);

                byte[] buffer77 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCEC2 + 0x80, buffer77);

                byte[] buffer88 = BitConverter.GetBytes(Convert.ToInt32(49.ToString()));
                PS3.SetMemory(0x026FCC6A + 0x80, buffer88);

                byte[] buffer99 = BitConverter.GetBytes(Convert.ToInt32(67.ToString()));
                PS3.SetMemory(0x026FCCEE + 0x80, buffer99);

            // Medals tab 1
            
                byte[] buffer111 = BitConverter.GetBytes(Convert.ToInt32(10.ToString()));
                PS3.SetMemory(0x026FCCCA + 0x80, buffer111);

                byte[] buffer222 = BitConverter.GetBytes(Convert.ToInt32(7.ToString()));
                PS3.SetMemory(0x026FCB92 + 0x80, buffer222);

                byte[] buffer333 = BitConverter.GetBytes(Convert.ToInt32(12.ToString()));
                PS3.SetMemory(0x026FCCE8 + 0x80, buffer333);

                byte[] buffer444 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
                PS3.SetMemory(0x026FCD2A + 0x80, buffer444);

                byte[] buffer555 = BitConverter.GetBytes(Convert.ToInt32(4.ToString()));
                PS3.SetMemory(0x026FCB98 + 0x80, buffer555);

                byte[] buffer666 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCD06 + 0x80, buffer666);

                byte[] buffer777 = BitConverter.GetBytes(Convert.ToInt32(14.ToString())); //Blackout
                PS3.SetMemory(0x026FCC46 + 0x80, buffer777);

                byte[] buffer888 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCBFE + 0x80, buffer888);

                byte[] buffer999 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
                PS3.SetMemory(0x026FCCFA + 0x80, buffer999);

                byte[] buffer1111 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Buzz Kill
                PS3.SetMemory(0x026FCEB0 + 0x80, buffer1111);

                byte[] buffer2222 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
                PS3.SetMemory(0x026FCC04 + 0x80, buffer2222);

                byte[] buffer3333 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCBA4 + 0x80, buffer3333);

                byte[] buffer4444 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Bullseye
                PS3.SetMemory(0x026FCD9C + 0x80, buffer4444);

                byte[] buffer5555 = BitConverter.GetBytes(Convert.ToInt32(7.ToString()));
                PS3.SetMemory(0x026FCB8C + 0x80, buffer5555);

                byte[] buffer6666 = BitConverter.GetBytes(Convert.ToInt32(5.ToString())); //Boomstick
                PS3.SetMemory(0x026FCDDE + 0x80, buffer6666);

                byte[] buffer7777 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
                PS3.SetMemory(0x026FCD96 + 0x80, buffer7777);

                byte[] buffer8888 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCCBE + 0x80, buffer8888);

                byte[] buffer9999 = BitConverter.GetBytes(Convert.ToInt32(14.ToString()));
                PS3.SetMemory(0x026FCD36 + 0x80, buffer9999);

            // Medals Tab 2
            
                byte[] buffer12 = BitConverter.GetBytes(Convert.ToInt32(10.ToString()));
                PS3.SetMemory(0x026FCE20 + 0x80, buffer12);

                byte[] buffer13 = BitConverter.GetBytes(Convert.ToInt32(3.ToString())); 
                PS3.SetMemory(0x026FCC88 + 0x80, buffer13);

                byte[] buffer14 = BitConverter.GetBytes(Convert.ToInt32(7.ToString())); 
                PS3.SetMemory(0x026FCC76 + 0x80, buffer14);

                byte[] buffer15 = BitConverter.GetBytes(Convert.ToInt32(9.ToString())); 
                PS3.SetMemory(0x026FCBD4 + 0x80, buffer15);

                byte[] buffer16 = BitConverter.GetBytes(Convert.ToInt32(12.ToString()));
                PS3.SetMemory(0x026FCBBC + 0x80, buffer16);

                byte[] buffer17 = BitConverter.GetBytes(Convert.ToInt32(17.ToString())); //Clutch SND
                PS3.SetMemory(0x026FCBE0 + 0x80, buffer17);

                byte[] buffer18 = BitConverter.GetBytes(Convert.ToInt32(70.ToString())); 
                PS3.SetMemory(0x026FCECE + 0x80, buffer18);

                byte[] buffer19 = BitConverter.GetBytes(Convert.ToInt32(1.ToString())); //Deadeye
                PS3.SetMemory(0x026FCBC8 + 0x80, buffer19);

                byte[] buffer21 = BitConverter.GetBytes(Convert.ToInt32(14.ToString())); //Denied Flag
                PS3.SetMemory(0x026FCD48 + 0x80, buffer21);

                byte[] buffer20 = BitConverter.GetBytes(Convert.ToInt32(8.ToString())); 
                PS3.SetMemory(0x026FCD3C + 0x80, buffer20);

                byte[] buffer23 = BitConverter.GetBytes(Convert.ToInt32(9.ToString())); //Decimated
                PS3.SetMemory(0x026FCBCE + 0x80, buffer23);

                byte[] buffer24 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
                PS3.SetMemory(0x026FCBF8 + 0x80, buffer24);

                byte[] buffer25 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCCDC + 0x80, buffer25);

                byte[] buffer26 = BitConverter.GetBytes(Convert.ToInt32(2.ToString())); //Extermination
                PS3.SetMemory(0x026FCC10 + 0x80, buffer26);

                byte[] buffer27 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCDA2 + 0x80, buffer27);

                byte[] buffer28 = BitConverter.GetBytes(Convert.ToInt32(7.ToString()));
                PS3.SetMemory(0x026FCCC4 + 0x80, buffer28);

                byte[] buffer29 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Flyswatter
                PS3.SetMemory(0x026FCC1C + 0x80, buffer29);

                byte[] buffer10 = BitConverter.GetBytes(Convert.ToInt32(12.ToString()));
                PS3.SetMemory(0x026FCC58 + 0x80, buffer10);

            //Medals Tab 3
            
                byte[] buffer31 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCBEC + 0x80, buffer31);

                byte[] buffer32 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
                PS3.SetMemory(0x026FCD7E + 0x80, buffer32);

                byte[] buffer30 = BitConverter.GetBytes(Convert.ToInt32(1.ToString())); //Gun Expert
                PS3.SetMemory(0x026FCDA8 + 0x80, buffer30);

                byte[] buffer34 = BitConverter.GetBytes(Convert.ToInt32(6.ToString()));
                PS3.SetMemory(0x026FCD1E + 0x80, buffer34);

                byte[] buffer35 = BitConverter.GetBytes(Convert.ToInt32(9.ToString()));
                PS3.SetMemory(0x026FCC82 + 0x80, buffer35);

                byte[] buffer36 = BitConverter.GetBytes(Convert.ToInt32(12.ToString())); //Hero
                PS3.SetMemory(0x026FCBDA + 0x80, buffer36);

                byte[] buffer37 = BitConverter.GetBytes(Convert.ToInt32(4.ToString()));
                PS3.SetMemory(0x026FCBB0 + 0x80, buffer37);

                byte[] buffer38 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCC3A + 0x80, buffer38);

                byte[] buffer39 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
                PS3.SetMemory(0x026FCCB8 + 0x80, buffer39);

                byte[] buffer40 = BitConverter.GetBytes(Convert.ToInt32(2.ToString())); //Intercepted
                PS3.SetMemory(0x026FCC28 + 0x80, buffer40);

                byte[] buffer41 = BitConverter.GetBytes(Convert.ToInt32(17.ToString())); //Kaboom
                PS3.SetMemory(0x026FCE02 + 0x80, buffer41);

                byte[] buffer42 = BitConverter.GetBytes(Convert.ToInt32(36.ToString()));
                PS3.SetMemory(0x026FCD8A + 0x80, buffer42);

                byte[] buffer43 = BitConverter.GetBytes(Convert.ToInt32(5.ToString())); //No Tip
                PS3.SetMemory(0x026FCC40 + 0x80, buffer43);

                byte[] buffer45 = BitConverter.GetBytes(Convert.ToInt32(40.ToString()));
                PS3.SetMemory(0x026FCCD6 + 0x80, buffer45);

                byte[] buffer46 = BitConverter.GetBytes(Convert.ToInt32(26.ToString())); //Opening Move
                PS3.SetMemory(0x026FCDE4 + 0x80, buffer46);

                byte[] buffer47 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
                PS3.SetMemory(0x026FCCF4 + 0x80, buffer47);

                byte[] buffer48 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCC70 + 0x80, buffer48);

                byte[] buffer49 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
                PS3.SetMemory(0x026FCC5E + 0x80, buffer49);

            // Medals Tab 4
            
                byte[] buffer50 = BitConverter.GetBytes(Convert.ToInt32(9.ToString()));
                PS3.SetMemory(0x026FCD78 + 0x80, buffer50);

                byte[] buffer51 = BitConverter.GetBytes(Convert.ToInt32(12.ToString()));
                PS3.SetMemory(0x026FCD24 + 0x80, buffer51);

                byte[] buffer52 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Raining Death
                PS3.SetMemory(0x026FCE08 + 0x80, buffer52);

                byte[] buffer53 = BitConverter.GetBytes(Convert.ToInt32(43.ToString()));
                PS3.SetMemory(0x026FCE1A + 0x80, buffer53);

                byte[] buffer54 = BitConverter.GetBytes(Convert.ToInt32(8.ToString()));
                PS3.SetMemory(0x026FCC0A + 0x80, buffer54);

                byte[] buffer56 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Red Baron
                PS3.SetMemory(0x026FCDF6 + 0x80, buffer56);

                byte[] buffer57 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
                PS3.SetMemory(0x026FCE14 + 0x80, buffer57);

                byte[] buffer58 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
                PS3.SetMemory(0x026FCC22 + 0x80, buffer58);

                byte[] buffer59 = BitConverter.GetBytes(Convert.ToInt32(6.ToString()));
                PS3.SetMemory(0x026FCC34 + 0x80, buffer59);

                byte[] buffer60 = BitConverter.GetBytes(Convert.ToInt32(10.ToString()));
                PS3.SetMemory(0x026FCBF2 + 0x80, buffer60);

                byte[] buffer61 = BitConverter.GetBytes(Convert.ToInt32(40.ToString())); //Savior
                PS3.SetMemory(0x026FCCD0 + 0x80, buffer61);

                byte[] buffer62 = BitConverter.GetBytes(Convert.ToInt32(67.ToString()));
                PS3.SetMemory(0x026FCCAC + 0x80, buffer62);

                byte[] buffer63 = BitConverter.GetBytes(Convert.ToInt32(44.ToString())); //Secure D
                PS3.SetMemory(0x026FCDF0 + 0x80, buffer63);

                byte[] buffer64 = BitConverter.GetBytes(Convert.ToInt32(13.ToString()));
                PS3.SetMemory(0x026FCCD6 + 0x80, buffer64);

                byte[] buffer65 = BitConverter.GetBytes(Convert.ToInt32(16.ToString()));
                PS3.SetMemory(0x026FCD30 + 0x80, buffer65);

                byte[] buffer67 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCCF4 + 0x80, buffer67);

                byte[] buffer68 = BitConverter.GetBytes(Convert.ToInt32(9.ToString()));
                PS3.SetMemory(0x026FCD90 + 0x80, buffer68);

                byte[] buffer69 = BitConverter.GetBytes(Convert.ToInt32(105.ToString()));
                PS3.SetMemory(0x026FCBC2 + 0x80, buffer69);

            // Medals Tab 5
            
                byte[] buffer70 = BitConverter.GetBytes(Convert.ToInt32(6.ToString()));
                PS3.SetMemory(0x026FCB9E + 0x80, buffer70);

                byte[] buffer71 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
                PS3.SetMemory(0x026FCDEA + 0x80, buffer71);

                byte[] buffer72 = BitConverter.GetBytes(Convert.ToInt32(11.ToString())); //Takedown Bomb
                PS3.SetMemory(0x026FCD42 + 0x80, buffer72);

                byte[] buffer73 = BitConverter.GetBytes(Convert.ToInt32(9.ToString()));
                PS3.SetMemory(0x026FCD0C + 0x80, buffer73);

                byte[] buffer74 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
                PS3.SetMemory(0x026FCC16 + 0x80, buffer74);

                byte[] buffer75 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCD00 + 0x80, buffer75);

                byte[] buffer76 = BitConverter.GetBytes(Convert.ToInt32(36.ToString())); //Retrieved
                PS3.SetMemory(0x026FCE14 + 0x80, buffer76);

                byte[] buffer78 = BitConverter.GetBytes(Convert.ToInt32(60.ToString())); //Victory
                PS3.SetMemory(0x026FCEC8 + 0x80, buffer78);

                byte[] buffer79 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
                PS3.SetMemory(0x026FCC2E + 0x80, buffer79);

                byte[] buffer80 = BitConverter.GetBytes(Convert.ToInt32(2.ToString())); //Warbeast
                PS3.SetMemory(0x026FCC4C + 0x80, buffer80);

                byte[] buffer81 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
                PS3.SetMemory(0x026FCC9A + 0x80, buffer81);

                byte[] buffer82 = BitConverter.GetBytes(Convert.ToInt32(8.ToString()));
                PS3.SetMemory(0x026FCBB6 + 0x80, buffer82);

                byte[] buffer83 = BitConverter.GetBytes(Convert.ToInt32(23.ToString())); //Shared RCXD
                PS3.SetMemory(0x026FCE80 + 0x80, buffer83);

                byte[] buffer84 = BitConverter.GetBytes(Convert.ToInt32(12.ToString()));
                PS3.SetMemory(0x026FCEA4 + 0x80, buffer84);

                byte[] buffer85 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Shared VSAT
                PS3.SetMemory(0x026FCE92 + 0x80, buffer85);

                byte[] buffer86 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Shared Swarm
                PS3.SetMemory(0x026FCE68 + 0x80, buffer86);

                byte[] buffer87 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
                PS3.SetMemory(0x026FCE26 + 0x80, buffer87);

                byte[] buffer89 = BitConverter.GetBytes(Convert.ToInt32(7.ToString()));
                PS3.SetMemory(0x026FCE32 + 0x80, buffer89);

            // Medals Tab 6
            
                byte[] buffer90 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
                PS3.SetMemory(0x026FCE74 + 0x80, buffer90);

                byte[] buffer91 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
                PS3.SetMemory(0x026FCE38 + 0x80, buffer91);

                byte[] buffer92 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
                PS3.SetMemory(0x026FCE4A + 0x80, buffer92);

                byte[] buffer93 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
                PS3.SetMemory(0x026FCE7A + 0x80, buffer93);

                byte[] buffer94 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCE50 + 0x80, buffer94);

                byte[] buffer95 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCE44 + 0x80, buffer95);

                byte[] buffer96 = BitConverter.GetBytes(Convert.ToInt32(1.ToString())); //S Sentry Gun
                PS3.SetMemory(0x026FCE98 + 0x80, buffer96);

                byte[] buffer97 = BitConverter.GetBytes(Convert.ToInt32(7.ToString())); //S Hunter Killer
                PS3.SetMemory(0x026FCE62 + 0x80, buffer97);

                byte[] buffer98 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //S Lodestar
                PS3.SetMemory(0x026FCE8C + 0x80, buffer98);

                byte[] buffer100 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
                PS3.SetMemory(0x026FCE56 + 0x80, buffer100);

                byte[] buffer101 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //S K9
                PS3.SetMemory(0x026FCE3E + 0x80, buffer101);

                byte[] buffer102 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
                PS3.SetMemory(0x026FCE5C + 0x80, buffer102);

                byte[] buffer103 = BitConverter.GetBytes(Convert.ToInt32(6.ToString()));
                PS3.SetMemory(0x026FCE86 + 0x80, buffer103);
        }

        private void LegitMedals()
        {
            byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
            PS3.SetMemory(0x026FCD72 + 0x80, buffer);

            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
            PS3.SetMemory(0x026FCD66 + 0x80, buffer2);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(8.ToString()));
            PS3.SetMemory(0x026FCD60 + 0x80, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(15.ToString()));
            PS3.SetMemory(0x026FCD5A + 0x80, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(39.ToString()));
            PS3.SetMemory(0x026FCD54 + 0x80, buffer5);

            byte[] buffer6 = BitConverter.GetBytes(Convert.ToInt32(78.ToString()));
            PS3.SetMemory(0x026FCD4E + 0x80, buffer6);

            byte[] buffer7 = BitConverter.GetBytes(Convert.ToInt32(195.ToString()));
            PS3.SetMemory(0x026FCD6C + 0x80, buffer7);

            byte[] buffer8 = BitConverter.GetBytes(Convert.ToInt32(372.ToString()));
            PS3.SetMemory(0x026FCDAE + 0x80, buffer8);

            byte[] buffer9 = BitConverter.GetBytes(Convert.ToInt32(243.ToString()));
            PS3.SetMemory(0x026FCDB4 + 0x80, buffer9);

            byte[] buffer11 = BitConverter.GetBytes(Convert.ToInt32(111.ToString()));
            PS3.SetMemory(0x026FCDBA + 0x80, buffer11);

            byte[] buffer22 = BitConverter.GetBytes(Convert.ToInt32(78.ToString()));
            PS3.SetMemory(0x026FCDC0 + 0x80, buffer22);

            byte[] buffer33 = BitConverter.GetBytes(Convert.ToInt32(61.ToString()));
            PS3.SetMemory(0x026FCDC6 + 0x80, buffer33);

            byte[] buffer44 = BitConverter.GetBytes(Convert.ToInt32(20.ToString()));
            PS3.SetMemory(0x026FCDCC + 0x80, buffer44);

            byte[] buffer55 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
            PS3.SetMemory(0x026FCDD2 + 0x80, buffer55);

            byte[] buffer66 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
            PS3.SetMemory(0x026FCDD8 + 0x80, buffer66);

            byte[] buffer77 = BitConverter.GetBytes(Convert.ToInt32(9.ToString()));
            PS3.SetMemory(0x026FCEC2 + 0x80, buffer77);

            byte[] buffer88 = BitConverter.GetBytes(Convert.ToInt32(310.ToString()));
            PS3.SetMemory(0x026FCC6A + 0x80, buffer88);

            byte[] buffer99 = BitConverter.GetBytes(Convert.ToInt32(517.ToString()));
            PS3.SetMemory(0x026FCCEE + 0x80, buffer99);

            // Medals Tab 1

            byte[] buffer111 = BitConverter.GetBytes(Convert.ToInt32(32.ToString()));
            PS3.SetMemory(0x026FCCCA + 0x80, buffer111);

            byte[] buffer222 = BitConverter.GetBytes(Convert.ToInt32(22.ToString()));
            PS3.SetMemory(0x026FCB92 + 0x80, buffer222);

            byte[] buffer333 = BitConverter.GetBytes(Convert.ToInt32(18.ToString()));
            PS3.SetMemory(0x026FCCE8 + 0x80, buffer333);

            byte[] buffer444 = BitConverter.GetBytes(Convert.ToInt32(7.ToString())); //Bankrupted
            PS3.SetMemory(0x026FCD2A + 0x80, buffer444);

            byte[] buffer555 = BitConverter.GetBytes(Convert.ToInt32(4.ToString()));
            PS3.SetMemory(0x026FCB98 + 0x80, buffer555);

            byte[] buffer666 = BitConverter.GetBytes(Convert.ToInt32(11.ToString()));
            PS3.SetMemory(0x026FCD06 + 0x80, buffer666);

            byte[] buffer777 = BitConverter.GetBytes(Convert.ToInt32(40.ToString())); //Blackout
            PS3.SetMemory(0x026FCC46 + 0x80, buffer777);

            byte[] buffer888 = BitConverter.GetBytes(Convert.ToInt32(10.ToString()));
            PS3.SetMemory(0x026FCBFE + 0x80, buffer888);

            byte[] buffer999 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
            PS3.SetMemory(0x026FCCFA + 0x80, buffer999);

            byte[] buffer1111 = BitConverter.GetBytes(Convert.ToInt32(6.ToString())); //Buzz Kill
            PS3.SetMemory(0x026FCEB0 + 0x80, buffer1111);

            byte[] buffer2222 = BitConverter.GetBytes(Convert.ToInt32(11.ToString()));
            PS3.SetMemory(0x026FCC04 + 0x80, buffer2222);

            byte[] buffer3333 = BitConverter.GetBytes(Convert.ToInt32(19.ToString()));
            PS3.SetMemory(0x026FCBA4 + 0x80, buffer3333);

            byte[] buffer4444 = BitConverter.GetBytes(Convert.ToInt32(8.ToString())); //Bullseye
            PS3.SetMemory(0x026FCD9C + 0x80, buffer4444);

            byte[] buffer5555 = BitConverter.GetBytes(Convert.ToInt32(17.ToString()));
            PS3.SetMemory(0x026FCB8C + 0x80, buffer5555);

            byte[] buffer6666 = BitConverter.GetBytes(Convert.ToInt32(18.ToString())); //Boomstick
            PS3.SetMemory(0x026FCDDE + 0x80, buffer6666);

            byte[] buffer7777 = BitConverter.GetBytes(Convert.ToInt32(9.ToString()));
            PS3.SetMemory(0x026FCD96 + 0x80, buffer7777);

            byte[] buffer8888 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
            PS3.SetMemory(0x026FCCBE + 0x80, buffer8888);

            byte[] buffer9999 = BitConverter.GetBytes(Convert.ToInt32(41.ToString()));
            PS3.SetMemory(0x026FCD36 + 0x80, buffer9999);

            // Medals Tab 2

            byte[] buffer12 = BitConverter.GetBytes(Convert.ToInt32(31.ToString()));
            PS3.SetMemory(0x026FCE20 + 0x80, buffer12);

            byte[] buffer13 = BitConverter.GetBytes(Convert.ToInt32(11.ToString()));
            PS3.SetMemory(0x026FCC88 + 0x80, buffer13);

            byte[] buffer14 = BitConverter.GetBytes(Convert.ToInt32(21.ToString()));
            PS3.SetMemory(0x026FCC76 + 0x80, buffer14);

            byte[] buffer15 = BitConverter.GetBytes(Convert.ToInt32(49.ToString()));
            PS3.SetMemory(0x026FCBD4 + 0x80, buffer15);

            byte[] buffer16 = BitConverter.GetBytes(Convert.ToInt32(55.ToString()));
            PS3.SetMemory(0x026FCBBC + 0x80, buffer16);

            byte[] buffer17 = BitConverter.GetBytes(Convert.ToInt32(69.ToString())); //Clutch SND
            PS3.SetMemory(0x026FCBE0 + 0x80, buffer17);

            byte[] buffer18 = BitConverter.GetBytes(Convert.ToInt32(69.ToString()));
            PS3.SetMemory(0x026FCECE + 0x80, buffer18);

            byte[] buffer19 = BitConverter.GetBytes(Convert.ToInt32(11.ToString())); //Deadeye
            PS3.SetMemory(0x026FCBC8 + 0x80, buffer19);

            byte[] buffer21 = BitConverter.GetBytes(Convert.ToInt32(56.ToString())); //Denied Flag
            PS3.SetMemory(0x026FCD48 + 0x80, buffer21);

            byte[] buffer20 = BitConverter.GetBytes(Convert.ToInt32(61.ToString()));
            PS3.SetMemory(0x026FCD3C + 0x80, buffer20);

            byte[] buffer23 = BitConverter.GetBytes(Convert.ToInt32(30.ToString())); //Decimated
            PS3.SetMemory(0x026FCBCE + 0x80, buffer23);

            byte[] buffer24 = BitConverter.GetBytes(Convert.ToInt32(38.ToString()));
            PS3.SetMemory(0x026FCBF8 + 0x80, buffer24);

            byte[] buffer25 = BitConverter.GetBytes(Convert.ToInt32(13.ToString()));
            PS3.SetMemory(0x026FCCDC + 0x80, buffer25);

            byte[] buffer26 = BitConverter.GetBytes(Convert.ToInt32(36.ToString())); //Extermination
            PS3.SetMemory(0x026FCC10 + 0x80, buffer26);

            byte[] buffer27 = BitConverter.GetBytes(Convert.ToInt32(11.ToString()));
            PS3.SetMemory(0x026FCDA2 + 0x80, buffer27);

            byte[] buffer28 = BitConverter.GetBytes(Convert.ToInt32(42.ToString()));
            PS3.SetMemory(0x026FCCC4 + 0x80, buffer28);

            byte[] buffer29 = BitConverter.GetBytes(Convert.ToInt32(10.ToString())); //Flyswatter
            PS3.SetMemory(0x026FCC1C + 0x80, buffer29);

            byte[] buffer10 = BitConverter.GetBytes(Convert.ToInt32(71.ToString()));
            PS3.SetMemory(0x026FCC58 + 0x80, buffer10);

            //Medals Tab 3

            byte[] buffer31 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
            PS3.SetMemory(0x026FCBEC + 0x80, buffer31);

            byte[] buffer32 = BitConverter.GetBytes(Convert.ToInt32(16.ToString()));
            PS3.SetMemory(0x026FCD7E + 0x80, buffer32);

            byte[] buffer30 = BitConverter.GetBytes(Convert.ToInt32(20.ToString())); //Gun Expert
            PS3.SetMemory(0x026FCDA8 + 0x80, buffer30);

            byte[] buffer34 = BitConverter.GetBytes(Convert.ToInt32(19.ToString()));
            PS3.SetMemory(0x026FCD1E + 0x80, buffer34);

            byte[] buffer35 = BitConverter.GetBytes(Convert.ToInt32(31.ToString()));
            PS3.SetMemory(0x026FCC82 + 0x80, buffer35);

            byte[] buffer36 = BitConverter.GetBytes(Convert.ToInt32(55.ToString())); //Hero
            PS3.SetMemory(0x026FCBDA + 0x80, buffer36);

            byte[] buffer37 = BitConverter.GetBytes(Convert.ToInt32(19.ToString()));
            PS3.SetMemory(0x026FCBB0 + 0x80, buffer37);

            byte[] buffer38 = BitConverter.GetBytes(Convert.ToInt32(8.ToString()));
            PS3.SetMemory(0x026FCC3A + 0x80, buffer38);

            byte[] buffer39 = BitConverter.GetBytes(Convert.ToInt32(17.ToString()));
            PS3.SetMemory(0x026FCCB8 + 0x80, buffer39);

            byte[] buffer40 = BitConverter.GetBytes(Convert.ToInt32(20.ToString())); //Intercepted
            PS3.SetMemory(0x026FCC28 + 0x80, buffer40);

            byte[] buffer41 = BitConverter.GetBytes(Convert.ToInt32(68.ToString())); //Kaboom
            PS3.SetMemory(0x026FCE02 + 0x80, buffer41);

            byte[] buffer42 = BitConverter.GetBytes(Convert.ToInt32(98.ToString()));
            PS3.SetMemory(0x026FCD8A + 0x80, buffer42);

            byte[] buffer43 = BitConverter.GetBytes(Convert.ToInt32(15.ToString())); //No Tip
            PS3.SetMemory(0x026FCC40 + 0x80, buffer43);

            byte[] buffer45 = BitConverter.GetBytes(Convert.ToInt32(70.ToString()));
            PS3.SetMemory(0x026FCCD6 + 0x80, buffer45);

            byte[] buffer46 = BitConverter.GetBytes(Convert.ToInt32(69.ToString())); //Opening Move
            PS3.SetMemory(0x026FCDE4 + 0x80, buffer46);

            byte[] buffer47 = BitConverter.GetBytes(Convert.ToInt32(12.ToString()));
            PS3.SetMemory(0x026FCCF4 + 0x80, buffer47);

            byte[] buffer48 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
            PS3.SetMemory(0x026FCC70 + 0x80, buffer48);

            byte[] buffer49 = BitConverter.GetBytes(Convert.ToInt32(8.ToString()));
            PS3.SetMemory(0x026FCC5E + 0x80, buffer49);

            // Medals Tab 4

            byte[] buffer50 = BitConverter.GetBytes(Convert.ToInt32(31.ToString()));
            PS3.SetMemory(0x026FCD78 + 0x80, buffer50);

            byte[] buffer51 = BitConverter.GetBytes(Convert.ToInt32(44.ToString()));
            PS3.SetMemory(0x026FCD24 + 0x80, buffer51);

            byte[] buffer52 = BitConverter.GetBytes(Convert.ToInt32(18.ToString())); //Raining Death
            PS3.SetMemory(0x026FCE08 + 0x80, buffer52);

            byte[] buffer53 = BitConverter.GetBytes(Convert.ToInt32(70.ToString()));
            PS3.SetMemory(0x026FCE1A + 0x80, buffer53);

            byte[] buffer54 = BitConverter.GetBytes(Convert.ToInt32(29.ToString()));
            PS3.SetMemory(0x026FCC0A + 0x80, buffer54);

            byte[] buffer56 = BitConverter.GetBytes(Convert.ToInt32(18.ToString())); //Red Baron
            PS3.SetMemory(0x026FCDF6 + 0x80, buffer56);

            byte[] buffer57 = BitConverter.GetBytes(Convert.ToInt32(17.ToString()));
            PS3.SetMemory(0x026FCE14 + 0x80, buffer57);

            byte[] buffer58 = BitConverter.GetBytes(Convert.ToInt32(20.ToString()));
            PS3.SetMemory(0x026FCC22 + 0x80, buffer58);

            byte[] buffer59 = BitConverter.GetBytes(Convert.ToInt32(26.ToString()));
            PS3.SetMemory(0x026FCC34 + 0x80, buffer59);

            byte[] buffer60 = BitConverter.GetBytes(Convert.ToInt32(41.ToString()));
            PS3.SetMemory(0x026FCBF2 + 0x80, buffer60);

            byte[] buffer61 = BitConverter.GetBytes(Convert.ToInt32(104.ToString())); //Savior
            PS3.SetMemory(0x026FCCD0 + 0x80, buffer61);

            byte[] buffer62 = BitConverter.GetBytes(Convert.ToInt32(133.ToString()));
            PS3.SetMemory(0x026FCCAC + 0x80, buffer62);

            byte[] buffer63 = BitConverter.GetBytes(Convert.ToInt32(190.ToString())); //Secure D
            PS3.SetMemory(0x026FCDF0 + 0x80, buffer63);

            byte[] buffer64 = BitConverter.GetBytes(Convert.ToInt32(128.ToString()));
            PS3.SetMemory(0x026FCCD6 + 0x80, buffer64);

            byte[] buffer65 = BitConverter.GetBytes(Convert.ToInt32(58.ToString()));
            PS3.SetMemory(0x026FCD30 + 0x80, buffer65);

            byte[] buffer67 = BitConverter.GetBytes(Convert.ToInt32(4.ToString()));
            PS3.SetMemory(0x026FCCF4 + 0x80, buffer67);

            byte[] buffer68 = BitConverter.GetBytes(Convert.ToInt32(21.ToString()));
            PS3.SetMemory(0x026FCD90 + 0x80, buffer68);

            byte[] buffer69 = BitConverter.GetBytes(Convert.ToInt32(301.ToString()));
            PS3.SetMemory(0x026FCBC2 + 0x80, buffer69);

            // Medals Tab 5

            byte[] buffer70 = BitConverter.GetBytes(Convert.ToInt32(19.ToString()));
            PS3.SetMemory(0x026FCB9E + 0x80, buffer70);

            byte[] buffer71 = BitConverter.GetBytes(Convert.ToInt32(15.ToString()));
            PS3.SetMemory(0x026FCDEA + 0x80, buffer71);

            byte[] buffer72 = BitConverter.GetBytes(Convert.ToInt32(39.ToString())); //Takedown Bomb
            PS3.SetMemory(0x026FCD42 + 0x80, buffer72);

            byte[] buffer73 = BitConverter.GetBytes(Convert.ToInt32(56.ToString()));
            PS3.SetMemory(0x026FCD0C + 0x80, buffer73);

            byte[] buffer74 = BitConverter.GetBytes(Convert.ToInt32(20.ToString()));
            PS3.SetMemory(0x026FCC16 + 0x80, buffer74);

            byte[] buffer75 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
            PS3.SetMemory(0x026FCD00 + 0x80, buffer75);

            byte[] buffer76 = BitConverter.GetBytes(Convert.ToInt32(89.ToString())); //Retrieved
            PS3.SetMemory(0x026FCE14 + 0x80, buffer76);

            byte[] buffer78 = BitConverter.GetBytes(Convert.ToInt32(143.ToString())); //Victory
            PS3.SetMemory(0x026FCEC8 + 0x80, buffer78);

            byte[] buffer79 = BitConverter.GetBytes(Convert.ToInt32(21.ToString()));
            PS3.SetMemory(0x026FCC2E + 0x80, buffer79);

            byte[] buffer80 = BitConverter.GetBytes(Convert.ToInt32(30.ToString())); //Warbeast
            PS3.SetMemory(0x026FCC4C + 0x80, buffer80);

            byte[] buffer81 = BitConverter.GetBytes(Convert.ToInt32(10.ToString()));
            PS3.SetMemory(0x026FCC9A + 0x80, buffer81);

            byte[] buffer82 = BitConverter.GetBytes(Convert.ToInt32(15.ToString()));
            PS3.SetMemory(0x026FCBB6 + 0x80, buffer82);

            byte[] buffer83 = BitConverter.GetBytes(Convert.ToInt32(76.ToString())); //Shared RCXD
            PS3.SetMemory(0x026FCE80 + 0x80, buffer83);

            byte[] buffer84 = BitConverter.GetBytes(Convert.ToInt32(44.ToString()));
            PS3.SetMemory(0x026FCEA4 + 0x80, buffer84);

            byte[] buffer85 = BitConverter.GetBytes(Convert.ToInt32(1.ToString())); //Shared VSAT
            PS3.SetMemory(0x026FCE92 + 0x80, buffer85);

            byte[] buffer86 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //Shared Swarm
            PS3.SetMemory(0x026FCE68 + 0x80, buffer86);

            byte[] buffer87 = BitConverter.GetBytes(Convert.ToInt32(7.ToString()));
            PS3.SetMemory(0x026FCE26 + 0x80, buffer87);

            byte[] buffer89 = BitConverter.GetBytes(Convert.ToInt32(18.ToString()));
            PS3.SetMemory(0x026FCE32 + 0x80, buffer89);

            // Medals Tab 6

            byte[] buffer90 = BitConverter.GetBytes(Convert.ToInt32(10.ToString()));
            PS3.SetMemory(0x026FCE74 + 0x80, buffer90);

            byte[] buffer91 = BitConverter.GetBytes(Convert.ToInt32(6.ToString()));
            PS3.SetMemory(0x026FCE38 + 0x80, buffer91);

            byte[] buffer92 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
            PS3.SetMemory(0x026FCE4A + 0x80, buffer92);

            byte[] buffer93 = BitConverter.GetBytes(Convert.ToInt32(2.ToString()));
            PS3.SetMemory(0x026FCE7A + 0x80, buffer93);

            byte[] buffer94 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
            PS3.SetMemory(0x026FCE50 + 0x80, buffer94);

            byte[] buffer95 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
            PS3.SetMemory(0x026FCE44 + 0x80, buffer95);

            byte[] buffer96 = BitConverter.GetBytes(Convert.ToInt32(5.ToString())); //S Sentry Gun
            PS3.SetMemory(0x026FCE98 + 0x80, buffer96);

            byte[] buffer97 = BitConverter.GetBytes(Convert.ToInt32(19.ToString())); //S Hunter Killer
            PS3.SetMemory(0x026FCE62 + 0x80, buffer97);

            byte[] buffer98 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //S Lodestar
            PS3.SetMemory(0x026FCE8C + 0x80, buffer98);

            byte[] buffer100 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
            PS3.SetMemory(0x026FCE56 + 0x80, buffer100);

            byte[] buffer101 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //S K9
            PS3.SetMemory(0x026FCE3E + 0x80, buffer101);

            byte[] buffer102 = BitConverter.GetBytes(Convert.ToInt32(11.ToString()));
            PS3.SetMemory(0x026FCE5C + 0x80, buffer102);

            byte[] buffer103 = BitConverter.GetBytes(Convert.ToInt32(5.ToString()));
            PS3.SetMemory(0x026FCE86 + 0x80, buffer103);
        }

        private void ProMedals()
        {
            byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(49.ToString())); //Unstoppable
            PS3.SetMemory(0x026FCD72 + 0x80, buffer);

            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(17.ToString())); //Nuclear
            PS3.SetMemory(0x026FCD66 + 0x80, buffer2);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(51.ToString())); //Brutal
            PS3.SetMemory(0x026FCD60 + 0x80, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(149.ToString())); //Relentless
            PS3.SetMemory(0x026FCD5A + 0x80, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(265.ToString())); //Ruthless
            PS3.SetMemory(0x026FCD54 + 0x80, buffer5);

            byte[] buffer6 = BitConverter.GetBytes(Convert.ToInt32(598.ToString())); //No Mercy
            PS3.SetMemory(0x026FCD4E + 0x80, buffer6);

            byte[] buffer7 = BitConverter.GetBytes(Convert.ToInt32(1693.ToString())); //Bloodthirsty
            PS3.SetMemory(0x026FCD6C + 0x80, buffer7);

            byte[] buffer8 = BitConverter.GetBytes(Convert.ToInt32(788.ToString())); //Double Kill
            PS3.SetMemory(0x026FCDAE + 0x80, buffer8);

            byte[] buffer9 = BitConverter.GetBytes(Convert.ToInt32(600.ToString())); //Triple
            PS3.SetMemory(0x026FCDB4 + 0x80, buffer9);

            byte[] buffer11 = BitConverter.GetBytes(Convert.ToInt32(414.ToString())); //Fury
            PS3.SetMemory(0x026FCDBA + 0x80, buffer11);

            byte[] buffer22 = BitConverter.GetBytes(Convert.ToInt32(322.ToString())); //Frenzy
            PS3.SetMemory(0x026FCDC0 + 0x80, buffer22);

            byte[] buffer33 = BitConverter.GetBytes(Convert.ToInt32(172.ToString())); //Super
            PS3.SetMemory(0x026FCDC6 + 0x80, buffer33);

            byte[] buffer44 = BitConverter.GetBytes(Convert.ToInt32(109.ToString())); //Mega
            PS3.SetMemory(0x026FCDCC + 0x80, buffer44);

            byte[] buffer55 = BitConverter.GetBytes(Convert.ToInt32(58.ToString())); //Ultra
            PS3.SetMemory(0x026FCDD2 + 0x80, buffer55);

            byte[] buffer66 = BitConverter.GetBytes(Convert.ToInt32(13.ToString())); //Killchain
            PS3.SetMemory(0x026FCDD8 + 0x80, buffer66);

            byte[] buffer77 = BitConverter.GetBytes(Convert.ToInt32(31.ToString())); //Quad Feed
            PS3.SetMemory(0x026FCEC2 + 0x80, buffer77);

            byte[] buffer88 = BitConverter.GetBytes(Convert.ToInt32(705.ToString())); //First Blood
            PS3.SetMemory(0x026FCC6A + 0x80, buffer88);

            byte[] buffer99 = BitConverter.GetBytes(Convert.ToInt32(1864.ToString())); //Avenger
            PS3.SetMemory(0x026FCCEE + 0x80, buffer99);

            //Medals Tab 1

            byte[] buffer111 = BitConverter.GetBytes(Convert.ToInt32(142.ToString()));
            PS3.SetMemory(0x026FCCCA + 0x80, buffer111);

            byte[] buffer222 = BitConverter.GetBytes(Convert.ToInt32(98.ToString()));
            PS3.SetMemory(0x026FCB92 + 0x80, buffer222);

            byte[] buffer333 = BitConverter.GetBytes(Convert.ToInt32(88.ToString()));
            PS3.SetMemory(0x026FCCE8 + 0x80, buffer333);

            byte[] buffer444 = BitConverter.GetBytes(Convert.ToInt32(65.ToString())); //Bankrupted
            PS3.SetMemory(0x026FCD2A + 0x80, buffer444);

            byte[] buffer555 = BitConverter.GetBytes(Convert.ToInt32(45.ToString()));
            PS3.SetMemory(0x026FCB98 + 0x80, buffer555);

            byte[] buffer666 = BitConverter.GetBytes(Convert.ToInt32(39.ToString()));
            PS3.SetMemory(0x026FCD06 + 0x80, buffer666);

            byte[] buffer777 = BitConverter.GetBytes(Convert.ToInt32(123.ToString())); //Blackout
            PS3.SetMemory(0x026FCC46 + 0x80, buffer777);

            byte[] buffer888 = BitConverter.GetBytes(Convert.ToInt32(35.ToString()));
            PS3.SetMemory(0x026FCBFE + 0x80, buffer888);

            byte[] buffer999 = BitConverter.GetBytes(Convert.ToInt32(31.ToString()));
            PS3.SetMemory(0x026FCCFA + 0x80, buffer999);

            byte[] buffer1111 = BitConverter.GetBytes(Convert.ToInt32(29.ToString())); //Buzz Kill
            PS3.SetMemory(0x026FCEB0 + 0x80, buffer1111);

            byte[] buffer2222 = BitConverter.GetBytes(Convert.ToInt32(54.ToString()));
            PS3.SetMemory(0x026FCC04 + 0x80, buffer2222);

            byte[] buffer3333 = BitConverter.GetBytes(Convert.ToInt32(76.ToString()));
            PS3.SetMemory(0x026FCBA4 + 0x80, buffer3333);

            byte[] buffer4444 = BitConverter.GetBytes(Convert.ToInt32(28.ToString())); //Bullseye
            PS3.SetMemory(0x026FCD9C + 0x80, buffer4444);

            byte[] buffer5555 = BitConverter.GetBytes(Convert.ToInt32(43.ToString()));
            PS3.SetMemory(0x026FCB8C + 0x80, buffer5555);

            byte[] buffer6666 = BitConverter.GetBytes(Convert.ToInt32(31.ToString())); //Boomstick
            PS3.SetMemory(0x026FCDDE + 0x80, buffer6666);

            byte[] buffer7777 = BitConverter.GetBytes(Convert.ToInt32(54.ToString()));
            PS3.SetMemory(0x026FCD96 + 0x80, buffer7777);

            byte[] buffer8888 = BitConverter.GetBytes(Convert.ToInt32(76.ToString()));
            PS3.SetMemory(0x026FCCBE + 0x80, buffer8888);

            byte[] buffer9999 = BitConverter.GetBytes(Convert.ToInt32(213.ToString()));
            PS3.SetMemory(0x026FCD36 + 0x80, buffer9999);

            // Medals Tab 2

            byte[] buffer12 = BitConverter.GetBytes(Convert.ToInt32(78.ToString()));
            PS3.SetMemory(0x026FCE20 + 0x80, buffer12);

            byte[] buffer13 = BitConverter.GetBytes(Convert.ToInt32(42.ToString()));
            PS3.SetMemory(0x026FCC88 + 0x80, buffer13);

            byte[] buffer14 = BitConverter.GetBytes(Convert.ToInt32(56.ToString()));
            PS3.SetMemory(0x026FCC76 + 0x80, buffer14);

            byte[] buffer15 = BitConverter.GetBytes(Convert.ToInt32(101.ToString()));
            PS3.SetMemory(0x026FCBD4 + 0x80, buffer15);

            byte[] buffer16 = BitConverter.GetBytes(Convert.ToInt32(142.ToString()));
            PS3.SetMemory(0x026FCBBC + 0x80, buffer16);

            byte[] buffer17 = BitConverter.GetBytes(Convert.ToInt32(231.ToString())); //Clutch SND
            PS3.SetMemory(0x026FCBE0 + 0x80, buffer17);

            byte[] buffer18 = BitConverter.GetBytes(Convert.ToInt32(166.ToString()));
            PS3.SetMemory(0x026FCECE + 0x80, buffer18);

            byte[] buffer19 = BitConverter.GetBytes(Convert.ToInt32(55.ToString())); //Deadeye
            PS3.SetMemory(0x026FCBC8 + 0x80, buffer19);

            byte[] buffer21 = BitConverter.GetBytes(Convert.ToInt32(201.ToString())); //Denied Flag
            PS3.SetMemory(0x026FCD48 + 0x80, buffer21);

            byte[] buffer20 = BitConverter.GetBytes(Convert.ToInt32(179.ToString()));
            PS3.SetMemory(0x026FCD3C + 0x80, buffer20);

            byte[] buffer23 = BitConverter.GetBytes(Convert.ToInt32(90.ToString())); //Decimated
            PS3.SetMemory(0x026FCBCE + 0x80, buffer23);

            byte[] buffer24 = BitConverter.GetBytes(Convert.ToInt32(121.ToString()));
            PS3.SetMemory(0x026FCBF8 + 0x80, buffer24);

            byte[] buffer25 = BitConverter.GetBytes(Convert.ToInt32(39.ToString()));
            PS3.SetMemory(0x026FCCDC + 0x80, buffer25);

            byte[] buffer26 = BitConverter.GetBytes(Convert.ToInt32(89.ToString())); //Extermination
            PS3.SetMemory(0x026FCC10 + 0x80, buffer26);

            byte[] buffer27 = BitConverter.GetBytes(Convert.ToInt32(81.ToString()));
            PS3.SetMemory(0x026FCDA2 + 0x80, buffer27);

            byte[] buffer28 = BitConverter.GetBytes(Convert.ToInt32(55.ToString()));
            PS3.SetMemory(0x026FCCC4 + 0x80, buffer28);

            byte[] buffer29 = BitConverter.GetBytes(Convert.ToInt32(38.ToString())); //Flyswatter
            PS3.SetMemory(0x026FCC1C + 0x80, buffer29);

            byte[] buffer10 = BitConverter.GetBytes(Convert.ToInt32(310.ToString()));
            PS3.SetMemory(0x026FCC58 + 0x80, buffer10);

            //Medals Tab 3

            byte[] buffer31 = BitConverter.GetBytes(Convert.ToInt32(23.ToString()));
            PS3.SetMemory(0x026FCBEC + 0x80, buffer31);

            byte[] buffer32 = BitConverter.GetBytes(Convert.ToInt32(58.ToString()));
            PS3.SetMemory(0x026FCD7E + 0x80, buffer32);

            byte[] buffer30 = BitConverter.GetBytes(Convert.ToInt32(89.ToString())); //Gun Expert
            PS3.SetMemory(0x026FCDA8 + 0x80, buffer30);

            byte[] buffer34 = BitConverter.GetBytes(Convert.ToInt32(53.ToString()));
            PS3.SetMemory(0x026FCD1E + 0x80, buffer34);

            byte[] buffer35 = BitConverter.GetBytes(Convert.ToInt32(79.ToString()));
            PS3.SetMemory(0x026FCC82 + 0x80, buffer35);

            byte[] buffer36 = BitConverter.GetBytes(Convert.ToInt32(132.ToString())); //Hero
            PS3.SetMemory(0x026FCBDA + 0x80, buffer36);

            byte[] buffer37 = BitConverter.GetBytes(Convert.ToInt32(54.ToString()));
            PS3.SetMemory(0x026FCBB0 + 0x80, buffer37);

            byte[] buffer38 = BitConverter.GetBytes(Convert.ToInt32(48.ToString()));
            PS3.SetMemory(0x026FCC3A + 0x80, buffer38);

            byte[] buffer39 = BitConverter.GetBytes(Convert.ToInt32(43.ToString()));
            PS3.SetMemory(0x026FCCB8 + 0x80, buffer39);

            byte[] buffer40 = BitConverter.GetBytes(Convert.ToInt32(80.ToString())); //Intercepted
            PS3.SetMemory(0x026FCC28 + 0x80, buffer40);

            byte[] buffer41 = BitConverter.GetBytes(Convert.ToInt32(188.ToString())); //Kaboom
            PS3.SetMemory(0x026FCE02 + 0x80, buffer41);

            byte[] buffer42 = BitConverter.GetBytes(Convert.ToInt32(259.ToString()));
            PS3.SetMemory(0x026FCD8A + 0x80, buffer42);

            byte[] buffer43 = BitConverter.GetBytes(Convert.ToInt32(65.ToString())); //No Tip
            PS3.SetMemory(0x026FCC40 + 0x80, buffer43);

            byte[] buffer45 = BitConverter.GetBytes(Convert.ToInt32(210.ToString()));
            PS3.SetMemory(0x026FCCD6 + 0x80, buffer45);

            byte[] buffer46 = BitConverter.GetBytes(Convert.ToInt32(261.ToString())); //Opening Move
            PS3.SetMemory(0x026FCDE4 + 0x80, buffer46);

            byte[] buffer47 = BitConverter.GetBytes(Convert.ToInt32(45.ToString()));
            PS3.SetMemory(0x026FCCF4 + 0x80, buffer47);

            byte[] buffer48 = BitConverter.GetBytes(Convert.ToInt32(33.ToString()));
            PS3.SetMemory(0x026FCC70 + 0x80, buffer48);

            byte[] buffer49 = BitConverter.GetBytes(Convert.ToInt32(39.ToString()));
            PS3.SetMemory(0x026FCC5E + 0x80, buffer49);

            // Medals Tab 4

            byte[] buffer50 = BitConverter.GetBytes(Convert.ToInt32(98.ToString()));
            PS3.SetMemory(0x026FCD78 + 0x80, buffer50);

            byte[] buffer51 = BitConverter.GetBytes(Convert.ToInt32(102.ToString()));
            PS3.SetMemory(0x026FCD24 + 0x80, buffer51);

            byte[] buffer52 = BitConverter.GetBytes(Convert.ToInt32(67.ToString())); //Raining Death
            PS3.SetMemory(0x026FCE08 + 0x80, buffer52);

            byte[] buffer53 = BitConverter.GetBytes(Convert.ToInt32(151.ToString()));
            PS3.SetMemory(0x026FCE1A + 0x80, buffer53);

            byte[] buffer54 = BitConverter.GetBytes(Convert.ToInt32(99.ToString()));
            PS3.SetMemory(0x026FCC0A + 0x80, buffer54);

            byte[] buffer56 = BitConverter.GetBytes(Convert.ToInt32(39.ToString())); //Red Baron
            PS3.SetMemory(0x026FCDF6 + 0x80, buffer56);

            byte[] buffer57 = BitConverter.GetBytes(Convert.ToInt32(76.ToString()));
            PS3.SetMemory(0x026FCE14 + 0x80, buffer57);

            byte[] buffer58 = BitConverter.GetBytes(Convert.ToInt32(88.ToString()));
            PS3.SetMemory(0x026FCC22 + 0x80, buffer58);

            byte[] buffer59 = BitConverter.GetBytes(Convert.ToInt32(59.ToString()));
            PS3.SetMemory(0x026FCC34 + 0x80, buffer59);

            byte[] buffer60 = BitConverter.GetBytes(Convert.ToInt32(69.ToString()));
            PS3.SetMemory(0x026FCBF2 + 0x80, buffer60);

            byte[] buffer61 = BitConverter.GetBytes(Convert.ToInt32(390.ToString())); //Savior
            PS3.SetMemory(0x026FCCD0 + 0x80, buffer61);

            byte[] buffer62 = BitConverter.GetBytes(Convert.ToInt32(333.ToString()));
            PS3.SetMemory(0x026FCCAC + 0x80, buffer62);

            byte[] buffer63 = BitConverter.GetBytes(Convert.ToInt32(419.ToString())); //Secure D
            PS3.SetMemory(0x026FCDF0 + 0x80, buffer63);

            byte[] buffer64 = BitConverter.GetBytes(Convert.ToInt32(470.ToString()));
            PS3.SetMemory(0x026FCCD6 + 0x80, buffer64);

            byte[] buffer65 = BitConverter.GetBytes(Convert.ToInt32(122.ToString()));
            PS3.SetMemory(0x026FCD30 + 0x80, buffer65);

            byte[] buffer67 = BitConverter.GetBytes(Convert.ToInt32(48.ToString()));
            PS3.SetMemory(0x026FCCF4 + 0x80, buffer67);

            byte[] buffer68 = BitConverter.GetBytes(Convert.ToInt32(78.ToString()));
            PS3.SetMemory(0x026FCD90 + 0x80, buffer68);

            byte[] buffer69 = BitConverter.GetBytes(Convert.ToInt32(805.ToString()));
            PS3.SetMemory(0x026FCBC2 + 0x80, buffer69);

            // Medals Tab 5

            byte[] buffer70 = BitConverter.GetBytes(Convert.ToInt32(65.ToString()));
            PS3.SetMemory(0x026FCB9E + 0x80, buffer70);

            byte[] buffer71 = BitConverter.GetBytes(Convert.ToInt32(49.ToString()));
            PS3.SetMemory(0x026FCDEA + 0x80, buffer71);

            byte[] buffer72 = BitConverter.GetBytes(Convert.ToInt32(178.ToString())); //Takedown Bomb
            PS3.SetMemory(0x026FCD42 + 0x80, buffer72);

            byte[] buffer73 = BitConverter.GetBytes(Convert.ToInt32(209.ToString()));
            PS3.SetMemory(0x026FCD0C + 0x80, buffer73);

            byte[] buffer74 = BitConverter.GetBytes(Convert.ToInt32(121.ToString()));
            PS3.SetMemory(0x026FCC16 + 0x80, buffer74);

            byte[] buffer75 = BitConverter.GetBytes(Convert.ToInt32(34.ToString()));
            PS3.SetMemory(0x026FCD00 + 0x80, buffer75);

            byte[] buffer76 = BitConverter.GetBytes(Convert.ToInt32(300.ToString())); //Retrieved
            PS3.SetMemory(0x026FCE14 + 0x80, buffer76);

            byte[] buffer78 = BitConverter.GetBytes(Convert.ToInt32(299.ToString())); //Victory
            PS3.SetMemory(0x026FCEC8 + 0x80, buffer78);

            byte[] buffer79 = BitConverter.GetBytes(Convert.ToInt32(174.ToString()));
            PS3.SetMemory(0x026FCC2E + 0x80, buffer79);

            byte[] buffer80 = BitConverter.GetBytes(Convert.ToInt32(145.ToString())); //Warbeast
            PS3.SetMemory(0x026FCC4C + 0x80, buffer80);

            byte[] buffer81 = BitConverter.GetBytes(Convert.ToInt32(99.ToString()));
            PS3.SetMemory(0x026FCC9A + 0x80, buffer81);

            byte[] buffer82 = BitConverter.GetBytes(Convert.ToInt32(100.ToString()));
            PS3.SetMemory(0x026FCBB6 + 0x80, buffer82);

            byte[] buffer83 = BitConverter.GetBytes(Convert.ToInt32(253.ToString())); //Shared RCXD
            PS3.SetMemory(0x026FCE80 + 0x80, buffer83);

            byte[] buffer84 = BitConverter.GetBytes(Convert.ToInt32(102.ToString()));
            PS3.SetMemory(0x026FCEA4 + 0x80, buffer84);

            byte[] buffer85 = BitConverter.GetBytes(Convert.ToInt32(9.ToString())); //Shared VSAT
            PS3.SetMemory(0x026FCE92 + 0x80, buffer85);

            byte[] buffer86 = BitConverter.GetBytes(Convert.ToInt32(1.ToString())); //Shared Swarm
            PS3.SetMemory(0x026FCE68 + 0x80, buffer86);

            byte[] buffer87 = BitConverter.GetBytes(Convert.ToInt32(15.ToString()));
            PS3.SetMemory(0x026FCE26 + 0x80, buffer87);

            byte[] buffer89 = BitConverter.GetBytes(Convert.ToInt32(37.ToString()));
            PS3.SetMemory(0x026FCE32 + 0x80, buffer89);

            // Medals Tab 6

            byte[] buffer90 = BitConverter.GetBytes(Convert.ToInt32(32.ToString()));
            PS3.SetMemory(0x026FCE74 + 0x80, buffer90);

            byte[] buffer91 = BitConverter.GetBytes(Convert.ToInt32(25.ToString()));
            PS3.SetMemory(0x026FCE38 + 0x80, buffer91);

            byte[] buffer92 = BitConverter.GetBytes(Convert.ToInt32(12.ToString()));
            PS3.SetMemory(0x026FCE4A + 0x80, buffer92);

            byte[] buffer93 = BitConverter.GetBytes(Convert.ToInt32(18.ToString()));
            PS3.SetMemory(0x026FCE7A + 0x80, buffer93);

            byte[] buffer94 = BitConverter.GetBytes(Convert.ToInt32(4.ToString()));
            PS3.SetMemory(0x026FCE50 + 0x80, buffer94);

            byte[] buffer95 = BitConverter.GetBytes(Convert.ToInt32(1.ToString()));
            PS3.SetMemory(0x026FCE44 + 0x80, buffer95);

            byte[] buffer96 = BitConverter.GetBytes(Convert.ToInt32(19.ToString())); //S Sentry Gun
            PS3.SetMemory(0x026FCE98 + 0x80, buffer96);

            byte[] buffer97 = BitConverter.GetBytes(Convert.ToInt32(40.ToString())); //S Hunter Killer
            PS3.SetMemory(0x026FCE62 + 0x80, buffer97);

            byte[] buffer98 = BitConverter.GetBytes(Convert.ToInt32(1.ToString())); //S Lodestar
            PS3.SetMemory(0x026FCE8C + 0x80, buffer98);

            byte[] buffer100 = BitConverter.GetBytes(Convert.ToInt32(0.ToString()));
            PS3.SetMemory(0x026FCE56 + 0x80, buffer100);

            byte[] buffer101 = BitConverter.GetBytes(Convert.ToInt32(0.ToString())); //S K9
            PS3.SetMemory(0x026FCE3E + 0x80, buffer101);

            byte[] buffer102 = BitConverter.GetBytes(Convert.ToInt32(31.ToString()));
            PS3.SetMemory(0x026FCE5C + 0x80, buffer102);

            byte[] buffer103 = BitConverter.GetBytes(Convert.ToInt32(29.ToString()));
            PS3.SetMemory(0x026FCE86 + 0x80, buffer103);
        }

        private void InsaneMedals()
        {
            byte[] buffer = BitConverter.GetBytes(Convert.ToInt32(406.ToString())); //Unstoppable
            PS3.SetMemory(0x026FCD72 + 0x80, buffer);

            byte[] buffer2 = BitConverter.GetBytes(Convert.ToInt32(128.ToString())); //Nuclear
            PS3.SetMemory(0x026FCD66 + 0x80, buffer2);

            byte[] buffer3 = BitConverter.GetBytes(Convert.ToInt32(330.ToString())); //Brutal
            PS3.SetMemory(0x026FCD60 + 0x80, buffer3);

            byte[] buffer4 = BitConverter.GetBytes(Convert.ToInt32(784.ToString())); //Relentless
            PS3.SetMemory(0x026FCD5A + 0x80, buffer4);

            byte[] buffer5 = BitConverter.GetBytes(Convert.ToInt32(1540.ToString())); //Ruthless
            PS3.SetMemory(0x026FCD54 + 0x80, buffer5);

            byte[] buffer6 = BitConverter.GetBytes(Convert.ToInt32(2316.ToString())); //No Mercy
            PS3.SetMemory(0x026FCD4E + 0x80, buffer6);

            byte[] buffer7 = BitConverter.GetBytes(Convert.ToInt32(3779.ToString())); //Bloodthirsty
            PS3.SetMemory(0x026FCD6C + 0x80, buffer7);

            byte[] buffer8 = BitConverter.GetBytes(Convert.ToInt32(3121.ToString())); //Double Kill
            PS3.SetMemory(0x026FCDAE + 0x80, buffer8);

            byte[] buffer9 = BitConverter.GetBytes(Convert.ToInt32(2569.ToString())); //Triple
            PS3.SetMemory(0x026FCDB4 + 0x80, buffer9);

            byte[] buffer11 = BitConverter.GetBytes(Convert.ToInt32(1665.ToString())); //Fury
            PS3.SetMemory(0x026FCDBA + 0x80, buffer11);

            byte[] buffer22 = BitConverter.GetBytes(Convert.ToInt32(1090.ToString())); //Frenzy
            PS3.SetMemory(0x026FCDC0 + 0x80, buffer22);

            byte[] buffer33 = BitConverter.GetBytes(Convert.ToInt32(622.ToString())); //Super
            PS3.SetMemory(0x026FCDC6 + 0x80, buffer33);

            byte[] buffer44 = BitConverter.GetBytes(Convert.ToInt32(500.ToString())); //Mega
            PS3.SetMemory(0x026FCDCC + 0x80, buffer44);

            byte[] buffer55 = BitConverter.GetBytes(Convert.ToInt32(298.ToString())); //Ultra
            PS3.SetMemory(0x026FCDD2 + 0x80, buffer55);

            byte[] buffer66 = BitConverter.GetBytes(Convert.ToInt32(159.ToString())); //Killchain
            PS3.SetMemory(0x026FCDD8 + 0x80, buffer66);

            byte[] buffer77 = BitConverter.GetBytes(Convert.ToInt32(210.ToString())); //Quad Feed
            PS3.SetMemory(0x026FCEC2 + 0x80, buffer77);

            byte[] buffer88 = BitConverter.GetBytes(Convert.ToInt32(3675.ToString())); //First Blood
            PS3.SetMemory(0x026FCC6A + 0x80, buffer88);

            byte[] buffer99 = BitConverter.GetBytes(Convert.ToInt32(5078.ToString())); //Avenger
            PS3.SetMemory(0x026FCCEE + 0x80, buffer99);

            //Medals Tab 1

            byte[] buffer111 = BitConverter.GetBytes(Convert.ToInt32(451.ToString()));
            PS3.SetMemory(0x026FCCCA + 0x80, buffer111);

            byte[] buffer222 = BitConverter.GetBytes(Convert.ToInt32(152.ToString()));
            PS3.SetMemory(0x026FCB92 + 0x80, buffer222);

            byte[] buffer333 = BitConverter.GetBytes(Convert.ToInt32(399.ToString()));
            PS3.SetMemory(0x026FCCE8 + 0x80, buffer333);

            byte[] buffer444 = BitConverter.GetBytes(Convert.ToInt32(112.ToString())); //Bankrupted
            PS3.SetMemory(0x026FCD2A + 0x80, buffer444);

            byte[] buffer555 = BitConverter.GetBytes(Convert.ToInt32(75.ToString()));
            PS3.SetMemory(0x026FCB98 + 0x80, buffer555);

            byte[] buffer666 = BitConverter.GetBytes(Convert.ToInt32(140.ToString()));
            PS3.SetMemory(0x026FCD06 + 0x80, buffer666);

            byte[] buffer777 = BitConverter.GetBytes(Convert.ToInt32(419.ToString())); //Blackout
            PS3.SetMemory(0x026FCC46 + 0x80, buffer777);

            byte[] buffer888 = BitConverter.GetBytes(Convert.ToInt32(128.ToString()));
            PS3.SetMemory(0x026FCBFE + 0x80, buffer888);

            byte[] buffer999 = BitConverter.GetBytes(Convert.ToInt32(110.ToString()));
            PS3.SetMemory(0x026FCCFA + 0x80, buffer999);

            byte[] buffer1111 = BitConverter.GetBytes(Convert.ToInt32(164.ToString())); //Buzz Kill
            PS3.SetMemory(0x026FCEB0 + 0x80, buffer1111);

            byte[] buffer2222 = BitConverter.GetBytes(Convert.ToInt32(98.ToString()));
            PS3.SetMemory(0x026FCC04 + 0x80, buffer2222);

            byte[] buffer3333 = BitConverter.GetBytes(Convert.ToInt32(151.ToString()));
            PS3.SetMemory(0x026FCBA4 + 0x80, buffer3333);

            byte[] buffer4444 = BitConverter.GetBytes(Convert.ToInt32(76.ToString())); //Bullseye
            PS3.SetMemory(0x026FCD9C + 0x80, buffer4444);

            byte[] buffer5555 = BitConverter.GetBytes(Convert.ToInt32(132.ToString()));
            PS3.SetMemory(0x026FCB8C + 0x80, buffer5555);

            byte[] buffer6666 = BitConverter.GetBytes(Convert.ToInt32(59.ToString())); //Boomstick
            PS3.SetMemory(0x026FCDDE + 0x80, buffer6666);

            byte[] buffer7777 = BitConverter.GetBytes(Convert.ToInt32(167.ToString()));
            PS3.SetMemory(0x026FCD96 + 0x80, buffer7777);

            byte[] buffer8888 = BitConverter.GetBytes(Convert.ToInt32(429.ToString()));
            PS3.SetMemory(0x026FCCBE + 0x80, buffer8888);

            byte[] buffer9999 = BitConverter.GetBytes(Convert.ToInt32(647.ToString()));
            PS3.SetMemory(0x026FCD36 + 0x80, buffer9999);

            // Medals Tab 2

            byte[] buffer12 = BitConverter.GetBytes(Convert.ToInt32(199.ToString()));
            PS3.SetMemory(0x026FCE20 + 0x80, buffer12);

            byte[] buffer13 = BitConverter.GetBytes(Convert.ToInt32(154.ToString()));
            PS3.SetMemory(0x026FCC88 + 0x80, buffer13);

            byte[] buffer14 = BitConverter.GetBytes(Convert.ToInt32(213.ToString()));
            PS3.SetMemory(0x026FCC76 + 0x80, buffer14);

            byte[] buffer15 = BitConverter.GetBytes(Convert.ToInt32(375.ToString()));
            PS3.SetMemory(0x026FCBD4 + 0x80, buffer15);

            byte[] buffer16 = BitConverter.GetBytes(Convert.ToInt32(431.ToString()));
            PS3.SetMemory(0x026FCBBC + 0x80, buffer16);

            byte[] buffer17 = BitConverter.GetBytes(Convert.ToInt32(409.ToString())); //Clutch SND
            PS3.SetMemory(0x026FCBE0 + 0x80, buffer17);

            byte[] buffer18 = BitConverter.GetBytes(Convert.ToInt32(102.ToString()));
            PS3.SetMemory(0x026FCECE + 0x80, buffer18);

            byte[] buffer19 = BitConverter.GetBytes(Convert.ToInt32(111.ToString())); //Deadeye
            PS3.SetMemory(0x026FCBC8 + 0x80, buffer19);

            byte[] buffer21 = BitConverter.GetBytes(Convert.ToInt32(607.ToString())); //Denied Flag
            PS3.SetMemory(0x026FCD48 + 0x80, buffer21);

            byte[] buffer20 = BitConverter.GetBytes(Convert.ToInt32(520.ToString()));
            PS3.SetMemory(0x026FCD3C + 0x80, buffer20);

            byte[] buffer23 = BitConverter.GetBytes(Convert.ToInt32(411.ToString())); //Decimated
            PS3.SetMemory(0x026FCBCE + 0x80, buffer23);

            byte[] buffer24 = BitConverter.GetBytes(Convert.ToInt32(326.ToString()));
            PS3.SetMemory(0x026FCBF8 + 0x80, buffer24);

            byte[] buffer25 = BitConverter.GetBytes(Convert.ToInt32(109.ToString()));
            PS3.SetMemory(0x026FCCDC + 0x80, buffer25);

            byte[] buffer26 = BitConverter.GetBytes(Convert.ToInt32(161.ToString())); //Extermination
            PS3.SetMemory(0x026FCC10 + 0x80, buffer26);

            byte[] buffer27 = BitConverter.GetBytes(Convert.ToInt32(378.ToString()));
            PS3.SetMemory(0x026FCDA2 + 0x80, buffer27);

            byte[] buffer28 = BitConverter.GetBytes(Convert.ToInt32(264.ToString()));
            PS3.SetMemory(0x026FCCC4 + 0x80, buffer28);

            byte[] buffer29 = BitConverter.GetBytes(Convert.ToInt32(105.ToString())); //Flyswatter
            PS3.SetMemory(0x026FCC1C + 0x80, buffer29);

            byte[] buffer10 = BitConverter.GetBytes(Convert.ToInt32(793.ToString()));
            PS3.SetMemory(0x026FCC58 + 0x80, buffer10);

            //Medals Tab 3

            byte[] buffer31 = BitConverter.GetBytes(Convert.ToInt32(89.ToString()));
            PS3.SetMemory(0x026FCBEC + 0x80, buffer31);

            byte[] buffer32 = BitConverter.GetBytes(Convert.ToInt32(209.ToString()));
            PS3.SetMemory(0x026FCD7E + 0x80, buffer32);

            byte[] buffer30 = BitConverter.GetBytes(Convert.ToInt32(310.ToString())); //Gun Expert
            PS3.SetMemory(0x026FCDA8 + 0x80, buffer30);

            byte[] buffer34 = BitConverter.GetBytes(Convert.ToInt32(288.ToString()));
            PS3.SetMemory(0x026FCD1E + 0x80, buffer34);

            byte[] buffer35 = BitConverter.GetBytes(Convert.ToInt32(301.ToString()));
            PS3.SetMemory(0x026FCC82 + 0x80, buffer35);

            byte[] buffer36 = BitConverter.GetBytes(Convert.ToInt32(465.ToString())); //Hero
            PS3.SetMemory(0x026FCBDA + 0x80, buffer36);

            byte[] buffer37 = BitConverter.GetBytes(Convert.ToInt32(369.ToString()));
            PS3.SetMemory(0x026FCBB0 + 0x80, buffer37);

            byte[] buffer38 = BitConverter.GetBytes(Convert.ToInt32(233.ToString()));
            PS3.SetMemory(0x026FCC3A + 0x80, buffer38);

            byte[] buffer39 = BitConverter.GetBytes(Convert.ToInt32(262.ToString()));
            PS3.SetMemory(0x026FCCB8 + 0x80, buffer39);

            byte[] buffer40 = BitConverter.GetBytes(Convert.ToInt32(454.ToString())); //Intercepted
            PS3.SetMemory(0x026FCC28 + 0x80, buffer40);

            byte[] buffer41 = BitConverter.GetBytes(Convert.ToInt32(688.ToString())); //Kaboom
            PS3.SetMemory(0x026FCE02 + 0x80, buffer41);

            byte[] buffer42 = BitConverter.GetBytes(Convert.ToInt32(703.ToString()));
            PS3.SetMemory(0x026FCD8A + 0x80, buffer42);

            byte[] buffer43 = BitConverter.GetBytes(Convert.ToInt32(298.ToString())); //No Tip
            PS3.SetMemory(0x026FCC40 + 0x80, buffer43);

            byte[] buffer45 = BitConverter.GetBytes(Convert.ToInt32(799.ToString()));
            PS3.SetMemory(0x026FCCD6 + 0x80, buffer45);

            byte[] buffer46 = BitConverter.GetBytes(Convert.ToInt32(683.ToString())); //Opening Move
            PS3.SetMemory(0x026FCDE4 + 0x80, buffer46);

            byte[] buffer47 = BitConverter.GetBytes(Convert.ToInt32(221.ToString()));
            PS3.SetMemory(0x026FCCF4 + 0x80, buffer47);

            byte[] buffer48 = BitConverter.GetBytes(Convert.ToInt32(200.ToString()));
            PS3.SetMemory(0x026FCC70 + 0x80, buffer48);

            byte[] buffer49 = BitConverter.GetBytes(Convert.ToInt32(180.ToString()));
            PS3.SetMemory(0x026FCC5E + 0x80, buffer49);

            // Medals Tab 4

            byte[] buffer50 = BitConverter.GetBytes(Convert.ToInt32(338.ToString()));
            PS3.SetMemory(0x026FCD78 + 0x80, buffer50);

            byte[] buffer51 = BitConverter.GetBytes(Convert.ToInt32(458.ToString()));
            PS3.SetMemory(0x026FCD24 + 0x80, buffer51);

            byte[] buffer52 = BitConverter.GetBytes(Convert.ToInt32(376.ToString())); //Raining Death
            PS3.SetMemory(0x026FCE08 + 0x80, buffer52);

            byte[] buffer53 = BitConverter.GetBytes(Convert.ToInt32(509.ToString()));
            PS3.SetMemory(0x026FCE1A + 0x80, buffer53);

            byte[] buffer54 = BitConverter.GetBytes(Convert.ToInt32(451.ToString()));
            PS3.SetMemory(0x026FCC0A + 0x80, buffer54);

            byte[] buffer56 = BitConverter.GetBytes(Convert.ToInt32(211.ToString())); //Red Baron
            PS3.SetMemory(0x026FCDF6 + 0x80, buffer56);

            byte[] buffer57 = BitConverter.GetBytes(Convert.ToInt32(189.ToString()));
            PS3.SetMemory(0x026FCE14 + 0x80, buffer57);

            byte[] buffer58 = BitConverter.GetBytes(Convert.ToInt32(169.ToString()));
            PS3.SetMemory(0x026FCC22 + 0x80, buffer58);

            byte[] buffer59 = BitConverter.GetBytes(Convert.ToInt32(196.ToString()));
            PS3.SetMemory(0x026FCC34 + 0x80, buffer59);

            byte[] buffer60 = BitConverter.GetBytes(Convert.ToInt32(155.ToString()));
            PS3.SetMemory(0x026FCBF2 + 0x80, buffer60);

            byte[] buffer61 = BitConverter.GetBytes(Convert.ToInt32(988.ToString())); //Savior
            PS3.SetMemory(0x026FCCD0 + 0x80, buffer61);

            byte[] buffer62 = BitConverter.GetBytes(Convert.ToInt32(775.ToString()));
            PS3.SetMemory(0x026FCCAC + 0x80, buffer62);

            byte[] buffer63 = BitConverter.GetBytes(Convert.ToInt32(1029.ToString())); //Secure D
            PS3.SetMemory(0x026FCDF0 + 0x80, buffer63);

            byte[] buffer64 = BitConverter.GetBytes(Convert.ToInt32(1221.ToString()));
            PS3.SetMemory(0x026FCCD6 + 0x80, buffer64);

            byte[] buffer65 = BitConverter.GetBytes(Convert.ToInt32(565.ToString()));
            PS3.SetMemory(0x026FCD30 + 0x80, buffer65);

            byte[] buffer67 = BitConverter.GetBytes(Convert.ToInt32(110.ToString()));
            PS3.SetMemory(0x026FCCF4 + 0x80, buffer67);

            byte[] buffer68 = BitConverter.GetBytes(Convert.ToInt32(194.ToString()));
            PS3.SetMemory(0x026FCD90 + 0x80, buffer68);

            byte[] buffer69 = BitConverter.GetBytes(Convert.ToInt32(2017.ToString()));
            PS3.SetMemory(0x026FCBC2 + 0x80, buffer69);

            // Medals Tab 5

            byte[] buffer70 = BitConverter.GetBytes(Convert.ToInt32(154.ToString()));
            PS3.SetMemory(0x026FCB9E + 0x80, buffer70);

            byte[] buffer71 = BitConverter.GetBytes(Convert.ToInt32(210.ToString()));
            PS3.SetMemory(0x026FCDEA + 0x80, buffer71);

            byte[] buffer72 = BitConverter.GetBytes(Convert.ToInt32(309.ToString())); //Takedown Bomb
            PS3.SetMemory(0x026FCD42 + 0x80, buffer72);

            byte[] buffer73 = BitConverter.GetBytes(Convert.ToInt32(411.ToString()));
            PS3.SetMemory(0x026FCD0C + 0x80, buffer73);

            byte[] buffer74 = BitConverter.GetBytes(Convert.ToInt32(321.ToString()));
            PS3.SetMemory(0x026FCC16 + 0x80, buffer74);

            byte[] buffer75 = BitConverter.GetBytes(Convert.ToInt32(177.ToString()));
            PS3.SetMemory(0x026FCD00 + 0x80, buffer75);

            byte[] buffer76 = BitConverter.GetBytes(Convert.ToInt32(598.ToString())); //Retrieved
            PS3.SetMemory(0x026FCE14 + 0x80, buffer76);

            byte[] buffer78 = BitConverter.GetBytes(Convert.ToInt32(931.ToString())); //Victory
            PS3.SetMemory(0x026FCEC8 + 0x80, buffer78);

            byte[] buffer79 = BitConverter.GetBytes(Convert.ToInt32(322.ToString()));
            PS3.SetMemory(0x026FCC2E + 0x80, buffer79);

            byte[] buffer80 = BitConverter.GetBytes(Convert.ToInt32(375.ToString())); //Warbeast
            PS3.SetMemory(0x026FCC4C + 0x80, buffer80);

            byte[] buffer81 = BitConverter.GetBytes(Convert.ToInt32(196.ToString()));
            PS3.SetMemory(0x026FCC9A + 0x80, buffer81);

            byte[] buffer82 = BitConverter.GetBytes(Convert.ToInt32(247.ToString()));
            PS3.SetMemory(0x026FCBB6 + 0x80, buffer82);

            byte[] buffer83 = BitConverter.GetBytes(Convert.ToInt32(399.ToString())); //Shared RCXD
            PS3.SetMemory(0x026FCE80 + 0x80, buffer83);

            byte[] buffer84 = BitConverter.GetBytes(Convert.ToInt32(271.ToString()));
            PS3.SetMemory(0x026FCEA4 + 0x80, buffer84);

            byte[] buffer85 = BitConverter.GetBytes(Convert.ToInt32(16.ToString())); //Shared VSAT
            PS3.SetMemory(0x026FCE92 + 0x80, buffer85);

            byte[] buffer86 = BitConverter.GetBytes(Convert.ToInt32(2.ToString())); //Shared Swarm
            PS3.SetMemory(0x026FCE68 + 0x80, buffer86);

            byte[] buffer87 = BitConverter.GetBytes(Convert.ToInt32(29.ToString()));
            PS3.SetMemory(0x026FCE26 + 0x80, buffer87);

            byte[] buffer89 = BitConverter.GetBytes(Convert.ToInt32(65.ToString()));
            PS3.SetMemory(0x026FCE32 + 0x80, buffer89);

            // Medals Tab 6

            byte[] buffer90 = BitConverter.GetBytes(Convert.ToInt32(67.ToString()));
            PS3.SetMemory(0x026FCE74 + 0x80, buffer90);

            byte[] buffer91 = BitConverter.GetBytes(Convert.ToInt32(55.ToString()));
            PS3.SetMemory(0x026FCE38 + 0x80, buffer91);

            byte[] buffer92 = BitConverter.GetBytes(Convert.ToInt32(44.ToString()));
            PS3.SetMemory(0x026FCE4A + 0x80, buffer92);

            byte[] buffer93 = BitConverter.GetBytes(Convert.ToInt32(59.ToString()));
            PS3.SetMemory(0x026FCE7A + 0x80, buffer93);

            byte[] buffer94 = BitConverter.GetBytes(Convert.ToInt32(7.ToString()));
            PS3.SetMemory(0x026FCE50 + 0x80, buffer94);

            byte[] buffer95 = BitConverter.GetBytes(Convert.ToInt32(3.ToString()));
            PS3.SetMemory(0x026FCE44 + 0x80, buffer95);

            byte[] buffer96 = BitConverter.GetBytes(Convert.ToInt32(32.ToString())); //S Sentry Gun
            PS3.SetMemory(0x026FCE98 + 0x80, buffer96);

            byte[] buffer97 = BitConverter.GetBytes(Convert.ToInt32(83.ToString())); //S Hunter Killer
            PS3.SetMemory(0x026FCE62 + 0x80, buffer97);

            byte[] buffer98 = BitConverter.GetBytes(Convert.ToInt32(3.ToString())); //S Lodestar
            PS3.SetMemory(0x026FCE8C + 0x80, buffer98);

            byte[] buffer100 = BitConverter.GetBytes(Convert.ToInt32(4.ToString()));
            PS3.SetMemory(0x026FCE56 + 0x80, buffer100);

            byte[] buffer101 = BitConverter.GetBytes(Convert.ToInt32(1.ToString())); //S K9
            PS3.SetMemory(0x026FCE3E + 0x80, buffer101);

            byte[] buffer102 = BitConverter.GetBytes(Convert.ToInt32(59.ToString()));
            PS3.SetMemory(0x026FCE5C + 0x80, buffer102);

            byte[] buffer103 = BitConverter.GetBytes(Convert.ToInt32(31.ToString()));
            PS3.SetMemory(0x026FCE86 + 0x80, buffer103);
        }
        #endregion

        private void simpleButton126_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            NoobStat();
            NoobMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Noob Stats.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton127_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            LegitStat();
            LegitMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Legit Stats.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton128_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            ProStat();
            ProMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Pro Player Stats.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton129_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            InsaneStat();
            InsaneMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Insane Stats.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton130_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            NoobStat2();
                if (checkEdit173.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(12);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit174.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(13);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit175.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(14);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit176.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(15);
                    PS3.SetMemory(0x26FD014, buffer);
                }
            NoobMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Noob Stats + BO1 Prestige.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton131_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            LegitStat2();
                if (checkEdit173.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(12);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit174.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(13);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit175.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(14);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit176.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(15);
                    PS3.SetMemory(0x26FD014, buffer);
                }
            LegitMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Legit Stats + BO1 Prestige.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void checkEdit173_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit173.Checked)
            {
                checkEdit174.Checked = false;
                checkEdit175.Checked = false;
                checkEdit176.Checked = false;
            }
        }

        private void checkEdit174_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit174.Checked)
            {
                checkEdit173.Checked = false;
                checkEdit175.Checked = false;
                checkEdit176.Checked = false;
            }
        }

        private void checkEdit175_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit175.Checked)
            {
                checkEdit173.Checked = false;
                checkEdit174.Checked = false;
                checkEdit176.Checked = false;
            }
        }

        private void checkEdit176_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit176.Checked)
            {
                checkEdit174.Checked = false;
                checkEdit175.Checked = false;
                checkEdit173.Checked = false;
            }
        }

        private void simpleButton132_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            ProStat2();
                if (checkEdit173.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(12);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit174.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(13);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit175.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(14);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit176.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(15);
                    PS3.SetMemory(0x26FD014, buffer);
                }
            ProMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Pro Player Stats + BO1 Prestige.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton133_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            InsaneStat2();
                if (checkEdit173.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(12);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit174.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(13);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit175.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(14);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit176.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(15);
                    PS3.SetMemory(0x26FD014, buffer);
                }
            InsaneMedals();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Insane Stats + BO1 Prestige.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton134_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            NoobStat2();
                if (checkEdit173.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(12);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit174.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(13);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit175.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(14);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit176.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(15);
                    PS3.SetMemory(0x26FD014, buffer);
                }
            NoobMedals();
            UnlockAll();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Noob Stats + BO1 Prestige + Unlock All.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton135_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            LegitStat2();
                if (checkEdit173.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(12);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit174.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(13);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit175.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(14);
                    PS3.SetMemory(0x26FD014, buffer);
                }
                else if (checkEdit176.Checked)
                {
                    byte[] buffer = BitConverter.GetBytes(15);
                    PS3.SetMemory(0x26FD014, buffer);
                }
            LegitMedals();
            UnlockAll();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Legit Stats + BO1 Prestige + Unlock All.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton136_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            ProStat2();
            if (checkEdit173.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(12);
                PS3.SetMemory(0x26FD014, buffer);
            }
            else if (checkEdit174.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(13);
                PS3.SetMemory(0x26FD014, buffer);
            }
            else if (checkEdit175.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(14);
                PS3.SetMemory(0x26FD014, buffer);
            }
            else if (checkEdit176.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(15);
                PS3.SetMemory(0x26FD014, buffer);
            }
            ProMedals();
            UnlockAll();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Pro Player Stats + BO1 Prestige + Unlock All.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton137_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            InsaneStat2();
            if (checkEdit173.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(12);
                PS3.SetMemory(0x26FD014, buffer);
            }
            else if (checkEdit174.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(13);
                PS3.SetMemory(0x26FD014, buffer);
            }
            else if (checkEdit175.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(14);
                PS3.SetMemory(0x26FD014, buffer);
            }
            else if (checkEdit176.Checked)
            {
                byte[] buffer = BitConverter.GetBytes(15);
                PS3.SetMemory(0x26FD014, buffer);
            }
            InsaneMedals();
            UnlockAll();
            splashScreenManager2.CloseWaitForm();
            Application.DoEvents();
            Thread.Sleep(50);
            XtraMessageBox.Show("Complete Recovery done - Insane Stats + BO1 Prestige + Unlock All.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            //WebClient wc = new WebClient();
            //string URL = "http://www.cybermodding.it/LezZo-BO2-RTM/";
            //string Change = "OLDChangelog.txt";

            //var CH = wc.DownloadString(URL + Change);

            XtraMessageBox.Show("Feature disabled, server is offline :(", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void labelControl148_Click(object sender, EventArgs e)
        {

        }
    }
}
