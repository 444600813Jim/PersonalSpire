using System;
using System.Collections;
using System.Drawing;

internal class Class445 : spr᥋
{
    private ArrayList arrayList_0;
    private bool bool_0;
    private Class622 class622_0;
    private RectangleF rectangleF_0;

    private void method_0(Class622 A_0)
    {
        this.method_4(A_0);
        for (int i = 0; i < A_0.method_8(); i++)
        {
            this.method_5(A_0.method_9(i));
            if (this.bool_0)
            {
                this.class622_0.method_2(A_0.method_9(i));
            }
            else
            {
                this.class622_0.method_0(A_0.method_9(i));
            }
        }
    }

    private Class622 method_1(spr➓ A_0, RectangleF A_1)
    {
        this.rectangleF_0 = A_1;
        this.class622_0 = new Class622();
        this.arrayList_0 = new ArrayList();
        A_0.ᜀ(this);
        return this.class622_0;
    }

    private Class622 method_2(sprᲆ A_0)
    {
        Class622 class2 = null;
        if (!this.bool_0)
        {
            class2 = this.method_3(A_0);
        }
        if (class2 == null)
        {
            class2 = Class548.smethod_0(A_0);
        }
        return class2;
    }

    private Class622 method_3(sprᲆ A_0)
    {
        if (A_0.ᜀ() == null)
        {
            spr⍂ r⍂ = A_0.ᜈ() as spr⍂;
            if (r⍂ != null)
            {
                return Class501.smethod_0(r⍂.ᜁ(), this.rectangleF_0);
            }
        }
        return null;
    }

    private void method_4(Class622 A_0)
    {
        Class549 class2 = (Class549) this.arrayList_0[this.arrayList_0.Count - 1];
        if (class2.method_2() != null)
        {
            A_0.method_7(class2.method_2());
        }
    }

    private void method_5(Class722 A_0)
    {
        for (int i = this.arrayList_0.Count - 1; i >= 0; i--)
        {
            Class549 class2 = (Class549) this.arrayList_0[i];
            spr➂ r➂ = spr➂.ᜀ(class2.method_0(), null) ? class2.method_0() : null;
            if (spr➂.ᜀ(r➂, null))
            {
                A_0.method_13(r➂);
            }
        }
    }

    internal static Class622 smethod_0(spr➓ A_0, RectangleF A_1)
    {
        Class445 class2 = new Class445();
        return class2.method_1(A_0, A_1);
    }

    internal static RectangleF smethod_1(spr➓ A_0)
    {
        Class445 class2 = new Class445 {
            bool_0 = true
        };
        return class2.method_1(A_0, RectangleF.Empty).method_6();
    }

    private static Class622 smethod_2(sprἣ A_0)
    {
        return Class501.smethod_0(A_0.ᜊ(), A_0.ᜂ());
    }

    public override void vmethod_0(spr➓ A_0)
    {
        Class549 class2 = new Class549(A_0.ᜀ());
        if (A_0.ᜃ() != null)
        {
            sprᲆ rᲆ = new Class1024().method_0(A_0.ᜃ(), false, false);
            rᲆ.ᜀ(new spr⚪(sprⓚ.ᜋ));
            rᲆ.ᜀ().ᜂ(0f);
            Class622 class4 = Class548.smethod_0(rᲆ);
            class2.method_3((class4.method_8() > 0) ? class4.method_9(0) : null);
        }
        this.arrayList_0.Add(class2);
    }

    public override void vmethod_1(spr➓ A_0)
    {
        if (this.bool_0 && (A_0.ᜋ() == 0))
        {
            PointF[] tfArray = new PointF[] { PointF.Empty };
            this.method_0(new Class622(new Class722(tfArray)));
        }
        this.arrayList_0.RemoveAt(this.arrayList_0.Count - 1);
    }

    public override void vmethod_2(sprᲆ A_0)
    {
        Class622 class2 = this.method_2(A_0);
        this.method_0(class2);
    }

    public override void vmethod_3(sprἣ A_0)
    {
        Class622 class2 = smethod_2(A_0);
        this.method_0(class2);
    }

    public override void vmethod_4(spr⚢ A_0)
    {
        Class622 class2 = new Class622(new Class722(A_0.ᜄ()));
        this.method_0(class2);
    }
}

