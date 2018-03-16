using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;

internal class Class919
{
    private bool bool_0;
    private bool bool_1;
    private readonly Class422 class422_0;
    private Class972 class972_0;

    internal Class919(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.bool_1 = false;
        this.bool_0 = false;
    }

    internal void method_0(Interface46 A_0, AttrCollection A_1)
    {
        this.method_1(A_0, A_1, false);
    }

    internal void method_1(Interface46 A_0, AttrCollection A_1, bool A_2)
    {
        bool flag2;
        int num = 14;
        Class400 class2 = this.class422_0.method_18();
        this.class972_0 = new Class972();
        this.method_5(A_0, A_1, A_2);
        if (this.class972_0.class580_0 != null)
        {
            this.method_5(A_0, this.class972_0.class580_0.method_4(), A_2);
        }
        bool flag = (this.class422_0.method_15().Settings.bool_67 && (A_0 is Style)) && ((A_0 as Style).StyleIdentifier == StyleIdentifier.Normal);
        if (flag2 = ((((this.class972_0.int_0 > 0) || this.method_14()) || (this.method_12() || this.class972_0.bool_2)) || flag) || A_2)
        {
            class2.method_4(BookmarkStart.b("䜳䈵䄷嘹夻н〿⍁㙃❅⽇㡉ⵋ㹍㡏网⑓⑕㝗⩙㥛ⱝᑟୡţᕥ", num));
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н㐿❁㱃㉅敇⭉㥋㩍㽏⅑⑓㝕㭗㽙", num), this.class972_0.string_14);
            class2.method_40(BookmarkStart.b("刳夵ȷ丹夻䘽㐿潁╃⩅ⅇⵉ≋", num), this.class972_0.string_2);
            class2.method_40(BookmarkStart.b("刳夵ȷ丹夻䘽㐿潁╃⩅ⅇⵉ≋捍㱏㍑❓≕", num), this.class972_0.string_3);
            object obj2 = (A_0 is Paragraph) ? this.class422_0.method_16().SectPr.method_31(0x92e) : null;
            bool flag3 = (obj2 != null) && (((int) obj2) > 0);
            if (!this.method_14() && (!this.method_12() || flag3))
            {
                if ((this.method_12() && flag3) && (this.class972_0.string_0 == null))
                {
                    this.class972_0.string_0 = BookmarkStart.b("圳夵吷伹儻倽", num);
                }
            }
            else
            {
                this.class972_0.string_0 = BookmarkStart.b("䐳圵強弹", num);
            }
            class2.method_40(BookmarkStart.b("刳夵ȷ堹主嬽ℿ⥁楃⑅ⵇⱉ⍋㱍㕏", num), this.class972_0.string_0);
            class2.method_40(BookmarkStart.b("刳夵ȷ堹崻崽⬿╁㙃⥅㵇⑉⡋捍㍏㵑㡓㥕⩗", num), this.class972_0.string_1);
            class2.method_40(BookmarkStart.b("刳夵ȷ丹夻䘽㐿潁ⵃ⡅ⱇ⽉≋㩍", num), this.class972_0.string_6);
            if (this.class972_0.lineSpacingRule_0 == LineSpacingRule.AtLeast)
            {
                class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻нⰿ⭁⩃⍅敇≉⥋❍㝏㩑⁓筕㥗⹙煛㉝՟͡ᝣብ", num), this.class972_0.string_7);
            }
            else
            {
                class2.method_40(BookmarkStart.b("刳夵ȷ嘹唻倽┿潁ⱃ⍅ⅇⵉ⑋㩍", num), this.class972_0.string_7);
            }
            this.class972_0.class1048_0.method_0(class2);
            class2.method_40(BookmarkStart.b("刳夵ȷ儹夻嬽〿潁㍃⽅㱇≉態⁍㕏⩑⁓", num), this.class972_0.string_8);
            class2.method_40(BookmarkStart.b("刳夵ȷ儹夻嬽〿潁ぃ⥅⽇⽉㡋♍㕏⁑", num), this.class972_0.string_9);
            if (this.class972_0.bool_2 && flag)
            {
                class2.method_40(BookmarkStart.b("刳夵ȷ唹主丽⠿⍁⩃㕅", num), BookmarkStart.b("س", num));
                class2.method_40(BookmarkStart.b("刳夵ȷ䴹唻娽⼿㕁㝃", num), BookmarkStart.b("س", num));
            }
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н㜿ぁⵃ㉅ⅇ⑉⭋捍㵏㵑こ㍕", num), this.class972_0.string_10);
            class2.method_40(BookmarkStart.b("䀳匵䀷丹ػ倽㔿⽁♃⍅㩇杉⁋❍㹏㝑❓", num), this.class972_0.string_11);
            class2.method_40(BookmarkStart.b("䀳匵䀷丹ػ刽⤿ⱁ⅃歅♇㽉⅋ⱍ㕏⁑", num), this.class972_0.string_12);
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н㌿ⱁ╃㙅敇㹉⍋捍㱏㍑ⵓ㥕ⵗ⹙煛㥝቟ୡc", num), this.class972_0.string_13);
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н〿㝁⩃╅㱇㽉ⵋ㩍㥏㵑㩓筕⽗⡙㵛⹝", num), this.class972_0.string_15);
            class2.method_40(BookmarkStart.b("刳夵ȷ刹䔻丽⠿❁⩃❅㱇⍉⍋⁍絏㹑㕓㉕㱗㽙⹛獝͟ൡᅣࡥᱧ", num), this.class972_0.string_16);
            class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н㘿❁㙃㉅ⅇ⥉ⵋ≍絏㍑㡓㽕㽗㑙", num), this.class972_0.string_17);
            if ((A_2 && (this.class422_0.method_15().Settings.float_0 != 0f)) && (this.class422_0.method_15().Settings.float_0 != 1134f))
            {
                class2.method_40(BookmarkStart.b("䜳䈵䄷嘹夻н㐿⍁♃歅㭇㹉⍋㹍絏㙑㵓╕ⱗ㭙㉛㵝՟", num), Class576.smethod_42((double) (this.class422_0.method_15().Settings.float_0 / 20f)));
            }
            if ((((this.class422_0.method_33() == 1) && (this.class422_0.method_16().PreviousSibling == null)) || this.class422_0.method_75()) && this.class422_0.method_16().SectPr.method_60())
            {
                this.class422_0.method_16().SectPr.method_86();
                class2.method_43(BookmarkStart.b("䜳䈵䄷嘹夻н〿⍁⍃⍅敇⑉㥋⍍㉏㝑♓", num), this.class422_0.method_16().SectPr.method_86());
            }
        }
        if (this.method_2(A_0, this.method_3(A_0, flag2) || flag2))
        {
            class2.method_6(BookmarkStart.b("䜳䈵䄷嘹夻н〿⍁㙃❅⽇㡉ⵋ㹍㡏网⑓⑕㝗⩙㥛ⱝᑟୡţᕥ", num));
        }
    }

