using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PS3Lib;

namespace LezZo_BO2_Extreme_Tool_xNew
{
    public class BO2
    {
        public static PS3API PS3 = new PS3API();
        public static bool rpcConnected = false;
        public static bool APIok = false;
        public static string APIused = "";
        public static string EBOOTtype = "";
        public static bool FTPconnected = false;

        public static void BO2ConnFTP(string PS3ip)
        {
            ModMenuManager.ModMenu.ConnFTP(PS3ip);
        }

        public class Offsets
        {
            public class Protection
            {
                #region Protection

                public static uint AntiBanSC58 = 0x4B8310;
                public static uint AntiBan2 = 0x50A38F;
                public static uint AntiBan3 = 0x50BA74;
                public static uint AntiBan4 = 0x547DD4;
                public static uint AntiBan5 = 0x548148;
                public static uint AntiBan6 = 0x50B61C;
                public static uint AntiBan7 = 0x50A3BC;
                public static uint AntiBan8 = 0x5300E8;
                public static uint AntiBan9 = 0x5300F4;
                #endregion
            }
            public class Nonhost
            {
                #region Non-host
                public static uint RedBox0 = 0x000783E0;
                public static uint RedBox1 = 0x00078604;
                public static uint Laser = 0xEF68C;
                public static uint VSAT = 0x00033C60;
                public static uint UAV = 0x33CB4;
                public static uint WallHack0 = 0x1CBF9F8;
                public static uint WallHack1 = 0x000834D0;
                public static uint SteadyAim = 0x5F0A20;
                public static uint FPS1 = 0x8E3590;
                public static uint FPS2 = 0x37FEC;
                public static uint AntiFreeze = 0x67B824;
                public static uint FPSText = 0x8E3290;
                public static uint BigNames = 0x01cc6e98;
                public static uint SkyColor = 0x01cc28d8;
                public static uint BodyColor = 0x01CC143C;
                public static uint FOV = 0x1CC52D8;
                public static uint NoRecoil = 0xF9E54;
                public static uint FloatingBodies = 0x1CD03D8;
                public static uint TargetFinder = 0x1CC4BF8;
                public static uint ForceHost = 0x1cd6018;
                public static uint BlinkingBoddies = 0xEF68C;
                public static uint SubjectInvite = 0x30933206;
                public static uint MessageInvite = 0x30933223;
                public static uint EndProbation = 0x53FC6C;
                public static uint SplitScreen = 0x01cbe2b8;
                public static uint MapR = 0x1CC52D8;
                public static uint Clan = 0x2708238;
                #endregion
            }
            public class Stats
            {
                #region Stats
                public static uint Prestige = 0x26FD014;
                public static uint Level = 0x26FD02D;
                public static uint LevelL = 0x26FD02C;
                public static uint Tokens = 0x2706938;
                public static uint Wins = 0x26FD152;
                public static uint Losses = 0x26FCBE2;
                public static uint Kills = 0x26FCBE2;
                public static uint Deaths = 0x26FC942;
                public static uint Score = 0x26FD050;
                public static uint TimePlayed = 0x26FD10A;
                public static uint HeadShots = 0x26FCA44;
                public static uint Unlock10Classes = 0x02708522;
                public static uint UnlockAll = 0x26FC870;
                public static uint GhostCard = 0x02708199;
                public static uint RoxannCard = 0x0270819C;
                public static uint FourGuns = 0x27078DC;
                public static uint EndProbation = 0x53FC6C;
                public static uint Level55 = 0x26FD016;
                public static uint AWTitle = 0x27078C0;
                //League Play
                public static uint LadderPoints = 0x196821B;
                public static uint SeasonWins = 0x1968310;
                public static uint CareerWins = 0x1968324;
                public static uint Winstreak = 0x1968320;
                public static uint Leaguebuffer = 0x0196821B;
                public static uint Primary = 0x27078BA;
                public static uint Secondary = 0x27078C8;
                public static uint PerkGreed1 = 0x27078d9;
                public static uint PerkGreed2 = 0x27078da;
                public static uint PerkGreed3 = 0x27078db;
                public static uint Lethal = 0x27078DC;
                public static uint Tactical = 0x27078DE;
                public static uint StickyLocalGameName = 0x26c0658;
                #endregion
            }
            public class Lobby
            {
                #region Lobby
                public static uint TimeScale = 0x1CB7BF8;
                public static uint Melee1 = 0x1CAF0D8;
                public static uint Melee2 = 0x1CAF138;
                public static uint Melee3 = 0x1CAF198;
                public static uint Jump = 0x005BE0B4;
                public static uint Speed = 0x1CA4E78;
                public static uint Gravity = 0x1CAF9D8;
                public static uint KnockBack = 0x01CA4ED8;
                public static uint RapidFire = 0x01CB2AF2;
                #endregion
            }

            public class Multiplayermods
            {
                #region MultiplayerMods
                public static uint AllPerks = 0x1781470;
                public static uint LobbyName = 0x026C0658;
                public static uint InGameName = 0x0178646c;
                public static uint ClanTagInGame = 0x17864D8;
                public static uint GodMode = 0x1780f43;
                public static uint POV3 = 0x1780fac;
                public static uint VSATIG = 0x1786717;
                public static uint Killstreak1 = 0x1781357;
                public static uint Killstreak2 = 0x1781359;
                public static uint Killstreak3 = 0x178135C;
                public static uint Speed2 = 0x1786418;
                public static uint SkateMod = 0x177DE37;
                public static uint Invisible = 0x1781025;
                public static uint Prone = 0x1786718;
                public static uint Freeze = 0x17865bf;
                public static uint lag = 0x1786363;
                public static uint TBAG = 0x1781027;
                public static uint EarthQuake = 0x1781087;
                public static uint WeaponFUp = 0x178641F;
                public static uint Jumper = 0x1786418;
                public static uint PlayerStatus = 0x178634B;
                public static uint PlayerTeam = 0x178642F;
                public static uint BlackScreen = 0x178102b;
                public static uint Vision = 0x178102B;
                public static uint PoisonVision = 0x178150B;
                public static uint NightVision = 0x1780F42;
                public static uint EMPVision = 0x1780F43;
                public static uint CamoOnline1 = 0x17811CB;
                public static uint CamoOnline2 = 0x17811AF;
                public static uint CamoLocal1 = 0x17811E7;
                public static uint CamoLocal2 = 0x1781203;
                public static uint G_Client = 0x1780F28;
                public static uint KillPlayer = 0x1780F58;
                public static uint AutoLoad = 0x4525F0;
                public static uint G_Spawn = 0x278AC0;
                public static uint Teleport = 0x1780F50;
                public static uint ChangeSC1 = 0x1781497;
                public static uint ChangeSC2 = 0x178148F;
                public static uint ChangeSC3 = 0x178148B;
                public static uint Enable1 = 0x1781487;
                public static uint Enable2 = 0x178147F;
                public static uint Enable3 = 0x178147B;
                public static uint PrimaryWeapon = 0x178118F;
                public static uint SecondaryWeapon = 0x17811C7;
                public static uint InGameName1 = 0x178BC74;
                public static uint InGameName2 = 0x179147C;
                public static uint InGameName3 = 0x1796C84;
                public static uint InGameName4 = 0x179C48C;
                public static uint InGameName5 = 0x17A1C94;
                public static uint InGameName6 = 0x17A749C;
                public static uint InGameName7 = 0x17ACCA4;
                public static uint InGameName8 = 0x17B24AC;
                public static uint InGameName9 = 0x17B7CB4;
                public static uint InGameName10 = 0x17BD4BC;
                public static uint InGameName11 = 0x17C2CC4;
                public static uint InGameName12 = 0x17C84CC;
                public static uint InGameName13 = 0x17CDCD4;
                public static uint InGameName14 = 0x17D34DC;
                public static uint InGameName15 = 0x17D8CE4;
                public static uint InGameName16 = 0x17DE4EC;
                public static uint InGameName17 = 0x17E3CF4;


