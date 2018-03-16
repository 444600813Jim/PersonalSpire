using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal class Class193
{
    [ThreadStatic]
    public static Class193 class193_0;

    public int method_0(Paragraph A_0, Regex A_1, string A_2)
    {
        int num = 0x12;
        ParagraphItemCollection items = A_0.Items;
        string text = A_0.Text;
        MatchCollection matchs = A_1.Matches(text);
        if (matchs.Count > 0)
        {
            int num2 = 0;
            int num3 = 0;
            int length = A_2.Length;
            int num5 = 0;
            int num6 = 0;
            foreach (Match match in matchs)
            {
                ParagraphBase base2;
                num5 = match.Index + num2;
                num6 = match.Length;
                num3 = length - match.Length;
                A_0.method_66(num5, num6, A_2);
                TextRange entity = null;
                int num9 = Class191.smethod_3(A_0, num5 + 1, out base2);
                if (base2 is TextRange)
                {
                    entity = base2 as TextRange;
                }
                else if (base2 is Break)
                {
                    entity = (base2 as Break).TextRange;
                }
                int num8 = entity.StartPos + entity.TextLength;
                entity.SafeText = false;
                if (num8 > (num5 + num6))
                {
                    entity.TextLength += num3;
                }
                else
                {
                    ParagraphBase base3;
                    this.method_5(A_0, num5 + num6, num9 + 1, out base3);
                    int num10 = num5 + num6;
                    if (base3 is TextRange)
                    {
                        TextRange range2 = base3 as TextRange;
                        range2.TextLength -= num10 - range2.StartPos;
                        range2.StartPos = num10 + num3;
                        num9++;
                    }
                    entity.TextLength = (num10 + num3) - entity.StartPos;
                }
                this.method_6(A_0, num9 + 1, num3);
                num2 += num3;
                if (base2 is Break)
                {
                    int index = A_0.ChildObjects.IndexOf(base2);
                    TextRange range3 = new TextRange(entity.Document) {
                        StartPos = base2.StartPos,
                        TextLength = A_2.Length
                    };
                    range3.CharacterFormat.ApplyBase(base2.CharacterFormat.method_23());
                    A_0.ChildObjects.InnerList.RemoveAt(index);
                    A_0.ChildObjects.InnerList.Insert(index, range3);
                    range3.method_0(A_0);
                    entity = range3;
                }
                else if (((entity != null) && (entity.DocumentObjectType == DocumentObjectType.TextRange)) && (entity.Text == BookmarkStart.b("㌷", num)))
                {
                    int num11 = A_0.ChildObjects.IndexOf(entity);
                    Break @break = new Break(entity.Document) {
                        StartPos = entity.StartPos
                    };
                    A_0.ChildObjects.InnerList.RemoveAt(num11);
                    A_0.ChildObjects.InnerList.Insert(num11, @break);
                    @break.method_0(A_0);
                }
                if (entity != null)
                {
                    entity.method_39();
                }
                if (A_0.Document.ReplaceFirst)
                {
                    break;
                }
            }
        }
        int count = matchs.Count;
        if (A_0.Document.ReplaceFirst && (count > 0))
        {
            return count;
        }
        return (count + smethod_1(A_0, A_1, A_2));
    }

    internal void method_1(TextSelection[] A_0, string A_1)
    {
        if ((A_0 != null) && (A_0.Length != 0))
        {
            TextSelection selection = null;
            int num2 = A_0.Length - 1;
            for (int i = num2; i > 0; i--)
            {
                selection = A_0[i];
                selection.method_0();
                this.method_4(selection);
            }
            selection = A_0[0];
            selection.GetAsOneRange().Text = A_1;
        }
    }

    internal void method_2(TextSelection[] A_0, TextSelection A_1)
    {
        if ((A_0 != null) && (A_0.Length != 0))
        {
            TextSelection selection = null;
            int num3 = A_0.Length - 1;
            for (int i = num3; i >= 0; i--)
            {
                selection = A_0[i];
                int num2 = selection.method_0();
                if (i == 0)
                {
                    Paragraph ownerParagraph = selection.OwnerParagraph;
                    if (selection.OwnerSDTInlineContent != null)
                    {
                        A_1.method_3(selection.OwnerSDTInlineContent, num2, false, null);
                    }
                    else
                    {
                        A_1.method_2(ownerParagraph, num2, false, null);
                    }
                }
                else
                {
                    this.method_4(selection);
                }
            }
        }
    }

    internal void method_3(TextSelection[] A_0, TextBodyPart A_1)
    {
        if ((A_0 != null) && (A_0.Length != 0))
        {
            TextSelection selection = null;
            int num3 = A_0.Length - 1;
            for (int i = num3; i >= 0; i--)
            {
                selection = A_0[i];
                int pItemIndex = selection.method_0();
                if (i == 0)
                {
                    Paragraph ownerParagraph = selection.OwnerParagraph;
                    A_1.PasteAt(ownerParagraph.OwnerTextBody, ownerParagraph.method_5(), pItemIndex);
                }
                else
                {
                    this.method_4(selection);
                }
            }
        }
    }

    private void method_4(TextSelection A_0)
    {
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        if (ownerParagraph.Items.Count == 0)
        {
            ownerParagraph.RemoveSelf();
        }
    }

    private void method_5(Paragraph A_0, int A_1, int A_2, out ParagraphBase A_3)
    {
        smethod_5(A_0.Items, A_1, A_2, out A_3);
    }

    private void method_6(Paragraph A_0, int A_1, int A_2)
    {
        smethod_7(A_0.Items, A_1, A_2);
    }

    public static Class193 smethod_0()
    {
        if (class193_0 == null)
        {
            class193_0 = new Class193();
        }
        return class193_0;
    }

    private static int smethod_1(Paragraph A_0, Regex A_1, string A_2)
    {
        int num = 0;
        foreach (ParagraphBase base2 in A_0.Items)
        {
            if (A_0.Document.ReplaceFirst && (num > 0))
            {
                return num;
            }
            List<Body> list = Class191.smethod_5(base2);
            if (list.Count > 0)
            {
                foreach (Body body in list)
                {
                    num += body.method_24(A_1, A_2);
                    if (A_0.Document.ReplaceFirst && (num > 0))
                    {
                        break;
                    }
                }
            }
            else
            {
                switch (base2.DocumentObjectType)
                {
                    case DocumentObjectType.StructureDocumentTagInline:
                        num += smethod_2((base2 as StructureDocumentTagInline).SDTContent, A_1, A_2);
                        break;

                    case DocumentObjectType.Field:
                    {
                        Field field = base2 as Field;
                        if (((field.Type == FieldType.FieldHyperlink) && (field.NextSibling != null)) && ((field.NextSibling.NextSibling is TextRange) && ((field.NextSibling.NextSibling as TextRange).Text == A_2)))
                        {
                            bool flag = false;
                            if (!string.IsNullOrEmpty(field.Code))
                            {
                                field.Code = A_1.Replace(field.Code, A_2);
                                num++;
                                flag = true;
                            }
                            if (!string.IsNullOrEmpty(field.Value))
                            {
                                field.FieldValue = A_1.Replace(field.Value, A_2);
                                if (!flag)
                                {
                                    num++;
                                }
                            }
                        }
                        break;
                    }
                }
            }
        }
        return num;
    }

    internal static int smethod_2(SDTInlineContent A_0, Regex A_1, string A_2)
    {
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        ParagraphItemCollection items = A_0.Items;
        string text = A_0.Text;
        MatchCollection matchs = A_1.Matches(text);
        if (matchs.Count > 0)
        {
            int num = 0;
            int num2 = 0;
            int length = A_2.Length;
            int num4 = 0;
            int num5 = 0;
            foreach (Match match in matchs)
            {
                TextRange range2;
                num4 = match.Index + num;
                num5 = match.Length;
                num2 = length - match.Length;
                A_0.method_24(num4, num5, A_2);
                int num7 = Class191.smethod_4(A_0, num4 + 1, out range2);
                int num9 = range2.StartPos + range2.TextLength;
                range2.SafeText = false;
                if ((num9 <= (num4 + num5)) && ((range2.NextSibling == null) || (range2.NextSibling.DocumentObjectType == DocumentObjectType.TextRange)))
                {
                    ParagraphBase base2;
                    smethod_4(A_0, num4 + num5, num7 + 1, out base2);
                    int num8 = num4 + num5;
                    if (base2 is TextRange)
                    {
                        TextRange range = base2 as TextRange;
                        range.TextLength -= num8 - range.StartPos;
                        range.StartPos = num8 + num2;
                        num7++;
                    }
                    range2.TextLength = (num8 + num2) - range2.StartPos;
                }
                else
                {
                    range2.TextLength += num2;
                }
                smethod_6(A_0, num7 + 1, num2);
                num += num2;
                if (ownerParagraph.Document.ReplaceFirst)
                {
                    break;
                }
            }
        }
        int count = matchs.Count;
        if (ownerParagraph.Document.ReplaceFirst && (count > 0))
        {
            return count;
        }
        return (count + smethod_3(A_0, A_1, A_2));
    }

    private static int smethod_3(SDTInlineContent A_0, Regex A_1, string A_2)
    {
        int num = 0;
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        foreach (ParagraphBase base2 in A_0.Items)
        {
            if (ownerParagraph.Document.ReplaceFirst && (num > 0))
            {
                return num;
            }
            List<Body> list = Class191.smethod_5(base2);
            if (list.Count > 0)
            {
                foreach (Body body in list)
                {
                    num += body.method_24(A_1, A_2);
                    if (ownerParagraph.Document.ReplaceFirst && (num > 0))
                    {
                        break;
                    }
                }
            }
            else
            {
                switch (base2.DocumentObjectType)
                {
                    case DocumentObjectType.StructureDocumentTagInline:
                        num += smethod_2((base2 as StructureDocumentTagInline).SDTContent, A_1, A_2);
                        break;

                    case DocumentObjectType.Field:
                    {
                        Field field = base2 as Field;
                        if (((field.Type == FieldType.FieldHyperlink) && (field.NextSibling.NextSibling is TextRange)) && ((field.NextSibling.NextSibling as TextRange).Text == A_2))
                        {
                            field.Code = A_1.Replace(field.Code, A_2);
                            field.FieldValue = A_1.Replace(field.Value, A_2);
                            num++;
                        }
                        break;
                    }
                }
            }
        }
        return num;
    }

    private static void smethod_4(SDTInlineContent A_0, int A_1, int A_2, out ParagraphBase A_3)
    {
        smethod_5(A_0.Items, A_1, A_2, out A_3);
    }

    private static void smethod_5(ParagraphItemCollection A_0, int A_1, int A_2, out ParagraphBase A_3)
    {
        int startPos = 0;
        A_3 = null;
        for (int i = A_2; i < A_0.Count; i++)
        {
            A_3 = A_0[i];
            startPos = A_3.StartPos;
            if (A_3 is TextRange)
            {
                TextRange range = A_3 as TextRange;
                startPos = range.StartPos + range.TextLength;
            }
            if (startPos >= A_1)
            {
                return;
            }
            A_0.method_23(i);
            i--;
        }
    }

    private static void smethod_6(SDTInlineContent A_0, int A_1, int A_2)
    {
        smethod_7(A_0.Items, A_1, A_2);
    }

    private static void smethod_7(ParagraphItemCollection A_0, int A_1, int A_2)
    {
        int num = A_1;
        int count = A_0.Count;
        while (num < count)
        {
            ParagraphBase base2 = A_0[num];
            base2.StartPos += A_2;
            num++;
        }
    }
}

