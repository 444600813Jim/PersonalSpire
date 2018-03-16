using Spire.Doc;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class1115
{
    public const int int_0 = 4;
    private const int int_1 = 2;
    private const int int_2 = 8;

    public static short smethod_0(Stream A_0, byte[] A_1)
    {
        int num = 7;
        if (A_0.Read(A_1, 0, 2) != 2)
        {
            throw new Exception(BookmarkStart.b("搬䄮䜰刲头帶崸ᬺ礼帾㕀≂", num));
        }
        return BitConverter.ToInt16(A_1, 0);
    }

    public static int smethod_1(Stream A_0, byte[] A_1)
    {
        int num = 7;
        if (A_0.Read(A_1, 0, 4) != 4)
        {
            throw new Exception(BookmarkStart.b("搬䄮䜰刲头帶崸ᬺ夼帾㕀≂", num));
        }
        return BitConverter.ToInt32(A_1, 0);
    }

    public static int smethod_10(Stream A_0, string A_1, Encoding A_2, bool A_3 = false)
    {
        int num = 14;
        if (string.IsNullOrEmpty(A_1))
        {
            A_1 = BookmarkStart.b("㐳", num);
        }
        else if (A_1[A_1.Length - 1] != '\0')
        {
            A_1 = A_1 + BookmarkStart.b("㐳", num);
        }
        byte[] bytes = A_2.GetBytes(A_1);
        int length = bytes.Length;
        byte[] buffer3 = BitConverter.GetBytes(A_1.Length);
        A_0.Write(buffer3, 0, buffer3.Length);
        A_0.Write(bytes, 0, length);
        if (A_3)
        {
            int num2 = 4 - (length % 4);
            if (num2 < 4)
            {
                byte[] buffer = new byte[num2];
                A_0.Write(buffer, 0, buffer.Length);
            }
        }
        return (4 + length);
    }

    public static void smethod_11(Stream A_0, ref int A_1)
    {
        int num = A_1 % 4;
        if (num != 0)
        {
            int num2 = 0;
            int num3 = 4 - num;
            while (num2 < num3)
            {
                A_0.WriteByte(0);
                num2++;
                A_1++;
            }
        }
    }

    private static string smethod_12(string A_0)
    {
        int num = (A_0 != null) ? A_0.Length : 0;
        if ((num > 0) && (A_0[num - 1] == '\0'))
        {
            A_0 = A_0.Substring(0, num - 1);
        }
        return A_0;
    }

    public static double smethod_2(Stream A_0, byte[] A_1)
    {
        int num = 15;
        if (A_0.Read(A_1, 0, 8) != 8)
        {
            throw new Exception(BookmarkStart.b("簴夶伸娺儼嘾╀捂⅄♆㵈⩊", num));
        }
        return BitConverter.ToDouble(A_1, 0);
    }

    public static int smethod_3(Stream A_0, short A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, 2);
        return 2;
    }

    public static int smethod_4(Stream A_0, int A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, 4);
        return 4;
    }

    public static int smethod_5(Stream A_0, double A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, 8);
        return 8;
    }

    public static string smethod_6(Stream A_0, int A_1)
    {
        byte[] buffer = new byte[4];
        int count = smethod_1(A_0, buffer);
        byte[] buffer2 = new byte[count];
        if (A_0.Read(buffer2, 0, count) != count)
        {
            throw new IOException();
        }
        for (int i = 0; i < count; i++)
        {
            if (buffer2[i] == 0)
            {
                A_1 = i;
                break;
            }
        }
        return smethod_12(Encoding.Default.GetString(buffer2, 0, A_1));
    }

    public static string smethod_7(Stream A_0, int A_1)
    {
        byte[] buffer = new byte[4];
        int count = smethod_1(A_0, buffer) * 2;
        byte[] buffer2 = new byte[count];
        if (A_0.Read(buffer2, 0, count) != count)
        {
            throw new IOException();
        }
        int num2 = 4 - (count % 4);
        if (num2 != 4)
        {
            A_0.Position += num2;
        }
        return smethod_12(Encoding.Unicode.GetString(buffer2, 0, count));
    }

    public static int smethod_8(Stream A_0, string A_1)
    {
        Encoding encoding = Encoding.Default;
        return smethod_10(A_0, A_1, encoding, false);
    }

    public static int smethod_9(Stream A_0, string A_1)
    {
        return smethod_10(A_0, A_1, Encoding.Unicode, true);
    }
}

