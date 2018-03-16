using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

internal class Class1081
{
    private Class1081()
    {
    }

    internal static void smethod_0(Class582 A_0)
    {
        int num = 9;
        Class115 class2 = new Class115();
        Hashtable hashtable = new Hashtable();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
        Class394 class3 = A_0.imethod_1();
        while (class3.method_9(BookmarkStart.b("尮䔰䨲头制䨸", num)))
        {
            string str = class3.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("央吰䄲䘴帶嘸唺爼夾̀㙂ⱄ⭆㵈Ɋ⍌ᱎ═⩒㥔㉖㝘㩚ぜ㩞በ", num))
                {
                    if (!(str == BookmarkStart.b("䌮倰䜲倴夶䴸栺䤼䘾ⵀ♂㙄", num)))
                    {
                        if (!(str == BookmarkStart.b("尮䔰䨲头制", num)))
                        {
                            goto Label_0086;
                        }
                        smethod_3(A_0, class2, hashtable, dictionary, dictionary2);
                    }
                    else
                    {
                        smethod_1(A_0);
                    }
                }
                continue;
            }
        Label_0086:
            class3.vmethod_1();
        }
        class2.method_0(A_0);
        smethod_4(A_0.Interface50.imethod_0(), dictionary);
        smethod_5(A_0.Interface50.imethod_0(), dictionary2);
    }

    private static void smethod_1(Class582 A_0)
    {
        int num = 5;
        Class547 latentStyles = A_0.Interface50.imethod_0().Styles.LatentStyles;
        Class394 class3 = A_0.imethod_1();
        while (class3.method_19())
        {
            string str2 = class3.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("伪䠬䤮細尲嘴尶尸强渼䬾⁀㝂⁄", num)))
                {
                    if (str2 == BookmarkStart.b("䜪䰬嬮吰崲䄴搶䴸䈺儼娾ɀⱂい⥆㵈", num))
                    {
                        latentStyles.method_13(class3.method_4());
                    }
                }
                else
                {
                    latentStyles.method_3(class3.method_63());
                }
            }
        }
        while (class3.method_9(BookmarkStart.b("䜪䰬嬮吰崲䄴搶䴸䈺儼娾㉀", num)))
        {
            string str;
            if (((str = class3.method_1()) != null) && (str == BookmarkStart.b("䜪帬䬮琰䬲嘴制䤸伺吼倾⽀", num)))
            {
                smethod_2(A_0);
            }
        }
    }

    private static void smethod_2(Class582 A_0)
    {
        int num = 5;
        Class547 latentStyles = A_0.Interface50.imethod_0().Styles.LatentStyles;
        Class394 class3 = A_0.imethod_1();
        bool flag = latentStyles.method_2();
        string str = "";
        bool flag2 = latentStyles.method_4();
        bool flag3 = latentStyles.method_6();
        int num2 = latentStyles.method_8();
        bool flag4 = latentStyles.method_10();
        while (class3.method_19())
        {
            string str2 = class3.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("䜪䈬䰮娰嘲儴", num)))
                {
                    if (str2 == BookmarkStart.b("䔪䰬䈮吰", num))
                    {
                        str = class3.method_3();
                    }
                }
                else
                {
                    flag = class3.method_63();
                }
            }
        }
        StyleIdentifier identifier = Class417.smethod_25(str);
        if (identifier != StyleIdentifier.User)
        {
            latentStyles.method_14().method_1(new Class66(identifier, flag, flag2, flag3, num2, flag4));
        }
    }

    private static void smethod_3(Class582 A_0, ArrayList A_1, Hashtable A_2, Dictionary<string, string> A_3, Dictionary<string, string> A_4)
    {
        int num = 3;
        StyleCollection styles = A_0.Interface50.imethod_0().Styles;
        Class394 class2 = A_0.imethod_1();
        StyleType paragraphStyle = StyleType.ParagraphStyle;
        string str = null;
        bool flag = false;
        while (class2.method_19())
        {
            string str6 = class2.method_1();
            if (str6 != null)
            {
                if (str6 != BookmarkStart.b("崨刪崬䨮", num))
                {
                    if (!(str6 == BookmarkStart.b("䴨个䬬丮䐰弲䄴", num)))
                    {
                        if (str6 == BookmarkStart.b("娨弪听䌮吰稲儴", num))
                        {
                            str = class2.method_3();
                        }
                    }
                    else
                    {
                        flag = class2.method_63();
                    }
                }
                else
                {
                    paragraphStyle = Class911.smethod_8(class2.method_3());
                }
            }
        }
        if (paragraphStyle == StyleType.ListStyle)
        {
            MemoryStream stream = new MemoryStream();
            XmlWriter writer = Class57.smethod_19(stream, Encoding.UTF8);
            writer.WriteNode(class2.method_8(), false);
            writer.Flush();
        }
        else
        {
            Style style = Style.smethod_1(paragraphStyle, A_0.Interface50.imethod_0()) as Style;
            if (!string.IsNullOrEmpty(str))
            {
                style.method_5(str);
            }
            Class801 class3 = new Class801(style);
            string str3 = null;
            while (class2.method_9(BookmarkStart.b("娨弪听䌮吰", num)))
            {
                string str2;
                string str5;
                string str7;
                string key = class2.method_1();
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_223 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x10);
                        dictionary1.Add(BookmarkStart.b("䜨䨪䀬䨮", num), 0);
                        dictionary1.Add(BookmarkStart.b("䠨䜪䐬丮䈰嘲䘴", num), 1);
                        dictionary1.Add(BookmarkStart.b("䬨䨪帬䨮唰簲嬴", num), 2);
                        dictionary1.Add(BookmarkStart.b("䜨个唬嬮", num), 3);
                        dictionary1.Add(BookmarkStart.b("䔨䈪䌬䐮", num), 4);
                        dictionary1.Add(BookmarkStart.b("䠨帪夬䀮挰嘲儴制弸刺匼娾", num), 5);
                        dictionary1.Add(BookmarkStart.b("䄨䈪䤬䬮吰崲", num), 6);
                        dictionary1.Add(BookmarkStart.b("娨个䀬䘮礰娲儴匶尸唺", num), 7);
                        dictionary1.Add(BookmarkStart.b("䔨䐪丬䐮吰圲", num), 8);
                        dictionary1.Add(BookmarkStart.b("夨个弬尮帰崲吴嬶", num), 9);
                        dictionary1.Add(BookmarkStart.b("夨个弬尮帰崲吴嬶稸吺值伾⹀あ⁄", num), 10);
                        dictionary1.Add(BookmarkStart.b("夨个弬尮帰崲吴嬶欸帺䴼匾㡀", num), 11);
                        dictionary1.Add(BookmarkStart.b("嬨堪䐬䬮", num), 12);
                        dictionary1.Add(BookmarkStart.b("夨笪弬", num), 13);
                        dictionary1.Add(BookmarkStart.b("嬨笪弬", num), 14);
                        dictionary1.Add(BookmarkStart.b("尨䈪挬丮尰嘲", num), 15);
                        Class1160.dictionary_223 = dictionary1;
                    }
                    if (Class1160.dictionary_223.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                goto Label_02A7;

                            case 1:
                            {
                                str3 = class2.method_28();
                                continue;
                            }
                            case 2:
                            {
                                if (style.Name.ToLower() != BookmarkStart.b("䜨䐪弬䈮倰弲", num))
                                {
                                    str5 = class2.method_28();
                                    if (A_0.Interface50.imethod_0().StyleNameIds.ContainsKey(str5))
                                    {
                                        goto Label_0345;
                                    }
                                    A_3.Add(style.StyleId, str5);
                                }
                                continue;
                            }
                            case 3:
                            {
                                style.NextStyle = class2.method_28();
                                continue;
                            }
                            case 4:
                            {
                                str2 = class2.method_28();
                                if (!A_0.Interface50.imethod_0().StyleNameIds.ContainsKey(str2))
                                {
                                    goto Label_03EB;
                                }
                                style.LinkStyle = A_0.Interface50.imethod_0().StyleNameIds[str2];
                                continue;
                            }
                            case 5:
                            {
                                style.AutomaticallyUpdate = class2.method_31();
                                continue;
                            }
                            case 6:
                            {
                                style.Hidden = class2.method_31();
                                continue;
                            }
                            case 7:
                            {
                                style.IsSemiHidden = class2.method_31();
                                continue;
                            }
                            case 8:
                            {
                                style.Locked = class2.method_31();
                                continue;
                            }
                            case 9:
                            {
                                style.Personal = class2.method_31();
                                continue;
                            }
                            case 10:
                            {
                                style.PersonalCompose = class2.method_31();
                                continue;
                            }
                            case 11:
                            {
                                style.PersonalReply = class2.method_31();
                                continue;
                            }
                            case 12:
                            {
                                int num3 = Class114.smethod_7(class2.method_28());
                                if (num3 != -2147483648)
                                {
                                    style.Rsid = num3;
                                }
                                continue;
                            }
                            case 13:
                            {
                                Class924.smethod_0(A_0, style.ParaPr, style.CharacterFormat);
                                continue;
                            }
                            case 14:
                            {
                                Class733.smethod_0(A_0, style.CharacterFormat);
                                continue;
                            }
                            case 15:
                            {
                                continue;
                            }
                        }
                    }
                }
                goto Label_04DE;
            Label_02A7:
                str7 = class2.method_28();
                if (Class567.smethod_16(str7))
                {
                    Class1145.smethod_0(str7, styles, false, style);
                    if (!Class567.smethod_16(str))
                    {
                        str = str7;
                    }
                    A_0.Interface58.imethod_1(str, style.Istd);
                }
                continue;
            Label_0345:
                if (A_0.Interface50.imethod_0().Styles.FindByName(A_0.Interface50.imethod_0().StyleNameIds[str5]) == null)
                {
                    A_3.Add(style.StyleId, str5);
                }
                else
                {
                    style.ApplyBaseStyle(A_0.Interface50.imethod_0().StyleNameIds[str5]);
                }
                continue;
            Label_03EB:
                if (A_4.ContainsKey(style.StyleId))
                {
                    A_4[style.StyleId] = str2;
                }
                else
                {
                    A_4.Add(style.StyleId, str2);
                }
                continue;
            Label_04DE:
                smethod_6(A_0, style);
            }
            string[] strArray = null;
            if (str3 != null)
            {
                strArray = str3.Split(new char[] { ',' });
            }
            if (!string.IsNullOrEmpty(str) && !A_0.Interface50.imethod_0().StyleNameIds.ContainsKey(str))
            {
                A_0.Interface50.imethod_0().StyleNameIds.Add(str, style.Name);
            }
            if (Class567.smethod_16(style.Name))
            {
                if (styles.method_9(style.StyleId) == null)
                {
                    styles.method_7(style, strArray);
                    if (flag && (paragraphStyle == StyleType.ParagraphStyle))
                    {
                        styles.DefaultParaStyle = style as ParagraphStyle;
                    }
                }
                A_1.Add(class3);
            }
        }
    }

    private static void smethod_4(Document A_0, Dictionary<string, string> A_1)
    {
        if ((A_1 != null) && (A_1.Count != 0))
        {
            foreach (string str in A_1.Keys)
            {
                Style style = A_0.Styles.FindByName(str);
                if ((style != null) && A_0.StyleNameIds.ContainsKey(A_1[str]))
                {
                    style.ApplyBaseStyle(A_0.StyleNameIds[A_1[str]]);
                }
            }
        }
    }

    private static void smethod_5(Document A_0, Dictionary<string, string> A_1)
    {
        if ((A_1 != null) && (A_1.Count != 0))
        {
            foreach (string str in A_1.Keys)
            {
                Style style = A_0.Styles.method_9(str) as Style;
                string key = A_1[str];
                if (A_0.StyleNameIds.ContainsKey(key))
                {
                    style.LinkStyle = key;
                }
            }
        }
    }

    private static void smethod_6(Class582 A_0, Style A_1)
    {
        int num = 10;
        Class394 class2 = A_0.imethod_1();
        Class13 class3 = A_1 as Class13;
        if (class3 == null)
        {
            class2.vmethod_1();
        }
        else
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str == BookmarkStart.b("䐯倱堳昵䨷", num))
                {
                    Class829.smethod_0(class3.Interface8.imethod_3(), A_0, true);
                    return;
                }
                if (str == BookmarkStart.b("䐯䀱搳䐵", num))
                {
                    Class1131.smethod_0(class3.Interface8.imethod_2(), A_0);
                    return;
                }
                if (str == BookmarkStart.b("䐯儱搳䐵", num))
                {
                    Class419.smethod_0(A_0, class3.Interface8.imethod_1());
                    return;
                }
                if (str == BookmarkStart.b("䐯倱堳攵䰷䌹倻嬽ဿぁ", num))
                {
                    return;
                }
            }
            class2.vmethod_1();
        }
    }

    private static Class13 smethod_7(Class582 A_0)
    {
        int num = 2;
        Class394 class2 = A_0.imethod_1();
        Class13 class3 = new Class13(A_0.Interface50.imethod_0());
        while (class2.method_19())
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                bool flag1 = str2 == BookmarkStart.b("尧匩尫䬭", num);
            }
        }
        while (class2.method_9(BookmarkStart.b("尧䠩䀫紭䐯䬱堳匵样䠹", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("堧稩師", num))
                {
                    if (str != BookmarkStart.b("娧稩師", num))
                    {
                        if (str != BookmarkStart.b("尧䠩䀫縭䈯", num))
                        {
                            if (!(str == BookmarkStart.b("尧堩簫尭", num)))
                            {
                                if (str == BookmarkStart.b("尧䤩簫尭", num))
                                {
                                    Class419.smethod_0(A_0, class3.Interface8.imethod_1());
                                }
                            }
                            else
                            {
                                Class1131.smethod_0(class3.Interface8.imethod_2(), A_0);
                            }
                        }
                        else
                        {
                            Class829.smethod_0(class3.Interface8.imethod_3(), A_0, true);
                        }
                    }
                    else
                    {
                        Class733.smethod_0(A_0, class3.CharacterFormat);
                    }
                }
                else
                {
                    Class924.smethod_0(A_0, class3.imethod_0(), class3.CharacterFormat);
                }
            }
        }
        return class3;
    }
}

