using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class796 : ArrayList
{
    internal Class94 method_0(string A_0)
    {
        Class94 class3;
        using (IEnumerator enumerator = this.GetEnumerator())
        {
            Class94 current;
            while (enumerator.MoveNext())
            {
                current = (Class94) enumerator.Current;
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

    public Class94 method_1(int A_0)
    {
        return (Class94) base[A_0];
    }
}

