using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Markup;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

internal class Class423 : Class420, Interface14, Interface27
{
    private BinaryWriter binaryWriter_0;
    private BinaryWriter binaryWriter_1;
    private BinaryWriter binaryWriter_2;
    private bool bool_0;
    private static readonly byte[] byte_0 = new byte[] { 
        0xff, 0xff, 1, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
        0xff, 0xff, 1, 0, 0, 0, 0, 0, 0xff, 0xff, 0, 0, 2, 0, 0xff, 0xff, 
        0, 0, 0, 0, 0xff, 0xff, 0, 0, 2, 0, 0xff, 0xff, 0, 0, 0, 0
     };
    private CharacterFormat characterFormat_0;
    private Class1065 class1065_0;
    private static readonly Class1107 class1107_0 = new Class1107();
    internal static readonly Class1107 class1107_1 = Class1107.smethod_0();
    private static readonly Class1150 class1150_0 = new Class1150();
    private Class140 class140_0;
    private Class141 class141_0;
    private Class142 class142_0;
    private Class143 class143_0;
    private Class147 class147_0;
    private Class147 class147_1;
    private Class160 class160_0;
    private Class165 class165_0;
    private Class261 class261_0;
    private Class348 class348_0;
    private Class348 class348_1;
    private Class700 class700_0;
    private Class700 class700_1;
    private Class703 class703_0;
    private Class755 class755_0;
    private Class812 class812_0;
    private Class847 class847_0;
    private Class928 class928_0;
    private Class987 class987_0;
    private Document document_0;
    private FileFormat fileFormat_0;
    private static readonly Guid guid_0 = new Guid(BookmarkStart.b("ص࠷ਹ฻฽礿牁牃歅硇穉籋繍絏扑摓晕桗睙Ὓ湝偟剡䥣噥塧婩屫幭䁯䉱䑳䙵䡷乹䩻", 0x10));
    private const int int_1 = 0x800;
    private const int int_2 = 0x200;
    private const int int_3 = 0x34;
    private int int_4;
    private List<string> list_0 = new List<string>();
    private readonly Stack stack_0 = new Stack();
    internal Stack<Field> stack_1 = new Stack<Field>();
    private Stream stream_0;
    private Stream stream_1;
    private Stream stream_2;
    private string string_0 = string.Empty;

    private Class1104 imethod_0(Class928 A_0)
    {
        int num = 3;
        try
        {
            this.document_0 = A_0.document_0;
            if (this.document_0.IsEncrypted)
            {
                (A_0.class253_0 as Class256).method_13(this.document_0.method_158());
            }
            this.class847_0 = new Class847(A_0);
            this.class928_0 = A_0;
            this.method_7();
            this.method_9();
            this.method_8().method_5(A_0.stream_0);
        }
        finally
        {
            this.class847_0.method_1();
        }
        return new Class1104(BookmarkStart.b("䠨嬪崬䌮堰倲吴䌶倸吺匼ှⱀあ㉄⡆㭈⽊", num));
    }

    void Interface27.imethod_0(Class9 A_0)
    {
        this.class755_0.method_14(A_0);
        this.method_38(Class816.string_19, new CharacterFormat(this.document_0), class1107_1);
    }

    void Interface27.imethod_1(Class9 A_0)
    {
        this.method_38(Class816.string_20, new CharacterFormat(this.document_0), class1107_1);
        this.class755_0.method_15(A_0);
    }

    private void method_10()
    {
        this.class755_0.method_0(SubDocumentType.HeaderTextBox);
        Paragraph paragraph = this.document_0.LastSection.Body.method_44() as Paragraph;
        Paragraph paragraph2 = new Paragraph(this.document_0);
        if (paragraph != null)
        {
            paragraph2 = paragraph.Clone() as Paragraph;
            paragraph2.method_0(this.document_0);
            paragraph2.ChildObjects.Clear();
            paragraph2.Accept(this);
        }
        else
        {
            paragraph2 = this.document_0.LastSection.AddParagraph();
            paragraph2.Accept(this);
            paragraph2.RemoveSelf();
            paragraph2 = null;
        }
        this.class755_0.method_1();
    }

    private void method_11(Section A_0)
    {
        Class596 class2 = new Class596 {
            class429_0 = this.class142_0.method_64(A_0.SectPr)
        };
        this.class160_0.method_6(this.class755_0.method_20(), class2);
        A_0.Body.Accept(this);
        this.method_12(A_0.HeadersFooters[HeaderFooterType.HeaderEven]);
        this.method_12(A_0.HeadersFooters[HeaderFooterType.HeaderOdd]);
        this.method_12(A_0.HeadersFooters[HeaderFooterType.FooterEven]);
        this.method_12(A_0.HeadersFooters[HeaderFooterType.FooterOdd]);
        this.method_12(A_0.HeadersFooters[HeaderFooterType.HeaderFirstPage]);
        this.method_12(A_0.HeadersFooters[HeaderFooterType.FooterFirstPage]);
    }

    private void method_12(DocumentObject A_0)
    {
        this.class755_0.method_0(SubDocumentType.Header);
        this.class165_0.method_6(this.class755_0.method_20(), null);
        if (A_0 != null)
        {
            bool flag = true;
            Paragraph entity = null;
            ShapeObject obj2 = null;
            HeaderFooter footer = A_0 as HeaderFooter;
            if ((((footer != null) && !(footer.Owner as Section).HeadersFooters.LinkToPrevious) && (((footer.Type == HeaderFooterType.HeaderOdd) || (footer.Type == HeaderFooterType.HeaderFirstPage)) || (footer.Type == HeaderFooterType.HeaderEven))) && (footer.Watermark.Type != WatermarkType.NoWatermark))
            {
                flag = false;
                HeaderFooter footer2 = A_0 as HeaderFooter;
                BodyRegionCollection items = footer2.Items;
                if (items.Count == 0)
                {
                    entity = new Paragraph(A_0.Document);
                    items.Insert(0, entity);
                }
                else
                {
                    Paragraph paragraph3 = (footer2.Paragraphs.Count > 0) ? footer2.Paragraphs[0] : null;
                    DocumentObject obj3 = ((paragraph3 == null) || (items[0] is StructureDocumentTag)) ? items[0] : paragraph3;
                    if (obj3 is Table)
                    {
                        Table table = obj3 as Table;
                        entity = this.method_14(table);
                        if (entity == null)
                        {
                            Section ownerBase = items.Owner.OwnerBase as Section;
                            entity = new Paragraph(ownerBase.Document);
                            ownerBase.HeadersFooters.OddHeader.Items.Insert(0, entity);
                        }
                    }
                    else if (obj3 is StructureDocumentTag)
                    {
                        StructureDocumentTag tag = obj3 as StructureDocumentTag;
                        entity = this.method_15(tag);
                        if (entity == null)
                        {
                            Section section2 = items.Owner.OwnerBase as Section;
                            entity = new Paragraph(section2.Document);
                            section2.HeadersFooters.OddHeader.Items.Insert(0, entity);
                        }
                    }
                    else
                    {
                        entity = obj3 as Paragraph;
                    }
                }
                obj2 = this.method_13(footer.Watermark);
                if (obj2 != null)
                {
                    entity.ChildObjects.Insert(0, obj2);
                }
            }
            for (DocumentObject obj4 = A_0.FirstChild; obj4 != null; obj4 = (DocumentObject) obj4.NextSibling)
            {
                obj4.Accept(this);
            }
            if (A_0.HasChildElements)
            {
                new Paragraph(this.document_0).Accept(this);
            }
            if (!flag)
            {
                entity.ChildObjects.Remove(obj2);
                entity = null;
            }
        }
        this.class755_0.method_1();
    }

