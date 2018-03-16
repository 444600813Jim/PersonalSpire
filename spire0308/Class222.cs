using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal abstract class Class222
{
    internal static bool bool_0;
    private byte[] byte_0;
    private Class728 class728_0;
    private Interface57 interface57_0;

    internal Class222()
    {
        this.class728_0 = new Class728();
    }

    internal Class222(EsRecordType A_0, int A_1) : this()
    {
        this.class728_0.method_9(A_0);
        this.class728_0.method_5(A_1);
    }

    internal void method_0(BinaryReader A_0, Interface57 A_1)
    {
        this.method_1(new Class728(A_0), A_0, A_1);
    }

    internal void method_1(Class728 A_0, BinaryReader A_1, Interface57 A_2)
    {
        this.class728_0 = A_0;
        this.interface57_0 = A_2;
        int position = (int) A_1.BaseStream.Position;
        this.vmethod_0(A_1);
        long num1 = A_1.BaseStream.Position;
        if (bool_0)
        {
            A_1.BaseStream.Position = position;
            this.byte_0 = A_1.ReadBytes(this.class728_0.method_10());
        }
    }

    internal int method_2(BinaryWriter A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        this.method_3().method_1(A_0);
        int num2 = (int) A_0.BaseStream.Position;
        this.vmethod_1(A_0);
        int num3 = (int) A_0.BaseStream.Position;
        this.method_3().method_11(num3 - num2);
        A_0.BaseStream.Seek((long) position, SeekOrigin.Begin);
        this.method_3().method_1(A_0);
        A_0.BaseStream.Seek((long) num3, SeekOrigin.Begin);
        return (num3 - position);
    }

    internal Class728 method_3()
    {
        return this.class728_0;
    }

    protected void method_4(WarningTypeCore A_0, string A_1)
    {
    }

    protected Interface57 method_5()
    {
        return this.interface57_0;
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("嘬Ἦ䰰ἲᔴ缶尸娺夼娾㍀祂㹄癆㑈杊浌୎ぐ❒㑔浖≘楚⁜", 7), base.GetType().Name, this.class728_0.ToString(), Class85.smethod_4(this.byte_0));
    }

    protected abstract void vmethod_0(BinaryReader A_0);
    protected abstract void vmethod_1(BinaryWriter A_0);
}

