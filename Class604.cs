using System;
using System.IO;
using System.Text;

internal class Class604
{
    public static int smethod_0(int A_0, int A_1)
    {
        return (A_0 >> A_1);
    }

    public static long smethod_1(long A_0, int A_1)
    {
        return (A_0 >> A_1);
    }

    public static int smethod_2(TextReader A_0, byte[] A_1, int A_2, int A_3)
    {
        if (A_1.Length == 0)
        {
            return 0;
        }
        char[] buffer = new char[A_1.Length];
        int num2 = A_0.Read(buffer, A_2, A_3);
        if (num2 == 0)
        {
            return -1;
        }
        for (int i = A_2; i < (A_2 + num2); i++)
        {
            A_1[i] = (byte) buffer[i];
        }
        return num2;
    }

    internal static byte[] smethod_3(string A_0)
    {
        return Encoding.UTF8.GetBytes(A_0);
    }

    internal static char[] smethod_4(byte[] A_0)
    {
        return Encoding.UTF8.GetChars(A_0);
    }
}

