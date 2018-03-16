namespace Spire.Doc.Documents.Rendering
{
    using Spire.Doc;
    using System;
    using System.Runtime.CompilerServices;

    public class PageLayoutEventArgs
    {
        private bool bool_0;
        private byte byte_0;
        private float float_0;
        private int int_0;
        private int int_1;
        [CompilerGenerated]
        private int int_2;
        private long[] long_0;
        [CompilerGenerated]
        private Spire.Doc.PageSetup pageSetup_0;

        public int PageIndex
        {
            [CompilerGenerated]
            get
            {
                return this.int_2;
            }
            [CompilerGenerated]
            set
            {
                this.int_2 = value;
            }
        }

        public Spire.Doc.PageSetup PageSetup
        {
            [CompilerGenerated]
            get
            {
                return this.pageSetup_0;
            }
            [CompilerGenerated]
            set
            {
                this.pageSetup_0 = value;
            }
        }
    }
}

