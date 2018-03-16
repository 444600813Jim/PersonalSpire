namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;

    public class CommentMark : ParagraphBase
    {
        private byte[] byte_4;
        private CommentMarkType commentMarkType_0;
        private int int_4;

        public CommentMark(IDocument doc) : base((Document) doc)
        {
            this.int_4 = -1;
        }

        internal CommentMark(Document A_0, int A_1) : this(A_0)
        {
            this.int_4 = A_1;
        }

        internal CommentMark(Document A_0, int A_1, CommentMarkType A_2) : this(A_0, A_1)
        {
            this.commentMarkType_0 = A_2;
        }

        internal override bool Accept(Class420 visitor)
        {
            if (this.Type == CommentMarkType.CommentStart)
            {
                return base.method_12(visitor.vmethod_31(this));
            }
            return base.method_12(visitor.vmethod_33(this));
        }

        protected override object CloneImpl()
        {
            CommentMark mark = (CommentMark) base.CloneImpl();
            if (this.int_4 != -1)
            {
                if (this.commentMarkType_0 == CommentMarkType.CommentStart)
                {
                    mark.CommentId = Class323.smethod_6(this.int_4, true);
                    return mark;
                }
                mark.CommentId = Class323.smethod_6(this.int_4, false);
            }
            return mark;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205();
            base.interface23_0.imethod_5(true);
        }

        public int CommentId
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

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.CommentMark;
            }
        }

        public CommentMarkType Type
        {
            get
            {
                return this.commentMarkType_0;
            }
            set
            {
                this.commentMarkType_0 = value;
            }
        }
    }
}

