using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Rendering;
using Spire.Pdf;
using Spire.Pdf.Actions;
using Spire.Pdf.Annotations;
using Spire.Pdf.Bookmarks;
using Spire.Pdf.General;
using Spire.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;

[ToolboxItem(false)]
internal class Class866 : Component
{
    private bool bool_0;
    private Class195 class195_0;
    private Dictionary<string, sprἰ> dictionary_0;
    private const ImageType imageType_0 = ImageType.Metafile;
    private int int_0 = 80;
    private List<PageSetup> list_0 = new List<PageSetup>();
    private PdfNewDocument pdfNewDocument_0;
    private PdfPageBase pdfPageBase_0;
    private ToPdfParameterList toPdfParameterList_0;

    private List<PageSetup> method_0()
    {
        return this.list_0;
    }

    private ToPdfParameterList method_1()
    {
        int num = 10;
        if (this.toPdfParameterList_0 == null)
        {
            this.toPdfParameterList_0 = new ToPdfParameterList();
            this.toPdfParameterList_0.EmbeddedFontNameList.Add(BookmarkStart.b("焯䀱崳圵吷ᨹ爻弽㈿ぁ⭃ㅅ", num));
        }
        if (this.toPdfParameterList_0.WordBookmarksTitle == null)
        {
            this.toPdfParameterList_0.WordBookmarksTitle = string.Empty;
        }
        return this.toPdfParameterList_0;
    }

    internal PdfNewDocument method_10(List<Image> A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int count = A_0.Count;
        int num2 = (count > 90) ? 3 : ((count > 60) ? 5 : ((count > 30) ? 10 : count));
        this.pdfNewDocument_0 = this.method_12();
        for (int i = 0; i < count; i++)
        {
            using (Image image = A_0[i])
            {
                PdfNewPage page = this.method_14(new SizeF(image.Width * 0.75f, image.Height * 0.75f)).get_Pages().Add();
                this.pdfPageBase_0 = page;
                using (PdfMetafile metafile = PdfImage.FromImage(image))
                {
                    metafile.set_Quality((long) this.int_0);
                    metafile.ᜀ(page, new RectangleF(PointF.Empty, page.get_Size()), true, this.method_1().EmbeddedFontNameList, this.method_1().IsEmbeddedAllFonts);
                    metafile.Dispose();
                }
                image.Dispose();
            }
            if ((i % num2) == 0)
            {
                GC.Collect();
            }
        }
        return this.pdfNewDocument_0;
    }

    internal void method_11(Document A_0, Stream A_1, ToPdfParameterList A_2)
    {
        this.toPdfParameterList_0 = A_2;
        this.toPdfParameterList_0.EmbeddedFontNameList.Add(BookmarkStart.b("申䐵儷嬹倻ḽ฿⍁㙃㑅❇㵉", 14));
        using (Class195 class2 = new Class195())
        {
            A_0.OperationType = DocumentOperationType.Layout;
            class2.method_2(this.method_1().UsePSCoversion);
            class2.method_20(this.method_1());
            class2.method_6(true);
            class2.method_43(A_0);
            A_0.OperationType = DocumentOperationType.None;
            this.class195_0 = class2;
            this.method_29(class2, A_1);
            this.class195_0 = null;
        }
    }

    private PdfNewDocument method_12()
    {
        PdfNewDocument document = new PdfNewDocument();
        document.ᜋ();
        if (this.method_1().PdfConformanceLevel != null)
        {
            document = new PdfNewDocument(this.method_1().PdfConformanceLevel);
            document.ᜁ(false);
        }
        else
        {
            document.get_FileStructure().set_CrossReferenceType(1);
            document.get_FileStructure().set_Version(5);
            document.ᜀ(this.method_1().PdfSecurity);
        }
        document.get_PageSettings().get_Margins().set_All(0f);
        return document;
    }

