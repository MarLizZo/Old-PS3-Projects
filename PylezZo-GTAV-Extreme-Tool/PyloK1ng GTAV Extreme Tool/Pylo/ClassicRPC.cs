using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using PS3Lib;

namespace PylezZo_GTAV_Extreme_Tool.Pylo
{
    public static class ClassicRPC
    {
        public static uint SFA1 = 0x1BE4C80;
        public static uint EFA1 = 0x1BE4D08;
        public static uint BFA1 = 0x18614;
        public static uint BAB1 = 0x18620;
        public static PS3API PS3 = new PS3API();
        private static bool Calling = false;

        public static void CompleteReq()
        {
            while (Calling)
            {
                
            }
        }

        public static uint CBAB(uint F, uint T)
        {
            if (F > T)
                return 0x4C000000 - (F - T);
            else if (F < T)
                return T - F + 0x48000000;
            else
                return 0x48000000;
        }

        public static void Enable()
        {
            byte[] mem = new byte[] {
            0xF8, 0x21, 0xFF, 0x91,
            0x7C, 0x08, 0x02, 0xA6,
            0xF8, 0x01, 0x00, 0x80,
            0x3C, 0x60, 0x10, 0x04,
            0x81, 0x83, 0x00, 0x4C,
            0x2C, 0x0C, 0x00, 0x00,
            0x41, 0x82, 0x00, 0x64,
            0x80, 0x83, 0x00, 0x04,
            0x80, 0xA3, 0x00, 0x08,
            0x80, 0xC3, 0x00, 0x0C,
            0x80, 0xE3, 0x00, 0x10,
            0x81, 0x03, 0x00, 0x14,
            0x81, 0x23, 0x00, 0x18,
            0x81, 0x43, 0x00, 0x1C,
            0x81, 0x63, 0x00, 0x20,
            0xC0, 0x23, 0x00, 0x24,
            0xc0, 0x43, 0x00, 0x28,
            0xC0, 0x63, 0x00, 0x2C,
            0xC0, 0x83, 0x00, 0x30,
            0xC0, 0xA3, 0x00, 0x34,
            0xc0, 0xC3, 0x00, 0x38,
            0xC0, 0xE3, 0x00, 0x3C,
            0xC1, 0x03, 0x00, 0x40,
            0xC1, 0x23, 0x00, 0x48,
            0x80, 0x63, 0x00, 0x00,
            0x7D, 0x89, 0x03, 0xA6,
            0x4E, 0x80, 0x04, 0x21,
            0x3C, 0x80, 0x10, 0x04,
            0x38, 0xA0, 0x00, 0x00,
            0x90, 0xA4, 0x00, 0x4C,
            0x90, 0x64, 0x00, 0x50,
            0xE8, 0x01, 0x00, 0x80,
            0x7C, 0x08, 0x03, 0xA6,
            0x38, 0x21, 0x00, 0x70 };

            PS3.SetMemory(SFA1, mem);
            PS3.Extension.WriteUInt32(EFA1, CBAB(EFA1, BAB1));
            PS3.Extension.WriteUInt32(BFA1, CBAB(BFA1, SFA1));
        }

        public static int Call(uint func_address, params object[] parameters)
        {
            if (Calling)
            {
                CompleteReq();
            }
            Calling = true;
            uint address = func_address;
            int length = parameters.Length;
            int index = 0;
            uint num3 = 0;
            uint num4 = 0;
            uint num5 = 0;
            uint num6 = 0;
            while (index < length)
            {
                if (parameters[index] is int)
                {
                    PS3.Extension.WriteInt32(0x10040000 + (num3 * 4), (int)parameters[index]);
                    num3++;
                }
                else if (parameters[index] is uint)
                {
                    PS3.Extension.WriteUInt32(0x10040000 + (num3 * 4), (uint)parameters[index]);
                    num3++;
                }
                else
                {
                    uint num7;
                    if (parameters[index] is string)
                    {
                        num7 = 0x10042000 + (num4 * 0x400);
                        PS3.Extension.WriteString(num7, Convert.ToString(parameters[index]));
                        PS3.Extension.WriteUInt32(0x10040000 + (num3 * 4), num7);
                        num3++;
                        num4++;
                    }
                    else if (parameters[index] is float)
                    {
                        WriteSingle(0x10040024 + (num5 * 4), (float)parameters[index]);
                        num5++;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] input = (float[])parameters[index];
                        num7 = 0x10041000 + (num6 * 4);
                        WriteSingle(num7, input);
                        PS3.Extension.WriteUInt32(0x10040000 + (num3 * 4), num7);
                        num3++;
                        num6 += (uint)input.Length;
                    }
                }
                index++;
            }
            PS3.Extension.WriteUInt32(0x1004004C, address);
            Calling = false;
            while (PS3.Extension.ReadUInt32(0x1004004C) != 0) ;

