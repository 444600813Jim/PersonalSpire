using Spire.Doc.Documents.Converters;
using System;
using System.ComponentModel;

internal class Class579 : Class577, Interface31
{
    private readonly EditRevisionType editRevisionType_0;

    internal Class579(EditRevisionType A_0) : this(A_0, "", DateTime.MinValue)
    {
    }

    internal Class579(EditRevisionType A_0, string A_1, DateTime A_2) : base(A_1, A_2)
    {
        this.editRevisionType_0 = A_0;
    }

    public bool imethod_0()
    {
        return false;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private Interface31 imethod_1()
    {
        return (Class579) base.MemberwiseClone();
    }

    internal EditRevisionType method_4()
    {
        return this.editRevisionType_0;
    }
}

