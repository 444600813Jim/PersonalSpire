using System;
using System.Collections.Generic;

internal class Class200 : List<Class199>
{
    private Class199 method_0(Class199 A_0)
    {
        Class199 class3;
        if ((A_0 == null) || (base.Count <= 0))
        {
            return null;
        }
        using (List<Class199>.Enumerator enumerator = base.GetEnumerator())
        {
            Class199 current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (((current.method_2() != null) && (A_0.method_2() != null)) && (current.method_2().method_73() == A_0.method_2().method_73()))
                {
                    goto Label_0053;
                }
            }
            return null;
        Label_0053:
            class3 = current;
        }
        return class3;
    }

    public void method_1()
    {
        if (base.Count != 0)
        {
            for (int i = base.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    Class199 class2 = base[i];
                    Class199 class3 = base[j];
                    if (class2.System.IComparable.CompareTo(class3) < 0)
                    {
                        this.method_2(ref class2, ref class3);
                        base[i] = class2;
                        base[j] = class3;
                    }
                }
            }
        }
    }

    public void method_2(ref Class199 A_0, ref Class199 A_1)
    {
        Class199 class2 = A_0;
        A_0 = A_1;
        A_1 = class2;
    }
}

