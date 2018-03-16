using Spire.Compression.Zip;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class271 : Class269
{
    private byte[] byte_1;
    private Class767 class767_0;
    private const int int_1 = 0x4000;

    internal Class271()
    {
    }

    internal Class271(Guid A_0, byte[] A_1) : base(A_0)
    {
        int num = 9;
        base.method_6(base.method_7(Class409.smethod_0(A_1)));
        switch (base.method_5())
        {
            case BlipImageType.Emf:
            case BlipImageType.Wmf:
            case BlipImageType.Pict:
                this.byte_1 = A_1;
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("種弰堲娴䀶圸ᬺ嬼倾㍀⹂⑄㍆楈㽊㑌㽎㑐絒", num));
    }

    protected override void vmethod_0(BinaryReader A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        base.method_8(A_0);
        this.class767_0 = new Class767(A_0, (int) A_0.BaseStream.Position);
        A_0.BaseStream.Position = position + base.method_3().method_10();
    }

    protected override void vmethod_1(BinaryWriter A_0)
    {
        byte[] buffer = Class409.smethod_30(this.byte_1);
        base.method_9(A_0);
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
        if ((this.byte_1 == null) && (this.class767_0 != null))
        {
            this.byte_1 = this.class767_0.method_0();
        }
        return this.byte_1;
    }

    internal override PresetTexture vmethod_3()
    {
        return PresetTexture.Custom;
    }

    private class Class767
    {
        private readonly BinaryReader binaryReader_0;
        private readonly int int_0;

        internal Class767(BinaryReader A_0, int A_1)
        {
            this.binaryReader_0 = A_0;
            this.int_0 = A_1;
        }

        internal byte[] method_0()
        {
            int num = 0x13;
            this.binaryReader_0.BaseStream.Position = this.int_0;
            int num2 = this.binaryReader_0.ReadInt32();
            int num3 = this.binaryReader_0.ReadInt32();
            int num4 = this.binaryReader_0.ReadInt32();
            int num5 = this.binaryReader_0.ReadInt32();
            int num6 = this.binaryReader_0.ReadInt32();
            int num7 = this.binaryReader_0.ReadInt32();
            int num8 = this.binaryReader_0.ReadInt32();
            Class1044.smethod_3(num3, num4, num5, num6, num7, num8);
            int count = this.binaryReader_0.ReadInt32();
            if (count <= 0)
            {
                return null;
            }
            EscherBlipCompression compression = (EscherBlipCompression) this.binaryReader_0.ReadByte();
            this.binaryReader_0.ReadByte();
            byte[] buffer = this.binaryReader_0.ReadBytes(count);
            EscherBlipCompression compression2 = compression;
            if (compression2 != EscherBlipCompression.Deflate)
            {
                if (compression2 != EscherBlipCompression.None)
                {
                    throw new InvalidOperationException(BookmarkStart.b("瀸唺䬼帾ⵀ⩂⅄杆⩈⑊⁌㽎⍐㙒♔⑖じ㑚㍜罞ౠ٢ᅤས٨ཪ䍬", num));
                }
                return buffer;
            }
            try
            {
                return Class1156.smethod_0(buffer, num2, CompressionMethod.Stored);
            }
            catch (Exception)
            {
                return Class567.smethod_14();
            }
        }
    }
}

