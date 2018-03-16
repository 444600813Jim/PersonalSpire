using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;
using System.Text;

internal class Class703
{
    internal bool bool_0;
    private bool bool_1;
    private bool bool_10;
    internal bool bool_11;
    private bool bool_12;
    private bool bool_13;
    private bool bool_14;
    private bool bool_15;
    private bool bool_16;
    internal static bool bool_17;
    internal bool bool_2;
    internal bool bool_3;
    internal bool bool_4;
    internal bool bool_5;
    internal bool bool_6;
    internal bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private byte byte_0;
    internal Class1057 class1057_0;
    internal Class597 class597_0;
    internal Class653 class653_0;
    internal Class868 class868_0;
    internal Class929 class929_0;
    internal const int int_0 = 0x44;
    internal const int int_1 = 0x5d;
    internal int int_10;
    internal int int_11;
    private int int_12;
    private int int_13;
    internal int int_14;
    internal int int_15;
    internal int int_16;
    private int int_17;
    internal int int_18;
    internal int int_19;
    internal const int int_2 = 0x6c;
    internal int int_20;
    internal int int_21;
    private int int_22;
    private int int_23;
    private int int_24;
    private int int_25;
    private int int_26;
    private int int_27;
    private int int_28;
    private int int_29;
    internal const int int_3 = 0x88;
    private int int_30;
    private int int_31;
    private int int_32;
    internal const int int_4 = 0xa4;
    internal const int int_5 = 0xb7;
    private const int int_6 = 0x382;
    internal int int_7;
    internal int int_8;
    internal int int_9;
    internal NFibEnum nfibEnum_0;
    private short short_0;
    private short short_1;
    private short short_2;
    private ushort ushort_0;
    private ushort ushort_1;
    private ushort ushort_10;
    private ushort ushort_11;
    internal ushort ushort_2;
    private ushort ushort_3;
    private ushort ushort_4;
    private ushort ushort_5;
    private ushort ushort_6;
    private ushort ushort_7;
    private ushort ushort_8;
    private ushort ushort_9;

    internal Class703()
    {
        this.class597_0 = new Class597();
        this.class1057_0 = new Class1057();
        this.class929_0 = new Class929();
        this.class868_0 = new Class868();
        this.class653_0 = new Class653();
        this.ushort_0 = 0xa5ec;
        this.nfibEnum_0 = NFibEnum.Word2003;
        this.ushort_11 = 0xa4;
        this.ushort_1 = 0x6021;
        this.short_0 = 0x409;
        this.bool_2 = true;
        this.bool_8 = true;
        this.ushort_2 = 0xbf;
        this.bool_16 = true;
        this.ushort_5 = 14;
        this.ushort_6 = 0x5741;
        this.ushort_7 = 0x4e;
        this.ushort_8 = BookmarkStart.b("Գܵᘷ༹਻ွ瀿汁瑃", 14)[0] | (BookmarkStart.b("Գܵᘷ༹਻ွ瀿汁瑃", 14)[2] << 8);
        this.ushort_9 = BookmarkStart.b("Գܵᘷ༹਻ွ瀿汁瑃", 14)[4] | (BookmarkStart.b("Գܵᘷ༹਻ွ瀿汁瑃", 14)[6] << 8);
        this.short_2 = 0x409;
        this.ushort_10 = 0x16;
        this.int_28 = 0xfffff;
        this.int_25 = 0xfffff;
        this.int_22 = 0xfffff;
        this.int_12 = 0xc73e;
        this.int_13 = 0xc73e;
    }

    internal Class703(BinaryReader A_0)
    {
        this.class597_0 = new Class597();
        this.class1057_0 = new Class1057();
        this.class929_0 = new Class929();
        this.class868_0 = new Class868();
        this.class653_0 = new Class653();
        this.method_2(A_0);
    }

    internal string method_0()
    {
        int num = 7;
        if (!this.bool_5)
        {
            return BookmarkStart.b("ᴬ笮倰儲头制", num);
        }
        return BookmarkStart.b("ᰬ笮倰儲头制", num);
    }

    internal bool method_1()
    {
        return (this.nfibEnum_0 < NFibEnum.Value106);
    }

