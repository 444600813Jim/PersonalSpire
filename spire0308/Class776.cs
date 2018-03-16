using Spire.Doc.Documents;
using System;
using System.Reflection;

[DefaultMember("Item")]
internal class Class776
{
    private Class656 class656_0 = new Class656();

    internal Class776 method_0()
    {
        Class776 class2 = (Class776) base.MemberwiseClone();
        class2.class656_0 = new Class656();
        for (int i = 0; i < this.class656_0.method_2(); i++)
        {
            class2.class656_0.method_5(this.class656_0.method_13(i), ((Class66) this.class656_0.method_12(i)).method_0());
        }
        return class2;
    }

    internal void method_1(Class66 A_0)
    {
        this.class656_0.method_4((int) A_0.method_2(), A_0);
    }

    internal void method_2()
    {
        this.class656_0.method_6();
    }

    internal Class66 method_3(StyleIdentifier A_0)
    {
        return (Class66) this.class656_0.method_3((int) A_0);
    }

    internal Class66 method_4(int A_0)
    {
        return (Class66) this.class656_0.method_12(A_0);
    }

    internal int method_5()
    {
        return this.class656_0.method_2();
    }
}

