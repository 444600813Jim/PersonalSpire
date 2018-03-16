using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Drawing;

internal class Class213 : Class210
{
    private float float_14;
    private bool? nullable_0;
    private bool? nullable_1;
    private bool? nullable_2;
    private Paragraph paragraph_0;

    public Class213(Paragraph A_0) : base(ChildrenLayoutDirection.Horizontal)
    {
        base.method_2(true);
        this.paragraph_0 = A_0;
        this.method_109();
        this.method_118();
        this.method_117();
        this.method_110();
        this.method_116();
        if (A_0.IsStartOfSection)
        {
            base.method_74(A_0.method_40() != null);
        }
    }

    internal bool method_101()
    {
        if ((this.method_104().ChildObjects.Count <= 0) || !(this.method_104().ChildObjects[0] is Break))
        {
            return false;
        }
        if ((this.method_104().ChildObjects[0] as Break).BreakType != BreakType.PageBreak)
        {
            return ((this.method_104().ChildObjects[0] as Break).BreakType == BreakType.ColumnBreak);
        }
        return true;
    }

    internal float method_102()
    {
        return this.float_14;
    }

    internal void method_103(float A_0)
    {
        this.float_14 = A_0;
    }

    private Paragraph method_104()
    {
        return this.paragraph_0;
    }

    public bool method_105()
    {
        if (!this.nullable_0.HasValue)
        {
            this.nullable_0 = new bool?(this.method_104().Format.IsFrame);
        }
        return this.nullable_0.Value;
    }

    public bool method_106()
    {
        if (!this.nullable_1.HasValue)
        {
            this.nullable_1 = new bool?(this.method_104().Format.SnapToGrid);
        }
        return this.nullable_1.Value;
    }

    public bool method_107()
    {
        if (!this.nullable_2.HasValue)
        {
            this.nullable_2 = new bool?(this.method_104().method_99());
        }
        return this.nullable_2.Value;
    }

    protected IDocument method_108()
    {
        return this.paragraph_0.Document;
    }

    private void method_109()
    {
        if (this.paragraph_0.IsInCell && ((this.paragraph_0.Owner.Owner as TableRow).HeightType == TableRowHeightType.Exactly))
        {
            float height = (this.paragraph_0.Owner.Owner as TableRow).Height;
            if (height < 0f)
            {
                height = -height;
            }
            if (height > 1f)
            {
                base.Interface23.imethod_3(true);
            }
        }
        else if (((this.paragraph_0 != null) && this.paragraph_0.Format.IsFrame) && (this.paragraph_0.Format.FrameHeightRule != FrameSizeRule.AtLeast))
        {
            base.Interface23.imethod_3(true);
        }
    }

