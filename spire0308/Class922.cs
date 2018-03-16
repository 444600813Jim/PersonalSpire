using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class922
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private static readonly Hashtable hashtable_10 = new Hashtable();
    private static readonly Hashtable hashtable_11 = new Hashtable();
    private static readonly Hashtable hashtable_12 = new Hashtable();
    private static readonly Hashtable hashtable_13 = new Hashtable();
    private static readonly Hashtable hashtable_14 = new Hashtable();
    private static readonly Hashtable hashtable_15 = new Hashtable();
    private static readonly Hashtable hashtable_16 = new Hashtable();
    private static readonly Hashtable hashtable_17 = new Hashtable();
    private static readonly Hashtable hashtable_18 = new Hashtable();
    private static readonly Hashtable hashtable_19 = new Hashtable();
    private static readonly Hashtable hashtable_2 = new Hashtable();
    private static readonly Hashtable hashtable_20 = new Hashtable();
    private static readonly Hashtable hashtable_21 = new Hashtable();
    private static readonly Hashtable hashtable_22 = new Hashtable();
    private static readonly Hashtable hashtable_23 = new Hashtable();
    private static readonly Hashtable hashtable_24 = new Hashtable();
    private static readonly Hashtable hashtable_25 = new Hashtable();
    private static readonly Hashtable hashtable_3 = new Hashtable();
    private static readonly Hashtable hashtable_4 = new Hashtable();
    private static readonly Hashtable hashtable_5 = new Hashtable();
    private static readonly Hashtable hashtable_6 = new Hashtable();
    private static readonly Hashtable hashtable_7 = new Hashtable();
    private static readonly Hashtable hashtable_8 = new Hashtable();
    private static readonly Hashtable hashtable_9 = new Hashtable();
    private const string string_0 = " (user)";

    static Class922()
    {
        Class791.smethod_0(new object[] { BookmarkStart.b("嬷刹崻䰽", 0x12), RelativeHorizontalPosition.Character, BookmarkStart.b("䠷嬹嬻嬽", 0x12), RelativeHorizontalPosition.Page }, hashtable_20, hashtable_21);
        Class791.smethod_0(new object[] { BookmarkStart.b("䠷唹主䨽㈿⍁ⵃ㉅", 0x12), PageOrientation.Portrait, BookmarkStart.b("吷嬹刻娽㌿⅁╃㙅ⵇ", 0x12), PageOrientation.Landscape }, hashtable_18, hashtable_19);
        Class791.smethod_0(new object[] { BookmarkStart.b("娷唹䠻䨽⼿⽁", 0x12), BaselineAlignment.Bottom, BookmarkStart.b("唷匹堻娽ⰿ❁", 0x12), BaselineAlignment.Center, BookmarkStart.b("䰷唹䰻", 0x12), BaselineAlignment.Top, BookmarkStart.b("夷伹䠻儽", 0x12), BaselineAlignment.Auto }, hashtable_16, hashtable_17);
        Class791.smethod_0(new object[] { BookmarkStart.b("娷唹䠻䨽⼿⽁", 0x12), VerticalPosition.Bottom, BookmarkStart.b("唷匹堻娽ⰿ❁", 0x12), VerticalPosition.Center, BookmarkStart.b("䰷唹䰻", 0x12), VerticalPosition.Top, BookmarkStart.b("帷䠹医匽洿㙁⭃㙅", 0x12), VerticalPosition.None }, hashtable_14, hashtable_15);
        Class791.smethod_0(new object[] { BookmarkStart.b("帷匹䐻嬽␿", 0x12), FontPitch.Fixed, BookmarkStart.b("丷嬹主圽ℿ⁁⡃⍅", 0x12), FontPitch.Variable }, hashtable_12, hashtable_13);
        Class791.smethod_0(new object[] { "", FontFamily.Auto, BookmarkStart.b("䨷唹儻弽⸿", 0x12), FontFamily.Roman, BookmarkStart.b("䬷䴹唻䴽㌿", 0x12), FontFamily.Swiss, BookmarkStart.b("唷唹堻嬽㈿ⱁ", 0x12), FontFamily.Modern, BookmarkStart.b("䬷夹主圽〿㙁", 0x12), FontFamily.Script, BookmarkStart.b("尷弹弻儽㈿⍁ぃ⽅㹇⽉", 0x12), FontFamily.Decorative }, hashtable_10, hashtable_11);
        Class791.smethod_0(new object[] { BookmarkStart.b("䰷弹䐻䨽", 0x12), FootnotePosition.PrintImmediatelyBeneathText, BookmarkStart.b("䠷嬹嬻嬽", 0x12), FootnotePosition.PrintAtBottomOfPage, BookmarkStart.b("䬷弹弻䨽⤿ⵁ⩃", 0x12), FootnotePosition.PrintAsEndOfSection, BookmarkStart.b("尷唹弻䬽ⴿ❁⩃㉅", 0x12), FootnotePosition.PrintAsEndOfDocument }, hashtable_8, hashtable_9);
        Class791.smethod_0(new object[] { "", SubSuperScript.None, BookmarkStart.b("䬷伹䰻嬽㈿扁煃繅浇", 0x12), SubSuperScript.SuperScript, BookmarkStart.b("䬷伹帻ḽ甿穁慃", 0x12), SubSuperScript.SubScript }, hashtable_6, hashtable_7);
        Class791.smethod_0(new object[] { BookmarkStart.b("夷䀹ᄻ崽㤿ぁⵃ⩅⑇⍉⽋", 0x12), Language.AzeriCyrillic, BookmarkStart.b("夷䀹ᄻ缽ᨿ", 0x12), Language.AzeriLatin, BookmarkStart.b("儷伹ᄻ紽Ŀ", 0x12), Language.InuktitutLatinCanada, BookmarkStart.b("圷圹ᄻ笽ᐿ", 0x12), Language.Oromo, BookmarkStart.b("䰷崹ᄻ樽ਿ", 0x12), Language.Tajik, BookmarkStart.b("嘷唹刻嬽", 0x12), Language.NoProof }, hashtable_0, hashtable_1);
        Class791.smethod_0(new object[] { BookmarkStart.b("䠷嬹主弽✿ぁ╃㙅⁇", 0x12), StyleType.ParagraphStyle, BookmarkStart.b("䰷弹䐻䨽", 0x12), StyleType.CharacterStyle }, hashtable_2, hashtable_3);
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅祇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅祇", 0x12), BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅穇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅穇", 0x12), BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅筇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅筇", 0x12), BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅籇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅籇", 0x12), BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅絇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅絇", 0x12), BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅繇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅繇", 0x12), BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅罇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅罇", 0x12), BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅灇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅灇", 0x12), 
            BookmarkStart.b("瀷弹崻娽⤿ⱁ⍃晅煇", 0x12), BookmarkStart.b("倷弹崻娽⤿ⱁ⍃晅煇", 0x12), BookmarkStart.b("笷嬹䰻䨽⤿ⵁ⩃", 0x12), BookmarkStart.b("嬷嬹䰻䨽⤿ⵁ⩃", 0x12), BookmarkStart.b("縷唹医䨽┿ぁ", 0x12), BookmarkStart.b("帷唹医䨽┿ぁ", 0x12), BookmarkStart.b("瀷弹崻娽┿ぁ", 0x12), BookmarkStart.b("倷弹崻娽┿ぁ", 0x12), BookmarkStart.b("孜뵜", 0x12), BookmarkStart.b("瘷唹主匽ℿ⹁", 0x12), BookmarkStart.b("焷吹䠻嬽㈿ⱁ⅃㉅桇♉╋⁍㭏", 0x12), BookmarkStart.b("瀷䌹䰻嬽㈿⹁ⵃ⡅⍇", 0x12), BookmarkStart.b("紷吹堻倽⼿㙁⅃晅㱇⽉㑋㩍", 0x12), BookmarkStart.b("崷吹堻倽⼿㙁⅃晅㱇⽉㑋㩍", 0x12), BookmarkStart.b("縷唹医䨽⸿ⵁぃ⍅桇㹉⥋㙍⑏", 0x12), BookmarkStart.b("帷唹医䨽⸿ⵁぃ⍅桇㹉⥋㙍⑏", 0x12), 
            BookmarkStart.b("紷吹堻倽⼿㙁⅃晅㩇⽉⩋⭍≏㝑㩓㕕㵗", 0x12), BookmarkStart.b("崷吹堻倽⼿㙁⅃晅㩇⽉⩋⭍≏㝑㩓㕕㵗", 0x12), BookmarkStart.b("縷唹医䨽⸿ⵁぃ⍅桇㡉⥋⡍㕏⁑ㅓ㡕㭗㽙", 0x12), BookmarkStart.b("帷唹医䨽⸿ⵁぃ⍅桇㡉⥋⡍㕏⁑ㅓ㡕㭗㽙", 0x12)
         }, hashtable_4, hashtable_5);
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("ष", 0x12), OutlineLevel.Level1, BookmarkStart.b("਷", 0x12), OutlineLevel.Level2, BookmarkStart.b("ଷ", 0x12), OutlineLevel.Level3, BookmarkStart.b("ష", 0x12), OutlineLevel.Level4, BookmarkStart.b("ഷ", 0x12), OutlineLevel.Level5, BookmarkStart.b("ื", 0x12), OutlineLevel.Level6, BookmarkStart.b("༷", 0x12), OutlineLevel.Level7, BookmarkStart.b("7", 0x12), OutlineLevel.Level8, 
            BookmarkStart.b("ķ", 0x12), OutlineLevel.Level9
         }, hashtable_22, hashtable_23);
        Class791.smethod_0(new object[] { "", ConnectionSiteType.Custom, BookmarkStart.b("嘷唹刻嬽", 0x12), ConnectionSiteType.None, BookmarkStart.b("䬷弹嬻匽┿ⱁぃ㕅", 0x12), ConnectionSiteType.Segments, BookmarkStart.b("䨷弹弻䨽ℿⱁ⍃⩅ⵇ", 0x12), ConnectionSiteType.Rect }, hashtable_24, hashtable_25);
    }

    internal static string smethod_0(string A_0)
    {
        int num = 3;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䠨嬪崬䌮堰倲吴䌶倸吺匼ှ㝀ⵂ⅄楆♈⩊㹌♎≐絒㩔❖㱘㕚㥜ぞɠᙢࡤɦݨὪ䍬ὮͰᙲٴቶ᝸ེᱼ୾", num))
            {
                return BookmarkStart.b("礨䐪娬䨮䌰挲娴帶圸伺ጼ瀾ㅀ♂⭄͆♈⡊㡌≎㑐㵒⅔ݖ⭘㹚⹜㩞འᝢѤ፦hѪͬ䅮䁰䅲", num);
            }
            if (str == BookmarkStart.b("䠨嬪崬䌮堰倲吴䌶倸吺匼ှ㝀ⵂ⅄楆♈⩊㹌♎≐絒㩔❖㱘㕚㥜ぞɠᙢࡤɦݨὪ䍬࡮Ͱቲմὶၸ᡺๼", num))
            {
                return BookmarkStart.b("䘨嬪䠬䄮唰尲嘴䈶吸帺匼䬾潀݂㝄♆㹈ཊ≌ⱎ⑐㹒ご㥖ⵘ畚汜", num);
            }
            if (str == BookmarkStart.b("䠨嬪崬䌮堰倲吴䌶倸吺匼ှ㝀ⵂ⅄楆♈⩊㹌♎≐絒㩔❖㱘㕚㥜ぞɠᙢࡤɦݨὪ䍬ᱮŰŲၴᙶᵸࡺᕼ᩾", num))
            {
                return BookmarkStart.b("氨匪丬䨮崰ᴲ稴䜶尸唺礼倾≀㙂⡄≆❈㽊Ṍ㽎⍐㙒㑔㍖⩘㍚㡜㩞ᕠ䵢呤啦", num);
            }
            if (str == BookmarkStart.b("䠨嬪崬䌮堰倲吴䌶倸吺匼ှ㝀ⵂ⅄楆♈⩊㹌♎≐絒㩔❖㱘㕚㥜ぞɠᙢࡤɦݨὪ䍬᭮ᑰ୲Ŵ", num))
            {
                return BookmarkStart.b("縨䐪弬䬮ἰ簲䔴制圸缺刼尾㑀⹂⁄⥆㵈Ὂ⡌㝎═絒摔敖", num);
            }
        }
        return BookmarkStart.b("簨䔪䘬䄮帰䐲嬴", num);
    }

    internal static string smethod_1(string A_0)
    {
        int num = 5;
        string key = A_0.ToUpper();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_187 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x24);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ഴԶसᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ഴжସᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 1);
                dictionary1.Add(BookmarkStart.b("株欬ᬮ眰ز4然സᘺԼ社祀瑂桄獆ൈ罊穌扎楐捒᝔ᕖ瑘湚敜潞奠剢卤卦⭨⥪幬⥮䥰", num), 2);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ఴܶ༸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 3);
                dictionary1.Add(BookmarkStart.b("ᴪ᤬ᜮ0ଲ焴ضसᘺ़社础ł桄癆硈ࡊୌ扎楐敒ၔᙖ瑘歚浜Ṟ⁠卢啤╦偨奪呬⩮䥰", num), 4);
                dictionary1.Add(BookmarkStart.b("漪測Ἦ̰̲شضุᘺ砼ाр煂桄獆ࡈ絊罌扎ፐ橒ፔᙖ瑘ᥚ湜ᩞ❠♢呤兦彨奪孬⥮䕰", num), 5);
                dictionary1.Add(BookmarkStart.b("ᴪ᤬ᜮ0ଲ焴ض࠸ᘺ़社础ł桄癆硈ࡊୌ扎楐敒ၔᙖ瑘歚浜Ṟ⁠卢啤╦偨奪呬⩮䥰", num), 6);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮȰ̲Դุܶᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 7);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮȰ̲Դܶ砸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 8);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮȰ̲Դܶ笸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 9);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮȰ̲Դܶ稸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 10);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮȰ̲Դܶ紸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 11);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮȰ̲Դܶ簸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 12);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ԰瀲ഴ猶ĸᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 13);
                dictionary1.Add(BookmarkStart.b("渪氬ᠮ猰爲瀴6सᘺ笼紾牀ł桄癆硈ࡊौ扎ၐ橒敔摖瑘歚浜Ṟ⁠卢啤剦塨孪⡬⹮䉰", num), 14);
                dictionary1.Add(BookmarkStart.b("ᬪ᤬ᜮ琰焲Ĵж簸ᘺ༼༾瑀穂桄獆筈祊ୌ扎桐晒ၔ杖瑘湚桜桞╠≢層兦奨塪啬⹮㝰", num), 15);
                dictionary1.Add(BookmarkStart.b("渪氬ᠮ猰爲瀴6࠸ᘺ笼紾牀ł桄癆硈ࡊौ扎ၐ橒敔摖瑘歚浜Ṟ⁠卢啤剦塨孪⡬⹮䉰", num), 0x10);
                dictionary1.Add(BookmarkStart.b("ᠪ測Ḯर瘲琴父സᘺ缼簾獀療桄獆硈硊祌扎ፐ摒ᅔᅖ瑘橚ᡜᱞ⁠剢噤呦幨⽪⥬⭮㉰", num), 0x11);
                dictionary1.Add(BookmarkStart.b("ᰪᠬ欮İȲԴ6सᘺ఼ാ牀睂桄獆絈๊瑌扎楐慒ፔ慖瑘὚὜橞⍠偢層♦嵨屪⹬幮䉰", num), 0x12);
                dictionary1.Add(BookmarkStart.b("横氬Ḯ԰甲ఴ琶8ᘺ଼ാ̀療桄獆罈硊穌扎楐ቒᙔ捖瑘捚᭜浞呠Ⅲ⍤啦偨⽪塬⹮䙰", num), 0x13);
                dictionary1.Add(BookmarkStart.b("洪᤬ᠮаܲ瘴ึ笸ᘺ଼ା݀療桄獆ୈ罊経扎楐ቒፔ捖瑘浚橜晞噠偢坤♦⩨孪孬彮䙰", num), 20);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ఴܶसᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x15);
                dictionary1.Add(BookmarkStart.b("ᨪᔬ渮İԲ眴Ķ笸ᘺ༼社牀Ղ桄獆ై祊ཌ扎ၐ敒摔晖瑘湚潜ᵞ①啢噤噦⭨奪⥬嵮䍰", num), 0x16);
                dictionary1.Add(BookmarkStart.b("ᨪ漬ᴮܰȲ眴Զସᘺ簼簾着ɂ桄獆ై絊界扎ၐ歒扔杖瑘ᩚ὜橞兠孢啤≦全嵪啬塮㍰", num), 0x17);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ఴܶ࠸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x18);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ఴุܶᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x19);
                dictionary1.Add(BookmarkStart.b("ሪᰬᴮ瀰焲瘴ȶସᘺ฼ाр煂桄獆繈穊祌扎楐ᙒ捔敖瑘ᩚ敜ᵞ噠偢♤♦屨⹪幬噮䅰", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰ܲ4ܶसᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ഴض࠸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ഴԶ࠸ᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("渪氬洮爰瘲瘴猶笸ᘺ縼簾灀B桄獆ࡈ絊ୌ扎ፐ杒ၔ摖瑘汚᭜杞奠孢⑤剦⡨⽪⭬Ɱ䥰", num), 30);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ഴжसᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ഴضसᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x20);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰̲ഴжਸᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x21);
                dictionary1.Add(BookmarkStart.b("漪Ḭ樮Ȱܲ眴Զ࠸ᘺм笾癀療桄癆祈穊ౌ扎楐ၒ晔ፖ瑘歚浜Ṟ⁠卢啤噦⡨婪孬婮䍰", num), 0x22);
                dictionary1.Add(BookmarkStart.b("ᬪᴬἮ̰瀲瀴ܶਸᘺ഼༾煀獂桄睆祈筊経扎ቐ捒敔杖瑘歚浜潞兠卢啤坦奨孪嵬孮䝰", num), 0x23);
                Class1160.dictionary_187 = dictionary1;
            }
            if (Class1160.dictionary_187.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BookmarkStart.b("渪唬䰮吰弲᬴搶儸帺堼䬾潀筂", num);

                    case 1:
                        return BookmarkStart.b("渪唬䰮吰弲᬴搶儸帺堼䬾ీ≂♄㕆♈๊⍌⹎㍐㽒ご㍖睘橚潜", num);

                    case 2:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⽂ⱄ⍆ⱈᡊ╌⁎♐絒摔敖", num);

                    case 3:
                        return BookmarkStart.b("簪䈬崮唰ᴲ焴堶娸为值娾⽀㝂歄罆", num);

                    case 4:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⽂ⱄ⍆ⱈᡊ╌⁎♐絒浔", num);

                    case 5:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⽂ⱄ⍆ⱈᡊ╌⁎♐Ṓ㑔㑖⭘㑚ᡜㅞ`Ţ।ɦ൨䕪屬嵮", num);

                    case 6:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⽂ⱄ⍆ⱈ敊界", num);

                    case 7:
                        return BookmarkStart.b("昪縬欮䌰刲䈴", num);

                    case 8:
                        return BookmarkStart.b("笪漬崮䐰䀲崴", num);

                    case 9:
                        return BookmarkStart.b("渪尬娮倰䜲尴堶圸", num);

                    case 10:
                        return BookmarkStart.b("笪䰬䰮娰刲刴制", num);

                    case 11:
                        return BookmarkStart.b("砪䈬娮弰圲朴制娸", num);

                    case 12:
                        return BookmarkStart.b("昪紬䌮倰䨲倴䔶", num);

                    case 13:
                        return BookmarkStart.b("簪紬栮䌰刲䔴弶倸堺༼฾", num);

                    case 14:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⭂⩄う杈籊", num);

                    case 15:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⽂ⱄ⍆ⱈ敊籌絎", num);

                    case 0x10:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⽂ⱄ⍆ⱈ敊穌", num);

                    case 0x11:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾቀ⽂ⱄ⍆ⱈيⱌⱎ⍐㱒ၔ㥖㡘㥚ㅜ㩞ՠ䵢呤啦", num);

                    case 0x12:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾᕀ♂⡄㝆╈⩊㥌⩎罐扒杔", num);

                    case 0x13:
                        return BookmarkStart.b("笪䈬堮吰䄲攴堶倸唺䤼ᄾᕀ♂⡄㝆╈⩊㥌⩎᱐㉒㙔╖㙘Ṛ㍜㹞͠རdͦ䝨婪彬", num);

                    case 20:
                        return BookmarkStart.b("簪䈬崮唰ᴲ焴堶娸为值娾⽀㝂歄癆筈", num);

                    case 0x15:
                        return BookmarkStart.b("簪䈬崮唰ᴲ焴堶娸为值娾⽀㝂歄煆", num);

                    case 0x16:
                        return BookmarkStart.b("簪䈬崮唰ᴲ焴堶娸为值娾⽀㝂ࡄ♆⩈㥊≌੎㽐㉒㝔㭖㱘㽚獜湞占", num);

                    case 0x17:
                        return BookmarkStart.b("簪䈬崮唰ᴲ稴䜶尸唺礼倾≀㙂⡄≆❈㽊᥌⩎⥐❒答晖歘", num);

                    case 0x18:
                        return BookmarkStart.b("簪䈬崮唰ᴲ攴帶娸伺䠼䴾⑀浂獄", num);

                    case 0x19:
                        return BookmarkStart.b("簪䈬崮唰ᴲ攴帶娸伺䠼䴾⑀浂組", num);

                    case 0x1a:
                        return BookmarkStart.b("簪䈬崮唰ᴲ愴制吸䬺儼帾㕀♂歄癆筈", num);

                    case 0x1b:
                        return BookmarkStart.b("渪唬䰮吰弲᬴瘶䤸䬺儼嘾≀≂ㅄ⹆♈╊捌繎捐", num);

                    case 0x1c:
                        return BookmarkStart.b("渪唬䰮吰弲᬴琶儸娺似䬾潀療", num);

                    case 0x1d:
                        return BookmarkStart.b("渪唬䰮吰弲᬴琶儸娺似䬾潀筂", num);

                    case 30:
                        return BookmarkStart.b("渪唬䰮吰弲᬴砶䤸帺匼笾⹀⁂い⩆ⱈ╊㥌ᱎ⅐⅒ご㙖㵘⡚㕜㩞Ѡᝢ䭤噦孨", num);

                    case 0x1f:
                        return BookmarkStart.b("渪唬䰮吰弲᬴搶儸帺堼䬾潀牂睄", num);

                    case 0x20:
                        return BookmarkStart.b("渪唬䰮吰弲᬴搶儸帺堼䬾潀療", num);

                    case 0x21:
                        return BookmarkStart.b("渪唬䰮吰弲᬴搶儸帺堼䬾̀⩂⭄♆㭈㉊L⹎㉐⅒㩔ቖ㝘㩚㽜㍞Ѡݢ䭤噦孨", num);

                    case 0x22:
                        return BookmarkStart.b("笪䰬䘮弰䜲᬴朶倸堺䤼䨾㍀♂", num);

                    case 0x23:
                        return BookmarkStart.b("渪尬娮倰䜲尴堶圸ᔺ礼氾ీᝂ煄", num);
                }
            }
        }
        return BookmarkStart.b("縪䌬䐮弰尲䈴夶", num);
    }

    internal static string smethod_10(VerticalAlignment A_0, TextOrientation A_1, HorizontalAlignment A_2, bool A_3)
    {
        int num = 7;
        switch (A_0)
        {
            case VerticalAlignment.Top:
                if (A_1 != TextOrientation.Upward)
                {
                    break;
                }
                if (A_2 != HorizontalAlignment.Left)
                {
                    if (A_2 == HorizontalAlignment.Center)
                    {
                        return BookmarkStart.b("䀬䘮唰圲头制", num);
                    }
                    break;
                }
                return BookmarkStart.b("伬䀮䔰䜲娴娶", num);

            case VerticalAlignment.Middle:
                if (A_1 != TextOrientation.Upward)
                {
                    goto Label_006E;
                }
                if (A_2 != HorizontalAlignment.Left)
                {
                    if (A_2 == HorizontalAlignment.Right)
                    {
                        return BookmarkStart.b("夬䀮䄰", num);
                    }
                    goto Label_006E;
                }
                return BookmarkStart.b("伬䀮䔰䜲娴娶", num);

            case VerticalAlignment.Bottom:
                if (A_1 != TextOrientation.Upward)
                {
                    if (!A_3)
                    {
                        return null;
                    }
                    return BookmarkStart.b("伬䀮䔰䜲娴娶", num);
                }
                if (A_2 != HorizontalAlignment.Right)
                {
                    if (A_2 == HorizontalAlignment.Center)
                    {
                        return BookmarkStart.b("䀬䘮唰圲头制", num);
                    }
                    return BookmarkStart.b("伬䀮䔰䜲娴娶", num);
                }
                return BookmarkStart.b("夬䀮䄰", num);

            default:
                return null;
        }
        return BookmarkStart.b("夬䀮䄰", num);
    Label_006E:
        return BookmarkStart.b("䀬䘮唰圲头制", num);
    }

    internal static string smethod_11(bool A_0, HorizontalAlignment A_1, TextOrientation A_2, VerticalAlignment A_3)
    {
        int num = 1;
        switch (A_1)
        {
            case HorizontalAlignment.Left:
                if (A_2 != TextOrientation.Upward)
                {
                    break;
                }
                if (A_3 != VerticalAlignment.Bottom)
                {
                    if (A_3 == VerticalAlignment.Middle)
                    {
                        return BookmarkStart.b("䐦䰨䔪夬䨮䌰", num);
                    }
                    break;
                }
                return BookmarkStart.b("唦䀨䰪䔬嬮", num);

            case HorizontalAlignment.Center:
                if (A_2 != TextOrientation.Upward)
                {
                    return BookmarkStart.b("䐦䰨䔪夬䨮䌰", num);
                }
                if (A_3 != VerticalAlignment.Bottom)
                {
                    if (A_3 == VerticalAlignment.Middle)
                    {
                        return BookmarkStart.b("䐦䰨䔪夬䨮䌰", num);
                    }
                    return null;
                }
                return BookmarkStart.b("唦䀨䰪䔬嬮", num);

            case HorizontalAlignment.Right:
                if (A_2 != TextOrientation.Upward)
                {
                    goto Label_00A4;
                }
                if (A_3 != VerticalAlignment.Top)
                {
                    if (A_3 == VerticalAlignment.Middle)
                    {
                        return BookmarkStart.b("䐦䰨䔪夬䨮䌰", num);
                    }
                    goto Label_00A4;
                }
                return null;

            case HorizontalAlignment.Justify:
            case HorizontalAlignment.Distribute:
                return BookmarkStart.b("䴦尨堪夬䘮地䨲", num);

            default:
                return null;
        }
        if (!A_0)
        {
            return null;
        }
        return BookmarkStart.b("䬦䰨䴪夬", num);
    Label_00A4:
        return BookmarkStart.b("唦䀨䰪䔬嬮", num);
    }

    internal static string smethod_12(TextOrientation A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case TextOrientation.Horizontal:
            case TextOrientation.Upward:
                return null;

            case TextOrientation.Downward:
                return BookmarkStart.b("嬮匰Ḳ䜴嬶", num);

            case TextOrientation.HorizontalRotatedFarEast:
                return BookmarkStart.b("䌮䌰Ḳ䄴唶ᐸ䴺", num);

            case TextOrientation.VerticalFarEast:
                return BookmarkStart.b("嬮匰Ḳ䜴嬶ᐸ䴺", num);
        }
        return BookmarkStart.b("弮倰吲倴", num);
    }

    internal static Class109 smethod_13(ShapeBase A_0, int A_1)
    {
        int num = 10;
        Class109 class2 = new Class109();
        if (!A_0.ShapePr.HasValue(0x1ce))
        {
            return class2;
        }
        switch (((LineDashing) A_0.ShapePr.method_31(0x1ce)))
        {
            case LineDashing.Dash:
                return smethod_14(BookmarkStart.b("簯嬱娳匵朷࠹఻愽ጿ㙁㵃⩅ⵇᕉ繋繍ཏ歑", num), A_1, BookmarkStart.b("簯嬱娳匵ᠷ椹䠻䜽ⰿ❁摃罅", num), BookmarkStart.b("į", num), BookmarkStart.b("į଱̳ጵ", num), null, null, BookmarkStart.b("į1гጵ", num));

            case LineDashing.Dot:
                return smethod_14(BookmarkStart.b("漯ıس椵朷࠹఻愽пⵁぃ㕅ᝇ硉籋ᅍ慏൑晓晕ݗṙ㵛ⵝ࡟", num), A_1, BookmarkStart.b("ȯሱ瀳夵䰷䤹᰻༽怿ف╃㕅⁇", num), BookmarkStart.b("ȯ", num), null, BookmarkStart.b("į", num), BookmarkStart.b("/ᰱسصଷ夹儻", num), BookmarkStart.b("/ᰱسصଷ夹儻", num));

            case LineDashing.DashDot:
                return smethod_14(BookmarkStart.b("瘯嬱娳匵朷࠹఻愽п⍁㝃⹅ⵇ⹉", num), A_1, BookmarkStart.b("瘯嬱娳匵ᠷ縹崻䴽⠿❁⁃", num), BookmarkStart.b("į", num), BookmarkStart.b("/ᰱĳص7夹儻", num), BookmarkStart.b("į", num), BookmarkStart.b("/ᰱĳص7夹儻", num), BookmarkStart.b("/ᰱĳص7夹儻", num));

            case LineDashing.DashDotDot:
                return smethod_14(BookmarkStart.b("支帱䀳䐵夷尹唻倽┿ᵁ癃癅ᝇ硉ፋ籍恏൑ၓ㥕ⱗ⥙͛汝偟㵡坣㥥婧婩㍫⩭ᅯűᱳ፵୷", num), A_1, BookmarkStart.b("支帱䀳䐵夷尹唻倽┿扁癃晅ే╉㡋㵍灏慑瑓ቕ㥗⥙㑛㭝፟", num), BookmarkStart.b("ȯ", num), BookmarkStart.b("/ᰱг̵ष夹儻", num), BookmarkStart.b("̯", num), BookmarkStart.b("/ᰱس̵ష夹儻", num), BookmarkStart.b("/ᰱԳе༷夹儻", num));

            case LineDashing.DotGEL:
                return smethod_14(BookmarkStart.b("瘯嬱娳匵朷࠹఻愽пⵁぃ㉅ⵇ⹉", num), A_1, BookmarkStart.b("瘯嬱娳匵ᠷ縹医䨽㐿❁⁃", num), BookmarkStart.b("į", num), null, null, null, BookmarkStart.b("/ᰱ3̵༷夹儻", num));

            case LineDashing.DashGEL:
                return smethod_14(BookmarkStart.b("瘯嬱娳匵朷࠹఻愽п⍁㝃⹅ⵇ⹉ፋ籍恏൑୓摕恗ՙ⩛㽝቟㵡噣彥㝧", num), A_1, BookmarkStart.b("瘯嬱娳匵ᠷ縹崻䴽⠿❁⁃晅恇㱉ⵋ㱍祏", num), BookmarkStart.b("į", num), BookmarkStart.b("į଱̳ጵ", num), null, null, BookmarkStart.b("į଱̳ጵ", num));

            case LineDashing.LongDashGEL:
                return smethod_14(BookmarkStart.b("瘯嬱娳匵朷࠹఻愽п⍁㝃⹅ⵇ⹉", num), A_1, BookmarkStart.b("瘯嬱娳匵ᠷ縹崻䴽⠿❁⁃", num), BookmarkStart.b("į", num), BookmarkStart.b("/ᰱĳص7夹儻", num), BookmarkStart.b("į", num), BookmarkStart.b("/ᰱĳص7夹儻", num), BookmarkStart.b("/ᰱĳص7夹儻", num));

            case LineDashing.DashDotGEL:
                return smethod_14(BookmarkStart.b("支帱䀳䐵夷尹唻倽┿ᵁ癃癅ᝇ硉ፋ籍恏൑ၓ㥕ⱗ⥙͛汝偟㵡坣㥥婧婩㍫⩭ᅯűᱳ፵୷", num), A_1, BookmarkStart.b("支帱䀳䐵夷尹唻倽┿扁癃晅ే╉㡋㵍灏慑瑓ቕ㥗⥙㑛㭝፟", num), BookmarkStart.b("ȯ", num), BookmarkStart.b("/ᰱг̵ष夹儻", num), BookmarkStart.b("̯", num), BookmarkStart.b("/ᰱس̵ష夹儻", num), BookmarkStart.b("/ᰱԳе༷夹儻", num));

            case LineDashing.LongDashDotGEL:
                return smethod_14(BookmarkStart.b("簯嬱娳匵朷࠹఻愽㜿⭁ぃ⹅ᝇ硉籋ᅍᙏ㭑㩓㍕ݗ桙汛ŝ⑟ൡၣᕥ", num), A_1, BookmarkStart.b("簯嬱娳匵ᠷ䴹唻䨽⠿扁Ƀ⽅♇⽉汋੍㽏♑❓", num), BookmarkStart.b("į", num), BookmarkStart.b("ȯᰱгص༷夹儻", num), BookmarkStart.b("įȱ", num), null, BookmarkStart.b("/ᰱг̵༷夹儻", num));

            case LineDashing.LongDashDotDotGEL:
                return smethod_14(BookmarkStart.b("支帱䀳䐵夷尹唻倽┿ᵁ癃癅ᝇ硉ፋ籍恏൑ၓ㥕ⱗ⥙͛汝偟㵡坣㥥婧婩㍫⩭ᅯűᱳ፵୷", num), A_1, BookmarkStart.b("支帱䀳䐵夷尹唻倽┿扁癃晅ే╉㡋㵍灏慑瑓ቕ㥗⥙㑛㭝፟", num), BookmarkStart.b("ȯ", num), BookmarkStart.b("/ᰱг̵ष夹儻", num), BookmarkStart.b("̯", num), BookmarkStart.b("/ᰱس̵ష夹儻", num), BookmarkStart.b("/ᰱԳе༷夹儻", num));
        }
        return smethod_14(BookmarkStart.b("瘯嬱娳匵朷࠹఻愽пⵁぃ㉅ⵇ⹉", num), A_1, BookmarkStart.b("瘯嬱娳匵ᠷ縹医䨽㐿❁⁃", num), BookmarkStart.b("į", num), null, null, null, BookmarkStart.b("/ᰱ3̵༷夹儻", num));
    }

    private static Class109 smethod_14(string A_0, int A_1, string A_2, string A_3, string A_4, string A_5, string A_6, string A_7)
    {
        Class109 class2 = new Class109();
        class2.method_1(string.Format(BookmarkStart.b("䨰̲䠴䰶࠸䘺", 11), A_0, A_1));
        class2.method_3(A_2);
        class2.method_7(A_3);
        class2.method_9(A_4);
        class2.method_11(A_5);
        class2.method_13(A_6);
        class2.method_15(A_7);
        return class2;
    }

    private static string smethod_15(string A_0)
    {
        int num = 9;
        if (Class567.smethod_16(A_0))
        {
            return string.Format(BookmarkStart.b("吮İ串ᔴ", num), A_0);
        }
        return "";
    }

    internal static LineDashing smethod_16(string A_0, Class109 A_1)
    {
        int num = 2;
        if (A_0 != BookmarkStart.b("嬧䔩䀫䜭启", 2))
        {
            if (!(A_0 == BookmarkStart.b("䰧䬩弫䘭", num)) || (A_1 == null))
            {
                return LineDashing.Solid;
            }
            string key = string.Format(BookmarkStart.b("匧ᨩ儫唭į伱伳е䔷䄹༻䌽㬿癁㥃", num), new object[] { smethod_15(A_1.method_6()), smethod_15(A_1.method_8()), smethod_15(A_1.method_10()), smethod_15(A_1.method_12()), smethod_15(A_1.method_14()).Trim() });
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_188 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x10);
                    dictionary1.Add(BookmarkStart.b("ᬧ਩ᤫอ/ᰱге7夹儻ḽ瀿汁瑃獅罇⥉⅋", num), 0);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᰫ-ԯȱళ唵唷ᨹ഻ḽ瀿汁煃癅灇⥉⅋湍恏籑慓晕恗㥙ㅛ", num), 1);
                    dictionary1.Add(BookmarkStart.b("ᨧ਩ᰫ-/ܱԳ唵唷ᨹ༻ḽ瀿汁癃獅籇⥉⅋湍恏籑敓摕潗㥙ㅛ", num), 2);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᰫ-Яܱ̳唵唷", num), 3);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ḫ-/ȱ̳唵唷ᨹ഻฽怿牁橃癅絇絉⽋⍍", num), 4);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᰫ-/̱ളĵ嬷圹᰻฽渿牁畃罅罇⥉⅋", num), 5);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᴫᜭܯᜱᐳܵķഹ᤻", num), 6);
                    dictionary1.Add(BookmarkStart.b("ᬧ਩ᰫ-/̱ളĵ嬷圹᰻ഽ怿牁橃癅祇⥉⅋", num), 7);
                    dictionary1.Add(BookmarkStart.b("ᬧ਩ᴫᜭܯᜱᐳԵᠷହ఻฽政", num), 8);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᰫ-/ȱĳ唵唷", num), 9);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᤫḭᔯ", num), 10);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᰫ-/̱ളĵ嬷圹᰻฽渿牁畃瑅⭇❉楋", num), 11);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᴫᜭܯᜱᐳܵ਷ਹ᤻", num), 12);
                    dictionary1.Add(BookmarkStart.b("ᨧ਩ᴫอ/ᰱسصଷ夹儻ḽ瀿汁癃癅筇⥉⅋", num), 13);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᰫ-/̱ളĵ嬷圹᰻฽渿牁畃瑅罇⥉⅋", num), 14);
                    dictionary1.Add(BookmarkStart.b("ᤧ਩ᴫᜭܯᜱᐳܵ਷ഹ᤻", num), 15);
                    Class1160.dictionary_188 = dictionary1;
                }
                if (Class1160.dictionary_188.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            return LineDashing.DashDotDot;

                        case 1:
                            return LineDashing.LongDashGEL;

                        case 2:
                            return LineDashing.DashDotDot;

                        case 3:
                            return LineDashing.Dot;

                        case 4:
                            return LineDashing.LongDashDotGEL;

                        case 5:
                        case 6:
                            return LineDashing.Dash;

                        case 7:
                        case 8:
                            return LineDashing.DashDotDot;

                        case 9:
                        case 10:
                            return LineDashing.Dot;

                        case 11:
                        case 12:
                            return LineDashing.Dash;

                        case 13:
                            return LineDashing.Dot;

                        case 14:
                        case 15:
                            return LineDashing.Dash;
                    }
                }
            }
        }
        return LineDashing.Solid;
    }

    internal static void smethod_17(Class857 A_0, string A_1, Class43 A_2, bool A_3)
    {
        int num = 1;
        Class110 class2 = (Class110) A_0.method_13().method_2(Class576.smethod_87(A_1), null, false, false);
        if (class2 != null)
        {
            ArrowType arrow = ArrowType.Arrow;
            string key = string.Format(BookmarkStart.b("尦ᤨ嘪嘬Ḯ䰰", num), class2.method_4(), class2.method_6());
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_189 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബᴮİጲشܶ吸਺഼Ἶ煀湂瑄睆楈硊経❎捐捒⽔", num), 0);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮȰĲд᜶ਸ༺мాⱀ牂癄畆硈歊繌筎桐恒㵔穖桘桚潜湞ൠ呢啤啦䑨塪奬噮䉰ॲ", num), 1);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮ02д᜶࠸Ⱥ఼ܾⱀ瑂癄灆楈穊籌籎恐㭒晔湖浘㝚灜橞坠坢䡤噦塨塪屬䉮䑰䕲䉴坶䡸䩺乼乾낂버뾆Ꚋ뺌뚎ꦐ뎒ꊔ꾖꺘겜꺞銠銢\udfa4", num), 2);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮİȲش᜶࠸਺฼༾ⱀ牂畄睆灈歊籌罎摐捒硔捖浘扚灜湞兠卢嵤䩦孨奪䁬屮䅰干䝴乶呸䩺佼剾늀랂ꖄ뚆뮈Ꚋ뾌뺎놐ꆒꎔ몖궘꾚꒜뾞邠鎢钤閦蒨麪趬麮芰얲趴\udbb6\u8cb8鮺込躾﯈響ﻎ律￞헠询\udce4\ud7e6\udae8\u87ea\udfec\udeee\udcf0\uc7f2헴엶죸훺쳼쳾℀㨂⠄㔆㠈⬊㤌∎⌐−挔㨖℘愚", num), 3);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮ02д᜶8଺༼刾瑀畂煄杆祈晊硌祎敐獒汔杖歘㍚汜湞剠剢ὤ", num), 4);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮ02д᜶ସऺ࠼ाⱀ牂瑄畆繈歊罌繎捐捒硔捖浘扚灜浞兠卢卤䩦偨䙪奬嵮屰䅲䁴婶䩸䉺偼䱾릀꺂랄늆ꒈ뢊떌ꊎꦐ뺒ꆔ꒖릘ꎚ난겞馠莢鞤銦蒨馪颬辮芰課颴躶馸辺込銾ﳄ﯈﯊﷌硫Ꟑ믖﷜쇠\udae2\uc5e4폦\udbe8\ucbea\udfec\udaee퇰샲췴ퟶ쫸쏺\uddfc\ucdfe㐀⌂㄄㔆⤈㈊攌㘎ℐ‒礔⌖⬘㘚␜㼞ሠᬢࠤᔦᰨପἬ᤮ᰰ2ഴ᜶ĸᘺ़ാ㝀湂籄㵆", num), 5);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮİጲдܶ吸଺ᴼ༾⥀牂畄ㅆ硈筊╌扎恐捒⽔", num), 6);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮ02д᜶࠸਺฼฾ⱀ獂敄牆罈罊浌穎材杒畔扖潘汚絜橞坠呢䡤剦彨屪䁬婮䝰䑲塴䉶佸佺ݼ", num), 7);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബᜮȰԲᔴض࠸଺值༾慀獂ⵄ畆繈獊浌絎晐歒畔敖慘歚⭜汞坠䍢噤兦䥨塪啬ݮ屰䅲䉴佶呸䥺䩼䝾검놂분랆ﾈꚊ뺌릎벐ꂒꎔ", num), 8);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮ02д᜶࠸਺฼฾ⱀ睂獄畆楈穊籌繎楐繒摔杖歘癚潜晞䱠剢啤啦䑨幪屬䉮䡰䁲塴䁶䭸噺䩼䵾검몂뚄ꪆ번몊ꂌ뺎ꆐꆒ뢔ꖖꂘ뚚겜꾞鎠躢钤钦蒨骪鶬骮醰芲蚴骶袸论込龾輸杻﷊龜ﻒﯚ쳠\udbe2\udce4쟦탨\ud8ea\uc0ec\ud8ee\uc3f0폲쓴쟶쯸훺주쿾℀㈂㔄㔆␈㠊㤌⼎‐⌒⌔㨖‘㬚Ⱌ⼞ဠ̢ᰤܦᠨᬪᬬ༮Ȱܲᔴึĸᬺ࠼༾慀穂癄杆繈祊浌硎捐獒浔湖祘湚汜罞偠卢坤䝦孨剪䵬幮䅰䕲啴䙶䩸孺䱼佾뎀꺂뒄뒆ꦈ몊붌몎벐ꆒ겔랖ꢘꮚ꾜늞钠銢薤隦馨馪肬颮莰鎲貴蒶钸芺躼龾ﻆﻎﳐ律탠폢퓤쟦\ud8e8\ud8ea韬", num), 9);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮ0Ĳܴ᜶ସऺ़ాⱀ獂敄畆硈筊界㥎恐摒畔晖湘㝚汜浞䅠坢坤䝦婨孪䵬屮䕰卲䙴佶奸䥺䱼彾떀낂ꖄ뎆ꦈ릊뒌ꊎꦐ뎒ꚔꞖ뒘ꦚ겜뾞鎠隢袤閦龨讪鲬鲮鲰育膴鞶誸辺躼銾ﻌﯚ쇠ퟢퟤ쟦\udbe8\ud2ea췬\udcee\uc5f0폲웴컶\ud9f8\uc9fa쳼\udffe\u3500㄂┄㌆⤈㼊㼌∎‐ℒ㔔␖ⴘ㘚⸜⼞Ġᄢᐤਦᴨᤪ嬬ȮȰਲᠴضସ场ြା慀睂桄獆絈筊恌繎桐橒浔穖恘癚楜浞䱠兢偤䩦婨剪䁬屮䥰干䝴䉶呸佺乼剾릀꺂놄떆ꦈ뎊ꂌ벎ꦐ뎒ꞔꊖ뒘ꦚꮜ뾞銠骢袤龦覨龪龬햮", num), 10);
                    dictionary1.Add(BookmarkStart.b("ᜦनᬪബḮ02д᜶࠸ฺԼ༾ⱀ牂畄癆穈歊籌筎桐扒畔晖桘捚絜杞塠乢偤兦幨䙪屬婮䥰䍲塴䉶佸佺嵼乾뒀뮂떄Ꞇ뢈몊릌ꊎꦐꚒ떔Ꚗꪘ궚난ꦞ馠莢钤鎦醨蚪馬馮醰芲莴蚶钸誺誼龾ﻎꇚ", num), 11);
                    Class1160.dictionary_189 = dictionary1;
                }
                if (Class1160.dictionary_189.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            arrow = ArrowType.Arrow;
                            break;

                        case 6:
                        case 7:
                            arrow = ArrowType.Diamond;
                            break;

                        case 8:
                            A_2.SetAttr(A_3 ? 0x1d3 : 0x1d5, StrokeArrowLength.Short);
                            A_2.SetAttr(A_3 ? 0x1d2 : 0x1d4, StrokeArrowWidth.Wide);
                            arrow = ArrowType.Oval;
                            break;

                        case 9:
                            arrow = ArrowType.Oval;
                            break;

                        case 10:
                            arrow = ArrowType.Open;
                            break;

                        case 11:
                            arrow = ArrowType.Stealth;
                            break;
                    }
                }
            }
            A_2.SetAttr(A_3 ? 0x1d0 : 0x1d1, arrow);
        }
    }

    internal static string smethod_18(PropertyValueType A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case PropertyValueType.Boolean:
                return BookmarkStart.b("䔦䘨䐪䄬䨮倰崲", num);

            case PropertyValueType.Date:
                return BookmarkStart.b("䌦䠨弪䠬", num);

            case PropertyValueType.Double:
            case PropertyValueType.Int:
                return BookmarkStart.b("䄦䔨䐪䰬嬮", num);
        }
        return null;
    }

    internal static FillType smethod_19(string A_0, Class111 A_1)
    {
        int num = 5;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䤪䐬嬮尰刲䔴", num))
            {
                return FillType.Picture;
            }
            if (str == BookmarkStart.b("䰪弬丮唰娲倴夶䴸", num))
            {
                return smethod_20(A_1);
            }
            if ((str == BookmarkStart.b("堪䈬䌮堰圲", num)) || (str == BookmarkStart.b("䌪䰬嬮到嬲", num)))
            {
                return FillType.Solid;
            }
        }
        return FillType.Solid;
    }

    internal static ConnectionSiteType smethod_2(string A_0)
    {
        return (ConnectionSiteType) Class791.smethod_3(hashtable_24, A_0, ShapeVerticalAlignment.None);
    }

    private static FillType smethod_20(Class111 A_0)
    {
        string str;
        int num = 5;
        if ((A_0 != null) && ((str = A_0.method_4()) != null))
        {
            int num2;
            if (Class1160.dictionary_190 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("䨪唬䘮倰弲", num), 0);
                dictionary1.Add(BookmarkStart.b("䜪䐬䄮吰刲䜴", num), 1);
                dictionary1.Add(BookmarkStart.b("太䠬䰮䔰刲嬴倶䰸场尼䴾", num), 2);
                dictionary1.Add(BookmarkStart.b("个䄬䌮堰䌲䘴堶倸强", num), 3);
                dictionary1.Add(BookmarkStart.b("太䰬䬮堰刲头", num), 4);
                dictionary1.Add(BookmarkStart.b("堪尬娮倰䄲倴", num), 5);
                Class1160.dictionary_190 = dictionary1;
            }
            if (Class1160.dictionary_190.TryGetValue(str, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return FillType.ShadeScale;

                    case 2:
                        return FillType.ShadeShape;

                    case 3:
                    case 4:
                    case 5:
                        return FillType.ShadeCenter;
                }
            }
        }
        return FillType.Shade;
    }

    internal static string smethod_21(FillType A_0)
    {
        int num = 6;
        switch (A_0)
        {
            case FillType.Solid:
                return BookmarkStart.b("弫䄭尯嬱倳", num);

            case FillType.Picture:
                return BookmarkStart.b("丫䜭䐯弱唳䘵", num);

            case FillType.Shade:
            case FillType.ShadeCenter:
            case FillType.ShadeShape:
            case FillType.ShadeScale:
            case FillType.ShadeTitle:
                return BookmarkStart.b("䬫尭儯嘱崳匵嘷丹", num);
        }
        return null;
    }

    internal static string smethod_22(FillType A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case FillType.Shade:
            case FillType.ShadeShape:
                return BookmarkStart.b("吥䴧䤩堫伭帯唱䄳娵夷䠹", num);

            case FillType.ShadeCenter:
                return BookmarkStart.b("唥大弩䴫尭唯", num);

            case FillType.ShadeScale:
            case FillType.ShadeTitle:
                return BookmarkStart.b("䨥䄧䐩䤫伭䈯", num);
        }
        return null;
    }

    internal static string smethod_23(FootnoteRestartRule A_0)
    {
        int num = 14;
        if (A_0 == FootnoteRestartRule.RestartPage)
        {
            return BookmarkStart.b("䐳圵強弹", num);
        }
        return null;
    }

    internal static FootnoteRestartRule smethod_24(string A_0)
    {
        string str;
        int num = 15;
        if (((str = A_0) != null) && (str == BookmarkStart.b("䔴嘶常帺", num)))
        {
            return FootnoteRestartRule.RestartPage;
        }
        return FootnoteRestartRule.DoNotRestart;
    }

    internal static string smethod_25(FontFamily A_0)
    {
        return (string) Class791.smethod_3(hashtable_11, A_0, "");
    }

    internal static FontFamily smethod_26(string A_0)
    {
        return (FontFamily) Class791.smethod_3(hashtable_10, A_0, FontFamily.Auto);
    }

    internal static string smethod_27(FontPitch A_0)
    {
        return (string) Class791.smethod_3(hashtable_13, A_0, "");
    }

    internal static FontPitch smethod_28(string A_0)
    {
        return (FontPitch) Class791.smethod_3(hashtable_12, A_0, FontPitch.Default);
    }

    internal static FootnotePosition smethod_29(string A_0)
    {
        return (FootnotePosition) Class791.smethod_3(hashtable_8, A_0, FootnotePosition.PrintAtBottomOfPage);
    }

    internal static string smethod_3(ConnectionSiteType A_0)
    {
        return (string) Class791.smethod_3(hashtable_25, A_0, BookmarkStart.b("弰尲嬴制", 11));
    }

    internal static string smethod_30(FootnotePosition A_0)
    {
        return (string) Class791.smethod_3(hashtable_9, A_0, "");
    }

    internal static string smethod_31(TextWrappingStyle A_0, TextWrappingType A_1)
    {
        int num = 0;
        if (A_0 == TextWrappingStyle.TopAndBottom)
        {
            return BookmarkStart.b("䠥䜧䐩䤫", num);
        }
        if ((((A_0 != TextWrappingStyle.Behind) && (A_0 != TextWrappingStyle.InFrontOfText)) || ((A_1 != TextWrappingType.Both) && (A_1 != TextWrappingType.Both))) && (A_0 != TextWrappingStyle.Through))
        {
            if (A_1 == TextWrappingType.Left)
            {
                return BookmarkStart.b("䨥䴧䰩堫", num);
            }
            if (A_1 == TextWrappingType.Right)
            {
                return BookmarkStart.b("吥䄧䴩䐫娭", num);
            }
            if (A_1 == TextWrappingType.Largest)
            {
                return BookmarkStart.b("䐥䄧䴩䬫䬭䌯䘱", num);
            }
            if ((A_0 != TextWrappingStyle.Square) && (A_0 != TextWrappingStyle.Tight))
            {
                return null;
            }
            return BookmarkStart.b("嘥䤧堩䴫䈭尯圱堳", num);
        }
        return BookmarkStart.b("吥崧䐩ī娭堯䀱嬳䌵強刹", num);
    }

    internal static TextWrappingStyle smethod_32(string A_0, string A_1, string A_2, string A_3)
    {
        int num = 0x12;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_191 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䠷嬹主弽ⰿ⹁⅃⩅", num), 0);
                dictionary1.Add(BookmarkStart.b("吷弹娻䨽", num), 1);
                dictionary1.Add(BookmarkStart.b("䨷匹嬻嘽㐿", num), 2);
                dictionary1.Add(BookmarkStart.b("娷匹嬻夽┿ㅁぃ", num), 3);
                dictionary1.Add(BookmarkStart.b("尷䌹刻弽ⴿ⭁❃", num), 4);
                dictionary1.Add(BookmarkStart.b("嘷唹刻嬽", num), 5);
                dictionary1.Add(BookmarkStart.b("䨷伹刻ጽ㐿⩁㙃⥅㵇ⵉ⑋", num), 6);
                Class1160.dictionary_191 = dictionary1;
            }
            if (Class1160.dictionary_191.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        if (!(A_1 == BookmarkStart.b("䰷䠹䤻嬽", num)))
                        {
                            return TextWrappingStyle.Square;
                        }
                        if (!(A_2 == BookmarkStart.b("圷伹䠻䴽⤿♁⅃", num)))
                        {
                            return TextWrappingStyle.Through;
                        }
                        return TextWrappingStyle.Tight;

                    case 5:
                        return TextWrappingStyle.TopAndBottom;

                    case 6:
                        if (!(A_3 == BookmarkStart.b("娷嬹弻唽✿ぁ⭃㍅♇⹉", num)))
                        {
                            return TextWrappingStyle.InFrontOfText;
                        }
                        return TextWrappingStyle.Behind;
                }
            }
        }
        return TextWrappingStyle.TopAndBottom;
    }

    internal static TextWrappingType smethod_33(string A_0)
    {
        int num = 13;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("弲倴儶䴸", num))
            {
                return TextWrappingType.Left;
            }
            if (str == BookmarkStart.b("䄲尴倶儸伺", num))
            {
                return TextWrappingType.Right;
            }
            if (str == BookmarkStart.b("儲尴倶常帺丼䬾", num))
            {
                return TextWrappingType.Largest;
            }
        }
        return TextWrappingType.Both;
    }

    internal static string smethod_34(BorderStyle A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case BorderStyle.None:
                return BookmarkStart.b("就嬳堵崷", num);

            case BorderStyle.Double:
            case BorderStyle.ThinThickSmallGap:
            case BorderStyle.ThickThinSmallGap:
            case BorderStyle.ThinThickThinSmallGap:
            case BorderStyle.ThinThickMediumGap:
            case BorderStyle.ThickThinMediumGap:
            case BorderStyle.ThinThickThinMediumGap:
            case BorderStyle.ThinThickLargeGap:
            case BorderStyle.ThickThinLargeGap:
            case BorderStyle.ThinThickThinLargeGap:
            case BorderStyle.DoubleWave:
                return BookmarkStart.b("嘱嬳䌵娷嘹夻", num);

            case BorderStyle.Dot:
                return BookmarkStart.b("嘱嬳䈵䰷弹堻", num);

            case BorderStyle.DashLargeGap:
            case BorderStyle.DotDash:
            case BorderStyle.DotDotDash:
            case BorderStyle.DashSmallGap:
                return BookmarkStart.b("嘱唳䔵倷弹堻", num);

            case BorderStyle.Emboss3D:
                return BookmarkStart.b("唱䘳夵圷䰹夻", num);

            case BorderStyle.Engrave3D:
                return BookmarkStart.b("䀱崳刵強弹", num);

            case BorderStyle.Outset:
                return BookmarkStart.b("崱䄳䈵䬷弹䠻", num);

            case BorderStyle.Inset:
                return BookmarkStart.b("嬱娳䔵崷丹", num);
        }
        return BookmarkStart.b("䄱嬳娵儷帹", num);
    }

    internal static BorderStyle smethod_35(string A_0)
    {
        int num = 3;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_192 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                dictionary1.Add(BookmarkStart.b("䴨䐪夬嬮吰圲", num), 0);
                dictionary1.Add(BookmarkStart.b("䴨䨪帬䜮吰圲", num), 1);
                dictionary1.Add(BookmarkStart.b("䴨䐪堬䴮崰嘲", num), 2);
                dictionary1.Add(BookmarkStart.b("丨太䈬䀮䜰嘲", num), 3);
                dictionary1.Add(BookmarkStart.b("嬨䈪䤬䠮吰", num), 4);
                dictionary1.Add(BookmarkStart.b("䘨帪夬尮吰䜲", num), 5);
                dictionary1.Add(BookmarkStart.b("䀨䔪帬䨮䔰", num), 6);
                dictionary1.Add(BookmarkStart.b("䜨䐪䌬䨮", num), 7);
                dictionary1.Add(BookmarkStart.b("娨䐪䄬䘮唰", num), 8);
                Class1160.dictionary_192 = dictionary1;
            }
            if (Class1160.dictionary_192.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BorderStyle.Dot;

                    case 1:
                        return BorderStyle.DashLargeGap;

                    case 2:
                        return BorderStyle.Double;

                    case 3:
                        return BorderStyle.Emboss3D;

                    case 4:
                        return BorderStyle.Engrave3D;

                    case 5:
                        return BorderStyle.Outset;

                    case 6:
                        return BorderStyle.Inset;

                    case 7:
                        return BorderStyle.None;
                }
            }
        }
        return BorderStyle.Single;
    }

    internal static double smethod_36(TextureStyle A_0)
    {
        switch (A_0)
        {
            case TextureStyle.TextureNone:
            case TextureStyle.TextureNil:
                return 0.0;

            case TextureStyle.Texture5Percent:
                return 0.05;

            case TextureStyle.Texture10Percent:
                return 0.1;

            case TextureStyle.Texture20Percent:
                return 0.2;

            case TextureStyle.Texture25Percent:
                return 0.25;

            case TextureStyle.Texture30Percent:
                return 0.3;

            case TextureStyle.Texture40Percent:
                return 0.4;

            case TextureStyle.Texture50Percent:
                return 0.5;

            case TextureStyle.Texture60Percent:
                return 0.6;

            case TextureStyle.Texture70Percent:
                return 0.7;

            case TextureStyle.Texture75Percent:
                return 0.75;

            case TextureStyle.Texture80Percent:
                return 0.8;

            case TextureStyle.Texture90Percent:
                return 0.9;

            case TextureStyle.TextureDarkHorizontal:
            case TextureStyle.TextureDarkVertical:
            case TextureStyle.TextureDarkDiagonalDown:
            case TextureStyle.TextureDarkDiagonalUp:
            case TextureStyle.TextureDarkCross:
            case TextureStyle.TextureDarkDiagonalCross:
            case TextureStyle.TextureHorizontal:
            case TextureStyle.TextureVertical:
            case TextureStyle.TextureDiagonalDown:
            case TextureStyle.TextureDiagonalUp:
            case TextureStyle.TextureCross:
            case TextureStyle.TextureDiagonalCross:
                return 0.33;

            case TextureStyle.Texture2Pt5Percent:
                return 0.025;

            case TextureStyle.Texture7Pt5Percent:
                return 0.075;

            case TextureStyle.Texture12Pt5Percent:
                return 0.125;

            case TextureStyle.Texture15Percent:
                return 0.15;

            case TextureStyle.Texture17Pt5Percent:
                return 0.175;

            case TextureStyle.Texture22Pt5Percent:
                return 0.225;

            case TextureStyle.Texture27Pt5Percent:
                return 0.275;

            case TextureStyle.Texture32Pt5Percent:
                return 0.325;

            case TextureStyle.Texture35Percent:
                return 0.35;

            case TextureStyle.Texture37Pt5Percent:
                return 0.375;

            case TextureStyle.Texture42Pt5Percent:
                return 0.425;

            case TextureStyle.Texture45Percent:
                return 0.45;

            case TextureStyle.Texture47Pt5Percent:
                return 0.475;

            case TextureStyle.Texture52Pt5Percent:
                return 0.525;

            case TextureStyle.Texture55Percent:
                return 0.55;

            case TextureStyle.Texture57Pt5Percent:
                return 0.575;

            case TextureStyle.Texture62Pt5Percent:
                return 0.625;

            case TextureStyle.Texture65Percent:
                return 0.65;

            case TextureStyle.Texture67Pt5Percent:
                return 0.675;

            case TextureStyle.Texture72Pt5Percent:
                return 0.725;

            case TextureStyle.Texture77Pt5Percent:
                return 0.775;

            case TextureStyle.Texture82Pt5Percent:
                return 0.825;

            case TextureStyle.Texture85Percent:
                return 0.85;

            case TextureStyle.Texture87Pt5Percent:
                return 0.875;

            case TextureStyle.Texture92Pt5Percent:
                return 0.925;

            case TextureStyle.Texture95Percent:
                return 0.95;

            case TextureStyle.Texture97Pt5Percent:
                return 0.975;
        }
        return 1.0;
    }

    internal static TextOrientation smethod_37(string A_0)
    {
        int num = 5;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("弪伬Ȯ䌰弲", num))
            {
                return TextOrientation.Downward;
            }
            if (str == BookmarkStart.b("䜪弬Ȯ䔰儲ᠴ䄶", num))
            {
                return TextOrientation.HorizontalRotatedFarEast;
            }
            if (str == BookmarkStart.b("弪伬Ȯ䌰弲ᠴ䄶", num))
            {
                return TextOrientation.VerticalFarEast;
            }
        }
        return TextOrientation.Horizontal;
    }

    internal static string smethod_38(RelativeVerticalPosition A_0)
    {
        int num = 15;
        switch (A_0)
        {
            case RelativeVerticalPosition.Margin:
                return BookmarkStart.b("䔴嘶常帺ြ尾⹀ⵂㅄ≆❈㽊", num);

            case RelativeVerticalPosition.Page:
                return BookmarkStart.b("䔴嘶常帺", num);

            case RelativeVerticalPosition.Line:
                return BookmarkStart.b("头帶圸帺", num);
        }
        return BookmarkStart.b("䔴嘶䬸娺娼䴾⁀㍂ⵄ", num);
    }

    internal static RelativeVerticalPosition smethod_39(string A_0)
    {
        int num = 12;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("帱崳堵崷", num))
            {
                return RelativeVerticalPosition.Line;
            }
            if (str == BookmarkStart.b("䈱唳儵崷᜹弻儽⸿㙁⅃⡅㱇", num))
            {
                return RelativeVerticalPosition.Margin;
            }
            if (str == BookmarkStart.b("䈱唳儵崷", num))
            {
                return RelativeVerticalPosition.Page;
            }
        }
        return RelativeVerticalPosition.Paragraph;
    }

    internal static PathType smethod_4(char A_0)
    {
        switch (A_0)
        {
            case 'A':
                return PathType.ArcTo;

            case 'B':
                return PathType.Arc;

            case 'C':
                return PathType.CurveTo;

            case 'F':
                return PathType.NoFill;

            case 'L':
                return PathType.LineTo;

            case 'M':
                return PathType.MoveTo;

            case 'N':
                return PathType.End;

            case 'Q':
                return PathType.QuadraticBezier;

            case 'S':
                return PathType.NoLine;

            case 'T':
                return PathType.AngleEllipseTo;

            case 'U':
                return PathType.AngleEllipse;

            case 'V':
                return PathType.ClockwiseArc;

            case 'W':
                return PathType.ClockwiseArcTo;

            case 'X':
                return PathType.EllipticalQuadrantX;

            case 'Y':
                return PathType.EllipticalQuadrantY;

            case 'Z':
                return PathType.Close;
        }
        return PathType.Unknown;
    }

    internal static string smethod_40(ShapeVerticalAlignment A_0)
    {
        return (string) Class791.smethod_3(hashtable_15, A_0, BookmarkStart.b("丧堩䌫䌭ᴯ䘱嬳䘵", 2));
    }

    internal static ShapeVerticalAlignment smethod_41(string A_0)
    {
        return (ShapeVerticalAlignment) Class791.smethod_3(hashtable_14, A_0, ShapeVerticalAlignment.Top);
    }

    internal static string smethod_42(BaselineAlignment A_0)
    {
        return (string) Class791.smethod_3(hashtable_17, A_0, "");
    }

    internal static BaselineAlignment smethod_43(string A_0)
    {
        return (BaselineAlignment) Class791.smethod_3(hashtable_16, A_0, BaselineAlignment.Baseline);
    }

    internal static string smethod_44(RelativeHorizontalPosition A_0)
    {
        return (string) Class791.smethod_3(hashtable_21, A_0, BookmarkStart.b("弮倰䄲吴倶䬸娺䴼圾", 9));
    }

    internal static RelativeHorizontalPosition smethod_45(string A_0)
    {
        return (RelativeHorizontalPosition) Class791.smethod_3(hashtable_20, A_0, RelativeHorizontalPosition.Column);
    }

    internal static string smethod_46(HorizontalPosition A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case HorizontalPosition.Left:
                return BookmarkStart.b("娵崷尹䠻", num);

            case HorizontalPosition.Center:
                return BookmarkStart.b("唵崷吹䠻嬽㈿", num);

            case HorizontalPosition.Right:
                return BookmarkStart.b("䐵儷崹吻䨽", num);

            case HorizontalPosition.Inside:
                return BookmarkStart.b("張嘷䤹唻娽┿", num);

            case HorizontalPosition.Outside:
                return BookmarkStart.b("夵䴷丹伻圽␿❁", num);
        }
        return null;
    }

    internal static ShapeHorizontalAlignment smethod_47(string A_0)
    {
        int num = 3;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_193 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䨨个䌬嬮吰䄲", num), 0);
                dictionary1.Add(BookmarkStart.b("䀨䔪帬䘮唰嘲", num), 1);
                dictionary1.Add(BookmarkStart.b("䔨个䬬嬮", num), 2);
                dictionary1.Add(BookmarkStart.b("䘨帪夬尮堰圲倴", num), 3);
                dictionary1.Add(BookmarkStart.b("嬨䈪䨬䜮䔰", num), 4);
                dictionary1.Add(BookmarkStart.b("伨太䈬䈮ᰰ弲倴儶䴸", num), 5);
                dictionary1.Add(BookmarkStart.b("伨太䈬䈮ᰰ娲嬴䐶倸强堼", num), 6);
                Class1160.dictionary_193 = dictionary1;
            }
            if (Class1160.dictionary_193.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return ShapeHorizontalAlignment.Center;

                    case 1:
                        return ShapeHorizontalAlignment.Inside;

                    case 2:
                        return ShapeHorizontalAlignment.Left;

                    case 3:
                        return ShapeHorizontalAlignment.Outside;

                    case 4:
                        return ShapeHorizontalAlignment.Right;

                    case 5:
                    case 6:
                        return ShapeHorizontalAlignment.None;
                }
            }
        }
        return ShapeHorizontalAlignment.Left;
    }

    internal static CellVerticalAlignment smethod_48(string A_0)
    {
        int num = 0x10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("嬵儷帹堻刽┿", num))
            {
                return CellVerticalAlignment.Center;
            }
            if (str == BookmarkStart.b("吵圷丹䠻儽ⴿ", num))
            {
                return CellVerticalAlignment.Bottom;
            }
        }
        return CellVerticalAlignment.Top;
    }

    internal static TableAlignment smethod_49(string A_0)
    {
        int num = 15;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䜴帶常区䤼", num))
            {
                return TableAlignment.Right;
            }
            if (str == BookmarkStart.b("嘴制圸伺堼䴾", num))
            {
                return TableAlignment.Center;
            }
        }
        return TableAlignment.Left;
    }

    internal static PathType smethod_5(char A_0)
    {
        char ch = char.ToUpper(A_0);
        if (ch <= 'H')
        {
            switch (ch)
            {
                case 'A':
                    return PathType.ArcTo;

                case 'C':
                    goto Label_006E;

                case 'H':
                    goto Label_0078;
            }
            goto Label_0076;
        }
        switch (ch)
        {
            case 'L':
            case 'V':
                goto Label_0078;

            case 'M':
                return PathType.MoveTo;

            case 'N':
            case 'O':
            case 'P':
            case 'R':
            case 'U':
                goto Label_0076;

            case 'Q':
            case 'T':
                return PathType.QuadraticBezier;

            case 'S':
                break;

            default:
                if (ch != 'Z')
                {
                    goto Label_0076;
                }
                return PathType.Close;
        }
    Label_006E:
        return PathType.CurveTo;
    Label_0076:
        return PathType.Unknown;
    Label_0078:
        return PathType.LineTo;
    }

    internal static string smethod_50(TableAlignment A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case TableAlignment.Center:
                return BookmarkStart.b("䰮吰崲䄴制䬸", num);

            case TableAlignment.Right:
                return BookmarkStart.b("崮堰吲崴䌶", num);
        }
        return BookmarkStart.b("䌮吰唲䄴", num);
    }

    internal static string smethod_51(ArrowType A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case ArrowType.None:
                return BookmarkStart.b("昧䔩䈫䬭", num);

            case ArrowType.Arrow:
                return BookmarkStart.b("椧堩師䄭䜯", num);

            case ArrowType.Stealth:
                return BookmarkStart.b("笧帩䤫伭尯䘱尳", num);

            case ArrowType.Diamond:
                return BookmarkStart.b("氧䌩䴫䌭弯就倳", num);

            case ArrowType.Oval:
                return BookmarkStart.b("朧尩䴫䈭", num);

            case ArrowType.Open:
                return BookmarkStart.b("朧娩䤫䀭", num);
        }
        return null;
    }

    internal static string smethod_52(ListNumberAlignment A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case ListNumberAlignment.Left:
                return BookmarkStart.b("否崨䨪弬嬮", num);

            case ListNumberAlignment.Center:
                return BookmarkStart.b("䐦䰨䔪夬䨮䌰", num);

            case ListNumberAlignment.Right:
                return BookmarkStart.b("䈦䜨伪", num);
        }
        return null;
    }

    internal static ListNumberAlignment smethod_53(string A_0)
    {
        int num = 0;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䔥䴧䐩堫䬭䈯", num))
            {
                return ListNumberAlignment.Center;
            }
            if ((str == BookmarkStart.b("䌥䘧丩", num)) || (str == BookmarkStart.b("吥䄧䴩䐫娭", num)))
            {
                return ListNumberAlignment.Right;
            }
        }
        return ListNumberAlignment.Left;
    }

    internal static string smethod_54(PageNumberStyle A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case PageNumberStyle.Arabic:
                return BookmarkStart.b("ᘦ", num);

            case PageNumberStyle.RomanUpper:
                return BookmarkStart.b("渦", num);

            case PageNumberStyle.RomanLower:
                return BookmarkStart.b("並", num);

            case PageNumberStyle.LetterUpper:
                return BookmarkStart.b("昦", num);

            case PageNumberStyle.LetterLower:
                return BookmarkStart.b("䘦", num);
        }
        return null;
    }

    internal static string smethod_55(ListPatternType A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case ListPatternType.Arabic:
                return BookmarkStart.b("ܵ", num);

            case ListPatternType.UpRoman:
                return BookmarkStart.b("缵", num);

            case ListPatternType.LowRoman:
                return BookmarkStart.b("張", num);

            case ListPatternType.UpLetter:
                return BookmarkStart.b("眵", num);

            case ListPatternType.LowLetter:
                return BookmarkStart.b("圵", num);
        }
        return null;
    }

    internal static string smethod_56(FootnoteNumberFormat A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case FootnoteNumberFormat.Arabic:
                return BookmarkStart.b("ᨪ", num);

            case FootnoteNumberFormat.UpperCaseRoman:
                return BookmarkStart.b("截", num);

            case FootnoteNumberFormat.LowerCaseRoman:
                return BookmarkStart.b("䈪", num);

            case FootnoteNumberFormat.UpperCaseLetter:
                return BookmarkStart.b("横", num);

            case FootnoteNumberFormat.LowerCaseLetter:
                return BookmarkStart.b("䨪", num);
        }
        return null;
    }

    internal static ListPatternType smethod_57(string A_0)
    {
        int num = 6;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("攫", num))
            {
                return ListPatternType.UpRoman;
            }
            if (str == BookmarkStart.b("䔫", num))
            {
                return ListPatternType.LowRoman;
            }
            if (str == BookmarkStart.b("洫", num))
            {
                return ListPatternType.UpLetter;
            }
            if (str == BookmarkStart.b("䴫", num))
            {
                return ListPatternType.LowLetter;
            }
            if (str == BookmarkStart.b("ᴫ", num))
            {
                return ListPatternType.Arabic;
            }
        }
        return ListPatternType.None;
    }

    internal static PageNumberStyle smethod_58(string A_0)
    {
        int num = 0x10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("缵", num))
            {
                return PageNumberStyle.RomanUpper;
            }
            if (str == BookmarkStart.b("張", num))
            {
                return PageNumberStyle.RomanLower;
            }
            if (str == BookmarkStart.b("眵", num))
            {
                return PageNumberStyle.LetterUpper;
            }
            if (str == BookmarkStart.b("圵", num))
            {
                return PageNumberStyle.LetterLower;
            }
            if (str == BookmarkStart.b("ܵ", num))
            {
                return PageNumberStyle.Arabic;
            }
        }
        return PageNumberStyle.None;
    }

    internal static FootnoteNumberFormat smethod_59(string A_0)
    {
        int num = 11;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("砰", num))
            {
                return FootnoteNumberFormat.UpperCaseRoman;
            }
            if (str == BookmarkStart.b("堰", num))
            {
                return FootnoteNumberFormat.LowerCaseRoman;
            }
            if (str == BookmarkStart.b("瀰", num))
            {
                return FootnoteNumberFormat.UpperCaseLetter;
            }
            if (str == BookmarkStart.b("倰", num))
            {
                return FootnoteNumberFormat.LowerCaseLetter;
            }
            if (str == BookmarkStart.b("0", num))
            {
                return FootnoteNumberFormat.Arabic;
            }
        }
        return FootnoteNumberFormat.None;
    }

    internal static string smethod_6(PathType A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case PathType.Unknown:
            case PathType.LineTo:
                return BookmarkStart.b("搧", num);

            case PathType.CurveTo:
                return BookmarkStart.b("欧", num);

            case PathType.MoveTo:
                return BookmarkStart.b("攧", num);

            case PathType.Close:
                return BookmarkStart.b("爧", num);

            case PathType.End:
                return BookmarkStart.b("昧", num);

            case PathType.AngleEllipseTo:
                return BookmarkStart.b("簧", num);

            case PathType.AngleEllipse:
                return BookmarkStart.b("紧", num);

            case PathType.ArcTo:
                return BookmarkStart.b("椧", num);

            case PathType.Arc:
                return BookmarkStart.b("樧", num);

            case PathType.ClockwiseArcTo:
                return BookmarkStart.b("缧", num);

            case PathType.ClockwiseArc:
                return BookmarkStart.b("縧", num);

            case PathType.EllipticalQuadrantX:
                return BookmarkStart.b("瀧", num);

            case PathType.EllipticalQuadrantY:
                return BookmarkStart.b("焧", num);

            case PathType.QuadraticBezier:
                return BookmarkStart.b("礧", num);

            case PathType.NoFill:
                return BookmarkStart.b("渧", num);

            case PathType.NoLine:
                return BookmarkStart.b("笧", num);
        }
        return "";
    }

    internal static string smethod_60(TabJustification A_0)
    {
        int num = 3;
        switch (A_0)
        {
            case TabJustification.Left:
                return BookmarkStart.b("䔨个䬬嬮", num);

            case TabJustification.Centered:
                return BookmarkStart.b("䨨个䌬嬮吰䄲", num);

            case TabJustification.Right:
                return BookmarkStart.b("嬨䈪䨬䜮䔰", num);

            case TabJustification.Decimal:
                return BookmarkStart.b("䨨䌪䰬崮", num);
        }
        return null;
    }

    internal static TabJustification smethod_61(string A_0, string A_1)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("匯圱娳䈵崷䠹", num))
            {
                return TabJustification.Centered;
            }
            if (str == BookmarkStart.b("䈯嬱匳帵䰷", num))
            {
                return TabJustification.Right;
            }
            if (str == BookmarkStart.b("匯娱唳䐵", num))
            {
                return TabJustification.Decimal;
            }
        }
        return TabJustification.Left;
    }

    internal static TabLeader smethod_62(string A_0, string A_1)
    {
        string str;
        int num = 10;
        if ((A_1.Length > 0) && ((str = A_1) != null))
        {
            if (str == BookmarkStart.b("ᴯ", num))
            {
                return TabLeader.Hyphenated;
            }
            if (str == BookmarkStart.b("ḯ", num))
            {
                return TabLeader.Dotted;
            }
            if (str == BookmarkStart.b("漯", num))
            {
                return TabLeader.Single;
            }
        }
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_194 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䌯崱堳張尷", num), 0);
                dictionary1.Add(BookmarkStart.b("䜯匱䈳匵", num), 1);
                dictionary1.Add(BookmarkStart.b("启崱䀳䈵崷帹", num), 2);
                dictionary1.Add(BookmarkStart.b("启匱䜳帵", num), 3);
                dictionary1.Add(BookmarkStart.b("尯崱娳儵ᔷ帹崻䴽⠿", num), 4);
                dictionary1.Add(BookmarkStart.b("启崱䀳ᬵ尷嬹伻嘽", num), 5);
                dictionary1.Add(BookmarkStart.b("启崱䀳ᬵ尷唹䠻ጽ␿⍁㝃⹅", num), 6);
                Class1160.dictionary_194 = dictionary1;
            }
            if (Class1160.dictionary_194.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return TabLeader.Single;

                    case 2:
                        return TabLeader.Dotted;

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        return TabLeader.Hyphenated;
                }
            }
        }
        return TabLeader.NoLeader;
    }

    internal static string smethod_63(TabLeader A_0)
    {
        int num = 0x11;
        switch (A_0)
        {
            case TabLeader.Dotted:
            case TabLeader.MiddleDot:
                return BookmarkStart.b("ᤶ", num);

            case TabLeader.Hyphenated:
                return BookmarkStart.b("ᨶ", num);

            case TabLeader.Single:
            case TabLeader.Heavy:
                return BookmarkStart.b("栶", num);
        }
        return null;
    }

    internal static string smethod_64(TabLeader A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case TabLeader.NoLeader:
                return BookmarkStart.b("䤦䘨䔪䠬", num);

            case TabLeader.Dotted:
            case TabLeader.MiddleDot:
                return BookmarkStart.b("䌦䘨弪夬䨮唰", num);

            case TabLeader.Hyphenated:
                return BookmarkStart.b("䌦䠨堪䔬", num);

            case TabLeader.Single:
            case TabLeader.Heavy:
                return BookmarkStart.b("否䘨䜪䐬䬮", num);
        }
        return null;
    }

    internal static HorizontalAlignment smethod_65(string A_0, bool A_1)
    {
        int num = 6;
        string str = A_0;
        if (str != null)
        {
            if ((str == BookmarkStart.b("䤫䀭启", num)) || (str == BookmarkStart.b("師䜭圯娱䀳", num)))
            {
                return HorizontalAlignment.Right;
            }
            if (str == BookmarkStart.b("伫䬭帯䘱儳䐵", num))
            {
                return HorizontalAlignment.Center;
            }
            if (str == BookmarkStart.b("䘫嬭䌯䘱崳倵䄷", num))
            {
                return HorizontalAlignment.Justify;
            }
        }
        return HorizontalAlignment.Left;
    }

    internal static string smethod_66(UnderlineStyle A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case UnderlineStyle.DottedHeavy:
            case UnderlineStyle.DashHeavy:
            case UnderlineStyle.DotDashHeavy:
            case UnderlineStyle.DotDotDashHeavy:
            case UnderlineStyle.WavyHeavy:
            case UnderlineStyle.DashLongHeavy:
                return BookmarkStart.b("䨧䔩䀫䨭", num);

            case UnderlineStyle.Thick:
                return BookmarkStart.b("尧䈩䔫䴭嬯", num);
        }
        return null;
    }

    internal static string smethod_67(UnderlineStyle A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case UnderlineStyle.None:
                return BookmarkStart.b("堵圷吹夻", num);

            case UnderlineStyle.Single:
            case UnderlineStyle.Words:
            case UnderlineStyle.Double:
            case UnderlineStyle.Thick:
                return BookmarkStart.b("䔵圷嘹唻娽", num);

            case UnderlineStyle.Dotted:
            case UnderlineStyle.DottedHeavy:
                return BookmarkStart.b("刵圷丹䠻嬽␿", num);

            case UnderlineStyle.Dash:
            case UnderlineStyle.DashHeavy:
                return BookmarkStart.b("刵夷䤹吻", num);

            case UnderlineStyle.DotDash:
            case UnderlineStyle.DotDashHeavy:
                return BookmarkStart.b("刵圷丹ᄻ娽ℿㅁⱃ", num);

            case UnderlineStyle.DotDotDash:
            case UnderlineStyle.DotDotDashHeavy:
                return BookmarkStart.b("刵圷丹ᄻ娽⼿㙁楃≅⥇㥉⑋", num);

            case UnderlineStyle.Wavy:
            case UnderlineStyle.WavyHeavy:
            case UnderlineStyle.WavyDouble:
                return BookmarkStart.b("䄵夷䰹夻", num);

            case UnderlineStyle.DashLong:
            case UnderlineStyle.DashLongHeavy:
                return BookmarkStart.b("娵圷吹嬻ጽ␿⍁㝃⹅", num);
        }
        return null;
    }

    internal static UnderlineStyle smethod_68(string A_0, string A_1, string A_2, string A_3)
    {
        int num = 0x11;
        if (A_1 == "")
        {
            return UnderlineStyle.None;
        }
        bool flag = A_1 == BookmarkStart.b("唶嘸场夼", num);
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_195 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼", num), 0);
                dictionary1.Add(BookmarkStart.b("嬶嘸唺娼ሾ╀≂㙄⽆", num), 1);
                dictionary1.Add(BookmarkStart.b("匶嘸伺ြ嬾⁀あⵄ", num), 2);
                dictionary1.Add(BookmarkStart.b("匶嘸伺ြ嬾⹀㝂桄⍆⡈㡊╌", num), 3);
                dictionary1.Add(BookmarkStart.b("匶嘸伺䤼娾╀", num), 4);
                dictionary1.Add(BookmarkStart.b("䀶堸䴺堼", num), 5);
                Class1160.dictionary_195 = dictionary1;
            }
            if (Class1160.dictionary_195.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        if (flag)
                        {
                            return UnderlineStyle.DashHeavy;
                        }
                        return UnderlineStyle.Dash;

                    case 1:
                        if (flag)
                        {
                            return UnderlineStyle.DashLongHeavy;
                        }
                        return UnderlineStyle.DashLong;

                    case 2:
                        if (flag)
                        {
                            return UnderlineStyle.DotDashHeavy;
                        }
                        return UnderlineStyle.DotDash;

                    case 3:
                        if (flag)
                        {
                            return UnderlineStyle.DotDotDashHeavy;
                        }
                        return UnderlineStyle.DotDotDash;

                    case 4:
                        if (flag)
                        {
                            return UnderlineStyle.DottedHeavy;
                        }
                        return UnderlineStyle.Dotted;

                    case 5:
                        if (!flag)
                        {
                            if (!(A_3 == BookmarkStart.b("匶嘸为弼匾⑀", num)))
                            {
                                return UnderlineStyle.Wavy;
                            }
                            return UnderlineStyle.WavyDouble;
                        }
                        if (!(A_0 == BookmarkStart.b("匶嘸为弼匾⑀", num)))
                        {
                            return UnderlineStyle.WavyHeavy;
                        }
                        return UnderlineStyle.Double;
                }
            }
        }
        if (A_2 == BookmarkStart.b("䐶券刺䴼ሾ㙀⭂ⱄ㍆ⱈ晊㹌㽎ぐげご", num))
        {
            return UnderlineStyle.Words;
        }
        if (A_1 == BookmarkStart.b("䌶儸刺帼吾", num))
        {
            return UnderlineStyle.Thick;
        }
        if (A_3 == BookmarkStart.b("匶嘸为弼匾⑀", num))
        {
            return UnderlineStyle.Double;
        }
        if (!(A_0 == BookmarkStart.b("䐶嘸场吼嬾", num)) && !(A_3 == BookmarkStart.b("䐶倸唺娼匾⑀", num)))
        {
            return UnderlineStyle.None;
        }
        return UnderlineStyle.Single;
    }

    internal static string smethod_69(TextOrientation A_0)
    {
        int num = 8;
        switch (A_0)
        {
            case TextOrientation.Upward:
                return BookmarkStart.b("ᜭ/", num);

            case TextOrientation.HorizontalRotatedFarEast:
                return BookmarkStart.b("ḭ", num);

            case TextOrientation.VerticalFarEast:
                return BookmarkStart.b("ᰭܯȱ", num);
        }
        return null;
    }

    internal static string smethod_7(ConnectorType A_0)
    {
        int num = 8;
        switch (A_0)
        {
            case ConnectorType.Straight:
                return BookmarkStart.b("䈭夯就儳", num);

            case ConnectorType.Curved:
                return BookmarkStart.b("䴭䔯䀱䈳匵", num);
        }
        return null;
    }

    internal static TextOrientation smethod_70(string A_0)
    {
        int num = Class1041.smethod_23(A_0) % 360;
        if (((num >= 0x13b) && (num < 360)) || ((num >= 0) && (num < 0x2d)))
        {
            return TextOrientation.HorizontalRotatedFarEast;
        }
        if ((num >= 0x2d) && (num < 0x87))
        {
            return TextOrientation.Upward;
        }
        if ((num >= 0x87) && (num < 0x13b))
        {
            return TextOrientation.VerticalFarEast;
        }
        return TextOrientation.Horizontal;
    }

    internal static string smethod_71(string A_0, int A_1)
    {
        int length = 0;
        for (int i = 0; i <= A_1; i++)
        {
            length = A_0.IndexOf((char) i);
            if (length != -1)
            {
                break;
            }
        }
        if (length != -1)
        {
            return A_0.Substring(0, length);
        }
        return null;
    }

    internal static string smethod_72(string A_0, int A_1)
    {
        int index = A_0.IndexOf((char) A_1);
        if ((index != -1) && (index < (A_0.Length - 1)))
        {
            return A_0.Substring(index + 1);
        }
        return null;
    }

    internal static string smethod_73(string A_0, int A_1)
    {
        int num = A_1 + 1;
        for (int i = 0; i < A_1; i++)
        {
            if (A_0.IndexOf((char) i) == -1)
            {
                num--;
            }
        }
        if (num != 1)
        {
            return num.ToString();
        }
        return null;
    }

    internal static string smethod_74(SubSuperScript A_0)
    {
        return (string) Class791.smethod_3(hashtable_7, A_0, "");
    }

    internal static SubSuperScript smethod_75(string A_0)
    {
        return (SubSuperScript) Class791.smethod_3(hashtable_6, A_0, "");
    }

    internal static string smethod_76(StyleType A_0)
    {
        return (string) Class791.smethod_3(hashtable_3, A_0, BookmarkStart.b("娩䴫尭儯唱䘳圵䠷刹", 4));
    }

    internal static string smethod_77(Style A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            return BookmarkStart.b("礶嘸携༼༾Ṁགⱄ㑆㵈", num);
        }
        string str = Class417.smethod_26(A_0.StyleIdentifier, "");
        if (Class567.smethod_16(str))
        {
            string str2 = (string) Class791.smethod_3(hashtable_5, str, str);
            return smethod_78(Class955.smethod_8(str2), A_0.StyleIdentifier);
        }
        if ((A_0.StyleIdentifier == StyleIdentifier.User) && !Class567.smethod_16(A_0.Name))
        {
            A_0.method_8(string.Format(BookmarkStart.b("戶圸唺尼刾⑀❂၄㑆ⱈ㥊Ṍ㭎⡐㽒ごⱖ楘♚", num), A_0.Istd));
        }
        return smethod_78(A_0.Name, A_0.StyleIdentifier);
    }

    private static string smethod_78(string A_0, StyleIdentifier A_1)
    {
        int num = 4;
        string str = (string) Class791.smethod_3(hashtable_4, A_0, A_0);
        StyleIdentifier identifier = Class417.smethod_25(str);
        if ((A_1 == StyleIdentifier.User) && (identifier != StyleIdentifier.User))
        {
            A_0 = string.Format(BookmarkStart.b("儩ᰫ匭䬯̱䤳", num), A_0, BookmarkStart.b("਩Ы嬭䌯圱䘳ἵ", num));
        }
        return Class576.smethod_88(A_0);
    }

    internal static string smethod_79(string A_0)
    {
        A_0 = Class576.smethod_87(A_0);
        return (string) Class791.smethod_3(hashtable_4, A_0, A_0);
    }

    internal static ConnectorType smethod_8(string A_0)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if ((str == BookmarkStart.b("尯嬱娳匵䬷", num)) || (str == BookmarkStart.b("尯嬱娳匵", num)))
            {
                return ConnectorType.Straight;
            }
            if (str == BookmarkStart.b("䌯䘱唳堵尷嬹主娽", num))
            {
                return ConnectorType.Bent;
            }
            if (str == BookmarkStart.b("匯䜱䘳䀵崷", num))
            {
                return ConnectorType.Curved;
            }
        }
        return ConnectorType.None;
    }

    internal static string smethod_80(int A_0)
    {
        string str = (string) Class791.smethod_3(hashtable_1, (Language) A_0, "");
        if (str == "")
        {
            return Class860.smethod_1(A_0, true);
        }
        return str;
    }

    internal static int smethod_81(string A_0)
    {
        int num = (int) Class791.smethod_3(hashtable_0, A_0, -1);
        if (num == -1)
        {
            return Class860.smethod_0(A_0, true);
        }
        return num;
    }

    internal static string smethod_82(string A_0)
    {
        return smethod_84(A_0, 0);
    }

    internal static string smethod_83(string A_0)
    {
        return smethod_84(A_0, 1);
    }

    private static string smethod_84(string A_0, int A_1)
    {
        if (!Class567.smethod_16(A_0))
        {
            return null;
        }
        string[] strArray = A_0.Split(new char[] { '-' });
        if (strArray.Length != 2)
        {
            return null;
        }
        return strArray[A_1];
    }

    internal static string smethod_85(PageOrientation A_0)
    {
        return (string) Class791.smethod_3(hashtable_19, A_0, BookmarkStart.b("娩䌫尭䐯䀱唳張䰷", 4));
    }

    internal static PageOrientation smethod_86(string A_0)
    {
        return (PageOrientation) Class791.smethod_3(hashtable_18, A_0, PageOrientation.Portrait);
    }

    internal static ShapeType smethod_9(string A_0)
    {
        int num = 9;
        string str = A_0;
        if (str != null)
        {
            if ((str == BookmarkStart.b("䌮堰崲倴䐶", num)) || (str == BookmarkStart.b("䌮堰崲倴", num)))
            {
                return ShapeType.StraightConnector1;
            }
            if (str == BookmarkStart.b("尮䔰刲嬴匶堸䤺夼", num))
            {
                return ShapeType.BentConnector3;
            }
            if (str == BookmarkStart.b("䰮䐰䄲䌴制", num))
            {
                return ShapeType.CurvedConnector3;
            }
        }
        return ShapeType.StraightConnector1;
    }
}