                //Zombies
                public static uint PrimaryWeaponZm = 0x178118F;
                public static uint SecondaryWeaponZm = 0x17811C7;
                public static uint MuleKick = 0x17811E3;
                public static uint Lethal = 0x1781359;
                public static uint Tactical = 0x1781365;
                public static uint ammo1v1 = 0x1781355;
                public static uint ammo1v2 = 0x1781319;
                public static uint ammo1v3 = 0x1781339;
                public static uint ammo2v1 = 0x178135D;
                public static uint ammo2v2 = 0x1781321;

                #endregion
            }


            public class Classes
            {
                #region Classes
                public static uint Class1 = 0x2707AC7;
                public static uint Class2 = 0x2707AD7;
                public static uint Class3 = 0x2707AE7;
                public static uint Class4 = 0x2707AF7;
                public static uint Class5 = 0x2707B07;
                public static uint Class6 = 0x2707B17;
                public static uint Class7 = 0x2707B27;
                public static uint Class8 = 0x2707B37;
                public static uint Class9 = 0x2707B47;
                public static uint Class10 = 0x2707B57;
                #endregion
            }
            public class Client
            {
                #region  Clients Offsets
                public static uint Interval = 0x5808;
                public static uint HeldWeapon = 0x17810E3;
                public static uint Cbuf_AddText = 0x313c18;
                public static uint CamoLocal1 = 0x17811E7;
                public static uint CamoLocal2 = 0x1781203;
                public static uint CamoOnline1 = 0x17811CB;
                public static uint CamoOnline2 = 0x17811AF;
                #endregion
            }
        }

        public class MultiplayerWeapons
        {
            public class Multiplayer
            {
                public static class Weapons
                {
                    public static Byte[]
                    WEAPON_DEFAULTWEAPON = new Byte[] { 0x01 },
                    MP7 = new Byte[] { 0x02 },
                    PDW57 = new Byte[] { 0x04 },
                    Vector = new Byte[] { 0x06 },
                    MSMC = new Byte[] { 0x08 },
                    Chicom = new Byte[] { 0x0A },
                    Scorpion = new Byte[] { 0x0C },
                    PeaceKeeper = new Byte[] { 0x0E },
                    MTAR = new Byte[] { 0x10 },
                    Type25 = new Byte[] { 0x14 },
                    Swat = new Byte[] { 0x18 },
                    FAL = new Byte[] { 0x1C },
                    M27 = new Byte[] { 0x20 },
                    ScarH = new Byte[] { 0x24 },
                    SMR = new Byte[] { 0x28 },
                    M8A1 = new Byte[] { 0x2C },
                    An94 = new Byte[] { 0x30 },
                    Remington = new Byte[] { 0x34 },
                    S12 = new Byte[] { 0x35 },
                    KSG = new Byte[] { 0x36 },
                    M1216 = new Byte[] { 0x37 },
                    MK48 = new Byte[] { 0x38 },
                    QBBLSW = new Byte[] { 0x3A },
                    LSAT = new Byte[] { 0x3C },
                    HAMR = new Byte[] { 0x3E },
                    SVU = new Byte[] { 0x40 },
                    DSR50 = new Byte[] { 0x41 },
                    Ballista = new Byte[] { 0x42 },
                    XPR50 = new Byte[] { 0x43 },
                    KAP40x2 = new Byte[] { 0x44 },
                    TAC45x2 = new Byte[] { 0x46 },
                    FiveSevenX2 = new Byte[] { 0x48 },
                    Executionerx2 = new Byte[] { 0x4A },
                    b23rx2 = new Byte[] { 0x4C },
                    FiveSeven = new Byte[] { 0x4E },
                    TAC45 = new Byte[] { 0x4F },
                    B23r = new Byte[] { 0x50 },
                    Executioner = new Byte[] { 0x51 },
                    KAP40 = new Byte[] { 0x52 },
                    SMAW = new Byte[] { 0x54 },
                    FHJ18 = new Byte[] { 0x55 },
                    RPG = new Byte[] { 0x56 },
                    CombatKnife = new Byte[] { 0x57 },
                    AssaultShield = new Byte[] { 0x59 },
                    crossbow = new Byte[] { 0x5A },
                    ballisticknife = new Byte[] { 0x5B };

                }

                public static class LethalTactical
                {
                    public static Byte[]
                     Grenade = new Byte[] { 0x5C }, //lethal
                     Concussion = new Byte[] { 0x5D }, //tactical
                     Semtex = new Byte[] { 0x5E }, //lethal
                     SmokeGrenade = new Byte[] { 0x5F }, //tactical
                     CombatAx = new Byte[] { 0x60 }, //lethal
                     SensorGrenade = new Byte[] { 0x61 }, //tactical
                     BouncingBetty = new Byte[] { 0x62 }, //lethal
                     EMPGrenade = new Byte[] { 0x63 }, //tactical
                     C4 = new Byte[] { 0x64 }, //lethal
                     ShockCharge = new Byte[] { 0x65 }, //tactical
                     Claymore = new Byte[] { 0x66 }, //lethal
                     BlackHat = new Byte[] { 0x67 }, //tactical
                     FlashBang = new Byte[] { 0x68 }, //tactical
                     TrophySystem = new Byte[] { 0x69 }, //tactical
                     TacInsert = new Byte[] { 0x6A }, //tactical
                     ThrowableRCXD = new Byte[] { 0x6B }, //lethal?
                     ThrowableWMExplosive = new Byte[] { 0x6C }; //lethal?
                }

