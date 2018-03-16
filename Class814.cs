using Spire.Compression;
using Spire.Compression.Zip;
using Spire.Doc;
using System;
using System.IO;
using System.Text;

internal class Class814 : IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private Class771 class771_0;
    private CompressionLevel compressionLevel_0;
    private CompressionMethod compressionMethod_0;
    private GeneralPurposeBitFlags generalPurposeBitFlags_0;
    private const int int_0 = 0xff;
    private int int_1;
    private int int_2;
    private long long_0;
    private long long_1;
    private long long_2;
    private Stream stream_0;
    private string string_0;
    private uint uint_0;

    internal Class814(Class771 A_0)
    {
        this.compressionMethod_0 = CompressionMethod.Deflated;
        this.compressionLevel_0 = CompressionLevel.Normal;
        this.class771_0 = A_0;
    }

    public Class814(Class771 A_0, string A_1, Stream A_2, bool A_3, FileAttributes A_4) : this(A_0)
    {
        this.string_0 = A_1;
        this.bool_0 = A_3;
        this.stream_0 = A_2;
        this.int_2 = (int) A_4;
        if (this.method_37(this.string_0))
        {
            this.generalPurposeBitFlags_0 = (GeneralPurposeBitFlags) ((short) (this.generalPurposeBitFlags_0 | GeneralPurposeBitFlags.Unicode));
        }
    }

    public string method_0()
    {
        return this.string_0;
    }

    public void method_1(string A_0)
    {
        int num = 0x11;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("縶䴸帺值焾⁀⹂⁄", num));
        }
        this.string_0 = A_0;
    }

    public bool method_10()
    {
        return this.bool_0;
    }

    public bool method_11()
    {
        return this.bool_1;
    }

    public FileAttributes method_12()
    {
        return (FileAttributes) this.int_2;
    }

    public void method_13(FileAttributes A_0)
    {
        this.int_2 = (int) A_0;
    }

    public bool method_14()
    {
        return this.bool_3;
    }

    public void method_15(bool A_0)
    {
        this.bool_3 = A_0;
    }

    public void method_16(Stream11 A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄱䀳䐵崷嬹儻", num));
        }
        if ((this.stream_0 != null) && this.bool_0)
        {
            this.stream_0.Close();
        }
        this.stream_0 = A_0.method_0();
        this.long_0 = this.stream_0.Length;
        this.long_1 = A_0.method_2();
        this.bool_1 = true;
        this.uint_0 = A_0.method_1();
        this.bool_0 = false;
    }

    public void method_17(Stream A_0, bool A_1)
    {
        if ((this.stream_0 != null) && this.bool_0)
        {
            this.stream_0.Close();
        }
        this.bool_0 = A_1;
        this.stream_0 = A_0;
        this.method_18();
        this.long_1 = (A_0 != null) ? A_0.Length : 0L;
    }

    public void method_18()
    {
        this.long_0 = 0L;
        this.long_1 = 0L;
        this.bool_1 = false;
        this.uint_0 = 0;
    }

    internal void method_19(Stream A_0)
    {
        if ((this.stream_0 == null) || (this.stream_0.Length == 0L))
        {
            this.compressionLevel_0 = CompressionLevel.NoCompression;
            this.compressionMethod_0 = CompressionMethod.Stored;
        }
        this.method_31(A_0);
        this.method_32(A_0);
        this.method_33(A_0);
    }

    public CompressionMethod method_2()
    {
        return this.compressionMethod_0;
    }

    internal void method_20()
    {
        if (this.stream_0 != null)
        {
            this.stream_0.Flush();
            if (this.bool_0)
            {
                this.stream_0.Close();
            }
            this.stream_0 = null;
            this.string_0 = null;
        }
    }

    internal void method_21(Stream A_0)
    {
        A_0.Write(BitConverter.GetBytes(0x2014b50), 0, 4);
        A_0.Write(BitConverter.GetBytes((short) 0x2d), 0, 2);
        A_0.Write(BitConverter.GetBytes((short) 20), 0, 2);
        A_0.Write(BitConverter.GetBytes((short) this.generalPurposeBitFlags_0), 0, 2);
        A_0.Write(BitConverter.GetBytes((short) this.compressionMethod_0), 0, 2);
        int num = this.method_22(DateTime.Now);
        byte[] buffer = new byte[] { (byte) (num & 0xff), (byte) ((num & 0xff00) >> 8), (byte) ((num & 0xff0000) >> 0x10), (byte) ((num & 0xff000000L) >> 0x18) };
        A_0.Write(buffer, 0, 4);
        A_0.Write(BitConverter.GetBytes(this.uint_0), 0, 4);
        A_0.Write(BitConverter.GetBytes((int) this.long_0), 0, 4);
        A_0.Write(BitConverter.GetBytes((int) this.long_1), 0, 4);
        Encoding encoding = (((short) (this.generalPurposeBitFlags_0 & GeneralPurposeBitFlags.Unicode)) != 0) ? Encoding.UTF8 : Encoding.Default;
        byte[] bytes = encoding.GetBytes(this.string_0);
        A_0.Write(BitConverter.GetBytes((short) bytes.Length), 0, 2);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.Write(BitConverter.GetBytes(this.int_2), 0, 4);
        A_0.Write(BitConverter.GetBytes(this.int_1), 0, 4);
        byte[] buffer3 = encoding.GetBytes(this.string_0);
        A_0.Write(buffer3, 0, buffer3.Length);
    }

    private int method_22(DateTime A_0)
    {
        A_0 = A_0.ToLocalTime();
        ushort num = (ushort) (((A_0.Day & 0x1f) | ((A_0.Month << 5) & 480)) | (((A_0.Year - 0x7bc) << 9) & 0xfe00));
        ushort num2 = (ushort) ((((A_0.Second / 2) & 0x1f) | ((A_0.Minute << 5) & 0x7e0)) | ((A_0.Hour << 11) & 0xf800));
        return ((num << 0x10) | num2);
    }

    internal void method_23(Stream A_0)
    {
        A_0.Position += 4L;
        this.generalPurposeBitFlags_0 = (GeneralPurposeBitFlags) Class771.smethod_2(A_0);
        this.compressionMethod_0 = (CompressionMethod) Class771.smethod_2(A_0);
        this.bool_1 = true;
        A_0.Position += 4L;
        this.uint_0 = (uint) Class771.smethod_1(A_0);
        this.long_0 = Class771.smethod_1(A_0);
        this.long_1 = Class771.smethod_1(A_0);
        int count = Class771.smethod_2(A_0);
        int num2 = Class771.smethod_2(A_0);
        int num3 = Class771.smethod_2(A_0);
        A_0.Position += 4L;
        this.int_2 = Class771.smethod_1(A_0);
        this.int_1 = Class771.smethod_1(A_0);
        byte[] buffer = new byte[count];
        A_0.Read(buffer, 0, count);
        this.string_0 = ((((short) (this.generalPurposeBitFlags_0 & GeneralPurposeBitFlags.Unicode)) != 0) ? Encoding.UTF8 : Encoding.Default).GetString(buffer, 0, buffer.Length);
        A_0.Position += num2 + num3;
    }

    internal void method_24(Stream A_0, bool A_1)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("否崨太䠬丮尰", num));
        }
        A_0.Position = this.int_1;
        this.bool_2 = A_1;
        this.method_26(A_0);
        this.method_25(A_0);
    }

    private void method_25(Stream A_0)
    {
        int num = 0x13;
        if (this.long_0 > 0L)
        {
            MemoryStream stream = new MemoryStream();
            int num2 = (int) this.long_0;
            stream.Capacity = num2;
            byte[] buffer = new byte[0x1000];
            while (num2 > 0)
            {
                int count = Math.Min(num2, 0x1000);
                if (A_0.Read(buffer, 0, count) != count)
                {
                    throw new Exception2(BookmarkStart.b("簸唺夼Ἶ⹀╂敄ⅆ⁈❊⡌潎⍐㙒㑔㑖ㅘ㹚㥜罞䱠䍢ቤᕦ٨ժ੬佮ᝰᩲᥴቶ奸ᵺቼൾꞆ力권ﾒ랖붜ﲞ캠톢힤튦\ud9a8\udfaa莬", num));
                }
                stream.Write(buffer, 0, count);
                num2 -= count;
            }
            this.stream_0 = stream;
            this.bool_0 = true;
        }
        else
        {
            long length = A_0.Length;
            long position = A_0.Position;
            int num8 = 0;
            MemoryStream stream2 = new MemoryStream {
                Capacity = 0x1000
            };
            byte num3 = 0;
            byte[] buffer2 = new byte[1];
            while (position <= length)
            {
                int num4 = 1;
                if (A_0.Read(buffer2, 0, 1) != 1)
                {
                    throw new Exception2(BookmarkStart.b("簸唺夼Ἶ⹀╂敄ⅆ⁈❊⡌潎⍐㙒㑔㑖ㅘ㹚㥜罞䱠䍢ቤᕦ٨ժ੬佮ᝰᩲᥴቶ奸ᵺቼൾꞆ力권ﾒ랖붜ﲞ캠톢힤튦\ud9a8\udfaa莬", num));
                }
                if ((num3 == 80) && (buffer2[0] == 0x4b))
                {
                    A_0.Position -= 2L;
                    break;
                }
                position = A_0.Position;
                stream2.Write(buffer2, 0, num4);
                num3 = buffer2[0];
                num8++;
            }
            this.stream_0 = stream2;
            this.bool_0 = true;
            this.long_0 = num8 - 1;
        }
    }

    private void method_26(Stream A_0)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬷丹主嬽ℿ⽁", num));
        }
        if (Class771.smethod_1(A_0) != 0x4034b50)
        {
            throw new Exception2(BookmarkStart.b("笷嬹刻᤽㐿扁≃⽅♇⹉汋≍㽏ㅑ㕓㩕硗㉙㥛㽝џݡᙣ䙥᭧ͩ୫mᅯٱųѵᵷ婹养幽ꪉﲏ뒓ﾝ풟芡쮣풥袧첩얫슭햯銱\uddb3\uc5b5颷\ud9b9\ud3bb첽늿럁듃닅", num));
        }
        A_0.Position += 0x16L;
        int num2 = Class771.smethod_2(A_0);
        int num3 = Class771.smethod_2(A_0);
        A_0.Position += num2 + num3;
    }

    private void method_27()
    {
        int num = 9;
        if (this.bool_1)
        {
            if (this.compressionMethod_0 == CompressionMethod.Deflated)
            {
                this.stream_0.Position = 0L;
                if (this.bool_3)
                {
                    this.method_29();
                }
                else
                {
                    this.method_30();
                }
                this.bool_1 = false;
            }
            else
            {
                if (this.compressionMethod_0 != CompressionMethod.Stored)
                {
                    throw new NotSupportedException(BookmarkStart.b("氮帰帲䔴䔶尸䠺丼嘾⹀ⵂ敄㍆え㭊⡌畎煐", num) + this.compressionMethod_0.ToString() + BookmarkStart.b("༮堰䀲ᔴ夶嘸伺ᴼ䰾㑀㍂㕄⡆㭈㽊⡌⭎", num));
                }
                this.bool_1 = false;
            }
        }
    }

    private void method_28()
    {
        int num2;
        Class1114 class2 = new Class1114(this.stream_0, true);
        MemoryStream stream = new MemoryStream();
        byte[] buffer = new byte[0x1000];
        int num = 0;
        while ((num2 = class2.method_18(buffer, 0, 0x1000)) > 0)
        {
            stream.Write(buffer, 0, num2);
            num += num2;
        }
        if (this.long_1 <= 0L)
        {
            this.long_1 = num;
        }
        if (this.bool_0)
        {
            this.stream_0.Close();
        }
        this.bool_0 = true;
        this.stream_0 = stream;
        stream.SetLength(this.long_1);
        stream.Capacity = (int) this.long_1;
        if (this.bool_2)
        {
            this.method_35(stream.GetBuffer());
        }
        this.stream_0.Position = 0L;
    }

    private void method_29()
    {
        this.stream_0 = new Stream0(this.stream_0, CompressionMode.Decompress, this.bool_0);
    }

    public void method_3(CompressionMethod A_0)
    {
        this.compressionMethod_0 = A_0;
    }

    private void method_30()
    {
        int num;
        Stream0 stream = new Stream0(this.stream_0, CompressionMode.Decompress, true);
        MemoryStream stream2 = new MemoryStream {
            Capacity = (this.long_1 > 0L) ? ((int) this.long_1) : ((int) 0x1000L)
        };
        byte[] buffer = new byte[0x1000];
        bool flag = false;
        long num2 = 0L;
        while ((num = stream.Read(buffer, 0, 0x1000)) > 0)
        {
            flag = true;
            stream2.Write(buffer, 0, num);
            num2 += num;
        }
        stream.Dispose();
        if (this.long_1 <= 0L)
        {
            this.long_1 = num2;
        }
        if (!flag)
        {
            this.stream_0.Position = 0L;
            this.method_28();
        }
        else
        {
            if (this.bool_0)
            {
                this.stream_0.Close();
            }
            this.bool_0 = true;
            this.stream_0 = stream2;
            stream2.SetLength(this.long_1);
            stream2.Capacity = (int) this.long_1;
            if (this.bool_2)
            {
                this.method_35(stream2.GetBuffer());
            }
            this.stream_0.Position = 0L;
        }
    }

    private void method_31(Stream A_0)
    {
        this.int_1 = (int) A_0.Position;
        A_0.Write(BitConverter.GetBytes(0x4034b50), 0, 4);
        A_0.Write(BitConverter.GetBytes((short) 20), 0, 2);
        A_0.Write(BitConverter.GetBytes((short) this.generalPurposeBitFlags_0), 0, 2);
        A_0.Write(BitConverter.GetBytes((short) this.compressionMethod_0), 0, 2);
        int num = this.method_22(DateTime.Now);
        byte[] buffer = new byte[] { (byte) (num & 0xff), (byte) ((num & 0xff00) >> 8), (byte) ((num & 0xff0000) >> 0x10), (byte) ((num & 0xff000000L) >> 0x18) };
        A_0.Write(buffer, 0, 4);
        this.long_2 = A_0.Position;
        A_0.Write(BitConverter.GetBytes(this.uint_0), 0, 4);
        A_0.Write(BitConverter.GetBytes((int) this.long_0), 0, 4);
        A_0.Write(BitConverter.GetBytes((int) this.long_1), 0, 4);
        byte[] bytes = ((((short) (this.generalPurposeBitFlags_0 & GeneralPurposeBitFlags.Unicode)) != 0) ? Encoding.UTF8 : Encoding.Default).GetBytes(this.string_0);
        int length = bytes.Length;
        A_0.Write(BitConverter.GetBytes((short) length), 0, 2);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.Write(bytes, 0, bytes.Length);
    }

    private void method_32(Stream A_0)
    {
        long num2 = (this.stream_0 != null) ? this.stream_0.Length : 0L;
        if (num2 > 0L)
        {
            long position = A_0.Position;
            if (!this.bool_1 && (this.compressionMethod_0 != CompressionMethod.Stored))
            {
                if (this.compressionMethod_0 == CompressionMethod.Deflated)
                {
                    this.long_1 = num2;
                    this.stream_0.Position = 0L;
                    this.uint_0 = 0;
                    byte[] buffer = new byte[0x1000];
                    Stream stream = this.class771_0.delegate5_0(A_0);
                    while (num2 > 0L)
                    {
                        int count = this.stream_0.Read(buffer, 0, 0x1000);
                        stream.Write(buffer, 0, count);
                        num2 -= count;
                        this.uint_0 = Class1155.smethod_0(buffer, 0, count, this.uint_0);
                    }
                    stream.Close();
                }
            }
            else
            {
                this.stream_0.Position = 0L;
                byte[] buffer2 = new byte[0x1000];
                while (num2 > 0L)
                {
                    int num3 = this.stream_0.Read(buffer2, 0, 0x1000);
                    A_0.Write(buffer2, 0, num3);
                    num2 -= num3;
                    if ((this.compressionMethod_0 == CompressionMethod.Stored) && (this.uint_0 == 0))
                    {
                        this.uint_0 = Class1155.smethod_0(buffer2, 0, num3, this.uint_0);
                    }
                }
            }
            this.long_0 = A_0.Position - position;
        }
    }

    private void method_33(Stream A_0)
    {
        int num2 = 4;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔩夫娭䀯䜱䀳攵䰷䠹夻弽ⴿ", num2));
        }
        long position = A_0.Position;
        A_0.Position = this.long_2;
        A_0.Write(BitConverter.GetBytes(this.uint_0), 0, 4);
        A_0.Write(BitConverter.GetBytes((int) this.long_0), 0, 4);
        A_0.Write(BitConverter.GetBytes((int) this.long_1), 0, 4);
        A_0.Position = position;
    }

    private void method_34()
    {
        int num2 = 4;
        this.stream_0.Position = 0L;
        if (Class1155.smethod_1(this.stream_0, (int) this.long_1) != this.uint_0)
        {
            throw new Exception2(BookmarkStart.b("紩師䄭帯唱ᐳ电䨷夹᰻䠽ℿ⹁ㅃ⍅晇", num2));
        }
    }

    private void method_35(byte[] A_0)
    {
        int num2 = 8;
        if (Class1155.smethod_0(A_0, 0, (int) this.long_1, 0) != this.uint_0)
        {
            throw new Exception2(BookmarkStart.b("礭䈯崱娳儵ᠷ礹主崽怿㑁╃⩅㵇⽉手", num2));
        }
    }

    internal Class814 method_36()
    {
        Class814 class2 = (Class814) base.MemberwiseClone();
        class2.stream_0 = smethod_0(this.stream_0);
        return class2;
    }

    private bool method_37(string A_0)
    {
        int num = 10;
        if ((A_0 == null) || (A_0 == string.Empty))
        {
            throw new ArgumentException(BookmarkStart.b("嘯嬱堳匵瘷嬹儻嬽", num));
        }
        foreach (char ch in A_0.ToCharArray())
        {
            if (ch > '\x00ff')
            {
                return true;
            }
        }
        return false;
    }

    public CompressionLevel method_4()
    {
        return this.compressionLevel_0;
    }

    public void method_5(CompressionLevel A_0)
    {
        if (this.compressionLevel_0 != A_0)
        {
            if (this.bool_1)
            {
                this.method_27();
            }
            this.compressionLevel_0 = A_0;
        }
    }

    public uint method_6()
    {
        return this.uint_0;
    }

    public Stream method_7()
    {
        if (this.bool_1)
        {
            this.method_27();
        }
        return this.stream_0;
    }

    public long method_8()
    {
        return this.long_0;
    }

    public long method_9()
    {
        return this.long_1;
    }

    public static Stream smethod_0(Stream A_0)
    {
        int num;
        if (A_0 == null)
        {
            return null;
        }
        long position = A_0.Position;
        MemoryStream stream = new MemoryStream((int) A_0.Length);
        A_0.Position = 0L;
        byte[] buffer = new byte[0x8000];
        while ((num = A_0.Read(buffer, 0, 0x8000)) != 0)
        {
            stream.Write(buffer, 0, num);
        }
        A_0.Position = position;
        stream.Position = position;
        return stream;
    }

    void IDisposable.Dispose()
    {
        if (this.string_0 != null)
        {
            this.method_20();
            this.string_0 = null;
            GC.SuppressFinalize(this);
        }
    }

    void object.Finalize()
    {
        try
        {
            this.System.IDisposable.Dispose();
        }
        finally
        {
            base.Finalize();
        }
    }
}

