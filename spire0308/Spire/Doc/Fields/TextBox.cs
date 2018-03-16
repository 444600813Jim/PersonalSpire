namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class TextBox : ShapeObject, Interface1, ITextBox
    {
        private byte byte_5;
        private int int_8;
        private long long_6;
        private long long_7;
        private long long_8;
        protected Spire.Doc.Body m_textBody;
        protected TextBoxFormat m_txbxFormat;
        [CompilerGenerated]
        private ShapeObject shapeObject_0;
        private string string_8;
        private string[] string_9;
        internal Table table_0;

        public TextBox(IDocument doc) : base((Document) doc)
        {
            this.method_75(doc);
            base.SetShapeType(ShapeType.TextBox);
        }

        internal TextBox(IDocument A_0, ShapeObject A_1) : base((Document) A_0)
        {
            base.ShapePr = A_1.ShapePr;
            this.method_75(A_0);
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            base.Document.TextBoxes.method_5(this);
        }

        protected override object CloneImpl()
        {
            TextBox box = (TextBox) base.CloneImpl();
            box.m_textBody = (Spire.Doc.Body) this.Body.Clone();
            int num = 0;
            int count = box.m_textBody.Items.Count;
            while (num < count)
            {
                box.m_textBody.Items[num].method_0(box.m_textBody);
                num++;
            }
            box.m_textBody.method_0(box);
            box.m_txbxFormat = new TextBoxFormat(box);
            box.m_txbxFormat.method_0(box);
            box.InternerTextbox = box;
            box.bool_4 = true;
            return box;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            this.Body.CloneRelationsTo(doc, nextOwner);
            base.Document.method_157(doc, this);
            base.bool_4 = false;
        }

        internal override void Close()
        {
            base.Close();
            if (this.m_textBody != null)
            {
                this.m_textBody.method_28();
                this.m_textBody = null;
            }
            this.m_txbxFormat = null;
            if (this.table_0 != null)
            {
                this.table_0.Close();
                this.table_0 = null;
            }
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_39(this.Format.AllowOverlap);
            if (this.Format.TextWrappingStyle != TextWrappingStyle.Inline)
            {
                base.interface23_0.imethod_13(true);
            }
            TextWrappingStyle textWrappingStyle = this.Format.TextWrappingStyle;
            if (textWrappingStyle != TextWrappingStyle.Inline)
            {
                if ((textWrappingStyle != TextWrappingStyle.InFrontOfText) && (textWrappingStyle != TextWrappingStyle.Behind))
                {
                    base.interface23_0.imethod_19(true);
                    base.interface23_0.imethod_17(false);
                }
                else
                {
                    base.interface23_0.imethod_21(true);
                    base.interface23_0.imethod_17(false);
                }
            }
            else
            {
                base.interface23_0.imethod_15(true);
            }
        }

        internal override void Detach()
        {
            base.Document.TextBoxes.method_6(this);
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䰭弯嘱䴳", 8), this.Body);
            base.XDLSHolder.AddElement(BookmarkStart.b("娭唯䨱䀳吵圷䈹ᄻ堽⼿ぁ⥃❅㱇", 8), this.Format);
        }

        private void method_75(IDocument A_0)
        {
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(A_0);
            base.m_charFormat.method_0(this);
            this.m_txbxFormat = new TextBoxFormat(this);
            this.m_txbxFormat.method_0(this);
            this.m_textBody = new Spire.Doc.Body(base.Document, this);
            base.InternerTextbox = this;
        }

        internal BodyRegion method_76()
        {
            if (base.OwnerParagraph != null)
            {
                return base.OwnerParagraph.GetNextTextBodyItem();
            }
            return null;
        }

        internal void method_77(Spire.Doc.Body A_0)
        {
            this.m_textBody = A_0;
        }

        internal Table method_78(Interface30 A_0)
        {
            int num = 7;
            bool flag = this.table_0 is Class7;
            bool flag2 = base.method_1() != null;
            if (!flag || flag2)
            {
                this.table_0 = new Class7(this);
                this.table_0.ResetCells(1, 1);
            }
            this.table_0.method_0(base.Owner);
            TableRow row = this.table_0.Rows[0];
            TableCell cell = row.Cells[0];
            float left = 0f;
            float top = 0f;
            float bottom = 0f;
            float right = 0f;
            float width = 0f;
            float height = 0f;
            float num2 = 0f;
            float clientHeight = 0f;
            bool flag4 = true;
            if (base.Owner != null)
            {
                for (IDocumentObject obj2 = base.Owner; !(obj2 is Section); obj2 = obj2.Owner)
                {
                    if (((obj2 is Table) && this.Format.IsAllowInCell) && !(obj2 as Table).IsSDTTable)
                    {
                        this.table_0.IsTextBoxInTable = true;
                        break;
                    }
                    if (obj2.Owner == null)
                    {
                        break;
                    }
                }
                if (A_0.imethod_0().method_28().method_30() != null)
                {
                    Section section = A_0.imethod_0().method_28().method_30() as Section;
                    left = section.PageSetup.Margins.Left;
                    top = section.PageSetup.Margins.Top;
                    bottom = section.PageSetup.Margins.Bottom;
                    right = section.PageSetup.Margins.Right;
                    float footerDistance = section.PageSetup.FooterDistance;
                    float headerDistance = section.PageSetup.HeaderDistance;
                    height = section.PageSetup.PageSize.Height;
                    width = section.PageSetup.PageSize.Width;
                    num2 = (A_0.imethod_0().method_135() || (section.Columns.Count <= 0)) ? section.PageSetup.ClientWidth : section.Columns[A_0.imethod_3().Interface30.imethod_4()].Width;
                    clientHeight = section.PageSetup.ClientHeight;
                    if (section.Columns.Count > 1)
                    {
                        flag4 = false;
                    }
                }
            }
            if (this.Format.WidthPercent > 0f)
            {
                float num9 = 0f;
                switch (this.Format.RelationWidth)
                {
                    case HorizontalOrigin.Margin:
                        num9 = (num2 * this.Format.WidthPercent) / 100f;
                        break;

                    case HorizontalOrigin.Page:
                        num9 = (width * this.Format.WidthPercent) / 100f;
                        break;
                }
                if (((num9 != 0f) && (this.Format.Width != num9)) && (((this.Format.LayoutFlowAlt == TextDirection.TopToBottom) || (this.Format.LayoutFlowAlt == TextDirection.TopToBottomRotated)) || !base.ShapePr.HasKey(0x1023)))
                {
                    this.Format.Width = num9;
                }
            }
            if (this.Format.HeightPercent > 0f)
            {
                float num5 = 0f;
                switch (this.Format.RelationHeight)
                {
                    case VerticalOrigin.Margin:
                        num5 = (clientHeight * this.Format.HeightPercent) / 100f;
                        break;

                    case VerticalOrigin.Page:
                        num5 = (height * this.Format.HeightPercent) / 100f;
                        break;
                }
                if ((num5 != 0f) && (this.Format.Width != num5))
                {
                    this.Format.Height = num5;
                }
            }
            Color fillColor = new Color();
            if (this.Format.Opacity > 0f)
            {
                fillColor = this.Format.FillColor;
            }
            row.Height = this.Format.Height;
            cell.CellFormat.TextDirection = this.Format.LayoutFlowAlt;
            if (!this.Format.NoLine && (base.ShapeType == ShapeType.TextBox))
            {
                cell.CellFormat.Borders.LineWidth = this.Format.LineWidth;
                cell.CellFormat.Borders.Color = this.Format.LineColor;
                cell.CellFormat.Borders.BorderType = this.method_81(this.Format.LineStyle);
            }
            else
            {
                cell.CellFormat.Borders.BorderType = BorderStyle.None;
            }
            if (this.Format.TextWrappingStyle == TextWrappingStyle.Inline)
            {
                goto Label_1240;
            }
            switch (this.Format.VerticalOrigin)
            {
                case VerticalOrigin.Margin:
                    this.table_0.TableFormat.Positioning.VertRelationTo = VerticalRelation.Margin;
                    switch (this.Format.VerticalAlignment)
                    {
                        case ShapeVerticalAlignment.None:
                            if (Math.Abs(this.Format.TopPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = clientHeight * (this.Format.TopPercent / 100f);
                            }
                            else if (this.Format.VerticalPosition != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = this.Format.VerticalPosition;
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.VertPositionAbs = VerticalPosition.None;
                            }
                            goto Label_0995;

                        case ShapeVerticalAlignment.Top:
                            if (Math.Abs(this.Format.TopPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = top * (this.Format.TopPercent / 100f);
                            }
                            else if (this.Format.VerticalPosition != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = this.Format.VerticalPosition;
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.VertPositionAbs = VerticalPosition.Top;
                            }
                            goto Label_0995;

                        case ShapeVerticalAlignment.Center:
                            if (Math.Abs(this.Format.TopPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = (clientHeight / 2f) * (this.Format.TopPercent / 100f);
                            }
                            else if (this.Format.VerticalPosition != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = (clientHeight - this.Format.Height) / 2f;
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.VertPositionAbs = VerticalPosition.Center;
                            }
                            goto Label_0995;

                        case ShapeVerticalAlignment.Bottom:
                            if (Math.Abs(this.Format.TopPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = ((clientHeight - this.Format.InternalMargin.Bottom) - bottom) * (this.Format.TopPercent / 100f);
                            }
                            else if (this.Format.VerticalPosition != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = clientHeight - this.Format.Height;
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.VertPositionAbs = VerticalPosition.Bottom;
                            }
                            goto Label_0995;
                    }
                    break;

                case VerticalOrigin.Page:
                    this.table_0.TableFormat.Positioning.VertRelationTo = VerticalRelation.Page;
                    switch (this.Format.VerticalAlignment)
                    {
                        case ShapeVerticalAlignment.None:
                            if (Math.Abs(this.Format.TopPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = height * (this.Format.TopPercent / 100f);
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.VertPositionEx = this.Format.VerticalPosition;
                            }
                            goto Label_0995;

                        case ShapeVerticalAlignment.Top:
                        {
                            RowFormat.TablePositioning positioning = this.table_0.TableFormat.Positioning;
                            positioning.VertPositionEx -= this.Format.InternalMargin.Top;
                            goto Label_0995;
                        }
                        case ShapeVerticalAlignment.Center:
                            this.table_0.TableFormat.Positioning.VertPositionEx = (height - this.Format.Height) / 2f;
                            goto Label_0995;

                        case ShapeVerticalAlignment.Bottom:
                            this.table_0.TableFormat.Positioning.VertPositionEx = (height - this.Format.Height) - this.Format.InternalMargin.Bottom;
                            goto Label_0995;
                    }
                    break;

                case VerticalOrigin.Paragraph:
                case VerticalOrigin.Line:
                    this.table_0.TableFormat.Positioning.VertRelationTo = VerticalRelation.Paragraph;
                    this.table_0.TableFormat.Positioning.VertPositionEx = this.Format.VerticalPosition;
                    break;

                case VerticalOrigin.TopMarginArea:
                    this.table_0.TableFormat.Positioning.VertRelationTo = VerticalRelation.Page;
                    if (this.Format.VerticalAlignment == ShapeVerticalAlignment.None)
                    {
                        if (Math.Abs(this.Format.TopPercent) == 0f)
                        {
                            this.table_0.TableFormat.Positioning.VertPositionEx = this.Format.VerticalPosition;
                            break;
                        }
                        this.table_0.TableFormat.Positioning.VertPositionEx = height * (this.Format.TopPercent / 100f);
                    }
                    break;

                default:
                    if (this.table_0.TableFormat.Positioning.VertPositionEx == 0f)
                    {
                        this.table_0.TableFormat.Positioning.VertPositionEx = this.Format.VerticalPosition;
                    }
                    break;
            }
        Label_0995:
            switch (this.Format.HorizontalOrigin)
            {
                case HorizontalOrigin.Margin:
                    this.table_0.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Margin;
                    this.table_0.TableFormat.Positioning.HorizPositionAbs = HorizontalPosition.Left;
                    switch (this.Format.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.None:
                            if (Math.Abs(this.Format.LeftPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = num2 * (this.Format.LeftPercent / 100f);
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = this.Format.HorizontalPosition;
                            }
                            break;

                        case ShapeHorizontalAlignment.Left:
                            if (Math.Abs(this.Format.LeftPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = (left - this.Format.InternalMargin.Left) * (this.Format.LeftPercent / 100f);
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = this.table_0.TableFormat.LeftIndent - this.Format.InternalMargin.Left;
                            }
                            break;

                        case ShapeHorizontalAlignment.Center:
                            if (Math.Abs(this.Format.LeftPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = (num2 / 2f) * (this.Format.LeftPercent / 100f);
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = (num2 - this.Format.Width) / 2f;
                            }
                            break;

                        case ShapeHorizontalAlignment.Right:
                            if (Math.Abs(this.Format.LeftPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = (num2 - this.Format.InternalMargin.Right) * (this.Format.LeftPercent / 100f);
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = (num2 - this.Format.Width) - this.Format.InternalMargin.Right;
                            }
                            break;
                    }
                    goto Label_11AF;

                case HorizontalOrigin.Page:
                    this.table_0.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Page;
                    switch (this.Format.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.None:
                            if (Math.Abs(this.Format.LeftPercent) != 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = width * (this.Format.LeftPercent / 100f);
                            }
                            else
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = this.Format.HorizontalPosition;
                            }
                            break;

                        case ShapeHorizontalAlignment.Left:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = 0f;
                            break;

                        case ShapeHorizontalAlignment.Center:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = (width - this.Format.Width) / 2f;
                            break;

                        case ShapeHorizontalAlignment.Right:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = width - this.Format.Width;
                            break;
                    }
                    goto Label_11AF;

                case HorizontalOrigin.Column:
                    this.table_0.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Column;
                    switch (this.Format.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.None:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = this.Format.HorizontalPosition;
                            break;

                        case ShapeHorizontalAlignment.Left:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = this.table_0.TableFormat.LeftIndent - this.Format.InternalMargin.Left;
                            break;

                        case ShapeHorizontalAlignment.Center:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = (num2 - this.Format.Width) / 2f;
                            break;

                        case ShapeHorizontalAlignment.Right:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = (num2 - this.Format.Width) - this.Format.InternalMargin.Right;
                            break;
                    }
                    goto Label_11AF;

                case HorizontalOrigin.LeftMarginArea:
                    this.table_0.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Margin;
                    switch (this.Format.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.None:
                            this.table_0.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Page;
                            if (Math.Abs(this.Format.LeftPercent) == 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = this.Format.HorizontalPosition;
                                break;
                            }
                            this.table_0.TableFormat.Positioning.HorizPositionEx = width * (this.Format.LeftPercent / 100f);
                            break;

                        case ShapeHorizontalAlignment.Left:
                            if (Math.Abs(this.Format.LeftPercent) == 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = -(left - this.Format.InternalMargin.Left);
                                break;
                            }
                            this.table_0.TableFormat.Positioning.HorizPositionEx = -(left - this.Format.InternalMargin.Left) * (this.Format.LeftPercent / 100f);
                            break;

                        case ShapeHorizontalAlignment.Center:
                            if (Math.Abs(this.Format.LeftPercent) == 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = -(left - this.Format.Width) / 2f;
                                break;
                            }
                            this.table_0.TableFormat.Positioning.HorizPositionEx = -(left / 2f) * (this.Format.LeftPercent / 100f);
                            break;

                        case ShapeHorizontalAlignment.Right:
                            if (Math.Abs(this.Format.LeftPercent) == 0f)
                            {
                                this.table_0.TableFormat.Positioning.HorizPositionEx = -(this.Format.Width + this.Format.InternalMargin.Right);
                                break;
                            }
                            this.table_0.TableFormat.Positioning.HorizPositionEx = -(left - this.Format.InternalMargin.Right) * (this.Format.LeftPercent / 100f);
                            break;
                    }
                    goto Label_11AF;

                case HorizontalOrigin.RightMarginArea:
                    this.table_0.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Margin;
                    this.table_0.TableFormat.Positioning.HorizPositionAbs = HorizontalPosition.Left;
                    switch (this.Format.HorizontalAlignment)
                    {
                        case ShapeHorizontalAlignment.None:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = num2 + this.Format.HorizontalPosition;
                            break;

                        case ShapeHorizontalAlignment.Left:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = num2;
                            break;

                        case ShapeHorizontalAlignment.Center:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = num2 + ((right - this.Format.Width) / 2f);
                            break;

                        case ShapeHorizontalAlignment.Right:
                            this.table_0.TableFormat.Positioning.HorizPositionEx = (num2 + right) - this.Format.Width;
                            break;
                    }
                    goto Label_11AF;
            }
            if (this.table_0.TableFormat.Positioning.VertPositionEx == 0f)
            {
                this.table_0.TableFormat.Positioning.VertPositionEx = this.Format.VerticalPosition;
            }
        Label_11AF:
            this.table_0.TableFormat.method_53(true);
            this.table_0.TableFormat.Positioning.DistanceFromBottom = this.Format.WrapDistanceBottom;
            this.table_0.TableFormat.Positioning.DistanceFromLeft = this.Format.WrapDistanceLeft;
            this.table_0.TableFormat.Positioning.DistanceFromRight = this.Format.WrapDistanceRight;
            this.table_0.TableFormat.Positioning.DistanceFromTop = this.Format.WrapDistanceTop;
        Label_1240:
            if ((this.Format.IsInGroupShape || this.Format.IsInShape) && (this.ShapeInfo != null))
            {
                this.table_0.TableFormat.method_53(true);
            }
            if (((this.Format.HorizontalOrigin == HorizontalOrigin.Column) && flag4) && !this.table_0.IsTextBoxInTable)
            {
                RowFormat.TablePositioning positioning2 = this.table_0.TableFormat.Positioning;
                positioning2.HorizPositionEx += left;
                this.table_0.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Page;
            }
            if (!this.Format.IsInShape)
            {
                cell.CellFormat.BackColor = fillColor;
            }
            if (base.ShapeType == ShapeType.TextBox)
            {
                if (this.Format.FillEfects.Type == BackgroundType.NoBackground)
                {
                    if (this.Format.TextWrappingStyle == TextWrappingStyle.InFrontOfText)
                    {
                        fillColor = this.Format.FillColor;
                    }
                    else
                    {
                        fillColor = Color.Transparent;
                    }
                }
                else if (this.Format.FillEfects.Type == BackgroundType.Gradient)
                {
                    fillColor = this.Format.FillEfects.Gradient.Color2;
                    cell.CellFormat.TextureStyle = TextureStyle.Texture30Percent;
                }
                if (!this.Format.IsInShape)
                {
                    this.table_0.TableFormat.BackColor = fillColor;
                    cell.CellFormat.BackColor = fillColor;
                }
            }
            this.table_0.TableFormat.LayoutType = LayoutType.Fixed;
            this.table_0.TableFormat.Paddings.Left = this.Format.InternalMargin.Left;
            this.table_0.TableFormat.Paddings.Right = this.Format.InternalMargin.Right;
            this.table_0.TableFormat.Paddings.Top = this.Format.InternalMargin.Top;
            this.table_0.TableFormat.Paddings.Bottom = this.Format.InternalMargin.Bottom;
            if (!this.Format.IsFitShapeToText || (this.Format.TextBoxWrapMode != TextBoxWrapMode.None))
            {
                cell.Width = this.Format.Width;
                goto Label_150E;
            }
            cell.CellWidthType = CellWidthType.Auto;
            bool flag3 = true;
            using (IEnumerator enumerator = this.ChildObjects.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if ((current is Paragraph) && (current as Paragraph).Text.Contains(BookmarkStart.b("␬", num)))
                    {
                        goto Label_14AE;
                    }
                }
                goto Label_14C8;
            Label_14AE:
                flag3 = false;
            }
        Label_14C8:
            if (flag3)
            {
                cell.Width = 0f;
                this.table_0.TableFormat.LayoutType = LayoutType.AutoFit;
                this.table_0.PreferredTableWidth.method_52(FtsWidth.Auto);
            }
        Label_150E:
            cell.CellFormat.VerticalAlignment = this.method_80(this.Format.TextAnchor);
            if (this.Format.IsFitShapeToText)
            {
                this.table_0.Rows[0].HeightType = TableRowHeightType.AtLeast;
            }
            else
            {
                this.table_0.Rows[0].HeightType = TableRowHeightType.Exactly;
            }
            if (!flag || flag2)
            {
                int num4 = 0;
                int count = this.Body.Items.Count;
                while (num4 < count)
                {
                    BodyRegion region = this.Body.Items[num4];
                    if ((region.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Paragraph) && (region as Paragraph).HasSDTInlineItem)
                    {
                        Paragraph entity = region.Clone() as Paragraph;
                        entity.Items.Clear();
                        int num10 = 0;
                        int num11 = (region as Paragraph).Items.Count;
                        while (num10 < num11)
                        {
                            DocumentObject obj3 = (region as Paragraph).Items[num10];
                            if (obj3 is StructureDocumentTagInline)
                            {
                                foreach (DocumentObject obj4 in (obj3 as StructureDocumentTagInline).SDTContent.Items)
                                {
                                    entity.Items.Add(obj4.Clone());
                                }
                                entity.bool_6 = false;
                            }
                            else
                            {
                                entity.Items.Add(obj3.Clone());
                            }
                            num10++;
                        }
                        cell.Items.Add(entity);
                    }
                    else
                    {
                        cell.Items.Add(region.Clone());
                    }
                    num4++;
                }
            }
            if (this.Format.IsInShape && (this.ShapeInfo != null))
            {
                this.Format.StartPoint = this.ShapeInfo.StartPoint;
            }
            return this.table_0;
        }

        private RowAlignment method_79(ShapeHorizontalAlignment A_0)
        {
            switch (A_0)
            {
                case ShapeHorizontalAlignment.Center:
                    return RowAlignment.Center;

                case ShapeHorizontalAlignment.Right:
                    return RowAlignment.Right;
            }
            return RowAlignment.Left;
        }

        private VerticalAlignment method_80(ShapeVerticalAlignment A_0)
        {
            switch (A_0)
            {
                case ShapeVerticalAlignment.Center:
                    return VerticalAlignment.Middle;

                case ShapeVerticalAlignment.Bottom:
                    return VerticalAlignment.Bottom;
            }
            return VerticalAlignment.Top;
        }

        private BorderStyle method_81(TextBoxLineStyle A_0)
        {
            switch (A_0)
            {
                case TextBoxLineStyle.Simple:
                    return BorderStyle.Single;

                case TextBoxLineStyle.Double:
                    return BorderStyle.Double;

                case TextBoxLineStyle.ThickThin:
                    return BorderStyle.ThickThinMediumGap;

                case TextBoxLineStyle.ThinThick:
                    return BorderStyle.ThinThickMediumGap;

                case TextBoxLineStyle.Triple:
                    return BorderStyle.Triple;
            }
            return BorderStyle.None;
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("堫圭䀯圱", 6), ParagraphItemType.TextBox);
        }

        public Spire.Doc.Body Body
        {
            get
            {
                return this.m_textBody;
            }
        }

        public override Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return base.m_charFormat;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.m_textBody.ChildObjects;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.TextBox;
            }
        }

        public TextBoxFormat Format
        {
            get
            {
                if (this.m_txbxFormat == null)
                {
                    this.m_txbxFormat = new TextBoxFormat(this);
                }
                return this.m_txbxFormat;
            }
        }

        Interface23 Interface1.LayoutInfo
        {
            get
            {
                if (base.interface23_0 == null)
                {
                    this.CreateLayoutInfo();
                }
                return base.interface23_0;
            }
        }

        internal ShapeObject ShapeInfo
        {
            [CompilerGenerated]
            get
            {
                return this.shapeObject_0;
            }
            [CompilerGenerated]
            set
            {
                this.shapeObject_0 = value;
            }
        }

        internal int Spid
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
    }
}

