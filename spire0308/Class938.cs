using Spire.Doc;
using System;
using System.IO;

internal class Class938
{
    private static readonly byte[] byte_0 = new byte[] { 0xd0, 0xcf, 0x11, 0xe0, 0xa1, 0xb1, 0x1a, 0xe1 };
    private byte[] byte_1;
    private Guid guid_0;
    public const int int_0 = 0x200;
    private const int int_1 = 8;
    private int int_10;
    private int[] int_11;
    internal const int int_2 = 2;
    internal const int int_3 = 4;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private int int_8;
    private int int_9;
    private uint uint_0;
    private uint uint_1;
    private uint uint_2;
    private ushort ushort_0;
    private ushort ushort_1;
    private ushort ushort_2;
    private ushort ushort_3;
    private ushort ushort_4;
    private ushort ushort_5;

    public Class938()
    {
        this.byte_1 = new byte[8];
        this.guid_0 = new Guid();
        this.ushort_0 = 0x3e;
        this.ushort_1 = 3;
        this.ushort_2 = 0xfffe;
        this.ushort_3 = 9;
        this.ushort_4 = 6;
        this.int_5 = -1;
        this.uint_2 = 0x1000;
        this.int_7 = -2;
        this.int_9 = -2;
        this.int_11 = new int[0x6d];
        Buffer.BlockCopy(byte_0, 0, this.byte_1, 0, 8);
    }

