using Spire.Doc.Documents.Converters.BinaryDoc.User;
using System;
using System.IO;

internal class Class438
{
    internal ControlType controlType_0;
    internal int int_0;
    internal int int_1;
    internal int int_2;
    internal int int_3;
    internal int int_4;
    internal TBCFlags tbcflags_0;

    internal Class438(BinaryReader A_0)
    {
        A_0.ReadByte();
        A_0.ReadByte();
        this.tbcflags_0 = (TBCFlags) A_0.ReadByte();
        this.controlType_0 = (ControlType) A_0.ReadByte();
        this.int_0 = A_0.ReadUInt16();
        this.int_1 = A_0.ReadInt32();
        this.int_2 = A_0.ReadByte();
        if ((this.tbcflags_0 & TBCFlags.SaveDxy) != 0)
        {
            this.int_3 = A_0.ReadUInt16();
            this.int_4 = A_0.ReadUInt16();
        }
    }
}

