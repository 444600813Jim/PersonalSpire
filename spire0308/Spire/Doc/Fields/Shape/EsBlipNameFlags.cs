namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum EsBlipNameFlags
    {
        Comment = 0,
        DoNotSave = 4,
        File = 1,
        LinkToFile = 8,
        TypeMask = 3,
        URL = 2
    }
}

