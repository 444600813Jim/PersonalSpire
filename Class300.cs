using System;
using System.Collections.Generic;
using System.IO;

[CLSCompliant(false)]
internal class Class300
{
    private Class299 class299_0;
    private const int int_0 = 8;
    private int int_1;
    private List<string> list_0;

    internal Class300()
    {
        this.int_1 = 8;
        this.list_0 = new List<string>();
        this.class299_0 = new Class299();
    }

    internal Class300(Stream A_0)
    {
        this.int_1 = 8;
        this.list_0 = new List<string>();
        this.class299_0 = new Class299();
        byte[] buffer = new byte[4];
        this.int_1 = this.class299_0.method_1(A_0, buffer);
        int num = this.class299_0.method_1(A_0, buffer);
        if (this.int_1 != 8)
        {
            A_0.Position += this.int_1 - 8;
        }
        for (int i = 0; i < num; i++)
        {
            string item = this.class299_0.method_2(A_0);
            this.list_0.Add(item);
        }
    }

    internal List<string> method_0()
    {
        return this.list_0;
    }

    internal void method_1(Stream A_0)
    {
        this.class299_0.method_4(A_0, this.int_1);
        int count = this.list_0.Count;
        this.class299_0.method_4(A_0, count);
        for (int i = 0; i < count; i++)
        {
            string str = this.list_0[i];
            this.class299_0.method_5(A_0, str);
        }
    }
}

