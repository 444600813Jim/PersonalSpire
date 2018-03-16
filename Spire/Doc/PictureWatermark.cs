namespace Spire.Doc
{
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Drawing;

    public class PictureWatermark : WatermarkBase
    {
        private bool bool_10;
        private bool bool_11;
        private DocPicture docPicture_0;
        private float[] float_3;
        private int int_7;

        public PictureWatermark() : base(WatermarkType.PictureWatermark)
        {
            this.bool_10 = true;
            this.int_7 = -1;
            this.bool_11 = true;
            this.docPicture_0 = new DocPicture(null);
        }

        internal PictureWatermark(Document A_0) : base(A_0, WatermarkType.PictureWatermark)
        {
            this.bool_10 = true;
            this.int_7 = -1;
            this.bool_11 = true;
            this.docPicture_0 = new DocPicture(A_0);
        }

        public PictureWatermark(Image image, bool washout) : this()
        {
            this.Picture = image;
            this.bool_10 = washout;
        }

        protected override object CloneImpl()
        {
            PictureWatermark watermark = (PictureWatermark) base.CloneImpl();
            watermark.WordPicture = (DocPicture) this.WordPicture.Clone();
            return watermark;
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("崳嬵夷崹夻", 14), this.docPicture_0);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x10;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("昵儷夹䠻䬽㈿❁ፃ❅㭇≉⍋㭍⑏", 0x10)))
            {
                this.bool_10 = reader.ReadBoolean(BookmarkStart.b("昵儷夹䠻䬽㈿❁ፃ❅㭇≉⍋㭍⑏", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("昵儷夹䠻䬽㈿❁ᑃ⽅⩇", num)))
            {
                this.int_7 = reader.ReadInt(BookmarkStart.b("昵儷夹䠻䬽㈿❁ᑃ⽅⩇", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 3;
            base.WriteXmlAttributes(writer);
            if (!this.bool_10)
            {
                writer.WriteValue(BookmarkStart.b("礨䈪丬嬮䐰䄲倴怶堸䠺唼倾㑀㝂", num), this.bool_10);
            }
            if (this.int_7 != -1)
            {
                writer.WriteValue(BookmarkStart.b("礨䈪丬嬮䐰䄲倴朶倸夺", num), this.int_7);
            }
        }

        public bool IsWashout
        {
            get
            {
                return this.bool_10;
            }
            set
            {
                this.bool_10 = value;
            }
        }

        internal int OriginalPib
        {
            get
            {
                return this.int_7;
            }
            set
            {
                this.int_7 = value;
            }
        }

        public Image Picture
        {
            get
            {
                return this.docPicture_0.Image;
            }
            set
            {
                this.int_7 = -1;
                this.docPicture_0.LoadImage(value);
            }
        }

        public float Scaling
        {
            get
            {
                return this.docPicture_0.HeightScale;
            }
            set
            {
                this.bool_11 = false;
                this.docPicture_0.HeightScale = this.docPicture_0.WidthScale = value;
            }
        }

        internal bool ScalingAuto
        {
            get
            {
                return this.bool_11;
            }
            set
            {
                this.bool_11 = value;
            }
        }

        internal DocPicture WordPicture
        {
            get
            {
                return this.docPicture_0;
            }
            set
            {
                this.docPicture_0 = value;
            }
        }
    }
}

