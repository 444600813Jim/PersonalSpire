namespace Spire.Doc
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct PrivateFontPath
    {
        private byte byte_0;
        private string string_0;
        private bool[] bool_0;
        private string string_1;
        private System.Drawing.FontStyle fontStyle_0;
        public string FontPath
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
        public string FontName
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
        public System.Drawing.FontStyle FontStyle
        {
            get
            {
                return this.fontStyle_0;
            }
            set
            {
                this.fontStyle_0 = value;
            }
        }
        public PrivateFontPath(string fontName, string fontPath)
        {
            this.string_1 = fontName;
            this.string_0 = fontPath;
            this.fontStyle_0 = System.Drawing.FontStyle.Regular;
        }

        public PrivateFontPath(string fontName, System.Drawing.FontStyle fontStyle, string fontPath) : this(fontName, fontPath)
        {
            this.fontStyle_0 = fontStyle;
        }
    }
}

