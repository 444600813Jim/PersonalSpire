using Spire.Doc;
using System;
using System.IO;

internal class Stream3 : Stream1, Interface59
{
    private Class1004 class1004_0;
    private Class297 class297_0;
    private Stream stream_0;

    public Stream3(Class1004 A_0, Class297 A_1) : base(A_1.method_0())
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("吱崳娵崷", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("圱娳䈵䨷䌹", num));
        }
        if (A_1.method_2() != Class297.EntryType.Stream)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("圱娳䈵䨷䌹", num));
        }
        this.class1004_0 = A_0;
        this.class297_0 = A_1;
    }

    public override void imethod_1()
    {
        if (this.stream_0 != null)
        {
            this.class1004_0.method_11(this.class297_0, this.stream_0);
        }
    }

    Class297 Interface59.imethod_0()
    {
        return this.class297_0;
    }

    protected Stream method_2()
    {
        return this.stream_0;
    }

    protected void method_3(Stream A_0)
    {
        this.stream_0 = A_0;
    }

    public Class1004 method_4()
    {
        return this.class1004_0;
    }

    void Stream.Close()
    {
        this.Flush();
        this.stream_0.Dispose();
        this.stream_0 = null;
    }

    void Stream.Dispose(bool A_0)
    {
        if (this.stream_0 != null)
        {
            base.Dispose(A_0);
            this.stream_0.Dispose();
            this.stream_0 = null;
            this.class1004_0 = null;
            this.class297_0 = null;
            GC.SuppressFinalize(this);
        }
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        return this.stream_0.Read(A_0, A_1, A_2);
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        return this.stream_0.Seek(A_0, A_1);
    }

    void Stream.SetLength(long A_0)
    {
        this.stream_0.SetLength(A_0);
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        this.stream_0.Write(A_0, A_1, A_2);
    }

    public virtual void vmethod_1()
    {
        if (this.stream_0 == null)
        {
            this.stream_0 = this.class1004_0.method_10(this.class297_0);
        }
    }

    bool Stream.CanRead
    {
        get
        {
            return true;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            return true;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            return true;
        }
    }

    [__DynamicallyInvokable]
    long Stream.Length
    {
        get
        {
            if (this.stream_0 == null)
            {
                return (long) this.class297_0.method_22();
            }
            return this.stream_0.Length;
        }
    }

    [__DynamicallyInvokable]
    long Stream.Position
    {
        get
        {
            return this.stream_0.Position;
        }
        set
        {
            this.stream_0.Position = value;
        }
    }
}

