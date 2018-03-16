using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;

internal class Class13 : Style, Interface8
{
    private Dictionary<ConditionalFormattingCode, Class10> dictionary_2;
    private Form1 form1_0;
    private Form2 form2_0;
    private Form3 form3_0;
    private ListFormat listFormat_0;

    internal Class13(IDocument A_0) : base((Document) A_0)
    {
        this.dictionary_2 = new Dictionary<ConditionalFormattingCode, Class10>();
        base.m_ParaPr = new ParagraphFormat(base.Document);
        base.m_ParaPr.method_0(this);
        this.form3_0 = new Form3(base.Document);
        this.form3_0.method_0(this);
        this.form1_0 = new Form1(base.Document);
        this.form1_0.method_0(this);
        this.form2_0 = new Form2(base.Document);
        this.form2_0.method_0(this);
    }

    public ParagraphFormat imethod_0()
    {
        return base.m_ParaPr;
    }

    Form3 Interface8.imethod_1()
    {
        return this.form3_0;
    }

    Form1 Interface8.imethod_2()
    {
        return this.form1_0;
    }

    Form2 Interface8.imethod_3()
    {
        return this.form2_0;
    }

    public ListFormat method_23()
    {
        if (this.listFormat_0 == null)
        {
            this.listFormat_0 = new ListFormat(base.Document, this);
        }
        return this.listFormat_0;
    }

    internal Class13 method_24()
    {
        return (base.BaseStyle as Class13);
    }

    internal Dictionary<ConditionalFormattingCode, Class10> method_25()
    {
        return this.dictionary_2;
    }

    internal Class10 method_26(ConditionalFormattingCode A_0)
    {
        Class10 class2 = new Class10(A_0, base.Document);
        this.dictionary_2.Add(A_0, class2);
        return class2;
    }

    internal WordAttrCollection method_27(ConditionalFormattingCode A_0, TableStylePrType A_1)
    {
        int num = 6;
        Class10 class2 = this.method_28(A_0);
        switch (A_1)
        {
            case TableStylePrType.Run:
                return class2.RunPr;

            case TableStylePrType.Para:
                return class2.ParaPr;

            case TableStylePrType.Cell:
                return class2.method_24();
        }
        throw new InvalidOperationException(BookmarkStart.b("礫䀭嬯就嬳䄵嘷ᨹ䰻䰽ᐿ㭁㑃⍅桇㱉ⵋ≍╏㝑穓", num));
    }

    private Class10 method_28(ConditionalFormattingCode A_0)
    {
        Class10 class2 = this.method_29(A_0);
        if (class2 == null)
        {
            class2 = new Class10(A_0, base.Document);
            this.dictionary_2.Add(A_0, class2);
        }
        return class2;
    }

    internal Class10 method_29(ConditionalFormattingCode A_0)
    {
        if (this.dictionary_2.ContainsKey(A_0))
        {
            return this.dictionary_2[A_0];
        }
        return null;
    }

    void Style.ApplyBaseStyle(string A_0)
    {
        base.ApplyBaseStyle(A_0);
        if (this.method_24() != null)
        {
            base.m_ParaPr.ApplyBase(this.method_24().imethod_0());
            this.form3_0.ApplyBase(this.method_24().Interface8.imethod_1());
            this.form1_0.ApplyBase(this.method_24().Interface8.imethod_2());
            this.form2_0.ApplyBase(this.method_24().Interface8.imethod_3());
        }
    }

    object Style.CloneImpl()
    {
        Class13 class2 = (Class13) base.CloneImpl();
        class2.m_ParaPr = new ParagraphFormat(base.Document);
        class2.m_ParaPr.ImportContainer(this.imethod_0());
        class2.m_ParaPr.method_21(this.imethod_0());
        class2.m_ParaPr.method_0(class2);
        class2.form3_0 = new Form3(base.Document);
        class2.form3_0.ImportContainer(this.Interface8.imethod_1());
        class2.form3_0.method_0(this);
        class2.form1_0 = new Form1(base.Document);
        class2.form1_0.ImportContainer(this.Interface8.imethod_2());
        class2.form1_0.method_0(this);
        class2.form2_0 = new Form2(base.Document);
        class2.form2_0.ImportContainer(this.Interface8.imethod_3());
        class2.form2_0.method_0(this);
        if ((this.dictionary_2 != null) && (this.dictionary_2.Count > 0))
        {
            foreach (KeyValuePair<ConditionalFormattingCode, Class10> pair in this.dictionary_2)
            {
                if (pair.Value != null)
                {
                    Class10 class3 = (Class10) pair.Value.Clone();
                    if (!class2.dictionary_2.ContainsKey(pair.Key))
                    {
                        class2.dictionary_2.Add(pair.Key, class3);
                    }
                }
            }
        }
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
        if (this.listFormat_0 != null)
        {
            this.listFormat_0.Close();
            this.listFormat_0 = null;
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
        if (this.dictionary_2 != null)
        {
            foreach (KeyValuePair<ConditionalFormattingCode, Class10> pair in this.dictionary_2)
            {
                if (pair.Value != null)
                {
                    pair.Value.Close();
                }
            }
            this.dictionary_2.Clear();
            this.dictionary_2 = null;
        }
    }

    public override IStyle Spire.Doc.Interface.IStyle.Clone()
    {
        return (Class13) this.CloneImpl();
    }

    ParagraphFormat Style.ParaPr
    {
        get
        {
            return base.m_ParaPr;
        }
    }

    CharacterFormat Style.RunPr
    {
        get
        {
            return base.m_chFormat;
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

