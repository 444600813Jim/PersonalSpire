using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class14 : WordAttrCollection
{
    private bool bool_2;
    private bool bool_3;
    private readonly Class906 class906_0;
    private Color color_0;
    private FrameDividerPositionType frameDividerPositionType_0;
    private FrameLayoutType frameLayoutType_0;
    private FrameScrollType frameScrollType_0;
    private FramesetBorderType framesetBorderType_0;
    private int int_10;
    private int int_11;
    private int int_8;
    private int int_9;
    internal const short short_0 = 3;
    internal const short short_1 = 4;
    internal const short short_10 = 13;
    internal const short short_11 = 14;
    internal const short short_12 = 15;
    internal const short short_13 = 0x10;
    internal const short short_14 = 0x11;
    internal const short short_15 = 0x12;
    internal const short short_16 = 0x13;
    internal const short short_17 = 20;
    internal const short short_18 = 0x15;
    internal const short short_2 = 5;
    internal const short short_3 = 6;
    internal const short short_4 = 7;
    internal const short short_5 = 8;
    internal const short short_6 = 9;
    internal const short short_7 = 5;
    internal const short short_8 = 11;
    internal const short short_9 = 12;
    private string string_3;
    private string string_4;
    private string string_5;

    internal Class14()
    {
        this.frameDividerPositionType_0 = FrameDividerPositionType.Relative;
        this.int_8 = 1;
        this.class906_0 = new Class906();
        this.color_0 = Color.Empty;
        this.framesetBorderType_0 = FramesetBorderType.Simple;
    }

    internal Class14(FormatBase A_0, int A_1) : base(A_0, A_1)
    {
        this.frameDividerPositionType_0 = FrameDividerPositionType.Relative;
        this.int_8 = 1;
        this.class906_0 = new Class906();
        this.color_0 = Color.Empty;
        this.framesetBorderType_0 = FramesetBorderType.Simple;
    }

    internal short method_100()
    {
        return (short) base[0x10];
    }

    internal void method_101(short A_0)
    {
        base[0x10] = A_0;
    }

    internal float method_102()
    {
        return (((float) this.method_100()) / 20f);
    }

    internal FrameTextWrap method_103()
    {
        if (this.HasValue(0x12))
        {
            return (FrameTextWrap) base[0x12];
        }
        if ((this.HasValue(0x11) && (this.method_87() != 0)) || (this.HasValue(6) && (this.method_92() != 0)))
        {
            return FrameTextWrap.Around;
        }
        if ((!this.HasValue(0x11) && !this.HasValue(6)) && (this.method_95() == FrameSizeRule.Exact))
        {
            return FrameTextWrap.Around;
        }
        if (((this.method_63() != 0) || (this.method_68() != 0)) || (this.HasValue(11) || this.HasValue(12)))
        {
            return FrameTextWrap.Around;
        }
        if (this.method_108() != DropCapPosition.None)
        {
            return FrameTextWrap.Around;
        }
        return FrameTextWrap.None;
    }

    internal void method_104(FrameTextWrap A_0)
    {
        base[0x12] = A_0;
    }

    internal bool method_105()
    {
        return (bool) base[13];
    }

    internal void method_106(bool A_0)
    {
        base[13] = A_0;
    }

    internal bool method_107()
    {
        if (!this.HasValue(0x12))
        {
            return (this.method_103() != FrameTextWrap.None);
        }
        if (((this.method_103() == FrameTextWrap.Auto) && (this.method_63() == 0)) && (this.method_68() == 0))
        {
            return false;
        }
        return true;
    }

    internal DropCapPosition method_108()
    {
        return (DropCapPosition) base[20];
    }

    internal void method_109(DropCapPosition A_0)
    {
        base[20] = A_0;
    }

    internal int method_110()
    {
        return (int) base[0x15];
    }

    internal void method_111(int A_0)
    {
        if ((A_0 >= 1) && (A_0 <= 10))
        {
            base[0x15] = A_0;
        }
    }

    internal bool method_112()
    {
        switch (this.method_103())
        {
            case FrameTextWrap.Auto:
            case FrameTextWrap.Around:
            case FrameTextWrap.Tight:
            case FrameTextWrap.Through:
                return true;

            case FrameTextWrap.NotBeside:
            case FrameTextWrap.None:
                return false;
        }
        return false;
    }

    internal void method_113(bool A_0)
    {
        if (A_0)
        {
            this.method_104(FrameTextWrap.Around);
        }
        else
        {
            this.method_104(FrameTextWrap.None);
        }
    }

    internal FrameScrollType method_114()
    {
        return this.frameScrollType_0;
    }

    internal void method_115(FrameScrollType A_0)
    {
        this.frameScrollType_0 = A_0;
    }

    internal bool method_116()
    {
        return this.bool_2;
    }

    internal void method_117(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal bool method_118()
    {
        return this.bool_3;
    }

    internal void method_119(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal bool method_120()
    {
        return (this.method_121().method_0() > 0);
    }

    internal Class906 method_121()
    {
        return this.class906_0;
    }

    internal FramesetBorderType method_122()
    {
        return this.framesetBorderType_0;
    }

    internal void method_123(FramesetBorderType A_0)
    {
        this.framesetBorderType_0 = A_0;
    }

    internal Color method_124()
    {
        return this.color_0;
    }

    internal void method_125(Color A_0)
    {
        this.color_0 = A_0;
    }

    internal int method_126()
    {
        return this.int_11;
    }

    internal void method_127(int A_0)
    {
        this.int_11 = A_0;
    }

    internal bool method_128(int A_0)
    {
        return (base.PropertiesHash.ContainsKey(this.GetFullKey(A_0)) || ((base.BaseFormat != null) && (base.BaseFormat as Class14).method_128(this.GetFullKey(A_0))));
    }

    internal void method_129(int A_0)
    {
        base.PropertiesHash.Remove(A_0);
    }

    internal string method_49()
    {
        return this.string_3;
    }

    internal void method_50(string A_0)
    {
        this.string_3 = A_0;
    }

    internal string method_51()
    {
        if (!this.method_120())
        {
            return this.string_4;
        }
        return null;
    }

    internal void method_52(string A_0)
    {
        if (Class567.smethod_16(A_0) && (A_0.Length > 0xff))
        {
            A_0 = A_0.Substring(0, 0xff);
        }
        this.string_4 = A_0;
    }

    internal string method_53()
    {
        if (!this.method_120())
        {
            return this.string_5;
        }
        return null;
    }

    internal void method_54(string A_0)
    {
        this.string_5 = A_0;
    }

    internal FrameDividerPositionType method_55()
    {
        return this.frameDividerPositionType_0;
    }

    internal void method_56(FrameDividerPositionType A_0)
    {
        this.frameDividerPositionType_0 = A_0;
    }

    internal int method_57()
    {
        return this.int_8;
    }

    internal void method_58(int A_0)
    {
        this.int_8 = A_0;
    }

    internal FrameLayoutType method_59()
    {
        return this.frameLayoutType_0;
    }

    internal void method_60(FrameLayoutType A_0)
    {
        this.frameLayoutType_0 = A_0;
    }

    internal int method_61()
    {
        return this.int_9;
    }

    internal void method_62(int A_0)
    {
        this.int_9 = A_0;
    }

    internal short method_63()
    {
        if (!base.HasKey(3))
        {
            if (base.HasKey(8))
            {
                switch (this.method_74())
                {
                    case HorizontalPosition.None:
                    case HorizontalPosition.Left:
                        return 0;

                    case HorizontalPosition.Center:
                        return -4;

                    case HorizontalPosition.Right:
                        return -8;

                    case HorizontalPosition.Inside:
                        return -12;

                    case HorizontalPosition.Outside:
                        return -16;
                }
            }
            else if (base.BaseFormat is Class14)
            {
                return (base.BaseFormat as Class14).method_63();
            }
        }
        return (short) base[3];
    }

    internal void method_64(short A_0)
    {
        base[3] = A_0;
    }

    internal short method_65()
    {
        if (((this.method_63() != -4) && (this.method_63() != -8)) && ((this.method_63() != -12) && (this.method_63() != -16)))
        {
            return (short) (this.method_63() - 1);
        }
        return -1;
    }

    internal int method_66()
    {
        return this.int_10;
    }

    internal void method_67(int A_0)
    {
        this.int_10 = A_0;
    }

    internal short method_68()
    {
        if (!base.HasKey(4))
        {
            if (base.HasKey(15))
            {
                switch (this.method_77())
                {
                    case VerticalPosition.Inline:
                    case VerticalPosition.None:
                        return 0;

                    case VerticalPosition.Top:
                        return -4;

                    case VerticalPosition.Center:
                        return -8;

                    case VerticalPosition.Bottom:
                        return -12;

                    case VerticalPosition.Inside:
                        return -16;

                    case VerticalPosition.Outside:
                        return -20;
                }
            }
            else if (base.BaseFormat is Class14)
            {
                return (base.BaseFormat as Class14).method_68();
            }
        }
        return (short) base[4];
    }

    internal void method_69(short A_0)
    {
        base[4] = A_0;
    }

    internal short method_70()
    {
        if ((((this.method_68() != -4) && (this.method_68() != -8)) && ((this.method_68() != -12) && (this.method_68() != -16))) && (this.method_68() != -20))
        {
            return (short) (this.method_68() - 1);
        }
        return -1;
    }

    internal bool method_71()
    {
        return (bool) base[5];
    }

    internal void method_72(bool A_0)
    {
        base[5] = A_0;
    }

    internal bool method_73()
    {
        return base.method_6(8);
    }

    internal HorizontalPosition method_74()
    {
        return (HorizontalPosition) ((short) base[8]);
    }

    internal void method_75(HorizontalPosition A_0)
    {
        base[8] = (short) A_0;
    }

    internal bool method_76()
    {
        return base.method_6(15);
    }

    internal VerticalPosition method_77()
    {
        return (VerticalPosition) ((short) base[15]);
    }

    internal void method_78(VerticalPosition A_0)
    {
        base[15] = (short) A_0;
    }

    internal TextDirection method_79()
    {
        return (TextDirection) base[14];
    }

    internal bool method_80()
    {
        return (bool) base[5];
    }

    internal FrameHorzAnchor method_81()
    {
        return (FrameHorzAnchor) base[11];
    }

    internal void method_82(FrameHorzAnchor A_0)
    {
        base[11] = A_0;
    }

    internal bool method_83()
    {
        return base.method_6(11);
    }

    internal FrameVertAnchor method_84()
    {
        return (FrameVertAnchor) base[12];
    }

    internal void method_85(FrameVertAnchor A_0)
    {
        base[12] = A_0;
    }

    internal bool method_86()
    {
        return base.method_6(12);
    }

    internal short method_87()
    {
        return (short) base[0x11];
    }

    internal void method_88(short A_0)
    {
        base[0x11] = A_0;
    }

    internal FrameSizeRule method_89()
    {
        if (this.method_87() == 0)
        {
            return FrameSizeRule.Auto;
        }
        return FrameSizeRule.Exact;
    }

    internal void method_90(FrameSizeRule A_0)
    {
        if (A_0 == FrameSizeRule.Auto)
        {
            this.method_88(0);
        }
    }

    internal float method_91()
    {
        if (this.method_87() != 0)
        {
            return (((float) this.method_87()) / 20f);
        }
        return 0f;
    }

    internal short method_92()
    {
        return (short) base[6];
    }

    internal void method_93(short A_0)
    {
        base[6] = A_0;
    }

    internal float method_94()
    {
        if (this.method_92() != 0)
        {
            return (((float) (((ushort) this.method_92()) & 0x7fff)) / 20f);
        }
        return 0f;
    }

    internal FrameSizeRule method_95()
    {
        if (this.HasValue(7) || !this.HasValue(6))
        {
            return (FrameSizeRule) base[7];
        }
        if (this.method_92() == 0)
        {
            return FrameSizeRule.Auto;
        }
        return FrameSizeRule.AtLeast;
    }

    internal void method_96(FrameSizeRule A_0)
    {
        switch (A_0)
        {
            case FrameSizeRule.Auto:
                this.method_93(0);
                break;

            case FrameSizeRule.AtLeast:
            {
                short num2 = this.method_92();
                if (num2 > 0)
                {
                    this.method_93((short) (num2 ^ 0x8000));
                }
                break;
            }
            case FrameSizeRule.Exact:
            {
                short num = this.method_92();
                if (num < 0)
                {
                    this.method_93((short) (((ushort) num) & 0x7fff));
                }
                break;
            }
        }
        base[7] = A_0;
    }

    internal short method_97()
    {
        return (short) base[9];
    }

    internal void method_98(short A_0)
    {
        base[9] = A_0;
    }

    internal float method_99()
    {
        return (((float) this.method_97()) / 20f);
    }

    bool AttrCollection.HasValue(int A_0)
    {
        return base.HasValue(A_0);
    }

    void FormatBase.CopyPropertiesTo(FormatBase A_0)
    {
        Class14 class2 = A_0 as Class14;
        if (base.HasKey(5))
        {
            class2.method_72(this.method_71());
        }
        if (base.HasKey(6))
        {
            class2.method_93(this.method_92());
        }
        if (base.HasKey(7))
        {
            class2.method_96(this.method_95());
        }
        if (base.HasKey(9))
        {
            class2.method_98(this.method_97());
        }
        if (base.HasKey(8))
        {
            class2.method_75(this.method_74());
        }
        if (base.HasKey(11))
        {
            class2.method_82(this.method_81());
        }
        if (base.HasKey(12))
        {
            class2.method_85(this.method_84());
        }
        if (base.HasKey(13))
        {
            class2.method_106(this.method_105());
        }
        if (base.HasKey(0x10))
        {
            class2.method_101(this.method_100());
        }
        if (base.HasKey(15))
        {
            class2.method_78(this.method_77());
        }
        if (base.HasKey(0x11))
        {
            class2.method_88(this.method_87());
        }
        if (base.HasKey(0x12))
        {
            class2.method_104(this.method_103());
        }
        if (base.HasKey(3))
        {
            class2.method_64(this.method_63());
        }
        if (base.HasKey(4))
        {
            class2.method_69(this.method_68());
        }
        if (base.HasKey(14))
        {
            class2[14] = this.method_79();
        }
        if (base.HasKey(0x15))
        {
            class2.method_111(this.method_110());
        }
        if (base.HasKey(20))
        {
            class2.method_109(this.method_108());
        }
    }

    object FormatBase.GetDefValue(int A_0)
    {
        switch (A_0)
        {
            case 3:
            case 4:
            case 6:
            case 8:
            case 9:
            case 15:
            case 0x10:
            case 0x11:
                return (short) 0;

            case 5:
            case 0x13:
                return false;

            case 7:
                return FrameSizeRule.Auto;

            case 11:
                return FrameHorzAnchor.Margin;

            case 12:
                return FrameVertAnchor.Margin;

            case 14:
                return TextDirection.TopToBottom;

            case 0x12:
                return FrameTextWrap.None;

            case 20:
                return DropCapPosition.None;

            case 0x15:
                return 0;
        }
        return null;
    }
}

