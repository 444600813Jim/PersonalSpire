using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class461
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal Class461 method_0()
    {
        Class461 class2 = new Class461();
        for (int i = 0; i < this.method_7(); i++)
        {
            class2.method_1(this.method_6(i).method_0());
        }
        return class2;
    }

    internal void method_1(Class683 A_0)
    {
        this.method_2(A_0, 1);
    }

    internal void method_2(Class683 A_0, int A_1)
    {
        for (int i = 0; i < A_1; i++)
        {
            this.arrayList_0.Add(A_0.method_0());
        }
    }

    internal void method_3(int A_0)
    {
        this.arrayList_0.RemoveAt(A_0);
    }

    internal void method_4()
    {
        this.method_3(this.method_7() - 1);
    }

    internal void method_5(int A_0)
    {
        int num = this.method_7() - A_0;
        if (num > 0)
        {
            for (int i = 0; i < num; i++)
            {
                this.method_4();
            }
        }
        else if (num < 0)
        {
            for (int j = num; j < 0; j++)
            {
                this.method_1(new Class683());
            }
        }
    }

    internal Class683 method_6(int A_0)
    {
        return (Class683) this.arrayList_0[A_0];
    }

    internal int method_7()
    {
        return this.arrayList_0.Count;
    }
}