    private void method_110()
    {
        if (!this.paragraph_0.ListFormat.IsEmptyList && (!this.paragraph_0.SectionEndMark || !string.IsNullOrEmpty(this.paragraph_0.Text)))
        {
            ListFormat listFormatForApplyStyle = this.paragraph_0.GetListFormatForApplyStyle();
            ParagraphStyle paraStyle = this.paragraph_0.ParaStyle;
            if ((listFormatForApplyStyle != null) && (listFormatForApplyStyle.CurrentListStyle != null))
            {
                ListStyle currentListStyle = listFormatForApplyStyle.CurrentListStyle;
                base.method_14(0);
                if (listFormatForApplyStyle.HasKey(0))
                {
                    base.method_14(listFormatForApplyStyle.ListLevelNumber);
                }
                ListLevel overrideListLevel = (currentListStyle.Levels.Count > 0) ? currentListStyle.GetNearLevel(base.method_13()) : null;
                if (overrideListLevel != null)
                {
                    Class12 class2 = null;
                    if ((listFormatForApplyStyle.LFOStyleName != null) && (listFormatForApplyStyle.LFOStyleName.Length > 0))
                    {
                        class2 = (this.method_108() as Document).ListOverrides.method_35(listFormatForApplyStyle.LFOStyleName);
                    }
                    if (((class2 != null) && class2.method_23().method_11(base.method_13())) && class2.method_23().method_5(base.method_13()).OverrideFormatting)
                    {
                        overrideListLevel = class2.method_23().method_5(base.method_13()).OverrideListLevel;
                    }
                    if ((currentListStyle.ListType == ListType.Numbered) || (currentListStyle.ListType == ListType.Bulleted))
                    {
                        if (overrideListLevel.ParagraphFormat.HasKey(0x488))
                        {
                            base.Interface22.imethod_1().method_1((double) overrideListLevel.ParagraphFormat.LeftIndent);
                        }
                        if (((this.paragraph_0.ListFormat.ListType == ListType.NoList) && !this.paragraph_0.ListFormat.HasKey(1)) && (paraStyle.ParagraphFormat.HasKey(0x488) || ((paraStyle.ParagraphFormat.LeftIndent != 0f) && (paraStyle.ParagraphFormat.LeftIndent != overrideListLevel.ParagraphFormat.LeftIndent))))
                        {
                            base.Interface22.imethod_1().method_1((double) paraStyle.ParagraphFormat.LeftIndent);
                        }
                        else if ((((this.paragraph_0.ListFormat.ListType != ListType.NoList) && !this.paragraph_0.ListFormat.HasKey(1)) && paraStyle.ListFormat.HasKey(1)) && (paraStyle.ParagraphFormat.HasKey(0x488) || !overrideListLevel.ParagraphFormat.HasKey(0x488)))
                        {
                            base.Interface22.imethod_1().method_1((double) paraStyle.ParagraphFormat.LeftIndent);
                        }
                        if (this.paragraph_0.Format.HasKey(0x488))
                        {
                            base.Interface22.imethod_1().method_1((double) this.paragraph_0.Format.LeftIndent);
                        }
                        if (overrideListLevel.ParagraphFormat.HasKey(0x492))
                        {
                            base.method_20(overrideListLevel.ParagraphFormat.FirstLineIndent);
                        }
                        if (((this.paragraph_0.ListFormat.ListType == ListType.NoList) && !this.paragraph_0.ListFormat.HasKey(1)) && (paraStyle.ParagraphFormat.HasKey(0x492) || ((paraStyle.ParagraphFormat.FirstLineIndent != 0f) && (paraStyle.ParagraphFormat.FirstLineIndent != overrideListLevel.ParagraphFormat.FirstLineIndent))))
                        {
                            base.method_20(paraStyle.ParagraphFormat.FirstLineIndent);
                        }
                        else if ((((this.paragraph_0.ListFormat.ListType != ListType.NoList) && !this.paragraph_0.ListFormat.HasKey(1)) && paraStyle.ListFormat.HasKey(1)) && (paraStyle.ParagraphFormat.HasKey(0x492) || !overrideListLevel.ParagraphFormat.HasKey(0x492)))
                        {
                            base.method_20(paraStyle.ParagraphFormat.FirstLineIndent);
                        }
                        if (this.paragraph_0.Format.HasKey(0x492))
                        {
                            base.method_20(this.paragraph_0.Format.FirstLineIndent);
                        }
                        if (((base.method_19() < 0f) && (base.Interface22.imethod_1().method_0() == 0.0)) && (!this.paragraph_0.Format.HasValue(0x488) && !paraStyle.ParagraphFormat.HasValue(0x488)))
                        {
                            base.Interface22.imethod_1().method_1((double) Math.Abs(base.method_19()));
                        }
                    }
                    base.method_72(new CharacterFormat(this.method_108()));
                    this.method_114(overrideListLevel.CharacterFormat, base.method_71());
                    base.method_71().ApplyBase(this.paragraph_0.BreakCharacterFormat);
                    base.method_66((this.method_108() as Document).method_133(this.paragraph_0, listFormatForApplyStyle, overrideListLevel, (LocaleIDs) base.method_71().LocaleIdASCII));
                    this.paragraph_0.ListText = base.method_65();
                    base.method_68(Class57.smethod_9(base.method_65()));
                    if (!overrideListLevel.IsEmptyPicture && (overrideListLevel.PicBullet != null))
                    {
                        base.method_46(true);
                        base.method_80(overrideListLevel.PicBullet);
                    }
                    if (overrideListLevel.FollowCharacter == FollowCharacterType.Tab)
                    {
                        this.method_112(overrideListLevel);
                    }
                    else
                    {
                        this.method_111(overrideListLevel);
                    }
                    base.method_76(overrideListLevel.NumberAlignment);
                }
                if ((((overrideListLevel.StartAt == 0) && (currentListStyle.ListType == ListType.Numbered)) && (string.IsNullOrEmpty(overrideListLevel.LevelText) && string.IsNullOrEmpty(overrideListLevel.NumberPrefix))) && (string.IsNullOrEmpty(overrideListLevel.NumberPrefix) && string.IsNullOrEmpty(overrideListLevel.BulletCharacter)))
                {
                    base.method_66(string.Empty);
                }
                listFormatForApplyStyle.Close();
            }
        }
    }

