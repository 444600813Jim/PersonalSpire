using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Drawing;

internal class Class418
{
    private Class418()
    {
    }

    internal static bool smethod_0(CharacterFormat A_0, IRunAttrSource A_1, bool A_2, Interface52 A_3)
    {
        int num = 2;
        Class398 class2 = A_3.imethod_1();
        if ((A_0.FormatRevision != null) && A_0.IsChangedFormat)
        {
            smethod_3(A_0, A_1, true, A_2, true, A_3, false);
            class2.vmethod_5(A_0.FormatRevision, BookmarkStart.b("弧ဩ師縭䈯焱尳圵嘷崹夻", num), A_3.imethod_6());
            if (smethod_3(A_0.FormatRevision.method_4() as CharacterFormat, A_1, true, false, false, A_3, true))
            {
                class2.method_6(BookmarkStart.b("弧ဩ師縭䈯", num));
            }
            class2.vmethod_8();
            class2.method_6(BookmarkStart.b("弧ဩ師縭䈯", num));
            return true;
        }
        if (smethod_3(A_0, A_1, true, A_2, false, A_3, false))
        {
            class2.method_6(BookmarkStart.b("弧ဩ師縭䈯", num));
            return true;
        }
        return false;
    }

    private static void smethod_1(Interface52 A_0, CharacterFormat A_1)
    {
        A_0.imethod_1();
    }

    internal static void smethod_2(CharacterFormat A_0, IRunAttrSource A_1, Interface52 A_2)
    {
        int num = 2;
        if (smethod_3(A_0, A_1, false, false, false, A_2, false))
        {
            A_2.imethod_1().method_6(BookmarkStart.b("弧ဩ師縭䈯", num));
        }
    }

