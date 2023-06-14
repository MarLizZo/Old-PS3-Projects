using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using PS3Lib;

namespace PylezZo_GTAV_Extreme_Tool.Pylo
{
    public static class RPCHook
    {
        public static PS3API PS3;
        private static bool Calling = false;

        static RPCHook()
        {
            RPCHook.PS3 = new PS3API(SelectAPI.ControlConsole);
        }

        public static void CompleteReq()
        {
            while (Calling)
            {
                
            }
        }

        private static byte[] smethod_0(byte[] byte_0)
        {
            Array.Reverse((Array)byte_0);
            return byte_0;
        }

        private static void smethod_1(uint uint_0, float float_0)
        {
            byte[] buffer = new byte[4];
            BitConverter.GetBytes(float_0).CopyTo((Array)buffer, 0);
            Array.Reverse((Array)buffer, 0, 4);
            RPCHook.PS3.SetMemory(uint_0, buffer);
        }

        private static void smethod_2(uint uint_0, float[] float_0)
        {
            int length = float_0.Length;
            byte[] buffer = new byte[length * 4];
            for (int index = 0; index < length; ++index)
                RPCHook.smethod_0(BitConverter.GetBytes(float_0[index])).CopyTo((Array)buffer, index * 4);
            RPCHook.PS3.SetMemory(uint_0, buffer);
        }

        public static int Call(uint func_address, params object[] parameters)
        {
            if (Calling)
            {
                CompleteReq();
            }
            Calling = true;
            int length = parameters.Length;
            int index = 0;
            uint num1 = 0;
            uint num2 = 0;
            uint num3 = 0;
            uint num4 = 0;
            for (; index < length; ++index)
            {
                if (parameters[index] is int)
                {
                    RPCHook.PS3.Extension.WriteInt32((uint)(268566528 + (int)num1 * 4), (int)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is uint)
                {
                    RPCHook.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), (uint)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is string)
                {
                    uint num5 = (uint)(268574720 + (int)num2 * 1024);
                    RPCHook.PS3.Extension.WriteString(num5, Convert.ToString(parameters[index]));
                    RPCHook.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                    ++num1;
                    ++num2;
                }
                else if (parameters[index] is float)
                {
                    RPCHook.smethod_1((uint)(268566564 + (int)num3 * 4), (float)parameters[index]);
                    ++num3;
                }
                else if (parameters[index] is float[])
                {
                    float[] float_0 = (float[])parameters[index];
                    uint num5 = (uint)(268570624 + (int)num4 * 4);
                    RPCHook.smethod_2(num5, float_0);
                    RPCHook.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                    ++num1;
                    num4 += (uint)float_0.Length;
                }
            }
            RPCHook.PS3.Extension.WriteUInt32(268566604U, func_address);
            do
                ;
            while ((int)RPCHook.PS3.Extension.ReadUInt32(268566604U) != 0);
            Thread.Sleep(20);
            Calling = false;
            return RPCHook.PS3.Extension.ReadInt32(268566608U);
        }

        public static T Call2<T>(string Native, params object[] Params) =>
            Call2<T>(Main.GetHash(Native), Params);

