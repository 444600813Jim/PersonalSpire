using Spire.Doc;
using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class909 : IEnumerable
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal int method_0()
    {
        return this.arrayList_0.Count;
    }

    internal Class910 method_1(int A_0)
    {
        return (Class910) this.arrayList_0[A_0];
    }

    internal void method_2(int A_0, Class910 A_1)
    {
        int num = 4;
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尩䴫䈭䔯圱", num));
        }
        this.arrayList_0[A_0] = A_1;
    }

    internal Class910 method_3(string A_0)
    {
        Class910 class3;
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            Class910 current;
            while (enumerator.MoveNext())
            {
                current = (Class910) enumerator.Current;
                if (current.method_0() == A_0)
                {
                    goto Label_0033;
                }
            }
            return null;
        Label_0033:
            class3 = current;
        }
        return class3;
    }

    internal int method_4(Class910 A_0)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈳圵吷伹夻", num));
        }
        return this.arrayList_0.Add(A_0);
    }

    internal void method_5()
    {
        this.arrayList_0.Clear();
    }

    internal void method_6(int A_0)
    {
        this.arrayList_0.RemoveAt(A_0);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.arrayList_0.GetEnumerator();
    }
}

