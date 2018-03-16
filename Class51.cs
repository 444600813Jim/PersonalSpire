using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class51 : OwnerHolder
{
    private bool bool_0;
    private Borders borders_0;
    private Class49 class49_0;
    private Document document_0;
    private int int_1;
    private int int_2;
    private MarginsF marginsF_0;

    public Class51(Document A_0) : base(A_0, A_0)
    {
    }

    internal void method_10(int A_0)
    {
        this.int_2 = A_0;
    }

    internal bool method_11()
    {
        return this.bool_0;
    }

    internal void method_12(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal Class49 method_13()
    {
        if (this.class49_0 == null)
        {
            this.class49_0 = new Class49(this.document_0);
        }
        return this.class49_0;
    }

    internal Document method_4()
    {
        return this.document_0;
    }

    internal MarginsF method_5()
    {
        if (this.marginsF_0 == null)
        {
            this.marginsF_0 = new MarginsF();
        }
        return this.marginsF_0;
    }

    internal Borders method_6()
    {
        if (this.borders_0 == null)
        {
            this.borders_0 = new Borders();
        }
        return this.borders_0;
    }

    internal int method_7()
    {
        return this.int_1;
    }

    internal void method_8(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_9()
    {
        return this.int_2;
    }
}

