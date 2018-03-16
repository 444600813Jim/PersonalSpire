using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class1098
{
    private Class1098()
    {
    }

    internal static void smethod_0(Class857 A_0, Class108 A_1)
    {
        int num = 15;
        Section section = A_1.method_8().Clone();
        section.SectPr.method_57(SectionBreakType.NoBreak);
        smethod_1(A_0, section.SectPr);
        Class95 class2 = (Class95) A_0.method_13().method_3(A_0.method_16(), BookmarkStart.b("䘴制娸伺吼倾⽀", 15), A_0.method_20());
        A_0.method_9().Settings.method_5().method_14((class2 != null) && class2.method_14());
        if ((class2 != null) && (class2.method_12() != null))
        {
            class2.method_12().method_37(section.SectPr);
        }
        A_0.method_29().Push(section);
        A_0.method_31(true);
        Class574.smethod_0(A_0, BookmarkStart.b("䘴制娸伺吼倾⽀", num), section.Body);
        A_0.method_33(true);
        A_0.method_29().Pop();
    }

    private static void smethod_1(Class857 A_0, Class17 A_1)
    {
        int num = 15;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            if ((!A_0.method_4(class2) && (class2.method_1() == BookmarkStart.b("䔴䔶嘸伺堼尾㕀♂⅄", num))) && (class2.method_3() == BookmarkStart.b("䄴䔶䰸帺", num)))
            {
                A_0.method_45(true);
                A_1.method_125(false);
            }
        }
    }
}

