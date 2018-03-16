using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;

internal class Class970
{
    private readonly Class400 class400_0;
    private readonly Class456[] class456_0;
    private int[] int_0;

    internal Class970(Class422 A_0)
    {
        this.class400_0 = A_0.method_18();
        this.class456_0 = null;
    }

    internal void method_0(ShapeObject A_0)
    {
        int num = 9;
        Class576.smethod_94(1.0);
        if (Class576.smethod_4(A_0.CoordSizeWidth, A_0.CoordSizeHeight))
        {
            Class576.smethod_3(A_0.CoordSizeWidth, A_0.CoordSizeHeight);
        }
        this.int_0 = smethod_1(A_0);
        if (A_0.ShapeType == ShapeType.RoundRectangle)
        {
            this.method_16(A_0);
        }
        else
        {
            Class400 class2 = this.class400_0;
            class2.method_4(BookmarkStart.b("䬮䌰刲䈴ശ尸唺唼帾⽀⁂⁄⍆摈ⱊ⡌⁎㱐㙒⅔╖⁘", num));
            this.method_1(A_0);
            this.method_5(A_0);
            class2.method_6(BookmarkStart.b("䬮䌰刲䈴ശ尸唺唼帾⽀⁂⁄⍆摈ⱊ⡌⁎㱐㙒⅔╖⁘", num));
        }
    }

    private void method_1(ShapeObject A_0)
    {
        int num = 0x11;
        this.class400_0.method_40(BookmarkStart.b("匶䬸娺䨼Ծ㕀㩂㕄≆", 0x11), BookmarkStart.b("夶嘸唺ြ伾㍀⩂⡄⹆㵈≊㭌⩎", 0x11));
        object obj2 = A_0.ShapePr.method_31(0xf1);
        if ((obj2 != null) && ((bool) obj2))
        {
            this.class400_0.method_40(BookmarkStart.b("匶䬸娺䨼Ծ㕀♂㵄㍆摈㭊ⱌ㭎㥐", num), BookmarkStart.b("䌶䬸为堼", num));
        }
        this.method_11(A_0);
        this.method_12(A_0);
        this.method_13(A_0);
        this.method_10(A_0);
        if ((A_0.FlipOrientation == FlipOrientation.Horizontal) || (A_0.FlipOrientation == FlipOrientation.Both))
        {
            this.class400_0.method_40(BookmarkStart.b("匶䬸娺䨼Ծⱀ⩂㝄㕆♈㥊恌❎㹐⅒㱔ⵖ㙘㕚⥜㹞ൠ", num), BookmarkStart.b("䌶䬸为堼", num));
        }
        if ((A_0.FlipOrientation == FlipOrientation.Vertical) || (A_0.FlipOrientation == FlipOrientation.Both))
        {
            this.class400_0.method_40(BookmarkStart.b("匶䬸娺䨼Ծⱀ⩂㝄㕆♈㥊恌㥎㑐⅒⅔㹖㩘㩚ㅜ", num), BookmarkStart.b("䌶䬸为堼", num));
        }
        this.method_4(A_0.ShapePr);
        object obj3 = A_0.ShapePr.method_31(0x158);
        if (obj3 != null)
        {
            this.class400_0.method_40(BookmarkStart.b("匶䬸娺䨼Ծ♀⽂い≆摈㭊≌♎㽐❒硔⍖⁘⭚㡜", num), Class922.smethod_3((ConnectionSiteType) obj3));
        }
        this.method_2(A_0.GetShapeAttribute(0x151));
        this.method_3(A_0.GetShapeAttribute(0x152));
    }

    private void method_10(ShapeObject A_0)
    {
        int num = 1;
        Class70[] textBoxRects = A_0.TextBoxRects;
        if ((textBoxRects != null) && (textBoxRects.Length > 0))
        {
            Class70 class2 = textBoxRects[(textBoxRects.Length == 1) ? 0 : 1];
            string str = string.Format(BookmarkStart.b("尦ᤨ嘪ബ吮0串ᔴ䰶ସ䘺ᴼ䐾牀㹂", num), new object[] { this.method_15(class2.class623_0), this.method_15(class2.class623_1), this.method_15(class2.class623_2), this.method_15(class2.class623_3) });
            this.class400_0.method_40(BookmarkStart.b("䌦嬨䨪娬ᔮ䔰嘲䴴䌶ᐸ娺似娾⁀あ", num), str);
        }
    }

