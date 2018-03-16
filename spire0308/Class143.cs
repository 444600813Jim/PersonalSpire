using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Converters.BinaryDoc.Tables;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.IO;

internal class Class143 : Class139, Interface15, Interface53
{
    private bool bool_3;
    private readonly CellFormat cellFormat_0;
    private Class1056 class1056_0;
    private readonly Class479 class479_0;
    private readonly Class758 class758_0;
    private static readonly IComparer icomparer_0 = new Class652();
    private static readonly IComparer icomparer_1 = new Class126();
    private int int_1;
    private readonly NFibEnum nfibEnum_0;
    private RowFormat rowFormat_0;
    private RowFormat rowFormat_1;

    internal Class143(BinaryReader A_0, Class812 A_1, NFibEnum A_2) : base(A_1)
    {
        this.cellFormat_0 = new CellFormat();
        this.class479_0 = new Class479(this, A_0);
        this.nfibEnum_0 = A_2;
        this.class758_0 = new Class758();
    }

    public bool imethod_0(SprmCode A_0, SprmType A_1, int A_2, BinaryReader A_3)
    {
        if (A_1 != SprmType.Tap)
        {
            return true;
        }
        base.binaryReader_0 = A_3;
        this.class758_0.method_31(A_3);
        this.class758_0.method_30(base.method_54() ? null : this.method_94());
        SprmCode code = A_0;
        if (code <= SprmCode.TTextFlow)
        {
            if (code <= SprmCode.TJc)
            {
                if (code <= SprmCode.TCVertBands)
                {
                    switch (code)
                    {
                        case SprmCode.TCHorzBands:
                            base.wordAttrCollection_0.SetAttr(0x1194, (long) A_3.ReadByte());
                            goto Label_0BB9;

                        case SprmCode.TCVertBands:
                            base.wordAttrCollection_0.SetAttr(0x119e, (long) A_3.ReadByte());
                            goto Label_0BB9;

                        case SprmCode.TCellVertAlignStyle:
                            base.wordAttrCollection_0.SetAttr(0xbf4, (VerticalAlignment) A_3.ReadByte());
                            goto Label_0BB9;

                        case SprmCode.TFCantSplit90:
                        {
                            bool flag6 = !A_3.ReadBoolean();
                            if (this.nfibEnum_0 < NFibEnum.Word2002)
                            {
                                base.wordAttrCollection_0.SetAttr(0x1108, flag6);
                            }
                            goto Label_0BB9;
                        }
                        case SprmCode.TTableHeader:
                            base.wordAttrCollection_0.SetAttr(0xfc8, A_3.ReadByte() == 1);
                            goto Label_0BB9;

                        case SprmCode.TFCantOverlap:
                        {
                            bool flag2 = A_3.ReadByte() == 0;
                            (base.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(0x45, flag2);
                            goto Label_0BB9;
                        }
                        case SprmCode.TFCantSplit:
                        {
                            bool flag3 = !A_3.ReadBoolean();
                            base.wordAttrCollection_0.SetAttr(0x1108, flag3);
                            goto Label_0BB9;
                        }
                    }
                    goto Label_0B9F;
                }
                if (code <= SprmCode.TFAllowAutoFit)
                {
                    if (code != SprmCode.TPositionCode)
                    {
                        if (code != SprmCode.TFAllowAutoFit)
                        {
                            goto Label_0B9F;
                        }
                        base.wordAttrCollection_0.SetAttr(0x1090, (A_3.ReadByte() == 1) ? LayoutType.AutoFit : LayoutType.Fixed);
                    }
                    else
                    {
                        base.method_51(0x3f, 0x40);
                    }
                }
                else if (code != SprmCode.TWall)
                {
                    if (code != SprmCode.TJc)
                    {
                        goto Label_0B9F;
                    }
                    base.wordAttrCollection_0.SetAttr(0x13ed, (RowAlignment) A_3.ReadInt16());
                }
                else
                {
                    this.method_71();
                }
                goto Label_0BB9;
            }
            if (code <= SprmCode.TIstd)
            {
                if (code <= SprmCode.TFBiDi)
                {
                    if (code != SprmCode.TJcEx)
                    {
                        if (code != SprmCode.TFBiDi)
                        {
                            goto Label_0B9F;
                        }
                        base.wordAttrCollection_0.SetAttr(0x111c, A_3.ReadInt16() != 0);
                    }
                    else if (base.wordAttrCollection_0 is RowFormat)
                    {
                        this.method_93().HorizontalAlignment = (RowAlignment) A_3.ReadInt16();
                    }
                }
                else if (code != SprmCode.TMerge)
                {
                    if (code != SprmCode.TIstd)
                    {
                        goto Label_0B9F;
                    }
                    this.method_93().Istd = A_3.ReadUInt16();
                }
                else
                {
                    this.class758_0.method_5();
                }
                goto Label_0BB9;
            }
            if (code <= SprmCode.TIpgp)
            {
                if (code != SprmCode.TTlp)
                {
                    if (code == SprmCode.TIpgp)
                    {
                        goto Label_0BB9;
                    }
                    goto Label_0B9F;
                }
                A_3.ReadInt16();
                base.wordAttrCollection_0.SetAttr(0x102c, Class531.smethod_2(A_3.ReadInt16()));
                goto Label_0BB9;
            }
            switch (code)
            {
                case SprmCode.TInsert:
                    this.class758_0.method_4(this.method_93());
                    goto Label_0BB9;

                case SprmCode.TDxaCol:
                {
                    int num5 = A_3.ReadInt16();
                    this.class758_0.method_1(num5, ((float) A_3.ReadInt16()) / 20f);
                    goto Label_0BB9;
                }
                case SprmCode.TTextFlow:
                {
                    int num2 = A_3.ReadUInt16();
                    TextDirection direction = Class417.smethod_36(A_3.ReadUInt16());
                    this.class758_0.method_0(num2, 0xbea, direction);
                    goto Label_0BB9;
                }
                case SprmCode.TRsidTr:
                    base.wordAttrCollection_0.SetAttr(0x1130, A_3.ReadInt32());
                    goto Label_0BB9;
            }
        }
        else if (code > SprmCode.TFCellNoWrap)
        {
            if (code <= SprmCode.TCnf)
            {
                if (code <= SprmCode.TCellBrcType)
                {
                    switch (code)
                    {
                        case SprmCode.TTableShd:
                            base.method_42(0x10ea);
                            goto Label_0BB9;

                        case SprmCode.TCellBrcType:
                            this.class758_0.method_9(A_2);
                            goto Label_0BB9;

                        case SprmCode.TCellHideMark:
                        {
                            int num6 = A_3.ReadUInt16();
                            bool flag4 = A_3.ReadBoolean();
                            this.class758_0.method_0(num6, 0xc94, flag4);
                            goto Label_0BB9;
                        }
                    }
                    goto Label_0B9F;
                }
                if (code != SprmCode.TPropRMark)
                {
                    if (code != SprmCode.TCnf)
                    {
                        goto Label_0B9F;
                    }
                    base.method_53(this, A_3, A_2, TableStylePrType.Cell);
                }
                else
                {
                    base.method_45(new RowFormat(base.document_0), false);
                }
                goto Label_0BB9;
            }
            if (code > SprmCode.TCellShdStyle)
            {
                switch (code)
                {
                    case SprmCode.TTableWidth:
                        this.method_75(base.wordAttrCollection_0.method_32(0x1086) as Class15);
                        goto Label_0BB9;

                    case SprmCode.TWidthBefore:
                        this.method_78(0x109a);
                        goto Label_0BB9;

                    case SprmCode.TWidthAfter:
                        this.method_78(0x10a4);
                        goto Label_0BB9;

                    case SprmCode.TFitText:
                    {
                        int num8 = A_3.ReadUInt16();
                        bool flag5 = A_3.ReadBoolean();
                        this.class758_0.method_0(num8, 0xc76, flag5);
                        goto Label_0BB9;
                    }
                    case SprmCode.TLeftIndent:
                        this.method_77(0x10f4);
                        goto Label_0BB9;
                }
            }
            else
            {
                switch (code)
                {
                    case SprmCode.TCellShdExRaw:
                    case SprmCode.TCellShdExRaw2:
                    case SprmCode.TCellShdExRaw3:
                        this.class758_0.method_8(A_0, A_2);
                        goto Label_0BB9;

                    case SprmCode.TCellBrcBottomStyle:
                    case SprmCode.TCellBrcLeftStyle:
                    case SprmCode.TCellBrcRightStyle:
                    case SprmCode.TCellBrcInsideHStyle:
                    case SprmCode.TCellBrcInsideVStyle:
                    case SprmCode.TCellBrcTL2BRStyle:
                    case SprmCode.TCellBrcTR2BLStyle:
                        goto Label_0AA3;

                    case SprmCode.TCellShdStyle:
                    {
                        Class16 class3 = Class1106.smethod_1(A_3, null);
                        if (base.method_54())
                        {
                            base.wordAttrCollection_0.SetAttr(0xc62, class3);
                        }
                        else if (base.class13_0 != null)
                        {
                            base.class13_0.Interface8.imethod_1().SetAttr(0xc62, class3);
                        }
                        goto Label_0BB9;
                    }
                }
            }
        }
        else
        {
            switch (code)
            {
                case SprmCode.TFrameLeft:
                    base.method_47(0x3d, 0x3b);
                    goto Label_0BB9;

                case SprmCode.TFrameTop:
                    base.method_48(0x3e, 60);
                    goto Label_0BB9;

                case SprmCode.TFromTextLeft:
                    (base.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(0x43, ((float) A_3.ReadInt16()) / 20f);
                    goto Label_0BB9;

                case SprmCode.TFromTextTop:
                    (base.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(0x41, ((float) A_3.ReadInt16()) / 20f);
                    goto Label_0BB9;

                case SprmCode.TDyaRowHeight:
                {
                    TableRowHeightType auto;
                    int num4 = A_3.ReadInt16();
                    if (num4 == 0)
                    {
                        auto = TableRowHeightType.Auto;
                    }
                    else if (num4 > 0)
                    {
                        auto = TableRowHeightType.AtLeast;
                    }
                    else
                    {
                        auto = TableRowHeightType.Exactly;
                    }
                    base.wordAttrCollection_0.SetAttr(0x100e, auto);
                    base.wordAttrCollection_0.SetAttr(0x1018, ((float) Math.Abs(num4)) / 20f);
                    goto Label_0BB9;
                }
                case SprmCode.TFromTextRight:
                    (base.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(0x44, ((float) A_3.ReadInt16()) / 20f);
                    goto Label_0BB9;

                case SprmCode.TFromTextBottom:
                    (base.wordAttrCollection_0 as RowFormat).Positioning.SetAttr(0x42, ((float) A_3.ReadInt16()) / 20f);
                    goto Label_0BB9;

                case SprmCode.TDxaLeft:
                    this.int_1 = A_3.ReadInt16();
                    goto Label_0BB9;

                case SprmCode.TDxaGapHalf:
                {
                    int num9 = A_3.ReadInt16();
                    if (this.nfibEnum_0 == NFibEnum.Word97)
                    {
                        this.method_93().Paddings.Left = num9;
                        this.method_93().Paddings.Right = num9;
                    }
                    goto Label_0BB9;
                }
                case SprmCode.TTableBorders80:
                case SprmCode.TTableBorders:
                    this.method_70(A_0);
                    goto Label_0BB9;

                case SprmCode.TDefTable:
                    this.class758_0.method_2(this.method_93(), A_2, this.nfibEnum_0);
                    if (!this.method_93().method_6(0xfb4) && !this.method_93().method_6(0x10e0))
                    {
                        this.method_93().Paddings.Left = 0f;
                        this.method_93().Paddings.Right = 0f;
                    }
                    goto Label_0BB9;

                case SprmCode.TCellShd:
                case SprmCode.TCellShdEx:
                case SprmCode.TCellShdEx2:
                case SprmCode.TCellShdEx3:
                    if (!this.method_96())
                    {
                        this.class758_0.method_8(A_0, A_2);
                    }
                    goto Label_0BB9;

                case SprmCode.TCellBrcTopStyle:
                    goto Label_0AA3;

                case SprmCode.TBrcTopCv:
                case SprmCode.TBrcLeftCv:
                case SprmCode.TBrcBottomCv:
                case SprmCode.TBrcRightCv:
                    this.class758_0.method_12(A_0, A_2);
                    goto Label_0BB9;

                case SprmCode.TSetBrc80:
                case SprmCode.TSetBrc:
                    this.class758_0.method_10(A_0);
                    goto Label_0BB9;

                case SprmCode.TVertMerge:
                    this.class758_0.method_6();
                    goto Label_0BB9;

                case SprmCode.TVertAlign:
                {
                    int num7 = A_3.ReadUInt16();
                    VerticalAlignment alignment = (VerticalAlignment) A_3.ReadByte();
                    this.class758_0.method_0(num7, 0xbf4, alignment);
                    goto Label_0BB9;
                }
                case SprmCode.TCellPadding:
                    this.class758_0.method_7();
                    goto Label_0BB9;

                case SprmCode.TCellSpacingDefault:
                    this.method_72();
                    goto Label_0BB9;

                case SprmCode.TCellPaddingDefault:
                    this.method_73();
                    goto Label_0BB9;

                case SprmCode.TCellWidth:
                {
                    int num3 = A_3.ReadInt16();
                    Class15 class2 = this.method_74();
                    switch (class2.method_51())
                    {
                        case FtsWidth.None:
                            this.class758_0.method_0(num3, 0xbc6, FtsWidth.None);
                            this.class758_0.method_0(num3, 0xbc4, 0f);
                            break;

                        case FtsWidth.Auto:
                            this.class758_0.method_0(num3, 0xbc6, FtsWidth.Auto);
                            this.class758_0.method_0(num3, 0xbc4, 0f);
                            break;

                        case FtsWidth.Percentage:
                            this.class758_0.method_0(num3, 0xbc6, FtsWidth.Percentage);
                            this.class758_0.method_0(num3, 0xbc4, class2.method_49() / 50f);
                            break;

                        case FtsWidth.Point:
                            this.class758_0.method_0(num3, 0xbc6, FtsWidth.Point);
                            this.class758_0.method_0(num3, 0xbc4, class2.method_49() / 20f);
                            break;
                    }
                    goto Label_0BB9;
                }
                case SprmCode.TFCellNoWrap:
                {
                    int num = A_3.ReadUInt16();
                    bool flag = !A_3.ReadBoolean();
                    this.class758_0.method_0(num, 0xc6c, flag);
                    goto Label_0BB9;
                }
            }
        }
        goto Label_0B9F;
    Label_0AA3:
        base.method_39(smethod_1(A_0));
        goto Label_0BB9;
    Label_0B9F:
        return false;
    Label_0BB9:
        return true;
    }

    private int imethod_1(SprmCode A_0, CellAlign A_1)
    {
        switch (A_1)
        {
            case CellAlign.Top:
                return 0x10cc;

            case CellAlign.Left:
                return 0xfb4;

            case CellAlign.Bottom:
                return 0x10d6;

            case CellAlign.Right:
                return 0x10e0;
        }
        return 0;
    }

    private void imethod_2(SprmCode A_0, int A_1, int A_2, CellAlign A_3, object A_4)
    {
        Class354.smethod_5(base.class345_0, SprmCode.TCellPaddingDefault, 0, 1, A_3, A_4);
    }

    internal void method_62(byte[] A_0, RowFormat A_1, int A_2)
    {
        this.method_64(A_1, A_2);
        this.class479_0.method_1(A_0);
        this.method_65();
    }

    internal void method_63(byte[] A_0, Class13 A_1)
    {
        base.class13_0 = A_1;
        base.wordAttrCollection_0 = A_1.Interface8.imethod_3();
        this.class479_0.method_1(A_0);
        A_1.Interface8.imethod_2().Remove(0xfa5);
    }

    internal void method_64(RowFormat A_0, int A_1)
    {
        base.wordAttrCollection_0 = A_0;
        this.rowFormat_0 = A_0;
        this.method_93().SetAttr(0x102c, TableStyleOptions.Default2003);
    }

    internal void method_65()
    {
        base.wordAttrCollection_0 = this.rowFormat_0;
        if ((this.method_94() != null) && (this.method_94().Count != 0))
        {
            this.method_92();
        }
    }

    internal Class430 method_66(TableRow A_0, Class430 A_1, BinaryWriter A_2, Class1056 A_3)
    {
        CellCollection cells = A_0.Cells;
        RowFormat rowFormat = A_0.RowFormat;
        smethod_2(cells, rowFormat, false);
        this.method_84(cells, rowFormat);
        if (!A_3.method_2())
        {
            rowFormat = (RowFormat) A_0.RowFormat.SysDirectAttrs;
            smethod_2(cells, rowFormat, true);
            this.method_84(cells, rowFormat);
        }
        Class428 class2 = this.method_67(A_0.RowFormat, true, A_3);
        int position = (int) A_2.BaseStream.Position;
        int num2 = class2.method_2().Length + A_1.method_2().Length;
        A_2.Write((ushort) num2);
        A_2.Write(A_1.method_2());
        A_2.Write(class2.method_2());
        Class428 class3 = this.method_85(position);
        Class430 class4 = new Class430(0, class3.method_2());
        class4.method_5(A_1);
        Class428 class5 = this.method_67(A_0.RowFormat, false, A_3);
        class4.method_5(class5);
        A_0.RowFormat.Remove(0x13ec);
        Class580 formatRevision = A_0.RowFormat.FormatRevision;
        if (formatRevision != null)
        {
            formatRevision.method_4().Remove(0x13ec);
        }
        return class4;
    }

    internal Class428 method_67(RowFormat A_0, bool A_1, Class1056 A_2)
    {
        this.bool_3 = A_1;
        this.class1056_0 = A_2;
        this.class758_0.method_32(base.class345_0);
        this.rowFormat_1 = A_0;
        RowFormat format = (!A_1 || A_2.method_2()) ? A_0 : ((RowFormat) A_0.SysDirectAttrs);
        return new Class428(base.method_1(format));
    }

    internal Class432 method_68(Class13 A_0)
    {
        base.class345_0.BaseStream.Position = 0L;
        base.wordAttrCollection_0 = A_0.Interface8.imethod_3();
        if (A_0.Istd >= 15)
        {
            base.class345_0.method_1(SprmCode.TIstd, A_0.Istd);
        }
        this.method_87(true);
        this.method_91(SprmCode.TWidthBefore, 0x109a);
        Class592.smethod_2(this.method_93(), SprmCode.TCellPaddingDefault, this, icomparer_1);
        this.method_91(SprmCode.TLeftIndent, 0x10f4);
        foreach (ConditionalFormattingCode code in A_0.method_25().Keys)
        {
            CellFormat format = A_0.method_25()[code].method_24();
            if (format != null)
            {
                long num = base.method_36(SprmCode.TCnf, code);
                if (format.method_6(0xbf4))
                {
                    base.class345_0.method_0(SprmCode.TCellVertAlignStyle, (byte) format.VerticalAlignment);
                }
                base.method_31(SprmCode.TCellBrcTopStyle, format.Borders.Top);
                base.method_31(SprmCode.TCellBrcBottomStyle, format.Borders.Bottom);
                base.method_31(SprmCode.TCellBrcLeftStyle, format.Borders.Left);
                base.method_31(SprmCode.TCellBrcRightStyle, format.Borders.Top);
                base.method_31(SprmCode.TCellBrcInsideHStyle, format.Borders.Horizontal);
                base.method_31(SprmCode.TCellBrcInsideVStyle, format.Borders.Vertical);
                base.method_31(SprmCode.TCellBrcTL2BRStyle, format.Borders.DiagonalUp);
                base.method_31(SprmCode.TCellBrcTR2BLStyle, format.Borders.DiagonalDown);
                base.method_35(SprmCode.TCellShdStyle, format.method_31(0xc62));
                base.method_37(num);
            }
        }
        if (base.wordAttrCollection_0.method_6(0x1194))
        {
            base.class345_0.method_0(SprmCode.TCHorzBands, (int) ((long) base.wordAttrCollection_0.method_31(0x1194)));
        }
        if (base.wordAttrCollection_0.method_6(0x119e))
        {
            base.class345_0.method_0(SprmCode.TCVertBands, (int) ((long) base.wordAttrCollection_0.method_31(0x119e)));
        }
        base.method_35(SprmCode.TCellShdStyle, A_0.Interface8.imethod_1().method_31(0xc62));
        return new Class432(base.method_2());
    }

    private void method_69(int A_0, bool A_1)
    {
        if (A_1)
        {
            base.method_39(A_0);
        }
        else
        {
            base.method_38(A_0);
        }
    }

    private void method_70(SprmCode A_0)
    {
        bool flag = A_0 == SprmCode.TTableBorders;
        this.method_69(0xfd2, flag);
        this.method_69(0xfdc, flag);
        this.method_69(0xfe6, flag);
        this.method_69(0xff0, flag);
        this.method_69(0xffa, flag);
        this.method_69(0x1004, flag);
    }

    private void method_71()
    {
        if (base.binaryReader_0.ReadBoolean())
        {
            RowFormat format = (RowFormat) this.method_93().FormatRevision.method_4();
            if (!format.method_6(0x13ec))
            {
                Class732 class3 = new Class732();
                format.SetAttr(0x13ec, class3);
                Class732 class2 = (Class732) ((RowFormat) base.wordAttrCollection_0).method_31(0x13ec);
                for (int i = 0; i < class2.Count; i++)
                {
                    CellFormat format2 = new CellFormat();
                    class3.Add(format2);
                }
            }
            base.wordAttrCollection_0 = format;
        }
    }

    private void method_72()
    {
        base.binaryReader_0.ReadByte();
        base.binaryReader_0.ReadByte();
        CellAlign align = (CellAlign) base.binaryReader_0.ReadByte();
        Class15 class2 = this.method_74();
        if ((align == CellAlign.Box) && class2.method_57())
        {
            base.wordAttrCollection_0.SetAttr(0x10c2, class2.method_49() / 20f);
        }
    }

    private void method_73()
    {
        int num;
        base.binaryReader_0.ReadByte();
        base.binaryReader_0.ReadByte();
        CellAlign align = (CellAlign) base.binaryReader_0.ReadByte();
        Class15 class2 = this.method_74();
        if (class2.method_57())
        {
            num = (int) class2.method_49();
        }
        else
        {
            align &= CellAlign.Right | CellAlign.Left;
            num = 0;
        }
        if (base.method_54())
        {
            (base.wordAttrCollection_0 as CellFormat).Paddings.IsDefault = false;
        }
        else
        {
            (base.wordAttrCollection_0 as RowFormat).Paddings.IsDefault = false;
        }
        if ((align & CellAlign.Left) != CellAlign.None)
        {
            base.wordAttrCollection_0.SetAttr(base.method_54() ? 0xc12 : 0xfb4, ((float) num) / 20f);
        }
        if ((align & CellAlign.Top) != CellAlign.None)
        {
            base.wordAttrCollection_0.SetAttr(base.method_54() ? 0xbfe : 0x10cc, ((float) num) / 20f);
        }
        if ((align & CellAlign.Bottom) != CellAlign.None)
        {
            base.wordAttrCollection_0.SetAttr(base.method_54() ? 0xc08 : 0x10d6, ((float) num) / 20f);
        }
        if ((align & CellAlign.Right) != CellAlign.None)
        {
            base.wordAttrCollection_0.SetAttr(base.method_54() ? 0xc1c : 0x10e0, ((float) num) / 20f);
        }
    }

    private Class15 method_74()
    {
        FtsWidth width = (FtsWidth) base.binaryReader_0.ReadByte();
        int num = base.binaryReader_0.ReadInt16();
        return new Class15(width, (short) num);
    }

    private void method_75(Class15 A_0)
    {
        Class15 class2 = A_0;
        FtsWidth width = (FtsWidth) base.binaryReader_0.ReadByte();
        class2.method_52(width);
        class2.method_50((width != FtsWidth.Percentage) ? ((float) base.binaryReader_0.ReadInt16()) : (((float) base.binaryReader_0.ReadInt16()) / 50f));
    }

    private byte method_76()
    {
        byte num = base.binaryReader_0.ReadByte();
        base.binaryReader_0.ReadInt16();
        return num;
    }

    private void method_77(int A_0)
    {
        Class15 class2 = this.method_74();
        if (class2.method_57())
        {
            base.wordAttrCollection_0.SetAttr(A_0, class2.method_49() / 20f);
        }
    }

    private void method_78(int A_0)
    {
        Class15 class2 = base.wordAttrCollection_0.method_32(A_0) as Class15;
        class2.method_52((FtsWidth) base.binaryReader_0.ReadByte());
        class2.method_50((float) base.binaryReader_0.ReadInt16());
    }

    private void method_79()
    {
        this.class758_0.method_30(this.method_94());
        this.method_86(false);
        if (this.method_93().method_6(0xfb4) && !base.method_56())
        {
            base.class345_0.method_1(SprmCode.TDxaGapHalf, (int) ((this.method_93().Paddings.Left + this.method_93().Paddings.Right) / 2f));
        }
        this.method_82();
        base.method_3(SprmCode.TTableHeader, 0xfc8);
        this.method_87(false);
        this.method_88();
        this.class758_0.method_20(base.method_56(), this.class1056_0.method_0(), this.class1056_0.method_1(), (int) this.method_93().GridBeforeWidth.method_49());
        this.class758_0.method_18(SprmCode.TCellShd);
        this.method_89();
        base.method_9(SprmCode.TFBiDi, 0x111c);
        base.method_52(SprmCode.TPositionCode, 0x3f, 0x40);
        base.method_49(SprmCode.TFrameLeft, 0x3d, 0x3b);
        base.method_50(SprmCode.TFrameTop, 0x3e, 60);
        if (this.method_93().Positioning.HasKey(0x43))
        {
            base.method_16(SprmCode.TFromTextLeft, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromLeft * 20f), 2));
        }
        if (this.method_93().Positioning.HasKey(0x41))
        {
            base.method_16(SprmCode.TFromTextTop, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromTop * 20f), 2));
        }
        this.class758_0.method_18(SprmCode.TCellShdEx3);
        this.class758_0.method_18(SprmCode.TCellShdEx);
        this.method_87(true);
        this.method_90(SprmCode.TTableWidth, 0x1086);
        base.method_5(SprmCode.TFAllowAutoFit, base.wordAttrCollection_0.method_31(0x1090));
        this.class758_0.method_18(SprmCode.TCellShdEx2);
        this.method_91(SprmCode.TWidthBefore, 0x109a);
        this.method_91(SprmCode.TWidthAfter, 0x10a4);
        this.class758_0.method_21();
        if (this.method_93().Positioning.HasKey(0x44))
        {
            base.method_16(SprmCode.TFromTextRight, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromRight * 20f), 2));
        }
        if (this.method_93().Positioning.HasKey(0x42))
        {
            base.method_16(SprmCode.TFromTextBottom, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromBottom * 20f), 2));
        }
        Class592.smethod_3(this.method_94(), SprmCode.TCellPadding, this.class758_0);
        Class354.smethod_4(base.class345_0, SprmCode.TCellSpacingDefault, CellAlign.Box, this.method_93().method_31(0x10c2));
        if (!base.method_56())
        {
            Class592.smethod_1(this.method_93(), SprmCode.TCellPaddingDefault, this);
        }
        this.class758_0.method_26();
        base.method_34(SprmCode.TTableShd, 0x10ea);
        this.method_91(SprmCode.TLeftIndent, 0x10f4);
        base.method_6(SprmCode.TFCantOverlap, 0x10fe);
        base.method_6(SprmCode.TFCantSplit, 0x1108);
        this.class758_0.method_18(SprmCode.TCellShdExRaw);
        this.class758_0.method_18(SprmCode.TCellShdExRaw2);
        this.class758_0.method_18(SprmCode.TCellShdExRaw3);
        base.method_18(SprmCode.TRsidTr, 0x1130);
        base.method_9(SprmCode.TJcEx, 0xfaa);
        if ((base.wordAttrCollection_0 as RowFormat).IsChangedFormat)
        {
            WordAttrCollection attrs = base.wordAttrCollection_0;
            base.wordAttrCollection_0 = base.wordAttrCollection_0.FormatRevision.method_4();
            base.method_46(SprmCode.TPropRMark, SprmCode.TWall);
            base.wordAttrCollection_0 = attrs;
        }
    }

    private void method_80()
    {
        this.class758_0.method_30((Class732) this.method_93().method_31(0x13ec));
        int num = (int) (((this.method_93().Paddings.Left + this.method_93().Paddings.Right) * 20f) / 2f);
        base.class345_0.method_1(SprmCode.TDxaLeft, (this.class1056_0.method_0() + num) + ((int) this.method_93().GridBeforeWidth.method_49()));
        this.class758_0.method_13(base.method_56());
        this.class758_0.method_15(false);
        Class592.smethod_0((Class732) this.method_93().method_31(0x13ec), 0xbc2, SprmCode.TDxaCol, this.class758_0);
        if (this.method_83())
        {
            int num3;
            if (this.method_93().OwnerRow.OwnerTable.TableStyle is Style)
            {
                int num2 = this.method_93().Document.Styles.DocStyleCollection.method_17(this.method_93().OwnerRow.OwnerTable.TableStyle as Style);
                num3 = (num2 != 0xfff) ? num2 : 11;
            }
            else
            {
                num3 = 11;
            }
            base.class345_0.method_1(SprmCode.TIstd, num3);
        }
        if (!base.method_56() && (num != 0))
        {
            base.class345_0.method_1(SprmCode.TDxaGapHalf, num);
        }
        this.method_82();
        base.method_3(SprmCode.TTableHeader, 0xfc8);
        this.method_88();
        Class732 class2 = (Class732) this.rowFormat_1.method_31(0x13ec);
        this.class758_0.method_17(class2, SprmCode.TCellShd);
        base.method_9(SprmCode.TFBiDi, 0x111c);
        this.method_89();
        base.method_52(SprmCode.TPositionCode, 0x3f, 0x40);
        base.method_49(SprmCode.TFrameLeft, 0x3d, 0x3b);
        base.method_50(SprmCode.TFrameTop, 0x3e, 60);
        if (this.method_93().Positioning.HasKey(0x43))
        {
            base.method_16(SprmCode.TFromTextLeft, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromLeft * 20f), 2));
        }
        if (this.method_93().Positioning.HasKey(0x41))
        {
            base.method_16(SprmCode.TFromTextTop, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromTop * 20f), 2));
        }
        this.class758_0.method_17(class2, SprmCode.TCellShdEx3);
        this.class758_0.method_17(class2, SprmCode.TCellShdEx);
        this.class758_0.method_14();
        this.method_87(true);
        this.method_90(SprmCode.TTableWidth, 0x1086);
        base.method_5(SprmCode.TFAllowAutoFit, base.wordAttrCollection_0.method_32(0x1090));
        this.class758_0.method_17(class2, SprmCode.TCellShdEx2);
        this.method_91(SprmCode.TWidthBefore, 0x109a);
        this.method_91(SprmCode.TWidthAfter, 0x10a4);
        Class592.smethod_0(class2, 0xbea, SprmCode.TTextFlow, this.class758_0);
        Class592.smethod_0(class2, 0xbf4, SprmCode.TVertAlign, this.class758_0);
        if (this.method_93().Positioning.HasKey(0x44))
        {
            base.method_16(SprmCode.TFromTextRight, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromRight * 20f), 2));
        }
        if (this.method_93().Positioning.HasKey(0x42))
        {
            base.method_16(SprmCode.TFromTextBottom, (short) Math.Round((double) (this.method_93().Positioning.DistanceFromBottom * 20f), 2));
        }
        this.class758_0.method_16();
        this.class758_0.method_15(true);
        Class592.smethod_0(class2, 0xc76, SprmCode.TFitText, this.class758_0);
        Class592.smethod_0(class2, 0xc6c, SprmCode.TFCellNoWrap, this.class758_0);
        Class592.smethod_4(class2, SprmCode.TSetBrc, this.class758_0, icomparer_0);
        Class592.smethod_0(class2, 0xc94, SprmCode.TCellHideMark, this.class758_0);
        this.class758_0.method_26();
        object obj2 = null;
        if ((base.wordAttrCollection_0 as RowFormat).Positioning.method_6(0x45))
        {
            obj2 = !((bool) (base.wordAttrCollection_0 as RowFormat).Positioning.method_32(0x45));
        }
        base.method_4(SprmCode.TFCantOverlap, obj2);
        if ((base.wordAttrCollection_0 as RowFormat).IsChangedFormat)
        {
            WordAttrCollection attrs = base.wordAttrCollection_0;
            base.wordAttrCollection_0 = base.wordAttrCollection_0.FormatRevision.method_4();
            base.method_46(SprmCode.TPropRMark, SprmCode.TWall);
            base.wordAttrCollection_0 = attrs;
        }
        Class592.smethod_3(class2, SprmCode.TCellPadding, this.class758_0);
        Class354.smethod_4(base.class345_0, SprmCode.TCellSpacingDefault, CellAlign.Box, this.method_93().method_31(0x10c2));
        base.method_34(SprmCode.TTableShd, 0x10ea);
        Class592.smethod_1(this.method_93(), SprmCode.TCellPaddingDefault, this);
        base.method_6(SprmCode.TFCantSplit, 0x1108);
        this.class758_0.method_18(SprmCode.TCellShdExRaw);
        this.class758_0.method_18(SprmCode.TCellShdExRaw2);
        this.class758_0.method_18(SprmCode.TCellShdExRaw3);
        this.method_91(SprmCode.TLeftIndent, 0x10f4);
        base.method_18(SprmCode.TRsidTr, 0x1130);
        this.method_86(true);
    }

    private bool method_81()
    {
        for (int i = 0; i < this.method_94().Count; i++)
        {
            if ((this.method_94().method_0(i).HorizontalMerge != CellMerge.None) || (this.method_94().method_0(i).VerticalMerge != CellMerge.None))
            {
                return true;
            }
        }
        return false;
    }

    private void method_82()
    {
        if (this.method_81())
        {
            base.class345_0.method_4(SprmCode.TFCantSplit90, true);
        }
        else if (base.wordAttrCollection_0.HasKey(0x1108))
        {
            base.method_6(SprmCode.TFCantSplit90, 0x1108);
        }
    }

    private bool method_83()
    {
        return (true & !base.method_56());
    }

    private void method_84(CellCollection A_0, RowFormat A_1)
    {
        if (A_1.HasFormatRevision)
        {
            RowFormat format = (RowFormat) A_1.FormatRevision.method_4();
            Class732 class3 = new Class732();
            format.SetAttr(0x13ec, class3);
            foreach (TableCell cell in A_0)
            {
                Class580 formatRevision = cell.CellFormat.FormatRevision;
                class3.Add((formatRevision != null) ? formatRevision.method_4() : this.cellFormat_0);
            }
        }
    }

    private Class428 method_85(int A_0)
    {
        base.class345_0.BaseStream.Position = 0L;
        base.class345_0.method_3(SprmCode.PTableProps, A_0);
        return new Class428(base.method_2());
    }

    private void method_86(bool A_0)
    {
        if (this.method_93().HasKey(0xfaa))
        {
            object obj2 = this.method_93().method_31(0xfaa);
            if (obj2 != null)
            {
                base.class345_0.method_1(A_0 ? SprmCode.TJcEx : SprmCode.TJc, (int) obj2);
            }
        }
    }

    private void method_87(bool A_0)
    {
        RowFormat format = (!this.method_93().Borders.IsDefault || (this.method_93().OwnerRow == null)) ? this.method_93() : this.method_93().OwnerRow.OwnerTable.TableFormat;
        if (!format.Borders.IsDefault)
        {
            base.class345_0.method_5(A_0 ? SprmCode.TTableBorders : SprmCode.TTableBorders80);
            base.class345_0.Write((byte) (Class355.smethod_7(A_0) * 6));
            Class355.smethod_6(format.Borders.Top, base.class345_0, false, A_0);
            Class355.smethod_6(format.Borders.Left, base.class345_0, false, A_0);
            Class355.smethod_6(format.Borders.Bottom, base.class345_0, false, A_0);
            Class355.smethod_6(format.Borders.Right, base.class345_0, false, A_0);
            Class355.smethod_6(format.Borders.Horizontal, base.class345_0, false, A_0);
            Class355.smethod_6(format.Borders.Vertical, base.class345_0, false, A_0);
        }
    }

    private void method_88()
    {
        if (this.method_93().method_6(0x100e) || this.method_93().method_6(0x1018))
        {
            int num = Class59.smethod_8(this.method_93().Height * 20f, 0);
            if ((this.method_93().HeightType == TableRowHeightType.Exactly) && (num > 0))
            {
                num = -num;
            }
            base.class345_0.method_1(SprmCode.TDyaRowHeight, num);
        }
    }

    private void method_89()
    {
        if (!base.method_56() && (this.method_93().TableOption != TableStyleOptions.Default2003))
        {
            base.class345_0.method_5(SprmCode.TTlp);
            base.class345_0.Write((short) 0);
            base.class345_0.Write((short) Class531.smethod_1(this.method_93().TableOption));
        }
    }

    private void method_90(SprmCode A_0, int A_1)
    {
        Class15 preferredTableWidth = (Class15) this.method_93().method_32(A_1);
        if (preferredTableWidth.IsDefault)
        {
            Table ownerTable = this.method_93().OwnerRow.OwnerTable;
            if (ownerTable != null)
            {
                preferredTableWidth = ownerTable.PreferredTableWidth;
            }
        }
        if (preferredTableWidth != null)
        {
            base.class345_0.method_5(A_0);
            base.class345_0.Write((byte) preferredTableWidth.method_51());
            base.class345_0.Write((preferredTableWidth.method_51() != FtsWidth.Percentage) ? ((short) preferredTableWidth.method_49()) : ((short) (preferredTableWidth.method_49() * 50f)));
        }
    }

    private void method_91(SprmCode A_0, int A_1)
    {
        object obj2 = this.method_93().method_31(A_1);
        if ((obj2 != null) && this.method_93().HasKey(A_1))
        {
            int num;
            base.class345_0.method_5(A_0);
            base.class345_0.Write((byte) 3);
            if (obj2 is Class15)
            {
                num = (int) (obj2 as Class15).method_49();
            }
            else
            {
                num = (int) Math.Round((double) (((float) obj2) * 20f));
            }
            base.class345_0.Write((short) num);
        }
    }

    private void method_92()
    {
        if (this.method_93().PreferredWidth.method_51() == FtsWidth.Point)
        {
            int num = (int) (this.method_93().GridBeforeWidth.method_49() + this.method_93().GridAfterWidth.method_49());
            Class732 class2 = (Class732) this.method_93().method_31(0x13ec);
            for (int i = 0; i < class2.Count; i++)
            {
                num += class2.method_0(i).TwipCellWidth;
            }
            if ((this.method_93().PreferredWidth.method_49() > num) && (this.int_1 > 0))
            {
                this.method_93().GridBeforeWidth.method_50(this.method_93().PreferredWidth.method_49() - num);
            }
        }
    }

    private RowFormat method_93()
    {
        return (RowFormat) base.wordAttrCollection_0;
    }

    private Class732 method_94()
    {
        return this.method_93().CellsPr;
    }

    internal void method_95(bool A_0)
    {
        this.class479_0.method_2(A_0);
    }

    private bool method_96()
    {
        return (this.nfibEnum_0 >= NFibEnum.Word2002);
    }

    private static int smethod_1(SprmCode A_0)
    {
        switch (A_0)
        {
            case SprmCode.TCellBrcBottomStyle:
                return 0xc3a;

            case SprmCode.TCellBrcLeftStyle:
                return 0xc30;

            case SprmCode.TCellBrcRightStyle:
                return 0xc44;

            case SprmCode.TCellBrcInsideHStyle:
                return 0xc80;

            case SprmCode.TCellBrcInsideVStyle:
                return 0xc8a;

            case SprmCode.TCellBrcTL2BRStyle:
                return 0xc4e;

            case SprmCode.TCellBrcTR2BLStyle:
                return 0xc58;

            case SprmCode.TCellBrcTopStyle:
                return 0xc26;
        }
        return 0;
    }

    private static void smethod_2(CellCollection A_0, RowFormat A_1, bool A_2)
    {
        Class732 class2 = new Class732();
        A_1.SetAttr(0x13ec, class2);
        foreach (TableCell cell in A_0)
        {
            class2.Add(A_2 ? cell.CellFormat.SysDirectAttrs : cell.CellFormat);
        }
    }

    protected override void vmethod_0()
    {
        if (this.bool_3)
        {
            this.method_80();
        }
        else
        {
            this.method_79();
        }
    }

    protected override void vmethod_1(int A_0)
    {
        throw new NotImplementedException();
    }
}

