using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;

internal class Class853
{
    private Class853()
    {
    }

    internal static void smethod_0(Class857 A_0, Class106 A_1)
    {
        int num = 9;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if (!Class857.smethod_9(class2, A_1.method_18()) && ((str = class2.method_1()) != null))
            {
                if (str != BookmarkStart.b("丮崰娲刴夶", num))
                {
                    if (!(str == BookmarkStart.b("堮堰圲䄴弶", num)))
                    {
                        if (str == BookmarkStart.b("堮䌰娲䄴帶圸尺ြ刾⹀❂⁄", num))
                        {
                            A_1.method_13(class2.method_3());
                        }
                    }
                    else
                    {
                        A_1.method_17(Class576.smethod_36(class2.method_3()));
                    }
                }
                else
                {
                    A_1.method_15(Class922.smethod_49(class2.method_3()));
                }
            }
        }
    }

    internal static void smethod_1(Class857 A_0, Class103 A_1)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        RowFormat format = new RowFormat();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䜩䔫䀭ᴯ䀱嬳䄵ᔷ刹夻圽✿⩁ぃ", num))
                {
                    if (!(str == BookmarkStart.b("堩䌫夭ᴯ娱儳張強刹䠻", num)))
                    {
                        if ((str == BookmarkStart.b("䄩䤫䬭䀯ἱ䀳夵強弹䠻嘽┿ぁ", num)) && (class2.method_3() == BookmarkStart.b("䬩䀫夭儯䬱䜳", num)))
                        {
                            format.SetAttr(0x1108, false);
                        }
                    }
                    else
                    {
                        format.Height = ((float) Class576.smethod_36(class2.method_3())) / 20f;
                        format.HeightType = TableRowHeightType.Exactly;
                    }
                }
                else
                {
                    format.Height = ((float) Class576.smethod_36(class2.method_3())) / 20f;
                    format.HeightType = TableRowHeightType.AtLeast;
                }
            }
        }
        if (format.Count > 0)
        {
            A_1.method_13(format);
        }
    }

    internal static void smethod_2(Class857 A_0, Class100 A_1)
    {
        int num = 8;
        Class396 class2 = A_0.method_11();
        CellFormat format = new CellFormat();
        while (class2.method_19())
        {
            string str;
            if ((!Class857.smethod_9(class2, A_1.method_35()) && !Class857.smethod_2(class2, A_1.method_39())) && (!Class857.smethod_1(class2, A_1.method_37()) && ((str = class2.method_1()) != null)))
            {
                if (str != BookmarkStart.b("夭䈯嬱䀳張嘷崹ᄻ匽⼿♁⅃", num))
                {
                    if (str != BookmarkStart.b("䤭尯䬱䐳帵ᔷ唹主圽┿ⱁぃ❅㱇⍉⍋⁍絏⑑ㅓ⑕ⱗ㍙㽛㽝౟", num))
                    {
                        if (str != BookmarkStart.b("堭唯䀱䀳張嬷嬹倻ጽℿ⹁ⵃⅅ♇", num))
                        {
                            if (!(str == BookmarkStart.b("䰭儯儱弳儵䨷唹䤻倽␿潁❃⥅⑇╉㹋", num)))
                            {
                                if (str == BookmarkStart.b("夭䈯匱䐳ᬵ圷䨹䠻圽⼿ⱁ", num))
                                {
                                    format.SetAttr(0xc6c, class2.method_3() == BookmarkStart.b("夭䈯匱䐳", num));
                                }
                            }
                            else
                            {
                                format.SetAttr(0xc62, Class576.smethod_62(class2.method_3(), (Class16) format.method_31(0xc62)));
                            }
                        }
                        else
                        {
                            format.SetAttr(0xbf4, Class922.smethod_48(class2.method_3()));
                        }
                    }
                    else if (class2.method_3() == BookmarkStart.b("ḭ", num))
                    {
                        format.SetAttr(0xbea, TextOrientation.Upward);
                    }
                }
                else if (Class922.smethod_37(class2.method_3()) != TextOrientation.Horizontal)
                {
                    format.SetAttr(0xbea, Class922.smethod_37(class2.method_3()));
                }
            }
        }
        smethod_3(format, A_1);
        if (format.Count > 0)
        {
            A_1.method_46(format);
        }
    }

    private static void smethod_3(CellFormat A_0, Class100 A_1)
    {
        Class852 class2 = A_1.method_37();
        Class412 class3 = A_1.method_39();
        if (class2.method_0() != null)
        {
            smethod_4(A_0.Borders.Top, Class472.smethod_2(class2.method_0()));
        }
        if (class3.method_0() != 0.0)
        {
            A_0.SamePaddingsAsTable = false;
            A_0.Paddings.Top = (float) class3.method_0();
        }
        if (class2.method_2() != null)
        {
            smethod_4(A_0.Borders.Bottom, Class472.smethod_2(class2.method_2()));
        }
        if (class3.method_2() != 0.0)
        {
            A_0.SamePaddingsAsTable = false;
            A_0.Paddings.Bottom = (float) class3.method_2();
        }
        if (class2.method_4() != null)
        {
            smethod_4(A_0.Borders.Left, Class472.smethod_2(class2.method_4()));
        }
        if (class3.method_4() != 0.0)
        {
            A_0.SamePaddingsAsTable = false;
            A_0.Paddings.Left = (float) class3.method_4();
        }
        if (class2.method_6() != null)
        {
            smethod_4(A_0.Borders.Right, Class472.smethod_2(class2.method_6()));
        }
        if (class3.method_6() != 0.0)
        {
            A_0.SamePaddingsAsTable = false;
            A_0.Paddings.Right = (float) class3.method_6();
        }
    }

    private static void smethod_4(Border A_0, Class1031 A_1)
    {
        A_0.BorderType = A_1.method_1();
        A_0.LineWidth = (float) A_1.method_3();
        A_0.Space = (float) A_1.method_14();
        A_0.Color = A_1.method_10();
        A_0.Shadow = A_1.method_16();
        A_0.ShadeTheme = A_1.method_22();
    }

    internal static void smethod_5(Class857 A_0, Class94 A_1)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䐦䘨䜪堬䈮弰Ḳ䈴帶崸伺唼", num)))
            {
                A_1.method_13(Class576.smethod_36(class2.method_3()));
            }
        }
    }
}

