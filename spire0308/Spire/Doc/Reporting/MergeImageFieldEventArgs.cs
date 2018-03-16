namespace Spire.Doc.Reporting
{
    using Spire.Doc.Interface;
    using System;
    using System.Drawing;
    using System.IO;

    public class MergeImageFieldEventArgs : MergeFieldEventArgs
    {
        private bool bool_1;
        private bool bool_2;
        private float float_1;
        private System.Drawing.Image image_0;
        private int int_1;
        private long[] long_1;
        private SizeF sizeF_0;
        private Stream stream_0;
        private string string_1;
        private string string_2;

        public MergeImageFieldEventArgs(IDocument doc, string tableName, int rowIndex, IMergeField field, System.Drawing.Image image) : base(doc, tableName, rowIndex, field, null)
        {
            this.string_2 = "";
            this.image_0 = image;
        }

        public MergeImageFieldEventArgs(IDocument doc, string tableName, int rowIndex, IMergeField field, object obj) : this(doc, tableName, rowIndex, field, obj, string.Empty)
        {
        }

        internal MergeImageFieldEventArgs(IDocument A_0, string A_1, int A_2, IMergeField A_3, object A_4, string A_5) : base(A_0, A_1, A_2, A_3, A_4)
        {
            this.string_2 = "";
            this.image_0 = A_4 as System.Drawing.Image;
            if (!string.IsNullOrEmpty(A_5))
            {
                this.ImageFileName = A_5;
            }
        }

        private void method_0(string A_0)
        {
            this.image_0 = new Bitmap(A_0);
        }

        private void method_1(Stream A_0)
        {
            this.image_0 = new Bitmap(A_0);
        }

        public System.Drawing.Image Image
        {
            get
            {
                return this.image_0;
            }
            set
            {
                this.image_0 = value;
            }
        }

        public string ImageFileName
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
                this.method_0(this.string_2);
            }
        }

        public Stream ImageStream
        {
            get
            {
                return this.stream_0;
            }
            set
            {
                this.stream_0 = value;
                this.method_1(this.stream_0);
            }
        }

        public SizeF PictureSize
        {
            get
            {
                return this.sizeF_0;
            }
            set
            {
                this.sizeF_0 = value;
            }
        }

        public bool Skip
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

        public bool UseText
        {
            get
            {
                return this.bool_1;
            }
        }
    }
}

