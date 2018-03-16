using System;
using System.Collections;

internal class Class740 : Interface34
{
    private readonly SortedList sortedList_0;

    public Class740()
    {
        this.sortedList_0 = new SortedList();
    }

    private Class740(SortedList A_0)
    {
        this.sortedList_0 = A_0;
    }

    int Interface34.imethod_0()
    {
        return this.sortedList_0.Count;
    }

    bool Interface34.imethod_1(object A_0)
    {
        object key = Class237.smethod_1(A_0);
        if (this.sortedList_0.Contains(key))
        {
            return false;
        }
        this.sortedList_0.Add(key, A_0);
        return true;
    }

    void Interface34.imethod_2()
    {
        this.sortedList_0.Clear();
    }

    bool Interface34.imethod_3(object A_0)
    {
        return this.sortedList_0.Contains(Class237.smethod_1(A_0));
    }

    bool Interface34.imethod_4(object A_0)
    {
        A_0 = Class237.smethod_1(A_0);
        if (!this.sortedList_0.Contains(A_0))
        {
            return false;
        }
        this.sortedList_0.Remove(A_0);
        return true;
    }

    public static Class740 smethod_0()
    {
        return new Class740(new SortedList(Class182.icomparer_0));
    }

    public static Class740 smethod_1()
    {
        return new Class740(new SortedList(Class183.icomparer_0));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.sortedList_0.GetValueList().GetEnumerator();
    }
}

