using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class415 : ArrayList
{
    internal Class1100 method_0(string A_0)
    {
        Class1100 class3;
        using (IEnumerator enumerator = this.GetEnumerator())
        {
            Class1100 current;
            while (enumerator.MoveNext())
            {
                current = (Class1100) enumerator.Current;
                if (current.method_0() == A_0)
                {
                    goto Label_002E;
                }
            }
            return null;
        Label_002E:
            class3 = current;
        }
        return class3;
    }

    internal Class977 method_1(string A_0)
    {
        for (int i = 0; i < this.Count; i++)
        {
            Class977 class2 = ((Class1100) base[i]).method_2().method_0(A_0);
            if (class2 != null)
            {
                return class2;
            }
        }
        return null;
    }
}

