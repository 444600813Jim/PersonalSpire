namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using System;
    using System.Reflection;

    public class BookmarkCollection : CollectionEx
    {
        internal BookmarkCollection(Document A_0) : base(A_0, A_0)
        {
        }

        public void Clear()
        {
            while (base.InnerList.Count > 0)
            {
                int index = base.InnerList.Count - 1;
                this.RemoveAt(index);
            }
        }

        public Bookmark FindByName(string name)
        {
            name.Replace('-', '_');
            for (int i = 0; i < base.InnerList.Count; i++)
            {
                Bookmark bookmark = base.InnerList[i] as Bookmark;
                if (bookmark.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return bookmark;
                }
            }
            return null;
        }

        internal void method_5(Bookmark A_0)
        {
            base.InnerList.Add(A_0);
        }

        internal void method_6(BookmarkStart A_0)
        {
            int num = 0x13;
            if (this[A_0.Name] != null)
            {
                A_0.method_30(A_0.Name + BookmarkStart.b("昸", num) + Guid.NewGuid().ToString());
                A_0.RemoveSelf();
            }
            else
            {
                Bookmark bookmark = new Bookmark(A_0);
                this.method_5(bookmark);
            }
        }

        internal void method_7(BookmarkEnd A_0)
        {
            Bookmark bookmark = this[A_0.Name];
            if (bookmark != null)
            {
                if (bookmark.BookmarkEnd != null)
                {
                    A_0.RemoveSelf();
                }
                else
                {
                    bookmark.method_1(A_0);
                }
            }
        }

        internal void method_8(string A_0, string A_1)
        {
            if (!string.IsNullOrEmpty(A_1))
            {
                Bookmark bookmark = this.FindByName(A_0);
                if (bookmark != null)
                {
                    bookmark.method_2(A_1);
                }
            }
        }

        public void Remove(Bookmark bookmark)
        {
            base.InnerList.Remove(bookmark);
            BookmarkStart bookmarkStart = bookmark.BookmarkStart;
            BookmarkEnd bookmarkEnd = bookmark.BookmarkEnd;
            if (bookmarkStart != null)
            {
                bookmarkStart.RemoveSelf();
            }
            if (bookmarkEnd != null)
            {
                bookmarkEnd.RemoveSelf();
            }
        }

        public void RemoveAt(int index)
        {
            Bookmark bookmark = base.InnerList[index] as Bookmark;
            this.Remove(bookmark);
        }

        public Bookmark this[string name]
        {
            get
            {
                return this.FindByName(name);
            }
        }

        public Bookmark this[int index]
        {
            get
            {
                return (base.InnerList[index] as Bookmark);
            }
        }
    }
}

