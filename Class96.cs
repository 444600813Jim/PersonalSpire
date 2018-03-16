using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;

internal class Class96 : Class93
{
    private CharacterFormat characterFormat_0;
    private double double_0 = 0.0;
    private ParagraphFormat paragraphFormat_0 = new ParagraphFormat();
    private TextOrientation textOrientation_0;

    internal Class96()
    {
    }

    internal CharacterFormat method_12(Class97 A_0)
    {
        CharacterFormat format = null;
        if ((A_0 != null) && (A_0.method_13() != null))
        {
            format = (CharacterFormat) A_0.method_13().Clone();
        }
        if (this.characterFormat_0 != null)
        {
            if (format == null)
            {
                format = (CharacterFormat) this.characterFormat_0.Clone();
            }
            else
            {
                this.characterFormat_0.method_37(format);
            }
        }
        if (format == null)
        {
            format = new CharacterFormat();
        }
        return format;
    }

    internal CharacterFormat method_13()
    {
        return this.characterFormat_0;
    }

    internal void method_14(CharacterFormat A_0)
    {
        this.characterFormat_0 = A_0;
    }

    internal ParagraphFormat method_15()
    {
        return this.paragraphFormat_0;
    }

    internal void method_16(ParagraphFormat A_0)
    {
        this.paragraphFormat_0 = A_0;
    }

    internal double method_17()
    {
        return this.double_0;
    }

    internal void method_18(double A_0)
    {
        this.double_0 = A_0;
    }

    internal TextOrientation method_19()
    {
        return this.textOrientation_0;
    }

    internal void method_20(TextOrientation A_0)
    {
        this.textOrientation_0 = A_0;
    }
}

