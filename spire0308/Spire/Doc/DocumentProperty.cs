namespace Spire.Doc
{
    using Spire.CompoundFile.Doc;
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    public class DocumentProperty
    {
        private bool bool_0;
        private bool[] bool_1;
        private bool bool_2;
        private BuiltInProperty builtInProperty_0;
        private const int int_0 = 0x3e8;
        private const int int_1 = 0x640;
        internal const int int_2 = 2;
        private long long_0;
        private object object_0;
        private Spire.CompoundFile.Doc.PropertyType propertyType_0;
        private string string_0;
        private string string_1;
        private string string_2;

        public DocumentProperty()
        {
        }

        internal DocumentProperty(Interface37 A_0, bool A_1)
        {
            int num = 10;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䘯匱䘳張夷吹䠻", num));
            }
            this.string_1 = A_0.imethod_2();
            if (this.string_1 == null)
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
            if ((A_1 && (this.builtInProperty_0 == BuiltInProperty.EditTime)) && (A_0.imethod_0() is System.DateTime))
            {
                System.DateTime time = (System.DateTime) A_0.imethod_0();
                this.object_0 = System.TimeSpan.FromTicks(time.Ticks - 0x701ce1722770000L);
            }
            else
            {
                this.object_0 = A_0.imethod_0();
            }
            this.propertyType_0 = (Spire.CompoundFile.Doc.PropertyType) A_0.imethod_1();
        }

        internal DocumentProperty(BuiltInProperty A_0, object A_1)
        {
            this.builtInProperty_0 = A_0;
            this.object_0 = A_1;
            this.propertyType_0 = smethod_0(A_1);
        }

        public DocumentProperty(string strName, object value)
        {
            int num = 0;
            if (strName == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("唥尧堩戫伭崯圱", num));
            }
            if (strName.Length == 0)
            {
                throw new ArgumentException(BookmarkStart.b("唥尧堩戫伭崯圱ᐳᬵᠷ䤹䠻䰽⤿ⱁ⍃晅⭇⭉≋⁍㽏♑瑓㑕㵗穙㥛㍝ၟᙡᵣ䡥", num));
            }
            this.string_1 = strName;
            this.Value = value;
            this.propertyType_0 = smethod_0(value);
        }

        public DocumentProperty(string strName, object value, Spire.CompoundFile.Doc.PropertyType type)
        {
            int num = 5;
            if (strName == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("堪夬崮缰刲場制", num));
            }
            if (strName.Length == 0)
            {
                throw new ArgumentException(BookmarkStart.b("堪夬崮缰刲場制ᤸᘺᴼ䰾㕀ㅂⱄ⥆⹈歊⹌⹎㽐㵒㩔⍖祘㥚㡜罞Ѡ๢ᕤ፦ၨ䕪", num));
            }
            this.string_1 = strName;
            this.object_0 = value;
            this.propertyType_0 = type;
        }

        public DocumentProperty Clone()
        {
            DocumentProperty property = (DocumentProperty) base.MemberwiseClone();
            property.method_6();
            return property;
        }

        private Spire.CompoundFile.Doc.PropertyType method_0(string A_0)
        {
            if (Encoding.UTF8.GetByteCount(A_0) != A_0.Length)
            {
                return Spire.CompoundFile.Doc.PropertyType.String;
            }
            return Spire.CompoundFile.Doc.PropertyType.AsciiString;
        }

        internal Class875 method_1()
        {
            return (Class875) this.object_0;
        }

        internal bool method_2(Interface37 A_0, int A_1)
        {
            int num = 4;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("尩䴫尭夯匱娳䈵", num));
            }
            if (this.object_0 == null)
            {
                return false;
            }
            if (this.IsBuiltIn)
            {
                bool flag;
                int num2 = this.method_3(this.builtInProperty_0, out flag);
                A_0.imethod_4(num2);
            }
            else
            {
                A_0.imethod_4(A_1);
            }
            object obj2 = this.object_0;
            if ((this.IsBuiltIn && (A_0.imethod_3() == 10)) && (this.object_0 is System.TimeSpan))
            {
                System.TimeSpan span = (System.TimeSpan) this.object_0;
                obj2 = System.DateTime.FromBinary(span.Ticks + 0x701ce1722770000L);
            }
            return A_0.imethod_5(obj2, this.propertyType_0);
        }

        internal int method_3(BuiltInProperty A_0, out bool A_1)
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

        private void method_4()
        {
            if (this.object_0 is string)
            {
                this.propertyType_0 = this.method_0((string) this.object_0);
            }
            else if (this.object_0 is double)
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Double;
            }
            else if (this.object_0 is int)
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Int32;
            }
            else if (this.object_0 is bool)
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Bool;
            }
            else if (this.object_0 is System.DateTime)
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.DateTime;
            }
            else if (this.object_0 is object[])
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.ObjectArray;
            }
            else if (this.object_0 is string[])
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.StringArray;
            }
            else if (this.object_0 is byte[])
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Blob;
            }
            else if (this.object_0 is Spire.CompoundFile.Doc.ClipboardData)
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.ClipboardData;
            }
        }

        internal void method_5(Interface37 A_0)
        {
            int num = 9;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("央倰䄲尴嘶圸伺", num));
            }
            if ((A_0.imethod_1() != VarEnum.VT_LPSTR) && (A_0.imethod_1() != VarEnum.VT_LPWSTR))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("挮堰崲帴搶嘸为似尾⑀", num));
            }
            this.LinkSource = A_0.imethod_0().ToString();
        }

        private void method_6()
        {
            if (this.object_0 != null)
            {
                switch (this.propertyType_0)
                {
                    case Spire.CompoundFile.Doc.PropertyType.Blob:
                        this.object_0 = Class665.smethod_6(this.Blob);
                        break;

                    case Spire.CompoundFile.Doc.PropertyType.ClipboardData:
                        this.object_0 = Class665.smethod_4(this.ClipboardData);
                        break;

                    case Spire.CompoundFile.Doc.PropertyType.ObjectArray:
                        this.object_0 = Class665.smethod_3(this.ObjectArray);
                        break;

                    case Spire.CompoundFile.Doc.PropertyType.StringArray:
                        this.object_0 = Class665.smethod_2(this.StringArray);
                        break;
                }
            }
        }

        internal static Spire.CompoundFile.Doc.PropertyType smethod_0(object A_0)
        {
            Spire.CompoundFile.Doc.PropertyType @null = Spire.CompoundFile.Doc.PropertyType.Null;
            if (A_0 is string)
            {
                return ((Encoding.UTF8.GetByteCount(A_0 as string) == (A_0 as string).Length) ? Spire.CompoundFile.Doc.PropertyType.AsciiString : Spire.CompoundFile.Doc.PropertyType.String);
            }
            if (A_0 is double)
            {
                return Spire.CompoundFile.Doc.PropertyType.Double;
            }
            if (A_0 is int)
            {
                return Spire.CompoundFile.Doc.PropertyType.Int32;
            }
            if (A_0 is bool)
            {
                return Spire.CompoundFile.Doc.PropertyType.Bool;
            }
            if ((A_0 is System.DateTime) || (A_0 is System.TimeSpan))
            {
                return Spire.CompoundFile.Doc.PropertyType.DateTime;
            }
            if (A_0 is object[])
            {
                return Spire.CompoundFile.Doc.PropertyType.ObjectArray;
            }
            if (A_0 is string[])
            {
                return Spire.CompoundFile.Doc.PropertyType.StringArray;
            }
            if (A_0 is byte[])
            {
                return Spire.CompoundFile.Doc.PropertyType.Blob;
            }
            if (A_0 is Spire.CompoundFile.Doc.ClipboardData)
            {
                @null = Spire.CompoundFile.Doc.PropertyType.ClipboardData;
            }
            return @null;
        }

        internal static PropertyValueType smethod_1(object A_0)
        {
            if (A_0 is string)
            {
                return PropertyValueType.String;
            }
            if (A_0 is bool)
            {
                return PropertyValueType.Boolean;
            }
            if (A_0 is System.DateTime)
            {
                return PropertyValueType.Date;
            }
            if ((A_0 is int) || (A_0 is uint))
            {
                return PropertyValueType.Int;
            }
            if (A_0 is double)
            {
                return PropertyValueType.Double;
            }
            if (A_0 is string[])
            {
                return PropertyValueType.StringArray;
            }
            if (A_0 is object[])
            {
                return PropertyValueType.ObjectArray;
            }
            if (A_0 is byte[])
            {
                return PropertyValueType.ByteArray;
            }
            return PropertyValueType.Other;
        }

        internal static object smethod_2(PropertyValueType A_0)
        {
            int num = 12;
            switch (A_0)
            {
                case PropertyValueType.Boolean:
                    return false;

                case PropertyValueType.Date:
                    return System.DateTime.MinValue;

                case PropertyValueType.Double:
                    return 0.0;

                case PropertyValueType.Int:
                    return 0;

                case PropertyValueType.String:
                    return string.Empty;

                case PropertyValueType.ByteArray:
                    return Class85.byte_0;

                case PropertyValueType.StringArray:
                    return new string[0];

                case PropertyValueType.ObjectArray:
                    return new object[0];

                case PropertyValueType.Other:
                    return null;
            }
            throw new InvalidOperationException(BookmarkStart.b("朱娳崵嘷唹䬻倽怿㉁㙃⥅㡇⽉㹋㩍⥏牑⁓⽕⡗㽙牛", num));
        }

        public bool ToBool()
        {
            return (bool) this.object_0;
        }

        public byte[] ToByteArray()
        {
            return (byte[]) this.object_0;
        }

        public System.DateTime ToDateTime()
        {
            System.DateTime time = (System.DateTime) this.object_0;
            return time.Date;
        }

        public double ToDouble()
        {
            return (double) this.object_0;
        }

        public float ToFloat()
        {
            return Convert.ToSingle(this.object_0);
        }

        public int ToInt()
        {
            return (int) this.object_0;
        }

        public override string ToString()
        {
            return Convert.ToString(this.object_0);
        }

        internal byte[] Blob
        {
            get
            {
                int num = 12;
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.Blob)
                {
                    throw new InvalidCastException(BookmarkStart.b("焱唳堵ἷ丹᰻崽⼿ⱁ㉃⍅㩇㹉汋㡍ㅏ㹑⅓㍕硗⹙㍛繝≟๡ୣѥ䙧", num));
                }
                return (byte[]) this.object_0;
            }
            set
            {
                int num = 15;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("䌴嘶唸为堼", num));
                }
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Blob;
                this.object_0 = value;
            }
        }

        internal bool Boolean
        {
            get
            {
                int num = 5;
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.Bool)
                {
                    throw new InvalidCastException(BookmarkStart.b("株䰬䄮ᘰ䜲ᔴ吶嘸唺䬼娾㍀㝂敄ㅆ⡈❊㡌⩎煐❒㩔睖㭘㑚㉜㍞Ѡɢ୤䥦", num));
                }
                return Convert.ToBoolean(this.object_0);
            }
            set
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Bool;
                this.object_0 = value;
            }
        }

        public Spire.CompoundFile.Doc.ClipboardData ClipboardData
        {
            get
            {
                int num = 1;
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.ClipboardData)
                {
                    throw new InvalidCastException(BookmarkStart.b("搦䠨䔪ਬ嬮ᄰ倲娴夶伸帺似䬾慀㕂⑄⭆㱈⹊浌㭎㹐獒ᙔ㭖じ⭚㽜ぞ`ᅢŤ⍦ࡨὪ౬䅮", num));
                }
                return (Spire.CompoundFile.Doc.ClipboardData) this.object_0;
            }
            set
            {
                int num = 2;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("帧䬩䀫嬭唯", num));
                }
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.ClipboardData;
                this.object_0 = value;
            }
        }

        internal System.DateTime DateTime
        {
            get
            {
                try
                {
                    this.method_4();
                    if (this.propertyType_0 == Spire.CompoundFile.Doc.PropertyType.DateTime)
                    {
                        return Convert.ToDateTime(this.object_0);
                    }
                    return System.DateTime.MinValue;
                }
                catch
                {
                    return System.DateTime.MinValue;
                }
            }
            set
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.DateTime;
                this.object_0 = value;
            }
        }

        internal double Double
        {
            get
            {
                int num = 0x10;
                this.method_4();
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.Double)
                {
                    throw new InvalidCastException(BookmarkStart.b("电夷吹ᬻ䨽怿⅁⭃⡅㹇⽉㹋㩍灏⑑㕓㩕ⵗ㽙籛⩝ཟ䉡ൣࡥᱧཀྵ୫୭ɯ山", num));
                }
                return Convert.ToDouble(this.object_0);
            }
            set
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Double;
                this.object_0 = value;
            }
        }

        internal int Int32
        {
            get
            {
                int num = 9;
                this.method_4();
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.Int32)
                {
                    throw new InvalidCastException(BookmarkStart.b("氮倰崲ሴ䌶ᤸ堺刼儾㝀♂㝄㍆楈㵊ⱌ⍎⑐㙒畔⍖㙘筚㑜ㅞᕠ٢ɤɦ᭨䕪", num));
                }
                return Convert.ToInt32(this.object_0);
            }
            set
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Int32;
                this.object_0 = value;
            }
        }

        internal int Integer
        {
            get
            {
                int num = 0x13;
                this.method_4();
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.Int)
                {
                    throw new InvalidCastException(BookmarkStart.b("稸娺匼ᠾ㕀捂♄⡆❈㵊⡌㵎═獒⍔㙖㕘⹚㡜罞ᕠౢ䕤๦ݨὪ࡬࡮ᑰŲ孴", num));
                }
                return int.Parse(this.object_0.ToString());
            }
            set
            {
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.Int;
                this.object_0 = value;
            }
        }

        internal string InternalName
        {
            get
            {
                return this.string_1;
            }
        }

        internal bool IsBuiltIn
        {
            get
            {
                return (this.string_1 == null);
            }
        }

        internal string LinkSource
        {
            get
            {
                return this.string_2;
            }
            set
            {
                int num = 3;
                if (this.IsBuiltIn)
                {
                    throw new InvalidOperationException(BookmarkStart.b("紨䌪䐬尮ᄰ尲䔴制䬸娺䤼嘾⹀ⵂ敄⑆⡈╊橌㭎煐ㅒご睖⥘㹚⽜㥞๠ᅢࡤɦ൨䭪ɬŮ兰ᅲtṶᕸེ偼ᙾꎂﮊﶎ뮔", num));
                }
                this.string_2 = value;
                this.bool_2 = true;
            }
        }

        internal bool LinkToContent
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                this.bool_2 = value;
            }
        }

        public string Name
        {
            get
            {
                if (this.string_1 != null)
                {
                    return this.string_1;
                }
                return this.builtInProperty_0.ToString();
            }
        }

        internal object[] ObjectArray
        {
            get
            {
                int num = 0;
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.ObjectArray)
                {
                    throw new InvalidCastException(BookmarkStart.b("攥䤧䐩ଫ娭ု儱嬳堵丷弹主䨽怿㑁╃⩅㵇⽉汋㩍㽏牑㕓㡕硗㭙⹛ⱝş᭡䑣॥๧䩩Ὣᩭɯ᭱ᩳᅵ୷呹", num));
                }
                return (object[]) this.object_0;
            }
            set
            {
                int num = 1;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("儦䠨䜪堬䨮", num));
                }
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.ObjectArray;
                this.object_0 = value;
            }
        }

        internal BuiltInProperty PropertyId
        {
            get
            {
                return this.builtInProperty_0;
            }
            set
            {
                this.builtInProperty_0 = value;
            }
        }

        internal Spire.CompoundFile.Doc.PropertyType PropertyType
        {
            get
            {
                return this.propertyType_0;
            }
            set
            {
                this.propertyType_0 = value;
            }
        }

        internal string[] StringArray
        {
            get
            {
                int num = 13;
                if (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.StringArray)
                {
                    throw new InvalidCastException(BookmarkStart.b("瀲吴夶Ḹ伺ᴼ尾⹀ⵂ㍄≆㭈㽊浌㥎ぐ㽒⁔㉖祘⽚㉜罞`ൢ䕤٦᭨ᥪ౬᙮兰ᱲ፴坶੸ེོᙾꦆ", num));
                }
                return (string[]) this.object_0;
            }
            set
            {
                int num = 0x13;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("伸娺儼䨾⑀", num));
                }
                this.propertyType_0 = Spire.CompoundFile.Doc.PropertyType.StringArray;
                this.object_0 = value;
            }
        }

        internal string Text
        {
            get
            {
                int num = 0x13;
                if (this.propertyType_0 == Spire.CompoundFile.Doc.PropertyType.Empty)
                {
                    this.method_4();
                }
                if ((this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.String) && (this.propertyType_0 != Spire.CompoundFile.Doc.PropertyType.AsciiString))
                {
                    throw new InvalidCastException(BookmarkStart.b("稸娺匼ᠾ㕀捂♄⡆❈㵊⡌㵎═獒⍔㙖㕘⹚㡜罞ᕠౢ䕤ᑦᵨᥪѬŮᙰ嵲", num));
                }
                return Convert.ToString(this.object_0);
            }
            set
            {
                this.propertyType_0 = this.method_0(value);
                this.object_0 = value;
            }
        }

        internal System.TimeSpan TimeSpan
        {
            get
            {
                return (System.TimeSpan) this.Value;
            }
            set
            {
                this.object_0 = value;
            }
        }

        public object Value
        {
            get
            {
                return this.object_0;
            }
            set
            {
                this.object_0 = value;
                this.method_4();
            }
        }

        public PropertyValueType ValueType
        {
            get
            {
                int num = 6;
                if (this.object_0 is string)
                {
                    return PropertyValueType.String;
                }
                if (this.object_0 is bool)
                {
                    return PropertyValueType.Boolean;
                }
                if (this.object_0 is System.DateTime)
                {
                    return PropertyValueType.Date;
                }
                if ((this.object_0 is int) || (this.object_0 is int))
                {
                    return PropertyValueType.Int;
                }
                if (this.object_0 is double)
                {
                    return PropertyValueType.Double;
                }
                if (this.Value is float)
                {
                    return PropertyValueType.Float;
                }
                if (this.Value is byte[])
                {
                    return PropertyValueType.ByteArray;
                }
                if (!(this.Value is Class875))
                {
                    throw new Exception(BookmarkStart.b("簫尭弯䈱儳䐵䰷䌹᰻䠽ℿ⹁ㅃ⍅桇⍉㽋湍㽏㑑瑓⍕㙗⥙⥛⹝ၟൡᙣብ൧๩䱫ᩭ९ɱᅳ塵", num));
                }
                return PropertyValueType.ClipData;
            }
        }
    }
}

