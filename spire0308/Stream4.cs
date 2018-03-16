using System;
using System.IO;

internal class Stream4 : Stream3, Interface59
{
    private const int int_0 = 0x8000;
    private long long_0;

    public Stream4(Class1004 A_0, Class297 A_1) : base(A_0, A_1)
    {
    }

    public override void imethod_1()
    {
        if (base.method_2() != null)
        {
            base.imethod_1();
        }
    }

    public override long System.IO.Stream.get_Length()
    {
        if (base.method_2() == null)
        {
            return (long) base.Interface59.imethod_0().method_22();
        }
        return base.method_2().Length;
    }

    public override long System.IO.Stream.get_Position()
    {
        return this.long_0;
    }

    public override int System.IO.Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        int num;
        if (base.method_2() != null)
        {
            num = base.System.IO.Stream.Read(A_0, A_1, A_2);
        }
        else
        {
            num = base.method_4().method_19(base.Interface59.imethod_0(), this.long_0, A_0, A_2);
        }
        this.long_0 += num;
        return num;
    }

    public override long System.IO.Stream.Seek(long A_0, SeekOrigin A_1)
    {
        if (base.method_2() != null)
        {
            base.method_2().Seek(A_0, A_1);
        }
        switch (A_1)
        {
            case SeekOrigin.Begin:
                this.long_0 = A_0;
                break;

            case SeekOrigin.Current:
                this.long_0 += A_0;
                break;

            case SeekOrigin.End:
                this.long_0 = base.Interface59.imethod_0().method_22() + A_0;
                break;
        }
        return this.long_0;
    }

    public override void System.IO.Stream.set_Position(long A_0)
    {
        this.long_0 = A_0;
        if (base.method_2() != null)
        {
            base.method_2().Position = A_0;
        }
    }

    public override void System.IO.Stream.SetLength(long A_0)
    {
        if (base.method_2() != null)
        {
            base.System.IO.Stream.SetLength(A_0);
        }
        base.Interface59.imethod_0().method_23((uint) A_0);
    }

    public override void System.IO.Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        if (base.method_2() == null)
        {
            base.method_4().method_20(base.Interface59.imethod_0(), this.long_0, A_0, A_1, A_2);
        }
        else
        {
            base.System.IO.Stream.Write(A_0, A_1, A_2);
            if (base.method_2().Length > 0x8000L)
            {
                base.method_4().method_11(base.Interface59.imethod_0(), base.method_2());
                base.method_3(null);
            }
        }
        this.long_0 += A_2;
    }

    public override void vmethod_1()
    {
        if (base.Interface59.imethod_0().method_22() < 0x8000)
        {
            base.vmethod_1();
        }
        this.long_0 = 0L;
    }
}

