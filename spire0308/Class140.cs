using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

internal class Class140 : Class139, Interface15
{
    private bool bool_3;
    private Class1107 class1107_0;
    private readonly Class479 class479_0;
    private readonly Class52 class52_0;
    private Dictionary<string, int> dictionary_0;
    private static readonly int[] int_1 = new int[] { 0x10, 0xca, 0x192 };

    internal Class140(Class52 A_0, Class812 A_1) : this(A_0.Document, A_0, A_1)
    {
        this.class52_0 = A_0;
        this.class479_0 = new Class479(this, null);
    }

    internal Class140(Document A_0, Class52 A_1, Class812 A_2) : base(A_0, A_2)
    {
        this.class52_0 = A_1;
        this.class479_0 = new Class479(this, null);
    }

    private bool imethod_0(SprmCode A_0, SprmType A_1, int A_2, BinaryReader A_3)
    {
        if (A_1 != SprmType.Chp)
        {
            return true;
        }
        base.binaryReader_0 = A_3;
        SprmCode code = A_0;
        if (code <= SprmCode.CCharScale)
        {
            if (code <= SprmCode.CHighlight)
            {
                if (code <= SprmCode.CFItalicBi)
                {
                    if (code <= SprmCode.CFOle2)
                    {
                        switch (code)
                        {
                            case SprmCode.CFRMarkDel:
                                if ((base.binaryReader_0.ReadByte() != 0) && !this.method_77().IsInsertRevision)
                                {
                                    this.method_77().IsDeleteRevision = true;
                                    this.method_77().DeleteRevision = new Class579(EditRevisionType.Deletion);
                                }
                                goto Label_0FEB;

                            case SprmCode.CFRMarkIns:
                                if ((base.binaryReader_0.ReadByte() != 0) && !this.method_77().IsDeleteRevision)
                                {
                                    this.method_77().IsInsertRevision = true;
                                    this.method_77().InsertRevision = new Class579(EditRevisionType.Insertion);
                                }
                                goto Label_0FEB;

                            case SprmCode.CFFldVanish:
                            case SprmCode.Noop:
                                goto Label_0FEB;

                            case SprmCode.CFData:
                                if (this.class1107_0 != null)
                                {
                                    this.class1107_0.bool_1 = base.binaryReader_0.ReadByte() == 1;
                                }
                                goto Label_0FEB;

                            case SprmCode.CFOle2:
                                if (this.class1107_0 != null)
                                {
                                    this.class1107_0.bool_3 = base.binaryReader_0.ReadByte() == 1;
                                }
                                goto Label_0FEB;
                        }
                    }
                    else
                    {
                        if (code <= SprmCode.CFSpecVanish)
                        {
                            if (code != SprmCode.CFWebHidden)
                            {
                                if (code != SprmCode.CFSpecVanish)
                                {
                                    goto Label_0FCB;
                                }
                                base.wordAttrCollection_0.SetAttr(10, this.method_75(base.binaryReader_0.ReadByte(), 10));
                            }
                            goto Label_0FEB;
                        }
                        switch (code)
                        {
                            case SprmCode.CFBold:
                                base.wordAttrCollection_0.SetAttr(60, this.method_75(base.binaryReader_0.ReadByte(), 60));
                                goto Label_0FEB;

                            case SprmCode.CFItalic:
                                base.wordAttrCollection_0.SetAttr(70, this.method_75(base.binaryReader_0.ReadByte(), 70));
                                goto Label_0FEB;

                            case SprmCode.CFStrike:
                                base.wordAttrCollection_0.SetAttr(80, this.method_75(base.binaryReader_0.ReadByte(), 80));
                                goto Label_0FEB;

                            case SprmCode.CFOutline:
                                base.wordAttrCollection_0.SetAttr(90, this.method_75(base.binaryReader_0.ReadByte(), 90));
                                goto Label_0FEB;

                            case SprmCode.CFShadow:
                                base.wordAttrCollection_0.SetAttr(100, this.method_75(base.binaryReader_0.ReadByte(), 100));
                                goto Label_0FEB;

                            case SprmCode.CFSmallCaps:
                                base.wordAttrCollection_0.SetAttr(110, this.method_75(base.binaryReader_0.ReadByte(), 110));
                                goto Label_0FEB;

                            case SprmCode.CFCaps:
                                base.wordAttrCollection_0.SetAttr(120, this.method_75(base.binaryReader_0.ReadByte(), 120));
                                goto Label_0FEB;

                            case SprmCode.CFVanish:
                                base.wordAttrCollection_0.SetAttr(130, this.method_75(base.binaryReader_0.ReadByte(), 130));
                                goto Label_0FEB;

                            case SprmCode.CFImprint:
                                base.wordAttrCollection_0.SetAttr(180, this.method_75(base.binaryReader_0.ReadByte(), 180));
                                goto Label_0FEB;

                            case SprmCode.CFSpec:
                                if (this.class1107_0 != null)
                                {
                                    this.class1107_0.bool_0 = base.binaryReader_0.ReadByte() == 1;
                                }
                                goto Label_0FEB;

                            case SprmCode.CFObj:
                                if (this.class1107_0 != null)
                                {
                                    this.class1107_0.bool_2 = base.binaryReader_0.ReadByte() == 1;
                                }
                                goto Label_0FEB;

                            case SprmCode.CFEmboss:
                                base.wordAttrCollection_0.SetAttr(170, this.method_75(base.binaryReader_0.ReadByte(), 170));
                                goto Label_0FEB;

                            case SprmCode.CFBiDi:
                                base.wordAttrCollection_0.SetAttr(0x109, this.method_75(base.binaryReader_0.ReadByte(), 0x109));
                                goto Label_0FEB;

                            case SprmCode.CFBoldBi:
                                base.wordAttrCollection_0.SetAttr(250, this.method_75(base.binaryReader_0.ReadByte(), 250));
                                goto Label_0FEB;

                            case SprmCode.CFItalicBi:
                                base.wordAttrCollection_0.SetAttr(260, this.method_75(base.binaryReader_0.ReadByte(), 260));
                                goto Label_0FEB;
                        }
                    }
                    goto Label_0FCB;
                }
                if (code <= SprmCode.CFComplexScript)
                {
                    switch (code)
                    {
                        case SprmCode.CFUsePgsuSettings:
                            base.wordAttrCollection_0.SetAttr(330, this.method_75(base.binaryReader_0.ReadByte(), 330));
                            goto Label_0FEB;

                        case SprmCode.CFNoProof:
                            base.wordAttrCollection_0.SetAttr(440, this.method_75(base.binaryReader_0.ReadByte(), 440));
                            goto Label_0FEB;
                    }
                    if (code != SprmCode.CFComplexScript)
                    {
                        goto Label_0FCB;
                    }
                    base.wordAttrCollection_0.SetAttr(0x10c, this.method_75(base.binaryReader_0.ReadByte(), 0x10c));
                }
                else if (code <= SprmCode.CIdctHint)
                {
                    if (code != SprmCode.CSfxText)
                    {
                        if (code != SprmCode.CIdctHint)
                        {
                            goto Label_0FCB;
                        }
                        base.wordAttrCollection_0.SetAttr(400, (int) base.binaryReader_0.ReadByte());
                    }
                    else
                    {
                        base.wordAttrCollection_0.SetAttr(310, (TextEffect) base.binaryReader_0.ReadByte());
                    }
                }
                else if (code != SprmCode.CLineBreakClear)
                {
                    if (code != SprmCode.CHighlight)
                    {
                        goto Label_0FCB;
                    }
                    int num = base.binaryReader_0.ReadByte();
                    if ((num >= 0) && (num < Class1006.list_0.Count))
                    {
                        Color color = Class1006.list_0[num];
                        base.wordAttrCollection_0.SetAttr(20, color);
                    }
                }
                else
                {
                    base.wordAttrCollection_0.SetAttr(0x2d, (LineBreakClear) base.binaryReader_0.ReadByte());
                }
            }
            else if (code <= SprmCode.CNeedFontFixup)
            {
                if (code <= SprmCode.CIco)
                {
                    switch (code)
                    {
                        case SprmCode.CKcd:
                            base.wordAttrCollection_0.SetAttr(770, (Emphasis) A_3.ReadByte());
                            goto Label_0FEB;

                        case SprmCode.CKul:
                            base.wordAttrCollection_0.SetAttr(140, this.method_76(base.binaryReader_0.ReadByte()));
                            goto Label_0FEB;
                    }
                    if (code != SprmCode.CIco)
                    {
                        goto Label_0FCB;
                    }
                    base.wordAttrCollection_0.SetAttr(160, Class624.smethod_1((Word97Color) base.binaryReader_0.ReadByte()));
                }
                else if (code <= SprmCode.CFDStrike)
                {
                    if (code != SprmCode.CIss)
                    {
                        if (code != SprmCode.CFDStrike)
                        {
                            goto Label_0FCB;
                        }
                        base.wordAttrCollection_0.SetAttr(300, this.method_75(base.binaryReader_0.ReadByte(), 300));
                    }
                    else
                    {
                        base.wordAttrCollection_0.SetAttr(210, (VerticalAlignment) base.binaryReader_0.ReadByte());
                    }
                }
                else
                {
                    if (code != SprmCode.CWall)
                    {
                        if (code == SprmCode.CNeedFontFixup)
                        {
                            goto Label_0FEB;
                        }
                        goto Label_0FCB;
                    }
                    base.binaryReader_0.ReadByte();
                }
            }
            else if (code <= SprmCode.CIdslRMark)
            {
                if (code != SprmCode.CFSdtVanish)
                {
                    if (code != SprmCode.CIbstRMark)
                    {
                        if (code == SprmCode.CIdslRMark)
                        {
                            goto Label_0FEB;
                        }
                        goto Label_0FCB;
                    }
                    this.method_73(this.method_77().InsertRevision);
                }
            }
            else if (code <= SprmCode.CHpsKern)
            {
                if (code != SprmCode.CHpsPos)
                {
                    if (code != SprmCode.CHpsKern)
                    {
                        goto Label_0FCB;
                    }
                    base.wordAttrCollection_0.SetAttr(220, ((float) base.binaryReader_0.ReadUInt16()) / 2f);
                }
                else
                {
                    base.wordAttrCollection_0.SetAttr(200, ((float) base.binaryReader_0.ReadInt16()) / 2f);
                }
            }
            else if (code != SprmCode.CYsri)
            {
                if (code != SprmCode.CCharScale)
                {
                    goto Label_0FCB;
                }
                base.wordAttrCollection_0.SetAttr(290, (short) base.binaryReader_0.ReadUInt16());
            }
            else
            {
                base.wordAttrCollection_0.SetAttr(460, (HyphenRule) base.binaryReader_0.ReadByte());
                base.wordAttrCollection_0.SetAttr(470, (int) base.binaryReader_0.ReadByte());
            }
            goto Label_0FEB;
        }
        if (code > SprmCode.CBrc)
        {
            if (code <= SprmCode.CFMathPr)
            {
                if (code <= SprmCode.CPbiIBullet)
                {
                    switch (code)
                    {
                        case SprmCode.CCv:
                            base.wordAttrCollection_0.SetAttr(160, Class624.smethod_7(base.binaryReader_0.ReadInt32()));
                            goto Label_0FEB;

                        case SprmCode.CUnderlineColor:
                            base.wordAttrCollection_0.SetAttr(450, Class624.smethod_7(base.binaryReader_0.ReadInt32()));
                            goto Label_0FEB;
                    }
                    if (code != SprmCode.CPbiIBullet)
                    {
                        goto Label_0FCB;
                    }
                    base.wordAttrCollection_0.SetAttr(480, base.binaryReader_0.ReadInt32());
                }
                else if (code <= SprmCode.CSymbol)
                {
                    if (code != SprmCode.CPicLocation)
                    {
                        if (code != SprmCode.CSymbol)
                        {
                            goto Label_0FCB;
                        }
                        if (this.class1107_0 != null)
                        {
                            this.class1107_0.string_0 = this.class52_0.method_9(base.binaryReader_0.ReadUInt16());
                            this.class1107_0.char_0 = (char) base.binaryReader_0.ReadUInt16();
                            this.class1107_0.bool_0 = true;
                        }
                    }
                    else if (this.class1107_0 != null)
                    {
                        this.class1107_0.int_1 = base.binaryReader_0.ReadInt32();
                        this.class1107_0.bool_0 = true;
                    }
                }
                else
                {
                    if (code != SprmCode.CDxaSpace)
                    {
                        if (code == SprmCode.CFMathPr)
                        {
                            goto Label_0FEB;
                        }
                        goto Label_0FCB;
                    }
                    base.wordAttrCollection_0.SetAttr(150, ((float) base.binaryReader_0.ReadInt16()) / 20f);
                }
                goto Label_0FEB;
            }
            if (code > SprmCode.CDispFldRMark)
            {
                if (code <= SprmCode.CFELayout)
                {
                    switch (code)
                    {
                        case SprmCode.CShdEx:
                            base.method_42(370);
                            goto Label_0FEB;

                        case SprmCode.CBrcEx:
                            base.method_39(360);
                            goto Label_0FEB;
                    }
                    if (code != SprmCode.CFELayout)
                    {
                        goto Label_0FCB;
                    }
                    this.method_71(A_3);
                    goto Label_0FEB;
                }
                switch (code)
                {
                    case SprmCode.CCnf:
                        base.method_53(this, A_3, A_2, TableStylePrType.Run);
                        goto Label_0FEB;

                    case SprmCode.CPropRMark:
                        base.method_44(new CharacterFormat(base.document_0));
                        goto Label_0FEB;
                }
            }
            else if (code > SprmCode.CMajority50)
            {
                switch (code)
                {
                    case SprmCode.CPropRMarkOld:
                    case SprmCode.CDispFldRMark:
                        goto Label_0FEB;
                }
            }
            else
            {
                switch (code)
                {
                    case SprmCode.CMajority:
                    case SprmCode.CMajority50:
                        goto Label_0FEB;

                    case SprmCode.CHpsNew50:
                        goto Label_0F30;
                }
            }
            goto Label_0FCB;
        }
        if (code > SprmCode.CFtcDefault)
        {
            if (code <= SprmCode.CHpsBi)
            {
                switch (code)
                {
                    case SprmCode.CLid_60:
                    {
                        short num6 = (short) base.binaryReader_0.ReadUInt16();
                        base.wordAttrCollection_0.SetAttr(380, num6);
                        base.wordAttrCollection_0.SetAttr(340, num6);
                        base.wordAttrCollection_0.SetAttr(390, num6);
                        goto Label_0FEB;
                    }
                    case SprmCode.CHps:
                        goto Label_0F30;

                    case SprmCode.CFtcAscii:
                        this.method_70(230, base.binaryReader_0.ReadInt16());
                        goto Label_0FEB;

                    case SprmCode.CFtcFarEast:
                        this.method_70(0xeb, base.binaryReader_0.ReadInt16());
                        goto Label_0FEB;

                    case SprmCode.CFtcOther:
                        this.method_70(240, base.binaryReader_0.ReadInt16());
                        goto Label_0FEB;

                    case SprmCode.CFtcBi:
                        this.method_70(270, base.binaryReader_0.ReadInt16());
                        goto Label_0FEB;

                    case SprmCode.CIcoBi:
                        goto Label_0FEB;

                    case SprmCode.CHpsBi:
                        base.wordAttrCollection_0.SetAttr(350, ((float) base.binaryReader_0.ReadUInt16()) / 2f);
                        goto Label_0FEB;
                }
            }
            else
            {
                if (code <= SprmCode.CObjLocation)
                {
                    if (code != SprmCode.CDttmRMark)
                    {
                        if (code != SprmCode.CObjLocation)
                        {
                            goto Label_0FCB;
                        }
                        if (this.class1107_0 != null)
                        {
                            this.class1107_0.int_1 = base.binaryReader_0.ReadInt32();
                        }
                    }
                    else
                    {
                        this.method_74(this.method_77().InsertRevision);
                    }
                    goto Label_0FEB;
                }
                switch (code)
                {
                    case SprmCode.CCharacterRsid:
                        base.wordAttrCollection_0.SetAttr(30, base.binaryReader_0.ReadInt32());
                        goto Label_0FEB;

                    case SprmCode.CInsertRsid:
                        base.wordAttrCollection_0.SetAttr(40, base.binaryReader_0.ReadInt32());
                        goto Label_0FEB;

                    case SprmCode.CRsidRMDel:
                        goto Label_0FEB;

                    case SprmCode.CDttmRMarkDel:
                        this.method_74(this.method_77().DeleteRevision);
                        goto Label_0FEB;

                    case SprmCode.CBrc:
                        base.method_38(360);
                        goto Label_0FEB;
                }
            }
            goto Label_0FCB;
        }
        if (code <= SprmCode.CLidFarEast_80)
        {
            switch (code)
            {
                case SprmCode.CIbstRMarkDel:
                    this.method_73(this.method_77().DeleteRevision);
                    goto Label_0FEB;

                case SprmCode.CShd:
                    base.method_40(370);
                    goto Label_0FEB;

                case SprmCode.CIdslRMarkDel:
                case SprmCode.CLidUndocumented3:
                    goto Label_0FEB;

                case SprmCode.CLidBi:
                    base.wordAttrCollection_0.SetAttr(340, (short) base.binaryReader_0.ReadUInt16());
                    goto Label_0FEB;

                case SprmCode.CLid_80:
                {
                    int num2 = base.binaryReader_0.ReadUInt16();
                    if (num2 != 0x400)
                    {
                        base.wordAttrCollection_0.SetAttr(380, (short) num2);
                    }
                    goto Label_0FEB;
                }
                case SprmCode.CLidFarEast_80:
                {
                    int num4 = base.binaryReader_0.ReadUInt16();
                    if (num4 != 0x400)
                    {
                        base.wordAttrCollection_0.SetAttr(390, (short) num4);
                    }
                    goto Label_0FEB;
                }
            }
            goto Label_0FCB;
        }
        if (code <= SprmCode.CPbiGrf)
        {
            switch (code)
            {
                case SprmCode.CLid:
                    base.wordAttrCollection_0.SetAttr(380, (short) base.binaryReader_0.ReadUInt16());
                    goto Label_0FEB;

                case SprmCode.CLidFarEast:
                    base.wordAttrCollection_0.SetAttr(390, (short) base.binaryReader_0.ReadUInt16());
                    goto Label_0FEB;

                case SprmCode.CPbiGrf:
                    base.wordAttrCollection_0.SetAttr(490, (PictureBulletFlags) base.binaryReader_0.ReadInt16());
                    goto Label_0FEB;
            }
            goto Label_0FCB;
        }
        if (code != SprmCode.CIstd)
        {
            if (code != SprmCode.CFtcDefault)
            {
                goto Label_0FCB;
            }
            string str2 = this.class52_0.method_9(base.binaryReader_0.ReadInt16());
            base.wordAttrCollection_0.SetAttr(230, str2);
            base.wordAttrCollection_0.SetAttr(270, str2);
            base.wordAttrCollection_0.SetAttr(0xeb, str2);
            base.wordAttrCollection_0.SetAttr(240, str2);
            goto Label_0FEB;
        }
        int num5 = base.binaryReader_0.ReadInt16();
        string name = string.Empty;
        using (Dictionary<string, int>.Enumerator enumerator = this.dictionary_0.GetEnumerator())
        {
            KeyValuePair<string, int> current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.Value == num5)
                {
                    goto Label_0AD9;
                }
            }
            goto Label_0AF1;
        Label_0AD9:
            name = current.Key;
        }
    Label_0AF1:
        if (base.wordAttrCollection_0.Document.Styles.FindByName(name, StyleType.CharacterStyle) != null)
        {
            (base.wordAttrCollection_0 as CharacterFormat).CharStyleName = name;
        }
        goto Label_0FEB;
    Label_0F30:
        base.wordAttrCollection_0.SetAttr(190, ((float) base.binaryReader_0.ReadUInt16()) / 2f);
        goto Label_0FEB;
    Label_0FCB:
        return false;
    Label_0FEB:
        return true;
    }

    internal void method_62(byte[] A_0, CharacterFormat A_1, Class1107 A_2, Dictionary<string, int> A_3)
    {
        this.dictionary_0 = A_3;
        base.wordAttrCollection_0 = A_1;
        this.class1107_0 = A_2;
        this.class479_0.method_1(A_0);
    }

    internal void method_63(byte[] A_0, Class13 A_1, Dictionary<string, int> A_2)
    {
        this.dictionary_0 = A_2;
        base.class13_0 = A_1;
        base.wordAttrCollection_0 = A_1.RunPr;
        this.class479_0.method_1(A_0);
    }

    internal Class431 method_64(CharacterFormat A_0, Class1107 A_1, bool A_2)
    {
        return new Class431(this.method_65(A_0, A_1, A_2));
    }

    internal byte[] method_65(CharacterFormat A_0, Class1107 A_1, bool A_2)
    {
        this.class1107_0 = A_1;
        this.bool_3 = A_2;
        return base.method_1(A_0);
    }

    internal byte[] method_66(Class13 A_0)
    {
        base.class345_0.BaseStream.Position = 0L;
        base.wordAttrCollection_0 = A_0.RunPr;
        this.vmethod_0();
        foreach (ConditionalFormattingCode code in A_0.method_25().Keys)
        {
            Class10 class2 = A_0.method_25()[code];
            if (class2.RunPr != null)
            {
                long num = base.method_36(SprmCode.CCnf, code);
                base.wordAttrCollection_0 = class2.RunPr;
                this.vmethod_0();
                base.method_37(num);
            }
        }
        return base.method_2();
    }

    private void method_67(short A_0, SprmCode A_1, object A_2)
    {
        Class650 class2 = (Class650) A_2;
        CharacterFormat format = base.wordAttrCollection_0 as CharacterFormat;
        if (!(format.OwnerBase is ListLevel))
        {
            Style style = base.document_0.Styles.FindByName(format.CharStyleName);
            CharacterFormat baseFormat = format.BaseFormat as CharacterFormat;
            bool flag = false;
            bool flag2 = format.method_53(A_0);
            if ((style != null) && style.CharacterFormat.HasValue(A_0))
            {
                flag = style.CharacterFormat.method_53(A_0);
                class2 = (flag2 == flag) ? Class650.class650_2 : Class650.class650_3;
            }
            else if ((baseFormat != null) && baseFormat.HasValue(A_0))
            {
                flag = baseFormat.method_53(A_0);
                class2 = (flag2 == flag) ? Class650.class650_2 : Class650.class650_3;
            }
            else
            {
                class2 = ((((Class650) A_2) == Class650.class650_1) || (((Class650) A_2) == Class650.class650_0)) ? ((Class650) A_2) : (flag2 ? Class650.class650_3 : Class650.class650_2);
            }
        }
        if (class2 != null)
        {
            base.method_8(A_1, class2);
        }
    }

    private void method_68(SprmCode A_0, object A_1)
    {
        if (A_1 != null)
        {
            string str = (string) A_1;
            base.class345_0.method_1(A_0, base.method_54() ? Class1149.smethod_1(str) : this.class52_0.method_8(str));
        }
    }

    private void method_69(bool A_0)
    {
        Class579 class2 = A_0 ? this.method_77().InsertRevision : this.method_77().DeleteRevision;
        if (class2 != null)
        {
            base.class345_0.method_0(A_0 ? SprmCode.CFRMarkIns : SprmCode.CFRMarkDel, 0x81);
            int num = base.class812_0.method_2(class2.method_0());
            base.class345_0.method_1(A_0 ? SprmCode.CIbstRMark : SprmCode.CIbstRMarkDel, num);
            base.class345_0.method_5(A_0 ? SprmCode.CDttmRMark : SprmCode.CDttmRMarkDel);
            Class353.smethod_3(class2.method_2(), base.class345_0);
        }
    }

    private void method_70(int A_0, int A_1)
    {
        string str = base.method_54() ? Class1149.smethod_0(A_1) : this.class52_0.method_10(A_1);
        if (!string.IsNullOrEmpty(str))
        {
            base.wordAttrCollection_0.SetAttr(A_0, str);
        }
    }

    private void method_71(BinaryReader A_0)
    {
        Class340 class2 = new Class340();
        int num = A_0.ReadUInt16();
        class2.method_1((num & 1) != 0);
        class2.method_3((num & 2) != 0);
        class2.method_5((CombineBrackets) ((num & 0x500) >> 8));
        class2.method_7((num & 0x1000) != 0);
        class2.method_9(A_0.ReadInt32());
        base.wordAttrCollection_0.SetAttr(780, class2);
    }

    private void method_72(Class340 A_0)
    {
        base.class345_0.method_5(SprmCode.CFELayout);
        base.class345_0.Write((byte) 6);
        int num = 0;
        num = 0 | (A_0.method_0() ? 1 : 0);
        num |= A_0.method_2() ? 2 : 0;
        num |= ((int) A_0.method_4()) << 8;
        num |= A_0.method_6() ? 0x1000 : 0;
        base.class345_0.Write((ushort) num);
        base.class345_0.Write(A_0.method_8());
    }

    private void method_73(Class579 A_0)
    {
        int num = base.binaryReader_0.ReadInt16();
        if (A_0 != null)
        {
            A_0.method_1(base.class812_0.method_1(num));
        }
    }

    private void method_74(Class579 A_0)
    {
        DateTime time = Class353.smethod_2(base.binaryReader_0);
        if (A_0 != null)
        {
            A_0.method_3(time);
        }
    }

    private Class650 method_75(int A_0, short A_1)
    {
        switch (A_0)
        {
            case 0:
                return Class650.class650_0;

            case 1:
                return Class650.class650_1;

            case 0x80:
                return Class650.class650_2;

            case 0x81:
                return Class650.class650_3;
        }
        return Class650.class650_1;
    }

    private UnderlineStyle method_76(int A_0)
    {
        UnderlineStyle style = (UnderlineStyle) A_0;
        switch (style)
        {
            case UnderlineStyle.None:
            case UnderlineStyle.Single:
            case UnderlineStyle.Words:
            case UnderlineStyle.Double:
            case UnderlineStyle.Dotted:
            case UnderlineStyle.Thick:
            case UnderlineStyle.Dash:
            case UnderlineStyle.DotDash:
            case UnderlineStyle.DotDotDash:
            case UnderlineStyle.Wavy:
            case UnderlineStyle.DottedHeavy:
            case UnderlineStyle.DashHeavy:
            case UnderlineStyle.DotDashHeavy:
            case UnderlineStyle.DotDotDashHeavy:
            case UnderlineStyle.WavyHeavy:
                return style;

            case UnderlineStyle.DashLong:
                return style;

            case UnderlineStyle.WavyDouble:
            case UnderlineStyle.DashLongHeavy:
                return style;
        }
        return UnderlineStyle.None;
    }

    private CharacterFormat method_77()
    {
        return (CharacterFormat) base.wordAttrCollection_0;
    }

    protected override void vmethod_0()
    {
        base.method_59(int_1);
        if (this.bool_3)
        {
            base.method_4(SprmCode.CFFldVanish, true);
        }
        if (base.wordAttrCollection_0 != null)
        {
            WordAttrCollection attrs = null;
            if ((base.wordAttrCollection_0 as CharacterFormat).IsChangedFormat)
            {
                WordAttrCollection attrs2 = base.wordAttrCollection_0.Clone() as WordAttrCollection;
                attrs2.method_42(base.wordAttrCollection_0.FormatRevision.method_4());
                attrs2.Remove(0x69);
                attrs = attrs2;
                base.wordAttrCollection_0 = base.wordAttrCollection_0.FormatRevision.method_4();
            }
            CharacterFormat format = base.wordAttrCollection_0 as CharacterFormat;
            if ((format != null) && !string.IsNullOrEmpty(format.CharStyleName))
            {
                Style style = base.wordAttrCollection_0.Document.Styles.DocStyleCollection.FindByName(format.CharStyleName);
                if (style != null)
                {
                    base.method_16(SprmCode.CIstd, style.StyleDocId);
                }
            }
            for (int i = 0; i < base.wordAttrCollection_0.Count; i++)
            {
                int num5 = base.wordAttrCollection_0.method_18(i);
                object obj2 = base.wordAttrCollection_0.method_19(i);
                base.method_60(num5);
                int num = num5;
                if (num <= 230)
                {
                    if (num <= 110)
                    {
                        if (num <= 0x2d)
                        {
                            if (num <= 20)
                            {
                                switch (num)
                                {
                                    case 10:
                                        base.method_8(SprmCode.CFSpecVanish, obj2);
                                        break;

                                    case 12:
                                        if ((base.wordAttrCollection_0 as CharacterFormat).IsDeleteRevision)
                                        {
                                            this.method_69(false);
                                        }
                                        break;

                                    case 14:
                                        if ((base.wordAttrCollection_0 as CharacterFormat).IsInsertRevision)
                                        {
                                            this.method_69(true);
                                        }
                                        break;

                                    case 20:
                                    {
                                        int index = Class1006.list_0.IndexOf((Color) obj2);
                                        if (index >= 0)
                                        {
                                            base.method_22(SprmCode.CHighlight, index);
                                        }
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                switch (num)
                                {
                                    case 30:
                                    {
                                        base.method_19(SprmCode.CCharacterRsid, obj2);
                                        continue;
                                    }
                                    case 40:
                                    {
                                        base.method_19(SprmCode.CInsertRsid, obj2);
                                        continue;
                                    }
                                }
                                if (num == 0x2d)
                                {
                                    base.method_8(SprmCode.CLineBreakClear, obj2);
                                }
                            }
                        }
                        else if (num <= 80)
                        {
                            switch (num)
                            {
                                case 60:
                                {
                                    this.method_67(60, SprmCode.CFBold, obj2);
                                    continue;
                                }
                                case 70:
                                {
                                    this.method_67(70, SprmCode.CFItalic, obj2);
                                    continue;
                                }
                            }
                            if (num == 80)
                            {
                                this.method_67(80, SprmCode.CFStrike, obj2);
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 90:
                                {
                                    base.method_8(SprmCode.CFOutline, obj2);
                                    continue;
                                }
                                case 100:
                                {
                                    this.method_67(100, SprmCode.CFShadow, obj2);
                                    continue;
                                }
                            }
                            if (num == 110)
                            {
                                this.method_67(110, SprmCode.CFSmallCaps, obj2);
                            }
                        }
                    }
                    else if (num <= 170)
                    {
                        if (num <= 140)
                        {
                            switch (num)
                            {
                                case 120:
                                {
                                    this.method_67(120, SprmCode.CFCaps, obj2);
                                    continue;
                                }
                                case 130:
                                {
                                    this.method_67(130, SprmCode.CFVanish, obj2);
                                    continue;
                                }
                            }
                            if (num == 140)
                            {
                                base.method_8(SprmCode.CKul, obj2);
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 150:
                                {
                                    base.method_17(SprmCode.CDxaSpace, obj2, 20f);
                                    continue;
                                }
                                case 160:
                                {
                                    base.method_21(SprmCode.CIco, obj2);
                                    continue;
                                }
                            }
                            if (num == 170)
                            {
                                base.method_8(SprmCode.CFEmboss, obj2);
                            }
                        }
                    }
                    else if (num <= 200)
                    {
                        switch (num)
                        {
                            case 180:
                            {
                                base.method_8(SprmCode.CFImprint, obj2);
                                continue;
                            }
                            case 190:
                            {
                                base.method_17(SprmCode.CHps, obj2, 2f);
                                continue;
                            }
                        }
                        if (num == 200)
                        {
                            base.method_17(SprmCode.CHpsPos, obj2, 2f);
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 210:
                            {
                                base.method_8(SprmCode.CIss, obj2);
                                continue;
                            }
                            case 220:
                            {
                                base.method_17(SprmCode.CHpsKern, obj2, 2f);
                                continue;
                            }
                        }
                        if (num == 230)
                        {
                            this.method_68(SprmCode.CFtcAscii, obj2);
                        }
                    }
                }
                else if (num <= 350)
                {
                    if (num <= 270)
                    {
                        if (num <= 250)
                        {
                            switch (num)
                            {
                                case 0xeb:
                                {
                                    this.method_68(SprmCode.CFtcFarEast, obj2);
                                    continue;
                                }
                                case 240:
                                {
                                    this.method_68(SprmCode.CFtcOther, obj2);
                                    continue;
                                }
                            }
                            if (num == 250)
                            {
                                this.method_67(250, SprmCode.CFBoldBi, obj2);
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x10c:
                                    base.method_8(SprmCode.CFComplexScript, obj2);
                                    break;

                                case 270:
                                    this.method_68(SprmCode.CFtcBi, obj2);
                                    break;

                                case 0x109:
                                    base.method_8(SprmCode.CFBiDi, obj2);
                                    break;

                                case 260:
                                    this.method_67(260, SprmCode.CFItalicBi, obj2);
                                    break;
                            }
                        }
                    }
                    else if (num <= 310)
                    {
                        switch (num)
                        {
                            case 290:
                            {
                                base.method_16(SprmCode.CCharScale, obj2);
                                continue;
                            }
                            case 300:
                            {
                                base.method_8(SprmCode.CFDStrike, obj2);
                                continue;
                            }
                        }
                        if (num == 310)
                        {
                            base.method_8(SprmCode.CSfxText, obj2);
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 330:
                            {
                                base.method_8(SprmCode.CFUsePgsuSettings, obj2);
                                continue;
                            }
                            case 340:
                            {
                                base.method_16(SprmCode.CLidBi, obj2);
                                continue;
                            }
                        }
                        if (num == 350)
                        {
                            base.method_17(SprmCode.CHpsBi, obj2, 2f);
                        }
                    }
                }
                else if (num <= 450)
                {
                    if (num <= 380)
                    {
                        switch (num)
                        {
                            case 360:
                            {
                                base.method_27(SprmCode.CBrc, obj2, 8f);
                                continue;
                            }
                            case 370:
                            {
                                base.method_33(SprmCode.CShd, obj2);
                                continue;
                            }
                        }
                        if (num == 380)
                        {
                            if (this.method_77().IsNoProof)
                            {
                                base.method_16(SprmCode.CLid_80, 0x400);
                                base.method_16(SprmCode.CLidFarEast_80, 0x400);
                            }
                            else
                            {
                                base.method_16(SprmCode.CLid_80, obj2);
                                if (this.method_77().LocaleIdASCII != this.method_77().LocaleIdFarEast)
                                {
                                    base.method_16(SprmCode.CLidFarEast_80, this.method_77().method_31(390));
                                }
                            }
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 400:
                            {
                                base.method_8(SprmCode.CIdctHint, obj2);
                                continue;
                            }
                            case 440:
                            {
                                base.method_8(SprmCode.CFNoProof, obj2);
                                continue;
                            }
                        }
                        if (num == 450)
                        {
                            base.method_24(SprmCode.CUnderlineColor, obj2);
                        }
                    }
                }
                else if (num <= 490)
                {
                    switch (num)
                    {
                        case 460:
                        {
                            if (base.wordAttrCollection_0.method_6(460))
                            {
                                base.class345_0.method_5(SprmCode.CYsri);
                                HyphenRule rule = (HyphenRule) base.wordAttrCollection_0.method_32(460);
                                base.class345_0.Write((byte) rule);
                                int num3 = (int) base.wordAttrCollection_0.method_32(470);
                                base.class345_0.Write((byte) num3);
                            }
                            continue;
                        }
                        case 480:
                        {
                            base.method_19(SprmCode.CPbiIBullet, obj2);
                            continue;
                        }
                    }
                    if (num == 490)
                    {
                        base.method_16(SprmCode.CPbiGrf, obj2);
                    }
                }
                else if (num != 600)
                {
                    if (num == 770)
                    {
                        Emphasis emphasis = (Emphasis) obj2;
                        if (emphasis != Emphasis.None)
                        {
                            base.method_8(SprmCode.CKcd, (byte) emphasis);
                        }
                    }
                    else if (num == 780)
                    {
                        this.method_72((Class340) obj2);
                    }
                }
            }
            base.method_61();
            if (attrs != null)
            {
                base.wordAttrCollection_0 = attrs;
                attrs = null;
                base.method_46(SprmCode.CPropRMark, SprmCode.CWall);
            }
        }
    }

    protected override void vmethod_1(int A_0)
    {
        int num = 6;
        int num2 = A_0;
        switch (num2)
        {
            case 0x10:
                if (this.class1107_0 != null)
                {
                    if (this.class1107_0.int_1 != -1)
                    {
                        base.class345_0.method_3(SprmCode.CPicLocation, this.class1107_0.int_1);
                    }
                    if (this.class1107_0.bool_3)
                    {
                        base.class345_0.method_0(SprmCode.CFOle2, 1);
                    }
                    if (this.class1107_0.bool_1)
                    {
                        base.class345_0.method_0(SprmCode.CFData, 1);
                    }
                    if ((this.class1107_0.char_0 != '\0') && !string.IsNullOrEmpty(this.class1107_0.string_0))
                    {
                        base.class345_0.method_5(SprmCode.CSymbol);
                        byte[] array = new byte[4];
                        short num3 = (short) this.class52_0.method_8(this.class1107_0.string_0);
                        BitConverter.GetBytes(num3).CopyTo(array, 0);
                        byte[] bytes = BitConverter.GetBytes(this.class1107_0.char_0);
                        array[2] = bytes[0];
                        array[3] = bytes[1];
                        base.class345_0.Write(array);
                        return;
                    }
                }
                break;

            case 0xca:
                if (this.class1107_0 == null)
                {
                    break;
                }
                if (this.class1107_0.bool_0)
                {
                    base.class345_0.method_0(SprmCode.CFSpec, 1);
                }
                if (!this.class1107_0.bool_2)
                {
                    break;
                }
                base.class345_0.method_0(SprmCode.CFObj, 1);
                return;

            default:
                if (num2 != 0x192)
                {
                    throw new InvalidOperationException(string.Format(BookmarkStart.b("攫䀭䘯匱堳張尷ᨹ䨻圽㈿㙁ㅃ❅⑇橉❋⭍⥏牑⽓晕╗瑙", num), A_0));
                }
                base.method_23(SprmCode.CCv, 160);
                base.method_34(SprmCode.CShdEx, 370);
                base.method_30(SprmCode.CBrcEx, 360);
                base.method_16(SprmCode.CLid, this.method_77().method_31(380));
                base.method_16(SprmCode.CLidFarEast, this.method_77().method_31(390));
                return;
        }
    }
}

