using Spire.Doc.Documents.Converters.Encryption;
using System;
using System.IO;

internal class Class1103
{
    internal AlgorithmIdHash algorithmIdHash_0;
    internal AlgorithmType algorithmType_0;
    internal HeaderFlags headerFlags_0;
    internal int int_0;
    internal int int_1;
    internal int int_2;
    internal string string_0;

    internal Class1103(BinaryReader A_0)
    {
        int num = A_0.ReadInt32();
        this.headerFlags_0 = (HeaderFlags) A_0.ReadInt32();
        this.int_0 = A_0.ReadInt32();
        this.algorithmType_0 = (AlgorithmType) A_0.ReadInt32();
        this.algorithmIdHash_0 = (AlgorithmIdHash) A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
        this.int_2 = A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt32();
        this.string_0 = Class1029.smethod_5(A_0, num - 0x20);
    }
}

