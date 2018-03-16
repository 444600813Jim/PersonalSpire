namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class ListLevelCollection : DocumentSerializableCollection
    {
        internal ListLevelCollection(ListStyle A_0) : base(A_0.Document, A_0)
        {
        }

        internal override void CloneToImpl(CollectionEx coll)
        {
            foreach (DocumentSerializable serializable in base.InnerList)
            {
                coll.InnerList.Add(serializable.method_4());
                (coll.InnerList[coll.Count - 1] as ListLevel).method_0(coll.OwnerBase);
            }
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new ListLevel(base.OwnerBase as ListStyle);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("头制伸帺儼", 15);
        }

        internal int method_5(ListLevel A_0)
        {
            int num = 10;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("尯圱䈳匵吷", num));
            }
            A_0.method_0(base.OwnerBase);
            return base.InnerList.Add(A_0);
        }

        internal int method_6(ListLevel A_0)
        {
            return base.InnerList.IndexOf(A_0);
        }

        internal void method_7()
        {
            base.InnerList.Clear();
        }

        public ListLevel this[int index]
        {
            get
            {
                return (ListLevel) base.InnerList[index];
            }
        }
    }
}

