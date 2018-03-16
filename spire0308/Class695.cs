using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class695
{
    private Class695()
    {
    }

    internal static void smethod_0(Section A_0, Interface52 A_1)
    {
        int num = 1;
        WordAttrCollection sectPr = A_0.SectPr;
        Class398 class2 = A_1.imethod_1();
        class2.method_4(BookmarkStart.b("倦ጨ堪䠬䰮䔰挲䜴", 1));
        if (A_1.imethod_2())
        {
            class2.method_40(BookmarkStart.b("倦ጨ太帬䘮唰怲倴吶䴸", num), Class114.smethod_6(sectPr.method_31(0x8ca)));
        }
        if (sectPr.FormatRevision != null)
        {
            smethod_2(A_0, A_1);
            WordAttrCollection attrs2 = (WordAttrCollection) sectPr.Clone();
            attrs2.AcceptFormatRevision();
            smethod_1(attrs2, false, A_1);
            class2.vmethod_5(sectPr.FormatRevision, BookmarkStart.b("倦ጨ堪䠬䰮䔰挲䜴琶儸娺匼堾⑀", num), A_1.imethod_6());
            class2.method_4(BookmarkStart.b("倦ጨ堪䠬䰮䔰挲䜴", num));
            if (A_1.imethod_2())
            {
                class2.method_40(BookmarkStart.b("倦ጨ太帬䘮唰怲倴吶䴸", num), Class114.smethod_6(sectPr.method_31(0x8ca)));
            }
            smethod_1(sectPr, true, A_1);
            class2.method_5();
            class2.vmethod_8();
        }
        else
        {
            smethod_2(A_0, A_1);
            smethod_1(sectPr, false, A_1);
        }
        class2.method_6(BookmarkStart.b("倦ጨ堪䠬䰮䔰挲䜴", num));
    }

    private static void smethod_1(AttrCollection A_0, bool A_1, Interface52 A_2)
    {
        int num = 13;
        Class398 class2 = A_2.imethod_1();
        bool flag = A_2.imethod_2();
        string str = null;
        string str2 = null;
        string str3 = null;
        string str4 = null;
        string str5 = null;
        string str6 = null;
        string str7 = null;
        string str8 = null;
        string str9 = null;
        string str10 = null;
        string str11 = null;
        string str12 = null;
        string str13 = null;
        string str14 = null;
        string str15 = null;
        string str16 = null;
        Border top = null;
        Border left = null;
        Border bottom = null;
        Border right = null;
        string str17 = null;
        string str18 = null;
        string str19 = null;
        string str20 = null;
        string str21 = null;
        string str22 = null;
        string str23 = null;
        string str24 = null;
        object obj2 = null;
        string str25 = null;
        string str26 = null;
        object obj3 = null;
        ColumnCollection columns = null;
        string str27 = null;
        string str28 = null;
        string str29 = null;
        string str30 = null;
        string str31 = null;
        object obj4 = null;
        object obj5 = null;
        object obj6 = null;
        object obj7 = null;
        object obj8 = null;
        object obj9 = null;
        for (int i = 0; i < A_0.Count; i++)
        {
            int num3 = A_0.method_18(i);
            object obj10 = A_0.method_19(i);
            int num4 = num3;
            if (num4 <= 0x8a2)
            {
                if (num4 <= 0x820)
                {
                    if (num4 <= 0x7e4)
                    {
                        if (num4 <= 0x7d0)
                        {
                            if (num4 == 0x7c6)
                            {
                                bottom = (obj10 as Borders).Bottom;
                                left = (obj10 as Borders).Left;
                                top = (obj10 as Borders).Top;
                                right = (obj10 as Borders).Right;
                            }
                            else if (num4 == 0x7d0)
                            {
                                MarginsF sf = (MarginsF) obj10;
                                str5 = A_2.imethod_1().method_23(sf.Top, 20f).ToString();
                                str8 = A_2.imethod_1().method_23(sf.Left, 20f).ToString();
                                str6 = A_2.imethod_1().method_23(sf.Right, 20f).ToString();
                                str7 = A_2.imethod_1().method_23(sf.Bottom, 20f).ToString();
                                str11 = A_2.imethod_1().method_23(sf.Gutter, 20f).ToString();
                            }
                        }
                        else if (num4 == 0x7da)
                        {
                            str21 = Class911.smethod_3((ListPatternType) obj10);
                        }
                        else if (num4 == 0x7e4)
                        {
                            str24 = Class339.smethod_11((PageSeparator) obj10, flag);
                        }
                    }
                    else if (num4 <= 0x7f8)
                    {
                        if (num4 == 0x7ee)
                        {
                            str30 = Class339.smethod_21((SectionBreakType) obj10, flag);
                        }
                        else if (num4 == 0x7f8)
                        {
                            obj6 = obj10;
                        }
                    }
                    else
                    {
                        switch (num4)
                        {
                            case 0x80c:
                            {
                                obj3 = obj10;
                                continue;
                            }
                            case 0x816:
                            {
                                str12 = Class1041.smethod_8((int) obj10);
                                continue;
                            }
                        }
                        if (num4 == 0x820)
                        {
                            str13 = Class1041.smethod_8((int) obj10);
                        }
                    }
                }
                else if (num4 <= 0x848)
                {
                    if (num4 <= 0x834)
                    {
                        if (num4 == 0x82a)
                        {
                            str4 = Class1041.smethod_8((int) obj10);
                        }
                        else if (num4 == 0x834)
                        {
                            obj8 = obj10;
                        }
                    }
                    else if (num4 == 0x83e)
                    {
                        str20 = Class339.smethod_13((LineNumberingRestartMode) obj10, flag);
                    }
                    else if (num4 == 0x848)
                    {
                        str17 = Class1041.smethod_8((int) obj10);
                    }
                }
                else if (num4 <= 0x884)
                {
                    if (num4 == 0x87a)
                    {
                        str28 = A_2.imethod_1().method_23(obj10, 20f).ToString();
                    }
                    else if (num4 == 0x884)
                    {
                        str18 = Class1041.smethod_8(((int) obj10) - 1);
                    }
                }
                else
                {
                    switch (num4)
                    {
                        case 0x88e:
                        {
                            str23 = Class1041.smethod_8((int) obj10);
                            continue;
                        }
                        case 0x898:
                        {
                            if ((bool) A_0.method_32(0x802))
                            {
                                str22 = Class1041.smethod_8((int) obj10);
                            }
                            continue;
                        }
                    }
                    if (num4 == 0x8a2)
                    {
                        str3 = Class339.smethod_19((PageOrientation) obj10);
                    }
                }
            }
            else if (num4 <= 0x92e)
            {
                if (num4 <= 0x8d4)
                {
                    if (num4 <= 0x8b6)
                    {
                        if (num4 == 0x8ac)
                        {
                            str15 = Class339.smethod_17((PageBordersApplyType) obj10, flag);
                        }
                        else if (num4 == 0x8b6)
                        {
                            if ((bool) obj10)
                            {
                                str14 = BookmarkStart.b("唲䜴堶圸伺", num);
                            }
                            else
                            {
                                str14 = BookmarkStart.b("儲吴吶券", num);
                            }
                        }
                    }
                    else if (num4 == 0x8c0)
                    {
                        str16 = Class339.smethod_15((PageBorderOffsetFrom) obj10);
                    }
                    else if (num4 == 0x8d4)
                    {
                        str = A_2.imethod_1().method_23(obj10, 20f).ToString();
                    }
                }
                else if (num4 <= 0x910)
                {
                    if (num4 == 0x8de)
                    {
                        str2 = A_2.imethod_1().method_23(obj10, 20f).ToString();
                    }
                    else if (num4 == 0x910)
                    {
                        str9 = A_2.imethod_1().method_23(obj10, 20f).ToString();
                    }
                }
                else
                {
                    switch (num4)
                    {
                        case 0x91a:
                        {
                            str10 = A_2.imethod_1().method_23(obj10, 20f).ToString();
                            continue;
                        }
                        case 0x924:
                        {
                            str31 = Class339.smethod_9((PageAlignment) obj10);
                            continue;
                        }
                    }
                    if (num4 == 0x92e)
                    {
                        str26 = Class1041.smethod_8((int) obj10);
                    }
                }
            }
            else if (num4 <= 0x960)
            {
                if (num4 <= 0x942)
                {
                    if (num4 == 0x938)
                    {
                        obj2 = obj10;
                    }
                    else if (num4 == 0x942)
                    {
                        str25 = Class1041.smethod_8((int) obj10);
                    }
                }
                else
                {
                    switch (num4)
                    {
                        case 0x94c:
                        {
                            columns = (ColumnCollection) obj10;
                            str26 = columns.Count.ToString();
                            continue;
                        }
                        case 0x956:
                        {
                            obj7 = !((bool) obj10);
                            continue;
                        }
                    }
                    if (num4 == 0x960)
                    {
                        str19 = Class1041.smethod_10(Convert.ToUInt32(obj10));
                    }
                }
            }
            else
            {
                switch (num4)
                {
                    case 0x96a:
                        obj5 = obj10;
                        break;

                    case 0x974:
                        str29 = Class1041.smethod_8((int) obj10);
                        break;

                    case 0x97e:
                        str27 = Class339.smethod_3((GridPitchType) obj10, flag);
                        break;

                    case 0x988:
                        obj9 = Class911.smethod_5((TextDirection) obj10);
                        break;

                    case 0x992:
                        obj4 = obj10;
                        break;
                }
            }
        }
        if (!A_1)
        {
            if (str9 == null)
            {
                str9 = A_2.imethod_1().method_23((float) A_0.method_32(0x910), 20f).ToString();
            }
            if (str10 == null)
            {
                str10 = A_2.imethod_1().method_23((float) A_0.method_32(0x91a), 20f).ToString();
            }
            if (((str25 == null) && (columns != null)) && (columns.Count > 0))
            {
                str25 = (columns[0].Space * 20f).ToString();
            }
        }
        A_2.imethod_8(A_0, false);
        class2.method_24(BookmarkStart.b("䐲༴䌶䀸䬺堼", num), str30);
        bool flag2 = ((PageOrientation) A_0[0x8a2]) == PageOrientation.Landscape;
        string str32 = str;
        string str33 = str2;
        float num7 = (A_0 as Class17).method_96() * 20f;
        float num8 = (A_0 as Class17).method_98() * 20f;
        if (flag2 && (num7 < num8))
        {
            str32 = num8.ToString();
            str33 = num7.ToString();
        }
        class2.method_33(BookmarkStart.b("䐲༴䜶常栺䜼", num), new object[] { BookmarkStart.b("䐲༴䀶", num), str32, BookmarkStart.b("䐲༴弶", num), str33, BookmarkStart.b("䐲༴堶䬸刺堼儾㕀", num), str3, BookmarkStart.b("䐲༴吶嘸强堼", num), str4 });
        class2.method_33(BookmarkStart.b("䐲༴䜶常瘺尼䴾", num), new object[] { BookmarkStart.b("䐲༴䌶嘸䬺", num), str5, BookmarkStart.b("䐲༴䔶倸尺唼䬾", num), str6, BookmarkStart.b("䐲༴唶嘸伺䤼倾ⱀ", num), str7, BookmarkStart.b("䐲༴嬶尸崺䤼", num), str8, BookmarkStart.b("䐲༴弶尸娺夼娾㍀", num), str9, BookmarkStart.b("䐲༴儶嘸吺䤼娾㍀", num), str10, BookmarkStart.b("䐲༴倶䰸伺䤼娾㍀", num), str11 });
        class2.method_33(BookmarkStart.b("䐲༴䜶堸䬺堼䴾ቀㅂ♄", num), new object[] { BookmarkStart.b("䐲༴儶倸䤺丼䬾", num), str12, BookmarkStart.b("䐲༴堶䴸区堼䴾", num), str13 });
        if (((top != null) || (left != null)) || ((bottom != null) || (right != null)))
        {
            class2.method_4(BookmarkStart.b("䐲༴䜶常示刼䴾╀♂㝄㑆", num));
            class2.method_40(flag ? BookmarkStart.b("䐲༴䴶瘸䤺夼娾㍀", num) : BookmarkStart.b("䐲༴䴶ᐸ吺似嬾⑀ㅂ", num), str14);
            class2.method_40(BookmarkStart.b("䐲༴匶倸䠺䴼匾⁀㩂", num), str15);
            class2.method_40(flag ? BookmarkStart.b("䐲༴堶弸崺丼娾㕀Ղ㝄⡆⑈", num) : BookmarkStart.b("䐲༴堶弸崺丼娾㕀湂⍄㕆♈♊", num), str16);
            class2.method_47(BookmarkStart.b("䐲༴䌶嘸䬺", num), top, flag);
            class2.method_47(BookmarkStart.b("䐲༴嬶尸崺䤼", num), left, flag);
            class2.method_47(BookmarkStart.b("䐲༴唶嘸伺䤼倾ⱀ", num), bottom, flag);
            class2.method_47(BookmarkStart.b("䐲༴䔶倸尺唼䬾", num), right, flag);
            class2.method_5();
        }
        class2.method_33(BookmarkStart.b("䐲༴嬶圸町䠼刾ᕀ㩂㕄≆", num), new object[] { flag ? BookmarkStart.b("䐲༴吶嘸为匼䬾̀㩂", num) : BookmarkStart.b("䐲༴吶嘸为匼䬾汀⅂㱄", num), str17, BookmarkStart.b("䐲༴䐶䴸娺似䬾", num), str18, BookmarkStart.b("䐲༴匶倸䠺䤼帾⽀⁂⁄", num), str19, BookmarkStart.b("䐲༴䔶尸䠺䤼帾㍀㝂", num), str20 });
        class2.method_33(BookmarkStart.b("䐲༴䜶常町䠼刾ᕀ㩂㕄≆", num), new object[] { BookmarkStart.b("䐲༴儶吸伺", num), str21, BookmarkStart.b("䐲༴䐶䴸娺似䬾", num), str22, flag ? BookmarkStart.b("䐲༴吶儸娺䴼氾㕀㩂⥄≆", num) : BookmarkStart.b("䐲༴吶儸娺䴼ሾ㉀㝂㱄⭆ⱈ", num), str23, flag ? BookmarkStart.b("䐲༴吶儸娺䴼氾⑀㍂", num) : BookmarkStart.b("䐲༴吶儸娺䴼ሾ㉀♂㕄", num), str24 });
        if (class2.method_34(BookmarkStart.b("䐲༴吶嘸场丼", num), new object[] { BookmarkStart.b("䐲༴夶䰸嘺", num), str26, BookmarkStart.b("䐲༴䐶尸䬺", num), obj3, BookmarkStart.b("䐲༴䐶䤸娺帼娾", num), str25, BookmarkStart.b("䐲༴制䠸为尼匾ᙀ⩂⅄㍆ⅈ", num), obj2 }))
        {
            if (columns != null)
            {
                for (int j = 0; j < columns.Count; j++)
                {
                    class2.method_33(BookmarkStart.b("䐲༴吶嘸场", num), new object[] { BookmarkStart.b("䐲༴䀶", num), (columns[j].Width > 0f) ? ((object) (columns[j].Width * 20f)) : null, BookmarkStart.b("䐲༴䐶䤸娺帼娾", num), (columns[j].Space > 0f) ? ((object) (columns[j].Space * 20f)) : null });
                }
            }
            class2.method_5();
        }
        class2.method_22(BookmarkStart.b("䐲༴儶嘸䤺值漾㍀ⱂㅄ", num), obj7);
        class2.method_24(BookmarkStart.b("䐲༴䄶砸场吼堾⽀", num), str31);
        class2.method_22(BookmarkStart.b("䐲༴夶嘸縺匼嬾⽀ⱂㅄ≆", num), obj8);
        class2.method_22(BookmarkStart.b("䐲༴䌶倸伺儼娾ᅀ⑂", num), obj6);
        class2.method_22(flag ? BookmarkStart.b("䐲༴䌶尸䌺䤼笾⡀ㅂ⁄⑆㵈≊≌ⅎ", num) : BookmarkStart.b("䐲༴䌶尸䌺䤼社ⵀⱂ㉄", num), obj9);
        class2.method_22(BookmarkStart.b("䐲༴唶倸强吼", num), obj4);
        class2.method_22(BookmarkStart.b("䐲༴䔶䴸场稼䨾㕀㝂⁄㕆", num), obj5);
        class2.method_33(BookmarkStart.b("䐲༴匶嘸堺稼䴾⡀❂", num), new object[] { BookmarkStart.b("䐲༴䌶䀸䬺堼", num), str27, flag ? BookmarkStart.b("䐲༴嬶倸唺堼漾⡀㝂♄⽆", num) : BookmarkStart.b("䐲༴嬶倸唺堼ሾㅀ⩂ㅄ⑆ⅈ", num), str28, flag ? BookmarkStart.b("䐲༴吶儸娺似氾ㅀ≂♄≆", num) : BookmarkStart.b("䐲༴吶儸娺似ሾ㉀㍂⑄⑆ⱈ", num), str29 });
    }

    private static void smethod_2(Section A_0, Interface52 A_1)
    {
        smethod_3(A_0, HeaderFooterType.HeaderEven, A_1);
        smethod_3(A_0, HeaderFooterType.HeaderOdd, A_1);
        smethod_3(A_0, HeaderFooterType.HeaderFirstPage, A_1);
        smethod_3(A_0, HeaderFooterType.FooterEven, A_1);
        smethod_3(A_0, HeaderFooterType.FooterOdd, A_1);
        smethod_3(A_0, HeaderFooterType.FooterFirstPage, A_1);
    }

    private static void smethod_3(Section A_0, HeaderFooterType A_1, Interface52 A_2)
    {
        HeaderFooter footer = A_0.HeadersFooters[A_1];
        if ((footer != null) && (footer.ChildObjects.Count > 0))
        {
            A_2.imethod_7(footer);
        }
    }
}

