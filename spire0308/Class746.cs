using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;

internal class Class746
{
    private Class746()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1, CharacterFormat A_2)
    {
        int num = 10;
        ShapeObject obj2 = new ShapeObject(A_0.method_9());
        obj2.ShapePr.SetAttr(0x1fc, false);
        obj2.ShapePr.Remove(0x1cb);
        if (Class567.smethod_16(A_0.method_48()))
        {
            obj2.HRef = A_0.method_48();
        }
        if (Class567.smethod_16(A_0.method_50()))
        {
            obj2.Target = A_0.method_50();
        }
        A_0.method_17(null);
        Class43 class2 = smethod_4(A_0);
        Class98 class3 = (Class98) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("圯䀱唳䘵倷匹弻", num), A_0.method_20(), true);
        smethod_1(A_0, obj2.ShapePr);
        if (A_2 != null)
        {
            A_2.method_37(obj2.CharacterFormat);
        }
        double d = smethod_5(A_0, A_1, obj2, class2);
        if (double.IsNaN(d) && (obj2.ShapePr.method_31(0x1024) == null))
        {
            obj2.ShapePr.SetAttr(0x1024, Class576.smethod_41(BookmarkStart.b("ȯᰱĳȵ嬷圹", num)));
        }
        if (!double.IsNaN(d) && (obj2.ShapePr.method_31(0x1024) == null))
        {
            obj2.ShapePr.SetAttr(0x1024, d);
            obj2.ShapePr.SetAttr(190, true);
        }
        class2.method_37(obj2.ShapePr);
        smethod_2(obj2, class3);
        if (obj2.ShapePr.method_31(0x1023) == null)
        {
            obj2.TextBox.method_13(TextBoxWrapMode.None);
        }
    }

    internal static void smethod_1(Class857 A_0, Class43 A_1)
    {
        Class98 class2 = (Class98) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("唱䘳圵䠷刹唻崽", 12), A_0.method_20(), true);
        if ((class2 != null) && (class2.method_45() != null))
        {
            class2.method_45().method_37(A_1);
        }
    }

    internal static void smethod_2(ShapeObject A_0, Class98 A_1)
    {
        if (A_0.ShapePr.method_31(4) == null)
        {
            if (A_0.Stroked)
            {
                A_0.Left += A_0.StrokeWeight;
                A_0.Top += A_0.StrokeWeight;
                A_0.Width = (A_0.Width < (A_0.StrokeWeight * 2.0)) ? 0.0 : (A_0.Width - (A_0.StrokeWeight * 2.0));
                A_0.Height = (A_0.Height < (A_0.StrokeWeight * 2.0)) ? 0.0 : (A_0.Height - (A_0.StrokeWeight * 2.0));
            }
            if (((A_0.Height == 0.0) || (A_0.Width == 0.0)) && (A_0.ShapePr.method_31(190) == null))
            {
                A_0.ShapePr.SetAttr(190, true);
            }
            DocPicture imageData = A_0.ImageData;
            if (imageData != null)
            {
                imageData.WidthScale = (((float) A_0.Width) / imageData.Width) * 100f;
                imageData.HeightScale = (((float) A_0.Height) / imageData.Height) * 100f;
            }
            smethod_3(A_0, A_1);
        }
    }

    private static void smethod_3(ShapeObject A_0, Class98 A_1)
    {
        if (((((A_0.Height != 0.0) && (A_0.Width != 0.0)) && (A_1 != null)) && (((A_1.method_47() != 0.0) || (A_1.method_49() != 0.0)) || ((A_1.method_53() != 0.0) || (A_1.method_51() != 0.0)))) && A_0.HasImageBytes)
        {
            ImageSize size = new ImageSize((int) A_0.ImageData.Size.Width, (int) A_0.ImageData.Size.Height);
            if (size.IsValid)
            {
                A_0.ShapePr.SetAttr(0x103, Class969.smethod_71(A_1.method_47() / ((double) size.WidthPixels)));
                A_0.ShapePr.SetAttr(0x100, Class969.smethod_71(A_1.method_49() / ((double) size.HeightPixels)));
                A_0.ShapePr.SetAttr(0x102, Class969.smethod_71(A_1.method_51() / ((double) size.WidthPixels)));
                A_0.ShapePr.SetAttr(0x101, Class969.smethod_71(A_1.method_53() / ((double) size.WidthPixels)));
            }
        }
    }

    private static Class43 smethod_4(Class857 A_0)
    {
        int num = 11;
        Class396 class2 = A_0.method_11();
        Class43 class3 = new Class43();
        while (class2.method_19())
        {
            string str;
            if (((!Class857.smethod_7(A_0, class3) && !Class857.smethod_6(A_0, class3)) && (!Class857.smethod_5(class2, class3) && !A_0.method_2(class2, class3))) && ((((str = class2.method_1()) != null) && !(str == BookmarkStart.b("尰娲嬴ᨶ儸帺吼堾⥀㝂", num))) && (!(str == BookmarkStart.b("尰娲嬴ᨶ丸刺夼䬾⥀", num)) && !(str == BookmarkStart.b("尰刲䴴ᨶ儸帺吼堾⥀㝂", num)))))
            {
                bool flag1 = str == BookmarkStart.b("尰刲䴴ᨶ丸刺夼䬾⥀", num);
            }
        }
        return class3;
    }

    internal static double smethod_5(Class857 A_0, DocumentObject A_1, ShapeObject A_2, Class43 A_3)
    {
        int num = 8;
        if (((A_1 is ShapeObject) && !(A_1 is ShapeGroup)) || (A_1 is TableCell))
        {
            return double.NaN;
        }
        double naN = double.NaN;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䠭䈯匱夳匵", num)))
        {
            if (A_0.method_5(A_3))
            {
                continue;
            }
            string str = A_0.method_11().method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("娭唯䨱䀳ᬵ娷唹䐻", num))
                {
                    if (str != BookmarkStart.b("䜭崯匱匳匵", num))
                    {
                        if (!(str == BookmarkStart.b("䄭刯報儳唵䰷", num)))
                        {
                            if (!(str == BookmarkStart.b("䄭刯報儳唵䰷᜹医刽┿", num)))
                            {
                                goto Label_011A;
                            }
                            A_2.SetShapeType(ShapeType.OleObject);
                            Class798.smethod_0(A_0, A_1, A_2);
                        }
                        else
                        {
                            new Class338(A_0);
                        }
                    }
                    else
                    {
                        if (A_2.ShapeType != ShapeType.OleObject)
                        {
                            A_2.SetShapeType(ShapeType.Image);
                        }
                        DocPicture imageData = A_2.ImageData;
                        Class798.smethod_0(A_0, A_1, A_2);
                    }
                }
                else if (A_0.method_55())
                {
                    class2.vmethod_1();
                }
                else
                {
                    A_0.method_56(true);
                    A_2.SetShapeType(ShapeType.TextBox);
                    naN = Class856.smethod_0(A_0, A_1, A_2);
                    A_0.method_56(false);
                }
                continue;
            }
        Label_011A:
            class2.vmethod_1();
        }
        return naN;
    }

    internal static void smethod_6(ShapeObject A_0, Class98 A_1)
    {
        A_0.SetShapeAttr(0x81, Class1133.smethod_5(A_1.method_39().method_4() * 12700.0));
        A_0.SetShapeAttr(130, Class1133.smethod_5(A_1.method_39().method_0() * 12700.0));
        A_0.SetShapeAttr(0x83, Class1133.smethod_5(A_1.method_39().method_6() * 12700.0));
        A_0.SetShapeAttr(0x84, Class1133.smethod_5(A_1.method_39().method_2() * 12700.0));
    }

    internal static void smethod_7(ShapeObject A_0, Class98 A_1)
    {
        A_0.StrokeWeight = (A_1.method_37().method_4().method_0() / 2.54) * 72.0;
        A_0.StrokeColor = A_1.method_37().method_4().method_4();
    }
}

