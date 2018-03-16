namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class CellCollection : DocumentObjectCollection
    {
        private byte byte_1;
        private float float_1;
        private long long_4;
        private string string_1;
        private static readonly Type[] type_0 = new Type[] { typeof(TableCell), typeof(StructureDocumentTagRow) };

        public CellCollection(TableRow owner) : base(owner.Document, owner)
        {
        }

        public int Add(TableCell cell)
        {
            this.method_23();
            return base.Add(cell);
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new TableCell(base.Document);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("䐦䰨䜪䄬", 1);
        }

        public int IndexOf(TableCell cell)
        {
            return base.IndexOf(cell);
        }

        public void Insert(int index, TableCell cell)
        {
            this.method_23();
            base.Insert(index, cell);
        }

        private void method_22(int A_0)
        {
            TableCell cell = this[A_0];
            Document document = cell.Document;
            int num = 0;
            int count = document.Bookmarks.Count;
            while (num < count)
            {
                Bookmark bookmark = document.Bookmarks[num];
                int cellIndex = cell.GetCellIndex();
                if ((cellIndex >= bookmark.BookmarkStart.ColumnFirst) && (cellIndex <= bookmark.BookmarkStart.ColumnLast))
                {
                    document.Bookmarks.Remove(bookmark);
                }
                else if (cellIndex < bookmark.BookmarkStart.ColumnFirst)
                {
                    BookmarkStart bookmarkStart = bookmark.BookmarkStart;
                    bookmarkStart.ColumnFirst--;
                    BookmarkStart start2 = bookmark.BookmarkStart;
                    start2.ColumnLast--;
                }
                num++;
            }
        }

        private void method_23()
        {
            if (((base.Owner != null) && (base.Owner is TableRow)) && !base.Owner.Document.bool_3)
            {
                (base.Owner as TableRow).method_35();
            }
        }

        public void Remove(TableCell cell)
        {
            this.method_23();
            this.method_22(cell.GetCellIndex());
            base.Remove(cell);
        }

        public void RemoveAt(int index)
        {
            this.method_23();
            this.method_22(index);
            base.RemoveAt(index);
        }

        public TableCell this[int index]
        {
            get
            {
                return (base.InnerList[index] as TableCell);
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

