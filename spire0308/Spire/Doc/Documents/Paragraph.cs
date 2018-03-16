namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Paragraph : BodyRegion, Interface3, Interface46, IRunAttrSource, IParagraph
    {
        private Body body_0;
        [CompilerGenerated]
        private bool bool_10;
        [CompilerGenerated]
        private bool bool_11;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        internal bool bool_6;
        private bool bool_7;
        private bool bool_8;
        [CompilerGenerated]
        private bool bool_9;
        private CharacterFormat characterFormat_0;
        private float[] float_2;
        internal const float float_3 = 14.5f;
        internal const float float_4 = 12f;
        internal float float_5;
        private float float_6;
        private int[] int_2;
        private const int int_3 = 0xb3;
        private const int int_4 = 0xffe;
        private int int_5;
        private int int_6;
        private int int_7;
        private int int_8;
        private long[] long_3;
        private long[] long_4;
        protected Spire.Doc.Formatting.ListFormat m_listFormat;
        protected ParagraphItemCollection m_pItemColl;
        protected ParagraphFormat m_prFormat;
        protected IParagraphStyle m_style;
        private ParagraphItemCollection paragraphItemCollection_0;
        private ParagraphItemCollection paragraphItemCollection_1;
        private const string string_7 = "Normal";
        private string string_8;
        private string string_9;
        private StringBuilder stringBuilder_0;
        private TextRange textRange_0;

        public Paragraph(IDocument doc) : base((Document) doc)
        {
            this.stringBuilder_0 = new StringBuilder(1);
            this.int_6 = -2147483648;
            this.int_7 = -2147483648;
            this.int_8 = -2147483648;
            this.string_9 = string.Empty;
            this.m_pItemColl = new ParagraphItemCollection(this);
            this.characterFormat_0 = new CharacterFormat(base.Document);
            this.m_prFormat = new ParagraphFormat(base.Document);
            this.m_listFormat = new Spire.Doc.Formatting.ListFormat(this);
            this.characterFormat_0.method_0(this);
            this.m_prFormat.method_0(this);
            this.m_listFormat.method_0(this);
            this.ApplyStyle(BuiltinStyle.Normal);
            this.method_82();
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override void AcceptCChanges()
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.AcceptChanges();
            }
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_9(this);
        }

        internal override void AcceptPChanges()
        {
            if (this.m_prFormat != null)
            {
                this.m_prFormat.AcceptChanges();
            }
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_8(this);
        }

        public BookmarkEnd AppendBookmarkEnd(string name)
        {
            BookmarkEnd entity = new BookmarkEnd(base.Document, name);
            this.Items.Add(entity);
            return entity;
        }

        public BookmarkStart AppendBookmarkStart(string name)
        {
            BookmarkStart entity = new BookmarkStart(base.Document, name);
            this.Items.Add(entity);
            return entity;
        }

        public Break AppendBreak(BreakType breakType)
        {
            return this.method_29(breakType, LineBreakClear.None);
        }

        public CheckBoxFormField AppendCheckBox()
        {
            return this.method_27();
        }

        public CheckBoxFormField AppendCheckBox(string checkBoxName, bool defaultCheckBoxValue)
        {
            return this.method_28(checkBoxName, defaultCheckBoxValue);
        }

        public Comment AppendComment(string text)
        {
            Comment comment = (Comment) this.method_62(ParagraphItemType.Comment);
            comment.Body.AddParagraph().AppendText(text);
            return comment;
        }

        public CommentMark AppendCommentMark(CommentMarkType type)
        {
            CommentMark mark = (CommentMark) this.method_62(ParagraphItemType.CommentMark);
            mark.Type = type;
            return mark;
        }

        public DropDownFormField AppendDropDownFormField()
        {
            string dropDropDownName = (BookmarkStart.b("洨太䈬弮渰", 3) + Guid.NewGuid().ToString().Replace(BookmarkStart.b("Ш", 3), BookmarkStart.b("瘨", 3))).Substring(0, 20);
            return this.AppendDropDownFormField(dropDropDownName);
        }

        public DropDownFormField AppendDropDownFormField(string dropDropDownName)
        {
            DropDownFormField entity = base.Document.CreateParagraphItem(ParagraphItemType.DropDownFormField) as DropDownFormField;
            entity.Name = dropDropDownName;
            this.Items.Add(entity);
            return entity;
        }

        public Field AppendField(string fieldName, FieldType fieldType)
        {
            Field field;
            int num = 11;
            if (fieldName == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("地娲倴嬶崸町尼刾⑀", num));
            }
            if (fieldType == FieldType.FieldFormCheckBox)
            {
                return this.method_28(fieldName, false);
            }
            if (fieldType == FieldType.FieldFormDropDown)
            {
                return this.AppendDropDownFormField(fieldName);
            }
            if (fieldType == FieldType.FieldFormTextInput)
            {
                return this.AppendTextFormField(fieldName, fieldName);
            }
            if (fieldType == FieldType.FieldIndexEntry)
            {
                return this.method_36(fieldName);
            }
            if (fieldType == FieldType.FieldMergeField)
            {
                MergeField field2 = new MergeField(base.Document) {
                    FieldName = fieldName
                };
                field = field2;
            }
            else if (fieldType == FieldType.FieldSequence)
            {
                field = new SequenceField(base.Document);
            }
            else
            {
                field = new Field(base.Document);
            }
            field.Type = fieldType;
            if (field.Type == FieldType.FieldFormula)
            {
                fieldName = fieldName.Replace(BookmarkStart.b("ᄰ", num), string.Empty);
                fieldName = fieldName.Replace(BookmarkStart.b("ጰ", num), string.Empty);
                fieldName = fieldName.Replace(BookmarkStart.b("ర", num), string.Empty);
            }
            if ((fieldName.IndexOf(' ') != -1) && (field.Type != FieldType.FieldIndex))
            {
                field.m_fieldValue = BookmarkStart.b("ጰ", num) + fieldName + BookmarkStart.b("ጰ", num);
            }
            else
            {
                field.m_fieldValue = fieldName;
            }
            if (fieldType == FieldType.FieldDocVariable)
            {
                field.m_formattingString = BookmarkStart.b("洰ᤲᔴ稶簸椺稼稾݀ూᝄ੆ࡈὊ", num);
            }
            this.m_pItemColl.Add(field);
            if ((field.Type != FieldType.FieldMergeField) && (field.Type != FieldType.FieldNext))
            {
                field.Separator = this.AppendFieldMark(FieldMarkType.FieldSeparator);
            }
            if ((fieldType != FieldType.FieldMergeField) && (fieldType != FieldType.FieldNext))
            {
                TextRange entity = new TextRange(base.Document) {
                    Text = fieldName
                };
                this.m_pItemColl.Add(entity);
                if (fieldType == FieldType.FieldHyperlink)
                {
                    entity.CharacterFormat.method_55(Color.Blue);
                    entity.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
                }
                field.End = this.AppendFieldMark(FieldMarkType.FieldEnd);
            }
            return field;
        }

        public FieldMark AppendFieldMark(FieldMarkType type)
        {
            FieldMark mark = (FieldMark) this.method_62(ParagraphItemType.FieldMark);
            mark.Type = type;
            return mark;
        }

        public Footnote AppendFootnote(FootnoteType type)
        {
            return this.AppendFootnote(type, true);
        }

        public Footnote AppendFootnote(FootnoteType type, bool bIsAutoNumbered)
        {
            Footnote footnote = (Footnote) this.method_62(ParagraphItemType.Footnote);
            footnote.IsAutoNumbered = bIsAutoNumbered;
            footnote.FootnoteType = type;
            footnote.method_38();
            return footnote;
        }

        public void AppendHTML(string html)
        {
            int num = 15;
            string str = html.ToLower();
            if ((!str.StartsWith(BookmarkStart.b("ऴ弶䴸嘺儼", 15)) && !str.StartsWith(BookmarkStart.b("ऴ唶嘸强䐼", num))) && (!str.StartsWith(BookmarkStart.b("ऴᘶ崸吺帼䬾㡀㍂⁄", num)) && !str.StartsWith(BookmarkStart.b("ऴ࠶䄸嘺儼", num))))
            {
                html = BookmarkStart.b("ऴ弶䴸嘺儼ľ絀⭂⁄♆ⵈ畊煌㭎㡐❒㥔㉖癘敚慜灞ॠ٢Ѥͦ坨坪ཬnᕰੲ䭴", num) + html + BookmarkStart.b("ऴᠶ嬸吺夼䘾罀罂橄⽆㵈♊⅌煎", num);
            }
            using (Class747 class2 = new Class747(true))
            {
                if (this.IsStyleApplied)
                {
                    class2.imethod_1(base.OwnerTextBody, html, base.method_5(), this.Items.Count, this.ParaStyle, this.ListFormat.CurrentListStyle);
                }
                else
                {
                    class2.imethod_1(base.OwnerTextBody, html, base.method_5(), this.Items.Count, null, this.ListFormat.CurrentListStyle);
                }
            }
            if ((this.Items.Count == 0) && (base.OwnerTextBody != null))
            {
                base.OwnerTextBody.Items.Remove(this);
            }
        }

        public Field AppendHyperlink(string link, DocPicture picture, HyperlinkType type)
        {
            return this.method_33(link, null, picture, type);
        }

        public Field AppendHyperlink(string link, string text, HyperlinkType type)
        {
            return this.method_33(link, text, null, type);
        }

        public DocOleObject AppendOleObject(string pathToFile, DocPicture olePicture)
        {
            return this.AppendOleObject(pathToFile, olePicture, OleObjectType.Package);
        }

        public DocOleObject AppendOleObject(Stream oleStream, DocPicture olePicture, OleLinkType oleLinkType)
        {
            int num = 3;
            DocOleObject obj2 = this.method_62(ParagraphItemType.OleObject) as DocOleObject;
            obj2.SetOlePicture(olePicture);
            obj2.method_86(oleLinkType);
            try
            {
                oleStream.Position = 0L;
                Stream12 stream = new Stream12(oleStream);
                string s = stream.method_2()[0].Replace(BookmarkStart.b("瘨", num), string.Empty);
                int.Parse(s);
                obj2.Interface49.set_OleStorageName(s);
                stream.Close();
                stream.Dispose();
            }
            catch
            {
            }
            oleStream.Position = 0L;
            obj2.method_80(oleStream);
            if (oleLinkType == OleLinkType.Embed)
            {
                obj2.Field.Type = FieldType.FieldEmbed;
            }
            else
            {
                obj2.Field.Type = FieldType.FieldLink;
            }
            FieldMark entity = new FieldMark(base.m_doc) {
                Type = FieldMarkType.FieldSeparator
            };
            this.Items.Add(entity);
            if (olePicture.Owner != null)
            {
                olePicture = olePicture.Clone() as DocPicture;
            }
            this.Items.Add(olePicture);
            this.AppendFieldMark(FieldMarkType.FieldEnd);
            return obj2;
        }

        public DocOleObject AppendOleObject(byte[] oleBytes, DocPicture olePicture, OleLinkType oleLinkType)
        {
            MemoryStream oleStream = new MemoryStream(oleBytes);
            return this.AppendOleObject(oleStream, olePicture, oleLinkType);
        }

        public DocOleObject AppendOleObject(Stream oleStream, DocPicture olePicture, OleObjectType type)
        {
            int num = 12;
            if ((oleStream == null) || (oleStream.Length == 0L))
            {
                return null;
            }
            if (type == OleObjectType.Package)
            {
                throw new ArgumentException(BookmarkStart.b("戱堳匵夷䤹夻ḽ㔿ㅁ⅃晅े㩉㱋⭍㹏㙑᭓㩕㵗ᕙ㹛㑝՟šၣ乥㭧ṩṫ୭ᅯά味᥵ᑷό⽻੽ꒇꪉ좋슑ﶓﮝ肟춡좣쎥쎩쾫\udaad\uc5af삱톳骵颷즹좻첽ꦿ곁ꏃ껇ꏉꃋꯍ闏꫑ꃓ돕뛗꧙뗛뇝軟쯡쓣该跧黩蓫臭铯\udcf1\ud4f3훵ꣷ鯹鿻闽懿攁愃★簇猉簋欍』笑朓㘕焗琙樛缝䰟䬡䀣إ䄧䐩ఫ娭堯嬱䜳ᘵ嬷唹刻䨽┿㩁ぃ桅", num));
            }
            oleStream.Position = 0L;
            string tempFileName = Path.GetTempFileName();
            using (FileStream stream = new FileStream(tempFileName, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[oleStream.Length];
                oleStream.Read(buffer, 0, buffer.Length);
                stream.Write(buffer, 0, buffer.Length);
            }
            DocOleObject obj2 = this.AppendOleObject(tempFileName, olePicture, type);
            try
            {
                File.Delete(tempFileName);
            }
            catch (Exception)
            {
            }
            return obj2;
        }

        public DocOleObject AppendOleObject(Stream oleStream, DocPicture olePicture, string fileExtension)
        {
            oleStream.Position = 0L;
            byte[] buffer = new byte[oleStream.Length];
            oleStream.Read(buffer, 0, buffer.Length);
            return this.AppendOleObject(buffer, olePicture, fileExtension);
        }

        public DocOleObject AppendOleObject(string linkFile, DocPicture olePicture, OleLinkType oleLinkType)
        {
            if (oleLinkType == OleLinkType.Embed)
            {
                return this.AppendOleObject(linkFile, olePicture);
            }
            DocOleObject obj2 = this.method_62(ParagraphItemType.OleObject) as DocOleObject;
            obj2.SetOlePicture(olePicture);
            obj2.method_86(OleLinkType.Link);
            obj2.Interface49.set_LinkPath(linkFile);
            obj2.Interface49.set_ObjectType(Class1117.smethod_1(OleObjectType.Package, false));
            obj2.OleObjectType = OleObjectType.Package;
            obj2.Interface49.set_DisplayAsIcon(false);
            FieldMark entity = new FieldMark(base.m_doc) {
                Type = FieldMarkType.FieldSeparator
            };
            this.Items.Add(entity);
            if (olePicture.Owner != null)
            {
                olePicture = olePicture.Clone() as DocPicture;
            }
            this.Items.Add(olePicture);
            this.AppendFieldMark(FieldMarkType.FieldEnd);
            return obj2;
        }

        public DocOleObject AppendOleObject(byte[] oleBytes, DocPicture olePicture, OleObjectType type)
        {
            int num = 5;
            if ((oleBytes == null) || (oleBytes.Length == 0))
            {
                return null;
            }
            if (type == OleObjectType.Package)
            {
                throw new ArgumentException(BookmarkStart.b("笪䄬䨮倰䀲倴᜶䰸䠺堼Ἶ@㍂㕄≆❈⽊Ɍ⍎㑐᱒㝔㵖㱘㡚⥜睞͠ᩢᅤɦ㉨㙪䵬nᵰᙲ㝴๶൸Ṻ๼卾ꆀ잂\ud988\ue28aﮎ랖쾞좠삢톤튦\udba8\uceaa膬辮슰잲잴\udeb6\ud7b8\udcba\u9dbc\ud9be\ua8c0꿂ꃄ苆뇈뿊꣌ꇎꋐ뫒뫔맖ﯚ냜뫞闠询諤菦쟨쯪췬뿮郰郲黴零黸黺\uddfc\u8bfe砀猂怄✆怈砊ⴌ明缐攒琔笖瀘缚㴜瘞传̢儤伦䀨堪ബ䰮帰崲䄴制䄸伺ጼ", num));
            }
            MemoryStream oleStream = new MemoryStream(oleBytes);
            return this.AppendOleObject(oleStream, olePicture, type);
        }

        public DocOleObject AppendOleObject(string pathToFile, DocPicture olePicture, OleObjectType type)
        {
            DocOleObject entity = new DocOleObject(base.m_doc);
            this.Items.Add(entity);
            entity.SetOlePicture(olePicture);
            entity.method_86(OleLinkType.Embed);
            entity.Interface49.set_ObjectType(Class1117.smethod_1(type, false));
            entity.OleObjectType = type;
            entity.method_101(pathToFile);
            entity.Field.Type = FieldType.FieldEmbed;
            FieldMark mark = new FieldMark(base.m_doc) {
                Type = FieldMarkType.FieldSeparator
            };
            this.Items.Add(mark);
            if (olePicture.Owner != null)
            {
                olePicture = olePicture.Clone() as DocPicture;
            }
            this.Items.Add(olePicture);
            this.AppendFieldMark(FieldMarkType.FieldEnd);
            return entity;
        }

        public DocOleObject AppendOleObject(byte[] oleBytes, DocPicture olePicture, string fileExtension)
        {
            DocOleObject entity = new DocOleObject(base.m_doc);
            this.Items.Add(entity);
            entity.SetOlePicture(olePicture);
            entity.method_86(OleLinkType.Embed);
            entity.Interface49.set_ObjectType(Class1117.smethod_1(OleObjectType.Package, false));
            entity.OleObjectType = OleObjectType.Package;
            string str = BookmarkStart.b("瘥䤧䤩䜫伭圯圱ᨳ", 0) + fileExtension.Replace(BookmarkStart.b("ࠥ", 0), string.Empty);
            entity.method_102(oleBytes, str);
            entity.Field.Type = FieldType.FieldEmbed;
            FieldMark mark = new FieldMark(base.m_doc) {
                Type = FieldMarkType.FieldSeparator
            };
            this.Items.Add(mark);
            if (olePicture.Owner != null)
            {
                olePicture = olePicture.Clone() as DocPicture;
            }
            this.Items.Add(olePicture);
            this.AppendFieldMark(FieldMarkType.FieldEnd);
            return entity;
        }

        public PermissionEnd AppendPermEnd(string id)
        {
            PermissionEnd entity = new PermissionEnd(base.Document, id);
            this.Items.Add(entity);
            return entity;
        }

        public PermissionStart AppendPermStart(string id)
        {
            PermissionStart entity = new PermissionStart(base.Document, id);
            this.Items.Add(entity);
            return entity;
        }

        public DocPicture AppendPicture(byte[] imageBytes)
        {
            DocPicture picture = (DocPicture) this.method_62(ParagraphItemType.Picture);
            picture.LoadImage(imageBytes);
            base.Document.HasPicture = true;
            return picture;
        }

        public DocPicture AppendPicture(Image image)
        {
            DocPicture picture = this.method_62(ParagraphItemType.Picture) as DocPicture;
            picture.LoadImage(image);
            base.Document.HasPicture = true;
            return picture;
        }

        public void AppendRTF(string rtfCode)
        {
            this.AppendRTF(rtfCode, false);
        }

        public void AppendRTF(string rtfcode, bool addtolastsection)
        {
            using (Document document = new Document())
            {
                using (StringReader reader = new StringReader(rtfcode))
                {
                    using (Class834 class2 = new Class834(document, reader))
                    {
                        class2.method_41();
                        int index = 0;
                        if (document.ChildObjects.Count > 0)
                        {
                            DocumentObject entity = this;
                            while (!(entity is Section))
                            {
                                if (entity.Owner == null)
                                {
                                    break;
                                }
                                entity = entity.Owner;
                            }
                            if ((entity != null) && (entity is Section))
                            {
                                index = base.Document.ChildObjects.IndexOf(entity) + 1;
                            }
                            int num2 = 0;
                            int count = document.ChildObjects.Count;
                            while (num2 < count)
                            {
                                DocumentObject obj12 = document.ChildObjects[num2];
                                if ((num2 == 0) && (obj12 is Section))
                                {
                                    foreach (DocumentObject obj3 in (obj12 as Section).ChildObjects)
                                    {
                                        HeaderFooter footer;
                                        TableCell cell;
                                        if (this.IsInCell)
                                        {
                                            goto Label_070F;
                                        }
                                        if (!addtolastsection)
                                        {
                                            goto Label_0551;
                                        }
                                        if ((obj3 is Body) && ((obj3 as Body).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Body))
                                        {
                                            foreach (DocumentObject obj11 in (obj3 as Body).ChildObjects)
                                            {
                                                base.Document.LastSection.Body.ChildObjects.Add(obj11.Clone());
                                                this.method_30(base.Document.LastSection.Body.ChildObjects.LastItem as Paragraph, obj11);
                                            }
                                        }
                                        else if (obj3 is HeaderFooter)
                                        {
                                            footer = obj3 as HeaderFooter;
                                            switch (footer.Type)
                                            {
                                                case HeaderFooterType.HeaderEven:
                                                    goto Label_01D3;

                                                case HeaderFooterType.HeaderOdd:
                                                    goto Label_0268;

                                                case HeaderFooterType.FooterEven:
                                                    goto Label_02FD;

                                                case HeaderFooterType.FooterOdd:
                                                    goto Label_0392;

                                                case HeaderFooterType.HeaderFirstPage:
                                                    goto Label_0427;

                                                case HeaderFooterType.FooterFirstPage:
                                                    goto Label_04BC;
                                            }
                                        }
                                        continue;
                                    Label_01D3:
                                        foreach (DocumentObject obj6 in footer.ChildObjects)
                                        {
                                            base.Document.LastSection.HeadersFooters.EvenHeader.ChildObjects.Add(obj6.Clone());
                                            this.method_30(base.Document.LastSection.HeadersFooters.EvenHeader.ChildObjects.LastItem as Paragraph, obj6);
                                        }
                                        continue;
                                    Label_0268:
                                        foreach (DocumentObject obj7 in footer.ChildObjects)
                                        {
                                            base.Document.LastSection.HeadersFooters.OddHeader.ChildObjects.Add(obj7.Clone());
                                            this.method_30(base.Document.LastSection.HeadersFooters.OddHeader.ChildObjects.LastItem as Paragraph, obj7);
                                        }
                                        continue;
                                    Label_02FD:
                                        foreach (DocumentObject obj14 in footer.ChildObjects)
                                        {
                                            base.Document.LastSection.HeadersFooters.EvenFooter.ChildObjects.Add(obj14.Clone());
                                            this.method_30(base.Document.LastSection.HeadersFooters.EvenFooter.ChildObjects.LastItem as Paragraph, obj14);
                                        }
                                        continue;
                                    Label_0392:
                                        foreach (DocumentObject obj10 in footer.ChildObjects)
                                        {
                                            base.Document.LastSection.HeadersFooters.OddFooter.ChildObjects.Add(obj10.Clone());
                                            this.method_30(base.Document.LastSection.HeadersFooters.OddFooter.ChildObjects.LastItem as Paragraph, obj10);
                                        }
                                        continue;
                                    Label_0427:
                                        foreach (DocumentObject obj9 in footer.ChildObjects)
                                        {
                                            base.Document.LastSection.HeadersFooters.FirstPageHeader.ChildObjects.Add(obj9.Clone());
                                            this.method_30(base.Document.LastSection.HeadersFooters.FirstPageHeader.ChildObjects.LastItem as Paragraph, obj9);
                                        }
                                        continue;
                                    Label_04BC:
                                        foreach (DocumentObject obj13 in footer.ChildObjects)
                                        {
                                            base.Document.LastSection.HeadersFooters.FirstPageFooter.ChildObjects.Add(obj13.Clone());
                                            this.method_30(base.Document.LastSection.HeadersFooters.FirstPageFooter.ChildObjects.LastItem as Paragraph, obj13);
                                        }
                                        continue;
                                    Label_0551:
                                        if ((obj3 is Body) && ((obj3 as Body).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Body))
                                        {
                                            Body ownerTextBody = base.OwnerTextBody;
                                            if ((ownerTextBody == null) && (base.Document.LastSection != null))
                                            {
                                                ownerTextBody = base.Document.LastSection.Body;
                                            }
                                            if (ownerTextBody != null)
                                            {
                                                int num3 = 0;
                                                int num5 = (obj3 as Body).ChildObjects.Count;
                                                while (num3 < num5)
                                                {
                                                    DocumentObject obj4 = (obj3 as Body).ChildObjects[num3];
                                                    if (((num3 == 0) && (obj4 is Paragraph)) && (base.OwnerTextBody != null))
                                                    {
                                                        if (this.ChildObjects.Count > 0)
                                                        {
                                                            foreach (ParagraphBase base3 in (obj4 as Paragraph).ChildObjects)
                                                            {
                                                                this.ChildObjects.Add(base3.Clone());
                                                            }
                                                        }
                                                        else
                                                        {
                                                            ownerTextBody.ChildObjects.Add(obj4.Clone());
                                                            this.method_30(ownerTextBody.ChildObjects.LastItem as Paragraph, obj4);
                                                            ownerTextBody.ChildObjects.Remove(this);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        ownerTextBody.ChildObjects.Add(obj4.Clone());
                                                        this.method_30(ownerTextBody.ChildObjects.LastItem as Paragraph, obj4);
                                                    }
                                                    num3++;
                                                }
                                            }
                                            else
                                            {
                                                base.Document.ChildObjects.Insert(index, obj12.Clone());
                                                this.method_30(base.Document.ChildObjects.LastItem as Paragraph, obj12);
                                                index++;
                                            }
                                        }
                                        continue;
                                    Label_070F:
                                        cell = base.Owner as TableCell;
                                        if (cell == null)
                                        {
                                            DocumentObject owner = base.Owner;
                                            while (owner != null)
                                            {
                                                if (owner is TableCell)
                                                {
                                                    break;
                                                }
                                                owner = owner.Owner;
                                            }
                                            cell = owner as TableCell;
                                        }
                                        if (((cell != null) && (obj3 is Body)) && ((obj3 as Body).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Body))
                                        {
                                            Body body2 = cell;
                                            int num4 = 0;
                                            int num6 = (obj3 as Body).ChildObjects.Count;
                                            while (num4 < num6)
                                            {
                                                DocumentObject obj5 = (obj3 as Body).ChildObjects[num4];
                                                if ((num4 == 0) && (obj5 is Paragraph))
                                                {
                                                    if (this.ChildObjects.Count > 0)
                                                    {
                                                        foreach (ParagraphBase base2 in (obj5 as Paragraph).ChildObjects)
                                                        {
                                                            this.ChildObjects.Add(base2.Clone());
                                                        }
                                                    }
                                                    else
                                                    {
                                                        body2.ChildObjects.Add(obj5.Clone());
                                                        this.method_30(body2.ChildObjects.LastItem as Paragraph, obj5);
                                                        body2.ChildObjects.Remove(this);
                                                    }
                                                }
                                                else
                                                {
                                                    body2.ChildObjects.Add(obj5.Clone());
                                                    this.method_30(body2.ChildObjects.LastItem as Paragraph, obj5);
                                                }
                                                num4++;
                                            }
                                        }
                                    }
                                }
                                else if (!this.IsInCell)
                                {
                                    base.Document.ChildObjects.Insert(index, obj12.Clone());
                                    this.method_30(base.Document.ChildObjects.LastItem as Paragraph, obj12);
                                    index++;
                                }
                                else
                                {
                                    foreach (DocumentObject obj15 in (obj12 as Section).ChildObjects)
                                    {
                                        TableCell cell2 = base.Owner as TableCell;
                                        if (cell2 == null)
                                        {
                                            for (DocumentObject obj16 = base.Owner; obj16 != null; obj16 = obj16.Owner)
                                            {
                                                if (obj16 is TableCell)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        if (((cell2 != null) && (obj15 is Body)) && ((obj15 as Body).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Body))
                                        {
                                            foreach (DocumentObject obj17 in (obj15 as Body).ChildObjects)
                                            {
                                                cell2.ChildObjects.Add(obj17.Clone());
                                                this.method_30(cell2.ChildObjects.LastItem as Paragraph, obj17);
                                            }
                                        }
                                    }
                                }
                                num2++;
                            }
                        }
                    }
                }
                document.Close();
            }
        }

        public ShapeObject AppendShape(float width, float height, ShapeType shapeType)
        {
            ShapeObject obj2 = this.method_62(ParagraphItemType.ShapeObject) as ShapeObject;
            obj2.Width = width;
            obj2.Height = height;
            obj2.SetShapeType(shapeType);
            return obj2;
        }

        public ShapeGroup AppendShapeGroup(float width, float height)
        {
            ShapeGroup group = this.method_62(ParagraphItemType.ShapeGroup) as ShapeGroup;
            group.Width = width;
            group.Height = height;
            return group;
        }

        public Symbol AppendSymbol(byte characterCode)
        {
            Symbol symbol = (Symbol) this.method_62(ParagraphItemType.Symbol);
            symbol.CharacterCode = characterCode;
            return symbol;
        }

        public TextRange AppendText(string text)
        {
            TextRange range = this.method_62(ParagraphItemType.TextRange) as TextRange;
            range.Text = text;
            return range;
        }

        public TextBox AppendTextBox(float width, float height)
        {
            TextBox box = this.method_62(ParagraphItemType.TextBox) as TextBox;
            box.Format.Width = width;
            box.Format.Height = height;
            return box;
        }

        public TextFormField AppendTextFormField(string defaultText)
        {
            string formFieldName = (BookmarkStart.b("洸帺䔼䬾Ṁ", 0x13) + Guid.NewGuid().ToString().Replace(BookmarkStart.b("ᐸ", 0x13), BookmarkStart.b("昸", 0x13))).Substring(0, 20);
            return this.AppendTextFormField(formFieldName, defaultText);
        }

        public TextFormField AppendTextFormField(string formFieldName, string defaultText)
        {
            int num = 13;
            TextFormField entity = base.Document.CreateParagraphItem(ParagraphItemType.TextFormField) as TextFormField;
            entity.Name = formFieldName;
            if (defaultText == null)
            {
                entity.DefaultText = BookmarkStart.b("ㄒ㜔㔖㬘㤚", num);
            }
            else
            {
                entity.DefaultText = defaultText;
            }
            this.Items.Add(entity);
            return entity;
        }

        public TableOfContent AppendTOC(int lowerLevel, int upperLevel)
        {
            TableOfContent content = this.method_62(ParagraphItemType.TOC) as TableOfContent;
            content.LowerHeadingLevel = lowerLevel;
            content.UpperHeadingLevel = upperLevel;
            this.AppendFieldMark(FieldMarkType.FieldSeparator);
            this.AppendText(BookmarkStart.b("朲稴琶", 13));
            this.AppendFieldMark(FieldMarkType.FieldEnd);
            base.Document.TOC = content;
            return content;
        }

        public void ApplyStyle(BuiltinStyle builtinStyle)
        {
            int num = 13;
            this.IsStyleApplied = true;
            bool flag = Style.smethod_6(builtinStyle);
            this.method_80();
            if (flag)
            {
                this.method_79(builtinStyle);
            }
            else
            {
                string name = Style.smethod_4(builtinStyle);
                IStyle style = base.Document.Styles.FindByName(name, StyleType.ParagraphStyle) as IParagraphStyle;
                if (style == null)
                {
                    style = (IParagraphStyle) Style.CreateBuiltinStyle(builtinStyle, base.Document);
                    if ((style as ParagraphStyle).StyleDocId > 10)
                    {
                        (style as ParagraphStyle).StyleDocId = 0xffe;
                    }
                    base.Document.Styles.Add(style);
                    if ((builtinStyle != BuiltinStyle.MacroText) && (builtinStyle != BuiltinStyle.CommentSubject))
                    {
                        (style as ParagraphStyle).ApplyBaseStyle(BookmarkStart.b("紲娴䔶吸娺儼", num));
                    }
                }
                this.method_65(style as ParagraphStyle);
                this.method_26(style as Style);
            }
        }

        public void ApplyStyle(string styleName)
        {
            int num = 3;
            this.IsStyleApplied = true;
            ParagraphStyle style = base.Document.Styles.FindByName(styleName, StyleType.ParagraphStyle) as ParagraphStyle;
            if ((style == null) && (styleName == BookmarkStart.b("木䐪弬䈮倰弲", num)))
            {
                style = (ParagraphStyle) Style.CreateBuiltinStyle(BuiltinStyle.Normal, base.Document);
                base.Document.Styles.Add(style);
            }
            if (style == null)
            {
                throw new ArgumentException(BookmarkStart.b("礨䨪弬丮嘰䄲吴䜶儸ᬺ丼䬾㡀⽂⁄杆⩈⩊⍌潎㽐㱒⅔睖㭘㹚絜㥞๠ᙢ୤ͦ䝨", num));
            }
            this.method_65(style);
            this.method_26(style);
        }

        internal override bool CheckChangedCFormat()
        {
            return ((this.characterFormat_0 != null) && this.characterFormat_0.IsChangedFormat);
        }

        internal override bool CheckChangedPFormat()
        {
            return ((this.m_prFormat != null) && this.m_prFormat.IsChangedFormat);
        }

        internal override bool CheckDeleteRev()
        {
            return ((this.characterFormat_0 != null) && this.characterFormat_0.IsDeleteRevision);
        }

        internal override bool CheckInsertRev()
        {
            return ((this.characterFormat_0 != null) && this.characterFormat_0.IsInsertRevision);
        }

        protected override object CloneImpl()
        {
            return this.method_74(true);
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            if (doc.ImportOption == ImportOptions.UseDestinationStyles)
            {
                this.method_71(doc);
            }
            else if (doc.ImportOption == ImportOptions.MergeFormatting)
            {
                this.method_69(doc);
            }
            else
            {
                this.method_70(doc);
            }
            this.method_72(doc);
            int num = 0;
            int count = this.Items.Count;
            while (num < count)
            {
                this.Items[num].CloneRelationsTo(doc, nextOwner);
                num++;
            }
            if (doc.ImportOption != ImportOptions.UseDestinationStyles)
            {
                this.method_65(this.m_style);
            }
        }

        internal override void Close()
        {
            if ((this.m_pItemColl != null) && (this.m_pItemColl.Count > 0))
            {
                ParagraphBase base2 = null;
                for (int i = 0; i < this.m_pItemColl.Count; i++)
                {
                    base2 = this.m_pItemColl[i];
                    base2.Close();
                    base2 = null;
                }
                this.m_pItemColl.Clear();
                this.m_pItemColl = null;
            }
            if (this.m_prFormat != null)
            {
                this.m_prFormat.Close();
                this.m_prFormat = null;
            }
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
            this.m_listFormat = null;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class213(this);
            if ((((this.Items.Count == 0) && this.BreakCharacterFormat.HasValue(130)) && this.BreakCharacterFormat.Hidden) || this.method_96())
            {
                base.interface23_0.imethod_5(true);
            }
            if (this.IsInCell && ((base.OwnerTextBody as TableCell).CellFormat.TextDirection != TextDirection.TopToBottom))
            {
                base.interface23_0.imethod_31(true);
            }
            if ((this.Text == string.Empty) && this.RemoveEmpty)
            {
                base.interface23_0.imethod_5(true);
            }
            if (!(base.Owner is TableCell) && this.Format.IsFrame)
            {
                base.interface23_0.imethod_33(true);
            }
        }

        public override TextSelection Find(Regex pattern)
        {
            int num = 15;
            if (Class191.smethod_0(pattern))
            {
                throw new ArgumentException(BookmarkStart.b("昴制堸䤺帼圾慀あㅄ㕆⁈╊⩌潎㉐㉒㭔㥖㙘⽚絜㵞Ѡ䍢d੦ᥨὪᑬ", num));
            }
            List<TextSelection> list = Class192.smethod_0().method_1(this, pattern, true);
            if (list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        public TextSelection Find(string given, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Find(pattern);
        }

        internal override Class185 FindAll(Regex pattern)
        {
            return Class192.smethod_0().method_1(this, pattern, false);
        }

        public Spire.Doc.Formatting.ListFormat GetListFormatForApplyStyle()
        {
            Spire.Doc.Formatting.ListFormat format = new Spire.Doc.Formatting.ListFormat(this);
            format.method_25(this.ListFormat);
            for (ParagraphStyle style2 = this.ParaStyle; style2 != null; style2 = style2.BaseStyle)
            {
                if (!style2.ListFormat.IsEmptyList && (((style2.ListFormat.CurrentListStyle == null) || (style2.ListFormat.CurrentListLevel == null)) || (style2.StyleId == style2.ListFormat.CurrentListLevel.ParaStyleName)))
                {
                    format.method_25(style2.ListFormat);
                    continue;
                }
                bool flag = false;
                if (((!style2.ListFormat.IsEmptyList && !style2.ListFormat.HasKey(0)) && (!format.HasKey(0) && (style2.ListFormat.CurrentListStyle != null))) && (style2.StyleId != style2.ListFormat.CurrentListLevel.ParaStyleName))
                {
                    using (IEnumerator enumerator = style2.ListFormat.CurrentListStyle.Levels.GetEnumerator())
                    {
                        ListLevel current;
                        while (enumerator.MoveNext())
                        {
                            current = (ListLevel) enumerator.Current;
                            if (style2.StyleId == current.ParaStyleName)
                            {
                                goto Label_011A;
                            }
                        }
                        goto Label_015C;
                    Label_011A:
                        flag = true;
                        format.method_25(style2.ListFormat);
                        format.ListLevelNumber = style2.ListFormat.CurrentListStyle.Levels.method_6(current);
                    }
                }
            Label_015C:
                if (!flag)
                {
                    return format;
                }
            }
            return format;
        }

        internal override BodyRegion GetNextTextBodyItem()
        {
            if (base.NextSibling != null)
            {
                return (base.NextSibling as BodyRegion);
            }
            if (base.Owner is TableCell)
            {
                return (base.Owner as TableCell).method_61();
            }
            if (base.Owner is Body)
            {
                if (base.OwnerTextBody.Owner is TextBox)
                {
                    return (base.OwnerTextBody.Owner as TextBox).method_76();
                }
                if (base.OwnerTextBody.Owner is Section)
                {
                    return base.GetNextInSection(base.OwnerTextBody.Owner as Section);
                }
            }
            return null;
        }

        public ParagraphStyle GetStyle()
        {
            return (this.m_style as ParagraphStyle);
        }

        internal override bool HasTrackedChanges()
        {
            if ((base.IsInsertRevision || base.IsDeleteRevision) || (base.IsChangedCFormat || base.IsChangedPFormat))
            {
                return true;
            }
            foreach (ParagraphBase base2 in this.m_pItemColl)
            {
                if (base2.method_26())
                {
                    return true;
                }
            }
            return false;
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddRefElement(BookmarkStart.b("䌯䘱䴳娵崷", 10), this.GetStyle());
            base.XDLSHolder.AddElement(BookmarkStart.b("䀯匱䘳圵強䠹崻丽⠿潁≃⥅㩇❉ⵋ㩍", 10), this.m_prFormat);
            base.XDLSHolder.AddElement(BookmarkStart.b("匯娱唳䐵夷夹䠻嬽㈿潁≃⥅㩇❉ⵋ㩍", 10), this.characterFormat_0);
            base.XDLSHolder.AddElement(BookmarkStart.b("尯嬱䜳䈵ᔷ尹医䰽ⴿ⍁ぃ", 10), this.ListFormat);
            base.XDLSHolder.AddElement(BookmarkStart.b("夯䘱儳嬵䬷", 10), this.m_pItemColl);
        }

        public Section InsertSectionBreak()
        {
            return this.InsertSectionBreak(SectionBreakType.NewPage);
        }

        public Section InsertSectionBreak(SectionBreakType breakType)
        {
            int num = 3;
            Section section = this.method_49();
            if (section == null)
            {
                throw new Exception(BookmarkStart.b("昨尪䌬䨮䌰ጲ䘴制娸伺吼倾⽀捂♄♆❈╊≌㭎煐ㅒご睖㝘⹚ㅜ㍞你", num));
            }
            if (this.body_0.Owner is HeaderFooter)
            {
                throw new NotSupportedException(BookmarkStart.b("樨䨪䌬䄮帰䜲ᔴ帶圸䠺堼䴾㕀捂㙄≆⩈㽊⑌⁎㽐獒㝔╖㱘㩚㙜罞ݠౢᝤ䝦Ũ๪౬୮ᑰŲ啴ᅶᙸᑺॼ᩾ꎂﺌꆎ", num));
            }
            int num4 = section.method_5();
            Section entity = section.method_25();
            base.Document.Sections.Insert(num4 + 1, entity);
            entity.BreakCode = breakType;
            int num5 = base.method_5();
            int count = section.Body.Items.Count;
            List<BodyRegion> list = new List<BodyRegion>();
            for (int i = num5 + 1; i < count; i++)
            {
                list.Add(section.Body.Items[i]);
            }
            foreach (BodyRegion region in list)
            {
                entity.Body.Items.Add(region);
            }
            list.Clear();
            list = null;
            return entity;
        }

        internal override void MakeChanges(bool acceptChanges)
        {
            if (acceptChanges && (this.m_listFormat != null))
            {
                if (this.m_listFormat.NewStyleName != string.Empty)
                {
                    this.m_listFormat.ApplyStyle(this.m_listFormat.NewStyleName);
                }
                if (this.m_listFormat.NewListLevelNumber != -1)
                {
                    this.m_listFormat.ListLevelNumber = this.m_listFormat.NewListLevelNumber;
                }
                if (this.m_listFormat.NewLfoStyleName != null)
                {
                    this.m_listFormat.LFOStyleName = this.m_listFormat.NewLfoStyleName;
                }
            }
            ParagraphBase base2 = null;
            for (int i = 0; i < this.m_pItemColl.Count; i++)
            {
                base2 = this.m_pItemColl[i];
                if ((base2.IsDeleteRevision && acceptChanges) || (base2.IsInsertRevision && !acceptChanges))
                {
                    this.m_pItemColl.RemoveAt(i);
                    i--;
                }
                else
                {
                    if (base2.IsChangedCFormat && !acceptChanges)
                    {
                        base2.method_25();
                    }
                    base2.method_24();
                    if (base2 is TextBox)
                    {
                        (base2 as TextBox).Body.method_35(acceptChanges);
                    }
                    else if (base2 is Footnote)
                    {
                        (base2 as Footnote).TextBody.method_35(acceptChanges);
                    }
                }
            }
        }

        internal bool method_22()
        {
            bool flag = true;
            using (IEnumerator enumerator = this.m_pItemColl.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    if (((((current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.TextRange) || !string.IsNullOrEmpty((current as TextRange).Text.Trim())) && ((current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.Picture) || (((current as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind) && ((current as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText)))) && (((current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.TextBox) || (((current as TextBox).Format.TextWrappingStyle != TextWrappingStyle.Behind) && ((current as TextBox).Format.TextWrappingStyle != TextWrappingStyle.InFrontOfText))) && ((current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.Shape) || (((current as ShapeObject).TextWrappingStyle != TextWrappingStyle.Behind) && ((current as ShapeObject).TextWrappingStyle != TextWrappingStyle.InFrontOfText))))) && (((current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.XmlParaItem) || ((current as Class6).method_32() == null)) || (((current as Class6).method_32().TextWrappingStyle != TextWrappingStyle.Behind) && ((current as Class6).method_32().TextWrappingStyle != TextWrappingStyle.InFrontOfText))))
                    {
                        goto Label_0112;
                    }
                }
                return flag;
            Label_0112:
                flag = false;
            }
            return flag;
        }

        internal bool method_25()
        {
            bool flag;
            int num = 13;
            using (IEnumerator enumerator = this.Items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if ((current is TextRange) && (current as TextRange).TextToSplit.Contains(BookmarkStart.b("㨲", num)))
                    {
                        goto Label_0050;
                    }
                }
                return false;
            Label_0050:
                flag = true;
            }
            return flag;
        }

        private void method_26(Style A_0)
        {
        }

        internal CheckBoxFormField method_27()
        {
            string checkBoxName = (BookmarkStart.b("氮夰嘲嘴尶昸", 9) + Guid.NewGuid().ToString().Replace(BookmarkStart.b("Ȯ", 9), BookmarkStart.b("瀮", 9))).Substring(0, 20);
            return this.AppendCheckBox(checkBoxName, false);
        }

        internal CheckBoxFormField method_28(string A_0, bool A_1)
        {
            CheckBoxFormField entity = base.Document.CreateParagraphItem(ParagraphItemType.CheckBox) as CheckBoxFormField;
            entity.Name = A_0;
            entity.DefaultCheckBoxValue = A_1;
            this.Items.Add(entity);
            return entity;
        }

        internal Break method_29(BreakType A_0, LineBreakClear A_1)
        {
            Break entity = new Break(base.Document, A_0);
            if ((A_0 == BreakType.LineBreak) && (A_1 != LineBreakClear.None))
            {
                entity.ClearType = A_1;
            }
            this.Items.Add(entity);
            return entity;
        }

        private void method_30(Paragraph A_0, DocumentObject A_1)
        {
            if (((A_0 != null) && (A_0.ListFormat != null)) && (A_0.ListFormat.CurrentListLevel != null))
            {
                A_0.ListFormat.CurrentListLevel.Word6Legacy = (A_1 as Paragraph).ListFormat.CurrentListLevel.Word6Legacy;
            }
        }

        internal string method_31()
        {
            string str = string.Empty;
            for (int i = 0; i < this.Items.Count; i++)
            {
                DocumentObject obj2 = this.Items[i];
                if ((obj2 is TextRange) && (obj2.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                {
                    str = str + (obj2 as TextRange).Text;
                }
                else if (obj2 is Field)
                {
                    if (!base.Document.LayoutVariables.method_3().Contains(obj2 as Field))
                    {
                        (obj2 as Field).method_49();
                    }
                    str = str + (obj2 as Field).FieldResult;
                    i += this.Items.IndexOf((obj2 as Field).End);
                }
            }
            return str;
        }

        internal Break method_32(string A_0)
        {
            Break entity = new Break(base.Document, BreakType.LineBreak) {
                TextRange = { Text = A_0 }
            };
            this.Items.Add(entity);
            return entity;
        }

        internal Field method_33(string A_0, string A_1, DocPicture A_2, HyperlinkType A_3)
        {
            int num = 2;
            Field entity = new Field(base.Document) {
                Type = FieldType.FieldHyperlink
            };
            this.Items.Add(entity);
            entity.Separator = this.AppendFieldMark(FieldMarkType.FieldSeparator);
            if (A_1 != null)
            {
                ITextRange range = this.AppendText(A_1);
                Class11 style = Style.CreateBuiltinStyle(BuiltinStyle.Hyperlink, StyleType.CharacterStyle, base.Document) as Class11;
                if (style != null)
                {
                    base.Document.Styles.Add(style);
                    range.ApplyStyle(style.Name);
                }
                else
                {
                    range.CharacterFormat.method_55(Color.Blue);
                    range.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
                }
            }
            else if (A_2 != null)
            {
                this.Items.Add(A_2);
            }
            else
            {
                this.AppendText(BookmarkStart.b("性匩尫䬭䈯帱崳堵匷", num));
            }
            entity.End = this.AppendFieldMark(FieldMarkType.FieldEnd);
            Hyperlink hyperlink = new Hyperlink(entity) {
                Type = A_3
            };
            if ((A_3 != HyperlinkType.WebLink) && (A_3 != HyperlinkType.EMailLink))
            {
                if (hyperlink.Type == HyperlinkType.Bookmark)
                {
                    hyperlink.BookmarkName = A_0;
                    return entity;
                }
                if (hyperlink.Type == HyperlinkType.FileLink)
                {
                    hyperlink.FilePath = A_0;
                }
                return entity;
            }
            hyperlink.Uri = A_0;
            return entity;
        }

        internal IPicture method_34(byte[] A_0, bool A_1, bool A_2)
        {
            DocPicture picture = this.method_62(ParagraphItemType.Picture) as DocPicture;
            byte[] buffer = new HMACSHA1().ComputeHash(A_0);
            picture.method_103(A_0, buffer, A_1, A_2);
            base.Document.HasPicture = true;
            return picture;
        }

        internal void method_35(DocPicture A_0, Class517 A_1)
        {
            A_0.method_86(A_1);
            base.Document.HasPicture = true;
        }

        internal Field method_36(string A_0)
        {
            Field entity = new Field(base.Document) {
                Type = FieldType.FieldIndexEntry,
                m_formattingString = BookmarkStart.b("ਧ", 2) + A_0 + BookmarkStart.b("ਧ", 2)
            };
            entity.CharacterFormat.FieldVanishComplex = 0x81;
            this.Items.Add(entity);
            this.AppendFieldMark(FieldMarkType.FieldEnd).CharacterFormat.FieldVanishComplex = 0x81;
            return entity;
        }

        internal bool method_37(Paragraph A_0)
        {
            return this.Format.method_70(A_0.Format);
        }

        internal TextRange method_38()
        {
            return this.method_39(false);
        }

        internal TextRange method_39(bool A_0)
        {
            TextRange range = null;
            using (IEnumerator enumerator = this.WidgetCollection.GetEnumerator())
            {
                ParagraphBase current;
                while (enumerator.MoveNext())
                {
                    current = (ParagraphBase) enumerator.Current;
                    if ((current is TextRange) && ((current as TextRange).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                    {
                        return (current as TextRange);
                    }
                    if ((A_0 && (current is TextRange)) && ((current as TextRange).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Field))
                    {
                        goto Label_0067;
                    }
                }
                return range;
            Label_0067:
                range = current as TextRange;
            }
            return range;
        }

        internal TextRange method_40()
        {
            TextRange range = null;
            using (IEnumerator enumerator = this.m_pItemColl.GetEnumerator())
            {
                ParagraphBase current;
                while (enumerator.MoveNext())
                {
                    current = (ParagraphBase) enumerator.Current;
                    if ((current is TextRange) && ((current as TextRange).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                    {
                        goto Label_0042;
                    }
                }
                return range;
            Label_0042:
                range = current as TextRange;
            }
            return range;
        }

        internal List<List<DocumentObject>> method_41(Class196 A_0, out float A_1)
        {
            float num = 0f;
            List<List<DocumentObject>> list = new List<List<DocumentObject>>();
            List<DocumentObject> item = new List<DocumentObject>();
            IDocumentObjectCollection widgetCollection = this.WidgetCollection;
            List<char> list4 = new List<char> { 0x2f, 0x5f };
            List<char> list6 = new List<char> { 0x2c, 0x2e };
            for (int i = 0; i < this.WidgetCollection.Count; i++)
            {
                DocumentObject obj2 = this.WidgetCollection[i];
                if (obj2 is TextRange)
                {
                    TextRange range2 = obj2 as TextRange;
                    if (range2 is Field)
                    {
                        Field field = range2 as Field;
                        if ((((field.Type == FieldType.FieldNumPages) || (field.Type == FieldType.FieldPage)) || (field.Type == FieldType.FieldSectionPages)) && !base.Document.LayoutVariables.method_3().Contains(range2 as Field))
                        {
                            field.method_49();
                            continue;
                        }
                    }
                    int startPos = range2.StartPos;
                    int num7 = range2.StartPos;
                    int length = range2.Text.Length;
                    StringBuilder builder = new StringBuilder();
                    int num3 = 0;
                    int num4 = range2.Text.Length;
                    while (num3 < num4)
                    {
                        char c = '\0';
                        char ch2 = '\0';
                        char ch = range2.Text[num3];
                        bool flag = false;
                        if (num3 > 0)
                        {
                            c = range2.Text[num3 - 1];
                        }
                        if ((num3 + 1) < num4)
                        {
                            ch2 = range2.Text[num3 + 1];
                        }
                        if ((char.IsDigit(c) && char.IsDigit(ch2)) && list6.Contains(ch))
                        {
                            flag = true;
                        }
                        if (char.IsWhiteSpace(ch))
                        {
                            builder.Append(ch);
                            TextRange range = new TextRange(base.Document);
                            range.ApplyCharacterFormat(range2.CharacterFormat);
                            range.Text = builder.ToString();
                            item.Add(range);
                            builder.Remove(0, builder.Length);
                            list.Add(item);
                            item = new List<DocumentObject>();
                        }
                        else if ((!flag && char.IsPunctuation(ch)) && !list4.Contains(ch))
                        {
                            if (Class203.smethod_2(ch))
                            {
                                TextRange range5 = new TextRange(base.Document);
                                range5.ApplyCharacterFormat(range2.CharacterFormat);
                                range5.Text = builder.ToString();
                                item.Add(range5);
                                builder.Remove(0, builder.Length);
                                list.Add(item);
                                builder.Append(ch);
                                item = new List<DocumentObject>();
                            }
                            else
                            {
                                builder.Append(ch);
                                int num6 = builder.Length;
                                TextRange range4 = new TextRange(base.Document);
                                range4.ApplyCharacterFormat(range2.CharacterFormat);
                                range4.Text = builder.ToString();
                                builder.Remove(0, num6);
                                if (((num3 == 0) && (item.Count == 0)) && ((num6 == 1) && (list.Count > 0)))
                                {
                                    list[list.Count - 1].Add(range4);
                                }
                                else
                                {
                                    item.Add(range4);
                                    list.Add(item);
                                }
                                item = new List<DocumentObject>();
                            }
                        }
                        else if ((ch >= '一') && (ch <= 0x9fbb))
                        {
                            builder.Append(ch);
                            int num5 = builder.Length;
                            TextRange range3 = new TextRange(base.Document);
                            range3.ApplyCharacterFormat(range2.CharacterFormat);
                            range3.Text = builder.ToString();
                            builder.Remove(0, num5);
                            item.Add(range3);
                            list.Add(item);
                            item = new List<DocumentObject>();
                        }
                        else
                        {
                            builder.Append(ch);
                        }
                        num3++;
                    }
                    if (builder.Length > 0)
                    {
                        TextRange range6 = new TextRange(base.Document);
                        range6.ApplyCharacterFormat(range2.CharacterFormat);
                        range6.Text = builder.ToString();
                        item.Add(range6);
                        builder.Remove(0, builder.Length);
                    }
                }
                else if ((obj2 is DocPicture) && (((obj2 as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline) || (((obj2 as DocPicture).LayoutInCell && ((obj2 as DocPicture).TextWrappingStyle != TextWrappingStyle.Behind)) && ((obj2 as DocPicture).TextWrappingStyle != TextWrappingStyle.InFrontOfText))))
                {
                    List<DocumentObject> list10;
                    list10 = new List<DocumentObject> {
                        obj2,
                        list10
                    };
                }
                else if ((obj2 is Class6) && (((obj2 as Class6).method_32() != null) || ((obj2 as Class6).method_30() != null)))
                {
                    Class6 class2 = obj2 as Class6;
                    if ((class2.method_32() != null) && ((class2.method_32().TextWrappingStyle == TextWrappingStyle.Inline) || ((class2.method_32().AllowInCell && (class2.method_32().TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (class2.method_32().TextWrappingStyle != TextWrappingStyle.Behind))))
                    {
                        List<DocumentObject> list11;
                        list11 = new List<DocumentObject> {
                            class2.method_32(),
                            list11
                        };
                    }
                    else if ((class2.method_30() != null) && ((class2.method_30().TextWrappingStyle == TextWrappingStyle.Inline) || ((class2.method_30().LayoutInCell && (class2.method_30().TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && (class2.method_30().TextWrappingStyle != TextWrappingStyle.Behind))))
                    {
                        List<DocumentObject> list9;
                        list9 = new List<DocumentObject> {
                            class2.method_30(),
                            list9
                        };
                    }
                }
                else if ((obj2 is TextBox) && (((obj2 as TextBox).Format.TextWrappingStyle == TextWrappingStyle.Inline) || (((obj2 as TextBox).Format.IsAllowInCell && ((obj2 as TextBox).Format.TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && ((obj2 as TextBox).Format.TextWrappingStyle != TextWrappingStyle.Behind))))
                {
                    List<DocumentObject> list7;
                    list7 = new List<DocumentObject> {
                        obj2,
                        list7
                    };
                }
                else if ((obj2 is ShapeObject) && (((obj2 as ShapeObject).TextWrappingStyle == TextWrappingStyle.Inline) || (((obj2 as ShapeObject).AllowInCell && ((obj2 as ShapeObject).TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && ((obj2 as ShapeObject).TextWrappingStyle != TextWrappingStyle.Behind))))
                {
                    List<DocumentObject> list8;
                    list8 = new List<DocumentObject> {
                        obj2,
                        list8
                    };
                }
                else if ((obj2 is Break) && ((obj2 as Break).BreakType == BreakType.LineBreak))
                {
                    List<DocumentObject> list12;
                    if (item.Count > 0)
                    {
                        list.Add(item);
                        item = new List<DocumentObject>();
                    }
                    list12 = new List<DocumentObject> {
                        obj2,
                        list12
                    };
                }
            }
            if (item.Count > 0)
            {
                list.Add(item);
                item = new List<DocumentObject>();
            }
            item.Clear();
            item = null;
            A_1 = num;
            return list;
        }

        internal bool method_42()
        {
            bool flag;
            using (IEnumerator enumerator = this.Items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    if (!(current is TextRange))
                    {
                        goto Label_002D;
                    }
                }
                return true;
            Label_002D:
                flag = false;
            }
            return flag;
        }

        internal bool method_43()
        {
            bool flag = true;
            int num = 0;
            using (IEnumerator enumerator = this.Items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    if (current is TextRange)
                    {
                        num++;
                    }
                    if (num > 1)
                    {
                        goto Label_0039;
                    }
                }
                return flag;
            Label_0039:
                flag = false;
            }
            return flag;
        }

        internal bool method_44()
        {
            for (DocumentObject obj2 = base.Owner; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2 is HeaderFooter)
                {
                    return true;
                }
            }
            return false;
        }

        internal bool method_45()
        {
            int num = 5;
            if (((this == null) || (this.ChildObjects.FirstItem == null)) || (!(this.ChildObjects.FirstItem is TableOfContent) && ((!(this.ChildObjects.FirstItem is Field) || ((this.ChildObjects.FirstItem as Field).Type != FieldType.FieldHyperlink)) || ((new Hyperlink(this.ChildObjects.FirstItem as Field).BookmarkName == null) || !new Hyperlink(this.ChildObjects.FirstItem as Field).BookmarkName.StartsWith(BookmarkStart.b("琪礬䀮到", num))))))
            {
                return false;
            }
            return true;
        }

        internal bool method_46()
        {
            DocumentObject owner = base.Owner;
            return ((owner is TableCell) || (((owner is SDTContent) && ((owner as SDTContent).Owner != null)) && ((owner as SDTContent).Owner.Owner is TableCell)));
        }

        internal int method_47(string A_0, string A_1, bool A_2, bool A_3)
        {
            Regex regex = Class191.smethod_1(A_0, A_2, A_3);
            return this.method_48(regex, A_1);
        }

        internal int method_48(Regex A_0, string A_1)
        {
            int num2 = 7;
            if (Class191.smethod_0(A_0))
            {
                throw new ArgumentException(BookmarkStart.b("縬䨮倰䄲嘴弶ᤸ䠺䤼䴾⡀ⵂ≄杆⩈⩊⍌ⅎ㹐❒畔㕖㱘筚㡜㉞ᅠᝢᱤ", num2));
            }
            Class193 class2 = Class193.smethod_0();
            bool replaceFirst = base.Document.ReplaceFirst;
            base.Document.ReplaceFirst = true;
            int num = class2.method_0(this, A_0, A_1);
            base.Document.ReplaceFirst = replaceFirst;
            return num;
        }

        internal Section method_49()
        {
            DocumentObject owner = this;
            while (!(owner is Section))
            {
                if (owner is Body)
                {
                    this.body_0 = owner as Body;
                }
                if (owner.Owner == null)
                {
                    break;
                }
                owner = owner.Owner;
            }
            return (owner as Section);
        }

        internal TableCell method_50()
        {
            for (DocumentObject obj2 = base.Owner; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2 is TableCell)
                {
                    return (obj2 as TableCell);
                }
            }
            return null;
        }

        internal ParagraphItemCollection method_51()
        {
            int num = 0x11;
            ParagraphItemCollection items = new ParagraphItemCollection(this);
            int index = 0;
            bool flag = false;
            for (int i = 0; i < this.m_pItemColl.Count; i++)
            {
                if (this.m_pItemColl[i] is StructureDocumentTagInline)
                {
                    StructureDocumentTagInline inline = this.m_pItemColl[i] as StructureDocumentTagInline;
                    inline.UpdateDataBinding();
                    inline.method_32(items);
                    if (((i == (this.m_pItemColl.Count - 1)) && (inline.ChildObjects.LastItem is Break)) && ((inline.ChildObjects.LastItem as Break).BreakType == BreakType.LineBreak))
                    {
                        items.InnerList.Add(this.method_52(inline.ChildObjects.LastItem as Break));
                    }
                    continue;
                }
                if ((this.m_pItemColl[i] is TextRange) && ((this.m_pItemColl[i] as TextRange).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                {
                    (this.m_pItemColl[i] as TextRange).method_42(items);
                    continue;
                }
                if (((i > 0) && (((this.m_pItemColl[i] is DocPicture) && ((((this.m_pItemColl[i] as DocPicture).TextWrappingStyle == TextWrappingStyle.Tight) || ((this.m_pItemColl[i] as DocPicture).TextWrappingStyle == TextWrappingStyle.Square)) || ((this.m_pItemColl[i] as DocPicture).TextWrappingStyle == TextWrappingStyle.Through))) || (((this.m_pItemColl[i] is TextBox) && (!(this.m_pItemColl[i - 1] is Class6) || (((this.m_pItemColl[i - 1] is Class6) && ((this.m_pItemColl[i - 1] as Class6).method_32() != null)) && (((this.m_pItemColl[i] as TextBox).ShapeInfo != null) && ((this.m_pItemColl[i - 1] as Class6).method_32() != (this.m_pItemColl[i] as TextBox).ShapeInfo))))) && ((((this.m_pItemColl[i] as TextBox).Format.TextWrappingStyle == TextWrappingStyle.Tight) || ((this.m_pItemColl[i] as TextBox).Format.TextWrappingStyle == TextWrappingStyle.Square)) || ((this.m_pItemColl[i] as TextBox).Format.TextWrappingStyle == TextWrappingStyle.Through))))) && ((!(this.m_pItemColl[i - 1] is ShapeObject) || !(this.m_pItemColl[i] is TextBox)) || ((this.m_pItemColl[i] as TextBox).ShapeInfo != (this.m_pItemColl[i - 1] as ShapeObject))))
                {
                    items.InnerList.Insert(index, this.m_pItemColl[i]);
                    index++;
                    continue;
                }
                if ((this.m_pItemColl[i] is Break) && ((this.m_pItemColl[i] as Break).BreakType != BreakType.LineBreak))
                {
                    int num4 = i + 1;
                    while (num4 < this.m_pItemColl.Count)
                    {
                        if ((!(this.m_pItemColl[num4] is BookmarkStart) || !(this.m_pItemColl[num4] as BookmarkStart).Name.StartsWith(BookmarkStart.b("栶縸吺缼帾≀⡂", num))) && (!(this.m_pItemColl[num4] is BookmarkEnd) || !(this.m_pItemColl[num4] as BookmarkEnd).Name.StartsWith(BookmarkStart.b("栶縸吺缼帾≀⡂", num))))
                        {
                            break;
                        }
                        num4++;
                    }
                    if (num4 == this.m_pItemColl.Count)
                    {
                        items.InnerList.Add(this.m_pItemColl[i]);
                        flag = true;
                        index = i;
                        continue;
                    }
                    index = i + 1;
                }
                if (flag)
                {
                    items.InnerList.Insert(index, this.m_pItemColl[i]);
                    index++;
                }
                else
                {
                    items.InnerList.Add(this.m_pItemColl[i]);
                }
            }
            return items;
        }

        private ParagraphBase method_52(Break A_0)
        {
            if ((A_0.BreakType == BreakType.LineBreak) && !this.IsEndOfSection)
            {
                ParagraphBase base2 = A_0.TextRange.Clone() as ParagraphBase;
                (base2 as TextRange).Text = string.Empty;
                (base2 as TextRange).IsAddForBreak = true;
                base2.CharacterFormat.ApplyBase(A_0.CharacterFormat);
                base2.method_0(this);
                return base2;
            }
            return this.paragraphItemCollection_0[0];
        }

        private TextRange method_53()
        {
            if (this.m_pItemColl.Count > 0)
            {
                int num = 0;
                int count = this.m_pItemColl.Count;
                while (num < count)
                {
                    DocumentObject obj2 = this.m_pItemColl[num];
                    if ((obj2 is TextRange) && (obj2.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                    {
                        return (obj2 as TextRange);
                    }
                    num++;
                }
            }
            return null;
        }

        internal TextRange method_54()
        {
            if (this.FirstTextRange != null)
            {
                return this.FirstTextRange;
            }
            return (this.paragraphItemCollection_0[0] as TextRange);
        }

        internal string method_55()
        {
            string str = string.Empty;
            for (int i = 0; i < this.Items.Count; i++)
            {
                ParagraphBase base2 = this.Items[i];
                if ((base2 is TextRange) && ((base2 as TextRange).DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.TextRange))
                {
                    str = str + (base2 as TextRange).Text;
                }
                else if (base2 is Field)
                {
                    Field item = base2 as Field;
                    if (!base.Document.LayoutVariables.method_3().Contains(item))
                    {
                        item.method_49();
                    }
                    str = str + item.FieldResult;
                    i += this.Items.IndexOf(item.End) - i;
                }
            }
            return str;
        }

        internal bool method_56()
        {
            if (this.m_pItemColl.Count <= 0)
            {
                return false;
            }
            bool flag = true;
            using (IEnumerator enumerator = this.m_pItemColl.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if (current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.BookmarkEnd)
                    {
                        goto Label_0043;
                    }
                }
                return flag;
            Label_0043:
                flag = false;
            }
            return flag;
        }

        internal void method_57()
        {
            this.Items.InnerList.Clear();
            this.stringBuilder_0 = new StringBuilder(1);
        }

        internal Class185 method_58(Regex A_0)
        {
            return Class192.smethod_0().method_1(this, A_0, true);
        }

        internal void method_59(int A_0, bool A_1)
        {
            if (A_1)
            {
                while (A_0 < this.Items.Count)
                {
                    this.Items.RemoveAt(A_0);
                }
            }
            else
            {
                while (A_0 > -1)
                {
                    this.Items.RemoveAt(A_0);
                    A_0--;
                }
            }
        }

        internal Paragraph method_60()
        {
            return this.method_74(false);
        }

        internal Paragraph method_61()
        {
            Paragraph paragraph = this.method_60();
            for (int i = 0; i < this.m_pItemColl.Count; i++)
            {
                ParagraphBase base2 = this.m_pItemColl[i];
                if ((base2 is Field) && ((base2 as Field).Type == FieldType.FieldAsk))
                {
                    i = this.m_pItemColl.IndexOf((base2 as Field).End);
                }
                else
                {
                    ParagraphBase base3 = (ParagraphBase) base2.Clone();
                    if (base3 != null)
                    {
                        base3.method_0(paragraph.Items.Owner);
                        paragraph.Items.method_25(base3);
                    }
                }
            }
            return paragraph;
        }

        internal IParagraphBase method_62(ParagraphItemType A_0)
        {
            IParagraphBase entity = base.Document.CreateParagraphItem(A_0);
            this.Items.Add(entity);
            return entity;
        }

        internal void method_63(TextRange A_0, string A_1)
        {
            this.method_64(A_0, A_0.TextLength, A_1);
        }

        internal void method_64(ParagraphBase A_0, int A_1, string A_2)
        {
            int num = 11;
            this.stringBuilder_0.Remove(A_0.StartPos, A_1);
            this.stringBuilder_0.Insert(A_0.StartPos, A_2);
            int num2 = A_2.Length - A_1;
            int index = this.m_pItemColl.IndexOf(A_0);
            if (index < 0)
            {
                throw new InvalidOperationException(BookmarkStart.b("䄰稲䄴制吸ᬺ唼帾㝀♂⭄恆㵈歊⭌⁎⑐㵒ㅔ睖じ㕚絜⽞`ᅢѤf᭨੪ᵬݮ兰ᩲŴቶᑸࡺ", num));
            }
            int num4 = index + 1;
            int count = this.m_pItemColl.Count;
            while (num4 < count)
            {
                ParagraphBase base2 = this.m_pItemColl[num4];
                if (base2 != null)
                {
                    if (base2 is TextRange)
                    {
                        (base2 as TextRange).method_44(base2.StartPos, num2);
                    }
                    base2.StartPos += num2;
                }
                num4++;
            }
        }

        internal void method_65(IParagraphStyle A_0)
        {
            int num = 15;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("嬴制丸栺䤼䘾ⵀ♂", num));
            }
            this.m_style = A_0;
            this.method_77();
            this.method_26(A_0 as Style);
            if (A_0.Name != BookmarkStart.b("笴堶䬸嘺尼匾", num))
            {
                this.Format.SetAttr(0x3e8, (A_0 as Style).StyleDocId);
            }
        }

        internal void method_66(int A_0, int A_1, string A_2)
        {
            int length = A_2.Length;
            this.stringBuilder_0.Remove(A_0, A_1);
            this.stringBuilder_0.Insert(A_0, A_2);
        }

        internal void method_67(ParagraphItemCollection A_0, int A_1)
        {
            this.method_68(A_0, A_1, null);
        }

        internal void method_68(ParagraphItemCollection A_0, int A_1, Field A_2)
        {
            if (A_0 != null)
            {
                Stack<Field> stack = new Stack<Field>();
                stack.Push(A_2);
                Field item = A_2;
                int num2 = A_0.Count - A_1;
                for (int i = 0; i < num2; i++)
                {
                    IDocumentObject obj2 = A_0[A_1];
                    if (((obj2 is Field) && !(obj2 is MergeField)) || (obj2 is FormField))
                    {
                        int endPos = (this.ChildObjects.LastItem as ParagraphBase).EndPos;
                        this.ChildObjects.InnerList.Add(obj2);
                        A_0.InnerList.RemoveAt(A_1);
                        (obj2 as ParagraphBase).StartPos = endPos;
                        (obj2 as ParagraphBase).method_0(this);
                        stack.Push(item);
                        item = obj2 as Field;
                    }
                    else
                    {
                        this.ChildObjects.Add(obj2);
                        if ((item != null) && (obj2 is FieldMark))
                        {
                            FieldMark mark = obj2 as FieldMark;
                            if (mark.Type == FieldMarkType.FieldSeparator)
                            {
                                item.Separator = mark;
                            }
                            else
                            {
                                item.End = mark;
                                item = stack.Pop();
                            }
                        }
                    }
                }
                stack = null;
                item = null;
            }
        }

        private void method_69(Document A_0)
        {
            Paragraph lastParagraph = A_0.LastParagraph;
            if (lastParagraph == null)
            {
                lastParagraph = new Paragraph(A_0);
            }
            this.Format.ImportContainer(lastParagraph.Format);
            this.Format.method_21(lastParagraph.Format);
            this.BreakCharacterFormat.method_77(lastParagraph.BreakCharacterFormat);
            this.m_style = lastParagraph.m_style;
        }

        private void method_70(Document A_0)
        {
            ParagraphStyle style = A_0.Styles.FindByName(BookmarkStart.b("縯崱䘳嬵夷嘹", 10), StyleType.ParagraphStyle) as ParagraphStyle;
            if (style == null)
            {
                style = (ParagraphStyle) Style.CreateBuiltinStyle(BuiltinStyle.Normal, A_0);
                A_0.Styles.Add(style);
            }
            if (A_0.ImportOption == ImportOptions.KeepSourceFormatting)
            {
                this.Format.method_64(style.ParagraphFormat);
                this.BreakCharacterFormat.method_79(style.CharacterFormat);
            }
            this.m_style = style;
        }

        private void method_71(Document A_0)
        {
            if (A_0.ImportStyles)
            {
                this.method_73(A_0);
            }
            else
            {
                IStyle style2 = A_0.Styles.FindByName(this.m_style.Name, StyleType.ParagraphStyle);
                if (style2 != null)
                {
                    this.method_65(style2 as ParagraphStyle);
                }
                else
                {
                    if (this.m_style is ParagraphStyle)
                    {
                        (this.m_style as ParagraphStyle).method_24(A_0);
                    }
                    ParagraphStyle style = this.m_style.Clone() as ParagraphStyle;
                    A_0.Styles.Add(style);
                    this.method_65(style);
                    if ((A_0.CurClonedSection != null) && !A_0.Styles.OldParaStylesHolder.ContainsKey(style.StyleId))
                    {
                        A_0.Styles.OldParaStylesHolder.Add(style.StyleId, style.Name);
                    }
                    if (!A_0.Styles.EmbedDocumentCloneStyleName.ContainsKey(style.StyleId))
                    {
                        A_0.Styles.EmbedDocumentCloneStyleName.Add(style.StyleId, style.Name);
                    }
                }
            }
        }

        private void method_72(Document A_0)
        {
            if (this.ListFormat.ListType != ListType.NoList)
            {
                ListStyle currentListStyle = this.ListFormat.CurrentListStyle;
                if (A_0.ListStyles.FindByName(currentListStyle.Name) == null)
                {
                    A_0.ListStyles.Add((ListStyle) currentListStyle.Clone());
                }
            }
            if ((this.ListFormat.LFOStyleName != null) && (A_0.ListOverrides.method_35(this.ListFormat.LFOStyleName) == null))
            {
                Class12 class2 = base.Document.ListOverrides.method_35(this.ListFormat.LFOStyleName);
                if (class2 != null)
                {
                    A_0.ListOverrides.method_34((Class12) class2.Clone());
                }
            }
        }

        private void method_73(Document A_0)
        {
            int num = 4;
            if (this.m_style != null)
            {
                IStyle style = A_0.Styles.FindByName(this.m_style.Name, StyleType.ParagraphStyle);
                IStyle style2 = A_0.Styles.FindByName(this.m_style.StyleId, StyleType.ParagraphStyle);
                if (style == null)
                {
                    (this.m_style as Style).method_18(A_0);
                    if (this.m_style is ParagraphStyle)
                    {
                        (this.m_style as ParagraphStyle).method_24(A_0);
                    }
                    style = A_0.Styles.FindByName(this.m_style.Name, StyleType.ParagraphStyle);
                    if (style is IParagraphStyle)
                    {
                        if ((style2 != null) && (style as Style).HasStyleId)
                        {
                            string str3;
                            string newValue = Guid.NewGuid().ToString();
                            string styleId = style.StyleId;
                            if (Style.smethod_0(styleId, out str3))
                            {
                                styleId = styleId.Replace(str3, newValue);
                            }
                            else
                            {
                                styleId = styleId + BookmarkStart.b("甩", num) + newValue;
                            }
                            (style as ParagraphStyle).method_5(styleId);
                        }
                        this.method_65(style as IParagraphStyle);
                        if ((A_0.CurClonedSection != null) && !A_0.Styles.OldParaStylesHolder.ContainsKey(style.StyleId))
                        {
                            A_0.Styles.OldParaStylesHolder.Add(style.StyleId, style.Name);
                        }
                        if (!A_0.Styles.EmbedDocumentCloneStyleName.ContainsKey(style.StyleId))
                        {
                            A_0.Styles.EmbedDocumentCloneStyleName.Add(style.StyleId, this.m_style.Name);
                        }
                    }
                }
                else if (A_0.CurClonedSection != null)
                {
                    this.m_style = (ParagraphStyle) (this.m_style as Style).method_20(A_0, style);
                    (this.m_style as ParagraphStyle).method_24(A_0);
                    this.method_65(this.m_style);
                }
                else if (!A_0.Styles.EmbedDocumentCloneStyleName.ContainsKey(style.StyleId))
                {
                    this.m_style = (ParagraphStyle) (this.m_style as Style).method_16(this.m_style, A_0);
                    (this.m_style as ParagraphStyle).method_24(A_0);
                    if (!A_0.Styles.EmbedDocumentCloneStyleName.ContainsKey(style.StyleId))
                    {
                        A_0.Styles.EmbedDocumentCloneStyleName.Add(style.StyleId, this.m_style.Name);
                    }
                    this.method_65(this.m_style);
                }
                else
                {
                    this.method_65(A_0.Styles.FindByName(A_0.Styles.EmbedDocumentCloneStyleName[style.StyleId], StyleType.ParagraphStyle) as ParagraphStyle);
                }
            }
        }

        private Paragraph method_74(bool A_0)
        {
            Paragraph paragraph = (Paragraph) base.CloneImpl();
            paragraph.stringBuilder_0 = new StringBuilder(this.Text);
            paragraph.m_pItemColl = new ParagraphItemCollection(paragraph);
            if (A_0)
            {
                this.m_pItemColl.method_22(paragraph.m_pItemColl);
            }
            foreach (DocumentObject obj2 in paragraph.Items)
            {
                if ((obj2 is Comment) && ((obj2 as Comment).ReplyCommentItems.Count > 0))
                {
                    (obj2 as Comment).method_30();
                }
            }
            paragraph.characterFormat_0 = new CharacterFormat(base.Document);
            paragraph.m_prFormat = new ParagraphFormat(base.Document);
            paragraph.characterFormat_0.ImportContainer(this.BreakCharacterFormat);
            paragraph.characterFormat_0.method_21(this.BreakCharacterFormat);
            paragraph.m_prFormat.ImportContainer(this.Format);
            if (paragraph.ListFormat.ListType != ListType.NoList)
            {
                paragraph.m_listFormat = new Spire.Doc.Formatting.ListFormat(paragraph);
                paragraph.m_listFormat.ImportContainer(this.ListFormat);
                paragraph.m_listFormat.method_21(this.ListFormat);
            }
            paragraph.m_listFormat.IsEmptyList = this.ListFormat.IsEmptyList;
            IParagraphStyle style = this.GetStyle();
            if (style != null)
            {
                ParagraphStyle style2 = style.Clone() as ParagraphStyle;
                paragraph.method_65(style2);
            }
            if (this.Format.TableStyleParagraphFormat != null)
            {
                paragraph.Format.TableStyleParagraphFormat = this.Format.TableStyleParagraphFormat;
            }
            paragraph.paragraphItemCollection_0 = new ParagraphItemCollection(paragraph);
            this.paragraphItemCollection_0.method_22(paragraph.paragraphItemCollection_0);
            foreach (ParagraphBase base2 in paragraph.paragraphItemCollection_0)
            {
                (base2 as TextRange).CharacterFormat.ApplyBase(this.characterFormat_0);
                (base2 as TextRange).OwnerEmptyParagraph = paragraph;
            }
            paragraph.m_prFormat.method_0(paragraph);
            if (Document.IsCloneParagraphCheckFormat)
            {
                paragraph.m_prFormat.method_72(this.Format, style);
            }
            paragraph.characterFormat_0.method_0(paragraph);
            paragraph.interface23_0 = null;
            return paragraph;
        }

        internal string method_75()
        {
            return (this.method_76(0, this.m_pItemColl.Count - 1) + Class816.string_27);
        }

        internal string method_76(int A_0, int A_1)
        {
            string str = string.Empty;
            for (int i = A_0; i <= A_1; i++)
            {
                ParagraphBase base2 = this.m_pItemColl[i];
                if (base2 is MergeField)
                {
                    str = str + (base2 as TextRange).Text;
                }
                else if (base2 is Field)
                {
                    str = str + (base2 as Field).method_182();
                    if (base.Document.bodyRegion_0 != null)
                    {
                        return str;
                    }
                    if ((base2 as Field).End.OwnerParagraph == this)
                    {
                        i = (base2 as Field).End.method_5();
                    }
                }
                else if (base2 is TextRange)
                {
                    str = str + (base2 as TextRange).Text;
                }
                else if (base2 is Break)
                {
                    str = str + Class816.string_27;
                }
            }
            return str;
        }

        private void method_77()
        {
            if (this.m_style != null)
            {
                this.characterFormat_0.ApplyBase(this.m_style.CharacterFormat);
                this.m_prFormat.ApplyBase(this.m_style.ParagraphFormat);
                this.m_prFormat.Frame.ApplyBase(this.m_style.ParagraphFormat.Frame);
                ParagraphBase base2 = null;
                int num = 0;
                int count = this.m_pItemColl.Count;
                while (num < count)
                {
                    base2 = this.m_pItemColl[num];
                    base2.CharacterFormat.ApplyBase(this.m_style.CharacterFormat);
                    if (base2 is MergeField)
                    {
                        (base2 as MergeField).method_235();
                    }
                    else if (base2 is StructureDocumentTagInline)
                    {
                        (base2 as StructureDocumentTagInline).method_31();
                    }
                    num++;
                }
            }
        }

        internal void method_78(string A_0)
        {
            int num = 2;
            foreach (Section section in base.Document.Sections)
            {
                if (section.Body.FormFields.ContainsName(A_0))
                {
                    throw new ArgumentException(BookmarkStart.b("渧䔩師䌭ု吱崳匵吷帹᰻䤽⤿㙁ⱃ晅♇⭉⅋⭍灏灑", num) + A_0 + BookmarkStart.b("ਧ਩䴫䈭䈯圱唳刵䄷ᨹ夻䘽⤿ㅁぃ桅", num));
                }
            }
            if (base.Document.Bookmarks[A_0] != null)
            {
                throw new ArgumentException(BookmarkStart.b("欧䬩䈫भ䐯ሱ圳䐵崷嬹䠻嬽怿⑁⭃㑅╇ⱉ╋⭍㱏㙑瑓⅕ㅗ⹙㑛繝䉟", num) + A_0 + BookmarkStart.b("ਧ਩䈫伭崯圱ำᘵ娷唹医唽ⴿ⍁㙃ⵅ桇㵉╋㩍㡏牑❓⍕㭗㉙籛そşཡţ䙥१٩ṫ୭ᅯᙱ൳噵ᵷɹᕻൽꪃ", num));
            }
        }

        private void method_79(BuiltinStyle A_0)
        {
            int num = 6;
            string name = Style.smethod_4(A_0);
            ListStyle style = base.Document.ListStyles.FindByName(name);
            if (style == null)
            {
                style = (ListStyle) Style.CreateBuiltinStyle(A_0, StyleType.ListStyle, base.Document);
                base.Document.ListStyles.Add(style);
            }
            ParagraphStyle style2 = base.Document.Styles.FindByName(style.Name) as ParagraphStyle;
            if (style2 == null)
            {
                style2 = new ParagraphStyle(base.Document) {
                    Name = name
                };
                style2.ApplyBaseStyle(BookmarkStart.b("戫䄭䈯弱唳娵", num));
                base.Document.Styles.Add(style2);
            }
            this.method_65(style2);
            this.ListFormat.ApplyStyle(style.Name);
        }

        private void method_80()
        {
            if (!(base.Document.Styles.FindByName(BookmarkStart.b("瘷唹主匽ℿ⹁", 0x12), StyleType.ParagraphStyle) is ParagraphStyle))
            {
                ParagraphStyle style = (ParagraphStyle) Style.CreateBuiltinStyle(BuiltinStyle.Normal, base.Document);
                base.Document.Styles.Add(style);
            }
        }

        internal void method_81()
        {
            int num = 5;
            if ((this.m_style == null) || ((this.m_style as ParagraphStyle).StyleDocId != 0xb3))
            {
                ParagraphStyle style = base.Document.Styles.FindById(0xb3) as ParagraphStyle;
                if (style == null)
                {
                    style = new ParagraphStyle(base.Document) {
                        StyleDocId = 0xb3,
                        Name = BookmarkStart.b("未䐬尮䔰ጲ攴嘶䬸娺娼䴾⁀㍂ⵄ", num),
                        NextStyle = BookmarkStart.b("未䐬尮䔰ጲ攴嘶䬸娺娼䴾⁀㍂ⵄ", num)
                    };
                    base.Document.Styles.Add(style);
                }
                this.m_style = style;
            }
        }

        private void method_82()
        {
            this.paragraphItemCollection_0 = new ParagraphItemCollection(this);
            TextRange range = (TextRange) base.Document.CreateParagraphItem(ParagraphItemType.TextRange);
            range.Text = BookmarkStart.b("ᔴ", 15);
            range.CharacterFormat.ApplyBase(this.characterFormat_0);
            this.paragraphItemCollection_0.method_25(range);
            range.OwnerEmptyParagraph = this;
        }

        internal FieldType method_83()
        {
            IDocumentObject lastItem = this.Items.LastItem;
            while (lastItem != null)
            {
                if (lastItem is Field)
                {
                    break;
                }
                lastItem = lastItem.PreviousSibling;
            }
            if ((lastItem != null) && (lastItem is Field))
            {
                return (lastItem as Field).Type;
            }
            return FieldType.FieldUnknown;
        }

        internal Field method_84()
        {
            IDocumentObject lastItem = this.Items.LastItem;
            while (lastItem != null)
            {
                if (lastItem is Field)
                {
                    break;
                }
                lastItem = lastItem.PreviousSibling;
            }
            if ((lastItem != null) && (lastItem is Field))
            {
                return (lastItem as Field);
            }
            return null;
        }

        private bool method_85()
        {
            if (((this != null) && (base.NextSibling == null)) && ((base.OwnerTextBody != null) && !(base.OwnerTextBody is HeaderFooter)))
            {
                Section owner = base.OwnerTextBody.Owner as Section;
                if ((owner != null) && (owner.NextSibling != null))
                {
                    string str = this.method_86(this.Text);
                    if (owner != null)
                    {
                        char ch = '\r';
                        if (!str.Contains(ch.ToString()))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private string method_86(string A_0)
        {
            char newChar = '\r';
            A_0 = A_0.Replace(Environment.NewLine, newChar.ToString());
            A_0 = A_0.Replace('\n', newChar);
            A_0 = A_0.Replace('\a'.ToString(), string.Empty);
            A_0 = A_0.Replace('\b'.ToString(), string.Empty);
            return A_0;
        }

        private void method_87()
        {
            this.method_88(new char[] { ' ' });
        }

        internal void method_88(char[] A_0)
        {
            this.UpdateWordCount(A_0, true);
        }

        private void method_89(string A_0, char[] A_1)
        {
            string str = A_0.Replace(Class818.string_0, string.Empty);
            if (!string.IsNullOrEmpty(str))
            {
                char[] sourceArray = base.Document.char_0;
                int num = 0;
                bool flag = false;
                if (A_1 != null)
                {
                    num += A_1.Length;
                }
                if (sourceArray != null)
                {
                    num += sourceArray.Length;
                }
                if (num == 0)
                {
                    flag = true;
                    num = 1;
                }
                char[] destinationArray = new char[num];
                if (A_1 != null)
                {
                    Array.Copy(A_1, destinationArray, A_1.Length);
                }
                if (sourceArray != null)
                {
                    Array.Copy(sourceArray, 0, destinationArray, A_1.Length, sourceArray.Length);
                }
                if (flag)
                {
                    destinationArray[destinationArray.Length - 1] = ' ';
                }
                foreach (string str2 in str.Split(destinationArray, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (!string.IsNullOrEmpty(str2))
                    {
                        this.int_6++;
                        this.int_7 += str2.Length;
                    }
                }
                this.int_8 = str.Length;
            }
        }

        private void method_90(char[] A_0)
        {
            Spire.Doc.Formatting.ListFormat listFormatForApplyStyle = this.GetListFormatForApplyStyle();
            if ((listFormatForApplyStyle != null) && (listFormatForApplyStyle.CurrentListStyle != null))
            {
                ParagraphStyle paraStyle = this.ParaStyle;
                ListStyle currentListStyle = listFormatForApplyStyle.CurrentListStyle;
                int levelNumber = 0;
                if (this.ListFormat.HasKey(0))
                {
                    levelNumber = this.ListFormat.ListLevelNumber;
                }
                else if (paraStyle.ListFormat.HasKey(0))
                {
                    levelNumber = paraStyle.ListFormat.ListLevelNumber;
                }
                ListLevel overrideListLevel = (currentListStyle.Levels.Count > 0) ? currentListStyle.GetNearLevel(levelNumber) : null;
                if (overrideListLevel != null)
                {
                    Class12 class2 = null;
                    if ((listFormatForApplyStyle.LFOStyleName != null) && (listFormatForApplyStyle.LFOStyleName.Length > 0))
                    {
                        class2 = base.Document.ListOverrides.method_35(listFormatForApplyStyle.LFOStyleName);
                    }
                    if (((class2 != null) && class2.method_23().method_11(levelNumber)) && class2.method_23().method_5(levelNumber).OverrideFormatting)
                    {
                        overrideListLevel = class2.method_23().method_5(levelNumber).OverrideListLevel;
                    }
                    string str = base.Document.method_132(this, listFormatForApplyStyle, overrideListLevel);
                    if (((str.Length != 1) || (listFormatForApplyStyle.CurrentListStyle.ListType != ListType.Bulleted)) || ((0xe000 > str[0]) || (0xf8ff < str[0])))
                    {
                        this.method_89(str, A_0);
                    }
                }
            }
        }

        private int method_91(char[] A_0)
        {
            int num = 0;
            int num2 = 0;
            int count = this.Items.Count;
            while (num2 < count)
            {
                ParagraphBase base2 = this.Items[num2];
                if ((base2 is Footnote) && (base2 != this.Items.LastItem))
                {
                    string str = this.Text.Substring(base2.StartPos, 1);
                    List<char> list = new List<char>();
                    list.AddRange(A_0);
                    list.AddRange(base.Document.char_0);
                    if (!list.Contains(str[0]))
                    {
                        num++;
                    }
                }
                num2++;
            }
            return num;
        }

        internal bool method_92()
        {
            bool flag;
            using (IEnumerator enumerator = this.m_pItemColl.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    if (!current.IsDeleteRevision && !current.IsInsertRevision)
                    {
                        goto Label_0035;
                    }
                }
                return true;
            Label_0035:
                flag = false;
            }
            return flag;
        }

        internal ParagraphFormat method_93()
        {
            ParagraphFormat format = new ParagraphFormat(base.Document);
            format.ImportContainer(this.Format);
            ParagraphFormat format2 = this.method_94(this.ListFormat, format);
            ParagraphStyle paraStyle = this.ParaStyle;
            if (paraStyle != null)
            {
                this.method_95(paraStyle, (format2 == null) ? format : format2);
            }
            return format;
        }

        private ParagraphFormat method_94(Spire.Doc.Formatting.ListFormat A_0, ParagraphFormat A_1)
        {
            if ((A_0 != null) && ((A_0.CurrentListLevel != null) && A_0.HasKey(1)))
            {
                ParagraphFormat baseFormat = new ParagraphFormat(base.Document);
                baseFormat.ImportContainer(A_0.CurrentListLevel.ParagraphFormat);
                A_1.ApplyBase(baseFormat);
                return baseFormat;
            }
            return null;
        }

        private ParagraphFormat method_95(ParagraphStyle A_0, ParagraphFormat A_1)
        {
            if (A_0 == null)
            {
                return null;
            }
            ParagraphFormat baseFormat = new ParagraphFormat(base.Document);
            baseFormat.ImportContainer(A_0.ParagraphFormat);
            A_1.ApplyBase(baseFormat);
            ParagraphFormat format2 = this.method_94(A_0.ListFormat, baseFormat);
            if (A_0.BaseStyle != null)
            {
                this.method_95(A_0.BaseStyle, (format2 == null) ? baseFormat : format2);
            }
            return baseFormat;
        }

        private bool method_96()
        {
            return (((this.IsInCell && (this.Items.Count == 0)) && ((base.Owner as TableCell).LastParagraph.Equals(this) && (base.PreviousSibling != null))) && (base.PreviousSibling is Table));
        }

        internal bool method_97()
        {
            bool flag = true;
            using (IEnumerator enumerator = this.ChildObjects.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    if (current is TextRange)
                    {
                        if (current is TextFormField)
                        {
                            if (!(current as TextFormField).CharacterFormat.Hidden)
                            {
                                return false;
                            }
                            continue;
                        }
                        if (((current as TextRange).Text.Trim().Length > 0) && !(current as TextRange).CharacterFormat.Hidden)
                        {
                            return false;
                        }
                    }
                    else if (current is Break)
                    {
                        goto Label_0087;
                    }
                }
                return flag;
            Label_0087:
                flag = false;
            }
            return flag;
        }

        internal bool method_98()
        {
            bool flag;
            using (IEnumerator enumerator = this.ChildObjects.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if (!(current is BookmarkEnd))
                    {
                        goto Label_002D;
                    }
                }
                return true;
            Label_002D:
                flag = false;
            }
            return flag;
        }

        internal bool method_99()
        {
            if (this.m_pItemColl.Count <= 0)
            {
                return false;
            }
            if (!string.IsNullOrEmpty(this.Text.Trim()))
            {
                return false;
            }
            return true;
        }

        public void RemoveAbsPosition()
        {
            if (this.m_prFormat != null)
            {
                this.m_prFormat.RemovePositioning();
            }
        }

        internal override void RemoveCFormatChanges()
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.RemoveChanges();
            }
        }

        public void RemoveFrame()
        {
            if (this.Format.IsFrame)
            {
                this.Format.method_61();
            }
        }

        internal override void RemovePFormatChanges()
        {
            if (this.m_prFormat != null)
            {
                this.m_prFormat.RemoveChanges();
            }
        }

        public override int Replace(Regex pattern, TextSelection textSelection)
        {
            return this.Replace(pattern, textSelection, false);
        }

        public override int Replace(Regex pattern, string replace)
        {
            int num = 0x11;
            if (Class191.smethod_0(pattern))
            {
                throw new ArgumentException(BookmarkStart.b("搶尸娺似尾⥀捂㙄㍆㭈≊⍌⡎煐げ㑔㥖㝘㑚⥜罞͠٢䕤ɦѨ᭪ᥬ᙮", num));
            }
            return Class193.smethod_0().method_0(this, pattern, replace);
        }

        public override int Replace(Regex pattern, TextSelection textSelection, bool saveFormatting)
        {
            int num = 12;
            if (Class191.smethod_0(pattern))
            {
                throw new ArgumentException(BookmarkStart.b("愱儳圵䨷夹吻ḽ㌿㙁㙃⽅♇ⵉ汋ⵍㅏ㱑㩓㥕ⱗ穙㹛㭝䁟ݡॣᙥᱧ፩", num));
            }
            textSelection.method_1();
            Class185 class2 = this.FindAll(pattern);
            if (class2 == null)
            {
                return 0;
            }
            foreach (TextSelection selection in class2)
            {
                CharacterFormat characterFormat = null;
                if ((selection.StartTextRange != null) && saveFormatting)
                {
                    characterFormat = selection.StartTextRange.CharacterFormat;
                }
                int num2 = selection.method_0();
                Paragraph ownerParagraph = selection.OwnerParagraph;
                if (selection.OwnerSDTInlineContent != null)
                {
                    textSelection.method_3(selection.OwnerSDTInlineContent, num2, saveFormatting, characterFormat);
                }
                else
                {
                    textSelection.method_2(ownerParagraph, num2, saveFormatting, characterFormat);
                }
            }
            return class2.Count;
        }

        public int Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Replace(pattern, textSelection, false);
        }

        public override int Replace(string given, string replace, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Replace(pattern, replace);
        }

        public int Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord, bool saveFormatting)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.Replace(pattern, textSelection, saveFormatting);
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.interface45_0 = null;
            }
        }

        protected override void RestoreReference(string name, int index)
        {
            if ((name == BookmarkStart.b("帬嬮䠰弲倴", 7)) && (index > -1))
            {
                this.m_style = base.Document.Styles[index] as ParagraphStyle;
                this.method_77();
            }
        }

        internal override void SetChangedCFormat(bool check)
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.IsChangedFormat = check;
            }
        }

        internal override void SetChangedPFormat(bool check)
        {
            if (this.m_prFormat != null)
            {
                this.m_prFormat.IsChangedFormat = check;
            }
        }

        internal override void SetDeleteRev(bool check)
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.IsDeleteRevision = check;
            }
        }

        internal override void SetInsertRev(bool check)
        {
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.IsInsertRevision = check;
            }
        }

        void Interface46.ClearParaAttrs()
        {
            this.Format.ClearAttrs();
        }

        object Interface46.FetchInheritedParaAttr(int key)
        {
            return this.Format.method_33(key);
        }

        object Interface46.FetchParaAttr(int key)
        {
            return this.Format.method_32(key);
        }

        object Interface46.GetDirectParaAttr(int key)
        {
            return this.Format.method_31(key);
        }

        void Interface46.GetDirectParaAttrByIndex(int index, out int key, out object value)
        {
            key = this.Format.method_18(index);
            value = this.Format.method_19(index);
        }

        void Interface46.RemoveParaAttr(int key)
        {
            this.Format.Remove(key);
        }

        void Interface46.SetParaAttr(int key, object value)
        {
            this.Format.SetAttr(key, value);
        }

        void IRunAttrSource.ClearRunAttrs()
        {
            this.BreakCharacterFormat.ClearAttrs();
        }

        object IRunAttrSource.FetchInheritedRunAttr(int key)
        {
            return this.BreakCharacterFormat.method_33(key);
        }

        object IRunAttrSource.GetDirectRunAttr(int key)
        {
            return this.BreakCharacterFormat.method_31(key);
        }

        void IRunAttrSource.GetDirectRunAttrByIndex(int index, out int key, out object value)
        {
            key = this.BreakCharacterFormat.method_18(index);
            value = this.BreakCharacterFormat.method_19(index);
        }

        void IRunAttrSource.SetRunAttr(int key, object value)
        {
            this.BreakCharacterFormat.SetAttr(key, value);
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            int num = 2;
            base.DrawImpl(dc, ltWidget);
            bool flag = (ltWidget.method_74().Count > 0) && (ltWidget.method_74().method_4(0).method_73() == this);
            if ((ltWidget.method_73() is Class65) && ((ltWidget.method_73() as Class65).method_2() is Paragraph))
            {
                Paragraph paragraph = (ltWidget.method_73() as Class65).method_2() as Paragraph;
                int count = paragraph.ChildObjects.Count;
                if ((count > (ltWidget.method_73() as Class65).Interface3.imethod_3()) && (paragraph.ChildObjects[(count - 1) - (ltWidget.method_73() as Class65).Interface3.imethod_3()].DocumentObjectType.ToString() == BookmarkStart.b("樧堩䤫伭嬯", num)))
                {
                    DocumentObject obj2 = paragraph.ChildObjects[(count - 1) - (ltWidget.method_73() as Class65).Interface3.imethod_3()];
                    Break @break = obj2 as Break;
                    if (((@break.BreakType == BreakType.PageBreak) || (@break.BreakType == BreakType.ColumnBreak)) && !this.bool_4)
                    {
                        flag = true;
                        this.bool_4 = true;
                    }
                }
                if (!flag)
                {
                    for (int i = 0; i < ltWidget.method_74().Count; i++)
                    {
                        Class375 class2 = ltWidget.method_74().method_4(i);
                        dc.method_167(class2);
                    }
                }
            }
            if (flag)
            {
                dc.method_158(this, ltWidget);
            }
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        public string UpdateListValue()
        {
            if (this.ListFormat.IsEmptyList || this.SectionEndMark)
            {
                return string.Empty;
            }
            string str = string.Empty;
            Spire.Doc.Formatting.ListFormat listFormatForApplyStyle = this.GetListFormatForApplyStyle();
            int levelNumber = 0;
            if ((listFormatForApplyStyle == null) || (listFormatForApplyStyle.CurrentListStyle == null))
            {
                return str;
            }
            ListStyle currentListStyle = listFormatForApplyStyle.CurrentListStyle;
            if (listFormatForApplyStyle.HasKey(0))
            {
                levelNumber = listFormatForApplyStyle.ListLevelNumber;
            }
            ListLevel overrideListLevel = (currentListStyle.Levels.Count > 0) ? currentListStyle.GetNearLevel(levelNumber) : null;
            if (overrideListLevel == null)
            {
                return str;
            }
            Class12 class2 = null;
            if ((listFormatForApplyStyle.LFOStyleName != null) && (listFormatForApplyStyle.LFOStyleName.Length > 0))
            {
                class2 = base.Document.ListOverrides.method_35(listFormatForApplyStyle.LFOStyleName);
            }
            if (((class2 != null) && class2.method_23().method_11(levelNumber)) && class2.method_23().method_5(levelNumber).OverrideFormatting)
            {
                overrideListLevel = class2.method_23().method_5(levelNumber).OverrideListLevel;
            }
            return base.Document.method_132(this, listFormatForApplyStyle, overrideListLevel);
        }

        public void UpdateWordCount(char[] splitchar, bool includeTB)
        {
            this.int_8 = 0;
            this.int_7 = 0;
            this.int_6 = 0;
            this.method_89(this.Text, splitchar);
            int num = this.method_91(splitchar);
            this.int_6 += num;
            this.int_7 += num;
            this.int_8 += num;
            this.method_90(splitchar);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("䀳伵䠷弹", 14), BookmarkStart.b("搳圵䨷嬹嬻䰽ℿ㉁ⱃ", 14));
        }

        public CharacterFormat BreakCharacterFormat
        {
            get
            {
                return this.characterFormat_0;
            }
            internal set
            {
                this.characterFormat_0 = value;
                this.characterFormat_0.method_0(this);
            }
        }

        public int CharCount
        {
            get
            {
                if (this.int_7 == -2147483648)
                {
                    this.method_87();
                }
                if (this.int_7 == -2147483648)
                {
                    return 0;
                }
                return this.int_7;
            }
        }

        public int CharCountIncludeSpace
        {
            get
            {
                if (this.int_8 == -2147483648)
                {
                    this.method_87();
                }
                if (this.int_8 == -2147483648)
                {
                    return 0;
                }
                return this.int_8;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.m_pItemColl;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Paragraph;
            }
        }

        internal TextRange FirstTextRange
        {
            get
            {
                if (this.textRange_0 == null)
                {
                    this.textRange_0 = this.method_53();
                }
                return this.textRange_0;
            }
        }

        public ParagraphFormat Format
        {
            get
            {
                return this.m_prFormat;
            }
            internal set
            {
                this.m_prFormat = value;
                this.m_prFormat.method_0(this);
            }
        }

        internal bool HasInlinePictureOnly
        {
            get
            {
                bool flag;
                using (IEnumerator enumerator = this.m_pItemColl.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ParagraphBase current = (ParagraphBase) enumerator.Current;
                        if ((current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.Picture) || ((current as DocPicture).TextWrappingStyle != TextWrappingStyle.Inline))
                        {
                            goto Label_003C;
                        }
                    }
                    return true;
                Label_003C:
                    flag = false;
                }
                return flag;
            }
        }

        internal bool HasOnlyBreakOrBookmark
        {
            get
            {
                bool flag;
                if (this.ChildObjects.Count <= 0)
                {
                    return false;
                }
                using (IEnumerator enumerator = this.ChildObjects.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ParagraphBase current = (ParagraphBase) enumerator.Current;
                        if (((current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.BookmarkStart) && (current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.BookmarkEnd)) && (current.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.Break))
                        {
                            goto Label_0055;
                        }
                    }
                    return true;
                Label_0055:
                    flag = false;
                }
                return flag;
            }
        }

        internal bool HasRelayout
        {
            [CompilerGenerated]
            get
            {
                return this.bool_9;
            }
            [CompilerGenerated]
            set
            {
                this.bool_9 = value;
            }
        }

        internal bool HasSDTInlineItem
        {
            get
            {
                return this.bool_6;
            }
        }

        internal bool HasTextBox
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                this.bool_7 = value;
            }
        }

        internal bool HasTextRangeBorder
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

        int Interface3.Count
        {
            get
            {
                return this.WidgetCollection.Count;
            }
        }

        Interface1 Interface3.this[int index]
        {
            get
            {
                return (this.WidgetCollection[index] as Interface1);
            }
        }

        int Interface46.DirectParaAttrsCount
        {
            get
            {
                return this.Format.Count;
            }
        }

        internal bool IsAddForIfField
        {
            get
            {
                return this.bool_8;
            }
            set
            {
                this.bool_8 = value;
            }
        }

        internal bool IsEmptyParagraph
        {
            get
            {
                foreach (ParagraphBase base2 in this.ChildObjects)
                {
                    if (((base2.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.BookmarkStart) && (base2.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.BookmarkEnd)) && (base2.DocumentObjectType != Spire.Doc.Documents.DocumentObjectType.Break))
                    {
                        return false;
                    }
                    if ((base2.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Break) && ((base2 as Break).BreakType == BreakType.LineBreak))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public bool IsEndOfDocument
        {
            get
            {
                if (!this.IsEndOfSection)
                {
                    return false;
                }
                if (base.Owner.Owner is Section)
                {
                    return ((base.Owner.Owner as Section).NextSibling == null);
                }
                return ((base.Owner.Owner.Owner.Owner as Section).NextSibling == null);
            }
        }

        public bool IsEndOfSection
        {
            get
            {
                if (((base.Owner == null) || (base.NextSibling != null)) || (((base.Owner is HeaderFooter) || !(base.Owner.Owner is Section)) && (((!(base.Owner.Owner is StructureDocumentTag) || (base.Owner.Owner.NextSibling != null)) || (!(base.Owner.Owner.Owner is Body) || (base.Owner.Owner.Owner is HeaderFooter))) || !(base.Owner.Owner.Owner.Owner is Section))))
                {
                    return false;
                }
                return true;
            }
        }

        public bool IsInCell
        {
            get
            {
                return (base.Owner is TableCell);
            }
        }

        internal bool IsInSameFrameWithNextSibling
        {
            get
            {
                if (this.Format.IsFrame)
                {
                    if (base.NextSibling is Paragraph)
                    {
                        Paragraph nextSibling = base.NextSibling as Paragraph;
                        if (((nextSibling.Format.IsFrame && (nextSibling.Format.FrameWidth == this.Format.FrameWidth)) && ((nextSibling.Format.FrameX == this.Format.FrameX) && (nextSibling.Format.FrameHorizontalDistanceFromText == this.Format.FrameHorizontalDistanceFromText))) && (((nextSibling.Format.FrameHeight == this.Format.FrameHeight) && (nextSibling.Format.FrameY == this.Format.FrameY)) && (nextSibling.Format.FrameVerticalDistanceFromText == this.Format.FrameVerticalDistanceFromText)))
                        {
                            return true;
                        }
                    }
                    else if (base.NextSibling is Table)
                    {
                        Table table = base.NextSibling as Table;
                        if (((table.IsFrame && (table.FrameFormat.FrameWidth == this.Format.FrameWidth)) && ((table.FrameFormat.FrameX == this.Format.FrameX) && (table.FrameFormat.FrameHorizontalDistanceFromText == this.Format.FrameHorizontalDistanceFromText))) && (((table.FrameFormat.FrameHeight == this.Format.FrameHeight) && (table.FrameFormat.FrameY == this.Format.FrameY)) && (table.FrameFormat.FrameVerticalDistanceFromText == this.Format.FrameVerticalDistanceFromText)))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        internal bool IsList
        {
            get
            {
                Spire.Doc.Formatting.ListFormat listFormatForApplyStyle = this.GetListFormatForApplyStyle();
                return ((listFormatForApplyStyle.ListType != ListType.NoList) && (listFormatForApplyStyle.CurrentListStyle != null));
            }
        }

        internal bool IsStartOfSection
        {
            get
            {
                return (((base.Owner.Owner is Section) || (((base.Owner.Owner is StructureDocumentTag) && (base.Owner.Owner.PreviousSibling == null)) && ((base.Owner.Owner.Owner is Body) && (base.Owner.Owner.Owner.Owner is Section)))) && (base.PreviousSibling == null));
            }
        }

        internal bool IsStyleApplied
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        internal bool IsTOCPara
        {
            [CompilerGenerated]
            get
            {
                return this.bool_11;
            }
            [CompilerGenerated]
            set
            {
                this.bool_11 = value;
            }
        }

        public ParagraphBase this[int index]
        {
            get
            {
                return this.m_pItemColl[index];
            }
        }

        public ParagraphItemCollection Items
        {
            get
            {
                return this.m_pItemColl;
            }
        }

        internal ParagraphBase LastItem
        {
            get
            {
                return (this.m_pItemColl.LastItem as ParagraphBase);
            }
        }

        public Spire.Doc.Formatting.ListFormat ListFormat
        {
            get
            {
                if (this.m_listFormat == null)
                {
                    this.m_listFormat = new Spire.Doc.Formatting.ListFormat(this);
                }
                return this.m_listFormat;
            }
        }

        public string ListText
        {
            get
            {
                if (string.IsNullOrEmpty(this.string_9))
                {
                    this.string_9 = this.UpdateListValue();
                }
                return this.string_9;
            }
            internal set
            {
                this.string_9 = value;
            }
        }

        internal ParagraphStyle ParaStyle
        {
            get
            {
                return (this.m_style as ParagraphStyle);
            }
        }

        internal bool RemoveEmpty
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        internal bool SectionEndMark
        {
            get
            {
                return this.method_85();
            }
        }

        int IRunAttrSource.DirectRunAttrsCount
        {
            get
            {
                return this.BreakCharacterFormat.Count;
            }
        }

        public string StyleName
        {
            get
            {
                if (this.m_style == null)
                {
                    return null;
                }
                return this.m_style.StyleId;
            }
        }

        public string Text
        {
            get
            {
                return this.stringBuilder_0.ToString();
            }
            set
            {
                this.Items.Clear();
                this.AppendText(value).CharacterFormat.ImportContainer(this.BreakCharacterFormat);
            }
        }

        internal float TextRangeBorderWidth
        {
            get
            {
                return this.float_6;
            }
            set
            {
                this.float_6 = Math.Max(this.float_6, value);
            }
        }

        internal IDocumentObjectCollection WidgetCollection
        {
            get
            {
                if (this.m_pItemColl.Count == 0)
                {
                    return this.paragraphItemCollection_0;
                }
                if (!(this.m_pItemColl[this.m_pItemColl.Count - 1] is Break))
                {
                    return this.method_51();
                }
                bool flag3 = (this.m_pItemColl[this.m_pItemColl.Count - 1] as Break).BreakType == BreakType.PageBreak;
                bool flag2 = !this.IsEndOfDocument && flag3;
                bool flag = flag3 && base.Document.Settings.method_5().method_0(CompatibilityOptions.SplitPgBreakAndParaMark);
                if ((flag2 && !this.bool_6) && !flag)
                {
                    return this.m_pItemColl;
                }
                ParagraphItemCollection items = this.method_51();
                if (!flag2 || flag)
                {
                    items.InnerList.Add(this.method_52(this.m_pItemColl[this.m_pItemColl.Count - 1] as Break));
                }
                return items;
            }
        }

        public int WordCount
        {
            get
            {
                if (this.int_6 == -2147483648)
                {
                    this.method_87();
                }
                if (this.int_6 == -2147483648)
                {
                    return 0;
                }
                return this.int_6;
            }
        }
    }
}

