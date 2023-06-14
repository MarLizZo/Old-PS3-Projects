using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PS3Lib;

namespace PylezZo_GTAV_Extreme_Tool.Pylo
{
    public static class RPC3
    {
        public static PS3API PS3;
        private static uint uint_0;
        private static uint uint_1;
        private static uint uint_2;
        private static uint uint_3;
        private static bool calling = false;

        static RPC3()
        {
            RPC3.PS3 = new PS3API(SelectAPI.ControlConsole);
            RPC3.uint_0 = 29315072U;
            RPC3.uint_1 = 29315208U;
            RPC3.uint_2 = 99860U;
            RPC3.uint_3 = 99872U;
        }

        public static void CompleteReq()
        {
            while (calling)
            {

            }
        }

        public static uint CBAB(uint F, uint T)
        {
            return F <= T ? (F >= T ? 1207959552U : (uint)((int)T - (int)F + 1207959552)) : (uint)(1275068416 - ((int)F - (int)T));
        }

        public static void Enable()
        {
            byte[] buffer = new byte[136]
            {
        (byte) 248,
        (byte) 33,
        byte.MaxValue,
        (byte) 145,
        (byte) 124,
        (byte) 8,
        (byte) 2,
        (byte) 166,
        (byte) 248,
        (byte) 1,
        (byte) 0,
        (byte) 128,
        (byte) 60,
        (byte) 96,
        (byte) 16,
        (byte) 4,
        (byte) 129,
        (byte) 131,
        (byte) 0,
        (byte) 76,
        (byte) 44,
        (byte) 12,
        (byte) 0,
        (byte) 0,
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 100,
        (byte) 128,
        (byte) 131,
        (byte) 0,
        (byte) 4,
        (byte) 128,
        (byte) 163,
        (byte) 0,
        (byte) 8,
        (byte) 128,
        (byte) 195,
        (byte) 0,
        (byte) 12,
        (byte) 128,
        (byte) 227,
        (byte) 0,
        (byte) 16,
        (byte) 129,
        (byte) 3,
        (byte) 0,
        (byte) 20,
        (byte) 129,
        (byte) 35,
        (byte) 0,
        (byte) 24,
        (byte) 129,
        (byte) 67,
        (byte) 0,
        (byte) 28,
        (byte) 129,
        (byte) 99,
        (byte) 0,
        (byte) 32,
        (byte) 192,
        (byte) 35,
        (byte) 0,
        (byte) 36,
        (byte) 192,
        (byte) 67,
        (byte) 0,
        (byte) 40,
        (byte) 192,
        (byte) 99,
        (byte) 0,
        (byte) 44,
        (byte) 192,
        (byte) 131,
        (byte) 0,
        (byte) 48,
        (byte) 192,
        (byte) 163,
        (byte) 0,
        (byte) 52,
        (byte) 192,
        (byte) 195,
        (byte) 0,
        (byte) 56,
        (byte) 192,
        (byte) 227,
        (byte) 0,
        (byte) 60,
        (byte) 193,
        (byte) 3,
        (byte) 0,
        (byte) 64,
        (byte) 193,
        (byte) 35,
        (byte) 0,
        (byte) 72,
        (byte) 128,
        (byte) 99,
        (byte) 0,
        (byte) 0,
        (byte) 125,
        (byte) 137,
        (byte) 3,
        (byte) 166,
        (byte) 78,
        (byte) 128,
        (byte) 4,
        (byte) 33,
        (byte) 60,
        (byte) 128,
        (byte) 16,
        (byte) 4,
        (byte) 56,
        (byte) 160,
        (byte) 0,
        (byte) 0,
        (byte) 144,
        (byte) 164,
        (byte) 0,
        (byte) 76,
        (byte) 144,
        (byte) 100,
        (byte) 0,
        (byte) 80,
        (byte) 232,
        (byte) 1,
        (byte) 0,
        (byte) 128,
        (byte) 124,
        (byte) 8,
        (byte) 3,
        (byte) 166,
        (byte) 56,
        (byte) 33,
        (byte) 0,
        (byte) 112
            };
            RPC3.PS3.SetMemory(RPC3.uint_0, buffer);
            RPC3.PS3.Extension.WriteUInt32(RPC3.uint_1, RPC3.CBAB(RPC3.uint_1, RPC3.uint_3));
            RPC3.PS3.Extension.WriteUInt32(RPC3.uint_2, RPC3.CBAB(RPC3.uint_2, RPC3.uint_0));
        }

