namespace Spire.Doc
{
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;

    public class FootEndnoteOptions : WordAttrCollection
    {
        private bool bool_2;
        private FootEndnoteApplyType footEndnoteApplyType_0;
        private FootnoteType footnoteType_0;
        internal const int int_10 = 3;
        internal const int int_11 = 4;
        private int[] int_12;
        internal const int int_8 = 1;
        internal const int int_9 = 2;
        private string string_3;
        private string string_4;
        private string string_5;

        internal FootEndnoteOptions(IDocument A_0, bool A_1) : base(A_0)
        {
            this.bool_2 = true;
            this.footEndnoteApplyType_0 = FootEndnoteApplyType.Document;
            this.method_49(A_1);
        }

        internal FootEndnoteOptions(FormatBase A_0, int A_1, bool A_2) : base(A_0, A_1)
        {
            this.bool_2 = true;
            this.footEndnoteApplyType_0 = FootEndnoteApplyType.Section;
            this.method_49(A_2);
        }

        protected override object GetDefValue(int key)
        {
            int num = 5;
            switch (key)
            {
                case 1:
                    if (!this.IsFootnote)
                    {
                        return FootnoteNumberFormat.LowerCaseRoman;
                    }
                    return FootnoteNumberFormat.Arabic;

                case 2:
                    if (!this.IsFootnote)
                    {
                        return FootnotePosition.PrintAsEndOfDocument;
                    }
                    return FootnotePosition.PrintAtBottomOfPage;

                case 3:
                    return FootnoteRestartRule.DoNotRestart;

                case 4:
                    return 1;
            }
            throw new ArgumentException(BookmarkStart.b("䀪䠬嘮ᄰ嬲吴䐶ᤸ刺匼䤾⁀⽂ⱄ⍆楈㵊ⱌ⍎⑐㙒", num));
        }

        internal override bool HasValue(int propertyKey)
        {
            return base.HasKey(propertyKey);
        }

        private void method_49(bool A_0)
        {
            this.bool_2 = A_0;
            if (A_0)
            {
                this.footnoteType_0 = FootnoteType.Footnote;
            }
            else
            {
                this.footnoteType_0 = FootnoteType.Endnote;
            }
        }

        private void method_50(int A_0, object A_1)
        {
            if (((this.ApplyObjectType == FootEndnoteApplyType.Document) && (base.Document != null)) && (base.Document.Sections.Count > 0))
            {
                foreach (Section section in base.Document.Sections)
                {
                    if (this.IsFootnote)
                    {
                        section.FootnoteOptions[A_0] = A_1;
                    }
                    else
                    {
                        section.EndnoteOptions[A_0] = A_1;
                    }
                }
            }
        }

        private object method_51(int A_0)
        {
            return base[A_0];
        }

        private void method_52(int A_0, object A_1)
        {
            base[A_0] = A_1;
        }

        internal void method_53(FootnoteNumberFormat A_0)
        {
            this.method_52(1, A_0);
        }

        internal void method_54(FootnotePosition A_0)
        {
            this.method_52(2, A_0);
        }

        internal void method_55(FootnoteRestartRule A_0)
        {
            this.method_52(3, A_0);
        }

        internal void method_56(int A_0)
        {
            this.method_52(4, A_0);
        }

        internal FootEndnoteApplyType ApplyObjectType
        {
            get
            {
                return this.footEndnoteApplyType_0;
            }
        }

        private bool IsFootnote
        {
            get
            {
                return this.bool_2;
            }
        }

        public FootnoteNumberFormat NumberFormat
        {
            get
            {
                return (FootnoteNumberFormat) this.method_51(1);
            }
            set
            {
                this.method_52(1, value);
                this.method_50(1, value);
            }
        }

        internal FootnoteType OptionsType
        {
            get
            {
                return this.footnoteType_0;
            }
        }

        public FootnotePosition Position
        {
            get
            {
                return (FootnotePosition) this.method_51(2);
            }
            set
            {
                this.method_52(2, value);
                this.method_50(2, value);
            }
        }

        public FootnoteRestartRule RestartRule
        {
            get
            {
                return (FootnoteRestartRule) this.method_51(3);
            }
            set
            {
                this.method_52(3, value);
                this.method_50(3, value);
            }
        }

        public int StartNumber
        {
            get
            {
                return (int) this.method_51(4);
            }
            set
            {
                this.method_52(4, value);
                this.method_50(4, value);
            }
        }
    }
}

