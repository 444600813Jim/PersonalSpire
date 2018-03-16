using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Converters.BinaryDoc.Tables;
using Spire.Doc.Formatting;
using System;
using System.Drawing;
using System.IO;

internal abstract class Class139
{
    protected BinaryReader binaryReader_0;
    private bool bool_0;
    private bool bool_1;
    internal static bool bool_2 = true;
    protected Class13 class13_0;
    protected Class345 class345_0;
    private Class656 class656_0;
    protected Class812 class812_0;
    protected Document document_0;
    private int int_0;
    protected WordAttrCollection wordAttrCollection_0;

    internal Class139(Class812 A_0)
    {
        this.class812_0 = A_0;
        this.class345_0 = new Class345(new MemoryStream());
    }

    internal Class139(Document A_0, Class812 A_1) : this(A_1)
    {
        this.document_0 = A_0;
    }

    private ConditionalFormattingCode method_0(Cnfc A_0)
    {
        Cnfc cnfc = A_0;
        if (cnfc <= Cnfc.BandedRows)
        {
            if (cnfc > Cnfc.LastColumn)
            {
                if (cnfc == Cnfc.BandedColumns)
                {
                    return ConditionalFormattingCode.OddColumnBanding;
                }
                if (cnfc == Cnfc.EvenColumnBanding)
                {
                    return ConditionalFormattingCode.EvenColumnBanding;
                }
                if (cnfc == Cnfc.BandedRows)
                {
                    return ConditionalFormattingCode.OddRowBanding;
                }
            }
            else
            {
                switch (cnfc)
                {
                    case Cnfc.HeaderRow:
                        return ConditionalFormattingCode.FirstRow;

                    case Cnfc.FooterRow:
                        return ConditionalFormattingCode.LastRow;

                    case Cnfc.FirstColumn:
                        return ConditionalFormattingCode.FirstColumn;

                    case Cnfc.LastColumn:
                        return ConditionalFormattingCode.LastColumn;
                }
            }
        }
        else
        {
            switch (cnfc)
            {
                case Cnfc.EvenRowBanding:
                    return ConditionalFormattingCode.EvenRowBanding;

                case Cnfc.TopRightCell:
                    return ConditionalFormattingCode.FirstRowLastCell;

                case Cnfc.TopLeftCell:
                    return ConditionalFormattingCode.FirstRowFirstCell;

                case Cnfc.BottomRightCell:
                    return ConditionalFormattingCode.LastRowLastCell;

                case Cnfc.BottomLeftCell:
                    return ConditionalFormattingCode.LastRowFirstCell;
            }
        }
        return ConditionalFormattingCode.None;
    }

    protected byte[] method_1(WordAttrCollection A_0)
    {
        this.wordAttrCollection_0 = A_0;
        this.class345_0.BaseStream.Position = 0L;
        this.vmethod_0();
        return this.method_2();
    }

    protected void method_10(SprmCode A_0, int A_1)
    {
        int num;
        object obj2 = this.wordAttrCollection_0.method_31(A_1);
        if (obj2 == null)
        {
            num = 0;
        }
        else if (((TextDirection) obj2) == TextDirection.RightToLeft)
        {
            num = 1;
        }
        else if (((TextDirection) obj2) == TextDirection.TopToBottomRotated)
        {
            num = 4;
        }
        else
        {
            num = 0;
        }
        this.method_16(A_0, num);
    }

    protected void method_11(SprmCode A_0, int A_1, float A_2)
    {
        object obj2 = this.wordAttrCollection_0.method_6(A_1) ? this.wordAttrCollection_0.method_31(A_1) : null;
        this.method_17(A_0, obj2, A_2);
    }

    protected void method_12(SprmCode A_0, int A_1)
    {
        this.method_14(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_13(SprmCode A_0, int A_1, float A_2)
    {
        this.method_15(A_0, this.wordAttrCollection_0.method_31(A_1), A_2);
    }

    protected void method_14(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            this.class345_0.method_2(A_0, Convert.ToInt32(A_1));
        }
    }

    protected void method_15(SprmCode A_0, object A_1, float A_2)
    {
        if (A_1 != null)
        {
            this.class345_0.method_2(A_0, (int) Math.Round((double) (Convert.ToSingle(A_1) * A_2)));
        }
    }

    protected void method_16(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            this.class345_0.method_1(A_0, Convert.ToInt32(A_1));
        }
    }

