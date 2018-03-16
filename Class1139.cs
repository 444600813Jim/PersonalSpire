using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class1139
{
    private Class1139()
    {
    }

    internal static void smethod_0(Class857 A_0, Class106 A_1, Class571 A_2, bool A_3)
    {
        int num = 6;
        if (!A_3)
        {
            Class1140 class2 = new Class1140();
            class2.method_9(new TableCell(A_0.method_9()));
            A_0.method_17(null);
            smethod_5(A_0, class2);
            if (!Class567.smethod_16(A_0.method_16()))
            {
                A_0.method_17(A_2.method_6());
            }
            Class100 class3 = (Class100) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("堫伭刯帱儳ᬵ嬷弹倻刽", num), A_0.method_20(), true);
            if ((class3 != null) && (class3.method_45() != null))
            {
                smethod_2(class2.method_8().CellFormat.Borders.Top, class3.method_45().Borders.Top);
                smethod_2(class2.method_8().CellFormat.Borders.Bottom, class3.method_45().Borders.Bottom);
                smethod_2(class2.method_8().CellFormat.Borders.Left, class3.method_45().Borders.Left);
                smethod_2(class2.method_8().CellFormat.Borders.Right, class3.method_45().Borders.Right);
                class2.method_8().CellFormat.BackColor = class3.method_45().BackColor;
                class2.method_8().CellFormat.TextWrap = class3.method_45().TextWrap;
                class2.method_8().CellFormat.Shading.CopyPropertiesTo(class3.method_45().Shading);
                class2.method_8().CellFormat.VerticalAlignment = class3.method_45().VerticalAlignment;
                class2.method_8().CellFormat.SamePaddingsAsTable = class3.method_45().SamePaddingsAsTable;
                smethod_3(class2.method_8().CellFormat.Paddings, class3.method_45().Paddings);
                class2.method_8().CellFormat.TextDirection = class3.method_45().TextDirection;
            }
            smethod_6(A_0, class3, class2.method_8(), A_1);
            A_2.Add(class2);
            smethod_4(A_1, A_2, class2);
        }
    }

    private static void smethod_1(Border A_0, Class472 A_1)
    {
        A_0.LineWidth = (float) A_1.method_0();
        A_0.BorderType = A_1.method_2();
        A_0.Color = A_1.method_4();
    }

    private static void smethod_2(Border A_0, Border A_1)
    {
        A_0.LineWidth = A_1.LineWidth;
        A_0.BorderType = A_1.BorderType;
        A_0.Color = A_1.Color;
        A_0.Space = A_1.Space;
        A_0.Shadow = A_1.Shadow;
        A_0.ShadeTheme = A_1.ShadeTheme;
    }

    private static void smethod_3(Paddings A_0, Paddings A_1)
    {
        A_0.Bottom = A_1.Bottom;
        A_0.Top = A_1.Top;
        A_0.Left = A_1.Left;
        A_0.Right = A_1.Right;
    }

    private static void smethod_4(Class106 A_0, Class571 A_1, Class1140 A_2)
    {
        for (int i = 1; i < A_2.method_0(); i++)
        {
            if (A_1.Count >= A_0.method_20().Count)
            {
                break;
            }
            Class1140 class2 = new Class1140();
            class2.method_5(CellMerge.Continue);
            class2.method_7(A_2.method_6());
            class2.method_1(A_2.method_0());
            class2.method_3(A_2.method_2());
            A_1.Add(class2);
        }
    }

    private static void smethod_5(Class857 A_0, Class1140 A_1)
    {
        int num = 12;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str;
            if (!A_0.method_4(class2) && ((str = class2.method_1()) != null))
            {
                if (!(str == BookmarkStart.b("就䄳嬵娷弹主ጽ⌿ⵁ⡃㍅╇⑉㽋捍⍏≑㕓㡕㙗㽙㡛", num)))
                {
                    if (str == BookmarkStart.b("就䄳嬵娷弹主ጽ㈿ⵁ㍃㕅敇㥉㱋⽍㹏㱑ㅓ㉕", num))
                    {
                        A_1.method_3(class2.method_4());
                        A_1.method_7(CellMerge.Start);
                    }
                }
                else
                {
                    A_1.method_1(class2.method_4());
                    A_1.method_5(CellMerge.Start);
                }
            }
        }
    }

    internal static void smethod_6(Class857 A_0, Class100 A_1, TableCell A_2, Class106 A_3)
    {
        Class396 class2 = A_0.method_11();
        class2.method_18();
        Class574.smethod_1(A_0, class2.method_1(), A_2, A_3);
        smethod_7(A_0, A_2);
    }

    internal static void smethod_7(Class857 A_0, TableCell A_1)
    {
        if ((A_1.LastChild is Paragraph) && !A_0.method_59())
        {
            ((Paragraph) A_1.LastChild).Format.method_71(0x4c4);
        }
    }
}

