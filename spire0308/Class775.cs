using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

internal class Class775
{
    private bool bool_0;
    private Document document_0;
    private HybridDictionary hybridDictionary_0;
    private int int_0;
    private Paragraph paragraph_0;
    private string string_0 = "";
    private TextWriter textWriter_0;

    internal HybridDictionary method_0()
    {
        if (this.hybridDictionary_0 == null)
        {
            this.hybridDictionary_0 = new HybridDictionary();
        }
        return this.hybridDictionary_0;
    }

    public string method_1(Document A_0)
    {
        this.document_0 = A_0;
        this.bool_0 = true;
        this.method_18();
        this.bool_0 = false;
        return this.string_0;
    }

    private void method_10(IParagraphBase A_0)
    {
        IParagraphBase base2 = A_0;
        DocumentObjectType documentObjectType = base2.DocumentObjectType;
        if (documentObjectType <= DocumentObjectType.TextRange)
        {
            switch (documentObjectType)
            {
                case DocumentObjectType.StructureDocumentTagInline:
                    this.method_9((base2 as StructureDocumentTagInline).SDTContent.Items);
                    break;

                case DocumentObjectType.TextRange:
                    this.method_13(base2 as ITextRange);
                    break;
            }
        }
        else
        {
            switch (documentObjectType)
            {
                case DocumentObjectType.Shape:
                {
                    ShapeObject obj4 = base2 as ShapeObject;
                    if (!obj4.HasInternalTextbox)
                    {
                        if (obj4.IsGroup)
                        {
                            foreach (DocumentObject obj2 in obj4.ChildObjects)
                            {
                                if (obj2 is ParagraphBase)
                                {
                                    this.method_10(obj2 as ParagraphBase);
                                }
                            }
                        }
                        break;
                    }
                    this.method_7(obj4.InternerTextbox.Body);
                    return;
                }
                case DocumentObjectType.ShapeGroup:
                {
                    ShapeGroup group = base2 as ShapeGroup;
                    foreach (DocumentObject obj3 in group.ChildObjects)
                    {
                        if (obj3 is ParagraphBase)
                        {
                            this.method_10(obj3 as ParagraphBase);
                        }
                    }
                    break;
                }
                case DocumentObjectType.TextBox:
                    this.method_7((base2 as TextBox).Body);
                    return;

                case DocumentObjectType.Break:
                    if ((base2 as Break).BreakType != BreakType.LineBreak)
                    {
                        break;
                    }
                    this.method_16();
                    return;

                case DocumentObjectType.Symbol:
                    this.method_14(base2 as Symbol);
                    return;

                default:
                    return;
            }
        }
    }

    protected void method_11(ITable A_0)
    {
        foreach (TableRow row in A_0.Rows)
        {
            foreach (TableCell cell in row.Cells)
            {
                this.method_7(cell);
            }
        }
    }

    protected void method_12(ISection A_0, bool A_1)
    {
        int num = 15;
        if (this.bool_0)
        {
            this.string_0 = this.string_0 + BookmarkStart.b("㠴㴶", num);
        }
        else if (!A_1)
        {
            this.textWriter_0.WriteLine("");
        }
        this.int_0++;
    }

    protected void method_13(ITextRange A_0)
    {
        if (this.bool_0)
        {
            this.string_0 = this.string_0 + A_0.Text;
        }
        else
        {
            this.textWriter_0.Write(A_0.Text);
        }
    }

    protected void method_14(Symbol A_0)
    {
        if (this.bool_0)
        {
            this.string_0 = this.string_0 + ((char) A_0.CharacterCode);
        }
        else
        {
            this.textWriter_0.Write((char) A_0.CharacterCode);
        }
    }

    protected void method_15(IParagraph A_0)
    {
        int num = 3;
        ListFormat listFormatForApplyStyle = (A_0 as Paragraph).GetListFormatForApplyStyle();
        if (listFormatForApplyStyle.CurrentListStyle != null)
        {
            if ((listFormatForApplyStyle.CurrentListStyle.ListType == ListType.Bulleted) || ((listFormatForApplyStyle.CurrentListLevel != null) && (listFormatForApplyStyle.CurrentListLevel.PatternType == ListPatternType.Bullet)))
            {
                if (this.bool_0)
                {
                    this.string_0 = this.string_0 + BookmarkStart.b("̨ପ", num);
                }
                else
                {
                    this.textWriter_0.Write(BookmarkStart.b("̨ପ", num));
                }
            }
            else if (listFormatForApplyStyle.CurrentListStyle.ListType != ListType.NoList)
            {
                if (listFormatForApplyStyle.IsRestartNumbering)
                {
                    this.method_22(listFormatForApplyStyle, true);
                }
                else if (listFormatForApplyStyle.ListLevelNumber == 0)
                {
                    this.method_22(listFormatForApplyStyle, false);
                }
                if (this.bool_0)
                {
                    this.string_0 = this.string_0 + (A_0 as Paragraph).ListText + BookmarkStart.b("नପ", num);
                }
                else
                {
                    this.textWriter_0.Write((A_0 as Paragraph).ListText + BookmarkStart.b("नପ", num));
                }
            }
        }
    }

