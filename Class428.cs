using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class428
{
    private byte[] byte_0;

    internal Class428()
    {
    }

    internal Class428(byte[] A_0)
    {
        this.byte_0 = A_0;
    }

    internal Class428(BinaryReader A_0, int A_1)
    {
        this.byte_0 = A_0.ReadBytes(A_1);
    }

    public override int imethod_0()
    {
        return new CrcMaker().MakeCRC(this.byte_0);
    }

    internal Class428 method_0()
    {
        return (Class428) base.MemberwiseClone();
    }

    internal bool method_1(Class428 A_0)
    {
        return Class85.smethod_1(this.byte_0, A_0.byte_0);
    }

    internal byte[] method_2()
    {
        return this.byte_0;
    }

    internal void method_3(byte[] A_0)
    {
        this.byte_0 = A_0;
    }
}