    private ShapeObject method_13(WatermarkBase A_0)
    {
        ShapeObject obj2 = null;
        if ((A_0 != null) && (A_0.Type != WatermarkType.NoWatermark))
        {
            if (A_0.Type == WatermarkType.TextWatermark)
            {
                obj2 = this.class261_0.method_5(A_0 as TextWatermark);
            }
            else
            {
                obj2 = this.class261_0.method_4(A_0 as PictureWatermark);
            }
            if (!obj2.ShapePr.HasKey(0x38f))
            {
                obj2.SetShapeAttribute(0x38f, ShapeHorizontalAlignment.Center);
            }
            if (!obj2.ShapePr.HasKey(0x390))
            {
                obj2.SetShapeAttribute(0x390, HorizontalOrigin.Margin);
            }
            if (!obj2.ShapePr.HasKey(0x391))
            {
                obj2.SetShapeAttribute(0x391, ShapeVerticalAlignment.Center);
            }
            if (!obj2.ShapePr.HasKey(0x392))
            {
                obj2.SetShapeAttribute(0x392, RelativeVerticalPosition.Margin);
            }
            if (!obj2.ShapePr.HasKey(0x3b0))
            {
                obj2.SetShapeAttribute(0x3b0, false);
            }
            if (!obj2.ShapePr.HasKey(0x103a))
            {
                obj2.SetShapeAttribute(0x103a, 0x7fffffffffffffffL);
            }
        }
        return obj2;
    }

    private Paragraph method_14(Table A_0)
    {
        foreach (TableRow row in A_0.Rows)
        {
            foreach (TableCell cell in row.Cells)
            {
                foreach (BodyRegion region in cell.Items)
                {
                    if (region is Paragraph)
                    {
                        return (region as Paragraph);
                    }
                    if (region is Table)
                    {
                        return this.method_14(region as Table);
                    }
                }
            }
        }
        if (A_0.Rows.Count > 0)
        {
            return A_0.Rows[0].Cells[0].AddParagraph();
        }
        return null;
    }

    private Paragraph method_15(StructureDocumentTag A_0)
    {
        if (A_0.ChildObjects.Count != 0)
        {
            if (A_0.ChildObjects[0] is Paragraph)
            {
                return (A_0.ChildObjects[0] as Paragraph);
            }
            if (A_0.ChildObjects[0] is Table)
            {
                return this.method_14(A_0.ChildObjects[0] as Table);
            }
        }
        return null;
    }

    private void method_16()
    {
        int num = 14;
        this.class755_0.method_12(BookmarkStart.b("欳昵儷夹䠻䬽㈿❁ك㍅⑇♉⥋㩍⍏", 14), 0);
        int num2 = 0;
        foreach (ListStyle style in this.document_0.ListStyles)
        {
            int num3 = 0;
            int count = style.Levels.Count;
            while (num3 < count)
            {
                ListLevel level = style.Levels[num3];
                if (level.PicBullet != null)
                {
                    level.CharacterFormat.ListPictureIndex = num2;
                    num2++;
                    ShapeObject picBullet = level.PicBullet;
                    picBullet.CharacterFormat.Hidden = true;
                    picBullet.Accept(this);
                }
                num3++;
            }
        }
        this.class755_0.method_13(BookmarkStart.b("欳昵儷夹䠻䬽㈿❁ك㍅⑇♉⥋㩍⍏", num));
    }

    private string method_17(Paragraph A_0)
    {
        TableCell cell = A_0.method_50();
        if ((cell != null) && ((cell.ChildObjects.Count == 0) || (cell.method_59() == A_0)))
        {
            if (this.class755_0.method_24() <= 1)
            {
                return Class816.string_24;
            }
            return Class816.string_27;
        }
        if (A_0.IsEndOfSection && !A_0.IsEndOfDocument)
        {
            return Class816.string_28;
        }
        return Class816.string_27;
    }

    private void method_18(Body A_0)
    {
        Paragraph paragraph = A_0.AddParagraph();
        this.vmethod_8(paragraph);
        this.vmethod_9(paragraph);
        paragraph.RemoveSelf();
        paragraph = null;
    }

    private Class430 method_19()
    {
        Class1150 class2 = new Class1150 {
            int_0 = this.class755_0.method_24()
        };
        if (this.class755_0.method_24() > 1)
        {
            class2.bool_2 = true;
            class2.bool_1 = true;
        }
        else
        {
            class2.bool_0 = true;
        }
        return this.class141_0.method_62(new ParagraphFormat(this.document_0), class2);
    }

    private void method_20(Class430 A_0)
    {
        this.class755_0.method_17(A_0);
        string str = (this.class755_0.method_24() > 1) ? Class816.string_27 : Class816.string_24;
        this.method_38(str, null, class1107_0);
    }

    private void method_21(TextRange A_0, Class1107 A_1)
    {
        int num = 0x12;
        string text = A_0.Text;
        if (A_0 is MergeField)
        {
            MergeField field = A_0 as MergeField;
            text = field.TextBefore + field.Text + field.TextAfter;
            text = field.method_240(text);
        }
        string[] strArray = text.Replace(BookmarkStart.b("㔷〹", num), BookmarkStart.b("㔷", num)).Replace('\n', '\r').Split(new char[] { '\r' });
        int index = 0;
        int length = strArray.Length;
        while (index < length)
        {
            this.method_38(strArray[index], (CharacterFormat) this.method_57(A_0.CharacterFormat), A_1);
            if (index < (length - 1))
            {
                Paragraph paragraph = A_0.method_28();
                if (paragraph != null)
                {
                    this.method_38(this.method_17(paragraph), (CharacterFormat) this.method_57(paragraph.BreakCharacterFormat), class1107_0);
                }
            }
            index++;
        }
    }

    private void method_22(MergeField A_0)
    {
        Class1107 class2 = class1107_0;
        if (A_0.Text == new string(' ', 5))
        {
            class2 = class1107_1;
        }
        if (!string.IsNullOrEmpty(A_0.TextBefore))
        {
            this.method_38(A_0.TextBefore, (CharacterFormat) this.method_57(A_0.CharacterFormat), class2);
        }
        this.method_21(A_0, class2);
        if (!string.IsNullOrEmpty(A_0.TextAfter))
        {
            this.method_38(A_0.TextAfter, (CharacterFormat) this.method_57(A_0.CharacterFormat), class2);
        }
    }

    private void method_23(MergeField A_0)
    {
        Class1107 class2 = class1107_0;
        if (A_0.Text == new string(' ', 5))
        {
            class2 = class1107_1;
        }
        try
        {
            this.method_21(A_0, class2);
        }
        catch
        {
            if (!string.IsNullOrEmpty(A_0.TextBefore))
            {
                this.method_38(A_0.TextBefore, (CharacterFormat) this.method_57(A_0.CharacterFormat), class2);
            }
            this.method_21(A_0, class2);
            if (!string.IsNullOrEmpty(A_0.TextAfter))
            {
                this.method_38(A_0.TextAfter, (CharacterFormat) this.method_57(A_0.CharacterFormat), class2);
            }
        }
    }

    public VisitorAction method_24(TextRange A_0)
    {
        this.method_38(A_0.Text, A_0.CharacterFormat, class1107_1);
        return VisitorAction.Continue;
    }

