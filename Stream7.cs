using Spire.Doc;
using System;
using System.IO;

internal class Stream7 : Stream, IDisposable
{
    private bool bool_0;
    private readonly Class356 class356_0;
    private static readonly long long_0 = -99L;
    private readonly long long_1;
    private readonly Stream stream_0;

    public Stream7(Stream A_0) : this(true, long_0, A_0)
    {
    }

    public Stream7(Stream A_0, bool A_1) : this(A_1, long_0, A_0)
    {
    }

    public Stream7(Stream A_0, long A_1) : this(true, A_1, A_0)
    {
        int num = 13;
        if (A_1 < 0L)
        {
            throw new ArgumentException(BookmarkStart.b("弲倴夶常伺唼", num));
        }
    }

    private Stream7(bool A_0, long A_1, Stream A_2)
    {
        this.long_1 = -99L;
        this.stream_0 = A_2;
        this.class356_0 = new Class356();
        this.long_1 = A_1;
        this.bool_0 = A_0;
    }

    public Stream7(Stream A_0, long A_1, bool A_2) : this(A_2, A_1, A_0)
    {
        int num = 0x10;
        if (A_1 < 0L)
        {
            throw new ArgumentException(BookmarkStart.b("娵崷吹嬻䨽⠿", num));
        }
    }

    public long method_0()
    {
        return this.class356_0.method_0();
    }

    public int method_1()
    {
        return this.class356_0.method_1();
    }

    public bool method_2()
    {
        return this.bool_0;
    }

    public void method_3(bool A_0)
    {
        this.bool_0 = A_0;
    }

    void IDisposable.Dispose()
    {
        this.Close();
    }

    void Stream.Close()
    {
        base.Close();
        if (!this.bool_0)
        {
            this.stream_0.Close();
        }
    }

    void Stream.Flush()
    {
        this.stream_0.Flush();
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        int count = A_2;
        if (this.long_1 != long_0)
        {
            if (this.class356_0.method_0() >= this.long_1)
            {
                return 0;
            }
            long num3 = this.long_1 - this.class356_0.method_0();
            if (num3 < A_2)
            {
                count = (int) num3;
            }
        }
        int num2 = this.stream_0.Read(A_0, A_1, count);
        if (num2 > 0)
        {
            this.class356_0.method_6(A_0, A_1, num2);
        }
        return num2;
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
        if (A_2 > 0)
        {
            this.class356_0.method_6(A_0, A_1, A_2);
        }
        this.stream_0.Write(A_0, A_1, A_2);
    }

    bool Stream.CanRead
    {
        get
        {
            return this.stream_0.CanRead;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            return this.stream_0.CanSeek;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            return this.stream_0.CanWrite;
        }
    }

    long Stream.Length
    {
        get
        {
            if (this.long_1 == long_0)
            {
                return this.stream_0.Length;
            }
            return this.long_1;
        }
    }

    long Stream.Position
    {
        get
        {
            return this.class356_0.method_0();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
}

