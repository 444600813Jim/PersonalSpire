using System;
using System.Collections;

internal class Class1134 : IComparer
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    public static readonly IComparer icomparer_0 = new Class1134();
    private static readonly int[] int_0 = new int[] { 
        0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 40, 0x29, 0x2a, 0x2c, 0x2e, 0x2f, 0x3a, 0x3b, 0x3f, 0x40, 
        0x5b, 0x5c, 0x27, 0x2d, 0x5d, 0x5e, 0x5f, 0x60, 0x7b, 0x7c, 0x7d, 0x7e, 0x2b, 60, 0x3d, 0x3e
     };

    static Class1134()
    {
        foreach (int num2 in int_0)
        {
            hashtable_0.Add(num2, hashtable_0.Count);
        }
    }

    private Class1134()
    {
    }

    private static int smethod_0(char A_0)
    {
        if (char.IsLetterOrDigit(A_0))
        {
            return ((char.ToLower(A_0) - '0') + hashtable_0.Count);
        }
        object obj2 = hashtable_0[(int) A_0];
        if (obj2 != null)
        {
            return (int) obj2;
        }
        return 0;
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
        int num2 = str2.Length;
        int num3 = 0;
        for (int i = 0; num3 < length; i++)
        {
            if (i >= num2)
            {
                break;
            }
            int num5 = smethod_0(str[num3]);
            int num6 = smethod_0(str2[i]);
            if (num5 != num6)
            {
                return (num5 - num6);
            }
            num3++;
        }
        return (length - num2);
    }
}

