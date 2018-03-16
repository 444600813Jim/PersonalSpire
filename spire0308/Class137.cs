using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class137
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    public Class138 method_0(int A_0)
    {
        return (Class138) this.arrayList_0[A_0];
    }

    internal void method_1(Class138 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal int method_2()
    {
        return this.arrayList_0.Count;
    }

    public IEnumerator method_3()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

