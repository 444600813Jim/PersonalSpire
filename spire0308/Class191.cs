using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal class Class191
{
    internal const string string_0 = @"(?<=^|\W|\t)";
    internal const string string_1 = @"(?=$|\W|\t)";
    internal const string string_2 = @"(?<=^|\W|\t)(?=$|\W|\t)";

    internal static bool smethod_0(Regex A_0)
    {
        int num = 0x11;
        string str = A_0.ToString();
        if (str.Length != 0)
        {
            return (str == BookmarkStart.b("ἶظܺ<愾㵀ὂቄ㭆ᕈ㽊摌李湐湒煔⭖՘ౚ⅜͞ᕠ䩢", num));
        }
        return true;
    }

    internal static Regex smethod_1(string A_0, bool A_1, bool A_2)
    {
        int num = 7;
        A_0 = Regex.Escape(A_0);
        if (A_2)
        {
            A_0 = BookmarkStart.b("Ԭီരา欴䬶攸氺䄼挾㕀橂", num) + A_0 + BookmarkStart.b("Ԭီరᜲ䤴欶游䜺愼䬾桀", num);
        }
        return new Regex(A_0, A_1 ? RegexOptions.None : RegexOptions.IgnoreCase);
    }

    internal static int smethod_2(Paragraph A_0, int A_1, out TextRange A_2)
    {
        A_2 = null;
        int num2 = 0;
        int count = A_0.Items.Count;
        while (num2 < count)
        {
            A_2 = A_0[num2] as TextRange;
            if ((A_2 != null) && ((A_2.StartPos + A_2.TextLength) >= A_1))
            {
                return num2;
            }
            num2++;
        }
        return 0;
    }

    internal static int smethod_3(Paragraph A_0, int A_1, out ParagraphBase A_2)
    {
        A_2 = null;
        int num = 0;
        int num2 = 0;
        int count = A_0.Items.Count;
        while (num2 < count)
        {
            A_2 = A_0[num2] as TextRange;
            if ((A_2 != null) && ((A_2.StartPos + (A_2 as TextRange).TextLength) >= A_1))
            {
                return num2;
            }
            if ((A_0[num2] is Break) && (((A_0[num2] as Break).StartPos + 1) >= A_1))
            {
                num = num2;
                A_2 = A_0[num2];
                return num;
            }
            num2++;
        }
        return num;
    }

    internal static int smethod_4(SDTInlineContent A_0, int A_1, out TextRange A_2)
    {
        A_2 = null;
        int num2 = 0;
        int count = A_0.Items.Count;
        while (num2 < count)
        {
            A_2 = A_0[num2] as TextRange;
            if ((A_2 != null) && ((A_2.StartPos + A_2.TextLength) >= A_1))
            {
                return num2;
            }
            num2++;
        }
        return 0;
    }

    internal static List<Body> smethod_5(ParagraphBase A_0)
    {
        List<Body> list = new List<Body>();
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.Comment:
            {
                Comment comment = (Comment) A_0;
                list.Add(comment.Body);
                return list;
            }
            case DocumentObjectType.Footnote:
            {
                Footnote footnote = (Footnote) A_0;
                list.Add(footnote.TextBody);
                return list;
            }
            case DocumentObjectType.TextBox:
            {
                TextBox box = (TextBox) A_0;
                list.Add(box.Body);
                return list;
            }
            case DocumentObjectType.Break:
            case DocumentObjectType.Symbol:
            case DocumentObjectType.TOC:
                return list;

            case DocumentObjectType.XmlParaItem:
                if (((A_0 is Class6) && ((A_0 as Class6).method_32() != null)) && ((A_0 as Class6).method_32() is ShapeObject))
                {
                    ShapeObject obj2 = (A_0 as Class6).method_32() as ShapeObject;
                    if ((obj2.AutoShapeTextCollection != null) && (obj2.AutoShapeTextCollection.Count > 0))
                    {
                        foreach (TextBox box2 in obj2.AutoShapeTextCollection)
                        {
                            list.Add(box2.Body);
                        }
                        return list;
                    }
                    if (obj2.HasInternalTextbox)
                    {
                        list.Add(obj2.InternerTextbox.Body);
                    }
                }
                return list;

            case DocumentObjectType.Shape:
                if (A_0 is ShapeObject)
                {
                    ShapeObject obj3 = A_0 as ShapeObject;
                    if ((obj3.AutoShapeTextCollection != null) && (obj3.AutoShapeTextCollection.Count > 0))
                    {
                        foreach (TextBox box3 in obj3.AutoShapeTextCollection)
                        {
                            list.Add(box3.Body);
                        }
                        return list;
                    }
                    if (obj3.HasInternalTextbox)
                    {
                        list.Add(obj3.InternerTextbox.Body);
                    }
                }
                return list;
        }
        return list;
    }
}

