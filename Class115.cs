using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class115 : ArrayList
{
    internal void method_0(Interface58 A_0)
    {
        foreach (Class801 class2 in this)
        {
            Style style = class2.istyle_0 as Style;
            if (class2.object_0 != null)
            {
                style.BasedOnIstd = A_0.imethod_0(class2.object_0, 0xfff);
            }
            if (class2.object_1 != null)
            {
                style.NextIstd = A_0.imethod_0(class2.object_1, style.Istd);
            }
            if (class2.object_2 != null)
            {
                style.LinkedIstd = A_0.imethod_0(class2.object_2, 0xfff);
            }
        }
    }
}

