using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Class81
{
    private const int int_0 = 2;
    private const int int_1 = 3;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("ᰳḵ朷䈹朻弽洿⑁瑃歅煇ᝉ㝋積ⵏ൑絓⩕灗ř[⥝䵟㵡㥣䵥坧䍩䕫", 14), RegexOptions.Compiled | RegexOptions.IgnoreCase);

    private Class81()
    {
    }

    internal static void smethod_0(Class582 A_0)
    {
        int num = 14;
        BuiltinDocumentProperties builtinDocumentProperties = A_0.Interface50.imethod_0().BuiltinDocumentProperties;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("瀳夵嬷伹儻嬽⸿㙁ᑃ㑅❇㩉⥋㱍⑏㭑ㅓ╕", num)))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_1 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1a);
                    dictionary1.Add(BookmarkStart.b("怳張䰷嘹夻", num), 0);
                    dictionary1.Add(BookmarkStart.b("朳䌵娷倹夻崽㐿", num), 1);
                    dictionary1.Add(BookmarkStart.b("申䌵䰷刹医䰽", num), 2);
                    dictionary1.Add(BookmarkStart.b("缳匵䄷䴹医䰽␿ㅁ", num), 3);
                    dictionary1.Add(BookmarkStart.b("瀳匵䬷夹主圽〿㙁ⵃ⥅♇", num), 4);
                    dictionary1.Add(BookmarkStart.b("砳圵䬷丹紻䬽㐿⩁⭃㑅", num), 5);
                    dictionary1.Add(BookmarkStart.b("昳匵丷匹伻圽⼿ⱁ", num), 6);
                    dictionary1.Add(BookmarkStart.b("申䘵䠷琹崻匽┿", num), 7);
                    dictionary1.Add(BookmarkStart.b("怳夵䰷嬹倻樽⤿⽁⅃", num), 8);
                    dictionary1.Add(BookmarkStart.b("砳圵䬷丹氻䰽⤿ⱁぃ⍅ⱇ", num), 9);
                    dictionary1.Add(BookmarkStart.b("眳䐵崷嬹䠻嬽␿", num), 10);
                    dictionary1.Add(BookmarkStart.b("砳圵䬷丹漻弽㘿❁⁃", num), 11);
                    dictionary1.Add(BookmarkStart.b("搳圵強弹伻", num), 12);
                    dictionary1.Add(BookmarkStart.b("挳夵䨷帹伻", num), 13);
                    dictionary1.Add(BookmarkStart.b("眳帵夷䠹崻崽㐿❁㙃㕅", num), 14);
                    dictionary1.Add(BookmarkStart.b("眳圵䰷弹嬻儽㈿㭁", num), 15);
                    dictionary1.Add(BookmarkStart.b("搳䐵崷䤹夻倽㐿⍁ぃ⽅❇⑉ੋ⅍≏㽑㕓≕", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("礳圵嘷嬹嬻嬽㈿", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("眳夵唷䨹崻倽㤿", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("猳䌵儷帹", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("簳伵䠷弹主刽⤿ⱁ⽃х⥇㥉⥋", num), 20);
                    dictionary1.Add(BookmarkStart.b("瘳伵䰷弹伻", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("砳張嘷弹伻", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("搳圵䨷嬹嬻䰽ℿ㉁ⱃ㕅", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("眳帵夷䠹崻崽㐿❁㙃㕅὇⍉㡋♍͏≑㕓㕕㵗⥙", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("戳匵䨷䤹唻儽⸿", num), 0x19);
                    Class1160.dictionary_1 = dictionary1;
                }
                if (Class1160.dictionary_1.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            builtinDocumentProperties.Title = class2.method_21();
                            continue;
                        }
                        case 1:
                        {
                            builtinDocumentProperties.Subject = class2.method_21();
                            continue;
                        }
                        case 2:
                        {
                            builtinDocumentProperties.Author = class2.method_21();
                            continue;
                        }
                        case 3:
                        {
                            builtinDocumentProperties.Keywords = class2.method_21();
                            continue;
                        }
                        case 4:
                        {
                            builtinDocumentProperties.Comments = class2.method_21();
                            continue;
                        }
                        case 5:
                        {
                            builtinDocumentProperties.LastAuthor = class2.method_21();
                            continue;
                        }
                        case 6:
                        {
                            builtinDocumentProperties.RevisionNumber = class2.method_22().ToString();
                            continue;
                        }
                        case 7:
                        {
                            builtinDocumentProperties.ApplicationName = class2.method_21();
                            continue;
                        }
                        case 8:
                        case 0x10:
                        case 0x13:
                        case 20:
                        case 0x18:
                        case 0x19:
                        {
                            continue;
                        }
                        case 9:
                        {
                            builtinDocumentProperties.LastPrinted = Class1041.smethod_3(class2.method_21());
                            continue;
                        }
                        case 10:
                        {
                            builtinDocumentProperties.CreateDate = Class1041.smethod_3(class2.method_21());
                            continue;
                        }
                        case 11:
                        {
                            builtinDocumentProperties.LastSaveDate = Class1041.smethod_3(class2.method_21());
                            continue;
                        }
                        case 12:
                        {
                            builtinDocumentProperties.PageCount = class2.method_22();
                            continue;
                        }
                        case 13:
                        {
                            builtinDocumentProperties.WordCount = class2.method_22();
                            continue;
                        }
                        case 14:
                        {
                            builtinDocumentProperties.CharCount = class2.method_22();
                            continue;
                        }
                        case 15:
                        {
                            builtinDocumentProperties.Category = class2.method_21();
                            continue;
                        }
                        case 0x11:
                        {
                            builtinDocumentProperties.Manager = class2.method_21();
                            continue;
                        }
                        case 0x12:
                        {
                            builtinDocumentProperties.Company = class2.method_21();
                            continue;
                        }
                        case 0x15:
                        {
                            builtinDocumentProperties.BytesCount = class2.method_22();
                            continue;
                        }
                        case 0x16:
                        {
                            builtinDocumentProperties.LinesCount = class2.method_22();
                            continue;
                        }
                        case 0x17:
                        {
                            builtinDocumentProperties.ParagraphCount = class2.method_22();
                            continue;
                        }
                    }
                }
            }
            class2.vmethod_1();
        }
    }

    internal static void smethod_1(Class582 A_0)
    {
        int num = 4;
        CustomDocumentProperties customDocumentProperties = A_0.Interface50.imethod_0().CustomDocumentProperties;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("椩夫崭䐯崱夳爵圷夹䤻匽┿ⱁぃᙅ㩇╉㱋⭍≏♑㵓㍕⭗", num)))
        {
            string name = smethod_2(class2.method_1());
            string str5 = null;
            string str6 = null;
            while (class2.method_19())
            {
                string str3 = class2.method_1();
                if (str3 != null)
                {
                    if (!(str3 == BookmarkStart.b("丩堫", num)))
                    {
                        if (str3 == BookmarkStart.b("䘩䔫䀭嬯", num))
                        {
                            str5 = class2.method_3();
                        }
                    }
                    else
                    {
                        str6 = class2.method_3();
                    }
                }
            }
            string str4 = class2.method_21();
            string str = str6;
            if (str != null)
            {
                if (str != BookmarkStart.b("天堫尭夯就匳", num))
                {
                    if (str != BookmarkStart.b("䰩䀫䄭儯䘱", num))
                    {
                        if (str != BookmarkStart.b("䠩䌫䄭尯圱唳堵", num))
                        {
                            if ((str == BookmarkStart.b("丩䴫娭唯昱崳嬵崷", num)) || (str == BookmarkStart.b("丩䴫娭唯昱崳嬵崷ᐹ䠻䐽", num)))
                            {
                                customDocumentProperties.Add(name, Class1041.smethod_3(str4));
                            }
                        }
                        else
                        {
                            customDocumentProperties.Add(name, class2.method_70(str4));
                        }
                    }
                    else
                    {
                        double num2 = Class1041.smethod_12(str4);
                        if (((int) num2) == num2)
                        {
                            customDocumentProperties.Add(name, (int) num2);
                        }
                        else
                        {
                            customDocumentProperties.Add(name, num2);
                        }
                    }
                }
                else
                {
                    DocumentProperty property = customDocumentProperties.Add(name, str4);
                    if (Class567.smethod_16(str5))
                    {
                        property.LinkSource = str5;
                    }
                }
            }
        }
    }

    private static string smethod_2(string A_0)
    {
        StringBuilder builder = new StringBuilder();
        foreach (Match match in regex_0.Matches(A_0))
        {
            string str = match.Groups[3].Value;
            if (Class567.smethod_16(str))
            {
                builder.Append(str);
            }
            else
            {
                builder.Append(smethod_3(match.Groups[2].Value));
            }
        }
        return builder.ToString();
    }

    private static char smethod_3(string A_0)
    {
        A_0 = A_0.Trim(new char[] { '_', 'x' });
        return (char) Class1041.smethod_26(A_0);
    }
}

