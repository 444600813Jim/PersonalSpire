using Spire.Doc;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class315
{
    private readonly Interface55 interface55_0;
    private RectangleF rectangleF_0 = RectangleF.Empty;

    internal Class315(Interface55 A_0)
    {
        this.interface55_0 = A_0;
    }

    internal SizeF method_0(Class672 A_0)
    {
        spr➓ r➓ = new spr➓();
        this.method_1(A_0, r➓);
        Class1076 textBox = A_0.method_28().TextBox;
        SizeF size = this.rectangleF_0.Size;
        switch (smethod_2(A_0.method_28()))
        {
            case 90f:
            case -90f:
                size = new SizeF(size.Height, size.Width);
                break;
        }
        float num2 = (float) ((size.Width + textBox.method_0()) + textBox.method_2());
        return new SizeF((num2 > A_0.method_28().Width) ? num2 : ((float) A_0.method_28().Width), (float) ((size.Height + textBox.method_4()) + textBox.method_6()));
    }

    internal void method_1(Class672 A_0, spr➓ A_1)
    {
        if ((this.interface55_0 != null) && this.interface55_0.imethod_13(A_0.method_28()))
        {
            ShapeObject obj2 = A_0.method_28();
            float num = smethod_2(obj2);
            this.rectangleF_0 = smethod_0(A_0, num);
            float width = this.rectangleF_0.Width;
            spr➓ r➓ = this.method_4(A_0);
            if (r➓ != null)
            {
                r➓.ᜀ(this.method_6(num));
                Class551 class2 = this.method_2(obj2);
                r➓.ᜀ(sprᲆ.ᜂ(new RectangleF(-class2.method_0(), 0f, (class2.method_0() + class2.method_1()) + width, this.rectangleF_0.Height)));
                A_1.ᜁ(r➓);
            }
        }
    }

    private Class551 method_2(ShapeObject A_0)
    {
        float num;
        float num2;
        Class1076 textBox = A_0.TextBox;
        switch (textBox.method_10())
        {
            case LayoutFlow.TopToBottomIdeographic:
            case LayoutFlow.TopToBottom:
                num = (float) textBox.method_4();
                num2 = (float) textBox.method_6();
                break;

            case LayoutFlow.BottomToTop:
                num = (float) textBox.method_6();
                num2 = (float) textBox.method_4();
                break;

            default:
                num = (float) textBox.method_0();
                num2 = (float) textBox.method_2();
                break;
        }
        float num3 = (float) (5.0 + A_0.StrokeWeight);
        return new Class551(num + num3, num2 + num3);
    }

    internal bool method_3()
    {
        return ((this.interface55_0 != null) && this.interface55_0.imethod_14());
    }

    private spr➓ method_4(Class672 A_0)
    {
        ShapeObject obj2 = A_0.method_28();
        float num = Math.Max(0f, this.rectangleF_0.Width);
        float num2 = Math.Max(0f, this.rectangleF_0.Height);
        this.interface55_0.imethod_5(((obj2.TextBox.method_12() != TextBoxWrapMode.None) || !obj2.TextBox.method_8()) ? num : 0f);
        this.interface55_0.imethod_1(num2);
        object obj3 = this.interface55_0.imethod_11(obj2, new Class68());
        float y = this.rectangleF_0.Y;
        this.method_5(A_0.method_28().TextBox.method_14());
        Color color = (!obj2.Filled || (obj2.Fill.FillType != FillType.Solid)) ? Color.Empty : obj2.FillColor;
        if (obj2.IsFitTextboxToText && !this.method_3())
        {
            this.rectangleF_0 = new RectangleF(this.rectangleF_0.Location, new SizeF(this.interface55_0.imethod_4(), this.interface55_0.imethod_0()));
        }
        else if (this.interface55_0.imethod_4() > this.rectangleF_0.Width)
        {
            this.rectangleF_0 = new RectangleF(this.rectangleF_0.Location, new SizeF(this.interface55_0.imethod_4(), this.rectangleF_0.Height));
        }
        return this.interface55_0.imethod_12(obj3, new SizeF(this.interface55_0.imethod_4(), this.interface55_0.imethod_0()), (this.rectangleF_0.Height - this.rectangleF_0.Y) + y, color);
    }

    private void method_5(TextBoxAnchor A_0)
    {
        PointF location = smethod_1(this.rectangleF_0, new SizeF(this.interface55_0.imethod_4(), this.interface55_0.imethod_0()), A_0);
        this.rectangleF_0 = new RectangleF(location, this.rectangleF_0.Size);
    }

    private spr➂ method_6(float A_0)
    {
        spr➂ r➂ = new spr➂();
        r➂.ᜀ(A_0, MatrixOrder.Append);
        if (A_0 == 90f)
        {
            r➂.ᜀ(this.rectangleF_0.Height, 0f, MatrixOrder.Append);
        }
        else if (A_0 == -90f)
        {
            r➂.ᜀ(0f, this.rectangleF_0.Width, MatrixOrder.Append);
        }
        r➂.ᜀ(this.rectangleF_0.X, this.rectangleF_0.Y, MatrixOrder.Append);
        return r➂;
    }

    internal static RectangleF smethod_0(Class672 A_0, float A_1)
    {
        RectangleF ef = A_0.method_30();
        Class316 class2 = A_0.method_8();
        ShapeObject obj2 = A_0.method_28();
        float strokeWeight = (float) obj2.StrokeWeight;
        if ((strokeWeight <= 1f) || !obj2.Stroked)
        {
            strokeWeight = 0f;
        }
        float num2 = strokeWeight * 0.5f;
        float x = ef.X;
        float y = ef.Y;
        float width = ef.Width;
        float height = ef.Height;
        float num7 = x + width;
        float num8 = y + height;
        float num9 = A_0.method_33().Width;
        float num10 = A_0.method_33().Height;
        float num11 = ((float) obj2.TextBox.method_0()) + num2;
        float num12 = ((float) obj2.TextBox.method_4()) + num2;
        float num13 = ((float) obj2.TextBox.method_2()) + num2;
        float num14 = ((float) obj2.TextBox.method_6()) + num2;
        float coordSizeWidth = obj2.CoordSizeWidth;
        float coordSizeHeight = obj2.CoordSizeHeight;
        float num17 = (num9 - num11) - num13;
        float num18 = (num10 - num12) - num14;
        float num19 = x / coordSizeWidth;
        float num20 = num7 / coordSizeWidth;
        float num21 = y / coordSizeHeight;
        float num22 = num8 / coordSizeHeight;
        float num23 = (num17 * num19) + num11;
        float num24 = (num17 * num20) + num11;
        float num25 = (num18 * num21) + num12;
        float num26 = (num18 * num22) + num12;
        float num28 = (num9 == 0f) ? 1f : (coordSizeWidth / num9);
        float num27 = (num10 == 0f) ? 1f : (coordSizeHeight / num10);
        x = (num23 * num28) + num2;
        num7 = (num24 * num28) + num2;
        y = (num25 * num27) - num2;
        num8 = (num26 * num27) - num2;
        PointF[] tfArray2 = new PointF[] { new PointF(x, y), new PointF(num7, num8) };
        class2.method_1(tfArray2, true);
        width = tfArray2[1].X - tfArray2[0].X;
        height = tfArray2[1].Y - tfArray2[0].Y;
        SizeF size = smethod_3(obj2, width, height, A_1);
        PointF location = tfArray2[0];
        if (Class316.smethod_1(obj2))
        {
            float num29 = (height - width) * 0.5f;
            location = new PointF(location.X - num29, location.Y + num29);
        }
        return new RectangleF(location, size);
    }

    private static PointF smethod_1(RectangleF A_0, SizeF A_1, TextBoxAnchor A_2)
    {
        SizeF size = A_0.Size;
        PointF location = A_0.Location;
        if (size.Height <= A_1.Height)
        {
            return location;
        }
        switch (A_2)
        {
            case TextBoxAnchor.Top:
            case TextBoxAnchor.TopCentered:
            case TextBoxAnchor.MiddleCentered:
            case TextBoxAnchor.BottomCentered:
            case TextBoxAnchor.TopBaseline:
            case TextBoxAnchor.BottomBaseline:
            case TextBoxAnchor.TopCenteredBaseline:
            case TextBoxAnchor.BottomCenteredBaseline:
                return location;

            case TextBoxAnchor.Middle:
                return new PointF(location.X, location.Y + ((size.Height - A_1.Height) * 0.5f));

            case TextBoxAnchor.Bottom:
                return new PointF(location.X, location.Y + (size.Height - A_1.Height));
        }
        throw new ArgumentOutOfRangeException();
    }

    internal static float smethod_2(ShapeObject A_0)
    {
        switch (A_0.TextBox.method_10())
        {
            case LayoutFlow.TopToBottomIdeographic:
            case LayoutFlow.TopToBottom:
                return 90f;

            case LayoutFlow.BottomToTop:
                return -90f;
        }
        return 0f;
    }

    private static SizeF smethod_3(ShapeObject A_0, float A_1, float A_2, float A_3)
    {
        float width = A_1;
        float height = A_2;
        if (!(A_3 == 0f) ^ Class316.smethod_1(A_0))
        {
            width = A_2;
            height = A_1;
        }
        return new SizeF(width, height);
    }
}

