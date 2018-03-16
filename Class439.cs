using Spire.CompoundFile.Doc;
using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using System;
using System.Runtime.InteropServices;

internal class Class439 : ICloneable, IDocProperty
{
    private bool bool_0;
    private BuiltInProperty builtInProperty_0;
    private const int int_0 = 0x3e8;
    public const int int_1 = 0x640;
    private object object_0;
    private PropertyType propertyType_0;
    private string string_0;
    private string string_1;

    private Class439()
    {
    }

    public Class439(Interface37 A_0, bool A_1)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("丷嬹主圽ℿⱁぃ", num));
        }
        this.string_0 = A_0.imethod_2();
        if (this.string_0 == null)
        {
            if (A_1)
            {
                this.builtInProperty_0 = (BuiltInProperty) A_0.imethod_3();
            }
            else
            {
                this.builtInProperty_0 = (BuiltInProperty) ((A_0.imethod_3() + 0x3e8) - 2);
            }
        }
        this.object_0 = A_0.imethod_0();
        this.propertyType_0 = (PropertyType) A_0.imethod_1();
    }

    public Class439(BuiltInProperty A_0, object A_1)
    {
        this.builtInProperty_0 = A_0;
        this.object_0 = A_1;
    }

    public Class439(string A_0, object A_1)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌯䘱䘳砵夷圹夻", num));
        }
        if (A_0.Length == 0)
        {
            throw new ArgumentException(BookmarkStart.b("䌯䘱䘳砵夷圹夻ḽ洿扁㝃㉅㩇⍉≋⥍灏ㅑ㕓㡕㙗㕙⡛繝ɟݡ䑣ͥէᩩᡫ᝭幯", num));
        }
        this.string_0 = A_0;
        this.Spire.CompoundFile.Doc.IDocProperty.set_Value(A_1);
    }

    public void method_0(BuiltInProperty A_0)
    {
        this.builtInProperty_0 = A_0;
    }

    public byte[] method_1()
    {
        int num = 8;
        if (this.propertyType_0 != PropertyType.Blob)
        {
            throw new InvalidCastException(BookmarkStart.b("洭儯就ጳ䈵ᠷ夹医倽㘿❁㙃㉅桇㱉ⵋ≍╏㝑瑓≕㝗穙ṛ㉝ཟa䩣", num));
        }
        return (byte[]) this.object_0;
    }

    public void method_10(PropertyType A_0)
    {
        this.propertyType_0 = A_0;
    }

    public string method_11()
    {
        return this.string_0;
    }

    public bool method_12(Interface37 A_0, int A_1)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("丷嬹主圽ℿⱁぃ", num));
        }
        if (this.object_0 == null)
        {
            return false;
        }
        if (this.Spire.CompoundFile.Doc.IDocProperty.get_IsBuiltIn())
        {
            bool flag;
            int num2 = smethod_0(this.builtInProperty_0, out flag);
            A_0.imethod_4(num2);
        }
        else
        {
            A_0.imethod_4(A_1);
        }
        return A_0.imethod_5(this.object_0, this.propertyType_0);
    }

    private void method_13()
    {
        if (this.object_0 is string)
        {
            this.propertyType_0 = PropertyType.String;
        }
        else if (this.object_0 is double)
        {
            this.propertyType_0 = PropertyType.Double;
        }
        else if (this.object_0 is int)
        {
            this.propertyType_0 = PropertyType.Int;
        }
        else if (this.object_0 is bool)
        {
            this.propertyType_0 = PropertyType.Bool;
        }
        else if (this.object_0 is DateTime)
        {
            this.propertyType_0 = PropertyType.DateTime;
        }
        else if (this.object_0 is object[])
        {
            this.propertyType_0 = PropertyType.ObjectArray;
        }
        else if (this.object_0 is string[])
        {
            this.propertyType_0 = PropertyType.StringArray;
        }
        else if (this.object_0 is byte[])
        {
            this.propertyType_0 = PropertyType.Blob;
        }
        else if (this.object_0 is ClipboardData)
        {
            this.propertyType_0 = PropertyType.ClipboardData;
        }
    }

    public void method_14(Interface37 A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐱唳䐵儷嬹刻䨽", num));
        }
        if ((A_0.imethod_1() != VarEnum.VT_LPSTR) && (A_0.imethod_1() != VarEnum.VT_LPWSTR))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("縱崳堵匷椹医䬽㈿⅁⅃", num));
        }
        this.Spire.CompoundFile.Doc.IDocProperty.set_LinkSource(A_0.imethod_0().ToString());
    }

    [CLSCompliant(false)]
    public void method_15(Interface43 A_0, Class358 A_1, int A_2)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嬧帩䌫尭怯䀱嬳䘵", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("帧䬩師䜭儯就䀳", num));
        }
        this.method_12(A_1, A_2);
        A_1.method_39(A_0);
        if (!this.Spire.CompoundFile.Doc.IDocProperty.get_IsBuiltIn())
        {
            uint num2 = (uint) A_2;
            A_0.imethod_4(1, ref num2, ref this.string_0);
        }
        if (this.Spire.CompoundFile.Doc.IDocProperty.get_LinkToContent())
        {
            A_1.method_7((PIDSI) (A_2 + 0x1000000));
            A_1.method_15(this.string_1);
            A_1.method_39(A_0);
        }
    }

    private void method_16()
    {
        if (this.object_0 != null)
        {
            PropertyType type = this.propertyType_0;
            switch (type)
            {
                case PropertyType.Blob:
                    this.object_0 = Class665.smethod_6(this.method_1());
                    return;

                case PropertyType.ObjectArray:
                    this.object_0 = Class665.smethod_3(this.method_7());
                    return;
            }
            if (type == PropertyType.StringArray)
            {
                this.object_0 = Class665.smethod_2(this.method_5());
            }
        }
    }

    public void method_2(byte[] A_0)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌴嘶唸为堼", num));
        }
        this.propertyType_0 = PropertyType.Blob;
        this.object_0 = A_0;
    }

    public ClipboardData method_3()
    {
        int num = 3;
        if (this.propertyType_0 != PropertyType.ClipboardData)
        {
            throw new InvalidCastException(BookmarkStart.b("樨䨪䌬࠮䔰ጲ嘴堶圸䴺堼䴾㕀捂㍄♆╈㹊⡌潎═㱒畔ᑖ㕘㉚ⵜ㵞๠ɢᝤͦ⵨੪ᥬ๮彰", num));
        }
        return (ClipboardData) this.object_0;
    }

    public void method_4(ClipboardData A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐱唳娵䴷弹", num));
        }
        this.propertyType_0 = PropertyType.ClipboardData;
        this.object_0 = A_0;
    }

    public string[] method_5()
    {
        int num = 0x11;
        if (this.propertyType_0 != PropertyType.StringArray)
        {
            throw new InvalidCastException(BookmarkStart.b("琶堸唺ᨼ䬾慀⁂⩄⥆㽈⹊㽌㭎煐╒㑔㭖ⱘ㹚絜⭞๠䍢Ѥ०䥨੪Ὤᵮၰੲ啴ᡶὸ孺๼୾愈ꖊ", num));
        }
        return (string[]) this.object_0;
    }

    public void method_6(string[] A_0)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嬬丮崰䘲倴", num));
        }
        this.propertyType_0 = PropertyType.StringArray;
        this.object_0 = A_0;
    }

    public object[] method_7()
    {
        int num = 11;
        if (this.propertyType_0 != PropertyType.ObjectArray)
        {
            throw new InvalidCastException(BookmarkStart.b("爰刲嬴ံ䴸ᬺ帼倾⽀㕂⁄㕆㵈歊㭌⹎㵐♒ご睖ⵘ㑚絜㹞འ䍢Ѥᕦ᭨੪ᑬ佮Ṱᕲ啴Ѷ൸ॺᑼᅾꮄ", num));
        }
        return (object[]) this.object_0;
    }

    public void method_8(object[] A_0)
    {
        int num = 0x13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伸娺儼䨾⑀", num));
        }
        this.propertyType_0 = PropertyType.ObjectArray;
        this.object_0 = A_0;
    }

    public PropertyType method_9()
    {
        return this.propertyType_0;
    }

    public static int smethod_0(BuiltInProperty A_0, out bool A_1)
    {
        int num = (int) A_0;
        if (num >= 0x3e8)
        {
            num -= 0x3e6;
            A_1 = false;
            return num;
        }
        A_1 = true;
        return num;
    }

    object ICloneable.Clone()
    {
        Class439 class2 = (Class439) base.MemberwiseClone();
        class2.method_16();
        return class2;
    }

    bool IDocProperty.Boolean
    {
        get
        {
            int num = 10;
            if (this.propertyType_0 != PropertyType.Bool)
            {
                throw new InvalidCastException(BookmarkStart.b("猯匱娳ᄵ䰷ᨹ弻儽⸿㑁⅃㑅㱇橉㩋⽍㱏❑ㅓ癕ⱗ㕙籛㱝ཟൡࡣͥ१ѩ䉫", num));
            }
            return Convert.ToBoolean(this.object_0);
        }
        set
        {
            this.propertyType_0 = PropertyType.Bool;
            this.object_0 = value;
        }
    }

    DateTime IDocProperty.DateTime
    {
        get
        {
            int num = 12;
            if (this.propertyType_0 != PropertyType.DateTime)
            {
                throw new InvalidCastException(BookmarkStart.b("焱唳堵ἷ丹᰻崽⼿ⱁ㉃⍅㩇㹉汋㡍ㅏ㹑⅓㍕硗⹙㍛繝⑟͡ၣͥ㱧ͩū୭幯", num));
            }
            return Convert.ToDateTime(this.object_0);
        }
        set
        {
            this.propertyType_0 = PropertyType.DateTime;
            this.object_0 = value;
        }
    }

    double IDocProperty.Double
    {
        get
        {
            int num = 13;
            if (this.propertyType_0 != PropertyType.Double)
            {
                throw new InvalidCastException(BookmarkStart.b("瀲吴夶Ḹ伺ᴼ尾⹀ⵂ㍄≆㭈㽊浌㥎ぐ㽒⁔㉖祘⽚㉜罞ࡠൢᅤɦ๨๪Ὤ䅮", num));
            }
            return Convert.ToDouble(this.object_0);
        }
        set
        {
            this.propertyType_0 = PropertyType.Double;
            this.object_0 = value;
        }
    }

    int IDocProperty.Int32
    {
        get
        {
            int num = 7;
            if (this.propertyType_0 != PropertyType.Int32)
            {
                throw new InvalidCastException(BookmarkStart.b("測丮弰ᐲ䄴᜶娸吺匼䤾⑀ㅂㅄ杆㽈⩊⅌㩎㑐獒⅔㡖祘㉚㍜⭞ѠѢdᕦ䝨", num));
            }
            return Convert.ToInt32(this.object_0);
        }
        set
        {
            this.propertyType_0 = PropertyType.Int32;
            this.object_0 = value;
        }
    }

    int IDocProperty.Integer
    {
        get
        {
            int num = 7;
            if (this.propertyType_0 != PropertyType.Int)
            {
                throw new InvalidCastException(BookmarkStart.b("測丮弰ᐲ䄴᜶娸吺匼䤾⑀ㅂㅄ杆㽈⩊⅌㩎㑐獒⅔㡖祘㉚㍜⭞ѠѢdᕦ䝨", num));
            }
            return Convert.ToInt32(this.object_0);
        }
        set
        {
            this.propertyType_0 = PropertyType.Int;
            this.object_0 = value;
        }
    }

    bool IDocProperty.IsBuiltIn
    {
        get
        {
            return (this.string_0 == null);
        }
    }

    string IDocProperty.LinkSource
    {
        get
        {
            return this.string_1;
        }
        set
        {
            int num = 7;
            if (this.Spire.CompoundFile.Doc.IDocProperty.get_IsBuiltIn())
            {
                throw new InvalidOperationException(BookmarkStart.b("礬䜮堰䀲ᔴ堶䤸帺似帾㕀⩂⩄⥆楈⡊ⱌⅎ癐❒畔㕖㱘筚ⵜ㩞፠բ੤ᕦѨ๪६佮Ṱᵲ啴ᕶ౸ቺᅼ୾검Ꞇ麗力ﾎ래", num));
            }
            this.string_1 = value;
            this.bool_0 = true;
        }
    }

    bool IDocProperty.LinkToContent
    {
        get
        {
            return this.bool_0;
        }
        set
        {
            this.bool_0 = value;
        }
    }

    string IDocProperty.Name
    {
        get
        {
            if (this.string_0 != null)
            {
                return this.string_0;
            }
            return this.builtInProperty_0.ToString();
        }
    }

    BuiltInProperty IDocProperty.PropertyId
    {
        get
        {
            return this.builtInProperty_0;
        }
    }

    string IDocProperty.Text
    {
        get
        {
            int num = 1;
            if (this.propertyType_0 != PropertyType.String)
            {
                throw new InvalidCastException(BookmarkStart.b("搦䠨䔪ਬ嬮ᄰ倲娴夶伸帺似䬾慀㕂⑄⭆㱈⹊浌㭎㹐獒♔⍖⭘㉚㍜㡞你", num));
            }
            return Convert.ToString(this.object_0);
        }
        set
        {
            this.propertyType_0 = PropertyType.String;
            this.object_0 = value;
        }
    }

    TimeSpan IDocProperty.TimeSpan
    {
        get
        {
            return new TimeSpan(this.Spire.CompoundFile.Doc.IDocProperty.get_DateTime().AddYears(-1600).Ticks);
        }
        set
        {
            DateTime time = new DateTime(value.Ticks);
            time = time.AddYears(0x640);
            this.Spire.CompoundFile.Doc.IDocProperty.set_DateTime(time);
        }
    }

    object IDocProperty.Value
    {
        get
        {
            return this.object_0;
        }
        set
        {
            this.object_0 = value;
            this.method_13();
        }
    }
}

