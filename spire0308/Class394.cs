using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.NML;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

internal class Class394 : Class393
{
    internal bool bool_0;
    private bool bool_1;
    private Document document_0;
    private int int_0;
    private Paragraph paragraph_0;
    private Stack<byte[]> stack_0;
    private readonly Stack stack_1;
    private Stack<Field> stack_2;
    private readonly StringBuilder stringBuilder_0;

    internal Class394(Document A_0)
    {
        this.stringBuilder_0 = new StringBuilder();
        this.stack_1 = new Stack();
        this.stack_2 = new Stack<Field>();
        this.document_0 = A_0;
    }

    internal Class394(Stream A_0) : base(A_0)
    {
        this.stringBuilder_0 = new StringBuilder();
        this.stack_1 = new Stack();
        this.stack_2 = new Stack<Field>();
    }

    internal Class394(string A_0, Hashtable A_1) : base(A_0, A_1)
    {
        this.stringBuilder_0 = new StringBuilder();
        this.stack_1 = new Stack();
        this.stack_2 = new Stack<Field>();
    }

    internal void method_26()
    {
        base.vmethod_1();
    }

    internal string method_27()
    {
        return base.method_12(BookmarkStart.b("儷帹", 0x12), null);
    }

    internal string method_28()
    {
        return base.method_12(BookmarkStart.b("䜰刲头", 11), null);
    }

    internal int method_29()
    {
        string str = this.method_28();
        if (Class567.smethod_16(str))
        {
            return Class1041.smethod_11(str);
        }
        return 0;
    }

    internal long method_30()
    {
        string str = this.method_28();
        if (Class567.smethod_16(str))
        {
            return long.Parse(str, NumberStyles.Integer, CultureInfo.InvariantCulture);
        }
        return 0L;
    }

    internal bool method_31()
    {
        string str = this.method_28();
        if (Class567.smethod_16(str))
        {
            return this.method_70(str);
        }
        return true;
    }

    internal Class650 method_32()
    {
        string str = this.method_28();
        if (Class567.smethod_16(str))
        {
            return Class650.smethod_0(this.method_70(str));
        }
        return Class650.class650_1;
    }

    internal bool method_33(bool A_0)
    {
        int num = 3;
        string str = base.method_21();
        if (str == null)
        {
            return A_0;
        }
        return (((str == BookmarkStart.b("崨太堬䨮", num)) || (str == BookmarkStart.b("崨", num))) || ((!(str == BookmarkStart.b("伨䨪䄬尮吰", num)) && !(str == BookmarkStart.b("伨", num))) && A_0));
    }

