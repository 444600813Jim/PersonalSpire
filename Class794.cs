using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections.Generic;

internal class Class794
{
    private Class794()
    {
    }

    internal static void smethod_0(Class857 A_0, Class98 A_1)
    {
        int num = 9;
        Class396 class2 = A_0.method_11();
        Class43 class3 = new Class43();
        if (Class567.smethod_16(A_1.method_8()))
        {
            Class91 class4 = A_0.method_13().method_4(A_1.method_8(), BookmarkStart.b("䠮䌰刲䔴弶倸堺", num));
            if (class4 is Class98)
            {
                Class98 class7 = (Class98) class4;
                if (class7.method_45() != null)
                {
                    class3 = (Class43) class7.method_45().Clone();
                }
            }
        }
        string str2 = null;
        string str = null;
        string str3 = "";
        string str4 = "";
        string str5 = null;
        string str6 = null;
        ShapeVerticalAlignment none = ShapeVerticalAlignment.None;
        class3.SetAttr(0x1001, TextWrappingStyle.Square);
        string str8 = class2.method_12(BookmarkStart.b("堮䌰刲䔴ᨶ娸吺匼䬾⹀㙂㝄", num), "");
        string str9 = class2.method_12(BookmarkStart.b("堮䌰刲䔴ᨶ娸吺匼䬾⹀㙂㝄橆⑈⑊⥌⩎", num), "");
        string str10 = class2.method_12(BookmarkStart.b("崮䐰崲ᠴ䌶儸䤺刼䨾♀⭂", num), BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀", num));
        while (class2.method_19())
        {
            string str7;
            if ((!Class857.smethod_1(class2, A_1.method_37()) && !Class857.smethod_9(class2, A_1.method_35())) && (!Class857.smethod_2(class2, A_1.method_39()) && ((str7 = class2.method_1()) != null)))
            {
                int num2;
                if (Class1160.dictionary_143 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x25);
                    dictionary1.Add(BookmarkStart.b("丮䐰䜲娴ᨶ常䤺刼䠾汀⭂⁄⹆⹈⍊㥌", num), 0);
                    dictionary1.Add(BookmarkStart.b("丮䐰䜲娴ᨶ常䤺刼䠾汀㑂ⱄ⍆㵈⍊", num), 1);
                    dictionary1.Add(BookmarkStart.b("䰮崰娲䔴", num), 2);
                    dictionary1.Add(BookmarkStart.b("堮䌰刲䔴", num), 3);
                    dictionary1.Add(BookmarkStart.b("䜮帰䄲尴䴶嘸唺䤼帾ⵀ湂㕄⡆㩈", num), 4);
                    dictionary1.Add(BookmarkStart.b("䜮帰䄲尴䴶嘸唺䤼帾ⵀ湂㝄≆╈", num), 5);
                    dictionary1.Add(BookmarkStart.b("央吰䄲䄴帶娸娺儼ሾㅀⱂ㙄", num), 6);
                    dictionary1.Add(BookmarkStart.b("央吰䄲䄴帶娸娺儼ሾ㍀♂⥄", num), 7);
                    dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸ᘺ䨼嘾╀㝂ⵄ", num), 8);
                    dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸ᘺ帼倾ⵀⱂ㝄", num), 9);
                    dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸ᘺ刼伾⁀⁂ⱄ㍆え", num), 10);
                    dictionary1.Add(BookmarkStart.b("尮夰刲儴堶丸ᘺ帼倾ⵀⱂ㝄", num), 11);
                    dictionary1.Add(BookmarkStart.b("尮夰刲儴堶丸", num), 12);
                    dictionary1.Add(BookmarkStart.b("尮夰刲儴堶丸ᘺ刼伾⁀⁂ⱄ㍆え", num), 13);
                    dictionary1.Add(BookmarkStart.b("尮夰刲儴堶丸ᘺ刼夾❀あ⁄㍆摈㍊", num), 14);
                    dictionary1.Add(BookmarkStart.b("尮夰刲儴堶丸ᘺ刼夾❀あ⁄㍆摈㉊", num), 15);
                    dictionary1.Add(BookmarkStart.b("崮䐰崲ᠴ䌶儸䤺刼䨾♀⭂", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸ᘺ夼帾㉀⭂", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("䈮倰䄲帴制䬸ᘺ丼䬾⁀ㅂㅄ", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䈮倰䄲帴制䬸ᘺ堼儾╀", num), 20);
                    dictionary1.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀湂♄⡆╈⑊㽌", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䤮堰弲头ᨶ娸吺儼倾㍀", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("尮吰倲娴夶崸娺似䘾汀╂ⱄ⭆╈晊⹌⁎㵐㱒❔", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("䤮堰弲头ᨶ常䤺尼嬾⡀♂⭄㍆摈╊ⱌ≎㑐", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("䤮堰弲头", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀湂ㅄ㕆⡈╊㹌㽎ぐ⅒ご㥖㩘≚", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("䀮䄰刲嘴帶䴸䈺", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("䌮䐰帲尴夶堸唺帼娾", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("䰮帰崲䄴䔶堸䠺䤼", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("䰮帰弲娴䔶ᐸ嘺刼嬾⑀", num), 30);
                    dictionary1.Add(BookmarkStart.b("䈮倰䄲帴制䬸ᘺ丼䬾⁀ㅂㅄ橆㹈≊⥌㭎㥐", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("䈮倰䄲帴制䬸ᘺ堼儾╀湂㉄⹆ⵈ㽊╌", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("堮䌰刲䔴ᨶ嘸䬺䤼嘾⹀ⵂ", num), 0x21);
                    dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸ᘺ夼帾㉀⭂桄⥆⡈♊⡌㱎", num), 0x22);
                    dictionary1.Add(BookmarkStart.b("䈮倰䄲帴制䬸ᘺ丼䬾⁀ㅂㅄ橆⩈⹊⍌㭎㑐⅒", num), 0x23);
                    dictionary1.Add(BookmarkStart.b("䈮倰䄲帴制䬸ᘺ堼儾╀湂♄≆❈㽊⡌㵎", num), 0x24);
                    Class1160.dictionary_143 = dictionary1;
                }
                if (Class1160.dictionary_143.TryGetValue(str7, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                            if (!(class2.method_3() == BookmarkStart.b("嬮䌰䘲倴", num)))
                            {
                                goto Label_04DD;
                            }
                            class3.SetAttr(190, true);
                            break;

                        case 2:
                        {
                            string[] strArray = class2.method_3().Replace(BookmarkStart.b("崮吰倲䄴", num), "").Replace(BookmarkStart.b("ܮ", num), "").Replace(BookmarkStart.b("خ", num), "").Replace(BookmarkStart.b("̮", num), BookmarkStart.b("༮", num)).Replace(BookmarkStart.b("༮ᄰ", num), BookmarkStart.b("༮", num)).Trim(new char[] { ' ' }).Split(new char[] { ' ' });
                            A_1.method_50(Class576.smethod_41(strArray[0]));
                            A_1.method_48(Class576.smethod_41(strArray[1]));
                            A_1.method_54(Class576.smethod_41(strArray[2]));
                            A_1.method_52(Class576.smethod_41(strArray[3]));
                            break;
                        }
                        case 3:
                            class3.SetAttr(0x1001, Class922.smethod_32(class2.method_3(), str8, str9, str10));
                            class3.SetAttr(0x1002, Class922.smethod_33(class2.method_3()));
                            break;

                        case 4:
                            class3.SetAttr(0x38f, Class922.smethod_47(class2.method_3()));
                            break;

                        case 5:
                            class3.SetAttr(0x390, Class922.smethod_45(class2.method_3()));
                            break;

                        case 6:
                            none = Class922.smethod_41(class2.method_3());
                            class3.Remove(0x391);
                            break;

                        case 7:
                            class3.SetAttr(0x392, Class922.smethod_39(class2.method_3()));
                            break;

                        case 8:
                            class3.SetAttr(0x1cb, Class576.smethod_55(class2.method_3()));
                            break;

                        case 9:
                            class3.SetAttr(0x1c0, Class576.smethod_76(class2.method_3()));
                            break;

                        case 10:
                            class3.SetAttr(0x1c1, Class576.smethod_78(class2.method_3()));
                            break;

                        case 11:
                            class3.SetAttr(0x201, Class576.smethod_76(class2.method_3()));
                            break;

                        case 12:
                            if (!(class2.method_3() == BookmarkStart.b("央堰䀲尴唶唸帺", num)))
                            {
                                goto Label_0747;
                            }
                            class3.SetAttr(0x23e, true);
                            break;

                        case 13:
                            class3.SetAttr(0x204, Class576.smethod_78(class2.method_3()));
                            break;

                        case 14:
                            class3.SetAttr(0x205, Class576.smethod_55(class2.method_3()));
                            break;

                        case 15:
                            class3.SetAttr(0x206, Class576.smethod_55(class2.method_3()));
                            break;

                        case 0x10:
                            class3.SetAttr(0x3ba, class2.method_3() == BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀", num));
                            break;

                        case 0x11:
                        {
                            str2 = class2.method_3();
                            string str11 = str2;
                            if (str11 != null)
                            {
                                if (str11 == BookmarkStart.b("䄮帰崲倴", num))
                                {
                                    goto Label_0856;
                                }
                                if (str11 == BookmarkStart.b("尮帰弲尴匶", num))
                                {
                                    class3.SetAttr(0x1fc, true);
                                }
                            }
                            break;
                        }
                        case 0x12:
                            str = Class576.smethod_87(class2.method_3());
                            break;

                        case 0x13:
                            Class922.smethod_17(A_0, class2.method_3(), class3, true);
                            break;

                        case 20:
                            Class922.smethod_17(A_0, class2.method_3(), class3, false);
                            break;

                        case 0x15:
                            if (class3.method_31(0x181) == null)
                            {
                                class3.SetAttr(0x181, Class576.smethod_76(class2.method_3()));
                            }
                            break;

                        case 0x16:
                            class3.SetAttr(0x181, Class576.smethod_76(class2.method_3()));
                            break;

                        case 0x17:
                            class3.SetAttr(0x287, Class576.smethod_76(class2.method_3()));
                            break;

                        case 0x18:
                            str5 = class2.method_3();
                            break;

                        case 0x19:
                            str6 = class2.method_3();
                            break;

                        case 0x1a:
                            class3.SetAttr(0x182, Class576.smethod_79(class2.method_3()));
                            break;

                        case 0x1b:
                            class3.SetAttr(0x182, Class576.smethod_78(class2.method_3()));
                            break;

                        case 0x1c:
                            class3.SetAttr(0x109, Class576.smethod_26(class2.method_3()));
                            break;

                        case 0x1d:
                            class3.SetAttr(0x108, Class576.smethod_24(class2.method_3()));
                            break;

                        case 30:
                            if (!(class2.method_3() == BookmarkStart.b("䠮䌰嘲䰴䐶娸娺儼娾", num)))
                            {
                                goto Label_09D9;
                            }
                            class3.SetAttr(0x13d, true);
                            break;

                        case 0x1f:
                            str3 = class2.method_3();
                            break;

                        case 0x20:
                            str4 = class2.method_3();
                            break;

                        case 0x21:
                            if (!(class2.method_3() == BookmarkStart.b("䄮帰Ḳ䈴䔶堸䬺", num)))
                            {
                                goto Label_0A43;
                            }
                            class3.SetAttr(0x85, TextBoxWrapMode.None);
                            break;
                    }
                }
            }
            continue;
        Label_04DD:
            class3.SetAttr(190, false);
            continue;
        Label_0747:
            if (class2.method_3() == BookmarkStart.b("䜮堰圲儴制圸", num))
            {
                class3.SetAttr(0x23e, false);
            }
            continue;
        Label_0856:
            class3.SetAttr(0x1fc, false);
            continue;
        Label_09D9:
            if (class2.method_3() == BookmarkStart.b("䈮帰崲娴", num))
            {
                class3.SetAttr(0x13e, true);
            }
            continue;
        Label_0A43:
            class3.SetAttr(0x85, TextBoxWrapMode.Square);
        }
        object obj2 = class3.method_31(0x392);
        if ((obj2 == null) || (((RelativeVerticalPosition) obj2) != RelativeVerticalPosition.Line))
        {
            class3.SetAttr(0x391, none);
        }
        Class109 class5 = A_0.method_13().method_2(str, null, false, false) as Class109;
        LineDashing dashing = Class922.smethod_16(str2, class5);
        if ((dashing != LineDashing.Solid) && (dashing != LineDashing.Solid))
        {
            class3.SetAttr(0x1ce, dashing);
        }
        if (class5 != null)
        {
            if (class5.method_4() == BookmarkStart.b("崮帰䘲嬴匶", num))
            {
                class3.SetAttr(0x1d7, LineCap.Round);
            }
            else if (Class567.smethod_16(class5.method_4()))
            {
                class3.SetAttr(0x1d7, LineCap.Flat);
            }
        }
        smethod_3(class3, A_1, str2 != BookmarkStart.b("䄮帰崲倴", num));
        smethod_2(str3, class3, true);
        smethod_2(str4, class3, false);
        Class111 class6 = A_0.method_13().method_2(str5, null, false, false) as Class111;
        smethod_1(class3, str6, class6);
        if (class3.Count > 0)
        {
            A_1.method_46(class3);
        }
    }

    private static void smethod_1(Class43 A_0, string A_1, Class111 A_2)
    {
        int num = 15;
        if (A_1 != null)
        {
            if (A_1 == BookmarkStart.b("嬴堶圸帺", num))
            {
                A_0.SetAttr(0x1bb, false);
            }
            else
            {
                A_0.SetAttr(0x1bb, true);
                A_0.SetAttr(0x180, Class922.smethod_19(A_1, A_2));
                if ((A_1 == BookmarkStart.b("刴䔶堸强吼娾⽀㝂", num)) && (A_2 != null))
                {
                    if (Class567.smethod_16(A_2.method_14()))
                    {
                        A_0.SetAttr(0x181, Class576.smethod_76(A_2.method_14()));
                    }
                    if (Class567.smethod_16(A_2.method_16()))
                    {
                        A_0.SetAttr(0x183, Class576.smethod_76(A_2.method_16()));
                    }
                    if (Class567.smethod_16(A_2.method_18()))
                    {
                        A_0.SetAttr(0x182, Class576.smethod_78(A_2.method_18()));
                    }
                    if (Class567.smethod_16(A_2.method_20()))
                    {
                        A_0.SetAttr(0x184, Class576.smethod_78(A_2.method_20()));
                    }
                    if (Class567.smethod_16(A_2.method_6()))
                    {
                        A_0.SetAttr(0x18d, Class576.smethod_28(A_2.method_6()));
                    }
                    if (Class567.smethod_16(A_2.method_8()))
                    {
                        A_0.SetAttr(0x18e, Class576.smethod_28(A_2.method_8()));
                    }
                    if (Class567.smethod_16(A_2.method_10()))
                    {
                        A_0.SetAttr(0x18b, Class576.smethod_7(A_2.method_10()) / 10);
                    }
                    if (A_2.method_4() == BookmarkStart.b("吴伶倸娺儼", num))
                    {
                        A_0.SetAttr(0x18c, -1);
                    }
                    if (A_2.method_4() == BookmarkStart.b("头帶圸帺尼䴾", num))
                    {
                        A_0.SetAttr(0x18c, 100);
                    }
                }
            }
        }
    }

    private static void smethod_2(string A_0, Class43 A_1, bool A_2)
    {
        if (Class567.smethod_16(A_0))
        {
            int num4 = Class576.smethod_36(A_0);
            int propKey = A_2 ? 0x1d2 : 0x1d4;
            int num = A_2 ? 0x1d0 : 0x1d1;
            int num3 = num4;
            if (num3 <= 0xf5)
            {
                switch (num3)
                {
                    case 140:
                        A_1.SetAttr(propKey, StrokeArrowWidth.Narrow);
                        return;

                    case 210:
                        A_1.SetAttr(propKey, StrokeArrowWidth.Medium);
                        return;
                }
                if (num3 == 0xf5)
                {
                    A_1.SetAttr(num, ArrowType.Open);
                    A_1.SetAttr(propKey, StrokeArrowWidth.Narrow);
                }
            }
            else
            {
                switch (num3)
                {
                    case 0x13b:
                        A_1.SetAttr(num, ArrowType.Open);
                        A_1.SetAttr(propKey, StrokeArrowWidth.Medium);
                        return;

                    case 350:
                        A_1.SetAttr(propKey, StrokeArrowWidth.Wide);
                        return;
                }
                if (num3 == 420)
                {
                    A_1.SetAttr(num, ArrowType.Open);
                    A_1.SetAttr(propKey, StrokeArrowWidth.Wide);
                }
            }
        }
    }

    private static void smethod_3(Class43 A_0, Class97 A_1, bool A_2)
    {
        Class852 class2 = A_1.method_37();
        Class412 class3 = A_1.method_39();
        A_1.method_35();
        if (((class2.method_0() != null) && (class2.method_0().method_2() != BorderStyle.None)) || (A_2 || (class3.method_0() != 0.0)))
        {
            Class413.smethod_3(A_0.method_58().Top, Class472.smethod_1(class2.method_0(), class3.method_0(), 0));
        }
        if (((class2.method_2() != null) && (class2.method_2().method_2() != BorderStyle.None)) || (A_2 || (class3.method_2() != 0.0)))
        {
            Class413.smethod_3(A_0.method_58().Bottom, Class472.smethod_1(class2.method_2(), class3.method_2(), 0));
        }
        if (((class2.method_4() != null) && (class2.method_4().method_2() != BorderStyle.None)) || (A_2 || (class3.method_4() != 0.0)))
        {
            Class413.smethod_3(A_0.method_58().Left, Class472.smethod_1(class2.method_4(), class3.method_4(), 0));
        }
        if (((class2.method_6() != null) && (class2.method_6().method_2() != BorderStyle.None)) || (A_2 || (class3.method_6() != 0.0)))
        {
            Class413.smethod_3(A_0.method_58().Right, Class472.smethod_1(class2.method_6(), class3.method_6(), 0));
        }
    }
}

