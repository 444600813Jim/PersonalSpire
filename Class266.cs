using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;
using System.IO;

internal abstract class Class266
{
    internal static bool bool_0;
    private byte[] byte_0;
    private Class768 class768_0;

    internal Class266()
    {
        this.class768_0 = new Class768();
    }

    internal Class266(EscherRecordType A_0, int A_1) : this()
    {
        this.class768_0.method_9(A_0);
        this.class768_0.method_5(A_1);
    }

    internal void method_0(BinaryReader A_0)
    {
        this.method_1(new Class768(A_0), A_0);
    }

    internal void method_1(Class768 A_0, BinaryReader A_1)
    {
        this.class768_0 = A_0;
        int position = (int) A_1.BaseStream.Position;
        this.vmethod_0(A_1);
        long num1 = A_1.BaseStream.Position;
        if (bool_0)
        {
            A_1.BaseStream.Position = position;
            this.byte_0 = A_1.ReadBytes(this.class768_0.method_10());
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

    internal Class768 method_3()
    {
        return this.class768_0;
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("圫ḭ䴯ḱᐳ縵崷嬹堻嬽㈿硁㽃睅㕇晉汋੍ㅏ♑㕓汕⍗桙⅛", 6), base.GetType().Name, this.class768_0.ToString(), Class85.smethod_4(this.byte_0));
    }

    protected abstract void vmethod_0(BinaryReader A_0);
    protected abstract void vmethod_1(BinaryWriter A_0);
}

