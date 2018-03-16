namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public class Border : WordAttrCollection
    {
        private bool bool_2;
        [CompilerGenerated]
        private bool bool_3;
        private BorderPositions borderPositions_0;
        protected const int FrameKey = 7;
        protected const int HasNoneStyleKey = 6;
        internal const int int_10 = 3;
        internal const int int_11 = 4;
        internal const int int_8 = 1;
        internal const int int_9 = 2;
        protected const int ShadowKey = 5;
        private string string_3;
        private string string_4;

        internal Border()
        {
        }

        public Border(FormatBase parent, int baseKey) : base(parent, baseKey)
        {
            switch (baseKey)
            {
                case 1:
                    this.borderPositions_0 = BorderPositions.Left;
                    break;

                case 2:
                    this.borderPositions_0 = BorderPositions.Top;
                    break;

                case 3:
                    this.borderPositions_0 = BorderPositions.Bottom;
                    break;

                case 4:
                    this.borderPositions_0 = BorderPositions.Right;
                    break;

                case 5:
                    this.borderPositions_0 = BorderPositions.Vertical;
                    break;

                case 6:
                    this.borderPositions_0 = BorderPositions.Horizontal;
                    break;

                case 7:
                    this.borderPositions_0 = BorderPositions.DiagonalDown;
                    break;

                case 8:
                    this.borderPositions_0 = BorderPositions.DiagonalUp;
                    break;
            }
            base.method_0(parent);
        }

        internal override void ApplyBase(FormatBase baseFormat)
        {
            base.ApplyBase(baseFormat);
        }

        internal override void ApplyProperty()
        {
            base.m_propsUpdateFlags.Clear();
            Type type = typeof(Border);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                int num2 = (int) info.GetValue(info.FieldType);
                base.method_31(num2);
            }
        }

        internal override void ClearAttrs()
        {
            this.Remove(1);
            this.Remove(2);
            this.Remove(6);
            this.Remove(3);
            this.Remove(5);
            this.Remove(4);
            this.Remove(7);
        }

        internal override void CopyPropertiesTo(FormatBase destFormat)
        {
            Border border = destFormat as Border;
            if (base.HasKey(2))
            {
                border.BorderType = this.BorderType;
            }
            if (base.HasKey(1))
            {
                border.Color = this.Color;
            }
            if (base.HasKey(3))
            {
                border.LineWidth = this.LineWidth;
            }
            if (base.HasKey(4))
            {
                border.Space = this.Space;
            }
            if (base.HasKey(5))
            {
                border.Shadow = this.Shadow;
            }
            if (base.HasKey(7))
            {
                border.Frame = this.Frame;
            }
            if (base.HasKey(6))
            {
                border.HasNoneStyle = this.HasNoneStyle;
            }
        }

        protected override object GetDefValue(int key)
        {
            int num = 0x12;
            switch (key)
            {
                case 1:
                    return System.Drawing.Color.Empty;

                case 2:
                    return BorderStyle.None;

                case 3:
                    return 0f;

                case 4:
                    return 0f;

                case 5:
                    return false;

                case 6:
                    return false;

                case 7:
                    return false;
            }
            throw new ArgumentException(BookmarkStart.b("匷弹䔻ḽ⠿⍁㝃晅ⅇ⑉㩋⽍㱏㭑こ癕⹗㭙せ⭝՟", num));
        }

        internal override bool HasValue(int propertyKey)
        {
            return base.HasValue(propertyKey);
        }

        public void InitFormatting(System.Drawing.Color color, float lineWidth, BorderStyle borderType, bool shadow)
        {
            base[1] = color;
            base[3] = lineWidth;
            base[2] = borderType;
            base[5] = shadow;
            if (borderType == BorderStyle.None)
            {
                base[6] = true;
            }
            else
            {
                base[6] = false;
            }
        }

        protected override void InitXDLSHolder()
        {
            if (this.IsDefault)
            {
                base.XDLSHolder.SkipMe = true;
            }
        }

        private void method_49(int A_0, object A_1)
        {
            base[A_0] = A_1;
            this.IsChanged = true;
        }

        private Border method_50()
        {
            Borders ownerBase = base.OwnerBase as Borders;
            if ((ownerBase != null) && (ownerBase.CurrentRow != null))
            {
                Borders borders = ownerBase.CurrentRow.RowFormat.Borders;
                switch (this.BorderPosition)
                {
                    case BorderPositions.Left:
                        return borders.Left;

                    case BorderPositions.Top:
                        return borders.Top;

                    case BorderPositions.Right:
                        return borders.Right;

                    case BorderPositions.Bottom:
                        return borders.Bottom;
                }
            }
            return null;
        }

        internal void method_51(Border A_0)
        {
            this.method_49(2, A_0.BorderType);
            this.method_49(3, A_0.LineWidth);
            this.method_49(1, A_0.Color);
            this.method_49(5, A_0.Shadow);
            if (A_0.BorderType != BorderStyle.Cleared)
            {
                this.method_49(6, A_0.HasNoneStyle);
            }
        }

        private void method_52()
        {
            if ((base.OwnerBase != null) && (base.OwnerBase is Borders))
            {
                Borders ownerBase = base.OwnerBase as Borders;
                if (ownerBase.CurrentRow != null)
                {
                    Table ownerTable = ownerBase.CurrentRow.OwnerTable;
                    if (ownerTable != null)
                    {
                        int rowIndex = ownerBase.CurrentRow.GetRowIndex();
                        if (ownerBase.CurrentCell == null)
                        {
                            this.method_54(ownerTable, rowIndex);
                        }
                        else
                        {
                            int curCellIndex = ownerBase.CurrentCell.CellFormat.CurCellIndex;
                            if (this.HasNoneStyle || (this.BorderType != BorderStyle.None))
                            {
                                this.method_53(ownerTable, ownerBase, rowIndex, curCellIndex);
                            }
                        }
                    }
                }
            }
        }

        private void method_53(Table A_0, Borders A_1, int A_2, int A_3)
        {
            if (A_2 != -1)
            {
                switch (this.BorderPosition)
                {
                    case BorderPositions.Left:
                        if ((A_3 > 0) && ((A_3 - 1) < A_0.Rows[A_2].Cells.Count))
                        {
                            TableCell cell4 = A_0[A_2, A_3 - 1];
                            if (!cell4.CellFormat.Borders.Right.HasNoneStyle)
                            {
                                return;
                            }
                            cell4.CellFormat.Borders.Right.method_51(this);
                        }
                        return;

                    case BorderPositions.Top:
                        if ((A_2 > 0) && (A_0.Rows[A_2 - 1].Cells.Count > A_3))
                        {
                            TableCell cell2 = A_0[A_2 - 1, A_3];
                            if (!cell2.CellFormat.Borders.Bottom.HasNoneStyle)
                            {
                                return;
                            }
                            cell2.CellFormat.Borders.Bottom.method_51(this);
                        }
                        return;

                    case BorderPositions.Right:
                        if ((A_3 + 1) < A_0.Rows[A_2].Cells.Count)
                        {
                            TableCell cell = A_0[A_2, A_3 + 1];
                            if (!cell.CellFormat.Borders.Left.HasNoneStyle)
                            {
                                return;
                            }
                            cell.CellFormat.Borders.Left.method_51(this);
                        }
                        return;

                    case BorderPositions.Bottom:
                        if (((A_2 + 1) < A_0.Rows.Count) && (A_0.Rows[A_2 + 1].Cells.Count > A_3))
                        {
                            TableCell cell3 = A_0[A_2 + 1, A_3];
                            if (cell3.CellFormat.Borders.Top.HasNoneStyle)
                            {
                                cell3.CellFormat.Borders.Top.method_51(this);
                            }
                        }
                        return;
                }
            }
        }

        private void method_54(Table A_0, int A_1)
        {
            switch (this.BorderPosition)
            {
                case BorderPositions.Top:
                    if (A_1 != 0)
                    {
                        TableRow row = A_0.Rows[A_1];
                        foreach (TableCell cell2 in row.Cells)
                        {
                            cell2.CellFormat.Borders.Top.BorderType = this.BorderType;
                            cell2.CellFormat.Borders.Top.Color = this.Color;
                            cell2.CellFormat.Borders.Top.LineWidth = this.LineWidth;
                        }
                    }
                    break;

                case BorderPositions.Right:
                    break;

                case BorderPositions.Bottom:
                    if (A_1 != (A_0.Rows.Count - 1))
                    {
                        TableRow row2 = A_0.Rows[A_1];
                        foreach (TableCell cell in row2.Cells)
                        {
                            cell.CellFormat.Borders.Bottom.BorderType = this.BorderType;
                            cell.CellFormat.Borders.Bottom.Color = this.Color;
                            cell.CellFormat.Borders.Bottom.LineWidth = this.LineWidth;
                        }
                    }
                    break;

                default:
                    return;
            }
        }

        private void method_55(BorderStyle A_0)
        {
            int num = 1;
            if ((A_0 != BorderStyle.None) && (A_0 != BorderStyle.Cleared))
            {
                if ((((BorderStyle) base[2]) == BorderStyle.None) && (A_0 != BorderStyle.Cleared))
                {
                    if (this.LineWidth == 0f)
                    {
                        this.LineWidth = 0.5f;
                    }
                    if (this.Color == System.Drawing.Color.Empty)
                    {
                        this.Color = System.Drawing.Color.Black;
                    }
                    this.HasNoneStyle = false;
                }
            }
            else
            {
                if (this.LineWidth != 0f)
                {
                    this.LineWidth = 0f;
                }
                if (A_0 == BorderStyle.None)
                {
                    this.HasNoneStyle = true;
                }
                else
                {
                    this.HasNoneStyle = false;
                }
            }
            if (((((BorderStyle) base[2]) == BorderStyle.None) || (((BorderStyle) base[2]) == BorderStyle.Cleared)) && ((A_0 != BorderStyle.Cleared) && (A_0 != BorderStyle.None)))
            {
                if (this.LineWidth == 0f)
                {
                    this.LineWidth = 0.5f;
                }
                if (((this.Color == System.Drawing.Color.Empty) || (this.Color == System.Drawing.Color.White)) || (this.Color.Name.ToLower() == BookmarkStart.b("䄦伨䴪䬬䤮地", num)))
                {
                    this.Color = System.Drawing.Color.Black;
                }
            }
            this.method_49(2, A_0);
            if (!this.IsRead)
            {
                this.method_52();
            }
        }

        internal void method_56(Border A_0)
        {
            if (A_0 != null)
            {
                if (A_0.BorderPosition != this.BorderPosition)
                {
                    A_0.BorderPosition = this.BorderPosition;
                }
                if (A_0.BorderType != this.BorderType)
                {
                    A_0.BorderType = this.BorderType;
                }
                if (A_0.Color != this.Color)
                {
                    A_0.Color = this.Color;
                }
                if (A_0.HasNoneStyle != this.HasNoneStyle)
                {
                    A_0.HasNoneStyle = this.HasNoneStyle;
                }
                if (A_0.IsRead != this.IsRead)
                {
                    A_0.IsRead = this.IsRead;
                }
                if (A_0.LineWidth != this.LineWidth)
                {
                    A_0.LineWidth = this.LineWidth;
                }
                if (A_0.Shadow != this.Shadow)
                {
                    A_0.Shadow = this.Shadow;
                }
                if (A_0.Space != this.Space)
                {
                    A_0.Space = this.Space;
                }
            }
        }

        internal bool method_57(Border A_0)
        {
            return (((this.LineWidth == A_0.LineWidth) && (this.Color == A_0.Color)) && (this.BorderType == A_0.BorderType));
        }

        protected override void OnChange(FormatBase format, int propertyKey)
        {
            base.OnChange(format, propertyKey);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 3;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("樨䐪䄬䀮䌰", 3)))
            {
                this.Color = reader.ReadColor(BookmarkStart.b("樨䐪䄬䀮䌰", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("攨䈪䌬䨮昰娲儴䌶儸", num)))
            {
                this.LineWidth = reader.ReadFloat(BookmarkStart.b("攨䈪䌬䨮昰娲儴䌶儸", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("欨䐪弬䬮吰䄲愴丶䤸帺", num)))
            {
                this.BorderType = (BorderStyle) reader.ReadEnum(BookmarkStart.b("欨䐪弬䬮吰䄲愴丶䤸帺", num), typeof(BorderStyle));
            }
            if (reader.HasAttribute(BookmarkStart.b("稨嬪䰬䰮吰", num)))
            {
                this.Space = reader.ReadFloat(BookmarkStart.b("稨嬪䰬䰮吰", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怨堪縬䜮倰圲娴䀶", num)))
            {
                this.Shadow = reader.ReadBoolean(BookmarkStart.b("怨堪縬䜮倰圲娴䀶", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x13;
            base.WriteXmlAttributes(writer);
            if (base.HasKey(1) && !this.Color.IsEmpty)
            {
                writer.WriteValue(BookmarkStart.b("稸吺儼倾㍀", num), this.Color);
            }
            if (base.HasKey(3))
            {
                writer.WriteValue(BookmarkStart.b("甸刺匼娾ᙀ⩂⅄㍆ⅈ", num), this.LineWidth);
            }
            if (base.HasKey(2))
            {
                writer.WriteValue(BookmarkStart.b("笸吺似嬾⑀ㅂᅄ㹆㥈⹊", num), this.BorderType);
            }
            if (base.HasKey(4))
            {
                writer.WriteValue(BookmarkStart.b("樸䬺尼尾⑀", num), this.Space);
            }
            if (base.HasKey(5))
            {
                writer.WriteValue(BookmarkStart.b("瀸䠺渼圾⁀❂⩄う", num), this.Shadow);
            }
        }

        internal BorderPositions BorderPosition
        {
            get
            {
                return this.borderPositions_0;
            }
            set
            {
                this.borderPositions_0 = value;
            }
        }

        public BorderStyle BorderType
        {
            get
            {
                return (BorderStyle) base[2];
            }
            set
            {
                this.method_55(value);
            }
        }

        public System.Drawing.Color Color
        {
            get
            {
                return (System.Drawing.Color) base[1];
            }
            set
            {
                this.method_49(1, value);
            }
        }

        internal string ColorShemeName
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }

        internal bool EqualsDefined
        {
            get
            {
                return (((this.Color.IsEmpty || (this.Color == System.Drawing.Color.Black)) && ((this.LineWidth == 0f) && (this.BorderType == BorderStyle.None))) && (this.Space == 0f));
            }
        }

        internal bool Frame
        {
            get
            {
                return (bool) base[7];
            }
            set
            {
                this.method_49(7, value);
                if (!this.IsRead)
                {
                    this.method_52();
                }
            }
        }

        internal bool HasNoneStyle
        {
            get
            {
                return (bool) base[6];
            }
            set
            {
                this.method_49(6, value);
            }
        }

        internal bool IsBorderDefined
        {
            get
            {
                return ((this.BorderType != BorderStyle.None) || (this.HasNoneStyle && base.HasKey(6)));
            }
        }

        internal bool IsChanged
        {
            [CompilerGenerated]
            get
            {
                return this.bool_3;
            }
            [CompilerGenerated]
            set
            {
                this.bool_3 = value;
            }
        }

        public override bool IsDefault
        {
            get
            {
                return base.IsDefault;
            }
        }

        internal bool IsRead
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

        public float LineWidth
        {
            get
            {
                return (float) base[3];
            }
            set
            {
                this.method_49(3, value);
                if (value == 0f)
                {
                    if ((this.BorderType != BorderStyle.None) && (this.BorderType != BorderStyle.Cleared))
                    {
                        this.BorderType = BorderStyle.None;
                    }
                }
                else if (this.BorderType == BorderStyle.None)
                {
                    this.BorderType = BorderStyle.Single;
                }
                if (!this.IsRead)
                {
                    this.method_52();
                }
            }
        }

        internal string ShadeTheme
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

        public bool Shadow
        {
            get
            {
                return (bool) base[5];
            }
            set
            {
                this.method_49(5, value);
                if (!this.IsRead)
                {
                    this.method_52();
                }
            }
        }

        public float Space
        {
            get
            {
                return (float) base[4];
            }
            set
            {
                this.method_49(4, value);
            }
        }

        internal enum BorderPositions
        {
            Bottom = 3,
            DiagonalDown = 7,
            DiagonalUp = 8,
            Horizontal = 6,
            Left = 0,
            Right = 2,
            Top = 1,
            Vertical = 5
        }
    }
}

