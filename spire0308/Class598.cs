using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.Collections;
using System.IO;

internal class Class598 : Interface16
{
    private readonly BinaryReader binaryReader_0;
    private Hashtable hashtable_0;
    private readonly Hashtable hashtable_1 = new Hashtable();

    internal Class598(Class703 A_0, BinaryReader A_1)
    {
        this.binaryReader_0 = A_1;
        this.method_1(SubDocumentType.Main, A_0.class597_0.class1111_16, BookmarkStart.b("瘥䐧䤩䨫栭尯嘱礳夵唷", 0));
        this.method_1(SubDocumentType.Header, A_0.class597_0.class1111_17, BookmarkStart.b("瘥䐧䤩䨫栭尯嘱簳刵䨷", 0));
        this.method_1(SubDocumentType.Footnote, A_0.class597_0.class1111_18, BookmarkStart.b("瘥䐧䤩䨫栭尯嘱爳䈵嘷", 0));
        this.method_1(SubDocumentType.Comment, A_0.class597_0.class1111_19, BookmarkStart.b("瘥䐧䤩䨫栭尯嘱申䈵嘷", 0));
        this.method_1(SubDocumentType.Endnote, A_0.class597_0.class1111_48, BookmarkStart.b("瘥䐧䤩䨫栭尯嘱焳刵嘷", 0));
        this.method_1(SubDocumentType.Textbox, A_0.class597_0.class1111_57, BookmarkStart.b("瘥䐧䤩䨫栭尯嘱怳丵娷䈹", 0));
        this.method_1(SubDocumentType.HeaderTextBox, A_0.class597_0.class1111_59, BookmarkStart.b("瘥䐧䤩䨫栭尯嘱簳刵䨷渹䐻䨽∿㩁", 0));
    }

    private void imethod_0(BinaryReader A_0, int A_1, int A_2)
    {
        Class766 class2 = new Class766(A_0);
        this.hashtable_0[A_1] = class2;
    }

    internal Class766 method_0(SubDocumentType A_0, int A_1)
    {
        Hashtable hashtable = (Hashtable) this.hashtable_1[A_0];
        return (Class766) hashtable[A_1];
    }

    private void method_1(SubDocumentType A_0, Class1111 A_1, string A_2)
    {
        this.hashtable_0 = new Hashtable();
        this.hashtable_1[A_0] = this.hashtable_0;
        this.binaryReader_0.BaseStream.Seek((long) A_1.int_0, SeekOrigin.Begin);
        Class144.smethod_0(this.binaryReader_0, A_1.int_1, 2, this, A_2);
    }
}

