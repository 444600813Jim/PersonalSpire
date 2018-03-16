using Spire.Doc;
using Spire.Doc.Converters;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;

internal class Class923
{
    private Class923()
    {
    }

    internal static void smethod_0(RowFormat A_0, bool A_1, bool A_2, Interface52 A_3)
    {
        smethod_1(A_0, A_1, A_2, A_3, OoxmlCompliance.Ecma376_2006);
    }

    internal static void smethod_1(RowFormat A_0, bool A_1, bool A_2, Interface52 A_3, OoxmlCompliance A_4)
    {
        int num = 13;
        if (A_0 != null)
        {
            Class398 class2 = A_3.imethod_1();
            Class1054 class3 = new Class1054(smethod_2(A_0), A_2, A_3);
            RowFormat format = smethod_3(A_0);
            if (((format != null) && (class3.object_0 != null)) && ((bool) class3.object_0))
            {
                format.IsAutoResized = true;
            }
            if (A_1)
            {
                smethod_4(class3, format, class2, A_2, A_3, A_4, true);
            }
            else
            {
                if (class3.bool_6)
                {
                    class2.method_40(BookmarkStart.b("䐲༴䔶䨸刺夼派", num), class3.string_26);
                    class2.method_40(BookmarkStart.b("䐲༴䔶䨸刺夼款㍀", num), class3.string_25);
                }
                smethod_6(class3, format, class2, A_2, A_3, A_4, true);
                smethod_5(class3, format, class2, A_2, A_3, A_4, true);
            }
        }
    }

    private static RowFormat smethod_2(RowFormat A_0)
    {
        RowFormat format = A_0;
        format.AcceptFormatRevision();
        return format;
    }

    private static RowFormat smethod_3(RowFormat A_0)
    {
        if (A_0.HasFormatRevision)
        {
            WordAttrCollection attrs = A_0.method_50();
            WordAttrCollection attrs2 = smethod_2(A_0);
            for (int i = 0; i < attrs2.Count; i++)
            {
                int propKey = attrs2.method_18(i);
                if (attrs[propKey] == attrs2[propKey])
                {
                    attrs.Remove(propKey);
                }
            }
            attrs.Remove(0x271a);
            if (attrs.Count > 0)
            {
                attrs.FormatRevision = A_0.FormatRevision;
                return (RowFormat) attrs;
            }
        }
        else if (A_0.HasDeleteRevision || A_0.HasInsertRevision)
        {
            return A_0;
        }
        return null;
    }

    private static void smethod_4(Class1054 A_0, RowFormat A_1, Class398 A_2, bool A_3, Interface52 A_4, OoxmlCompliance A_5, bool A_6)
    {
        int num = 9;
        if (A_6)
        {
            A_2.method_4(BookmarkStart.b("堮ର䜲圴嬶椸䤺", num));
        }
        smethod_8(A_0, A_2, A_5);
        if (A_0.int_1 > 0)
        {
            smethod_9(A_0, A_2, A_3);
        }
        smethod_7(BookmarkStart.b("堮ର䜲圴嬶椸䤺縼圾⁀ⵂ≄≆", num), A_1, A_2, A_3, A_4, A_5, A_4.imethod_2());
        if (A_6)
        {
            A_2.method_5();
        }
    }

    private static void smethod_5(Class1054 A_0, RowFormat A_1, Class398 A_2, bool A_3, Interface52 A_4, OoxmlCompliance A_5, bool A_6)
    {
        int num = 12;
        if ((A_0.int_0 > 0) || ((A_1 != null) && (A_1.HasDeleteRevision || A_1.HasInsertRevision)))
        {
            if (A_6)
            {
                A_2.method_4(BookmarkStart.b("䔱ำ䈵䨷樹主", num));
            }
            if (A_0.int_2 != 0)
            {
                A_2.method_24(BookmarkStart.b("䔱ำ儵䨷匹堻簽┿⑁⭃㑅ⵇ", num), Class1041.smethod_8(A_0.int_2));
            }
            if (A_0.int_4 > 0)
            {
                A_2.method_24(BookmarkStart.b("䔱ำ儵䨷匹堻缽☿㙁⅃㑅", num), Class1041.smethod_8(A_0.int_4));
            }
            if (A_0.int_3 > 0)
            {
                A_2.method_48(BookmarkStart.b("䔱ำ䄵稷弹娻儽㈿❁", num), Class1041.smethod_8(A_0.int_3));
            }
            if (A_0.int_5 > 0)
            {
                A_2.method_48(BookmarkStart.b("䔱ำ䄵礷尹䠻嬽㈿", num), Class1041.smethod_8(A_0.int_5));
            }
            if (A_0.bool_5)
            {
                A_2.method_10(BookmarkStart.b("䔱ำ帵儷帹堻嬽⸿", num));
            }
            if (!A_0.bool_4)
            {
                A_2.method_10(BookmarkStart.b("䔱ำ唵夷吹䠻洽〿⹁ⵃ㉅", num));
            }
            A_2.method_33(BookmarkStart.b("䔱ำ䈵䨷爹夻圽✿⩁ぃ", num), new object[] { A_0.bool_6 ? BookmarkStart.b("䔱ำ帵樷伹倻嬽", num) : BookmarkStart.b("䔱ำ帵ᔷ䠹䤻刽┿", num), A_0.string_22, BookmarkStart.b("䔱ำ䀵夷嘹", num), A_0.string_21 });
            if (A_0.bool_3)
            {
                A_2.method_10(BookmarkStart.b("䔱ำ䈵娷嘹琻嬽ℿ♁⅃㑅", num));
            }
            A_2.method_48(BookmarkStart.b("䔱ำ䈵娷嘹缻嬽ⰿ⹁ᝃ㙅⥇⥉╋⁍㝏", num), A_0.string_14);
            A_2.method_24(BookmarkStart.b("䔱ำ尵嬷", num), A_0.string_13);
            smethod_7(BookmarkStart.b("䔱ำ䈵䨷樹主紽⠿⍁⩃ⅅⵇ", num), A_1, A_2, A_3, A_4, A_5, A_4.imethod_2());
            if (A_1 != null)
            {
                if (A_1.HasDeleteRevision)
                {
                    A_2.vmethod_6(A_1.DeleteRevision, A_4.imethod_6());
                    A_2.vmethod_8();
                }
                if (A_1.HasInsertRevision)
                {
                    A_2.vmethod_6(A_1.InsertRevision, A_4.imethod_6());
                    A_2.vmethod_8();
                }
            }
            if (A_6)
            {
                A_2.method_5();
            }
        }
    }

