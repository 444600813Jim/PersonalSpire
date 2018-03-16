using System;
using System.Collections;
using System.Collections.Generic;

internal class Class1119
{
    private readonly Dictionary<object, int> dictionary_0 = new Dictionary<object, int>();

    internal void method_0()
    {
        this.dictionary_0.Clear();
    }

    internal void method_1(object A_0)
    {
        object obj2 = this.dictionary_0[A_0];
        if (obj2 != null)
        {
            int num = (int) obj2;
            this.dictionary_0[A_0] = ++num;
        }
        else
        {
            this.dictionary_0.Add(A_0, 1);
        }
    }

    internal void method_2(object A_0)
    {
        object obj2 = this.dictionary_0[A_0];
        if (obj2 != null)
        {
            int num = (int) obj2;
            if (num > 0)
            {
                num--;
            }
            if (num == 0)
            {
                this.dictionary_0.Remove(A_0);
            }
            else
            {
                this.dictionary_0[A_0] = num;
            }
        }
    }

    internal bool method_3(object A_0)
    {
        return this.dictionary_0.ContainsKey(A_0);
    }

    internal IEnumerable method_4()
    {
        return this.dictionary_0.Keys;
    }
}

