using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.ComponentModel;
using System.Drawing;

internal class Class678 : Interface62
{
    private Color color_0;
    private Color color_1;
    private int int_0;
    private Interface69 interface69_0;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private TextureStyle textureStyle_0;

    internal Class678()
    {
        this.method_0();
    }

    internal Class678(Interface69 A_0, int A_1)
    {
        this.interface69_0 = A_0;
        this.int_0 = A_1;
    }

    bool Interface62.imethod_0()
    {
        return this.method_4();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    Interface62 Interface62.imethod_1()
    {
        int num = 10;
        if (this.method_4())
        {
            throw new InvalidOperationException(BookmarkStart.b("猯匱娳堵圷丹᰻崽ⰿⵁ⩃⍅桇⭉≋湍㥏㱑㱓㍕⩗㍙⡛㭝џ䉡գብᱧᡩի౭կٱᅳ塵", num));
        }
        return (Class678) base.MemberwiseClone();
    }

    public void method_0()
    {
        smethod_0(new object[] { this.interface69_0 != null, PrId.Parent, this.interface69_0 });
        this.interface69_0 = null;
        smethod_0(new object[] { this.textureStyle_0 != TextureStyle.TextureNone, PrId.Texture, this.textureStyle_0 });
        this.textureStyle_0 = TextureStyle.TextureNone;
        smethod_0(new object[] { !this.color_0.IsEmpty, PrId.ForegroundPatternColor, this.color_0 });
        this.color_0 = Color.Empty;
        smethod_0(new object[] { !this.color_1.IsEmpty, PrId.BackgroundPatternColor, this.color_1 });
        this.color_1 = Color.Empty;
        this.string_0 = null;
        this.string_1 = null;
        this.string_2 = null;
        this.string_3 = null;
        this.string_4 = null;
        this.string_5 = null;
    }

    internal bool method_1(Class678 A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        return (object.ReferenceEquals(this, A_0) || (((((this.method_13() == A_0.method_13()) && (this.method_11() == A_0.method_11())) && ((this.method_7() == A_0.method_7()) && (this.method_15() == A_0.method_15()))) && (((this.method_17() == A_0.method_17()) && (this.method_19() == A_0.method_19())) && ((this.method_21() == A_0.method_21()) && (this.method_23() == A_0.method_23())))) && (this.method_25() == A_0.method_25())));
    }

    public void method_10(Color A_0)
    {
        this.method_12(A_0);
    }

    internal Color method_11()
    {
        if (!this.method_4())
        {
            return this.color_0;
        }
        return this.method_29().method_11();
    }

    internal void method_12(Color A_0)
    {
        this.method_2();
        smethod_0(new object[] { this.color_0 != A_0, PrId.ForegroundPatternColor, this.color_0 });
        this.color_0 = A_0;
    }

    public TextureStyle method_13()
    {
        if (!this.method_4())
        {
            return this.textureStyle_0;
        }
        return this.method_29().method_13();
    }

    public void method_14(TextureStyle A_0)
    {
        this.method_2();
        smethod_0(new object[] { this.textureStyle_0 != A_0, PrId.Texture, this.textureStyle_0 });
        this.textureStyle_0 = A_0;
    }

    internal string method_15()
    {
        return this.string_0;
    }

    internal void method_16(string A_0)
    {
        this.string_0 = A_0;
    }

    internal string method_17()
    {
        return this.string_1;
    }

    internal void method_18(string A_0)
    {
        this.string_1 = A_0;
    }

    internal string method_19()
    {
        return this.string_2;
    }

    private void method_2()
    {
        if (this.method_4())
        {
            this.method_3(this.method_29());
            smethod_0(new object[] { this.interface69_0 != null, PrId.Parent, this.interface69_0 });
            this.interface69_0 = null;
        }
    }

    internal void method_20(string A_0)
    {
        this.string_2 = A_0;
    }

    internal string method_21()
    {
        return this.string_3;
    }

    internal void method_22(string A_0)
    {
        this.string_3 = A_0;
    }

    internal string method_23()
    {
        return this.string_4;
    }

    internal void method_24(string A_0)
    {
        this.string_4 = A_0;
    }

    internal string method_25()
    {
        return this.string_5;
    }

    internal void method_26(string A_0)
    {
        this.string_5 = A_0;
    }

    internal bool method_27()
    {
        return (((this.method_13() != TextureStyle.TextureNone) && (this.method_13() != TextureStyle.TextureNil)) || !this.method_7().IsEmpty);
    }

    internal Class678 method_28()
    {
        int num = 6;
        if (this.method_4())
        {
            throw new InvalidOperationException(BookmarkStart.b("漫伭帯就嬳䈵ᠷ夹倻儽⸿❁摃❅♇橉╋⁍㡏㝑♓㽕ⱗ㽙㡛繝şᙡၣᑥŧࡩᥫᩭᕯ山", num));
        }
        return (Class678) base.MemberwiseClone();
    }

    private Class678 method_29()
    {
        return (Class678) this.interface69_0.imethod_0(this.int_0);
    }

    private void method_3(Class678 A_0)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唥娧䤩", num));
        }
        this.interface69_0 = A_0.interface69_0;
        smethod_0(new object[] { this.int_0 != A_0.int_0, PrId.Key, this.int_0 });
        this.int_0 = A_0.int_0;
        smethod_0(new object[] { this.textureStyle_0 != A_0.method_13(), PrId.Texture, this.textureStyle_0 });
        this.textureStyle_0 = A_0.method_13();
        smethod_0(new object[] { this.color_0 != A_0.method_11(), PrId.ForegroundPatternColor, this.color_0 });
        this.color_0 = A_0.method_11();
        smethod_0(new object[] { this.color_1 != A_0.method_7(), PrId.BackgroundPatternColor, this.color_1 });
        this.color_1 = A_0.method_7();
        this.string_0 = A_0.method_15();
        this.string_1 = A_0.method_17();
        this.string_2 = A_0.method_19();
        this.string_3 = A_0.method_21();
        this.string_4 = A_0.method_23();
        this.string_5 = A_0.method_25();
    }

    internal bool method_4()
    {
        return (this.interface69_0 != null);
    }

    public Color method_5()
    {
        return this.method_7();
    }

    public void method_6(Color A_0)
    {
        this.method_8(A_0);
    }

    internal Color method_7()
    {
        if (!this.method_4())
        {
            return this.color_1;
        }
        return this.method_29().method_7();
    }

    internal void method_8(Color A_0)
    {
        this.method_2();
        smethod_0(new object[] { this.color_1 != A_0, PrId.BackgroundPatternColor, this.color_1 });
        this.color_1 = A_0;
    }

    public Color method_9()
    {
        return this.method_11();
    }

    internal static void smethod_0(params object[] A_0)
    {
    }

    bool object.Equals(object A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        if (object.ReferenceEquals(this, A_0))
        {
            return true;
        }
        if (A_0.GetType() != typeof(Class678))
        {
            return false;
        }
        return this.method_1((Class678) A_0);
    }

    int object.GetHashCode()
    {
        int num = ((int) (this.textureStyle_0 * ((TextureStyle) 0x18d))) ^ this.color_0.GetHashCode();
        num = (num * 0x18d) ^ this.color_1.GetHashCode();
        num = (num * 0x18d) ^ ((this.string_0 != null) ? this.string_0.GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.string_1 != null) ? this.string_1.GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.string_2 != null) ? this.string_2.GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.string_3 != null) ? this.string_3.GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.string_4 != null) ? this.string_4.GetHashCode() : 0);
        return ((num * 0x18d) ^ ((this.string_5 != null) ? this.string_5.GetHashCode() : 0));
    }
}

