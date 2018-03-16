using Spire.Doc.Fields.Shape;
using System;
using System.Collections;

internal class Class823 : IComparer
{
    int IComparer.Compare(object A_0, object A_1)
    {
        ShapeBase base2 = (ShapeBase) A_0;
        ShapeBase base3 = (ShapeBase) A_1;
        int num2 = base2.ZOrder.CompareTo(base3.ZOrder);
        if (num2 == 0)
        {
            num2 = base2.Id.CompareTo(base3.Id);
        }
        return num2;
    }
}

