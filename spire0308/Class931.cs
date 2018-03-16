using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Interface;
using System;
using System.IO;

internal class Class931
{
    internal static bool bool_0;
    private readonly Class658 class658_0;
    private readonly Class930 class930_0;

    internal Class931(Class658 A_0)
    {
        this.class658_0 = A_0;
        this.class930_0 = new Class930(A_0);
    }

    internal ShapeBase method_0(Class266 A_0)
    {
        int num = 0x11;
        switch (A_0.method_3().method_8())
        {
            case EscherRecordType.ShapeGroupContainer:
                return this.method_2((Class277) A_0);

            case EscherRecordType.ShapeContainer:
                return this.method_4((Class273) A_0);
        }
        throw new InvalidOperationException(BookmarkStart.b("戶圸债匼倾㙀ⵂ敄Ɇ㩈⡊╌⩎⍐獒❔㉖㩘㑚⽜㭞你", num));
    }

    internal Class272 method_1(ShapeBase A_0, EscherShapeKind A_1)
    {
        if (A_0.IsGroup)
        {
            return this.method_3((ShapeGroup) A_0, A_1);
        }
        return this.method_6(A_0, A_1);
    }

    private ShapeGroup method_2(Class277 A_0)
    {
        ShapeGroup group = new ShapeGroup(this.class658_0.document_0);
        this.method_5((Class273) A_0.method_9(0), group);
        for (int i = 1; i < A_0.method_8(); i++)
        {
            ShapeBase base2 = this.method_0(A_0.method_9(i));
            group.method_13(base2);
        }
        return group;
    }

    private Class277 method_3(ShapeGroup A_0, EscherShapeKind A_1)
    {
        Class277 class2 = new Class277();
        Class273 class3 = this.method_6(A_0, A_1);
        class2.method_7().Add(class3);
        for (IDocumentObject obj2 = A_0.FirstChild; obj2 != null; obj2 = obj2.NextSibling)
        {
            Class266 class4 = this.method_1((ShapeBase) obj2, EscherShapeKind.Child);
            class2.method_7().Add(class4);
        }
        return class2;
    }

    internal ShapeObject method_4(Class273 A_0)
    {
        ShapeObject obj2 = new ShapeObject(this.class658_0.document_0);
        this.method_5(A_0, obj2);
        return obj2;
    }

    private void method_5(Class273 A_0, ShapeBase A_1)
    {
        Class291 class2 = null;
        for (int i = 0; i < A_0.method_8(); i++)
        {
            Class279 class4;
            Class266 class3 = A_0.method_9(i);
            if (class3 != null)
            {
                switch (class3.method_3().method_8())
                {
                    case EscherRecordType.ShapeGroup:
                    {
                        Class285 class5 = (Class285) class3;
                        A_1.CoordOrigin = class5.method_4();
                        A_1.method_56(class5.method_6());
                        break;
                    }
                    case EscherRecordType.Shape:
                        class4 = (Class279) class3;
                        A_1.Id = class4.method_4();
                        if (!class4.method_6())
                        {
                            goto Label_00AB;
                        }
                        A_1.SetShapeType(ShapeType.Group);
                        goto Label_00C9;

                    case EscherRecordType.ShapeOptions:
                    case EscherRecordType.ShapeOptionsEx:
                        goto Label_00D7;

                    case EscherRecordType.ChildAnchor:
                        goto Label_00F0;
                }
            }
            continue;
        Label_00AB:
            if (class4.method_14())
            {
                A_1.SetShapeType(ShapeType.OleObject);
            }
            else
            {
                A_1.SetShapeType(class4.method_30());
            }
        Label_00C9:
            A_1.FlipOrientation = class4.method_32();
            continue;
        Label_00D7:
            this.class930_0.method_0(((Class287) class3).method_4(), A_1);
            continue;
        Label_00F0:
            class2 = (Class291) class3;
        }
        if (class2 != null)
        {
            Class265.smethod_2(A_1, (double) class2.method_4(), (double) class2.method_6(), (double) class2.method_8(), (double) class2.method_10());
        }
    }