    protected void method_17(SprmCode A_0, object A_1, float A_2)
    {
        if (A_1 != null)
        {
            this.class345_0.method_1(A_0, (int) Math.Round((double) (Convert.ToSingle(A_1) * A_2)));
        }
    }

    protected void method_18(SprmCode A_0, int A_1)
    {
        this.method_19(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_19(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            this.class345_0.method_3(A_0, Convert.ToInt32(A_1));
        }
    }

    protected byte[] method_2()
    {
        byte[] buffer = new byte[(int) this.class345_0.BaseStream.Position];
        this.class345_0.BaseStream.Position = 0L;
        this.class345_0.BaseStream.Read(buffer, 0, buffer.Length);
        return buffer;
    }

    protected void method_20(SprmCode A_0, int A_1)
    {
        this.method_21(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_21(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            this.class345_0.method_0(A_0, (int) Class624.smethod_0((Color) A_1));
        }
    }

    protected void method_22(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            this.class345_0.method_0(A_0, (int) A_1);
        }
    }

    protected void method_23(SprmCode A_0, int A_1)
    {
        if (this.wordAttrCollection_0.HasKey(A_1))
        {
            this.method_24(A_0, this.wordAttrCollection_0.method_31(A_1));
        }
    }

    protected void method_24(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            this.class345_0.method_3(A_0, Class624.smethod_6((Color) A_1));
        }
    }

