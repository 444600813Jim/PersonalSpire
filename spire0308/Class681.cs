using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using Spire.Doc.Fields;
using System;

internal class Class681
{
    private Class681()
    {
    }

    internal static int smethod_0(DocumentObject A_0)
    {
        if (A_0.DocumentObjectType == DocumentObjectType.TextRange)
        {
            return (A_0 as TextRange).Text.Length;
        }
        if (smethod_4(A_0))
        {
            return 0;
        }
        return 1;
    }

    internal static bool smethod_1(DocumentObject A_0, DocumentObject A_1)
    {
        if (A_0 != A_1)
        {
            return A_0.method_14(A_1);
        }
        return true;
    }

    internal static bool smethod_10(DocumentObject A_0)
    {
        DocumentObjectType documentObjectType = A_0.DocumentObjectType;
        if (documentObjectType <= DocumentObjectType.TextRange)
        {
            if (documentObjectType == DocumentObjectType.StructureDocumentTag)
            {
                return false;
            }
            if (documentObjectType != DocumentObjectType.TextRange)
            {
                goto Label_008D;
            }
            goto Label_008F;
        }
        switch (documentObjectType)
        {
            case DocumentObjectType.TextFormField:
            case DocumentObjectType.DropDownFormField:
            case DocumentObjectType.BookmarkStart:
            case DocumentObjectType.BookmarkEnd:
            case DocumentObjectType.Shape:
            case DocumentObjectType.ShapeGroup:
            case DocumentObjectType.Comment:
            case DocumentObjectType.Footnote:
            case DocumentObjectType.FieldMark:
            case DocumentObjectType.CommentMark:
            case DocumentObjectType.CommentEnd:
            case DocumentObjectType.SmartTag:
                goto Label_008F;

            case DocumentObjectType.CustomXml:
                return (((Class9) A_0).method_29() == MarkupLevel.Inline);
        }
    Label_008D:
        return false;
    Label_008F:
        return true;
    }

    internal static bool smethod_11(Interface60 A_0, DocumentObject A_1)
    {
        if (A_1 is Interface60)
        {
            return (A_0.imethod_0() == ((Interface60) A_1).imethod_0());
        }
        switch (A_0.imethod_0())
        {
            case MarkupLevel.Inline:
                return smethod_10(A_1);

            case MarkupLevel.Block:
                return smethod_7(A_1);

            case MarkupLevel.Row:
                return smethod_8(A_1);

            case MarkupLevel.Cell:
                return smethod_9(A_1);
        }
        return false;
    }

    internal static bool smethod_12(DocumentObjectType A_0)
    {
        return ((A_0 != DocumentObjectType.Any) && !smethod_13(A_0));
    }

    internal static bool smethod_13(DocumentObjectType A_0)
    {
        if ((A_0 != DocumentObjectType.StructureDocumentTag) && (A_0 != DocumentObjectType.CustomXml))
        {
            return (A_0 == DocumentObjectType.SmartTag);
        }
        return true;
    }

    internal static bool smethod_14(DocumentObject A_0)
    {
        return ((A_0 != null) && smethod_13(A_0.DocumentObjectType));
    }

    internal static DocumentObject smethod_15(DocumentObject A_0)
    {
        DocumentObject firstNonMarkupDescendant = null;
        for (DocumentObject obj3 = A_0; obj3 != null; obj3 = (DocumentObject) obj3.NextSibling)
        {
            if (firstNonMarkupDescendant != null)
            {
                return firstNonMarkupDescendant;
            }
            if (smethod_14(obj3))
            {
                DocumentObject obj4 = obj3;
                firstNonMarkupDescendant = obj4.FirstNonMarkupDescendant;
            }
            else
            {
                firstNonMarkupDescendant = obj3;
            }
        }
        return firstNonMarkupDescendant;
    }

    internal static DocumentObject smethod_16(DocumentObject A_0)
    {
        DocumentObject lastNonMarkupDescendant = null;
        for (DocumentObject obj3 = A_0; obj3 != null; obj3 = (DocumentObject) obj3.PreviousSibling)
        {
            if (lastNonMarkupDescendant != null)
            {
                return lastNonMarkupDescendant;
            }
            if (smethod_14(obj3))
            {
                DocumentObject obj4 = obj3;
                lastNonMarkupDescendant = obj4.LastNonMarkupDescendant;
            }
            else
            {
                lastNonMarkupDescendant = obj3;
            }
        }
        return lastNonMarkupDescendant;
    }

    internal static Table smethod_17(DocumentObject A_0)
    {
        return ((A_0.DocumentObjectType == DocumentObjectType.Table) ? ((Table) A_0) : ((Table) A_0.method_7(DocumentObjectType.Table)));
    }

