using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Text;

internal class Class234
{
    private bool bool_0;
    private bool bool_1 = true;
    private bool bool_2 = true;
    private bool bool_3 = true;
    private bool bool_4 = true;
    private bool bool_5;
    private bool bool_6;
    private readonly Class398 class398_0;
    private Class456[] class456_0;
    private Class679[] class679_0;
    private Class70[] class70_0;
    private Class784[] class784_0;
    private Class891[] class891_0;
    private Class891[] class891_1;
    private int int_0;
    private int int_1;
    private int[] int_2;
    private readonly ShapeBase shapeBase_0;
    private string string_0;
    private readonly string[] string_1 = new string[10];

    internal Class234(ShapeBase A_0, Class398 A_1)
    {
        this.class398_0 = A_1;
        this.shapeBase_0 = A_0;
    }

    internal void method_0(int A_0, object A_1)
    {
        switch (A_0)
        {
            case 0x145:
                this.class891_1 = (Class891[]) A_1;
                return;

            case 0x146:
                this.class679_0 = (Class679[]) A_1;
                return;

            case 0x147:
            case 0x148:
            case 0x149:
            case 330:
            case 0x14b:
            case 0x14c:
            case 0x14d:
            case 0x14e:
            case 0x14f:
            case 0x150:
                this.string_1[A_0 - 0x147] = Class1041.smethod_8((int) A_1);
                return;

            case 0x151:
                this.class891_0 = (Class891[]) A_1;
                return;

            case 0x152:
                this.int_2 = (int[]) A_1;
                return;

            case 0x153:
                this.int_0 = (int) A_1;
                return;

            case 340:
                this.int_1 = (int) A_1;
                return;

            case 0x155:
                this.class784_0 = (Class784[]) A_1;
                return;

            case 0x156:
                this.class456_0 = (Class456[]) A_1;
                return;

            case 0x157:
                this.class70_0 = (Class70[]) A_1;
                return;

            case 0x158:
                this.string_0 = Class1085.smethod_14((ConnectionSiteType) A_1);
                return;

            case 0x17a:
                this.bool_3 = (bool) A_1;
                return;

            case 0x17b:
                this.bool_4 = (bool) A_1;
                return;

            case 380:
                this.bool_2 = (bool) A_1;
                return;

            case 0x17d:
                this.bool_6 = (bool) A_1;
                return;

            case 0x17e:
                this.bool_5 = (bool) A_1;
                return;

            case 0x17f:
                this.bool_1 = (bool) A_1;
                return;

            case 0x1fb:
                this.bool_0 = (bool) A_1;
                return;
        }
    }

    internal void method_1()
    {
        int num = 2;
        if (this.shapeBase_0.ShapeType != ShapeType.RoundRectangle)
        {
            if (this.shapeBase_0.ShapeType == ShapeType.CustomShape)
            {
                if (this.string_1[0] == null)
                {
                    this.string_1[0] = BookmarkStart.b("ԧᬩᴫ᤭यб3ี࠷", num);
                }
                if (this.string_1[2] == null)
                {
                    this.string_1[2] = BookmarkStart.b("ᴧḩᰫḭ", num);
                }
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i <= 9; i++)
            {
                if (this.string_1[i] != null)
                {
                    builder.Append(this.string_1[i]);
                }
                builder.Append(',');
            }
            this.class398_0.method_36(BookmarkStart.b("䤧丩䘫", num), builder.ToString().TrimEnd(new char[] { ',' }));
        }
    }

    internal void method_10()
    {
        int num = 0x13;
        if ((this.class784_0 != null) && (this.class784_0.Length > 0))
        {
            this.class398_0.method_4(BookmarkStart.b("伸ĺ唼帾⽀❂⥄≆㩈", num));
            for (int i = 0; i < this.class784_0.Length; i++)
            {
                Class784 class2 = this.class784_0[i];
                this.class398_0.method_4(BookmarkStart.b("伸ĺ唼", num));
                this.method_11(BookmarkStart.b("䤸吺丼嘾㕀⩂⩄⥆", num), new Class623(class2.class72_0.method_0(), true), new Class623(class2.class72_1.method_0(), true));
                if (class2.bool_4)
                {
                    this.class398_0.method_18(BookmarkStart.b("䨸䰺吼䬾≀⭂", num), "");
                }
                if (class2.bool_3)
                {
                    this.method_11(BookmarkStart.b("䤸吺儼帾㍀", num), class2.class623_0, class2.class623_1);
                }
                if (class2.bool_2)
                {
                    this.method_11(BookmarkStart.b("吸娺䴼", num), class2.class623_0, class2.class623_1);
                }
                if (class2.bool_0)
                {
                    this.method_11(BookmarkStart.b("䬸娺夼嘾㑀あ㝄♆❈ⱊ⡌", num), class2.class623_2, class2.class623_3);
                }
                if (class2.bool_1)
                {
                    if ((class2.class623_2.method_1() != -2147483648) || (class2.class623_3.method_1() != 0x7fffffff))
                    {
                        this.method_11(BookmarkStart.b("䄸䤺尼儾♀♂", num), class2.class623_2, class2.class623_3);
                    }
                    if ((class2.class623_4.method_1() != -2147483648) || (class2.class623_5.method_1() != 0x7fffffff))
                    {
                        this.method_11(BookmarkStart.b("䀸䤺尼儾♀♂", num), class2.class623_4, class2.class623_5);
                    }
                }
                this.class398_0.method_5();
            }
            this.class398_0.method_5();
        }
    }