    private void method_11(ShapeObject A_0)
    {
        int num = 0x10;
        string str = "";
        for (int i = 0; i < 10; i++)
        {
            object obj2 = A_0.ShapePr.method_31(0x147 + i);
            if (obj2 == null)
            {
                Class43 class2 = Class565.smethod_1(A_0.ShapeType);
                if (class2 != null)
                {
                    obj2 = class2.method_31(0x147 + i);
                }
            }
            if (obj2 != null)
            {
                int num3 = Class576.smethod_2((int) obj2);
                str = string.Format(BookmarkStart.b("䴵࠷䜹᰻䔽焿㽁", num), str, Class1041.smethod_8(num3));
            }
        }
        this.class400_0.method_40(BookmarkStart.b("刵䨷嬹䬻нⴿⵁ⁃⽅⹇⍉⥋㱍⍏", num), str.Trim());
    }

    private void method_12(ShapeBase A_0)
    {
        this.class400_0.method_40(BookmarkStart.b("天娫䤭ਯ䐱崳匵伷砹医䘽", 4), string.Format(BookmarkStart.b("儩ᰫ匭ု䤱Գ䬵ᠷ䄹฻䌽怿㥁睃㭅", 4), new object[] { 0, 0, Class576.smethod_2(A_0.CoordSizeWidth), Class576.smethod_2(A_0.CoordSizeHeight) }));
    }

    private void method_13(ShapeObject A_0)
    {
        int num = 9;
        Class679[] segmentInfo = A_0.SegmentInfo;
        Class891[] vertices = A_0.Vertices;
        if (vertices != null)
        {
            string str3 = "";
            string str = "";
            int num2 = 0;
            for (int i = 0; i < segmentInfo.Length; i++)
            {
                Class679 class2 = segmentInfo[i];
                if (class2.method_0() != PathType.Unknown)
                {
                    string str2 = Class922.smethod_6(class2.method_0());
                    if (Class567.smethod_16(str2))
                    {
                        int num4 = class2.method_2();
                        if ((str != str2) && ((!(str2 == BookmarkStart.b("眮", num)) && !(str2 == BookmarkStart.b("瘮", num))) || (!(str == BookmarkStart.b("眮", num)) && !(str == BookmarkStart.b("瘮", num)))))
                        {
                            str3 = string.Format(BookmarkStart.b("吮İ串ᔴ䰶࠸䘺", num), str3, str2);
                        }
                        for (int j = num2; j < (num2 + num4); j++)
                        {
                            Class891 class3 = vertices[j];
                            bool flag = ((class2.method_0() == PathType.AngleEllipse) || (class2.method_0() == PathType.AngleEllipseTo)) ? ((((j - num2) + 1) % 3) == 0) : false;
                            str3 = string.Format(BookmarkStart.b("吮İ串ᔴ䰶࠸䘺ᴼ䐾獀㹂", num), str3, this.method_14(class3.method_0(), flag), this.method_14(class3.method_1(), flag));
                        }
                        num2 += num4;
                        str = str2;
                    }
                }
            }
            this.class400_0.method_40(BookmarkStart.b("䬮䌰刲䈴ശ尸唺唼帾⽀⁂⁄⍆摈㭊ⱌ㭎㥐", num), str3.Trim());
        }
    }

    private string method_14(Class623 A_0, bool A_1)
    {
        int num = A_0.method_0() ? this.int_0[A_0.method_1()] : A_0.method_1();
        if (A_1)
        {
            num /= 0x10000;
        }
        else
        {
            num = Class576.smethod_2(num);
        }
        return Class1041.smethod_8(num);
    }

