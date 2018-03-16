using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class413
{
    private Class413()
    {
    }

    internal static void smethod_0(Class857 A_0, Class97 A_1)
    {
        ParagraphFormat format = new ParagraphFormat(A_0.method_9());
        smethod_1(A_0, A_1, format);
        smethod_5(A_0, A_1, format);
        if (A_1.method_25() != -1)
        {
            format.OutlineLevel = (OutlineLevel) A_1.method_25();
        }
        if (format.Count > 0)
        {
            if (A_1.method_15() == null)
            {
                A_1.method_16(format);
            }
            else
            {
                format.method_37(A_1.method_15());
            }
        }
    }

    private static void smethod_1(Class857 A_0, Class97 A_1, ParagraphFormat A_2)
    {
        int num = 0x10;
        Class396 class2 = A_0.method_11();
        bool flag = false;
        int num2 = 0;
        int num3 = 0;
        string str = null;
        string str2 = null;
        bool flag2 = false;
        while (class2.method_19())
        {
            string str3;
            if (((!Class857.smethod_0(class2, A_1, A_2) && !Class857.smethod_9(class2, A_1.method_35())) && (!Class857.smethod_1(class2, A_1.method_37()) && !Class857.smethod_2(class2, A_1.method_39()))) && ((str3 = class2.method_1()) != null))
            {
                int num4;
                if (Class1160.dictionary_27 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x16);
                    dictionary1.Add(BookmarkStart.b("䘵夷崹夻ጽ⸿㝁⥃⑅ⵇ㡉", num), 0);
                    dictionary1.Add(BookmarkStart.b("䈵崷䈹䠻ጽℿ⹁ⵃⅅ♇杉⁋⽍⍏♑", num), 1);
                    dictionary1.Add(BookmarkStart.b("娵儷吹夻ጽ⸿㝁⥃⑅ⵇ㡉", num), 2);
                    dictionary1.Add(BookmarkStart.b("堵䴷圹帻嬽㈿潁⡃⽅♇⽉㽋", num), 3);
                    dictionary1.Add(BookmarkStart.b("嬵夷䤹䠻嬽㈿潁㑃❅⽇⽉態⁍ㅏ㽑ㅓ", num), 4);
                    dictionary1.Add(BookmarkStart.b("䈵崷䈹䠻ጽℿ⹁ⵃⅅ♇", num), 5);
                    dictionary1.Add(BookmarkStart.b("䄵䨷匹䠻圽⸿╁楃⭅❇⹉⥋", num), 6);
                    dictionary1.Add(BookmarkStart.b("䈵崷䈹䠻ጽ⤿ⱁ⁃⍅♇㹉", num), 7);
                    dictionary1.Add(BookmarkStart.b("娵儷吹夻ጽ⠿❁ⵃⅅ⁇㹉", num), 8);
                    dictionary1.Add(BookmarkStart.b("娵儷吹夻ጽ⠿❁ⵃⅅ⁇㹉態⽍⑏网㡓㍕㥗⥙⡛", num), 9);
                    dictionary1.Add(BookmarkStart.b("崵崷弹䰻ጽ㐿ⵁ⍃⍅㱇≉⥋㱍", num), 10);
                    dictionary1.Add(BookmarkStart.b("崵崷弹䰻ጽ㜿⭁ぃ⹅敇⑉⥋㙍⑏", num), 11);
                    dictionary1.Add(BookmarkStart.b("吵夷夹圻夽㈿ⵁㅃ⡅ⱇ杉⽋⅍㱏㵑♓", num), 12);
                    dictionary1.Add(BookmarkStart.b("䈵崷䈹䠻ጽℿ㝁ぃ⥅㭇㩉ⵋⵍ㕏", num), 13);
                    dictionary1.Add(BookmarkStart.b("䘵䴷吹弻䨽㔿⍁ぃ⽅❇⑉態㥍≏㍑⑓", num), 14);
                    dictionary1.Add(BookmarkStart.b("䀵崷䠹䠻圽⌿⍁⡃歅⥇♉╋⥍㹏", num), 15);
                    dictionary1.Add(BookmarkStart.b("䔵嘷嬹䰻ጽ㐿ⵁ楃⩅⥇㍉⍋㭍⑏网㍓⑕ㅗ㹙", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("帵䄷䨹吻嬽⸿⍁ぃ⽅❇⑉態≍ㅏ㙑こ㍕⩗睙㽛ㅝᕟౡၣ", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("䈵夷堹ᄻ䴽㐿ⵁ㑃歅ⱇ⍉㽋㩍ㅏ㱑㝓㍕", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("䔵倷嬹堻儽㜿", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䄵儷帹医䤽㌿", num), 20);
                    dictionary1.Add(BookmarkStart.b("夵䨷䨹吻弽⸿ㅁ", num), 0x15);
                    Class1160.dictionary_27 = dictionary1;
                }
                if (Class1160.dictionary_27.TryGetValue(str3, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                            if (class2.method_3() != BookmarkStart.b("圵䴷丹医", num))
                            {
                                A_1.method_44(class2.method_3());
                            }
                            break;

                        case 1:
                            str = class2.method_3();
                            break;

                        case 2:
                            A_1.method_42(class2.method_4());
                            break;

                        case 3:
                            if (class2.method_3() == BookmarkStart.b("䈵䨷伹夻", num))
                            {
                                A_2.SuppressLineNumbers = false;
                            }
                            break;

                        case 4:
                            if (!Class567.smethod_16(A_1.method_6()))
                            {
                                A_1.method_7(Class576.smethod_87(class2.method_3()));
                            }
                            break;

                        case 5:
                            str2 = class2.method_3();
                            break;

                        case 6:
                            goto Label_0340;

                        case 7:
                            A_2.FirstLineIndent = ((float) Class576.smethod_36(class2.method_3())) / 20f;
                            break;

                        case 8:
                            if (class2.method_3() != BookmarkStart.b("堵圷䠹儻弽ⰿ", num))
                            {
                                A_2.LineSpacing = ((float) Class576.smethod_52(class2.method_3())) / 20f;
                                A_2.LineSpacingRule = class2.method_3().EndsWith(BookmarkStart.b("ጵ", num)) ? LineSpacingRule.Multiple : LineSpacingRule.Exactly;
                            }
                            break;

                        case 9:
                            A_2.LineSpacingRule = LineSpacingRule.AtLeast;
                            A_2.LineSpacing = ((float) Class576.smethod_36(class2.method_3())) / 20f;
                            break;

                        case 10:
                            if (class2.method_3() == BookmarkStart.b("圵吷䴹崻䜽㌿", num))
                            {
                                A_2.SetAttr(0x410, true);
                            }
                            break;

                        case 11:
                            if (class2.method_3() == BookmarkStart.b("圵吷䴹崻䜽㌿", num))
                            {
                                A_2.SetAttr(0x41a, true);
                            }
                            break;

                        case 12:
                            if (class2.method_3() != BookmarkStart.b("䈵䨷嬹刻䴽〿⍁㙃⍅♇㹉", num))
                            {
                                A_2.SetAttr(0x5b4, Class576.smethod_62(class2.method_3(), (Class16) A_2.method_31(0x5b4)));
                                A_1.method_15().SetAttr(0x5b4, Class576.smethod_62(class2.method_3(), (Class16) A_2.method_31(0x5b4)));
                            }
                            break;

                        case 13:
                            A_2.SetAttr(0x4d8, class2.method_3() == BookmarkStart.b("張尷弹医夽㈿⍁㑃⹅敇⭉⁋㹍㡏㍑", num));
                            break;

                        case 14:
                            if (class2.method_3() == BookmarkStart.b("䔵儷圹䰻刽┿", num))
                            {
                                A_2.SetAttr(0x442, false);
                            }
                            break;

                        case 15:
                        {
                            BaselineAlignment alignment = Class922.smethod_43(class2.method_3());
                            if (alignment != BaselineAlignment.Baseline)
                            {
                                A_2.SetAttr(0x5e6, alignment);
                            }
                            break;
                        }
                        case 0x10:
                            if (class2.method_3() == BookmarkStart.b("䈵䨷伹夻", num))
                            {
                                A_2.SetAttr(0x4ec, true);
                            }
                            break;

                        case 0x11:
                            if (class2.method_3() == BookmarkStart.b("堵圷᜹倻圽ⴿ⭁ぃ", num))
                            {
                                A_2.SetAttr(0x582, true);
                            }
                            break;

                        case 0x12:
                            if (A_1.method_0() == null)
                            {
                                A_0.method_9().Settings.float_0 = Class576.smethod_36(class2.method_3());
                            }
                            break;

                        case 0x13:
                            flag = Class576.smethod_90(class2.method_3());
                            break;

                        case 20:
                            num2 = class2.method_4();
                            break;

                        case 0x15:
                            num3 = class2.method_4();
                            break;
                    }
                }
            }
            continue;
        Label_0340:
            flag2 = class2.method_3() == BookmarkStart.b("䐵吷᜹䠻尽", num);
            if ((class2.method_3() == BookmarkStart.b("䐵吷᜹䠻尽", num)) || (class2.method_3() == BookmarkStart.b("䐵吷", num)))
            {
                A_2.SetAttr(0x618, true);
            }
            if ((class2.method_3() == BookmarkStart.b("娵䨷᜹䠻尽", num)) || (class2.method_3() == BookmarkStart.b("娵䨷", num)))
            {
                A_2.SetAttr(0x618, false);
            }
        }
        if (str2 != null)
        {
            A_2.HorizontalAlignment = Class922.smethod_65(str2, flag2);
        }
        bool flag3 = (num2 == 2) && (num3 == 2);
        if ((A_1.method_0() != null) && (A_1.method_0() != BookmarkStart.b("攵䰷嬹刻娽ℿぁ⁃", num)))
        {
            if (flag3)
            {
                A_2.SetAttr(0x5be, true);
            }
            else if (!flag3)
            {
                A_2.SetAttr(0x5be, false);
            }
        }
        else if ((num2 >= 2) && (num3 >= 2))
        {
            if (flag3)
            {
                A_0.method_9().Settings.bool_67 = true;
            }
        }
        else
        {
            A_0.method_9().Settings.bool_67 = false;
        }
        if (str == BookmarkStart.b("尵䴷䤹䠻圽☿㭁", num))
        {
            A_2.SetAttr(0x3fc, HorizontalAlignment.Distribute);
        }
        smethod_2(A_2, A_1, flag);
    }

    private static void smethod_2(ParagraphFormat A_0, Class97 A_1, bool A_2)
    {
        Class852 class2 = A_1.method_37();
        Class412 class3 = A_1.method_39();
        Class572 class4 = A_1.method_35();
        if ((class2.method_0() != null) || (class3.method_0() != 0.0))
        {
            Class1031 class7 = smethod_4(class2.method_0(), class3.method_0(), A_2);
            smethod_3(A_0.Borders.Top, class7);
        }
        if (class4.method_2().method_4())
        {
            A_0.SetAttr(0x4b0, (float) class4.method_2().method_0());
        }
        if ((class2.method_2() != null) || (class3.method_2() != 0.0))
        {
            Class1031 class6 = smethod_4(class2.method_2(), class3.method_2(), A_2);
            smethod_3(A_0.Borders.Bottom, class6);
        }
        if (class4.method_2().method_6())
        {
            A_0.SetAttr(0x4c4, (float) class4.method_2().method_2());
        }
        if ((class2.method_4() != null) || (class3.method_4() != 0.0))
        {
            Class1031 class8 = smethod_4(class2.method_4(), class3.method_4(), A_2);
            smethod_3(A_0.Borders.Left, class8);
        }
        if (class4.method_0().method_4())
        {
            A_0.SetAttr(0x488, (float) class4.method_0().method_0());
        }
        if ((class2.method_6() != null) || (class3.method_6() != 0.0))
        {
            Class1031 class5 = smethod_4(class2.method_6(), class3.method_6(), A_2);
            smethod_3(A_0.Borders.Right, class5);
        }
        if (class4.method_0().method_6())
        {
            A_0.SetAttr(0x47e, (float) class4.method_0().method_2());
        }
    }

    internal static void smethod_3(Border A_0, Class1031 A_1)
    {
        A_0.BorderType = A_1.method_1();
        A_0.LineWidth = (float) A_1.method_3();
        A_0.Space = (float) A_1.method_14();
        A_0.Color = A_1.method_10();
        A_0.Shadow = A_1.method_16();
        A_0.ShadeTheme = A_1.method_22();
        A_0.IsChanged = true;
    }

    private static Class1031 smethod_4(Class472 A_0, double A_1, bool A_2)
    {
        Class1031 class2 = Class472.smethod_1(A_0, A_1, 0);
        class2.method_17(A_2);
        return class2;
    }

    private static void smethod_5(Class857 A_0, Class97 A_1, ParagraphFormat A_2)
    {
        int num = 8;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("席儯䀱唳儵䨷嬹䰻嘽洿㉁㙃⥅㡇⽉㹋㩍㥏㝑❓", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("娭儯倱ᤳ䔵䰷唹䰻䴽", num))
                {
                    if (!(str == BookmarkStart.b("䨭䈯崱䐳ᬵ嬷嬹䰻", num)))
                    {
                        if (!(str == BookmarkStart.b("䰭儯儱弳儵䨷唹䤻倽␿潁ⵃ⭅⥇ⵉ⥋", num)))
                        {
                            goto Label_0088;
                        }
                        smethod_9(A_0, A_1);
                    }
                    else
                    {
                        smethod_8(A_0, A_2, A_1);
                    }
                }
                else
                {
                    A_2.SetAttr(0x474, smethod_6(A_0, A_1.method_35().method_0().method_0()));
                }
                continue;
            }
        Label_0088:
            class2.vmethod_1();
        }
    }

    private static TabCollection smethod_6(Class857 A_0, double A_1)
    {
        int num = 11;
        TabCollection tabs = new TabCollection(A_0.method_9());
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䔰刲圴ᨶ䨸伺刼伾㉀", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䔰刲圴ᨶ䨸伺刼伾", num)))
            {
                tabs.method_6(smethod_7(A_0, A_1));
            }
            else
            {
                class2.vmethod_1();
            }
        }
        return tabs;
    }

    private static Tab smethod_7(Class857 A_0, double A_1)
    {
        int num = 0x13;
        Tab tab = new Tab(A_0.method_9());
        Class396 class2 = A_0.method_11();
        string str = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";
        while (class2.method_19())
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_28 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("䴸䈺䴼娾", num), 0);
                    dictionary1.Add(BookmarkStart.b("唸帺尼嬾⑀ㅂ桄㑆㵈㉊⅌⩎", num), 1);
                    dictionary1.Add(BookmarkStart.b("唸帺尼嬾⑀ㅂ桄㍆ⱈ㍊㥌", num), 2);
                    dictionary1.Add(BookmarkStart.b("娸区尼䴾", num), 3);
                    dictionary1.Add(BookmarkStart.b("䤸吺丼嘾㕀⩂⩄⥆", num), 4);
                    dictionary1.Add(BookmarkStart.b("唸帺尼嬾⑀ㅂ桄㍆え㭊⡌", num), 5);
                    dictionary1.Add(BookmarkStart.b("唸帺尼嬾⑀ㅂ桄㍆ⱈ㍊㥌扎≐❒ⱔ㭖㱘", num), 6);
                    dictionary1.Add(BookmarkStart.b("唸帺尼嬾⑀ㅂ桄う⁈⽊㥌❎", num), 7);
                    dictionary1.Add(BookmarkStart.b("唸帺尼嬾⑀ㅂ桄⑆♈❊≌㵎", num), 8);
                    Class1160.dictionary_28 = dictionary1;
                }
                if (Class1160.dictionary_28.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            str3 = class2.method_3();
                            break;

                        case 1:
                            str = class2.method_3();
                            break;

                        case 2:
                            str2 = class2.method_3();
                            break;

                        case 3:
                            str4 = class2.method_3();
                            break;

                        case 4:
                            tab.Position = ((float) Class576.smethod_41(class2.method_3())) + ((float) A_1);
                            break;
                    }
                }
            }
        }
        if (Class567.smethod_16(str) || Class567.smethod_16(str2))
        {
            tab.TabLeader = Class922.smethod_62(str, str2);
        }
        tab.Justification = Class922.smethod_61(str3, str4);
        return tab;
    }

    private static void smethod_8(Class857 A_0, ParagraphFormat A_1, Class97 A_2)
    {
        int num = 6;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䀫䜭帯圱䜳", num))
                {
                    if (str != BookmarkStart.b("䠫䜭䌯䘱唳堵嬷弹", num))
                    {
                        if (!(str == BookmarkStart.b("䀫䬭帯唱䀳帵", num)))
                        {
                            if (str == BookmarkStart.b("弫娭䤯帱儳ᬵ嘷嬹儻嬽", num))
                            {
                            }
                        }
                        else if (class2.method_3() == BookmarkStart.b("嬫䄭䈯嘱", num))
                        {
                            A_2.method_24(true);
                        }
                        else
                        {
                            A_2.method_22(class2.method_4());
                        }
                    }
                    else
                    {
                        A_1.SetAttr(0x5dc, Class576.smethod_36(class2.method_3()));
                    }
                }
                else
                {
                    A_1.DropCapLinesToDrop = class2.method_4();
                }
            }
        }
    }

    private static void smethod_9(Class857 A_0, Class97 A_1)
    {
    }
}