    private static void smethod_6(Class1054 A_0, RowFormat A_1, Class398 A_2, bool A_3, Interface52 A_4, OoxmlCompliance A_5, bool A_6)
    {
        int num = 10;
        if (A_0.int_1 > 0)
        {
            if (A_6)
            {
                A_2.method_4(BookmarkStart.b("䜯࠱䀳吵吷樹主笽㠿", num));
            }
            smethod_9(A_0, A_2, A_3);
            smethod_7(BookmarkStart.b("䜯࠱䀳吵吷樹主笽㠿Łⱃ❅♇ⵉ⥋", num), A_1, A_2, A_3, A_4, A_5, A_4.imethod_2());
            if (A_6)
            {
                A_2.method_5();
            }
        }
    }

    private static void smethod_7(string A_0, RowFormat A_1, Class398 A_2, bool A_3, Interface52 A_4, OoxmlCompliance A_5, bool A_6)
    {
        int num = 5;
        if ((A_1 == null) || !A_1.HasFormatRevision)
        {
            return;
        }
        Class1054 class2 = new Class1054(A_1, A_3, A_4);
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("尪ᜬ嬮匰弲攴䔶稸区尼儾♀♂", num))
            {
                if (class2.int_1 > 0)
                {
                    A_2.vmethod_5(A_1.FormatRevision, A_0, A_4.imethod_6());
                    smethod_4(class2, null, A_2, A_3, A_4, A_5, A_6);
                    A_2.vmethod_8();
                    return;
                }
            }
            else if (str == BookmarkStart.b("尪ᜬ嬮匰弲攴䔶簸䌺縼圾⁀ⵂ≄≆", num))
            {
                if (class2.int_1 > 0)
                {
                    A_2.vmethod_5(A_1.FormatRevision, A_0, A_4.imethod_6());
                    smethod_6(class2, null, A_2, A_3, A_4, A_5, A_6);
                    A_2.vmethod_8();
                    return;
                }
            }
            else
            {
                if (str != BookmarkStart.b("尪ᜬ嬮䌰挲䜴琶儸娺匼堾⑀", num))
                {
                    goto Label_0104;
                }
                if (class2.int_0 > 0)
                {
                    A_2.vmethod_5(A_1.FormatRevision, A_0, A_4.imethod_6());
                    smethod_5(class2, null, A_2, A_3, A_4, A_5, A_6);
                    A_2.vmethod_8();
                    return;
                }
            }
            return;
        }
    Label_0104:
        throw new ArgumentException(BookmarkStart.b("縪䌬䨮䤰䌲倴吶䴸帺夼Ἶ㕀≂≄杆❈⩊⁌⩎罐", num));
    }

    private static void smethod_8(Class1054 A_0, Class398 A_1, OoxmlCompliance A_2)
    {
        int num = 0;
        A_1.method_24(BookmarkStart.b("儥ሧ帩丫䈭振䘱䴳娵崷", 0), A_0.string_0);
        A_1.method_24(BookmarkStart.b("儥ሧ帩丫䈭振䘱䴳娵崷根医䤽ȿ⍁⩃≅ᭇ⍉㙋⭍", 0), A_0.string_1);
        A_1.method_24(BookmarkStart.b("儥ሧ帩丫䈭振䘱䴳娵崷礹医刽ȿ⍁⩃≅ᭇ⍉㙋⭍", 0), A_0.string_2);
        if (A_0.bool_6 && (A_2 != OoxmlCompliance.Ecma376_2006))
        {
            A_1.method_24(BookmarkStart.b("儥ሧ帩丫䈭猯匱䐳䈵儷唹刻", num), A_0.string_23);
            A_1.method_24(BookmarkStart.b("儥ሧ帩丫䈭琯圱䜳唵䨷匹䰻䨽⤿ⵁ⩃", num), A_0.string_24);
        }
        if (A_0.bool_0)
        {
            A_1.method_33(BookmarkStart.b("儥ሧ帩丫䈭䀯戱䘳", num), new object[] { 
                BookmarkStart.b("儥ሧ䘩䤫䠭䐯琱䘳夵唷渹夻䘽㐿", num), A_0.string_4, BookmarkStart.b("儥ሧ堩䔫䤭堯䘱爳䐵圷圹栻嬽㠿㙁", num), A_0.string_6, BookmarkStart.b("儥ሧ帩䌫席瘯䀱嬳嬵氷弹䐻䨽", num), A_0.string_3, BookmarkStart.b("儥ሧ䠩䌫娭䐯崱夳瀵䨷唹儻樽┿㩁ぃ", num), A_0.string_5, BookmarkStart.b("儥ሧ尩䤫尭䐯猱娳唵倷唹主", num), A_0.string_7, BookmarkStart.b("儥ሧ䈩䌫尭䨯猱娳唵倷唹主", num), A_0.string_8, BookmarkStart.b("儥ሧ帩丫䈭䀯樱朳䘵崷夹", num), A_0.string_9, BookmarkStart.b("儥ሧ帩丫䈭䀯樱", num), A_0.string_10, 
                BookmarkStart.b("儥ሧ帩丫䈭䀯欱朳䘵崷夹", num), A_0.string_11, BookmarkStart.b("儥ሧ帩丫䈭䀯欱", num), A_0.string_12
             });
        }
        if (!A_0.bool_1)
        {
            A_1.method_24(BookmarkStart.b("儥ሧ帩丫䈭缯䐱儳䐵吷嬹䰻", num), A_0.bool_6 ? BookmarkStart.b("䠥䴧尩䤫尭", num) : BookmarkStart.b("栥䴧尩䤫尭", num));
        }
        if (A_0.bool_2)
        {
            A_1.method_10(BookmarkStart.b("儥ሧ䠩䔫䨭夯搱崳䔵䴷嬹倻", num));
        }
    }

    private static void smethod_9(Class1054 A_0, Class398 A_1, bool A_2)
    {
        int num = 2;
        A_1.method_54(BookmarkStart.b("弧ဩ堫䰭尯攱", 2), A_0.class15_0);
        A_1.method_24(BookmarkStart.b("弧ဩ䘫䴭", 2), A_0.string_13);
        A_1.method_48(BookmarkStart.b("弧ဩ堫䰭尯焱儳娵吷椹䰻弽⌿⭁⩃ⅅ", 2), A_0.string_14);
        A_1.method_48(BookmarkStart.b("弧ဩ堫䰭尯笱娳刵", 2), A_0.string_15);
        A_1.method_46(BookmarkStart.b("弧ဩ堫䰭尯瀱嬳䐵尷弹主䴽", 2), A_0.bool_6, new object[] { BookmarkStart.b("弧ဩ堫䄭䀯", 2), A_0.border_4, BookmarkStart.b("弧ဩ䀫䬭嘯䘱", 2), A_0.border_2, BookmarkStart.b("弧ဩ丫䄭䐯䘱嬳嬵", 2), A_0.border_0, BookmarkStart.b("弧ဩ師䜭圯娱䀳", 2), A_0.border_3, BookmarkStart.b("弧ဩ䔫䀭䌯嬱倳匵瀷", 2), A_0.border_1, BookmarkStart.b("弧ဩ䔫䀭䌯嬱倳匵渷", 2), A_0.border_5 });
        A_1.vmethod_4(A_0.class16_0);
        if (!A_2 && !((bool) A_0.object_0))
        {
            A_1.method_33(BookmarkStart.b("弧ဩ堫䰭尯縱唳伵圷伹䠻", num), new object[] { BookmarkStart.b("弧ဩ堫圭䀯圱", num), A_0.bool_6 ? BookmarkStart.b("丧䌩含䬭启", num) : BookmarkStart.b("渧䌩含䬭启", num) });
        }
        A_1.method_50(BookmarkStart.b("弧ဩ堫䰭尯焱儳娵吷眹崻䰽", num), A_0.string_16, A_0.string_17, A_0.string_18, A_0.string_19);
        if (!A_0.bool_6 && !A_2)
        {
            if (A_0.string_20 == null)
            {
                A_1.method_24(BookmarkStart.b("弧ဩ堫䰭尯縱嬳夵匷", num), Class1041.smethod_41(Class531.smethod_1(TableStyleOptions.Default)));
            }
            else if (A_0.string_20 != Class1041.smethod_41(Class531.smethod_1(TableStyleOptions.Default2003)))
            {
                A_1.method_24(BookmarkStart.b("弧ဩ堫䰭尯縱嬳夵匷", num), A_0.string_20);
            }
        }
        else
        {
            A_1.method_24(BookmarkStart.b("弧ဩ堫䰭尯縱嬳夵匷", num), A_0.string_20);
        }
    }
}

