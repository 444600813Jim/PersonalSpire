using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

[CLSCompliant(false)]
internal class Class876
{
    private Class299 class299_0;
    private const int int_0 = 8;
    private int int_1;
    private List<Class362> list_0;

    internal Class876()
    {
        this.int_1 = 8;
        this.list_0 = new List<Class362>();
        this.class299_0 = new Class299();
    }

    internal Class876(Stream A_0)
    {
        int num3 = 9;
        this.int_1 = 8;
        this.list_0 = new List<Class362>();
        this.class299_0 = new Class299();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尮䔰䄲倴嘶吸", num3));
        }
        byte[] buffer = new byte[4];
        this.int_1 = this.class299_0.method_1(A_0, buffer);
        int num = this.class299_0.method_1(A_0, buffer);
        if (this.list_0.Capacity < num)
        {
            this.list_0.Capacity = num;
        }
        if (this.int_1 != 8)
        {
            A_0.Position += this.int_1 - 8;
        }
        for (int i = 0; i < num; i++)
        {
            Class362 item = new Class362(A_0);
            this.list_0.Add(item);
        }
    }

    internal List<Class362> method_0()
    {
        return this.list_0;
    }

    internal void method_1(Stream A_0)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堪夬崮吰刲場", num));
        }
        this.class299_0.method_4(A_0, this.int_1);
        int count = this.list_0.Count;
        this.class299_0.method_4(A_0, count);
        for (int i = 0; i < count; i++)
        {
            this.list_0[i].method_3(A_0);
        }
    }
}

