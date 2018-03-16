using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Drawing;

internal class Class725
{
    private float float_0;
    private float float_1;
    private float float_2;
    private float float_3;

    private RectangleF method_0(Class724 A_0, spr➓ A_1)
    {
        PointF[] tfArray = smethod_1(A_0, A_1);
        if (A_0.method_3().ShapeType != ShapeType.Group)
        {
            smethod_4(A_0, tfArray);
        }
        this.method_1(tfArray);
        return new RectangleF(this.float_0, this.float_2, this.float_1 - this.float_0, this.float_3 - this.float_2);
    }

    private void method_1(PointF[] A_0)
    {
        this.float_0 = A_0[0].X;
        this.float_2 = A_0[0].Y;
        this.float_1 = this.float_0;
        this.float_3 = this.float_2;
        for (int i = 0; i < 4; i++)
        {
            PointF tf = A_0[i];
            if (tf.X < this.float_0)
            {
                this.float_0 = tf.X;
            }
            else if (tf.X > this.float_1)
            {
                this.float_1 = tf.X;
            }
            if (tf.Y < this.float_2)
            {
                this.float_2 = tf.Y;
            }
            else if (tf.Y > this.float_3)
            {
                this.float_3 = tf.Y;
            }
        }
    }

    internal static RectangleF smethod_0(Class724 A_0, spr➓ A_1)
    {
        Class725 class2 = new Class725();
        return class2.method_0(A_0, A_1);
    }

    private static PointF[] smethod_1(Class724 A_0, spr➓ A_1)
    {
        RectangleF ef;
        if (A_0.method_3().ShapeType == ShapeType.Group)
        {
            ef = smethod_2(A_1);
            PointF[] tfArray = spr⃸.ᜀ(smethod_3(A_0));
            smethod_4(A_0, tfArray);
            ef = (ef == RectangleF.Empty) ? smethod_3(A_0) : spr⃸.ᜀ(ef, spr⃸.ᜁ(tfArray));
            return spr⃸.ᜀ(ef);
        }
        ef = smethod_3(A_0);
        ShapeObject obj2 = (ShapeObject) A_0.method_3();
        float left = ef.Left;
        float top = ef.Top;
        float right = ef.Right;
        float bottom = ef.Bottom;
        float num5 = 0f;
        float num6 = 0f;
        float num7 = 0f;
        float num8 = 0f;
        Class826 stroke = obj2.Stroke;
        bool flag = Class1022.smethod_1(obj2);
        if (stroke.method_0())
        {
            num5 = (float) stroke.method_2();
            num6 = num5;
            num7 = num5;
            num8 = num5;
        }
        float num9 = flag ? 1f : 0.5f;
        left -= num7 * num9;
        top -= num5 * num9;
        right += num8 * num9;
        bottom += num6 * num9;
        return new PointF[] { new PointF(left, top), new PointF(right, top), new PointF(right, bottom), new PointF(left, bottom) };
    }

    private static RectangleF smethod_2(spr➓ A_0)
    {
        sprᨴ rᨴ = new sprᨴ();
        return rᨴ.ᜁ(A_0);
    }

    private static RectangleF smethod_3(Class724 A_0)
    {
        float width;
        float height;
        if (A_0.method_4().IsEmpty)
        {
            SizeF sizeInPoints = A_0.method_3().SizeInPoints;
            width = sizeInPoints.Width;
            height = sizeInPoints.Height;
        }
        else
        {
            RectangleF ef5 = A_0.method_3().method_47(new RectangleF(0f, 0f, A_0.method_4().Width, A_0.method_4().Height));
            width = ef5.Width;
            height = ef5.Height;
        }
        return new RectangleF(0f, 0f, width, height);
    }

    private static void smethod_4(Class724 A_0, PointF[] A_1)
    {
        spr➂ r➂ = new spr➂();
        double totalRotation = A_0.method_3().TotalRotation;
        PointF tf = A_1[0];
        PointF tf2 = A_1[2];
        if (totalRotation != 0.0)
        {
            r➂.ᜀ((float) totalRotation, new PointF(tf.X + ((tf2.X - tf.X) * 0.5f), tf.Y + ((tf2.Y - tf.Y) * 0.5f)));
        }
        r➂.ᜀ(A_1);
    }
}

