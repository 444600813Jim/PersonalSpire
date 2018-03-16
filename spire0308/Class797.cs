using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;

internal class Class797
{
    private Class797()
    {
    }

    internal static bool smethod_0(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3, Class97 A_4, DocumentObject A_5)
    {
        int num = 4;
        Class396 class2 = A_0.method_11();
        string key = class2.method_1();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_149 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x25);
                dictionary1.Add(BookmarkStart.b("䠩䌫䄭嬯弱唳䐵匷᜹主嬽☿", num), 0);
                dictionary1.Add(BookmarkStart.b("伩䠫䜭䐯嬱娳儵ᔷ夹䔻崽ⰿ❁㝃", num), 1);
                dictionary1.Add(BookmarkStart.b("伩䠫䜭䐯嬱娳儵ᔷ帹䤻䰽ℿ㙁ⵃ⥅♇", num), 2);
                dictionary1.Add(BookmarkStart.b("䄩䤫圭䜯崱䘳刵䬷", num), 3);
                dictionary1.Add(BookmarkStart.b("天夫䰭娯圱圳䈵", num), 4);
                dictionary1.Add(BookmarkStart.b("丩䤫崭匯䀱崳䘵䰷匹医倽", num), 5);
                dictionary1.Add(BookmarkStart.b("䬩", num), 6);
                dictionary1.Add(BookmarkStart.b("丩䴫娭儯倱唳䔵崷᜹堻圽㌿㉁⡃❅ㅇ", num), 7);
                dictionary1.Add(BookmarkStart.b("丩䴫娭儯倱唳䔵崷᜹刻嬽㠿㙁", num), 8);
                dictionary1.Add(BookmarkStart.b("丩䴫娭儯倱唳䔵崷᜹主儽㜿潁⩃㍅╇⡉⥋㱍", num), 9);
                dictionary1.Add(BookmarkStart.b("天䤫弭䔯圱娳唵崷", num), 10);
                dictionary1.Add(BookmarkStart.b("䰩䔫䈭唯ἱ娳圵唷弹", num), 11);
                dictionary1.Add(BookmarkStart.b("帩䤫䌭䀯帱唳䈵崷᜹刻弽ⴿ❁", num), 12);
                dictionary1.Add(BookmarkStart.b("尩䴫尭夯匱嘳娵崷᜹伻嬽㐿", num), 13);
                dictionary1.Add(BookmarkStart.b("尩䴫尭夯匱嘳娵崷᜹嬻嬽㐿", num), 14);
                dictionary1.Add(BookmarkStart.b("娩䴫䤭唯ἱ娳䌵唷堹夻䰽", num), 15);
                dictionary1.Add(BookmarkStart.b("䬩夫娭堯崱䘳ᬵ嘷嬹儻嬽", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䬩夫娭堯崱䘳ᬵ儷吹唻䨽⤿⍁⡃㕅", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䌩䈫䜭䐯嬱唳娵ᔷ夹主嬽ℿ㙁⭃㑅", num), 0x12);
                dictionary1.Add(BookmarkStart.b("丩䴫娭唯", num), 0x13);
                dictionary1.Add(BookmarkStart.b("帩䔫䌭唯", num), 20);
                dictionary1.Add(BookmarkStart.b("娩師䜭帯䘱ᤳ刵夷丹夻", num), 0x15);
                dictionary1.Add(BookmarkStart.b("娩師䜭帯䘱ᤳ䈵儷圹夻", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䤩師䬭儯䘱崳夵嘷᜹堻弽㐿❁", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䤩師䬭儯䘱崳夵嘷᜹䠻圽ⴿ❁", num), 0x18);
                dictionary1.Add(BookmarkStart.b("帩䔫娭尯圱", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䜩䌫䨭夯吱崳唵夷丹唻儽⸿潁ぃ⽅╇⽉", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("䜩䌫䨭夯吱崳唵夷丹唻儽⸿潁⁃❅㱇⽉", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䤩師䬭儯䘱嬳䐵", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("娩䴫尭儯唱䘳圵䠷刹ᄻ崽⼿㝁⩃㉅", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("䤩䐫伭䈯匱圳䈵崷䠹ᄻ崽⼿㝁⩃㉅", num), 30);
                dictionary1.Add(BookmarkStart.b("娩䴫䤭唯ἱ圳夵䴷吹䠻", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("崩䌫尭启ἱ圳夵䴷吹䠻", num), 0x20);
                dictionary1.Add(BookmarkStart.b("帩䤫嘭䐯ἱ崳堵䠷伹䠻", num), 0x21);
                dictionary1.Add(BookmarkStart.b("丩師䄭䀯ἱ倳夵伷吹", num), 0x22);
                dictionary1.Add(BookmarkStart.b("弩弫䬭䈯ἱ倳匵帷匹刻嬽␿", num), 0x23);
                dictionary1.Add(BookmarkStart.b("䬩䀫席堯匱嘳匵䰷匹弻弽ⰿ潁ⵃ⡅ⱇ⽉㑋捍㵏㍑♓㵕", num), 0x24);
                Class1160.dictionary_149 = dictionary1;
            }
            if (Class1160.dictionary_149.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        smethod_2(A_0, A_1, A_2, A_3);
                        return true;

                    case 1:
                        smethod_11(A_0, A_1, FieldType.FieldRevisionNum, BookmarkStart.b("砩椫砭縯朱礳", num), A_2, A_3);
                        return true;

                    case 2:
                        smethod_11(A_0, A_1, FieldType.FieldEditTime, BookmarkStart.b("漩栫札搯昱紳笵紷", num), A_2, A_3);
                        return true;

                    case 3:
                        smethod_11(A_0, A_1, FieldType.FieldKeyWord, BookmarkStart.b("愩椫眭术紱昳爵欷", num), A_2, A_3);
                        return true;

                    case 4:
                        smethod_11(A_0, A_1, FieldType.FieldSubject, BookmarkStart.b("礩礫氭稯眱眳戵", num), A_2, A_3);
                        return true;

                    case 5:
                        smethod_11(A_0, A_1, FieldType.FieldComments, BookmarkStart.b("椩挫挭累眱稳戵欷", num), A_2, A_3);
                        return true;

                    case 6:
                        smethod_3(A_0, A_1, A_4, A_5, A_2, A_3);
                        return true;

                    case 7:
                        smethod_11(A_0, A_1, FieldType.FieldMergeField, string.Format(BookmarkStart.b("朩椫簭眯眱爳缵紷瘹砻ḽ㬿牁㥃", num), class2.method_12(BookmarkStart.b("䤩䌫䈭䔯弱娳ᬵ嘷嬹儻嬽", num), null)), A_2, A_3);
                        return true;

                    case 8:
                        smethod_11(A_0, A_1, FieldType.FieldNext, BookmarkStart.b("搩椫瘭搯", num), A_2, A_3);
                        return true;

                    case 9:
                        smethod_11(A_0, A_1, FieldType.FieldMergeRec, BookmarkStart.b("朩椫簭眯眱昳猵笷", num), A_2, A_3);
                        return true;

                    case 10:
                        smethod_11(A_0, A_1, FieldType.FieldSequence, string.Format(BookmarkStart.b("礩椫缭ု䤱г䬵", num), class2.method_12(BookmarkStart.b("䐩䴫䌭唯", num), "")), A_2, A_3);
                        return true;

                    case 11:
                    {
                        string str2 = class2.method_12(BookmarkStart.b("丩䔫崭䀯帱唳伵", num), BookmarkStart.b("䐩䴫䌭唯ἱ唳堵尷᜹夻䘽㐿❁⩃㕅ⅇ╉≋", num));
                        smethod_11(A_0, A_1, FieldType.FieldFileName, Class576.smethod_19(str2), A_2, A_3);
                        return true;
                    }
                    case 12:
                    {
                        string str3 = class2.method_12(BookmarkStart.b("丩䔫崭䀯帱唳伵", num), BookmarkStart.b("䐩䴫䌭唯ἱ唳堵尷᜹夻䘽㐿❁⩃㕅ⅇ╉≋", num));
                        smethod_11(A_0, A_1, FieldType.FieldTemplate, Class576.smethod_19(str3), A_2, A_3);
                        return true;
                    }
                    case 13:
                        smethod_4(A_0, A_1, A_2, A_3);
                        return true;

                    case 14:
                        smethod_5(A_0, A_1, A_2, A_3);
                        return true;

                    case 15:
                        smethod_11(A_0, A_1, FieldType.FieldPage, string.Format(BookmarkStart.b("਩簫漭眯眱ᐳ樵ሷᨹ䜻฽㴿扁", num), smethod_10(A_0)), A_2, A_3);
                        return true;

                    case 0x10:
                        smethod_11(A_0, A_1, FieldType.FieldUserName, BookmarkStart.b("缩缫欭戯簱申笵紷", num), A_2, A_3);
                        return true;

                    case 0x11:
                        smethod_11(A_0, A_1, FieldType.FieldUserInitials, BookmarkStart.b("缩缫欭戯笱稳缵氷猹紻爽ጿ", num), A_2, A_3);
                        return true;

                    case 0x12:
                        smethod_11(A_0, A_1, FieldType.FieldAuthor, BookmarkStart.b("欩礫稭砯紱昳", num), A_2, A_3);
                        return true;

                    case 0x13:
                        smethod_9(A_0, A_1, BookmarkStart.b("温洫稭甯", num), FieldType.FieldDate, A_2, A_3);
                        return true;

                    case 20:
                        smethod_9(A_0, A_1, BookmarkStart.b("縩攫挭甯", num), FieldType.FieldDate, A_2, A_3);
                        return true;

                    case 0x15:
                    case 0x16:
                        smethod_9(A_0, A_1, BookmarkStart.b("稩縫札縯昱瀳眵氷缹", num), FieldType.FieldPrintDate, A_2, A_3);
                        return true;

                    case 0x17:
                    case 0x18:
                        smethod_9(A_0, A_1, BookmarkStart.b("椩縫欭焯昱焳爵礷渹礻", num), FieldType.FieldCreateDate, A_2, A_3);
                        return true;

                    case 0x19:
                        smethod_11(A_0, A_1, FieldType.FieldTitle, BookmarkStart.b("縩攫稭簯眱", num), A_2, A_3);
                        return true;

                    case 0x1a:
                    case 0x1b:
                        smethod_9(A_0, A_1, BookmarkStart.b("礩洫砭甯瘱申戵紷", num), FieldType.FieldSaveDate, A_2, A_3);
                        return true;

                    case 0x1c:
                        smethod_11(A_0, A_1, FieldType.FieldLastSavedBy, BookmarkStart.b("昩洫紭搯愱申怵紷縹縻朽", num), A_2, A_3);
                        return true;

                    case 0x1d:
                        smethod_11(A_0, A_1, FieldType.FieldDocProperty, BookmarkStart.b("温挫洭怯怱笳昵紷根栻朽怿ቁՃᑅे൉ṋཌྷOᩑݓ", num), A_2, A_3);
                        return true;

                    case 30:
                        smethod_11(A_0, A_1, FieldType.FieldDocProperty, BookmarkStart.b("温挫洭怯怱笳昵紷根栻朽怿Łృ݅ᩇ୉ཋᩍᕏQݓŕᅗ๙ᑛ൝た⍡❣⍥㭧", num), A_2, A_3);
                        return true;

                    case 0x1f:
                        smethod_11(A_0, A_1, FieldType.FieldNumPages, string.Format(BookmarkStart.b("搩礫挭怯猱猳猵欷䄹఻䌽", num), smethod_10(A_0)), A_2, A_3);
                        return true;

                    case 0x20:
                        smethod_11(A_0, A_1, FieldType.FieldNumWords, string.Format(BookmarkStart.b("਩戫笭累攱笳搵簷椹᰻戽樿扁㽃癅㕇橉", num), smethod_10(A_0)), A_2, A_3);
                        return true;

                    case 0x21:
                        smethod_8(A_0, A_1, A_2, A_3);
                        return true;

                    case 0x22:
                        smethod_6(A_0, A_1, A_2, A_3);
                        return true;

                    case 0x23:
                    {
                        string str4 = class2.method_12(BookmarkStart.b("䐩䴫䌭唯", num), "");
                        smethod_11(A_0, A_1, FieldType.FieldDocProperty, string.Format(BookmarkStart.b("温挫洭怯怱笳昵紷根栻朽怿恁㽃癅㕇桉", num), str4), A_2, A_3);
                        return true;
                    }
                    case 0x24:
                        smethod_1(A_0, A_1, class2);
                        return true;
                }
            }
        }
        return false;
    }

    private static void smethod_1(Class857 A_0, Paragraph A_1, Class396 A_2)
    {
        int num = 0x13;
        string str = A_2.method_12(BookmarkStart.b("䨸伺似嘾⽀⑂桄ㅆ⡈❊㡌⩎", 0x13), null);
        string str2 = A_2.method_12(BookmarkStart.b("券帺䐼฾", 0x13), null);
        string str3 = A_2.method_12(BookmarkStart.b("券帺䐼ാ", 0x13), null);
        A_1.method_13(new TextRange(A_0.method_9(), string.Format(BookmarkStart.b("愸縺ᴼᴾ㩀獂㡄㱆硈㙊㙌絎ⱐ煒", 0x13), str, (str2 != null) ? string.Format(BookmarkStart.b("̸䀺഼䈾", num), str2) : "", (str3 != null) ? string.Format(BookmarkStart.b("̸䀺഼䈾", num), str3) : ""), new CharacterFormat()));
    }

    private static string smethod_10(Class857 A_0)
    {
        int num = 1;
        Class396 class2 = A_0.method_11();
        class2.method_18();
        string key = class2.method_12(BookmarkStart.b("䤦尨䘪,䤮帰䄲場嘶䴸", 1), "");
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_150 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1f);
                dictionary1.Add(BookmarkStart.b("ᘦ", num), 0);
                dictionary1.Add(BookmarkStart.b("昦", num), 1);
                dictionary1.Add(BookmarkStart.b("ਦनᨪബȮᴰጲᠴ᜶ସᬺြጾ慀湂敄瑆楈晊慌潎罐絒答", num), 2);
                dictionary1.Add(BookmarkStart.b("䘦", num), 3);
                dictionary1.Add(BookmarkStart.b("渦", num), 4);
                dictionary1.Add(BookmarkStart.b("並", num), 5);
                dictionary1.Add(BookmarkStart.b("㛙Ԩପ㿓̮ᄰ⃍ᤴ᜶᜸ᔺጼ", num), 6);
                dictionary1.Add(BookmarkStart.b("❨Ԩପⵢ⠞ᴰጲ㕺〆㸈᜺ᴼᄾ潀浂", num), 7);
                dictionary1.Add(BookmarkStart.b("❨Ԩପꅢ̮ᄰ㩼ᤴ᜶᜸ᔺጼ", num), 8);
                dictionary1.Add(BookmarkStart.b("홾Ԩପ㵳̮ᄰᤴ᜶᜸ᔺጼ", num), 9);
                dictionary1.Add(BookmarkStart.b("❨Ԩପꅢ̮ᄰ㩼ᤴ᜶㹶᜺ᴼᄾ潀浂", num), 10);
                dictionary1.Add(BookmarkStart.b("囙Ԩପ忓̮ᄰ䃍ᤴ᜶᜸ᔺጼ", num), 11);
                dictionary1.Add(BookmarkStart.b("嗙Ԩପ뛓̮ᄰ맍ᤴ᜶᜸ᔺጼ", num), 12);
                dictionary1.Add(BookmarkStart.b("䜂Ԩପ䰈̮ᄰ儖ᤴ᜶᜸ᔺጼ", num), 13);
                dictionary1.Add(BookmarkStart.b("❨Ԩପ汿̮ᄰ㍼䭂ἶ硆ሺᄼἾ潀浂歄", num), 14);
                dictionary1.Add(BookmarkStart.b("搦愨截挬樮戰瘲笴戶琸ऺ", num), 15);
                dictionary1.Add(BookmarkStart.b("ᕓԨପ瑢̮ᄰ⩼ᤴ᜶᜸ᔺጼ", num), 0x10);
                dictionary1.Add(BookmarkStart.b("睽Ԩପ㱢̮ᄰᤴ᜶᜸ᔺጼ", num), 0x11);
                dictionary1.Add(BookmarkStart.b("ᕓ祳ܪബ癠⁾ἲᔴ⹸ﱣ᜺ᴼᄾ潀浂", num), 0x12);
                dictionary1.Add(BookmarkStart.b("꼂Ԩପꐈ̮ᄰ뤖ᤴ᜶᜸ᔺጼ", num), 0x13);
                dictionary1.Add(BookmarkStart.b("匂Ԩପ堈̮ᄰ䔖ᤴ᜶᜸ᔺጼ", num), 20);
                dictionary1.Add(BookmarkStart.b("ܔԨପఞ̮ᄰᄀᤴ᜶᜸ᔺጼ", num), 0x15);
                dictionary1.Add(BookmarkStart.b("㈯Ԩପ㬥̮ᄰ␻ᤴ᜶᜸ᔺጼ", num), 0x16);
                dictionary1.Add(BookmarkStart.b("∯Ԩପ⬥̮ᄰ㐻ᤴ᜶᜸ᔺጼ", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䀯Ԩପ䔥̮ᄰ娻ᤴ᜶᜸ᔺጼ", num), 0x18);
                dictionary1.Add(BookmarkStart.b("⠯㰡ܪബध稹ἲᔴጿ礱ጳᄼἾ潀浂歄", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䨦\udd28\u0829夬̮ᄰ嬲吴帶ᔸᬺ弼帾浀捂歄楆杈", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("ᘦ娨弪Ĭ༮̰崲儴ᬶᤸ࠺似嬾浀捂歄楆杈", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("栦䜨个Ĭ༮攰䐲娴ᬶᤸ漺唼䴾⑀♂楄杆杈敊捌", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("愦䀨太帬嬮ᴰጲ昴制娸吺匼嬾浀捂ᅄ⽆⁈㥊⥌捎煐絒答祖", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("ᘦԨପ氬̮ᄰ焲ᤴ᜶᜸ᔺጼ", num), 30);
                Class1160.dictionary_150 = dictionary1;
            }
            if (Class1160.dictionary_150.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BookmarkStart.b("昦笨横漬昮爰", num);

                    case 1:
                        return BookmarkStart.b("昦攨笪攬渮猰瘲愴縶稸", num);

                    case 2:
                        return BookmarkStart.b("昦笨横漬昮爰眲琴搶焸", num);

                    case 3:
                        return BookmarkStart.b("䘦䔨嬪䔬丮匰嘲䄴帶娸", num);

                    case 4:
                        return BookmarkStart.b("昦攨笪攬渮猰瘲愴縶稸", num);

                    case 5:
                        return BookmarkStart.b("唦䘨䘪䰬䄮", num);

                    case 6:
                        return BookmarkStart.b("挦欨株攬渮挰", num);

                    case 7:
                        return BookmarkStart.b("挦欨攪砬戮0", num);

                    case 8:
                        return BookmarkStart.b("挦欨攪砬戮̰", num);

                    case 9:
                        return BookmarkStart.b("挦欨攪砬戮Ȱ", num);

                    case 10:
                        return BookmarkStart.b("挦欨攪砬戮԰", num);

                    case 11:
                        return BookmarkStart.b("昦怨縪栬怮", num);

                    case 12:
                        return BookmarkStart.b("渦笨搪攬渮", num);

                    case 13:
                        return BookmarkStart.b("搦怨礪測挮琰紲怴稶", num);

                    case 14:
                        return BookmarkStart.b("搦愨截挬樮戰瘲笴戶琸࠺", num);

                    case 15:
                        return BookmarkStart.b("\ude7e\u0528ପ麠̮ᄰᤴ᜶᜸ᔺጼ", num);

                    case 0x10:
                        return BookmarkStart.b("紦昨漪搬渮爰Ȳ", num);

                    case 0x11:
                        return BookmarkStart.b("紦昨漪搬渮爰Ĳ", num);

                    case 0x12:
                        return BookmarkStart.b("紦昨漪搬渮爰2", num);

                    case 0x13:
                        return BookmarkStart.b("怦欨ᨪ", num);

                    case 20:
                        return BookmarkStart.b("怦欨ᤪ", num);

                    case 0x15:
                        return BookmarkStart.b("怦欨Ἢ", num);

                    case 0x16:
                        return BookmarkStart.b("漦怨攪椬昮細瘲愴挶簸椺఼", num);

                    case 0x17:
                        return BookmarkStart.b("漦怨攪椬昮細瘲愴挶簸椺༼", num);

                    case 0x18:
                        return BookmarkStart.b("漦怨攪椬昮瀰愲琴甶瀸砺", num);

                    case 0x19:
                        return BookmarkStart.b("漦怨攪椬昮爰爲朴猶洸縺攼款", num);

                    case 0x1a:
                        return BookmarkStart.b("焦怨渪礬氮瀰愲焴挶簸挺椼", num);

                    case 0x1b:
                        return BookmarkStart.b("栦笨漪搬愮瀰缲", num);

                    case 0x1c:
                        return BookmarkStart.b("搦栨礪椬笮琰欲愴", num);

                    case 0x1d:
                        return BookmarkStart.b("栦笨漪礬樮椰朲", num);

                    case 30:
                        return BookmarkStart.b("漦氨猪", num);
                }
            }
        }
        return "";
    }

    private static void smethod_11(Class857 A_0, Paragraph A_1, FieldType A_2, string A_3, CharacterFormat A_4, Style A_5)
    {
        string str = A_0.method_11().method_21();
        smethod_12(A_0, A_1, A_2, A_3, str, A_4, A_5);
    }

    private static void smethod_12(Class857 A_0, Paragraph A_1, FieldType A_2, string A_3, string A_4, CharacterFormat A_5, Style A_6)
    {
        Field field;
        int num = 0x13;
        if (A_5 == null)
        {
            A_5 = A_1.BreakCharacterFormat;
        }
        if (A_2 == FieldType.FieldMergeField)
        {
            field = new MergeField(A_0.method_9());
        }
        else
        {
            field = new Field(A_0.method_9());
        }
        string str = A_3.Trim();
        if (str.EndsWith(BookmarkStart.b("攸ᄺ", num)))
        {
            A_3 = str.Substring(0, str.Length - 2);
        }
        field.Code = A_3;
        if (A_2 == FieldType.FieldMergeField)
        {
            field.ParseFieldCode(field.Code);
        }
        field.ApplyCharacterFormat(A_5);
        field.Type = A_2;
        A_1.method_13(field);
        if (A_2 != FieldType.FieldMergeField)
        {
            FieldMark mark = new FieldMark(A_0.method_9(), FieldMarkType.FieldSeparator);
            mark.ApplyCharacterFormat(A_5);
            TextRange range = new TextRange(A_0.method_9()) {
                Text = A_4
            };
            range.ApplyCharacterFormat(A_5);
            FieldMark mark2 = new FieldMark(A_0.method_9(), FieldMarkType.FieldEnd);
            mark2.ApplyCharacterFormat(A_5);
            field.Separator = mark;
            field.End = mark2;
            A_1.method_13(mark);
            A_1.method_13(range);
            A_1.method_13(mark2);
        }
        field.UpdateFieldCode(field.Code);
    }

    private static void smethod_13(Class857 A_0, DocumentObject A_1, string A_2, CharacterFormat A_3, Style A_4)
    {
        if (Class567.smethod_16(A_2))
        {
            TextRange range = new TextRange(A_0.method_9(), A_2, A_3);
            Class857.smethod_16(range, A_4);
            A_1.method_13(range);
        }
    }

    private static void smethod_2(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
        string str3;
        int num = 0x12;
        string str = A_0.method_11().method_12(BookmarkStart.b("䨷弹娻嬽㈿❁⩃╅ⵇ杉⩋⅍≏㽑㕓≕", 0x12), BookmarkStart.b("䰷弹䐻䨽", 0x12));
        string str2 = A_0.method_11().method_12(BookmarkStart.b("䨷弹娻ጽ⸿⍁⥃⍅", 0x12), "");
        FieldType fieldRef = FieldType.FieldRef;
        if ((str != BookmarkStart.b("䠷嬹嬻嬽", 0x12)) && !str.StartsWith(BookmarkStart.b("嘷伹儻尽┿ぁ", num)))
        {
            if (str == BookmarkStart.b("尷匹主嬽⌿㙁ⵃ⥅♇", num))
            {
                str3 = string.Format(BookmarkStart.b("樷缹稻ḽ㬿牁㥃晅ᑇ㩉", num), str2);
            }
            else
            {
                str3 = string.Format(BookmarkStart.b("樷缹稻ḽ㬿牁㥃", num), str2);
            }
        }
        else
        {
            str3 = string.Format(BookmarkStart.b("样笹笻笽ሿ݁Ƀ晅㍇穉ㅋ", num), str2);
            fieldRef = FieldType.FieldPageRef;
        }
        smethod_11(A_0, A_1, fieldRef, str3, A_2, A_3);
    }

    internal static void smethod_3(Class857 A_0, Paragraph A_1, Class97 A_2, DocumentObject A_3, CharacterFormat A_4, Style A_5)
    {
        int num = 11;
        Class396 class2 = A_0.method_11();
        string str = class2.method_0();
        Field field = new Field(A_0.method_9()) {
            Type = FieldType.FieldHyperlink
        };
        Hyperlink hyperlink = new Hyperlink(field);
        A_1.method_13(field);
        string str2 = "";
        string str3 = "";
        while (class2.method_19())
        {
            string str5 = class2.method_1();
            if (str5 != null)
            {
                if (!(str5 == BookmarkStart.b("夰䄲倴儶", num)))
                {
                    if (str5 == BookmarkStart.b("䔰刲䜴倶尸伺ြ夾㍀≂⡄≆摈╊ⱌ≎㑐", num))
                    {
                        str3 = class2.method_3();
                    }
                }
                else
                {
                    str2 = Class576.smethod_91(class2.method_3());
                }
            }
        }
        if ((str == BookmarkStart.b("䔰嘲䴴䌶", num)) && Class567.smethod_16(str2))
        {
            string.Format(BookmarkStart.b("礰樲攴父欸眺琼焾ੀ捂杄㱆祈㙊潌", num), str2);
            if (str2.StartsWith(BookmarkStart.b("ሰ", num)))
            {
                hyperlink.Type = HyperlinkType.Bookmark;
                string str4 = str2.Replace(BookmarkStart.b("ሰ", num), string.Empty);
                hyperlink.BookmarkName = str4;
                field.m_fieldValue = str4;
            }
            else
            {
                field.m_fieldValue = BookmarkStart.b("ጰ", num) + str2.Replace(BookmarkStart.b("洰", num), BookmarkStart.b("洰漲", num)) + BookmarkStart.b("ጰ", num);
                field.Code = string.Format(BookmarkStart.b("礰樲攴父欸眺琼焾ੀ捂㹄睆㑈", num), field.m_fieldValue);
            }
            FieldMark mark = new FieldMark(A_0.method_9(), FieldMarkType.FieldSeparator);
            A_1.method_13(mark);
            field.Separator = mark;
        }
        if (str == BookmarkStart.b("唰䄲吴䀶", num))
        {
            A_0.method_49(str2);
            A_0.method_51(str3);
        }
        Class1099.smethod_8(A_0, A_1, BookmarkStart.b("倰", num), A_2, A_3);
        if (str == BookmarkStart.b("唰䄲吴䀶", num))
        {
            A_0.method_49(null);
            A_0.method_51(null);
        }
        if ((A_2 != null) && (A_2.method_13() != null))
        {
            A_4.method_73(A_2.method_13());
        }
        FieldMark mark2 = new FieldMark(A_0.method_9(), FieldMarkType.FieldEnd);
        A_1.method_13(mark2);
        field.End = mark2;
    }

    private static void smethod_4(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
        int num = 7;
        Class396 class2 = A_0.method_11();
        Document doc = A_0.method_9();
        string str = class2.method_12(BookmarkStart.b("䌬丮尰嘲", 7), null);
        string str2 = class2.method_12(BookmarkStart.b("帬嬮䌰娲嬴倶ᐸ䴺尼匾㑀♂", 7), null);
        if (!Class567.smethod_16(str2))
        {
            str2 = class2.method_21();
        }
        string str3 = class2.method_12(BookmarkStart.b("䤬䘮䈰䌲头嘶䀸", num), null);
        if (Class567.smethod_16(str) && (str3 != BookmarkStart.b("䌬䀮弰嘲", num)))
        {
            smethod_12(A_0, A_1, FieldType.FieldSet, string.Format(BookmarkStart.b("縬樮攰ጲ临ܶ䐸ᬺἼ䐾灀㹂杄", num), str, str2), str2, A_2, A_3);
            smethod_12(A_0, A_1, FieldType.FieldRef, string.Format(BookmarkStart.b("缬樮眰ጲ᜴䰶स䘺Ἴ", num), str), str2, A_2, A_3);
            int num2 = 0;
            foreach (Bookmark bookmark in doc.Bookmarks)
            {
                if (Class567.smethod_41(str, bookmark.Name))
                {
                    break;
                }
                num2++;
            }
            if (num2 == doc.Bookmarks.Count)
            {
                A_1.method_13(new BookmarkStart(doc, str));
                A_1.method_13(new BookmarkEnd(doc, str));
            }
        }
    }

    private static void smethod_5(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
        int num = 0x12;
        Class396 class2 = A_0.method_11();
        string str = class2.method_12(BookmarkStart.b("嘷嬹儻嬽", 0x12), null);
        string str2 = class2.method_21();
        if (Class567.smethod_16(str))
        {
            smethod_12(A_0, A_1, FieldType.FieldRef, string.Format(BookmarkStart.b("樷缹稻ḽ房㥁瑃㭅橇", num), str), str2, A_2, A_3);
        }
    }

    private static void smethod_6(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
    }

    internal static void smethod_7(Class857 A_0, DocumentObject A_1, Class978 A_2, CharacterFormat A_3, Style A_4)
    {
    }

    private static void smethod_8(Class857 A_0, Paragraph A_1, CharacterFormat A_2, Style A_3)
    {
    }

    private static void smethod_9(Class857 A_0, Paragraph A_1, string A_2, FieldType A_3, CharacterFormat A_4, Style A_5)
    {
        int num = 0x11;
        Class396 class2 = A_0.method_11();
        string str = class2.method_12(BookmarkStart.b("匶堸伺尼ሾ㉀㝂㱄⭆ⱈ晊⍌⹎㱐㙒", 0x11), null);
        Class102 class3 = (Class102) A_0.method_13().method_2(str, null, A_0.method_20(), true);
        if ((class3 != null) && (class3.method_13() != null))
        {
            class3.method_13().method_37(A_4);
        }
        smethod_12(A_0, A_1, A_3, string.Format(BookmarkStart.b("᜶䈸଺䀼Ἶᵀ͂敄敆㉈穊が济", num), A_2, class3.method_21()), class2.method_21(), A_4, A_5);
    }
}

