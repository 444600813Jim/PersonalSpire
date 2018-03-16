namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class BodyRegionCollection : DocumentObjectCollection
    {
        private bool[] bool_0;
        private long[] long_4;
        private string string_1;
        private static readonly Type[] type_0 = new Type[] { typeof(Table), typeof(Paragraph), typeof(StructureDocumentTag) };

        public BodyRegionCollection(Body body) : base(body.Document, body)
        {
        }

        internal BodyRegionCollection(Document A_0) : base(A_0, null)
        {
        }

        internal BodyRegionCollection(Document A_0, DocumentObject A_1) : base(A_0, A_1)
        {
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            string str2;
            int num = 11;
            if (((str2 = reader.GetAttributeValue(BookmarkStart.b("䔰䨲䔴制", 11))) != null) && (str2 == BookmarkStart.b("攰刲圴嬶尸", num)))
            {
                return new Table(base.Document);
            }
            return new Paragraph(base.Document);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("尴䌶尸嘺", 15);
        }

        internal Section method_22()
        {
            DocumentObject owner = base.Owner;
            while (owner != null)
            {
                if ((owner is Section) || (owner.Owner == null))
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner is Section)
            {
                return (owner as Section);
            }
            if (base.Document.Sections.Count <= 0)
            {
                return null;
            }
            return base.Document.Sections[0];
        }

        internal BodyRegion this[int A_0]
        {
            get
            {
                return (BodyRegion) base[A_0];
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

