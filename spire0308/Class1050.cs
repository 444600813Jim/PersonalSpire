using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Globalization;

internal class Class1050
{
    private Class1050()
    {
    }

    internal static void smethod_0(Class857 A_0, bool A_1)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        string str = class2.method_1();
        Class102 class3 = new Class102();
        smethod_3(A_0, class3);
        bool flag = false;
        class2.method_18();
        bool flag2 = true;
        if (class2.method_12(BookmarkStart.b("匦嬨䨪䌬尮崰娲䄴制䬸娺䤼嘾⹀ⵂ桄ⅆ♈㥊⁌⹎═", 1), "") == BookmarkStart.b("❨", 1))
        {
            flag2 = false;
        }
        string str2 = class2.method_12(BookmarkStart.b("䬦䠨䔪䨬娮倰吲倴", num), "").ToLower();
        string str3 = class2.method_12(BookmarkStart.b("䐦䘨帪䌬嬮䌰䨲", num), "").ToUpper();
        if (!string.IsNullOrEmpty(str2) && !string.IsNullOrEmpty(str3))
        {
            class3.method_13().LocaleIdASCII = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), str2 + BookmarkStart.b("砦", num) + str3));
        }
        CultureInfo info = new CultureInfo(str2 + BookmarkStart.b("ਦ", num) + str3);
        string[] strArray = info.DateTimeFormat.SortableDateTimePattern.Replace(BookmarkStart.b("ਦ", num), "").Replace(BookmarkStart.b("ᴦ", num), "").Replace(BookmarkStart.b("&ศ", num), BookmarkStart.b("&", num)).Split(new char[] { '\'' });
        for (int i = 0; i < strArray.Length; i++)
        {
            strArray[i] = strArray[i].Substring(0, strArray[i].Length / 2);
        }
        while (class2.method_9(str))
        {
            CharacterFormat format;
            string key = class2.method_1();
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_222 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬Ȯ䄰䄲娴䜶尸䤺䤼嘾⑀あ", num), 0);
                    dictionary1.Add(BookmarkStart.b("匦䰨匪夬", num), 1);
                    dictionary1.Add(BookmarkStart.b("䌦䠨刪", num), 2);
                    dictionary1.Add(BookmarkStart.b("䨦䘨䔪夬䜮", num), 3);
                    dictionary1.Add(BookmarkStart.b("带䰨䨪弬", num), 4);
                    dictionary1.Add(BookmarkStart.b("䈦嬨䨪", num), 5);
                    dictionary1.Add(BookmarkStart.b("䌦䠨刪,䀮地Ḳ䈴制尸债", num), 6);
                    dictionary1.Add(BookmarkStart.b("伦䘨帪弬尮", num), 7);
                    dictionary1.Add(BookmarkStart.b("䘦䐨ت崬䈮", num), 8);
                    dictionary1.Add(BookmarkStart.b("䨦䀨䔪堬嬮吰䀲", num), 9);
                    dictionary1.Add(BookmarkStart.b("否䰨䠪䈬䄮唰䀲", num), 10);
                    Class1160.dictionary_222 = dictionary1;
                }
                if (Class1160.dictionary_222.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                            goto Label_02D1;

                        case 1:
                        {
                            class3.method_22(string.Format(BookmarkStart.b("尦ᤨ嘪嘬Ḯ䰰", num), class3.method_21(), class2.method_21()));
                            continue;
                        }
                        case 2:
                        {
                            smethod_1(class3, flag2 ? strArray[2] : BookmarkStart.b("昦", num));
                            continue;
                        }
                        case 3:
                        {
                            if (!flag2)
                            {
                                goto Label_0386;
                            }
                            smethod_1(class3, smethod_5(class2) ? (strArray[1] + smethod_6(class2, strArray[1])) : smethod_6(class2, strArray[1]));
                            continue;
                        }
                        case 4:
                        {
                            smethod_1(class3, flag2 ? smethod_6(class2, strArray[0]) : smethod_6(class2, BookmarkStart.b("戦氨", num)));
                            continue;
                        }
                        case 5:
                        {
                            smethod_1(class3, BookmarkStart.b("䀦", num));
                            continue;
                        }
                        case 6:
                        {
                            smethod_1(class3, smethod_6(class2, smethod_2(class3)));
                            continue;
                        }
                        case 7:
                        {
                            smethod_1(class3, smethod_6(class2, strArray[4]));
                            continue;
                        }
                        case 8:
                        {
                            smethod_1(class3, (class3.method_13().LocaleIdASCII == 0x804) ? BookmarkStart.b("䘦䐨嬪䀬", num) : BookmarkStart.b("䘦䐨Ъ崬䈮", num));
                            flag = true;
                            continue;
                        }
                        case 9:
                        {
                            smethod_1(class3, smethod_6(class2, strArray[5]));
                            continue;
                        }
                        case 10:
                        {
                            smethod_1(class3, smethod_6(class2, strArray[6]));
                            continue;
                        }
                    }
                }
            }
            goto Label_045D;
        Label_02D1:
            format = Class1141.smethod_0(A_0, class3);
            if (format.Count > 0)
            {
                if (class3.method_13() != null)
                {
                    class3.method_13().method_37(format);
                }
                class3.method_14(format);
            }
            continue;
        Label_0386:
            smethod_1(class3, BookmarkStart.b("栦", num));
            continue;
        Label_045D:
            class2.vmethod_1();
        }
        if (flag)
        {
            class3.method_22(class3.method_21().Replace(BookmarkStart.b("漦", num), BookmarkStart.b("伦", num)));
        }
        A_0.method_13().method_1(class3, A_0.method_20(), A_1);
    }

    private static void smethod_1(Class102 A_0, string A_1)
    {
        A_0.method_22(string.Format(BookmarkStart.b("临ܶ䐸䀺఼䈾", 15), A_0.method_21(), A_1));
    }

    private static string smethod_2(Class102 A_0)
    {
        int num = 0x10;
        switch (A_0.method_13().LocaleIdASCII)
        {
            case 0x411:
                return BookmarkStart.b("圵夷", num);

            case 0x804:
                return BookmarkStart.b("愵", num);
        }
        return BookmarkStart.b("刵尷", num);
    }

    private static void smethod_3(Class857 A_0, Class102 A_1)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        class2.method_18();
        string str = "";
        string str2 = "";
        while (class2.method_19())
        {
            string str3;
            if (!Class857.smethod_8(class2, A_1) && ((str3 = class2.method_1()) != null))
            {
                if (!(str3 == BookmarkStart.b("䘩䴫䀭圯䜱唳儵崷", num)))
                {
                    if (str3 == BookmarkStart.b("䤩䌫嬭帯䘱䘳伵", num))
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
        if (Class567.smethod_16(str) || Class567.smethod_16(str2))
        {
            if (A_1.method_13() == null)
            {
                A_1.method_14(new CharacterFormat());
            }
            A_1.method_13().SetAttr(380, (short) Class922.smethod_81(string.Format(BookmarkStart.b("儩ᰫ匭ᴯ䤱Գ䬵", num), str, str2)));
        }
    }

    private static bool smethod_4(Class396 A_0)
    {
        return (A_0.method_12(BookmarkStart.b("䨸伺䐼匾⑀", 0x13), BookmarkStart.b("䨸区刼䴾㕀", 0x13)).ToLower() == BookmarkStart.b("唸吺匼堾", 0x13));
    }

    private static bool smethod_5(Class396 A_0)
    {
        return (A_0.method_12(BookmarkStart.b("䄴制䄸伺䠼帾ⵀ", 15), BookmarkStart.b("匴嘶唸䠺堼", 15)).ToLower() == BookmarkStart.b("䄴䔶䰸帺", 15));
    }

    private static string smethod_6(Class396 A_0, string A_1)
    {
        int num = 13;
        if (smethod_4(A_0))
        {
            return string.Format(BookmarkStart.b("䠲Դ䨶䈸਺䀼", num), A_1, A_1);
        }
        return A_1;
    }
}

