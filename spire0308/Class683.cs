using Spire.Doc.Documents;
using System;

internal class Class683
{
    private HorizontalAlignment horizontalAlignment_0 = HorizontalAlignment.Center;

    internal Class683 method_0()
    {
        return (Class683) base.MemberwiseClone();
    }

    internal HorizontalAlignment method_1()
    {
        return this.horizontalAlignment_0;
    }

    internal void method_2(HorizontalAlignment A_0)
    {
        switch (A_0)
        {
            case HorizontalAlignment.Left:
            case HorizontalAlignment.Center:
            case HorizontalAlignment.Right:
                this.horizontalAlignment_0 = A_0;
                return;
        }
        this.horizontalAlignment_0 = HorizontalAlignment.Center;
    }
}

