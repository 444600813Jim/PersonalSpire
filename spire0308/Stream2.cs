using System;
using System.IO;

internal class Stream2 : Stream1
{
    private Stream1 stream1_0;

    public Stream2(Stream1 A_0) : base(A_0.method_0())
    {
        this.stream1_0 = A_0;
    }

    void Stream.Dispose(bool A_0)
    {
        if (this.stream1_0 != null)
        {
            base.Dispose(A_0);
            this.stream1_0 = null;
            GC.SuppressFinalize(this);
        }
    }

    void Stream.Flush()
    {
        this.stream1_0.Flush();
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        return this.stream1_0.Read(A_0, A_1, A_2);
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        return this.stream1_0.Seek(A_0, A_1);
    }

    void Stream.SetLength(long A_0)
    {
        this.stream1_0.SetLength(A_0);
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        this.stream1_0.Write(A_0, A_1, A_2);
    }

    bool Stream.CanRead
    {
        get
        {
            return this.stream1_0.CanRead;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            return this.stream1_0.CanSeek;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            return this.stream1_0.CanWrite;
        }
    }

    long Stream.Length
    {
        get
        {
            return this.stream1_0.Length;
        }
    }

    long Stream.Position
    {
        get
        {
            return this.stream1_0.Position;
        }
        set
        {
            this.stream1_0.Position = value;
        }
    }
}

