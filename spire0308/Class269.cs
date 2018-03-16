using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal abstract class Class269 : Class266
{
    private Guid guid_0;
    private Guid guid_1;
    protected const int int_0 = 0x10;

    internal Class269()
    {
        this.guid_0 = Guid.Empty;
        this.guid_1 = Guid.Empty;
    }

    internal Class269(Guid A_0)
    {
        this.guid_0 = Guid.Empty;
        this.guid_1 = Guid.Empty;
        this.guid_0 = A_0;
    }

    internal Guid method_4()
    {
        return this.guid_0;
    }

    internal BlipImageType method_5()
    {
        return smethod_0(base.method_3().method_8());
    }

    internal void method_6(BlipImageType A_0)
    {
        base.method_3().method_9(smethod_1(A_0));
        base.method_3().method_7((int) smethod_2(A_0));
    }

    internal BlipImageType method_7(ImageFormat A_0)
    {
        switch (A_0)
        {
            case ImageFormat.Unknown:
                return BlipImageType.Unknown;

            case ImageFormat.Bmp:
                return BlipImageType.Bmp;

            case ImageFormat.Emf:
                return BlipImageType.Emf;

            case ImageFormat.Gif:
            case ImageFormat.Jpeg:
                return BlipImageType.Jpeg;

            case ImageFormat.Png:
                return BlipImageType.Png;

            case ImageFormat.Wmf:
                return BlipImageType.Wmf;

            case ImageFormat.MacPICT:
                return BlipImageType.Pict;
        }
        return BlipImageType.NoImage;
    }

    protected void method_8(BinaryReader A_0)
    {
        this.guid_0 = smethod_3(A_0);
        if ((base.method_3().method_6() & 1) != 0)
        {
            this.guid_1 = smethod_3(A_0);
        }
    }

    protected void method_9(BinaryWriter A_0)
    {
        A_0.Write(this.guid_0.ToByteArray());
        if ((base.method_3().method_6() & 1) != 0)
        {
            A_0.Write(this.guid_1.ToByteArray());
        }
    }

    private static BlipImageType smethod_0(EscherRecordType A_0)
    {
        return (BlipImageType) (A_0 - 0xf018);
    }

    private static EscherRecordType smethod_1(BlipImageType A_0)
    {
        return (EscherRecordType) (A_0 + 0xf018);
    }

    private static EscherBlipInstance smethod_2(BlipImageType A_0)
    {
        int num = 4;
        switch (A_0)
        {
            case BlipImageType.Emf:
                return EscherBlipInstance.Emf;

            case BlipImageType.Wmf:
                return EscherBlipInstance.Wmf;

            case BlipImageType.Pict:
                return EscherBlipInstance.Pict;

            case BlipImageType.Jpeg:
                return EscherBlipInstance.Jpeg;

            case BlipImageType.Png:
                return EscherBlipInstance.Png;

            case BlipImageType.Bmp:
                return EscherBlipInstance.Bmp;
        }
        throw new InvalidOperationException(BookmarkStart.b("缩䈫䔭帯崱䌳堵ᠷ匹儻弽✿❁摃⁅❇㡉⅋⽍⑏籑", num));
    }

    private static Guid smethod_3(BinaryReader A_0)
    {
        return new Guid(A_0.ReadBytes(0x10));
    }

    internal abstract byte[] vmethod_2();
    internal abstract PresetTexture vmethod_3();
}

