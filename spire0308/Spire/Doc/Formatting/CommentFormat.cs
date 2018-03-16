namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;

    public class CommentFormat : DocumentSerializable
    {
        private System.DateTime dateTime_0;
        private float[] float_0;
        private float[] float_1;
        private float[] float_2;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private int int_6;
        private int int_7;
        private int int_8;
        private string string_3;
        private string string_4;
        private string string_5;

        public CommentFormat() : base(null, null)
        {
            this.string_3 = "";
            this.dateTime_0 = System.DateTime.MinValue;
            this.string_4 = "";
            this.int_5 = -1;
            this.int_6 = -1;
            this.int_7 = -1;
        }

        public CommentFormat Clone(IDocument doc)
        {
            CommentFormat format = new CommentFormat {
                string_4 = this.string_4,
                string_3 = this.string_3,
                dateTime_0 = this.dateTime_0,
                int_6 = this.int_6,
                int_5 = this.int_5
            };
            if ((doc != base.Document) && !this.method_5(doc, this.int_7))
            {
                format.int_7 = this.int_7;
                return format;
            }
            format.int_7 = Class323.smethod_4(this.int_7);
            return format;
        }

        private bool method_5(IDocument A_0, int A_1)
        {
            foreach (Section section in A_0.Sections)
            {
                foreach (Paragraph paragraph in section.Body.Paragraphs)
                {
                    foreach (IParagraphBase base2 in paragraph.Items)
                    {
                        Comment comment = base2 as Comment;
                        if ((comment != null) && (comment.Format.CommentId == A_1))
                        {
                            return true;
                        }
                    }
                }
            }
            return Class323.smethod_1().ContainsKey(A_1);
        }

        internal void method_6()
        {
            this.int_7 = Class323.smethod_0().Next();
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("朱䜳匵䨷", 12)))
            {
                this.string_3 = reader.ReadString(BookmarkStart.b("朱䜳匵䨷", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("朱䜳匵䨷猹刻圽㐿⭁╃⩅㭇", num)))
            {
                this.string_4 = reader.ReadString(BookmarkStart.b("朱䜳匵䨷猹刻圽㐿⭁╃⩅㭇", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿ᅁぃ❅㩇㹉᱋⅍⍏", num)))
            {
                this.int_5 = reader.ReadInt(BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿ᅁぃ❅㩇㹉᱋⅍⍏", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿݁⩃≅ᡇ╉㽋", num)))
            {
                this.int_6 = reader.ReadInt(BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿݁⩃≅ᡇ╉㽋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("昱唳儵稷儹儻唽", num)))
            {
                this.int_7 = reader.ReadInt(BookmarkStart.b("昱唳儵稷儹儻唽", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 3;
            base.WriteXmlAttributes(writer);
            if (this.string_4 != "")
            {
                writer.WriteValue(BookmarkStart.b("簨堪䠬崮砰崲尴䌶倸娺儼䰾", num), this.string_4);
            }
            if (this.string_3 != "")
            {
                writer.WriteValue(BookmarkStart.b("簨堪䠬崮", num), this.string_3);
            }
            if (this.int_5 != -1)
            {
                writer.WriteValue(BookmarkStart.b("欨䐪䈬䐮尰刲䜴尶樸伺尼䴾㕀ፂ⩄㑆", num), this.int_5);
            }
            if (this.int_6 != -1)
            {
                writer.WriteValue(BookmarkStart.b("欨䐪䈬䐮尰刲䜴尶簸唺夼漾⹀あ", num), this.int_6);
            }
            if (this.int_7 != -1)
            {
                writer.WriteValue(BookmarkStart.b("紨䨪䨬洮娰帲帴", num), this.int_7);
            }
        }

        public string Author
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }

        internal int BookmarkEndOffset
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

        internal int BookmarkStartOffset
        {
            get
            {
                return this.int_5;
            }
            set
            {
                this.int_5 = value;
            }
        }

        public int CommentId
        {
            get
            {
                return this.int_7;
            }
            set
            {
                this.int_2 = this.int_7 = value;
            }
        }

        public System.DateTime DateTime
        {
            get
            {
                if (this.dateTime_0 == System.DateTime.MinValue)
                {
                    return System.DateTime.Now;
                }
                return this.dateTime_0;
            }
            set
            {
                this.dateTime_0 = value;
            }
        }

        public int Id
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_7 = this.int_2 = value;
            }
        }

        public string Initial
        {
            get
            {
                return this.string_4;
            }
            set
            {
                int num = 9;
                if (value.Length > 9)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("昮弰娲䄴帶堸场", num), BookmarkStart.b("種䈰嘲䜴䐶ᤸ刺匼嘾㕀⩂⑄⭆㩈歊⅌⩎㽐㑒⅔㽖祘㙚⡜ⱞᕠ䍢ݤɦ䥨ݪ࡬ᱮɰ卲Ŵὶᡸᕺ嵼乾놀ꎂﺆ붒", num));
                }
                this.string_4 = value;
            }
        }

        internal int Position
        {
            get
            {
                return this.int_8;
            }
            set
            {
                this.int_8 = value;
            }
        }

        internal int StartTextPos
        {
            get
            {
                return (this.int_8 - this.int_5);
            }
        }
    }
}

