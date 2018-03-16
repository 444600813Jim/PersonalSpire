using Spire.Compression.Zip;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class224 : Class223
{
    private byte[] byte_1;
    private Class227 class227_0;
    private const int int_1 = 0x4000;

    internal Class224()
    {
    }

    internal Class224(Guid A_0, byte[] A_1) : base(A_0)
    {
        int num = 0;
        base.method_8(Class409.smethod_2(Class409.smethod_0(A_1)));
        switch (base.method_7())
        {
            case BlipImageType.Emf:
            case BlipImageType.Wmf:
            case BlipImageType.Pict:
                this.byte_1 = A_1;
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("栥䜧帩ఫ䬭䠯䈱儳唵䰷匹刻夽怿㙁ⱃ⽅㭇橉╋⍍ㅏ㕑ㅓ癕㹗㕙⹛㍝şᙡ䑣๥൧ᡩ५䁭", num));
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        base.method_9(A_0);
        this.class227_0 = new Class227(A_0, (int) A_0.BaseStream.Position);
        A_0.BaseStream.Position = position + base.method_3().method_10();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        byte[] buffer = Class409.smethod_30(this.byte_1);
        base.method_10(A_0);
        A_0.Write(buffer.Length);
        Class1044 class2 = Class409.smethod_9(this.byte_1);
        A_0.Write(class2.method_0());
        A_0.Write(class2.method_1());
        A_0.Write(class2.method_2());
        A_0.Write(class2.method_3());
        A_0.Write(class2.method_11());
        A_0.Write(class2.method_12());
        if (buffer.Length > 0x4000)
        {
            MemoryStream stream = new MemoryStream(buffer);
            MemoryStream stream2 = new MemoryStream();
            Class1156.smethod_4(stream, stream2, CompressionMethod.Stored);
            A_0.Write((int) stream2.Length);
            A_0.Write((byte) 0);
            A_0.Write((byte) 0xfe);
            A_0.Write(stream2.GetBuffer(), 0, (int) stream2.Length);
            stream2.Close();
            stream.Close();
        }
        else
        {
            A_0.Write(buffer.Length);
            A_0.Write((byte) 0xfe);
            A_0.Write((byte) 0xfe);
            A_0.Write(buffer);
        }
    }

    internal override byte[] vmethod_2()
    {
        if ((this.byte_1 == null) && (this.class227_0 != null))
        {
            this.byte_1 = this.class227_0.method_0();
        }
        return this.byte_1;
    }

    internal override PresetTexture vmethod_3()
    {
        return PresetTexture.Custom;
    }

    private class Class227
    {
        private readonly BinaryReader binaryReader_0;
        private readonly int int_0;

        internal Class227(BinaryReader A_0, int A_1)
        {
            this.binaryReader_0 = A_0;
            this.int_0 = A_1;
        }

        internal byte[] method_0()
        {
            int num = 10;
            this.binaryReader_0.BaseStream.Position = this.int_0;
            int num2 = this.binaryReader_0.ReadInt32();
            int num3 = this.binaryReader_0.ReadInt32();
            int num4 = this.binaryReader_0.ReadInt32();
            int num5 = this.binaryReader_0.ReadInt32();
            int num6 = this.binaryReader_0.ReadInt32();
            int num7 = this.binaryReader_0.ReadInt32();
            int num8 = this.binaryReader_0.ReadInt32();
            Class1044 class2 = Class1044.smethod_3(num3, num4, num5, num6, num7, num8);
            int count = this.binaryReader_0.ReadInt32();
            if (count <= 0)
            {
                return null;
            }
            EsBlipCompression compression = (EsBlipCompression) this.binaryReader_0.ReadByte();
            this.binaryReader_0.ReadByte();
            byte[] buffer = this.binaryReader_0.ReadBytes(count);
            EsBlipCompression compression2 = compression;
            if (compression2 != EsBlipCompression.Deflate)
            {
                if (compression2 != EsBlipCompression.None)
                {
                    throw new InvalidOperationException(BookmarkStart.b("礯就䈳圵吷匹堻ḽⴿ❁ぃ❅⹇⍉⁋⭍灏ㅑ㭓㭕⡗⡙㥛ⵝ፟ୡୣࡥ䡧ݩ५ᩭᡯᵱၳ塵", num));
                }
            }
            else
            {
                try
                {
                    buffer = Class1156.smethod_0(buffer, num2, CompressionMethod.Stored);
                }
                catch (Exception)
                {
                    buffer = Class567.smethod_14();
                }
            }
            if (Class409.smethod_50(buffer))
            {
                buffer = Class409.smethod_29(buffer, class2);
            }
            return buffer;
        }
    }
}

