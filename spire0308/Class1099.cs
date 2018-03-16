using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Class1099
{
    private static bool bool_0;

    private Class1099()
    {
    }

    internal static void smethod_0(Class857 A_0, string A_1, ref DocumentObject A_2, Class101 A_3, bool A_4)
    {
        bool_0 = A_4;
        smethod_1(A_0, A_1, A_2);
        bool_0 = false;
        if (A_3 != null)
        {
            if (A_2 == null)
            {
                A_2 = A_0.method_9().LastSection.Body;
            }
            Paragraph lastChild = (Paragraph) A_2.LastChild;
            if (A_4)
            {
                ListStyle style = A_3.method_21();
                lastChild.ListFormat.ListLevelNumber = A_0.method_24();
                lastChild.ListFormat.ApplyStyle(style.Name);
                if (A_3.method_27() != null)
                {
                    lastChild.ListFormat.LFOStyleName = A_3.method_27();
                }
                A_3.method_26(true);
            }
        }
    }

    internal static void smethod_1(Class857 A_0, string A_1, DocumentObject A_2)
    {
        Paragraph paragraph;
        int num = 12;
        Class396 class2 = A_0.method_11();
        A_0.method_17(null);
        while (class2.method_19())
        {
            smethod_7(A_0);
        }
        class2.method_8().MoveToElement();
        Class108 class6 = Class574.smethod_10(A_0);
        if (!Class576.smethod_1(class2))
        {
            A_2 = Class574.smethod_4(A_0, class6, A_2);
        }
        Class97 class4 = (Class97) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("䈱唳䐵夷崹主弽〿⩁", num), A_0.method_20(), true);
        if ((A_0.method_36().Count > 0) && (A_2 is Body))
        {
            paragraph = (Paragraph) A_0.method_36()[A_0.method_36().Count - 1];
            A_0.method_36().RemoveAt(A_0.method_36().Count - 1);
        }
        else
        {
            paragraph = new Paragraph(A_0.method_9());
            if (A_2 is ShapeObject)
            {
                (A_2 as ShapeObject).InternerTextbox.method_13(paragraph);
            }
            else if (A_2 is Footnote)
            {
                (A_2 as Footnote).TextBody.method_13(paragraph);
            }
            else if (A_2 is Comment)
            {
                (A_2 as Comment).Body.method_13(paragraph);
            }
            else
            {
                A_2.method_13(paragraph);
            }
        }
        if ((A_0.method_38() != null) && !A_0.method_38().method_10())
        {
            paragraph.method_18(new FieldMark(A_0.method_9(), new CharacterFormat(A_0.method_9()), FieldMarkType.FieldSeparator), paragraph.FirstChild);
            paragraph.method_17(new FieldMark(A_0.method_9(), new CharacterFormat(A_0.method_9()), FieldMarkType.FieldSeparator), paragraph.method_17(new TextRange(A_0.method_9(), string.Format(BookmarkStart.b("䤱г䬵", num), A_0.method_38().method_8()), new CharacterFormat(A_0.method_9())), paragraph.FirstChild));
            A_0.method_38().method_11(true);
        }
        if (A_1 == BookmarkStart.b("娱", num))
        {
            smethod_6(A_0, paragraph);
        }
        else
        {
            paragraph.Format.SetAttr(0x500, (byte) 9);
        }
        Class857.string_4 = "";
        smethod_13(A_0, paragraph, class4);
        smethod_8(A_0, paragraph, A_1, class4, A_2);
        smethod_14(A_0, paragraph, class4);
        if (class4 == null)
        {
            Style style2 = (Style) A_0.method_9().Styles[(A_0.method_16() == null) ? BookmarkStart.b("愱䀳圵嘷帹崻䰽␿", num) : A_0.method_16()];
            if (style2 != null)
            {
                paragraph.ApplyStyle(style2.Name);
            }
        }
        else
        {
            if (class4.method_15() != null)
            {
                class4.method_15().CopyPropertiesTo(paragraph.Format);
                paragraph.Format.Borders.IsDefault = class4.method_15().Borders.IsDefault;
            }
            if (class4.method_13() != null)
            {
                CharacterFormat.smethod_5(class4.method_13(), paragraph.BreakCharacterFormat);
            }
            if (Class567.smethod_16(class4.method_8()))
            {
                Style style = (Style) A_0.method_9().Styles[class4.method_8()];
                if ((style != null) && (style.ParaPr != null))
                {
                    paragraph.method_65(style as ParagraphStyle);
                    smethod_4(style.ParaPr.Tabs, paragraph.Format.Tabs);
                }
            }
            if (Class567.smethod_16(class4.method_10()))
            {
                Class101 class3 = A_0.method_13().method_3(class4.method_10(), null, A_0.method_20()) as Class101;
                class3.method_21().Name = class4.method_10();
                if (A_0.method_9().ListStyles.FindByName(class4.method_10()) == null)
                {
                    A_0.method_9().ListStyles.Add(class3.method_21());
                }
                paragraph.ListFormat.ApplyStyle(class3.method_21().Name);
            }
            if ((paragraph.IsInCell && (((TableCell) paragraph.OwnerTextBody).Paragraphs[0] == paragraph)) && (class4.method_19() != TextOrientation.Horizontal))
            {
                ((TableCell) paragraph.OwnerTextBody).CellFormat.SetAttr(0xbea, class4.method_19());
            }
            if (paragraph.method_1() == null)
            {
                smethod_2(paragraph, class4);
            }
        }
        if ((paragraph.Format.OutlineLevel != OutlineLevel.Body) && (A_0.method_65() != null))
        {
            Class101 class5 = A_0.method_65();
            int outlineLevelEx = paragraph.Format.OutlineLevelEx;
            if (((class5 != null) && class5.hashtable_0.ContainsKey(outlineLevelEx)) && ((bool) class5.hashtable_0[outlineLevelEx]))
            {
                paragraph.ListFormat.ListLevelNumber = outlineLevelEx - 1;
                paragraph.ListFormat.ApplyStyle(A_0.method_65().method_21().Name);
            }
        }
        smethod_5(paragraph, class4);
        smethod_3(paragraph);
    }

    private static void smethod_10(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
        int num = 12;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(BookmarkStart.b("䀱䄳吵䄷", num)))
        {
            string str = A_0.method_11().method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䀱䄳吵䄷᜹䠻嬽㠿㙁", num)))
                {
                    if (!(str == BookmarkStart.b("䀱䄳吵䄷᜹帻弽㌿❁", num)))
                    {
                        goto Label_0070;
                    }
                    smethod_11(A_0, A_1, BookmarkStart.b("䀱䄳吵䄷᜹帻弽㌿❁", num), A_2, A_3);
                }
                else
                {
                    smethod_11(A_0, A_1, BookmarkStart.b("䀱䄳吵䄷᜹䠻嬽㠿㙁", num), A_2, A_3);
                }
                continue;
            }
        Label_0070:
            A_0.method_11().vmethod_1();
        }
    }

    private static void smethod_11(Class857 A_0, Paragraph A_1, string A_2, CharacterFormat A_3, Style A_4)
    {
        Class396 class2 = A_0.method_11();
        while (class2.method_10(A_2, XmlDocumentTextHandling.TextAndSignificantAndIgnorable))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == ""))
            {
                smethod_23(A_0, A_1, A_3, A_4);
            }
        }
    }

    private static void smethod_12(Class857 A_0, Paragraph A_1, CharacterFormat A_2, string A_3, Style A_4)
    {
        int num = 5;
        if (!A_0.method_40() && (A_1.ChildObjects.Count != 0))
        {
            if (A_1.ChildObjects[A_1.ChildObjects.Count - 1] is TextRange)
            {
                ((TextRange) A_1.ChildObjects[A_1.ChildObjects.Count - 1]).Text = string.Format(BookmarkStart.b("倪ᴬ刮䨰Ȳ䠴", num), ((TextRange) A_1.ChildObjects[A_1.ChildObjects.Count - 1]).Text, A_3);
            }
        }
        else
        {
            TextRange entity = new TextRange(A_0.method_9(), A_3, A_2);
            if (A_4 != null)
            {
                entity.CharacterFormat.CharStyleName = A_4.Name;
            }
            A_1.ChildObjects.Add(entity);
            A_0.method_41(false);
        }
    }

    internal static void smethod_13(Class857 A_0, Paragraph A_1, Class97 A_2)
    {
        if (A_0.method_18())
        {
            A_1.Format.SetAttr(0x424, true);
            A_0.method_19(false);
        }
        A_0.method_19((A_2 != null) && A_2.method_27());
        if ((A_2 != null) && A_2.method_31())
        {
            Break @break = new Break(A_0.method_9(), BreakType.ColumnBreak);
            A_1.method_13(@break);
        }
    }

    internal static void smethod_14(Class857 A_0, Paragraph A_1, Class97 A_2)
    {
        if ((A_2 != null) && A_2.method_29())
        {
            Break @break = new Break(A_0.method_9(), BreakType.ColumnBreak);
            A_1.method_13(@break);
        }
    }

    private static ArrayList smethod_15(string A_0)
    {
        char[] separator = new char[] { '\r', '\n' };
        string[] strArray = A_0.Split(separator);
        ArrayList list = new ArrayList();
        for (int i = 0; i < strArray.Length; i++)
        {
            if (Class567.smethod_16(strArray[i]))
            {
                list.Add(strArray[i]);
            }
        }
        return list;
    }

    private static void smethod_16(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
        int num = 9;
        Class396 class2 = A_0.method_11();
        string str = Class816.string_11;
        while (class2.method_19())
        {
            string str2;
            if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("䰮", num)))
            {
                str = new string(' ', class2.method_4());
            }
        }
        if (Class567.smethod_16(Class857.string_4))
        {
            str = string.Format(BookmarkStart.b("༮䨰̲䠴", num), str);
            Class857.string_4 = "";
        }
        smethod_12(A_0, A_1, A_2, str, A_3);
    }

    private static void smethod_17(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
        int num = 14;
        string str = Class816.string_9;
        if (Class567.smethod_16(Class857.string_4))
        {
            str = string.Format(BookmarkStart.b("ᐳ䴵࠷䜹", num), str);
            Class857.string_4 = "";
        }
        smethod_12(A_0, A_1, A_2, str, A_3);
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str2;
            if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("䀳匵䀷丹ػ䨽ℿ⁁楃㑅ⵇⱉ", num)))
            {
                return;
            }
        }
    }

    private static void smethod_18(Class857 A_0, Paragraph A_1, Class97 A_2, DocumentObject A_3)
    {
        int num = 9;
        string str = A_0.method_16();
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            A_0.method_4(class2);
        }
        smethod_8(A_0, A_1, BookmarkStart.b("尮䄰刲嬴", num), A_2, A_3);
        A_0.method_17(str);
    }

    private static void smethod_19(Class857 A_0, Paragraph A_1, CharacterFormat A_2)
    {
        int num = 0x11;
        Class396 class2 = A_0.method_11();
        FootnoteType type = (class2.method_12(BookmarkStart.b("夶嘸伺堼ሾ≀⽂⑄㑆㩈", 0x11), BookmarkStart.b("制圸强匼倾㕀♂", 0x11)) == BookmarkStart.b("制圸强匼倾㕀♂", 0x11)) ? FootnoteType.Endnote : FootnoteType.Footnote;
        Footnote footnote = new Footnote(A_0.method_9()) {
            FootnoteType = type,
            IsAutoNumbered = true,
            CustomMarker = null
        };
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔶䰸唺洼䴾", num));
        }
        A_2.method_37(footnote.CharacterFormat);
        while (class2.method_9(BookmarkStart.b("夶嘸伺堼", num)))
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("夶嘸伺堼ሾ≀⩂ㅄ♆㵈≊≌ⅎ", num)))
                {
                    if (!(str2 == BookmarkStart.b("夶嘸伺堼ሾ⍀ⱂ⅄㹆", num)))
                    {
                        goto Label_0110;
                    }
                    A_0.method_56(true);
                    Class574.smethod_0(A_0, BookmarkStart.b("夶嘸伺堼ሾ⍀ⱂ⅄㹆", num), footnote);
                    Class857.string_4 = "";
                    A_0.method_56(false);
                }
                else
                {
                    string str = class2.method_12(BookmarkStart.b("嬶堸夺堼匾", num), null);
                    if (str != null)
                    {
                        footnote.IsAutoNumbered = false;
                        footnote.CustomMarker = str;
                    }
                }
                continue;
            }
        Label_0110:
            class2.vmethod_1();
        }
        Paragraph paragraph = smethod_20(footnote.TextBody.ChildObjects);
        if (paragraph != null)
        {
            if (footnote.IsAutoNumbered)
            {
                new Class818();
            }
            else
            {
                paragraph.method_18(new TextRange(A_0.method_9(), footnote.CustomMarker, A_2), paragraph.FirstChild);
            }
        }
        A_1.method_13(footnote);
    }

    private static void smethod_2(Paragraph A_0, Class97 A_1)
    {
        if ((A_0.method_49() != null) && (A_0 == A_0.method_49().Body.Paragraphs[0]))
        {
            if (Class567.smethod_16(A_1.method_43()))
            {
                A_0.method_49().SectPr.SetAttr(0x898, Class1041.smethod_11(A_1.method_43()));
                A_0.method_49().SectPr.SetAttr(0x802, true);
            }
            if ((A_1.method_41() > 0) && (A_0.method_49().SectPr.method_70() != LineNumberingRestartMode.Continuous))
            {
                A_0.method_49().SectPr.SetAttr(0x884, A_1.method_41());
                A_0.method_49().SectPr.SetAttr(0x83e, LineNumberingRestartMode.RestartSection);
                A_0.Format.SetAttr(0x46a, false);
            }
        }
    }

    internal static Paragraph smethod_20(DocumentObjectCollection A_0)
    {
        if (A_0.Count != 0)
        {
            if (A_0.FirstItem is Table)
            {
                TableRow firstItem = (A_0.FirstItem as Table).Rows.FirstItem as TableRow;
                if (firstItem != null)
                {
                    TableCell cell = firstItem.Cells.FirstItem as TableCell;
                    if (cell != null)
                    {
                        return cell.method_55();
                    }
                }
            }
            else
            {
                if (!(A_0[0] is StructureDocumentTag))
                {
                    return (A_0.FirstItem as Paragraph);
                }
                if (A_0[0].ChildObjects.Count != 0)
                {
                    if (A_0[0].ChildObjects[0] is Table)
                    {
                        return (A_0[0].ChildObjects[0] as Table).Rows[0].Cells[0].method_55();
                    }
                    return (A_0[0].ChildObjects[0] as Paragraph);
                }
            }
        }
        return null;
    }

    private static void smethod_21(Class857 A_0, Paragraph A_1, CharacterFormat A_2)
    {
        int num = 6;
        if (Class567.smethod_16(Class857.string_4))
        {
            TextRange lastChild = (TextRange) A_1.LastChild;
            if (lastChild != null)
            {
                lastChild.Text = string.Format(BookmarkStart.b("圫ḭ䴯ሱ", num), lastChild.Text);
            }
            Class857.string_4 = "";
        }
        Class396 class2 = A_0.method_11();
        Comment comment = new Comment(A_0.method_9());
        while (class2.method_9(BookmarkStart.b("䴫䀭帯崱䀳圵䰷匹医倽", num)))
        {
            string str = A_0.method_11().method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("尫", num)))
                {
                    if (!(str == BookmarkStart.b("䀫䜭䌯䘱", num)))
                    {
                        goto Label_00B2;
                    }
                    Class530.smethod_0(A_0, comment.Body, null);
                }
                else
                {
                    smethod_1(A_0, class2.method_1(), comment);
                }
                continue;
            }
        Label_00B2:
            A_0.method_11().vmethod_1();
        }
        A_1.method_13(comment);
    }

    private static string smethod_22(Class857 A_0, Paragraph A_1, string A_2)
    {
        int num = 1;
        if ((A_2.IndexOf(Class816.string_2) >= 0) || (A_2.IndexOf(Class816.string_3) >= 0))
        {
            ArrayList list = smethod_15(A_2);
            A_2 = "";
            for (int i = 0; i < list.Count; i++)
            {
                string str = (string) list[i];
                bool flag2 = (i != 0) && smethod_27((string) list[i - 1]);
                bool flag = (str.Trim(new char[] { ' ' }).Length > 0) && (((i != 0) || (A_1.ChildObjects.Count != 0)) ? flag2 : true);
                if (A_0.method_40())
                {
                    str = string.Format(BookmarkStart.b("尦ᤨ嘪嘬Ḯ䰰", num), flag ? "" : BookmarkStart.b("ܦ", num), str.TrimStart(new char[] { ' ' }));
                }
                A_2 = string.Format(BookmarkStart.b("尦ᤨ嘪嘬Ḯ䰰", num), A_2, str);
            }
        }
        return A_2;
    }

    private static void smethod_23(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
        string str = smethod_24(A_0, A_1);
        if (Class567.smethod_16(str))
        {
            smethod_12(A_0, A_1, A_2, str, A_3);
        }
    }

    private static string smethod_24(Class857 A_0, Paragraph A_1)
    {
        int num = 0x10;
        string str = A_0.method_11().method_3().Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' ');
        str = smethod_22(A_0, A_1, str).Replace('‑', '\x001e').Replace('\x00ad', '\x001f');
        string str2 = str.Trim(new char[] { ' ' });
        bool flag = A_1.ChildObjects.Count == 0;
        if (!Class567.smethod_16(str2))
        {
            if (Class567.smethod_16(str) && !flag)
            {
                Class857.string_4 = BookmarkStart.b("ᘵ", num);
            }
            return null;
        }
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < str2.Length; i++)
        {
            if (((i == (str2.Length - 1)) || (str2[i] != ' ')) || (str2[i + 1] != ' '))
            {
                builder.Append(str2[i]);
            }
        }
        if ((smethod_26(str) || Class567.smethod_16(Class857.string_4)) && !flag)
        {
            builder.Insert(0, ' ');
        }
        Class857.string_4 = smethod_25(str);
        return builder.ToString();
    }

    private static string smethod_25(string A_0)
    {
        int length = A_0.TrimEnd(new char[] { ' ' }).Length;
        return new string(' ', A_0.Length - length);
    }

    private static bool smethod_26(string A_0)
    {
        return (Class567.smethod_16(A_0) && (A_0[0] == ' '));
    }

    private static bool smethod_27(string A_0)
    {
        return (Class567.smethod_16(A_0) && (A_0[A_0.Length - 1] == ' '));
    }

    private static void smethod_3(Paragraph A_0)
    {
        HorizontalAlignment horizontalAlignment = A_0.Format.HorizontalAlignment;
        if (A_0.IsInCell)
        {
            TextDirection textDirection = ((TableCell) A_0.OwnerTextBody).CellFormat.TextDirection;
            VerticalAlignment verticalAlignment = ((TableCell) A_0.OwnerTextBody).CellFormat.VerticalAlignment;
            if (textDirection == TextDirection.RightToLeft)
            {
                if (verticalAlignment == VerticalAlignment.Bottom)
                {
                    switch (horizontalAlignment)
                    {
                        case HorizontalAlignment.Left:
                            ((TableCell) A_0.OwnerTextBody).CellFormat.VerticalAlignment = VerticalAlignment.Top;
                            break;

                        case HorizontalAlignment.Right:
                            A_0.Format.HorizontalAlignment = HorizontalAlignment.Left;
                            break;

                        case HorizontalAlignment.Center:
                            A_0.Format.HorizontalAlignment = HorizontalAlignment.Left;
                            ((TableCell) A_0.OwnerTextBody).CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                            break;
                    }
                }
                if (verticalAlignment == VerticalAlignment.Top)
                {
                    switch (horizontalAlignment)
                    {
                        case HorizontalAlignment.Left:
                            A_0.Format.HorizontalAlignment = HorizontalAlignment.Right;
                            break;

                        case HorizontalAlignment.Right:
                            ((TableCell) A_0.OwnerTextBody).CellFormat.VerticalAlignment = VerticalAlignment.Bottom;
                            break;
                    }
                }
                if (verticalAlignment == VerticalAlignment.Middle)
                {
                    switch (horizontalAlignment)
                    {
                        case HorizontalAlignment.Left:
                            A_0.Format.HorizontalAlignment = HorizontalAlignment.Center;
                            ((TableCell) A_0.OwnerTextBody).CellFormat.VerticalAlignment = VerticalAlignment.Top;
                            break;

                        case HorizontalAlignment.Right:
                            A_0.Format.HorizontalAlignment = HorizontalAlignment.Center;
                            ((TableCell) A_0.OwnerTextBody).CellFormat.VerticalAlignment = VerticalAlignment.Bottom;
                            break;
                    }
                }
                if ((verticalAlignment == VerticalAlignment.Top) && (horizontalAlignment == HorizontalAlignment.Center))
                {
                    A_0.Format.HorizontalAlignment = HorizontalAlignment.Right;
                    ((TableCell) A_0.OwnerTextBody).CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                }
            }
        }
    }

    private static void smethod_4(TabCollection A_0, TabCollection A_1)
    {
        if ((A_0 != null) && (A_1 != null))
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Tab tab = A_0[i].method_5();
                tab.Justification = TabJustification.Clear;
                A_1.method_6(tab);
            }
        }
    }

    private static void smethod_5(Paragraph A_0, Class97 A_1)
    {
        int num = 0x13;
        if ((A_0.Format.method_55(0x5aa) && (A_0.ChildObjects.Count != 0)) && (A_1 != null))
        {
            Paragraph paragraph = (Paragraph) A_0.Clone();
            A_0.Owner.method_18(paragraph, A_0);
            int length = (A_1.method_21() > 1) ? A_1.method_21() : 1;
            if (A_1.method_23())
            {
                length = Regex.Matches(A_0.Text, BookmarkStart.b("攸䰺ᘼ", num))[0].Length;
            }
            int num3 = 0;
            while (num3 < A_0.ChildObjects.Count)
            {
                if (length <= 0)
                {
                    break;
                }
                if (A_0.ChildObjects[num3] is TextRange)
                {
                    TextRange range2 = (TextRange) A_0.ChildObjects[num3];
                    TextRange entity = (TextRange) range2.Clone();
                    if (length >= range2.Text.Length)
                    {
                        range2.method_19();
                        length -= range2.Text.Length;
                    }
                    else
                    {
                        entity.Text = entity.Text.Substring(0, length);
                        range2.Text = range2.Text.Substring(length);
                        length = 0;
                        num3++;
                    }
                    paragraph.ChildObjects.Add(entity);
                }
            }
            paragraph.Format.SetAttr(0x5a0, DropCapPosition.Normal);
            paragraph.Format.SetAttr(0x53c, WrapMode.Square);
            if (A_0.HasChildElements)
            {
                A_0.Format.method_71(0x5aa);
            }
            else
            {
                A_0.method_19();
            }
        }
    }

    private static void smethod_6(Class857 A_0, Paragraph A_1)
    {
        Class396 class2 = A_0.method_11();
        class2.method_18();
        string str = class2.method_12(BookmarkStart.b("崱䄳䈵吷匹刻嬽洿⹁⅃ぅⵇ♉", 12), null);
        if (Class567.smethod_16(str))
        {
            A_1.Format.SetAttr(0x500, (byte) (Class1041.smethod_11(str) - 1));
        }
        else
        {
            A_1.Format.SetAttr(0x500, (byte) 9);
        }
    }

    private static void smethod_7(Class857 A_0)
    {
        A_0.method_4(A_0.method_11());
    }

    internal static void smethod_8(Class857 A_0, Paragraph A_1, string A_2, Class97 A_3, DocumentObject A_4)
    {
        int num = 14;
        Class396 class2 = A_0.method_11();
        string str = (A_2 == BookmarkStart.b("䜳䘵夷吹", 14)) ? BookmarkStart.b("䀳匵䀷丹", num) : BookmarkStart.b("䐳圵䨷嬹嬻䰽ℿ㉁ⱃ", num);
        Class96 class3 = (Class96) A_0.method_13().method_2(A_0.method_16(), str, A_0.method_20(), true);
        if (class3 == null)
        {
            class3 = (Class96) A_0.method_13().method_2(A_0.method_16(), str, A_0.method_20(), false);
        }
        CharacterFormat format = new CharacterFormat();
        if (((str == BookmarkStart.b("䀳匵䀷丹", num)) && (A_3 != null)) && (A_3.method_13() != null))
        {
            format.method_73(A_3.method_13());
        }
        Style style = null;
        if (class3 != null)
        {
            if (class3.method_13() != null)
            {
                format.method_73(class3.method_13());
            }
            if ((str == BookmarkStart.b("䀳匵䀷丹", num)) && Class567.smethod_16(class3.method_8()))
            {
                style = (Style) A_0.method_9().Styles[class3.method_8()];
            }
        }
        A_0.method_41(true);
        while (class2.method_10(A_2, XmlDocumentTextHandling.TextAndSignificantAndIgnorable))
        {
            if (!Class857.smethod_10(A_0, A_1, format, style))
            {
                string key = class2.method_1();
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_229 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                        dictionary1.Add("", 0);
                        dictionary1.Add(BookmarkStart.b("䜳", num), 1);
                        dictionary1.Add(BookmarkStart.b("䀳圵娷", num), 2);
                        dictionary1.Add(BookmarkStart.b("堳張嘷弹ᄻ尽㈿❁╃ⵅ", num), 3);
                        dictionary1.Add(BookmarkStart.b("䜳唵䨷匹䰻䨽", num), 4);
                        dictionary1.Add(BookmarkStart.b("䜳䘵夷吹", num), 5);
                        dictionary1.Add(BookmarkStart.b("娳夵䰷弹", num), 6);
                        dictionary1.Add(BookmarkStart.b("唳堵嘷唹䠻弽㐿⭁⭃⡅", num), 7);
                        dictionary1.Add(BookmarkStart.b("嘳夵圷儹儻弽㈿⥁", num), 8);
                        dictionary1.Add(BookmarkStart.b("嘳夵圷儹儻弽㈿⥁楃㕅㱇⭉㹋㩍", num), 9);
                        dictionary1.Add(BookmarkStart.b("嘳夵圷儹儻弽㈿⥁楃⍅♇⹉", num), 10);
                        dictionary1.Add(BookmarkStart.b("䘳䌵娷䌹", num), 11);
                        Class1160.dictionary_229 = dictionary1;
                    }
                    if (Class1160.dictionary_229.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                            {
                                smethod_23(A_0, A_1, format, style);
                                continue;
                            }
                            case 1:
                            {
                                smethod_16(A_0, A_1, format, style);
                                continue;
                            }
                            case 2:
                            {
                                smethod_17(A_0, A_1, format, style);
                                continue;
                            }
                            case 3:
                            {
                                smethod_12(A_0, A_1, format, Class816.string_6, style);
                                continue;
                            }
                            case 4:
                            {
                                smethod_9(A_0, A_1);
                                continue;
                            }
                            case 5:
                            {
                                smethod_18(A_0, A_1, A_3, A_4);
                                A_0.method_41(true);
                                continue;
                            }
                            case 6:
                            {
                                smethod_19(A_0, A_1, format);
                                A_0.method_41(true);
                                continue;
                            }
                            case 7:
                            {
                                smethod_21(A_0, A_1, format);
                                A_0.method_41(true);
                                continue;
                            }
                            case 8:
                            {
                                A_1.method_13(new BookmarkStart(A_0.method_9(), class2.method_12(BookmarkStart.b("娳圵唷弹", num), null)));
                                A_1.method_13(new BookmarkEnd(A_0.method_9(), class2.method_12(BookmarkStart.b("娳圵唷弹", num), null)));
                                A_0.method_41(true);
                                continue;
                            }
                            case 9:
                            {
                                A_1.method_13(new BookmarkStart(A_0.method_9(), class2.method_12(BookmarkStart.b("娳圵唷弹", num), null)));
                                A_0.method_41(true);
                                continue;
                            }
                            case 10:
                            {
                                A_1.method_13(new BookmarkEnd(A_0.method_9(), class2.method_12(BookmarkStart.b("娳圵唷弹", num), null)));
                                A_0.method_41(true);
                                continue;
                            }
                            case 11:
                            {
                                smethod_10(A_0, A_1, format, style);
                                continue;
                            }
                        }
                    }
                }
                if (Class567.smethod_16(Class857.string_4) && !smethod_27(A_1.Text))
                {
                    smethod_12(A_0, A_1, format, BookmarkStart.b("ᐳ", num), style);
                    Class857.string_4 = "";
                }
                if (Class797.smethod_0(A_0, A_1, format, style, A_3, A_4))
                {
                    A_0.method_41(true);
                }
                else
                {
                    smethod_8(A_0, A_1, class2.method_1(), A_3, A_4);
                }
            }
            else
            {
                A_0.method_41(true);
            }
        }
        if (((class3 != null) && (!A_1.HasChildElements || bool_0)) && ((class3.method_13() != null) && ((A_2 == BookmarkStart.b("䐳", num)) || (A_2 == BookmarkStart.b("尳", num)))))
        {
            A_1.BreakCharacterFormat.method_25(class3.method_13());
        }
    }

    private static void smethod_9(Class857 A_0, Paragraph A_1)
    {
        int num = 8;
        Class396 class2 = A_0.method_11();
        ShapeObject obj2 = new ShapeObject(A_0.method_9()) {
            ScriptType = BookmarkStart.b("娭唯䨱䀳ᤵ刷嬹䨻弽㌿⅁㙃⽅㡇㹉", 8)
        };
        while (class2.method_10(BookmarkStart.b("崭匯䀱崳䘵䰷", num), XmlDocumentTextHandling.TextAndSignificantAndIgnorable))
        {
            obj2.ScriptText = string.Format(BookmarkStart.b("唭/伱伳ܵ䔷", num), obj2.ScriptText, class2.method_3());
        }
        obj2.ShapePr.SetAttr(0x3b8, true);
        A_1.method_13(obj2);
    }
}

