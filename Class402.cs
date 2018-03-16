using Spire.Doc;
using Spire.Doc.Documents.Markup;
using System;

internal class Class402
{
    private Class402()
    {
    }

    internal static Class9 smethod_0(Class581 A_0, MarkupLevel A_1)
    {
        int num = 0x10;
        Class394 class2 = A_0.imethod_1();
        Class9 class3 = new Class9(A_0.Interface50.imethod_0(), A_1);
        class3.method_23(class2.method_1());
        class3.method_27(class2.method_7());
        while (class2.method_19())
        {
            if ((class2.method_1() == BookmarkStart.b("䘵吷嬹弻嬽⠿ⵁ⡃≅ⵇ㡉", num)) && (class2.method_7() == BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㥓㽕㭗⡙㍛ⵝཟѡၣ䡥୧թū䅭Ὧᑱታή᭷ό卻ॽꦅ몇몉벋붍뾏ﮓﲗ", num)))
            {
                class3.method_25(class2.method_3());
            }
            else
            {
                Class901 class4 = new Class901(class2.method_1(), class2.method_7(), class2.method_3());
                class3.method_28().method_4(class4);
            }
        }
        return class3;
    }
}

