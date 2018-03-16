using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class1131
{
    private Class1131()
    {
    }

    internal static void smethod_0(RowFormat A_0, Class581 A_1)
    {
        int num = 5;
        Class394 class2 = A_1.imethod_1();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_230 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                    dictionary1.Add(BookmarkStart.b("䠪䌬䤮戰䜲䰴嬶尸", num), 0);
                    dictionary1.Add(BookmarkStart.b("伪䐬央砰圲", num), 1);
                    dictionary1.Add(BookmarkStart.b("尪漬䨮地尲䜴制", num), 2);
                    dictionary1.Add(BookmarkStart.b("尪氬䤮䔰嘲䜴", num), 3);
                    dictionary1.Add(BookmarkStart.b("䰪弬䘮唰焲倴儶嘸䤺堼", num), 4);
                    dictionary1.Add(BookmarkStart.b("䰪弬䘮唰爲匴䌶尸䤺", num), 5);
                    dictionary1.Add(BookmarkStart.b("䠪䰬䄮䔰怲䔴嬶倸伺", num), 6);
                    dictionary1.Add(BookmarkStart.b("弪弬朮吰娲刴弶䴸", num), 7);
                    dictionary1.Add(BookmarkStart.b("弪伬䌮礰嘲吴匶尸䤺", num), 8);
                    dictionary1.Add(BookmarkStart.b("弪伬䌮爰嘲头嬶樸䬺尼尾⡀ⵂ≄", num), 9);
                    dictionary1.Add(BookmarkStart.b("䄪丬", num), 10);
                    dictionary1.Add(BookmarkStart.b("䨪䌬䄮帰䜲吴䌶倸吺匼", num), 11);
                    Class1160.dictionary_230 = dictionary1;
                }
                if (Class1160.dictionary_230.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            class2.method_26();
                            continue;
                        }
                        case 1:
                        {
                            class2.vmethod_1();
                            continue;
                        }
                        case 2:
                        {
                            smethod_1(A_0.GridBeforeWidth, class2.method_44());
                            continue;
                        }
                        case 3:
                        {
                            smethod_1(A_0.GridAfterWidth, class2.method_44());
                            continue;
                        }
                        case 4:
                        {
                            A_0.GridBefore = class2.method_29();
                            continue;
                        }
                        case 5:
                        {
                            A_0.GridAfter = class2.method_29();
                            continue;
                        }
                        case 6:
                        {
                            A_0.IsBreakAcrossPages = !class2.method_31();
                            continue;
                        }
                        case 7:
                        {
                            smethod_2(A_0, class2);
                            continue;
                        }
                        case 8:
                        {
                            A_0.IsHeader = class2.method_31();
                            continue;
                        }
                        case 9:
                        {
                            A_0.CellSpacingEx = class2.method_42();
                            continue;
                        }
                        case 10:
                        {
                            A_0.HorizontalAlignment = Class859.smethod_0(class2.method_28());
                            continue;
                        }
                        case 11:
                        {
                            Class519.smethod_11(A_1, A_0);
                            continue;
                        }
                    }
                }
            }
            class2.vmethod_1();
        }
    }

    private static void smethod_1(Class15 A_0, PreferredWidth A_1)
    {
        Class15 class2 = A_0;
        FtsWidth auto = FtsWidth.Auto;
        switch (A_1.Type)
        {
            case WidthType.Percentage:
                auto = FtsWidth.Percentage;
                break;

            case WidthType.Twip:
                auto = FtsWidth.Point;
                break;
        }
        class2.method_52(auto);
        class2.method_50((float) A_1.Value);
    }

    private static void smethod_2(RowFormat A_0, Class394 A_1)
    {
        int num = 10;
        bool flag = false;
        bool flag2 = false;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("堯ἱ䘳䌵吷弹", num)))
                {
                    if (str == BookmarkStart.b("䘯匱堳", num))
                    {
                        A_0.OwnerRow.Height = A_1.method_62();
                        flag2 = true;
                    }
                }
                else
                {
                    A_0.OwnerRow.HeightType = Class859.smethod_2(A_1.method_3());
                    flag = true;
                }
            }
        }
        if (flag2 && !flag)
        {
            A_0.HeightType = TableRowHeightType.AtLeast;
        }
    }
}

