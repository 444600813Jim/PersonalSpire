namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using System;

    public interface IBody : ICompositeObject
    {
        Paragraph AddParagraph();
        Table AddTable();
        void EnsureMinimum();
        void InsertXHTML(string html);
        void InsertXHTML(string html, int paragraphIndex);
        void InsertXHTML(string html, int paragraphIndex, int paragraphItemIndex);

        FormFieldCollection FormFields { get; }

        IParagraph LastParagraph { get; }

        ParagraphCollection Paragraphs { get; }

        TableCollection Tables { get; }
    }
}

