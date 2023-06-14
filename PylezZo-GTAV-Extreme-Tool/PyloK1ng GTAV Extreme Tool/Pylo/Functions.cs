using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PS3Lib;
using PylezZo_GTAV_Extreme_Tool.Mods;

namespace PylezZo_GTAV_Extreme_Tool.Pylo
{
    internal sealed class Functions
    {
        #region defin
        public static PS3API PS3 = new PS3API();
        public static uint uint_1 = 0U;
        public static uint uint_2 = 0U;
        public static uint uint_3 = 0U;
        public static string UserName = "";
        public static string KeyNumber = "";
        public static byte[] byte_0 = new byte[9] { 65, 78, 78, 73, 72, 76, 0, 0, 0 };
        public static byte[] byte_1 = new byte[4] { 179, 155, 10, 230 };
        public static byte[] byte_2 = new byte[16777216];
        private static bool ContinueWP = true;
        #endregion

        public sealed class Addresses
        {
            public static int PICKUP_MONEY_PAPER_BAG = 0x711d02a4;
            public static int PICKUP_AMMO_BULLET_MP = 0x550447a9;
            public static int PICKUP_AMMO_MISSILE_MP = -107080240;
            public static int PICKUP_ARMOUR_STANDARD = 0x4bfb42d1;
            public static int PICKUP_HEALTH_SNACK = 0x1cd2cf66;
            public static int PICKUP_HEALTH_STANDARD = -1888453608;
            public static int PICKUP_MONEY_CASE = -831529621;
            public static int PICKUP_MONEY_DEP_BAG = 0x20893292;
            public static int PICKUP_MONEY_MED_BAG = 0x14568f28;
            public static int PICKUP_MONEY_PURSE = 0x1e9a99f8;
            public static int PICKUP_MONEY_SECURITY_CASE = -562499202;
            public static int PICKUP_MONEY_VARIABLE = -31919185;
            public static int PICKUP_MONEY_WALLET = 0x5de0ad3e;
            public static int PICKUP_PARACHUTE = 0x6773257d;
            public static int PICKUP_PORTABLE_PACKAGE = -2136239332;
            public static int PICKUP_VEHICLE_HEALTH_STANDARD = 0x98d79ef;
        }

        public sealed class Weapons
        {
            public static uint[] WeaponsU = new uint[] { 0xaf113f99, 0x13579279, 0xf9fbaebe, 0x22d8fe39, 0xbfefff6d, 0xe284c527, 0xefe7e2df,
            0x23c9f95c, 0xf9e6aa4b, 0x88c78eb7, 0x1b79f17, 0x7f229f94, 0x9d61e50f, 0xa0973d5e, 0x83bf0278, 0x7fd62962, 0xa3d4d34, 0x5ef9fec4,
            0x8d4be52, 0x84bd7bfd, 0x92a27487, 0xfdbadced, 0x60ec506, 0x7f7497e5, 0x497facc3, 0x47757124, 0x440e4788, 0x93e220bd, 0xa284510b,
            0x4dd2dc56, 0x61012683, 0x4e875f73, 0xd205520e, 0x3aabbbaa, 0xc472fe2, 0x63ab0442, 0x99b507ea, 0xc734385a, 0x13532244, 0x42bf8a85,
            0x24b17070, 0xa89cb99e, 0x678b81b1, 0x34a67b97, 0x1b06d571, 0x99aeeb3b, 0xab564b93, 0x1d073a89, 0x7846a318, 0xfdbc8a50, 0x5fc3c11,
            0x787f0bb, 0xbfd21232, 0xc0a3098d, 0x2c3731d9, 0x687652ce, 0x3656c8c1, 0x958a4a8f, 0x9d07f764, 0xb1ca77b1, 0x2be6766b, 0xa2719263, 0x83839c4 };

            public static uint ADVANCEDRIFLE = 0xaf113f99;
            public static uint AIRSTRIKE_ROCKET = 0x13579279;
            public static uint ANIMAL = 0xf9fbaebe;
            public static uint APPISTOL = 0x22d8fe39;
            public static uint ASSAULTRIFLE = 0xbfefff6d;
            public static uint ASSAULTSHOTGUN = 0xe284c527;
            public static uint ASSAULTSMG = 0xefe7e2df;
            public static uint BALL = 0x23c9f95c;
            public static uint BOTTLE = 0xf9e6aa4b;
            public static uint BRIEFCASE = 0x88c78eb7;
            public static uint BRIEFCASE_02 = 0x1b79f17;
            public static uint BULLPUPRIFLE = 0x7f229f94;
            public static uint BULLPUPSHOTGUN = 0x9d61e50f;
            public static uint BZGAS = 0xa0973d5e;
            public static uint CARBINERIFLE = 0x83bf0278;
            public static uint COMBATMG = 0x7fd62962;
            public static uint COMBATPDW = 0xa3d4d34;
            public static uint COMBATPISTOL = 0x5ef9fec4;
            public static uint COUGAR = 0x8d4be52;
            public static uint CROWBAR = 0x84bd7bfd;
            public static uint DAGGER = 0x92a27487;
            public static uint DIGISCANNER = 0xfdbadced;
            public static uint FIREEXTINGUISHER = 0x60ec506;
            public static uint FIREWORK = 0x7f7497e5;
            public static uint FLARE = 0x497facc3;
            public static uint FLAREGUN = 0x47757124;
            public static uint GOLFCLUB = 0x440e4788;
            public static uint GRENADE = 0x93e220bd;
            public static uint GRENADELAUNCHER = 0xa284510b;
            public static uint GRENADELAUNCHER_SMOKE = 0x4dd2dc56;
            public static uint GUSENBERG = 0x61012683;
            public static uint HAMMER = 0x4e875f73;
            public static uint HEAVYPISTOL = 0xd205520e;
            public static uint HEAVYSHOTGUN = 0x3aabbbaa;
            public static uint HEAVYSNIPER = 0xc472fe2;
            public static uint HOMINGLAUNCHER = 0x63ab0442;
            public static uint KNIFE = 0x99b507ea;
            public static uint MARKSMANRIFLE = 0xc734385a;
            public static uint MICROSMG = 0x13532244;
            public static uint MINIGUN = 0x42bf8a85;
            public static uint MOLOTOV = 0x24b17070;
            public static uint MUSKET = 0xa89cb99e;
            public static uint NIGHTSTICK = 0x678b81b1;
            public static uint PETROLCAN = 0x34a67b97;
            public static uint PISTOL = 0x1b06d571;
            public static uint PISTOL50 = 0x99aeeb3b;
            public static uint PROXMINE = 0xab564b93;
            public static uint PUMPSHOTGUN = 0x1d073a89;
            public static uint SAWNOFFSHOTGUN = 0x7846a318;
            public static uint SMOKEGRENADE = 0xfdbc8a50;
            public static uint SNIPERRIFLE = 0x5fc3c11;
            public static uint SNOWBALL = 0x787f0bb;
            public static uint SNSPISTOL = 0xbfd21232;
            public static uint SPECIALCARBINE = 0xc0a3098d;
            public static uint STICKYBOMB = 0x2c3731d9;
            public static uint STINGER = 0x687652ce;
            public static uint STUNGUN = 0x3656c8c1;
            public static uint uint_0 = 0x958a4a8f;
            public static uint uint_1 = 0x9d07f764;
            public static uint uint_2 = 0xb1ca77b1;
            public static uint uint_3 = 0x2be6766b;
            public static uint UNARMED = 0xa2719263;
            public static uint VINTAGEPISTOL = 0x83839c4;
        }

        #region trophy
        public static void GIVE_ACHIEVEMENT_TO_PLAYER(Trophies achievement)
        {
            if (!HAS_ACHIEVEMENT_BEEN_PASSED((int)achievement))
                ClassicRPC.Call(Natives.GIVE_ACHIEVEMENT_TO_PLAYER, (int)achievement);
        }

        public static bool HAS_ACHIEVEMENT_BEEN_PASSED(int achievement)
        {
            return Convert.ToBoolean(ClassicRPC.Call(Natives.HAS_ACHIEVEMENT_BEEN_PASSED, achievement));
        }
        #endregion

        public enum Trophies
        {
            Welcom_To_Los_Santos = 1,
            Friendship,
            A_fair_days,
            The_Moment_of_Truth,
            To_live_or_die,
            Diamond_Hard,
            Subversive,
            Blitzed,
            Small_Town_Big_Job,
            The_Government_Gimps,
            The_Big_One,
            Solid_Gold,
            Career_Criminal,
            Trophie_14,
            Fare_in_Love_and_War,
            TP_Industries_Arms_Rac,
            Trophie_17,
            From_Beyond_the_Stars,
            A_Mystery,
            Waste_Management,
            Red_Mist,
            Trophie_22,
            Kifflom,
            Three_Man_Army,
            Out_of_your_Depth,
            Altruist_Acolyte,
            Trophie_27,
            Trading_Pure_Alpha,
            Pimp_my_Sidearm,
            Wanted_Alive,
            Los_Santos_Customs,
            Close_Shave,
            Off_the_Plane,
            Trophie_34,
            Trophie_35,
            Trophie_36,
            Trophie_37,
            Trophie_38,
            Trophie_39,
            Backseat_Driver,
            Trophie_41,
            Trophie_42,
            Trophie_43,
            Trophie_44,
            Trophie_45,
            Trophie_46,
            Trophie_47,
            Trophie_48,
            Trophie_49,
            Trophie_50,
            Trophie_51,
            Trophie_52,
            Trophie_53,
            Trophie_54,
            Trophie_55,
            Trophie_56,
            Trophie_57,
            Trophie_58
        }

        public static class MsgColors
        {
            public static string Red = "~r~",
                Blue = "~b~",
                Green = "~g~",
                Yellow = "~y~",
                Purple = "~p~",
                Orange = "~o~",
                Grey = "~c~",
                DarkGrey = "~m~",
                Black = "~u~",
                SkipLine = "~n~",
                White = "~s~",
                RockstarVerifiedIcon = "¦",
                RockstarIcon = "÷",
                RockstarIcon2 = "∑";
        }

        public sealed class RPCFunc
        {
            public static string WeapStr = "";

            #region TaskDef
            public static CancellationTokenSource tokenSource_0 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_1 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_2 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_3 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_4 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_5 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_6 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_11 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_12 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_13 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_14 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_15 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_16 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_17 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_18 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_19 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_20 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_21 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_22 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_23 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_24 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_25 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_26 = new CancellationTokenSource();
            public static CancellationTokenSource tokenSource_27 = new CancellationTokenSource();

            public static CancellationToken token_0 = tokenSource_0.Token;
            public static CancellationToken token_1 = tokenSource_1.Token;
            public static CancellationToken token_2 = tokenSource_2.Token;
            public static CancellationToken token_3 = tokenSource_3.Token;
            public static CancellationToken token_4 = tokenSource_4.Token;
            public static CancellationToken token_5 = tokenSource_5.Token;
            public static CancellationToken token_6 = tokenSource_6.Token;
            public static CancellationToken token_11 = tokenSource_11.Token;
            public static CancellationToken token_12 = tokenSource_12.Token;
            public static CancellationToken token_13 = tokenSource_13.Token;
            public static CancellationToken token_14 = tokenSource_14.Token;
            public static CancellationToken token_15 = tokenSource_15.Token;
            public static CancellationToken token_16 = tokenSource_16.Token;
            public static CancellationToken token_17 = tokenSource_17.Token;
            public static CancellationToken token_18 = tokenSource_18.Token;
            public static CancellationToken token_19 = tokenSource_19.Token;
            public static CancellationToken token_20 = tokenSource_20.Token;
            public static CancellationToken token_21 = tokenSource_21.Token;
            public static CancellationToken token_22 = tokenSource_22.Token;
            public static CancellationToken token_23 = tokenSource_23.Token;
            public static CancellationToken token_24 = tokenSource_24.Token;
            public static CancellationToken token_25 = tokenSource_25.Token;
            public static CancellationToken token_26 = tokenSource_26.Token;
            public static CancellationToken token_27 = tokenSource_27.Token;
            #endregion

