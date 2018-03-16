namespace Spire.Doc.Fields.Shape
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Core.DataStreamParser.Escher;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class ShapeBase : ParagraphBase, Interface0, ICompositeObject
    {
        private bool bool_7;
        [CompilerGenerated]
        private bool bool_8;
        private Class43 class43_0;
        private DocumentObjectCollection documentObjectCollection_0;
        internal static double double_0 = 20116800.0;
        internal static double double_1 = 0.75;
        private Image image_0;
        internal const int int_4 = 0x400;
        internal const int int_5 = 0x400;
        private int int_6;
        private int? nullable_0;

        internal ShapeBase(Document A_0) : base(A_0)
        {
            this.class43_0 = new Class43();
            this.documentObjectCollection_0 = new ShapeItemCollection(A_0, this);
        }

        protected override object CloneImpl()
        {
            ShapeBase base2 = (ShapeBase) base.CloneImpl();
            base2.ShapePr = (Class43) base2.ShapePr.Clone();
            base2.bool_4 = true;
            return base2;
        }

        internal override void Close()
        {
            base.Close();
            if (this.image_0 != null)
            {
                this.image_0.Dispose();
                this.image_0 = null;
            }
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_5(false);
            base.interface23_0.imethod_3(false);
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

        public PointF LocalToParent(PointF value)
        {
            value = new PointF(value.X - this.CoordOrigin.X, value.Y - this.CoordOrigin.Y);
            value = new PointF((float) (value.X * (this.Width / ((double) this.CoordSize.Width))), (float) (value.Y * (this.Height / ((double) this.CoordSize.Height))));
            value = new PointF(value.X + ((float) this.Left), value.Y + ((float) this.Top));
            return value;
        }

        internal Class218 method_30()
        {
            return new Class218(this);
        }

        internal Image method_31()
        {
            if (this.image_0 == null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    this.method_30().method_5(stream);
                    this.image_0 = Image.FromStream(stream);
                }
            }
            return this.image_0;
        }

        internal void method_32(Graphics A_0)
        {
            Class450 class2 = new Class450();
            Class724 class3 = new Class724(this);
            spr➓ r➓ = Class220.smethod_0(class3, null);
            class2.method_0(r➓, A_0);
        }

        internal void method_33(Graphics A_0, PointF A_1)
        {
            Class450 class2 = new Class450();
            Class724 class3 = new Class724(this);
            spr➓ r➓ = Class220.smethod_0(class3, null);
            class2.method_1(r➓, A_0, A_1);
        }

        internal bool method_34()
        {
            bool flag;
            if (this.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Shape)
            {
                return (this.ChildObjects.Count > 0);
            }
            using (List<ShapeObject>.Enumerator enumerator = this.method_35(Spire.Doc.Documents.DocumentObjectType.Shape).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ShapeObject current = enumerator.Current;
                    if (current.ChildObjects.Count > 0)
                    {
                        goto Label_004B;
                    }
                }
                return false;
            Label_004B:
                flag = true;
            }
            return flag;
        }

        private List<ShapeObject> method_35(Spire.Doc.Documents.DocumentObjectType A_0)
        {
            List<ShapeObject> list = new List<ShapeObject>();
            foreach (DocumentObject obj2 in this.ChildObjects)
            {
                if (obj2.DocumentObjectType == A_0)
                {
                    list.Add((ShapeObject) obj2);
                }
            }
            return list;
        }

        internal void method_36(double A_0, double A_1)
        {
            this.method_37(A_0);
            this.method_39(A_1);
        }

        internal void method_37(double A_0)
        {
            this.method_38(A_0, false);
        }

        private void method_38(double A_0, bool A_1)
        {
            this.SetShapeAttribute(0x1023, this.method_42(A_0, A_1, BookmarkStart.b("儥䄧丩堫䘭", 0)));
        }

        internal void method_39(double A_0)
        {
            this.method_40(A_0, false);
        }

        private void method_40(double A_0, bool A_1)
        {
            this.SetShapeAttribute(0x1024, this.method_42(A_0, A_1, BookmarkStart.b("䄨个䐬䠮夰䜲", 3)));
        }

        internal void method_41()
        {
            this.method_37(this.Width);
            this.method_39(this.Height);
        }

        private double method_42(double A_0, bool A_1, string A_2)
        {
            int num = 5;
            if (A_0 < 0.0)
            {
                if (A_1)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("崪䰬䌮䐰嘲", num), string.Format(BookmarkStart.b("砪䔬丮䄰嘲ᔴ䰶स䘺ᴼ尾⁀ⵂ⭄⡆㵈歊⽌⩎煐㽒ご⑖⩘筚⥜㝞`ൢ䕤坦䝨", num), A_2));
                }
                return 0.0;
            }
            if ((A_0 <= double_0) || !this.IsTopLevel)
            {
                return A_0;
            }
            if (base.ParentObject == null)
            {
                return A_0;
            }
            if (A_1)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("崪䰬䌮䐰嘲", num), string.Format(BookmarkStart.b("砪䔬丮䄰嘲ᔴ䰶स䘺ᴼ尾⁀ⵂ⭄⡆㵈歊⽌⩎煐㑒❔㉖㡘⽚㡜ⵞ䅠ᝢ൤٦ݨ䭪ᙬ幮౰卲մᡶၸᕺॼ౾꾀", num), A_2, Class1041.smethod_44(double_0)));
            }
            return double_1;
        }

        internal bool method_43()
        {
            Class891[] classArray = (Class891[]) this.ShapePr.method_31(0x145);
            return ((((this.ShapeType == Spire.Doc.Documents.ShapeType.NonPrimitive) && Class1133.smethod_7(this.Width)) && (Class1133.smethod_7(this.Height) && (classArray != null))) && (classArray.Length > 0));
        }

        internal void method_44()
        {
            Class891[] classArray = (Class891[]) this.ShapePr.method_31(0x145);
            PointF[] tfArray = smethod_0(classArray);
            if (tfArray != null)
            {
                RectangleF ef = this.method_45(tfArray);
                this.Width = Class969.smethod_33((double) ef.Width);
                this.Height = Class969.smethod_33((double) ef.Height);
                this.Left = Class969.smethod_33((double) ef.X);
                this.Top = Class969.smethod_33((double) ef.Y);
                for (int i = 0; i < classArray.Length; i++)
                {
                    classArray[i] = new Class891(classArray[i].method_0().method_1() - ((int) ef.X), classArray[i].method_1().method_1() - ((int) ef.Y));
                }
                this.SetShapeAttribute(0x145, classArray);
            }
        }

        private RectangleF method_45(PointF[] A_0)
        {
            if ((A_0 == null) || (A_0.Length == 0))
            {
                return RectangleF.Empty;
            }
            float x = A_0[0].X;
            float num3 = x;
            float y = A_0[0].Y;
            float num = y;
            for (int i = 0; i < A_0.Length; i++)
            {
                PointF tf = A_0[i];
                if (tf.X > x)
                {
                    x = tf.X;
                }
                else if (tf.X < num3)
                {
                    num3 = tf.X;
                }
                if (tf.Y > y)
                {
                    y = tf.Y;
                }
                else if (tf.Y < num)
                {
                    num = tf.Y;
                }
            }
            return new RectangleF(num3, num, x - num3, y - num);
        }

        internal void method_46()
        {
            if (this.IsHorizontalRule && this.ShapePr.HasKey(0x395))
            {
                this.method_39(Class969.smethod_32((int) this.GetDirectShapeAttribute(0x395)));
                this.RemoveShapeAttribute(0x395);
            }
        }

        internal RectangleF method_47(RectangleF A_0)
        {
            PointF tf = this.method_48(A_0.Location);
            PointF tf2 = this.method_48(new PointF(A_0.Right, A_0.Bottom));
            return new RectangleF(tf.X, tf.Y, tf2.X - tf.X, tf2.Y - tf.Y);
        }

        internal PointF method_48(PointF A_0)
        {
            for (DocumentObject obj2 = base.ParentObject; obj2 is ShapeBase; obj2 = obj2.Owner)
            {
                A_0 = ((ShapeBase) obj2).LocalToParent(A_0);
            }
            return A_0;
        }

        internal spr➓ method_49()
        {
            new Class450();
            Class724 class2 = new Class724(this);
            return Class220.smethod_0(class2, null);
        }

        internal void method_50(Graphics A_0, bool A_1)
        {
            Class450 class2 = new Class450 {
                bool_0 = A_1
            };
            Class724 class3 = new Class724(this);
            spr➓ r➓ = Class220.smethod_0(class3, null);
            class2.method_0(r➓, A_0);
        }

        internal void method_51()
        {
            if (this.IsTopLevel)
            {
                Section section = (Section) base.method_7(Spire.Doc.Documents.DocumentObjectType.Section);
                if (section == null)
                {
                    if (this.ShapeType == Spire.Doc.Documents.ShapeType.TextBox)
                    {
                        section = (this as ShapeObject).InternerTextbox.method_2();
                    }
                    else if ((this.ShapeType != Spire.Doc.Documents.ShapeType.Image) && !(this as ShapeObject).HasImage)
                    {
                        if (this.ShapeType == Spire.Doc.Documents.ShapeType.OleObject)
                        {
                            section = (this as ShapeObject).OleFormat.method_2();
                        }
                    }
                    else
                    {
                        section = (this as ShapeObject).ImageData.method_2();
                    }
                }
                if (section != null)
                {
                    PageSetup pageSetup = section.PageSetup;
                    this.method_52(pageSetup);
                    this.method_53(pageSetup);
                    this.method_54(pageSetup);
                    this.method_55(pageSetup);
                }
            }
        }

        private void method_52(PageSetup A_0)
        {
            object leftPercent = this.LeftPercent;
            if (leftPercent != null)
            {
                double num = ((double) ((float) leftPercent)) / 1000.0;
                switch (this.HorizontalOrigin)
                {
                    case Spire.Doc.Documents.HorizontalOrigin.Margin:
                        this.Left = A_0.ClientWidth * num;
                        return;

                    case Spire.Doc.Documents.HorizontalOrigin.Page:
                        this.Left = A_0.PageSize.Width * num;
                        return;

                    case Spire.Doc.Documents.HorizontalOrigin.Column:
                    case Spire.Doc.Documents.HorizontalOrigin.Character:
                        return;

                    case Spire.Doc.Documents.HorizontalOrigin.LeftMarginArea:
                    case Spire.Doc.Documents.HorizontalOrigin.OuterMarginArea:
                        this.Left = A_0.Margins.Left * num;
                        return;

                    case Spire.Doc.Documents.HorizontalOrigin.RightMarginArea:
                    case Spire.Doc.Documents.HorizontalOrigin.InnerMarginArea:
                        this.Left = A_0.Margins.Right * num;
                        return;
                }
            }
        }

        private void method_53(PageSetup A_0)
        {
            object topPercent = this.TopPercent;
            if (topPercent != null)
            {
                double num = ((double) ((float) topPercent)) / 1000.0;
                switch (this.VerticalOrigin)
                {
                    case Spire.Doc.Documents.VerticalOrigin.Margin:
                        this.Top = A_0.ClientWidth * num;
                        return;

                    case Spire.Doc.Documents.VerticalOrigin.Page:
                        this.Top = A_0.PageSize.Height * num;
                        return;

                    case Spire.Doc.Documents.VerticalOrigin.Paragraph:
                    case Spire.Doc.Documents.VerticalOrigin.Line:
                        return;

                    case Spire.Doc.Documents.VerticalOrigin.TopMarginArea:
                    case Spire.Doc.Documents.VerticalOrigin.InnerMarginArea:
                    case Spire.Doc.Documents.VerticalOrigin.OuterMarginArea:
                        this.Top = A_0.Margins.Top * num;
                        return;

                    case Spire.Doc.Documents.VerticalOrigin.BottomMarginArea:
                        this.Top = A_0.Margins.Bottom * num;
                        return;
                }
            }
        }

        private void method_54(PageSetup A_0)
        {
            object widthPercent = this.WidthPercent;
            if (widthPercent != null)
            {
                double num = ((double) ((float) widthPercent)) / 1000.0;
                if ((num > 0.0) && ((!(this is TextBox) || !this.ShapePr.HasKey(0x1023)) || (((this as TextBox).Format.LayoutFlowAlt == TextDirection.TopToBottom) || ((this as TextBox).Format.LayoutFlowAlt == TextDirection.TopToBottomRotated))))
                {
                    switch (this.RelativeWidth)
                    {
                        case Spire.Doc.RelativeWidth.Margin:
                            this.Width = A_0.ClientWidth * num;
                            return;

                        case Spire.Doc.RelativeWidth.Page:
                            this.Width = A_0.PageSize.Width * num;
                            return;

                        case Spire.Doc.RelativeWidth.LeftMargin:
                        case Spire.Doc.RelativeWidth.OutsideMargin:
                            this.Width = A_0.Margins.Left * num;
                            return;

                        case Spire.Doc.RelativeWidth.RightMargin:
                        case Spire.Doc.RelativeWidth.InsideMargin:
                            this.Width = A_0.Margins.Right * num;
                            return;
                    }
                }
            }
        }

        private void method_55(PageSetup A_0)
        {
            object heightPercent = this.HeightPercent;
            if (heightPercent != null)
            {
                double num = ((double) ((float) heightPercent)) / 1000.0;
                if (num > 0.0)
                {
                    switch (this.RelativeHeight)
                    {
                        case Spire.Doc.RelativeHeight.Margin:
                            this.Height = A_0.ClientHeight * num;
                            return;

                        case Spire.Doc.RelativeHeight.Page:
                            this.Height = A_0.PageSize.Height * num;
                            return;

                        case Spire.Doc.RelativeHeight.TopMargin:
                        case Spire.Doc.RelativeHeight.InsideMargin:
                        case Spire.Doc.RelativeHeight.OutsideMargin:
                            this.Height = A_0.Margins.Top * num;
                            return;

                        case Spire.Doc.RelativeHeight.BottomMargin:
                            this.Height = A_0.Margins.Bottom * num;
                            return;
                    }
                }
            }
        }

        internal void method_56(System.Drawing.Size A_0)
        {
            this.method_57(A_0.Width);
            this.method_58(A_0.Height);
        }

        internal void method_57(int A_0)
        {
            this.method_59(0x101f, A_0);
        }

        internal void method_58(int A_0)
        {
            this.method_59(0x1020, A_0);
        }

        private void method_59(int A_0, int A_1)
        {
            if (A_1 <= 0)
            {
                A_1 = (int) this.GetInheritedShapeAttribute(A_0);
            }
            this.SetShapeAttribute(A_0, A_1);
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

        public void SetShapeType(Spire.Doc.Documents.ShapeType shapeType)
        {
            this.SetShapeAttribute(0x103b, shapeType);
        }

        private static PointF[] smethod_0(Class891[] A_0)
        {
            if ((A_0 == null) || (A_0.Length <= 0))
            {
                return null;
            }
            PointF[] tfArray = new PointF[A_0.Length];
            for (int i = 0; i < A_0.Length; i++)
            {
                Class891 class2 = A_0[i];
                tfArray[i] = new PointF((float) class2.method_0().method_1(), (float) class2.method_1().method_1());
            }
            return tfArray;
        }

        internal bool AllowInCell
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x3b0);
            }
            set
            {
                this.SetShapeAttribute(0x3b0, value);
            }
        }

        public bool AllowOverlap
        {
            get
            {
                return (bool) this.GetShapeAttribute(950);
            }
            set
            {
                this.SetShapeAttribute(950, value);
            }
        }

        internal string AlternativeText
        {
            get
            {
                return (string) this.GetShapeAttribute(0x381);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("弨䨪䄬娮吰", 3));
                this.SetShapeAttribute(0x381, value);
            }
        }

        internal bool AnchorLocked
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x1003);
            }
            set
            {
                this.SetShapeAttribute(0x1003, value);
            }
        }

        public bool BehindText
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x3ba);
            }
            set
            {
                this.SetShapeAttribute(0x3ba, value);
            }
        }

        public double Bottom
        {
            get
            {
                return (this.Top + this.Height);
            }
        }

        [ComVisible(false)]
        internal RectangleF Bounds
        {
            get
            {
                return new RectangleF((float) this.Left, (float) this.Top, (float) this.Width, (float) this.Height);
            }
            set
            {
                this.Left = value.Left;
                this.Top = value.Top;
                this.Width = value.Width;
                this.Height = value.Height;
            }
        }

        [ComVisible(false)]
        internal RectangleF BoundsInPoints
        {
            get
            {
                return this.method_47(this.Bounds);
            }
        }

        internal bool CanHaveImage
        {
            get
            {
                if (this.ShapeType == Spire.Doc.Documents.ShapeType.Group)
                {
                    return false;
                }
                return true;
            }
        }

        internal bool CanHaveInternalTextbox
        {
            get
            {
                if (this.ShapeType == Spire.Doc.Documents.ShapeType.Group)
                {
                    return false;
                }
                return true;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.documentObjectCollection_0;
            }
        }

        internal Spire.Doc.Fields.Shape.ConnectorType ConnectorType
        {
            get
            {
                return (Spire.Doc.Fields.Shape.ConnectorType) this.GetShapeAttribute(0x303);
            }
            set
            {
                this.SetShapeAttribute(0x303, value);
            }
        }

        internal Point CoordOrigin
        {
            get
            {
                return new Point(this.CoordOriginX, this.CoordOriginY);
            }
            set
            {
                this.CoordOriginX = value.X;
                this.CoordOriginY = value.Y;
            }
        }

        internal int CoordOriginX
        {
            get
            {
                return (int) this.GetShapeAttribute(0x101d);
            }
            set
            {
                this.SetShapeAttribute(0x101d, value);
            }
        }

        internal int CoordOriginY
        {
            get
            {
                return (int) this.GetShapeAttribute(0x101e);
            }
            set
            {
                this.SetShapeAttribute(0x101e, value);
            }
        }

        internal System.Drawing.Size CoordSize
        {
            get
            {
                return new System.Drawing.Size(this.CoordSizeWidth, this.CoordSizeHeight);
            }
            set
            {
                int num = 2;
                if ((value.Width <= 0) || (value.Height <= 0))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("帧䬩䀫嬭唯", num), BookmarkStart.b("搧䔩伫伭尯ሱ圳夵圷䠹堻圽⸿⍁ぃ⍅桇㥉㱋⽍㍏㝑瑓╕ㅗ⁙㥛繝͟͡੣ࡥݧṩ䱫౭ᕯ剱ᡳ፵୷ॹ屻੽ꚅ겋歹뢗뺝\uda9f\uc7a1횣즥蚧", num));
                }
                this.method_56(value);
            }
        }

        internal int CoordSizeHeight
        {
            get
            {
                return (((int) this.GetShapeAttribute(0x1020)) / this.NumLevel);
            }
        }

        internal int CoordSizeWidth
        {
            get
            {
                return (((int) this.GetShapeAttribute(0x101f)) / this.NumLevel);
            }
        }

        public double DistanceBottom
        {
            get
            {
                return Class969.smethod_42((int) this.GetShapeAttribute(0x387));
            }
            set
            {
                this.SetShapeAttribute(0x387, Class969.smethod_40(value));
            }
        }

        public double DistanceLeft
        {
            get
            {
                return Class969.smethod_42((int) this.GetShapeAttribute(900));
            }
            set
            {
                this.SetShapeAttribute(900, Class969.smethod_40(value));
            }
        }

        public double DistanceRight
        {
            get
            {
                return Class969.smethod_42((int) this.GetShapeAttribute(0x386));
            }
            set
            {
                this.SetShapeAttribute(0x386, Class969.smethod_40(value));
            }
        }

        public double DistanceTop
        {
            get
            {
                return Class969.smethod_42((int) this.GetShapeAttribute(0x385));
            }
            set
            {
                this.SetShapeAttribute(0x385, Class969.smethod_40(value));
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Shape;
            }
        }

        internal Spire.Doc.Core.DataStreamParser.Escher.FlipOrientation FlipOrientation
        {
            get
            {
                return (Spire.Doc.Core.DataStreamParser.Escher.FlipOrientation) this.GetShapeAttribute(0x1000);
            }
            set
            {
                this.SetShapeAttribute(0x1000, value);
            }
        }

        internal System.Drawing.Font Font
        {
            get
            {
                return null;
            }
        }

        internal double HalfHeight
        {
            get
            {
                return (this.Height / 2.0);
            }
        }

        internal double HalfWidth
        {
            get
            {
                return (this.Width / 2.0);
            }
        }

        internal bool HasHyperlink
        {
            get
            {
                return Class567.smethod_16(this.HRef);
            }
        }

        public double Height
        {
            get
            {
                return (double) this.GetShapeAttribute(0x1024);
            }
            set
            {
                this.method_40(value, true);
            }
        }

        internal object HeightPercent
        {
            get
            {
                return this.GetShapeAttribute(0x7c1);
            }
            set
            {
                this.SetShapeAttribute(0x7c1, value);
            }
        }

        internal bool Hidden
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x3be);
            }
            set
            {
                this.SetShapeAttribute(0x3be, value);
            }
        }

        public virtual ShapeHorizontalAlignment HorizontalAlignment
        {
            get
            {
                return (ShapeHorizontalAlignment) this.GetShapeAttribute(0x38f);
            }
            set
            {
                this.SetShapeAttribute(0x38f, value);
            }
        }

        public virtual Spire.Doc.Documents.HorizontalOrigin HorizontalOrigin
        {
            get
            {
                return (Spire.Doc.Documents.HorizontalOrigin) this.GetShapeAttribute(0x390);
            }
            set
            {
                this.SetShapeAttribute(0x390, value);
            }
        }

        public virtual float HorizontalPosition
        {
            get
            {
                return Convert.ToSingle(this.Left);
            }
            set
            {
                this.Left = value;
            }
        }

        internal string HRef
        {
            get
            {
                return (string) this.GetShapeAttribute(0x382);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("䌴嘶唸为堼", 15));
                this.SetShapeAttribute(0x382, value);
            }
        }

        internal string HyperlinkAddress
        {
            get
            {
                return Class736.smethod_2(this.HRef);
            }
        }

        internal string HyperlinkSubAddress
        {
            get
            {
                return Class736.smethod_3(this.HRef);
            }
        }

        internal int Id
        {
            get
            {
                return (int) this.GetShapeAttribute(0x101c);
            }
            set
            {
                this.SetShapeAttribute(0x101c, value);
            }
        }

        internal bool InkAnnotation
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x73f);
            }
        }

        internal byte[] InkData
        {
            get
            {
                return (byte[]) this.GetDirectShapeAttribute(0x700);
            }
        }

        private bool IsBelowTextEx
        {
            get
            {
                if (!((bool) this.GetShapeAttribute(0x3ba)))
                {
                    return (this.TextWrappingStyle == Spire.Doc.Documents.TextWrappingStyle.Behind);
                }
                return true;
            }
        }

        internal bool IsConnector
        {
            get
            {
                return (this.ConnectorType != Spire.Doc.Fields.Shape.ConnectorType.None);
            }
        }

        private bool IsCustomShape
        {
            get
            {
                return (this.ShapeType == Spire.Doc.Documents.ShapeType.CustomShape);
            }
        }

        internal bool IsDummy
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x101b);
            }
            set
            {
                if (value)
                {
                    this.SetShapeAttribute(0x101b, true);
                }
            }
        }

        internal bool IsGroup
        {
            get
            {
                return (this.ShapeType == Spire.Doc.Documents.ShapeType.Group);
            }
        }

        internal bool IsHorizontalRule
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x3b4);
            }
        }

        internal bool IsHyperlinkedInline
        {
            get
            {
                if (!this.IsInline || !this.HasHyperlink)
                {
                    return false;
                }
                if (!this.IsImage)
                {
                    return this.IsOleObject;
                }
                return true;
            }
        }

        public bool IsImage
        {
            get
            {
                return (this.ShapeType == Spire.Doc.Documents.ShapeType.Image);
            }
        }

        internal bool IsInline
        {
            get
            {
                return (this.TextWrappingStyle == Spire.Doc.Documents.TextWrappingStyle.Inline);
            }
        }

        internal bool IsNeedDummyWhenInline
        {
            get
            {
                return (((!this.IsImage && !this.IsOle) && (!this.IsHorizontalRule && !this.IsWordArt)) && !this.IsCustomShape);
            }
        }

        internal bool IsOle
        {
            get
            {
                if (!this.IsOleObject)
                {
                    return this.IsOleControl;
                }
                return true;
            }
        }

        internal bool IsOleControl
        {
            get
            {
                return (this.ShapeType == Spire.Doc.Documents.ShapeType.OleControl);
            }
        }

        internal bool IsOleObject
        {
            get
            {
                return (this.ShapeType == Spire.Doc.Documents.ShapeType.OleObject);
            }
        }

        internal bool IsPictureBullet
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x3b1);
            }
            set
            {
                this.SetShapeAttribute(0x3b1, value);
            }
        }

        internal bool IsPseudoInline
        {
            get
            {
                return (this.IsInline && this.IsNeedDummyWhenInline);
            }
        }

        internal bool IsSignatureLine
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x7bf);
            }
        }

        internal bool IsStandardHorizontalRule
        {
            get
            {
                return (bool) this.GetShapeAttribute(0x3b2);
            }
        }

        internal bool IsTextbox
        {
            [CompilerGenerated]
            get
            {
                return this.bool_8;
            }
            [CompilerGenerated]
            set
            {
                this.bool_8 = value;
            }
        }

        internal bool IsTopLevel
        {
            get
            {
                if (base.ParentObject != null)
                {
                    return (base.ParentObject.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.ShapeGroup);
                }
                return true;
            }
        }

        internal bool IsWordArt
        {
            get
            {
                return (bool) this.GetShapeAttribute(0xf1);
            }
        }

        internal Spire.Doc.Fields.Shape.LayoutFlow LayoutFlow
        {
            get
            {
                return (Spire.Doc.Fields.Shape.LayoutFlow) this.GetShapeAttribute(0x88);
            }
            set
            {
                this.SetShapeAttribute(0x88, value);
            }
        }

        internal double Left
        {
            get
            {
                return (double) this.GetShapeAttribute(0x1021);
            }
            set
            {
                this.SetShapeAttribute(0x1021, value);
            }
        }

        internal object LeftPercent
        {
            get
            {
                return this.GetDirectShapeAttribute(0x7c2);
            }
        }

        internal string Name
        {
            get
            {
                return (string) this.GetShapeAttribute(0x380);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("䔲吴嬶䰸帺", 13));
                this.SetShapeAttribute(0x380, value);
            }
        }

        internal int NumLevel
        {
            get
            {
                if (!this.nullable_0.HasValue)
                {
                    return 1;
                }
                return this.nullable_0.Value;
            }
            set
            {
                this.nullable_0 = new int?(value);
            }
        }

        public Paragraph ParentParagraph
        {
            get
            {
                return (base.Owner.Owner as Paragraph);
            }
        }

        internal Spire.Doc.RelativeHeight RelativeHeight
        {
            get
            {
                return (Spire.Doc.RelativeHeight) this.GetShapeAttribute(0x7c5);
            }
        }

        internal Spire.Doc.RelativeWidth RelativeWidth
        {
            get
            {
                return (Spire.Doc.RelativeWidth) this.GetShapeAttribute(0x7c4);
            }
        }

        public double Right
        {
            get
            {
                return (this.Left + this.Width);
            }
        }

        internal double Rotation
        {
            get
            {
                return Class969.smethod_68((int) this.GetShapeAttribute(4));
            }
            set
            {
                this.SetShapeAttribute(4, Class969.smethod_71(value));
            }
        }

        internal string ScreenTip
        {
            get
            {
                return (string) this.GetShapeAttribute(0x38d);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("䈳圵吷伹夻", 14));
                this.SetShapeAttribute(0x38d, value);
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

        public Spire.Doc.Documents.ShapeType ShapeType
        {
            get
            {
                return (Spire.Doc.Documents.ShapeType) this.class43_0.method_32(0x103b);
            }
        }

        public SizeF Size
        {
            get
            {
                return new SizeF((float) this.Width, (float) this.Height);
            }
        }

        internal SizeF SizeInPoints
        {
            get
            {
                return this.BoundsInPoints.Size;
            }
        }

        internal string Target
        {
            get
            {
                return (string) this.GetShapeAttribute(0x1018);
            }
            set
            {
                Class567.smethod_20(value, BookmarkStart.b("䌴嘶唸为堼", 15));
                this.SetShapeAttribute(0x1018, value);
            }
        }

        internal int TempZIndex
        {
            get
            {
                return this.int_6;
            }
            set
            {
                this.int_6 = value;
            }
        }

        internal float TextBoxInernalMarginBottom
        {
            get
            {
                object shapeAttribute = this.GetShapeAttribute(0x84);
                if (shapeAttribute != null)
                {
                    return (float.Parse(shapeAttribute.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f);
                }
                return float.MaxValue;
            }
        }

        internal float TextBoxInernalMarginLeft
        {
            get
            {
                object shapeAttribute = this.GetShapeAttribute(0x81);
                if (shapeAttribute != null)
                {
                    return (float.Parse(shapeAttribute.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f);
                }
                return float.MaxValue;
            }
        }

        internal float TextBoxInernalMarginRight
        {
            get
            {
                object shapeAttribute = this.GetShapeAttribute(0x83);
                if (shapeAttribute != null)
                {
                    return (float.Parse(shapeAttribute.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f);
                }
                return float.MaxValue;
            }
        }

        internal float TextBoxInernalMarginTop
        {
            get
            {
                object shapeAttribute = this.GetShapeAttribute(130);
                if (shapeAttribute != null)
                {
                    return (float.Parse(shapeAttribute.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f);
                }
                return float.MaxValue;
            }
        }

        internal int TextboxNextShapeId
        {
            get
            {
                return (int) this.GetShapeAttribute(0x8a);
            }
            set
            {
                this.SetShapeAttribute(0x8a, value);
            }
        }

        public virtual Spire.Doc.Documents.TextWrappingStyle TextWrappingStyle
        {
            get
            {
                return (Spire.Doc.Documents.TextWrappingStyle) this.GetShapeAttribute(0x1001);
            }
            set
            {
                this.SetShapeAttribute(0x1001, value);
            }
        }

        internal virtual Spire.Doc.Documents.TextWrappingStyle TextWrappingStyleEx
        {
            get
            {
                object directShapeAttribute = this.GetDirectShapeAttribute(0x3ba);
                Spire.Doc.Documents.TextWrappingStyle shapeAttribute = (Spire.Doc.Documents.TextWrappingStyle) this.GetShapeAttribute(0x1001);
                if (((directShapeAttribute != null) && ((bool) directShapeAttribute)) && (shapeAttribute != Spire.Doc.Documents.TextWrappingStyle.Inline))
                {
                    return Spire.Doc.Documents.TextWrappingStyle.Behind;
                }
                return (Spire.Doc.Documents.TextWrappingStyle) this.GetShapeAttribute(0x1001);
            }
        }

        public virtual Spire.Doc.Documents.TextWrappingType TextWrappingType
        {
            get
            {
                return (Spire.Doc.Documents.TextWrappingType) this.GetShapeAttribute(0x1002);
            }
            set
            {
                this.SetShapeAttribute(0x1002, value);
            }
        }

        internal double Top
        {
            get
            {
                return (double) this.GetShapeAttribute(0x1022);
            }
            set
            {
                this.SetShapeAttribute(0x1022, value);
            }
        }

        internal object TopPercent
        {
            get
            {
                return this.GetDirectShapeAttribute(0x7c3);
            }
        }

        internal double TotalRotation
        {
            get
            {
                double num = 0.0;
                DocumentObject parentObject = this;
            Label_001A:
                num += ((ShapeBase) parentObject).Rotation;
                parentObject = parentObject.ParentObject;
                if (parentObject != null)
                {
                    if (parentObject.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.ShapeGroup)
                    {
                        return num;
                    }
                    goto Label_001A;
                }
                return num;
            }
        }

        internal int Txid
        {
            get
            {
                return (int) this.GetShapeAttribute(0x80);
            }
            set
            {
                this.SetShapeAttribute(0x80, value);
            }
        }

        public virtual ShapeVerticalAlignment VerticalAlignment
        {
            get
            {
                return (ShapeVerticalAlignment) this.GetShapeAttribute(0x391);
            }
            set
            {
                this.SetShapeAttribute(0x391, value);
            }
        }

        public virtual Spire.Doc.Documents.VerticalOrigin VerticalOrigin
        {
            get
            {
                return (Spire.Doc.Documents.VerticalOrigin) this.GetShapeAttribute(0x392);
            }
            set
            {
                this.SetShapeAttribute(0x392, value);
            }
        }

        public virtual float VerticalPosition
        {
            get
            {
                return Convert.ToSingle(this.Top);
            }
            set
            {
                this.Top = value;
            }
        }

        public double Width
        {
            get
            {
                return (double) this.GetShapeAttribute(0x1023);
            }
            set
            {
                this.method_38(value, true);
            }
        }

        internal object WidthPercent
        {
            get
            {
                return this.GetShapeAttribute(0x7c0);
            }
            set
            {
                this.SetShapeAttribute(0x7c0, value);
            }
        }

        internal Class891[] WrapPolygonVertices
        {
            get
            {
                return (Class891[]) this.GetShapeAttribute(0x383);
            }
        }

        public long ZOrder
        {
            get
            {
                long shapeAttribute = (long) this.GetShapeAttribute(0x103a);
                if ((shapeAttribute == 0L) && (this.TextWrappingStyle == Spire.Doc.Documents.TextWrappingStyle.Behind))
                {
                    return -1L;
                }
                return shapeAttribute;
            }
            set
            {
                this.SetShapeAttribute(0x103a, value);
            }
        }

        internal long ZOrderEx
        {
            get
            {
                long zOrder = this.ZOrder;
                if (this.IsBelowTextEx && (zOrder >= 0L))
                {
                    if (zOrder > 0L)
                    {
                        zOrder = (int) ((-4294967295L + (zOrder * 2L)) / 2L);
                        if (zOrder > 0L)
                        {
                            zOrder = -zOrder;
                        }
                    }
                    if (zOrder == 0L)
                    {
                        zOrder = -1L;
                    }
                }
                return zOrder;
            }
        }
    }
}

