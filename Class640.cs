using Spire.Doc;
using Spire.Doc.Converters.Sgml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

internal class Class640
{
    private Class631 class631_0;
    private Dictionary<string, Class636> dictionary_0;
    private Dictionary<string, Class631> dictionary_1;
    private Dictionary<string, Class631> dictionary_2;
    private const string string_0 = " \r\n\t";
    private string string_1;
    private static string string_2 = BookmarkStart.b("ᔴ㨶㌸㈺䄼ጾ桀", 15);
    private static string string_3 = BookmarkStart.b("ᔴ㨶㌸㈺̼", 15);
    private static string string_4 = BookmarkStart.b("ᔴ㨶㌸㈺ᄼ᤾㵀歂汄硆扈慊", 15);
    private static string string_5 = BookmarkStart.b("ᔴ㸶㐸ㄺ̼", 15);
    private StringBuilder stringBuilder_0;

    public Class640(string A_0, XmlNameTable A_1)
    {
        this.string_1 = A_0;
        this.dictionary_0 = new Dictionary<string, Class636>();
        this.dictionary_1 = new Dictionary<string, Class631>();
        this.dictionary_2 = new Dictionary<string, Class631>();
        this.stringBuilder_0 = new StringBuilder();
    }

    public string method_0()
    {
        return this.string_1;
    }

    public XmlNameTable method_1()
    {
        return null;
    }

    private void method_10()
    {
        int num = 12;
        this.class631_0.method_15();
        string a = this.method_13(BookmarkStart.b("椱", 12));
        if (string.Equals(a, BookmarkStart.b("笱稳电琷漹砻笽", 12), StringComparison.OrdinalIgnoreCase))
        {
            this.method_11();
        }
        else if (string.Equals(a, BookmarkStart.b("笱猳砵眷根礻", num), StringComparison.OrdinalIgnoreCase))
        {
            this.method_12();
        }
        else
        {
            this.class631_0.method_28(BookmarkStart.b("朱娳䔵䴷䨹䰻儽㈿㙁⅃≅桇❉ⵋ㱍㭏㝑こ癕⭗㽙㽛⩝य़ൡ੣䙥ᱧ፩ᱫ୭偯啱ཱི䙵շ嵹", num), a);
        }
    }

    private void method_11()
    {
        throw new NotImplementedException(BookmarkStart.b("札帯儱堳䌵尷弹᰻洽┿⅁ぃ⽅❇⑉", 8));
    }

