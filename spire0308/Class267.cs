using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using System;
using System.IO;

internal class Class267 : Class266
{
    private EscherClientAnchorFlags escherClientAnchorFlags_0;

    internal Class267() : base(EscherRecordType.ClientAnchor, 0)
    {
    }

    internal EscherClientAnchorFlags method_4()
    {
        return this.escherClientAnchorFlags_0;
    }

    internal void method_5(EscherClientAnchorFlags A_0)
    {
        this.escherClientAnchorFlags_0 = A_0;
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        this.escherClientAnchorFlags_0 = (EscherClientAnchorFlags) A_0.ReadInt32();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        A_0.Write((int) this.escherClientAnchorFlags_0);
    }
}

