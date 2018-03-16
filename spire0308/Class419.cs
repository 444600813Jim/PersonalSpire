using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class419
{
    private Class419()
    {
    }

    internal static void smethod_0(Class581 A_0, CellFormat A_1)
    {
        int num = 0;
        Class394 class2 = A_0.imethod_1();
        A_1.SetAttr(0xc6c, true);
        A_1.SetAttr(0xc76, false);
        A_1.SetAttr(0xbe0, CellMerge.None);
        A_1.SetAttr(0xbd6, CellMerge.None);
        A_1.SetAttr(0xbf4, VerticalAlignment.Top);
        A_1.SetAttr(0xbea, TextDirection.TopToBottom);
        class2.method_18();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            string str2;
            string str3;
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_33 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x12);
                    dictionary1.Add(BookmarkStart.b("䔥䘧䰩缫娭䤯帱儳", num), 0);
                    dictionary1.Add(BookmarkStart.b("別䬧紩", num), 1);
                    dictionary1.Add(BookmarkStart.b("䄥娧䌩䠫紭䀯匱娳", num), 2);
                    dictionary1.Add(BookmarkStart.b("严䔧伩師䤭唯", num), 3);
                    dictionary1.Add(BookmarkStart.b("严攧伩師䤭唯", num), 4);
                    dictionary1.Add(BookmarkStart.b("倥䔧伩師䤭唯", num), 5);
                    dictionary1.Add(BookmarkStart.b("倥攧伩師䤭唯", num), 6);
                    dictionary1.Add(BookmarkStart.b("別䬧栩䌫尭启圱䘳䔵", num), 7);
                    dictionary1.Add(BookmarkStart.b("唥䀧丩", num), 8);
                    dictionary1.Add(BookmarkStart.b("䠥䜧紩師伭䀯", num), 9);
                    dictionary1.Add(BookmarkStart.b("严䄧丩䤫挭儯䀱弳", num), 10);
                    dictionary1.Add(BookmarkStart.b("別䬧朩䴫尭", num), 11);
                    dictionary1.Add(BookmarkStart.b("別䴧利堫栭尯崱䌳", num), 12);
                    dictionary1.Add(BookmarkStart.b("別䴧利堫樭夯䀱儳唵䰷匹医倽", num), 13);
                    dictionary1.Add(BookmarkStart.b("別䬧氩䔫娭搯圱䰳䈵", num), 14);
                    dictionary1.Add(BookmarkStart.b("倥椧䘩䔫䤭帯", num), 15);
                    dictionary1.Add(BookmarkStart.b("別䬧稩師洭堯匱娳儵崷", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷", num), 0x11);
                    Class1160.dictionary_33 = dictionary1;
                }
                if (Class1160.dictionary_33.TryGetValue(key, out num2))
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
                            class2.method_45(A_1);
                            continue;
                        }
                        case 2:
                        {
                            short num3 = (short) class2.method_29();
                            A_1.GridSpan = num3;
                            continue;
                        }
                        case 3:
                        case 4:
                            goto Label_0291;

                        case 5:
                        case 6:
                            goto Label_02C6;

                        case 7:
                        {
                            smethod_1(class2, A_1);
                            continue;
                        }
                        case 8:
                        {
                            A_1.SetAttr(0xc62, class2.method_39());
                            continue;
                        }
                        case 9:
                        {
                            A_1.SetAttr(0xc6c, !class2.method_31());
                            continue;
                        }
                        case 10:
                        {
                            A_1.SetAttr(0xc94, class2.method_31());
                            continue;
                        }
                        case 11:
                        {
                            A_1.SamePaddingsAsTable = false;
                            smethod_2(class2, A_1);
                            continue;
                        }
                        case 12:
                        case 13:
                        {
                            A_1.SetAttr(0xbea, Class417.smethod_38(class2.method_28()));
                            continue;
                        }
                        case 14:
                        {
                            A_1.SetAttr(0xc76, class2.method_31());
                            continue;
                        }
                        case 15:
                        {
                            A_1.SetAttr(0xbf4, Class859.smethod_6(class2.method_28()));
                            continue;
                        }
                        case 0x10:
                        {
                            continue;
                        }
                        case 0x11:
                        {
                            Class519.smethod_9(A_1, A_0);
                            continue;
                        }
                    }
                }
            }
            goto Label_03BA;
        Label_0291:
            str3 = class2.method_28();
            if (str3 == null)
            {
                str3 = BookmarkStart.b("䔥䜧䐩堫䜭帯䜱儳", num);
            }
            A_1.SetAttr(0xbe0, Class859.smethod_4(str3));
            continue;
        Label_02C6:
            str2 = class2.method_28();
            if (str2 == null)
            {
                str2 = BookmarkStart.b("䔥䜧䐩堫䜭帯䜱儳", num);
            }
            A_1.SetAttr(0xbd6, Class859.smethod_4(str2));
            continue;
        Label_03BA:
            class2.vmethod_1();
        }
    }

    private static void smethod_1(Class394 A_0, CellFormat A_1)
    {
        int num = 8;
        while (A_0.method_9(BookmarkStart.b("娭匯瀱嬳䐵尷弹主䴽", num)))
        {
            string key = A_0.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_34 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("娭弯䈱", num), 0);
                    dictionary1.Add(BookmarkStart.b("䈭唯吱䀳", num), 1);
                    dictionary1.Add(BookmarkStart.b("崭䐯匱䘳䈵", num), 2);
                    dictionary1.Add(BookmarkStart.b("䰭弯䘱䀳夵唷", num), 3);
                    dictionary1.Add(BookmarkStart.b("尭夯唱尳䈵", num), 4);
                    dictionary1.Add(BookmarkStart.b("䬭帯嘱", num), 5);
                    dictionary1.Add(BookmarkStart.b("娭尯1嘳䐵", num), 6);
                    dictionary1.Add(BookmarkStart.b("娭䈯1嘳娵", num), 7);
                    dictionary1.Add(BookmarkStart.b("䜭帯䄱崳刵崷爹", num), 8);
                    dictionary1.Add(BookmarkStart.b("䜭帯䄱崳刵崷氹", num), 9);
                    Class1160.dictionary_34 = dictionary1;
                }
                if (Class1160.dictionary_34.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            A_0.method_35(A_1.Borders.Top);
                            continue;
                        }
                        case 1:
                        case 2:
                        {
                            A_0.method_35(A_1.Borders.Left);
                            continue;
                        }
                        case 3:
                        {
                            A_0.method_35(A_1.Borders.Bottom);
                            continue;
                        }
                        case 4:
                        case 5:
                        {
                            A_0.method_35(A_1.Borders.Right);
                            continue;
                        }
                        case 6:
                        {
                            A_0.method_35(A_1.Borders.DiagonalDown);
                            continue;
                        }
                        case 7:
                        {
                            A_0.method_35(A_1.Borders.DiagonalUp);
                            continue;
                        }
                        case 8:
                        {
                            A_0.method_35(A_1.Borders.Horizontal);
                            continue;
                        }
                        case 9:
                        {
                            A_0.method_35(A_1.Borders.Vertical);
                            continue;
                        }
                    }
                }
            }
            A_0.vmethod_1();
        }
    }

    private static void smethod_2(Class394 A_0, CellFormat A_1)
    {
        int num = 0x12;
        while (A_0.method_9(BookmarkStart.b("䰷夹焻弽㈿", num)))
        {
            string key = A_0.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_35 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                    dictionary1.Add(BookmarkStart.b("䰷唹䰻", num), 0);
                    dictionary1.Add(BookmarkStart.b("吷弹娻䨽", num), 1);
                    dictionary1.Add(BookmarkStart.b("䬷丹崻䰽㐿", num), 2);
                    dictionary1.Add(BookmarkStart.b("娷唹䠻䨽⼿⽁", num), 3);
                    dictionary1.Add(BookmarkStart.b("䨷匹嬻嘽㐿", num), 4);
                    dictionary1.Add(BookmarkStart.b("崷吹堻", num), 5);
                    Class1160.dictionary_35 = dictionary1;
                }
                if (Class1160.dictionary_35.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            A_1.Paddings.Top = A_0.method_42();
                            continue;
                        }
                        case 1:
                        case 2:
                        {
                            A_1.Paddings.Left = A_0.method_42();
                            continue;
                        }
                        case 3:
                        {
                            A_1.Paddings.Bottom = A_0.method_42();
                            continue;
                        }
                        case 4:
                        case 5:
                        {
                            A_1.Paddings.Right = A_0.method_42();
                            continue;
                        }
                    }
                }
            }
            A_0.vmethod_1();
        }
    }
}

