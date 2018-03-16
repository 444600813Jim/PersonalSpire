using System;
using System.IO;

internal class Class303
{
    private readonly BinaryReader binaryReader_0;

    public Class303(Stream A_0)
    {
        this.binaryReader_0 = new BinaryReader(A_0);
    }

    public Stream method_0()
    {
        return this.binaryReader_0.BaseStream;
    }

    public int method_1()
    {
        return Class710.smethod_1(this.binaryReader_0.ReadInt32());
    }

    public uint method_2()
    {
        return Class710.smethod_2(this.binaryReader_0.ReadUInt32());
    }

    public short method_3()
    {
        return Class710.smethod_3(this.binaryReader_0.ReadInt16());
    }

    public ushort method_4()
    {
        return Class710.smethod_4(this.binaryReader_0.ReadUInt16());
    }

    public long method_5()
    {
        return Class710.smethod_0(this.binaryReader_0.ReadInt64());
    }

    public int method_6()
    {
        byte[] buffer = this.binaryReader_0.ReadBytes(3);
        int num = 0;
        int num2 = 1;
        for (int i = 2; i >= 0; i--)
        {
            num += buffer[i] * num2;
            num2 = num2 << 8;
        }
        return num;
    }

    public short method_7()
    {
        return this.binaryReader_0.ReadByte();
    }

    public byte[] method_8(int A_0)
    {
        return this.binaryReader_0.ReadBytes(A_0);
    }

    public char[] method_9(int A_0)
    {
        char[] chArray = new char[A_0];
        for (int i = 0; i < chArray.Length; i++)
        {
            chArray[i] = (char) this.binaryReader_0.ReadByte();
        }
        return chArray;
    }
}