        public static T Call2<T>(uint func_address, params object[] parameters)
        {
            if (Calling)
            {
                CompleteReq();
            }
            Calling = true;
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
            for (; index < length; ++index)
            {
                if (parameters[index] is bool)
                    parameters[index] = (object)Convert.ToInt32(parameters[index]);
                if (parameters[index] is int)
                {
                    RPCHook.PS3.Extension.WriteInt32((uint)(268566528 + (int)num1 * 4), (int)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is uint)
                {
                    RPCHook.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), (uint)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is string)
                {
                    uint num5 = (uint)(268574720 + (int)num2 * 1024);
                    RPCHook.PS3.Extension.WriteString(num5, Convert.ToString(parameters[index]));
                    RPCHook.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                    ++num1;
                    ++num2;
                }
                else if (parameters[index] is float)
                {
                    if (flag)
                        RPCHook.PS3.Extension.WriteFloat((uint)(268636160 + (int)num3 * 4), (float)parameters[index]);
                    RPCHook.smethod_1((uint)(268566564 + (int)num3 * 4), (float)parameters[index]);
                    ++num3;
                }
                else if (parameters[index] is float[])
                {
                    float[] float_0 = (float[])parameters[index];
                    uint num5 = (uint)(268570624 + (int)num4 * 4);
                    RPCHook.smethod_2(num5, float_0);
                    RPCHook.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                    ++num1;
                    num4 += (uint)float_0.Length;
                }
            }
            RPCHook.PS3.Extension.WriteUInt32(268566604U, func_address);
            do
                ;
            while ((int)RPCHook.PS3.Extension.ReadUInt32(268566604U) != 0);
            Thread.Sleep(20);
            object obj = (object)0;
            if (typeof(T).ToString() == "System.Int32")
                obj = (object)(T)Convert.ChangeType((object)RPCHook.PS3.Extension.ReadInt32(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.UInt32")
                obj = (object)(T)Convert.ChangeType((object)RPCHook.PS3.Extension.ReadUInt32(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.String")
                obj = (object)(T)Convert.ChangeType((object)RPCHook.PS3.Extension.ReadString(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.Single")
                obj = (object)(T)Convert.ChangeType((object)RPCHook.PS3.Extension.ReadFloat(268566608U), typeof(T));
            if (typeof(T).ToString() == "System.Boolean")
                obj = (object)(T)Convert.ChangeType((object)RPCHook.PS3.Extension.ReadInt32(268566608U), typeof(T));
            if (flag)
            {
                byte[] bytes = RPCHook.PS3.GetBytes(268636160U, 12);
                Array.Reverse((Array)bytes);
                float[] numArray = new float[3];
                numArray[2] = BitConverter.ToSingle(bytes, 0);
                numArray[1] = BitConverter.ToSingle(bytes, 4);
                numArray[0] = BitConverter.ToSingle(bytes, 8);
                obj = (object)(T)Convert.ChangeType((object)numArray, typeof(T));
            }
            Calling = false;
            return (T)obj;
        }

        public class IS_PLAYER_ONLINE
        {
            public static PS3API PS3;
            private static uint uint_0;

            static IS_PLAYER_ONLINE()
            {
                RPCHook.IS_PLAYER_ONLINE.PS3 = new PS3API(SelectAPI.TargetManager);
                RPCHook.IS_PLAYER_ONLINE.uint_0 = 25617296U;
            }

            public IS_PLAYER_ONLINE()
            {
            }

            public static int Call(uint func_address, params object[] parameters)
            {
                if (Calling)
                {
                    CompleteReq();
                }
                Calling = true;
                int length = parameters.Length;
                int index = 0;
                uint num1 = 0;
                uint num2 = 0;
                uint num3 = 0;
                uint num4 = 0;
                for (; index < length; ++index)
                {
                    if (parameters[index] is int)
                    {
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteInt32((uint)(268566528 + (int)num1 * 4), (int)parameters[index]);
                        ++num1;
                    }
                    else if (parameters[index] is uint)
                    {
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), (uint)parameters[index]);
                        ++num1;
                    }
                    else if (parameters[index] is string)
                    {
                        uint num5 = (uint)(268574720 + (int)num2 * 1024);
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteString(num5, Convert.ToString(parameters[index]));
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                        ++num1;
                        ++num2;
                    }
                    else if (parameters[index] is float)
                    {
                        RPCHook.IS_PLAYER_ONLINE.smethod_3((uint)(268566564 + (int)num3 * 4), (float)parameters[index]);
                        ++num3;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] float_0 = (float[])parameters[index];
                        uint num5 = (uint)(268570624 + (int)num4 * 4);
                        RPCHook.IS_PLAYER_ONLINE.smethod_4(num5, float_0);
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                        ++num1;
                        num4 += (uint)float_0.Length;
                    }
                }
                RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32(268566604U, func_address);
                do
                    ;
                while ((int)RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadUInt32(268566604U) != 0);
                Thread.Sleep(20);
                Calling = false;
                return RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadInt32(268566608U);
            }

            public static T Call2<T>(uint func_address, params object[] parameters)
            {
                if (Calling)
                {
                    CompleteReq();
                }
                Calling = true;
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
                for (; index < length; ++index)
                {
                    if (parameters[index] is bool)
                        parameters[index] = (object)Convert.ToInt32(parameters[index]);
                    if (parameters[index] is int)
                    {
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteInt32((uint)(268566528 + (int)num1 * 4), (int)parameters[index]);
                        ++num1;
                    }
                    else if (parameters[index] is uint)
                    {
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), (uint)parameters[index]);
                        ++num1;
                    }
                    else if (parameters[index] is string)
                    {
                        uint num5 = (uint)(268574720 + (int)num2 * 1024);
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteString(num5, Convert.ToString(parameters[index]));
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                        ++num1;
                        ++num2;
                    }
                    else if (parameters[index] is float)
                    {
                        if (flag)
                            RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteFloat((uint)(268636160 + (int)num3 * 4), (float)parameters[index]);
                        RPCHook.IS_PLAYER_ONLINE.smethod_3((uint)(268566564 + (int)num3 * 4), (float)parameters[index]);
                        ++num3;
                    }
                    else if (parameters[index] is float[])
                    {
                        float[] float_0 = (float[])parameters[index];
                        uint num5 = (uint)(268570624 + (int)num4 * 4);
                        RPCHook.IS_PLAYER_ONLINE.smethod_4(num5, float_0);
                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32((uint)(268566528 + (int)num1 * 4), num5);
                        ++num1;
                        num4 += (uint)float_0.Length;
                    }
                }
                RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32(268566604U, func_address);
                do
                    ;
                while ((int)RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadUInt32(268566604U) != 0);
                Thread.Sleep(20);
                object obj = (object)0;
                if (typeof(T).ToString() == "System.Int32")
                    obj = (object)(T)Convert.ChangeType((object)RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadInt32(268566608U), typeof(T));
                if (typeof(T).ToString() == "System.UInt32")
                    obj = (object)(T)Convert.ChangeType((object)RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadUInt32(268566608U), typeof(T));
                if (typeof(T).ToString() == "System.String")
                    obj = (object)(T)Convert.ChangeType((object)RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadString(268566608U), typeof(T));
                if (typeof(T).ToString() == "System.Single")
                    obj = (object)(T)Convert.ChangeType((object)RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadFloat(268566608U), typeof(T));
                if (typeof(T).ToString() == "System.Boolean")
                    obj = (object)(T)Convert.ChangeType((object)RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadInt32(268566608U), typeof(T));
                if (flag)
                {
                    byte[] bytes = RPCHook.IS_PLAYER_ONLINE.PS3.GetBytes(268636160U, 12);
                    Array.Reverse((Array)bytes);
                    float[] numArray = new float[3];
                    numArray[2] = BitConverter.ToSingle(bytes, 0);
                    numArray[1] = BitConverter.ToSingle(bytes, 4);
                    numArray[0] = BitConverter.ToSingle(bytes, 8);
                    obj = (object)(T)Convert.ChangeType((object)numArray, typeof(T));
                }
                Calling = false;
                return (T)obj;
            }

            public static void Enable(uint is_player_online)
            {
                byte[] buffer = new byte[144]
                {
          (byte) 248,
          (byte) 33,
          (byte) 253,
          (byte) 161,
          (byte) 124,
          (byte) 8,
          (byte) 2,
          (byte) 166,
          (byte) 248,
          (byte) 1,
          (byte) 2,
          (byte) 112,
          (byte) 60,
          (byte) 96,
          (byte) 16,
          (byte) 2,
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
          (byte) 2,
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
          (byte) 2,
          (byte) 112,
          (byte) 124,
          (byte) 8,
          (byte) 3,
          (byte) 166,
          (byte) 56,
          (byte) 33,
          (byte) 2,
          (byte) 96,
          (byte) 56,
          (byte) 96,
          (byte) 0,
          (byte) 3,
          (byte) 78,
          (byte) 128,
          (byte) 0,
          (byte) 32
                };
                RPCHook.IS_PLAYER_ONLINE.PS3.SetMemory(25617264U, new byte[16]
                {
          (byte) 61,
          (byte) 96,
          (byte) 16,
          (byte) 5,
          (byte) 129,
          (byte) 107,
          (byte) 0,
          (byte) 0,
          (byte) 125,
          (byte) 105,
          (byte) 3,
          (byte) 166,
          (byte) 78,
          (byte) 128,
          (byte) 4,
          (byte) 32
                });
                RPCHook.IS_PLAYER_ONLINE.PS3.SetMemory(RPCHook.IS_PLAYER_ONLINE.uint_0, buffer);
                RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32(268763136U, 25617296U);
                byte[] numArray = RPCHook.IS_PLAYER_ONLINE.smethod_0(is_player_online);
                RPCHook.IS_PLAYER_ONLINE.PS3.SetMemory(is_player_online, new byte[16]
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
          numArray[0],
          numArray[1],
          numArray[2],
          numArray[3]
                });
                RPCHook.IS_PLAYER_ONLINE.PS3.SetMemory((uint)((int)is_player_online + 24), new byte[12]
                {
          (byte) 124,
          (byte) 8,
          (byte) 3,
          (byte) 166,
          (byte) 56,
          (byte) 33,
          (byte) 0,
          (byte) 112,
          (byte) 78,
          (byte) 128,
          (byte) 0,
          (byte) 32
                });
            }

            private static byte[] smethod_0(uint uint_1)
            {
                uint_1 += 12U;
                uint num = 25617264U - uint_1;
                byte[] numArray1 = new byte[4];
                byte[] numArray2 = new byte[4];
                numArray1[3] = (byte)(num >> 24);
                numArray1[2] = (byte)(num >> 16);
                numArray1[1] = (byte)(num >> 8);
                numArray1[0] = (byte)num;
                numArray2[3] = (byte)((uint)numArray1[0] + 1U);
                numArray2[2] = numArray1[1];
                numArray2[1] = numArray1[2];
                numArray2[0] = (byte)73;
                return numArray2;
            }

            public static bool IsEnable()
            {
                bool flag = false;
                if (((IEnumerable<byte>)RPCHook.IS_PLAYER_ONLINE.PS3.GetBytes(25617264U, 4)).SequenceEqual<byte>((IEnumerable<byte>)new byte[4]
                {
          (byte) 61,
          (byte) 96,
          (byte) 16,
          (byte) 5
                }))
                    flag = true;
                return flag;
            }

            private static float[] smethod_1(uint uint_1, int int_0)
            {
                byte[] byte_0 = RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadBytes(uint_1, int_0 * 4);
                RPCHook.IS_PLAYER_ONLINE.smethod_2(byte_0);
                float[] numArray = new float[int_0];
                for (int index = 0; index < int_0; ++index)
                    numArray[index] = BitConverter.ToSingle(byte_0, (int_0 - 1 - index) * 4);
                return numArray;
            }

            private static byte[] smethod_2(byte[] byte_0)
            {
                Array.Reverse((Array)byte_0);
                return byte_0;
            }

            private static void smethod_3(uint uint_1, float float_0)
            {
                byte[] buffer = new byte[4];
                BitConverter.GetBytes(float_0).CopyTo((Array)buffer, 0);
                Array.Reverse((Array)buffer, 0, 4);
                RPCHook.IS_PLAYER_ONLINE.PS3.SetMemory(uint_1, buffer);
            }

            private static void smethod_4(uint uint_1, float[] float_0)
            {
                int length = float_0.Length;
                byte[] buffer = new byte[length * 4];
                for (int index = 0; index < length; ++index)
                    RPCHook.IS_PLAYER_ONLINE.smethod_2(BitConverter.GetBytes(float_0[index])).CopyTo((Array)buffer, index * 4);
                RPCHook.IS_PLAYER_ONLINE.PS3.SetMemory(uint_1, buffer);
            }
        }