    public Class938(Stream A_0)
    {
        int num = 4;
        this.byte_1 = new byte[8];
        this.guid_0 = new Guid();
        this.ushort_0 = 0x3e;
        this.ushort_1 = 3;
        this.ushort_2 = 0xfffe;
        this.ushort_3 = 9;
        this.ushort_4 = 6;
        this.int_5 = -1;
        this.uint_2 = 0x1000;
        this.int_7 = -2;
        this.int_9 = -2;
        this.int_11 = new int[0x6d];
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("天堫尭唯匱夳", num));
        }
        if (A_0.Length < 0x200L)
        {
            throw new Exception7();
        }
        byte[] buffer = new byte[0x200];
        A_0.Read(buffer, 0, 0x200);
        Buffer.BlockCopy(buffer, 0, this.byte_1, 0, 8);
        this.method_1();
        byte[] dst = new byte[0x10];
        Buffer.BlockCopy(buffer, 8, dst, 0, 0x10);
        this.guid_0 = new Guid(dst);
        this.ushort_0 = BitConverter.ToUInt16(buffer, 0x18);
        this.ushort_1 = BitConverter.ToUInt16(buffer, 0x1a);
        this.ushort_2 = BitConverter.ToUInt16(buffer, 0x1c);
        this.ushort_3 = BitConverter.ToUInt16(buffer, 30);
        this.ushort_4 = BitConverter.ToUInt16(buffer, 0x20);
        this.ushort_5 = BitConverter.ToUInt16(buffer, 0x22);
        this.uint_0 = BitConverter.ToUInt32(buffer, 0x24);
        this.uint_1 = BitConverter.ToUInt32(buffer, 40);
        this.int_4 = BitConverter.ToInt32(buffer, 0x2c);
        this.int_5 = BitConverter.ToInt32(buffer, 0x30);
        this.int_6 = BitConverter.ToInt32(buffer, 0x34);
        this.uint_2 = BitConverter.ToUInt32(buffer, 0x38);
        this.int_7 = BitConverter.ToInt32(buffer, 60);
        this.int_8 = BitConverter.ToInt32(buffer, 0x40);
        this.int_9 = BitConverter.ToInt32(buffer, 0x44);
        this.int_10 = BitConverter.ToInt32(buffer, 0x48);
        Buffer.BlockCopy(buffer, 0x4c, this.int_11, 0, this.int_11.Length * 4);
    }

    public void method_0(Stream A_0)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嬧帩師䬭儯弱", num));
        }
        byte[] dst = new byte[0x200];
        Buffer.BlockCopy(this.byte_1, 0, dst, 0, 8);
        Buffer.BlockCopy(this.guid_0.ToByteArray(), 0, dst, 8, 0x10);
        this.method_2(dst, 0x18, this.ushort_0);
        this.method_2(dst, 0x1a, this.ushort_1);
        this.method_2(dst, 0x1c, this.ushort_2);
        this.method_2(dst, 30, this.ushort_3);
        this.method_2(dst, 0x20, this.ushort_4);
        this.method_2(dst, 0x22, this.ushort_5);
        this.method_3(dst, 0x24, this.uint_0);
        this.method_3(dst, 40, this.uint_1);
        this.method_4(dst, 0x2c, this.int_4);
        this.method_4(dst, 0x30, this.int_5);
        this.method_4(dst, 0x34, this.int_6);
        this.method_3(dst, 0x38, this.uint_2);
        this.method_4(dst, 60, this.int_7);
        this.method_4(dst, 0x40, this.int_8);
        this.method_4(dst, 0x44, this.int_9);
        this.method_4(dst, 0x48, this.int_10);
        Buffer.BlockCopy(this.int_11, 0, dst, 0x4c, this.int_11.Length * 4);
        A_0.Write(dst, 0, 0x200);
    }

    private void method_1()
    {
        int num = 7;
        if (!smethod_1(this.byte_1))
        {
            throw new Exception7(BookmarkStart.b("稬崮帰崲刴᜶䨸刺娼儾⁀㝂い㕆ⱈ", num));
        }
    }

    public ushort method_10()
    {
        return this.ushort_4;
    }

    public ushort method_11()
    {
        return this.ushort_5;
    }

    public uint method_12()
    {
        return this.uint_0;
    }

    public uint method_13()
    {
        return this.uint_1;
    }

    public int method_14()
    {
        return this.int_4;
    }

    public void method_15(int A_0)
    {
        this.int_4 = A_0;
    }

    public int method_16()
    {
        return this.int_5;
    }

    public void method_17(int A_0)
    {
        this.int_5 = A_0;
    }

    public int method_18()
    {
        return this.int_6;
    }

    public uint method_19()
    {
        return this.uint_2;
    }

    private void method_2(byte[] A_0, int A_1, ushort A_2)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("倱䄳倵帷弹主", num));
        }
        A_0[A_1] = (byte) (A_2 & 0xff);
        A_0[A_1 + 1] = (byte) ((A_2 & 0xff00) >> 8);
    }

    public int method_20()
    {
        return this.int_7;
    }

    public void method_21(int A_0)
    {
        this.int_7 = A_0;
    }

    public int method_22()
    {
        return this.int_8;
    }

    public void method_23(int A_0)
    {
        this.int_8 = A_0;
    }

    public int method_24()
    {
        return this.int_9;
    }

    public void method_25(int A_0)
    {
        this.int_9 = A_0;
    }

    public int method_26()
    {
        return this.int_10;
    }

    public void method_27(int A_0)
    {
        this.int_10 = A_0;
    }

    public int[] method_28()
    {
        return this.int_11;
    }

    internal void method_29(Stream A_0)
    {
        byte[] dst = new byte[0x200];
        Buffer.BlockCopy(this.byte_1, 0, dst, 0, 8);
        Buffer.BlockCopy(this.guid_0.ToByteArray(), 0, dst, 8, 0x10);
        Buffer.BlockCopy(BitConverter.GetBytes(this.ushort_0), 0, dst, 0x18, 2);
        Buffer.BlockCopy(BitConverter.GetBytes(this.ushort_1), 0, dst, 0x1a, 2);
        Buffer.BlockCopy(BitConverter.GetBytes(this.ushort_2), 0, dst, 0x1c, 2);
        Buffer.BlockCopy(BitConverter.GetBytes(this.ushort_3), 0, dst, 30, 2);
        Buffer.BlockCopy(BitConverter.GetBytes(this.ushort_4), 0, dst, 0x20, 2);
        Buffer.BlockCopy(BitConverter.GetBytes(this.ushort_5), 0, dst, 0x22, 2);
        Buffer.BlockCopy(BitConverter.GetBytes(this.uint_0), 0, dst, 0x24, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.uint_1), 0, dst, 40, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.int_4), 0, dst, 0x2c, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.int_5), 0, dst, 0x30, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.int_6), 0, dst, 0x34, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.uint_2), 0, dst, 0x38, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.int_7), 0, dst, 60, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.int_8), 0, dst, 0x40, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.int_9), 0, dst, 0x44, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(this.int_10), 0, dst, 0x48, 4);
        Buffer.BlockCopy(this.int_11, 0, dst, 0x4c, this.int_11.Length * 4);
        A_0.Position = 0L;
        A_0.Write(dst, 0, 0x200);
    }

    private void method_3(byte[] A_0, int A_1, uint A_2)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("丫嬭嘯吱儳䐵", num));
        }
        A_0[A_1] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
        A_0[A_1 + 1] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
        A_0[A_1 + 2] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
        A_0[A_1 + 3] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
    }

    internal long method_30(int A_0)
    {
        return (long) ((A_0 << this.ushort_3) + 0x200);
    }

    internal long method_31(int A_0, int A_1)
    {
        return (long) ((A_0 << this.ushort_3) + A_1);
    }

    private void method_4(byte[] A_0, int A_1, int A_2)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐥崧䰩䨫䬭䈯", num));
        }
        A_0[A_1] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
        A_0[A_1 + 1] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
        A_0[A_1 + 2] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
        A_0[A_1 + 3] = (byte) (A_2 & 0xff);
        A_2 = A_2 >> 8;
    }

    public int method_5()
    {
        return (((int) 1) << this.ushort_3);
    }

    public ushort method_6()
    {
        return this.ushort_0;
    }

    public ushort method_7()
    {
        return this.ushort_1;
    }

    public ushort method_8()
    {
        return this.ushort_2;
    }

    public ushort method_9()
    {
        return this.ushort_3;
    }

    public static bool smethod_0(Stream A_0)
    {
        bool flag = false;
        if (A_0 != null)
        {
            byte[] buffer = new byte[8];
            long position = A_0.Position;
            if (A_0.Read(buffer, 0, 8) == 8)
            {
                flag = smethod_1(buffer);
            }
            A_0.Position = position;
        }
        return flag;
    }

    private static bool smethod_1(byte[] A_0)
    {
        bool flag = false;
        if ((A_0 != null) && (A_0.Length == 8))
        {
            flag = true;
            for (int i = 0; i < 8; i++)
            {
                if (A_0[i] != byte_0[i])
                {
                    return false;
                }
            }
        }
        return flag;
    }
}

