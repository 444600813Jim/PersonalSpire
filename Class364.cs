using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal abstract class Class364
{
    internal abstract void vmethod_0(byte[] A_0, int A_1);
    internal abstract int vmethod_1(byte[] A_0, int A_1);
    internal abstract int vmethod_2();
    internal static short smethod_0(byte[] A_0, ref int A_1)
    {
        short num = BitConverter.ToInt16(A_0, A_1);
        A_1 += 2;
        return num;
    }

    internal static int smethod_1(byte[] A_0, ref int A_1)
    {
        int num = BitConverter.ToInt32(A_0, A_1);
        A_1 += 4;
        return num;
    }

    internal static long smethod_2(byte[] A_0, ref int A_1)
    {
        long num = BitConverter.ToInt64(A_0, A_1);
        A_1 += 8;
        return num;
    }

    internal static ushort smethod_3(byte[] A_0, ref int A_1)
    {
        ushort num = BitConverter.ToUInt16(A_0, A_1);
        A_1 += 2;
        return num;
    }

    internal static uint smethod_4(byte[] A_0, ref int A_1)
    {
        uint num = BitConverter.ToUInt32(A_0, A_1);
        A_1 += 4;
        return num;
    }

    internal static byte[] smethod_5(byte[] A_0, int A_1, ref int A_2)
    {
        byte[] buffer = new byte[A_1];
        for (int i = 0; i < A_1; i++)
        {
            buffer[i] = A_0[A_2 + i];
        }
        A_2 += A_1;
        return buffer;
    }

    internal static void smethod_6(byte[] A_0, ref int A_1, short A_2)
    {
        byte[] bytes = BitConverter.GetBytes(A_2);
        smethod_11(A_0, ref A_1, bytes);
    }

    internal static void smethod_7(byte[] A_0, ref int A_1, ushort A_2)
    {
        byte[] bytes = BitConverter.GetBytes(A_2);
        smethod_11(A_0, ref A_1, bytes);
    }

    internal static void smethod_8(byte[] A_0, ref int A_1, int A_2)
    {
        byte[] bytes = BitConverter.GetBytes(A_2);
        smethod_11(A_0, ref A_1, bytes);
    }

    internal static void smethod_9(byte[] A_0, ref int A_1, long A_2)
    {
        byte[] bytes = BitConverter.GetBytes(A_2);
        smethod_11(A_0, ref A_1, bytes);
    }

    internal static void smethod_10(byte[] A_0, ref int A_1, uint A_2)
    {
        byte[] bytes = BitConverter.GetBytes(A_2);
        smethod_11(A_0, ref A_1, bytes);
    }

    internal static void smethod_11(byte[] A_0, ref int A_1, byte[] A_2)
    {
        int length = A_2.Length;
        for (int i = 0; i < length; i++)
        {
            A_0[A_1 + i] = A_2[i];
        }
        A_1 += length;
    }

    internal static void smethod_12(byte[] A_0, byte[] A_1, int A_2)
    {
        for (int i = 0; i < A_2; i++)
        {
            A_0[i] = A_1[i];
        }
    }

    protected Class364()
    {
    }
}

