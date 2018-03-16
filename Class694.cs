using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class694 : IEnumerable
{
    private readonly IDictionary idictionary_0 = Class83.smethod_0();

    public int method_0()
    {
        return this.idictionary_0.Count;
    }

    public void method_1(Class113 A_0)
    {
        this.idictionary_0.Add(A_0.method_1(), A_0);
    }

    public Class113 method_2(string A_0)
    {
        return (Class113) this.idictionary_0[A_0];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.idictionary_0.Values.GetEnumerator();
    }
}

