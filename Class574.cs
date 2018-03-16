using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;

internal class Class574
{
    private static bool bool_0;

    private Class574()
    {
    }

    internal static void smethod_0(Class857 A_0, string A_1, DocumentObject A_2)
    {
        smethod_1(A_0, A_1, A_2, null);
    }

    internal static void smethod_1(Class857 A_0, string A_1, DocumentObject A_2, Class106 A_3)
    {
        int num = 0x10;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(A_1))
        {
            A_0.method_17(class2.method_12(BookmarkStart.b("䔵䰷䌹倻嬽洿ⱁ╃⭅ⵇ", num), BookmarkStart.b("攵䰷嬹刻娽ℿぁ⁃", num)));
            Class108 class3 = smethod_10(A_0);
            A_2 = smethod_4(A_0, class3, A_2);
            if (!smethod_3(A_0, A_2, A_3, class3))
            {
                class2.vmethod_1();
            }
        }
    }

    internal static Class108 smethod_10(Class857 A_0)
    {
        int num = 0;
        Class91 class2 = A_0.method_13().method_2(A_0.method_16(), null, A_0.method_20(), true);
        if (class2 is Class92)
        {
            return A_0.method_14().method_0(BookmarkStart.b("甥尧䬩䈫䨭儯䀱倳", num));
        }
        Class93 class3 = (Class93) class2;
        string str = (class3 != null) ? class3.method_6() : A_0.method_26();
        return smethod_11(A_0, A_0.method_14(), str);
    }

    internal static Class108 smethod_11(Class857 A_0, Class854 A_1, string A_2)
    {
        int num = 3;
        Class108 class2 = A_1.method_0(A_2);
        if (class2 != null)
        {
            return class2;
        }
        return A_1.method_0(BookmarkStart.b("稨弪䰬䄮唰刲䜴匶", num));
    }

    internal static bool smethod_2(Class857 A_0, DocumentObject A_1, Class108 A_2)
    {
        return smethod_3(A_0, A_1, null, A_2);
    }

    private static bool smethod_3(Class857 A_0, DocumentObject A_1, Class106 A_2, Class108 A_3)
    {
        int num = 10;
        Class396 class2 = A_0.method_11();
        if (Class857.smethod_10(A_0, A_1, null, null))
        {
            return true;
        }
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_108 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(15);
                dictionary1.Add(BookmarkStart.b("䀯", num), 0);
                dictionary1.Add(BookmarkStart.b("堯", num), 1);
                dictionary1.Add(BookmarkStart.b("尯嬱䜳䈵", num), 2);
                dictionary1.Add(BookmarkStart.b("䐯匱嘳娵崷", num), 3);
                dictionary1.Add(BookmarkStart.b("䐯匱嘳娵崷᜹医堽洿⅁⭃⡅㱇⽉≋㩍", num), 4);
                dictionary1.Add(BookmarkStart.b("儯帱䐳帵夷堹夻䨽⤿⅁╃⩅敇⍉≋⩍㕏⩑", num), 5);
                dictionary1.Add(BookmarkStart.b("夯帱堳䌵䬷丹主弽㐿⭁⭃⡅敇⍉≋⩍㕏⩑", num), 6);
                dictionary1.Add(BookmarkStart.b("䐯匱嘳娵崷᜹唻倽␿❁㱃", num), 7);
                dictionary1.Add(BookmarkStart.b("弯倱帳匵嬷丹ᄻ圽⸿♁⅃㹅", num), 8);
                dictionary1.Add(BookmarkStart.b("䔯䄱儳䐵ᔷ匹刻娽┿㩁", num), 9);
                dictionary1.Add(BookmarkStart.b("刯嬱嘳娵儷唹嬻䰽ℿ㉁ⱃ㽅", num), 10);
                dictionary1.Add(BookmarkStart.b("夯就倳匵䀷᜹䠻圽㐿⹁⅃", num), 11);
                dictionary1.Add(BookmarkStart.b("䌯圱圳䈵儷唹刻", num), 12);
                dictionary1.Add(BookmarkStart.b("匯崱娳䈵䨷唹倻", num), 13);
                dictionary1.Add(BookmarkStart.b("䌯崱刳䈵ᔷ䨹崻夽┿潁♃㑅ⵇ⭉❋", num), 14);
                Class1160.dictionary_108 = dictionary1;
            }
            if (Class1160.dictionary_108.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        Class1099.smethod_1(A_0, class2.method_1(), A_1);
                        return true;

                    case 2:
                        Class530.smethod_0(A_0, A_1, null);
                        return true;

                    case 3:
                        Class90.smethod_1(A_0, A_1, A_2);
                        return true;

                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        return Class246.smethod_0(A_0, A_1, A_3);

                    case 11:
                        smethod_0(A_0, BookmarkStart.b("夯就倳匵䀷᜹䠻圽㐿⹁⅃", num), A_1);
                        return true;

                    case 12:
                        Class1098.smethod_0(A_0, A_3);
                        return true;

                    case 13:
                        Class1144.smethod_0(A_0, A_1, null, null);
                        return true;

                    case 14:
                        bool_0 = true;
                        return true;
                }
            }
        }
        return false;
    }

    internal static DocumentObject smethod_4(Class857 A_0, Class108 A_1, DocumentObject A_2)
    {
        int num = 0x10;
        if (smethod_8(A_0) && ((A_2 == null) || (A_2 is Body)))
        {
            bool flag2;
            if (((A_2 is TableCell) || (A_2 is TextBox)) || (A_2 is HeaderFooter))
            {
                return A_2;
            }
            Section lastSection = A_0.method_9().LastSection;
            bool flag = smethod_7(A_0, A_1);
            if ((flag2 = ((A_0.method_32() || A_0.method_30()) || flag) || (A_0.method_9().Sections.Count == 0)) || ((A_2 == null) && (A_0.method_29().Count == 0)))
            {
                if (A_0.method_29().Count == 0)
                {
                    if (flag2)
                    {
                        lastSection = A_1.method_8();
                        A_0.method_9().Sections.Add(lastSection);
                    }
                }
                else
                {
                    Section section2 = (Section) A_0.method_29().Peek();
                    lastSection = section2.Clone();
                    A_1.method_8().SectPr.method_37(lastSection.SectPr);
                    smethod_5((Class17) section2.SectPr.Clone(), lastSection.SectPr);
                    A_0.method_9().Sections.Add(lastSection);
                }
                Section section3 = (Section) A_0.method_9().GetChildElements(1, 1)[0];
                if ((flag && (((A_0.method_38() == null) || A_0.method_38().method_10()) || (section3.Body.ChildObjects.Count != 0))) && bool_0)
                {
                    lastSection.SectPr.method_57(SectionBreakType.NewPage);
                }
                Class91 class2 = A_0.method_13().method_2(A_0.method_16(), null, A_0.method_20(), true);
                if (!(class2 is Class92))
                {
                    Class93 class3 = (Class93) class2;
                    A_0.method_27((class3 != null) ? class3.method_6() : BookmarkStart.b("攵䰷嬹刻娽ℿぁ⁃", num));
                    A_0.method_35((((A_0.method_16() != BookmarkStart.b("攵䰷嬹刻娽ℿぁ⁃", num)) && (class3 != null)) && (class3 is Class97)) && Class567.smethod_16(class3.method_6()));
                }
            }
            smethod_6(A_0.method_9());
            A_0.method_33(false);
            A_0.method_31(false);
            foreach (Paragraph paragraph2 in A_0.method_36())
            {
                if (paragraph2.ParentObject != lastSection.Body)
                {
                    lastSection.Body.method_13(paragraph2);
                }
            }
            A_0.method_36().Clear();
            return lastSection.Body;
        }
        if (A_2 != null)
        {
            foreach (Paragraph paragraph in A_0.method_36())
            {
                if (paragraph.Owner == null)
                {
                    A_2.method_13(paragraph);
                }
            }
        }
        return A_2;
    }

    private static void smethod_5(Class17 A_0, Class17 A_1)
    {
        if (A_0.method_116() != 0)
        {
            A_1.method_117(A_0.method_116());
            A_1.method_123(A_0.method_122());
            A_1.method_119(A_0.method_118());
            A_1.method_63(A_0.method_62());
            A_1.method_121(A_0.method_120());
        }
    }

    private static void smethod_6(Document A_0)
    {
        PageSetup pageSetup = A_0.LastSection.PageSetup;
        if ((A_0.LastSection.BreakCode == SectionBreakType.NoBreak) && (A_0.Sections.Count > 1))
        {
            PageSetup setup2 = ((Section) A_0.LastSection.PreviousSibling).PageSetup;
            pageSetup.PageSize = setup2.PageSize;
            pageSetup.Margins.Top = setup2.Margins.Top;
            pageSetup.Margins.Bottom = setup2.Margins.Bottom;
            pageSetup.Margins.Left = setup2.Margins.Left;
            pageSetup.Margins.Right = setup2.Margins.Right;
        }
    }

    private static bool smethod_7(Class857 A_0, Class108 A_1)
    {
        Class108 class2 = null;
        Class91 class3 = A_0.method_13().method_2(A_0.method_16(), null, A_0.method_20(), true);
        if (!(class3 is Class92))
        {
            class2 = smethod_11(A_0, A_0.method_14(), A_0.method_26());
        }
        bool flag = ((class3 != null) && !(class3 is Class92)) && Class567.smethod_16(((Class93) class3).method_6());
        bool flag2 = (A_1.method_0() != A_0.method_26()) && (A_0.method_26() != null);
        if (!flag)
        {
            return false;
        }
        return (((flag2 || A_0.method_34()) || ((class2 == null) || !A_1.method_8().SectPr.Equals(class2.method_8().SectPr))) || ((class3 is Class97) && ((Class97) class3).method_33()));
    }

    private static bool smethod_8(Class857 A_0)
    {
        int num = 5;
        Class396 class2 = A_0.method_11();
        string str = class2.method_1();
        string str2 = class2.method_0();
        if ((!Class576.smethod_1(class2) && ((str2 != BookmarkStart.b("伪弬丮䘰", num)) || (str != BookmarkStart.b("䨪", num)))) && (((((!(str == BookmarkStart.b("䰪", num)) && !(str == BookmarkStart.b("䜪䐬䄮吰", num))) && (!(str == BookmarkStart.b("䠪䈬䄮弰嘲嘴䌶嘸䤺", num)) && !(str == BookmarkStart.b("太䠬䰮䔰", num)))) && ((!(str == BookmarkStart.b("䠪䐬崮到弲倴", num)) && !(str == BookmarkStart.b("个䄬䌮堰䌲䘴制", num))) && (!(str == BookmarkStart.b("嬪䈬䌮䠰弲尴夶尸", num)) && !(str == BookmarkStart.b("嬪䈬䌮䠰吲娴夶", num))))) && (((!(str == BookmarkStart.b("太䠬䠮䐰弲吴䔶ᐸ䬺刼匾㡀⑂⩄⥆", num)) && !(str == BookmarkStart.b("嬪䰬嬮夰", num))) && (!(str == BookmarkStart.b("嬪䰬䠮吰Ḳ䄴弶䰸嘺弼儾⁀⩂⥄", num)) && !(str == BookmarkStart.b("䘪䠬丮䈰䘲䜴制", num)))) && ((!(str == BookmarkStart.b("䠪䰬弮䔰娲娴夶", num)) && !(str == BookmarkStart.b("堪丬䨮弰嘲", num))) && (!(str == BookmarkStart.b("䠪堬尮䔰尲場ᨶ䨸区尼伾⑀", num)) && !(str == BookmarkStart.b("嬪", num)))))) && ((!(str == BookmarkStart.b("䌪", num)) && !(str == BookmarkStart.b("弪䰬䴮崰嘲", num))) && !(str == BookmarkStart.b("䜪䐬尮䔰", num)))))
        {
            return (str == BookmarkStart.b("䜪䐬䄮吰", num));
        }
        return true;
    }

    private static void smethod_9(Class857 A_0, Class108 A_1, Section A_2)
    {
        Class92 class2 = A_0.method_13().method_2(A_1.method_4(), null, A_0.method_20(), true) as Class92;
        if (class2 != null)
        {
            if (class2.method_12() != null)
            {
                A_2.SectPr.method_50().Top += class2.method_12().method_8();
            }
            if (class2.method_14() != null)
            {
                A_2.SectPr.method_50().Bottom += class2.method_14().method_8();
            }
        }
    }
}

