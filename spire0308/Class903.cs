using System;
using System.Collections;

internal class Class903 : IComparer
{
    public static readonly IComparer icomparer_0 = new Class903();

    private Class903()
    {
    }

    int IComparer.Compare(object A_0, object A_1)
    {
        return string.CompareOrdinal((string) A_0, (string) A_1);
    }
}

