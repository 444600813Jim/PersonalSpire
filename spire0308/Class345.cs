using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class345 : BinaryWriter
{
    internal Class345(Stream A_0) : base(A_0, Encoding.Unicode)
    {
    }

    internal void method_0(SprmCode A_0, int A_1)
    {
        this.method_5(A_0);
        this.Write((byte) A_1);
    }

    internal void method_1(SprmCode A_0, int A_1)
    {
        this.method_5(A_0);
        this.Write((short) A_1);
    }

    internal void method_2(SprmCode A_0, int A_1)
    {
        this.method_5(A_0);
        this.Write((ushort) A_1);
    }

    internal void method_3(SprmCode A_0, int A_1)
    {
        this.method_5(A_0);
        this.Write(A_1);
    }

    internal void method_4(SprmCode A_0, bool A_1)
    {
        this.method_0(A_0, A_1 ? 1 : 0);
    }

    internal void method_5(SprmCode A_0)
    {
        this.Write((ushort) A_0);
    }
}