    internal char method_34(CharacterFormat A_0)
    {
        int num = 8;
        char ch = 0xf0ff;
        string str = BookmarkStart.b("紭䤯弱嘳夵吷", 8);
        while (base.method_19())
        {
            string str2 = base.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("䠭弯就䀳", num)))
                {
                    if (str2 == BookmarkStart.b("䴭堯匱䘳", num))
                    {
                        ch = (char) Class114.smethod_8(base.method_3());
                    }
                }
                else
                {
                    str = base.method_3();
                }
            }
        }
        A_0.FontName = str;
        return ch;
    }

    internal Border method_35(Border A_0)
    {
        return this.method_37(true, A_0);
    }

    internal Border method_36(Border A_0)
    {
        return this.method_37(false, A_0);
    }

    private Border method_37(bool A_0, Border A_1)
    {
        int num = 4;
        bool flag = false;
        bool flag2 = false;
        while (base.method_19())
        {
            string key = base.method_1();
            if (key != null)
            {
                int num4;
                if (Class1160.dictionary_23 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("尩䴫䈭", num), 0);
                    dictionary1.Add(BookmarkStart.b("天嘫", num), 1);
                    dictionary1.Add(BookmarkStart.b("天尫伭匯圱", num), 2);
                    dictionary1.Add(BookmarkStart.b("䤩䌫䈭弯䀱", num), 3);
                    dictionary1.Add(BookmarkStart.b("天䐫伭启崱䌳", num), 4);
                    dictionary1.Add(BookmarkStart.b("䰩師伭崯圱", num), 5);
                    dictionary1.Add(BookmarkStart.b("帩䐫䬭崯圱眳夵吷唹主", num), 6);
                    dictionary1.Add(BookmarkStart.b("帩䐫䬭崯圱朳帵夷帹夻", num), 7);
                    dictionary1.Add(BookmarkStart.b("帩䐫䬭崯圱怳張嘷丹", num), 8);
                    dictionary1.Add(BookmarkStart.b("䠩䠫尭䜯嬱倳䈵倷", num), 9);
                    Class1160.dictionary_23 = dictionary1;
                }
                if (Class1160.dictionary_23.TryGetValue(key, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                            A_1.BorderType = this.vmethod_3();
                            flag = base.method_3() == BookmarkStart.b("䐩䌫䀭唯", num);
                            A_1.IsChanged = true;
                            break;

                        case 1:
                        {
                            float num3 = this.method_69(8f);
                            if (num3 != float.MaxValue)
                            {
                                A_1.LineWidth = num3;
                                A_1.IsChanged = true;
                            }
                            break;
                        }
                        case 2:
                        {
                            float num5 = this.method_69(1f);
                            if (num5 != float.MaxValue)
                            {
                                A_1.Space = num5;
                                A_1.IsChanged = true;
                            }
                            break;
                        }
                        case 3:
                            A_1.Color = Class114.smethod_13(base.method_3());
                            A_1.IsChanged = true;
                            break;

                        case 4:
                            A_1.Shadow = this.method_63();
                            break;

                        case 6:
                            A_1.ColorShemeName = base.method_3();
                            break;

                        case 7:
                            A_1.ShadeTheme = base.method_3();
                            break;

                        case 9:
                        {
                            float num2 = this.method_69(20f);
                            A_1.LineWidth = num2;
                            flag2 = base.method_4() == 0;
                            break;
                        }
                    }
                }
            }
        }
        if ((A_0 && flag) && !flag2)
        {
            return null;
        }
        return A_1;
    }

    internal void method_38(Border A_0, bool A_1)
    {
        int num = 2;
        while (base.method_19())
        {
            string key = base.method_1();
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_24 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("帧䬩䀫", num), 0);
                    dictionary1.Add(BookmarkStart.b("嬧倩", num), 1);
                    dictionary1.Add(BookmarkStart.b("嬧娩䴫䴭唯", num), 2);
                    dictionary1.Add(BookmarkStart.b("䬧䔩䀫䄭䈯", num), 3);
                    dictionary1.Add(BookmarkStart.b("嬧䈩䴫䨭弯䔱", num), 4);
                    dictionary1.Add(BookmarkStart.b("丧堩䴫䌭唯", num), 5);
                    dictionary1.Add(BookmarkStart.b("尧䈩䤫䌭唯焱嬳娵圷䠹", num), 6);
                    dictionary1.Add(BookmarkStart.b("尧䈩䤫䌭唯愱尳圵尷弹", num), 7);
                    dictionary1.Add(BookmarkStart.b("尧䈩䤫䌭唯昱崳堵䰷", num), 8);
                    dictionary1.Add(BookmarkStart.b("䨧丩師夭夯嘱䀳帵", num), 9);
                    Class1160.dictionary_24 = dictionary1;
                }
                if (Class1160.dictionary_24.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                        {
                            A_0.BorderType = this.vmethod_3();
                            bool flag1 = base.method_3() == BookmarkStart.b("䘧䔩䈫䬭", num);
                            break;
                        }
                        case 1:
                        {
                            float num4 = this.method_69(8f);
                            if (num4 != float.MaxValue)
                            {
                                A_0.LineWidth = num4;
                            }
                            break;
                        }
                        case 2:
                        {
                            float num2 = this.method_69(1f);
                            if (num2 != float.MaxValue)
                            {
                                A_0.Space = num2;
                            }
                            break;
                        }
                        case 3:
                            A_0.Color = Class114.smethod_13(base.method_3());
                            break;

                        case 4:
                            A_0.Shadow = this.method_63();
                            break;

                        case 6:
                            A_0.ColorShemeName = base.method_3();
                            break;

                        case 7:
                            A_0.ShadeTheme = base.method_3();
                            break;

                        case 9:
                            base.method_4();
                            break;
                    }
                }
            }
        }
    }

    internal Class16 method_39()
    {
        int num = 15;
        Class16 class2 = new Class16();
        while (base.method_19())
        {
            string key = base.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_25 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("䌴嘶唸", num), 0);
                    dictionary1.Add(BookmarkStart.b("嘴堶唸吺似", num), 1);
                    dictionary1.Add(BookmarkStart.b("匴帶唸场", num), 2);
                    dictionary1.Add(BookmarkStart.b("䄴弶尸嘺堼簾⹀⽂⩄㕆", num), 3);
                    dictionary1.Add(BookmarkStart.b("䄴弶尸嘺堼氾⥀≂⅄≆", num), 4);
                    dictionary1.Add(BookmarkStart.b("䄴弶尸嘺堼款⡀ⵂㅄ", num), 5);
                    dictionary1.Add(BookmarkStart.b("䄴弶尸嘺堼社⡀⽂⥄", num), 6);
                    dictionary1.Add(BookmarkStart.b("䄴弶尸嘺堼社⡀⽂⥄ᑆⅈ⩊⥌⩎", num), 7);
                    dictionary1.Add(BookmarkStart.b("䄴弶尸嘺堼社⡀⽂⥄ፆ⁈╊㥌", num), 8);
                    Class1160.dictionary_25 = dictionary1;
                }
                if (Class1160.dictionary_25.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            class2.SetAttr(1, Class417.smethod_34(base.method_3()));
                            break;

                        case 1:
                            class2.method_61(Class114.smethod_13(base.method_3()));
                            break;

                        case 2:
                            class2.method_57(Class114.smethod_13(base.method_3()));
                            break;

                        case 3:
                            class2.method_65(base.method_3());
                            break;

                        case 4:
                            class2.method_67(base.method_3());
                            break;

                        case 5:
                            class2.method_69(base.method_3());
                            break;

                        case 6:
                            class2.method_71(base.method_3());
                            break;

                        case 7:
                            class2.method_73(base.method_3());
                            break;

                        case 8:
                            class2.method_75(base.method_3());
                            break;
                    }
                }
            }
        }
        return class2;
    }

    internal int method_40()
    {
        return this.method_44().Value;
    }

    internal float method_41()
    {
        return (float.Parse(this.method_44().Value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture) / 20f);
    }

    internal float method_42()
    {
        string str2;
        int num = 0;
        string s = base.method_12(BookmarkStart.b("儥", 0), string.Empty);
        if (((str2 = base.method_12(BookmarkStart.b("別儧娩䤫", 0), string.Empty)) != null) && (str2 == BookmarkStart.b("嘥尧", num)))
        {
            return float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture);
        }
        return (float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f);
    }

    internal Class15 method_43()
    {
        int num = 8;
        int num2 = 0;
        FtsWidth auto = FtsWidth.Auto;
        bool flag = false;
        while (base.method_19())
        {
            string str = base.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("夭", num)))
                {
                    if (str == BookmarkStart.b("娭䤯䈱儳", num))
                    {
                        auto = Class417.smethod_31(base.method_3());
                    }
                }
                else
                {
                    flag = smethod_0(base.method_3());
                    num2 = this.method_50(base.method_3());
                }
            }
        }
        if ((auto == FtsWidth.Percentage) && !flag)
        {
            num2 /= 50;
        }
        return new Class15(auto, num2);
    }

    internal PreferredWidth method_44()
    {
        int num = 6;
        short num2 = 0;
        WidthType auto = WidthType.Auto;
        bool flag = false;
        while (base.method_19())
        {
            string str = base.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("嬫", num)))
                {
                    if (str == BookmarkStart.b("堫圭䀯圱", num))
                    {
                        auto = Class417.smethod_32(base.method_3());
                    }
                }
                else
                {
                    flag = smethod_0(base.method_3());
                    num2 = (short) this.method_50(base.method_3());
                }
            }
        }
        if ((auto == WidthType.Percentage) && !flag)
        {
            num2 = (short) (num2 / 50);
        }
        return new PreferredWidth(auto, num2);
    }

    internal void method_45(CellFormat A_0)
    {
        Class15 class2 = this.method_43();
        A_0.PreferredWidth = class2;
        switch (class2.method_51())
        {
            case FtsWidth.None:
                A_0.WidthUnit = FtsWidth.None;
                A_0.CellWidth = 0f;
                return;

            case FtsWidth.Auto:
                A_0.WidthUnit = FtsWidth.Auto;
                A_0.CellWidth = 0f;
                return;

            case FtsWidth.Percentage:
                A_0.WidthUnit = FtsWidth.Percentage;
                A_0.CellScaling = class2.method_49() / 50f;
                return;

            case FtsWidth.Point:
                A_0.WidthUnit = FtsWidth.Point;
                A_0.CellWidth = class2.method_49() / 20f;
                return;
        }
    }

    internal void method_46(RowFormat A_0)
    {
        Class15 class2 = this.method_43();
        Class15 tablePreferredWidthInfo = A_0.TablePreferredWidthInfo;
        switch (class2.method_51())
        {
            case FtsWidth.None:
                tablePreferredWidthInfo.method_52(FtsWidth.None);
                tablePreferredWidthInfo.method_50(0f);
                return;

            case FtsWidth.Auto:
                tablePreferredWidthInfo.method_52(FtsWidth.Auto);
                tablePreferredWidthInfo.method_50(0f);
                return;

            case FtsWidth.Percentage:
                tablePreferredWidthInfo.method_52(FtsWidth.Percentage);
                tablePreferredWidthInfo.method_50(class2.method_49());
                return;

            case FtsWidth.Point:
                tablePreferredWidthInfo.method_52(FtsWidth.Point);
                tablePreferredWidthInfo.method_50(class2.method_49());
                return;
        }
    }

    internal int method_47()
    {
        return smethod_4(this.method_49(this.method_28(), NMLUnit.HalfPoints));
    }

    internal int method_48()
    {
        return smethod_4(this.method_49(this.method_28(), NMLUnit.Twips));
    }

    internal double method_49(string A_0, NMLUnit A_1)
    {
        double num = 0.0;
        if (A_0 != string.Empty)
        {
            int num2 = A_0.Length - 1;
            while (num2 >= 0)
            {
                if ((A_0[num2] >= '0') && (A_0[num2] <= '9'))
                {
                    break;
                }
                num2--;
            }
            double d = Class1041.smethod_15(A_0.Substring(0, num2 + 1));
            NMLUnit unit = smethod_3(A_0.Substring(num2 + 1, (A_0.Length - num2) - 1), A_1);
            if (!double.IsNaN(d))
            {
                num = (float) smethod_1(d, unit, A_1);
            }
        }
        return num;
    }

    internal int method_50(string A_0)
    {
        if (smethod_0(A_0))
        {
            return (int) Class1041.smethod_13(A_0.Substring(0, A_0.Length - 1));
        }
        return Class1041.smethod_11(A_0);
    }

    internal StringBuilder method_51()
    {
        return this.stringBuilder_0;
    }

    internal Stack method_52()
    {
        return this.stack_1;
    }

    internal FieldCharType method_53()
    {
        if ((this.stack_1 != null) && (this.stack_1.Count > 0))
        {
            return (FieldCharType) this.stack_1.Peek();
        }
        return FieldCharType.Unknown;
    }

    internal Stack<Field> method_54()
    {
        return this.stack_2;
    }

    internal bool method_55()
    {
        return this.bool_1;
    }

    internal void method_56(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal Field method_57()
    {
        if ((this.stack_2 != null) && (this.stack_2.Count > 0))
        {
            return this.stack_2.Peek();
        }
        return null;
    }

    internal int method_58()
    {
        return this.int_0;
    }

    internal void method_59(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_60()
    {
        return smethod_4(this.method_49(base.method_3(), NMLUnit.HalfPoints));
    }

    internal int method_61()
    {
        return smethod_4(this.method_49(base.method_3(), NMLUnit.Twips));
    }

    internal float method_62()
    {
        if (!string.IsNullOrEmpty(base.method_3()))
        {
            return (float.Parse(base.method_3(), NumberStyles.Float, CultureInfo.InvariantCulture) / 20f);
        }
        return float.MaxValue;
    }

    internal bool method_63()
    {
        return this.method_70(base.method_3());
    }

    internal Paragraph method_64()
    {
        return this.paragraph_0;
    }

    internal void method_65(Paragraph A_0)
    {
        this.paragraph_0 = A_0;
    }

    internal Document method_66()
    {
        return this.document_0;
    }

    internal byte[] method_67()
    {
        if ((this.stack_0 != null) && (this.stack_0.Count != 0))
        {
            return this.stack_0.Peek();
        }
        return null;
    }

    internal Stack<byte[]> method_68()
    {
        if (this.stack_0 == null)
        {
            this.stack_0 = new Stack<byte[]>();
        }
        return this.stack_0;
    }

    internal float method_69(float A_0)
    {
        if (!string.IsNullOrEmpty(base.method_3()) && !float.IsNaN(A_0))
        {
            return (float.Parse(base.method_3(), NumberStyles.Float, CultureInfo.InvariantCulture) / A_0);
        }
        return float.MaxValue;
    }

    internal bool method_70(string A_0)
    {
        int num = 1;
        if (((A_0 == BookmarkStart.b("䠦䜨", 1)) || (A_0 == BookmarkStart.b("ᘦ", num))) || ((A_0 == BookmarkStart.b("匦嬨帪䠬", num)) || (A_0 == BookmarkStart.b("匦", num))))
        {
            return true;
        }
        if ((!(A_0 == BookmarkStart.b("䠦伨䴪", num)) && !(A_0 == BookmarkStart.b("ᜦ", num))) && (!(A_0 == BookmarkStart.b("䄦䠨䜪帬䨮", num)) && !(A_0 == BookmarkStart.b("䄦", num))))
        {
            throw new InvalidOperationException(BookmarkStart.b("爦䜨䀪䌬䀮䘰崲ᔴ䄶堸场䠼娾慀╂⩄㕆楈⩊⍌潎癐㱒㭔ᡖ㽘㵚ड़♞ᅠ٢䉤䝦ࡨὪᥬᵮᡰᅲtͶᱸ啺", num));
        }
        return false;
    }

    private static bool smethod_0(string A_0)
    {
        return ((A_0.Length >= 1) && (A_0[A_0.Length - 1] == '%'));
    }

    private static double smethod_1(double A_0, NMLUnit A_1, NMLUnit A_2)
    {
        int num = 4;
        double num2 = A_0;
        if (A_1 == A_2)
        {
            return num2;
        }
        switch (A_1)
        {
            case NMLUnit.Pica:
                num2 *= 12.0;
                break;

            case NMLUnit.Point:
                break;

            case NMLUnit.Inch:
                num2 = Class969.smethod_13(A_0);
                break;

            case NMLUnit.Milimiter:
                num2 = Class969.smethod_15(A_0);
                break;

            case NMLUnit.Centimeter:
                num2 = Class969.smethod_22(A_0);
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("缩䈫䔭帯崱䌳堵ᠷ伹刻圽㘿❁㙃㕅⥇♉汋⍍㕏㍑❓⍕⩗㽙牛", num));
        }
        return (num2 * smethod_2(A_2));
    }

    private static float smethod_2(NMLUnit A_0)
    {
        switch (A_0)
        {
            case NMLUnit.HalfPoints:
                return 2f;

            case NMLUnit.Twips:
                return 20f;
        }
        return 1f;
    }

    private static NMLUnit smethod_3(string A_0, NMLUnit A_1)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_26 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("帶圸", num), 0);
                dictionary1.Add(BookmarkStart.b("䜶䴸", num), 1);
                dictionary1.Add(BookmarkStart.b("娶吸", num), 2);
                dictionary1.Add(BookmarkStart.b("吶吸", num), 3);
                dictionary1.Add(BookmarkStart.b("䜶娸", num), 4);
                dictionary1.Add(BookmarkStart.b("䜶倸", num), 5);
                dictionary1.Add("", 6);
                Class1160.dictionary_26 = dictionary1;
            }
            if (Class1160.dictionary_26.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return NMLUnit.Inch;

                    case 1:
                        return NMLUnit.Point;

                    case 2:
                        return NMLUnit.Milimiter;

                    case 3:
                        return NMLUnit.Centimeter;

                    case 4:
                    case 5:
                        return NMLUnit.Pica;

                    case 6:
                        return A_1;
                }
            }
        }
        throw new ArgumentOutOfRangeException(string.Format(BookmarkStart.b("戶圸债匼倾㙀ⵂ敄㉆❈≊㭌⩎⍐⁒㑔㭖祘㙚㡜㹞በᙢᝤɦ䥨ၪ嵬ቮ", num), A_0));
    }

    private static int smethod_4(double A_0)
    {
        return (int) Math.Round(A_0);
    }

    public override void vmethod_1()
    {
    }

    internal virtual bool vmethod_2()
    {
        throw new InvalidOperationException(BookmarkStart.b("礷堹伻䨽㈿⍁❃㉅桇⍉⅋㹍㱏㝑㥓㍕㙗⹙㵛⩝य़ൡ੣䙥ŧᥩ䱫൭ᅯṱᡳ፵ᱷ呹", 0x12));
    }

    protected virtual BorderStyle vmethod_3()
    {
        return BorderStyle.None;
    }
}

