using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
internal class Class52 : OwnerHolder, IEnumerable
{
    private Dictionary<string, int> dictionary_0;
    private Dictionary<string, int> dictionary_1;
    private List<Form4> list_0;
    private List<string> list_1;

    public Class52(Document A_0) : base(A_0)
    {
        this.method_15();
    }

    internal string method_10(int A_0)
    {
        int num = 0x10;
        if (this.list_0.Count == 0)
        {
            this.method_11(new Form4(base.Document, BookmarkStart.b("戵儷圹夻䴽怿ు⅃ㅅ桇ᡉ⍋⍍ㅏ㱑", num)));
        }
        if ((A_0 >= 0) && (A_0 < this.list_1.Count))
        {
            return this.list_1[A_0];
        }
        return string.Empty;
    }

    internal int method_11(Form4 A_0)
    {
        int index = 0;
        if (this.method_7(A_0.method_31()))
        {
            index = this.dictionary_0[A_0.method_31()];
            this.list_0[index].method_51(A_0);
        }
        else if (!string.IsNullOrEmpty(A_0.method_31()))
        {
            Form4 item = A_0.method_59();
            this.list_0.Add(item);
            index = this.list_0.IndexOf(item);
            this.dictionary_0[A_0.method_31()] = index;
        }
        this.list_1.Add(A_0.method_31());
        foreach (string str in A_0.method_50())
        {
            if (!this.dictionary_1.ContainsKey(str))
            {
                this.dictionary_1[str] = index;
            }
            if (!base.m_doc.FontSubstitutionTable.ContainsKey(A_0.method_31()))
            {
                base.m_doc.FontSubstitutionTable.Add(A_0.method_31(), str);
            }
            else
            {
                base.m_doc.FontSubstitutionTable[A_0.method_31()] = str;
            }
        }
        return index;
    }

    internal void method_12(Class52 A_0)
    {
        using (IEnumerator enumerator = A_0.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Form4 current = (Form4) enumerator.Current;
                this.method_11(current);
            }
        }
    }

    internal void method_13(Dictionary<string, int> A_0)
    {
        List<string> list = new List<string>();
        List<int> list2 = new List<int>();
        this.method_16(A_0, list, list2);
        this.method_17(list2);
        this.method_18(list);
    }

    internal Class52 method_14()
    {
        Class52 class2 = new Class52(null);
        class2.method_12(this);
        return class2;
    }

    private void method_15()
    {
        this.list_0 = new List<Form4>();
        this.list_1 = new List<string>();
        this.dictionary_0 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        this.dictionary_1 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    }

    private void method_16(Dictionary<string, int> A_0, List<string> A_1, List<int> A_2)
    {
        List<string> list = new List<string>();
        foreach (string str2 in A_0.Keys)
        {
            list.Add(str2);
        }
        list.Sort();
        foreach (string str in list)
        {
            int item = this.dictionary_0.ContainsKey(str) ? this.dictionary_0[str] : (this.dictionary_1.ContainsKey(str) ? this.dictionary_1[str] : -2147483648);
            if ((item != -2147483648) && !A_2.Contains(item))
            {
                A_2.Add(item);
            }
            else
            {
                A_1.Add(str);
            }
        }
    }

    private void method_17(List<int> A_0)
    {
        List<Form4> list = this.list_0;
        this.method_15();
        foreach (int num in A_0)
        {
            this.method_11(list[num]);
        }
    }

    private void method_18(List<string> A_0)
    {
        foreach (string str in A_0)
        {
            this.method_11(new Form4(base.Document, str));
        }
    }

    public int method_4()
    {
        return this.list_0.Count;
    }

    public Form4 method_5(string A_0)
    {
        int num = this.dictionary_0.ContainsKey(A_0) ? this.dictionary_0[A_0] : -2147483648;
        if (num == -2147483648)
        {
            return null;
        }
        return this.method_6(num);
    }

    public Form4 method_6(int A_0)
    {
        return this.list_0[A_0];
    }

    public bool method_7(string A_0)
    {
        return this.dictionary_0.ContainsKey(A_0);
    }

    internal int method_8(string A_0)
    {
        int num = this.dictionary_0.ContainsKey(A_0) ? this.dictionary_0[A_0] : (this.dictionary_1.ContainsKey(A_0) ? this.dictionary_1[A_0] : -2147483648);
        if (num != -2147483648)
        {
            return num;
        }
        return this.method_11(new Form4(base.Document, A_0));
    }

    internal string method_9(int A_0)
    {
        int num = 2;
        if (this.list_0.Count == 0)
        {
            this.method_11(new Form4(base.Document, BookmarkStart.b("簧䌩䄫䬭䌯ሱ稳匵伷ᨹ渻儽ⴿ⍁⩃", num)));
        }
        if ((A_0 < 0) || (A_0 >= this.list_1.Count))
        {
            A_0 = 0;
        }
        return this.list_1[A_0];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.list_0.GetEnumerator();
    }
}

