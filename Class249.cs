using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class249
{
    private static readonly char[] char_0 = new char[] { ' ', '\t' };

    private Class249()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        smethod_1(A_0, null);
    }

    internal static void smethod_1(Class581 A_0, CharacterFormat A_1)
    {
        int num = 6;
        if (A_1 == null)
        {
            A_1 = new CharacterFormat(A_0.Interface50.imethod_0());
        }
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str;
            if (((str = class2.method_1()) != null) && (str != BookmarkStart.b("師崭夯嘱瀳匵吷", num)))
            {
                if (!(str == BookmarkStart.b("師崭夯嘱昳", num)))
                {
                    if (str == BookmarkStart.b("師崭夯嘱昳昵䨷", num))
                    {
                        int num3 = Class114.smethod_7(class2.method_3());
                        if (num3 != -2147483648)
                        {
                            A_1.SetAttr(30, num3);
                        }
                    }
                }
                else
                {
                    int num2 = Class114.smethod_7(class2.method_3());
                    if ((num2 != -2147483648) && (num2 != class2.method_58()))
                    {
                        A_1.SetAttr(40, num2);
                    }
                }
            }
        }
        smethod_2(A_0, A_1);
        smethod_4(A_0, A_1);
    }

    private static bool smethod_10(string A_0)
    {
        return (((A_0.Length > 0) && (A_0[0] == '\r')) && Class567.smethod_28(A_0));
    }

    internal static bool smethod_11(Class581 A_0, CharacterFormat A_1)
    {
        int num = 2;
        Class394 class2 = A_0.imethod_1();
        bool flag = true;
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_10 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("堧䌩伫娭", num), 0);
                dictionary1.Add(BookmarkStart.b("䜧䠩䘫䬭匯䘱", num), 1);
                dictionary1.Add(BookmarkStart.b("䰧堩䴫夭夯就匳", num), 2);
                dictionary1.Add(BookmarkStart.b("䨧堩", num), 3);
                dictionary1.Add(BookmarkStart.b("丧䘩䠫洭堯匱䘳", num), 4);
                dictionary1.Add(BookmarkStart.b("丧䘩䠫紭夯弱䐳娵崷", num), 5);
                dictionary1.Add(BookmarkStart.b("娧", num), 6);
                Class1160.dictionary_10 = dictionary1;
            }
            if (Class1160.dictionary_10.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        smethod_19(A_0, A_1);
                        return flag;

                    case 2:
                        smethod_21(A_0, A_1);
                        return flag;

                    case 3:
                        return flag;

                    case 4:
                        smethod_22(A_0, A_1);
                        return flag;

                    case 5:
                        Class802.smethod_0(A_0);
                        return flag;

                    case 6:
                        smethod_1(A_0, A_1);
                        return flag;
                }
            }
        }
        return false;
    }

    private static void smethod_12(Class581 A_0)
    {
        A_0.method_5(DocumentObjectType.Paragraph);
        if (!A_0.vmethod_5())
        {
            Class1080.smethod_0(A_0);
        }
        A_0.method_3(new Paragraph(A_0.Interface50.imethod_0()));
    }

    internal static void smethod_13(Class581 A_0)
    {
        A_0.method_5(DocumentObjectType.Paragraph);
        if (!A_0.vmethod_5())
        {
            Class518.smethod_0(A_0, null, null, null, null);
        }
        A_0.method_3(new Paragraph(A_0.Interface50.imethod_0()));
    }

    private static void smethod_14(Class581 A_0, CharacterFormat A_1, char A_2)
    {
        smethod_4(A_0, A_1);
        A_0.method_9(new TextRange(A_0.Interface50.imethod_0(), A_2.ToString(), A_1));
    }

    private static void smethod_15(Class581 A_0, CharacterFormat A_1)
    {
        smethod_4(A_0, A_1);
        CharacterFormat format = (CharacterFormat) A_1.method_23();
        char ch = A_0.imethod_1().method_34(format);
        A_0.method_9(new TextRange(A_0.Interface50.imethod_0(), ch.ToString(), format));
    }

    private static void smethod_16(Class581 A_0, CharacterFormat A_1, FootnoteType A_2)
    {
        Footnote footnote;
        int num = 12;
        smethod_4(A_0, A_1);
        int num2 = -1;
        bool flag = false;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("嬱倳", num))
                {
                    if (str != BookmarkStart.b("䘱䴳䘵崷", num))
                    {
                        if (!(str == BookmarkStart.b("儱䄳䔵䰷唹儻猽ℿぁ⽃E❇♉⁋⅍❏⅑", num)))
                        {
                            if (str == BookmarkStart.b("䄱䄳䘵䠷䠹夻䴽㌿၁⅃⁅", num))
                            {
                                flag = class2.method_63();
                            }
                        }
                        else
                        {
                            flag = class2.method_63();
                        }
                    }
                }
                else
                {
                    num2 = class2.method_4();
                }
            }
        }
        if (A_0.vmethod_5())
        {
            footnote = A_0.vmethod_2(A_2, num2);
        }
        else
        {
            footnote = new Footnote(A_0.Interface50.imethod_0()) {
                FootnoteType = A_2
            };
            Class629.smethod_0(A_0, footnote.TextBody);
        }
        if (footnote != null)
        {
            footnote.IsAutoNumbered = !flag;
            footnote.MarkerCharacterFormat.ImportContainer(A_1);
            if (flag)
            {
                smethod_17(A_0, A_1, class2, footnote);
            }
            A_0.method_9(footnote);
        }
    }

    private static void smethod_17(Class581 A_0, CharacterFormat A_1, Class394 A_2, Footnote A_3)
    {
        int num = 0x11;
        if (!A_2.method_9(BookmarkStart.b("䔶", 0x11)))
        {
            throw new InvalidOperationException(BookmarkStart.b("戶圸娺弼匾⑀捂ㅄ⡆楈ⵊ⑌ⅎ㕐獒㍔㡖㙘⽚㍜ぞᕠ٢䕤ᕦ౨൪࡬ᵮᑰᵲᙴቶ奸ᙺᱼൾ궂", num));
        }
        if (((A_2.method_1() == BookmarkStart.b("䌶", num)) && A_2.method_10(BookmarkStart.b("䌶", num), XmlDocumentTextHandling.TextAndSignificant)) && (A_2.method_1() == ""))
        {
            A_3.CustomMarker = A_2.method_3();
        }
        else if (A_2.method_1() == BookmarkStart.b("唶䬸", num))
        {
            A_3.CustomMarker = smethod_25(A_2, A_1).ToString();
        }
        else
        {
            if (A_2.method_1() != BookmarkStart.b("䐶䀸嘺", num))
            {
                throw new InvalidOperationException(BookmarkStart.b("戶圸䠺䠼伾ㅀⱂ㝄㍆ⱈ⽊浌⥎㹐㱒⅔㥖㙘⽚㡜罞፠٢ͤɦ᭨๪ͬ౮ᑰ卲ᡴᙶ୸ၺ卼", num));
            }
            A_3.CustomMarker = Class742.smethod_2(A_0.imethod_1().method_34(A_1)).ToString();
        }
    }

    private static void smethod_18(Class581 A_0, CharacterFormat A_1)
    {
        Comment comment;
        int num = 0x13;
        smethod_4(A_0, A_1);
        if (A_0.vmethod_5())
        {
            int num2 = A_0.imethod_1().method_13(BookmarkStart.b("倸强", num), 0);
            comment = A_0.vmethod_4(num2);
        }
        else
        {
            comment = Class519.smethod_18(A_1, A_0);
        }
        if (comment != null)
        {
            A_0.method_9(comment);
            comment.CharacterFormat.method_25(A_1);
        }
    }

    private static void smethod_19(Class581 A_0, CharacterFormat A_1)
    {
        smethod_4(A_0, A_1);
        ShapeBase base2 = Class964.smethod_4(A_0);
        if (base2 != null)
        {
            base2.ApplyCharacterFormat(A_1);
            if (base2.ShapeType == ShapeType.OleObject)
            {
                DocOleObject oleFormat = (base2 as ShapeObject).OleFormat;
                oleFormat.SetOlePicture((base2 as ShapeObject).ImageData);
                A_0.method_9(oleFormat);
                smethod_20(oleFormat, A_0);
            }
            else if (base2.ShapeType == ShapeType.TextBox)
            {
                TextBox internerTextbox = (base2 as ShapeObject).InternerTextbox;
                A_0.method_9(internerTextbox);
            }
            else if ((base2.ShapeType == ShapeType.Image) || (base2 as ShapeObject).HasImage)
            {
                DocPicture imageData = (base2 as ShapeObject).ImageData;
                imageData.IsShape = true;
                A_0.method_9(imageData);
            }
            else
            {
                base2.CharacterFormat.method_25(A_1);
                A_0.method_9(base2);
            }
        }
    }

    private static void smethod_2(Class581 A_0, CharacterFormat A_1)
    {
        int num = 12;
        Class394 class2 = A_0.imethod_1();
        class2.method_18();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_9 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x19);
                    dictionary1.Add(BookmarkStart.b("䀱搳䐵", num), 0);
                    dictionary1.Add(BookmarkStart.b("䘱", num), 1);
                    dictionary1.Add(BookmarkStart.b("嘱儳娵氷弹䐻䨽", num), 2);
                    dictionary1.Add(BookmarkStart.b("嬱娳䔵䰷䠹栻嬽㠿㙁", num), 3);
                    dictionary1.Add(BookmarkStart.b("嘱儳娵焷吹伻䨽㈿ᙁ⅃㹅㱇", num), 4);
                    dictionary1.Add(BookmarkStart.b("䘱唳吵", num), 5);
                    dictionary1.Add(BookmarkStart.b("䄱嬳倵䰷爹䔻丽⠿❁⩃", num), 6);
                    dictionary1.Add(BookmarkStart.b("就嬳琵䨷弹崻唽࠿㭁㑃⹅ⵇ⑉", num), 7);
                    dictionary1.Add(BookmarkStart.b("䄱䴳嬵", num), 8);
                    dictionary1.Add(BookmarkStart.b("圱娳刵嘷唹䠻嬽ሿ❁≃⍅㩇⽉≋ⵍ㕏", num), 9);
                    dictionary1.Add(BookmarkStart.b("圱娳刵嘷唹䠻嬽", num), 10);
                    dictionary1.Add(BookmarkStart.b("吱嬳夵䰷吹医䨽┿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), 11);
                    dictionary1.Add(BookmarkStart.b("吱嬳夵䰷吹医䨽┿", num), 12);
                    dictionary1.Add(BookmarkStart.b("吱嬳夵䰷吹医䨽┿၁⅃⁅", num), 13);
                    dictionary1.Add(BookmarkStart.b("圱娳刵嘷唹䠻嬽ሿ❁≃", num), 14);
                    dictionary1.Add(BookmarkStart.b("䄱儳䘵夷䠹崻䨽⼿ぁ", num), 15);
                    dictionary1.Add(BookmarkStart.b("儱嬳堵䰷匹刻䬽ℿ㙁ⵃ⥅♇᥉⥋㹍ㅏ⁑㕓≕㝗⡙", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("儱嬳嬵唷弹刻䨽ሿ❁≃⍅㩇⽉≋ⵍ㕏", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("匱娳堵圷丹崻䨽⤿ⵁ⩃", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("匱娳堵圷丹崻䨽⤿ⵁ⩃ᑅⵇⱉ", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䈱匳砵䴷圹", num), 20);
                    dictionary1.Add(BookmarkStart.b("猱堳䈵崷䠹刻弽㐿❁݃⥅♇㹉⥋⁍⑏", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䈱䀳圵娷", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("儱䘳", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("倱䘳", num), 0x18);
                    Class1160.dictionary_9 = dictionary1;
                }
                if (Class1160.dictionary_9.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            Class733.smethod_0(A_0, A_1);
                            continue;
                        }
                        case 1:
                        case 2:
                        {
                            smethod_8(A_0, A_1);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 3:
                        case 4:
                        {
                            smethod_6(A_0, A_1);
                            A_0.imethod_1().bool_0 = false;
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 5:
                        {
                            class2.method_51().Append(Class816.string_9);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 6:
                        {
                            class2.method_51().Append(Class816.string_21);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 7:
                        {
                            class2.method_51().Append(Class816.string_12);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 8:
                        {
                            smethod_15(A_0, A_1);
                            continue;
                        }
                        case 9:
                        case 10:
                        {
                            smethod_16(A_0, A_1, FootnoteType.Endnote);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 11:
                        case 12:
                        {
                            smethod_16(A_0, A_1, FootnoteType.Footnote);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 13:
                        case 14:
                        {
                            smethod_14(A_0, A_1, '\x0002');
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 15:
                        {
                            smethod_14(A_0, A_1, '\x0003');
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 0x10:
                        {
                            smethod_14(A_0, A_1, '\x0004');
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 0x11:
                        case 0x12:
                        {
                            smethod_18(A_0, A_1);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 0x13:
                        case 0x15:
                        {
                            continue;
                        }
                        case 20:
                        {
                            smethod_23(A_0, A_1);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 0x16:
                        {
                            smethod_3(A_0, A_1);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                        case 0x17:
                        case 0x18:
                        {
                            smethod_24(A_0, A_1);
                            smethod_4(A_0, A_1);
                            continue;
                        }
                    }
                }
            }
            if (!smethod_11(A_0, A_1))
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_20(DocOleObject A_0, Class581 A_1)
    {
        FieldMark mark = new FieldMark(A_1.Interface50.imethod_0()) {
            Type = FieldMarkType.FieldSeparator
        };
        A_1.method_9(mark);
        DocPicture picture = A_0.Interface49.get_OlePicture();
        A_1.method_9(picture);
        FieldMark mark2 = new FieldMark(A_1.Interface50.imethod_0()) {
            Type = FieldMarkType.FieldEnd
        };
        A_1.method_9(mark2);
    }

    private static void smethod_21(Class581 A_0, CharacterFormat A_1)
    {
        smethod_4(A_0, A_1);
    }

    private static void smethod_22(Class581 A_0, CharacterFormat A_1)
    {
        smethod_4(A_0, A_1);
        Class250.smethod_0(A_0, A_1);
    }

    private static void smethod_23(Class581 A_0, CharacterFormat A_1)
    {
    }

    private static void smethod_24(Class581 A_0, CharacterFormat A_1)
    {
        int num = 0x12;
        BreakType lineBreak = BreakType.LineBreak;
        LineBreakClear none = LineBreakClear.None;
        bool flag = A_0.imethod_1().method_1().ToLower() == BookmarkStart.b("嬷䠹", 0x12);
        while (A_0.imethod_1().method_19())
        {
            string str = A_0.imethod_1().method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䰷䌹䰻嬽", num)))
                {
                    if (str == BookmarkStart.b("嬷嘹夻弽㈿", num))
                    {
                        none = Class860.smethod_11(A_0.imethod_1().method_3());
                    }
                }
                else
                {
                    lineBreak = Class860.smethod_13(A_0.imethod_1().method_3());
                }
            }
        }
        Break @break = new Break(A_0.Interface50.imethod_0(), lineBreak);
        if (lineBreak == BreakType.LineBreak)
        {
            @break.TextRange.Text = BookmarkStart.b("㌷", num);
        }
        @break.ClearType = none;
        if (flag)
        {
            @break.IsCrBreak = true;
        }
        if (A_1 != null)
        {
            @break.TextRange.ApplyCharacterFormat(A_1);
        }
        if ((A_0.imethod_1().method_57() != null) && (A_0.imethod_1().method_57() is MergeField))
        {
            A_0.imethod_1().method_51().Append(Class816.string_27);
        }
        else
        {
            A_0.method_9(@break);
        }
    }

    private static char smethod_25(Class394 A_0, CharacterFormat A_1)
    {
        int num = 4;
        BreakType lineBreak = BreakType.LineBreak;
        while (A_0.method_19())
        {
            string str = A_0.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("帩唫席唯", num)))
                {
                    if (str == BookmarkStart.b("䤩䀫䬭儯䀱", num))
                    {
                        A_1.SetAttr(0x2d, Class860.smethod_11(A_0.method_3()));
                    }
                }
                else
                {
                    lineBreak = Class860.smethod_13(A_0.method_3());
                }
            }
        }
        return smethod_26(lineBreak);
    }

    private static char smethod_26(BreakType A_0)
    {
        switch (A_0)
        {
            case BreakType.PageBreak:
                return '\f';

            case BreakType.ColumnBreak:
                return '\x000e';
        }
        return '\v';
    }

    private static bool smethod_27(DocumentObject A_0)
    {
        return false;
    }

    private static void smethod_3(Class581 A_0, CharacterFormat A_1)
    {
        Class394 class2 = A_0.imethod_1();
        new Tab(A_0.Interface50.imethod_0());
        while (class2.method_19())
        {
        }
    }

    private static void smethod_4(Class581 A_0, CharacterFormat A_1)
    {
        Class394 class2 = A_0.imethod_1();
        if (class2.method_51().Length > 0)
        {
            TextRange range = null;
            string str2 = class2.method_51().ToString();
            if (class2.method_57() is MergeField)
            {
                range = class2.method_57();
                string str = str2;
                if (((A_1 != null) && A_1.Bidi) && (str != null))
                {
                    str = smethod_5(str);
                    A_1.Bidi = false;
                }
                if (range.Text == string.Empty)
                {
                    range.Text = str;
                    range.ApplyCharacterFormat(A_1);
                }
                else
                {
                    range.Text = range.Text + str;
                }
                class2.method_51().Length = 0;
            }
            else if (Class567.smethod_16(str2))
            {
                range = new TextRange(A_0.Interface50.imethod_0(), str2, A_1);
                A_0.method_9(range);
                class2.method_51().Length = 0;
            }
        }
    }

    private static string smethod_5(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        string str = string.Empty;
        for (int i = chArray.Length - 1; i >= 0; i--)
        {
            str = str + chArray[i].ToString();
        }
        return str;
    }

    private static void smethod_6(Class581 A_0, CharacterFormat A_1)
    {
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_1();
        while (class2.method_10(str, XmlDocumentTextHandling.TextAndSignificant))
        {
            string str2 = class2.method_3();
            switch (str2)
            {
                case null:
                case string.Empty:
                    return;
            }
            Field field = smethod_7(str2, A_0.Interface50.imethod_0());
            if (!class2.bool_0 && (class2.method_57() != null))
            {
                int index = -1;
                if ((class2.method_57() != null) && (class2.method_57().NextSibling == null))
                {
                    index = (A_0.method_13() as Paragraph).ChildObjects.IndexOf(class2.method_57());
                }
                if (((class2.method_53() != FieldCharType.Seperate) && (index >= 0)) && (index == ((A_0.method_13() as Paragraph).ChildObjects.Count - 1)))
                {
                    Field field3 = class2.method_57();
                    field3.Code = field3.Code + str2;
                    if (class2.method_57().Type == FieldType.FieldUnknown)
                    {
                        Field field2 = class2.method_54().Pop();
                        (A_0.method_13() as Paragraph).method_20(field2);
                        field2 = smethod_7(field2.Code, A_0.Interface50.imethod_0());
                        if (A_1 != null)
                        {
                            field2.ApplyCharacterFormat(A_1);
                        }
                        field2.IsLocked = class2.method_55();
                        class2.method_56(false);
                        A_0.method_9(field2);
                        if (class2.method_57() != field2)
                        {
                            class2.method_54().Push(field2);
                        }
                    }
                }
                else
                {
                    TextRange range = new TextRange(A_0.Interface50.imethod_0());
                    if (A_1 != null)
                    {
                        range.ApplyCharacterFormat(A_1);
                    }
                    range.Text = str2;
                    A_0.method_9(range);
                }
                return;
            }
            if (A_1 != null)
            {
                field.CharacterFormat.method_73(A_1);
            }
            field.IsLocked = class2.method_55();
            class2.method_56(false);
            A_0.method_9(field);
            class2.method_54().Push(field);
        }
    }

    private static Field smethod_7(string A_0, Document A_1)
    {
        int num = 12;
        Field field = null;
        string str = A_0.Trim();
        FieldType type = Class819.smethod_2(str);
        FieldType type2 = type;
        if (type2 <= FieldType.FieldMergeField)
        {
            if (type2 != FieldType.FieldIf)
            {
                if (type2 != FieldType.FieldMergeField)
                {
                    goto Label_005C;
                }
                field = new MergeField(A_1);
            }
            else
            {
                field = new IfField(A_1);
            }
            goto Label_0113;
        }
        switch (type2)
        {
            case FieldType.FieldFormTextInput:
            case FieldType.FieldFormCheckBox:
            case FieldType.FieldFormDropDown:
            {
                string str2 = str.ToUpper();
                if (str2 != null)
                {
                    if ((str2 == BookmarkStart.b("昱焳渵氷猹爻渽ᔿᙁ", num)) || (str2 == BookmarkStart.b("琱笳搵男渹礻昽ᐿ", num)))
                    {
                        field = new TextFormField(A_1);
                    }
                    else if ((str2 == BookmarkStart.b("瘱瀳稵焷椹栻", num)) || (str2 == BookmarkStart.b("琱笳搵男縹渻焽ဿفୃᅅه", num)))
                    {
                        field = new DropDownFormField(A_1);
                    }
                    else if ((str2 == BookmarkStart.b("焱簳猵笷焹縻焽ᠿ", num)) || (str2 == BookmarkStart.b("琱笳搵男礹琻笽̿ुكॅ၇", num)))
                    {
                        field = new CheckBoxFormField(A_1);
                    }
                }
                (field as FormField).HasFFData = false;
                goto Label_0113;
            }
        }
    Label_005C:
        field = new Field(A_1);
    Label_0113:
        field.Code = field.Code + A_0;
        if (!(field is FormField))
        {
            field.Type = type;
        }
        return field;
    }

    private static void smethod_8(Class581 A_0, CharacterFormat A_1)
    {
        int num = 6;
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_1();
        bool flag = (A_0.method_22() || (class2.method_12(BookmarkStart.b("弫席儯儱儳", num), "") == BookmarkStart.b("尫尭唯䄱儳䐵丷弹", num))) || (str != BookmarkStart.b("堫", num));
        while (class2.method_10(str, XmlDocumentTextHandling.TextAndSignificant))
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (str2 == "")
                {
                    string str3 = class2.method_3().Replace(Class816.string_4, Class816.string_11);
                    str3.TrimStart(new char[] { '\n' });
                    str3 = str3.Replace(Class816.string_3, Class816.string_11);
                    if (!flag)
                    {
                        str3 = str3.Trim(char_0).Replace('\t', ' ');
                    }
                    if (smethod_9(str3))
                    {
                        smethod_14(A_0, A_1, str3[0]);
                    }
                    else if (!smethod_10(str3))
                    {
                        class2.method_51().Append(str3);
                    }
                }
                else if (str2 != BookmarkStart.b("䈫䄭爯䀱儳圵匷爹䔻丽⠿❁⩃", num))
                {
                    if (str2 != BookmarkStart.b("丫尭", num))
                    {
                        if (!(str2 == BookmarkStart.b("尫", num)))
                        {
                            if (!(str2 == BookmarkStart.b("堫䰭尯", num)))
                            {
                                goto Label_01A5;
                            }
                            smethod_12(A_0);
                        }
                        else
                        {
                            smethod_13(A_0);
                        }
                    }
                    else
                    {
                        class2.method_51().Append(Class816.string_6);
                    }
                }
                else
                {
                    class2.method_51().Append(Class816.string_12);
                }
                continue;
            }
        Label_01A5:
            smethod_11(A_0, A_1);
        }
    }

    private static bool smethod_9(string A_0)
    {
        return ((A_0.Length == 1) && (A_0[0] == ' '));
    }
}

