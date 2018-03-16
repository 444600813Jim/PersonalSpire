namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Formatting;
    using System;
    using System.Drawing;
    using System.Reflection;

    public class Borders : WordAttrCollection
    {
        public const int BottomKey = 3;
        public const int DiagonalDownKey = 7;
        public const int DiagonalUpKey = 8;
        private float[] float_2;
        private float float_3;
        public const int HorizontalKey = 6;
        public const int LeftKey = 1;
        public const int RightKey = 4;
        private TableCell tableCell_0;
        private TableRow tableRow_0;
        public const int TopKey = 2;
        public const int VerticalKey = 5;

        public Borders()
        {
            this.method_52();
        }

        internal Borders(Borders A_0) : this()
        {
            if (!A_0.IsDefault)
            {
                base.ImportContainer(A_0);
            }
        }

        internal Borders(FormatBase A_0, int A_1) : base(A_0, A_1)
        {
            this.method_52();
        }

        internal override void ApplyBase(FormatBase baseFormat)
        {
            base.ApplyBase(baseFormat);
            this.Left.ApplyBase((baseFormat as Borders).Left);
            this.Right.ApplyBase((baseFormat as Borders).Right);
            this.Top.ApplyBase((baseFormat as Borders).Top);
            this.Bottom.ApplyBase((baseFormat as Borders).Bottom);
            this.Horizontal.ApplyBase((baseFormat as Borders).Horizontal);
            this.Vertical.ApplyBase((baseFormat as Borders).Vertical);
            this.DiagonalDown.ApplyBase((baseFormat as Borders).DiagonalDown);
            this.DiagonalUp.ApplyBase((baseFormat as Borders).DiagonalUp);
        }

        internal override void ApplyProperty()
        {
            if (base.m_propsUpdateFlags != null)
            {
                base.m_propsUpdateFlags.Clear();
            }
            Type type = typeof(Borders);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                int num2 = (int) info.GetValue(info.FieldType);
                base.method_31(num2);
            }
        }

        internal override void ClearAttrs()
        {
            if (base.HasKey(1))
            {
                this.Left.ClearAttrs();
                this.Remove(1);
            }
            if (base.HasKey(2))
            {
                this.Top.ClearAttrs();
                this.Remove(2);
            }
            if (base.HasKey(3))
            {
                this.Bottom.ClearAttrs();
                this.Remove(3);
            }
            if (base.HasKey(4))
            {
                this.Right.ClearAttrs();
                this.Remove(4);
            }
            if (base.HasKey(5))
            {
                this.Vertical.ClearAttrs();
                this.Remove(5);
            }
            if (base.HasKey(6))
            {
                this.Horizontal.ClearAttrs();
                this.Remove(6);
            }
            if (base.HasKey(7))
            {
                this.DiagonalDown.ClearAttrs();
                this.Remove(7);
            }
            if (base.HasKey(8))
            {
                this.DiagonalUp.ClearAttrs();
                this.Remove(8);
            }
        }

        public Borders Clone()
        {
            return (Borders) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            return new Borders(this);
        }

        internal override void CopyPropertiesTo(FormatBase destFormat)
        {
            Borders borders = destFormat as Borders;
            if (base.HasKey(1))
            {
                this.Left.CopyPropertiesTo(borders.Left);
            }
            if (base.HasKey(4))
            {
                this.Right.CopyPropertiesTo(borders.Right);
            }
            if (base.HasKey(2))
            {
                this.Top.CopyPropertiesTo(borders.Top);
            }
            if (base.HasKey(3))
            {
                this.Bottom.CopyPropertiesTo(borders.Bottom);
            }
            if (base.HasKey(5))
            {
                this.Vertical.CopyPropertiesTo(borders.Vertical);
            }
            if (base.HasKey(6))
            {
                this.Horizontal.CopyPropertiesTo(borders.Horizontal);
            }
            if (base.HasKey(7))
            {
                this.DiagonalDown.CopyPropertiesTo(borders.DiagonalDown);
            }
            if (base.HasKey(8))
            {
                this.DiagonalUp.CopyPropertiesTo(borders.DiagonalUp);
            }
        }

        protected internal override void EnsureComposites()
        {
            base.EnsureComposites(new int[] { 1, 4, 2, 3, 5, 6, 7, 8 });
        }

        protected override FormatBase GetDefComposite(int key)
        {
            switch (key)
            {
                case 1:
                    return base.GetDefComposite(1, new Border(this, 1));

                case 2:
                    return base.GetDefComposite(2, new Border(this, 2));

                case 3:
                    return base.GetDefComposite(3, new Border(this, 3));

                case 4:
                    return base.GetDefComposite(4, new Border(this, 4));

                case 5:
                    return base.GetDefComposite(5, new Border(this, 5));

                case 6:
                    return base.GetDefComposite(6, new Border(this, 6));

                case 7:
                    return base.GetDefComposite(7, new Border(this, 7));

                case 8:
                    return base.GetDefComposite(8, new Border(this, 8));
            }
            return null;
        }

        protected override object GetDefValue(int key)
        {
            return this.GetDefComposite(key);
        }

        protected override void InitXDLSHolder()
        {
            int num = 0x12;
            if (this.IsDefault)
            {
                base.XDLSHolder.SkipMe = true;
            }
            base.XDLSHolder.AddElement(BookmarkStart.b("稷唹䠻䨽⼿⽁", num), this.Bottom);
            base.XDLSHolder.AddElement(BookmarkStart.b("氷唹䰻", num), this.Top);
            base.XDLSHolder.AddElement(BookmarkStart.b("琷弹娻䨽", num), this.Left);
            base.XDLSHolder.AddElement(BookmarkStart.b("樷匹嬻嘽㐿", num), this.Right);
            base.XDLSHolder.AddElement(BookmarkStart.b("瀷唹主圽㨿ⵁ⩃㉅⥇♉", num), this.Horizontal);
            base.XDLSHolder.AddElement(BookmarkStart.b("渷弹主䨽⤿⅁╃⩅", num), this.Vertical);
        }

        internal Borders method_49()
        {
            Borders borders = new Borders(this);
            this.method_50(this.Top, borders.Top);
            this.method_50(this.Right, borders.Right);
            this.method_50(this.Bottom, borders.Bottom);
            this.method_50(this.Left, borders.Left);
            return borders;
        }

        private void method_50(Border A_0, Border A_1)
        {
            if (A_0.HasKey(2))
            {
                A_1.BorderType = A_0.BorderType;
            }
            if (A_0.HasKey(3))
            {
                A_1.LineWidth = A_0.LineWidth;
            }
            if (A_0.HasKey(1))
            {
                A_1.Color = A_0.Color;
            }
            if (A_0.HasKey(4))
            {
                A_1.Space = A_0.Space;
            }
        }

        private void method_51(float A_0)
        {
            if ((base.ParentFormat is RowFormat) || (base.ParentFormat is CellFormat))
            {
                if (base.ParentFormat is RowFormat)
                {
                    (base.ParentFormat as RowFormat).Paddings.All = A_0;
                }
                else
                {
                    (base.ParentFormat as CellFormat).Paddings.All = A_0;
                }
            }
        }

        private void method_52()
        {
        }

        internal void method_53(Borders A_0)
        {
            this.Left.method_56(A_0.Left);
            this.Right.method_56(A_0.Right);
            this.Top.method_56(A_0.Top);
            this.Bottom.method_56(A_0.Bottom);
            this.Horizontal.method_56(A_0.Horizontal);
            this.Vertical.method_56(A_0.Vertical);
            this.DiagonalDown.method_56(A_0.DiagonalDown);
            this.DiagonalUp.method_56(A_0.DiagonalUp);
        }

        protected override void OnChange(FormatBase format, int propertyKey)
        {
            base.OnChange(format, propertyKey);
        }

        public BorderStyle BorderType
        {
            set
            {
                this.Left.BorderType = this.Right.BorderType = this.Top.BorderType = this.Bottom.BorderType = value;
                this.Vertical.BorderType = this.Horizontal.BorderType = value;
            }
        }

        public Border Bottom
        {
            get
            {
                return (base[3] as Border);
            }
        }

        public System.Drawing.Color Color
        {
            set
            {
                this.Left.Color = this.Right.Color = this.Top.Color = this.Bottom.Color = value;
            }
        }

        internal string ColorShemeName
        {
            set
            {
                this.Left.ColorShemeName = this.Right.ColorShemeName = this.Top.ColorShemeName = this.Bottom.ColorShemeName = value;
            }
        }

        internal TableCell CurrentCell
        {
            get
            {
                if (((this.tableCell_0 == null) && (base.OwnerBase != null)) && (base.OwnerBase is CellFormat))
                {
                    CellFormat ownerBase = base.OwnerBase as CellFormat;
                    if (ownerBase.OwnerBase != null)
                    {
                        this.tableCell_0 = ownerBase.OwnerBase as TableCell;
                    }
                }
                return this.tableCell_0;
            }
        }

        internal TableRow CurrentRow
        {
            get
            {
                if (this.tableRow_0 == null)
                {
                    if (this.CurrentCell != null)
                    {
                        this.tableRow_0 = this.CurrentCell.OwnerRow;
                    }
                    else if ((base.OwnerBase != null) && (base.OwnerBase is TableRow))
                    {
                        return null;
                    }
                }
                return this.tableRow_0;
            }
            set
            {
                this.tableRow_0 = value;
            }
        }

        internal Border DiagonalDown
        {
            get
            {
                return (base[7] as Border);
            }
        }

        internal Border DiagonalUp
        {
            get
            {
                return (base[8] as Border);
            }
        }

        internal bool HasBorderTypeValue
        {
            get
            {
                if ((!this.Left.HasValue(2) && !this.Top.HasValue(2)) && !this.Right.HasValue(2))
                {
                    return this.Bottom.HasValue(2);
                }
                return true;
            }
        }

        public Border Horizontal
        {
            get
            {
                return (base[6] as Border);
            }
        }

        public override bool IsDefault
        {
            get
            {
                return ((((this.Left.IsDefault && this.Top.IsDefault) && (this.Right.IsDefault && this.Bottom.IsDefault)) && ((this.Horizontal.IsDefault && this.Vertical.IsDefault) && (this.DiagonalDown.IsDefault && this.DiagonalUp.IsDefault))) || base.IsDefault);
            }
            internal set
            {
                base.IsDefault = value;
            }
        }

        public bool IsShadow
        {
            set
            {
                this.Left.Shadow = this.Right.Shadow = this.Top.Shadow = this.Bottom.Shadow = value;
            }
        }

        public Border Left
        {
            get
            {
                return (base[1] as Border);
            }
        }

        public float LineWidth
        {
            set
            {
                this.Left.LineWidth = this.Right.LineWidth = this.Top.LineWidth = this.Bottom.LineWidth = value;
            }
        }

        public bool NoBorder
        {
            get
            {
                return ((((this.Left.BorderType == BorderStyle.None) && (this.Right.BorderType == BorderStyle.None)) && (this.Top.BorderType == BorderStyle.None)) && (this.Bottom.BorderType == BorderStyle.None));
            }
        }

        internal bool NoBorderEx
        {
            get
            {
                return (((((this.Left.BorderType == BorderStyle.None) && (this.Right.BorderType == BorderStyle.None)) && ((this.Top.BorderType == BorderStyle.None) && (this.Bottom.BorderType == BorderStyle.None))) && (this.Horizontal.BorderType == BorderStyle.None)) && (this.Vertical.BorderType == BorderStyle.None));
            }
        }

        public Border Right
        {
            get
            {
                return (base[4] as Border);
            }
        }

        public float Space
        {
            set
            {
                this.method_51(value);
            }
        }

        public Border Top
        {
            get
            {
                return (base[2] as Border);
            }
        }

        public Border Vertical
        {
            get
            {
                return (base[5] as Border);
            }
        }
    }
}

