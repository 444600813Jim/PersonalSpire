using System;
using System.IO;

internal class Class230 : Class229
{
    internal Class230(Class229 A_0) : base(A_0.method_4())
    {
        base.string_0 = A_0.method_7();
    }

    public Class230(Class814 A_0) : base(A_0.method_7())
    {
        base.string_0 = A_0.method_0();
    }

    internal Class230(Stream A_0, string A_1) : base(A_0)
    {
        base.string_0 = A_1;
    }

    internal Class229 method_10()
    {
        return new Class230(base.stream_0, base.string_0);
    }
}

