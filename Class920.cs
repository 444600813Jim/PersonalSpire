using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class920
{
    private static readonly double double_0 = 878.74015748031491;

    private Class920()
    {
    }

    internal static void smethod_0(Class857 A_0, Class92 A_1)
    {
        int num = 11;
        Class17 class2 = new Class17(A_0.method_9());
        smethod_5(A_0, A_1, class2);
        smethod_7(class2, A_1);
        if (class2.method_80() != 0)
        {
            class2.method_156(0x87a, (((class2.method_98() - class2.method_104()) - class2.method_106()) / ((float) class2.method_80())) / 20f);
            class2.method_81(0);
        }
        smethod_4(A_0, class2);
        if (A_0.method_52() != null)
        {
            if (A_0.method_52() != null)
            {
                class2.method_73(int.Parse(A_0.method_52().method_4()));
            }
            if (A_0.method_52().method_14() == BookmarkStart.b("䔰䄲䀴制", num))
            {
                class2.method_71(LineNumberingRestartMode.RestartPage);
            }
            else
            {
                class2.method_71(LineNumberingRestartMode.Continuous);
            }
            if (A_0.method_52().method_8() != null)
            {
                class2.method_127((float) Class576.smethod_50(Class576.smethod_36(A_0.method_52().method_8())));
            }
        }
        if (class2.Count > 0)
        {
            A_1.method_5(class2);
        }
    }

    internal static void smethod_1(Class857 A_0, Class17 A_1)
    {
        int num = 5;
        Class396 class2 = A_0.method_11();
        A_1.method_121(0);
        A_1.method_123(new ColumnCollection(A_0.method_9()));
        A_1.method_119(false);
        while (class2.method_19())
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("䠪䈬䌮䐰帲嬴ᨶ娸吺䠼儾㕀", num)))
                {
                    if (str2 == BookmarkStart.b("䠪䈬䌮䐰帲嬴ᨶ常娺䴼", num))
                    {
                        A_1.method_121(Class576.smethod_36(class2.method_3()));
                        A_1.method_119(true);
                    }
                }
                else
                {
                    A_1.method_117(class2.method_4());
                }
            }
        }
        ArrayList list = new ArrayList();
        float num4 = 0f;
        float num5 = 0f;
        while (class2.method_9(BookmarkStart.b("䠪䈬䌮䐰帲嬴䐶", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䠪䈬䌮䐰帲嬴", num)))
                {
                    if (!(str == BookmarkStart.b("䠪䈬䌮䐰帲嬴ᨶ䨸帺䴼", num)))
                    {
                        goto Label_0113;
                    }
                    A_1.method_63(true);
                    smethod_3(A_0);
                }
                else
                {
                    Column column3 = smethod_2(A_0, A_1, list, ref num5);
                    A_1.method_122().Add(column3);
                    num4 += (int) column3.Width;
                }
                continue;
            }
        Label_0113:
            class2.vmethod_1();
        }
        if (A_1.method_122().Count > 0)
        {
            Column column1 = A_1.method_122()[A_1.method_122().Count - 1];
            column1.Space -= num5;
        }
        double num2 = num4 / ((A_1.method_96() - A_1.method_50().Left) - A_1.method_50().Right);
        num2 = (num2 > 0.0) ? num2 : 1.0;
        for (int i = 0; i < A_1.method_122().Count; i++)
        {
            Column column = A_1.method_122()[i];
            float num6 = (float) ((((double) column.Width) / num2) / 20.0);
            float num7 = 0f;
            if (i < (A_1.method_122().Count - 1))
            {
                num7 = column.Space - ((float) list[i + 1]);
            }
            column.Width = (num6 - ((float) list[i])) - num7;
        }
        if (A_1.method_122().Count == 0)
        {
            for (int j = 0; j < A_1.method_116(); j++)
            {
                Column column2 = new Column(A_0.method_9()) {
                    Space = ((float) A_1.method_120()) / 20f,
                    Width = (((((A_1.method_96() - A_1.method_102()) - A_1.method_100()) - ((A_1.method_116() - 1) * A_1.method_120())) - (A_1.method_50().Gutter * 20f)) / ((float) A_1.method_116())) / 20f
                };
                A_1.method_122().Add(column2);
            }
        }
    }

    private static bool smethod_10(double A_0, double A_1, bool A_2)
    {
        return (((A_0 > double_0) && (A_1 <= double_0)) && A_2);
    }

    private static Column smethod_2(Class857 A_0, Class17 A_1, ArrayList A_2, ref float A_3)
    {
        int num = 5;
        Class396 class2 = A_0.method_11();
        Column column = new Column(A_1.Document);
        float num2 = 0f;
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("太䠬䌮ᰰ䐲尴匶䴸区", num))
                {
                    if (str != BookmarkStart.b("堪夬丮䌰䜲ᠴ帶圸强堼儾㕀", num))
                    {
                        if (!(str == BookmarkStart.b("个䌬䬮ᰰ娲嬴匶尸唺䤼", num)))
                        {
                            if ((str == BookmarkStart.b("堪崬丮到嘲ᠴ唶尸崺刼䴾⑀", num)) || (str == BookmarkStart.b("堪崬丮到嘲ᠴ嘶弸伺堼䴾", num)))
                            {
                            }
                        }
                        else
                        {
                            A_3 = (float) Class576.smethod_41(class2.method_3());
                            column.Space += (float) Class576.smethod_41(class2.method_3());
                        }
                    }
                    else
                    {
                        num2 = (float) Class576.smethod_41(class2.method_3());
                        if (A_1.method_122().Count > 0)
                        {
                            Column column1 = A_1.method_122()[A_1.method_122().Count - 1];
                            column1.Space += num2;
                        }
                    }
                }
                else
                {
                    column.Width = Class1041.smethod_11(class2.method_3().Replace(BookmarkStart.b("Ī", num), ""));
                }
            }
        }
        A_2.Add(num2);
        return column;
    }

    private static void smethod_3(Class857 A_0)
    {
        int num = 10;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if (((((str = class2.method_1()) != null) && !(str == BookmarkStart.b("䌯䘱䴳娵崷", num))) && (!(str == BookmarkStart.b("䜯嬱倳䈵倷", num)) && !(str == BookmarkStart.b("堯圱崳儵倷丹", num)))) && !(str == BookmarkStart.b("䘯圱䘳䈵儷夹崻刽洿⍁⡃⽅⽇⑉", num)))
            {
                bool flag1 = str == BookmarkStart.b("匯崱堳夵䨷", num);
            }
        }
    }

    private static void smethod_4(Class857 A_0, Class17 A_1)
    {
        int num = 13;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䌲吴倶尸ᘺ儼帾㡀ⱂい㍆摈㭊㽌⁎⅐㙒❔⍖じ㹚⹜", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("倲娴嬶䰸嘺匼䰾", num)))
                {
                    if (!(str == BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⁈♊ⱌ⡎㑐", num)))
                    {
                        goto Label_0097;
                    }
                    ShapeObject obj2 = new ShapeObject(A_0.method_9(), ShapeType.Image);
                    Class798.smethod_1(A_0, obj2, BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄橆⁈♊ⱌ⡎㑐", num));
                    if (obj2.ImageData.HasImage)
                    {
                        A_0.method_9().method_190(obj2);
                        A_0.method_9().ViewSetup.DisplayBackgroundShape = true;
                    }
                }
                else
                {
                    smethod_1(A_0, A_1);
                }
                continue;
            }
        Label_0097:
            class2.vmethod_1();
        }
    }

    private static void smethod_5(Class857 A_0, Class92 A_1, Class17 A_2)
    {
        int num = 11;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str2;
            if ((!Class857.smethod_1(class2, A_1.method_8()) && !Class857.smethod_9(class2, A_1.method_6())) && (!Class857.smethod_2(class2, A_1.method_10()) && ((str2 = class2.method_1()) != null)))
            {
                int num2;
                if (Class1160.dictionary_184 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("弰䘲場ᨶ弸吺似刾⁀㝂", num), 0);
                    dictionary1.Add(BookmarkStart.b("䄰刲刴制ᐸ䰺吼嬾㕀⭂", num), 1);
                    dictionary1.Add(BookmarkStart.b("䄰刲刴制ᐸ区堼嘾♀⭂ㅄ", num), 2);
                    dictionary1.Add(BookmarkStart.b("䄰䄲尴夶䴸ᘺ刼䴾⡀♂⭄㍆⡈㽊⑌⁎㽐", num), 3);
                    dictionary1.Add(BookmarkStart.b("䘰䄲尴䌶倸唺娼ሾⱀⱂ⅄≆", num), 4);
                    dictionary1.Add(BookmarkStart.b("䈰嬲吴匶嘸䰺", num), 5);
                    dictionary1.Add(BookmarkStart.b("匰刲嘴尶常䤺刼䨾⽀❂桄⑆♈❊≌㵎", num), 6);
                    dictionary1.Add(BookmarkStart.b("崰刲䰴堶䰸伺ြ堾㍀⩂⅄橆⑈⑊⥌⩎", num), 7);
                    dictionary1.Add(BookmarkStart.b("崰刲䰴堶䰸伺ြ堾㍀⩂⅄橆╈≊⍌⩎≐", num), 8);
                    Class1160.dictionary_184 = dictionary1;
                }
                if (Class1160.dictionary_184.TryGetValue(str2, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            if (class2.method_3() != BookmarkStart.b("0", num))
                            {
                                A_2.method_53(Class922.smethod_58(class2.method_3()));
                            }
                            break;

                        case 1:
                            A_2.method_156(0x8d4, (float) Class576.smethod_36(class2.method_3()));
                            break;

                        case 2:
                            A_2.method_156(0x8de, (float) Class576.smethod_36(class2.method_3()));
                            break;

                        case 3:
                            A_2.method_156(0x8a2, Class922.smethod_86(class2.method_3()));
                            break;

                        case 4:
                            smethod_6(A_2, class2.method_3());
                            break;

                        case 5:
                            A_1.method_17(Class576.smethod_90(class2.method_3()));
                            break;

                        case 6:
                            A_0.method_9().Background.Color = Class576.smethod_76(class2.method_3());
                            break;

                        case 7:
                        {
                            string str = class2.method_3();
                            if (str != null)
                            {
                                if (str == BookmarkStart.b("崰娲嬴制", num))
                                {
                                    goto Label_026C;
                                }
                                if (str == BookmarkStart.b("匰尲䄴弶", num))
                                {
                                    A_2.method_156(0x97e, GridPitchType.CharsAndLine);
                                }
                            }
                            break;
                        }
                        case 8:
                            A_2.method_156(0xa50, int.Parse(class2.method_3()));
                            break;
                    }
                }
            }
            continue;
        Label_026C:
            A_2.method_156(0x97e, GridPitchType.LinesOnly);
        }
        Class1138 class3 = A_0.method_52();
        if ((class3 != null) && (class3.method_0() == BookmarkStart.b("䔰䄲䀴制", num)))
        {
            A_2.SetAttr(0x848, 1);
            if (Class567.smethod_16(class3.method_4()))
            {
                A_2.SetAttr(0x848, Class1041.smethod_11(class3.method_4()));
            }
            if (Class567.smethod_16(class3.method_8()))
            {
                A_2.SetAttr(0x960, Class576.smethod_36(class3.method_8()));
            }
            if (class3.method_14() == BookmarkStart.b("䔰䄲䀴制", num))
            {
                A_2.SetAttr(0x83e, LineNumberingRestartMode.RestartPage);
            }
        }
    }

    private static void smethod_6(Class17 A_0, string A_1)
    {
        int num = 0x10;
        if (((A_1 == BookmarkStart.b("䈵娷᜹主刽", 0x10)) || (A_1 == BookmarkStart.b("䈵娷", num))) || (A_1 == BookmarkStart.b("䈵娷᜹倻䰽", num)))
        {
            A_0.method_156(0x988, TextOrientation.Downward);
        }
        if ((A_1 == BookmarkStart.b("䐵吷᜹䠻尽", num)) || (A_1 == BookmarkStart.b("䐵吷", num)))
        {
            A_0.method_156(0x988, TextOrientation.HorizontalRotatedFarEast);
        }
        if ((A_1 == BookmarkStart.b("娵䨷᜹䠻尽", num)) || (A_1 == BookmarkStart.b("娵䨷", num)))
        {
            A_0.method_156(0x992, false);
        }
    }

    private static void smethod_7(Class17 A_0, Class92 A_1)
    {
        Class852 class2 = A_1.method_8();
        Class412 class3 = A_1.method_10();
        Class572 class4 = A_1.method_6();
        if (smethod_9(class3, class4))
        {
            A_0.method_95(PageBorderOffsetFrom.PageEdge);
        }
        smethod_8(A_0, A_1, 2, 0x8fc, class2.method_0(), class3.method_0(), class4.method_2().method_0(), class4.method_2().method_4());
        smethod_8(A_0, A_1, 3, 0x906, class2.method_2(), class3.method_2(), class4.method_2().method_2(), class4.method_2().method_6());
        smethod_8(A_0, A_1, 1, 0x8e8, class2.method_4(), class3.method_4(), class4.method_0().method_0(), class4.method_0().method_4());
        smethod_8(A_0, A_1, 4, 0x8f2, class2.method_6(), class3.method_6(), class4.method_0().method_2(), class4.method_0().method_6());
    }

    private static void smethod_8(Class17 A_0, Class92 A_1, int A_2, int A_3, Class472 A_4, double A_5, double A_6, bool A_7)
    {
        Border border = A_0.method_49()[A_2] as Border;
        if (A_4 != null)
        {
            border.BorderType = A_4.method_2();
            border.Color = A_4.method_4();
            border.LineWidth = (float) A_4.method_0();
        }
        if ((A_5 > double_0) || (A_0.method_94() == PageBorderOffsetFrom.PageEdge))
        {
            if ((A_6 <= double_0) && A_7)
            {
                A_5 = A_6;
                A_6 = A_5;
                A_0.method_95(PageBorderOffsetFrom.PageEdge);
            }
            else
            {
                A_5 = double_0;
            }
        }
        border.Space = Class1133.smethod_5(A_5);
        border.Shadow = A_1.method_16();
        if (A_7)
        {
            A_0.method_156(A_3, ((float) (A_6 + A_5)) + ((A_4 == null) ? 0f : border.LineWidth));
        }
    }

    private static bool smethod_9(Class412 A_0, Class572 A_1)
    {
        if ((!smethod_10(A_0.method_0(), A_1.method_2().method_0(), A_1.method_2().method_4()) && !smethod_10(A_0.method_2(), A_1.method_2().method_2(), A_1.method_2().method_6())) && !smethod_10(A_0.method_4(), A_1.method_0().method_0(), A_1.method_0().method_4()))
        {
            return smethod_10(A_0.method_6(), A_1.method_0().method_2(), A_1.method_0().method_6());
        }
        return true;
    }
}

