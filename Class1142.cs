using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class1142
{
    private Class1142()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        Class108 class2 = new Class108();
        smethod_5(A_0, class2);
        Class92 class3 = A_0.method_13().method_2(class2.method_4(), null, A_0.method_20(), true) as Class92;
        if ((class3 != null) && (class3.method_4() != null))
        {
            class2.method_9(new Section(A_0.method_9()));
            smethod_1(class2.method_8(), class3.method_4());
        }
        else
        {
            class2.method_9(new Section(A_0.method_9()));
        }
        A_0.method_14().Add(class2);
        smethod_6(A_0, class2);
    }

    internal static void smethod_1(Section A_0, Class17 A_1)
    {
        A_1.CopyPropertiesTo(A_0.SectPr);
        A_0.PageSetup.PageSize = new SizeF(A_1.method_96() / 20f, A_1.method_98() / 20f);
    }

    internal static void smethod_2(Class17 A_0, Class17 A_1)
    {
        A_0.method_117(A_1.method_116());
        A_0.method_121((int) (((float) A_1.method_120()) / 20f));
        A_0.method_119(A_1.method_118());
        A_0.method_123(A_1.method_122());
        A_0.method_63(A_1.method_62());
    }

    internal static void smethod_3(Section A_0, Class17 A_1)
    {
        A_0.SectPr.method_50().Left = ((float) A_1.method_31(0x8e8)) / 20f;
        A_0.SectPr.method_50().Right = ((float) A_1.method_31(0x8f2)) / 20f;
        A_0.SectPr.method_50().Top = ((float) A_1.method_31(0x8fc)) / 20f;
        A_0.SectPr.method_50().Bottom = ((float) A_1.method_31(0x906)) / 20f;
        A_0.SectPr.SetAttr(0x8fc, A_0.SectPr.method_50().Top);
        A_0.SectPr.SetAttr(0x906, A_0.SectPr.method_50().Bottom);
        A_0.SectPr.SetAttr(0x8e8, A_0.SectPr.method_50().Left);
        A_0.SectPr.SetAttr(0x8f2, A_0.SectPr.method_50().Right);
    }

    internal static void smethod_4(Border A_0, Class1031 A_1)
    {
        A_0.LineWidth = A_1.method_8();
        A_0.BorderType = A_1.method_1();
        A_0.Color = A_1.method_10();
        A_0.Space = (float) A_1.method_14();
        A_0.Shadow = A_1.method_16();
    }

    private static void smethod_5(Class857 A_0, Class108 A_1)
    {
        int num = 2;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if (!Class857.smethod_8(class2, A_1) && ((str = class2.method_1()) != null))
            {
                if (!(str == BookmarkStart.b("堧䬩䬫䬭ᴯ帱唳伵圷伹䠻ጽ⸿⍁⥃⍅", num)))
                {
                    if (str == BookmarkStart.b("䘧伩含娭ᴯ䄱䀳伵吷弹ᄻ倽ℿ⽁⅃", num))
                    {
                        A_1.method_7(Class576.smethod_87(class2.method_3()));
                    }
                }
                else
                {
                    A_1.method_5(class2.method_3());
                }
            }
        }
    }

    private static void smethod_6(Class857 A_0, Class108 A_1)
    {
        int num = 6;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䄫伭䌯䘱儳䐵ᔷ䨹崻夽┿", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (((str == BookmarkStart.b("䐫䬭儯嘱儳䐵", num)) || (str == BookmarkStart.b("䨫䄭弯䘱儳䐵", num))) || ((str == BookmarkStart.b("䐫䬭儯嘱儳䐵ᔷ嘹夻堽㐿", num)) || (str == BookmarkStart.b("䨫䄭弯䘱儳䐵ᔷ嘹夻堽㐿", num)))))
            {
                Class575.smethod_0(A_0, A_1, class2.method_1());
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }
}

