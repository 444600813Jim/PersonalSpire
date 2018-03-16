using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Formatting;
using System;
using System.IO;

internal class Class1109 : Interface15
{
    private Class1150 class1150_0;
    private readonly Class141 class141_0;
    private readonly Class143 class143_0;
    private readonly Class479 class479_0;
    private Class764 class764_0;
    private ParagraphFormat paragraphFormat_0;
    private RowFormat rowFormat_0;

    internal Class1109(BinaryReader A_0, Class812 A_1, NFibEnum A_2, Class764 A_3)
    {
        this.class764_0 = A_3;
        this.class479_0 = new Class479(this, A_0);
        this.class141_0 = new Class141(A_0, A_1);
        this.class143_0 = new Class143(A_0, A_1, A_2);
    }

    private bool imethod_0(SprmCode A_0, SprmType A_1, int A_2, BinaryReader A_3)
    {
        SprmType type = A_1;
        if (type == SprmType.Pap)
        {
            return this.class141_0.imethod_0(A_0, A_1, A_2, A_3);
        }
        if (type != SprmType.Tap)
        {
            return true;
        }
        if (this.rowFormat_0 == null)
        {
            this.rowFormat_0 = new RowFormat(this.class764_0.method_42());
            this.rowFormat_0.SetAttr(0x1090, LayoutType.Fixed);
            this.class143_0.method_64(this.rowFormat_0, this.class1150_0.int_0);
        }
        return this.class143_0.imethod_0(A_0, A_1, A_2, A_3);
    }

    internal void method_0(Class430 A_0, byte[] A_1, Document A_2)
    {
        this.paragraphFormat_0 = new ParagraphFormat(A_2);
        this.class1150_0 = new Class1150();
        this.rowFormat_0 = null;
        this.class141_0.method_67(this.paragraphFormat_0, this.class1150_0);
        this.paragraphFormat_0.SetAttr(0x3e8, A_0.method_6());
        this.class479_0.method_1(A_0.method_2());
        this.class479_0.method_1(A_1);
        if (this.rowFormat_0 != null)
        {
            this.class143_0.method_65();
        }
        this.class141_0.method_68();
    }

    internal ParagraphFormat method_1()
    {
        return this.paragraphFormat_0;
    }

    internal Class1150 method_2()
    {
        return this.class1150_0;
    }

    internal RowFormat method_3()
    {
        return this.rowFormat_0;
    }
}

