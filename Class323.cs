using System;
using System.Collections.Generic;

internal class Class323
{
    [ThreadStatic]
    private static Dictionary<int, int> dictionary_0;
    [ThreadStatic]
    private static List<int> list_0;
    [ThreadStatic]
    private static List<int> list_1;
    [ThreadStatic]
    private static Random random_0;

    internal static Random smethod_0()
    {
        if (random_0 == null)
        {
            random_0 = new Random(0x3e8);
        }
        return random_0;
    }

    internal static Dictionary<int, int> smethod_1()
    {
        if (dictionary_0 == null)
        {
            dictionary_0 = new Dictionary<int, int>();
        }
        return dictionary_0;
    }

    internal static List<int> smethod_2()
    {
        if (list_0 == null)
        {
            list_0 = new List<int>();
        }
        return list_0;
    }

    internal static List<int> smethod_3()
    {
        if (list_1 == null)
        {
            list_1 = new List<int>();
        }
        return list_1;
    }

    internal static int smethod_4(int A_0)
    {
        if (smethod_3().Contains(A_0))
        {
            return A_0;
        }
        int num = -1;
        if (!smethod_1().ContainsKey(A_0))
        {
            num = smethod_0().Next();
            smethod_1().Add(A_0, num);
            smethod_2().Add(num);
            return num;
        }
        num = smethod_1()[A_0];
        if (smethod_5(num))
        {
            smethod_2().Add(num);
            return num;
        }
        num = smethod_0().Next();
        smethod_2().Add(num);
        return num;
    }

    private static bool smethod_5(int A_0)
    {
        bool flag = true;
        if ((list_0 != null) && (list_0.Count > 0))
        {
            using (List<int>.Enumerator enumerator = list_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current == A_0)
                    {
                        goto Label_003D;
                    }
                }
                return flag;
            Label_003D:
                flag = false;
            }
        }
        return flag;
    }

    internal static int smethod_6(int A_0, bool A_1)
    {
        if (smethod_3().Contains(A_0))
        {
            return A_0;
        }
        if (smethod_1().ContainsKey(A_0) && !A_1)
        {
            return smethod_1()[A_0];
        }
        int num = smethod_0().Next();
        if (!smethod_1().ContainsKey(A_0))
        {
            smethod_1().Add(A_0, num);
            return num;
        }
        smethod_1()[A_0] = num;
        return num;
    }
}

