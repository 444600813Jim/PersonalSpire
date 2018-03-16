using Spire.Doc;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class1033 : IEnumerable
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal Class1033()
    {
    }

    public int method_0()
    {
        return this.arrayList_0.Count;
    }

    public string method_1(int A_0)
    {
        return (string) this.arrayList_0[A_0];
    }

    public void method_2(int A_0, string A_1)
    {
        this.arrayList_0[A_0] = A_1;
    }

    public void method_3(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("伸娺儼䨾⑀", 0x13));
        this.arrayList_0.Add(A_0);
    }

    public int method_4(string A_0)
    {
        return this.arrayList_0.IndexOf(A_0);
    }

    public void method_5(string A_0)
    {
        this.arrayList_0.Remove(A_0);
    }

    public void method_6(int A_0)
    {
        this.arrayList_0.RemoveAt(A_0);
    }

    public void method_7()
    {
        this.arrayList_0.Clear();
    }

    public Class1033 method_8()
    {
        Class1033 class2 = new Class1033();
        using (IEnumerator enumerator = this.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                string current = (string) enumerator.Current;
                class2.method_3(current);
            }
        }
        return class2;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

