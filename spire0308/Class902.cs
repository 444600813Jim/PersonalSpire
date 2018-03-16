using System;
using System.Collections;

internal class Class902 : SortedList
{
    public Class902() : this(true)
    {
    }

    public Class902(bool A_0) : base(A_0 ? Class903.icomparer_0 : Class904.icomparer_0)
    {
    }
}

