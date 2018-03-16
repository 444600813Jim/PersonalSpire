using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class921
{
    private Class921()
    {
    }

    internal static void smethod_0(Class857 A_0, bool A_1)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        string str = class2.method_1();
        Class93 class3 = smethod_1(class2.method_12(BookmarkStart.b("䰩䴫䌭夯帱䴳", 4), null));
        smethod_2(A_0, class3);
        while (class2.method_9(str))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_185 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                    dictionary1.Add(BookmarkStart.b("帩䤫嘭䐯ἱ䐳䐵圷䨹夻䰽㐿⭁⅃㕅", num), 0);
                    dictionary1.Add(BookmarkStart.b("娩䴫尭儯唱䘳圵䠷刹ᄻ丽㈿ⵁ㑃⍅㩇㹉╋⭍⍏", num), 1);
                    dictionary1.Add(BookmarkStart.b("天䤫䴭䐯嬱嬳堵ᔷ䨹主儽〿❁㙃㉅ⅇ⽉㽋", num), 2);
                    dictionary1.Add(BookmarkStart.b("帩䴫䰭尯圱ᤳ䘵䨷唹䰻嬽㈿㙁ⵃ⍅㭇", num), 3);
                    dictionary1.Add(BookmarkStart.b("帩䴫䰭尯圱ᤳ唵圷嘹䤻匽⸿潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num), 4);
                    dictionary1.Add(BookmarkStart.b("帩䴫䰭尯圱ᤳ䐵圷䴹ᄻ丽㈿ⵁ㑃⍅㩇㹉╋⭍⍏", num), 5);
                    dictionary1.Add(BookmarkStart.b("帩䴫䰭尯圱ᤳ唵崷嘹倻ጽ〿ぁ⭃㙅ⵇ㡉㡋❍㕏⅑", num), 6);
                    dictionary1.Add(BookmarkStart.b("䴩師伭䀯娱崳唵ᔷ䨹主儽〿❁㙃㉅ⅇ⽉㽋", num), 7);
                    dictionary1.Add(BookmarkStart.b("堩夫䰭䤯ἱ䐳䐵圷䨹夻䰽㐿⭁⅃㕅", num), 8);
                    dictionary1.Add(BookmarkStart.b("丩師伭䜯嬱娳儵ᔷ䨹崻夽┿潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num), 9);
                    dictionary1.Add(BookmarkStart.b("䤩䐫伭䈯䘱ᤳ䘵䨷唹䰻嬽㈿㙁ⵃ⍅㭇", num), 10);
                    Class1160.dictionary_185 = dictionary1;
                }
                if (Class1160.dictionary_185.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            goto Label_0175;

                        case 1:
                        {
                            if (class3 is Class97)
                            {
                                Class413.smethod_0(A_0, (Class97) class3);
                            }
                            continue;
                        }
                        case 2:
                        {
                            if (class3 is Class95)
                            {
                                Class242.smethod_0(A_0, (Class95) class3);
                            }
                            continue;
                        }
                        case 3:
                        {
                            if (class3 is Class106)
                            {
                                Class853.smethod_0(A_0, (Class106) class3);
                            }
                            continue;
                        }
                        case 4:
                        {
                            if (class3 is Class94)
                            {
                                Class853.smethod_5(A_0, (Class94) class3);
                            }
                            continue;
                        }
                        case 5:
                        {
                            if (class3 is Class103)
                            {
                                Class853.smethod_1(A_0, (Class103) class3);
                            }
                            continue;
                        }
                        case 6:
                        {
                            if (class3 is Class100)
                            {
                                Class853.smethod_2(A_0, (Class100) class3);
                            }
                            continue;
                        }
                        case 7:
                        {
                            if (class3 is Class98)
                            {
                                Class794.smethod_0(A_0, (Class98) class3);
                            }
                            continue;
                        }
                        case 8:
                        {
                            if (class3 is Class105)
                            {
                                Class1095.smethod_0(A_0, (Class105) class3);
                            }
                            continue;
                        }
                        case 9:
                        {
                            if (class3 is Class104)
                            {
                                Class529.smethod_0(A_0, (Class104) class3);
                            }
                            continue;
                        }
                        case 10:
                        {
                            if (class3 is Class99)
                            {
                                Class648.smethod_0(A_0, (Class99) class3);
                            }
                            continue;
                        }
                    }
                }
            }
            goto Label_02BD;
        Label_0175:
            if (class3 is Class96)
            {
                Class96 class4 = (Class96) class3;
                CharacterFormat format = Class1141.smethod_0(A_0, (Class96) class3);
                if (format.Count > 0)
                {
                    class4.method_14(format);
                }
                if (class3.method_8() != null)
                {
                    format.CharStyleName = class3.method_8();
                }
            }
            continue;
        Label_02BD:
            class2.vmethod_1();
        }
        A_0.method_13().method_1(class3, A_0.method_20(), A_1);
    }

    private static Class93 smethod_1(string A_0)
    {
        int num = 2;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_186 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                dictionary1.Add(BookmarkStart.b("尧伩含娭", num), 0);
                dictionary1.Add(BookmarkStart.b("堧䬩師伭圯䀱唳䘵倷", num), 1);
                dictionary1.Add(BookmarkStart.b("嬧伩伫娭夯崱娳", num), 2);
                dictionary1.Add(BookmarkStart.b("娧弩丫圭", num), 3);
                dictionary1.Add(BookmarkStart.b("尧䬩丫䈭唯", num), 4);
                dictionary1.Add(BookmarkStart.b("尧䬩丫䈭唯ἱ圳夵吷伹儻倽", num), 5);
                dictionary1.Add(BookmarkStart.b("尧䬩丫䈭唯ἱ䘳夵伷", num), 6);
                dictionary1.Add(BookmarkStart.b("尧䬩丫䈭唯ἱ圳匵吷嘹", num), 7);
                dictionary1.Add(BookmarkStart.b("伧堩䴫席堯嬱圳", num), 8);
                dictionary1.Add(BookmarkStart.b("堧堩䤫崭唯就䀳圵䰷匹医倽", num), 9);
                dictionary1.Add(BookmarkStart.b("䰧堩䴫夭夯就匳ᬵ䠷嬹嬻嬽", num), 10);
                dictionary1.Add(BookmarkStart.b("䬧䈩䴫尭䐯", num), 11);
                Class1160.dictionary_186 = dictionary1;
            }
            if (Class1160.dictionary_186.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return new Class96();

                    case 1:
                        return new Class97();

                    case 2:
                        return new Class95();

                    case 3:
                        return new Class105();

                    case 4:
                        return new Class106();

                    case 5:
                        return new Class94();

                    case 6:
                        return new Class103();

                    case 7:
                        return new Class100();

                    case 8:
                        return new Class98();

                    case 9:
                        return new Class98();

                    case 10:
                        return new Class104();

                    case 11:
                        return new Class99();
                }
            }
        }
        throw new InvalidOperationException(string.Format(BookmarkStart.b("紧䐩䜫䀭弯䔱娳ᘵ䬷丹䔻刽┿扁≃❅╇⍉⁋㝍灏畑⽓晕╗絙牛", num), A_0));
    }

    private static void smethod_2(Class857 A_0, Class93 A_1)
    {
        int num = 6;
        Class396 class2 = A_0.method_11();
        class2.method_18();
        while (class2.method_19())
        {
            string str;
            if (!Class857.smethod_8(class2, A_1) && ((str = class2.method_1()) != null))
            {
                if (str != BookmarkStart.b("䨫伭崯嬱堳伵", num))
                {
                    if (str != BookmarkStart.b("䄫伭䌯䘱儳䐵ᔷ䨹崻夽┿潁⩃❅╇⽉", num))
                    {
                        if (str != BookmarkStart.b("䠫䬭嘯匱䄳娵䰷᜹医䬽㐿⹁ⵃ⡅ⵇ杉⁋⭍♏㝑㡓", num))
                        {
                            if (!(str == BookmarkStart.b("尫伭䈯圱娳䈵ᔷ䤹䠻䜽ⰿ❁楃⡅⥇❉⥋", num)))
                            {
                                if (str == BookmarkStart.b("䀫䜭䌯䘱ᤳ䔵䰷䌹倻嬽洿ⱁ╃⭅ⵇ", num))
                                {
                                    A_1.method_11(Class576.smethod_87(class2.method_3()));
                                }
                            }
                            else
                            {
                                A_1.method_9(Class576.smethod_87(class2.method_3()));
                            }
                        }
                        else if ((A_1 is Class97) && Class567.smethod_16(class2.method_3()))
                        {
                            ((Class97) A_1).method_26(class2.method_4() - 1);
                        }
                    }
                    else
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
}

