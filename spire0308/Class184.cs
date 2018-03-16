using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class184
{
    private static readonly Guid guid_0 = new Guid(BookmarkStart.b("帷࠹Ի堽砿睁⅃癅敇繉⩋⡍楏网敓晕湗扙煛㽝ɟ孡啣䭥塧剩屫幭䉯ၱ䙳䅵᩷䥹᡻䝽", 0x12));
    private const int int_0 = 0xfffe;
    private int int_1;
    private List<Class663> list_0;

    public Class184()
    {
        this.int_1 = -1;
        this.list_0 = new List<Class663>();
    }

    public Class184(Stream A_0)
    {
        int num = 9;
        this.int_1 = -1;
        this.list_0 = new List<Class663>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尮䔰䄲倴嘶吸", num));
        }
        A_0.Position = 0L;
        this.method_2(A_0);
        this.method_1(A_0);
    }

    public List<Class663> method_0()
    {
        return this.list_0;
    }

    private void method_1(Stream A_0)
    {
        int num = 0;
        int count = this.list_0.Count;
        while (num < count)
        {
            this.list_0[num].method_8(A_0);
            num++;
        }
    }

    private void method_2(Stream A_0)
    {
        byte[] buffer = new byte[0x10];
        A_0.Read(buffer, 0, 4);
        if (BitConverter.ToInt32(buffer, 0) != 0xfffe)
        {
            throw new IOException();
        }
        A_0.Read(buffer, 0, 2);
        A_0.Read(buffer, 0, 2);
        A_0.Read(buffer, 0, 0x10);
        A_0.Read(buffer, 0, 4);
        int num4 = BitConverter.ToInt32(buffer, 0);
        for (int i = 0; i < num4; i++)
        {
            A_0.Read(buffer, 0, 0x10);
            Guid guid = new Guid(buffer);
            int num2 = Class1115.smethod_1(A_0, buffer);
            this.list_0.Add(new Class663(guid, num2));
        }
    }

    private void method_3(Stream A_0)
    {
        int num = 0;
        int count = this.list_0.Count;
        while (num < count)
        {
            this.list_0[num].method_11(A_0);
            num++;
        }
    }

    private void method_4(Stream A_0)
    {
        Class1115.smethod_4(A_0, 0xfffe);
        Class1115.smethod_3(A_0, 0x105);
        Class1115.smethod_3(A_0, 2);
        for (int i = 0; i < 0x10; i++)
        {
            A_0.WriteByte(0);
        }
        int count = this.list_0.Count;
        Class1115.smethod_4(A_0, count);
        List<long> list = new List<long>();
        for (int j = 0; j < count; j++)
        {
            Class663 class3 = this.list_0[j];
            byte[] buffer = class3.method_2().ToByteArray();
            A_0.Write(buffer, 0, buffer.Length);
            list.Add(A_0.Position);
            Class1115.smethod_4(A_0, 0);
        }
        for (int k = 0; k < count; k++)
        {
            Class663 class2 = this.list_0[k];
            long position = A_0.Position;
            A_0.Position = list[k];
            Class1115.smethod_4(A_0, (int) position);
            A_0.Position = position;
            class2.method_11(A_0);
        }
    }

    public void method_5(Stream A_0)
    {
        this.method_4(A_0);
    }
}