    private void method_111(ListLevel A_0)
    {
        int num = 6;
        using (Class196 class2 = new Class196())
        {
            bool flag = (this.method_108() as Document).bool_23;
            SizeF ef = new SizeF();
            if (A_0.IsEmptyPicture && (A_0.PicBullet == null))
            {
                ef = flag ? class2.method_309(base.method_65(), class2.method_376(base.method_71()), null) : class2.method_316(base.method_65(), base.method_71().Font, null);
            }
            else
            {
                SizeF ef4 = flag ? class2.method_309(base.method_65(), class2.method_376(base.method_71()), null) : class2.method_316(base.method_65(), base.method_71().Font, null);
                SizeF ef5 = class2.method_306(A_0.PicBullet);
                float num3 = Math.Min((float) (ef4.Width / ef5.Width), (float) (ef4.Height / ef5.Height));
                if (num3 != 1f)
                {
                    ef = new SizeF(ef5.Width * num3, ef5.Height * num3);
                }
            }
            base.method_70(ef.Width);
            float width = 0f;
            if (A_0.NumberAlignment == ListNumberAlignment.Left)
            {
                width = ef.Width;
            }
            else if (A_0.NumberAlignment == ListNumberAlignment.Center)
            {
                width = ef.Width / 2f;
            }
            if (A_0.FollowCharacter == FollowCharacterType.Space)
            {
                base.method_52(width + (flag ? class2.method_309(BookmarkStart.b("ఫ", num), class2.method_376(base.method_71()), null).Width : class2.method_316(BookmarkStart.b("ఫ", num), base.method_71().Font, null).Width));
            }
            else
            {
                base.method_52(width);
            }
        }
    }

    private void method_112(ListLevel A_0)
    {
        Class208 class2 = new Class208(this.paragraph_0, A_0);
        using (Class196 class3 = new Class196())
        {
            bool flag = (this.method_108() as Document).bool_23;
            SizeF ef = new SizeF();
            if (A_0.IsEmptyPicture && (A_0.PicBullet == null))
            {
                ef = flag ? class3.method_309(base.method_65(), class3.method_376(base.method_71()), null) : class3.method_316(base.method_65(), base.method_71().Font, null);
            }
            else
            {
                SizeF ef2 = flag ? class3.method_309(base.method_65(), class3.method_376(base.method_71()), null) : class3.method_316(base.method_65(), base.method_71().Font, null);
                SizeF ef3 = class3.method_306(A_0.PicBullet);
                float num = Math.Min((float) (ef2.Width / ef3.Width), (float) (ef2.Height / ef3.Height));
                if (num != 1f)
                {
                    ef = new SizeF(ef3.Width * num, ef3.Height * num);
                }
            }
            base.method_70(ef.Width);
            if (A_0.NumberAlignment == ListNumberAlignment.Left)
            {
                this.method_113(class2, ef.Width);
            }
            else if (A_0.NumberAlignment == ListNumberAlignment.Center)
            {
                this.method_113(class2, ef.Width / 2f);
            }
            else
            {
                this.method_113(class2, 0f);
            }
            base.method_78(class2.class215_0);
        }
    }

    private void method_113(Class208 A_0, float A_1)
    {
        bool useHangingIndentAsListTab = (this.method_108() as Document).UseHangingIndentAsListTab;
        if (((base.method_51() < A_1) || !useHangingIndentAsListTab) || (((A_1 == base.method_51()) && (A_1 == 0f)) && useHangingIndentAsListTab))
        {
            float num2 = (A_1 + ((float) base.Interface22.imethod_1().method_0())) + base.method_19();
            float num = (float) A_0.method_22((double) num2, null);
            if ((A_1 <= Math.Abs(base.method_19())) && useHangingIndentAsListTab)
            {
                if (A_0.class215_0.method_4() != 0f)
                {
                    base.method_52(A_1 + num);
                }
                else if (base.method_19() == 0f)
                {
                    base.method_52(num);
                }
                else if ((num > Math.Abs(base.method_19())) && (num == A_0.method_13()))
                {
                    base.method_52(Math.Abs(A_1));
                }
                else if (num <= Math.Abs(base.method_19()))
                {
                    base.method_52(Math.Min(A_1 + num, Math.Abs(base.method_19())));
                }
                else
                {
                    base.method_52(Math.Abs(base.method_19()));
                }
            }
            else if (((A_0.class215_0.method_4() != 0f) && !useHangingIndentAsListTab) && (((A_1 + num) > Math.Abs(base.method_19())) && (base.method_19() != 0f)))
            {
                if (A_1 > Math.Abs(base.method_19()))
                {
                    base.method_52(A_1 + num);
                }
                else
                {
                    base.method_52(Math.Abs(base.method_19()));
                }
            }
            else if ((A_0.class215_0.method_4() == 0f) && (A_1 <= Math.Abs(base.method_19())))
            {
                base.method_52(Math.Min(A_1 + num, Math.Abs(base.method_19())));
            }
            else
            {
                base.method_52(A_1 + num);
            }
        }
    }

