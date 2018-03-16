namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;
    using System.Text;

    public class SDTInlineContent : DocumentBase, ICompositeObject
    {
        private bool bool_3;
        private bool bool_4;
        private bool[] bool_5;
        private int[] int_2;
        private int int_3;
        private ParagraphItemCollection paragraphItemCollection_0;
        private StringBuilder stringBuilder_0;

        internal SDTInlineContent(Document A_0, StructureDocumentTagInline A_1) : base(A_0, A_1)
        {
            this.stringBuilder_0 = new StringBuilder(1);
            this.paragraphItemCollection_0 = new ParagraphItemCollection(A_0);
            this.paragraphItemCollection_0.method_0(this);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        protected override object CloneImpl()
        {
            SDTInlineContent content = (SDTInlineContent) base.CloneImpl();
            content.paragraphItemCollection_0 = new ParagraphItemCollection(base.Document);
            content.paragraphItemCollection_0.method_0(content);
            this.paragraphItemCollection_0.method_22(content.paragraphItemCollection_0);
            content.stringBuilder_0 = new StringBuilder(1);
            content.stringBuilder_0.Append(this.Text);
            content.method_0(null);
            return content;
        }

        protected override void CreateLayoutInfo()
        {
        }

        internal void method_21()
        {
            this.stringBuilder_0 = new StringBuilder();
            foreach (ParagraphBase base2 in this.paragraphItemCollection_0)
            {
                if (base2.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange)
                {
                    TextRange range = base2 as TextRange;
                    range.StartPos = this.stringBuilder_0.Length;
                    range.TextLength = range.Text.Length;
                    this.stringBuilder_0.Append(range.Text);
                }
            }
        }

        internal void method_22(TextRange A_0, string A_1)
        {
            this.method_23(A_0, A_0.TextLength, A_1);
        }

        internal void method_23(ParagraphBase A_0, int A_1, string A_2)
        {
            int num = 4;
            this.stringBuilder_0.Remove(A_0.StartPos, A_1);
            this.stringBuilder_0.Insert(A_0.StartPos, A_2);
            int num2 = A_2.Length - A_1;
            int index = this.paragraphItemCollection_0.IndexOf(A_0);
            if (index < 0)
            {
                throw new InvalidOperationException(BookmarkStart.b("娩攫娭唯弱ᐳ帵夷䰹夻倽朿㙁摃⁅❇㽉≋⩍灏㭑㩓癕⡗㭙⹛㽝ݟၡգᙥg䩩իᩭᕯάݳ", num));
            }
            int num4 = index + 1;
            int count = this.paragraphItemCollection_0.Count;
            while (num4 < count)
            {
                ParagraphBase base2 = this.paragraphItemCollection_0[num4];
                if (base2 != null)
                {
                    base2.StartPos += num2;
                }
                num4++;
            }
        }

        internal void method_24(int A_0, int A_1, string A_2)
        {
            int length = A_2.Length;
            this.stringBuilder_0.Remove(A_0, A_1);
            this.stringBuilder_0.Insert(A_0, A_2);
        }

        internal SDTInlineContent method_25()
        {
            return (SDTInlineContent) this.CloneImpl();
        }

        private Paragraph method_26()
        {
            DocumentObject owner = base.Owner;
            while (owner != null)
            {
                if (owner is Paragraph)
                {
                    break;
                }
                owner = owner.Owner;
            }
            return (owner as Paragraph);
        }

        internal virtual void RemoveSelf()
        {
            ICompositeObject owner = base.Owner as ICompositeObject;
            if ((owner != null) && (owner.ChildObjects != null))
            {
                owner.ChildObjects.Remove(this);
            }
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.paragraphItemCollection_0;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.SDTInlineContent;
            }
        }

        public ParagraphBase this[int index]
        {
            get
            {
                return this.paragraphItemCollection_0[index];
            }
        }

        internal ParagraphItemCollection Items
        {
            get
            {
                return this.paragraphItemCollection_0;
            }
        }

        public Paragraph OwnerParagraph
        {
            get
            {
                return this.method_26();
            }
        }

        public string Text
        {
            get
            {
                return this.stringBuilder_0.ToString();
            }
        }
    }
}