            return PS3.Extension.ReadInt32(0x10040050);
        }

        public static int CallwHash<T>(T address, params object[] parameters)
        {
            object func_address = 0;
            if (typeof(T) == typeof(string))
                func_address = FindAddress((string)(object)address);
            else
                func_address = Convert.ChangeType(address, TypeCode.UInt32);
            int length = parameters.Length;
            int index = 0;
            uint num3 = 0;
            uint num4 = 0;
            uint num5 = 0;
            uint num6 = 0;
            while (index < length)
            {
                if (parameters[index] is int)
                {
                    PS3.Extension.WriteInt32(0x10020000 + (num3 * 4), (int)parameters[index]);
                    num3++;
                }
                else if (parameters[index] is bool)
                {
                    PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), Convert.ToUInt32(parameters[index]));
                    num3++;
                }
                else if (parameters[index] is uint)
                {
                    PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), (uint)parameters[index]);
                    num3++;
                }
                else
                {
                    uint num7;
                    if (parameters[index] is string)
                    {
                        num7 = 0x10022000 + (num4 * 0x400);
                        PS3.Extension.WriteString(num7, Convert.ToString(parameters[index]));
                        PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                        num3++;
                        num4++;
                    }
                    else if (parameters[index] is float)
                    {
                        WriteSingle(0x10020024 + (num5 * 4), (float)parameters[index]);
                        num5++;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] input = (float[])parameters[index];
                        num7 = 0x10021000 + (num6 * 4);
                        WriteSingle(num7, input);
                        PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                        num3++;
                        num6 += (uint)input.Length;
                    }
                }
                index++;
            }
            PS3.Extension.WriteUInt32(0x1002004C, (uint)func_address);
            int timeOut = 0;
            while (PS3.Extension.ReadUInt32(0x1002004C) != 00)
            {
                Thread.Sleep(10);
                timeOut++;
                if (timeOut == 60)
                    break;
                Application.DoEvents();
            }
            return PS3.Extension.ReadInt32(0x10020050);
        }

        static uint FindAddress(string NativeString)
        {
            object NativeHash = 0;
            if (NativeString.ToString().Any(c => char.IsDigit(c)))
            {
                NativeHash = Convert.ToUInt32(NativeString.ToString(), 0x10);
            }
            else
            {
                NativeHash = Functions.RPCFunc.STRINGHASH((string)(object)NativeString);
            }
            short[] bl_Dictionary = { 0x4AE5, 0x4AE4, 0x4AEB, 0x4AE9, 0x4AE6, 0x4AA8, 0x4AEA, 0x4AE8, 0x4AE3, 0x4AE1, 0x4AE2, 0x4AE7, 0x4AB9, 0x4AB8, 0x4AB7, 0x4AB6, 0x4AB5, 0x4AB4, 0x4AB3, 0x4AB2, 0x4AB1 };
            uint hash = (uint)NativeHash & 0xff;
            uint Struct = PS3.Extension.ReadUInt32(0x1E6FF38 + (hash * 4));
            while (Struct != 0)
            {
                int NativeCount = PS3.Extension.ReadInt32(Struct + 0x20);
                for (uint i = 0; i < NativeCount; i++)
                {
                    if (PS3.Extension.ReadUInt32((Struct + 0x24) + (i * 4)) == (uint)NativeHash)
                    {
                        uint Native = PS3.Extension.ReadUInt32(PS3.Extension.ReadUInt32((Struct + 4) + (i * 4)));
                        for (uint e = 0; e < 100; ++e)
                        {
                            short NativeLocation = PS3.Extension.ReadInt16(Native + (e * 0x4));
                            for (int u = 0; u < bl_Dictionary.Length; ++u)
                            {
                                if (bl_Dictionary[u] == NativeLocation)
                                {
                                    byte[] call = PS3.GetBytes(Native + (e * 0x4), 4);
                                    Array.Reverse(call);
                                    return ((uint)(BitConverter.ToUInt32(call, 0) - 0x48000001)) + Native + (e * 0x4) - 0x4000000;
                                }
                            }
                        }
                    }
                }
                Struct = PS3.Extension.ReadUInt32(Struct);
            }
            return 0xFF;
        }

        public static int HookCall(uint uint_2, params object[] object_0)
        {
            if (Calling)
            {
                CompleteReq();
            }
            Calling = true;
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
                        smethod_5(0x10020024 + (num5 * 4), (float)object_0[index]);
                        num5++;
                    }
                    else if (object_0[index] is float[])
                    {
                        float[] numArray = (float[])object_0[index];
                        num7 = 0x10021000 + (num6 * 4);
                        smethod_6(num7, numArray);
                        PS3.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                        num3++;
                        num6 += (uint)numArray.Length;
                    }
                }
                index++;
            }
            PS3.Extension.WriteUInt32(0x1002004c, uint_2);
            while (PS3.Extension.ReadUInt32(0x1002004c) != 0)
            {
            }
            System.Threading.Thread.Sleep(8);
            Calling = false;
            return PS3.Extension.ReadInt32(0x10020050);
        }

        public static int NCall(NewNatives func_address, params object[] parameters)
        {
            if (Calling)
            {
                CompleteReq();
            }
            Calling = true;
            uint address = (uint)func_address;
            int length = parameters.Length;
            int index = 0;
            uint num3 = 0;
            uint num4 = 0;
            uint num5 = 0;
            uint num6 = 0;
            while (index < length)
            {
                if (parameters[index] is int)
                {
                    PS3.Extension.WriteInt32(0x10040000 + (num3 * 4), (int)parameters[index]);
                    num3++;
                }
                else if (parameters[index] is uint)
                {
                    PS3.Extension.WriteUInt32(0x10040000 + (num3 * 4), (uint)parameters[index]);
                    num3++;
                }
                else
                {
                    uint num7;
                    if (parameters[index] is string)
                    {
                        num7 = 0x10042000 + (num4 * 0x400);
                        PS3.Extension.WriteString(num7, Convert.ToString(parameters[index]));
                        PS3.Extension.WriteUInt32(0x10040000 + (num3 * 4), num7);
                        num3++;
                        num4++;
                    }
                    else if (parameters[index] is float)
                    {
                        WriteSingle(0x10040024 + (num5 * 4), (float)parameters[index]);
                        num5++;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] input = (float[])parameters[index];
                        num7 = 0x10041000 + (num6 * 4);
                        WriteSingle(num7, input);
                        PS3.Extension.WriteUInt32(0x10040000 + (num3 * 4), num7);
                        num3++;
                        num6 += (uint)input.Length;
                    }
                }
                index++;
            }
            PS3.Extension.WriteUInt32(0x1004004C, address);
            Calling = false;
            while (PS3.Extension.ReadUInt32(0x1004004C) != 0) ;

            return PS3.Extension.ReadInt32(0x10040050);
        }

        private static byte[] smethod_4(byte[] byte_0)
        {
            Array.Reverse(byte_0);
            return byte_0;
        }

        private static void smethod_5(uint uint_2, float float_0)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(float_0).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            PS3.SetMemory(uint_2, array);
        }

        private static void smethod_6(uint uint_2, float[] float_0)
        {
            int length = float_0.Length;
            byte[] array = new byte[length * 4];
            for (int i = 0; i < length; i++)
            {
                smethod_4(BitConverter.GetBytes(float_0[i])).CopyTo(array, (int)(i * 4));
            }
            PS3.SetMemory(uint_2, array);
        }

        private static void WriteSingle(uint address, float input)
        {
            byte[] Bytes = new byte[4];
            BitConverter.GetBytes(input).CopyTo((Array)Bytes, 0);
            Array.Reverse((Array)Bytes, 0, 4);
            PS3.SetMemory(address, Bytes);
        }

        private static void WriteSingle(uint address, float[] input)
        {
            int length = input.Length;
            byte[] Bytes = new byte[length * 4];
            for (int index = 0; index < length; ++index)
                ReverseBytes(BitConverter.GetBytes(input[index])).CopyTo((Array)Bytes, index * 4);
            PS3.SetMemory(address, Bytes);
        }

        private static byte[] ReverseBytes(byte[] toReverse)
        {
            Array.Reverse((Array)toReverse);
            return toReverse;
        }
    }
}
