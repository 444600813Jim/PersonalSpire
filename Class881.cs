using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class881
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    internal const int int_0 = 0;
    internal const int int_1 = 1;
    internal const int int_10 = 10;
    internal const int int_11 = 11;
    internal const int int_12 = 12;
    internal const int int_13 = 0xfff;
    internal const int int_14 = 0xfff;
    internal const int int_2 = 2;
    internal const int int_3 = 3;
    internal const int int_4 = 4;
    internal const int int_5 = 5;
    internal const int int_6 = 6;
    internal const int int_7 = 7;
    internal const int int_8 = 8;
    internal const int int_9 = 9;

    static Class881()
    {
        hashtable_0.Add(StyleIdentifier.Normal, 0);
        hashtable_0.Add(StyleIdentifier.Heading1, 1);
        hashtable_0.Add(StyleIdentifier.Heading2, 2);
        hashtable_0.Add(StyleIdentifier.Heading3, 3);
        hashtable_0.Add(StyleIdentifier.Heading4, 4);
        hashtable_0.Add(StyleIdentifier.Heading5, 5);
        hashtable_0.Add(StyleIdentifier.Heading6, 6);
        hashtable_0.Add(StyleIdentifier.Heading7, 7);
        hashtable_0.Add(StyleIdentifier.Heading8, 8);
        hashtable_0.Add(StyleIdentifier.Heading9, 9);
        hashtable_0.Add(StyleIdentifier.DefaultParagraphFont, 10);
        hashtable_0.Add(StyleIdentifier.TableNormal, 11);
        hashtable_0.Add(StyleIdentifier.NoList, 12);
    }

    private Class881()
    {
    }

    internal static StyleIdentifier smethod_0(string A_0)
    {
        return Class417.smethod_25(Class417.smethod_28(A_0));
    }

    internal static void smethod_1(Style A_0, Style A_1)
    {
        A_0.method_15(StyleIdentifier.User, true);
        if (A_1 != null)
        {
            A_0.method_13(A_1.StyleDocId, true);
        }
        else if (smethod_4(A_0.StyleDocId))
        {
            A_0.method_13(A_0.Styles.method_15(), true);
        }
    }

    internal static void smethod_2(Style A_0, StyleIdentifier A_1, Style A_2, bool A_3)
    {
        A_0.method_15(A_1, A_3);
        int num = smethod_3(A_1);
        if (num != 0xfff)
        {
            A_0.method_13(num, A_3);
        }
        else if (A_2 != null)
        {
            A_0.method_13(A_2.StyleDocId, A_3);
        }
    }

    internal static int smethod_3(StyleIdentifier A_0)
    {
        int num = 0xfff;
        if (hashtable_0.Contains(A_0))
        {
            num = (int) hashtable_0[A_0];
        }
        return num;
    }

    internal static bool smethod_4(int A_0)
    {
        return hashtable_0.ContainsValue(A_0);
    }
}

