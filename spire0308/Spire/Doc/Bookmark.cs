namespace Spire.Doc
{
    using System;

    public class Bookmark
    {
        private Spire.Doc.BookmarkEnd bookmarkEnd_0;
        private Spire.Doc.BookmarkStart bookmarkStart_0;
        private int[] int_0;
        private long long_0;
        private string[] string_0;

        public Bookmark(Spire.Doc.BookmarkStart start) : this(start, null)
        {
        }

        public Bookmark(Spire.Doc.BookmarkStart start, Spire.Doc.BookmarkEnd end)
        {
            this.bookmarkStart_0 = start;
            this.bookmarkEnd_0 = end;
        }

        internal void method_0(Spire.Doc.BookmarkStart A_0)
        {
            this.bookmarkStart_0 = A_0;
        }

        internal void method_1(Spire.Doc.BookmarkEnd A_0)
        {
            this.bookmarkEnd_0 = A_0;
        }

        internal void method_2(string A_0)
        {
            if (!string.IsNullOrEmpty(A_0))
            {
                if (this.bookmarkStart_0 != null)
                {
                    this.bookmarkStart_0.method_30(A_0);
                }
                if (this.bookmarkEnd_0 != null)
                {
                    this.bookmarkEnd_0.method_30(A_0);
                }
            }
        }

        public Spire.Doc.BookmarkEnd BookmarkEnd
        {
            get
            {
                return this.bookmarkEnd_0;
            }
        }

        public Spire.Doc.BookmarkStart BookmarkStart
        {
            get
            {
                return this.bookmarkStart_0;
            }
        }

        public string Name
        {
            get
            {
                return this.bookmarkStart_0.Name;
            }
        }
    }
}

