using Spire.Doc;
using System;
using System.Text;

internal class Class863
{
    private Class863()
    {
    }

    internal static void smethod_0(Document A_0, Class398 A_1, bool A_2)
    {
        smethod_1(A_0.BuiltinDocumentProperties, A_1, A_2);
        smethod_4(A_0.CustomDocumentProperties, A_1, A_2);
    }

    private static void smethod_1(BuiltinDocumentProperties A_0, Class398 A_1, bool A_2)
    {
        int num = 12;
        A_1.method_4(BookmarkStart.b("崱ำ爵圷夹䤻匽┿ⱁぃᙅ㩇╉㱋⭍≏♑㵓㍕⭗", 12));
        smethod_2(A_1, BookmarkStart.b("崱ำ戵儷丹倻嬽", 12), A_0.Title, A_2);
        smethod_2(A_1, BookmarkStart.b("崱ำ攵䴷堹嘻嬽⌿㙁", 12), A_0.Subject, A_2);
        smethod_2(A_1, BookmarkStart.b("崱ำ眵䴷丹吻儽㈿", 12), A_0.Author, A_2);
        smethod_2(A_1, BookmarkStart.b("崱ำ紵崷䌹䬻儽㈿♁㝃", 12), A_0.Keywords, A_2);
        smethod_2(A_1, BookmarkStart.b("崱ำ爵崷䤹弻䰽⤿㉁ぃ⽅❇⑉", 12), A_0.Comments, A_2);
        smethod_2(A_1, BookmarkStart.b("崱ำ稵夷䤹䠻缽㔿㙁ⱃ⥅㩇", 12), A_0.LastAuthor, A_2);
        A_1.method_11(BookmarkStart.b("崱ำ搵崷䰹唻䴽⤿ⵁ⩃", 12), A_0.RevisionNumber);
        A_1.method_13(BookmarkStart.b("崱ำ稵夷䤹䠻渽㈿⭁⩃㉅ⵇ⹉", 12), A_0.LastPrinted);
        A_1.method_13(BookmarkStart.b("崱ำ电䨷弹崻䨽┿♁", 12), A_0.CreateDate);
        A_1.method_13(BookmarkStart.b("崱ำ稵夷䤹䠻洽ℿ㑁⅃≅", 12), A_0.LastSaveDate);
        A_1.method_14(BookmarkStart.b("崱ำ昵夷崹夻䴽", 12), A_0.PageCount);
        A_1.method_14(BookmarkStart.b("崱ำ愵圷䠹堻䴽", 12), A_0.WordCount);
        A_1.method_14(BookmarkStart.b("崱ำ电倷嬹主弽⌿㙁⅃㑅㭇", 12), A_0.CharCount);
        smethod_2(A_1, BookmarkStart.b("崱ำ电夷丹夻夽⼿ぁ㵃", 12), A_0.Category, A_2);
        smethod_2(A_1, BookmarkStart.b("崱ำ笵夷吹崻夽┿ぁ", 12), A_0.Manager, A_2);
        smethod_2(A_1, BookmarkStart.b("崱ำ电圷圹䰻弽⸿㭁", 12), A_0.Company, A_2);
        if (A_0.BytesCount > 0)
        {
            A_1.method_14(BookmarkStart.b("崱ำ琵䄷丹夻䴽", num), A_0.BytesCount);
        }
        A_1.method_14(BookmarkStart.b("崱ำ稵儷吹夻䴽", num), A_0.LinesCount);
        A_1.method_14(BookmarkStart.b("崱ำ昵夷䠹崻夽㈿⍁㑃⹅㭇", num), A_0.ParagraphCount);
        A_1.method_5();
    }

    internal static void smethod_10(Class907 A_0, Class398 A_1, string A_2)
    {
        int num = 12;
        if (Class567.smethod_16(A_0.string_1))
        {
            A_1.method_33(BookmarkStart.b("䔱ำ堵圷瘹唻倽┿A㙃⍅⥇ⅉ㽋ཌྷ㙏♑ㅓ⑕", num), new object[] { BookmarkStart.b("䔱ำ娵夷吹嬻", num), A_2, BookmarkStart.b("䔱ำ䀵夷嘹", num), A_0.string_1 });
        }
        if (Class567.smethod_16(A_0.string_2))
        {
            A_1.method_33(BookmarkStart.b("䔱ำ堵圷瘹唻倽┿A㙃⍅⥇ⅉ㽋్㕏㑑㭓⑕㵗", num), new object[] { BookmarkStart.b("䔱ำ娵夷吹嬻", num), A_2, BookmarkStart.b("䔱ำ䀵夷嘹", num), A_0.string_2 });
        }
    }