    private void method_114(CharacterFormat A_0, CharacterFormat A_1)
    {
        if ((A_0 != null) && (A_1 != null))
        {
            if (A_0.HasValue(190))
            {
                A_1.FontSize = A_0.FontSize;
            }
            if (A_0.HasValue(160))
            {
                A_1.method_55(A_0.TextColor);
            }
            if (A_0.HasValue(230))
            {
                A_1.FontNameAscii = A_0.FontNameAscii;
            }
            if (A_0.HasValue(270))
            {
                A_1.FontNameBidi = A_0.FontNameBidi;
            }
            if (A_0.HasValue(0xeb))
            {
                A_1.FontNameFarEast = A_0.FontNameFarEast;
            }
            if (A_0.HasValue(240))
            {
                A_1.FontNameNonFarEast = A_0.FontNameNonFarEast;
            }
            if (A_0.HasValue(60))
            {
                A_1.Bold = A_0.Bold;
            }
            if (A_0.HasValue(70))
            {
                A_1.Italic = A_0.Italic;
            }
            if (A_0.HasValue(140))
            {
                A_1.UnderlineStyle = A_0.UnderlineStyle;
            }
            if (A_0.HasValue(20))
            {
                A_1.HighlightColor = A_0.HighlightColor;
            }
            if (A_0.HasValue(100))
            {
                A_1.IsShadow = A_0.IsShadow;
            }
            if (A_0.HasValue(150))
            {
                A_1.CharacterSpacing = A_0.CharacterSpacing;
            }
            if (A_0.HasValue(200))
            {
                A_1.Position = A_0.Position;
            }
            if (A_0.HasValue(300))
            {
                A_1.DoubleStrike = A_0.DoubleStrike;
            }
            if (A_0.HasValue(170))
            {
                A_1.Emboss = A_0.Emboss;
            }
            if (A_0.HasValue(180))
            {
                A_1.Engrave = A_0.Engrave;
            }
            if (A_0.HasValue(210))
            {
                A_1.SubSuperScript = A_0.SubSuperScript;
            }
            if (A_0.HasValue(9))
            {
                A_1.TextBackgroundColor = A_0.TextBackgroundColor;
            }
            if (A_0.HasValue(120))
            {
                A_1.AllCaps = A_0.AllCaps;
            }
            if (A_0.Bidi)
            {
                A_1.Bidi = true;
                A_1.FontNameBidi = A_0.FontNameBidi;
                A_1.FontSizeBidi = A_0.FontSizeBidi;
            }
            if (A_0.HasValue(250))
            {
                A_1.BoldBidi = A_0.BoldBidi;
            }
            if (A_0.HasValue(0x6d))
            {
                A_1.FieldVanish = A_0.FieldVanish;
            }
            if (A_0.HasValue(130))
            {
                A_1.Hidden = A_0.Hidden;
            }
            if (A_0.HasValue(110))
            {
                A_1.IsSmallCaps = A_0.IsSmallCaps;
            }
            if (!A_1.HasValue(140))
            {
                A_1.UnderlineStyle = UnderlineStyle.None;
            }
        }
    }

    private void method_115(CharacterFormat A_0, CharacterFormat A_1)
    {
        CharacterFormat format = new CharacterFormat(A_0.Document);
        CharacterFormat baseFormat = A_0;
        format.method_25(baseFormat);
        while (baseFormat.BaseFormat != null)
        {
            baseFormat = baseFormat.BaseFormat as CharacterFormat;
            format.method_25(baseFormat);
        }
        if (format.HasValue(190) && !A_1.HasValue(190))
        {
            A_1.FontSize = format.FontSize;
        }
        if (format.HasValue(160) && A_1.TextColor.IsEmpty)
        {
            A_1.method_55(format.TextColor);
        }
        if (format.HasValue(230) && !A_1.HasValue(230))
        {
            A_1.FontNameAscii = format.FontNameAscii;
        }
        if (format.HasValue(270) && !A_1.HasValue(270))
        {
            A_1.FontNameBidi = format.FontNameBidi;
        }
        if (format.HasValue(0xeb) && !A_1.HasValue(0xeb))
        {
            A_1.FontNameFarEast = format.FontNameFarEast;
        }
        if (format.HasValue(240) && !A_1.HasValue(240))
        {
            A_1.FontNameNonFarEast = format.FontNameNonFarEast;
        }
        if (format.HasValue(2) && !A_1.HasValue(2))
        {
            A_1.FontName = format.FontName;
        }
        format.Close();
    }

