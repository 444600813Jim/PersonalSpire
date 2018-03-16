using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class795
{
    private Class795()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 3;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("娨弪听䌮吰䀲", num)))
        {
            if (!smethod_3(A_0, false))
            {
                string key = class2.method_1();
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_144 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                        dictionary1.Add(BookmarkStart.b("䴨个䬬丮䐰弲䄴ᨶ䨸伺䐼匾⑀", num), 0);
                        dictionary1.Add(BookmarkStart.b("䜨䐪夬䨮䈰Ḳ嘴堶圸崺吼堾㑀ㅂ⑄㍆⁈⑊⍌", num), 1);
                        dictionary1.Add(BookmarkStart.b("䐨䨪弬䐮吰䄲", num), 2);
                        dictionary1.Add(BookmarkStart.b("娨弪弬䀮娰嘲ᠴ匶堸䠺唼", num), 3);
                        dictionary1.Add(BookmarkStart.b("丨太䰬䬮堰嘲嬴䌶", num), 4);
                        dictionary1.Add(BookmarkStart.b("䔨䈪䌬䨮弰䘲場唶尸䤺吼儾♀湂♄⡆❈ⵊ⑌⡎⑐⅒㑔⍖じ㑚㍜", num), 5);
                        Class1160.dictionary_144 = dictionary1;
                    }
                    if (Class1160.dictionary_144.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                            {
                                Class921.smethod_0(A_0, false);
                                continue;
                            }
                            case 1:
                            {
                                smethod_6(A_0);
                                continue;
                            }
                            case 2:
                            {
                                smethod_5(A_0);
                                continue;
                            }
                            case 3:
                            {
                                smethod_4(A_0);
                                continue;
                            }
                            case 4:
                            {
                                smethod_2(A_0);
                                continue;
                            }
                            case 5:
                            {
                                smethod_1(A_0);
                                continue;
                            }
                        }
                    }
                }
                class2.vmethod_1();
            }
        }
        A_0.method_6(true, false);
        smethod_8(A_0);
    }

    private static void smethod_1(Class857 A_0)
    {
        int num = 13;
        Class396 class2 = A_0.method_11();
        A_0.method_53(new Class1138());
        while (class2.method_19())
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_145 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("崲䀴娶嬸帺似ሾⵀ⩂⭄≆㩈", num), 0);
                    dictionary1.Add(BookmarkStart.b("䀲䄴丶唸帺ြ儾⁀⹂⁄", num), 1);
                    dictionary1.Add(BookmarkStart.b("娲嬴吶䬸帺值娾⽀㝂", num), 2);
                    dictionary1.Add(BookmarkStart.b("崲䀴娶嬸帺似ሾㅀⱂ㙄⹆㵈≊≌ⅎ", num), 3);
                    dictionary1.Add(BookmarkStart.b("尲匴儶䨸帺䤼", num), 4);
                    dictionary1.Add(BookmarkStart.b("倲娴䈶圸伺ြ娾ⱀ㍂ㅄ㹆摈❊⑌ⅎ㑐⁒", num), 5);
                    dictionary1.Add(BookmarkStart.b("倲娴䈶圸伺ြ嘾⽀湂ㅄ≆ㅈ㽊恌ⵎ㹐⭒ご⑖", num), 6);
                    dictionary1.Add(BookmarkStart.b("䄲倴䐶䴸娺似䬾汀ⱂ⭄橆㥈⩊⩌⩎", num), 7);
                    dictionary1.Add(BookmarkStart.b("崲䀴娶ᐸ崺刼䴾ⱀ≂ㅄ", num), 8);
                    dictionary1.Add(BookmarkStart.b("崲䀴娶ᐸ场堼䬾㕀♂㝄橆㩈㉊⍌ⱎ", num), 9);
                    Class1160.dictionary_145 = dictionary1;
                }
                if (Class1160.dictionary_145.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            A_0.method_52().method_1(class2.method_3());
                            break;

                        case 1:
                            A_0.method_52().method_3(class2.method_3());
                            break;

                        case 2:
                            A_0.method_52().method_5(class2.method_3());
                            break;

                        case 3:
                            A_0.method_52().method_7(class2.method_3());
                            break;

                        case 4:
                            A_0.method_52().method_9(class2.method_3());
                            break;

                        case 5:
                            A_0.method_52().method_11(class2.method_3());
                            break;

                        case 6:
                            A_0.method_52().method_13(class2.method_3());
                            break;

                        case 7:
                            A_0.method_52().method_15(class2.method_3());
                            break;

                        case 8:
                            A_0.method_52().method_17(class2.method_3());
                            break;

                        case 9:
                            A_0.method_52().method_19(class2.method_3());
                            break;
                    }
                }
            }
        }
    }

    private static bool smethod_10(Class857 A_0, Class93 A_1)
    {
        for (int i = 0; i < A_0.method_13().method_8(); i++)
        {
            Class91 class2 = A_0.method_13().method_5(i);
            if ((class2 is Class101) && (class2 as Class101).method_23().Contains(A_1.method_0()))
            {
                return true;
            }
        }
        return false;
    }

    private static Style smethod_11(StyleType A_0, string A_1, DocumentObject A_2)
    {
        Style style;
        if (A_0 == StyleType.ParagraphStyle)
        {
            style = new ParagraphStyle((Document) A_2, false);
        }
        else
        {
            style = new Class11((Document) A_2);
        }
        Class1145.smethod_0(Class922.smethod_79(A_1), ((Document) A_2).Styles, false, style);
        style.method_8(A_1);
        return style;
    }

    private static void smethod_12(Class857 A_0, Class93 A_1)
    {
        int num = 0x10;
        if (Class567.smethod_16(A_1.method_0()))
        {
            string name = Class922.smethod_79(A_1.method_0());
            if (A_0.method_9().Styles.FindByName(name) == null)
            {
                Style style = smethod_11(StyleType.ParagraphStyle, A_1.method_0(), A_0.method_9());
                Class97 class2 = (Class97) A_1;
                if (A_1.method_8() != null)
                {
                    style.ApplyBaseStyle(smethod_11(StyleType.ParagraphStyle, A_1.method_8(), A_0.method_9()));
                }
                if (class2.method_13() != null)
                {
                    class2.method_13().CopyPropertiesTo(style.RunPr);
                }
                if ((class2.method_15() != null) && (style.ParaPr != null))
                {
                    class2.method_15().CopyPropertiesTo(style.ParaPr);
                }
                if (class2.method_25() != -1)
                {
                    style.ParaPr.SetAttr(0x500, (byte) class2.method_25());
                }
                if (style.StyleIdentifier == StyleIdentifier.Normal)
                {
                    style.QuickFormat = true;
                    A_0.method_9().Styles.DefaultParaStyle = style as ParagraphStyle;
                    style.Name = BookmarkStart.b("砵圷䠹儻弽ⰿ", num);
                    style.method_5(BookmarkStart.b("圵", num));
                    A_0.method_9().Styles.method_7(style, null);
                }
                else
                {
                    A_0.method_9().Styles.method_7(style, null);
                }
            }
        }
        else
        {
            Class97 class3 = (Class97) A_1;
            if (class3.method_13() != null)
            {
                A_0.method_9().DefCharFormat = new CharacterFormat(A_0.method_9());
                class3.method_13().method_37(A_0.method_9().DefCharFormat);
            }
            if (class3.method_15() != null)
            {
                A_0.method_9().DefParaFormat = new ParagraphFormat(A_0.method_9());
                class3.method_15().method_37(A_0.method_9().DefParaFormat);
            }
        }
    }

    private static void smethod_13(Class857 A_0)
    {
        int num = 6;
        for (int i = 0; i < A_0.method_9().Styles.Count; i++)
        {
            Style style4 = (Style) A_0.method_9().Styles[i];
            if ((style4.StyleIdentifier != StyleIdentifier.Normal) && (style4.StyleIdentifier != StyleIdentifier.DefaultParagraphFont))
            {
                Class91 class4 = A_0.method_13().method_2(style4.Name, null, false, false);
                if (class4 is Class93)
                {
                    Class93 class3 = class4 as Class93;
                    if (class3.method_8() != null)
                    {
                        Style style = A_0.method_9().Styles.method_12(class3.method_8(), false);
                        if (((style != null) && (style.StyleType == style4.StyleType)) && (class3.method_0() != class3.method_8()))
                        {
                            style4.BasedOnIstd = A_0.method_9().Styles.method_12(class3.method_8(), false).Istd;
                        }
                    }
                }
            }
        }
        for (int j = 0; j < A_0.method_13().method_8(); j++)
        {
            Class91 class5 = A_0.method_13().method_5(j);
            if ((class5 != null) && (class5 is Class101))
            {
                Class101 class6 = class5 as Class101;
                string str = (string) class6.method_23()[0];
                Class93 class2 = (Class93) A_0.method_13().method_2(str, BookmarkStart.b("堫䬭䠯䘱", num), false, false);
                if ((class2 != null) && (class2.method_8() != null))
                {
                    Style style3 = A_0.method_9().Styles.method_12(class2.method_8(), false);
                    ListStyle style2 = A_0.method_9().ListStyles[class6.method_21().ListDefId];
                    if (style3.StyleIdentifier != StyleIdentifier.NoList)
                    {
                        style2.ListStyleIstd = style3.Istd;
                    }
                }
            }
        }
    }

    private static void smethod_2(Class857 A_0)
    {
        int num = 0;
        Class396 class2 = A_0.method_11();
        Class111 class3 = new Class111();
        while (class2.method_19())
        {
            string str;
            if (!Class857.smethod_8(class2, class3) && ((str = class2.method_1()) != null))
            {
                int num2;
                if (Class1160.dictionary_146 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("唥尧匩䀫䬭", num), 0);
                    dictionary1.Add(BookmarkStart.b("䔥倧", num), 1);
                    dictionary1.Add(BookmarkStart.b("䔥儧", num), 2);
                    dictionary1.Add(BookmarkStart.b("䜥䘧䴩䀫䬭", num), 3);
                    dictionary1.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯", num), 4);
                    dictionary1.Add(BookmarkStart.b("唥尧䬩師娭ᴯ儱嬳娵圷䠹", num), 5);
                    dictionary1.Add(BookmarkStart.b("䌥䘧丩ī䴭弯帱嬳䐵", num), 6);
                    dictionary1.Add(BookmarkStart.b("唥尧䬩師娭ᴯ嬱娳䈵崷吹伻圽㐿㭁", num), 7);
                    dictionary1.Add(BookmarkStart.b("䌥䘧丩ī䜭帯䘱儳堵䬷匹䠻䜽", num), 8);
                    Class1160.dictionary_146 = dictionary1;
                }
                if (Class1160.dictionary_146.TryGetValue(str, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            class3.method_5(class2.method_3());
                            break;

                        case 1:
                            class3.method_7(class2.method_3());
                            break;

                        case 2:
                            class3.method_9(class2.method_3());
                            break;

                        case 3:
                            class3.method_11(class2.method_3());
                            break;

                        case 4:
                            class3.method_13(class2.method_3());
                            break;

                        case 5:
                            class3.method_15(class2.method_3());
                            break;

                        case 6:
                            class3.method_17(class2.method_3());
                            break;

                        case 7:
                            class3.method_19(class2.method_3());
                            break;

                        case 8:
                            class3.method_21(class2.method_3());
                            break;
                    }
                }
            }
        }
        A_0.method_13().method_1(class3, false, false);
    }

    internal static bool smethod_3(Class857 A_0, bool A_1)
    {
        int num = 13;
        string key = A_0.method_11().method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_147 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("䀲䄴丶唸帺", num), 0);
                dictionary1.Add(BookmarkStart.b("弲尴䐶䴸ᘺ丼䬾㡀⽂⁄", num), 1);
                dictionary1.Add(BookmarkStart.b("尲䀴䌶唸刺匼娾汀あㅄ㹆╈⹊", num), 2);
                dictionary1.Add(BookmarkStart.b("圲吴䌶尸ᘺ丼䬾㡀⽂⁄", num), 3);
                dictionary1.Add(BookmarkStart.b("䜲尴娶尸ᘺ丼䬾㡀⽂⁄", num), 4);
                dictionary1.Add(BookmarkStart.b("崲䀴娶嬸帺似ሾ㉀㝂㱄⭆ⱈ", num), 5);
                dictionary1.Add(BookmarkStart.b("倲䀴䔶䬸帺匼尾㡀湂㙄㍆え❊⡌", num), 6);
                dictionary1.Add(BookmarkStart.b("䌲倴䔶娸帺匼䬾⁀⑂⁄橆㩈㽊㑌⍎㑐", num), 7);
                dictionary1.Add(BookmarkStart.b("儲娴堶唸帺尼儾汀あㅄ㹆╈⹊", num), 8);
                dictionary1.Add(BookmarkStart.b("䜲倴伶䴸ᘺ丼䬾㡀⽂⁄", num), 9);
                Class1160.dictionary_147 = dictionary1;
            }
            if (Class1160.dictionary_147.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        Class921.smethod_0(A_0, A_1);
                        return true;

                    case 1:
                        Class573.smethod_0(A_0, A_1);
                        return true;

                    case 2:
                        Class573.smethod_1(A_0);
                        return true;

                    case 3:
                    case 4:
                        Class1050.smethod_0(A_0, A_1);
                        return true;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        return true;
                }
            }
        }
        return false;
    }

    private static void smethod_4(Class857 A_0)
    {
        int num = 0x10;
        Class396 class2 = A_0.method_11();
        Class109 class3 = new Class109();
        while (class2.method_19())
        {
            string str;
            if (!Class857.smethod_8(class2, class3) && ((str = class2.method_1()) != null))
            {
                if (str != BookmarkStart.b("䔵䰷䌹倻嬽", num))
                {
                    if (str != BookmarkStart.b("刵圷丹伻༽", num))
                    {
                        if (str != BookmarkStart.b("刵圷丹伻༽洿⹁⅃⡅⽇㹉⑋", num))
                        {
                            if (str != BookmarkStart.b("刵圷丹伻ఽ", num))
                            {
                                if (!(str == BookmarkStart.b("刵圷丹伻ఽ洿⹁⅃⡅⽇㹉⑋", num)))
                                {
                                    if (str == BookmarkStart.b("刵儷䤹䠻弽⸿⅁⅃", num))
                                    {
                                        class3.method_15(class2.method_3());
                                    }
                                }
                                else
                                {
                                    class3.method_13(class2.method_3());
                                }
                            }
                            else
                            {
                                class3.method_11(class2.method_3());
                            }
                        }
                        else
                        {
                            class3.method_9(class2.method_3());
                        }
                    }
                    else
                    {
                        class3.method_7(class2.method_3());
                    }
                }
                else
                {
                    class3.method_5(class2.method_3());
                }
            }
        }
        A_0.method_13().method_1(class3, false, false);
    }

    private static void smethod_5(Class857 A_0)
    {
        int num = 0x12;
        Class396 class2 = A_0.method_11();
        Class110 class3 = new Class110();
        while (class2.method_19())
        {
            string str;
            if (!Class857.smethod_8(class2, class3) && ((str = class2.method_1()) != null))
            {
                if (!(str == BookmarkStart.b("丷匹夻䤽ȿⵁ㱃", num)))
                {
                    if (str == BookmarkStart.b("尷", num))
                    {
                        class3.method_7(class2.method_3());
                    }
                }
                else
                {
                    class3.method_5(class2.method_3());
                }
            }
        }
        A_0.method_13().method_1(class3, false, false);
    }

    private static void smethod_6(Class857 A_0)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        string str = class2.method_12(BookmarkStart.b("䐩䌫娭唯ἱ圳娵夷䤹伻", 4), "");
        if (str != "")
        {
            bool flag;
            FootEndnoteOptions options = (flag = str == BookmarkStart.b("伩䈫䨭帯崱䀳匵", num)) ? A_0.method_9().EndnoteOptions : A_0.method_9().FootnoteOptions;
            options.method_53(FootnoteNumberFormat.None);
            options.method_56(0);
            class2.method_18();
            while (class2.method_19())
            {
                string key = class2.method_1();
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_148 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                        dictionary1.Add(BookmarkStart.b("䤩䔫娭儯䘱崳夵嘷᜹伻䨽㤿⹁⅃歅♇⭉⅋⭍", num), 0);
                        dictionary1.Add(BookmarkStart.b("䤩䔫娭儯䘱崳夵嘷᜹帻儽␿㭁楃㕅㱇㍉⁋⭍絏㱑㕓㭕㵗", num), 1);
                        dictionary1.Add(BookmarkStart.b("天堫伭䈯䘱ᤳ䀵夷嘹䤻嬽", num), 2);
                        dictionary1.Add(BookmarkStart.b("䰩䌫䄭䐯就嬳䈵崷䤹ᄻ丽⼿ㅁⵃ㉅ⅇ╉≋", num), 3);
                        dictionary1.Add(BookmarkStart.b("䐩夫䌭ᴯ吱嬳䐵唷嬹䠻", num), 4);
                        dictionary1.Add(BookmarkStart.b("天堫伭䈯䘱ᤳ堵䴷圹帻嬽㈿⭁⩃ⅅ敇⭉㡋", num), 5);
                        dictionary1.Add(BookmarkStart.b("丩䤫䠭儯䜱堳䈵ᔷ䤹䠻䜽ⰿ❁楃⡅⥇❉⥋", num), 6);
                        dictionary1.Add(BookmarkStart.b("䜩䴫崭䐯圱䘳ᬵ䠷嬹嬻嬽洿ⱁ╃⭅ⵇ", num), 7);
                        dictionary1.Add(BookmarkStart.b("䐩夫䌭ᴯ䈱䘳匵帷匹䐻", num), 8);
                        dictionary1.Add(BookmarkStart.b("䐩夫䌭ᴯ䄱䄳倵帷匹䐻", num), 9);
                        dictionary1.Add(BookmarkStart.b("䐩夫䌭ᴯ帱儳䈵䰷弹主ጽ㌿㭁⩃╅", num), 10);
                        dictionary1.Add(BookmarkStart.b("䐩䌫娭唯ἱ圳夵嘷丹唻倽㔿⍁ぃ⽅❇⑉態⁍㽏♑㵓㕕㵗睙㩛ㅝ቟ᕡգᑥ౧", num), 11);
                        dictionary1.Add(BookmarkStart.b("䐩䌫娭唯ἱ圳夵嘷丹唻倽㔿⍁ぃ⽅❇⑉態⁍㽏♑㵓㕕㵗睙㹛㽝͟ॡ፣ݥᩧ๩", num), 12);
                        Class1160.dictionary_148 = dictionary1;
                    }
                    if (Class1160.dictionary_148.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                smethod_7(A_0, class2.method_3(), flag, false);
                                break;

                            case 1:
                                smethod_7(A_0, class2.method_3(), flag, true);
                                break;

                            case 2:
                                options.method_56(class2.method_4() + 1);
                                break;

                            case 3:
                                options.method_54(Class922.smethod_29(class2.method_3()));
                                break;

                            case 4:
                                options.method_53(Class922.smethod_59(class2.method_3()));
                                break;

                            case 5:
                                options.method_55(Class922.smethod_24(class2.method_3()));
                                break;
                        }
                    }
                }
            }
        }
    }

    private static void smethod_7(Class857 A_0, string A_1, bool A_2, bool A_3)
    {
        if (Class567.smethod_16(A_1))
        {
            Class96 class2 = (Class96) A_0.method_13().method_2(Class576.smethod_87(A_1), null, false, false);
            Style style = (Style) Style.smethod_1(StyleType.CharacterStyle, A_0.method_9());
            style.Name = class2.method_0();
            if (class2.method_13() != null)
            {
                class2.method_13().method_37(style.RunPr);
            }
        }
    }

    private static void smethod_8(Class857 A_0)
    {
        int num = 9;
        for (int i = 0; i < A_0.method_13().method_8(); i++)
        {
            Class91 class3 = A_0.method_13().method_5(i);
            if (class3 is Class93)
            {
                Class93 class2 = class3 as Class93;
                if (class2.method_4() == BookmarkStart.b("弮倰䄲吴倶䬸娺䴼圾", num))
                {
                    smethod_12(A_0, class2);
                }
                if ((class2.method_4() == BookmarkStart.b("嬮吰䬲䄴", num)) && (!Class567.smethod_16(class2.method_0()) || (A_0.method_9().Styles.method_12(class2.method_0(), false) == null)))
                {
                    smethod_9(A_0, class2);
                }
            }
        }
        smethod_13(A_0);
    }

    private static void smethod_9(Class857 A_0, Class93 A_1)
    {
        if (!smethod_10(A_0, A_1))
        {
            Class96 class2 = (Class96) A_1;
            if (Class567.smethod_16(A_1.method_0()))
            {
                Style style = smethod_11(StyleType.CharacterStyle, A_1.method_0().ToString(), A_0.method_9());
                if (class2.method_13() != null)
                {
                    class2.method_13().method_37(style.RunPr);
                }
                A_0.method_9().Styles.method_7(style, null);
            }
        }
    }
}

