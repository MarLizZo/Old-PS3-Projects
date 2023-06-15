using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using PS3Lib;

namespace LezZo_BO2_Extreme_Tool_xNew
{
    internal class RPC
    {
        public static PS3API PS3 = new PS3API();
        public static uint uint_0 = 0x16b9f20;
        public static uint uint_1 = 0x2774a4;
        public static uint uint_2 = 0x31c;
        private static uint uint_3 = 0x7aa050;

        public static int Call(uint uint_4, params object[] object_0)
        {
            int length = object_0.Length;
            int index = 0;
            uint num3 = 0;
            uint num4 = 0;
            uint num5 = 0;
            uint num6 = 0;
            while (index < length)
            {
                if (object_0[index] is int)
                {
                    PS3.Extension.WriteInt32(0x10020000 + (num3 * 4), (int)object_0[index]);
                    num3++;
                }
                else if (object_0[index] is uint)
                {
                    PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), (uint)object_0[index]);
                    num3++;
                }
                else
                {
                    uint num7;
                    if (object_0[index] is string)
                    {
                        num7 = 0x10022000 + (num4 * 0x400);
                        PS3.Extension.WriteString(num7, Convert.ToString(object_0[index]));
                        PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                        num3++;
                        num4++;
                    }
                    else if (object_0[index] is float)
                    {
                        PS3.Extension.WriteFloat(0x10020024 + (num5 * 4), (float)object_0[index]);
                        num5++;
                    }
                }
                index++;
            }
            PS3.Extension.WriteUInt32(0x1002004c, uint_4);
            System.Threading.Thread.Sleep(20);
            return PS3.Extension.ReadInt32(0x10020050);
        }

        public static int Init()
        {
            uint_3 = 0x7aa050;
            RPC.Enable();
            return 0;
        }

        public static void smethod_11(int int_0, int int_1, int int_2 = 0x12, int int_3 = 0)
        {
            uint num = smethod_12(int_0, 0);
            uint num2 = smethod_12(int_1, 0);
            Call(0x1fd370, new object[] { num2, num, num, 0xff, int_2, int_3, 0xd0300ad4cL });
            System.Threading.Thread.Sleep(100);
        }

        public static uint smethod_12(int int_0, uint uint_4 = 0)
        {
            return ((0x16b9f20 + uint_4) + ((uint)(int_0 * 0x31c)));
        }

        public static void Cbuf_AddText(string Command)
        {
            Call(0x313c18, new object[] { 0, Command });
        }

        public static void smethod_14(int int_0, string string_0)
        {
            SV_GameSendServerCommand(int_0, "2 1060 \"" + string_0 + "\"");
        }

        public static void SpawnClone(int int_0)
        {
            byte[] input = new byte[4];
            input[0] = 0x38;
            input[1] = 0x60;
            PS3.Extension.WriteBytes(0x1f63c4, input);
            PS3.Extension.WriteInt16(0x1f63c6, (short)int_0);
            Call(0x1f6388, new object[] { int_0 });
        }

        public static void smethod_16(int int_0)
        {
            SV_GameSendServerCommand(-1, "^ 5 " + int_0);
        }

        public static void KillcamTime(int int_0)
        {
            Cbuf_AddText("set scr_killcam_time " + int_0);
        }

        public static void smethod_18(int int_0)
        {
            Call(0x1E6698, new object[] { (uint)(0x16B9F20 + (0x31C * int_0)) });
        }

        public static void smethod_19(int int_0, int int_1)
        {
            Call(0x2089A8, new object[] { (uint)(0x16B9F20 + (0x31C * int_0)), smethod_20(int_0), int_1, int_1, int_1, int_1 });
        }

        public static void iPrintln(int int_0, string string_0)
        {
            SV_GameSendServerCommand(int_0, "O \"" + string_0 + "\"");
        }

        public static int smethod_20(int int_0)
        {
            return PS3.Extension.ReadByte((uint)(0x17810E3 + (0x5808 * int_0)));
        }

        public static void smethod_21(int int_0, string string_0)
        {
            SV_GameSendServerCommand(int_0, "B " + Call(0x4F45BC, new object[] { string_0 }));
        }

        public static void iPrintlnBold(int int_0, string string_0)
        {
            SV_GameSendServerCommand(int_0, "< \"" + string_0 + "\"");
        }

        public static void Enable()
        {
            PS3.SetMemory(uint_3, new byte[] { 0x4e, 0x80, 0, 0x20 });
            System.Threading.Thread.Sleep(20);
            byte[] buffer = new byte[] {
                    0x7c, 8, 2, 0xa6, 0xf8, 1, 0, 0x80, 60, 0x60, 0x10, 2, 0x81, 0x83, 0, 0x4c,
                    0x2c, 12, 0, 0, 0x41, 130, 0, 100, 0x80, 0x83, 0, 4, 0x80, 0xa3, 0, 8,
                    0x80, 0xc3, 0, 12, 0x80, 0xe3, 0, 0x10, 0x81, 3, 0, 20, 0x81, 0x23, 0, 0x18,
                    0x81, 0x43, 0, 0x1c, 0x81, 0x63, 0, 0x20, 0xc0, 0x23, 0, 0x24, 0xc0, 0x43, 0, 40,
                    0xc0, 0x63, 0, 0x2c, 0xc0, 0x83, 0, 0x30, 0xc0, 0xa3, 0, 0x34, 0xc0, 0xc3, 0, 0x38,
                    0xc0, 0xe3, 0, 60, 0xc1, 3, 0, 0x40, 0xc1, 0x23, 0, 0x48, 0x80, 0x63, 0, 0,
                    0x7d, 0x89, 3, 0xa6, 0x4e, 0x80, 4, 0x21, 60, 0x80, 0x10, 2, 0x38, 160, 0, 0,
                    0x90, 0xa4, 0, 0x4c, 0x90, 100, 0, 80, 0xe8, 1, 0, 0x80, 0x7c, 8, 3, 0xa6,
                    0x38, 0x21, 0, 0x70, 0x4e, 0x80, 0, 0x20
                 };
            PS3.SetMemory(uint_3 + 4, buffer);
            PS3.SetMemory(0x10020000, new byte[0x2854]);
            PS3.SetMemory(uint_3, new byte[] { 0xf8, 0x21, 0xff, 0x91 });
        }

        public static void SV_GameSendServerCommand(int int_0, string string_0)
        {
            Call(0x349f6c, new object[] { int_0, 0, string_0 });
        }

        public static void smethod_6(int int_0, string string_0)
        {
            Call(uint_1, new object[] { uint_0 + ((uint)(uint_2 * int_0)), string_0 });
        }

        public static void smethod_7(int int_0, string string_0)
        {
            SV_GameSendServerCommand(int_0, "5 \"\n" + string_0 + "\"");
        }

        public static void KickNoob(int int_0)
        {
            Cbuf_AddText("clientKick " + int_0);
        }
    }
}
