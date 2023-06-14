using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
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
using PS3Lib;
using PylezZo_GTAV_Extreme_Tool.Properties;
using PylezZo_GTAV_Extreme_Tool.Pylo;

namespace PylezZo_GTAV_Extreme_Tool
{
    public partial class PlayersInform : DevExpress.XtraEditors.XtraForm
    {
        public PlayersInform()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        public static PS3Lib.PS3API PS3 = new PS3Lib.PS3API();

        #region Functionsss
        delegate void SetTextCallback(string text, LabelControl ctrl);
        private static int ped = Functions.RPCFunc.GET_PLAYER_PED(Main.PlayersInfoInt);
        float[] coo = Functions.RPCFunc.GET_ENTITY_COORDS(ped);
        private string GET_LABEL_TEXT(string txt)
        {
            return (Convert.ToString(ClassicRPC.Call(0x95C4B5AD, new object[] { txt })));
        }

        private void SetText(string text, LabelControl ctrl)
        {
            if (tokenSource_0.IsCancellationRequested == false)
            {
                try
                {
                    if (ctrl.InvokeRequired)
                    {
                        SetTextCallback d = new SetTextCallback(SetText);
                        Invoke(d, new object[] { text, ctrl });
                    }
                    else
                    {
                        ctrl.Text = text;
                    }
                }
                catch
                {
                    
                }
            }
        }
        
        private string returnName()
        {
            ClassicRPC.CompleteReq();
            int name = ClassicRPC.Call(Natives.GET_PLAYER_NAME, new object[] { Main.PlayersInfoInt });
            return PS3.Extension.ReadString((uint)name);
        }

        private bool InVehicle()
        {
            bool flag = false;
            ClassicRPC.CompleteReq();
            if (ClassicRPC.Call(Natives.IS_PED_IN_ANY_VEHICLE, (object)ped) != 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        private string GetZone()
        {
            string str;
            ClassicRPC.CompleteReq();
            str = GET_LABEL_TEXT(PS3.Extension.ReadString((uint)ClassicRPC.Call(Natives.GET_NAME_OF_ZONE, new object[] { coo })));
            return str;
        }

        private bool IsHost()
        {
            ClassicRPC.CompleteReq();
            if (ClassicRPC.NCall(NewNatives.NETWORK_GET_HOST_OF_SCRIPT, (object)"freemode", (object)-1, (object)0) == Main.PlayersInfoInt)
                return true;
            else
                return false;
        }

        private bool IsAlive()
        {
            ClassicRPC.CompleteReq();
            if (Functions.RPCFunc.IS_PLAYER_ALIVE(ped))
                return true;
            else
                return false;
        }

        private bool IsTalking()
        {
            ClassicRPC.CompleteReq();
            if (ClassicRPC.NCall(NewNatives.NETWORK_IS_PLAYER_TALKING, new object[] { Main.PlayersInfoInt }) != 0)
                return true;
            else return false;
        }

        private bool IsArmed()
        {
            RPC3.CompleteReq();
            if (RPC3.Call(Natives.IS_PLAYER_FREE_AIMING, new object[] { ped }) != 0)
                return true;
            else return false;
        }

        private string GetHealth()
        {
            ClassicRPC.CompleteReq();
            int hea = ClassicRPC.Call(Natives.GET_ENTITY_HEALTH, new object[] { ped });
            return Convert.ToString(hea);
        }

        private bool IsShooting()
        {
            ClassicRPC.CompleteReq();
            if (ClassicRPC.Call(Natives.IS_PED_SHOOTING, new object[] { ped }) != 0)
                return true;
            else return false;
        }

        private int IsWanted()
        {
            ClassicRPC.CompleteReq();
            int wantedlev = ClassicRPC.Call(Natives.GET_PLAYER_WANTED_LEVEL, new object[] { Main.PlayersInfoInt });
            return wantedlev;
        }

        private string GetSpeed()
        {
            ClassicRPC.CompleteReq();
            double spd = ((ClassicRPC.Call(Natives.GET_ENTITY_SPEED, new object[] { ped }) * 3.3) * 1.609344);
            return Convert.ToString(spd);
        }

        private string GetDistance()
        {
            ClassicRPC.CompleteReq();
            float[] coo2 = Functions.RPCFunc.GET_ENTITY_COORDS(Functions.RPCFunc.PLAYER_PED_ID());
            double dis = ClassicRPC.Call(Natives.VDIST, new object[] { coo2[0], coo2[1], coo2[2], coo[0], coo[1], coo[2] });
            return Convert.ToString(dis);
        }
        #endregion

        #region Task
        public static CancellationTokenSource tokenSource_0 = new CancellationTokenSource();
        public static CancellationToken token_0 = tokenSource_0.Token;

        private void TaskRefreshInfo(bool toggle)
        {
            if (toggle == false)
            {
                tokenSource_0.Cancel();
            }
            if (toggle == true)
            {
                if (tokenSource_0.IsCancellationRequested == true)
                {
                    tokenSource_0 = new CancellationTokenSource();
                    token_0 = tokenSource_0.Token;
                }
                Task t0 = Task.Factory.StartNew(() =>
                {
                    while (!token_0.IsCancellationRequested)
                    {
                        UpdateLabels();
                    }
                }, token_0);
            }
        }

        private void UpdateLabels()
        {
            if (InVehicle())
            {
                SetText("Yes", labelControl12);
                SetText(Functions.RPCFunc.GET_VEH_NAME(Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(ped)), labelControl4);
            }
            else
            {
                SetText("No", labelControl12);
                SetText("Not in Vehicle", labelControl4);
            }

            string name = returnName();
            SetText(name, labelControl11);

            if (IsHost())
                SetText("Yes", labelControl23);
            else
                SetText("No", labelControl23);

            if (IsTalking())
                SetText("Yes", labelControl15);
            else
                SetText("No", labelControl15);
            
            SetText(GetZone(), labelControl16);

            string hea = GetHealth();
            SetText(hea, labelControl20);

            if (IsAlive())
                SetText("Yes", labelControl13);
            else
                SetText("No", labelControl13);

            if (IsShooting())
                SetText("Yes", labelControl9);
            else
                SetText("No", labelControl9);

            string wan = Convert.ToString(IsWanted());
            SetText(wan, labelControl21);

            SetText(GetSpeed(), labelControl7);
            SetText(GetDistance(), labelControl17);
        }
        #endregion

        private void PlayersInform_Load(object sender, EventArgs e)
        {
            
        }

        private void PlayersInform_Shown(object sender, EventArgs e)
        {
            TaskRefreshInfo(true);
        }

        private void PlayersInform_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void PlayersInform_Closing(object sender, FormClosingEventArgs e)
        {
            XtraMessageBox.Show("You can enable or disable this Advanced info windows from the 'Tool' dropdown bar at the top !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            for (int i = 0; i < 3; i++)
            {
                TaskRefreshInfo(false);
            }
            Thread.Sleep(500);
        }
    }
}