    private void method_116()
    {
        Borders borders = this.paragraph_0.Format.Borders;
        if (!borders.NoBorder && !this.paragraph_0.SectionEndMark)
        {
            Class372 class1 = base.Interface22.imethod_0();
            class1.method_5(class1.method_4() + (borders.Top.LineWidth + borders.Top.Space));
            if (borders.Bottom.Shadow)
            {
                Class372 class2 = base.Interface22.imethod_0();
                class2.method_13(class2.method_12() + ((borders.Bottom.LineWidth * 2f) + borders.Bottom.Space));
            }
            else
            {
                Class372 class3 = base.Interface22.imethod_0();
                class3.method_13(class3.method_12() + (borders.Bottom.LineWidth + borders.Bottom.Space));
            }
        }
        if (((this.paragraph_0.PreviousSibling is Paragraph) && ((this.paragraph_0.PreviousSibling as Paragraph).Format.Borders.Bottom.BorderType != BorderStyle.Cleared)) && (((this.paragraph_0.PreviousSibling as Paragraph).Format.Borders.Bottom.BorderType != BorderStyle.None) && ((this.paragraph_0.PreviousSibling as Paragraph).Format.Borders.Bottom.LineWidth > 0f)))
        {
            Class372 class4 = base.Interface22.imethod_0();
            class4.method_5(class4.method_4() + (this.paragraph_0.PreviousSibling as Paragraph).Format.Borders.Bottom.LineWidth);
        }
        if (!borders.NoBorder)
        {
            if (borders.Bottom.BorderType != BorderStyle.None)
            {
                base.Interface22.imethod_0().method_15(borders.Bottom.Space);
            }
            if (borders.Top.BorderType != BorderStyle.None)
            {
                base.Interface22.imethod_0().method_7(borders.Top.Space);
            }
            IDocumentObject previousSibling = this.paragraph_0.PreviousSibling;
            if ((previousSibling == null) && (borders.Top.BorderType != BorderStyle.None))
            {
                base.method_50(true);
            }
            else
            {
                if ((!(previousSibling is Paragraph) && (this.paragraph_0.Owner is SDTContent)) && (this.paragraph_0.Owner.Owner is StructureDocumentTag))
                {
                    ICompositeObject owner = this.paragraph_0.Owner.Owner.Owner as ICompositeObject;
                    int index = owner.ChildObjects.IndexOf(this.paragraph_0.Owner.Owner);
                    if ((index >= 1) && (index <= (owner.ChildObjects.Count - 1)))
                    {
                        previousSibling = owner.ChildObjects[index - 1];
                    }
                    else
                    {
                        previousSibling = null;
                    }
                }
                if (previousSibling is StructureDocumentTag)
                {
                    previousSibling = (previousSibling as StructureDocumentTag).ChildObjects.LastItem;
                }
                if (previousSibling is Paragraph)
                {
                    Paragraph paragraph2 = previousSibling as Paragraph;
                    ParagraphFormat format = this.paragraph_0.method_93();
                    ParagraphFormat format2 = paragraph2.method_93();
                    Borders borders2 = !paragraph2.Format.Borders.NoBorder ? paragraph2.Format.Borders : ((((paragraph2.ParaStyle == null) || (paragraph2.ParaStyle.ParagraphFormat == null)) || paragraph2.ParaStyle.ParagraphFormat.Borders.NoBorder) ? null : paragraph2.ParaStyle.ParagraphFormat.Borders);
                    if (borders2 != null)
                    {
                        if (borders2.NoBorder && (borders.Top.BorderType != BorderStyle.None))
                        {
                            base.method_50(true);
                        }
                        else if (!borders2.NoBorder && ((!format.method_68(format2) || !format.method_69(format2)) || (((borders2.Bottom.BorderType == BorderStyle.None) || !borders2.Bottom.method_57(borders.Top)) && (!borders2.Bottom.method_57(borders.Bottom) || !borders2.Top.method_57(borders.Top)))))
                        {
                            base.method_50(true);
                        }
                    }
                    else if ((borders2 == null) && (borders.Top.BorderType != BorderStyle.None))
                    {
                        base.method_50(true);
                    }
                }
            }
            IDocumentObject nextSibling = this.paragraph_0.NextSibling;
            if ((nextSibling == null) && (borders.Bottom.BorderType != BorderStyle.None))
            {
                base.method_48(true);
            }
            else
            {
                if ((!(nextSibling is Paragraph) && (this.paragraph_0.Owner is SDTContent)) && (this.paragraph_0.Owner.Owner is StructureDocumentTag))
                {
                    ICompositeObject obj2 = this.paragraph_0.Owner.Owner.Owner as ICompositeObject;
                    int num = obj2.ChildObjects.IndexOf(this.paragraph_0.Owner.Owner);
                    if ((num >= 0) && (num <= (obj2.ChildObjects.Count - 2)))
                    {
                        nextSibling = obj2.ChildObjects[num + 1];
                    }
                    else
                    {
                        nextSibling = null;
                    }
                }
                if (nextSibling is StructureDocumentTag)
                {
                    nextSibling = (nextSibling as StructureDocumentTag).ChildObjects.FirstItem;
                }
                if (nextSibling is Paragraph)
                {
                    Paragraph paragraph = nextSibling as Paragraph;
                    ParagraphFormat format3 = this.paragraph_0.method_93();
                    ParagraphFormat format4 = paragraph.method_93();
                    Borders borders3 = !paragraph.Format.Borders.NoBorder ? paragraph.Format.Borders : ((((paragraph.ParaStyle == null) || (paragraph.ParaStyle.ParagraphFormat == null)) || paragraph.ParaStyle.ParagraphFormat.Borders.NoBorder) ? null : paragraph.ParaStyle.ParagraphFormat.Borders);
                    if (borders3 != null)
                    {
                        if (borders3.NoBorder && (borders.Bottom.BorderType != BorderStyle.None))
                        {
                            base.method_48(true);
                        }
                        else if (!borders3.NoBorder && ((!format3.method_68(format4) || !format3.method_69(format4)) || (((borders3.Top.BorderType == BorderStyle.None) || !borders3.Top.method_57(borders.Bottom)) && (!borders3.Bottom.method_57(borders.Bottom) || !borders3.Top.method_57(borders.Top)))))
                        {
                            base.method_48(true);
                        }
                    }
                    else if ((borders3 == null) && (borders.Bottom.BorderType != BorderStyle.None))
                    {
                        base.method_48(true);
                    }
                }
            }
        }
        if (!base.method_49())
        {
            base.Interface22.imethod_0().method_5(0.0);
            base.Interface22.imethod_0().method_7(0f);
        }
        if (!base.method_47())
        {
            base.Interface22.imethod_0().method_13(0.0);
            base.Interface22.imethod_0().method_15(0f);
        }
    }

