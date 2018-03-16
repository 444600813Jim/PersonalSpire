using System;
using System.Collections;

internal class Class689 : IComparer
{
    int IComparer.Compare(object A_0, object A_1)
    {
        string str = (string) A_0;
        string str2 = (string) A_1;
        int num = str.Length.CompareTo(str2.Length);
        if (num == 0)
        {
            return string.CompareOrdinal(str.ToUpper(), str2.ToUpper());
        }
        return num;
    }
}

