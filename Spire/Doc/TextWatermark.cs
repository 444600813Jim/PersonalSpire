namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Drawing;

    public class TextWatermark : WatermarkBase
    {
        private bool bool_10;
        private bool bool_11;
        private System.Drawing.Color color_0;
        private float float_3;
        private float float_4;
        private int int_7;
        private int int_8;
        private long[] long_5;
        private string string_10;
        private string string_11;
        private string string_8;
        private string string_9;
        private WatermarkLayout watermarkLayout_0;

        public TextWatermark() : base(WatermarkType.TextWatermark)
        {
            this.string_10 = BookmarkStart.b("笭䈯唱儳堵䰷", 8);
            this.string_11 = BookmarkStart.b("稭夯弱儳䔵ᠷ琹夻䤽怿၁⭃⭅⥇⑉", 8);
            this.float_4 = 36f;
            this.color_0 = System.Drawing.Color.Gray;
            this.bool_11 = true;
            this.int_7 = -1;
            this.int_8 = -1;
        }

        internal TextWatermark(Document A_0) : base(A_0, WatermarkType.TextWatermark)
        {
            this.string_10 = BookmarkStart.b("洷䠹嬻嬽⸿㙁", 0x12);
            this.string_11 = BookmarkStart.b("氷匹儻嬽㌿扁੃⍅㽇橉ṋ⅍㵏㍑㩓", 0x12);
            this.float_4 = 36f;
            this.color_0 = System.Drawing.Color.Gray;
            this.bool_11 = true;
            this.int_7 = -1;
            this.int_8 = -1;
        }

        public TextWatermark(string text) : base(WatermarkType.TextWatermark)
        {
            this.string_10 = BookmarkStart.b("猥娧䴩䤫䀭䐯", 0);
            this.string_11 = BookmarkStart.b("爥䄧䜩䤫崭ု簱儳䄵ᠷ根医匽ℿⱁ", 0);
            this.float_4 = 36f;
            this.color_0 = System.Drawing.Color.Gray;
            this.bool_11 = true;
            this.int_7 = -1;
            this.int_8 = -1;
            this.string_10 = text;
        }

        public TextWatermark(string text, string fontName, int fontSize, WatermarkLayout layout) : base(WatermarkType.TextWatermark)
        {
            this.string_10 = BookmarkStart.b("戶䬸尺堼儾㕀", 0x11);
            this.string_11 = BookmarkStart.b("挶倸嘺堼䰾慀ൂ⁄う楈᥊≌≎ぐ㵒", 0x11);
            this.float_4 = 36f;
            this.color_0 = System.Drawing.Color.Gray;
            this.bool_11 = true;
            this.int_7 = -1;
            this.int_8 = -1;
            this.string_10 = text;
            this.string_11 = fontName;
            this.float_4 = fontSize;
            this.watermarkLayout_0 = layout;
        }

        private SizeF method_30()
        {
            Font font = Class58.smethod_1(this.string_11, this.float_4, FontStyle.Regular);
            return Class1073.smethod_0().MeasureString(this.string_10, font);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("氷弹䐻䨽", 0x12)))
            {
                this.string_10 = reader.ReadString(BookmarkStart.b("氷弹䐻䨽", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷弹䐻䨽ؿⵁ⩃㉅ه⭉⅋⭍", num)))
            {
                this.string_11 = reader.ReadString(BookmarkStart.b("氷弹䐻䨽ؿⵁ⩃㉅ه⭉⅋⭍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷弹䐻䨽ؿⵁ⩃㉅ᭇ⍉㙋⭍", num)))
            {
                this.float_4 = reader.ReadFloat(BookmarkStart.b("氷弹䐻䨽ؿⵁ⩃㉅ᭇ⍉㙋⭍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷弹䐻䨽ి⍁㵃⥅㵇㹉", num)))
            {
                this.watermarkLayout_0 = (WatermarkLayout) reader.ReadEnum(BookmarkStart.b("氷弹䐻䨽ి⍁㵃⥅㵇㹉", num), typeof(WatermarkLayout));
            }
            if (reader.HasAttribute(BookmarkStart.b("欷弹儻圽㐿ぁ╃⡅㭇㩉ⵋ㱍㕏㱑⁓", num)))
            {
                this.bool_11 = reader.ReadBoolean(BookmarkStart.b("欷弹儻圽㐿ぁ╃⡅㭇㩉ⵋ㱍㕏㱑⁓", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷弹䐻䨽ؿⵁ⩃㉅େ╉⁋⅍≏", num)))
            {
                this.color_0 = reader.ReadColor(BookmarkStart.b("氷弹䐻䨽ؿⵁ⩃㉅େ╉⁋⅍≏", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("欷刹崻丽┿ੁ⅃⽅⽇≉㡋", num)))
            {
                this.int_7 = reader.ReadInt(BookmarkStart.b("欷刹崻丽┿ੁ⅃⽅⽇≉㡋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("欷刹崻丽┿ᕁⵃ≅㱇≉", num)))
            {
                this.int_8 = reader.ReadInt(BookmarkStart.b("欷刹崻丽┿ᕁⵃ≅㱇≉", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x10;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("戵崷䈹䠻", 0x10), this.string_10);
            writer.WriteValue(BookmarkStart.b("戵崷䈹䠻砽⼿ⱁぃࡅ⥇❉⥋", 0x10), this.string_11);
            writer.WriteValue(BookmarkStart.b("戵崷䈹䠻砽⼿ⱁぃᕅⅇぉ⥋", 0x10), this.float_4);
            writer.WriteValue(BookmarkStart.b("戵崷䈹䠻爽ℿ㭁⭃㍅㱇", 0x10), this.watermarkLayout_0);
            if (this.color_0 != System.Drawing.Color.Gray)
            {
                writer.WriteValue(BookmarkStart.b("戵崷䈹䠻砽⼿ⱁぃՅ❇♉⍋㱍", num), this.color_0);
            }
            if (!this.bool_11)
            {
                writer.WriteValue(BookmarkStart.b("攵崷圹唻䨽㈿⍁⩃㕅㡇⭉㹋⭍㹏♑", num), this.bool_11);
            }
            if (this.int_7 != 0)
            {
                writer.WriteValue(BookmarkStart.b("攵倷嬹䰻嬽࠿❁ⵃⅅ⁇㹉", num), this.int_7);
            }
            if (this.int_8 != 0)
            {
                writer.WriteValue(BookmarkStart.b("攵倷嬹䰻嬽᜿⭁⁃㉅⁇", num), this.int_8);
            }
        }

        public System.Drawing.Color Color
        {
            get
            {
                return this.color_0;
            }
            set
            {
                this.color_0 = value;
            }
        }

        public string FontName
        {
            get
            {
                return this.string_11;
            }
            set
            {
                this.string_11 = value;
                this.int_7 = -1;
                this.int_8 = -1;
            }
        }

        public float FontSize
        {
            get
            {
                return this.float_4;
            }
            set
            {
                this.float_4 = value;
                this.int_7 = -1;
                this.int_8 = -1;
            }
        }

        public WatermarkLayout Layout
        {
            get
            {
                return this.watermarkLayout_0;
            }
            set
            {
                this.watermarkLayout_0 = value;
            }
        }

        public bool Semitransparent
        {
            get
            {
                return this.bool_11;
            }
            set
            {
                this.bool_11 = value;
            }
        }

        internal int ShapeHeightInPixels
        {
            get
            {
                return this.int_7;
            }
            set
            {
                this.int_7 = value;
            }
        }

        internal SizeF ShapeSize
        {
            get
            {
                return this.method_30();
            }
        }

        internal int ShapeWidthInPixels
        {
            get
            {
                return this.int_8;
            }
            set
            {
                this.int_8 = value;
            }
        }

        public string Text
        {
            get
            {
                return this.string_10;
            }
            set
            {
                this.string_10 = value;
            }
        }
    }
}

