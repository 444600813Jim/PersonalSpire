namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.Converters;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;

    public class Table : BodyRegion, ITable, Interface4
    {
        private ArrayList arrayList_0;
        internal ArrayList arrayList_1;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        internal bool bool_6;
        private bool bool_7;
        [CompilerGenerated]
        private bool bool_8;
        private Class15 class15_0;
        [CompilerGenerated]
        private Class500 class500_0;
        internal DocumentObject documentObject_0;
        private const float float_2 = 1f;
        private float float_3;
        private float float_4;
        private float[] float_5;
        private float[] float_6;
        internal const int int_2 = 20;
        private const int int_3 = 0xffe;
        private Interface5 interface5_0;
        private Interface8 interface8_0;
        private List<float> list_0;
        internal List<float> list_1;
        private List<float> list_2;
        private int? nullable_0;
        private float? nullable_1;
        private float? nullable_2;
        private RectangleF rectangleF_0;
        internal RectangleF rectangleF_1;
        private RowCollection rowCollection_0;
        private RowFormat rowFormat_0;
        private const string string_7 = "Normal Table";
        private string string_8;
        private string string_9;
        private XmlTableFormat xmlTableFormat_0;
        internal XmlTableFormat xmlTableFormat_1;

        public Table(IDocument doc) : this(doc, false)
        {
        }

        public Table(IDocument doc, bool showBorder) : base((Document) doc)
        {
            this.float_3 = float.MinValue;
            this.float_4 = float.MinValue;
            this.rectangleF_0 = new RectangleF();
            this.arrayList_0 = new ArrayList();
            this.rowCollection_0 = new RowCollection(this);
            if (showBorder)
            {
                this.TableFormat.Borders.BorderType = BorderStyle.Single;
                this.TableFormat.Borders.Color = Color.Black;
                this.TableFormat.Borders.LineWidth = 0.5f;
            }
        }

        internal Table(bool A_0, IDocument A_1) : base((Document) A_1)
        {
            this.float_3 = float.MinValue;
            this.float_4 = float.MinValue;
            this.rectangleF_0 = new RectangleF();
            this.arrayList_0 = new ArrayList();
            this.rowCollection_0 = new RowCollection(this);
            if (A_0)
            {
                this.TableFormat.Borders.BorderType = BorderStyle.Single;
                this.TableFormat.Borders.Color = Color.Black;
                this.TableFormat.Borders.LineWidth = 0.5f;
            }
            else
            {
                this.TableFormat.Borders.BorderType = BorderStyle.None;
                this.TableFormat.Borders.Color = Color.Empty;
                this.TableFormat.Borders.LineWidth = 0f;
            }
        }

        public Table(IDocument doc, bool showBorder, float lineWidth) : base((Document) doc)
        {
            this.float_3 = float.MinValue;
            this.float_4 = float.MinValue;
            this.rectangleF_0 = new RectangleF();
            this.arrayList_0 = new ArrayList();
            this.rowCollection_0 = new RowCollection(this);
            if (showBorder)
            {
                this.TableFormat.Borders.BorderType = BorderStyle.Single;
                this.TableFormat.Borders.Color = Color.Black;
                this.TableFormat.Borders.LineWidth = lineWidth;
            }
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override void AcceptCChanges()
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.CharacterFormat.AcceptChanges();
                foreach (TableCell cell in row.Cells)
                {
                    cell.CharacterFormat.AcceptChanges();
                }
            }
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_11(this);
        }

        internal override void AcceptPChanges()
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.RowFormat.AcceptChanges();
            }
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_10(this);
        }

        public TableRow AddRow()
        {
            return this.AddRow(true, true);
        }

        public TableRow AddRow(bool isCopyFormat)
        {
            return this.AddRow(isCopyFormat, true);
        }

        public TableRow AddRow(int columnsNum)
        {
            return this.method_39(true, true, new int?(columnsNum));
        }

        public TableRow AddRow(bool isCopyFormat, bool autoPopulateCells)
        {
            return this.method_39(isCopyFormat, autoPopulateCells, null);
        }

        public TableRow AddRow(bool isCopyFormat, int columnsNum)
        {
            return this.method_39(isCopyFormat, true, new int?(columnsNum));
        }

        public void ApplyHorizontalMerge(int rowIndex, int startCellIndex, int endCellIndex)
        {
            int num = 0x13;
            if ((this.rowCollection_0 == null) || (this.rowCollection_0.Count == 0))
            {
                throw new Exception(BookmarkStart.b("洸娺弼匾⑀捂㝄⡆㹈㡊浌⹎⍐㙒畔㥖㙘⽚絜㙞འ੢ᅤ๦ࡨݪѬᕮᑰᝲ孴", num));
            }
            if ((rowIndex < 0) || (rowIndex >= this.rowCollection_0.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䬸吺䨼瘾⽀❂⁄㽆", num), BookmarkStart.b("欸吺䨼Ἶ㙀⩂ㅄ⽆楈㡊㵌⩎㉐㩒㍔㹖㱘㽚絜ⵞ๠ᑢ䕤๦ݨཪ࡬ᝮ兰ᝲᩴቶ੸ᕺ婼୾ꆀﶄ愈ﾊ", num));
            }
            CellCollection cells = this.rowCollection_0[rowIndex].Cells;
            if ((cells == null) || (cells.Count == 0))
            {
                throw new Exception(BookmarkStart.b("洸娺弼匾⑀捂㝄⡆㹈歊⹌⩎㵐㽒♔睖㡘⥚㡜罞འౢᅤ䝦hժѬ᭮ᡰቲᥴṶ͸Ṻ᥼兾", num));
            }
            if ((startCellIndex < 0) || (startCellIndex > (cells.Count - 1)))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䨸伺尼䴾㕀B⁄⭆╈Ɋ⍌⭎㑐⭒", num), BookmarkStart.b("稸帺儼匾慀㑂ⱄ㍆ⅈ歊㹌㽎㑐げ㱔ㅖじ㹚㥜罞በᝢѤᕦᵨ䭪๬੮ᵰὲ啴Ṷ᝸ὺ᡼ݾꆀ愈ꪌﮎ놐ﺖ", num));
            }
            if ((endCellIndex < 0) || (endCellIndex > (cells.Count - 1)))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("尸唺夼簾⑀⽂⥄ๆ❈⽊⡌㝎", num), BookmarkStart.b("稸帺儼匾慀㑂ⱄ㍆ⅈ歊㹌㽎㑐げ㱔ㅖじ㹚㥜罞ѠൢŤ䝦੨๪Ŭͮ兰ᩲ᭴፶ᱸͺ嵼᭾꺈ﾊ권朗", num));
            }
            if (startCellIndex > endCellIndex)
            {
                throw new Exception(BookmarkStart.b("樸伺尼䴾㕀捂♄≆╈❊浌♎㽐㝒ご⽖祘㉚⹜罞٠ᅢd٦ᵨ๪Ὤ佮հ᭲ᑴ᥶奸Ṻ፼᭾ꆀꮊ릖", num));
            }
            float num2 = 0f;
            cells[startCellIndex].CellFormat.HorizontalMerge = CellMerge.Start;
            for (int i = startCellIndex + 1; i <= endCellIndex; i++)
            {
                cells[i].CellFormat.HorizontalMerge = CellMerge.Continue;
                if (cells[i].WidthType == FtsWidth.Point)
                {
                    num2 += cells[i].Width;
                    cells[i].SetCellWidth(0f, CellWidthType.Auto);
                }
            }
            if ((num2 > 0f) && (cells[startCellIndex].WidthType == FtsWidth.Point))
            {
                TableCell cell1 = cells[startCellIndex];
                cell1.Width += num2;
            }
        }

        public void ApplyStyle(DefaultTableStyle builtinTableStyle)
        {
            int num = 0x10;
            this.method_42();
            string name = Style.smethod_5(builtinTableStyle);
            IStyle style = base.Document.Styles.FindByName(name, StyleType.TableStyle) as Interface8;
            if (style == null)
            {
                style = (Interface8) Style.smethod_3(builtinTableStyle, base.Document);
                if ((style as Class13).StyleDocId > 10)
                {
                    (style as Class13).StyleDocId = 0xffe;
                }
                base.Document.Styles.Add(style);
                string str2 = style.Name;
                base.Document.StyleNameIds.Add(str2.Replace(BookmarkStart.b("ᘵ", num), ""), style.Name);
                (style as Class13).ApplyBaseStyle(BookmarkStart.b("砵圷䠹儻弽ⰿ扁၃❅⩇♉⥋", num));
            }
            this.method_44(style as Interface8);
        }

        public void ApplyTableStyle()
        {
            this.method_46();
        }

        public void ApplyVerticalMerge(int columnIndex, int startRowIndex, int endRowIndex)
        {
            int num = 0x10;
            if ((this.rowCollection_0 == null) || (this.rowCollection_0.Count == 0))
            {
                throw new Exception(BookmarkStart.b("戵夷堹倻嬽怿ぁ⭃ㅅ㭇橉ⵋ㱍㕏牑㩓㥕ⱗ穙㕛そय़ᙡൣݥѧͩᙫ୭ᑯ山", num));
            }
            if ((startRowIndex < 0) || (startRowIndex >= this.rowCollection_0.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䔵䰷嬹主䨽ሿⵁ㍃ཅ♇⹉⥋㙍", num), BookmarkStart.b("搵圷䴹᰻䤽⤿㙁ⱃ晅㭇㩉⥋ⵍ㥏㑑㵓㍕㱗穙⹛ㅝ᝟䉡ൣࡥ౧ཀྵᑫ乭ᑯᵱᅳյᙷ嵹ࡻ幽嬨ﲇ", num));
            }
            if ((endRowIndex < 0) || (endRowIndex >= this.rowCollection_0.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("匵嘷帹渻儽㜿ୁ⩃≅ⵇ㉉", num), BookmarkStart.b("搵圷䴹᰻䤽⤿㙁ⱃ晅㭇㩉⥋ⵍ㥏㑑㵓㍕㱗穙⹛ㅝ᝟䉡ൣࡥ౧ཀྵᑫ乭ᑯᵱᅳյᙷ嵹ࡻ幽嬨ﲇ", num));
            }
            if (startRowIndex > endRowIndex)
            {
                throw new Exception(BookmarkStart.b("攵䰷嬹主䨽怿ぁ⭃ㅅ桇⍉≋⩍㕏⩑瑓㽕⭗穙㭛ⱝ՟͡ၣͥᩧ䩩ᡫ٭ᅯᱱ味፵ᙷṹ屻౽ꒃ뺏", num));
            }
            if (columnIndex < 0)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("唵圷嘹䤻匽⸿ୁ⩃≅ⵇ㉉", num), BookmarkStart.b("电圷嘹䤻匽⸿扁㍃⽅㱇≉汋㵍⁏㝑㝓㽕㹗㍙㥛㩝䁟šୣ੥ᵧݩɫ乭᥯ᱱၳ፵w婹᡻ᅽꆅﲇꪉ憐", num));
            }
            for (int i = startRowIndex; i <= endRowIndex; i++)
            {
                if (columnIndex >= this.rowCollection_0[i].Cells.Count)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("唵圷嘹䤻匽⸿ୁ⩃≅ⵇ㉉", num), BookmarkStart.b("电圷嘹䤻匽⸿扁㍃⽅㱇≉汋㵍⁏㝑㝓㽕㹗㍙㥛㩝䁟šୣ੥ᵧݩɫ乭᥯ᱱၳ፵w婹᡻ᅽꆅﲇꪉ憐", num));
                }
            }
            this.rowCollection_0[startRowIndex].Cells[columnIndex].CellFormat.VerticalMerge = CellMerge.Start;
            for (int j = startRowIndex + 1; j <= endRowIndex; j++)
            {
                this.rowCollection_0[j].Cells[columnIndex].CellFormat.VerticalMerge = CellMerge.Continue;
            }
        }

        public void AutoFit(AutoFitBehaviorType behavior)
        {
            int num = 6;
            switch (behavior)
            {
                case AutoFitBehaviorType.FixedColumnWidths:
                    this.method_24();
                    return;

                case AutoFitBehaviorType.AutoFitToContents:
                    this.method_22();
                    return;

                case AutoFitBehaviorType.AutoFitToWindow:
                    this.method_23();
                    return;
            }
            throw new ArgumentException(BookmarkStart.b("礫䀭嬯就嬳䄵嘷ᨹ崻䬽㐿ⵁ摃⁅ⅇ㹉汋ⱍ㕏㩑㕓⁕ㅗ㕙⹛灝", num));
        }

        internal override bool CheckChangedCFormat()
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                if (row.CharacterFormat.IsChangedFormat)
                {
                    return true;
                }
                foreach (TableCell cell in row.Cells)
                {
                    if (cell.CharacterFormat.IsChangedFormat)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        internal override bool CheckChangedPFormat()
        {
            bool flag;
            using (IEnumerator enumerator = this.rowCollection_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    TableRow current = (TableRow) enumerator.Current;
                    if (current.RowFormat.IsChangedFormat)
                    {
                        goto Label_0032;
                    }
                }
                return false;
            Label_0032:
                flag = true;
            }
            return flag;
        }

        internal override bool CheckDeleteRev()
        {
            bool flag;
            using (IEnumerator enumerator = this.rowCollection_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    TableRow current = (TableRow) enumerator.Current;
                    if (current.CharacterFormat.IsDeleteRevision)
                    {
                        goto Label_0032;
                    }
                }
                return false;
            Label_0032:
                flag = true;
            }
            return flag;
        }

        internal override bool CheckInsertRev()
        {
            bool flag;
            using (IEnumerator enumerator = this.rowCollection_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    TableRow current = (TableRow) enumerator.Current;
                    if (current.CharacterFormat.IsInsertRevision)
                    {
                        goto Label_0032;
                    }
                }
                return false;
            Label_0032:
                flag = true;
            }
            return flag;
        }

        public Table Clone()
        {
            return (Table) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            Table owner = (Table) base.CloneImpl();
            owner.rowCollection_0 = new RowCollection(owner);
            owner.list_0 = null;
            owner.rowFormat_0 = null;
            owner.TableFormat.ImportContainer(this.TableFormat);
            if (this.TableFormat.Scaling != 100f)
            {
                owner.TableFormat.Scaling = this.TableFormat.Scaling;
            }
            owner.TableFormat.method_0(owner);
            if (this.xmlTableFormat_0 != null)
            {
                owner.xmlTableFormat_0 = this.xmlTableFormat_0.method_0(owner);
            }
            this.Rows.method_12(owner.rowCollection_0);
            Interface8 interface2 = this.method_43();
            if (interface2 != null)
            {
                Class13 class2 = interface2.Clone() as Class13;
                owner.method_44(class2);
            }
            return owner;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            if (doc.ImportStyles)
            {
                this.method_50(doc);
            }
            int num = 0;
            int count = this.ChildObjects.Count;
            while (num < count)
            {
                this.ChildObjects[num].CloneRelationsTo(doc, nextOwner);
                num++;
            }
        }

        internal override void Close()
        {
            if ((this.rowCollection_0 != null) && (this.rowCollection_0.Count > 0))
            {
                int count = this.rowCollection_0.Count;
                TableRow row = null;
                for (int i = 0; i < count; i++)
                {
                    row = this.rowCollection_0[i];
                    row.method_36();
                    row = null;
                }
                this.rowCollection_0.Clear();
                this.rowCollection_0 = null;
            }
            if (this.rowFormat_0 != null)
            {
                this.rowFormat_0.Close();
            }
            if (this.list_0 != null)
            {
                this.list_0.Clear();
                this.list_0 = null;
            }
            if (this.list_1 != null)
            {
                this.list_1.Clear();
                this.list_1 = null;
            }
            if (this.arrayList_1 != null)
            {
                this.arrayList_1.Clear();
                this.arrayList_1 = null;
            }
            if (this.list_2 != null)
            {
                this.list_2.Clear();
                this.list_2 = null;
            }
            if (this.xmlTableFormat_0 != null)
            {
                this.xmlTableFormat_0.method_1();
                this.xmlTableFormat_0 = null;
            }
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_39(this.TableFormat.Positioning.TableOverlap);
            if (base.NextSibling is Paragraph)
            {
                base.interface23_0.imethod_29((base.NextSibling as Paragraph).Format.PageBreakBefore);
            }
            else if (base.NextSibling is Table)
            {
                base.interface23_0.imethod_29((base.NextSibling as Table).Rows[0].Cells[0].Paragraphs[0].Format.PageBreakBefore);
            }
            if (this.TableFormat.CellSpacingEx > 0f)
            {
                base.interface23_0.imethod_1().method_1((double) (this.TableFormat.Borders.Left.LineWidth / 2f));
                base.interface23_0.imethod_1().method_9((double) (this.TableFormat.Borders.Right.LineWidth / 2f));
                base.interface23_0.imethod_1().method_5((double) (this.TableFormat.Borders.Top.LineWidth / 2f));
                base.interface23_0.imethod_1().method_13((double) (this.TableFormat.Borders.Bottom.LineWidth / 2f));
            }
        }

        public override TextSelection Find(Regex pattern)
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                foreach (TableCell cell in row.Cells)
                {
                    TextSelection selection = cell.method_22(pattern);
                    if ((selection != null) && (selection.Count > 0))
                    {
                        return selection;
                    }
                }
            }
            return null;
        }

        internal override Class185 FindAll(Regex pattern)
        {
            Class185 class2 = null;
            foreach (TableRow row in this.rowCollection_0)
            {
                foreach (TableCell cell in row.Cells)
                {
                    Class185 collection = cell.method_23(pattern);
                    if ((collection != null) && (collection.Count > 0))
                    {
                        if (class2 == null)
                        {
                            class2 = collection;
                        }
                        else
                        {
                            class2.AddRange(collection);
                        }
                    }
                }
            }
            return class2;
        }

        internal override BodyRegion GetNextTextBodyItem()
        {
            if (base.NextSibling != null)
            {
                return (base.NextSibling as BodyRegion);
            }
            if (base.OwnerTextBody is TableCell)
            {
                (base.OwnerTextBody as TableCell).method_61();
            }
            else if (base.OwnerTextBody != null)
            {
                base.GetNextInSection(base.OwnerTextBody.Owner as Section);
            }
            return null;
        }

        internal override bool HasTrackedChanges()
        {
            if ((base.IsDeleteRevision || base.IsInsertRevision) || (base.IsChangedCFormat || base.IsChangedPFormat))
            {
                return true;
            }
            foreach (TableRow row in this.rowCollection_0)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (BodyRegion region in cell.Items)
                    {
                        if (region.HasTrackedChanges())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("崮帰䐲䘴", 9), this.Rows);
        }

        internal override void MakeChanges(bool acceptChanges)
        {
            for (int i = 0; i < this.rowCollection_0.Count; i++)
            {
                TableRow row = this.rowCollection_0[i];
                foreach (TableCell cell in row.Cells)
                {
                    int num2 = 0;
                    int count = cell.Items.Count;
                    while (num2 < count)
                    {
                        cell.Items[num2].MakeChanges(acceptChanges);
                        num2++;
                    }
                    cell.method_35(acceptChanges);
                    if (acceptChanges)
                    {
                        cell.cellFormat_1 = null;
                    }
                    else if (cell.cellFormat_1 != null)
                    {
                        cell.CellFormat.ClearFormatting();
                        cell.CellFormat.ImportContainer(cell.TrackCellFormat);
                        cell.cellFormat_1 = null;
                    }
                }
                if (acceptChanges)
                {
                    row.rowFormat_1 = null;
                }
                else if (row.rowFormat_1 != null)
                {
                    row.RowFormat.ClearFormatting();
                    row.RowFormat.ImportContainer(row.TrackRowFormat);
                    row.rowFormat_1 = null;
                }
                if ((row.IsDeleteRevision && acceptChanges) || (row.IsInsertRevision && !acceptChanges))
                {
                    this.rowCollection_0.RemoveAt(i);
                    i--;
                }
                if (this.rowCollection_0.Count == 0)
                {
                    (this.rowCollection_0.OwnerBase as Table).RemoveSelf();
                    (this.rowCollection_0.OwnerBase as Table).TableFormat.ClearFormatting();
                    (this.rowCollection_0.OwnerBase as Table).xmlTableFormat_1 = null;
                }
            }
        }

        private void method_22()
        {
            this.method_31(AutoFitBehaviorType.AutoFitToContents);
            this.method_29(LayoutType.AutoFit);
            this.method_28(0f, FtsWidth.Auto);
            this.method_25();
            this.method_26(0f, CellWidthType.Auto);
        }

        private void method_23()
        {
            this.method_29(LayoutType.AutoFit);
            this.method_28(100f, FtsWidth.Percentage);
            this.method_25();
            this.method_31(AutoFitBehaviorType.AutoFitToWindow);
        }

        private void method_24()
        {
            this.method_29(LayoutType.Fixed);
            this.method_28(0f, FtsWidth.Auto);
            this.method_31(AutoFitBehaviorType.FixedColumnWidths);
        }

        private void method_25()
        {
            foreach (TableRow row in this.Rows)
            {
                if (row.RowFormat.GridBefore > 0)
                {
                    TableCell firstChild = row.FirstChild as TableCell;
                    firstChild.GridSpan = (short) (firstChild.GridSpan + ((short) row.RowFormat.GridBefore));
                    TableCell cell2 = row.FirstChild as TableCell;
                    cell2.Width += row.RowFormat.GridBeforeWidth.method_56();
                    row.RowFormat.Remove(0x13f0);
                    row.RowFormat.Remove(0x109a);
                }
                if (row.RowFormat.GridAfter > 0)
                {
                    TableCell lastChild = row.LastChild as TableCell;
                    lastChild.GridSpan = (short) (lastChild.GridSpan + ((short) row.RowFormat.GridAfter));
                    TableCell cell4 = row.LastChild as TableCell;
                    cell4.Width += (short) row.RowFormat.GridAfterWidth.method_56();
                    row.RowFormat.Remove(0x13f1);
                    row.RowFormat.Remove(0x10a4);
                }
            }
        }

        private void method_26(float A_0, CellWidthType A_1)
        {
            foreach (TableRow row in this.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.SetCellWidth(A_0, A_1);
                }
            }
        }

        private void method_27()
        {
            foreach (TableRow row in this.Rows)
            {
                row.RowFormat.TablePreferredWidthInfo = this.PreferredTableWidth;
            }
        }

        private void method_28(float A_0, FtsWidth A_1)
        {
            Class15 preferredTableWidth = this.PreferredTableWidth;
            switch (A_1)
            {
                case FtsWidth.Auto:
                    preferredTableWidth.method_52(FtsWidth.Auto);
                    preferredTableWidth.method_50(0f);
                    break;

                case FtsWidth.Percentage:
                    preferredTableWidth.method_52(FtsWidth.Percentage);
                    preferredTableWidth.method_50(A_0);
                    break;

                case FtsWidth.Point:
                    preferredTableWidth.method_52(FtsWidth.Point);
                    preferredTableWidth.method_50(A_0);
                    break;
            }
            this.method_27();
        }

        private void method_29(LayoutType A_0)
        {
            this.TableFormat.LayoutType = A_0;
            foreach (TableRow row in this.Rows)
            {
                row.RowFormat.LayoutType = A_0;
            }
        }

        private ArrayList method_30()
        {
            ArrayList list = (ArrayList) this.TableFormat.method_51(0x13ef);
            ArrayList list2 = new ArrayList();
            List<short> list3 = new List<short>();
            if (list.Count > 0)
            {
                return list;
            }
            using (IEnumerator enumerator = this.Rows.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    TableRow current = (TableRow) enumerator.Current;
                }
            }
            if (list3.Count > 0)
            {
                list3.Sort();
                for (int i = 0; i < (list3.Count - 1); i++)
                {
                    list2.Add((int) (list3[i + 1] - list3[i]));
                }
            }
            if (list2.Count == 0)
            {
                list2 = this.method_34();
            }
            return list2;
        }

        private void method_31(AutoFitBehaviorType A_0)
        {
            ArrayList c = (this._ColumnWidths.Count > 0) ? this._ColumnWidths : this.method_30();
            this.TableFormat.method_52(0x13ef, new ArrayList(c));
            if (A_0 == AutoFitBehaviorType.FixedColumnWidths)
            {
                foreach (TableRow row in this.Rows)
                {
                    Class532.smethod_3(row, true, false, 0);
                }
            }
            else if (A_0 == AutoFitBehaviorType.AutoFitToWindow)
            {
                int num2 = this.method_33(c);
                Section section = this.method_55();
                int num = (section != null) ? ((int) (section.PageSetup.ClientWidth * 20f)) : ((int) (base.Document.Sections[0].PageSetup.ClientWidth * 20f));
                int num3 = num - num2;
                this.method_32(num3, num2, c);
                foreach (TableRow row2 in this.Rows)
                {
                    Class532.smethod_3(row2, true, true, num);
                }
            }
        }

        private void method_32(int A_0, int A_1, ArrayList A_2)
        {
            ArrayList list = new ArrayList();
            foreach (int num in A_2)
            {
                list.Add(num + ((int) ((((float) num) / ((float) A_1)) * A_0)));
            }
            this.TableFormat.SetAttr(0x13ef, list);
        }

        private int method_33(ArrayList A_0)
        {
            int num = 0;
            foreach (int num2 in A_0)
            {
                num += num2;
            }
            return num;
        }

        private ArrayList method_34()
        {
            ArrayList list = new Class618().method_113(this, this.method_55().PageSetup.ClientWidth);
            this.IsHasCaculatedCellWidth = false;
            return list;
        }

        private void method_36()
        {
            this.TableFormat.Paddings.method_51();
        }

        private void method_37(int A_0, int A_1, RowFormat A_2, float? A_3)
        {
            int num = 7;
            if ((A_0 <= 0) || (A_1 <= 0))
            {
                throw new ArgumentException(BookmarkStart.b("礬丮匰弲倴᜶吸为丼䬾慀⭂⑄ㅆⱈ歊ⱌ㭎煐㽒ご㙖⩘⽚絜ぞའ٢䕤ᕦ٨ᱪ䵬๮ὰᝲ啴ᡶ᝸Ṻ嵼᱾", num));
            }
            if (A_1 > 0x3f)
            {
                throw new ArgumentException(BookmarkStart.b("怬䀮䌰嘲ᔴ䌶儸娺匼Ἶ着灂敄⑆ⱈ❊⅌㱎煐げ㑔㥖祘㕚㉜⭞䅠Ţd䝦ᩨṪᵬὮṰŲŴቶᵸ啺", num));
            }
            if (A_2 != null)
            {
                this.TableFormat.ClearFormatting();
                this.TableFormat.ImportContainer(A_2);
            }
            this.rowCollection_0.Clear();
            this.nullable_0 = new int?(A_1);
            if (A_3.HasValue)
            {
                this.nullable_1 = new float?(A_3.Value);
            }
            this.method_89();
            if (A_0 > 0)
            {
                this.method_38(A_1, A_3);
                A_0--;
                while (A_0 > 0)
                {
                    this.AddRow();
                    A_0--;
                }
            }
        }

        private TableRow method_38(int A_0, float? A_1)
        {
            TableRow row = new TableRow(base.Document);
            if ((this.rowFormat_0 != null) && !this.rowFormat_0.IsDefault)
            {
                row.RowFormat.ImportContainer(this.rowFormat_0);
                if (this.rowFormat_0.Hidden)
                {
                    row.Hidden = true;
                }
            }
            if (this.nullable_2.HasValue)
            {
                row.Height = this.nullable_2.Value;
                row.HeightType = TableRowHeightType.Exactly;
            }
            for (int i = 0; i < A_0; i++)
            {
                TableCell cell = new TableCell(base.Document);
                float? nullable = null;
                if (A_1.HasValue)
                {
                    nullable = new float?(A_1.Value);
                }
                else if ((this.float_5 != null) && (this.float_5.Length > i))
                {
                    nullable = new float?(this.float_5[i]);
                }
                else if (this.nullable_1.HasValue)
                {
                    nullable = new float?(this.nullable_1.Value);
                }
                if (nullable.HasValue)
                {
                    cell.Width = nullable.Value;
                    if (nullable.Value > 0f)
                    {
                        cell.WidthType = FtsWidth.Point;
                    }
                }
                row.Cells.Add(cell);
            }
            this.Rows.Add(row);
            return row;
        }

        private TableRow method_39(bool A_0, bool A_1, int? A_2)
        {
            int num = 10;
            TableRow lastRow = this.LastRow;
            if (A_2.HasValue)
            {
                if (A_2.Value > 0x3f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("匯崱堳䌵唷吹伻瀽㔿⽁", num), BookmarkStart.b("搯匱嘳娵崷ᨹ弻弽⸿扁⩃⥅㱇橉㽋㭍⁏≑㭓⑕ⱗ穙ㅛㅝ቟ݡ䑣ብg୩ɫ乭䙯䅱味ᕵ᝷ᙹॻ፽ꪃ", num));
                }
                if (A_2.Value < 0)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("匯崱堳䌵唷吹伻瀽㔿⽁", num), BookmarkStart.b("搯娱儳ᘵ嘷伹儻尽┿ぁ摃⥅⹇橉⽋⅍╏㱑⁓癕㝗㱙籛⩝࡟ݡ䑣ᑥݧᵩ䱫൭ᅯᱱ味ᡵ᝷๹屻ᱽꊁﮇ黎겋뺍", num));
                }
            }
            else if (this.nullable_0.HasValue)
            {
                A_2 = new int?(this.nullable_0.Value);
            }
            else if (lastRow != null)
            {
                A_2 = new int?(lastRow.Cells.Count);
            }
            else
            {
                A_2 = 0;
            }
            TableRow row = null;
            if (lastRow == null)
            {
                row = this.method_38(A_2.Value, null);
            }
            else
            {
                row = new TableRow(base.Document);
                if (this.TableFormat.Hidden)
                {
                    row.Hidden = true;
                }
                if (A_1)
                {
                    int num2 = Math.Min(A_2.Value, lastRow.Cells.Count);
                    for (int i = 0; i < num2; i++)
                    {
                        TableCell cell2 = lastRow.Cells[i];
                        TableCell cell3 = new TableCell(base.Document);
                        row.Cells.Add(cell3);
                        cell3.Width = cell2.Width;
                        cell3.WidthType = cell2.WidthType;
                        if (A_0)
                        {
                            cell3.CellFormat.ImportContainer(cell2.CellFormat);
                        }
                    }
                    if (A_2.Value > num2)
                    {
                        for (int j = num2; j < A_2.Value; j++)
                        {
                            TableCell cell = new TableCell(base.Document);
                            float? nullable = null;
                            if ((this.float_5 != null) && (this.float_5.Length > j))
                            {
                                nullable = new float?(this.float_5[j]);
                            }
                            else if (this.nullable_1.HasValue)
                            {
                                nullable = new float?(this.nullable_1.Value);
                            }
                            if (nullable.HasValue)
                            {
                                cell.Width = nullable.Value;
                            }
                            row.Cells.Add(cell);
                        }
                    }
                }
            }
            if (A_0 && (lastRow != null))
            {
                row.RowFormat.ImportContainer(lastRow.RowFormat);
            }
            if (this.nullable_2.HasValue)
            {
                row.Height = this.nullable_2.Value;
            }
            this.Rows.Add(row);
            return row;
        }

        internal string method_40()
        {
            string str = string.Empty;
            foreach (TableRow row in this.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    for (int i = 0; i < cell.Items.Count; i++)
                    {
                        if (cell.Items[i] is Paragraph)
                        {
                            str = str + (cell.Items[i] as Paragraph).method_75();
                        }
                        else if (cell.Items[i] is Table)
                        {
                            str = str + (cell.Items[i] as Table).method_40();
                        }
                        if ((base.Document.bodyRegion_0 != null) && (base.Document.bodyRegion_0.OwnerTextBody == cell))
                        {
                            i = base.Document.bodyRegion_0.method_5();
                            base.Document.bodyRegion_0 = null;
                        }
                        if ((i == (cell.Items.Count - 1)) && (cell.CellFormat.CurCellIndex < (row.Cells.Count - 1)))
                        {
                            str = str.Substring(0, str.Length - 1);
                            str = str + Class816.string_9;
                        }
                    }
                }
            }
            return str;
        }

        internal bool method_41(DocumentObject A_0)
        {
            for (DocumentObject obj2 = A_0; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2 is StructureDocumentTag)
                {
                    return true;
                }
            }
            return false;
        }

        private void method_42()
        {
            int num = 7;
            if (!(base.Document.Styles.FindByName(BookmarkStart.b("挬䀮䌰帲吴嬶ᤸ漺尼崾ⵀ♂", 7), StyleType.TableStyle) is Class13))
            {
                Class13 style = (Class13) Style.smethod_3(DefaultTableStyle.TableNormal, base.Document);
                base.Document.Styles.Add(style);
                base.Document.StyleNameIds.Add(BookmarkStart.b("礬丮匰弲倴礶嘸䤺值帾ⵀ", num), style.Name);
            }
        }

        private Interface8 method_43()
        {
            return this.interface8_0;
        }

        internal void method_44(Interface8 A_0)
        {
            int num = 6;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䈫䬭䜯愱䀳伵吷弹", num));
            }
            this.interface8_0 = A_0;
            this.TableFormat.SetAttr(0xfa5, (this.interface8_0 as Style).StyleDocId);
        }

        internal void method_45(string A_0)
        {
            int num = 12;
            Interface8 interface2 = base.Document.Styles.FindByName(A_0, StyleType.TableStyle) as Interface8;
            if (interface2 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("就儳䄵欷丹䔻刽┿", num));
            }
            this.method_44(interface2);
        }

        internal void method_46()
        {
            if (this.interface8_0 != null)
            {
                this.TableFormat.ApplyBase(this.interface8_0.imethod_3().method_84());
                for (int i = 0; i < this.Rows.Count; i++)
                {
                    Class10 class2 = null;
                    bool flag = (!this.ApplyStyleForHeaderRow || !(this.interface8_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.FirstRow)) ? (((((long) i) / this.interface8_0.imethod_3().method_82()) % 2L) == 1L) : ((i != 0) ? ((((((long) (i - 1)) / this.interface8_0.imethod_3().method_82()) + 1L) % 2L) == 1L) : false);
                    foreach (KeyValuePair<ConditionalFormattingCode, Class10> pair in (this.interface8_0 as Class13).method_25())
                    {
                        switch (pair.Key)
                        {
                            case ConditionalFormattingCode.OddRowBanding:
                                if (((i != (this.Rows.Count - 1)) || !this.ApplyStyleForLastRow) && (flag && this.ApplyStyleForBandedRows))
                                {
                                    class2 = pair.Value;
                                }
                                break;

                            case ConditionalFormattingCode.EvenRowBanding:
                                if (((i != 0) && (i != (this.Rows.Count - 1))) && (!flag && this.ApplyStyleForBandedRows))
                                {
                                    class2 = pair.Value;
                                }
                                break;

                            case ConditionalFormattingCode.FirstRow:
                                if ((i == 0) && this.ApplyStyleForHeaderRow)
                                {
                                    class2 = pair.Value;
                                }
                                break;

                            case ConditionalFormattingCode.LastRow:
                                if (((i != 0) && (i == (this.Rows.Count - 1))) && this.ApplyStyleForLastRow)
                                {
                                    class2 = pair.Value;
                                }
                                break;
                        }
                    }
                    this.Rows[i].RowFormat.ApplyBase(this.interface8_0.imethod_3().method_84());
                    if (class2 != null)
                    {
                        this.Rows[i].RowFormat.method_61(class2.method_25().method_75());
                    }
                    else
                    {
                        this.Rows[i].RowFormat.method_61(this.interface8_0.imethod_2().method_75());
                    }
                    for (int j = 0; j < this.Rows[i].Cells.Count; j++)
                    {
                        bool flag2 = (!this.ApplyStyleForFirstColumn || !(this.interface8_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.FirstColumn)) ? (((((long) j) / this.interface8_0.imethod_3().method_80()) % 2L) == 1L) : ((j != 0) ? ((((((long) (j - 1)) / this.interface8_0.imethod_3().method_80()) + 1L) % 2L) == 1L) : false);
                        ParagraphFormat format2 = new ParagraphFormat(base.Document);
                        CharacterFormat format3 = new CharacterFormat(base.Document);
                        CellFormat format = new CellFormat();
                        format2.method_26(this.interface8_0.imethod_0());
                        format3.method_26(this.interface8_0.CharacterFormat);
                        format.method_56(this.interface8_0.imethod_1());
                        if (class2 != null)
                        {
                            format.method_56(class2.method_24());
                            this.method_47(format.Borders, class2.method_24().method_66(), this.TableFormat.Borders, j, this.Rows[i].Cells.Count);
                            format2.method_26(class2.method_23());
                            format3.method_26(class2.CharacterFormat);
                        }
                        Class10 class3 = null;
                        foreach (KeyValuePair<ConditionalFormattingCode, Class10> pair2 in (this.interface8_0 as Class13).method_25())
                        {
                            switch (pair2.Key)
                            {
                                case ConditionalFormattingCode.OddColumnBanding:
                                    if (((j != (this.Rows[i].Cells.Count - 1)) && flag2) && this.ApplyStyleForBandedColumns)
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;

                                case ConditionalFormattingCode.EvenColumnBanding:
                                    if (((j != 0) && (j != (this.Rows[i].Cells.Count - 1))) && (!flag2 && this.ApplyStyleForBandedColumns))
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;

                                case ConditionalFormattingCode.FirstColumn:
                                    if ((j == 0) && this.ApplyStyleForFirstColumn)
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;

                                case ConditionalFormattingCode.LastColumn:
                                    if (((j != 0) && (j == (this.Rows[i].Cells.Count - 1))) && this.ApplyStyleForLastColumn)
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;

                                case ConditionalFormattingCode.FirstRowLastCell:
                                    if ((((i == 0) && (j != 0)) && ((j == (this.Rows[i].Cells.Count - 1)) && this.ApplyStyleForHeaderRow)) && this.ApplyStyleForLastColumn)
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;

                                case ConditionalFormattingCode.FirstRowFirstCell:
                                    if (((i == 0) && (j == 0)) && (this.ApplyStyleForHeaderRow && this.ApplyStyleForFirstColumn))
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;

                                case ConditionalFormattingCode.LastRowLastCell:
                                    if ((((i != 0) && (i == (this.Rows.Count - 1))) && ((j != 0) && (j == (this.Rows[i].Cells.Count - 1)))) && (this.ApplyStyleForLastRow && this.ApplyStyleForLastColumn))
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;

                                case ConditionalFormattingCode.LastRowFirstCell:
                                    if ((((i != 0) && (i == (this.Rows.Count - 1))) && ((j == 0) && this.ApplyStyleForLastRow)) && this.ApplyStyleForFirstColumn)
                                    {
                                        class3 = pair2.Value;
                                    }
                                    break;
                            }
                            if (class3 != null)
                            {
                                format.method_56(class3.method_24());
                                this.method_48(format.Borders, class3.method_24().method_66(), this.TableFormat.Borders, i, this.Rows.Count);
                                format2.method_26(class3.method_23());
                                format3.method_26(class3.CharacterFormat);
                                if (class2 != null)
                                {
                                    if (class2.method_27() == ConditionalFormattingCode.FirstRow)
                                    {
                                        format2.method_26(class2.method_23());
                                        format3.method_26(class2.CharacterFormat);
                                    }
                                    format.method_56(class2.method_24());
                                    this.method_47(format.Borders, class2.method_24().method_66(), this.TableFormat.Borders, j, this.Rows[i].Cells.Count);
                                }
                                switch (class3.method_27())
                                {
                                    case ConditionalFormattingCode.FirstColumn:
                                        if ((class2 == null) || (class2.method_27() != ConditionalFormattingCode.FirstRow))
                                        {
                                            format.method_56(class3.method_24());
                                            this.method_48(format.Borders, class3.method_24().method_66(), this.TableFormat.Borders, i, this.Rows.Count);
                                        }
                                        break;

                                    case ConditionalFormattingCode.FirstRowLastCell:
                                    case ConditionalFormattingCode.FirstRowFirstCell:
                                    case ConditionalFormattingCode.LastRowLastCell:
                                    case ConditionalFormattingCode.LastRowFirstCell:
                                        format.method_26(class3.method_24());
                                        format2.method_26(class3.method_23());
                                        format3.method_26(class3.CharacterFormat);
                                        break;
                                }
                            }
                        }
                        this.Rows[i].Cells[j].method_48(format, format2, format3);
                    }
                }
            }
        }

        private void method_47(Borders A_0, Borders A_1, Borders A_2, int A_3, int A_4)
        {
            if (!A_1.NoBorder)
            {
                A_0.Top.method_51(A_1.Top);
                A_0.Bottom.method_51(A_1.Bottom);
                if (A_3 == 0)
                {
                    A_0.Left.method_51(A_1.Left);
                }
                if (A_3 == (A_4 - 1))
                {
                    A_0.Right.method_51(A_1.Right);
                }
                if (A_1.Vertical.HasValue(2))
                {
                    if (A_3 < (A_4 - 1))
                    {
                        A_0.Right.method_51(A_1.Vertical);
                        if ((A_1.Vertical.BorderType == BorderStyle.Cleared) && (A_2.Vertical.BorderType != BorderStyle.None))
                        {
                            A_0.Right.method_51(A_2.Vertical);
                        }
                    }
                    if ((A_3 > 0) && (A_3 < A_4))
                    {
                        A_0.Left.method_51(A_1.Vertical);
                        if ((A_1.Vertical.BorderType == BorderStyle.Cleared) && (A_2.Vertical.BorderType != BorderStyle.None))
                        {
                            A_0.Left.method_51(A_2.Vertical);
                        }
                    }
                }
            }
        }

        private void method_48(Borders A_0, Borders A_1, Borders A_2, int A_3, int A_4)
        {
            if (!A_1.NoBorder)
            {
                A_0.Left.method_51(A_1.Left);
                A_0.Right.method_51(A_1.Right);
                if (A_3 == 0)
                {
                    A_0.Top.method_51(A_1.Top);
                }
                if (A_3 == (A_4 - 1))
                {
                    A_0.Bottom.method_51(A_1.Bottom);
                }
                if (A_1.Horizontal.HasValue(2))
                {
                    if (A_3 < (A_4 - 1))
                    {
                        A_0.Bottom.method_51(A_1.Horizontal);
                        if ((A_1.Horizontal.BorderType == BorderStyle.Cleared) && (A_2.Horizontal.BorderType != BorderStyle.None))
                        {
                            A_0.Bottom.method_51(A_2.Vertical);
                        }
                    }
                    if ((A_3 > 0) && (A_3 < A_4))
                    {
                        A_0.Top.method_51(A_1.Horizontal);
                        if ((A_1.Horizontal.BorderType == BorderStyle.Cleared) && (A_2.Horizontal.BorderType != BorderStyle.None))
                        {
                            A_0.Top.method_51(A_2.Vertical);
                        }
                    }
                }
            }
        }

        internal object method_49()
        {
            Table owner = (Table) base.CloneImpl();
            owner.rowCollection_0 = new RowCollection(owner);
            owner.rowFormat_0 = null;
            owner.TableFormat.ImportContainer(this.TableFormat);
            owner.TableFormat.Scaling = this.TableFormat.Scaling;
            owner.TableFormat.method_0(owner);
            if (this.xmlTableFormat_0 != null)
            {
                owner.xmlTableFormat_0 = this.xmlTableFormat_0.method_0(owner);
            }
            Interface8 interface2 = this.method_43();
            if (interface2 != null)
            {
                Class13 class2 = interface2.Clone() as Class13;
                owner.method_44(class2);
            }
            return owner;
        }

        private void method_50(Document A_0)
        {
            if (this.interface8_0 != null)
            {
                IStyle style = A_0.Styles.FindByName(this.interface8_0.Name, StyleType.TableStyle);
                if (style == null)
                {
                    (this.interface8_0 as Style).method_18(A_0);
                }
                else if (A_0.CurClonedSection != null)
                {
                    this.interface8_0 = (Class13) (this.interface8_0 as Style).method_20(A_0, style);
                    this.method_44(this.interface8_0);
                }
            }
        }

        private List<float> method_51(bool A_0)
        {
            List<float> list = new List<float>();
            float num = this.method_71(this);
            float num2 = num * 20f;
            int num3 = 0;
            int num4 = 0;
            int count = this.Rows.Count;
            while (num4 < count)
            {
                TableRow row = this.Rows[num4];
                float num9 = this.method_53(row, num);
                int num8 = 0;
                float num6 = 0f;
                this.method_80(list, num6);
                bool flag = false;
                int num10 = 0;
                int num11 = row.Cells.Count;
                while (num10 < num11)
                {
                    float num7 = 0f;
                    TableCell cell = row.Cells[num10];
                    if ((cell.CellFormat.HorizontalMerge != CellMerge.Start) && ((cell.CellFormat.HorizontalMerge != CellMerge.Continue) || flag))
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                    num8 += cell.GridSpanEx;
                    if (cell.CellFormat.VerticalMerge == CellMerge.Continue)
                    {
                        float num12 = this.method_69(row, cell, num);
                        num6 += num12;
                    }
                    else
                    {
                        if (((row.RowFormat.LayoutType == LayoutType.AutoFit) && (cell.WidthType == FtsWidth.Point)) && ((cell.GridSpanEx > 1) && ((num2 - num9) > 20f)))
                        {
                            break;
                        }
                        num7 = this.method_70(cell, num, flag);
                        if ((A_0 && (row.RowFormat.LayoutType == LayoutType.AutoFit)) && (cell.WidthType == FtsWidth.Auto))
                        {
                            num7 = (float) Math.Round((double) 20.0);
                        }
                        num6 = (float) Math.Round((double) (num6 + num7));
                        this.method_80(list, num6);
                    }
                    num10++;
                }
                num8 += row.RowFormat.GridAfter + row.RowFormat.GridBefore;
                num3 = Math.Max(num3, num8);
                num4++;
            }
            if (list.Count > (num3 + 1))
            {
                this.method_58(list);
            }
            if ((!A_0 || (this.list_0 == null)) || ((list.Count != 1) && (((list.Count - 1) == num3) || ((this.list_0.Count - 1) != num3))))
            {
                return list;
            }
            return this.list_0;
        }

        private List<float> method_52(ArrayList A_0)
        {
            List<float> list = new List<float>();
            if (A_0.Count > 0)
            {
                list.Add(0f);
                for (int i = 0; i < A_0.Count; i++)
                {
                    float num2 = list[list.Count - 1];
                    list.Add(num2 + ((int) A_0[i]));
                }
                return list;
            }
            return this.method_51(true);
        }

        private float method_53(TableRow A_0, float A_1)
        {
            float num = 0f;
            if (A_0 != null)
            {
                bool flag = false;
                foreach (TableCell cell in A_0.Cells)
                {
                    if ((cell.CellFormat.HorizontalMerge != CellMerge.Start) && ((cell.CellFormat.HorizontalMerge != CellMerge.Continue) || flag))
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                    num += this.method_70(cell, A_1, flag);
                }
            }
            return num;
        }

        internal float method_54()
        {
            float num = 0f;
            Section section = this.method_55();
            if (section == null)
            {
                return num;
            }
            if (this.IsInCell)
            {
                TableCell owner = base.Owner as TableCell;
                if (owner.WidthType == FtsWidth.Percentage)
                {
                    float num2 = owner.CellFormat.SamePaddingsAsTable ? owner.OwnerRow.OwnerTable.TableFormat.Paddings.PaddingWidth : owner.CellFormat.Paddings.PaddingWidth;
                    return (((owner.Scaling / 100f) * section.PageSetup.ClientWidth) - num2);
                }
                return owner.Width;
            }
            return ((section.PageSetup.ClientWidth * this.PreferredTableWidth.method_49()) / 100f);
        }

        internal Section method_55()
        {
            return this.method_56(this);
        }

        internal Section method_56(Table A_0)
        {
            for (IDocumentObject obj2 = A_0; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Section)
                {
                    return (obj2 as Section);
                }
            }
            return null;
        }

        private void method_57(List<float> A_0, int A_1)
        {
            if (Math.Abs((int) ((A_1 + 1) - A_0.Count)) >= 1)
            {
                this.method_58(A_0);
            }
        }

        private void method_58(List<float> A_0)
        {
            for (int i = A_0.Count - 1; i > 0; i--)
            {
                if (Math.Abs((float) (A_0[i] - A_0[i - 1])) < 10f)
                {
                    A_0.RemoveAt(i);
                }
            }
        }

        private void method_59(ArrayList A_0)
        {
            for (int i = A_0.Count - 1; i > 0; i--)
            {
                if (Math.Abs((float) (((float) A_0[i]) - ((float) A_0[i - 1]))) <= 20f)
                {
                    A_0.RemoveAt(i);
                }
            }
        }

        private Dictionary<int, int> method_60()
        {
            float num = this.method_71(this);
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (TableRow row in this.Rows)
            {
                int key = 0;
                int num3 = 0;
                foreach (TableCell cell in row.Cells)
                {
                    key += cell.GridSpanEx;
                    if (cell.WidthType == FtsWidth.Percentage)
                    {
                        num3 += (int) (((cell.Scaling * num) / 100f) * 20f);
                    }
                    else if (cell.Width == 0f)
                    {
                        num3 += 20;
                    }
                    else
                    {
                        num3 += (int) (cell.Width * 20f);
                    }
                    if (dictionary.ContainsKey(key))
                    {
                        dictionary[key] = Math.Max(dictionary[key], num3);
                    }
                    else
                    {
                        dictionary.Add(key, num3);
                    }
                }
            }
            if (this.method_61(dictionary))
            {
                this.method_62(dictionary, (int) Math.Round((double) (num * 20f)));
            }
            return dictionary;
        }

        private bool method_61(Dictionary<int, int> A_0)
        {
            bool flag = false;
            using (Dictionary<int, int>.ValueCollection.Enumerator enumerator = A_0.Values.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current <= 0)
                    {
                        goto Label_0028;
                    }
                }
                return flag;
            Label_0028:
                flag = true;
            }
            return flag;
        }

        private void method_62(Dictionary<int, int> A_0, int A_1)
        {
            if (A_0 != null)
            {
                SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
                foreach (KeyValuePair<int, int> pair in A_0)
                {
                    if (pair.Value <= 0)
                    {
                        dictionary.Add(pair.Key, pair.Value);
                    }
                }
                if (dictionary.Count > 0)
                {
                    if ((dictionary.Count == A_0.Count) && (A_1 > 0))
                    {
                        int num12 = A_1 / A_0.Count;
                        int num11 = num12;
                        for (int i = 1; i <= A_0.Count; i++)
                        {
                            A_0[i] = num11;
                            num11 += num12;
                        }
                    }
                    else
                    {
                        List<List<int>> list2 = new List<List<int>>();
                        List<int> item = new List<int>();
                        foreach (KeyValuePair<int, int> pair2 in dictionary)
                        {
                            if (item.Count == 0)
                            {
                                item.Add(pair2.Key);
                            }
                            else
                            {
                                int num13 = item[item.Count - 1];
                                if ((pair2.Key - num13) == 1)
                                {
                                    item.Add(pair2.Key);
                                }
                                else
                                {
                                    list2.Add(item);
                                    item = new List<int> {
                                        pair2.Key
                                    };
                                }
                            }
                        }
                        if (item.Count > 0)
                        {
                            list2.Add(item);
                        }
                        if (list2.Count > 0)
                        {
                            foreach (List<int> list3 in list2)
                            {
                                if (list3.Count > 1)
                                {
                                    int num = list3[0];
                                    int num3 = list3[list3.Count - 1];
                                    if (((num - 1) >= 1) && ((num3 + 1) <= A_0.Count))
                                    {
                                        int num2 = A_0[num - 1];
                                        int num4 = A_0[num3 + 1];
                                        int num5 = (num4 - num2) / list3.Count;
                                        int num6 = num2 + num5;
                                        for (int j = 0; j < list3.Count; j++)
                                        {
                                            A_0[list3[j]] = num6;
                                            num6 += num5;
                                        }
                                    }
                                }
                                else
                                {
                                    int num8 = list3[0];
                                    if ((num8 - 1) >= 1)
                                    {
                                        int num9 = A_0[num8 - 1];
                                        A_0[list3[0]] = num9;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        internal void method_63()
        {
            if (this.method_79())
            {
                this.method_64();
            }
            Dictionary<int, int> dictionary = this.method_60();
            if (dictionary.Count > 0)
            {
                foreach (TableRow row in this.Rows)
                {
                    int num = 0;
                    foreach (TableCell cell in row.Cells)
                    {
                        num += cell.GridSpanEx;
                        cell.CellFormat.Cellx = (short) dictionary[num];
                    }
                }
            }
        }

        internal void method_64()
        {
            bool flag = true;
            bool flag2 = true;
            bool flag3 = true;
            int num = 0;
            List<int> list = new List<int>();
            List<float> list2 = new List<float>();
            List<float> list3 = this.method_67(out flag, out flag2, out flag3, out num, out list, out list2);
            if ((!flag2 && (list.Count > 0)) && (list.Count == num))
            {
                foreach (TableRow row in this.Rows)
                {
                    int num3 = 0;
                    foreach (TableCell cell in row.Cells)
                    {
                        int cellx = cell.CellFormat.Cellx;
                        int num5 = this.method_74(cellx, list) + 1;
                        cell.GridSpan = ((num5 - num3) > 1) ? ((short) (num5 - num3)) : ((short) 1);
                        num3 = num5;
                    }
                }
            }
            else if (!flag2 || ((!flag || (flag && flag3)) && ((this.Rows.Count > 0) && (list3.Count != (this.Rows[0].method_23() + 1)))))
            {
                float num2 = this.method_71(this);
                foreach (TableRow row2 in this.Rows)
                {
                    int num10 = 0;
                    float num11 = 0f;
                    float num8 = 0f;
                    if (row2.RowFormat.GridBeforeWidth.method_55())
                    {
                        float num7 = 0f;
                        switch (row2.RowFormat.GridBeforeWidth.method_51())
                        {
                            case FtsWidth.Percentage:
                                num7 = (float) Math.Round((double) (((num2 * row2.RowFormat.GridBeforeWidth.method_49()) / 100f) * 20f));
                                break;

                            case FtsWidth.Point:
                                num7 = row2.RowFormat.GridBeforeWidth.method_49();
                                break;
                        }
                        if (row2.RowFormat.GridBefore <= 1)
                        {
                            num11 += num7;
                            int num13 = this.method_73(num11, list3);
                            row2.RowFormat.GridBefore = ((num13 - num10) > 1) ? ((short) (num13 - num10)) : ((short) 1);
                            num10 = num13;
                        }
                        else
                        {
                            num10 += row2.RowFormat.GridBefore;
                            num11 += num7;
                        }
                    }
                    bool flag4 = false;
                    foreach (TableCell cell5 in row2.Cells)
                    {
                        TableCell cell3;
                        if ((cell5.CellFormat.HorizontalMerge != CellMerge.Start) && ((cell5.CellFormat.HorizontalMerge != CellMerge.Continue) || flag4))
                        {
                            flag4 = false;
                        }
                        else
                        {
                            flag4 = true;
                        }
                        num8 = this.method_70(cell5, num2, flag4);
                        if ((num8 > 0f) || (cell5.CellFormat.VerticalMerge != CellMerge.Continue))
                        {
                            goto Label_036C;
                        }
                        TableCell cell4 = null;
                        TableRow previousSibling = (TableRow) row2.PreviousSibling;
                        while (previousSibling != null)
                        {
                            TableCell cell2 = previousSibling.method_24(num10);
                            if (cell2 == null)
                            {
                                break;
                            }
                            cell3 = (num10 <= 0) ? cell2 : ((TableCell) cell2.NextSibling);
                            if (cell3 != null)
                            {
                                if (cell3.CellFormat.VerticalMerge == CellMerge.Start)
                                {
                                    goto Label_0356;
                                }
                                if (cell3.CellFormat.VerticalMerge != CellMerge.Continue)
                                {
                                    break;
                                }
                                previousSibling = (TableRow) previousSibling.PreviousSibling;
                                cell4 = cell3;
                            }
                        }
                        goto Label_035A;
                    Label_0356:
                        cell4 = cell3;
                    Label_035A:
                        if (cell4 != null)
                        {
                            num8 = this.method_70(cell5, num2, flag4);
                        }
                    Label_036C:
                        if (cell5.GridSpan <= 1)
                        {
                            num11 += num8;
                            int num9 = this.method_73(num11, list3);
                            cell5.GridSpan = ((num9 - num10) > 1) ? ((short) (num9 - num10)) : ((short) 1);
                            num10 = num9;
                        }
                        else
                        {
                            num10 += cell5.GridSpanEx;
                            num11 += num8;
                        }
                    }
                    if (row2.RowFormat.GridAfterWidth.method_55())
                    {
                        float num6 = 0f;
                        switch (row2.RowFormat.GridAfterWidth.method_51())
                        {
                            case FtsWidth.Percentage:
                                num6 = (float) Math.Round((double) (((num2 * row2.RowFormat.GridAfterWidth.method_49()) / 100f) * 20f));
                                break;

                            case FtsWidth.Point:
                                num6 = row2.RowFormat.GridAfterWidth.method_49();
                                break;
                        }
                        if (row2.RowFormat.GridAfter <= 1)
                        {
                            num11 += num6;
                            int num12 = this.method_73(num11, list3);
                            row2.RowFormat.GridAfter = ((num12 - num10) > 1) ? ((short) (num12 - num10)) : ((short) 1);
                            num10 = num12;
                        }
                        else
                        {
                            num10 += row2.RowFormat.GridAfter;
                            num11 += num6;
                        }
                    }
                }
            }
        }

        private void method_65(TableRow A_0)
        {
        }

        private int method_66()
        {
            int num = 0;
            foreach (TableRow row in this.Rows)
            {
                int num2 = 0;
                foreach (TableCell cell in row.Cells)
                {
                    num2 += cell.GridSpanEx;
                }
                num = Math.Max(num, num2);
            }
            return num;
        }

        private List<float> method_67(out bool A_0, out bool A_1, out bool A_2, out int A_3, out List<int> A_4, out List<float> A_5)
        {
            A_5 = new List<float>();
            A_4 = new List<int>();
            A_0 = true;
            A_1 = true;
            A_2 = true;
            float num = this.method_71(this);
            this.method_65(this.Rows[0]);
            A_3 = this.Rows[0].Cells.Count;
            int num2 = this.Rows[0].method_23();
            FtsWidth widthType = this.Rows[0].Cells[0].WidthType;
            foreach (TableRow row in this.Rows)
            {
                this.method_65(row);
                if (A_0)
                {
                    A_0 = A_3 == row.Cells.Count;
                }
                float item = 0f;
                float num7 = 0f;
                int num4 = 0;
                item = 0f;
                if (!A_5.Contains(item))
                {
                    A_5.Add(item);
                }
                if (row.RowFormat.GridBeforeWidth.method_55())
                {
                    switch (row.RowFormat.GridBeforeWidth.method_51())
                    {
                        case FtsWidth.Percentage:
                            item = (float) Math.Round((double) (item + (((row.RowFormat.GridBeforeWidth.method_49() / 100f) * num) * 20f)));
                            break;

                        case FtsWidth.Point:
                            item = (float) Math.Round((double) (item + row.RowFormat.GridBeforeWidth.method_49()));
                            break;
                    }
                    if (!A_5.Contains(item))
                    {
                        A_5.Add(item);
                    }
                }
                bool flag = false;
                foreach (TableCell cell in row.Cells)
                {
                    if ((cell.CellFormat.HorizontalMerge != CellMerge.Start) && ((cell.CellFormat.HorizontalMerge != CellMerge.Continue) || flag))
                    {
                        if (cell.CellFormat.HorizontalMerge == CellMerge.None)
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                    if (A_2)
                    {
                        A_2 = widthType == cell.WidthType;
                    }
                    num4 += cell.GridSpanEx;
                    if (cell.CellFormat.VerticalMerge == CellMerge.Continue)
                    {
                        float num5 = this.method_69(row, cell, num);
                        item += num5;
                    }
                    else
                    {
                        if (cell.GridSpanEx < 2)
                        {
                            num7 = this.method_70(cell, num, flag);
                            item = (float) Math.Round((double) (item + num7));
                            if (!A_5.Contains(item))
                            {
                                A_5.Add(item);
                            }
                        }
                        else
                        {
                            num7 = this.method_70(cell, num, flag);
                            item = (float) Math.Round((double) (item + num7));
                        }
                        int cellx = cell.CellFormat.Cellx;
                        if (!A_4.Contains(cellx) && (cellx > 0))
                        {
                            A_4.Add(cellx);
                        }
                    }
                }
                if (!A_5.Contains(item))
                {
                    A_5.Add(item);
                }
                if (row.RowFormat.GridAfterWidth.method_55())
                {
                    switch (row.RowFormat.GridAfterWidth.method_51())
                    {
                        case FtsWidth.Percentage:
                            item = (float) Math.Round((double) (item + (((row.RowFormat.GridAfterWidth.method_49() / 100f) * num) * 20f)));
                            break;

                        case FtsWidth.Point:
                            item = (float) Math.Round((double) (item + row.RowFormat.GridAfterWidth.method_49()));
                            break;
                    }
                    if (!A_5.Contains(item))
                    {
                        A_5.Add(item);
                    }
                }
                if (A_1)
                {
                    A_1 = num2 == num4;
                }
            }
            A_5.Sort();
            this.method_57(A_5, num2);
            A_4.Sort();
            this.method_68(A_4, num2);
            return A_5;
        }

        private void method_68(List<int> A_0, int A_1)
        {
            if (Math.Abs((int) (A_1 - A_0.Count)) >= 1)
            {
                for (int i = A_0.Count - 1; i > 0; i--)
                {
                    if (Math.Abs((int) (A_0[i] - A_0[i - 1])) < 10f)
                    {
                        A_0.RemoveAt(i);
                    }
                }
            }
        }

        internal float method_69(TableRow A_0, TableCell A_1, float A_2)
        {
            if (((A_0 == null) || (A_1 == null)) || (this.Rows.Count <= 0))
            {
                return 0f;
            }
            int rowIndex = A_0.GetRowIndex();
            int cellIndex = A_1.GetCellIndex();
            float num = this.method_70(A_1, A_2, false);
            if (rowIndex < this.Rows.Count)
            {
                for (int i = rowIndex - 1; i > -1; i--)
                {
                    TableRow row = this.Rows[i];
                    if (cellIndex >= row.Cells.Count)
                    {
                        return num;
                    }
                    TableCell cell = row.Cells[cellIndex];
                    if (cell.CellFormat.VerticalMerge == CellMerge.None)
                    {
                        return num;
                    }
                    if (cell.CellFormat.VerticalMerge == CellMerge.Start)
                    {
                        return this.method_70(cell, A_2, false);
                    }
                    num = this.method_70(cell, A_2, false);
                }
            }
            return num;
        }

        internal float method_70(TableCell A_0, float A_1, bool A_2)
        {
            if ((A_0 == null) || (((A_0.CellFormat.HorizontalMerge == CellMerge.Continue) && A_2) && (A_0.CellFormat.WidthUnit != FtsWidth.Point)))
            {
                return 0f;
            }
            float width = A_0.Width;
            if (A_0.WidthType == FtsWidth.Percentage)
            {
                width = (float) Math.Round((double) (((A_0.Scaling / 100f) * A_1) * 20f));
                return Math.Max(width, (float) A_0.CellFormat.TwipCellWidth);
            }
            return A_0.CellFormat.TwipCellWidth;
        }

        internal float method_71(Table A_0)
        {
            if (A_0 == null)
            {
                return 0f;
            }
            if (A_0.PreferredTableWidth.method_51() != FtsWidth.Percentage)
            {
                return A_0.Width;
            }
            return this.method_54();
        }

        internal bool method_72(int A_0)
        {
            if ((A_0 >= 0) && (A_0 <= (this.Rows.Count - 1)))
            {
                TableCell cell = this.Rows[A_0].Cells[0];
                return cell.method_53();
            }
            return false;
        }

        private int method_73(float A_0, List<float> A_1)
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                if (Math.Abs((float) (A_0 - A_1[i])) <= 10f)
                {
                    return i;
                }
            }
            return -1;
        }

        private int method_74(int A_0, List<int> A_1)
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                if (Math.Abs((int) (A_0 - A_1[i])) <= 10f)
                {
                    return i;
                }
            }
            return -1;
        }

        internal void method_75()
        {
            if (this.method_78())
            {
                float num4 = (this.PreferredTableWidth.method_51() == FtsWidth.Percentage) ? this.method_54() : this.Width;
                List<float> list = this.method_77();
                int num6 = 0;
                foreach (TableRow row2 in this.Rows)
                {
                    int num7 = 0;
                    foreach (TableCell cell2 in row2.Cells)
                    {
                        num7 += cell2.GridSpanEx;
                    }
                    num6 = Math.Max(num6, num7);
                }
                if ((list.Count - num6) <= 1)
                {
                    foreach (TableRow row in this.Rows)
                    {
                        if (!row.method_22())
                        {
                            int num = 0;
                            float num2 = 0f;
                            float num3 = 0f;
                            foreach (TableCell cell in row.Cells)
                            {
                                if (cell.GridSpanEx <= 1)
                                {
                                    num3 = (float) Math.Round((cell.WidthType == FtsWidth.Percentage) ? ((double) (((num4 * cell.Scaling) / 100f) * 20f)) : ((double) (cell.LayoutWidth * 20f)));
                                    num2 += num3;
                                    int num5 = this.method_76(num2, list);
                                    cell.GridSpan = ((num5 - num) > 1) ? ((short) (num5 - num)) : ((short) 1);
                                    num = ((num5 - num) > 1) ? num5 : (num + 1);
                                }
                                else
                                {
                                    num += cell.GridSpanEx;
                                    num3 = (float) Math.Round((cell.WidthType == FtsWidth.Percentage) ? ((double) (((num4 * cell.Scaling) / 100f) * 20f)) : ((double) (cell.LayoutWidth * 20f)));
                                    num2 += num3;
                                }
                            }
                        }
                    }
                }
            }
        }

        private int method_76(float A_0, List<float> A_1)
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                if (Math.Abs((float) (A_0 - A_1[i])) <= 10f)
                {
                    return i;
                }
            }
            return -1;
        }

        private List<float> method_77()
        {
            List<float> list = new List<float>();
            int num = 0;
            float width = this.Width;
            if (this.PreferredTableWidth.method_51() == FtsWidth.Percentage)
            {
                width = this.method_54();
            }
            foreach (TableRow row in this.Rows)
            {
                if (!row.method_22())
                {
                    float item = 0f;
                    float num4 = 0f;
                    int num5 = 0;
                    item = 0f;
                    if (!list.Contains(item))
                    {
                        list.Add(item);
                    }
                    foreach (TableCell cell in row.Cells)
                    {
                        num5 += cell.GridSpanEx;
                        if (cell.GridSpanEx <= 1)
                        {
                            if (cell.WidthType == FtsWidth.Percentage)
                            {
                                num4 = (float) Math.Round((double) (((cell.Scaling * width) / 100f) * 20f));
                            }
                            else if (cell.WidthType == FtsWidth.Point)
                            {
                                num4 = (float) Math.Round((double) (cell.LayoutWidth * 20f));
                            }
                            item = (float) Math.Round((double) (item + num4));
                            if (!list.Contains(item))
                            {
                                list.Add(item);
                            }
                        }
                        else
                        {
                            if (cell.WidthType == FtsWidth.Percentage)
                            {
                                num4 = (float) Math.Round((double) (((cell.Scaling * width) / 100f) * 20f));
                            }
                            else if (cell.WidthType == FtsWidth.Point)
                            {
                                num4 = (float) Math.Round((double) (cell.LayoutWidth * 20f));
                            }
                            item = (float) Math.Round((double) (item + num4));
                        }
                    }
                    num5 += row.RowFormat.GridBefore + row.RowFormat.GridAfter;
                    num = Math.Max(num, num5);
                }
            }
            list.Sort();
            this.method_58(list);
            return list;
        }

        private bool method_78()
        {
            bool flag;
            int count = this.Rows[0].Cells.Count;
            using (IEnumerator enumerator = this.Rows.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    TableRow current = (TableRow) enumerator.Current;
                    if (count != current.Cells.Count)
                    {
                        goto Label_004C;
                    }
                }
                return false;
            Label_004C:
                flag = true;
            }
            return flag;
        }

        private bool method_79()
        {
            if (this.Rows.Count > 0)
            {
                int num2 = this.Rows[0].method_23();
                int num = 1;
                int count = this.Rows.Count;
                while (num < count)
                {
                    if (this.Rows[num].method_23() != num2)
                    {
                        return true;
                    }
                    num++;
                }
            }
            return false;
        }

        private void method_80(List<float> A_0, float A_1)
        {
            if (A_0.IndexOf(A_1) < 0)
            {
                if (A_0.Count <= 0)
                {
                    A_0.Add(A_1);
                }
                else
                {
                    int index = 0;
                    int count = A_0.Count;
                    while (index < count)
                    {
                        float num3 = A_0[index];
                        if (num3 > A_1)
                        {
                            A_0.Insert(index, A_1);
                            return;
                        }
                        if (count == (index + 1))
                        {
                            A_0.Add(A_1);
                        }
                        index++;
                    }
                }
            }
        }

        internal void method_81(FormatBase A_0, int A_1)
        {
            if (A_0 is RowFormat)
            {
                foreach (TableRow row3 in this.Rows)
                {
                    switch (A_1)
                    {
                        case 1:
                        {
                            row3.RowFormat.TextureStyle = (A_0 as RowFormat).TextureStyle;
                            continue;
                        }
                        case 3:
                        {
                            row3.RowFormat.BackColor = (A_0 as RowFormat).BackColor;
                            continue;
                        }
                    }
                    row3.RowFormat.method_52(A_1, this.TableFormat.method_51(A_1));
                }
            }
            else if (!(A_0 is Border) && !(A_0 is Borders))
            {
                if (A_0 is Paddings)
                {
                    foreach (TableRow row2 in this.Rows)
                    {
                        row2.RowFormat.Paddings.ImportContainer(this.TableFormat.Paddings);
                    }
                }
            }
            else
            {
                foreach (TableRow row in this.Rows)
                {
                    row.RowFormat.Borders.ImportContainer(this.TableFormat.Borders);
                }
            }
        }

        internal float method_82()
        {
            float num = 0f;
            Dictionary<int, float> dictionary = new Dictionary<int, float>();
            bool flag = true;
            if (this.Rows.Count > 0)
            {
                float num2 = 0f;
                TableCell cell = null;
                this.method_65(this.Rows[0]);
                int count = this.Rows[0].Cells.Count;
                int num4 = 0;
                int num5 = this.Rows.Count;
                while (num4 < num5)
                {
                    int key = 0;
                    num2 = 0f;
                    TableRow row = this.Rows[num4];
                    this.method_65(row);
                    int num13 = row.Cells.Count;
                    if (flag && (count != num13))
                    {
                        flag = false;
                    }
                    for (int i = 0; i < num13; i++)
                    {
                        cell = row.Cells[i];
                        float num10 = (cell.CellFormat.WidthUnit != FtsWidth.Percentage) ? cell.LayoutWidth : 0f;
                        num2 += num10;
                        num10 = (cell.GridSpanEx > 1) ? 0f : num10;
                        if (dictionary.ContainsKey(key))
                        {
                            dictionary[key] = Math.Max(dictionary[key], num10);
                        }
                        else
                        {
                            dictionary.Add(key, num10);
                        }
                        key++;
                        if (cell.GridSpanEx > 1)
                        {
                            for (int j = 1; j < cell.GridSpanEx; j++)
                            {
                                if (dictionary.ContainsKey(key))
                                {
                                    dictionary[key] = Math.Max(dictionary[key], 0f);
                                }
                                else
                                {
                                    dictionary.Add(key, 0f);
                                }
                                key++;
                            }
                        }
                    }
                    if (num2 > num)
                    {
                        num = num2;
                    }
                    num4++;
                }
            }
            float num11 = 0f;
            if (flag)
            {
                foreach (float num12 in dictionary.Values)
                {
                    num11 += num12;
                }
            }
            dictionary.Clear();
            dictionary = null;
            if (num11 > num)
            {
                num = num11;
            }
            if ((this.PreferredTableWidth.method_51() == FtsWidth.Point) && (this.PreferredWidth.Type == WidthType.Twip))
            {
                float num8 = ((float) this.PreferredWidth.Value) / 20f;
                if (num8 > num)
                {
                    num = num8;
                }
            }
            return num;
        }

        internal bool method_83()
        {
            TableRow row = null;
            for (int i = 0; i < this.rowCollection_0.Count; i++)
            {
                row = this.rowCollection_0[i];
                if (row.CharacterFormat.IsDeleteRevision || row.CharacterFormat.IsInsertRevision)
                {
                    if (this.rowCollection_0.Count <= 1)
                    {
                        return true;
                    }
                    this.rowCollection_0.Remove(row);
                    i--;
                }
            }
            return false;
        }

        internal bool method_84(CellWidthType A_0)
        {
            bool flag = true;
            foreach (TableRow row in this.Rows)
            {
                using (IEnumerator enumerator2 = row.Cells.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        TableCell current = (TableCell) enumerator2.Current;
                        if (current.CellWidthType != A_0)
                        {
                            goto Label_004F;
                        }
                    }
                    goto Label_0067;
                Label_004F:
                    flag = false;
                }
            Label_0067:
                if (!flag)
                {
                    return flag;
                }
            }
            return flag;
        }

        internal bool method_85()
        {
            return this.method_84(CellWidthType.Auto);
        }

        internal bool method_86()
        {
            return this.method_84(CellWidthType.Point);
        }

        internal bool method_87()
        {
            return this.method_84(CellWidthType.Percentage);
        }

        internal Interface5 method_88()
        {
            this.interface5_0 = new TableLayoutInfo(this);
            return this.interface5_0;
        }

        private void method_89()
        {
            if (this.nullable_0.HasValue)
            {
                float? nullable = null;
                if (this.bool_3)
                {
                    nullable = new float?(this.nullable_1.Value);
                }
                else if (base.Document.LastSection != null)
                {
                    nullable = new float?(base.Document.LastSection.PageSetup.ClientWidth / ((float) this.nullable_0.Value));
                }
                if (nullable.HasValue)
                {
                    if (!this.bool_3)
                    {
                        this.nullable_1 = new float?(nullable.Value);
                    }
                    if (!this.bool_4)
                    {
                        this.float_5 = new float[this.nullable_0.Value];
                        for (int i = 0; i < this.float_5.Length; i++)
                        {
                            this.float_5[i] = nullable.Value;
                        }
                    }
                }
            }
        }

        public void RemoveAbsPosition()
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (BodyRegion region in cell.Items)
                    {
                        if (region is Paragraph)
                        {
                            (region as Paragraph).RemoveAbsPosition();
                        }
                        else if (region is Table)
                        {
                            (region as Table).RemoveAbsPosition();
                        }
                    }
                }
                if (row.RowFormat != null)
                {
                    row.RowFormat.RemovePositioning();
                }
            }
        }

        internal override void RemoveCFormatChanges()
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.CharacterFormat.RemoveChanges();
                foreach (TableCell cell in row.Cells)
                {
                    cell.CharacterFormat.RemoveChanges();
                }
            }
        }

        internal override void RemovePFormatChanges()
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.RowFormat.RemoveChanges();
            }
        }

        public override int Replace(Regex pattern, TextSelection textSelection)
        {
            return this.Replace(pattern, textSelection, false);
        }

        public override int Replace(Regex pattern, string replace)
        {
            int num = 0;
            foreach (TableRow row in this.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (BodyRegion region in cell.ChildObjects)
                    {
                        num += region.Replace(pattern, replace);
                        if (base.Document.ReplaceFirst && (num > 0))
                        {
                            return num;
                        }
                    }
                }
            }
            return num;
        }

        public override int Replace(Regex pattern, TextSelection textSelection, bool saveFormatting)
        {
            textSelection.method_1();
            int num = 0;
            foreach (TableRow row in this.rowCollection_0)
            {
                foreach (TableCell cell in row.Cells)
                {
                    num += cell.method_25(pattern, textSelection, saveFormatting);
                    if (base.Document.ReplaceFirst && (num > 0))
                    {
                        return num;
                    }
                }
            }
            return num;
        }

        public override int Replace(string given, string replace, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Replace(pattern, replace);
        }

        public void ResetCells(int rowsNum, int columnsNum)
        {
            int num = 0;
            if ((rowsNum <= 0) || (columnsNum <= 0))
            {
                throw new ArgumentException(BookmarkStart.b("爥䤧䠩䀫䬭ု弱䄳䔵䰷ᨹ吻弽㘿❁摃❅㱇橉⁋⭍ㅏ⅑⁓癕㝗㑙㥛繝቟ൡ፣䙥१ѩ࡫乭Ὧᱱᅳ噵᭷ᕹၻ୽", num));
            }
            this.method_37(rowsNum, columnsNum, null, null);
        }

        public void ResetCells(int rowsNum, int columnsNum, RowFormat format, float cellWidth)
        {
            int num = 15;
            if ((rowsNum <= 0) || (columnsNum <= 0))
            {
                throw new ArgumentException(BookmarkStart.b("愴嘶嬸场堼Ἶⱀ㙂㙄㍆楈⍊ⱌ㥎㑐獒㑔⍖祘㝚㡜㹞በᝢ䕤ࡦݨ๪䵬ᵮṰѲ啴ᙶ᝸ὺ嵼ၾꖄﾐ", num));
            }
            float? nullable = new float?(cellWidth);
            Section section = this.method_55();
            if (section != null)
            {
                cellWidth = section.PageSetup.ClientWidth / ((float) columnsNum);
            }
            else if (base.Document.LastSection != null)
            {
                cellWidth = base.Document.LastSection.PageSetup.ClientWidth / ((float) columnsNum);
            }
            this.method_37(rowsNum, columnsNum, format, nullable);
        }

        internal override void ResetLayoutInfo()
        {
            this.bool_7 = false;
            base.ResetLayoutInfo();
            this.interface5_0 = null;
            this.float_4 = float.MinValue;
        }

        internal override void SetChangedCFormat(bool check)
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.CharacterFormat.IsChangedFormat = check;
                foreach (TableCell cell in row.Cells)
                {
                    cell.CharacterFormat.IsChangedFormat = check;
                }
            }
        }

        internal override void SetChangedPFormat(bool check)
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.RowFormat.IsChangedFormat = check;
            }
        }

        internal override void SetDeleteRev(bool check)
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.CharacterFormat.IsDeleteRevision = check;
            }
        }

        internal override void SetInsertRev(bool check)
        {
            foreach (TableRow row in this.rowCollection_0)
            {
                row.CharacterFormat.IsInsertRevision = check;
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            dc.vmethod_1(this, ltWidget);
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        Interface3 Interface4.GetCellWidget(int row, int column)
        {
            if (column < this.rowCollection_0[row].Cells.Count)
            {
                return this.rowCollection_0[row].Cells[column];
            }
            return null;
        }

        Interface1 Interface4.GetRowWidget(int row)
        {
            return this.rowCollection_0[row];
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("䴸䈺䴼娾", 0x13), BookmarkStart.b("洸娺弼匾⑀", 0x13));
        }

        internal ArrayList _ColumnWidths
        {
            get
            {
                return (ArrayList) this.TableFormat.method_51(0x13ef);
            }
        }

        internal bool ApplyStyleForBandedColumns
        {
            get
            {
                return ((this.FirstRow.RowFormat.TableOption & TableStyleOptions.ColumnBands) > TableStyleOptions.None);
            }
            set
            {
                if (value)
                {
                    this.FirstRow.RowFormat.TableOption |= TableStyleOptions.ColumnBands;
                }
                else
                {
                    this.FirstRow.RowFormat.TableOption ^= TableStyleOptions.ColumnBands;
                }
            }
        }

        internal bool ApplyStyleForBandedRows
        {
            get
            {
                return ((this.FirstRow.RowFormat.TableOption & TableStyleOptions.RowBands) > TableStyleOptions.None);
            }
            set
            {
                if (value)
                {
                    this.FirstRow.RowFormat.TableOption |= TableStyleOptions.RowBands;
                }
                else
                {
                    this.FirstRow.RowFormat.TableOption ^= TableStyleOptions.RowBands;
                }
            }
        }

        internal bool ApplyStyleForFirstColumn
        {
            get
            {
                return ((this.FirstRow.RowFormat.TableOption & TableStyleOptions.FirstColumn) > TableStyleOptions.None);
            }
            set
            {
                if (value)
                {
                    this.FirstRow.RowFormat.TableOption |= TableStyleOptions.FirstColumn;
                }
                else
                {
                    this.FirstRow.RowFormat.TableOption ^= TableStyleOptions.FirstColumn;
                }
            }
        }

        internal bool ApplyStyleForHeaderRow
        {
            get
            {
                return ((this.FirstRow.RowFormat.TableOption & TableStyleOptions.FirstRow) > TableStyleOptions.None);
            }
            set
            {
                if (value)
                {
                    this.FirstRow.RowFormat.TableOption |= TableStyleOptions.FirstRow;
                }
                else
                {
                    this.FirstRow.RowFormat.TableOption ^= TableStyleOptions.FirstRow;
                }
            }
        }

        internal bool ApplyStyleForLastColumn
        {
            get
            {
                return ((this.FirstRow.RowFormat.TableOption & TableStyleOptions.LastColumn) > TableStyleOptions.None);
            }
            set
            {
                if (value)
                {
                    this.FirstRow.RowFormat.TableOption |= TableStyleOptions.LastColumn;
                }
                else
                {
                    this.FirstRow.RowFormat.TableOption ^= TableStyleOptions.LastColumn;
                }
            }
        }

        internal bool ApplyStyleForLastRow
        {
            get
            {
                return ((this.FirstRow.RowFormat.TableOption & TableStyleOptions.LastRow) > TableStyleOptions.None);
            }
            set
            {
                if (value)
                {
                    this.FirstRow.RowFormat.TableOption |= TableStyleOptions.LastRow;
                }
                else
                {
                    this.FirstRow.RowFormat.TableOption ^= TableStyleOptions.LastRow;
                }
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.rowCollection_0;
            }
        }

        internal DocumentObject ClonedOwner
        {
            get
            {
                return this.documentObject_0;
            }
            set
            {
                this.documentObject_0 = value;
            }
        }

        public float[] ColumnWidth
        {
            get
            {
                return this.float_5;
            }
            set
            {
                int num = 14;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("眳夵吷伹儻倽᜿⭁⁃㉅⁇", num));
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 0f)
                    {
                        string message = string.Format(BookmarkStart.b("眳夵吷伹儻倽᜿⭁⁃㉅⁇ᅉ㝋繍ⵏད瑓橕硗橙灛繝ᑟ੡ţ䙥ὧͩ࡫ᩭᡯ剱᭳ၵ塷᥹፻ችꚅ꺍ﺏ﶑뚕流ﾙ벛얟톡힣蚥\udca7\uc2a9춫삭邯花骳", num), i);
                        throw new ArgumentOutOfRangeException(BookmarkStart.b("䈳圵吷伹夻", num), message);
                    }
                }
                this.float_5 = value;
                this.bool_4 = true;
            }
        }

        private float[] ColumnWidthPercent
        {
            get
            {
                return this.float_6;
            }
            set
            {
                int num = 13;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("瀲娴嬶䰸嘺匼栾⡀❂ㅄ⽆᥈⹊㽌ⱎ㑐㵒⅔", num));
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 0f)
                    {
                        string message = string.Format(BookmarkStart.b("䔲吴嬶䰸帺昼䐾煀㹂ᡄ杆畈歊経捎煐❒㵔㉖祘ⱚ㑜㭞ᕠୢ䕤ࡦཨ䭪๬nᵰٲᡴ᥶奸᡺ᱼᅾꆀꦈ꾎﶐릘ﺞ쾠莢閤覦", num), i);
                        throw new ArgumentOutOfRangeException(BookmarkStart.b("䔲吴嬶䰸帺", num), message);
                    }
                }
            }
        }

        public int DefaultColumnsNumber
        {
            get
            {
                if (!this.nullable_0.HasValue)
                {
                    return 0;
                }
                return this.nullable_0.Value;
            }
            set
            {
                int num = 7;
                if (value > 0x3f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("椬䨮地刲䀴嬶䴸砺刼匾㑀⹂⭄㑆݈㹊⁌ⵎ㑐⅒", num), BookmarkStart.b("挬䀮䔰ጲ䘴䈶䤸䬺刼䴾㕀♂⅄杆⑈⑊㽌⩎煐❒㵔㙖㝘筚歜汞䅠b੤୦ᱨ٪ͬᱮ彰", num));
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("椬䨮地刲䀴嬶䴸砺刼匾㑀⹂⭄㑆݈㹊⁌ⵎ㑐⅒", num), BookmarkStart.b("夬䜮吰ጲ嬴䈶吸夺堼䴾慀ⱂ⍄杆⩈⑊⅌㩎㱐㵒畔㑖㡘㕚絜ㅞ๠ᝢ䕤զ౨䭪Ŭ੮ɰr啴Ͷᅸ᩺፼彾놀궂", num));
                }
                this.nullable_0 = new int?(value);
                this.method_89();
            }
        }

        public float DefaultColumnWidth
        {
            get
            {
                if (!this.nullable_1.HasValue)
                {
                    return 0f;
                }
                return this.nullable_1.Value;
            }
            set
            {
                int num = 6;
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("栫䬭嘯匱䄳娵䰷礹医刽㔿⽁⩃ᅅⅇ⹉㡋♍", num), BookmarkStart.b("堫䘭唯ሱ䌳張尷丹吻ḽ⼿⑁摃╅❇♉㥋⍍㹏牑㝓㝕㙗穙㉛ㅝᑟ䉡٣ͥ䡧٩५ᵭͯ剱sṵ᥷ᑹ屻乽깿", num));
                }
                this.nullable_1 = new float?(value);
                this.bool_3 = true;
                this.method_89();
            }
        }

        public float DefaultRowHeight
        {
            get
            {
                if (!this.nullable_2.HasValue)
                {
                    return 0f;
                }
                return this.nullable_2.Value;
            }
            set
            {
                int num = 15;
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("焴制弸娺䠼匾㕀ᅂ⩄うň⹊⑌⡎㥐❒", num), BookmarkStart.b("䄴弶尸ᬺ唼娾⡀⑂ⵄ㍆楈⑊⭌潎⍐㱒≔睖㩘㩚㍜罞འౢᅤ䝦୨๪䵬ͮᑰrٴ坶൸፺ᱼᅾꆀ뎂ꮄ", num));
                }
                this.nullable_2 = new float?(value);
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Table;
            }
        }

        internal Document Documnet
        {
            get
            {
                DocumentObject owner = base.Owner;
                while (owner != null)
                {
                    if (owner is Document)
                    {
                        break;
                    }
                    owner = owner.Owner;
                }
                if (owner is Document)
                {
                    return (owner as Document);
                }
                return null;
            }
        }

        internal XmlTableFormat DocxTableFormat
        {
            get
            {
                if (this.xmlTableFormat_0 == null)
                {
                    this.xmlTableFormat_0 = new XmlTableFormat(this);
                }
                return this.xmlTableFormat_0;
            }
            set
            {
                this.xmlTableFormat_0 = value;
            }
        }

        internal bool DontAdjustLineHeightInTable
        {
            get
            {
                return base.Document.Settings.method_5().method_0(CompatibilityOptions.DontAdjustLineHeightInTable);
            }
        }

        internal bool DontBreakWrappedTables
        {
            get
            {
                return base.Document.Settings.method_5().method_0(CompatibilityOptions.DontBreakWrappedTables);
            }
        }

        public TableRow FirstRow
        {
            get
            {
                return (this.Rows.FirstItem as TableRow);
            }
        }

        internal ParagraphFormat FrameFormat
        {
            get
            {
                if (this.IsFrame)
                {
                    return this.Rows[0].Cells[0].Paragraphs[0].Format;
                }
                return null;
            }
        }

        internal short FrameX
        {
            get
            {
                if (this.IsFrame)
                {
                    return this.FrameFormat.FrameX;
                }
                return 0;
            }
        }

        internal short FrameY
        {
            get
            {
                if (this.IsFrame)
                {
                    return this.FrameFormat.FrameY;
                }
                return 0;
            }
        }

        internal bool GrowAuotFit
        {
            get
            {
                return base.Document.Settings.method_5().method_0(CompatibilityOptions.GrowAutoFit);
            }
        }

        public float IndentFromLeft
        {
            get
            {
                if (((this.TableFormat.RowIndent != 0f) || this.TableFormat.HasValue(0x10f4)) && (this.TableFormat.RowIndent != float.MinValue))
                {
                    return this.TableFormat.RowIndent;
                }
                return this.TableFormat.LeftIndent;
            }
            set
            {
                int num = 9;
                if (value != 0f)
                {
                    if ((value > float.MaxValue) || (value < float.MinValue))
                    {
                        throw new ArgumentOutOfRangeException(BookmarkStart.b("昮弰圲倴夶䴸紺似倾ⱀག⁄ⅆ㵈", num), string.Concat(new object[] { BookmarkStart.b("昮弰圲倴夶䴸紺似倾ⱀག⁄ⅆ㵈歊㹌❎㹐♒㥔㍖祘㥚㡜罞ൠౢቤɦ᭨䭪ᥬݮၰᵲ啴", num), 3.402823E+38f, BookmarkStart.b("༮倰崲儴᜶唸娺似堾⑀ㅂ敄㍆ⅈ⩊⍌潎", num), -3.402823E+38f }));
                    }
                    foreach (TableRow row in this.Rows)
                    {
                        row.RowFormat.RowIndent = value;
                    }
                }
            }
        }

        int Interface4.ColumnsCount
        {
            get
            {
                int num = 0;
                for (int i = 0; i < this.rowCollection_0.Count; i++)
                {
                    int num3 = 0;
                    int num4 = 0;
                    int count = this.rowCollection_0[i].Cells.Count;
                    for (int j = 0; j < this.rowCollection_0[i].Cells.Count; j++)
                    {
                        num4 += this.rowCollection_0[i].Cells[j].GridSpanEx;
                    }
                    num3 = Math.Max(count, num4);
                    if (num < num3)
                    {
                        num = num3;
                    }
                }
                return num;
            }
        }

        int Interface4.MaxRowIndex
        {
            get
            {
                int count = 0;
                int num2 = 0;
                for (int i = 0; i < this.rowCollection_0.Count; i++)
                {
                    if (count < this.rowCollection_0[i].Cells.Count)
                    {
                        count = this.rowCollection_0[i].Cells.Count;
                        num2 = i;
                    }
                }
                return num2;
            }
        }

        int Interface4.RowsCount
        {
            get
            {
                return this.rowCollection_0.Count;
            }
        }

        Interface5 Interface4.TableLayoutInfo
        {
            get
            {
                if (this.interface5_0 == null)
                {
                    this.interface5_0 = new TableLayoutInfo(this);
                }
                return this.interface5_0;
            }
        }

        internal bool IsFrame
        {
            get
            {
                if ((((this.IsTextBox || this.IsInCell) || ((this.Rows.Count <= 0) || (this.Rows[0].Cells.Count <= 0))) || ((this.Rows[0].Cells[0].Paragraphs.Count <= 0) || !this.Rows[0].Cells[0].Paragraphs[0].Format.IsFrame)) || (((Class59.smethod_4((float) this.Rows[0].Cells[0].Paragraphs[0].Format.FrameYEx, this.TableFormat.Positioning.VertPosition * 20f, 0.0001f) == 0) && (Class59.smethod_4((float) this.Rows[0].Cells[0].Paragraphs[0].Format.FrameXEx, this.TableFormat.Positioning.HorizPosition * 20f, 0.0001f) == 0)) && ((this.Rows[0].Cells[0].Paragraphs[0].Format.FrameHorizontalPosition == this.TableFormat.Positioning.HorizPositionAbs) && (this.Rows[0].Cells[0].Paragraphs[0].Format.FrameVerticalPosition == this.TableFormat.Positioning.VertPositionAbs))))
                {
                    return false;
                }
                return true;
            }
        }

        internal bool IsHasCaculatedCellWidth
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

        internal bool IsInCell
        {
            get
            {
                return (base.Owner is TableCell);
            }
        }

        internal bool IsInSameFrameWithNextSibling
        {
            get
            {
                if (this.IsFrame)
                {
                    if (base.NextSibling is Paragraph)
                    {
                        Paragraph nextSibling = base.NextSibling as Paragraph;
                        if (((nextSibling.Format.IsFrame && (nextSibling.Format.FrameWidth == this.FrameFormat.FrameWidth)) && ((nextSibling.Format.FrameX == this.FrameFormat.FrameX) && (nextSibling.Format.FrameHorizontalDistanceFromText == this.FrameFormat.FrameHorizontalDistanceFromText))) && (((nextSibling.Format.FrameHeight == this.FrameFormat.FrameHeight) && (nextSibling.Format.FrameY == this.FrameFormat.FrameY)) && (nextSibling.Format.FrameVerticalDistanceFromText == this.FrameFormat.FrameVerticalDistanceFromText)))
                        {
                            return true;
                        }
                    }
                    else if (base.NextSibling is Table)
                    {
                        Table table = base.NextSibling as Table;
                        if (((table.IsFrame && (table.FrameFormat.FrameWidth == this.FrameFormat.FrameWidth)) && ((table.FrameFormat.FrameX == this.FrameFormat.FrameX) && (table.FrameFormat.FrameHorizontalDistanceFromText == this.FrameFormat.FrameHorizontalDistanceFromText))) && (((table.FrameFormat.FrameHeight == this.FrameFormat.FrameHeight) && (table.FrameFormat.FrameY == this.FrameFormat.FrameY)) && (table.FrameFormat.FrameVerticalDistanceFromText == this.FrameFormat.FrameVerticalDistanceFromText)))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        internal bool IsSDTTable
        {
            [CompilerGenerated]
            get
            {
                return this.bool_8;
            }
            [CompilerGenerated]
            set
            {
                this.bool_8 = value;
            }
        }

        internal virtual bool IsTextBox
        {
            get
            {
                return false;
            }
        }

        internal bool IsTextBoxInTable
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        public TableCell this[int row, int column]
        {
            get
            {
                return this.Rows[row].Cells[column];
            }
        }

        public TableCell LastCell
        {
            get
            {
                TableRow lastRow = this.LastRow;
                if (lastRow == null)
                {
                    return null;
                }
                int count = lastRow.Cells.Count;
                if (count <= 0)
                {
                    return null;
                }
                return lastRow.Cells[count - 1];
            }
        }

        internal Class500 LastLayoutPage
        {
            [CompilerGenerated]
            get
            {
                return this.class500_0;
            }
            [CompilerGenerated]
            set
            {
                this.class500_0 = value;
            }
        }

        internal Paragraph LastParagraph
        {
            get
            {
                TableCell lastCell = this.LastCell;
                if (this.LastCell != null)
                {
                    if (lastCell.ChildObjects.Count <= 0)
                    {
                        return null;
                    }
                    DocumentObject lastChild = lastCell.LastChild;
                    if (lastChild is Paragraph)
                    {
                        return (lastChild as Paragraph);
                    }
                    if (lastChild is Table)
                    {
                        return (lastChild as Table).LastParagraph;
                    }
                }
                return null;
            }
        }

        public TableRow LastRow
        {
            get
            {
                return (this.Rows.LastItem as TableRow);
            }
        }

        internal float LayoutWidth
        {
            get
            {
                if (this.float_4 == float.MinValue)
                {
                    return this.Width;
                }
                return this.float_4;
            }
            set
            {
                this.float_4 = value;
            }
        }

        internal ArrayList Offsets
        {
            get
            {
                return this.arrayList_0;
            }
            set
            {
                this.arrayList_0 = value;
            }
        }

        internal Class15 PreferredTableWidth
        {
            get
            {
                return (Class15) this.TableFormat.method_51(0x1086);
            }
            set
            {
                this.TableFormat.method_52(0x1086, value);
            }
        }

        public Spire.Doc.PreferredWidth PreferredWidth
        {
            get
            {
                if (this.PreferredTableWidth != null)
                {
                    switch (this.PreferredTableWidth.method_51())
                    {
                        case FtsWidth.None:
                            return new Spire.Doc.PreferredWidth(WidthType.None, 0);

                        case FtsWidth.Auto:
                            return new Spire.Doc.PreferredWidth(WidthType.Auto, 0);

                        case FtsWidth.Percentage:
                            return new Spire.Doc.PreferredWidth(WidthType.Percentage, (short) this.PreferredTableWidth.method_49());

                        case FtsWidth.Point:
                            return new Spire.Doc.PreferredWidth(WidthType.Twip, (short) this.PreferredTableWidth.method_49());
                    }
                }
                return new Spire.Doc.PreferredWidth(WidthType.None, 0);
            }
            set
            {
                this.PreferredTableWidth.method_52((FtsWidth) value.Type);
                this.PreferredTableWidth.method_50((float) value.Value);
            }
        }

        public RowCollection Rows
        {
            get
            {
                return this.rowCollection_0;
            }
        }

        internal RectangleF TableBounds
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

        public string TableDescription
        {
            get
            {
                return this.string_9;
            }
            set
            {
                this.string_9 = value;
            }
        }

        public RowFormat TableFormat
        {
            get
            {
                if (this.rowFormat_0 == null)
                {
                    this.rowFormat_0 = new RowFormat();
                }
                if (this.rowFormat_0.IsDefault && (this.Rows.Count > 0))
                {
                    this.rowFormat_0.ImportContainer(this.FirstRow.RowFormat);
                }
                this.rowFormat_0.method_0(this);
                return this.rowFormat_0;
            }
        }

        internal List<float> TableGrid
        {
            get
            {
                if (!this.bool_6)
                {
                    this.list_0 = null;
                }
                if (this.list_0 == null)
                {
                    if ((this.rowCollection_0 != null) && (this.rowCollection_0.Count > 0))
                    {
                        this.list_0 = this.method_51(false);
                    }
                    else
                    {
                        this.list_0 = new List<float>();
                    }
                    this.bool_6 = true;
                }
                return this.list_0;
            }
        }

        internal Interface8 TableStyle
        {
            get
            {
                return this.interface8_0;
            }
        }

        public string TableStyleName
        {
            get
            {
                if (this.interface8_0 == null)
                {
                    return null;
                }
                return this.interface8_0.Name;
            }
        }

        internal virtual ITextBox TextBox
        {
            get
            {
                return null;
            }
        }

        internal virtual Spire.Doc.Formatting.TextBoxFormat TextBoxFormat
        {
            get
            {
                return null;
            }
        }

        public string Title
        {
            get
            {
                return this.string_8;
            }
            set
            {
                this.string_8 = value;
            }
        }

        internal List<float> ToDocGrid
        {
            get
            {
                if (this.list_2 == null)
                {
                    if ((this.rowCollection_0 != null) && (this.rowCollection_0.Count > 0))
                    {
                        this.list_2 = this.method_52(this._ColumnWidths);
                    }
                    else
                    {
                        this.list_2 = new List<float>();
                    }
                }
                return this.list_2;
            }
        }

        internal List<float> TrackTableGrid
        {
            get
            {
                if (this.list_1 == null)
                {
                    this.list_1 = new List<float>();
                }
                return this.list_1;
            }
        }

        internal XmlTableFormat TrackTblFormat
        {
            get
            {
                if (this.xmlTableFormat_1 == null)
                {
                    this.xmlTableFormat_1 = new XmlTableFormat(this);
                }
                return this.xmlTableFormat_1;
            }
        }

        public float Width
        {
            get
            {
                if (this.float_3 == float.MinValue)
                {
                    float num = this.method_82();
                    this.float_3 = num;
                }
                return this.float_3;
            }
            internal set
            {
                this.float_3 = value;
            }
        }

        protected class TableLayoutInfo : Interface5
        {
            private bool[] bool_0;
            private bool bool_1;
            private bool bool_2;
            private bool bool_3;
            private float[] float_0;
            private float float_1;
            private int int_0;
            private bool? nullable_0;
            private Table table_0;
            private RowFormat.TablePositioning tablePositioning_0;

            public TableLayoutInfo(Table table)
            {
                this.table_0 = table;
                int count = 0;
                int num2 = 0;
                for (int i = 0; i < this.table_0.Rows.Count; i++)
                {
                    if (count < this.table_0.Rows[i].Cells.Count)
                    {
                        count = this.table_0.Rows[i].Cells.Count;
                        num2 = i;
                    }
                }
                this.float_1 = this.table_0.LayoutWidth;
                this.float_0 = new float[count];
                this.bool_0 = new bool[count];
                int index = 0;
                int num5 = count;
                while (index < num5)
                {
                    TableCell cell = this.table_0.Rows[num2].Cells[index];
                    this.float_0[index] = cell.LayoutWidth;
                    this.bool_0[index] = cell.IsFixedWidth;
                    index++;
                }
                this.int_0 = this.method_3();
                this.bool_1 = this.method_2();
                if ((!this.bool_1 && !this.table_0.IsInCell) && this.table_0.IsFrame)
                {
                    this.tablePositioning_0 = new RowFormat.TablePositioning(this.table_0.TableFormat.method_50());
                    Paddings paddings = this.table_0.TableFormat.Paddings;
                    Paragraph paragraph = this.table_0.Rows[0].Cells[0].Paragraphs[0];
                    this.Interface5.get_TablePosition().HorizRelationTo = (HorizontalRelation) paragraph.Format.FrameHorizontalPos;
                    if (this.Interface5.get_TablePosition().HorizRelationTo != HorizontalRelation.Column)
                    {
                        this.Interface5.get_TablePosition().HorizPositionAbs = this.method_0(paragraph.Format.FrameX);
                        if (this.Interface5.get_TablePosition().HorizPositionAbs == HorizontalPosition.Left)
                        {
                            if (paragraph.Format.FrameWidthRule == FrameSizeRule.Exact)
                            {
                                if (this.table_0.TableFormat.HorizontalAlignment == RowAlignment.Center)
                                {
                                    this.Interface5.get_TablePosition().HorizPositionEx = ((((float) paragraph.Format.FrameX) / 20f) - paddings.Left) + ((paragraph.Format.FrameWidthEx - this.table_0.Width) / 2f);
                                }
                                else if (this.table_0.TableFormat.HorizontalAlignment == RowAlignment.Right)
                                {
                                    this.Interface5.get_TablePosition().HorizPositionEx = ((((float) paragraph.Format.FrameX) / 20f) - paddings.Left) + (paragraph.Format.FrameWidthEx - this.table_0.Width);
                                }
                                else
                                {
                                    this.Interface5.get_TablePosition().HorizPositionEx = (((float) paragraph.Format.FrameX) / 20f) - paddings.Left;
                                }
                            }
                            else
                            {
                                this.Interface5.get_TablePosition().HorizPositionEx = (((float) paragraph.Format.FrameX) / 20f) - paddings.Left;
                            }
                        }
                    }
                    this.Interface5.get_TablePosition().VertRelationTo = (VerticalRelation) paragraph.Format.FrameVerticalPos;
                    if (this.Interface5.get_TablePosition().VertRelationTo != VerticalRelation.Paragraph)
                    {
                        this.Interface5.get_TablePosition().VertPositionAbs = this.method_1(paragraph.Format.FrameY);
                        if (this.Interface5.get_TablePosition().VertPositionAbs == VerticalPosition.None)
                        {
                            this.Interface5.get_TablePosition().VertPositionEx = (((float) paragraph.Format.FrameY) / 20f) - paddings.Top;
                        }
                    }
                    this.bool_1 = true;
                }
            }

            private HorizontalPosition method_0(short A_0)
            {
                switch (A_0)
                {
                    case -16:
                        return HorizontalPosition.Outside;

                    case -12:
                        return HorizontalPosition.Inside;

                    case -8:
                        return HorizontalPosition.Right;

                    case -4:
                        return HorizontalPosition.Center;
                }
                return HorizontalPosition.Left;
            }

            private VerticalPosition method_1(short A_0)
            {
                switch (A_0)
                {
                    case -20:
                        return VerticalPosition.Outside;

                    case -16:
                        return VerticalPosition.Inside;

                    case -12:
                        return VerticalPosition.Bottom;

                    case -8:
                        return VerticalPosition.Center;

                    case -4:
                        return VerticalPosition.Top;
                }
                return VerticalPosition.None;
            }

            private bool method_2()
            {
                return this.table_0.TableFormat.WrapTextAround;
            }

            private int method_3()
            {
                int num = 0;
                for (int i = 0; i < this.table_0.Rows.Count; i++)
                {
                    TableRow row = this.table_0.Rows[i];
                    if (!row.IsHeader)
                    {
                        return num;
                    }
                    num++;
                }
                return num;
            }

            double Interface5.CellPaddings
            {
                get
                {
                    if (this.table_0.Owner.Owner is TableCell)
                    {
                        return (double) ((this.table_0.Owner.Owner as TableCell).CellFormat.Paddings.Left + (this.table_0.Owner.Owner as TableCell).CellFormat.Paddings.Right);
                    }
                    return 0.0;
                }
            }

            double Interface5.CellSpacings
            {
                get
                {
                    if (this.table_0.Owner.Owner is TableCell)
                    {
                        double num = (this.table_0.Owner.Owner as TableCell).OwnerRow.RowFormat.CellSpacingEx * 2f;
                        return Math.Max(0.0, num);
                    }
                    return 0.0;
                }
            }

            float[] Interface5.CellsWidth
            {
                get
                {
                    return this.float_0;
                }
                set
                {
                    this.float_0 = value;
                }
            }

            int Interface5.HeadersRowCount
            {
                get
                {
                    return this.int_0;
                }
            }

            float Interface5.Height
            {
                get
                {
                    return 0f;
                }
            }

            bool[] Interface5.IsDefaultCells
            {
                get
                {
                    return this.bool_0;
                }
            }

            bool Interface5.IsFrame
            {
                get
                {
                    if (!this.nullable_0.HasValue)
                    {
                        this.nullable_0 = new bool?(this.table_0.IsFrame);
                    }
                    return this.nullable_0.Value;
                }
            }

            bool Interface5.IsSplitFirstRow
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

            bool Interface5.IsSplitted
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

            RowFormat.TablePositioning Interface5.TablePosition
            {
                get
                {
                    if (this.tablePositioning_0 == null)
                    {
                        return this.table_0.TableFormat.Positioning;
                    }
                    return this.tablePositioning_0;
                }
            }

            bool Interface5.UseAbsolutePosition
            {
                get
                {
                    return this.bool_1;
                }
            }

            float Interface5.Width
            {
                get
                {
                    return this.float_1;
                }
                set
                {
                    this.float_1 = value;
                }
            }
        }
    }
}

