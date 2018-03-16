namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using Spire.Doc.Reporting;
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Web;

    public interface IDocument : ICompositeObject
    {
        ListStyle AddListStyle(ListType listType, string styleName);
        ParagraphStyle AddParagraphStyle(string styleName);
        Section AddSection();
        Style AddStyle(BuiltinStyle builtinStyle);
        Document Clone();
        void CreateMinialDocument();
        Paragraph CreateParagraph();
        void Encrypt(string password);
        TextSelection[] FindAllPattern(Regex pattern);
        TextSelection[] FindAllString(string given, bool caseSensitive, bool wholeWord);
        TextSelection FindPattern(Regex pattern);
        TextSelection FindPattern(BodyRegion startBodyItem, Regex pattern);
        TextSelection[] FindPatternInLine(Regex pattern);
        TextSelection[] FindPatternInLine(BodyRegion startBodyItem, Regex pattern);
        TextSelection FindString(string given, bool caseSensitive, bool wholeWord);
        TextSelection FindString(BodyRegion startTextBodyItem, string given, bool caseSensitive, bool wholeWord);
        TextSelection[] FindStringInLine(string given, bool caseSensitive, bool wholeWord);
        TextSelection[] FindStringInLine(BodyRegion startTextBodyItem, string given, bool caseSensitive, bool wholeWord);
        string GetText();
        void ImportContent(IDocument doc);
        void ImportContent(IDocument doc, bool importStyles);
        void LoadFromFile(string fileName);
        void LoadFromFile(string fileName, FileFormat fileFormat);
        void LoadFromFileInReadMode(string strFileName, FileFormat fileFormat);
        void LoadFromStream(Stream stream, FileFormat fileFormat);
        void Protect(Spire.Doc.ProtectionType type);
        void Protect(Spire.Doc.ProtectionType type, string password);
        void RemoveEncryption();
        int Replace(Regex pattern, TextSelection textSelection);
        int Replace(Regex pattern, string replace);
        int Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord);
        int Replace(string given, string replace, bool caseSensitive, bool wholeWord);
        int ReplaceInLine(Regex pattern, TextSelection replacement);
        int ReplaceInLine(Regex pattern, string replace);
        int ReplaceInLine(string given, TextSelection replacement, bool caseSensitive, bool wholeWord);
        int ReplaceInLine(string given, string replace, bool caseSensitive, bool wholeWord);
        void ResetFindState();
        void SaveToFile(string fileName);
        void SaveToFile(Stream stream, FileFormat fileFormat);
        void SaveToFile(string fileName, FileFormat fileFormat);
        void SaveToFile(string fileName, FileFormat fileFormat, HttpResponse response, HttpContentType contentDisposotion);
        Image[] SaveToImages(ImageType type);
        Image SaveToImages(int pageIndex, ImageType type);
        Stream SaveToImages(int pageIndex, ImageFormat imageFormat);
        Image[] SaveToImages(int pageIndex, int noOfPages, ImageType type);
        void UpdateWordCount();

        Spire.Doc.Background Background { get; }

        BookmarkCollection Bookmarks { get; }

        Spire.Doc.BuiltinDocumentProperties BuiltinDocumentProperties { get; }

        CommentsCollection Comments { get; }

        Spire.Doc.CustomDocumentProperties CustomDocumentProperties { get; }

        bool HasChanges { get; }

        bool IsUpdateFields { get; set; }

        Paragraph LastParagraph { get; }

        Section LastSection { get; }

        ListStyleCollection ListStyles { get; }

        Spire.Doc.Reporting.MailMerge MailMerge { get; }

        DocumentProperties Properties { get; }

        Spire.Doc.ProtectionType ProtectionType { get; set; }

        SectionCollection Sections { get; }

        StyleCollection Styles { get; }

        TextBoxCollection TextBoxes { get; }

        TableOfContent TOC { get; set; }

        VariableCollection Variables { get; }

        Spire.Doc.Formatting.ViewSetup ViewSetup { get; }

        WatermarkBase Watermark { get; set; }
    }
}