    private PdfSection method_13(PageSetup A_0)
    {
        int num = 7;
        PdfSection section = this.pdfNewDocument_0.get_Sections().Add();
        section.get_PageSettings().get_Margins().set_All(0f);
        section.get_PageSettings().set_Orientation((((A_0.Orientation == PageOrientation.Portrait) && (A_0.PageSize.Width <= A_0.PageSize.Height)) || (A_0.Orientation.ToString() == BookmarkStart.b("ᰬ", num))) ? ((PdfPageOrientation) 0) : ((PdfPageOrientation) 1));
        section.get_PageSettings().set_Size(A_0.PageSize);
        return section;
    }

    private PdfSection method_14(SizeF A_0)
    {
        PdfSection section = this.pdfNewDocument_0.get_Sections().Add();
        section.get_PageSettings().get_Margins().set_All(0f);
        section.get_PageSettings().set_Size(A_0);
        return section;
    }

    private void method_15(Class195 A_0)
    {
        for (int i = 0; i < A_0.method_0().Count; i++)
        {
            Class500 class2 = A_0.method_0()[i];
            this.method_0().Add(class2.method_28());
        }
    }

    private void method_16(BuiltinDocumentProperties A_0)
    {
        this.pdfNewDocument_0.get_DocumentInformation().set_Author(string.IsNullOrEmpty(A_0.Author) ? string.Empty : A_0.Author);
        this.pdfNewDocument_0.get_DocumentInformation().set_CreationDate(A_0.CreateDate);
        this.pdfNewDocument_0.get_DocumentInformation().set_Creator(string.IsNullOrEmpty(A_0.Company) ? string.Empty : A_0.Company);
        this.pdfNewDocument_0.get_DocumentInformation().set_Keywords(string.IsNullOrEmpty(A_0.Keywords) ? string.Empty : A_0.Keywords);
        this.pdfNewDocument_0.get_DocumentInformation().set_Producer(string.IsNullOrEmpty(A_0.Company) ? string.Empty : A_0.Company);
        this.pdfNewDocument_0.get_DocumentInformation().set_Subject(string.IsNullOrEmpty(A_0.Subject) ? string.Empty : A_0.Subject);
        this.pdfNewDocument_0.get_DocumentInformation().set_Title(string.IsNullOrEmpty(A_0.Title) ? string.Empty : A_0.Title);
    }

    private void method_17(BuiltinDocumentProperties A_0, sprḷ A_1)
    {
        A_1.ᜅ(A_0.Author);
        A_1.ᜃ(A_0.Keywords);
        A_1.ᜄ(A_0.Company);
        A_1.ᜁ(A_0.Subject);
        A_1.ᜀ(A_0.Title);
    }

