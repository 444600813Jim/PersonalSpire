using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class Class247 : ArrayList
{
    internal Class977 method_0(string A_0)
    {
        Class977 class3;
        using (IEnumerator enumerator = this.GetEnumerator())
        {
            Class977 current;
            while (enumerator.MoveNext())
            {
                current = (Class977) enumerator.Current;
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

