using System;
using System.Collections;
using System.IO;

internal class Class296
{
    private readonly Class771 class771_0 = new Class771();
    private readonly IEnumerator ienumerator_0;

    public Class296(Stream A_0)
    {
        this.class771_0.method_27(A_0, false);
        this.ienumerator_0 = ((IEnumerable) this.class771_0).GetEnumerator();
    }

    public string method_0()
    {
        return this.method_1().method_0();
    }

    private Class814 method_1()
    {
        return (Class814) this.ienumerator_0.Current;
    }

    public bool method_2()
    {
        return this.ienumerator_0.MoveNext();
    }

    public MemoryStream method_3()
    {
        MemoryStream stream = new MemoryStream();
        this.method_4(stream);
        stream.Position = 0L;
        return stream;
    }

    public void method_4(Stream A_0)
    {
        this.method_1().method_19(A_0);
    }

    public void method_5(Stream A_0)
    {
        long length = this.method_1().method_7().Length;
        byte[] buffer = new byte[length];
        this.method_1().method_7().Position = 0L;
        this.method_1().method_7().Read(buffer, 0, (int) length);
        A_0.Write(buffer, 0, (int) length);
        buffer = null;
    }
}

