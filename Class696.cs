using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class696
{
    private const int int_0 = -31680;

    private Class696()
    {
    }

    internal static void smethod_0(ParagraphFormat A_0, Interface52 A_1)
    {
        if (smethod_1(A_0, A_1))
        {
            A_1.imethod_1().method_5();
        }
    }

    internal static bool smethod_1(ParagraphFormat A_0, Interface52 A_1)
    {
        int num = 11;
        if ((A_0 == null) || (A_0.Count == 0))
        {
            return false;
        }
        Class398 class2 = A_1.imethod_1();
        if ((A_0.FormatRevision != null) && A_0.IsChangedFormat)
        {
            class2.method_4(BookmarkStart.b("䘰ल䔴朶䬸", num));
            smethod_2(A_0, false, A_1, false);
            class2.vmethod_5(A_0.FormatRevision, BookmarkStart.b("䘰ल䔴朶䬸砺唼帾⽀⑂⁄", num), A_1.imethod_6());
            class2.method_4(BookmarkStart.b("䘰ल䔴朶䬸", num));
            smethod_2(A_0.FormatRevision.method_4(), false, A_1, true);
            class2.method_6(BookmarkStart.b("䘰ल䔴朶䬸", num));
            class2.vmethod_8();
            return true;
        }
        return smethod_2(A_0, true, A_1, false);
    }

    private static bool smethod_2(WordAttrCollection A_0, bool A_1, Interface52 A_2, bool A_3)
    {
        int num = 0;
        bool flag = A_2.imethod_2();
        Class398 class2 = A_2.imethod_1();
        int num2 = 0;
        string styleId = null;
        object obj2 = null;
        object obj3 = null;
        object obj4 = null;
        string str2 = null;
        object obj5 = null;
        object obj6 = null;
        object obj7 = null;
        object obj8 = null;
        object obj9 = null;
        string str3 = null;
        string str4 = null;
        string str5 = null;
        object obj10 = null;
        string str6 = null;
        object obj11 = null;
        string str7 = null;
        string str8 = null;
        object obj12 = null;
        object obj13 = null;
        object obj14 = null;
        object listLevelNumber = null;
        object obj16 = null;
        Border top = null;
        Border left = null;
        Border bottom = null;
        Border right = null;
        Border border5 = null;
        Border border6 = null;
        Class16 class3 = null;
        TabCollection tabs = null;
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
        object obj29 = null;
        object obj30 = null;
        object obj31 = null;
        object obj32 = null;
        object obj33 = null;
        string str9 = null;
        object obj34 = null;
        object obj35 = null;
        object obj36 = null;
        object obj37 = null;
        object obj38 = null;
        object obj39 = null;
        object obj40 = null;
        object obj41 = null;
        object obj42 = null;
        object obj43 = null;
        object obj44 = null;
        string str10 = null;
        string str11 = null;
        string str12 = null;
        object obj45 = null;
        Class578 class4 = null;
        for (int i = 0; i < A_0.Count; i++)
        {
            int num4 = A_0.method_18(i);
            object obj46 = A_0.method_19(i);
            num2++;
            int num5 = num4;
            if (num5 <= 0x497)
            {
                if (num5 <= 0x456)
                {
                    if (num5 <= 0x41a)
                    {
                        if (num5 <= 40)
                        {
                            if (num5 == 20)
                            {
                                bottom = (obj46 as Borders).Bottom;
                                left = (obj46 as Borders).Left;
                                right = (obj46 as Borders).Right;
                                top = (obj46 as Borders).Top;
                            }
                            else
                            {
                                if (num5 != 40)
                                {
                                    goto Label_0757;
                                }
                                if (!(A_0 as ParagraphFormat).Frame.IsDefault)
                                {
                                    Class14 class5 = obj46 as Class14;
                                    if (class5.HasKey(0x11))
                                    {
                                        obj6 = class5.method_87();
                                    }
                                    if (class5.HasKey(6))
                                    {
                                        obj7 = class5.method_92();
                                    }
                                    if (class5.HasKey(7))
                                    {
                                        str8 = Class248.smethod_15(class5.method_95(), flag);
                                    }
                                    if (class5.HasKey(9))
                                    {
                                        obj9 = class5.method_97();
                                    }
                                    if (class5.HasKey(0x10))
                                    {
                                        obj8 = class5.method_100();
                                    }
                                    if (class5.HasKey(0x12))
                                    {
                                        str3 = Class248.smethod_13(class5.method_103(), flag);
                                    }
                                    if (class5.HasKey(11))
                                    {
                                        str4 = Class248.smethod_9((byte) class5.method_81());
                                    }
                                    if (class5.HasKey(12))
                                    {
                                        str5 = Class248.smethod_11((byte) class5.method_84());
                                    }
                                    if (class5.HasKey(3))
                                    {
                                        obj10 = class5.method_63();
                                    }
                                    if (class5.HasKey(8))
                                    {
                                        str6 = Class248.smethod_7(class5.method_74());
                                    }
                                    if (class5.HasKey(4))
                                    {
                                        obj11 = class5.method_68();
                                    }
                                    if (class5.HasKey(15))
                                    {
                                        str7 = Class248.smethod_5(class5.method_77());
                                    }
                                    if (class5.HasKey(0x15))
                                    {
                                        str2 = Class248.smethod_3(class5.method_108());
                                    }
                                    if (class5.HasKey(20))
                                    {
                                        obj5 = class5.method_110();
                                    }
                                }
                            }
                            continue;
                        }
                        switch (num5)
                        {
                            case 0x3fc:
                            {
                                str10 = Class248.smethod_19((HorizontalAlignment) obj46, false);
                                continue;
                            }
                            case 0x3fe:
                            {
                                obj43 = obj46;
                                continue;
                            }
                            case 0x410:
                            {
                                obj3 = obj46;
                                continue;
                            }
                            case 0x41a:
                            {
                                obj2 = obj46;
                                continue;
                            }
                        }
                        goto Label_0757;
                    }
                    if (num5 <= 0x438)
                    {
                        switch (num5)
                        {
                            case 0x424:
                            {
                                obj4 = obj46;
                                continue;
                            }
                            case 0x42e:
                            {
                                obj18 = obj46;
                                continue;
                            }
                        }
                        if (num5 != 0x438)
                        {
                            goto Label_0757;
                        }
                        obj19 = obj46;
                    }
                    else
                    {
                        switch (num5)
                        {
                            case 0x442:
                            {
                                obj20 = obj46;
                                continue;
                            }
                            case 0x44c:
                            {
                                obj21 = obj46;
                                continue;
                            }
                        }
                        if (num5 != 0x456)
                        {
                            goto Label_0757;
                        }
                        listLevelNumber = obj46;
                    }
                }
                else if (num5 <= 0x479)
                {
                    if (num5 <= 0x465)
                    {
                        if (num5 == 0x460)
                        {
                            obj14 = obj46;
                        }
                        else
                        {
                            if (num5 != 0x465)
                            {
                                goto Label_0757;
                            }
                            if (!A_3)
                            {
                                class4 = (Class578) obj46;
                                if (!class4.method_4())
                                {
                                    class4 = null;
                                    num2--;
                                }
                            }
                        }
                    }
                    else
                    {
                        switch (num5)
                        {
                            case 0x46a:
                            {
                                obj16 = obj46;
                                continue;
                            }
                            case 0x474:
                            {
                                tabs = (TabCollection) obj46;
                                continue;
                            }
                        }
                        if (num5 != 0x479)
                        {
                            goto Label_0757;
                        }
                        obj34 = obj46;
                    }
                }
                else if (num5 <= 0x488)
                {
                    switch (num5)
                    {
                        case 0x47e:
                        {
                            obj36 = obj46;
                            continue;
                        }
                        case 0x483:
                        {
                            obj40 = obj46;
                            continue;
                        }
                    }
                    if (num5 != 0x488)
                    {
                        goto Label_0757;
                    }
                    obj35 = obj46;
                }
                else
                {
                    switch (num5)
                    {
                        case 0x48d:
                        {
                            obj39 = obj46;
                            continue;
                        }
                        case 0x492:
                        {
                            if (((float) obj46) < 0f)
                            {
                                obj37 = -((float) obj46);
                            }
                            else
                            {
                                obj38 = obj46;
                            }
                            continue;
                        }
                    }
                    if (num5 != 0x497)
                    {
                        goto Label_0757;
                    }
                    if (((float) obj46) < 0f)
                    {
                        obj41 = -((float) obj46);
                    }
                    else
                    {
                        obj42 = obj46;
                    }
                }
                continue;
            }
            if (num5 <= 0x500)
            {
                if (num5 <= 0x4c9)
                {
                    if (num5 <= 0x4b5)
                    {
                        if (num5 != 0x4b0)
                        {
                            if (num5 != 0x4b5)
                            {
                                goto Label_0757;
                            }
                            obj28 = obj46;
                        }
                        else
                        {
                            obj27 = obj46;
                        }
                    }
                    else
                    {
                        switch (num5)
                        {
                            case 0x4ba:
                            {
                                obj29 = obj46;
                                continue;
                            }
                            case 0x4c4:
                            {
                                obj30 = obj46;
                                continue;
                            }
                        }
                        if (num5 != 0x4c9)
                        {
                            goto Label_0757;
                        }
                        obj31 = obj46;
                    }
                }
                else if (num5 <= 0x4e2)
                {
                    switch (num5)
                    {
                        case 0x4ce:
                        {
                            obj32 = obj46;
                            continue;
                        }
                        case 0x4d8:
                        {
                            obj22 = obj46;
                            continue;
                        }
                    }
                    if (num5 != 0x4e2)
                    {
                        goto Label_0757;
                    }
                    obj23 = obj46;
                }
                else
                {
                    switch (num5)
                    {
                        case 0x4ec:
                        {
                            obj26 = obj46;
                            continue;
                        }
                        case 0x4f6:
                        {
                            obj25 = obj46;
                            continue;
                        }
                    }
                    if (num5 != 0x500)
                    {
                        goto Label_0757;
                    }
                    obj45 = (byte) obj46;
                }
                continue;
            }
            if (num5 <= 0x5c8)
            {
                if (num5 <= 0x582)
                {
                    switch (num5)
                    {
                        case 0x56e:
                        {
                            border5 = (Border) obj46;
                            continue;
                        }
                        case 0x578:
                        {
                            border6 = (Border) obj46;
                            continue;
                        }
                    }
                    if (num5 != 0x582)
                    {
                        goto Label_0757;
                    }
                    obj17 = obj46;
                }
                else
                {
                    switch (num5)
                    {
                        case 0x5b4:
                        {
                            class3 = (Class16) obj46;
                            continue;
                        }
                        case 0x5be:
                        {
                            obj13 = obj46;
                            continue;
                        }
                    }
                    if (num5 != 0x5c8)
                    {
                        goto Label_0757;
                    }
                    str11 = Class417.smethod_39((TextDirection) obj46, flag);
                }
                continue;
            }
            if (num5 <= 0x672)
            {
                if (num5 == 0x5e6)
                {
                    str12 = Class248.smethod_1((TextAlignment) obj46);
                }
                else if (num5 != 0x618)
                {
                    if (num5 != 0x672)
                    {
                        goto Label_0757;
                    }
                    obj33 = Math.Abs((float) obj46);
                }
                else
                {
                    obj24 = obj46;
                }
                continue;
            }
            switch (num5)
            {
                case 0x677:
                {
                    str9 = Class248.smethod_17((LineSpacingRule) obj46, flag);
                    continue;
                }
                case 0x67c:
                {
                    obj44 = obj46;
                    continue;
                }
                case 0x271a:
                {
                    num2--;
                    continue;
                }
            }
        Label_0757:
            num2--;
        }
        ListFormat listFormat = null;
        if (A_0.OwnerBase is Paragraph)
        {
            Paragraph ownerBase = A_0.OwnerBase as Paragraph;
            if (string.IsNullOrEmpty(styleId) && ((A_0.OwnerBase as Paragraph).ParaStyle != null))
            {
                if (flag)
                {
                    styleId = (A_0.OwnerBase as Paragraph).ParaStyle.StyleId;
                }
                else
                {
                    styleId = A_2.imethod_5((A_0.OwnerBase as Paragraph).ParaStyle.StyleId);
                }
            }
            listFormat = ownerBase.ListFormat;
        }
        if (A_0.OwnerBase is ParagraphStyle)
        {
            listFormat = (A_0.OwnerBase as ParagraphStyle).ListFormat;
        }
        if (listFormat != null)
        {
            if (((listFormat.ListType != ListType.NoList) && listFormat.HasKey(1)) && !listFormat.IsEmptyList)
            {
                if (flag)
                {
                    obj14 = (A_2 as Class421).class401_0.method_3().method_520(listFormat);
                }
                else
                {
                    obj14 = (A_2 as Class421).method_22(listFormat);
                }
                listLevelNumber = listFormat.ListLevelNumber;
            }
            else if (listFormat.IsEmptyList)
            {
                obj14 = 0;
                listLevelNumber = 0;
            }
        }
        if (num2 == 0)
        {
            return false;
        }
        if (A_1)
        {
            class2.method_4(BookmarkStart.b("儥ሧ娩簫尭", num));
        }
        class2.method_24(BookmarkStart.b("儥ሧ娩缫娭䤯帱儳", num), styleId);
        class2.method_22(BookmarkStart.b("儥ሧ䄩䤫䬭䀯簱儳丵䰷", num), obj2);
        class2.method_22(BookmarkStart.b("儥ሧ䄩䤫䬭䀯縱崳堵崷䤹", num), obj3);
        class2.method_22(BookmarkStart.b("儥ሧ娩䴫䤭唯瀱䘳匵夷儹縻嬽☿ⵁ㙃⍅", num), obj4);
        if (obj10 != null)
        {
            str6 = null;
        }
        if (obj11 != null)
        {
            str7 = null;
        }
        class2.method_33(BookmarkStart.b("儥ሧ䰩師伭崯圱搳䐵", num), new object[] { 
            flag ? BookmarkStart.b("儥ሧ丩師䄭䀯焱唳䘵", num) : BookmarkStart.b("儥ሧ丩師䄭䀯ἱ圳圵䠷", num), str2, BookmarkStart.b("儥ሧ䘩䔫䀭唯䄱", num), obj5, BookmarkStart.b("儥ሧ崩", num), obj6, BookmarkStart.b("儥ሧ䈩", num), obj7, flag ? BookmarkStart.b("儥ሧ䈩縫嬭尯圱", num) : BookmarkStart.b("儥ሧ䈩ī尭䔯帱儳", num), str8, flag ? BookmarkStart.b("儥ሧ䈩缫席儯儱儳", num) : BookmarkStart.b("儥ሧ䈩弫席儯儱儳", num), obj9, flag ? BookmarkStart.b("儥ሧ尩缫席儯儱儳", num) : BookmarkStart.b("儥ሧ尩弫席儯儱儳", num), obj8, BookmarkStart.b("儥ሧ崩師伭䀯", num), str3, 
            flag ? BookmarkStart.b("儥ሧ尩洫䀭匯娱嬳䐵", num) : BookmarkStart.b("儥ሧ尩䴫䀭匯娱嬳䐵", num), str5, flag ? BookmarkStart.b("儥ሧ䈩洫䀭匯娱嬳䐵", num) : BookmarkStart.b("儥ሧ䈩䴫䀭匯娱嬳䐵", num), str4, BookmarkStart.b("儥ሧ利", num), obj10, flag ? BookmarkStart.b("儥ሧ利洫䈭夯唱娳", num) : BookmarkStart.b("儥ሧ利ī伭尯嬱匳堵", num), str6, BookmarkStart.b("儥ሧ匩", num), obj11, flag ? BookmarkStart.b("儥ሧ匩洫䈭夯唱娳", num) : BookmarkStart.b("儥ሧ匩ī伭尯嬱匳堵", num), str7, flag ? BookmarkStart.b("儥ሧ䬩䈫䴭堯崱䘳稵圷夹圻", num) : BookmarkStart.b("儥ሧ䬩䈫䴭堯崱䘳ᬵ吷唹弻唽", num), obj12
         });
        class2.method_22(BookmarkStart.b("儥ሧ崩䔫䨭弯䔱眳夵嘷丹主儽ⰿ", num), obj13);
        bool flag2 = listLevelNumber != null;
        bool flag3 = obj14 != null;
        string str13 = flag ? null : ((Class421) A_2).method_55();
        string str14 = flag ? null : ((Class421) A_2).method_56();
        bool flag4 = (class4 != null) && class4.method_4();
        if ((flag2 || flag3) || ((flag4 || (str13 != null)) || (str14 != null)))
        {
            class2.method_4(flag ? BookmarkStart.b("儥ሧ䐩夫䌭怯䀱", num) : BookmarkStart.b("儥ሧ䘩䔫崭䐯戱䘳", num));
            if (flag2)
            {
                class2.method_22(BookmarkStart.b("儥ሧ䌩䀫堭尯", num), listLevelNumber);
            }
            if (flag3)
            {
                class2.method_22(flag ? BookmarkStart.b("儥ሧ䐩夫䌭礯嘱", num) : BookmarkStart.b("儥ሧ䌩䀫䠭弯", num), obj14);
            }
            if (str13 != null)
            {
                class2.method_24(BookmarkStart.b("儥倧ဩ堫", num), str13);
            }
            if (str14 != null)
            {
                class2.method_24(BookmarkStart.b("儥倧ဩ䨫䄭帯䘱", num), str14);
            }
            if (flag4)
            {
                class2.vmethod_10(class4, A_2.imethod_6());
            }
            class2.method_5();
        }
        class2.method_22(flag ? BookmarkStart.b("儥ሧ天夫席䀯䀱儳䔵䬷瘹唻倽┿ుㅃ⭅⩇⽉㹋㵍", num) : BookmarkStart.b("儥ሧ天夫席䈯圱䜳䔵琷匹刻嬽฿㝁⥃⑅ⵇ㡉㽋", num), obj16);
        class2.method_46(BookmarkStart.b("儥ሧ娩渫䨭䈯", num), flag, new object[] { BookmarkStart.b("儥ሧ帩䌫席", num), top, BookmarkStart.b("儥ሧ䘩䤫䠭䐯", num), left, BookmarkStart.b("儥ሧ䠩䌫娭䐯崱夳", num), bottom, BookmarkStart.b("儥ሧ堩䔫䤭堯䘱", num), right, BookmarkStart.b("儥ሧ䠩䤫娭䜯圱儳堵", num), border5, BookmarkStart.b("儥ሧ䠩䴫尭", num), border6 });
        class2.vmethod_4(class3);
        smethod_3(tabs, A_2);
        class2.method_22(BookmarkStart.b("儥ሧ天夫席䀯䀱儳䔵䬷笹䤻䨽⼿ੁ㵃㙅⁇⽉≋㵍", num), obj17);
        class2.method_22(BookmarkStart.b("儥ሧ䄩䔫䀭䌯崱弳䌵", num), obj18);
        class2.method_22(BookmarkStart.b("儥ሧ崩䌫尭启攱䘳圵䠷", num), obj19);
        class2.method_22(BookmarkStart.b("儥ሧ䔩娫䬭䈯吱堳夵伷樹䤻倽⌿㙁", num), obj20);
        class2.method_22(BookmarkStart.b("儥ሧ帩䌫席簯嬱娳匵样伹刻崽㐿", num), obj21);
        class2.method_22(BookmarkStart.b("儥ሧ䬩夫娭弯愱䐳圵嬷弹砻笽", num), obj22);
        class2.method_22(BookmarkStart.b("儥ሧ䬩夫娭弯愱䐳圵嬷弹砻瀽", num), obj23);
        class2.method_22(BookmarkStart.b("儥ሧ䠩䔫䨭夯", num), obj24);
        class2.method_22(BookmarkStart.b("儥ሧ䬩䠫䐭䔯䄱䀳搵儷崹吻䨽िⱁ⁃", num), obj25);
        class2.method_22(BookmarkStart.b("儥ሧ天䈫伭䀯昱嬳焵䨷匹堻", num), obj26);
        class2.method_33(BookmarkStart.b("儥ሧ天尫伭匯嬱娳儵", num), new object[] { BookmarkStart.b("儥ሧ䠩䤫䠭弯䀱儳", num), class2.method_23(obj27, 20f), flag ? BookmarkStart.b("儥ሧ䠩䤫䠭弯䀱儳稵儷吹夻䴽", num) : BookmarkStart.b("儥ሧ䠩䤫䠭弯䀱儳ᬵ吷匹刻嬽㌿", num), class2.method_23(obj28, 100f), flag ? BookmarkStart.b("儥ሧ䠩䤫䠭弯䀱儳眵䴷丹医䴽〿⍁❃⽅♇ⵉ", num) : BookmarkStart.b("儥ሧ䠩䤫䠭弯䀱儳ᬵ夷伹䠻儽㌿㉁╃╅ⅇ⑉⭋", num), obj29, BookmarkStart.b("儥ሧ䬩䨫娭唯䀱", num), class2.method_23(obj30, 20f), flag ? BookmarkStart.b("儥ሧ䬩䨫娭唯䀱砳張嘷弹伻", num) : BookmarkStart.b("儥ሧ䬩䨫娭唯䀱ᤳ娵儷吹夻䴽", num), class2.method_23(obj31, 100f), flag ? BookmarkStart.b("儥ሧ䬩䨫娭唯䀱申䌵䰷唹伻丽ℿ⅁ⵃ⡅⽇", num) : BookmarkStart.b("儥ሧ䬩䨫娭唯䀱ᤳ圵䴷丹医䴽〿⍁❃⽅♇ⵉ", num), obj32, BookmarkStart.b("儥ሧ䘩䔫䀭唯", num), class2.method_23(obj33, 20f), flag ? BookmarkStart.b("儥ሧ䘩䔫䀭唯怱䄳娵崷", num) : BookmarkStart.b("儥ሧ䘩䔫䀭唯ἱ䘳䌵吷弹", num), str9 });
        class2.method_33(BookmarkStart.b("儥ሧ䌩䈫䨭", num), new object[] { BookmarkStart.b("儥ሧ䘩䤫䠭䐯", num), class2.method_23(obj35, 20f), BookmarkStart.b("儥ሧ堩䔫䤭堯䘱", num), class2.method_23(obj36, 20f), BookmarkStart.b("儥ሧ䈩䴫䀭圯嬱娳儵", num), class2.method_23(obj37, 20f), flag ? BookmarkStart.b("儥ሧ䰩䔫尭䌯䘱砳張嘷弹", num) : BookmarkStart.b("儥ሧ䰩䔫尭䌯䘱ᤳ娵儷吹夻", num), class2.method_23(obj38, 20f), flag ? BookmarkStart.b("儥ሧ䘩䤫䠭䐯焱尳圵䨷䤹", num) : BookmarkStart.b("儥ሧ䘩䤫䠭䐯ἱ圳帵夷䠹伻", num), class2.method_23(obj39, 100f), flag ? BookmarkStart.b("儥ሧ堩䔫䤭堯䘱眳帵夷䠹伻", num) : BookmarkStart.b("儥ሧ堩䔫䤭堯䘱ᤳ唵倷嬹主䴽", num), class2.method_23(obj40, 100f), flag ? BookmarkStart.b("儥ሧ䈩䴫䀭圯嬱娳儵笷刹崻䰽㌿", num) : BookmarkStart.b("儥ሧ䈩䴫䀭圯嬱娳儵ᔷ夹吻弽㈿ㅁ", num), class2.method_23(obj41, 100f), flag ? BookmarkStart.b("儥ሧ䰩䔫尭䌯䘱砳張嘷弹缻嘽ℿぁ㝃", num) : BookmarkStart.b("儥ሧ䰩䔫尭䌯䘱ᤳ娵儷吹夻ጽ⌿⩁╃㑅㭇", num), class2.method_23(obj42, 100f) });
        class2.method_22(BookmarkStart.b("儥ሧ䤩䌫䀭䐯圱䰳䈵䴷嬹倻洽〿⍁❃⽅♇ⵉ", num), obj43);
        class2.method_22(BookmarkStart.b("儥ሧ天夫席䀯䀱儳䔵䬷甹䨻嬽㈿⹁╃㙅", num), obj44);
        class2.method_24(BookmarkStart.b("儥ሧ䀩伫", num), str10);
        class2.method_24(BookmarkStart.b("儥ሧ帩䤫嘭䐯瘱崳䐵崷夹䠻圽⼿ⱁ", num), str11);
        class2.method_24(BookmarkStart.b("儥ሧ帩䤫嘭䐯猱堳張強吹儻嬽⸿㙁", num), str12);
        class2.method_22(BookmarkStart.b("儥ሧ䔩夫娭尯嬱娳匵琷䰹倻", num), obj45);
        if (flag)
        {
            class2.method_22(BookmarkStart.b("儥ሧ䜩䔫尭䈯崱䘳缵嘷帹夻倽㐿ㅁ", num), obj34);
        }
        return true;
    }

    private static void smethod_3(TabCollection A_0, Interface52 A_1)
    {
        int num = 0x12;
        if ((A_0 != null) && (A_0.Count != 0))
        {
            Class398 class2 = A_1.imethod_1();
            class2.method_4(BookmarkStart.b("伷9䠻弽∿ㅁ", num));
            for (int i = 0; i < A_0.Count; i++)
            {
                Tab tab = A_0[i];
                string str = Class248.smethod_21(tab.TabLeader, A_1.imethod_2());
                int num3 = Math.Max(Convert.ToInt32((float) (tab.Position * 20f)), -31680);
                int num4 = Math.Max(Convert.ToInt32(tab.DeletePosition), -31680);
                if ((tab.Position == 0f) && (tab.DeletePosition != 0f))
                {
                    class2.method_33(BookmarkStart.b("伷9䠻弽∿", num), new object[] { BookmarkStart.b("伷9䨻弽ⰿ", num), BookmarkStart.b("嬷嘹夻弽㈿", num), BookmarkStart.b("伷9倻嬽ℿ♁⅃㑅", num), (str != BookmarkStart.b("嘷唹刻嬽", num)) ? str : null, BookmarkStart.b("伷9䰻儽㌿", num), num4 });
                }
                else
                {
                    class2.method_33(BookmarkStart.b("伷9䠻弽∿", num), new object[] { BookmarkStart.b("伷9䨻弽ⰿ", num), Class248.smethod_23(tab.Justification, A_1.imethod_2()), BookmarkStart.b("伷9倻嬽ℿ♁⅃㑅", num), (str != BookmarkStart.b("嘷唹刻嬽", num)) ? str : null, BookmarkStart.b("伷9䰻儽㌿", num), num3 });
                }
            }
            class2.method_5();
        }
    }
}