    private static bool smethod_3(CharacterFormat A_0, IRunAttrSource A_1, bool A_2, bool A_3, bool A_4, Interface52 A_5, bool A_6)
    {
        int num = 13;
        if (A_0 == null)
        {
            return false;
        }
        bool flag = A_5.imethod_2();
        int num2 = 0;
        string styleId = null;
        string str2 = null;
        string str3 = null;
        string str4 = null;
        string str5 = null;
        string str6 = null;
        string str7 = null;
        string str8 = null;
        string str9 = null;
        string str10 = null;
        object obj2 = null;
        object obj3 = null;
        object obj4 = null;
        object obj5 = null;
        object obj6 = null;
        object obj7 = null;
        object obj8 = null;
        object obj9 = null;
        object obj10 = null;
        object obj11 = null;
        object obj12 = null;
        object obj13 = null;
        object obj14 = null;
        object obj15 = null;
        object obj16 = null;
        object obj17 = null;
        object obj18 = null;
        object obj19 = null;
        object obj20 = null;
        object obj21 = null;
        object obj22 = null;
        object obj23 = null;
        object obj24 = null;
        object obj25 = null;
        object obj26 = null;
        object obj27 = null;
        object obj28 = null;
        string str11 = null;
        string str12 = null;
        string str13 = null;
        Border border = null;
        Class16 class2 = null;
        string str14 = null;
        string str15 = null;
        string str16 = null;
        object obj29 = null;
        object obj30 = null;
        string str17 = null;
        string str18 = null;
        string str19 = null;
        string str20 = null;
        string str21 = null;
        string str22 = null;
        Class340 class3 = null;
        object obj31 = null;
        object obj32 = null;
        object obj33 = null;
        object obj34 = null;
        bool flag2 = false;
        for (int i = 0; i < A_0.Count; i++)
        {
            int num4 = A_0.method_18(i);
            object obj35 = A_0.method_19(i);
            num2++;
            int num5 = num4;
            if (num5 <= 0x109)
            {
                if (num5 <= 150)
                {
                    if (num5 <= 80)
                    {
                        if (num5 <= 0x2d)
                        {
                            switch (num5)
                            {
                                case 10:
                                {
                                    obj31 = A_0.method_62((short) num4);
                                    continue;
                                }
                                case 12:
                                {
                                    if (!A_6 && !(A_1 is Paragraph))
                                    {
                                        num2--;
                                    }
                                    continue;
                                }
                                case 14:
                                {
                                    if (!A_6 && !(A_1 is Paragraph))
                                    {
                                        num2--;
                                    }
                                    continue;
                                }
                                case 20:
                                {
                                    obj28 = Class860.smethod_20((Color) obj35, flag);
                                    continue;
                                }
                                case 0x2d:
                                {
                                    num2--;
                                    continue;
                                }
                            }
                            goto Label_08AF;
                        }
                        switch (num5)
                        {
                            case 60:
                            {
                                obj2 = A_0.method_62((short) num4);
                                continue;
                            }
                            case 70:
                            {
                                obj4 = A_0.method_62((short) num4);
                                continue;
                            }
                        }
                        if (num5 != 80)
                        {
                            goto Label_08AF;
                        }
                        obj8 = A_0.method_62((short) num4);
                    }
                    else if (num5 <= 110)
                    {
                        switch (num5)
                        {
                            case 90:
                            {
                                obj10 = A_0.method_62((short) num4);
                                continue;
                            }
                            case 100:
                            {
                                obj11 = A_0.method_62((short) num4);
                                continue;
                            }
                        }
                        if (num5 != 110)
                        {
                            goto Label_08AF;
                        }
                        obj7 = A_0.method_62((short) num4);
                    }
                    else
                    {
                        if (num5 <= 0x84)
                        {
                            switch (num5)
                            {
                                case 130:
                                {
                                    obj16 = A_0.method_62((short) num4);
                                    continue;
                                }
                                case 0x84:
                                {
                                    obj17 = A_0.method_62((short) num4);
                                    continue;
                                }
                                case 120:
                                {
                                    obj6 = A_0.method_62((short) num4);
                                    continue;
                                }
                            }
                            goto Label_08AF;
                        }
                        if (num5 == 140)
                        {
                            str11 = Class860.smethod_18((UnderlineStyle) obj35, flag);
                        }
                        else
                        {
                            if (num5 != 150)
                            {
                                goto Label_08AF;
                            }
                            if (((float) obj35) != 0f)
                            {
                                obj22 = (int) (((float) obj35) * 20f);
                            }
                        }
                    }
                }
                else if (num5 <= 210)
                {
                    if (num5 <= 180)
                    {
                        switch (num5)
                        {
                            case 160:
                            {
                                obj18 = obj35;
                                continue;
                            }
                            case 170:
                            {
                                obj12 = A_0.method_62((short) num4);
                                continue;
                            }
                        }
                        if (num5 != 180)
                        {
                            goto Label_08AF;
                        }
                        obj13 = A_0.method_62((short) num4);
                    }
                    else
                    {
                        switch (num5)
                        {
                            case 190:
                            {
                                obj26 = obj35;
                                continue;
                            }
                            case 200:
                            {
                                obj25 = ((float) obj35) * 2f;
                                continue;
                            }
                        }
                        if (num5 != 210)
                        {
                            goto Label_08AF;
                        }
                        str16 = Class860.smethod_22((SubSuperScript) obj35);
                    }
                }
                else if (num5 <= 0xeb)
                {
                    switch (num5)
                    {
                        case 220:
                        {
                            obj24 = ((float) obj35) * 2f;
                            continue;
                        }
                        case 230:
                        {
                            str2 = (string) obj35;
                            continue;
                        }
                    }
                    if (num5 != 0xeb)
                    {
                        goto Label_08AF;
                    }
                    str4 = (string) obj35;
                }
                else if (num5 <= 250)
                {
                    if (num5 != 240)
                    {
                        if (num5 != 250)
                        {
                            goto Label_08AF;
                        }
                        obj3 = A_0.method_62((short) num4);
                    }
                    else
                    {
                        str3 = (string) obj35;
                    }
                }
                else if (num5 != 260)
                {
                    if (num5 != 0x109)
                    {
                        goto Label_08AF;
                    }
                    obj29 = A_0.method_62((short) num4);
                }
                else
                {
                    obj5 = A_0.method_62((short) num4);
                }
                continue;
            }
            if (num5 <= 440)
            {
                if (num5 <= 340)
                {
                    if (num5 <= 300)
                    {
                        switch (num5)
                        {
                            case 0x10c:
                            {
                                obj30 = A_0.method_62((short) num4);
                                continue;
                            }
                            case 270:
                            {
                                str5 = (string) obj35;
                                continue;
                            }
                            case 290:
                            {
                                obj23 = obj35;
                                continue;
                            }
                            case 300:
                            {
                                obj9 = A_0.method_62((short) num4);
                                continue;
                            }
                        }
                        goto Label_08AF;
                    }
                    switch (num5)
                    {
                        case 310:
                        {
                            str13 = Class860.smethod_16((TextEffect) obj35, flag);
                            continue;
                        }
                        case 330:
                        {
                            obj15 = A_0.method_62((short) num4);
                            continue;
                        }
                    }
                    if (num5 != 340)
                    {
                        goto Label_08AF;
                    }
                    str22 = Class860.smethod_1((short) obj35, flag);
                    if (!Class567.smethod_16(str22))
                    {
                        num2--;
                    }
                }
                else if (num5 <= 370)
                {
                    switch (num5)
                    {
                        case 350:
                        {
                            obj27 = obj35;
                            continue;
                        }
                        case 360:
                        {
                            border = (Border) obj35;
                            continue;
                        }
                    }
                    if (num5 != 370)
                    {
                        goto Label_08AF;
                    }
                    class2 = (Class16) obj35;
                }
                else if (num5 <= 390)
                {
                    if (num5 != 380)
                    {
                        if (num5 != 390)
                        {
                            goto Label_08AF;
                        }
                        str21 = Class860.smethod_1((short) obj35, flag);
                        if (!Class567.smethod_16(str21))
                        {
                            num2--;
                        }
                    }
                    else
                    {
                        str20 = Class860.smethod_1((short) obj35, flag);
                        if (!Class567.smethod_16(str20))
                        {
                            num2--;
                        }
                    }
                }
                else if (num5 != 400)
                {
                    if (num5 != 440)
                    {
                        goto Label_08AF;
                    }
                    obj14 = A_0.method_62((short) num4);
                }
                else
                {
                    str6 = Class860.smethod_10((CharacterCategory) Enum.ToObject(typeof(CharacterCategory), obj35), flag);
                }
                continue;
            }
            if (num5 <= 530)
            {
                if (num5 <= 470)
                {
                    switch (num5)
                    {
                        case 450:
                        {
                            str12 = Class114.smethod_12((Color) obj35);
                            continue;
                        }
                        case 460:
                        {
                            if (flag)
                            {
                                num2--;
                            }
                            else
                            {
                                str19 = Class860.smethod_24((HyphenRule) obj35);
                            }
                            continue;
                        }
                    }
                    if (num5 != 470)
                    {
                        goto Label_08AF;
                    }
                    num2--;
                    continue;
                }
                if (num5 <= 510)
                {
                    if (num5 == 500)
                    {
                        if (flag)
                        {
                            obj19 = obj35;
                        }
                        else
                        {
                            num2--;
                        }
                    }
                    else
                    {
                        if (num5 != 510)
                        {
                            goto Label_08AF;
                        }
                        if (flag)
                        {
                            obj20 = obj35;
                        }
                        else
                        {
                            num2--;
                        }
                    }
                    continue;
                }
                switch (num5)
                {
                    case 520:
                    {
                        if (!flag)
                        {
                            break;
                        }
                        obj21 = obj35;
                        continue;
                    }
                    case 0x209:
                    {
                        if (!flag)
                        {
                            num2--;
                        }
                        continue;
                    }
                    case 0x20a:
                    {
                        if (!flag)
                        {
                            num2--;
                        }
                        continue;
                    }
                    case 0x20b:
                    {
                        if (!flag)
                        {
                            num2--;
                        }
                        continue;
                    }
                    case 530:
                    {
                        if (flag)
                        {
                            str7 = (string) obj35;
                        }
                        else
                        {
                            num2--;
                        }
                        continue;
                    }
                    default:
                        goto Label_08AF;
                }
                num2--;
                continue;
            }
            if (num5 <= 560)
            {
                switch (num5)
                {
                    case 540:
                    {
                        if (flag)
                        {
                            str8 = (string) obj35;
                        }
                        else
                        {
                            num2--;
                        }
                        continue;
                    }
                    case 550:
                    {
                        if (flag)
                        {
                            str9 = (string) obj35;
                        }
                        else
                        {
                            num2--;
                        }
                        continue;
                    }
                }
                if (num5 != 560)
                {
                    goto Label_08AF;
                }
                if (flag)
                {
                    str10 = (string) obj35;
                }
                else
                {
                    num2--;
                }
                continue;
            }
            if (num5 <= 770)
            {
                if (num5 != 760)
                {
                    if (num5 != 770)
                    {
                        goto Label_08AF;
                    }
                    str17 = Class860.smethod_4((Emphasis) obj35, flag);
                }
                else
                {
                    flag2 = true;
                }
                continue;
            }
            switch (num5)
            {
                case 780:
                {
                    class3 = (Class340) obj35;
                    continue;
                }
                case 0x271a:
                {
                    continue;
                }
            }
        Label_08AF:
            num2--;
        }
        if ((A_0 != null) && !string.IsNullOrEmpty(A_0.CharStyleName))
        {
            Style style = A_0.Document.Styles.DocStyleCollection.FindByName(A_0.CharStyleName);
            if (style != null)
            {
                if (flag)
                {
                    styleId = style.StyleId;
                }
                else
                {
                    styleId = A_5.imethod_4(style.StyleDocId);
                }
                num2++;
            }
            else
            {
                styleId = null;
            }
        }
        else
        {
            styleId = null;
        }
        if ((num2 == 0) && !A_4)
        {
            return false;
        }
        Class398 class4 = A_5.imethod_1();
        if (A_3)
        {
            class4.method_4(BookmarkStart.b("䐲༴䜶椸䤺", num));
        }
        class4.method_4(BookmarkStart.b("䐲༴䔶椸䤺", num));
        if (!A_6 && (A_1 is Paragraph))
        {
            if (A_0.HasInsertRevision)
            {
                string str23 = flag ? (A_5 as Class421).class401_0.method_3().method_476() : A_5.imethod_6().ToString();
                class4.vmethod_12(A_0.InsertRevision, str23, flag);
            }
            if (A_0.HasDeleteRevision)
            {
                string str24 = flag ? (A_5 as Class421).class401_0.method_3().method_476() : A_5.imethod_6().ToString();
                class4.vmethod_12(A_0.DeleteRevision, str24, flag);
            }
        }
        class4.method_24(BookmarkStart.b("䐲༴䔶樸伺䐼匾⑀", num), styleId);
        if (flag)
        {
            class4.method_31(BookmarkStart.b("䐲༴堶琸娺䤼圾", num), flag2);
            class4.method_33(BookmarkStart.b("䐲༴䔶缸吺匼䬾㉀", num), new object[] { 
                BookmarkStart.b("䐲༴嘶䨸堺吼嘾", num), str2, BookmarkStart.b("䐲༴制堸䠺䤼績㉀⩂⑄", num), str4, BookmarkStart.b("䐲༴弶砸唺丼嘾", num), str3, BookmarkStart.b("䐲༴嘶䨸堺吼嘾ᕀ⭂⁄⩆ⱈ", num), str7, BookmarkStart.b("䐲༴制堸䠺䤼績㉀⩂⑄ፆⅈ⹊⁌⩎", num), str9, BookmarkStart.b("䐲༴弶砸唺丼嘾ᕀ⭂⁄⩆ⱈ", num), str8, BookmarkStart.b("䐲༴吶䨸", num), str5, BookmarkStart.b("䐲༴吶䨸伺唼娾ⱀ♂", num), str10, 
                BookmarkStart.b("䐲༴弶倸唺䤼", num), str6
             });
        }
        else
        {
            class4.method_33(BookmarkStart.b("䐲༴䔶缸吺匼䬾㉀", num), new object[] { BookmarkStart.b("䐲༴嘶䨸堺吼嘾", num), str2, BookmarkStart.b("䐲༴儶堸䤺堼帾㉀㝂", num), str4, BookmarkStart.b("䐲༴弶ᐸ娺匼䰾⡀", num), str3, BookmarkStart.b("䐲༴吶䨸", num), str5, BookmarkStart.b("䐲༴弶倸唺䤼", num), str6 });
        }
        class4.method_22(BookmarkStart.b("䐲༴唶", num), obj2);
        class4.method_22(flag ? BookmarkStart.b("䐲༴唶稸䠺", num) : BookmarkStart.b("䐲༴唶ᐸ堺丼", num), obj3);
        class4.method_22(BookmarkStart.b("䐲༴帶", num), obj4);
        class4.method_22(flag ? BookmarkStart.b("䐲༴帶稸䠺", num) : BookmarkStart.b("䐲༴帶ᐸ堺丼", num), obj5);
        class4.method_22(BookmarkStart.b("䐲༴吶堸䬺丼", num), obj6);
        class4.method_22(BookmarkStart.b("䐲༴䐶吸娺儼匾ɀ≂㕄㑆", num), obj7);
        class4.method_22(BookmarkStart.b("䐲༴䐶䴸䤺吼吾⑀", num), obj8);
        class4.method_22(BookmarkStart.b("䐲༴匶䨸伺似嘾⩀♂", num), obj9);
        class4.method_22(BookmarkStart.b("䐲༴堶䰸伺儼嘾⽀♂", num), obj10);
        class4.method_22(BookmarkStart.b("䐲༴䐶儸娺夼倾㙀", num), obj11);
        class4.method_22(BookmarkStart.b("䐲༴制吸夺刼䰾㉀", num), obj12);
        class4.method_22(BookmarkStart.b("䐲༴帶吸䬺似嘾⽀㝂", num), obj13);
        class4.method_22(BookmarkStart.b("䐲༴夶嘸欺似倾⹀╂", num), obj14);
        class4.method_22(BookmarkStart.b("䐲༴䐶圸娺䴼款⹀т㝄⹆ⵈ", num), obj15);
        class4.method_22(BookmarkStart.b("䐲༴䄶堸唺吼䰾⥀", num), obj16);
        class4.method_22(BookmarkStart.b("䐲༴䀶尸夺甼嘾╀❂⁄⥆", num), obj17);
        if (flag)
        {
            class4.method_33(BookmarkStart.b("䐲༴吶嘸场刼䴾", num), new object[] { BookmarkStart.b("䐲༴䄶堸场", num), obj18, BookmarkStart.b("䐲༴䌶儸帺值娾ɀⱂ⥄⡆㭈", num), obj19, BookmarkStart.b("䐲༴䌶儸帺值娾ቀ⭂⑄⍆ⱈ", num), obj20, BookmarkStart.b("䐲༴䌶儸帺值娾ᕀ⩂⭄㍆", num), obj21 });
        }
        else
        {
            class4.method_22(BookmarkStart.b("䐲༴吶嘸场刼䴾", num), obj18);
        }
        class4.method_22(BookmarkStart.b("䐲༴䐶䤸娺帼嘾⽀⑂", num), obj22);
        class4.method_22(BookmarkStart.b("䐲༴䀶", num), obj23);
        class4.method_22(BookmarkStart.b("䐲༴尶尸䤺匼", num), obj24);
        class4.method_22(BookmarkStart.b("䐲༴䜶嘸䠺吼䬾⡀ⱂ⭄", num), obj25);
        class4.method_22(BookmarkStart.b("䐲༴䐶䌸", num), class4.method_23(obj26, 2f));
        class4.method_22(flag ? BookmarkStart.b("䐲༴䐶䌸砺丼", num) : BookmarkStart.b("䐲༴䐶䌸ᘺ帼䰾", num), class4.method_23(obj27, 2f));
        class4.method_22(BookmarkStart.b("䐲༴弶倸尺唼匾⡀⑂ⵄ㍆", num), obj28);
        class4.method_33(BookmarkStart.b("䐲༴䈶", num), new object[] { BookmarkStart.b("䐲༴䄶堸场", num), str11, BookmarkStart.b("䐲༴吶嘸场刼䴾", num), str12 });
        class4.method_24(BookmarkStart.b("䐲༴制弸崺堼尾㕀", num), str13);
        class4.method_47(BookmarkStart.b("䐲༴唶崸䤺", num), border, flag);
        class4.vmethod_4(class2);
        class4.method_33(BookmarkStart.b("䐲༴儶倸伺椼娾㥀㝂", num), new object[] { BookmarkStart.b("䐲༴䄶堸场", num), str14, BookmarkStart.b("䐲༴帶崸", num), str15 });
        class4.method_24(BookmarkStart.b("䐲༴䄶尸䤺䤼績ⵀ⩂≄⥆", num), str16);
        class4.method_22(BookmarkStart.b("䐲༴䔶䴸场", num), obj29);
        class4.method_22(BookmarkStart.b("䐲༴吶䨸", num), obj30);
        class4.method_24(BookmarkStart.b("䐲༴制吸", num), str17);
        if (!flag)
        {
            class4.method_33(BookmarkStart.b("䐲༴弶䀸䬺唼娾⽀", num), new object[] { BookmarkStart.b("䐲༴䄶堸场", num), str18, BookmarkStart.b("䐲༴䔶䰸场堼", num), str19 });
        }
        class4.method_33(BookmarkStart.b("䐲༴嬶堸唺娼", num), new object[] { BookmarkStart.b("䐲༴䄶堸场", num), str20, flag ? BookmarkStart.b("䐲༴制堸䠺䤼績㉀⩂⑄", num) : BookmarkStart.b("䐲༴儶堸䤺堼帾㉀㝂", num), str21, BookmarkStart.b("䐲༴唶倸强吼", num), str22 });
        if (class3 != null)
        {
            smethod_4(class4, class3, flag);
        }
        class4.method_22(BookmarkStart.b("䐲༴䐶䤸帺帼椾⁀ⵂⱄ㑆ⅈ", num), obj31);
        if (!flag)
        {
            class4.method_22(BookmarkStart.b("䐲䴴ശ弸吺匼䬾", num), obj32);
            class4.method_33(BookmarkStart.b("䐲䴴ശ䨸䈺值", num), new object[] { BookmarkStart.b("䐲䴴ശ弸吺匼䬾", num), obj33, BookmarkStart.b("䐲䴴ശ娸区尼䴾", num), obj34 });
        }
        return true;
    }

