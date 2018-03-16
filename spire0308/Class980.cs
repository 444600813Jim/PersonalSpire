using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;

internal class Class980
{
    public const float float_0 = 20f;

    private Class980()
    {
    }

    internal static void smethod_0(Class581 A_0, Section A_1)
    {
        int num = 15;
        bool isDefault = A_1.SectPr.IsDefault;
        Class17 sectPr = A_1.SectPr;
        Class394 class3 = A_0.imethod_1();
        if (A_0.vmethod_5())
        {
            while (class3.method_19())
            {
                string str2;
                if (((str2 = class3.method_1()) != null) && (str2 == BookmarkStart.b("䜴䐶倸强渼娾≀㝂", num)))
                {
                    int num3 = Class114.smethod_7(class3.method_3());
                    if (num3 != -2147483648)
                    {
                        sectPr.SetAttr(0x8ca, num3);
                    }
                }
            }
        }
        while (class3.method_9(BookmarkStart.b("䘴制娸伺洼䴾", num)))
        {
            string key = class3.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_220 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x18);
                    dictionary1.Add(BookmarkStart.b("崴制堸强堼䴾ፀ♂⍄≆㭈⹊⍌ⱎ㑐", num), 0);
                    dictionary1.Add(BookmarkStart.b("匴堶嘸伺堼䴾ፀ♂⍄≆㭈⹊⍌ⱎ㑐", num), 1);
                    dictionary1.Add(BookmarkStart.b("崴匶䬸", num), 2);
                    dictionary1.Add(BookmarkStart.b("匴䌶䬸", num), 3);
                    dictionary1.Add(BookmarkStart.b("匴堶嘸伺匼倾㕀♂ᕄ㕆", num), 4);
                    dictionary1.Add(BookmarkStart.b("倴夶崸唺刼䬾⑀ፂ㝄", num), 5);
                    dictionary1.Add(BookmarkStart.b("䄴丶䤸帺", num), 6);
                    dictionary1.Add(BookmarkStart.b("䔴倶樸䄺", num), 7);
                    dictionary1.Add(BookmarkStart.b("䔴倶琸娺似", num), 8);
                    dictionary1.Add(BookmarkStart.b("䔴嘶䤸帺似氾㍀⁂", num), 9);
                    dictionary1.Add(BookmarkStart.b("䔴倶笸吺似嬾⑀ㅂ㙄", num), 10);
                    dictionary1.Add(BookmarkStart.b("头夶眸为值款㡀㍂⁄", num), 11);
                    dictionary1.Add(BookmarkStart.b("䔴倶眸为值款㡀㍂⁄", num), 12);
                    dictionary1.Add(BookmarkStart.b("嘴堶唸䠺", num), 13);
                    dictionary1.Add(BookmarkStart.b("匴堶䬸嘺洼䴾⹀㝂", num), 14);
                    dictionary1.Add(BookmarkStart.b("䌴瘶唸刺娼儾", num), 15);
                    dictionary1.Add(BookmarkStart.b("嬴堶簸唺夼儾⹀㝂⁄", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䄴帶䴸场堼漾♀", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("䄴制䄸伺笼匾⹀㑂", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("圴帶崸刺", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䜴䌶唸簺䠼䬾㕀♂㝄", num), 20);
                    dictionary1.Add(BookmarkStart.b("儴堶娸簺似嘾╀", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䘴制娸伺洼䴾ɀ⭂⑄⥆⹈⹊", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("吴夶圸吺䤼帾㕀⩂⩄⥆", num), 0x17);
                    Class1160.dictionary_220 = dictionary1;
                }
                if (Class1160.dictionary_220.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 2:
                        case 3:
                            smethod_1(A_1, A_0);
                            break;

                        case 4:
                            Class913.smethod_7(A_0, class3.method_1(), sectPr.method_139());
                            break;

                        case 5:
                            Class913.smethod_7(A_0, class3.method_1(), sectPr.method_138());
                            break;

                        case 6:
                            sectPr.SetAttr(0x7ee, Class339.smethod_20(class3.method_28()));
                            break;

                        case 7:
                            smethod_2(class3, sectPr);
                            break;

                        case 8:
                            smethod_3(class3, sectPr);
                            break;

                        case 9:
                            smethod_4(class3, sectPr);
                            break;

                        case 10:
                            smethod_5(class3, sectPr, A_1.PageSetup.Borders);
                            break;

                        case 11:
                            smethod_6(class3, sectPr);
                            break;

                        case 12:
                            smethod_7(A_0, sectPr);
                            break;

                        case 13:
                            smethod_8(class3, sectPr, A_1);
                            break;

                        case 14:
                            sectPr.SetAttr(0x956, !class3.method_31());
                            break;

                        case 15:
                            sectPr.SetAttr(0x924, Class339.smethod_8(class3.method_28()));
                            break;

                        case 0x10:
                            sectPr.SetAttr(0x834, class3.method_31());
                            break;

                        case 0x11:
                            sectPr.SetAttr(0x7f8, class3.method_31());
                            break;

                        case 0x12:
                            sectPr.SetAttr(0x988, Class911.smethod_4(class3.method_28()));
                            break;

                        case 0x13:
                            sectPr.SetAttr(0x992, class3.method_31());
                            break;

                        case 20:
                            sectPr.SetAttr(0x96a, class3.method_31());
                            break;

                        case 0x15:
                            smethod_10(class3, sectPr);
                            break;

                        case 0x17:
                            Class519.smethod_8(sectPr, A_0);
                            break;
                    }
                }
            }
        }
    }

    private static void smethod_1(Section A_0, Class581 A_1)
    {
        Class394 class2 = A_1.imethod_1();
        bool flag = class2.method_1() == BookmarkStart.b("䈩䠫尭", 4);
        HeaderFooterType type = Class339.smethod_4(class2.method_12(BookmarkStart.b("帩唫席唯", 4), ""), flag);
        HeaderFooter footer = new HeaderFooter(A_0, type);
        A_1.method_16(true);
        Class629.smethod_0(A_1, footer);
        A_1.method_16(false);
        A_0.HeadersFooters[type] = footer;
        if (A_0.HeadersFooters[footer.Type] == null)
        {
            A_0.method_18(footer, A_0.Body);
        }
    }

    private static void smethod_10(Class394 A_0, Class17 A_1)
    {
        int num = 14;
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䀳伵䠷弹", num))
                {
                    if ((str != BookmarkStart.b("堳張嘷弹氻圽㐿⅁ⱃ", num)) && (str != BookmarkStart.b("堳張嘷弹ᄻ丽⤿㙁❃⹅", num)))
                    {
                        if ((str == BookmarkStart.b("圳帵夷䠹漻丽ℿ⅁⅃", num)) || (str == BookmarkStart.b("圳帵夷䠹ᄻ䴽〿⍁❃⍅", num)))
                        {
                            A_1.SetAttr(0x974, A_0.method_4());
                        }
                    }
                    else
                    {
                        A_1.SetAttr(0x87a, ((float) A_0.method_4()) / 20f);
                    }
                }
                else
                {
                    GridPitchType type = Class339.smethod_2(A_0.method_3());
                    A_1.SetAttr(0x97e, (int) type);
                }
            }
        }
    }

    private static void smethod_2(Class394 A_0, Class17 A_1)
    {
        int num = 5;
        A_1.method_89(PageOrientation.Portrait);
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("尪", num))
                {
                    if (str != BookmarkStart.b("䌪", num))
                    {
                        if (!(str == BookmarkStart.b("䐪弬䘮吰崲䄴", num)))
                        {
                            if (str == BookmarkStart.b("䠪䈬䬮吰", num))
                            {
                                A_1.SetAttr(0x82a, A_0.method_4());
                            }
                        }
                        else
                        {
                            A_1.SetAttr(0x8a2, Class339.smethod_18(A_0.method_3()));
                        }
                    }
                    else
                    {
                        float num3 = A_0.method_62();
                        if (num3 != float.MaxValue)
                        {
                            A_1.SetAttr(0x8de, num3);
                        }
                    }
                }
                else
                {
                    float num2 = A_0.method_62();
                    if (num2 != float.MaxValue)
                    {
                        A_1.SetAttr(0x8d4, num2);
                    }
                }
            }
        }
    }

    private static void smethod_3(Class394 A_0, Class17 A_1)
    {
        int num = 3;
        A_1.method_51(A_1.method_50());
        while (A_0.method_19())
        {
            string key = A_0.method_1();
            if (key != null)
            {
                int num5;
                if (Class1160.dictionary_221 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("崨䐪崬", num), 0);
                    dictionary1.Add(BookmarkStart.b("嬨䈪䨬䜮䔰", num), 1);
                    dictionary1.Add(BookmarkStart.b("䬨䐪夬嬮帰帲", num), 2);
                    dictionary1.Add(BookmarkStart.b("䔨个䬬嬮", num), 3);
                    dictionary1.Add(BookmarkStart.b("䄨个䰬䬮吰䄲", num), 4);
                    dictionary1.Add(BookmarkStart.b("伨䐪䈬嬮吰䄲", num), 5);
                    dictionary1.Add(BookmarkStart.b("丨帪夬嬮吰䄲", num), 6);
                    Class1160.dictionary_221 = dictionary1;
                }
                if (Class1160.dictionary_221.TryGetValue(key, out num5))
                {
                    switch (num5)
                    {
                        case 0:
                        {
                            float num6 = A_0.method_62();
                            if (num6 != float.MaxValue)
                            {
                                A_1.method_50().Top = num6;
                            }
                            break;
                        }
                        case 1:
                        {
                            float num7 = A_0.method_62();
                            if (num7 != float.MaxValue)
                            {
                                A_1.method_50().Right = num7;
                            }
                            break;
                        }
                        case 2:
                        {
                            float num3 = A_0.method_62();
                            if (num3 != float.MaxValue)
                            {
                                A_1.method_50().Bottom = num3;
                            }
                            break;
                        }
                        case 3:
                        {
                            float num9 = A_0.method_62();
                            if (num9 != float.MaxValue)
                            {
                                A_1.method_50().Left = num9;
                            }
                            break;
                        }
                        case 4:
                        {
                            float num2 = A_0.method_62();
                            if (num2 != float.MaxValue)
                            {
                                A_1.SetAttr(0x910, num2);
                            }
                            break;
                        }
                        case 5:
                        {
                            float num8 = A_0.method_62();
                            if (num8 != float.MaxValue)
                            {
                                A_1.SetAttr(0x91a, num8);
                            }
                            break;
                        }
                        case 6:
                        {
                            float num4 = A_0.method_62();
                            if (num4 != float.MaxValue)
                            {
                                A_1.method_50().Gutter = num4;
                            }
                            break;
                        }
                    }
                }
            }
        }
    }

    private static void smethod_4(Class394 A_0, Class17 A_1)
    {
        int num = 0x13;
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("弸刺似䰾㕀", num)))
                {
                    if (str == BookmarkStart.b("嘸伺唼娾㍀", num))
                    {
                        A_1.SetAttr(0x820, A_0.method_4());
                    }
                }
                else
                {
                    A_1.SetAttr(0x816, A_0.method_4());
                }
            }
        }
    }

    private static void smethod_5(Class394 A_0, Class17 A_1, Borders A_2)
    {
        int num = 12;
        while (A_0.method_19())
        {
            string str2 = A_0.method_1();
            if (str2 != null)
            {
                if ((str2 != BookmarkStart.b("䠱笳䐵尷弹主", num)) && (str2 != BookmarkStart.b("䠱ᤳ夵䨷帹夻䰽", num)))
                {
                    if (str2 != BookmarkStart.b("嘱崳䔵䠷嘹崻䜽", num))
                    {
                        if ((str2 == BookmarkStart.b("崱刳倵䬷弹䠻砽㈿ⵁ⥃", num)) || (str2 == BookmarkStart.b("崱刳倵䬷弹䠻ጽ☿ぁ⭃⭅", num)))
                        {
                            A_1.SetAttr(0x8c0, Class339.smethod_14(A_0.method_3()));
                        }
                    }
                    else
                    {
                        A_1.SetAttr(0x8ac, Class339.smethod_16(A_0.method_3()));
                    }
                }
                else
                {
                    string str3 = A_0.method_3();
                    if (str3 != null)
                    {
                        if (!(str3 == BookmarkStart.b("吱䘳夵嘷丹", num)))
                        {
                            if (str3 == BookmarkStart.b("倱唳唵匷", num))
                            {
                                A_1.SetAttr(0x8b6, false);
                            }
                            continue;
                        }
                        A_1.SetAttr(0x8b6, true);
                    }
                }
            }
        }
        while (A_0.method_9(BookmarkStart.b("䈱匳琵圷䠹堻嬽㈿ㅁ", num)))
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䘱嬳䘵", num))
                {
                    if (str != BookmarkStart.b("帱儳倵䰷", num))
                    {
                        if (!(str == BookmarkStart.b("倱嬳䈵䰷唹儻", num)))
                        {
                            if (str == BookmarkStart.b("䀱崳儵倷丹", num))
                            {
                                A_0.method_36(A_2.Right);
                            }
                        }
                        else
                        {
                            A_0.method_36(A_2.Bottom);
                        }
                    }
                    else
                    {
                        A_0.method_36(A_2.Left);
                    }
                }
                else
                {
                    A_0.method_36(A_2.Top);
                }
            }
        }
    }

    private static void smethod_6(Class394 A_0, Class17 A_1)
    {
        int num = 1;
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if ((str != BookmarkStart.b("䐦䘨帪䌬嬮猰䨲", num)) && (str != BookmarkStart.b("䐦䘨帪䌬嬮ᰰ儲䰴", num)))
                {
                    if (str != BookmarkStart.b("否崨䨪弬嬮", num))
                    {
                        if (!(str == BookmarkStart.b("䌦䀨堪夬丮弰倲倴", num)))
                        {
                            if (str == BookmarkStart.b("唦䰨堪夬丮䌰䜲", num))
                            {
                                A_1.SetAttr(0x83e, Class339.smethod_12(A_0.method_3()));
                            }
                        }
                        else
                        {
                            float num2 = A_0.method_62();
                            if (num2 != float.MaxValue)
                            {
                                A_1.SetAttr(0x960, num2);
                            }
                        }
                    }
                    else
                    {
                        A_1.SetAttr(0x884, A_0.method_4() + 1);
                    }
                }
                else
                {
                    A_1.SetAttr(0x848, A_0.method_4());
                }
            }
        }
    }

    private static void smethod_7(Class581 A_0, Class17 A_1)
    {
        int num = 5;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䴪䀬嬮", num))
                {
                    if (str != BookmarkStart.b("堪夬丮䌰䜲", num))
                    {
                        if ((str != BookmarkStart.b("䠪䔬丮䄰怲䄴丶唸帺", num)) && (str != BookmarkStart.b("䠪䔬丮䄰Ḳ䘴䌶䀸场堼", num)))
                        {
                            if ((str == BookmarkStart.b("䠪䔬丮䄰怲倴䜶", num)) || (str == BookmarkStart.b("䠪䔬丮䄰Ḳ䘴制䤸", num)))
                            {
                                A_1.method_55(Class339.smethod_10(class2.method_3()));
                            }
                        }
                        else
                        {
                            A_1.method_85(class2.method_4());
                        }
                    }
                    else
                    {
                        A_1.method_87(class2.method_4());
                        A_1.method_61(true);
                    }
                }
                else
                {
                    A_0.vmethod_5();
                    A_1.method_53((PageNumberStyle) Class911.smethod_2(class2.method_3()));
                }
            }
        }
    }

    private static void smethod_8(Class394 A_0, Class17 A_1, Section A_2)
    {
        int num = 8;
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䀭䔯弱", num))
                {
                    if (str != BookmarkStart.b("崭唯䈱", num))
                    {
                        if (!(str == BookmarkStart.b("崭䀯匱圳匵", num)))
                        {
                            if (str == BookmarkStart.b("䬭䄯䜱唳娵漷匹堻䨽⠿", num))
                            {
                                A_1.SetAttr(0x938, A_0.method_63());
                            }
                        }
                        else
                        {
                            A_1.SetAttr(0x942, A_0.method_61());
                        }
                    }
                    else
                    {
                        A_1.SetAttr(0x80c, A_0.method_63());
                    }
                }
                else
                {
                    A_1.SetAttr(0x92e, A_0.method_4());
                }
            }
        }
        ColumnCollection columns = new ColumnCollection(A_2);
        while (A_0.method_9(BookmarkStart.b("䴭弯帱䜳", num)))
        {
            string str2;
            if (((str2 = A_0.method_1()) != null) && (str2 == BookmarkStart.b("䴭弯帱", num)))
            {
                columns.Add(smethod_9(A_0));
            }
        }
        if (columns.Count > 0)
        {
            A_1.SetAttr(0x94c, columns);
        }
        else
        {
            float num4 = A_2.PageSetup.PageSize.Width * 20f;
            float num5 = A_2.PageSetup.Margins.Left * 20f;
            float num6 = A_2.PageSetup.Margins.Right * 20f;
            float num7 = A_2.PageSetup.Margins.Gutter * 20f;
            float num2 = ((((num4 - num5) - num6) - (A_1.method_120() * (A_1.method_116() - 1))) - num7) / ((float) A_1.method_116());
            for (int i = 0; i < A_1.method_116(); i++)
            {
                Column column = new Column(A_0.method_66()) {
                    Space = ((float) A_1.method_120()) / 20f,
                    Width = num2 / 20f
                };
                A_2.Columns.Add(column);
            }
        }
    }

    private static Column smethod_9(Class394 A_0)
    {
        int num = 0x11;
        Column column = new Column(A_0.method_66());
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䀶", num)))
                {
                    if (str == BookmarkStart.b("䐶䤸娺帼娾", num))
                    {
                        float num2 = A_0.method_62();
                        if (num2 != float.MaxValue)
                        {
                            column.Space = num2;
                        }
                    }
                }
                else
                {
                    float num3 = A_0.method_62();
                    if (num3 != float.MaxValue)
                    {
                        column.Width = num3;
                    }
                }
            }
        }
        return column;
    }
}

