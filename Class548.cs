using System;
using System.Collections;
using System.Drawing;

internal class Class548 : spr᥋
{
    private ArrayList arrayList_0;
    private readonly Class1024 class1024_0 = new Class1024();
    private Class622 class622_0;
    private Class722 class722_0;

    private Class622 method_0(sprᲆ A_0)
    {
        this.class622_0 = new Class622();
        sprᲆ rᲆ = this.method_1(A_0);
        if (!smethod_3(rᲆ))
        {
            return new Class622(new Class722());
        }
        rᲆ.ᜀ(this);
        if (A_0.ᜇ() != null)
        {
            Class622 class2 = smethod_0(A_0.ᜇ());
            Class722 class3 = (class2.method_8() > 0) ? class2.method_9(0) : null;
            if (class3 != null)
            {
                this.class622_0.method_7(class3);
            }
        }
        if (spr➂.ᜀ(A_0.ᜁ(), null))
        {
            this.class622_0.method_4(A_0.ᜁ());
        }
        this.class622_0.method_3(true);
        return this.class622_0;
    }

    private sprᲆ method_1(sprᲆ A_0)
    {
        if (A_0.ᜀ() == null)
        {
            return A_0;
        }
        sprᲆ rᲆ = this.class1024_0.method_0(A_0, false, false);
        rᲆ.ᜀ(new spr⚪(sprⓚ.ᜋ));
        rᲆ.ᜀ().ᜂ(1f);
        bool flag = (A_0.ᜈ() != null) || A_0.ᜄ();
        float num = (A_0.ᜀ().ᜀ() == 0f) ? 0.75f : A_0.ᜀ().ᜀ();
        if (flag && (A_0.ᜀ().ᜀ() == 0f))
        {
            return rᲆ;
        }
        sprᲆ rᲆ2 = Class675.smethod_1(rᲆ, -num * 0.5f);
        if (flag)
        {
            return rᲆ2;
        }
        return smethod_1(A_0.ᜀ().ᜀ(), rᲆ, rᲆ2);
    }

    private void method_2()
    {
        this.method_3();
        this.method_5();
    }

    private void method_3()
    {
        ArrayList list = this.method_4();
        for (int i = 0; i < list.Count; i++)
        {
            this.class722_0.method_7(((int) list[i]) - i);
        }
    }

    private ArrayList method_4()
    {
        ArrayList list = new ArrayList();
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            int num2 = (int) this.arrayList_0[i];
            if (smethod_2(this.class722_0.method_20(num2 - 1).method_2(), this.class722_0.method_20(num2).method_2(), this.class722_0.method_20(num2 + 1).method_2(), this.class722_0.method_22()))
            {
                list.Add(num2);
            }
        }
        return list;
    }

    private void method_5()
    {
        if (this.class722_0.method_19() >= 2)
        {
            ArrayList list = new ArrayList();
            int num3 = this.class722_0.method_19();
            for (int i = 1; i < (num3 - 1); i++)
            {
                if (spr⃸.ᜀ(this.class722_0.method_20(i - 1).method_2(), this.class722_0.method_20(i).method_2()))
                {
                    list.Add(i);
                }
            }
            for (int j = 0; j < list.Count; j++)
            {
                this.class722_0.method_7(((int) list[j]) - j);
            }
            if ((this.class722_0.method_19() > 2) && spr⃸.ᜀ(this.class722_0.method_20(0).method_2(), this.class722_0.method_20(this.class722_0.method_19() - 1).method_2()))
            {
                this.class722_0.method_7(this.class722_0.method_19() - 1);
            }
        }
    }

    internal static Class622 smethod_0(sprᲆ A_0)
    {
        Class548 class2 = new Class548();
        return class2.method_0(A_0);
    }

    private static sprᲆ smethod_1(float A_0, sprᲆ A_1, sprᲆ A_2)
    {
        sprᲆ rᲆ = Class1023.smethod_0(Class675.smethod_1(A_1, A_0 * 0.5f));
        for (int i = 0; i < rᲆ.ᜋ(); i++)
        {
            if (i == (rᲆ.ᜋ() - 1))
            {
                sprᧂ rᧂ = rᲆ.ᜀ(i);
                sprᧂ rᧂ2 = A_2.ᜀ(0);
                for (int j = 0; j < rᧂ.ᜋ(); j++)
                {
                    rᧂ2.ᜀ(j, rᧂ.ᜀ(j));
                }
            }
            else
            {
                A_2.ᜁ(rᲆ.ᜀ(i));
            }
        }
        return A_2;
    }

    private static bool smethod_2(PointF A_0, PointF A_1, PointF A_2, bool A_3)
    {
        Class447 class2 = new Class447(A_0, A_2);
        bool flag = !class2.method_1(A_1);
        bool flag2 = (A_0.X - A_2.X) > 0f;
        if (A_3)
        {
            return (flag ^ flag2);
        }
        return ((flag2 && flag) || (!flag2 && !flag));
    }

    private static bool smethod_3(sprᲆ A_0)
    {
        return (((A_0.ᜀ() != null) && smethod_4(A_0.ᜀ().ᜌ())) || smethod_4(A_0.ᜈ()));
    }

    private static bool smethod_4(spr᧢ A_0)
    {
        if (A_0 == null)
        {
            return false;
        }
        spr⡅ r⡅ = A_0 as spr⡅;
        if (r⡅ != null)
        {
            return (r⡅.ᜀ().ᜁ() != 0);
        }
        return true;
    }

    public override void vmethod_0(sprᧂ A_0)
    {
        this.class722_0 = new Class722();
        this.arrayList_0 = new ArrayList();
    }

    public override void vmethod_1(sprᧂ A_0)
    {
        this.method_2();
        this.class622_0.method_0(this.class722_0);
    }

    public override void vmethod_2(spr៧ A_0)
    {
        this.class722_0.method_1(A_0.ᜀ(), true);
    }

    public override void vmethod_3(sprᡉ A_0)
    {
        spr᣼[] r᣼Array = A_0.ᜀ().ᜁ();
        for (int i = 0; i < r᣼Array.Length; i++)
        {
            this.class722_0.method_4(r᣼Array[i].ᜁ());
            this.class722_0.method_4(r᣼Array[i].ᜂ());
            this.arrayList_0.Add(this.class722_0.method_19() - 1);
        }
        this.class722_0.method_4(r᣼Array[r᣼Array.Length - 1].ᜀ());
    }
}

