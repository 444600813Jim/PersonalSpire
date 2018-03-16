using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class320 : Interface24
{
    private readonly OdtClipboardFormat odtClipboardFormat_0;
    private readonly OdtPersist1 odtPersist1_0;
    private readonly OdtPersist2 odtPersist2_0;

    internal Class320(Class1089 A_0)
    {
        MemoryStream input = A_0.method_4(BookmarkStart.b("␦昨䤪䜬昮弰唲娴", 1));
        if (input != null)
        {
            BinaryReader reader = new BinaryReader(input);
            this.odtPersist1_0 = (OdtPersist1) reader.ReadUInt16();
            this.odtClipboardFormat_0 = (OdtClipboardFormat) reader.ReadUInt16();
            if (Class567.smethod_46(reader, 2))
            {
                this.odtPersist2_0 = ((OdtPersist2) reader.ReadUInt16()) & (OdtPersist2.StoredAsEmf | OdtPersist2.QueriedEmf | OdtPersist2.Reserved1 | OdtPersist2.Emf);
            }
        }
    }

    internal Class320(OdtPersist1 A_0, OdtPersist2 A_1, OdtClipboardFormat A_2)
    {
        this.odtPersist1_0 = A_0;
        this.odtPersist2_0 = A_1;
        this.odtClipboardFormat_0 = A_2;
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((ushort) this.odtPersist1_0);
        A_0.Write((ushort) this.odtClipboardFormat_0);
        A_0.Write((ushort) this.odtPersist2_0);
    }

    string Interface24.imethod_1()
    {
        return BookmarkStart.b("⬧攩丫䐭礯就刳夵", 2);
    }

    internal OdtPersist1 method_0()
    {
        return this.odtPersist1_0;
    }

    internal OdtPersist2 method_1()
    {
        return this.odtPersist2_0;
    }

    internal OdtClipboardFormat method_2()
    {
        return this.odtClipboardFormat_0;
    }

    internal bool method_3()
    {
        return ((this.method_0() & OdtPersist1.Icon) != OdtPersist1.None);
    }
}

