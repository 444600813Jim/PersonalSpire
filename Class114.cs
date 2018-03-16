using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;
using System.Text;

internal class Class114
{
    private static readonly char[] char_0 = new char[] { '#' };

    private Class114()
    {
    }

    internal static string smethod_0(string A_0)
    {
        for (int i = 0; i < 9; i++)
        {
            A_0 = A_0.Replace(((char) i).ToString(), smethod_2(i));
        }
        return A_0;
    }

    internal static string smethod_1(Class578 A_0)
    {
        int num = 8;
        string str = A_0.method_13();
        int[] numArray = A_0.method_12();
        ListPatternType[] typeArray = A_0.method_11();
        StringBuilder builder = new StringBuilder();
        int num2 = 0;
        for (int i = 0; num2 < str.Length; i++)
        {
            builder.Append(smethod_2(str[num2++]));
            builder.Append(BookmarkStart.b("ᐭ", num));
            builder.Append(Class1041.smethod_8(numArray[i]));
            builder.Append(BookmarkStart.b("ᐭ", num));
            builder.Append(Class1041.smethod_8((int) typeArray[i]));
            builder.Append(BookmarkStart.b("ᐭ", num));
            if (num2 < str.Length)
            {
                char ch = str[num2];
                if (ch > '\b')
                {
                    builder.Append(ch);
                    num2++;
                }
            }
        }
        return builder.ToString();
    }

    internal static void smethod_10(string A_0, byte[] A_1, int A_2)
    {
        for (int i = 0; i < A_0.Length; i += 2)
        {
            A_1[A_2++] = (byte) Class1041.smethod_26(A_0.Substring(i, 2));
        }
    }

    internal static void smethod_11(string A_0, byte[] A_1, int A_2)
    {
        A_2 = (A_2 + (A_0.Length / 2)) - 1;
        for (int i = 0; i < A_0.Length; i += 2)
        {
            A_1[A_2--] = (byte) Class1041.smethod_26(A_0.Substring(i, 2));
        }
    }

    internal static string smethod_12(Color A_0)
    {
        int num = 5;
        if (A_0.IsEmpty)
        {
            return BookmarkStart.b("䨪堬嬮帰", num);
        }
        return Class1041.smethod_43(A_0.ToArgb()).Substring(2);
    }

    internal static Color smethod_13(string A_0)
    {
        A_0 = A_0.ToLower();
        if (A_0 == BookmarkStart.b("䠨帪夬䀮", 3))
        {
            return Color.Empty;
        }
        A_0 = A_0.Trim(char_0);
        if (smethod_15(A_0))
        {
            return smethod_14(A_0);
        }
        return Color.FromName(A_0);
    }

    private static Color smethod_14(string A_0)
    {
        int num = smethod_8(A_0);
        int red = (num & 0xff0000) >> 0x10;
        int green = (num & 0xff00) >> 8;
        int blue = num & 0xff;
        return Color.FromArgb(red, green, blue);
    }

    private static bool smethod_15(string A_0)
    {
        if (A_0.Length != 6)
        {
            return false;
        }
        for (int i = 0; i < A_0.Length; i++)
        {
            if (!Class567.smethod_35(A_0[i]))
            {
                return false;
            }
        }
        return true;
    }

    internal static string smethod_16(int A_0)
    {
        int num = A_0 >> 0x10;
        int num2 = A_0 % 0x10000;
        string str = Class1041.smethod_8(num);
        return string.Format(BookmarkStart.b("匧ᨩ儫-䬯̱䤳", 2), str, Class1041.smethod_34(num2));
    }

    internal static int smethod_17(string A_0)
    {
        int num = 0;
        if (!Class567.smethod_16(A_0))
        {
            return num;
        }
        string[] strArray = A_0.Split(new char[] { '.' });
        int num2 = Class1041.smethod_11(strArray[0]);
        int num3 = 0;
        if (strArray.Length > 1)
        {
            num3 = Class1041.smethod_11(strArray[1]);
        }
        return ((num2 << 0x10) | num3);
    }

    internal static string smethod_18(byte[] A_0)
    {
        return Class525.smethod_0(A_0, BookmarkStart.b("☫", 6));
    }

    internal static int smethod_19(string A_0)
    {
        if (!Class567.smethod_16(A_0))
        {
            return -2147483648;
        }
        int num = A_0.Length - 1;
        while (num >= 0)
        {
            if ((A_0[num] < '0') || (A_0[num] > '9'))
            {
                break;
            }
            num--;
        }
        return Class1041.smethod_18(A_0.Substring(num + 1));
    }

    internal static string smethod_2(int A_0)
    {
        return string.Format(BookmarkStart.b("ᔯ䤱г䬵", 10), A_0 + 1);
    }

    internal static string smethod_3(int[] A_0)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < A_0.Length; i++)
        {
            builder.Append(Class1041.smethod_8(A_0[i]));
            builder.Append(',');
        }
        if (builder.Length > 0)
        {
            builder.Length--;
        }
        return builder.ToString();
    }

    internal static string smethod_4(byte[] A_0, int A_1)
    {
        return Class567.smethod_38(A_0, A_1, 4, true);
    }

    internal static string smethod_5(int A_0)
    {
        return Class1041.smethod_43(A_0);
    }

    internal static string smethod_6(object A_0)
    {
        if (A_0 is int)
        {
            return Class1041.smethod_43((int) A_0);
        }
        return null;
    }

    internal static int smethod_7(string A_0)
    {
        return Class1041.smethod_27(A_0);
    }

    internal static int smethod_8(string A_0)
    {
        return Class1041.smethod_26(A_0);
    }

    internal static int smethod_9(string A_0)
    {
        if ((A_0.Length != 8) && Class567.smethod_36(A_0))
        {
            return (int) (Class1041.smethod_25(A_0) & 0xffffffffL);
        }
        return smethod_8(A_0);
    }
}

