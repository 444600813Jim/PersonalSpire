using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;

internal class Class524
{
    private Class524()
    {
    }

    internal static DocumentObject[] smethod_0(DocumentBase A_0, CharacterFormat A_1)
    {
        return smethod_1(A_0, A_1, FieldType.FieldPage, BookmarkStart.b("眦栨氪栬", 1));
    }

    internal static DocumentObject[] smethod_1(DocumentBase A_0, CharacterFormat A_1, FieldType A_2, string A_3)
    {
        return new DocumentObject[] { new Field((IDocument) A_0, A_2, A_3), new FieldMark((IDocument) A_0, (CharacterFormat) A_1.Clone(), FieldMarkType.FieldSeparator), new TextRange((IDocument) A_0, BookmarkStart.b("瘭栯樱", 8), (CharacterFormat) A_1.Clone()), new FieldMark((IDocument) A_0, (CharacterFormat) A_1.Clone(), FieldMarkType.FieldEnd) };
    }
}

