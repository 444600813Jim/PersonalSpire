using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Caculation;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;

internal class Class422 : Class420, Interface14
{
    private ArrayList arrayList_0;
    private ArrayList arrayList_1;
    private ArrayList arrayList_2;
    private ArrayList arrayList_3;
    private bool bool_0;
    private bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private Class1136 class1136_0;
    private Class240 class240_0;
    private Class241 class241_0;
    private Class400 class400_0;
    private Class468 class468_0;
    private Class470 class470_0;
    private Class471 class471_0;
    private Class476 class476_0;
    private Class52 class52_0;
    private Class528 class528_0;
    private Class569 class569_0;
    private Class690 class690_0;
    private Class691 class691_0;
    private Class850 class850_0;
    private Class88 class88_0;
    private Class89 class89_0;
    private Class89 class89_1;
    private Class89 class89_2;
    private Class918 class918_0;
    private Class928 class928_0;
    private Class973 class973_0;
    private DocumentObject documentObject_0;
    private Hashtable hashtable_0;
    internal Hashtable hashtable_1;
    private int int_1;
    private int int_10;
    private int int_11;
    private int int_12;
    private int int_13;
    private int int_14;
    private int int_15;
    private int int_16;
    private int int_17;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private int int_8;
    private int int_9;
    private OpenDocumentWritingStage openDocumentWritingStage_0;
    private Paragraph paragraph_0;
    private Section section_0;

    public Class422()
    {
        this.hashtable_1 = new Hashtable();
    }

    public Class422(Document A_0, Stream A_1) : this()
    {
        Class253 class2 = new Class255(FileFormat.Odt);
        Class928 class3 = new Class928(A_0, A_1, string.Empty, class2);
        this.method_5(class3);
        this.bool_1 = false;
        this.bool_3 = false;
        this.bool_4 = false;
        this.class240_0 = new Class240();
    }

    Class1104 Interface14.imethod_0(Class928 A_0)
    {
        this.method_5(A_0);
        this.bool_1 = false;
        this.bool_3 = false;
        this.bool_4 = false;
        this.class240_0 = new Class240();
        this.method_7();
        return new Class1104(this.method_6());
    }

    internal string method_10()
    {
        this.method_40(this.method_39() + 1);
        return string.Format(BookmarkStart.b("測笮䨰̲䠴", 7), this.method_39());
    }

    internal void method_100(bool A_0)
    {
        this.bool_10 = A_0;
    }

    internal bool method_101()
    {
        return this.bool_11;
    }

    internal void method_102(bool A_0)
    {
        this.bool_11 = A_0;
    }

    internal bool method_103()
    {
        return this.bool_12;
    }

    internal void method_104(bool A_0)
    {
        this.bool_12 = A_0;
    }

    internal int method_105()
    {
        return this.int_17;
    }

    internal void method_106(int A_0)
    {
        this.int_17 = A_0;
    }

    internal Class52 method_107()
    {
        if (this.class52_0 == null)
        {
            this.class52_0 = new Class52(this.method_15());
        }
        return this.class52_0;
    }

    internal void method_11(DocumentObject A_0, Section A_1)
    {
        if (A_0.NextSibling == null)
        {
            if (((A_0.ParentObject is Body) && (A_1 != null)) && ((A_1.Owner != null) && !A_1.IsLastChild))
            {
                this.documentObject_0 = null;
            }
            else
            {
                this.documentObject_0 = A_0.ParentObject;
            }
        }
        else
        {
            this.documentObject_0 = A_0;
        }
    }

    internal string method_12(Class43 A_0, ArrowType A_1, bool A_2)
    {
        if (A_1 == ArrowType.None)
        {
            return null;
        }
        Class110 class2 = Class576.smethod_63(A_0, A_1, A_2);
        if (this.class89_1.method_2(class2.method_0(), null, false, false) == null)
        {
            this.class89_1.method_1(class2, false, false);
        }
        return class2.method_0();
    }

    internal Class476 method_13()
    {
        return this.class476_0;
    }

    internal Class255 method_14()
    {
        return (Class255) this.class928_0.class253_0;
    }

    internal Document method_15()
    {
        return this.class928_0.document_0;
    }

    internal Section method_16()
    {
        return this.section_0;
    }

    internal void method_17(Section A_0)
    {
        this.section_0 = A_0;
    }

    internal Class400 method_18()
    {
        return this.class400_0;
    }

