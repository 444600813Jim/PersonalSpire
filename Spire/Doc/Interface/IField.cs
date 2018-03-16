namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using System;

    public interface IField : ITextRange
    {
        FieldType Type { get; set; }
    }
}