    private bool method_25()
    {
        return ((this.method_60() == SubDocumentType.Header) && this.class928_0.bool_2);
    }

    private void method_26()
    {
        this.class703_0.int_9 = 0x800;
        this.stream_0.Seek(0x800L, SeekOrigin.Begin);
        this.class703_0.int_14 = this.class755_0.method_22(SubDocumentType.Main).method_3(this.binaryWriter_0);
        this.class703_0.int_15 = this.class755_0.method_22(SubDocumentType.Footnote).method_3(this.binaryWriter_0);
        this.class703_0.int_16 = this.class755_0.method_22(SubDocumentType.Header).method_3(this.binaryWriter_0);
        this.class703_0.int_18 = this.class755_0.method_22(SubDocumentType.Comment).method_3(this.binaryWriter_0);
        this.class703_0.int_19 = this.class755_0.method_22(SubDocumentType.Endnote).method_3(this.binaryWriter_0);
        this.class703_0.int_20 = this.class755_0.method_22(SubDocumentType.Textbox).method_3(this.binaryWriter_0);
        this.class703_0.int_21 = this.class755_0.method_22(SubDocumentType.HeaderTextBox).method_3(this.binaryWriter_0);
        if ((((this.class703_0.int_15 > 0) || (this.class703_0.int_16 > 0)) || ((this.class703_0.int_18 > 0) || (this.class703_0.int_19 > 0))) || ((this.class703_0.int_20 > 0) || (this.class703_0.int_21 > 0)))
        {
            this.class703_0.int_21--;
        }
        this.class703_0.int_10 = (int) this.stream_0.Position;
    }

