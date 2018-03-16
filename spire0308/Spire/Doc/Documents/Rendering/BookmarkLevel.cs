namespace Spire.Doc.Documents.Rendering
{
    using Spire.Doc;
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class BookmarkLevel
    {
        private BookmarkLevel bookmarkLevel_0;
        private BookmarkTextStyle bookmarkTextStyle_0 = BookmarkTextStyle.Bold;
        private bool bool_0;
        private bool bool_1;
        private System.Drawing.Color color_0 = System.Drawing.Color.SaddleBrown;
        private float[] float_0;
        private float[] float_1;
        private int int_0;
        private int int_1;
        private int int_2;
        private List<BookmarkLevel> list_0;
        private long[] long_0;
        private RectangleF rectangleF_0 = new RectangleF();
        private RectangleF rectangleF_1 = new RectangleF();
        private string string_0;
        private string string_1;

        internal bool method_0(BookmarkLevel A_0)
        {
            if (A_0 != null)
            {
                A_0.method_1(this);
                if (!this.ChildObjects.Contains(A_0))
                {
                    this.ChildObjects.Add(A_0);
                    return true;
                }
            }
            return false;
        }

        internal void method_1(BookmarkLevel A_0)
        {
            this.bookmarkLevel_0 = A_0;
        }

        public List<BookmarkLevel> ChildObjects
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<BookmarkLevel>();
                }
                return this.list_0;
            }
        }

        public System.Drawing.Color Color
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

        internal bool IsDrawComplete
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

        internal bool IsPair
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

        public int Level
        {
            get
            {
                int num = 1;
                if (this.bookmarkLevel_0 != null)
                {
                    for (BookmarkLevel level = this.bookmarkLevel_0; level != null; level = level.Owner)
                    {
                        num++;
                    }
                }
                return num;
            }
        }

        public string Name
        {
            get
            {
                return this.string_0;
            }
            internal set
            {
                this.string_0 = value;
            }
        }

        internal BookmarkLevel Owner
        {
            get
            {
                return this.bookmarkLevel_0;
            }
        }

        internal RectangleF SourceBounds
        {
            get
            {
                return this.rectangleF_1;
            }
            set
            {
                this.rectangleF_1 = value;
            }
        }

        internal int SourcePageNumber
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_2 = value;
            }
        }

        public BookmarkTextStyle Style
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

        internal RectangleF TargetBounds
        {
            get
            {
                return this.rectangleF_0;
            }
            set
            {
                this.rectangleF_0 = value;
            }
        }

        internal int TargetPageNumber
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

        internal string Text
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

