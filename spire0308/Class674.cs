using System;
using System.Drawing;

internal class Class674 : spr᥋
{
    private bool bool_0;
    private Class890 class890_0;
    private spr◽ spr◽_0;
    private readonly spr⚪ spr⚪_0 = new spr⚪(sprⓚ.ᜋ, 0.15f);
    private spr➓ spr➓_0;

    internal Class674(Class672 A_0)
    {
        this.class890_0 = new Class890(A_0);
    }

    internal spr➓ method_0(spr➓ A_0, bool A_1)
    {
        this.bool_0 = A_1;
        A_0.ᜀ(this);
        return this.spr➓_0;
    }

    private void method_1()
    {
        sprᳺ rᳺ = new sprᳺ();
        rᳺ.ᜀ(-this.class890_0.method_18().X, -this.class890_0.method_18().Y, 0f);
        rᳺ.ᜀ(this.class890_0.method_14(), this.class890_0.method_16());
        rᳺ.ᜀ(this.class890_0.method_18().X, this.class890_0.method_18().Y, 0f);
        this.spr◽_0.ᜀ(rᳺ);
    }

    private sprᲆ method_2()
    {
        sprᳺ rᳺ = sprᳺ.ᜂ(this.class890_0.method_4());
        return this.method_4(rᳺ);
    }

    private sprᲆ method_3()
    {
        sprᳺ rᳺ = sprᳺ.ᜀ(new spr⁍(this.class890_0.method_8(), this.class890_0.method_10(), this.class890_0.method_12()), this.class890_0.method_6());
        return this.method_4(rᳺ);
    }

    private sprᲆ method_4(sprᳺ A_0)
    {
        spr↾ r↾ = new spr↾(A_0);
        this.spr◽_0.ᜀ(r↾);
        r↾.ᜁ().ᜀ(this.spr⚪_0);
        return r↾.ᜁ();
    }

    public override void vmethod_0(spr➓ A_0)
    {
        this.spr➓_0 = new spr➓();
        base.ᜀ(A_0);
    }

    public override void vmethod_1(sprᲆ A_0)
    {
        this.spr◽_0 = new spr◽();
        base.ᜀ(A_0);
    }

    public override void vmethod_2(sprᲆ A_0)
    {
        this.method_1();
        if (this.bool_0)
        {
            this.spr➓_0.ᜁ(this.method_2());
        }
        else
        {
            this.spr➓_0.ᜁ(this.method_3());
        }
        base.ᜂ(A_0);
    }

    public override void vmethod_3(sprᧂ A_0)
    {
        this.spr◽_0.ᜀ(new spr⇟());
        base.ᜀ(A_0);
    }

    public override void vmethod_4(sprᧂ A_0)
    {
        spr⇟ r⇟ = this.spr◽_0.ᜀ(this.spr◽_0.ᜀ() - 1);
        spr⇟ r⇟2 = r⇟.ᜂ();
        sprᳺ rᳺ = new sprᳺ();
        rᳺ.ᜀ(0f, 0f, this.class890_0.method_0() + this.class890_0.method_2());
        r⇟2.ᜀ(rᳺ);
        this.spr◽_0.ᜀ(r⇟2);
        for (int i = 0; i < r⇟.ᜀ(); i++)
        {
            spr⇟ r⇟3 = new spr⇟();
            spr⁍ r⁍ = r⇟.ᜀ(i).ᜂ();
            spr⁍ r⁍2 = r⁍.ᜂ();
            r⁍2.ᜂ(this.class890_0.method_2());
            r⇟3.ᜀ(r⁍);
            r⇟3.ᜀ(r⁍2);
            this.spr◽_0.ᜀ(r⇟3);
        }
        base.ᜁ(A_0);
    }

    public override void vmethod_5(spr៧ A_0)
    {
        for (int i = 0; i < A_0.ᜀ().Count; i++)
        {
            PointF tf = (PointF) A_0.ᜀ()[i];
            spr⁍ r⁍ = new spr⁍(tf.X, tf.Y, -this.class890_0.method_0());
            ((spr⇟) this.spr◽_0.ᜀ(this.spr◽_0.ᜀ() - 1)).ᜀ(r⁍);
        }
        base.ᜀ(A_0);
    }

    public override void vmethod_6(sprᡉ A_0)
    {
        float num = 0.25f / ((float) (((int) ((Class951.smethod_1(A_0.ᜀ()) - 5.0) / 10.0)) + 1));
        if (num < 0.05f)
        {
            num = 0.05f;
        }
        float num3 = 0.25f;
        for (float i = 0f; i <= 1f; i += num)
        {
            double num4 = Class951.smethod_0(A_0.ᜀ(), i);
            num3 += num;
            if (((num4 > 0.005) || (num3 >= 0.25f)) || (i == 1f))
            {
                PointF tf = Class951.smethod_2(A_0.ᜀ(), i);
                spr⁍ r⁍ = new spr⁍(tf.X, tf.Y, -this.class890_0.method_0());
                ((spr⇟) this.spr◽_0.ᜀ(this.spr◽_0.ᜀ() - 1)).ᜀ(r⁍);
                num3 = 0f;
            }
        }
        base.ᜀ(A_0);
    }
}