    private void method_27()
    {
        if (this.method_64())
        {
            this.class987_0 = new Class987();
            this.class987_0.method_6(this.binaryWriter_1, ((Class256) this.class928_0.class253_0).method_12());
        }
        this.class703_0.class597_0.class1111_1.int_0 = this.class703_0.class597_0.class1111_0.int_0 = (int) this.stream_1.Position;
        Class427 class3 = new Class427(this.document_0.FontInfoList, this.class812_0, this.document_0.Styles.DocStyleCollection);
        this.class703_0.class597_0.class1111_1.int_1 = this.class703_0.class597_0.class1111_0.int_1 = class3.method_7(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_6.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_6.int_1 = this.class160_0.vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.method_12((int) this.stream_1.Position);
        this.class703_0.class597_0.class1111_11.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_11.int_1 = this.class165_0.vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_12.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_12.int_1 = this.class147_0.vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_13.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_13.int_1 = this.class147_1.vmethod_1(this.binaryWriter_1);
        this.class700_0.method_0(this.class703_0, this.binaryWriter_1);
        this.class700_1.method_0(this.class703_0, this.binaryWriter_1);
        this.class1065_0.method_1(this.class703_0, this.binaryWriter_1);
        this.class703_0.class597_0.class1111_16.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_16.int_1 = this.class755_0.method_22(SubDocumentType.Main).method_7().vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_17.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_17.int_1 = this.class755_0.method_22(SubDocumentType.Header).method_7().vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_18.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_18.int_1 = this.class755_0.method_22(SubDocumentType.Footnote).method_7().vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_19.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_19.int_1 = this.class755_0.method_22(SubDocumentType.Comment).method_7().vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_48.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_48.int_1 = this.class755_0.method_22(SubDocumentType.Endnote).method_7().vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_57.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_57.int_1 = this.class755_0.method_22(SubDocumentType.Textbox).method_7().vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_59.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_59.int_1 = this.class755_0.method_22(SubDocumentType.HeaderTextBox).method_7().vmethod_1(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_50.int_0 = (int) this.stream_1.Position;
        bool flag = this.class703_0.int_16 > 0;
        this.class703_0.class597_0.class1111_50.int_1 = this.class261_0.method_20().method_6(this.binaryWriter_1, this.binaryWriter_0, flag);
        this.class348_0.method_3(this.class703_0, this.binaryWriter_1);
        this.class348_1.method_3(this.class703_0, this.binaryWriter_1);
        this.class755_0.method_25().method_1(this.class703_0, this.binaryWriter_1, this.class755_0.method_21());
        this.class755_0.method_26().method_5(this.class703_0, this.binaryWriter_1);
        this.class755_0.method_27().method_2(this.class703_0, this.binaryWriter_1);
        if (this.document_0.DropdownStrings != null)
        {
            this.class703_0.class597_0.class1111_45.int_0 = (int) this.stream_1.Position;
            this.binaryWriter_1.Write(this.document_0.DropdownStrings);
            this.class703_0.class597_0.class1111_45.int_1 = this.document_0.DropdownStrings.Length;
        }
        new Class1060(this.document_0.FontInfoList, this.class812_0, this.document_0.ListStyles, this.document_0.ListOverrides).method_2(this.class703_0, this.binaryWriter_1);
        Class1152.smethod_1(this.class703_0, this.binaryWriter_1, this.document_0.ListStyles, this.document_0.Frame);
        if (this.document_0.RouteSlip != null)
        {
            this.class703_0.class597_0.class1111_70.int_0 = (int) this.stream_1.Position;
            this.class703_0.class597_0.class1111_70.int_1 = this.document_0.RouteSlip.method_0(this.binaryWriter_1, this.document_0.Settings.int_27);
        }
        Class490 class4 = new Class490();
        this.class703_0.class597_0.class1111_24.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_24.int_1 = class4.method_0(this.document_0, this.binaryWriter_1);
        this.class703_0.class597_0.class1111_60.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_60.int_1 = Class125.smethod_1(this.document_0, this.binaryWriter_1);
        this.class703_0.class1057_0.method_7((int) this.stream_1.Position);
        Class770 class5 = new Class770();
        Class602 class6 = new Class602(0, this.class755_0.method_21(), 0x800, true);
        class5.method_3(class6);
        this.class703_0.class597_0.class1111_33.int_0 = (int) this.stream_1.Position;
        class5.method_0(this.binaryWriter_1);
        this.class703_0.class597_0.class1111_33.int_1 = ((int) this.stream_1.Position) - this.class703_0.class597_0.class1111_33.int_0;
        this.class703_0.bool_2 = false;
        this.class703_0.int_7 = 15;
        Class599.smethod_3(this.document_0.FontInfoList, this.class703_0, this.binaryWriter_1, this.binaryWriter_0);
        this.class703_0.class597_0.class1111_31.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_31.int_1 = Class659.smethod_3(this.document_0, this.binaryWriter_1);
        int position = (int) this.binaryWriter_1.BaseStream.Position;
        this.binaryWriter_1.BaseStream.Position = this.class703_0.class597_0.class1111_31.int_0;
        int count = this.class703_0.class597_0.class1111_31.int_1;
        byte[] buffer = new byte[count];
        this.binaryWriter_1.BaseStream.Read(buffer, 0, count);
        this.binaryWriter_1.BaseStream.Position = position;
        this.class703_0.class868_0.class1111_4.int_0 = (int) this.stream_1.Position;
        this.class703_0.class868_0.class1111_4.int_1 = this.method_28();
        this.class703_0.class597_0.class1111_32.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_32.int_1 = this.method_29();
        this.class703_0.class597_0.class1111_51.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_51.int_1 = this.class812_0.method_0(this.binaryWriter_1);
        Class342 class7 = new Class342();
        new Class1148().method_0(this.document_0.Settings.class460_0, this.class703_0, class7, this.binaryWriter_1);
        this.class755_0.method_28().method_1(this.class703_0, class7, this.binaryWriter_1);
        this.class703_0.class597_0.class1111_72.int_0 = (int) this.stream_1.Position;
        this.class703_0.class597_0.class1111_72.int_1 = class7.method_3(this.binaryWriter_1);
        this.class703_0.class1057_0.class1111_1.int_0 = (int) this.stream_1.Position;
        this.class703_0.class1057_0.class1111_1.int_1 = byte_0.Length;
        this.binaryWriter_1.Write(byte_0);
    }

    private int method_28()
    {
        if (!Class567.smethod_16(this.document_0.Settings.string_4))
        {
            return 0;
        }
        byte[] bytes = Encoding.Unicode.GetBytes(this.document_0.Settings.string_4);
        this.binaryWriter_1.Write(bytes);
        return bytes.Length;
    }

    private int method_29()
    {
        StringCollection strings = new StringCollection();
        strings.Add(smethod_0(""));
        strings.Add(smethod_0(this.document_0.Settings.string_0));
        strings.Add(smethod_0(this.document_0.BuiltinDocumentProperties.Title));
        strings.Add(smethod_0(this.document_0.BuiltinDocumentProperties.Subject));
        strings.Add(smethod_0(this.document_0.BuiltinDocumentProperties.Keywords));
        strings.Add(smethod_0(""));
        strings.Add(smethod_0(this.document_0.BuiltinDocumentProperties.Author));
        strings.Add(smethod_0(this.document_0.BuiltinDocumentProperties.LastAuthor));
        strings.Add(smethod_0(this.document_0.Settings.class460_0.method_11()));
        strings.Add(smethod_0(this.document_0.Settings.class460_0.method_19()));
        for (int i = 0; i < 7; i++)
        {
            strings.Add(smethod_0(""));
        }
        return Class343.smethod_4(this.binaryWriter_1, strings);
    }

    internal void method_3(Document A_0, string A_1)
    {
        this.method_4(A_0, A_1, FileFormat.Doc);
    }

    private void method_30()
    {
        Class120 class2 = new Class120();
        foreach (Class260 class5 in this.class755_0)
        {
            Class159 class3 = class5.method_5();
            for (int i = 0; i < class3.method_4(); i++)
            {
                Class430 class4 = class3.method_25(i);
                if (Class430.smethod_1(class4))
                {
                    class4 = Class430.smethod_2(this.stream_2, class4);
                }
                class2.method_0(class3.method_16(i), class3.method_16(i + 1), class4);
            }
        }
        this.class147_1 = class2.method_1(this.stream_0);
    }

    private void method_31()
    {
        int num = 10;
        Class121 class2 = new Class121();
        int num2 = 0;
        int num3 = 0;
        Class431 class3 = null;
        foreach (Class260 class6 in this.class755_0)
        {
            Class158 class4 = class6.method_6();
            for (int i = 0; i < class4.method_4(); i++)
            {
                int num5 = class4.method_16(i);
                int num6 = class4.method_16(i + 1);
                Class431 class5 = class4.method_25(i);
                if (class3 == null)
                {
                    num2 = num5;
                    num3 = num6;
                    class3 = class5;
                }
                else if (class3.method_1(class5))
                {
                    if (num3 != num5)
                    {
                        throw new InvalidOperationException(BookmarkStart.b("瘯崱䄳堵尷ᨹ崻ḽ✿⍁㑃晅⩇⽉㡋㥍㕏㝑㩓癕㹗㍙せ㭝䁟ၡᅣࡥ᭧䑩", num));
                    }
                    num3 = num6;
                }
                else
                {
                    class2.method_0(num2, num3, class3);
                    num2 = num5;
                    num3 = num6;
                    class3 = class5;
                }
            }
        }
        if (class3 != null)
        {
            class2.method_0(num2, num3, class3);
        }
        this.class147_0 = class2.method_1(this.stream_0);
    }

    private bool method_32(SubDocumentType A_0)
    {
        if (this.class755_0.method_22(A_0).method_13() > 0)
        {
            Class348 class2 = this.method_55(A_0);
            Class480 class3 = new Class480 {
                int_1 = -1
            };
            class2.method_1().method_6(this.class755_0.method_22(A_0).method_13(), class3);
            Class811 class4 = new Class811 {
                int_1 = 0xffff
            };
            this.method_36(A_0, class2.method_2(), class4);
            return true;
        }
        return false;
    }

    private bool method_33()
    {
        return this.method_36(SubDocumentType.Header, this.class165_0, null);
    }

    private bool method_34(FootnoteType A_0)
    {
        SubDocumentType type = Class700.smethod_0(A_0);
        Class700 class2 = this.method_56(A_0);
        return this.method_36(type, class2.method_7(), null);
    }

    private bool method_35()
    {
        return this.method_36(SubDocumentType.Comment, this.class1065_0.method_10(), null);
    }

    private bool method_36(SubDocumentType A_0, Class146 A_1, Interface35 A_2)
    {
        if (this.class755_0.method_22(A_0).method_13() > 0)
        {
            this.class755_0.method_0(A_0);
            A_1.method_6(this.class755_0.method_20(), A_2);
            new Paragraph(this.document_0).Accept(this);
            A_1.method_8(this.class755_0.method_20() + 2);
            this.class755_0.method_1();
            return true;
        }
        A_1.method_10();
        return false;
    }

    internal void method_37(string A_0, CharacterFormat A_1)
    {
        this.method_38(A_0, A_1, class1107_0);
    }

    internal void method_38(string A_0, CharacterFormat A_1, Class1107 A_2)
    {
        if (A_0 != string.Empty)
        {
            int num = this.class755_0.method_20();
            this.class755_0.method_9(A_0);
            int num2 = this.class755_0.method_20();
            if (A_1 == null)
            {
                A_1 = this.characterFormat_0;
            }
            Class431 class2 = this.class140_0.method_64(A_1, A_2, this.int_4 > 0);
            this.class755_0.method_10(num, num2, class2);
            this.characterFormat_0 = A_1;
        }
    }

    internal void method_39(FieldType A_0, CharacterFormat A_1)
    {
        bool flag;
        int num = 10;
        switch (A_0)
        {
            case FieldType.FieldTOCEntry:
            case FieldType.FieldRefDoc:
            case FieldType.FieldIndexEntry:
            case FieldType.FieldTOAEntry:
            case FieldType.FieldPrivate:
                flag = true;
                break;

            default:
                flag = false;
                break;
        }
        if (flag)
        {
            this.int_4++;
        }
        else
        {
            byte num2 = 0x13;
            if (A_0 == FieldType.FieldShape)
            {
                num2 = (byte) (num2 | 0x80);
            }
            if (A_1.Hidden && (((A_0 == FieldType.FieldFormTextInput) || (A_0 == FieldType.FieldFormDropDown)) || (A_0 == FieldType.FieldFormCheckBox)))
            {
                A_0 = FieldType.FieldCannotParse;
            }
            Class766 class2 = new Class766(num2, (byte) A_0);
            this.class755_0.method_11(class2);
        }
        this.method_38(Class816.string_16, A_1, class1107_1);
        if (this.stack_1.Count > 0)
        {
            Field field = this.stack_1.Peek();
            string str3 = field.ConvertSwitchesToString();
            string str = this.method_41(field);
            string str2 = this.method_42(field, str);
            string str4 = string.Empty;
            if (field.Type == FieldType.FieldHyperlink)
            {
                Hyperlink hyperlink = new Hyperlink(field);
                str4 = this.method_43(field, str, str2, str3);
                if (!string.IsNullOrEmpty(hyperlink.ToolTip))
                {
                    object obj2 = str4;
                    str4 = string.Concat(new object[] { obj2, BookmarkStart.b("氯崱", num), '"', hyperlink.ToolTip });
                }
            }
            else
            {
                str4 = string.IsNullOrEmpty(field.Code) ? this.method_43(field, str, str2, str3) : field.Code;
            }
            this.method_37(str4, A_1);
            if (((field.Type == FieldType.FieldMergeField) || (field.Type == FieldType.FieldFormCheckBox)) || ((field.Type == FieldType.FieldFormDropDown) || (field.Type == FieldType.FieldFormTextInput)))
            {
                if (field.Separator == null)
                {
                    this.vmethod_19(new FieldMark(field.Document, field.CharacterFormat, FieldMarkType.FieldSeparator));
                }
                if (field.End == null)
                {
                    this.method_37(field.Text, field.CharacterFormat);
                    this.method_40(new FieldMark(field.Document, field.CharacterFormat, FieldMarkType.FieldEnd));
                }
            }
        }
    }

    internal void method_4(Document A_0, string A_1, FileFormat A_2)
    {
        this.string_0 = A_1;
        using (Stream stream = File.OpenWrite(A_1))
        {
            this.method_6(A_0, stream, A_2);
        }
    }

    internal void method_40(FieldMark A_0)
    {
        bool flag;
        Field field = this.stack_1.Peek();
        switch (field.Type)
        {
            case FieldType.FieldTOCEntry:
            case FieldType.FieldRefDoc:
            case FieldType.FieldIndexEntry:
            case FieldType.FieldTOAEntry:
            case FieldType.FieldPrivate:
                flag = true;
                break;

            default:
                flag = false;
                break;
        }
        if (!flag)
        {
            Class766 class2 = new Class766(0x15, 0);
            class2.method_4(true);
            if (field.Type == FieldType.FieldShape)
            {
                class2.method_10(true);
                class2.method_14(true);
                class2.method_12(true);
            }
            else
            {
                class2.method_10(field.IsLocked);
                class2.method_14(field.IsDirty);
            }
            this.class755_0.method_11(class2);
        }
        this.method_38(Class816.string_18, A_0.CharacterFormat, class1107_1);
        if (flag)
        {
            this.int_4--;
        }
        this.stack_1.Pop();
    }

    private string method_41(Field A_0)
    {
        int num = 0x13;
        string fieldName = string.Empty;
        if (A_0 is MergeField)
        {
            MergeField field = A_0 as MergeField;
            if (field.FieldName != null)
            {
                fieldName = field.FieldName;
            }
            if ((field.Prefix != null) && (field.Prefix != ""))
            {
                fieldName = field.Prefix + BookmarkStart.b("̸", num) + field.FieldName;
            }
        }
        return fieldName;
    }

    private string method_42(Field A_0, string A_1)
    {
        string text = string.Empty;
        if ((A_0.Type != FieldType.FieldLink) && (A_0.Type != FieldType.FieldEmbed))
        {
            text = A_0.Text;
        }
        return text;
    }

    private string method_43(Field A_0, string A_1, string A_2, string A_3)
    {
        int num = 2;
        string str = BookmarkStart.b("ࠧ", 2) + Class819.smethod_3(A_0.Type) + BookmarkStart.b("ࠧ", 2);
        if (A_0.Type == FieldType.FieldExpression)
        {
            str = "";
        }
        if ((A_0.Type == FieldType.FieldHyperlink) && (A_3.Length != 0))
        {
            if ((A_0.LocalReference != null) && (A_0.LocalReference != string.Empty))
            {
                str = ((str + BookmarkStart.b("ࠧ", num) + A_0.Value) + BookmarkStart.b("ࠧ", num) + A_3) + BookmarkStart.b("ࠧ", num) + A_0.LocalReference;
            }
            else
            {
                str = str + BookmarkStart.b("ࠧ", num) + A_3;
            }
        }
        if (A_1.Length != 0)
        {
            str = str + BookmarkStart.b("ࠧ", num) + A_1;
        }
        if (((A_0.Value != null) && (A_0.Value.Length != 0)) && (A_1 != A_0.Value))
        {
            str = str + BookmarkStart.b("ࠧ", num) + A_0.Value;
        }
        if ((A_0.Type != FieldType.FieldHyperlink) && (A_3.Length != 0))
        {
            str = str + BookmarkStart.b("ࠧ", num) + A_3;
        }
        if (str == null)
        {
            str = BookmarkStart.b("ࠧ", num);
        }
        return str;
    }

    internal void method_44(CharacterFormat A_0)
    {
        this.method_49(A_0, class1107_1);
    }

    internal void method_45(FieldMark A_0, Field A_1)
    {
        string str = A_1.Value;
        if (!string.IsNullOrEmpty(str))
        {
            this.method_47(str, A_0.CharacterFormat);
        }
        this.method_44(A_0.CharacterFormat);
    }

    internal void method_46(CharacterFormat A_0, int A_1)
    {
        Class1107 class2 = Class1107.smethod_0();
        class2.bool_3 = true;
        class2.bool_2 = true;
        class2.int_1 = A_1;
        this.method_49(A_0, class2);
    }

    private void method_47(string A_0, CharacterFormat A_1)
    {
        Class1107 class2 = new Class1107 {
            bool_0 = true,
            bool_1 = true,
            int_1 = (int) this.stream_2.Position
        };
        this.int_4++;
        this.method_38('\x0001'.ToString(), A_1, class2);
        this.int_4--;
        long position = this.stream_2.Position;
        this.binaryWriter_2.Write(0);
        this.binaryWriter_2.Write((short) 0x44);
        this.binaryWriter_2.Write(new byte[0x3e]);
        this.binaryWriter_2.Write(this.method_48(A_0));
        long num2 = this.stream_2.Position;
        this.stream_2.Position = position;
        this.binaryWriter_2.Write((int) (num2 - position));
        this.stream_2.Position = num2;
    }

    private byte[] method_48(string A_0)
    {
        BinaryWriter writer = new BinaryWriter(new MemoryStream());
        writer.Write((byte) 8);
        new Class177(0, null, A_0, null).vmethod_3(writer);
        return ((MemoryStream) writer.BaseStream).ToArray();
    }

    private void method_49(CharacterFormat A_0, Class1107 A_1)
    {
        this.class755_0.method_11(new Class766(20, 0xff));
        this.method_38(Class816.string_17, A_0, A_1);
    }

    internal void method_5(Document A_0, Stream A_1)
    {
        this.method_6(A_0, A_1, FileFormat.Doc);
    }

    internal void method_50(Class347 A_0)
    {
        this.method_55(this.class755_0.method_23()).method_0().method_6(this.class755_0.method_20(), A_0);
    }

    internal int method_51(Class480 A_0)
    {
        return this.method_55(this.class755_0.method_23()).method_1().method_6(this.class755_0.method_20(), A_0);
    }

    internal void method_52(Class811 A_0)
    {
        this.method_55(this.class755_0.method_23()).method_2().method_6(this.class755_0.method_20(), A_0);
    }

    internal void method_53(SubDocumentType A_0)
    {
        this.class755_0.method_0(A_0);
    }

    internal void method_54()
    {
        this.class755_0.method_1();
    }

    private Class348 method_55(SubDocumentType A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case SubDocumentType.Main:
            case SubDocumentType.Textbox:
                return this.class348_0;

            case SubDocumentType.Header:
            case SubDocumentType.HeaderTextBox:
                return this.class348_1;
        }
        throw new InvalidOperationException(BookmarkStart.b("猥䘧伩含席唯儱䀳匵尷ᨹ伻䬽∿♁⭃╅㵇❉⥋⁍⑏牑⁓⽕⡗㽙牛", num));
    }

    private Class700 method_56(FootnoteType A_0)
    {
        int num = 7;
        switch (A_0)
        {
            case FootnoteType.Footnote:
                return this.class700_0;

            case FootnoteType.Endnote:
                return this.class700_1;
        }
        throw new InvalidOperationException(BookmarkStart.b("砬䄮娰崲娴䀶圸ᬺ嬼倾⹀㝂⭄⡆㵈⹊浌㭎⡐⍒ご祖", num));
    }

    private WordAttrCollection method_57(WordAttrCollection A_0)
    {
        if ((this.method_63() != null) && !this.method_63().method_2())
        {
            return A_0.SysDirectAttrs;
        }
        return A_0;
    }

    internal Class165 method_58()
    {
        return this.class165_0;
    }

    internal BinaryWriter method_59()
    {
        return this.binaryWriter_2;
    }

    internal void method_6(Document A_0, Stream A_1, FileFormat A_2)
    {
        this.fileFormat_0 = A_2;
        Class928 class2 = new Class928(A_0, A_1, this.string_0, new Class256(this.fileFormat_0));
        ((Interface14) this).imethod_0(class2);
    }

    internal SubDocumentType method_60()
    {
        return this.class755_0.method_23();
    }

    internal Document method_61()
    {
        return this.document_0;
    }

    internal Class928 method_62()
    {
        return this.class928_0;
    }

    private Class1056 method_63()
    {
        if (this.stack_0.Count <= 0)
        {
            return null;
        }
        return (Class1056) this.stack_0.Peek();
    }

    private bool method_64()
    {
        return Class567.smethod_16(((Class256) this.class928_0.class253_0).method_12());
    }

    internal bool method_65()
    {
        return this.bool_0;
    }

    private void method_7()
    {
        this.stream_0 = this.class847_0.method_0();
        this.binaryWriter_0 = new BinaryWriter(this.stream_0, Encoding.Unicode);
        this.stream_1 = this.class847_0.method_0();
        this.binaryWriter_1 = new BinaryWriter(this.stream_1, Encoding.Unicode);
        this.stream_2 = this.class847_0.method_0();
        this.binaryWriter_2 = new BinaryWriter(this.stream_2, Encoding.Unicode);
        this.class812_0 = new Class812();
        this.class142_0 = new Class142(this.class812_0);
        this.class141_0 = new Class141(null, this.class812_0);
        this.class143_0 = new Class143(null, this.class812_0, NFibEnum.Word2003);
        this.class140_0 = new Class140(this.document_0.FontInfoList, this.class812_0);
        this.class755_0 = new Class755();
        this.class160_0 = new Class160();
        this.class165_0 = new Class165();
        this.class700_0 = new Class700(FootnoteType.Footnote);
        this.class700_1 = new Class700(FootnoteType.Endnote);
        this.class1065_0 = new Class1065();
        this.class348_0 = new Class348(SubDocumentType.Main);
        this.class348_1 = new Class348(SubDocumentType.Header);
        this.class261_0 = new Class261(this);
        if (this.document_0.Background.Type != BackgroundType.NoBackground)
        {
            ShapeObject obj2 = new ShapeObject(this.document_0);
            obj2.ShapePr.method_26(this.document_0.Background.ShapePr);
            obj2.Id = this.class261_0.method_9();
            this.class261_0.method_20().method_13(obj2);
        }
        this.class703_0 = new Class703();
        this.class703_0.bool_5 = true;
        this.document_0.ListStyles.method_6();
    }

    private Class1132 method_8()
    {
        int num = 7;
        Class907 settings = this.document_0.Settings;
        switch (this.class928_0.method_0())
        {
            case FileFormat.Doc:
                this.class703_0.bool_0 = false;
                break;

            case FileFormat.Dot:
                this.class703_0.bool_0 = true;
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("砬䄮吰䬲䔴制娸伺堼嬾慀あ⑄ㅆⱈ歊⭌⁎⍐㹒㑔⍖睘", num));
        }
        this.class703_0.bool_7 = Class567.smethod_16(this.document_0.method_158());
        this.class703_0.bool_3 = true;
        this.class703_0.method_4(this.stream_0);
        this.method_26();
        Class567.smethod_6(this.stream_0, 0x200);
        this.method_31();
        this.method_30();
        this.class160_0.method_26(this.binaryWriter_0);
        this.method_27();
        this.class703_0.int_11 = (int) this.stream_0.Length;
        this.stream_0.Seek(0L, SeekOrigin.Begin);
        if (this.method_64())
        {
            this.class703_0.bool_4 = true;
            this.class703_0.bool_11 = false;
            this.class703_0.int_8 = 0x34;
        }
        this.class703_0.method_4(this.stream_0);
        Class1132 class2 = new Class1132(guid_0);
        class2.method_0().Add(BookmarkStart.b("稬䀮䌰圲焴堶娸为值娾⽀㝂", num), this.stream_0);
        class2.method_0().Add(this.class703_0.method_0(), this.stream_1);
        if (this.stream_2.Length > 0L)
        {
            class2.method_0().Add(BookmarkStart.b("椬丮䔰刲", num), this.stream_2);
        }
        if (this.method_64())
        {
            this.class987_0.method_7(class2, this.class703_0.method_0());
        }
        if (this.document_0.CompObj != null)
        {
            class2.method_0().method_2(BookmarkStart.b("Ⱜ氮帰帲䔴砶嬸儺", num), this.document_0.CompObj);
        }
        if (this.document_0.IsMacroEnabled)
        {
            class2.method_0().method_3(BookmarkStart.b("怬丮到䄲娴䐶", num), this.document_0.VbaMacros);
        }
        if (this.class928_0.class1089_0.Count > 0)
        {
            class2.method_0().method_3(BookmarkStart.b("戬䴮嬰嘲嘴䌶椸吺刼匾", num), this.class928_0.class1089_0);
        }
        Class1089 class3 = Class871.smethod_4(this.document_0.CustomXmlParts);
        if (class3 != null)
        {
            class2.method_0().method_3(BookmarkStart.b("怬尮帰眲吴䌶堸栺䤼倾㍀♂", num), class3);
        }
        new Class704().method_6(this.document_0.BuiltinDocumentProperties, this.document_0.CustomDocumentProperties, class2.method_0());
        this.document_0.Styles.method_5();
        return class2;
    }

