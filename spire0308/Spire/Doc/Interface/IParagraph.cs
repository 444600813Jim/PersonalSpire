namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Formatting;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Reflection;

    public interface IParagraph : ICompositeObject, IBodyRegion, IStyleHolder
    {
        BookmarkEnd AppendBookmarkEnd(string name);
        BookmarkStart AppendBookmarkStart(string name);
        Break AppendBreak(BreakType breakType);
        CheckBoxFormField AppendCheckBox();
        CheckBoxFormField AppendCheckBox(string checkBoxName, bool defaultCheckBoxValue);
        Comment AppendComment(string text);
        DropDownFormField AppendDropDownFormField();
        DropDownFormField AppendDropDownFormField(string dropDropDownName);
        Field AppendField(string fieldName, FieldType fieldType);
        Footnote AppendFootnote(FootnoteType type);
        void AppendHTML(string html);
        Field AppendHyperlink(string link, DocPicture picture, HyperlinkType type);
        Field AppendHyperlink(string link, string text, HyperlinkType type);
        DocOleObject AppendOleObject(string pathToFile, DocPicture olePicture);
        DocOleObject AppendOleObject(Stream stream, DocPicture pic, OleLinkType oleLinkType);
        DocOleObject AppendOleObject(byte[] oleBytes, DocPicture olePicture, OleLinkType oleLinkType);
        DocOleObject AppendOleObject(Stream oleStream, DocPicture olePicture, OleObjectType type);
        DocOleObject AppendOleObject(byte[] oleBytes, DocPicture olePicture, OleObjectType type);
        DocOleObject AppendOleObject(string pathToFile, DocPicture olePicture, OleObjectType type);
        DocOleObject AppendOleObject(byte[] oleBytes, DocPicture olePicture, string fileExtension);
        DocOleObject AppendOleObject(Stream oleStream, DocPicture olePicture, string fileExtension);
        DocPicture AppendPicture(Image image);
        DocPicture AppendPicture(byte[] imageBytes);
        Symbol AppendSymbol(byte characterCode);
        TextRange AppendText(string text);
        TextBox AppendTextBox(float width, float height);
        TextFormField AppendTextFormField(string defaultText);
        TextFormField AppendTextFormField(string formFieldName, string defaultText);
        TableOfContent AppendTOC(int lowerHeadingLevel, int upperHeadingLevel);
        ParagraphStyle GetStyle();
        void RemoveAbsPosition();
        int Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord);

        CharacterFormat BreakCharacterFormat { get; }

        ParagraphFormat Format { get; }

        bool IsEndOfDocument { get; }

        bool IsEndOfSection { get; }

        bool IsInCell { get; }

        ParagraphBase this[int index] { get; }

        ParagraphItemCollection Items { get; }

        Spire.Doc.Formatting.ListFormat ListFormat { get; }

        string Text { get; set; }
    }
}

