using System;
using System.Collections;

internal class Class505
{
    private readonly ArrayList arrayList_0;
    private readonly int int_0;
    private readonly spr➓ spr➓_0;

    internal Class505(spr➓ A_0) : this(A_0, 2)
    {
    }

    internal Class505(spr➓ A_0, int A_1)
    {
        this.spr➓_0 = A_0;
        this.int_0 = A_1;
        this.arrayList_0 = new ArrayList();
    }

    internal void method_0(sprᲆ A_0, sprᲆ[] A_1)
    {
        if ((A_1 != null) && (A_1.Length >= this.int_0))
        {
            Class1121 class2 = new Class1121();
            class2.method_1(this.spr➓_0.ᜀ(A_0));
            if (class2.method_0() != -1)
            {
                class2.method_3(A_1);
                this.arrayList_0.Add(class2);
            }
        }
    }

    internal void method_1(bool A_0)
    {
        int num = 0;
        foreach (Class1121 class2 in this.method_2())
        {
            int length = class2.method_2().Length;
            if (A_0)
            {
                this.spr➓_0.ᜁ(class2.method_0());
            }
            for (int i = 0; i < length; i++)
            {
                this.spr➓_0.ᜀ(class2.method_0() + num, class2.method_2()[i]);
            }
            num += length - 1;
        }
    }

    private Class1121[] method_2()
    {
        this.arrayList_0.Sort();
        return (Class1121[]) this.arrayList_0.ToArray(typeof(Class1121));
    }
}

