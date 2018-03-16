using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class675 : spr᥋
{
    private Class1123 class1123_0;
    internal static readonly float[] float_0 = new float[0];
    private sprᲆ[] sprᲆ_0;

    private sprᲆ[] method_0(sprᲆ A_0)
    {
        if ((A_0.ᜀ() != null) && (A_0.ᜀ().ᜆ() != PenAlignment.Inset))
        {
            if ((((A_0.ᜀ().ᜊ() != null) && (A_0.ᜀ().ᜊ().Length != 0)) && (A_0.ᜀ().ᜊ() != float_0)) && (((A_0.ᜀ().ᜊ().Length != 2) || (A_0.ᜀ().ᜊ()[0] != 0f)) || (A_0.ᜀ().ᜊ()[1] != 1f)))
            {
                if ((A_0.ᜀ().ᜍ() == DashStyle.Dot) && (A_0.ᜀ().ᜇ() == DashCap.Round))
                {
                    return new sprᲆ[] { A_0 };
                }
                ArrayList list = new ArrayList();
                if (!smethod_3(A_0.ᜀ(), list))
                {
                    return new sprᲆ[] { A_0 };
                }
                this.sprᲆ_0 = new sprᲆ[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    this.sprᲆ_0[i] = this.method_1(A_0, (Class888) list[i]);
                }
                return this.sprᲆ_0;
            }
            return new sprᲆ[] { A_0 };
        }
        return new sprᲆ[] { A_0 };
    }

    private sprᲆ method_1(sprᲆ A_0, Class888 A_1)
    {
        try
        {
            this.class1123_0 = new Class1123(A_0, A_1);
            A_0.ᜀ(this);
            return this.class1123_0.method_7();
        }
        catch (Exception)
        {
            return new sprᲆ();
        }
    }

    private spr៧ method_10(spr៧ A_0)
    {
        PointF empty = PointF.Empty;
        PointF tf2 = PointF.Empty;
        if (this.class1123_0.method_8() is sprᡉ)
        {
            empty = ((sprᡉ) this.class1123_0.method_8()).ᜀ().ᜀ();
            if (this.class1123_0.method_9() is sprᡉ)
            {
                tf2 = ((sprᡉ) this.class1123_0.method_9()).ᜀ().ᜀ();
            }
        }
        else if (this.class1123_0.method_8() is spr៧)
        {
            spr៧ spr2 = this.class1123_0.method_8();
            empty = (PointF) spr2.ᜀ()[spr2.ᜀ().Count - 1];
            if (this.class1123_0.method_9() is spr៧)
            {
                spr៧ spr = (spr៧) this.class1123_0.method_9();
                tf2 = (PointF) spr.ᜀ()[spr.ᜀ().Count - 1];
            }
        }
        float num = tf2.X - empty.X;
        float num2 = tf2.Y - empty.Y;
        PointF tf3 = (PointF) A_0.ᜀ()[0];
        PointF tf4 = new PointF(tf3.X + num, tf3.Y + num2);
        return new spr៧(new PointF[] { tf4 });
    }

    private spr៧ method_11(spr៧ A_0, float A_1)
    {
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        Class447 class2 = new Class447((PointF) A_0.ᜀ()[0], (PointF) A_0.ᜀ()[1]);
        if (this.method_24((PointF) A_0.ᜀ()[0], (PointF) A_0.ᜀ()[1]))
        {
            A_1 *= -1f;
        }
        Class447 class3 = class2.method_2(A_1);
        Class447 class4 = class2.method_3((PointF) A_0.ᜀ()[0]);
        Class447 class5 = class2.method_3((PointF) A_0.ᜀ()[1]);
        PointF[] tfArray4 = new PointF[] { PointF.Empty, PointF.Empty };
        Class447.smethod_1(class3, class4, tfArray2);
        tfArray4[0] = tfArray2[0];
        Class447.smethod_1(class3, class5, tfArray2);
        tfArray4[1] = tfArray2[0];
        return new spr៧(tfArray4);
    }

    private spr៧ method_12(spr៧ A_0, int A_1, float A_2)
    {
        bool flag = this.class1123_0.method_16();
        if (spr⃸.ᜀ((PointF) A_0.ᜀ()[0], (PointF) A_0.ᜀ()[A_1 - 1]))
        {
            A_1--;
            flag = true;
        }
        ArrayList list = new ArrayList(A_1);
        this.method_13(A_0, list, A_1, A_2);
        spr៧ spr = new spr៧(this.method_14(A_0, (Class447[]) list.ToArray(typeof(Class447)), A_2, A_1));
        this.class1123_0.method_17(flag);
        return spr;
    }

    private void method_13(spr៧ A_0, ArrayList A_1, int A_2, float A_3)
    {
        for (int i = 0; i < A_2; i++)
        {
            bool flag = i == (A_2 - 1);
            Class447 class2 = new Class447((PointF) A_0.ᜀ()[i], (PointF) A_0.ᜀ()[flag ? 0 : (i + 1)]);
            bool flag2 = this.method_24((PointF) A_0.ᜀ()[i], (PointF) A_0.ᜀ()[flag ? 0 : (i + 1)]);
            float num2 = A_3;
            if (flag2)
            {
                num2 *= -1f;
            }
            A_1.Add(class2.method_2(num2));
        }
    }

    private PointF[] method_14(spr៧ A_0, Class447[] A_1, float A_2, int A_3)
    {
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        PointF[] tfArray3 = new PointF[A_3];
        for (int i = 0; i < A_1.Length; i++)
        {
            bool flag = i == (A_1.Length - 1);
            bool flag2 = i == (A_1.Length - 2);
            if (!this.class1123_0.method_16() && (flag || flag2))
            {
                Class447 class2 = new Class447((PointF) A_0.ᜀ()[flag ? 0 : (A_3 - 2)], (PointF) A_0.ᜀ()[flag ? 1 : (A_3 - 1)]).method_3((PointF) A_0.ᜀ()[flag ? 0 : (A_3 - 1)]);
                Class447.smethod_1(A_1[flag ? 0 : (A_3 - 2)], class2, tfArray2);
            }
            else if (!Class447.smethod_2(A_1[i], A_1[flag ? 0 : (i + 1)], tfArray2, true))
            {
                this.method_15(A_0, A_2, A_1, i, tfArray2);
            }
            tfArray3[flag ? 0 : (i + 1)] = tfArray2[0];
        }
        return tfArray3;
    }

    private void method_15(spr៧ A_0, float A_1, Class447[] A_2, int A_3, PointF[] A_4)
    {
        bool flag = A_3 == (A_0.ᜀ().Count - 1);
        bool flag2 = this.method_24((PointF) A_0.ᜀ()[A_3], (PointF) A_0.ᜀ()[flag ? 0 : (A_3 + 1)]);
        float num = A_1;
        if (!flag2)
        {
            num *= -1f;
        }
        Class447 class3 = A_2[A_3].method_2(num).method_3((PointF) A_0.ᜀ()[A_3]);
        Class447.smethod_1(A_2[A_3], class3.method_2(num), A_4);
    }

    private sprᡉ[] method_16(sprᡉ A_0, float A_1)
    {
        spr᣼[] r᣼Array = A_0.ᜀ().ᜁ();
        spr᣼[] r᣼Array2 = new spr᣼[r᣼Array.Length];
        for (int i = 0; i < r᣼Array.Length; i++)
        {
            r᣼Array2[i] = this.method_17(r᣼Array[i], A_1);
        }
        Class778.smethod_12(r᣼Array2);
        r᣼Array2 = this.method_18(r᣼Array2);
        return this.method_23(A_0, r᣼Array2);
    }

    private spr᣼ method_17(spr᣼ A_0, float A_1)
    {
        spr᣼ r᣼ = new spr᣼();
        Class447 class2 = new Class447(A_0.ᜁ(), A_0.ᜂ());
        Class447 class3 = new Class447(A_0.ᜀ(), A_0.ᜂ());
        Class447 class4 = class2.method_3(A_0.ᜁ());
        Class447 class5 = class3.method_3(A_0.ᜀ());
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        float num = A_1;
        if (this.method_24(A_0.ᜁ(), A_0.ᜂ()))
        {
            num *= -1f;
        }
        class4.method_7(A_0.ᜁ(), num, tfArray2);
        PointF tf = tfArray2[0];
        num = A_1;
        if (this.method_24(A_0.ᜂ(), A_0.ᜀ()))
        {
            num *= -1f;
        }
        class5.method_7(A_0.ᜀ(), num, tfArray2);
        PointF tf2 = tfArray2[0];
        PointF tf3 = smethod_2(A_0, class2, class3, tf, tf2);
        r᣼.ᜀ(tf);
        r᣼.ᜂ(tf2);
        r᣼.ᜁ(tf3);
        return r᣼;
    }

    private spr᣼[] method_18(spr᣼[] A_0)
    {
        if (this.class1123_0.method_9() != null)
        {
            A_0 = this.class1123_0.method_11() ? this.method_21(A_0) : this.method_19(A_0);
        }
        return A_0;
    }

    private spr᣼[] method_19(spr᣼[] A_0)
    {
        Class446 class2 = Class778.smethod_6(this.class1123_0.method_14(), A_0, false);
        if (class2.method_10())
        {
            this.method_20(class2, A_0);
            return A_0;
        }
        spr᣼[] r᣼Array2 = class2.method_0();
        spr᣼[] r᣼Array = class2.method_2();
        r᣼Array2[r᣼Array2.Length - 1].ᜂ(r᣼Array[r᣼Array.Length - 1].ᜁ());
        this.class1123_0.method_1(r᣼Array2);
        if (r᣼Array.Length != A_0.Length)
        {
            A_0 = new spr᣼[r᣼Array.Length];
        }
        for (int i = 0; i < r᣼Array.Length; i++)
        {
            A_0[i] = r᣼Array[(r᣼Array.Length - 1) - i];
        }
        return A_0;
    }

    private void method_2()
    {
        if (this.class1123_0.method_12())
        {
            this.method_3();
        }
        else
        {
            this.method_4();
        }
    }

    private void method_20(Class446 A_0, spr᣼[] A_1)
    {
        PointF[] tfArray = new PointF[] { A_1[A_1.Length - 1].ᜂ(), A_1[A_1.Length - 1].ᜁ() };
        PointF tf = Class778.smethod_3(A_1, false, tfArray, A_0.method_8());
        PointF[] tfArray2 = new PointF[] { tf };
        this.class1123_0.method_5().ᜃ(tfArray2);
    }

    private spr᣼[] method_21(spr᣼[] A_0)
    {
        spr᣼[] r᣼Array = Class778.smethod_1((spr៧) this.class1123_0.method_9(), A_0, false);
        if (r᣼Array.Length != A_0.Length)
        {
            A_0 = new spr᣼[r᣼Array.Length];
        }
        for (int i = 0; i < r᣼Array.Length; i++)
        {
            A_0[i] = r᣼Array[(r᣼Array.Length - 1) - i];
        }
        return A_0;
    }

    private void method_22(spr៧ A_0, spr៧ A_1)
    {
        if (this.class1123_0.method_9() != null)
        {
            if (this.class1123_0.method_11())
            {
                Class778.smethod_0(A_1, (spr៧) this.class1123_0.method_9());
            }
            else
            {
                spr᣼[] r᣼Array = Class778.smethod_1(A_1, this.class1123_0.method_14(), true);
                this.class1123_0.method_1(r᣼Array);
                this.class1123_0.method_10(r᣼Array[r᣼Array.Length - 1]);
            }
        }
        this.class1123_0.method_3(A_1, A_0);
    }

    private sprᡉ[] method_23(sprᡉ A_0, spr᣼[] A_1)
    {
        sprᡉ[] rᡉArray = new sprᡉ[A_1.Length];
        for (int i = 0; i < A_1.Length; i++)
        {
            rᡉArray[i] = new sprᡉ(A_1[i].ᜁ(), A_1[i].ᜂ(), A_1[i].ᜀ());
        }
        this.class1123_0.method_4(A_1, rᡉArray, A_0);
        return rᡉArray;
    }

    private bool method_24(PointF A_0, PointF A_1)
    {
        float num = A_1.X - A_0.X;
        float num2 = A_1.Y - A_0.Y;
        if (!this.class1123_0.method_18())
        {
            num *= -1f;
            num2 *= -1f;
        }
        if (num != 0f)
        {
            return (num > 0f);
        }
        return (num2 < 0f);
    }

    private void method_3()
    {
        if (this.class1123_0.method_11())
        {
            this.method_8();
        }
        else
        {
            this.method_7();
        }
    }

    private void method_4()
    {
        if (this.class1123_0.method_11())
        {
            this.method_6();
        }
        else
        {
            this.method_5();
        }
    }

    private void method_5()
    {
        Class446 class2 = Class778.smethod_6(this.class1123_0.method_15(), this.class1123_0.method_14(), true);
        if (class2.method_10())
        {
            PointF[] tfArray = new PointF[] { class2.method_8() };
            this.class1123_0.method_5().ᜃ(tfArray);
        }
        else
        {
            spr᣼[] r᣼Array = class2.method_0();
            spr᣼[] r᣼Array2 = class2.method_2();
            this.class1123_0.method_2(r᣼Array);
            this.class1123_0.method_1(r᣼Array2);
        }
    }

    private void method_6()
    {
        spr᣼[] r᣼Array = Class778.smethod_1((spr៧) this.class1123_0.method_9(), this.class1123_0.method_15(), false);
        this.class1123_0.method_2(r᣼Array);
    }

    private void method_7()
    {
        spr᣼[] r᣼Array = Class778.smethod_1(this.class1123_0.method_13(), this.class1123_0.method_14(), true);
        this.class1123_0.method_1(r᣼Array);
    }

    private void method_8()
    {
        if ((this.class1123_0.method_13().ᜀ().Count >= 2) && (((spr៧) this.class1123_0.method_9()).ᜀ().Count >= 2))
        {
            spr៧ spr = (spr៧) this.class1123_0.method_9();
            Class447 class2 = new Class447((PointF) this.class1123_0.method_13().ᜀ()[0], (PointF) this.class1123_0.method_13().ᜀ()[1]);
            Class447 class3 = new Class447((PointF) spr.ᜀ()[spr.ᜀ().Count - 2], (PointF) spr.ᜀ()[spr.ᜀ().Count - 1]);
            PointF[] tfArray2 = new PointF[] { PointF.Empty };
            if (Class447.smethod_2(class2, class3, tfArray2, true))
            {
                this.class1123_0.method_13().ᜀ()[0] = tfArray2[0];
                ((spr៧) this.class1123_0.method_9()).ᜀ()[spr.ᜀ().Count - 1] = tfArray2[0];
            }
        }
    }

    private spr៧ method_9(spr៧ A_0, float A_1)
    {
        spr៧ spr;
        int count = A_0.ᜀ().Count;
        if (count < 1)
        {
            return A_0;
        }
        switch (count)
        {
            case 1:
                spr = this.method_10(A_0);
                break;

            case 2:
                spr = this.method_11(A_0, A_1);
                break;

            default:
                spr = this.method_12(A_0, count, A_1);
                break;
        }
        this.method_22(A_0, spr);
        return spr;
    }

    internal static sprᲆ[] smethod_0(sprᲆ A_0)
    {
        Class675 class2 = new Class675();
        return class2.method_0(A_0);
    }

    internal static sprᲆ smethod_1(sprᲆ A_0, float A_1)
    {
        Class675 class2 = new Class675();
        return class2.method_1(A_0, new Class888(1f, A_1));
    }

    private static PointF smethod_2(spr᣼ A_0, Class447 A_1, Class447 A_2, PointF A_3, PointF A_4)
    {
        PointF[] tfArray2 = new PointF[] { PointF.Empty };
        bool flag = Class447.smethod_0(A_1, A_2);
        Class447 class2 = A_1.method_5(A_3);
        if (flag)
        {
            Class447 class3 = A_1.method_3(A_0.ᜂ());
            Class447.smethod_1(class2, class3, tfArray2);
        }
        else
        {
            Class447 class4 = A_2.method_5(A_4);
            Class447.smethod_1(class2, class4, tfArray2);
        }
        return tfArray2[0];
    }

    private static bool smethod_3(spr⚪ A_0, ArrayList A_1)
    {
        float num = 0f;
        float num2 = A_0.ᜀ() / 2f;
        bool flag = false;
        for (int i = 0; i < A_0.ᜊ().Length; i++)
        {
            float num4 = A_0.ᜊ()[i];
            if (((num4 < 0f) || (num4 > 1f)) || (num4 < num))
            {
                return false;
            }
            if (flag)
            {
                float num5 = (num4 - num) * A_0.ᜀ();
                float num6 = (A_0.ᜀ() * (num4 + num)) / 2f;
                float num7 = num6 - num2;
                A_1.Add(new Class888(num5, num7));
                flag = false;
            }
            else
            {
                flag = true;
            }
            num = num4;
        }
        return true;
    }

    public override void vmethod_0(sprᧂ A_0)
    {
        this.class1123_0.method_0(A_0);
    }

    public override void vmethod_1(sprᧂ A_0)
    {
        if ((A_0.ᜋ() > 1) && A_0.ᜁ())
        {
            this.method_2();
        }
    }

    public override void vmethod_2(spr៧ A_0)
    {
        this.class1123_0.method_20(this.class1123_0.method_19() + 1);
        spr៧ spr = this.method_9(A_0, this.class1123_0.method_6().method_2());
        if (spr != null)
        {
            this.class1123_0.method_5().ᜁ(spr);
        }
    }

    public override void vmethod_3(sprᡉ A_0)
    {
        this.class1123_0.method_20(this.class1123_0.method_19() + 1);
        sprᡉ[] rᡉArray = this.method_16(A_0, this.class1123_0.method_6().method_2());
        this.class1123_0.method_5().ᜀ(rᡉArray);
    }
}

