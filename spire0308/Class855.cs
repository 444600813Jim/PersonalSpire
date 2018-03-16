using Spire.Doc;
using spr;
using System;

internal class Class855
{
    private Class855()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 11;
        int num2 = 0;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("倰䘲䄴堶吸娺䤼嘾≀湂㙄㍆え❊⡌㱎", num)))
        {
            if (!Class795.smethod_3(A_0, true))
            {
                string str;
                if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䄰刲刴制ᐸ场尼䘾⹀㙂ㅄ", num)))
                {
                    $UNNAMED_TYPE$.smethod_0(A_0);
                    num2++;
                }
                else
                {
                    class2.vmethod_1();
                }
            }
        }
        if (num2 > 1)
        {
            A_0.method_9().method_190(null);
            A_0.method_9().ViewSetup.DisplayBackgroundShape = false;
        }
        A_0.method_6(true, true);
    }
}

