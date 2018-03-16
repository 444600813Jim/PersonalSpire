using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class1030 : ArrayList
{
    internal Class1030()
    {
    }

    internal Class1030(ArrayList A_0) : base(A_0)
    {
    }

    internal Class1030(int A_0) : base(A_0)
    {
    }

    internal Class1030(params Class1125[] A_0) : base(A_0.Length)
    {
        foreach (Class1125 class2 in A_0)
        {
            this.Add(class2);
        }
    }

    public Class1125 method_0(int A_0)
    {
        return (Class1125) base[A_0];
    }

    public void method_1(int A_0, Class1125 A_1)
    {
        base[A_0] = A_1;
    }
}