    private void method_117()
    {
        IDocumentObject owner = this.paragraph_0.Owner;
        while (owner != null)
        {
            if (owner.DocumentObjectType == DocumentObjectType.Body)
            {
                break;
            }
            owner = owner.Owner;
        }
        Body body = owner as Body;
        bool flag = false;
        bool pageBreakBefore = false;
        IParagraph nextSibling = null;
        if (body != null)
        {
            bool isEndOfSection = this.paragraph_0.IsEndOfSection;
            ISection section = body.method_2();
            int index = this.method_108().Sections.IndexOf(section);
            ISection section2 = ((index + 1) < this.paragraph_0.Document.Sections.Count) ? this.method_108().Sections[index + 1] : null;
            if (section2 != null)
            {
                if (flag = isEndOfSection && ((((section2.BreakCode == SectionBreakType.NewPage) || (section2.BreakCode == SectionBreakType.Oddpage)) || (section2.BreakCode == SectionBreakType.EvenPage)) || (section2.BreakCode == SectionBreakType.NoBreak)))
                {
                    base.method_30(flag);
                    base.method_64(section2.BreakCode);
                }
                else if ((isEndOfSection && (section2.BreakCode == SectionBreakType.NewColumn)) && ((section != null) && ((section as Section).SectPr.method_116() == 1)))
                {
                    base.method_30(true);
                    flag = true;
                    base.method_64(SectionBreakType.NewPage);
                }
            }
            if (!this.paragraph_0.IsInCell)
            {
                if ((this.paragraph_0.NextSibling is Table) && ((this.paragraph_0.NextSibling as Table).Rows[0].Cells[0].Paragraphs.Count > 0))
                {
                    nextSibling = (this.paragraph_0.NextSibling as Table).Rows[0].Cells[0].Paragraphs[0];
                }
                else if (this.paragraph_0.NextSibling is Paragraph)
                {
                    nextSibling = this.paragraph_0.NextSibling as Paragraph;
                }
                else if (this.paragraph_0.NextSibling is StructureDocumentTag)
                {
                    DocumentObject firstItem = (this.paragraph_0.NextSibling as StructureDocumentTag).ChildObjects.FirstItem;
                    if (firstItem is Paragraph)
                    {
                        nextSibling = firstItem as Paragraph;
                    }
                    else if ((firstItem is Table) && ((firstItem as Table).Rows[0].Cells[0].Paragraphs.Count > 0))
                    {
                        nextSibling = (firstItem as Table).Rows[0].Cells[0].Paragraphs[0];
                    }
                }
                else if (((this.paragraph_0.NextSibling == null) && (body.Owner != null)) && (body.Owner is StructureDocumentTag))
                {
                    IDocumentObject obj4 = body.Owner.NextSibling;
                    if (obj4 is Paragraph)
                    {
                        nextSibling = obj4 as Paragraph;
                    }
                    else if ((obj4 is Table) && ((obj4 as Table).Rows[0].Cells[0].Paragraphs.Count > 0))
                    {
                        nextSibling = (obj4 as Table).Rows[0].Cells[0].Paragraphs[0];
                    }
                }
                else if (((this.paragraph_0.NextSibling == null) && (body.Owner != null)) && ((body.Owner is Section) && (body.Owner.NextSibling is Section)))
                {
                    Body body2 = (body.Owner.NextSibling as Section).Body;
                    if (body2.Items.Count > 0)
                    {
                        if (body2.Items[0] is Paragraph)
                        {
                            nextSibling = body2.Items[0] as Paragraph;
                        }
                        else if ((body2.Items[0] is Table) && ((body2.Items[0] as Table).Rows[0].Cells[0].Paragraphs.Count > 0))
                        {
                            nextSibling = (body2.Items[0] as Table).Rows[0].Cells[0].Paragraphs[0];
                        }
                    }
                }
                if (nextSibling != null)
                {
                    pageBreakBefore = nextSibling.Format.PageBreakBefore;
                    if (flag && pageBreakBefore)
                    {
                        base.method_30(false);
                    }
                }
            }
        }
        base.method_32(this.paragraph_0.Format.PageBreakAfter);
        base.method_34(pageBreakBefore);
        base.method_38(((base.method_31() || pageBreakBefore) || this.paragraph_0.Format.IsColumnBreakAfter) || flag);
    }

