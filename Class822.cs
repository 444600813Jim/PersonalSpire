using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
internal class Class822 : IDisposable
{
    private Dictionary<int, Class821> dictionary_0 = new Dictionary<int, Class821>();

    public ICollection method_0()
    {
        return this.dictionary_0.Keys;
    }

    public ICollection method_1()
    {
        return this.dictionary_0.Values;
    }

    public Class821 method_2(int A_0)
    {
        return this.dictionary_0[A_0];
    }

    public void method_3(int A_0, Class821 A_1)
    {
        this.dictionary_0[A_0] = A_1;
    }

    public int method_4()
    {
        return this.dictionary_0.Count;
    }

    public void method_5(int A_0, Class821 A_1)
    {
        this.dictionary_0.Add(A_0, A_1);
    }

    public void method_6()
    {
        this.dictionary_0.Clear();
    }

    public bool method_7(int A_0)
    {
        return this.dictionary_0.ContainsKey(A_0);
    }

    public bool method_8(int A_0)
    {
        return this.dictionary_0.Remove(A_0);
    }

    void IDisposable.Dispose()
    {
        if (this.dictionary_0 != null)
        {
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
    }
}

