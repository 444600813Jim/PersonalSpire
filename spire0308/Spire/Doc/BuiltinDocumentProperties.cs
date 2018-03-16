namespace Spire.Doc
{
    using Spire.CompoundFile.Doc;
    using Spire.CompoundFile.Doc.Native;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class BuiltinDocumentProperties : SummaryDocumentProperties
    {
        private Dictionary<int, DocumentProperty> dictionary_0;
        private float[] float_1;
        private long long_3;

        internal BuiltinDocumentProperties() : this(0, 0)
        {
        }

        internal BuiltinDocumentProperties(int A_0, int A_1) : base(A_1)
        {
            this.dictionary_0 = new Dictionary<int, DocumentProperty>();
            this.dictionary_0 = new Dictionary<int, DocumentProperty>(A_0);
        }

        public BuiltinDocumentProperties Clone()
        {
            BuiltinDocumentProperties properties = new BuiltinDocumentProperties(this.dictionary_0.Count, base.m_summaryHash.Count);
            foreach (int num2 in this.dictionary_0.Keys)
            {
                properties.dictionary_0.Add(num2, this.dictionary_0[num2].Clone());
            }
            foreach (int num in base.m_summaryHash.Keys)
            {
                properties.m_summaryHash.Add(num, base.m_summaryHash[num].Clone());
            }
            return properties;
        }

        internal void method_7()
        {
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
                this.dictionary_0 = null;
            }
        }

        private bool method_8(int A_0)
        {
            return this.dictionary_0.ContainsKey(A_0);
        }

        internal void method_9(PIDDSI A_0, object A_1)
        {
            if (this.dictionary_0.ContainsKey((int) A_0))
            {
                this[A_0].Value = A_1;
            }
            else
            {
                DocumentProperty property = new DocumentProperty((BuiltInProperty) A_0, A_1);
                this.dictionary_0[(int) A_0] = property;
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("笷唹儻丽ℿⱁ㵃", 0x12)))
            {
                this.Company = reader.ReadString(BookmarkStart.b("笷唹儻丽ℿⱁ㵃", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("男嬹刻弽✿❁㙃", num)))
            {
                this.Manager = reader.ReadString(BookmarkStart.b("男嬹刻弽✿❁㙃", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笷嬹䠻嬽✿ⵁ㙃㽅", num)))
            {
                this.Category = reader.ReadString(BookmarkStart.b("笷嬹䠻嬽✿ⵁ㙃㽅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稷䌹䠻嬽㌿Ł⭃㍅♇㹉", num)))
            {
                this.method_9(PIDDSI.ByteCount, reader.ReadInt(BookmarkStart.b("稷䌹䠻嬽㌿Ł⭃㍅♇㹉", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("琷匹刻嬽㌿Ł⭃㍅♇㹉", num)))
            {
                this.method_9(PIDDSI.LineCount, reader.ReadInt(BookmarkStart.b("琷匹刻嬽㌿Ł⭃㍅♇㹉", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("样嬹主弽✿ぁ╃㙅⁇ॉ⍋㭍㹏♑", num)))
            {
                this.method_9(PIDDSI.ParCount, reader.ReadInt(BookmarkStart.b("样嬹主弽✿ぁ╃㙅⁇ॉ⍋㭍㹏♑", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("欷嘹唻娽┿Ł⭃㍅♇㹉", num)))
            {
                this.method_9(PIDDSI.SlideCount, reader.ReadInt(BookmarkStart.b("欷嘹唻娽┿Ł⭃㍅♇㹉", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("瘷唹䠻嬽̿ⵁㅃ⡅㱇", num)))
            {
                this.method_9(PIDDSI.NoteCount, reader.ReadInt(BookmarkStart.b("瘷唹䠻嬽̿ⵁㅃ⡅㱇", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀷匹堻娽┿ⱁ݃⥅㵇⑉㡋", num)))
            {
                this.method_9(PIDDSI.HiddenCount, reader.ReadInt(BookmarkStart.b("瀷匹堻娽┿ⱁ݃⥅㵇⑉㡋", num)));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 1;
            base.WriteXmlAttributes(writer);
            if (this.method_8(15))
            {
                writer.WriteValue(BookmarkStart.b("搦䘨䘪崬丮弰䨲", num), this.Company);
            }
            if (this.method_8(14))
            {
                writer.WriteValue(BookmarkStart.b("樦䠨䔪䰬䠮吰䄲", num), this.Manager);
            }
            if (this.method_8(2))
            {
                writer.WriteValue(BookmarkStart.b("搦䠨弪䠬䠮帰䄲䰴", num), this.Category);
            }
            if (this.method_8(4))
            {
                writer.WriteValue(BookmarkStart.b("攦倨弪䠬尮爰尲䀴夶䴸", num), this.BytesCount);
            }
            if (this.method_8(5))
            {
                writer.WriteValue(BookmarkStart.b("欦䀨䔪䠬尮爰尲䀴夶䴸", num), this.LinesCount);
            }
            if (this.method_8(6))
            {
                writer.WriteValue(BookmarkStart.b("眦䠨太䰬䠮䌰刲䔴弶稸吺䠼儾㕀", num), this.ParagraphCount);
            }
            if (this.method_8(7))
            {
                writer.WriteValue(BookmarkStart.b("琦䔨䈪䤬䨮爰尲䀴夶䴸", num), this.SlideCount);
            }
            if (this.method_8(8))
            {
                writer.WriteValue(BookmarkStart.b("椦䘨弪䠬氮帰䘲嬴䌶", num), this.NoteCount);
            }
            if (this.method_8(9))
            {
                writer.WriteValue(BookmarkStart.b("漦䀨伪䤬䨮弰瀲娴䈶圸伺", num), this.HiddenCount);
            }
        }

        public int BytesCount
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(4))
                {
                    return -2147483648;
                }
                return this[PIDDSI.ByteCount].Int32;
            }
            internal set
            {
                this.method_9(PIDDSI.ByteCount, value);
                this[PIDDSI.ByteCount].Int32 = value;
            }
        }

        public string Category
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(0x3e8))
                {
                    return null;
                }
                return this[(PIDDSI) 0x3e8].Text;
            }
            set
            {
                this.method_9((PIDDSI) 0x3e8, value);
                this[(PIDDSI) 0x3e8].Text = value;
            }
        }

        public int CharCountWithSpace
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(0x11))
                {
                    return -2147483648;
                }
                return this[PIDDSI.CharactersWithSpaces].ToInt();
            }
            internal set
            {
                this.method_9(PIDDSI.CharactersWithSpaces, value);
                this[PIDDSI.CharactersWithSpaces].Int32 = value;
            }
        }

        public string Company
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(0x3f5))
                {
                    return null;
                }
                return this[(PIDDSI) 0x3f5].Text;
            }
            set
            {
                this.method_9((PIDDSI) 0x3f5, value);
                this[(PIDDSI) 0x3f5].Text = value;
            }
        }

        internal Dictionary<int, DocumentProperty> DocumentHash
        {
            get
            {
                return this.dictionary_0;
            }
        }

        public int HiddenCount
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(9))
                {
                    return -2147483648;
                }
                return this[PIDDSI.HiddenCount].ToInt();
            }
            internal set
            {
                this.method_9((PIDDSI) 0x3ef, value);
                this[(PIDDSI) 0x3ef].Int32 = value;
            }
        }

        internal DocumentProperty this[PIDDSI A_0]
        {
            get
            {
                return this.dictionary_0[(int) A_0];
            }
        }

        public int LinesCount
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(5))
                {
                    return -2147483648;
                }
                return this[PIDDSI.LineCount].ToInt();
            }
            internal set
            {
                this.method_9(PIDDSI.LineCount, value);
                this[PIDDSI.LineCount].Int32 = value;
            }
        }

        public string Manager
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(0x3f4))
                {
                    return null;
                }
                return this[(PIDDSI) 0x3f4].Text;
            }
            set
            {
                this.method_9((PIDDSI) 0x3f4, value);
                this[(PIDDSI) 0x3f4].Text = value;
            }
        }

        public int NoteCount
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(8))
                {
                    return -2147483648;
                }
                return this[PIDDSI.NoteCount].ToInt();
            }
            internal set
            {
                this.method_9((PIDDSI) 0x3ee, value);
                this[(PIDDSI) 0x3ee].Int32 = value;
            }
        }

        public int ParagraphCount
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(6))
                {
                    return -2147483648;
                }
                return this[PIDDSI.ParCount].ToInt();
            }
            internal set
            {
                this.method_9(PIDDSI.ParCount, value);
                this[PIDDSI.ParCount].Int32 = value;
            }
        }

        public int SlideCount
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(7))
                {
                    return -2147483648;
                }
                return this[PIDDSI.SlideCount].ToInt();
            }
            internal set
            {
                this.method_9((PIDDSI) 0x3ed, value);
                this[(PIDDSI) 0x3ed].Int32 = value;
            }
        }
    }
}

