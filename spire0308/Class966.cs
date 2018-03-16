using System;
using System.IO;

internal class Class966
{
    internal const int int_0 = 40;
    internal int int_1;
    internal int int_2 = 40;
    internal int int_3;
    internal int int_4;
    internal int int_5;
    internal uint uint_0;
    internal uint uint_1;
    internal uint uint_2;
    internal uint uint_3;
    internal ushort ushort_0;
    internal ushort ushort_1;

    internal int method_0()
    {
        if (((this.ushort_0 == 0x20) || (this.ushort_0 == 0x10)) && (this.uint_2 == 3))
        {
            return 12;
        }
        if (this.ushort_0 > 8)
        {
            return 0;
        }
        int num = (this.uint_1 != 0) ? ((int) this.uint_1) : (((int) 1) << this.ushort_0);
        return (num * 4);
    }

    internal void method_1(BinaryReader A_0)
    {
        this.int_2 = A_0.ReadInt32();
        switch (this.int_2)
        {
            case 12:
                this.int_2 = 40;
                this.int_3 = A_0.ReadUInt16();
                this.int_1 = A_0.ReadUInt16();
                this.ushort_1 = A_0.ReadUInt16();
                this.ushort_0 = A_0.ReadUInt16();
                return;
        }
        this.int_3 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
        this.ushort_1 = A_0.ReadUInt16();
        this.ushort_0 = A_0.ReadUInt16();
        this.uint_2 = A_0.ReadUInt32();
        this.uint_3 = A_0.ReadUInt32();
        this.int_4 = A_0.ReadInt32();
        this.int_5 = A_0.ReadInt32();
        this.uint_1 = A_0.ReadUInt32();
        this.uint_0 = A_0.ReadUInt32();
    }

    internal void method_2(BinaryWriter A_0)
    {
        A_0.Write(this.int_2);
        A_0.Write(this.int_3);
        A_0.Write(this.int_1);
        A_0.Write((short) this.ushort_1);
        A_0.Write((short) this.ushort_0);
        A_0.Write((int) this.uint_2);
        A_0.Write((int) this.uint_3);
        A_0.Write(this.int_4);
        A_0.Write(this.int_5);
        A_0.Write((int) this.uint_1);
        A_0.Write((int) this.uint_0);
    }
}

