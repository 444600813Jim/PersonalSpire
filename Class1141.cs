using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

internal class Class1141
{
    private Class1141()
    {
    }

    internal static CharacterFormat smethod_0(Class857 A_0, Class96 A_1)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        CharacterFormat format = new CharacterFormat(A_0.method_9());
        string str = class2.method_12(BookmarkStart.b("䄦䘨䔪夬Ȯ䈰娲伴制", 1), BookmarkStart.b("ᘦᤨ嬪夬", 1));
        if (str.EndsWith(BookmarkStart.b("Ȧ", 1)))
        {
            str = BookmarkStart.b("ᘦᤨ嬪夬", num);
        }
        float num3 = Class576.smethod_68(str);
        string str3 = "";
        string str4 = "";
        string str5 = "";
        string str6 = "";
        string str7 = "";
        string str8 = "";
        string str12 = "";
        string str9 = "";
        string str10 = "";
        string str13 = "";
        Color black = Color.Black;
        Class340 class3 = null;
        bool flag = true;
        string str14 = string.Empty;
        string str15 = string.Empty;
        bool flag2 = false;
        bool flag3 = false;
        class2.method_18();
        while (class2.method_19())
        {
            int num2;
            string[] strArray;
            bool flag4;
            string str2 = class2.method_3();
            string key = class2.method_1();
            if (key != null)
            {
                int num4;
                if (Class1160.dictionary_231 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x2b);
                    dictionary1.Add(BookmarkStart.b("伦倨嬪䔬䨮弰刲䄴制", num), 0);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䜰刲䜴帶堸唺䤼", num), 1);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䔰䄲吴夶䨸崺刼䴾ⱀ", num), 2);
                    dictionary1.Add(BookmarkStart.b("䐦䘨䜪䈬崮", num), 3);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ帰䘲䄴嬶倸唺堼", num), 4);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ崰娲嬴制ᐸ伺唼䴾⹀㙂≄⽆摈㽊㑌㽎㑐", num), 5);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ崰娲嬴制ᐸ伺唼䴾⹀㙂≄⽆摈㱊⑌⭎═㭒", num), 6);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ崰娲嬴制ᐸ伺唼䴾⹀㙂≄⽆摈㡊㥌㙎㵐㙒", num), 7);
                    dictionary1.Add(BookmarkStart.b("䬦䰨弪夬䨮䌰Ḳ帴制䬸唺吼儾♀", num), 8);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䄰尲䘴帶䴸刺刼儾", num), 9);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ弰刲場制", num), 10);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ弰刲場制ᐸ堺刼刾ㅀ⽂⁄㽆", num), 11);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ弰刲場制ᐸ娺丼嘾⁀ⵂ", num), 12);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䈰娲伴制", num), 13);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䈰娲伴制ᐸ娺丼嘾⁀ⵂ", num), 14);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䈰娲伴制ᐸ堺刼刾ㅀ⽂⁄㽆", num), 15);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䘰嘲尴倶儸伺", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䘰嘲尴倶儸伺ြ帾㉀⩂⑄⥆", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䘰嘲尴倶儸伺ြ尾⹀⹂㕄⭆ⱈ㍊", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䈰䜲䰴嬶尸", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䈰䜲䰴嬶尸ᘺ尼䰾⡀≂⭄", num), 20);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䈰䜲䰴嬶尸ᘺ帼倾ⱀ㍂⥄≆ㅈ", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䬦䠨䔪䨬娮倰吲倴", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䐦䘨帪䌬嬮䌰䨲", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("䬦䠨䔪䨬娮倰吲倴ᨶ堸䠺吼帾⽀", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("䐦䘨帪䌬嬮䌰䨲ᠴ嘶䨸刺尼儾", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("䬦䠨䔪䨬娮倰吲倴ᨶ娸吺值伾ⵀ♂㵄", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("䐦䘨帪䌬嬮䌰䨲ᠴ吶嘸嘺䴼匾⑀㭂", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("䔦䠨䠪䘬䠮䌰尲䀴夶崸ᘺ帼倾ⵀⱂ㝄", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("䬦䰨弪夬䨮䌰Ḳ䘴䜶堸堺吼儾♀", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬Ȯ䌰嘲头帶尸崺", num), 30);
                    dictionary1.Add(BookmarkStart.b("䌦䀨堪崬䌮倰䨲", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ匰弲尴夶券刺匼堾", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䈰倲吴嬶尸", num), 0x21);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䈰嬲吴匶嘸䰺", num), 0x22);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䐰崲儴制䬸场吼儾⑀湂㉄⹆ⵈ㽊╌", num), 0x23);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䐰崲儴制䬸场吼儾⑀湂㙄㍆え❊⡌", num), 0x24);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䐰崲儴制䬸场吼儾⑀湂ㅄ㹆㥈⹊", num), 0x25);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䐰崲儴制䬸场吼儾⑀湂⡄⡆ⵈ⹊", num), 0x26);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䐰崲儴制䬸场吼儾⑀湂♄⡆╈⑊㽌", num), 0x27);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䌰尲䄴嘶䴸刺刼儾汀あ♄♆╈⹊", num), 40);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䌰尲䄴嘶䴸刺刼儾汀≂⭄⁆╈⹊", num), 0x29);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ吰帲䔴弶堸䠺吼䔾⑀", num), 0x2a);
                    Class1160.dictionary_231 = dictionary1;
                }
                if (Class1160.dictionary_231.TryGetValue(key, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                            goto Label_04F5;

                        case 1:
                            if (str2 == BookmarkStart.b("否䐨䨪䄬䌮ᰰ倲吴䜶䨸", num))
                            {
                                format.SetAttr(110, Class650.class650_1);
                            }
                            break;

                        case 2:
                            if (str2 == BookmarkStart.b("刦夨嬪䠬崮到刲䘴制", num))
                            {
                                format.SetAttr(120, Class650.class650_1);
                            }
                            break;

                        case 3:
                            format.SetAttr(160, Class576.smethod_76(str2));
                            break;

                        case 4:
                            if (str2 == BookmarkStart.b("匦嬨帪䠬", num))
                            {
                                format.SetAttr(90, Class650.class650_1);
                            }
                            break;

                        case 5:
                            goto Label_05F1;

                        case 6:
                            if (str2 == "")
                            {
                                flag = false;
                            }
                            break;

                        case 7:
                            if (!(str2 == BookmarkStart.b("否䘨䜪䐬䬮", num)))
                            {
                                goto Label_067D;
                            }
                            format.SetAttr(80, Class650.class650_1);
                            break;

                        case 8:
                            format.SetAttr(220, 1.5f);
                            if (str2 != BookmarkStart.b("匦嬨帪䠬", num))
                            {
                                format.SetAttr(220, 0f);
                            }
                            break;

                        case 9:
                            strArray = str2.Split(new char[] { ' ' });
                            if (!(strArray[0] == BookmarkStart.b("否尨嬪䠬崮", num)))
                            {
                                goto Label_072E;
                            }
                            format.SetAttr(210, SubSuperScript.SuperScript);
                            goto Label_0755;

                        case 10:
                        {
                            string str11 = (string) A_0.method_54()[class2.method_3()];
                            if (Class567.smethod_16(str11))
                            {
                                format.FontNameAscii = str11;
                                format.FontNameNonFarEast = str11;
                            }
                            break;
                        }
                        case 11:
                        {
                            string str17 = (string) A_0.method_54()[class2.method_3()];
                            if (Class567.smethod_16(str17))
                            {
                                format.FontNameBidi = (string) A_0.method_54()[class2.method_3()];
                            }
                            break;
                        }
                        case 12:
                        {
                            string str16 = (string) A_0.method_54()[class2.method_3()];
                            if (Class567.smethod_16(str16))
                            {
                                format.FontNameFarEast = (string) A_0.method_54()[class2.method_3()];
                            }
                            break;
                        }
                        case 13:
                            Class576.smethod_66(class2.method_3(), A_1, format, 190);
                            break;

                        case 14:
                        case 15:
                            Class576.smethod_66(class2.method_3(), A_1, format, 350);
                            break;

                        case 0x10:
                            str14 = smethod_4(str2);
                            break;

                        case 0x11:
                            str15 = smethod_4(str2);
                            break;

                        case 0x12:
                            format.SetAttr(250, new Class650(Class576.smethod_70(class2.method_3())));
                            break;

                        case 0x13:
                            flag2 = Class576.smethod_69(class2.method_3());
                            break;

                        case 20:
                            flag3 = Class576.smethod_69(class2.method_3());
                            break;

                        case 0x15:
                            format.SetAttr(260, new Class650(Class576.smethod_69(class2.method_3())));
                            break;

                        case 0x16:
                            str3 = class2.method_3();
                            break;

                        case 0x17:
                            str4 = class2.method_3();
                            break;

                        case 0x18:
                            str5 = class2.method_3();
                            break;

                        case 0x19:
                            str6 = class2.method_3();
                            break;

                        case 0x1a:
                            str7 = class2.method_3();
                            break;

                        case 0x1b:
                            str8 = class2.method_3();
                            break;

                        case 0x1c:
                            format.SetAttr(370, Class576.smethod_62(str2, (Class16) format.method_31(370)));
                            break;

                        case 0x1d:
                            format.SetAttr(150, (class2.method_3() == BookmarkStart.b("䤦䘨太䀬丮崰", num)) ? 0f : (((float) Class576.smethod_36(class2.method_3())) / 20f));
                            break;

                        case 30:
                            goto Label_09A1;

                        case 0x1f:
                            goto Label_09F9;

                        case 0x20:
                            smethod_3(class2.method_3(), black);
                            break;

                        case 0x21:
                            format.SetAttr(290, smethod_2(class2.method_3()));
                            break;

                        case 0x22:
                            if (class2.method_3() != BookmarkStart.b("䤦䘨䔪䠬", num))
                            {
                                format.SetAttr(100, Class650.class650_1);
                            }
                            break;

                        case 0x23:
                            str12 = class2.method_3();
                            break;

                        case 0x24:
                            str9 = class2.method_3();
                            break;

                        case 0x25:
                            str13 = class2.method_3();
                            break;

                        case 0x26:
                            str10 = class2.method_3();
                            break;

                        case 0x27:
                            if (class2.method_3() != BookmarkStart.b("䄦䘨䔪夬Ȯ到尲头堶䬸", num))
                            {
                                format.SetAttr(450, Class576.smethod_76(class2.method_3()));
                            }
                            break;

                        case 40:
                            goto Label_0B20;

                        case 0x29:
                            goto Label_0B51;

                        case 0x2a:
                            format.SetAttr(770, smethod_5(str2));
                            break;
                    }
                }
            }
            continue;
        Label_04F5:
            flag4 = str2 == BookmarkStart.b("匦嬨帪䠬", num);
            if ((A_1.method_4() == BookmarkStart.b("圦䠨太䰬䠮䌰刲䔴弶", num)) && (A_1.method_0() == null))
            {
                A_0.method_9().Settings.bool_27 = flag4;
            }
            A_1.method_15().SetAttr(0x582, !flag4);
            continue;
        Label_05F1:
            if (str2 == BookmarkStart.b("䌦䘨帪伬䌮吰", num))
            {
                format.SetAttr(300, Class650.class650_1);
            }
            if (str2 == BookmarkStart.b("否䀨䔪䨬䌮吰", num))
            {
                format.SetAttr(80, Class650.class650_1);
            }
            continue;
        Label_067D:
            if (str2 == BookmarkStart.b("䤦䘨䔪䠬", num))
            {
                format.SetAttr(80, Class650.class650_0);
            }
            continue;
        Label_072E:
            if (strArray[0] == BookmarkStart.b("否尨䤪", num))
            {
                format.SetAttr(210, SubSuperScript.SubScript);
            }
        Label_0755:
            format.SetAttr(200, Class576.smethod_73(format, str2, num3));
            continue;
        Label_09A1:
            if (class2.method_3() == BookmarkStart.b("䈦䜨䰪弬丮䜰嘲儴", num))
            {
                format.SetAttr(180, Class650.class650_1);
            }
            if (class2.method_3() == BookmarkStart.b("䈦䐨䤪䈬尮䈰嘲儴", num))
            {
                format.SetAttr(170, Class650.class650_1);
            }
            continue;
        Label_09F9:
            if (class2.method_3() == BookmarkStart.b("䤦䘨䔪䠬", num))
            {
                format.SetAttr(130, Class650.class650_1);
            }
            if (class2.method_3() == BookmarkStart.b("匦嬨帪䠬", num))
            {
                format.SetAttr(130, Class650.class650_0);
            }
            continue;
        Label_0B20:
            if (class2.method_3() == BookmarkStart.b("䬦䀨䔪䠬Ȯ夰嘲尴倶儸伺", num))
            {
                if (class3 == null)
                {
                    class3 = smethod_1(A_0);
                }
                class3.method_7(true);
            }
            continue;
        Label_0B51:
            num2 = Class1041.smethod_23(str2) % 360;
            if (((num2 >= 0x2d) && (num2 < 180)) || ((num2 >= -315) && (num2 < -180)))
            {
                if (class3 == null)
                {
                    class3 = smethod_1(A_0);
                }
                class3.method_1(true);
            }
            if (class3 == null)
            {
                A_1.method_20(Class922.smethod_70(class2.method_3()));
            }
        }
        if (!flag)
        {
            format.SetAttr(80, Class650.class650_0);
            format.SetAttr(300, Class650.class650_0);
        }
        if ((str14 != string.Empty) || (str15 != string.Empty))
        {
            if (!(str14 == BookmarkStart.b("匦嬨帪䠬", num)) && !(str15 == BookmarkStart.b("匦嬨帪䠬", num)))
            {
                format.SetAttr(60, Class650.class650_0);
            }
            else
            {
                format.SetAttr(60, Class650.class650_1);
            }
        }
        if (flag2 || flag3)
        {
            format.SetAttr(70, Class650.class650_1);
        }
        if (class3 != null)
        {
            format.SetAttr(780, class3);
        }
        format.SetAttr(380, (short) Class922.smethod_81(string.Format(BookmarkStart.b("尦ᤨ嘪,吮0串", num), str3, str4)));
        format.SetAttr(390, (short) Class922.smethod_81(string.Format(BookmarkStart.b("尦ᤨ嘪,吮0串", num), str5, str6)));
        format.SetAttr(340, (short) Class922.smethod_81(string.Format(BookmarkStart.b("尦ᤨ嘪,吮0串", num), str7, str8)));
        if ((Class567.smethod_16(str9) || (str10 == BookmarkStart.b("否䈨䈪崬Ȯ䘰嬲尴䌶尸ᘺ丼伾⁀⁂⁄", num))) || (str12 == BookmarkStart.b("匦䄨䈪丬䐮", num)))
        {
            format.SetAttr(140, Class922.smethod_68(str9, str12, str10, str13));
        }
        return format;
    }

    private static Class340 smethod_1(Class857 A_0)
    {
        Class340 class2 = new Class340();
        class2.method_9(A_0.method_57());
        A_0.method_58(A_0.method_57() + 1);
        return class2;
    }

    private static short smethod_2(string A_0)
    {
        int num = 0x11;
        Regex regex = new Regex(BookmarkStart.b("椶戸଺ြؾ᱀桂歄᱆祈晊瑌቎筐癒煔", 0x11));
        if (!regex.IsMatch(A_0))
        {
            return 1;
        }
        if (((short) Class1041.smethod_11(A_0.Replace(BookmarkStart.b("ሶ", num), ""))) > 600)
        {
            return 600;
        }
        if (((short) Class1041.smethod_11(A_0.Replace(BookmarkStart.b("ሶ", num), ""))) < 1)
        {
            return 1;
        }
        return (short) Math.Round((double) float.Parse(A_0.Replace(BookmarkStart.b("ሶ", num), "")));
    }

    private static bool smethod_3(string A_0, Color A_1)
    {
        string[] strArray = A_0.Split(new char[] { ' ' });
        if (strArray.Length < 2)
        {
            return false;
        }
        if (!Class576.smethod_38(strArray[0]) || !Class576.smethod_38(strArray[1]))
        {
            return false;
        }
        if (strArray.Length == 3)
        {
            A_1 = Class576.smethod_76(strArray[2]);
        }
        else if (strArray.Length >= 4)
        {
            A_1 = Class576.smethod_76(strArray[3]);
            if (A_1 == Color.Empty)
            {
                A_1 = Class576.smethod_76(strArray[2]);
            }
        }
        if (A_1 == Color.Empty)
        {
            A_1 = Color.Black;
        }
        return true;
    }

    private static string smethod_4(string A_0)
    {
        int num = 0x11;
        Regex regex = new Regex(BookmarkStart.b("椶戸଺ြؾ᱀桂慄", 0x11));
        if (regex.IsMatch(A_0))
        {
            int num2 = int.Parse(A_0);
            if ((num2 >= 600) && (num2 <= 800))
            {
                return BookmarkStart.b("䌶䬸为堼", num);
            }
            return BookmarkStart.b("儶堸场丼娾", num);
        }
        if (!(A_0 == BookmarkStart.b("唶嘸场夼", num)))
        {
            return BookmarkStart.b("儶堸场丼娾", num);
        }
        return BookmarkStart.b("䌶䬸为堼", num);
    }

    private static Emphasis smethod_5(string A_0)
    {
        int num = 3;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䨨䈪弬䰮崰嘲ᔴ嘶嬸吺䬼娾", num))
            {
                return Emphasis.CircleAbove;
            }
            if (str == BookmarkStart.b("䨨䐪䀬䈮倰", num))
            {
                return Emphasis.CommaAbove;
            }
            if (str == BookmarkStart.b("䴨䐪夬༮倰儲娴䄶尸", num))
            {
                return Emphasis.Dot;
            }
            if ((str == BookmarkStart.b("尨䔪䤬䨮䌰眲娴䌶", num)) || (str == BookmarkStart.b("䴨䐪夬༮匰嘲头堶丸", num)))
            {
                return Emphasis.DotBelow;
            }
        }
        return Emphasis.None;
    }
}