    private string method_15(Class623 A_0)
    {
        return this.method_14(A_0, false);
    }

    private void method_16(ShapeObject A_0)
    {
        int num = 13;
        Class400 class2 = this.class400_0;
        class2.method_4(BookmarkStart.b("圲䜴嘶丸ĺ堼儾⥀≂⭄⑆ⱈ⽊恌⡎㑐㱒㡔㉖ⵘ⥚⑜", 13));
        class2.method_40(BookmarkStart.b("圲䜴嘶丸ĺ䤼䘾ㅀ♂", 13), BookmarkStart.b("崲娴夶ᐸ䬺似嘾ⱀ⩂ㅄ⹆㽈⹊", 13));
        object obj2 = A_0.ShapePr.method_31(0x147);
        double num2 = 46.0;
        int num3 = (int) (((obj2 == null) ? ((double) 0) : ((double) ((int) obj2))) * num2);
        int num4 = (int) (21600.0 * num2);
        string str = string.Format(BookmarkStart.b("縲ᔴ䰶स䘺ᴼ༾慀ᭂ敄睆楈お経㉎煐ὒ畔杖祘⁚汜≞䅠㩢䕤ᱦ奨ᙪ䵬ᑮ䍰๲啴㭶奸z䱼ɾꆀ랄惘ꦈ펊권ꎐ떔ꢘ붜펞膠\ud8a2\u97a4\udaa6\u89a8킪鶬튮醰閴첶袸욺鶼达駂视", num), num3, num4 - num3, num4);
        class2.method_43(BookmarkStart.b("圲䜴嘶丸ĺ值倾╀⩂⍄⹆ⱈ㥊㹌", num), num3);
        class2.method_40(BookmarkStart.b("䀲䌴倶̸䴺吼娾㙀ł⩄㽆", num), string.Format(BookmarkStart.b("̲ᔴܶᤸ䀺഼䈾慀㡂畄㩆", num), num4));
        class2.method_40(BookmarkStart.b("圲䜴嘶丸ĺ堼儾⥀≂⭄⑆ⱈ⽊恌㽎ぐ❒㵔", num), str);
        this.method_10(A_0);
        class2.method_6(BookmarkStart.b("圲䜴嘶丸ĺ堼儾⥀≂⭄⑆ⱈ⽊恌⡎㑐㱒㡔㉖ⵘ⥚⑜", num));
    }

    private void method_2(object A_0)
    {
        int num = 8;
        if (A_0 != null)
        {
            string str = "";
            foreach (Class891 class2 in (Class891[]) A_0)
            {
                str = string.Format(BookmarkStart.b("唭/伱ᐳ䴵ष䜹᰻䔽爿㽁", num), str, this.method_15(class2.method_0()), this.method_15(class2.method_1()));
            }
            this.class400_0.method_40(BookmarkStart.b("䨭䈯匱䌳వ強嘹䤻嬽洿㉁⭃⽅♇㹉㽋", num), str.Trim(new char[] { ' ' }));
        }
    }

    private void method_3(object A_0)
    {
        int num = 13;
        if (A_0 != null)
        {
            string str = "";
            foreach (int num3 in (int[]) A_0)
            {
                str = string.Format(BookmarkStart.b("䠲Դ䨶ᔸᬺ䘼฾㱀", num), str, Class576.smethod_6(num3));
            }
            this.class400_0.method_40(BookmarkStart.b("圲䜴嘶丸ĺ娼匾㑀♂桄㝆♈≊⍌㭎籐㽒ご㙖⽘㉚㍜㡞䱠ݢ౤ᕦ౨ࡪᥬٮṰᵲٴ", num), str.Trim(BookmarkStart.b("ἲᔴ", num).ToCharArray()));
        }
    }

