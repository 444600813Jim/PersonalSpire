namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using System;

    public interface ISection : ICompositeObject
    {
        Column AddColumn(float width, float spacing);
        Paragraph AddParagraph();
        Table AddTable();
        Section Clone();
        void MakeColumnsSameWidth();

        Spire.Doc.Body Body { get; }

        SectionBreakType BreakCode { get; set; }

        ColumnCollection Columns { get; }

        Spire.Doc.HeadersFooters HeadersFooters { get; }

        Spire.Doc.PageSetup PageSetup { get; }

        ParagraphCollection Paragraphs { get; }

        bool ProtectForm { get; set; }

        TableCollection Tables { get; }
    }
}

