using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class220 : Class219
{
    private readonly bool bool_0;
    private readonly Class315 class315_0;
    private Class672 class672_0;
    private Class724 class724_0;

    internal Class220(Interface55 A_0, sprℭ A_1, Hashtable A_2, bool A_3) : base(A_1, A_2)
    {
        this.class315_0 = new Class315(A_0);
        this.bool_0 = A_3;
    }

    private void method_10(ShapeObject A_0)
    {
        if (A_0.RenderMode == ThreeDRenderMode.Wireframe)
        {
            Class674 class2 = new Class674(this.class672_0);
            this.class672_0.method_11(class2.method_0(this.class672_0.method_10(), A_0.IsParallelExtrusion));
        }
    }

    private void method_11(ShapeObject A_0)
    {
        bool shadowOn = A_0.ShadowOn;
        if (A_0.ExtrusionOn)
        {
            ThreeDRenderMode renderMode = A_0.RenderMode;
        }
    }

    private void method_12(Class724 A_0, Class673 A_1, Class69 A_2, bool A_3)
    {
        spr➓ r➓ = A_2.method_1();
        ShapeObject obj2 = (ShapeObject) A_0.method_3();
        if (this.class672_0.method_10() != null)
        {
            Class1024 class2 = new Class1024();
            int num = this.class672_0.method_10().ᜋ();
            if (obj2.HorizontalRule.method_0())
            {
                spr➓ r➓2 = new spr➓();
                r➓.ᜁ(r➓2);
                r➓ = r➓2;
                smethod_2(obj2.HorizontalRule.method_6(), A_0.method_4().Width, A_0.method_1(), r➓2);
            }
            PointF[] tfArray = this.method_13(obj2);
            Class1021 class3 = (tfArray == null) ? ((A_3 || A_0.method_14()) ? new Class1021(base.sprℭ_0) : null) : null;
            this.method_14(r➓, num, class2, class3);
            this.method_15(r➓, obj2, A_1, class3);
            this.method_16(r➓, num, class2, class3);
            A_2.method_3((tfArray != null) ? new Class722(tfArray, true) : ((class3 != null) ? class3.method_4() : null));
        }
        this.class315_0.method_1(this.class672_0, r➓);
        if (((obj2.ParentObject != null) && (obj2.ParentObject.DocumentObjectType == DocumentObjectType.ShapeGroup)) && sprḆ.ᜋ(obj2.HRef))
        {
            r➓.ᜀ(new spr⠱(obj2.BoundsInPoints, obj2.HRef));
        }
    }

    private PointF[] method_13(ShapeBase A_0)
    {
        PointF[] tfArray = null;
        if (A_0.WrapPolygonVertices != null)
        {
            tfArray = Class889.smethod_1(A_0.WrapPolygonVertices);
            this.class672_0.method_8().method_1(tfArray, false);
        }
        return tfArray;
    }

    private void method_14(spr➓ A_0, int A_1, Class1024 A_2, Class1021 A_3)
    {
        for (int i = 0; i < A_1; i++)
        {
            sprᲆ rᲆ = this.class672_0.method_10().ᜀ(i);
            if (rᲆ.ᜈ() != null)
            {
                if ((((rᲆ.ᜈ() is spr⡀) && (this.class672_0.method_28().Rotation != 0.0)) && (!this.class672_0.method_28().IsTextureRotated && !this.class672_0.method_28().IsWordArt)) && !this.class672_0.method_28().IsImage)
                {
                    sprᨴ rᨴ = new sprᨴ();
                    ((spr⡀) rᲆ.ᜈ()).ᜀ(rᨴ.ᜁ(rᲆ));
                }
                sprᲆ rᲆ2 = A_2.method_0(rᲆ, false, true);
                A_0.ᜁ(rᲆ2);
                if (A_3 != null)
                {
                    A_3.method_0(rᲆ2);
                }
            }
        }
    }

    private void method_15(spr➓ A_0, ShapeObject A_1, Class673 A_2, Class1021 A_3)
    {
        if (A_1.HasImage)
        {
            spr➓ r➓ = new spr➓();
            r➓.ᜀ(Class316.smethod_8(A_1, A_2));
            DocPicture imageData = A_1.ImageData;
            byte[] buffer = smethod_3(A_1) ? smethod_4(A_1) : Class1022.smethod_5(imageData);
            sprἣ sprἣ = new sprἣ(PointF.Empty, this.class672_0.method_32(), buffer, new sprᤘ((double) imageData.CropFromLeft, (double) imageData.CropFromRight, (double) imageData.CropFromTop, (double) imageData.CropFromBottom), smethod_6(imageData));
            smethod_5(A_1, sprἣ);
            r➓.ᜁ(sprἣ);
            A_0.ᜁ(r➓);
            if (A_3 != null)
            {
                A_3.method_1(buffer, sprἣ.ᜂ());
            }
        }
    }

    private void method_16(spr➓ A_0, int A_1, Class1024 A_2, Class1021 A_3)
    {
        for (int i = 0; i < A_1; i++)
        {
            sprᲆ rᲆ = this.class672_0.method_10().ᜀ(i);
            if (rᲆ.ᜀ() != null)
            {
                if (A_3 != null)
                {
                    A_3.method_2(rᲆ);
                }
                sprᲆ[] rᲆArray2 = Class825.smethod_0(rᲆ, this.class672_0.method_28().Stroke.method_37());
                if (rᲆArray2 != null)
                {
                    if (rᲆArray2[0].ᜋ() > 0)
                    {
                        A_0.ᜁ(rᲆArray2[0]);
                    }
                    if (rᲆArray2[1].ᜋ() > 0)
                    {
                        A_0.ᜁ(rᲆArray2[1]);
                    }
                }
                sprᲆ[] rᲆArray = Class675.smethod_0(rᲆ);
                for (int j = 0; j < rᲆArray.Length; j++)
                {
                    A_0.ᜁ(A_2.method_0(rᲆArray[j], true, false));
                }
            }
        }
    }

    private void method_17(ShapeObject A_0)
    {
        if (this.class672_0.method_19() != null)
        {
            PointF[] tfArray = new PointF[] { PointF.Empty, new PointF((float) A_0.CoordSize.Width, 0f), new PointF((float) A_0.CoordSize.Width, (float) A_0.CoordSize.Height), new PointF(0f, (float) A_0.CoordSize.Height) };
            this.class672_0.method_8().method_1(tfArray, false);
            sprᲆ rᲆ = new sprᲆ(null);
            rᲆ.ᜀ(this.class672_0.method_19());
            rᲆ.ᜁ(sprᧂ.ᜁ(tfArray, true));
            this.class672_0.method_10().ᜁ(rᲆ);
        }
    }

    private void method_18()
    {
        double strokeWeight = this.class672_0.method_28().StrokeWeight;
        PointF tf = this.class672_0.method_8().method_0();
        float num2 = (float) (strokeWeight / ((double) tf.Y));
        float num3 = (float) (strokeWeight / ((double) tf.Y));
        float num4 = (float) (strokeWeight / ((double) tf.X));
        float num5 = (float) (strokeWeight / ((double) tf.X));
        PointF[] tfArray = smethod_7(this.class672_0.method_28().CoordSize, num2, num5, num3, num4);
        this.class672_0.method_8().method_1(tfArray, false);
        Class1074.smethod_0(this.class672_0, tfArray[0], tfArray[1]);
        Class1074.smethod_0(this.class672_0, tfArray[2], tfArray[3]);
        Class1074.smethod_0(this.class672_0, tfArray[4], tfArray[5]);
        Class1074.smethod_0(this.class672_0, tfArray[6], tfArray[7]);
    }

    private void method_19(Class724 A_0)
    {
    }

    private void method_20(Class679 A_0, ref int A_1)
    {
        int num = 6;
        switch (A_0.method_0())
        {
            case PathType.Unknown:
            case PathType.EscapeBase:
            case PathType.QuadraticBezier:
            case PathType.EscapeAutoLine:
            case PathType.EscapeAutoCurve:
            case PathType.EscapeCornerLine:
            case PathType.EscapeCornerCurve:
            case PathType.EscapeSmoothLine:
            case PathType.EscapeSmoothCurve:
            case PathType.EscapeSymmetricLine:
            case PathType.EscapeSymmetricCurve:
            case PathType.EscapeFreeForm:
            case PathType.LineColor:
                return;

            case PathType.LineTo:
                A_1 = this.method_23(A_0, A_1);
                return;

            case PathType.CurveTo:
                A_1 = this.method_29(A_0, A_1, false);
                return;

            case PathType.MoveTo:
                this.class672_0.method_7();
                this.class672_0.method_22(this.class672_0.method_14()[A_1]);
                this.class672_0.method_24(true);
                A_1++;
                return;

            case PathType.Close:
                this.method_30();
                return;

            case PathType.End:
                this.class672_0.method_6();
                return;

            case PathType.AngleEllipseTo:
                this.class672_0.method_26(null);
                A_1 = this.method_27(A_0, A_1, this.class672_0.method_23());
                return;

            case PathType.AngleEllipse:
                this.class672_0.method_7();
                A_1 = this.method_27(A_0, A_1, false);
                return;

            case PathType.ArcTo:
                this.class672_0.method_26(null);
                A_1 = this.method_24(A_0, A_1, false, this.class672_0.method_23());
                return;

            case PathType.Arc:
                this.class672_0.method_7();
                A_1 = this.method_24(A_0, A_1, false, false);
                return;

            case PathType.ClockwiseArcTo:
                this.class672_0.method_26(null);
                A_1 = this.method_24(A_0, A_1, true, this.class672_0.method_23());
                return;

            case PathType.ClockwiseArc:
                this.class672_0.method_7();
                A_1 = this.method_24(A_0, A_1, true, false);
                return;

            case PathType.EllipticalQuadrantX:
                this.class672_0.method_26(null);
                A_1 = this.method_21(A_0, A_1, true);
                return;

            case PathType.EllipticalQuadrantY:
                this.class672_0.method_26(null);
                A_1 = this.method_21(A_0, A_1, false);
                return;

            case PathType.NoFill:
                this.class672_0.method_16().ᜀ(null);
                return;

            case PathType.NoLine:
                this.class672_0.method_16().ᜀ(null);
                return;

            case PathType.FillColor:
                A_1++;
                this.class672_0.method_16().ᜀ(this.class672_0.method_19());
                return;
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("尫伭䐯娱紳堵帷唹", num));
    }

    private int method_21(Class679 A_0, int A_1, bool A_2)
    {
        for (int i = 0; i < A_0.method_1(); i++)
        {
            this.method_26(this.method_22(ref A_1, A_2));
            A_2 = !A_2;
        }
        this.class672_0.method_24(false);
        return A_1;
    }

    private sprṋ[] method_22(ref int A_0, bool A_1)
    {
        float num3;
        float num4;
        PointF[] tfArray = new PointF[] { this.class672_0.method_21(), this.class672_0.method_14()[A_0] };
        this.class672_0.method_22(this.class672_0.method_14()[A_0]);
        A_0++;
        float num = Math.Abs((float) (tfArray[1].X - tfArray[0].X));
        float num2 = Math.Abs((float) (tfArray[1].Y - tfArray[0].Y));
        PointF tf = A_1 ? new PointF(tfArray[0].X - num, tfArray[1].Y - num2) : new PointF(tfArray[1].X - num, tfArray[0].Y - num2);
        SizeF ef = new SizeF(num * 2f, num2 * 2f);
        if ((tfArray[0].X < tfArray[1].X) && (tfArray[0].Y < tfArray[1].Y))
        {
            if (A_1)
            {
                num3 = 270f;
                num4 = 90f;
            }
            else
            {
                num3 = 180f;
                num4 = -90f;
            }
        }
        else if ((tfArray[0].X < tfArray[1].X) && (tfArray[0].Y > tfArray[1].Y))
        {
            if (A_1)
            {
                num3 = 90f;
                num4 = -90f;
            }
            else
            {
                num3 = 180f;
                num4 = 90f;
            }
        }
        else if ((tfArray[0].X > tfArray[1].X) && (tfArray[0].Y > tfArray[1].Y))
        {
            if (A_1)
            {
                num3 = 90f;
                num4 = 90f;
            }
            else
            {
                num3 = 0f;
                num4 = -90f;
            }
        }
        else if (A_1)
        {
            num3 = 270f;
            num4 = -90f;
        }
        else
        {
            num3 = 0f;
            num4 = 90f;
        }
        spr⢩ r⢩ = new spr⢩();
        r⢩.ᜀ(tf);
        r⢩.ᜀ(ef);
        r⢩.ᜃ((double) num3);
        r⢩.ᜂ((double) num4);
        return this.method_32(r⢩);
    }

    private int method_23(Class679 A_0, int A_1)
    {
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        spr៧ spr = this.class672_0.method_25() as spr៧;
        if (spr == null)
        {
            spr = new spr៧();
            this.class672_0.method_17().ᜁ(spr);
            this.class672_0.method_26(spr);
            if (this.class672_0.method_23())
            {
                tfArray2[0] = this.class672_0.method_21();
                this.class672_0.method_8().method_1(tfArray2, false);
                spr.ᜀ().Add(tfArray2[0]);
            }
        }
        int num2 = A_0.method_1();
        for (int i = 0; i < num2; i++)
        {
            this.class672_0.method_22(this.class672_0.method_14()[A_1]);
            tfArray2[0] = this.class672_0.method_21();
            this.class672_0.method_8().method_1(tfArray2, false);
            spr.ᜀ().Add(tfArray2[0]);
            A_1++;
        }
        return A_1;
    }

    private int method_24(Class679 A_0, int A_1, bool A_2, bool A_3)
    {
        int num = A_0.method_1() / 4;
        for (int i = 0; i < num; i++)
        {
            sprṋ[] sprṋArray = this.method_31(ref A_1, A_2);
            if (A_3)
            {
                this.method_25(sprṋArray);
                A_3 = false;
            }
            this.method_26(sprṋArray);
        }
        this.class672_0.method_24(false);
        return A_1;
    }

    private void method_25(sprṋ[] A_0)
    {
        if (this.class672_0.method_17().ᜋ() == 0)
        {
            PointF tf = A_0[0].ᜂ();
            if ((tf.X != this.class672_0.method_21().X) || (tf.Y != this.class672_0.method_21().Y))
            {
                PointF[] tfArray2 = new PointF[] { PointF.Empty };
                tfArray2[0] = this.class672_0.method_21();
                this.class672_0.method_8().method_1(tfArray2, false);
                spr៧ spr = new spr៧();
                spr.ᜀ().Add(tfArray2[0]);
                spr.ᜀ().Add(tf);
                this.class672_0.method_17().ᜁ(spr);
            }
        }
    }

    private void method_26(sprṋ[] A_0)
    {
        for (int i = 0; i < A_0.Length; i++)
        {
            sprᡉ rᡉ = new sprᡉ();
            rᡉ.ᜀ(A_0[i]);
            this.class672_0.method_17().ᜁ(rᡉ);
        }
    }

    private int method_27(Class679 A_0, int A_1, bool A_2)
    {
        int num = A_0.method_1() / 3;
        for (int i = 0; i < num; i++)
        {
            sprṋ[] sprṋArray = this.method_28(ref A_1);
            if (A_2)
            {
                this.method_25(sprṋArray);
                A_2 = false;
            }
            this.method_26(sprṋArray);
        }
        this.class672_0.method_24(false);
        return A_1;
    }

    private sprṋ[] method_28(ref int A_0)
    {
        PointF[] tfArray = new PointF[] { this.class672_0.method_14()[A_0] };
        PointF tf = tfArray[0];
        A_0++;
        tfArray[0] = this.class672_0.method_14()[A_0];
        PointF tf2 = tfArray[0];
        A_0++;
        PointF tf3 = this.class672_0.method_14()[A_0];
        A_0++;
        spr⢩ r⢩ = new spr⢩();
        r⢩.ᜃ((double) (360f - (tf3.X / 65536f)));
        r⢩.ᜂ((double) (-tf3.Y / 65536f));
        r⢩.ᜀ(new SizeF(tf2.X * 2f, tf2.Y * 2f));
        r⢩.ᜀ(new PointF(tf.X - tf2.X, tf.Y - tf2.Y));
        return this.method_32(r⢩);
    }

    private int method_29(Class679 A_0, int A_1, bool A_2)
    {
        for (int i = 0; i < A_0.method_1(); i++)
        {
            PointF[] destinationArray = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
            Array.Copy(this.class672_0.method_14(), A_1, destinationArray, 1, 3);
            PointF tf3 = this.class672_0.method_21();
            destinationArray[0] = tf3;
            if (A_2)
            {
                for (int j = 1; j < 4; j++)
                {
                    PointF tf = destinationArray[j];
                    destinationArray[j] = new PointF(tf.X + tf3.X, tf.Y + tf3.Y);
                }
            }
            A_1 += 3;
            this.class672_0.method_22(destinationArray[3]);
            this.class672_0.method_8().method_1(destinationArray, false);
            this.class672_0.method_17().ᜁ(new sprᡉ(destinationArray));
        }
        this.class672_0.method_26(null);
        return A_1;
    }

    internal spr➓ method_3(Class724 A_0)
    {
        return this.method_4(A_0, true);
    }

    private void method_30()
    {
        this.class672_0.method_17().ᜀ(true);
    }

    private sprṋ[] method_31(ref int A_0, bool A_1)
    {
        double num16;
        PointF[] destinationArray = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
        Array.Copy(this.class672_0.method_14(), A_0, destinationArray, 0, 4);
        A_0 += 4;
        PointF tf = destinationArray[0];
        PointF tf2 = destinationArray[1];
        float x = tf.X;
        float y = tf.Y;
        float num3 = tf2.X;
        float num4 = tf2.Y;
        if (tf.X > tf2.X)
        {
            x = tf2.X;
            num3 = tf.X;
        }
        if (tf.Y > tf2.Y)
        {
            y = tf2.Y;
            num4 = tf.Y;
        }
        float num9 = (num3 - x) * 0.5f;
        float num10 = (num4 - y) * 0.5f;
        float num11 = x + num9;
        float num12 = y + num10;
        PointF tf4 = new PointF(destinationArray[2].X - num11, destinationArray[2].Y - num12);
        PointF tf3 = new PointF(destinationArray[3].X - num11, destinationArray[3].Y - num12);
        double num13 = tf4.X;
        double d = num13 / Math.Sqrt((tf4.X * tf4.X) + (tf4.Y * tf4.Y));
        double num6 = spr⃘.ᜄ(Math.Acos(d));
        if (tf4.Y < 0f)
        {
            num6 = 360.0 - num6;
        }
        double num7 = tf3.X;
        double num8 = num7 / Math.Sqrt((tf3.X * tf3.X) + (tf3.Y * tf3.Y));
        double num5 = spr⃘.ᜄ(Math.Acos(num8));
        if (tf3.Y < 0f)
        {
            num5 = 360.0 - num5;
        }
        double num15 = num6;
        if (A_1)
        {
            num16 = (num5 > num6) ? (num5 - num6) : ((360.0 - num6) + num5);
        }
        else
        {
            num16 = (num5 > num6) ? ((num5 - 360.0) - num6) : (num5 - num6);
        }
        spr⢩ r⢩ = new spr⢩();
        r⢩.ᜃ(num15);
        r⢩.ᜂ(num16);
        r⢩.ᜀ(new SizeF(num3 - x, num4 - y));
        r⢩.ᜀ(new PointF(x, y));
        return this.method_32(r⢩);
    }

    private sprṋ[] method_32(spr⢩ A_0)
    {
        sprṋ[] sprṋArray = A_0.ᜃ();
        PointF[] tfArray = new PointF[sprṋArray.Length * 4];
        int index = 0;
        for (int i = 0; i < sprṋArray.Length; i++)
        {
            tfArray[index] = sprṋArray[i].ᜂ();
            index++;
            tfArray[index] = sprṋArray[i].ᜄ();
            index++;
            tfArray[index] = sprṋArray[i].ᜃ();
            index++;
            tfArray[index] = sprṋArray[i].ᜀ();
            index++;
        }
        this.class672_0.method_8().method_1(tfArray, false);
        index = 0;
        for (int j = 0; j < sprṋArray.Length; j++)
        {
            sprṋ sprṋ = new sprṋ();
            sprṋ.ᜁ(tfArray[index]);
            index++;
            sprṋ.ᜃ(tfArray[index]);
            index++;
            sprṋ.ᜂ(tfArray[index]);
            index++;
            sprṋ.ᜀ(tfArray[index]);
            index++;
            sprṋArray[j] = sprṋ;
        }
        return sprṋArray;
    }

    internal spr➓ method_4(Class724 A_0, bool A_1)
    {
        ShapeBase parentObject = A_0.method_3();
        this.class724_0 = A_0;
        if (parentObject.Hidden)
        {
            return new spr➓();
        }
        spr➓ r➓ = base.method_0(A_0, false);
        if (r➓ == null)
        {
            while (!parentObject.IsTopLevel)
            {
                parentObject = (ShapeBase) parentObject.ParentObject;
            }
            this.method_5((parentObject != A_0.method_3()) ? new Class724(parentObject) : A_0, Class673.smethod_0(), false);
            spr➓ r➓2 = base.method_0(A_0, false);
            if (!A_1)
            {
                base.method_2(parentObject);
            }
            return r➓2;
        }
        return r➓;
    }

    private spr➓ method_5(Class724 A_0, Class673 A_1, bool A_2)
    {
        if (A_0.method_3() == this.class724_0.method_3())
        {
            A_0 = this.class724_0;
        }
        return ((A_0.method_3().ShapeType == ShapeType.Group) ? this.method_6(A_0, A_1, A_2) : this.method_7(A_0, A_1, A_2));
    }

    private spr➓ method_6(Class724 A_0, Class673 A_1, bool A_2)
    {
        ShapeGroup group = (ShapeGroup) A_0.method_3();
        SizeF ef2 = A_0.method_4().IsEmpty ? group.Size : A_0.method_4();
        spr➂ r➂ = Class316.smethod_9(group, ef2, false);
        r➂.ᜀ(A_1.method_0(), MatrixOrder.Append);
        Class316.smethod_9(group, ef2, true).ᜀ(A_1.method_0(), MatrixOrder.Append);
        SizeF ef3 = Class316.smethod_0(group, A_1.method_1(), A_1.method_2());
        float width = ef3.Width;
        float height = ef3.Height;
        float num = (ef2.Width / ((float) group.CoordSizeWidth)) * width;
        float num2 = (ef2.Height / ((float) group.CoordSizeHeight)) * height;
        float num3 = ((float) group.Rotation) + A_1.method_3();
        bool flag = A_0.method_14();
        Class622 class3 = new Class622();
        spr➓ r➓ = new spr➓();
        PointF[] tfArray = smethod_1(group, ef2, flag, num3);
        foreach (ShapeBase base2 in group.ChildObjects)
        {
            if ((group.FlipOrientation != FlipOrientation.None) && (base2.FlipOrientation == FlipOrientation.None))
            {
                base2.FlipOrientation = group.FlipOrientation;
            }
            Class724 class4 = new Class724(base2);
            spr➓ r➓2 = this.method_5(class4, new Class673(r➂, num, num2, num3), (tfArray == null) ? (A_2 || flag) : false);
            spr➓ r➓3 = base.method_0(class4, false);
            Class722 class5 = class4.method_12();
            if (class5 != null)
            {
                class5.method_13(r➓3.ᜀ());
                class3.method_0(class5);
            }
            r➓.ᜁ(r➓2);
        }
        Class69 class2 = new Class69(r➓);
        class2.method_0(A_0);
        class2.method_3((tfArray != null) ? new Class722(tfArray) : Class670.smethod_1(class3));
        base.method_1(A_0.method_3(), class2);
        return r➓;
    }

    private spr➓ method_7(Class724 A_0, Class673 A_1, bool A_2)
    {
        Class69 class3;
        ShapeObject obj2 = (ShapeObject) A_0.method_3();
        this.method_11(obj2);
        this.method_8(A_0, obj2, A_1);
        if (Class1022.smethod_1(obj2))
        {
            if (obj2.Stroked)
            {
                this.method_18();
            }
            else
            {
                this.method_19(A_0);
            }
            this.method_17(obj2);
        }
        else if (this.class672_0.method_12() == null)
        {
            class3 = new Class69(new spr➓());
            class3.method_0(A_0);
            base.method_1(A_0.method_3(), class3);
        }
        else
        {
            int num2 = 0;
            for (int i = 0; i < this.class672_0.method_12().Length; i++)
            {
                Class679 class2 = this.class672_0.method_12()[i];
                this.method_20(class2, ref num2);
            }
        }
        spr➓ r➓ = new spr➓();
        if (obj2.Owner is ShapeGroup)
        {
            r➓.ᜀ(new spr➂(1f, 0f, 0f, 1f, this.class672_0.method_9().method_9().X, this.class672_0.method_9().method_9().Y));
        }
        else
        {
            r➓.ᜀ(new spr➂(1f, 0f, 0f, 1f, this.class672_0.method_8().method_9().X, this.class672_0.method_8().method_9().Y));
        }
        if (this.class672_0.method_28().WordArt.On)
        {
            r➓ = this.method_9(r➓);
        }
        if (obj2.ExtrusionOn)
        {
            this.method_10(obj2);
        }
        class3 = new Class69(r➓);
        this.method_12(A_0, A_1, class3, A_2);
        class3.method_0(A_0);
        base.method_1(A_0.method_3(), class3);
        return r➓;
    }

    private void method_8(Class724 A_0, ShapeObject A_1, Class673 A_2)
    {
        if (A_1.HorizontalRule.method_0())
        {
            A_0.method_5((A_1.HorizontalRule.method_8() > 0.0) ? new SizeF(((float) (A_1.HorizontalRule.method_8() * 0.0099999997764825821)) * A_0.method_1(), (float) A_1.Height) : new SizeF((float) A_1.Width, (float) A_1.Height));
        }
        this.class672_0 = new Class672(A_0, A_2, base.sprℭ_0);
        if ((A_1.method_34() && A_1.IsFitTextboxToText) && !this.class315_0.method_3())
        {
            A_0.method_5(this.class315_0.method_0(this.class672_0));
            this.class672_0 = new Class672(A_0, A_2, base.sprℭ_0);
        }
    }

    private spr➓ method_9(spr➓ A_0)
    {
        spr➓ r➓ = null;
        if (this.bool_0)
        {
            A_0 = Class723.smethod_0(this.class672_0);
        }
        else
        {
            r➓ = Class1120.smethod_0(this.class672_0);
        }
        this.class672_0.method_11(r➓);
        return A_0;
    }

    internal static spr➓ smethod_0(Class724 A_0, sprℭ A_1)
    {
        Document document = A_0.method_3().Document;
        Class220 class2 = new Class220(null, A_1, document.CanvasCache, false);
        return class2.method_3(A_0);
    }

    private static PointF[] smethod_1(ShapeGroup A_0, SizeF A_1, bool A_2, float A_3)
    {
        PointF[] tfArray = Class889.smethod_1(A_2 ? A_0.WrapPolygonVertices : null);
        if (tfArray != null)
        {
            spr➂ r➂ = new spr➂();
            r➂.ᜁ(A_1.Width / 21600f, A_1.Height / 21600f);
            r➂.ᜀ(A_3, new PointF(A_1.Width / 2f, A_1.Height / 2f), MatrixOrder.Append);
            r➂.ᜀ(tfArray);
        }
        return tfArray;
    }

    private static void smethod_2(ShapeHorizontalAlignment A_0, float A_1, float A_2, spr➓ A_3)
    {
        if (spr➂.ᜁ(A_3.ᜀ(), null))
        {
            A_3.ᜀ(new spr➂());
        }
        switch (A_0)
        {
            case ShapeHorizontalAlignment.Center:
                A_3.ᜀ().ᜀ((A_2 - A_1) * 0.5f, 0f, MatrixOrder.Append);
                return;

            case ShapeHorizontalAlignment.Right:
                A_3.ᜀ().ᜀ(A_2 - A_1, 0f, MatrixOrder.Append);
                return;
        }
    }

    private static bool smethod_3(ShapeObject A_0)
    {
        return false;
    }

    private static byte[] smethod_4(ShapeObject A_0)
    {
        if (A_0.SignatureLine == null)
        {
            return null;
        }
        return A_0.SignatureLine.method_3();
    }

    private static void smethod_5(ShapeObject A_0, sprἣ A_1)
    {
        ArrayList list = new ArrayList();
        if (A_0.ImageRecolor != Color.Empty)
        {
            list.Add(new sprᶬ(sprⓚ.ᜀ(A_0.ImageRecolor)));
        }
        spr▽[] array = new spr▽[list.Count];
        list.CopyTo(array);
        A_1.ᜀ(array);
    }

    private static spr╩ smethod_6(DocPicture A_0)
    {
        if (!A_0.IsChromaKeySpecified)
        {
            return null;
        }
        return new spr╩(sprⓚ.ᜀ(A_0.ChromaKey), 10);
    }

    private static PointF[] smethod_7(Size A_0, float A_1, float A_2, float A_3, float A_4)
    {
        float num = A_1 * 0.5f;
        float num2 = A_4 * 0.5f;
        float num3 = A_2 * 0.5f;
        float num4 = A_3 * 0.5f;
        return new PointF[] { new PointF(-A_4, -num), new PointF(A_0.Width + A_2, -num), new PointF(A_0.Width + num3, 0f), new PointF(A_0.Width + num3, (float) A_0.Height), new PointF(-A_4, A_0.Height + num4), new PointF(A_0.Width + A_2, A_0.Height + num4), new PointF(-num2, 0f), new PointF(-num2, (float) A_0.Height) };
    }
}