    private static void smethod_2(Class398 A_0, string A_1, string A_2, bool A_3)
    {
        A_0.method_12(A_1, smethod_3(A_2, A_3));
    }

    private static string smethod_3(string A_0, bool A_1)
    {
        int num = 10;
        if (!A_1)
        {
            return A_0;
        }
        return A_0.Replace(BookmarkStart.b("ᴯἱ", num), BookmarkStart.b("ᴯሱ", num));
    }

    private static void smethod_4(CustomDocumentProperties A_0, Class398 A_1, bool A_2)
    {
        int num = 5;
        if (smethod_7(A_0))
        {
            A_1.method_4(BookmarkStart.b("䐪ᜬ氮䐰䀲䄴堶吸缺刼尾㑀⹂⁄⥆㵈ᭊ㽌⁎⅐㙒❔⍖じ㹚⹜", num));
            int num2 = 0;
            int count = A_0.Count;
            while (num2 < count)
            {
                DocumentProperty property = A_0[num2];
                if (smethod_8(property))
                {
                    smethod_5(property, A_1, A_2);
                }
                num2++;
            }
            A_1.method_5();
        }
    }

    private static void smethod_5(DocumentProperty A_0, Class398 A_1, bool A_2)
    {
        int num = 11;
        A_1.method_4(smethod_6(A_0.Name));
        switch (A_0.ValueType)
        {
            case PropertyValueType.Boolean:
                A_1.method_18(BookmarkStart.b("唰䜲༴匶䴸", num), BookmarkStart.b("匰尲娴嬶尸娺匼", num));
                A_1.method_15(A_0.ToBool() ? BookmarkStart.b("0", num) : BookmarkStart.b("İ", num));
                break;

            case PropertyValueType.Date:
                A_1.method_18(BookmarkStart.b("唰䜲༴匶䴸", num), BookmarkStart.b("唰刲䄴制洸刺值娾潀㝂㽄", num));
                A_1.method_15(Class1041.smethod_0(A_0.ToDateTime()));
                break;

            case PropertyValueType.Float:
            case PropertyValueType.Int:
                A_1.method_18(BookmarkStart.b("唰䜲༴匶䴸", num), BookmarkStart.b("地弲娴嘶䴸", num));
                A_1.method_15(A_0.ToString());
                break;

            case PropertyValueType.Double:
                A_1.method_18(BookmarkStart.b("唰䜲༴匶䴸", num), BookmarkStart.b("地弲娴嘶䴸", num));
                A_1.method_15(Class1041.smethod_44(A_0.ToDouble()));
                break;

            case PropertyValueType.String:
                A_1.method_18(BookmarkStart.b("唰䜲༴匶䴸", num), BookmarkStart.b("䈰䜲䜴帶圸尺", num));
                A_1.method_40(BookmarkStart.b("崰娲嬴尶", num), A_0.LinkSource);
                A_1.method_15(smethod_3(A_0.ToString(), A_2));
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("搰崲倴伶䤸帺帼䬾⑀❂敄㝆㭈⑊㵌⩎⍐❒ⱔ睖ⵘ≚ⵜ㩞你", num));
        }
        A_1.method_5();
    }

    private static string smethod_6(string A_0)
    {
        int num = 0x11;
        StringBuilder builder = new StringBuilder(BookmarkStart.b("堶̸", 0x11));
        for (int i = 0; i < A_0.Length; i++)
        {
            char c = A_0[i];
            if ((!char.IsLetter(c) && (c != '_')) && (c != '-'))
            {
                builder.Append(BookmarkStart.b("栶䄸", num));
                builder.Append(Class1041.smethod_41(c));
                builder.Append('_');
            }
            else
            {
                builder.Append(c);
            }
        }
        return builder.ToString();
    }

    internal static bool smethod_7(CustomDocumentProperties A_0)
    {
        if (A_0 != null)
        {
            int num = 0;
            int count = A_0.Count;
            while (num < count)
            {
                DocumentProperty property = A_0[num];
                if (smethod_8(property))
                {
                    return true;
                }
                num++;
            }
        }
        return false;
    }

    internal static bool smethod_8(DocumentProperty A_0)
    {
        if (A_0.Name.StartsWith(BookmarkStart.b("砦礨截椬瀮", 1)))
        {
            return false;
        }
        return smethod_9(A_0.ValueType);
    }

    private static bool smethod_9(PropertyValueType A_0)
    {
        switch (A_0)
        {
            case PropertyValueType.Boolean:
            case PropertyValueType.Date:
            case PropertyValueType.Float:
            case PropertyValueType.Double:
            case PropertyValueType.Int:
            case PropertyValueType.String:
                return true;
        }
        return false;
    }
}

