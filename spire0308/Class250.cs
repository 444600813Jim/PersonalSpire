using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;

internal class Class250
{
    private static FieldCharType fieldCharType_0;

    private Class250()
    {
    }

    internal static void smethod_0(Class581 A_0, CharacterFormat A_1)
    {
        int num = 0x10;
        Class394 class2 = A_0.imethod_1();
        bool flag = false;
        bool flag2 = false;
        while (class2.method_19())
        {
            string str3 = class2.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("倵吷帹缻嘽ℿぁ၃㽅㡇⽉", num)))
                {
                    if (!(str3 == BookmarkStart.b("刵儷䠹䠻䜽", num)) && (str3 == BookmarkStart.b("倵吷帹瀻儽⌿⥁", num)))
                    {
                        class2.method_56(class2.method_63());
                    }
                }
                else
                {
                    string str = class2.method_3();
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("吵崷崹唻倽", num))
                        {
                            if (!(str == BookmarkStart.b("䔵崷䨹崻䰽ℿ㙁⅃", num)))
                            {
                                if (str == BookmarkStart.b("匵嘷帹", num))
                                {
                                    flag = true;
                                }
                            }
                            else
                            {
                                smethod_2(A_0, A_1);
                            }
                            continue;
                        }
                        smethod_1(A_0, A_1);
                        flag2 = true;
                    }
                }
            }
        }
        if (flag)
        {
            smethod_3(A_0, A_1);
        }
        byte[] item = null;
        while (class2.method_9(BookmarkStart.b("倵吷帹缻嘽ℿぁ", num)))
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("倵吷帹砻弽㐿⍁", num)))
                {
                    if (str2 == BookmarkStart.b("倵帷縹崻䨽ℿ", num))
                    {
                        continue;
                    }
                }
                else
                {
                    item = Convert.FromBase64String(class2.method_21());
                    continue;
                }
            }
            class2.vmethod_1();
        }
        if (flag2)
        {
            class2.method_68().Push(item);
        }
        else if (flag)
        {
            class2.method_68().Pop();
        }
    }

    private static void smethod_1(Class581 A_0, CharacterFormat A_1)
    {
        A_0.imethod_1().bool_0 = true;
        fieldCharType_0 = FieldCharType.Begin;
        A_0.imethod_1().method_52().Push(fieldCharType_0);
    }

    private static void smethod_2(Class581 A_0, CharacterFormat A_1)
    {
        if ((A_0.imethod_1().method_52().Count <= 0) || (A_0.imethod_1().method_53() != FieldCharType.Seperate))
        {
            bool flag = A_0.imethod_1().method_53() == FieldCharType.Begin;
            fieldCharType_0 = FieldCharType.Seperate;
            A_0.imethod_1().method_52().Push(fieldCharType_0);
            ParagraphBase lastChild = A_0.method_13().LastChild as ParagraphBase;
            if (A_0.imethod_1().method_57() != null)
            {
                lastChild = A_0.imethod_1().method_57();
            }
            else if (flag)
            {
                lastChild = new Field(A_0.Interface50.imethod_0());
                A_0.imethod_1().method_54().Push(lastChild as Field);
                A_0.method_9(lastChild);
            }
            if (((lastChild is Field) || (lastChild is TextRange)) && !(lastChild is MergeField))
            {
                if ((lastChild is Field) ? ((lastChild as Field).Type == FieldType.FieldTOC) : false)
                {
                    if (lastChild.Owner == null)
                    {
                        return;
                    }
                    (lastChild as Field).ParseFieldCode((lastChild as Field).Code);
                    TableOfContent content = new TableOfContent(A_0.Interface50.imethod_0(), A_0.imethod_1().method_57().FormattingString);
                    A_0.Interface50.imethod_0().TOC = content;
                    content.FormattingString = A_0.imethod_1().method_57().FormattingString;
                    A_0.method_13().ChildObjects.Remove(lastChild);
                    A_0.method_9(content);
                    if (A_0.method_13() is Paragraph)
                    {
                        (A_0.method_13() as Paragraph).IsTOCPara = true;
                    }
                    else
                    {
                        (A_0.method_13() as ParagraphBase).OwnerParagraph.IsTOCPara = true;
                    }
                    lastChild = content.TOCField;
                }
                FieldMark mark = new FieldMark(A_0.Interface50.imethod_0(), A_1, FieldMarkType.FieldSeparator);
                A_0.method_9(mark);
                if (lastChild is Field)
                {
                    (lastChild as Field).Separator = mark;
                }
            }
        }
    }

    private static void smethod_3(Class581 A_0, CharacterFormat A_1)
    {
        Class394 class2 = A_0.imethod_1();
        if (!(class2.method_57() is MergeField) && (class2.method_57() != null))
        {
            FieldMark mark = new FieldMark(A_0.Interface50.imethod_0(), A_1, FieldMarkType.FieldEnd);
            A_0.method_9(mark);
            if (class2.method_52().Count == 0)
            {
                return;
            }
            Field field2 = class2.method_57();
            field2.End = mark;
            if ((class2.method_52().Count > 0) && (class2.method_53() == FieldCharType.Seperate))
            {
                class2.method_52().Pop();
            }
            if (class2.method_52().Count == 0)
            {
                field2.method_19();
                return;
            }
            class2.method_52().Pop();
            smethod_4(A_0, field2);
        }
        if ((class2.method_54() != null) && (class2.method_54().Count > 0))
        {
            Field field = class2.method_54().Pop();
            field.ParseFieldCode(field.Code);
            if ((field.Type == FieldType.FieldDate) || (field.Type == FieldType.FieldTime))
            {
                field.method_49();
            }
        }
    }

    private static void smethod_4(Class581 A_0, Field A_1)
    {
        switch (A_1.Type)
        {
            case FieldType.FieldIncludePicture:
            case FieldType.FieldIncludeText:
            case FieldType.FieldFileSize:
                break;

            case FieldType.FieldFormTextInput:
            case FieldType.FieldFormCheckBox:
            case FieldType.FieldFormDropDown:
                smethod_5(A_0, A_1);
                break;

            default:
                return;
        }
    }

    private static void smethod_5(Class581 A_0, Field A_1)
    {
        bool flag = A_0.vmethod_5();
        Class394 class2 = A_0.imethod_1();
        if ((class2.method_67() != null) || flag)
        {
            CharacterFormat format1 = (CharacterFormat) A_1.CharacterFormat.Clone();
            if ((A_1 is FormField) && (class2.method_67() != null))
            {
                (A_1 as FormField).method_242(class2.method_67());
            }
        }
    }

    private static void smethod_6(Class581 A_0, Field A_1)
    {
        ShapeObject obj3;
        DocumentObject nextSibling = (DocumentObject) A_1.Separator.NextSibling;
        switch (nextSibling.DocumentObjectType)
        {
            case DocumentObjectType.Shape:
                obj3 = (ShapeObject) nextSibling;
                goto Label_00C1;

            case DocumentObjectType.ShapeGroup:
                obj3 = (ShapeObject) nextSibling.NextSibling;
                goto Label_00C1;

            case DocumentObjectType.BookmarkStart:
                while (nextSibling != null)
                {
                    if (nextSibling.NextSibling is DocPicture)
                    {
                        break;
                    }
                    nextSibling = nextSibling.NextSibling as DocumentObject;
                }
                break;

            case DocumentObjectType.FieldMark:
                obj3 = new ShapeObject(A_0.Interface50.imethod_0()) {
                    Width = 1.0,
                    Height = 1.0,
                    TextWrappingStyle = TextWrappingStyle.Inline
                };
                A_0.method_11(A_1.Separator.ParentObject, obj3, A_1.Separator);
                goto Label_00C1;

            default:
                return;
        }
        obj3 = nextSibling.NextSibling as DocPicture;
    Label_00C1:
        obj3.TextWrappingStyle = TextWrappingStyle.Inline;
        smethod_7(A_1);
    }

    private static void smethod_7(Field A_0)
    {
        DocumentObject nextSibling;
        for (DocumentObject obj2 = A_0.Separator; obj2 != A_0.End.NextSibling; obj2 = nextSibling)
        {
            nextSibling = (DocumentObject) obj2.NextSibling;
            switch (obj2.DocumentObjectType)
            {
                case DocumentObjectType.Shape:
                case DocumentObjectType.ShapeGroup:
                    break;

                default:
                    obj2.method_19();
                    break;
            }
        }
    }
}

