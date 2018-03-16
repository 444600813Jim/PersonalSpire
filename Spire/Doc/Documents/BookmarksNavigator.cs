namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;

    public class BookmarksNavigator
    {
        private Bookmark bookmark_0;
        private bool bool_0;
        private bool bool_1;
        private byte[] byte_0;
        private Spire.Doc.Document document_0;
        private int int_0;
        private int int_1;
        private IParagraph iparagraph_0;
        private long[] long_0;
        private long[] long_1;
        private const string string_0 = "You can not use DocumentNavigator without initializing Document property";
        private const string string_1 = "Specified bookmark not found";
        private const string string_2 = " Document property must be equal this Document property";
        private const string string_3 = "Current Bookmark didn't select";
        private const string string_4 = "Not supported getting content between bookmarks in different paragraphs";
        private const string string_5 = "Not supported deleting content between bookmarks in different paragraphs";

        public BookmarksNavigator(IDocument doc)
        {
            this.document_0 = (Spire.Doc.Document) doc;
        }

        public void DeleteBookmarkContent(bool saveFormatting)
        {
            this.method_0(saveFormatting, false);
        }

        public TextBodyPart GetBookmarkContent()
        {
            TextBodySelection selection;
            this.method_2();
            BookmarkStart bookmarkStart = this.bookmark_0.BookmarkStart;
            BookmarkEnd bookmarkEnd = this.bookmark_0.BookmarkEnd;
            return new TextBodyPart(new TextBodySelection(bookmarkStart, bookmarkEnd) { ParagraphItemStartIndex = selection.ParagraphItemStartIndex + 1, ParagraphItemEndIndex = selection.ParagraphItemEndIndex - 1 });
        }

        public void InsertParagraph(IParagraph paragraph)
        {
            this.method_4(paragraph as BodyRegion);
        }

        public IParagraphBase InsertParagraphItem(ParagraphItemType itemType)
        {
            IParagraphBase entity = this.document_0.CreateParagraphItem(itemType);
            this.iparagraph_0.Items.Insert(this.int_1, entity);
            return entity;
        }

        public void InsertTable(ITable table)
        {
            this.method_4(table as BodyRegion);
        }

        public ITextRange InsertText(string text)
        {
            return this.InsertText(text, true);
        }

        public ITextRange InsertText(string text, bool saveFormatting)
        {
            this.method_2();
            ITextRange nextSibling = this.bookmark_0.BookmarkStart.NextSibling as ITextRange;
            if (saveFormatting)
            {
                if (nextSibling != null)
                {
                    nextSibling.Text = nextSibling.Text + text;
                    return nextSibling;
                }
                CharacterFormat characterFormat = null;
                ITextRange previousSibling = this.bookmark_0.BookmarkStart.PreviousSibling as ITextRange;
                ITextRange range2 = this.bookmark_0.BookmarkEnd.NextSibling as ITextRange;
                nextSibling = this.InsertParagraphItem(ParagraphItemType.TextRange) as ITextRange;
                if (previousSibling != null)
                {
                    characterFormat = previousSibling.CharacterFormat;
                    nextSibling.CharacterFormat.ImportContainer(characterFormat);
                }
                else if (range2 != null)
                {
                    characterFormat = range2.CharacterFormat;
                    nextSibling.CharacterFormat.ImportContainer(characterFormat);
                }
                else
                {
                    this.method_3(nextSibling);
                }
                nextSibling.Text = text;
                return nextSibling;
            }
            nextSibling = this.InsertParagraphItem(ParagraphItemType.TextRange) as ITextRange;
            nextSibling.Text = text;
            return nextSibling;
        }

        public void InsertTextBodyPart(TextBodyPart bodyPart)
        {
            if (this.CurrentBookmark.BookmarkStart != null)
            {
                bodyPart.PasteAfter(this.bookmark_0.BookmarkStart);
            }
        }

        internal void method_0(bool A_0, bool A_1)
        {
            int num = 1;
            if (this.CurrentBookmark == null)
            {
                throw new InvalidOperationException();
            }
            BookmarkStart bookmarkStart = this.CurrentBookmark.BookmarkStart;
            BookmarkEnd bookmarkEnd = this.CurrentBookmark.BookmarkEnd;
            if (bookmarkEnd != null)
            {
                Paragraph ownerParagraph = bookmarkStart.OwnerParagraph;
                Paragraph paragraph = bookmarkEnd.OwnerParagraph;
                if (ownerParagraph.Owner != paragraph.Owner)
                {
                    throw new NotSupportedException(BookmarkStart.b("椦䘨弪ബ尮䐰䌲䔴堶䬸伺堼嬾慀❂⁄⭆ⱈ㽊⑌ⅎ㙐獒㙔㡖㝘⽚㡜ㅞᕠ䍢ݤɦᵨᱪ࡬੮ὰ卲᝴ᡶᙸၺၼṾꞆ권ﺚ膠펢쒤햦좨첪\udfac\uceae솰\udbb2\uc6b4", num));
                }
                Body owner = (Body) ownerParagraph.Owner;
                BodyRegionCollection regions = owner.Items;
                int index = ownerParagraph.method_5() + 1;
                if (ownerParagraph != paragraph)
                {
                    while (regions.Count > index)
                    {
                        if (regions[index] == paragraph)
                        {
                            break;
                        }
                        regions.RemoveAt(index);
                    }
                }
                ParagraphItemCollection items = ownerParagraph.Items;
                int num4 = bookmarkStart.method_5() + 1;
                if (A_0 && (items.Count > num4))
                {
                    TextRange range = items[num4] as TextRange;
                    if (range != null)
                    {
                        range.Text = "";
                        num4++;
                    }
                }
                while (items.Count > num4)
                {
                    if (items[num4] == bookmarkEnd)
                    {
                        break;
                    }
                    items.RemoveAt(num4);
                    if (this.int_1 > 0)
                    {
                        this.int_1--;
                    }
                }
                if (ownerParagraph != paragraph)
                {
                    int num2 = bookmarkEnd.method_5();
                    if (num2 != 0)
                    {
                        while (num2 < paragraph.Items.Count)
                        {
                            DocumentObject entity = paragraph.Items[num2];
                            ownerParagraph.Items.Add(entity);
                        }
                        paragraph.RemoveSelf();
                    }
                    else if (A_1)
                    {
                        if (num4 == 1)
                        {
                            ownerParagraph.RemoveSelf();
                            paragraph.Items.RemoveAt(num2);
                        }
                        if ((num4 == 2) && (items[0] is BookmarkEnd))
                        {
                            paragraph.Items.RemoveAt(num2);
                            BookmarkEnd end2 = items[0] as BookmarkEnd;
                            ((Paragraph) regions[index]).Items.Insert(0, end2);
                            ownerParagraph.RemoveSelf();
                        }
                    }
                }
            }
            if (this.document_0.Bookmarks.InnerList.Contains(this.CurrentBookmark))
            {
                this.MoveToBookmark(this.CurrentBookmark.Name, this.bool_0, this.bool_1);
            }
        }

        private CharacterFormat method_1(ParagraphBase A_0)
        {
            if (A_0 == null)
            {
                return null;
            }
            CharacterFormat characterFormat = null;
            ITextRange nextSibling = this.bookmark_0.BookmarkStart.NextSibling as ITextRange;
            if (nextSibling != null)
            {
                return nextSibling.CharacterFormat;
            }
            ITextRange previousSibling = this.bookmark_0.BookmarkStart.PreviousSibling as ITextRange;
            ITextRange range2 = this.bookmark_0.BookmarkEnd.NextSibling as ITextRange;
            nextSibling = this.InsertParagraphItem(ParagraphItemType.TextRange) as ITextRange;
            if (previousSibling != null)
            {
                return previousSibling.CharacterFormat;
            }
            if (range2 != null)
            {
                characterFormat = range2.CharacterFormat;
            }
            return characterFormat;
        }

        private void method_2()
        {
            int num = 0x11;
            if (this.document_0 == null)
            {
                throw new InvalidOperationException(BookmarkStart.b("渶嘸为ᴼ尾⁀ⵂ敄⥆♈㽊浌㩎≐㙒畔ፖ㙘㡚⡜㉞Ѡൢᅤ⥦ࡨᵪѬ࡮ၰݲᩴն奸౺ᑼ୾ꦈ朗ﮖ욠莢좦쪨\udeaa\uc0ac쪮\udfb0\uc7b2閴잶쮸풺춼\udabe\ub3c0럂별", num));
            }
            if (((this.bookmark_0 == null) || (this.iparagraph_0 == null)) || (this.int_1 < 0))
            {
                throw new InvalidOperationException(BookmarkStart.b("琶䰸䤺似娾⽀㝂敄Ն♈⑊♌≎ぐ⅒㹔睖㵘㉚㥜ㅞ䙠ᝢ䕤ᑦ౨ݪ࡬౮հ", num));
            }
        }

        private void method_3(ITextRange A_0)
        {
            Paragraph ownerParagraph = this.bookmark_0.BookmarkStart.OwnerParagraph;
            if (ownerParagraph != null)
            {
                if (((ownerParagraph.OwnerTextBody != null) && (ownerParagraph.OwnerTextBody.DocumentObjectType == DocumentObjectType.TableCell)) && (ownerParagraph.OwnerTextBody.Paragraphs.Count == 1))
                {
                    TableCell ownerTextBody = ownerParagraph.OwnerTextBody as TableCell;
                    A_0.CharacterFormat.ImportContainer(ownerTextBody.CharacterFormat);
                }
                A_0.CharacterFormat.ImportContainer(ownerParagraph.BreakCharacterFormat);
            }
        }

        private void method_4(BodyRegion A_0)
        {
            ParagraphBase bookmarkStart = this.CurrentBookmark.BookmarkStart;
            if (bookmarkStart != null)
            {
                bool flag = false;
                int num = bookmarkStart.method_5();
                Paragraph ownerParagraph = bookmarkStart.OwnerParagraph;
                Paragraph paragraph2 = new Paragraph(ownerParagraph.Document);
                if (bookmarkStart.NextSibling == null)
                {
                    flag = true;
                }
                if ((A_0 is Paragraph) && (bookmarkStart.NextSibling == null))
                {
                    paragraph2 = A_0 as Paragraph;
                    flag = false;
                }
                num++;
                TextBodyPart.smethod_0(ownerParagraph, num, paragraph2);
                int index = paragraph2.method_5();
                ownerParagraph.OwnerTextBody.Items.Insert(index, A_0);
                if (((flag && (paragraph2.Text == "")) && ((bookmarkStart.OwnerBase != null) && (bookmarkStart.OwnerBase.OwnerBase != null))) && (bookmarkStart.OwnerBase.OwnerBase is Body))
                {
                    int num3 = (bookmarkStart.OwnerBase.OwnerBase as Body).Paragraphs.IndexOf(paragraph2);
                    (bookmarkStart.OwnerBase.OwnerBase as Body).Paragraphs.RemoveAt(num3);
                }
            }
        }

        public void MoveToBookmark(string bookmarkName)
        {
            this.MoveToBookmark(bookmarkName, false, false);
        }

        public void MoveToBookmark(string bookmarkName, bool isStart, bool isAfter)
        {
            int num = 0;
            this.bool_0 = isStart;
            this.bool_1 = isAfter;
            string name = bookmarkName.Replace('-', '_');
            if (this.document_0 == null)
            {
                throw new InvalidOperationException(BookmarkStart.b("缥䜧弩ఫ䴭儯就ᐳ堵圷丹᰻䬽㌿❁摃Ʌ❇⥉㥋⍍㕏㱑⁓ᡕ㥗ⱙ㕛㥝şᙡୣᑥ䡧ᵩիᩭᡯᵱųɵ塷፹ቻ᝽늑킓秊ﮗﮝ캟횡蒣횥\udaa7\uc5a9\udcab\ucbad슯욱춳", num));
            }
            this.bookmark_0 = this.document_0.Bookmarks.FindByName(name);
            if (this.bookmark_0 == null)
            {
                throw new ArgumentException(BookmarkStart.b("甥堧伩伫䜭嘯嬱儳刵ᠷ堹医儽⬿⽁╃㑅⍇橉≋⅍⑏牑㉓㥕ⵗ㑙㡛", num));
            }
            IParagraphBase entity = (isStart || (this.bookmark_0.BookmarkEnd == null)) ? ((IParagraphBase) this.bookmark_0.BookmarkStart) : ((IParagraphBase) this.bookmark_0.BookmarkEnd);
            this.iparagraph_0 = entity.OwnerParagraph;
            if (isAfter)
            {
                this.int_1 = this.iparagraph_0.Items.IndexOf(entity) + 1;
            }
            else
            {
                this.int_1 = this.iparagraph_0.Items.IndexOf(entity);
            }
        }

        public void ReplaceBookmarkContent(TextBodyPart bodyPart)
        {
            this.ReplaceBookmarkContent(bodyPart, false);
        }

        public void ReplaceBookmarkContent(TextBodyPart bodyPart, bool isKeepSourceFirstParaFormat)
        {
            this.ReplaceBookmarkContent(bodyPart, isKeepSourceFirstParaFormat, false);
        }

        public void ReplaceBookmarkContent(string text, bool saveFormatting)
        {
            this.method_0(saveFormatting, false);
            this.InsertText(text, saveFormatting);
        }

        public void ReplaceBookmarkContent(TextBodyPart bodyPart, bool isKeepSourceFirstParaFormat, bool saveFormatting)
        {
            bodyPart.bool_3 = isKeepSourceFirstParaFormat;
            this.method_0(saveFormatting, false);
            BodyRegion owner = this.bookmark_0.BookmarkStart.Owner as BodyRegion;
            int num = owner.method_5();
            int num2 = this.bookmark_0.BookmarkStart.method_5();
            CharacterFormat format = this.method_1(this.bookmark_0.BookmarkStart);
            bodyPart.method_1(owner.OwnerTextBody, num, num2 + 1, format, saveFormatting);
            bodyPart.bool_3 = false;
        }

        public Bookmark CurrentBookmark
        {
            get
            {
                return this.bookmark_0;
            }
        }

        private IParagraphBase CurrentParagraphItem
        {
            get
            {
                if (((this.iparagraph_0 != null) && (this.int_1 >= 0)) && (this.int_1 <= (this.iparagraph_0.Items.Count - 1)))
                {
                    return this.iparagraph_0[this.int_1];
                }
                return null;
            }
        }

        public IDocument Document
        {
            get
            {
                return this.document_0;
            }
            set
            {
                this.document_0 = (Spire.Doc.Document) value;
            }
        }
    }
}

