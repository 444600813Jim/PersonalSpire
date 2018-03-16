namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using System;
    using System.Drawing;

    public interface IPicture : IParagraphBase
    {
        IParagraph AddCaption(string name, CaptionNumberingFormat format, CaptionPosition captionPosition);
        void LoadImage(System.Drawing.Image imageStream);
        void LoadImage(byte[] imageBytes);

        string AlternativeText { get; set; }

        float Height { get; set; }

        float HeightScale { get; set; }

        ShapeHorizontalAlignment HorizontalAlignment { get; set; }

        Spire.Doc.Documents.HorizontalOrigin HorizontalOrigin { get; set; }

        float HorizontalPosition { get; set; }

        System.Drawing.Image Image { get; }

        byte[] ImageBytes { get; }

        bool IsUnderText { get; set; }

        Spire.Doc.Documents.TextWrappingStyle TextWrappingStyle { get; set; }

        Spire.Doc.Documents.TextWrappingType TextWrappingType { get; set; }

        string Title { get; set; }

        ShapeVerticalAlignment VerticalAlignment { get; set; }

        Spire.Doc.Documents.VerticalOrigin VerticalOrigin { get; set; }

        float VerticalPosition { get; set; }

        float Width { get; set; }

        float WidthScale { get; set; }
    }
}

