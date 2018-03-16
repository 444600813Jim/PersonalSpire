using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;

internal class Class472
{
    private BorderStyle borderStyle_0;
    private Color color_0 = Color.Empty;
    private double double_0;

    internal double method_0()
    {
        return this.double_0;
    }

    internal void method_1(double A_0)
    {
        this.double_0 = A_0;
    }

    internal BorderStyle method_2()
    {
        return this.borderStyle_0;
    }

    internal void method_3(BorderStyle A_0)
    {
        this.borderStyle_0 = A_0;
    }

    internal Color method_4()
    {
        return this.color_0;
    }

    internal void method_5(Color A_0)
    {
        this.color_0 = A_0;
    }

    internal static Class472 smethod_0(Class472 A_0, string A_1)
    {
        int num = 9;
        if (A_0 == null)
        {
            A_0 = new Class472();
        }
        if (A_1 == BookmarkStart.b("䄮帰崲倴", num))
        {
            A_0.method_3(BorderStyle.None);
            return A_0;
        }
        string[] strArray = A_1.Split(new char[] { ' ' });
        for (int i = 0; i < strArray.Length; i++)
        {
            string str = strArray[i].Trim();
            if (!str.StartsWith(BookmarkStart.b("మ", num)) && (str != BookmarkStart.b("嬮䌰刲嬴䐶䤸娺似娾⽀㝂", num)))
            {
                if (Class576.smethod_38(str))
                {
                    A_0.method_1(Class576.smethod_41(str));
                }
                else if (A_0.method_2() == BorderStyle.None)
                {
                    A_0.method_3(Class922.smethod_35(str));
                }
            }
            else
            {
                A_0.method_5(Class576.smethod_76(str));
            }
        }
        return A_0;
    }

    internal static Class1031 smethod_1(Class472 A_0, double A_1, int A_2)
    {
        Class1031 class2 = new Class1031();
        if (A_0 != null)
        {
            class2.method_2(A_0.method_2());
            class2.method_11(A_0.method_4());
            class2.method_27(Class576.smethod_60(class2.method_1(), A_0.method_0()));
        }
        class2.method_15((double) Class1133.smethod_5((A_1 > 31.0) ? 31.0 : A_1));
        return class2;
    }

    internal static Class1031 smethod_2(Class472 A_0)
    {
        return smethod_1(A_0, 0.0, 0);
    }
}