    private void method_11(string A_0, Class623 A_1, Class623 A_2)
    {
        this.class398_0.method_18(A_0, smethod_0(smethod_1(A_1), smethod_1(A_2)));
    }

    private string method_12(Class456 A_0)
    {
        int num = 14;
        if (((A_0.operation_0 == Operation.Sum) && (A_0.int_2 == 0)) && (A_0.int_3 == 0))
        {
            return smethod_2(new string[] { BookmarkStart.b("䈳圵吷", num), this.method_13(A_0.int_1, A_0.method_0()) });
        }
        string str = Class1085.smethod_4(A_0.operation_0);
        switch (A_0.operation_0)
        {
            case Operation.Mid:
            case Operation.Min:
            case Operation.Max:
            case Operation.Atan2:
            case Operation.Sin:
            case Operation.Cos:
                return smethod_2(new string[] { str, this.method_13(A_0.int_1, A_0.method_0()), this.method_13(A_0.int_2, A_0.method_1()) });

            case Operation.Abs:
            case Operation.Sqrt:
                return smethod_2(new string[] { str, this.method_13(A_0.int_1, A_0.method_0()) });
        }
        return smethod_2(new string[] { str, this.method_13(A_0.int_1, A_0.method_0()), this.method_13(A_0.int_2, A_0.method_1()), this.method_13(A_0.int_3, A_0.method_2()) });
    }

    private string method_13(int A_0, bool A_1)
    {
        int num = 14;
        if (!A_1)
        {
            return Class1041.smethod_8(A_0);
        }
        switch (A_0)
        {
            case 320:
                return BookmarkStart.b("䰳唵崷吹䠻嬽㈿", num);

            case 0x141:
                return BookmarkStart.b("䴳唵崷吹䠻嬽㈿", num);

            case 0x142:
                return BookmarkStart.b("䌳張尷丹吻", num);

            case 0x143:
                return BookmarkStart.b("尳匵儷崹吻䨽", num);

            case 0x153:
                return BookmarkStart.b("䰳娵儷圹医", num);

            case 340:
                return BookmarkStart.b("䴳娵儷圹医", num);

            case 0x4f7:
                return BookmarkStart.b("䐳張䀷弹倻爽⤿ⱁ⅃ᅅⅇ⹉㡋♍", num);

            case 0x4f8:
                return BookmarkStart.b("䐳張䀷弹倻椽⤿♁ぃ⹅", num);

            case 0x4f9:
                return BookmarkStart.b("䐳張䀷弹倻瘽┿⭁⍃⹅㱇", num);

            case 0x4fc:
                return BookmarkStart.b("儳嬵䴷洹唻娽㐿⩁", num);

            case 0x4fd:
                return BookmarkStart.b("儳嬵䴷爹夻圽✿⩁ぃ", num);

            case 0x4fe:
                return BookmarkStart.b("儳嬵䴷洹唻娽㐿⩁癃", num);

            case 0x4ff:
                return BookmarkStart.b("儳嬵䴷爹夻圽✿⩁ぃ瑅", num);

            case 0x1fc:
                return BookmarkStart.b("堳張嘷弹砻䰽ℿ㕁⩃", num);
        }
        if (A_0 >= 0x400)
        {
            return (BookmarkStart.b("琳", num) + (A_0 - 0x400));
        }
        if ((A_0 < 0x147) || (A_0 > 0x14e))
        {
            throw new InvalidOperationException(BookmarkStart.b("愳堵䨷弹弻儽✿ⱁⵃ㱅ⵇ⹉汋⅍⁏㝑♓㝕㙗㹙籛⡝ş๡ᅣͥ䡧ͩɫ乭ѯᩱᅳ噵ṷᕹ๻፽ꢅ", num));
        }
        return (BookmarkStart.b("ᜳ", num) + (A_0 - 0x147));
    }

