using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class854 : ArrayList
{
    internal Class108 method_0(string A_0)
    {
        Class108 class3;
        using (IEnumerator enumerator = this.GetEnumerator())
        {
            Class108 current;
            while (enumerator.MoveNext())
            {
                current = (Class108) enumerator.Current;
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
}

