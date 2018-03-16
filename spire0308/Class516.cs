using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class516
{
    private Dictionary<string, int> dictionary_0;
    private Document document_0;
    private List<DocumentObject> list_0;
    private List<DocumentObject> list_1;
    private List<Field> list_2;

    public Class516(Document A_0)
    {
        this.document_0 = A_0;
    }

    internal List<DocumentObject> method_0()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<DocumentObject>();
        }
        return this.list_0;
    }

    internal List<DocumentObject> method_1()
    {
        if (this.list_1 == null)
        {
            this.list_1 = new List<DocumentObject>();
        }
        return this.list_1;
    }

    internal Dictionary<string, int> method_2()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, int>();
        }
        return this.dictionary_0;
    }

    internal List<Field> method_3()
    {
        if (this.list_2 == null)
        {
            this.list_2 = new List<Field>();
        }
        return this.list_2;
    }

    internal void method_4()
    {
        this.dictionary_0 = null;
        this.list_1 = null;
        this.list_0 = null;
        this.list_2 = null;
        if (this.document_0 != null)
        {
            for (int i = 0; i < this.document_0.Fields.Count; i++)
            {
                this.document_0.Fields[i].bool_28 = false;
                this.document_0.Fields[i].bool_29 = false;
            }
        }
        this.document_0 = null;
    }
}

