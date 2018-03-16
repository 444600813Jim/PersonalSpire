using System;
using System.IO;

internal abstract class Class483
{
    private readonly BinaryReader binaryReader_0;
    private readonly int int_0;
    private readonly long long_0;

    internal Class483(BinaryReader A_0)
    {
        this.binaryReader_0 = A_0;
        this.long_0 = A_0.BaseStream.Position;
        A_0.BaseStream.Seek(0x1ffL, SeekOrigin.Current);
        this.int_0 = A_0.ReadByte();
        A_0.BaseStream.Seek(this.long_0, SeekOrigin.Begin);
    }

    protected long method_0()
    {
        return this.long_0;
    }

    protected int method_1()
    {
        return this.int_0;
    }

    protected BinaryReader method_2()
    {
        return this.binaryReader_0;
    }
}

