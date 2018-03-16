using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

internal class Class141 : Class139, Interface15
{
    private Class1150 class1150_0;
    private readonly Class479 class479_0;
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private const int int_1 = 0x80;
    private const int int_2 = 0x40;
    private const int int_3 = 0x7bc0;
    private static readonly int[] int_4 = new int[] { 0x496, 0x494, 0x508, 0x5f2 };

    static Class141()
    {
        Class791.smethod_0(new object[] { SprmCode.PDylBefore, 0x4b5, SprmCode.PDylAfter, 0x4c9, SprmCode.PDxcLeft1, 0x497, SprmCode.PDxcLeft, 0x48d, SprmCode.PDxcRight, 0x483 }, hashtable_0, hashtable_1);
    }

    internal Class141(BinaryReader A_0, Class812 A_1) : base(A_1)
    {
        this.class479_0 = new Class479(this, A_0);
    }

    public bool imethod_0(SprmCode A_0, SprmType A_1, int A_2, BinaryReader A_3)
    {
        if (A_1 != SprmType.Pap)
        {
            return true;
        }
        base.binaryReader_0 = A_3;
        SprmCode code = A_0;
        if (code > SprmCode.PNestEx)
        {
            if (code <= SprmCode.PDxaLeft1)
            {
                switch (code)
                {
                    case SprmCode.PIpgp:
                    case SprmCode.PTableProps:
                        goto Label_1033;

                    case SprmCode.PRsid:
                        switch (base.binaryReader_0.ReadInt32())
                        {
                            case 0:
                                base.wordAttrCollection_0.SetAttr(0x62c, false);
                                break;

                            case 1:
                                base.wordAttrCollection_0.SetAttr(0x62c, true);
                                break;
                        }
                        goto Label_1033;

                    case SprmCode.PBrcBar:
                        base.method_38(0x578);
                        goto Label_1033;

                    case SprmCode.PBrcTop:
                        base.method_38(0x546);
                        goto Label_1033;

                    case SprmCode.PBrcLeft:
                        base.method_38(0x550);
                        goto Label_1033;

                    case SprmCode.PBrcBottom:
                        base.method_38(0x55a);
                        goto Label_1033;

                    case SprmCode.PBrcRight:
                        base.method_38(0x564);
                        goto Label_1033;

                    case SprmCode.PBrcBetween:
                        base.method_38(0x56e);
                        goto Label_1033;

                    case SprmCode.PDyaLine:
                    {
                        LineSpacingRule exactly;
                        int num2 = base.binaryReader_0.ReadInt16();
                        bool flag = base.binaryReader_0.ReadInt16() != 0;
                        if (num2 >= 0)
                        {
                            exactly = flag ? LineSpacingRule.Multiple : LineSpacingRule.AtLeast;
                        }
                        else
                        {
                            exactly = LineSpacingRule.Exactly;
                        }
                        base.wordAttrCollection_0.SetAttr(0x677, exactly);
                        float num3 = ((float) num2) / 20f;
                        base.wordAttrCollection_0.SetAttr(0x672, num3);
                        goto Label_1033;
                    }
                    case SprmCode.PDxaRight80:
                        base.wordAttrCollection_0.SetAttr(0x65e, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                        goto Label_1033;

                    case SprmCode.PDxaLeft80:
                        this.method_70(0x654, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                        goto Label_1033;

                    case SprmCode.PDxaLeft180:
                        this.method_70(0x668, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                        goto Label_1033;

                    case SprmCode.PItap:
                        if (this.class1150_0 != null)
                        {
                            this.class1150_0.int_0 = base.binaryReader_0.ReadInt32();
                            if ((this.class1150_0.int_0 < 0) || (this.class1150_0.int_0 > 0x3e8))
                            {
                                this.class1150_0.int_0 = 1;
                            }
                        }
                        goto Label_1033;

                    case SprmCode.PDxaAbs:
                        base.method_47(3, 8);
                        goto Label_1033;

                    case SprmCode.PDyaAbs:
                        base.method_48(4, 15);
                        goto Label_1033;

                    case SprmCode.PDxaWidth:
                        (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(0x11, base.binaryReader_0.ReadInt16());
                        goto Label_1033;

                    case SprmCode.PDyaFromText:
                        (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(0x10, base.binaryReader_0.ReadInt16());
                        goto Label_1033;

                    case SprmCode.PDxaFromText:
                        (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(9, base.binaryReader_0.ReadInt16());
                        goto Label_1033;

                    case SprmCode.PDxaRight:
                        base.wordAttrCollection_0.SetAttr(0x47e, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                        goto Label_1033;

                    case SprmCode.PDxaLeft:
                        this.method_70(0x488, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                        goto Label_1033;

                    case SprmCode.PDxaLeft1:
                        this.method_70(0x492, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                        goto Label_1033;
                }
            }
            else
            {
                if (code <= SprmCode.PAnld)
                {
                    if (code <= SprmCode.PIstdPermute)
                    {
                        switch (code)
                        {
                            case SprmCode.PDyaBefore:
                                base.wordAttrCollection_0.SetAttr(0x4b0, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                                goto Label_1033;

                            case SprmCode.PDyaAfter:
                                base.wordAttrCollection_0.SetAttr(0x4c4, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                                goto Label_1033;

                            case SprmCode.PIstdPermute:
                            {
                                A_3.ReadByte();
                                int num7 = A_3.ReadUInt16();
                                int num9 = A_3.ReadUInt16();
                                int num11 = num9 - num7;
                                int[] numArray = new int[num11 + 1];
                                for (int i = 0; i < numArray.Length; i++)
                                {
                                    numArray[i] = A_3.ReadUInt16();
                                }
                                if ((this.method_82().Istd > num7) && (this.method_82().Istd <= num9))
                                {
                                    this.method_82().Istd = numArray[this.method_82().Istd - num7];
                                }
                                goto Label_1033;
                            }
                        }
                        goto Label_100B;
                    }
                    if (code != SprmCode.PChgTabs)
                    {
                        if (code != SprmCode.PChgTabsWithTolerance)
                        {
                            if (code == SprmCode.PAnld)
                            {
                                goto Label_1033;
                            }
                            goto Label_100B;
                        }
                        Class757.smethod_0(base.binaryReader_0, this.method_82().Tabs, true);
                    }
                    else
                    {
                        Class757.smethod_0(base.binaryReader_0, this.method_82().Tabs, false);
                    }
                    goto Label_1033;
                }
                switch (code)
                {
                    case SprmCode.PShdEx:
                        base.method_42(0x5b4);
                        goto Label_1033;

                    case SprmCode.PBrcTopEx:
                        base.method_39(0x546);
                        goto Label_1033;

                    case SprmCode.PBrcLeftEx:
                        base.method_39(0x550);
                        goto Label_1033;

                    case SprmCode.PBrcBottomEx:
                        base.method_39(0x55a);
                        goto Label_1033;

                    case SprmCode.PBrcRightEx:
                        base.method_39(0x564);
                        goto Label_1033;

                    case SprmCode.PBrcBetweenEx:
                        base.method_39(0x56e);
                        goto Label_1033;

                    case SprmCode.PNumRM:
                        if (this.method_82().method_31(0x465) == null)
                        {
                            this.method_82().SetAttr(0x465, new Class578());
                        }
                        this.method_80((Class578) this.method_82().method_31(0x465));
                        goto Label_1033;

                    case SprmCode.PCnf:
                        base.method_53(this, A_3, A_2, TableStylePrType.Para);
                        goto Label_1033;

                    case SprmCode.PTIstdInfo:
                        goto Label_1033;

                    case SprmCode.PPropRMark:
                        base.method_44(new ParagraphFormat(base.document_0));
                        goto Label_1033;
                }
            }
        }
        else
        {
            if (code <= SprmCode.PIncLvl)
            {
                if (code <= SprmCode.PSubTableEndOfRow)
                {
                    switch (code)
                    {
                        case SprmCode.PJc:
                            base.wordAttrCollection_0.SetAttr(0x64a, (HorizontalAlignment) base.binaryReader_0.ReadByte());
                            goto Label_1033;

                        case SprmCode.PFSideBySide:
                            base.wordAttrCollection_0.SetAttr(0x406, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFKeep:
                            base.wordAttrCollection_0.SetAttr(0x410, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFKeepFollow:
                            base.wordAttrCollection_0.SetAttr(0x41a, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFPageBreakBefore:
                            base.wordAttrCollection_0.SetAttr(0x424, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFNoLineNumb:
                            base.wordAttrCollection_0.SetAttr(0x46a, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFInTable:
                            if (((this.class1150_0 != null) && (base.binaryReader_0.ReadByte() == 1)) && (this.class1150_0.int_0 == 0))
                            {
                                this.class1150_0.int_0 = 1;
                            }
                            goto Label_1033;

                        case SprmCode.PFTtp:
                            if (this.class1150_0 != null)
                            {
                                this.class1150_0.bool_0 = base.binaryReader_0.ReadByte() == 1;
                            }
                            goto Label_1033;

                        case SprmCode.PFNoAutoHyph:
                            base.wordAttrCollection_0.SetAttr(0x582, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFLockAnchor:
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(5, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFWidowControl:
                            base.wordAttrCollection_0.SetAttr(0x5be, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFKinsoku:
                            base.wordAttrCollection_0.SetAttr(0x42e, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFWordWrap:
                            base.wordAttrCollection_0.SetAttr(0x438, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFOverflowPunct:
                            base.wordAttrCollection_0.SetAttr(0x442, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFTopLinePunct:
                            base.wordAttrCollection_0.SetAttr(0x44c, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFAutoSpaceDE:
                            base.wordAttrCollection_0.SetAttr(0x4d8, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFAutoSpaceDN:
                            base.wordAttrCollection_0.SetAttr(0x4e2, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PWr:
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(0x12, (FrameTextWrap) base.binaryReader_0.ReadByte());
                            goto Label_1033;

                        case SprmCode.PFBiDi:
                            this.method_82().IsBidi = base.binaryReader_0.ReadByte() == 1;
                            goto Label_1033;

                        case SprmCode.PFNumRMIns:
                            if (this.method_82().method_31(0x465) == null)
                            {
                                this.method_82().SetAttr(0x465, new Class578());
                            }
                            ((Class578) this.method_82().method_31(0x465)).method_7(A_3.ReadByte() != 0);
                            goto Label_1033;

                        case SprmCode.PCrLf:
                            goto Label_1033;

                        case SprmCode.PFUsePgsuSettings:
                            base.wordAttrCollection_0.SetAttr(0x4ec, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFAdjustRight:
                            base.wordAttrCollection_0.SetAttr(0x4f6, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PSubTableEndOfCell:
                            if (this.class1150_0 != null)
                            {
                                this.class1150_0.bool_2 = base.binaryReader_0.ReadByte() == 1;
                            }
                            goto Label_1033;

                        case SprmCode.PSubTableEndOfRow:
                            if (this.class1150_0 != null)
                            {
                                this.class1150_0.bool_1 = base.binaryReader_0.ReadByte() == 1;
                            }
                            goto Label_1033;
                    }
                    goto Label_100B;
                }
                if (code <= SprmCode.PFNoAllowOverlap)
                {
                    switch (code)
                    {
                        case SprmCode.PFBeforeAuto:
                            base.wordAttrCollection_0.SetAttr(0x4ba, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PFAfterAuto:
                            base.wordAttrCollection_0.SetAttr(0x4ce, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;

                        case SprmCode.PJcEx:
                        {
                            HorizontalAlignment alignment = (HorizontalAlignment) base.binaryReader_0.ReadByte();
                            base.wordAttrCollection_0.SetAttr(0x3fc, alignment);
                            goto Label_1033;
                        }
                        case SprmCode.PFNoAllowOverlap:
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(13, base.binaryReader_0.ReadByte() == 1);
                            goto Label_1033;
                    }
                    goto Label_100B;
                }
                if (code != SprmCode.PNoSpaceBetweenSameStyle)
                {
                    if (code != SprmCode.PFMirrorIndents)
                    {
                        if (code == SprmCode.PIncLvl)
                        {
                            goto Label_1033;
                        }
                        goto Label_100B;
                    }
                    base.wordAttrCollection_0.SetAttr(0x479, base.binaryReader_0.ReadByte() == 1);
                }
                else
                {
                    base.wordAttrCollection_0.SetAttr(0x3fe, base.binaryReader_0.ReadByte() == 1);
                }
                goto Label_1033;
            }
            if (code > SprmCode.PShd)
            {
                if (code <= SprmCode.PIstd)
                {
                    switch (code)
                    {
                        case SprmCode.PWAlignFont:
                            base.wordAttrCollection_0.SetAttr(0x5e6, (TextAlignment) base.binaryReader_0.ReadUInt16());
                            goto Label_1033;

                        case SprmCode.PFrameTextFlow:
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(14, (TextDirection) base.binaryReader_0.ReadInt16());
                            goto Label_1033;

                        case SprmCode.PIstd:
                        {
                            int num12 = base.binaryReader_0.ReadInt16();
                            this.method_82().Istd = num12;
                            base.wordAttrCollection_0.SetAttr(0x3e8, num12);
                            goto Label_1033;
                        }
                    }
                    goto Label_100B;
                }
                switch (code)
                {
                    case SprmCode.PIlfo:
                    {
                        int num6 = base.binaryReader_0.ReadInt16();
                        if (num6 == 0x7ff)
                        {
                            num6 = 0;
                        }
                        base.wordAttrCollection_0.SetAttr(0x460, num6);
                        goto Label_1033;
                    }
                    case SprmCode.PNest:
                        this.method_71(0x654);
                        goto Label_1033;
                }
                if (code != SprmCode.PNestEx)
                {
                    goto Label_100B;
                }
                this.method_71(0x488);
                goto Label_1033;
            }
            if (code <= SprmCode.PPc)
            {
                if (code != SprmCode.PIlvl)
                {
                    if (code != SprmCode.PPc)
                    {
                        goto Label_100B;
                    }
                    base.method_51(11, 12);
                }
                else
                {
                    byte num = base.binaryReader_0.ReadByte();
                    num = ListLevel.smethod_0(num) ? num : ((byte) 0);
                    this.method_82().SetAttr(0x456, num);
                }
                goto Label_1033;
            }
            switch (code)
            {
                case SprmCode.PWHeightAbs:
                {
                    int num8 = base.binaryReader_0.ReadInt16();
                    if (num8 <= 0)
                    {
                        if (num8 < 0)
                        {
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(6, (short) num8);
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(7, FrameSizeRule.AtLeast);
                        }
                        else
                        {
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(6, (short) 0);
                            (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(7, FrameSizeRule.Auto);
                        }
                    }
                    else
                    {
                        (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(6, (short) num8);
                        (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(7, FrameSizeRule.Exact);
                    }
                    goto Label_1033;
                }
                case SprmCode.PDcs:
                {
                    int num10 = base.binaryReader_0.ReadInt16();
                    (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(20, ((DropCapPosition) num10) & ((DropCapPosition) 7));
                    (base.wordAttrCollection_0 as ParagraphFormat).Frame.SetAttr(0x15, (num10 & 0xf8) >> 3);
                    goto Label_1033;
                }
                case SprmCode.PShd:
                    base.method_40(0x5b4);
                    goto Label_1033;

                case SprmCode.PWall:
                    base.binaryReader_0.ReadByte();
                    goto Label_1033;

                case SprmCode.POutLvl:
                    base.wordAttrCollection_0.SetAttr(0x500, base.binaryReader_0.ReadByte());
                    goto Label_1033;
            }
        }
    Label_100B:
        return this.method_69(A_0, A_3);
    Label_1033:
        return true;
    }

    internal Class430 method_62(ParagraphFormat A_0, Class1150 A_1)
    {
        if ((A_0.OwnerBase is Paragraph) && ((A_0.OwnerBase as Paragraph).ParaStyle != null))
        {
            int num = A_0.Document.Styles.method_17((A_0.OwnerBase as Paragraph).ParaStyle);
            if (num == 0xfff)
            {
                num = 0;
            }
            A_0.Istd = num;
        }
        return new Class430(A_0.Istd, this.method_63(A_0, A_1));
    }

    internal byte[] method_63(ParagraphFormat A_0, Class1150 A_1)
    {
        this.class1150_0 = A_1;
        return base.method_1(A_0);
    }

    internal void method_64(Class430 A_0, ParagraphFormat A_1, Class1150 A_2)
    {
        A_1.Istd = A_0.method_6();
        this.method_65(A_0.method_2(), A_1, A_2);
    }

    internal void method_65(byte[] A_0, ParagraphFormat A_1, Class1150 A_2)
    {
        this.method_67(A_1, A_2);
        this.class479_0.method_1(A_0);
        this.method_68();
    }

    internal void method_66(byte[] A_0, Class13 A_1)
    {
        base.class13_0 = A_1;
        base.wordAttrCollection_0 = A_1.ParaPr;
        this.class479_0.method_1(A_0);
    }

    internal void method_67(ParagraphFormat A_0, Class1150 A_1)
    {
        base.wordAttrCollection_0 = A_0;
        this.class1150_0 = A_1;
    }

    internal void method_68()
    {
    }

    private bool method_69(SprmCode A_0, BinaryReader A_1)
    {
        object obj2 = Class791.smethod_6(hashtable_0, A_0);
        if (obj2 != null)
        {
            switch (((int) obj2))
            {
                case 0x483:
                case 0x48d:
                case 0x497:
                case 0x4b5:
                case 0x4c9:
                    this.method_82().SetAttr((int) obj2, ((float) A_1.ReadInt16()) / 100f);
                    goto Label_0091;
            }
            this.method_82().SetAttr((int) obj2, (float) A_1.ReadInt16());
        }
    Label_0091:
        return (obj2 != null);
    }

    private void method_70(int A_0, float A_1)
    {
        if (A_1 < 31680f)
        {
            base.wordAttrCollection_0.SetAttr(A_0, A_1);
        }
    }

    private void method_71(int A_0)
    {
        int num = base.binaryReader_0.ReadInt16();
        int num2 = (int) base.wordAttrCollection_0.method_32(A_0);
        int num3 = num2 + num;
        base.wordAttrCollection_0.SetAttr(A_0, (num3 < 0) ? 0 : num3);
    }

    internal byte[] method_72(Class13 A_0)
    {
        base.class345_0.BaseStream.Position = 0L;
        base.wordAttrCollection_0 = A_0.ParaPr;
        this.vmethod_0();
        foreach (ConditionalFormattingCode code in A_0.method_25().Keys)
        {
            Class10 class2 = A_0.method_25()[code];
            if (class2.ParaPr != null)
            {
                long num = base.method_36(SprmCode.PCnf, code);
                base.wordAttrCollection_0 = class2.ParaPr;
                this.vmethod_0();
                base.method_37(num);
            }
        }
        return base.method_2();
    }

    private void method_73(ListFormat A_0)
    {
        if (((A_0.ListType != ListType.NoList) && !A_0.IsEmptyList) && (A_0.CurrentListStyle != null))
        {
            this.method_74(A_0);
        }
        else if (A_0.IsEmptyList)
        {
            if (A_0.HasKey(0))
            {
                base.method_8(SprmCode.PIlvl, A_0.ListLevelNumber);
            }
            base.method_16(SprmCode.PIlfo, 0);
        }
        else if (A_0.HasKey(0))
        {
            base.method_8(SprmCode.PIlvl, A_0.ListLevelNumber);
        }
    }

    private void method_74(ListFormat A_0)
    {
        int num = 15;
        string name = null;
        if (A_0.OwnerParagraph != null)
        {
            name = A_0.OwnerParagraph.StyleName;
        }
        int num2 = A_0.Document.ListStyles.method_8(A_0, true);
        if ((name != null) && !A_0.OwnerParagraph.Format.HasListReference)
        {
            Document document = A_0.OwnerParagraph.Document;
            ParagraphStyle style = document.Styles.FindByName(name, StyleType.ParagraphStyle) as ParagraphStyle;
            if (style.ListIndex == -1)
            {
                ListStyle style2 = A_0.OwnerParagraph.Document.ListStyles.FindByName(A_0.CustomStyleName);
                style.ListIndex = num2;
                document.Styles.method_6(style);
                if (style2.Levels.Count > 1)
                {
                    style.ListLevel = A_0.ListLevelNumber;
                }
                name = name.Replace(BookmarkStart.b("ᔴ", num), "");
                style2.Levels[A_0.ListLevelNumber].ParaStyleName = name;
            }
        }
        else
        {
            if (A_0.HasKey(0))
            {
                base.method_8(SprmCode.PIlvl, A_0.ListLevelNumber);
            }
            if (A_0.HasKey(1))
            {
                base.method_16(SprmCode.PIlfo, num2);
            }
        }
    }

    private int method_75(ListFormat A_0)
    {
        Dictionary<int, Dictionary<int, string>> dictionary = new Dictionary<int, Dictionary<int, string>>();
        int key = 0;
        int num2 = 0;
        if ((A_0.LFOStyleName == string.Empty) || (A_0.CurrentListStyle.Name != string.Empty))
        {
            foreach (ListStyle style in A_0.Document.ListStyles)
            {
                if (style.Name == A_0.CustomStyleName)
                {
                    break;
                }
                num2++;
            }
        }
        if (A_0.LFOStyleName == null)
        {
            num2++;
            return num2;
        }
        if (key == 0)
        {
            key = A_0.Document.ListStyles.Count + 1;
        }
        if (!dictionary.ContainsKey(num2))
        {
            if (!dictionary.ContainsKey(num2))
            {
                dictionary.Add(num2, new Dictionary<int, string>());
            }
            dictionary[num2].Add(key, A_0.LFOStyleName);
            int num3 = key;
            key++;
            return num3;
        }
        Dictionary<int, string> dictionary2 = dictionary[num2];
        bool flag = false;
        using (Dictionary<int, string>.KeyCollection.Enumerator enumerator2 = dictionary2.Keys.GetEnumerator())
        {
            int current;
            while (enumerator2.MoveNext())
            {
                current = enumerator2.Current;
                if (dictionary2[current] == A_0.LFOStyleName)
                {
                    goto Label_0134;
                }
            }
            goto Label_014A;
        Label_0134:
            num2 = current;
            flag = true;
        }
    Label_014A:
        if (flag)
        {
            return num2;
        }
        if (!dictionary.ContainsKey(num2))
        {
            dictionary.Add(num2, new Dictionary<int, string>());
        }
        dictionary[num2].Add(key, A_0.LFOStyleName);
        int num5 = key;
        key++;
        return num5;
    }

    private bool method_76(int A_0, object A_1)
    {
        object obj2 = Class791.smethod_6(hashtable_1, A_0);
        if (obj2 != null)
        {
            base.method_16((SprmCode) obj2, int.Parse(A_1.ToString()));
        }
        return (obj2 != null);
    }

    private void method_77(HorizontalAlignment A_0)
    {
        if (this.method_82().IsBidi)
        {
            switch (A_0)
            {
                case HorizontalAlignment.Left:
                    A_0 = HorizontalAlignment.Right;
                    break;

                case HorizontalAlignment.Right:
                    A_0 = HorizontalAlignment.Left;
                    break;
            }
        }
        base.class345_0.method_0(SprmCode.PJc, (int) A_0);
    }

    private void method_78(int A_0, SprmCode A_1, SprmCode A_2)
    {
        SprmCode code = this.method_82().IsBidi ? A_2 : A_1;
        base.class345_0.method_1(code, A_0);
    }

    private void method_79()
    {
        LineSpacingRule multiple = LineSpacingRule.Multiple;
        if (base.wordAttrCollection_0.method_6(0x677))
        {
            multiple = (LineSpacingRule) base.wordAttrCollection_0.method_32(0x677);
        }
        if (base.wordAttrCollection_0.method_6(0x672))
        {
            int num = (int) Math.Round((double) (((float) base.wordAttrCollection_0.method_32(0x672)) * 20f));
            int num2 = ((multiple != LineSpacingRule.Exactly) || (num <= 0)) ? num : -num;
            base.class345_0.method_5(SprmCode.PDyaLine);
            base.class345_0.Write((short) num2);
            base.class345_0.Write((multiple == LineSpacingRule.Multiple) ? ((short) 1) : ((short) 0));
        }
    }

    private void method_80(Class578 A_0)
    {
        int num = base.binaryReader_0.ReadByte();
        A_0.method_9(num != 0);
        base.binaryReader_0.ReadByte();
        A_0.method_1(base.class812_0.method_1(base.binaryReader_0.ReadInt16()));
        A_0.method_3(Class353.smethod_2(base.binaryReader_0));
        for (int i = 0; i < 9; i++)
        {
            A_0.method_10()[i] = base.binaryReader_0.ReadByte();
        }
        for (int j = 0; j < 9; j++)
        {
            A_0.method_11()[j] = (ListPatternType) base.binaryReader_0.ReadByte();
        }
        base.binaryReader_0.ReadInt16();
        for (int k = 0; k < 9; k++)
        {
            A_0.method_12()[k] = base.binaryReader_0.ReadInt32();
        }
        A_0.method_14(Class813.smethod_3(base.binaryReader_0, 0x40));
    }

    private void method_81()
    {
        Class578 class2 = (Class578) this.method_82().method_31(0x465);
        if (class2 != null)
        {
            if (class2.method_6())
            {
                base.class345_0.method_4(SprmCode.PFNumRMIns, true);
            }
            if (class2.method_4())
            {
                base.class345_0.method_5(SprmCode.PNumRM);
                base.class345_0.Write((byte) 0x80);
                int position = (int) base.class345_0.BaseStream.Position;
                base.class345_0.Write(class2.method_8() ? ((byte) 1) : ((byte) 0));
                base.class345_0.Write((byte) 0);
                base.class345_0.Write((short) base.class812_0.method_2(class2.method_0()));
                Class353.smethod_3(class2.method_2(), base.class345_0);
                for (int i = 0; i < 9; i++)
                {
                    base.class345_0.Write(class2.method_10()[i]);
                }
                for (int j = 0; j < 9; j++)
                {
                    base.class345_0.Write((byte) class2.method_11()[j]);
                }
                base.class345_0.Write((short) 0);
                for (int k = 0; k < 9; k++)
                {
                    base.class345_0.Write(class2.method_12()[k]);
                }
                Class813.smethod_4(class2.method_13(), base.class345_0, 0x40);
                long num4 = base.class345_0.BaseStream.Position;
            }
        }
    }

    private ParagraphFormat method_82()
    {
        return (ParagraphFormat) base.wordAttrCollection_0;
    }

    protected override void vmethod_0()
    {
        base.method_59(int_4);
        WordAttrCollection attrs = null;
        if ((base.wordAttrCollection_0 as ParagraphFormat).IsChangedFormat)
        {
            WordAttrCollection attr = base.wordAttrCollection_0.FormatRevision.method_4().Clone() as WordAttrCollection;
            (base.wordAttrCollection_0 as ParagraphFormat).AcceptFormatRevision(attr);
            attr.Remove(0x62c);
            attrs = attr;
            base.wordAttrCollection_0 = base.wordAttrCollection_0.FormatRevision.method_4();
        }
        for (int i = 0; i < base.wordAttrCollection_0.Count; i++)
        {
            int num3 = base.wordAttrCollection_0.method_18(i);
            object obj2 = base.wordAttrCollection_0.method_19(i);
            int num = num3;
            if (num <= 0x488)
            {
                if (num <= 0x42e)
                {
                    if (num <= 0x3fc)
                    {
                        if (num <= 40)
                        {
                            if (num != 20)
                            {
                                if (num != 40)
                                {
                                    goto Label_05A4;
                                }
                                base.method_29(obj2);
                            }
                            else
                            {
                                base.method_28(obj2);
                            }
                        }
                        else if (num != 0x3e8)
                        {
                            if (num != 0x3fc)
                            {
                                goto Label_05A4;
                            }
                            this.method_77((HorizontalAlignment) obj2);
                        }
                        else if (base.method_56() && ((base.wordAttrCollection_0 as ParagraphFormat).BaseFormat != null))
                        {
                            Style ownerBase = (base.wordAttrCollection_0 as ParagraphFormat).BaseFormat.OwnerBase as Style;
                            int num4 = base.wordAttrCollection_0.Document.Styles.DocStyleCollection.method_17(ownerBase);
                            base.method_16(SprmCode.PIstd, num4);
                        }
                    }
                    else if (num <= 0x410)
                    {
                        if (num != 0x406)
                        {
                            if (num != 0x410)
                            {
                                goto Label_05A4;
                            }
                            base.method_4(SprmCode.PFKeep, obj2);
                        }
                        else
                        {
                            base.method_4(SprmCode.PFSideBySide, obj2);
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x41a:
                            {
                                base.method_4(SprmCode.PFKeepFollow, obj2);
                                continue;
                            }
                            case 0x424:
                            {
                                base.method_4(SprmCode.PFPageBreakBefore, obj2);
                                continue;
                            }
                        }
                        if (num != 0x42e)
                        {
                            goto Label_05A4;
                        }
                        base.method_4(SprmCode.PFKinsoku, obj2);
                    }
                }
                else if (num <= 0x46a)
                {
                    if (num <= 0x442)
                    {
                        if (num != 0x438)
                        {
                            if (num != 0x442)
                            {
                                goto Label_05A4;
                            }
                            base.method_4(SprmCode.PFOverflowPunct, obj2);
                        }
                        else
                        {
                            base.method_4(SprmCode.PFWordWrap, obj2);
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x44c:
                            {
                                base.method_4(SprmCode.PFTopLinePunct, obj2);
                                continue;
                            }
                            case 0x465:
                            {
                                this.method_81();
                                continue;
                            }
                        }
                        if (num != 0x46a)
                        {
                            goto Label_05A4;
                        }
                        base.method_4(SprmCode.PFNoLineNumb, obj2);
                    }
                }
                else if (num <= 0x479)
                {
                    if (num != 0x474)
                    {
                        if (num != 0x479)
                        {
                            goto Label_05A4;
                        }
                        base.method_4(SprmCode.PFMirrorIndents, (bool) obj2);
                    }
                    else
                    {
                        TabCollection tabs = this.method_82().Tabs;
                        if (tabs != null)
                        {
                            Class757.smethod_1(tabs, base.class345_0);
                        }
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x47e:
                        {
                            this.method_78((int) Math.Round((double) (((float) obj2) * 20f)), SprmCode.PDxaRight80, SprmCode.PDxaLeft80);
                            continue;
                        }
                        case 0x483:
                        {
                            base.method_17(SprmCode.PDxcRight, obj2, 100f);
                            continue;
                        }
                    }
                    if (num != 0x488)
                    {
                        goto Label_05A4;
                    }
                    this.method_78((int) Math.Round((double) (((float) obj2) * 20f)), SprmCode.PDxaLeft80, SprmCode.PDxaRight80);
                }
                continue;
            }
            if (num <= 0x4ce)
            {
                if (num <= 0x4b0)
                {
                    if (num <= 0x492)
                    {
                        if (num != 0x48d)
                        {
                            if (num != 0x492)
                            {
                                goto Label_05A4;
                            }
                            base.method_17(SprmCode.PDxaLeft180, obj2, 20f);
                        }
                        else
                        {
                            base.method_17(SprmCode.PDxcLeft, obj2, 100f);
                        }
                    }
                    else if (num != 0x497)
                    {
                        if (num != 0x4b0)
                        {
                            goto Label_05A4;
                        }
                        base.method_17(SprmCode.PDyaBefore, obj2, 20f);
                    }
                    else
                    {
                        base.method_17(SprmCode.PDxcLeft1, obj2, 100f);
                    }
                }
                else if (num <= 0x4ba)
                {
                    if (num != 0x4b5)
                    {
                        if (num != 0x4ba)
                        {
                            goto Label_05A4;
                        }
                        base.method_4(SprmCode.PFBeforeAuto, obj2);
                    }
                    else
                    {
                        base.method_17(SprmCode.PDylBefore, obj2, 100f);
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x4c4:
                        {
                            base.method_17(SprmCode.PDyaAfter, obj2, 20f);
                            continue;
                        }
                        case 0x4c9:
                        {
                            base.method_17(SprmCode.PDylAfter, obj2, 100f);
                            continue;
                        }
                    }
                    if (num != 0x4ce)
                    {
                        goto Label_05A4;
                    }
                    base.method_4(SprmCode.PFAfterAuto, obj2);
                }
                continue;
            }
            if (num <= 0x500)
            {
                if (num <= 0x4e2)
                {
                    if (num != 0x4d8)
                    {
                        if (num != 0x4e2)
                        {
                            goto Label_05A4;
                        }
                        base.method_4(SprmCode.PFAutoSpaceDN, obj2);
                    }
                    else
                    {
                        base.method_4(SprmCode.PFAutoSpaceDE, obj2);
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x4ec:
                        {
                            base.method_4(SprmCode.PFUsePgsuSettings, obj2);
                            continue;
                        }
                        case 0x4f6:
                        {
                            base.method_4(SprmCode.PFAdjustRight, obj2);
                            continue;
                        }
                    }
                    if (num != 0x500)
                    {
                        goto Label_05A4;
                    }
                    base.method_8(SprmCode.POutLvl, obj2);
                }
                continue;
            }
            if (num <= 0x5b4)
            {
                if (num != 0x582)
                {
                    if (num != 0x5b4)
                    {
                        goto Label_05A4;
                    }
                    base.method_33(SprmCode.PShd, obj2);
                }
                else
                {
                    base.method_4(SprmCode.PFNoAutoHyph, obj2);
                }
                continue;
            }
            switch (num)
            {
                case 0x5be:
                {
                    base.method_4(SprmCode.PFWidowControl, obj2);
                    continue;
                }
                case 0x5e6:
                {
                    base.method_16(SprmCode.PWAlignFont, obj2);
                    continue;
                }
                case 0x618:
                {
                    base.method_4(SprmCode.PFBiDi, (bool) obj2);
                    continue;
                }
            }
        Label_05A4:
            this.method_76(num3, obj2);
        }
        if (base.wordAttrCollection_0.OwnerBase is Paragraph)
        {
            this.method_73((base.wordAttrCollection_0.OwnerBase as Paragraph).ListFormat);
        }
        else if (base.wordAttrCollection_0.OwnerBase is ParagraphStyle)
        {
            this.method_73((base.wordAttrCollection_0.OwnerBase as ParagraphStyle).ListFormat);
        }
        base.method_61();
        if (this.class1150_0 != null)
        {
            if (this.class1150_0.bool_2)
            {
                base.class345_0.method_4(SprmCode.PSubTableEndOfCell, this.class1150_0.bool_2);
            }
            if (this.class1150_0.bool_1)
            {
                base.class345_0.method_4(SprmCode.PSubTableEndOfRow, this.class1150_0.bool_1);
            }
            if (this.class1150_0.int_0 != 0)
            {
                base.class345_0.method_4(SprmCode.PFInTable, true);
            }
            if (this.class1150_0.bool_0)
            {
                base.class345_0.method_4(SprmCode.PFTtp, this.class1150_0.bool_0);
            }
            if (this.class1150_0.int_0 != 0)
            {
                base.class345_0.method_3(SprmCode.PItap, this.class1150_0.int_0);
            }
        }
        base.method_11(SprmCode.PDxaRight, 0x47e, 20f);
        base.method_11(SprmCode.PDxaLeft, 0x488, 20f);
        base.method_11(SprmCode.PDxaLeft1, 0x492, 20f);
        base.method_7(SprmCode.PJcEx, 0x3fc);
        base.method_3(SprmCode.PNoSpaceBetweenSameStyle, 0x3fe);
        base.method_18(SprmCode.PRsid, 0x62c);
        if (attrs != null)
        {
            base.wordAttrCollection_0 = attrs;
            attrs = null;
            base.method_46(SprmCode.PPropRMark, SprmCode.PWall);
        }
    }

    protected override void vmethod_1(int A_0)
    {
        int num = 10;
        int num2 = A_0;
        switch (num2)
        {
            case 0x494:
            {
                TabCollection tabs = this.method_82().Tabs;
                if (tabs == null)
                {
                    break;
                }
                Class757.smethod_1(tabs, base.class345_0);
                return;
            }
            case 0x495:
                goto Label_0171;

            case 0x496:
                this.method_79();
                return;

            case 0x508:
                base.method_49(SprmCode.PDxaAbs, 3, 8);
                base.method_50(SprmCode.PDyaAbs, 4, 15);
                if ((base.wordAttrCollection_0 is ParagraphFormat) && (base.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(0x11))
                {
                    base.method_17(SprmCode.PDxaWidth, (base.wordAttrCollection_0 as ParagraphFormat).Frame.method_31(0x11), 1f);
                }
                base.method_52(SprmCode.PPc, 11, 12);
                if ((base.wordAttrCollection_0 is ParagraphFormat) && (base.wordAttrCollection_0 as ParagraphFormat).Frame.HasKey(0x12))
                {
                    base.method_8(SprmCode.PWr, (base.wordAttrCollection_0 as ParagraphFormat).Frame.method_31(0x12));
                    return;
                }
                break;

            default:
                if (num2 != 0x5f2)
                {
                    goto Label_0171;
                }
                base.method_34(SprmCode.PShdEx, 0x5b4);
                base.method_30(SprmCode.PBrcTopEx, 0x546);
                base.method_30(SprmCode.PBrcLeftEx, 0x550);
                base.method_30(SprmCode.PBrcBottomEx, 0x55a);
                base.method_30(SprmCode.PBrcRightEx, 0x564);
                base.method_30(SprmCode.PBrcBetweenEx, 0x56e);
                return;
        }
        return;
    Label_0171:
        throw new InvalidOperationException(string.Format(BookmarkStart.b("礯就䈳圵吷匹堻ḽ∿⹁⭃╅⍇橉❋⭍⥏牑⽓晕╗瑙", num), A_0));
    }
}