    private void method_9()
    {
        this.method_12(this.document_0.FootnoteSeparators.method_0(FootnoteSeparatorType.FootnoteSeparator));
        this.method_12(this.document_0.FootnoteSeparators.method_0(FootnoteSeparatorType.FootnoteContinuation));
        this.method_12(this.document_0.FootnoteSeparators.method_0(FootnoteSeparatorType.FootnoteContinuationNotice));
        this.method_12(this.document_0.FootnoteSeparators.method_0(FootnoteSeparatorType.EndnoteSeparator));
        this.method_12(this.document_0.FootnoteSeparators.method_0(FootnoteSeparatorType.EndnoteContinuation));
        this.method_12(this.document_0.FootnoteSeparators.method_0(FootnoteSeparatorType.EndnoteContinuationNotice));
        this.class755_0.method_0(SubDocumentType.Main);
        for (DocumentObject obj2 = this.document_0.FirstChild; obj2 != null; obj2 = (DocumentObject) obj2.NextSibling)
        {
            this.method_11((Section) obj2);
        }
        this.class755_0.method_1();
        if (((((this.method_34(FootnoteType.Footnote) | this.method_33()) | this.method_35()) | this.method_34(FootnoteType.Endnote)) | this.method_32(SubDocumentType.Textbox)) | this.method_32(SubDocumentType.HeaderTextBox))
        {
            this.method_10();
        }
        this.class755_0.method_2(0x800);
        int num = this.class755_0.method_21();
        this.class160_0.method_8(num);
        this.class700_0.method_6().method_8(num);
        this.class1065_0.method_9().method_8(num);
        int num2 = this.class755_0.method_22(SubDocumentType.Main).method_13() + 2;
        this.class1065_0.method_11().method_8(num2);
        this.class1065_0.method_12().method_8(num2);
        this.class700_1.method_6().method_8(num);
        this.class348_0.method_0().method_8(num);
        this.class348_0.method_1().method_8(num);
        this.class348_1.method_0().method_8(this.class165_0.method_1());
        this.class348_1.method_1().method_8(num);
    }

