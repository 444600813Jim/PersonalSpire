using Spire.Doc;
using System;
using System.IO;

[CLSCompliant(false)]
internal class Class992
{
    private byte[] byte_0;
    private byte[] byte_1;
    private byte[] byte_2;
    private Class991 class991_0;
    private int int_0;

    internal Class992()
    {
        this.byte_1 = new byte[0x10];
        this.class991_0 = new Class991();
    }

    internal Class992(Stream A_0)
    {
        this.byte_1 = new byte[0x10];
        this.class991_0 = new Class991();
        this.method_8(A_0);
    }

    internal byte[] method_0()
    {
        return this.byte_0;
    }

    internal void method_1(byte[] A_0)
    {
        this.byte_0 = A_0;
    }

    internal void method_10(Stream A_0)
    {
        int length = this.byte_0.Length;
        this.class991_0.method_3(A_0, length);
        A_0.Write(this.byte_0, 0, length);
        A_0.Write(this.byte_1, 0, this.byte_1.Length);
        this.class991_0.method_3(A_0, this.int_0);
        int count = this.byte_2.Length;
        A_0.Write(this.byte_2, 0, count);
    }

    internal byte[] method_2()
    {
        return this.byte_1;
    }

    internal void method_3(byte[] A_0)
    {
        this.byte_1 = A_0;
    }

    internal byte[] method_4()
    {
        return this.byte_2;
    }

    internal void method_5(byte[] A_0)
    {
        this.byte_2 = A_0;
    }

    internal int method_6()
    {
        return this.int_0;
    }

    internal void method_7(int A_0)
    {
        this.int_0 = A_0;
    }

    internal void method_8(Stream A_0)
    {
        this.method_9(A_0, false);
    }

    internal void method_9(Stream A_0, bool A_1)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔵䰷䠹夻弽ⴿ", num));
        }
        if (!A_1)
        {
            byte[] buffer = new byte[4];
            int count = this.class991_0.method_0(A_0, buffer);
            this.byte_0 = new byte[count];
            A_0.Read(this.byte_0, 0, count);
            A_0.Read(this.byte_1, 0, this.byte_1.Length);
            this.int_0 = this.class991_0.method_0(A_0, buffer);
            long length = A_0.Length;
            long position = A_0.Position;
            this.byte_2 = new byte[this.int_0];
            A_0.Read(this.byte_2, 0, this.int_0);
        }
        else
        {
            this.byte_0 = new byte[0x10];
            A_0.Read(this.byte_0, 0, 0x10);
            A_0.Read(this.byte_1, 0, 0x10);
            this.byte_2 = new byte[0x10];
            A_0.Read(this.byte_2, 0, 0x10);
        }
    }
}