    private void method_4(Class43 A_0)
    {
        int num = 15;
        object obj2 = A_0.method_31(700);
        if ((obj2 != null) && ((bool) obj2))
        {
            int num2 = 50;
            int num3 = 0xe10000;
            int num4 = 0;
            int num5 = 0;
            int num6 = 5;
            int num7 = 0x6f9f0;
            int num8 = 0;
            bool flag = false;
            bool flag2 = false;
            int num9 = 0x4ccd;
            int num10 = 0;
            int num11 = 1;
            int num12 = 0x1339e0;
            int num13 = -1260000;
            int num14 = 0x895440;
            int num15 = 0x8000;
            int num16 = -32768;
            bool flag3 = true;
            ThreeDRenderMode fullRender = ThreeDRenderMode.FullRender;
            bool flag4 = true;
            bool flag5 = true;
            int num17 = 0x999a;
            int num18 = 0xc350;
            int num19 = 0;
            int num20 = 0x2710;
            bool flag6 = false;
            int num21 = 0x999a;
            int num22 = -50000;
            int num23 = 0;
            int num24 = 0x2710;
            int num25 = 0;
            int num26 = 0;
            int num27 = 0;
            bool flag7 = false;
            for (int i = 0; i < A_0.Count; i++)
            {
                int num29 = A_0.method_18(i);
                object obj3 = A_0.method_19(i);
                if (obj3 != null)
                {
                    switch (num29)
                    {
                        case 640:
                            num10 = (int) obj3;
                            break;

                        case 0x281:
                            num11 = (int) obj3;
                            break;

                        case 0x282:
                            num6 = (int) obj3;
                            break;

                        case 0x284:
                            num8 = (int) obj3;
                            break;

                        case 0x285:
                            num7 = (int) obj3;
                            break;

                        case 0x287:
                            flag2 = true;
                            break;

                        case 0x2bd:
                            flag = (bool) obj3;
                            break;

                        case 0x2bf:
                            flag4 = (bool) obj3;
                            break;

                        case 0x2c0:
                            num5 = (int) obj3;
                            break;

                        case 0x2c1:
                            num4 = (int) obj3;
                            break;

                        case 710:
                            num25 = (int) obj3;
                            break;

                        case 0x2c7:
                            num26 = (int) obj3;
                            break;

                        case 0x2c8:
                            num27 = (int) obj3;
                            break;

                        case 0x2c9:
                            fullRender = (ThreeDRenderMode) obj3;
                            break;

                        case 0x2cb:
                            num12 = (int) obj3;
                            break;

                        case 0x2cc:
                            num13 = (int) obj3;
                            break;

                        case 0x2cd:
                            num14 = (int) obj3;
                            break;

                        case 0x2ce:
                            num15 = (int) obj3;
                            break;

                        case 0x2cf:
                            num16 = (int) obj3;
                            break;

                        case 720:
                            num3 = (int) obj3;
                            break;

                        case 0x2d1:
                            num2 = (int) obj3;
                            break;

                        case 0x2d2:
                            num9 = (int) obj3;
                            break;

                        case 0x2d3:
                            num18 = (int) obj3;
                            break;

                        case 0x2d4:
                            num19 = (int) obj3;
                            break;

                        case 0x2d5:
                            num20 = (int) obj3;
                            break;

                        case 0x2d6:
                            num17 = (int) obj3;
                            break;

                        case 0x2d7:
                            num22 = (int) obj3;
                            break;

                        case 0x2d8:
                            num23 = (int) obj3;
                            break;

                        case 0x2d9:
                            num24 = (int) obj3;
                            break;

                        case 730:
                            num21 = (int) obj3;
                            break;

                        case 0x2fc:
                            flag7 = (bool) obj3;
                            break;

                        case 0x2fd:
                            flag3 = (bool) obj3;
                            break;

                        case 0x2fe:
                            flag5 = (bool) obj3;
                            break;

                        case 0x2ff:
                            flag6 = (bool) obj3;
                            break;
                    }
                }
            }
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ", num), BookmarkStart.b("䄴䔶䰸帺", num));
            if ((((num25 != 0) || (num26 != 0)) || (num27 != 0)) && !flag7)
            {
                this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⅒㩔⍖㡘⽚㑜ぞའ乢٤ɦݨὪ࡬ᵮ", num), string.Format(BookmarkStart.b("ᴴ䰶स䘺ᴼ䐾灀㹂敄㱆筈㙊摌", num), Class576.smethod_6(num25), Class576.smethod_6(num26), Class576.smethod_6(num27)));
            }
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㽒㱔ざㅘ⽚灜㥞`bd", num), flag4 ? "" : BookmarkStart.b("匴嘶唸䠺堼", num));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㕒㱔╖⩘⽚灜㍞ࡠѢ൤፦䑨ͪ౬ᵮɰ᭲", num), flag5 ? BookmarkStart.b("䄴䔶䰸帺", num) : BookmarkStart.b("匴嘶唸䠺堼", num));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㕒㱔╖⩘⽚灜㍞ࡠѢ൤፦䑨ݪ࡬᥮ᑰὲ", num), Class576.smethod_6(num17));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㕒㱔╖⩘⽚灜㍞ࡠѢ൤፦䑨ཪѬᵮᑰၲŴṶᙸᕺ", num), string.Format(BookmarkStart.b("ᴴ䰶स䘺ᴼ䐾灀㹂敄㱆筈㙊摌", num), Class576.smethod_6(num18), Class576.smethod_6(num19), Class576.smethod_6(num20)));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⁒ご㑖㙘㕚㥜牞ൠ੢ɤསᵨ䙪լ๮Ͱrᵴ", num), flag6 ? BookmarkStart.b("䄴䔶䰸帺", num) : BookmarkStart.b("匴嘶唸䠺堼", num));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⁒ご㑖㙘㕚㥜牞ൠ੢ɤསᵨ䙪Ŭ੮ݰᙲᥴ", num), Class576.smethod_6(num21));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⁒ご㑖㙘㕚㥜牞ൠ੢ɤསᵨ䙪६ٮͰᙲᙴͶၸᑺ፼", num), string.Format(BookmarkStart.b("ᴴ䰶स䘺ᴼ䐾灀㹂敄㱆筈㙊摌", num), Class576.smethod_6(num22), Class576.smethod_6(num23), Class576.smethod_6(num24)));
            if ((num15 != 0x8000) || (num16 != -32768))
            {
                this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㱒❔㹖㹘㉚㍜", num), string.Format(BookmarkStart.b("临ܶ䐸ᬺ䘼฾㱀", num), Class576.smethod_6(num15), Class576.smethod_6(num16)));
            }
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐╒㱔㉖⹘⭚㉜㙞འᝢ", num), string.Format(BookmarkStart.b("ᴴ䰶स䘺ᴼ䐾灀㹂敄㱆筈㙊摌", num), Class576.smethod_56(num12), Class576.smethod_56(num13), Class576.smethod_56(num14)));
            this.class400_0.method_40(BookmarkStart.b("儴䔶ਸ强ܼ䰾⥀≂⅄≆摈♊≌⭎㑐", num), (fullRender == ThreeDRenderMode.Wireframe) ? BookmarkStart.b("儴䔶堸崺䤼", num) : "");
            this.class400_0.method_40(BookmarkStart.b("儴䔶ਸ强ܼ伾㍀ⱂ⽄≆⩈㽊⑌⁎㽐", num), flag3 ? "" : BookmarkStart.b("䔴制䬸䠺䴼娾≀㝂ⱄㅆⱈ", num));
            if ((num4 != 0) || (num5 != 0))
            {
                this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⅒㩔⍖㡘⽚㑜ぞའ乢Ѥ०๨ݪ࡬", num), string.Format(BookmarkStart.b("临ܶ䐸ᬺ䘼฾㱀", num), Class576.smethod_6(num4), Class576.smethod_6(num5)));
            }
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⁒㹔㉖⹘", num), string.Format(BookmarkStart.b("临ܶ䐸ᬺ䘼฾㱀", num), Class1041.smethod_8(num2), Class576.smethod_6(num3)));
            if ((num7 != 0x6f9f0) || (num8 != 0))
            {
                this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㝒ご❖ⵘ㍚", num), string.Format(BookmarkStart.b("临ܶ䐸ᬺ䘼฾㱀", num), Class576.smethod_56(num7), (num8 > num7) ? BookmarkStart.b("Դᤶస", num) : Class1041.smethod_47(Class969.smethod_42(num8))));
            }
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐げ㩔㭖㙘⥚", num), flag2 ? BookmarkStart.b("䄴䔶䰸帺", num) : "");
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⁒╔㉖㩘⹚ㅜ㹞፠੢ᅤṦ", num), (num10 == 0) ? "" : Class576.smethod_27(num10));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㝒㱔ㅖ㽘⹚⹜㙞๠ൢ", num), (num11 == 1) ? "" : Class576.smethod_27(num11));
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐㹒ご⍖㡘㝚", num), flag ? BookmarkStart.b("䄴䔶䰸帺", num) : "");
            this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐ㅒ❔㹖㹘㍚⥜ㅞѠၢᙤ", num), Class576.smethod_27(num9));
            if (num6 != 5)
            {
                this.class400_0.method_40(BookmarkStart.b("儴䔶堸䰺ܼ娾㥀㝂㝄㉆㩈≊≌ⅎ籐⁒㵔㹖㝘㉚㍜㩞በၢ", num), string.Format(BookmarkStart.b("临ܶ䐸Ḻ", num), Class1041.smethod_8(num6 * 10)));
            }
        }
    }

    private void method_5(ShapeObject A_0)
    {
        int num = 0x11;
        Class784[] handles = A_0.Handles;
        if (handles != null)
        {
            Class400 class3 = this.class400_0;
            for (int i = 0; i < handles.Length; i++)
            {
                Class784 class2 = handles[i];
                class3.method_4(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊", num));
                this.class400_0.method_40(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌㽎㹐⁒㱔⍖じ㑚㍜", num), this.method_7(A_0, class2.class72_0, class2.class72_1));
                if (class2.bool_5)
                {
                    this.class400_0.vmethod_1(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌≎㡐⅒❔㡖⭘癚㕜ぞ፠੢ὤࡦݨὪ౬ͮ", num), class2.bool_5);
                }
                if (class2.bool_6)
                {
                    this.class400_0.vmethod_1(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌≎㡐⅒❔㡖⭘癚⭜㩞፠ᝢ౤Ѧࡨݪ", num), class2.bool_6);
                }
                if (class2.bool_4)
                {
                    this.class400_0.vmethod_1(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌㱎♐㩒⅔㑖ㅘ㹚㥜", num), class2.bool_4);
                }
                if (class2.bool_1)
                {
                    if (class2.class623_2.method_1() != -2147483648)
                    {
                        this.method_6(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌㵎ぐ㵒㉔㉖瑘⍚灜㉞ࡠൢ౤੦ᱨ٪", num), A_0, class2.class623_2, true);
                    }
                    if (class2.class623_3.method_1() != 0x7fffffff)
                    {
                        this.method_6(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌㵎ぐ㵒㉔㉖瑘⍚灜㉞`᭢౤੦ᱨ٪", num), A_0, class2.class623_3, true);
                    }
                    if (class2.class623_4.method_1() != -2147483648)
                    {
                        this.method_6(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌㵎ぐ㵒㉔㉖瑘≚灜㉞ࡠൢ౤੦ᱨ٪", num), A_0, class2.class623_4, false);
                    }
                    if (class2.class623_5.method_1() != 0x7fffffff)
                    {
                        this.method_6(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊恌㵎ぐ㵒㉔㉖瑘≚灜㉞`᭢౤੦ᱨ٪", num), A_0, class2.class623_5, false);
                    }
                }
                class3.method_6(BookmarkStart.b("匶䬸娺䨼Ծ⥀≂⭄⍆╈⹊", num));
            }
        }
    }

    private void method_6(string A_0, ShapeObject A_1, Class623 A_2, bool A_3)
    {
        this.class400_0.method_40(A_0, this.method_8(A_1, A_2, A_3));
    }

    private string method_7(ShapeObject A_0, Class72 A_1, Class72 A_2)
    {
        return string.Format(BookmarkStart.b("临ܶ䐸ᬺ䘼฾㱀", 15), this.method_9(A_0, A_1, true), this.method_9(A_0, A_2, false));
    }

    private string method_8(ShapeObject A_0, Class623 A_1, bool A_2)
    {
        int num = 15;
        if (A_1.method_0())
        {
            switch (A_1.method_1())
            {
                case 0:
                    if (A_2)
                    {
                        return BookmarkStart.b("头制弸伺", num);
                    }
                    return BookmarkStart.b("䄴堶䤸", num);

                case 1:
                    if (A_2)
                    {
                        return BookmarkStart.b("䜴帶常区䤼", num);
                    }
                    return BookmarkStart.b("圴堶䴸伺刼刾", num);

                case 2:
                    return Class1041.smethod_8(A_2 ? (A_0.CoordOriginX + (A_0.CoordSizeWidth / 2)) : (A_0.CoordOriginY + (A_0.CoordSizeHeight / 2)));
            }
            if (A_1.method_1() >= 0x100)
            {
                return string.Format(BookmarkStart.b("ᄴ䰶स䘺", num), Class1041.smethod_8(A_1.method_1() - 0x100));
            }
            int num2 = (this.class456_0 == null) ? 0 : this.class456_0.Length;
            if (A_0.Formulas == null)
            {
                return null;
            }
            if ((A_1.method_1() - 3) < (num2 + A_0.Formulas.Length))
            {
                return Class1041.smethod_8(this.int_0[A_1.method_1() - 3]);
            }
        }
        return Class1041.smethod_8(A_1.method_1());
    }

    private string method_9(ShapeObject A_0, Class72 A_1, bool A_2)
    {
        int num = 7;
        switch (A_1.method_1())
        {
            case HandlePositionType.LeftTop:
                if (A_2)
                {
                    return BookmarkStart.b("䄬䨮地䜲", num);
                }
                return BookmarkStart.b("夬䀮䄰", num);

            case HandlePositionType.RightBottom:
                if (A_2)
                {
                    return BookmarkStart.b("弬䘮嘰嬲䄴", num);
                }
                return BookmarkStart.b("伬䀮䔰䜲娴娶", num);

            case HandlePositionType.Center:
                return Class1041.smethod_8(A_2 ? (A_0.CoordOriginX + (A_0.CoordSizeWidth / 2)) : (A_0.CoordOriginY + (A_0.CoordSizeHeight / 2)));

            case HandlePositionType.Formula:
                return Class1041.smethod_8(this.int_0[A_1.method_2()]);

            case HandlePositionType.Adjust:
                return string.Format(BookmarkStart.b("ब吮İ串", num), Class1041.smethod_8(A_1.method_2()));
        }
        return Class1041.smethod_8(A_1.method_2());
    }

    private static int smethod_0(ShapeObject A_0, int[] A_1, int A_2)
    {
        int num = 0x11;
        if ((A_2 >= 0x400) && (A_2 <= 0x47f))
        {
            return A_1[A_2 - 0x400];
        }
        switch (A_2)
        {
            case 320:
                return (A_0.CoordOriginX + (A_0.CoordSizeWidth / 2));

            case 0x141:
                return (A_0.CoordOriginY + (A_0.CoordSizeHeight / 2));

            case 0x142:
                return A_0.CoordSizeWidth;

            case 0x143:
                return A_0.CoordSizeHeight;

            case 0x147:
                return A_0.method_60(1);

            case 0x148:
                return A_0.method_60(2);

            case 0x149:
                return A_0.method_60(3);

            case 330:
                return A_0.method_60(4);

            case 0x14b:
                return A_0.method_60(5);

            case 0x14c:
                return A_0.method_60(6);

            case 0x14d:
                return A_0.method_60(7);

            case 0x14e:
                return A_0.method_60(8);

            case 0x153:
                return A_0.LimoX;

            case 340:
                return A_0.LimoY;

            case 0x1fc:
                if (!A_0.IsStroked)
                {
                    return 0;
                }
                return 1;

            case 0x4f7:
                return (int) Class969.smethod_50((int) A_0.LineWidth);

            case 0x4f8:
                return (int) Class509.smethod_0(A_0.Width);

            case 0x4f9:
                return (int) Class509.smethod_0(A_0.Height);

            case 0x4fc:
                return Class969.smethod_40(A_0.Width);

            case 0x4fd:
                return Class969.smethod_40(A_0.Height);

            case 0x4fe:
                return Class969.smethod_40(A_0.Width * 0.5);

            case 0x4ff:
                return Class969.smethod_40(A_0.Height * 0.5);
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("䜶堸䤺尼刾", num), string.Format(BookmarkStart.b("然嘸䤺值䨾ⵀ≂敄⑆⡈❊⹌㩎㵐㉒⅔㉖㵘筚ⵜ㹞፠ɢࡤɦᵨ๪Ὤ佮ᥰቲٴ坶ླྀ᩺ᅼ੾ꎂ뎈ꮊ뾎", num), A_2));
    }

    internal static int[] smethod_1(ShapeObject A_0)
    {
        Class456[] formulas = A_0.Formulas;
        if ((formulas == null) || (formulas.Length == 0))
        {
            return null;
        }
        int[] numArray = new int[formulas.Length];
        for (int i = 0; i < formulas.Length; i++)
        {
            int num3;
            Class456 class2 = formulas[i];
            int num2 = class2.method_0() ? smethod_0(A_0, numArray, class2.int_1) : class2.int_1;
            int num = class2.method_1() ? smethod_0(A_0, numArray, class2.int_2) : class2.int_2;
            int num4 = class2.method_2() ? smethod_0(A_0, numArray, class2.int_3) : class2.int_3;
            switch (class2.operation_0)
            {
                case Operation.Sum:
                    num3 = (num2 + num) - num4;
                    break;

                case Operation.Prod:
                    num3 = num2 * num;
                    if (num4 != 0)
                    {
                        num3 /= num4;
                    }
                    break;

                case Operation.Mid:
                    num3 = (num2 + num) / 2;
                    break;

                case Operation.Abs:
                    num3 = Math.Abs(num2);
                    break;

                case Operation.Min:
                    num3 = Math.Min(num2, num);
                    break;

                case Operation.Max:
                    num3 = Math.Max(num2, num);
                    break;

                case Operation.If:
                    num3 = (num2 > 0) ? num : num4;
                    break;

                case Operation.Mod:
                    num3 = (int) Math.Sqrt((double) (((num2 * num2) + (num * num)) + (num4 * num4)));
                    break;

                case Operation.Atan2:
                    num3 = (int) (Class1133.smethod_1(Math.Atan2((double) num, (double) num2)) * 65536.0);
                    break;

                case Operation.Sin:
                    num3 = (int) (num2 * Math.Sin(Class1133.smethod_0((double) (((float) num) / 65536f))));
                    break;

                case Operation.Cos:
                    num3 = (int) (num2 * Math.Cos(Class1133.smethod_0((double) (((float) num) / 65536f))));
                    break;

                case Operation.CosAtan2:
                    num3 = (int) (num2 * Math.Cos(Math.Atan2((double) num4, (double) num)));
                    break;

                case Operation.SinAtan2:
                    num3 = (int) (num2 * Math.Sin(Math.Atan2((double) num4, (double) num)));
                    break;

                case Operation.Sqrt:
                    num3 = (int) Math.Floor(Math.Sqrt((double) num2));
                    break;

                case Operation.SumAngle:
                    num3 = (num2 + (num * 0x10000)) - (num4 * 0x10000);
                    break;

                case Operation.Ellipse:
                    num3 = (int) (num4 * Math.Sqrt(1.0 - Math.Pow(((double) num2) / ((double) num), 2.0)));
                    break;

                case Operation.Tan:
                    num3 = (int) (num2 * Math.Tan(Class1133.smethod_0((double) (((float) num) / 65536f))));
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            numArray[i] = num3;
        }
        return numArray;
    }
}

