namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class ColumnCollection : DocumentSerializableCollection
    {
        internal ColumnCollection(Document A_0) : base(A_0, null)
        {
        }

        internal ColumnCollection(Section A_0) : base(A_0.Document, A_0)
        {
        }

        public int Add(Column column)
        {
            column.method_0(base.OwnerBase);
            return base.InnerList.Add(column);
        }

        public void Clear()
        {
            base.InnerList.Clear();
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new Column(base.Document);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("䰮帰弲䀴娶圸", 9);
        }

        internal void method_5()
        {
            base.InnerList.Clear();
        }

        internal void method_6(ColumnCollection A_0)
        {
            int num = 0;
            int count = base.InnerList.Count;
            while (num < count)
            {
                A_0.Add((base.InnerList[num] as Column).method_5());
                num++;
            }
        }

        public void Populate(int count, float spacing)
        {
            float num = (this.OwnerSection.PageSetup.ClientWidth - (spacing * (count - 1))) / ((float) count);
            base.InnerList.Clear();
            for (int i = 0; i < count; i++)
            {
                Column column = new Column(base.Document) {
                    Width = num,
                    Space = spacing
                };
                this.Add(column);
            }
        }

        public Column this[int index]
        {
            get
            {
                return (Column) base.InnerList[index];
            }
        }

        internal Section OwnerSection
        {
            get
            {
                return (base.OwnerBase as Section);
            }
        }
    }
}

