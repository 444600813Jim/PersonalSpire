namespace Spire.Doc
{
    using Spire.Pdf;
    using Spire.Pdf.Security;
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class ToPdfParameterList
    {
        private BookmarkTextStyle bookmarkTextStyle_0 = BookmarkTextStyle.Bold;
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private bool bool_7;
        private Color color_0 = Color.SaddleBrown;
        private Dictionary<string, Struct10> dictionary_0 = new Dictionary<string, Struct10>();
        private float float_0;
        private int int_0;
        private List<string> list_0 = new List<string>();
        private List<PrivateFontPath> list_1 = new List<PrivateFontPath>();
        private long long_0;
        private Spire.Pdf.PdfConformanceLevel pdfConformanceLevel_0;
        private Spire.Pdf.Security.PdfSecurity pdfSecurity_0;
        private string string_0;
        private string string_1 = BookmarkStart.b("怶嘸䤺夼Ἶ̀ⱂ⩄ⱆ⑈⩊㽌⑎≐", 0x11);
        private string[] string_2;

        [Obsolete("This properties is obsolete")]
        public bool AutoFitTableLayout
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

        public bool CreateWordBookmarks
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

        public bool DisableLink
        {
            get
            {
                return this.bool_6;
            }
            set
            {
                this.bool_6 = value;
            }
        }

        public List<string> EmbeddedFontNameList
        {
            get
            {
                return this.list_0;
            }
            set
            {
                this.list_0 = value;
                if ((this.list_0 != null) && (this.list_0.Count > 0))
                {
                    this.bool_3 = false;
                }
            }
        }

        public bool IsAtLast
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

        public bool IsEmbeddedAllFonts
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
                if (this.bool_3)
                {
                    this.list_0 = new List<string>();
                }
            }
        }

        public bool IsHidden
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

        public Spire.Pdf.PdfConformanceLevel PdfConformanceLevel
        {
            get
            {
                return this.pdfConformanceLevel_0;
            }
            set
            {
                this.pdfConformanceLevel_0 = value;
            }
        }

        public Spire.Pdf.Security.PdfSecurity PdfSecurity
        {
            get
            {
                if (this.pdfSecurity_0 == null)
                {
                    this.pdfSecurity_0 = new Spire.Pdf.Security.PdfSecurity();
                }
                return this.pdfSecurity_0;
            }
        }

        internal Dictionary<string, Struct10> PrivateFontList
        {
            get
            {
                return this.dictionary_0;
            }
        }

        public List<PrivateFontPath> PrivateFontPaths
        {
            get
            {
                return this.list_1;
            }
            set
            {
                this.list_1 = value;
            }
        }

        public bool UsePSCoversion
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                this.bool_7 = value;
            }
        }

        public Color WordBookmarksColor
        {
            get
            {
                return this.color_0;
            }
            set
            {
                this.color_0 = value;
            }
        }

        public BookmarkTextStyle WordBookmarksTextStyle
        {
            get
            {
                return this.bookmarkTextStyle_0;
            }
            set
            {
                this.bookmarkTextStyle_0 = value;
            }
        }

        public string WordBookmarksTitle
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
    }
}

