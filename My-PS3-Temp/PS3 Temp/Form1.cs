using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PS3ManagerAPI;
using DevExpress;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.Printing;
using DevExpress.Sparkline;
using DevExpress.XtraSplashScreen;
using DevExpress.Sparkline.Core;
using DevExpress.XtraBars;

namespace PS3_Temp
{
    public partial class Form1 : XtraForm
    {

        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public string Temperature = "";

        public Form1()
        {
            InitializeComponent();
            Temperature = "OK";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void flowButton1_Click(object sender, EventArgs e)
        {
            Temperature = "";
            if (PS3M_API.IsConnected)
            {
                timer2.Stop();
                PS3M_API.DisconnectTarget();
            }

            Application.Exit();
        }

        private void flowButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PS3M_API.ConnectTarget(textEdit1.Text, Convert.ToInt32(7887)))
                {
                    XtraMessageBox.Show("Impossible to connect, check your IP!", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelControl11.Text = "NOT Connected";
                }
                else
                {
                    flowButton2.Enabled = true;
                    flowButton5.Enabled = true;
                    flowButton6.Enabled = true;
                    flowButton7.Enabled = true;
                    labelControl4.Text = PS3M_API.PS3.GetFirmwareVersion_Str();
                    labelControl2.Text = PS3M_API.PS3.GetFirmwareType();
                    uint cpu;
                    uint rsx;
                    PS3M_API.PS3.GetTemperature(out cpu, out rsx);
                    labelControl6.Text = cpu.ToString() + "°";
                    labelControl8.Text = rsx.ToString() + "°";
                    labelControl10.ForeColor = Color.DodgerBlue;
                    labelControl11.ForeColor = Color.DodgerBlue;
                    labelControl11.Text = "Connected";
                    timer1.Interval = 10000;
                    timer1.Start();
                    timer2.Interval = 10000;
                    timer2.Start();
                    webBrowser1.Navigate(textEdit1.Text);
                    webBrowser1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowButton2_Click(object sender, EventArgs e)
        {
            PS3M_API.DisconnectTarget();
            labelControl10.ForeColor = Color.White;
            labelControl11.ForeColor = Color.White;
            labelControl11.Text = "...";
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            XtraMessageBox.Show("PS3 Temp Disconnected! Bye bye :)", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void flowButton5_Click(object sender, EventArgs e)
        {
            if (PS3M_API.IsConnected)
                {
                timer1.Interval = 10000;
                timer1.Start();
                }
            else
            {
                XtraMessageBox.Show("You have to connect your PS3 before.. .-.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowButton6_Click(object sender, EventArgs e)
        {
            if (PS3M_API.IsConnected)
            {
                webBrowser1.Navigate(textEdit1.Text + "/cpursx.ps3?up");
            }
            else
            {
                XtraMessageBox.Show("You have to connect your PS3 before.. .-.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowButton7_Click(object sender, EventArgs e)
        {
            if (PS3M_API.IsConnected)
            {
                webBrowser1.Navigate(textEdit1.Text + "/cpursx.ps3?dn");
            }
            else
            {
                XtraMessageBox.Show("You have to connect your PS3 before.. .-.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PS3M_API.IsConnected)
                {
            labelControl2.Text = PS3M_API.PS3.GetFirmwareType();
            labelControl4.Text = PS3M_API.PS3.GetFirmwareVersion_Str();
            uint cpu;
            uint rsx;
            PS3M_API.PS3.GetTemperature(out cpu, out rsx);
            labelControl6.Text = cpu.ToString() + "°";
            labelControl8.Text = rsx.ToString() + "°";
                }
        }

        private void flowTheme1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            WarningMsg wmsg = new WarningMsg();

            if (labelControl6.Text == "72°")
            if (Temperature == "OK")
            {
                wmsg.Show();
                timer2.Stop();
                timer3.Start();
                Temperature = "Danger";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            WarningTemp wtmp = new WarningTemp();

            if (labelControl6.Text == "75°")
            if (Temperature == "Danger")
            {
                wtmp.Show();
                timer3.Stop();
                Temperature = "Finish";
            }
        }
    }
}
