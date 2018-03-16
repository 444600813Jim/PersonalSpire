namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class TableCollection : DocumentSubsetCollection, ITableCollection
    {
        public TableCollection(BodyRegionCollection bodyItems) : base(bodyItems, DocumentObjectType.Table)
        {
        }

        public int Add(ITable table)
        {
            return base.method_2((DocumentObject) table);
        }

        public bool Contains(ITable table)
        {
            return base.method_3((DocumentObject) table);
        }

        public int IndexOf(ITable table)
        {
            return base.method_4((DocumentObject) table);
        }

        public int Insert(int index, ITable table)
        {
            return base.method_5(index, (DocumentObject) table);
        }

        public void Remove(ITable table)
        {
            base.method_6((DocumentObject) table);
        }

        public void RemoveAt(int index)
        {
            base.method_7(index);
        }

        public ITable this[int index]
        {
            get
            {
                return (base.GetByIndex(index) as ITable);
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

