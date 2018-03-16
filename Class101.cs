using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class101 : Class96
{
    private ArrayList arrayList_0 = new ArrayList();
    private bool bool_0 = false;
    internal Hashtable hashtable_0 = new Hashtable();
    private ListStyle listStyle_0;
    private string string_6;

    internal Class101()
    {
        for (int i = 0; i < 9; i++)
        {
            this.arrayList_0.Add(null);
        }
    }

    internal ListStyle method_21()
    {
        return this.listStyle_0;
    }

    internal void method_22(ListStyle A_0)
    {
        this.listStyle_0 = A_0;
    }

    internal ArrayList method_23()
    {
        return this.arrayList_0;
    }

    internal void method_24(ArrayList A_0)
    {
        this.arrayList_0 = A_0;
    }

    internal bool method_25()
    {
        return this.bool_0;
    }

    internal void method_26(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal string method_27()
    {
        return this.string_6;
    }

    internal void method_28(string A_0)
    {
        this.string_6 = A_0;
    }
}

