using System;
using System.Collections;

internal class Class1018 : IComparer
{
    public static readonly IComparer icomparer_0 = new Class1018();

    private Class1018()
    {
    }

    int IComparer.Compare(object A_0, object A_1)
    {
        if (A_0 == A_1)
        {
            return 0;
        }
        if (A_0 == null)
        {
            return -1;
        }
        if (A_1 == null)
        {
            return 1;
        }
        string str = (string) A_0;
        string str2 = (string) A_1;
        int length = str.Length;
        int num6 = str2.Length;
        int num3 = 0;
        for (int i = 0; num3 < length; i++)
        {
            if (i >= num6)
            {
                break;
            }
            int num = str[num3];
            int num2 = str2[i];
            if ((num | num2) <= 0x7f)
            {
                if ((num >= 0x61) && (num <= 0x7a))
                {
                    num ^= 0x20;
                }
                if ((num2 >= 0x61) && (num2 <= 0x7a))
                {
                    num2 ^= 0x20;
                }
                if (num != num2)
                {
                    return (num - num2);
                }
            }
            else if (num != num2)
            {
                num = char.ToUpperInvariant((char) num);
                num2 = char.ToUpperInvariant((char) num2);
                if (num != num2)
                {
                    num = char.ToLowerInvariant((char) num);
                    num2 = char.ToLowerInvariant((char) num2);
                    if (num != num2)
                    {
                        return (num - num2);
                    }
                }
            }
            num3++;
        }
        return (length - num6);
    }
}

