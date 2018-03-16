using System;
using System.Collections;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
internal class Class1063 : ArrayList
{
    public Class266 method_0(int A_0)
    {
        return (Class266) base[A_0];
    }

    public void method_1(int A_0, Class266 A_1)
    {
        base[A_0] = A_1;
    }

    internal void method_2(BinaryReader A_0, int A_1)
    {
        long num = A_0.BaseStream.Position + A_1;
        num = Math.Min(num, A_0.BaseStream.Length);
        while (A_0.BaseStream.Position < num)
        {
            Class266 class2 = Class1062.smethod_0(A_0);
            if (class2 != null)
            {
                this.Add(class2);
            }
        }
    }

    internal int method_3(BinaryWriter A_0)
    {
        long position = A_0.BaseStream.Position;
        foreach (Class266 class2 in this)
        {
            class2.method_2(A_0);
        }
        return (int) (A_0.BaseStream.Position - position);
    }
}

