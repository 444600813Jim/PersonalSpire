using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal abstract class Class223 : Class222
{
    private Guid guid_0;
    private Guid guid_1;
    protected const int int_0 = 0x10;

    internal Class223()
    {
        this.guid_0 = Guid.Empty;
        this.guid_1 = Guid.Empty;
    }

    internal Class223(Guid A_0)
    {
        this.guid_0 = Guid.Empty;
        this.guid_1 = Guid.Empty;
        this.guid_0 = A_0;
    }

    protected void method_10(BinaryWriter A_0)
    {
        A_0.Write(this.guid_0.ToByteArray());
        if ((base.method_3().method_6() & 1) != 0)
        {
            A_0.Write(this.guid_1.ToByteArray());
        }
    }

    internal Guid method_6()
    {
        return this.guid_0;
    }

    internal BlipImageType method_7()
    {
        return smethod_0(base.method_3().method_8());
    }

    internal void method_8(BlipImageType A_0)
    {
        base.method_3().method_9(smethod_1(A_0));
        base.method_3().method_7((int) smethod_2(A_0));
    }

    protected void method_9(BinaryReader A_0)
    {
        this.guid_0 = smethod_3(A_0);
        if ((base.method_3().method_6() & 1) != 0)
        {
            this.guid_1 = smethod_3(A_0);
        }
    }

    private static BlipImageType smethod_0(EsRecordType A_0)
    {
        return (BlipImageType) (A_0 - 0xf018);
    }

    private static EsRecordType smethod_1(BlipImageType A_0)
    {
        return (EsRecordType) (A_0 + 0xf018);
    }

    private static EsBlipInstance smethod_2(BlipImageType A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case BlipImageType.Emf:
                return EsBlipInstance.Emf;

            case BlipImageType.Wmf:
                return EsBlipInstance.Wmf;

            case BlipImageType.Pict:
                return EsBlipInstance.Pict;

            case BlipImageType.Jpeg:
                return EsBlipInstance.Jpeg;

            case BlipImageType.Png:
                return EsBlipInstance.Png;

            case BlipImageType.Bmp:
                return EsBlipInstance.Bmp;
        }
        throw new InvalidOperationException(BookmarkStart.b("支就弳堵圷䴹刻ḽ⤿⽁╃ⅅⵇ橉⩋⅍≏㽑㕓≕癗", num));
    }

    private static Guid smethod_3(BinaryReader A_0)
    {
        return new Guid(A_0.ReadBytes(0x10));
    }

    internal abstract byte[] vmethod_2();
    internal abstract PresetTexture vmethod_3();
}

