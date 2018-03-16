using Spire.Doc;
using System;
using System.IO;
using System.Text;

internal class Class736
{
    private static readonly char[] char_0 = new char[] { ' ', '<', '>', '{', '}', '|', '^', '[', ']', '`', '"' };
    private static readonly char[] char_1 = new char[] { '/', '\\' };
    private const string string_0 = " <>{}|^[]`\"%";

    private Class736()
    {
    }

    public static string smethod_0(string A_0, string A_1)
    {
        if (!smethod_20(A_1))
        {
            return smethod_11(A_0, A_1);
        }
        return A_1;
    }

    public static string smethod_1(string A_0, string A_1)
    {
        A_1 = smethod_17(A_1);
        if (!smethod_20(A_1))
        {
            return smethod_11(A_0, A_1);
        }
        return A_1;
    }

    private static bool smethod_10(char A_0)
    {
        return (((A_0 >= 'a') && (A_0 <= 'z')) || ((A_0 >= 'A') && (A_0 <= 'Z')));
    }

    public static string smethod_11(string A_0, string A_1)
    {
        string str;
        int num = 5;
        if (!Class567.smethod_16(A_0))
        {
            return A_1;
        }
        if (A_0.IndexOf(BookmarkStart.b("眪", num)) != -1)
        {
            str = BookmarkStart.b("眪", num);
        }
        else
        {
            str = BookmarkStart.b("Ъ", num);
        }
        if (A_0.EndsWith(str))
        {
            return (A_0 + A_1);
        }
        return (A_0 + str + A_1);
    }

    public static string smethod_12(string A_0)
    {
        int num2 = 3;
        int num = A_0.LastIndexOfAny(char_1);
        if (num >= 0)
        {
            return A_0.Substring(0, Math.Max(num, 1));
        }
        return BookmarkStart.b("ܨ", num2);
    }

    public static bool smethod_13(string A_0)
    {
        int num = A_0.LastIndexOf('.');
        int num2 = A_0.LastIndexOfAny(char_1);
        int index = A_0.IndexOf(BookmarkStart.b("ᘫĭἯ", 6));
        if (num <= num2)
        {
            return false;
        }
        if (index >= 0)
        {
            return ((index + 2) != num2);
        }
        return true;
    }

    public static bool smethod_14(string A_0)
    {
        return A_0.StartsWith(BookmarkStart.b("మ", 9));
    }

    public static string smethod_15(string A_0)
    {
        if (!smethod_19(A_0))
        {
            return A_0;
        }
        return smethod_16(A_0);
    }

    public static string smethod_16(string A_0)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < A_0.Length; i++)
        {
            char ch = A_0[i];
            if (smethod_18(ch))
            {
                smethod_23(builder, ch);
            }
            else
            {
                builder.Append(ch);
            }
        }
        return builder.ToString();
    }

    public static string smethod_17(string A_0)
    {
        if (!Class567.smethod_16(A_0))
        {
            return A_0;
        }
        StringBuilder builder = new StringBuilder();
        int startIndex = 0;
        while (startIndex < A_0.Length)
        {
            char ch = A_0[startIndex];
            if ((ch == '%') && ((startIndex + 2) < A_0.Length))
            {
                string str = A_0.Substring(startIndex, 3);
                if (smethod_21(str))
                {
                    builder.Append(smethod_22(str));
                    startIndex += 3;
                    continue;
                }
            }
            builder.Append(ch);
            startIndex++;
        }
        return builder.ToString();
    }

    private static bool smethod_18(char A_0)
    {
        return (BookmarkStart.b("ᠷعȻ䔽㴿㹁ᩃᵅᕇ⩉湋歍", 0x12).IndexOf(A_0) >= 0);
    }

    private static bool smethod_19(string A_0)
    {
        if (Class567.smethod_16(A_0))
        {
            if (smethod_7(A_0) || smethod_8(A_0))
            {
                return false;
            }
            if (A_0.IndexOfAny(char_0) >= 0)
            {
                return true;
            }
            for (int i = 0; i < A_0.Length; i++)
            {
                if (((A_0[i] == '%') && ((i + 2) < A_0.Length)) && !smethod_21(A_0.Substring(i, 3)))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static string smethod_2(string A_0)
    {
        int index = A_0.IndexOf('#');
        if (index < 0)
        {
            return A_0;
        }
        return A_0.Substring(0, index);
    }

    private static bool smethod_20(string A_0)
    {
        if (!smethod_5(A_0) && !smethod_7(A_0))
        {
            return smethod_8(A_0);
        }
        return true;
    }

    private static bool smethod_21(string A_0)
    {
        return ((((A_0.Length == 3) && (A_0[0] == '%')) && Class567.smethod_35(A_0[1])) && Class567.smethod_35(A_0[2]));
    }

    private static char smethod_22(string A_0)
    {
        return (char) ((Class567.smethod_31(A_0[1]) * 0x10) + Class567.smethod_31(A_0[2]));
    }

    private static void smethod_23(StringBuilder A_0, char A_1)
    {
        A_0.Append('%');
        A_0.Append(Class567.smethod_39((byte) A_1));
    }

    public static string smethod_24(string A_0, string A_1)
    {
        if (Path.GetFileName(A_1) == A_1)
        {
            return Path.Combine(Path.GetDirectoryName(A_0), Path.GetFileName(A_1));
        }
        return A_1;
    }

    public static string smethod_3(string A_0)
    {
        int index = A_0.IndexOf('#');
        if (index < 0)
        {
            return string.Empty;
        }
        return A_0.Substring(index + 1);
    }

    public static string smethod_4(string A_0, string A_1)
    {
        int num = 5;
        if (A_0 == null)
        {
            A_0 = string.Empty;
        }
        if (Class567.smethod_16(A_1))
        {
            return (A_0 + BookmarkStart.b("ࠪ", num) + A_1);
        }
        return A_0;
    }

    public static bool smethod_5(string A_0)
    {
        return (A_0.IndexOf(':') > 1);
    }

    public static bool smethod_6(string A_0)
    {
        if (!smethod_7(A_0))
        {
            return smethod_8(A_0);
        }
        return true;
    }

    public static bool smethod_7(string A_0)
    {
        if (((A_0.Length <= 2) || !smethod_10(A_0[0])) || (A_0[1] != ':'))
        {
            return false;
        }
        if (A_0[2] != '\\')
        {
            return (A_0[2] == '/');
        }
        return true;
    }

    public static bool smethod_8(string A_0)
    {
        return A_0.StartsWith(BookmarkStart.b("椴欶", 15));
    }

    public static bool smethod_9(string A_0)
    {
        return A_0.StartsWith(BookmarkStart.b("伫䜭启࠱", 6));
    }
}

