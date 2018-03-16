namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class ParagraphItemCollection : DocumentObjectCollection
    {
        private byte byte_1;
        private float[] float_1;
        private int[] int_2;
        private static readonly Type[] type_0 = new Type[] { typeof(ParagraphBase) };

        public ParagraphItemCollection(Document doc) : base(doc)
        {
        }

        internal ParagraphItemCollection(Paragraph A_0) : base(A_0.Document, A_0)
        {
        }

        internal ParagraphItemCollection(SDTInlineContent A_0) : base(A_0.Document, A_0)
        {
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            Enum textRange;
            if (!reader.ParseElementType(typeof(ParagraphItemType), out textRange))
            {
                textRange = ParagraphItemType.TextRange;
            }
            return base.Document.CreateParagraphItem((ParagraphItemType) textRange);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("儷丹夻匽", 0x12);
        }

        internal void method_22(ParagraphItemCollection A_0)
        {
            int num = 0;
            int count = base.Count;
            while (num < count)
            {
                ParagraphBase base2 = (ParagraphBase) this[num].Clone();
                if (base2 != null)
                {
                    base2.method_0(A_0.Owner);
                    A_0.method_25(base2);
                }
                num++;
            }
        }

        internal void method_23(int A_0)
        {
            base.InnerList.RemoveAt(A_0);
        }

        internal void method_24(IDocumentObject A_0)
        {
            base.InnerList.Remove(A_0);
        }

        internal void method_25(ParagraphBase A_0)
        {
            base.InnerList.Add(A_0);
            if ((base.Document != null) && !base.Document.bool_3)
            {
                if ((A_0 is Field) && ((A_0 as Field).End != null))
                {
                    base.Document.ClonedFields.Push(A_0 as Field);
                }
                else if ((A_0 is FieldMark) && (base.Document.ClonedFields.Count > 0))
                {
                    Field field = base.Document.ClonedFields.Peek();
                    if ((A_0 as FieldMark).Type == FieldMarkType.FieldSeparator)
                    {
                        field.Separator = A_0 as FieldMark;
                    }
                    else
                    {
                        base.Document.ClonedFields.Pop().End = A_0 as FieldMark;
                    }
                }
            }
        }

        protected override void OnClear()
        {
            if (base.Joined)
            {
                for (int i = 0; i < base.Count; i++)
                {
                    this[i].Detach();
                }
            }
            base.OnClear();
        }

        protected override void OnInsertComplete(int index, DocumentObject entity)
        {
            base.OnInsertComplete(index, entity);
            if ((base.Joined && (entity.Owner != null)) && (this.OwnerParagraph != null))
            {
                ParagraphBase base3 = (ParagraphBase) entity;
                int itemPos = 0;
                if (index > 0)
                {
                    itemPos = this[index - 1].EndPos;
                }
                base3.Attach(this.OwnerParagraph, itemPos);
            }
            else if (base.Joined && (entity.Owner is SDTInlineContent))
            {
                ParagraphBase base2 = (ParagraphBase) entity;
                int endPos = 0;
                if (index > 0)
                {
                    endPos = this[index - 1].EndPos;
                }
                base2.Attach(entity.Owner as SDTInlineContent, endPos);
            }
            else if (base.Joined && (entity.Owner is MergeField))
            {
                (entity as ParagraphBase).CharacterFormat.ApplyBase((entity.Owner as MergeField).CharacterFormat.BaseFormat);
            }
        }

        protected override void OnRemove(int index)
        {
            DocumentObject entity = this[index];
            if (base.Joined)
            {
                this[index].Detach();
            }
            base.OnRemove(base.IndexOf(entity));
        }

        public ParagraphBase this[int index]
        {
            get
            {
                return (base.InnerList[index] as ParagraphBase);
            }
        }

        protected Paragraph OwnerParagraph
        {
            get
            {
                return (base.Owner as Paragraph);
            }
        }

        protected override Type[] TypesOfElement
        {
            get
            {
                return type_0;
            }
        }
    }
}

