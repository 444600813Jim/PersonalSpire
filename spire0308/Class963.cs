using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Drawing;
using System.Text;

internal class Class963
{
    private Class963()
    {
    }

    internal static void smethod_0(ShapeBase A_0, Class398 A_1, Interface48 A_2)
    {
        smethod_1(A_0, false, A_1, A_2);
    }

    internal static void smethod_1(ShapeBase A_0, bool A_1, Class398 A_2, Interface48 A_3)
    {
        int num = 11;
        string str = BookmarkStart.b("䜰ल䘴弶堸䬺堼", 11);
        string item = null;
        bool flag = false;
        switch (A_0.ShapeType)
        {
            case ShapeType.OleObject:
                item = string.Format(BookmarkStart.b("ሰ氲䴴ܶस଺഼怾㕀㡂畄㩆", num), 0x4b);
                flag = true;
                break;

            case ShapeType.Group:
                str = BookmarkStart.b("䜰ल刴䔶嘸为䴼", num);
                break;

            case ShapeType.NonPrimitive:
                str = BookmarkStart.b("䜰ल䘴弶堸䬺堼", num);
                break;

            case ShapeType.Rectangle:
                str = BookmarkStart.b("䜰ल䜴制娸伺", num);
                break;

            case ShapeType.RoundRectangle:
                str = BookmarkStart.b("䜰ल䜴堶䰸唺夼䴾⑀⁂ㅄ", num);
                break;

            case ShapeType.Ellipse:
                str = BookmarkStart.b("䜰ल娴䄶堸场", num);
                break;

            case ShapeType.Line:
                str = BookmarkStart.b("䜰ल头帶圸帺", num);
                break;

            default:
                item = string.Format(BookmarkStart.b("ሰ氲䴴ܶस଺഼怾㕀㡂畄㩆", num), (int) A_0.ShapeType);
                flag = true;
                break;
        }
        if (A_1)
        {
            str = BookmarkStart.b("䜰ल圴嘶娸债娼䴾⹀㙂⭄⍆", num);
        }
        Class965 class3 = new Class965(A_0, A_2, A_3);
        Class82 class4 = new Class82(A_0, A_2, A_3);
        Class333 class2 = new Class333(A_0, A_2, A_3);
        Class845 class5 = new Class845(A_2);
        Class235 class6 = new Class235(A_2);
        Class234 class7 = new Class234(A_0, A_2);
        Class686 class8 = new Class686(A_2);
        Class332 class9 = new Class332(A_2);
        Class1039 class10 = new Class1039(A_3, A_2);
        Class788 class11 = new Class788(A_2);
        Class844 class12 = new Class844(A_2);
        string str3 = null;
        string str4 = null;
        Hashtable hashtable = new Hashtable();
        Class43 shapePr = A_0.ShapePr;
        for (int i = 0; i < shapePr.Count; i++)
        {
            int num2 = shapePr.method_18(i);
            object obj2 = shapePr.method_19(i);
            int num8 = num2 & -64;
            if (num8 <= 0x180)
            {
                if (num8 <= 0xc0)
                {
                    if (num8 != 0x40)
                    {
                        if (num8 != 0xc0)
                        {
                            goto Label_029D;
                        }
                        class8.method_0(num2, obj2);
                    }
                    else
                    {
                        class9.method_0(num2, obj2);
                    }
                }
                else
                {
                    switch (num8)
                    {
                        case 0x100:
                        {
                            class2.method_0(num2, obj2);
                            continue;
                        }
                        case 320:
                        {
                            class7.method_0(num2, obj2);
                            continue;
                        }
                    }
                    if (num8 != 0x180)
                    {
                        goto Label_029D;
                    }
                    class3.method_0(num2, obj2);
                }
                continue;
            }
            switch (num8)
            {
                case 0x1c0:
                {
                    if (num2 == 0x1fb)
                    {
                        class7.method_0(num2, obj2);
                    }
                    else
                    {
                        class4.method_0(num2, obj2);
                    }
                    continue;
                }
                case 0x200:
                {
                    class5.method_0(num2, obj2);
                    continue;
                }
                case 640:
                case 0x2c0:
                {
                    class6.method_0(num2, obj2);
                    continue;
                }
                case 0x340:
                {
                    class11.method_0(num2, obj2);
                    continue;
                }
                case 0x500:
                {
                    class10.method_0(num2, obj2);
                    continue;
                }
            }
        Label_029D:
            switch (num2)
            {
                case 0x85:
                {
                    hashtable[num2] = Class1085.smethod_54((TextBoxWrapMode) obj2);
                    continue;
                }
                case 0x87:
                {
                    hashtable[num2] = Class1085.smethod_52((TextBoxAnchor) obj2);
                    continue;
                }
                case 190:
                {
                    if ((bool) obj2)
                    {
                        hashtable[num2] = BookmarkStart.b("䔰", num);
                    }
                    continue;
                }
                case 0x303:
                {
                    hashtable[num2] = Class1085.smethod_58((ConnectorType) obj2);
                    continue;
                }
                case 0x304:
                case 0x305:
                case 0x306:
                {
                    hashtable[num2] = Class1085.smethod_6((BWMode) obj2);
                    continue;
                }
                case 0x309:
                {
                    str3 = Class1041.smethod_8((int) obj2);
                    continue;
                }
                case 0x30a:
                {
                    str4 = Class1041.smethod_8((int) obj2);
                    continue;
                }
                case 0x33c:
                {
                    class9.method_0(num2, obj2);
                    continue;
                }
                case 900:
                case 0x385:
                case 0x386:
                case 0x387:
                {
                    hashtable[num2] = Class969.smethod_42((int) obj2);
                    continue;
                }
                case 0x38f:
                {
                    HorizontalPosition position2 = (HorizontalPosition) obj2;
                    if (position2 != HorizontalPosition.None)
                    {
                        hashtable[num2] = Class417.smethod_18(position2);
                    }
                    continue;
                }
                case 0x390:
                {
                    HorizontalOrigin origin2 = (HorizontalOrigin) obj2;
                    if (origin2 != HorizontalOrigin.Column)
                    {
                        hashtable[num2] = Class417.smethod_16(origin2);
                    }
                    continue;
                }
                case 0x391:
                {
                    VerticalPosition position = (VerticalPosition) obj2;
                    if (position != VerticalPosition.None)
                    {
                        hashtable[num2] = Class417.smethod_23(position);
                    }
                    continue;
                }
                case 0x392:
                {
                    VerticalOrigin origin = (VerticalOrigin) obj2;
                    if (origin != VerticalOrigin.Paragraph)
                    {
                        hashtable[num2] = Class417.smethod_14(origin);
                    }
                    continue;
                }
                case 0x394:
                {
                    ShapeHorizontalAlignment alignment = (ShapeHorizontalAlignment) obj2;
                    if (alignment != ShapeHorizontalAlignment.Left)
                    {
                        hashtable[num2] = Class1085.smethod_10(alignment);
                    }
                    continue;
                }
                case 0x781:
                case 0x782:
                case 0x783:
                case 0x784:
                case 0x785:
                case 0x786:
                case 0x787:
                case 0x788:
                case 0x7bc:
                case 0x7bd:
                case 0x7be:
                case 0x7bf:
                {
                    class12.method_0(num2, obj2);
                    continue;
                }
                case 0x7c0:
                case 0x7c1:
                case 0x7c2:
                case 0x7c3:
                {
                    hashtable[num2] = Class1041.smethod_30((int) ((float) obj2));
                    continue;
                }
                case 0x7c4:
                {
                    hashtable[num2] = Class417.smethod_11((RelativeWidth) obj2);
                    continue;
                }
                case 0x7c5:
                {
                    hashtable[num2] = Class417.smethod_9((RelativeHeight) obj2);
                    continue;
                }
                case 0x1000:
                {
                    hashtable[num2] = Class1085.smethod_68((FlipOrientation) obj2);
                    continue;
                }
                case 0x1006:
                case 0x1007:
                case 0x1008:
                {
                    class2.method_0(num2, obj2);
                    continue;
                }
                case 0x100e:
                {
                    class4.method_0(num2, obj2);
                    continue;
                }
                case 0x100f:
                {
                    class3.method_0(num2, obj2);
                    continue;
                }
                case 0x101d:
                case 0x101e:
                case 0x101f:
                case 0x1020:
                {
                    hashtable[num2] = (int) obj2;
                    continue;
                }
            }
            hashtable[num2] = obj2;
        }
        if ((!A_3.imethod_7() && (hashtable[0x3b8] != null)) && ((bool) hashtable[0x3b8]))
        {
            string str7;
            if (hashtable[0x39a] != null)
            {
                str7 = hashtable[0x39a] as string;
            }
            else
            {
                str7 = Class1085.smethod_2(hashtable[920]);
            }
            A_2.method_4(BookmarkStart.b("䘰ल䘴吶䬸刺䴼䬾@ⵂ♄⽆♈㥊", num));
            A_2.method_11(BookmarkStart.b("䘰ल头嘶圸尺䠼帾♀♂", num), str7);
            A_2.method_11(BookmarkStart.b("䘰ल吴䔶常䠺", num), hashtable[0x397] as string);
            A_2.method_11(BookmarkStart.b("䘰ल䘴吶䬸刺䴼䬾ᕀ♂㵄㍆", num), hashtable[910] as string);
        }
        else
        {
            if ((!A_3.imethod_7() && flag) && !A_3.imethod_3().Contains(item))
            {
                A_3.imethod_3().Add(item);
                string str6 = Class565.smethod_0(A_0.ShapeType);
                if (Class567.smethod_16(str6))
                {
                    A_2.method_9(BookmarkStart.b("㰰㤲", num));
                    A_2.method_9(str6);
                    A_2.method_9(BookmarkStart.b("㰰㤲", num));
                }
            }
            if (class2.method_2() != null)
            {
                class2.method_4(A_3.imethod_1(class2.method_2()));
                if (Class567.smethod_16(class2.method_5()) && (class2.method_5() != class2.method_3()))
                {
                    class2.method_6(A_3.imethod_2(class2.method_5()));
                }
            }
            else if (Class567.smethod_16(class2.method_5()))
            {
                class2.method_4(A_3.imethod_2(class2.method_5()));
            }
            if (class3.method_3() != null)
            {
                class3.method_5(A_3.imethod_1(class3.method_3()));
            }
            if (class4.method_3() != null)
            {
                class4.method_5(A_3.imethod_1(class4.method_3()));
            }
            A_2.method_4(str);
            if (A_0.ShapeType == ShapeType.CustomShape)
            {
                string str8 = (string) hashtable[0x380];
                if (Class567.smethod_16(str8))
                {
                    if (A_0 is DocOleObject)
                    {
                        string str10 = Class734.smethod_3(A_0);
                        A_2.method_36(BookmarkStart.b("堰圲", num), str10);
                        A_2.method_36(BookmarkStart.b("帰ल䘴䜶倸强", num), str10);
                    }
                    else
                    {
                        A_2.method_36(BookmarkStart.b("堰圲", num), str8);
                        A_2.method_36(BookmarkStart.b("帰ल䘴䜶倸强", num), Class734.smethod_3(A_0));
                    }
                }
                else
                {
                    A_2.method_36(BookmarkStart.b("堰圲", num), Class734.smethod_3(A_0));
                }
                if (class4.method_6() == null)
                {
                    class4.method_7(BookmarkStart.b("尰娲䄴制䬸", num));
                }
                if (hashtable[0x101f] == null)
                {
                    hashtable[0x101f] = A_0.CoordSizeWidth;
                }
                if (hashtable[0x1020] == null)
                {
                    hashtable[0x1020] = A_0.CoordSizeHeight;
                }
            }
            else if (Class567.smethod_16((string) hashtable[0x380]))
            {
                if (A_0 is DocOleObject)
                {
                    string str11 = Class734.smethod_3(A_0);
                    A_2.method_36(BookmarkStart.b("堰圲", num), str11);
                    A_2.method_36(BookmarkStart.b("帰ल䘴䜶倸强", num), str11);
                }
                else
                {
                    A_2.method_36(BookmarkStart.b("堰圲", num), hashtable[0x380]);
                    A_2.method_36(BookmarkStart.b("帰ल䘴䜶倸强", num), Class734.smethod_3(A_0));
                }
                A_2.method_36(BookmarkStart.b("䔰䨲䔴制", num), item);
            }
            else
            {
                A_2.method_36(BookmarkStart.b("堰圲", num), Class734.smethod_3(A_0));
                A_2.method_36(BookmarkStart.b("䔰䨲䔴制", num), item);
                A_2.method_36(BookmarkStart.b("吰圲尴䌶堸䠺", num), class10.method_2());
            }
            if (A_0.IsInline && A_0.IsImage)
            {
                A_2.method_36(BookmarkStart.b("倰弲䄴", num), hashtable[0x381]);
            }
            else
            {
                A_2.method_36(BookmarkStart.b("夰䄲倴儶", num), hashtable[0x382]);
                A_2.method_36(BookmarkStart.b("䔰刲䜴倶尸伺", num), hashtable[0x1018]);
                A_2.method_36(BookmarkStart.b("䔰娲䄴嬶尸", num), hashtable[0x38d]);
                A_2.method_36(BookmarkStart.b("倰弲䄴", num), hashtable[0x381]);
            }
            if (!A_1)
            {
                Class558 class14 = new Class558();
                if (!A_0.IsInline)
                {
                    class14.method_2(BookmarkStart.b("䄰尲䘴帶䴸刺刼儾", num), BookmarkStart.b("倰儲䘴堶唸为䤼娾", num));
                }
                string str5 = "";
                if (A_0.IsTopLevel)
                {
                    str5 = BookmarkStart.b("尰刲䜴倶倸唺ြ", num);
                }
                if (A_0.ShapeType != ShapeType.Line)
                {
                    if (!A_0.IsInline)
                    {
                        if (A_0.IsTopLevel || (A_0.Left != 0.0))
                        {
                            class14.method_2(str5 + BookmarkStart.b("崰嘲匴䌶", num), Class734.smethod_19(A_0.Left, A_0.IsTopLevel));
                        }
                        if (A_0.IsTopLevel || (A_0.Top != 0.0))
                        {
                            class14.method_2(str5 + BookmarkStart.b("䔰尲䔴", num), Class734.smethod_19(A_0.Top, A_0.IsTopLevel));
                        }
                    }
                    if ((A_0.ShapeType != ShapeType.Image) && (A_0.ShapeType != ShapeType.OleObject))
                    {
                        class14.method_2(BookmarkStart.b("䘰娲儴䌶儸", num), Class734.smethod_19(A_0.Width, A_0.IsTopLevel));
                        class14.method_2(BookmarkStart.b("夰嘲尴倶儸伺", num), Class734.smethod_19(A_0.Height, A_0.IsTopLevel));
                    }
                    else
                    {
                        DocPicture imageData = (A_0 as ShapeObject).ImageData;
                        float num6 = imageData.WidthScale / 100f;
                        float num7 = imageData.HeightScale / 100f;
                        class14.method_2(BookmarkStart.b("䘰娲儴䌶儸", num), Class734.smethod_19(A_0.Width * num6, A_0.IsTopLevel));
                        class14.method_2(BookmarkStart.b("夰嘲尴倶儸伺", num), Class734.smethod_19(A_0.Height * num7, A_0.IsTopLevel));
                    }
                }
                object obj4 = hashtable[4];
                if (obj4 != null)
                {
                    class14.method_2(BookmarkStart.b("䌰尲䄴嘶䴸刺刼儾", num), Class734.smethod_14(Convert.ToInt32(obj4)));
                }
                if (Class567.smethod_16((string) hashtable[0x1000]))
                {
                    class14.method_2(BookmarkStart.b("地弲尴䜶", num), (string) hashtable[0x1000]);
                }
                if (A_0.IsTopLevel && !A_0.IsInline)
                {
                    if (A_0.BehindText && (A_0.ZOrder > 0L))
                    {
                        class14.method_4(BookmarkStart.b("䬰Ḳ尴夶崸帺䔼", num), (double) A_0.ZOrderEx);
                    }
                    else
                    {
                        class14.method_4(BookmarkStart.b("䬰Ḳ尴夶崸帺䔼", num), (double) A_0.ZOrder);
                    }
                }
                if (hashtable[0x3be] != null)
                {
                    class14.method_2(BookmarkStart.b("䜰娲䘴帶嬸刺儼嘾㕀㩂", num), ((bool) hashtable[0x3be]) ? BookmarkStart.b("夰娲儴匶尸唺", num) : BookmarkStart.b("䜰娲䘴帶嬸场堼", num));
                }
                if (hashtable[0x3b9] != null)
                {
                    class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀♂⅄⹆㵈⹊⥌", num), ((bool) hashtable[0x3b9]) ? "" : BookmarkStart.b("地", num));
                }
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒㥔㉖㽘⽚", num), Class734.smethod_18(hashtable[900], A_0.IsTopLevel));
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒⅔㡖⥘", num), Class734.smethod_18(hashtable[0x385], A_0.IsTopLevel));
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒❔㹖㹘㍚⥜", num), Class734.smethod_18(hashtable[0x386], A_0.IsTopLevel));
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀❂ⱄ㑆㵈⩊⍌ⱎ㑐繒㝔㡖ⵘ⽚㉜㉞", num), Class734.smethod_18(hashtable[0x387], A_0.IsTopLevel));
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈⍊≌㵎㡐⥒㩔㥖ⵘ㩚ㅜ", num), (string) hashtable[0x38f]);
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈⍊≌㵎㡐⥒㩔㥖ⵘ㩚ㅜ牞፠٢।٦ᵨɪ᭬੮", num), (string) hashtable[0x390]);
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈㵊⡌㵎═㩒㙔㙖㕘", num), (string) hashtable[0x391]);
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈㵊⡌㵎═㩒㙔㙖㕘癚⽜㩞ൠɢᅤ๦Ὠ๪", num), (string) hashtable[0x392]);
                if (A_3.imethod_7())
                {
                    class14.method_2(BookmarkStart.b("尰䀲娴ᨶ唸帺嬼䬾汀㍂⁄㕆⩈⹊⍌㭎", num), (string) hashtable[0x7c2]);
                    class14.method_2(BookmarkStart.b("尰䀲娴ᨶ䴸吺䴼ሾㅀ♂㝄⑆ⱈ╊㥌", num), (string) hashtable[0x7c3]);
                    class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸刺夼䬾⥀湂㕄≆㭈⡊⡌ⅎ═", num), (string) hashtable[0x7c0]);
                    class14.method_2(BookmarkStart.b("尰䀲娴ᨶ儸帺吼堾⥀㝂桄㝆ⱈ㥊⹌⩎㽐❒", num), (string) hashtable[0x7c1]);
                    class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸刺夼䬾⥀湂㝄≆╈⩊㥌♎❐㙒", num), (string) hashtable[0x7c4]);
                    class14.method_2(BookmarkStart.b("尰䀲娴ᨶ儸帺吼堾⥀㝂桄㕆ⱈ❊ⱌ㭎㡐╒ご", num), (string) hashtable[0x7c5]);
                }
                class14.method_2(BookmarkStart.b("尰䀲娴ᨶ丸䤺尼伾汀あㅄ㹆╈⹊", num), (string) hashtable[0x85]);
                class14.method_2(BookmarkStart.b("䜰Ḳ䄴制䄸伺ြ帾⽀⁂ⵄ⡆㭈", num), (string) hashtable[0x87]);
                A_2.method_40(BookmarkStart.b("䈰䜲䰴嬶尸", num), Class734.smethod_2(class14));
            }
            if (hashtable[780] != null)
            {
                A_2.method_40(BookmarkStart.b("吰䈲䀴嘶䴸刺刼儾㥀⹂⥄", num), Encoding.UTF8.GetString((byte[]) hashtable[780]));
            }
            A_2.method_38(BookmarkStart.b("䘰ल䄴弶尸嘺堼簾⹀⽂⩄㕆", num), hashtable[0x1033]);
            A_2.method_38(BookmarkStart.b("䘰ल䄴弶尸嘺堼氾⥀≂⅄≆", num), hashtable[0x1034]);
            A_2.method_38(BookmarkStart.b("䘰ल䄴弶尸嘺堼款⡀ⵂㅄ", num), hashtable[0x1035]);
            A_2.method_38(BookmarkStart.b("帰ल圴䀶吸吺夼娾", num), hashtable[0x304]);
            A_2.method_38(BookmarkStart.b("帰ल圴䀶䤸为似娾", num), hashtable[0x305]);
            A_2.method_38(BookmarkStart.b("帰ल圴䀶圸吺似刾⁀⽂", num), hashtable[0x306]);
            if (!A_1)
            {
                A_2.method_36(BookmarkStart.b("帰ल娴嬶尸刺帼倾⽀", num), hashtable[0x33a]);
            }
            if (A_0.IsInline && A_0.IsOle)
            {
                A_2.method_18(BookmarkStart.b("帰ल娴嬶尸", num), "");
            }
            if (A_0.IsInline)
            {
                A_2.method_40(BookmarkStart.b("帰ल圴堶䬸强堼䴾㕀ⱂ㕄⑆♈❊≌㵎", num), Class734.smethod_23((Class1031) hashtable[0x100a]));
                A_2.method_40(BookmarkStart.b("帰ल圴堶䬸强堼䴾ⵀ♂⍄㍆⩈⑊⅌⁎⍐", num), Class734.smethod_23((Class1031) hashtable[0x100b]));
                A_2.method_40(BookmarkStart.b("帰ल圴堶䬸强堼䴾⍀ⱂㅄ㍆♈♊⹌⁎㵐㱒❔", num), Class734.smethod_23((Class1031) hashtable[0x100c]));
                A_2.method_40(BookmarkStart.b("帰ल圴堶䬸强堼䴾㍀⩂≄⽆㵈⡊≌⍎㹐⅒", num), Class734.smethod_23((Class1031) hashtable[0x100d]));
            }
            switch (A_0.ShapeType)
            {
                case ShapeType.RoundRectangle:
                    A_2.method_36(BookmarkStart.b("倰䄲嘴䐶倸䄺堼", num), Class734.smethod_10(smethod_7(A_0)));
                    break;

                case ShapeType.Line:
                    A_2.method_36(BookmarkStart.b("地䄲娴娶", num), Class734.smethod_17(A_0.Left, A_0.Top, A_0.IsTopLevel));
                    A_2.method_36(BookmarkStart.b("䔰尲", num), Class734.smethod_17(A_0.Left + A_0.Width, A_0.Top + A_0.Height, A_0.IsTopLevel));
                    break;
            }
            smethod_3(A_2, hashtable, 0x101d, 0x101e, BookmarkStart.b("到尲娴䔶崸吺似嘾♀⩂⭄", num));
            smethod_3(A_2, hashtable, 0x101f, 0x1020, BookmarkStart.b("到尲娴䔶崸䠺吼䔾⑀", num));
            A_2.method_35(BookmarkStart.b("帰ल吴嬶唸吺䨼嘾⽀⁂⁄⭆╈", num), hashtable[0x3b0], true);
            A_2.method_35(BookmarkStart.b("帰ल吴嬶唸吺䨼倾㝀♂㝄⭆⡈㭊", num), hashtable[950], true);
            if (A_0.ShapeType == ShapeType.CustomShape)
            {
                A_2.method_36(BookmarkStart.b("帰ल䘴䜶䴸", num), BookmarkStart.b("0̲Դ", num));
            }
            if (str3 != null)
            {
                A_2.method_40(BookmarkStart.b("帰ल儴倶吸场尼䘾⹀㙂ㅄ", num), str3);
            }
            if (str4 != null)
            {
                A_2.method_40(BookmarkStart.b("帰ल儴倶吸唺刼嬾⑀⡂ⱄ⥆ⵈ", num), str4);
            }
            A_2.method_36(BookmarkStart.b("帰ल嘴堶圸唺堼尾㕀ⱂ㝄㍆え㭊⡌", num), hashtable[0x303]);
            class7.method_1();
            class7.method_2();
            A_2.method_36(BookmarkStart.b("帰ल䔴䔶尸崺堼䴾㍀♂⥄♆㵈≊㭌⩎", num), hashtable[0x33b]);
            A_2.method_36(BookmarkStart.b("帰ल圴䈶䴸伺刼儾", num), hashtable[0x3bc]);
            A_2.method_36(BookmarkStart.b("帰ल崴䔶䤸堺䤼", num), hashtable[0x393]);
            A_2.method_36(BookmarkStart.b("帰ल崴䔶堸场吼堾⽀", num), hashtable[0x394]);
            A_2.method_36(BookmarkStart.b("帰ल崴䔶䨸伺夼", num), hashtable[0x3b2]);
            A_2.method_36(BookmarkStart.b("帰ल崴䔶圸吺丼圾⁀❂⁄", num), hashtable[0x3b3]);
            A_2.method_36(BookmarkStart.b("帰ल崴䔶", num), hashtable[0x3b4]);
            A_2.method_36(BookmarkStart.b("帰ल圴䈶唸场堼䬾", num), hashtable[0x3b1]);
            smethod_2(A_2, (Class891[]) hashtable[0x383]);
            class3.method_1();
            if (!A_1)
            {
                class4.method_1();
            }
            class3.method_2();
            class4.method_2();
            class2.method_1();
            class5.method_1();
            class6.method_1();
            if (str == BookmarkStart.b("䜰ल䘴弶堸䬺堼", num))
            {
                class7.method_4();
                class7.method_5();
                class8.method_1();
                class7.method_10();
            }
            if (!A_1)
            {
                class9.method_1();
            }
            if (A_0.InkData != null)
            {
                A_2.method_4(BookmarkStart.b("帰ल尴夶券", num));
                A_2.method_44(BookmarkStart.b("堰", num), A_0.InkData);
                A_2.method_36(BookmarkStart.b("倰崲嬴堶䴸娺䤼嘾⹀ⵂ", num), A_0.InkAnnotation);
                A_2.method_5();
            }
            class12.method_1();
            class10.method_1();
            class11.method_1();
            smethod_6(BookmarkStart.b("䘰ȲԴശ嬸吺似嬾⑀ㅂㅄ⡆㥈", num), A_0.ShapePr[0x100a], A_2);
            smethod_6(BookmarkStart.b("䘰ȲԴശ嬸吺似嬾⑀ㅂ⥄≆⽈㽊", num), A_0.ShapePr[0x100b], A_2);
            smethod_6(BookmarkStart.b("䘰ȲԴശ嬸吺似嬾⑀ㅂ❄⡆㵈㽊≌≎", num), A_0.ShapePr[0x100c], A_2);
            smethod_6(BookmarkStart.b("䘰ȲԴശ嬸吺似嬾⑀ㅂ㝄⹆⹈⍊㥌", num), A_0.ShapePr[0x100d], A_2);
            bool flag2 = A_3.imethod_4().class335_0.Interface34.imethod_3(A_0.Id);
            if (!A_0.IsGroup && ((A_0.HasChildElements || flag2) || (A_0.ShapeType == ShapeType.TextBox)))
            {
                A_2.method_4(BookmarkStart.b("䜰ल䄴制䄸伺弼倾㥀", num));
                Class558 class15 = new Class558();
                if (hashtable.Contains(0x88))
                {
                    LayoutFlow flow = (LayoutFlow) hashtable[0x88];
                    if (flow == LayoutFlow.BottomToTop)
                    {
                        class15.method_2(BookmarkStart.b("崰刲䰴堶䰸伺ြ夾ⵀⱂ㉄", num), BookmarkStart.b("䜰嘲䜴䌶倸堺尼匾", num));
                        class15.method_2(BookmarkStart.b("尰䀲娴ᨶ唸娺䐼倾㑀㝂桄ⅆ╈⑊㩌扎ぐ㽒⅔", num), BookmarkStart.b("匰尲䄴䌶嘸嘺ြ䬾⹀湂ㅄ⡆㥈", num));
                    }
                    else
                    {
                        class15.method_2(BookmarkStart.b("崰刲䰴堶䰸伺ြ夾ⵀⱂ㉄", num), Class1085.smethod_46(flow));
                    }
                }
                int textboxNextShapeId = A_0.TextboxNextShapeId;
                if ((textboxNextShapeId != 0) && A_3.imethod_4().hashtable_0.ContainsKey(textboxNextShapeId))
                {
                    ShapeObject obj3 = (ShapeObject) A_3.imethod_4().hashtable_0[textboxNextShapeId];
                    string str9 = Class567.smethod_16(obj3.Name) ? string.Format(BookmarkStart.b("ሰ䠲Դ䨶", num), obj3.Name) : string.Format(BookmarkStart.b("ሰ氲䴴ܶस଺഼怾㉀㡂畄㩆", num), textboxNextShapeId);
                    class15.method_2(BookmarkStart.b("尰䀲娴ᨶ圸帺䔼䬾汀㝂⁄㽆㵈⥊≌㝎", num), str9);
                }
                class15.method_2(BookmarkStart.b("尰䀲娴ᨶ弸刺䤼ሾ㉀⭂⑄㝆ⱈ晊㥌⁎籐❒ご⽖ⵘ", num), (string) hashtable[190]);
                A_2.method_36(BookmarkStart.b("䈰䜲䰴嬶尸", num), Class734.smethod_2(class15));
                A_2.method_36(BookmarkStart.b("堰崲䘴制䴸", num), Class734.smethod_8(hashtable));
                A_2.method_4(BookmarkStart.b("䘰ल䄴伶嬸䌺縼倾⽀㝂⁄⥆㵈", num));
                if (!A_0.HasChildElements && flag2)
                {
                    A_2.method_6(BookmarkStart.b("䘰ल䄴伶嬸䌺縼倾⽀㝂⁄⥆㵈", num));
                    A_2.method_6(BookmarkStart.b("䜰ल䄴制䄸伺弼倾㥀", num));
                }
            }
        }
    }

