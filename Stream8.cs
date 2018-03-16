using Spire.Compression;
using Spire.Compression.Zip;
using Spire.Doc;
using System;
using System.IO;

internal class Stream8 : Stream, IDisposable
{
    private bool bool_0;
    internal Stream9 stream9_0;

    public Stream8(Stream A_0, CompressionMode A_1) : this(A_0, A_1, CompressionLevel.Normal, false)
    {
    }

    public Stream8(Stream A_0, CompressionMode A_1, CompressionLevel A_2) : this(A_0, A_1, A_2, false)
    {
    }

    public Stream8(Stream A_0, CompressionMode A_1, bool A_2) : this(A_0, A_1, CompressionLevel.Normal, A_2)
    {
    }

    public Stream8(Stream A_0, CompressionMode A_1, CompressionLevel A_2, bool A_3)
    {
        this.stream9_0 = new Stream9(A_0, A_1, A_2, ZlibStreamFlavor.ZLIB, A_3);
    }

    public int method_0()
    {
        return this.stream9_0.int_0;
    }

    public void method_1(int A_0)
    {
        int num = 14;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("渳娵儷堹漻䨽㈿❁╃⭅", num));
        }
        if (this.stream9_0.byte_0 != null)
        {
            throw new Exception0(BookmarkStart.b("怳帵崷ᨹ䬻儽㈿⥁ⵃ⡅⽇橉⹋㭍㙏㑑ㅓ⑕硗㍙⽛繝ş๡ᙣͥ१๩ᕫ乭ͯ᝱s塵", num));
        }
        if (A_0 < 0x80)
        {
            throw new Exception0(string.Format(BookmarkStart.b("瀳夵嘷ᴹ䠻ḽ∿❁摃㕅ⅇ♉⁋㝍繏牑⽓晕╗穙㹛❝ᑟݡᝣ奥坧䩩㥫ᵭᕯ剱ᕳ噵᩷፹᭻᥽ꒃﶇ벑", num), A_0));
        }
        this.stream9_0.int_0 = A_0;
    }

    public void method_2()
    {
        this.stream9_0.method_4();
    }

    public static byte[] smethod_0(string A_0)
    {
        return Stream9.smethod_0(A_0, typeof(Stream8));
    }

    public static byte[] smethod_1(byte[] A_0)
    {
        return Stream9.smethod_2(A_0, typeof(Stream8));
    }

    public static string smethod_2(byte[] A_0)
    {
        return Stream9.smethod_1(A_0, typeof(Stream8));
    }

    public static byte[] smethod_3(byte[] A_0)
    {
        return Stream9.smethod_3(A_0, typeof(Stream8));
    }

    void IDisposable.Dispose()
    {
        this.vmethod_4(true);
        GC.SuppressFinalize(this);
    }

    void Stream.Close()
    {
        this.vmethod_4(true);
        GC.SuppressFinalize(this);
    }

    void Stream.Flush()
    {
        int num = 2;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("爧䘩䔫䰭振䘱䘳匵夷圹", num));
        }
        this.stream9_0.Flush();
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        int num = 2;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("爧䘩䔫䰭振䘱䘳匵夷圹", num));
        }
        return this.stream9_0.Read(A_0, A_1, A_2);
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        throw new NotImplementedException();
    }

    void Stream.SetLength(long A_0)
    {
        throw new NotImplementedException();
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        int num = 5;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("焪䄬䘮匰怲䄴䔶尸娺值", num));
        }
        this.stream9_0.Write(A_0, A_1, A_2);
    }

    public virtual FlushType vmethod_0()
    {
        return this.stream9_0.flushType_0;
    }

    public virtual void vmethod_1(FlushType A_0)
    {
        int num = 0x12;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("户嘹唻尽ጿ㙁㙃⍅⥇❉", num));
        }
        this.stream9_0.flushType_0 = A_0;
    }

    public virtual long vmethod_2()
    {
        return this.stream9_0.class1068_0.long_0;
    }

    public virtual long vmethod_3()
    {
        return this.stream9_0.class1068_0.long_1;
    }

    protected virtual void vmethod_4(bool A_0)
    {
        if (!this.bool_0)
        {
            if (A_0 && (this.stream9_0 != null))
            {
                this.stream9_0.Close();
            }
            this.bool_0 = true;
        }
    }

    bool Stream.CanRead
    {
        get
        {
            int num = 7;
            if (this.bool_0)
            {
                throw new ObjectDisposedException(BookmarkStart.b("眬䌮堰儲昴䌶䬸帺尼刾", num));
            }
            return this.stream9_0.stream_0.CanRead;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            return false;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            int num = 12;
            if (this.bool_0)
            {
                throw new ObjectDisposedException(BookmarkStart.b("栱堳張娷椹䠻䰽┿⍁⥃", num));
            }
            return this.stream9_0.stream_0.CanWrite;
        }
    }

    long Stream.Length
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    long Stream.Position
    {
        get
        {
            if (this.stream9_0.streamMode_0 == Stream9.StreamMode.Writer)
            {
                return this.stream9_0.class1068_0.long_1;
            }
            if (this.stream9_0.streamMode_0 == Stream9.StreamMode.Reader)
            {
                return this.stream9_0.class1068_0.long_0;
            }
            return 0L;
        }
        set
        {
            throw new NotImplementedException();
        }
    }
}

