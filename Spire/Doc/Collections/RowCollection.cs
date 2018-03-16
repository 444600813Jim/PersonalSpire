namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class RowCollection : DocumentObjectCollection
    {
        private int int_2;
        private static readonly Type[] type_0 = new Type[] { typeof(TableRow) };

        public RowCollection(Table owner) : base(owner.Document, owner)
        {
        }

        public int Add(TableRow row)
        {
            return base.Add(row);
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new TableRow(base.Document);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("䌰尲䈴", 11);
        }

        public int IndexOf(TableRow row)
        {
            return base.IndexOf(row);
        }

        public void Insert(int index, TableRow row)
        {
            base.Insert(index, row);
        }

        public void Remove(TableRow row)
        {
            base.Remove(row);
        }

        public TableRow this[int index]
        {
            get
            {
                return (base.InnerList[index] as TableRow);
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

