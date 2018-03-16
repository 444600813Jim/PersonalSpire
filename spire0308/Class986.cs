using System;
using System.Collections.Specialized;
using System.IO;

internal class Class986
{
    private readonly Class157 class157_0;
    private const int int_0 = 5;
    private readonly StringCollection stringCollection_0;

    internal Class986()
    {
        this.stringCollection_0 = new StringCollection();
        this.class157_0 = new Class157();
    }

    internal Class986(Class703 A_0, BinaryReader A_1)
    {
        this.stringCollection_0 = new StringCollection();
        this.class157_0 = new Class157();
        if (A_0.class597_0.class1111_54.int_1 != 0)
        {
            this.class157_0.method_23(A_1, A_0.class597_0.class1111_54);
        }
    }

    internal void method_0(Class342 A_0, string A_1)
    {
        for (int i = 0; i < this.class157_0.method_4(); i++)
        {
            Class756 class2 = (Class756) this.class157_0.method_18(i);
            this.stringCollection_0.Add(Class736.smethod_24(A_1, A_0.method_5(class2.method_0())));
        }
    }

    internal void method_1(Class703 A_0, Class342 A_1, BinaryWriter A_2)
    {
        if (this.stringCollection_0.Count != 0)
        {
            for (int i = 0; i < this.class157_0.method_4(); i++)
            {
                ((Class756) this.class157_0.method_18(i)).method_1(A_1.method_6(5, this.stringCollection_0[i]));
            }
            A_0.class597_0.class1111_54.int_0 = (int) A_2.BaseStream.Position;
            this.class157_0.vmethod_1(A_2);
            A_0.class597_0.class1111_54.int_1 = ((int) A_2.BaseStream.Position) - A_0.class597_0.class1111_54.int_0;
        }
    }

    internal void method_2(int A_0, Class4 A_1)
    {
        this.class157_0.method_6(A_0, new Class756());
        this.stringCollection_0.Add(A_1.method_30());
    }

    internal void method_3(Class986 A_0, int A_1)
    {
        if (A_0.method_7() != 0)
        {
            for (int i = 0; i < A_0.method_7(); i++)
            {
                int num2 = A_0.method_6().method_16(i);
                this.class157_0.method_6(num2 + A_1, new Class756());
                this.stringCollection_0.Add(A_0.method_5(i));
            }
        }
    }

    internal void method_4(int A_0)
    {
        if (this.stringCollection_0.Count != 0)
        {
            this.class157_0.method_8(A_0);
        }
    }

    internal string method_5(int A_0)
    {
        if (A_0 < this.method_7())
        {
            return this.stringCollection_0[A_0];
        }
        return null;
    }

    internal Class157 method_6()
    {
        return this.class157_0;
    }

    internal int method_7()
    {
        return this.stringCollection_0.Count;
    }
}

