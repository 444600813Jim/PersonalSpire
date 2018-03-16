using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class482 : Interface28
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly Class389 class389_0;
    private Class764 class764_0;
    private readonly Class861 class861_0;
    private static Dictionary<string, DocPicture> dictionary_0 = new Dictionary<string, DocPicture>();
    private readonly Document document_0;
    private DocumentObject documentObject_0;
    private DocumentObject documentObject_1;
    private FieldCharType fieldCharType_0 = FieldCharType.Unknown;
    private ShapeObject shapeObject_0;
    private readonly Stack stack_0 = new Stack();
    private Stack<Class454> stack_1 = new Stack<Class454>();
    private Stack<ShapeObject> stack_2 = new Stack<ShapeObject>();
    private Stack<CommentMark> stack_3 = new Stack<CommentMark>();

    internal Class482(Document A_0, Class861 A_1, Class764 A_2)
    {
        this.class764_0 = A_2;
        this.document_0 = A_0;
        this.documentObject_0 = A_0;
        this.class389_0 = new Class389();
        this.class861_0 = A_1;
    }

    private void imethod_1(bool A_0)
    {
        this.class389_0.method_4();
        dictionary_0.Clear();
    }

    private void imethod_11(ParagraphFormat A_0, CharacterFormat A_1)
    {
        int num = 3;
        if (this.shapeObject_0 == null)
        {
            while (this.documentObject_0.DocumentObjectType == DocumentObjectType.SmartTag)
            {
                this.Interface28.imethod_35();
            }
            while (this.documentObject_0.DocumentObjectType == DocumentObjectType.CustomXml)
            {
                this.Interface28.imethod_37();
            }
            if (this.documentObject_0.DocumentObjectType != DocumentObjectType.Paragraph)
            {
                throw new InvalidOperationException(BookmarkStart.b("昨帪夬༮帰唲ᔴ䐶䀸唺帼ᄾ", num));
            }
            Paragraph paragraph = (Paragraph) this.documentObject_0;
            paragraph.method_23(A_0);
            if (A_0.HasKey(0x271a))
            {
                A_0.FormatRevision.method_4().method_0(paragraph);
            }
            this.method_1(paragraph, A_0);
            this.method_2(paragraph, A_0);
            paragraph.BreakCharacterFormat.method_73(A_1);
            Class646.smethod_1(paragraph.Format);
            this.method_13();
            if (this.documentObject_0.Owner is Comment)
            {
                this.method_13();
            }
            if (this.stack_2.Count > 0)
            {
                this.stack_2.Clear();
            }
        }
    }

    private void imethod_12(string A_0, CharacterFormat A_1)
    {
        int num = 0x11;
        Break @break = null;
        if (A_0.Length == 1)
        {
            switch (A_0[0])
            {
                case '\v':
                case '\r':
                    @break = new Break(this.document_0, BreakType.LineBreak) {
                        TextRange = { Text = BookmarkStart.b("㰶", num) },
                        ClearType = (LineBreakClear) A_1.method_52(0x2d)
                    };
                    if (A_0[0] == '\r')
                    {
                        @break.IsCrBreak = true;
                    }
                    break;

                case '\f':
                    @break = new Break(this.document_0, BreakType.PageBreak);
                    break;

                case '\x000e':
                    @break = new Break(this.document_0, BreakType.ColumnBreak);
                    break;
            }
            if (@break != null)
            {
                @break.TextRange.CharacterFormat.method_73(A_1);
            }
        }
        if ((this.stack_0.Count > 0) && (this.stack_0.Peek() is Field))
        {
            Field entity = this.stack_0.Peek() as Field;
            int index = -1;
            if (entity.NextSibling == null)
            {
                index = this.documentObject_0.ChildObjects.IndexOf(entity);
            }
            if (((index > -1) && (index == (this.documentObject_0.ChildObjects.Count - 1))) && (this.fieldCharType_0 == FieldCharType.Begin))
            {
                entity.Code = entity.Code + A_0;
                entity.CharacterFormat.method_25(A_1);
            }
            else if (entity.Type == FieldType.FieldMergeField)
            {
                TextRange range = entity;
                if (range.Text == string.Empty)
                {
                    range.Text = A_0;
                    range.ApplyCharacterFormat(A_1);
                }
                else
                {
                    range.Text = range.Text + A_0;
                }
            }
            else
            {
                this.documentObject_0.method_13((@break == null) ? ((IDocumentObject) new TextRange(this.document_0, A_0, A_1)) : ((IDocumentObject) @break));
            }
        }
        else
        {
            this.documentObject_0.method_13((@break == null) ? ((IDocumentObject) new TextRange(this.document_0, A_0, A_1)) : ((IDocumentObject) @break));
        }
    }

    private void imethod_14(Class42 A_0, CharacterFormat A_1)
    {
        switch (A_0.method_87())
        {
            case FormFieldType.TextInput:
            {
                TextFormField field3 = this.stack_0.Peek() as TextFormField;
                field3.Name = A_0.method_46();
                field3.ApplyCharacterFormat(A_1);
                field3.DefaultText = A_0.method_68();
                field3.MaximumLength = A_0.method_64();
                field3.StringFormat = A_0.method_70();
                field3.TextFieldType = A_0.method_66();
                return;
            }
            case FormFieldType.CheckBox:
            {
                CheckBoxFormField field = this.stack_0.Peek() as CheckBoxFormField;
                field.Name = A_0.method_46();
                field.ApplyCharacterFormat(A_1);
                field.CalculateOnExit = A_0.method_50();
                field.CheckBoxSize = (int) (((float) A_0.method_74()) / 2f);
                field.SizeType = A_0.method_72() ? CheckBoxSizeType.Auto : CheckBoxSizeType.Exactly;
                field.Checked = A_0.method_78();
                field.DefaultCheckBoxValue = A_0.method_76();
                return;
            }
            case FormFieldType.DropDown:
            {
                DropDownFormField field2 = this.stack_0.Peek() as DropDownFormField;
                field2.Name = A_0.method_46();
                field2.ApplyCharacterFormat(A_1);
                field2.DefaultDropDownValue = A_0.method_81();
                A_0.method_86().method_6(field2.DropDownItems);
                field2.DropDownSelectedIndex = A_0.method_83();
                return;
            }
        }
    }

    private void imethod_15(CharacterFormat A_0, FieldType A_1)
    {
        Field field;
        FieldType type = A_1;
        if (type <= FieldType.FieldMergeField)
        {
            if (type != FieldType.FieldIf)
            {
                if (type != FieldType.FieldMergeField)
                {
                    goto Label_0044;
                }
                field = new MergeField(this.document_0);
            }
            else
            {
                field = new IfField(this.document_0);
            }
            goto Label_007A;
        }
        switch (type)
        {
            case FieldType.FieldFormTextInput:
                field = new TextFormField(this.document_0);
                goto Label_007A;

            case FieldType.FieldFormCheckBox:
                field = new CheckBoxFormField(this.document_0);
                goto Label_007A;

            case FieldType.FieldFormDropDown:
                field = new DropDownFormField(this.document_0);
                goto Label_007A;
        }
    Label_0044:
        field = new Field(this.document_0);
    Label_007A:
        this.fieldCharType_0 = FieldCharType.Begin;
        field.Type = A_1;
        field.CharacterFormat = (CharacterFormat) A_0.Clone();
        this.documentObject_0.method_13(field);
        if (A_1 == FieldType.FieldTOC)
        {
            (this.documentObject_0 as Paragraph).IsTOCPara = true;
        }
        this.stack_0.Push(field);
    }

    private void imethod_16(CharacterFormat A_0, Class454 A_1)
    {
        Field field = this.stack_0.Peek() as Field;
        if ((field.Type == FieldType.FieldEmbed) || (field.Type == FieldType.FieldLink))
        {
            this.stack_1.Push(A_1);
        }
        field.UpdateFieldCode(field.Code);
        if (field.Type != FieldType.FieldMergeField)
        {
            FieldMark mark = new FieldMark(this.document_0, A_0, FieldMarkType.FieldSeparator);
            this.documentObject_0.method_13(mark);
            field.Separator = mark;
        }
        this.fieldCharType_0 = FieldCharType.Seperate;
    }

    private void imethod_17(CharacterFormat A_0, bool A_1, bool A_2)
    {
        Field field = this.stack_0.Peek() as Field;
        if (field.IsRuby)
        {
            Class2 class2 = new Class2(this.documentObject_0.Document);
            class2.method_60(field.Code);
            if ((this.documentObject_0.LastChild is Field) && (this.documentObject_0.LastChild as Field).IsRuby)
            {
                this.documentObject_0.method_20(this.documentObject_0.LastChild);
            }
            this.documentObject_0.method_13(class2);
            class2.ApplyCharacterFormat(A_0);
            this.stack_0.Pop();
        }
        else
        {
            field.IsLocked = A_1;
            field.IsDirty = A_2;
            FieldType type = Class819.smethod_2(field.Code);
            if (type != FieldType.FieldUnknown)
            {
                field.Type = type;
            }
            if (((field.Type == FieldType.FieldNumPages) || (field.Type == FieldType.FieldPage)) && ((this.documentObject_0.ChildObjects.Count > 0) && (this.documentObject_0.LastChild == field)))
            {
                this.class764_0.method_43().imethod_16(A_0, null);
                TextRange range = new TextRange(this.documentObject_0.Document) {
                    Text = string.Empty
                };
                range.ApplyCharacterFormat(field.CharacterFormat);
                this.documentObject_0.method_13(range);
            }
            if (field.Type != FieldType.FieldMergeField)
            {
                FieldMark mark = new FieldMark(this.document_0, A_0, FieldMarkType.FieldEnd);
                this.documentObject_0.method_13(mark);
                field.End = mark;
            }
            field.UpdateFieldCode(field.Code);
            if ((field.Type == FieldType.FieldDate) || (field.Type == FieldType.FieldTime))
            {
                field.method_49();
            }
            this.stack_0.Pop();
            this.fieldCharType_0 = FieldCharType.End;
            Class454 class3 = null;
            if (((field.Type == FieldType.FieldEmbed) || (field.Type == FieldType.FieldLink)) && (this.stack_2.Count > 0))
            {
                if (this.stack_1.Count > 0)
                {
                    class3 = this.stack_1.Pop();
                }
                this.method_6(field, class3);
            }
            if (field.Type == FieldType.FieldShape)
            {
                this.method_5(field);
            }
        }
    }

    private void imethod_18(ShapeBase A_0)
    {
        int num = 1;
        if (!A_0.IsGroup && A_0.IsPictureBullet)
        {
            DocPicture imageData = ((ShapeObject) A_0).ImageData;
            dictionary_0.Add(dictionary_0.Keys.Count.ToString(), imageData);
            foreach (ListStyle style in this.document_0.ListStyles)
            {
                int num3 = 0;
                int count = style.Levels.Count;
                while (num3 < count)
                {
                    ListLevel level = style.Levels[num3];
                    if (level.PicBulletId == (dictionary_0.Count - 1))
                    {
                        int num4 = dictionary_0.Count - 1;
                        level.PicBullet = dictionary_0[num4.ToString()];
                    }
                    num3++;
                }
            }
        }
        else
        {
            HeaderFooter footer = this.documentObject_0.method_1();
            if ((((A_0.ShapeType == ShapeType.Image) || (A_0.ShapeType == ShapeType.NonPrimitive)) || (A_0.ShapeType == ShapeType.CustomShape)) && (A_0 as ShapeObject).HasImage)
            {
                if (((footer != null) && (((footer.Type == HeaderFooterType.HeaderEven) || (footer.Type == HeaderFooterType.HeaderFirstPage)) || (footer.Type == HeaderFooterType.HeaderOdd))) && A_0.Name.StartsWith(BookmarkStart.b("瀦䘨太䤬缮堰倲䄴䈶䬸帺樼帾㕀♂㝄⩆⡈㥊♌", num)))
                {
                    if (this.document_0.Watermark.Type == WatermarkType.NoWatermark)
                    {
                        footer.WriteWatermark = true;
                    }
                    footer.Watermark = (A_0 as ShapeObject).method_62();
                    return;
                }
                A_0.method_0(this.documentObject_0);
                DocPicture picture = (A_0 as ShapeObject).ImageData;
                picture.CharacterFormat.method_73(A_0.CharacterFormat);
                picture.IsShape = true;
                this.documentObject_0.method_13(picture);
            }
            else
            {
                if (((footer != null) && (((footer.Type == HeaderFooterType.HeaderEven) || (footer.Type == HeaderFooterType.HeaderFirstPage)) || (footer.Type == HeaderFooterType.HeaderOdd))) && (((A_0.ShapeType == ShapeType.TextPlainText) && A_0.ShapePr.method_6(0xc0)) && A_0.Name.StartsWith(BookmarkStart.b("眦䘨尪䠬崮愰弲䀴䐶游娺䤼娾㍀โ⑄㕆≈ъ⽌╎㑐げ⅔", num))))
                {
                    if (this.document_0.Watermark.Type == WatermarkType.NoWatermark)
                    {
                        footer.WriteWatermark = true;
                    }
                    footer.Watermark = (A_0 as ShapeObject).method_61();
                    return;
                }
                this.documentObject_0.method_13(A_0);
            }
            this.stack_2.Push(A_0 as ShapeObject);
        }
    }

    private void imethod_2(Class17 A_0)
    {
        Section section = new Section(this.document_0);
        section.method_23(A_0);
        this.method_11(section);
    }

    private void imethod_21(string A_0, int A_1)
    {
        if (A_0 != BookmarkStart.b("琪紬䘮到䜲䀴䔶尸示䠼匾ⵀ♂ㅄ㑆", 5))
        {
            BookmarkStart start = new BookmarkStart(this.document_0, A_0) {
                Flags = A_1
            };
            this.method_14(start);
        }
    }

    private void imethod_22(string A_0)
    {
        if (A_0 != BookmarkStart.b("眧稩䔫䴭䐯䜱䘳匵稷伹倻刽┿㙁㝃", 2))
        {
            this.method_14(new BookmarkEnd(this.document_0, A_0));
        }
    }

    private void imethod_23(FootnoteType A_0, bool A_1, string A_2, CharacterFormat A_3)
    {
        Footnote footnote = new Footnote(this.document_0, A_2) {
            FootnoteType = A_0,
            IsAutoNumbered = A_1
        };
        if (A_3 != null)
        {
            footnote.MarkerCharacterFormat.ImportContainer(A_3);
        }
        this.method_11(footnote);
        if (footnote.FootnoteType == FootnoteType.Endnote)
        {
            this.document_0.Endnotes.Add(footnote);
        }
        else
        {
            this.document_0.Footnotes.Add(footnote);
        }
    }

    private void imethod_24()
    {
        int num = 6;
        if (this.documentObject_0.DocumentObjectType == DocumentObjectType.Body)
        {
            this.method_13();
        }
        if (this.documentObject_0.DocumentObjectType != DocumentObjectType.Footnote)
        {
            throw new InvalidOperationException(BookmarkStart.b("挫嬭䐯ሱ嬳倵ᠷ䤹䔻倽⌿汁", num));
        }
        this.method_13();
    }

    private void imethod_25(int A_0, string A_1, string A_2, DateTime A_3, CharacterFormat A_4)
    {
        Comment comment = new Comment(this.document_0) {
            CharacterFormat = A_4
        };
        comment.Format.CommentId = A_0;
        comment.Format.Initial = A_1;
        comment.Format.Author = A_2;
        comment.Format.DateTime = A_3;
        this.method_11(comment);
        if (this.stack_3.Count > 0)
        {
            CommentMark mark = this.stack_3.Peek();
            if (mark.CommentId == comment.Format.CommentId)
            {
                comment.CommentMarkEnd = mark;
            }
            this.stack_3.Pop();
            mark = this.stack_3.Peek();
            if (mark.CommentId == comment.Format.CommentId)
            {
                comment.CommentMarkStart = mark;
            }
            this.stack_3.Pop();
        }
    }

    private void imethod_30()
    {
        int num = 0x10;
        if (this.documentObject_0.DocumentObjectType != DocumentObjectType.Table)
        {
            throw new InvalidOperationException(BookmarkStart.b("礵䴷丹᰻儽☿扁㝃㽅♇⥉手", num));
        }
        Table table = (Table) this.documentObject_0;
        table.TableFormat.method_54();
        this.method_3(table);
        smethod_5(table);
        smethod_4(table);
        if (smethod_2(table))
        {
            smethod_3(table);
        }
        if ((table != null) && (table.Rows.Count > 0))
        {
            table.method_64();
        }
        this.method_13();
        if (table.Rows.Count == 0)
        {
            this.documentObject_0.method_20(table);
        }
    }

    private void imethod_32(RowFormat A_0)
    {
        int num = 14;
        if (this.documentObject_0.DocumentObjectType != DocumentObjectType.TableRow)
        {
            throw new InvalidOperationException(BookmarkStart.b("笳䌵䰷ᨹ医堽怿ㅁ㵃⡅⭇摉", num));
        }
        TableRow row = (TableRow) this.documentObject_0;
        Class732 class3 = (Class732) A_0.method_31(0x13ec);
        if (class3 != null)
        {
            row.HasTblPrEx = true;
            row.RowFormat.method_25(A_0);
            this.method_8(row, class3);
            smethod_8(row);
            smethod_10(row);
            this.method_9(A_0, row);
            row.RowFormat.Remove(0x13ec);
            Class580 formatRevision = row.RowFormat.FormatRevision;
            if (formatRevision != null)
            {
                formatRevision.method_4().Remove(0x13ec);
            }
            Class646.smethod_2(row.RowFormat);
            this.method_10(row);
            row.method_30();
            this.method_13();
        }
        else
        {
            this.method_13();
            row.method_19();
        }
    }

    private void imethod_36(Class9 A_0)
    {
        if (!this.class389_0.method_0(A_0, this.documentObject_0))
        {
            this.method_11(A_0);
        }
    }

    public void imethod_38(Class4 A_0)
    {
        this.documentObject_0.method_13(A_0);
    }

    private void imethod_40(Class1107 A_0, CharacterFormat A_1)
    {
        Symbol symbol = new Symbol(this.document_0);
        byte[] bytes = BitConverter.GetBytes(A_0.char_0);
        symbol.CharacterCode = bytes[0];
        symbol.CharCodeExt = bytes[1];
        symbol.FontName = A_0.string_0;
        symbol.CharacterFormat.method_73(A_1);
        this.documentObject_0.method_13(symbol);
    }

    private void imethod_6(HeaderFooterType A_0)
    {
        if (this.documentObject_0 is Section)
        {
            Section section = this.documentObject_0 as Section;
            switch (A_0)
            {
                case HeaderFooterType.HeaderEven:
                    this.method_12(section.HeadersFooters.EvenHeader);
                    return;

                case HeaderFooterType.HeaderOdd:
                    this.method_12(section.HeadersFooters.OddHeader);
                    return;

                case HeaderFooterType.FooterEven:
                    this.method_12(section.HeadersFooters.EvenFooter);
                    return;

                case HeaderFooterType.FooterOdd:
                    this.method_12(section.HeadersFooters.OddFooter);
                    return;

                case HeaderFooterType.HeaderFirstPage:
                    this.method_12(section.HeadersFooters.FirstPageHeader);
                    return;

                case HeaderFooterType.FooterFirstPage:
                    this.method_12(section.HeadersFooters.FirstPageFooter);
                    break;

                default:
                    return;
            }
        }
    }

    private void imethod_8(FootnoteSeparatorType A_0)
    {
        int num = 1;
        if (this.documentObject_0 != this.document_0)
        {
            throw new InvalidOperationException(BookmarkStart.b("愦䘨䐪夬䄮帰䜲倴᜶䨸帺䴼帾㍀≂ㅄ⡆㭈㡊捌", num));
        }
        Class8 class2 = new Class8(this.document_0, A_0);
        this.document_0.FootnoteSeparators.method_1(A_0, class2);
        this.documentObject_0 = class2;
    }

    void Interface28.imethod_0()
    {
        Class646.smethod_0(this.document_0.Styles, false);
    }

    void Interface28.imethod_10()
    {
        if (((this.shapeObject_0 == null) || (this.stack_2.Count <= 0)) || !(this.documentObject_0 is Paragraph))
        {
            if (this.documentObject_0 is Footnote)
            {
                Paragraph paragraph3 = new Paragraph(this.document_0);
                this.method_12((this.documentObject_0 as Footnote).TextBody);
                this.method_11(paragraph3);
            }
            else if (this.documentObject_0 is Class8)
            {
                Paragraph paragraph = new Paragraph(this.document_0);
                if ((this.documentObject_0 as Class8).method_104() == null)
                {
                    (this.documentObject_0 as Class8).method_105(new Body(this.document_0, this.documentObject_0));
                }
                paragraph.method_0((this.documentObject_0 as Class8).method_104());
                this.method_12(paragraph);
            }
            else if (this.documentObject_0 is Comment)
            {
                Paragraph paragraph2 = new Paragraph(this.document_0);
                this.method_12((this.documentObject_0 as Comment).Body);
                this.method_11(paragraph2);
            }
            else
            {
                this.method_11(new Paragraph(this.document_0));
            }
        }
    }

    void Interface28.imethod_13(char A_0, CharacterFormat A_1)
    {
        if (!this.method_4(A_0, A_1))
        {
            this.documentObject_0.method_13(new TextRange(this.document_0, A_0.ToString(), A_1));
        }
    }

    void Interface28.imethod_19(ShapeObject A_0)
    {
        if ((A_0.ShapeType == ShapeType.OleObject) && (this.documentObject_0.ChildObjects.IndexOf(A_0) > -1))
        {
            this.documentObject_0.method_20(A_0);
        }
        else
        {
            this.documentObject_1 = this.documentObject_0;
            this.documentObject_0 = A_0;
        }
        if (A_0.IsOle)
        {
            this.shapeObject_0 = A_0;
        }
    }

    void Interface28.imethod_20(ShapeObject A_0)
    {
        if (((A_0.ShapeType == ShapeType.OleObject) && (A_0.Owner == null)) && ((this.shapeObject_0 != null) && (this.documentObject_0.DocumentObjectType != DocumentObjectType.Shape)))
        {
            this.shapeObject_0 = null;
        }
        else
        {
            this.method_0(DocumentObjectType.Shape);
            this.documentObject_0 = this.documentObject_1;
            this.documentObject_1 = null;
            if ((A_0.ShapeType == ShapeType.TextBox) && A_0.HasInternalTextbox)
            {
                TextBox internerTextbox = A_0.InternerTextbox;
                DocumentObject owner = A_0.Owner;
                if (owner != null)
                {
                    int index = owner.ChildObjects.IndexOf(A_0);
                    A_0.RemoveSelf();
                    owner.ChildObjects.Insert(index, internerTextbox);
                }
            }
            if (this.shapeObject_0 != null)
            {
                for (int i = 0; i < this.shapeObject_0.ChildObjects.Count; i++)
                {
                    this.shapeObject_0.ChildObjects[i].method_19();
                }
                if (this.shapeObject_0.IsOle && !Class567.smethod_16(this.shapeObject_0.OleFormat.Interface49.get_ObjectType()))
                {
                    this.shapeObject_0.SetShapeType(ShapeType.Image);
                }
                this.shapeObject_0 = null;
            }
        }
    }

    void Interface28.imethod_26()
    {
        while (this.documentObject_0.DocumentObjectType != DocumentObjectType.Comment)
        {
            if (this.documentObject_0.DocumentObjectType == DocumentObjectType.TableRow)
            {
                this.method_13();
            }
            else
            {
                if (this.documentObject_0.DocumentObjectType == DocumentObjectType.TableCell)
                {
                    this.method_13();
                    continue;
                }
                if (this.documentObject_0.DocumentObjectType == DocumentObjectType.Table)
                {
                    this.method_13();
                }
            }
        }
        this.method_13();
    }

    void Interface28.imethod_27(int A_0)
    {
        CommentMark mark = new CommentMark(this.document_0, A_0, CommentMarkType.CommentStart);
        this.method_14(mark);
        this.stack_3.Push(mark);
    }

    void Interface28.imethod_28(int A_0)
    {
        CommentMark mark = new CommentMark(this.document_0, A_0, CommentMarkType.CommentEnd);
        this.method_14(mark);
        this.stack_3.Push(mark);
    }

    void Interface28.imethod_29()
    {
        this.method_11(new Table(this.document_0));
    }

    void Interface28.imethod_3()
    {
        int num = 11;
        if (this.documentObject_0.DocumentObjectType != DocumentObjectType.Section)
        {
            throw new InvalidOperationException(BookmarkStart.b("琰崲儴᜶嘸崺ᴼ䰾⑀⁂ㅄ⹆♈╊浌♎≐獒㩔≖ⵘ筚㉜㥞䅠ၢᱤ०੨䕪", num));
        }
        this.method_13();
    }

    void Interface28.imethod_31()
    {
        this.method_11(new TableRow(this.document_0));
    }

    void Interface28.imethod_33()
    {
        this.method_11(new TableCell(this.document_0));
    }

    void Interface28.imethod_34()
    {
        int num = 12;
        if (this.documentObject_0.DocumentObjectType != DocumentObjectType.TableCell)
        {
            throw new InvalidOperationException(BookmarkStart.b("紱䄳䈵ᠷ唹娻ḽ㌿㭁⩃╅晇", num));
        }
        this.method_13();
    }

    void Interface28.imethod_35()
    {
        if (this.documentObject_0.DocumentObjectType == DocumentObjectType.SmartTag)
        {
            this.method_13();
        }
    }

    void Interface28.imethod_37()
    {
        if (!this.class389_0.method_3((DocumentContainer) this.documentObject_0) && (this.documentObject_0.DocumentObjectType == DocumentObjectType.CustomXml))
        {
            this.method_13();
        }
    }

    FieldType Interface28.imethod_39()
    {
        if (this.stack_0.Count > 0)
        {
            Field field = (Field) this.stack_0.Peek();
            return field.Type;
        }
        return FieldType.FieldNone;
    }

    void Interface28.imethod_4()
    {
        if (this.documentObject_0 is Section)
        {
            this.method_12((this.documentObject_0 as Section).Body);
        }
    }

    void Interface28.imethod_5()
    {
        this.method_0(DocumentObjectType.Body);
        this.method_13();
    }

    void Interface28.imethod_7()
    {
        this.method_0(DocumentObjectType.HeaderFooter);
        this.method_13();
    }

    void Interface28.imethod_9()
    {
        smethod_0(this.documentObject_0);
        this.documentObject_0 = this.document_0;
    }

    private void method_0(DocumentObjectType A_0)
    {
        int num = 0x13;
        if ((this.documentObject_0.DocumentObjectType != A_0) && !(this.documentObject_0.Owner is TextBox))
        {
            if (this.documentObject_0.DocumentObjectType == DocumentObjectType.TableCell)
            {
                this.method_13();
                TableRow row2 = (TableRow) this.documentObject_0;
                this.method_13();
                row2.method_19();
                Table table = (Table) this.documentObject_0;
                smethod_5(table);
                this.method_13();
            }
            else if (this.documentObject_0.DocumentObjectType == DocumentObjectType.TableRow)
            {
                TableRow row = (TableRow) this.documentObject_0;
                this.method_13();
                row.method_19();
                this.method_13();
            }
            else
            {
                if (this.documentObject_0.DocumentObjectType != DocumentObjectType.Table)
                {
                    throw new InvalidOperationException(BookmarkStart.b("嘸为䤼Ἶ⹀╂敄㑆え╊⹌慎", num));
                }
                this.method_13();
            }
        }
        else
        {
            switch (A_0)
            {
                case DocumentObjectType.HeaderFooter:
                case DocumentObjectType.Shape:
                    smethod_0(this.documentObject_0);
                    break;
            }
        }
    }

    private void method_1(Paragraph A_0, ParagraphFormat A_1)
    {
        if (A_0 == null)
        {
            return;
        }
        if (A_1.method_31(0x3e8) == null)
        {
            goto Label_00B8;
        }
        int num2 = (int) A_1.method_31(0x3e8);
        string str2 = string.Empty;
        using (Dictionary<string, int>.Enumerator enumerator2 = this.class764_0.method_47().GetEnumerator())
        {
            KeyValuePair<string, int> current;
            while (enumerator2.MoveNext())
            {
                current = enumerator2.Current;
                if (current.Value == num2)
                {
                    goto Label_0065;
                }
            }
            goto Label_007E;
        Label_0065:
            str2 = current.Key;
        }
    Label_007E:
        if (this.document_0.StyleNameIds.ContainsValue(str2))
        {
            IParagraphStyle style2 = this.document_0.Styles.FindByName(str2, StyleType.ParagraphStyle) as IParagraphStyle;
            if (style2 != null)
            {
                A_0.method_65(style2);
            }
        }
    Label_00B8:
        if ((A_1.FormatRevision == null) || (A_1.FormatRevision.method_4().method_31(0x3e8) == null))
        {
            return;
        }
        int num = (int) A_1.FormatRevision.method_4().method_31(0x3e8);
        string str = string.Empty;
        using (Dictionary<string, int>.Enumerator enumerator = this.class764_0.method_47().GetEnumerator())
        {
            KeyValuePair<string, int> pair;
            while (enumerator.MoveNext())
            {
                pair = enumerator.Current;
                if (pair.Value == num)
                {
                    goto Label_0131;
                }
            }
            goto Label_0149;
        Label_0131:
            str = pair.Key;
        }
    Label_0149:
        if (this.document_0.StyleNameIds.ContainsValue(str))
        {
            IParagraphStyle style = this.document_0.Styles.FindByName(str, StyleType.ParagraphStyle) as IParagraphStyle;
            if (style != null)
            {
                A_1.FormatRevision.method_4().ApplyBase(style.ParagraphFormat);
            }
        }
    }

    private void method_10(TableRow A_0)
    {
        for (int i = 0; i < A_0.Cells.Count; i++)
        {
            if (A_0.Cells[i].CellFormat.HorizontalMerge == CellMerge.Continue)
            {
                if ((A_0.Cells[i].ChildObjects.Count == 1) && (A_0.Cells[i].ChildObjects[0].DocumentObjectType == DocumentObjectType.Paragraph))
                {
                    Paragraph paragraph = (Paragraph) A_0.Cells[i].ChildObjects[0];
                    if (paragraph.HasChildElements)
                    {
                        paragraph.ChildObjects.Clear();
                    }
                }
                else if (A_0.Cells[i].HasChildElements)
                {
                    A_0.Cells[i].ChildObjects.Clear();
                    A_0.Cells[i].method_13(new Paragraph(this.document_0));
                }
            }
        }
    }

    private void method_11(DocumentObject A_0)
    {
        this.documentObject_0.method_13(A_0);
        this.documentObject_0 = A_0;
        this.method_16();
    }

    private void method_12(DocumentObject A_0)
    {
        this.documentObject_0 = A_0;
        this.method_16();
    }

    private void method_13()
    {
        this.method_16();
        this.documentObject_0 = this.documentObject_0.ParentObject;
    }

    private void method_14(DocumentObject A_0)
    {
        if (this.method_15(A_0))
        {
            if ((A_0 is BookmarkStart) && (this.documentObject_0.LastChild is FormField))
            {
                this.documentObject_0.ChildObjects.Insert(this.documentObject_0.ChildObjects.Count - 1, A_0);
            }
            else
            {
                this.documentObject_0.method_13(A_0);
            }
        }
        else
        {
            this.arrayList_0.Add(A_0);
        }
    }

    private bool method_15(DocumentObject A_0)
    {
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.TextRange:
            case DocumentObjectType.Field:
            case DocumentObjectType.FieldMark:
            case DocumentObjectType.TextFormField:
            case DocumentObjectType.DropDownFormField:
            case DocumentObjectType.BookmarkStart:
            case DocumentObjectType.BookmarkEnd:
            case DocumentObjectType.Shape:
            case DocumentObjectType.ShapeGroup:
            case DocumentObjectType.Comment:
            case DocumentObjectType.Footnote:
            case DocumentObjectType.CommentMark:
            case DocumentObjectType.SmartTag:
            case DocumentObjectType.OfficeMath:
            case DocumentObjectType.SubDocument:
                return true;

            case DocumentObjectType.CustomXml:
                return (((Class9) A_0).method_29() == MarkupLevel.Inline);
        }
        return false;
    }

    private void method_16()
    {
        if (this.arrayList_0.Count != 0)
        {
            DocumentObject obj2 = (this.documentObject_0.DocumentObjectType == DocumentObjectType.Paragraph) ? this.documentObject_0 : this.documentObject_0.LastChild;
            if (obj2 is Paragraph)
            {
                foreach (DocumentObject obj3 in this.arrayList_0)
                {
                    ((Paragraph) obj2).method_13(obj3);
                }
                this.arrayList_0.Clear();
            }
        }
    }

    private void method_2(Paragraph A_0, ParagraphFormat A_1)
    {
        int num = 0;
        if (A_0 != null)
        {
            int key = -1;
            object obj2 = null;
            if (A_1.method_6(0x460))
            {
                key = (int) A_1.method_31(0x460);
            }
            else if ((A_1.FormatRevision != null) && A_1.FormatRevision.method_4().method_6(0x460))
            {
                key = (int) A_1.FormatRevision.method_4().method_31(0x460);
            }
            if (A_1.method_6(0x456))
            {
                obj2 = A_1.method_31(0x456);
            }
            else if ((A_1.FormatRevision != null) && A_1.FormatRevision.method_4().method_6(0x456))
            {
                obj2 = A_1.FormatRevision.method_4().method_31(0x456);
            }
            if (key == 0)
            {
                A_0.ListFormat.IsEmptyList = true;
            }
            else if ((key > 0) && this.document_0.ListStyles.ListStyleNames.ContainsKey(key.ToString()))
            {
                string name = this.document_0.ListStyles.ListStyleNames[key.ToString()];
                ListStyle style = this.document_0.ListStyles.FindByName(name);
                if (style != null)
                {
                    if (!string.IsNullOrEmpty(style.BaseListStyleName) && this.document_0.ListStyles.ListStyleNames.ContainsKey(style.BaseListStyleName))
                    {
                        string str = this.document_0.ListStyles.ListStyleNames[style.BaseListStyleName];
                        if (this.document_0.ListStyles.ListStyleNames.ContainsKey(str))
                        {
                            name = this.document_0.ListStyles.ListStyleNames[str];
                        }
                    }
                    if (name != null)
                    {
                        A_0.ListFormat.ApplyStyle(name);
                    }
                    if (this.class764_0.method_48().ContainsKey(key))
                    {
                        A_0.ListFormat.LFOStyleName = this.class764_0.method_48()[key];
                    }
                }
                if (obj2 != null)
                {
                    int num3;
                    if (obj2.GetType().Name == BookmarkStart.b("搥儧帩䤫", num))
                    {
                        num3 = (byte) obj2;
                    }
                    else
                    {
                        num3 = (int) obj2;
                    }
                    if (num3 > 8)
                    {
                        num3 = 8;
                    }
                    A_0.ListFormat.ListLevelNumber = num3;
                }
            }
        }
    }

    private void method_3(Table A_0)
    {
        if ((A_0.FirstRow == null) || (A_0.FirstRow.RowFormat.method_31(0xfa5) == null))
        {
            return;
        }
        int num = (int) A_0.FirstRow.RowFormat.method_31(0xfa5);
        string str = string.Empty;
        using (Dictionary<string, int>.Enumerator enumerator = this.class764_0.method_47().GetEnumerator())
        {
            KeyValuePair<string, int> current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.Value == num)
                {
                    goto Label_007A;
                }
            }
            goto Label_0092;
        Label_007A:
            str = current.Key;
        }
    Label_0092:
        if (this.document_0.StyleNameIds.ContainsValue(str))
        {
            Interface8 interface2 = this.document_0.Styles.FindByName(str, StyleType.TableStyle) as Interface8;
            if (interface2 != null)
            {
                A_0.method_44(interface2);
            }
        }
    }

    private bool method_4(char A_0, CharacterFormat A_1)
    {
        bool flag = false;
        if (A_0 != '\0')
        {
            return flag;
        }
        DocumentObject[] objArray = Class524.smethod_0(this.document_0, A_1);
        for (int i = 0; i < objArray.Length; i++)
        {
            this.documentObject_0.method_13(objArray[i]);
        }
        return true;
    }

    private void method_5(Field A_0)
    {
        ShapeBase base2 = smethod_1(A_0);
        if ((base2 != null) && !base2.IsImage)
        {
            base2.TextWrappingStyle = TextWrappingStyle.Inline;
        }
        int index = this.documentObject_0.ChildObjects.IndexOf(A_0.End);
        int num2 = this.documentObject_0.ChildObjects.IndexOf(A_0);
        while (index >= num2)
        {
            this.documentObject_0.ChildObjects.Remove(this.documentObject_0.ChildObjects[index]);
            index--;
        }
    }

    private void method_6(Field A_0, Class454 A_1)
    {
        ShapeObject obj2 = (this.shapeObject_0 != null) ? this.shapeObject_0 : this.stack_2.Pop();
        obj2.SetShapeType(ShapeType.OleObject);
        obj2.OleFormat.Field = A_0;
        obj2.OleFormat.method_86((A_0.Type == FieldType.FieldEmbed) ? OleLinkType.Embed : OleLinkType.Link);
        obj2.OleFormat.method_78();
        if (A_1 != null)
        {
            obj2.OleFormat.method_81(A_1.method_12());
        }
        int index = this.documentObject_0.ChildObjects.IndexOf(A_0.End);
        int num2 = this.documentObject_0.ChildObjects.IndexOf(A_0);
        while (index >= num2)
        {
            this.documentObject_0.ChildObjects.Remove(this.documentObject_0.ChildObjects[index]);
            index--;
        }
        DocOleObject oleFormat = obj2.OleFormat;
        this.documentObject_0.method_13(oleFormat);
        FieldMark mark = new FieldMark(this.document_0) {
            Type = FieldMarkType.FieldSeparator
        };
        this.documentObject_0.method_13(mark);
        DocPicture picture = oleFormat.Interface49.get_OlePicture();
        if (picture != null)
        {
            this.documentObject_0.method_13(picture);
            picture.ApplyCharacterFormat(obj2.CharacterFormat);
        }
        FieldMark mark2 = new FieldMark(this.document_0) {
            Type = FieldMarkType.FieldEnd
        };
        this.documentObject_0.method_13(mark2);
    }

    private ShapeObject method_7(FieldMark A_0)
    {
        if (this.shapeObject_0 != null)
        {
            return this.shapeObject_0;
        }
        if (A_0 == null)
        {
            return null;
        }
        return (A_0.NextSibling as ShapeObject);
    }

    private void method_8(TableRow A_0, Class732 A_1)
    {
        if (((A_0 != null) && (A_1 != null)) && (A_0.Cells.Count > A_1.Count))
        {
            int num3 = A_1.Count - 1;
            int count = A_0.Cells.Count;
            TableCell cell2 = A_0.Cells[A_1.Count - 1];
            for (int i = num3 + 1; i < A_0.Cells.Count; i++)
            {
                TableCell cell = A_0.Cells[i];
                if (cell.ChildObjects.Count > 0)
                {
                    for (int j = 0; j < cell.ChildObjects.Count; j++)
                    {
                        cell2.ChildObjects.Add(cell.ChildObjects[j]);
                        j--;
                    }
                }
                A_0.Cells.Remove(cell);
                i--;
            }
        }
    }

    private void method_9(RowFormat A_0, TableRow A_1)
    {
        foreach (TableCell cell in A_1.Cells)
        {
            if (!cell.CellFormat.SamePaddingsAsTable && !A_0.Paddings.IsDefault)
            {
                if (!cell.CellFormat.Paddings.HasKey(1) && A_0.Paddings.HasKey(1))
                {
                    cell.CellFormat.Paddings.Left = A_0.Paddings.Left;
                }
                if (!cell.CellFormat.Paddings.HasKey(4) && A_0.Paddings.HasKey(4))
                {
                    cell.CellFormat.Paddings.Right = A_0.Paddings.Right;
                }
                if (!cell.CellFormat.Paddings.HasKey(2) && A_0.Paddings.HasKey(2))
                {
                    cell.CellFormat.Paddings.Top = A_0.Paddings.Top;
                }
                if (!cell.CellFormat.Paddings.HasKey(3) && A_0.Paddings.HasKey(3))
                {
                    cell.CellFormat.Paddings.Bottom = A_0.Paddings.Bottom;
                }
            }
        }
    }

    private static void smethod_0(DocumentObject A_0)
    {
        DocumentObject lastChild = A_0.LastChild;
        if ((lastChild is Paragraph) && !((Paragraph) lastChild).HasChildElements)
        {
            lastChild.method_19();
        }
    }

    private static ShapeBase smethod_1(Field A_0)
    {
        DocumentObject nextSibling = A_0.Separator.NextSibling as DocumentObject;
        ShapeBase base2 = null;
        while (nextSibling != A_0.End)
        {
            DocumentObject obj3 = nextSibling.NextSibling as DocumentObject;
            if ((nextSibling.DocumentObjectType == DocumentObjectType.Shape) || (nextSibling.DocumentObjectType == DocumentObjectType.ShapeGroup))
            {
                base2 = (ShapeBase) nextSibling;
            }
            A_0.OwnerParagraph.ChildObjects.Insert(A_0.OwnerParagraph.ChildObjects.IndexOf(A_0), nextSibling);
            nextSibling = obj3;
        }
        return base2;
    }

    private static void smethod_10(TableRow A_0)
    {
        int num = 14;
        if (A_0.RowFormat.HasFormatRevision)
        {
            Class580 formatRevision = A_0.RowFormat.FormatRevision;
            RowFormat format2 = (RowFormat) formatRevision.method_4();
            Class732 class2 = (Class732) format2.method_31(0x13ec);
            if (class2 == null)
            {
                A_0.RowFormat.method_47();
            }
            else
            {
                int num3 = 0;
                for (int i = 0; i < A_0.Cells.Count; i++)
                {
                    TableCell cell = A_0.Cells[i];
                    Class580 class4 = new Class580(class2.method_0(num3), formatRevision.method_0(), formatRevision.method_2());
                    cell.CellFormat.FormatRevision = class4;
                    num3++;
                }
                if (num3 != class2.Count)
                {
                    throw new InvalidOperationException(BookmarkStart.b("稳䌵唷堹夻䰽怿ⵁ≃晅㡇㡉⍋㹍㕏⁑⁓㽕㵗⥙牛", num));
                }
            }
        }
    }

    private static bool smethod_2(Table A_0)
    {
        if (A_0.Rows.Count == 0)
        {
            return false;
        }
        return A_0.Rows[0].RowFormat.method_6(0x13ee);
    }

    private static void smethod_3(Table A_0)
    {
        TableRow row = A_0.Rows[0];
        int num = (int) row.RowFormat.method_31(0x13ee);
        foreach (TableRow row3 in A_0.Rows)
        {
            int num5 = (int) row3.RowFormat.method_31(0x13ee);
            if (num5 < num)
            {
                num = num5;
                row = row3;
            }
        }
        int num6 = (int) ((((row.Cells[0] == null) || !row.Cells[0].CellFormat.HasKey(0xc12)) ? row.RowFormat.Paddings.Left : row.Cells[0].CellFormat.Paddings.Left) * 20f);
        int num2 = num6 + ((int) row.RowFormat.method_31(0x13ee));
        foreach (TableRow row2 in A_0.Rows)
        {
            RowFormat rowFormat = row2.RowFormat;
            int num4 = ((int) rowFormat.method_31(0x13ee)) - num;
            if (num4 != 0)
            {
                rowFormat.GridBeforeWidth.method_50((float) num4);
            }
            int num3 = (int) Math.Round((double) (rowFormat.LeftIndent * 20f));
            if (((num2 != 0) && (num != 0)) && (!rowFormat.method_6(0x10f4) || (rowFormat.method_6(0x13ee) && (Class59.smethod_4((float) num3, (float) num2, 0.001f) != 0))))
            {
                rowFormat.LeftIndent = ((float) num2) / 20f;
            }
            rowFormat.Remove(0x13ee);
        }
    }

    private static void smethod_4(Table A_0)
    {
        if (A_0.FirstRow != null)
        {
            RowFormat rowFormat = A_0.Rows[0].RowFormat;
            object obj2 = rowFormat.method_31(0xfb4);
            object obj3 = rowFormat.method_31(0x10e0);
            foreach (TableRow row in A_0.Rows)
            {
                RowFormat format2 = row.RowFormat;
                if ((obj2 != null) && (format2.method_31(0xfb4) == null))
                {
                    format2.Paddings.Left = 5.4f;
                }
                if ((obj3 != null) && (format2.method_31(0x10e0) == null))
                {
                    format2.Paddings.Right = 5.4f;
                }
            }
        }
    }

    private static void smethod_5(Table A_0)
    {
        TableRow row = null;
        TableRow firstRow = A_0.FirstRow;
        int num = 0;
        while (firstRow != null)
        {
            if ((row != null) && !smethod_6(row, firstRow))
            {
                A_0 = smethod_7(firstRow);
                row = null;
                firstRow = A_0.FirstRow;
            }
            else
            {
                row = firstRow;
                num++;
                if (num < A_0.Rows.Count)
                {
                    firstRow = A_0.Rows[num];
                    continue;
                }
                firstRow = null;
            }
        }
    }

    private static bool smethod_6(TableRow A_0, TableRow A_1)
    {
        if (!A_0.RowFormat.method_49(A_1.RowFormat))
        {
            return false;
        }
        if (!A_0.RowFormat.IsFloating)
        {
            Paragraph paragraph2 = (Paragraph) A_0.GetChildElements(4, 1)[0];
            Paragraph paragraph = (Paragraph) A_1.GetChildElements(4, 1)[0];
            if ((paragraph2 != null) && (paragraph != null))
            {
                return paragraph2.method_37(paragraph);
            }
        }
        return true;
    }

    private static Table smethod_7(TableRow A_0)
    {
        IDocumentObject nextSibling;
        Table parentTable = A_0.ParentTable;
        Table table2 = new Table(parentTable.Document);
        parentTable.ParentObject.method_17(table2, parentTable);
        for (IDocumentObject obj2 = A_0; obj2 != null; obj2 = nextSibling)
        {
            nextSibling = obj2.NextSibling;
            parentTable.method_20((DocumentObject) obj2);
            table2.method_13(obj2);
        }
        return table2;
    }

    private static void smethod_8(TableRow A_0)
    {
        Class732 class2 = (Class732) A_0.RowFormat.method_31(0x13ec);
        TableCell cell = A_0.Cells[0];
        int num = 0;
        while (cell != null)
        {
            if (num >= class2.Count)
            {
                break;
            }
            cell.CellFormat = class2.method_0(num);
            num++;
            if (num < class2.Count)
            {
                cell = A_0.Cells[num];
            }
            else
            {
                cell = null;
            }
        }
        if (cell != null)
        {
            smethod_9(cell, null);
        }
    }

    internal static void smethod_9(DocumentObject A_0, DocumentObject A_1)
    {
        DocumentObject nextSibling;
        int num = 14;
        if ((A_1 != null) && (A_1.ParentObject != A_0.ParentObject))
        {
            throw new ArgumentException(BookmarkStart.b("朳䈵夷䠹䠻ḽℿⱁ⁃晅ⵇ⑉⡋湍ᕏ㹑ㅓ㭕㵗㑙⡛ⵝ䁟ཡᅣᕥᱧ䩩ѫ཭ٯ᝱味ɵၷό屻ൽꚅﺋﺏ몓", num));
        }
        for (DocumentObject obj2 = A_0; obj2 != A_1; obj2 = nextSibling)
        {
            nextSibling = (DocumentObject) obj2.NextSibling;
            obj2.method_19();
        }
    }
}

