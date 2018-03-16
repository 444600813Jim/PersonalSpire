using Spire.Doc.Documents.Converters;
using System;
using System.IO;

internal class Class769
{
    internal bool bool_0;
    internal FixedCommandType fixedCommandType_0;
    internal int int_0;

    internal Class769()
    {
    }

    internal Class769(BinaryReader A_0)
    {
        this.int_0 = A_0.ReadUInt16();
        int num = A_0.ReadUInt16();
        this.fixedCommandType_0 = ((FixedCommandType) num) & ((FixedCommandType) 0x1fff);
        this.bool_0 = (num & 0x4000) != 0;
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) this.int_0);
        int num = 0;
        num = (int) (FixedCommandType.None | this.fixedCommandType_0);
        num |= 0x2000;
        num |= this.bool_0 ? 0x4000 : 0;
        num |= !this.bool_0 ? 0x8000 : 0;
        A_0.Write((ushort) num);
    }
}

