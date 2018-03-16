using Spire.Doc.Documents.Converters.BinaryDoc.Markup;
using System;
using System.Collections;
using System.IO;

internal class Class702
{
    private readonly ArrayList arrayList_0;
    private const int int_0 = 12;
    private readonly int int_1;
    private readonly int int_2;
    private readonly int int_3;
    private readonly Sdtt sdtt_0;
    private readonly string string_0;

    internal Class702(BinaryReader A_0)
    {
        this.arrayList_0 = new ArrayList();
        A_0.ReadInt16();
        this.int_3 = A_0.ReadInt32();
        this.int_1 = A_0.ReadInt32();
        this.int_2 = A_0.ReadInt32();
        this.sdtt_0 = (Sdtt) A_0.ReadInt32();
        int num = A_0.ReadInt32();
        int num2 = A_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            this.arrayList_0.Add(new Class167(A_0));
        }
        if (num2 > 0)
        {
            this.string_0 = Class813.smethod_5(A_0, num2);
        }
    }

    internal Class702(Sdtt A_0, int A_1, int A_2, string A_3)
    {
        this.arrayList_0 = new ArrayList();
        this.sdtt_0 = A_0;
        this.int_1 = A_1;
        this.int_2 = A_2;
        this.string_0 = A_3;
    }

    internal void method_0(BinaryWriter A_0, int A_1)
    {
        A_0.Write((short) 12);
        A_0.Write(A_1);
        A_0.Write(this.int_1);
        A_0.Write(this.int_2);
        A_0.Write((int) this.method_1());
        A_0.Write(this.arrayList_0.Count);
        A_0.Write(Class567.smethod_16(this.string_0) ? ((this.string_0.Length * 2) + 2) : 0);
        foreach (Class167 class2 in this.arrayList_0)
        {
            class2.method_0(A_0);
        }
        if (Class567.smethod_16(this.string_0))
        {
            Class813.smethod_8(this.string_0, A_0);
        }
    }

    internal Sdtt method_1()
    {
        return this.sdtt_0;
    }

    internal int method_2()
    {
        return this.int_1;
    }

    internal int method_3()
    {
        return this.int_2;
    }

    internal string method_4()
    {
        if (!Class567.smethod_16(this.string_0))
        {
            return "";
        }
        return this.string_0;
    }

    internal ArrayList method_5()
    {
        return this.arrayList_0;
    }

    internal int method_6()
    {
        return this.int_3;
    }
}