    internal void method_2()
    {
        int num = 0;
        if (((this.class891_1 != null) && (this.class891_1.Length != 0)) && ((this.class679_0 != null) && (this.class679_0.Length != 0)))
        {
            StringBuilder builder = new StringBuilder();
            int index = 0;
            for (int i = 0; i < this.class679_0.Length; i++)
            {
                Class679 class3 = this.class679_0[i];
                builder.Append(Class1085.smethod_74(class3.method_0()));
                int num3 = class3.method_2();
                for (int j = 0; j < num3; j++)
                {
                    if (index >= this.class891_1.Length)
                    {
                        throw new InvalidOperationException(BookmarkStart.b("栥䜧帩ఫ䬭帯崱䄳儵倷ᨹ䰻弽㈿⍁⥃⍅㱇⽉㹋㵍灏㭑㩓癕㽗㽙㍛㍝՟ᙡᙣὥ䡧ᩩ൫ᩭᡯ山", num));
                    }
                    Class891 class2 = this.class891_1[index];
                    builder.Append(this.method_3(class2.method_0()));
                    builder.Append(',');
                    builder.Append(this.method_3(class2.method_1()));
                    builder.Append(',');
                    index++;
                }
                if (num3 > 0)
                {
                    builder.Remove(builder.Length - 1, 1);
                }
            }
            this.class398_0.method_40(BookmarkStart.b("嘥䤧帩䐫", num), builder.ToString());
        }
    }

    private string method_3(Class623 A_0)
    {
        int num = 1;
        if (A_0.method_0())
        {
            return (BookmarkStart.b("朦", num) + A_0.method_1());
        }
        return Class1041.smethod_36(A_0.method_1());
    }

    internal void method_4()
    {
        int num = 0x10;
        if (this.class456_0 != null)
        {
            this.class398_0.method_4(BookmarkStart.b("䀵ȷ尹医䰽ⴿ㝁⡃❅㭇", num));
            for (int i = 0; i < this.class456_0.Length; i++)
            {
                Class456 class2 = this.class456_0[i];
                this.class398_0.method_4(BookmarkStart.b("䀵ȷ尹", num));
                this.class398_0.method_18(BookmarkStart.b("匵䤷吹", num), this.method_12(class2));
                this.class398_0.method_5();
            }
            this.class398_0.method_5();
        }
    }

    internal void method_5()
    {
        int num = 8;
        if ((((((this.bool_0 || !this.bool_1) || (!this.bool_2 || !this.bool_3)) || ((!this.bool_4 || this.bool_5) || this.bool_6)) || ((this.string_0 != null) && (this.string_0 != BookmarkStart.b("䀭弯就儳", num)))) || ((this.class891_0 != null) && (this.class891_0.Length > 0))) || (((this.int_2 != null) && (this.int_2.Length > 0)) || (this.class70_0 != null)))
        {
            this.class398_0.method_4(BookmarkStart.b("堭ਯ䈱唳䈵倷", num));
            this.class398_0.method_37(BookmarkStart.b("伭䈯䀱嬳䄵圷儹", num), this.bool_0, false);
            this.class398_0.method_37(BookmarkStart.b("䠭夯帱堳夵匷", num), this.bool_1, true);
            this.class398_0.method_37(BookmarkStart.b("崭䐯䀱嬳崵崷唹圻", num), this.bool_2, true);
            this.class398_0.method_37(BookmarkStart.b("崭堯匱倳夵伷唹圻", num), this.bool_3, true);
            this.class398_0.method_37(BookmarkStart.b("䄭ਯ圱䰳䈵䨷伹伻圽⼿ⱁ⭃ⵅ", num), this.bool_4, true);
            this.class398_0.method_37(BookmarkStart.b("䤭䈯匱倳張崷吹䠻䴽⠿⍁㑃⍅❇ⅉ", num), this.bool_5, false);
            this.class398_0.method_37(BookmarkStart.b("娭唯䨱䀳䘵夷丹吻儽⬿", num), this.bool_6, false);
            if ((this.int_0 != 0) || (this.int_1 != 0))
            {
                this.class398_0.method_40(BookmarkStart.b("䈭夯弱嬳", num), string.Format(BookmarkStart.b("唭/伱ᠳ䴵ष䜹", num), this.int_0, this.int_1));
            }
            if (((this.class891_0 != null) && (this.class891_0.Length > 0)) && (this.string_0 == null))
            {
                this.class398_0.method_40(BookmarkStart.b("䄭ਯ儱嬳堵嘷弹弻䨽㐿㭁㑃⍅", num), BookmarkStart.b("䴭䔯䄱䀳夵唷", num));
            }
            else
            {
                this.class398_0.method_41(BookmarkStart.b("䄭ਯ儱嬳堵嘷弹弻䨽㐿㭁㑃⍅", num), this.string_0, BookmarkStart.b("䀭弯就儳", num));
            }
            this.method_6();
            this.method_7();
            this.method_8();
            this.class398_0.method_5();
        }
    }