    private void method_12()
    {
        int num = 2;
        char ch = this.class631_0.method_19();
        if (ch != '[')
        {
            this.class631_0.method_26(BookmarkStart.b("洧利尫䬭匯䘱崳堵強ᨹᬻ攽朿扁♃㍅㱇橉⩋⅍╏㱑こ癕⍗橙⅛", num), ch);
        }
        this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("欧䔩䈫䨭夯䘱崳夵嘷嬹倻ḽጿ❁❃㉅ⅇ╉≋", num), BookmarkStart.b("甧眩ራ", num));
    }

    private string method_13(string A_0)
    {
        int num = 6;
        if (this.class631_0.method_19() != '%')
        {
            return this.class631_0.method_20(this.stringBuilder_0, A_0, true);
        }
        Class631 class2 = this.method_14(A_0);
        char ch = this.class631_0.method_7();
        if (!class2.method_10())
        {
            throw new NotSupportedException(BookmarkStart.b("椫嘭䐯圱䘳堵夷嘹᰻丽ℿぁ╃⭅ⵇ㹉⥋㱍灏㝑㩓≕ㅗ⹙╛繝቟ݡᝣ॥ѧὩᡫݭὯᱱ", num));
        }
        return class2.method_11().Trim();
    }

    private Class631 method_14(string A_0)
    {
        this.class631_0.method_15();
        string str = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("വ", 0x10) + A_0, false);
        if (this.class631_0.method_7() == ';')
        {
            this.class631_0.method_15();
        }
        return this.method_15(str);
    }

    private Class631 method_15(string A_0)
    {
        int num = 7;
        Class631 class2 = null;
        this.dictionary_1.TryGetValue(A_0, out class2);
        if (class2 == null)
        {
            this.class631_0.method_28(BookmarkStart.b("缬䨮地嘲䜴制圸堺堼Ἶ㕀ⱂ敄㉆❈⽊⡌⥎㡐㵒ご㍖祘⭚㱜ⵞ`๢d፦౨ᥪ䵬੮ὰݲᱴͶx孺婼Ѿ놀ﺂꊄ", num), A_0);
        }
        return class2;
    }

    public Dictionary<string, Class631> method_16()
    {
        Dictionary<string, Class631> dictionary = new Dictionary<string, Class631>();
        foreach (Class631 class2 in this.dictionary_2.Values)
        {
            dictionary[class2.method_11()] = class2;
        }
        return dictionary;
    }

    private void method_17()
    {
        char ch;
        bool flag;
        int num = 13;
        if (flag = this.class631_0.method_19() == '%')
        {
            this.class631_0.method_15();
            ch = this.class631_0.method_19();
        }
        string str6 = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("ጲ㠴㴶〸", num), true);
        ch = this.class631_0.method_19();
        Class631 class2 = null;
        switch (ch)
        {
            case '"':
            case '\'':
            {
                string str7 = this.class631_0.method_21(this.stringBuilder_0, ch);
                class2 = new Class631(str6, str7);
                break;
            }
            default:
            {
                string str2 = null;
                string a = null;
                string str4 = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("ጲ㠴㴶〸", num), true);
                if (Class631.smethod_0(str4))
                {
                    ch = this.class631_0.method_19();
                    string str5 = this.class631_0.method_21(this.stringBuilder_0, ch);
                    class2 = new Class631(str6, str5);
                    class2.method_30(str4);
                }
                else
                {
                    a = str4;
                    if (string.Equals(a, BookmarkStart.b("挲怴甶甸爺縼", num), StringComparison.OrdinalIgnoreCase))
                    {
                        ch = this.class631_0.method_19();
                        if ((ch != '"') && (ch != '\''))
                        {
                            this.class631_0.method_26(BookmarkStart.b("瘲䴴䜶尸堺䤼嘾⽀⑂敄㝆㱈⥊⅌♎㉐獒㱔㍖㱘㕚⥜㙞ݠ੢dᕦ䥨ݪѬ᭮ᑰŲᑴ᭶奸᥺ࡼ୾ꆀ권ꢎꎒ낖", num), ch);
                        }
                        else
                        {
                            str2 = this.class631_0.method_21(this.stringBuilder_0, ch);
                        }
                    }
                    else if (!string.Equals(a, BookmarkStart.b("怲水搶洸縺瀼", num), StringComparison.OrdinalIgnoreCase))
                    {
                        this.class631_0.method_28(BookmarkStart.b("稲嬴䄶堸场吼嬾慀♂㵄㍆ⱈ㥊⍌⹎㵐獒㱔㍖㱘㕚⥜㙞ݠ੢dᕦ䥨䱪ᙬ彮౰呲孴坶奸㹺ռཾꮊꪌ\udf8e\uc490톒\ud994\ude96\uda98\ubc9a붜펠莢芤怜ﲰ钲鮴", num), a);
                    }
                    string str = null;
                    ch = this.class631_0.method_19();
                    if ((ch != '"') && (ch != '\''))
                    {
                        if (ch != '>')
                        {
                            this.class631_0.method_26(BookmarkStart.b("瘲䴴䜶尸堺䤼嘾⽀⑂敄㑆え㡊㥌⩎㱐獒㱔㍖㱘㕚⥜㙞ݠ੢dᕦ䥨ݪѬ᭮ᑰŲᑴ᭶奸᥺ࡼ୾ꆀ권ꢎꎒ낖", num), ch);
                        }
                    }
                    else
                    {
                        str = this.class631_0.method_21(this.stringBuilder_0, ch);
                    }
                    class2 = new Class631(str6, str2, str, this.class631_0.method_14());
                }
                break;
            }
        }
        ch = this.class631_0.method_19();
        if (ch == '-')
        {
            ch = this.method_8();
        }
        if (ch != '>')
        {
            this.class631_0.method_26(BookmarkStart.b("瘲䴴䜶尸堺䤼嘾⽀⑂敄≆❈⽊浌⁎㝐獒ご㥖ⵘ㉚⥜♞䅠ݢdѦը੪Ὤ๮հᩲᩴ᥶奸屺䍼塾ꆀꦈ搜ﾐ떔낖ꮚ뢞", num), ch);
        }
        if (flag)
        {
            this.dictionary_1.Add(class2.method_0(), class2);
        }
        else
        {
            this.dictionary_2.Add(class2.method_0(), class2);
        }
    }

    private void method_18()
    {
        int num = 1;
        char ch = this.class631_0.method_19();
        string[] strArray = this.method_19(ch, true);
        ch = char.ToUpperInvariant(this.class631_0.method_19());
        bool flag = false;
        bool flag2 = false;
        switch (ch)
        {
            case 'O':
            case '-':
                flag = ch == 'O';
                this.class631_0.method_15();
                ch = char.ToUpperInvariant(this.class631_0.method_19());
                if ((ch == 'O') || (ch == '-'))
                {
                    flag2 = ch == 'O';
                    ch = this.class631_0.method_15();
                }
                break;
        }
        ch = this.class631_0.method_19();
        Class637 class2 = this.method_21(ch);
        ch = this.class631_0.method_19();
        string[] strArray2 = null;
        string[] strArray3 = null;
        if (ch == '-')
        {
            ch = this.class631_0.method_15();
            switch (ch)
            {
                case '(':
                    strArray2 = this.method_19(ch, true);
                    ch = this.class631_0.method_19();
                    goto Label_00F6;

                case '-':
                    ch = this.method_9(false);
                    goto Label_00F6;
            }
            this.class631_0.method_26(BookmarkStart.b("渦䜨崪䰬䌮堰圲ᔴ䐶䀸唺䤼帾㥀捂⑄㍆楈汊㙌罎ⱐ瑒", num), ch);
        }
    Label_00F6:
        if (ch == '-')
        {
            ch = this.method_8();
        }
        if (ch == '+')
        {
            ch = this.class631_0.method_15();
            if (ch != '(')
            {
                this.class631_0.method_26(BookmarkStart.b("戦儨嬪䠬䰮䔰娲嬴倶ᤸ刺匼尾ⵀ㙂㙄⹆♈╊㹌潎㽐㉒㡔㉖祘㱚⽜ぞᑠ።", num), ch);
            }
            strArray3 = this.method_19(ch, true);
            ch = this.class631_0.method_19();
        }
        if (ch == '-')
        {
            ch = this.method_8();
        }
        if (ch != '>')
        {
            this.class631_0.method_26(BookmarkStart.b("戦儨嬪䠬䰮䔰娲嬴倶ᤸ帺匼嬾慀ⱂ⍄杆ై݊ࡌɎᑐᵒŔ睖㵘㹚㹜㍞`ᅢѤ፦hѪͬ佮噰䵲剴坶᭸๺ॼ彾ꮊꪌꆐ는", num), ch);
        }
        foreach (string str in strArray)
        {
            string key = str.ToUpperInvariant();
            this.dictionary_0.Add(key, new Class636(key, flag, flag2, class2, strArray3, strArray2));
        }
    }

    private string[] method_19(char A_0, bool A_1)
    {
        int num = 8;
        ArrayList list = new ArrayList();
        if (A_0 == '(')
        {
            A_0 = this.class631_0.method_15();
            A_0 = this.class631_0.method_19();
            while (A_0 != ')')
            {
                A_0 = this.class631_0.method_19();
                if (A_0 == '%')
                {
                    Class631 class2 = this.method_14(string_2);
                    this.method_4(this.class631_0.method_5(), class2);
                    this.method_20(list, A_1);
                    this.method_5();
                    A_0 = this.class631_0.method_7();
                }
                else
                {
                    string str2 = this.class631_0.method_20(this.stringBuilder_0, string_2, A_1).ToUpperInvariant();
                    list.Add(str2);
                }
                A_0 = this.class631_0.method_19();
                if ((A_0 == '|') || (A_0 == ','))
                {
                    A_0 = this.class631_0.method_15();
                }
            }
            this.class631_0.method_15();
        }
        else
        {
            string str = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("อ㴯㠱㴳", num), A_1).ToUpperInvariant();
            list.Add(str);
        }
        return (string[]) list.ToArray(typeof(string));
    }

    public Class631 method_2(string A_0)
    {
        Class631 class2;
        this.dictionary_2.TryGetValue(A_0, out class2);
        return class2;
    }

    private void method_20(ArrayList A_0, bool A_1)
    {
        char ch = this.class631_0.method_7();
        ch = this.class631_0.method_19();
        while (ch != 0xffff)
        {
            if (ch == '%')
            {
                Class631 class2 = this.method_14(string_2);
                this.method_4(this.class631_0.method_5(), class2);
                this.method_20(A_0, A_1);
                this.method_5();
                ch = this.class631_0.method_7();
            }
            else
            {
                string str = this.class631_0.method_20(this.stringBuilder_0, string_2, true).ToUpperInvariant();
                A_0.Add(str);
            }
            ch = this.class631_0.method_19();
            if (ch == '|')
            {
                ch = this.class631_0.method_15();
                ch = this.class631_0.method_19();
            }
        }
    }

    private Class637 method_21(char A_0)
    {
        Class637 class2 = new Class637();
        if (A_0 == '(')
        {
            this.class631_0.method_15();
            this.method_22(')', class2);
            A_0 = this.class631_0.method_15();
            if (((A_0 == '?') || (A_0 == '+')) || (A_0 == '*'))
            {
                class2.method_6(A_0);
                this.class631_0.method_15();
            }
            return class2;
        }
        if (A_0 == '%')
        {
            Class631 class3 = this.method_14(string_3);
            this.method_4(this.class631_0.method_5(), class3);
            class2 = this.method_21(this.class631_0.method_7());
            this.method_5();
            return class2;
        }
        string str = this.method_13(string_3);
        class2.method_7(str);
        return class2;
    }

    private void method_22(char A_0, Class637 A_1)
    {
        int num = 0x11;
        int num2 = A_1.method_0();
        char ch = this.class631_0.method_7();
        ch = this.class631_0.method_19();
        while ((ch != A_0) || (A_1.method_0() > num2))
        {
            switch (ch)
            {
                case 0xffff:
                    this.class631_0.method_25(BookmarkStart.b("琶嘸唺䤼娾⽀㝂敄੆♈⽊⡌⍎煐⑒㑔⑖祘㕚㉜⭞䅠b।ࡦᩨ๪६", num));
                    break;

                case '%':
                {
                    Class631 class2 = this.method_14(string_4);
                    this.method_4(this.class631_0.method_5(), class2);
                    this.method_22(0xffff, A_1);
                    this.method_5();
                    ch = this.class631_0.method_19();
                    continue;
                }
                case '(':
                {
                    A_1.method_2();
                    this.class631_0.method_15();
                    ch = this.class631_0.method_19();
                    continue;
                }
                case ')':
                {
                    ch = this.class631_0.method_15();
                    switch (ch)
                    {
                        case '*':
                        case '+':
                        case '?':
                            A_1.method_6(ch);
                            ch = this.class631_0.method_15();
                            break;
                    }
                    if (A_1.method_3() < num2)
                    {
                        this.class631_0.method_25(BookmarkStart.b("朶堸䤺尼刾⑀㝂⁄㕆楈⹊⍌㭎㡐❒ⱔ睖㩘㩚㍜ㅞ๠ᝢ䕤ѦըѪṬ੮兰ቲ啴ݶᡸॺ᡼ᅾꆀ愈놐朗낖뮚쾠莢횤쒦욨\udbaa\uc8ac", num));
                    }
                    ch = this.class631_0.method_19();
                    continue;
                }
            }
            if (((ch != ',') && (ch != '|')) && (ch != '&'))
            {
                string str;
                if (ch == '#')
                {
                    ch = this.class631_0.method_15();
                    str = BookmarkStart.b("ᐶ", num) + this.class631_0.method_20(this.stringBuilder_0, string_4, true);
                }
                else
                {
                    str = this.class631_0.method_20(this.stringBuilder_0, string_4, true);
                }
                str = str.ToUpperInvariant();
                ch = this.class631_0.method_7();
                if (((ch != '?') && (ch != '+')) && (ch != '*'))
                {
                    A_1.method_4(str);
                    ch = this.class631_0.method_19();
                }
                else
                {
                    A_1.method_2();
                    A_1.method_4(str);
                    A_1.method_6(ch);
                    A_1.method_3();
                    this.class631_0.method_15();
                    ch = this.class631_0.method_19();
                }
            }
            else
            {
                A_1.method_5(ch);
                this.class631_0.method_15();
                ch = this.class631_0.method_19();
            }
        }
    }

    private void method_23()
    {
        int num = 10;
        char ch = this.class631_0.method_19();
        string[] strArray = this.method_19(ch, true);
        Dictionary<string, Class639> dictionary = new Dictionary<string, Class639>();
        this.method_24(dictionary, '>');
        foreach (string str in strArray)
        {
            Class636 class2;
            if (!this.dictionary_0.TryGetValue(str, out class2))
            {
                this.class631_0.method_28(BookmarkStart.b("焯昱怳稵焷椹栻ḽ㈿❁≃⍅㩇⽉≋ⵍ㕏⅑瑓⍕㙗㹙㥛㡝य़ౡţɥ䡧⽩⁫⭭㵯㝱㩳≵塷Ź䱻ͽ", num), str);
            }
            class2.method_5(dictionary);
        }
    }

    private void method_24(Dictionary<string, Class639> A_0, char A_1)
    {
        for (char ch = this.class631_0.method_19(); ch != A_1; ch = this.class631_0.method_19())
        {
            switch (ch)
            {
                case '%':
                {
                    Class631 class3 = this.method_14(string_5);
                    this.method_4(this.class631_0.method_5(), class3);
                    this.method_24(A_0, 0xffff);
                    this.method_5();
                    ch = this.class631_0.method_19();
                    break;
                }
                case '-':
                    ch = this.method_8();
                    break;

                default:
                {
                    Class639 class2 = this.method_25(ch);
                    A_0.Add(class2.method_0(), class2);
                    break;
                }
            }
        }
    }

    private Class639 method_25(char A_0)
    {
        A_0 = this.class631_0.method_19();
        Class639 class2 = new Class639(this.method_13(BookmarkStart.b("ု㼱㸳㼵", 10)).ToUpperInvariant());
        A_0 = this.class631_0.method_19();
        if (A_0 == '-')
        {
            A_0 = this.method_8();
        }
        this.method_26(A_0, class2);
        A_0 = this.class631_0.method_19();
        if (A_0 == '-')
        {
            A_0 = this.method_8();
        }
        this.method_27(A_0, class2);
        A_0 = this.class631_0.method_19();
        if (A_0 == '-')
        {
            A_0 = this.method_8();
        }
        return class2;
    }

    private void method_26(char A_0, Class639 A_1)
    {
        int num = 9;
        if (A_0 == '%')
        {
            Class631 class2 = this.method_14(BookmarkStart.b("༮㰰㤲㰴", num));
            this.method_4(this.class631_0.method_5(), class2);
            this.method_26(this.class631_0.method_7(), A_1);
            this.method_5();
            A_0 = this.class631_0.method_7();
        }
        else if (A_0 == '(')
        {
            A_1.method_5(this.method_19(A_0, false), AttributeType.ENUMERATION);
        }
        else
        {
            string a = this.method_13(BookmarkStart.b("༮㰰㤲㰴", num));
            if (string.Equals(a, BookmarkStart.b("愮縰朲琴挶瀸琺猼", num), StringComparison.OrdinalIgnoreCase))
            {
                A_0 = this.class631_0.method_19();
                if (A_0 != '(')
                {
                    this.class631_0.method_26(BookmarkStart.b("樮䤰䌲倴吶䴸刺匼堾慀ⵂ⑄⩆ⱈ歊⩌㵎㹐♒╔睖繘獚穜獞䅠Ţၤ፦䥨൪ɬᩮὰᝲ啴偶ɸ䭺|塾", num), A_0);
                }
                A_1.method_5(this.method_19(A_0, true), AttributeType.NOTATION);
            }
            else
            {
                A_1.method_7(a);
            }
        }
    }

    private void method_27(char A_0, Class639 A_1)
    {
        int num = 4;
        if (A_0 == '%')
        {
            Class631 class2 = this.method_14(BookmarkStart.b("਩Å␭㤯", num));
            this.method_4(this.class631_0.method_5(), class2);
            this.method_27(this.class631_0.method_7(), A_1);
            this.method_5();
            A_0 = this.class631_0.method_7();
        }
        else
        {
            bool flag = true;
            if (A_0 == '#')
            {
                this.class631_0.method_15();
                string str = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("਩Å␭㤯", num), true);
                flag = A_1.method_8(str);
                A_0 = this.class631_0.method_19();
            }
            if (flag)
            {
                if ((A_0 == '\'') || (A_0 == '"'))
                {
                    string str3 = this.class631_0.method_21(this.stringBuilder_0, A_0);
                    A_1.method_2(str3);
                    A_0 = this.class631_0.method_19();
                }
                else
                {
                    string str2 = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("਩Å␭㤯", num), false).ToUpperInvariant();
                    A_1.method_2(str2);
                    A_0 = this.class631_0.method_19();
                }
            }
        }
    }

    public Class636 method_3(string A_0)
    {
        Class636 class2;
        this.dictionary_0.TryGetValue(A_0.ToUpperInvariant(), out class2);
        return class2;
    }

    private void method_4(Uri A_0, Class631 A_1)
    {
        A_1.method_16(this.class631_0, A_0);
        this.class631_0 = A_1;
        this.class631_0.method_15();
    }

    private void method_5()
    {
        if (this.class631_0 != null)
        {
            this.class631_0.method_18();
        }
        if (this.class631_0.method_6() != null)
        {
            this.class631_0 = this.class631_0.method_6();
        }
        else
        {
            this.class631_0 = null;
        }
    }

    private void method_6()
    {
        int num = 0x12;
        char ch = this.class631_0.method_7();
    Label_0012:
        switch (ch)
        {
            case '\t':
            case '\n':
            case '\r':
            case ' ':
                ch = this.class631_0.method_15();
                goto Label_0012;

            case '%':
            {
                Class631 class2 = this.method_14(BookmarkStart.b("ᠷ㜹㘻㜽", num));
                try
                {
                    this.method_4(this.class631_0.method_5(), class2);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message + this.class631_0.method_29());
                }
                ch = this.class631_0.method_7();
                goto Label_0012;
            }
            case '<':
                this.method_7();
                ch = this.class631_0.method_15();
                goto Label_0012;

            case 0xffff:
                this.method_5();
                if (this.class631_0 == null)
                {
                    return;
                }
                ch = this.class631_0.method_7();
                goto Label_0012;
        }
        this.class631_0.method_26(BookmarkStart.b("洷吹夻䘽〿❁❃㉅ⵇ⹉汋ⵍ㡏㍑♓㝕㭗⹙㥛ⱝ䁟䕡ὣ噥ᕧ䵩", num), ch);
        goto Label_0012;
    }

    private void method_7()
    {
        int num = 13;
        if (this.class631_0.method_15() != '!')
        {
            this.class631_0.method_25(BookmarkStart.b("甲娴䈶圸强ᴼᠾ㩀獂㡄恆效歊⽌㩎═獒ご⽖⥘㹚㹜㙞འѢ䕤ͦ౨ࡪŬ๮ͰቲŴṶᙸᕺ嵼౾꾎朗ﾖ릘벚ꆜ뺞蚠", num));
        }
        else
        {
            char ch = this.class631_0.method_15();
            switch (ch)
            {
                case '-':
                    ch = this.class631_0.method_15();
                    if (ch != '-')
                    {
                        this.class631_0.method_26(BookmarkStart.b("瘲䴴䜶尸堺䤼嘾⽀⑂敄⑆♈♊⁌⩎㽐❒畔灖敘穚灜牞䙠䍢ݤቦᵨ䭪୬nѰᵲᅴ坶ɸ䭺|", num), ch);
                    }
                    this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("瀲娴娶吸帺匼䬾", num), BookmarkStart.b("Ḳᠴश", num));
                    return;

                case '[':
                    this.method_10();
                    return;
            }
            string str2 = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("ጲ㠴㴶〸", num), true);
            string str = str2;
            if (str != null)
            {
                if (str == BookmarkStart.b("瘲笴挶瀸漺搼", num))
                {
                    this.method_17();
                    return;
                }
                if (str == BookmarkStart.b("瘲礴父琸縺猼款", num))
                {
                    this.method_18();
                    return;
                }
                if (str == BookmarkStart.b("爲愴挶甸爺渼款", num))
                {
                    this.method_23();
                    return;
                }
            }
            this.class631_0.method_28(BookmarkStart.b("稲嬴䄶堸场吼嬾慀❂⁄⑆╈⩊㽌⹎═㩒㩔㥖祘籚慜繞᩠卢ᡤ䁦䝨䭪䵬⩮॰Ͳၴᑶ൸ቺ፼᡾ꆀꒂ삄즆\udd88\uc28a\ud98c\ud68e뚐뾒떔낖\udc98\ud79a\ud89c\ud29e肦覨쒪\udfac\u8fae隰", num), str2);
        }
    }

    private char method_8()
    {
        char ch = this.class631_0.method_7();
        while (ch == '-')
        {
            ch = this.method_9(true);
        }
        return ch;
    }

    private char method_9(bool A_0)
    {
        int num = 5;
        char ch = this.class631_0.method_15();
        if (A_0 && (ch != '-'))
        {
            this.class631_0.method_26(BookmarkStart.b("渪唬弮吰倲䄴帶圸尺ᴼ尾⹀⹂⡄≆❈㽊浌⭎㑐㽒㱔㩖じ⽚㡜ⵞ䅠䑢䡤䩦乨䭪ཬᩮհ卲፴ᡶ౸ᕺ᥼彾婢뎂", num), ch);
        }
        this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("昪䰬崮娰䘲䔴᜶稸吺值刾⑀ⵂㅄ", num), BookmarkStart.b("ت,", num));
        return this.class631_0.method_19();
    }

    public static Class640 smethod_0(Uri A_0, string A_1, string A_2, string A_3, string A_4, string A_5, XmlNameTable A_6)
    {
        Class640 class2 = new Class640(A_1, A_6);
        if (!string.IsNullOrEmpty(A_3))
        {
            class2.method_4(A_0, new Class631(class2.method_0(), A_2, A_3, A_5));
        }
        if (!string.IsNullOrEmpty(A_4))
        {
            class2.method_4(A_0, new Class631(A_1, A_4));
        }
        try
        {
            class2.method_6();
        }
        catch (ApplicationException exception)
        {
            throw new Exception1(exception.Message + class2.class631_0.method_29());
        }
        return class2;
    }

    public static Class640 smethod_1(Uri A_0, string A_1, TextReader A_2, string A_3, string A_4, XmlNameTable A_5)
    {
        Class640 class2 = new Class640(A_1, A_5);
        class2.method_4(A_0, new Class631(class2.method_0(), A_0, A_2, A_4));
        if (!string.IsNullOrEmpty(A_3))
        {
            class2.method_4(A_0, new Class631(A_1, A_3));
        }
        try
        {
            class2.method_6();
        }
        catch (ApplicationException exception)
        {
            throw new Exception1(exception.Message + class2.class631_0.method_29());
        }
        return class2;
    }
}

