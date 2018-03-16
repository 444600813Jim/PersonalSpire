namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Comment : ParagraphBase, ICompositeObject
    {
        private bool bool_7;
        private bool bool_8;
        private Comment comment_0;
        private CommentMark commentMark_0;
        private CommentMark commentMark_1;
        private CommentsCollection commentsCollection_0;
        private float float_2;
        private long long_4;
        protected CommentFormat m_format;
        protected Spire.Doc.Body m_textBody;
        private ParagraphItemCollection paragraphItemCollection_1;
        private TextBodyPart textBodyPart_0;

        public Comment(IDocument doc) : base((Document) doc)
        {
            this.m_format = new CommentFormat();
            this.m_textBody = new Spire.Doc.Body(base.Document, this);
        }

        internal override bool Accept(Class420 visitor)
        {
            visitor.vmethod_30(this);
            this.Body.Accept(visitor);
            return base.method_12(visitor.vmethod_32(this));
        }

        public void AddItem(IParagraphBase paraItem)
        {
            if ((base.OwnerParagraph != null) && ((this.paragraphItemCollection_1 == null) || !this.paragraphItemCollection_1.Contains(paraItem)))
            {
                Paragraph ownerParagraph = base.OwnerParagraph;
                int index = base.method_5();
                if (this.m_format.CommentId == -1)
                {
                    int num4 = Class323.smethod_0().Next();
                    this.m_format.CommentId = num4;
                    CommentMark entity = new CommentMark(base.m_doc, num4) {
                        Type = CommentMarkType.CommentStart
                    };
                    CommentMark mark3 = new CommentMark(base.m_doc, num4) {
                        Type = CommentMarkType.CommentEnd
                    };
                    ownerParagraph.Items.Insert(index, mark3);
                    ownerParagraph.Items.Insert(index, entity);
                }
                index = base.method_5();
                if (ownerParagraph.Items[index - 1] is CommentMark)
                {
                    int commentId = this.m_format.CommentId;
                    if (paraItem.OwnerParagraph == null)
                    {
                        this.method_32(ownerParagraph, index - 1, paraItem);
                    }
                    else if ((ownerParagraph.Items.Count > (index + 1)) && (paraItem == ownerParagraph.Items[index + 1]))
                    {
                        ownerParagraph.Items.RemoveAt(index + 1);
                        this.method_32(ownerParagraph, index - 1, paraItem);
                    }
                    else
                    {
                        CommentMark mark = this.method_33(index, commentId, ownerParagraph.Items);
                        if ((mark != null) && (paraItem == ownerParagraph.Items[mark.method_5() - 1]))
                        {
                            int num = mark.method_5();
                            ownerParagraph.Items.RemoveAt(num - 1);
                            this.method_32(ownerParagraph, num, paraItem);
                        }
                        else
                        {
                            ParagraphBase base2 = paraItem.Clone() as ParagraphBase;
                            this.method_32(ownerParagraph, index - 1, base2);
                        }
                    }
                }
            }
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            base.Document.Comments.method_6(this);
        }

        public void Clear()
        {
            if ((this.paragraphItemCollection_1 != null) && (this.paragraphItemCollection_1.Count != 0))
            {
                if (this.bool_7)
                {
                    this.paragraphItemCollection_1.Clear();
                    this.textBodyPart_0 = null;
                }
                else
                {
                    ParagraphBase firstItem = this.paragraphItemCollection_1.FirstItem as ParagraphBase;
                    ParagraphBase lastItem = this.paragraphItemCollection_1.LastItem as ParagraphBase;
                    this.method_31(firstItem, lastItem);
                    this.Format.BookmarkStartOffset = 0;
                    this.Format.BookmarkEndOffset = 1;
                    this.paragraphItemCollection_1.Clear();
                    this.bool_7 = false;
                }
            }
        }

        protected override object CloneImpl()
        {
            Comment comment = (Comment) base.CloneImpl();
            comment.m_format = this.Format.Clone(comment.Document);
            comment.m_textBody = (Spire.Doc.Body) this.Body.Clone();
            comment.m_textBody.method_0(comment);
            foreach (BodyRegion region in comment.Body.ChildObjects)
            {
                region.method_0(comment.m_textBody);
            }
            this.paragraphItemCollection_1 = null;
            this.textBodyPart_0 = null;
            return comment;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            base.CloneRelationsTo(doc, nextOwner);
            if (this.m_textBody != null)
            {
                this.m_textBody.CloneRelationsTo(doc, nextOwner);
            }
        }

        internal override void Close()
        {
            base.Close();
            if (this.m_textBody != null)
            {
                this.m_textBody.method_28();
                this.m_textBody = null;
            }
            this.m_format = null;
            this.textBodyPart_0 = null;
            this.paragraphItemCollection_1 = null;
            this.commentsCollection_0 = null;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205();
        }

        internal override void Detach()
        {
            base.Document.Comments.method_5(this);
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䬨䐪䤬嘮", 3), this.m_textBody);
            base.XDLSHolder.AddElement(BookmarkStart.b("䨨䐪䀬䈮吰崲䄴ᨶ弸吺似刾⁀㝂", 3), this.m_format);
        }

        public void MarkCommentDone(bool done)
        {
            this.bool_8 = done;
        }

        internal void method_30()
        {
            List<Comment> list = new List<Comment>();
            foreach (Comment comment2 in this.ReplyCommentItems)
            {
                if (Class323.smethod_1().ContainsKey(comment2.Format.CommentId))
                {
                    int num = Class323.smethod_1()[comment2.Format.CommentId];
                    using (IEnumerator enumerator4 = base.OwnerParagraph.ChildObjects.GetEnumerator())
                    {
                        DocumentObject current;
                        while (enumerator4.MoveNext())
                        {
                            current = (DocumentObject) enumerator4.Current;
                            if ((current is Comment) && ((current as Comment).Format.CommentId == num))
                            {
                                goto Label_00A6;
                            }
                        }
                        continue;
                    Label_00A6:
                        list.Add(current as Comment);
                        continue;
                    }
                }
                using (IEnumerator enumerator3 = base.OwnerParagraph.ChildObjects.GetEnumerator())
                {
                    DocumentObject obj3;
                    while (enumerator3.MoveNext())
                    {
                        obj3 = (DocumentObject) enumerator3.Current;
                        if ((obj3 is Comment) && ((obj3 as Comment).Format.CommentId == comment2.Format.CommentId))
                        {
                            goto Label_0125;
                        }
                    }
                    continue;
                Label_0125:
                    list.Add(obj3 as Comment);
                }
            }
            this.ReplyCommentItems.Clear();
            foreach (Comment comment in list)
            {
                this.ReplyCommentItems.method_6(comment);
                comment.ByRepliedComment = this;
            }
        }

        internal void method_31(ParagraphBase A_0, ParagraphBase A_1)
        {
            if ((A_0.PreviousSibling != null) && (A_0.PreviousSibling is CommentMark))
            {
                A_0.OwnerParagraph.Items.Remove(A_0.PreviousSibling);
            }
            if ((A_1.NextSibling != null) && (A_1.NextSibling is CommentMark))
            {
                A_1.OwnerParagraph.Items.Remove(A_1.NextSibling);
            }
            if (A_0 != A_1)
            {
                if (A_0.OwnerParagraph != A_1.OwnerParagraph)
                {
                    while ((A_0.OwnerParagraph.NextTextBodyItem != A_1.OwnerParagraph) && ((A_0.OwnerParagraph.NextTextBodyItem != null) && this.method_34(A_0.OwnerParagraph.NextTextBodyItem)))
                    {
                        A_0.OwnerParagraph.NextTextBodyItem.RemoveSelf();
                    }
                }
                while ((A_0.NextSibling != null) && ((A_0.NextSibling != A_1) && !(A_0.NextSibling is Comment)))
                {
                    A_0.OwnerParagraph.Items.Remove(A_0.NextSibling);
                }
                while (A_1.PreviousSibling != null)
                {
                    if ((A_1.PreviousSibling == A_0) || (A_0.NextSibling is Comment))
                    {
                        break;
                    }
                    A_1.OwnerParagraph.Items.Remove(A_1.PreviousSibling);
                }
                this.method_37(A_0, A_1);
                this.method_38(A_0, A_1);
            }
            A_1.RemoveSelf();
        }

        private void method_32(Paragraph A_0, int A_1, IParagraphBase A_2)
        {
            A_0.Items.Insert(A_1, A_2);
            (A_2 as ParagraphBase).method_0(A_0);
            this.Items.Add(A_2);
        }

        private CommentMark method_33(int A_0, int A_1, ParagraphItemCollection A_2)
        {
            ParagraphBase base2 = null;
            for (int i = A_0; i > 0; i--)
            {
                base2 = A_2[i];
                if (base2 is CommentMark)
                {
                    CommentMark mark2 = base2 as CommentMark;
                    if ((mark2.Type == CommentMarkType.CommentStart) && (mark2.CommentId == A_1))
                    {
                        return mark2;
                    }
                }
            }
            return null;
        }

        private bool method_34(BodyRegion A_0)
        {
            if (A_0 is Paragraph)
            {
                return this.method_35(A_0 as Paragraph);
            }
            return this.method_36(A_0 as Table);
        }

        private bool method_35(Paragraph A_0)
        {
            bool flag;
            using (IEnumerator enumerator = A_0.Items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    if (current is Comment)
                    {
                        goto Label_002D;
                    }
                }
                return true;
            Label_002D:
                flag = false;
            }
            return flag;
        }

        private bool method_36(Table A_0)
        {
            bool flag = true;
            foreach (TableRow row in A_0.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (IDocumentObject obj2 in cell.ChildObjects)
                    {
                        if (obj2 is Paragraph)
                        {
                            flag = this.method_35(obj2 as Paragraph);
                        }
                        else
                        {
                            flag = this.method_36(obj2 as Table);
                        }
                        if (!flag)
                        {
                            return false;
                        }
                    }
                }
            }
            return flag;
        }

        private void method_37(ParagraphBase A_0, ParagraphBase A_1)
        {
            if ((A_0.OwnerParagraph.NextSibling != A_1.OwnerParagraph) && (A_0.OwnerParagraph.NextSibling != null))
            {
                Paragraph ownerParagraph = A_0.OwnerParagraph;
                Paragraph paragraph2 = A_1.OwnerParagraph;
                Table ownerTable = null;
                Table table2 = null;
                if (base.OwnerParagraph.Owner is TableCell)
                {
                    ownerTable = (base.OwnerParagraph.Owner as TableCell).OwnerRow.OwnerTable;
                }
                if (paragraph2.Owner is TableCell)
                {
                    table2 = (paragraph2.Owner as TableCell).OwnerRow.OwnerTable;
                }
                while (ownerParagraph.NextSibling != A_1.OwnerParagraph)
                {
                    if ((ownerParagraph.NextSibling == null) || (A_0.NextSibling == ownerTable))
                    {
                        break;
                    }
                    if (A_0.NextSibling == table2)
                    {
                        return;
                    }
                    (A_0.NextSibling as BodyRegion).RemoveSelf();
                }
            }
        }

        private void method_38(ParagraphBase A_0, ParagraphBase A_1)
        {
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            if (ownerParagraph.method_5() > 0)
            {
                A_0.RemoveSelf();
            }
            else
            {
                Table ownerTable = null;
                if (ownerParagraph.Owner is TableCell)
                {
                    ownerTable = (ownerParagraph.Owner as TableCell).OwnerRow.OwnerTable;
                }
                if (ownerTable == null)
                {
                    if (ownerParagraph.Items.Count > 1)
                    {
                        A_0.RemoveSelf();
                    }
                    else
                    {
                        ownerParagraph.RemoveSelf();
                    }
                }
                else
                {
                    Paragraph paragraph2 = A_1.OwnerParagraph;
                    Table table2 = null;
                    if (paragraph2.Owner is TableCell)
                    {
                        table2 = (paragraph2.Owner as TableCell).OwnerRow.OwnerTable;
                    }
                    if ((ownerTable != table2) && (ownerParagraph.Owner == ownerTable.FirstRow.Cells[0]))
                    {
                        ownerTable.RemoveSelf();
                    }
                    else
                    {
                        A_0.RemoveSelf();
                    }
                }
            }
        }

        private void method_39()
        {
            foreach (BodyRegion region in this.textBodyPart_0.BodyItems)
            {
                if (region is Paragraph)
                {
                    this.method_40(region as Paragraph);
                }
                else
                {
                    this.method_41(region as Table);
                }
            }
        }

        private void method_40(Paragraph A_0)
        {
            foreach (ParagraphBase base2 in A_0.Items)
            {
                this.Items.Add(base2);
            }
        }

        private void method_41(Table A_0)
        {
            foreach (TableRow row in A_0.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (IDocumentObject obj2 in cell.ChildObjects)
                    {
                        if (obj2 is Paragraph)
                        {
                            this.method_40(obj2 as Paragraph);
                        }
                        else
                        {
                            this.method_41(obj2 as Table);
                        }
                    }
                }
            }
        }

        private string method_42(string A_0)
        {
            A_0 = A_0.Replace(BookmarkStart.b("㠴㴶", 15), BookmarkStart.b("㠴", 15));
            A_0 = A_0.Replace('\n', '\r');
            return A_0;
        }

        public void Replace(TextBodyPart textBodyPart)
        {
            this.Clear();
            this.bool_7 = true;
            this.textBodyPart_0 = textBodyPart;
            this.method_39();
        }

        public void Replace(string text)
        {
            int num = 13;
            string str = this.method_42(text);
            TextRange entity = new TextRange(base.m_doc) {
                Text = text
            };
            if (this.Format.CommentId == -1)
            {
                this.Format.method_6();
            }
            if (str.IndexOf(BookmarkStart.b("㸲", num)) != -1)
            {
                this.Clear();
                this.bool_7 = false;
                int commentId = this.Format.CommentId;
                int index = base.method_5();
                CommentMark mark = new CommentMark(base.Document, commentId, CommentMarkType.CommentStart);
                CommentMark mark2 = new CommentMark(base.Document, commentId, CommentMarkType.CommentEnd);
                base.OwnerParagraph.Items.Insert(index, mark2);
                base.OwnerParagraph.Items.Insert(index, entity);
                base.OwnerParagraph.Items.Insert(index, mark);
            }
            else
            {
                this.Clear();
                this.bool_7 = true;
                this.Items.Add(entity);
            }
        }

        public void ReplyToComment(Comment replyComment)
        {
            if ((base.OwnerParagraph != null) && !base.OwnerParagraph.Items.Contains(replyComment))
            {
                int num = -1;
                if (this.ReplyCommentItems.Count > 0)
                {
                    num = this.ReplyCommentItems[this.ReplyCommentItems.Count - 1].method_5();
                }
                else
                {
                    num = base.method_5();
                }
                if (num >= 1)
                {
                    base.OwnerParagraph.Items.Insert(num + 1, replyComment);
                }
            }
            this.ReplyCommentItems.method_6(replyComment);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("堫圭䀯圱", 6), ParagraphItemType.Comment);
        }

        internal bool AppendItems
        {
            get
            {
                return this.bool_7;
            }
        }

        public Spire.Doc.Body Body
        {
            get
            {
                return this.m_textBody;
            }
        }

        internal TextBodyPart BodyPart
        {
            get
            {
                return this.textBodyPart_0;
            }
        }

        public Comment ByRepliedComment
        {
            get
            {
                return this.comment_0;
            }
            internal set
            {
                this.comment_0 = value;
            }
        }

        public DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.m_textBody.ChildObjects;
            }
        }

        public CommentMark CommentMarkEnd
        {
            get
            {
                return this.commentMark_1;
            }
            internal set
            {
                this.commentMark_1 = value;
            }
        }

        public CommentMark CommentMarkStart
        {
            get
            {
                return this.commentMark_0;
            }
            internal set
            {
                this.commentMark_0 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Comment;
            }
        }

        public CommentFormat Format
        {
            get
            {
                return this.m_format;
            }
        }

        public ParagraphItemCollection Items
        {
            get
            {
                if (this.paragraphItemCollection_1 == null)
                {
                    this.paragraphItemCollection_1 = new ParagraphItemCollection(base.m_doc);
                }
                return this.paragraphItemCollection_1;
            }
        }

        public bool MarkDone
        {
            get
            {
                return this.bool_8;
            }
        }

        public CommentsCollection ReplyCommentItems
        {
            get
            {
                if (this.commentsCollection_0 == null)
                {
                    this.commentsCollection_0 = new CommentsCollection(base.m_doc, this);
                }
                return this.commentsCollection_0;
            }
        }

        internal bool TempHasRange
        {
            get
            {
                return ((this.CommentMarkStart != null) && (this.CommentMarkEnd != null));
            }
        }
    }
}

