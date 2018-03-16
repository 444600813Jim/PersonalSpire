using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class142 : Class139, Interface15
{
    private Class479 class479_0;

    internal Class142(Class812 A_0) : base(A_0)
    {
        this.class479_0 = new Class479(this, null);
    }

    private bool imethod_0(SprmCode A_0, SprmType A_1, int A_2, BinaryReader A_3)
    {
        if (A_1 != SprmType.Sep)
        {
            return true;
        }
        base.binaryReader_0 = A_3;
        SprmCode code = A_0;
        if (code > SprmCode.SPgbProp)
        {
            switch (code)
            {
                case SprmCode.SBrcTop:
                    base.method_38(0x852);
                    goto Label_0BBA;

                case SprmCode.SBrcLeft:
                    base.method_38(0x85c);
                    goto Label_0BBA;

                case SprmCode.SBrcBottom:
                    base.method_38(0x866);
                    goto Label_0BBA;

                case SprmCode.SBrcRight:
                    base.method_38(0x870);
                    goto Label_0BBA;

                case SprmCode.SDxtCharSpace:
                    base.wordAttrCollection_0.SetAttr(0x974, base.binaryReader_0.ReadInt32());
                    goto Label_0BBA;

                case SprmCode.SRsid:
                    base.wordAttrCollection_0.SetAttr(0x8ca, base.binaryReader_0.ReadInt32());
                    goto Label_0BBA;

                case SprmCode.SPgnStart:
                    base.wordAttrCollection_0.SetAttr(0x898, base.binaryReader_0.ReadInt32());
                    goto Label_0BBA;

                case SprmCode.SDyaTop:
                    base.wordAttrCollection_0.SetAttr(0x8fc, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDyaBottom:
                    base.wordAttrCollection_0.SetAttr(0x906, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDxaLnn:
                    base.wordAttrCollection_0.SetAttr(0x960, ((float) base.binaryReader_0.ReadUInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDxaColumns:
                    base.wordAttrCollection_0.SetAttr(0x942, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SDyaHdrTop:
                    base.wordAttrCollection_0.SetAttr(0x910, ((float) base.binaryReader_0.ReadUInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDyaHdrBottom:
                    base.wordAttrCollection_0.SetAttr(0x91a, ((float) base.binaryReader_0.ReadUInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDyaLinePitch:
                    base.wordAttrCollection_0.SetAttr(0x87a, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SXaPage:
                    base.wordAttrCollection_0.SetAttr(0x8d4, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SYaPage:
                    base.wordAttrCollection_0.SetAttr(0x8de, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDxaLeft:
                    base.wordAttrCollection_0.SetAttr(0x8e8, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDxaRight:
                    base.wordAttrCollection_0.SetAttr(0x8f2, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SDzaGutter:
                    base.wordAttrCollection_0.SetAttr(0x908, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                    goto Label_0BBA;

                case SprmCode.SBrcTopEx:
                    base.method_39(0x852);
                    goto Label_0BBA;

                case SprmCode.SBrcLeftEx:
                    base.method_39(0x85c);
                    goto Label_0BBA;

                case SprmCode.SBrcBottomEx:
                    base.method_39(0x866);
                    goto Label_0BBA;

                case SprmCode.SBrcRightEx:
                    base.method_39(0x870);
                    goto Label_0BBA;

                case SprmCode.SPropRMark:
                    base.method_44(new Class17(base.document_0));
                    goto Label_0BBA;

                case SprmCode.SDxaColWidth:
                {
                    int num7 = base.binaryReader_0.ReadByte();
                    this.method_68(num7).Width = ((float) base.binaryReader_0.ReadInt16()) / 20f;
                    goto Label_0BBA;
                }
                case SprmCode.SDxaColSpacing:
                {
                    int num3 = base.binaryReader_0.ReadByte();
                    this.method_68(num3).Space = ((float) base.binaryReader_0.ReadInt16()) / 20f;
                    goto Label_0BBA;
                }
            }
        }
        else if (code > SprmCode.SColumns)
        {
            switch (code)
            {
                case SprmCode.SLnnMin:
                    base.wordAttrCollection_0.SetAttr(0x884, base.binaryReader_0.ReadInt16() + 1);
                    goto Label_0BBA;

                case SprmCode.SPgnStart97:
                    base.wordAttrCollection_0.SetAttr(0x898, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SDmPaperReq:
                    base.wordAttrCollection_0.SetAttr(0x82a, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SNLnnMod:
                    base.wordAttrCollection_0.SetAttr(0x848, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SClm:
                    base.wordAttrCollection_0.SetAttr(0x97e, (GridPitchType) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.STextFlow:
                    switch (base.binaryReader_0.ReadInt16())
                    {
                        case 1:
                            base.wordAttrCollection_0.SetAttr(0x988, TextDirection.RightToLeft);
                            goto Label_0BBA;

                        case 4:
                            base.wordAttrCollection_0.SetAttr(0x988, TextDirection.TopToBottomRotated);
                            goto Label_0BBA;
                    }
                    base.wordAttrCollection_0.SetAttr(0x988, TextDirection.TopToBottom);
                    goto Label_0BBA;

                case SprmCode.SNFtn:
                    base.wordAttrCollection_0.SetAttr(0x9d8, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SNfcFtnRef:
                    base.wordAttrCollection_0.SetAttr(0x9e2, (FootnoteNumberFormat) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SNEdn:
                    base.wordAttrCollection_0.SetAttr(0xa3c, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SNfcEdnRef:
                    base.wordAttrCollection_0.SetAttr(0xa46, (FootnoteNumberFormat) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SPgbProp:
                {
                    int num4 = base.binaryReader_0.ReadUInt16();
                    base.wordAttrCollection_0.SetAttr(0x8ac, ((PageBordersApplyType) num4) & ((PageBordersApplyType) 7));
                    base.wordAttrCollection_0.SetAttr(0x8b6, ((num4 & 0x18) >> 3) == 0);
                    base.wordAttrCollection_0.SetAttr(0x8c0, (PageBorderOffsetFrom) ((num4 & 0xe0) >> 5));
                    goto Label_0BBA;
                }
            }
        }
        else
        {
            switch (code)
            {
                case SprmCode.ScnsPgn:
                    base.wordAttrCollection_0.SetAttr(0x7e4, (PageSeparator) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SHeadingPgn:
                    base.wordAttrCollection_0.SetAttr(0x88e, (int) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SFEvenlySpaced:
                    base.wordAttrCollection_0.SetAttr(0x938, base.binaryReader_0.ReadByte() == 1);
                    goto Label_0BBA;

                case SprmCode.SFProtected:
                    base.wordAttrCollection_0.SetAttr(0x956, base.binaryReader_0.ReadByte() == 1);
                    goto Label_0BBA;

                case SprmCode.SBkc:
                    base.wordAttrCollection_0.SetAttr(0x7ee, (SectionBreakType) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SFTitlePage:
                    base.wordAttrCollection_0.SetAttr(0x7f8, base.binaryReader_0.ReadByte() != 0);
                    goto Label_0BBA;

                case SprmCode.SNfcPgn:
                    base.wordAttrCollection_0.SetAttr(0x7da, (PageNumberStyle) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SFPgnRestart:
                {
                    bool flag = base.binaryReader_0.ReadByte() == 1;
                    base.wordAttrCollection_0.SetAttr(0x802, flag);
                    if (flag)
                    {
                        base.wordAttrCollection_0.SetAttr(0x898, 0);
                    }
                    goto Label_0BBA;
                }
                case SprmCode.SFEndnote:
                    base.wordAttrCollection_0.SetAttr(0x834, base.binaryReader_0.ReadByte() != 1);
                    goto Label_0BBA;

                case SprmCode.SLnc:
                    base.wordAttrCollection_0.SetAttr(0x83e, (LineNumberingRestartMode) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SGprfIhdt:
                    goto Label_0BBA;

                case SprmCode.SLBetween:
                    base.wordAttrCollection_0.SetAttr(0x80c, base.binaryReader_0.ReadByte() == 1);
                    goto Label_0BBA;

                case SprmCode.SVjc:
                    base.wordAttrCollection_0.SetAttr(0x924, (PageAlignment) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SBOrientation:
                    base.wordAttrCollection_0.SetAttr(0x8a2, (PageOrientation) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SFpc:
                    base.wordAttrCollection_0.SetAttr(0x9c4, (FootnotePosition) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SRncFtn:
                    base.wordAttrCollection_0.SetAttr(0x9ce, (FootnoteRestartRule) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SRncEdn:
                    base.wordAttrCollection_0.SetAttr(0xa32, (FootnoteRestartRule) base.binaryReader_0.ReadByte());
                    goto Label_0BBA;

                case SprmCode.SFBiDi:
                    base.wordAttrCollection_0.SetAttr(0x992, base.binaryReader_0.ReadByte() == 1);
                    goto Label_0BBA;

                case SprmCode.SFRTLGutter:
                    base.wordAttrCollection_0.SetAttr(0x96a, base.binaryReader_0.ReadByte() == 1);
                    goto Label_0BBA;

                case SprmCode.SWall:
                    base.binaryReader_0.ReadByte();
                    goto Label_0BBA;

                case SprmCode.SDmBinFirst:
                    base.wordAttrCollection_0.SetAttr(0x816, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SDmBinOther:
                    base.wordAttrCollection_0.SetAttr(0x820, (int) base.binaryReader_0.ReadInt16());
                    goto Label_0BBA;

                case SprmCode.SColumns:
                {
                    int num = base.binaryReader_0.ReadInt16() + 1;
                    base.wordAttrCollection_0.SetAttr(0x92e, num);
                    if (num > 1)
                    {
                        ColumnCollection columns = new ColumnCollection(base.document_0);
                        for (int i = 0; i < num; i++)
                        {
                            Column column = new Column(base.document_0);
                            columns.Add(column);
                        }
                        base.wordAttrCollection_0.SetAttr(0x94c, columns);
                    }
                    goto Label_0BBA;
                }
            }
        }
        return false;
    Label_0BBA:
        return true;
    }

    internal void method_62(byte[] A_0, Class17 A_1)
    {
        base.wordAttrCollection_0 = A_1;
        this.class479_0.method_1(A_0);
        this.method_63();
    }

    private void method_63()
    {
        if ((base.wordAttrCollection_0.method_31(0x938) == null) || ((bool) base.wordAttrCollection_0.method_31(0x938)))
        {
            ColumnCollection columns = (ColumnCollection) base.wordAttrCollection_0.method_31(0x94c);
            if (columns != null)
            {
                object obj2 = base.wordAttrCollection_0.method_31(0x942);
                if (obj2 != null)
                {
                    int num2 = (int) obj2;
                    float num4 = ((float) base.wordAttrCollection_0.method_31(0x8d4)) * 20f;
                    float num5 = ((float) base.wordAttrCollection_0.method_31(0x8e8)) * 20f;
                    float num6 = ((float) base.wordAttrCollection_0.method_31(0x8f2)) * 20f;
                    float num3 = (((num4 - num5) - num6) - (num2 * (columns.Count - 1))) / ((float) columns.Count);
                    for (int i = 0; i < columns.Count; i++)
                    {
                        Column column = columns[i];
                        column.Space = ((float) num2) / 20f;
                        column.Width = num3 / 20f;
                    }
                }
            }
        }
    }

    internal Class429 method_64(Class17 A_0)
    {
        return new Class429(base.method_1(A_0));
    }

    private void method_65()
    {
        object count = ((Class17) base.wordAttrCollection_0).method_122().Count;
        if ((count != null) && (((int) count) != 0))
        {
            base.class345_0.method_1(SprmCode.SColumns, ((int) count) - 1);
        }
        base.method_3(SprmCode.SFEvenlySpaced, 0x938);
        base.method_9(SprmCode.SDxaColumns, 0x942);
        ColumnCollection columns = (ColumnCollection) base.wordAttrCollection_0.method_31(0x94c);
        if (columns != null)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                base.class345_0.method_0(SprmCode.SDxaColWidth, i);
                base.class345_0.Write((short) Math.Round((double) (columns[i].Width * 20f)));
                if (i < (columns.Count - 1))
                {
                    base.class345_0.method_0(SprmCode.SDxaColSpacing, i);
                    base.class345_0.Write((short) Math.Round((double) (columns[i].Space * 20f)));
                }
            }
        }
    }

    private void method_66()
    {
        if ((base.wordAttrCollection_0.method_6(0x8ac) || base.wordAttrCollection_0.method_6(0x8b6)) || base.wordAttrCollection_0.method_6(0x8c0))
        {
            int num = (int) base.wordAttrCollection_0.method_32(0x8ac);
            int num2 = ((bool) base.wordAttrCollection_0.method_32(0x8b6)) ? 0 : 1;
            int num3 = (int) base.wordAttrCollection_0.method_32(0x8c0);
            int num4 = (num | (num2 << 3)) | (num3 << 5);
            base.class345_0.method_1(SprmCode.SPgbProp, num4);
        }
    }

    private ColumnCollection method_67()
    {
        object obj2 = base.wordAttrCollection_0.method_31(0x94c);
        if (obj2 == null)
        {
            obj2 = new ColumnCollection(base.document_0);
            base.wordAttrCollection_0.SetAttr(0x94c, obj2);
        }
        return (obj2 as ColumnCollection);
    }

    private Column method_68(int A_0)
    {
        ColumnCollection columns = this.method_67();
        while (columns.Count <= A_0)
        {
            columns.Add(new Column(base.document_0));
        }
        return columns[A_0];
    }

    protected override void vmethod_0()
    {
        Class17 class2 = (Class17) base.wordAttrCollection_0;
        if (class2.method_60() && !class2.method_6(0x898))
        {
            class2.method_87((int) class2.method_32(0x898));
        }
        base.method_7(SprmCode.SBkc, 0x7ee);
        base.method_7(SprmCode.SNfcPgn, 0x7da);
        base.method_7(SprmCode.ScnsPgn, 0x7e4);
        base.method_3(SprmCode.SFTitlePage, 0x7f8);
        base.method_3(SprmCode.SFPgnRestart, 0x802);
        base.method_3(SprmCode.SLBetween, 0x80c);
        base.method_9(SprmCode.SDmBinFirst, 0x816);
        base.method_9(SprmCode.SDmBinOther, 0x820);
        base.method_9(SprmCode.SDmPaperReq, 0x82a);
        base.method_6(SprmCode.SFEndnote, 0x834);
        base.method_7(SprmCode.SLnc, 0x83e);
        base.method_9(SprmCode.SNLnnMod, 0x848);
        base.method_27(SprmCode.SBrcTop, base.wordAttrCollection_0.method_31(0x852), 8f);
        base.method_27(SprmCode.SBrcLeft, base.wordAttrCollection_0.method_31(0x85c), 8f);
        base.method_27(SprmCode.SBrcBottom, base.wordAttrCollection_0.method_31(0x866), 8f);
        base.method_27(SprmCode.SBrcRight, base.wordAttrCollection_0.method_31(0x870), 8f);
        base.method_11(SprmCode.SDyaLinePitch, 0x87a, 20f);
        if (base.wordAttrCollection_0.method_6(0x884))
        {
            base.class345_0.method_1(SprmCode.SLnnMin, ((int) base.wordAttrCollection_0.method_32(0x884)) - 1);
        }
        base.method_7(SprmCode.SHeadingPgn, 0x88e);
        base.method_9(SprmCode.SPgnStart97, 0x898);
        base.method_7(SprmCode.SBOrientation, 0x8a2);
        this.method_66();
        base.method_30(SprmCode.SBrcTopEx, 0x852);
        base.method_30(SprmCode.SBrcLeftEx, 0x85c);
        base.method_30(SprmCode.SBrcBottomEx, 0x866);
        base.method_30(SprmCode.SBrcRightEx, 0x870);
        base.method_18(SprmCode.SRsid, 0x8ca);
        bool flag = class2.method_88() == PageOrientation.Landscape;
        float num3 = class2.method_96();
        float num = class2.method_98();
        float num2 = num3;
        float num4 = num;
        if (flag && (num3 < num))
        {
            num2 = num;
            num4 = num3;
        }
        base.method_17(SprmCode.SXaPage, num2, 20f);
        base.method_17(SprmCode.SYaPage, num4, 20f);
        base.method_17(SprmCode.SDxaLeft, class2.method_32(0x8e8), 20f);
        base.method_17(SprmCode.SDxaRight, class2.method_32(0x8f2), 20f);
        base.method_17(SprmCode.SDyaTop, class2.method_32(0x8fc), 20f);
        base.method_17(SprmCode.SDyaBottom, class2.method_32(0x906), 20f);
        base.method_11(SprmCode.SDzaGutter, 0x908, 20f);
        base.method_13(SprmCode.SDyaHdrTop, 0x910, 20f);
        base.method_13(SprmCode.SDyaHdrBottom, 0x91a, 20f);
        base.method_7(SprmCode.SVjc, 0x924);
        this.method_65();
        base.method_3(SprmCode.SFProtected, 0x956);
        base.method_13(SprmCode.SDxaLnn, 0x960, 20f);
        base.method_3(SprmCode.SFRTLGutter, 0x96a);
        base.method_18(SprmCode.SDxtCharSpace, 0x974);
        base.method_9(SprmCode.SClm, 0x97e);
        base.method_10(SprmCode.STextFlow, 0x988);
        base.method_3(SprmCode.SFBiDi, 0x992);
        object obj2 = base.wordAttrCollection_0.method_31(0x9c4);
        if (obj2 != null)
        {
            FootnotePosition position = (FootnotePosition) obj2;
            position = ((position == FootnotePosition.PrintAtBottomOfPage) || (position == FootnotePosition.PrintImmediatelyBeneathText)) ? position : FootnotePosition.PrintAtBottomOfPage;
            base.method_8(SprmCode.SFpc, position);
        }
        base.method_7(SprmCode.SRncFtn, 0x9ce);
        base.method_7(SprmCode.SRncEdn, 0xa32);
        base.method_9(SprmCode.SNFtn, 0x9d8);
        base.method_9(SprmCode.SNfcFtnRef, 0x9e2);
        base.method_9(SprmCode.SNEdn, 0xa3c);
        base.method_9(SprmCode.SNfcEdnRef, 0xa46);
        base.method_46(SprmCode.SPropRMark, SprmCode.SWall);
    }

    protected override void vmethod_1(int A_0)
    {
        throw new NotImplementedException();
    }
}

