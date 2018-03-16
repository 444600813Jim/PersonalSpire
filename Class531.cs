using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;

internal class Class531
{
    private Class531()
    {
    }

    internal static bool smethod_0(Document A_0, RowFormat A_1, int A_2)
    {
        for (Class13 class2 = (Class13) A_0.Styles.method_13(A_1.Istd, false); class2 != null; class2 = class2.method_24())
        {
            if (class2.Interface8.imethod_2().HasKey(A_2))
            {
                return true;
            }
            if (class2.Interface8.imethod_3().HasKey(A_2))
            {
                return true;
            }
        }
        return false;
    }

    internal static int smethod_1(TableStyleOptions A_0)
    {
        return (((int) A_0) ^ 0x600);
    }

    internal static TableStyleOptions smethod_2(int A_0)
    {
        return (((TableStyleOptions) A_0) ^ TableStyleOptions.Default2003);
    }
}

