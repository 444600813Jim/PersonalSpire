using Spire.Doc;
using System;
using System.IO;
using System.Text;

internal class Class297
{
    private byte byte_0;
    private DateTime dateTime_0;
    private DateTime dateTime_1;
    private EntryType entryType_0;
    private Guid guid_0;
    public const int int_0 = 0x80;
    private const int int_1 = 0x40;
    public int int_10;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private int int_8;
    public int int_9;
    private string string_0;
    private uint uint_0;

    public Class297(string A_0, EntryType A_1, int A_2)
    {
        this.byte_0 = 1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.int_4 = -1;
        this.int_6 = -2;
        this.int_9 = -1;
        this.int_10 = -1;
        this.string_0 = A_0;
        this.entryType_0 = A_1;
        this.int_8 = A_2;
        this.dateTime_1 = this.dateTime_0 = DateTime.Now;
    }

    public Class297(byte[] A_0, int A_1, int A_2)
    {
        int num4 = 13;
        this.byte_0 = 1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.int_4 = -1;
        this.int_6 = -2;
        this.int_9 = -1;
        this.int_10 = -1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("圲吴䌶堸", num4));
        }
        if ((A_1 < 0) || (A_1 >= A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尲匴儶䨸帺䤼", num4));
        }
        this.int_8 = A_2;
        int count = BitConverter.ToUInt16(A_0, A_1 + 0x40);
        this.string_0 = Encoding.Unicode.GetString(A_0, A_1, count);
        count = this.string_0.Length;
        if ((count > 0) && (this.string_0[count - 1] == '\0'))
        {
            this.string_0 = this.string_0.Substring(0, count - 1);
        }
        A_1 += 0x42;
        this.entryType_0 = (EntryType) A_0[A_1];
        A_1++;
        this.byte_0 = A_0[A_1];
        A_1++;
        this.int_2 = BitConverter.ToInt32(A_0, A_1);
        A_1 += 4;
        this.int_3 = BitConverter.ToInt32(A_0, A_1);
        A_1 += 4;
        this.int_4 = BitConverter.ToInt32(A_0, A_1);
        A_1 += 4;
        byte[] dst = new byte[0x10];
        Buffer.BlockCopy(A_0, A_1, dst, 0, 0x10);
        this.guid_0 = new Guid(dst);
        A_1 += 0x10;
        this.int_5 = BitConverter.ToInt32(A_0, A_1);
        A_1 += 4;
        long num2 = DateTime.MaxValue.ToFileTime();
        long fileTime = BitConverter.ToInt64(A_0, A_1);
        fileTime = ((fileTime < 0L) || (fileTime > num2)) ? 0L : fileTime;
        this.dateTime_0 = DateTime.FromFileTime(fileTime);
        A_1 += 8;
        fileTime = BitConverter.ToInt64(A_0, A_1);
        fileTime = ((fileTime < 0L) || (fileTime > num2)) ? 0L : fileTime;
        this.dateTime_1 = DateTime.FromFileTime(fileTime);
        A_1 += 8;
        this.int_6 = BitConverter.ToInt32(A_0, A_1);
        A_1 += 4;
        this.uint_0 = BitConverter.ToUInt32(A_0, A_1);
        A_1 += 4;
        this.int_7 = BitConverter.ToInt32(A_0, A_1);
        A_1 += 4;
    }

    public string method_0()
    {
        return this.string_0;
    }

    public void method_1(string A_0)
    {
        this.string_0 = A_0;
    }

    public int method_10()
    {
        return this.int_4;
    }

    public void method_11(int A_0)
    {
        this.int_4 = A_0;
    }

    public Guid method_12()
    {
        return this.guid_0;
    }

    public void method_13(Guid A_0)
    {
        this.guid_0 = A_0;
    }

    public int method_14()
    {
        return this.int_5;
    }

    public void method_15(int A_0)
    {
        this.int_5 = A_0;
    }

    public DateTime method_16()
    {
        return this.dateTime_0;
    }

    public void method_17(DateTime A_0)
    {
        this.dateTime_0 = A_0;
    }

    public DateTime method_18()
    {
        return this.dateTime_1;
    }

    public void method_19(DateTime A_0)
    {
        this.dateTime_1 = A_0;
    }

    public EntryType method_2()
    {
        return this.entryType_0;
    }

    public int method_20()
    {
        return this.int_6;
    }

    public void method_21(int A_0)
    {
        this.int_6 = A_0;
    }

    public uint method_22()
    {
        return this.uint_0;
    }

    public void method_23(uint A_0)
    {
        this.uint_0 = A_0;
    }

    public int method_24()
    {
        return this.int_7;
    }

    public void method_25(int A_0)
    {
    }

    public int method_26()
    {
        return this.int_8;
    }

    internal void method_27(int A_0)
    {
        this.int_8 = A_0;
    }

    public void method_28(Stream A_0)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬷丹主嬽ℿ⽁", num));
        }
        long position = A_0.Position;
        if (this.entryType_0 == EntryType.Invalid)
        {
            this.int_4 = -1;
            this.int_3 = -1;
            this.int_2 = -1;
        }
        byte[] bytes = Encoding.Unicode.GetBytes(this.string_0);
        A_0.Write(bytes, 0, bytes.Length);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.Position = position + 0x40L;
        bytes = BitConverter.GetBytes((short) (bytes.Length + 2));
        A_0.Write(bytes, 0, 2);
        A_0.WriteByte((byte) this.entryType_0);
        A_0.WriteByte(this.byte_0);
        bytes = BitConverter.GetBytes(this.int_2);
        A_0.Write(bytes, 0, 4);
        bytes = BitConverter.GetBytes(this.int_3);
        A_0.Write(bytes, 0, 4);
        bytes = BitConverter.GetBytes(this.int_4);
        A_0.Write(bytes, 0, 4);
        if ((this.method_2() == EntryType.Root) && (this.guid_0.CompareTo(Guid.Empty) == 0))
        {
            this.guid_0 = new Guid(BookmarkStart.b("࠷ਹ఻ఽ瀿穁癃癅敇穉籋繍恏网摓晕桗橙煛㵝偟剡呣䭥塧婩屫幭䁯䉱䑳䙵䡷䩹䡻䡽", num));
        }
        bytes = this.guid_0.ToByteArray();
        A_0.Write(bytes, 0, bytes.Length);
        bytes = BitConverter.GetBytes(this.int_5);
        A_0.Write(bytes, 0, 4);
        bytes = BitConverter.GetBytes((long) 0L);
        A_0.Write(bytes, 0, bytes.Length);
        bytes = BitConverter.GetBytes((long) 0L);
        A_0.Write(bytes, 0, bytes.Length);
        bytes = BitConverter.GetBytes(this.int_6);
        A_0.Write(bytes, 0, 4);
        bytes = BitConverter.GetBytes(this.uint_0);
        A_0.Write(bytes, 0, 4);
        bytes = BitConverter.GetBytes(this.int_7);
        A_0.Write(bytes, 0, 4);
    }

    public void method_3(EntryType A_0)
    {
        this.entryType_0 = A_0;
    }

    public byte method_4()
    {
        return this.byte_0;
    }

    public void method_5(byte A_0)
    {
        this.byte_0 = A_0;
    }

    public int method_6()
    {
        return this.int_2;
    }

    public void method_7(int A_0)
    {
        this.int_2 = A_0;
    }

    public int method_8()
    {
        return this.int_3;
    }

    public void method_9(int A_0)
    {
        this.int_3 = A_0;
    }

    internal enum EntryType
    {
        Invalid,
        Storage,
        Stream,
        LockBytes,
        Property,
        Root
    }
}