    private void method_10(Interface46 A_0)
    {
        if (Class567.smethod_16(this.class972_0.string_2))
        {
        }
    }

    private AttrCollection method_11(Interface46 A_0, AttrCollection A_1, bool A_2)
    {
        AttrCollection attrs = A_1;
        if (Class422.smethod_0(A_0, A_2))
        {
            attrs = new CharacterFormat();
            A_1.method_37(attrs);
        }
        return attrs;
    }

    internal bool method_12()
    {
        return this.bool_0;
    }

    internal void method_13(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal bool method_14()
    {
        return this.bool_1;
    }

    internal void method_15(bool A_0)
    {
        this.bool_1 = A_0;
    }

    private bool method_2(Interface46 A_0, bool A_1)
    {
        int num = 1;
        if ((this.class972_0.string_4 == null) && (this.class972_0.string_5 == null))
        {
            return A_1;
        }
        if (!A_1)
        {
            this.class422_0.method_18().method_4(BookmarkStart.b("否崨刪䄬䨮ର䌲吴䔶堸尺似帾ㅀ⭂桄㝆㭈⑊㵌⩎⍐❒㱔㉖⩘", num));
        }
        string str = null;
        if (A_0 is Paragraph)
        {
            int num2 = 0;
            foreach (TextRange range in (A_0 as Paragraph).ChildObjects)
            {
                num2 += range.Text.Length;
            }
            str = ((num2 > 0) ? num2 : 1).ToString();
        }
        this.class422_0.method_18().method_33(BookmarkStart.b("否崨刪䄬䨮ର圲䜴堶䤸ᘺ帼帾ㅀ", num), new object[] { BookmarkStart.b("否崨刪䄬䨮ର弲尴夶尸䠺", num), (this.class972_0.string_4 != null) ? this.class972_0.string_4 : BookmarkStart.b("ᘦ", num), BookmarkStart.b("否崨刪䄬䨮ର圲尴䐶䴸娺匼尾⑀", num), this.class972_0.string_5, BookmarkStart.b("否崨刪䄬䨮ର弲倴夶常伺唼", num), str });
        return true;
    }

    private bool method_3(Interface46 A_0, bool A_1)
    {
        int num = 15;
        Paragraph paragraph = (A_0 is Paragraph) ? ((Paragraph) A_0) : null;
        TabCollection tabs2 = this.class972_0.tabCollection_0;
        if ((tabs2 != null) && (tabs2.Count != 0))
        {
            Class400 class2 = this.class422_0.method_18();
            bool flag = true;
            TabCollection tabs = null;
            if ((paragraph != null) && (paragraph.ParaStyle != null))
            {
                tabs = paragraph.ParaStyle.ParaPr.Tabs;
            }
            int num3 = 0;
            for (int i = 0; i < tabs2.Count; i++)
            {
                Tab tab2 = tabs2[i];
                if (tabs != null)
                {
                    while (num3 < tabs.Count)
                    {
                        Tab tab = tabs[num3];
                        int position = (int) tab.Position;
                        int num5 = (int) tab2.Position;
                        if (position > num5)
                        {
                            break;
                        }
                        if (position < num5)
                        {
                            flag = this.method_4(tab, flag, A_1);
                        }
                        num3++;
                    }
                }
                flag = this.method_4(tab2, flag, A_1);
            }
            if (tabs != null)
            {
                while (num3 < tabs.Count)
                {
                    flag = this.method_4(tabs[num3++], flag, A_1);
                }
            }
            if (!flag)
            {
                class2.method_6(BookmarkStart.b("䘴䌶䀸场堼Ծ㕀≂❄橆㩈㽊≌㽎≐", num));
                return true;
            }
        }
        return false;
    }

    private bool method_4(Tab A_0, bool A_1, bool A_2)
    {
        int num = 2;
        if (Class922.smethod_60(A_0.Justification) == null)
        {
            return A_1;
        }
        Class400 class2 = this.class422_0.method_18();
        if (A_1)
        {
            if (!A_2)
            {
                class2.method_4(BookmarkStart.b("嬧帩唫䈭唯࠱䐳圵䨷嬹嬻䰽ℿ㉁ⱃ歅㡇㡉⍋㹍㕏⁑⁓㽕㵗⥙", num));
            }
            class2.method_4(BookmarkStart.b("嬧帩唫䈭唯࠱䀳圵娷᜹伻䨽⼿㉁㝃", num));
        }
        class2.method_33(BookmarkStart.b("嬧帩唫䈭唯࠱䀳圵娷᜹伻䨽⼿㉁", num), new object[] { BookmarkStart.b("嬧帩唫䈭唯࠱䀳伵䠷弹", num), Class922.smethod_60(A_0.Justification), BookmarkStart.b("嬧帩唫䈭唯࠱堳匵夷帹夻䰽洿ㅁぃ㽅⑇⽉", num), Class922.smethod_64(A_0.TabLeader), BookmarkStart.b("嬧帩唫䈭唯࠱堳匵夷帹夻䰽洿㙁⅃㹅㱇", num), Class922.smethod_63(A_0.TabLeader), BookmarkStart.b("嬧帩唫䈭唯࠱圳帵夷䠹", num), (A_0.Justification == TabJustification.Decimal) ? BookmarkStart.b("Ч", num) : null, BookmarkStart.b("嬧帩唫䈭唯࠱䐳夵䬷匹䠻圽⼿ⱁ", num), Class576.smethod_35(A_0.Position - this.class972_0.int_1) });
        return false;
    }

    private void method_5(Interface46 A_0, AttrCollection A_1, bool A_2)
    {
        int num = 7;
        AttrCollection attrs = this.method_11(A_0, A_1, A_2);
        this.class972_0.class1048_0.bool_0 = false;
        ParagraphFormat paraPr = null;
        if (A_0 is Paragraph)
        {
            paraPr = (A_0 as Paragraph).Format;
        }
        else if (A_0 is Style)
        {
            paraPr = (A_0 as Style).ParaPr;
        }
        if (A_2)
        {
            this.class972_0.string_14 = BookmarkStart.b("䐬䬮吰尲刴䔶堸䬺唼ሾ⁀⽂㕄⽆⡈", num);
            this.class972_0.string_15 = BookmarkStart.b("䔬丮弰吲尴夶常", num);
        }
        HorizontalAlignment left = HorizontalAlignment.Left;
        bool flag = false;
        for (int i = 0; i < attrs.Count; i++)
        {
            int num3;
            int num5 = attrs.method_18(i);
            object obj2 = attrs.method_19(i);
            if (obj2 != null)
            {
                this.class972_0.int_0++;
                num3 = num5;
                if (num3 <= 0x4ba)
                {
                    if (num3 <= 0x442)
                    {
                        if (num3 <= 0x410)
                        {
                            switch (num3)
                            {
                                case 20:
                                {
                                    Borders borders = obj2 as Borders;
                                    if (!borders.Left.IsDefault)
                                    {
                                        this.class972_0.class1048_0.class411_2.border_0 = borders.Left;
                                    }
                                    if (!borders.Right.IsDefault)
                                    {
                                        this.class972_0.class1048_0.class411_3.border_0 = borders.Right;
                                    }
                                    if (!borders.Top.IsDefault)
                                    {
                                        this.class972_0.class1048_0.class411_0.border_0 = borders.Top;
                                    }
                                    if (!borders.Bottom.IsDefault)
                                    {
                                        this.class972_0.class1048_0.class411_1.border_0 = borders.Bottom;
                                    }
                                    if (borders.IsDefault || (borders == null))
                                    {
                                        this.class972_0.int_0--;
                                    }
                                    continue;
                                }
                                case 0x3fc:
                                {
                                    flag = true;
                                    left = (HorizontalAlignment) obj2;
                                    continue;
                                }
                            }
                            if (num3 != 0x410)
                            {
                                goto Label_09CD;
                            }
                            if ((bool) obj2)
                            {
                                this.class972_0.string_9 = BookmarkStart.b("䰬䌮䘰刲䰴䐶", num);
                            }
                            else
                            {
                                this.class972_0.int_0--;
                            }
                        }
                        else
                        {
                            switch (num3)
                            {
                                case 0x41a:
                                {
                                    if ((bool) obj2)
                                    {
                                        this.class972_0.string_8 = BookmarkStart.b("䰬䌮䘰刲䰴䐶", num);
                                    }
                                    else
                                    {
                                        this.class972_0.int_0--;
                                    }
                                    continue;
                                }
                                case 0x424:
                                {
                                    this.class972_0.string_0 = ((bool) obj2) ? BookmarkStart.b("崬丮嘰嘲", num) : BookmarkStart.b("䰬娮䔰尲", num);
                                    continue;
                                }
                            }
                            if (num3 != 0x442)
                            {
                                goto Label_09CD;
                            }
                            if (!((bool) obj2))
                            {
                                this.class972_0.string_15 = BookmarkStart.b("帬䘮尰䌲头制", num);
                            }
                            else
                            {
                                this.class972_0.int_0--;
                            }
                        }
                    }
                    else if (num3 <= 0x47e)
                    {
                        switch (num3)
                        {
                            case 0x46a:
                            {
                                if (!((bool) obj2))
                                {
                                    this.class972_0.string_11 = BookmarkStart.b("夬崮䐰嘲", num);
                                }
                                else
                                {
                                    this.class972_0.int_0--;
                                }
                                continue;
                            }
                            case 0x474:
                            {
                                if ((obj2 != null) && (((TabCollection) obj2).Count != 0))
                                {
                                    this.class972_0.tabCollection_0 = (TabCollection) obj2;
                                }
                                this.class972_0.int_0--;
                                continue;
                            }
                        }
                        if (num3 != 0x47e)
                        {
                            goto Label_09CD;
                        }
                        if (((A_0 is Paragraph) && ((Paragraph) A_0).IsList) && (((Paragraph) A_0).ListFormat.method_31(0x47e) != null))
                        {
                            this.class972_0.int_0--;
                        }
                        else
                        {
                            this.class972_0.class1048_0.class411_3.string_3 = Class576.smethod_42((double) ((float) obj2));
                            this.method_7(A_0);
                        }
                    }
                    else if (num3 <= 0x492)
                    {
                        if (num3 == 0x488)
                        {
                            if (((A_0 is Paragraph) && ((Paragraph) A_0).IsList) && (((Paragraph) A_0).ListFormat.method_31(0x488) != null))
                            {
                                this.class972_0.int_0--;
                            }
                            else
                            {
                                this.class972_0.class1048_0.class411_2.string_3 = Class576.smethod_42((double) ((float) obj2));
                                this.method_7(A_0);
                            }
                            this.class972_0.int_1 = (int) ((float) obj2);
                        }
                        else
                        {
                            if (num3 != 0x492)
                            {
                                goto Label_09CD;
                            }
                            if ((A_0 is Paragraph) && (((float) obj2) < 0f))
                            {
                                if ((A_0 is Paragraph) && !(A_0 as Paragraph).IsList)
                                {
                                    this.class972_0.string_6 = Class576.smethod_42((double) ((float) obj2));
                                }
                                else
                                {
                                    this.class972_0.int_0--;
                                }
                            }
                            else
                            {
                                this.class972_0.string_6 = Class576.smethod_42((double) ((float) obj2));
                            }
                        }
                    }
                    else if (num3 != 0x4b0)
                    {
                        if (num3 != 0x4ba)
                        {
                            goto Label_09CD;
                        }
                        this.class972_0.bool_0 = (bool) obj2;
                        this.class972_0.int_0--;
                    }
                    else
                    {
                        this.class972_0.class1048_0.class411_0.string_3 = Class576.smethod_42((double) ((float) obj2));
                    }
                }
                else
                {
                    if (num3 > 0x5aa)
                    {
                        goto Label_0837;
                    }
                    if (num3 > 0x4d8)
                    {
                        goto Label_073E;
                    }
                    switch (num3)
                    {
                        case 0x4c4:
                        {
                            if (!(A_0 is Paragraph))
                            {
                                goto Label_0717;
                            }
                            Paragraph paragraph = (Paragraph) A_0;
                            if ((paragraph.NextSibling == null) || !(paragraph.NextSibling is Paragraph))
                            {
                                goto Label_06E9;
                            }
                            Paragraph nextSibling = (Paragraph) paragraph.NextSibling;
                            object obj3 = nextSibling.Format.method_31(0x4b0);
                            if ((obj3 != null) && nextSibling.Format.BeforeAutoSpacing)
                            {
                                obj3 = 280f;
                            }
                            if ((obj3 != null) && (((float) obj3) > ((float) obj2)))
                            {
                                this.class972_0.int_0--;
                            }
                            else
                            {
                                this.class972_0.class1048_0.class411_1.string_3 = Class576.smethod_42((double) ((float) obj2));
                                this.method_7(A_0);
                            }
                            continue;
                        }
                        case 0x4ce:
                        {
                            this.class972_0.bool_1 = (bool) obj2;
                            this.class972_0.int_0--;
                            continue;
                        }
                    }
                    if (num3 != 0x4d8)
                    {
                        goto Label_09CD;
                    }
                    this.class972_0.string_14 = ((bool) obj2) ? BookmarkStart.b("䐬䬮吰尲刴䔶堸䬺唼ሾ⁀⽂㕄⽆⡈", num) : BookmarkStart.b("䌬䀮弰嘲", num);
                }
            }
            continue;
        Label_06E9:
            this.class972_0.class1048_0.class411_1.string_3 = Class576.smethod_42((double) ((float) obj2));
            this.method_7(A_0);
            continue;
        Label_0717:
            this.class972_0.class1048_0.class411_1.string_3 = Class576.smethod_42((double) ((float) obj2));
            continue;
        Label_073E:
            if (num3 <= 0x500)
            {
                if (num3 != 0x4ec)
                {
                    if (num3 != 0x500)
                    {
                        goto Label_09CD;
                    }
                    this.class972_0.int_2 = (byte) obj2;
                }
                else if ((bool) obj2)
                {
                    this.class972_0.string_13 = BookmarkStart.b("夬崮䐰嘲", num);
                }
                else
                {
                    this.class972_0.int_0--;
                }
            }
            else if (num3 != 0x582)
            {
                if (num3 != 0x5aa)
                {
                    goto Label_09CD;
                }
                this.class972_0.string_4 = ((int) obj2).ToString();
                this.class972_0.int_0--;
            }
            else if ((bool) obj2)
            {
                this.class972_0.string_16 = BookmarkStart.b("䌬䀮ᰰ弲尴娶倸伺", num);
            }
            else
            {
                this.class972_0.int_0--;
            }
            continue;
        Label_0837:
            if (num3 <= 0x5dc)
            {
                switch (num3)
                {
                    case 0x5b4:
                    {
                        this.class972_0.string_1 = Class576.smethod_83((Class16) obj2);
                        if (this.class972_0.string_1 == null)
                        {
                            this.class972_0.int_0--;
                        }
                        continue;
                    }
                    case 0x5be:
                    {
                        if ((bool) obj2)
                        {
                            this.class972_0.bool_2 = true;
                        }
                        else
                        {
                            this.class972_0.bool_2 = false;
                            this.class972_0.int_0--;
                        }
                        continue;
                    }
                }
                if (num3 != 0x5dc)
                {
                    goto Label_09CD;
                }
                if (attrs.HasValue(0x5aa))
                {
                    this.class972_0.string_5 = Class576.smethod_35(obj2);
                }
                this.class972_0.int_0--;
                continue;
            }
            if (num3 <= 0x618)
            {
                if (num3 == 0x5e6)
                {
                    this.class972_0.string_17 = Class922.smethod_42((BaselineAlignment) obj2);
                    if (this.class972_0.string_17 == null)
                    {
                        this.class972_0.int_0--;
                    }
                }
                else
                {
                    if (num3 != 0x618)
                    {
                        goto Label_09CD;
                    }
                    if ((bool) obj2)
                    {
                        this.class972_0.string_10 = BookmarkStart.b("弬䌮ᰰ䜲圴", num);
                    }
                    else
                    {
                        this.class972_0.string_10 = BookmarkStart.b("䄬崮ᰰ䜲圴", num);
                    }
                }
                continue;
            }
            switch (num3)
            {
                case 0x672:
                {
                    float num4 = Math.Abs((float) obj2);
                    LineSpacingRule rule = (LineSpacingRule) attrs.method_31(0x677);
                    this.class972_0.lineSpacingRule_0 = rule;
                    if (((A_0 is Paragraph) && ((Paragraph) A_0).Format.HasKey(0x532)) || (!(A_0 is Paragraph) && !(A_0 is Style)))
                    {
                        goto Label_0A84;
                    }
                    this.class972_0.string_7 = Class576.smethod_9(num4, rule);
                    continue;
                }
                case 0x271a:
                {
                    this.class972_0.class580_0 = (Class580) obj2;
                    this.class972_0.int_0--;
                    continue;
                }
            }
        Label_09CD:
            this.class972_0.int_0--;
            continue;
        Label_0A84:
            this.class972_0.int_0--;
        }
        this.method_8(A_0);
        this.method_9(A_0, paraPr, left, flag);
        if (this.class972_0.bool_0 && (this.class972_0.class1048_0.class411_0.string_3 != null))
        {
            if ((A_0 is Paragraph) && (((Paragraph) A_0).PreviousSibling == null))
            {
                this.class972_0.class1048_0.class411_0.string_3 = null;
                this.class972_0.int_0--;
            }
            else
            {
                this.class972_0.class1048_0.class411_0.string_3 = Class576.smethod_42(280.0);
            }
        }
        if (this.class972_0.bool_1 && (this.class972_0.class1048_0.class411_1.string_3 != null))
        {
            if ((A_0 is Paragraph) && (((Paragraph) A_0).NextSibling == null))
            {
                this.class972_0.class1048_0.class411_1.string_3 = null;
                this.class972_0.int_0--;
            }
            else
            {
                this.class972_0.class1048_0.class411_1.string_3 = Class576.smethod_42(280.0);
            }
        }
        this.method_6(A_0, paraPr);
    }

    private void method_6(Interface46 A_0, ParagraphFormat A_1)
    {
        int num = 0x10;
        if ((this.class972_0.class1048_0.class411_0.border_0 == null) && (this.class972_0.class1048_0.class411_0.string_2 == null))
        {
            this.class972_0.class1048_0.class411_0.border_0 = A_1.Borders.Top;
            this.class972_0.class1048_0.class411_0.string_2 = BookmarkStart.b("堵圷吹夻", num);
        }
        if ((this.class972_0.class1048_0.class411_1.border_0 == null) && (this.class972_0.class1048_0.class411_1.string_2 == null))
        {
            this.class972_0.class1048_0.class411_1.border_0 = A_1.Borders.Bottom;
            this.class972_0.class1048_0.class411_1.string_2 = BookmarkStart.b("堵圷吹夻", num);
        }
        if ((this.class972_0.class1048_0.class411_2.border_0 == null) && (this.class972_0.class1048_0.class411_2.string_2 == null))
        {
            this.class972_0.class1048_0.class411_2.border_0 = A_1.Borders.Left;
            this.class972_0.class1048_0.class411_2.string_2 = BookmarkStart.b("堵圷吹夻", num);
        }
        if ((this.class972_0.class1048_0.class411_3.border_0 == null) && (this.class972_0.class1048_0.class411_3.string_2 == null))
        {
            this.class972_0.class1048_0.class411_3.border_0 = A_1.Borders.Right;
            this.class972_0.class1048_0.class411_3.string_2 = BookmarkStart.b("堵圷吹夻", num);
        }
        this.class972_0.class1048_0.method_1(false, false);
    }

    private void method_7(Interface46 A_0)
    {
        if (A_0 is Paragraph)
        {
            Paragraph paragraph = (Paragraph) A_0;
            if (paragraph.IsInCell)
            {
                this.class422_0.method_98(true);
            }
        }
    }

    private void method_8(Interface46 A_0)
    {
        int num = 15;
        if (A_0 is Paragraph)
        {
            Paragraph paragraph = (Paragraph) A_0;
            Section section = paragraph.method_49();
            if ((section != null) || !(paragraph.OwnerTextBody.Owner is ShapeObject))
            {
                Class17 sectPr = section.SectPr;
                object obj3 = sectPr.method_31(0x884);
                object obj2 = sectPr.method_31(0x83e);
                if ((section.Body.Paragraphs.Count > 0) && (paragraph == section.Body.Paragraphs[0]))
                {
                    if ((obj3 != null) || (obj2 != null))
                    {
                        this.class972_0.string_11 = BookmarkStart.b("䄴䔶䰸帺", num);
                    }
                    if ((sectPr.method_60() && !this.bool_1) && !this.bool_0)
                    {
                        this.class972_0.string_18 = Class1041.smethod_8(sectPr.method_86());
                        this.class972_0.int_0++;
                    }
                }
                if ((this.class972_0.string_11 == BookmarkStart.b("䄴䔶䰸帺", num)) && !Class567.smethod_16(this.class972_0.string_12))
                {
                    object obj4 = sectPr.method_31(0x884);
                    this.class972_0.string_12 = (obj4 != null) ? Class1041.smethod_8((int) obj4) : BookmarkStart.b("д", num);
                    this.class972_0.int_0++;
                }
            }
        }
    }

    private void method_9(Interface46 A_0, ParagraphFormat A_1, HorizontalAlignment A_2, bool A_3)
    {
        int num = 5;
        TextOrientation horizontal = TextOrientation.Horizontal;
        VerticalAlignment top = VerticalAlignment.Top;
        if (A_0 is Paragraph)
        {
            Paragraph paragraph = (Paragraph) A_0;
            if (paragraph.IsInCell)
            {
                horizontal = (TextOrientation) ((TableCell) paragraph.OwnerTextBody).CellFormat.method_32(0xbea);
                top = ((TableCell) paragraph.OwnerTextBody).CellFormat.VerticalAlignment;
            }
        }
        string str = Class922.smethod_11(A_3, A_2, horizontal, top);
        if (Class567.smethod_16(str))
        {
            this.class972_0.string_2 = str;
        }
        if ((A_1 != null) && (A_2 == HorizontalAlignment.Distribute))
        {
            this.class972_0.string_3 = BookmarkStart.b("䄪堬尮䔰娲匴丶", num);
        }
        if (!Class567.smethod_16(this.class972_0.string_2) && A_3)
        {
            this.class972_0.int_0--;
        }
        if (Class567.smethod_16(this.class972_0.string_2) && !A_3)
        {
            this.class972_0.int_0++;
        }
        this.method_10(A_0);
    }
}

