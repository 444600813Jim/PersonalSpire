namespace Spire.Doc
{
    using Spire.CompoundFile.Doc;
    using Spire.CompoundFile.Doc.Native;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class SummaryDocumentProperties : DocumentSerializable
    {
        private bool bool_0;
        private float float_0;
        private long[] long_2;
        protected Dictionary<int, DocumentProperty> m_summaryHash;
        private int? nullable_0;
        private string[] string_3;
        private string string_4;

        internal SummaryDocumentProperties() : this(0)
        {
        }

        internal SummaryDocumentProperties(int A_0) : base(null, null)
        {
            this.m_summaryHash = new Dictionary<int, DocumentProperty>(A_0);
        }

        public void Add(int key, DocumentProperty props)
        {
            this.m_summaryHash.Add(key, props);
        }

        private bool method_5(int A_0)
        {
            return this.m_summaryHash.ContainsKey(A_0);
        }

        internal void method_6(PIDSI A_0, object A_1)
        {
            if (this.m_summaryHash.ContainsKey((int) A_0))
            {
                this[A_0].Value = A_1;
            }
            else
            {
                DocumentProperty property = new DocumentProperty((BuiltInProperty) A_0, A_1);
                this.m_summaryHash[(int) A_0] = property;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("礷伹䠻嘽⼿ぁ", 0x12)))
            {
                this.Author = reader.ReadString(BookmarkStart.b("礷伹䠻嘽⼿ぁ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("礷䨹䰻刽⤿⅁╃㉅ⅇ╉≋Mㅏ㽑ㅓ", num)))
            {
                this.ApplicationName = reader.ReadString(BookmarkStart.b("礷䨹䰻刽⤿⅁╃㉅ⅇ╉≋Mㅏ㽑ㅓ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷匹䠻刽┿", num)))
            {
                this.Title = reader.ReadString(BookmarkStart.b("氷匹䠻刽┿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("欷伹帻吽┿⅁ぃ", num)))
            {
                this.Subject = reader.ReadString(BookmarkStart.b("欷伹帻吽┿⅁ぃ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("猷弹䔻䤽⼿ぁ⁃㕅", num)))
            {
                this.Keywords = reader.ReadString(BookmarkStart.b("猷弹䔻䤽⼿ぁ⁃㕅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笷唹儻匽┿ⱁぃ㕅", num)))
            {
                this.Comments = reader.ReadString(BookmarkStart.b("笷唹儻匽┿ⱁぃ㕅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷弹儻丽ⰿ⍁ぃ⍅", num)))
            {
                this.Template = reader.ReadString(BookmarkStart.b("氷弹儻丽ⰿ⍁ぃ⍅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琷嬹伻䨽Ŀ㝁ぃ⹅❇㡉", num)))
            {
                this.LastAuthor = reader.ReadString(BookmarkStart.b("琷嬹伻䨽Ŀ㝁ぃ⹅❇㡉", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("樷弹䨻圽㌿⭁⭃⡅ه㽉⅋ⱍ㕏⁑", num)))
            {
                this.RevisionNumber = reader.ReadString(BookmarkStart.b("樷弹䨻圽㌿⭁⭃⡅ه㽉⅋ⱍ㕏⁑", num));
            }
            reader.HasAttribute(BookmarkStart.b("紷帹唻䨽ᐿ⭁⥃⍅", num));
            if (reader.HasAttribute(BookmarkStart.b("琷嬹伻䨽ဿぁⵃ⡅㱇⽉⡋", num)))
            {
                this.LastPrinted = reader.ReadDateTime(BookmarkStart.b("琷嬹伻䨽ဿぁⵃ⡅㱇⽉⡋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笷䠹夻弽㐿❁C❅㱇⽉", num)))
            {
                this.CreateDate = reader.ReadDateTime(BookmarkStart.b("笷䠹夻弽㐿❁C❅㱇⽉", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琷嬹伻䨽ጿ⍁㉃⍅ే⭉㡋⭍", num)))
            {
                this.LastSaveDate = reader.ReadDateTime(BookmarkStart.b("琷嬹伻䨽ጿ⍁㉃⍅ే⭉㡋⭍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹嬻嬽̿ⵁㅃ⡅㱇", num)))
            {
                this.method_6(PIDSI.Pagecount, reader.ReadInt(BookmarkStart.b("样嬹嬻嬽̿ⵁㅃ⡅㱇", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("漷唹主娽̿ⵁㅃ⡅㱇", num)))
            {
                this.method_6(PIDSI.Wordcount, reader.ReadInt(BookmarkStart.b("漷唹主娽̿ⵁㅃ⡅㱇", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("笷刹崻䰽̿ⵁㅃ⡅㱇", num)))
            {
                this.method_6(PIDSI.Charcount, reader.ReadInt(BookmarkStart.b("笷刹崻䰽̿ⵁㅃ⡅㱇", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("氷刹䤻匽∿ⱁ╃⽅⑇", num)))
            {
                this.Thumbnail = reader.ReadString(BookmarkStart.b("氷刹䤻匽∿ⱁ╃⽅⑇", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("簷唹弻洽┿⅁ㅃ㑅ⅇ㹉㕋", num)))
            {
                this.DocSecurity = reader.ReadInt(BookmarkStart.b("簷唹弻洽┿⅁ㅃ㑅ⅇ㹉㕋", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 12;
            base.WriteXmlAttributes(writer);
            if (this.method_5(4))
            {
                writer.WriteValue(BookmarkStart.b("猱䄳䈵倷唹主", num), this.Author);
            }
            if (this.method_5(0x12))
            {
                writer.WriteValue(BookmarkStart.b("猱䐳䘵吷匹弻弽㐿⭁⭃⡅ه⭉⅋⭍", num), this.ApplicationName);
            }
            if (this.method_5(2))
            {
                writer.WriteValue(BookmarkStart.b("昱崳䈵吷弹", num), this.Title);
            }
            if (this.method_5(3))
            {
                writer.WriteValue(BookmarkStart.b("愱䄳吵刷弹弻䨽", num), this.Subject);
            }
            if (this.method_5(5))
            {
                writer.WriteValue(BookmarkStart.b("礱儳伵伷唹主娽㌿", num), this.Keywords);
            }
            if (this.method_5(6))
            {
                writer.WriteValue(BookmarkStart.b("焱嬳嬵唷弹刻䨽㌿", num), this.Comments);
            }
            if (this.method_5(7))
            {
                writer.WriteValue(BookmarkStart.b("昱儳嬵䠷嘹崻䨽┿", num), this.Template);
            }
            if (this.method_5(8))
            {
                writer.WriteValue(BookmarkStart.b("縱唳䔵䰷笹䤻䨽⠿ⵁ㙃", num), this.LastAuthor);
            }
            if (this.method_5(9))
            {
                writer.WriteValue(BookmarkStart.b("怱儳䀵儷䤹唻儽⸿ుㅃ⭅⩇⽉㹋", num), this.RevisionNumber);
            }
            if (this.method_5(10))
            {
                writer.WriteValue(BookmarkStart.b("眱倳張䰷渹唻匽┿", num), this.TotalEditingTime.TotalMinutes.ToString());
            }
            if (this.method_5(11))
            {
                writer.WriteValue(BookmarkStart.b("縱唳䔵䰷樹主圽⸿㙁⅃≅", num), this.LastPrinted);
            }
            if (this.method_5(12))
            {
                writer.WriteValue(BookmarkStart.b("焱䘳匵夷丹夻稽ℿ㙁⅃", num), this.CreateDate);
            }
            if (this.method_5(13))
            {
                writer.WriteValue(BookmarkStart.b("縱唳䔵䰷椹崻䠽┿ف╃㉅ⵇ", num), this.LastSaveDate);
            }
            if (this.method_5(14))
            {
                writer.WriteValue(BookmarkStart.b("戱唳儵崷礹医䬽⸿㙁", num), this.PageCount);
            }
            if (this.method_5(15))
            {
                writer.WriteValue(BookmarkStart.b("攱嬳䐵尷礹医䬽⸿㙁", num), this.WordCount);
            }
            if (this.method_5(0x10))
            {
                writer.WriteValue(BookmarkStart.b("焱尳圵䨷礹医䬽⸿㙁", num), this.CharCount);
            }
            if (this.method_5(0x11))
            {
                writer.WriteValue(BookmarkStart.b("昱尳䌵唷堹刻弽⤿⹁", num), this.Thumbnail);
            }
            if (this.method_5(0x13))
            {
                writer.WriteValue(BookmarkStart.b("瘱嬳唵欷弹弻䬽㈿⭁ぃ㽅", num), this.DocSecurity);
            }
        }

        public string ApplicationName
        {
            get
            {
                int num = 14;
                if (!this.m_summaryHash.ContainsKey(0x12))
                {
                    return BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃", num);
                }
                return this[PIDSI.Appname].Text;
            }
            set
            {
                this.method_6(PIDSI.Appname, value);
                this[PIDSI.Appname].Text = value;
            }
        }

        public string Author
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(4))
                {
                    return null;
                }
                return this[PIDSI.Author].Text;
            }
            set
            {
                this.method_6(PIDSI.Author, value);
                this[PIDSI.Author].Text = value;
            }
        }

        public int CharCount
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(0x10))
                {
                    return -2147483648;
                }
                return this[PIDSI.Charcount].ToInt();
            }
            internal set
            {
                this.method_6(PIDSI.Charcount, value);
                this[PIDSI.Charcount].Int32 = value;
            }
        }

        public int CharCountWithSpace
        {
            get
            {
                if (this.nullable_0.HasValue)
                {
                    return this.nullable_0.Value;
                }
                return this.CharCount;
            }
            internal set
            {
                this.nullable_0 = new int?(value);
            }
        }

        public string Comments
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(6))
                {
                    return null;
                }
                return this[PIDSI.Comments].Text;
            }
            set
            {
                this.method_6(PIDSI.Comments, value);
                this[PIDSI.Comments].Text = value;
            }
        }

        public int Count
        {
            get
            {
                return this.m_summaryHash.Count;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(12))
                {
                    return DateTime.Now;
                }
                return this[PIDSI.Create_dtm].DateTime;
            }
            set
            {
                if (!value.Equals(new DateTime()))
                {
                    if (value.CompareTo(new DateTime(0x76c, 12, 0x1f)) > 0)
                    {
                        this.method_6(PIDSI.Create_dtm, value);
                        this[PIDSI.Create_dtm].DateTime = value;
                    }
                    else
                    {
                        this.method_6(PIDSI.Create_dtm, new DateTime(0x76d, 1, 1));
                        this[PIDSI.Create_dtm].DateTime = new DateTime(0x76d, 1, 1);
                    }
                }
                else if (this.m_summaryHash.ContainsKey(12))
                {
                    this.m_summaryHash.Remove(12);
                }
            }
        }

        public int DocSecurity
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(0x13))
                {
                    return -2147483648;
                }
                return this[PIDSI.Doc_security].ToInt();
            }
            set
            {
                this.method_6(PIDSI.Doc_security, value);
                this[PIDSI.Doc_security].Int32 = value;
            }
        }

        internal DocumentProperty this[PIDSI A_0]
        {
            get
            {
                return this.m_summaryHash[(int) A_0];
            }
        }

        public string Keywords
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(5))
                {
                    return null;
                }
                return this[PIDSI.Keywords].Text;
            }
            set
            {
                this.method_6(PIDSI.Keywords, value);
                this[PIDSI.Keywords].Text = value;
            }
        }

        public string LastAuthor
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(8))
                {
                    return null;
                }
                return this[PIDSI.LastAuthor].Text;
            }
            set
            {
                this.method_6(PIDSI.LastAuthor, value);
                this[PIDSI.LastAuthor].Text = value;
            }
        }

        public DateTime LastPrinted
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(11))
                {
                    return DateTime.MinValue;
                }
                return this[PIDSI.LastPrinted].DateTime;
            }
            set
            {
                this.method_6(PIDSI.LastPrinted, value);
                this[PIDSI.LastPrinted].DateTime = value;
            }
        }

        public DateTime LastSaveDate
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(13))
                {
                    return DateTime.Now;
                }
                return this[PIDSI.LastSave_dtm].DateTime;
            }
            set
            {
                if (!value.Equals(new DateTime()))
                {
                    if (value.CompareTo(new DateTime(0x76c, 12, 0x1f)) > 0)
                    {
                        this.method_6(PIDSI.LastSave_dtm, value);
                        this[PIDSI.LastSave_dtm].DateTime = value;
                    }
                    else
                    {
                        this.method_6(PIDSI.LastSave_dtm, new DateTime(0x76d, 1, 1));
                        this[PIDSI.LastSave_dtm].DateTime = new DateTime(0x76d, 1, 1);
                    }
                }
                else if (this.m_summaryHash.ContainsKey(13))
                {
                    this.m_summaryHash.Remove(13);
                }
            }
        }

        public int PageCount
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(14))
                {
                    return -2147483648;
                }
                return this[PIDSI.Pagecount].ToInt();
            }
            internal set
            {
                this.method_6(PIDSI.Pagecount, value);
                this[PIDSI.Pagecount].Int32 = value;
            }
        }

        public string RevisionNumber
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(9))
                {
                    return null;
                }
                return this[PIDSI.Revnumber].Text;
            }
            set
            {
                this.method_6(PIDSI.Revnumber, value);
                this[PIDSI.Revnumber].Value = value;
            }
        }

        public string Subject
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(3))
                {
                    return null;
                }
                return this[PIDSI.Subject].Text;
            }
            set
            {
                this.method_6(PIDSI.Subject, value);
                this[PIDSI.Subject].Text = value;
            }
        }

        internal Dictionary<int, DocumentProperty> SummaryHash
        {
            get
            {
                return this.m_summaryHash;
            }
        }

        public string Template
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(7))
                {
                    return null;
                }
                return this[PIDSI.Template].Text;
            }
            set
            {
                this.method_6(PIDSI.Template, value);
                this[PIDSI.Template].Value = value;
            }
        }

        public string Thumbnail
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(0x11))
                {
                    return null;
                }
                return this[PIDSI.Thumbnail].Text;
            }
            set
            {
                this.method_6(PIDSI.Thumbnail, value);
                this[PIDSI.Thumbnail].Text = value;
            }
        }

        public string Title
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(2))
                {
                    return null;
                }
                return this[PIDSI.Title].Text;
            }
            set
            {
                this.method_6(PIDSI.Title, value);
                this[PIDSI.Title].Text = value;
            }
        }

        public TimeSpan TotalEditingTime
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(10))
                {
                    return TimeSpan.MinValue;
                }
                if (this[PIDSI.EditTime].TimeSpan >= TimeSpan.Zero)
                {
                    return this[PIDSI.EditTime].TimeSpan;
                }
                return TimeSpan.Zero;
            }
            set
            {
                this.method_6(PIDSI.EditTime, value);
                this[PIDSI.EditTime].Value = value;
            }
        }

        public int WordCount
        {
            get
            {
                if (!this.m_summaryHash.ContainsKey(15))
                {
                    return -2147483648;
                }
                return this[PIDSI.Wordcount].ToInt();
            }
            internal set
            {
                this.method_6(PIDSI.Wordcount, value);
                this[PIDSI.Wordcount].Int32 = value;
            }
        }
    }
}

