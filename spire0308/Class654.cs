using System;
using System.IO;

internal class Class654
{
    private Class654()
    {
    }

    internal static string smethod_0(BinaryReader A_0)
    {
        int num = A_0.ReadUInt16();
        int num2 = num & 0x7fff;
        bool flag = (num & 0x8000) == 0;
        if (num2 > 0)
        {
            int count = flag ? (num2 * 2) : num2;
            byte[] bytes = A_0.ReadBytes(count);
            return Class813.smethod_0(flag).GetString(bytes);
        }
        return "";
    }

    internal static void smethod_1(BinaryWriter A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            A_0.Write((ushort) A_1.Length);
            byte[] bytes = Class813.smethod_0(true).GetBytes(A_1);
            A_0.Write(bytes);
        }
        else
        {
            A_0.Write((ushort) 0);
        }
    }

    internal static int smethod_2(string A_0)
    {
        if (Class567.smethod_16(A_0))
        {
            return (2 + (A_0.Length * 2));
        }
        return 2;
    }
}

