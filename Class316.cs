using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Fields.Shape.Ps;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class316
{
    private readonly float float_0;
    private readonly float float_1;
    private readonly float float_2;
    private float float_3;
    private readonly int int_0;
    private readonly int int_1;
    private LimoStretchType limoStretchType_0;
    private PointF pointF_0;
    private readonly ShapeObject shapeObject_0;
    private SizeF sizeF_0;
    private readonly spr➂ spr➂_0;
    private spr➂ spr➂_1;
    private spr➂ spr➂_2;

    internal Class316(ShapeObject A_0, SizeF A_1, Class673 A_2)
    {
        this.sizeF_0 = SizeF.Empty;
        this.shapeObject_0 = A_0;
        this.sizeF_0 = A_1.IsEmpty ? this.shapeObject_0.Size : A_1;
        this.spr➂_0 = A_2.method_0();
        SizeF ef = smethod_0(A_0, A_2.method_1(), A_2.method_2());
        this.float_0 = ef.Width;
        this.float_1 = ef.Height;
        this.float_2 = A_2.method_3();
        this.limoStretchType_0 = LimoStretchType.None;
        this.float_3 = 0f;
        this.spr➂_1 = null;
        this.int_0 = A_0.LimoX;
        this.int_1 = A_0.LimoY;
        this.method_7(false);
    }

    internal Class316(ShapeObject A_0, SizeF A_1, Class673 A_2, bool A_3)
    {
        this.sizeF_0 = SizeF.Empty;
        this.shapeObject_0 = A_0;
        this.sizeF_0 = A_1.IsEmpty ? this.shapeObject_0.Size : A_1;
        this.spr➂_0 = A_2.method_0();
        SizeF ef = smethod_0(A_0, A_2.method_1(), A_2.method_2());
        this.float_0 = ef.Width;
        this.float_1 = ef.Height;
        this.float_2 = A_2.method_3();
        this.limoStretchType_0 = LimoStretchType.None;
        this.float_3 = 0f;
        this.spr➂_1 = null;
        this.int_0 = A_0.LimoX;
        this.int_1 = A_0.LimoY;
        this.method_7(A_3);
    }

    internal PointF method_0()
    {
        return smethod_4(this.shapeObject_0, this.sizeF_0, this.float_0, this.float_1);
    }

    internal void method_1(PointF[] A_0, bool A_1)
    {
        if (this.limoStretchType_0 != LimoStretchType.None)
        {
            for (int i = 0; i < A_0.Length; i++)
            {
                PointF tf = A_0[i];
                float x = tf.X;
                float y = tf.Y;
                if (this.limoStretchType_0 == LimoStretchType.AlongX)
                {
                    if (x > this.int_0)
                    {
                        x += this.float_3;
                    }
                }
                else if (y > this.int_1)
                {
                    y += this.float_3;
                }
                A_0[i] = new PointF(x, y);
            }
        }
        if (A_1)
        {
            this.spr➂_2.ᜀ(A_0);
        }
        else
        {
            this.spr➂_1.ᜀ(A_0);
        }
    }

    internal spr➂ method_2(spr❯ A_0, bool A_1, VMLFill A_2)
    {
        return this.method_3(A_0, A_1, A_2);
    }

    internal spr➂ method_3(spr❯ A_0, bool A_1, VMLFill A_2)
    {
        PointF[] tfArray2 = new PointF[] { PointF.Empty, new PointF((float) this.shapeObject_0.CoordSizeWidth, 0f), new PointF((float) this.shapeObject_0.CoordSizeWidth, (float) this.shapeObject_0.CoordSizeHeight), new PointF(0f, (float) this.shapeObject_0.CoordSizeHeight) };
        this.method_1(tfArray2, false);
        RectangleF ef = smethod_6(tfArray2);
        float x = ef.X;
        float y = ef.Y;
        float width = ef.Width;
        float height = ef.Height;
        if (this.shapeObject_0.IsTextureRotated)
        {
            RectangleF ef2 = this.shapeObject_0.method_47(new RectangleF(0f, 0f, this.sizeF_0.Width, this.sizeF_0.Height));
            width = ef2.Width;
            height = ef2.Height;
        }
        RectangleF ef3 = new RectangleF(x, y, width, height);
        if (!A_2.Tiled)
        {
            this.method_6(ref ef3, A_2.Stretch);
        }
        else
        {
            this.method_4(ref ef3, A_2.Tile, A_0, ef);
        }
        x = ef3.X;
        y = ef3.Y;
        width = ef3.Width;
        height = ef3.Height;
        float num6 = width / ((float) A_0.ᜑ().Width);
        float num5 = height / ((float) A_0.ᜑ().Height);
        if (A_1)
        {
            if (num6 > num5)
            {
                num5 = num6;
            }
            else
            {
                num6 = num5;
            }
        }
        spr➂ r➂ = new spr➂();
        r➂.ᜁ(num6, num5, MatrixOrder.Prepend);
        double num7 = this.float_2 + this.shapeObject_0.Rotation;
        if (this.shapeObject_0.IsTextureRotated && (num7 != 0.0))
        {
            x = tfArray2[0].X;
            y = tfArray2[0].Y;
            r➂.ᜀ((float) num7, MatrixOrder.Append);
        }
        r➂.ᜀ(x, y, MatrixOrder.Append);
        return r➂;
    }

    private void method_4(ref RectangleF A_0, Struct37 A_1, spr❯ A_2, RectangleF A_3)
    {
        A_0.Width = (((float) A_2.ᜅ()) * A_1.float_0) / 100f;
        A_0.Height = (((float) A_2.ᜃ()) * A_1.float_1) / 100f;
        this.method_5(ref A_0, A_3, A_1.rectAlignment_0);
        A_0.X += A_1.float_2;
        A_0.Y += A_1.float_3;
    }

    private void method_5(ref RectangleF A_0, RectangleF A_1, RectAlignment A_2)
    {
        float num = 0f;
        float num2 = 0f;
        switch (A_2)
        {
            case RectAlignment.TopLeft:
                break;

            case RectAlignment.Bottom:
                num = A_1.Height - A_0.Height;
                num2 = (A_1.Width - A_0.Width) / 2f;
                A_0.X += num2;
                A_0.Y += num;
                return;

            case RectAlignment.BottomLeft:
                num = A_1.Height - A_0.Height;
                A_0.Y += num;
                return;

            case RectAlignment.BottomRight:
                num = A_1.Height - A_0.Height;
                num2 = A_1.Width - A_0.Width;
                A_0.X += num2;
                A_0.Y += num;
                return;

            case RectAlignment.Center:
                num = (A_1.Height - A_0.Height) / 2f;
                num2 = (A_1.Width - A_0.Width) / 2f;
                A_0.X += num2;
                A_0.Y += num;
                return;

            case RectAlignment.Left:
                num = (A_1.Height - A_0.Height) / 2f;
                A_0.Y += num;
                return;

            case RectAlignment.Right:
                num = (A_1.Height - A_0.Height) / 2f;
                num2 = A_1.Width - A_0.Width;
                A_0.X += num2;
                A_0.Y += num;
                return;

            case RectAlignment.Top:
                num2 = (A_1.Width - A_0.Width) / 2f;
                A_0.X += num2;
                return;

            case RectAlignment.TopRight:
                num2 = A_1.Width - A_0.Width;
                A_0.X += num2;
                break;

            default:
                return;
        }
    }

    private void method_6(ref RectangleF A_0, Struct36 A_1)
    {
        if (A_1.float_0 != 0f)
        {
            A_0.Y += (A_0.Height * A_1.float_0) / 100f;
            A_0.Height -= (A_0.Height * A_1.float_0) / 100f;
        }
        if (A_1.float_1 != 0f)
        {
            A_0.Height -= (A_0.Height * A_1.float_1) / 100f;
        }
        if (A_1.float_2 != 0f)
        {
            A_0.X += (A_0.Width * A_1.float_2) / 100f;
            A_0.Width -= (A_0.Width * A_1.float_2) / 100f;
        }
        if (A_1.float_3 != 0f)
        {
            A_0.Width -= (A_0.Width * A_1.float_3) / 100f;
        }
    }

    private void method_7(bool A_0)
    {
        int num6 = A_0 ? 0 : this.shapeObject_0.CoordOriginX;
        int num9 = A_0 ? 0 : this.shapeObject_0.CoordOriginY;
        int coordSizeWidth = this.shapeObject_0.CoordSizeWidth;
        int coordSizeHeight = this.shapeObject_0.CoordSizeHeight;
        float num8 = coordSizeWidth * 0.5f;
        float num4 = coordSizeHeight * 0.5f;
        float num3 = this.sizeF_0.Width / ((float) coordSizeWidth);
        float num2 = this.sizeF_0.Height / ((float) coordSizeHeight);
        float rotation = (float) this.shapeObject_0.Rotation;
        if ((this.int_0 != 0) || (this.int_1 != 0))
        {
            if (num3 > num2)
            {
                this.limoStretchType_0 = LimoStretchType.AlongX;
                this.float_3 = coordSizeWidth * ((num3 / num2) - 1f);
                num8 += this.float_3 * 0.5f;
            }
            else
            {
                this.limoStretchType_0 = LimoStretchType.AlongY;
                this.float_3 = coordSizeHeight * ((num2 / num3) - 1f);
                num4 += this.float_3 * 0.5f;
            }
            float num5 = Math.Min(num3, num2);
            num3 = num5;
            num2 = num5;
        }
        this.method_8(num3, num2, num8, num4, (float) num6, (float) num9);
        this.spr➂_1 = new spr➂();
        this.spr➂_1.ᜀ((float) -num6, (float) -num9, MatrixOrder.Append);
        this.spr➂_1.ᜀ(-num8, -num4, MatrixOrder.Append);
        num3 *= this.float_0;
        num2 *= this.float_1;
        this.spr➂_2 = this.spr➂_1.ᜎ();
        this.spr➂_1.ᜁ(num3, num2, MatrixOrder.Append);
        this.spr➂_2.ᜁ(num3, num2, MatrixOrder.Append);
        this.spr➂_1.ᜀ(rotation, MatrixOrder.Append);
        smethod_7(this.shapeObject_0, this.spr➂_1);
        this.spr➂_1.ᜀ(this.float_2, MatrixOrder.Append);
        this.spr➂_1.ᜀ(num8 * num3, num4 * num2, MatrixOrder.Append);
        this.spr➂_2.ᜀ(num8 * num3, num4 * num2, MatrixOrder.Append);
    }

    private void method_8(float A_0, float A_1, float A_2, float A_3, float A_4, float A_5)
    {
        PointF[] tfArray2 = new PointF[] { new PointF(A_2, A_3) };
        spr➂ r➂ = new spr➂();
        r➂.ᜀ(-A_4, -A_5, MatrixOrder.Append);
        r➂.ᜁ(A_0, A_1, MatrixOrder.Append);
        if (!this.shapeObject_0.IsTopLevel)
        {
            r➂.ᜀ((float) this.shapeObject_0.Left, (float) this.shapeObject_0.Top, MatrixOrder.Append);
        }
        r➂.ᜀ(this.spr➂_0, MatrixOrder.Append);
        r➂.ᜀ((-A_2 * A_0) * this.float_0, (-A_3 * A_1) * this.float_1, MatrixOrder.Append);
        r➂.ᜀ(tfArray2);
        this.pointF_0 = tfArray2[0];
    }

    internal PointF method_9()
    {
        return this.pointF_0;
    }

    internal static SizeF smethod_0(ShapeBase A_0, float A_1, float A_2)
    {
        if (!smethod_1(A_0))
        {
            return new SizeF(A_1, A_2);
        }
        return new SizeF(A_2, A_1);
    }

    internal static bool smethod_1(ShapeBase A_0)
    {
        return smethod_2((float) A_0.Rotation);
    }

    internal static bool smethod_2(float A_0)
    {
        A_0 = smethod_3(A_0);
        return (((A_0 >= 45f) && (A_0 < 135f)) || ((A_0 >= 225f) && (A_0 < 315f)));
    }

    internal static float smethod_3(float A_0)
    {
        if (Math.Abs(A_0) > 360f)
        {
            A_0 = A_0 % 360f;
        }
        if (A_0 < 0f)
        {
            A_0 += 360f;
        }
        return A_0;
    }

    private static PointF smethod_4(ShapeBase A_0, SizeF A_1, float A_2, float A_3)
    {
        int coordSizeWidth = A_0.CoordSizeWidth;
        int coordSizeHeight = A_0.CoordSizeHeight;
        float num3 = A_1.Width / ((float) coordSizeWidth);
        float num4 = A_1.Height / ((float) coordSizeHeight);
        if (A_0 is ShapeObject)
        {
            ShapeObject obj2 = (ShapeObject) A_0;
            if ((obj2.LimoX != 0) || (obj2.LimoY != 0))
            {
                float num5 = Math.Min(num3, num4);
                num3 = num5;
                num4 = num5;
            }
        }
        num3 *= A_2;
        num4 *= A_3;
        return new PointF((num3 == 0f) ? 1f : num3, (num4 == 0f) ? 1f : num4);
    }

    internal static SizeF smethod_5(SizeF A_0, ShapeBase A_1, float A_2, float A_3)
    {
        if (A_0.IsEmpty)
        {
            return A_0;
        }
        PointF tf = smethod_4(A_1, A_1.Size, A_2, A_3);
        return new SizeF(A_0.Width / tf.X, A_0.Height / tf.Y);
    }

    internal static RectangleF smethod_6(PointF[] A_0)
    {
        float x = A_0[0].X;
        float num2 = x;
        float y = A_0[0].Y;
        float num4 = y;
        for (int i = 0; i < A_0.Length; i++)
        {
            PointF tf = A_0[i];
            if (tf.X > num2)
            {
                num2 = tf.X;
            }
            else if (tf.X < x)
            {
                x = tf.X;
            }
            if (tf.Y > num4)
            {
                num4 = tf.Y;
            }
            else if (tf.Y < y)
            {
                y = tf.Y;
            }
        }
        return new RectangleF(x, y, num2 - x, num4 - y);
    }

    private static void smethod_7(ShapeBase A_0, spr➂ A_1)
    {
        switch (A_0.FlipOrientation)
        {
            case FlipOrientation.None:
                break;

            case FlipOrientation.Horizontal:
                A_1.ᜁ(-1f, 1f, MatrixOrder.Append);
                return;

            case FlipOrientation.Vertical:
                A_1.ᜁ(1f, -1f, MatrixOrder.Append);
                break;

            case FlipOrientation.Both:
                A_1.ᜁ(-1f, -1f, MatrixOrder.Append);
                return;

            default:
                return;
        }
    }

    internal static spr➂ smethod_8(ShapeBase A_0, Class673 A_1)
    {
        float num7;
        float num8;
        int coordOriginX = A_0.CoordOriginX;
        int coordOriginY = A_0.CoordOriginY;
        float width = (float) A_0.Width;
        float height = (float) A_0.Height;
        float num5 = width * 0.5f;
        float num6 = height * 0.5f;
        spr➂ r➂ = new spr➂();
        r➂.ᜀ((float) -coordOriginX, (float) -coordOriginY, MatrixOrder.Append);
        r➂.ᜀ(-num5, -num6, MatrixOrder.Append);
        switch (A_0.FlipOrientation)
        {
            case FlipOrientation.Horizontal:
                r➂.ᜁ(-1f, 1f, MatrixOrder.Append);
                break;

            case FlipOrientation.Vertical:
                r➂.ᜁ(1f, -1f, MatrixOrder.Append);
                break;

            case FlipOrientation.Both:
                r➂.ᜁ(-1f, -1f, MatrixOrder.Append);
                break;
        }
        float num9 = ((float) A_0.Rotation) + A_1.method_3();
        r➂.ᜁ(A_1.method_1(), A_1.method_2(), MatrixOrder.Append);
        r➂.ᜀ(num9, MatrixOrder.Append);
        if (((Math.Abs((float) (num9 % 180f)) == 90f) && !A_0.IsInline) && !(A_0.ParentObject is ShapeGroup))
        {
            num7 = num6;
            num8 = num5;
        }
        else
        {
            num7 = num5;
            num8 = num6;
        }
        r➂.ᜀ(num7 * A_1.method_1(), num8 * A_1.method_2(), MatrixOrder.Append);
        return r➂;
    }

    internal static spr➂ smethod_9(ShapeBase A_0, SizeF A_1, bool A_2)
    {
        int coordOriginX = A_0.CoordOriginX;
        int coordOriginY = A_0.CoordOriginY;
        int coordSizeWidth = A_0.CoordSizeWidth;
        int coordSizeHeight = A_0.CoordSizeHeight;
        float num5 = coordSizeWidth * 0.5f;
        float num6 = coordSizeHeight * 0.5f;
        if (A_1.IsEmpty)
        {
            A_1 = A_0.Size;
        }
        float num7 = A_1.Width / ((float) coordSizeWidth);
        float num8 = A_1.Height / ((float) coordSizeHeight);
        if (A_2)
        {
            num7 = A_1.Height / ((float) coordSizeHeight);
            num8 = A_1.Width / ((float) coordSizeWidth);
        }
        spr➂ r➂ = new spr➂();
        r➂.ᜀ((float) -coordOriginX, (float) -coordOriginY, MatrixOrder.Append);
        r➂.ᜀ(-num5, -num6, MatrixOrder.Append);
        switch (A_0.FlipOrientation)
        {
            case FlipOrientation.Horizontal:
                r➂.ᜁ(-1f, 1f, MatrixOrder.Append);
                break;

            case FlipOrientation.Vertical:
                r➂.ᜁ(1f, -1f, MatrixOrder.Append);
                break;

            case FlipOrientation.Both:
                r➂.ᜁ(-1f, -1f, MatrixOrder.Append);
                break;
        }
        r➂.ᜁ(num7, num8, MatrixOrder.Append);
        r➂.ᜀ((float) A_0.Rotation, MatrixOrder.Append);
        r➂.ᜀ(num5 * num7, num6 * num8, MatrixOrder.Append);
        if (!A_0.IsTopLevel)
        {
            r➂.ᜀ((float) A_0.Left, (float) A_0.Top, MatrixOrder.Append);
        }
        return r➂;
    }
}

