using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Converters.BinaryDoc.Tables;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.IO;

internal class Class758 : Interface53
{
    private BinaryReader binaryReader_0;
    private static readonly Border border_0 = new Border();
    private static readonly Class16 class16_0 = new Class16();
    private Class345 class345_0;
    private Class732 class732_0;
    private const int int_0 = 0x16;

    private int imethod_1(SprmCode A_0, CellAlign A_1)
    {
        int num = 0x12;
        SprmCode code = A_0;
        if (code == SprmCode.TSetBrc)
        {
            return smethod_4(A_1);
        }
        if (code != SprmCode.TCellPadding)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("瘷唹䠻ḽ⤿⽁㑃⩅ⵇ❉⥋⁍⑏㝑こ癕㹗㕙⹛繝᭟剡ᥣ䙥ṧ୩k᭭ᕯ山", num), A_0));
        }
        return smethod_5(A_1);
    }

    private void imethod_2(SprmCode A_0, int A_1, int A_2, CellAlign A_3, object A_4)
    {
        int num = 0x10;
        SprmCode code = A_0;
        if (code <= SprmCode.TSetBrc)
        {
            if (code > SprmCode.TTextFlow)
            {
                if (code == SprmCode.TVertAlign)
                {
                    VerticalAlignment alignment = (VerticalAlignment) A_4;
                    if (alignment != VerticalAlignment.Top)
                    {
                        this.class345_0.method_5(SprmCode.TVertAlign);
                        this.class345_0.Write((byte) 3);
                        this.class345_0.Write((byte) A_1);
                        this.class345_0.Write((byte) A_2);
                        this.class345_0.Write((byte) alignment);
                        return;
                    }
                    return;
                }
                if (code == SprmCode.TSetBrc)
                {
                    this.method_27(A_1, A_2, (Border) A_4, A_3, SprmCode.TSetBrc);
                    return;
                }
            }
            else
            {
                if (code == SprmCode.TDxaCol)
                {
                    int num2 = (int) Math.Round((double) (float.Parse(A_4.ToString()) * 20f));
                    this.class345_0.method_5(SprmCode.TDxaCol);
                    this.class345_0.Write((byte) A_1);
                    this.class345_0.Write((byte) A_2);
                    this.class345_0.Write((short) num2);
                    return;
                }
                if (code == SprmCode.TTextFlow)
                {
                    TextDirection direction = (TextDirection) A_4;
                    if (direction != TextDirection.TopToBottom)
                    {
                        this.class345_0.method_5(SprmCode.TTextFlow);
                        this.class345_0.Write((byte) A_1);
                        this.class345_0.Write((byte) A_2);
                        this.class345_0.Write((ushort) direction);
                        return;
                    }
                    return;
                }
            }
        }
        else if (code > SprmCode.TCellWidth)
        {
            switch (code)
            {
                case SprmCode.TFCellNoWrap:
                    if (!((bool) A_4))
                    {
                        this.class345_0.method_5(SprmCode.TFCellNoWrap);
                        this.class345_0.Write((byte) 3);
                        this.class345_0.Write((byte) A_1);
                        this.class345_0.Write((byte) A_2);
                        this.class345_0.Write((byte) 1);
                        return;
                    }
                    return;

                case SprmCode.TCellHideMark:
                    if ((bool) A_4)
                    {
                        this.class345_0.method_5(SprmCode.TCellHideMark);
                        this.class345_0.Write((byte) 3);
                        this.class345_0.Write((byte) A_1);
                        this.class345_0.Write((byte) A_2);
                        this.class345_0.Write((byte) 1);
                    }
                    return;

                case SprmCode.TFitText:
                    if ((bool) A_4)
                    {
                        this.class345_0.method_5(SprmCode.TFitText);
                        this.class345_0.Write((byte) A_1);
                        this.class345_0.Write((byte) A_2);
                        this.class345_0.Write((byte) 1);
                    }
                    return;
            }
        }
        else
        {
            if (code == SprmCode.TCellPadding)
            {
                Class354.smethod_5(this.class345_0, SprmCode.TCellPadding, A_1, A_2, A_3, A_4);
                return;
            }
            if (code == SprmCode.TCellWidth)
            {
                Class15 class2 = new Class15(FtsWidth.None, 0);
                switch (this.class732_0.method_0(A_1).WidthUnit)
                {
                    case FtsWidth.Auto:
                        class2 = new Class15(FtsWidth.Auto, 0);
                        break;

                    case FtsWidth.Percentage:
                        class2 = new Class15(FtsWidth.Percentage, (short) Math.Round((double) (this.class732_0.method_0(A_1).CellWidth * 50f)));
                        break;

                    case FtsWidth.Point:
                        class2 = new Class15(FtsWidth.Point, (short) Math.Round((double) (this.class732_0.method_0(A_1).CellWidth * 20f)));
                        break;
                }
                this.method_23(A_1, A_2, (int) class2.method_51(), (int) class2.method_49());
                class2.Close();
                class2 = null;
                return;
            }
        }
        throw new InvalidOperationException(string.Format(BookmarkStart.b("砵圷丹᰻圽ⴿ㉁⡃⍅╇⽉≋㩍㕏㙑瑓さ㝗⡙籛╝偟ὡ䑣ၥ१٩ᥫ୭幯", num), A_0));
    }

    internal void method_0(int A_0, int A_1, object A_2)
    {
        if (this.class732_0 != null)
        {
            int num2 = A_0 & 0xff;
            int num3 = A_0 >> 8;
            num2 = Math.Min(num2, this.class732_0.Count);
            num3 = Math.Min(num3, this.class732_0.Count);
            for (int i = num2; i < num3; i++)
            {
                this.class732_0.method_0(i).SetAttr(A_1, A_2);
            }
        }
    }

    internal void method_1(int A_0, object A_1)
    {
        if (this.class732_0 != null)
        {
            int num2 = A_0 & 0xff;
            int num3 = A_0 >> 8;
            num2 = Math.Min(num2, this.class732_0.Count);
            num3 = Math.Min(num3, this.class732_0.Count);
            for (int i = num2; i < num3; i++)
            {
                this.class732_0.method_0(i).TwipCellWidth = (int) Math.Round((double) (((float) A_1) * 20f), 2);
                this.class732_0.method_0(i).Cellx = (short) (((i == 0) ? 0 : this.class732_0.method_0(i - 1).Cellx) + this.class732_0.method_0(i).TwipCellWidth);
            }
        }
    }

    internal void method_10(SprmCode A_0)
    {
        int num = this.binaryReader_0.ReadByte();
        int num2 = this.binaryReader_0.ReadByte();
        CellAlign align = (CellAlign) this.binaryReader_0.ReadByte();
        Border border = (A_0 == SprmCode.TSetBrc) ? Class355.smethod_1(this.binaryReader_0, null) : Class355.smethod_0(this.binaryReader_0, null);
        num = Math.Min(num, this.class732_0.Count);
        num2 = Math.Min(num2, this.class732_0.Count);
        for (int i = num; i < num2; i++)
        {
            CellFormat format = this.class732_0.method_0(i);
            if ((align & CellAlign.Left) != CellAlign.None)
            {
                this.method_28(format, 0xc30, border);
            }
            if ((align & CellAlign.Top) != CellAlign.None)
            {
                this.method_28(format, 0xc26, border);
            }
            if ((align & CellAlign.Bottom) != CellAlign.None)
            {
                this.method_28(format, 0xc3a, border);
            }
            if ((align & CellAlign.Right) != CellAlign.None)
            {
                this.method_28(format, 0xc44, border);
            }
            if ((align & CellAlign.DiagonalDown) != CellAlign.None)
            {
                this.method_28(format, 0xc4e, border);
            }
            if ((align & CellAlign.DiagonalUp) != CellAlign.None)
            {
                this.method_28(format, 0xc58, border);
            }
        }
    }

    private void method_11(Border A_0, Border A_1)
    {
        IDictionaryEnumerator enumerator = A_1.PropertiesHash.GetEnumerator();
        while (enumerator.MoveNext())
        {
            A_0[(int) enumerator.Key] = enumerator.Value;
        }
    }

    internal void method_12(SprmCode A_0, int A_1)
    {
        int num = 0;
        switch (A_0)
        {
            case SprmCode.TBrcTopCv:
                num = 0xc26;
                break;

            case SprmCode.TBrcLeftCv:
                num = 0xc30;
                break;

            case SprmCode.TBrcBottomCv:
                num = 0xc3a;
                break;

            case SprmCode.TBrcRightCv:
                num = 0xc44;
                break;
        }
        int num2 = A_1 / 4;
        for (int i = 0; i < num2; i++)
        {
            int num4 = this.binaryReader_0.ReadInt32();
            if (this.class732_0.method_0(i).method_6(num))
            {
                Border border = (Border) this.class732_0.method_0(i).method_32(num);
                border.Color = Class624.smethod_7(num4);
            }
        }
    }

    internal void method_13(bool A_0)
    {
        if (!A_0)
        {
            this.class345_0.method_3(SprmCode.TInsert, (this.method_29().Count << 8) + 0x1680000);
        }
    }

    internal void method_14()
    {
        int num = -1;
        for (int i = 0; i < this.class732_0.Count; i++)
        {
            CellMerge horizontalMerge = this.class732_0.method_0(i).HorizontalMerge;
            switch (horizontalMerge)
            {
                case CellMerge.Start:
                case CellMerge.None:
                    if (num >= 0)
                    {
                        this.method_24(num, i);
                    }
                    num = (horizontalMerge == CellMerge.Start) ? i : -1;
                    break;
            }
        }
        if (num >= 0)
        {
            this.method_24(num, this.class732_0.Count);
        }
    }

    internal void method_15(bool A_0)
    {
        if (A_0)
        {
            Class592.smethod_0(this.class732_0, 0xbc4, SprmCode.TCellWidth, this);
        }
        else
        {
            for (int i = 0; i < this.class732_0.Count; i++)
            {
                if ((this.class732_0.method_0(i).WidthUnit == FtsWidth.Auto) || (this.class732_0.method_0(i).WidthUnit == FtsWidth.None))
                {
                    this.method_23(i, i + 1, 3, this.class732_0.method_0(i).TwipCellWidth);
                }
            }
        }
    }

    internal void method_16()
    {
        for (int i = 0; i < this.class732_0.Count; i++)
        {
            if (this.class732_0.method_0(i).VerticalMerge == CellMerge.Start)
            {
                this.method_25(i, 3);
            }
            else if (this.class732_0.method_0(i).VerticalMerge == CellMerge.Continue)
            {
                this.method_25(i, 1);
            }
        }
    }

    internal void method_17(Class732 A_0, SprmCode A_1)
    {
        Class732 class2 = this.class732_0;
        this.class732_0 = A_0;
        this.method_18(A_1);
        this.class732_0 = class2;
    }

    internal void method_18(SprmCode A_0)
    {
        int num = 3;
        if (this.method_19(A_0))
        {
            int num5;
            int num2 = smethod_0(A_0);
            bool flag = A_0 != SprmCode.TCellShd;
            int count = 0;
            if (flag)
            {
                num5 = num2 * 0x16;
                if (num5 >= this.class732_0.Count)
                {
                    return;
                }
                count = Math.Min(this.class732_0.Count, (num2 + 1) * 0x16);
            }
            else
            {
                num5 = 0;
                count = this.class732_0.Count;
            }
            int num6 = count - num5;
            int num7 = num6 * Class1106.smethod_5(flag);
            if (num7 > 220)
            {
                throw new InvalidOperationException(BookmarkStart.b("樨个䄬䌮ᄰ䀲崴嘶崸刺匼堾慀あ㕄㕆⑈歊⑌㱎煐❒㩔㡖祘㝚㉜ㅞ٠䵢", num));
            }
            this.class345_0.method_5(A_0);
            this.class345_0.Write((byte) num7);
            for (int i = num5; i < count; i++)
            {
                Class16 class2 = (Class16) this.class732_0.method_0(i).method_31(0xc62);
                if ((class2 == null) || (class2.OwnerBase != null))
                {
                    class2 = class16_0;
                }
                Class1106.smethod_4(class2, this.class345_0, flag);
            }
        }
    }

    private bool method_19(SprmCode A_0)
    {
        int num = smethod_0(A_0);
        int num2 = num * 0x16;
        int num3 = Math.Min(this.class732_0.Count, (num + 1) * 0x16);
        for (int i = num2; i < num3; i++)
        {
            if (this.class732_0.method_0(i).method_6(0xc62))
            {
                return true;
            }
        }
        return false;
    }

    internal void method_2(RowFormat A_0, int A_1, NFibEnum A_2)
    {
        this.class732_0 = new Class732();
        A_0.SetAttr(0x13ec, this.class732_0);
        int position = (int) this.binaryReader_0.BaseStream.Position;
        int num2 = this.binaryReader_0.ReadByte();
        int[] numArray = new int[num2 + 1];
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = this.binaryReader_0.ReadInt16();
        }
        A_0.SetAttr(0x13f2, numArray);
        A_0.SetAttr(0x13ee, numArray[0]);
        for (int j = 0; j < num2; j++)
        {
            CellFormat format = new CellFormat();
            int num6 = ((int) this.binaryReader_0.BaseStream.Position) - position;
            if (num6 < A_1)
            {
                Class354.smethod_0(this.binaryReader_0, format);
            }
            int num5 = numArray[j + 1] - numArray[j];
            format.Cellx = (short) numArray[j + 1];
            format.TwipCellWidth = num5;
            if (A_2 <= NFibEnum.Word97)
            {
                format.WidthUnit = FtsWidth.Point;
                format.CellWidth = ((float) num5) / 20f;
            }
            else if ((A_2 <= NFibEnum.Word2000) && (!format.method_6(0xbc6) || !format.method_6(0xbc4)))
            {
                format.WidthUnit = FtsWidth.Point;
                format.CellWidth = ((float) num5) / 20f;
            }
            this.class732_0.Add(format);
        }
    }

    internal void method_20(bool A_0, int A_1, int A_2, int A_3)
    {
        this.class345_0.method_5(SprmCode.TDefTable);
        int num = ((1 + ((this.class732_0.Count + 1) * 2)) + (this.class732_0.Count * 20)) + 1;
        this.class345_0.Write((short) num);
        this.class345_0.Write((byte) this.class732_0.Count);
        int num4 = (A_0 ? A_2 : A_1) + A_3;
        this.class345_0.Write((short) num4);
        for (int i = 0; i < this.class732_0.Count; i++)
        {
            num4 += this.class732_0.method_0(i).TwipCellWidth;
            this.class345_0.Write((short) num4);
        }
        for (int j = 0; j < this.class732_0.Count; j++)
        {
            Class354.smethod_1(this.class732_0.method_0(j), this.class345_0);
        }
    }

    internal void method_21()
    {
        this.method_22(SprmCode.TBrcTopCv, 0xc26);
        this.method_22(SprmCode.TBrcLeftCv, 0xc30);
        this.method_22(SprmCode.TBrcBottomCv, 0xc3a);
        this.method_22(SprmCode.TBrcRightCv, 0xc44);
    }

    private void method_22(SprmCode A_0, int A_1)
    {
        if (this.class732_0 != null)
        {
            this.class345_0.method_5(A_0);
            this.class345_0.Write((byte) (this.class732_0.Count * 4));
            for (int i = 0; i < this.class732_0.Count; i++)
            {
                Border border = (Border) this.class732_0.method_0(i).method_31(A_1);
                if ((border == null) || border.IsDefault)
                {
                    border = border_0;
                }
                this.class345_0.Write(Class624.smethod_6(border.Color));
            }
        }
    }

    private void method_23(int A_0, int A_1, int A_2, int A_3)
    {
        this.class345_0.method_5(SprmCode.TCellWidth);
        this.class345_0.Write((byte) 5);
        this.class345_0.Write((byte) A_0);
        this.class345_0.Write((byte) A_1);
        this.class345_0.Write((byte) A_2);
        this.class345_0.Write((short) A_3);
    }

    private void method_24(int A_0, int A_1)
    {
        this.class345_0.method_5(SprmCode.TMerge);
        this.class345_0.Write((byte) A_0);
        this.class345_0.Write((byte) A_1);
    }

    private void method_25(int A_0, int A_1)
    {
        this.class345_0.method_5(SprmCode.TVertMerge);
        this.class345_0.Write((byte) 2);
        this.class345_0.Write((byte) A_0);
        this.class345_0.Write((byte) A_1);
    }

    internal void method_26()
    {
        if (this.class732_0 != null)
        {
            for (int i = 0; i < this.class732_0.Count; i++)
            {
                this.method_27(i, i + 1, (Border) this.class732_0.method_0(i).method_31(0xc4e), CellAlign.DiagonalDown, SprmCode.TSetBrc80);
                this.method_27(i, i + 1, (Border) this.class732_0.method_0(i).method_31(0xc4e), CellAlign.DiagonalDown, SprmCode.TSetBrc);
                this.method_27(i, i + 1, (Border) this.class732_0.method_0(i).method_31(0xc58), CellAlign.DiagonalUp, SprmCode.TSetBrc80);
                this.method_27(i, i + 1, (Border) this.class732_0.method_0(i).method_31(0xc58), CellAlign.DiagonalUp, SprmCode.TSetBrc);
            }
        }
    }

    private void method_27(int A_0, int A_1, Border A_2, CellAlign A_3, SprmCode A_4)
    {
        if ((A_2 != null) && !A_2.IsDefault)
        {
            this.class345_0.method_5(A_4);
            int num = 3 + Class355.smethod_7(A_4 == SprmCode.TSetBrc);
            this.class345_0.Write((byte) num);
            this.class345_0.Write((byte) A_0);
            this.class345_0.Write((byte) A_1);
            this.class345_0.Write((byte) A_3);
            Class355.smethod_6(A_2.Equals(new Border()) ? null : A_2, this.class345_0, false, A_4 == SprmCode.TSetBrc);
        }
    }

    private void method_28(CellFormat A_0, int A_1, Border A_2)
    {
        Border border = (Border) A_0.method_33(A_1);
        if (A_2 == null)
        {
            A_0.SetAttr(A_1, border);
        }
        else
        {
            this.method_11(border, A_2);
        }
    }

    internal Class732 method_29()
    {
        return this.class732_0;
    }

    private void method_3(CellFormat A_0, int A_1)
    {
        switch (A_0.WidthUnit)
        {
            case FtsWidth.None:
                if (A_1 > 0)
                {
                    A_0.CellWidth = A_1;
                    A_0.WidthUnit = FtsWidth.Point;
                }
                return;

            case FtsWidth.Auto:
            case FtsWidth.Percentage:
                return;
        }
        A_0.CellWidth = ((float) A_1) / 20f;
        A_0.WidthUnit = FtsWidth.Point;
    }

    internal void method_30(Class732 A_0)
    {
        this.class732_0 = A_0;
    }

    internal void method_31(BinaryReader A_0)
    {
        this.binaryReader_0 = A_0;
    }

    internal void method_32(Class345 A_0)
    {
        this.class345_0 = A_0;
    }

    internal void method_4(RowFormat A_0)
    {
        this.class732_0 = new Class732();
        A_0.SetAttr(0x13ec, this.class732_0);
        int num = this.binaryReader_0.ReadByte();
        int num2 = this.binaryReader_0.ReadByte();
        int num3 = this.binaryReader_0.ReadInt16();
        for (int i = num; i < num2; i++)
        {
            CellFormat format = new CellFormat();
            format.SetAttr(0xbf4, VerticalAlignment.Top);
            format.SetAttr(0xc6c, true);
            format.TwipCellWidth = num3;
            this.class732_0.Add(format);
        }
    }

    internal void method_5()
    {
        int num = this.binaryReader_0.ReadByte();
        int num2 = Math.Min(this.binaryReader_0.ReadByte(), this.class732_0.Count);
        this.class732_0.method_0(num).SetAttr(0xbe0, CellMerge.Start);
        for (int i = num + 1; i < num2; i++)
        {
            this.class732_0.method_0(i).SetAttr(0xbe0, CellMerge.Continue);
        }
    }

    internal void method_6()
    {
        int num = this.binaryReader_0.ReadByte();
        int num2 = this.binaryReader_0.ReadByte();
        bool flag = num2 == 1;
        CellMerge merge = (num2 == 3) ? CellMerge.Start : (flag ? CellMerge.Continue : CellMerge.None);
        this.class732_0.method_0(num).SetAttr(0xbd6, merge);
    }

    internal void method_7()
    {
        int num = this.binaryReader_0.ReadByte();
        int num2 = this.binaryReader_0.ReadByte();
        CellAlign align = (CellAlign) this.binaryReader_0.ReadByte();
        Class15 class2 = smethod_2(this.binaryReader_0);
        if (class2.method_57())
        {
            num = Math.Min(num, this.class732_0.Count);
            num2 = Math.Min(num2, this.class732_0.Count);
            int num3 = (int) class2.method_49();
            for (int i = num; i < num2; i++)
            {
                CellFormat format = this.class732_0.method_0(i);
                format.SamePaddingsAsTable = false;
                if ((align & CellAlign.Left) != CellAlign.None)
                {
                    format.SetAttr(0xc12, ((float) num3) / 20f);
                }
                if ((align & CellAlign.Top) != CellAlign.None)
                {
                    format.SetAttr(0xbfe, ((float) num3) / 20f);
                }
                if ((align & CellAlign.Bottom) != CellAlign.None)
                {
                    format.SetAttr(0xc08, ((float) num3) / 20f);
                }
                if ((align & CellAlign.Right) != CellAlign.None)
                {
                    format.SetAttr(0xc1c, ((float) num3) / 20f);
                }
            }
        }
    }

    internal void method_8(SprmCode A_0, int A_1)
    {
        int num = 9;
        if (A_0 == SprmCode.TCellShd)
        {
            int num2 = A_1 / 2;
            for (int i = 0; i < num2; i++)
            {
                smethod_1(this.binaryReader_0, this.class732_0.method_0(i), A_0);
            }
        }
        else
        {
            switch ((A_1 % 10))
            {
                case 0:
                    break;

                case 4:
                    A_1 += 0x100;
                    break;

                default:
                    throw new InvalidOperationException(BookmarkStart.b("氮吰弲头᜶䨸区尼嬾⡀ⵂ≄杆⁈╊浌㩎㽐㡒㭔㡖⹘㕚絜㥞๠ᅢࡤ٦ᵨ䭪Ѭᱮ兰ᙲ᭴ᑶᙸ๺፼୾ꞈ", num));
            }
            int num5 = smethod_0(A_0) * 0x16;
            int num6 = A_1 / 10;
            int num7 = num5 + num6;
            for (int j = num5; j < num7; j++)
            {
                smethod_1(this.binaryReader_0, this.class732_0.method_0(j), A_0);
            }
        }
    }

    internal void method_9(int A_0)
    {
        int num = A_0 / 4;
        for (int i = 0; i < num; i++)
        {
            CellFormat format = this.class732_0.method_0(i);
            smethod_3(format, 0xc26, (BorderStyle) this.binaryReader_0.ReadByte());
            smethod_3(format, 0xc30, (BorderStyle) this.binaryReader_0.ReadByte());
            smethod_3(format, 0xc3a, (BorderStyle) this.binaryReader_0.ReadByte());
            smethod_3(format, 0xc44, (BorderStyle) this.binaryReader_0.ReadByte());
        }
    }

    private static int smethod_0(SprmCode A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case SprmCode.TCellShd:
            case SprmCode.TCellShdExRaw:
            case SprmCode.TCellShdEx:
                return 0;

            case SprmCode.TCellShdEx3:
            case SprmCode.TCellShdExRaw3:
                return 2;

            case SprmCode.TCellShdExRaw2:
            case SprmCode.TCellShdEx2:
                return 1;
        }
        throw new InvalidOperationException(BookmarkStart.b("支就弳堵圷䴹刻ḽ㌿㉁㙃⭅桇⥉⍋⩍㕏籑", num));
    }

    private static void smethod_1(BinaryReader A_0, WordAttrCollection A_1, SprmCode A_2)
    {
        Class16 class2 = (Class16) A_1.method_31(0xc62);
        Class16 class3 = (A_2 == SprmCode.TCellShd) ? Class1106.smethod_0(A_0, class2) : Class1106.smethod_1(A_0, class2);
        if (class3 != null)
        {
            A_1.SetAttr(0xc62, class3);
        }
    }

    private static Class15 smethod_2(BinaryReader A_0)
    {
        FtsWidth width = (FtsWidth) A_0.ReadByte();
        int num = A_0.ReadInt16();
        return new Class15(width, (short) num);
    }

    private static void smethod_3(CellFormat A_0, int A_1, BorderStyle A_2)
    {
        Border border = (Border) A_0.method_31(A_1);
        if (border != null)
        {
            border.BorderType = A_2;
        }
    }

    private static int smethod_4(CellAlign A_0)
    {
        switch (A_0)
        {
            case CellAlign.Top:
                return 0xc26;

            case CellAlign.Left:
                return 0xc30;

            case CellAlign.Bottom:
                return 0xc3a;

            case CellAlign.Right:
                return 0xc44;

            case CellAlign.DiagonalDown:
                return 0xc4e;

            case CellAlign.DiagonalUp:
                return 0xc58;
        }
        throw new InvalidOperationException();
    }

    private static int smethod_5(CellAlign A_0)
    {
        switch (A_0)
        {
            case CellAlign.Top:
                return 0xbfe;

            case CellAlign.Left:
                return 0xc12;

            case CellAlign.Bottom:
                return 0xc08;

            case CellAlign.Right:
                return 0xc1c;

            case CellAlign.DiagonalDown:
            case CellAlign.DiagonalUp:
                return 0;
        }
        throw new InvalidOperationException();
    }
}

