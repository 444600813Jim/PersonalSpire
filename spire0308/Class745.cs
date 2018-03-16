using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class745
{
    private Class745()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1, CharacterFormat A_2)
    {
        ShapeGroup group = new ShapeGroup(A_0.method_9());
        smethod_2(A_0, group);
        Class98 class2 = (Class98) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("嘰䄲吴䜶儸刺帼", 11), A_0.method_20(), true);
        if ((class2 != null) && (class2.method_45() != null))
        {
            class2.method_45().method_37(group.ShapePr);
        }
        if (A_2 != null)
        {
            A_2.method_37(group.CharacterFormat);
        }
        smethod_3(A_0, group, A_2);
        if ((group.ChildObjects.Count > 0) || !(A_1 is ShapeGroup))
        {
            smethod_1(group);
            A_1.method_13(group);
        }
    }

    private static void smethod_1(ShapeBase A_0)
    {
        if (A_0.ChildObjects.Count > 0)
        {
            double maxValue = double.MaxValue;
            double num2 = double.MaxValue;
            double minValue = double.MinValue;
            double num4 = double.MinValue;
            foreach (ShapeBase base2 in A_0.ChildObjects)
            {
                maxValue = Math.Min(base2.Left, maxValue);
                num2 = Math.Min(base2.Top, num2);
                minValue = Math.Max(base2.Right, minValue);
                num4 = Math.Max(base2.Bottom, num4);
            }
            Size size = new Size((int) (minValue - maxValue), (int) (num4 - num2));
            if ((size.Height > 0) && (size.Width > 0))
            {
                A_0.CoordSize = size;
                A_0.Width = size.Width;
                A_0.Height = size.Height;
            }
            A_0.CoordOriginX = (int) maxValue;
            A_0.CoordOriginY = (int) num2;
            A_0.Left = A_0.CoordOriginX;
            A_0.Top = A_0.CoordOriginY;
        }
    }

    private static void smethod_2(Class857 A_0, ShapeGroup A_1)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        string str = "";
        while (class2.method_19())
        {
            string str2;
            if ((!A_0.method_4(class2) && !Class857.smethod_6(A_0, A_1.ShapePr)) && ((str2 = class2.method_1()) != null))
            {
                if (!(str2 == BookmarkStart.b("崦Ш䈪䌬䬮吰䬲", num)))
                {
                    if (str2 == BookmarkStart.b("匦嬨䨪䌬尮地尲䜴娶", num))
                    {
                        str = class2.method_3();
                    }
                }
                else
                {
                    A_1.ShapePr.SetAttr(0x103a, (long) class2.method_4());
                }
            }
        }
        Class857.smethod_4(A_1.ShapePr, str);
    }

    private static void smethod_3(Class857 A_0, ShapeGroup A_1, CharacterFormat A_2)
    {
        int num = 9;
        Class396 class2 = A_0.method_11();
        while (class2.method_10(BookmarkStart.b("䠮", num), XmlDocumentTextHandling.TextAndSignificantAndIgnorable))
        {
            if (Class857.smethod_10(A_0, A_1, A_2, null))
            {
                A_0.method_41(true);
            }
            else
            {
                A_0.method_5(A_1.ShapePr);
            }
        }
    }
}

