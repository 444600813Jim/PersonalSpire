using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;
using System.IO;

internal class Class768
{
    private EscherRecordType escherRecordType_0;
    private int int_0;
    private int int_1;
    private int int_2;

    internal Class768()
    {
    }

    internal Class768(BinaryReader A_0)
    {
        this.method_0(A_0);
    }

    internal void method_0(BinaryReader A_0)
    {
        int num = A_0.ReadInt32();
        this.int_0 = num & 15;
        this.int_1 = (num & 0xfff0) >> 4;
        this.escherRecordType_0 = (EscherRecordType) ((int) ((num & 0xffff0000L) >> 0x10));
        this.int_2 = A_0.ReadInt32();
    }

    internal void method_1(BinaryWriter A_0)
    {
        int num = 0;
        num = 0 | this.int_0;
        num |= this.int_1 << 4;
        num |= ((int) this.escherRecordType_0) << 0x10;
        A_0.Write(num);
        A_0.Write(this.int_2);
    }

    internal int method_10()
    {
        return this.int_2;
    }

    internal void method_11(int A_0)
    {
        this.int_2 = A_0;
    }

    internal bool method_2()
    {
        return (this.int_0 == 15);
    }

    internal void method_3(bool A_0)
    {
        this.int_0 = A_0 ? 15 : 0;
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal void method_5(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_6()
    {
        return this.int_1;
    }

    internal void method_7(int A_0)
    {
        this.int_1 = A_0;
    }

    internal EscherRecordType method_8()
    {
        return this.escherRecordType_0;
    }

    internal void method_9(EscherRecordType A_0)
    {
        this.escherRecordType_0 = A_0;
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("焳䔵瀷弹崻娽┿ぁ桃晅᱇㍉㱋⭍橏⥑摓汕W❙灛繝㙟ݡᙣᕥŧթɫ呭୯䍱ॳ婵塷㍹ቻൽ낉벍뺑뒓\uda95\ufd97ﮛ좟颡\udfa3\u95a5햧", 14), new object[] { this.escherRecordType_0, this.int_0, this.int_1, this.int_2 });
    }
}

