using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Caculation;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class338
{
    private bool bool_0;
    private readonly Class396 class396_0;
    private readonly Class857 class857_0;
    private string string_0;

    internal Class338(Class857 A_0)
    {
        this.class857_0 = A_0;
        this.string_0 = this.method_20();
        string str = string.Format(BookmarkStart.b("थ匧ᨩ儫ĭ䬯̱䤳", 0), this.string_0, BookmarkStart.b("䔥䜧䐩堫䬭帯䘱ᨳ丵唷嘹", 0));
        Class113 class2 = A_0.method_10().method_2(str);
        if (class2 == null)
        {
            this.class857_0.method_11().method_18();
        }
        else
        {
            this.class396_0 = new Class396(class2.method_3());
        }
    }

    internal void method_0(Class857 A_0, DocumentObject A_1, ShapeObject A_2)
    {
        int num = 2;
        if (this.class396_0 == null)
        {
            A_2.SetShapeType(ShapeType.OleObject);
            Class798.smethod_0(A_0, A_1, A_2);
        }
        else
        {
            string str = (string) A_0.method_63()[string.Format(BookmarkStart.b("匧ᨩ儫ĭ", num), this.string_0)];
            if (str != BookmarkStart.b("䤧娩尫䈭夯儱唳䈵儷唹刻ᄽ㘿ⱁ⁃桅❇⭉㽋❍⍏籑㭓♕㵗㑙㡛ㅝ͟ᝡॣͥ٧ṩ䉫࡭Ὧqᥳ͵ᑷ᭹", num))
            {
                Class922.smethod_0(str);
                A_2.SetShapeType(ShapeType.OleObject);
                Class476 class2 = new Class476();
                this.method_2(class2, str, this.method_1(A_0, class2, BookmarkStart.b("䬧䔩䈫娭唯就䀳ᠵ䀷圹倻", num)), this.method_1(A_0, class2, BookmarkStart.b("嬧帩唫䈭唯䄱ᨳ丵唷嘹", num)), this.method_1(A_0, class2, BookmarkStart.b("嬧伩堫娭夯就匳䔵ᘷ䈹儻刽", num)));
                MemoryStream stream = new MemoryStream();
                class2.method_3(stream, str);
            }
        }
    }

    internal bool method_1(Class857 A_0, Class476 A_1, string A_2)
    {
        Class113 class2 = A_0.method_10().method_1().method_2(string.Format(BookmarkStart.b("ܧ儩ᰫ匭Ἧ䤱Գ䬵", 2), this.method_21(), A_2));
        if (class2 != null)
        {
            A_1.method_1().method_1(new Class113(A_2, class2.method_3()));
            return true;
        }
        return false;
    }

    private Class5 method_10(Class5 A_0, int A_1)
    {
        MathObjectType argument = MathObjectType.Argument;
        MathObjectType type2 = A_0.method_32().vmethod_1();
        if (type2 != MathObjectType.Delimiter)
        {
            switch (type2)
            {
                case MathObjectType.LowerLimit:
                    if (A_1 == 1)
                    {
                        argument = MathObjectType.Limit;
                    }
                    break;

                case MathObjectType.UpperLimit:
                    if (A_1 == 1)
                    {
                        argument = MathObjectType.Limit;
                    }
                    break;

                case MathObjectType.Matrix:
                    return new Class5(this.class857_0.method_9(), new Class29());

                case MathObjectType.Radical:
                    if (A_1 == 1)
                    {
                        argument = MathObjectType.Degree;
                    }
                    break;

                case MathObjectType.PreSubSuperscript:
                case MathObjectType.SubSuperscript:
                    if (A_1 == 1)
                    {
                        argument = MathObjectType.SubscriptPart;
                    }
                    if (A_1 == 2)
                    {
                        argument = MathObjectType.SuperscriptPart;
                    }
                    break;

                case MathObjectType.Subscript:
                    if (A_1 == 1)
                    {
                        argument = MathObjectType.SubscriptPart;
                    }
                    break;

                case MathObjectType.Supercript:
                    if (A_1 == 1)
                    {
                        argument = MathObjectType.SuperscriptPart;
                    }
                    break;

                case MathObjectType.Fraction:
                    argument = (A_1 == 0) ? MathObjectType.Numerator : MathObjectType.Denominator;
                    break;
            }
        }
        return new Class5(this.class857_0.method_9(), new Class34(argument));
    }

    private Class5 method_11(Class5 A_0, string A_1, int A_2, MathLimitLocation A_3)
    {
        int num = 1;
        MathObjectType argument = MathObjectType.Argument;
        switch (A_0.method_32().vmethod_1())
        {
            case MathObjectType.Fraction:
                argument = (A_2 == 0) ? MathObjectType.Numerator : MathObjectType.Denominator;
                break;

            case MathObjectType.Function:
                if (A_2 == 0)
                {
                    argument = MathObjectType.FunctionName;
                }
                break;

            case MathObjectType.GroupCharacter:
                if ((A_2 == 0) && (A_1 == BookmarkStart.b("䨦尨䔪䤬䨮䌰", num)))
                {
                    A_0.method_32().Remove(0x3bba);
                    A_0.method_32().Remove(0x3bc4);
                }
                if (A_2 == 1)
                {
                    if (A_1 == BookmarkStart.b("䨦尨䔪䤬䨮䌰", num))
                    {
                        A_0.method_32().Remove(0x3bc4);
                    }
                    if (A_1 == BookmarkStart.b("䨦䘨崪䠬崮", num))
                    {
                        A_0.method_32().Remove(0x3bba);
                    }
                }
                break;

            case MathObjectType.LowerLimit:
                if (A_2 == 1)
                {
                    argument = MathObjectType.Limit;
                }
                break;

            case MathObjectType.UpperLimit:
                if (A_2 == 1)
                {
                    argument = MathObjectType.Limit;
                }
                break;

            case MathObjectType.Delimiter:
                break;

            case MathObjectType.Radical:
                if (A_2 == 1)
                {
                    argument = MathObjectType.Degree;
                }
                break;

            case MathObjectType.PreSubSuperscript:
            case MathObjectType.SubSuperscript:
                if (A_2 == 1)
                {
                    argument = MathObjectType.SubscriptPart;
                }
                if (A_2 == 2)
                {
                    argument = MathObjectType.SuperscriptPart;
                }
                break;

            case MathObjectType.Subscript:
                if (A_2 == 1)
                {
                    argument = MathObjectType.SubscriptPart;
                }
                break;

            case MathObjectType.Supercript:
                if (A_2 == 1)
                {
                    argument = MathObjectType.SuperscriptPart;
                }
                break;

            default:
                if (!this.method_14(A_0, A_3))
                {
                    this.method_4(A_0, BookmarkStart.b("䨦嬨䐪娬", num));
                    this.method_12(A_0);
                }
                return null;
        }
        return new Class5(this.class857_0.method_9(), new Class34(argument));
    }

    private void method_12(Class5 A_0)
    {
        int num = smethod_5(A_0);
        if (num >= 0)
        {
            Class5 class2 = this.method_13(A_0, num);
            smethod_4(A_0, num);
            A_0.method_13(class2);
        }
    }

    private Class5 method_13(Class5 A_0, int A_1)
    {
        Class5 class2 = new Class5(this.class857_0.method_9(), new Class23());
        Class5 class3 = new Class5(this.class857_0.method_9(), new Class34(MathObjectType.FunctionName));
        Class5 class4 = new Class5(this.class857_0.method_9(), new Class34(MathObjectType.Argument));
        class2.method_13(class3);
        class2.method_13(class4);
        bool flag = false;
        for (int i = A_1 - 1; i < A_0.ChildObjects.Count; i++)
        {
            DocumentObject obj2 = A_0.ChildObjects[i];
            string text = ((TextRange) obj2).Text;
            if ((text.Length == 1) && (text[0] == '⁡'))
            {
                flag = true;
            }
            else if (!flag)
            {
                class3.method_13(obj2.Clone());
            }
            else
            {
                class4.method_13(obj2.Clone());
            }
        }
        return class2;
    }

    private bool method_14(Class5 A_0, MathLimitLocation A_1)
    {
        int num = 9;
        if ((A_0.LastChild == null) || !(A_0.LastChild is Class5))
        {
            return false;
        }
        Class5 lastChild = A_0.LastChild as Class5;
        bool flag = (lastChild.method_32().vmethod_1() == MathObjectType.SubSuperscript) && (lastChild.ChildObjects.Count == 3);
        bool flag2 = (((lastChild.method_32().vmethod_1() == MathObjectType.LowerLimit) || (lastChild.method_32().vmethod_1() == MathObjectType.UpperLimit)) || (lastChild.method_32().vmethod_1() == MathObjectType.Subscript)) ? (lastChild.ChildObjects.Count == 2) : false;
        if (!flag && !flag2)
        {
            return false;
        }
        Class5 class3 = new Class5(this.class857_0.method_9(), new Class41());
        A_0.method_13(class3);
        string text = ((TextRange) lastChild.ChildObjects[0]).Text;
        if (Class567.smethod_16(text))
        {
            class3.method_32().SetAttr(0x3ac5, text[0]);
        }
        class3.method_32().SetAttr(0x3c96, A_1);
        if (flag)
        {
            class3.method_13(lastChild.ChildObjects[1].Clone());
            class3.method_13(lastChild.ChildObjects[2].Clone());
        }
        else
        {
            class3.method_32().SetAttr(0x3caa, true);
            Class5 class4 = new Class5(this.class857_0.method_9(), new Class34(MathObjectType.SubscriptPart));
            foreach (DocumentObject obj2 in lastChild.ChildObjects[1].ChildObjects)
            {
                class4.method_13(obj2.Clone());
            }
            class3.method_13(class4);
        }
        lastChild.method_19();
        Class5 class5 = new Class5(this.class857_0.method_9(), new Class34(MathObjectType.Argument));
        this.method_4(class5, BookmarkStart.b("䈮䌰尲䈴", num));
        class3.method_13(class5);
        return true;
    }

    private Class18 method_15(string A_0)
    {
        int num = 3;
        while (this.class396_0.method_19())
        {
            if ((this.class396_0.method_1() == BookmarkStart.b("䠨䠪丬䨮弰䜲䀴夶崸帺似", num)) || (this.class396_0.method_1() == BookmarkStart.b("䠨䠪丬䨮弰䜲", num)))
            {
                if (this.class396_0.method_3() == BookmarkStart.b("伨䨪䄬尮吰", num))
                {
                    Class18 class2 = new Class21();
                    class2.SetAttr(0x3bba, MathPosition.Top);
                    class2.SetAttr(0x3bc4, MathVerticalJustification.Bottom);
                    return class2;
                }
                if (A_0 == BookmarkStart.b("䐨䐪嬬䨮䌰", num))
                {
                    return new Class35();
                }
            }
        }
        if (A_0 == BookmarkStart.b("䐨帪䌬䬮吰䄲", num))
        {
            return new Class28();
        }
        return new Class22();
    }

    private void method_16(Class5 A_0)
    {
        int num = 2;
        while (this.class396_0.method_19())
        {
            string str = this.class396_0.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䐧䌩䈫䬭䐯娱崳唵匷吹夻䴽㌿", num)))
                {
                    if ((str == BookmarkStart.b("䨧伩娫䬭尯帱儳刵", num)) && (this.class396_0.method_3() == BookmarkStart.b("尧堩夫䬭", num)))
                    {
                        A_0.method_32().SetAttr(0x3c64, MathFractionType.Skewed);
                    }
                }
                else if (Class576.smethod_40(this.class396_0.method_3()) == 0.0)
                {
                    A_0.method_32().SetAttr(0x3c64, MathFractionType.NoBar);
                }
            }
        }
    }

    private void method_17(Class5 A_0)
    {
        int num = 9;
        while (this.class396_0.method_19())
        {
            bool flag = (this.class396_0.method_3().Length == 3) && (this.class396_0.method_3()[0] == '0');
            string str = this.class396_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("堮堰圲䄴弶", num))
                {
                    if (!(str == BookmarkStart.b("䜮吰娲刴弶䴸", num)))
                    {
                        if (str == BookmarkStart.b("䬮吰䌲䄴弶", num))
                        {
                            A_0.method_32().SetAttr(0x3bec, flag);
                        }
                    }
                    else
                    {
                        A_0.method_32().SetAttr(0x3be2, flag);
                    }
                }
                else
                {
                    A_0.method_32().SetAttr(0x3c5a, flag);
                }
            }
        }
    }

    private void method_18(Class5 A_0)
    {
        int num = 13;
        while (this.class396_0.method_19())
        {
            string str = this.class396_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("尲䔴制圸", num))
                {
                    if (!(str == BookmarkStart.b("倲头堶䨸帺", num)))
                    {
                        if (str == BookmarkStart.b("䀲倴䜶堸䤺尼䬾⹀ㅂ㙄", num))
                        {
                            this.method_19(A_0, 0x3b60);
                        }
                    }
                    else
                    {
                        this.method_19(A_0, 0x3b56);
                    }
                }
                else
                {
                    this.method_19(A_0, 0x3b4c);
                }
            }
        }
    }

    private void method_19(Class5 A_0, int A_1)
    {
        if (this.class396_0.method_3().Length == 1)
        {
            A_0.method_32().SetAttr(A_1, this.class396_0.method_3()[0]);
        }
        if (this.class396_0.method_3() == "")
        {
            A_0.method_32().SetAttr(A_1, '\0');
        }
    }

    internal void method_2(Class476 A_0, string A_1, bool A_2, bool A_3, bool A_4)
    {
        int num = 13;
        Class113 class2 = new Class113(BookmarkStart.b("ᰲ破父洸稺ြ瘾ཀՂ橄⩆⡈╊⑌⥎㑐⁒⅔祖⅘㙚ㅜ", 13));
        Class400 class3 = new Class400(class2, true);
        class3.method_62();
        class3.method_33(BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄⹆╈⹊恌⩎㽐❒❔⹖", 13), new object[] { BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⡄≆ⵈ≊ⱌ扎═⩒╔㉖", 13), A_1, BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄㉆╈❊恌㽎ぐ❒㵔", 13), BookmarkStart.b("ᰲ", 13) });
        if (A_2)
        {
            class3.method_33(BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄⹆╈⹊恌⩎㽐❒❔⹖", num), new object[] { BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⡄≆ⵈ≊ⱌ扎═⩒╔㉖", num), BookmarkStart.b("䜲倴伶䴸ᐺ䔼刾ⵀ", num), BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄㉆╈❊恌㽎ぐ❒㵔", num), BookmarkStart.b("倲娴夶䴸帺匼䬾潀㭂⡄⭆", num) });
        }
        if (A_3)
        {
            class3.method_33(BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄⹆╈⹊恌⩎㽐❒❔⹖", num), new object[] { BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⡄≆ⵈ≊ⱌ扎═⩒╔㉖", num), BookmarkStart.b("䜲倴伶䴸ᐺ䔼刾ⵀ", num), BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄㉆╈❊恌㽎ぐ❒㵔", num), BookmarkStart.b("䀲䄴丶唸帺丼ᄾ㥀⹂⥄", num) });
        }
        if (A_4)
        {
            class3.method_33(BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄⹆╈⹊恌⩎㽐❒❔⹖", num), new object[] { BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⡄≆ⵈ≊ⱌ扎═⩒╔㉖", num), BookmarkStart.b("䜲倴伶䴸ᐺ䔼刾ⵀ", num), BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄㉆╈❊恌㽎ぐ❒㵔", num), BookmarkStart.b("䀲倴䌶䴸刺匼堾㉀浂㵄⩆╈", num) });
        }
        class3.method_33(BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄⹆╈⹊恌⩎㽐❒❔⹖", num), new object[] { BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⡄≆ⵈ≊ⱌ扎═⩒╔㉖", num), BookmarkStart.b("䜲倴伶䴸ᐺ䴼匾⁀⩂⭄", num), BookmarkStart.b("帲吴夶倸崺堼䰾㕀祂⍄㉆╈❊恌㽎ぐ❒㵔", num), BookmarkStart.b("帲尴娶尸伺䐼伾⑀", num) });
        class3.method_3();
        A_0.method_1().method_1(class2);
    }

    private string method_20()
    {
        int num = 9;
        Class396 class2 = this.class857_0.method_11();
        while (class2.method_19())
        {
            if (class2.method_1() == BookmarkStart.b("䜮䌰嘲匴", num))
            {
                return class2.method_3().Replace(BookmarkStart.b("ĮḰ", num), "").Trim(new char[] { '/' });
            }
        }
        return null;
    }

    internal string method_21()
    {
        return this.string_0;
    }

    internal void method_3(DocumentObject A_0)
    {
        if (this.class396_0 != null)
        {
            Class5 class2 = new Class5(this.class857_0.method_9(), new Class32());
            this.bool_0 = false;
            this.method_4(class2, this.class396_0.method_1());
            if (this.bool_0)
            {
                Class5 class3 = new Class5(this.class857_0.method_9(), new Class20());
                class3.method_13(class2);
                A_0.method_13(class3);
            }
        }
    }

    private void method_4(Class5 A_0, string A_1)
    {
        int num = 6;
        int num2 = 0;
        MathLimitLocation undefined = MathLimitLocation.Undefined;
        while (this.class396_0.method_9(A_1))
        {
            Class5 class2;
            if (A_1 == BookmarkStart.b("䄫伭䐯娱", num))
            {
                this.bool_0 = true;
            }
            string str2 = this.class396_0.method_1();
            string key = str2;
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_13 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x15);
                    dictionary1.Add(BookmarkStart.b("弫䬭崯匱娳䈵儷夹伻", num), 0);
                    dictionary1.Add(BookmarkStart.b("䄫䠭唯就圳匵尷", num), 1);
                    dictionary1.Add(BookmarkStart.b("䄫䠭䈯匱圳", num), 2);
                    dictionary1.Add(BookmarkStart.b("䄫崭䔯䈱", num), 3);
                    dictionary1.Add(BookmarkStart.b("䄫崭䔯倱", num), 4);
                    dictionary1.Add(BookmarkStart.b("䄫崭䔯倱䜳䌵䠷", num), 5);
                    dictionary1.Add(BookmarkStart.b("䄫嬭帯嘱儳䐵圷䰹夻䰽", num), 6);
                    dictionary1.Add(BookmarkStart.b("䄫䌭䔯帱䀳張䬷夹主圽〿㙁㝃", num), 7);
                    dictionary1.Add(BookmarkStart.b("䄫尭弯崱䀳", num), 8);
                    dictionary1.Add(BookmarkStart.b("䄫崭䄯䀱䀳", num), 9);
                    dictionary1.Add(BookmarkStart.b("䄫娭儯倱堳匵", num), 10);
                    dictionary1.Add(BookmarkStart.b("䄫娭䈯", num), 11);
                    dictionary1.Add(BookmarkStart.b("䄫娭启", num), 12);
                    dictionary1.Add(BookmarkStart.b("䄫䬭帯儱堳夵䬷弹", num), 13);
                    dictionary1.Add(BookmarkStart.b("䄫嬭帯嘱儳䐵", num), 14);
                    dictionary1.Add(BookmarkStart.b("䄫䄭䘯圱䘳", num), 15);
                    dictionary1.Add(BookmarkStart.b("䄫席儯嘱倳匵尷", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䄫尭弯䔱", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("䄫䜭", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("䄫䄭", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䄫䀭", num), 20);
                    Class1160.dictionary_13 = dictionary1;
                }
                if (Class1160.dictionary_13.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                            this.method_4(A_0, A_1);
                            return;

                        case 1:
                            class2 = new Class5(this.class857_0.method_9(), new Class30());
                            this.method_18(class2);
                            goto Label_03E7;

                        case 2:
                            class2 = new Class5(this.class857_0.method_9(), new Class38());
                            this.method_16(class2);
                            goto Label_03E7;

                        case 3:
                            class2 = new Class5(this.class857_0.method_9(), new Class27());
                            goto Label_03E7;

                        case 4:
                            undefined = MathLimitLocation.SubscriptSuperscript;
                            class2 = new Class5(this.class857_0.method_9(), new Class31());
                            goto Label_03E7;

                        case 5:
                        case 6:
                            undefined = (str2 == BookmarkStart.b("䄫崭䔯倱䜳䌵䠷", num)) ? MathLimitLocation.SubscriptSuperscript : MathLimitLocation.UnderOver;
                            class2 = new Class5(this.class857_0.method_9(), new Class39());
                            goto Label_03E7;

                        case 7:
                            class2 = new Class5(this.class857_0.method_9(), new Class26());
                            goto Label_03E7;

                        case 8:
                            class2 = new Class5(this.class857_0.method_9(), new Class40());
                            goto Label_03E7;

                        case 9:
                            class2 = this.method_7();
                            goto Label_03E7;

                        case 10:
                            class2 = this.method_6();
                            goto Label_03E7;

                        case 11:
                            class2 = new Class5(this.class857_0.method_9(), new Class29());
                            goto Label_03E7;

                        case 12:
                            class2 = new Class5(this.class857_0.method_9(), new Class34(MathObjectType.Argument));
                            goto Label_03E7;

                        case 13:
                            class2 = new Class5(this.class857_0.method_9(), new Class25());
                            goto Label_03E7;

                        case 14:
                        case 15:
                            class2 = new Class5(this.class857_0.method_9(), this.method_15(str2));
                            goto Label_03E7;

                        case 0x10:
                            class2 = new Class5(this.class857_0.method_9(), new Class36());
                            this.method_17(class2);
                            goto Label_03E7;

                        case 0x11:
                            class2 = this.method_11(A_0, A_1, num2++, undefined);
                            undefined = MathLimitLocation.Undefined;
                            goto Label_03E7;

                        case 0x12:
                        case 0x13:
                        case 20:
                        {
                            num2 = this.method_8(A_0, A_1, num2);
                            continue;
                        }
                    }
                }
            }
            goto Label_040E;
        Label_03E7:
            if (class2 != null)
            {
                this.method_4(class2, str2);
                num2 = this.method_5(A_0, A_1, class2, str2, num2);
            }
            continue;
        Label_040E:
            this.class396_0.vmethod_1();
        }
    }

    private int method_5(Class5 A_0, string A_1, DocumentObject A_2, string A_3, int A_4)
    {
        int num = 15;
        Class5 lastChild = A_0.LastChild as Class5;
        if (((((A_3 != BookmarkStart.b("場䔶嘸䰺", 15)) && (A_3 != BookmarkStart.b("場䌶䬸", num))) && (A_3 != BookmarkStart.b("場䌶崸", num))) && !(A_0.method_32() is Class34)) && (A_0.method_32().vmethod_2() || smethod_1(A_2, lastChild)))
        {
            Class5 class3;
            if (smethod_2(A_0.method_32().vmethod_1(), lastChild) && (A_4 >= smethod_3(A_1)))
            {
                class3 = (Class5) A_0.LastChild;
            }
            else
            {
                class3 = this.method_10(A_0, A_4++);
                A_0.method_13(class3);
            }
            class3.method_13(A_2);
            return A_4;
        }
        string text = ((TextRange) A_2).Text;
        if (smethod_0(A_0, A_1, text))
        {
            A_0.method_32().SetAttr(0x3bb0, text[0]);
            return ++A_4;
        }
        A_0.method_13(A_2);
        return A_4;
    }

    private Class5 method_6()
    {
        Class19 class2 = new Class19();
        class2.method_55(true);
        return new Class5(this.class857_0.method_9(), class2);
    }

    private Class5 method_7()
    {
        Class5 class2 = new Class5(this.class857_0.method_9(), new Class40());
        Class5 class3 = new Class5(this.class857_0.method_9(), new Class34(MathObjectType.Degree));
        class2.method_32().SetAttr(0x3cb4, true);
        class2.method_13(class3);
        return class2;
    }

    private int method_8(Class5 A_0, string A_1, int A_2)
    {
        int num = 12;
        string str = this.class396_0.method_21();
        if ((str.Length == 1) && ((A_1 == BookmarkStart.b("弱嬳䀵崷䠹", num)) || (A_1 == BookmarkStart.b("弱䄳堵尷弹主", num))))
        {
            if (A_0.method_32().vmethod_1() == MathObjectType.Accent)
            {
                A_0.method_32().SetAttr(0x3ac0, str[0]);
                return ++A_2;
            }
            if (A_0.method_32().vmethod_1() == MathObjectType.GroupCharacter)
            {
                A_0.method_32().SetAttr(0x3bb0, str[0]);
                return ++A_2;
            }
        }
        A_2 = this.method_5(A_0, A_1, this.method_9(str), this.class396_0.method_1(), A_2);
        return A_2;
    }

    private TextRange method_9(string A_0)
    {
        return new TextRange(this.class857_0.method_9(), A_0, new CharacterFormat(this.class857_0.method_9()) { FontName = BookmarkStart.b("眳圵唷堹主圽ℿ扁ृ❅㱇≉", 14) });
    }

    private static bool smethod_0(Class5 A_0, string A_1, string A_2)
    {
        int num = 9;
        return ((((A_1 == BookmarkStart.b("䈮䐰崲儴制䬸", 9)) || (A_1 == BookmarkStart.b("䈮帰䔲倴䔶", num))) && ((A_0.method_32().vmethod_1() == MathObjectType.GroupCharacter) && (A_2.Length == 1))) && (A_0.ChildObjects.Count == 1));
    }

    private static bool smethod_1(DocumentObject A_0, Class5 A_1)
    {
        Class5 class2 = A_0 as Class5;
        if (((A_1 == null) || (A_1.ChildObjects.Count != 1)) || (A_1.method_32().vmethod_1() != MathObjectType.Function))
        {
            return false;
        }
        return ((A_0 is TextRange) || ((class2 != null) && (class2.method_32().vmethod_1() == MathObjectType.Argument)));
    }

    private static bool smethod_2(MathObjectType A_0, Class5 A_1)
    {
        if (A_1 == null)
        {
            return false;
        }
        return (((((A_0 == MathObjectType.Phantom) || (A_0 == MathObjectType.BorderBox)) || ((A_0 == MathObjectType.Subscript) || (A_0 == MathObjectType.Supercript))) || (A_0 == MathObjectType.SubSuperscript)) || (((A_0 == MathObjectType.Radical) && (A_1.method_32() is Class34)) && (A_1.method_32().vmethod_1() != MathObjectType.Degree)));
    }

    private static int smethod_3(string A_0)
    {
        int num = 4;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_14 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                dictionary1.Add(BookmarkStart.b("䜩䨫䬭帯儱儳刵", num), 0);
                dictionary1.Add(BookmarkStart.b("䜩䨫尭儯儱", num), 1);
                dictionary1.Add(BookmarkStart.b("䜩弫嬭䀯", num), 2);
                dictionary1.Add(BookmarkStart.b("䜩弫嬭刯", num), 3);
                dictionary1.Add(BookmarkStart.b("䜩弫嬭刯䄱䄳䘵", num), 4);
                dictionary1.Add(BookmarkStart.b("䜩䄫嬭尯䘱崳䔵嬷䠹唻丽㐿ㅁ", num), 5);
                dictionary1.Add(BookmarkStart.b("䜩師䄭弯䘱", num), 6);
                dictionary1.Add(BookmarkStart.b("䜩尫伭启嘱儳刵", num), 7);
                dictionary1.Add(BookmarkStart.b("䜩弫弭䈯䘱", num), 8);
                dictionary1.Add(BookmarkStart.b("䜩師䄭䜯", num), 9);
                dictionary1.Add(BookmarkStart.b("䜩䔫", num), 10);
                dictionary1.Add(BookmarkStart.b("䜩䌫", num), 11);
                dictionary1.Add(BookmarkStart.b("䜩䈫", num), 12);
                Class1160.dictionary_14 = dictionary1;
            }
            if (Class1160.dictionary_14.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        return 2;

                    case 7:
                    case 8:
                        return 1;
                }
            }
        }
        return 0;
    }

    private static void smethod_4(Class5 A_0, int A_1)
    {
        for (int i = A_0.ChildObjects.Count - 1; i >= (A_1 - 1); i--)
        {
            A_0.ChildObjects.RemoveAt(i);
        }
    }

    private static int smethod_5(Class5 A_0)
    {
        for (int i = 0; i < A_0.ChildObjects.Count; i++)
        {
            string text = ((TextRange) A_0.ChildObjects[i]).Text;
            if ((text.Length == 1) && (text[0] == '⁡'))
            {
                return i;
            }
        }
        return -1;
    }
}

