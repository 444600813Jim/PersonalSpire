using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class684
{
    private static Dictionary<string, DocPicture> dictionary_0 = new Dictionary<string, DocPicture>();

    private Class684()
    {
    }

    internal static void smethod_0(Class582 A_0)
    {
        int num = 0x11;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("嬶倸䠺䤼䰾", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("嬶倸䠺䤼漾⡀⁂݄㉆╈❊⡌㭎", num))
                {
                    if (!(str == BookmarkStart.b("嬶倸䠺䤼笾⑀╂", num)))
                    {
                        if (!(str == BookmarkStart.b("嬶倸䠺䤼", num)))
                        {
                            goto Label_006A;
                        }
                        smethod_8(A_0);
                    }
                    else
                    {
                        smethod_2(A_0);
                    }
                }
                else
                {
                    smethod_1(A_0);
                }
                continue;
            }
        Label_006A:
            class2.vmethod_1();
        }
        dictionary_0.Clear();
    }

    private static void smethod_1(Class582 A_0)
    {
        int num = 0x12;
        Class394 class2 = A_0.imethod_1();
        int num2 = class2.method_13(BookmarkStart.b("吷匹伻䨽ဿ⭁❃х㵇♉⁋⭍⑏᭑こ", 0x12), 0);
        while (class2.method_9(BookmarkStart.b("吷匹伻䨽ဿ⭁❃х㵇♉⁋⭍⑏", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䠷匹弻䨽", num)))
            {
                ShapeObject obj2 = Class964.smethod_4(A_0) as ShapeObject;
                if (obj2 != null)
                {
                    DocPicture imageData = obj2.ImageData;
                    num2.ToString();
                    dictionary_0.Add(num2.ToString(), imageData);
                }
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static string smethod_10(string A_0)
    {
        int num = 7;
        for (int i = 0; i < 10; i++)
        {
            A_0 = A_0.Replace(BookmarkStart.b("ࠬ", num) + (i + 1), ((char) i).ToString());
        }
        return A_0;
    }

    internal static void smethod_11(Class582 A_0)
    {
        foreach (KeyValuePair<ListStyle, string> pair2 in A_0.method_33())
        {
            ListStyle key = pair2.Key;
            string str2 = pair2.Value;
            key.ListStyleIstd = A_0.Interface58.imethod_0(str2, 12);
        }
        foreach (KeyValuePair<ListLevel, string> pair in A_0.method_34())
        {
            ListLevel level = pair.Key;
            string str = pair.Value;
            level.int_10 = A_0.Interface58.imethod_0(str, 0xfff);
        }
    }

    private static void smethod_2(Class582 A_0)
    {
        int num = 2;
        Class394 class2 = A_0.imethod_1();
        int num2 = 0;
        bool flag = false;
        int num3 = 0;
        ListLevelsType hybridMultiLevel = ListLevelsType.HybridMultiLevel;
        int num4 = 0;
        string str = null;
        string str2 = null;
        string str3 = string.Empty;
        ListStyle listStyle = null;
        while (class2.method_19())
        {
            string str4;
            if (((str4 = class2.method_1()) != null) && (str4 == BookmarkStart.b("䐧䌩弫娭琯圱刳缵尷", num)))
            {
                num2 = class2.method_4();
            }
        }
        int num5 = 0;
        while (class2.method_9(BookmarkStart.b("䐧䌩弫娭琯圱刳", num)))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num6;
                if (Class1160.dictionary_120 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("䐧天䔫䨭", num), 0);
                    dictionary1.Add(BookmarkStart.b("堧䘩堫", num), 1);
                    dictionary1.Add(BookmarkStart.b("尧䜩尫䈭", num), 2);
                    dictionary1.Add(BookmarkStart.b("䘧䬩䄫䬭", num), 3);
                    dictionary1.Add(BookmarkStart.b("嬧帩唫䈭唯縱崳堵匷", num), 4);
                    dictionary1.Add(BookmarkStart.b("䐧䌩弫娭振䘱䴳娵崷瘹唻倽⬿", num), 5);
                    dictionary1.Add(BookmarkStart.b("䐧尩䀫", num), 6);
                    Class1160.dictionary_120 = dictionary1;
                }
                if (Class1160.dictionary_120.TryGetValue(key, out num6))
                {
                    switch (num6)
                    {
                        case 0:
                            flag = true;
                            num3 = Class114.smethod_9(class2.method_28());
                            break;

                        case 1:
                            hybridMultiLevel = Class463.smethod_4(class2.method_28());
                            break;

                        case 2:
                            num4 = Class114.smethod_9(class2.method_28());
                            break;

                        case 3:
                            str = class2.method_28();
                            break;

                        case 4:
                            str3 = str2 = class2.method_28();
                            break;

                        case 5:
                            str2 = class2.method_28();
                            break;

                        case 6:
                            goto Label_01A6;
                    }
                }
            }
            continue;
        Label_01A6:
            if (listStyle == null)
            {
                listStyle = new ListStyle(A_0.Interface50.imethod_0(), num3, hybridMultiLevel, num4);
            }
            ListLevel level = new ListLevel(listStyle);
            listStyle.Levels.method_5(level);
            int num7 = class2.method_13(BookmarkStart.b("䄧䘩娫䈭", num), 0);
            if ((num7 == -1) && (num5 > 0))
            {
                listStyle.Levels[0].PatternType = ListPatternType.None;
                listStyle.Levels[0].LevelText = string.Empty;
                listStyle.Levels[0].ParagraphFormat.ClearFormatting();
                A_0.imethod_1().vmethod_1();
            }
            else
            {
                if (num7 == -1)
                {
                    num7 = 0;
                }
                smethod_6(listStyle.Levels[num7], A_0, num5);
            }
            num5++;
        }
        if (listStyle == null)
        {
            listStyle = new ListStyle(A_0.Interface50.imethod_0(), num3, hybridMultiLevel, num4);
            if (!string.IsNullOrEmpty(str))
            {
                listStyle.Name = str;
            }
            if (!string.IsNullOrEmpty(str2))
            {
                listStyle.BaseListStyleName = str2;
            }
            if (!string.IsNullOrEmpty(str3))
            {
                listStyle.StyleLink = str3;
            }
        }
        else
        {
            bool flag2 = smethod_5(listStyle);
            listStyle.Name = flag2 ? (BookmarkStart.b("樧弩䀫䈭唯䘱儳刵朷", num) + Guid.NewGuid().ToString()) : (BookmarkStart.b("昧弩䄫䰭唯䀱儳刵朷", num) + Guid.NewGuid().ToString());
            listStyle.ListType = flag2 ? ListType.Bulleted : ListType.Numbered;
            if (!string.IsNullOrEmpty(str2))
            {
                listStyle.BaseListStyleName = str2;
            }
            if (!string.IsNullOrEmpty(str3))
            {
                listStyle.StyleLink = str3;
            }
        }
        if (!flag)
        {
            listStyle.method_23(num2);
        }
        if (str2 != null)
        {
            A_0.method_33()[listStyle] = str2;
        }
        A_0.Interface50.imethod_0().ListStyles.Add(listStyle);
        smethod_3(listStyle);
        smethod_4(listStyle);
        A_0.method_19()[num2] = listStyle.Name;
    }

    private static void smethod_3(ListStyle A_0)
    {
        if (A_0.Levels != null)
        {
            A_0.ListType = ListType.Bulleted;
            using (IEnumerator enumerator = A_0.Levels.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ListLevel current = (ListLevel) enumerator.Current;
                    if (current.PatternType != ListPatternType.Bullet)
                    {
                        goto Label_0040;
                    }
                }
                return;
            Label_0040:
                A_0.ListType = ListType.Numbered;
            }
        }
    }

    private static void smethod_4(ListStyle A_0)
    {
        int num = 5;
        if (A_0.ListType == ListType.Numbered)
        {
            A_0.Name = BookmarkStart.b("攪堬䈮匰嘲䜴制崸携", num) + Guid.NewGuid().ToString();
        }
        else
        {
            A_0.Name = BookmarkStart.b("椪堬䌮崰嘲䄴制崸携", num) + Guid.NewGuid().ToString();
        }
    }

    private static bool smethod_5(ListStyle A_0)
    {
        int num = 0;
        int count = A_0.Levels.Count;
        while (num < count)
        {
            if (A_0.Levels[num].PatternType != ListPatternType.Bullet)
            {
                return false;
            }
            num++;
        }
        return true;
    }

    private static void smethod_6(ListLevel A_0, Class582 A_1, int A_2)
    {
        int num = 3;
        Class394 class2 = A_1.imethod_1();
        while (class2.method_19())
        {
            string str3 = class2.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("崨嬪䄬䰮", num)))
                {
                    if (str3 == BookmarkStart.b("崨个䌬嬮倰䜲尴䄶尸", num))
                    {
                        class2.method_63();
                    }
                }
                else
                {
                    Class114.smethod_9(class2.method_3());
                }
            }
        }
        A_0.StartAt = 0;
        while (class2.method_9(BookmarkStart.b("䔨崪䄬", num)))
        {
            string str;
            string str4;
            string key = class2.method_1();
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_121 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                    dictionary1.Add(BookmarkStart.b("娨弪䰬崮䔰", num), 0);
                    dictionary1.Add(BookmarkStart.b("䜨䴪丬", num), 1);
                    dictionary1.Add(BookmarkStart.b("䔨崪䄬紮吰䀲䄴嘶䬸伺", num), 2);
                    dictionary1.Add(BookmarkStart.b("夨砪夬嘮崰嘲", num), 3);
                    dictionary1.Add(BookmarkStart.b("䀨堪愬䠮崰", num), 4);
                    dictionary1.Add(BookmarkStart.b("娨帪䬬䤮", num), 5);
                    dictionary1.Add(BookmarkStart.b("䔨崪䄬笮吰䬲䄴", num), 6);
                    dictionary1.Add(BookmarkStart.b("䔨崪䄬缮堰倲眴䈶唸场堼䬾ࡀ❂", num), 7);
                    dictionary1.Add(BookmarkStart.b("䔨个䨬丮到䨲", num), 8);
                    dictionary1.Add(BookmarkStart.b("䔨崪䄬攮到", num), 9);
                    dictionary1.Add(BookmarkStart.b("夨笪弬", num), 10);
                    dictionary1.Add(BookmarkStart.b("嬨笪弬", num), 11);
                    Class1160.dictionary_121 = dictionary1;
                }
                if (Class1160.dictionary_121.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                            A_0.StartAt = class2.method_29();
                            break;

                        case 1:
                            A_0.PatternType = (ListPatternType) class2.method_29();
                            break;

                        case 2:
                            if (class2.method_29() == 0)
                            {
                                A_0.NoRestartByHigher = true;
                            }
                            break;

                        case 3:
                            A_0.ParaStyleName = class2.method_28();
                            break;

                        case 4:
                            A_0.IsLegalStyleNumbering = class2.method_31();
                            break;

                        case 5:
                            A_0.FollowCharacter = Class463.smethod_2(class2.method_28());
                            break;

                        case 6:
                            goto Label_0314;

                        case 7:
                            A_0.PicBulletId = (short) class2.method_29();
                            A_0.PicBullet = dictionary_0[A_0.PicBulletId.ToString()];
                            break;

                        case 8:
                            goto Label_03BF;

                        case 9:
                            A_0.NumberAlignment = Class463.smethod_0(class2.method_28());
                            break;

                        case 10:
                            Class924.smethod_0(A_1, A_0.ParagraphFormat, A_0.CharacterFormat);
                            break;

                        case 11:
                            Class733.smethod_0(A_1, A_0.CharacterFormat);
                            break;
                    }
                }
            }
            continue;
        Label_0234:
            if ((str4 = class2.method_1()) != null)
            {
                if (!(str4 == BookmarkStart.b("弨䨪䄬", num)))
                {
                    if (str4 == BookmarkStart.b("䜨帪䄬䌮", num))
                    {
                    }
                }
                else if (A_0.PatternType == ListPatternType.Bullet)
                {
                    A_0.BulletCharacter = class2.method_3();
                }
                else
                {
                    string str5 = class2.method_3();
                    A_0.LevelText = str5;
                    string str6 = BookmarkStart.b("న", num) + ((A_0.LevelNumber + 1)).ToString();
                    int index = str5.IndexOf(str6);
                    if (index != -1)
                    {
                        A_0.NumberPrefix = class2.method_3().Substring(0, index);
                        A_0.NumberPrefix = smethod_7(A_0.NumberPrefix);
                        int startIndex = index + 2;
                        A_0.NumberSufix = str5.Substring(startIndex, str5.Length - startIndex);
                    }
                }
            }
        Label_0314:
            if (class2.method_19())
            {
                goto Label_0234;
            }
            continue;
        Label_0354:
            if ((str = class2.method_1()) != null)
            {
                if (str != BookmarkStart.b("䔨个䨬丮到䨲", num))
                {
                    if (!(str == BookmarkStart.b("䔨个䨬丮到䨲昴䜶堸堺堼", num)))
                    {
                        if (str == BookmarkStart.b("䔨个䨬丮到䨲簴夶崸帺匼䬾", num))
                        {
                            A_0.LegacyIndent = class2.method_4();
                        }
                    }
                    else
                    {
                        A_0.LegacySpace = class2.method_4();
                    }
                }
                else
                {
                    A_0.Word6Legacy = class2.method_63();
                }
            }
        Label_03BF:
            if (class2.method_19())
            {
                goto Label_0354;
            }
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

    private static void smethod_8(Class582 A_0)
    {
        int num = 7;
        Class394 class2 = A_0.imethod_1();
        int num2 = class2.method_13(BookmarkStart.b("䐬䌮地尲", 7), 0);
        while (class2.method_9(BookmarkStart.b("䄬䘮䈰䜲", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䐬䌮䈰䜲", num)))
                {
                    if (str == BookmarkStart.b("䄬央崰簲䌴制䬸䤺吼嬾⑀", num))
                    {
                        smethod_9(A_0, num2);
                    }
                }
                else
                {
                    int key = class2.method_29();
                    if (A_0.method_19().ContainsKey(key))
                    {
                        A_0.method_20().Add(num2.ToString(), A_0.method_19()[key].ToString());
                    }
                }
            }
        }
    }

    private static void smethod_9(Class582 A_0, int A_1)
    {
        int num = 12;
        Document document = A_0.Interface50.imethod_0();
        Class394 class2 = A_0.imethod_1();
        Class12 class3 = null;
        if (!A_0.method_21().ContainsKey(A_1))
        {
            class3 = new Class12(document, A_1 + 2) {
                Name = BookmarkStart.b("縱刳夵欷丹䔻刽┿ᵁ", num) + Guid.NewGuid()
            };
            A_0.method_21().Add(A_1, class3.Name);
            document.ListOverrides.method_34(class3);
            class3.method_25(A_0.method_20().Count);
        }
        else
        {
            class3 = document.ListOverrides.method_35((string) A_0.method_21()[A_1]);
        }
        int num3 = class2.method_13(BookmarkStart.b("嬱堳䀵吷", num), 0);
        OverrideLevelFormat format = new OverrideLevelFormat(document);
        class3.method_23().method_9(num3, format);
        format.OverrideStartAtValue = false;
        format.OverrideFormatting = false;
        for (int i = 0; class2.method_9(BookmarkStart.b("帱䈳娵眷䰹夻䰽㈿⭁⁃⍅", num)); i++)
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䄱䀳圵䨷丹猻䠽┿ぁ㙃⽅ⱇ⽉", num)))
                {
                    if (str == BookmarkStart.b("帱䈳娵", num))
                    {
                        format.OverrideFormatting = true;
                        smethod_6(format.OverrideListLevel, A_0, i);
                    }
                }
                else
                {
                    format.OverrideStartAtValue = true;
                    format.StartAt = class2.method_29();
                }
            }
        }
    }
}

