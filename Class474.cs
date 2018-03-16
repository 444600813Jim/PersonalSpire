using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class474
{
    private static readonly char[] char_0 = new char[] { 'H', 'M', 'S' };

    private Class474()
    {
    }

    internal static void smethod_0(Class857 A_0)
    {
        int num = 7;
        Class113 class2 = A_0.method_10().method_2(BookmarkStart.b("Ȭ䈮吰䜲吴ᤶ䄸嘺儼", 7));
        if (class2 != null)
        {
            Class396 class3 = new Class396(class2.method_3());
            A_0.method_12(class3);
            while (class3.method_9(BookmarkStart.b("䤬䀮到䘲場制圸伺ြ刾⑀㝂⑄", num)))
            {
                string str;
                if (((str = class3.method_1()) != null) && (str == BookmarkStart.b("䀬䨮䔰刲", num)))
                {
                    smethod_1(A_0);
                }
                else
                {
                    class3.vmethod_1();
                }
            }
        }
    }

    private static void smethod_1(Class857 A_0)
    {
        int num = 0x13;
        Class396 class2 = A_0.method_11();
        BuiltinDocumentProperties builtinDocumentProperties = A_0.method_9().BuiltinDocumentProperties;
        bool flag = true;
        while (A_0.method_11().method_9(BookmarkStart.b("吸帺䤼帾", num)))
        {
            string key = A_0.method_11().method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_45 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(15);
                    dictionary1.Add(BookmarkStart.b("常帺匼娾㍀≂ㅄ⡆㭈", num), 0);
                    dictionary1.Add(BookmarkStart.b("䴸帺值伾ⵀ≂ㅄ≆", num), 1);
                    dictionary1.Add(BookmarkStart.b("崸帺丼尾㍀⩂㕄㍆⁈⑊⍌", num), 2);
                    dictionary1.Add(BookmarkStart.b("䨸为弼唾⑀⁂ㅄ", num), 3);
                    dictionary1.Add(BookmarkStart.b("券帺䐼䠾⹀ㅂ⅄", num), 4);
                    dictionary1.Add(BookmarkStart.b("倸唺吼䬾⡀≂⥄橆⩈㥊⡌⹎═㱒❔", num), 5);
                    dictionary1.Add(BookmarkStart.b("娸䤺堼帾㕀ⱂ㝄", num), 6);
                    dictionary1.Add(BookmarkStart.b("䴸刺䤼匾⑀", num), 7);
                    dictionary1.Add(BookmarkStart.b("娸䤺堼帾㕀⩂⩄⥆摈⽊ⱌ㭎㑐", num), 8);
                    dictionary1.Add(BookmarkStart.b("崸娺䤼娾", num), 9);
                    dictionary1.Add(BookmarkStart.b("䤸䤺吼儾㕀湂⅄♆㵈⹊", num), 10);
                    dictionary1.Add(BookmarkStart.b("尸强吼䬾⡀ⵂ≄橆⩈㉊⹌⍎㑐⁒", num), 11);
                    dictionary1.Add(BookmarkStart.b("尸强吼䬾⡀ⵂ≄橆ⵈ㹊㽌⹎═㩒㩔㥖", num), 12);
                    dictionary1.Add(BookmarkStart.b("崸吺帼䨾ⱀ♂⭄㍆摈㡊㥌⹎═㩒♔⍖じ㡚", num), 13);
                    dictionary1.Add(BookmarkStart.b("䰸䠺堼䴾汀❂⁄ⅆ⁈╊⡌⭎", num), 14);
                    Class1160.dictionary_45 = dictionary1;
                }
                if (Class1160.dictionary_45.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            builtinDocumentProperties.ApplicationName = class2.method_21();
                            continue;
                        }
                        case 1:
                        {
                            smethod_4(A_0);
                            continue;
                        }
                        case 2:
                        {
                            builtinDocumentProperties.Comments = class2.method_21();
                            continue;
                        }
                        case 3:
                        {
                            builtinDocumentProperties.Subject = class2.method_21();
                            continue;
                        }
                        case 4:
                            goto Label_01FC;

                        case 5:
                        {
                            builtinDocumentProperties.Author = class2.method_21();
                            continue;
                        }
                        case 6:
                        {
                            builtinDocumentProperties.LastAuthor = class2.method_21();
                            continue;
                        }
                        case 7:
                        {
                            builtinDocumentProperties.Title = class2.method_21();
                            continue;
                        }
                        case 8:
                        {
                            builtinDocumentProperties.CreateDate = Class1041.smethod_3(class2.method_21());
                            continue;
                        }
                        case 9:
                        {
                            builtinDocumentProperties.LastSaveDate = Class1041.smethod_3(class2.method_21());
                            continue;
                        }
                        case 10:
                        {
                            builtinDocumentProperties.LastPrinted = Class1041.smethod_3(class2.method_21());
                            continue;
                        }
                        case 11:
                        {
                            builtinDocumentProperties.RevisionNumber = class2.method_22().ToString();
                            continue;
                        }
                        case 12:
                        {
                            builtinDocumentProperties.TotalEditingTime = TimeSpan.FromMinutes((double) smethod_2(class2.method_21()));
                            continue;
                        }
                        case 13:
                        {
                            smethod_5(A_0);
                            continue;
                        }
                        case 14:
                        {
                            smethod_3(A_0);
                            continue;
                        }
                    }
                }
            }
            goto Label_02F0;
        Label_01FC:
            if (!flag)
            {
                builtinDocumentProperties.Keywords = string.Format(BookmarkStart.b("䈸଺䀼ጾ", num), builtinDocumentProperties.Keywords);
            }
            builtinDocumentProperties.Keywords = string.Format(BookmarkStart.b("䈸଺䀼䐾灀㹂", num), builtinDocumentProperties.Keywords, class2.method_21());
            flag = false;
            continue;
        Label_02F0:
            A_0.method_11().vmethod_1();
        }
    }

    private static int smethod_2(string A_0)
    {
        int num = 0x12;
        A_0 = A_0.ToUpper();
        int index = A_0.IndexOf(BookmarkStart.b("样渹", 0x12));
        if (index != -1)
        {
            A_0 = A_0.Substring(index + 2);
            int num5 = A_0.IndexOf(BookmarkStart.b("瀷", num));
            int num4 = A_0.IndexOf(BookmarkStart.b("男", num));
            int num6 = A_0.IndexOf(BookmarkStart.b("欷", num));
            string[] strArray2 = A_0.Split(char_0);
            ArrayList list = new ArrayList();
            foreach (string str in strArray2)
            {
                if (Class567.smethod_16(str))
                {
                    list.Add(str);
                }
            }
            if (list.Count == 0)
            {
                return 0;
            }
            if (list.Count == 1)
            {
                if (num6 != -1)
                {
                    return (int) (Class1041.smethod_12(strArray2[0]) / 60.0);
                }
                if (num4 != -1)
                {
                    return (int) Class1041.smethod_12(strArray2[0]);
                }
                if (num5 != -1)
                {
                    return (int) (Class1041.smethod_12(strArray2[0]) * 60.0);
                }
            }
            if (list.Count == 2)
            {
                if ((num6 != -1) && (num4 != -1))
                {
                    return (int) (Class1041.smethod_12(strArray2[0]) + (Class1041.smethod_12(strArray2[1]) / 60.0));
                }
                if ((num6 != -1) && (num5 != -1))
                {
                    return (int) ((Class1041.smethod_12(strArray2[0]) * 60.0) + (Class1041.smethod_12(strArray2[1]) / 60.0));
                }
                if ((num4 != -1) && (num5 != -1))
                {
                    return (int) ((Class1041.smethod_12(strArray2[0]) * 60.0) + Class1041.smethod_12(strArray2[1]));
                }
            }
            if (list.Count == 3)
            {
                return (int) (((Class1041.smethod_12(strArray2[0]) * 60.0) + Class1041.smethod_12(strArray2[1])) + (Class1041.smethod_12(strArray2[2]) / 60.0));
            }
        }
        return 0;
    }

    private static void smethod_3(Class857 A_0)
    {
        int num = 3;
        Class396 class2 = A_0.method_11();
        class2.method_18();
        string key = "";
        string str2 = "";
        while (class2.method_19())
        {
            string str5 = class2.method_1();
            if (str5 != null)
            {
                if (!(str5 == BookmarkStart.b("䜨䨪䀬䨮", num)))
                {
                    if (str5 == BookmarkStart.b("弨䨪䄬娮吰Ḳ䄴丶䤸帺", num))
                    {
                        str2 = class2.method_3();
                    }
                }
                else
                {
                    key = class2.method_3();
                    if (A_0.method_9().CustomDocumentProperties[key] != null)
                    {
                        return;
                    }
                }
            }
        }
        DocumentProperty property = A_0.method_9().CustomDocumentProperties.dictionary_0.ContainsKey(key) ? A_0.method_9().CustomDocumentProperties.dictionary_0[key] : null;
        string str3 = class2.method_21();
        string str4 = str2;
        if (str4 != null)
        {
            if (str4 == BookmarkStart.b("䬨䐪䈬䌮吰刲嬴", num))
            {
                Class567.smethod_19(key, BookmarkStart.b("䜨䨪䀬䨮", num));
                Class567.smethod_20(Class1041.smethod_28(str3), BookmarkStart.b("弨䨪䄬娮吰", num));
                property = (property != null) ? property : A_0.method_9().CustomDocumentProperties.Add(key, str3);
                return;
            }
            if ((str4 == BookmarkStart.b("䴨䨪夬䨮", num)) || (str4 == BookmarkStart.b("崨䈪䀬䨮", num)))
            {
                Class567.smethod_19(key, BookmarkStart.b("䜨䨪䀬䨮", num));
                Class567.smethod_20(Class1041.smethod_3(str3), BookmarkStart.b("弨䨪䄬娮吰", num));
                property = (property != null) ? property : A_0.method_9().CustomDocumentProperties.Add(key, str3);
                return;
            }
            if (str4 == BookmarkStart.b("伨䜪䈬丮䔰", num))
            {
                Class567.smethod_19(key, BookmarkStart.b("䜨䨪䀬䨮", num));
                Class567.smethod_20(Class1041.smethod_12(str3), BookmarkStart.b("弨䨪䄬娮吰", num));
                property = (property != null) ? property : A_0.method_9().CustomDocumentProperties.Add(key, str3);
                return;
            }
        }
        Class567.smethod_19(key, BookmarkStart.b("䜨䨪䀬䨮", num));
        Class567.smethod_20(str3, BookmarkStart.b("弨䨪䄬娮吰", num));
        property = (property != null) ? property : A_0.method_9().CustomDocumentProperties.Add(key, str3);
    }

    private static void smethod_4(Class857 A_0)
    {
        int num = 12;
        Class396 class2 = A_0.method_11();
        BuiltinDocumentProperties properties = A_0.method_9().builtinDocumentProperties_0;
        while (class2.method_19())
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("娱䘳匵帷", num)))
            {
                properties.Template = class2.method_3();
            }
        }
    }

    private static void smethod_5(Class857 A_0)
    {
        int num = 12;
        Class396 class2 = A_0.method_11();
        BuiltinDocumentProperties properties = A_0.method_9().builtinDocumentProperties_0;
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䈱唳儵崷᜹弻儽㔿ⱁぃ", num))
                {
                    if (str != BookmarkStart.b("䈱唳䐵夷崹主弽〿⩁楃╅❇㽉≋㩍", num))
                    {
                        if (str != BookmarkStart.b("䀱嬳䄵ᔷ夹医䬽⸿㙁", num))
                        {
                            if (str != BookmarkStart.b("䔱嬳䐵尷᜹弻儽㔿ⱁぃ", num))
                            {
                                if (!(str == BookmarkStart.b("儱尳圵䨷嬹弻䨽┿ぁ楃╅❇㽉≋㩍", num)))
                                {
                                    if (str == BookmarkStart.b("就嬳堵ᔷ䴹吻圽㐿❁㝃㙅⥇⥉⥋捍㍏㩑㕓⑕㥗㥙⡛㭝቟佡ݣ॥ᵧѩᡫ", num))
                                    {
                                        properties.CharCount = class2.method_4();
                                    }
                                }
                                else
                                {
                                    properties.CharCountWithSpace = class2.method_4();
                                }
                            }
                            else
                            {
                                properties.WordCount = class2.method_4();
                            }
                        }
                        else
                        {
                            properties.LinesCount = class2.method_4();
                        }
                    }
                    else
                    {
                        properties.ParagraphCount = class2.method_4();
                    }
                }
                else
                {
                    properties.PageCount = class2.method_4();
                }
            }
        }
    }
}