            #region TaskFunctions
            public static void TaskBossModeStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_1.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_1.IsCancellationRequested == true)
                    {
                        tokenSource_1 = new CancellationTokenSource();
                        token_1 = tokenSource_1.Token;
                    }
                    Task t1 = Task.Factory.StartNew(() =>
                    {
                        while (!token_1.IsCancellationRequested)
                        {
                            for (int client = 0; client < 16; ++client)
                            {
                                if (IS_PLAYER_TARGETING_ENTITY(client, PLAYER_PED_ID()))
                                {
                                    int PED_ID = GET_PLAYER_PED(client);
                                    float[] entityCoords = GET_ENTITY_COORDS(PED_ID);
                                    int type = 5;
                                    Main.Owned_Explosion(PED_ID, entityCoords, type);
                                }
                            }
                        }
                    }, token_1);
                }
            }

            public static void TaskExplosiveBulletsStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_2.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_2.IsCancellationRequested == true)
                    {
                        tokenSource_2 = new CancellationTokenSource();
                        token_2 = tokenSource_2.Token;
                    }
                    Task t2 = Task.Factory.StartNew(() =>
                    {
                        while (!token_2.IsCancellationRequested)
                        {
                            int PEDID = PLAYER_PED_ID();
                            Main.ExplosiveBullets(PEDID);
                        }
                    }, token_2);
                }
            }

            public static void TaskSuperManStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_3.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_3.IsCancellationRequested == true)
                    {
                        tokenSource_3 = new CancellationTokenSource();
                        token_3 = tokenSource_3.Token;
                    }
                    Task t3 = Task.Factory.StartNew(() =>
                    {
                        int Me = PLAYER_PED_ID();

                        while (!token_3.IsCancellationRequested)
                        {
                            if (IS_ENTITY_IN_AIR(Me) != 0)
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    float[] Force = { 100, 100, 50 }, Position = { 140, 140, 60 };
                                    APPLY_FORCE_TO_ENTITY(Me, Force, Position);
                                }
                            }
                            else
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    float[] Force = { 0, 0, 100 }, Position = { 0, 0, 0 };
                                    APPLY_FORCE_TO_ENTITY(Me, Force, Position);
                                }
                            }
                        }
                    }, token_3);
                }
            }

            public static void TaskDisableActionsStart(bool toggle, int clientPED)
            {
                if (toggle == false)
                {
                    tokenSource_4.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_4.IsCancellationRequested == true)
                    {
                        tokenSource_4 = new CancellationTokenSource();
                        token_4 = tokenSource_4.Token;
                    }
                    Task t4 = Task.Factory.StartNew(() =>
                    {
                        while (!token_4.IsCancellationRequested)
                        {
                            Main.CLEAR_PED_TASKS_IMMEDIATLY(clientPED);
                        }
                    }, token_4);
                }
            }

            public static void TaskForceFieldStart(bool toggle, int clientPED)
            {
                if (toggle == false)
                {
                    tokenSource_5.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_5.IsCancellationRequested == true)
                    {
                        tokenSource_5 = new CancellationTokenSource();
                        token_5 = tokenSource_5.Token;
                    }
                    Task t5 = Task.Factory.StartNew(() =>
                    {
                        while (!token_5.IsCancellationRequested)
                        {
                            if (IS_PLAYER_ALIVE(clientPED) == true)
                            {
                                float[] Coords = GET_ENTITY_COORDS(clientPED);
                                Main.Owned_Explosion(clientPED, Coords, 5);
                            }
                        }
                    }, token_5);
                }
            }

            public static void TaskInfiniteStarsStart(bool toggle, int clientPED, int stars)
            {
                if (toggle == false)
                {
                    tokenSource_11.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_11.IsCancellationRequested == true)
                    {
                        tokenSource_11 = new CancellationTokenSource();
                        token_11 = tokenSource_11.Token;
                    }
                    Task t11 = Task.Factory.StartNew(() =>
                    {
                        while (!token_11.IsCancellationRequested)
                        {
                            Main.GiveStars(clientPED, stars);
                        }
                    }, token_11);
                }
            }

            public static void TaskSuperManVehicleStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_14.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_14.IsCancellationRequested == true)
                    {
                        tokenSource_14 = new CancellationTokenSource();
                        token_14 = tokenSource_14.Token;
                    }
                    int Me = PLAYER_PED_ID();
                    int Veh = Main.GET_VEHICLE_PED_IS_IN(Me);

                    Task t14 = Task.Factory.StartNew(() =>
                    {
                        while (!token_14.IsCancellationRequested)
                        {
                            if (IS_ENTITY_IN_AIR(Veh) != 0)
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    float[] Force = { 100, 100, 70 }, Position = { 100, 100, 70 };
                                    APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                }
                            }
                            else
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    float[] Force = { 0, 0, 90 }, Position = { 0, 0, 0 };
                                    APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                }
                            }
                        }
                    }, token_14);
                }
            }

            public static void TaskBindFixVehicleStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_15.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_15.IsCancellationRequested == true)
                    {
                        tokenSource_15 = new CancellationTokenSource();
                        token_15 = tokenSource_15.Token;
                    }
                    int Me = PLAYER_PED_ID();
                    int Veh = Main.GET_VEHICLE_PED_IS_IN(Me);

                    Task t15 = Task.Factory.StartNew(() =>
                    {
                        while (!token_15.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    Main.FixVehicle();
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    Main.FixVehicle();
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    Main.FixVehicle();
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    Main.FixVehicle();
                                }
                            }
                            else if (buttP == "L1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L1))
                                {
                                    Main.FixVehicle();
                                }
                            }
                            else if (buttP == "DR")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.DpadRight))
                                {
                                    Main.FixVehicle();
                                }
                            }
                        }
                    }, token_15);
                }
            }

            public static void TaskLoopShootStart(bool toggle, int clientPED, string WeapStr)
            {
                if (toggle == false)
                {
                    tokenSource_24.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_24.IsCancellationRequested == true)
                    {
                        tokenSource_24 = new CancellationTokenSource();
                        token_24 = tokenSource_24.Token;
                    }
                    Task t24 = Task.Factory.StartNew(() =>
                    {
                        int PID = PLAYER_PED_ID();
                        uint hash = Functions.RPCFunc.STRINGHASH(WeapStr);

                        while (!token_24.IsCancellationRequested)
                        {
                            float[] coord = GET_ENTITY_COORDS(PID);
                            float[] coord2 = GET_ENTITY_COORDS(clientPED);
                            Functions.RPCFunc.SHOOT_SINGLE_BULLET_BETWEEN_COORDS(coord, coord2, 0, 0, Convert.ToInt32(hash), PLAYER_PED_ID(), 0, 0, 700f);
                        }
                    }, token_24);
                }
            }

            public static void TaskBindForwardBoostVehicleStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_16.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_16.IsCancellationRequested == true)
                    {
                        tokenSource_16 = new CancellationTokenSource();
                        token_16 = tokenSource_16.Token;
                    }
                    Task t16 = Task.Factory.StartNew(() =>
                    {
                        while (!token_16.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    Main.BoostVehicle();
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    Main.BoostVehicle();
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    Main.BoostVehicle();
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    Main.BoostVehicle();
                                }
                            }
                            else if (buttP == "L1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L1))
                                {
                                    Main.BoostVehicle();
                                }
                            }
                            else if (buttP == "DR")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.DpadRight))
                                {
                                    Main.BoostVehicle();
                                }
                            }
                        }
                    }, token_16);
                }
            }

            public static void TaskBindShootMissileStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_25.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_25.IsCancellationRequested == true)
                    {
                        tokenSource_25 = new CancellationTokenSource();
                        token_25 = tokenSource_25.Token;
                    }
                    int PID = PLAYER_PED_ID();
                    int Veh = GET_PED_VEHICLE_IS_IN(PID);

                    Task t25 = Task.Factory.StartNew(() =>
                    {
                        while (!token_25.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    float[] numArray2 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[] { 0.6f, 0.6707f, 0.3711f });
                                    float[] numArray3 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[] { -0.6f, 0.6707f, 0.3711f });
                                    float[] numArray4 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[] { 0.6f, 5.0707f, 0.3711f });
                                    float[] numArray5 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[] { -0.6f, 5.0707f, 0.3711f });
                                    uint num2 = 250;
                                    uint hash = STRINGHASH("WEAPON_RPG");
                                    float num4 = 1500f;
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray2[0], numArray2[1], numArray2[2], numArray4[0], numArray4[1], numArray4[2], num2, 0, hash, PID, 1, 1, num4 });
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray3[0], numArray3[1], numArray3[2], numArray5[0], numArray5[1], numArray5[2], num2, 0, hash, PID, 1, 1, num4 });
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    float[] numArray2 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { 0.6f, 0.6707f, 0.3711f });
                                    float[] numArray3 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { -0.6f, 0.6707f, 0.3711f });
                                    float[] numArray4 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { 0.6f, 5.0707f, 0.3711f });
                                    float[] numArray5 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { -0.6f, 5.0707f, 0.3711f });
                                    uint num2 = 250;
                                    uint hash = STRINGHASH("WEAPON_RPG");
                                    float num4 = 1500f;
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray2[0], numArray2[1], numArray2[2], numArray4[0], numArray4[1], numArray4[2], num2, 0, hash, PID, 1, 1, num4 });
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray3[0], numArray3[1], numArray3[2], numArray5[0], numArray5[1], numArray5[2], num2, 0, hash, PID, 1, 1, num4 });
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    float[] numArray2 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { 0.6f, 0.6707f, 0.3711f });
                                    float[] numArray3 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { -0.6f, 0.6707f, 0.3711f });
                                    float[] numArray4 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { 0.6f, 5.0707f, 0.3711f });
                                    float[] numArray5 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { -0.6f, 5.0707f, 0.3711f });
                                    uint num2 = 250;
                                    uint hash = STRINGHASH("WEAPON_RPG");
                                    float num4 = 1500f;
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray2[0], numArray2[1], numArray2[2], numArray4[0], numArray4[1], numArray4[2], num2, 0, hash, PID, 1, 1, num4 });
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray3[0], numArray3[1], numArray3[2], numArray5[0], numArray5[1], numArray5[2], num2, 0, hash, PID, 1, 1, num4 });
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    float[] numArray2 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { 0.6f, 0.6707f, 0.3711f });
                                    float[] numArray3 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { -0.6f, 0.6707f, 0.3711f });
                                    float[] numArray4 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { 0.6f, 5.0707f, 0.3711f });
                                    float[] numArray5 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[] { -0.6f, 5.0707f, 0.3711f });
                                    uint num2 = 250;
                                    uint hash = STRINGHASH("WEAPON_RPG");
                                    float num4 = 1500f;
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray2[0], numArray2[1], numArray2[2], numArray4[0], numArray4[1], numArray4[2], num2, 0, hash, PID, 1, 1, num4 });
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[] { numArray3[0], numArray3[1], numArray3[2], numArray5[0], numArray5[1], numArray5[2], num2, 0, hash, PID, 1, 1, num4 });
                                }
                            }
                        }
                    }, token_25);
                }
            }

            public static void TaskBindBackwardBoostVehicleStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_17.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_17.IsCancellationRequested == true)
                    {
                        tokenSource_17 = new CancellationTokenSource();
                        token_17 = tokenSource_17.Token;
                    }
                    Task t17 = Task.Factory.StartNew(() =>
                    {
                        while (!token_17.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    Main.BackwardBoostVehicle();
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    Main.BackwardBoostVehicle();
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    Main.BackwardBoostVehicle();
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    Main.BackwardBoostVehicle();
                                }
                            }
                            else if (buttP == "L1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L1))
                                {
                                    Main.BackwardBoostVehicle();
                                }
                            }
                            else if (buttP == "DR")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.DpadRight))
                                {
                                    Main.BackwardBoostVehicle();
                                }
                            }
                        }
                    }, token_17);
                }
            }

            public static void TaskBindApplyNosVehicleStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_18.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_18.IsCancellationRequested == true)
                    {
                        tokenSource_18 = new CancellationTokenSource();
                        token_18 = tokenSource_18.Token;
                    }
                    int PID = PLAYER_PED_ID();

                    Task t18 = Task.Factory.StartNew(() =>
                    {
                        while (!token_18.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    int Veh = Main.GET_VEHICLE_PED_IS_IN(PID);
                                    int VehU = GET_PED_VEHICLE_IS_USING(PID);

                                    if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                                    {
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 1, 0);
                                        float[] Force = { 0, 10, 0 }, Position = { 0, 10, 0 };
                                        APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 0, 0);
                                    }
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    int Veh = Main.GET_VEHICLE_PED_IS_IN(PID);
                                    int VehU = GET_PED_VEHICLE_IS_USING(PID);

                                    if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                                    {
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 1, 0);
                                        float[] Force = { 0, 10, 0 }, Position = { 0, 10, 0 };
                                        APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 0, 0);
                                    }
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    int Veh = Main.GET_VEHICLE_PED_IS_IN(PID);
                                    int VehU = GET_PED_VEHICLE_IS_USING(PID);

                                    if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                                    {
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 1, 0);
                                        float[] Force = { 0, 10, 0 }, Position = { 0, 10, 0 };
                                        APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 0, 0);
                                    }
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    int Veh = Main.GET_VEHICLE_PED_IS_IN(PID);
                                    int VehU = GET_PED_VEHICLE_IS_USING(PID);

                                    if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                                    {
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 1, 0);
                                        float[] Force = { 0, 10, 0 }, Position = { 0, 10, 0 };
                                        APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 0, 0);
                                    }
                                }
                            }
                            else if (buttP == "L1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L1))
                                {
                                    int Veh = Main.GET_VEHICLE_PED_IS_IN(PID);
                                    int VehU = GET_PED_VEHICLE_IS_USING(PID);

                                    if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                                    {
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 1, 0);
                                        float[] Force = { 0, 10, 0 }, Position = { 0, 10, 0 };
                                        APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 0, 0);
                                    }
                                }
                            }
                            else if (buttP == "DR")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.DpadRight))
                                {
                                    int Veh = Main.GET_VEHICLE_PED_IS_IN(PID);
                                    int VehU = GET_PED_VEHICLE_IS_USING(PID);

                                    if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                                    {
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 1, 0);
                                        float[] Force = { 0, 10, 0 }, Position = { 0, 10, 0 };
                                        APPLY_FORCE_TO_ENTITY(Veh, Force, Position);
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, VehU, 0, 0);
                                    }
                                }
                            }
                        }
                    }, token_18);
                }
            }

            public static void TaskBindJumpCarStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_19.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_19.IsCancellationRequested == true)
                    {
                        tokenSource_19 = new CancellationTokenSource();
                        token_19 = tokenSource_19.Token;
                    }
                    int PID = PLAYER_PED_ID();
                    int Veh = GET_PED_VEHICLE_IS_USING(PID);
                    float[] jump = new float[3];
                    jump[1] = 5f;
                    jump[2] = 10f;

                    Task t19 = Task.Factory.StartNew(() =>
                    {
                        while (!token_19.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                }
                            }
                            else if (buttP == "L1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L1))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                }
                            }
                            else if (buttP == "DR")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.DpadRight))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                }
                            }
                        }
                    }, token_19);
                }
            }

            public static void TaskBindStopVehStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_21.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_21.IsCancellationRequested == true)
                    {
                        tokenSource_21 = new CancellationTokenSource();
                        token_21 = tokenSource_21.Token;
                    }
                    int PID = PLAYER_PED_ID();
                    int Veh = GET_PED_VEHICLE_IS_USING(PID);

                    Task t21 = Task.Factory.StartNew(() =>
                    {
                        while (!token_21.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    VEHICLE_SPEED(Veh, 0f);
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    VEHICLE_SPEED(Veh, 0f);
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    VEHICLE_SPEED(Veh, 0f);
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    VEHICLE_SPEED(Veh, 0f);
                                }
                            }
                            else if (buttP == "L1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L1))
                                {
                                    VEHICLE_SPEED(Veh, 0f);
                                }
                            }
                            else if (buttP == "DR")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.DpadRight))
                                {
                                    VEHICLE_SPEED(Veh, 0f);
                                }
                            }
                        }
                    }, token_21);
                }
            }

            public static void TaskBindCatapultVehStart(bool toggle, string buttP)
            {
                if (toggle == false)
                {
                    tokenSource_22.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_22.IsCancellationRequested == true)
                    {
                        tokenSource_22 = new CancellationTokenSource();
                        token_22 = tokenSource_22.Token;
                    }
                    int PID = PLAYER_PED_ID();
                    int Veh = GET_PED_VEHICLE_IS_USING(PID);
                    float[] catap = new float[3];
                    catap[1] = 30f;
                    catap[2] = 70f;

                    Task t22 = Task.Factory.StartNew(() =>
                    {
                        while (!token_22.IsCancellationRequested)
                        {
                            if (buttP == "R1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R1))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                }
                            }
                            else if (buttP == "L2")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L2))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                }
                            }
                            else if (buttP == "R3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.R3))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                }
                            }
                            else if (buttP == "L3")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L3))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                }
                            }
                            else if (buttP == "L1")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.L1))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                }
                            }
                            else if (buttP == "DR")
                            {
                                if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.DpadRight))
                                {
                                    APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                }
                            }
                        }
                    }, token_22);
                }
            }

            public static void TaskRandomResprayStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_12.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_12.IsCancellationRequested == true)
                    {
                        tokenSource_12 = new CancellationTokenSource();
                        token_12 = tokenSource_12.Token;
                    }
                    int PID = PLAYER_PED_ID();

                    Task t12 = Task.Factory.StartNew(() =>
                    {
                        while (!token_12.IsCancellationRequested)
                        {
                            if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                            {
                                int Veh = GET_PED_VEHICLE_IS_IN(PID);
                                SET_VEHICLE_CUSTOM_PRIM_COLOR(Veh, GET_RANDOM_INT_IN_RANGE(0, 255), GET_RANDOM_INT_IN_RANGE(0, 255), GET_RANDOM_INT_IN_RANGE(0, 255));
                                SET_VEHICLE_CUSTOM_SEC_COLOR(Veh, GET_RANDOM_INT_IN_RANGE(0, 255), GET_RANDOM_INT_IN_RANGE(0, 255), GET_RANDOM_INT_IN_RANGE(0, 255));
                            }
                        }
                    }, token_12);
                }
            }

            public static void TaskTireSmokeLoopStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_13.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_13.IsCancellationRequested == true)
                    {
                        tokenSource_13 = new CancellationTokenSource();
                        token_13 = tokenSource_13.Token;
                    }
                    int PID = PLAYER_PED_ID();

                    Task t13 = Task.Factory.StartNew(() =>
                    {
                        while (!token_13.IsCancellationRequested)
                        {
                            if (IS_PED_IN_ANY_VEHICLE(PID) != 0)
                            {
                                int Veh = GET_PED_VEHICLE_IS_IN(PID);

                                ClassicRPC.NCall(NewNatives.TOGGLE_VEHICLE_MOD, Veh, 20, 1);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0xFE, 0xFE, 0xFE);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 1, 1, 1);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0, 0, 0xFF);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0xFF, 0, 0);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0xFF, 0xFF, 0);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0x96, 0, 0xFF);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0xFF, 0xAF, 0);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0, 0xFF, 0);
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, Veh, 0xFF, 0, 0xFF);
                            }
                        }
                    }, token_13);
                }
            }

            public static void TaskDropMoneyStart(bool toggle, int moneyhash, int clientPED)
            {
                if (toggle == false)
                {
                    tokenSource_6.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_6.IsCancellationRequested == true)
                    {
                        tokenSource_6 = new CancellationTokenSource();
                        token_6 = tokenSource_6.Token;
                    }
                    int PID = PLAYER_PED_ID();

                    Task t6 = Task.Factory.StartNew(() =>
                    {
                        while (!token_6.IsCancellationRequested)
                        {
                            float[] Coord = GET_ENTITY_COORDS(clientPED);
                            CREATE_AMBIENT_PICKUP3(moneyhash, Coord, 0x7d0);
                        }
                    }, token_6);
                }
            }

            public static void TaskSuperRunStart(bool toggle)
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
                            int Me = PLAYER_PED_ID();

                            if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.X))
                            {
                                float[] Force = { 0, 30, 0 }, Position = { 0, 30, 0 };
                                APPLY_FORCE_TO_ENTITY(Me, Force, Position);
                            }
                        }
                    }, token_0);
                }
            }

            public static void TaskMultiSuperJumpStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_27.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_27.IsCancellationRequested == true)
                    {
                        tokenSource_27 = new CancellationTokenSource();
                        token_27 = tokenSource_27.Token;
                    }
                    Task t27 = Task.Factory.StartNew(() =>
                    {
                        while (!token_27.IsCancellationRequested)
                        {
                            int Me = PLAYER_PED_ID();

                            if (ButtonMonitoring.IS_CONTROL_PRESSED(0, ButtonMonitoring.Buttons.Square))
                            {
                                float[] Force = { 0, 15, 15 }, Position = { 0, 15, 15 };
                                APPLY_FORCE_TO_ENTITY(Me, Force, Position);
                            }
                        }
                    }, token_27);
                }
            }

            public static void TaskNetworkControlStart(bool toggle)
            {
                if (toggle == false)
                {
                    tokenSource_26.Cancel();
                }
                if (toggle == true)
                {
                    if (tokenSource_26.IsCancellationRequested == true)
                    {
                        tokenSource_26 = new CancellationTokenSource();
                        token_26 = tokenSource_26.Token;
                    }
                    Task t26 = Task.Factory.StartNew(() =>
                    {
                        while (!token_26.IsCancellationRequested)
                        {
                            int Me = PLAYER_PED_ID();
                            Main.NewRequestNetworkControl(Me);
                        }
                    }, token_26);
                }
            }
            #endregion

            public static uint STRINGHASH(string string_0)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(string_0.ToLower());
                uint num = 0;
                for (int i = 0; i < bytes.Length; i++)
                {
                    uint num3 = num + bytes[i];
                    uint num4 = num3 + (num3 << 10);
                    num = num4 ^ (num4 >> 6);
                }
                uint num5 = num + (num << 3);
                uint num6 = num5 ^ (num5 >> 11);
                return (num6 + (num6 << 15));
            }

            public static int GET_CURRENT_PED_WEAPON(int ped)
            {
                ClassicRPC.Call(Natives.GET_CURRENT_PED_WEAPON, ped, 0x10030340, 1);
                return PS3.Extension.ReadInt32(0x10030340);
            }

            public static void SET_PED_WEAPON_TINT_INDEX(int ped, uint hashw, int color)
            {
                ClassicRPC.CallwHash("0xEB2A7B23", ped, hashw, color);
            }

            public static void TASK_PLAY_ANIMATION(int Entity, string AnimDict, string Anim)
            {
                RPCHook.CompleteReq();
                RPCHook.Call(Natives.REQUEST_ANIM_DICT, new object[] { AnimDict });
                RPCHook.CompleteReq();
                while (RPCHook.Call(Natives.HAS_ANIM_DICT_LOADED, new object[] { AnimDict }) == 0);
                if (RPCHook.Call(Natives.HAS_ANIM_DICT_LOADED, new object[] { AnimDict }) == 1)
                {
                    RPCHook.Call(Natives.TASK_PLAY_ANIM, new object[] { Entity, AnimDict, Anim, 8f, 0, -1, 9, 0, 0, 0, 0 });
                }
            }

            public static void CREATE_AMBIENT_PICKUP(uint Offset, float[] Coord, int in1, int value, uint oft, int in2, int in3)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[] { Offset, Coord, in1, value, oft, in2, in3 });
            }
            
            public static void CREATE_AMBIENT_PICKUP_ST(uint Offset, float[] Coord, int val)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[] { Offset, Coord, 0, val, 1, 0, 1 });
            }

            public static void SET_ENTITY_PROOFS(int entity, bool bulletProof, bool fireProof, bool explosionProof, bool collisionProof, bool meleeProof, bool p6, bool p7, bool drownProof)
            {
                RPC3.Call(Natives.SET_ENTITY_PROOFS, entity, bulletProof, fireProof, explosionProof, collisionProof, meleeProof, p6, p7, drownProof);
            }

            public static void SET_VEHICLE_STRONG(int vehicle, bool toggle)
            {
                RPC3.Call(Natives.SET_VEHICLE_STRONG, vehicle, toggle);
            }

            public static void SET_VEHICLE_CAN_BREAK(int vehicle, bool toggle)
            {
                RPC3.Call(Natives.SET_VEHICLE_CAN_BREAK, vehicle, toggle);
            }

            public static void CREATE_AMBIENT_PICKUP2(int Offset, float[] Coord, int in1, int value, int oft, int in2, int in3)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[] { Offset, Coord, in1, value, oft, in2, in3 });
            }

            public static void CREATE_AMBIENT_PICKUP3(int Model, float[] Coord, int in1)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[] { Model, Coord, 0, in1, 1, 0, 1 });
            }

            public static void DELETE_ENTITY(int Entity)
            {
                ClassicRPC.NCall(NewNatives.DELETE_ENTITY, new object[] { Entity });
            }

            public static int GET_PED_MONEY(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_MONEY, new object[] { Player, 1 });
            }

            public static int GET_PED_NEARBY_PEDS(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_NEARBY_PEDS, new object[] { Player });
            }

            public static int GET_PED_NEARBY_VEHICLES(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_NEARBY_VEHICLES, new object[] { Player });
            }

            public static void DELETE_VEHICLE(int Vehicle)
            {
                ClassicRPC.HookCall(Natives.DELETE_VEHICLE, new object[] { Vehicle });
            }

            public static int GET_PLAYERS_LAST_VEHICLE(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PLAYERS_LAST_VEHICLE, new object[] { Player });
            }

            public static int NETWORK_GET_HOST_OF_SCRIPT(string Mod, int unk1, int unk2)
            {
                return ClassicRPC.NCall(NewNatives.NETWORK_GET_HOST_OF_SCRIPT, new object[] { Mod, unk1, unk2 });
            }

            public static void CLEAR_AREA(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA, new object[] { Pos, Dis, 0, 0, 0, 0 });
            }

            public static void CLEAR_AREA_OF_COPS(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_COPS, new object[] { Pos, Dis, 0 });
            }

            public static void CLEAR_AREA_OF_OBJECTS(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_OBJECTS, new object[] { Pos, Dis, 0 });
            }

            public static void CLEAR_AREA_OF_VEHICLES(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_VEHICLES, new object[] { Pos, Dis, 0, 0, 0, 0, 0 });
            }

            public static void CLEAR_AREA_OF_PEDS(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_PEDS, new object[] { Pos, Dis, 0 });
            }

            public static void CLEAR_AREA_OF_PROJECTILES(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_PROJECTILES, new object[] { Pos, Dis, 0 });
            }

            public static int CREATE_OBJECT(uint uint_0, float[] float_0)
            {
                return ClassicRPC.NCall(NewNatives.CREATE_OBJECT, new object[] { uint_0, float_0, 1, 1, 0 });
            }

            public static int GET_ENTITY_HEADING(int ind)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_HEADING, new object[] { ind });
            }

            public static int CREATE_VEHICLE(int ind, float[] Pos, int Head, int int_0, int int_1)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_HEADING, new object[] { ind, Pos, Head, int_0, int_1 });
            }

            public static void VEHICLE_SPEED(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_FORWARD_SPEED, new object[] { int_0, float_0 });
            }

            public static void SET_VEHICLE_ENGINE_ON(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_ENGINE_ON, new object[] { int_0, int_1, int_2 });
            }

            public static void VEHICLE_GRAVITY(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_GRAVITY, new object[] { int_0, int_1 });
            }

            public static void VEHICLE_ENGINE_HEALTH(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_ENGINE_HEALTH, new object[] { int_0, float_0 });
            }

            public static void VEHICLE_PETROL_TANK_HEALTH(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_PETROL_TANK_HEALTH, new object[] { int_0, float_0 });
            }

            public static void SET_ENTITY_HEALTH(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_HEALTH, new object[] { int_0, int_1 });
            }

            public static void REQUEST_IPL(string string_0)
            {
                ClassicRPC.NCall(NewNatives.REQUEST_IPL, new object[] { string_0 });
            }

            public static void REMOVE_IPL(string string_0)
            {
                ClassicRPC.NCall(NewNatives.REMOVE_IPL, new object[] { string_0 });
            }

            public static void START_ENTITY_FIRE(int int_0)
            {
                ClassicRPC.NCall(NewNatives.START_ENTITY_FIRE, new object[] { int_0 });
            }

            public static void REDUCE_GRIP(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_REDUCE_GRIP, new object[] { int_0, int_1 });
            }

            public static void ENTITY_CAN_BE_DAMAGED(int int_0, int int_1)
            {
                RPC3.Call(Natives.SET_ENTITY_CAN_BE_DAMAGED, new object[] { int_0, int_1 });
            }

            public static void RESET_PED_VISIBLE_DAMAGE(int int_0)
            {
                ClassicRPC.NCall(NewNatives.RESET_PED_VISIBLE_DAMAGE, new object[] { int_0 });
            }

            public static void VEHICLE_CAN_VISIBLY_DAMAGED(int int_0, int int_1)
            {
                RPC3.Call(Natives.SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED, new object[] { int_0, int_1 });
            }

            public static void REQUEST_COLLISION_AT_COORD(float[] Coord)
            {
                ClassicRPC.NCall(NewNatives.REQUEST_COLLISION_AT_COORD, new object[] { Coord });
            }

            public static void SET_VEHICLE_DOOR_OPEN(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOOR_OPEN, new object[] { int_0, int_1, int_2 });
            }

            public static void SET_VEHICLE_DOOR_SHUT(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOOR_SHUT, new object[] { int_0, int_1, int_2 });
            }

            public static void SET_VEHICLE_TYRE_SMOKE_COLOR(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[] { int_0, int_1, int_2, int_3 });
            }

            public static int GET_RANDOM_INT_IN_RANGE(int int_0, int int_1)
            {
                return ClassicRPC.NCall(NewNatives.GET_RANDOM_INT_IN_RANGE, new object[] { int_0, int_1 });
            }

            public static void SET_VEHICLE_CAN_BREAK(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_BRAKE, new object[] { int_0, int_1 });
            }

            public static void VEHICLE_UNDRIVEABLE(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_UNDRIVEABLE, new object[] { int_0, int_1 });
            }

            public static int IS_PED_IN_ANY_VEHICLE(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.IS_PED_IN_ANY_VEHICLE, new object[] { int_0, 0 });
            }

            public static void FIX_VEHICLE(int int_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_FIXED, new object[] { int_0 });
            }

            public static int GET_PED_VEHICLE_IS_IN(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_VEHICLE_PED_IS_IN, new object[] { int_0, new object[0] });
            }

            public static int GET_PED_VEHICLE_IS_USING(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_VEHICLE_PED_IS_USING, new object[] { int_0, new object[0] });
            }

            public static int PLAYER_PED_ID()
            {
                return ClassicRPC.NCall(NewNatives.PLAYER_PED_ID, new object[0]);
            }

            public static void OHK(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_WEAPON_DAMAGE_MODIFIER, new object[] { int_0, float_0 });
            }

            public static void SET_TIMECYCLE_MODIFIER(string wh)
            {
                ClassicRPC.NCall(NewNatives.SET_TIMECYCLE_MODIFIER, new object[] { wh });
            }

            public static void FTPCo(string IP)
            {
                ModsDL MDL = new ModsDL();
                MDL.ConnFTP(IP);
            }

            public static void FTPCoEB(string IP)
            {
                EBOOTS.EBOOTDL EB = new EBOOTS.EBOOTDL();
                EB.ConnFTP(IP);
            }

            public static void ENTITY_VISIBLE(int int_0, bool bool_0)
            {
                if (bool_0)
                {
                    ClassicRPC.NCall(NewNatives.SET_ENTITY_VISIBLE, new object[] { int_0, 1 });
                }
                else
                {
                    ClassicRPC.NCall(NewNatives.SET_ENTITY_VISIBLE, new object[] { int_0, 0 });
                }
            }

            public static void SET_MOVEMENTS(int PID, string Movement)
            {
                RPCHook.Call2<int>(OLDNatives.REQUEST_ANIM_DICT, new object[] { Movement });
                Thread.Sleep(500);
                RPCHook.CompleteReq();
                if (RPCHook.Call2<int>(OLDNatives.HAS_ANIM_DICT_LOADED, new object[] { Movement }) != 0)
                {
                    RPCHook.Call2<int>(OLDNatives.SET_PED_MOVEMENT_CLIPSET, new object[] { PID, Movement, 0x3e800000 });
                }
            }

            public static uint entityXCoord = 0x10030000;
            public static uint entityYCoord = 0x10030004;
            public static uint entityZCoord = 0x10030008;
            public static string[] Walk = new string[] { "move_m@casual@b", "move_m@drunk@verydrunk", "move_m@fat@a", "move_f@film_reel", "move_m@hiking", "move_m@business@a" };
            public static string[] Visions = new string[] { "DEFAULT", "stoned", "REDMIST", "DEATH", "stoned_aliens", "MichaelColorCode", "NeutralColorCode", "player_transition", "Bloom", "CHOP", "hud_def_blur",
                "PlayerSwitchPulse", "michealspliff", "BarryFadeOut", "Drunk", "drug_flying_base", "DRUG_gas_huffin", "drug_wobbly", "MP_heli_cam", "BlackOut", "phone_cam1", "phone_cam2", "phone_cam3", "phone_cam4", "phone_cam5",
                "phone_cam6", "phone_cam7", "phone_cam8", "phone_cam9", "phone_cam10", "phone_cam11", "phone_cam12", "phone_cam13" };

            #region BytesRTM
            public static byte[] AllHUDBlue = { 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f,
        0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff,
        0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8,
        0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d,
        0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f,
        0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff,
        0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8,
        0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d,
        0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f,
        0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff,
        0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8,
        0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d,
        0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f,
        0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff,
        0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8,
        0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d,
        0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f,
        0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff,
        0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8,
        0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d,
        0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f,
        0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff,
        0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff, 0x0f, 0x9d, 0xe8, 0xff };

            public static byte[] AllHUDGreen = { 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a,
        0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff,
        0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23,
        0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89,
        0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a,
        0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff,
        0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23,
        0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89,
        0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a,
        0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff,
        0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23,
        0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89,
        0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a,
        0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff,
        0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23,
        0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89,
        0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a,
        0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff,
        0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23,
        0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89,
        0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a,
        0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff,
        0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff, 0x3a, 0x89, 0x23, 0xff };

            public static byte[] AllHUDRed = { 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee,
        0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff,
        0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10,
        0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10,
        0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee,
        0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff,
        0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10,
        0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10,
        0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee,
        0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff,
        0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10,
        0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10,
        0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee,
        0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff,
        0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10,
        0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10,
        0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee,
        0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff,
        0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10,
        0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10,
        0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee,
        0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff,
        0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff, 0xee, 0x10, 0x10, 0xff };

            public static byte[] AllHUDOrange = { 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff,
        0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14,
        0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d,
        0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf,
        0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff,
        0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14,
        0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d,
        0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf,
        0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff,
        0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14,
        0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d,
        0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf,
        0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff,
        0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14,
        0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d,
        0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf,
        0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff,
        0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14,
        0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d,
        0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf,
        0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff,
        0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14,
        0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff, 0xdf, 0x6d, 0x14, 0xff };

            public static byte[] AllHUDPurple = { 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff,
        0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8,
        0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c,
        0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79,
        0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff,
        0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8,
        0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c,
        0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79,
        0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff,
        0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8,
        0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c,
        0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79,
        0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff,
        0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8,
        0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c,
        0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79,
        0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff,
        0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8,
        0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c,
        0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79,
        0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff,
        0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8,
        0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff, 0x79, 0x1c, 0xf8, 0xff };

            public static byte[] AllHUDPink = { 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd,
        0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff,
        0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92,
        0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f,
        0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd,
        0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff,
        0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92,
        0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f,
        0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd,
        0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff,
        0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92,
        0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f,
        0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd,
        0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff,
        0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92,
        0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f,
        0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd,
        0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff,
        0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92,
        0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f,
        0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd,
        0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff,
        0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff, 0xfd, 0x3f, 0x92, 0xff };

            public static byte[] AllHUDYellow = { 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff,
        0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d,
        0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0,
        0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7,
        0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff,
        0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d,
        0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0,
        0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7,
        0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff,
        0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d,
        0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0,
        0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7,
        0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff,
        0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d,
        0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0,
        0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7,
        0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff,
        0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d,
        0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0,
        0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7,
        0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff,
        0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d,
        0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff, 0xe7, 0xf0, 0x0d, 0xff };

            public static byte[] AllHUDBrown = { 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad,
        0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff,
        0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09,
        0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f,
        0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad,
        0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff,
        0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09,
        0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f,
        0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad,
        0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff,
        0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09,
        0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f,
        0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad,
        0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff,
        0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09,
        0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f,
        0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad,
        0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff,
        0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09,
        0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f,
        0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad,
        0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff,
        0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff, 0xad, 0x4f, 0x09, 0xff };

            public static byte[] AllHUDNormal = { 0x9B, 0x9B, 0x9B, 0xFF, 0xCD, 0xCD, 0xCD, 0xFF, 0x4D, 0x4D, 0x4D, 0xFF, 0xC2, 0x50, 0x50, 0xFF, 0xE1, 0xA8, 0xA8, 0xFF, 0x61, 0x28, 0x28, 0xFF, 0x5D,
        0xB6, 0xE5, 0xFF, 0xAE, 0xDB, 0xF2, 0xFF, 0x2F, 0x5C, 0x73, 0xFF, 0xF0, 0xC8, 0x50, 0xFF, 0xFE, 0xEB, 0xA9, 0xFF, 0x7E, 0x6B, 0x29, 0xFF, 0xFF, 0x85, 0x55, 0xFF, 0xFF, 0xC2, 0xAA, 0xFF,
        0x7F, 0x42, 0x2A, 0xFF, 0x66, 0x98, 0x68, 0xFF, 0xB3, 0xCC, 0xB4, 0xFF, 0x34, 0x4D, 0x35, 0xFF, 0x64, 0x4F, 0x8E, 0xFF, 0x4E, 0xA7, 0xC7, 0xFF, 0x32, 0x27, 0x47, 0xFF, 0xCB, 0x36, 0x94,
        0xFF, 0x35, 0x9A, 0x47, 0xFF, 0x5D, 0xB6, 0xE5, 0xFF, 0xEB, 0x24, 0x27, 0xFF, 0xC2, 0x50, 0x50, 0xFF, 0x9C, 0x6E, 0xAF, 0xFF, 0xFF, 0x7B, 0xC4, 0xFF, 0xE5, 0xB0, 0x93, 0xFF, 0xC7, 0x83,
        0xD1, 0xFF, 0xD7, 0xBD, 0x79, 0xFF, 0x8B, 0xB3, 0xA7, 0xFF, 0x7B, 0x9C, 0x54, 0xFF, 0x90, 0x7F, 0x99, 0xFF, 0x6A, 0xC4, 0xBF, 0xFF, 0xD6, 0xC4, 0x99, 0xFF, 0xEA, 0x8E, 0x50, 0xFF, 0x98,
        0xCB, 0xEA, 0xFF, 0xB2, 0x62, 0x87, 0xFF, 0x90, 0x8E, 0x7A, 0xFF, 0xA6, 0x75, 0x5E, 0xFF, 0xAF, 0xA8, 0xA8, 0xFF, 0xE8, 0x8E, 0x9B, 0xFF, 0xBB, 0xD6, 0x5B, 0xFF, 0x0C, 0x7B, 0x56, 0xFF,
        0x7B, 0xC4, 0xFF, 0xFF, 0xAB, 0x3C, 0xE6, 0xFF, 0xCE, 0xA9, 0x0D, 0xFF, 0x47, 0x63, 0xAD, 0xFF, 0x2A, 0xA6, 0xB9, 0xFF, 0xBA, 0x9D, 0x7D, 0xFF, 0xC9, 0xE1, 0xFF, 0xFF, 0xF0, 0xF0, 0x96,
        0xFF, 0xED, 0x8C, 0xA1, 0xFF, 0xF9, 0x8A, 0x8A, 0xFF, 0xFC, 0xEF, 0xA6, 0xFF, 0xF0, 0xF0, 0xF0, 0xFF, 0x9F, 0xC9, 0xA6, 0xFF, 0x8C, 0x8C, 0x8C, 0xFF, 0x8C, 0x8C, 0x8C, 0xFF, 0x28, 0x28,
        0x28, 0xFF, 0xF0, 0xA0, 0x00, 0xFF, 0xF0, 0xA0, 0x00, 0xFF, 0xF0, 0xA0, 0x00, 0xFF, 0x8C, 0x8C, 0x8C, 0xFF, 0x3C, 0x3C, 0x3C, 0xFF, 0x1E, 0x1E, 0x1E, 0xFF, 0x8C, 0x8C, 0x8C, 0xFF, 0x4B,
        0x4B, 0x4B, 0xFF, 0x32, 0x32, 0x32, 0xFF, 0x5F, 0x5F, 0x5F, 0xFF, 0x64, 0x64, 0x64, 0xFF, 0x61, 0x28, 0x28, 0xFF, 0x4E, 0x37, 0x57, 0xFF, 0x79, 0x28, 0x55, 0xFF, 0x72, 0x58, 0x49, 0xFF,
        0x63, 0x41, 0x68, 0xFF, 0x6B, 0x5E, 0x3C, 0xFF, 0x45, 0x59, 0x53, 0xFF, 0x3D, 0x4E, 0x2A, 0xFF, 0x48, 0x3F, 0x4C, 0xFF, 0x35, 0x62, 0x5F, 0xFF, 0x6B, 0x62, 0x4C, 0xFF, 0x75, 0x47, 0x28,
        0xFF, 0x4C, 0x65, 0x75, 0xFF, 0x41, 0x23, 0x2F, 0xFF, 0x48, 0x47, 0x3D, 0xFF, 0x55, 0x3A, 0x2F, 0xFF, 0x57, 0x54, 0x54, 0xFF, 0x74, 0x47, 0x4D, 0xFF, 0x5D, 0x6B, 0x2D, 0xFF, 0x06, 0x3D,
        0x2B, 0xFF, 0x3D, 0x62, 0x7F, 0xFF, 0x55, 0x1E, 0x73, 0xFF, 0x67, 0x54, 0x06, 0xFF, 0x23, 0x31, 0x56, 0xFF, 0x15, 0x53, 0x5C, 0xFF, 0x5D, 0x62, 0x3E, 0xFF, 0x64, 0x70, 0x7F, 0xFF, 0x78,
        0x78, 0x4B, 0xFF, 0x98, 0x4C, 0x5D, 0xFF, 0x7C, 0x45, 0x45, 0xFF, 0x0A, 0x2B, 0x32, 0xFF, 0x5F, 0x5F, 0x0A, 0xFF, 0xB4, 0x82, 0x61, 0xFF, 0x96, 0x99, 0xA1, 0xFF, 0xD6, 0xB5, 0x63, 0xFF,
        0xA6, 0xDD, 0xBE, 0xFF, 0x1D, 0x64, 0x99, 0xFF, 0xD6, 0x74, 0x0F, 0xFF, 0x87, 0x7D, 0x8E, 0xFF, 0xE5, 0x77, 0xB9, 0xFF, 0xFC, 0xEF, 0xA6, 0xFF, 0x2D, 0x6E, 0xB9, 0xBA, 0x00, 0x00, 0x00,
        0xFF, 0x5D, 0xB6, 0xE5, 0xFF, 0xC2, 0x50, 0x50, 0xFF, 0xF0, 0xC8, 0x50, 0xFF, 0x66, 0x98, 0x68, 0xFF, 0x66, 0x98, 0x68, 0xFF, 0x16, 0x37, 0x5C, 0xFF, 0x9A, 0x9A, 0x9A, 0xFF, 0xC2, 0x50,
        0x50, 0xFF, 0xFC, 0x73, 0xC9, 0xFF, 0xFC, 0xB1, 0x31, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x6D, 0xF7, 0xCC, 0xFF, 0xF1, 0x65, 0x22, 0xFF, 0xD6, 0xBD, 0x61, 0xFF, 0x61, 0x28, 0x28, 0xFF, 0x2F,
        0x5C, 0x73, 0xFF, 0x5D, 0xB6, 0xE5, 0xFF, 0xEA, 0x99, 0x1C, 0xFF, 0x0B, 0x37, 0x7B, 0xFF, 0x92, 0xC8, 0x3E, 0xFF, 0xEA, 0x99, 0x1C, 0xFF, 0x42, 0x59, 0x94, 0xBA, 0x00, 0x00, 0x00, 0xFF,
        0x66, 0x98, 0x68, 0xFF, 0xA4, 0x4C, 0xF2, 0xFF, 0x65, 0xB4, 0xD4, 0xFF, 0xAB, 0xED, 0xAB, 0xFF, 0xFF, 0xA3, 0x57, 0xFF, 0xF0, 0xF0, 0xF0, 0xFF, 0xEB, 0xEF, 0x1E, 0xFF, 0xFF, 0x95, 0x0E,
        0xFF, 0xF6, 0x3C, 0xA1, 0xFF, 0xD2, 0xA6, 0xF9, 0xFF, 0x52, 0x26, 0x79, 0x4D, 0x00, 0x00, 0x00, 0xFF, 0x48, 0x67, 0x74, 0xFF, 0x55, 0x76, 0x55, 0xFF, 0x7F, 0x51, 0x2B, 0xFF, 0xF0, 0xC8,
        0x50, 0xD7, 0x00, 0x00, 0x00, 0x7F, 0x64, 0x64, 0x64, 0xFF, 0x2D, 0x6E, 0xB9, 0xBF, 0xF0, 0xF0, 0xF0, 0xBA, 0x00, 0x00, 0x00, 0xFF, 0xAB, 0xED, 0xAB, 0xD7, 0x00, 0x00, 0x00, 0xFF, 0x00,
        0x47, 0x85, 0xFF, 0x00, 0x00, 0x00, 0xFF, 0x21, 0x76, 0x25, 0xFF, 0x25, 0x66, 0x28, 0xFF, 0xEA, 0x99, 0x1C, 0xFF, 0xE1, 0x8C, 0x08, 0xFF, 0x26, 0x2E, 0x33, 0xFF, 0x30, 0xFF, 0xFF, 0xFF,
        0x30, 0xFF, 0x00, 0xFF, 0xB0, 0x50, 0x00, 0xFF, 0xC2, 0x50, 0x50, 0xFF };
            #endregion

            public static float[] GET_COORDS(int int_0)
            {
                float[] numArray = new float[3];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[] { entityXCoord, int_0 });
                numArray[0] = PS3.Extension.ReadFloat(entityXCoord);
                numArray[1] = PS3.Extension.ReadFloat(entityYCoord);
                numArray[2] = PS3.Extension.ReadFloat(entityZCoord);
                return numArray;
            }
            /*
            public static float[] GET_ENTITY_COORDS_2(int PedID)
            {
                float[] numArray = new float[3];
                ClassicRPC.CompleteReq();
                ClassicRPC.Call(Natives.GET_ENTITY_COORDS, new object[] { 0x10031000, PedID });
                Thread.Sleep(20);
                return PS3.Extension.ReadFloats(0x10031000, 3);
            }
            */

            public static float GET_ENTITY_FORWARD_VECTOR(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_FORWARD_VECTOR, new object[] { Player });
            }

            public static float GET_ENTITY_FORWARD_X(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_FORWARD_X, new object[] { Player });
            }

            public static float GET_ENTITY_FORWARD_Y(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_FORWARD_Y, new object[] { Player });
            }

            public static float GET_ENTITY_SPEED(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_SPEED, new object[] { Player });
            }

            public static float[] GET_MY_X_COORDS(int int_0)
            {
                float[] numArray = new float[0];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[] { 268636160, int_0 });
                numArray[0] = PS3.Extension.ReadFloat(268636160U);
                return numArray;
            }

            public static float[] GET_MY_Y_COORDS(int int_0)
            {
                float[] numArray = new float[0];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[] { 268636164, int_0 });
                numArray[0] = PS3.Extension.ReadFloat(268636164U);
                return numArray;
            }

            public static float[] GET_MY_Z_COORDS(int int_0)
            {
                float[] numArray = new float[0];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[] { 268636168, int_0 });
                numArray[0] = PS3.Extension.ReadFloat(268636168U);
                return numArray;
            }

            public static void AMBIENT_PICKUP(int int_0, float[] float_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[] { int_0, float_0, 0, int_1, 1, 0, 1 });
            }

            public static void GiveWeapons(int int_0)
            {
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.KNIFE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.NIGHTSTICK, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.HAMMER, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.uint_0, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.GOLFCLUB, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.CROWBAR, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.PISTOL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.COMBATPISTOL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.APPISTOL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.PISTOL50, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.MICROSMG, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.uint_3, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.ASSAULTSMG, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.ASSAULTRIFLE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.CARBINERIFLE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.ADVANCEDRIFLE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.uint_1, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.COMBATMG, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.PUMPSHOTGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.SAWNOFFSHOTGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.ASSAULTSHOTGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.BULLPUPSHOTGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.STUNGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.SNIPERRIFLE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.HEAVYSNIPER, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.GRENADELAUNCHER, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.uint_2, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.MINIGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.GRENADE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.STICKYBOMB, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.SMOKEGRENADE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.BZGAS, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.MOLOTOV, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.FIREEXTINGUISHER, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.PETROLCAN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.BALL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.FLARE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.BOTTLE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.GUSENBERG, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.SPECIALCARBINE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.HEAVYPISTOL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.SNSPISTOL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.BULLPUPRIFLE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.DAGGER, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.VINTAGEPISTOL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.FIREWORK, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.MUSKET, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.HEAVYSHOTGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.MARKSMANRIFLE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.HOMINGLAUNCHER, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.PROXMINE, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.SNOWBALL, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.FLAREGUN, 0x270f, 0, 1 });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[] { int_0, Weapons.COMBATPDW, 0x270f, 0, 1 });
            }

            public static int GET_PLAYER_PED(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_PLAYER_PED, new object[] { int_0 });
            }

            public static void SET_NIGHT_V(int int_0)
            {
                ClassicRPC.Call(0x3BF544, new object[] { int_0 });
            }

            public static void GOD_MODE(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_INVINCIBLE, new object[] { int_0, int_1 });
            }

            public static void PED_RAGDOLL(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_CAN_RAGDOLL, new object[] { int_0, int_1 });
            }

            public static void INVITE_GAMER(string name)
            {
                byte[] buffer = new byte[8];
                buffer[3] = 2;
                PS3.Extension.WriteBytes(0x10020200, buffer);
                PS3.Extension.WriteString(0x10020208, name);
                ClassicRPC.Call(0x13321ec, new object[] { 0x40054ce0, 0x10020200, 1, 0, 0, 0, 0x540, 0x4ec, 0x59 });
            }

            public static void PED_RAGDOLL_IMPACT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT, new object[] { int_0, int_1 });
            }

            public static void CLEAR_PED_TASKS_IMMEDIATLY(int int_0)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_PED_TASKS_IMMEDIATELY, new object[] { int_0 });
            }

            public static void SCREEN_FADE_OUT(int ms)
            {
                ClassicRPC.NCall(NewNatives.DO_SCREEN_FADE_OUT, new object[] { ms });
            }

            public static int IS_PED_IN_VEHICLE(int ped)
            {
                return ClassicRPC.NCall(NewNatives.IS_PED_IN_ANY_VEHICLE, new object[] { ped, 0 });
            }

            public static void SET_ENTITY_COORDS(int entity, float[] coords)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COORDS, new object[] { entity, coords, 1, 0, 0, 1 });
            }

            public static void SET_ENTITY_COORDS2(int entity, float coords1, float coords2, float coords3)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COORDS, new object[] { entity, coords1, coords2, coords3, 1, 0, 0, 1 });
            }

            public static void CHANGE_PLAYER_PED(int ped)
            {
                ClassicRPC.Call(Natives.CHANGE_PLAYER_PED, new object[] { PLAYER_ID(), ped, 0, 0 });
            }

            public static uint GET_ENTITY_MODEL(int entity)
            {
                return (uint)ClassicRPC.Call(Natives.GET_ENTITY_MODEL, new object[] { entity });
            }

            public static string GET_VEH_NAME(int veh)
            {
                return PS3.Extension.ReadString((uint)ClassicRPC.Call(Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL, GET_ENTITY_MODEL(veh)));
            }

            public static uint FindOffset(uint StartOffset, int length, byte[] toFind, int add)
            {
                byte[] toSearch = new byte[length];
                PS3.GetMemory(StartOffset, toSearch);
                int num = 0;
                while (num + toFind.Length < toSearch.Length)
                {
                    bool flag = true;
                    for (int index = 0; index <= toFind.Length - 1; index++)
                    {
                        if (Convert.ToInt32(toSearch[num + index]) != Convert.ToInt32(toFind[index]))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        return StartOffset + Convert.ToUInt32(num + add);
                    }
                    num += 4;
                }
                return 0;
            }

            public static int GET_PLAYER_NAME_INT(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_PLAYER_NAME, new object[] { int_0 });
            }

            public static void SCREEN_FADE_IN(int int_0)
            {
                ClassicRPC.NCall(NewNatives.DO_SCREEN_FADE_IN, new object[] { int_0 });
            }

            public static int PLAYER_ID()
            {
                return ClassicRPC.NCall(NewNatives.PLAYER_ID, new object[0]);
            }

            public static void FREEZE_ENTITY_POSITION(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.FREEZE_ENTITY_POSITION, new object[] { int_0, int_1 });
            }

            public static void NETWORK_REQUEST_CONTROL_ENTITY(int int_0)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_REQUEST_CONTROL_OF_ENTITY, new object[] { int_0 });
            }

            public static void SET_VEHICLE_ENGINE_HEALTH(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_ENGINE_HEALTH, new object[] { int_0, float_0 });
            }

            public static void SET_VEHICLE_MOD_KIT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_MOD_KIT, new object[] { int_0, int_1 });
            }

            public static void REMOVE_VEHICLE_MOD_KIT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.REMOVE_VEHICLE_MOD_KIT, new object[] { int_0, int_1 });
            }

            public static void REMOVE_VEHICLE_MOD(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.REMOVE_VEHICLE_MOD, new object[] { int_0, int_1 });
            }

            public static void SET_VEHICLE_WINDOW_TINT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_WINDOW_TINT, new object[] { int_0, int_1 });
            }

            public static void SET_VEHICLE_WHEEL_TYPE(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_WHEEL_TYPE, new object[] { int_0, int_1 });
            }

            public static void NETWORK_SPENT_CASH_DROP(int int_0)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_SPENT_CASH_DROP, new object[] { int_0 });
            }

            public static void SET_MAX_WANTED_LEVEL(int Level)
            {
                ClassicRPC.NCall(NewNatives.SET_MAX_WANTED_LEVEL, new object[] { Level });
            }

            public static void PLAYERPED_NETWORK_SPENT_CASH_DROP(int player, int int_0)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_SPENT_CASH_DROP, new object[] { player, int_0 });
            }

            public static float[] GET_ENTITY_COORDS(int getplayerped)
            {
                float[] numArray = new float[3];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, (object)268636160, (object)getplayerped);
                numArray[0] = PS3.Extension.ReadFloat(268636160U);
                numArray[1] = PS3.Extension.ReadFloat(268636164U);
                numArray[2] = PS3.Extension.ReadFloat(268636168U);
                return numArray;
            }

            public static void SET_VEHICLE_COLOURS(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_COLOURS, new object[] { int_0, int_1, int_2 });
            }

            public static void TOGGLE_VEHICLE_MOD(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.TOGGLE_VEHICLE_MOD, new object[] { int_0, int_1, int_2 });
            }

            public static void SET_VEHICLE_NUMBER_PLATE_TEXT(int int_0, string txt)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_NUMBER_PLATE_TEXT, new object[] { int_0, txt });
            }

            public static void SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX, new object[] { int_0, int_1 });
            }

            public static void SET_VEHICLE_MOD(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_MOD, new object[] { int_0, int_1, int_2 });
            }

            public static void SET_VEHICLE_MOD2(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_MOD, new object[] { int_0, int_1, int_2, int_3 });
            }

            public static void SET_VEHICLE_CUSTOM_PRIM_COLOR(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_CUSTOM_PRIMARY_COLOUR, new object[] { int_0, int_1, int_2, int_3 });
            }

            public static void SET_VEHICLE_CUSTOM_SEC_COLOR(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_CUSTOM_SECONDARY_COLOUR, new object[] { int_0, int_1, int_2, int_3 });
            }

            public static void ATTACH_ENTITY_TO_ENTITY(int Player1, int Player2, float[] Coord)
            {
                ClassicRPC.Call(Natives.ATTACH_ENTITY_TO_ENTITY, new object[] { Player1, Player2, Coord });
            }

            public static int NEW_ATTACH_ENTITY_TO_ENTITY(int ent1, int ent2)
            {
                return ClassicRPC.Call(Natives.ATTACH_ENTITY_TO_ENTITY, new object[] { ent1, ent2, 0, 0x10030010, 0x10030010, 0, 0, 0, 0, 2, 0 });
            }
            public static int NEW_DETACH_ENTITY(int entity)
            {
                return ClassicRPC.Call(Natives.DETACH_ENTITY, entity, 1, 1);
            }

            public static void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(int Player1, int Player2, float[] Coord)
            {
                ClassicRPC.NCall(NewNatives.ATTACH_ENTITY_TO_ENTITY_PHYSICALLY, new object[] { Player1, Player2, Coord });
            }

            public static void DISABLE_PLAYER_FIRING(int Player, bool Value)
            {
                ClassicRPC.NCall(NewNatives.DISABLE_PLAYER_FIRING, new object[] { Player, Value });
            }

            public static void EXPLODE_VEHICLE(int Vehicle, int t, int r)
            {
                ClassicRPC.NCall(NewNatives.EXPLODE_VEHICLE, new object[] { Vehicle, t, r });
            }

            public static void NETWORK_EXPLODE_VEHICLE(int Vehicle)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_EXPLODE_VEHICLE, new object[] { Vehicle });
            }

            /*
            public static int TELEPORT_TO_CLOSEST_VEHICLE()
            {
                int veh = GET_CLOSEST_VEHICLE(GET_BLIP_ID());
                int ped = PLAYER_PED_ID();
                SET_PED_INTO_VEHICLE(ped, veh);
                return veh;
            }

            public static float[] GET_BLIP_ID()
            {
                ClassicRPC.Call(Natives.GET_BLIP_COORDS, 0x10010500, GET_MAIN_PLAYER_BLIP_ID());
                return PS3.Extension.ReadFloats(0x10010500, 3);
            }
            */

            public static int GET_MAIN_PLAYER_BLIP_ID()
            {
                return ClassicRPC.CallwHash("get_main_player_blip_id");
            }

            public static int GET_CLOSEST_VEHICLE(float[] blipc)
            {
                return ClassicRPC.Call(Natives.GET_CLOSEST_VEHICLE, new object[] { blipc, 5000f, 0, 0 });
            }

            public static int GET_STREET_NAME_AT_COORD(float Coord)
            {
                return ClassicRPC.NCall(NewNatives.GET_STREET_NAME_AT_COORD, new object[] { Coord });
            }

            public static int GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(int Entity)
            {
                return ClassicRPC.NCall(NewNatives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL, new object[] { Entity });
            }

            public static void SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(int toggle)
            {
                ClassicRPC.HookCall(Natives.SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY, new object[] { toggle });
            }

            public static void SET_PED_INTO_VEHICLE(int Player, int Vehicle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_INTO_VEHICLE, new object[] { Player, Vehicle });
            }

            public static void SET_PED_INTO_VEHICLE2(int Player, int Vehicle, int Seat)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_INTO_VEHICLE, new object[] { Player, Vehicle, Seat });
            }

            public static void SET_PED_IS_DRUNK(int Player, bool Value)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_IS_DRUNK, new object[] { Player, Value });
            }

            public static void REMOVE_PARTICLE_FX_FROM_ENTITY(int Player)
            {
                ClassicRPC.HookCall(Natives.REMOVE_PARTICLE_FX_FROM_ENTITY, new object[] { Player });
            }

            public static bool HAS_PTFX_ASSET_LOADED(string FX)
            {
                if (RPCHook.Call(Natives.HAS_PTFX_ASSET_LOADED, new object[] { FX }) != 0)
                    return true;
                else return false;
            }

            public static void START_PARTICLE_FX_LOOPED_ON_ENTITY(string FX, int Entity)
            {
                RPCHook.Call(Natives.START_PARTICLE_FX_LOOPED_ON_ENTITY, new object[] { FX, Entity, 0.0, 0.0, -0.5, 0.0, 0.0, 0.0, 1.0, 0, 0, 0 });
            }

            public static void SET_PARTICLE_FX_LOOPED_COLOUR(int r, int g, int b)
            {
                RPCHook.Call(Natives.SET_PARTICLE_FX_LOOPED_COLOUR, new object[] { r, g, b });
            }

            public static void REQUEST_PTFX_ASSET(string FX)
            {
                RPCHook.Call(Natives.REQUEST_PTFX_ASSET, new object[] { FX });
            }

            public static void SET_PTFX_ASSET_NEXT_CALL(string FX)
            {
                ClassicRPC.Call(Natives.SET_PTFX_ASSET_NEXT_CALL, new object[] { FX });
            }

            public static void START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string FX, int Entity, uint bone)
            {
                ClassicRPC.NCall(NewNatives.START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE, new object[] { FX, Entity, 0, 0, 0, 0, 0, 0, bone, 0.1f, 0, 0, 0 });
            }

            public static void STOP_ENTITY_FIRE(int Entity)
            {
                ClassicRPC.NCall(NewNatives.STOP_ENTITY_FIRE, new object[] { Entity });
            }

            public static void CLEAR_PED_BLOOD_DAMAGE(int Player)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_PED_BLOOD_DAMAGE, new object[] { Player });
            }

            public static void OVERRIDE_WEATHER(string Weather)
            {
                ClassicRPC.NCall(NewNatives.SET_OVERRIDE_WEATHER, new object[] { Weather });
            }

            public static void SET_PED_INFINITE_AMMO_CLIP(int Player, int state)
            {
                ClassicRPC.HookCall(Natives.SET_PED_INFINITE_AMMO_CLIP, new object[] { Player, state });
            }

            public static void TASK_START_SCENARIO_AT_POSITION(int Ped, string Scenario, float x, float y, float z, float Heading, int p6, bool p7, bool p8)
            {
                ClassicRPC.HookCall(Natives.SET_PED_INFINITE_AMMO_CLIP, new object[] { Ped, Scenario, x, y, z, Heading, p6, p7, p8 });
            }

            public static bool IS_PLAYER_TARGETING_ENTITY(int PlayerIndex, int Me)
            {
                if (ClassicRPC.NCall(NewNatives.IS_PLAYER_TARGETTING_ENTITY, new object[] { PlayerIndex, Me }) != 0)
                    return true;
                else return false;
            }

            public static void SET_ENTITY_AS_MISSION_ENTITY(int Ped, int y, int z)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_AS_MISSION_ENTITY, new object[] { Ped, y, z });
            }

            public static void SET_ENTITY_COORDS_FOR_FORCE(int Ped, float x, float y, float z)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COORDS, new object[] { Ped, x, y, z, 0, 0, 0, 1 });
            }

            public static int IS_PED_SHOOTING(int PlayerIndex)
            {
                return ClassicRPC.NCall(NewNatives.IS_PLAYER_TARGETTING_ENTITY, new object[] { PlayerIndex });
            }

            public static int IS_ENTITY_IN_AIR(int PlayerIndex)
            {
                return ClassicRPC.NCall(NewNatives.IS_ENTITY_IN_AIR, new object[] { PlayerIndex });
            }

            public static float[] GET_CORDS_INFRONT(int Entity, float Dis)
            {
                float[] Coords = new float[3];
                Coords = GET_ENTITY_COORDS(Entity);
                Coords[0] = +Dis;
                return Coords;
            }

            public static int GET_CONTROL_VALUE(int st, int en)
            {
                return ClassicRPC.NCall(NewNatives.GET_CONTROL_VALUE, new object[] { st, en });
            }

            public static float[] GET_PED_LAST_WEAPON_IMPACT_COORD(int Ped)
            {
                float[] Coord = new float[3];
                ClassicRPC.NCall(NewNatives.GET_PED_LAST_WEAPON_IMPACT_COORD, new object[] { Ped, Coord });
                return Coord;
            }

            public static int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(int num)
            {
                return ClassicRPC.NCall(NewNatives.GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS, new object[] { num });
            }

            public static bool IS_VEHICLE_SEAT_FREE(int Veh, int Seat)
            {
                bool flag = false;
                if (ClassicRPC.NCall(NewNatives.IS_VEHICLE_SEAT_FREE, new object[] { Veh, Seat }) == 1)
                {
                    flag = true;
                }
                return flag;
            }

            public static int CREATE_OBJECT2(int hash, float[] Coord, int in1, int in2, int in3, int in4, int in5)
            {
                return ClassicRPC.NCall(NewNatives.CREATE_OBJECT, new object[] { hash, Coord, in1, in2, in3, in4, in5 });
            }

            public static int GET_PED_BONE_INDEX(int st, int en)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_BONE_INDEX, new object[] { st, en });
            }

            public static void SET_ENTITY_COLLISION(int Ped, int y)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COLLISION, new object[] { Ped, y });
            }

            public static void TASK_START_SCENARIO_IN_PLACE(int Ped, string Scenario)
            {
                ClassicRPC.HookCall(Natives.TASK_START_SCENARIO_IN_PLACE, new object[] { Ped, Scenario, 0, 1 });
            }

            public static void REQUEST_CUTSCENE(string Cutscene)
            {
                ClassicRPC.HookCall(Natives.REQUEST_CUTSCENE, new object[] { Cutscene, 8 });
            }

            public static int HAS_CUTSCENE_LOADED()
            {
                return ClassicRPC.HookCall(Natives.REQUEST_CUTSCENE, new object[0]);
            }

            public static void START_CUTSCENE(string Cutscene)
            {
                ClassicRPC.HookCall(Natives.START_CUTSCENE, new object[] { Cutscene });
            }

            public static void STOP_CUTSCENE_IMMEDIATELY()
            {
                ClassicRPC.HookCall(Natives.STOP_CUTSCENE_IMMEDIATELY, new object[0]);
            }

            public static void AttachObject(string obj, int list)
            {
                int PED = GET_PLAYER_PED(list);
                float[] PlayerCoords = GET_ENTITY_COORDS(PED);
                int attachobj;
                int hash = Main.GET_HASH_KEY(obj);
                Main.REQUEST_MODEL(hash);
                int head = GET_PED_BONE_INDEX(PED, 31086);
                if (Main.HAS_MODEL_LOADED(hash) != 0)
                {
                    attachobj = CREATE_OBJECT2(hash, PlayerCoords, 1, 1, 0, 0, 1);
                    Main.ATTACH_ENTITY_TO_ENTITY(attachobj, PED, Convert.ToInt32(Boneindices.SKEL_Head), 0.3f, 0.0f, 0.0f, 0.0f, 90f, 0.0f);
                }
            }

            public static void ATTACH_ENTITY_TO_ENTITY3(int obj, int y)
            {
                ClassicRPC.HookCall(Natives.ATTACH_ENTITY_TO_ENTITY, new object[] { obj, y, BoneIndices.SKEL_Head, 0.0, 0.0, 0.0, 0.0f, 90.0f, 0.50f, 0, 0, 0 });
            }

            public static int GET_PLAYER_GROUP(int Ped)
            {
                return ClassicRPC.HookCall(Natives.GET_PLAYER_GROUP, new object[] { Ped });
            }

            public static void SET_PED_AS_GROUP_LEADER(int Ped, int grouphandle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_AS_GROUP_LEADER, new object[] { Ped, grouphandle });
            }

            public static float[] GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(int Ped, float[] unk)
            {
                return RPCHook.Call2<float[]>(Natives.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS, new object[] { Ped, unk });
            }

            public static float[] GET_GAMEPLAY_CAM_ROT(int Dis)
            {
                return RPCHook.Call2<float[]>(Natives.GET_GAMEPLAY_CAM_ROT, new object[] { Dis });
            }

            public static void DRAW_LINE(float[] coord1, float[] coord2, int a, int r, int g, int b)
            {
                ClassicRPC.NCall(NewNatives.DRAW_LINE, new object[] { coord1, coord2, a, r, g, b });
            }

            public static void REQUEST_WEAPON_ASSET(int weapon, int unk, int unk2)
            {
                ClassicRPC.HookCall(Natives.REQUEST_WEAPON_ASSET, new object[] { weapon, unk, unk2 });
            }

            public static void SET_ENTITY_ROTATION(int entity, float[] val, int unk, int unk2)
            {
                ClassicRPC.HookCall(Natives.SET_ENTITY_ROTATION, new object[] { entity, val, unk, unk2 });
            }

            public static int GET_ENTITY_PITCH(int entity)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_PITCH, new object[] { entity });
            }

            public static bool DOES_ENTITY_EXIST(int entity)
            {
                if (RPC3.Call(Natives.DOES_ENTITY_EXIST, new object[] { entity }) != 0)
                    return true;
                else return false;
            }

            public static int GET_ENTITY_ROLL(int entity)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_ROLL, new object[] { entity });
            }

            public static void LocoMode()
            {
                int Me = PLAYER_PED_ID();
                if (IS_PED_IN_ANY_VEHICLE(Me) != 0)
                {
                    int Veh = GET_PED_VEHICLE_IS_IN(Me);
                    float Yaw = GET_ENTITY_HEADING(Veh);
                    float Pitch = GET_ENTITY_PITCH(Veh);
                    float Roll = GET_ENTITY_ROLL(Veh);
                    Yaw += 2;
                    float[] Rot = new float[3];
                    Rot[0] = Pitch; Rot[1] = Roll; Rot[2] = Yaw;
                    SET_ENTITY_ROTATION(Veh, Rot, 2, 1);
                }
            }

            public static void DropPickup(float[] Location, string PickupModel, string PickupBehavior, int PickupAmount, string DisplayName, int Client)
            {
                int Model = Main.GET_HASH_KEY(PickupModel);
                int Behavior = Main.GET_HASH_KEY(PickupBehavior);

                Main.REQUEST_MODEL(Model);
                if (Main.HAS_MODEL_LOADED(Model) != 0)
                {
                    CREATE_AMBIENT_PICKUP2(Behavior, Location, 0, PickupAmount, Model, 0, 2);
                    Main.SET_MODEL_AS_NO_LONGER_NEEDED(Model);
                }
            }

            public static void AimingLaser()
            {
                int Me = PLAYER_PED_ID();
                int VehIn = GET_PED_VEHICLE_IS_IN(Me);
                float[] idk1 = { 0.6f, 0.6707f, 0.3711f };
                float[] idk2 = { -0.6f, 0.6707f, 0.3711f };
                float[] idk3 = { 0.6f, 25.0707f, 0.3711f };
                float[] idk4 = { -0.6f, 25.0707f, 0.3711f };

                float[] getcoords1 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(VehIn, idk1);
                float[] getcoords2 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(VehIn, idk2);
                float[] getcoords3 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(VehIn, idk3);
                float[] getcoords4 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(VehIn, idk4);
                DRAW_LINE(getcoords1, getcoords3, 255, 0, 0, 255);
                DRAW_LINE(getcoords2, getcoords4, 255, 0, 0, 255);
            }

            public static void VehicleWeapon(string Bullet)
            {
                int Veh = GET_PED_VEHICLE_IS_IN(PLAYER_PED_ID());
                int launchDistance = 250;
                int weaponHash = Main.GET_HASH_KEY(Bullet);
                REQUEST_WEAPON_ASSET(weaponHash, 31, 0);
                float launchSpeed = 800.0f;

                float[] idkcoords1 = { 0.6f, 0.6707f, 0.3711f };
                float[] getcoords1 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, idkcoords1);

                float[] idkcoords2 = { -0.6f, 0.6707f, 0.3711f };
                float[] getcoords2 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, idkcoords2);

                float[] idkcoords3 = { 0.6f, 5.0707f, 0.3711f };
                float[] getcoords3 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, idkcoords3);

                float[] idkcoords4 = { -0.6f, 5.0707f, 0.3711f };
                float[] getcoords4 = GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, idkcoords4);

                SHOOT_SINGLE_BULLET_BETWEEN_COORDS(getcoords1, getcoords3, 0, 0, weaponHash, PLAYER_PED_ID(), 1, 1, launchSpeed);

                SHOOT_SINGLE_BULLET_BETWEEN_COORDS(getcoords2, getcoords4, 0, 0, weaponHash, PLAYER_PED_ID(), 1, 1, launchSpeed);
            }

            public static void SET_PED_AS_GROUP_MEMBER(int Ped, int grouphandle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_AS_GROUP_MEMBER, new object[] { Ped, grouphandle });
            }

            public static void SHOOT_SINGLE_BULLET_BETWEEN_COORDS(float[] coord1, float[] coord2, int distance, int unk3, int whash, int me, int unk1, int unk2, double lspeed)
            {
                RPCHook.Call2<int>("SHOOT_SINGLE_BULLET_BETWEEN_COORDS", new object[] { coord1, coord2, distance, unk3, whash, me, unk1, unk2, lspeed });
            }

            public static void SET_PED_NEVER_LEAVES_GROUP(int Ped, int grouphandle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_NEVER_LEAVES_GROUP, new object[] { Ped, grouphandle });
            }

            public static void SET_GROUP_FORMATION(int Ped, int formation)
            {
                ClassicRPC.NCall(NewNatives.SET_GROUP_FORMATION, new object[] { Ped, formation });
            }

            public static void SET_PED_ARMOUR(int Ped, int value)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_ARMOUR, new object[] { Ped, value });
            }

            public static int CLONE_PED(int Ped)
            {
                return RPCHook.Call(Natives.CLONE_PED, new object[] { Ped });
            }

            public static void SET_RADIO_TO_STATION_INDEX(int station)
            {
                ClassicRPC.HookCall(Natives.SET_RADIO_TO_STATION_INDEX, new object[] { station });
            }

            public static void SET_VEHICLE_UNDRIVEABLE(int Veh, bool toggle)
            {
                ClassicRPC.Call(Natives.SET_VEHICLE_UNDRIVEABLE, new object[] { Veh, toggle });
            }

            public static void SET_VEHICLE_TYRES_CAN_BURST(int Veh, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRES_CAN_BURST, new object[] { Veh, toggle });
            }

            public static void EXPLODE_PED_HEAD(int Ped, string WeapHash)
            {
                ClassicRPC.NCall(NewNatives.EXPLODE_PED_HEAD, new object[] { Ped, WeapHash });
            }

            public static void START_VEHICLE_ALARM(int Veh)
            {
                ClassicRPC.NCall(NewNatives.START_VEHICLE_ALARM, new object[] { Veh });
            }

            public static void ROLL_DOWN_WINDOWS(int Veh)
            {
                ClassicRPC.NCall(NewNatives.ROLL_DOWN_WINDOWS, new object[] { Veh });
            }

            public static void ROLL_DOWN_WINDOW(int Veh, int windowindex)
            {
                ClassicRPC.NCall(NewNatives.ROLL_DOWN_WINDOW, new object[] { Veh, windowindex });
            }

            public static void ROLL_UP_WINDOW(int Veh, int windowindex)
            {
                ClassicRPC.NCall(NewNatives.ROLL_UP_WINDOW, new object[] { Veh, windowindex });
            }

            public static void SET_VEHICLE_INDICATOR_LIGHTS(int Veh, int signal, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_INDICATOR_LIGHTS, new object[] { Veh, signal, toggle });
            }

            public static void DRAW_LIGHT_WITH_RANGE(float[] Coords, int r, int g, int b, float fl1, float fl2)
            {
                ClassicRPC.NCall(NewNatives.DRAW_LIGHT_WITH_RANGE, new object[] { Coords, r, g, b, fl1, fl2 });
            }

            public static void SET_VEHICLE_ON_GROUND_PROPERLY(int Veh)
            {
                RPC3.Call(Natives.SET_VEHICLE_ON_GROUND_PROPERLY, new object[] { Veh });
            }
            
            public static void TASK_PARACHUTE(int in1, int in2)
            {
                ClassicRPC.NCall(NewNatives.TASK_PARACHUTE, new object[] { in1, in2 });
            }

            public static void DRAW_LINE(float[] TargetPED)
            {
                float[] Pos = GET_ENTITY_COORDS(PLAYER_PED_ID());
                ClassicRPC.NCall(NewNatives.DRAW_LINE, new object[] { Pos, TargetPED, 255, 0, 0, 255 });
            }

            public static void SHAKE_GAMEPLAY_CAM(string in1, float in2)
            {
                ClassicRPC.Call(Natives.SHAKE_GAMEPLAY_CAM, new object[] { in1, in2 });
            }

            public static void APPLY_FORCE_TO_ENTITY(int Entity, float[] force, float[] pos)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[] { Entity, 1, force, pos, 0, 1, 1, 1, 0, 1 });
            }

            public static void APPLY_FORCE_TO_ENTITY_FOR_SUP(int Entity, int in1, int in2, int in3, int in4, int in5, int in6, int in7, int in8, int in9, int in10, int in11, int in12, int in13)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[] { Entity, in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 });
            }

            public static void APPLY_FORCE_TO_ENTITY_FOR_SUP2(int Entity, int in1, double in2, int in3, int in4, int in5, double in6, int in7, int in8, int in9, int in10, int in11, int in12, int in13)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[] { Entity, in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 });
            }

            public static void APPLY_FORCE_TO_ENTITY_FOR_SUP3(int Entity, int in1, int in2, int in3, double in4, int in5, int in6, int in7, int in8, int in9, int in10, int in11, int in12, int in13)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[] { Entity, in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 });
            }

            public static int GET_FIRST_BLIP_INFO_ID(int wp)
            {
                return ClassicRPC.NCall(NewNatives.GET_FIRST_BLIP_INFO_ID, new object[] { wp });
            }

            public static int DOES_BLIP_EXIST(int wp)
            {
                return ClassicRPC.NCall(NewNatives.GET_FIRST_BLIP_INFO_ID, new object[] { wp });
            }

            public static float[] GET_BLIP_COORDS(int wp)
            {
                return RPCHook.Call2<float[]>(Natives.GET_BLIP_COORDS, new object[] { wp });
            }

            public static void TeleToWayp()
            {
                while (ContinueWP)
                {
                    int WaypointID = GET_FIRST_BLIP_INFO_ID(8);
                    float[] WaypointCoords = GET_BLIP_COORDS(WaypointID);
                    float[] coordos = new float[3];
                    int Entity;
                    if (IS_PED_IN_ANY_VEHICLE(PLAYER_PED_ID()) == 1)
                    {
                        Entity = GET_PED_VEHICLE_IS_USING(PLAYER_PED_ID());
                    }
                    else
                    {
                        Entity = PLAYER_PED_ID();
                    }
                    float ZAxis = 0;
                    if (WaypointCoords[0] != 0 && WaypointCoords[1] != 0)
                    {
                        SET_ENTITY_COORDS(Entity, WaypointCoords);
                        ContinueWP = true;
                    }
                    if (ContinueWP)
                    {
                        coordos = GET_ENTITY_COORDS(Entity);
                        coordos[2] += 10.0f;
                        SET_ENTITY_COORDS(Entity, coordos);

                        //the tricks is working here i keep teleporting my entity and thats where all the magic is going ... as when you teleport your entity to your entity coords it lifts you up and up till ground found
                    }

                    if (RPC3.Call2<int>(Natives.GET_GROUND_Z_FOR_3D_COORD, coordos, ZAxis) != 0)
                    {
                        SET_ENTITY_COORDS2(Entity, coordos[0], coordos[1], ZAxis + 1.0f);
                        ZAxis = 0;
                        ContinueWP = false;
                    }
                }
            }

            public static bool IS_PLAYER_ALIVE(int PED)
            {
                if (ClassicRPC.NCall(NewNatives.IS_PLAYER_DEAD, new object[] { PED }) == 0)
                    return true;
                else return false;
            }

            public static int GET_PLAYER_RADIO_STATION_INDEX()
            {
                object nonloso = 0;
                return ClassicRPC.NCall(NewNatives.GET_PLAYER_RADIO_STATION_INDEX, nonloso);
            }

            public static void SET_POLICE_IGNORE_PLAYER(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_POLICE_IGNORE_PLAYER, new object[] { Player, Toggle });
            }

            public static void SET_EVERYONE_IGNORE_PLAYER(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_EVERYONE_IGNORE_PLAYER, new object[] { Player, Toggle });
            }

            public static void SET_PLAYER_FORCED_AIM(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_FORCED_AIM, new object[] { Player, Toggle });
            }

            public static void SET_PLAYER_FORCED_ZOOM(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_FORCED_ZOOM, new object[] { Player, Toggle });
            }

            public static void CLEAR_WANTED_LEVEL(int Player)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_PLAYER_WANTED_LEVEL, new object[] { Player });
            }

            public static void SET_WANTED_LEVEL(int Player, int Level)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_WANTED_LEVEL, new object[] { Player, Level });
            }

            public static void SET_PLAYER_INVINCIBLE(int Player, int toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_INVINCIBLE, new object[] { Player, toggle });
            }

            public static void NETWORK_EARN_FROM_ROCKSTAR(int Player, int value)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_EARN_FROM_ROCKSTAR, new object[] { Player, value });
            }

            public static void SET_VEHICLE_GRAVITY(int state, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_GRAVITY, new object[] { state, toggle });
            }

            public static void SET_VEHICLE_DOORS_LOCKED(int Veh, int toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOORS_LOCKED, new object[] { Veh, toggle });
            }

            public static void ADD_EXPLOSION(float[] coord, int ExType)
            {
                ClassicRPC.NCall(NewNatives.ADD_EXPLOSION, new object[] { coord, ExType, 5f, 0, 1, 5f });
            }

            public static int GET_FREE_SEAT(int Vehicle)
            {
                int numSeats = GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(Vehicle);
                int SeatIndex = -1;
                while (SeatIndex < numSeats)
                {
                    if (IS_VEHICLE_SEAT_FREE(Vehicle, SeatIndex))
                        return SeatIndex;
                    SeatIndex++;
                }
                return -2;
            }

            public static void TELEPORT_ME_TO_PLAYER_CAR(int Player)
            {
                int PedHandle = GET_PLAYER_PED(Player);
                if (IS_PED_IN_VEHICLE(PedHandle) != 0)
                {
                    int Vehicle = GET_PED_VEHICLE_IS_IN(PedHandle);
                    SET_PED_INTO_VEHICLE2(PLAYER_PED_ID(), Vehicle, GET_FREE_SEAT(Vehicle));
                }
            }

            public static void TELEPORT_PLAYER_TO_MY_CAR(int PlayerToTeleport)
            {
                int PedHandle = PLAYER_PED_ID();
                if (IS_PED_IN_VEHICLE(PedHandle) != 0)
                {
                    int Vehicle = GET_PED_VEHICLE_IS_IN(PedHandle);
                    SET_PED_INTO_VEHICLE2(GET_PLAYER_PED(PlayerToTeleport), Vehicle, GET_FREE_SEAT(Vehicle));
                }
            }

            public static int ATTACH_OBJECT_TO_PLAYER(int Hash, float[] coord, int ped)
            {
                int obj = CREATE_OBJECT_INT(Hash, coord);
                RPCHook.CompleteReq();
                ATTACH_PED_TO_PED(obj, ped);
                return obj;
            }

            public static int CREATE_OBJECT_INT(int hash, float[] coords)
            {
                return RPCHook.Call2<int>(Natives.CREATE_OBJECT, (object)hash, (object)coords, (object)1, (object)1, (object)0);
            }

            public static void ATTACH_OB_TO_ENTITY(int ObjToNet, int ToAttachID, int bone, float X, float Y, float Z, float RX, float RY, float RZ)
            {
                float[] numArray1 = new float[3];
                float[] numArray2 = new float[3];
                numArray1[0] += X;
                numArray1[1] += Y;
                numArray1[2] += Z;
                numArray2[0] += RX;
                numArray2[1] += RY;
                numArray2[2] += RZ;
                RPCHook.Call2<int>(Natives.ATTACH_ENTITY_TO_ENTITY, (object)ObjToNet, (object)ToAttachID, (object)bone, (object)numArray1, (object)numArray2, (object)1, (object)1, (object)1, (object)1, (object)2, (object)1);
            }

            public static void ATTACH_ENTITY_TO_ENTITY_2(int Ent, int Ent2, int Bone = 0, float f1 = 0f, float f2 = 0f, float f3 = 0f, float f4 = 0f, float f5 = 2f, float f6 = 0f, int i1 = 1, int i2 = 0)
            {
                RPCHook.Call2<int>(OLDNatives.ATTACH_ENTITY_TO_ENTITY, Ent, Ent2, Bone, f1, f2, f3, f4, f5, f6, 0, i1, i2, 0, 2, 1);
            }

            public static void ATTACH_PED_TO_PED(int toatt, int Ped)
            {
                RPCHook.Call2<int>(OLDNatives.ATTACH_ENTITY_TO_ENTITY, new object[] { toatt, Ped, 0, 0x10030010, 0x10030010, 0, 0, 0, 0, 2, 0 });
            }

            public static void DETACH_ENTITY_FROM_ENTITY(int todet, int ent)
            {
                RPCHook.Call2<int>(OLDNatives.DETACH_ENTITY, new object[] { todet, ent, 1 });
            }

            public static void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(int vehicle, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS, vehicle, toggle);
            }

            public static void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int Player, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER, vehicle, Player, toggle);
            }

            public static int CREATE_OBJECT_NEW(uint Hash, float[] Coords)
            {
                return ClassicRPC.NCall(NewNatives.CREATE_OBJECT, Hash, Coords, true, true, false);
            }

            public static void SHOW_NOTIFY(string txt)
            {
                NOTIFICATION_TYPE("STRING");
                NOTIFICATION_TEXT(txt);
                NOTIFICATION_SHOW(2000, 1);
            }

            public static void NOTIFICATION_TYPE(string type)
            {
                ClassicRPC.Call(Natives.NOTIFICATION_TYPE, new object[] { type });
            }

            public static void NOTIFICATION_TEXT(string type)
            {
                ClassicRPC.Call(Natives.NOTIFICATION_TEXT, new object[] { type });
            }

            public static void NOTIFICATION_SHOW(int MilliSec, int Enable)
            {
                ClassicRPC.Call(Natives.NOTIFICATION_SHOW, new object[] { MilliSec, Enable });
            }

            public static void PRINT(string txt, int MilliSec)
            {
                PRINT_TEXT_TYPE("STRING");
                PRINT_TEXT_TEXT(txt);
                PRINT_TEXT_TIME(MilliSec);
            }

            public static void PRINT_TEXT_TYPE(string type)
            {
                ClassicRPC.Call(Natives.PRINT_TEXT_TYPE, new object[] { type });
            }

            public static void PRINT_TEXT_TEXT(string txt)
            {
                ClassicRPC.Call(Natives.ADD_TEXT_COMPONENT_STRING, new object[] { txt });
            }

            public static void PRINT_TEXT_TIME(int sec)
            {
                ClassicRPC.Call(Natives.PRINT_TEXT_TIME, new object[] { sec });
            }

            public static void TASK_FOLLOW_NAV_MESH_TO_COORD(int Player, float[] Coords, int a, int b, int c, int d, int e)
            {
                ClassicRPC.NCall(NewNatives.TASK_FOLLOW_NAV_MESH_TO_COORD, new object[] { Player, Coords, a, b, c, d, e });
            }

            public static void NETWORK_SET_FRIENDLY_FIRE_OPTION(int am)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_SET_FRIENDLY_FIRE_OPTION, new object[] { am });
            }

            public static int GET_NEAREST_PLAYER_TO_ENTITY(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_NEAREST_PLAYER_TO_ENTITY, new object[] { Player });
            }

            public static void TASK_JUMP(int Player)
            {
                ClassicRPC.Call(Natives.TASK_JUMP, new object[] { Player });
            }
        }

        public static class ButtonMonitoring
        {
            public class Buttons
            {
                public static Int32
                X = 0xC1,
                O = 0xC3,
                Square = 0xC2,
                Triangle = 0xC0,
                L3 = 0xC8,
                R3 = 0xC9,
                L2 = 0xC6,
                R2 = 0xC7,
                L1 = 0xC4,
                R1 = 0xC5,
                DpadDown = 0xCB,
                DPadUp = 0xCA,
                DpadRight = 0xCD,
                DpadLeft = 0xCC;
            }

            public static bool IS_CONTROL_PRESSED(int Client, int Button)
            {
                bool state = false;
                if (ClassicRPC.NCall(NewNatives.IS_CONTROL_PRESSED, new object[] { Client, Button }) == 1)
                {
                    state = true;
                }
                return state;
            }

            public static int isButtonBeingPressed(int ButtonID)
            {
                return ClassicRPC.NCall(NewNatives.IS_DISABLED_CONTROL_PRESSED, new object[] { 0, ButtonID });
            }
        }
    }
}
