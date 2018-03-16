namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;

    public class TableRow : DocumentBase, ICompositeObject, Interface1
    {
        private bool bool_10;
        private bool bool_11;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        internal bool bool_7;
        private bool bool_8;
        private bool bool_9;
        private byte byte_2;
        private byte[] byte_3;
        private CellCollection cellCollection_0;
        private Spire.Doc.Formatting.CharacterFormat characterFormat_0;
        private int[] int_2;
        private long[] long_3;
        private Spire.Doc.Formatting.RowFormat rowFormat_0;
        internal Spire.Doc.Formatting.RowFormat rowFormat_1;
        private TableRowHeightType tableRowHeightType_0;

        public TableRow(IDocument document) : base((Document) document, null)
        {
            this.bool_7 = true;
            this.cellCollection_0 = new CellCollection(this);
            this.characterFormat_0 = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            this.rowFormat_0 = new Spire.Doc.Formatting.RowFormat();
            this.rowFormat_0.method_0(this);
        }

        internal TableRow(IDocument A_0, Spire.Doc.Formatting.RowFormat A_1) : base((Document) A_0, null)
        {
            this.bool_7 = true;
            this.cellCollection_0 = new CellCollection(this);
            this.characterFormat_0 = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            this.rowFormat_0 = A_1;
            this.rowFormat_0.method_0(this);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_13(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_12(this);
        }

        public TableCell AddCell()
        {
            return this.AddCell(true);
        }

        public TableCell AddCell(bool isCopyFormat)
        {
            return this.method_21(-1, isCopyFormat);
        }

        public TableRow Clone()
        {
            return (TableRow) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            TableRow row = (TableRow) base.CloneImpl();
            row.characterFormat_0 = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            row.characterFormat_0.ImportContainer(this.CharacterFormat);
            row.rowFormat_0 = new Spire.Doc.Formatting.RowFormat(base.Document);
            row.rowFormat_0.ImportContainer(this.RowFormat);
            row.rowFormat_0.method_0(row);
            if (this.DataArray != null)
            {
                row.byte_3 = new byte[this.DataArray.Length];
                this.DataArray.CopyTo(row.byte_3, 0);
            }
            row.cellCollection_0 = new CellCollection(row);
            this.Cells.method_12(row.cellCollection_0);
            base.interface23_0 = null;
            return row;
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
            base.interface23_0 = new Class211((this.HeightType == TableRowHeightType.Exactly) && (((this.Height >= 0f) ? ((double) this.Height) : ((double) (-1f * this.Height))) >= 0.05), this.Height);
            if (base.NextSibling is TableRow)
            {
                Paragraph paragraph = (base.NextSibling as TableRow).Cells[0].method_55();
                if (paragraph != null)
                {
                    base.interface23_0.imethod_29(paragraph.Format.PageBreakBefore);
                }
            }
            base.interface23_0.imethod_31(true);
            for (int i = 0; i < this.Cells.Count; i++)
            {
                if (this.Cells[i].CellFormat.TextDirection == TextDirection.TopToBottom)
                {
                    base.interface23_0.imethod_31(false);
                    break;
                }
            }
            this.method_40();
            Class211 class2 = base.interface23_0 as Class211;
            Class211 class3 = (base.PreviousSibling != null) ? ((base.PreviousSibling as Interface1).imethod_0() as Class211) : null;
            if (class3 == null)
            {
                class2.method_102(0);
            }
            else
            {
                class2.method_102(class3.method_101() + 1);
            }
            if (this is StructureDocumentTagRow)
            {
                (this as StructureDocumentTagRow).UpdateDataBinding();
            }
        }

        public int GetRowIndex()
        {
            return base.method_5();
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("圳匵吷嘹伻", 14), this.Cells);
            base.XDLSHolder.AddElement(BookmarkStart.b("圳帵夷䠹崻崽㐿❁㙃歅⹇╉㹋⍍ㅏ♑", 14), this.CharacterFormat);
            base.XDLSHolder.AddElement(BookmarkStart.b("䀳圵娷嘹夻ጽ☿ⵁ㙃⭅⥇㹉", 14), this.RowFormat);
        }

        internal TableCell method_21(int A_0, bool A_1)
        {
            TableCell cell = new TableCell(base.Document);
            TableRow previousSibling = base.PreviousSibling as TableRow;
            TableCell cell2 = null;
            if ((previousSibling != null) && (previousSibling.Cells.Count > this.Cells.Count))
            {
                cell2 = previousSibling.Cells[this.Cells.Count];
            }
            if (A_1 && (cell2 != null))
            {
                cell.CellFormat.ImportContainer(cell2.CellFormat);
                cell.Width = cell2.Width;
                cell.CellFormat.Remove(0xf3c);
            }
            else if (A_1 && (cell2 == null))
            {
                cell.CellFormat.ImportContainer(this.rowFormat_0);
            }
            if ((A_0 > -1) && (A_0 < this.Cells.Count))
            {
                this.Cells.Insert(A_0, cell);
                return cell;
            }
            this.Cells.Add(cell);
            return cell;
        }

        internal bool method_22()
        {
            for (int i = 0; i < this.Cells.Count; i++)
            {
                if (this.Cells[i].WidthType == FtsWidth.Auto)
                {
                    return true;
                }
            }
            return false;
        }

        internal int method_23()
        {
            int num = 0;
            for (int i = 0; i < this.Cells.Count; i++)
            {
                num += this.Cells[i].GridSpanEx;
            }
            num += this.RowFormat.GridAfter;
            return (num + this.RowFormat.GridBefore);
        }

        internal TableCell method_24(int A_0)
        {
            if (A_0 <= 0)
            {
                return this.Cells[0];
            }
            TableCell cell = null;
            int num = (this.RowFormat.GridBefore > 0) ? this.RowFormat.GridBefore : 0;
            using (IEnumerator enumerator = this.Cells.GetEnumerator())
            {
                TableCell current;
                while (enumerator.MoveNext())
                {
                    current = (TableCell) enumerator.Current;
                    num += current.GridSpan;
                    if (num == A_0)
                    {
                        goto Label_0064;
                    }
                }
                return cell;
            Label_0064:
                cell = current;
            }
            return cell;
        }

        internal int method_25(TableCell A_0)
        {
            int num = (this.RowFormat.GridBefore > 0) ? this.RowFormat.GridBefore : 0;
            foreach (TableCell cell in this.Cells)
            {
                num += cell.GridSpan;
                if (A_0 == cell)
                {
                    return num;
                }
            }
            return num;
        }

        internal void method_26()
        {
            Table ownerTable = this.OwnerTable;
            int num = 0;
            bool flag = true;
            float num2 = this.method_28(ref num, ref flag);
            if ((ownerTable._ColumnWidths.Count > 0) && (ownerTable._ColumnWidths.Count == num))
            {
                float num3 = this.method_27(ownerTable._ColumnWidths);
                if ((num2 <= num3) || ownerTable.IsInCell)
                {
                    Spire.Doc.Formatting.RowFormat rowFormat = this.RowFormat;
                    Spire.Doc.Formatting.RowFormat tableFormat = ownerTable.TableFormat;
                    ArrayList list = ownerTable._ColumnWidths;
                    int num8 = (rowFormat.GridBefore >= 0) ? rowFormat.GridBefore : 0;
                    this.method_29(list, rowFormat);
                    if (list.Count > 0)
                    {
                        int num6 = num8;
                        if (flag)
                        {
                            foreach (TableCell cell in this.Cells)
                            {
                                CellFormat cellFormat = cell.CellFormat;
                                int num4 = (cell.GridSpan >= 1) ? cell.GridSpan : 1;
                                int num5 = 0;
                                int num7 = Math.Min(num6 + num4, list.Count);
                                while (num6 < num7)
                                {
                                    num5 += (int) list[num6++];
                                }
                                cellFormat.CellWidthEx = ((float) num5) / 20f;
                            }
                        }
                    }
                }
            }
        }

        private float method_27(ArrayList A_0)
        {
            float num = 0f;
            for (int i = 0; i < A_0.Count; i++)
            {
                num += (int) A_0[i];
            }
            return num;
        }

        private float method_28(ref int A_0, ref bool A_1)
        {
            float num = 0f;
            foreach (TableCell cell in this.Cells)
            {
                num += cell.Width * 20f;
                A_0 += cell.GridSpan;
                if ((cell.WidthType != FtsWidth.Point) && A_1)
                {
                    A_1 = false;
                }
            }
            return num;
        }

        private void method_29(ArrayList A_0, Spire.Doc.Formatting.RowFormat A_1)
        {
            int num3 = (A_1.GridBefore >= 0) ? A_1.GridBefore : 0;
            int num = 0;
            for (int i = 0; i < num3; i++)
            {
                num += (int) A_0[i];
            }
            A_1.GridBeforeWidth.method_50((float) num);
        }

        internal void method_30()
        {
            short cellx = (base.LastChild as TableCell).CellFormat.Cellx;
            short num2 = this.method_31();
            if ((cellx > num2) && (this.RowFormat.CellSpacingEx == -1f))
            {
                for (int i = 0; i < this.Cells.Count; i++)
                {
                    TableCell cell = this.Cells[i];
                    if (cell.WidthType == FtsWidth.Point)
                    {
                        cell.Width = ((float) this.method_32(i)) / 20f;
                    }
                }
            }
        }

        private short method_31()
        {
            short num = 0;
            foreach (TableCell cell in this.Cells)
            {
                num = (short) (num + ((short) Math.Round((double) (cell.Width * 20f))));
            }
            return num;
        }

        private short method_32(int A_0)
        {
            int[] cellXList = this.RowFormat.CellXList;
            if (A_0 > (cellXList.Length - 2))
            {
                return (short) this.Cells[A_0].CellFormat.TwipCellWidth;
            }
            return (short) (cellXList[A_0 + 1] - cellXList[A_0]);
        }

        internal void method_33(FormatBase A_0, int A_1)
        {
            if (A_0 is Spire.Doc.Formatting.RowFormat)
            {
                Spire.Doc.Formatting.RowFormat format = A_0 as Spire.Doc.Formatting.RowFormat;
                switch (A_1)
                {
                    case 1:
                    {
                        TextureStyle textureStyle = format.TextureStyle;
                        foreach (TableCell cell in this.Cells)
                        {
                            if (!cell.CellFormat.HasKey(cell.CellFormat.Shading.GetFullKey(1)))
                            {
                                cell.CellFormat.TextureStyle = textureStyle;
                            }
                        }
                        return;
                    }
                    case 2:
                        return;

                    case 3:
                    {
                        Color backColor = format.BackColor;
                        foreach (TableCell cell2 in this.Cells)
                        {
                            if (!cell2.CellFormat.HasKey(cell2.CellFormat.Shading.GetFullKey(3)))
                            {
                                cell2.CellFormat.BackColor = backColor;
                            }
                        }
                        return;
                    }
                }
            }
        }

        private void method_34()
        {
            if (this.RowFormat.OwnerBase != this)
            {
                this.RowFormat.method_0(this);
            }
        }

        internal void method_35()
        {
            if (this.OwnerTable != null)
            {
                this.OwnerTable.bool_6 = false;
            }
        }

        internal void method_36()
        {
            if ((this.cellCollection_0 != null) && (this.cellCollection_0.Count > 0))
            {
                int count = this.cellCollection_0.Count;
                TableCell cell = null;
                for (int i = 0; i < count; i++)
                {
                    cell = this.cellCollection_0[i];
                    cell.method_62();
                    cell = null;
                }
                this.cellCollection_0.Clear();
                this.cellCollection_0 = null;
            }
            if (this.rowFormat_0 != null)
            {
                this.rowFormat_0.Close();
                this.rowFormat_0 = null;
            }
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
        }

        internal bool method_37()
        {
            bool flag = true;
            if (this.Cells.Count > 1)
            {
                FtsWidth widthUnit = this.Cells[0].CellFormat.WidthUnit;
                if (this.Cells[0].WidthType == FtsWidth.Auto)
                {
                    this.bool_8 = true;
                }
                else if (this.Cells[0].WidthType == FtsWidth.Percentage)
                {
                    this.bool_9 = true;
                }
                int num = 1;
                int count = this.Cells.Count;
                while (num < count)
                {
                    if (flag && (this.Cells[num].CellFormat.WidthUnit != widthUnit))
                    {
                        flag = false;
                    }
                    if (this.Cells[num].WidthType == FtsWidth.Auto)
                    {
                        this.bool_8 = true;
                    }
                    else if (this.Cells[num].WidthType == FtsWidth.Percentage)
                    {
                        this.bool_9 = true;
                    }
                    num++;
                }
            }
            return flag;
        }

        private bool method_38()
        {
            bool flag;
            using (IEnumerator enumerator = this.Cells.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    TableCell current = (TableCell) enumerator.Current;
                    if (current.WidthType != FtsWidth.Point)
                    {
                        goto Label_0030;
                    }
                }
                return true;
            Label_0030:
                flag = false;
            }
            return flag;
        }

        internal void method_39(float A_0)
        {
            if (((this.Cells.Count > 0) && (A_0 > 0f)) && !this.IsSameWidthTypeOfCells)
            {
                List<TableCell> list2 = new List<TableCell>();
                List<TableCell> list3 = new List<TableCell>();
                List<TableCell> list = new List<TableCell>();
                List<TableCell> list4 = new List<TableCell>();
                foreach (TableCell cell2 in this.Cells)
                {
                    FtsWidth widthType = cell2.WidthType;
                    switch (widthType)
                    {
                        case FtsWidth.None:
                        case FtsWidth.Auto:
                            list3.Add(cell2);
                            break;

                        case FtsWidth.Percentage:
                            list.Add(cell2);
                            break;

                        case FtsWidth.Point:
                            list2.Add(cell2);
                            break;

                        default:
                            if (widthType == FtsWidth.ftsDxaSys)
                            {
                                list4.Add(cell2);
                            }
                            break;
                    }
                }
                if (list3.Count > 0)
                {
                    float num = A_0;
                    if (list2.Count > 0)
                    {
                        foreach (TableCell cell4 in list2)
                        {
                            num -= cell4.Width;
                        }
                    }
                    if (list.Count > 0)
                    {
                        foreach (TableCell cell in list)
                        {
                            num -= (cell.Scaling / 100f) * A_0;
                        }
                    }
                    if (list4.Count > 0)
                    {
                        foreach (TableCell cell3 in list4)
                        {
                            num -= cell3.Width / 20f;
                        }
                    }
                    float num3 = num / ((float) list3.Count);
                    int num2 = 0;
                    int count = list3.Count;
                    while (num2 < count)
                    {
                        if (list3[num2].Width == 0f)
                        {
                            list3[num2].Width = num3;
                        }
                        num2++;
                    }
                }
                list2.Clear();
                list2 = null;
                list3.Clear();
                list3 = null;
                list.Clear();
                list = null;
                list4.Clear();
                list4 = null;
            }
        }

        private void method_40()
        {
            float num = this.RowFormat.CellSpacingEx / 4f;
            float leftIndent = this.RowFormat.LeftIndent;
            if (this.RowFormat.CellSpacingEx > -1f)
            {
                Borders borders = this.RowFormat.Borders;
                float num3 = borders.Left.LineWidth / 2f;
                float num4 = borders.Top.LineWidth / 2f;
                float num5 = borders.Right.LineWidth / 2f;
                float num6 = borders.Bottom.LineWidth / 2f;
                Class372 class2 = base.interface23_0.imethod_0();
                class2.method_1((double) (num3 + num));
                class2.method_5((double) (num4 + num));
                class2.method_9((double) (num5 + num));
                class2.method_13((double) (num6 + num));
                Class372 class3 = base.interface23_0.imethod_1();
                class3.method_1((double) num3);
                class3.method_5((double) num4);
                class3.method_9((double) num5);
                class3.method_13((double) num6);
            }
            Class372 class1 = base.interface23_0.imethod_1();
            class1.method_1(class1.method_0() + leftIndent);
            base.interface23_0.imethod_25(true);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x13;
            if (reader.HasAttribute(BookmarkStart.b("欸吺䨼眾⑀⩂≄⽆㵈", 0x13)))
            {
                this.Height = reader.ReadFloat(BookmarkStart.b("欸吺䨼眾⑀⩂≄⽆㵈", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀸䠺甼娾⁀❂⁄㕆", num)))
            {
                this.IsHeader = reader.ReadBoolean(BookmarkStart.b("瀸䠺甼娾⁀❂⁄㕆", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("焸帺吼堾⥀㝂ᅄ㹆㥈⹊", num)))
            {
                this.HeightType = (TableRowHeightType) reader.ReadEnum(BookmarkStart.b("焸帺吼堾⥀㝂ᅄ㹆㥈⹊", num), typeof(TableRowHeightType));
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            bool flag = base.ReadXmlContent(reader);
            if (reader.TagName == BookmarkStart.b("䐬䄮䔰嘲䜴夶堸场ြ嬾⁀㝂⑄", 7))
            {
                this.DataArray = reader.ReadChildBinaryElement();
                flag = true;
            }
            return flag;
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            dc.vmethod_2(this, ltWidget);
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x11;
            if (this.IsHeader)
            {
                writer.WriteValue(BookmarkStart.b("縶䨸猺堼帾╀♂㝄", num), this.IsHeader);
            }
            if (!this.rowFormat_0.method_57())
            {
                if (this.Height > 0f)
                {
                    writer.WriteValue(BookmarkStart.b("收嘸䰺甼娾⡀⑂ⵄ㍆", num), this.Height);
                }
                writer.WriteValue(BookmarkStart.b("缶尸刺娼圾㕀ᝂ㱄㝆ⱈ", num), this.HeightType);
            }
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 15;
            if (this.DataArray != null)
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("尴夶䴸帺似儾⁀⽂桄⍆⡈㽊ⱌ", num), this.DataArray);
            }
        }

        public virtual CellCollection Cells
        {
            get
            {
                return this.cellCollection_0;
            }
            set
            {
                this.cellCollection_0 = value;
            }
        }

        internal Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return this.characterFormat_0;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.cellCollection_0;
            }
        }

        internal byte[] DataArray
        {
            get
            {
                return this.byte_3;
            }
            set
            {
                this.byte_3 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.TableRow;
            }
        }

        internal TableCell FirstCell
        {
            get
            {
                return (this.Cells.FirstItem as TableCell);
            }
        }

        internal bool HasTblPrEx
        {
            get
            {
                return this.bool_6;
            }
            set
            {
                this.bool_6 = value;
            }
        }

        internal bool HasWidthTypeIsAuot
        {
            get
            {
                return this.bool_8;
            }
        }

        internal bool HasWidthTypeIsPercentage
        {
            get
            {
                return this.bool_9;
            }
        }

        public float Height
        {
            get
            {
                return this.rowFormat_0.Height;
            }
            set
            {
                this.rowFormat_0.Height = value;
            }
        }

        public TableRowHeightType HeightType
        {
            get
            {
                return this.rowFormat_0.HeightType;
            }
            set
            {
                this.rowFormat_0.HeightType = value;
            }
        }

        internal bool Hidden
        {
            get
            {
                return this.bool_10;
            }
            set
            {
                this.bool_10 = value;
            }
        }

        internal bool IsDeleteRevision
        {
            get
            {
                if (!this.bool_4)
                {
                    return this.CharacterFormat.IsDeleteRevision;
                }
                return true;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        public bool IsHeader
        {
            get
            {
                return this.rowFormat_0.IsHeader;
            }
            set
            {
                this.rowFormat_0.IsHeader = value;
            }
        }

        internal bool IsHtmlCaption
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

        internal bool IsInsertRevision
        {
            get
            {
                if (!this.bool_5)
                {
                    return this.CharacterFormat.IsInsertRevision;
                }
                return true;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        internal bool IsRowCanSplit
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                this.bool_7 = value;
            }
        }

        internal bool IsSameWidthTypeOfCells
        {
            get
            {
                return this.method_37();
            }
        }

        internal TableCell LastCell
        {
            get
            {
                return (this.Cells.LastItem as TableCell);
            }
        }

        internal virtual Table OwnerTable
        {
            get
            {
                return (base.Owner as Table);
            }
        }

        internal Table ParentTable
        {
            get
            {
                return (base.Owner as Table);
            }
        }

        public Spire.Doc.Formatting.RowFormat RowFormat
        {
            get
            {
                return this.rowFormat_0;
            }
            internal set
            {
                this.rowFormat_0 = value;
                this.rowFormat_0.method_0(this);
            }
        }

        internal Spire.Doc.Formatting.RowFormat TrackRowFormat
        {
            get
            {
                if (this.rowFormat_1 == null)
                {
                    this.rowFormat_1 = new Spire.Doc.Formatting.RowFormat();
                }
                return this.rowFormat_1;
            }
        }
    }
}

