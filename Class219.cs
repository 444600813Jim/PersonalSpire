using Spire.Doc.Fields.Shape;
using System;
using System.Collections;

internal abstract class Class219
{
    internal const float float_0 = 21600f;
    private readonly Hashtable hashtable_0;
    protected readonly sprℭ sprℭ_0;

    internal Class219(sprℭ A_0, Hashtable A_1)
    {
        this.sprℭ_0 = A_0;
        this.hashtable_0 = A_1;
    }

    protected spr➓ method_0(Class724 A_0, bool A_1)
    {
        spr➓ r➓ = null;
        Class69 class2 = (Class69) this.hashtable_0[A_0.method_3()];
        if (class2 == null)
        {
            return r➓;
        }
        A_0.method_2(class2.method_4());
        if (A_1)
        {
            A_0.method_5(class2.method_4().Size);
        }
        A_0.method_13(class2.method_2());
        return class2.method_1().ᜂ();
    }

    protected void method_1(ShapeBase A_0, Class69 A_1)
    {
        this.hashtable_0[A_0] = A_1;
    }

    protected void method_2(ShapeBase A_0)
    {
        this.hashtable_0[A_0] = null;
    }
}

