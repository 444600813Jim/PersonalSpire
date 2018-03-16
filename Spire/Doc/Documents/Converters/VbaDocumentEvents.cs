namespace Spire.Doc.Documents.Converters
{
    using System;

    [Flags]
    internal enum VbaDocumentEvents
    {
        BuildingBlockAfterInsert = 0x4000,
        Close = 4,
        ContentControlAfterInsert = 0x100,
        ContentControlBeforeDelete = 0x200,
        ContentControlContentUpdate = 0x2000,
        ContentControlOnEnter = 0x800,
        ContentControlOnExit = 0x400,
        New = 1,
        Open = 2,
        StoreUpdate = 0x1000,
        Sync = 8,
        XmlAfterInsert = 0x10,
        XmlBeforeDelete = 0x20
    }
}

