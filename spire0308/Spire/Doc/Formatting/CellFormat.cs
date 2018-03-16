namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public class CellFormat : WordAttrCollection
    {
        private bool bool_2;
        private bool bool_3 = true;
        private bool bool_4;
        [CompilerGenerated]
        private bool bool_5;
        private float float_2;
        internal const int int_10 = 3;
        internal const int int_11 = 4;
        internal const int int_12 = 5;
        internal const int int_13 = 6;
        internal const int int_14 = 7;
        internal const int int_15 = 0xbc4;
        internal const int int_16 = 0xbc6;
        internal const int int_17 = 0xbf4;
        internal const int int_18 = 0xc62;
        internal const int int_19 = 0xbd6;
        internal const int int_20 = 0xbe0;
        internal const int int_21 = 0xc6c;
        internal const int int_22 = 0xc76;
        internal const int int_23 = 0xbea;
        private int int_24;
        internal const int int_25 = 0xd48;
        internal const int int_26 = 0xbcc;
        private int int_27 = -1;
        private int int_28;
        internal const int int_8 = 1;
        internal const int int_9 = 2;
        private long[] long_3;
        private long long_4;
        private long long_5;
        private RowFormat rowFormat_0;
        private short short_0 = 1;
        private string[] string_3;
        private WidthType widthType_0;

        public CellFormat()
        {
            this.Borders.method_0(this);
        }

        internal override void ApplyBase(FormatBase baseFormat)
        {
            base.ApplyBase(baseFormat);
            this.Borders.ApplyBase((baseFormat as CellFormat).Borders);
            this.Paddings.ApplyBase((baseFormat as CellFormat).Paddings);
        }

        internal override void ApplyProperty()
        {
            if (base.m_propsUpdateFlags != null)
            {
                base.m_propsUpdateFlags.Clear();
            }
            Type type = typeof(CellFormat);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                int num2 = (int) info.GetValue(info.FieldType);
                this.method_51(num2);
            }
        }

        protected internal override void EnsureComposites()
        {
            if (base.HasKey(1))
            {
                base.EnsureComposites(new int[] { 1 });
            }
            if (base.HasKey(2))
            {
                base.EnsureComposites(new int[] { 2 });
            }
            if (base.HasKey(0xbcc))
            {
                base.EnsureComposites(new int[] { 0xbcc });
            }
            if (base.HasKey(0xc62))
            {
                base.EnsureComposites(new int[] { 0xc62 });
            }
        }

        protected override FormatBase GetDefComposite(int key)
        {
            switch (key)
            {
                case 1:
                    return base.GetDefComposite(1, new Spire.Doc.Documents.Borders(this, 1));

                case 2:
                    return base.GetDefComposite(2, new Spire.Doc.Formatting.Paddings(this, 2));

                case 0xbcc:
                    return base.GetDefComposite(0xbcc, new Class15(this, 0xbcc));

                case 0xc62:
                    return base.GetDefComposite(0xc62, new Class16(this, 0xc62));
            }
            return null;
        }

        protected override object GetDefValue(int key)
        {
            int num = key;
            if (num <= 0xc26)
            {
                if (num > 0xbea)
                {
                    if (num > 0xc08)
                    {
                        switch (num)
                        {
                            case 0xc12:
                                return this.Paddings.Left;

                            case 0xc1c:
                                return this.Paddings.Right;

                            case 0xc26:
                                return this.Borders.Top;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0xbf4:
                                return Spire.Doc.Documents.VerticalAlignment.Top;

                            case 0xbfe:
                                return this.Paddings.Top;

                            case 0xc08:
                                return this.Paddings.Bottom;
                        }
                    }
                }
                else if (num > 0xbc6)
                {
                    switch (num)
                    {
                        case 0xbd6:
                            return CellMerge.None;

                        case 0xbe0:
                            return CellMerge.None;

                        case 0xbea:
                            return Spire.Doc.Documents.TextDirection.TopToBottom;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 3:
                            return Color.Empty;

                        case 4:
                            return this.Shading.method_58();

                        case 5:
                            return this.Shading.method_62();

                        case 6:
                            return 100f;

                        case 7:
                            return -3.402823E+38f;

                        case 0xbc2:
                            return 0;

                        case 0xbc4:
                            return this.PreferredWidth.method_49();

                        case 0xbc6:
                            return this.PreferredWidth.method_51();
                    }
                }
            }
            else
            {
                switch (num)
                {
                    case 0xc30:
                        return this.Borders.Left;

                    case 0xc3a:
                        return this.Borders.Bottom;

                    case 0xc44:
                        return this.Borders.Right;

                    case 0xc4e:
                        return this.Borders.DiagonalDown;

                    case 0xc58:
                        return this.Borders.DiagonalUp;

                    case 0xc6c:
                        return true;

                    case 0xc76:
                    case 0xc94:
                        return false;

                    case 0xc80:
                        return this.Borders.Horizontal;

                    case 0xc8a:
                        return this.Borders.Vertical;

                    case 0xd48:
                        return (short) 0;

                    case 0xf3c:
                        return (short) 1;
                }
            }
            throw new NotImplementedException();
        }

        internal override int GetFullKey(int key)
        {
            int num = key;
            if (num <= 0xc26)
            {
                if (num > 0xbfe)
                {
                    if (num > 0xc12)
                    {
                        if (num == 0xc1c)
                        {
                            return this.Paddings.GetFullKey(4);
                        }
                        if (num == 0xc26)
                        {
                            return this.Borders.GetFullKey(2);
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0xc08:
                                return this.Paddings.GetFullKey(3);

                            case 0xc12:
                                return this.Paddings.GetFullKey(1);
                        }
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 3:
                            return this.Shading.GetFullKey(3);

                        case 4:
                            return this.Shading.GetFullKey(2);

                        case 5:
                            return this.Shading.GetFullKey(1);

                        case 0xbc4:
                            return this.PreferredWidth.GetFullKey(1);

                        case 0xbc6:
                            return this.PreferredWidth.GetFullKey(2);

                        case 0xbfe:
                            return this.Paddings.GetFullKey(2);
                    }
                }
            }
            else
            {
                switch (num)
                {
                    case 0xc30:
                        return this.Borders.GetFullKey(1);

                    case 0xc3a:
                        return this.Borders.GetFullKey(3);

                    case 0xc44:
                        return this.Borders.GetFullKey(4);

                    case 0xc4e:
                        return this.Borders.GetFullKey(7);

                    case 0xc58:
                        return this.Borders.GetFullKey(8);

                    case 0xc80:
                        return this.Borders.GetFullKey(6);

                    case 0xc8a:
                        return this.Borders.GetFullKey(5);
                }
            }
            return base.GetFullKey(key);
        }

        internal override bool HasValue(int propertyKey)
        {
            this.method_51(propertyKey);
            return base.HasKey(propertyKey);
        }

        protected override void ImportMembers(FormatBase format)
        {
            if (format is CellFormat)
            {
                this.Borders.method_0(this);
                this.SamePaddingsAsTable = ((CellFormat) format).SamePaddingsAsTable;
            }
            else
            {
                this.method_57(format as RowFormat);
            }
        }

        protected override void InitXDLSHolder()
        {
            int num = 10;
            if (!this.OwnerRowFormat.method_57())
            {
                base.XDLSHolder.AddElement(BookmarkStart.b("刯崱䘳刵崷䠹伻", num), this.Borders);
                base.XDLSHolder.AddElement(BookmarkStart.b("怯匱倳刵儷吹嬻䴽", num), this.Paddings);
            }
        }

        private object method_49(int A_0)
        {
            return base[A_0];
        }

        private void method_50(int A_0, object A_1)
        {
            base[A_0] = A_1;
        }

        internal void method_51(int A_0)
        {
            if (!base.IsPropertyUpdated(A_0) && (this.OwnerRowFormat != null))
            {
                base.SetPropUpdateFlag(A_0);
            }
        }

        private RowFormat method_52()
        {
            if (this.rowFormat_0 == null)
            {
                TableCell ownerBase = base.OwnerBase as TableCell;
                if (ownerBase == null)
                {
                    return null;
                }
                TableRow owner = ownerBase.Owner as TableRow;
                if (owner == null)
                {
                    return null;
                }
                this.rowFormat_0 = owner.RowFormat;
            }
            return this.rowFormat_0;
        }

        private int method_53()
        {
            if (this.int_27 < 0)
            {
                TableCell ownerBase = base.OwnerBase as TableCell;
                if (ownerBase != null)
                {
                    this.int_27 = ownerBase.GetCellIndex();
                }
            }
            return this.int_27;
        }

        private bool method_54()
        {
            if (!this.bool_3)
            {
                return this.bool_3;
            }
            return this.bool_3;
        }

        private void method_55(FormatBase A_0, int A_1)
        {
            int num = A_1;
            if (num > 0xbfe)
            {
                if (((num != 0xc08) && (num != 0xc12)) && (num != 0xc1c))
                {
                    return;
                }
            }
            else
            {
                switch (num)
                {
                    case 0xbc4:
                    case 0xbc6:
                        this.PreferredWidth.IsDefault = false;
                        break;

                    case 0xbc5:
                        break;

                    case 0xbfe:
                        goto Label_0051;

                    default:
                        return;
                }
                return;
            }
        Label_0051:
            this.Paddings.IsDefault = false;
        }

        internal void method_56(Form3 A_0)
        {
            if (A_0.HasValue(3))
            {
                base[3] = A_0.method_60();
            }
            if (A_0.HasValue(4))
            {
                base[4] = A_0.method_62();
            }
            if (A_0.HasValue(5))
            {
                base[5] = A_0.method_64();
            }
            if (A_0.HasValue(0xc6c))
            {
                base[0xc6c] = A_0.method_70();
            }
            if (A_0.HasValue(0xbf4))
            {
                base[0xbf4] = A_0.method_68();
            }
            this.Paddings.method_50(A_0.method_67());
        }

        private void method_57(RowFormat A_0)
        {
            this.BackColor = A_0.BackColor;
            this.method_58(A_0.Borders);
        }

        private void method_58(Spire.Doc.Documents.Borders A_0)
        {
            this.Borders.Left.BorderType = A_0.Left.BorderType;
            this.Borders.Left.Color = A_0.Left.Color;
            this.Borders.Left.IsDefault = A_0.Left.IsDefault;
            this.Borders.Left.LineWidth = A_0.Left.LineWidth;
            this.Borders.Left.Shadow = A_0.Left.Shadow;
            this.Borders.Left.Space = A_0.Left.Space;
            this.Borders.Right.BorderType = A_0.Right.BorderType;
            this.Borders.Right.Color = A_0.Right.Color;
            this.Borders.Right.IsDefault = A_0.Right.IsDefault;
            this.Borders.Right.LineWidth = A_0.Right.LineWidth;
            this.Borders.Right.Shadow = A_0.Right.Shadow;
            this.Borders.Right.Space = A_0.Right.Space;
            this.Borders.Top.BorderType = A_0.Top.BorderType;
            this.Borders.Top.Color = A_0.Top.Color;
            this.Borders.Top.IsDefault = A_0.Top.IsDefault;
            this.Borders.Top.LineWidth = A_0.Top.LineWidth;
            this.Borders.Top.Shadow = A_0.Top.Shadow;
            this.Borders.Top.Space = A_0.Top.Space;
            this.Borders.Bottom.BorderType = A_0.Bottom.BorderType;
            this.Borders.Bottom.Color = A_0.Bottom.Color;
            this.Borders.Bottom.IsDefault = A_0.Bottom.IsDefault;
            this.Borders.Bottom.LineWidth = A_0.Bottom.LineWidth;
            this.Borders.Bottom.Shadow = A_0.Bottom.Shadow;
            this.Borders.Bottom.Space = A_0.Bottom.Space;
        }

        private void method_59(Spire.Doc.Formatting.Paddings A_0)
        {
            this.Paddings.Left = A_0.Left;
            this.Paddings.Right = A_0.Right;
            this.Paddings.Top = A_0.Top;
            this.Paddings.Bottom = A_0.Bottom;
        }

        protected override void OnChange(FormatBase format, int propKey)
        {
            this.method_55(format, propKey);
            if ((!this.bool_2 && ((base.OwnerBase == null) || !base.OwnerBase.Document.bool_3)) && (((format is Spire.Doc.Documents.Borders) || (format is Border)) || !(format is Spire.Doc.Formatting.Paddings)))
            {
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 3;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("缨横䄬䘮嘰崲場制圸伺", 3)))
            {
                this.VerticalAlignment = (Spire.Doc.Documents.VerticalAlignment) reader.ReadEnum(BookmarkStart.b("缨横䄬䘮嘰崲場制圸伺", num), typeof(Spire.Doc.Documents.VerticalAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("缨昪䠬崮嘰嘲", num)))
            {
                this.VerticalMerge = (CellMerge) reader.ReadEnum(BookmarkStart.b("缨昪䠬崮嘰嘲", num), typeof(CellMerge));
            }
            if (reader.HasAttribute(BookmarkStart.b("愨昪䠬崮嘰嘲", num)))
            {
                this.HorizontalMerge = (CellMerge) reader.ReadEnum(BookmarkStart.b("愨昪䠬崮嘰嘲", num), typeof(CellMerge));
            }
            if (reader.HasAttribute(BookmarkStart.b("稨䌪䰬䬮堰崲刴琶嘸场刼䴾", num)))
            {
                this.BackColor = reader.ReadColor(BookmarkStart.b("稨䌪䰬䬮堰崲刴琶嘸场刼䴾", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("紨个唬嬮昰䄲吴䜶", num)))
            {
                this.TextWrap = reader.ReadBoolean(BookmarkStart.b("紨个唬嬮昰䄲吴䜶", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稨䨪䀬䨮愰刲儴匶倸唺娼䰾@あᅄ♆⭈❊⡌", num)))
            {
                this.SamePaddingsAsTable = reader.ReadBoolean(BookmarkStart.b("稨䨪䀬䨮愰刲儴匶倸唺娼䰾@あᅄ♆⭈❊⡌", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("漨䈪夬笮吰䬲䄴", num)))
            {
                this.FitText = reader.ReadBoolean(BookmarkStart.b("漨䈪夬笮吰䬲䄴", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("紨个唬嬮田娲䜴制娸伺吼倾⽀", num)))
            {
                this.TextDirection = (Spire.Doc.Documents.TextDirection) reader.ReadEnum(BookmarkStart.b("紨个唬嬮田娲䜴制娸伺吼倾⽀", num), typeof(Spire.Doc.Documents.TextDirection));
            }
        }

        internal override void SetAttr(int propKey, object value)
        {
            this.method_50(propKey, value);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 13;
            base.WriteXmlAttributes(writer);
            if (base.HasKey(0xc6c))
            {
                writer.WriteValue(BookmarkStart.b("朲倴伶䴸氺似帾ㅀ", num), this.TextWrap);
            }
            writer.WriteValue(BookmarkStart.b("怲吴娶尸欺尼嬾╀⩂⭄⁆㩈੊㹌᭎ぐㅒ㥔㉖", num), this.bool_3);
            if (!this.OwnerRowFormat.method_57())
            {
                if (this.VerticalAlignment != Spire.Doc.Documents.VerticalAlignment.Top)
                {
                    writer.WriteValue(BookmarkStart.b("攲琴嬶倸尺匼刾⑀ⵂㅄ", num), this.VerticalAlignment);
                }
                if (this.VerticalMerge != CellMerge.None)
                {
                    writer.WriteValue(BookmarkStart.b("攲破制䬸尺堼", num), this.VerticalMerge);
                }
                if (this.HorizontalMerge != CellMerge.None)
                {
                    writer.WriteValue(BookmarkStart.b("笲破制䬸尺堼", num), this.HorizontalMerge);
                }
                if (this.BackColor != Color.Empty)
                {
                    writer.WriteValue(BookmarkStart.b("怲崴嘶崸刺匼堾ɀⱂ⥄⡆㭈", num), this.BackColor);
                }
                if (this.FitText)
                {
                    writer.WriteValue(BookmarkStart.b("甲尴䌶洸帺䔼䬾", num), this.FitText);
                }
                if (this.TextDirection != Spire.Doc.Documents.TextDirection.TopToBottom)
                {
                    writer.WriteValue(BookmarkStart.b("朲倴伶䴸缺吼䴾⑀⁂ㅄ⹆♈╊", num), this.TextDirection);
                }
            }
        }

        public Color BackColor
        {
            get
            {
                return this.Shading.method_56();
            }
            set
            {
                this.Shading.method_57(value);
            }
        }

        public Spire.Doc.Documents.Borders Borders
        {
            get
            {
                return (this.method_49(1) as Spire.Doc.Documents.Borders);
            }
            internal set
            {
                this.method_50(1, value);
                this.Borders.method_12(1, base.KeysOffset);
            }
        }

        internal float CellScaling
        {
            get
            {
                return (float) this.method_49(6);
            }
            set
            {
                this.method_50(6, value);
            }
        }

        internal float CellWidth
        {
            get
            {
                return this.PreferredWidth.method_49();
            }
            set
            {
                this.PreferredWidth.method_50(value);
            }
        }

        internal float CellWidthEx
        {
            get
            {
                float num = (float) this.method_49(7);
                if (num == float.MinValue)
                {
                    return this.CellWidth;
                }
                return num;
            }
            set
            {
                this.method_50(7, value);
            }
        }

        internal short Cellx
        {
            get
            {
                return (short) this.method_49(0xd48);
            }
            set
            {
                this.method_50(0xd48, value);
            }
        }

        internal int CurCellIndex
        {
            get
            {
                return this.method_53();
            }
        }

        public bool FitText
        {
            get
            {
                return (bool) this.method_49(0xc76);
            }
            set
            {
                this.method_50(0xc76, value);
            }
        }

        internal Color ForeColor
        {
            get
            {
                return this.Shading.method_60();
            }
            set
            {
                this.Shading.method_61(value);
            }
        }

        internal short GridSpan
        {
            get
            {
                return (short) this.method_49(0xf3c);
            }
            set
            {
                this.method_50(0xf3c, value);
                this.short_0 = value;
            }
        }

        internal short GridSpanEx
        {
            get
            {
                return this.short_0;
            }
            set
            {
                this.short_0 = value;
            }
        }

        internal bool HideMark
        {
            get
            {
                return (bool) this.method_49(0xc94);
            }
            set
            {
                this.method_50(0xc94, value);
            }
        }

        public CellMerge HorizontalMerge
        {
            get
            {
                return (CellMerge) this.method_49(0xbe0);
            }
            set
            {
                this.method_50(0xbe0, value);
            }
        }

        internal bool IsAutoResized
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        internal bool IsRtfCellwidthCalc
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

        internal RowFormat OwnerRowFormat
        {
            get
            {
                return this.method_52();
            }
        }

        public Spire.Doc.Formatting.Paddings Paddings
        {
            get
            {
                return (this.method_49(2) as Spire.Doc.Formatting.Paddings);
            }
        }

        internal Class15 PreferredWidth
        {
            get
            {
                return (Class15) this.method_49(0xbcc);
            }
            set
            {
                this.PreferredWidth.method_50(value.method_49());
                this.PreferredWidth.method_52(value.method_51());
            }
        }

        internal CellFormat RevisedPr
        {
            get
            {
                if (!base.HasFormatRevision)
                {
                    return this;
                }
                return (CellFormat) base.FormatRevision.method_4();
            }
        }

        internal float RtfCellWidth
        {
            get
            {
                return this.float_2;
            }
            set
            {
                this.float_2 = value;
            }
        }

        internal WidthType RtfCellWidthType
        {
            get
            {
                return this.widthType_0;
            }
            set
            {
                this.widthType_0 = value;
            }
        }

        public bool SamePaddingsAsTable
        {
            get
            {
                return this.method_54();
            }
            set
            {
                if ((this.bool_3 && !value) && (this.OwnerRowFormat != null))
                {
                    this.Paddings.method_50(this.OwnerRowFormat.Paddings);
                }
                this.bool_3 = value;
            }
        }

        internal Class16 Shading
        {
            get
            {
                return (Class16) this.method_49(0xc62);
            }
        }

        public Spire.Doc.Documents.TextDirection TextDirection
        {
            get
            {
                return (Spire.Doc.Documents.TextDirection) this.method_49(0xbea);
            }
            set
            {
                this.method_50(0xbea, value);
            }
        }

        internal Spire.Doc.TextureStyle TextureStyle
        {
            get
            {
                return this.Shading.method_62();
            }
            set
            {
                this.Shading.method_63(value);
            }
        }

        public bool TextWrap
        {
            get
            {
                return (bool) this.method_49(0xc6c);
            }
            set
            {
                this.method_50(0xc6c, value);
            }
        }

        internal int TwipCellWidth
        {
            get
            {
                if (base.HasKey(0xbc2))
                {
                    return (int) this.method_49(0xbc2);
                }
                return (int) (this.CellWidth * 20f);
            }
            set
            {
                this.method_50(0xbc2, value);
            }
        }

        public Spire.Doc.Documents.VerticalAlignment VerticalAlignment
        {
            get
            {
                return (Spire.Doc.Documents.VerticalAlignment) this.method_49(0xbf4);
            }
            set
            {
                this.method_50(0xbf4, value);
            }
        }

        public CellMerge VerticalMerge
        {
            get
            {
                return (CellMerge) this.method_49(0xbd6);
            }
            set
            {
                this.method_50(0xbd6, value);
            }
        }

        internal FtsWidth WidthUnit
        {
            get
            {
                return this.PreferredWidth.method_51();
            }
            set
            {
                this.PreferredWidth.method_52(value);
            }
        }
    }
}

