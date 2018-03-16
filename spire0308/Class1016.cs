using System;
using System.Collections;

internal class Class1016 : SortedList
{
    public Class1016() : this(true)
    {
    }

    public Class1016(bool A_0) : base(A_0 ? Class1017.icomparer_0 : Class1018.icomparer_0)
    {
    }
}

