using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Layouting;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

internal class Class210 : Class205
{
    private bool bool_27;
    private bool bool_28;
    private bool bool_29;
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
    private bool bool_40;
    private bool bool_41;
    private bool bool_42;
    [CompilerGenerated]
    private bool bool_43;
    [CompilerGenerated]
    private bool bool_44;
    private CharacterCategory characterCategory_0;
    private CharacterFormat characterFormat_0;
    private Class206.Class215 class215_0;
    private Class375 class375_0;
    private DocPicture docPicture_0;
    private float float_10;
    private float float_11;
    private float float_12;
    [CompilerGenerated]
    private float float_13;
    private float float_3;
    private float float_4;
    private float float_5;
    private float float_6;
    private float float_7;
    private float float_8;
    private float float_9;
    private HorizontalAlignment horizontalAlignment_0;
    private HorizontalAlignment horizontalAlignment_1;
    private int int_1;
    private LineSpacingRule lineSpacingRule_0;
    private ListNumberAlignment listNumberAlignment_0;
    private RectangleF rectangleF_0;
    private RectangleF rectangleF_1;
    private RectangleF rectangleF_2;
    private SectionBreakType sectionBreakType_0;
    private string string_0;

    public Class210()
    {
        this.bool_29 = true;
        this.int_1 = -1;
        this.float_8 = float.MinValue;
        this.string_0 = string.Empty;
    }

    public Class210(ChildrenLayoutDirection A_0) : base(A_0)
    {
        this.bool_29 = true;
        this.int_1 = -1;
        this.float_8 = float.MinValue;
        this.string_0 = string.Empty;
    }

    public Class210(ChildrenLayoutDirection A_0, bool A_1) : this(A_0)
    {
        this.bool_27 = A_1;
    }

    public void method_100()
    {
        this.method_98(0f);
        this.method_96(false);
        this.method_94(false);
    }

    public int method_13()
    {
        return this.int_1;
    }

    public void method_14(int A_0)
    {
        this.int_1 = A_0;
    }

    public HorizontalAlignment method_15()
    {
        return this.horizontalAlignment_0;
    }

    public void method_16(HorizontalAlignment A_0)
    {
        this.horizontalAlignment_0 = A_0;
    }

    public HorizontalAlignment method_17()
    {
        return this.horizontalAlignment_1;
    }

    public void method_18(HorizontalAlignment A_0)
    {
        this.horizontalAlignment_1 = A_0;
    }

    public float method_19()
    {
        return this.float_3;
    }

    public void method_20(float A_0)
    {
        this.float_3 = A_0;
    }

    public float method_21()
    {
        return this.float_10;
    }

    public void method_22(float A_0)
    {
        this.float_10 = A_0;
    }

    public float method_23()
    {
        return this.float_11;
    }

    public void method_24(float A_0)
    {
        this.float_11 = A_0;
    }

    public bool method_25()
    {
        return this.bool_39;
    }

    public void method_26(bool A_0)
    {
        this.bool_39 = A_0;
    }

    public bool method_27()
    {
        return this.bool_40;
    }

    public void method_28(bool A_0)
    {
        this.bool_40 = A_0;
    }

    internal bool method_29()
    {
        return this.bool_32;
    }

    internal void method_30(bool A_0)
    {
        this.bool_32 = A_0;
    }

    internal bool method_31()
    {
        return this.bool_33;
    }

    internal void method_32(bool A_0)
    {
        this.bool_33 = A_0;
    }

    internal bool method_33()
    {
        return this.bool_34;
    }

    internal void method_34(bool A_0)
    {
        this.bool_34 = A_0;
    }

    public bool method_35()
    {
        return this.bool_28;
    }

    public void method_36(bool A_0)
    {
        this.bool_28 = A_0;
    }

    public bool method_37()
    {
        return this.bool_27;
    }

    public void method_38(bool A_0)
    {
        this.bool_27 = A_0;
    }

    public bool method_39()
    {
        return this.bool_30;
    }

    public void method_40(bool A_0)
    {
        this.bool_30 = A_0;
    }

    public bool method_41()
    {
        return this.bool_31;
    }

    public void method_42(bool A_0)
    {
        this.bool_31 = A_0;
    }

    public bool method_43()
    {
        return this.bool_29;
    }

    public void method_44(bool A_0)
    {
        this.bool_29 = A_0;
    }

    internal bool method_45()
    {
        return this.bool_35;
    }

    internal void method_46(bool A_0)
    {
        this.bool_35 = A_0;
    }

