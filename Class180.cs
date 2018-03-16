using Spire.Doc.Collections;
using Spire.Doc.Documents;
using System;
using System.Reflection;

[DefaultMember("Item")]
internal class Class180 : DocumentSubsetCollection
{
    public Class180(CellCollection A_0) : base(A_0, DocumentObjectType.StructureDocumentTagRow)
    {
    }

    public StructureDocumentTagRow method_13(int A_0)
    {
        return (StructureDocumentTagRow) base.GetByIndex(A_0);
    }

    public bool method_14(StructureDocumentTagRow A_0)
    {
        return base.method_3(A_0);
    }

    public int method_15(StructureDocumentTagRow A_0)
    {
        return base.method_4(A_0);
    }
}

