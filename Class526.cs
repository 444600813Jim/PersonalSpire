using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class526
{
    private readonly Class422 class422_0;
    private Class743 class743_0;

    internal Class526(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0(IRunAttrSource A_0, CharacterFormat A_1)
    {
        this.method_1(A_0, A_1, false);
    }

    internal void method_1(IRunAttrSource A_0, CharacterFormat A_1, bool A_2)
    {
        this.method_4(A_0, A_1, A_2);
        if (this.class743_0.int_0 > 0)
        {
            this.method_2(A_2);
        }
    }

    private string method_10(Emphasis A_0)
    {
        int num = 3;
        switch (A_0)
        {
            case Emphasis.Dot:
                return BookmarkStart.b("䴨䐪夬༮倰儲娴䄶尸", num);

            case Emphasis.CommaAbove:
                return BookmarkStart.b("䨨䐪䀬䈮倰", num);

            case Emphasis.CircleAbove:
                return BookmarkStart.b("䨨䈪弬䰮崰嘲ᔴ嘶嬸吺䬼娾", num);

            case Emphasis.DotBelow:
                return BookmarkStart.b("䴨䐪夬༮匰嘲头堶丸", num);
        }
        return BookmarkStart.b("䜨䐪䌬䨮", num);
    }

    internal void method_2(bool A_0)
    {
        int num = 0x12;
        Class400 class2 = this.class422_0.method_18();
        class2.method_4(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㹍≏㵑⑓㍕⩗⹙㕛㭝፟", 0x12));
        class2.method_40(BookmarkStart.b("帷唹ػ刽┿㙁ぃ⍅㩇杉㽋㹍ㅏㅑ㵓㡕㽗", 0x12), this.class743_0.string_40);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㵍㍏㍑㡓㍕", 0x12), this.class743_0.string_39);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態ⱍ㱏㭑㩓㵕ㅗ㑙㭛", 0x12), this.class743_0.string_38);
        class2.method_40(BookmarkStart.b("䰷弹䐻䨽稿♁ⵃ㕅㡇♉ⵋ㝍", 0x12), this.class743_0.string_37);
        class2.method_40(BookmarkStart.b("帷唹ػ䨽┿㩁ぃ歅㭇≉ⵋ⩍㽏║", 0x12), this.class743_0.string_35);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態㱍㕏㹑㵓㍕㹗", 0x12), this.class743_0.string_36);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態⅍╏♑㡓㽕㙗㽙", 0x12), this.class743_0.string_34);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ㅃ㕅ⵇ杉㭋❍㹏㙑㭓⅕畗㱙㍛そᑟ佡ݣ॥ѧթṫ", 0x12), this.class743_0.string_41);
        class2.method_40(BookmarkStart.b("帷唹ػ尽ℿ⅁⽃ⅅ㩇╉㥋⁍㑏网㝓㥕㑗㕙⹛", 0x12), this.class743_0.string_33);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㹍㽏⅑㵓≕ㅗ㕙㉛", 0x12), this.class743_0.string_32);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態≍㥏㱑ㅓ筕ⱗ㉙⹛ㅝᕟաౣ䭥ᱧ፩ᱫ୭", 0x12), this.class743_0.string_31);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態≍㥏㱑ㅓ筕ⱗ㉙⹛ㅝᕟաౣ䭥᭧ṩᕫɭᕯ", 0x12), this.class743_0.string_30);
        class2.method_40(BookmarkStart.b("帷唹ػ䨽┿㩁ぃ歅㱇㡉ⵋ⁍⍏㑑㭓⑕㕗", 0x12), this.class743_0.string_29);
        class2.method_40(BookmarkStart.b("帷唹ػ堽⼿ⱁぃ歅㹇⭉㹋❍ㅏ㱑⁓", 0x12), this.class743_0.string_28);
        class2.method_40(BookmarkStart.b("帷唹ػ堽⼿ⱁぃ歅㭇㹉㕋≍㕏", 0x12), this.class743_0.string_25);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態㵍⑏⭑㡓㍕畗㭙⽛㝝şౡ", 0x12), this.class743_0.string_26);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態㵍⑏⭑㡓㍕畗㥙㍛㍝ၟ๡ţṥ", 0x12), this.class743_0.string_27);
        class2.method_40(BookmarkStart.b("帷唹ػ崽⼿⹁⭃㑅", 0x12), this.class743_0.string_20);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態⁍ㅏ㽑ㅓ", 0x12), this.class743_0.string_0);
        if (this.class743_0.string_0 != null)
        {
            Form4 form = new Form4(this.class422_0.method_15(), this.class743_0.string_0);
            this.class422_0.method_107().method_11(form);
        }
        class2.method_40(BookmarkStart.b("帷唹ػ堽⼿ⱁぃ歅㭇⍉㙋⭍", num), this.class743_0.string_3);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態⁍ㅏ㽑ㅓ筕㥗⥙㕛㽝๟", num), this.class743_0.string_2);
        if (this.class743_0.string_2 != null)
        {
            Form4 form2 = new Form4(this.class422_0.method_15(), this.class743_0.string_2);
            this.class422_0.method_107().method_11(form2);
        }
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態㵍㥏⡑ㅓ筕㥗⥙㕛㽝๟", num), this.class743_0.string_5);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態⁍ㅏ㽑ㅓ筕㭗㕙ㅛ⹝౟ݡᱣ", num), this.class743_0.string_1);
        if (this.class743_0.string_1 != null)
        {
            Form4 form3 = new Form4(this.class422_0.method_15(), this.class743_0.string_1);
            this.class422_0.method_107().method_11(form3);
        }
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態㵍㥏⡑ㅓ筕㭗㕙ㅛ⹝౟ݡᱣ", num), this.class743_0.string_4);
        class2.method_40(BookmarkStart.b("帷唹ػ刽ℿⱁ⍃㍅⥇ⵉ⥋", num), this.class743_0.string_6);
        class2.method_40(BookmarkStart.b("帷唹ػ刽ℿⱁ⍃㍅⥇ⵉ⥋捍ㅏ⅑㵓㝕㙗", num), this.class743_0.string_7);
        class2.method_40(BookmarkStart.b("帷唹ػ刽ℿⱁ⍃㍅⥇ⵉ⥋捍㍏㵑㥓♕㑗㽙⑛", num), this.class743_0.string_8);
        class2.method_40(BookmarkStart.b("帷唹ػ崽⼿㝁⩃㉅㩇㍉", num), this.class743_0.string_12);
        class2.method_40(BookmarkStart.b("帷唹ػ崽⼿㝁⩃㉅㩇㍉態⽍⍏㭑㕓㡕", num), this.class743_0.string_13);
        class2.method_40(BookmarkStart.b("帷唹ػ崽⼿㝁⩃㉅㩇㍉態ⵍ㽏㽑⑓㩕㵗≙", num), this.class743_0.string_14);
        class2.method_40(BookmarkStart.b("帷唹ػ堽⼿ⱁぃ歅㽇⽉╋⥍㡏♑", num), this.class743_0.string_21);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態㥍㕏㭑㍓㹕ⱗ睙㵛ⵝय़͡੣", num), this.class743_0.string_22);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁≃⥅♇㹉態㥍㕏㭑㍓㹕ⱗ睙㽛ㅝൟቡࡣͥၧ", num), this.class743_0.string_23);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㱍㽏♑㕓≕ㅗ㕙㉛獝şౡͣ੥൧", num), this.class743_0.string_24);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㱍㽏♑㕓≕ㅗ㕙㉛獝፟šգ੥൧", num), this.class743_0.string_45);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁⡃⍅㱇㹉⥋㱍絏㥑ㅓ⑕㙗㍙㉛㥝", num), this.class743_0.string_46);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態⭍㵏≑㱓㝕⭗㍙♛㭝", num), this.class743_0.string_47);
        class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㭍㹏㙑ㅓ⑕㑗㍙㉛㭝䵟ᅡၣὥѧཀྵ", num), this.class743_0.string_15);
        if ((this.class743_0.string_15 != BookmarkStart.b("嘷唹刻嬽", num)) && (this.class743_0.string_15 != null))
        {
            class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㭍㹏㙑ㅓ⑕㑗㍙㉛㭝䵟ᙡᵣᙥ൧", num), this.class743_0.string_16);
            class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㭍㹏㙑ㅓ⑕㑗㍙㉛㭝䵟ᕡൣɥᱧɩ", num), this.class743_0.string_18);
            class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㭍㹏㙑ㅓ⑕㑗㍙㉛㭝䵟ཡୣɥ൧", num), this.class743_0.string_17);
            if (!(this.class743_0.string_20 == this.class743_0.string_19) && (this.class743_0.string_19 != null))
            {
                class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㭍㹏㙑ㅓ⑕㑗㍙㉛㭝䵟šୣ੥ݧᡩ", num), this.class743_0.string_19);
            }
            else
            {
                class2.method_40(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㭍㹏㙑ㅓ⑕㑗㍙㉛㭝䵟šୣ੥ݧᡩ", num), BookmarkStart.b("帷唹刻䨽洿⅁⭃⩅❇㡉", num));
            }
        }
        if (A_0)
        {
            if (this.class422_0.method_15().Settings.bool_27)
            {
                class2.vmethod_1(BookmarkStart.b("帷唹ػ嘽㤿㉁ⱃ⍅♇⭉㡋⭍", num), this.class422_0.method_15().Settings.bool_27);
            }
        }
        else
        {
            class2.method_40(BookmarkStart.b("帷唹ػ嘽㤿㉁ⱃ⍅♇⭉㡋⭍", num), this.class743_0.string_42);
        }
        class2.method_40(BookmarkStart.b("帷唹ػ嘽㤿㉁ⱃ⍅♇⭉㡋❍㽏㱑祓⑕㵗㝙㵛㝝๟佡ݣ๥१ᡩ䅫൭Ὧݱᩳɵ", num), this.class743_0.string_43);
        class2.method_40(BookmarkStart.b("帷唹ػ嘽㤿㉁ⱃ⍅♇⭉㡋❍㽏㱑祓♕ⵗ⥙㑛獝͟੡գᑥ䕧३ͫ᭭ṯٱ", num), this.class743_0.string_44);
        class2.method_6(BookmarkStart.b("䬷丹䔻刽┿硁ぃ⍅ぇ㹉態㹍≏㵑⑓㍕⩗⹙㕛㭝፟", num));
    }

    internal bool method_3(IRunAttrSource A_0, CharacterFormat A_1)
    {
        return this.method_4(A_0, A_1, false);
    }

    private bool method_4(IRunAttrSource A_0, AttrCollection A_1, bool A_2)
    {
        this.class743_0 = new Class743();
        this.method_5(A_0, A_1, A_2);
        if (this.class743_0.class580_0 != null)
        {
            this.method_5(A_0, this.class743_0.class580_0.method_4(), A_2);
        }
        return (this.class743_0.int_0 > 0);
    }

    private void method_5(IRunAttrSource A_0, AttrCollection A_1, bool A_2)
    {
        bool flag;
        int num = 13;
        Paragraph paragraph2 = (flag = (A_0 != null) && (A_0 is Paragraph)) ? ((Paragraph) A_0) : null;
        AttrCollection attrs = this.method_6(A_0, A_1, A_2);
        for (int i = 0; i < attrs.Count; i++)
        {
            int num2 = attrs.method_18(i);
            object obj2 = attrs.method_19(i);
            if (obj2 == null)
            {
                continue;
            }
            this.class743_0.int_0++;
            int num3 = num2;
            if (num3 <= 210)
            {
                if (num3 <= 120)
                {
                    if (num3 <= 80)
                    {
                        if (num3 <= 60)
                        {
                            if (num3 != 20)
                            {
                                if (num3 != 60)
                                {
                                    goto Label_085E;
                                }
                                this.class743_0.string_21 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("儲娴嬶崸", num), BookmarkStart.b("崲娴䔶吸娺儼", num));
                            }
                            else
                            {
                                this.class743_0.string_33 = Class576.smethod_74((Color) obj2, false);
                            }
                        }
                        else if (num3 != 70)
                        {
                            if (num3 != 80)
                            {
                                goto Label_085E;
                            }
                            this.class743_0.string_30 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("䀲娴嬶倸强", num), null);
                            if (this.class743_0.string_30 == null)
                            {
                                this.class743_0.string_30 = BookmarkStart.b("崲娴夶尸", num);
                            }
                        }
                        else
                        {
                            this.class743_0.string_25 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("娲䄴嘶唸刺帼", num), BookmarkStart.b("崲娴䔶吸娺儼", num));
                        }
                    }
                    else if (num3 <= 100)
                    {
                        if (num3 != 90)
                        {
                            if (num3 != 100)
                            {
                                goto Label_085E;
                            }
                            this.class743_0.string_35 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("Ȳ䔴䌶ᤸ਺䴼䬾", num), null);
                        }
                        else
                        {
                            this.class743_0.string_34 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("䜲䜴䈶尸", num), null);
                        }
                    }
                    else if (num3 != 110)
                    {
                        if (num3 != 120)
                        {
                            goto Label_085E;
                        }
                        this.class743_0.string_29 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("䘲䔴䜶尸䤺帼帾㉀♂", num), null);
                    }
                    else
                    {
                        this.class743_0.string_28 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("䀲場嘶唸场ြ尾⁀㍂㙄", num), null);
                    }
                }
                else if (num3 <= 160)
                {
                    if (num3 <= 140)
                    {
                        if (num3 != 130)
                        {
                            if (num3 != 140)
                            {
                                goto Label_085E;
                            }
                            UnderlineStyle style = (UnderlineStyle) obj2;
                            this.class743_0.string_15 = Class922.smethod_67(style);
                            this.class743_0.string_18 = Class922.smethod_66(style);
                            switch (style)
                            {
                                case UnderlineStyle.Double:
                                case UnderlineStyle.WavyDouble:
                                    this.class743_0.string_16 = BookmarkStart.b("圲娴䈶嬸场堼", num);
                                    break;
                            }
                            if (style == UnderlineStyle.Words)
                            {
                                this.class743_0.string_17 = BookmarkStart.b("䀲帴帶䤸ᘺ䨼圾⡀㝂⁄橆㩈㭊ⱌⱎ㑐", num);
                            }
                        }
                        else
                        {
                            this.class743_0.string_37 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("崲娴夶尸", num), BookmarkStart.b("䜲䜴䈶尸", num));
                        }
                    }
                    else if (num3 != 150)
                    {
                        if (num3 != 160)
                        {
                            goto Label_085E;
                        }
                        this.class743_0.string_20 = Class576.smethod_75((Color) obj2);
                    }
                    else
                    {
                        this.class743_0.string_40 = Class576.smethod_35(obj2);
                    }
                }
                else if (num3 <= 180)
                {
                    if (num3 != 170)
                    {
                        if (num3 != 180)
                        {
                            goto Label_085E;
                        }
                        this.class743_0.string_36 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("嘲嬴倶䬸娺䬼娾╀", num), null);
                    }
                    else
                    {
                        this.class743_0.string_36 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("嘲場唶嘸䠺丼娾╀", num), null);
                    }
                }
                else
                {
                    switch (num3)
                    {
                        case 190:
                        {
                            this.class743_0.string_3 = Class576.smethod_65(obj2);
                            continue;
                        }
                        case 200:
                        {
                            this.class743_0.string_32 = Class576.smethod_71(obj2, ((CharacterFormat) attrs).FontSize);
                            continue;
                        }
                    }
                    if (num3 != 210)
                    {
                        goto Label_085E;
                    }
                    this.class743_0.string_32 = Class922.smethod_74((SubSuperScript) obj2);
                }
                continue;
            }
            if (num3 <= 310)
            {
                if (num3 <= 250)
                {
                    if (num3 <= 230)
                    {
                        if (num3 != 220)
                        {
                            if (num3 != 230)
                            {
                                goto Label_085E;
                            }
                            this.class743_0.string_0 = (string) obj2;
                        }
                        else
                        {
                            this.class743_0.string_46 = BookmarkStart.b("䜲䜴䈶尸", num);
                            if (((float) obj2) == 0f)
                            {
                                this.class743_0.string_46 = BookmarkStart.b("唲吴嬶䨸帺", num);
                            }
                        }
                    }
                    else if (num3 != 0xeb)
                    {
                        if (num3 != 250)
                        {
                            goto Label_085E;
                        }
                        this.class743_0.string_23 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("儲娴嬶崸", num), BookmarkStart.b("崲娴䔶吸娺儼", num));
                    }
                    else
                    {
                        this.class743_0.string_2 = (string) obj2;
                    }
                }
                else if (num3 <= 270)
                {
                    if (num3 != 260)
                    {
                        if (num3 != 270)
                        {
                            goto Label_085E;
                        }
                        this.class743_0.string_1 = (string) obj2;
                    }
                    else
                    {
                        this.class743_0.string_27 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("娲䄴嘶唸刺帼", num), BookmarkStart.b("崲娴䔶吸娺儼", num));
                    }
                }
                else
                {
                    switch (num3)
                    {
                        case 290:
                        {
                            this.class743_0.string_39 = string.Format(BookmarkStart.b("䠲Դ䨶᰸", num), (short) obj2);
                            continue;
                        }
                        case 300:
                        {
                            this.class743_0.string_31 = this.method_9(attrs as CharacterFormat, num2, BookmarkStart.b("圲娴䈶嬸场堼", num), null);
                            if (this.class743_0.string_30 == null)
                            {
                                this.class743_0.string_30 = BookmarkStart.b("崲娴夶尸", num);
                            }
                            continue;
                        }
                    }
                    if (num3 != 310)
                    {
                        goto Label_085E;
                    }
                    if (((TextEffect) obj2) == TextEffect.None)
                    {
                        this.class743_0.int_0--;
                    }
                    else
                    {
                        this.class743_0.string_38 = BookmarkStart.b("䜲䜴䈶尸", num);
                    }
                }
                continue;
            }
            if (num3 <= 380)
            {
                if (num3 <= 350)
                {
                    if (num3 != 340)
                    {
                        if (num3 != 350)
                        {
                            goto Label_085E;
                        }
                        this.class743_0.string_5 = Class576.smethod_65(((CharacterFormat) attrs).FontSize);
                        this.class743_0.string_4 = Class576.smethod_65(obj2);
                    }
                    else
                    {
                        this.class743_0.string_11 = Class922.smethod_80(int.Parse(obj2.ToString()));
                        if (this.class743_0.string_11 == BookmarkStart.b("崲娴夶尸", num))
                        {
                            this.class743_0.int_0--;
                        }
                    }
                }
                else if (num3 != 370)
                {
                    if (num3 != 380)
                    {
                        goto Label_085E;
                    }
                    this.class743_0.string_9 = Class922.smethod_80((short) obj2);
                    if (this.class743_0.string_9 == BookmarkStart.b("崲娴夶尸", num))
                    {
                        this.class743_0.int_0--;
                    }
                }
                else
                {
                    this.class743_0.string_33 = Class576.smethod_83((Class16) obj2);
                }
                continue;
            }
            if (num3 <= 450)
            {
                if (num3 != 390)
                {
                    if (num3 != 450)
                    {
                        goto Label_085E;
                    }
                    this.class743_0.string_19 = Class576.smethod_74((Color) obj2, false);
                }
                else
                {
                    this.class743_0.string_10 = Class922.smethod_80((short) obj2);
                    if (this.class743_0.string_10 == BookmarkStart.b("崲娴夶尸", num))
                    {
                        this.class743_0.int_0--;
                    }
                }
                continue;
            }
            switch (num3)
            {
                case 770:
                {
                    this.class743_0.string_47 = this.method_10((Emphasis) obj2);
                    continue;
                }
                case 780:
                {
                    Class340 class2 = (Class340) obj2;
                    if (class2.method_6())
                    {
                        this.class743_0.string_45 = BookmarkStart.b("弲尴夶尸ᘺ唼娾⡀⑂ⵄ㍆", num);
                    }
                    if (class2.method_0())
                    {
                        this.class743_0.string_24 = BookmarkStart.b("ਲԴ", num);
                    }
                    continue;
                }
                case 0x271a:
                {
                    this.class743_0.class580_0 = (Class580) obj2;
                    continue;
                }
            }
        Label_085E:
            this.class743_0.int_0--;
        }
        this.class743_0.string_6 = Class922.smethod_82(this.class743_0.string_9);
        this.class743_0.string_12 = Class922.smethod_83(this.class743_0.string_9);
        this.class743_0.string_7 = Class922.smethod_82(this.class743_0.string_10);
        this.class743_0.string_13 = Class922.smethod_83(this.class743_0.string_10);
        this.class743_0.string_8 = Class922.smethod_82(this.class743_0.string_11);
        this.class743_0.string_14 = Class922.smethod_83(this.class743_0.string_11);
        if (!flag && (A_0 is DocumentObject))
        {
            DocumentObject obj4 = (DocumentObject) A_0;
            if (obj4.ParentObject is Paragraph)
            {
                Paragraph parentObject = (Paragraph) obj4.ParentObject;
                object obj5 = null;
                if (parentObject.IsInCell || (parentObject.IsInCell && (((TableCell) parentObject.OwnerTextBody).Paragraphs[0] == parentObject)))
                {
                    obj5 = ((TableCell) parentObject.OwnerTextBody).CellFormat.method_31(0xbea);
                }
                if (obj5 != null)
                {
                    this.class743_0.string_24 = Class922.smethod_69((TextOrientation) obj5);
                    if (this.class743_0.string_24 != null)
                    {
                        this.class743_0.int_0++;
                    }
                }
            }
        }
        if (paragraph2 != null)
        {
            object obj3 = paragraph2.Format.method_31(0x582);
            if ((obj3 != null) && ((bool) obj3))
            {
                this.class743_0.string_42 = BookmarkStart.b("唲吴嬶䨸帺", num);
                this.class743_0.string_43 = BookmarkStart.b("Ĳ", num);
                this.class743_0.string_44 = BookmarkStart.b("Ĳ", num);
                this.class743_0.int_0++;
            }
            else if (!((bool) obj3))
            {
                this.class743_0.string_42 = BookmarkStart.b("䜲䜴䈶尸", num);
                this.class743_0.int_0++;
            }
        }
        if (A_2)
        {
            this.class743_0.string_41 = BookmarkStart.b("䜲䜴䈶尸", num);
            this.class743_0.int_0++;
        }
    }

    private AttrCollection method_6(IRunAttrSource A_0, AttrCollection A_1, bool A_2)
    {
        AttrCollection attrs = A_1;
        if (Class422.smethod_0(A_0, A_2))
        {
            attrs = new CharacterFormat(this.class422_0.method_15());
            for (int i = attrs.Count - 1; i >= 0; i--)
            {
                if (smethod_0(attrs.method_18(i)))
                {
                    attrs.method_11(i);
                }
            }
            A_1.method_37(attrs);
        }
        return attrs;
    }

    private void method_7(IRunAttrSource A_0)
    {
        if (Class422.smethod_0(A_0, false))
        {
            this.class743_0.string_3 = this.method_8(this.class743_0.string_3);
            this.class743_0.string_5 = this.method_8(this.class743_0.string_5);
            this.class743_0.string_4 = this.class743_0.string_5;
        }
    }

    private string method_8(string A_0)
    {
        int num = 6;
        if (Class567.smethod_16(A_0))
        {
            return A_0;
        }
        this.class743_0.int_0++;
        return BookmarkStart.b("ᴫḭ䀯䘱", num);
    }

    public string method_9(CharacterFormat A_0, int A_1, string A_2, string A_3)
    {
        if (!A_0.method_62((short) A_1))
        {
            return A_3;
        }
        return A_2;
    }

    private static bool smethod_0(int A_0)
    {
        if ((((A_0 != 230) && (A_0 != 0xeb)) && ((A_0 != 240) && (A_0 != 270))) && ((A_0 != 380) && (A_0 != 390)))
        {
            return (A_0 == 340);
        }
        return true;
    }
}

