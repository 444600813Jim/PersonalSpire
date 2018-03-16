using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class1053
{
    private Class1053()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 0x10;
        A_0.method_21(true);
        Class113 class2 = A_0.method_10().method_2(BookmarkStart.b("ᤵ嬷唹刻䨽┿ⱁぃ桅ぇ❉⁋", 0x10));
        if (class2 != null)
        {
            Class396 class3 = new Class396(class2.method_3());
            A_0.method_12(class3);
            while (class3.method_9(BookmarkStart.b("刵圷夹䤻匽┿ⱁぃ歅⭇╉≋㩍㕏㱑⁓", num)))
            {
                string str = class3.method_1();
                if (str != null)
                {
                    if (str != BookmarkStart.b("倵圷吹䠻ጽ☿⍁❃⍅敇⹉⥋ⵍ㱏⅑", num))
                    {
                        if (!(str == BookmarkStart.b("圵䴷丹医匽ℿ㙁ⵃ╅敇㥉㡋㝍㱏㝑❓", num)))
                        {
                            if (!(str == BookmarkStart.b("吵圷帹䔻", num)))
                            {
                                goto Label_0099;
                            }
                            smethod_1(A_0);
                        }
                        else
                        {
                            Class855.smethod_0(A_0);
                        }
                    }
                    else
                    {
                        Class976.smethod_0(A_0);
                    }
                    continue;
                }
            Label_0099:
                class3.vmethod_1();
            }
        }
    }

    private static void smethod_1(Class857 A_0)
    {
        int num = 0x10;
        A_0.method_6(false, true);
        while (A_0.method_11().method_9(BookmarkStart.b("吵圷帹䔻", num)))
        {
            string str;
            if (((str = A_0.method_11().method_1()) != null) && (str == BookmarkStart.b("䈵崷䈹䠻", num)))
            {
                smethod_2(A_0);
            }
            else
            {
                A_0.method_11().vmethod_1();
            }
        }
        if (A_0.method_36().Count > 0)
        {
            Section lastSection = A_0.method_9().LastSection;
            if (lastSection == null)
            {
                lastSection = A_0.method_14().method_0(BookmarkStart.b("攵䰷嬹刻娽ℿぁ⁃", num)).method_8().Clone();
                A_0.method_9().Sections.Add(lastSection);
            }
            foreach (Paragraph paragraph in A_0.method_36())
            {
                if (paragraph.Owner == null)
                {
                    lastSection.Body.method_13(paragraph);
                }
            }
        }
    }

    private static void smethod_2(Class857 A_0)
    {
        int num = 10;
        Class396 class2 = A_0.method_11();
        DocumentObject obj2 = null;
        while (class2.method_9(BookmarkStart.b("䐯圱䰳䈵", num)))
        {
            Class108 class3 = Class574.smethod_10(A_0);
            if (!Class574.smethod_2(A_0, obj2, class3))
            {
                string str;
                if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("嘯崱䘳嬵䬷", num)))
                {
                    smethod_3(A_0);
                }
                else
                {
                    class2.vmethod_1();
                }
            }
        }
    }

    private static void smethod_3(Class857 A_0)
    {
        int num = 0x13;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("弸吺似刾㉀", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("弸吺似刾", num)))
            {
                smethod_4(A_0);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_4(Class857 A_0)
    {
        int num = 0;
        Class1100 class2 = new Class1100();
        Class396 class3 = A_0.method_11();
        while (class3.method_9(BookmarkStart.b("䀥䜧堩䄫", num)))
        {
            string str;
            if (((str = class3.method_1()) != null) && (str == BookmarkStart.b("䔥䀧伩伫䔭刯崱䰳", num)))
            {
                class2.method_2().Add(smethod_5(A_0));
            }
            else
            {
                class3.vmethod_1();
            }
        }
        A_0.method_15().Add(class2);
    }

    private static Class978 smethod_5(Class857 A_0)
    {
        int num = 0x10;
        Class396 class2 = A_0.method_11();
        Class978 class3 = new Class978();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("張尷", num)))
                {
                    if (str == BookmarkStart.b("唵䴷䠹主嬽⸿㙁楃㕅㱇⭉㡋⭍", num))
                    {
                        class3.method_7(class2.method_3());
                    }
                }
                else
                {
                    class3.method_1(class2.method_3());
                }
            }
        }
        return class3;
    }
}

