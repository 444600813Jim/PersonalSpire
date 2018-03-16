using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;

internal class Class10 : Style
{
    private ConditionalFormattingCode conditionalFormattingCode_0;
    private Form1 form1_0;
    private Form2 form2_0;
    private Form3 form3_0;

    internal Class10(ConditionalFormattingCode A_0, IDocument A_1) : base((Document) A_1)
    {
        this.conditionalFormattingCode_0 = A_0;
        base.m_ParaPr = new ParagraphFormat(base.Document);
        base.m_ParaPr.method_0(this);
        this.form3_0 = new Form3(base.Document);
        this.form3_0.method_0(this);
        this.form1_0 = new Form1(base.Document);
        this.form1_0.method_0(this);
        this.form2_0 = new Form2(base.Document);
        this.form2_0.method_0(this);
    }

    internal ParagraphFormat method_23()
    {
        return base.m_ParaPr;
    }

    internal Form3 method_24()
    {
        return this.form3_0;
    }

    internal Form1 method_25()
    {
        return this.form1_0;
    }

    internal Form2 method_26()
    {
        return this.form2_0;
    }

    internal ConditionalFormattingCode method_27()
    {
        return this.conditionalFormattingCode_0;
    }

    public override IStyle Spire.Doc.Documents.Style.Clone()
    {
        return (Class10) this.CloneImpl();
    }

    object Style.CloneImpl()
    {
        Class10 class2 = (Class10) base.CloneImpl();
        class2.m_ParaPr = new ParagraphFormat(base.Document);
        class2.m_ParaPr.ImportContainer(this.method_23());
        class2.m_ParaPr.method_0(class2);
        class2.form3_0 = new Form3(base.Document);
        class2.form3_0.ImportContainer(this.method_24());
        class2.form3_0.method_0(this);
        class2.form1_0 = new Form1(base.Document);
        class2.form1_0.ImportContainer(this.method_25());
        class2.form1_0.method_0(this);
        class2.form2_0 = new Form2(base.Document);
        class2.form2_0.ImportContainer(this.method_26());
        class2.form2_0.method_0(this);
        return class2;
    }

    void Style.Close()
    {
        base.Close();
        if (base.m_ParaPr != null)
        {
            base.m_ParaPr.Close();
            base.m_ParaPr = null;
        }
        if (this.form3_0 != null)
        {
            this.form3_0.Close();
            this.form3_0 = null;
        }
        if (this.form1_0 != null)
        {
            this.form1_0.Close();
            this.form1_0 = null;
        }
        if (this.form2_0 != null)
        {
            this.form2_0.Close();
            this.form2_0 = null;
        }
    }

    ParagraphFormat Style.ParaPr
    {
        get
        {
            return base.m_ParaPr;
        }
    }

    public override StyleType Spire.Doc.Interface.IStyle.StyleType
    {
        get
        {
            return StyleType.TableStyle;
        }
    }
}

