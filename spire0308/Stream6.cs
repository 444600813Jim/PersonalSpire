using Spire.Compression;
using System;
using System.IO;

internal class Stream6 : Stream
{
    private Class1113 class1113_0;

    public Stream6(CompressionLevel A_0, Stream A_1)
    {
        this.class1113_0 = new Class1113(A_1, true, A_0, false);
    }

    public void method_0(byte[] A_0, int A_1, bool A_2)
    {
        this.class1113_0.method_0(A_0, 0, A_1, A_2);
    }

    void Stream.Close()
    {
        this.class1113_0.method_1();
        base.Close();
    }

    void Stream.Flush()
    {
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        throw new NotImplementedException();
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
        this.class1113_0.method_0(A_0, A_1, A_2, false);
    }

    bool Stream.CanRead
    {
        get
        {
            return false;
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
            return true;
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
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
}

