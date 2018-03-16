using Spire.Doc;
using System;
using System.Collections;
using System.Text;

internal class Class334
{
    private const int int_0 = 0xd800;
    private const int int_1 = 0xdbff;
    private const int int_2 = 0xdc00;
    private const int int_3 = 0xdfff;
    private const int int_4 = 0x10000;
    private const int int_5 = 0x10ffff;

    public static string smethod_0(int A_0)
    {
        int num = 0;
        if (!smethod_4(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("匥尧䰩Ἣᰭ猯娱唳䐵", num));
        }
        if (smethod_5(A_0))
        {
            char ch = (char) (((A_0 - 0x10000) / 0x400) + 0xd800);
            char ch2 = (char) (((A_0 - 0x10000) % 0x400) + 0xdc00);
            return new string(new char[] { ch, ch2 });
        }
        return new string((char) A_0, 1);
    }

    public static int smethod_1(char A_0, char A_1)
    {
        int num = 11;
        if (!smethod_7(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("崰嘲吴匶", num));
        }
        if (!smethod_8(A_1))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔰刲尴嬶", num));
        }
        return ((((A_0 - 0xd800) * 0x400) + (A_1 - 0xdc00)) + 0x10000);
    }

    public static int[] smethod_10(string A_0)
    {
        if (!Class567.smethod_16(A_0))
        {
            return new int[0];
        }
        Class741 class2 = new Class741();
        using (IEnumerator enumerator = new Class1087(A_0).System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int current = (int) enumerator.Current;
                class2.method_9(current);
            }
        }
        return class2.method_30();
    }

    public static string smethod_11(int[] A_0, int A_1, int A_2)
    {
        int num = 9;
        if ((A_0 == null) || (A_0.Length < 1))
        {
            return "";
        }
        if ((A_1 < 0) || (A_1 >= A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尮䔰刲䜴䌶", num));
        }
        if ((A_2 < A_1) || (A_2 > A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䨮弰圲", num));
        }
        StringBuilder builder = new StringBuilder();
        for (int i = A_1; i < A_2; i++)
        {
            builder.Append(smethod_0(A_0[i]));
        }
        return builder.ToString();
    }

    public static int smethod_2(string A_0, int A_1)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬷", num));
        }
        if ((A_1 < 0) || (A_1 >= A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䠷唹伻圽㐿⭁⭃⡅", num));
        }
        if (!smethod_6(A_0[A_1]))
        {
            return A_0[A_1];
        }
        if (!smethod_3(A_0, A_1))
        {
            throw new ArgumentException(BookmarkStart.b("笷刹崻䰽ℿ⅁ぃ⍅㩇㥉汋❍⍏牑㩓㥕ⱗ穙㵛繝ᙟ͡ࡣཥ౧䩩Ὣ᭭ɯq᭳ᅵ᥷๹᥻幽ꚇ", num));
        }
        return smethod_1(A_0[A_1], A_0[A_1 + 1]);
    }

    public static bool smethod_3(string A_0, int A_1)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄱", num));
        }
        if ((A_1 < 0) || (A_1 >= A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䈱嬳䔵儷丹唻儽⸿", num));
        }
        if (A_1 == (A_0.Length - 1))
        {
            return false;
        }
        if (!smethod_7(A_0[A_1]))
        {
            return false;
        }
        return smethod_8(A_0[A_1 + 1]);
    }

    public static bool smethod_4(int A_0)
    {
        return (((A_0 >= 0) && (A_0 < 0xd800)) || ((A_0 > 0xdfff) && (A_0 <= 0x10ffff)));
    }

    public static bool smethod_5(int A_0)
    {
        return ((A_0 >= 0x10000) && (A_0 <= 0x10ffff));
    }

    public static bool smethod_6(char A_0)
    {
        if (!smethod_7(A_0))
        {
            return smethod_8(A_0);
        }
        return true;
    }

    public static bool smethod_7(char A_0)
    {
        return ((A_0 >= 0xd800) && (A_0 <= 0xdbff));
    }

    public static bool smethod_8(char A_0)
    {
        return ((A_0 >= 0xdc00) && (A_0 <= 0xdfff));
    }

    public static string smethod_9(int[] A_0)
    {
        if ((A_0 == null) || (A_0.Length < 1))
        {
            return "";
        }
        StringBuilder builder = new StringBuilder();
        foreach (int num2 in A_0)
        {
            builder.Append(smethod_0(num2));
        }
        return builder.ToString();
    }
}

