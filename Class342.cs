using System;
using System.Collections;
using System.IO;

internal class Class342 : Class341
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    internal string method_5(int A_0)
    {
        string str;
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            Class539 current;
            while (enumerator.MoveNext())
            {
                current = (Class539) enumerator.Current;
                if (current.int_1 == A_0)
                {
                    goto Label_0030;
                }
            }
            return "";
        Label_0030:
            str = current.string_0;
        }
        return str;
    }

    internal int method_6(int A_0, string A_1)
    {
        Class539 class2 = new Class539();
        int count = this.arrayList_0.Count;
        class2.int_1 = A_0 | (count << 4);
        class2.int_2 = 0xff;
        class2.string_0 = A_1;
        this.arrayList_0.Add(class2);
        return class2.int_1;
    }

    protected override void vmethod_0(string A_0, BinaryReader A_1)
    {
        Class539 class2 = new Class539(A_0, A_1);
        this.arrayList_0.Add(class2);
    }

    protected override int vmethod_1()
    {
        return this.arrayList_0.Count;
    }

    protected override int vmethod_2()
    {
        return 8;
    }

    protected override void vmethod_3(BinaryWriter A_0)
    {
        foreach (Class539 class2 in this.arrayList_0)
        {
            Class341.smethod_0(class2.string_0, A_0);
            class2.method_0(A_0);
        }
    }
}

