namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Fields.Shape;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class TextBoxFormat : WordAttrCollection
    {
        private Background background_0;
        private bool bool_2;
        private bool bool_3;
        [CompilerGenerated]
        private bool bool_4;
        [CompilerGenerated]
        private bool bool_5;
        private byte byte_3;
        private const float float_2 = 0.75f;
        private int int_8;
        private Spire.Doc.Formatting.InternalMargin internalMargin_0;
        private List<int> list_2;
        private List<string> list_3;
        private long[] long_3;
        [CompilerGenerated]
        private PointF pointF_0;
        private string[] string_3;
        private string string_4;
        private TextBox textBox_0;

        internal TextBoxFormat() : this(null)
        {
        }

        public TextBoxFormat(TextBox txtBox)
        {
            this.bool_2 = true;
            this.string_4 = BookmarkStart.b("䘳匵嬷丹", 14);
            this.bool_3 = true;
            this.int_8 = 0xca;
            this.textBox_0 = txtBox;
            this.background_0 = new Background(txtBox.Document, txtBox);
        }

        public TextBoxFormat Clone()
        {
            TextBoxFormat format = new TextBoxFormat();
            foreach (KeyValuePair<int, object> pair in this.ParentTextBox.ShapePr.PropertiesHash)
            {
                if (!format.ParentTextBox.ShapePr.method_6(pair.Key))
                {
                    format.ParentTextBox.ShapePr.PropertiesHash.Add(pair.Key, pair.Value);
                }
                else
                {
                    format.ParentTextBox.ShapePr.PropertiesHash[pair.Key] = pair.Value;
                }
            }
            return format;
        }

        protected override object GetDefValue(int key)
        {
            return null;
        }

        internal void method_49(TextBoxFormat A_0)
        {
            this.list_2 = A_0.Adjustment;
            this.list_3 = A_0.DocxStyleProps;
            this.textBox_0.ShapePr.method_24(A_0.ParentTextBox.ShapePr);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x13;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("缸刺儼匾ɀⱂ⥄⡆㭈", 0x13)))
            {
                this.FillColor = reader.ReadColor(BookmarkStart.b("缸刺儼匾ɀⱂ⥄⡆㭈", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("焸帺吼堾⥀㝂", num)))
            {
                this.Height = reader.ReadFloat(BookmarkStart.b("焸帺吼堾⥀㝂", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊Ɍ㵎㡐㑒㱔㥖", num)))
            {
                this.HorizontalOrigin = (Spire.Doc.Documents.HorizontalOrigin) reader.ReadEnum(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊Ɍ㵎㡐㑒㱔㥖", num), typeof(Spire.Doc.Documents.HorizontalOrigin));
            }
            if (reader.HasAttribute(BookmarkStart.b("甸刺匼娾ቀ㝂㱄⭆ⱈ", num)))
            {
                this.LineStyle = (TextBoxLineStyle) reader.ReadEnum(BookmarkStart.b("甸刺匼娾ቀ㝂㱄⭆ⱈ", num), typeof(TextBoxLineStyle));
            }
            if (reader.HasAttribute(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ᩈ㽊㑌⍎㑐", num)))
            {
                this.TextWrappingStyle = (Spire.Doc.Documents.TextWrappingStyle) reader.ReadEnum(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ᩈ㽊㑌⍎㑐", num), typeof(Spire.Doc.Documents.TextWrappingStyle));
            }
            if (reader.HasAttribute(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆و㥊⑌⡎㡐㵒", num)))
            {
                this.VerticalOrigin = (Spire.Doc.Documents.VerticalOrigin) reader.ReadEnum(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆و㥊⑌⡎㡐㵒", num), typeof(Spire.Doc.Documents.VerticalOrigin));
            }
            if (reader.HasAttribute(BookmarkStart.b("游刺夼䬾⥀", num)))
            {
                this.Width = reader.ReadFloat(BookmarkStart.b("游刺夼䬾⥀", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("甸刺匼娾ɀⱂ⥄⡆㭈", num)))
            {
                this.LineColor = reader.ReadColor(BookmarkStart.b("甸刺匼娾ɀⱂ⥄⡆㭈", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊ᵌ⁎≐㩒⅔㹖㙘㕚", num)))
            {
                this.HorizontalPosition = reader.ReadFloat(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊ᵌ⁎≐㩒⅔㹖㙘㕚", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("甸刺匼娾Հ≂㙄⽆⁈╊⩌", num)))
            {
                this.LineDashing = (Spire.Doc.LineDashing) reader.ReadEnum(BookmarkStart.b("甸刺匼娾Հ≂㙄⽆⁈╊⩌", num), typeof(Spire.Doc.LineDashing));
            }
            if (reader.HasAttribute(BookmarkStart.b("甸刺匼娾ᙀ⩂⅄㍆ⅈ", num)))
            {
                this.LineWidth = reader.ReadFloat(BookmarkStart.b("甸刺匼娾ᙀ⩂⅄㍆ⅈ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆᥈⑊㹌♎═㩒㩔㥖", num)))
            {
                this.VerticalPosition = reader.ReadFloat(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆᥈⑊㹌♎═㩒㩔㥖", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ш⑊⥌⩎", num)))
            {
                this.WrappingMode = (WrapMode) reader.ReadEnum(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ш⑊⥌⩎", num), typeof(WrapMode));
            }
            if (reader.HasAttribute(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ᵈ㉊㵌⩎", num)))
            {
                this.TextWrappingType = (Spire.Doc.Documents.TextWrappingType) reader.ReadEnum(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ᵈ㉊㵌⩎", num), typeof(Spire.Doc.Documents.TextWrappingType));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀸䠺缼娾ⵀⱂ㉄ፆⱈ㍊㥌", num)))
            {
                this.IsBelowText = reader.ReadBoolean(BookmarkStart.b("瀸䠺缼娾ⵀⱂ㉄ፆⱈ㍊㥌", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("眸吺焼嘾⽀♂", num)))
            {
                this.NoLine = reader.ReadBoolean(BookmarkStart.b("眸吺焼嘾⽀♂", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("眸吺笼嘾ⵀ⽂", num)))
            {
                this.FillColor = Color.Empty;
            }
            if (reader.HasAttribute(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊ౌ⍎㡐㑒㭔㩖㱘㕚⥜", num)))
            {
                this.HorizontalAlignment = (ShapeHorizontalAlignment) reader.ReadEnum(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊ౌ⍎㡐㑒㭔㩖㱘㕚⥜", num), typeof(ShapeHorizontalAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆ࡈ❊⑌⡎㽐㹒ご㥖ⵘ", num)))
            {
                this.VerticalAlignment = (ShapeVerticalAlignment) reader.ReadEnum(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆ࡈ❊⑌⡎㽐㹒ご㥖ⵘ", num), typeof(ShapeVerticalAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("樸区尼伾⑀ੂń", num)))
            {
                this.TextBoxShapeID = reader.ReadInt(BookmarkStart.b("樸区尼伾⑀ੂń", num));
            }
            reader.HasAttribute(BookmarkStart.b("瀸䠺甼娾⁀❂⁄㕆", num));
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x11;
            base.WriteXmlAttributes(writer);
            if (this.FillColor == Color.Empty)
            {
                writer.WriteValue(BookmarkStart.b("礶嘸紺吼匾ⵀ", num), true);
            }
            else if (this.FillColor != Color.White)
            {
                writer.WriteValue(BookmarkStart.b("然倸场儼簾⹀⽂⩄㕆", num), this.FillColor);
            }
            if (this.Height != 0f)
            {
                writer.WriteValue(BookmarkStart.b("缶尸刺娼圾㕀", num), this.Height);
            }
            if (this.HorizontalOrigin != Spire.Doc.Documents.HorizontalOrigin.Column)
            {
                writer.WriteValue(BookmarkStart.b("缶嘸䤺吼䔾⹀ⵂㅄ♆╈ъ㽌♎㙐㩒㭔", num), this.HorizontalOrigin);
            }
            if (this.LineStyle != TextBoxLineStyle.Simple)
            {
                writer.WriteValue(BookmarkStart.b("笶倸唺堼氾㕀㩂⥄≆", num), this.LineStyle);
            }
            if (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Square)
            {
                writer.WriteValue(BookmarkStart.b("怶䬸娺䴼伾⡀ⵂ≄ᑆ㵈㉊⅌⩎", num), this.TextWrappingStyle);
            }
            if (this.VerticalOrigin != Spire.Doc.Documents.VerticalOrigin.Paragraph)
            {
                writer.WriteValue(BookmarkStart.b("愶尸䤺䤼嘾≀≂⥄ࡆ㭈≊⩌♎㽐", num), this.VerticalOrigin);
            }
            if (this.Width != 0f)
            {
                writer.WriteValue(BookmarkStart.b("怶倸强䤼圾", num), this.Width);
            }
            if (this.LineColor != Color.Black)
            {
                writer.WriteValue(BookmarkStart.b("笶倸唺堼簾⹀⽂⩄㕆", num), this.LineColor);
            }
            if (this.HorizontalPosition != 0f)
            {
                writer.WriteValue(BookmarkStart.b("缶嘸䤺吼䔾⹀ⵂㅄ♆╈ᭊ≌㱎㡐❒㱔㡖㝘", num), this.HorizontalPosition);
            }
            if (this.LineDashing != Spire.Doc.LineDashing.Solid)
            {
                writer.WriteValue(BookmarkStart.b("笶倸唺堼笾⁀あⵄ⹆❈ⱊ", num), this.LineDashing);
            }
            if (this.LineWidth != 0.75f)
            {
                writer.WriteValue(BookmarkStart.b("笶倸唺堼栾⡀❂ㅄ⽆", num), this.LineWidth);
            }
            if (this.VerticalPosition != 0f)
            {
                writer.WriteValue(BookmarkStart.b("愶尸䤺䤼嘾≀≂⥄ᝆ♈㡊⑌㭎㡐㱒㭔", num), this.VerticalPosition);
            }
            if (this.WrappingMode != WrapMode.None)
            {
                writer.WriteValue(BookmarkStart.b("怶䬸娺䴼伾⡀ⵂ≄੆♈⽊⡌", num), this.WrappingMode);
            }
            if (this.TextWrappingType != Spire.Doc.Documents.TextWrappingType.Both)
            {
                writer.WriteValue(BookmarkStart.b("怶䬸娺䴼伾⡀ⵂ≄ፆえ㭊⡌", num), this.TextWrappingType);
            }
            if (this.IsBelowText)
            {
                writer.WriteValue(BookmarkStart.b("縶䨸示堼匾⹀㑂ᅄ≆ㅈ㽊", num), this.IsBelowText);
            }
            if (this.NoLine)
            {
                writer.WriteValue(BookmarkStart.b("礶嘸眺吼儾⑀", num), this.NoLine);
            }
            if (this.HorizontalAlignment != ShapeHorizontalAlignment.None)
            {
                writer.WriteValue(BookmarkStart.b("缶嘸䤺吼䔾⹀ⵂㅄ♆╈੊⅌♎㙐㵒㡔㉖㝘⽚", num), this.HorizontalAlignment);
            }
            if (this.VerticalAlignment != ShapeVerticalAlignment.None)
            {
                writer.WriteValue(BookmarkStart.b("愶尸䤺䤼嘾≀≂⥄ن╈≊⩌ⅎ㱐㙒㭔⍖", num), this.VerticalAlignment);
            }
            if (this.TextBoxShapeID != 0)
            {
                writer.WriteValue(BookmarkStart.b("搶儸娺䴼娾ࡀ݂", num), this.TextBoxShapeID);
            }
            if (this.IsHeaderTextBox)
            {
                writer.WriteValue(BookmarkStart.b("縶䨸猺堼帾╀♂㝄", num), this.IsHeaderTextBox);
            }
        }

        internal List<int> Adjustment
        {
            get
            {
                if (this.list_2 == null)
                {
                    this.list_2 = new List<int>();
                }
                return this.list_2;
            }
            set
            {
                this.list_2 = value;
            }
        }

        internal bool AllowOverlap
        {
            get
            {
                return this.textBox_0.AllowOverlap;
            }
            set
            {
                this.textBox_0.AllowOverlap = value;
            }
        }

        internal List<string> DocxStyleProps
        {
            get
            {
                if (this.list_3 == null)
                {
                    this.list_3 = new List<string>();
                }
                return this.list_3;
            }
        }

        internal string DrawingShapeType
        {
            get
            {
                return this.string_4;
            }
            set
            {
                this.string_4 = value;
            }
        }

        public Color FillColor
        {
            get
            {
                if (this.textBox_0.Filled)
                {
                    return this.background_0.Color;
                }
                return Color.Empty;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    this.FillEfects.Type = BackgroundType.Color;
                }
                this.textBox_0.SetShapeAttribute(0x181, value);
            }
        }

        public Background FillEfects
        {
            get
            {
                return this.background_0;
            }
        }

        internal bool HasDocxProps
        {
            get
            {
                return (this.list_3 != null);
            }
        }

        public float Height
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.Height);
            }
            set
            {
                this.textBox_0.Height = value;
            }
        }

        internal float HeightPercent
        {
            get
            {
                return (((float) this.textBox_0.GetShapeAttribute(0x7c1)) / 10f);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x7c1, value * 10f);
            }
        }

        public ShapeHorizontalAlignment HorizontalAlignment
        {
            get
            {
                return (ShapeHorizontalAlignment) this.textBox_0.GetShapeAttribute(0x38f);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x38f, value);
            }
        }

        public Spire.Doc.Documents.HorizontalOrigin HorizontalOrigin
        {
            get
            {
                return this.textBox_0.HorizontalOrigin;
            }
            set
            {
                this.textBox_0.HorizontalOrigin = value;
            }
        }

        public float HorizontalPosition
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.Left);
            }
            set
            {
                this.textBox_0.Left = value;
            }
        }

        public Spire.Doc.Formatting.InternalMargin InternalMargin
        {
            get
            {
                if (this.internalMargin_0 == null)
                {
                    this.internalMargin_0 = new Spire.Doc.Formatting.InternalMargin(this.textBox_0);
                }
                return this.internalMargin_0;
            }
        }

        internal bool IsAllowInCell
        {
            get
            {
                return (bool) this.textBox_0.GetShapeAttribute(0x3b0);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x3b0, value);
            }
        }

        internal bool IsBelowText
        {
            get
            {
                if (!((bool) this.textBox_0.GetShapeAttribute(0x3ba)))
                {
                    return (this.TextWrappingStyle == Spire.Doc.Documents.TextWrappingStyle.Behind);
                }
                return true;
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x3ba, value);
            }
        }

        internal bool IsEditWrapPolygonPoint
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        public bool IsFitShapeToText
        {
            get
            {
                return (bool) this.textBox_0.GetShapeAttribute(190);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(190, value);
            }
        }

        internal bool IsFitTextToShape
        {
            get
            {
                return (bool) this.textBox_0.GetShapeAttribute(0xbf);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0xbf, value);
            }
        }

        internal bool IsHeaderTextBox
        {
            get
            {
                return (base.method_1() != null);
            }
        }

        internal bool IsInGroupShape
        {
            [CompilerGenerated]
            get
            {
                return this.bool_5;
            }
            [CompilerGenerated]
            set
            {
                this.bool_5 = value;
            }
        }

        internal bool IsInShape
        {
            [CompilerGenerated]
            get
            {
                return this.bool_4;
            }
            [CompilerGenerated]
            set
            {
                this.bool_4 = value;
            }
        }

        public TextDirection LayoutFlowAlt
        {
            get
            {
                return Class1085.smethod_59((LayoutFlow) this.textBox_0.GetShapeAttribute(0x88));
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x88, Class1085.smethod_60(value));
            }
        }

        internal float LeftPercent
        {
            get
            {
                return (((float) this.textBox_0.GetShapeAttribute(0x7c2)) / 10f);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x7c2, value * 10f);
            }
        }

        public Color LineColor
        {
            get
            {
                return (Color) this.textBox_0.GetShapeAttribute(0x1c0);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x1c0, value);
            }
        }

        public Spire.Doc.LineDashing LineDashing
        {
            get
            {
                return (Spire.Doc.LineDashing) this.textBox_0.GetShapeAttribute(0x1ce);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x1ce, value);
            }
        }

        public TextBoxLineStyle LineStyle
        {
            get
            {
                return (TextBoxLineStyle) this.textBox_0.GetShapeAttribute(0x1cd);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x1cd, value);
            }
        }

        public float LineWidth
        {
            get
            {
                return (float) Class969.smethod_42((int) this.textBox_0.GetShapeAttribute(0x1cb));
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x1cb, Class969.smethod_40((double) value));
            }
        }

        public bool NoLine
        {
            get
            {
                return !((bool) this.textBox_0.GetShapeAttribute(0x1fc));
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x1fc, !value);
            }
        }

        internal float Opacity
        {
            get
            {
                return this.FillEfects.Opacity;
            }
            set
            {
                this.FillEfects.Opacity = value;
            }
        }

        internal long OrderIndex
        {
            get
            {
                return this.textBox_0.ZOrder;
            }
            set
            {
                this.textBox_0.ZOrder = value;
            }
        }

        internal TextBox ParentTextBox
        {
            get
            {
                return this.textBox_0;
            }
        }

        internal Spire.Doc.Documents.VerticalOrigin RelationHeight
        {
            get
            {
                return (Spire.Doc.Documents.VerticalOrigin) this.textBox_0.GetShapeAttribute(0x7c5);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x7c5, value);
            }
        }

        internal Spire.Doc.Documents.HorizontalOrigin RelationWidth
        {
            get
            {
                return (Spire.Doc.Documents.HorizontalOrigin) this.textBox_0.GetShapeAttribute(0x7c4);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x7c4, value);
            }
        }

        internal float Rotation
        {
            get
            {
                return (float) this.textBox_0.Rotation;
            }
            set
            {
                this.textBox_0.Rotation = value;
            }
        }

        internal int ShapeTypeId
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

        internal PointF StartPoint
        {
            [CompilerGenerated]
            get
            {
                return this.pointF_0;
            }
            [CompilerGenerated]
            set
            {
                this.pointF_0 = value;
            }
        }

        public ShapeVerticalAlignment TextAnchor
        {
            get
            {
                return Class1085.smethod_48((TextBoxAnchor) this.textBox_0.GetShapeAttribute(0x87));
            }
            set
            {
                if (((value != ShapeVerticalAlignment.Inline) && (value != ShapeVerticalAlignment.Inside)) && ((value != ShapeVerticalAlignment.Outside) && (value != ShapeVerticalAlignment.None)))
                {
                    this.textBox_0.SetShapeAttribute(0x87, Class1085.smethod_49(value));
                }
            }
        }

        internal int TextBoxShapeID
        {
            get
            {
                return (int) this.textBox_0.GetShapeAttribute(0x101c);
            }
            set
            {
                this.textBox_0.SetShapeAttr(0x101c, value);
            }
        }

        internal Spire.Doc.TextBoxWrapMode TextBoxWrapMode
        {
            get
            {
                return (Spire.Doc.TextBoxWrapMode) this.textBox_0.GetShapeAttribute(0x85);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x85, value);
            }
        }

        internal bool TextUpRight
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

        public Spire.Doc.Documents.TextWrappingStyle TextWrappingStyle
        {
            get
            {
                return this.textBox_0.TextWrappingStyle;
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x1001, value);
            }
        }

        public Spire.Doc.Documents.TextWrappingType TextWrappingType
        {
            get
            {
                return (Spire.Doc.Documents.TextWrappingType) this.textBox_0.GetShapeAttribute(0x1002);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x1002, value);
            }
        }

        internal float TopPercent
        {
            get
            {
                return (((float) this.textBox_0.GetShapeAttribute(0x7c3)) / 10f);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x7c3, value * 10f);
            }
        }

        public ShapeVerticalAlignment VerticalAlignment
        {
            get
            {
                return (ShapeVerticalAlignment) this.textBox_0.GetShapeAttribute(0x391);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x391, value);
            }
        }

        public Spire.Doc.Documents.VerticalOrigin VerticalOrigin
        {
            get
            {
                return this.textBox_0.VerticalOrigin;
            }
            set
            {
                this.textBox_0.VerticalOrigin = value;
            }
        }

        public float VerticalPosition
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.Top);
            }
            set
            {
                this.textBox_0.Top = value;
            }
        }

        public float Width
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.Width);
            }
            set
            {
                this.textBox_0.Width = value;
            }
        }

        internal float WidthPercent
        {
            get
            {
                return (Convert.ToSingle(this.textBox_0.GetShapeAttribute(0x7c0)) / 10f);
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x7c0, value * 10f);
            }
        }

        internal float WrapDistanceBottom
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.DistanceBottom);
            }
            set
            {
                this.textBox_0.DistanceBottom = value;
            }
        }

        internal float WrapDistanceLeft
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.DistanceLeft);
            }
            set
            {
                this.textBox_0.DistanceLeft = value;
            }
        }

        internal float WrapDistanceRight
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.DistanceRight);
            }
            set
            {
                this.textBox_0.DistanceRight = value;
            }
        }

        internal float WrapDistanceTop
        {
            get
            {
                return Convert.ToSingle(this.textBox_0.DistanceTop);
            }
            set
            {
                this.textBox_0.DistanceTop = value;
            }
        }

        internal WrapMode WrappingMode
        {
            get
            {
                return (WrapMode) this.textBox_0.GetShapeAttribute(0x1001);
            }
            set
            {
                this.textBox_0.SetShapeAttr(0x1001, value);
            }
        }

        internal Class891[] WrapPolygon
        {
            get
            {
                Class891[] shapeAttribute = (Class891[]) this.textBox_0.GetShapeAttribute(0x383);
                if ((shapeAttribute != null) && (shapeAttribute.Length >= 5))
                {
                    return shapeAttribute;
                }
                return new Class891[] { new Class891(0, 0), new Class891(0, 0x541f), new Class891(0x541f, 0x541f), new Class891(0x541f, 0), new Class891(0, 0) };
            }
            set
            {
                this.textBox_0.SetShapeAttribute(0x383, value);
            }
        }

        internal List<PointF> WrapPolygonEx
        {
            get
            {
                List<PointF> list = new List<PointF>();
                foreach (Class891 class2 in this.WrapPolygon)
                {
                    list.Add(new PointF((class2.method_0().method_1() * 0.75f) / 20f, (class2.method_1().method_1() * 0.75f) / 20f));
                }
                return list;
            }
        }
    }
}