    protected void method_16()
    {
        int num = 0x12;
        if (this.bool_0)
        {
            this.string_0 = this.string_0 + BookmarkStart.b("㔷〹", num);
        }
        else
        {
            this.textWriter_0.WriteLine("");
        }
    }

    private void method_17()
    {
        if (this.document_0.LastSection.HeadersFooters.Footer.ChildObjects.Count > 0)
        {
            this.paragraph_0 = this.document_0.LastSection.HeadersFooters.Footer.LastParagraph as Paragraph;
        }
        else
        {
            this.paragraph_0 = this.document_0.LastParagraph;
        }
    }

    private void method_18()
    {
        Section section = null;
        int num = this.document_0.Sections.Count - 1;
        bool flag = false;
        this.method_17();
        for (int i = 0; i <= num; i++)
        {
            section = this.document_0.Sections[i];
            flag = i == num;
            this.method_7(this.method_20(section, this.int_0));
            this.method_7(section.Body);
            this.method_12(section, flag);
            this.method_7(this.method_19(section, this.int_0 - 1));
        }
    }

    private IBody method_19(Section A_0, int A_1)
    {
        HeaderFooterType type = A_0.PageSetup.DifferentFirstPageHeaderFooter ? HeaderFooterType.FooterFirstPage : HeaderFooterType.FooterOdd;
        if (A_0.HeadersFooters[type].LinkToPrevious && (A_1 > 0))
        {
            int num = A_1 - 1;
            while (num >= 0)
            {
                Section section = this.document_0.Sections[num];
                HeaderFooter footer = section.HeadersFooters[type];
                if ((type == footer.Type) && footer.LinkToPrevious)
                {
                    num--;
                }
                else if ((type == footer.Type) && !footer.LinkToPrevious)
                {
                    A_0.HeadersFooters[type] = section.HeadersFooters[type];
                    break;
                }
            }
        }
        if (A_0.PageSetup.DifferentFirstPageHeaderFooter)
        {
            return A_0.HeadersFooters.FirstPageFooter;
        }
        return A_0.HeadersFooters.Footer;
    }

    public void method_2(TextWriter A_0, IDocument A_1)
    {
        this.textWriter_0 = A_0;
        this.document_0 = A_1 as Document;
        this.method_18();
    }

    private IBody method_20(Section A_0, int A_1)
    {
        HeaderFooterType type = A_0.PageSetup.DifferentFirstPageHeaderFooter ? HeaderFooterType.HeaderFirstPage : HeaderFooterType.HeaderOdd;
        if (A_0.HeadersFooters[type].LinkToPrevious && (A_1 > 0))
        {
            int num = A_1 - 1;
            while (num >= 0)
            {
                Section section = this.document_0.Sections[num];
                HeaderFooter footer = section.HeadersFooters[type];
                if ((type == footer.Type) && footer.LinkToPrevious)
                {
                    num--;
                }
                else if ((type == footer.Type) && !footer.LinkToPrevious)
                {
                    A_0.HeadersFooters[type] = section.HeadersFooters[type];
                    break;
                }
            }
        }
        if (A_0.PageSetup.DifferentFirstPageHeaderFooter)
        {
            return A_0.HeadersFooters.FirstPageHeader;
        }
        return A_0.HeadersFooters.Header;
    }

    private int method_21(ListFormat A_0)
    {
        HybridDictionary dictionary = this.method_0()[A_0.CustomStyleName] as HybridDictionary;
        if (dictionary == null)
        {
            HybridDictionary dictionary2 = new HybridDictionary();
            this.method_0().Add(A_0.CustomStyleName, dictionary2);
            ListLevel level = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
            dictionary2.Add(A_0.ListLevelNumber, level.StartAt + 1);
            return (level.StartAt - 1);
        }
        if (dictionary[A_0.ListLevelNumber] != null)
        {
            int num = (int) dictionary[A_0.ListLevelNumber];
            dictionary[A_0.ListLevelNumber] = num + 1;
            return (num - 1);
        }
        ListLevel level2 = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
        dictionary.Add(A_0.ListLevelNumber, level2.StartAt + 1);
        return (level2.StartAt - 1);
    }

