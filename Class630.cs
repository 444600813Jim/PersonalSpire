using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;

internal class Class630
{
    private Class630()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        int num = 0x10;
        string str = "";
        string str2 = "";
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str3 = class2.method_1();
            if (str3 != null)
            {
                if (str3 != BookmarkStart.b("刵崷䤹䠻", num))
                {
                    if (str3 != BookmarkStart.b("吵圷唹圻匽ℿぁ⽃", num))
                    {
                        if (!(str3 == BookmarkStart.b("䈵夷䠹嬻嬽㐿", num)))
                        {
                            if (str3 == BookmarkStart.b("䔵嬷䠹夻嬽⸿ᙁⵃ㙅", num))
                            {
                                class2.method_3();
                            }
                        }
                        else
                        {
                            class2.method_3();
                        }
                    }
                    else
                    {
                        str2 = class2.method_3();
                    }
                }
                else
                {
                    str = class2.method_3();
                }
            }
        }
        DocumentObject lastChild = A_0.method_13().LastChild;
        Field field = new Field(A_0.Interface50.imethod_0()) {
            Type = FieldType.FieldHyperlink
        };
        Hyperlink hyperlink = new Hyperlink(field) {
            Type = HyperlinkType.Bookmark,
            BookmarkName = str2
        };
        if (!string.IsNullOrEmpty(str))
        {
            field.m_fieldValue = BookmarkStart.b("ᐵ", num) + str.Replace(BookmarkStart.b("樵", num), BookmarkStart.b("樵搷", num)) + BookmarkStart.b("ᐵ", num);
            field.Code = BookmarkStart.b("縵愷樹礻氽ిୁ੃൅桇", num) + field.m_fieldValue;
        }
        Class464.smethod_0(A_0);
        int index = (A_0.method_13() as Paragraph).ChildObjects.IndexOf(lastChild);
        (A_0.method_13() as Paragraph).ChildObjects.Insert(index + 1, field);
        index = (A_0.method_13() as Paragraph).ChildObjects.IndexOf(field);
        FieldMark entity = new FieldMark(A_0.Interface50.imethod_0(), FieldMarkType.FieldSeparator);
        (A_0.method_13() as Paragraph).ChildObjects.Insert(index + 1, entity);
        field.Separator = entity;
        FieldMark mark2 = new FieldMark(A_0.Interface50.imethod_0(), FieldMarkType.FieldEnd);
        A_0.method_11(A_0.method_13(), mark2, A_0.method_13().LastChild);
        field.End = mark2;
    }
}

