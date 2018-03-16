using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class89
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly ArrayList arrayList_1 = new ArrayList();
    private readonly ArrayList arrayList_2 = new ArrayList();

    internal Class89()
    {
    }

    internal void method_0()
    {
        this.arrayList_0.Clear();
        this.arrayList_1.Clear();
        this.arrayList_2.Clear();
    }

    internal int method_1(Class91 A_0, bool A_1, bool A_2)
    {
        if (!A_2)
        {
            return this.arrayList_2.Add(A_0);
        }
        if (A_1)
        {
            return this.arrayList_1.Add(A_0);
        }
        return this.arrayList_0.Add(A_0);
    }

    internal int method_10()
    {
        return this.arrayList_0.Count;
    }

    internal Class91 method_2(string A_0, string A_1, bool A_2, bool A_3)
    {
        if (!A_3)
        {
            return smethod_1(this.arrayList_2, A_0, A_1);
        }
        if (A_2)
        {
            Class91 class2 = smethod_1(this.arrayList_1, A_0, A_1);
            if (class2 != null)
            {
                return class2;
            }
        }
        return smethod_1(this.arrayList_0, A_0, A_1);
    }

    internal Class91 method_3(string A_0, string A_1, bool A_2)
    {
        Class91 class2 = this.method_2(A_0, A_1, A_2, true);
        if (class2 == null)
        {
            return smethod_1(this.arrayList_2, A_0, A_1);
        }
        return class2;
    }

    internal Class91 method_4(string A_0, string A_1)
    {
        if (A_0 == null)
        {
            return smethod_0(this.arrayList_2, A_1);
        }
        Class91 class2 = smethod_1(this.arrayList_2, A_0, A_1);
        if (class2 == null)
        {
            class2 = smethod_1(this.arrayList_0, A_0, A_1);
        }
        if (class2 == null)
        {
            class2 = smethod_1(this.arrayList_1, A_0, A_1);
        }
        return class2;
    }

    internal Class91 method_5(int A_0)
    {
        return (Class91) this.arrayList_2[A_0];
    }

    internal Class91 method_6(int A_0)
    {
        return (Class91) this.arrayList_0[A_0];
    }

    internal Class91 method_7(int A_0)
    {
        return (Class91) this.arrayList_1[A_0];
    }

    internal int method_8()
    {
        return this.arrayList_2.Count;
    }

    internal int method_9()
    {
        return this.arrayList_1.Count;
    }

    private static Class91 smethod_0(ArrayList A_0, string A_1)
    {
        Class91 class3;
        using (IEnumerator enumerator = A_0.GetEnumerator())
        {
            Class91 current;
            while (enumerator.MoveNext())
            {
                current = (Class91) enumerator.Current;
                if (((current is Class93) && ((current as Class93).method_4() == A_1)) && !Class567.smethod_16((current as Class93).method_0()))
                {
                    goto Label_004D;
                }
            }
            return null;
        Label_004D:
            class3 = current;
        }
        return class3;
    }

    private static Class91 smethod_1(ArrayList A_0, string A_1, string A_2)
    {
        if (A_2 == null)
        {
            foreach (Class91 class4 in A_0)
            {
                if ((A_1 != null) && (class4.method_0() == A_1))
                {
                    return class4;
                }
            }
        }
        else
        {
            foreach (Class91 class2 in A_0)
            {
                if (((class2 is Class93) && (A_1 != null)) && ((class2.method_0() == A_1) && ((class2 as Class93).method_4() == A_2)))
                {
                    return class2;
                }
            }
        }
        return null;
    }
}