                public static void Give(Int32 Client, Byte[] Weapon)
                {
                    UInt32 G_ClientSize = 0x5808;
                    UInt32 Index = (UInt32)Client * G_ClientSize;
                    PS3.SetMemory(Offsets.Multiplayermods.PrimaryWeapon + Index, Weapon);
                    byte[] buffer1 = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0x00, 0xFF, 0xFF, 0xFF, 0xFF };
                    PS3.SetMemory(Offsets.Multiplayermods.ammo1v1 + Index, buffer1);
                    byte[] buffer2 = new byte[] { 0xFF, 0xFF, 0xFF };
                    PS3.SetMemory(Offsets.Multiplayermods.ammo1v2 + Index, buffer2);
                    byte[] buffer3 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0x00 };
                    PS3.SetMemory(Offsets.Multiplayermods.ammo1v3 + Index, buffer3);
                }
                public static void Give1(Int32 Client, Byte[] Weapon)
                {
                    //Secondary Weapon
                    UInt32 G_ClientSize = 0x5808;
                    UInt32 Index = (UInt32)Client * G_ClientSize;
                    byte[] buffer1 = new byte[] { 0xFF, 0xFF, 0xFF };
                    PS3.SetMemory(Offsets.Multiplayermods.ammo2v1 + Index, buffer1);
                    byte[] buffer2 = new byte[] { 0xFF, 0xFF, 0xFF };
                    PS3.SetMemory(Offsets.Multiplayermods.ammo2v2 + Index, buffer2);
                    PS3.SetMemory(Offsets.Multiplayermods.SecondaryWeapon + Index, Weapon);
                }