    internal void method_19(Class400 A_0)
    {
        this.class400_0 = A_0;
    }

    internal bool method_20()
    {
        if (this.openDocumentWritingStage_0 != OpenDocumentWritingStage.ContentAutomaticStyles)
        {
            return (this.openDocumentWritingStage_0 == OpenDocumentWritingStage.ContentBody);
        }
        return true;
    }

    internal bool method_21()
    {
        if (this.openDocumentWritingStage_0 != OpenDocumentWritingStage.ContentAutomaticStyles)
        {
            return (this.openDocumentWritingStage_0 == OpenDocumentWritingStage.StylesAutomaticStyles);
        }
        return true;
    }

    internal bool method_22()
    {
        if (this.openDocumentWritingStage_0 != OpenDocumentWritingStage.StylesMasterPage)
        {
            return (this.openDocumentWritingStage_0 == OpenDocumentWritingStage.ContentBody);
        }
        return true;
    }

    internal OpenDocumentWritingStage method_23()
    {
        return this.openDocumentWritingStage_0;
    }

    internal void method_24(OpenDocumentWritingStage A_0)
    {
        this.openDocumentWritingStage_0 = A_0;
    }

    internal int method_25()
    {
        return this.int_1;
    }

    internal void method_26(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_27()
    {
        return this.int_15;
    }

    internal void method_28(int A_0)
    {
        this.int_15 = A_0;
    }

    internal int method_29()
    {
        return this.int_2;
    }

    internal Class400 method_3(string A_0)
    {
        Class113 class2 = new Class113(A_0);
        this.class400_0 = new Class400(class2, this.method_14().method_6());
        this.class476_0.method_1().method_1(class2);
        return this.class400_0;
    }

    internal void method_30(int A_0)
    {
        this.int_2 = A_0;
    }

    internal int method_31()
    {
        return this.int_3;
    }

    internal void method_32(int A_0)
    {
        this.int_3 = A_0;
    }

    internal int method_33()
    {
        return this.int_7;
    }

    internal void method_34(int A_0)
    {
        this.int_7 = A_0;
    }

    internal int method_35()
    {
        return this.int_4;
    }

    internal void method_36(int A_0)
    {
        this.int_4 = A_0;
    }

    internal int method_37()
    {
        return this.int_5;
    }

    internal void method_38(int A_0)
    {
        this.int_5 = A_0;
    }

    internal int method_39()
    {
        return this.int_6;
    }

    public void method_4(Document A_0, Stream A_1, Class928 A_2)
    {
        this.method_5(A_2);
        this.bool_1 = false;
        this.bool_3 = false;
        this.bool_4 = false;
        this.class240_0 = new Class240();
        this.method_7();
    }

    internal void method_40(int A_0)
    {
        this.int_6 = A_0;
    }

    internal int method_41()
    {
        return this.int_8;
    }

    internal void method_42(int A_0)
    {
        this.int_8 = A_0;
    }

    internal int method_43()
    {
        return this.int_9;
    }

    internal void method_44(int A_0)
    {
        this.int_9 = A_0;
    }

    internal int method_45()
    {
        return this.int_10;
    }

    internal void method_46(int A_0)
    {
        this.int_10 = A_0;
    }

    internal int method_47()
    {
        return this.int_11;
    }

    internal void method_48(int A_0)
    {
        this.int_11 = A_0;
    }

    internal int method_49()
    {
        return this.int_12;
    }

    private void method_5(Class928 A_0)
    {
        this.class928_0 = A_0;
        if (this.class928_0.document_0.TrackChanges)
        {
            Document document = this.class928_0.document_0.Clone();
            document.AcceptChanges();
            this.class928_0.document_0 = document;
        }
    }

    internal void method_50(int A_0)
    {
        this.int_12 = A_0;
    }

    internal int method_51()
    {
        return this.int_14;
    }

    internal void method_52(int A_0)
    {
        this.int_14 = A_0;
    }

    internal int method_53()
    {
        return this.int_13;
    }

    internal void method_54(int A_0)
    {
        this.int_13 = A_0;
    }

    internal ArrayList method_55()
    {
        return this.arrayList_0;
    }

    internal void method_56(ArrayList A_0)
    {
        this.arrayList_0 = A_0;
    }

    internal ArrayList method_57()
    {
        return this.arrayList_1;
    }

    internal void method_58(ArrayList A_0)
    {
        this.arrayList_1 = A_0;
    }

    internal ArrayList method_59()
    {
        return this.arrayList_2;
    }

    private string method_6()
    {
        int num = 11;
        switch (this.class928_0.method_0())
        {
            case FileFormat.Odt:
                return BookmarkStart.b("倰䌲䔴嬶倸堺尼䬾⡀ⱂ⭄框㽈╊⥌慎㹐㉒♔㹖⩘畚㉜⽞ѠൢŤࡦ੨Ṫl੮ὰݲ孴Ͷᱸͺॼ", num);

            case FileFormat.Ott:
                return BookmarkStart.b("倰䌲䔴嬶倸堺尼䬾⡀ⱂ⭄框㽈╊⥌慎㹐㉒♔㹖⩘畚㉜⽞ѠൢŤࡦ੨Ṫl੮ὰݲ孴Ͷᱸͺॼ剾歷", num);
        }
        throw new InvalidOperationException(BookmarkStart.b("搰崲倴伶䤸帺帼䬾⑀❂敄㑆⡈㵊⡌潎㝐㱒❔㩖㡘⽚絜⭞ᡠ።d䥦", num));
    }

    internal void method_60(ArrayList A_0)
    {
        this.arrayList_2 = A_0;
    }

    internal ArrayList method_61()
    {
        return this.arrayList_3;
    }

    internal void method_62(ArrayList A_0)
    {
        this.arrayList_3 = A_0;
    }

    internal bool method_63()
    {
        return this.bool_5;
    }

    internal void method_64(bool A_0)
    {
        this.bool_5 = A_0;
    }

    internal bool method_65()
    {
        return this.bool_6;
    }

    internal void method_66(bool A_0)
    {
        this.bool_6 = A_0;
    }

    internal bool method_67()
    {
        return this.bool_1;
    }

    internal void method_68(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal bool method_69()
    {
        return this.bool_2;
    }

    private void method_7()
    {
        this.class89_1 = new Class89();
        this.class89_0 = new Class89();
        this.class89_2 = new Class89();
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        this.arrayList_3 = new ArrayList();
        this.class241_0 = new Class241(this);
        this.class468_0 = new Class468(this);
        this.class973_0 = new Class973(this);
        this.class918_0 = new Class918(this);
        this.class569_0 = new Class569(this);
        this.class471_0 = new Class471(this);
        this.class470_0 = new Class470(this);
        this.class850_0 = new Class850(this);
        this.class691_0 = new Class691(this);
        this.class690_0 = new Class690(this);
        this.class528_0 = new Class528(this);
        this.hashtable_0 = new Hashtable();
        this.class476_0 = new Class476();
        this.class88_0 = new Class88(this);
        this.class88_0.method_0();
        new Class1094(this).method_0();
        this.arrayList_3.Clear();
        new Class793(this).method_0();
        this.openDocumentWritingStage_0 = OpenDocumentWritingStage.MathML;
        this.method_15().Accept(this);
        new Class239(this).method_0(this.method_6());
        new Class849(this).method_0();
        this.class476_0.method_3(this.class928_0.stream_0, this.method_6());
    }

    internal void method_70(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal int method_71()
    {
        return this.int_16;
    }

    internal void method_72(int A_0)
    {
        this.int_16 = A_0;
    }

    internal bool method_73()
    {
        return this.bool_8;
    }

    internal void method_74(bool A_0)
    {
        this.bool_8 = A_0;
    }

    internal bool method_75()
    {
        return this.bool_3;
    }

    internal void method_76(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal bool method_77()
    {
        return this.bool_4;
    }

    internal void method_78(bool A_0)
    {
        this.bool_4 = A_0;
    }

    internal bool method_79()
    {
        return this.bool_7;
    }

    internal void method_8()
    {
        this.int_16 = 0;
        this.int_2 = 0;
        this.int_7 = 0;
        this.int_4 = 0;
        this.int_5 = 0;
        this.int_6 = 0;
        this.int_8 = 0;
        this.int_9 = 0;
        this.int_10 = 0;
        this.int_11 = 0;
        this.int_12 = 0;
        this.int_3 = 0;
        this.int_13 = 0;
        this.int_14 = 0;
        this.int_17 = 0;
    }

    internal void method_80(bool A_0)
    {
        this.bool_7 = A_0;
    }

    internal Class89 method_81()
    {
        return this.class89_0;
    }

    internal void method_82(Class89 A_0)
    {
        this.class89_0 = A_0;
    }

    internal Class89 method_83()
    {
        return this.class89_1;
    }

    internal void method_84(Class89 A_0)
    {
        this.class89_1 = A_0;
    }

    internal Class89 method_85()
    {
        return this.class89_2;
    }

    internal void method_86(Class89 A_0)
    {
        this.class89_2 = A_0;
    }

    internal DocumentObject method_87()
    {
        return this.documentObject_0;
    }

    internal void method_88(DocumentObject A_0)
    {
        this.documentObject_0 = A_0;
    }

    internal Paragraph method_89()
    {
        return this.paragraph_0;
    }

    private VisitorAction method_9(ParagraphBase A_0)
    {
        if (this.class1136_0 != null)
        {
            if (this.method_23() == OpenDocumentWritingStage.MathML)
            {
                this.class1136_0.method_25(A_0);
            }
            return VisitorAction.Continue;
        }
        if (A_0.ParentObject.DocumentObjectType == DocumentObjectType.OfficeMath)
        {
            return VisitorAction.Continue;
        }
        return this.class691_0.method_3(A_0);
    }

    internal void method_90(Paragraph A_0)
    {
        this.paragraph_0 = A_0;
    }

    internal Class240 method_91()
    {
        return this.class240_0;
    }

    internal void method_92(Class240 A_0)
    {
        this.class240_0 = A_0;
    }

    internal Hashtable method_93()
    {
        return this.hashtable_0;
    }

    internal void method_94(Hashtable A_0)
    {
        this.hashtable_0 = A_0;
    }

    internal bool method_95()
    {
        return this.bool_0;
    }

    internal void method_96(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal bool method_97()
    {
        return this.bool_9;
    }

    internal void method_98(bool A_0)
    {
        this.bool_9 = A_0;
    }

    internal bool method_99()
    {
        return this.bool_10;
    }

    internal static bool smethod_0(object A_0, bool A_1)
    {
        if (!(A_0 is Style))
        {
            return false;
        }
        Style style = (Style) A_0;
        if (A_1 || ((style.StyleType != StyleType.ParagraphStyle) && (style.StyleType != StyleType.ListStyle)))
        {
            return false;
        }
        return (style.BasedOnIstd == 0xfff);
    }

    internal static bool smethod_1(DocumentObject A_0)
    {
        Body body = (Body) A_0.method_6(DocumentObjectType.Body);
        return ((body != null) && (body.DocumentObjectType == DocumentObjectType.Body));
    }

    public override VisitorAction vmethod_0(Document A_0)
    {
        this.class240_0.Clear();
        return this.class88_0.method_1();
    }

    public override VisitorAction vmethod_1(Document A_0)
    {
        return this.class973_0.method_1();
    }

    public override VisitorAction vmethod_10(Table A_0)
    {
        return this.class690_0.method_0(A_0);
    }

    public override VisitorAction vmethod_11(Table A_0)
    {
        return this.class690_0.method_1(A_0);
    }

    public override VisitorAction vmethod_12(TableRow A_0)
    {
        return this.class690_0.method_2(A_0);
    }

    public override VisitorAction vmethod_13(TableRow A_0)
    {
        return this.class690_0.method_3(A_0);
    }

    public override VisitorAction vmethod_14(TableCell A_0)
    {
        return this.class690_0.method_4(A_0);
    }

    public override VisitorAction vmethod_15(TableCell A_0)
    {
        return this.class690_0.method_5(A_0);
    }

    public override VisitorAction vmethod_16(TextRange A_0)
    {
        return this.method_9(A_0);
    }

    public override VisitorAction vmethod_18(Field A_0)
    {
        return this.class241_0.method_0(A_0);
    }

    public override VisitorAction vmethod_2(Section A_0)
    {
        return this.class918_0.method_0(A_0);
    }

    public override VisitorAction vmethod_23(BookmarkStart A_0)
    {
        return this.class471_0.method_0(A_0);
    }

    public override VisitorAction vmethod_24(Break A_0)
    {
        int num = 0x11;
        if (this.method_22() && (A_0.BreakType == BreakType.LineBreak))
        {
            this.class400_0.method_10(BookmarkStart.b("䌶尸䌺䤼Ծⵀ⩂⭄≆摈⥊㽌⩎ぐ㡒", num));
        }
        return base.vmethod_24(A_0);
    }

    public override VisitorAction vmethod_25(BookmarkEnd A_0)
    {
        return this.class471_0.method_1(A_0);
    }

    public override VisitorAction vmethod_26(Footnote A_0)
    {
        return this.class470_0.method_0(A_0);
    }

    public override VisitorAction vmethod_29(Footnote A_0)
    {
        return this.class470_0.method_1(A_0);
    }

    public override VisitorAction vmethod_3(Section A_0)
    {
        return this.class918_0.method_1(A_0);
    }

    public override VisitorAction vmethod_30(Comment A_0)
    {
        return this.class528_0.method_0(A_0);
    }

    public override VisitorAction vmethod_32(Comment A_0)
    {
        return this.class528_0.method_1(A_0);
    }

    public override VisitorAction vmethod_34(ShapeObject A_0)
    {
        return this.class468_0.method_0(A_0);
    }

    public override VisitorAction vmethod_35(ShapeObject A_0)
    {
        return this.class468_0.method_7(A_0);
    }

    public override VisitorAction vmethod_36(ShapeGroup A_0)
    {
        return this.class468_0.method_0(A_0);
    }

    public override VisitorAction vmethod_37(ShapeGroup A_0)
    {
        return this.class468_0.method_7(A_0);
    }

    public override VisitorAction vmethod_38(Class5 A_0)
    {
        int num = 7;
        if (this.openDocumentWritingStage_0 == OpenDocumentWritingStage.MathML)
        {
            if (A_0.method_32().vmethod_1() == MathObjectType.OMath)
            {
                this.class1136_0 = new Class1136(this, A_0);
            }
            if (this.class1136_0 != null)
            {
                return this.class1136_0.method_0(A_0);
            }
        }
        if ((A_0.method_32().vmethod_1() == MathObjectType.OMath) && this.method_22())
        {
            this.method_18().method_9(BookmarkStart.b("ᄬ䬮䌰刲䈴ശ弸䤺尼刾⑀終", num));
            this.method_18().method_66(BookmarkStart.b("䤬崮倰䐲༴堶嬸儺堼尾㕀", num));
            this.method_18().method_69(BookmarkStart.b("唬䌮堰崲帴ശ儸䤺堼夾", num), A_0.method_38());
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_39(Class5 A_0)
    {
        int num = 6;
        if (A_0.method_32().vmethod_1() == MathObjectType.OMath)
        {
            if (this.openDocumentWritingStage_0 == OpenDocumentWritingStage.MathML)
            {
                this.class400_0.method_3();
                this.class1136_0 = null;
                return VisitorAction.Continue;
            }
            if (this.method_22())
            {
                this.method_18().method_67(BookmarkStart.b("䠫尭儯䔱ำ夵娷倹夻崽㐿", num));
                this.method_18().method_67(BookmarkStart.b("䠫尭儯䔱ำ倵䨷嬹儻嬽", num));
            }
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_4(Body A_0)
    {
        this.bool_3 = A_0.method_2().BreakCode == SectionBreakType.NewPage;
        this.documentObject_0 = null;
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_42(StructureDocumentTag A_0)
    {
        A_0.UpdateDataBinding();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_44(StructureDocumentTagInline A_0)
    {
        A_0.UpdateDataBinding();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_46(StructureDocumentTagCell A_0)
    {
        A_0.UpdateDataBinding();
        return this.class690_0.method_4(A_0);
    }

    public override VisitorAction vmethod_47(StructureDocumentTagCell A_0)
    {
        return this.class690_0.method_5(A_0);
    }

    public override VisitorAction vmethod_48(StructureDocumentTagRow A_0)
    {
        A_0.UpdateDataBinding();
        return this.class690_0.method_2(A_0);
    }

    public override VisitorAction vmethod_49(StructureDocumentTagRow A_0)
    {
        return this.class690_0.method_3(A_0);
    }

    public override VisitorAction vmethod_5(Body A_0)
    {
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_6(HeaderFooter A_0)
    {
        return this.class850_0.method_0(A_0);
    }

    public override VisitorAction vmethod_7(HeaderFooter A_0)
    {
        return this.class850_0.method_1(A_0);
    }

    public override VisitorAction vmethod_8(Paragraph A_0)
    {
        return this.class569_0.method_3(A_0);
    }

    public override VisitorAction vmethod_9(Paragraph A_0)
    {
        return this.class569_0.method_5(A_0);
    }
}