    private void method_6()
    {
        int num = 0x12;
        if ((this.class891_0 != null) && (this.class891_0.Length > 0))
        {
            this.class398_0.method_40(BookmarkStart.b("圷9弻儽⸿ⱁ⅃╅㱇♉⍋ⵍ⍏", num), Class734.smethod_32(this.class891_0, ',', ';'));
        }
    }

    private void method_7()
    {
        int num = 10;
        if ((this.int_2 != null) && (this.int_2.Length > 0))
        {
            StringBuilder builder = new StringBuilder(0x20);
            for (int i = 0; i < this.int_2.Length; i++)
            {
                int num3 = this.int_2[i];
                builder.Append(Class734.smethod_14(num3));
                builder.Append(',');
            }
            builder.Remove(builder.Length - 1, 1);
            this.class398_0.method_40(BookmarkStart.b("弯࠱圳夵嘷吹夻崽㐿⍁⩃ⅅ⑇⽉㽋", num), builder.ToString());
        }
    }

    private void method_8()
    {
        int num = 9;
        if (this.class70_0 != null)
        {
            string str = this.method_9(this.class70_0);
            this.class398_0.method_40(BookmarkStart.b("嬮吰䬲䄴唶嘸䌺似娾≀㝂", num), str);
        }
        else if (!this.shapeBase_0.IsGroup && this.shapeBase_0.HasChildElements)
        {
            if (this.shapeBase_0.ShapeType == ShapeType.TextBox)
            {
                string str2 = this.method_9(((ShapeObject) this.shapeBase_0).TextBoxRects);
                this.class398_0.method_40(BookmarkStart.b("嬮吰䬲䄴唶嘸䌺似娾≀㝂", num), str2);
            }
            else
            {
                this.class398_0.method_40(BookmarkStart.b("嬮吰䬲䄴唶嘸䌺似娾≀㝂", num), BookmarkStart.b("ᰮ0Բشᬶਸ਺଼ా浀牂組獆穈籊慌繎楐杒晔恖", num));
            }
        }
    }

    private string method_9(Class70[] A_0)
    {
        int num = 8;
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < A_0.Length; i++)
        {
            Class70 class2 = A_0[i];
            builder.Append(Class734.smethod_33(class2.class623_0));
            builder.Append(',');
            builder.Append(Class734.smethod_33(class2.class623_1));
            builder.Append(',');
            builder.Append(Class734.smethod_33(class2.class623_2));
            builder.Append(',');
            builder.Append(Class734.smethod_33(class2.class623_3));
            if (i < (A_0.Length - 1))
            {
                builder.Append(BookmarkStart.b("ᔭ", num));
            }
        }
        return builder.ToString();
    }

    private static string smethod_0(string A_0, string A_1)
    {
        return string.Format(BookmarkStart.b("吮İ串ᤴ䰶࠸䘺", 9), A_0, A_1);
    }

    private static string smethod_1(Class623 A_0)
    {
        int num = 8;
        if (!A_0.method_0())
        {
            return A_0.method_1().ToString();
        }
        switch (A_0.method_1())
        {
            case 0:
                return BookmarkStart.b("娭弯䈱砳匵帷丹", num);

            case 1:
                return BookmarkStart.b("䰭弯䘱䀳夵唷根唻夽⠿㙁", num);

            case 2:
                return BookmarkStart.b("䴭唯就䀳匵䨷", num);
        }
        if (A_0.method_1() < 0x100)
        {
            return (BookmarkStart.b("渭", num) + (A_0.method_1() - 3));
        }
        return (BookmarkStart.b("ഭ", num) + (A_0.method_1() - 0x100));
    }

    private static string smethod_2(params string[] A_0)
    {
        StringBuilder builder = new StringBuilder(0x20);
        builder.Append(A_0[0]);
        for (int i = 1; i < A_0.Length; i++)
        {
            builder.Append(' ');
            builder.Append(A_0[i]);
        }
        return builder.ToString();
    }
}