    private void method_18(List<Dictionary<string, RectangleF>> A_0)
    {
        if (!this.method_1().DisableLink)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                foreach (KeyValuePair<string, RectangleF> pair in A_0[i])
                {
                    RectangleF ef = pair.Value;
                    string key = pair.Key;
                    if (!key.Equals(string.Empty))
                    {
                        PdfUriAnnotation annotation = new PdfUriAnnotation(ef);
                        annotation.set_Uri(key);
                        annotation.get_Border().set_Width(0f);
                        if (this.pdfPageBase_0 is PdfNewPage)
                        {
                            (this.pdfPageBase_0 as PdfNewPage).get_Annotations().Add(annotation);
                        }
                        else
                        {
                            (this.pdfPageBase_0 as PdfPageWidget).get_AnnotationsWidget().Add(annotation);
                        }
                    }
                }
            }
        }
    }

    private void method_19(List<Dictionary<string, RectangleF>> A_0, sprᣍ A_1)
    {
        if (((A_0 != null) && (A_1 != null)) && !this.method_1().DisableLink)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                foreach (KeyValuePair<string, RectangleF> pair in A_0[i])
                {
                    RectangleF ef = pair.Value;
                    string key = pair.Key;
                    if (!string.IsNullOrEmpty(key))
                    {
                        spr⠱ r⠱ = new spr⠱(ef, key);
                        A_1.ᜀ(r⠱);
                    }
                }
            }
        }
    }

    private Dictionary<string, sprἰ> method_2()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = this.method_31(this.method_1().PrivateFontList);
        }
        return this.dictionary_0;
    }

    private void method_20(List<Dictionary<string, Class310>> A_0, Dictionary<string, PdfBookmark> A_1, bool A_2)
    {
        for (int i = 0; i < A_0.Count; i++)
        {
            foreach (KeyValuePair<string, Class310> pair in A_0[i])
            {
                Class310 class2 = pair.Value;
                if (class2.method_16() == A_2)
                {
                    int index = this.pdfNewDocument_0.get_Pages().IndexOf(this.pdfPageBase_0);
                    if (class2.method_6() == (index + 1))
                    {
                        if (pair.Value.method_12() == 1)
                        {
                            A_1.Clear();
                        }
                        if (!pair.Key.Equals(string.Empty))
                        {
                            float height = this.method_0()[index].PageSize.Height;
                            PdfDocumentLinkAnnotation annotation = new PdfDocumentLinkAnnotation(class2.method_0());
                            annotation.set_Border(new PdfAnnotationBorder(0f));
                            if ((this.pdfNewDocument_0.get_Pages().get_Count() >= class2.method_4()) && (class2.method_4() != 0))
                            {
                                PdfDestination destination = new PdfDestination(this.pdfNewDocument_0.get_Pages().get_Item(class2.method_4() - 1), class2.method_2().Location);
                                string[] strArray = class2.method_8().Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                                if ((strArray.Length > 2) && (strArray[1] == strArray[2]))
                                {
                                    PdfBookmark bookmark = this.pdfNewDocument_0.get_Bookmarks().Add(class2.method_10());
                                    bookmark.set_Color((PdfRGBColor) Color.SaddleBrown);
                                    bookmark.set_DisplayStyle(2);
                                    annotation.set_Destination(destination);
                                    bookmark.set_Action(new PdfGoToAction(annotation.get_Destination()));
                                }
                                else if (pair.Value.method_12() == 0)
                                {
                                    annotation.set_Destination(destination);
                                }
                                else if (pair.Value.method_12() == 1)
                                {
                                    PdfBookmark bookmark3 = this.pdfNewDocument_0.get_Bookmarks().Add(class2.method_10());
                                    bookmark3.set_Color((PdfRGBColor) Color.SaddleBrown);
                                    bookmark3.set_DisplayStyle(2);
                                    annotation.set_Destination(destination);
                                    bookmark3.set_Action(new PdfGoToAction(annotation.get_Destination()));
                                    A_1.Add(pair.Value.method_12().ToString(), bookmark3);
                                }
                                else
                                {
                                    PdfBookmark bookmark4 = null;
                                    A_1.TryGetValue((pair.Value.method_12() - 1).ToString(), out bookmark4);
                                    if (bookmark4 != null)
                                    {
                                        PdfBookmark bookmark2 = bookmark4.Add(class2.method_10());
                                        bookmark2.set_Color((PdfRGBColor) Color.SaddleBrown);
                                        bookmark2.set_DisplayStyle(2);
                                        annotation.set_Destination(destination);
                                        bookmark2.set_Action(new PdfGoToAction(annotation.get_Destination()));
                                        if (A_1.ContainsKey(pair.Value.method_12().ToString()))
                                        {
                                            A_1.Remove(pair.Value.method_12().ToString());
                                        }
                                        A_1.Add(pair.Value.method_12().ToString(), bookmark2);
                                    }
                                }
                            }
                            if (this.pdfPageBase_0 is PdfNewPage)
                            {
                                (this.pdfPageBase_0 as PdfNewPage).get_Annotations().Add(annotation);
                            }
                            else
                            {
                                (this.pdfPageBase_0 as PdfPageWidget).get_AnnotationsWidget().Add(annotation);
                            }
                        }
                    }
                }
            }
        }
    }

    private void method_21(List<Dictionary<string, Class310>> A_0, sprᣍ A_1, int A_2, int A_3, bool A_4)
    {
        if ((A_0 != null) && (A_0.Count > 0))
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                foreach (KeyValuePair<string, Class310> pair in A_0[i])
                {
                    Class310 class2 = pair.Value;
                    if (class2.method_16() == A_4)
                    {
                        if ((class2.method_6() == (A_3 + 1)) && !string.IsNullOrEmpty(pair.Key))
                        {
                            A_1.ᜀ(class2.method_8(), class2.method_0(), class2.method_4() - 1, class2.method_2());
                        }
                        if ((A_4 && (A_2 >= class2.method_4())) && ((class2.method_4() != 0) && ((A_3 + 1) == class2.method_4())))
                        {
                            sprᢧ rᢧ = new sprᢧ(class2.method_2().Location, class2.method_12(), class2.method_10());
                            rᢧ.ᜀ(new sprⓚ(Color.SaddleBrown.ToArgb()));
                            rᢧ.ᜀ(FontStyle.Bold);
                            A_1.ᜀ(rᢧ, A_3);
                        }
                    }
                }
            }
        }
    }

    private void method_22(List<BookmarkLevel> A_0, PdfBookmark A_1)
    {
        if (A_0.Count > 0)
        {
            if (A_1 == null)
            {
                A_1 = this.pdfNewDocument_0.get_Bookmarks().Add(this.method_1().WordBookmarksTitle);
                A_1.set_Color((PdfRGBColor) this.method_1().WordBookmarksColor);
                A_1.set_DisplayStyle(this.method_24(this.method_1().WordBookmarksTextStyle));
            }
            for (int i = 0; i < A_0.Count; i++)
            {
                BookmarkLevel level = A_0[i];
                if ((this.pdfNewDocument_0.get_Pages().get_Count() >= level.TargetPageNumber) && (level.TargetPageNumber != 0))
                {
                    PdfPageBase base2 = this.pdfNewDocument_0.get_Pages().get_Item(level.TargetPageNumber - 1);
                    RectangleF ef = new RectangleF();
                    PdfDocumentLinkAnnotation annotation = new PdfDocumentLinkAnnotation(ef);
                    PdfBookmark bookmark = null;
                    annotation.set_Border(new PdfAnnotationBorder(0f));
                    PdfDestination destination = new PdfDestination(base2, level.TargetBounds.Location);
                    bookmark = A_1.Add(level.Name);
                    bookmark.set_Color((!(level.Color == Color.SaddleBrown) || !(this.method_1().WordBookmarksColor != Color.SaddleBrown)) ? ((PdfRGBColor) level.Color) : ((PdfRGBColor) this.method_1().WordBookmarksColor));
                    bookmark.set_DisplayStyle(((level.Style != BookmarkTextStyle.Bold) || (this.method_1().WordBookmarksTextStyle == BookmarkTextStyle.Bold)) ? this.method_24(level.Style) : this.method_24(this.method_1().WordBookmarksTextStyle));
                    annotation.set_Destination(destination);
                    bookmark.set_Action(new PdfGoToAction(annotation.get_Destination()));
                    if (base2 is PdfNewPage)
                    {
                        (base2 as PdfNewPage).get_Annotations().Add(annotation);
                    }
                    else
                    {
                        (base2 as PdfPageWidget).get_AnnotationsWidget().Add(annotation);
                    }
                    if ((level.ChildObjects.Count > 0) && (bookmark != null))
                    {
                        this.method_22(level.ChildObjects, bookmark);
                    }
                }
            }
        }
    }

    private void method_23(List<BookmarkLevel> A_0, sprᣍ A_1, int A_2, int A_3)
    {
        if ((A_0 != null) && (A_0.Count > 0))
        {
            if (!this.bool_0)
            {
                this.bool_0 = true;
                sprᢧ rᢧ = new sprᢧ(new PointF(0f, 0f), 0, this.method_1().WordBookmarksTitle);
                rᢧ.ᜀ(true);
                rᢧ.ᜀ(new sprⓚ(this.method_1().WordBookmarksColor.ToArgb()));
                rᢧ.ᜀ(this.method_25(this.method_1().WordBookmarksTextStyle));
                A_1.ᜀ(rᢧ, A_3);
            }
            for (int i = 0; i < A_0.Count; i++)
            {
                BookmarkLevel level = A_0[i];
                if ((A_2 >= level.TargetPageNumber) && (level.TargetPageNumber != 0))
                {
                    if ((A_3 + 1) == level.TargetPageNumber)
                    {
                        sprᢧ rᢧ2 = new sprᢧ(level.TargetBounds.Location, level.Level, level.Name);
                        Color color2 = (!(level.Color == Color.SaddleBrown) || !(this.method_1().WordBookmarksColor != Color.SaddleBrown)) ? level.Color : this.method_1().WordBookmarksColor;
                        rᢧ2.ᜀ(new sprⓚ(color2.ToArgb()));
                        rᢧ2.ᜀ(((level.Style != BookmarkTextStyle.Bold) || (this.method_1().WordBookmarksTextStyle == BookmarkTextStyle.Bold)) ? this.method_25(level.Style) : this.method_25(this.method_1().WordBookmarksTextStyle));
                        A_1.ᜀ(rᢧ2, A_3);
                    }
                    if (level.ChildObjects.Count > 0)
                    {
                        this.method_23(level.ChildObjects, A_1, A_2, A_3);
                    }
                }
            }
        }
    }

    private PdfTextStyle method_24(BookmarkTextStyle A_0)
    {
        switch (A_0)
        {
            case BookmarkTextStyle.Italic:
                return 1;

            case BookmarkTextStyle.Bold:
                return 2;

            case (BookmarkTextStyle.Bold | BookmarkTextStyle.Italic):
                return 3;
        }
        return 0;
    }

    private FontStyle method_25(BookmarkTextStyle A_0)
    {
        switch (A_0)
        {
            case BookmarkTextStyle.Italic:
                return FontStyle.Italic;

            case BookmarkTextStyle.Bold:
                return FontStyle.Bold;

            case (BookmarkTextStyle.Bold | BookmarkTextStyle.Italic):
                return (FontStyle.Italic | FontStyle.Bold);
        }
        return FontStyle.Regular;
    }

    private PdfNewDocument method_26(Class195 A_0)
    {
        this.method_15(A_0);
        int count = A_0.method_0().Count;
        int num3 = (count > 90) ? 3 : ((count > 60) ? 5 : ((count > 30) ? 10 : count));
        this.pdfNewDocument_0 = this.method_12();
        for (int i = 0; i < count; i++)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                A_0.method_57(i, 1, ImageType.Metafile, stream, false, false, true);
                PdfNewPage page = this.method_13(this.method_0()[i]).get_Pages().Add();
                this.pdfPageBase_0 = page;
                using (PdfMetafile metafile = PdfImage.FromImage(A_0.method_34().method_0()[i].method_0()))
                {
                    metafile.set_Quality((long) this.int_0);
                    metafile.ᜀ(page, new RectangleF(PointF.Empty, page.get_Size()), true, this.method_1().EmbeddedFontNameList, this.method_1().IsEmbeddedAllFonts, this.method_2());
                }
                this.method_18(A_0.method_34().method_0()[i].method_2());
                A_0.method_34().method_0()[i].method_0().Dispose();
                A_0.method_34().method_0()[i].method_1(null);
            }
            if ((i % num3) == 0)
            {
                GC.Collect();
            }
        }
        this.method_27(A_0, count, false);
        if (!this.method_1().CreateWordBookmarks)
        {
            this.method_27(A_0, count, true);
        }
        else if (A_0.method_11().Count > 0)
        {
            PdfBookmark bookmark = this.pdfNewDocument_0.get_Bookmarks().Add(this.method_1().WordBookmarksTitle);
            bookmark.set_Color((PdfRGBColor) this.method_1().WordBookmarksColor);
            bookmark.set_DisplayStyle(this.method_24(this.method_1().WordBookmarksTextStyle));
            this.method_22(A_0.method_11(), bookmark);
        }
        this.method_16(A_0.method_35().BuiltinDocumentProperties);
        A_0.method_51();
        return this.pdfNewDocument_0;
    }

    private void method_27(Class195 A_0, int A_1, bool A_2)
    {
        if ((A_0 != null) && (A_0.method_9().Count > 0))
        {
            Dictionary<string, PdfBookmark> dictionary = new Dictionary<string, PdfBookmark>();
            for (int i = 0; i < A_1; i++)
            {
                this.pdfPageBase_0 = this.pdfNewDocument_0.get_Pages().get_Item(i);
                this.method_20(A_0.method_9(), dictionary, A_2);
            }
            dictionary = null;
        }
    }

    private void method_28(spr➎ A_0, spr│ A_1, Stream A_2)
    {
        spr╞ r╞ = new spr╞();
        spr│ r│ = new spr│();
        r│.ᜀ(A_1.ᜄ(), A_1.ᜀ());
        r│.ᜉ(A_1.ᜂ());
        r│.ᜇ(A_1.ᜆ());
        r╞.ᜀ(A_0, A_1, A_2);
    }

    private void method_29(Class195 A_0, Stream A_1)
    {
        sprḷ sprḷ = new sprḷ {
            ᜀ = new sprḷ.ᜀ(this, (IntPtr) this.method_28)
        };
        sprḷ.ᜂ(this.int_0);
        this.method_17(A_0.method_35().BuiltinDocumentProperties, sprḷ);
        spr᝸ r᝸ = new spr᝸(A_1, sprḷ);
        r᝸.ᜁ(new sprᡈ(this, (IntPtr) this.method_30));
        r᝸.ᜀ();
        this.method_15(A_0);
        int count = A_0.method_0().Count;
        int num4 = (count > 90) ? 3 : ((count > 60) ? 5 : ((count > 30) ? 10 : count));
        List<spr⠃> list = new List<spr⠃>();
        for (int i = 0; i < count; i++)
        {
            list.Add(A_0.method_63(i, 1)[i]);
        }
        for (int j = 0; j < list.Count; j++)
        {
            spr⠃ r⠃ = list[j];
            r᝸.ᜀ(r⠃);
            if ((j % num4) == 0)
            {
                GC.Collect();
            }
        }
        r᝸.ᜄ();
        A_1.Flush();
        A_0.method_51();
    }

    private Class195 method_3()
    {
        return this.class195_0;
    }

    private void method_30(object A_0, spr⌑ A_1)
    {
        if (this.method_3() != null)
        {
            Class195 class2 = this.method_3();
            sprᣍ rᣍ = A_1.ᜂ();
            A_1.ᜁ();
            int num = A_1.ᜀ();
            int count = class2.method_34().method_0().Count;
            this.method_19(class2.method_34().method_0()[num].method_2(), rᣍ);
            this.method_21(class2.method_9(), rᣍ, count, num, false);
            if (this.method_1().CreateWordBookmarks)
            {
                this.method_23(class2.method_11(), rᣍ, count, num);
            }
            else
            {
                this.method_21(class2.method_9(), rᣍ, count, num, true);
            }
        }
    }

    private Dictionary<string, sprἰ> method_31(Dictionary<string, Struct10> A_0)
    {
        int num = 8;
        Dictionary<string, sprἰ> dictionary = new Dictionary<string, sprἰ>();
        foreach (KeyValuePair<string, Struct10> pair in A_0)
        {
            string key = pair.Key;
            string str3 = key.Contains(BookmarkStart.b("ȭ", num)) ? key.Substring(key.IndexOf(BookmarkStart.b("ȭ", num))) : string.Empty;
            Struct10 struct2 = pair.Value;
            if (struct2.method_4().Families.Length > 0)
            {
                string str2 = struct2.method_4().Families[0].Name.ToLowerInvariant() + str3;
                if (!dictionary.ContainsKey(str2))
                {
                    sprἰ sprἰ = new sprἰ();
                    sprἰ.ᜀ(struct2.method_4());
                    sprἰ.ᜀ(struct2.method_2());
                    sprἰ.ᜀ(struct2.method_0());
                    dictionary.Add(str2, sprἰ);
                }
            }
        }
        return dictionary;
    }

    private void method_32(int A_0)
    {
        PdfNewPage page = this.method_13(this.method_0()[A_0]).get_Pages().Add();
        this.pdfPageBase_0 = page;
        PdfCanvas canvas = page.get_Canvas();
        canvas.DrawString(BookmarkStart.b("昴䜶倸䤺堼ἾՀⱂ♄楆", 15), new PdfFont(2, 16f, 1), PdfBrushes.get_Red(), new PointF(10f, 10f));
        canvas.DrawString(BookmarkStart.b("猴䔶尸帺ᴼ䤾⑀ㅂ㙄⹆♈╊浌ⱎ㹐㵒⍔㉖⭘⽚㑜ㅞ٠䍢ቤࡦ᭨ཪ䵬୮Ṱၲt᩶ᱸᕺॼ౾ꆀꞆ\ud988\ucf8a쮌꾎朗璉랚붜캠횢薤쒦좨얪趬삮\udfb0\udfb2체鞶\udeb8\udeba즼龾뗀ꯂꃄ꿈ꋊ뿌볎ꗐ꧘뫚뫜뫞쇠賢菤쟦맨꿪꯬쿮韰髲駴鋶ퟸ", 15), new PdfFont(2, 10f), PdfBrushes.get_Red(), new PointF(10f, 30f));
        canvas.DrawString(BookmarkStart.b("怴䜶常䤺尼嬾⑀捂ㅄ⡆楈ࡊ≌≎㱐㙒❔㑖じ㩚ㅜ罞①ݢ౤፦hѪͬ佮Ṱᕲ啴⑶ॸቺོ᩾꾀잂ꦈ랊ﮎ꾔뢖뚘辠욢袤캦쪨캪쾬쎮쒰횲鮴풶횸횺銼꿀럂럄꣆귈뻊껌꫎ﻐꓒ뫔ꗖ뷘믜냞鏠컢诤苦鷨웪蓬臮藰臲髴鏶賸飺飼퇾椀眂栄欆㜈┊", 15), new PdfFont(2, 10f), PdfBrushes.get_Red(), new PointF(10f, 42f));
    }

    internal void method_4(int A_0)
    {
        this.int_0 = A_0;
    }

    public PdfNewDocument method_5(Document A_0)
    {
        using (Class195 class2 = new Class195())
        {
            A_0.OperationType = DocumentOperationType.Layout;
            class2.method_20(this.method_1());
            class2.method_6(true);
            class2.method_43(A_0);
            A_0.OperationType = DocumentOperationType.None;
            return this.method_26(class2);
        }
    }

    public PdfNewDocument method_6(Document A_0, ToPdfParameterList A_1)
    {
        this.toPdfParameterList_0 = A_1;
        this.toPdfParameterList_0.EmbeddedFontNameList.Add(BookmarkStart.b("横弬䘮倰弲ᔴ礶堸䤺似倾㙀", 5));
        return this.method_5(A_0);
    }

    public PdfNewDocument method_7(Document A_0, List<string> A_1)
    {
        ToPdfParameterList list = new ToPdfParameterList {
            EmbeddedFontNameList = A_1
        };
        return this.method_6(A_0, list);
    }

    public PdfNewDocument method_8(string A_0)
    {
        Document document = new Document(A_0, FileFormat.Auto);
        return this.method_5(document);
    }

    public PdfNewDocument method_9(Stream A_0)
    {
        Document document = new Document(A_0, FileFormat.Auto);
        return this.method_5(document);
    }

    void Component.Dispose(bool A_0)
    {
        base.Dispose(A_0);
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        this.pdfNewDocument_0 = null;
        this.pdfPageBase_0 = null;
        this.toPdfParameterList_0 = null;
    }
}

