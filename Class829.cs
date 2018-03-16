using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class829
{
    private Class829()
    {
    }

    internal static void smethod_0(RowFormat A_0, Class581 A_1, bool A_2)
    {
        int num = 1;
        if (!A_2)
        {
            A_0.LayoutType = LayoutType.AutoFit;
            A_0.SetAttr(0x102c, TableStyleOptions.Default2003);
        }
        Class394 class2 = A_1.imethod_1();
        class2.method_18();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_151 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("匦䬨䜪縬嬮䠰弲倴", num), 0);
                    dictionary1.Add(BookmarkStart.b("匦䬨䜪崬缮䌰", num), 1);
                    dictionary1.Add(BookmarkStart.b("匦䬨䜪戬央吰䄲头嘶䤸", num), 2);
                    dictionary1.Add(BookmarkStart.b("匦䬨䜪缬嬮崰", num), 3);
                    dictionary1.Add(BookmarkStart.b("䔦䀨伪䐬礮堰䀲䀴嘶唸", num), 4);
                    dictionary1.Add(BookmarkStart.b("匦䬨䜪縬嬮䠰弲倴收嘸䰺缼帾⽀❂ᙄ⹆㍈⹊", num), 5);
                    dictionary1.Add(BookmarkStart.b("匦䬨䜪縬嬮䠰弲倴琶嘸场缼帾⽀❂ᙄ⹆㍈⹊", num), 6);
                    Class1160.dictionary_151 = dictionary1;
                }
                if (Class1160.dictionary_151.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                        {
                            int num2 = A_1.Interface58.imethod_0(class2.method_28(), 11);
                            A_0.Istd = num2;
                            continue;
                        }
                        case 1:
                        {
                            smethod_1(A_0, class2);
                            continue;
                        }
                        case 2:
                        {
                            if (class2.method_28() == BookmarkStart.b("椦䰨崪䠬崮", num))
                            {
                                A_0.Positioning.TableOverlap = false;
                            }
                            continue;
                        }
                        case 3:
                        {
                            class2.vmethod_1();
                            continue;
                        }
                        case 4:
                        {
                            A_0.Bidi = class2.method_31();
                            continue;
                        }
                        case 5:
                        {
                            A_0.SetAttr(0x1194, class2.method_30());
                            continue;
                        }
                        case 6:
                        {
                            A_0.SetAttr(0x119e, class2.method_30());
                            continue;
                        }
                    }
                }
            }
            smethod_3(A_0, A_1);
        }
    }

    private static void smethod_1(RowFormat A_0, Class394 A_1)
    {
        int num = 5;
        RowFormat.TablePositioning positioning = A_0.Positioning;
        A_0.method_53(true);
        float num2 = 0f;
        bool flag = false;
        while (A_1.method_19())
        {
            string key = A_1.method_1();
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_152 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("䜪䠬䤮䔰甲䜴堶吸漺堼䜾㕀", num), 0);
                    dictionary1.Add(BookmarkStart.b("太䐬䠮夰䜲猴䔶嘸嘺椼娾㥀㝂", num), 1);
                    dictionary1.Add(BookmarkStart.b("弪䈬弮眰䄲娴娶洸帺䔼䬾", num), 2);
                    dictionary1.Add(BookmarkStart.b("䤪䈬嬮䔰尲場然䬸吺值款⑀㭂ㅄ", num), 3);
                    dictionary1.Add(BookmarkStart.b("崪䠬崮䔰爲嬴吶儸吺似", num), 4);
                    dictionary1.Add(BookmarkStart.b("䌪䈬崮䬰爲嬴吶儸吺似", num), 5);
                    dictionary1.Add(BookmarkStart.b("弪伬䌮䄰欲昴䜶尸堺", num), 6);
                    dictionary1.Add(BookmarkStart.b("弪伬䌮䄰欲", num), 7);
                    dictionary1.Add(BookmarkStart.b("弪伬䌮䄰樲昴䜶尸堺", num), 8);
                    dictionary1.Add(BookmarkStart.b("弪伬䌮䄰樲", num), 9);
                    Class1160.dictionary_152 = dictionary1;
                }
                if (Class1160.dictionary_152.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                            num2 = A_1.method_62();
                            if (num2 != float.MaxValue)
                            {
                                positioning.DistanceFromLeft = num2;
                            }
                            break;

                        case 1:
                            num2 = A_1.method_62();
                            if (num2 != float.MaxValue)
                            {
                                positioning.DistanceFromRight = num2;
                            }
                            break;

                        case 2:
                            num2 = A_1.method_62();
                            if (num2 != float.MaxValue)
                            {
                                positioning.DistanceFromTop = num2;
                            }
                            break;

                        case 3:
                            num2 = A_1.method_62();
                            if (num2 != float.MaxValue)
                            {
                                positioning.DistanceFromBottom = num2;
                            }
                            break;

                        case 4:
                            flag = true;
                            positioning.VertRelationTo = Class417.smethod_12(A_1.method_3());
                            break;

                        case 5:
                        {
                            RelativeHorizontalPosition position = Class417.smethod_15(A_1.method_3());
                            positioning.HorizRelationTo = Class417.smethod_22(position);
                            break;
                        }
                        case 6:
                            positioning.HorizPositionAbs = Class417.smethod_17(A_1.method_3());
                            break;

                        case 7:
                            num2 = A_1.method_62();
                            if (num2 != float.MaxValue)
                            {
                                positioning.HorizPositionEx = num2;
                            }
                            break;

                        case 8:
                            goto Label_021E;

                        case 9:
                            goto Label_023B;
                    }
                }
            }
            continue;
        Label_021E:
            if (!flag)
            {
                positioning.VertRelationTo = VerticalRelation.Margin;
            }
            positioning.VertPositionAbs = Class417.smethod_20(A_1.method_3());
            continue;
        Label_023B:
            if (!flag)
            {
                positioning.VertRelationTo = VerticalRelation.Margin;
            }
            num2 = A_1.method_62();
            if (num2 != float.MaxValue)
            {
                positioning.VertPositionEx = num2;
            }
        }
    }

    internal static void smethod_2(RowFormat A_0, Class581 A_1)
    {
        int num = 9;
        Class394 class2 = A_1.imethod_1();
        while (class2.method_9(BookmarkStart.b("嬮匰弲攴䔶簸䌺", num)))
        {
            smethod_3(A_0, A_1);
        }
    }

    private static void smethod_3(RowFormat A_0, Class581 A_1)
    {
        int num = 4;
        Class394 class2 = A_1.imethod_1();
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_153 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("帩丫䈭术", num), 0);
                dictionary1.Add(BookmarkStart.b("䀩伫", num), 1);
                dictionary1.Add(BookmarkStart.b("帩丫䈭猯圱堳娵欷䨹崻崽⤿ⱁ⍃", num), 2);
                dictionary1.Add(BookmarkStart.b("帩丫䈭礯就倳", num), 3);
                dictionary1.Add(BookmarkStart.b("帩丫䈭爯崱䘳刵崷䠹伻", num), 4);
                dictionary1.Add(BookmarkStart.b("天䐫䨭", num), 5);
                dictionary1.Add(BookmarkStart.b("帩丫䈭簯匱䴳夵䴷丹", num), 6);
                dictionary1.Add(BookmarkStart.b("帩丫䈭猯圱堳娵男嬹主", num), 7);
                dictionary1.Add(BookmarkStart.b("帩丫䈭簯崱嬳崵", num), 8);
                dictionary1.Add(BookmarkStart.b("䬩䈫䀭弯䘱唳䈵儷唹刻", num), 9);
                Class1160.dictionary_153 = dictionary1;
            }
            if (Class1160.dictionary_153.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        class2.method_46(A_0);
                        return;

                    case 1:
                        A_0.HorizontalAlignment = Class859.smethod_0(class2.method_28());
                        return;

                    case 2:
                        A_0.SetAttr(0x10c2, class2.method_42());
                        return;

                    case 3:
                        A_0.SetAttr(0x10f4, class2.method_42());
                        return;

                    case 4:
                        smethod_4(A_0, class2);
                        return;

                    case 5:
                        A_0.SetAttr(0x10ea, class2.method_39());
                        return;

                    case 6:
                        smethod_5(A_0, class2);
                        return;

                    case 7:
                        smethod_6(A_0, class2);
                        return;

                    case 8:
                        A_0.SetAttr(0x102c, Class531.smethod_2(Class114.smethod_8(class2.method_28())));
                        return;

                    case 9:
                        Class519.smethod_10(A_1, A_0);
                        return;
                }
            }
        }
        class2.vmethod_1();
    }

    private static void smethod_4(RowFormat A_0, Class394 A_1)
    {
        int num = 0;
        Borders borders = A_0.Borders;
        while (A_1.method_9(BookmarkStart.b("別䨧䘩渫䄭䈯嘱儳䐵䬷", num)))
        {
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_154 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                    dictionary1.Add(BookmarkStart.b("別䜧娩", num), 0);
                    dictionary1.Add(BookmarkStart.b("䨥䴧䰩堫", num), 1);
                    dictionary1.Add(BookmarkStart.b("䐥䜧帩堫䄭崯", num), 2);
                    dictionary1.Add(BookmarkStart.b("吥䄧䴩䐫娭", num), 3);
                    dictionary1.Add(BookmarkStart.b("伥䘧天䔫䨭唯稱", num), 4);
                    dictionary1.Add(BookmarkStart.b("伥䘧天䔫䨭唯搱", num), 5);
                    Class1160.dictionary_154 = dictionary1;
                }
                if (Class1160.dictionary_154.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            A_1.method_36(borders.Top);
                            continue;
                        }
                        case 1:
                        {
                            A_1.method_36(borders.Left);
                            continue;
                        }
                        case 2:
                        {
                            A_1.method_36(borders.Bottom);
                            continue;
                        }
                        case 3:
                        {
                            A_1.method_36(borders.Right);
                            continue;
                        }
                        case 4:
                        {
                            A_1.method_36(borders.Horizontal);
                            continue;
                        }
                        case 5:
                        {
                            A_1.method_36(borders.Vertical);
                            continue;
                        }
                    }
                }
            }
            A_1.vmethod_1();
        }
    }

    private static void smethod_5(RowFormat A_0, Class394 A_1)
    {
        int num = 6;
        while (A_1.method_19())
        {
            string str;
            if (((str = A_1.method_1()) != null) && (str == BookmarkStart.b("堫圭䀯圱", num)))
            {
                A_0.LayoutType = (A_1.method_3() != BookmarkStart.b("樫䜭䠯圱倳", num)) ? LayoutType.AutoFit : LayoutType.Fixed;
            }
        }
    }

    private static void smethod_6(RowFormat A_0, Class394 A_1)
    {
        int num = 0x12;
        while (A_1.method_9(BookmarkStart.b("䰷堹倻紽┿⹁⡃୅⥇㡉", num)))
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䰷唹䰻", num))
                {
                    if (str != BookmarkStart.b("吷弹娻䨽", num))
                    {
                        if (!(str == BookmarkStart.b("娷唹䠻䨽⼿⽁", num)))
                        {
                            if (!(str == BookmarkStart.b("䨷匹嬻嘽㐿", num)))
                            {
                                goto Label_00B0;
                            }
                            A_0.Paddings.Right = A_1.method_42();
                        }
                        else
                        {
                            A_0.Paddings.Bottom = A_1.method_42();
                        }
                    }
                    else
                    {
                        A_0.Paddings.Left = A_1.method_42();
                    }
                }
                else
                {
                    A_0.Paddings.Top = A_1.method_42();
                }
                continue;
            }
        Label_00B0:
            A_1.vmethod_1();
        }
    }
}

