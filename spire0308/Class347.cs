using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class347 : Interface35
{
    internal bool bool_0;
    internal bool bool_1;
    internal bool bool_2;
    internal bool bool_3;
    internal static bool bool_4;
    internal HorizontalOrigin horizontalOrigin_0;
    internal const int int_0 = 0x1a;
    internal int int_1;
    internal int int_2;
    internal int int_3;
    internal int int_4;
    internal int int_5;
    internal int int_6;
    internal TextWrappingStyle textWrappingStyle_0;
    internal TextWrappingType textWrappingType_0;
    internal VerticalOrigin verticalOrigin_0;

    internal Class347(ShapeBase A_0)
    {
        this.int_1 = A_0.Id;
        this.bool_0 = false;
        this.bool_1 = false;
        Class265 class2 = Class265.smethod_3(A_0);
        TextWrappingStyle shapeAttribute = (TextWrappingStyle) A_0.GetShapeAttribute(0x1001);
        if (shapeAttribute != TextWrappingStyle.Inline)
        {
            this.horizontalOrigin_0 = A_0.HorizontalOrigin;
            this.verticalOrigin_0 = A_0.VerticalOrigin;
            if (this.horizontalOrigin_0 > HorizontalOrigin.Column)
            {
                this.horizontalOrigin_0 = HorizontalOrigin.Column;
            }
            if (this.verticalOrigin_0 > VerticalOrigin.Paragraph)
            {
                this.verticalOrigin_0 = VerticalOrigin.Paragraph;
            }
            this.textWrappingStyle_0 = (shapeAttribute == TextWrappingStyle.Behind) ? TextWrappingStyle.InFrontOfText : shapeAttribute;
            this.textWrappingType_0 = A_0.TextWrappingType;
            this.bool_2 = A_0.BehindText;
            this.bool_3 = A_0.AnchorLocked;
        }
        else
        {
            class2.double_0 = 0.0;
            class2.double_1 = 0.0;
            this.horizontalOrigin_0 = HorizontalOrigin.Column;
            this.verticalOrigin_0 = VerticalOrigin.Paragraph;
            this.textWrappingStyle_0 = TextWrappingStyle.InFrontOfText;
            this.textWrappingType_0 = TextWrappingType.Both;
            this.bool_2 = false;
            this.bool_3 = true;
        }
        this.int_2 = Class969.smethod_31(class2.double_0);
        this.int_3 = Class969.smethod_31(class2.double_1);
        this.int_4 = Class969.smethod_31(class2.double_0 + class2.double_2);
        this.int_5 = Class969.smethod_31(class2.double_1 + class2.double_3);
        this.int_6 = 0;
    }

    internal Class347(BinaryReader A_0)
    {
        this.int_1 = A_0.ReadInt32();
        this.int_2 = A_0.ReadInt32();
        this.int_3 = A_0.ReadInt32();
        this.int_4 = A_0.ReadInt32();
        this.int_5 = A_0.ReadInt32();
        int num = A_0.ReadUInt16();
        this.bool_0 = (num & 1) != 0;
        this.horizontalOrigin_0 = (HorizontalOrigin) ((num & 6) >> 1);
        this.verticalOrigin_0 = (VerticalOrigin) ((num & 0x18) >> 3);
        this.textWrappingStyle_0 = (TextWrappingStyle) ((num & 480) >> 5);
        this.textWrappingType_0 = (TextWrappingType) ((num & 0x1e00) >> 9);
        this.bool_1 = (num & 0x2000) != 0;
        this.bool_2 = (num & 0x4000) != 0;
        this.bool_3 = (num & 0x8000) != 0;
        if (this.bool_2 && (this.textWrappingStyle_0 == TextWrappingStyle.InFrontOfText))
        {
            this.textWrappingStyle_0 = TextWrappingStyle.Behind;
        }
        this.int_6 = A_0.ReadInt32();
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write(this.int_1);
        A_0.Write(this.int_2);
        A_0.Write(this.int_3);
        A_0.Write(this.int_4);
        A_0.Write(this.int_5);
        int num = 0;
        num = 0 | (this.bool_0 ? 1 : 0);
        num |= ((int) this.horizontalOrigin_0) << 1;
        num |= ((int) this.verticalOrigin_0) << 3;
        num |= ((int) this.textWrappingStyle_0) << 5;
        num |= ((int) this.textWrappingType_0) << 9;
        num |= this.bool_1 ? 0x2000 : 0;
        num |= this.bool_2 ? 0x4000 : 0;
        num |= this.bool_3 ? 0x8000 : 0;
        A_0.Write((ushort) num);
        A_0.Write(this.int_6);
    }

    internal void method_0(ShapeBase A_0, bool A_1)
    {
        Class265.smethod_1(A_0, (double) this.int_2, (double) this.int_4, (double) this.int_3, (double) this.int_5);
        Class43 shapePr = A_0.ShapePr;
        smethod_0(shapePr, 0x1002, this.textWrappingType_0);
        smethod_0(shapePr, 0x1003, this.bool_3);
        smethod_0(shapePr, 0x3ba, this.bool_2);
        if (!shapePr.method_47() && (this.textWrappingStyle_0 == TextWrappingStyle.Behind))
        {
            this.textWrappingStyle_0 = TextWrappingStyle.InFrontOfText;
        }
        if (shapePr.method_47() && (this.textWrappingStyle_0 == TextWrappingStyle.InFrontOfText))
        {
            this.textWrappingStyle_0 = TextWrappingStyle.Behind;
        }
        smethod_0(shapePr, 0x1001, this.textWrappingStyle_0);
        if (!A_1)
        {
            smethod_0(shapePr, 0x390, this.horizontalOrigin_0);
            smethod_0(shapePr, 0x392, this.verticalOrigin_0);
        }
    }

    private static void smethod_0(Class43 A_0, int A_1, object A_2)
    {
        if (!A_0.method_6(A_1))
        {
            A_0.SetAttr(A_1, A_2);
        }
    }
}

