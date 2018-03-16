namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using System;

    public class HeaderFooter : Body
    {
        private bool[] bool_4;
        private bool bool_5;
        private bool bool_6;
        private float[] float_3;
        private float float_4;
        private HeaderFooterType headerFooterType_0;
        private long[] long_3;
        private string string_8;
        private WatermarkBase watermarkBase_0;

        internal HeaderFooter(Section A_0, HeaderFooterType A_1) : base(A_0)
        {
            this.headerFooterType_0 = A_1;
            this.bool_6 = true;
        }

        internal bool method_45()
        {
            return this.bool_5;
        }

        private bool method_46()
        {
            Section ownerBase = base.OwnerBase as Section;
            if (ownerBase == null)
            {
                return false;
            }
            int num = ownerBase.method_5();
            if (num == 0)
            {
                this.bool_6 = false;
            }
            else if (num > 0)
            {
                if (base.Items.Count > 0)
                {
                    this.bool_6 = false;
                }
                else
                {
                    this.bool_6 = true;
                }
            }
            return this.bool_6;
        }

        private void method_47(bool A_0)
        {
            if (A_0)
            {
                this.ChildObjects.Clear();
                (base.OwnerBase as Section).HeadersFooters[this.headerFooterType_0] = new HeaderFooter(base.OwnerBase as Section, this.headerFooterType_0);
            }
            else
            {
                Section section = this.method_48();
                if (section != null)
                {
                    foreach (HeaderFooter footer in section.HeadersFooters)
                    {
                        if ((this.headerFooterType_0 == footer.headerFooterType_0) && this.method_49(footer))
                        {
                            footer.m_bodyItems.method_12(base.m_bodyItems);
                        }
                    }
                }
            }
            this.bool_6 = A_0;
        }

        private Section method_48()
        {
            Section previousSibling = (base.OwnerBase as Section).PreviousSibling as Section;
            while (previousSibling != null)
            {
                if (!previousSibling.HeadersFooters.LinkToPrevious)
                {
                    return previousSibling;
                }
            }
            return previousSibling;
        }

        private bool method_49(HeaderFooter A_0)
        {
            foreach (Paragraph paragraph in A_0.Paragraphs)
            {
                foreach (ParagraphBase base2 in paragraph.Items)
                {
                    if (!(base2 is DocPicture) && !(base2 is TextBox))
                    {
                        if (base2 is ShapeObject)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        base2.bool_4 = true;
                    }
                }
            }
            return true;
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.HeaderFooter;
            }
        }

        internal bool HasWatermark
        {
            get
            {
                return (this.Watermark.Type != WatermarkType.NoWatermark);
            }
        }

        internal bool IsHeader
        {
            get
            {
                if ((this.Type != HeaderFooterType.HeaderEven) && (this.Type != HeaderFooterType.HeaderFirstPage))
                {
                    return (this.Type == HeaderFooterType.HeaderOdd);
                }
                return true;
            }
        }

        public bool LinkToPrevious
        {
            get
            {
                return this.method_46();
            }
            set
            {
                this.method_47(value);
            }
        }

        internal HeaderFooterType Type
        {
            get
            {
                return this.headerFooterType_0;
            }
            set
            {
                this.headerFooterType_0 = value;
            }
        }

        internal WatermarkBase Watermark
        {
            get
            {
                if (((this.Type != HeaderFooterType.HeaderEven) && (this.Type != HeaderFooterType.HeaderOdd)) && (this.Type != HeaderFooterType.HeaderFirstPage))
                {
                    return null;
                }
                if (this.watermarkBase_0 == null)
                {
                    return base.Document.watermarkBase_0;
                }
                return this.watermarkBase_0;
            }
            set
            {
                this.watermarkBase_0 = value;
            }
        }

        internal bool WriteWatermark
        {
            get
            {
                Section ownerBase = base.OwnerBase as Section;
                return (this.bool_5 || (((ownerBase != null) && !ownerBase.HeadersFooters.EvenHeader.method_45()) && (!ownerBase.HeadersFooters.OddHeader.method_45() && !ownerBase.HeadersFooters.FirstPageHeader.method_45())));
            }
            set
            {
                this.bool_5 = value;
            }
        }
    }
}

