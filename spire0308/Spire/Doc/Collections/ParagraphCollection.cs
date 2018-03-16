namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class ParagraphCollection : DocumentSubsetCollection, IParagraphCollection
    {
        public ParagraphCollection(BodyRegionCollection bodyItems) : base(bodyItems, DocumentObjectType.Paragraph)
        {
        }

        public int Add(IParagraph paragraph)
        {
            base.Document.method_156(paragraph);
            return base.method_2((DocumentObject) paragraph);
        }

        public bool Contains(IParagraph paragraph)
        {
            return base.method_3((DocumentObject) paragraph);
        }

        public int IndexOf(IParagraph paragraph)
        {
            return base.method_4((DocumentObject) paragraph);
        }

        public void Insert(int index, IParagraph paragraph)
        {
            base.Document.method_156(paragraph);
            base.method_5(index, (DocumentObject) paragraph);
        }

        public void Remove(IParagraph paragraph)
        {
            base.method_6((DocumentObject) paragraph);
        }

        public void RemoveAt(int index)
        {
            base.method_7(index);
        }

        public Paragraph this[int index]
        {
            get
            {
                return (Paragraph) base.GetByIndex(index);
            }
        }

        internal IBody OwnerTextBody
        {
            get
            {
                return (base.Owner as IBody);
            }
        }
    }
}

