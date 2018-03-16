namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;

    public class TextBodyPart
    {
        private Body body_0;
        private Body body_1;
        private bool[] bool_0;
        private bool[] bool_1;
        private bool bool_2;
        internal bool bool_3;
        private byte[] byte_0;
        private byte[] byte_1;
        private CharacterFormat characterFormat_0;
        private int int_0;
        private int int_1;
        private long[] long_0;
        private string string_0;

        public TextBodyPart()
        {
        }

        public TextBodyPart(Document doc)
        {
            this.method_4(doc);
        }

        public TextBodyPart(TextBodySelection textBodySelection)
        {
            this.Copy(textBodySelection);
        }

        public TextBodyPart(TextSelection textSelection)
        {
            this.Copy(textSelection);
        }

        public void Clear()
        {
            this.body_0.Items.Clear();
        }

        public void Copy(TextBodySelection textSel)
        {
            this.method_4(textSel.TextBody.Document);
            int itemStartIndex = textSel.ItemStartIndex;
            int itemEndIndex = textSel.ItemEndIndex;
            for (int i = itemStartIndex; i <= itemEndIndex; i++)
            {
                BodyRegion entity = (BodyRegion) textSel.TextBody.Items[i].Clone();
                if ((i == itemStartIndex) || (i == itemEndIndex))
                {
                    if (entity.DocumentObjectType == DocumentObjectType.StructureDocumentTag)
                    {
                        if (i == itemStartIndex)
                        {
                            StructureDocumentTag tag = entity as StructureDocumentTag;
                            for (int j = textSel.ItemStartIndexInSDT - 1; j >= 0; j--)
                            {
                                tag.ChildObjects.InnerList.RemoveAt(j);
                            }
                            DocumentObject firstItem = tag.ChildObjects.FirstItem;
                            if (firstItem is Paragraph)
                            {
                                Paragraph paragraph3 = firstItem as Paragraph;
                                for (int k = textSel.ParagraphItemStartIndex - 1; k >= 0; k--)
                                {
                                    paragraph3.Items.InnerList.RemoveAt(k);
                                }
                            }
                        }
                        if (i == itemEndIndex)
                        {
                            StructureDocumentTag tag2 = entity as StructureDocumentTag;
                            int index = textSel.ItemEndIndexInSDT + 1;
                            while (index < tag2.ChildObjects.Count)
                            {
                                tag2.ChildObjects.InnerList.RemoveAt(index);
                            }
                            DocumentObject lastItem = tag2.ChildObjects.LastItem;
                            if (lastItem is Paragraph)
                            {
                                Paragraph paragraph = lastItem as Paragraph;
                                int num5 = textSel.ParagraphItemEndIndex + 1;
                                while (num5 < paragraph.Items.Count)
                                {
                                    paragraph.Items.InnerList.RemoveAt(num5);
                                }
                            }
                        }
                    }
                    else if (entity.DocumentObjectType == DocumentObjectType.Paragraph)
                    {
                        Paragraph paragraph2 = entity as Paragraph;
                        if (i == itemEndIndex)
                        {
                            int num4 = textSel.ParagraphItemEndIndex + 1;
                            while (num4 < paragraph2.Items.Count)
                            {
                                paragraph2.Items.InnerList.RemoveAt(num4);
                            }
                        }
                        if (i == itemStartIndex)
                        {
                            for (int m = textSel.ParagraphItemStartIndex - 1; m >= 0; m--)
                            {
                                paragraph2.Items.InnerList.RemoveAt(m);
                            }
                        }
                    }
                }
                this.body_0.Items.Add(entity);
            }
        }

        public void Copy(TextSelection textSel)
        {
            this.method_4(textSel.OwnerParagraph.Document);
            TextRange[] ranges = textSel.GetRanges();
            Paragraph entity = new Paragraph(this.body_0.Document);
            this.body_0.Items.Add(entity);
            int index = 0;
            int length = ranges.Length;
            while (index < length)
            {
                entity.Items.Add(ranges[index].Clone());
                index++;
            }
        }

        public void Copy(BodyRegion bodyItem, bool clone)
        {
            if (clone)
            {
                bodyItem = (BodyRegion) bodyItem.Clone();
            }
            this.method_4(bodyItem.Document);
            this.body_0.Items.Add(bodyItem);
        }

        public void Copy(ParagraphBase pItem, bool clone)
        {
            if (clone)
            {
                pItem = (ParagraphBase) pItem.Clone();
            }
            this.method_4(pItem.Document);
            this.body_0.AddParagraph().Items.Add(pItem);
        }

        internal void method_0(Body A_0, bool A_1)
        {
            this.method_4(A_0.Document);
            if (A_1)
            {
                this.body_0 = (Body) A_0.Clone();
            }
            else
            {
                this.body_0 = A_0;
            }
        }

        internal void method_1(IBody A_0, int A_1, int A_2, CharacterFormat A_3, bool A_4)
        {
            this.characterFormat_0 = A_3;
            this.bool_2 = A_4;
            this.PasteAt(A_0, A_1, A_2);
        }

        private void method_2()
        {
            int num = 9;
            if (this.body_1 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("嬮吰䬲䄴甶嘸强䐼", num));
            }
            if ((this.int_0 < 0) || (this.int_0 > this.body_1.Items.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䘮䔰嘲場縶圸强堼䜾", num), BookmarkStart.b("䘮䔰嘲場縶圸强堼䜾慀⩂㙄杆╈⹊㹌㱎煐❒㵔㙖㝘筚浜罞๠ᅢ䕤f᭨๪౬᭮ᑰŲ啴Ͷᅸ᩺፼彾", num) + this.body_1.Items.Count);
            }
            BodyRegion region = (this.body_1.Items.Count > this.int_0) ? this.body_1.Items[this.int_0] : null;
            Paragraph paragraph = region as Paragraph;
            if ((paragraph != null) && ((this.int_1 < 0) || (this.int_1 > paragraph.Items.Count)))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("弮砰䜲倴娶瀸唺夼娾㥀", num), BookmarkStart.b("弮砰䜲倴娶瀸唺夼娾㥀捂ⱄ㑆楈❊⡌㱎≐獒⅔㽖㡘㕚絜潞䅠ౢᝤ䝦๨ᥪ࡬๮հᙲݴ坶൸፺ᱼᅾꆀꎂ", num) + paragraph.Items.Count);
            }
        }

        private Paragraph method_3(Paragraph A_0, Paragraph A_1)
        {
            Paragraph paragraph;
            int num = 10;
            if (A_1 != null)
            {
                paragraph = (Paragraph) A_1.Clone();
                this.method_5(paragraph);
                if (((paragraph.ParaStyle != null) && (paragraph.StyleName == BookmarkStart.b("縯崱䘳嬵夷嘹", num))) && (A_0.ParaStyle != null))
                {
                    paragraph.ParaStyle.method_7(A_0.ParaStyle.Name);
                }
            }
            else
            {
                paragraph = new Paragraph(this.body_1.Document);
            }
            this.body_1.Items.Insert(this.int_0 + 1, paragraph);
            while (A_0.Items.Count > (this.int_1 + 1))
            {
                paragraph.Items.Add(A_0.Items[this.int_1 + 1]);
            }
            return paragraph;
        }

        private void method_4(Document A_0)
        {
            if ((this.body_0 != null) && (this.body_0.Document == A_0))
            {
                this.Clear();
            }
            else
            {
                this.body_0 = new Body(A_0, null);
            }
        }

        private void method_5(Paragraph A_0)
        {
            if ((this.bool_2 && (this.characterFormat_0 != null)) && (A_0 != null))
            {
                foreach (ParagraphBase base2 in A_0.Items)
                {
                    if (base2 is TextRange)
                    {
                        base2.CharacterFormat.ImportContainer(this.characterFormat_0);
                    }
                }
            }
        }

        public void PasteAfter(BodyRegion bodyItem)
        {
            int num = bodyItem.method_5();
            this.PasteAt(bodyItem.OwnerTextBody, num + 1);
        }

        public void PasteAfter(ParagraphBase paragraphItem)
        {
            BodyRegion owner = paragraphItem.Owner as BodyRegion;
            int itemIndex = owner.method_5();
            int num2 = paragraphItem.method_5();
            this.PasteAt(owner.OwnerTextBody, itemIndex, num2 + 1);
        }

        public void PasteAt(IBody textBody, int itemIndex)
        {
            this.PasteAt(textBody, itemIndex, 0);
        }

        public void PasteAt(IBody textBody, int itemIndex, int pItemIndex)
        {
            if (this.body_0.Items.Count != 0)
            {
                this.body_1 = textBody as Body;
                this.int_0 = itemIndex;
                this.int_1 = pItemIndex;
                this.method_2();
                Paragraph paragraph = this.body_0.Items[0] as Paragraph;
                Paragraph paragraph6 = this.body_0.Items[this.body_0.ChildObjects.Count - 1] as Paragraph;
                Paragraph paragraph5 = (itemIndex < this.body_1.Items.Count) ? (this.body_1.Items[itemIndex] as Paragraph) : null;
                int num6 = 0;
                int num5 = 0;
                int num8 = this.body_0.Items.Count - 1;
                if ((((num8 > 0) || (paragraph == null)) && (paragraph5 != null)) && (this.int_1 >= 0))
                {
                    this.method_3(paragraph5, paragraph6);
                    num6 = 1;
                    if (paragraph6 != null)
                    {
                        num8--;
                    }
                }
                if (((paragraph != null) && (paragraph5 != null)) && (paragraph.ListFormat.ListType == ListType.NoList))
                {
                    int num9 = (paragraph5.Items.Count - 1) - this.int_1;
                    num9 = (num9 < 0) ? 0 : num9;
                    int index = paragraph5.Items.Count - num9;
                    Stack stack2 = new Stack();
                    Field field2 = null;
                    int num4 = 0;
                    int count = paragraph.Items.Count;
                    while (num4 < count)
                    {
                        DocumentObject entity = paragraph.Items[num4].Clone();
                        if (((entity is TextRange) && this.bool_2) && (this.characterFormat_0 != null))
                        {
                            (entity as TextRange).CharacterFormat.ImportContainer(this.characterFormat_0);
                        }
                        paragraph5.Items.Insert(index, entity);
                        if (entity is Field)
                        {
                            stack2.Push(field2);
                            field2 = entity as Field;
                        }
                        else if ((entity is FieldMark) && (field2 != null))
                        {
                            FieldMark mark2 = entity as FieldMark;
                            if (mark2.Type == FieldMarkType.FieldSeparator)
                            {
                                field2.Separator = mark2;
                            }
                            else
                            {
                                field2.End = mark2;
                                if (stack2.Count > 0)
                                {
                                    field2 = stack2.Pop() as Field;
                                }
                            }
                        }
                        index = paragraph5.Items.Count - num9;
                        num4++;
                    }
                    stack2 = null;
                    field2 = null;
                    if (((paragraph.Items.Count == 1) && !this.bool_2) && !string.IsNullOrEmpty(paragraph.StyleName))
                    {
                        paragraph5.method_65(paragraph.ParaStyle);
                        paragraph5.BreakCharacterFormat.ImportContainer(paragraph.BreakCharacterFormat);
                    }
                    if (this.bool_3)
                    {
                        paragraph5.Format.ImportContainer(paragraph.Format);
                    }
                    num5 = 1;
                    num6 = 1;
                }
                else if (((paragraph != null) && (paragraph5 != null)) && (paragraph.ListFormat.ListType != ListType.NoList))
                {
                    Paragraph paragraph2 = paragraph.Clone() as Paragraph;
                    this.body_1.Items.Insert(itemIndex + 1, paragraph2);
                    int num3 = 0;
                    Stack stack = new Stack();
                    Field field = null;
                    int num = 0;
                    int num2 = paragraph5.Items.Count;
                    while (num < num2)
                    {
                        DocumentObject obj2 = paragraph5.Items[0];
                        if (((obj2 is TextRange) && this.bool_2) && (this.characterFormat_0 != null))
                        {
                            (obj2 as TextRange).CharacterFormat.ImportContainer(this.characterFormat_0);
                        }
                        paragraph2.Items.Insert(num3, obj2);
                        if (obj2 is Field)
                        {
                            stack.Push(field);
                            field = obj2 as Field;
                        }
                        else if ((obj2 is FieldMark) && (field != null))
                        {
                            FieldMark mark = obj2 as FieldMark;
                            if (mark.Type == FieldMarkType.FieldSeparator)
                            {
                                field.Separator = mark;
                            }
                            else
                            {
                                field.End = mark;
                                if (stack.Count > 0)
                                {
                                    field = stack.Pop() as Field;
                                }
                            }
                        }
                        num3++;
                        num++;
                    }
                    stack = null;
                    field = null;
                    if (((paragraph.Items.Count == 1) && !this.bool_2) && !string.IsNullOrEmpty(paragraph.StyleName))
                    {
                        paragraph2.method_65(paragraph.ParaStyle);
                        paragraph2.BreakCharacterFormat.ImportContainer(paragraph.BreakCharacterFormat);
                    }
                    if (this.bool_3)
                    {
                        paragraph2.Format.ImportContainer(paragraph.Format);
                    }
                    this.method_5(paragraph2);
                    this.body_1.Items.RemoveAt(itemIndex);
                    num5 = 1;
                    num6 = 1;
                }
                itemIndex += num6 - num5;
                int num11 = num5;
                int num12 = num8;
                while (num11 <= num12)
                {
                    DocumentObject obj4 = this.body_0.Items[num11].Clone();
                    if (obj4 is Paragraph)
                    {
                        this.method_5(obj4 as Paragraph);
                    }
                    this.body_1.Items.Insert(itemIndex + num11, obj4);
                    num11++;
                }
                if ((((itemIndex > 0) && (this.body_1.Items[itemIndex - 1] is Paragraph)) && (((this.body_1.Items[itemIndex - 1] as Paragraph).Items.Count == 1) && ((this.body_1.Items[itemIndex - 1] as Paragraph).Items[0] is BookmarkStart))) && (this.body_0.Items[0] is Table))
                {
                    Paragraph paragraph4;
                    Paragraph paragraph3 = this.body_1.Items[itemIndex - 1] as Paragraph;
                    Table table = this.body_1.Items[itemIndex] as Table;
                    string name = (paragraph3.Items[0].Clone() as BookmarkStart).Name;
                    Document doc = this.body_1.Document;
                    doc.Bookmarks.Remove(doc.Bookmarks[name]);
                    paragraph3.RemoveSelf();
                    if ((table.FirstRow != null) && (table.FirstRow.Cells.Count > 0))
                    {
                        if (table.FirstRow.Cells[0].Items.Count == 0)
                        {
                            table.FirstRow.Cells[0].Items.Add(new Paragraph(doc));
                        }
                        if (table.FirstRow.Cells[0].Items[0] is Paragraph)
                        {
                            (table.FirstRow.Cells[0].Items[0] as Paragraph).Items.Insert(0, new BookmarkStart(doc, name));
                        }
                    }
                    if (this.body_0.Items.Count == 1)
                    {
                        paragraph4 = this.body_1.Items[itemIndex] as Paragraph;
                        paragraph4.Items.Insert(0, new BookmarkEnd(doc, name));
                    }
                    else
                    {
                        paragraph4 = this.body_1.Items[(itemIndex + this.body_0.Items.Count) - 2] as Paragraph;
                        if (paragraph4 == null)
                        {
                            paragraph4 = new Paragraph(doc);
                            this.body_1.Items.Add(paragraph4);
                        }
                        paragraph4.Items.Add(new BookmarkEnd(doc, name));
                    }
                }
            }
        }

        public void PasteAtEnd(IBody textBody)
        {
            this.PasteAt(textBody, ((Body) textBody).Items.Count);
        }

        internal static void smethod_0(Paragraph A_0, int A_1, Paragraph A_2)
        {
            int num = A_0.method_5();
            A_0.OwnerTextBody.Items.Insert(num + 1, A_2);
            while (A_0.Items.Count > A_1)
            {
                A_2.Items.Add(A_0.Items[A_1]);
            }
        }

        public BodyRegionCollection BodyItems
        {
            get
            {
                if (this.body_0 == null)
                {
                    return null;
                }
                return this.body_0.Items;
            }
        }
    }
}

