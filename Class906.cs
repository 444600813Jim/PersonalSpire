using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class906 : IEnumerable
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal int method_0()
    {
        return this.arrayList_0.Count;
    }

    internal Class14 method_1(int A_0)
    {
        return (Class14) this.arrayList_0[A_0];
    }

    internal void method_2(Class14 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

