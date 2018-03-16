using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

[CLSCompliant(false)]
internal class Class362
{
    private Class299 class299_0;
    private List<Class541> list_0;
    private string string_0;

    internal Class362()
    {
        this.list_0 = new List<Class541>();
        this.class299_0 = new Class299();
    }

    internal Class362(Stream A_0)
    {
        this.list_0 = new List<Class541>();
        this.class299_0 = new Class299();
        byte[] buffer = new byte[4];
        this.class299_0.method_1(A_0, buffer);
        int num = this.class299_0.method_1(A_0, buffer);
        for (int i = 0; i < num; i++)
        {
            Class541 item = new Class541(A_0);
            this.list_0.Add(item);
        }
        this.string_0 = this.class299_0.method_2(A_0);
    }

    internal List<Class541> method_0()
    {
        return this.list_0;
    }

    internal string method_1()
    {
        return this.string_0;
    }

    internal void method_2(string A_0)
    {
        this.string_0 = A_0;
    }

    internal void method_3(Stream A_0)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌯䘱䘳匵夷圹", num));
        }
        long position = A_0.Position;
        A_0.Position += 4L;
        int count = this.list_0.Count;
        this.class299_0.method_4(A_0, count);
        for (int i = 0; i < count; i++)
        {
            this.list_0[i].method_2(A_0);
        }
        this.class299_0.method_5(A_0, this.string_0);
        long num5 = A_0.Position;
        A_0.Position = position;
        this.class299_0.method_4(A_0, (int) (num5 - position));
        A_0.Position = num5;
    }
}

