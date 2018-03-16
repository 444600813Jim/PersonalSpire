namespace Spire.Doc.Interface
{
    using System;

    public interface IMergeField : IField
    {
        string FieldName { get; set; }

        string TextAfter { get; set; }

        string TextBefore { get; set; }
    }
}

