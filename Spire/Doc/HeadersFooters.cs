namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using System;
    using System.Collections;
    using System.Reflection;

    public class HeadersFooters : DocumentSerializable, IEnumerable
    {
        private bool bool_0;
        private bool bool_1;
        private Class53 class53_0;
        private HeaderFooter headerFooter_0;
        private HeaderFooter headerFooter_1;
        private HeaderFooter headerFooter_2;
        private HeaderFooter headerFooter_3;
        private HeaderFooter headerFooter_4;
        private HeaderFooter headerFooter_5;

        internal HeadersFooters(Section A_0) : base(A_0.Document, A_0)
        {
            this.headerFooter_0 = new HeaderFooter(A_0, HeaderFooterType.HeaderEven);
            this.headerFooter_2 = new HeaderFooter(A_0, HeaderFooterType.HeaderOdd);
            this.headerFooter_3 = new HeaderFooter(A_0, HeaderFooterType.FooterEven);
            this.headerFooter_1 = new HeaderFooter(A_0, HeaderFooterType.FooterOdd);
            this.headerFooter_5 = new HeaderFooter(A_0, HeaderFooterType.FooterFirstPage);
            this.headerFooter_4 = new HeaderFooter(A_0, HeaderFooterType.HeaderFirstPage);
        }

        protected override object CloneImpl()
        {
            HeadersFooters footers = (HeadersFooters) base.CloneImpl();
            footers.headerFooter_0 = (HeaderFooter) this.headerFooter_0.Clone();
            footers.headerFooter_2 = (HeaderFooter) this.headerFooter_2.Clone();
            footers.headerFooter_3 = (HeaderFooter) this.headerFooter_3.Clone();
            footers.headerFooter_1 = (HeaderFooter) this.headerFooter_1.Clone();
            footers.headerFooter_5 = (HeaderFooter) this.headerFooter_5.Clone();
            footers.headerFooter_4 = (HeaderFooter) this.headerFooter_4.Clone();
            footers.bool_0 = this.LinkToPrevious;
            return footers;
        }

        public IEnumerator GetEnumerator()
        {
            return new Class53(this);
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("吰䔲倴夶ᐸ区堼帾╀♂㝄", 11), this.EvenHeader);
            base.XDLSHolder.AddElement(BookmarkStart.b("帰圲儴ᨶ儸帺尼嬾⑀ㅂ", 11), this.OddHeader);
            base.XDLSHolder.AddElement(BookmarkStart.b("吰䔲倴夶ᐸ崺刼倾㕀♂㝄", 11), this.EvenFooter);
            base.XDLSHolder.AddElement(BookmarkStart.b("帰圲儴ᨶ弸吺刼䬾⑀ㅂ", 11), this.OddFooter);
            base.XDLSHolder.AddElement(BookmarkStart.b("地娲䜴䐶䴸ᘺ䴼帾♀♂桄⽆ⱈ⩊⥌⩎⍐", 11), this.FirstPageHeader);
            base.XDLSHolder.AddElement(BookmarkStart.b("地娲䜴䐶䴸ᘺ䴼帾♀♂桄ⅆ♈⑊㥌⩎⍐", 11), this.FirstPageFooter);
        }

        internal void method_10()
        {
            Section ownerBase = base.OwnerBase as Section;
            if (ownerBase != null)
            {
                this.bool_1 = true;
                if (ownerBase.method_5() > 0)
                {
                    this.bool_0 = false;
                    this.headerFooter_2 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderOdd);
                    this.headerFooter_1 = new HeaderFooter(ownerBase, HeaderFooterType.FooterOdd);
                    this.headerFooter_0 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderEven);
                    this.headerFooter_3 = new HeaderFooter(ownerBase, HeaderFooterType.FooterEven);
                    this.headerFooter_4 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderFirstPage);
                    this.headerFooter_5 = new HeaderFooter(ownerBase, HeaderFooterType.FooterFirstPage);
                }
            }
        }

        private bool method_11(HeadersFooters A_0)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!this.method_12(A_0[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool method_12(HeaderFooter A_0)
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

        internal HeadersFooters method_5()
        {
            return (HeadersFooters) this.CloneImpl();
        }

        private HeadersFooters method_6()
        {
            Section previousSibling = (base.OwnerBase as Section).PreviousSibling as Section;
            while (previousSibling != null)
            {
                HeadersFooters headersFooters = previousSibling.HeadersFooters;
                if (!headersFooters.LinkToPrevious)
                {
                    return headersFooters;
                }
                previousSibling = previousSibling.PreviousSibling as Section;
                if (previousSibling == null)
                {
                    return headersFooters;
                }
            }
            if (previousSibling == null)
            {
                return (base.OwnerBase as Section).HeadersFooters;
            }
            return previousSibling.HeadersFooters;
        }

        internal void method_7()
        {
            HeaderFooter footer = null;
            for (int i = 0; i < 6; i++)
            {
                footer = this[i];
                footer.method_28();
                footer = null;
            }
        }

        private bool method_8()
        {
            Section ownerBase = base.OwnerBase as Section;
            if (ownerBase == null)
            {
                return false;
            }
            this.bool_1 = true;
            int num = ownerBase.method_5();
            if (num == 0)
            {
                this.bool_0 = false;
            }
            else if (num > 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (this[i].Items.Count > 0)
                    {
                        this.bool_0 = false;
                        break;
                    }
                    this.bool_0 = true;
                }
            }
            return this.bool_0;
        }

        internal void method_9(bool A_0)
        {
            Section ownerBase = base.OwnerBase as Section;
            if (ownerBase != null)
            {
                this.bool_1 = true;
                int num = ownerBase.method_5();
                if (num == -1)
                {
                    this.bool_0 = A_0;
                    if (!A_0)
                    {
                        if ((this.headerFooter_2 != null) && (this.headerFooter_2.ChildObjects.Count <= 0))
                        {
                            this.headerFooter_2 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderOdd);
                            this.headerFooter_2.AddParagraph().AppendText(string.Empty);
                        }
                        if ((this.headerFooter_1 != null) && (this.headerFooter_1.ChildObjects.Count <= 0))
                        {
                            this.headerFooter_1 = new HeaderFooter(ownerBase, HeaderFooterType.FooterOdd);
                            this.headerFooter_1.AddParagraph().AppendText(string.Empty);
                        }
                        if ((this.headerFooter_0 != null) && (this.headerFooter_0.ChildObjects.Count <= 0))
                        {
                            this.headerFooter_0 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderEven);
                            this.headerFooter_0.AddParagraph().AppendText(string.Empty);
                        }
                        if ((this.headerFooter_3 != null) && (this.headerFooter_3.ChildObjects.Count <= 0))
                        {
                            this.headerFooter_3 = new HeaderFooter(ownerBase, HeaderFooterType.FooterEven);
                            this.headerFooter_3.AddParagraph().AppendText(string.Empty);
                        }
                        if ((this.headerFooter_4 != null) && (this.headerFooter_4.ChildObjects.Count <= 0))
                        {
                            this.headerFooter_4 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderFirstPage);
                            this.headerFooter_4.AddParagraph().AppendText(string.Empty);
                        }
                        if ((this.headerFooter_5 != null) && (this.headerFooter_5.ChildObjects.Count <= 0))
                        {
                            this.headerFooter_5 = new HeaderFooter(ownerBase, HeaderFooterType.FooterFirstPage);
                            this.headerFooter_5.AddParagraph().AppendText(string.Empty);
                        }
                    }
                }
                else
                {
                    this.bool_0 = (num != 0) && A_0;
                    if (num != 0)
                    {
                        HeadersFooters footers = this.method_6();
                        if (A_0)
                        {
                            if (this.method_11(footers))
                            {
                                this.headerFooter_2 = footers.OddHeader;
                                this.headerFooter_1 = footers.OddFooter;
                                this.headerFooter_0 = footers.EvenHeader;
                                this.headerFooter_3 = footers.EvenFooter;
                                this.headerFooter_4 = footers.FirstPageHeader;
                                this.headerFooter_5 = footers.FirstPageFooter;
                            }
                        }
                        else
                        {
                            if ((this.headerFooter_2 == footers.OddHeader) || ((this.headerFooter_2 != null) && (this.headerFooter_2.ChildObjects.Count <= 0)))
                            {
                                this.headerFooter_2 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderOdd);
                                this.headerFooter_2.AddParagraph().AppendText(string.Empty);
                            }
                            if ((this.headerFooter_1 == footers.OddFooter) || ((this.headerFooter_1 != null) && (this.headerFooter_1.ChildObjects.Count <= 0)))
                            {
                                this.headerFooter_1 = new HeaderFooter(ownerBase, HeaderFooterType.FooterOdd);
                                this.headerFooter_1.AddParagraph().AppendText(string.Empty);
                            }
                            if ((this.headerFooter_0 == footers.EvenHeader) || ((this.headerFooter_0 != null) && (this.headerFooter_0.ChildObjects.Count <= 0)))
                            {
                                this.headerFooter_0 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderEven);
                                this.headerFooter_0.AddParagraph().AppendText(string.Empty);
                            }
                            if ((this.headerFooter_3 == footers.EvenFooter) || ((this.headerFooter_3 != null) && (this.headerFooter_3.ChildObjects.Count <= 0)))
                            {
                                this.headerFooter_3 = new HeaderFooter(ownerBase, HeaderFooterType.FooterEven);
                                this.headerFooter_3.AddParagraph().AppendText(string.Empty);
                            }
                            if ((this.headerFooter_4 == footers.FirstPageHeader) || ((this.headerFooter_4 != null) && (this.headerFooter_4.ChildObjects.Count <= 0)))
                            {
                                this.headerFooter_4 = new HeaderFooter(ownerBase, HeaderFooterType.HeaderFirstPage);
                                this.headerFooter_4.AddParagraph().AppendText(string.Empty);
                            }
                            if ((this.headerFooter_5 == footers.FirstPageFooter) || ((this.headerFooter_5 != null) && (this.headerFooter_5.ChildObjects.Count <= 0)))
                            {
                                this.headerFooter_5 = new HeaderFooter(ownerBase, HeaderFooterType.FooterFirstPage);
                                this.headerFooter_5.AddParagraph().AppendText(string.Empty);
                            }
                        }
                    }
                }
            }
        }

        public HeaderFooter EvenFooter
        {
            get
            {
                return this.headerFooter_3;
            }
        }

        public HeaderFooter EvenHeader
        {
            get
            {
                return this.headerFooter_0;
            }
        }

        public HeaderFooter FirstPageFooter
        {
            get
            {
                return this.headerFooter_5;
            }
        }

        public HeaderFooter FirstPageHeader
        {
            get
            {
                return this.headerFooter_4;
            }
        }

        public HeaderFooter Footer
        {
            get
            {
                return this.OddFooter;
            }
        }

        public HeaderFooter Header
        {
            get
            {
                return this.OddHeader;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (((((this.headerFooter_0.ChildObjects.Count == 0) && (this.headerFooter_3.ChildObjects.Count == 0)) && ((this.headerFooter_1.ChildObjects.Count == 0) && (this.headerFooter_2.ChildObjects.Count == 0))) && (this.headerFooter_5.ChildObjects.Count == 0)) && (this.headerFooter_4.ChildObjects.Count == 0));
            }
        }

        public HeaderFooter this[int index]
        {
            get
            {
                int num = 0;
                if ((index < 0) || (index > 5))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("漥䘧丩䤫嘭", num), BookmarkStart.b("漥䘧丩䤫嘭ု儱唳堵嘷唹䠻ḽ∿❁摃⩅ⵇ㥉㽋湍恏牑㭓⑕硗㵙⹛㭝şᙡţᑥ䡧彩", num));
                }
                return this[(HeaderFooterType) index];
            }
        }

        public HeaderFooter this[HeaderFooterType A_0]
        {
            get
            {
                int num = 1;
                switch (hfType)
                {
                    case HeaderFooterType.HeaderEven:
                        return this.EvenHeader;

                    case HeaderFooterType.HeaderOdd:
                        return this.OddHeader;

                    case HeaderFooterType.FooterEven:
                        return this.EvenFooter;

                    case HeaderFooterType.FooterOdd:
                        return this.OddFooter;

                    case HeaderFooterType.HeaderFirstPage:
                        return this.FirstPageHeader;

                    case HeaderFooterType.FooterFirstPage:
                        return this.FirstPageFooter;
                }
                throw new ArgumentException(BookmarkStart.b("渦䜨崪䰬䌮堰圲ᔴ弶尸娺夼娾㍀求⍄⡆♈㽊⡌㵎煐❒ⱔ❖㱘", num), BookmarkStart.b("伦伨缪听弮吰", num));
            }
            internal set
            {
                int num = 8;
                switch (A_0)
                {
                    case HeaderFooterType.HeaderEven:
                        this.headerFooter_0 = value;
                        return;

                    case HeaderFooterType.HeaderOdd:
                        this.headerFooter_2 = value;
                        return;

                    case HeaderFooterType.FooterEven:
                        this.headerFooter_3 = value;
                        return;

                    case HeaderFooterType.FooterOdd:
                        this.headerFooter_1 = value;
                        return;

                    case HeaderFooterType.HeaderFirstPage:
                        this.headerFooter_4 = value;
                        return;

                    case HeaderFooterType.FooterFirstPage:
                        this.headerFooter_5 = value;
                        return;
                }
                throw new ArgumentException(BookmarkStart.b("札帯䐱唳娵儷帹᰻嘽┿⍁⁃⍅㩇敉⩋⅍㽏♑ㅓ⑕硗⹙╛⹝՟", num), BookmarkStart.b("䘭嘯昱䴳䘵崷", num));
            }
        }

        public bool LinkToPrevious
        {
            get
            {
                if (!this.bool_1)
                {
                    return this.method_8();
                }
                return this.bool_0;
            }
            set
            {
                this.method_9(value);
            }
        }

        public HeaderFooter OddFooter
        {
            get
            {
                return this.headerFooter_1;
            }
        }

        public HeaderFooter OddHeader
        {
            get
            {
                return this.headerFooter_2;
            }
        }

        internal class Class53 : IEnumerator
        {
            private HeadersFooters headersFooters_0;
            private int int_0 = -1;

            internal Class53(HeadersFooters A_0)
            {
                this.headersFooters_0 = A_0;
            }

            bool IEnumerator.MoveNext()
            {
                if (this.int_0 < 5)
                {
                    this.int_0++;
                    return true;
                }
                return false;
            }

            void IEnumerator.Reset()
            {
                this.int_0 = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    if (this.int_0 >= 0)
                    {
                        return this.headersFooters_0[this.int_0];
                    }
                    return null;
                }
            }
        }
    }
}

