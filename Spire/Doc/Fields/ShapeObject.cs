namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields.Shape;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class ShapeObject : ShapeBase, Interface2
    {
        [CompilerGenerated]
        private bool bool_10;
        private bool bool_9;
        private byte byte_4;
        private Class1076 class1076_0;
        private Class626 class626_0;
        private Class628 class628_0;
        private Class826 class826_0;
        internal DocOleObject docOleObject_0;
        private DocPicture docPicture_0;
        [CompilerGenerated]
        private DocumentObject documentObject_0;
        [CompilerGenerated]
        private Field field_0;
        private float[] float_2;
        private int int_7;
        private long long_4;
        private long[] long_5;
        [CompilerGenerated]
        private PointF pointF_0;
        private Spire.Doc.Fields.TextBox textBox_0;
        private TextBoxItemCollection textBoxItemCollection_0;
        private VMLFill vmlfill_0;
        private Spire.Doc.Fields.WordArt wordArt_0;

        public ShapeObject(IDocument doc) : base((Document) doc)
        {
            this.textBoxItemCollection_0 = new TextBoxItemCollection(doc);
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(doc);
            base.m_charFormat.method_0(this);
            base.SetShapeType(ShapeType.Rectangle);
        }

        public ShapeObject(IDocument doc, ShapeType shapeType) : base((Document) doc)
        {
            this.textBoxItemCollection_0 = new TextBoxItemCollection(doc);
            base.m_charFormat = new Spire.Doc.Formatting.CharacterFormat(doc);
            base.m_charFormat.method_0(this);
            base.SetShapeType(shapeType);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_35(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_34(this);
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
        }

        protected override object CloneImpl()
        {
            ShapeObject obj2 = (ShapeObject) base.CloneImpl();
            obj2.textBoxItemCollection_0 = new TextBoxItemCollection(base.Document);
            this.textBoxItemCollection_0.method_12(obj2.textBoxItemCollection_0);
            obj2.bool_4 = true;
            return obj2;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            foreach (Spire.Doc.Fields.TextBox box in this.AutoShapeTextCollection)
            {
                foreach (DocumentObject obj2 in box.ChildObjects)
                {
                    obj2.CloneRelationsTo(doc, nextOwner);
                    obj2.method_0(doc);
                }
            }
            base.Document.method_157(doc, this);
            base.bool_4 = false;
        }

        protected override void CreateLayoutInfo()
        {
            base.CreateLayoutInfo();
        }

        protected override void InitXDLSHolder()
        {
            base.InitXDLSHolder();
            base.XDLSHolder.AddElement(BookmarkStart.b("䴸帺䔼䬾⍀ⱂ㵄≆㩈", 0x13), this.textBoxItemCollection_0);
            base.XDLSHolder.AddElement(BookmarkStart.b("娸区尼䴾⁀⁂ㅄ≆㭈晊⭌⁎⍐㹒㑔⍖", 0x13), base.m_charFormat);
        }

        internal int method_60(int A_0)
        {
            int num3;
            int num = 12;
            switch (A_0)
            {
                case 1:
                    num3 = 0x147;
                    break;

                case 2:
                    num3 = 0x148;
                    break;

                case 3:
                    num3 = 0x149;
                    break;

                case 4:
                    num3 = 330;
                    break;

                case 5:
                    num3 = 0x14b;
                    break;

                case 6:
                    num3 = 0x14c;
                    break;

                case 7:
                    num3 = 0x14d;
                    break;

                case 8:
                    num3 = 0x14e;
                    break;

                case 9:
                    num3 = 0x14f;
                    break;

                case 10:
                    num3 = 0x150;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("嬱娳刵崷䈹", num));
            }
            return (int) base.GetShapeAttribute(num3);
        }

        internal WatermarkBase method_61()
        {
            TextWatermark watermark = new TextWatermark(base.m_doc);
            if (!base.ShapePr.method_6(0x182))
            {
                watermark.Semitransparent = false;
            }
            watermark.Text = (string) base.ShapePr.method_32(0xc0);
            watermark.FontName = (string) base.ShapePr.method_32(0xc5);
            if (base.ShapePr.method_6(0xc3))
            {
                watermark.FontSize = Class969.smethod_69((int) base.ShapePr.method_32(0xc3));
            }
            if (base.ShapePr.method_6(0x181))
            {
                watermark.Color = (Color) base.ShapePr.method_32(0x181);
            }
            else
            {
                watermark.Color = Color.Empty;
            }
            if (base.ShapePr.method_6(0x1023))
            {
                watermark.ShapeWidthInPixels = (int) (base.Width * 20.0);
            }
            if (base.ShapePr.method_6(0x1024))
            {
                watermark.ShapeHeightInPixels = (int) (base.Height * 20.0);
            }
            if (!base.ShapePr.method_6(4))
            {
                watermark.Layout = WatermarkLayout.Horizontal;
            }
            return watermark;
        }

        internal WatermarkBase method_62()
        {
            PictureWatermark watermark = new PictureWatermark(base.m_doc) {
                WordPicture = this.ImageData
            };
            if (!base.ShapePr.method_6(0x108) && !base.ShapePr.method_6(0x109))
            {
                watermark.IsWashout = false;
            }
            if (this.ImageData.Image.Size.Width != this.ImageData.Width)
            {
                watermark.Scaling = (this.ImageData.Width / ((float) this.ImageData.Image.Size.Width)) * 100f;
            }
            else if (this.ImageData.Image.Size.Height != this.ImageData.Height)
            {
                watermark.Scaling = (this.ImageData.Height / ((float) this.ImageData.Image.Size.Height)) * 100f;
            }
            else
            {
                watermark.ScalingAuto = false;
            }
            this.ImageData.Width = this.ImageData.Image.Size.Width;
            this.ImageData.Height = this.ImageData.Image.Size.Height;
            return watermark;
        }

        internal DocPicture method_63(bool A_0)
        {
            Paragraph owner = base.Owner as Paragraph;
            owner = (owner != null) ? owner : base.method_28();
            Document document = base.Document;
            float heightPercent = this.HeightPercent;
            if (this.HeightPercent > 0f)
            {
                float num = this.method_67(base.RelativeHeight, this.HeightPercent);
                if ((num > 0f) && (base.Height != num))
                {
                    base.Height = num;
                }
            }
            float widthPercent = this.WidthPercent;
            if (this.WidthPercent > 0f)
            {
                float num2 = this.method_68(base.RelativeWidth, this.WidthPercent);
                if ((num2 > 0f) && (num2 != base.Width))
                {
                    base.Width = num2;
                }
            }
            if ((base.LeftPercent != null) && (((float) base.LeftPercent) != 0f))
            {
                float num3 = this.method_65(this.HorizontalOrigin, (float) base.LeftPercent);
                if ((num3 != 0f) && (base.Left != num3))
                {
                    base.Left = num3;
                }
            }
            if ((base.TopPercent != null) && (((float) base.TopPercent) != 0f))
            {
                float num4 = this.method_66(this.VerticalOrigin, (float) base.TopPercent);
                if ((num4 != 0f) && (base.Top != num4))
                {
                    base.Top = num4;
                }
            }
            if (!A_0 && !this.CompleteExtractionOfEmbeddedTextbox)
            {
                int num5 = this.method_64(this, this, owner);
                int num6 = num5;
                this.method_70(owner, this, ref num5);
                this.CompleteExtractionOfEmbeddedTextbox = true;
                if (num6 != num5)
                {
                    document.LayoutVariables.method_0().Add(owner);
                }
            }
            DocPicture picture = new DocPicture(base.Document, base.Clone() as ShapeObject) {
                ShapeInfo = this
            };
            picture.method_0(base.Owner);
            picture.Height = (float) base.Height;
            picture.Width = (float) base.Width;
            picture.HorizontalPosition = (base.Owner.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup) ? (((float) base.Left) / 20f) : ((float) base.Left);
            picture.VerticalPosition = (base.Owner.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup) ? (((float) base.Top) / 20f) : ((float) base.Top);
            if (base.IsHorizontalRule)
            {
                DocumentObject obj2 = base.Owner;
                while (obj2 != null)
                {
                    if (obj2 is Section)
                    {
                        break;
                    }
                    obj2 = obj2.Owner;
                }
                if (obj2 is Section)
                {
                    float clientWidth = (obj2 as Section).PageSetup.ClientWidth;
                    if (this.HorizontalRule.method_8() > 0.0)
                    {
                        float num8 = (float) ((clientWidth * this.HorizontalRule.method_8()) / 100.0);
                        picture.Width = num8;
                        base.Width = num8;
                    }
                    switch (this.HorizontalRule.method_6())
                    {
                        case ShapeHorizontalAlignment.Center:
                            picture.HorizontalPosition = (clientWidth - picture.Width) / 2f;
                            break;

                        case ShapeHorizontalAlignment.Right:
                            picture.HorizontalPosition = picture.Width - clientWidth;
                            break;
                    }
                }
            }
            picture.TextWrappingStyle = this.TextWrappingStyleEx;
            picture.OwnerHyperlinkField = this.OwnerHyperlinkField;
            return picture;
        }

        private int method_64(DocumentObject A_0, DocumentObject A_1, Paragraph A_2)
        {
            int num = (A_0 != null) ? ((A_0.Owner is SDTInlineContent) ? A_2.Items.IndexOf(A_0.Owner.Owner) : A_2.Items.IndexOf(this)) : A_2.Items.IndexOf(A_1);
            return (num + 1);
        }

        private float method_65(HorizontalOrigin A_0, float A_1)
        {
            float width = 0f;
            float clientWidth = 0f;
            DocumentObject owner = base.Owner;
            while (owner != null)
            {
                if (owner is Section)
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner is Section)
            {
                Section section = owner as Section;
                float left = section.PageSetup.Margins.Left;
                float right = section.PageSetup.Margins.Right;
                float top = section.PageSetup.Margins.Top;
                float bottom = section.PageSetup.Margins.Bottom;
                float height = section.PageSetup.PageSize.Height;
                width = section.PageSetup.PageSize.Width;
                clientWidth = section.PageSetup.ClientWidth;
            }
            switch (A_0)
            {
                case HorizontalOrigin.Margin:
                    return ((clientWidth * A_1) / 1000f);

                case HorizontalOrigin.Page:
                    return ((width * A_1) / 1000f);
            }
            if (base.Owner.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.ShapeGroup)
            {
                return (float) base.Left;
            }
            return (((float) base.Left) / 20f);
        }

        private float method_66(VerticalOrigin A_0, float A_1)
        {
            float height = 0f;
            float clientHeight = 0f;
            DocumentObject owner = base.Owner;
            while (owner != null)
            {
                if (owner is Section)
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner is Section)
            {
                Section section = owner as Section;
                float left = section.PageSetup.Margins.Left;
                float right = section.PageSetup.Margins.Right;
                float top = section.PageSetup.Margins.Top;
                float bottom = section.PageSetup.Margins.Bottom;
                height = section.PageSetup.PageSize.Height;
                float width = section.PageSetup.PageSize.Width;
                float clientWidth = section.PageSetup.ClientWidth;
                clientHeight = section.PageSetup.ClientHeight;
            }
            switch (A_0)
            {
                case VerticalOrigin.Margin:
                    return ((clientHeight * A_1) / 1000f);

                case VerticalOrigin.Page:
                    return ((height * A_1) / 1000f);
            }
            return (float) base.Top;
        }

        private float method_67(RelativeHeight A_0, float A_1)
        {
            float height = 0f;
            float clientHeight = 0f;
            DocumentObject owner = base.Owner;
            while (owner != null)
            {
                if (owner is Section)
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner is Section)
            {
                Section section = owner as Section;
                float left = section.PageSetup.Margins.Left;
                float right = section.PageSetup.Margins.Right;
                float top = section.PageSetup.Margins.Top;
                float bottom = section.PageSetup.Margins.Bottom;
                height = section.PageSetup.PageSize.Height;
                float width = section.PageSetup.PageSize.Width;
                float clientWidth = section.PageSetup.ClientWidth;
                clientHeight = section.PageSetup.ClientHeight;
            }
            switch (A_0)
            {
                case RelativeHeight.Margin:
                    return ((clientHeight * A_1) / 1000f);

                case RelativeHeight.Page:
                    return ((height * A_1) / 1000f);
            }
            return (float) base.Height;
        }

        private float method_68(RelativeWidth A_0, float A_1)
        {
            float width = 0f;
            float clientWidth = 0f;
            DocumentObject owner = base.Owner;
            while (owner != null)
            {
                if (owner is Section)
                {
                    break;
                }
                owner = owner.Owner;
            }
            if (owner is Section)
            {
                Section section = owner as Section;
                float left = section.PageSetup.Margins.Left;
                float right = section.PageSetup.Margins.Right;
                float top = section.PageSetup.Margins.Top;
                float bottom = section.PageSetup.Margins.Bottom;
                float height = section.PageSetup.PageSize.Height;
                width = section.PageSetup.PageSize.Width;
                clientWidth = section.PageSetup.ClientWidth;
            }
            switch (A_0)
            {
                case RelativeWidth.Margin:
                    return ((clientWidth * A_1) / 1000f);

                case RelativeWidth.Page:
                    return ((width * A_1) / 1000f);
            }
            return (float) base.Width;
        }

        internal Spire.Doc.Fields.TextBox method_69()
        {
            if (this.AutoShapeTextCollection.Count <= 0)
            {
                return null;
            }
            Spire.Doc.Fields.TextBox box = this.AutoShapeTextCollection[0].Clone() as Spire.Doc.Fields.TextBox;
            box.method_0(this.method_74());
            box.Format.Width = (base.Owner.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup) ? (((float) base.Width) / 20f) : ((float) base.Width);
            box.Format.Height = (base.Owner.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup) ? (((float) base.Height) / 20f) : ((float) base.Height);
            box.Format.TextWrappingStyle = this.TextWrappingStyle;
            box.Format.TextWrappingType = this.TextWrappingType;
            box.Format.HorizontalAlignment = this.HorizontalAlignment;
            box.Format.VerticalAlignment = this.VerticalAlignment;
            box.Format.HorizontalOrigin = this.HorizontalOrigin;
            box.Format.VerticalOrigin = this.VerticalOrigin;
            box.Format.HorizontalPosition = (base.Owner.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup) ? (((float) base.Left) / 20f) : ((float) base.Left);
            box.Format.VerticalPosition = (base.Owner.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup) ? (((float) base.Top) / 20f) : ((float) base.Top);
            box.Format.OrderIndex = (base.Owner.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup) ? (base.Owner as ShapeGroup).ZOrderEx : base.ZOrderEx;
            box.Format.NoLine = true;
            box.Format.FillColor = Color.Empty;
            box.Format.LineWidth = 0f;
            box.Format.LineColor = Color.Empty;
            box.Format.FillEfects.Type = BackgroundType.NoBackground;
            box.Format.IsInShape = true;
            return box;
        }

        private void method_70(Paragraph A_0, ShapeObject A_1, ref int A_2)
        {
            if (A_0 != null)
            {
                if (A_1.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup)
                {
                    int num = 0;
                    int count = A_1.ChildObjects.Count;
                    while (num < count)
                    {
                        DocumentObject obj2 = A_1.ChildObjects[num];
                        if ((obj2 is ShapeObject) && (obj2.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup))
                        {
                            this.method_70(A_0, obj2 as ShapeObject, ref A_2);
                        }
                        else
                        {
                            Spire.Doc.Fields.TextBox box2 = this.method_71(obj2 as ShapeObject);
                            if (box2 != null)
                            {
                                A_0.Items.InnerList.Insert(A_2, box2);
                                A_2++;
                            }
                        }
                        num++;
                    }
                }
                else
                {
                    Spire.Doc.Fields.TextBox box = this.method_71(A_1);
                    if (box != null)
                    {
                        A_0.Items.InnerList.Insert(A_2, box);
                        A_2++;
                    }
                }
            }
        }

        private Spire.Doc.Fields.TextBox method_71(ShapeObject A_0)
        {
            if (((A_0 == null) || (A_0.InternerTextbox == null)) || (A_0.InternerTextbox.ChildObjects.Count <= 0))
            {
                return null;
            }
            Spire.Doc.Fields.TextBox box = A_0.InternerTextbox.Clone() as Spire.Doc.Fields.TextBox;
            DocumentObject owner = A_0.Owner;
            ShapeGroup group = null;
            List<PointF> list = new List<PointF> {
                A_0.BoundsInPoints.Location
            };
            while (owner != null)
            {
                if (owner is Paragraph)
                {
                    break;
                }
                if (owner is ShapeGroup)
                {
                    group = owner as ShapeGroup;
                    list.Add(group.BoundsInPoints.Location);
                }
                owner = owner.Owner;
            }
            PointF tf = new PointF();
            if (list.Count > 1)
            {
                int num = 1;
                int count = list.Count;
                while (num < count)
                {
                    PointF tf3 = list[num - 1];
                    PointF tf4 = list[num];
                    PointF tf5 = list[num - 1];
                    PointF tf6 = list[num];
                    PointF tf2 = new PointF(tf3.X - tf4.X, tf5.Y - tf6.Y);
                    tf.X += tf2.X;
                    tf.Y += tf2.Y;
                    num++;
                }
            }
            list = null;
            bool flag = (group != null) && (group.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.ShapeGroup);
            box.method_0(owner);
            if (flag)
            {
                box.Format.Width = A_0.BoundsInPoints.Width;
                box.Format.Height = A_0.BoundsInPoints.Height;
                if (flag)
                {
                    box.Format.HorizontalAlignment = group.HorizontalAlignment;
                    box.Format.VerticalAlignment = group.VerticalAlignment;
                    box.Format.HorizontalOrigin = group.HorizontalOrigin;
                    box.Format.VerticalOrigin = group.VerticalOrigin;
                    box.Format.HorizontalPosition = tf.X;
                    box.Format.VerticalPosition = tf.Y;
                    box.Format.OrderIndex = group.ZOrderEx;
                }
                else
                {
                    box.Format.HorizontalPosition = A_0.HorizontalPosition;
                    box.Format.VerticalPosition = A_0.VerticalPosition;
                    box.Format.OrderIndex = A_0.ZOrderEx;
                }
            }
            box.Format.IsInShape = true;
            box.ShapeInfo = flag ? group : A_0;
            box.Format.IsInGroupShape = flag;
            if (A_0.TextBox != null)
            {
                box.Format.TextAnchor = this.method_73(A_0.TextBox.method_14());
                box.Format.TextBoxWrapMode = A_0.TextBox.method_12();
                box.Format.IsFitShapeToText = A_0.TextBox.method_8();
                box.Format.InternalMargin.Bottom = (float) A_0.TextBox.method_6();
                box.Format.InternalMargin.Left = (float) A_0.TextBox.method_0();
                box.Format.InternalMargin.Right = (float) A_0.TextBox.method_2();
                box.Format.InternalMargin.Top = (float) A_0.TextBox.method_4();
                box.Format.LayoutFlowAlt = this.method_72(A_0.TextBox.method_10());
            }
            return box;
        }

        internal TextDirection method_72(LayoutFlow A_0)
        {
            switch (A_0)
            {
                case LayoutFlow.TopToBottomIdeographic:
                    return TextDirection.RightToLeftRotated;

                case LayoutFlow.BottomToTop:
                    return TextDirection.LeftToRight;

                case LayoutFlow.TopToBottom:
                    return TextDirection.RightToLeft;

                case LayoutFlow.HorizontalIdeographic:
                    return TextDirection.TopToBottomRotated;

                case LayoutFlow.Vertical:
                    return TextDirection.LeftToRightRotated;
            }
            return TextDirection.TopToBottom;
        }

        private ShapeVerticalAlignment method_73(TextBoxAnchor A_0)
        {
            switch (A_0)
            {
                case TextBoxAnchor.Middle:
                    return ShapeVerticalAlignment.Center;

                case TextBoxAnchor.Bottom:
                    return ShapeVerticalAlignment.Bottom;
            }
            return ShapeVerticalAlignment.Top;
        }

        private DocumentObject method_74()
        {
            DocumentObject owner = base.Owner;
            while (owner != null)
            {
                if (owner is Paragraph)
                {
                    return owner;
                }
                owner = owner.Owner;
            }
            return owner;
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 11;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("砰䀲紴制堸强堼䴾", 11)))
            {
                this.bool_9 = reader.ReadBoolean(BookmarkStart.b("砰䀲紴制堸强堼䴾", num));
            }
        }

        internal static bool smethod_1(ShapeObject A_0)
        {
            if (A_0 == null)
            {
                return false;
            }
            if (!A_0.Filled)
            {
                return A_0.HasImage;
            }
            return true;
        }

        internal static ShapeObject smethod_2(Document A_0)
        {
            ShapeObject obj2 = new ShapeObject(A_0, ShapeType.Rectangle) {
                TextWrappingStyle = TextWrappingStyle.Inline,
                Filled = true,
                FillColor = Class628.color_0,
                Stroked = false
            };
            obj2.HorizontalRule.method_1(true);
            obj2.HorizontalRule.method_5(true);
            obj2.Height = 1.5;
            if (A_0.Sections.Count > 0)
            {
                obj2.method_37((double) A_0.Sections[0].PageSetup.ClientWidth);
            }
            obj2.HorizontalRule.method_9(100.0);
            return obj2;
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            dc.method_215(this, ltWidget);
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            return dc.method_214(this);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("娭䤯䈱儳", 8), ParagraphItemType.ShapeObject);
            writer.WriteValue(BookmarkStart.b("札䌯稱儳圵尷弹主", 8), this.bool_9);
        }

        internal TextBoxItemCollection AutoShapeTextCollection
        {
            get
            {
                return this.textBoxItemCollection_0;
            }
        }

        internal Spire.Doc.Fields.Shape.BWMode BWMode
        {
            get
            {
                return (Spire.Doc.Fields.Shape.BWMode) base.GetShapeAttribute(0x304);
            }
            set
            {
                base.SetShapeAttribute(0x304, value);
            }
        }

        internal Spire.Doc.Fields.Shape.BWMode BWNormal
        {
            get
            {
                return (Spire.Doc.Fields.Shape.BWMode) base.GetShapeAttribute(0x306);
            }
            set
            {
                base.SetShapeAttribute(0x306, value);
            }
        }

        internal Spire.Doc.Fields.Shape.BWMode BWPure
        {
            get
            {
                return (Spire.Doc.Fields.Shape.BWMode) base.GetShapeAttribute(0x305);
            }
            set
            {
                base.SetShapeAttribute(0x305, value);
            }
        }

        public override Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return base.m_charFormat;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                if (((base.ShapeType != ShapeType.TextBox) && (!base.CanHaveInternalTextbox || (this.InternerTextbox.ChildObjects.Count <= 0))) && !base.IsTextbox)
                {
                    return base.ChildObjects;
                }
                return this.InternerTextbox.ChildObjects;
            }
        }

        internal bool CompleteExtractionOfEmbeddedTextbox
        {
            [CompilerGenerated]
            get
            {
                return this.bool_10;
            }
            [CompilerGenerated]
            set
            {
                this.bool_10 = value;
            }
        }

        internal Spire.Doc.Fields.Shape.ConnectorType ConnectorType
        {
            get
            {
                return base.ConnectorType;
            }
            set
            {
                base.ConnectorType = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Shape;
            }
        }

        internal int ExtrusionBackDepth
        {
            get
            {
                return (int) base.GetShapeAttribute(0x285);
            }
        }

        internal int ExtrusionForeDepth
        {
            get
            {
                return (int) base.GetShapeAttribute(0x284);
            }
        }

        internal bool ExtrusionOn
        {
            get
            {
                return (bool) base.GetShapeAttribute(700);
            }
            set
            {
                base.SetShapeAttribute(700, value);
            }
        }

        internal int ExtrusionSkewAngle
        {
            get
            {
                return (int) base.GetShapeAttribute(720);
            }
        }

        internal VMLFill Fill
        {
            get
            {
                if (this.vmlfill_0 == null)
                {
                    this.vmlfill_0 = new VMLFill(this);
                }
                return this.vmlfill_0;
            }
        }

        public Color FillColor
        {
            get
            {
                return this.Fill.Color;
            }
            set
            {
                this.Fill.Color = value;
            }
        }

        internal bool Filled
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x1bb);
            }
            set
            {
                base.SetShapeAttribute(0x1bb, value);
            }
        }

        internal bool ForceDash
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x1ff);
            }
            set
            {
                base.SetShapeAttribute(0x1ff, value);
            }
        }

        internal Class456[] Formulas
        {
            get
            {
                return (Class456[]) base.GetShapeAttribute(0x156);
            }
        }

        internal Class784[] Handles
        {
            get
            {
                return (Class784[]) base.GetShapeAttribute(0x155);
            }
        }

        public bool HasImage
        {
            get
            {
                return (base.CanHaveImage && this.ImageData.HasImage);
            }
        }

        internal bool HasImageBytes
        {
            get
            {
                return (base.CanHaveImage && this.ImageData.HasImage);
            }
        }

        internal bool HasInternalTextbox
        {
            get
            {
                return (base.CanHaveInternalTextbox && (this.InternerTextbox.ChildObjects.Count > 0));
            }
        }

        internal float HeightPercent
        {
            get
            {
                return (float) base.HeightPercent;
            }
            set
            {
                base.HeightPercent = value;
            }
        }

        internal Class628 HorizontalRule
        {
            get
            {
                if (this.class628_0 == null)
                {
                    this.class628_0 = new Class628(this);
                }
                return this.class628_0;
            }
        }

        internal DocPicture ImageData
        {
            get
            {
                if (!base.CanHaveImage)
                {
                    return null;
                }
                if (this.docPicture_0 == null)
                {
                    this.docPicture_0 = new DocPicture(base.Document, this);
                    this.docPicture_0.m_charFormat = base.m_charFormat;
                }
                return this.docPicture_0;
            }
            set
            {
                this.docPicture_0 = value;
            }
        }

        internal Color ImageRecolor
        {
            get
            {
                object directShapeAttribute = base.GetDirectShapeAttribute(0x11a);
                if ((directShapeAttribute != null) && (((int) directShapeAttribute) != -1))
                {
                    return Color.FromArgb(((int) directShapeAttribute) | -16777216);
                }
                return Color.Empty;
            }
        }

        internal Spire.Doc.Fields.TextBox InternerTextbox
        {
            get
            {
                if (!base.CanHaveInternalTextbox)
                {
                    return null;
                }
                if (this.textBox_0 == null)
                {
                    this.textBox_0 = new Spire.Doc.Fields.TextBox(base.Document, this);
                }
                return this.textBox_0;
            }
            set
            {
                this.textBox_0 = value;
            }
        }

        internal bool IsFitTextboxToText
        {
            get
            {
                return (bool) base.GetShapeAttribute(190);
            }
            set
            {
                base.SetShapeAttribute(190, value);
            }
        }

        internal bool IsHeaderAutoShape
        {
            get
            {
                return this.bool_9;
            }
            set
            {
                this.bool_9 = value;
            }
        }

        internal bool IsOoxmlControl
        {
            get
            {
                return base.IsOleControl;
            }
        }

        internal bool IsParallelExtrusion
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x2fd);
            }
        }

        internal bool IsStroked
        {
            get
            {
                return (bool) base.GetShapeAttribute(380);
            }
        }

        internal bool IsTextureRotated
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x1ba);
            }
        }

        internal int LimoX
        {
            get
            {
                return (int) base.GetShapeAttribute(0x153);
            }
            set
            {
                base.SetShapeAttribute(0x153, value);
            }
        }

        internal int LimoY
        {
            get
            {
                return (int) base.GetShapeAttribute(340);
            }
            set
            {
                base.SetShapeAttribute(340, value);
            }
        }

        public ShapeLineStyle LineStyle
        {
            get
            {
                return this.Stroke.method_20();
            }
            set
            {
                this.Stroke.method_21(value);
            }
        }

        internal float LineWidth
        {
            get
            {
                return (float) Class969.smethod_42((int) base.GetShapeAttribute(0x1cb));
            }
        }

        internal DocOleObject OleFormat
        {
            get
            {
                if (!base.IsOle)
                {
                    return null;
                }
                if (this.docOleObject_0 == null)
                {
                    this.docOleObject_0 = new DocOleObject(base.Document, this);
                }
                return this.docOleObject_0;
            }
            set
            {
                this.docOleObject_0 = value;
            }
        }

        internal ShapeOleObjectType OleObjectType
        {
            get
            {
                if (base.IsOleControl)
                {
                    return ShapeOleObjectType.Control;
                }
                if (!base.IsOleObject)
                {
                    return ShapeOleObjectType.None;
                }
                if (this.OleFormat.Interface49.get_LinkType() != OleLinkType.Link)
                {
                    return ShapeOleObjectType.Embedded;
                }
                return ShapeOleObjectType.Linked;
            }
        }

        internal Field OwnerHyperlinkField
        {
            [CompilerGenerated]
            get
            {
                return this.field_0;
            }
            [CompilerGenerated]
            set
            {
                this.field_0 = value;
            }
        }

        internal DocumentObject ParentContainer
        {
            [CompilerGenerated]
            get
            {
                return this.documentObject_0;
            }
            [CompilerGenerated]
            set
            {
                this.documentObject_0 = value;
            }
        }

        internal bool PreferRelative
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x33b);
            }
            set
            {
                base.SetShapeAttribute(0x33b, value);
            }
        }

        internal ThreeDRenderMode RenderMode
        {
            get
            {
                return (ThreeDRenderMode) base.GetShapeAttribute(0x2c9);
            }
        }

        internal string ScriptText
        {
            get
            {
                return (string) base.GetShapeAttribute(910);
            }
            set
            {
                int num = 0;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("倥䤧䘩夫䬭", num));
                }
                base.SetShapeAttribute(910, value);
            }
        }

        internal string ScriptType
        {
            get
            {
                return (string) base.GetShapeAttribute(0x397);
            }
            set
            {
                int num = 6;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("娫伭尯䜱儳", num));
                }
                base.SetShapeAttribute(0x397, value);
            }
        }

        internal Class679[] SegmentInfo
        {
            get
            {
                return (Class679[]) base.GetShapeAttribute(0x146);
            }
        }

        internal bool ShadowOn
        {
            get
            {
                return (bool) base.GetShapeAttribute(0x23e);
            }
            set
            {
                base.SetShapeAttribute(0x23e, value);
            }
        }

        internal Class626 SignatureLine
        {
            get
            {
                if (base.GetDirectShapeAttribute(0x7bf) == null)
                {
                    return null;
                }
                if (this.class626_0 == null)
                {
                    this.class626_0 = new Class626(this);
                }
                return this.class626_0;
            }
        }

        internal PointF StartPoint
        {
            [CompilerGenerated]
            get
            {
                return this.pointF_0;
            }
            [CompilerGenerated]
            set
            {
                this.pointF_0 = value;
            }
        }

        internal Class826 Stroke
        {
            get
            {
                if (this.class826_0 == null)
                {
                    this.class826_0 = new Class826(this);
                }
                return this.class826_0;
            }
        }

        public Color StrokeColor
        {
            get
            {
                return this.Stroke.method_4();
            }
            set
            {
                this.Stroke.method_5(value);
            }
        }

        internal bool Stroked
        {
            get
            {
                return this.Stroke.method_0();
            }
            set
            {
                this.Stroke.method_1(value);
            }
        }

        public double StrokeWeight
        {
            get
            {
                return this.Stroke.method_2();
            }
            set
            {
                this.Stroke.method_3(value);
            }
        }

        internal int TDRotationAngleX
        {
            get
            {
                return (int) base.GetShapeAttribute(0x2c1);
            }
        }

        internal int TDRotationAngleY
        {
            get
            {
                return (int) base.GetShapeAttribute(0x2c0);
            }
        }

        internal Class1076 TextBox
        {
            get
            {
                if (this.class1076_0 == null)
                {
                    this.class1076_0 = new Class1076(this);
                }
                return this.class1076_0;
            }
        }

        internal Class70[] TextBoxRects
        {
            get
            {
                Class70[] shapeAttribute = (Class70[]) base.GetShapeAttribute(0x157);
                if ((shapeAttribute != null) && (shapeAttribute.Length > 0))
                {
                    return shapeAttribute;
                }
                Class70 class2 = new Class70 {
                    class623_0 = new Class623(-base.CoordOriginX, false),
                    class623_1 = new Class623(-base.CoordOriginY, false),
                    class623_2 = new Class623(base.CoordSizeWidth - base.CoordOriginX, false),
                    class623_3 = new Class623(base.CoordSizeHeight - base.CoordOriginY, false)
                };
                return new Class70[] { class2 };
            }
            set
            {
                base.SetShapeAttribute(0x157, value);
            }
        }

        internal Class891[] Vertices
        {
            get
            {
                return (Class891[]) base.GetShapeAttribute(0x145);
            }
        }

        internal int ViewpointOriginX
        {
            get
            {
                return (int) base.GetShapeAttribute(0x2ce);
            }
        }

        internal int ViewpointOriginY
        {
            get
            {
                return (int) base.GetShapeAttribute(0x2cf);
            }
        }

        internal int ViewpointX
        {
            get
            {
                return (int) base.GetShapeAttribute(0x2cb);
            }
        }

        internal int ViewpointY
        {
            get
            {
                return (int) base.GetShapeAttribute(0x2cc);
            }
        }

        internal int ViewpointZ
        {
            get
            {
                return (int) base.GetShapeAttribute(0x2cd);
            }
        }

        internal float WidthPercent
        {
            get
            {
                return (float) base.WidthPercent;
            }
            set
            {
                base.WidthPercent = value;
            }
        }

        public Spire.Doc.Fields.WordArt WordArt
        {
            get
            {
                if (this.wordArt_0 == null)
                {
                    this.wordArt_0 = new Spire.Doc.Fields.WordArt(this);
                }
                return this.wordArt_0;
            }
        }
    }
}

