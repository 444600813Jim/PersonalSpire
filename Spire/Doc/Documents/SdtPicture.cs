namespace Spire.Doc.Documents
{
    using System;
    using System.Drawing;

    public class SdtPicture : SdtControlProperties
    {
        private float float_0;
        private System.Drawing.Image image_0;
        private long[] long_1;
        private long[] long_2;
        private long[] long_3;
        private string string_1;
        private string string_2;

        internal override void OnChange()
        {
            base.OnChange();
        }

        public void ReplaceImage(System.Drawing.Image image)
        {
            this.image_0 = image;
            this.OnChange();
        }

        internal System.Drawing.Image Image
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

        internal override SdtType Type
        {
            get
            {
                return SdtType.Picture;
            }
        }
    }
}