    private static string smethod_0(string A_0)
    {
        if ((A_0 != null) && (A_0.Length <= 0xff))
        {
            return A_0;
        }
        return "";
    }

    public override VisitorAction vmethod_10(Table A_0)
    {
        this.stack_0.Push(new Class1056(this.document_0, A_0));
        if ((A_0 != null) && !string.IsNullOrEmpty(A_0.TableStyleName))
        {
            A_0.method_46();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_11(Table A_0)
    {
        this.stack_0.Pop();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_12(TableRow A_0)
    {
        this.class755_0.method_18();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_13(TableRow A_0)
    {
        Class430 class2 = this.class143_0.method_66(A_0, this.method_19(), this.binaryWriter_2, this.method_63());
        this.method_20(class2);
        this.class755_0.method_19();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_14(TableCell A_0)
    {
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_15(TableCell A_0)
    {
        if ((A_0.ChildObjects.Count == 0) || (A_0.method_59() is Table))
        {
            this.method_18(A_0);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_16(TextRange A_0)
    {
        Class1107 class2 = class1107_0;
        if (!(A_0.Text == new string(' ', 5)))
        {
            char ch = '\x0002';
            if (!(A_0.Text == ch.ToString()))
            {
                char ch2 = '\x0005';
                if (!(A_0.Text == ch2.ToString()))
                {
                    goto Label_0050;
                }
            }
        }
        class2 = class1107_1;
    Label_0050:
        this.method_21(A_0, class2);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_17(Symbol A_0)
    {
        Class1107 class2 = new Class1107 {
            string_0 = A_0.FontName,
            char_0 = A_0.Text
        };
        this.method_38('('.ToString(), (CharacterFormat) this.method_57(A_0.CharacterFormat), class2);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_18(Field A_0)
    {
        if ((A_0 is MergeField) && (A_0.ConvertedToText || (A_0 as MergeField).IsToTextOfMergeFieldEvent))
        {
            MergeField field = A_0 as MergeField;
            if (field.IsToTextOfMergeFieldEvent && (A_0.Text.Trim().Length > 0))
            {
                this.method_22(field);
            }
            else if (A_0.ConvertedToText && (A_0.Text.Trim().Length > 0))
            {
                this.method_23(field);
            }
            else
            {
                Class1107 class3 = class1107_0;
                if (A_0.Code == new string(' ', 5))
                {
                    class3 = class1107_1;
                }
                this.method_38(A_0.Text, (CharacterFormat) this.method_57(A_0.CharacterFormat), class3);
            }
        }
        else if (((A_0.Type == FieldType.FieldUnknown) && (A_0.Separator == null)) && (A_0.End == null))
        {
            Class1107 class2 = class1107_0;
            if (A_0.Code == new string(' ', 5))
            {
                class2 = class1107_1;
            }
            this.method_38(A_0.Code, (CharacterFormat) this.method_57(A_0.CharacterFormat), class2);
        }
        else
        {
            this.stack_1.Push(A_0);
            this.method_39(A_0.Type, A_0.CharacterFormat);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_19(FieldMark A_0)
    {
        if (this.stack_1.Count != 0)
        {
            Field field = this.stack_1.Peek();
            FieldType type = field.Type;
            if (A_0.Type == FieldMarkType.FieldSeparator)
            {
                switch (type)
                {
                    case FieldType.FieldIncludePicture:
                        this.bool_0 = true;
                        break;

                    case FieldType.FieldFormTextInput:
                    case FieldType.FieldFormDropDown:
                    case FieldType.FieldFormCheckBox:
                        this.vmethod_22(field as FormField);
                        break;
                }
                if (((type != FieldType.FieldPageRef) && (type != FieldType.FieldNoteRef)) && (type != FieldType.FieldRef))
                {
                    this.method_44(A_0.CharacterFormat);
                }
                else
                {
                    this.method_45(A_0, field);
                }
                if (((type == FieldType.FieldFormTextInput) && (A_0.NextSibling is FieldMark)) && ((field as FormField).Range.Count == 2))
                {
                    this.method_38((field as FormField).Text, field.CharacterFormat, class1107_0);
                }
            }
            else
            {
                if (type == FieldType.FieldIncludePicture)
                {
                    this.bool_0 = false;
                }
                this.method_40(A_0);
            }
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_20(Class2 A_0)
    {
        Field field = A_0.method_61();
        this.vmethod_18(field);
        this.vmethod_19(field.End);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_22(FormField A_0)
    {
        bool flag;
        switch (A_0.Type)
        {
            case FieldType.FieldFormTextInput:
            case FieldType.FieldFormCheckBox:
            case FieldType.FieldFormDropDown:
                flag = true;
                break;

            default:
                flag = false;
                break;
        }
        if (!flag)
        {
            return VisitorAction.SkipThisElement;
        }
        Class1107 class2 = new Class1107 {
            bool_0 = true,
            bool_1 = true,
            int_1 = (int) this.stream_2.Position
        };
        this.int_4++;
        this.method_38('\x0001'.ToString(), A_0.CharacterFormat, class2);
        this.int_4--;
        A_0.method_245(this.binaryWriter_2);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_23(BookmarkStart A_0)
    {
        Bookmark bookmark = A_0.Document.Bookmarks.FindByName(A_0.Name);
        if (((bookmark != null) && (bookmark.BookmarkEnd != null)) && (bookmark.BookmarkEnd.OwnerParagraph != null))
        {
            this.list_0.Add(A_0.Name);
            this.class755_0.method_12(A_0.Name, A_0.Flags);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_24(Break A_0)
    {
        string str = string.Empty;
        if (A_0.BreakType == BreakType.PageBreak)
        {
            str = Class816.string_26;
        }
        else if (A_0.BreakType == BreakType.ColumnBreak)
        {
            str = Class816.string_25;
        }
        else if (A_0.BreakType == BreakType.LineBreak)
        {
            A_0.TextRange.CharacterFormat.SetAttr(0x2d, A_0.ClearType);
            str = A_0.IsCrBreak ? Class816.string_27 : Class816.string_6;
        }
        this.method_37(str, A_0.TextRange.CharacterFormat);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_25(BookmarkEnd A_0)
    {
        if ((this.list_0.Count > 0) && this.list_0.Contains(A_0.Name))
        {
            this.class755_0.method_13(A_0.Name);
            this.list_0.Remove(A_0.Name);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_26(Footnote A_0)
    {
        Class700 class2 = this.method_56(A_0.FootnoteType);
        class2.method_2(this.class755_0.method_20(), A_0.IsAutoNumbered);
        if (A_0.IsAutoNumbered)
        {
            this.method_38(Class816.string_14, A_0.MarkerCharacterFormat, class1107_1);
        }
        else
        {
            this.method_38(A_0.CustomMarker, A_0.MarkerCharacterFormat, class1107_0);
        }
        this.class755_0.method_0(Class700.smethod_0(A_0.FootnoteType));
        class2.method_3(this.class755_0.method_20());
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_29(Footnote A_0)
    {
        this.class755_0.method_1();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_30(Comment A_0)
    {
        this.class1065_0.method_4(this.class755_0.method_20(), A_0);
        this.method_38(Class816.string_15, A_0.CharacterFormat, class1107_1);
        this.class755_0.method_0(SubDocumentType.Comment);
        this.class1065_0.method_5(this.class755_0.method_20());
        return VisitorAction.Continue;
    }

    internal override VisitorAction vmethod_31(CommentMark A_0)
    {
        A_0.Type = CommentMarkType.CommentStart;
        this.class1065_0.method_7(this.class755_0.method_20(), A_0.CommentId);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_32(Comment A_0)
    {
        this.class755_0.method_1();
        return VisitorAction.Continue;
    }

    internal override VisitorAction vmethod_33(CommentMark A_0)
    {
        A_0.Type = CommentMarkType.CommentEnd;
        this.class1065_0.method_8(this.class755_0.method_20(), A_0.CommentId);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_34(ShapeObject A_0)
    {
        return this.class261_0.method_2(A_0);
    }

    public override VisitorAction vmethod_35(ShapeObject A_0)
    {
        return this.class261_0.method_3(A_0);
    }

    public override VisitorAction vmethod_36(ShapeGroup A_0)
    {
        return this.class261_0.method_0(A_0);
    }

    public override VisitorAction vmethod_37(ShapeGroup A_0)
    {
        return this.class261_0.method_1(A_0);
    }

    public override VisitorAction vmethod_40(Class9 A_0)
    {
        if (A_0.method_29() == MarkupLevel.Inline)
        {
            this.Interface27.imethod_0(A_0);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_41(Class9 A_0)
    {
        if (A_0.method_29() == MarkupLevel.Inline)
        {
            this.Interface27.imethod_1(A_0);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_42(StructureDocumentTag A_0)
    {
        A_0.UpdateDataBinding();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_44(StructureDocumentTagInline A_0)
    {
        A_0.UpdateDataBinding();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_46(StructureDocumentTagCell A_0)
    {
        A_0.UpdateDataBinding();
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_47(StructureDocumentTagCell A_0)
    {
        if ((A_0.ChildObjects.Count == 0) || (A_0.method_59() is Table))
        {
            this.method_18(A_0);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_48(StructureDocumentTagRow A_0)
    {
        A_0.UpdateDataBinding();
        if ((A_0.ChildObjects.Count > 0) && !(A_0.ChildObjects[0] is StructureDocumentTagRow))
        {
            this.class755_0.method_18();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_49(StructureDocumentTagRow A_0)
    {
        if ((A_0.ChildObjects.Count > 0) && !(A_0.ChildObjects[0] is StructureDocumentTagRow))
        {
            Class430 class2 = this.class143_0.method_66(A_0, this.method_19(), this.binaryWriter_2, this.method_63());
            this.method_20(class2);
            this.class755_0.method_19();
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_5(Body A_0)
    {
        if ((A_0.Owner is Section) && ((A_0.ChildObjects.Count == 0) || (A_0.LastChild is Table)))
        {
            this.method_18(A_0);
        }
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_50(Class4 A_0)
    {
        this.class755_0.method_16(A_0);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_8(Paragraph A_0)
    {
        ParagraphFormat format = A_0.Format.Clone() as ParagraphFormat;
        format.method_0(A_0);
        Class1150 class2 = class1150_0;
        if (this.class755_0.method_24() > 0)
        {
            class2 = new Class1150 {
                int_0 = this.class755_0.method_24()
            };
            TableCell cell = A_0.method_50();
            if (((cell.DocumentObjectType == DocumentObjectType.TableCell) && ((cell.ChildObjects.Count == 0) || (cell.method_59() == A_0))) && (this.class755_0.method_24() > 1))
            {
                class2.bool_2 = true;
            }
            if (cell != null)
            {
                if ((cell.Owner.Owner is Table) && ((cell.Owner.Owner as Table).TableStyle != null))
                {
                    Interface8 tableStyle = (cell.Owner.Owner as Table).TableStyle;
                    if (!A_0.Format.HasKey(0x4c4) && tableStyle.imethod_0().HasValue(0x4c4))
                    {
                        format.AfterSpacing = tableStyle.imethod_0().AfterSpacing;
                    }
                    if (!A_0.Format.HasKey(0x4b0) && tableStyle.imethod_0().HasValue(0x4b0))
                    {
                        format.BeforeSpacing = tableStyle.imethod_0().BeforeSpacing;
                    }
                    if (!A_0.Format.HasKey(0x672) && tableStyle.imethod_0().HasValue(0x672))
                    {
                        format.LineSpacing = tableStyle.imethod_0().LineSpacing;
                        format.LineSpacingRule = tableStyle.imethod_0().LineSpacingRule;
                    }
                }
                if (A_0.ParaStyle != null)
                {
                    IParagraphStyle paraStyle = A_0.ParaStyle;
                    if (!A_0.Format.HasKey(0x4c4) && paraStyle.ParagraphFormat.HasValue(0x4c4))
                    {
                        format.AfterSpacing = paraStyle.ParagraphFormat.AfterSpacing;
                    }
                    if (!A_0.Format.HasKey(0x4b0) && paraStyle.ParagraphFormat.HasValue(0x4b0))
                    {
                        format.BeforeSpacing = paraStyle.ParagraphFormat.BeforeSpacing;
                    }
                    if (!A_0.Format.HasKey(0x672) && paraStyle.ParagraphFormat.HasValue(0x672))
                    {
                        format.LineSpacing = paraStyle.ParagraphFormat.LineSpacing;
                        format.LineSpacingRule = paraStyle.ParagraphFormat.LineSpacingRule;
                    }
                }
            }
        }
        Class430 class3 = this.class141_0.method_62((ParagraphFormat) this.method_57(format), class2);
        this.class755_0.method_17(class3);
        Class1043.smethod_0(A_0, this);
        return VisitorAction.Continue;
    }

    public override VisitorAction vmethod_9(Paragraph A_0)
    {
        if (!A_0.IsEmptyParagraph && A_0.IsEndOfDocument)
        {
            bool flag = false;
            foreach (ListStyle style in this.document_0.ListStyles)
            {
                int num = 0;
                int count = style.Levels.Count;
                while (num < count)
                {
                    ListLevel level = style.Levels[num];
                    if (level.PicBullet != null)
                    {
                        this.method_16();
                        flag = true;
                    }
                    if (flag)
                    {
                        break;
                    }
                    num++;
                }
                if (flag)
                {
                    break;
                }
            }
        }
        Class1043.smethod_1(A_0, this);
        this.method_38(this.method_17(A_0), (CharacterFormat) this.method_57(A_0.BreakCharacterFormat), class1107_0);
        return VisitorAction.Continue;
    }
}

