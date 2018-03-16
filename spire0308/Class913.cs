using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class913
{
    private Class913()
    {
    }

    internal static void smethod_0(Class582 A_0)
    {
        int num = 13;
        Class394 class2 = A_0.imethod_1();
        Document document = A_0.Interface50.imethod_0();
        Class907 settings = document.Settings;
        ViewSetup viewSetup = document.ViewSetup;
        settings.method_5().method_151();
        Class908 class4 = document.Settings.method_5();
        settings.bool_42 = false;
        while (class2.method_9(BookmarkStart.b("圲娴吶椸䤺", num)))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_181 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x48);
                    dictionary1.Add(BookmarkStart.b("刲头䀶堸䈺丼爾⑀ㅂ≄≆ై♊㵌㭎⡐ᵒ㑔㩖㱘⡚ⵜ㹞ɠ٢", num), 0);
                    dictionary1.Add(BookmarkStart.b("刲头䀶堸䈺丼氾⥀ⱂ㉄ᝆ╈⩊⹌⩎㥐㱒㥔㍖㱘⥚ड़㩞ᥠᝢ", num), 1);
                    dictionary1.Add(BookmarkStart.b("刲䀴䌶嘸紺刼䴾ⱀ≂ㅄࡆ㽈⹊㽌㵎㡐㝒ご", num), 2);
                    dictionary1.Add(BookmarkStart.b("儲娴堶券紺刼匾╀ፂ㝄⹆❈㽊⑌ⅎ㙐", num), 3);
                    dictionary1.Add(BookmarkStart.b("儲娴堶券紺刼匾╀ᅂ⁄ㅆ᥈㥊⑌ⅎ═㩒㭔ざ", num), 4);
                    dictionary1.Add(BookmarkStart.b("儲娴堶券紺刼匾╀ፂ㝄⹆❈㽊⑌ⅎ㙐R㵔㉖㱘⽚⹜", num), 5);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺砼刾⍀♂⅄ᑆえ㡊㥌⩎㱐ᕒ㩔㥖ⵘ⡚", num), 6);
                    dictionary1.Add(BookmarkStart.b("䌲䜴帶圸伺笼䴾⁀⁂ㅄ⹆♈╊ⱌ⍎ቐ㭒㑔╖㡘㡚⥜㩞፠㑢౤ͦᵨͪ", num), 7);
                    dictionary1.Add(BookmarkStart.b("䌲䜴帶圸伺洼倾㉀㝂ᙄ⑆㭈≊㵌㭎Ṑ╒ご╖൘㹚╜⭞", num), 8);
                    dictionary1.Add(BookmarkStart.b("䄲倴娶嘸䴺堼漾⑀ㅂ㙄⡆❈⩊⅌َ㽐㕒㩔╖㑘㩚⥜㙞๠ൢ", num), 9);
                    dictionary1.Add(BookmarkStart.b("䀲崴堶丸縺匼䤾⑀⽂⩄㝆ⱈ", num), 10);
                    dictionary1.Add(BookmarkStart.b("䔲吴嬶倸强尼䬾⑀ɂ≄♆⁈╊㹌㭎ɐげ㵔㉖㑘㩚", num), 11);
                    dictionary1.Add(BookmarkStart.b("䀲吴䄶尸爺匼䤾⁀⽂ⱄ⍆ᅈيŌ", num), 12);
                    dictionary1.Add(BookmarkStart.b("娲刴夶嘸䤺堼爾⡀㭂⁄⍆ੈ⑊⍌㭎㑐㵒⅔", num), 13);
                    dictionary1.Add(BookmarkStart.b("䘲䘴制愸栺焼款ᙀ⭂⁄⥆ᩈ⩊㭌♎㽐㑒", num), 14);
                    dictionary1.Add(BookmarkStart.b("䀲吴䄶尸漺唼䴾⹀㙂≄⽆ᅈᡊŌ᭎", num), 15);
                    dictionary1.Add(BookmarkStart.b("䔲尴制丸", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䤲娴堶吸", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("圲娴夶䴸缺吼䰾ㅀ⽂⑄㹆᥈⩊⩌⩎ፐ㱒⁔㥖㵘㩚⽜㙞Ѡၢ", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("圲尴䐶䤸场尼䘾̀≂♄ⱆ⹈㥊≌㩎㽐㝒ٔ㽖㡘⭚㡜", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䌲䜴帶圸伺笼倾㍀⹂㙄͆⡈㽊ⱌ", num), 20);
                    dictionary1.Add(BookmarkStart.b("嘲場唶尸强椼䴾㑀♂ᅄ㹆㥈⹊ୌ⁎㽐❒♔", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䀲吴䄶尸栺䠼崾㉀♂ㅄņ♈╊㥌㱎", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䀲吴䄶尸紺刼䴾ⱀあń♆㵈⩊", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("帲尴䔶䬸吺似爾⁀ㅂ≄⹆❈㡊", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("刲头帶常唺缼倾㍀❂⁄㕆㩈੊⍌⭎ᑐ㝒㉔㉖⩘", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("儲娴䔶崸帺似䰾Հⱂ⭄㍆ᩈ㹊㽌㵎㹐♒㭔㍖ᅘ㹚㱜㭞Ѡᅢ", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("儲娴䔶崸帺似䰾Հⱂ⭄㍆ᩈ㹊㽌㵎㹐♒㭔㍖὘㑚㉜⭞Ѡᅢ", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺格儾╀♂㝄⭆⁈╊⡌َ㽐╒㑔㭖じ㽚՜቞ⵠ", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("吲䀴䌶䴸帺似績㕀ᝂ⩄㝆", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("䌲䜴堶嘸崺渼䬾⁀㝂⁄", num), 30);
                    dictionary1.Add(BookmarkStart.b("唲娴䔶吸䠺礼娾㉀⩂≄⥆", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("刲䄴䌶堸堺唼娾╀ᝂ⁄⩆㥈❊ⱌ㭎㑐", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("弲尴夶券栺䤼䘾ⵀ♂㙄", num), 0x21);
                    dictionary1.Add(BookmarkStart.b("圲娴吶䰸嘺堼儾㕀ᝂ㱄㝆ⱈ", num), 0x22);
                    dictionary1.Add(BookmarkStart.b("帲吴帶唸瘺堼䴾♀♂", num), 0x23);
                    dictionary1.Add(BookmarkStart.b("䀲䄴丶唸帺洼帾⽀♂̈́⡆㭈♊ⱌ㭎ᝐ㩒㥔⍖㱘⥚", num), 0x24);
                    dictionary1.Add(BookmarkStart.b("䜲䜴嘶娸债漼娾㝀⩂㙄⹆♈╊㹌", num), 0x25);
                    dictionary1.Add(BookmarkStart.b("圲娴吶䰸嘺堼儾㕀ፂ㝄⡆㵈⹊⹌㭎㡐㱒㭔", num), 0x26);
                    dictionary1.Add(BookmarkStart.b("圲倴儶堸为儼䬾ᕀ≂❄ᑆ㵈⑊㵌", num), 0x27);
                    dictionary1.Add(BookmarkStart.b("刲䀴䌶嘸猺䐼伾⥀♂⭄♆㵈≊≌ⅎ", num), 40);
                    dictionary1.Add(BookmarkStart.b("倲娴夶䨸帺帼䨾㕀⩂㍄≆ň㉊㵌❎㑐㵒ᥔ㹖㑘㉚⥜", num), 0x29);
                    dictionary1.Add(BookmarkStart.b("嬲䰴䜶儸帺匼帾㕀⩂⩄⥆ፈ⑊⍌⩎", num), 0x2a);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺甼䘾ㅀ⭂⁄⥆⡈㽊⡌౎ぐ⍒♔", num), 0x2b);
                    dictionary1.Add(BookmarkStart.b("嘲䌴制圸稺匼嬾เ❂⅄ཆⱈ⩊⥌⩎⍐⁒", num), 0x2c);
                    dictionary1.Add(BookmarkStart.b("圲䜴嘶丸刺匼堾ـㅂⱄ⍆ň⑊㽌♎⭐㱒㭔⍖㡘㝚๜⽞`b౤०๨", num), 0x2d);
                    dictionary1.Add(BookmarkStart.b("圲䜴嘶丸刺匼堾ـㅂⱄ⍆Ὀ⹊㽌㭎㡐げ㑔㭖੘⭚㱜㱞ࡠൢɤ", num), 0x2e);
                    dictionary1.Add(BookmarkStart.b("圲尴䐶䤸场尼䘾ीⱂ㝄⹆㍈⑊⍌㭎ぐ㽒ᅔ╖㡘ⱚ㑜ㅞ٠③ᝤ๦൨⹪᭬੮Ͱੲ", num), 0x2f);
                    dictionary1.Add(BookmarkStart.b("圲尴䐶䤸场尼䘾ᝀ♂㝄㍆⁈⡊ⱌ⍎ᕐ⅒㑔⁖じ㕚㩜ᡞ፠੢Ť≦Ὠ๪Ὤ᙮", num), 0x30);
                    dictionary1.Add(BookmarkStart.b("䘲䘴制琸娺似堾⡀ⵂ㙄ņ♈㥊ौ㵎ぐ⑒㱔㥖㹘ᱚ⽜㙞ՠⱢᝤ๦๨ɪͬ", num), 0x31);
                    dictionary1.Add(BookmarkStart.b("圲䜴嘶丸刺匼堾ـㅂⱄ⍆ň⑊㽌♎⭐㱒㭔⍖㡘㝚ቜⵞࡠѢ౤०", num), 50);
                    dictionary1.Add(BookmarkStart.b("圲䜴嘶丸刺匼堾ـㅂⱄ⍆Ὀ⹊㽌㭎㡐げ㑔㭖ᙘ⥚㑜㡞ࡠൢ", num), 0x33);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺渼圾⁀❂⁄ņ♈㥊⁌୎ぐ❒㑔", num), 0x34);
                    dictionary1.Add(BookmarkStart.b("䌲䀴夶娸伺䠼帾㕀⩂⩄⥆Ɉ⹊㽌ⅎ㡐㵒㉔", num), 0x35);
                    dictionary1.Add(BookmarkStart.b("倲崴嘶䬸娺帼䬾⑀ㅂᙄ㝆⡈⡊⑌ⅎ㙐ၒ㩔㥖ⵘ⥚㉜㍞", num), 0x36);
                    dictionary1.Add(BookmarkStart.b("䌲䜴帶圸伺椼䠾⹀ూ⭄ࡆ❈⹊", num), 0x37);
                    dictionary1.Add(BookmarkStart.b("䀲䄴䔶倸堺䤼社⡀ㅂ㙄㍆ࡈ╊⥌͎ぐ⁒⅔ᑖㅘ㩚⽜ⱞ", num), 0x38);
                    dictionary1.Add(BookmarkStart.b("崲娴笶倸唺堼紾㍀♂⑄ⱆ㩈੊⭌㭎㑐⅒", num), 0x39);
                    dictionary1.Add(BookmarkStart.b("崲娴笶倸唺堼紾㍀♂⑄ⱆ㩈ॊ⡌⥎㹐⅒ご", num), 0x3a);
                    dictionary1.Add(BookmarkStart.b("唲娴堶䴸唺刼䬾⑀ፂ㝄", num), 0x3b);
                    dictionary1.Add(BookmarkStart.b("嘲嬴匶圸吺䤼娾ᅀㅂ", num), 60);
                    dictionary1.Add(BookmarkStart.b("倲娴娶䤸娺䤼", num), 0x3d);
                    dictionary1.Add(BookmarkStart.b("圲娴吶漸娺似䰾", num), 0x3e);
                    dictionary1.Add(BookmarkStart.b("尲䔴䌶倸嘺吼䔾⑀Ղ⩄㕆ୈ㥊≌㡎≐㙒❔", num), 0x3f);
                    dictionary1.Add(BookmarkStart.b("䄲倴嬶䀸琺匼椾ీག", num), 0x40);
                    dictionary1.Add(BookmarkStart.b("刲头嬶嘸䰺洼焾ـ", num), 0x41);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺漼娾ⵀ㩂੄⥆ੈᡊṌ", num), 0x42);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺渼帾㝀♂ቄ≆⭈ᭊⱌ⡎㑐⁒ᑔ⑖੘㉚㍜㡞ൠ٢⍤๦ը๪", num), 0x43);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺爼䴾♀≂⭄⹆㍈⹊ьⅎᝐ㱒㥔㍖㱘⥚", num), 0x44);
                    dictionary1.Add(BookmarkStart.b("圲娴礶嘸伺格䰾⑀ག⩄⥆⹈ൊ⑌⍎㑐ᵒ㑔㩖㱘⡚", num), 0x45);
                    dictionary1.Add(BookmarkStart.b("䌲尴伶尸场丼漾⑀ㅂౄ⥆⩈⍊", num), 70);
                    dictionary1.Add(BookmarkStart.b("䜲吴䔶常帺䤼氾≀ㅂ⁄≆❈ᡊ㝌", num), 0x47);
                    Class1160.dictionary_181 = dictionary1;
                }
                if (Class1160.dictionary_181.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            settings.bool_60 = class2.method_31();
                            continue;
                        }
                        case 1:
                        {
                            settings.bool_57 = class2.method_31();
                            continue;
                        }
                        case 2:
                        case 0x23:
                        {
                            continue;
                        }
                        case 3:
                        {
                            settings.bool_39 = class2.method_31();
                            continue;
                        }
                        case 4:
                        {
                            settings.bool_38 = class2.method_31();
                            continue;
                        }
                        case 5:
                        {
                            settings.int_18 = class2.method_29();
                            continue;
                        }
                        case 6:
                        {
                            settings.bool_8 = class2.method_31();
                            continue;
                        }
                        case 7:
                        {
                            settings.bool_5 = class2.method_31();
                            continue;
                        }
                        case 8:
                        {
                            settings.bool_4 = class2.method_31();
                            continue;
                        }
                        case 9:
                        {
                            settings.bool_3 = class2.method_31();
                            continue;
                        }
                        case 10:
                        {
                            settings.bool_29 = class2.method_31();
                            continue;
                        }
                        case 11:
                        {
                            settings.bool_52 = class2.method_31();
                            continue;
                        }
                        case 12:
                        {
                            settings.bool_53 = class2.method_31();
                            continue;
                        }
                        case 13:
                        {
                            settings.bool_56 = class2.method_31();
                            continue;
                        }
                        case 14:
                        {
                            settings.bool_59 = class2.method_31();
                            continue;
                        }
                        case 15:
                        {
                            settings.string_4 = class2.method_12(BookmarkStart.b("䬲䘴嬶䴸", num), "");
                            continue;
                        }
                        case 0x10:
                        {
                            viewSetup.DocumentViewType = Class330.smethod_6(class2.method_28());
                            continue;
                        }
                        case 0x11:
                        {
                            smethod_1(viewSetup, class2);
                            continue;
                        }
                        case 0x12:
                        {
                            viewSetup.DoNotDisplayPageBoundaries = class2.method_31();
                            continue;
                        }
                        case 0x13:
                        {
                            viewSetup.DisplayBackgroundShape = class2.method_31();
                            continue;
                        }
                        case 20:
                        {
                            settings.bool_6 = class2.method_31();
                            continue;
                        }
                        case 0x15:
                        {
                            settings.bool_7 = class2.method_31();
                            continue;
                        }
                        case 0x16:
                        {
                            settings.bool_9 = class2.method_31();
                            continue;
                        }
                        case 0x17:
                        {
                            settings.bool_10 = class2.method_31();
                            continue;
                        }
                        case 0x18:
                        {
                            settings.bool_11 = class2.method_31();
                            continue;
                        }
                        case 0x19:
                        {
                            settings.bool_12 = class2.method_31();
                            continue;
                        }
                        case 0x1a:
                        {
                            settings.bool_13 = class2.method_31();
                            continue;
                        }
                        case 0x1b:
                        {
                            settings.bool_14 = class2.method_31();
                            continue;
                        }
                        case 0x1c:
                        {
                            settings.bool_58 = class2.method_31();
                            continue;
                        }
                        case 0x1d:
                        {
                            settings.bool_15 = class2.method_31();
                            continue;
                        }
                        case 30:
                        {
                            smethod_3(settings, class2);
                            continue;
                        }
                        case 0x1f:
                        {
                            viewSetup.FormsDesign = class2.method_31();
                            continue;
                        }
                        case 0x20:
                        {
                            settings.string_0 = class2.method_28();
                            continue;
                        }
                        case 0x21:
                        {
                            settings.bool_16 = class2.method_31();
                            continue;
                        }
                        case 0x22:
                        {
                            settings.autoFormatDocumentType_0 = Class330.smethod_10(class2.method_28());
                            continue;
                        }
                        case 0x24:
                        {
                            settings.int_32 = Class114.smethod_8(class2.method_28());
                            continue;
                        }
                        case 0x25:
                        {
                            settings.bool_21 = class2.method_31();
                            continue;
                        }
                        case 0x26:
                        {
                            smethod_4(document, class2);
                            continue;
                        }
                        case 0x27:
                        {
                            settings.float_0 = class2.method_29();
                            continue;
                        }
                        case 40:
                        {
                            settings.bool_27 = class2.method_31();
                            continue;
                        }
                        case 0x29:
                        {
                            settings.int_15 = class2.method_29();
                            continue;
                        }
                        case 0x2a:
                        {
                            settings.int_16 = class2.method_29();
                            continue;
                        }
                        case 0x2b:
                        {
                            settings.bool_28 = class2.method_31();
                            continue;
                        }
                        case 0x2c:
                        {
                            settings.bool_37 = class2.method_31();
                            continue;
                        }
                        case 0x2d:
                        {
                            settings.int_19 = class2.method_29();
                            continue;
                        }
                        case 0x2e:
                        {
                            settings.int_20 = class2.method_29();
                            continue;
                        }
                        case 0x2f:
                        {
                            settings.int_21 = class2.method_29();
                            continue;
                        }
                        case 0x30:
                        {
                            settings.int_22 = class2.method_29();
                            continue;
                        }
                        case 0x31:
                        {
                            settings.bool_40 = !class2.method_31();
                            continue;
                        }
                        case 50:
                        {
                            settings.int_23 = class2.method_29();
                            continue;
                        }
                        case 0x33:
                        {
                            settings.int_24 = class2.method_29();
                            continue;
                        }
                        case 0x34:
                        {
                            settings.bool_41 = class2.method_31();
                            continue;
                        }
                        case 0x35:
                        {
                            settings.bool_42 = class2.method_31();
                            continue;
                        }
                        case 0x36:
                        {
                            settings.characterSpacing_0 = Class330.smethod_2(class2.method_28());
                            continue;
                        }
                        case 0x37:
                        {
                            settings.bool_43 = class2.method_31();
                            continue;
                        }
                        case 0x38:
                        {
                            settings.bool_44 = class2.method_31();
                            continue;
                        }
                        case 0x39:
                        {
                            settings.string_1 = smethod_2(class2, settings);
                            continue;
                        }
                        case 0x3a:
                        {
                            settings.string_2 = smethod_2(class2, settings);
                            continue;
                        }
                        case 0x3b:
                        {
                            smethod_7(A_0, class2.method_1(), document.FootnoteOptions);
                            continue;
                        }
                        case 60:
                        {
                            smethod_7(A_0, class2.method_1(), document.EndnoteOptions);
                            continue;
                        }
                        case 0x3d:
                        {
                            smethod_5(class4, class2);
                            continue;
                        }
                        case 0x3e:
                        {
                            smethod_6(document.Variables, class2);
                            continue;
                        }
                        case 0x3f:
                        {
                            settings.bool_45 = class2.method_31();
                            continue;
                        }
                        case 0x40:
                        {
                            settings.bool_46 = class2.method_31();
                            continue;
                        }
                        case 0x41:
                        {
                            settings.bool_47 = class2.method_31();
                            continue;
                        }
                        case 0x42:
                        {
                            settings.bool_48 = class2.method_31();
                            continue;
                        }
                        case 0x43:
                        {
                            settings.bool_49 = class2.method_31();
                            continue;
                        }
                        case 0x44:
                        {
                            settings.bool_50 = class2.method_31();
                            continue;
                        }
                        case 0x45:
                        {
                            settings.bool_51 = class2.method_31();
                            continue;
                        }
                        case 70:
                        {
                            settings.int_25 = class2.method_29();
                            continue;
                        }
                        case 0x47:
                        {
                            settings.screenSize_1 = Class417.smethod_29(class2.method_28());
                            continue;
                        }
                    }
                }
            }
            class2.vmethod_1();
        }
    }

    private static void smethod_1(ViewSetup A_0, Class394 A_1)
    {
        int num = 9;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("央倰弲", num)))
                {
                    if (str == BookmarkStart.b("弮吰䄲嘴制圸伺", num))
                    {
                        A_0.ZoomPercent = A_1.method_4();
                    }
                }
                else
                {
                    A_0.ZoomType = Class330.smethod_8(A_1.method_3());
                }
            }
        }
    }

    private static string smethod_2(Class394 A_0, Class907 A_1)
    {
        int num = 5;
        string str = string.Empty;
        while (A_0.method_19())
        {
            string str2 = A_0.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("崪䰬䌮", num)))
                {
                    if (str2 == BookmarkStart.b("䜪䰬䄮嘰", num))
                    {
                        A_1.localeIDs_0 = (LocaleIDs) Class860.smethod_0(A_0.method_3(), false);
                    }
                }
                else
                {
                    str = A_0.method_3();
                }
            }
        }
        return str;
    }

    private static void smethod_3(Class907 A_0, Class394 A_1)
    {
        int num = 0x10;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("䔵䠷弹倻刽⤿ⱁ⍃", num)))
                {
                    if (str == BookmarkStart.b("儵䨷嬹儻匽ℿぁ", num))
                    {
                        A_0.proofState_1 = Class330.smethod_4(A_1.method_3());
                    }
                }
                else
                {
                    A_0.proofState_0 = Class330.smethod_4(A_1.method_3());
                }
            }
        }
    }

    private static void smethod_4(Document A_0, Class394 A_1)
    {
        int num = 8;
        while (A_1.method_19())
        {
            string str = A_1.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("䬭启嬱䀳", num))
                {
                    if (str != BookmarkStart.b("䠭弯䀱夳圵䰷丹唻倽✿", num))
                    {
                        if (!(str == BookmarkStart.b("䬭帯吱嬳䐵嬷弹儻嬽⸿㙁", num)))
                        {
                            if (str == BookmarkStart.b("嬭帯䈱䘳夵䰷弹弻䨽ဿ⍁㝃㕅㽇╉㹋⩍", num))
                            {
                                A_0.Settings.uint_0 = (uint) Class114.smethod_8(A_1.method_3());
                            }
                        }
                        else
                        {
                            A_0.EnforceDocProt = A_1.method_63();
                        }
                    }
                    else
                    {
                        A_0.Settings.bool_1 = A_1.method_63();
                    }
                }
                else
                {
                    A_0.Settings.method_9(Class330.smethod_0(A_1.method_3()));
                }
            }
        }
    }

    private static void smethod_5(Class908 A_0, Class394 A_1)
    {
        int num = 11;
        A_0.method_138(true);
        while (A_1.method_9(BookmarkStart.b("到尲場䜶堸伺", num)))
        {
            string key = A_1.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_182 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(50);
                    dictionary1.Add(BookmarkStart.b("帰䄲尴倶游吺似嬾ᕀ≂❄⭆ⱈ᥊㡌⍎㑐⁒", num), 0);
                    dictionary1.Add(BookmarkStart.b("䘰䌲缴䈶䨸伺吼夾⡀⁂⑄㍆⁈⑊⍌", num), 1);
                    dictionary1.Add(BookmarkStart.b("弰尲愴嘶嬸猺尼儾♀ੂ⭄⍆", num), 2);
                    dictionary1.Add(BookmarkStart.b("弰尲礴制堸强吼儾♀", num), 3);
                    dictionary1.Add(BookmarkStart.b("䈰䌲吴吶尸紺刼䴾ᑀག", num), 4);
                    dictionary1.Add(BookmarkStart.b("弰尲瘴堶唸为值儾̀≂⥄♆❈⡊⡌", num), 5);
                    dictionary1.Add(BookmarkStart.b("匰刲头嘶圸堺堼氾⡀ⵂ≄⭆ⱈॊ㑌㭎㑐ᝒ㩔≖㭘㝚㡜ᵞᡠᝢdてhཪᥬݮ", num), 6);
                    dictionary1.Add(BookmarkStart.b("䔰䄲吴夶䨸䬺尼䴾⑀ⵂㅄ੆ⱈ㽊ⱌ⥎㡐㽒ご⑖", num), 7);
                    dictionary1.Add(BookmarkStart.b("弰尲瀴伶䴸䤺尼猾⡀ⵂ⁄ᑆ㥈⩊⹌♎㽐㑒", num), 8);
                    dictionary1.Add(BookmarkStart.b("唰尲笴堶䴸眺堼帾㝀♂݄♆⩈⁊㹌⍎ぐ⁒㵔ᙖ㕘㑚㍜㩞", num), 9);
                    dictionary1.Add(BookmarkStart.b("䐰弲愴䔶堸刺儼氾ㅀ≂♄≆", num), 10);
                    dictionary1.Add(BookmarkStart.b("唰尲笴堶䴸縺䔼伾⁀ⵂ⅄ᑆⅈ≊⭌㭎͐㙒⅔≖⭘㕚", num), 11);
                    dictionary1.Add(BookmarkStart.b("䈰䌲吴吶倸唺娼瘾⽀ᑂⵄ⡆╈⹊ᵌ⁎㡐㵒⅔⑖", num), 12);
                    dictionary1.Add(BookmarkStart.b("崰娲嬴制游䤺尼伾ീ⩂⹄≆Ṉ⑊㽌⭎材", num), 13);
                    dictionary1.Add(BookmarkStart.b("䄰䄲尴夶䴸示刼嬾㡀ᝂ⁄㽆㵈ॊ⡌⥎㹐⅒ごὖ㱘㩚㥜㩞፠", num), 14);
                    dictionary1.Add(BookmarkStart.b("䄰䄲尴夶䴸砺刼匾̀⽂⑄⑆≈", num), 15);
                    dictionary1.Add(BookmarkStart.b("䘰䌲昴䜶堸堺堼栾⡀❂ㅄ⽆", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䈰嬲娴䀶笸䤺堼帾⩀あౄ⥆཈㥊ⱌ≎㑐⁒", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("䈰䘲圴然嘸唺䤼紾㡀၂ⱄ㵆ⱈ", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("䈰䘲䔴䜶䬸帺丼䰾̀ⱂㅄ㍆♈♊Ṍ㽎ぐげ㱔㥖㹘", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䈰䘲䔴䜶䬸帺丼䰾ᕀⱂ㕄ᑆ㥈⩊⹌♎㽐㑒", num), 20);
                    dictionary1.Add(BookmarkStart.b("䈰䘲䔴䜶䬸帺丼䰾ᕀⱂ㕄ᑆ㥈⩊⹌♎㽐㑒ᡔ㙖㩘湚", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䈰䘲䔴䜶䬸帺丼䰾ᕀⱂ㕄ᑆ㥈⩊⹌♎㽐㑒ɔݖ", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("䈰䘲䔴䜶䬸帺丼䰾ቀ㍂݄ⅆࡈⵊ㥌⩎⍐͒㉔ᕖ⭘ず", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("䈰䐲吴䜶笸吺似嬾⑀ㅂ㙄ņ⡈⡊⑌ⅎ㙐͒㑔ざ㱘⡚", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("到尲嬴䄶琸娺吼匾ీ♂㝄⁆ⱈ๊㹌ⱎ", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("䔰䄲䀴夶娸娺䤼娾݀ⱂ⭄㍆ň⹊⑌⡎㥐❒", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("尰䐲昴娶堸场儼簾⁀㍂㙄", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("䐰䀲倴朶䬸刺匼䬾⑀ㅂࡄ≆㵈㥊⑌ⱎ≐", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("䘰䐲̴甶嘸䤺夼娾㍀ᅂい⭆ⱈ㡊", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("䘰䄲吴䜶洸䤺尼嘾ⵀ၂㕄♆⩈⹊㹌", num), 30);
                    dictionary1.Add(BookmarkStart.b("地尲娴䌶圸吺䤼娾ീ≂㱄⡆㱈㽊Ō♎㩐㙒ɔV慘", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("䈰嬲吴䜶尸眺尼䘾⹀㙂ㅄ୆⁈⁊⡌ᡎِ歒", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("倰弲尴倶圸漺尼崾ⵀ♂㙄ᕆ♈㱊ཌ㙎͐㱒≔", num), 0x21);
                    dictionary1.Add(BookmarkStart.b("地尲䜴倶尸伺焼帾㉀㝂ᅄ♆⭈੊⅌♎㙐㵒㡔㉖㝘⽚", num), 0x22);
                    dictionary1.Add(BookmarkStart.b("倰圲弴䈶䨸伺焼嘾⽀♂ൄ≆⁈ⱊ╌㭎ᡐ㵒Ŕ㙖㭘㝚㡜", num), 0x23);
                    dictionary1.Add(BookmarkStart.b("倰䘲䄴堶樸䬺尼尾⑀གⱄⱆⱈ᱊≌㵎㕐橒恔", num), 0x24);
                    dictionary1.Add(BookmarkStart.b("弰尲昴䜶堸堺堼派⁀⩂㙄≆Ո⑊㩌⩎⍐", num), 0x25);
                    dictionary1.Add(BookmarkStart.b("唰尲笴堶䴸渺丼娾ीᝂࡄ୆᥈⩊㽌⹎㙐⅒㑔❖ㅘᩚ⡜⭞๠ぢᕤ٦੨ɪͬ࡮", num), 0x26);
                    dictionary1.Add(BookmarkStart.b("崰刲䰴堶䰸伺漼帾㙀ᝂ⑄╆╈⹊ᩌ♎㕐❒㵔", num), 0x27);
                    dictionary1.Add(BookmarkStart.b("崰刲䰴堶䰸伺椼帾⍀⽂⁄ᕆ♈㱊㹌๎⅐㉒❔⍖", num), 40);
                    dictionary1.Add(BookmarkStart.b("䐰䀲倴怶嘸䤺夼ؾ癀གⱄ⥆ⱈॊ㽌⩎ぐ㡒㱔㥖㹘ग़⡜㍞Ѡၢ", num), 0x29);
                    dictionary1.Add(BookmarkStart.b("匰䄲倴嘶券氺似帾ㅀ㍂⁄⍆ᵈ⩊⽌⍎㑐⁒", num), 0x2a);
                    dictionary1.Add(BookmarkStart.b("䈰崲吴䜶洸吺稼䴾⡀❂ౄ⥆ੈ⹊⅌⍎", num), 0x2b);
                    dictionary1.Add(BookmarkStart.b("唰尲嬴䌶砸场儼倾㙀Ղⱄ≆╈⽊ࡌⅎ㕐Rご㭖㱘㡚⥜", num), 0x2c);
                    dictionary1.Add(BookmarkStart.b("倰䌲䔴嬶䀸示似娾⁀⡂ⱄ⥆⹈᥊㡌⍎㑐⁒", num), 0x2d);
                    dictionary1.Add(BookmarkStart.b("䘰䄲吴䜶洸帺䔼䬾ᙀ⩂ㅄ⽆᥈㹊⍌ⱎ═", num), 0x2e);
                    dictionary1.Add(BookmarkStart.b("䐰䀲倴瘶䨸刺尼儾̀ㅂ⁄♆≈᥊㡌⍎㑐⁒", num), 0x2f);
                    dictionary1.Add(BookmarkStart.b("䐰䀲倴怶嘸䤺夼ാ煀獂睄ፆ⡈⥊⅌⩎ɐ❒ⱔ㭖㱘ग़⡜㍞Ѡၢ", num), 0x30);
                    dictionary1.Add(BookmarkStart.b("唰尲嬴䌶縸䤺刼䠾@㙂ㅄ⡆⽈≊㥌", num), 0x31);
                    Class1160.dictionary_182 = dictionary1;
                }
                if (Class1160.dictionary_182.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            A_0.method_20(A_1.method_31());
                            continue;
                        }
                        case 1:
                        {
                            A_0.method_64(A_1.method_31());
                            continue;
                        }
                        case 2:
                        {
                            A_0.method_4(A_1.method_31());
                            continue;
                        }
                        case 3:
                        {
                            A_0.method_42(A_1.method_31());
                            continue;
                        }
                        case 4:
                        {
                            A_0.method_44(A_1.method_31());
                            continue;
                        }
                        case 5:
                        {
                            A_0.method_14(A_1.method_31());
                            continue;
                        }
                        case 6:
                        {
                            A_0.method_34(A_1.method_31());
                            continue;
                        }
                        case 7:
                        {
                            A_0.method_22(A_1.method_31());
                            continue;
                        }
                        case 8:
                        {
                            A_0.method_58(A_1.method_31());
                            continue;
                        }
                        case 9:
                        {
                            A_0.method_28(A_1.method_31());
                            continue;
                        }
                        case 10:
                        {
                            A_0.method_32(A_1.method_31());
                            continue;
                        }
                        case 11:
                        {
                            A_0.method_30(A_1.method_31());
                            continue;
                        }
                        case 12:
                        {
                            A_0.method_38(A_1.method_31());
                            continue;
                        }
                        case 13:
                        {
                            A_0.method_54(A_1.method_31());
                            continue;
                        }
                        case 14:
                        {
                            A_0.method_40(A_1.method_31());
                            continue;
                        }
                        case 15:
                        {
                            A_0.method_12(A_1.method_31());
                            continue;
                        }
                        case 0x10:
                        {
                            A_0.method_62(A_1.method_31());
                            continue;
                        }
                        case 0x11:
                        {
                            A_0.method_24(A_1.method_31());
                            continue;
                        }
                        case 0x12:
                        {
                            A_0.method_52(A_1.method_31());
                            continue;
                        }
                        case 0x13:
                        {
                            A_0.method_60(A_1.method_31());
                            continue;
                        }
                        case 20:
                        {
                            A_0.method_18(A_1.method_31());
                            continue;
                        }
                        case 0x15:
                        {
                            A_0.method_36(A_1.method_31());
                            continue;
                        }
                        case 0x16:
                        {
                            A_0.method_48(A_1.method_31());
                            continue;
                        }
                        case 0x17:
                        {
                            A_0.method_8(A_1.method_31());
                            continue;
                        }
                        case 0x18:
                        {
                            A_0.method_26(A_1.method_31());
                            continue;
                        }
                        case 0x19:
                        {
                            A_0.method_16(A_1.method_31());
                            continue;
                        }
                        case 0x1a:
                        {
                            A_0.method_50(A_1.method_31());
                            continue;
                        }
                        case 0x1b:
                        {
                            A_0.method_46(A_1.method_31());
                            continue;
                        }
                        case 0x1c:
                        {
                            A_0.method_66(A_1.method_31());
                            continue;
                        }
                        case 0x1d:
                        {
                            A_0.method_56(A_1.method_31());
                            continue;
                        }
                        case 30:
                        {
                            A_0.method_10(A_1.method_31());
                            continue;
                        }
                        case 0x1f:
                        {
                            A_0.method_70(A_1.method_31());
                            continue;
                        }
                        case 0x20:
                        {
                            A_0.method_68(A_1.method_31());
                            continue;
                        }
                        case 0x21:
                        {
                            A_0.method_80(A_1.method_31());
                            continue;
                        }
                        case 0x22:
                        {
                            A_0.method_76(A_1.method_31());
                            continue;
                        }
                        case 0x23:
                        {
                            A_0.method_74(!A_1.method_31());
                            continue;
                        }
                        case 0x24:
                        {
                            A_0.method_78(A_1.method_31());
                            continue;
                        }
                        case 0x25:
                        {
                            A_0.method_6(A_1.method_31());
                            continue;
                        }
                        case 0x26:
                        {
                            A_0.method_72(A_1.method_31());
                            continue;
                        }
                        case 0x27:
                        {
                            A_0.method_82(A_1.method_31());
                            continue;
                        }
                        case 40:
                        {
                            A_0.method_84(A_1.method_31());
                            continue;
                        }
                        case 0x29:
                        {
                            A_0.method_86(A_1.method_31());
                            continue;
                        }
                        case 0x2a:
                        {
                            A_0.method_88(!A_1.method_31());
                            continue;
                        }
                        case 0x2b:
                        {
                            A_0.method_90(!A_1.method_31());
                            continue;
                        }
                        case 0x2c:
                        {
                            A_0.method_92(A_1.method_31());
                            continue;
                        }
                        case 0x2d:
                        {
                            A_0.method_94(A_1.method_31());
                            continue;
                        }
                        case 0x2e:
                        {
                            A_0.method_96(!A_1.method_31());
                            continue;
                        }
                        case 0x2f:
                        {
                            A_0.method_98(!A_1.method_31());
                            continue;
                        }
                        case 0x30:
                        {
                            A_0.method_100(A_1.method_31());
                            continue;
                        }
                        case 0x31:
                        {
                            A_0.method_102(!A_1.method_31());
                            continue;
                        }
                    }
                }
            }
            A_1.vmethod_1();
        }
    }

    private static void smethod_6(VariableCollection A_0, Class394 A_1)
    {
        int num = 0x12;
        while (A_1.method_9(BookmarkStart.b("尷唹弻栽ℿぁ㝃", num)))
        {
            if (A_1.method_1() == BookmarkStart.b("尷唹弻栽ℿぁ", num))
            {
                string name = null;
                string str2 = null;
                while (A_1.method_19())
                {
                    string str3 = A_1.method_1();
                    if (str3 != null)
                    {
                        if (!(str3 == BookmarkStart.b("嘷嬹儻嬽", num)))
                        {
                            if (str3 == BookmarkStart.b("丷嬹倻", num))
                            {
                                str2 = A_1.method_3();
                            }
                        }
                        else
                        {
                            name = A_1.method_3();
                        }
                    }
                }
                if (name != null)
                {
                    A_0.Add(name, str2);
                }
            }
            else
            {
                A_1.vmethod_1();
            }
        }
    }

    internal static void smethod_7(Class581 A_0, string A_1, FormatBase A_2)
    {
        int num = 0x11;
        bool flag1 = A_1 == BookmarkStart.b("制圸强匼倾㕀♂ᕄ㕆", 0x11);
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(A_1))
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_183 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                    dictionary1.Add(BookmarkStart.b("䜶嘸䠺", num), 0);
                    dictionary1.Add(BookmarkStart.b("夶䰸嘺笼刾㕀", num), 1);
                    dictionary1.Add(BookmarkStart.b("夶䰸嘺渼䬾⁀ㅂㅄ", num), 2);
                    dictionary1.Add(BookmarkStart.b("夶䰸嘺漼娾㉀㝂⑄㕆㵈", num), 3);
                    dictionary1.Add(BookmarkStart.b("儶嘸吺䤼儾⹀㝂⁄", num), 4);
                    dictionary1.Add(BookmarkStart.b("制圸强匼倾㕀♂", num), 5);
                    Class1160.dictionary_183 = dictionary1;
                }
                if (Class1160.dictionary_183.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            A_2.SetAttr(2, Class339.smethod_6(class2.method_28()));
                            continue;
                        }
                        case 1:
                        {
                            A_2.SetAttr(1, Class911.smethod_13(Class911.smethod_2(class2.method_28())));
                            continue;
                        }
                        case 2:
                        {
                            A_2.SetAttr(4, class2.method_29());
                            continue;
                        }
                        case 3:
                        {
                            A_2.SetAttr(3, Class339.smethod_0(class2.method_28()));
                            continue;
                        }
                        case 4:
                        {
                            smethod_8(A_0, FootnoteType.Footnote);
                            continue;
                        }
                        case 5:
                        {
                            smethod_8(A_0, FootnoteType.Endnote);
                            continue;
                        }
                    }
                }
            }
            class2.vmethod_1();
        }
    }

    private static void smethod_8(Class581 A_0, FootnoteType A_1)
    {
        int num = 9;
        FootnoteSeparatorType normal = FootnoteSeparatorType.Normal;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str;
            if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("嬮䠰䌲倴", num)))
            {
                bool flag = A_1 == FootnoteType.Endnote;
                normal = Class911.smethod_10(class2.method_3(), flag);
            }
        }
        if (normal != FootnoteSeparatorType.Normal)
        {
            Class8 class3 = new Class8(A_0.Interface50.imethod_0(), normal);
            A_0.Interface50.imethod_0().FootnoteSeparators.method_1(normal, class3);
        }
    }
}

