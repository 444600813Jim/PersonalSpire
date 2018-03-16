using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Text;

internal class Class519
{
    private static List<BookmarkStart> list_0 = new List<BookmarkStart>();

    private Class519()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        string str;
        int num = 12;
        Class584 class3 = new Class584(A_0.imethod_1());
        if (class3.method_10() && ((str = class3.method_9()) != null))
        {
            if (str == BookmarkStart.b("攱嬳䐵尷ᐹ縻儽⼿⥁⥃❅㩇ⅉ手ᵍ⑏㍑♓≕", num))
            {
                A_0.method_18()[class3.method_0()] = class3.method_2();
                BookmarkStart start = new BookmarkStart(A_0.Interface50.imethod_0(), class3.method_2());
                if ((class3.method_7() >= 0) && (class3.method_8() >= 0))
                {
                    start.ColumnFirst = class3.method_7();
                    start.ColumnLast = class3.method_8();
                }
                A_0.method_6(start);
            }
            else if (str == BookmarkStart.b("攱嬳䐵尷ᐹ縻儽⼿⥁⥃❅㩇ⅉ手୍㹏㙑", num))
            {
                string name = (string) A_0.method_18()[class3.method_0()];
                if (name != null)
                {
                    BookmarkEnd end = new BookmarkEnd(A_0.Interface50.imethod_0(), name);
                    A_0.method_6(end);
                    A_0.method_18().Remove(class3.method_0());
                }
            }
            else if (str == BookmarkStart.b("攱嬳䐵尷ᐹ缻儽ⴿ⽁⅃⡅㱇摉Ὃ㩍ㅏ⁑⁓", num))
            {
                smethod_3(A_0, class3);
            }
            else if (str == BookmarkStart.b("攱嬳䐵尷ᐹ缻儽ⴿ⽁⅃⡅㱇摉ो⁍㑏", num))
            {
                smethod_4(A_0, class3);
            }
            else if (str == BookmarkStart.b("攱嬳䐵尷ᐹ画倽㌿❁㙃㉅ⅇ╉≋", num))
            {
                if (A_0.stack_0 == null)
                {
                    A_0.stack_0 = new Stack<Class579>();
                }
                A_0.stack_0.Push(smethod_16(class3, EditRevisionType.Insertion));
                smethod_17(A_0);
                A_0.stack_0.Pop();
            }
            else if (str == BookmarkStart.b("攱嬳䐵尷ᐹ砻嬽ⰿ❁ぃ⽅❇⑉", num))
            {
                if (A_0.stack_0 == null)
                {
                    A_0.stack_0 = new Stack<Class579>();
                }
                A_0.stack_0.Push(smethod_16(class3, EditRevisionType.Deletion));
                smethod_17(A_0);
                A_0.stack_0.Pop();
            }
        }
    }

    internal static void smethod_1(Class581 A_0, Paragraph A_1)
    {
        smethod_2(A_0, A_1, null, null);
    }

    internal static void smethod_10(Class581 A_0, RowFormat A_1)
    {
        smethod_12(A_0, A_1, true);
    }

    internal static void smethod_11(Class581 A_0, RowFormat A_1)
    {
        smethod_12(A_0, A_1, false);
    }

    public static void smethod_12(Class581 A_0, RowFormat A_1, bool A_2)
    {
        string str;
        int num = 15;
        Class394 class2 = A_0.imethod_1();
        Class584 class3 = new Class584(class2);
        if (class3.method_10() && ((str = class3.method_9()) != null))
        {
            if (str == BookmarkStart.b("戴堶䬸强ጼ社⹀ㅂ⡄♆㵈㽊⑌ⅎ㙐", num))
            {
                while (class2.method_9(BookmarkStart.b("吴夶圸吺䤼帾㕀⩂⩄⥆", num)))
                {
                    string str2;
                    if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("嘴堶圸伺堼儾㕀", num)))
                    {
                        smethod_13(A_0, A_1, class3, A_2);
                    }
                    else
                    {
                        class2.vmethod_1();
                    }
                }
            }
            else if ((str != BookmarkStart.b("戴堶䬸强ጼ瘾⽀あ⁄㕆㵈≊≌ⅎ", num)) && (str != BookmarkStart.b("戴堶䬸强ጼ笾⑀⽂⁄㍆⁈⑊⍌", num)))
            {
            }
        }
    }

    private static void smethod_13(Class581 A_0, RowFormat A_1, Class584 A_2, bool A_3)
    {
        RowFormat format1 = (RowFormat) A_1.method_23();
        if (A_3)
        {
            Class829.smethod_0(A_1, A_0, false);
        }
        else
        {
            Class1131.smethod_0(A_1, A_0);
        }
    }

    private static void smethod_14(Class581 A_0, RowFormat A_1, Class584 A_2, EditRevisionType A_3)
    {
        int num = 1;
        switch (A_3)
        {
            case EditRevisionType.Insertion:
            case EditRevisionType.Deletion:
                return;
        }
        throw new ArgumentException(BookmarkStart.b("爦䜨个唬弮吰倲䄴制崸ᬺ似娾㝀⩂㙄⹆♈╊浌㭎⡐⍒ご祖", num));
    }

    public static void smethod_15(CharacterFormat A_0, Class581 A_1)
    {
        string str;
        int num = 14;
        Class394 class2 = A_1.imethod_1();
        Class584 class3 = new Class584(class2);
        if (class3.method_10() && ((str = class3.method_9()) != null))
        {
            if (str == BookmarkStart.b("挳夵䨷帹ሻ眽⸿ㅁ⅃㑅㱇⍉⍋⁍", num))
            {
                A_0.SetAttr(14, smethod_16(class3, EditRevisionType.Insertion));
            }
            else if (str == BookmarkStart.b("挳夵䨷帹ሻ稽┿⹁⅃㉅ⅇ╉≋", num))
            {
                A_0.SetAttr(12, smethod_16(class3, EditRevisionType.Deletion));
            }
            else if (str == BookmarkStart.b("挳夵䨷帹ሻ砽⼿ぁ⥃❅㱇㹉╋⁍㝏", num))
            {
                while (class2.method_9(BookmarkStart.b("唳堵嘷唹䠻弽㐿⭁⭃⡅", num)))
                {
                    string str3;
                    if (((str3 = class2.method_1()) != null) && (str3 == BookmarkStart.b("圳夵嘷丹夻倽㐿", num)))
                    {
                        while (class2.method_9(BookmarkStart.b("圳夵嘷丹夻倽㐿", num)))
                        {
                            string str2;
                            if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("䘳昵䨷", num)))
                            {
                                Class1146.smethod_1(A_1, A_0, class3);
                            }
                            else
                            {
                                class2.vmethod_1();
                            }
                        }
                    }
                    else
                    {
                        class2.vmethod_1();
                    }
                }
            }
        }
    }

    private static Class579 smethod_16(Class584 A_0, EditRevisionType A_1)
    {
        Class579 class2 = new Class579(A_1);
        class2.method_1(A_0.method_4());
        class2.method_3(A_0.method_1());
        return class2;
    }

    private static void smethod_17(Class581 A_0)
    {
        int num = 15;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("吴夶圸吺䤼帾㕀⩂⩄⥆", num)))
        {
            string str;
            string str2;
            if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("嘴堶圸伺堼儾㕀", num)))
            {
                goto Label_0077;
            }
            goto Label_008C;
        Label_0031:
            if ((str = class2.method_1()) != null)
            {
                if (!(str == BookmarkStart.b("䜴", num)))
                {
                    if (!(str == BookmarkStart.b("吴夶圸吺䤼帾㕀⩂⩄⥆", num)))
                    {
                        goto Label_0071;
                    }
                    smethod_0(A_0);
                }
                else
                {
                    Class249.smethod_0(A_0);
                }
                goto Label_0077;
            }
        Label_0071:
            class2.vmethod_1();
        Label_0077:
            if (class2.method_9(BookmarkStart.b("嘴堶圸伺堼儾㕀", num)))
            {
                goto Label_0031;
            }
            continue;
        Label_008C:
            class2.vmethod_1();
        }
    }

    internal static Comment smethod_18(CharacterFormat A_0, Class581 A_1)
    {
        int num = 14;
        Class394 class2 = A_1.imethod_1();
        Class584 class3 = new Class584(class2);
        if (!class3.method_11())
        {
            return null;
        }
        Comment comment = null;
        if ((A_1.method_25().Count > 0) && A_1.method_25().ContainsKey(class3.method_0()))
        {
            comment = A_1.method_25()[class3.method_0()];
        }
        else
        {
            comment = new Comment(A_1.Interface50.imethod_0());
            A_1.method_25().Add(class3.method_0(), comment);
        }
        comment.Format.CommentId = class3.method_0();
        comment.Format.Author = class3.method_4();
        comment.Format.Initial = class3.method_5();
        comment.Format.DateTime = class3.method_1();
        while (class2.method_9(BookmarkStart.b("唳堵嘷唹䠻弽㐿⭁⭃⡅", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("圳夵嘷丹夻倽㐿", num)))
            {
                Class629.smethod_0(A_1, comment.Body);
            }
            else
            {
                class2.vmethod_1();
            }
        }
        return comment;
    }

    internal static void smethod_2(Class581 A_0, Paragraph A_1, List<BookmarkStart> A_2, List<BookmarkEnd> A_3)
    {
        string str;
        int num = 10;
        Class584 class3 = new Class584(A_0.imethod_1());
        if (class3.method_10() && ((str = class3.method_9()) != null))
        {
            if (str == BookmarkStart.b("术崱䘳刵ᘷ砹医儽⬿⽁╃㑅⍇摉Ὃ㩍ㅏ⁑⁓", num))
            {
                A_0.method_18()[class3.method_0()] = class3.method_2();
                BookmarkStart item = new BookmarkStart(A_0.Interface50.imethod_0(), class3.method_2());
                if ((class3.method_7() >= 0) && (class3.method_8() >= 0))
                {
                    item.ColumnFirst = class3.method_7();
                    item.ColumnLast = class3.method_8();
                    list_0.Add(item);
                }
                if ((A_1 == null) && (A_2 != null))
                {
                    A_2.Add(item);
                }
                else
                {
                    A_1.Items.Add(item);
                }
            }
            else if (str == BookmarkStart.b("术崱䘳刵ᘷ砹医儽⬿⽁╃㑅⍇摉ो⁍㑏", num))
            {
                string name = (string) A_0.method_18()[class3.method_0()];
                if (name != null)
                {
                    BookmarkEnd end = new BookmarkEnd(A_0.Interface50.imethod_0(), name);
                    if (list_0.Count > 0)
                    {
                        BookmarkStart start = list_0[list_0.Count - 1];
                        list_0.RemoveAt(list_0.Count - 1);
                        if (start.IsTableColumnBookmark)
                        {
                            end.IsCellGroupBkmk = true;
                        }
                    }
                    if ((A_1 == null) && (A_3 != null))
                    {
                        A_3.Add(end);
                    }
                    else
                    {
                        A_1.Items.Add(end);
                    }
                    A_0.method_18().Remove(class3.method_0());
                }
            }
            else if (str == BookmarkStart.b("术崱䘳刵ᘷ猹刻䴽┿ぁぃ⽅❇⑉", num))
            {
                if (A_0.stack_0 == null)
                {
                    A_0.stack_0 = new Stack<Class579>();
                }
                A_0.stack_0.Push(smethod_16(class3, EditRevisionType.Insertion));
                smethod_17(A_0);
                A_0.stack_0.Pop();
            }
            else if (str == BookmarkStart.b("术崱䘳刵ᘷ縹夻刽┿㙁ⵃ⥅♇", num))
            {
                if (A_0.stack_0 == null)
                {
                    A_0.stack_0 = new Stack<Class579>();
                }
                A_0.stack_0.Push(smethod_16(class3, EditRevisionType.Deletion));
                smethod_17(A_0);
                A_0.stack_0.Pop();
            }
            else if (str == BookmarkStart.b("术崱䘳刵ᘷ礹医匽ⴿ❁⩃㉅晇᥉㡋⽍≏♑", num))
            {
                smethod_3(A_0, class3);
            }
            else if (str == BookmarkStart.b("术崱䘳刵ᘷ礹医匽ⴿ❁⩃㉅晇ཉ≋⩍", num))
            {
                smethod_4(A_0, class3);
            }
        }
    }

    private static void smethod_3(Class581 A_0, Class584 A_1)
    {
        Comment comment = null;
        CommentMark commentMarkStart = null;
        if ((A_0.method_25().Count > 0) && A_0.method_25().ContainsKey(A_1.method_0()))
        {
            comment = A_0.method_25()[A_1.method_0()];
        }
        else
        {
            comment = new Comment(A_0.Interface50.imethod_0());
            A_0.method_25().Add(A_1.method_0(), comment);
        }
        if (comment.CommentMarkStart != null)
        {
            commentMarkStart = A_0.method_25()[A_1.method_0()].CommentMarkStart;
        }
        else
        {
            commentMarkStart = new CommentMark(A_0.Interface50.imethod_0(), A_1.method_0(), CommentMarkType.CommentStart);
            comment.CommentMarkStart = commentMarkStart;
        }
        A_0.method_6(commentMarkStart);
    }

    private static void smethod_4(Class581 A_0, Class584 A_1)
    {
        if (((A_0.method_25().Count != 0) && A_0.method_25().ContainsKey(A_1.method_0())) && (A_0.method_25()[A_1.method_0()].CommentMarkEnd == null))
        {
            CommentMark mark = new CommentMark(A_0.Interface50.imethod_0(), A_1.method_0(), CommentMarkType.CommentEnd);
            A_0.method_25()[A_1.method_0()].CommentMarkEnd = mark;
            A_0.method_6(mark);
        }
    }

    public static void smethod_5(ParagraphFormat A_0, Class394 A_1)
    {
        string str;
        int num = 11;
        Class584 class2 = new Class584(A_1);
        if (class2.method_10() && (((str = class2.method_9()) != null) && !(str == BookmarkStart.b("昰尲䜴匶᜸爺匼䰾⑀ㅂㅄ⹆♈╊", num))))
        {
            bool flag1 = str == BookmarkStart.b("昰尲䜴匶᜸町䠼刾⍀♂㝄⹆❈ⱊ", num);
        }
    }

    internal static void smethod_6(Class578 A_0, string A_1)
    {
        int num = 0;
        int index = 0;
        StringBuilder builder = new StringBuilder();
        while (num < A_1.Length)
        {
            if (A_1[num] != '%')
            {
                break;
            }
            num++;
            builder.Append((char) (A_1[num] - '1'));
            A_0.method_10()[index] = (byte) builder.Length;
            num += 2;
            A_0.method_12()[index] = A_1[num] - '0';
            num += 2;
            A_0.method_11()[index] = (ListPatternType) (A_1[num] - '0');
            num += 2;
            if ((num < A_1.Length) && (A_1[num] != '%'))
            {
                builder.Append(A_1[num]);
                num++;
            }
            index++;
        }
        A_0.method_14(builder.ToString());
    }

    public static void smethod_7(Class581 A_0, ParagraphFormat A_1, CharacterFormat A_2)
    {
        string str;
        int num = 14;
        Class394 class2 = A_0.imethod_1();
        Class584 class3 = new Class584(class2);
        if ((class3.method_10() && ((str = class3.method_9()) != null)) && (str == BookmarkStart.b("挳夵䨷帹ሻ砽⼿ぁ⥃❅㱇㹉╋⁍㝏", num)))
        {
            while (class2.method_9(BookmarkStart.b("唳堵嘷唹䠻弽㐿⭁⭃⡅", num)))
            {
                string str2;
                if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("圳夵嘷丹夻倽㐿", num)))
                {
                    while (class2.method_9(BookmarkStart.b("圳夵嘷丹夻倽㐿", num)))
                    {
                        string str3;
                        if (((str3 = class2.method_1()) != null) && (str3 == BookmarkStart.b("䐳昵䨷", num)))
                        {
                            Class1146.smethod_0(A_0, A_1, A_2, class3);
                        }
                        else
                        {
                            class2.vmethod_1();
                        }
                    }
                }
                else
                {
                    class2.vmethod_1();
                }
            }
        }
    }

    public static void smethod_8(Class17 A_0, Class581 A_1)
    {
        string str2;
        int num = 0x13;
        Class394 class2 = A_1.imethod_1();
        Class584 class3 = new Class584(class2);
        if ((class3.method_10() && ((str2 = class3.method_9()) != null)) && (str2 == BookmarkStart.b("游吺似嬾潀Ղ⩄㕆⑈⩊㥌㭎㡐㵒㉔", num)))
        {
            while (class2.method_9(BookmarkStart.b("堸唺匼倾㕀≂ㅄ⹆♈╊", num)))
            {
                string str3;
                if (((str3 = class2.method_1()) != null) && (str3 == BookmarkStart.b("娸吺匼䬾⑀ⵂㅄ", num)))
                {
                    while (class2.method_9(BookmarkStart.b("娸吺匼䬾⑀ⵂㅄ", num)))
                    {
                        string str;
                        if (((str = class2.method_1()) == null) || (str != BookmarkStart.b("䨸帺帼䬾ᅀㅂ", num)))
                        {
                            class2.vmethod_1();
                        }
                    }
                }
                else
                {
                    class2.vmethod_1();
                }
            }
        }
    }

    public static void smethod_9(CellFormat A_0, Class581 A_1)
    {
        string str2;
        int num = 0x13;
        Class394 class2 = A_1.imethod_1();
        Class584 class3 = new Class584(class2);
        if ((class3.method_10() && ((str2 = class3.method_9()) != null)) && (str2 == BookmarkStart.b("游吺似嬾潀Ղ⩄㕆⑈⩊㥌㭎㡐㵒㉔", num)))
        {
            while (class2.method_9(BookmarkStart.b("堸唺匼倾㕀≂ㅄ⹆♈╊", num)))
            {
                string str;
                if (((str = class2.method_1()) == null) || (str != BookmarkStart.b("娸吺匼䬾⑀ⵂㅄ", num)))
                {
                    class2.vmethod_1();
                }
            }
        }
    }
}

