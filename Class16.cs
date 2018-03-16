using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;

internal class Class16 : WordAttrCollection, Interface31
{
    private int int_8;
    internal const short short_0 = 1;
    internal const short short_1 = 2;
    internal const short short_2 = 3;
    internal const short short_3 = 4;
    internal const short short_4 = 5;
    internal const short short_5 = 6;
    internal const short short_6 = 7;
    internal const short short_7 = 8;
    internal const short short_8 = 9;

    internal Class16()
    {
        this.method_49();
    }

    internal Class16(FormatBase A_0, int A_1) : base(A_0, A_1)
    {
    }

    bool Interface31.imethod_0()
    {
        return this.method_53();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    Interface31 Interface31.imethod_1()
    {
        int num = 0x10;
        if (this.method_53())
        {
            throw new InvalidOperationException(BookmarkStart.b("电夷吹刻儽㐿扁❃⩅❇⑉⥋湍ㅏ㱑瑓㽕㙗㉙㥛ⱝय़ᙡţɥ䡧୩ᡫᩭɯ᭱ᙳ͵౷ό剻", num));
        }
        return (Class16) base.MemberwiseClone();
    }

    public void method_49()
    {
        smethod_5(new object[] { this.method_62() != TextureStyle.TextureNone, PrId.Texture, this.method_62() });
        this.method_63(TextureStyle.TextureNone);
        smethod_5(new object[] { !this.method_58().IsEmpty, PrId.ForegroundPatternColor, this.method_58() });
        this.method_59(Color.Empty);
        smethod_5(new object[] { !this.method_54().IsEmpty, PrId.BackgroundPatternColor, this.method_54() });
        this.method_55(Color.Empty);
        this.method_65(null);
        this.method_67(null);
        this.method_69(null);
        this.method_71(null);
        this.method_73(null);
        this.method_75(null);
    }

    internal bool method_50(Class16 A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        return (object.ReferenceEquals(this, A_0) || (((((this.method_62() == A_0.method_62()) && (this.method_60() == A_0.method_60())) && ((this.method_56() == A_0.method_56()) && (this.method_64() == A_0.method_64()))) && (((this.method_66() == A_0.method_66()) && (this.method_68() == A_0.method_68())) && ((this.method_70() == A_0.method_70()) && (this.method_72() == A_0.method_72())))) && (this.method_74() == A_0.method_74())));
    }

    private void method_51()
    {
        this.method_53();
    }

    private void method_52(Class16 A_0)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䘴䔶娸", num));
        }
        this.int_8 = A_0.int_8;
        if (base.HasKey(1))
        {
            this.method_63(A_0.method_62());
        }
        if (base.HasKey(2))
        {
            this.method_59(A_0.method_60());
        }
        if (base.HasKey(3))
        {
            this.method_55(A_0.method_56());
        }
        if (base.HasKey(4))
        {
            this.method_65(A_0.method_64());
        }
        if (base.HasKey(5))
        {
            this.method_67(A_0.method_66());
        }
        if (base.HasKey(6))
        {
            this.method_69(A_0.method_68());
        }
        if (base.HasKey(7))
        {
            this.method_71(A_0.method_70());
        }
        if (base.HasKey(8))
        {
            this.method_73(A_0.method_72());
        }
        if (base.HasKey(9))
        {
            this.method_75(A_0.method_74());
        }
    }

    internal bool method_53()
    {
        return true;
    }

    public Color method_54()
    {
        return this.method_56();
    }

    public void method_55(Color A_0)
    {
        this.method_57(A_0);
    }

    internal Color method_56()
    {
        return (Color) base[3];
    }

    internal void method_57(Color A_0)
    {
        this.method_51();
        smethod_5(new object[] { ((Color) base[3]) != A_0, PrId.BackgroundPatternColor, (Color) base[3] });
        base[3] = A_0;
    }

    public Color method_58()
    {
        return this.method_60();
    }

    public void method_59(Color A_0)
    {
        this.method_61(A_0);
    }

    internal Color method_60()
    {
        return (Color) base[2];
    }

    internal void method_61(Color A_0)
    {
        this.method_51();
        smethod_5(new object[] { ((Color) base[2]) != A_0, PrId.ForegroundPatternColor, (Color) base[2] });
        base[2] = A_0;
    }

    public TextureStyle method_62()
    {
        return (TextureStyle) base[1];
    }

    public void method_63(TextureStyle A_0)
    {
        this.method_51();
        smethod_5(new object[] { ((TextureStyle) base[1]) != A_0, PrId.Texture, (TextureStyle) base[1] });
        base[1] = A_0;
    }

    internal string method_64()
    {
        return (string) base[4];
    }

    internal void method_65(string A_0)
    {
        base[4] = A_0;
    }

    internal string method_66()
    {
        return (string) base[5];
    }

    internal void method_67(string A_0)
    {
        base[5] = A_0;
    }

    internal string method_68()
    {
        return (string) base[6];
    }

    internal void method_69(string A_0)
    {
        base[6] = A_0;
    }

    internal string method_70()
    {
        return (string) base[7];
    }

    internal void method_71(string A_0)
    {
        base[7] = A_0;
    }

    internal string method_72()
    {
        return (string) base[8];
    }

    internal void method_73(string A_0)
    {
        base[8] = A_0;
    }

    internal string method_74()
    {
        return (string) base[9];
    }

    internal void method_75(string A_0)
    {
        base[9] = A_0;
    }

    internal bool method_76()
    {
        return (((this.method_62() != TextureStyle.TextureNone) && (this.method_62() != TextureStyle.TextureNil)) || !this.method_56().IsEmpty);
    }

    internal Class16 method_77()
    {
        Class16 class2 = new Class16();
        class2.method_26(this);
        return class2;
    }

    internal static void smethod_5(params object[] A_0)
    {
    }

    void FormatBase.ApplyProperty()
    {
        if (base.m_propsUpdateFlags != null)
        {
            base.m_propsUpdateFlags.Clear();
        }
        Type type = typeof(Class16);
        foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
        {
            int key = (int) info.GetValue(info.FieldType);
            if (base.PropertiesHash.ContainsKey(key))
            {
                base.method_31(key);
            }
        }
    }

    void FormatBase.CopyPropertiesTo(FormatBase A_0)
    {
        Class16 class2 = A_0 as Class16;
        if (base.HasKey(3))
        {
            class2.method_55(this.method_54());
        }
        if (base.HasKey(2))
        {
            class2.method_57(this.method_56());
        }
        if (base.HasKey(1))
        {
            class2.method_63(this.method_62());
        }
        if (base.HasKey(4))
        {
            class2.method_65(this.method_64());
        }
        if (base.HasKey(7))
        {
            class2.method_71(this.method_70());
        }
        if (base.HasKey(8))
        {
            class2.method_73(this.method_72());
        }
        if (base.HasKey(9))
        {
            class2.method_75(this.method_74());
        }
        if (base.HasKey(5))
        {
            class2.method_67(this.method_66());
        }
        if (base.HasKey(6))
        {
            class2.method_69(this.method_68());
        }
    }

    object FormatBase.GetDefValue(int A_0)
    {
        switch (A_0)
        {
            case 1:
                return TextureStyle.TextureNone;

            case 2:
                return Color.Empty;

            case 3:
                return Color.Empty;

            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return string.Empty;
        }
        throw new NotImplementedException();
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
        if (A_0.GetType() != typeof(Class16))
        {
            return false;
        }
        return this.method_50((Class16) A_0);
    }

    int object.GetHashCode()
    {
        this.method_58();
        int num = ((int) (this.method_62() * ((TextureStyle) 0x18d))) ^ this.method_58().GetHashCode();
        this.method_54();
        num = (num * 0x18d) ^ this.method_54().GetHashCode();
        num = (num * 0x18d) ^ ((this.method_64() != null) ? this.method_64().GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.method_66() != null) ? this.method_66().GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.method_68() != null) ? this.method_68().GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.method_70() != null) ? this.method_70().GetHashCode() : 0);
        num = (num * 0x18d) ^ ((this.method_72() != null) ? this.method_72().GetHashCode() : 0);
        return ((num * 0x18d) ^ ((this.method_74() != null) ? this.method_74().GetHashCode() : 0));
    }
}

