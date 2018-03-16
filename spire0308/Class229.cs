using System;
using System.IO;

internal class Class229 : IDisposable
{
    protected Stream stream_0;
    protected string string_0;
    protected string string_1;
    protected string string_2;
    protected string string_3;

    public Class229(Stream A_0)
    {
        if (A_0 == null)
        {
            this.stream_0 = new MemoryStream();
        }
        else
        {
            byte[] buffer = new byte[A_0.Length];
            A_0.Position = 0L;
            A_0.Read(buffer, 0, (int) A_0.Length);
            this.stream_0 = new MemoryStream(buffer);
            buffer = null;
        }
    }

    internal string method_0()
    {
        return this.string_1;
    }

    internal void method_1(string A_0)
    {
        this.string_1 = A_0;
    }

    internal string method_2()
    {
        return this.string_2;
    }

    internal void method_3(string A_0)
    {
        this.string_2 = A_0;
    }

    internal Stream method_4()
    {
        return this.stream_0;
    }

    internal string method_5()
    {
        return this.string_3;
    }

    internal void method_6(string A_0)
    {
        this.string_3 = A_0;
    }

    internal string method_7()
    {
        return this.string_0;
    }

    internal void method_8(string A_0)
    {
        this.string_0 = A_0;
    }

    internal Class229 method_9()
    {
        Class229 class2 = new Class229(this.stream_0);
        class2.method_8(this.string_0);
        return class2;
    }

    void IDisposable.Dispose()
    {
        if (this.stream_0 != null)
        {
            this.stream_0.Dispose();
            this.stream_0 = null;
        }
        this.string_0 = null;
    }
}

