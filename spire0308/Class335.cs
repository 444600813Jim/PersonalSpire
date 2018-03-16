using System;
using System.Collections;

internal class Class335 : Interface34
{
    private readonly IDictionary idictionary_0;

    public Class335()
    {
        this.idictionary_0 = new Hashtable();
    }

    private Class335(IDictionary A_0)
    {
        this.idictionary_0 = A_0;
    }

    public Class335(int A_0)
    {
        this.idictionary_0 = new Hashtable(A_0);
    }

    int Interface34.imethod_0()
    {
        return this.idictionary_0.Count;
    }

    bool Interface34.imethod_1(object A_0)
    {
        object key = Class237.smethod_1(A_0);
        if (this.idictionary_0.Contains(key))
        {
            return false;
        }
        this.idictionary_0.Add(key, A_0);
        return true;
    }

    void Interface34.imethod_2()
    {
        this.idictionary_0.Clear();
    }

    bool Interface34.imethod_3(object A_0)
    {
        return this.idictionary_0.Contains(Class237.smethod_1(A_0));
    }

    bool Interface34.imethod_4(object A_0)
    {
        A_0 = Class237.smethod_1(A_0);
        if (!this.idictionary_0.Contains(A_0))
        {
            return false;
        }
        this.idictionary_0.Remove(A_0);
        return true;
    }

    public static Class335 smethod_0()
    {
        return new Class335(Class83.smethod_0());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.idictionary_0.Values.GetEnumerator();
    }
}