    private static void smethod_4(Class398 A_0, Class340 A_1, bool A_2)
    {
        int num = 4;
        A_0.method_33(A_2 ? BookmarkStart.b("崩ᘫ䬭儯䄱䀳眵䬷匹崻倽ి⍁㵃⥅㵇㹉", num) : BookmarkStart.b("崩ᘫ伭䌯嬱唳堵琷嬹䔻儽㔿㙁", num), new object[] { BookmarkStart.b("崩ᘫ䜭启", num), A_1.method_8(), BookmarkStart.b("崩ᘫ堭唯䀱䀳", num), A_1.method_0(), A_2 ? BookmarkStart.b("崩ᘫ堭唯䀱䀳电圷圹䰻䰽┿ㅁ㝃", num) : BookmarkStart.b("崩ᘫ堭唯䀱䀳ᬵ嬷唹儻丽㈿❁㝃㕅", num), A_1.method_6(), BookmarkStart.b("崩ᘫ䴭弯弱嘳張嘷弹", num), A_1.method_2(), A_2 ? BookmarkStart.b("崩ᘫ䴭弯弱嘳張嘷弹縻䰽ℿ⅁⽃⍅㱇㥉", num) : BookmarkStart.b("崩ᘫ䴭弯弱嘳張嘷弹ᄻ尽㈿⍁❃ⵅⵇ㹉㽋", num), Class860.smethod_6(A_1.method_4()) });
    }

    private static object smethod_5(object A_0, IRunAttrSource A_1, int A_2)
    {
        return Class650.smethod_0((bool) A_0).method_6(A_1, A_2);
    }
}

