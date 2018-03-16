using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class Class61
{
    private const int int_0 = 0xd800;
    private const int int_1 = 0xdbff;
    private const int int_2 = 0xdc00;
    private const int int_3 = 0xdfff;
    private const int int_4 = 0x10000;
    private const int int_5 = 0x10ffff;

    public static string smethod_0(int A_0)
    {
        int num = 6;
        if (!smethod_4(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("夫娭嘯ıس电倷嬹主", num));
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
        int num = 2;
        if (!smethod_7(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䐧伩䴫䨭", num));
        }
        if (!smethod_8(A_1))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尧䬩䔫䈭", num));
        }
        return ((((A_0 - 0xd800) * 0x400) + (A_1 - 0xdc00)) + 0x10000);
    }

    public static int[] smethod_10(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return new int[0];
        }
        List<int> list = new List<int>();
        using (IEnumerator enumerator = new Class60(A_0).System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int current = (int) enumerator.Current;
                list.Add(current);
            }
        }
        return list.ToArray();
    }

    public static string smethod_11(int[] A_0, int A_1, int A_2)
    {
        int num = 15;
        if ((A_0 == null) || (A_0.Length < 1))
        {
            return "";
        }
        if ((A_1 < 0) || (A_1 >= A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䘴䌶堸䤺䤼", num));
        }
        if ((A_2 < A_1) || (A_2 > A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("倴夶崸", num));
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
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔵", num));
        }
        if ((A_1 < 0) || (A_1 >= A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䘵圷䤹唻䨽⤿ⵁ⩃", num));
        }
        if (!smethod_6(A_0[A_1]))
        {
            return A_0[A_1];
        }
        if (!smethod_3(A_0, A_1))
        {
            throw new ArgumentException(BookmarkStart.b("电倷嬹主弽⌿㙁⅃㑅㭇橉╋㵍灏㱑㭓≕硗㭙籛⡝ş๡ൣɥ䡧ᥩᥫᱭɯᵱ፳᝵౷ό屻๽ꢅ", num));
        }
        return smethod_1(A_0[A_1], A_0[A_1 + 1]);
    }

    public static bool smethod_3(string A_0, int A_1)
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