    private void method_2(BinaryReader A_0)
    {
        A_0.BaseStream.Position = 0L;
        this.ushort_0 = A_0.ReadUInt16();
        this.nfibEnum_0 = (NFibEnum) A_0.ReadUInt16();
        this.ushort_1 = A_0.ReadUInt16();
        this.short_0 = A_0.ReadInt16();
        this.short_1 = A_0.ReadInt16();
        int num = A_0.ReadByte();
        this.bool_0 = (num & 1) != 0;
        this.bool_1 = (num & 2) != 0;
        this.bool_2 = (num & 4) != 0;
        this.bool_3 = (num & 8) != 0;
        this.int_7 = (num & 240) >> 4;
        num = A_0.ReadByte();
        this.bool_4 = (num & 1) != 0;
        this.bool_5 = (num & 2) != 0;
        this.bool_6 = (num & 4) != 0;
        this.bool_7 = (num & 8) != 0;
        this.bool_8 = (num & 0x10) != 0;
        this.bool_9 = (num & 0x20) != 0;
        this.bool_10 = (num & 0x40) != 0;
        this.bool_11 = (num & 0x80) != 0;
        this.ushort_2 = A_0.ReadUInt16();
        this.int_8 = A_0.ReadInt32();
        this.byte_0 = A_0.ReadByte();
        num = A_0.ReadByte();
        this.bool_12 = (num & 1) != 0;
        this.bool_13 = (num & 2) != 0;
        this.bool_14 = (num & 4) != 0;
        this.bool_15 = (num & 8) != 0;
        this.bool_16 = (num & 0x10) != 0;
        this.ushort_3 = A_0.ReadUInt16();
        this.ushort_4 = A_0.ReadUInt16();
        this.int_9 = A_0.ReadInt32();
        this.int_10 = A_0.ReadInt32();
        this.ushort_5 = A_0.ReadUInt16();
        this.ushort_6 = A_0.ReadUInt16();
        this.ushort_7 = A_0.ReadUInt16();
        this.ushort_8 = A_0.ReadUInt16();
        this.ushort_9 = A_0.ReadUInt16();
        A_0.BaseStream.Seek(0x12L, SeekOrigin.Current);
        this.short_2 = A_0.ReadInt16();
        this.ushort_10 = A_0.ReadUInt16();
        this.int_11 = A_0.ReadInt32();
    }

    internal void method_3(BinaryReader A_0)
    {
        A_0.BaseStream.Position = 0x44L;
        this.int_12 = A_0.ReadInt32();
        this.int_13 = A_0.ReadInt32();
        this.int_14 = A_0.ReadInt32();
        this.int_15 = A_0.ReadInt32();
        this.int_16 = A_0.ReadInt32();
        this.int_17 = A_0.ReadInt32();
        this.int_18 = A_0.ReadInt32();
        this.int_19 = A_0.ReadInt32();
        this.int_20 = A_0.ReadInt32();
        this.int_21 = A_0.ReadInt32();
        this.int_22 = A_0.ReadInt32();
        this.int_23 = A_0.ReadInt32();
        this.int_24 = A_0.ReadInt32();
        this.int_25 = A_0.ReadInt32();
        this.int_26 = A_0.ReadInt32();
        this.int_27 = A_0.ReadInt32();
        this.int_28 = A_0.ReadInt32();
        this.int_29 = A_0.ReadInt32();
        this.int_30 = A_0.ReadInt32();
        this.int_31 = A_0.ReadInt32();
        this.int_32 = A_0.ReadInt32();
        this.ushort_11 = A_0.ReadUInt16();
        int position = (int) A_0.BaseStream.Position;
        this.class597_0.method_10(A_0);
        if (this.ushort_11 >= 0x6c)
        {
            this.class1057_0.method_5(A_0);
        }
        if (this.ushort_11 >= 0x88)
        {
            this.class929_0.method_7(A_0);
        }
        if (this.ushort_11 >= 0xa4)
        {
            this.class868_0.method_2(A_0);
        }
        if (this.ushort_11 >= 0xb7)
        {
            this.class653_0.method_0(A_0);
        }
        if (this.ushort_11 >= 0x6c)
        {
            A_0.BaseStream.Position = position + (this.ushort_11 * 8);
            if (A_0.ReadUInt16() >= 2)
            {
                this.nfibEnum_0 = (NFibEnum) A_0.ReadUInt16();
                this.int_7 = A_0.ReadUInt16();
            }
        }
        this.method_8();
    }

