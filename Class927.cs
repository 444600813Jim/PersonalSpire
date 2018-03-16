using System;
using System.Collections;

internal class Class927 : IComparer
{
    public Class927 class927_0 = new Class927();

    int IComparer.Compare(object A_0, object A_1)
    {
        if ((((float) A_0) - ((float) A_1)) < 0.0001f)
        {
            return 0;
        }
        if (((float) A_0) > ((float) A_1))
        {
            return 1;
        }
        return -1;
    }
}

