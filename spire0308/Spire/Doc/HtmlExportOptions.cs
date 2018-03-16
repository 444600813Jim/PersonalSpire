namespace Spire.Doc
{
    using System;

    public class HtmlExportOptions
    {
        private bool bool_0;
        private bool bool_1 = true;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private Spire.Doc.CssStyleSheetType cssStyleSheetType_0;
        private float[] float_0;
        private int int_0 = 3;
        private int[] int_1;
        private int int_2;
        private long long_0;
        private long long_1;
        private string string_0;
        private string string_1 = string.Empty;
        private string[] string_2;

        public string CssStyleSheetFileName
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }

        public Spire.Doc.CssStyleSheetType CssStyleSheetType
        {
            get
            {
                return this.cssStyleSheetType_0;
            }
            set
            {
                this.cssStyleSheetType_0 = value;
            }
        }

        public bool EPubExportFont
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        internal int EPubHeadingLevels
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        internal string[] FontFiles
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
            }
        }

        public bool HasHeadersFooters
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        public bool ImageEmbedded
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        public string ImagesPath
        {
            get
            {
                return this.string_1;
            }
            set
            {
                this.string_1 = value;
            }
        }

        public bool IsTextInputFormFieldAsText
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                this.bool_2 = value;
            }
        }
    }
}