    internal static int smethod_18(DocumentObject A_0)
    {
        if (A_0.ParentObject == null)
        {
            return 0;
        }
        int num = 0;
        for (DocumentObject obj2 = A_0.ParentObject.FirstChild; obj2 != A_0; obj2 = (DocumentObject) obj2.NextSibling)
        {
            num++;
        }
        return num;
    }

    internal static int smethod_19(DocumentObject A_0)
    {
        int num = 0;
        while (A_0 != null)
        {
            A_0 = A_0.ParentObject;
            num++;
        }
        return num;
    }

    internal static DocumentObject smethod_2(DocumentObject A_0, DocumentObjectType A_1)
    {
        DocumentObject obj2 = A_0.method_6(A_1);
        if (obj2 == null)
        {
            return A_0;
        }
        return obj2;
    }

    internal static DocumentObject smethod_20(DocumentObject A_0, int A_1)
    {
        while (A_1 > 0)
        {
            if (A_0 == null)
            {
                return A_0;
            }
            A_1--;
            A_0 = A_0.ParentObject;
        }
        return A_0;
    }

    internal static bool smethod_21(DocumentObject A_0)
    {
        if (A_0.DocumentObjectType != DocumentObjectType.Paragraph)
        {
            return false;
        }
        Paragraph paragraph = (Paragraph) A_0;
        for (DocumentObject obj2 = paragraph.FirstNonMarkupDescendant; obj2 != null; obj2 = obj2.NextNonMarkupElementLimited)
        {
            if (obj2.DocumentObjectType == DocumentObjectType.Shape)
            {
                ShapeObject obj3 = (ShapeObject) obj2;
                if ((obj3.TextWrappingStyle == TextWrappingStyle.Inline) && !obj3.Hidden)
                {
                    return false;
                }
            }
            else if (obj2.DocumentObjectType == DocumentObjectType.Paragraph)
            {
                return (obj2 as Paragraph).method_97();
            }
        }
        return true;
    }

    internal static int smethod_3(DocumentObject A_0)
    {
        int num = 0;
        while (A_0 != null)
        {
            if (DocumentObjectType.Table == A_0.DocumentObjectType)
            {
                num++;
            }
            A_0 = A_0.ParentObject;
            if (A_0 != null)
            {
                switch (A_0.DocumentObjectType)
                {
                    case DocumentObjectType.Shape:
                    case DocumentObjectType.ShapeGroup:
                    case DocumentObjectType.Comment:
                    case DocumentObjectType.Footnote:
                        A_0 = null;
                        break;
                }
            }
        }
        return num;
    }

    internal static bool smethod_4(DocumentObject A_0)
    {
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.BookmarkStart:
            case DocumentObjectType.BookmarkEnd:
            case DocumentObjectType.StructureDocumentTag:
            case DocumentObjectType.CommentMark:
            case DocumentObjectType.CommentEnd:
            case DocumentObjectType.CustomXml:
            case DocumentObjectType.SmartTag:
            case DocumentObjectType.Comment:
                return true;
        }
        return false;
    }

    internal static bool smethod_5(DocumentObject A_0)
    {
        if (A_0.DocumentObjectType != DocumentObjectType.TextRange)
        {
            return !smethod_4(A_0);
        }
        return !Class567.smethod_28((A_0 as TextRange).Text);
    }

    internal static bool smethod_6(DocumentObject A_0)
    {
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.Shape:
            case DocumentObjectType.ShapeGroup:
            case DocumentObjectType.Comment:
            case DocumentObjectType.Footnote:
            case DocumentObjectType.HeaderFooter:
            case DocumentObjectType.Document:
                return true;
        }
        return false;
    }

    internal static bool smethod_7(DocumentObject A_0)
    {
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.Paragraph:
            case DocumentObjectType.Table:
                return true;

            case DocumentObjectType.StructureDocumentTag:
                return false;

            case DocumentObjectType.CustomXml:
                return (((Class9) A_0).method_29() == MarkupLevel.Block);
        }
        return false;
    }

    internal static bool smethod_8(DocumentObject A_0)
    {
        DocumentObjectType documentObjectType = A_0.DocumentObjectType;
        switch (documentObjectType)
        {
            case DocumentObjectType.StructureDocumentTag:
                return false;

            case DocumentObjectType.TableRow:
                return true;
        }
        if (documentObjectType != DocumentObjectType.CustomXml)
        {
            return false;
        }
        return (((Class9) A_0).method_29() == MarkupLevel.Row);
    }

    internal static bool smethod_9(DocumentObject A_0)
    {
        DocumentObjectType documentObjectType = A_0.DocumentObjectType;
        switch (documentObjectType)
        {
            case DocumentObjectType.StructureDocumentTag:
                return false;

            case DocumentObjectType.TableCell:
                return true;
        }
        if (documentObjectType != DocumentObjectType.CustomXml)
        {
            return false;
        }
        return (((Class9) A_0).method_29() == MarkupLevel.Cell);
    }
}

