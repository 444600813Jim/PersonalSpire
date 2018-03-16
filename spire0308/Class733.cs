using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

internal class Class733
{
    private Class733()
    {
    }

    internal static void smethod_0(Class581 A_0, CharacterFormat A_1)
    {
        int num = 0x11;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("䔶椸䤺", num)))
        {
            smethod_1(A_0, A_1);
        }
    }

    internal static void smethod_1(Class581 A_0, CharacterFormat A_1)
    {
        int num = 1;
        Class394 class2 = A_0.imethod_1();
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_126 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x2b);
                dictionary1.Add(BookmarkStart.b("唦稨弪听䌮吰", num), 0);
                dictionary1.Add(BookmarkStart.b("唦漨䐪䌬嬮䈰", num), 1);
                dictionary1.Add(BookmarkStart.b("䄦䘨䔪夬", num), 2);
                dictionary1.Add(BookmarkStart.b("䔦", num), 3);
                dictionary1.Add(BookmarkStart.b("䔦Ш䠪帬", num), 4);
                dictionary1.Add(BookmarkStart.b("並", num), 5);
                dictionary1.Add(BookmarkStart.b("並Ш䠪帬", num), 6);
                dictionary1.Add(BookmarkStart.b("䐦䠨嬪帬", num), 7);
                dictionary1.Add(BookmarkStart.b("否䐨䨪䄬䌮爰刲䔴䐶", num), 8);
                dictionary1.Add(BookmarkStart.b("否崨太䐬䐮吰", num), 9);
                dictionary1.Add(BookmarkStart.b("䌦娨弪弬䘮娰嘲", num), 10);
                dictionary1.Add(BookmarkStart.b("䠦尨弪䄬䘮弰嘲", num), 11);
                dictionary1.Add(BookmarkStart.b("否䄨䨪䤬䀮䘰", num), 12);
                dictionary1.Add(BookmarkStart.b("䈦䐨䤪䈬尮䈰", num), 13);
                dictionary1.Add(BookmarkStart.b("並䐨嬪弬䘮弰䜲", num), 14);
                dictionary1.Add(BookmarkStart.b("䤦䘨笪弬䀮帰唲", num), 15);
                dictionary1.Add(BookmarkStart.b("儦䠨䔪䐬尮夰", num), 0x10);
                dictionary1.Add(BookmarkStart.b("否䜨䨪崬笮帰琲䜴帶崸", num), 0x11);
                dictionary1.Add(BookmarkStart.b("倦䰨䤪攬䘮唰圲倴夶", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䐦䘨䜪䈬崮", num), 0x13);
                dictionary1.Add(BookmarkStart.b("否夨䨪丬䘮弰吲", num), 20);
                dictionary1.Add(BookmarkStart.b("倦", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䰦䰨太䌬", num), 0x16);
                dictionary1.Add(BookmarkStart.b("圦䘨堪䐬嬮堰尲嬴", num), 0x17);
                dictionary1.Add(BookmarkStart.b("否匨", num), 0x18);
                dictionary1.Add(BookmarkStart.b("否匨ت丬尮", num), 0x19);
                dictionary1.Add(BookmarkStart.b("伦䀨䰪䔬䌮堰吲崴䌶", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("刦", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䈦伨䴪䠬䰮䔰", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("䔦䴨太", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("否䄨伪", num), 30);
                dictionary1.Add(BookmarkStart.b("䄦䀨弪礬䨮䤰䜲", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("儦䰨太夬渮崰娲刴夶", num), 0x20);
                dictionary1.Add(BookmarkStart.b("唦崨䜪", num), 0x21);
                dictionary1.Add(BookmarkStart.b("䐦娨", num), 0x22);
                dictionary1.Add(BookmarkStart.b("䈦䐨", num), 0x23);
                dictionary1.Add(BookmarkStart.b("伦倨嬪䔬䨮弰", num), 0x24);
                dictionary1.Add(BookmarkStart.b("䬦䠨䔪䨬", num), 0x25);
                dictionary1.Add(BookmarkStart.b("䘦娨䈪䰬䄮細刲䰴堶䰸伺", num), 0x26);
                dictionary1.Add(BookmarkStart.b("否夨个丬礮倰崲尴䐶儸", num), 0x27);
                dictionary1.Add(BookmarkStart.b("否倨䘪", num), 40);
                dictionary1.Add(BookmarkStart.b("䘦䜨䔪䈬嬮倰䜲尴堶圸", num), 0x29);
                dictionary1.Add(BookmarkStart.b("䀦嬨䈪䤬簮䄰刲嬴", num), 0x2a);
                Class1160.dictionary_126 = dictionary1;
            }
            if (Class1160.dictionary_126.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    {
                        string str4 = class2.method_28();
                        if (A_0.Interface50.imethod_0().StyleNameIds.ContainsKey(str4))
                        {
                            A_1.CharStyleName = A_0.Interface50.imethod_0().StyleNameIds[str4];
                        }
                        return;
                    }
                    case 1:
                        smethod_4(A_1, class2);
                        return;

                    case 2:
                        if (!A_1.method_72(230))
                        {
                            A_1.SetAttr(230, class2.method_28());
                        }
                        return;

                    case 3:
                        A_1.SetAttr(60, class2.method_32());
                        return;

                    case 4:
                        A_1.SetAttr(250, class2.method_32());
                        return;

                    case 5:
                        A_1.SetAttr(70, class2.method_32());
                        return;

                    case 6:
                        A_1.SetAttr(260, class2.method_32());
                        return;

                    case 7:
                        A_1.SetAttr(120, class2.method_32());
                        return;

                    case 8:
                        A_1.SetAttr(110, class2.method_32());
                        return;

                    case 9:
                        A_1.SetAttr(80, class2.method_32());
                        return;

                    case 10:
                        A_1.SetAttr(300, class2.method_32());
                        return;

                    case 11:
                        A_1.SetAttr(90, class2.method_32());
                        return;

                    case 12:
                        A_1.SetAttr(100, class2.method_32());
                        return;

                    case 13:
                        A_1.SetAttr(170, class2.method_32());
                        return;

                    case 14:
                        A_1.SetAttr(180, class2.method_32());
                        return;

                    case 15:
                        A_1.SetAttr(440, class2.method_32());
                        return;

                    case 0x10:
                        A_1.SetAttr(130, class2.method_32());
                        return;

                    case 0x11:
                        A_1.SetAttr(330, class2.method_32());
                        return;

                    case 0x12:
                        A_1.SetAttr(0x84, class2.method_32());
                        return;

                    case 0x13:
                    {
                        string str3 = class2.method_28();
                        if (str3 != null)
                        {
                            A_1.SetAttr(160, Class114.smethod_13(str3));
                        }
                        return;
                    }
                    case 20:
                    {
                        float num3 = class2.method_29();
                        if (num3 != float.MaxValue)
                        {
                            A_1.SetAttr(150, num3 / 20f);
                        }
                        return;
                    }
                    case 0x15:
                    {
                        string str6 = class2.method_28();
                        if (!string.IsNullOrEmpty(str6))
                        {
                            short num5 = short.Parse(str6.Replace(BookmarkStart.b("Ȧ", num), string.Empty), NumberStyles.Integer, CultureInfo.InvariantCulture);
                            A_1.SetAttr(290, num5);
                        }
                        return;
                    }
                    case 0x16:
                        A_1.SetAttr(220, float.Parse(class2.method_29().ToString(), NumberStyles.Number, CultureInfo.InvariantCulture) / 2f);
                        return;

                    case 0x17:
                        A_1.SetAttr(200, ((float) class2.method_29()) / 2f);
                        return;

                    case 0x18:
                    {
                        string s = class2.method_28();
                        if (s != null)
                        {
                            A_1.SetAttr(190, float.Parse(s, NumberStyles.Number, CultureInfo.InvariantCulture) / 2f);
                        }
                        return;
                    }
                    case 0x19:
                    {
                        string str5 = class2.method_28();
                        if (str5 != null)
                        {
                            A_1.SetAttr(350, float.Parse(str5, NumberStyles.Number, CultureInfo.InvariantCulture) / 2f);
                        }
                        return;
                    }
                    case 0x1a:
                    {
                        Color color = Class860.smethod_19(class2.method_28());
                        if (color != Color.Empty)
                        {
                            A_1.SetAttr(20, color);
                        }
                        return;
                    }
                    case 0x1b:
                        smethod_5(A_1, class2);
                        return;

                    case 0x1c:
                        A_1.SetAttr(310, Class860.smethod_15(class2.method_28()));
                        return;

                    case 0x1d:
                        class2.method_36(A_1.Border);
                        return;

                    case 30:
                        A_1.SetAttr(370, class2.method_39());
                        return;

                    case 0x1f:
                        class2.vmethod_1();
                        return;

                    case 0x20:
                        A_1.SetAttr(210, Class860.smethod_21(class2.method_28()));
                        return;

                    case 0x21:
                        A_1.SetAttr(0x109, class2.method_32());
                        return;

                    case 0x22:
                        A_1.SetAttr(0x10c, class2.method_32());
                        return;

                    case 0x23:
                        A_1.SetAttr(770, Class860.smethod_3(class2.method_28()));
                        return;

                    case 0x24:
                        smethod_6(A_1, class2);
                        return;

                    case 0x25:
                        smethod_7(A_1, class2);
                        return;

                    case 0x26:
                        smethod_3(A_1, class2);
                        return;

                    case 0x27:
                        A_1.SetAttr(10, class2.method_32());
                        return;

                    case 40:
                        class2.method_26();
                        return;

                    case 0x29:
                        Class519.smethod_15(A_1, A_0);
                        return;

                    case 0x2a:
                    {
                        TableCell parentObject = A_0.method_13().ParentObject as TableCell;
                        if (parentObject != null)
                        {
                            parentObject.CellFormat.GridSpan = (short) class2.method_29();
                        }
                        return;
                    }
                }
            }
        }
        if (!smethod_2(A_0, A_1))
        {
            class2.vmethod_1();
        }
    }

    private static bool smethod_2(Class581 A_0, CharacterFormat A_1)
    {
        Class582 class2 = A_0 as Class582;
        if ((class2 != null) && class2.method_35())
        {
            Class394 class3 = A_0.imethod_1();
            class3.method_1();
            class3.vmethod_1();
            return true;
        }
        return false;
    }

    private static void smethod_3(CharacterFormat A_0, Class394 A_1)
    {
        int num = 12;
        Class340 class2 = new Class340();
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("嬱倳", num))
                {
                    if (str != BookmarkStart.b("䐱儳䐵䰷", num))
                    {
                        if (str != BookmarkStart.b("䐱儳䐵䰷᜹弻儽ⴿ㉁㙃⍅㭇㥉", num))
                        {
                            if (!(str == BookmarkStart.b("儱嬳嬵娷匹刻嬽", num)))
                            {
                                if (str == BookmarkStart.b("儱嬳嬵娷匹刻嬽洿⁁㙃❅⭇ⅉ⥋㩍⍏", num))
                                {
                                    class2.method_5(Class860.smethod_5(A_1.method_3()));
                                }
                            }
                            else
                            {
                                class2.method_3(A_1.method_63());
                            }
                        }
                        else
                        {
                            class2.method_7(A_1.method_63());
                        }
                    }
                    else
                    {
                        class2.method_1(A_1.method_63());
                    }
                }
                else
                {
                    class2.method_9(A_1.method_4());
                }
            }
        }
        A_0.FarEastLayout = class2;
    }

    private static void smethod_4(CharacterFormat A_0, Class394 A_1)
    {
        int num = 5;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䨪帬䰮堰娲", num))
                {
                    if (str != BookmarkStart.b("䌪,丮弰䀲尴", num))
                    {
                        if (str != BookmarkStart.b("䴪䰬崮吰刲䘴䌶", num))
                        {
                            if (!(str == BookmarkStart.b("䠪帬", num)))
                            {
                                if (str == BookmarkStart.b("䌪䐬䄮䔰", num))
                                {
                                    A_0.SetAttr(400, Class860.smethod_9(A_1.method_3()));
                                }
                            }
                            else if (Class567.smethod_16(A_1.method_3()))
                            {
                                A_0.SetAttr(270, A_1.method_3());
                            }
                        }
                        else if (Class567.smethod_16(A_1.method_3()))
                        {
                            A_0.SetAttr(0xeb, A_1.method_3());
                        }
                    }
                    else if (Class567.smethod_16(A_1.method_3()))
                    {
                        A_0.SetAttr(240, A_1.method_3());
                    }
                }
                else if (Class567.smethod_16(A_1.method_3()))
                {
                    A_0.SetAttr(230, A_1.method_3());
                }
            }
        }
    }

    private static void smethod_5(CharacterFormat A_0, Class394 A_1)
    {
        int num = 13;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䔲吴嬶", num)))
                {
                    if (str == BookmarkStart.b("倲娴嬶嘸䤺", num))
                    {
                        A_0.SetAttr(450, Class114.smethod_13(A_1.method_3()));
                    }
                }
                else
                {
                    A_0.SetAttr(140, Class860.smethod_17(A_1.method_3()));
                }
            }
        }
    }

    private static void smethod_6(CharacterFormat A_0, Class394 A_1)
    {
        int num = 0x10;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䀵夷嘹", num)))
                {
                    if (str == BookmarkStart.b("䐵䴷嘹夻", num))
                    {
                        A_0.SetAttr(460, Class860.smethod_23(A_1.method_3()));
                    }
                }
                else if (Class567.smethod_16(A_1.method_3()))
                {
                    A_0.SetAttr(470, A_1.method_3()[0]);
                }
            }
        }
    }

    private static void smethod_7(CharacterFormat A_0, Class394 A_1)
    {
        int num = 12;
        bool flag = false;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䐱唳娵", num))
                {
                    if (!(str == BookmarkStart.b("吱唳䐵崷嬹伻䨽", num)))
                    {
                        if (str == BookmarkStart.b("倱崳刵儷", num))
                        {
                            A_0.SetAttr(340, (short) Class860.smethod_0(A_1.method_3(), false));
                            flag = true;
                        }
                    }
                    else
                    {
                        A_0.SetAttr(390, (short) Class860.smethod_0(A_1.method_3(), false));
                        flag = true;
                    }
                }
                else
                {
                    A_0.SetAttr(380, (short) Class860.smethod_0(A_1.method_3(), false));
                    flag = true;
                }
            }
        }
        if (!flag)
        {
            A_0.SetAttr(380, (short) 0);
        }
    }
}

