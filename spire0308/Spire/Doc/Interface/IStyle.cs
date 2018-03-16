namespace Spire.Doc.Interface
{
    using Spire.Doc.Documents;
    using System;

    public interface IStyle
    {
        IStyle Clone();

        string Name { get; set; }

        string StyleId { get; }

        Spire.Doc.Documents.StyleType StyleType { get; }
    }
}

