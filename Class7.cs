using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;

internal class Class7 : Table, IParagraphBase
{
    private TextBox textBox_0;

    public Class7(TextBox A_0) : base(A_0.Document)
    {
        this.textBox_0 = A_0;
    }

    void IParagraphBase.ApplyStyle(string A_0)
    {
    }

    void Table.CreateLayoutInfo()
    {
        base.CreateLayoutInfo();
        if (this.IsTextBox)
        {
            if (this.TextBoxFormat.TextWrappingStyle != TextWrappingStyle.Inline)
            {
                base.interface23_0.imethod_13(true);
            }
            switch (this.TextBoxFormat.TextWrappingStyle)
            {
                case TextWrappingStyle.Inline:
                    base.interface23_0.imethod_15(true);
                    return;

                case TextWrappingStyle.InFrontOfText:
                case TextWrappingStyle.Behind:
                    base.interface23_0.imethod_21(true);
                    base.interface23_0.imethod_17(false);
                    return;
            }
            base.interface23_0.imethod_19(true);
            base.interface23_0.imethod_17(false);
        }
    }

    void Table.ResetLayoutInfo()
    {
        base.ResetLayoutInfo();
        this.textBox_0.interface23_0 = null;
        this.textBox_0.table_0 = null;
    }

    Paragraph IParagraphBase.OwnerParagraph
    {
        get
        {
            return this.textBox_0.OwnerParagraph;
        }
    }

    string IParagraphBase.StyleName
    {
        get
        {
            return string.Empty;
        }
    }

    bool Table.IsTextBox
    {
        get
        {
            return true;
        }
    }

    ITextBox Table.TextBox
    {
        get
        {
            return this.textBox_0;
        }
    }

    TextBoxFormat Table.TextBoxFormat
    {
        get
        {
            return this.textBox_0.Format;
        }
    }
}

