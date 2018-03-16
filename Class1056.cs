using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;

internal class Class1056
{
    private readonly bool bool_0;
    private readonly int int_0;
    private readonly int int_1;

    internal Class1056(Document A_0, Table A_1)
    {
        this.bool_0 = false;
        if ((A_0.DetectedFormatType != FileFormat.Doc) && (A_0.DetectedFormatType != FileFormat.Dot))
        {
            this.bool_0 = true;
        }
        else
        {
            RowFormat rowFormat = A_1.Rows[0].RowFormat;
            Class13 class2 = A_0.Styles.method_13(rowFormat.Istd, false) as Class13;
            if (class2 != null)
            {
                this.bool_0 |= Class1149.smethod_2(class2);
            }
            TableStyleOptions tableOption = rowFormat.TableOption;
            this.bool_0 |= ((tableOption & TableStyleOptions.RowBands) == TableStyleOptions.None) || ((tableOption & TableStyleOptions.ColumnBands) == TableStyleOptions.None);
        }
        this.int_1 = 0;
    }

    internal Class1056(int A_0, int A_1, bool A_2)
    {
        this.int_0 = A_0;
        this.int_1 = A_1;
        this.bool_0 = A_2;
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal int method_1()
    {
        return this.int_1;
    }

    internal bool method_2()
    {
        return this.bool_0;
    }
}

