using Spire.Doc;
using System;
using System.Collections.Generic;

internal static class Class203
{
    internal static List<char> list_0 = new List<char> { 
        0x24, 40, 0x5b, 0x7b, 0xa3, 0xa5, 0xab, 0xb7, 0x2018, 0x201c, 0x3008, 0x300a, 0x300c, 0x300e, 0x3010, 0x3014, 
        0x3016, 0x301d, 0xfe59, 0xfe5b, 0xfe5d, 0xff04, 0xff08, 0xff0e, 0xff3b, 0xff5b, 0xffe1, 0xffe5
     };
    internal static List<char> list_1 = new List<char> { 
        0x21, 0x25, 0x29, 0x2c, 0x2e, 0x3a, 0x3b, 0x3e, 0x3b, 0x3f, 0x5d, 0x7d, 0xa2, 0xa8, 0xb0, 0xb7, 
        0xbb, 0x2c7, 0x2c9, 0x2015, 0x2016, 0x2019, 0x201d, 0x2026, 0x2030, 0x2032, 0x2033, 0x203a, 0x2103, 0x2236, 0x3001, 0x3002, 
        0x3003, 0x3009, 0x300b, 0x300d, 0x300f, 0x3011, 0x3015, 0x3017, 0x301e, 0xfe36, 0xfe3a, 0xfe3e, 0xfe40, 0xfe44, 0xfe5a, 0xfe5c, 
        0xfe5e, 0xff01, 0xff02, 0xff05, 0xff07, 0xff09, 0xff0c, 0xff0e, 0xff1a, 0xff1b, 0xff1f, 0xff3d, 0xff40, 0xff5c, 0xff5d, 0xff5e, 
        0xffe0
     };

    internal static LineBreaksPunctuation smethod_0(char A_0)
    {
        LineBreaksPunctuation none = LineBreaksPunctuation.None;
        bool flag = false;
        if (list_0.Contains(A_0))
        {
            flag = true;
            none = LineBreaksPunctuation.LineBreaksAfter;
        }
        if (!flag && list_1.Contains(A_0))
        {
            none = LineBreaksPunctuation.LineBreaksBefore;
        }
        return none;
    }

    internal static bool smethod_1(char A_0)
    {
        if (!list_1.Contains(A_0))
        {
            return list_0.Contains(A_0);
        }
        return true;
    }

    internal static bool smethod_2(char A_0)
    {
        return list_0.Contains(A_0);
    }

    internal static bool smethod_3(char A_0)
    {
        return list_1.Contains(A_0);
    }

    internal static int smethod_4(string A_0, int A_1)
    {
        int num;
        if (A_0 == null)
        {
            return 0;
        }
        if (A_0.Length <= A_1)
        {
            return 0;
        }
        char[] chArray = A_0.ToCharArray();
        int num3 = 0;
        if (chArray.Length <= A_1)
        {
            return num3;
        }
        for (int i = A_1; i > 0; i--)
        {
            LineBreaksPunctuation punctuation2 = smethod_0(chArray[i - 1]);
            switch (punctuation2)
            {
                case LineBreaksPunctuation.None:
                case LineBreaksPunctuation.LineBreaksBefore:
                    goto Label_0053;
            }
            if ((punctuation2 == LineBreaksPunctuation.LineBreaksAfter) && ((num3 + A_1) > 1))
            {
                num3--;
            }
        }
    Label_0053:
        num = A_1;
        while (num < chArray.Length)
        {
            LineBreaksPunctuation punctuation = smethod_0(chArray[num]);
            switch (punctuation)
            {
                case LineBreaksPunctuation.None:
                case LineBreaksPunctuation.LineBreaksAfter:
                    return num3;
            }
            if (punctuation == LineBreaksPunctuation.LineBreaksBefore)
            {
                num3++;
            }
            num++;
        }
        return num3;
    }
}

