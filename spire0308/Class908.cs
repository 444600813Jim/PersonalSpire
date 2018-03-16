using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
internal class Class908
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12;
    private bool bool_13;
    private bool bool_14;
    private bool bool_15;
    private bool bool_16;
    private bool bool_17;
    private bool bool_18;
    private bool bool_19;
    private bool bool_2;
    private bool bool_20;
    private bool bool_21;
    private bool bool_22;
    private bool bool_23;
    private bool bool_24;
    private bool bool_25;
    private bool bool_26;
    private bool bool_27;
    private bool bool_28;
    private bool bool_29;
    private bool bool_3;
    private bool bool_30;
    private bool bool_31;
    private bool bool_32;
    private bool bool_33;
    private bool bool_34;
    private bool bool_35;
    private bool bool_36;
    private bool bool_37;
    private bool bool_38;
    private bool bool_39;
    private bool bool_4;
    private bool bool_40;
    private bool bool_41;
    private bool bool_42;
    private bool bool_43;
    private bool bool_44;
    private bool bool_45;
    private bool bool_46;
    private bool bool_47;
    private bool bool_48;
    private bool bool_49;
    private bool bool_5;
    private bool bool_50;
    private bool bool_51;
    private bool bool_52;
    private bool bool_53;
    private bool bool_54;
    private bool bool_55;
    private bool bool_56;
    private bool bool_57;
    private bool bool_58;
    private bool bool_59;
    private bool bool_6;
    private bool bool_60;
    private bool bool_61;
    private bool bool_62;
    private bool bool_63;
    private bool bool_64;
    private bool bool_65;
    private bool bool_66;
    private bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private Class909 class909_0 = new Class909();
    private Dictionary<CompatibilityOptions, bool> dictionary_0;

    internal Class908()
    {
        this.method_153(CompatibilityOptions.DontMakeSpaceForUL, false);
        this.method_153(CompatibilityOptions.DontBlnSbDbWid, false);
        this.method_153(CompatibilityOptions.DontAdjustLineHeightInTable, false);
        this.method_153(CompatibilityOptions.ExpShRtn, false);
        this.method_153(CompatibilityOptions.DontULTrlSpc, false);
        this.method_153(CompatibilityOptions.LeaveBackslashAlone, true);
    }

    internal bool method_0(CompatibilityOptions A_0)
    {
        return this.method_155(A_0);
    }

    internal void method_1(CompatibilityOptions A_0, bool A_1)
    {
        this.method_153(A_0, A_1);
    }

    internal void method_10(bool A_0)
    {
        this.method_153(CompatibilityOptions.WrapTrailSpaces, A_0);
    }

    internal void method_100(bool A_0)
    {
        this.method_153(CompatibilityOptions.UseWord2002TableStyleRules, A_0);
    }

    internal bool method_101()
    {
        return this.method_155(CompatibilityOptions.GrowAutoFit);
    }

    internal void method_102(bool A_0)
    {
        this.method_153(CompatibilityOptions.GrowAutoFit, A_0);
    }

    internal bool method_103()
    {
        return this.method_155(CompatibilityOptions.UseNormalStyleForList);
    }

    internal void method_104(bool A_0)
    {
        this.method_153(CompatibilityOptions.UseNormalStyleForList, A_0);
    }

    internal bool method_105()
    {
        return this.method_155(CompatibilityOptions.DontUseIndentAsNumberingTabStop);
    }

    internal void method_106(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontUseIndentAsNumberingTabStop, A_0);
    }

    internal bool method_107()
    {
        return this.method_155(CompatibilityOptions.FELineBreak11);
    }

    internal void method_108(bool A_0)
    {
        this.method_153(CompatibilityOptions.FELineBreak11, A_0);
    }

    internal bool method_109()
    {
        return this.method_155(CompatibilityOptions.AllowSpaceOfSameStyleInTable);
    }

    internal bool method_11()
    {
        return this.method_155(CompatibilityOptions.MapPrintTextColor);
    }

    internal void method_110(bool A_0)
    {
        this.method_153(CompatibilityOptions.AllowSpaceOfSameStyleInTable, A_0);
    }

    internal bool method_111()
    {
        return this.method_155(CompatibilityOptions.WW11IndentRules);
    }

    internal void method_112(bool A_0)
    {
        this.method_153(CompatibilityOptions.WW11IndentRules, A_0);
    }

    internal bool method_113()
    {
        return this.method_155(CompatibilityOptions.DontAutofitConstrainedTables);
    }

    internal void method_114(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontAutofitConstrainedTables, A_0);
    }

    internal bool method_115()
    {
        return this.method_155(CompatibilityOptions.AutofitLikeWW11);
    }

    internal void method_116(bool A_0)
    {
        this.method_153(CompatibilityOptions.AutofitLikeWW11, A_0);
    }

    internal bool method_117()
    {
        return this.method_155(CompatibilityOptions.UnderlineTabInNumList);
    }

    internal void method_118(bool A_0)
    {
        this.method_153(CompatibilityOptions.UnderlineTabInNumList, A_0);
    }

    internal bool method_119()
    {
        return this.method_155(CompatibilityOptions.HangulWidthLikeWW11);
    }

    internal void method_12(bool A_0)
    {
        this.method_153(CompatibilityOptions.MapPrintTextColor, A_0);
    }

    internal void method_120(bool A_0)
    {
        this.method_153(CompatibilityOptions.HangulWidthLikeWW11, A_0);
    }

    internal bool method_121()
    {
        return this.method_155(CompatibilityOptions.SplitPgBreakAndParaMark);
    }

    internal void method_122(bool A_0)
    {
        this.method_153(CompatibilityOptions.SplitPgBreakAndParaMark, A_0);
    }

    internal bool method_123()
    {
        return this.method_155(CompatibilityOptions.DontVertAlignCellWithSp);
    }

    internal void method_124(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontVertAlignCellWithSp, A_0);
    }

    internal bool method_125()
    {
        return this.method_155(CompatibilityOptions.DontBreakConstrainedForcedTables);
    }

    internal void method_126(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontBreakConstrainedForcedTables, A_0);
    }

    internal bool method_127()
    {
        return this.method_155(CompatibilityOptions.DontVertAlignInTxbx);
    }

    internal void method_128(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontVertAlignInTxbx, A_0);
    }

    internal bool method_129()
    {
        return this.method_155(CompatibilityOptions.Word11KerningPairs);
    }

    internal bool method_13()
    {
        return this.method_155(CompatibilityOptions.NoColumnBalance);
    }

    internal void method_130(bool A_0)
    {
        this.method_153(CompatibilityOptions.Word11KerningPairs, A_0);
    }

    internal bool method_131()
    {
        return this.method_155(CompatibilityOptions.CachedColBalance);
    }

    internal void method_132(bool A_0)
    {
        this.method_153(CompatibilityOptions.CachedColBalance, A_0);
    }

    internal bool method_133()
    {
        return this.method_155(CompatibilityOptions.UseFELayout);
    }

    internal void method_134(bool A_0)
    {
        this.method_153(CompatibilityOptions.UseFELayout, A_0);
    }

    internal bool method_135()
    {
        return this.method_155(CompatibilityOptions.doNotFlipMirrorIndents);
    }

    internal void method_136(bool A_0)
    {
        this.method_153(CompatibilityOptions.doNotFlipMirrorIndents, A_0);
    }

    internal bool method_137()
    {
        return this.bool_0;
    }

    internal void method_138(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal Class909 method_139()
    {
        return this.class909_0;
    }

    internal void method_14(bool A_0)
    {
        this.method_153(CompatibilityOptions.NoColumnBalance, A_0);
    }

    internal Class908 method_140()
    {
        return (Class908) base.MemberwiseClone();
    }

    internal Class908 method_141()
    {
        Class908 class2 = new Class908();
        class2.method_146();
        return class2;
    }

    internal Class908 method_142()
    {
        Class908 class2 = new Class908();
        class2.method_147();
        return class2;
    }

    internal Class908 method_143()
    {
        Class908 class2 = new Class908();
        class2.method_148();
        return class2;
    }

    internal Class908 method_144()
    {
        Class908 class2 = new Class908();
        class2.method_149();
        return class2;
    }

    internal Class908 method_145()
    {
        return new Class908();
    }

    private void method_146()
    {
        this.method_147();
        this.method_153(CompatibilityOptions.AlignTablesRowByRow, true);
        this.method_153(CompatibilityOptions.LayoutTableRowsApart, true);
        this.method_153(CompatibilityOptions.DontUseHTMLParagraphAutoSpacing, true);
        this.method_153(CompatibilityOptions.ForgetLastTabAlign, true);
        this.method_153(CompatibilityOptions.SpLayoutLikeWW8, true);
        this.method_153(CompatibilityOptions.FtnLayoutLikeWW8, true);
        this.method_153(CompatibilityOptions.LayoutRawTableWidth, true);
        this.method_153(CompatibilityOptions.UseWord97LineBreakingRules, true);
    }

    private void method_147()
    {
        this.method_148();
        this.method_153(CompatibilityOptions.DontWrapTextWithPunct, true);
        this.method_153(CompatibilityOptions.DontBreakWrappedTables, true);
        this.method_153(CompatibilityOptions.DontSnapToGridInCell, true);
        this.method_153(CompatibilityOptions.DontUseAsianBreakRules, true);
        this.method_153(CompatibilityOptions.DontAllowFieldEndSelect, true);
        this.method_153(CompatibilityOptions.UnderlineTabInNumList, true);
    }

    private void method_148()
    {
        this.method_149();
        this.method_153(CompatibilityOptions.GrowAutoFit, true);
        this.method_153(CompatibilityOptions.UseWord2002TableStyleRules, true);
    }

    internal void method_149()
    {
        this.method_153(CompatibilityOptions.enableOpenTypeFeatures, true);
        this.method_153(CompatibilityOptions.doNotFlipMirrorIndents, true);
        this.method_153(CompatibilityOptions.DontVertAlignCellWithSp, true);
        this.method_153(CompatibilityOptions.DontVertAlignInTxbx, true);
        this.method_153(CompatibilityOptions.DontBreakConstrainedForcedTables, true);
        this.method_153(CompatibilityOptions.HangulWidthLikeWW11, true);
        this.method_153(CompatibilityOptions.DontUseIndentAsNumberingTabStop, true);
        this.method_153(CompatibilityOptions.DontAutofitConstrainedTables, true);
        this.method_153(CompatibilityOptions.SplitPgBreakAndParaMark, true);
        this.method_153(CompatibilityOptions.WW11IndentRules, true);
        this.method_153(CompatibilityOptions.UseNormalStyleForList, true);
        this.method_153(CompatibilityOptions.FELineBreak11, true);
        this.method_153(CompatibilityOptions.AutofitLikeWW11, true);
        this.method_153(CompatibilityOptions.Word11KerningPairs, true);
        this.method_153(CompatibilityOptions.CachedColBalance, true);
        this.method_153(CompatibilityOptions.AllowSpaceOfSameStyleInTable, true);
    }

    internal bool method_15()
    {
        return this.method_155(CompatibilityOptions.ConvMailMergeEsc);
    }

    internal void method_150()
    {
        this.method_153(CompatibilityOptions.SpLayoutLikeWW8, true);
        this.method_153(CompatibilityOptions.FtnLayoutLikeWW8, true);
        this.method_153(CompatibilityOptions.DontVertAlignCellWithSp, true);
        this.method_153(CompatibilityOptions.DontVertAlignInTxbx, true);
        this.method_153(CompatibilityOptions.DontBreakConstrainedForcedTables, true);
        this.method_153(CompatibilityOptions.HangulWidthLikeWW11, true);
        this.method_153(CompatibilityOptions.DontUseIndentAsNumberingTabStop, true);
        this.method_153(CompatibilityOptions.DontUseHTMLParagraphAutoSpacing, true);
        this.method_153(CompatibilityOptions.DontBreakWrappedTables, true);
        this.method_153(CompatibilityOptions.DontAutofitConstrainedTables, true);
        this.method_153(CompatibilityOptions.SplitPgBreakAndParaMark, true);
        this.method_153(CompatibilityOptions.AlignTablesRowByRow, true);
        this.method_153(CompatibilityOptions.WW11IndentRules, true);
        this.method_153(CompatibilityOptions.UseNormalStyleForList, true);
        this.method_153(CompatibilityOptions.UseWord97LineBreakingRules, true);
        this.method_153(CompatibilityOptions.DontUseAsianBreakRules, true);
        this.method_153(CompatibilityOptions.DontWrapTextWithPunct, true);
        this.method_153(CompatibilityOptions.ForgetLastTabAlign, true);
        this.method_153(CompatibilityOptions.LeaveBackslashAlone, true);
        this.method_153(CompatibilityOptions.UseWord2002TableStyleRules, true);
        this.method_153(CompatibilityOptions.FELineBreak11, true);
        this.method_153(CompatibilityOptions.AutofitLikeWW11, true);
        this.method_153(CompatibilityOptions.Word11KerningPairs, true);
        this.method_153(CompatibilityOptions.CachedColBalance, true);
        this.method_153(CompatibilityOptions.UnderlineTabInNumList, true);
        this.method_153(CompatibilityOptions.DontAllowFieldEndSelect, true);
        this.method_153(CompatibilityOptions.LayoutRawTableWidth, true);
        this.method_153(CompatibilityOptions.GrowAutoFit, true);
        this.method_153(CompatibilityOptions.LayoutTableRowsApart, true);
        this.method_153(CompatibilityOptions.DontSnapToGridInCell, true);
        this.method_153(CompatibilityOptions.AllowSpaceOfSameStyleInTable, true);
        this.method_153(CompatibilityOptions.ExpShRtn, true);
        this.method_153(CompatibilityOptions.DontBlnSbDbWid, true);
        this.method_153(CompatibilityOptions.DontMakeSpaceForUL, true);
        this.method_153(CompatibilityOptions.DontULTrlSpc, true);
    }

    internal void method_151()
    {
        this.method_153(CompatibilityOptions.DontSnapToGridInCell, true);
        this.method_153(CompatibilityOptions.DontWrapTextWithPunct, true);
        this.method_153(CompatibilityOptions.DontUseAsianBreakRules, true);
        this.method_153(CompatibilityOptions.GrowAutoFit, true);
        this.method_153(CompatibilityOptions.DontAdjustLineHeightInTable, true);
        this.method_153(CompatibilityOptions.UnderlineTabInNumList, true);
        this.method_153(CompatibilityOptions.DontVertAlignCellWithSp, true);
        this.method_153(CompatibilityOptions.DontBreakConstrainedForcedTables, true);
        this.method_153(CompatibilityOptions.DontVertAlignInTxbx, true);
        this.method_153(CompatibilityOptions.HangulWidthLikeWW11, true);
        this.method_153(CompatibilityOptions.DontUseIndentAsNumberingTabStop, true);
        this.method_153(CompatibilityOptions.DontAutofitConstrainedTables, true);
        this.method_153(CompatibilityOptions.SplitPgBreakAndParaMark, true);
        this.method_153(CompatibilityOptions.UseNormalStyleForList, true);
        this.method_153(CompatibilityOptions.FELineBreak11, true);
        this.method_153(CompatibilityOptions.AllowSpaceOfSameStyleInTable, true);
        this.method_153(CompatibilityOptions.WW11IndentRules, true);
        this.method_153(CompatibilityOptions.AutofitLikeWW11, true);
        this.method_153(CompatibilityOptions.Word11KerningPairs, true);
        this.method_153(CompatibilityOptions.CachedColBalance, true);
        this.method_153(CompatibilityOptions.LeaveBackslashAlone, false);
    }

    internal void method_152()
    {
        this.method_153(CompatibilityOptions.LeaveBackslashAlone, false);
        this.method_153(CompatibilityOptions.DontAdjustLineHeightInTable, true);
        this.method_153(CompatibilityOptions.DontUseAsianBreakRules, true);
        this.method_153(CompatibilityOptions.DontWrapTextWithPunct, true);
        this.method_153(CompatibilityOptions.DontSnapToGridInCell, true);
        this.method_153(CompatibilityOptions.GrowAutoFit, true);
    }

    private void method_153(CompatibilityOptions A_0, bool A_1)
    {
        if (this.method_2().ContainsKey(A_0))
        {
            this.method_2()[A_0] = A_1;
        }
        else
        {
            this.method_2().Add(A_0, A_1);
        }
    }

    private void method_154()
    {
        this.method_153(CompatibilityOptions.DontAdjustLineHeightInTable, true);
        this.method_153(CompatibilityOptions.UseFELayout, true);
    }

    private bool method_155(CompatibilityOptions A_0)
    {
        if (this.method_2().ContainsKey(A_0))
        {
            return this.method_2()[A_0];
        }
        return false;
    }

    public void method_156()
    {
        foreach (object obj2 in Enum.GetValues(typeof(CompatibilityOptions)))
        {
            this.method_153((CompatibilityOptions) obj2, false);
        }
        this.method_154();
    }

    internal void method_16(bool A_0)
    {
        this.method_153(CompatibilityOptions.ConvMailMergeEsc, A_0);
    }

    internal bool method_17()
    {
        return this.method_155(CompatibilityOptions.SuppressTopSpacing);
    }

    internal void method_18(bool A_0)
    {
        this.method_153(CompatibilityOptions.SuppressTopSpacing, A_0);
    }

    internal bool method_19()
    {
        return this.method_155(CompatibilityOptions.OrigWordTableRules);
    }

    internal Dictionary<CompatibilityOptions, bool> method_2()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<CompatibilityOptions, bool>();
        }
        return this.dictionary_0;
    }

    internal void method_20(bool A_0)
    {
        this.method_153(CompatibilityOptions.OrigWordTableRules, A_0);
    }

    internal bool method_21()
    {
        return this.bool_10;
    }

    internal void method_22(bool A_0)
    {
        this.bool_10 = A_0;
    }

    internal bool method_23()
    {
        return this.method_155(CompatibilityOptions.ShowBreaksInFrames);
    }

    internal void method_24(bool A_0)
    {
        this.method_153(CompatibilityOptions.ShowBreaksInFrames, A_0);
    }

    internal bool method_25()
    {
        return this.method_155(CompatibilityOptions.SwapBordersFacingPgs);
    }

    internal void method_26(bool A_0)
    {
        this.method_153(CompatibilityOptions.SwapBordersFacingPgs, A_0);
    }

    internal bool method_27()
    {
        return this.method_155(CompatibilityOptions.LeaveBackslashAlone);
    }

    internal void method_28(bool A_0)
    {
        this.method_153(CompatibilityOptions.LeaveBackslashAlone, A_0);
    }

    internal bool method_29()
    {
        return this.method_155(CompatibilityOptions.ExpShRtn);
    }

    internal bool method_3()
    {
        return this.method_155(CompatibilityOptions.NoTabForInd);
    }

    internal void method_30(bool A_0)
    {
        this.method_153(CompatibilityOptions.ExpShRtn, A_0);
    }

    internal bool method_31()
    {
        return this.method_155(CompatibilityOptions.DontULTrlSpc);
    }

    internal void method_32(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontULTrlSpc, A_0);
    }

    internal bool method_33()
    {
        return this.method_155(CompatibilityOptions.DontBlnSbDbWid);
    }

    internal void method_34(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontBlnSbDbWid, A_0);
    }

    internal bool method_35()
    {
        return this.method_155(CompatibilityOptions.SuppressTopSpacingMac5);
    }

    internal void method_36(bool A_0)
    {
        this.method_153(CompatibilityOptions.SuppressTopSpacingMac5, A_0);
    }

    internal bool method_37()
    {
        return this.method_155(CompatibilityOptions.TruncDxaExpand);
    }

    internal void method_38(bool A_0)
    {
        this.method_153(CompatibilityOptions.TruncDxaExpand, A_0);
    }

    internal bool method_39()
    {
        return this.method_155(CompatibilityOptions.PrintBodyBeforeHdr);
    }

    internal void method_4(bool A_0)
    {
        this.method_153(CompatibilityOptions.NoTabForInd, A_0);
    }

    internal void method_40(bool A_0)
    {
        this.method_153(CompatibilityOptions.PrintBodyBeforeHdr, A_0);
    }

    internal bool method_41()
    {
        return this.method_155(CompatibilityOptions.NoExtLeading);
    }

    internal void method_42(bool A_0)
    {
        this.method_153(CompatibilityOptions.NoExtLeading, A_0);
    }

    internal bool method_43()
    {
        return this.method_155(CompatibilityOptions.DontMakeSpaceForUL);
    }

    internal void method_44(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontMakeSpaceForUL, A_0);
    }

    internal bool method_45()
    {
        return this.method_155(CompatibilityOptions.MWSmallCaps);
    }

    internal void method_46(bool A_0)
    {
        this.method_153(CompatibilityOptions.MWSmallCaps, A_0);
    }

    internal bool method_47()
    {
        return this.method_155(CompatibilityOptions.SuppressTopSpacing);
    }

    internal void method_48(bool A_0)
    {
        this.method_153(CompatibilityOptions.SuppressTopSpacing, A_0);
    }

    internal bool method_49()
    {
        return this.method_155(CompatibilityOptions.TruncFontHeight);
    }

    internal bool method_5()
    {
        return this.method_155(CompatibilityOptions.NoSpaceRaiseLower);
    }

    internal void method_50(bool A_0)
    {
        this.method_153(CompatibilityOptions.TruncFontHeight, A_0);
    }

    internal bool method_51()
    {
        return this.method_155(CompatibilityOptions.SubOnSize);
    }

    internal void method_52(bool A_0)
    {
        this.method_153(CompatibilityOptions.SubOnSize, A_0);
    }

    internal bool method_53()
    {
        return this.method_155(CompatibilityOptions.LineWrapLikeWord6);
    }

    internal void method_54(bool A_0)
    {
        this.method_153(CompatibilityOptions.LineWrapLikeWord6, A_0);
    }

    internal bool method_55()
    {
        return this.method_155(CompatibilityOptions.WW6BorderRules);
    }

    internal void method_56(bool A_0)
    {
        this.method_153(CompatibilityOptions.WW6BorderRules, A_0);
    }

    internal bool method_57()
    {
        return this.method_155(CompatibilityOptions.ExactOnTop);
    }

    internal void method_58(bool A_0)
    {
        this.method_153(CompatibilityOptions.ExactOnTop, A_0);
    }

    internal bool method_59()
    {
        return this.method_155(CompatibilityOptions.ExtraAfter);
    }

    internal void method_6(bool A_0)
    {
        this.method_153(CompatibilityOptions.NoSpaceRaiseLower, A_0);
    }

    internal void method_60(bool A_0)
    {
        this.method_153(CompatibilityOptions.ExtraAfter, A_0);
    }

    internal bool method_61()
    {
        return this.method_155(CompatibilityOptions.WPSpace);
    }

    internal void method_62(bool A_0)
    {
        this.method_153(CompatibilityOptions.WPSpace, A_0);
    }

    internal bool method_63()
    {
        return this.method_155(CompatibilityOptions.WPJust);
    }

    internal void method_64(bool A_0)
    {
        this.method_153(CompatibilityOptions.WPJust, A_0);
    }

    internal bool method_65()
    {
        return this.method_155(CompatibilityOptions.PrintMet);
    }

    internal void method_66(bool A_0)
    {
        this.method_153(CompatibilityOptions.PrintMet, A_0);
    }

    internal bool method_67()
    {
        return this.method_155(CompatibilityOptions.SpLayoutLikeWW8);
    }

    internal void method_68(bool A_0)
    {
        this.method_153(CompatibilityOptions.SpLayoutLikeWW8, A_0);
    }

    internal bool method_69()
    {
        return this.method_155(CompatibilityOptions.FtnLayoutLikeWW8);
    }

    internal bool method_7()
    {
        return this.method_155(CompatibilityOptions.SuppressSpBfAfterPgBrk);
    }

    internal void method_70(bool A_0)
    {
        this.method_153(CompatibilityOptions.FtnLayoutLikeWW8, A_0);
    }

    internal bool method_71()
    {
        return this.method_155(CompatibilityOptions.DontUseHTMLParagraphAutoSpacing);
    }

    internal void method_72(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontUseHTMLParagraphAutoSpacing, A_0);
    }

    internal bool method_73()
    {
        return this.method_155(CompatibilityOptions.DontAdjustLineHeightInTable);
    }

    internal void method_74(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontAdjustLineHeightInTable, A_0);
    }

    internal bool method_75()
    {
        return this.method_155(CompatibilityOptions.ForgetLastTabAlign);
    }

    internal void method_76(bool A_0)
    {
        this.method_153(CompatibilityOptions.ForgetLastTabAlign, A_0);
    }

    internal bool method_77()
    {
        return this.method_155(CompatibilityOptions.UseAutospaceForFullWidthAlpha);
    }

    internal void method_78(bool A_0)
    {
        this.method_153(CompatibilityOptions.UseAutospaceForFullWidthAlpha, A_0);
    }

    internal bool method_79()
    {
        return this.method_155(CompatibilityOptions.AlignTablesRowByRow);
    }

    internal void method_8(bool A_0)
    {
        this.method_153(CompatibilityOptions.SuppressSpBfAfterPgBrk, A_0);
    }

    internal void method_80(bool A_0)
    {
        this.method_153(CompatibilityOptions.AlignTablesRowByRow, A_0);
    }

    internal bool method_81()
    {
        return this.method_155(CompatibilityOptions.LayoutRawTableWidth);
    }

    internal void method_82(bool A_0)
    {
        this.method_153(CompatibilityOptions.LayoutRawTableWidth, A_0);
    }

    internal bool method_83()
    {
        return this.method_155(CompatibilityOptions.LayoutTableRowsApart);
    }

    internal void method_84(bool A_0)
    {
        this.method_153(CompatibilityOptions.LayoutTableRowsApart, A_0);
    }

    internal bool method_85()
    {
        return this.method_155(CompatibilityOptions.UseWord97LineBreakingRules);
    }

    internal void method_86(bool A_0)
    {
        this.method_153(CompatibilityOptions.UseWord97LineBreakingRules, A_0);
    }

    internal bool method_87()
    {
        return this.method_155(CompatibilityOptions.DontBreakWrappedTables);
    }

    internal void method_88(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontBreakWrappedTables, A_0);
    }

    internal bool method_89()
    {
        return this.method_155(CompatibilityOptions.DontSnapToGridInCell);
    }

    internal bool method_9()
    {
        return this.method_155(CompatibilityOptions.WrapTrailSpaces);
    }

    internal void method_90(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontSnapToGridInCell, A_0);
    }

    internal bool method_91()
    {
        return this.method_155(CompatibilityOptions.DontAllowFieldEndSelect);
    }

    internal void method_92(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontAllowFieldEndSelect, A_0);
    }

    internal bool method_93()
    {
        return this.method_155(CompatibilityOptions.ApplyBreakingRules);
    }

    internal void method_94(bool A_0)
    {
        this.method_153(CompatibilityOptions.ApplyBreakingRules, A_0);
    }

    internal bool method_95()
    {
        return this.method_155(CompatibilityOptions.DontWrapTextWithPunct);
    }

    internal void method_96(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontWrapTextWithPunct, A_0);
    }

    internal bool method_97()
    {
        return this.method_155(CompatibilityOptions.DontUseAsianBreakRules);
    }

    internal void method_98(bool A_0)
    {
        this.method_153(CompatibilityOptions.DontUseAsianBreakRules, A_0);
    }

    internal bool method_99()
    {
        return this.method_155(CompatibilityOptions.UseWord2002TableStyleRules);
    }
}