    private void method_118()
    {
        bool flag2;
        int num = 0x10;
        ParagraphFormat format = this.paragraph_0.Format;
        ParagraphStyle style = this.paragraph_0.GetStyle();
        if (style == null)
        {
            style = this.paragraph_0.Document.Styles.FindByName(BookmarkStart.b("砵圷䠹儻弽ⰿ", num)) as ParagraphStyle;
        }
        if (format.HasValue(0x488))
        {
            base.Interface22.imethod_1().method_1((double) format.LeftIndent);
        }
        else if (this.paragraph_0.ListFormat.IsEmptyList)
        {
            base.Interface22.imethod_1().method_1(0.0);
        }
        else
        {
            base.Interface22.imethod_1().method_1((double) format.LeftIndent);
        }
        base.method_22(format.BeforeSpacing);
        base.method_24(format.AfterSpacing);
        base.Interface22.imethod_1().method_9((double) format.RightIndent);
        base.Interface22.imethod_1().method_5((double) base.method_21());
        base.Interface22.imethod_1().method_13((double) base.method_23());
        if (format.BeforeAutoSpacing)
        {
            base.Interface22.imethod_1().method_5(14.5);
        }
        if (format.AfterAutoSpacing)
        {
            base.Interface22.imethod_1().method_13(14.5);
        }
        IDocumentObject previousSibling = this.paragraph_0.PreviousSibling;
        if (((previousSibling == null) && !(this.paragraph_0.Owner is SDTContent)) && !this.paragraph_0.IsInCell)
        {
            Section section = this.paragraph_0.method_49().PreviousSibling as Section;
            previousSibling = (section != null) ? section.Body.ChildObjects.LastItem : previousSibling;
        }
        Paragraph paragraph = (previousSibling is StructureDocumentTag) ? ((previousSibling as StructureDocumentTag).ChildObjects.LastItem as Paragraph) : (previousSibling as Paragraph);
        IDocumentObject nextSibling = this.paragraph_0.NextSibling;
        Paragraph paragraph2 = (nextSibling is StructureDocumentTag) ? ((nextSibling as StructureDocumentTag).ChildObjects.FirstItem as Paragraph) : (nextSibling as Paragraph);
        if (flag2 = paragraph != null)
        {
            if (this.paragraph_0.Format.IsFrame && !paragraph.Format.IsFrame)
            {
                flag2 = false;
            }
            else if (!this.paragraph_0.Format.IsFrame && paragraph.Format.IsFrame)
            {
                while (paragraph != null)
                {
                    if (!paragraph.Format.IsFrame)
                    {
                        break;
                    }
                    paragraph = (paragraph.PreviousSibling is StructureDocumentTag) ? ((paragraph.PreviousSibling as StructureDocumentTag).ChildObjects.LastItem as Paragraph) : (paragraph.PreviousSibling as Paragraph);
                }
                if (paragraph == null)
                {
                    flag2 = false;
                }
            }
        }
        if (flag2)
        {
            if (this.paragraph_0.Format.BeforeAutoSpacing && paragraph.Format.AfterAutoSpacing)
            {
                base.Interface22.imethod_1().method_5(0.0);
            }
            else if (!this.paragraph_0.Format.BeforeAutoSpacing && paragraph.Format.AfterAutoSpacing)
            {
                if (14.5f >= this.paragraph_0.Format.BeforeSpacing)
                {
                    base.Interface22.imethod_1().method_5(0.0);
                }
                else
                {
                    base.Interface22.imethod_1().method_5((double) (this.paragraph_0.Format.BeforeSpacing - 14.5f));
                }
            }
            else if (this.paragraph_0.Format.BeforeAutoSpacing && !paragraph.Format.AfterAutoSpacing)
            {
                if (paragraph.Format.AfterSpacing >= 14.5f)
                {
                    base.Interface22.imethod_1().method_5(0.0);
                }
                else
                {
                    base.Interface22.imethod_1().method_5((double) (14.5f - paragraph.Format.AfterSpacing));
                }
            }
            else if (((paragraph.interface23_0 != null) && (paragraph.interface23_0 as Class213).method_81()) && (paragraph.interface23_0 as Class213).Interface23.imethod_40())
            {
                base.Interface22.imethod_1().method_5((double) this.paragraph_0.Format.BeforeSpacing);
            }
            else if (paragraph.Format.AfterSpacing >= this.paragraph_0.Format.BeforeSpacing)
            {
                base.Interface22.imethod_1().method_5(0.0);
            }
            else
            {
                base.Interface22.imethod_1().method_5((double) (this.paragraph_0.Format.BeforeSpacing - paragraph.Format.AfterSpacing));
            }
        }
        if ((((paragraph2 != null) && this.paragraph_0.Format.AfterAutoSpacing) && ((this.paragraph_0.ListFormat.ListType != ListType.NoList) && (paragraph2.ListFormat.ListType != ListType.NoList))) && (((this.paragraph_0.ListFormat.CurrentListLevel != null) && (paragraph2.ListFormat.CurrentListLevel != null)) && (this.paragraph_0.ListFormat.CustomStyleName == paragraph2.ListFormat.CustomStyleName)))
        {
            base.Interface22.imethod_1().method_13(0.0);
        }
        if (this.paragraph_0.IsInCell)
        {
            TableCell owner = this.paragraph_0.Owner as TableCell;
            if (owner != null)
            {
                int count = owner.ChildObjects.Count;
                int index = owner.ChildObjects.IndexOf(this.paragraph_0);
                if (((count > 0) && (index == 0)) && this.paragraph_0.Format.BeforeAutoSpacing)
                {
                    base.Interface22.imethod_1().method_5(0.0);
                }
                if (((count > 0) && (index == (count - 1))) && (this.paragraph_0.Format.AfterAutoSpacing && (this.paragraph_0.ListFormat.ListType == ListType.NoList)))
                {
                    base.Interface22.imethod_1().method_13(0.0);
                }
            }
        }
        if (format.IsContextualSpacing)
        {
            Paragraph paragraph3 = (this.paragraph_0.PreviousSibling != null) ? ((this.paragraph_0.PreviousSibling is Paragraph) ? (this.paragraph_0.PreviousSibling as Paragraph) : ((this.paragraph_0.PreviousSibling is Table) ? ((this.paragraph_0.PreviousSibling as Table).FirstRow.Cells[0].ChildObjects[0] as Paragraph) : null)) : null;
            Paragraph paragraph4 = (this.paragraph_0.NextSibling != null) ? ((this.paragraph_0.NextSibling is Paragraph) ? (this.paragraph_0.NextSibling as Paragraph) : ((this.paragraph_0.NextSibling is Table) ? ((this.paragraph_0.NextSibling as Table).FirstRow.Cells[0].ChildObjects[0] as Paragraph) : null)) : null;
            bool flag = this.paragraph_0.Document.Settings.method_5().method_0(CompatibilityOptions.AllowSpaceOfSameStyleInTable);
            if ((paragraph3 == null) || (paragraph3.StyleName == this.paragraph_0.StyleName))
            {
                if (this.paragraph_0.IsInCell)
                {
                    if (!flag)
                    {
                        base.Interface22.imethod_1().method_5(0.0);
                    }
                }
                else
                {
                    base.Interface22.imethod_1().method_5(0.0);
                }
            }
            if ((paragraph4 == null) || (paragraph4.StyleName == this.paragraph_0.StyleName))
            {
                if (this.paragraph_0.IsInCell)
                {
                    if (!flag)
                    {
                        base.Interface22.imethod_1().method_13(0.0);
                    }
                }
                else if (this.paragraph_0.NextSibling != null)
                {
                    base.Interface22.imethod_1().method_13(0.0);
                }
            }
        }
        base.method_40(format.KeepLines);
        base.method_36(format.KeepFollow);
        base.method_42(format.IsWidowControl);
        if (format.HasKey(0x492) && format.HasValue(0x492))
        {
            base.method_20(format.FirstLineIndent);
        }
        else if ((style != null) && (style.ParagraphFormat != null))
        {
            base.method_20(format.FirstLineIndent);
        }
        else
        {
            base.method_20(format.FirstLineIndent);
        }
        base.method_54(this.paragraph_0.Format.LineSpacing);
        base.method_56(this.paragraph_0.Format.LineSpacingRule);
        base.method_18(format.HorizontalAlignment);
        base.method_16((HorizontalAlignment) base.method_17());
        base.method_26(format.AutoSpaceDE);
        base.method_28(format.AutoSpaceDN);
        if (format.IsBidi)
        {
            if (base.method_15() == HorizontalAlignment.Left)
            {
                base.method_16(HorizontalAlignment.Right);
            }
            else if (base.method_15() == HorizontalAlignment.Right)
            {
                base.method_16(HorizontalAlignment.Left);
            }
        }
        if (this.paragraph_0.SectionEndMark)
        {
            base.Interface22.imethod_1().method_5(0.0);
            if ((this.paragraph_0.ChildObjects.Count == 0) && (this.paragraph_0.OwnerTextBody.ChildObjects.Count > 1))
            {
                base.Interface22.imethod_1().method_13(0.0);
            }
        }
    }

    private float method_119(Paragraph A_0)
    {
        float num = 0f;
        if (A_0.Format.LineSpacingRule == LineSpacingRule.Multiple)
        {
            Class196 class2 = new Class196();
            num = ((float) class2.method_339(A_0.BreakCharacterFormat.Font).method_11()) * (A_0.Format.LineSpacing / 12f);
            class2.System.IDisposable.Dispose();
            class2 = null;
            return num;
        }
        return A_0.Format.LineSpacing;
    }
}

