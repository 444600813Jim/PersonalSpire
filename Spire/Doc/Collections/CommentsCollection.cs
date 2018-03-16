namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class CommentsCollection : CollectionEx
    {
        private byte byte_1;
        private int int_2;
        private int[] int_3;
        private List<int> list_1;
        private long[] long_4;
        private string string_1;
        private string[] string_2;

        public CommentsCollection(Document doc) : base(doc, doc)
        {
            this.list_1 = new List<int>();
        }

        internal CommentsCollection(Document A_0, Comment A_1) : base(A_0, A_1)
        {
            this.list_1 = new List<int>();
        }

        public void Clear()
        {
            while (base.InnerList.Count > 0)
            {
                int index = base.InnerList.Count - 1;
                this.RemoveAt(index);
            }
        }

        public int Counts()
        {
            return base.InnerList.Count;
        }

        internal void method_5(Comment A_0)
        {
            if ((A_0 != null) && (base.InnerList.Count > 0))
            {
                if (A_0.Format != null)
                {
                    this.list_1.Remove(A_0.Format.CommentId);
                }
                base.InnerList.Remove(A_0);
            }
        }

        internal void method_6(Comment A_0)
        {
            if (this.list_1.Contains(A_0.Format.CommentId))
            {
                this.list_1.Sort();
                int count = this.list_1.Count;
                int num2 = this.list_1[count - 1];
                A_0.Format.CommentId = num2 + 1;
                if (A_0.CommentMarkStart != null)
                {
                    A_0.CommentMarkStart.CommentId = num2 + 1;
                }
                if (A_0.CommentMarkEnd != null)
                {
                    A_0.CommentMarkEnd.CommentId = num2 + 1;
                }
            }
            base.InnerList.Add(A_0);
            this.list_1.Add(A_0.Format.CommentId);
            if (base.OwnerBase is Comment)
            {
                A_0.ByRepliedComment = base.OwnerBase as Comment;
            }
        }

        public void Remove(Comment comment)
        {
            base.InnerList.Remove(comment);
            if (comment.Format != null)
            {
                this.list_1.Remove(comment.Format.CommentId);
            }
            comment.OwnerParagraph.Items.Remove(comment);
            for (int i = 0; i < base.InnerList.Count; i++)
            {
                Comment comment2 = base.InnerList[i] as Comment;
                comment2.ReplyCommentItems.method_5(comment);
            }
        }

        public void RemoveAt(int index)
        {
            Comment comment = base.InnerList[index] as Comment;
            base.InnerList.Remove(comment);
            if (comment.Format != null)
            {
                this.list_1.Remove(comment.Format.CommentId);
            }
            if (comment.OwnerParagraph != null)
            {
                comment.OwnerParagraph.Items.Remove(comment);
            }
            for (int i = 0; i < base.InnerList.Count; i++)
            {
                Comment comment2 = base.InnerList[i] as Comment;
                comment2.ReplyCommentItems.method_5(comment);
            }
        }

        public Comment this[int index]
        {
            get
            {
                return (base.InnerList[index] as Comment);
            }
        }
    }
}

