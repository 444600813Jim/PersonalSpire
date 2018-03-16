using System;
using System.Collections;

internal class Class1017 : IComparer
{
    public static readonly IComparer icomparer_0 = new Class1017();

    private Class1017()
    {
    }

    int IComparer.Compare(object A_0, object A_1)
    {
        return string.CompareOrdinal((string) A_0, (string) A_1);
    }
}

