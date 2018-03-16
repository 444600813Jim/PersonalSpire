namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.Rendering;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class BookmarkStart : ParagraphBase, Interface2
    {
        private bool bool_7;
        private bool bool_8;
        internal bool bool_9;
        private int int_4;
        private int int_5;
        private int int_6;
        private int int_7;
        private string string_8;

        internal BookmarkStart(Document A_0) : this(A_0, "")
        {
        }

        public BookmarkStart(IDocument doc, string name) : base((Document) doc)
        {
            this.string_8 = "";
            this.int_6 = -1;
            this.int_7 = -1;
            this.method_30(name);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_12(visitor.vmethod_23(this));
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            if (!base.DeepDetached)
            {
                base.Document.Bookmarks.method_6(this);
                this.bool_9 = false;
            }
            else
            {
                this.bool_9 = true;
                this.bool_8 = true;
            }
        }

        internal static string b(string A_0, int A_1)
        {
            int num2 = 0;
            char[] chArray = A_0.ToCharArray();
            int num = 0x24c08b25 + A_1;
            while (true)
            {
                if (0 >= chArray.Length)
                {
                    break;
                }
                char ch1 = chArray[num2];
                byte num3 = (byte) ((ch1 & '\x00ff') ^ num++);
                byte num4 = (byte) ((ch1 >> 8) ^ num++);
                num4 = num3;
                num3 = num4;
                chArray[num2] = (char) ((num4 << 8) | num3);
            }
            int num1 = (num2 = 0) + 1;
            return string.Intern(new string(chArray));
        }

        internal override void CloneCommit()
        {
            if (this.bool_9 && this.bool_8)
            {
                base.Document.Bookmarks.method_6(this);
                this.bool_9 = false;
                this.bool_8 = false;
            }
        }

        protected override object CloneImpl()
        {
            BookmarkStart start = (BookmarkStart) base.CloneImpl();
            start.bool_9 = true;
            start.bool_8 = true;
            return start;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_13(true);
            if (base.Owner is SDTInlineContent)
            {
                base.interface23_0.imethod_3((base.Owner.Owner.Owner as Interface1).imethod_0().imethod_2());
            }
            else
            {
                base.interface23_0.imethod_3(((Interface1) base.OwnerParagraph).imethod_0().imethod_2());
            }
        }

        internal override void Detach()
        {
            base.Detach();
            if (!base.DeepDetached)
            {
                BookmarkCollection bookmarks = base.Document.Bookmarks;
                Bookmark bookmark = bookmarks.FindByName(this.Name);
                if (bookmark != null)
                {
                    bookmark.method_0(null);
                    bookmarks.Remove(bookmark);
                }
            }
        }

        internal void method_30(string A_0)
        {
            this.string_8 = A_0.Replace('-', '_');
        }

        private void method_31(Class196 A_0, Class375 A_1, BookmarkLevel A_2)
        {
            for (int i = 0; i < A_0.method_145().Count; i++)
            {
                string text = string.Empty;
                if (base.Owner is Paragraph)
                {
                    text = (base.Owner as Paragraph).Text;
                }
                if (A_2 != null)
                {
                    A_2.Text = text;
                }
                foreach (KeyValuePair<string, Class310> pair in A_0.method_145()[i])
                {
                    if (pair.Key == this.Name)
                    {
                        pair.Value.method_3(A_1.method_69());
                        pair.Value.method_5(A_0.method_16());
                        A_0.method_400(base.OwnerParagraph, pair.Value);
                        pair.Value.method_11(text);
                        if (A_2 != null)
                        {
                            A_2.SourcePageNumber = pair.Value.method_6();
                            A_2.SourceBounds = pair.Value.method_0();
                        }
                    }
                }
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 2;
            base.ReadXmlAttributes(reader);
            this.string_8 = reader.ReadString(b("樧䔩䌫䔭崯匱䘳崵瘷嬹儻嬽", 2));
            base.Document.Bookmarks.method_6(this);
            if (reader.HasAttribute(b("愧天漫䬭尯帱猳䐵圷伹䰻簽⬿⽁⽃", 2)))
            {
                this.IsCellGroupBkmk = reader.ReadBoolean(b("愧天漫䬭尯帱猳䐵圷伹䰻簽⬿⽁⽃", num));
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            int num = 8;
            if (!this.Name.StartsWith(b("焭", 8)))
            {
                BookmarkLevel item = new BookmarkLevel {
                    Name = this.Name,
                    IsPair = false,
                    TargetBounds = ltWidget.method_69(),
                    TargetPageNumber = dc.method_16()
                };
                if (dc.method_149() != null)
                {
                    if (!dc.method_149().IsDrawComplete && !dc.method_149().ChildObjects.Contains(item))
                    {
                        dc.method_149().method_0(item);
                        dc.method_150(item);
                        BookmarkLevelEventArgs args2 = new BookmarkLevelEventArgs {
                            BookmarkLevel = item,
                            BookmarkStart = this
                        };
                        base.Document.method_21(args2);
                    }
                }
                else if (!dc.method_147().Contains(item))
                {
                    dc.method_147().Add(item);
                    dc.method_150(item);
                    BookmarkLevelEventArgs args = new BookmarkLevelEventArgs {
                        BookmarkLevel = item,
                        BookmarkStart = this
                    };
                    base.Document.method_21(args);
                }
                this.method_31(dc, ltWidget, item);
            }
            else if (this.Name.ToLower().StartsWith(b("焭䐯崱圳", num)))
            {
                this.method_31(dc, ltWidget, null);
            }
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            int num = 5;
            SizeF ef = new SizeF(0.0045f, 0f);
            Paragraph ownerParagraph = base.OwnerParagraph;
            if ((ownerParagraph == null) && (base.Owner is SDTInlineContent))
            {
                ownerParagraph = (base.Owner as SDTInlineContent).OwnerParagraph;
            }
            if (ownerParagraph != null)
            {
                ef.Height = dc.method_1() ? dc.method_309(b("∪", num), dc.method_376(ownerParagraph.BreakCharacterFormat), null).Height : dc.method_316(b("∪", num), dc.method_365(ownerParagraph.BreakCharacterFormat), null).Height;
                if (ownerParagraph.ParaStyle != null)
                {
                    ef.Height = Math.Min(ef.Height, dc.method_1() ? dc.method_309(b("∪", num), dc.method_376(ownerParagraph.ParaStyle.CharacterFormat), null).Height : dc.method_316(b("∪", num), dc.method_365(ownerParagraph.ParaStyle.CharacterFormat), null).Height);
                }
            }
            int num2 = base.Document.DocLayoter.method_28().method_31() + 1;
            if (base.Document.DocLayoter.dictionary_1.ContainsKey(this.Name))
            {
                base.Document.DocLayoter.dictionary_1[this.Name] = num2;
                return ef;
            }
            base.Document.DocLayoter.dictionary_1.Add(this.Name, num2);
            return ef;
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 8;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(b("娭䤯䈱儳", 8), ParagraphItemType.BookmarkStart);
            writer.WriteValue(b("氭弯崱弳嬵夷䠹圻瀽ℿ⽁⅃", 8), this.Name);
            if (this.IsCellGroupBkmk)
            {
                writer.WriteValue(b("札䌯焱儳娵吷紹主儽㔿㉁كⵅ╇ⅉ", num), this.IsCellGroupBkmk);
            }
        }

        public SizeF imethod_3(Class196 A_0)
        {
            throw new NotImplementedException();
        }

        internal int ColumnFirst
        {
            get
            {
                return this.int_6;
            }
            set
            {
                this.int_6 = value;
            }
        }

        internal int ColumnLast
        {
            get
            {
                return this.int_7;
            }
            set
            {
                this.int_7 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.BookmarkStart;
            }
        }

        internal int Flags
        {
            get
            {
                return this.int_4;
            }
            set
            {
                this.int_4 = value;
            }
        }

        internal bool IsCellGroupBkmk
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

        internal bool IsTableColumnBookmark
        {
            get
            {
                return ((this.ColumnLast & this.ColumnFirst) >= 0);
            }
        }

        public string Name
        {
            get
            {
                return this.string_8;
            }
        }
    }
}

