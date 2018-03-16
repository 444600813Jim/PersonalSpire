using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

internal class Class964
{
    private static readonly char[] char_0 = new char[] { ',', ';' };
    private const string string_0 = "Import of element '{0}' is not supported.";

    private Class964()
    {
    }

    internal static ShapeObject smethod_0(Interface50 A_0)
    {
        int num = 13;
        ShapeObject obj2 = new ShapeObject(A_0.imethod_0(), ShapeType.Rectangle);
        A_0.imethod_0().method_190(obj2);
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("倲娴嬶嘸䤺", num))
                {
                    if (str != BookmarkStart.b("䜲崴制吸帺縼倾ⵀⱂ㝄", num))
                    {
                        if (!(str == BookmarkStart.b("䜲崴制吸帺渼圾⁀❂⁄", num)))
                        {
                            if (str == BookmarkStart.b("䜲崴制吸帺椼嘾⽀㝂", num))
                            {
                                obj2.SetShapeAttribute(0x1035, class2.method_3());
                            }
                        }
                        else
                        {
                            obj2.SetShapeAttribute(0x1034, class2.method_3());
                        }
                    }
                    else
                    {
                        obj2.SetShapeAttribute(0x1033, class2.method_3());
                    }
                }
                else
                {
                    Color color = Class735.smethod_0(class2.method_3());
                    if (color != Color.White)
                    {
                        obj2.SetShapeAttribute(0x181, color);
                    }
                }
            }
        }
        while (class2.method_9(BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄", num)))
        {
            string str2;
            if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄", num)))
            {
                smethod_9(A_0, obj2);
            }
            else
            {
                class2.vmethod_1();
            }
        }
        return obj2;
    }

    internal static void smethod_1(Interface50 A_0)
    {
        int num = 4;
        ShapeObject obj2 = new ShapeObject(A_0.imethod_0(), ShapeType.Rectangle);
        A_0.imethod_0().method_27(new Background(A_0.imethod_0(), obj2));
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("䠩䬫縭夯儱䀳", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䠩䔫䀭琯匱䀳圵", num))
                {
                    if (str == BookmarkStart.b("䠩䴫䴭嬯唱䘳夵䴷吹堻", num))
                    {
                        if (class2.method_0() == BookmarkStart.b("崩", num))
                        {
                            smethod_2(A_0, obj2);
                        }
                        else if (class2.method_0() == BookmarkStart.b("尩", num))
                        {
                            smethod_9(A_0, obj2);
                        }
                    }
                }
                else
                {
                    A_0.imethod_9();
                }
            }
        }
    }

    private static void smethod_10(Interface50 A_0, ShapeBase A_1, bool A_2)
    {
        int num = 0;
        Class394 class2 = A_0.imethod_1();
        string str = class2.method_1();
        string str2 = null;
        string str3 = null;
        string str4 = null;
        string str5 = null;
        Class846[] classArray = null;
        Class846[] classArray2 = null;
        while (class2.method_19())
        {
            Size size;
            string str6 = class2.method_3();
            string key = class2.method_1();
            if (key != null)
            {
                int num6;
                if (Class1160.dictionary_204 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(50);
                    dictionary1.Add(BookmarkStart.b("伥䰧", num), 0);
                    dictionary1.Add(BookmarkStart.b("唥堧䌩䠫", num), 1);
                    dictionary1.Add(BookmarkStart.b("唥堧帩", num), 2);
                    dictionary1.Add(BookmarkStart.b("別儧娩䤫", num), 3);
                    dictionary1.Add(BookmarkStart.b("䌥䰧䌩堫伭䌯", num), 4);
                    dictionary1.Add(BookmarkStart.b("䜥䐧帩", num), 5);
                    dictionary1.Add(BookmarkStart.b("唥尧匩䀫䬭", num), 6);
                    dictionary1.Add(BookmarkStart.b("䤥䐧伩", num), 7);
                    dictionary1.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯䘱嬳䘵嬷唹倻儽㈿", num), 8);
                    dictionary1.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯帱儳倵䰷夹医刽⼿ぁ", num), 9);
                    dictionary1.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯倱嬳䈵䰷唹儻崽⼿⹁⭃㑅", num), 10);
                    dictionary1.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯䀱崳儵倷丹弻儽ⰿⵁ㙃", num), 11);
                    dictionary1.Add(BookmarkStart.b("䜥䐧䘩䌫夭夯就圳匵吷嘹", num), 12);
                    dictionary1.Add(BookmarkStart.b("䜥䐧䘩䌫夭弯䐱儳䐵吷嬹䰻", num), 13);
                    dictionary1.Add(BookmarkStart.b("䔥䜧䔩師䨭弯䀱崳儵儷吹", num), 14);
                    dictionary1.Add(BookmarkStart.b("䔥䜧䔩師䨭䌯嬱丳匵", num), 15);
                    dictionary1.Add(BookmarkStart.b("䜥䰧䀩", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("嘥䤧帩䐫", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("嘥䜧䌩䈫娭䌯", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("嘥娧伩䨫䬭䈯䀱儳娵夷丹唻䠽┿", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䀥䄧䘩䀫", num), 20);
                    dictionary1.Add(BookmarkStart.b("䀥䄧䘩䀫䬭启", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䀥䄧䘩䀫䴭弯帱嬳䐵", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䈥伧䜩䀫伭䤯崱䄳䈵", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("䈥伧䜩䈫䄭启圱弳張嘷帹", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("䔥䜧䐩䈫䬭匯䘱嬳䐵䰷䌹䰻嬽", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("唥尧堩䌫䔭唯嘱", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("唥尧堩䌫䔭唯儱嬳娵圷䠹", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("唥尧堩䌫䔭唯䔱儳張強刹䠻", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("伥䘧天䤫娭䀯圱娳", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("严娧伩䨫", num), 30);
                    dictionary1.Add(BookmarkStart.b("別䤧堩䬫䬭䐯", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("別䄧帩䀫䬭", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("䐥崧䘩䀫䬭䐯", num), 0x21);
                    dictionary1.Add(BookmarkStart.b("䐥崧帩堫䄭帯", num), 0x22);
                    dictionary1.Add(BookmarkStart.b("䤥䐧伩䔫䴭弯就", num), 0x23);
                    dictionary1.Add(BookmarkStart.b("䐥弧䜩䌫䨭唯", num), 0x24);
                    dictionary1.Add(BookmarkStart.b("䐥弧娩夫尭唯", num), 0x25);
                    dictionary1.Add(BookmarkStart.b("䐥弧䐩䌫尭崯匱堳", num), 0x26);
                    dictionary1.Add(BookmarkStart.b("严娧", num), 0x27);
                    dictionary1.Add(BookmarkStart.b("严娧天堫䨭", num), 40);
                    dictionary1.Add(BookmarkStart.b("严娧䐩䌫崭堯匱倳匵", num), 0x29);
                    dictionary1.Add(BookmarkStart.b("严娧娩伫娭", num), 0x2a);
                    dictionary1.Add(BookmarkStart.b("严娧䬩䀫䜭圯就", num), 0x2b);
                    dictionary1.Add(BookmarkStart.b("䀥娧䔩䄫", num), 0x2c);
                    dictionary1.Add(BookmarkStart.b("別䜧", num), 0x2d);
                    dictionary1.Add(BookmarkStart.b("䜥娧䤩弫䜭䨯圱", num), 0x2e);
                    dictionary1.Add(BookmarkStart.b("儥娧䬩尫䴭弯崱䘳刵䬷", num), 0x2f);
                    dictionary1.Add(BookmarkStart.b("䌥大弩䴫娭夯崱娳丵唷嘹", num), 0x30);
                    dictionary1.Add(BookmarkStart.b("䄥丧利䠫伭䐯匱", num), 0x31);
                    Class1160.dictionary_204 = dictionary1;
                }
                if (Class1160.dictionary_204.TryGetValue(key, out num6))
                {
                    switch (num6)
                    {
                        case 0:
                            str2 = str6;
                            break;

                        case 1:
                            str3 = str6;
                            break;

                        case 2:
                            str4 = str6;
                            break;

                        case 3:
                            str5 = str6;
                            break;

                        case 4:
                            A_1.SetShapeAttribute(0x500, Class1085.smethod_63(str6));
                            break;

                        case 5:
                            A_1.SetShapeAttribute(0x381, str6);
                            break;

                        case 6:
                            smethod_14(A_1, str6, A_0, class2, A_2);
                            break;

                        case 8:
                            A_1.ShapePr.method_58().Top.Color = Class735.smethod_0(str6);
                            break;

                        case 9:
                            A_1.ShapePr.method_58().Left.Color = Class735.smethod_0(str6);
                            break;

                        case 10:
                            A_1.ShapePr.method_58().Bottom.Color = Class735.smethod_0(str6);
                            break;

                        case 11:
                            A_1.ShapePr.method_58().Right.Color = Class735.smethod_0(str6);
                            break;

                        case 12:
                            smethod_47(A_1, 0x3b0, str6);
                            break;

                        case 13:
                            smethod_47(A_1, 950, str6);
                            break;

                        case 14:
                            if (Class567.smethod_16(str6))
                            {
                                int[] numArray = smethod_56(str6);
                                int x = (numArray.Length > 0) ? numArray[0] : 0;
                                int y = (numArray.Length > 1) ? numArray[1] : 0;
                                A_1.CoordOrigin = new Point(x, y);
                            }
                            break;

                        case 15:
                        {
                            if (!Class567.smethod_16(str6))
                            {
                                goto Label_0681;
                            }
                            int[] numArray2 = smethod_56(str6);
                            int width = (numArray2.Length > 0) ? numArray2[0] : 0;
                            int height = (numArray2.Length > 1) ? numArray2[1] : 0;
                            size = new Size(width, height);
                            goto Label_0692;
                        }
                        case 0x10:
                            smethod_57(A_1, str6);
                            break;

                        case 0x11:
                            smethod_58(A_1, str6);
                            break;

                        case 0x12:
                            smethod_59(A_1, str6);
                            break;

                        case 0x13:
                            smethod_47(A_1, 0x33b, str6);
                            break;

                        case 20:
                        case 0x15:
                            smethod_47(A_1, 0x1bb, str6);
                            break;

                        case 0x16:
                            goto Label_06EA;

                        case 0x17:
                            A_1.SetShapeAttribute(0x309, (DiagramNodeLayout) class2.method_4());
                            break;

                        case 0x18:
                            A_1.SetShapeAttribute(0x30a, (DiagramNodeKind) class2.method_4());
                            break;

                        case 0x19:
                            A_1.SetShapeAttribute(0x303, Class1085.smethod_57(str6));
                            break;

                        case 0x1a:
                            smethod_47(A_1, 0x1fc, str6);
                            break;

                        case 0x1b:
                            goto Label_0792;

                        case 0x1c:
                            smethod_50(A_1, 0x1cb, str6);
                            break;

                        case 0x1d:
                            smethod_47(A_1, 0x1f9, str6);
                            break;

                        case 30:
                            A_1.SetShapeAttribute(0x382, str6);
                            break;

                        case 0x1f:
                            A_1.SetShapeAttribute(0x1018, str6);
                            break;

                        case 0x20:
                            A_1.SetShapeAttribute(0x38d, str6);
                            break;

                        case 0x21:
                            smethod_47(A_1, 0x3b1, str6);
                            break;

                        case 0x22:
                            smethod_47(A_1, 0x3bc, str6);
                            break;

                        case 0x23:
                            smethod_47(A_1, 0x33a, str6);
                            break;

                        case 0x24:
                            A_1.SetShapeAttribute(0x304, Class1085.smethod_5(str6));
                            break;

                        case 0x25:
                            A_1.SetShapeAttribute(0x305, Class1085.smethod_5(str6));
                            break;

                        case 0x26:
                            A_1.SetShapeAttribute(0x306, Class1085.smethod_5(str6));
                            break;

                        case 0x27:
                            smethod_47(A_1, 0x3b4, str6);
                            break;

                        case 40:
                            smethod_47(A_1, 0x3b2, str6);
                            break;

                        case 0x29:
                            smethod_47(A_1, 0x3b3, str6);
                            break;

                        case 0x2a:
                            smethod_55(A_1, 0x393, str6);
                            break;

                        case 0x2b:
                            A_1.SetShapeAttribute(0x394, Class1085.smethod_9(str6));
                            break;

                        case 0x2c:
                            if (A_1.ShapeType == ShapeType.Line)
                            {
                                classArray = smethod_69(str6);
                            }
                            break;

                        case 0x2d:
                            if (A_1.ShapeType == ShapeType.Line)
                            {
                                classArray2 = smethod_69(str6);
                            }
                            break;

                        case 0x2e:
                            smethod_72(A_1, str6);
                            break;

                        case 0x2f:
                        {
                            Class891[] classArray3 = smethod_12(class2.method_3());
                            if (classArray3 != null)
                            {
                                A_1.SetShapeAttribute(0x383, classArray3);
                            }
                            break;
                        }
                        case 0x30:
                            A_1.SetShapeAttribute(780, Encoding.UTF8.GetBytes(str6));
                            break;
                    }
                }
            }
            continue;
        Label_0681:
            size = new Size(0x3e8, 0x3e8);
        Label_0692:
            A_1.method_56(size);
            continue;
        Label_06EA:
            if (A_1.Document.ColorScheme.ContainsKey(str6))
            {
                str6 = A_1.Document.ColorScheme[str6];
            }
            A_1.SetShapeAttribute(0x181, Class735.smethod_0(str6));
            continue;
        Label_0792:
            if (A_1.Document.ColorScheme.ContainsKey(str6))
            {
                str6 = A_1.Document.ColorScheme[str6];
            }
            A_1.SetShapeAttribute(0x1c0, Class735.smethod_0(str6));
        }
        if (classArray != null)
        {
            if (classArray[0].method_2())
            {
                A_1.Left = classArray[0].method_8();
            }
            if (classArray[1].method_2())
            {
                A_1.Top = classArray[1].method_8();
            }
        }
        if (classArray2 != null)
        {
            smethod_8(classArray2[0], A_1);
            smethod_7(classArray2[1], A_1);
        }
        if (Class567.smethod_16(str4))
        {
            smethod_13(A_1, 0x103b, str4);
        }
        else if (Class567.smethod_16(str5))
        {
            Class43 class3 = A_0.imethod_12(str5);
            if ((class3 != null) && class3.HasKey(0x103b))
            {
                A_1.SetShapeAttribute(0x103b, class3.method_31(0x103b));
            }
            else
            {
                smethod_13(A_1, 0x103b, str5);
            }
            if ((class3 != null) && class3.HasKey(120))
            {
                A_1.SetShapeAttribute(120, class3.method_31(120));
            }
            if ((class3 != null) && class3.HasKey(0x7c))
            {
                A_1.SetShapeAttribute(0x7c, class3.method_31(0x7c));
            }
            if ((class3 != null) && class3.HasKey(0x7d))
            {
                A_1.SetShapeAttribute(0x7d, class3.method_31(0x7d));
            }
            if ((class3 != null) && class3.HasKey(0x33c))
            {
                A_1.SetShapeAttribute(0x33c, class3.method_31(0x33c));
            }
        }
        if (Class567.smethod_16(str3))
        {
            smethod_13(A_1, 0x101c, str3);
            if (Class567.smethod_16(str2))
            {
                A_1.Name = str2;
            }
        }
        else if (Class567.smethod_16(str2))
        {
            smethod_13(A_1, 0x101c, str2);
            A_1.Name = str2;
        }
        if (Class567.smethod_16(str2))
        {
            A_0.imethod_7(str2, A_1);
        }
        while (class2.method_9(str))
        {
            string str7 = class2.method_1();
            if (str7 != null)
            {
                int num3;
                if (Class1160.dictionary_205 == null)
                {
                    Dictionary<string, int> dictionary2 = new Dictionary<string, int>(0x17);
                    dictionary2.Add(BookmarkStart.b("伥䘧䄩", num), 0);
                    dictionary2.Add(BookmarkStart.b("䐥䄧䐩栫伭䐯匱", num), 1);
                    dictionary2.Add(BookmarkStart.b("䀥䄧䘩䀫", num), 2);
                    dictionary2.Add(BookmarkStart.b("唥尧堩䌫䔭唯", num), 3);
                    dictionary2.Add(BookmarkStart.b("伥䔧䬩䬫䬭启匱䀳圵", num), 4);
                    dictionary2.Add(BookmarkStart.b("伥䔧䬩䬫䬭琯匱䀳圵", num), 5);
                    dictionary2.Add(BookmarkStart.b("唥䄧䴩䈫伭䐯䜱䘳匵吷匹刻嬽", num), 6);
                    dictionary2.Add(BookmarkStart.b("唥䀧䬩䠫䄭䜯", num), 7);
                    dictionary2.Add(BookmarkStart.b("䌥倧帩師嬭䌯嬱嬳堵", num), 8);
                    dictionary2.Add(BookmarkStart.b("䀥䜧堩䄫嬭尯匱䜳", num), 9);
                    dictionary2.Add(BookmarkStart.b("嘥䤧帩䐫", num), 10);
                    dictionary2.Add(BookmarkStart.b("別䴧利堫席儯䘱尳", num), 11);
                    dictionary2.Add(BookmarkStart.b("严䤧䐩䠫䈭唯䄱", num), 12);
                    dictionary2.Add(BookmarkStart.b("䨥䜧䤩䜫", num), 13);
                    dictionary2.Add(BookmarkStart.b("別䴧利堫䰭弯䨱", num), 14);
                    dictionary2.Add(BookmarkStart.b("䈥䄧䬩䬫尭儯弱", num), 15);
                    dictionary2.Add(BookmarkStart.b("䔥䤧䘩䀫䄭䔯䘱", num), 0x10);
                    dictionary2.Add(BookmarkStart.b("儥娧䬩尫", num), 0x11);
                    dictionary2.Add(BookmarkStart.b("䜥䘧䤩䐫䄭䈯帱嬳唵匷", num), 0x12);
                    dictionary2.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯䘱嬳䘵", num), 0x13);
                    dictionary2.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯帱儳倵䰷", num), 20);
                    dictionary2.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯倱嬳䈵䰷唹儻", num), 0x15);
                    dictionary2.Add(BookmarkStart.b("䐥䜧堩䠫䬭䈯䀱崳儵倷丹", num), 0x16);
                    Class1160.dictionary_205 = dictionary2;
                }
                if (Class1160.dictionary_205.TryGetValue(str7, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                        {
                            smethod_16(A_1, A_0);
                            continue;
                        }
                        case 1:
                        {
                            A_0.imethod_9();
                            continue;
                        }
                        case 2:
                        {
                            smethod_17(A_1, A_0);
                            continue;
                        }
                        case 3:
                        {
                            smethod_18(A_1, A_0);
                            continue;
                        }
                        case 4:
                        case 5:
                        {
                            if (!A_1.IsGroup)
                            {
                                ShapeObject obj2 = (ShapeObject) A_1;
                                smethod_19(obj2, A_0);
                                if (obj2.HasImage && (A_1.ShapeType == ShapeType.NonPrimitive))
                                {
                                    smethod_13(A_1, 0x103b, BookmarkStart.b("ᜥᠧᨩ", num));
                                }
                            }
                            continue;
                        }
                        case 6:
                        {
                            smethod_11(A_1, class2);
                            continue;
                        }
                        case 7:
                        {
                            smethod_20(A_1, class2);
                            continue;
                        }
                        case 8:
                        {
                            smethod_21(A_1, class2);
                            continue;
                        }
                        case 9:
                        {
                            smethod_22(A_1, class2);
                            continue;
                        }
                        case 10:
                        {
                            smethod_25(A_1, class2);
                            continue;
                        }
                        case 11:
                        {
                            smethod_29(A_1, class2);
                            continue;
                        }
                        case 12:
                        {
                            smethod_31(A_1, class2);
                            continue;
                        }
                        case 13:
                        {
                            smethod_37(A_1, class2);
                            continue;
                        }
                        case 14:
                        {
                            smethod_38(A_0, A_1);
                            continue;
                        }
                        case 15:
                        {
                            smethod_40(A_1, class2);
                            continue;
                        }
                        case 0x10:
                        {
                            smethod_43(A_1, class2);
                            continue;
                        }
                        case 0x11:
                        {
                            smethod_45(A_1, class2);
                            continue;
                        }
                        case 0x12:
                        {
                            A_1.SetShapeAttribute(0x1003, true);
                            continue;
                        }
                        case 0x13:
                        {
                            smethod_46(A_1, 0x100a, class2);
                            continue;
                        }
                        case 20:
                        {
                            smethod_46(A_1, 0x100b, class2);
                            continue;
                        }
                        case 0x15:
                        {
                            smethod_46(A_1, 0x100c, class2);
                            continue;
                        }
                        case 0x16:
                        {
                            smethod_46(A_1, 0x100d, class2);
                            continue;
                        }
                    }
                }
            }
            if (A_1.ShapeType == ShapeType.Group)
            {
                ShapeBase entity = smethod_5(A_0, true);
                if (entity != null)
                {
                    if (entity.ShapeType == ShapeType.TextBox)
                    {
                        TextBox internerTextbox = (entity as ShapeObject).InternerTextbox;
                        A_1.ChildObjects.Add(internerTextbox);
                    }
                    else
                    {
                        A_1.ChildObjects.Add(entity);
                    }
                }
            }
            else
            {
                class2.vmethod_1();
            }
        }
        if (A_1.method_43())
        {
            A_1.method_44();
        }
    }

    private static void smethod_11(ShapeBase A_0, Class394 A_1)
    {
        int num = 0x12;
        A_0.SetShapeAttribute(0x7bc, true);
        while (A_1.method_19())
        {
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_206 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                    dictionary1.Add(BookmarkStart.b("夷帹堻刽㠿⽁⡃", num), 0);
                    dictionary1.Add(BookmarkStart.b("夷嘹倻儽㜿⅁⭃⭅╇⽉≋㩍⍏", num), 1);
                    dictionary1.Add(BookmarkStart.b("崷䈹䠻", num), 2);
                    dictionary1.Add(BookmarkStart.b("儷帹", num), 3);
                    dictionary1.Add(BookmarkStart.b("儷䤹伻圽✿ⱁ╃㉅㵇㡉⥋≍㥏㱑ㅓ", num), 4);
                    dictionary1.Add(BookmarkStart.b("䠷䠹医䠽⤿♁", num), 5);
                    dictionary1.Add(BookmarkStart.b("䬷刹医䤽㌿⭁⍃⡅ⱇ⭉㡋⭍", num), 6);
                    dictionary1.Add(BookmarkStart.b("䬷匹嬻倽⤿ⱁ⍃⽅♇㥉㡋㱍╏ㅑ⁓㽕㝗㑙⽛", num), 7);
                    dictionary1.Add(BookmarkStart.b("䬷匹嬻倽⤿ⱁ⍃⽅♇㥉㡋㱍╏ㅑ⁓㽕㝗㑙⽛ⵝ՟ᙡ", num), 8);
                    dictionary1.Add(BookmarkStart.b("䬷匹嬻丽㈿ⵁ㉃㍅㩇♉", num), 9);
                    dictionary1.Add(BookmarkStart.b("䬷伹嬻夽┿ㅁぃ⍅ⱇ㥉╋⥍㹏㝑♓", num), 10);
                    dictionary1.Add(BookmarkStart.b("䬷伹嬻夽┿ㅁぃ⍅ⱇ㥉╋⥍㹏㝑♓摕", num), 11);
                    dictionary1.Add(BookmarkStart.b("䬷伹嬻夽┿ㅁぃ⍅ⱇ㥉╋⥍㹏㝑♓㍕㕗㭙㕛㉝", num), 12);
                    Class1160.dictionary_206 = dictionary1;
                }
                if (Class1160.dictionary_206.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            A_0.SetShapeAttribute(0x787, A_1.method_3());
                            continue;
                        }
                        case 1:
                        {
                            A_0.SetShapeAttribute(0x7bd, A_1.method_63());
                            continue;
                        }
                        case 2:
                        {
                            continue;
                        }
                        case 3:
                        {
                            A_0.SetShapeAttribute(0x781, A_1.method_3());
                            continue;
                        }
                        case 4:
                        {
                            A_0.SetShapeAttribute(0x7bf, A_1.method_63());
                            continue;
                        }
                        case 5:
                        {
                            A_0.SetShapeAttribute(0x782, A_1.method_3());
                            continue;
                        }
                        case 6:
                        {
                            A_0.SetShapeAttribute(0x7bc, A_1.method_63());
                            continue;
                        }
                        case 7:
                        {
                            A_0.SetShapeAttribute(0x786, A_1.method_3());
                            continue;
                        }
                        case 8:
                        {
                            A_0.SetShapeAttribute(0x7be, A_1.method_63());
                            continue;
                        }
                        case 9:
                        {
                            A_0.SetShapeAttribute(0x788, A_1.method_3());
                            continue;
                        }
                        case 10:
                        {
                            A_0.SetShapeAttribute(0x783, A_1.method_3());
                            continue;
                        }
                        case 11:
                        {
                            A_0.SetShapeAttribute(0x784, A_1.method_3());
                            continue;
                        }
                        case 12:
                        {
                            A_0.SetShapeAttribute(0x785, A_1.method_3());
                            continue;
                        }
                    }
                }
            }
            A_1.vmethod_1();
        }
    }

    private static Class891[] smethod_12(string A_0)
    {
        MatchCollection matchs = new Regex(BookmarkStart.b("Ḳ਴欶崸်", 13)).Matches(A_0);
        string[] strArray = new string[matchs.Count];
        for (int i = 0; i < matchs.Count; i++)
        {
            strArray[i] = matchs[i].Value;
        }
        Class891[] classArray = new Class891[strArray.Length / 2];
        for (int j = 0; j < (strArray.Length / 2); j++)
        {
            classArray[j] = new Class891(Class233.smethod_4(strArray[2 * j]), Class233.smethod_4(strArray[(2 * j) + 1]));
        }
        if (classArray.Length == 0)
        {
            return null;
        }
        return classArray;
    }

    private static void smethod_13(ShapeBase A_0, int A_1, string A_2)
    {
        int num = Class114.smethod_19(A_2);
        if (num != -2147483648)
        {
            A_0.SetShapeAttribute(A_1, num);
        }
    }

    private static void smethod_14(ShapeBase A_0, string A_1, Interface50 A_2, Class394 A_3, bool A_4)
    {
        int num = 12;
        Class914[] classArray = smethod_70(A_1);
        bool flag = true;
        for (int i = 0; i < classArray.Length; i++)
        {
            string str = classArray[i].method_0();
            string str2 = classArray[i].method_1();
            if ((str == BookmarkStart.b("䈱嬳䔵儷丹唻儽⸿", num)) && (str2 == BookmarkStart.b("匱嘳䔵圷嘹䤻䨽┿", num)))
            {
                flag = false;
            }
            smethod_15(A_0, str, str2, A_2, A_3, A_4);
        }
        if (flag)
        {
            A_0.SetShapeAttribute(0x1001, TextWrappingStyle.Inline);
        }
    }

    private static void smethod_15(ShapeBase A_0, string A_1, string A_2, Interface50 A_3, Class394 A_4, bool A_5)
    {
        int num = 11;
        string key = A_1;
        if (key != null)
        {
            int num3;
            if (Class1160.dictionary_207 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1d);
                dictionary1.Add(BookmarkStart.b("䔰嘲䴴䌶ᐸ娺儼嘾♀ⵂ", num), 0);
                dictionary1.Add(BookmarkStart.b("䔰尲䔴", num), 1);
                dictionary1.Add(BookmarkStart.b("尰刲䜴倶倸唺ြ䬾⹀㍂", num), 2);
                dictionary1.Add(BookmarkStart.b("崰嘲匴䌶", num), 3);
                dictionary1.Add(BookmarkStart.b("尰刲䜴倶倸唺ြ匾⑀╂ㅄ", num), 4);
                dictionary1.Add(BookmarkStart.b("䘰娲儴䌶儸", num), 5);
                dictionary1.Add(BookmarkStart.b("夰嘲尴倶儸伺", num), 6);
                dictionary1.Add(BookmarkStart.b("䌰尲䄴嘶䴸刺刼儾", num), 7);
                dictionary1.Add(BookmarkStart.b("地弲尴䜶", num), 8);
                dictionary1.Add(BookmarkStart.b("䜰娲䘴帶嬸刺儼嘾㕀㩂", num), 9);
                dictionary1.Add(BookmarkStart.b("䬰Ḳ尴夶崸帺䔼", num), 10);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀♂⅄⹆㵈⹊⥌", num), 11);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒㥔㉖㽘⽚", num), 12);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒⅔㡖⥘", num), 13);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒❔㹖㹘㍚⥜", num), 14);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒㝔㡖ⵘ⽚㉜㉞", num), 15);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈⍊≌㵎㡐⥒㩔㥖ⵘ㩚ㅜ", num), 0x10);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈⍊≌㵎㡐⥒㩔㥖ⵘ㩚ㅜ牞፠٢।٦ᵨɪ᭬੮", num), 0x11);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈㵊⡌㵎═㩒㙔㙖㕘", num), 0x12);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈㵊⡌㵎═㩒㙔㙖㕘癚⽜㩞ൠɢᅤ๦Ὠ๪", num), 0x13);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀あㅄ㹆╈⹊", num), 20);
                dictionary1.Add(BookmarkStart.b("䄰尲䘴帶䴸刺刼儾", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䜰Ḳ䄴制䄸伺ြ帾⽀⁂ⵄ⡆㭈", num), 0x16);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ唸帺嬼䬾汀㍂⁄㕆⩈⹊⍌㭎", num), 0x17);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ䴸吺䴼ሾㅀ♂㝄⑆ⱈ╊㥌", num), 0x18);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸刺夼䬾⥀湂㕄≆㭈⡊⡌ⅎ═", num), 0x19);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ儸帺吼堾⥀㝂桄㝆ⱈ㥊⹌⩎㽐❒", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ丸刺夼䬾⥀湂㝄≆╈⩊㥌♎❐㙒", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("尰䀲娴ᨶ儸帺吼堾⥀㝂桄㕆ⱈ❊ⱌ㭎㡐╒ご", num), 0x1c);
                Class1160.dictionary_207 = dictionary1;
            }
            if (Class1160.dictionary_207.TryGetValue(key, out num3))
            {
                switch (num3)
                {
                    case 0:
                    case 0x15:
                        return;

                    case 1:
                        if (A_5)
                        {
                            A_0.Top = smethod_67(A_2, 0.0);
                        }
                        return;

                    case 2:
                        A_0.Top = smethod_67(A_2, 0.0);
                        return;

                    case 3:
                        if (A_5)
                        {
                            A_0.Left = smethod_67(A_2, 0.0);
                        }
                        return;

                    case 4:
                        A_0.Left = smethod_67(A_2, 0.0);
                        return;

                    case 5:
                        A_0.method_37(smethod_67(A_2, 50.25));
                        return;

                    case 6:
                        A_0.method_39(smethod_67(A_2, 50.25));
                        return;

                    case 7:
                        A_0.SetShapeAttribute(4, smethod_68(A_2));
                        return;

                    case 8:
                        A_0.SetShapeAttribute(0x1000, Class1085.smethod_67(A_2));
                        return;

                    case 9:
                        smethod_48(A_0, 0x3be, BookmarkStart.b("夰娲儴匶尸唺", num), BookmarkStart.b("䜰娲䘴帶嬸场堼", num), A_2);
                        return;

                    case 10:
                    {
                        int num2 = Class1041.smethod_23(A_2);
                        if (num2 < 0)
                        {
                            A_0.SetShapeAttribute(0x3ba, true);
                            A_0.TextWrappingStyle = TextWrappingStyle.Behind;
                        }
                        A_0.ZOrder = num2;
                        A_3.imethod_6(A_0);
                        return;
                    }
                    case 11:
                        smethod_47(A_0, 0x3b9, A_2);
                        return;

                    case 12:
                        smethod_50(A_0, 900, A_2);
                        return;

                    case 13:
                        smethod_50(A_0, 0x385, A_2);
                        return;

                    case 14:
                        smethod_50(A_0, 0x386, A_2);
                        return;

                    case 15:
                        smethod_50(A_0, 0x387, A_2);
                        return;

                    case 0x10:
                        A_0.SetShapeAttribute(0x38f, Class417.smethod_17(A_2));
                        return;

                    case 0x11:
                        A_0.SetShapeAttribute(0x390, Class417.smethod_15(A_2));
                        return;

                    case 0x12:
                        A_0.SetShapeAttribute(0x391, Class417.smethod_20(A_2));
                        return;

                    case 0x13:
                        A_0.SetShapeAttribute(0x392, Class417.smethod_13(A_2, RelativeVerticalPosition.Paragraph));
                        return;

                    case 20:
                        A_0.SetShapeAttribute(0x85, Class1085.smethod_53(A_2));
                        return;

                    case 0x16:
                        A_0.SetShapeAttribute(0x87, Class1085.smethod_47(A_2));
                        return;

                    case 0x17:
                        A_0.SetShapeAttribute(0x7c2, Class1041.smethod_13(A_2));
                        return;

                    case 0x18:
                        A_0.SetShapeAttribute(0x7c3, Class1041.smethod_13(A_2));
                        return;

                    case 0x19:
                        A_0.SetShapeAttribute(0x7c0, Class1041.smethod_13(A_2));
                        return;

                    case 0x1a:
                        A_0.SetShapeAttribute(0x7c1, Class1041.smethod_13(A_2));
                        return;

                    case 0x1b:
                        A_0.SetShapeAttribute(0x7c4, Class417.smethod_10(A_2));
                        return;

                    case 0x1c:
                        A_0.SetShapeAttribute(0x7c5, Class417.smethod_8(A_2));
                        return;
                }
            }
        }
    }

    private static void smethod_16(ShapeBase A_0, Interface50 A_1)
    {
        int num = 10;
        Class394 class2 = A_1.imethod_1();
        while (class2.method_19())
        {
            string s = class2.method_3();
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("夯", num)))
                {
                    if (str2 == BookmarkStart.b("儯就娳夵䰷嬹䠻圽⼿ⱁ", num))
                    {
                        A_0.SetShapeAttribute(0x73f, s == BookmarkStart.b("䐯", num));
                    }
                }
                else
                {
                    A_0.SetShapeAttribute(0x700, Convert.FromBase64String(s));
                }
            }
        }
    }

    private static void smethod_17(ShapeBase A_0, Interface50 A_1)
    {
        int num = 5;
        Class394 class2 = A_1.imethod_1();
        bool flag = false;
        while (class2.method_19())
        {
            string str3 = class2.method_3();
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_208 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x16);
                    dictionary1.Add(BookmarkStart.b("䈪䤬", num), 0);
                    dictionary1.Add(BookmarkStart.b("堪弬䰮", num), 1);
                    dictionary1.Add(BookmarkStart.b("弪䐬嬮崰嘲", num), 2);
                    dictionary1.Add(BookmarkStart.b("䐪崬丮到娲䄴丶", num), 3);
                    dictionary1.Add(BookmarkStart.b("䠪䈬䌮帰䄲ܴ", num), 4);
                    dictionary1.Add(BookmarkStart.b("䐪崬丮到娲䄴丶ସ", num), 5);
                    dictionary1.Add(BookmarkStart.b("䨪帬弮吰倲䄴", num), 6);
                    dictionary1.Add(BookmarkStart.b("䐪弬䘮嘰娲嬴", num), 7);
                    dictionary1.Add(BookmarkStart.b("嬪䈬尮堰䜲尴堶圸", num), 8);
                    dictionary1.Add(BookmarkStart.b("堪䐬售吰", num), 9);
                    dictionary1.Add(BookmarkStart.b("太䠬䰮帰弲娴䔶", num), 10);
                    dictionary1.Add(BookmarkStart.b("太䈬嬮倰䜲倴", num), 11);
                    dictionary1.Add(BookmarkStart.b("䨪䌬䠮崰嘲", num), 12);
                    dictionary1.Add(BookmarkStart.b("䠪䈬䌮帰䄲䘴", num), 13);
                    dictionary1.Add(BookmarkStart.b("䴪䈬䰮䐰䀲䔴堶䨸刺䤼嘾⹀ⵂ", num), 14);
                    dictionary1.Add(BookmarkStart.b("䴪䈬䰮䐰䀲䘴帶䌸帺", num), 15);
                    dictionary1.Add(BookmarkStart.b("䘪䠬嬮夰尲儴", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䴪䈬䰮䐰䀲", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("弪听弮吰", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("伪䠬嬮吰倲䄴娶嘸为丼娾≀⽂ⱄ⑆≈", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䌪弬䨮地", num), 20);
                    dictionary1.Add(BookmarkStart.b("䨪䄬嬮夰䄲倴儶", num), 0x15);
                    Class1160.dictionary_208 = dictionary1;
                }
                if (Class1160.dictionary_208.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                        {
                            byte[] buffer = A_1.imethod_3(str3);
                            if (buffer != null)
                            {
                                A_0.SetShapeAttribute(0x100f, Class783.smethod_0(buffer));
                            }
                            break;
                        }
                        case 2:
                            A_0.SetShapeAttribute(0x187, str3);
                            break;

                        case 3:
                            smethod_52(A_0, 0x182, str3);
                            break;

                        case 4:
                            A_0.SetShapeAttribute(0x183, Class735.smethod_0(str3));
                            break;

                        case 5:
                            smethod_52(A_0, 0x184, str3);
                            break;

                        case 6:
                            A_0.SetShapeAttribute(0x195, Class1085.smethod_62(str3));
                            break;

                        case 7:
                            smethod_66(A_0, 0x198, 0x199, str3);
                            break;

                        case 8:
                            smethod_66(A_0, 410, 0x19b, str3);
                            break;

                        case 10:
                            smethod_47(A_0, 0x1b9, str3);
                            break;

                        case 11:
                            smethod_47(A_0, 0x1ba, str3);
                            break;

                        case 12:
                            smethod_52(A_0, 0x18b, str3);
                            break;

                        case 13:
                            A_0.SetShapeAttribute(0x197, smethod_44(str3));
                            break;

                        case 14:
                            smethod_66(A_0, 0x18d, 0x18e, str3);
                            break;

                        case 0x10:
                            if (!(str3 == BookmarkStart.b("䜪䐬䄮吰刲䜴᜶䨸刺娼刾⁀", num)))
                            {
                                goto Label_03A9;
                            }
                            A_0.SetShapeAttribute(0x19c, (GradientType) 0x4000000b);
                            break;

                        case 0x11:
                            smethod_54(A_0, 0x18c, str3);
                            break;

                        case 0x12:
                            goto Label_03CB;

                        case 0x13:
                            smethod_47(A_0, 0x1bf, str3);
                            break;
                    }
                }
            }
            continue;
        Label_03A9:
            A_0.SetShapeAttribute(0x19c, GradientType.None);
            continue;
        Label_03CB:
            A_0.SetShapeAttribute(0x180, Class1085.smethod_66(str3));
            if ((str3 == BookmarkStart.b("䰪弬丮唰娲倴夶䴸椺尼嬾⡀≂⥄", num)) || (str3 == BookmarkStart.b("䰪弬丮唰娲倴夶䴸", num)))
            {
                flag = true;
            }
        }
        if (flag)
        {
            while (class2.method_9(BookmarkStart.b("䴪䐬䌮崰", num)))
            {
                string str2 = class2.method_12(BookmarkStart.b("弪听弮吰", num), "");
                if (str2 != null)
                {
                    if (!(str2 == BookmarkStart.b("䰪弬丮唰娲倴夶䴸砺堼儾㕀♂㝄", num)))
                    {
                        if (str2 == BookmarkStart.b("䰪弬丮唰娲倴夶䴸渺匼䰾≀≂⥄≆ⵈ", num))
                        {
                            A_0.SetShapeAttribute(0x180, FillType.ShadeUnscale);
                        }
                    }
                    else
                    {
                        A_0.SetShapeAttribute(0x180, FillType.ShadeCenter);
                    }
                }
            }
        }
    }

    private static void smethod_18(ShapeBase A_0, Interface50 A_1)
    {
        int num = 1;
        Class394 class2 = A_1.imethod_1();
        while (class2.method_19())
        {
            string str = class2.method_3();
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_209 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x11);
                    dictionary1.Add(BookmarkStart.b("並䴨", num), 0);
                    dictionary1.Add(BookmarkStart.b("否嬨䠪", num), 1);
                    dictionary1.Add(BookmarkStart.b("匦䀨弪䄬䨮", num), 2);
                    dictionary1.Add(BookmarkStart.b("䴦䘨䈪䌬尮䔰䨲头制", num), 3);
                    dictionary1.Add(BookmarkStart.b("䌦䠨堪䔬尮䔰䨲头制", num), 4);
                    dictionary1.Add(BookmarkStart.b("䬦䀨䔪䠬尮䔰䨲头制", num), 5);
                    dictionary1.Add(BookmarkStart.b("䈦䜨伪丬丮䄰", num), 6);
                    dictionary1.Add(BookmarkStart.b("否崨䨪弬嬮倰䄲䜴堶丸", num), 7);
                    dictionary1.Add(BookmarkStart.b("否崨䨪弬嬮倰䄲䜴堶丸䰺吼嬾㕀⭂", num), 8);
                    dictionary1.Add(BookmarkStart.b("否崨䨪弬嬮倰䄲䜴堶丸场堼儾♀㝂ⵄ", num), 9);
                    dictionary1.Add(BookmarkStart.b("䈦䜨伪䰬崮䌰尲䈴", num), 10);
                    dictionary1.Add(BookmarkStart.b("䈦䜨伪䰬崮䌰尲䈴䀶倸强䤼圾", num), 11);
                    dictionary1.Add(BookmarkStart.b("䈦䜨伪䰬崮䌰尲䈴嬶尸唺娼䬾⥀", num), 12);
                    dictionary1.Add(BookmarkStart.b("䠦夨䨪丬䘮䔰䨲", num), 13);
                    dictionary1.Add(BookmarkStart.b("䐦䘨䜪䈬崮̰", num), 14);
                    dictionary1.Add(BookmarkStart.b("䄦䀨䜪䄬嬮䠰䌲倴", num), 15);
                    dictionary1.Add(BookmarkStart.b("倦䰨䈪䨬䜮䔰", num), 0x10);
                    Class1160.dictionary_209 = dictionary1;
                }
                if (Class1160.dictionary_209.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                            A_0.SetShapeAttribute(0x100e, A_1.imethod_3(str));
                            break;

                        case 2:
                            A_0.SetShapeAttribute(0x1c6, str);
                            break;

                        case 3:
                            A_0.SetShapeAttribute(470, Class1085.smethod_23(str));
                            break;

                        case 4:
                            A_0.SetShapeAttribute(0x1ce, Class1085.smethod_21(str));
                            break;

                        case 5:
                            A_0.SetShapeAttribute(0x1cd, Class1085.smethod_25(str));
                            break;

                        case 6:
                            A_0.SetShapeAttribute(0x1d7, Class1085.smethod_27(str));
                            break;

                        case 7:
                            A_0.SetShapeAttribute(0x1d0, Class1085.smethod_33(str));
                            break;

                        case 8:
                            A_0.SetShapeAttribute(0x1d2, Class1085.smethod_29(str));
                            break;

                        case 9:
                            A_0.SetShapeAttribute(0x1d3, Class1085.smethod_31(str));
                            break;

                        case 10:
                            A_0.SetShapeAttribute(0x1d1, Class1085.smethod_33(str));
                            break;

                        case 11:
                            A_0.SetShapeAttribute(0x1d4, Class1085.smethod_29(str));
                            break;

                        case 12:
                            A_0.SetShapeAttribute(0x1d5, Class1085.smethod_31(str));
                            break;

                        case 13:
                            smethod_52(A_0, 0x1c1, str);
                            break;

                        case 14:
                            A_0.SetShapeAttribute(450, Class735.smethod_0(str));
                            break;

                        case 15:
                            A_0.SetShapeAttribute(0x1c4, Class1085.smethod_35(str));
                            break;

                        case 0x10:
                            smethod_50(A_0, 0x1cb, str);
                            break;
                    }
                }
            }
        }
    }

    private static void smethod_19(ShapeObject A_0, Interface50 A_1)
    {
        int num = 2;
        Class394 class2 = A_1.imethod_1();
        while (class2.method_19())
        {
            byte[] buffer;
            string str = class2.method_3();
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_210 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x10);
                    dictionary1.Add(BookmarkStart.b("䄧丩", num), 0);
                    dictionary1.Add(BookmarkStart.b("嬧堩伫", num), 1);
                    dictionary1.Add(BookmarkStart.b("䀧堩䤫䠭", num), 2);
                    dictionary1.Add(BookmarkStart.b("尧䌩堫䈭唯", num), 3);
                    dictionary1.Add(BookmarkStart.b("䬧堩䌫席䐯崱䐳", num), 4);
                    dictionary1.Add(BookmarkStart.b("䬧堩䌫席刯崱䀳䈵圷圹", num), 5);
                    dictionary1.Add(BookmarkStart.b("䬧堩䌫席尯圱刳䈵", num), 6);
                    dictionary1.Add(BookmarkStart.b("䬧堩䌫席䈯嬱匳帵䰷", num), 7);
                    dictionary1.Add(BookmarkStart.b("䬧䈩師䄭崯匱弳匵䄷", num), 8);
                    dictionary1.Add(BookmarkStart.b("伧䬩䔫䀭", num), 9);
                    dictionary1.Add(BookmarkStart.b("䨧䘩䴫䴭嬯帱儳䀵崷嘹", num), 10);
                    dictionary1.Add(BookmarkStart.b("伧䬩䄫䌭儯", num), 11);
                    dictionary1.Add(BookmarkStart.b("伧堩䴫圭䌯儱唳娵崷", num), 12);
                    dictionary1.Add(BookmarkStart.b("䨧䌩䀫䬭䘯圱堳", num), 13);
                    dictionary1.Add(BookmarkStart.b("䴧䜩丫䄭䌯䄱圳夵吷唹主", num), 14);
                    dictionary1.Add(BookmarkStart.b("娧伩伫䄭尯崱䘳䈵夷䠹嬻嬽㐿", num), 15);
                    Class1160.dictionary_210 = dictionary1;
                }
                if (Class1160.dictionary_210.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                            if (!A_1.imethod_5(str))
                            {
                                goto Label_01E7;
                            }
                            A_0.SetShapeAttribute(0x1008, A_1.imethod_4(str));
                            break;

                        case 2:
                            A_0.SetShapeAttribute(0x1008, A_1.imethod_4(str));
                            break;

                        case 3:
                            A_0.SetShapeAttribute(0x1007, str);
                            break;

                        case 4:
                            smethod_52(A_0, 0x100, str);
                            break;

                        case 5:
                            smethod_52(A_0, 0x101, str);
                            break;

                        case 6:
                            smethod_52(A_0, 0x102, str);
                            break;

                        case 7:
                            smethod_52(A_0, 0x103, str);
                            break;

                        case 8:
                            A_0.SetShapeAttribute(0x107, Class735.smethod_0(str));
                            break;

                        case 9:
                            smethod_52(A_0, 0x108, str);
                            break;

                        case 10:
                            smethod_52(A_0, 0x109, str);
                            break;

                        case 11:
                            smethod_52(A_0, 0x10a, str);
                            break;

                        case 12:
                            smethod_47(A_0, 0x13d, str);
                            if (str == BookmarkStart.b("尧", num))
                            {
                                A_0.ImageData.Color = PictureColor.Grayscale;
                            }
                            break;

                        case 13:
                            smethod_47(A_0, 0x13e, str);
                            if (str == BookmarkStart.b("尧", num))
                            {
                                A_0.ImageData.Color = PictureColor.BlackAndWhite;
                            }
                            break;

                        case 14:
                        {
                            Color color = Class735.smethod_0(str);
                            int num3 = ((0x10000000 + (color.B << 0x10)) + (color.G << 8)) + color.R;
                            A_0.SetShapeAttribute(0x10c, num3);
                            break;
                        }
                        case 15:
                        {
                            Color color2 = Class735.smethod_0(str);
                            int num4 = ((color2.B << 0x10) + (color2.G << 8)) + color2.R;
                            A_0.SetShapeAttribute(0x11a, num4);
                            break;
                        }
                    }
                }
            }
            continue;
        Label_01E7:
            buffer = A_1.imethod_3(str);
            if ((buffer != null) && (buffer.Length > 0))
            {
                A_0.ImageData.method_87(buffer);
            }
            A_0.SetShapeAttribute(0x1006, A_0.ImageData.ImageBytes);
        }
    }

    private static void smethod_2(Interface50 A_0, ShapeBase A_1)
    {
        int num = 12;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str = class2.method_3();
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("倱匳唵圷嘹医䰽", num)))
                {
                    if (str2 == BookmarkStart.b("倱唳唵匷崹主儽㔿ⱁ⁃", num))
                    {
                        A_1.SetShapeAttribute(0x100f, A_0.imethod_3(str));
                    }
                }
                else if (str != BookmarkStart.b("䔱尳張䰷弹", num))
                {
                    A_1.SetShapeAttribute(0x181, Class735.smethod_0(str));
                }
            }
        }
    }

    private static void smethod_20(ShapeBase A_0, Class394 A_1)
    {
        int num = 0x13;
        while (A_1.method_19())
        {
            string str = A_1.method_3();
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_211 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("嘸唺", num), 0);
                    dictionary1.Add(BookmarkStart.b("䴸䈺䴼娾", num), 1);
                    dictionary1.Add(BookmarkStart.b("娸吺儼倾㍀", num), 2);
                    dictionary1.Add(BookmarkStart.b("娸吺儼倾㍀煂", num), 3);
                    dictionary1.Add(BookmarkStart.b("嘸䬺尼尾⡀㝂㱄", num), 4);
                    dictionary1.Add(BookmarkStart.b("嘸䤺吼堾⡀ⵂ", num), 5);
                    dictionary1.Add(BookmarkStart.b("嘸崺嬼䰾⑀㝂", num), 6);
                    dictionary1.Add(BookmarkStart.b("嘸崺嬼䰾⑀㝂睄", num), 7);
                    dictionary1.Add(BookmarkStart.b("吸娺䤼䴾⡀㭂", num), 8);
                    dictionary1.Add(BookmarkStart.b("嘸夺丼尾㑀ㅂ⁄⍆", num), 9);
                    Class1160.dictionary_211 = dictionary1;
                }
                if (Class1160.dictionary_211.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            smethod_47(A_0, 0x23e, str);
                            break;

                        case 1:
                            A_0.SetShapeAttribute(0x200, Class1085.smethod_41(str));
                            break;

                        case 2:
                            A_0.SetShapeAttribute(0x201, Class735.smethod_0(str));
                            break;

                        case 3:
                            A_0.SetShapeAttribute(0x202, Class735.smethod_0(str));
                            break;

                        case 4:
                            smethod_52(A_0, 0x204, str);
                            break;

                        case 5:
                            smethod_66(A_0, 0x210, 0x211, str);
                            break;

                        case 6:
                            smethod_65(A_0, 0x205, 0x206, str);
                            break;

                        case 7:
                            smethod_65(A_0, 0x207, 520, str);
                            break;

                        case 8:
                            smethod_60(A_0, str);
                            break;

                        case 9:
                            smethod_47(A_0, 0x23f, str);
                            break;
                    }
                }
            }
        }
    }

    private static void smethod_21(ShapeBase A_0, Class394 A_1)
    {
        int num = 8;
        while (A_1.method_19())
        {
            string str = A_1.method_3();
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_212 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x21);
                    dictionary1.Add(BookmarkStart.b("䬭䠯䘱", num), 0);
                    dictionary1.Add(BookmarkStart.b("崭䀯圱圳䌵吷嬹主圽㐿㭁", num), 1);
                    dictionary1.Add(BookmarkStart.b("䨭夯吱刳䌵䬷匹䠻䜽", num), 2);
                    dictionary1.Add(BookmarkStart.b("崭堯嬱娳張嘷弹伻䴽", num), 3);
                    dictionary1.Add(BookmarkStart.b("䬭启唱儳", num), 4);
                    dictionary1.Add(BookmarkStart.b("䠭弯䀱儳刵崷䨹䠻嘽", num), 5);
                    dictionary1.Add(BookmarkStart.b("䰭儯儱弳刵崷䨹䠻嘽", num), 6);
                    dictionary1.Add(BookmarkStart.b("席尯匱娳匵", num), 7);
                    dictionary1.Add(BookmarkStart.b("䴭弯帱嬳䐵", num), 8);
                    dictionary1.Add(BookmarkStart.b("䄭帯", num), 9);
                    dictionary1.Add(BookmarkStart.b("䌭唯䘱唳娵", num), 10);
                    dictionary1.Add(BookmarkStart.b("䈭夯唱尳䈵帷嬹弻嬽", num), 11);
                    dictionary1.Add(BookmarkStart.b("尭弯䘱唳䈵儷唹刻弽⸿╁⡃⍅", num), 12);
                    dictionary1.Add(BookmarkStart.b("䄭䈯嬱儳堵䰷嬹䠻圽⼿ⱁ", num), 13);
                    dictionary1.Add(BookmarkStart.b("䄭䈯嬱儳堵䰷嬹䠻圽⼿ⱁ╃⡅⽇♉⥋", num), 14);
                    dictionary1.Add(BookmarkStart.b("尭弯䘱唳䈵儷唹刻崽┿ⱁぃ⍅㩇", num), 15);
                    dictionary1.Add(BookmarkStart.b("尭唯就倳匵䨷", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䠭儯儱儳䈵", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("堭夯圱䌳䘵圷匹刻䨽", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("堭夯圱䌳䘵圷匹刻䨽⼿ぁⵃⅅⅇ⑉", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("崭嬯圱䌳圵嘷崹倻嬽", num), 20);
                    dictionary1.Add(BookmarkStart.b("崭嬯圱䌳圵唷丹", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䰭䈯嬱匳帵䰷吹夻䴽㌿", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䈭夯唱尳䈵䠷唹伻圽㐿⭁⭃⡅", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("䈭夯唱尳䈵吷弹䨻嬽ⰿ", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("䈭夯唱尳䈵䠷唹伻圽㐿⭁⭃⡅穇", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("䈭夯唱尳䈵吷弹䨻嬽ⰿ灁", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("䴭弯帱嬳䐵唷唹堻嬽", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("䈭弯儱弳䐵圷丹崻䨽⤿ⵁ⩃╅ⵇ⑉㡋⭍≏", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("伭䔯䘱嬳䐵圷丹崻䨽⤿ⵁ⩃╅ⵇ⑉㡋⭍≏", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("娭䤯䈱儳", num), 30);
                    dictionary1.Add(BookmarkStart.b("䈭夯唱尳䈵倷嬹主䴽⠿", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("䈭夯唱尳䈵倷嬹主䴽⠿灁", num), 0x20);
                    Class1160.dictionary_212 = dictionary1;
                }
                if (Class1160.dictionary_212.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 1:
                            smethod_52(A_0, 640, str);
                            break;

                        case 2:
                            smethod_52(A_0, 0x281, str);
                            break;

                        case 3:
                            A_0.SetShapeAttribute(0x282, A_1.method_4());
                            break;

                        case 4:
                            smethod_50(A_0, 0x283, str);
                            break;

                        case 5:
                            smethod_50(A_0, 0x284, str);
                            break;

                        case 6:
                            smethod_50(A_0, 0x285, str);
                            break;

                        case 7:
                            A_0.SetShapeAttribute(0x286, Class1085.smethod_37(str));
                            break;

                        case 8:
                            A_0.SetShapeAttribute(0x287, Class735.smethod_0(str));
                            break;

                        case 9:
                            smethod_47(A_0, 700, str);
                            break;

                        case 10:
                            smethod_47(A_0, 0x2bd, str);
                            break;

                        case 11:
                            smethod_47(A_0, 0x2bf, str);
                            break;

                        case 12:
                            smethod_66(A_0, 0x2c1, 0x2c0, str);
                            break;

                        case 13:
                            smethod_63(A_0, 0x2c2, 0x2c3, 0x2c4, str);
                            break;

                        case 14:
                            smethod_52(A_0, 0x2c5, str);
                            break;

                        case 15:
                            smethod_62(A_0, str);
                            break;

                        case 0x10:
                            A_0.SetShapeAttribute(0x2c9, Class1085.smethod_39(str));
                            break;

                        case 0x11:
                            smethod_52(A_0, 0x2ca, str);
                            break;

                        case 0x12:
                            smethod_64(A_0, 0x2cb, 0x2cc, 0x2cd, str);
                            break;

                        case 0x13:
                            smethod_66(A_0, 0x2ce, 0x2cf, str);
                            break;

                        case 20:
                            smethod_52(A_0, 720, str);
                            break;

                        case 0x15:
                            smethod_54(A_0, 0x2d1, str);
                            break;

                        case 0x16:
                            smethod_52(A_0, 0x2d2, str);
                            break;

                        case 0x17:
                            smethod_63(A_0, 0x2d3, 0x2d4, 0x2d5, str);
                            break;

                        case 0x18:
                            smethod_52(A_0, 0x2d6, str);
                            break;

                        case 0x19:
                            smethod_63(A_0, 0x2d7, 0x2d8, 0x2d9, str);
                            break;

                        case 0x1a:
                            smethod_52(A_0, 730, str);
                            break;

                        case 0x1c:
                            smethod_47(A_0, 0x2fb, str);
                            break;

                        case 0x1d:
                            smethod_47(A_0, 0x2fc, str);
                            break;

                        case 30:
                            if (str == BookmarkStart.b("席唯䀱䜳䘵崷夹䠻圽㘿❁", num))
                            {
                                A_0.SetShapeAttribute(0x2fd, false);
                            }
                            break;

                        case 0x1f:
                            smethod_47(A_0, 0x2fe, str);
                            break;

                        case 0x20:
                            smethod_47(A_0, 0x2ff, str);
                            break;
                    }
                }
            }
        }
    }

    private static void smethod_22(ShapeBase A_0, Class394 A_1)
    {
        int num = 1;
        ArrayList list = new ArrayList();
        while (A_1.method_9(BookmarkStart.b("䄦䘨太䀬娮崰刲䘴", num)))
        {
            string str2;
            if (((str2 = A_1.method_1()) != null) && (str2 == BookmarkStart.b("䄦", num)))
            {
                string str = A_1.method_12(BookmarkStart.b("䈦堨䔪", num), "");
                if (Class567.smethod_16(str))
                {
                    list.Add(smethod_23(str));
                }
            }
            else
            {
                A_1.vmethod_1();
            }
        }
        Class456[] classArray = (Class456[]) list.ToArray(typeof(Class456));
        A_0.SetShapeAttribute(0x156, classArray);
    }

    private static Class456 smethod_23(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ' ' });
        Class456 class2 = new Class456 {
            operation_0 = Class1085.smethod_3(strArray[0])
        };
        if (strArray.Length > 1)
        {
            string str = strArray[1];
            if (!Class1041.smethod_17(str))
            {
                class2.int_0 |= 0x20;
                class2.int_1 = smethod_24(str);
            }
            else
            {
                class2.int_1 = Class1041.smethod_11(str);
            }
        }
        if (strArray.Length > 2)
        {
            string str3 = strArray[2];
            if (!Class1041.smethod_17(str3))
            {
                class2.int_0 |= 0x40;
                class2.int_2 = smethod_24(str3);
            }
            else
            {
                class2.int_2 = Class1041.smethod_11(str3);
            }
        }
        if (strArray.Length > 3)
        {
            string str2 = strArray[3];
            if (!Class1041.smethod_17(str2))
            {
                class2.int_0 |= 0x80;
                class2.int_3 = smethod_24(str2);
                return class2;
            }
            class2.int_3 = Class1041.smethod_11(str2);
        }
        return class2;
    }

    private static int smethod_24(string A_0)
    {
        int num = 11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_213 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                dictionary1.Add(BookmarkStart.b("䤰倲倴夶䴸帺似", num), 0);
                dictionary1.Add(BookmarkStart.b("䠰倲倴夶䴸帺似", num), 1);
                dictionary1.Add(BookmarkStart.b("䘰娲儴䌶儸", num), 2);
                dictionary1.Add(BookmarkStart.b("夰嘲尴倶儸伺", num), 3);
                dictionary1.Add(BookmarkStart.b("䤰弲尴娶嘸", num), 4);
                dictionary1.Add(BookmarkStart.b("䠰弲尴娶嘸", num), 5);
                dictionary1.Add(BookmarkStart.b("崰娲嬴制紸䤺尼䠾⽀", num), 6);
                dictionary1.Add(BookmarkStart.b("䄰娲䴴制唸眺吼儾⑀ᑂⱄ⍆㵈⍊", num), 7);
                dictionary1.Add(BookmarkStart.b("䄰娲䴴制唸氺吼嬾㕀⭂", num), 8);
                dictionary1.Add(BookmarkStart.b("䄰娲䴴制唸猺堼嘾♀⭂ㅄ", num), 9);
                dictionary1.Add(BookmarkStart.b("吰帲䀴怶倸强䤼圾", num), 10);
                dictionary1.Add(BookmarkStart.b("吰帲䀴缶尸刺娼圾㕀", num), 11);
                dictionary1.Add(BookmarkStart.b("吰帲䀴怶倸强䤼圾獀", num), 12);
                dictionary1.Add(BookmarkStart.b("吰帲䀴缶尸刺娼圾㕀煂", num), 13);
                Class1160.dictionary_213 = dictionary1;
            }
            if (Class1160.dictionary_213.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return 320;

                    case 1:
                        return 0x141;

                    case 2:
                        return 0x142;

                    case 3:
                        return 0x143;

                    case 4:
                        return 0x153;

                    case 5:
                        return 340;

                    case 6:
                        return 0x1fc;

                    case 7:
                        return 0x4f7;

                    case 8:
                        return 0x4f8;

                    case 9:
                        return 0x4f9;

                    case 10:
                        return 0x4fc;

                    case 11:
                        return 0x4fd;

                    case 12:
                        return 0x4fe;

                    case 13:
                        return 0x4ff;
                }
            }
        }
        if (A_0.StartsWith(BookmarkStart.b("焰", num)))
        {
            return (Class1041.smethod_23(A_0.TrimStart(new char[] { '@' })) + 0x400);
        }
        if (!A_0.StartsWith(BookmarkStart.b("ሰ", num)))
        {
            throw new InvalidOperationException(BookmarkStart.b("搰崲䜴制娸吺娼儾⡀㥂⁄⍆楈⑊㵌⩎⍐㉒㭔㍖祘ⵚ㱜㍞ᑠ٢䕤๦ݨ䭪ᥬݮᑰ卲፴ᡶ୸ᙺࡼ፾궂", num));
        }
        return (Class1041.smethod_23(A_0.TrimStart(new char[] { '#' })) + 0x147);
    }

    private static void smethod_25(ShapeBase A_0, Class394 A_1)
    {
        int num = 9;
        while (A_1.method_19())
        {
            string str = A_1.method_3();
            string key = A_1.method_1();
            if (key != null)
            {
                int num4;
                if (Class1160.dictionary_214 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                    dictionary1.Add(BookmarkStart.b("丮䌰䄲娴䀶嘸债", num), 0);
                    dictionary1.Add(BookmarkStart.b("䤮堰弲头堶券", num), 1);
                    dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸吺嘼", num), 2);
                    dictionary1.Add(BookmarkStart.b("尮夰刲儴堶丸吺嘼", num), 3);
                    dictionary1.Add(BookmarkStart.b("䨮䤰䜲䜴䈶䨸刺刼儾⹀⡂", num), 4);
                    dictionary1.Add(BookmarkStart.b("䠮䌰刲儴帶尸唺䤼䰾⥀≂㕄≆♈⁊", num), 5);
                    dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴䜶堸伺唼倾⩀", num), 6);
                    dictionary1.Add(BookmarkStart.b("䌮堰帲娴", num), 7);
                    dictionary1.Add(BookmarkStart.b("䰮帰崲嬴制娸伺䤼䘾ㅀ♂", num), 8);
                    dictionary1.Add(BookmarkStart.b("䰮帰崲嬴制娸伺儼倾≀あ", num), 9);
                    dictionary1.Add(BookmarkStart.b("䰮帰崲嬴制娸伺尼儾♀⽂⁄㑆", num), 10);
                    dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴唶嘸䌺似娾≀㝂", num), 11);
                    Class1160.dictionary_214 = dictionary1;
                }
                if (Class1160.dictionary_214.TryGetValue(key, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                            smethod_47(A_0, 0x1fb, str);
                            break;

                        case 1:
                            smethod_47(A_0, 0x17f, str);
                            break;

                        case 2:
                            smethod_47(A_0, 380, str);
                            break;

                        case 3:
                            smethod_47(A_0, 0x17a, str);
                            break;

                        case 4:
                            smethod_47(A_0, 0x17b, str);
                            break;

                        case 5:
                            smethod_47(A_0, 0x17e, str);
                            break;

                        case 6:
                            smethod_47(A_0, 0x17d, str);
                            break;

                        case 7:
                        {
                            int[] numArray = smethod_56(str);
                            int num2 = (numArray.Length > 0) ? numArray[0] : 0;
                            int num3 = (numArray.Length > 1) ? numArray[1] : 0;
                            A_0.SetShapeAttribute(0x153, num2);
                            A_0.SetShapeAttribute(340, num3);
                            break;
                        }
                        case 8:
                            A_0.SetShapeAttribute(0x158, Class1085.smethod_13(str));
                            break;

                        case 9:
                            smethod_26(A_0, str);
                            break;

                        case 10:
                            smethod_27(A_0, str);
                            break;

                        case 11:
                            smethod_28(A_0, str);
                            break;
                    }
                }
            }
        }
    }

    private static void smethod_26(ShapeBase A_0, string A_1)
    {
        string[] strArray = A_1.Split(char_0);
        Class891[] classArray = new Class891[strArray.Length / 2];
        for (int i = 0; i < (strArray.Length / 2); i++)
        {
            classArray[i] = new Class891(Class233.smethod_4(strArray[2 * i]), Class233.smethod_4(strArray[(2 * i) + 1]));
        }
        A_0.SetShapeAttribute(0x151, classArray);
    }

    private static void smethod_27(ShapeBase A_0, string A_1)
    {
        string[] strArray = A_1.Split(new char[] { ',' });
        int[] numArray = new int[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            numArray[i] = smethod_68(strArray[i]);
        }
        A_0.SetShapeAttribute(0x152, numArray);
    }

    private static void smethod_28(ShapeBase A_0, string A_1)
    {
        string[] strArray = A_1.Split(new char[] { ';' });
        Class70[] classArray = new Class70[strArray.Length];
        for (int i = 0; i < classArray.Length; i++)
        {
            string[] strArray2 = strArray[i].Split(new char[] { ',' });
            Class70 class2 = new Class70();
            if (strArray2.Length == 4)
            {
                class2.class623_0 = Class233.smethod_4(strArray2[0]);
                class2.class623_1 = Class233.smethod_4(strArray2[1]);
                class2.class623_2 = Class233.smethod_4(strArray2[2]);
                class2.class623_3 = Class233.smethod_4(strArray2[3]);
            }
            classArray[i] = class2;
        }
        A_0.SetShapeAttribute(0x157, classArray);
    }

    private static void smethod_29(ShapeBase A_0, Class394 A_1)
    {
        int num = 0x11;
        A_0.SetShapeAttribute(0xf1, true);
        A_0.SetShapeAttribute(0xf5, true);
        while (A_1.method_19())
        {
            string str = A_1.method_3();
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_215 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("堶圸", num), 0);
                    dictionary1.Add(BookmarkStart.b("䐶䴸䈺儼娾", num), 1);
                    dictionary1.Add(BookmarkStart.b("儶倸伺丼圾⁀㍂⁄", num), 2);
                    dictionary1.Add(BookmarkStart.b("䌶䬸刺值", num), 3);
                    dictionary1.Add(BookmarkStart.b("儶倸伺䴼帾㕀⭂", num), 4);
                    dictionary1.Add(BookmarkStart.b("伶䨸堺尼匾⑀", num), 5);
                    dictionary1.Add(BookmarkStart.b("䐶䴸䤺吼儾♀", num), 6);
                    Class1160.dictionary_215 = dictionary1;
                }
                if (Class1160.dictionary_215.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            smethod_47(A_0, 0xf1, str);
                            break;

                        case 1:
                            smethod_30(A_0, str);
                            break;

                        case 2:
                            smethod_47(A_0, 0xf5, str);
                            break;

                        case 3:
                            smethod_47(A_0, 0xf6, str);
                            break;

                        case 4:
                            smethod_47(A_0, 0xf7, str);
                            break;

                        case 5:
                            smethod_47(A_0, 0xf9, str);
                            break;

                        case 6:
                            A_0.SetShapeAttribute(0xc0, str);
                            break;
                    }
                }
            }
        }
    }

    internal static Class43 smethod_3(Interface50 A_0)
    {
        ShapeObject obj2 = new ShapeObject(A_0.imethod_0());
        smethod_9(A_0, obj2);
        return obj2.ShapePr;
    }

    private static void smethod_30(ShapeBase A_0, string A_1)
    {
        int num = 0;
        Class914[] classArray = smethod_70(A_1);
        for (int i = 0; i < classArray.Length; i++)
        {
            string str = classArray[i].method_1();
            string key = classArray[i].method_0();
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_216 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                    dictionary1.Add(BookmarkStart.b("䀥䜧䐩堫̭嘯匱夳張吷䌹", num), 0);
                    dictionary1.Add(BookmarkStart.b("䀥䜧䐩堫̭䌯嬱丳匵", num), 1);
                    dictionary1.Add(BookmarkStart.b("䀥䜧䐩堫̭䌯䘱䴳娵崷", num), 2);
                    dictionary1.Add(BookmarkStart.b("䀥䜧䐩堫̭䜯圱崳儵倷丹", num), 3);
                    dictionary1.Add(BookmarkStart.b("䀥䜧䐩堫̭䘯匱䘳張夷吹䠻", num), 4);
                    dictionary1.Add(BookmarkStart.b("別䴧利堫̭启圱圳夵䨷嬹䠻圽⼿ⱁ", num), 5);
                    dictionary1.Add(BookmarkStart.b("䬥嬧䔩ī娭唯䨱䀳ᬵ䬷刹崻娽⼿㕁", num), 6);
                    dictionary1.Add(BookmarkStart.b("倥ԧ帩䤫嘭䐯ἱ唳娵儷崹刻", num), 7);
                    dictionary1.Add(BookmarkStart.b("倥ԧ帩䤫嘭䐯ἱ䜳䘵夷夹唻倽✿潁⥃⥅ⱇ⽉", num), 8);
                    dictionary1.Add(BookmarkStart.b("倥ԧ帩䤫嘭䐯ἱ䜳䘵夷夹唻倽✿", num), 9);
                    dictionary1.Add(BookmarkStart.b("倥ԧ帩䤫嘭䐯ἱ弳匵䨷吹", num), 10);
                    dictionary1.Add(BookmarkStart.b("倥ԧ帩䤫嘭䐯ἱ䘳匵丷弹主䴽┿", num), 11);
                    dictionary1.Add(BookmarkStart.b("倥ԧ天䴫䌭唯ἱ堳匵䰷丹夻䰽洿⩁⅃⽅⽇≉㡋㵍", num), 12);
                    dictionary1.Add(BookmarkStart.b("倥ԧ堩䌫娭儯䘱儳ᬵ吷弹䠻䨽┿ぁ㝃", num), 13);
                    Class1160.dictionary_216 = dictionary1;
                }
                if (Class1160.dictionary_216.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                            A_0.SetShapeAttribute(0xc5, str.Trim(new char[] { '"', '\'' }));
                            break;

                        case 1:
                            A_0.SetShapeAttribute(0xc3, Class969.smethod_71(smethod_67(str, 36.0)));
                            break;

                        case 2:
                            smethod_48(A_0, 0xfb, BookmarkStart.b("伥尧䬩䀫䜭匯", num), BookmarkStart.b("䠥䜧堩䄫伭尯", num), str);
                            break;

                        case 3:
                            smethod_48(A_0, 250, BookmarkStart.b("䐥䜧䘩䠫", num), BookmarkStart.b("䠥䜧堩䄫伭尯", num), str);
                            break;

                        case 4:
                            smethod_48(A_0, 0xfe, BookmarkStart.b("唥䔧䬩䀫䈭ᴯ儱唳䘵䬷", num), BookmarkStart.b("䠥䜧堩䄫伭尯", num), str);
                            break;

                        case 5:
                        {
                            string str3 = str;
                            if (str3 != null)
                            {
                                if (str3 == BookmarkStart.b("匥䘧丩䤫尭尯嬱娳匵", num))
                                {
                                    goto Label_02B5;
                                }
                                if (str3 == BookmarkStart.b("䨥䄧䐩䤫̭䐯娱䘳夵䴷崹吻", num))
                                {
                                    A_0.SetShapeAttribute(0xff, true);
                                }
                            }
                            break;
                        }
                        case 6:
                            smethod_48(A_0, 0xfd, BookmarkStart.b("䜥崧帩䌫", num), BookmarkStart.b("䠥䜧堩䄫伭尯", num), str);
                            break;

                        case 7:
                            A_0.SetShapeAttribute(0xc2, Class1085.smethod_11(str));
                            break;

                        case 8:
                            smethod_48(A_0, 0xf4, BookmarkStart.b("別䄧䴩䐫娭唯就崳堵強", num), BookmarkStart.b("別娧䬩伫䔭夯就匳", num), str);
                            break;

                        case 9:
                            smethod_52(A_0, 0xc4, str);
                            break;

                        case 10:
                            smethod_47(A_0, 0xf3, str);
                            break;

                        case 11:
                            smethod_47(A_0, 240, str);
                            break;

                        case 12:
                            smethod_47(A_0, 0xf8, str);
                            break;

                        case 13:
                            smethod_47(A_0, 0xf2, str);
                            break;
                    }
                }
            }
            continue;
        Label_02B5:
            A_0.SetShapeAttribute(0xfc, true);
        }
    }

    private static void smethod_31(ShapeBase A_0, Class394 A_1)
    {
        int num = 0x11;
        ArrayList list = new ArrayList();
        while (A_1.method_9(BookmarkStart.b("弶堸唺夼匾⑀あ", num)))
        {
            string str;
            if (((str = A_1.method_1()) != null) && (str == BookmarkStart.b("弶", num)))
            {
                list.Add(smethod_32(A_1));
            }
            else
            {
                A_1.vmethod_1();
            }
        }
        Class784[] classArray = (Class784[]) list.ToArray(typeof(Class784));
        A_0.SetShapeAttribute(0x155, classArray);
    }

    private static Class784 smethod_32(Class394 A_0)
    {
        int num = 10;
        Class784 class2 = new Class784 {
            class623_2 = new Class623(-2147483648),
            class623_3 = new Class623(0x7fffffff),
            class623_4 = new Class623(-2147483648),
            class623_5 = new Class623(0x7fffffff)
        };
        while (A_0.method_19())
        {
            string str = A_0.method_3();
            string key = A_0.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_217 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("䀯崱䜳張䰷匹医倽", num), 0);
                    dictionary1.Add(BookmarkStart.b("䌯䔱崳䈵嬷刹", num), 1);
                    dictionary1.Add(BookmarkStart.b("䀯崱堳圵䨷", num), 2);
                    dictionary1.Add(BookmarkStart.b("崯匱䐳", num), 3);
                    dictionary1.Add(BookmarkStart.b("䈯匱倳張䴷䤹主弽⸿╁⅃", num), 4);
                    dictionary1.Add(BookmarkStart.b("䠯䀱唳堵強弹", num), 5);
                    dictionary1.Add(BookmarkStart.b("䤯䀱唳堵強弹", num), 6);
                    Class1160.dictionary_217 = dictionary1;
                }
                if (Class1160.dictionary_217.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            Class388 class6 = smethod_33(str);
                            class2.class72_0 = class6.method_1();
                            class2.class72_1 = class6.method_3();
                            break;
                        }
                        case 1:
                            class2.bool_4 = true;
                            break;

                        case 2:
                        {
                            class2.bool_3 = true;
                            Class891 class8 = smethod_34(str);
                            class2.class623_0 = class8.method_0();
                            class2.class623_1 = class8.method_1();
                            break;
                        }
                        case 3:
                        {
                            class2.bool_2 = true;
                            Class891 class3 = smethod_34(str);
                            class2.class623_0 = class3.method_0();
                            class2.class623_1 = class3.method_1();
                            break;
                        }
                        case 4:
                        {
                            class2.bool_0 = true;
                            Class891 class5 = smethod_34(str);
                            class2.class623_2 = class5.method_0();
                            class2.class623_3 = class5.method_1();
                            break;
                        }
                        case 5:
                        {
                            class2.bool_1 = true;
                            Class891 class4 = smethod_34(str);
                            class2.class623_2 = class4.method_0();
                            class2.class623_3 = class4.method_1();
                            break;
                        }
                        case 6:
                        {
                            class2.bool_1 = true;
                            Class891 class7 = smethod_34(str);
                            class2.class623_4 = class7.method_0();
                            class2.class623_5 = class7.method_1();
                            break;
                        }
                    }
                }
            }
        }
        return class2;
    }

    private static Class388 smethod_33(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ',' });
        return new Class388(smethod_36(strArray[0]), smethod_36(strArray[1]));
    }

    private static Class891 smethod_34(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ',' });
        return new Class891(smethod_35(strArray[0]), smethod_35(strArray[1]));
    }

    private static Class623 smethod_35(string A_0)
    {
        int num = 14;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䀳夵䠷瘹夻堽㐿", num))
            {
                return new Class623(0, true);
            }
            if (str == BookmarkStart.b("嘳夵䰷丹医匽ሿ⭁⍃⹅㱇", num))
            {
                return new Class623(1, true);
            }
            if (str == BookmarkStart.b("圳匵嘷丹夻䰽", num))
            {
                return new Class623(2, true);
            }
        }
        if (A_0.StartsWith(BookmarkStart.b("琳", num)))
        {
            return new Class623(Class1041.smethod_23(A_0.TrimStart(new char[] { '@' })) + 3, true);
        }
        if (A_0.StartsWith(BookmarkStart.b("ᜳ", num)))
        {
            return new Class623(Class1041.smethod_23(A_0.TrimStart(new char[] { '#' })) + 0x100, true);
        }
        return new Class623(Class1041.smethod_23(A_0), false);
    }

    private static Class72 smethod_36(string A_0)
    {
        int num = 4;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("帩䌫席簯圱刳䈵", num))
            {
                return new Class72(HandlePositionType.LeftTop, 0);
            }
            if (str == BookmarkStart.b("䠩䌫娭䐯崱夳搵儷崹吻䨽", num))
            {
                return new Class72(HandlePositionType.RightBottom, 0);
            }
            if (str == BookmarkStart.b("䤩䤫䀭䐯圱䘳", num))
            {
                return new Class72(HandlePositionType.Center, 0);
            }
        }
        if (A_0.StartsWith(BookmarkStart.b("権", num)))
        {
            return new Class72(HandlePositionType.Formula, Class1041.smethod_23(A_0.TrimStart(new char[] { '@' })));
        }
        if (A_0.StartsWith(BookmarkStart.b("ऩ", num)))
        {
            return new Class72(HandlePositionType.Adjust, Class1041.smethod_23(A_0.TrimStart(new char[] { '#' })));
        }
        return new Class72(HandlePositionType.Constant, Class1041.smethod_23(A_0));
    }

    private static void smethod_37(ShapeBase A_0, Class394 A_1)
    {
        int num = 15;
        while (A_1.method_19())
        {
            string str2;
            string str = A_1.method_3();
            if (((str2 = A_1.method_1()) != null) && (str2 != BookmarkStart.b("倴伶䴸", num)))
            {
                if (str2 != BookmarkStart.b("吴䐶䤸帺帼䬾㍀≂ㅄ⹆♈", num))
                {
                    if (str2 != BookmarkStart.b("䌴制䬸伺吼尾⡀♂㙄", num))
                    {
                        if (!(str2 == BookmarkStart.b("䄴制䄸伺", num)))
                        {
                            if (str2 == BookmarkStart.b("䘴弶堸䬺堼䬾㡀㍂⁄", num))
                            {
                                smethod_47(A_0, 0x33c, str);
                            }
                        }
                        else
                        {
                            smethod_47(A_0, 0x7d, str);
                        }
                    }
                    else
                    {
                        smethod_47(A_0, 0x7c, str);
                    }
                }
                else
                {
                    smethod_47(A_0, 120, str);
                }
            }
        }
    }

    private static void smethod_38(Interface50 A_0, ShapeBase A_1)
    {
        int num = 12;
        if (A_1.ShapeType == ShapeType.Rectangle)
        {
            A_1.SetShapeType(ShapeType.TextBox);
        }
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("䄱䀳伵吷弹", num)))
                {
                    if (str2 == BookmarkStart.b("嬱娳䔵崷丹", num))
                    {
                        smethod_61(A_1, class2.method_3());
                    }
                }
                else
                {
                    smethod_39(A_0, A_1, class2.method_3());
                }
            }
        }
        while (class2.method_9(BookmarkStart.b("䘱儳丵䰷堹医䘽", num)))
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䘱䰳吵䀷礹医倽㐿❁⩃㉅", num)))
            {
                A_0.imethod_10(A_1);
            }
            else
            {
                class2.vmethod_1();
            }
        }
    }

    private static void smethod_39(Interface50 A_0, ShapeBase A_1, string A_2)
    {
        int num = 4;
        Class914[] classArray = smethod_70(A_2);
        string str = null;
        string str2 = null;
        for (int i = 0; i < classArray.Length; i++)
        {
            string str3 = classArray[i].method_1();
            string str4 = classArray[i].method_0();
            if (str4 != null)
            {
                if (str4 != BookmarkStart.b("䘩䴫圭弯䜱䀳ᬵ帷嘹医䤽", num))
                {
                    if (str4 != BookmarkStart.b("䜩弫䄭ᴯ帱唳伵圷伹䠻ጽ☿⹁⭃ㅅ敇⭉⁋㩍", num))
                    {
                        if (!(str4 == BookmarkStart.b("䜩弫䄭ᴯ吱崳䈵ᔷ䤹吻弽〿❁楃㉅❇杉㡋⭍⡏♑", num)))
                        {
                            if (str4 == BookmarkStart.b("䜩弫䄭ᴯ就儳丵䰷᜹䠻嬽㠿㙁♃⥅ぇ", num))
                            {
                                A_1.SetShapeAttribute(0x8e, str3.Trim(new char[] { '#' }));
                            }
                        }
                        else
                        {
                            smethod_47(A_1, 190, str3);
                        }
                    }
                    else
                    {
                        str2 = str3;
                    }
                }
                else
                {
                    str = str3;
                }
            }
        }
        if (str != null)
        {
            if ((str == BookmarkStart.b("尩䤫尭䐯嬱圳圵吷", num)) && (str2 == BookmarkStart.b("䠩䌫娭䐯崱夳ᬵ䰷唹ᄻ䨽⼿㉁", num)))
            {
                A_1.SetShapeAttribute(0x88, LayoutFlow.BottomToTop);
            }
            else
            {
                A_1.SetShapeAttribute(0x88, Class1085.smethod_45(str));
            }
        }
    }

    internal static ShapeBase smethod_4(Interface50 A_0)
    {
        Class394 class2 = A_0.imethod_1();
        ShapeBase base2 = null;
        class2.method_18();
        string str = class2.method_1();
        while (class2.method_9(str))
        {
            ShapeBase base3 = smethod_5(A_0, false);
            if (base3 != null)
            {
                base2 = base3;
            }
        }
        return base2;
    }

    private static void smethod_40(ShapeBase A_0, Class394 A_1)
    {
        int num = 9;
        while (A_1.method_19())
        {
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_218 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                    dictionary1.Add(BookmarkStart.b("䨮䤰䜲", num), 0);
                    dictionary1.Add(BookmarkStart.b("䬮嘰帲䘴䌶䀸场堼", num), 1);
                    dictionary1.Add(BookmarkStart.b("䬮嘰帲䘴吶堸场堼䜾", num), 2);
                    dictionary1.Add(BookmarkStart.b("䬮嘰帲䘴吶堸场堼䘾", num), 3);
                    dictionary1.Add(BookmarkStart.b("䬮嘰帲匴堶圸伺丼嘾㭀♂", num), 4);
                    dictionary1.Add(BookmarkStart.b("䰮帰崲䘴䌶䬸娺吼儾⍀ⱂい⥆ⵈ㡊", num), 5);
                    dictionary1.Add(BookmarkStart.b("丮䐰䜲娴儶嘸䤺值帾㕀", num), 6);
                    dictionary1.Add(BookmarkStart.b("崮吰䔲倴䔶䨸帺", num), 7);
                    Class1160.dictionary_218 = dictionary1;
                }
                if (Class1160.dictionary_218.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 1:
                            A_0.SetShapeAttribute(0x501, A_1.method_4());
                            break;

                        case 2:
                            A_0.SetShapeAttribute(0x505, A_1.method_4());
                            break;

                        case 3:
                            A_0.SetShapeAttribute(0x506, A_1.method_4());
                            break;

                        case 4:
                            A_0.SetShapeAttribute(0x507, A_1.method_4());
                            break;

                        case 5:
                            A_0.SetShapeAttribute(0x508, smethod_56(A_1.method_3()));
                            break;

                        case 6:
                            smethod_47(A_0, 0x53c, A_1.method_3());
                            break;

                        case 7:
                            smethod_47(A_0, 0x53d, A_1.method_3());
                            break;
                    }
                }
            }
        }
        while (A_1.method_9(BookmarkStart.b("䬮堰刲刴䔶堸嘺", num)))
        {
            string str2;
            if (((str2 = A_1.method_1()) != null) && (str2 == BookmarkStart.b("崮吰弲吴䌶倸吺匼䬾⁀⅂⥄≆", num)))
            {
                smethod_41(A_0, A_1);
            }
        }
    }

    private static void smethod_41(ShapeBase A_0, Class394 A_1)
    {
        int num = 0x10;
        ArrayList list = new ArrayList();
        while (A_1.method_9(BookmarkStart.b("䐵崷嘹崻䨽⤿ⵁ⩃㉅⥇⡉⁋⭍", num)))
        {
            string str;
            if (((str = A_1.method_1()) != null) && (str == BookmarkStart.b("䐵崷嘹", num)))
            {
                list.Add(smethod_42(A_1));
            }
        }
        Class782[] classArray = (Class782[]) list.ToArray(typeof(Class782));
        A_0.SetShapeAttribute(0x504, classArray);
    }

    private static Class782 smethod_42(Class394 A_0)
    {
        int num = 9;
        Class782 class2 = new Class782();
        while (A_0.method_19())
        {
            string str2;
            string str = A_0.method_3();
            if (((str2 = A_0.method_1()) != null) && (str2 != BookmarkStart.b("䨮䤰䜲", num)))
            {
                if (str2 != BookmarkStart.b("䘮唰䀲䜴吶", num))
                {
                    if (!(str2 == BookmarkStart.b("䘮唰圲倴䐶䴸", num)))
                    {
                        if (str2 == BookmarkStart.b("䘮唰倲嬴䌶䬸", num))
                        {
                            class2.int_2 = Class734.smethod_26(str);
                        }
                    }
                    else
                    {
                        class2.int_1 = Class734.smethod_26(str);
                    }
                }
                else
                {
                    class2.int_0 = Class734.smethod_26(str);
                }
            }
        }
        return class2;
    }

    private static void smethod_43(ShapeBase A_0, Class394 A_1)
    {
        int num = 0;
        while (A_1.method_19())
        {
            string str = A_1.method_3();
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_219 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                    dictionary1.Add(BookmarkStart.b("䌥倧帩", num), 0);
                    dictionary1.Add(BookmarkStart.b("別儧娩䤫", num), 1);
                    dictionary1.Add(BookmarkStart.b("䄥䤧娩", num), 2);
                    dictionary1.Add(BookmarkStart.b("䜥䘧䴩䀫䬭", num), 3);
                    dictionary1.Add(BookmarkStart.b("䈥娧䔩尫", num), 4);
                    dictionary1.Add(BookmarkStart.b("䈥䄧天堫伭帯儱儳", num), 5);
                    dictionary1.Add(BookmarkStart.b("䨥䴧䐩䬫娭堯", num), 6);
                    dictionary1.Add(BookmarkStart.b("䤥䘧", num), 7);
                    dictionary1.Add(BookmarkStart.b("䜥䬧䤩䤫䀭䐯倱唳䐵", num), 8);
                    dictionary1.Add(BookmarkStart.b("別䴧利堫䰭弯䀱倳匵䨷", num), 9);
                    dictionary1.Add(BookmarkStart.b("䬥䄧䐩夫崭䠯", num), 10);
                    dictionary1.Add(BookmarkStart.b("䬥䄧䐩夫崭䤯", num), 11);
                    dictionary1.Add(BookmarkStart.b("䈥娧䔩尫伭䔯䘱嬳", num), 12);
                    dictionary1.Add(BookmarkStart.b("䨥䴧䐩䬫娭堯䄱䐳匵嬷匹娻圽┿♁", num), 13);
                    Class1160.dictionary_219 = dictionary1;
                }
                if (Class1160.dictionary_219.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 1:
                            A_0.SetShapeAttribute(0x340, Class1085.smethod_43(str));
                            break;

                        case 2:
                            smethod_50(A_0, 0x341, str);
                            break;

                        case 3:
                            A_0.SetShapeAttribute(0x342, Class1085.smethod_19(str));
                            break;

                        case 4:
                            A_0.SetShapeAttribute(0x343, Class1085.smethod_17(str));
                            break;

                        case 5:
                            smethod_50(A_0, 0x344, str);
                            break;

                        case 6:
                            smethod_50(A_0, 0x345, str);
                            break;

                        case 7:
                            smethod_47(A_0, 0x379, str);
                            break;

                        case 8:
                            smethod_47(A_0, 890, str);
                            break;

                        case 9:
                            smethod_47(A_0, 0x37b, str);
                            break;

                        case 10:
                            smethod_47(A_0, 0x37c, str);
                            break;

                        case 11:
                            smethod_47(A_0, 0x37d, str);
                            break;

                        case 12:
                            smethod_47(A_0, 0x37e, str);
                            break;

                        case 13:
                            smethod_47(A_0, 0x37f, str);
                            break;
                    }
                }
            }
        }
    }

    private static Class954[] smethod_44(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ';' });
        Class954[] classArray = new Class954[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            string[] strArray2 = strArray[i].Split(new char[] { ' ' });
            Class846 class3 = new Class846(strArray2[0]);
            if (!class3.method_3())
            {
                return null;
            }
            classArray[i] = new Class954 { int_0 = class3.method_12(), color_0 = Class735.smethod_0(strArray2[1]) };
        }
        return classArray;
    }

    private static void smethod_45(ShapeBase A_0, Class394 A_1)
    {
        int num = 6;
        while (A_1.method_19())
        {
            string str2 = A_1.method_3();
            string str = A_1.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("堫圭䀯圱", num))
                {
                    if (!(str == BookmarkStart.b("弫䜭启圱", num)))
                    {
                        if ((str == BookmarkStart.b("䴫䀭匯娱嬳䐵䀷", num)) || (str == BookmarkStart.b("䴫䀭匯娱嬳䐵䄷", num)))
                        {
                        }
                    }
                    else
                    {
                        A_0.SetShapeAttribute(0x1002, Class1085.smethod_55(str2));
                    }
                }
                else
                {
                    TextWrappingStyle style = Class1085.smethod_71(str2);
                    if (!A_0.ShapePr.method_6(0x1001) || (style != TextWrappingStyle.Inline))
                    {
                        A_0.ShapePr.Remove(0x3ba);
                        A_0.SetShapeAttribute(0x1001, style);
                    }
                }
            }
        }
    }

    private static void smethod_46(ShapeBase A_0, int A_1, Class394 A_2)
    {
        int num = 0x12;
        Border border = (Border) A_0.ShapePr.method_32(A_1);
        while (A_2.method_19())
        {
            string str = A_2.method_3();
            string str2 = A_2.method_1();
            if (str2 != null)
            {
                if (str2 != BookmarkStart.b("䰷䌹䰻嬽", num))
                {
                    if (!(str2 == BookmarkStart.b("伷匹堻䨽⠿", num)))
                    {
                        if (str2 == BookmarkStart.b("䬷刹崻娽⼿㕁", num))
                        {
                            border.Shadow = str == BookmarkStart.b("䰷", num);
                        }
                    }
                    else
                    {
                        border.LineWidth = Class1041.smethod_13(str) / 8f;
                    }
                }
                else
                {
                    border.SetAttr(2, Class1085.smethod_15(str));
                }
            }
        }
    }

    private static void smethod_47(ShapeBase A_0, int A_1, string A_2)
    {
        int num = 0x12;
        string str = A_2;
        if (str != null)
        {
            if (((str == BookmarkStart.b("䰷", num)) || (str == BookmarkStart.b("ष", num))) || (str == BookmarkStart.b("圷吹", num)))
            {
                A_0.SetShapeAttribute(A_1, true);
            }
            else if (((str == BookmarkStart.b("帷", num)) || (str == BookmarkStart.b("࠷", num))) || (str == BookmarkStart.b("圷尹娻", num)))
            {
                A_0.SetShapeAttribute(A_1, false);
            }
        }
    }

    private static void smethod_48(ShapeBase A_0, int A_1, string A_2, string A_3, string A_4)
    {
        if (A_4 == A_2)
        {
            A_0.SetShapeAttribute(A_1, true);
        }
        else if (A_4 == A_3)
        {
            A_0.SetShapeAttribute(A_1, false);
        }
    }

    private static Class1031 smethod_49(string A_0)
    {
        Class1031 class2 = new Class1031();
        class2.method_13(Class735.smethod_0(A_0));
        return class2;
    }

    private static ShapeBase smethod_5(Interface50 A_0, bool A_1)
    {
        int num = 5;
        ShapeBase base2 = null;
        Class394 class2 = A_0.imethod_1();
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_203 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x10);
                dictionary1.Add(BookmarkStart.b("堪䔬丮䄰嘲䄴丶䤸帺", num), 0);
                dictionary1.Add(BookmarkStart.b("䤪䐬䄮田刲䄴嘶", num), 1);
                dictionary1.Add(BookmarkStart.b("䰪弬䀮䐰䌲", num), 2);
                dictionary1.Add(BookmarkStart.b("堪䔬丮䄰嘲", num), 3);
                dictionary1.Add(BookmarkStart.b("嬪䈬䌮䠰弲尴夶尸", num), 4);
                dictionary1.Add(BookmarkStart.b("太䠬䰮䔰", num), 5);
                dictionary1.Add(BookmarkStart.b("太䈬娮弰圲䜴制娸伺", num), 6);
                dictionary1.Add(BookmarkStart.b("䜪䐬䄮吰", num), 7);
                dictionary1.Add(BookmarkStart.b("䐪嬬丮崰", num), 8);
                dictionary1.Add(BookmarkStart.b("堪丬崮堰䌲䄴瘶圸堺唼倾㍀", num), 9);
                dictionary1.Add(BookmarkStart.b("䨪弬䰮", num), 10);
                dictionary1.Add(BookmarkStart.b("䈪䀬丮嘰嘲", num), 11);
                dictionary1.Add(BookmarkStart.b("䠪堬崮䜰嘲", num), 12);
                dictionary1.Add(BookmarkStart.b("䐪丬圮", num), 13);
                dictionary1.Add(BookmarkStart.b("䠪䈬䄮䔰䄲娴嬶", num), 14);
                dictionary1.Add(BookmarkStart.b("搪愬樮縰儲弴制娸伺", num), 15);
                Class1160.dictionary_203 = dictionary1;
            }
            if (Class1160.dictionary_203.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    {
                        string str2 = class2.method_12(BookmarkStart.b("䈪䤬", num), null);
                        Class43 class3 = smethod_3(A_0);
                        A_0.imethod_11(str2, class3);
                        return base2;
                    }
                    case 1:
                        A_0.imethod_9();
                        return base2;

                    case 2:
                        base2 = new ShapeGroup(A_0.imethod_0());
                        smethod_10(A_0, base2, A_1);
                        return base2;

                    case 3:
                    case 4:
                        base2 = new ShapeObject(A_0.imethod_0());
                        base2.SetShapeType(ShapeType.NonPrimitive);
                        smethod_10(A_0, base2, A_1);
                        return base2;

                    case 5:
                        base2 = new ShapeObject(A_0.imethod_0(), ShapeType.Rectangle);
                        smethod_10(A_0, base2, A_1);
                        return base2;

                    case 6:
                        base2 = new ShapeObject(A_0.imethod_0(), ShapeType.RoundRectangle);
                        smethod_10(A_0, base2, A_1);
                        return base2;

                    case 7:
                        base2 = new ShapeObject(A_0.imethod_0(), ShapeType.Line);
                        smethod_10(A_0, base2, A_1);
                        return base2;

                    case 8:
                        base2 = new ShapeObject(A_0.imethod_0(), ShapeType.Ellipse);
                        smethod_10(A_0, base2, A_1);
                        return base2;

                    case 9:
                        return smethod_6(A_0);

                    case 10:
                    case 11:
                    case 12:
                        class2.vmethod_1();
                        return base2;

                    case 13:
                        return Class331.smethod_1(A_0);

                    case 14:
                        return Class331.smethod_0(A_0);

                    case 15:
                        Class331.smethod_2(A_0);
                        return base2;
                }
            }
        }
        class2.vmethod_1();
        return base2;
    }

    private static void smethod_50(ShapeBase A_0, int A_1, string A_2)
    {
        smethod_51(A_0, A_1, new Class846(A_2));
    }

    private static void smethod_51(ShapeBase A_0, int A_1, Class846 A_2)
    {
        if (A_2.method_2())
        {
            A_0.SetShapeAttribute(A_1, A_2.method_7());
        }
    }

    private static void smethod_52(ShapeBase A_0, int A_1, string A_2)
    {
        smethod_53(A_0, A_1, new Class846(A_2));
    }

    private static void smethod_53(ShapeBase A_0, int A_1, Class846 A_2)
    {
        if (A_2.method_3())
        {
            A_0.SetShapeAttribute(A_1, A_2.method_12());
        }
    }

    private static void smethod_54(ShapeBase A_0, int A_1, string A_2)
    {
        Class846 class2 = new Class846(A_2);
        if (class2.method_4())
        {
            A_0.SetShapeAttribute(A_1, class2.method_11());
        }
    }

    private static void smethod_55(ShapeBase A_0, int A_1, string A_2)
    {
        if (Class567.smethod_16(A_2))
        {
            A_0.SetShapeAttribute(A_1, Class1041.smethod_23(A_2));
        }
    }

    private static int[] smethod_56(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ',' });
        int[] numArray = new int[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            string str = strArray[i];
            numArray[i] = (int) Math.Round(Class1041.smethod_12(str));
        }
        return numArray;
    }

    private static void smethod_57(ShapeBase A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            string[] strArray = A_1.Split(new char[] { ',' });
            for (int i = 0; i < strArray.Length; i++)
            {
                string str = strArray[i];
                if (str != "")
                {
                    A_0.SetShapeAttribute(0x147 + i, Class1041.smethod_23(str));
                }
            }
        }
    }

    private static void smethod_58(ShapeBase A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            Class233 class2 = new Class233(A_1);
            A_0.SetShapeAttribute(0x146, class2.method_4());
            A_0.SetShapeAttribute(0x145, class2.method_5());
        }
    }

    private static void smethod_59(ShapeBase A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            Class846[] classArray2 = smethod_69(A_1);
            Class891[] classArray3 = new Class891[classArray2.Length / 2];
            for (int i = 0; i < classArray3.Length; i++)
            {
                classArray3[i] = new Class891(classArray2[2 * i].method_9(), classArray2[(2 * i) + 1].method_9());
            }
            A_0.SetShapeAttribute(0x145, classArray3);
            Class679[] classArray = new Class679[(classArray3.Length * 2) + 1];
            classArray[0] = new Class679(PathType.MoveTo, 0);
            for (int j = 1; j < (classArray.Length - 1); j++)
            {
                if (Class567.smethod_3((long) j))
                {
                    classArray[j] = new Class679(PathType.EscapeAutoLine, 0);
                }
                else
                {
                    classArray[j] = new Class679(PathType.LineTo, 1);
                }
            }
            classArray[classArray.Length - 1] = new Class679(PathType.End, 0);
            A_0.SetShapeAttribute(0x146, classArray);
        }
    }

    private static ShapeObject smethod_6(Interface50 A_0)
    {
        int num = 0;
        ShapeObject obj2 = new ShapeObject(A_0.imethod_0());
        obj2.SetShapeType(ShapeType.Image);
        obj2.SetShapeAttribute(0x3bf, false);
        obj2.SetShapeAttribute(0x1fc, false);
        obj2.SetShapeAttribute(0x1001, TextWrappingStyle.Inline);
        obj2.SetShapeAttribute(0x7f, true);
        obj2.SetShapeAttribute(0x1000, FlipOrientation.None);
        obj2.SetShapeAttribute(0x1007, BookmarkStart.b("栥䜧堩䄫伭尯", 0));
        obj2.SetShapeAttribute(0x3be, true);
        obj2.SetShapeAttribute(0x3b7, false);
        obj2.SetShapeAttribute(0x3b8, true);
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("唥䬧堩䔫席䐯猱娳唵倷唹主", num)))
        {
            string str = class2.method_21();
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (str2 != BookmarkStart.b("䨥䤧䐩䬫嬭儯唱儳", num))
                {
                    if (!(str2 == BookmarkStart.b("䜥娧䴩弫", num)))
                    {
                        if (str2 == BookmarkStart.b("唥䬧堩䔫席䐯昱儳丵䰷", num))
                        {
                            obj2.SetShapeAttribute(910, str);
                        }
                    }
                    else
                    {
                        obj2.SetShapeAttribute(0x397, str);
                    }
                }
                else
                {
                    obj2.SetShapeAttribute(0x39a, str);
                    ScriptLanguage language = Class1085.smethod_0(str);
                    if (language != ScriptLanguage.None)
                    {
                        obj2.SetShapeAttribute(920, language);
                    }
                }
            }
        }
        return obj2;
    }

    private static void smethod_60(ShapeBase A_0, string A_1)
    {
        string[] strArray = A_1.Split(new char[] { ',' });
        int index = 0;
        int num2 = strArray.Length - 1;
        for (int i = 0x209; i <= 0x20c; i++)
        {
            smethod_52(A_0, i, strArray[index]);
            index++;
            if (index > num2)
            {
                return;
            }
        }
        for (int j = 0x20d; j <= 0x20e; j++)
        {
            string str = strArray[index];
            if (str != "")
            {
                A_0.SetShapeAttribute(j, Class734.smethod_25(str));
            }
            index++;
            if (index > num2)
            {
                return;
            }
        }
    }

    private static void smethod_61(ShapeBase A_0, string A_1)
    {
        string[] strArray = A_1.Split(new char[] { ',' });
        int index = 0;
        int num2 = strArray.Length - 1;
        for (int i = 0x81; i <= 0x84; i++)
        {
            smethod_50(A_0, i, strArray[index]);
            index++;
            if (index > num2)
            {
                return;
            }
        }
    }

    private static void smethod_62(ShapeBase A_0, string A_1)
    {
        Class846[] classArray = smethod_69(A_1);
        smethod_53(A_0, 710, classArray[0]);
        if (classArray.Length > 1)
        {
            smethod_53(A_0, 0x2c7, classArray[1]);
        }
        if (classArray.Length > 2)
        {
            smethod_51(A_0, 0x2c8, classArray[2]);
        }
    }

    private static void smethod_63(ShapeBase A_0, int A_1, int A_2, int A_3, string A_4)
    {
        string[] strArray = A_4.Split(new char[] { ',' });
        smethod_55(A_0, A_1, strArray[0]);
        if (strArray.Length > 1)
        {
            smethod_55(A_0, A_2, strArray[1]);
        }
        if (strArray.Length > 2)
        {
            smethod_55(A_0, A_3, strArray[2]);
        }
    }

    private static void smethod_64(ShapeBase A_0, int A_1, int A_2, int A_3, string A_4)
    {
        Class846[] classArray = smethod_69(A_4);
        smethod_51(A_0, A_1, classArray[0]);
        if (classArray.Length > 1)
        {
            smethod_51(A_0, A_2, classArray[1]);
        }
        if (classArray.Length > 2)
        {
            smethod_51(A_0, A_3, classArray[2]);
        }
    }

    private static void smethod_65(ShapeBase A_0, int A_1, int A_2, string A_3)
    {
        Class846[] classArray = smethod_69(A_3);
        smethod_51(A_0, A_1, classArray[0]);
        if (classArray.Length > 1)
        {
            smethod_51(A_0, A_2, classArray[1]);
        }
    }

    private static void smethod_66(ShapeBase A_0, int A_1, int A_2, string A_3)
    {
        Class846[] classArray = smethod_69(A_3);
        smethod_53(A_0, A_1, classArray[0]);
        if (classArray.Length > 1)
        {
            smethod_53(A_0, A_2, classArray[1]);
        }
    }

    private static double smethod_67(string A_0, double A_1)
    {
        Class846 class2 = new Class846(A_0);
        if (!class2.method_2())
        {
            return A_1;
        }
        return class2.method_8();
    }

    private static int smethod_68(string A_0)
    {
        Class846 class2 = new Class846(A_0);
        if (!class2.method_1())
        {
            return 0;
        }
        return class2.method_10();
    }

    private static Class846[] smethod_69(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ',' });
        Class846[] classArray = new Class846[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            classArray[i] = new Class846(strArray[i]);
        }
        return classArray;
    }

    private static void smethod_7(Class846 A_0, ShapeBase A_1)
    {
        if (A_0.method_2())
        {
            double num = A_0.method_8() - A_1.Top;
            if (A_1.Top > A_0.method_8())
            {
                num = A_1.Top - A_0.method_8();
                A_1.Top = A_0.method_8();
            }
            A_1.method_39(num);
        }
    }

    private static Class914[] smethod_70(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ';' });
        Class914[] classArray = new Class914[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            classArray[i] = Class914.smethod_0(strArray[i]);
        }
        return smethod_71(classArray);
    }

    private static Class914[] smethod_71(Class914[] A_0)
    {
        int num = 0;
        for (int i = 0; i < A_0.Length; i++)
        {
            if (A_0[i] != null)
            {
                A_0[num++] = A_0[i];
            }
        }
        Class914[] classArray = new Class914[num];
        for (int j = 0; j < classArray.Length; j++)
        {
            classArray[j] = A_0[j];
        }
        return classArray;
    }

    private static void smethod_72(ShapeBase A_0, string A_1)
    {
        double num;
        Class846 class2 = new Class846(A_1);
        if (class2.method_4())
        {
            num = ((double) class2.method_11()) / 100.0;
        }
        else
        {
            if (!class2.method_3())
            {
                return;
            }
            num = Class969.smethod_68(class2.method_12());
        }
        num = (num < 0.0) ? 0.0 : num;
        int num2 = Class1133.smethod_5(num * A_0.CoordSizeWidth);
        A_0.SetShapeAttribute(0x147, num2);
    }

    private static void smethod_8(Class846 A_0, ShapeBase A_1)
    {
        if (A_0.method_2())
        {
            double num = A_0.method_8() - A_1.Left;
            if (A_0.method_8() < A_1.Left)
            {
                num = A_1.Left - A_0.method_8();
                A_1.Left = A_0.method_8();
            }
            A_1.method_37(num);
        }
    }

    private static void smethod_9(Interface50 A_0, ShapeBase A_1)
    {
        smethod_10(A_0, A_1, false);
    }
}

