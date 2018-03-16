using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class1003
{
    private List<Class297> list_0;

    public Class1003()
    {
        this.list_0 = new List<Class297>();
    }

    public Class1003(byte[] A_0)
    {
        int num4 = 10;
        this.list_0 = new List<Class297>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("启匱䀳圵", num4));
        }
        int num = 0;
        int length = A_0.Length;
        this.list_0 = new List<Class297>();
        for (int i = 0; num < length; i++)
        {
            this.list_0.Add(new Class297(A_0, num, i));
            num += 0x80;
        }
    }

    public List<Class297> method_0()
    {
        return this.list_0;
    }

    public int method_1()
    {
        int num2 = 0;
        int count = this.list_0.Count;
        while (num2 < count)
        {
            Class297 class2 = this.list_0[num2];
            if (class2.method_2() == Class297.EntryType.Invalid)
            {
                return num2;
            }
            num2++;
        }
        return -1;
    }

    internal void method_2(Class297 A_0)
    {
        int num = this.method_1();
        if (num >= 0)
        {
            this.list_0[num] = A_0;
            A_0.method_27(num);
        }
        else
        {
            this.list_0.Add(A_0);
        }
    }

    public void method_3(Stream A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弫娭䈯圱唳嬵", num));
        }
        int num2 = 0;
        int count = this.list_0.Count;
        while (num2 < count)
        {
            this.list_0[num2].method_28(A_0);
            num2++;
        }
    }
}

