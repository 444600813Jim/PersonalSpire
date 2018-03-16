namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class TableCell : Body, ICompositeObject, Interface1
    {
        internal bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private byte byte_2;
        internal byte byte_3;
        private Spire.Doc.Formatting.CellFormat cellFormat_0;
        internal Spire.Doc.Formatting.CellFormat cellFormat_1;
        private Spire.Doc.CellWidthType cellWidthType_0;
        private Spire.Doc.Formatting.CharacterFormat characterFormat_0;
        internal Color color_0;
        internal float float_3;
        private FtsWidth ftsWidth_0;
        [CompilerGenerated]
        private int int_10;
        private int int_6;
        internal int int_7;
        private int int_8;
        internal int int_9;
        private Spire.Doc.Formatting.ParagraphFormat paragraphFormat_0;
        private RectangleF rectangleF_0;
        private short short_0;
        private string[] string_8;
        private string[] string_9;
        private StructureDocumentTagCell structureDocumentTagCell_0;
        internal Spire.Doc.TextureStyle textureStyle_0;

        public TableCell(IDocument document) : base((Document) document, null)
        {
            this.color_0 = Color.Empty;
            this.float_3 = float.MinValue;
            this.byte_3 = 1;
            this.int_8 = 1;
            this.int_9 = 1;
            this.short_0 = 1;
            this.ftsWidth_0 = FtsWidth.Auto;
            this.cellWidthType_0 = Spire.Doc.CellWidthType.Auto;
            this.cellFormat_0 = new Spire.Doc.Formatting.CellFormat();
            this.cellFormat_0.method_0(this);
            this.characterFormat_0 = new Spire.Doc.Formatting.CharacterFormat(base.Document);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_15(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_14(this);
        }

        public DocumentObject Clone()
        {
            return (DocumentObject) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            TableCell cell = (TableCell) base.CloneImpl();
            cell.cellFormat_0 = new Spire.Doc.Formatting.CellFormat();
            cell.cellFormat_0.method_0(cell);
            cell.cellFormat_0.ImportContainer(this.cellFormat_0);
            cell.cellFormat_0.Cellx = this.cellFormat_0.Cellx;
            cell.cellFormat_0.GridSpanEx = this.cellFormat_0.GridSpanEx;
            if (this.cellFormat_0.HasValue(2))
            {
                cell.cellFormat_0.Paddings.method_50(this.cellFormat_0.Paddings);
            }
            cell.characterFormat_0 = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            cell.characterFormat_0.ImportContainer(this.CharacterFormat);
            base.interface23_0 = null;
            return cell;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            int num = 0;
            int count = this.ChildObjects.Count;
            while (num < count)
            {
                this.ChildObjects[num].CloneRelationsTo(doc, nextOwner);
                num++;
            }
        }

        protected override void CreateLayoutInfo()
        {
            if (base.Items.Count == 0)
            {
                base.AddParagraph();
            }
            base.interface23_0 = new Class212(this);
            if (this is StructureDocumentTagCell)
            {
                (this as StructureDocumentTagCell).UpdateDataBinding();
            }
        }

        public int GetCellIndex()
        {
            return base.method_5();
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䠪䠬䌮崰Ḳ匴堶䬸嘺尼䬾", 5), this.CellFormat);
            base.XDLSHolder.AddElement(BookmarkStart.b("䠪䔬丮䌰刲嘴䌶尸䤺ြ夾⹀ㅂ⡄♆㵈", 5), this.CharacterFormat);
        }

        private int method_45(int A_0)
        {
            int num = 0;
            TableRow ownerRow = this.OwnerRow;
            for (int i = A_0; i > -1; i--)
            {
                num += ownerRow.Cells[i].GridSpan;
            }
            return num;
        }

        private TableCell method_46(TableRow A_0, int A_1)
        {
            TableCell cell2;
            int num = 0;
            using (IEnumerator enumerator = A_0.Cells.GetEnumerator())
            {
                TableCell current;
                while (enumerator.MoveNext())
                {
                    current = (TableCell) enumerator.Current;
                    num += current.GridSpan;
                    if (num == A_1)
                    {
                        goto Label_0036;
                    }
                }
                return null;
            Label_0036:
                cell2 = current;
            }
            return cell2;
        }

        internal List<string> method_47()
        {
            List<string> list = new List<string>();
            foreach (DocumentObject obj2 in this.ChildObjects)
            {
                if (obj2 is Paragraph)
                {
                    list.Add((obj2 as Paragraph).method_31());
                }
                else if (obj2 is Table)
                {
                    foreach (TableRow row in (obj2 as Table).Rows)
                    {
                        foreach (TableCell cell in row.Cells)
                        {
                            list.AddRange(cell.method_47());
                        }
                    }
                }
            }
            return list;
        }

        internal void method_48(Spire.Doc.Formatting.CellFormat A_0, Spire.Doc.Formatting.ParagraphFormat A_1, Spire.Doc.Formatting.CharacterFormat A_2)
        {
            this.CellFormat.ApplyBase(A_0);
            this.method_50(this, A_1, A_2);
        }

        private void method_49(Paragraph A_0, Spire.Doc.Formatting.ParagraphFormat A_1, Spire.Doc.Formatting.CharacterFormat A_2)
        {
            if (A_0 != null)
            {
                A_0.Format.TableStyleParagraphFormat = A_1;
                A_0.BreakCharacterFormat.TableStyleCharacterFormat = A_2;
                foreach (ParagraphBase base2 in A_0.Items)
                {
                    base2.CharacterFormat.TableStyleCharacterFormat = A_2;
                }
            }
        }

        private void method_50(Body A_0, Spire.Doc.Formatting.ParagraphFormat A_1, Spire.Doc.Formatting.CharacterFormat A_2)
        {
            for (int i = 0; i < A_0.Items.Count; i++)
            {
                DocumentObject obj2 = A_0.Items[i];
                if (obj2 is Paragraph)
                {
                    this.method_49(obj2 as Paragraph, A_1, A_2);
                }
                else if (obj2 is StructureDocumentTag)
                {
                    this.method_50((obj2 as StructureDocumentTag).SDTContent, A_1, A_2);
                }
            }
        }

        private void method_51()
        {
            if (this.CellFormat != null)
            {
                this.byte_3 = (byte) this.CellFormat.WidthUnit;
            }
        }

        private void method_52()
        {
            if (this.CellFormat.OwnerBase != this)
            {
                this.CellFormat.method_0(this);
            }
        }

        internal bool method_53()
        {
            return this.method_54(this);
        }

        private bool method_54(Body A_0)
        {
            if (A_0.ChildObjects.Count <= 0)
            {
                return false;
            }
            DocumentObject firstItem = A_0.ChildObjects.FirstItem;
            if (firstItem is Paragraph)
            {
                return (firstItem as Paragraph).Format.KeepFollow;
            }
            if (firstItem is Table)
            {
                return (firstItem as Table).method_72(0);
            }
            return ((firstItem is StructureDocumentTag) && this.method_54((firstItem as StructureDocumentTag).SDTContent));
        }

        internal Paragraph method_55()
        {
            if (this.ChildObjects.Count == 0)
            {
                return null;
            }
            if (this.ChildObjects.FirstItem is Table)
            {
                TableRow firstItem = (this.ChildObjects.FirstItem as Table).Rows.FirstItem as TableRow;
                if (firstItem != null)
                {
                    TableCell cell = firstItem.Cells.FirstItem as TableCell;
                    if (cell != null)
                    {
                        return cell.method_55();
                    }
                }
                return null;
            }
            if (!(this.ChildObjects[0] is StructureDocumentTag))
            {
                return (this.ChildObjects.FirstItem as Paragraph);
            }
            if (this.ChildObjects[0].ChildObjects.Count == 0)
            {
                return null;
            }
            if (this.ChildObjects[0].ChildObjects[0] is Table)
            {
                return (this.ChildObjects[0].ChildObjects[0] as Table).Rows[0].Cells[0].method_55();
            }
            return (this.ChildObjects[0].ChildObjects[0] as Paragraph);
        }

        internal ParagraphBase method_56()
        {
            if (this.ChildObjects.Count != 0)
            {
                Paragraph paragraph = this.method_55();
                if (paragraph != null)
                {
                    return (paragraph.ChildObjects.FirstItem as ParagraphBase);
                }
            }
            return null;
        }

        internal Paragraph method_57()
        {
            if (this.ChildObjects.Count != 0)
            {
                if (!(this.ChildObjects.LastItem is Table))
                {
                    return (this.ChildObjects.LastItem as Paragraph);
                }
                TableRow lastItem = (this.ChildObjects.LastItem as Table).Rows.LastItem as TableRow;
                if (lastItem != null)
                {
                    TableCell cell = lastItem.Cells.LastItem as TableCell;
                    if (cell != null)
                    {
                        return cell.method_57();
                    }
                }
            }
            return null;
        }

        internal ParagraphBase method_58()
        {
            if (this.ChildObjects.Count != 0)
            {
                Paragraph paragraph = this.method_57();
                if (paragraph != null)
                {
                    return (paragraph.ChildObjects.LastItem as ParagraphBase);
                }
            }
            return null;
        }

        internal DocumentObject method_59()
        {
            DocumentObject lastChild = base.LastChild;
            if (((lastChild == null) || (lastChild is Paragraph)) || (lastChild is Table))
            {
                return lastChild;
            }
            if (lastChild is StructureDocumentTagCell)
            {
                return (lastChild as StructureDocumentTagCell).method_59();
            }
            if (lastChild is StructureDocumentTag)
            {
                return this.method_60((lastChild as StructureDocumentTag).SDTContent);
            }
            return null;
        }

        private DocumentObject method_60(Body A_0)
        {
            if (A_0 != null)
            {
                DocumentObject lastChild = A_0.LastChild;
                if (((lastChild == null) || (lastChild is Paragraph)) || (lastChild is Table))
                {
                    return lastChild;
                }
                if (lastChild is StructureDocumentTag)
                {
                    this.method_60((lastChild as StructureDocumentTag).SDTContent);
                }
            }
            return null;
        }

        internal BodyRegion method_61()
        {
            if (base.NextSibling != null)
            {
                TableCell nextSibling = base.NextSibling as TableCell;
                if (nextSibling.Items.Count > 0)
                {
                    return nextSibling.Items[0];
                }
                return nextSibling.method_61();
            }
            if (this.OwnerRow == null)
            {
                return null;
            }
            if (this.OwnerRow.NextSibling == null)
            {
                if (this.OwnerRow.OwnerTable != null)
                {
                    return this.OwnerRow.OwnerTable.GetNextTextBodyItem();
                }
                return null;
            }
            TableRow ownerRow = this.OwnerRow;
            while (ownerRow.NextSibling != null)
            {
                ownerRow = ownerRow.NextSibling as TableRow;
                foreach (TableCell cell in ownerRow.Cells)
                {
                    if (cell.Items.Count > 0)
                    {
                        return cell.Items[0];
                    }
                }
            }
            return this.OwnerRow.OwnerTable.GetNextTextBodyItem();
        }

        internal void method_62()
        {
            base.method_28();
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
            if (this.cellFormat_0 != null)
            {
                this.cellFormat_0.Close();
                this.cellFormat_0 = null;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 14;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("挳張尷丹吻", 14)))
            {
                this.Width = reader.ReadFloat(BookmarkStart.b("挳張尷丹吻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("爳夵䨷弹缻儽ⰿⵁ㙃", num)))
            {
                this.ForeColor = reader.ReadColor(BookmarkStart.b("爳夵䨷弹缻儽ⰿⵁ㙃", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怳匵䀷丹䤻䰽┿", num)))
            {
                this.TextureStyle = (Spire.Doc.TextureStyle) reader.ReadEnum(BookmarkStart.b("怳匵䀷丹䤻䰽┿", num), typeof(Spire.Doc.TextureStyle));
            }
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.interface45_0 = null;
            }
            this.float_3 = float.MinValue;
        }

        public void SetCellWidth(float width, Spire.Doc.CellWidthType widthType)
        {
            if (widthType == Spire.Doc.CellWidthType.Auto)
            {
                this.Width = 0f;
            }
            else if (widthType == Spire.Doc.CellWidthType.Point)
            {
                this.Width = width;
            }
            else if (widthType == Spire.Doc.CellWidthType.Percentage)
            {
                this.Width = 0f;
                this.Scaling = width;
            }
            this.CellWidthType = widthType;
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            dc.vmethod_3(this, ltWidget);
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
            dc.vmethod_4(this, layoutedWidget);
        }

        public void SplitCell(int columnNum, int rowNum)
        {
            columnNum = (columnNum < 1) ? 1 : columnNum;
            rowNum = (rowNum < 1) ? 1 : rowNum;
            TableRow ownerRow = this.OwnerRow;
            Table ownerTable = ownerRow.OwnerTable;
            int cellIndex = this.GetCellIndex();
            int rowIndex = ownerRow.GetRowIndex();
            int num5 = this.method_45(cellIndex);
            if (columnNum > 1)
            {
                int num4 = 0;
                int count = ownerTable.Rows.Count;
                while (num4 < count)
                {
                    if (rowIndex != num4)
                    {
                        TableCell cell = this.method_46(ownerTable.Rows[num4], num5);
                        cell.GridSpan = (short) ((cell.GridSpan - 1) + columnNum);
                    }
                    num4++;
                }
                switch (this.WidthType)
                {
                    case FtsWidth.None:
                    case FtsWidth.Auto:
                        for (int i = columnNum; i > 1; i--)
                        {
                            ownerRow.method_21(cellIndex, true);
                        }
                        break;

                    case FtsWidth.Percentage:
                    {
                        float num10 = this.Scaling / ((float) columnNum);
                        for (int j = columnNum; j > 1; j--)
                        {
                            TableCell cell3 = ownerRow.method_21(cellIndex, true);
                            cell3.Scaling = num10;
                            cell3.WidthType = FtsWidth.Percentage;
                        }
                        this.Scaling = num10;
                        break;
                    }
                    case FtsWidth.Point:
                    {
                        float num2 = this.Width / ((float) columnNum);
                        for (int k = columnNum; k > 1; k--)
                        {
                            TableCell cell2 = ownerRow.method_21(cellIndex, true);
                            cell2.Width = num2;
                            cell2.WidthType = FtsWidth.Point;
                        }
                        this.Width = num2;
                        break;
                    }
                }
            }
            if (rowNum > 1)
            {
                for (int m = rowNum; m > 1; m--)
                {
                    ownerTable.Rows.Insert(rowIndex, ownerRow.Clone());
                }
                int columnIndex = 0;
                int num8 = ownerRow.Cells.Count;
                while (columnIndex < num8)
                {
                    if ((columnIndex < cellIndex) || (columnIndex > ((cellIndex + columnNum) - 1)))
                    {
                        ownerTable.ApplyVerticalMerge(columnIndex, rowIndex, (rowIndex + rowNum) - 1);
                    }
                    columnIndex++;
                }
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x13;
            base.WriteXmlAttributes(writer);
            if (!this.cellFormat_0.OwnerRowFormat.method_57())
            {
                if (this.IsFixedWidth)
                {
                    writer.WriteValue(BookmarkStart.b("游刺夼䬾⥀", num), this.Width);
                }
                if (this.ForeColor != Color.Empty)
                {
                    writer.WriteValue(BookmarkStart.b("缸吺似娾ɀⱂ⥄⡆㭈", num), this.ForeColor);
                }
                writer.WriteValue(BookmarkStart.b("洸帺䔼䬾㑀ㅂ⁄", num), this.TextureStyle);
            }
        }

        internal RectangleF Bounds
        {
            get
            {
                return this.rectangleF_0;
            }
            set
            {
                this.rectangleF_0 = value;
            }
        }

        public Spire.Doc.Formatting.CellFormat CellFormat
        {
            get
            {
                return this.cellFormat_0;
            }
            internal set
            {
                this.cellFormat_0 = value;
                this.cellFormat_0.method_0(this);
            }
        }

        public Spire.Doc.CellWidthType CellWidthType
        {
            get
            {
                switch (this.CellFormat.WidthUnit)
                {
                    case FtsWidth.Percentage:
                        return Spire.Doc.CellWidthType.Percentage;

                    case FtsWidth.Point:
                        return Spire.Doc.CellWidthType.Point;
                }
                return Spire.Doc.CellWidthType.Auto;
            }
            set
            {
                switch (value)
                {
                    case Spire.Doc.CellWidthType.Auto:
                        this.WidthType = FtsWidth.Auto;
                        this.CellFormat.IsAutoResized = true;
                        return;

                    case Spire.Doc.CellWidthType.Percentage:
                        this.WidthType = FtsWidth.Percentage;
                        return;

                    case Spire.Doc.CellWidthType.Point:
                        this.WidthType = FtsWidth.Point;
                        return;
                }
            }
        }

        internal Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return this.characterFormat_0;
            }
        }

        internal int Colspan
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

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.TableCell;
            }
        }

        internal bool DontVertAlignCellWithSp
        {
            get
            {
                return base.Document.Settings.method_5().method_0(CompatibilityOptions.DontVertAlignCellWithSp);
            }
        }

        internal Color ForeColor
        {
            get
            {
                return this.CellFormat.ForeColor;
            }
            set
            {
                this.CellFormat.ForeColor = value;
            }
        }

        public short GridSpan
        {
            get
            {
                return this.CellFormat.GridSpan;
            }
            internal set
            {
                this.CellFormat.GridSpan = value;
                this.int_7 = value;
            }
        }

        internal short GridSpanEx
        {
            get
            {
                return this.CellFormat.GridSpanEx;
            }
        }

        internal bool HasShape
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

        internal int HTMLColIndex
        {
            [CompilerGenerated]
            get
            {
                return this.int_10;
            }
            [CompilerGenerated]
            set
            {
                this.int_10 = value;
            }
        }

        internal bool IsFixedWidth
        {
            get
            {
                return (this.Width > -1f);
            }
        }

        internal float LayoutWidth
        {
            get
            {
                if (this.float_3 != float.MinValue)
                {
                    return this.float_3;
                }
                if ((this.OwnerRow.OwnerTable.TableFormat.CellSpacingEx == -1f) || (this.WidthEx <= 0f))
                {
                    return this.WidthEx;
                }
                int cellIndex = this.GetCellIndex();
                if ((cellIndex != 0) && (cellIndex != (this.OwnerRow.ChildObjects.Count - 1)))
                {
                    return (this.WidthEx + (this.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 2f));
                }
                return (this.WidthEx + ((this.OwnerRow.OwnerTable.TableFormat.CellSpacingEx * 1.5f) * 2f));
            }
            set
            {
                this.float_3 = value;
            }
        }

        public TableRow OwnerRow
        {
            get
            {
                return (base.Owner as TableRow);
            }
        }

        internal Spire.Doc.Formatting.ParagraphFormat ParagraphFormat
        {
            get
            {
                return this.paragraphFormat_0;
            }
            set
            {
                this.paragraphFormat_0 = value;
            }
        }

        public float Scaling
        {
            get
            {
                if (this.CellFormat.WidthUnit == FtsWidth.Percentage)
                {
                    return this.CellFormat.CellWidth;
                }
                return 100f;
            }
            set
            {
                this.CellFormat.WidthUnit = FtsWidth.Percentage;
                this.CellFormat.CellWidth = value;
            }
        }

        internal Spire.Doc.TextureStyle TextureStyle
        {
            get
            {
                return this.CellFormat.TextureStyle;
            }
            set
            {
                this.CellFormat.TextureStyle = value;
            }
        }

        internal Spire.Doc.Formatting.CellFormat TrackCellFormat
        {
            get
            {
                if (this.cellFormat_1 == null)
                {
                    this.cellFormat_1 = new Spire.Doc.Formatting.CellFormat();
                    this.cellFormat_1.method_0(this);
                }
                return this.cellFormat_1;
            }
        }

        protected override IDocumentObjectCollection WidgetCollection
        {
            get
            {
                return base.m_bodyItems;
            }
        }

        public float Width
        {
            get
            {
                return this.CellFormat.CellWidth;
            }
            set
            {
                this.CellFormat.CellWidth = value;
                if ((!base.Document.bool_3 && (this.OwnerRow != null)) && (this.OwnerRow.OwnerTable != null))
                {
                    this.OwnerRow.OwnerTable.bool_6 = false;
                }
            }
        }

        private float WidthEx
        {
            get
            {
                return this.CellFormat.CellWidthEx;
            }
        }

        internal FtsWidth WidthType
        {
            get
            {
                return this.CellFormat.PreferredWidth.method_53();
            }
            set
            {
                this.CellFormat.PreferredWidth.method_54(value);
            }
        }
    }
}