                public static void Give2(Int32 Client, Byte[] LethalTactical)
                {
                    //Lethal
                    UInt32 G_ClientSize = 0x5808;
                    UInt32 Index = (UInt32)Client * G_ClientSize;
                    byte[] buffer1 = new byte[] { 0xFF, 0xFF, 0xFF };
                    PS3.SetMemory(Offsets.Multiplayermods.Lethal + Index, buffer1);
                    PS3.SetMemory(Offsets.Multiplayermods.SecondaryWeapon + Index, LethalTactical);
                }
                public static void Give3(Int32 Client, Byte[] LethalTactical)
                {
                    //Tactical
                    UInt32 G_ClientSize = 0x5808;
                    UInt32 Index = (UInt32)Client * G_ClientSize;
                    byte[] buffer1 = new byte[] { 0xFF, 0xFF, 0xFF };
                    PS3.SetMemory(Offsets.Multiplayermods.Tactical + Index, buffer1);
                    PS3.SetMemory(Offsets.Multiplayermods.SecondaryWeapon + Index, LethalTactical);
                }
            }
        }

        public class MyFunc
        {
            public static void PS3Frezze(int int_0)
            {
                RPC.SV_GameSendServerCommand(int_0, "7 30 60");
            }

            public static void IPHider(uint client)
            {
                PS3.Extension.WriteBytes(0x00F9E726 + (client * 328), new byte[] { 0x23, 0x07, 0x49, 0x22, 0x33, 0x01 });
            }

            public static void AttachEntity(int Client, string Entity, string Tag)
            {
                int num = RPC.Call(0x48e718, new object[] { Tag });
                RPC.Call(0x27769c, new object[] { Cazz(Client, 0), Entity, num, 0 });
            }

            public static string ZombieMap()
            {
                return PS3.Extension.ReadString(0xED7A08);
            }

            public static void ChangeTeam(int int_0, byte byte_0)
            {
                PS3.Extension.WriteByte(0x1780F28 + 0x5507 + ((uint)(0x5808 * int_0)), byte_0);
            }

            public static void RemoveWeapons(int int_0)
            {
                PS3.SetMemory((uint)(0x1781170 + (0x5808 * int_0)), new byte[0x188]);
                if (rpcConnected)
                    RPC.iPrintln(0, "^2Weapon Removed");
            }

            public static void ScoreperKill(string string_2)
            {
                string str = PS3.Extension.ReadString(0xed7a48);
                Thread.Sleep(5);
                RPC.Cbuf_AddText("set scr_" + str + "_score_kill " + string_2);
            }

            public static void RoundsLimit(string string_2)
            {
                RPC.Cbuf_AddText("gametype_setting roundlimit " + string_2);
            }

            public static void ScoreLimit(string string_2)
            {
                RPC.Cbuf_AddText("gametype_setting scorelimit " + string_2);
            }

            public static void TimeLimit(string string_2)
            {
                RPC.Cbuf_AddText("gametype_setting timelimit " + string_2);
            }

            public static void LiveLimit(string string_2)
            {
                RPC.Cbuf_AddText("gametype_setting playerNumlives " + string_2);
            }

            public static void Vis(int int_0, string string_0)
            {
                RPC.SV_GameSendServerCommand(int_0, "2 1060 \"" + string_0 + "\"");
            }

            public static void ChangeName(string string_0)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(string_0);
                PS3.SetMemory(0x026C0658, buffer);
            }

            public static void ChangeName_2(string string_0)
            {
                PS3.Extension.WriteString(0x026C0658, string_0);
            }

            public static void TBagStart(int int_0, bool bool_26)
            {
                clientTBag = int_0;
                if (threadStart_8 == null)
                {
                    threadStart_8 = new ThreadStart(TBagFunc);
                }
                thread_8 = new Thread(threadStart_8);
                try
                {
                    if (bool_26)
                    {
                        bool_102 = true;
                        thread_8.Start();
                    }
                    else
                    {
                        bool_102 = false;
                        thread_8.Abort();
                        PS3.SetMemory(0x1780f28 + 14 + ((uint)(0x5808 * int_0)), new byte[1]);
                    }
                }
                catch
                {
                }
            }

            public static void SkateModStart(int int_0, bool bool_26)
            {
                clientSkate = int_0;
                if (threadStart_5 == null)
                {
                    threadStart_5 = new ThreadStart(SkateFunct);
                }
                thread_5 = new Thread(threadStart_5);
                try
                {
                    if (bool_26)
                    {
                        bool_16 = true;
                        thread_5.Start();
                    }
                    else
                    {
                        bool_16 = false;
                        thread_5.Abort();
                        PS3.SetMemory(0x1780f28 + 14 + ((uint)(0x5808 * int_0)), new byte[1]);
                    }
                }
                catch
                {
                }
            }

            public static void AntiQuitStart(int int_0, bool toggle)
            {
                clientAntiquit = int_0;
                if (threadStart_6 == null)
                {
                    threadStart_6 = new ThreadStart(AntiQuitFunc);
                }
                thread_6 = new Thread(threadStart_6);
                if (toggle)
                {
                    bool_19 = true;
                    thread_6.Start();
                }
                else
                {
                    thread_6.Abort();
                    bool_19 = false;
                }
            }

            public static void HeartQuakeStart(int int_0, bool toggle)
            {
                clientHeartQ = int_0;
                if (threadStart_0 == null)
                {
                    threadStart_0 = new ThreadStart(HeartQuakeFunc);
                }
                thread_0 = new Thread(threadStart_0);
                if (toggle == true)
                {
                    bool_0 = true;
                    thread_0.Start();
                }
                else
                {
                    bool_0 = false;
                    thread_0.Abort();
                }
            }

            public static void ZmHeartQuakeStart(int int_0, bool toggle)
            {
                clientHeartQ = int_0;
                if (threadStart_7 == null)
                {
                    threadStart_7 = new ThreadStart(HeartQuakeFunc);
                }
                thread_7 = new Thread(threadStart_7);
                if (toggle == true)
                {
                    bool_100 = true;
                    thread_7.Start();
                }
                else
                {
                    bool_100 = false;
                    thread_7.Abort();
                }
            }

            public static void TeleportClient2Client(int clientSource, int dateletrasp)
            {
                byte[] bytes = PS3.GetBytes(0x1780F28 + 40 + ((uint)(0x5808 * clientSource)), 12);
                PS3.SetMemory(0x1780F28 + 40 + ((uint)(0x5808 * dateletrasp)), bytes);
            }

            public static void iPrintStart(string textEd, bool toggle)
            {
                txt = textEd;
                if (threadStart_1 == null)
                {
                    threadStart_1 = new ThreadStart(iPrintFunct);
                }
                thread_1 = new Thread(threadStart_1);
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

            public static void iPrintBoldStart(string textEd, bool toggle)
            {
                txt = textEd;
                if (threadStart_2 == null)
                {
                    threadStart_2 = new ThreadStart(iPrintBoldFunct);
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

            public static void ZmiPrintStart(string textEd, bool toggle)
            {
                txt39 = textEd;
                if (threadStart_11 == null)
                {
                    threadStart_11 = new ThreadStart(ZmiPrintFunct);
                }
                thread_11 = new Thread(threadStart_11);
                if (toggle == true)
                {
                    bool_105 = true;
                    thread_11.Start();
                }
                else
                {
                    bool_105 = false;
                    thread_11.Abort();
                }
            }

            public static void ZmiPrintBoldStart(string textEd, bool toggle)
            {
                txt40 = textEd;
                if (threadStart_12 == null)
                {
                    threadStart_12 = new ThreadStart(ZmiPrintBoldFunct);
                }
                thread_12 = new Thread(threadStart_12);
                if (toggle == true)
                {
                    bool_106 = true;
                    thread_12.Start();
                }
                else
                {
                    bool_106 = false;
                    thread_12.Abort();
                }
            }

            public static void ClientiPrintBoldStart(string textEd, bool toggle)
            {
                txt2 = textEd;
                if (threadStart_10 == null)
                {
                    threadStart_10 = new ThreadStart(ClientiPrintBoldFunct);
                }
                thread_10 = new Thread(threadStart_10);
                if (toggle == true)
                {
                    bool_104 = true;
                    thread_10.Start();
                }
                else
                {
                    bool_104 = false;
                    thread_10.Abort();
                }
            }

            public static void ClockNameStart(bool toggle)
            {
                if (threadStart_3 == null)
                {
                    threadStart_3 = new ThreadStart(ClockFunct);
                }
                thread_3 = new Thread(threadStart_3);
                if (toggle == true)
                {
                    bool_97 = true;
                    thread_3.Start();
                }
                else
                {
                    bool_97 = false;
                    thread_3.Abort();
                }
            }

            public static void AmmoStart(int index, bool toggle)
            {
                ammoClient = index;
                if (threadStart_9 == null)
                {
                    threadStart_9 = new ThreadStart(AmmoFunc);
                }
                thread_9 = new Thread(threadStart_9);
                if (toggle == true)
                {
                    bool_103 = true;
                    thread_9.Start();
                }
                else
                {
                    bool_103 = false;
                    thread_9.Abort();
                }
            }

            #region Zm
            public static void ZmRoundLimit(string string_2)
            {
                RPC.Cbuf_AddText("gametype_setting roundlimit " + string_2);
            }

            public static void ZmTranzitWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x178118F + (0x5808 * index)), byte_zmTranzitweap[we]);
                PS3.Extension.WriteByte((uint)(0x17811E3 + (0x5808 * index)), 0x38);
            }

            public static void ZmMOTDWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x1781173 + (0x5808 * index)), byte_MOTDweap[we]);
            }

            public static void ZmDieRiseWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x178118F + (0x5808 * index)), byte_DieRiseweap[we]);
            }

            public static void ZmBuriedWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x178118F + (0x5808 * index)), byte_Buriedweap[we]);
            }

            public static void ZmOriginsWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x178118F + (0x5808 * index)), byte_Originsweap[we]);
                PS3.Extension.WriteByte((uint)(0x17811E3 + (0x5808 * index)), 110);
            }

            public static void ZmSecTranzitWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811C7 + (0x5808 * index)), byte_zmTranzitweap[we]);
                PS3.Extension.WriteByte((uint)(0x17811E3 + (0x5808 * index)), 0x38);
            }

            public static void ZmSecMOTDWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811C7 + (0x5808 * index)), byte_MOTDweap[we]);
            }

            public static void ZmSecDieRiseWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811C7 + (0x5808 * index)), byte_DieRiseweap[we]);
            }

            public static void ZmSecBuriedWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811C7 + (0x5808 * index)), byte_Buriedweap[we]);
            }

            public static void ZmSecOriginsWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811C7 + (0x5808 * index)), byte_Originsweap[we]);
                PS3.Extension.WriteByte((uint)(0x17811E3 + (0x5808 * index)), 110);
            }

            public static void ZmEqTranzitWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811AB + (0x5808 * index)), byte_eqTranzit[we]);
            }

            public static void ZmEqMOTDWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811AB + (0x5808 * index)), byte_eqMOTD[we]);
            }

            public static void ZmEqDieRiseWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811AB + (0x5808 * index)), byte_eqDieRise[we]);
            }

            public static void ZmEqOriginsWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17811AB + (0x5808 * index)), byte_eqOrigins[we]);
            }

            public static void ZmR3TranzitWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17810F7 + (0x5808 * index)), byte_r3Tranzit[we]);
            }

            public static void ZmR3MOTDWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17810F7 + (0x5808 * index)), byte_r3MOTD[we]);
            }

            public static void ZmR3DieRiseWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17810F7 + (0x5808 * index)), byte_r3DieRise[we]);
            }

            public static void ZmR3BuriedWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17810F7 + (0x5808 * index)), byte_r3Buried[we]);
            }

            public static void ZmR3OriginsWeap(int index, int we)
            {
                PS3.Extension.WriteByte((uint)(0x17810F7 + (0x5808 * index)), byte_r3Origins[we]);
            }
            #endregion

            #region shit
            public static string[] strGameMode = new string[] { "g_gametype tdm;wait 500;map_restart", "g_gametype dm;wait 500;map_restart", "g_gametype dom;wait 500;map_restart", "g_gametype dem;wait 500;map_restart", "g_gametype conf;wait 500;map_restart", "g_gametype koth;wait 500;map_restart", "g_gametype hq;wait 500;map_restart", "g_gametype ctf;wait 500;map_restart", "g_gametype sd;wait 500;map_restart", "g_gametype oneflag;wait 500;map_restart", "g_gametype oic;wait 500;map_restart", "g_gametype sas;wait 500;map_restart", "g_gametype gun;wait 500;map_restart" };
            public static string[] zmEquip = new string[] { "Grenade", "Semtex", "EMP", "Monkey" };
            public static string[] zmR3 = new string[] { "Zombie Shield", "Galvaknuckles", "Knife", "Knife 1", "Knife 2" };
            public static string[] zmWeapons()
            {
                return new string[] {
                            "AK74u", "AK74u P.A.P", "MP5", "MP5 P.A.P", "Chicom", "Chicom P.A.P", "M14", "M14 P.A.P", "M16A1", "M16A1 P.A.P", "SMR", "SMR P.A.P", "M8A1", "M8A1 P.A.P", "Type-25", "Type-25 P.A.P",
                            "MTAR", "MTAR P.A.P", "Remington", "Remington P.A.P", "Olympia", "Olympia P.A.P", "S12", "S12 P.A.P", "M1216", "M1216 P.A.P", "Galil", "Galil P.A.P", "Fal", "Fal P.A.P", "RPD", "RPD P.A.P",
                            "Hamr", "Hamr P.A.P", "DSR", "DSR P.A.P", "Barret", "Barret P.A.P", "M1911", "Mustang & Sally", "Python", "Python P.A.P", "Executioner", "Executioner P.A.P", "Kap-40", "Kap-40 P.A.P", "Five-Seven", "Five-Seven P.A.P",
                            "B23R", "B23R P.A.P", "RPG", "RPG P.A.P", "WarMachine", "WarMachine P.A.P", "RayGun", "RayGun P.A.P", "RayGun Mark II", "RayGun Mark II P.A.P", "Ballistic Knife", "Ballistic Knife P.A.P1", "Ballistic Knife P.A.P2", "Ballistic Knife P.A.P3"
                         };
            }
            public static byte[] byte_r3Tranzit = new byte[] { 70, 0x47, 0x65, 0x49, 0x4A };
            public static byte[] byte_r3MOTD = new byte[] { 0x40, 80, 50, 0x41, 0x42 };
            public static byte[] byte_r3Buried = new byte[] { 0x2B, 0x42, 0x35, 0x62, 0x61, 70 };
            public static byte[] byte_r3Origins = new byte[] { 0x2E, 0x7D, 0x55, 0x61, 0x60, 0x67, 0x6A };
            public static byte[] byte_r3DieRise = new byte[] { 0x34, 0x37, 0x66, 0x51, 0x4B };
            public static byte[] byte_eqTranzit = new byte[] { 0x4F, 80, 0x52, 0x51 };
            public static byte[] byte_eqMOTD = new byte[] { 0x3F, 0x44, 0x3A };
            public static byte[] byte_eqOrigins = new byte[] { 0x56, 0x57, 0x58, 0x59 };
            public static byte[] byte_eqDieRise = new byte[] { 0x55, 0x56, 0x57 };
            public static byte[] byte_zmTranzitweap = new byte[] {
                        2, 5, 3, 6, 4, 7, 9, 15, 10, 0x10, 11, 0x12, 12, 20, 13, 0x16,
                        14, 0x18, 0x1A, 30, 0x1B, 0x1F, 0x1C, 0x20, 0x1D, 0x21, 0x22, 0x26, 0x23, 0x27, 0x24, 40,
                        0x25, 0x29, 0x2A, 0x2C, 0x2B, 0x2D, 0x2F, 0x37, 0x30, 0x39, 0x31, 0x3a, 50, 0x3B, 0x33, 60,
                        0x34, 0x3D, 0x40, 0x42, 0x41, 0x43, 0x44, 0x4E, 0x4C, 0x4D, 0x48, 0x49, 0x4A, 0x4B
                     };
            public static byte[] byte_MOTDweap = new byte[] {
                        2, 3, 4, 5, 6, 8, 7, 9, 10, 12, 11, 13, 0x11, 0x12, 0x13, 0x16,
                        20, 0x17, 0x15, 0x18, 0x19, 0x1b, 0x1a, 0x1c, 15, 0x10, 0x1d, 0x1f, 30, 0x20, 0x22, 0x23,
                        0x2a, 0x24, 0x2b, 0x25, 0x2c, 0x2f, 0x30, 0x33, 0x37, 0x31, 0x3e, 60, 0x3d, 0x34, 0x38, 0x35,
                        0x39, 0x56, 0x58
                     };
            public static byte[] byte_DieRiseweap = new byte[] {
                        2, 5, 3, 6, 4, 7, 9, 10, 11, 0x11, 12, 0x12, 13, 20, 14, 0x16,
                        15, 0x18, 0x10, 0x1a, 0x1c, 0x1d, 30, 0x22, 0x1f, 0x23, 0x20, 0x24, 0x21, 0x25, 0x26, 0x2a,
                        0x27, 0x2b, 40, 0x2c, 0x29, 0x2d, 0x2e, 0x30, 0x2f, 0x31, 0x35, 0, 0x36, 0x3f, 0x37, 0x40,
                        0x38, 0x41, 0x39, 0x42, 0x3a, 0x43, 70, 0x48, 0x47, 0x49, 0x4a, 0x54, 0x52, 0x53, 0x4e, 0x4f,
                        0x4c, 0x4d, 80, 0x51
                     };
            public static byte[] byte_Buriedweap = new byte[] {
                        2, 4, 3, 5, 6, 7, 8, 12, 9, 13, 10, 15, 11, 0x11, 0x15, 0x16,
                        0x17, 0x1b, 0x18, 0x1c, 0x19, 0x1d, 0x1a, 30, 0x1f, 0x22, 0x20, 0x23, 0x13, 20, 0x21, 0x24,
                        0x25, 0x27, 0x26, 40, 0x2c, 0x2d, 0x35, 0x2e, 0x36, 0x2f, 0x37, 0x30, 0x38, 0x3d, 0x3f, 0x3e,
                        0x40, 0x41, 0x4b, 0x49, 0x4a, 0x43, 0x44, 0x45, 70, 0x3b, 60, 0x47, 0x48
                     };
            public static byte[] byte_Originsweap = new byte[] {
                        2, 0x20, 3, 5, 7, 8, 0x11, 0x13, 11, 15, 13, 0x10, 0x12, 20, 0x16, 0x18,
                        0x22, 0x25, 0x23, 0x26, 0x1a, 0x1c, 0x1b, 0x1d, 0x24, 0x27, 0x2a, 0x2b, 0x2c, 0x2d, 0x3b, 0x3d,
                        0x2f, 0x35, 0x30, 0x36, 0x31, 0x37, 50, 0x38, 0x3f, 0x40, 0x41, 0x44, 0x42, 0x43, 0x17, 0x19,
                        0x45, 0x49, 70, 0x4c, 0x47, 0x4f, 0x48, 0x52
                     };

            private static Thread thread_5;
            private static Thread thread_6;
            private static ThreadStart threadStart_5;
            private static ThreadStart threadStart_6;
            private static Thread thread_0;
            private static ThreadStart threadStart_0;
            private static Thread thread_1;
            private static ThreadStart threadStart_1;
            private static Thread thread_2;
            private static ThreadStart threadStart_2;
            private static Thread thread_3;
            private static ThreadStart threadStart_3;
            private static Thread thread_7;
            private static ThreadStart threadStart_7;
            private static Thread thread_8;
            private static ThreadStart threadStart_8;
            private static Thread thread_9;
            private static ThreadStart threadStart_9;
            private static Thread thread_10;
            private static ThreadStart threadStart_10;
            private static Thread thread_11;
            private static ThreadStart threadStart_11;
            private static Thread thread_12;
            private static ThreadStart threadStart_12;
            private static bool bool_106 = false;
            private static bool bool_105 = false;
            private static bool bool_104 = false;
            private static bool bool_103 = false;
            private static bool bool_102 = false;
            private static bool bool_100 = false;
            private static bool bool_99 = false;
            private static bool bool_98 = false;
            private static bool bool_97 = false;
            private static bool bool_16 = false;
            private static bool bool_19 = false;
            public static bool bool_0 = false;
            public static string clockNameColor = "";
            public static string txt = "";
            public static string txt2 = "";
            public static string txt39 = "";
            public static string txt40 = "";
            private static int clientSkate = 0;
            private static int ammoClient = 0;
            private static int clientAntiquit = 0;
            private static int clientHeartQ = 0;
            public static int clientTBag = 0;
            public static int clientiPrintBold = 0;
            public static byte[] byte_Status = new byte[] { 0, 1, 2, 3 };
            public static string[] strModels = new string[] { "defaultactor", "german_shepherd", "german_shepherd_vest", "german_shepherd_vest_black", "veh_t6_drone_overwatch_light", "veh_t6_drone_tank", "veh_t6_drone_rcxd", "veh_t6_drone_pegasus_mp" };
            public static string[] strMaps = new string[] {
                "la", "dockside", "carrier", "drone", "express", "hijacked", "meltdown", "overflow", "nightclub", "raid", "slums", "village", "turbine", "socotra", "nuketown_2020", "dig",
                "pod", "takeoff", "frostbite", "mirage", "hydro", "skate", "downhill", "concert", "vertigo", "magma", "Studio", "paintball", "Uplink"
             };

            private static void ClockFunct()
            {
                while (bool_97)
                {
                    PS3.Extension.WriteString(0x026C0658, DateTime.Now.ToString(clockNameColor + "HH:mm:ss"));
                    PS3.Extension.WriteString(0x026C067F, DateTime.Now.ToString(clockNameColor + "HH:mm:ss"));
                }
            }

            public static void TBagFunc()
            {
                while (bool_102)
                {
                    Thread.Sleep(300);
                    PS3.SetMemory(0x1781027 + ((uint)(0x5808 * clientTBag)), new byte[] { 2 });
                    Thread.Sleep(300);
                    PS3.SetMemory(0x1781027 + ((uint)(0x5808 * clientTBag)), new byte[] { 6 });
                    Thread.Sleep(300);
                    PS3.SetMemory(0x1781027 + ((uint)(0x5808 * clientTBag)), new byte[] { 10 });
                }
            }

            public static void AmmoFunc()
            {
                while (bool_103)
                {
                    PS3.SetMemory(0x1781327, new byte[] { 190 });
                    PS3.SetMemory(0x1781363, new byte[] { 190 });
                    PS3.SetMemory(0x178132b, new byte[] { 190 });
                    PS3.SetMemory(0x1781367, new byte[] { 190 });
                    PS3.SetMemory(0x178136b, new byte[] { 190 });
                    PS3.SetMemory(0x178132f, new byte[] { 190 });
                    PS3.SetMemory(0x178136f, new byte[] { 190 });
                    PS3.SetMemory(0x1781373, new byte[] { 190 });
                }
            }

            public static void HeartQuakeFunc()
            {
                while (bool_0)
                {
                    PS3.SetMemory(0x1781087 + ((uint)(0x5808 * clientHeartQ)), new byte[] { 0x81 });
                    Thread.Sleep(15);
                    PS3.SetMemory(0x1781087 + ((uint)(0x5808 * clientHeartQ)), new byte[] { 0x33 });
                }
            }

            public static void ZmHeartQuakeFunc()
            {
                while (bool_100)
                {
                    PS3.SetMemory(0x1781087 + ((uint)(0x5808 * clientHeartQ)), new byte[] { 0x81 });
                    Thread.Sleep(15);
                    PS3.SetMemory(0x1781087 + ((uint)(0x5808 * clientHeartQ)), new byte[] { 0x33 });
                }
            }

            public static string[] strVisions = new string[] { "default", "infrared", "mpintro", "remote_mortar_enhanced", "remote_mortar_infrared", "taser_mine_shock", "tvguided_sp" };

            private static void SkateFunct()
            {
                while (bool_16)
                {
                    PS3.SetMemory(0x1780F28 + 14 + (0x5808 * (uint)clientSkate), new byte[] { 1 });
                }
            }

            private static void AntiQuitFunc()
            {
                while (bool_19)
                {
                    RPC.SV_GameSendServerCommand(clientAntiquit, "@ 1");
                }
            }

            public static uint Fig(int int_0, uint uint_0 = 0)
            {
                return (((uint)(0x16b9f20 + (0x31c * int_0))) + uint_0);
            }

            public static float[] Ziz(int int_0)
            {
                return smethod_10((uint)(0x17865e4 + (0x5808 * int_0)), 3);
            }

            public static float[] Cul(int int_0, string string_0 = "j_head")
            {
                int num = (int)Fig(int_0, 0);
                int num2 = RPC.Call(0x48ed68, new object[] { string_0.ToLower(), 0 });
                RPC.Call(0x278004, new object[] { num, num2, 0x2600270 });
                return smethod_10(0x2600270, 3);
            }

            public static uint Cazz(int int_0, uint uint_4 = 0)
            {
                return ((0x16B9F20 + uint_4) + ((uint)(int_0 * 0x31C)));
            }

            public static float[] smethod_10(uint uint_0, int int_0)
            {
                byte[] bytes = PS3.GetBytes(uint_0, int_0 * 4);
                RevByte(bytes);
                float[] numArray = new float[(int_0 - 1) + 1];
                for (int i = 0; i <= (int_0 - 1); i++)
                {
                    numArray[i] = Convert.ToSingle(BitConverter.ToSingle(bytes, ((int_0 - 1) - i) * 4));
                }
                return numArray;
            }

            public static byte[] RevByte(byte[] byte_0)
            {
                Array.Reverse(byte_0);
                return byte_0;
            }

            public static void iPrintFunct()
            {
                while (bool_98)
                {
                    RPC.iPrintln(0, txt);
                    RPC.iPrintln(1, txt);
                    RPC.iPrintln(2, txt);
                    RPC.iPrintln(3, txt);
                    RPC.iPrintln(4, txt);
                    RPC.iPrintln(5, txt);
                    RPC.iPrintln(6, txt);
                    RPC.iPrintln(7, txt);
                    RPC.iPrintln(8, txt);
                    RPC.iPrintln(9, txt);
                    RPC.iPrintln(10, txt);
                    RPC.iPrintln(11, txt);
                    RPC.iPrintln(12, txt);
                    RPC.iPrintln(13, txt);
                    RPC.iPrintln(14, txt);
                    RPC.iPrintln(15, txt);
                    RPC.iPrintln(16, txt);
                    RPC.iPrintln(17, txt);
                }
            }

            public static void iPrintBoldFunct()
            {
                while (bool_99)
                {
                    RPC.iPrintlnBold(0, txt);
                    RPC.iPrintlnBold(1, txt);
                    RPC.iPrintlnBold(2, txt);
                    RPC.iPrintlnBold(3, txt);
                    RPC.iPrintlnBold(4, txt);
                    RPC.iPrintlnBold(5, txt);
                    RPC.iPrintlnBold(6, txt);
                    RPC.iPrintlnBold(7, txt);
                    RPC.iPrintlnBold(8, txt);
                    RPC.iPrintlnBold(9, txt);
                    RPC.iPrintlnBold(10, txt);
                    RPC.iPrintlnBold(11, txt);
                    RPC.iPrintlnBold(12, txt);
                    RPC.iPrintlnBold(13, txt);
                    RPC.iPrintlnBold(14, txt);
                    RPC.iPrintlnBold(15, txt);
                    RPC.iPrintlnBold(16, txt);
                    RPC.iPrintlnBold(17, txt);
                }
            }

            public static void ZmiPrintFunct()
            {
                while (bool_105)
                {
                    RPC.iPrintln(0, txt);
                    RPC.iPrintln(1, txt);
                    RPC.iPrintln(2, txt);
                    RPC.iPrintln(3, txt);
                }
            }

            public static void ZmiPrintBoldFunct()
            {
                while (bool_106)
                {
                    RPC.iPrintlnBold(0, txt);
                    RPC.iPrintlnBold(1, txt);
                    RPC.iPrintlnBold(2, txt);
                    RPC.iPrintlnBold(3, txt);
                }
            }

            public static void ClientiPrintBoldFunct()
            {
                while (bool_104)
                {
                    RPC.iPrintlnBold(clientiPrintBold, txt2);
                }
            }
            #endregion
        }

        public class Aimbot
        {
            private static Thread thread_0;
            private static ThreadStart threadStart_0;
            private static Thread thread_1;
            private static ThreadStart threadStart_1;
            private static bool bool_0 = false;
            private static bool bool_1 = false;
            private static int client = 0;

            public static void AimbotStart(int clientIndex, bool toggle)
            {
                client = clientIndex;
                if (threadStart_0 == null)
                {
                    threadStart_0 = new ThreadStart(AimbotFunct);
                }
                thread_0 = new Thread(threadStart_0);
                if (toggle == true)
                {
                    bool_0 = true;
                    thread_0.Start();
                }
                else
                {
                    bool_0 = false;
                    thread_0.Abort();
                }
            }

            private static void AimbotFunct()
            {
                while (bool_0)
                {
                    if (BitConverter.ToUInt32(PS3.Extension.ReadBytes((uint)(0x17863a4 + (0x5808 * client)), 4), 0) == 0x80001000)
                    {
                        smethod_8(client, smethod_3(client, true));
                    }
                }
            }

            public static void UnfairAimbotStart(int clientIndex, bool toggle)
            {
                client = clientIndex;
                if (threadStart_1 == null)
                {
                    threadStart_1 = new ThreadStart(UnfairAimbotFunct);
                }
                thread_1 = new Thread(threadStart_1);
                if (toggle == true)
                {
                    bool_1 = true;
                    thread_1.Start();
                }
                else
                {
                    bool_1 = false;
                    thread_1.Abort();
                }
            }

            private static void UnfairAimbotFunct()
            {
                while (bool_1)
                {
                    if (BitConverter.ToUInt32(PS3.Extension.ReadBytes((uint)(0x17863A4 + (0x5808 * client)), 4), 0) == 0x80001000)
                    {
                        smethod_8(client, smethod_3(client, true));
                        if (BitConverter.ToUInt32(PS3.Extension.ReadBytes((uint)(0x17863A4 + (0x5808 * client)), 4), 0) == 0x80001080)
                        {
                            RPC.smethod_11(client, smethod_3(client, true), 0, smethod_69(client));
                        }
                    }
                }
            }

            public static int smethod_69(int int_0)
            {
                return PS3.Extension.ReadByte(0x17810E3 + ((uint)(0x5808 * int_0)));
            }

            public static void smethod_8(int int_0, int int_1)
            {
                float[] numArray = smethod_15(smethod_16(int_0), smethod_16(int_1));
                numArray[2] -= Convert.ToSingle(smethod_14(int_1));
                numArray[2] += Convert.ToSingle(smethod_13(int_0));
                float[] numArray2 = smethod_12(numArray);
                smethod_9((uint)int_0, numArray2);
            }

            private static void smethod_9(uint uint_0, float[] float_0)
            {
                smethod_10(0x10040000, float_0);
                RPC.Call(0x1e1bf0, new object[] { smethod_11(Convert.ToInt32(uint_0), 0), 0x10040000 });
            }

            public static int smethod_3(int int_0, bool bool_0 = false)
            {
                int num = 0;
                float num2 = 1E+08f;
                for (int i = 0; i <= 11; i++)
                {
                    if ((i != int_0) && (smethod_5(i) && smethod_6(i)))
                    {
                        float num4;
                        if ((PS3.Extension.ReadInt32((uint)(0x178642c + (0x5808 * int_0))) != 0) && bool_0)
                        {
                            if (!smethod_4(int_0, i))
                            {
                                num4 = Convert.ToSingle(smethod_7(smethod_16(int_0), smethod_16(i)));
                                if (num4 < num2)
                                {
                                    num2 = num4;
                                    num = i;
                                }
                            }
                        }
                        else
                        {
                            num4 = Convert.ToSingle(smethod_7(smethod_16(int_0), smethod_16(i)));
                            if (num4 < num2)
                            {
                                num2 = num4;
                                num = i;
                            }
                        }
                    }
                }
                return num;
            }

            private static void smethod_10(uint uint_0, float[] float_0)
            {
                int length = float_0.Length;
                byte[] array = new byte[length * 4];
                for (int i = 0; i < length; i++)
                {
                    smethod_19(BitConverter.GetBytes(float_0[i])).CopyTo(array, (int)(i * 4));
                }
                PS3.SetMemory(uint_0, array);
            }

            public static uint smethod_11(int int_0, uint uint_0 = 0)
            {
                return (((uint)(0x16b9f20 + (0x31c * int_0))) + uint_0);
            }

            private static float[] smethod_12(float[] float_0)
            {
                float num = 0f;
                float num2 = 0f;
                float num3 = 0f;
                float[] numArray = new float[3];
                if ((float_0[1] == 0f) && (float_0[0] == 0f))
                {
                    num2 = 0f;
                    if (float_0[2] > 0f)
                    {
                        num3 = 90f;
                    }
                    else
                    {
                        num3 = 270f;
                    }
                }
                else
                {
                    if (!(float_0[0] == -1f))
                    {
                        num2 = Convert.ToSingle((double)((Math.Atan2((double)float_0[1], (double)float_0[0]) * 180.0) / 3.1415926535897931));
                    }
                    else if (float_0[1] > 0f)
                    {
                        num2 = 90f;
                    }
                    else
                    {
                        num2 = 270f;
                    }
                    if (num2 < 0f)
                    {
                        num2 += 360f;
                    }
                    num = Convert.ToSingle(Math.Sqrt((double)((float_0[0] * float_0[0]) + (float_0[1] * float_0[1]))));
                    num3 = Convert.ToSingle((double)((Math.Atan2((double)float_0[2], (double)num) * 180.0) / 3.1415926535897931));
                    if (num3 < 0f)
                    {
                        num3 += 360f;
                    }
                }
                numArray[0] = Convert.ToSingle(-num3);
                numArray[1] = num2;
                numArray[2] = 0f;
                return numArray;
            }

            private static float smethod_13(int int_0)
            {
                switch (PS3.Extension.ReadByte((uint)(0x1781027 + (0x5808 * int_0))))
                {
                    case 8:
                    case 10:
                    case 0x48:
                    case 0x4a:
                        return 46f;

                    case 4:
                    case 6:
                    case 0x44:
                    case 70:
                        return 18f;
                }
                return 0f;
            }

            private static float smethod_14(int int_0)
            {
                switch (PS3.Extension.ReadByte((uint)(0x1781027 + (0x5808 * int_0))))
                {
                    case 8:
                    case 10:
                    case 0x48:
                    case 0x4a:
                        return 44f;

                    case 4:
                    case 6:
                    case 0x44:
                    case 70:
                        return 14f;
                }
                return 0f;
            }

            private static float[] smethod_15(float[] float_0, float[] float_1)
            {
                return new float[] { (float_1[0] - float_0[0]), (float_1[1] - float_0[1]), (float_1[2] - float_0[2]) };
            }

            public static float[] smethod_16(int int_0)
            {
                return smethod_17((uint)(0x1780f50 + (0x5808 * int_0)), 3);
            }

            private static float[] smethod_17(uint uint_0, int int_0)
            {
                byte[] buffer = smethod_18(uint_0, int_0 * 4);
                smethod_19(buffer);
                float[] numArray = new float[(int_0 - 1) + 1];
                for (int i = 0; i <= (int_0 - 1); i++)
                {
                    numArray[i] = BitConverter.ToSingle(buffer, ((int_0 - 1) - i) * 4);
                }
                return numArray;
            }

            public static byte[] smethod_18(uint uint_0, int int_0)
            {
                byte[] buffer = new byte[int_0];
                PS3.GetMemory(uint_0, buffer);
                return buffer;
            }

            private static byte[] smethod_19(byte[] byte_0)
            {
                Array.Reverse(byte_0);
                return byte_0;
            }

            private static bool smethod_4(int int_0, int int_1)
            {
                return (PS3.Extension.ReadInt32((uint)(0x178642c + (0x5808 * int_0))) == PS3.Extension.ReadInt32((uint)(0x178642c + (0x5808 * int_1))));
            }

            private static bool smethod_5(int int_0)
            {
                return (PS3.Extension.ReadInt32((uint)(0x1780f28 + (0x5808 * int_0))) != 0);
            }

            private static bool smethod_6(int int_0)
            {
                return (PS3.Extension.ReadInt32((uint)(0x17864f8 + (0x5808 * int_0))) == 0);
            }

            public static float smethod_7(float[] float_0, float[] float_1)
            {
                float num = float_1[0] - float_0[0];
                float num2 = float_1[1] - float_0[1];
                float num3 = float_1[2] - float_0[2];
                return Convert.ToSingle(Math.Sqrt((double)(((num * num) + (num2 * num2)) + (num3 * num3))));
            }
        }
    }

    public static class Functions
        {
            public static byte[] Multiply(this byte[] A, byte[] B)
            {
                List<byte> ans = new List<byte>();

                byte ov, res;
                int idx = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    ov = 0;
                    for (int j = 0; j < B.Length; j++)
                    {
                        short result = (short)(A[i] * B[j] + ov);
                        ov = (byte)(result >> 8);
                        res = (byte)result;
                        idx = i + j;
                        if (idx < (ans.Count))
                            ans = _add_(ans, res, idx);
                        else ans.Add(res);
                    }
                    if (ov > 0)
                        if (idx + 1 < (ans.Count))
                            ans = _add_(ans, ov, idx + 1);
                        else ans.Add(ov);
                }

                return ans.ToArray();
            }

        public static void SetMemUshort(uint uint_0, ushort ushort_0)
        {
            BO2.PS3.SetMemory(uint_0, BitConverter.GetBytes(ushort_0).Reverse<byte>().ToArray<byte>());
        }

        private static List<byte> _add_(List<byte> A, byte b, int idx = 0, byte rem = 0)
            {
                short sample = 0;
                if (idx < A.Count)
                {
                    sample = (short)((short)A[idx] + (short)b);
                    A[idx] = (byte)(sample % 256);
                    rem = (byte)((sample - A[idx]) % 255);
                    if (rem > 0)
                        return _add_(A, (byte)rem, idx + 1);
                }
                else A.Add(b);

                return A;
            }
        }
    
}