        public class _GET_ACTIVE_NOTIFICATION_HANDLE
        {
            public _GET_ACTIVE_NOTIFICATION_HANDLE()
            {

            }

            public static void Enable(uint anyhook)
            {
                byte[] buffer1 = new byte[168]
                {
          (byte) 49,
          (byte) 51,
          (byte) 51,
          (byte) 55,
          (byte) 32,
          (byte) 104,
          (byte) 97,
          (byte) 120,
          (byte) 48,
          (byte) 114,
          (byte) 32,
          (byte) 119,
          (byte) 97,
          (byte) 115,
          (byte) 32,
          (byte) 104,
          (byte) 101,
          (byte) 114,
          (byte) 101,
          (byte) 101,
          (byte) 101,
          (byte) 101,
          (byte) 101,
          (byte) 101,
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
          (byte) 2,
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
          (byte) 68,
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
          (byte) 2,
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
          (byte) 56,
          (byte) 96,
          (byte) 0,
          (byte) 1,
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
          (byte) 112,
          (byte) 78,
          (byte) 128,
          (byte) 0,
          (byte) 32
                };
                RPCHook.PS3.SetMemory(29345408U, buffer1);
                byte[] buffer2 = new byte[16]
                {
          (byte) 61,
          (byte) 96,
          (byte) 1,
          (byte) 191,
          (byte) 97,
          (byte) 107,
          (byte) 198,
          (byte) 152,
          (byte) 125,
          (byte) 105,
          (byte) 3,
          (byte) 166,
          (byte) 78,
          (byte) 128,
          (byte) 4,
          (byte) 32
                };
                RPCHook.PS3.SetMemory(anyhook, buffer2);
            }
        }
    }
}