        public static int Call(uint func_address, params object[] parameters)
        {
            if (calling)
            {
                CompleteReq();
            }
            int length = parameters.Length;
            int index = 0;
            uint num1 = 0;
            uint num2 = 0;
            uint num3 = 0;
            uint num4 = 0;
            calling = true;
            for (; index < length; ++index)
            {
                if (parameters[index] is int)
                {
                    RPC3.PS3.Extension.WriteInt32((uint)(268697600 + (int)num1 * 4), (int)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is uint)
                {
                    RPC3.PS3.Extension.WriteUInt32((uint)(268697600 + (int)num1 * 4), (uint)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is string)
                {
                    uint num5 = (uint)(268705792 + (int)num2 * 1024);
                    RPC3.PS3.Extension.WriteString(num5, Convert.ToString(parameters[index]));
                    RPC3.PS3.Extension.WriteUInt32((uint)(268697600 + (int)num1 * 4), num5);
                    ++num1;
                    ++num2;
                }
                else if (parameters[index] is float)
                {
                    RPC3.smethod_0((uint)(268697636 + (int)num3 * 4), (float)parameters[index]);
                    ++num3;
                }
                else if (parameters[index] is float[])
                {
                    float[] float_0 = (float[])parameters[index];
                    uint num5 = (uint)(268701696 + (int)num4 * 4);
                    RPC3.smethod_1(num5, float_0);
                    RPC3.PS3.Extension.WriteUInt32((uint)(268697600 + (int)num1 * 4), num5);
                    ++num1;
                    num4 += (uint)float_0.Length;
                }
            }
            RPC3.PS3.Extension.WriteUInt32(268697676U, func_address);
            do
                ;
            while (RPC3.PS3.Extension.ReadUInt32(268697676U) > 0U);
            calling = false;
            return RPC3.PS3.Extension.ReadInt32(268697680U);
        }

        public static T Call2<T>(uint func_address, params object[] parameters)
        {
            if (calling)
            {
                CompleteReq();
            }
            bool flag = false;
            if (typeof(T).ToString() == "System.Single[]")
            {
                flag = true;
                List<object> objectList = new List<object>()
        {
          (object) 268636160
        };
                objectList.AddRange((IEnumerable<object>)parameters);
                objectList.Add((object)268636160);
                parameters = objectList.ToArray();
            }
            int length = parameters.Length;
            int index = 0;
            uint num1 = 0;
            uint num2 = 0;
            uint num3 = 0;
            uint num4 = 0;
            calling = true;
            for (; index < length; ++index)
            {
                if (parameters[index] is bool)
                    parameters[index] = (object)Convert.ToInt32(parameters[index]);
                if (parameters[index] is int)
                {
                    RPC3.PS3.Extension.WriteInt32((uint)(268566528 + (int)num1 * 4), (int)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is uint)
                {
                    RPC3.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), (uint)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is string)
                {
                    uint num5 = (uint)(268574720 + (int)num2 * 1024);
                    RPC3.PS3.Extension.WriteString(num5, Convert.ToString(parameters[index]));
                    RPC3.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                    ++num1;
                    ++num2;
                }
                else if (parameters[index] is float)
                {
                    if (flag)
                        RPC3.PS3.Extension.WriteFloat((uint)(268636160 + (int)num3 * 4), (float)parameters[index]);
                    RPC3.smethod_0((uint)(268566564 + (int)num3 * 4), (float)parameters[index]);
                    ++num3;
                }
                else if (parameters[index] is float[])
                {
                    float[] float_0 = (float[])parameters[index];
                    uint num5 = (uint)(268570624 + (int)num4 * 4);
                    RPC3.smethod_1(num5, float_0);
                    RPC3.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                    ++num1;
                    num4 += (uint)float_0.Length;
                }
            }
            RPC3.PS3.Extension.WriteUInt32(268566604U, func_address);
            do
                ;
            while ((int)RPC3.PS3.Extension.ReadUInt32(268566604U) != 0);
            Thread.Sleep(20);
            object obj = (object)0;
            if (typeof(T).ToString() == "System.Int32")
                obj = (object)(T)Convert.ChangeType((object)RPC3.PS3.Extension.ReadInt32(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.UInt32")
                obj = (object)(T)Convert.ChangeType((object)RPC3.PS3.Extension.ReadUInt32(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.String")
                obj = (object)(T)Convert.ChangeType((object)RPC3.PS3.Extension.ReadString(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.Single")
                obj = (object)(T)Convert.ChangeType((object)RPC3.PS3.Extension.ReadFloat(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.Boolean")
                obj = (object)(T)Convert.ChangeType((object)RPC3.PS3.Extension.ReadInt32(268566608U), typeof(T));
            if (flag)
            {
                byte[] bytes = RPC3.PS3.GetBytes(268636160U, 12);
                Array.Reverse((Array)bytes);
                float[] numArray = new float[3];
                numArray[2] = BitConverter.ToSingle(bytes, 0);
                numArray[1] = BitConverter.ToSingle(bytes, 4);
                numArray[0] = BitConverter.ToSingle(bytes, 8);
                obj = (object)(T)Convert.ChangeType((object)numArray, typeof(T));
            }
            calling = false;
            return (T)obj;
        }

        private static void smethod_0(uint uint_4, float float_0)
        {
            byte[] buffer = new byte[4];
            BitConverter.GetBytes(float_0).CopyTo((Array)buffer, 0);
            Array.Reverse((Array)buffer, 0, 4);
            RPC3.PS3.SetMemory(uint_4, buffer);
        }

        private static void smethod_1(uint uint_4, float[] float_0)
        {
            int length = float_0.Length;
            byte[] buffer = new byte[length * 4];
            for (int index = 0; index < length; ++index)
                RPC3.smethod_2(BitConverter.GetBytes(float_0[index])).CopyTo((Array)buffer, index * 4);
            RPC3.PS3.SetMemory(uint_4, buffer);
        }

        private static byte[] smethod_2(byte[] byte_0)
        {
            Array.Reverse((Array)byte_0);
            return byte_0;
        }
    }
}