    private void method_22(ListFormat A_0, bool A_1)
    {
        if (this.hybridDictionary_0 != null)
        {
            HybridDictionary dictionary = this.method_0()[A_0.CustomStyleName] as HybridDictionary;
            if (dictionary != null)
            {
                ICollection keys = dictionary.Keys;
                IEnumerator enumerator = keys.GetEnumerator();
                int count = keys.Count;
                int[] numArray = new int[count];
                for (int i = 0; enumerator.MoveNext(); i++)
                {
                    numArray[i] = (int) enumerator.Current;
                }
                for (int j = 0; j < count; j++)
                {
                    if (A_1 || ((numArray[j] != 0) && !A_0.CurrentListStyle.Levels[numArray[j]].NoRestartByHigher))
                    {
                        dictionary[numArray[j]] = A_0.CurrentListStyle.Levels[numArray[j]].StartAt;
                    }
                }
            }
        }
    }

    public void method_3(StreamReader A_0, IDocument A_1)
    {
        int num = 12;
        string str = A_0.ReadToEnd();
        string[] strArray = str.Split(BookmarkStart.b("㠱", 12).ToCharArray());
        if (A_1.LastParagraph == null)
        {
            if (A_1.LastSection == null)
            {
                A_1.CreateMinialDocument();
            }
            else
            {
                A_1.LastSection.Body.AddParagraph();
            }
        }
        int index = 0;
        int length = strArray.Length;
        while (index < length)
        {
            string text = strArray[index];
            text = text.Trim(BookmarkStart.b("㼱", num).ToCharArray());
            if ((text != string.Empty) && (text != BookmarkStart.b("㼱", num)))
            {
                A_1.LastParagraph.AppendText(text);
                if (((index + 1) < length) && (strArray[index + 1] != string.Empty))
                {
                    A_1.LastSection.Body.AddParagraph();
                }
            }
            index++;
        }
        this.method_5(str, strArray, A_1);
    }

    public void method_4(TextReader A_0, IDocument A_1)
    {
        int num = 13;
        string str = A_0.ReadToEnd();
        string[] strArray = str.Split(BookmarkStart.b("㤲", 13).ToCharArray());
        if (A_1.LastParagraph == null)
        {
            if (A_1.LastSection == null)
            {
                A_1.CreateMinialDocument();
            }
            else
            {
                A_1.LastSection.Body.AddParagraph();
            }
        }
        int index = 0;
        int length = strArray.Length;
        while (index < length)
        {
            string text = strArray[index];
            text = text.Trim(BookmarkStart.b("㸲", num).ToCharArray());
            if ((text != string.Empty) && (text != BookmarkStart.b("㸲", num)))
            {
                A_1.LastParagraph.AppendText(text);
                if (((index + 1) < length) && (strArray[index + 1] != string.Empty))
                {
                    A_1.LastSection.Body.AddParagraph();
                }
            }
            index++;
        }
        this.method_5(str, strArray, A_1);
    }

    private void method_5(string A_0, string[] A_1, IDocument A_2)
    {
        int num = 14;
        int length = A_1.Length;
        int num3 = 0;
        foreach (string str in A_1)
        {
            if ((str != BookmarkStart.b("㤳", num)) && (str != string.Empty))
            {
                foreach (string str2 in str.Split(BookmarkStart.b("ᐳ", num).ToCharArray()))
                {
                    if (str2 != string.Empty)
                    {
                        num3++;
                    }
                }
            }
            else
            {
                length--;
            }
        }
        A_0 = A_0.Replace(BookmarkStart.b("ᐳ", num), string.Empty);
        A_0 = A_0.Replace(BookmarkStart.b("㸳", num), string.Empty);
        A_0 = A_0.Replace(BookmarkStart.b("㤳", num), string.Empty);
        A_2.BuiltinDocumentProperties.ParagraphCount = length;
        A_2.BuiltinDocumentProperties.WordCount = num3;
        A_2.BuiltinDocumentProperties.CharCount = A_0.Length;
    }

    protected void method_6(Document A_0)
    {
    }

    protected void method_7(IBody A_0)
    {
        int num = A_0.ChildObjects.Count - 1;
        BodyRegion region = null;
        for (int i = 0; i <= num; i++)
        {
            region = A_0.ChildObjects[i] as BodyRegion;
            DocumentObjectType documentObjectType = region.DocumentObjectType;
            switch (documentObjectType)
            {
                case DocumentObjectType.Paragraph:
                {
                    bool flag = (region as Paragraph) == this.paragraph_0;
                    this.method_8(region as IParagraph, flag);
                    break;
                }
                case DocumentObjectType.StructureDocumentTag:
                    this.method_7((region as StructureDocumentTag).SDTContent);
                    break;

                default:
                    if (documentObjectType == DocumentObjectType.Table)
                    {
                        this.method_11(region as ITable);
                    }
                    break;
            }
        }
    }

    protected void method_8(IParagraph A_0, bool A_1)
    {
        this.method_15(A_0);
        this.method_9(A_0.Items);
        if (!A_1)
        {
            this.method_16();
        }
    }

    protected void method_9(ParagraphItemCollection A_0)
    {
        int num = 0;
        int count = A_0.Count;
        while (num < count)
        {
            this.method_10(A_0[num]);
            num++;
        }
    }
}

