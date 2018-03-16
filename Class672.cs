using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class672
{
    private bool bool_0;
    private readonly Class316 class316_0;
    private readonly Class316 class316_1;
    private Class679[] class679_0;
    private Class724 class724_0;
    private object object_0;
    private PointF[] pointF_0;
    private PointF pointF_1;
    private RectangleF rectangleF_0;
    private ShapeObject shapeObject_0;
    private readonly SizeF sizeF_0;
    private readonly SizeF sizeF_1;
    private sprᲆ sprᲆ_0;
    private spr⚪ spr⚪_0;
    private spr➓ spr➓_0;
    private readonly sprℭ sprℭ_0;
    private spr᧢ spr᧢_0;
    private sprᧂ sprᧂ_0;
    private sprᮃ sprᮃ_0;
    private VMLFill vmlfill_0;

    internal Class672(Class672 A_0, Class679[] A_1)
    {
        this.rectangleF_0 = RectangleF.Empty;
        this.pointF_1 = PointF.Empty;
        this.sizeF_0 = SizeF.Empty;
        this.sizeF_1 = SizeF.Empty;
        this.class724_0 = A_0.class724_0;
        this.sprℭ_0 = A_0.sprℭ_0;
        this.shapeObject_0 = A_0.method_28();
        this.class316_0 = A_0.class316_0;
        this.sizeF_0 = A_0.sizeF_0;
        this.sizeF_1 = A_0.sizeF_1;
        this.spr➓_0 = new spr➓();
        Class889.smethod_0(this);
        this.class679_0 = A_1;
    }

    internal Class672(Class724 A_0, Class673 A_1, sprℭ A_2)
    {
        this.rectangleF_0 = RectangleF.Empty;
        this.pointF_1 = PointF.Empty;
        this.sizeF_0 = SizeF.Empty;
        this.sizeF_1 = SizeF.Empty;
        this.class724_0 = A_0;
        this.sprℭ_0 = A_2;
        this.shapeObject_0 = (ShapeObject) A_0.method_3();
        this.class316_0 = new Class316(this.shapeObject_0, A_0.method_4(), A_1);
        this.class316_1 = new Class316(this.shapeObject_0, A_0.method_4(), A_1, this.shapeObject_0.Owner is ShapeGroup);
        if (A_0.method_4().IsEmpty)
        {
            this.sizeF_0 = A_0.method_3().Size;
            this.sizeF_1 = A_0.method_3().SizeInPoints;
        }
        else
        {
            this.sizeF_0 = A_0.method_4();
            this.sizeF_1 = A_0.method_4();
        }
        this.spr➓_0 = new spr➓();
        Class889.smethod_0(this);
    }

    private void method_0()
    {
        this.sprᲆ_0 = new sprᲆ();
        this.sprᲆ_0.ᜀ(this.method_18());
        this.sprᲆ_0.ᜀ(this.method_19());
        this.spr➓_0.ᜁ(this.sprᲆ_0);
    }

    private void method_1()
    {
        this.sprᧂ_0 = new sprᧂ();
        this.sprᧂ_0.ᜀ(false);
        this.method_16().ᜁ(this.sprᧂ_0);
    }

    internal spr➓ method_10()
    {
        return this.spr➓_0;
    }

    internal void method_11(spr➓ A_0)
    {
        this.spr➓_0 = A_0;
    }

    internal Class679[] method_12()
    {
        return this.class679_0;
    }

    internal void method_13(Class679[] A_0)
    {
        this.class679_0 = A_0;
    }

    internal PointF[] method_14()
    {
        return this.pointF_0;
    }

    internal void method_15(PointF[] A_0)
    {
        this.pointF_0 = A_0;
    }

    internal sprᲆ method_16()
    {
        if (this.sprᲆ_0 == null)
        {
            this.method_0();
        }
        return this.sprᲆ_0;
    }

    internal sprᧂ method_17()
    {
        if (this.sprᧂ_0 == null)
        {
            this.method_1();
        }
        return this.sprᧂ_0;
    }

    internal spr⚪ method_18()
    {
        if (this.spr⚪_0 == null)
        {
            this.method_2();
        }
        return this.spr⚪_0;
    }

    internal spr᧢ method_19()
    {
        if (this.spr᧢_0 == null)
        {
            this.method_5();
        }
        return this.spr᧢_0;
    }

    private void method_2()
    {
        Class826 stroke = this.shapeObject_0.Stroke;
        if (!stroke.method_0())
        {
            this.spr⚪_0 = null;
        }
        else
        {
            switch (stroke.method_12())
            {
                case LineFillType.Pattern:
                {
                    spr᧢ r᧢2 = Class1075.smethod_2(stroke.method_36(), null, sprឦ.ᜀ(stroke.method_6()), sprឦ.ᜀ(stroke.method_10()));
                    this.spr⚪_0 = new spr⚪(r᧢2);
                    break;
                }
                case LineFillType.Texture:
                case LineFillType.Picture:
                {
                    spr⍂ r⍂ = new spr⍂(stroke.method_36());
                    this.spr⚪_0 = new spr⚪(r⍂);
                    break;
                }
                default:
                {
                    spr᧢ r᧢ = Class1075.smethod_1(sprⓚ.ᜀ(stroke.method_6()), stroke.method_34());
                    this.spr⚪_0 = new spr⚪(r᧢);
                    break;
                }
            }
            this.spr⚪_0.ᜀ(Class1022.smethod_2(stroke.method_16()));
            this.spr⚪_0.ᜂ(this.method_27());
            this.method_3(stroke);
            this.method_4(stroke);
            LineCap cap = Class1022.smethod_3(stroke.method_18());
            this.spr⚪_0.ᜀ(Class1022.smethod_4(stroke.method_18()));
            this.spr⚪_0.ᜀ(cap);
            this.spr⚪_0.ᜁ(cap);
        }
    }

    private VMLFill method_20()
    {
        if (this.vmlfill_0 == null)
        {
            this.vmlfill_0 = new VMLFill(this.shapeObject_0);
        }
        return this.vmlfill_0;
    }

    internal PointF method_21()
    {
        return this.pointF_1;
    }

    internal void method_22(PointF A_0)
    {
        this.pointF_1 = A_0;
    }

    internal bool method_23()
    {
        return this.bool_0;
    }

    internal void method_24(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal sprᮃ method_25()
    {
        return this.sprᮃ_0;
    }

    internal void method_26(sprᮃ A_0)
    {
        this.sprᮃ_0 = A_0;
    }

    internal float method_27()
    {
        if (this.object_0 == null)
        {
            this.object_0 = this.shapeObject_0.LineWidth;
        }
        return (float) this.object_0;
    }

    internal ShapeObject method_28()
    {
        return this.shapeObject_0;
    }

    internal void method_29(ShapeObject A_0)
    {
        this.shapeObject_0 = A_0;
    }

    private void method_3(Class826 A_0)
    {
        switch (A_0.method_20())
        {
            case ShapeLineStyle.Single:
            {
                float[] numArray = new float[2];
                numArray[1] = 1f;
                this.spr⚪_0.ᜀ(numArray);
                return;
            }
            case ShapeLineStyle.Double:
                this.spr⚪_0.ᜀ(new float[] { 0f, 0.3333333f, 0.6666667f, 1f });
                return;

            case ShapeLineStyle.ThickThin:
                this.spr⚪_0.ᜀ(new float[] { 0f, 0.6f, 0.8f, 1f });
                return;

            case ShapeLineStyle.ThinThick:
                this.spr⚪_0.ᜀ(new float[] { 0f, 0.2f, 0.4f, 1f });
                return;

            case ShapeLineStyle.Triple:
                this.spr⚪_0.ᜀ(new float[] { 0f, 0.1666667f, 0.3333333f, 0.6666667f, 0.8333333f, 1f });
                return;
        }
    }

    internal RectangleF method_30()
    {
        return this.rectangleF_0;
    }

    internal void method_31(RectangleF A_0)
    {
        this.rectangleF_0 = A_0;
    }

    internal SizeF method_32()
    {
        return this.sizeF_0;
    }

    internal SizeF method_33()
    {
        return this.sizeF_1;
    }

    internal sprℭ method_34()
    {
        return this.sprℭ_0;
    }

    private void method_4(Class826 A_0)
    {
        switch (A_0.method_14())
        {
            case LineDashing.Solid:
                this.spr⚪_0.ᜀ(DashStyle.Solid);
                return;

            case LineDashing.Dash:
                this.spr⚪_0.ᜀ(DashStyle.Dash);
                return;

            case LineDashing.Dot:
                this.spr⚪_0.ᜀ(DashStyle.Dot);
                return;

            case LineDashing.DashDot:
                this.spr⚪_0.ᜀ(DashStyle.DashDot);
                return;

            case LineDashing.DashDotDot:
                this.spr⚪_0.ᜀ(DashStyle.DashDotDot);
                return;

            case LineDashing.DotGEL:
                this.spr⚪_0.ᜁ(new float[] { 1f, 3f });
                return;

            case LineDashing.DashGEL:
                this.spr⚪_0.ᜁ(new float[] { 4f, 3f });
                return;

            case LineDashing.LongDashGEL:
                this.spr⚪_0.ᜁ(new float[] { 8f, 3f });
                return;

            case LineDashing.DashDotGEL:
                this.spr⚪_0.ᜁ(new float[] { 4f, 3f, 1f, 3f });
                return;

            case LineDashing.LongDashDotGEL:
                this.spr⚪_0.ᜁ(new float[] { 8f, 3f, 1f, 3f });
                return;

            case LineDashing.LongDashDotDotGEL:
                this.spr⚪_0.ᜁ(new float[] { 8f, 3f, 1f, 3f, 1f, 3f });
                return;
        }
    }

    private void method_5()
    {
        VMLFill fill = this.method_20();
        if (!fill.On)
        {
            this.spr᧢_0 = null;
        }
        else
        {
            if (this.shapeObject_0.IsTextureRotated)
            {
                double rotation = this.shapeObject_0.Rotation;
            }
            switch (fill.FillType)
            {
                case FillType.Pattern:
                    this.spr᧢_0 = Class1075.smethod_2(fill.ImageBytes, this.class724_0.method_11(), sprⓚ.ᜀ(fill.ColorInternal), sprⓚ.ᜀ(fill.Color2Internal));
                    return;

                case FillType.Texture:
                    this.spr᧢_0 = Class1075.smethod_15(fill, this.class724_0.method_11(), this.class316_0);
                    return;

                case FillType.Picture:
                    this.spr᧢_0 = Class1075.smethod_3(fill, this.class724_0.method_11(), this.class316_0);
                    return;

                case FillType.Shade:
                case FillType.ShadeScale:
                case FillType.ShadeTitle:
                case FillType.ShadeUnscale:
                    this.spr᧢_0 = Class1075.smethod_14(this.shapeObject_0, this.sizeF_1);
                    return;

                case FillType.ShadeCenter:
                    this.spr᧢_0 = Class1075.smethod_13(this.shapeObject_0, this.sizeF_1);
                    return;

                case FillType.ShadeShape:
                    this.spr᧢_0 = this.method_28().IsWordArt ? Class1075.smethod_13(this.shapeObject_0, this.sizeF_1) : Class1075.smethod_6(this.sprᲆ_0, fill, new PointF(this.sizeF_1.Width * 0.5f, this.sizeF_1.Height * 0.5f));
                    return;
            }
            this.spr᧢_0 = Class1075.smethod_1(sprⓚ.ᜀ(fill.ColorInternal), fill.Opacity);
        }
    }

    internal void method_6()
    {
        this.sprᲆ_0 = null;
        this.spr⚪_0 = null;
        this.object_0 = null;
        this.method_7();
    }

    internal void method_7()
    {
        this.sprᧂ_0 = null;
        this.pointF_1 = PointF.Empty;
        this.bool_0 = false;
        this.sprᮃ_0 = null;
    }

    internal Class316 method_8()
    {
        return this.class316_0;
    }

    internal Class316 method_9()
    {
        return this.class316_1;
    }
}

