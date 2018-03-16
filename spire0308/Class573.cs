using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class573
{
    private Class573()
    {
    }

    internal static void smethod_0(Class857 A_0, bool A_1)
    {
        Class101 class2 = new Class101();
        class2.method_22(new ListStyle(A_0.method_9()));
        smethod_2(A_0, class2);
        smethod_3(A_0, class2);
        for (int i = 0; i < 9; i++)
        {
            Class91 class3 = A_0.method_13().method_3((string) class2.method_23()[i], null, A_0.method_20());
            if ((class3 != null) && (class3 is Class96))
            {
                CharacterFormat format = (class3 as Class96).method_13();
                if ((format != null) && (format.Count > 0))
                {
                    format.method_37(class2.method_21().Levels[i].CharacterFormat);
                }
            }
        }
        A_0.method_13().method_1(class2, A_0.method_20(), A_1);
    }

    internal static void smethod_1(Class857 A_0)
    {
        int num = 1;
        Class101 class2 = new Class101();
        class2.method_22(new ListStyle(A_0.method_9()));
        class2.method_21().Name = BookmarkStart.b("栦䴨弪爬怮䐰䜲礴帶圸帺焼嘾㉀㝂ᙄ㍆え❊⡌", 1);
        A_0.method_66(class2);
        Class396 class3 = A_0.method_11();
        class3.method_18();
        while (class3.method_9(BookmarkStart.b("䠦尨弪䄬䘮弰嘲ᠴ䐶䴸䈺儼娾", num)))
        {
            string str;
            class3 = A_0.method_11();
            if (((str = class3.method_1()) != null) && (str == BookmarkStart.b("䠦尨弪䄬䘮弰嘲ᠴ嬶尸䴺堼匾汀あㅄ㹆╈⹊", num)))
            {
                ListStyle listStyle = class2.method_21();
                ListLevel level = new ListLevel(listStyle);
                listStyle.Levels.method_5(level);
                smethod_5(A_0, class2, level, BookmarkStart.b("䠦尨弪䄬䘮弰嘲ᠴ嬶尸䴺堼匾汀あㅄ㹆╈⹊", num));
            }
            else
            {
                class3.vmethod_1();
            }
        }
        A_0.method_13().method_1(class2, A_0.method_20(), false);
        A_0.method_9().ListStyles.Add(class2.method_21());
    }

    private static void smethod_2(Class857 A_0, Class101 A_1)
    {
        Class396 class2 = A_0.method_11();
        class2.method_18();
        while (class2.method_19())
        {
            Class857.smethod_8(class2, A_1);
        }
    }

    private static void smethod_3(Class857 A_0, Class101 A_1)
    {
        int num = 0;
        Class396 class2 = A_0.method_11();
        class2.method_18();
        A_1.method_22(new ListStyle(A_0.method_9()));
        while (class2.method_9(BookmarkStart.b("䨥䄧天堫̭䌯䘱䴳娵崷", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (((str == BookmarkStart.b("䨥䄧天堫̭尯圱䈳匵吷᜹伻䨽㤿⹁⅃歅♇㽉⅋ⱍ㕏⁑", num)) || (str == BookmarkStart.b("䨥䄧天堫̭尯圱䈳匵吷᜹伻䨽㤿⹁⅃歅⩇㽉⁋≍㕏♑", num))) || (str == BookmarkStart.b("䨥䄧天堫̭尯圱䈳匵吷᜹伻䨽㤿⹁⅃歅ⅇ❉ⵋ⥍㕏", num))))
            {
                smethod_4(A_0, A_1);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_4(Class857 A_0, Class101 A_1)
    {
        int num = 5;
        Class396 class2 = A_0.method_11();
        int num2 = Class1041.smethod_11(class2.method_12(BookmarkStart.b("䜪䠬央吰弲", 5), BookmarkStart.b("ᨪ", 5))) - 1;
        ListStyle listStyle = A_1.method_21();
        ListLevel level = new ListLevel(listStyle);
        listStyle.Levels.method_5(level);
        class2.method_18();
        if (ListLevel.smethod_0(num2))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䜪䐬尮䔰Ḳ头制伸帺儼ሾ㉀㝂㱄⭆ⱈ晊⍌㩎㱐ㅒご╖", num))
                {
                    if (!(str == BookmarkStart.b("䜪䐬尮䔰Ḳ头制伸帺儼ሾ㉀㝂㱄⭆ⱈ晊⽌㩎㵐㽒ご⍖", num)))
                    {
                        if (str == BookmarkStart.b("䜪䐬尮䔰Ḳ头制伸帺儼ሾ㉀㝂㱄⭆ⱈ晊⑌≎ぐ㑒ご", num))
                        {
                            smethod_9(A_0, A_1, level);
                        }
                    }
                    else
                    {
                        smethod_8(A_0, A_1, level);
                    }
                }
                else
                {
                    smethod_5(A_0, A_1, level, BookmarkStart.b("䜪䐬尮䔰Ḳ头制伸帺儼ሾ㉀㝂㱄⭆ⱈ晊⍌㩎㱐ㅒご╖", num));
                }
            }
            if (A_1.method_13() != null)
            {
                A_1.method_13().method_37(level.CharacterFormat);
            }
        }
    }

    private static void smethod_5(Class857 A_0, Class101 A_1, ListLevel A_2, string A_3)
    {
        int num = 14;
        Class396 class2 = A_0.method_11();
        A_2.PatternType = ListPatternType.None;
        string str = "";
        string str2 = "";
        int num2 = 0;
        int num3 = 1;
        int key = -1;
        while (class2.method_19())
        {
            string str3 = class2.method_1();
            if (str3 != null)
            {
                int num6;
                if (Class1160.dictionary_107 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("堳匵丷弹倻", num), 0);
                    dictionary1.Add(BookmarkStart.b("娳䌵唷᜹娻儽㈿⽁╃㉅", num), 1);
                    dictionary1.Add(BookmarkStart.b("倳張䬷䨹倻弽㤿潁⡃⍅㹇⽉⁋㵍", num), 2);
                    dictionary1.Add(BookmarkStart.b("䜳䈵䄷嘹夻ጽ⸿⍁⥃⍅", num), 3);
                    dictionary1.Add(BookmarkStart.b("䜳䈵夷䠹䠻ጽ㘿⍁⡃㍅ⵇ", num), 4);
                    dictionary1.Add(BookmarkStart.b("娳䌵唷᜹伻䬽☿⑁ⵃ㹅", num), 5);
                    dictionary1.Add(BookmarkStart.b("娳䌵唷᜹䰻䰽┿⑁ⵃ㹅", num), 6);
                    Class1160.dictionary_107 = dictionary1;
                }
                if (Class1160.dictionary_107.TryGetValue(str3, out num6))
                {
                    switch (num6)
                    {
                        case 0:
                            key = class2.method_4();
                            break;

                        case 1:
                            A_2.PatternType = Class922.smethod_57(class2.method_3());
                            break;

                        case 2:
                            num2 = class2.method_4();
                            break;

                        case 3:
                            A_1.method_23()[A_2.LevelNumber] = Class576.smethod_87(class2.method_3());
                            break;

                        case 4:
                            num3 = class2.method_4();
                            break;

                        case 5:
                            str = class2.method_3();
                            break;

                        case 6:
                            str2 = class2.method_3();
                            break;
                    }
                }
            }
        }
        A_2.StartAt = num3;
        int num5 = A_2.LevelNumber + 1;
        if (num2 != 0)
        {
            smethod_6(num2, A_2);
        }
        else
        {
            A_2.NumberPrefix = str2;
            A_2.NumberSufix = str;
            A_2.LevelText = str2 + BookmarkStart.b("ᄳ", num) + num5.ToString() + str;
        }
        bool flag = false;
        while (class2.method_9(A_3))
        {
            string str4 = class2.method_1();
            if (str4 != null)
            {
                if (!(str4 == BookmarkStart.b("堳張䬷丹ᄻ刽┿㑁⅃⩅敇㩉㹋⅍⁏㝑♓≕ㅗ㽙⽛", num)))
                {
                    if (!(str4 == BookmarkStart.b("䀳匵䀷丹ᄻ丽㈿ⵁ㑃⍅㩇㹉╋⭍⍏", num)))
                    {
                        goto Label_022E;
                    }
                    CharacterFormat format = Class1141.smethod_0(A_0, A_1);
                    if (format.Count > 0)
                    {
                        format.method_37(A_2.CharacterFormat);
                    }
                }
                else
                {
                    Class693.smethod_0(A_0, A_2);
                    flag = true;
                }
                continue;
            }
        Label_022E:
            class2.vmethod_1();
        }
        if (key != -1)
        {
            A_1.hashtable_0.Add(key, flag);
        }
    }

    private static void smethod_6(int A_0, ListLevel A_1)
    {
        int num2 = 5;
        A_1.NumberSufix = "";
        switch (A_0)
        {
            case 1:
                A_1.NumberPrefix = BookmarkStart.b("⬪", num2);
                A_1.LevelText = BookmarkStart.b("สᰬ", num2);
                return;

            case 2:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮ", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ", num2);
                return;

            case 3:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮᐰĲ᬴", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸ", num2);
                return;

            case 4:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺ", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା", num2);
                return;

            case 5:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄", num2);
                return;

            case 6:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆汈絊", num2);
                return;

            case 7:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆汈絊捌", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆汈絊捌橎晐", num2);
                return;

            case 8:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆汈絊捌橎晐絒", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆汈絊捌橎晐絒灔潖", num2);
                return;

            case 9:
                A_1.NumberPrefix = smethod_7(BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆汈絊捌橎晐絒灔潖睘", num2));
                A_1.LevelText = BookmarkStart.b("สᰬĮᐰĲ᬴ሶਸᔺᠼା潀時灄楆汈絊捌橎晐絒灔潖睘繚摜", num2);
                return;
        }
    }

    private static string smethod_7(string A_0)
    {
        int num = 0;
        if ((A_0 != null) && !(A_0 == string.Empty))
        {
            string str = A_0;
            return str.Replace(BookmarkStart.b("̥ᤧ", num), BookmarkStart.b("☥", num)).Replace(BookmarkStart.b("̥ᨧ", num), BookmarkStart.b("✥", num)).Replace(BookmarkStart.b("̥ᬧ", num), BookmarkStart.b("␥", num)).Replace(BookmarkStart.b("̥ᰧ", num), BookmarkStart.b("┥", num)).Replace(BookmarkStart.b("̥ᴧ", num), BookmarkStart.b("∥", num)).Replace(BookmarkStart.b("̥ḧ", num), BookmarkStart.b("⌥", num)).Replace(BookmarkStart.b("̥ἧ", num), BookmarkStart.b("‥", num)).Replace(BookmarkStart.b("̥ဧ", num), BookmarkStart.b("℥", num)).Replace(BookmarkStart.b("̥ᄧ", num), BookmarkStart.b("⸥", num));
        }
        return A_0;
    }

    private static void smethod_8(Class857 A_0, Class101 A_1, ListLevel A_2)
    {
        int num = 8;
        Class396 class2 = A_0.method_11();
        A_2.PatternType = ListPatternType.Bullet;
        string str = "";
        while (class2.method_19())
        {
            string str3 = class2.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("崭䐯䬱堳匵ᔷ吹崻匽┿", num)))
                {
                    if (str3 == BookmarkStart.b("䰭䔯帱堳匵䰷᜹弻嘽ℿぁ", num))
                    {
                        str = class2.method_3();
                    }
                }
                else
                {
                    A_1.method_23()[A_2.LevelNumber] = Class576.smethod_87(class2.method_3());
                }
            }
        }
        A_2.BulletCharacter = str;
        while (class2.method_9(BookmarkStart.b("䈭夯䄱䀳ᬵ吷弹䨻嬽ⰿ潁㝃㉅ㅇ♉⥋捍㉏❑㡓㩕㵗⹙", num)))
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("䈭夯䄱䀳ᬵ吷弹䨻嬽ⰿ潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num)))
                {
                    if (!(str2 == BookmarkStart.b("娭唯䨱䀳ᬵ䠷䠹医丽┿ぁぃ⽅ⵇ㥉", num)))
                    {
                        goto Label_00E1;
                    }
                    CharacterFormat format = Class1141.smethod_0(A_0, A_1);
                    if (format.Count > 0)
                    {
                        format.method_37(A_2.CharacterFormat);
                    }
                }
                else
                {
                    Class693.smethod_0(A_0, A_2);
                }
                continue;
            }
        Label_00E1:
            class2.vmethod_1();
        }
    }

    private static void smethod_9(Class857 A_0, Class101 A_1, ListLevel A_2)
    {
        int num = 5;
        Class396 class2 = A_0.method_11();
        A_2.PatternType = ListPatternType.Bullet;
        A_2.BulletCharacter = BookmarkStart.b("鳚", 5);
        ShapeObject obj2 = new ShapeObject(A_0.method_9(), ShapeType.Image);
        obj2.SetShapeAttribute(0x1001, TextWrappingStyle.Inline);
        Class798.smethod_1(A_0, obj2, BookmarkStart.b("䜪䐬尮䔰Ḳ头制伸帺儼ሾ㉀㝂㱄⭆ⱈ晊⑌≎ぐ㑒ご", 5));
        A_2.PicBullet = obj2.ImageData;
        while (class2.method_9(BookmarkStart.b("䜪䐬尮䔰Ḳ头制伸帺儼ሾ㉀㝂㱄⭆ⱈ晊⑌≎ぐ㑒ご", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䜪䐬尮䔰Ḳ头制伸帺儼ሾㅀㅂ⩄㝆ⱈ㥊㥌♎㑐⁒", num)))
            {
                Class693.smethod_0(A_0, A_2);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }
}

