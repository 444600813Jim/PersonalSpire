using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class1042 : IEnumerable
{
    private ArrayList arrayList_0;
    private readonly Class181 class181_0;
    private Class295 class295_0;

    public Class1042()
    {
        this.arrayList_0 = new ArrayList();
        this.class181_0 = new Class181(false);
    }

    public Class1042(Class295 A_0)
    {
        this.arrayList_0 = new ArrayList();
        this.class295_0 = A_0;
        this.class181_0 = new Class181(false);
    }

    public int method_0()
    {
        return this.class181_0.Count;
    }

    public Class467 method_1(string A_0)
    {
        return (Class467) this.class181_0[A_0];
    }

    public void method_2(Class467 A_0)
    {
        if (this.class295_0 != null)
        {
            A_0.method_4().Position = 0L;
            this.class295_0.method_0(smethod_0(A_0.method_0()), A_0.method_4());
            A_0.method_4().Close();
            A_0.method_5(null);
        }
        this.class181_0.Add(A_0.method_0(), A_0);
    }

    public void method_3()
    {
        foreach (Class467 class2 in this.arrayList_0)
        {
            class2.method_4().Position = 0L;
            this.class295_0.method_0(smethod_0(class2.method_0()), class2.method_4());
            class2.method_4().Close();
            class2.method_5(null);
        }
    }

    public bool method_4(string A_0)
    {
        return this.class181_0.Contains(A_0);
    }

    private static string smethod_0(string A_0)
    {
        return A_0.TrimStart(new char[] { '/' });
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.class181_0.GetValueList().GetEnumerator();
    }
}

