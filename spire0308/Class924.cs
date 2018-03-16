using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class924
{
    private Class924()
    {
    }

    internal static bool smethod_0(Class581 A_0, ParagraphFormat A_1, CharacterFormat A_2)
    {
        int num = 0x13;
        bool flag = false;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("䤸欺似", num)))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num4;
                if (Class1160.dictionary_196 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x24);
                    dictionary1.Add(BookmarkStart.b("䤸栺䤼䘾ⵀ♂", num), 0);
                    dictionary1.Add(BookmarkStart.b("券帺堼伾ཀ♂㵄㍆", num), 1);
                    dictionary1.Add(BookmarkStart.b("券帺堼伾ീ⩂⭄≆㩈", num), 2);
                    dictionary1.Add(BookmarkStart.b("䤸娺娼娾̀ㅂ⁄♆≈ॊ⡌⥎㹐⅒ご", num), 3);
                    dictionary1.Add(BookmarkStart.b("弸䤺尼刾⑀ፂ㝄", num), 4);
                    dictionary1.Add(BookmarkStart.b("丸刺夼倾㙀B⩄⥆㵈㥊≌⍎", num), 5);
                    dictionary1.Add(BookmarkStart.b("圸为值漾㍀", num), 6);
                    dictionary1.Add(BookmarkStart.b("唸刺丼䬾ᅀㅂ", num), 7);
                    dictionary1.Add(BookmarkStart.b("䨸为䴼伾㍀♂㙄㑆Ո≊⍌⩎ὐ♒㡔㕖㱘⥚⹜", num), 8);
                    dictionary1.Add(BookmarkStart.b("䨸为䴼䴾⑀あ㙄୆⁈╊⡌Ŏ⑐㹒㝔㉖⭘⡚", num), 9);
                    dictionary1.Add(BookmarkStart.b("䤸示夼䴾", num), 10);
                    dictionary1.Add(BookmarkStart.b("䨸区夼", num), 11);
                    dictionary1.Add(BookmarkStart.b("䴸娺弼䰾", num), 12);
                    dictionary1.Add(BookmarkStart.b("䨸为䴼伾㍀♂㙄㑆ࡈ㹊㥌⁎ᥐ⩒╔㽖㱘㕚⹜", num), 13);
                    dictionary1.Add(BookmarkStart.b("券刺匼䰾⹀⡂い", num), 14);
                    dictionary1.Add(BookmarkStart.b("丸吺似嬾ᙀㅂ⑄㝆", num), 15);
                    dictionary1.Add(BookmarkStart.b("嘸䴺堼䴾❀⽂⩄う᥈㹊⍌ⱎ═", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䴸吺䴼猾⡀ⵂ⁄ᝆ㱈╊⹌㭎", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("堸为䤼倾ቀ㍂⑄⑆ⱈཊࡌ", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("堸为䤼倾ቀ㍂⑄⑆ⱈཊ͌", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("嬸刺夼嘾", num), 20);
                    dictionary1.Add(BookmarkStart.b("堸强圼䨾㉀㝂ᝄ⹆⹈⍊㥌َ㽐㝒", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䨸唺尼伾ᕀⱂɄ㕆⁈⽊", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䨸䬺尼尾⡀ⵂ≄", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("倸唺夼", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("娸吺匼䬾⑀㭂ㅄ㉆⡈❊Ṍ㽎ぐげ㱔㥖㹘", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("䨸为䴼伾㍀♂㙄㑆و㵊⡌㵎㵐㉒╔", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("匸堺", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("䴸帺䔼䬾Հ⩂㝄≆⩈㽊⑌⁎㽐", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("䴸帺䔼䬾@⽂ⱄ⁆❈♊⡌ⅎ═", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("嘸为䤼匾⡀ⵂ⁄୆㽈❊", num), 30);
                    dictionary1.Add(BookmarkStart.b("䬸欺似", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("䨸帺帼䬾ᅀㅂ", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("䤸欺似簾⥀≂⭄⁆ⱈ", num), 0x21);
                    dictionary1.Add(BookmarkStart.b("堸唺匼倾㕀≂ㅄ⹆♈╊", num), 0x22);
                    dictionary1.Add(BookmarkStart.b("吸刺似䴾⹀ㅂౄ⥆ⵈ⹊⍌㭎≐", num), 0x23);
                    Class1160.dictionary_196 = dictionary1;
                }
                if (Class1160.dictionary_196.TryGetValue(key, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                        {
                            string str = class2.method_28();
                            int num3 = A_0.Interface58.imethod_0(str, 0);
                            A_1.SetAttr(0x3e8, num3);
                            if (!string.IsNullOrEmpty(str))
                            {
                                str = str.Trim();
                                if ((A_1.OwnerBase is Paragraph) && A_1.OwnerBase.Document.StyleNameIds.ContainsKey(str))
                                {
                                    IParagraphStyle style = A_1.OwnerBase.Document.Styles.FindByName(A_1.OwnerBase.Document.StyleNameIds[str], StyleType.ParagraphStyle) as IParagraphStyle;
                                    if (style != null)
                                    {
                                        A_1.SetAttr(0x3e8, (style as Style).Istd);
                                        (A_1.OwnerBase as Paragraph).method_65(style);
                                    }
                                }
                            }
                            continue;
                        }
                        case 1:
                        {
                            A_1.SetAttr(0x41a, class2.method_31());
                            continue;
                        }
                        case 2:
                        {
                            A_1.SetAttr(0x410, class2.method_31());
                            continue;
                        }
                        case 3:
                        {
                            A_1.SetAttr(0x424, class2.method_31());
                            continue;
                        }
                        case 4:
                        {
                            smethod_1(class2, A_1);
                            continue;
                        }
                        case 5:
                        {
                            A_1.SetAttr(0x5be, class2.method_31());
                            continue;
                        }
                        case 6:
                        case 7:
                        {
                            smethod_7(A_0, A_1);
                            continue;
                        }
                        case 8:
                        case 9:
                        {
                            A_1.SetAttr(0x46a, class2.method_31());
                            continue;
                        }
                        case 10:
                        {
                            smethod_6(class2, A_1);
                            continue;
                        }
                        case 11:
                        {
                            A_1.SetAttr(0x5b4, class2.method_39());
                            continue;
                        }
                        case 12:
                        {
                            smethod_5(class2, A_1);
                            continue;
                        }
                        case 13:
                        {
                            A_1.SetAttr(0x582, class2.method_31());
                            continue;
                        }
                        case 14:
                        {
                            A_1.SetAttr(0x42e, class2.method_31());
                            continue;
                        }
                        case 15:
                        {
                            A_1.SetAttr(0x438, class2.method_31());
                            continue;
                        }
                        case 0x10:
                        {
                            A_1.SetAttr(0x442, class2.method_31());
                            continue;
                        }
                        case 0x11:
                        {
                            A_1.SetAttr(0x44c, class2.method_31());
                            continue;
                        }
                        case 0x12:
                        {
                            A_1.SetAttr(0x4d8, class2.method_31());
                            continue;
                        }
                        case 0x13:
                        {
                            A_1.SetAttr(0x4e2, class2.method_31());
                            continue;
                        }
                        case 20:
                        {
                            A_1.SetAttr(0x618, class2.method_31());
                            continue;
                        }
                        case 0x15:
                        {
                            A_1.SetAttr(0x4f6, class2.method_31());
                            continue;
                        }
                        case 0x16:
                        {
                            A_1.SetAttr(0x4ec, class2.method_31());
                            continue;
                        }
                        case 0x17:
                        {
                            smethod_3(class2, A_1);
                            continue;
                        }
                        case 0x18:
                        {
                            smethod_2(class2, A_1);
                            continue;
                        }
                        case 0x19:
                        {
                            A_1.SetAttr(0x3fe, class2.method_31());
                            continue;
                        }
                        case 0x1a:
                        {
                            A_1.SetAttr(0x67c, class2.method_31());
                            continue;
                        }
                        case 0x1b:
                        {
                            A_1.SetAttr(0x3fc, Class248.smethod_18(class2.method_28(), false));
                            continue;
                        }
                        case 0x1c:
                        {
                            A_1.SetAttr(0x5c8, Class417.smethod_38(class2.method_28()));
                            continue;
                        }
                        case 0x1d:
                        {
                            A_1.SetAttr(0x5e6, Class248.smethod_0(class2.method_28()));
                            continue;
                        }
                        case 30:
                        {
                            int num2 = class2.method_29();
                            A_1.SetAttr(0x500, ((num2 < 0) || (num2 > 9)) ? ((byte) 9) : ((byte) ((OutlineLevel) Enum.ToObject(typeof(OutlineLevel), num2))));
                            continue;
                        }
                        case 0x1f:
                        {
                            Class733.smethod_0(A_0, A_2);
                            continue;
                        }
                        case 0x20:
                        {
                            Class980.smethod_0(A_0, ((Paragraph) A_0.method_13()).method_49());
                            flag = true;
                            continue;
                        }
                        case 0x21:
                        {
                            continue;
                        }
                        case 0x22:
                        {
                            Class519.smethod_7(A_0, A_1, A_2);
                            continue;
                        }
                        case 0x23:
                        {
                            A_1.SetAttr(0x479, class2.method_31());
                            continue;
                        }
                    }
                }
            }
            Class733.smethod_1(A_0, A_2);
        }
        return flag;
    }

    internal static void smethod_1(Class394 A_0, ParagraphFormat A_1)
    {
        int num = 6;
        while (A_0.method_19())
        {
            HorizontalPosition position;
            VerticalPosition position2;
            string key = A_0.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_197 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x18);
                    dictionary1.Add(BookmarkStart.b("䠫尭弯䈱眳圵䠷", num), 0);
                    dictionary1.Add(BookmarkStart.b("䠫尭弯䈱ᤳ唵夷䨹", num), 1);
                    dictionary1.Add(BookmarkStart.b("䀫䜭帯圱䜳", num), 2);
                    dictionary1.Add(BookmarkStart.b("嬫", num), 3);
                    dictionary1.Add(BookmarkStart.b("䐫", num), 4);
                    dictionary1.Add(BookmarkStart.b("娫紭䀯匱圳匵", num), 5);
                    dictionary1.Add(BookmarkStart.b("娫崭䀯匱圳匵", num), 6);
                    dictionary1.Add(BookmarkStart.b("䐫紭䀯匱圳匵", num), 7);
                    dictionary1.Add(BookmarkStart.b("䐫崭䀯匱圳匵", num), 8);
                    dictionary1.Add(BookmarkStart.b("嬫尭儯䈱", num), 9);
                    dictionary1.Add(BookmarkStart.b("䐫漭帯儱尳夵䨷", num), 10);
                    dictionary1.Add(BookmarkStart.b("䐫伭帯儱尳夵䨷", num), 11);
                    dictionary1.Add(BookmarkStart.b("娫漭帯儱尳夵䨷", num), 12);
                    dictionary1.Add(BookmarkStart.b("娫伭帯儱尳夵䨷", num), 13);
                    dictionary1.Add(BookmarkStart.b("含", num), 14);
                    dictionary1.Add(BookmarkStart.b("唫", num), 15);
                    dictionary1.Add(BookmarkStart.b("含漭尯嬱匳堵", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("含̭儯帱崳儵嘷", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("唫漭尯嬱匳堵", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("唫̭儯帱崳儵嘷", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䐫簭䔯帱儳", num), 20);
                    dictionary1.Add(BookmarkStart.b("䐫̭䈯䜱堳匵", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䴫䀭匯娱嬳䐵琷唹弻唽", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䴫䀭匯娱嬳䐵ᔷ嘹医崽⬿", num), 0x17);
                    Class1160.dictionary_197 = dictionary1;
                }
                if (Class1160.dictionary_197.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                            A_1.DropCapPosition = Class248.smethod_2(A_0.method_3());
                            break;

                        case 2:
                            A_1.DropCapLinesToDrop = A_0.method_4();
                            break;

                        case 3:
                            A_1.FrameWidth = (short) A_0.method_61();
                            break;

                        case 4:
                            A_1.FrameHeight = (short) A_0.method_61();
                            break;

                        case 5:
                        case 6:
                            A_1.FrameVerticalDistanceFromText = (short) A_0.method_61();
                            break;

                        case 7:
                        case 8:
                            A_1.FrameHorizontalDistanceFromText = (short) A_0.method_61();
                            break;

                        case 9:
                            A_1.FrameWrapType = Class248.smethod_12(A_0.method_3());
                            break;

                        case 10:
                        case 11:
                        {
                            string str = A_0.method_3();
                            if ((str != null) && (str != ""))
                            {
                                A_1.Frame.method_82(Class248.smethod_8(str));
                            }
                            break;
                        }
                        case 12:
                        case 13:
                        {
                            string str3 = A_0.method_3();
                            if ((str3 != null) && (str3 != ""))
                            {
                                A_1.Frame.method_85(Class248.smethod_10(str3));
                            }
                            break;
                        }
                        case 14:
                            A_1.FrameX = (short) A_0.method_61();
                            break;

                        case 15:
                            A_1.FrameY = (short) A_0.method_61();
                            break;

                        case 0x10:
                        case 0x11:
                            goto Label_0384;

                        case 0x12:
                        case 0x13:
                            goto Label_03BC;

                        case 20:
                        case 0x15:
                            A_1.FrameHeightRule = Class248.smethod_14(A_0.method_3());
                            break;

                        case 0x16:
                            A_1.Frame.SetAttr(5, A_0.method_63());
                            break;

                        case 0x17:
                            A_1.Frame.SetAttr(5, A_0.method_63());
                            break;
                    }
                }
            }
            continue;
        Label_0384:
            position = Class248.smethod_6(A_0.method_3());
            if ((position != HorizontalPosition.None) || (A_0.method_3().ToLower() == BookmarkStart.b("䈫䄭帯圱", num)))
            {
                A_1.FrameHorizontalPosition = position;
            }
            continue;
        Label_03BC:
            position2 = Class248.smethod_4(A_0.method_3());
            if ((position2 != VerticalPosition.None) || (A_0.method_3().ToLower() == BookmarkStart.b("䈫䄭帯圱", num)))
            {
                A_1.FrameVerticalPosition = position2;
            }
        }
        if (A_1.method_55(0x58c) && !A_1.method_55(0x596))
        {
            A_1.SetAttr(0x596, FrameSizeRule.AtLeast);
        }
    }

    internal static void smethod_2(Class394 A_0, ParagraphFormat A_1)
    {
        int num = 8;
        while (A_0.method_19())
        {
            string key = A_0.method_1();
            if (key != null)
            {
                int num6;
                if (Class1160.dictionary_198 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x11);
                    dictionary1.Add(BookmarkStart.b("䈭唯吱䀳", num), 0);
                    dictionary1.Add(BookmarkStart.b("崭䐯匱䘳䈵", num), 1);
                    dictionary1.Add(BookmarkStart.b("尭夯唱尳䈵", num), 2);
                    dictionary1.Add(BookmarkStart.b("䬭帯嘱", num), 3);
                    dictionary1.Add(BookmarkStart.b("䠭夯䀱䜳䈵琷匹刻嬽", num), 4);
                    dictionary1.Add(BookmarkStart.b("䠭夯䀱䜳䈵ᔷ嘹唻倽┿", num), 5);
                    dictionary1.Add(BookmarkStart.b("䘭儯就匳張嘷崹", num), 6);
                    dictionary1.Add(BookmarkStart.b("䈭唯吱䀳电倷嬹主䴽", num), 7);
                    dictionary1.Add(BookmarkStart.b("䈭唯吱䀳ᬵ嬷刹崻䰽㌿", num), 8);
                    dictionary1.Add(BookmarkStart.b("崭䐯匱䘳䈵笷刹崻䰽㌿", num), 9);
                    dictionary1.Add(BookmarkStart.b("尭夯唱尳䈵笷刹崻䰽㌿", num), 10);
                    dictionary1.Add(BookmarkStart.b("尭夯唱尳䈵ᔷ夹吻弽㈿ㅁ", num), 11);
                    dictionary1.Add(BookmarkStart.b("䬭帯嘱眳帵夷䠹伻", num), 12);
                    dictionary1.Add(BookmarkStart.b("䠭夯䀱䜳䈵琷匹刻嬽̿⩁╃㑅㭇", num), 13);
                    dictionary1.Add(BookmarkStart.b("䠭夯䀱䜳䈵ᔷ嘹唻倽┿潁❃⹅⥇㡉㽋", num), 14);
                    dictionary1.Add(BookmarkStart.b("䘭儯就匳張嘷崹缻嘽ℿぁ㝃", num), 15);
                    dictionary1.Add(BookmarkStart.b("䘭儯就匳張嘷崹ᄻ崽⠿⍁㙃㕅", num), 0x10);
                    Class1160.dictionary_198 = dictionary1;
                }
                if (Class1160.dictionary_198.TryGetValue(key, out num6))
                {
                    switch (num6)
                    {
                        case 0:
                        case 1:
                        {
                            float num7 = A_0.method_69(20f);
                            if (num7 != float.MaxValue)
                            {
                                A_1.SetAttr(0x488, num7);
                            }
                            break;
                        }
                        case 2:
                        case 3:
                        {
                            float num5 = A_0.method_69(20f);
                            if (num5 != float.MaxValue)
                            {
                                A_1.SetAttr(0x47e, num5);
                            }
                            break;
                        }
                        case 4:
                        case 5:
                        {
                            float num10 = A_0.method_69(20f);
                            if (num10 != float.MaxValue)
                            {
                                A_1.SetAttr(0x492, num10);
                            }
                            break;
                        }
                        case 6:
                        {
                            float num3 = A_0.method_69(20f);
                            if (num3 != float.MaxValue)
                            {
                                A_1.SetAttr(0x492, -num3);
                            }
                            break;
                        }
                        case 7:
                        case 8:
                        case 9:
                        {
                            float num9 = A_0.method_69(100f);
                            if (num9 != float.MaxValue)
                            {
                                A_1.SetAttr(0x48d, num9);
                            }
                            break;
                        }
                        case 10:
                        case 11:
                        case 12:
                        {
                            float num2 = A_0.method_69(100f);
                            if (num2 != float.MaxValue)
                            {
                                A_1.SetAttr(0x483, num2);
                            }
                            break;
                        }
                        case 13:
                        case 14:
                        {
                            float num8 = A_0.method_69(100f);
                            if (num8 != float.MaxValue)
                            {
                                A_1.SetAttr(0x497, num8);
                            }
                            break;
                        }
                        case 15:
                        case 0x10:
                        {
                            float num4 = A_0.method_69(100f);
                            if (num4 != float.MaxValue)
                            {
                                A_1.SetAttr(0x497, -num4);
                            }
                            break;
                        }
                    }
                }
            }
        }
    }

    internal static void smethod_3(Class394 A_0, ParagraphFormat A_1)
    {
        int num = 6;
        while (A_0.method_19())
        {
            string key = A_0.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_199 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                    dictionary1.Add(BookmarkStart.b("丫䬭嘯崱䘳匵", num), 0);
                    dictionary1.Add(BookmarkStart.b("丫䬭嘯崱䘳匵琷匹刻嬽㌿", num), 1);
                    dictionary1.Add(BookmarkStart.b("丫䬭嘯崱䘳匵ᔷ嘹唻倽┿ㅁ", num), 2);
                    dictionary1.Add(BookmarkStart.b("丫䬭嘯崱䘳匵礷伹䠻儽㌿㉁╃╅ⅇ⑉⭋", num), 3);
                    dictionary1.Add(BookmarkStart.b("丫䬭嘯崱䘳匵ᔷ嬹䤻䨽⼿ㅁ㑃❅⭇⍉≋⥍", num), 4);
                    dictionary1.Add(BookmarkStart.b("䴫䠭䐯圱䘳", num), 5);
                    dictionary1.Add(BookmarkStart.b("䴫䠭䐯圱䘳稵儷吹夻䴽", num), 6);
                    dictionary1.Add(BookmarkStart.b("䴫䠭䐯圱䘳ᬵ吷匹刻嬽㌿", num), 7);
                    dictionary1.Add(BookmarkStart.b("䴫䠭䐯圱䘳眵䴷丹医䴽〿⍁❃⽅♇ⵉ", num), 8);
                    dictionary1.Add(BookmarkStart.b("䴫䠭䐯圱䘳ᬵ夷伹䠻儽㌿㉁╃╅ⅇ⑉⭋", num), 9);
                    dictionary1.Add(BookmarkStart.b("䀫䜭帯圱", num), 10);
                    dictionary1.Add(BookmarkStart.b("䀫䜭帯圱昳䌵吷弹", num), 11);
                    dictionary1.Add(BookmarkStart.b("䀫䜭帯圱ᤳ䐵䴷嘹夻", num), 12);
                    Class1160.dictionary_199 = dictionary1;
                }
                if (Class1160.dictionary_199.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            float num6 = A_0.method_69(20f);
                            if (num6 != float.MaxValue)
                            {
                                smethod_4(A_1, 0x4b0, num6);
                            }
                            break;
                        }
                        case 1:
                        case 2:
                        {
                            float num5 = A_0.method_69(100f);
                            if (num5 != float.MaxValue)
                            {
                                A_1.SetAttr(0x4b5, num5);
                            }
                            break;
                        }
                        case 3:
                        case 4:
                            A_1.SetAttr(0x4ba, A_0.method_63());
                            break;

                        case 5:
                        {
                            float num7 = A_0.method_69(20f);
                            if (num7 != float.MaxValue)
                            {
                                smethod_4(A_1, 0x4c4, num7);
                            }
                            break;
                        }
                        case 6:
                        case 7:
                        {
                            float num4 = A_0.method_69(100f);
                            if (num4 != float.MaxValue)
                            {
                                A_1.SetAttr(0x4c9, num4);
                            }
                            break;
                        }
                        case 8:
                        case 9:
                            A_1.SetAttr(0x4ce, A_0.method_63());
                            break;

                        case 10:
                        {
                            float num3 = A_0.method_69(20f);
                            if (num3 != float.MaxValue)
                            {
                                A_1.LineSpacing = Math.Abs(num3);
                            }
                            break;
                        }
                        case 11:
                        case 12:
                            A_1.LineSpacingRule = Class248.smethod_16(A_0.method_3());
                            break;
                    }
                }
            }
        }
    }

    private static void smethod_4(ParagraphFormat A_0, int A_1, float A_2)
    {
        if (A_2 >= 0f)
        {
            A_0.SetAttr(A_1, A_2);
        }
    }

    internal static void smethod_5(Class394 A_0, ParagraphFormat A_1)
    {
        int num = 0x10;
        TabCollection tabs = A_1.Tabs;
        while (A_0.method_9(BookmarkStart.b("䈵夷堹伻", num)))
        {
            string str2;
            if (((str2 = A_0.method_1()) == null) || !(str2 == BookmarkStart.b("䈵夷堹", num)))
            {
                continue;
            }
            Tab tab = null;
            TabJustification clear = TabJustification.Clear;
            TabLeader noLeader = TabLeader.NoLeader;
            while (A_0.method_19())
            {
                string str = A_0.method_1();
                if (str == null)
                {
                    continue;
                }
                if (str == BookmarkStart.b("䀵夷嘹", num))
                {
                    goto Label_013E;
                }
                if (str == BookmarkStart.b("娵崷嬹堻嬽㈿", num))
                {
                    goto Label_012F;
                }
                if (!(str == BookmarkStart.b("䘵圷䤹", num)))
                {
                    continue;
                }
                float num2 = A_0.method_62();
                if (num2 == float.MaxValue)
                {
                    continue;
                }
                using (IEnumerator enumerator = tabs.GetEnumerator())
                {
                    Tab current;
                    while (enumerator.MoveNext())
                    {
                        current = (Tab) enumerator.Current;
                        if (current.Position == num2)
                        {
                            goto Label_00DB;
                        }
                    }
                    goto Label_00F5;
                Label_00DB:
                    tab = current;
                }
            Label_00F5:
                if (tab == null)
                {
                    tab = tabs.AddTab();
                }
                if (clear == TabJustification.Clear)
                {
                    tab.Justification = TabJustification.Left;
                    tab.DeletePosition = num2 * 20f;
                    tab.Position = 0f;
                }
                else
                {
                    tab.Position = num2;
                }
                continue;
            Label_012F:
                noLeader = Class248.smethod_20(A_0.method_3());
                continue;
            Label_013E:
                A_0.method_3();
                clear = Class248.smethod_22(A_0.method_3());
            }
            if (clear != TabJustification.Clear)
            {
                tab.Justification = clear;
            }
            tab.TabLeader = noLeader;
        }
    }

    internal static void smethod_6(Class394 A_0, ParagraphFormat A_1)
    {
        int num = 13;
        while (A_0.method_9(BookmarkStart.b("䌲眴匶䬸", num)))
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䜲娴䜶", num))
                {
                    if (str != BookmarkStart.b("弲倴儶䴸", num))
                    {
                        if (str != BookmarkStart.b("儲娴䌶䴸吺值", num))
                        {
                            if (str != BookmarkStart.b("䄲尴倶儸伺", num))
                            {
                                if (!(str == BookmarkStart.b("儲倴䌶丸帺堼儾", num)))
                                {
                                    if (str == BookmarkStart.b("儲吴䔶", num))
                                    {
                                        A_0.method_36(A_1.Borders.Vertical);
                                    }
                                }
                                else
                                {
                                    A_0.method_36(A_1.Borders.Horizontal);
                                }
                            }
                            else
                            {
                                A_0.method_36(A_1.Borders.Right);
                            }
                        }
                        else
                        {
                            A_0.method_36(A_1.Borders.Bottom);
                        }
                    }
                    else
                    {
                        A_0.method_36(A_1.Borders.Left);
                    }
                }
                else
                {
                    A_0.method_36(A_1.Borders.Top);
                }
            }
        }
        A_1.SetAttr(20, A_1.Borders);
    }

    internal static void smethod_7(Class581 A_0, ParagraphFormat A_1)
    {
        int num = 0x11;
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_1();
        ListFormat listFormat = null;
        if (A_1.OwnerBase is Paragraph)
        {
            listFormat = (A_1.OwnerBase as Paragraph).ListFormat;
        }
        else if (A_1.OwnerBase is ParagraphStyle)
        {
            listFormat = (A_1.OwnerBase as ParagraphStyle).ListFormat;
        }
        else if (A_1.OwnerBase is Class13)
        {
            listFormat = (A_1.OwnerBase as Class13).method_23();
        }
        while (class2.method_9(str))
        {
            string str3;
            int num2;
            int num3;
            string key = class2.method_1();
            if (key != null)
            {
                int num4;
                if (Class1160.dictionary_200 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                    dictionary1.Add(BookmarkStart.b("帶唸䴺儼", num), 0);
                    dictionary1.Add(BookmarkStart.b("夶䰸嘺琼嬾", num), 1);
                    dictionary1.Add(BookmarkStart.b("帶唸崺刼", num), 2);
                    dictionary1.Add(BookmarkStart.b("帶圸䠺", num), 3);
                    dictionary1.Add(BookmarkStart.b("夶䰸嘺弼娾㍀⩂⭄⁆ੈ⍊ⱌⅎ㙐㙒", num), 4);
                    dictionary1.Add(BookmarkStart.b("嘶圸唺刼䬾⁀㝂ⱄ⡆❈", num), 5);
                    dictionary1.Add(BookmarkStart.b("䌶", num), 6);
                    dictionary1.Add(BookmarkStart.b("儶嘸唺䤼", num), 7);
                    Class1160.dictionary_200 = dictionary1;
                }
                if (Class1160.dictionary_200.TryGetValue(key, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                            goto Label_017A;

                        case 1:
                        case 2:
                        {
                            num2 = class2.method_29();
                            str3 = num2.ToString();
                            A_1.SetAttr(0x460, num2);
                            if (num2 != 0)
                            {
                                goto Label_01EC;
                            }
                            listFormat.IsEmptyList = true;
                            continue;
                        }
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        {
                            continue;
                        }
                    }
                }
            }
            goto Label_02E2;
        Label_017A:
            num3 = class2.method_29();
            if (num3 < 0)
            {
                num3 = 0x100 + num3;
            }
            if (num3 > 8)
            {
                num3 = 8;
            }
            A_1.SetAttr(0x456, (byte) num3);
            listFormat.ListLevelNumber = num3;
            continue;
        Label_01EC:
            if (A_0.method_20().ContainsKey(str3))
            {
                string name = A_0.method_20()[str3];
                ListStyle style = A_0.Interface50.imethod_0().ListStyles.FindByName(name);
                if (((A_0.method_20() != null) && (style.BaseListStyleName != null)) && ((style.BaseListStyleName != string.Empty) && A_0.method_20().ContainsKey(style.BaseListStyleName)))
                {
                    string str2 = A_0.method_20()[style.BaseListStyleName];
                    if (A_0.method_20().ContainsKey(str2))
                    {
                        name = A_0.method_20()[str2];
                    }
                }
                if (name != null)
                {
                    listFormat.ApplyStyle(name);
                }
                if (A_0.method_21().ContainsKey(num2))
                {
                    listFormat.LFOStyleName = A_0.method_21()[num2].ToString();
                }
                listFormat.ApplyStyle(A_0.method_20()[str3].ToString());
            }
            continue;
        Label_02E2:
            class2.vmethod_1();
        }
    }
}

