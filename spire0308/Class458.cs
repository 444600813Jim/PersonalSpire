using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class458 : IEnumerable
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    public int method_0()
    {
        return this.arrayList_0.Count;
    }

    public Class905 method_1(int A_0)
    {
        return (Class905) this.arrayList_0[A_0];
    }

    public void method_2(int A_0, Class905 A_1)
    {
        this.arrayList_0[A_0] = A_1;
    }

    public void method_3(Class905 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    public void method_4(int A_0)
    {
        this.arrayList_0.RemoveAt(A_0);
    }

    public void method_5()
    {
        this.arrayList_0.Clear();
    }

    public Class458 method_6()
    {
        Class458 class2 = new Class458();
        foreach (Class905 class3 in this.arrayList_0)
        {
            class2.method_3(class3.method_10());
        }
        return class2;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