    internal Class273 method_6(ShapeBase A_0, EscherShapeKind A_1)
    {
        Class273 class2 = new Class273();
        if (A_0.IsGroup)
        {
            Class285 class3 = new Class285();
            class3.method_5(A_0.CoordOrigin);
            class3.method_7(A_0.CoordSize);
            class2.method_7().Add(class3);
        }
        Class279 class4 = new Class279();
        class4.method_5(A_0.Id);
        switch (A_0.ShapeType)
        {
            case ShapeType.OleObject:
            case ShapeType.OleControl:
                class4.method_31(ShapeType.Image);
                break;

            case ShapeType.Group:
                class4.method_31(ShapeType.NonPrimitive);
                break;

            default:
                class4.method_31(A_0.ShapeType);
                break;
        }
        class4.method_7(A_0.IsGroup);
        class4.method_25(A_1 == EscherShapeKind.Background);
        class4.method_9(A_1 == EscherShapeKind.Child);
        class4.method_23(A_0.IsConnector);
        class4.method_15(A_0.IsOle && !A_0.IsInline);
        class4.method_29(!A_0.IsGroup);
        class4.method_27(true);
        class4.method_33(A_0.FlipOrientation);
        class2.method_7().Add(class4);
        Class287 class8 = new Class287(false);
        Class287 class5 = new Class287(true);
        this.class930_0.method_23(A_0, class8.method_4(), class5.method_4(), class4.method_24());
        if (class8.method_4().method_2() > 0)
        {
            class2.method_7().Add(class8);
        }
        if (class5.method_4().method_2() > 0)
        {
            class2.method_7().Add(class5);
        }
        if (A_1 == EscherShapeKind.InlineReal)
        {
            Class267 class11 = new Class267();
            class11.method_5(EscherClientAnchorFlags.Inline);
            class2.method_7().Add(class11);
            return class2;
        }
        if (!class4.method_24())
        {
            if (class4.method_8())
            {
                Class291 class6 = new Class291();
                Class265 class7 = Class265.smethod_3(A_0);
                class6.method_5((int) class7.double_0);
                class6.method_7((int) class7.double_1);
                class6.method_9((int) class7.double_2);
                class6.method_11((int) class7.double_3);
                class2.method_7().Add(class6);
            }
            else
            {
                Class267 class12 = new Class267();
                class2.method_7().Add(class12);
            }
        }
        Class280 class9 = new Class280();
        class9.method_5(1);
        class2.method_7().Add(class9);
        if (A_0.Txid != 0)
        {
            Class282 class10 = new Class282();
            class10.method_5(A_0.Txid);
            class2.method_7().Add(class10);
        }
        return class2;
    }

    internal static ShapeObject smethod_0(Class352 A_0, BinaryReader A_1, int A_2)
    {
        if (A_2 == 0)
        {
            return null;
        }
        long position = A_1.BaseStream.Position;
        Class1063 class4 = new Class1063();
        class4.method_2(A_1, A_2);
        if (class4.Count == 0)
        {
            return null;
        }
        Class273 class5 = (Class273) class4.method_0(0);
        Class268 class2 = null;
        Class350 class6 = new Class350();
        for (int i = 1; i < class4.Count; i++)
        {
            if ((class4.method_0(i) != null) && (class4.method_0(i).method_3().method_8() == EscherRecordType.Bse))
            {
                class2 = (Class268) class4.method_0(i);
                if (class2 != null)
                {
                    if (((class2.method_8() == null) && (i < class4.Count)) && (class4.method_0(i + 1) is Class269))
                    {
                        class2.method_9((Class269) class4.method_0(i + 1));
                    }
                    Class268 class3 = A_0.method_5(class2.method_8().method_4());
                    if (class3 != null)
                    {
                        class2 = class3;
                    }
                    else
                    {
                        A_0.method_4(class2);
                    }
                    ((Interface36) class6).imethod_1(class2);
                }
            }
        }
        Class658 class7 = new Class658(A_0.method_14(), class6, null);
        ShapeObject obj2 = new Class931(class7).method_4(class5);
        obj2.TextWrappingStyle = TextWrappingStyle.Inline;
        return obj2;
    }

    internal static void smethod_1(ShapeBase A_0, BinaryWriter A_1)
    {
        if (A_0.IsNeedDummyWhenInline)
        {
            smethod_3(A_0, A_1);
        }
        else
        {
            smethod_2(A_0, A_1);
        }
    }

    private static void smethod_2(ShapeBase A_0, BinaryWriter A_1)
    {
        Class350 class2 = new Class350();
        Class658 class3 = new Class658(A_0.Document, class2, null);
        Class273 class5 = new Class931(class3).method_6(A_0, EscherShapeKind.InlineReal);
        int position = (int) A_1.BaseStream.Position;
        class5.method_2(A_1);
        class2.method_0(A_1, position);
    }

    private static void smethod_3(ShapeBase A_0, BinaryWriter A_1)
    {
        Class273 class2 = new Class273();
        Class279 class3 = new Class279();
        class3.method_5(A_0.Id);
        class3.method_31(ShapeType.Image);
        class3.method_29(true);
        class3.method_27(true);
        class2.method_7().Add(class3);
        Class287 class4 = new Class287(false);
        class4.method_4().method_24(0x7f, 0x1400140);
        class2.method_7().Add(class4);
        Class287 class5 = new Class287(true);
        class5.method_4().method_24(0x53f, 0x10001);
        class2.method_7().Add(class5);
        Class267 class6 = new Class267();
        class6.method_5(EscherClientAnchorFlags.Inline);
        class2.method_7().Add(class6);
        class2.method_2(A_1);
    }
}

