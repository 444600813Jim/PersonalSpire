using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class Class1097
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly ArrayList arrayList_1 = new ArrayList();
    private bool bool_0 = false;
    private bool bool_1;
    private Class43 class43_0;
    private Class784[] class784_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private ShapeObject shapeObject_0;
    private string[] string_0;
    private string[] string_1;
    private string[] string_2;
    private readonly StringBuilder stringBuilder_0 = new StringBuilder();

    internal Class1097()
    {
    }

    internal void method_0(Class857 A_0, DocumentObject A_1, CharacterFormat A_2)
    {
        int num = 12;
        Class576.smethod_94(1.0);
        this.shapeObject_0 = new ShapeObject(A_0.method_9());
        string str = A_0.method_11().method_1();
        if (A_2 != null)
        {
            A_2.method_37(this.shapeObject_0.CharacterFormat);
        }
        this.class43_0 = new Class43();
        this.class43_0.SetAttr(0x103b, ShapeType.NonPrimitive);
        this.method_2(A_0);
        Class746.smethod_1(A_0, this.shapeObject_0.ShapePr);
        this.method_1(A_0, str);
        this.class43_0.method_37(this.shapeObject_0.ShapePr);
        Class746.smethod_2(this.shapeObject_0, (Class98) A_0.method_13().method_2(A_0.method_16(), BookmarkStart.b("唱䘳圵䠷刹唻崽", num), A_0.method_20(), true));
        A_1.method_13(this.shapeObject_0);
    }

    private void method_1(Class857 A_0, string A_1)
    {
        int num = 0x11;
        Class396 class2 = A_0.method_11();
        while (class2.method_9(A_1))
        {
            string str;
            if ((!Class857.smethod_13(A_0, this.shapeObject_0) && !A_0.method_5(this.class43_0)) && (((str = class2.method_1()) != null) && (str == BookmarkStart.b("制圸区尼儾≀♂⅄橆⹈⹊≌≎㑐❒❔⹖", num))))
            {
                this.method_4(A_0);
            }
        }
        if (this.bool_1)
        {
            this.shapeObject_0.ChildObjects.Clear();
        }
        if ((this.class784_0 != null) && (this.class784_0.Length > 0))
        {
            this.shapeObject_0.ShapePr.SetAttr(0x155, this.class784_0);
        }
    }

    private Class784 method_10(Class857 A_0)
    {
        int num = 3;
        Class396 class2 = A_0.method_11();
        Class784 class3 = new Class784 {
            class623_2 = new Class623(-2147483648),
            class623_3 = new Class623(0x7fffffff),
            class623_4 = new Class623(-2147483648),
            class623_5 = new Class623(0x7fffffff)
        };
        while (class2.method_19())
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_227 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ䜶嘸䠺吼䬾⡀ⱂ⭄", num), 0);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ娶倸䤺似倾㍀湂ⵄ⡆㭈≊㝌⁎㽐❒㑔㭖", num), 1);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ娶倸䤺似倾㍀湂㍄≆㭈㽊⑌ⱎぐ㽒", num), 2);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ䐶丸刺䤼尾⥀♂⅄", num), 3);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ䔶堸唺娼娾汀㭂桄⩆⁈╊⑌≎⑐㹒", num), 4);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ䔶堸唺娼娾汀㭂桄⩆⡈㍊⑌≎⑐㹒", num), 5);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ䔶堸唺娼娾汀㩂桄⩆⁈╊⑌≎⑐㹒", num), 6);
                    dictionary1.Add(BookmarkStart.b("䄨䨪䌬䬮崰嘲ᠴ䔶堸唺娼娾汀㩂桄⩆⡈㍊⑌≎⑐㹒", num), 7);
                    Class1160.dictionary_227 = dictionary1;
                }
                if (Class1160.dictionary_227.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            string[] strArray = class2.method_3().Split(new char[] { ' ' });
                            if (strArray.Length == 2)
                            {
                                class3.class72_0 = this.method_12(strArray[0], true);
                                class3.class72_1 = this.method_12(strArray[1], false);
                            }
                            break;
                        }
                        case 1:
                            class3.bool_5 = class2.method_3() == BookmarkStart.b("崨太堬䨮", num);
                            break;

                        case 2:
                            class3.bool_6 = class2.method_3() == BookmarkStart.b("崨太堬䨮", num);
                            break;

                        case 3:
                            class3.bool_4 = class2.method_3() == BookmarkStart.b("崨太堬䨮", num);
                            break;

                        case 4:
                            class3.bool_1 = true;
                            class3.class623_2 = this.method_11(class2.method_3(), true);
                            break;

                        case 5:
                            class3.bool_1 = true;
                            class3.class623_3 = this.method_11(class2.method_3(), true);
                            break;

                        case 6:
                            class3.bool_1 = true;
                            class3.class623_4 = this.method_11(class2.method_3(), false);
                            break;

                        case 7:
                            class3.bool_1 = true;
                            class3.class623_5 = this.method_11(class2.method_3(), false);
                            break;
                    }
                }
            }
        }
        return class3;
    }

    private Class623 method_11(string A_0, bool A_1)
    {
        int num = 1;
        if (Class567.smethod_16(A_0))
        {
            int num3;
            string str = A_0;
            if (str != null)
            {
                if (str == BookmarkStart.b("䬦䰨䴪夬", num))
                {
                    return new Class623(A_1 ? 0 : (this.int_0 + this.int_2), true);
                }
                if (str == BookmarkStart.b("匦䘨嬪", num))
                {
                    return new Class623(A_1 ? this.int_1 : 0, true);
                }
                if (str == BookmarkStart.b("唦䀨䰪䔬嬮", num))
                {
                    return new Class623(A_1 ? 1 : (this.int_0 + this.int_2), true);
                }
                if (str == BookmarkStart.b("䔦䘨弪夬䀮尰", num))
                {
                    return new Class623(A_1 ? (this.int_1 + this.int_3) : 1, true);
                }
            }
            if (A_0[0] == '?')
            {
                for (int i = 0; i < this.arrayList_0.Count; i++)
                {
                    if (((Class414) this.arrayList_0[i]).string_0 == A_0.Substring(1))
                    {
                        return new Class623(i + 3, true);
                    }
                }
            }
            if (A_0[0] == '$')
            {
                num3 = Class1041.smethod_18(A_0.Substring(1));
                if (num3 != -2147483648)
                {
                    return new Class623(num3 + 0x100, true);
                }
            }
            num3 = Class1041.smethod_18(A_0);
            if (num3 != -2147483648)
            {
                return new Class623(Class576.smethod_2(num3), false);
            }
        }
        return new Class623(0, false);
    }

    private Class72 method_12(string A_0, bool A_1)
    {
        int num2;
        int num = 13;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("弲倴儶䴸", num))
            {
                return new Class72(A_1 ? HandlePositionType.LeftTop : HandlePositionType.Constant, A_1 ? 0 : (this.int_0 + this.int_2));
            }
            if (str == BookmarkStart.b("䜲娴䜶", num))
            {
                return new Class72(A_1 ? HandlePositionType.Constant : HandlePositionType.LeftTop, A_1 ? this.int_1 : 0);
            }
            if (str == BookmarkStart.b("䄲尴倶儸伺", num))
            {
                return new Class72(A_1 ? HandlePositionType.RightBottom : HandlePositionType.Constant, A_1 ? 0 : (this.int_0 + this.int_2));
            }
            if (str == BookmarkStart.b("儲娴䌶䴸吺值", num))
            {
                return new Class72(A_1 ? HandlePositionType.Constant : HandlePositionType.RightBottom, A_1 ? (this.int_1 + this.int_3) : 0);
            }
        }
        if (A_0[0] == '?')
        {
            return new Class72(HandlePositionType.Constant, this.method_22(A_0.Substring(1)));
        }
        if (A_0[0] == '$')
        {
            num2 = Class1041.smethod_18(A_0.Substring(1));
            if (num2 != -2147483648)
            {
                return new Class72(HandlePositionType.Adjust, num2);
            }
            if (num2 != -2147483648)
            {
                num2 = Class1041.smethod_18(this.string_2[num2]);
                if (num2 != -2147483648)
                {
                    return new Class72(HandlePositionType.Constant, Class576.smethod_2(num2));
                }
            }
            return new Class72(HandlePositionType.Constant, 0);
        }
        num2 = Class1041.smethod_18(A_0);
        if (num2 != -2147483648)
        {
            return new Class72(HandlePositionType.Constant, Class576.smethod_2(num2));
        }
        return new Class72();
    }

    private void method_13(Class857 A_0)
    {
        int num = 7;
        Class396 class2 = A_0.method_11();
        FlipOrientation none = FlipOrientation.None;
        string str = BookmarkStart.b("ᴬ༮İጲܴض༸଺഼Ἶ獀牂獄睆祈", 7);
        bool flag = false;
        bool flag2 = false;
        while (class2.method_19())
        {
            string[] strArray2;
            int[] numArray;
            int num2;
            string key = class2.method_1();
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_228 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x22);
                    dictionary1.Add(BookmarkStart.b("嬬䘮吰䐲眴堶䄸", num), 0);
                    dictionary1.Add(BookmarkStart.b("䠬䄮夰刲嬴吶尸强ြ伾⁀㝂ⵄ", num), 1);
                    dictionary1.Add(BookmarkStart.b("䀬䀮唰娲匴帶尸䤺丼", num), 2);
                    dictionary1.Add(BookmarkStart.b("夬䨮䤰䜲ᠴ䜶堸伺唼", num), 3);
                    dictionary1.Add(BookmarkStart.b("夬䨮䤰䜲ᠴ嘶䬸帺尼䰾", num), 4);
                    dictionary1.Add(BookmarkStart.b("䀬䘮䌰䄲娴䔶ᐸ区刼䴾⡀㥂⩄⥆㵈⩊⅌", num), 5);
                    dictionary1.Add(BookmarkStart.b("䀬䘮䌰䄲娴䔶ᐸ䴺堼䴾㕀⩂♄♆╈", num), 6);
                    dictionary1.Add(BookmarkStart.b("崬丮䔰嬲ᠴ䐶䴸䤺堼䬾≀⭂㕄⡆⁈╊㥌扎⥐", num), 7);
                    dictionary1.Add(BookmarkStart.b("崬丮䔰嬲ᠴ䐶䴸䤺堼䬾≀⭂㕄⡆⁈╊㥌扎⡐", num), 8);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ≀ⱂ⥄⡆㭈", num), 9);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼", num), 10);
                    dictionary1.Add(BookmarkStart.b("帬䜮倰圲倴ᨶ吸吺夼娾", num), 11);
                    dictionary1.Add(BookmarkStart.b("崬崮帰夲倴吶䴸刺刼儾", num), 12);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ⍀ㅂⱄ⁆ⅈ㽊⍌⩎≐⁒", num), 13);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㉀⭂ⱄ⥆⁈╊⡌㱎≐", num), 14);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㉀㍂⁄⑆㱈❊ⱌ㵎㡐❒ⱔ", num), 15);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ╀⩂⍄ⅆ㱈㡊⑌⁎㽐", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾⱀ♂ㅄ♆╈", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㍀ⱂㅄ♆㵈≊≌ⅎ籐㉒㭔ざ㕘㹚", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ⹀ㅂⱄ⁆⁈╊", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ❀⩂㝄㑆㵈晊⅌♎㙐㭒⅔穖㵘㉚⽜㩞ɠᝢ౤ࡦݨ", num), 20);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㉀♂♄⡆❈⽊恌⍎㡐㑒㵔⍖瑘㽚㑜ⵞѠbᅤ๦٨ժ", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㍀ⱂㅄ♆㵈≊≌ⅎ籐げご㥖ⵘ㹚⽜", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㉀⡂⁄う", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ╀♂㕄㍆ⅈ", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㝀⩂⁄う㥈⑊⑌ⅎ═", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ❀⩂㝄㑆㵈晊⅌♎㙐㭒⅔穖㕘㹚⭜㩞ൠ", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㉀♂♄⡆❈⽊恌⍎㡐㑒㵔⍖瑘㝚㡜⥞Ѡར", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ❀⩂㝄㑆㵈晊⅌♎㙐㭒⅔穖ㅘ㩚⽜ⱞॠ", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾ㉀♂♄⡆❈⽊恌⍎㡐㑒㵔⍖瑘㍚㱜ⵞበୢ", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("䠬圮䔰䄲䀴䐶倸吺匼ሾⵀ⩂≄⽆㵈晊⭌⹎㉐㙒", num), 30);
                    dictionary1.Add(BookmarkStart.b("䨬䌮䐰嘲ᠴ䜶嘸刺匼䬾汀㝂㱄㝆ⱈ", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("䨬䌮䐰嘲ᠴ䜶嘸刺匼䬾㉀", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("䨬䌮䐰嘲ᠴ䜶嘸刺匼䬾汀⽂⁄♆㽈≊⍌⡎籐㝒㱔╖㱘㡚⥜㙞๠ൢᙤ", num), 0x21);
                    Class1160.dictionary_228 = dictionary1;
                }
                if (Class1160.dictionary_228.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                            str = class2.method_3();
                            break;

                        case 1:
                            this.method_17(class2.method_3());
                            break;

                        case 2:
                            this.method_16(class2.method_3());
                            break;

                        case 3:
                            this.bool_1 = class2.method_3() == BookmarkStart.b("夬崮䐰嘲", num);
                            this.class43_0.SetAttr(0xf1, this.bool_1);
                            if (this.bool_1)
                            {
                                this.class43_0.SetAttr(0x103b, ShapeType.TextPlainText);
                            }
                            break;

                        case 4:
                            this.string_0 = class2.method_3().Trim().Split(new char[] { ' ' });
                            break;

                        case 5:
                            none = (none == FlipOrientation.Vertical) ? FlipOrientation.Both : FlipOrientation.Horizontal;
                            break;

                        case 6:
                            none = (none == FlipOrientation.Horizontal) ? FlipOrientation.Both : FlipOrientation.Vertical;
                            break;

                        case 7:
                            flag = true;
                            break;

                        case 8:
                            flag2 = true;
                            break;

                        case 10:
                            if (class2.method_3() == BookmarkStart.b("夬崮䐰嘲", num))
                            {
                                this.class43_0.SetAttr(700, true);
                            }
                            break;

                        case 11:
                            this.class43_0.SetAttr(0x2c9, (class2.method_3() == BookmarkStart.b("䤬崮倰唲䄴", num)) ? ThreeDRenderMode.Wireframe : ThreeDRenderMode.FullRender);
                            break;

                        case 12:
                            if (class2.method_3() == BookmarkStart.b("崬䨮䌰䀲䔴制娸伺吼䤾⑀", num))
                            {
                                this.class43_0.SetAttr(0x2fd, false);
                            }
                            break;

                        case 13:
                            this.class43_0.SetAttr(0x2d2, Class576.smethod_28(class2.method_3()));
                            break;

                        case 14:
                        {
                            int num5 = Class1041.smethod_18(class2.method_3().Replace(BookmarkStart.b("ࠬ", num), ""));
                            if (num5 != -2147483648)
                            {
                                this.class43_0.SetAttr(0x282, num5 / 10);
                            }
                            break;
                        }
                        case 15:
                            this.class43_0.SetAttr(640, Class576.smethod_28(class2.method_3()));
                            break;

                        case 0x10:
                            this.class43_0.SetAttr(0x281, Class576.smethod_28(class2.method_3()));
                            break;

                        case 0x11:
                            if (class2.method_3() == BookmarkStart.b("夬崮䐰嘲", num))
                            {
                                this.class43_0.SetAttr(0x2bd, true);
                            }
                            break;

                        case 0x12:
                            smethod_1(this.class43_0, 0x2c1, 0x2c0, -1, class2.method_3());
                            break;

                        case 0x13:
                            smethod_1(this.class43_0, 0x2ce, 0x2cf, -1, class2.method_3());
                            break;

                        case 20:
                            smethod_1(this.class43_0, 0x2d3, 0x2d4, 0x2d5, class2.method_3());
                            break;

                        case 0x15:
                            smethod_1(this.class43_0, 0x2d7, 0x2d8, 0x2d9, class2.method_3());
                            break;

                        case 0x16:
                            smethod_1(this.class43_0, 710, 0x2c7, 0x2c8, class2.method_3());
                            break;

                        case 0x17:
                            goto Label_069F;

                        case 0x18:
                        {
                            string[] strArray = class2.method_3().Split(new char[] { ' ' });
                            if (strArray.Length == 2)
                            {
                                this.class43_0.SetAttr(0x285, Class576.smethod_55(strArray[0]));
                                this.class43_0.SetAttr(0x284, Class969.smethod_40(Class1041.smethod_12(strArray[1])));
                            }
                            break;
                        }
                        case 0x19:
                        {
                            string[] strArray3 = class2.method_3().Replace(BookmarkStart.b("Ԭ", num), "").Replace(BookmarkStart.b("Ь", num), "").Split(new char[] { ' ' });
                            if (strArray3.Length == 3)
                            {
                                this.class43_0.SetAttr(0x2cb, Class576.smethod_55(strArray3[0]));
                                this.class43_0.SetAttr(0x2cc, Class576.smethod_55(strArray3[1]));
                                this.class43_0.SetAttr(0x2cd, Class576.smethod_55(strArray3[2]));
                            }
                            break;
                        }
                        case 0x1a:
                            this.class43_0.SetAttr(0x2d6, Class576.smethod_7(class2.method_3()));
                            break;

                        case 0x1b:
                            this.class43_0.SetAttr(730, Class576.smethod_7(class2.method_3()));
                            break;

                        case 0x1c:
                            if (class2.method_3() == BookmarkStart.b("䬬丮崰䀲倴", num))
                            {
                                this.class43_0.SetAttr(0x2fe, false);
                            }
                            break;

                        case 0x1d:
                            if (class2.method_3() == BookmarkStart.b("夬崮䐰嘲", num))
                            {
                                this.class43_0.SetAttr(0x2ff, true);
                            }
                            break;

                        case 30:
                            if (class2.method_3() == BookmarkStart.b("䬬丮崰䀲倴", num))
                            {
                                this.class43_0.SetAttr(0x2bf, false);
                            }
                            break;

                        case 0x1f:
                            this.class43_0.SetAttr(0x158, Class922.smethod_2(class2.method_3()));
                            break;

                        case 0x20:
                            this.string_1 = class2.method_3().Trim().Split(new char[] { ' ' });
                            break;

                        case 0x21:
                            strArray2 = class2.method_3().Split(new char[] { ',' });
                            numArray = new int[strArray2.Length];
                            num2 = 0;
                            goto Label_09C1;
                    }
                }
            }
            continue;
        Label_069F:;
            string[] strArray4 = class2.method_3().Split(new char[] { ' ' });
            if (strArray4.Length == 2)
            {
                int num4 = Class1041.smethod_18(strArray4[0]);
                if (num4 != -2147483648)
                {
                    this.class43_0.SetAttr(0x2d1, num4);
                }
                this.class43_0.SetAttr(720, Class576.smethod_8(strArray4[1]));
            }
            continue;
        Label_0997:;
            numArray[num2] = Class576.smethod_8(strArray2[num2].Trim(new char[] { ' ' }));
            num2++;
        Label_09C1:
            if (num2 < strArray2.Length)
            {
                goto Label_0997;
            }
            this.class43_0.SetAttr(0x152, numArray);
        }
        Class857.smethod_12(A_0, str, flag, flag2, this.class43_0);
        this.method_15();
        this.class43_0.SetAttr(0x1000, none);
    }

    private Class623 method_14(string A_0, bool A_1, bool A_2)
    {
        int num = 13;
        if (A_0.StartsWith(BookmarkStart.b("ᜲ", 13)))
        {
            int num2 = Class1041.smethod_18(A_0.Substring(1));
            if ((num2 >= 0) && (num2 < 10))
            {
                object obj2 = this.class43_0.method_31(0x147 + num2);
                if (obj2 != null)
                {
                    return new Class623((int) obj2, true);
                }
            }
        }
        else
        {
            if (A_0.StartsWith(BookmarkStart.b("ల", num)))
            {
                return new Class623(this.method_22(A_0.Substring(1)), false);
            }
            int num3 = Class1041.smethod_18(A_0);
            if ((Class857.bool_9 && A_2) && (num3 == Class857.int_2))
            {
                num3 = (int) (num3 * Class857.double_2);
            }
            if ((Class857.bool_10 && !A_2) && (num3 == Class857.int_3))
            {
                num3 = (int) (((double) num3) / Class857.double_2);
            }
            if (num3 != -2147483648)
            {
                return new Class623(A_1 ? num3 : Class576.smethod_2(num3));
            }
        }
        return new Class623();
    }

    private void method_15()
    {
        object obj2 = this.class43_0.method_31(0x101d);
        object obj3 = this.class43_0.method_31(0x101e);
        object obj4 = this.class43_0.method_31(0x101f);
        object obj5 = this.class43_0.method_31(0x1020);
        if (obj2 != null)
        {
            this.int_0 = (int) obj2;
        }
        if (obj3 != null)
        {
            this.int_1 = (int) obj3;
        }
        if (obj4 != null)
        {
            this.int_2 = (int) obj4;
        }
        if (obj5 != null)
        {
            this.int_3 = (int) obj5;
        }
    }

    private void method_16(string A_0)
    {
        this.string_2 = A_0.Trim().Split(new char[] { ' ' });
        for (int i = 0; i < this.string_2.Length; i++)
        {
            if (i >= 8)
            {
                break;
            }
            double d = Class1041.smethod_15(this.string_2[i]);
            if (!double.IsNaN(d))
            {
                this.class43_0.SetAttr(0x147 + i, Class576.smethod_2(Class1133.smethod_5(d)));
            }
        }
    }

    private void method_17(string A_0)
    {
        for (int i = 0; i < A_0.Length; i++)
        {
            char ch = A_0[i];
            if (Class922.smethod_4(ch) != PathType.Unknown)
            {
                this.method_18();
                this.arrayList_1.Add(ch);
            }
            else if ((ch != '$') && (ch != '?'))
            {
                if ((!char.IsDigit(ch) && (ch != '-')) && !char.IsLetter(ch))
                {
                    this.method_18();
                }
                else
                {
                    this.stringBuilder_0.Append(ch);
                }
            }
            else
            {
                this.method_18();
                this.stringBuilder_0.Append(ch);
            }
        }
        this.method_18();
    }

    private void method_18()
    {
        if (this.stringBuilder_0.ToString().Length > 0)
        {
            this.arrayList_1.Add(this.stringBuilder_0.ToString());
        }
        this.stringBuilder_0.Length = 0;
    }

    private void method_19()
    {
        if ((this.string_0 != null) && (this.string_0.Length >= 4))
        {
            Class70[] classArray = new Class70[this.string_0.Length / 4];
            for (int i = 0; i < this.string_0.Length; i += 4)
            {
                Class70 class2 = new Class70 {
                    class623_0 = this.method_14(this.string_0[i], false, true),
                    class623_1 = this.method_14(this.string_0[i + 1], false, false),
                    class623_2 = this.method_14(this.string_0[i + 2], false, true),
                    class623_3 = this.method_14(this.string_0[i + 3], false, false)
                };
                classArray[i / 4] = class2;
            }
            this.class43_0.SetAttr(0x157, classArray);
        }
    }

    private void method_2(Class857 A_0)
    {
        int num = 5;
        A_0.method_17(null);
        Class396 class2 = A_0.method_11();
        string str = "";
        while (class2.method_19())
        {
            string str2;
            if ((!A_0.method_2(A_0.method_11(), this.class43_0) && !Class857.smethod_7(A_0, this.class43_0)) && (!Class857.smethod_6(A_0, this.class43_0) && ((str2 = class2.method_1()) != null)))
            {
                if (str2 != BookmarkStart.b("崪䐬䨮䘰焲娴伶", num))
                {
                    if (!(str2 == BookmarkStart.b("嬪䈬䘮弰䜲䘴", num)))
                    {
                        if (str2 == BookmarkStart.b("弪弬丮弰䀲匴堶䬸嘺", num))
                        {
                            str = class2.method_3();
                        }
                    }
                    else
                    {
                        this.method_3(class2.method_3());
                    }
                }
                else
                {
                    Class857.smethod_12(A_0, class2.method_3(), false, false, this.class43_0);
                    this.method_15();
                }
            }
        }
        Class857.smethod_4(this.class43_0, str);
    }

    private void method_20()
    {
        if (this.string_1 != null)
        {
            Class891[] classArray = new Class891[this.string_1.Length / 2];
            for (int i = 0; i < classArray.Length; i++)
            {
                Class623 class2 = this.method_14(this.string_1[i * 2], false, true);
                Class623 class3 = this.method_14(this.string_1[(i * 2) + 1], false, false);
                classArray[i] = new Class891(class2, class3);
            }
            this.class43_0.SetAttr(0x151, classArray);
        }
    }

    private void method_21()
    {
        ArrayList list = new ArrayList();
        ArrayList list2 = new ArrayList();
        PathType unknown = PathType.Unknown;
        PathType type2 = PathType.Unknown;
        int num = 0;
        Class679 class2 = new Class679();
        bool flag = true;
        while (num < this.arrayList_1.Count)
        {
            if (smethod_14(this.arrayList_1[num]))
            {
                flag = true;
                char ch = (char) this.arrayList_1[num];
                unknown = Class922.smethod_4(ch);
                if (((unknown == PathType.EllipticalQuadrantX) || (unknown == PathType.EllipticalQuadrantY)) && (unknown == type2))
                {
                    unknown = (unknown == PathType.EllipticalQuadrantX) ? PathType.EllipticalQuadrantY : PathType.EllipticalQuadrantX;
                }
                int num4 = 1;
                switch (unknown)
                {
                    case PathType.Close:
                    case PathType.End:
                    case PathType.MoveTo:
                        num4 = 0;
                        break;
                }
                if (((unknown == PathType.ClockwiseArcTo) || (unknown == PathType.ArcTo)) || (unknown == PathType.Arc))
                {
                    num4 = 4;
                }
                if ((unknown == PathType.AngleEllipse) || (unknown == PathType.AngleEllipseTo))
                {
                    num4 = 3;
                }
                class2 = new Class679(unknown, num4);
                if (class2.method_2() == 0)
                {
                    list2.Add(class2);
                }
                num++;
            }
            else
            {
                if (unknown != PathType.Unknown)
                {
                    if ((!flag && ((unknown == PathType.EllipticalQuadrantX) || (unknown == PathType.EllipticalQuadrantY))) && (unknown == type2))
                    {
                        unknown = (unknown == PathType.EllipticalQuadrantX) ? PathType.EllipticalQuadrantY : PathType.EllipticalQuadrantX;
                        class2 = new Class679(unknown, class2.method_1());
                    }
                    list2.Add(class2);
                    for (int k = 0; k < class2.method_2(); k++)
                    {
                        bool flag2 = ((class2.method_0() == PathType.AngleEllipse) || (class2.method_0() == PathType.AngleEllipseTo)) ? (k == 2) : false;
                        Class623 class3 = this.method_14((string) this.arrayList_1[num++], flag2, true);
                        Class623 class4 = this.method_14((string) this.arrayList_1[num++], flag2, false);
                        if (flag2)
                        {
                            class3 = new Class623(class3.method_1() * 0x10000);
                            class4 = new Class623(class4.method_1() * 0x10000);
                        }
                        Class891 class5 = new Class891(class3, class4);
                        list.Add(class5);
                    }
                }
                flag = false;
            }
            type2 = unknown;
        }
        Class891[] classArray = new Class891[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            classArray[i] = (Class891) list[i];
        }
        Class679[] classArray2 = new Class679[list2.Count];
        for (int j = 0; j < list2.Count; j++)
        {
            classArray2[j] = (Class679) list2[j];
        }
        this.class43_0.SetAttr(0x145, classArray);
        this.class43_0.SetAttr(0x146, classArray2);
    }

    private int method_22(string A_0)
    {
        int num2;
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            double num;
            while (enumerator.MoveNext())
            {
                Class414 current = (Class414) enumerator.Current;
                if (current.string_0 == A_0)
                {
                    num = Class1041.smethod_15(current.string_3);
                    if (!double.IsNaN(num))
                    {
                        goto Label_0047;
                    }
                }
            }
            return 0;
        Label_0047:
            num2 = Class576.smethod_2((int) num);
        }
        return num2;
    }

    internal void method_23(bool A_0)
    {
        this.bool_0 = A_0;
    }

    private void method_3(string A_0)
    {
        int num = 8;
        string str = null;
        foreach (string str2 in A_0.Split(new char[] { ' ' }))
        {
            str = (str == null) ? BookmarkStart.b("挭", num) : string.Format(BookmarkStart.b("唭/伱ᐳ稵", num), str);
            string[] strArray3 = str2.Split(new char[] { ',' });
            if (strArray3.Length == 2)
            {
                str = string.Format(BookmarkStart.b("唭/伱ᐳ䴵ष䜹᰻䔽爿㽁", num), str, strArray3[0], strArray3[1]);
            }
        }
        if (str != null)
        {
            str = this.bool_0 ? string.Format(BookmarkStart.b("栭ု䤱г䬵ᠷ琹", num), str) : string.Format(BookmarkStart.b("唭/伱ᐳ氵ᠷ琹", num), str);
        }
        this.method_17(str);
        this.method_21();
    }

    private void method_4(Class857 A_0)
    {
        this.method_13(A_0);
        this.method_9(A_0);
        this.method_5();
        this.method_21();
        this.method_19();
        this.method_20();
    }

    private void method_5()
    {
        foreach (Class414 class2 in this.arrayList_0)
        {
            this.method_6(class2);
        }
    }

    private void method_6(Class414 A_0)
    {
        int num = 0x10;
        A_0.string_2 = smethod_3(A_0.string_1);
        for (int i = 0; i < A_0.string_2.Length; i++)
        {
            string str2 = A_0.string_2[i];
            if (str2.StartsWith(BookmarkStart.b("व", num)))
            {
                using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
                {
                    Class414 current;
                    while (enumerator.MoveNext())
                    {
                        current = (Class414) enumerator.Current;
                        if (!(current.string_0 != str2.Substring(1)))
                        {
                            goto Label_007B;
                        }
                    }
                    continue;
                Label_007B:
                    if (current.string_3 == null)
                    {
                        this.method_6(current);
                    }
                    A_0.string_2[i] = current.string_3;
                }
            }
        }
        Stack stack = new Stack();
        foreach (string str in A_0.string_2)
        {
            if (smethod_6(str))
            {
                stack.Push(str);
            }
            else if (smethod_8(str) || (smethod_13(str) > 0))
            {
                this.method_7(stack, str);
            }
        }
        A_0.string_3 = Class1041.smethod_44(this.method_8((string) stack.Pop()));
        double d = Class1041.smethod_15(A_0.string_3);
        A_0.string_1 = double.IsNaN(d) ? BookmarkStart.b("ص", num) : Class1041.smethod_30(Class1133.smethod_5(d));
    }

    private void method_7(Stack A_0, string A_1)
    {
        int num = 0x10;
        string key = A_1;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_226 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                dictionary1.Add(BookmarkStart.b("洵ᔷ朹", num), 0);
                dictionary1.Add(BookmarkStart.b("ᴵ", num), 1);
                dictionary1.Add(BookmarkStart.b("ᬵ", num), 2);
                dictionary1.Add(BookmarkStart.b("ᰵ", num), 3);
                dictionary1.Add(BookmarkStart.b("ᤵ", num), 4);
                dictionary1.Add(BookmarkStart.b("䔵儷吹", num), 5);
                dictionary1.Add(BookmarkStart.b("唵圷䤹", num), 6);
                dictionary1.Add(BookmarkStart.b("張帷", num), 7);
                dictionary1.Add(BookmarkStart.b("圵娷䤹", num), 8);
                dictionary1.Add(BookmarkStart.b("䔵䤷䠹䠻", num), 9);
                dictionary1.Add(BookmarkStart.b("嬵儷吹", num), 10);
                dictionary1.Add(BookmarkStart.b("嬵夷䈹", num), 11);
                dictionary1.Add(BookmarkStart.b("圵䰷嬹刻ఽ", num), 12);
                Class1160.dictionary_226 = dictionary1;
            }
            if (Class1160.dictionary_226.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    {
                        string str2 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(-this.method_8(str2)));
                        return;
                    }
                    case 1:
                    {
                        string str3 = (string) A_0.Pop();
                        string str4 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(this.method_8(str4) + this.method_8(str3)));
                        return;
                    }
                    case 2:
                    {
                        string str5 = (string) A_0.Pop();
                        string str6 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(this.method_8(str6) - this.method_8(str5)));
                        return;
                    }
                    case 3:
                    {
                        string str7 = (string) A_0.Pop();
                        string str8 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(this.method_8(str8) * this.method_8(str7)));
                        return;
                    }
                    case 4:
                    {
                        string str9 = (string) A_0.Pop();
                        string str10 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(this.method_8(str10) / this.method_8(str9)));
                        return;
                    }
                    case 5:
                    {
                        string str11 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(Math.Sin(this.method_8(str11))));
                        return;
                    }
                    case 6:
                    {
                        string str12 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(Math.Cos(this.method_8(str12))));
                        return;
                    }
                    case 7:
                    {
                        string str13 = (string) A_0.Pop();
                        string str14 = (string) A_0.Pop();
                        string str15 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(this.method_8((this.method_8(str15) > 0.0) ? str14 : str13)));
                        return;
                    }
                    case 8:
                    {
                        string str16 = (string) A_0.Pop();
                        A_0.Push(Class1041.smethod_44(Math.Abs(this.method_8(str16))));
                        return;
                    }
                    case 9:
                    {
                        double d = this.method_8((string) A_0.Pop());
                        A_0.Push(Class1041.smethod_44(Math.Sqrt(d)));
                        return;
                    }
                    case 10:
                    {
                        double num4 = this.method_8((string) A_0.Pop());
                        double num5 = this.method_8((string) A_0.Pop());
                        A_0.Push(Class1041.smethod_44((num5 < num4) ? num5 : num4));
                        return;
                    }
                    case 11:
                    {
                        double num6 = this.method_8((string) A_0.Pop());
                        double num7 = this.method_8((string) A_0.Pop());
                        A_0.Push(Class1041.smethod_44((num7 > num6) ? num7 : num6));
                        return;
                    }
                    case 12:
                    {
                        double x = this.method_8((string) A_0.Pop());
                        double y = this.method_8((string) A_0.Pop());
                        A_0.Push(Class1041.smethod_44(Math.Atan2(y, x)));
                        break;
                    }
                    default:
                        return;
                }
            }
        }
    }

    private double method_8(string A_0)
    {
        int num = 3;
        if (Class567.smethod_16(A_0))
        {
            double num3;
            if (A_0.ToLower() == BookmarkStart.b("夨䈪", num))
            {
                return 3.1415926535897931;
            }
            if (A_0.ToLower() == BookmarkStart.b("䔨个䬬嬮", num))
            {
                return (double) this.int_0;
            }
            if (A_0.ToLower() == BookmarkStart.b("崨䐪崬", num))
            {
                return (double) this.int_1;
            }
            if (A_0.ToLower() == BookmarkStart.b("嬨䈪䨬䜮䔰", num))
            {
                if (!Class857.bool_9)
                {
                    return (double) Class857.int_2;
                }
                return (Class857.int_2 * Class857.double_2);
            }
            if (A_0.ToLower() == BookmarkStart.b("䬨䐪夬嬮帰帲", num))
            {
                if (!Class857.bool_10)
                {
                    return (double) Class857.int_3;
                }
                return (((double) Class857.int_3) / Class857.double_2);
            }
            if (A_0[0] == '$')
            {
                int index = Class1041.smethod_18(A_0.Substring(1));
                if ((this.string_2 == null) || (index > (this.string_2.Length - 1)))
                {
                    return 0.0;
                }
                num3 = Class1041.smethod_15(this.string_2[index]);
                if (!double.IsNaN(num3))
                {
                    return num3;
                }
            }
            num3 = Class1041.smethod_15(A_0);
            if (!double.IsNaN(num3))
            {
                return num3;
            }
        }
        return 0.0;
    }

    private void method_9(Class857 A_0)
    {
        int num = 11;
        Class396 class2 = A_0.method_11();
        ArrayList list = new ArrayList();
        while (class2.method_9(BookmarkStart.b("吰崲崴嘶圸堺堼嬾汀⑂⁄⡆⑈⹊㥌㵎⡐", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("吰䈲䀴嘶䴸刺刼儾", num)))
                {
                    if (str == BookmarkStart.b("夰刲嬴匶唸帺", num))
                    {
                        list.Add(this.method_10(A_0));
                    }
                }
                else
                {
                    this.arrayList_0.Add(smethod_0(A_0));
                }
            }
        }
        if (list.Count > 0)
        {
            this.class784_0 = (Class784[]) list.ToArray(typeof(Class784));
        }
    }

    private static Class414 smethod_0(Class857 A_0)
    {
        int num = 13;
        Class396 class2 = A_0.method_11();
        Class414 class3 = new Class414();
        while (class2.method_19())
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("崲吴娶尸", num)))
                {
                    if (str == BookmarkStart.b("唲娴䔶吸为儼帾", num))
                    {
                        class3.string_1 = class2.method_3();
                    }
                }
                else
                {
                    class3.string_0 = class2.method_3();
                }
            }
        }
        return class3;
    }

    private static void smethod_1(Class43 A_0, int A_1, int A_2, int A_3, string A_4)
    {
        string[] strArray = A_4.Replace(BookmarkStart.b("Ы", 6), "").Replace(BookmarkStart.b("ԫ", 6), "").Split(new char[] { ' ' });
        if (A_1 != -1)
        {
            smethod_2(A_0, A_1, strArray[0]);
        }
        if ((strArray.Length > 1) && (A_2 != -1))
        {
            smethod_2(A_0, A_2, strArray[1]);
        }
        if ((strArray.Length > 2) && (A_3 != -1))
        {
            smethod_2(A_0, A_3, strArray[2]);
        }
    }

    private static void smethod_10(Stack A_0, StringBuilder A_1, bool A_2)
    {
        int num = 0x10;
        if (A_0.Peek() is char)
        {
            for (char ch = A_2 ? ((char) A_0.Peek()) : ((char) A_0.Pop()); ch != '('; ch = A_2 ? ((char) A_0.Peek()) : ((char) A_0.Pop()))
            {
                if (A_2)
                {
                    A_0.Pop();
                }
                A_1.AppendFormat(BookmarkStart.b("ᘵ䌷ਹ䄻", num), ch);
                if (A_0.Count == 0)
                {
                    throw new InvalidOperationException(BookmarkStart.b("礵䠷弹刻稽⼿⅁ㅃ⭅ⵇ⑉㡋湍㙏㵑♓㭕ⵗ㙙㵛繝य़ᅡ䑣ᅥᩧթɫ७", num));
                }
            }
            if (A_2)
            {
                A_1.Append(' ');
            }
        }
    }

    private static int smethod_11(char A_0)
    {
        if ((A_0 == '+') || (A_0 == '-'))
        {
            return 1;
        }
        if ((A_0 != '*') && (A_0 != '/'))
        {
            return 0;
        }
        return 2;
    }

    private static int smethod_12(string A_0)
    {
        int num = 1;
        if (A_0.ToLower().StartsWith(BookmarkStart.b("圦䀨", 1)))
        {
            return 2;
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("匦䘨嬪", num)))
        {
            return 3;
        }
        if (A_0.StartsWith(BookmarkStart.b("䬦䰨䴪夬", num)))
        {
            return 4;
        }
        if (A_0.StartsWith(BookmarkStart.b("唦䀨䰪䔬嬮", num)) || A_0.StartsWith(BookmarkStart.b("倦䀨伪夬䜮", num)))
        {
            return 5;
        }
        if (A_0.StartsWith(BookmarkStart.b("䔦䘨弪夬䀮尰", num)) || A_0.StartsWith(BookmarkStart.b("伦䰨䈪䨬䜮䔰", num)))
        {
            return 6;
        }
        if (A_0.StartsWith(BookmarkStart.b("伦䠨堪䬬䘮崰弲", num)))
        {
            return 7;
        }
        if ((A_0.StartsWith(BookmarkStart.b("弦娨弪弬䨮䔰倲崴", num)) || A_0.StartsWith(BookmarkStart.b("带娨弪弬䨮䔰倲崴", num))) || A_0.StartsWith(BookmarkStart.b("䬦䘨䰪娬䘮唰䜲崴", num)))
        {
            return 8;
        }
        if (!A_0.StartsWith(BookmarkStart.b("伦䠨堪帬嬮䌰尲帴制", num)) && !A_0.StartsWith(BookmarkStart.b("䬦䘨䰪䔬䨮堰吲崴䌶", num)))
        {
            return 0;
        }
        return 9;
    }

    private static int smethod_13(string A_0)
    {
        int num = 5;
        if (A_0.ToLower().StartsWith(BookmarkStart.b("瀪,爮", 5)))
        {
            return 3;
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("瀪ج爮", num)))
        {
            return 3;
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("䈪䬬", num)))
        {
            return 2;
        }
        if (((A_0.StartsWith(BookmarkStart.b("䨪伬尮", num)) || A_0.StartsWith(BookmarkStart.b("堪䐬䄮", num))) || (A_0.StartsWith(BookmarkStart.b("䠪䈬尮", num)) || A_0.StartsWith(BookmarkStart.b("弪䰬䄮", num)))) || (A_0.StartsWith(BookmarkStart.b("䘪䐬䄮", num)) || A_0.StartsWith(BookmarkStart.b("䘪䰬圮", num))))
        {
            return 3;
        }
        if (A_0.StartsWith(BookmarkStart.b("䨪夬丮弰Ĳ", num)))
        {
            return 5;
        }
        if (!A_0.StartsWith(BookmarkStart.b("堪尬崮䔰", num)) && !A_0.StartsWith(BookmarkStart.b("䨪夬丮弰", num)))
        {
            return 0;
        }
        return 4;
    }

    private static bool smethod_14(object A_0)
    {
        int num = 3;
        return ((A_0 is char) && (BookmarkStart.b("栨椪測椮細縲笴昶樸漺格椾ᙀᭂ᱄ᵆ", num).IndexOf((char) A_0) != -1));
    }

    private static void smethod_2(Class43 A_0, int A_1, string A_2)
    {
        if (Class567.smethod_16(A_2))
        {
            A_0.SetAttr(A_1, Class576.smethod_7(A_2));
        }
    }

    private static string[] smethod_3(string A_0)
    {
        int num = 0x13;
        StringBuilder builder = new StringBuilder();
        bool flag = true;
        for (int i = 0; i < A_0.Length; i++)
        {
            char ch2 = A_0[i];
            if (((ch2 == '+') || (ch2 == '-')) && flag)
            {
                builder.Append(string.Format(BookmarkStart.b("戸䀺഼䈾᱀捂", num), ch2));
                flag = false;
            }
            else
            {
                builder.Append(ch2);
            }
            flag = ((ch2 == '(') || smethod_7(ch2)) || ((ch2 == ' ') && flag);
        }
        A_0 = builder.ToString();
        Stack stack = new Stack();
        StringBuilder builder2 = new StringBuilder();
        bool flag3 = false;
        bool flag2 = false;
        bool flag4 = true;
        int startIndex = 0;
        while (startIndex < A_0.Length)
        {
            char c = A_0[startIndex];
            int length = smethod_13(A_0.Substring(startIndex));
            int num5 = smethod_12(A_0.Substring(startIndex));
            if ((((c == ' ') || (c == '?')) || ((c == ',') || (c == ')'))) || (char.IsLetter(c) || smethod_7(c)))
            {
                if (((stack.Count > 0) && (stack.Peek() is string)) && ((((string) stack.Peek()) == BookmarkStart.b("戸ᘺ怼", num)) && flag2))
                {
                    builder2.AppendFormat(BookmarkStart.b("ᤸ䀺഼䈾", num), stack.Pop());
                }
                flag2 = false;
            }
            if (((char.IsDigit(c) || (c == '.')) && !flag3) || (char.IsLetterOrDigit(c) && flag3))
            {
                builder2.Append(c);
                flag2 = true;
            }
            if (!flag3)
            {
                if (num5 != 0)
                {
                    builder2.Append(A_0.Substring(startIndex, num5));
                }
                if (length != 0)
                {
                    string str = A_0.Substring(startIndex, length);
                    stack.Push(str);
                    startIndex += length - 1;
                }
            }
            switch (c)
            {
                case ' ':
                    flag3 = false;
                    break;

                case '(':
                    stack.Push(c);
                    goto Label_0285;

                case ',':
                case ')':
                    smethod_10(stack, builder2, c == ',');
                    if (((c == ')') && (stack.Count > 0)) && (smethod_13(stack.Peek().ToString()) > 0))
                    {
                        builder2.AppendFormat(BookmarkStart.b("ᤸ䀺഼䈾", num), stack.Pop());
                    }
                    flag3 = false;
                    goto Label_0285;

                case '$':
                    builder2.Append(c);
                    flag3 = false;
                    goto Label_0285;

                case '?':
                    builder2.Append(c);
                    flag3 = true;
                    goto Label_0285;
            }
            if (smethod_7(c))
            {
                smethod_4(c, builder2, stack, startIndex == 0, flag4);
                flag3 = false;
            }
        Label_0285:
            startIndex++;
            flag4 = (((c == '(') || smethod_7(c)) || (length != 0)) || ((c == ' ') && flag4);
        }
        smethod_5(builder2, stack);
        return builder2.ToString().Split(new char[] { ' ' });
    }

    private static void smethod_4(char A_0, StringBuilder A_1, Stack A_2, bool A_3, bool A_4)
    {
        int num = 6;
        if (((A_0 == '+') || (A_0 == '-')) && (A_3 || A_4))
        {
            A_1.Append(BookmarkStart.b("ᰫ", num));
        }
        A_1.Append(' ');
        while (A_2.Count != 0)
        {
            if (!(A_2.Peek() is char))
            {
                break;
            }
            char ch = (char) A_2.Peek();
            if (!smethod_7(ch) || (smethod_11(A_0) > smethod_11(ch)))
            {
                break;
            }
            A_1.AppendFormat(BookmarkStart.b("圫ḭ䴯ሱ", num), A_2.Pop());
        }
        A_2.Push(A_0);
    }

    private static void smethod_5(StringBuilder A_0, Stack A_1)
    {
        int num = 0x13;
        while (A_1.Count != 0)
        {
            if (!smethod_9(A_1.Peek()))
            {
                StringBuilder builder = new StringBuilder();
                while (A_1.Count != 0)
                {
                    if (smethod_9(A_1.Peek()))
                    {
                        break;
                    }
                    if ((A_1.Peek() is string) && (smethod_13(A_1.Peek() as string) != 0))
                    {
                        builder.Append(A_1.Pop());
                    }
                    else
                    {
                        A_1.Pop();
                    }
                }
                if (smethod_13(builder.ToString()) == 0)
                {
                    throw new InvalidOperationException(BookmarkStart.b("瘸䬺堼儾Հⱂ♄㉆⑈⹊⍌㭎煐㕒㩔╖㑘⹚ㅜ㹞䅠੢ᙤ䝦ṨᥪɬŮᙰ", num));
                }
                A_0.AppendFormat(BookmarkStart.b("ᤸ䀺഼䈾", num), builder);
                continue;
            }
            A_0.AppendFormat(BookmarkStart.b("ᤸ䀺഼䈾", num), A_1.Pop());
        }
    }

    private static bool smethod_6(string A_0)
    {
        return ((smethod_13(A_0) == 0) && !smethod_8(A_0));
    }

    private static bool smethod_7(char A_0)
    {
        if (((A_0 != '+') && (A_0 != '-')) && (A_0 != '*'))
        {
            return (A_0 == '/');
        }
        return true;
    }

    private static bool smethod_8(string A_0)
    {
        return ((A_0.Length == 1) && smethod_7(A_0[0]));
    }

    private static bool smethod_9(object A_0)
    {
        if (A_0 is char)
        {
            char ch = (char) A_0;
            return smethod_7(ch);
        }
        if (A_0 is string)
        {
            string str = (string) A_0;
            return smethod_8(str);
        }
        return false;
    }
}

