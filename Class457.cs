using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class457 : IEnumerable
{
    private readonly Class902 class902_0 = new Class902();

    internal Class457()
    {
    }

    public int method_0()
    {
        return this.class902_0.Count;
    }

    public Class901 method_1(string A_0)
    {
        return (Class901) this.class902_0[A_0];
    }

    internal Class457 method_10()
    {
        Class457 class2 = new Class457();
        using (IEnumerator enumerator = this.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                class2.method_3(((Class901) enumerator.Current).method_5());
            }
        }
        return class2;
    }

    public Class901 method_2(int A_0)
    {
        return (Class901) this.class902_0.GetByIndex(A_0);
    }

    public void method_3(Class901 A_0)
    {
        this.class902_0.Add(A_0.method_0(), A_0);
    }

    internal void method_4(Class901 A_0)
    {
        this.class902_0[A_0.method_0()] = A_0;
    }

    public bool method_5(string A_0)
    {
        return this.class902_0.Contains(A_0);
    }

    public int method_6(string A_0)
    {
        return this.class902_0.IndexOfKey(A_0);
    }

    public void method_7(string A_0)
    {
        this.class902_0.Remove(A_0);
    }

    public void method_8(int A_0)
    {
        this.class902_0.RemoveAt(A_0);
    }

    public void method_9()
    {
        this.class902_0.Clear();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.class902_0.GetValueList().GetEnumerator();
    }
}

