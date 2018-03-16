using Spire.Doc.Documents;
using System;

internal class Class311
{
    private TextWrappingStyle textWrappingStyle_0;
    private TextWrappingType textWrappingType_0 = TextWrappingType.Left;

    public TextWrappingStyle method_0()
    {
        return this.textWrappingStyle_0;
    }

    public void method_1(TextWrappingStyle A_0)
    {
        this.textWrappingStyle_0 = A_0;
    }

    public TextWrappingType method_2()
    {
        return this.textWrappingType_0;
    }

    public void method_3(TextWrappingType A_0)
    {
        this.textWrappingType_0 = A_0;
    }

    bool object.Equals(object A_0)
    {
        return (((A_0 != null) && (A_0 is Class311)) && (((A_0 as Class311).method_0() == this.method_0()) && ((A_0 as Class311).method_2() == this.method_2())));
    }

    int object.GetHashCode()
    {
        return base.GetHashCode();
    }
}

