namespace Spire.Doc.Documents.XML
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Interface;
    using System;

    public abstract class DocumentSerializableCollection : CollectionEx, IXDLSSerializableCollection
    {
        protected DocumentSerializableCollection(Document doc, OwnerHolder owner) : base(doc, owner)
        {
        }

        internal virtual void CloneToImpl(CollectionEx coll)
        {
            foreach (DocumentSerializable serializable in base.InnerList)
            {
                coll.InnerList.Add(serializable.method_4());
            }
        }

        protected abstract OwnerHolder CreateItem(IXDLSContentReader reader);
        protected abstract string GetTagItemName();
        IDocumentSerializable IXDLSSerializableCollection.AddNewItem(IXDLSContentReader reader)
        {
            OwnerHolder holder = this.CreateItem(reader);
            if (holder != null)
            {
                base.InnerList.Add(holder);
                holder.method_0(base.OwnerBase);
            }
            return (holder as IDocumentSerializable);
        }

        string IXDLSSerializableCollection.TagItemName
        {
            get
            {
                return this.GetTagItemName();
            }
        }
    }
}

