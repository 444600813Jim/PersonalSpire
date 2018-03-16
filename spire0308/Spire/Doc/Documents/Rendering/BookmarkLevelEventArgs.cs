namespace Spire.Doc.Documents.Rendering
{
    using Spire.Doc;
    using System;
    using System.Runtime.CompilerServices;

    public class BookmarkLevelEventArgs
    {
        [CompilerGenerated]
        private Spire.Doc.Documents.Rendering.BookmarkLevel bookmarkLevel_0;
        [CompilerGenerated]
        private Spire.Doc.BookmarkStart bookmarkStart_0;
        private byte byte_0;

        public Spire.Doc.Documents.Rendering.BookmarkLevel BookmarkLevel
        {
            [CompilerGenerated]
            get
            {
                return this.bookmarkLevel_0;
            }
            [CompilerGenerated]
            set
            {
                this.bookmarkLevel_0 = value;
            }
        }

        public Spire.Doc.BookmarkStart BookmarkStart
        {
            [CompilerGenerated]
            get
            {
                return this.bookmarkStart_0;
            }
            [CompilerGenerated]
            set
            {
                this.bookmarkStart_0 = value;
            }
        }
    }
}

