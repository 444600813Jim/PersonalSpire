using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class1123
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private readonly Class888 class888_0;
    private const float float_0 = 0.1f;
    private int int_0;
    private object object_0;
    private readonly sprᲆ sprᲆ_0;
    private spr᣼[] spr᣼_0;
    private spr᣼[] spr᣼_1;
    private spr៧ spr៧_0;
    private sprᡉ[] sprᡉ_0;
    private sprᡉ[] sprᡉ_1;
    private sprᧂ sprᧂ_0;
    private sprᮃ sprᮃ_0;

    internal Class1123(sprᲆ A_0, Class888 A_1)
    {
        this.class888_0 = A_1;
        this.sprᲆ_0 = new sprᲆ();
        this.method_7().ᜀ(A_0.ᜀ().ᜈ());
        this.method_7().ᜀ().ᜀ(Class675.float_0);
        this.method_7().ᜀ().ᜂ((this.method_6().method_0() > 1f) ? this.method_6().method_0() : 1f);
        if (this.method_7().ᜀ().ᜍ() != DashStyle.Solid)
        {
            this.method_7().ᜀ().ᜁ(smethod_7(A_0.ᜀ().ᜋ(), A_0.ᜀ().ᜀ(), this.method_7().ᜀ().ᜀ()));
        }
    }

    internal void method_0(sprᧂ A_0)
    {
        this.sprᧂ_0 = new sprᧂ();
        this.method_5().ᜀ(A_0.ᜁ());
        this.method_17(A_0.ᜁ());
        this.method_7().ᜁ(this.method_5());
        this.sprᮃ_0 = null;
        this.object_0 = null;
        this.spr៧_0 = null;
        this.bool_0 = false;
        this.method_20(0);
        ArrayList list = smethod_0(A_0);
        this.bool_4 = spr⃸.ᜀ(list);
    }

    internal void method_1(spr᣼[] A_0)
    {
        PointF empty = PointF.Empty;
        for (int i = 0; i < this.sprᡉ_0.Length; i++)
        {
            if (A_0.Length > i)
            {
                this.sprᡉ_0[i].ᜀ(new sprṋ(A_0[i].ᜁ(), A_0[i].ᜂ(), A_0[i].ᜀ()));
                empty = A_0[i].ᜀ();
            }
            else
            {
                this.sprᡉ_0[i].ᜀ(new sprṋ(empty, empty, empty));
            }
        }
        if ((this.method_19() == 2) && !this.method_12())
        {
            this.spr᣼_1 = A_0;
        }
    }

    internal void method_10(object A_0)
    {
        this.object_0 = A_0;
    }

    internal bool method_11()
    {
        return this.bool_1;
    }

    internal bool method_12()
    {
        return this.bool_2;
    }

    internal spr៧ method_13()
    {
        return this.spr៧_0;
    }

    internal spr᣼[] method_14()
    {
        return this.spr᣼_0;
    }

    internal spr᣼[] method_15()
    {
        return this.spr᣼_1;
    }

    internal bool method_16()
    {
        return this.bool_3;
    }

    internal void method_17(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal bool method_18()
    {
        return this.bool_4;
    }

    internal int method_19()
    {
        return this.int_0;
    }

    internal void method_2(spr᣼[] A_0)
    {
        PointF empty = PointF.Empty;
        for (int i = 0; i < this.sprᡉ_1.Length; i++)
        {
            if (A_0.Length > i)
            {
                this.sprᡉ_1[(this.sprᡉ_1.Length - 1) - i].ᜀ(new sprṋ(A_0[i].ᜁ(), A_0[i].ᜂ(), A_0[i].ᜀ()));
                empty = A_0[i].ᜀ();
            }
            else
            {
                this.sprᡉ_1[(this.sprᡉ_1.Length - 1) - i].ᜀ(new sprṋ(empty, empty, empty));
            }
        }
    }

    internal void method_20(int A_0)
    {
        this.int_0 = A_0;
    }

    internal void method_3(spr៧ A_0, spr៧ A_1)
    {
        this.sprᮃ_0 = A_1;
        this.object_0 = A_0;
        this.bool_1 = true;
        if (!this.bool_0)
        {
            this.bool_0 = true;
            this.spr៧_0 = A_0;
            this.bool_2 = true;
        }
    }

    internal void method_4(spr᣼[] A_0, sprᡉ[] A_1, sprᡉ A_2)
    {
        this.object_0 = A_0[A_0.Length - 1];
        this.spr᣼_0 = A_0;
        this.sprᡉ_0 = A_1;
        if (!this.bool_0)
        {
            this.bool_0 = true;
            this.bool_2 = false;
            this.spr᣼_1 = A_0;
            this.sprᡉ_1 = A_1;
        }
        this.sprᮃ_0 = A_2;
        this.bool_1 = false;
    }

    internal sprᧂ method_5()
    {
        return this.sprᧂ_0;
    }

    internal Class888 method_6()
    {
        return this.class888_0;
    }

    internal sprᲆ method_7()
    {
        return this.sprᲆ_0;
    }

    internal sprᮃ method_8()
    {
        return this.sprᮃ_0;
    }

    internal object method_9()
    {
        return this.object_0;
    }

    private static ArrayList smethod_0(sprᧂ A_0)
    {
        ArrayList list = new ArrayList();
        bool flag = false;
        sprᮃ rᮃ = null;
        for (int i = 0; i < A_0.ᜋ(); i++)
        {
            sprᮃ rᮃ2 = A_0.ᜀ(i);
            if (rᮃ2 is spr៧)
            {
                smethod_2((spr៧) rᮃ2, A_0, i, list, rᮃ, flag);
                flag = true;
            }
            else if (rᮃ2 is sprᡉ)
            {
                if (smethod_1((sprᡉ) rᮃ2, A_0, i, list, rᮃ, flag))
                {
                    i++;
                }
                flag = false;
            }
            rᮃ = rᮃ2;
        }
        return list;
    }

    private static bool smethod_1(sprᡉ A_0, sprᧂ A_1, int A_2, ArrayList A_3, sprᮃ A_4, bool A_5)
    {
        bool flag = false;
        A_3.Add(A_0.ᜀ().ᜂ());
        A_3.Add(A_0.ᜀ().ᜀ());
        if (A_4 != null)
        {
            if (smethod_3(A_0, A_4, false, A_5, A_1, A_2))
            {
                flag = true;
            }
            return flag;
        }
        if (((A_1.ᜋ() != 1) && A_1.ᜁ()) && smethod_3(A_0, A_1.ᜀ(A_1.ᜋ() - 1), false, A_1.ᜀ(A_1.ᜋ() - 1) is spr៧, A_1, A_2))
        {
            flag = true;
        }
        return flag;
    }

    private static void smethod_2(spr៧ A_0, sprᧂ A_1, int A_2, ArrayList A_3, sprᮃ A_4, bool A_5)
    {
        A_3.AddRange(A_0.ᜀ());
        if (A_4 != null)
        {
            smethod_3(A_0, A_4, true, A_5, A_1, A_2);
        }
        else if ((A_1.ᜋ() != 1) && A_1.ᜁ())
        {
            smethod_3(A_0, A_1.ᜀ(A_1.ᜋ() - 1), true, A_1.ᜀ(A_1.ᜋ() - 1) is spr៧, A_1, A_2);
        }
    }

    private static bool smethod_3(sprᮃ A_0, sprᮃ A_1, bool A_2, bool A_3, sprᧂ A_4, int A_5)
    {
        if (A_2)
        {
            smethod_5(A_0, A_1, A_3);
            return false;
        }
        return smethod_4(A_0, A_1, A_3, A_4, A_5);
    }

    private static bool smethod_4(sprᮃ A_0, sprᮃ A_1, bool A_2, sprᧂ A_3, int A_4)
    {
        sprᡉ rᡉ = A_0;
        if (A_2)
        {
            smethod_6(A_1, rᡉ.ᜀ().ᜂ());
        }
        else
        {
            sprᡉ rᡉ2 = A_1;
            if (!spr⃸.ᜀ(rᡉ2.ᜀ().ᜀ(), rᡉ.ᜀ().ᜂ(), 0.1f))
            {
                PointF[] tfArray = new PointF[] { rᡉ2.ᜀ().ᜀ(), rᡉ.ᜀ().ᜂ() };
                spr៧ spr = new spr៧(tfArray);
                A_3.ᜀ(A_4, spr);
                return true;
            }
        }
        return false;
    }

    private static void smethod_5(sprᮃ A_0, sprᮃ A_1, bool A_2)
    {
        spr៧ spr = A_0;
        if (A_2)
        {
            smethod_6(A_1, (PointF) spr.ᜀ()[0]);
        }
        else
        {
            sprᡉ rᡉ = A_1;
            if (!spr⃸.ᜀ(rᡉ.ᜀ().ᜀ(), (PointF) spr.ᜀ()[0], 0.1f))
            {
                spr.ᜀ().Insert(0, rᡉ.ᜀ().ᜀ());
            }
        }
    }

    private static void smethod_6(sprᮃ A_0, PointF A_1)
    {
        spr៧ spr = A_0;
        if (!spr⃸.ᜀ((PointF) spr.ᜀ()[spr.ᜀ().Count - 1], A_1, 0.1f))
        {
            spr.ᜀ().Add(A_1);
        }
    }

    private static float[] smethod_7(float[] A_0, float A_1, float A_2)
    {
        float[] numArray = new float[A_0.Length];
        for (int i = 0; i < A_0.Length; i++)
        {
            numArray[i] = (A_0[i] * A_1) / A_2;
        }
        return numArray;
    }
}

