namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Runtime.CompilerServices;

    public class DocPicture : ShapeObject, Interface2, IPicture
    {
        private Body body_0;
        private bool bool_11;
        private bool bool_12;
        private bool bool_13;
        private bool bool_14;
        private bool bool_15;
        private bool bool_16;
        private bool[] bool_17;
        private bool bool_18;
        [CompilerGenerated]
        private bool bool_19;
        private Spire.Doc.Documents.Borders borders_0;
        private byte[] byte_5;
        private Class517 class517_0;
        private System.Drawing.Color color_0;
        private DocOleObject docOleObject_1;
        internal DocumentObject documentObject_1;
        private float float_10;
        private float float_11;
        private float float_12;
        private float float_13;
        private float float_14;
        private float float_15;
        private float float_16;
        private float float_17;
        private float float_18;
        private float float_19;
        private float float_20;
        private float float_21;
        private float float_22;
        private float float_23;
        private float float_24;
        private float float_25;
        private float float_26;
        private float float_3;
        private float float_4;
        private float float_5;
        private float float_6;
        private float float_7;
        private float float_8;
        private float float_9;
        private Spire.Doc.Documents.HorizontalOrigin horizontalOrigin_0;
        private Spire.Doc.Documents.HorizontalOrigin horizontalOrigin_1;
        private int int_10;
        internal const int int_8 = 300;
        private int int_9;
        private List<Stream> list_0;
        private List<PointF> list_1;
        internal const long long_6 = 0xa00000L;
        private long long_7;
        private long[] long_8;
        private PictureColor pictureColor_0;
        private RectangleF rectangleF_0;
        private ShapeHorizontalAlignment shapeHorizontalAlignment_0;
        private ShapeObject shapeObject_0;
        [CompilerGenerated]
        private ShapeObject shapeObject_1;
        private ShapeVerticalAlignment shapeVerticalAlignment_0;
        private string string_10;
        private string string_11;
        private string string_8;
        private string string_9;
        private Spire.Doc.Documents.TextWrappingStyle textWrappingStyle_0;
        private Spire.Doc.Documents.TextWrappingType textWrappingType_0;
        private Spire.Doc.Documents.VerticalOrigin verticalOrigin_0;
        private Spire.Doc.Documents.VerticalOrigin verticalOrigin_1;

        public DocPicture(IDocument doc) : base((Document) doc)
        {
            this.float_3 = 100f;
            this.float_4 = 100f;
            this.bool_14 = true;
            this.bool_15 = true;
            this.float_9 = 9f;
            this.float_10 = 9f;
            this.bool_16 = true;
            this.float_17 = float.MinValue;
            this.float_18 = float.MinValue;
            this.bool_18 = true;
            this.int_10 = 0xff;
            this.float_21 = 100f;
            this.string_11 = string.Empty;
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(doc);
            base.m_charFormat.method_0(this);
            base.SetShapeType(ShapeType.Image);
            base.TextWrappingStyle = Spire.Doc.Documents.TextWrappingStyle.Inline;
            base.ImageData = this;
        }

        internal DocPicture(IDocument A_0, ShapeObject A_1) : base((Document) A_0)
        {
            this.float_3 = 100f;
            this.float_4 = 100f;
            this.bool_14 = true;
            this.bool_15 = true;
            this.float_9 = 9f;
            this.float_10 = 9f;
            this.bool_16 = true;
            this.float_17 = float.MinValue;
            this.float_18 = float.MinValue;
            this.bool_18 = true;
            this.int_10 = 0xff;
            this.float_21 = 100f;
            this.string_11 = string.Empty;
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(A_0);
            base.m_charFormat.method_0(this);
            base.ShapePr = A_1.ShapePr;
            base.ImageData = this;
        }

        public IParagraph AddCaption(string name, CaptionNumberingFormat format, CaptionPosition captionPosition)
        {
            int num = 4;
            Body owner = base.OwnerParagraph.Owner as Body;
            Paragraph paragraph = null;
            if (owner != null)
            {
                int index = owner.Paragraphs.IndexOf(base.OwnerParagraph);
                paragraph = new Paragraph(base.Document);
                paragraph.AppendText(name + BookmarkStart.b("਩", num));
                name = name.Replace(BookmarkStart.b("਩", num), BookmarkStart.b("甩", num));
                name = string.IsNullOrEmpty(name.Trim()) ? BookmarkStart.b("氩䔫䤭䔯䀱儳", num) : name;
                SequenceField field = (SequenceField) paragraph.AppendField(name, FieldType.FieldSequence);
                field.CaptionName = name;
                field.NumberFormat = format;
                int num4 = base.OwnerParagraph.Items.IndexOf(this);
                if (captionPosition == CaptionPosition.AboveImage)
                {
                    paragraph.Format.KeepFollow = true;
                    int num3 = (num4 == 0) ? index : (index + 1);
                    owner.Paragraphs.Insert(num3, paragraph);
                    if (num4 > 0)
                    {
                        base.OwnerParagraph.Items.RemoveAt(num4);
                        Paragraph paragraph2 = new Paragraph(base.Document);
                        paragraph2.Items.Insert(0, this);
                        owner.Paragraphs.Insert(num3 + 1, paragraph2);
                    }
                    return paragraph;
                }
                base.OwnerParagraph.Format.KeepFollow = true;
                owner.Paragraphs.Insert(index + 1, paragraph);
            }
            return paragraph;
        }

        protected override object CloneImpl()
        {
            DocPicture picture = (DocPicture) base.CloneImpl();
            picture.ImageData = picture;
            if (picture.ImageRecord == null)
            {
                return null;
            }
            picture.class517_0 = null;
            picture.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            picture.m_charFormat.ImportContainer(base.m_charFormat);
            picture.bool_4 = true;
            return picture;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            if (((nextOwner.OwnerBase != null) && (nextOwner.OwnerBase is HeaderFooter)) || (nextOwner is HeaderFooter))
            {
                this.IsHeaderPicture = true;
            }
            base.Document.method_157(doc, this);
            base.bool_4 = false;
        }

        internal override void Close()
        {
            base.Close();
            if ((this.class517_0 != null) && !base.DeepDetached)
            {
                this.class517_0.method_6(this.class517_0.method_5() - 1);
            }
            if (this.body_0 != null)
            {
                this.body_0.method_28();
                this.body_0 = null;
            }
            if (this.docOleObject_1 != null)
            {
                this.docOleObject_1.Close();
                this.docOleObject_1 = null;
            }
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_39(this.AllowOverlap);
            if (base.PreviousSibling is DocOleObject)
            {
                base.interface23_0.imethod_5(true);
            }
            if ((this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.InFrontOfText) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Behind))
            {
                if (this.method_106().IsInCell && (((Interface1) this.method_106()).imethod_0().imethod_2() || (this.method_106().OwnerBase as TableCell).IsFixedWidth))
                {
                    base.interface23_0.imethod_3(true);
                }
            }
            else
            {
                base.interface23_0.imethod_3(false);
            }
            if (this.method_106().IsInCell && ((this.method_106().OwnerTextBody as TableCell).CellFormat.TextDirection != TextDirection.TopToBottom))
            {
                base.interface23_0.imethod_31(true);
            }
            if (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Inline)
            {
                base.interface23_0.imethod_13(true);
            }
            Spire.Doc.Documents.TextWrappingStyle textWrappingStyle = this.TextWrappingStyle;
            if (textWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Inline)
            {
                if ((textWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.InFrontOfText) && (textWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Behind))
                {
                    base.interface23_0.imethod_19(true);
                    base.interface23_0.imethod_17(false);
                }
                else
                {
                    base.interface23_0.imethod_21(true);
                    base.interface23_0.imethod_17(false);
                }
            }
            else
            {
                base.interface23_0.imethod_15(true);
            }
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("倲崴嘶䬸娺帼䬾⑀ㅂ桄ⅆ♈㥊⁌⹎═", 13), base.m_charFormat);
        }

        public void LoadImage(System.Drawing.Image image)
        {
            this.method_84(image, true);
        }

        public void LoadImage(byte[] imageBytes)
        {
            int num = 4;
            if (imageBytes == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("挩䄫伭圯圱ᐳ吵䄷丹夻䴽怿⅁╃⡅♇╉㡋湍㉏㝑瑓㡕ⵗ㙙せ繝ཟၡ䑣ͥէᩩᡫ᝭", num));
            }
            this.method_105();
            System.Drawing.Image image = this.method_90(imageBytes);
            if (image is Metafile)
            {
                this.method_85(imageBytes, true);
            }
            else if ((this.Image != null) && (this.Image.RawFormat.Equals(ImageFormat.Tiff) || this.Image.RawFormat.Equals(ImageFormat.Bmp)))
            {
                this.method_104(this.Image);
            }
            else
            {
                this.method_85(imageBytes, false);
            }
            base.SetShapeAttribute(0x1006, imageBytes);
            imageBytes = null;
            this.method_108(image);
        }

        private Bitmap method_100(System.Drawing.Image A_0, SizeF A_1)
        {
            Bitmap bitmap;
            int width = (int) A_1.Width;
            float num2 = ((float) width) / A_1.Height;
            float num3 = ((float) width) / A_1.Width;
            int num4 = (int) (A_0.Size.Width * num3);
            int num5 = (int) (A_0.Size.Height * num2);
            if (width < 150)
            {
                int num6 = 150 / width;
                num6 = (((150 % width) == 0) || ((num6 % 2) == 0)) ? num6 : (num6 + 1);
                width *= num6;
                num2 = ((float) width) / A_1.Height;
                num3 = ((float) width) / A_1.Width;
                num4 = (int) (A_0.Size.Width * num3);
                num5 = (int) (A_0.Size.Height * num2);
            }
            if (!this.method_101(num4, num5))
            {
                goto Label_011B;
            }
            width = 300;
        Label_00CF:
            num2 = ((float) width) / A_1.Height;
            num3 = ((float) width) / A_1.Width;
            num4 = (int) (A_0.Size.Width * num3);
            num5 = (int) (A_0.Size.Height * num2);
            if (this.method_101(num4, num5))
            {
                width /= 2;
                goto Label_00CF;
            }
        Label_011B:
            bitmap = new Bitmap(num4, num5);
            bitmap.SetResolution((float) width, (float) width);
            using (Graphics graphics = this.method_102(bitmap))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(A_0, 0, 0);
                A_0.Dispose();
            }
            return bitmap;
        }

        internal bool method_101(int A_0, int A_1)
        {
            long num = A_0 * A_1;
            return (num > 0xa00000L);
        }

        private Graphics method_102(System.Drawing.Image A_0)
        {
            return Graphics.FromImage(A_0);
        }

        internal void method_103(byte[] A_0, byte[] A_1, bool A_2, bool A_3)
        {
            int num = 10;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("夯弱唳儵崷", num));
            }
            if (A_3)
            {
                this.class517_0 = base.Document.Images.method_6(A_0, false);
            }
            else
            {
                this.class517_0 = base.Document.Images.method_5(A_0);
            }
            A_0 = null;
            base.RemoveShapeAttribute(0x1023);
            base.RemoveShapeAttribute(0x1024);
        }

        private void method_104(System.Drawing.Image A_0)
        {
            if (this.class517_0 != null)
            {
                this.class517_0.method_6(this.class517_0.method_5() - 1);
                this.class517_0 = null;
            }
            this.class517_0 = base.Document.Images.method_5(smethod_4(A_0));
        }

        private void method_105()
        {
            if (this.class517_0 != null)
            {
                this.class517_0.method_6(this.class517_0.method_5() - 1);
                this.class517_0 = null;
            }
            base.RemoveShapeAttribute(0x1023);
            base.RemoveShapeAttribute(0x1024);
        }

        internal Paragraph method_106()
        {
            Paragraph ownerParagraph = base.OwnerParagraph;
            if (ownerParagraph == null)
            {
                for (DocumentObject obj2 = base.Owner; obj2 != null; obj2 = obj2.Owner)
                {
                    if (obj2 is Paragraph)
                    {
                        return (obj2 as Paragraph);
                    }
                }
            }
            return ownerParagraph;
        }

        internal SizeF method_107(System.Drawing.Image A_0)
        {
            int num = 2;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䄧䜩䴫䤭唯", num));
            }
            SizeF size = (SizeF) A_0.Size;
            this.class517_0.method_10(A_0.Size);
            this.class517_0.method_12(A_0.RawFormat);
            if (((((A_0.PixelFormat != PixelFormat.Format8bppIndexed) && (A_0.PixelFormat != PixelFormat.Format4bppIndexed)) && (A_0.PixelFormat != PixelFormat.Format1bppIndexed)) && (!(A_0 is Metafile) || (A_0.PixelFormat != PixelFormat.Format32bppRgb))) && Enum.IsDefined(typeof(PixelFormat), A_0.PixelFormat))
            {
                using (Graphics graphics = Graphics.FromImage(A_0))
                {
                    using (Class1073 class2 = new Class1073(graphics))
                    {
                        return class2.method_11(A_0.Size, PrintUnits.Point);
                    }
                }
            }
            using (Class1073 class3 = new Class1073())
            {
                return class3.method_18((SizeF) A_0.Size, PrintUnits.Point, (float) Math.Round((double) A_0.HorizontalResolution), (float) Math.Round((double) A_0.VerticalResolution));
            }
        }

        private void method_108(System.Drawing.Image A_0)
        {
            if ((A_0 != null) && (!base.ShapePr.HasKey(0x1023) || !base.ShapePr.HasKey(0x1024)))
            {
                SizeF ef = this.method_107(A_0);
                base.Height = ef.Height;
                base.Width = ef.Width;
            }
        }

        internal void method_109()
        {
            this.Width = (this.Width * this.WidthScale) / 100f;
            this.Height = (this.Height * this.HeightScale) / 100f;
        }

        private Rectangle method_110(RectangleF A_0)
        {
            double num = A_0.Left + (A_0.Width * this.CropFromLeft);
            double num2 = A_0.Left + (A_0.Width * (1f - this.CropFromRight));
            double num3 = A_0.Top + (A_0.Height * this.CropFromTop);
            double num4 = A_0.Top + (A_0.Height * (1f - this.CropFromBottom));
            return Rectangle.FromLTRB((int) num, (int) num3, (int) num2, (int) num4);
        }

        private object method_75(int A_0)
        {
            return base.GetShapeAttribute(A_0);
        }

        private float method_76(int A_0)
        {
            return Class969.smethod_69((int) this.method_75(A_0));
        }

        internal Class915 method_77()
        {
            return new Class915((double) this.CropFromLeft, (double) this.CropFromRight, (double) this.CropFromTop, (double) this.CropFromBottom);
        }

        private void method_78(int A_0, float A_1)
        {
            int num = 10;
            if ((A_1 < -1f) || (A_1 > 1f))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䘯匱堳䌵崷", num));
            }
            this.method_79(A_0, Class969.smethod_70(A_1));
        }

        private void method_79(int A_0, object A_1)
        {
            base.SetShapeAttribute(A_0, A_1);
        }

        internal void method_80(float A_0)
        {
            this.float_4 = A_0;
        }

        internal void method_81(float A_0)
        {
            this.float_3 = A_0;
        }

        private Body method_82()
        {
            if (this.docOleObject_1 == null)
            {
                return null;
            }
            TextBox box = new TextBox(base.Document);
            Paragraph paragraph = box.Body.AddParagraph();
            DocOleObject entity = (DocOleObject) this.docOleObject_1.Clone();
            Field field = entity.Field;
            paragraph.Items.Add(entity);
            FieldMark mark = new FieldMark(base.m_doc) {
                Type = FieldMarkType.FieldSeparator
            };
            paragraph.Items.Add(mark);
            field.Separator = mark;
            DocPicture picture = entity.Interface49.get_OlePicture();
            picture.TextWrappingStyle = Spire.Doc.Documents.TextWrappingStyle.Inline;
            picture.VerticalOrigin = Spire.Doc.Documents.VerticalOrigin.Margin;
            picture.HorizontalOrigin = Spire.Doc.Documents.HorizontalOrigin.Margin;
            paragraph.Items.Add(picture);
            FieldMark mark2 = new FieldMark(base.m_doc) {
                Type = FieldMarkType.FieldEnd
            };
            paragraph.Items.Add(mark2);
            field.End = mark2;
            return box.Body;
        }

        private DocOleObject method_83()
        {
            if (this.body_0 != null)
            {
                foreach (DocumentObject obj2 in this.body_0.ChildObjects)
                {
                    if (obj2 is Paragraph)
                    {
                        using (IEnumerator enumerator2 = (obj2 as Paragraph).Items.GetEnumerator())
                        {
                            DocumentObject current;
                            while (enumerator2.MoveNext())
                            {
                                current = (DocumentObject) enumerator2.Current;
                                if (current is DocOleObject)
                                {
                                    goto Label_0065;
                                }
                            }
                            continue;
                        Label_0065:
                            current.method_0(base.Owner);
                            return (current as DocOleObject);
                        }
                    }
                }
            }
            return null;
        }

        internal void method_84(System.Drawing.Image A_0, bool A_1)
        {
            int num = 6;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䔫䌭儯唱儳", num));
            }
            this.method_105();
            if (A_0 is Metafile)
            {
                this.class517_0 = base.Document.Images.method_6(smethod_3(A_0 as Metafile), false);
            }
            else if ((!A_0.RawFormat.Equals(ImageFormat.Tiff) && !A_0.RawFormat.Equals(ImageFormat.Bmp)) && !(A_0 is Metafile))
            {
                if (base.Document == null)
                {
                    this.class517_0 = new Class517(smethod_4(A_0));
                }
                else
                {
                    this.class517_0 = base.Document.Images.method_5(smethod_4(A_0));
                }
            }
            else
            {
                this.method_104(A_0);
            }
            this.method_108(A_0);
            base.SetShapeAttribute(0x1006, this.class517_0.method_3());
        }

        internal void method_85(byte[] A_0, bool A_1)
        {
            int num = 5;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䈪䀬丮嘰嘲", num));
            }
            base.SetShapeAttribute(0x1006, A_0);
            if (A_1)
            {
                this.class517_0 = base.Document.Images.method_6(A_0, false);
            }
            else
            {
                this.class517_0 = base.Document.Images.method_5(A_0);
            }
            A_0 = null;
            base.RemoveShapeAttribute(0x1023);
            base.RemoveShapeAttribute(0x1024);
        }

        internal void method_86(Class517 A_0)
        {
            this.class517_0 = A_0;
            base.SetShapeAttribute(0x1006, A_0.method_3());
            this.Size = new SizeF((float) this.class517_0.method_9().Width, (float) this.class517_0.method_9().Height);
        }

        internal void method_87(byte[] A_0)
        {
            this.method_88(A_0, false);
        }

        internal void method_88(byte[] A_0, bool A_1)
        {
            base.SetShapeAttribute(0x1006, A_0);
            this.class517_0 = new Class517(A_0);
            if (this.LockAspectRatio)
            {
                SizeF ef = this.method_107(this.Image);
                float num = this.Size.Width / ef.Width;
                float num2 = this.Size.Height / ef.Height;
                if (A_1)
                {
                    float num3 = Math.Min(num, num2);
                    this.Size = new SizeF(ef.Width * num3, ef.Height * num3);
                }
                else
                {
                    this.Size = new SizeF(ef.Width * num, ef.Height * num2);
                }
            }
        }

        internal void method_89(System.Drawing.Image A_0)
        {
            this.method_88(smethod_4(A_0), true);
        }

        private System.Drawing.Image method_90(byte[] A_0)
        {
            System.Drawing.Image image = null;
            if (A_0 != null)
            {
                Class777.ImageType none = Class777.ImageType.None;
                try
                {
                    none = Class777.smethod_3(A_0);
                    if ((((none == Class777.ImageType.None) && (A_0.Length > 4)) && ((A_0[0] == 1) && (A_0[1] == 0))) && ((A_0[2] == 9) && (A_0[3] == 0)))
                    {
                        byte[] destinationArray = new byte[0x16 + A_0.Length];
                        byte[] buffer2 = new byte[0x16];
                        buffer2[0] = 0xd7;
                        buffer2[1] = 0xcd;
                        buffer2[2] = 0xc6;
                        buffer2[3] = 0x9a;
                        byte[] bytes = BitConverter.GetBytes((ushort) this.Width);
                        Array.Copy(bytes, 0, buffer2, 10, bytes.Length);
                        byte[] sourceArray = BitConverter.GetBytes((ushort) this.Height);
                        Array.Copy(sourceArray, 0, buffer2, 12, sourceArray.Length);
                        byte[] buffer5 = BitConverter.GetBytes((ushort) 0x23);
                        Array.Copy(buffer5, 0, buffer2, 14, buffer5.Length);
                        Array.Copy(BitConverter.GetBytes(this.method_91(buffer2)), 0, buffer2, 20, buffer5.Length);
                        Array.Copy(buffer2, 0, destinationArray, 0, buffer2.Length);
                        Array.Copy(A_0, 0, destinationArray, 0x16, A_0.Length);
                        A_0 = destinationArray;
                    }
                    image = System.Drawing.Image.FromStream(new MemoryStream(A_0));
                    A_0 = null;
                }
                catch
                {
                    if (none == Class777.ImageType.GIF)
                    {
                        Class958 class2 = new Class958();
                        class2.method_9(new MemoryStream(A_0));
                        image = class2.method_2();
                        class2.method_14();
                        class2 = null;
                        A_0 = null;
                    }
                }
            }
            return image;
        }

        private ushort method_91(byte[] A_0)
        {
            if (A_0 == null)
            {
                return 0;
            }
            ushort num = BitConverter.ToUInt16(A_0, 0);
            for (int i = 2; i < 0x10; i += 2)
            {
                num = (ushort) (num ^ BitConverter.ToUInt16(A_0, i));
            }
            return num;
        }

        internal SizeF method_92()
        {
            float width = (this.Size.Width * this.WidthScale) / 100f;
            float num2 = (this.Size.Height * this.HeightScale) / 100f;
            if ((this.LockAspectRatio && (this.WidthScale != this.HeightScale)) && ((width > 1584f) || (num2 > 1584f)))
            {
                float num4 = Math.Min(this.WidthScale, this.HeightScale);
                width = (this.Size.Width * num4) / 100f;
                num2 = (this.Size.Height * num4) / 100f;
            }
            if ((this.WidthPercent > 0f) || (this.HeightPercent > 0f))
            {
                Section section = base.method_2();
                if (section != null)
                {
                    float num8 = section.PageSetup.PageSize.Width;
                    float height = section.PageSetup.PageSize.Height;
                    float clientWidth = section.PageSetup.ClientWidth;
                    float clientHeight = section.PageSetup.ClientHeight;
                    if (this.WidthPercent > 0f)
                    {
                        float num6 = 0f;
                        switch (this.RelationWidth)
                        {
                            case Spire.Doc.Documents.HorizontalOrigin.Margin:
                                num6 = (clientWidth * this.WidthPercent) / 100f;
                                break;

                            case Spire.Doc.Documents.HorizontalOrigin.Page:
                                num6 = (num8 * this.WidthPercent) / 100f;
                                break;
                        }
                        if ((num6 != 0f) && (num6 != width))
                        {
                            width = num6;
                        }
                    }
                    if (this.HeightPercent > 0f)
                    {
                        float num3 = 0f;
                        switch (this.RelationHeight)
                        {
                            case Spire.Doc.Documents.VerticalOrigin.Margin:
                                num3 = (clientHeight * this.HeightPercent) / 100f;
                                break;

                            case Spire.Doc.Documents.VerticalOrigin.Page:
                                num3 = (height * this.HeightPercent) / 100f;
                                break;
                        }
                        if ((num3 != 0f) && (num3 != num2))
                        {
                            num2 = num3;
                        }
                    }
                }
            }
            width = (width > 1584f) ? 1584f : width;
            return new SizeF(width, (num2 > 1584f) ? 1584f : num2);
        }

        internal System.Drawing.Image method_93(float A_0, float A_1)
        {
            System.Drawing.Image image2;
            int num = 4;
            System.Drawing.Image image = this.Image;
            string str = image.PixelFormat.ToString().ToLowerInvariant();
            float horizontalResolution = image.HorizontalResolution;
            if (image is Metafile)
            {
                image = this.method_94(image);
            }
            float num3 = 1f;
            if (((image != null) && ((image.Width > 0x1388) || (image.Height > 0x1388))) && !str.Contains(BookmarkStart.b("䌩䈫䨭唯䨱儳刵", num)))
            {
                num3 = Math.Min((float) (5000f / ((float) image.Width)), (float) (5000f / ((float) image.Height)));
                image = this.method_95(image, image.Width * num3, image.Height * num3);
            }
            else if (horizontalResolution != image.HorizontalResolution)
            {
                num3 = (float) Math.Round((double) (image.HorizontalResolution / horizontalResolution), 1);
            }
            if (((image != null) && (image is Bitmap)) && (image.PixelFormat == ((PixelFormat) 0x200f)))
            {
                Bitmap bitmap5 = image as Bitmap;
                try
                {
                    image = this.method_96(bitmap5);
                }
                catch (OutOfMemoryException)
                {
                    return new Bitmap(image);
                }
            }
            if (this.IsCrop && this.IsPositivelyCrop)
            {
                Bitmap bitmap = null;
                if (image is Bitmap)
                {
                    bitmap = image as Bitmap;
                    RectangleF cropRectangle = this.CropRectangle;
                    if ((num3 > 0f) && (num3 != 1.0))
                    {
                        cropRectangle = new RectangleF((float) ((int) (cropRectangle.X * num3)), (float) ((int) (cropRectangle.Y * num3)), (float) ((int) (cropRectangle.Width * num3)), (float) ((int) (cropRectangle.Height * num3)));
                    }
                    if (cropRectangle.Width > bitmap.Width)
                    {
                        cropRectangle.Width = bitmap.Width;
                    }
                    if (cropRectangle.Height > bitmap.Height)
                    {
                        cropRectangle.Height = bitmap.Height;
                    }
                    try
                    {
                        image = bitmap.Clone(cropRectangle, image.PixelFormat);
                        if (((image != null) && (image is Bitmap)) && (image.PixelFormat == PixelFormat.Format8bppIndexed))
                        {
                            try
                            {
                                Bitmap bitmap6 = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
                                bitmap6.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                                using (Graphics graphics4 = Graphics.FromImage(bitmap6))
                                {
                                    graphics4.DrawImageUnscaled(image, 0, 0);
                                    graphics4.Dispose();
                                }
                                image = bitmap6;
                            }
                            catch (OutOfMemoryException)
                            {
                                return new Bitmap(image);
                            }
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        return new Bitmap(image);
                    }
                }
            }
            System.Drawing.Color chromaKey = this.ChromaKey;
            if (!this.ChromaKey.IsEmpty)
            {
                try
                {
                    Bitmap bitmap2 = new Bitmap(image.Width, image.Height);
                    using (Graphics graphics = Graphics.FromImage(bitmap2))
                    {
                        int num4 = 0x18;
                        ImageAttributes imageAttr = new ImageAttributes();
                        System.Drawing.Color colorLow = System.Drawing.Color.FromArgb(0, ((this.ChromaKey.R - 0x18) < 0) ? 0 : (this.ChromaKey.R - num4), ((this.ChromaKey.G - num4) < 0) ? 0 : (this.ChromaKey.G - num4), ((this.ChromaKey.B - num4) < 0) ? 0 : (this.ChromaKey.B - num4));
                        System.Drawing.Color colorHigh = System.Drawing.Color.FromArgb(0, ((this.ChromaKey.R + num4) > 0xff) ? 0xff : (this.ChromaKey.R + num4), ((this.ChromaKey.G + num4) > 0xff) ? 0xff : (this.ChromaKey.G + num4), ((this.ChromaKey.B + num4) > 0xff) ? 0xff : (this.ChromaKey.B + num4));
                        imageAttr.SetColorKey(colorLow, colorHigh);
                        graphics.DrawImage(image, new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), 0, 0, bitmap2.Width, bitmap2.Height, GraphicsUnit.Pixel, imageAttr);
                        graphics.Dispose();
                        imageAttr.Dispose();
                    }
                    image = bitmap2;
                }
                catch (OutOfMemoryException)
                {
                    return new Bitmap(image);
                }
            }
            if ((this.AlphaModFix >= 0f) && (this.AlphaModFix < 100.0))
            {
                try
                {
                    float num7 = this.AlphaModFix / 100f;
                    ImageAttributes attributes3 = new ImageAttributes();
                    attributes3.ClearColorMatrix();
                    ColorMatrix newColorMatrix = new ColorMatrix {
                        Matrix33 = num7
                    };
                    attributes3.SetColorMatrix(newColorMatrix);
                    Bitmap bitmap4 = new Bitmap(image.Width, image.Height);
                    using (Graphics graphics3 = Graphics.FromImage(bitmap4))
                    {
                        graphics3.DrawImage(image, new Rectangle(0, 0, bitmap4.Width, bitmap4.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes3);
                        graphics3.Dispose();
                    }
                    attributes3.Dispose();
                    image = bitmap4;
                }
                catch (OutOfMemoryException)
                {
                    return new Bitmap(image);
                }
            }
            if ((this.Brightness != 0f) || (this.Contrast != 0f))
            {
                try
                {
                    float num5 = this.Brightness / 100f;
                    float num6 = (this.Contrast == 0f) ? 1f : (1f + (this.Contrast / 100f));
                    float[][] numArray5 = new float[5][];
                    float[] numArray6 = new float[5];
                    numArray6[0] = 1f;
                    numArray5[0] = numArray6;
                    float[] numArray7 = new float[5];
                    numArray7[1] = 1f;
                    numArray5[1] = numArray7;
                    float[] numArray8 = new float[5];
                    numArray8[2] = 1f;
                    numArray5[2] = numArray8;
                    float[] numArray9 = new float[5];
                    numArray9[3] = 1f;
                    numArray5[3] = numArray9;
                    float[] numArray10 = new float[5];
                    numArray10[0] = num5;
                    numArray10[1] = num5;
                    numArray10[2] = num5;
                    numArray10[4] = 1f;
                    numArray5[4] = numArray10;
                    float[][] numArray = numArray5;
                    float[][] numArray11 = new float[5][];
                    float[] numArray12 = new float[5];
                    numArray12[0] = num6;
                    numArray11[0] = numArray12;
                    float[] numArray13 = new float[5];
                    numArray13[1] = num6;
                    numArray11[1] = numArray13;
                    float[] numArray14 = new float[5];
                    numArray14[2] = num6;
                    numArray11[2] = numArray14;
                    float[] numArray15 = new float[5];
                    numArray15[3] = 1f;
                    numArray11[3] = numArray15;
                    float[] numArray16 = new float[5];
                    numArray16[4] = 1f;
                    numArray11[4] = numArray16;
                    float[][] numArray3 = numArray11;
                    float[][] numArray17 = new float[5][];
                    float[] numArray18 = new float[5];
                    numArray18[0] = num6;
                    numArray17[0] = numArray18;
                    float[] numArray19 = new float[5];
                    numArray19[1] = num6;
                    numArray17[1] = numArray19;
                    float[] numArray20 = new float[5];
                    numArray20[2] = num6;
                    numArray17[2] = numArray20;
                    float[] numArray21 = new float[5];
                    numArray21[3] = 1f;
                    numArray17[3] = numArray21;
                    float[] numArray22 = new float[5];
                    numArray22[0] = num5;
                    numArray22[1] = num5;
                    numArray22[2] = num5;
                    numArray22[4] = 1f;
                    numArray17[4] = numArray22;
                    float[][] numArray4 = numArray17;
                    float[][] numArray2 = ((this.Brightness == 0f) || (this.Contrast == 0f)) ? (((this.Brightness == 0f) || (this.Contrast != 0f)) ? numArray3 : numArray) : numArray4;
                    ImageAttributes attributes2 = new ImageAttributes();
                    attributes2.ClearColorMatrix();
                    attributes2.SetColorMatrix(new ColorMatrix(numArray2));
                    Bitmap bitmap3 = new Bitmap(image.Width, image.Height);
                    using (Graphics graphics2 = Graphics.FromImage(bitmap3))
                    {
                        graphics2.Clear(System.Drawing.Color.White);
                        graphics2.DrawImage(image, new Rectangle(0, 0, bitmap3.Width, bitmap3.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes2);
                        graphics2.Dispose();
                    }
                    attributes2.Dispose();
                    image = bitmap3;
                }
                catch (OutOfMemoryException)
                {
                    return new Bitmap(image);
                }
            }
            if (this.Color == PictureColor.Automatic)
            {
                return image;
            }
            try
            {
                switch (this.Color)
                {
                    case PictureColor.Grayscale:
                        return this.method_98(image);

                    case PictureColor.BlackAndWhite:
                        return this.method_97(image);

                    case PictureColor.Washout:
                        return this.method_99(image);
                }
                return image;
            }
            catch (OutOfMemoryException)
            {
                image2 = new Bitmap(image);
            }
            return image2;
        }

        private System.Drawing.Image method_94(System.Drawing.Image A_0)
        {
            if (A_0 == null)
            {
                return null;
            }
            return this.method_100(A_0, new SizeF(A_0.HorizontalResolution, A_0.VerticalResolution));
        }

        private System.Drawing.Image method_95(System.Drawing.Image A_0, float A_1, float A_2)
        {
            if ((A_0.Width <= A_1) && (A_0.Height <= A_2))
            {
                return A_0;
            }
            int width = A_0.Width;
            int height = A_0.Height;
            int x = 0;
            int y = 0;
            int num3 = 0;
            int num4 = 0;
            int num = (int) A_1;
            int num2 = (int) A_2;
            if (num <= 0)
            {
                num = 1;
            }
            if (num2 <= 0)
            {
                num2 = 1;
            }
            Bitmap image = new Bitmap(num, num2, PixelFormat.Format24bppRgb);
            image.SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.Clear(System.Drawing.Color.White);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(A_0, new Rectangle(num3, num4, num, num2), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                graphics.Dispose();
            }
            return image;
        }

        private Bitmap method_96(Bitmap A_0)
        {
            Bitmap image = new Bitmap(A_0.Width, A_0.Height, PixelFormat.Format24bppRgb);
            image.SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                Rectangle rect = new Rectangle(0, 0, A_0.Width, A_0.Height);
                graphics.DrawImage(A_0, rect);
            }
            A_0.Dispose();
            return image;
        }

        private System.Drawing.Image method_97(System.Drawing.Image A_0)
        {
            Bitmap image = new Bitmap(A_0.Width, A_0.Height);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.Clear(System.Drawing.Color.White);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                float[][] numArray = new float[5][];
                numArray[0] = new float[] { 0.299f, 0.299f, 0.299f, 0f, 0f };
                numArray[1] = new float[] { 0.587f, 0.587f, 0.587f, 0f, 0f };
                numArray[2] = new float[] { 0.114f, 0.114f, 0.114f, 0f, 0f };
                float[] numArray2 = new float[5];
                numArray2[3] = 1f;
                numArray[3] = numArray2;
                float[] numArray3 = new float[5];
                numArray3[4] = 1f;
                numArray[4] = numArray3;
                float[][] newColorMatrix = numArray;
                ColorMatrix matrix = new ColorMatrix(newColorMatrix);
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.ClearColorMatrix();
                imageAttr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                imageAttr.SetThreshold(0.5f, ColorAdjustType.Bitmap);
                graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width, A_0.Height), 0, 0, A_0.Width, A_0.Height, GraphicsUnit.Pixel, imageAttr);
                graphics.Dispose();
                imageAttr.Dispose();
            }
            return image;
        }

        private System.Drawing.Image method_98(System.Drawing.Image A_0)
        {
            Bitmap image = new Bitmap(A_0.Width, A_0.Height);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.Clear(System.Drawing.Color.White);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                float[][] numArray = new float[5][];
                numArray[0] = new float[] { 0.299f, 0.299f, 0.299f, 0f, 0f };
                numArray[1] = new float[] { 0.587f, 0.587f, 0.587f, 0f, 0f };
                numArray[2] = new float[] { 0.114f, 0.114f, 0.114f, 0f, 0f };
                float[] numArray2 = new float[5];
                numArray2[3] = 1f;
                numArray[3] = numArray2;
                float[] numArray3 = new float[5];
                numArray3[4] = 1f;
                numArray[4] = numArray3;
                float[][] newColorMatrix = numArray;
                ColorMatrix matrix = new ColorMatrix(newColorMatrix);
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.ClearColorMatrix();
                imageAttr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width, A_0.Height), 0, 0, A_0.Width, A_0.Height, GraphicsUnit.Pixel, imageAttr);
                graphics.Dispose();
                imageAttr.Dispose();
            }
            return image;
        }

        private System.Drawing.Image method_99(System.Drawing.Image A_0)
        {
            Bitmap image = new Bitmap(A_0.Width, A_0.Height);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.Clear(System.Drawing.Color.White);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                ColorMatrix newColorMatrix = new ColorMatrix {
                    Matrix33 = 0.5f
                };
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.ClearColorMatrix();
                imageAttr.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(A_0, new Rectangle(0, 0, A_0.Width, A_0.Height), 0, 0, A_0.Width, A_0.Height, GraphicsUnit.Pixel, imageAttr);
                graphics.Dispose();
                imageAttr.Dispose();
            }
            return image;
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 9;
            base.ReadXmlAttributes(reader);
            this.Width = reader.ReadFloat(BookmarkStart.b("堮堰圲䄴弶", 9));
            this.Height = reader.ReadFloat(BookmarkStart.b("䜮吰娲刴弶䴸", 9));
            this.float_3 = reader.ReadFloat(BookmarkStart.b("砮堰圲䄴弶樸堺尼匾⑀", 9));
            this.float_4 = reader.ReadFloat(BookmarkStart.b("朮吰娲刴弶䴸栺帼帾ⵀ♂", 9));
            if (reader.HasAttribute(BookmarkStart.b("朮帰䄲尴䴶嘸唺䤼帾ⵀూ㝄⹆⹈≊⍌", 9)))
            {
                this.horizontalOrigin_0 = (Spire.Doc.Documents.HorizontalOrigin) reader.ReadEnum(BookmarkStart.b("朮帰䄲尴䴶嘸唺䤼帾ⵀూ㝄⹆⹈≊⍌", num), typeof(Spire.Doc.Documents.HorizontalOrigin));
            }
            if (reader.HasAttribute(BookmarkStart.b("礮吰䄲䄴帶娸娺儼瀾㍀⩂≄⹆❈", num)))
            {
                this.verticalOrigin_0 = (Spire.Doc.Documents.VerticalOrigin) reader.ReadEnum(BookmarkStart.b("礮吰䄲䄴帶娸娺儼瀾㍀⩂≄⹆❈", num), typeof(Spire.Doc.Documents.VerticalOrigin));
            }
            if (reader.HasAttribute(BookmarkStart.b("礮吰䄲䄴帶娸娺儼漾⹀あⱄ㍆⁈⑊⍌", num)))
            {
                this.float_6 = reader.ReadFloat(BookmarkStart.b("礮吰䄲䄴帶娸娺儼漾⹀あⱄ㍆⁈⑊⍌", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("朮帰䄲尴䴶嘸唺䤼帾ⵀፂ⩄㑆⁈㽊⑌⁎㽐", num)))
            {
                this.float_5 = reader.ReadFloat(BookmarkStart.b("朮帰䄲尴䴶嘸唺䤼帾ⵀፂ⩄㑆⁈㽊⑌⁎㽐", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("砮䌰刲䔴䜶倸唺娼氾㕀㩂⥄≆", num)))
            {
                this.textWrappingStyle_0 = (Spire.Doc.Documents.TextWrappingStyle) reader.ReadEnum(BookmarkStart.b("砮䌰刲䔴䜶倸唺娼氾㕀㩂⥄≆", num), typeof(Spire.Doc.Documents.TextWrappingStyle));
            }
            if (reader.HasAttribute(BookmarkStart.b("砮䌰刲䔴䜶倸唺娼款㡀㍂⁄", num)))
            {
                this.textWrappingType_0 = (Spire.Doc.Documents.TextWrappingType) reader.ReadEnum(BookmarkStart.b("砮䌰刲䔴䜶倸唺娼款㡀㍂⁄", num), typeof(Spire.Doc.Documents.TextWrappingType));
            }
            if (reader.HasAttribute(BookmarkStart.b("昮䈰焲倴嬶嘸䰺椼娾㥀㝂", num)))
            {
                this.bool_11 = reader.ReadBoolean(BookmarkStart.b("昮䈰焲倴嬶嘸䰺椼娾㥀㝂", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("朮帰䄲尴䴶嘸唺䤼帾ⵀɂ⥄⹆⹈╊⁌⩎㽐❒", num)))
            {
                this.shapeHorizontalAlignment_0 = (ShapeHorizontalAlignment) reader.ReadEnum(BookmarkStart.b("朮帰䄲尴䴶嘸唺䤼帾ⵀɂ⥄⹆⹈╊⁌⩎㽐❒", num), typeof(ShapeHorizontalAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("礮吰䄲䄴帶娸娺儼績ⵀ⩂≄⥆⑈⹊⍌㭎", num)))
            {
                this.shapeVerticalAlignment_0 = (ShapeVerticalAlignment) reader.ReadEnum(BookmarkStart.b("礮吰䄲䄴帶娸娺儼績ⵀ⩂≄⥆⑈⹊⍌㭎", num), typeof(ShapeVerticalAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("簮夰刲䔴制瀸缺", num)))
            {
                this.int_9 = reader.ReadInt(BookmarkStart.b("簮夰刲䔴制瀸缺", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("昮䈰笲倴嘶崸帺似", num)))
            {
                this.bool_12 = reader.ReadBoolean(BookmarkStart.b("昮䈰笲倴嘶崸帺似", num));
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            base.ReadXmlContent(reader);
            if (reader.TagName == BookmarkStart.b("娲場嘶常帺", 13))
            {
                System.Drawing.Image image = this.method_90(reader.ReadChildBinaryElement());
                this.LoadImage(image);
                return true;
            }
            return false;
        }

        internal static byte[] smethod_3(Metafile A_0)
        {
            int num = 14;
            Rectangle bounds = A_0.GetMetafileHeader().Bounds;
            Bitmap image = null;
            try
            {
                image = new Bitmap(bounds.Width, bounds.Height, A_0.PixelFormat);
            }
            catch
            {
                throw new ArgumentException(BookmarkStart.b("紳䀵夷嘹唻娽怿⽁⅃㉅⥇ⱉ╋≍㕏牑㉓㥕⩗㝙㵛⩝䁟", num));
            }
            Graphics graphics = Graphics.FromImage(image);
            IntPtr hdc = graphics.GetHdc();
            MemoryStream stream = new MemoryStream();
            Metafile metafile = new Metafile(stream, hdc, EmfType.EmfPlusOnly);
            graphics.ReleaseHdc(hdc);
            Graphics graphics2 = Graphics.FromImage(metafile);
            graphics2.DrawImageUnscaled(A_0, bounds);
            graphics2.Dispose();
            metafile.Dispose();
            byte[] buffer = stream.ToArray();
            stream.Close();
            return buffer;
        }

        internal static byte[] smethod_4(System.Drawing.Image A_0)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    if (!A_0.RawFormat.Equals(ImageFormat.Tiff) && !A_0.RawFormat.Equals(ImageFormat.Bmp))
                    {
                        A_0.Save(stream, A_0.RawFormat);
                    }
                    else
                    {
                        A_0.Save(stream, ImageFormat.Png);
                    }
                }
                catch
                {
                    A_0.Save(stream, ImageFormat.Png);
                }
                return stream.ToArray();
            }
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            if (this.HasImage)
            {
                dc.method_213(this, ltWidget, true);
            }
            else if ((this.ShapeInfo != null) && (this.ShapeInfo is ShapeGroup))
            {
                dc.method_215(this.ShapeInfo, ltWidget);
            }
            else
            {
                dc.method_215(this, ltWidget);
            }
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            return dc.method_306(this);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x13;
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("䴸䈺䴼娾", 0x13), ParagraphItemType.Picture);
            writer.WriteValue(BookmarkStart.b("丸刺夼䬾⥀", 0x13), this.Size.Width);
            writer.WriteValue(BookmarkStart.b("儸帺吼堾⥀㝂", 0x13), this.Size.Height);
            writer.WriteValue(BookmarkStart.b("游刺夼䬾⥀၂♄♆╈⹊", 0x13), this.float_3);
            writer.WriteValue(BookmarkStart.b("焸帺吼堾⥀㝂ᙄ⑆⡈❊⡌", 0x13), this.float_4);
            writer.WriteValue(BookmarkStart.b("瀸䠺瀼娾㕀≂⍄⹆╈⹊", 0x13), this.ImageRecord.method_7());
            if (this.textWrappingStyle_0 != Spire.Doc.Documents.TextWrappingStyle.Inline)
            {
                writer.WriteValue(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊Ɍ㵎㡐㑒㱔㥖", num), this.horizontalOrigin_0);
                writer.WriteValue(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆و㥊⑌⡎㡐㵒", num), this.verticalOrigin_0);
                writer.WriteValue(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆᥈⑊㹌♎═㩒㩔㥖", num), this.float_6);
                writer.WriteValue(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊ᵌ⁎≐㩒⅔㹖㙘㕚", num), this.float_5);
                writer.WriteValue(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ᩈ㽊㑌⍎㑐", num), this.textWrappingStyle_0);
                writer.WriteValue(BookmarkStart.b("游䤺尼伾ㅀ⩂⭄⁆ᵈ㉊㵌⩎", num), this.textWrappingType_0);
                writer.WriteValue(BookmarkStart.b("瀸䠺缼娾ⵀⱂ㉄ፆⱈ㍊㥌", num), this.bool_11);
                writer.WriteValue(BookmarkStart.b("焸吺似嘾㭀ⱂ⭄㍆⡈❊ౌ⍎㡐㑒㭔㩖㱘㕚⥜", num), this.shapeHorizontalAlignment_0);
                writer.WriteValue(BookmarkStart.b("漸帺似䬾⡀⁂⑄⭆ࡈ❊⑌⡎㽐㹒ご㥖ⵘ", num), this.shapeVerticalAlignment_0);
                writer.WriteValue(BookmarkStart.b("樸区尼伾⑀ੂń", num), this.int_9);
                if (this.bool_12)
                {
                    writer.WriteValue(BookmarkStart.b("瀸䠺甼娾⁀❂⁄㕆", num), this.bool_12);
                }
            }
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 4;
            base.WriteXmlContent(writer);
            if (this.class517_0 != null)
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("䌩䄫伭圯圱", num), this.class517_0.method_3());
            }
        }

        internal bool AllowOverlap
        {
            get
            {
                return base.AllowOverlap;
            }
            set
            {
                base.AllowOverlap = value;
            }
        }

        internal int AlphaMod
        {
            get
            {
                return this.int_10;
            }
            set
            {
                this.int_10 = value;
            }
        }

        internal float AlphaModFix
        {
            get
            {
                return this.float_21;
            }
            set
            {
                this.float_21 = value;
            }
        }

        public string AlternativeText
        {
            get
            {
                return (string) base.GetShapeAttribute(0x381);
            }
            set
            {
                base.SetShapeAttribute(0x381, value);
            }
        }

        public bool BiLevel
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x13e);
            }
            set
            {
                base.SetShapeAttribute(0x13e, value);
            }
        }

        internal Spire.Doc.Documents.Borders Borders
        {
            get
            {
                return base.ShapePr.method_58();
            }
        }

        public float Brightness
        {
            get
            {
                return (((float) Class792.smethod_5((int) base.GetShapeAttribute(0x109))) / 1000f);
            }
            set
            {
                int num = 4;
                if ((value < -100f) || (value > 100f))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("稩䔫䴭䐯䜱䘳匵ᠷ堹主圽✿⩁⩃⍅㭇㥉汋⍍╏⅑⁓癕㩗㽙籛㥝቟ݡգብ൧ᡩ䱫ᩭᡯ፱ᩳ噵䡷婹ᵻၽꊁﾇﺋ꺍晴뢗ꮙ겛꺝", num));
                }
                base.SetShapeAttribute(0x109, Class792.smethod_4((int) (value * 1000f)));
            }
        }

        public override Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return base.m_charFormat;
            }
            internal set
            {
                base.m_charFormat = value;
            }
        }

        internal System.Drawing.Color ChromaKey
        {
            get
            {
                return (System.Drawing.Color) this.method_75(0x107);
            }
            set
            {
                this.method_79(0x107, value);
            }
        }

        public PictureColor Color
        {
            get
            {
                bool shapeAttribute = (bool) base.GetShapeAttribute(0x13d);
                if ((bool) base.GetShapeAttribute(0x13e))
                {
                    return PictureColor.BlackAndWhite;
                }
                if (shapeAttribute)
                {
                    return PictureColor.Grayscale;
                }
                if ((this.Contrast == 15f) && (this.Brightness == 85f))
                {
                    return PictureColor.Washout;
                }
                return PictureColor.Automatic;
            }
            set
            {
                if (value == PictureColor.Washout)
                {
                    this.Contrast = 15f;
                    this.Brightness = 85f;
                }
                else if (value == PictureColor.BlackAndWhite)
                {
                    base.SetShapeAttribute(0x13e, true);
                }
                else if (value == PictureColor.Grayscale)
                {
                    base.SetShapeAttribute(0x13d, true);
                }
            }
        }

        public float Contrast
        {
            get
            {
                return (((float) Class792.smethod_7((int) base.GetShapeAttribute(0x108))) / 1000f);
            }
            set
            {
                int num = 6;
                if ((value < -100f) || (value > 100f))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("簫䜭匯䘱䄳䐵崷ᨹ弻儽⸿㙁㙃❅㭇㹉汋⍍╏⅑⁓癕㩗㽙籛㥝቟ݡգብ൧ᡩ䱫ᩭᡯ፱ᩳ噵啷䭹䱻乽ꁿꢇ轢뒓ﮙ뺝醟銡钣", num));
                }
                base.SetShapeAttribute(0x108, Class792.smethod_6((int) (value * 1000f)));
            }
        }

        internal float CropFromBottom
        {
            get
            {
                return this.method_76(0x101);
            }
            set
            {
                this.method_78(0x101, value);
            }
        }

        internal float CropFromLeft
        {
            get
            {
                return this.method_76(0x102);
            }
            set
            {
                this.method_78(0x102, value);
            }
        }

        internal float CropFromRight
        {
            get
            {
                return this.method_76(0x103);
            }
            set
            {
                this.method_78(0x103, value);
            }
        }

        internal float CropFromTop
        {
            get
            {
                return this.method_76(0x100);
            }
            set
            {
                this.method_78(0x100, value);
            }
        }

        internal Rectangle CropRectangle
        {
            get
            {
                RectangleF ef = new RectangleF();
                if (this.class517_0 != null)
                {
                    ef = new RectangleF(new PointF(0f, 0f), new SizeF((float) this.class517_0.method_9().Width, (float) this.class517_0.method_9().Height));
                }
                else if (this.Image != null)
                {
                    ef = new RectangleF(new PointF(0f, 0f), new SizeF((float) this.Image.Width, (float) this.Image.Height));
                }
                return this.method_110(ef);
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Picture;
            }
        }

        internal List<Stream> DocxProps
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<Stream>();
                }
                return this.list_0;
            }
        }

        internal float EffectExtentBottom
        {
            get
            {
                return this.float_25;
            }
            set
            {
                this.float_25 = value;
            }
        }

        internal float EffectExtentLeft
        {
            get
            {
                return this.float_22;
            }
            set
            {
                this.float_22 = value;
            }
        }

        internal float EffectExtentRight
        {
            get
            {
                return this.float_24;
            }
            set
            {
                this.float_24 = value;
            }
        }

        internal float EffectExtentTop
        {
            get
            {
                return this.float_23;
            }
            set
            {
                this.float_23 = value;
            }
        }

        internal Body EmbedBody
        {
            get
            {
                return this.body_0;
            }
            set
            {
                this.body_0 = value;
            }
        }

        internal DocOleObject EmbedOleObject
        {
            get
            {
                if ((this.docOleObject_1 == null) && (this.body_0 != null))
                {
                    return this.method_83();
                }
                if ((this.docOleObject_1 != null) && (this.docOleObject_1.Owner == null))
                {
                    this.docOleObject_1.method_0(base.Owner);
                }
                return this.docOleObject_1;
            }
            set
            {
                this.docOleObject_1 = value;
            }
        }

        public bool GrayScale
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x13d);
            }
            set
            {
                base.SetShapeAttribute(0x13d, value);
            }
        }

        internal bool HasBorder
        {
            get
            {
                return !base.ShapePr.method_58().NoBorder;
            }
        }

        internal bool HasImage
        {
            get
            {
                return (this.ImageBytes != null);
            }
        }

        public float Height
        {
            get
            {
                return Convert.ToSingle(base.Height);
            }
            set
            {
                base.Height = value;
            }
        }

        internal float HeightPercent
        {
            get
            {
                return this.float_20;
            }
            set
            {
                this.float_20 = value;
            }
        }

        public float HeightScale
        {
            get
            {
                return this.float_4;
            }
            set
            {
                int num = 13;
                if (value <= 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("怲嘴嘶唸帺ᴼ夾⁀⁂ㅄ⡆㭈歊⁌㩎≐❒畔㕖㱘筚㩜ⵞѠɢᅤɦ᭨䭪ᥬݮၰᵲ啴䝶", num));
                }
                this.float_4 = value;
            }
        }

        public override ShapeHorizontalAlignment HorizontalAlignment
        {
            get
            {
                return (ShapeHorizontalAlignment) base.GetShapeAttribute(0x38f);
            }
            set
            {
                base.SetShapeAttribute(0x38f, value);
            }
        }

        public override Spire.Doc.Documents.HorizontalOrigin HorizontalOrigin
        {
            get
            {
                return (Spire.Doc.Documents.HorizontalOrigin) base.GetShapeAttribute(0x390);
            }
            set
            {
                base.SetShapeAttribute(0x390, value);
            }
        }

        public override float HorizontalPosition
        {
            get
            {
                return Convert.ToSingle(base.Left);
            }
            set
            {
                base.Left = value;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return this.method_90(this.ImageBytes);
            }
        }

        public byte[] ImageBytes
        {
            get
            {
                return (byte[]) base.GetShapeAttribute(0x1006);
            }
        }

        internal Class517 ImageRecord
        {
            get
            {
                if (this.class517_0 == null)
                {
                    this.class517_0 = new Class517(this.ImageBytes);
                }
                return this.class517_0;
            }
        }

        internal RectangleF InTableCellBounds
        {
            get
            {
                return this.rectangleF_0;
            }
            set
            {
                if (((this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Inline) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Behind)) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.InFrontOfText))
                {
                    this.rectangleF_0 = value;
                }
            }
        }

        internal bool IsChromaKeySpecified
        {
            get
            {
                return (base.GetDirectShapeAttribute(0x107) != null);
            }
        }

        internal bool IsCrop
        {
            get
            {
                if (((this.CropFromBottom == 0f) && (this.CropFromLeft == 0f)) && (this.CropFromRight == 0f))
                {
                    return !(this.CropFromTop == 0f);
                }
                return true;
            }
        }

        internal bool IsEditWrapPolygonPoint
        {
            get
            {
                return this.bool_18;
            }
            set
            {
                this.bool_18 = value;
            }
        }

        internal bool IsHeaderPicture
        {
            get
            {
                return this.bool_12;
            }
            set
            {
                this.bool_12 = value;
            }
        }

        internal bool IsLink
        {
            get
            {
                return Class567.smethod_16(this.SourceFullName);
            }
        }

        internal bool IsMetaFile
        {
            get
            {
                if (this.ImageRecord == null)
                {
                    return false;
                }
                return this.ImageRecord.method_7();
            }
        }

        internal bool IsOlePicture
        {
            [CompilerGenerated]
            get
            {
                return this.bool_19;
            }
            [CompilerGenerated]
            set
            {
                this.bool_19 = value;
            }
        }

        internal bool IsPositivelyCrop
        {
            get
            {
                if (((this.CropFromLeft <= 0f) && (this.CropFromRight <= 0f)) && (this.CropFromTop <= 0f))
                {
                    return (this.CropFromBottom > 0f);
                }
                return true;
            }
        }

        internal bool IsShape
        {
            get
            {
                return this.bool_13;
            }
            set
            {
                this.bool_13 = value;
            }
        }

        public bool IsUnderText
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x3ba);
            }
            set
            {
                base.SetShapeAttribute(0x3ba, value);
            }
        }

        public bool LayoutInCell
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x3b0);
            }
            set
            {
                base.SetShapeAttribute(0x3b0, value);
            }
        }

        internal float LeftPercent
        {
            get
            {
                return this.float_17;
            }
            set
            {
                this.float_17 = value;
            }
        }

        internal bool LockAspectRatio
        {
            get
            {
                return (bool) base.GetShapeAttribute(120);
            }
            set
            {
                base.SetShapeAttribute(120, value);
            }
        }

        internal long OrderIndex
        {
            get
            {
                return base.ZOrder;
            }
            set
            {
                base.ZOrder = value;
            }
        }

        internal Spire.Doc.Documents.VerticalOrigin RelationHeight
        {
            get
            {
                return this.verticalOrigin_1;
            }
            set
            {
                this.verticalOrigin_1 = value;
            }
        }

        internal Spire.Doc.Documents.HorizontalOrigin RelationWidth
        {
            get
            {
                return this.horizontalOrigin_1;
            }
            set
            {
                this.horizontalOrigin_1 = value;
            }
        }

        internal float Rotation
        {
            get
            {
                return (float) base.Rotation;
            }
            set
            {
                base.Rotation = value;
            }
        }

        internal int ShapeId
        {
            get
            {
                return (int) base.GetShapeAttribute(0x101c);
            }
            set
            {
                base.SetShapeAttribute(0x101c, value);
            }
        }

        internal ShapeObject ShapeInfo
        {
            [CompilerGenerated]
            get
            {
                return this.shapeObject_1;
            }
            [CompilerGenerated]
            set
            {
                this.shapeObject_1 = value;
            }
        }

        internal SizeF Size
        {
            get
            {
                if (!base.ShapePr.HasKey(0x1023) || !base.ShapePr.HasKey(0x1024))
                {
                    this.method_108(this.Image);
                }
                return base.Size;
            }
            set
            {
                base.Width = value.Width;
                base.Height = value.Height;
            }
        }

        internal string SourceFullName
        {
            get
            {
                return this.string_11;
            }
            set
            {
                this.string_11 = value;
            }
        }

        public override Spire.Doc.Documents.TextWrappingStyle TextWrappingStyle
        {
            get
            {
                return (Spire.Doc.Documents.TextWrappingStyle) base.GetShapeAttribute(0x1001);
            }
            set
            {
                if (value == Spire.Doc.Documents.TextWrappingStyle.Behind)
                {
                    this.IsUnderText = true;
                }
                else if (!this.IsHeaderPicture)
                {
                    this.IsUnderText = false;
                }
                base.SetShapeAttribute(0x1001, value);
            }
        }

        internal Spire.Doc.Documents.TextWrappingStyle TextWrappingStyleEx
        {
            get
            {
                Spire.Doc.Documents.TextWrappingStyle textWrappingStyle = base.TextWrappingStyle;
                if (((this.IsHeaderPicture && this.IsUnderText) && ((textWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Behind) && (textWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.InFrontOfText))) && (textWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Inline))
                {
                    return Spire.Doc.Documents.TextWrappingStyle.Behind;
                }
                return textWrappingStyle;
            }
        }

        public override Spire.Doc.Documents.TextWrappingType TextWrappingType
        {
            get
            {
                return (Spire.Doc.Documents.TextWrappingType) base.GetShapeAttribute(0x1002);
            }
            set
            {
                base.SetShapeAttribute(0x1002, value);
            }
        }

        public string Title
        {
            get
            {
                return (string) base.GetShapeAttribute(0x1007);
            }
            set
            {
                base.SetShapeAttribute(0x1007, value);
            }
        }

        internal float TopPercent
        {
            get
            {
                return this.float_18;
            }
            set
            {
                this.float_18 = value;
            }
        }

        public override ShapeVerticalAlignment VerticalAlignment
        {
            get
            {
                return (ShapeVerticalAlignment) base.GetShapeAttribute(0x391);
            }
            set
            {
                base.SetShapeAttribute(0x391, value);
            }
        }

        public override Spire.Doc.Documents.VerticalOrigin VerticalOrigin
        {
            get
            {
                return (Spire.Doc.Documents.VerticalOrigin) base.GetShapeAttribute(0x392);
            }
            set
            {
                base.SetShapeAttribute(0x392, value);
            }
        }

        public override float VerticalPosition
        {
            get
            {
                return Convert.ToSingle(base.Top);
            }
            set
            {
                base.Top = value;
            }
        }

        public float Width
        {
            get
            {
                return Convert.ToSingle(base.Width);
            }
            set
            {
                base.Width = value;
            }
        }

        internal float WidthPercent
        {
            get
            {
                return this.float_19;
            }
            set
            {
                this.float_19 = value;
            }
        }

        public float WidthScale
        {
            get
            {
                return this.float_3;
            }
            set
            {
                int num = 1;
                if (value <= 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("琦䨨䨪䄬䨮ᄰ唲吴吶䴸吺似Ἶⱀ㙂㙄㍆楈⥊⡌潎㙐⅒ご㙖ⵘ㹚⽜罞ᕠୢѤ०䥨孪", num));
                }
                this.float_3 = value;
            }
        }

        internal float WrapDistanceBottom
        {
            get
            {
                if ((this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Square) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.TopAndBottom))
                {
                    return 0f;
                }
                return Convert.ToSingle(base.DistanceBottom);
            }
            set
            {
                base.DistanceBottom = value;
            }
        }

        internal float WrapDistanceLeft
        {
            get
            {
                if (((this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Square) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Tight)) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Through))
                {
                    return 0f;
                }
                return Convert.ToSingle(base.DistanceLeft);
            }
            set
            {
                base.DistanceLeft = value;
            }
        }

        internal float WrapDistanceRight
        {
            get
            {
                if (((this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Square) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Tight)) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Through))
                {
                    return 0f;
                }
                return Convert.ToSingle(base.DistanceRight);
            }
            set
            {
                base.DistanceRight = value;
            }
        }

        internal float WrapDistanceTop
        {
            get
            {
                if ((this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.Square) && (this.TextWrappingStyle != Spire.Doc.Documents.TextWrappingStyle.TopAndBottom))
                {
                    return 0f;
                }
                return Convert.ToSingle(base.DistanceTop);
            }
            set
            {
                base.DistanceTop = value;
            }
        }

        internal Class891[] WrapPolygon
        {
            get
            {
                Class891[] shapeAttribute = (Class891[]) base.GetShapeAttribute(0x383);
                if ((shapeAttribute != null) && (shapeAttribute.Length >= 5))
                {
                    return shapeAttribute;
                }
                return new Class891[] { new Class891(0, 0), new Class891(0, 0x541f), new Class891(0x541f, 0x541f), new Class891(0x541f, 0), new Class891(0, 0) };
            }
            set
            {
                base.SetShapeAttribute(0x383, value);
            }
        }

        internal List<PointF> WrapPolygonEx
        {
            get
            {
                List<PointF> list = new List<PointF>();
                foreach (Class891 class2 in this.WrapPolygon)
                {
                    list.Add(new PointF((class2.method_0().method_1() * 0.75f) / 20f, (class2.method_1().method_1() * 0.75f) / 20f));
                }
                return list;
            }
        }
    }
}

