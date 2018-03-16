namespace Spire.Doc
{
    using Spire.Doc.Core.DataStreamParser.Escher;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Fields.Shape;
    using Spire.Doc.Interface;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    public class Background : DocumentSerializable, Interface0
    {
        private BackgroundGradient backgroundGradient_0;
        private BackgroundType backgroundType_0;
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private byte[] byte_1;
        private byte[] byte_2;
        private byte[] byte_3;
        private Class43 class43_0;
        private Class517 class517_0;
        private System.Drawing.Color color_0;
        private System.Drawing.Color color_1;
        private float float_0;
        private System.Drawing.Image image_0;
        private Stream stream_0;
        private Stream stream_1;

        internal Background(Document A_0) : base(A_0, null)
        {
            this.color_0 = System.Drawing.Color.White;
            this.color_1 = System.Drawing.Color.White;
            this.float_0 = 1f;
            this.class43_0 = new Class43();
            this.backgroundGradient_0 = new BackgroundGradient(this);
        }

        internal Background(BackgroundType A_0) : base(null, null)
        {
            this.color_0 = System.Drawing.Color.White;
            this.color_1 = System.Drawing.Color.White;
            this.float_0 = 1f;
            this.class43_0 = new Class43();
            this.backgroundGradient_0 = new BackgroundGradient(this);
            this.Type = A_0;
        }

        internal Background(Document A_0, ShapeBase A_1) : base(A_0, null)
        {
            this.color_0 = System.Drawing.Color.White;
            this.color_1 = System.Drawing.Color.White;
            this.float_0 = 1f;
            this.class43_0 = new Class43();
            this.class43_0 = A_1.ShapePr;
            this.backgroundGradient_0 = new BackgroundGradient(this);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public object GetDirectShapeAttribute(int key)
        {
            return this.class43_0.method_31(key);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public object GetInheritedShapeAttribute(int key)
        {
            Class43 class2 = Class565.smethod_1(this.ShapeType);
            if (class2 != null)
            {
                return class2.method_32(key);
            }
            return Class43.smethod_5(key);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public object GetShapeAttribute(int key)
        {
            object directShapeAttribute = this.GetDirectShapeAttribute(key);
            if (directShapeAttribute == null)
            {
                return this.GetInheritedShapeAttribute(key);
            }
            return directShapeAttribute;
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䰪弬丮唰娲倴夶䴸", 5), this.backgroundGradient_0);
        }

        private void method_10(Metafile A_0)
        {
            int num = 5;
            Rectangle bounds = A_0.GetMetafileHeader().Bounds;
            Bitmap image = null;
            try
            {
                image = new Bitmap(bounds.Width, bounds.Height, A_0.PixelFormat);
            }
            catch
            {
                throw new ArgumentException(BookmarkStart.b("截嬬丮崰娲儴᜶吸帺䤼帾❀⩂⥄≆楈ⵊ≌㵎㱐㉒⅔睖", num));
            }
            Graphics graphics = Graphics.FromImage(image);
            IntPtr hdc = graphics.GetHdc();
            MemoryStream stream = new MemoryStream();
            Metafile metafile = new Metafile(stream, hdc, EmfType.EmfOnly);
            graphics.ReleaseHdc(hdc);
            Graphics graphics2 = Graphics.FromImage(metafile);
            graphics2.DrawImageUnscaled(A_0, bounds);
            graphics2.Dispose();
            metafile.Dispose();
            this.ImageBytes = stream.ToArray();
            stream.Close();
        }

        private void method_11(System.Drawing.Image A_0)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    A_0.Save(stream, A_0.RawFormat);
                }
                catch
                {
                    A_0.Save(stream, ImageFormat.Png);
                }
                this.ImageBytes = stream.ToArray();
            }
        }

        internal Background method_5()
        {
            Background background;
            return new Background(this.Type) { class43_0 = this.class43_0.Clone() as Class43, backgroundGradient_0 = new BackgroundGradient(background) };
        }

        internal void method_6(Document A_0)
        {
            if (this.class517_0 != null)
            {
                Class517 class2 = this.class517_0;
                if (class2.method_7())
                {
                    this.class517_0 = A_0.Images.method_6(class2.byte_1, true);
                }
                else
                {
                    this.class517_0 = A_0.Images.method_5(class2.method_3());
                }
                this.class517_0.method_10(class2.method_9());
                this.class517_0.method_12(class2.method_11());
                this.class517_0.method_14(class2.method_13());
                class2.method_17();
                class2 = null;
            }
        }

        internal void method_7()
        {
            if ((this.Type != BackgroundType.NoBackground) && (base.OwnerBase is Document))
            {
                (base.OwnerBase as Document).ViewSetup.DisplayBackgroundShape = true;
            }
        }

        private System.Drawing.Image method_8()
        {
            int num = 0x13;
            if (this.ImageBytes != null)
            {
                MemoryStream stream = new MemoryStream(this.ImageBytes);
                try
                {
                    this.image_0 = System.Drawing.Image.FromStream(stream, true, false);
                }
                catch
                {
                    throw new ArgumentException(BookmarkStart.b("砸䤺娼䨾ⱀ♂⭄㍆楈≊㹌潎㽐㱒⅔睖じ㙚㱜㡞Ѡ䍢ݤṦᵨ๪䵬๮ͰŲᑴ๶", num));
                }
            }
            return this.image_0;
        }

        private void method_9(System.Drawing.Image A_0)
        {
            int num = 5;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䈪䀬丮嘰嘲", num));
            }
            if (A_0 is Metafile)
            {
                this.class517_0 = base.Document.Images.method_6(DocPicture.smethod_3(A_0 as Metafile), false);
            }
            else
            {
                this.class517_0 = base.Document.Images.method_5(DocPicture.smethod_4(A_0));
            }
            this.class517_0.method_18(A_0);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 9;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("笮䠰䌲倴", 9)))
            {
                this.backgroundType_0 = (BackgroundType) reader.ReadEnum(BookmarkStart.b("笮䠰䌲倴", num), typeof(BackgroundType));
            }
            if (reader.HasAttribute(BookmarkStart.b("昮䈰縲倴䌶堸崺吼匾⑀", num)))
            {
                this.bool_0 = reader.ReadBoolean(BookmarkStart.b("昮䈰縲倴䌶堸崺吼匾⑀", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("椮堰弲头琶嘸场刼䴾", num)))
            {
                this.color_0 = reader.ReadColor(BookmarkStart.b("椮堰弲头琶嘸场刼䴾", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("椮堰弲头甶堸堺嘼堾㍀ⱂい⥆ⵈࡊ≌⍎㹐⅒", num)))
            {
                this.color_1 = reader.ReadColor(BookmarkStart.b("椮堰弲头甶堸堺嘼堾㍀ⱂい⥆ⵈࡊ≌⍎㹐⅒", num));
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            bool flag = base.ReadXmlContent(reader);
            if (reader.TagName == BookmarkStart.b("夯弱唳儵崷", 10))
            {
                this.byte_2 = reader.ReadChildBinaryElement();
            }
            return flag;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveShapeAttribute(int key)
        {
            this.class43_0.Remove(key);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetShapeAttr(int key, object value)
        {
            this.class43_0.SetAttr(key, value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetShapeAttribute(int key, object value)
        {
            this.class43_0.SetAttr(key, value);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 2;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("簧匩尫䬭", 2), this.backgroundType_0);
            if (this.bool_0)
            {
                writer.WriteValue(BookmarkStart.b("愧天愫䬭䐯匱刳張吷弹", num), this.bool_0);
            }
            if (this.color_0 != System.Drawing.Color.White)
            {
                writer.WriteValue(BookmarkStart.b("渧䌩䀫䈭猯崱堳夵䨷", num), this.color_0);
            }
            if (this.color_1 != System.Drawing.Color.White)
            {
                writer.WriteValue(BookmarkStart.b("渧䌩䀫䈭爯匱圳崵強䠹医䬽⸿♁݃⥅⑇╉㹋", num), this.color_1);
            }
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 0x10;
            base.WriteXmlContent(writer);
            if (this.ImageBytes != null)
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("張唷嬹嬻嬽", num), this.ImageBytes);
            }
            else
            {
                (writer as Class669).method_4(this.image_0);
            }
        }

        public System.Drawing.Color Color
        {
            get
            {
                return this.backgroundGradient_0.Color1;
            }
            set
            {
                this.backgroundGradient_0.Color1 = value;
            }
        }

        internal string FillBlipName
        {
            get
            {
                return this.Gradient.FillBlipName;
            }
            set
            {
                this.Gradient.FillBlipName = value;
            }
        }

        internal BackgroundFillType FillType
        {
            get
            {
                return (BackgroundFillType) this.backgroundGradient_0.FillType;
            }
            set
            {
                this.backgroundGradient_0.FillType = (Spire.Doc.Fields.Shape.FillType) value;
            }
        }

        public BackgroundGradient Gradient
        {
            get
            {
                return this.backgroundGradient_0;
            }
            internal set
            {
                this.backgroundGradient_0 = value;
            }
        }

        internal System.Drawing.Image Image
        {
            get
            {
                if (this.image_0 == null)
                {
                    this.image_0 = this.method_8();
                }
                return this.image_0;
            }
        }

        internal byte[] ImageBytes
        {
            get
            {
                if ((this.backgroundGradient_0.ImageBytes == null) && (this.ImageRecord != null))
                {
                    return this.ImageRecord.method_3();
                }
                return this.backgroundGradient_0.ImageBytes;
            }
            set
            {
                this.backgroundGradient_0.method_0(value);
                this.method_7();
            }
        }

        internal Class517 ImageRecord
        {
            get
            {
                if ((this.class517_0 == null) && (this.backgroundGradient_0.ImageBytes != null))
                {
                    this.class517_0 = new Class517(this.backgroundGradient_0.ImageBytes);
                }
                return this.class517_0;
            }
            set
            {
                if (this.class517_0 != null)
                {
                    this.class517_0.method_6(this.class517_0.method_5() - 1);
                }
                this.class517_0 = value;
                this.class517_0.method_6(this.class517_0.method_5() + 1);
            }
        }

        internal float Opacity
        {
            get
            {
                return (float) this.backgroundGradient_0.Opacity;
            }
            set
            {
                this.backgroundGradient_0.Opacity = value;
            }
        }

        internal Stream PatternFill
        {
            get
            {
                return this.stream_1;
            }
            set
            {
                this.stream_1 = value;
            }
        }

        internal Stream PatternFill2010
        {
            get
            {
                return this.stream_0;
            }
            set
            {
                this.stream_0 = value;
            }
        }

        internal byte[] PatternImageBytes
        {
            get
            {
                return this.byte_3;
            }
            set
            {
                this.byte_3 = value;
            }
        }

        public System.Drawing.Image Picture
        {
            get
            {
                if (this.image_0 == null)
                {
                    return this.method_8();
                }
                return this.image_0;
            }
            set
            {
                this.FillType = BackgroundFillType.msofillPicture;
                this.method_9(value);
                this.backgroundGradient_0.method_0(this.class517_0.method_3());
                this.class517_0 = null;
            }
        }

        internal System.Drawing.Color PictureBackColor
        {
            get
            {
                return this.color_1;
            }
        }

        internal bool Recolor
        {
            get
            {
                return (bool) this.ShapePr.method_32(0x1b9);
            }
            set
            {
                this.ShapePr.SetAttr(0x1b9, value);
            }
        }

        internal bool Rotate
        {
            get
            {
                return (bool) this.ShapePr.method_32(0x1ba);
            }
            set
            {
                this.ShapePr.SetAttr(0x1ba, value);
            }
        }

        internal Class43 ShapePr
        {
            get
            {
                return this.class43_0;
            }
            set
            {
                this.class43_0 = value;
            }
        }

        internal Spire.Doc.Documents.ShapeType ShapeType
        {
            get
            {
                return (Spire.Doc.Documents.ShapeType) this.class43_0.method_32(0x103b);
            }
        }

        public BackgroundType Type
        {
            get
            {
                if (!this.ShapePr.HasKey(0x180) && (!this.ShapePr.HasKey(0x1bb) || !((bool) this.ShapePr[0x1bb])))
                {
                    if ((!this.ShapePr.HasKey(0x180) && (!this.ShapePr.HasKey(0x1bb) || ((bool) this.ShapePr[0x1bb]))) && (this.ShapePr.HasKey(0x181) && !this.Color.IsEmpty))
                    {
                        this.backgroundType_0 = BackgroundType.Color;
                    }
                }
                else
                {
                    switch (this.FillType)
                    {
                        case BackgroundFillType.msofillSolid:
                            this.backgroundType_0 = BackgroundType.Color;
                            goto Label_010A;

                        case BackgroundFillType.msofillPattern:
                        case BackgroundFillType.msofillTexture:
                            this.backgroundType_0 = BackgroundType.Texture;
                            goto Label_010A;

                        case BackgroundFillType.msofillPicture:
                            this.backgroundType_0 = BackgroundType.Picture;
                            goto Label_010A;

                        case BackgroundFillType.msofillShade:
                        case BackgroundFillType.msofillShadeTitle:
                        case BackgroundFillType.msofillBackground:
                            goto Label_010A;

                        case BackgroundFillType.msofillShadeCenter:
                        case BackgroundFillType.msofillShadeShape:
                        case BackgroundFillType.msofillShadeScale:
                            this.backgroundType_0 = BackgroundType.Gradient;
                            goto Label_010A;
                    }
                    this.backgroundType_0 = BackgroundType.NoBackground;
                }
            Label_010A:
                return this.backgroundType_0;
            }
            set
            {
                switch (value)
                {
                    case BackgroundType.Gradient:
                        switch (this.Gradient.ShadingStyle)
                        {
                            case GradientShadingStyle.Horizontal:
                            case GradientShadingStyle.Vertical:
                            case GradientShadingStyle.DiagonalUp:
                            case GradientShadingStyle.DiagonalDown:
                                this.FillType = BackgroundFillType.msofillShadeScale;
                                goto Label_008C;

                            case GradientShadingStyle.FromCorner:
                                this.FillType = BackgroundFillType.msofillShadeCenter;
                                goto Label_008C;

                            case GradientShadingStyle.FromCenter:
                                this.FillType = BackgroundFillType.msofillShadeShape;
                                goto Label_008C;
                        }
                        break;

                    case BackgroundType.Picture:
                        this.FillType = BackgroundFillType.msofillPicture;
                        break;

                    case BackgroundType.Texture:
                        this.FillType = BackgroundFillType.msofillTexture;
                        break;

                    case BackgroundType.Color:
                        this.FillType = BackgroundFillType.msofillSolid;
                        break;

                    default:
                        this.ShapePr.Remove(0x180);
                        break;
                }
            Label_008C:
                this.backgroundType_0 = value;
                this.method_7();
            }
        }
    }
}