    protected void method_25(SprmCode A_0, int A_1)
    {
        this.method_26(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_26(SprmCode A_0, object A_1)
    {
        this.method_27(A_0, A_1, float.MinValue);
    }

    protected void method_27(SprmCode A_0, object A_1, float A_2)
    {
        Border border = (Border) A_1;
        if ((border != null) && !border.IsDefault)
        {
            this.class345_0.method_5(A_0);
            Class355.smethod_3(border, this.class345_0, true, A_2);
        }
    }

    protected void method_28(object A_0)
    {
        Borders borders = (Borders) A_0;
        if (!borders.IsDefault)
        {
            this.method_27(SprmCode.PBrcLeft, borders.Left, 8f);
            this.method_27(SprmCode.PBrcTop, borders.Top, 8f);
            this.method_27(SprmCode.PBrcBottom, borders.Bottom, 8f);
            this.method_27(SprmCode.PBrcRight, borders.Right, 8f);
        }
    }

    protected void method_29(object A_0)
    {
        Class14 class2 = (Class14) A_0;
        if (class2.HasKey(6))
        {
            int num = class2.method_92();
            if (class2.method_95() == FrameSizeRule.AtLeast)
            {
                num |= 0x8000;
            }
            this.class345_0.method_1(SprmCode.PWHeightAbs, num);
        }
        if (class2.HasKey(14))
        {
            this.method_16(SprmCode.PFrameTextFlow, class2.method_32(14));
        }
        if (class2.HasKey(0x10))
        {
            this.method_16(SprmCode.PDyaFromText, class2.method_32(0x10));
        }
        if (class2.HasKey(9))
        {
            this.method_16(SprmCode.PDxaFromText, class2.method_32(9));
        }
        if (class2.HasKey(5))
        {
            this.method_4(SprmCode.PFLockAnchor, class2.method_32(5));
        }
        if (class2.HasKey(13))
        {
            this.method_4(SprmCode.PFNoAllowOverlap, class2.method_32(13));
        }
        if (class2.HasKey(20))
        {
            DropCapPosition position = class2.method_108();
            int num2 = class2.method_110();
            int num3 = ((int) position) | (num2 << 3);
            this.class345_0.method_1(SprmCode.PDcs, num3);
        }
    }

    protected void method_3(SprmCode A_0, int A_1)
    {
        this.method_4(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_30(SprmCode A_0, int A_1)
    {
        this.method_31(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_31(SprmCode A_0, object A_1)
    {
        Border border = (Border) A_1;
        if ((border != null) && !border.IsDefault)
        {
            this.class345_0.method_5(A_0);
            this.class345_0.Write((byte) 8);
            Class355.smethod_4(border, this.class345_0, true);
        }
    }

    protected void method_32(SprmCode A_0, int A_1)
    {
        this.method_33(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_33(SprmCode A_0, object A_1)
    {
        Class16 class2 = (Class16) A_1;
        if (((class2 != null) && (class2.OwnerBase == null)) && !class2.IsDefault)
        {
            this.class345_0.method_5(A_0);
            Class1106.smethod_2(class2, this.class345_0);
        }
    }

    protected void method_34(SprmCode A_0, int A_1)
    {
        this.method_35(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_35(SprmCode A_0, object A_1)
    {
        Class16 class2 = (Class16) A_1;
        if (((class2 != null) && (class2.OwnerBase == null)) && !class2.IsDefault)
        {
            this.class345_0.method_5(A_0);
            this.class345_0.Write((byte) 10);
            Class1106.smethod_3(class2, this.class345_0);
        }
    }

    protected long method_36(SprmCode A_0, ConditionalFormattingCode A_1)
    {
        this.bool_0 = true;
        this.class345_0.method_5(A_0);
        long position = (int) this.class345_0.BaseStream.Position;
        this.class345_0.Write((byte) 0);
        this.class345_0.Write((ushort) smethod_0(A_1));
        return position;
    }

    protected void method_37(long A_0)
    {
        long position = this.class345_0.BaseStream.Position;
        this.class345_0.BaseStream.Position = A_0;
        this.class345_0.Write((byte) ((position - A_0) - 1L));
        this.class345_0.BaseStream.Position = position;
        this.bool_0 = false;
    }

    protected void method_38(int A_0)
    {
        Border border = (Border) this.wordAttrCollection_0.method_33(A_0);
        Class355.smethod_0(this.binaryReader_0, border);
    }

    protected void method_39(int A_0)
    {
        Border border = (Border) this.wordAttrCollection_0.method_33(A_0);
        Class355.smethod_1(this.binaryReader_0, border);
    }

    protected void method_4(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            this.class345_0.method_4(A_0, (bool) A_1);
        }
    }

    protected void method_40(int A_0)
    {
        this.method_41(A_0, this.wordAttrCollection_0);
    }

    protected void method_41(int A_0, WordAttrCollection A_1)
    {
        Class16 class2 = (Class16) A_1.method_31(A_0);
        Class16 class3 = Class1106.smethod_0(this.binaryReader_0, class2);
        if (class3 != null)
        {
            A_1.SetAttr(A_0, class3);
        }
    }

    protected void method_42(int A_0)
    {
        this.method_43(A_0, this.wordAttrCollection_0);
    }

    protected void method_43(int A_0, WordAttrCollection A_1)
    {
        Class16 class2 = (Class16) A_1.method_31(A_0);
        Class16 class3 = Class1106.smethod_1(this.binaryReader_0, class2);
        if (class3 != null)
        {
            A_1.SetAttr(A_0, class3);
        }
    }

    protected void method_44(WordAttrCollection A_0)
    {
        this.method_45(A_0, true);
    }

    protected void method_45(WordAttrCollection A_0, bool A_1)
    {
        bool flag = this.binaryReader_0.ReadByte() != 0;
        int num = this.binaryReader_0.ReadInt16();
        DateTime time = Class353.smethod_2(this.binaryReader_0);
        if (flag)
        {
            Class580 class2 = new Class580(A_0, this.class812_0.method_1(num), time);
            if (A_1)
            {
                class2.method_4().method_25(this.wordAttrCollection_0);
            }
            if (this.wordAttrCollection_0 is CharacterFormat)
            {
                (this.wordAttrCollection_0 as CharacterFormat).IsChangedFormat = true;
                (class2.method_4() as CharacterFormat).method_74(this.wordAttrCollection_0 as CharacterFormat);
            }
            else if (this.wordAttrCollection_0 is ParagraphFormat)
            {
                (this.wordAttrCollection_0 as ParagraphFormat).IsChangedFormat = true;
            }
            this.wordAttrCollection_0.SetAttr(0x271a, class2);
        }
    }

    protected void method_46(SprmCode A_0, SprmCode A_1)
    {
        if (this.wordAttrCollection_0.FormatRevision != null)
        {
            Class580 formatRevision = this.wordAttrCollection_0.FormatRevision;
            this.class345_0.method_5(A_0);
            this.class345_0.Write((byte) 7);
            this.class345_0.Write((byte) 1);
            this.class345_0.Write((short) this.class812_0.method_2(formatRevision.method_0()));
            Class353.smethod_3(formatRevision.method_2(), this.class345_0);
            this.class345_0.method_4(A_1, true);
            this.bool_1 = true;
            this.vmethod_0();
            this.bool_1 = false;
        }
    }

    protected void method_47(int A_0, int A_1)
    {
        if (this.wordAttrCollection_0 is ParagraphFormat)
        {
            short num = this.binaryReader_0.ReadInt16();
            object obj2 = Class292.smethod_4(num);
            if (obj2 != null)
            {
                (this.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(A_1, (short) ((ShapeHorizontalAlignment) obj2));
            }
            else
            {
                (this.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(A_0, num);
            }
        }
        else if (this.wordAttrCollection_0 is RowFormat)
        {
            int num2 = this.binaryReader_0.ReadInt16();
            object obj3 = Class292.smethod_4(num2);
            if (obj3 != null)
            {
                (this.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(A_1, (short) ((ShapeHorizontalAlignment) obj3));
            }
            else
            {
                (this.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(A_0, (float) num2);
            }
        }
    }

    protected void method_48(int A_0, int A_1)
    {
        if (this.wordAttrCollection_0 is ParagraphFormat)
        {
            short num = this.binaryReader_0.ReadInt16();
            object obj2 = Class292.smethod_6(num);
            if (obj2 != null)
            {
                (this.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(A_1, (short) ((ShapeVerticalAlignment) obj2));
            }
            else
            {
                (this.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(A_0, num);
            }
        }
        else if (this.wordAttrCollection_0 is RowFormat)
        {
            int num2 = this.binaryReader_0.ReadInt16();
            if (Class292.smethod_6(num2) != null)
            {
                (this.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(A_1, (short) num2);
            }
            else
            {
                (this.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(A_0, (float) num2);
            }
        }
    }

    protected void method_49(SprmCode A_0, int A_1, int A_2)
    {
        if ((this.wordAttrCollection_0 is ParagraphFormat) && ((this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_1) || (this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_2)))
        {
            int num;
            if ((this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_1))
            {
                num = (short) (this.wordAttrCollection_0 as ParagraphFormat).Frame.method_32(A_1);
            }
            else
            {
                num = Class292.smethod_5((ShapeHorizontalAlignment) ((short) (this.wordAttrCollection_0 as ParagraphFormat).Frame.method_32(A_2)));
            }
            this.class345_0.method_1(A_0, num);
        }
        else if ((this.wordAttrCollection_0 is RowFormat) && ((this.wordAttrCollection_0 as RowFormat).Positioning.HasKey(A_1) || (this.wordAttrCollection_0 as RowFormat).Positioning.HasKey(A_2)))
        {
            int num2;
            ShapeHorizontalAlignment alignment = (ShapeHorizontalAlignment) ((short) (this.wordAttrCollection_0 as RowFormat).Positioning.method_32(A_2));
            if ((alignment == ShapeHorizontalAlignment.None) && (this.wordAttrCollection_0 as RowFormat).Positioning.HasKey(A_1))
            {
                num2 = (int) Math.Round((double) ((float) (this.wordAttrCollection_0 as RowFormat).Positioning.method_32(A_1)));
            }
            else
            {
                num2 = Class292.smethod_5(alignment);
            }
            this.class345_0.method_1(A_0, num2);
        }
    }

    protected void method_5(SprmCode A_0, object A_1)
    {
        bool flag = true;
        if (A_1 != null)
        {
            flag = ((LayoutType) A_1) == LayoutType.AutoFit;
            this.class345_0.method_4(A_0, flag);
        }
    }

    protected void method_50(SprmCode A_0, int A_1, int A_2)
    {
        if ((this.wordAttrCollection_0 is ParagraphFormat) && ((this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_1) || (this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_2)))
        {
            int num2;
            if ((this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_1))
            {
                num2 = (short) (this.wordAttrCollection_0 as ParagraphFormat).Frame.method_32(A_1);
            }
            else
            {
                num2 = Class292.smethod_7((ShapeVerticalAlignment) ((short) (this.wordAttrCollection_0 as ParagraphFormat).Frame.method_32(A_2)));
            }
            this.class345_0.method_1(A_0, num2);
        }
        else if ((this.wordAttrCollection_0 is RowFormat) && ((this.wordAttrCollection_0 as RowFormat).Positioning.HasKey(A_1) || (this.wordAttrCollection_0 as RowFormat).Positioning.HasKey(A_2)))
        {
            int num;
            ShapeVerticalAlignment alignment = (ShapeVerticalAlignment) ((short) (this.wordAttrCollection_0 as RowFormat).Positioning.method_32(A_2));
            if (alignment == ShapeVerticalAlignment.None)
            {
                num = (int) Math.Round((double) ((float) (this.wordAttrCollection_0 as RowFormat).Positioning.method_32(A_1)));
            }
            else
            {
                num = Class292.smethod_7(alignment);
            }
            this.class345_0.method_1(A_0, num);
        }
    }

    protected void method_51(int A_0, int A_1)
    {
        int num;
        int num2;
        if (this.wordAttrCollection_0 is RowFormat)
        {
            num = this.binaryReader_0.ReadByte();
            num2 = (num & 0x30) >> 4;
            if (num2 != 3)
            {
                (this.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(A_1, (VerticalRelation) ((byte) Class292.smethod_2(num2)));
            }
            int num5 = (num & 0xc0) >> 6;
            if (num5 != 3)
            {
                (this.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(A_0, (HorizontalRelation) num5);
            }
        }
        else if (this.wordAttrCollection_0 is ParagraphFormat)
        {
            num = this.binaryReader_0.ReadByte();
            num2 = (num & 0x30) >> 4;
            if (num2 != 3)
            {
                byte num4 = (byte) Class292.smethod_2(num2);
                (this.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(A_1, (FrameVertAnchor) num4);
            }
            int num3 = (num & 0xc0) >> 6;
            if (num3 != 3)
            {
                (this.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(A_0, (FrameHorzAnchor) num3);
            }
        }
    }

    protected void method_52(SprmCode A_0, int A_1, int A_2)
    {
        if ((this.wordAttrCollection_0 is ParagraphFormat) && ((this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_1) || (this.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(A_2)))
        {
            int num4 = Class292.smethod_3((RelativeVerticalPosition) ((FrameVertAnchor) (this.wordAttrCollection_0 as ParagraphFormat).Frame.method_32(A_2)));
            int num5 = (int) ((FrameHorzAnchor) (this.wordAttrCollection_0 as ParagraphFormat).Frame.method_32(A_1));
            int num6 = (num4 << 4) | (num5 << 6);
            this.class345_0.method_0(A_0, num6);
        }
        else if ((this.wordAttrCollection_0 is RowFormat) && ((this.wordAttrCollection_0 as RowFormat).Positioning.HasKey(A_1) || (this.wordAttrCollection_0 as RowFormat).Positioning.HasKey(A_2)))
        {
            int num = Class292.smethod_3((RelativeVerticalPosition) ((VerticalRelation) (this.wordAttrCollection_0 as RowFormat).Positioning.method_32(A_2)));
            int num2 = (int) ((HorizontalRelation) (this.wordAttrCollection_0 as RowFormat).Positioning.method_32(A_1));
            int num3 = (num << 4) | (num2 << 6);
            this.class345_0.method_0(A_0, num3);
        }
    }

    protected void method_53(Interface15 A_0, BinaryReader A_1, int A_2, TableStylePrType A_3)
    {
        ConditionalFormattingCode code = this.method_0((Cnfc) A_1.ReadInt16());
        this.bool_0 = true;
        WordAttrCollection attrs = this.wordAttrCollection_0;
        this.wordAttrCollection_0 = this.class13_0.method_27(code, A_3);
        new Class479(A_0, A_1).method_1(A_1.ReadBytes(A_2 - 2));
        this.wordAttrCollection_0 = attrs;
        this.bool_0 = false;
    }

    protected bool method_54()
    {
        return this.bool_0;
    }

    protected Document method_55()
    {
        return this.document_0;
    }

    protected bool method_56()
    {
        return this.bool_1;
    }

    protected void method_57(string A_0, params object[] A_1)
    {
    }

    protected void method_58(string A_0, params object[] A_1)
    {
    }

    protected void method_59(int[] A_0)
    {
        if (this.class656_0 == null)
        {
            this.class656_0 = new Class656();
        }
        else
        {
            this.class656_0.method_6();
        }
        foreach (int num2 in A_0)
        {
            this.class656_0.method_5(num2, null);
        }
        this.int_0 = 0;
    }

    protected void method_6(SprmCode A_0, int A_1)
    {
        object obj2 = this.wordAttrCollection_0.method_31(A_1);
        if (obj2 != null)
        {
            this.class345_0.method_4(A_0, !((bool) obj2));
        }
    }

    protected void method_60(int A_0)
    {
        while (this.int_0 < this.class656_0.method_2())
        {
            if (this.class656_0.method_13(this.int_0) >= A_0)
            {
                break;
            }
            this.vmethod_1(this.class656_0.method_13(this.int_0));
            this.int_0++;
        }
    }

    protected void method_61()
    {
        this.method_60(0x7fffffff);
    }

    protected void method_7(SprmCode A_0, int A_1)
    {
        this.method_8(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    protected void method_8(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            int num;
            if (A_1 is int)
            {
                num = (int) A_1;
            }
            else if (A_1 is Class650)
            {
                num = ((Class650) A_1).method_0();
            }
            else
            {
                num = Convert.ToInt32(A_1);
            }
            this.class345_0.method_0(A_0, num);
        }
    }

    protected void method_9(SprmCode A_0, int A_1)
    {
        this.method_16(A_0, this.wordAttrCollection_0.method_31(A_1));
    }

    private static Cnfc smethod_0(ConditionalFormattingCode A_0)
    {
        switch (A_0)
        {
            case ConditionalFormattingCode.OddRowBanding:
                return Cnfc.BandedRows;

            case ConditionalFormattingCode.OddColumnBanding:
                return Cnfc.BandedColumns;

            case ConditionalFormattingCode.EvenRowBanding:
                return Cnfc.EvenRowBanding;

            case ConditionalFormattingCode.EvenColumnBanding:
                return Cnfc.EvenColumnBanding;

            case ConditionalFormattingCode.FirstColumn:
                return Cnfc.FirstColumn;

            case ConditionalFormattingCode.FirstRow:
                return Cnfc.HeaderRow;

            case ConditionalFormattingCode.LastColumn:
                return Cnfc.LastColumn;

            case ConditionalFormattingCode.LastRow:
                return Cnfc.FooterRow;

            case ConditionalFormattingCode.FirstRowLastCell:
                return Cnfc.TopRightCell;

            case ConditionalFormattingCode.FirstRowFirstCell:
                return Cnfc.TopLeftCell;

            case ConditionalFormattingCode.LastRowLastCell:
                return Cnfc.BottomRightCell;

            case ConditionalFormattingCode.LastRowFirstCell:
                return Cnfc.BottomLeftCell;
        }
        return Cnfc.None;
    }

    protected abstract void vmethod_0();
    protected abstract void vmethod_1(int A_0);
}

