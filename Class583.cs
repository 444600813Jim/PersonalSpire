using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class583
{
    private Class583()
    {
    }

    internal static void smethod_0(CellFormat A_0, Interface52 A_1)
    {
        int num = 0x11;
        if ((A_0 != null) && (A_0.Count != 0))
        {
            WordAttrCollection attrs = A_0;
            Class398 class2 = A_1.imethod_1();
            class2.method_4(BookmarkStart.b("䀶̸伺帼漾㍀", num));
            if (attrs.FormatRevision != null)
            {
                WordAttrCollection attrs2 = (WordAttrCollection) attrs.Clone();
                attrs2.AcceptFormatRevision();
                smethod_1(attrs2, A_1);
                class2.vmethod_5(attrs.FormatRevision, BookmarkStart.b("䀶̸伺帼漾㍀Bⵄ♆❈ⱊ⡌", num), A_1.imethod_6());
                if (A_1.imethod_2())
                {
                    class2.method_4(BookmarkStart.b("䀶̸伺帼漾㍀", num));
                }
                smethod_1(attrs, A_1);
                if (A_1.imethod_2())
                {
                    class2.method_5();
                }
                class2.vmethod_8();
            }
            else
            {
                smethod_1(attrs, A_1);
            }
            class2.method_5();
        }
    }

    private static void smethod_1(AttrCollection A_0, Interface52 A_1)
    {
        int num = 14;
        bool flag = A_1.imethod_2();
        Class398 class2 = A_1.imethod_1();
        Class15 class3 = null;
        object obj2 = null;
        object obj3 = null;
        object obj4 = null;
        string str = null;
        string str2 = null;
        Border top = null;
        Border left = null;
        Border bottom = null;
        Border right = null;
        Border diagonalDown = null;
        Border diagonalUp = null;
        Border horizontal = null;
        Border vertical = null;
        Class16 class4 = null;
        object obj5 = null;
        string str3 = null;
        string str4 = null;
        string str5 = null;
        string str6 = null;
        string str7 = null;
        object obj6 = null;
        string str8 = null;
        object obj7 = null;
        object obj8 = null;
        for (int i = 0; i < A_0.Count; i++)
        {
            int num3 = A_0.method_18(i);
            object obj9 = A_0.method_19(i);
            int num4 = num3;
            if (num4 <= 0xbea)
            {
                if (num4 <= 0xbc6)
                {
                    switch (num4)
                    {
                        case 1:
                            top = (obj9 as Borders).Top;
                            left = (obj9 as Borders).Left;
                            bottom = (obj9 as Borders).Bottom;
                            right = (obj9 as Borders).Right;
                            diagonalDown = (obj9 as Borders).DiagonalDown;
                            diagonalUp = (obj9 as Borders).DiagonalUp;
                            horizontal = (obj9 as Borders).Horizontal;
                            vertical = (obj9 as Borders).Vertical;
                            break;

                        case 2:
                            str3 = ((obj9 as Paddings).Top >= 0f) ? A_1.imethod_1().method_23((obj9 as Paddings).Top, 20f).ToString() : BookmarkStart.b("г", num);
                            str4 = ((obj9 as Paddings).Left >= 0f) ? A_1.imethod_1().method_23((obj9 as Paddings).Left, 20f).ToString() : BookmarkStart.b("Գص7", num);
                            str5 = ((obj9 as Paddings).Bottom >= 0f) ? A_1.imethod_1().method_23((obj9 as Paddings).Bottom, 20f).ToString() : BookmarkStart.b("г", num);
                            str6 = ((obj9 as Paddings).Right >= 0f) ? A_1.imethod_1().method_23((obj9 as Paddings).Right, 20f).ToString() : BookmarkStart.b("Գص7", num);
                            break;

                        case 6:
                            obj4 = class2.method_23(obj9, 50f);
                            break;

                        case 0xbc4:
                            obj3 = class2.method_23(obj9, 20f);
                            break;

                        case 0xbc6:
                            obj2 = (FtsWidth) obj9;
                            break;
                    }
                }
                else if (num4 <= 0xbd6)
                {
                    switch (num4)
                    {
                        case 0xbcc:
                            class3 = (Class15) obj9;
                            break;

                        case 0xbd6:
                            str2 = Class859.smethod_5((CellMerge) obj9);
                            break;
                    }
                }
                else if (num4 != 0xbe0)
                {
                    if ((num4 == 0xbea) && (((TextDirection) obj9) != TextDirection.TopToBottom))
                    {
                        str7 = Class417.smethod_39((TextDirection) obj9, flag);
                    }
                }
                else
                {
                    str = Class859.smethod_5((CellMerge) obj9);
                }
            }
            else if (num4 <= 0xc6c)
            {
                switch (num4)
                {
                    case 0xbf4:
                    {
                        if (((VerticalAlignment) obj9) != VerticalAlignment.Top)
                        {
                            str8 = Class859.smethod_7((VerticalAlignment) obj9);
                        }
                        continue;
                    }
                    case 0xc62:
                    {
                        class4 = (Class16) obj9;
                        continue;
                    }
                }
                if ((num4 == 0xc6c) && !((bool) obj9))
                {
                    obj5 = true;
                }
            }
            else if (num4 <= 0xc94)
            {
                if (num4 == 0xc76)
                {
                    if ((bool) obj9)
                    {
                        obj6 = true;
                    }
                }
                else if ((num4 == 0xc94) && ((bool) obj9))
                {
                    obj7 = true;
                }
            }
            else
            {
                switch (num4)
                {
                    case 0xf3c:
                        obj8 = (short) obj9;
                        break;
                }
            }
        }
        if (((obj3 != null) || (obj4 != null)) && (obj2 != null))
        {
            if (((WidthType) obj2) == WidthType.Percentage)
            {
                class3 = new Class15((FtsWidth) obj2, (short) ((int) obj4));
                class2.method_53(BookmarkStart.b("䌳వ䰷夹欻", num), class3);
            }
            else if (((WidthType) obj2) == WidthType.Twip)
            {
                class3 = new Class15((FtsWidth) obj2, (short) ((int) obj3));
                class2.method_53(BookmarkStart.b("䌳వ䰷夹欻", num), class3);
            }
        }
        else if (class3 != null)
        {
            class2.method_53(BookmarkStart.b("䌳వ䰷夹欻", num), class3);
        }
        if (((str != BookmarkStart.b("䘳匵䬷丹崻䰽㐿", num)) && (obj8 != null)) && (((short) obj8) > 1))
        {
            class2.method_22(BookmarkStart.b("䌳వ強䠹唻娽ጿ㉁╃⡅", num), obj8);
        }
        string str9 = flag ? BookmarkStart.b("䌳వ倷眹夻䰽✿❁", num) : BookmarkStart.b("䌳వ倷圹夻䰽✿❁", num);
        if (str == BookmarkStart.b("圳夵嘷丹唻倽㔿❁", num))
        {
            class2.method_10(str9);
        }
        else
        {
            class2.method_24(str9, str);
        }
        string str10 = flag ? BookmarkStart.b("䌳వ丷眹夻䰽✿❁", num) : BookmarkStart.b("䌳వ丷圹夻䰽✿❁", num);
        if (str2 == BookmarkStart.b("圳夵嘷丹唻倽㔿❁", num))
        {
            class2.method_10(str10);
        }
        else
        {
            class2.method_24(str10, str2);
        }
        class2.method_46(BookmarkStart.b("䌳వ䰷夹縻儽㈿♁⅃㑅㭇", num), flag, new object[] { BookmarkStart.b("䌳వ䰷唹䰻", num), top, BookmarkStart.b("䌳వ吷弹娻䨽", num), left, BookmarkStart.b("䌳వ娷唹䠻䨽⼿⽁", num), bottom, BookmarkStart.b("䌳వ䨷匹嬻嘽㐿", num), right, BookmarkStart.b("䌳వ儷吹伻圽␿❁ృ", num), horizontal, BookmarkStart.b("䌳వ儷吹伻圽␿❁ቃ", num), vertical, BookmarkStart.b("䌳వ䰷嘹฻尽㈿", num), diagonalDown, BookmarkStart.b("䌳వ䰷䠹฻尽ⰿ", num), diagonalUp });
        class2.vmethod_4(class4);
        class2.method_22(BookmarkStart.b("䌳వ嘷唹欻䰽ℿ㉁", num), obj5);
        if (!(A_0.OwnerBase is TableCell) || !(A_0.OwnerBase as TableCell).CellFormat.SamePaddingsAsTable)
        {
            class2.method_50(BookmarkStart.b("䌳వ䰷夹焻弽㈿", num), str3, str4, str5, str6);
        }
        class2.method_24(flag ? BookmarkStart.b("䌳వ䰷弹䐻䨽п⭁㙃⍅⭇㹉╋⅍㹏", num) : BookmarkStart.b("䌳వ䰷弹䐻䨽ؿ⹁⭃ㅅ", num), str7);
        class2.method_22(BookmarkStart.b("䌳వ䰷夹稻圽㐿ᙁ⅃㹅㱇", num), obj6);
        class2.method_24(BookmarkStart.b("䌳వ丷笹倻圽✿ⱁ", num), str8);
        class2.method_22(BookmarkStart.b("䌳వ倷匹堻嬽ി⍁㙃ⵅ", num), obj7);
    }
}