    internal void method_4(Stream A_0)
    {
        BinaryWriter writer = new BinaryWriter(A_0, Encoding.Unicode);
        writer.Write(this.ushort_0);
        writer.Write((ushort) 0xc1);
        writer.Write(this.ushort_1);
        writer.Write(this.short_0);
        writer.Write(this.short_1);
        ushort num = 0;
        if (this.bool_0)
        {
            num = (ushort) (num | 1);
        }
        if (this.bool_1)
        {
            num = (ushort) (num | 2);
        }
        if (this.bool_2)
        {
            num = (ushort) (num | 4);
        }
        if (this.bool_3)
        {
            num = (ushort) (num | 8);
        }
        num = (ushort) (num | ((ushort) (240 & (this.int_7 << 4))));
        if (this.bool_4)
        {
            num = (ushort) (num | 0x100);
        }
        if (this.bool_5)
        {
            num = (ushort) (num | 0x200);
        }
        if (this.bool_6)
        {
            num = (ushort) (num | 0x400);
        }
        if (this.bool_7)
        {
            num = (ushort) (num | 0x800);
        }
        if (this.bool_8)
        {
            num = (ushort) (num | 0x1000);
        }
        writer.Write(num);
        writer.Write(this.ushort_2);
        writer.Write(this.int_8);
        writer.Write(this.byte_0);
        byte num2 = 0;
        if (this.bool_12)
        {
            num2 = (byte) (num2 | 1);
        }
        if (this.bool_13)
        {
            num2 = (byte) (num2 | 2);
        }
        if (this.bool_14)
        {
            num2 = (byte) (num2 | 4);
        }
        if (this.bool_15)
        {
            num2 = (byte) (num2 | 8);
        }
        if (this.bool_16)
        {
            num2 = (byte) (num2 | 0x10);
        }
        writer.Write(num2);
        writer.Write(this.ushort_3);
        writer.Write(this.ushort_4);
        writer.Write(this.int_9);
        writer.Write(this.int_10);
        writer.Write(this.ushort_5);
        writer.Write(this.ushort_6);
        writer.Write(this.ushort_7);
        writer.Write(this.ushort_8);
        writer.Write(this.ushort_9);
        writer.Seek(0x12, SeekOrigin.Current);
        writer.Write(this.short_2);
        writer.Write(this.ushort_10);
        writer.Write(this.int_11);
        writer.Write(this.int_12);
        writer.Write(this.int_13);
        writer.Write(this.int_14);
        writer.Write(this.int_15);
        writer.Write(this.int_16);
        writer.Write(this.int_17);
        writer.Write(this.int_18);
        writer.Write(this.int_19);
        writer.Write(this.int_20);
        writer.Write(this.int_21);
        writer.Write(this.int_22);
        writer.Write(this.int_23);
        writer.Write(this.int_24);
        writer.Write(this.int_25);
        writer.Write(this.int_26);
        writer.Write(this.int_27);
        writer.Write(this.int_28);
        writer.Write(this.int_29);
        writer.Write(this.int_30);
        writer.Write(this.int_31);
        writer.Write(this.int_32);
        writer.Write(this.ushort_11);
        int position = (int) writer.BaseStream.Position;
        this.class597_0.method_11(writer);
        this.class1057_0.method_6(writer);
        this.class929_0.method_8(writer);
        this.class868_0.method_3(writer, this.class597_0.class1111_33.int_0);
        int num1 = (((int) writer.BaseStream.Position) - position) / 8;
        writer.Write((ushort) 2);
        writer.Write((ushort) this.nfibEnum_0);
        writer.Write((ushort) 0);
    }

    internal string method_5()
    {
        return Class567.smethod_15(this, BookmarkStart.b("瀵焷砹", 0x10));
    }

    internal int method_6(int A_0)
    {
        int num = 13;
        int num2 = A_0;
        if (num2 >= this.int_14)
        {
            num2 -= this.int_14;
            if (num2 < this.int_15)
            {
                return num2;
            }
            num2 -= this.int_15;
            if (num2 < this.int_16)
            {
                return num2;
            }
            num2 -= this.int_16;
            if (num2 < this.int_17)
            {
                return num2;
            }
            num2 -= this.int_17;
            if (num2 < this.int_18)
            {
                return num2;
            }
            num2 -= this.int_18;
            if (num2 < this.int_19)
            {
                return num2;
            }
            num2 -= this.int_19;
            if (num2 < this.int_20)
            {
                return num2;
            }
            num2 -= this.int_20;
            if (num2 >= this.int_21)
            {
                throw new InvalidOperationException(string.Format(BookmarkStart.b("爲䄴䌶尸嘺䴼䬾⑀❂敄㍆♈歊ⱌ♎㱐獒⹔杖⑘筚㹜㝞`ᅢѤѦᵨ๪Ὤᱮ兰ͲᑴѶ൸孺ॼ᝾ꎂꮊ놐ﶔ릘햠趢薤", num), num2));
            }
        }
        return num2;
    }

    internal int method_7(SubDocumentType A_0, int A_1)
    {
        int num = 0;
        int num2 = A_1;
        if (A_0 != SubDocumentType.Main)
        {
            num2 += this.int_14;
            if (A_0 == SubDocumentType.Footnote)
            {
                return num2;
            }
            num2 += this.int_15;
            if (A_0 == SubDocumentType.Header)
            {
                return num2;
            }
            num2 += this.int_16;
            num2 += this.int_17;
            if (A_0 == SubDocumentType.Comment)
            {
                return num2;
            }
            num2 += this.int_18;
            if (A_0 == SubDocumentType.Endnote)
            {
                return num2;
            }
            num2 += this.int_19;
            if (A_0 == SubDocumentType.Textbox)
            {
                return num2;
            }
            num2 += this.int_20;
            if (A_0 != SubDocumentType.HeaderTextBox)
            {
                throw new InvalidOperationException(BookmarkStart.b("猥䘧䄩䈫䄭䜯就ᐳ䔵䴷堹堻儽⌿㝁⥃⍅♇㹉汋㩍⥏≑ㅓ癕⭗⩙㥛㵝य़ѡൣͥ౧䑩", num));
            }
        }
        return num2;
    }

    private void method_8()
    {
    }

    private void method_9(bool A_0, string A_1)
    {
    }
}

