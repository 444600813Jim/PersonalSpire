using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class225 : Class223
{
    private byte[] byte_1;
    private Class506 class506_0;
    private PresetTexture presetTexture_0;

    internal Class225()
    {
    }

    internal Class225(Guid A_0, byte[] A_1, PresetTexture A_2) : base(A_0)
    {
        int num = 0x12;
        this.presetTexture_0 = A_2;
        base.method_8(Class409.smethod_2(Class409.smethod_0(A_1)));
        switch (base.method_7())
        {
            case BlipImageType.Jpeg:
            case BlipImageType.Png:
            case BlipImageType.Bmp:
                this.byte_1 = A_1;
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("瘷唹䠻ḽ┿㩁㑃⍅⭇㹉⥋⩍灏㵑⁓㹕㵗⡙籛㝝ൟͣͥ͡䡧౩ͫᱭᵯ፱sյ塷ቹ᥻౽겁", num));
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        base.method_9(A_0);
        this.presetTexture_0 = (PresetTexture) A_0.ReadByte();
        int num2 = ((int) A_0.BaseStream.Position) - position;
        int num3 = base.method_3().method_10() - num2;
        this.class506_0 = new Class506(A_0, (int) A_0.BaseStream.Position, num3, base.method_7());
        A_0.BaseStream.Position = position + base.method_3().method_10();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        base.method_10(A_0);
        A_0.Write((byte) this.presetTexture_0);
        if (base.method_7() == BlipImageType.Bmp)
        {
            A_0.Write(this.byte_1, 14, this.byte_1.Length - 14);
        }
        else
        {
            A_0.Write(this.byte_1);
        }
    }

    internal override byte[] vmethod_2()
    {
        if ((this.byte_1 == null) && (this.class506_0 != null))
        {
            this.byte_1 = this.class506_0.method_0();
        }
        return this.byte_1;
    }

    internal override PresetTexture vmethod_3()
    {
        return this.presetTexture_0;
    }

    private class Class506
    {
        private readonly BinaryReader binaryReader_0;
        private readonly BlipImageType blipImageType_0;
        private readonly int int_0;
        private readonly int int_1;

        internal Class506(BinaryReader A_0, int A_1, int A_2, BlipImageType A_3)
        {
            this.binaryReader_0 = A_0;
            this.int_0 = A_1;
            this.int_1 = A_2;
            this.blipImageType_0 = A_3;
        }

        internal byte[] method_0()
        {
            this.binaryReader_0.BaseStream.Position = this.int_0;
            if (this.blipImageType_0 == BlipImageType.Bmp)
            {
                return Class409.smethod_15(this.binaryReader_0, this.int_1);
            }
            return this.binaryReader_0.ReadBytes(this.int_1);
        }
    }
}

