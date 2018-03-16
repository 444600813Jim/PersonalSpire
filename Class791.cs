using Spire.Doc;
using System;
using System.Collections;

internal class Class791
{
    private Class791()
    {
    }

    public static void smethod_0(object[] A_0, IDictionary A_1, IDictionary A_2)
    {
        smethod_2(A_0, A_1, A_2, false);
    }

    public static void smethod_1(object[] A_0, IDictionary A_1, IDictionary A_2)
    {
        smethod_2(A_0, A_1, A_2, true);
    }

    private static void smethod_2(object[] A_0, IDictionary A_1, IDictionary A_2, bool A_3)
    {
        int num = A_0.Length / 2;
        for (int i = 0; i < num; i++)
        {
            try
            {
                object key = A_0[i * 2];
                if (A_3 && (key is string))
                {
                    key = ((string) key).ToLower();
                }
                A_1.Add(key, A_0[(i * 2) + 1]);
                if (A_2 != null)
                {
                    A_2.Add(A_0[(i * 2) + 1], A_0[i * 2]);
                }
            }
            catch
            {
            }
        }
    }

    public static object smethod_3(IDictionary A_0, object A_1, object A_2)
    {
        int num = 9;
        if (A_1 != null)
        {
            object obj2 = A_0[A_1];
            if (obj2 != null)
            {
                return obj2;
            }
        }
        if (A_2 == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("氮倰崲嬴堶䴸ᬺ帼倾⽀㕂⁄㕆㵈歊橌㑎慐⹒牔祖", num), A_1));
        }
        return A_2;
    }

    public static object smethod_4(IDictionary A_0, string A_1, object A_2)
    {
        return smethod_3(A_0, A_1.ToLower(), A_2);
    }

    public static object smethod_5(IDictionary A_0, object A_1)
    {
        return smethod_3(A_0, A_1, null);
    }

    public static object smethod_6(IDictionary A_0, object A_1)
    {
        if (A_1 == null)
        {
            return null;
        }
        return A_0[A_1];
    }
}

