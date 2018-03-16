using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

internal sealed class Class665
{
    public static int[] smethod_0(int[] A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int length = A_0.Length;
        int[] numArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            numArray[i] = A_0[i];
        }
        return numArray;
    }

    public static ushort[] smethod_1(ushort[] A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int length = A_0.Length;
        ushort[] numArray = new ushort[length];
        for (int i = 0; i < length; i++)
        {
            numArray[i] = A_0[i];
        }
        return numArray;
    }

    public static string[] smethod_2(string[] A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int length = A_0.Length;
        string[] strArray = new string[length];
        for (int i = 0; i < length; i++)
        {
            strArray[i] = A_0[i];
        }
        return strArray;
    }

    public static object[] smethod_3(object[] A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int length = A_0.Length;
        object[] objArray = new object[length];
        for (int i = 0; i < length; i++)
        {
            object obj2 = A_0[i];
            ICloneable cloneable = obj2 as ICloneable;
            if (cloneable != null)
            {
                obj2 = cloneable.Clone();
            }
            objArray[i] = obj2;
        }
        return objArray;
    }

    public static object smethod_4(ICloneable A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        return A_0.Clone();
    }

    public static SortedList<int, int> smethod_5(SortedList<int, int> A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int count = A_0.Count;
        SortedList<int, int> list = new SortedList<int, int>(count);
        IList<int> keys = A_0.Keys;
        IList<int> values = A_0.Values;
        for (int i = 0; i < count; i++)
        {
            list.Add(keys[i], values[i]);
        }
        return list;
    }

    public static byte[] smethod_6(byte[] A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int length = A_0.Length;
        byte[] buffer = new byte[length];
        for (int i = 0; i < length; i++)
        {
            buffer[i] = A_0[i];
        }
        return buffer;
    }

    public static Dictionary<T, U> smethod_7<T, U>(Dictionary<T, U> A_0)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀧䬩弫䘭", num));
        }
        Dictionary<T, U> dictionary = new Dictionary<T, U>(A_0.Count);
        foreach (KeyValuePair<T, U> pair in A_0)
        {
            U local = pair.Value;
            ICloneable cloneable = local as ICloneable;
            if (cloneable != null)
            {
                local = (U) cloneable.Clone();
            }
            T key = pair.Key;
            cloneable = key as ICloneable;
            if (cloneable != null)
            {
                key = (T) cloneable.Clone();
            }
            dictionary.Add(key, local);
        }
        return dictionary;
    }

    public static Dictionary<int, int> smethod_8(Dictionary<int, int> A_0)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀧䬩弫䘭", num));
        }
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        foreach (KeyValuePair<int, int> pair in A_0)
        {
            dictionary.Add(pair.Key, pair.Value);
        }
        return dictionary;
    }

    public static Stream smethod_9(Stream A_0)
    {
        return Class814.smethod_0(A_0);
    }
}