    private static void smethod_2(Class398 A_0, Class891[] A_1)
    {
        int num = 5;
        if ((A_1 != null) && (A_1.Length > 0))
        {
            A_0.method_40(BookmarkStart.b("尪弬丮䄰倲娴堶䬸强丼", num), Class734.smethod_32(A_1, ' ', ' '));
        }
    }

    private static void smethod_3(Class398 A_0, Hashtable A_1, int A_2, int A_3, string A_4)
    {
        object obj2 = A_1[A_2];
        object obj3 = A_1[A_3];
        if ((obj2 != null) && (obj3 != null))
        {
            A_0.method_36(A_4, Class734.smethod_16(new Point((int) obj2, (int) obj3)));
        }
    }

    internal static void smethod_4(ShapeBase A_0, Class398 A_1)
    {
        int num = 11;
        Class43 shapePr = A_0.ShapePr;
        string str2 = shapePr.HasKey(0x1001) ? Class1085.smethod_72((TextWrappingStyle) shapePr[0x1001]) : "";
        if (A_0.ShapePr.HasKey(0x1001))
        {
            string str4 = Class417.smethod_16(A_0.HorizontalOrigin);
            if (str4 == BookmarkStart.b("䔰嘲䴴䌶", num))
            {
                str4 = "";
            }
            string str = Class417.smethod_14(A_0.VerticalOrigin);
            if (str == BookmarkStart.b("䔰嘲䴴䌶", num))
            {
                str = "";
            }
            string str3 = shapePr.HasKey(0x1002) ? Class1085.smethod_56(A_0.TextWrappingType) : "";
            if (A_0.IsInline)
            {
                if ((str4 == BookmarkStart.b("到嬲吴䔶", num)) && (str == BookmarkStart.b("崰娲嬴制", num)))
                {
                    A_1.method_4(BookmarkStart.b("䘰ȲԴശ丸䤺尼伾", num));
                    A_1.method_36(BookmarkStart.b("䔰䨲䔴制", num), str2);
                    A_1.method_5();
                }
            }
            else if (Class567.smethod_16(str2))
            {
                A_1.method_4(BookmarkStart.b("䘰ȲԴശ丸䤺尼伾", num));
                A_1.method_36(BookmarkStart.b("䔰䨲䔴制", num), str2);
                A_1.method_36(BookmarkStart.b("䈰娲儴制", num), str3);
                A_1.method_5();
            }
            else if (Class567.smethod_16(str4) || Class567.smethod_16(str))
            {
                A_1.method_4(BookmarkStart.b("䘰ȲԴശ丸䤺尼伾", num));
                A_1.method_36(BookmarkStart.b("䈰娲儴制", num), str3);
                if (smethod_5(str4))
                {
                    A_1.method_36(BookmarkStart.b("倰崲嘴弶嘸䤺䔼", num), str4);
                }
                if (smethod_5(str))
                {
                    A_1.method_36(BookmarkStart.b("倰崲嘴弶嘸䤺䐼", num), str);
                }
                A_1.method_5();
            }
        }
        if (A_0.AnchorLocked)
        {
            A_1.method_10(BookmarkStart.b("䘰ȲԴശ堸唺帼圾⹀ㅂ⥄⡆⩈⁊", num));
        }
    }

