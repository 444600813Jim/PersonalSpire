using Spire.Pdf.General.Paper.Drawing;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class825 : spr᥋
{
    private bool bool_0;
    private const float float_0 = 3f;
    private const float float_1 = 3f;
    private static readonly float[] float_10 = new float[] { -1.5f, 3f, 0f, 0f, 1.5f, 3f, 0f, 1.8f };
    private static readonly float[] float_11 = new float[] { -1.75f, 3f, 0f, 0f, 1.75f, 3f };
    private static readonly float[] float_12 = new float[] { 0f, -1.5f, 1.5f, 0f, 0f, 1.5f, -1.5f, 0f };
    private static readonly float[] float_13 = new float[] { 0.65f, 1f, 1.68f };
    private const float float_2 = 3f;
    private const float float_3 = 3f;
    private const float float_4 = 1.8f;
    private const float float_5 = 3.5f;
    private const float float_6 = 3f;
    private const float float_7 = 1.5f;
    private const float float_8 = 1.5f;
    private static readonly float[] float_9 = new float[] { -1.5f, 3f, 0f, 0f, 1.5f, 3f };
    private static readonly SizeF[][] sizeF_0;
    private sprᲆ sprᲆ_0;
    private sprᲆ sprᲆ_1;
    private spr⇻ spr⇻_0;

    static Class825()
    {
        SizeF[][] efArray = new SizeF[3][];
        efArray[0] = new SizeF[] { new SizeF(0.7f, 0.65f), new SizeF(0.7f, 1f), new SizeF(0.7f, 1.5f) };
        efArray[1] = new SizeF[] { new SizeF(1f, 0.65f), new SizeF(1f, 1f), new SizeF(1f, 1.5f) };
        efArray[2] = new SizeF[] { new SizeF(1.42f, 0.65f), new SizeF(1.42f, 1f), new SizeF(1.42f, 1.5f) };
        sizeF_0 = efArray;
    }

    private sprᲆ[] method_0(sprᲆ A_0, spr⇻ A_1)
    {
        this.spr⇻_0 = A_1.ᜁ();
        if (((this.spr⇻_0.ᜂ() == 1) && (this.spr⇻_0.ᜃ().ᜃ() == null)) && (this.spr⇻_0.ᜀ().ᜃ() == null))
        {
            return null;
        }
        this.sprᲆ_0 = new sprᲆ();
        this.sprᲆ_0.ᜀ(A_0.ᜀ().ᜌ());
        this.sprᲆ_1 = new sprᲆ(A_0.ᜀ().ᜈ());
        this.sprᲆ_1.ᜀ().ᜂ((this.spr⇻_0.ᜄ() <= 0.75f) ? 0.75f : this.spr⇻_0.ᜄ());
        this.sprᲆ_1.ᜀ().ᜀ(DashStyle.Solid);
        this.sprᲆ_1.ᜀ().ᜀ(LineJoin.Miter);
        this.sprᲆ_1.ᜀ().ᜁ(LineCap.Round);
        this.sprᲆ_1.ᜀ().ᜀ(LineCap.Round);
        for (int i = 0; i < A_0.ᜋ(); i++)
        {
            sprᧂ rᧂ = A_0.ᜀ(i);
            if (!rᧂ.ᜁ() && (rᧂ.ᜋ() != 0))
            {
                this.bool_0 = true;
                rᧂ.ᜀ(0).ᜀ(this);
                this.bool_0 = false;
                rᧂ.ᜀ(rᧂ.ᜋ() - 1).ᜀ(this);
            }
        }
        return new sprᲆ[] { this.sprᲆ_0, this.sprᲆ_1 };
    }

    private void method_1(PointF A_0, float A_1, PsLineEndSize A_2, PsLineEndSize A_3)
    {
        PsLineEndType type = this.method_3();
        sprᧂ rᧂ = new sprᧂ();
        ArrayList list = new ArrayList();
        float num3 = (this.spr⇻_0.ᜄ() <= 2.0) ? 2f : this.spr⇻_0.ᜄ();
        rᧂ.ᜀ(true);
        float width = float_13[A_2];
        float height = float_13[A_3];
        switch (type)
        {
            case 1:
                list.Add(new spr៧(float_9));
                break;

            case 2:
                list.Add(new spr៧(float_10));
                break;

            case 3:
                list.Add(new spr៧(float_12));
                break;

            case 4:
            {
                spr⢩ r⢩ = new spr⢩();
                r⢩.ᜀ(new PointF(-1.5f, -1.5f));
                r⢩.ᜀ(new SizeF(3f, 3f));
                r⢩.ᜃ(0.0);
                r⢩.ᜂ(360.0);
                sprṋ[] sprṋArray = r⢩.ᜃ();
                for (int i = 0; i < sprṋArray.Length; i++)
                {
                    sprᡉ rᡉ = new sprᡉ();
                    rᡉ.ᜀ(sprṋArray[i]);
                    list.Add(rᡉ);
                }
                break;
            }
            case 5:
            {
                spr៧ spr = new spr៧(float_11);
                list.Add(spr);
                rᧂ.ᜀ(false);
                num3 = this.sprᲆ_1.ᜀ().ᜀ();
                SizeF ef = sizeF_0[A_2][A_3];
                width = ef.Width;
                height = ef.Height;
                break;
            }
        }
        if (list.Count != 0)
        {
            width *= num3;
            height *= num3;
            spr➂ r➂ = new spr➂();
            r➂.ᜁ(width, height, MatrixOrder.Prepend);
            r➂.ᜀ(0f, this.method_2(type, A_2, A_3), MatrixOrder.Append);
            r➂.ᜀ(A_1, MatrixOrder.Append);
            r➂.ᜀ(A_0.X, A_0.Y, MatrixOrder.Append);
            for (int j = 0; j < list.Count; j++)
            {
                spr➘ r➘ = (spr➘) list[j];
                r➘.ᜀ(r➂);
                rᧂ.ᜁ((sprᮃ) r➘);
            }
            if (rᧂ.ᜁ())
            {
                this.sprᲆ_0.ᜁ(rᧂ);
            }
            else
            {
                this.sprᲆ_1.ᜁ(rᧂ);
            }
        }
    }

    private float method_2(PsLineEndType A_0, PsLineEndSize A_1, PsLineEndSize A_2)
    {
        if (A_0 != 5)
        {
            return 0f;
        }
        if ((A_1 == null) && (A_2 == 2))
        {
            return (this.sprᲆ_1.ᜀ().ᜀ() * 2.5f);
        }
        return this.sprᲆ_1.ᜀ().ᜀ();
    }

    private PsLineEndType method_3()
    {
        if (!this.bool_0)
        {
            return this.spr⇻_0.ᜀ().ᜃ();
        }
        return this.spr⇻_0.ᜃ().ᜃ();
    }

    private PsLineEndSize method_4()
    {
        if (!this.bool_0)
        {
            return this.spr⇻_0.ᜀ().ᜀ();
        }
        return this.spr⇻_0.ᜃ().ᜀ();
    }

    private PsLineEndSize method_5()
    {
        if (!this.bool_0)
        {
            return this.spr⇻_0.ᜀ().ᜂ();
        }
        return this.spr⇻_0.ᜃ().ᜂ();
    }

    internal static sprᲆ[] smethod_0(sprᲆ A_0, spr⇻ A_1)
    {
        if (A_1 == null)
        {
            return null;
        }
        Class825 class2 = new Class825();
        return class2.method_0(A_0, A_1);
    }

    private static PointF smethod_1(PointF A_0, PointF A_1, float A_2)
    {
        double num = A_1.X - A_0.X;
        double num2 = A_1.Y - A_0.Y;
        double num3 = Math.Sqrt(smethod_2(num) + smethod_2(num2));
        double num4 = 0.0;
        if (num3 != 0.0)
        {
            num4 = ((double) A_2) / num3;
        }
        return new PointF(A_0.X + ((float) (num * num4)), A_0.Y + ((float) (num2 * num4)));
    }

    private static double smethod_2(double A_0)
    {
        return (A_0 * A_0);
    }

    public override void vmethod_0(spr៧ A_0)
    {
        float num;
        int num2;
        int num3;
        PsLineEndSize size3;
        PsLineEndSize size4;
        PsLineEndType type = this.method_3();
        PsLineEndSize index = this.method_5();
        PsLineEndSize size2 = this.method_4();
        switch (type)
        {
            case 1:
            case 2:
                num = (1.5f * this.spr⇻_0.ᜄ()) * float_13[size2];
                break;

            case 3:
            case 4:
                num = 0f;
                break;

            case 5:
            {
                SizeF ef = sizeF_0[index][size2];
                num = this.spr⇻_0.ᜄ() * ef.Height;
                if ((size2 != 2) || (index != null))
                {
                    num *= 1.3f;
                    break;
                }
                num *= 2.5f;
                break;
            }
            default:
                return;
        }
        if (this.bool_0)
        {
            num2 = 0;
            num3 = 1;
            size3 = this.spr⇻_0.ᜃ().ᜂ();
            size4 = this.spr⇻_0.ᜃ().ᜀ();
        }
        else
        {
            num2 = A_0.ᜀ().Count - 1;
            num3 = num2 - 1;
            size3 = this.spr⇻_0.ᜀ().ᜂ();
            size4 = this.spr⇻_0.ᜀ().ᜀ();
        }
        PointF tf = (PointF) A_0.ᜀ()[num2];
        PointF tf2 = (PointF) A_0.ᜀ()[num3];
        if (num > 0f)
        {
            A_0.ᜀ()[num2] = smethod_1(tf, tf2, num);
        }
        PointF tf3 = new PointF(tf.X - tf2.X, tf.Y - tf2.Y);
        float num6 = 0f;
        if ((tf3.X != 0f) || (tf3.Y != 0f))
        {
            float num4 = -tf3.Y;
            float num5 = num4 / ((float) Math.Sqrt((double) ((tf3.X * tf3.X) + (tf3.Y * tf3.Y))));
            num6 = (float) spr⃘.ᜄ(Math.Acos((double) num5));
            if (tf3.X < 0f)
            {
                num6 = 360f - num6;
            }
        }
        this.method_1(tf, num6, size3, size4);
    }

    public override void vmethod_1(sprᡉ A_0)
    {
        PsLineEndSize size;
        PsLineEndSize size2;
        float num;
        PointF tf2;
        PointF tf3;
        switch (this.method_3())
        {
            case 1:
            case 2:
            case 5:
                num = this.spr⇻_0.ᜄ();
                break;

            case 3:
            case 4:
                num = 0f;
                break;

            default:
                return;
        }
        if (this.bool_0)
        {
            tf2 = A_0.ᜀ().ᜂ();
            tf3 = A_0.ᜀ().ᜄ();
            if (num > 0f)
            {
                sprṋ sprṋ7 = new sprṋ();
                sprṋ7.ᜁ(smethod_1(tf2, tf3, num));
                sprṋ7.ᜃ(A_0.ᜀ().ᜄ());
                sprṋ7.ᜂ(A_0.ᜀ().ᜃ());
                sprṋ7.ᜀ(A_0.ᜀ().ᜀ());
                A_0.ᜀ(sprṋ7);
            }
            size = this.spr⇻_0.ᜃ().ᜂ();
            size2 = this.spr⇻_0.ᜃ().ᜀ();
        }
        else
        {
            tf2 = A_0.ᜀ().ᜀ();
            tf3 = A_0.ᜀ().ᜃ();
            if (num > 0f)
            {
                sprṋ sprṋ3 = new sprṋ();
                sprṋ3.ᜀ(smethod_1(tf2, tf3, num));
                sprṋ3.ᜃ(A_0.ᜀ().ᜄ());
                sprṋ3.ᜂ(A_0.ᜀ().ᜃ());
                sprṋ3.ᜁ(A_0.ᜀ().ᜂ());
                A_0.ᜀ(sprṋ3);
            }
            size = this.spr⇻_0.ᜀ().ᜂ();
            size2 = this.spr⇻_0.ᜀ().ᜀ();
        }
        PointF tf = new PointF(tf2.X - tf3.X, tf2.Y - tf3.Y);
        float num2 = -tf.Y;
        float num3 = num2 / ((float) Math.Sqrt((double) ((tf.X * tf.X) + (tf.Y * tf.Y))));
        float num4 = (float) spr⃘.ᜄ(Math.Acos((double) num3));
        if (tf.X < 0f)
        {
            num4 = 360f - num4;
        }
        this.method_1(tf2, num4, size, size2);
    }
}