    public bool method_47()
    {
        return this.bool_37;
    }

    public void method_48(bool A_0)
    {
        this.bool_37 = A_0;
    }

    public bool method_49()
    {
        return this.bool_38;
    }

    public void method_50(bool A_0)
    {
        this.bool_38 = A_0;
    }

    public float method_51()
    {
        return this.float_4;
    }

    public void method_52(float A_0)
    {
        this.float_4 = A_0;
    }

    public float method_53()
    {
        return this.float_6;
    }

    public void method_54(float A_0)
    {
        this.float_6 = A_0;
    }

    public LineSpacingRule method_55()
    {
        return this.lineSpacingRule_0;
    }

    public void method_56(LineSpacingRule A_0)
    {
        this.lineSpacingRule_0 = A_0;
    }

    internal float method_57()
    {
        return this.float_7;
    }

    internal void method_58(float A_0)
    {
        this.float_7 = A_0;
    }

    internal float method_59()
    {
        return this.float_8;
    }

    internal void method_60(float A_0)
    {
        this.float_8 = A_0;
    }

    internal float method_61()
    {
        return this.float_5;
    }

    internal void method_62(float A_0)
    {
        this.float_5 = A_0;
    }

    internal SectionBreakType method_63()
    {
        return this.sectionBreakType_0;
    }

    internal void method_64(SectionBreakType A_0)
    {
        this.sectionBreakType_0 = A_0;
    }

    public string method_65()
    {
        return this.string_0;
    }

    public void method_66(string A_0)
    {
        this.string_0 = A_0;
    }

    public CharacterCategory method_67()
    {
        return this.characterCategory_0;
    }

    internal void method_68(CharacterCategory A_0)
    {
        this.characterCategory_0 = A_0;
    }

    internal float method_69()
    {
        return this.float_9;
    }

    internal void method_70(float A_0)
    {
        this.float_9 = A_0;
    }

    public CharacterFormat method_71()
    {
        return this.characterFormat_0;
    }

    public void method_72(CharacterFormat A_0)
    {
        this.characterFormat_0 = A_0;
    }

    public bool method_73()
    {
        return this.bool_36;
    }

    public void method_74(bool A_0)
    {
        this.bool_36 = A_0;
    }

    public ListNumberAlignment method_75()
    {
        return this.listNumberAlignment_0;
    }

    public void method_76(ListNumberAlignment A_0)
    {
        this.listNumberAlignment_0 = A_0;
    }

    public Class206.Class215 method_77()
    {
        return this.class215_0;
    }

    public void method_78(Class206.Class215 A_0)
    {
        this.class215_0 = A_0;
    }

    internal DocPicture method_79()
    {
        return this.docPicture_0;
    }

    internal void method_80(DocPicture A_0)
    {
        this.docPicture_0 = A_0;
    }

    internal bool method_81()
    {
        return this.bool_41;
    }

    internal void method_82(bool A_0)
    {
        this.bool_41 = A_0;
    }

    internal RectangleF method_83()
    {
        return this.rectangleF_0;
    }

    internal void method_84(RectangleF A_0)
    {
        this.rectangleF_0 = A_0;
    }

    internal RectangleF method_85()
    {
        return this.rectangleF_1;
    }

    internal void method_86(RectangleF A_0)
    {
        this.rectangleF_1 = A_0;
    }

    internal RectangleF method_87()
    {
        return this.rectangleF_2;
    }

    internal void method_88(RectangleF A_0)
    {
        this.rectangleF_2 = A_0;
    }

    internal float method_89()
    {
        return this.float_12;
    }

    internal void method_90(float A_0)
    {
        this.float_12 = A_0;
    }

    internal Class375 method_91()
    {
        return this.class375_0;
    }

    internal void method_92(Class375 A_0)
    {
        this.class375_0 = A_0;
    }

    [CompilerGenerated]
    internal bool method_93()
    {
        return this.bool_43;
    }

    [CompilerGenerated]
    internal void method_94(bool A_0)
    {
        this.bool_43 = A_0;
    }

    [CompilerGenerated]
    internal bool method_95()
    {
        return this.bool_44;
    }

    [CompilerGenerated]
    internal void method_96(bool A_0)
    {
        this.bool_44 = A_0;
    }

    [CompilerGenerated]
    internal float method_97()
    {
        return this.float_13;
    }

    [CompilerGenerated]
    internal void method_98(float A_0)
    {
        this.float_13 = A_0;
    }

    public void method_99()
    {
    }
}