    private static bool smethod_5(string A_0)
    {
        int num = 0x11;
        if (!(A_0 == BookmarkStart.b("娶堸䤺娼嘾⽀", 0x11)) && !(A_0 == BookmarkStart.b("䜶堸尺堼", num)))
        {
            return (A_0 == BookmarkStart.b("䌶尸䌺䤼", num));
        }
        return true;
    }

    private static void smethod_6(string A_0, object A_1, Class398 A_2)
    {
        int num = 14;
        if (A_1 is Border)
        {
            Border border = (Border) A_1;
            if (!border.IsDefault)
            {
                A_2.method_4(A_0);
                A_2.method_40(BookmarkStart.b("䀳伵䠷弹", num), Class1085.smethod_16(border.BorderType));
                A_2.method_40(BookmarkStart.b("䌳張尷丹吻", num), Class1041.smethod_46((double) (border.LineWidth * 8f)));
                A_2.method_40(BookmarkStart.b("䜳帵夷帹医䤽", num), Class734.smethod_11(border.Shadow, false));
                A_2.method_5();
            }
        }
    }

    private static int smethod_7(ShapeBase A_0)
    {
        object directShapeAttribute = A_0.GetDirectShapeAttribute(0x147);
        if (directShapeAttribute != null)
        {
            int num = (int) directShapeAttribute;
            double num2 = ((double) num) / ((double) A_0.CoordSizeWidth);
            return Class969.smethod_71(num2);
        }
        return 0x2aab;
    }
}

