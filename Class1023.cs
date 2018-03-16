using System;
using System.Collections;
using System.Drawing;

internal class Class1023 : spr᥋
{
    private sprᧂ sprᧂ_0;

    internal sprᲆ method_0(sprᲆ A_0)
    {
        sprᲆ rᲆ = A_0.ᜀ(false);
        if (A_0.ᜋ() != 0)
        {
            for (int i = A_0.ᜋ() - 1; i >= 0; i--)
            {
                sprᧂ rᧂ = A_0.ᜀ(i);
                this.sprᧂ_0 = new sprᧂ();
                this.sprᧂ_0.ᜀ(rᧂ.ᜁ());
                rᧂ.ᜀ(this);
                rᲆ.ᜁ(this.sprᧂ_0);
            }
        }
        return rᲆ;
    }

    internal static sprᲆ smethod_0(sprᲆ A_0)
    {
        Class1023 class2 = new Class1023();
        return class2.method_0(A_0);
    }

    public override void vmethod_0(spr៧ A_0)
    {
        ArrayList list = (ArrayList) A_0.ᜀ().Clone();
        list.Reverse();
        spr៧ spr = new spr៧((PointF[]) list.ToArray(typeof(PointF)));
        this.sprᧂ_0.ᜀ(0, spr);
    }

    public override void vmethod_1(sprᡉ A_0)
    {
        sprᡉ rᡉ = new sprᡉ(A_0.ᜀ().ᜀ(), A_0.ᜀ().ᜃ(), A_0.ᜀ().ᜄ(), A_0.ᜀ().ᜂ());
        this.sprᧂ_0.ᜀ(0, rᡉ);
    }
}

