using System;
using System.Collections;
using System.Collections.Generic;

internal class Class1002 : IComparer<string>, IComparer
{
    int IComparer<string>.Compare(string A_0, string A_1)
    {
        if ((A_0 == null) && (A_1 == null))
        {
            return 0;
        }
        if (A_1 == null)
        {
            return 1;
        }
        if (A_0 == null)
        {
            return -1;
        }
        int length = A_0.Length;
        int num2 = A_1.Length;
        int num3 = length - num2;
        if (num3 == 0)
        {
            num3 = StringComparer.Ordinal.Compare(A_0.ToUpper(), A_1.ToUpper());
        }
        return num3;
    }

    int IComparer.Compare(object A_0, object A_1)
    {
        if ((A_0 == null) && (A_1 == null))
        {
            return 0;
        }
        if (A_1 == null)
        {
            return 1;
        }
        if (A_0 == null)
        {
            return -1;
        }
        string x = A_0.ToString();
        string y = A_1.ToString();
        int length = x.Length;
        int num2 = y.Length;
        int num3 = length - num2;
        if (num3 == 0)
        {
            num3 = StringComparer.Ordinal.Compare(x, y);
        }
        return num3;
    }
}

