using Spire.Doc;
using System;
using System.IO;

internal class Class268 : Class266
{
    private bool bool_1;
    internal byte[] byte_1;
    private Class269 class269_0;
    internal const int int_0 = 0x24;
    internal int int_1;
    internal int int_2;
    internal int int_3;
    internal int int_4;
    internal int int_5;
    internal int int_6;
    internal int int_7;
    internal int int_8;
    internal int int_9;
    internal uint uint_0;

    internal Class268() : base(EscherRecordType.Bse, 2)
    {
    }

    private void method_10(BinaryReader A_0)
    {
        int num = 1;
        this.int_1 = A_0.ReadByte();
        this.int_2 = A_0.ReadByte();
        this.byte_1 = A_0.ReadBytes(0x10);
        this.int_3 = A_0.ReadInt16();
        this.int_4 = A_0.ReadInt32();
        this.int_5 = A_0.ReadInt32();
        this.uint_0 = A_0.ReadUInt32();
        this.int_6 = A_0.ReadByte();
        this.int_7 = A_0.ReadByte();
        this.int_8 = A_0.ReadByte();
        this.int_9 = A_0.ReadByte();
        if (this.int_7 > 0)
        {
            throw new InvalidOperationException(BookmarkStart.b("攦攨截紬༮弰刲場制ᤸ唺刼䬾慀あい㝆㥈⑊㽌㭎㑐㝒答", num));
        }
    }

    private void method_11(BinaryWriter A_0)
    {
        A_0.Write((byte) this.int_1);
        A_0.Write((byte) this.int_2);
        A_0.Write(this.byte_1);
        A_0.Write((short) this.int_3);
        A_0.Write(this.int_4);
        A_0.Write(this.int_5);
        A_0.Write(this.uint_0);
        A_0.Write((byte) this.int_6);
        A_0.Write((byte) this.int_7);
        A_0.Write((byte) this.int_8);
        A_0.Write((byte) this.int_9);
    }

    internal void method_4(BinaryReader A_0)
    {
        if (((this.uint_0 != uint.MaxValue) && (this.int_5 != 0)) && (this.int_1 != 0))
        {
            A_0.BaseStream.Position = this.uint_0;
            this.class269_0 = Class1062.smethod_0(A_0) as Class269;
        }
    }

    internal void method_5(BinaryWriter A_0)
    {
        this.uint_0 = (uint) A_0.BaseStream.Position;
        this.int_4 = this.class269_0.method_2(A_0);
    }

    internal bool method_6()
    {
        return this.bool_1;
    }

    internal void method_7(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal Class269 method_8()
    {
        return this.class269_0;
    }

    internal void method_9(Class269 A_0)
    {
        this.class269_0 = A_0;
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        int num = ((int) A_0.BaseStream.Position) + base.method_3().method_10();
        this.method_10(A_0);
        while (A_0.BaseStream.Position < num)
        {
            this.bool_1 = true;
            this.class269_0 = (Class269) Class1062.smethod_0(A_0);
        }
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        this.method_11(A_0);
        if (this.bool_1)
        {
            this.int_4 = this.class269_0.method_2(A_0);
            int num2 = (int) A_0.BaseStream.Position;
            A_0.BaseStream.Position = position;
            this.method_11(A_0);
            A_0.BaseStream.Position = num2;
        }
    }
}

