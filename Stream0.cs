using Spire.Compression;
using Spire.Compression.Zip;
using Spire.Doc;
using System;
using System.IO;

internal class Stream0 : Stream, IDisposable
{
    private bool bool_0;
    internal Stream9 stream9_0;

    public Stream0(Stream A_0, CompressionMode A_1) : this(A_0, A_1, CompressionLevel.Normal, false)
    {
    }

    public Stream0(Stream A_0, CompressionMode A_1, CompressionLevel A_2) : this(A_0, A_1, A_2, false)
    {
    }

    public Stream0(Stream A_0, CompressionMode A_1, bool A_2) : this(A_0, A_1, CompressionLevel.Normal, A_2)
    {
    }

    public Stream0(Stream A_0, CompressionMode A_1, CompressionLevel A_2, bool A_3)
    {
        this.stream9_0 = new Stream9(A_0, A_1, A_2, ZlibStreamFlavor.DEFLATE, A_3);
    }

    public int method_0()
    {
        return this.stream9_0.int_0;
    }

    public void method_1(int A_0)
    {
        int num = 6;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("栫䬭嘯帱唳䈵崷椹䠻䰽┿⍁⥃", num));
        }
        if (this.stream9_0.byte_0 != null)
        {
            throw new Exception0(BookmarkStart.b("砫䘭唯ሱ䌳夵䨷儹唻倽✿扁♃㍅⹇ⱉ⥋㱍灏㭑❓癕㥗㙙⹛㭝ş١ᵣ䙥᭧ཀྵᡫ䁭", num));
        }
        if (A_0 < 0x80)
        {
            throw new Exception0(string.Format(BookmarkStart.b("栫䄭帯ᔱ䀳ᘵ娷弹᰻䴽⤿⹁⡃㽅晇橉㝋繍ⵏ牑㙓⽕ⱗ㽙⽛慝彟䉡ㅣᕥ൧䩩൫乭ቯ᭱፳ᅵᵷࡹ屻ᱽ慎ꒉ", num), A_0));
        }
        this.stream9_0.int_0 = A_0;
    }

    public CompressionStrategy method_2()
    {
        return this.stream9_0.compressionStrategy_0;
    }

    public void method_3(CompressionStrategy A_0)
    {
        int num = 7;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("椬䨮地弲吴䌶尸栺䤼䴾⑀≂⡄", num));
        }
        this.stream9_0.compressionStrategy_0 = A_0;
    }

    public static byte[] smethod_0(string A_0)
    {
        return Stream9.smethod_0(A_0, typeof(Stream0));
    }

    public static byte[] smethod_1(byte[] A_0)
    {
        return Stream9.smethod_2(A_0, typeof(Stream0));
    }

    public static string smethod_2(byte[] A_0)
    {
        return Stream9.smethod_1(A_0, typeof(Stream0));
    }

    public static byte[] smethod_3(byte[] A_0)
    {
        return Stream9.smethod_3(A_0, typeof(Stream0));
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
        int num = 9;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("欮吰唲头嘶䴸帺渼䬾㍀♂⑄⩆", num));
        }
        this.stream9_0.Flush();
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        int num = 15;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("焴制弸场尼䬾⑀၂ㅄ㕆ⱈ⩊⁌", num));
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
        int num = 8;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("樭唯吱堳圵䰷弹漻䨽㈿❁╃⭅", num));
        }
        this.stream9_0.Write(A_0, A_1, A_2);
    }

    public virtual FlushType vmethod_0()
    {
        return this.stream9_0.flushType_0;
    }

    public virtual void vmethod_1(FlushType A_0)
    {
        int num = 1;
        if (this.bool_0)
        {
            throw new ObjectDisposedException(BookmarkStart.b("挦䰨䴪䄬丮䔰嘲昴䌶䬸帺尼刾", num));
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
            int num = 0x13;
            if (this.bool_0)
            {
                throw new ObjectDisposedException(BookmarkStart.b("紸帺嬼匾⁀㝂⁄ᑆ㵈㥊⡌⹎㱐", num));
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
            int num = 4;
            if (this.bool_0)
            {
                throw new ObjectDisposedException(BookmarkStart.b("温䤫䠭尯匱䀳匵欷丹主嬽ℿ⽁", num));
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

