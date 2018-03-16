using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

internal class Class576
{
    internal const char char_0 = '⁡';
    private static readonly char[] char_1 = new char[] { 
        '\0', '\x0001', '\x0002', '\x0003', '\x0004', '\x0005', '\x0006', '\a', '\b', '\t', '\n', '\v', '\f', '\r', '\x000e', '\x000f', 
        '\x0010', '\x0011', '\x0012', '\x0013', '\x0014', '\x0015', '\x0016', '\x0017', '\x0018', '\x0019', '\x001a', '\x001b', '\x001c', '\x001d', '\x001e', '\x001f', 
        '"', '<', '>', '|'
     };
    private static readonly char[] char_2 = new char[] { '\\', '/' };
    private const double double_0 = 20.0;
    public const double double_1 = 0.05;
    internal const double double_2 = 72.0;
    internal const double double_3 = 2.54;
    private const double double_4 = 0.035277777777777776;
    private const double double_5 = 1440.0;
    internal const double double_6 = 0.0;
    private static double double_7 = 1.0;
    private const int int_0 = 3;
    private const int int_1 = 4;
    internal const int int_2 = 0x1f;
    internal const int int_3 = 0x7a120;
    private static readonly Regex regex_0 = new Regex(BookmarkStart.b("渴椶昸稺ြ放⁀湂㽄蝆摈鵊镌扎Ꝑꭒ硔ꡖ奙癚汝歟䱠嵣⑥䩦ⅩⅫ䁬ᅯ干뙵멷呸譻襽剾璁禃ꢄ還\ud98a\ua68a▎㒌벐劐᎗ᾕ뒘ᆙᆟᆝ負ʡڧ誦枫箩肬禭殳澱殷垵宻隺亿뺺쿆쯀蛌髎鏊返ﻒ哐䟒῞᫘⧤⣦죤⯢㧬웪ۨǪ\udcf0\u06f6෰\udaf6\u00fc쫿탼ꧻ堅戇⠄脃\ud90d\u260a＋㰐㐒㨖⌞娜〜唘倦ย鈢鴠Ш锬ȮＶᠴ\ude3c\u103c\ud938\u4449湂籍穏ᅁ晊ⱅ쩇籐\udf5b\uda5d穖쥑졓灜쭩乢항핯\udf61\u466a푥덧屰깻ꩽ婶顱譳偼蹷蒊꺂辎袌ꒈ鮀麆ꊎ릚릘뢔Ꞝꮒ뚚꺖ꪔ負閨鶮誦邢肬솸颴쎼㲲隺㚶㊴今哎哌揀柆懚懘擜泒擖拔Ǫ죤웪﷧ﳥ\udcf0\udbf9\udfff\udaf6짳짱탼쳵㜋⸂㰏㨍唃☊倇倅㰐爙速㨖錓锑〜輕댫ย뀯븭Ш넡넧넥ᰰ갹阿ᨶ鴳錱ြ锵湂摈䡀扎嵜嵞硔䝚䭔癚畐畒䱠偮偨䩦偤୦䁬๢干兩梁呸剾⦌⦎ꢄ㒊㲄Ꚋ㒀冂熜뺒璘銛뒘鞗鎑늞놭놯袤辫莥蚪钡쾣鲰튿뒺骶鞶讴農銾菌苈䣆係䯀回ﻒ巚巘哖俔䣐磮컢竪䛨쓨䣤䣢䣠対\udef2\u5efa嫸퓸嗴䷲䷰Ⰰ뀌렊윈␈켄䴃∎嘟娝㠔縙뤈㘚\ud80c\ucf0eఠ픲┵┷Ш⠻⠽Ȯ㘡㨣㸥ᨶ㔩㔫ြ⴯絑絓Օୗݙ᭛ᥝ扎с੃੅穖㡉㡋㡍㡏ࡱ๳䡤ॷ᭹䙪ṽ᩿\udb63\ude65\ud967\u5478푫쩭剾㦑㦓㦕ꪆ䮙悛綝皟醎뺒ຊ㞈뒘抄鶃늞뒿뮽袤몹覷蚪鲰ﺭ骶黟룛䟙翕篓淏淍់𥳐᷇᷅Ꮑㇿ컢㛻ㇹ쓨ヵෳ싮ᷯǭ\ud8f4\u03e9࿧훺ǣ\ud9df\u2b21⸂⸥⤧褩☊輭举㰐蜢됤㨖ḫ〜㌯↌ย蛳❨Ш躵⨜พᰰᨂ栴", 15));
    private static readonly Regex regex_1 = new Regex(BookmarkStart.b("渴椶攸ᔺ愼ሾṀɂ桄ᵆ⡈晊㝌轎籐蕒赔穖꽘ꍚ灜ꁞ慡乢呥卧䑨啫Ɑ䉮㥱㥳塴ॷ凉噺빽뉿검玃熅ꪆ粉熋ꂌ颌솒뺒㶖Ⲕ뒘媘ᮟឝ負⦡⦧⦥蒨઩ຯ芮羳掱颴憵掻枹掿徽⏃㛇웂쟎쏈黔苖诒蟜峘俚쳠⟦⋠쫦⇬⃮샬⏪⇴\udef2\u1ef0᧲퓸໾׸틾㈇⠄儃倍樏‌褋섕㸒１㐘㰚㈞ᬦ戤ࠤ洠堮ت騪锨ᰰ贴ᨶြ鑆Ꙅ桄ꅀ䱁晊瑅片ख़繒㑝퉟瑘흓퉕牞䡤콯썡䙪\udd65\udd67읹干챽ꭿ呸꙳ꉵ剾悉王ꢄ皏貂Ꚋ螆肄벐莘蚞몖높놐난꾔鎪躢隮銬蒨鶠閦芮袺颴즰邼쮴䓊从䫌䛂峆峄ﳐ篘翞𥳐槒槐泔哪컢峮嫬ৢ샬ﻻ\udef2\ue5ff퓸폱ퟷ틾ㄋㄉ⠄㐍㼃☊㐇㈅䴛㸒䠟䠝㐘稑頗㈞ꬫ괩ࠤ뜭묣ت렧똥ᰰꤹꤿꤽᐸꐱ鸷ሾ桄晊籐偘穖啔啖灜佒獬乢䵨䵪䑨塦塠䉮䡼፾塴ᙺﱴ噺검ᎎឈꪆↄↆꂌ㲂⒜뺒Ⲙ䦚禔뚚粐骓負꾯ꮩ誦릥릧肬螣鮽麲貹ힻ钸\udab7\ubcb2銾陼评諀僞ﻒ埚变廖嗒嗐泮矬죤烨烦웪狢仠\udcf0\u50fc僺僸叶훺囲勰Ⰰ괌딊딈␈렄뀂케㰐휜唛㨖帗刕〜瘑脰ยШ\udd3a\u2d3dⴿᰰ〣〥ᨶ㸩㈫㘭ሾ䵑䵓桄啗留畛൝͟ὁ̓Ņ穖౉ɋɍ牞qsuwyٻ䁬ſ͡干٥ɧ퍫홭텯검ⲓ㊕ꪆ㆙㆛㆝ꊎ厁碃斅溇馆뚚ڂ㾀負媼ꖻ誦벷뎵肬늱醯麲ﾩ钸銾雟髝黛髙雗냓俑ﳐ柍揋𥳐旇旅ῃ◿◽죤⯹㧷웪㻳㧱\udcf0\u28edᗫ\udaf6\u15e7৥탼௡⸂亂℧〈☊☭ℯ鄱㸒霵嘦㐘輪밬㈞\udb10\u2613ࠤଗ⦄ت軻⽠ᰰ隭㈄ᘆᐸሊ഼ሾ础⍄桄⹀륎晊둊⥇籐㱛덝穖뙑㵐灜ご蝪乢詮ŭ䑨ѡ詧䉮鹻ᕾ塴᡺齴噺鉰ᥳ검햊ꪆ킆宄ꂌ嚀놟뺒벛鞕뒘\ude99\ufd9f늞삣₦袤↢㢭蚪಩ಫ鲰ષັ骶ҽҿ粹銾υ߇軂鯎믌ᯊූ໔࣐㧞㧚㣘쳠௤࿢쫦Ӯ샬췹췻\ud8f4\ubbff등ꫳ탼꯷按⸂昍蘏␈蠃넅넇긙팛㠔팟\ude11\u361a픕퐗ఠ씯Ш젣⼦ጤ༺స甾ᨶ笲簰ြ眴੊湂ࡎ㝌摈㩀챆扎퉚穖鱒鱐灜陔ꩪ乢ꡮ晭䑨桡內入屰べ㉿婶ㅳぱ偼㉵힋꺂튏֍ꒈࢁ㎇ꊎ厛喙뢔徝厓뚚傗䢕ꂬ躢ꚨ馪蒨芮寮料颴諸隺㶲䃎篈හෆ߂ᯜﻒᣘ˚ූ\udfd1\uf2de\uddef\uc8e4ꓫ꿥웪ꗡꗣ\udcf0\ubeffꋹ웸췶훺쟲룰Ⰰ䴌됊댈␈누똂∎괞\udb1c\u3814\uda18\u0117㘚Г⨑ᘯᨭᬫᠩ堧تꤣꤡᰰ렽ꔻᨶ갷갵ꐳሾ桄魪恌鍮끰祢硔硦쁨셪轜끢╢Ⅸ꽦湚屜䉮䑀塴蕈噺荌≾", 15));
    private static readonly Regex regex_2 = new Regex(BookmarkStart.b("樴氶सᘺм績汀Ղ⑄橆⽈ᙊ㙌繎結杒⡔ࡖ", 15));

    internal static bool smethod_0(Field A_0)
    {
        if (A_0.Type != FieldType.FieldIndex)
        {
            return (A_0.Type == FieldType.FieldTOC);
        }
        return true;
    }

    internal static bool smethod_1(Class396 A_0)
    {
        int num = 3;
        if (((!(A_0.method_1() == BookmarkStart.b("崨䨪伬䌮吰Ḳ娴儶ᐸ堺刼儾㕀♂⭄㍆", 3)) && !(A_0.method_1() == BookmarkStart.b("䠨䜪崬䜮倰儲倴䌶倸堺尼匾汀⩂⭄⍆ⱈ㍊", num))) && (!(A_0.method_1() == BookmarkStart.b("䀨䜪䄬娮䈰䜲䜴嘶䴸刺刼儾汀⩂⭄⍆ⱈ㍊", num)) && !(A_0.method_1() == BookmarkStart.b("崨䨪伬䌮吰Ḳ尴夶崸帺䔼", num)))) && (!(A_0.method_1() == BookmarkStart.b("䘨䤪䜬䨮到䜲ᠴ帶圸强堼䜾", num)) && !(A_0.method_1() == BookmarkStart.b("尨堪䠬崮ᰰ娲嬴匶尸䌺", num))))
        {
            return (A_0.method_1() == BookmarkStart.b("䬨䈪伬䌮堰尲刴䔶堸䬺唼䘾", num));
        }
        return true;
    }

    internal static string smethod_10(string A_0, string A_1)
    {
        int num = 11;
        if (Class567.smethod_16(A_0) && (A_0.IndexOf(A_1) != -1))
        {
            int startIndex = A_0.IndexOf(A_1) + A_1.Length;
            int index = A_0.IndexOf(BookmarkStart.b("洰", num), startIndex);
            index = (index != -1) ? index : A_0.Length;
            return A_0.Substring(startIndex, index - startIndex).Trim(new char[] { ' ' });
        }
        return "";
    }

    internal static string smethod_11(string A_0)
    {
        int num = 7;
        if (Class567.smethod_16(A_0))
        {
            int index = A_0.IndexOf(BookmarkStart.b("縬樮怰", num));
            if (index != -1)
            {
                A_0 = A_0.Substring(index + 3).Trim(new char[] { ' ' });
                int length = A_0.IndexOf(BookmarkStart.b("焬", num));
                length = (length != -1) ? length : A_0.Length;
                return A_0.Substring(0, length).Trim(new char[] { ' ' });
            }
        }
        return "";
    }

    internal static string smethod_12(string A_0)
    {
        int num = 0;
        if (Class567.smethod_16(A_0))
        {
            int index = A_0.IndexOf(BookmarkStart.b("戥朧椩簫簭缯戱焳搵氷挹", num));
            if (index != -1)
            {
                A_0 = A_0.Substring(index + 11);
                int length = A_0.IndexOf(BookmarkStart.b("稥", num));
                length = (length != -1) ? length : A_0.Length;
                return A_0.Substring(0, length).Trim(new char[] { ' ' });
            }
        }
        return "";
    }

    internal static string smethod_13(string A_0)
    {
        int num = 12;
        if (Class567.smethod_16(A_0))
        {
            int index = A_0.IndexOf(BookmarkStart.b("愱焳戵ᠷ", num));
            if (index != -1)
            {
                A_0 = A_0.Substring(index + 4).Trim(new char[] { ' ' });
                int length = A_0.IndexOf(BookmarkStart.b("ေ", num));
                if (length == -1)
                {
                    length = A_0.IndexOf(BookmarkStart.b("ሱ", num));
                }
                length = (length != -1) ? length : A_0.Length;
                return A_0.Substring(0, length).Trim(new char[] { ' ' }).Trim(new char[] { '"' });
            }
        }
        return "";
    }

    internal static string smethod_14(string A_0, string A_1)
    {
        int num = 1;
        if (Class567.smethod_16(A_0))
        {
            int index = A_0.IndexOf(A_1);
            if (index != -1)
            {
                index += A_1.Length;
                if (A_0.IndexOf(BookmarkStart.b("Ԧ", num), index) != -1)
                {
                    index = A_0.IndexOf(BookmarkStart.b("Ԧ", num), index);
                }
                else
                {
                    index = A_0.IndexOf(BookmarkStart.b("ܦ", num), index);
                }
                if (index != -1)
                {
                    index++;
                    int num3 = A_0.IndexOf(BookmarkStart.b("Ԧ", num), index);
                    if (num3 == -1)
                    {
                        num3 = A_0.IndexOf(BookmarkStart.b("ܦ", num), index);
                    }
                    num3 = (num3 != -1) ? num3 : A_0.Length;
                    int length = num3 - index;
                    return A_0.Substring(index, length);
                }
            }
        }
        return "";
    }

    internal static string smethod_15(string A_0)
    {
        int num = 1;
        if (A_0.IndexOf(BookmarkStart.b("符̨", 1)) != -1)
        {
            if (A_0.IndexOf(BookmarkStart.b("甦昨昪氬愮", num)) != -1)
            {
                return BookmarkStart.b("渦", num);
            }
            if (A_0.IndexOf(BookmarkStart.b("唦䘨䘪䰬䄮", num)) != -1)
            {
                return BookmarkStart.b("並", num);
            }
            if (A_0.IndexOf(BookmarkStart.b("昦攨笪攬渮猰瘲愴縶稸", num)) != -1)
            {
                return BookmarkStart.b("昦", num);
            }
            if (A_0.IndexOf(BookmarkStart.b("䘦䔨嬪䔬丮匰嘲䄴帶娸", num)) != -1)
            {
                return BookmarkStart.b("䘦", num);
            }
        }
        return null;
    }

    internal static string smethod_16(string A_0)
    {
        int num = 9;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("昮", num))
            {
                return BookmarkStart.b("༮洰ᤲᔴ收瘸瘺簼焾", num);
            }
            if (str == BookmarkStart.b("䘮", num))
            {
                return BookmarkStart.b("༮洰ᤲᔴ䔶嘸嘺尼儾", num);
            }
            if (str == BookmarkStart.b("渮", num))
            {
                return BookmarkStart.b("༮洰ᤲᔴ瘶甸欺甼績̀قᅄๆੈ", num);
            }
            if (str == BookmarkStart.b("丮", num))
            {
                return BookmarkStart.b("༮洰ᤲᔴ嘶唸䬺唼帾⍀♂ㅄ⹆⩈", num);
            }
        }
        return null;
    }

    internal static string smethod_17(string A_0)
    {
        int num = 8;
        if (A_0.IndexOf(BookmarkStart.b("อ氯䈱ᐳ", 8)) != -1)
        {
            return BookmarkStart.b("䠭䔯帱堳", num);
        }
        return BookmarkStart.b("䀭儯弱儳ᬵ夷吹堻ጽ┿㩁ぃ⍅♇㥉╋⅍㹏", num);
    }

    internal static string smethod_18(string A_0)
    {
        int num = 8;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_110 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x20);
                dictionary1.Add(BookmarkStart.b("漭戯猱瘳缵笷", num), 0);
                dictionary1.Add(BookmarkStart.b("漭戯猱瘳缵笷縹紻洽࠿", num), 1);
                dictionary1.Add(BookmarkStart.b("漭簯戱簳眵稷缹栻眽̿", num), 2);
                dictionary1.Add(BookmarkStart.b("伭尯䈱尳圵娷弹䠻圽⌿", num), 3);
                dictionary1.Add(BookmarkStart.b("簭缯缱申砵", num), 4);
                dictionary1.Add(BookmarkStart.b("尭弯弱唳堵", num), 5);
                dictionary1.Add(BookmarkStart.b("樭爯焱簳眵樷", num), 6);
                dictionary1.Add(BookmarkStart.b("樭爯簱愳笵ष", num), 7);
                dictionary1.Add(BookmarkStart.b("樭爯簱愳笵਷", num), 8);
                dictionary1.Add(BookmarkStart.b("樭爯簱愳笵ଷ", num), 9);
                dictionary1.Add(BookmarkStart.b("樭爯簱愳笵ష", num), 10);
                dictionary1.Add(BookmarkStart.b("漭礯朱焳礵", num), 11);
                dictionary1.Add(BookmarkStart.b("札戯紱簳眵", num), 12);
                dictionary1.Add(BookmarkStart.b("洭礯怱眳稵紷琹椻猽", num), 13);
                dictionary1.Add(BookmarkStart.b("洭砯笱稳猵欷缹爻欽ി煁", num), 14);
                dictionary1.Add(BookmarkStart.b("洭砯笱稳猵欷缹爻欽ി灁", num), 15);
                dictionary1.Add(BookmarkStart.b("琭缯瘱紳眵笷ହ", num), 0x10);
                dictionary1.Add(BookmarkStart.b("琭缯瘱紳眵笷࠹", num), 0x11);
                dictionary1.Add(BookmarkStart.b("琭缯瘱紳眵笷ह", num), 0x12);
                dictionary1.Add(BookmarkStart.b("椭爯̱", num), 0x13);
                dictionary1.Add(BookmarkStart.b("椭爯1", num), 20);
                dictionary1.Add(BookmarkStart.b("椭爯ı", num), 0x15);
                dictionary1.Add(BookmarkStart.b("椭爯ر", num), 0x16);
                dictionary1.Add(BookmarkStart.b("昭礯簱瀳缵琷缹栻樽Կ၁畃", num), 0x17);
                dictionary1.Add(BookmarkStart.b("昭礯簱瀳缵琷缹栻樽Կ၁癃", num), 0x18);
                dictionary1.Add(BookmarkStart.b("昭礯簱瀳缵礷根紻簽िŁ", num), 0x19);
                dictionary1.Add(BookmarkStart.b("昭礯簱瀳缵笷笹渻稽ᐿ݁᱃ቅ", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("砭礯眱怳电礷根砻樽Կᩁ၃", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("愭戯瘱紳砵礷瘹", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("洭焯怱瀳戵紷戹栻", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("愭戯瘱怳猵怷渹", num), 30);
                dictionary1.Add(BookmarkStart.b("昭甯樱", num), 0x1f);
                Class1160.dictionary_110 = dictionary1;
            }
            if (Class1160.dictionary_110.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BookmarkStart.b("Ἥ", num);

                    case 1:
                        return BookmarkStart.b("̭ု̱ᐳᬵᐷᨹᄻḽ爿扁楃橅桇杉汋絍灏网硓癕癗瑙牛", num);

                    case 2:
                        return BookmarkStart.b("漭", num);

                    case 3:
                        return BookmarkStart.b("伭", num);

                    case 4:
                        return BookmarkStart.b("札", num);

                    case 5:
                        return BookmarkStart.b("䜭", num);

                    case 6:
                        return BookmarkStart.b("㿒ᰯሱ⛌ᨵᠷ⧆ျḽ渿汁橃", num);

                    case 7:
                        return BookmarkStart.b("⹣ᰯሱ㑽ㄅᐷᨹ㱵㤍䜏湁摃桅晇摉", num);

                    case 8:
                        return BookmarkStart.b("⹣ᰯሱ롽ᨵᠷ㍷ျḽ渿汁橃", num);

                    case 9:
                        return BookmarkStart.b("\udf75\u1c2fሱ⑬ᨵᠷျḽ渿汁橃", num);

                    case 10:
                        return BookmarkStart.b("⹣ᰯሱ롽ᨵᠷ㍷ျḽ䝱湁摃桅晇摉", num);

                    case 11:
                        return BookmarkStart.b("忒ᰯሱ䛌ᨵᠷ䧆ျḽ渿汁橃", num);

                    case 12:
                        return BookmarkStart.b("峒ᰯሱ꿌ᨵᠷ냆ျḽ渿汁橃", num);

                    case 13:
                        return BookmarkStart.b("三ᰯሱ唗ᨵᠷ堝ျḽ渿汁橃", num);

                    case 14:
                        return BookmarkStart.b("⹣ᰯሱ畠ᨵᠷ㩷䉍ᘽŁ歁桃晅晇摉手", num);

                    case 15:
                        return BookmarkStart.b("흵ᰯሱ螿ᨵᠷ索ျḽ渿汁橃", num);

                    case 0x10:
                        return BookmarkStart.b("᱘ᰯሱ浽ᨵᠷ⍷ျḽ渿汁橃", num);

                    case 0x11:
                        return BookmarkStart.b("繶ᰯሱ╽ᨵᠷ｢ျḽ渿汁橃", num);

                    case 0x12:
                        return BookmarkStart.b("᱘恴ḱᐳ潻⥹ᘹ᰻❳蕤湁摃桅晇摉", num);

                    case 0x13:
                        return BookmarkStart.b("ꘉᰯሱ봗ᨵᠷ뀝ျḽ渿汁橃", num);

                    case 20:
                        return BookmarkStart.b("娉ᰯሱ䄗ᨵᠷ䰝ျḽ渿汁橃", num);

                    case 0x15:
                        return BookmarkStart.b("三ᰯሱ唗ᨵᠷ堝ျḽ渿汁橃", num);

                    case 0x16:
                        return BookmarkStart.b("ฟᰯሱᔁᨵᠷ᠋ျḽ渿汁橃", num);

                    case 0x17:
                        return BookmarkStart.b("㬤ᰯሱ∺ᨵᠷⴰျḽ渿汁橃", num);

                    case 0x18:
                        return BookmarkStart.b("⬤ᰯሱ㈺ᨵᠷ㴰ျḽ渿汁橃", num);

                    case 0x19:
                        return BookmarkStart.b("䤤ᰯሱ尺ᨵᠷ匰ျḽ渿汁橃", num);

                    case 0x1a:
                        return BookmarkStart.b("ℤ┦ḱᐳြ猾ᘹ᰻ᨴ6橈桃晅晇摉手", num);

                    case 0x1b:
                        return BookmarkStart.b("䌭쐯ᄲ䀳ᨵᠷ刹崻圽氿扁♃❅摇橉手恍繏", num);

                    case 0x1c:
                        return BookmarkStart.b("Ἥ䌯䘱ᠳᘵ਷吹堻ሽ怿煁㙃≅摇橉手恍繏", num);

                    case 0x1d:
                        return BookmarkStart.b("愭帯圱ᠳᘵ氷䴹医ሽ怿ᙁⱃ㑅ⵇ⽉恋湍繏籑穓", num);

                    case 30:
                        return BookmarkStart.b("栭夯䀱䜳䈵ᐷᨹ漻嬽⌿ⵁ⩃≅摇橉ᡋ♍㥏⁑こ穕硗瑙牛灝", num);

                    case 0x1f:
                        return BookmarkStart.b("Ἥᰯሱ申ᨵᠷ砹ျḽ渿汁橃", num);
                }
            }
        }
        return "";
    }

    internal static string smethod_19(string A_0)
    {
        string str;
        string str2;
        int num = 8;
        if (((str = A_0) != null) && ((str == BookmarkStart.b("席儯䘱尳", num)) || (str == BookmarkStart.b("䠭䔯帱堳", num))))
        {
            str2 = BookmarkStart.b("席", num);
        }
        else
        {
            str2 = null;
        }
        if (str2 == null)
        {
            return BookmarkStart.b("栭礯縱焳砵礷眹礻", num);
        }
        return string.Format(BookmarkStart.b("栭礯縱焳砵礷眹礻ḽ᰿桁摃ᩅ㍇穉ㅋ湍౏硑", num), str2);
    }

    internal static int smethod_2(int A_0)
    {
        return (int) (A_0 * smethod_93());
    }

    internal static string smethod_20(string A_0)
    {
        int num = 14;
        int index = A_0.IndexOf(BookmarkStart.b("栳瘵", 14));
        if (index != -1)
        {
            index = A_0.IndexOf(BookmarkStart.b("ᘳ", num), index) + 1;
            if (index != -1)
            {
                int num3 = A_0.IndexOf(BookmarkStart.b("ᘳ", num), index);
                if (num3 != -1)
                {
                    return A_0.Substring(index, num3 - index);
                }
            }
        }
        return null;
    }

    internal static double smethod_21(double A_0)
    {
        int num = 0x11;
        if (A_0 < 0.0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("制䨸堺唼娾㍀B⩄⥆㵈㥊ⱌ㱎═", num));
        }
        if (A_0 <= 1.0)
        {
            return (A_0 / 2.0);
        }
        return ((A_0 - 0.5) / A_0);
    }

    internal static double smethod_22(double A_0)
    {
        int num = 0x12;
        if ((A_0 < 0.0) || (A_0 > 1.0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䠷弹主崽┿ⱁぃ", num));
        }
        if (A_0 <= 0.5)
        {
            return (A_0 * 2.0);
        }
        if (A_0 >= 1.0)
        {
            return double.MaxValue;
        }
        return (0.5 / (1.0 - A_0));
    }

    internal static string smethod_23(int A_0)
    {
        return smethod_29((smethod_21(Class969.smethod_68(A_0)) - 0.5) * 2.0);
    }

    internal static int smethod_24(string A_0)
    {
        return Class969.smethod_71(smethod_22((smethod_30(A_0) / 2.0) + 0.5));
    }

    internal static string smethod_25(int A_0)
    {
        return smethod_29(Class969.smethod_68(A_0 * 2));
    }

    internal static int smethod_26(string A_0)
    {
        return Class969.smethod_71(smethod_30(A_0) / 2.0);
    }

    internal static string smethod_27(int A_0)
    {
        return smethod_29(Class969.smethod_68(A_0));
    }

    internal static int smethod_28(string A_0)
    {
        return Class969.smethod_71(smethod_30(A_0));
    }

    private static string smethod_29(double A_0)
    {
        return (Class1041.smethod_44(Math.Round((double) (A_0 * 100.0))) + BookmarkStart.b("ሶ", 0x11));
    }

    internal static void smethod_3(int A_0, int A_1)
    {
        int num = (A_0 < A_1) ? A_0 : A_1;
        if (num == 0)
        {
            double_7 = 1.0;
        }
        else
        {
            double_7 = 0xf4240 / num;
        }
    }

    private static double smethod_30(string A_0)
    {
        return (Class1041.smethod_12(A_0.Replace(BookmarkStart.b("ᄳ", 14), "")) / 100.0);
    }

    internal static string smethod_31(int A_0, double A_1)
    {
        return smethod_53(smethod_32(A_0, A_1));
    }

    private static double smethod_32(int A_0, double A_1)
    {
        return (smethod_45(A_0) - smethod_43(A_1));
    }

    internal static int smethod_33(double A_0)
    {
        return Class1133.smethod_5((A_0 * 1440.0) / 2.54);
    }

    private static int smethod_34(double A_0)
    {
        return Class1133.smethod_5(A_0 * 1440.0);
    }

    internal static string smethod_35(object A_0)
    {
        return smethod_54(smethod_47(Convert.ToSingle(A_0)) * 20.0);
    }

    internal static int smethod_36(string A_0)
    {
        int num = 7;
        if (!smethod_38(A_0))
        {
            return 0;
        }
        double num2 = smethod_40(A_0);
        string str2 = smethod_39(A_0);
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("䐬䄮", num))
            {
                return smethod_34(num2);
            }
            if (str2 == BookmarkStart.b("崬嬮", num))
            {
                return Class969.smethod_31(num2);
            }
            if (str2 == BookmarkStart.b("丬䈮", num))
            {
                return smethod_33(num2);
            }
        }
        return smethod_33(num2 / 10.0);
    }

    internal static double smethod_37(string A_0)
    {
        int num = 0;
        if (!smethod_38(A_0))
        {
            return 0.0;
        }
        double num2 = smethod_40(A_0);
        string str2 = smethod_39(A_0);
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("伥䘧", num))
            {
                return (num2 * 2.54);
            }
            if (str2 == BookmarkStart.b("嘥尧", num))
            {
                return (num2 * 0.035277777777777776);
            }
            if (str2 == BookmarkStart.b("䔥䔧", num))
            {
                return num2;
            }
        }
        return (num2 / 10.0);
    }

    internal static bool smethod_38(string A_0)
    {
        int num = 7;
        if ((!A_0.EndsWith(BookmarkStart.b("丬䈮", 7)) && !A_0.EndsWith(BookmarkStart.b("䐬䄮", num))) && !A_0.EndsWith(BookmarkStart.b("䀬䈮", num)))
        {
            return A_0.EndsWith(BookmarkStart.b("崬嬮", num));
        }
        return true;
    }

    internal static string smethod_39(string A_0)
    {
        return A_0.Substring(A_0.Length - 2, 2);
    }

    internal static bool smethod_4(int A_0, int A_1)
    {
        if ((A_0 <= 0) || (A_1 <= 0))
        {
            return false;
        }
        if (A_0 >= 0x7a120)
        {
            return (A_1 < 0x7a120);
        }
        return true;
    }

    internal static double smethod_40(string A_0)
    {
        return Class1041.smethod_12(A_0.Substring(0, A_0.Length - 2));
    }

    internal static double smethod_41(string A_0)
    {
        int num = 0x10;
        if (!smethod_38(A_0))
        {
            return 0.0;
        }
        double num2 = smethod_40(A_0);
        string str2 = smethod_39(A_0);
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("張嘷", num))
            {
                return Class969.smethod_13(num2);
            }
            if (str2 == BookmarkStart.b("嬵唷", num))
            {
                return Class969.smethod_15(num2);
            }
            if (str2 == BookmarkStart.b("䘵䰷", num))
            {
                return num2;
            }
        }
        return smethod_48(num2);
    }

    internal static string smethod_42(double A_0)
    {
        return smethod_54(smethod_44(A_0));
    }

    internal static double smethod_43(double A_0)
    {
        return Math.Round((double) ((A_0 * 2.54) / 72.0), 3);
    }

    internal static double smethod_44(double A_0)
    {
        return Math.Round((double) (A_0 / 72.0), 4);
    }

    internal static double smethod_45(int A_0)
    {
        return Math.Round((double) ((A_0 * 2.54) / 1440.0), 3);
    }

    internal static double smethod_46(float A_0)
    {
        return Math.Round((double) ((A_0 * 2.54) / 1440.0), 3);
    }

    internal static double smethod_47(float A_0)
    {
        return Math.Round((double) (((double) A_0) / 1440.0), 4);
    }

    internal static double smethod_48(double A_0)
    {
        return ((A_0 * 72.0) / 2.54);
    }

    internal static int smethod_49(double A_0)
    {
        return Class1133.smethod_5(A_0 * 20.0);
    }

    internal static string smethod_5(int A_0)
    {
        double num = Class969.smethod_68(A_0) + ((A_0 < 0) ? ((double) 180) : ((double) 0));
        return Class1041.smethod_47((num % 360.0) * 10.0);
    }

    internal static double smethod_50(int A_0)
    {
        return (A_0 * 0.05);
    }

    internal static int smethod_51(double A_0)
    {
        return Class969.smethod_39(smethod_33(A_0));
    }

    internal static int smethod_52(string A_0)
    {
        int num = 9;
        if (smethod_67(A_0))
        {
            return Class969.smethod_31(Class969.smethod_23(1.0));
        }
        if (A_0.EndsWith(BookmarkStart.b("ਮ", num)))
        {
            return Class969.smethod_31(Class969.smethod_23(Class1041.smethod_12(A_0.Replace(BookmarkStart.b("ਮ", num), "")) / 100.0));
        }
        return smethod_36(A_0);
    }

    internal static string smethod_53(double A_0)
    {
        return string.Format(BookmarkStart.b("䌷ਹ䄻崽ⴿ", 0x12), Class1041.smethod_44(Math.Round(A_0, 3)));
    }

    internal static string smethod_54(double A_0)
    {
        return string.Format(BookmarkStart.b("䠲Դ䨶倸唺", 13), Class1041.smethod_44(Math.Round(A_0, 4)));
    }

    internal static int smethod_55(string A_0)
    {
        return Class969.smethod_40(smethod_41(A_0));
    }

    internal static string smethod_56(int A_0)
    {
        return smethod_42(Class969.smethod_42(A_0));
    }

    internal static string smethod_57(int A_0, Border A_1)
    {
        double num = smethod_45(A_0);
        double num2 = 0.0;
        double num3 = 0.0;
        if (A_1 != null)
        {
            num2 = smethod_32(A_0, (double) A_1.Space);
            num3 = smethod_43((double) A_1.LineWidth);
        }
        return smethod_53((num - num2) - num3);
    }

    internal static string smethod_58(Border A_0, bool A_1)
    {
        int num = 8;
        if (((A_0 != null) && (A_0.BorderType != BorderStyle.None)) && (A_0.BorderType != BorderStyle.Cleared))
        {
            Color black = A_0.Color;
            if (black.IsEmpty)
            {
                black = Color.Black;
            }
            string str = smethod_75(black);
            return string.Format(BookmarkStart.b("唭/伱ᐳ䴵ष䜹᰻䔽爿㽁", num), smethod_42((double) A_0.LineWidth), Class922.smethod_34(A_0.BorderType), str);
        }
        if (!A_1)
        {
            return BookmarkStart.b("䀭弯就儳", num);
        }
        return null;
    }

    internal static double smethod_59(BorderStyle A_0, int A_1)
    {
        double num = A_1;
        switch (A_0)
        {
            case BorderStyle.Double:
                return (num * 3.0);

            case ((BorderStyle) 4):
            case BorderStyle.Hairline:
            case BorderStyle.Dot:
            case BorderStyle.DashLargeGap:
            case BorderStyle.DotDash:
            case BorderStyle.DotDotDash:
            case BorderStyle.DashSmallGap:
            case BorderStyle.DashDotStroker:
                return num;

            case BorderStyle.Triple:
                return (num * 5.0);

            case BorderStyle.ThinThickSmallGap:
            case BorderStyle.ThickThinSmallGap:
                return (num * 2.5);

            case BorderStyle.ThinThickThinSmallGap:
                return (num * 1.5);

            case BorderStyle.ThinThickMediumGap:
            case BorderStyle.ThickThinMediumGap:
                return (num * 2.0);

            case BorderStyle.ThinThickThinMediumGap:
                return (num * 3.0);

            case BorderStyle.ThinThickLargeGap:
            case BorderStyle.ThickThinLargeGap:
                return (num * 3.25);

            case BorderStyle.ThinThickThinLargeGap:
                return (num * 3.0);

            case BorderStyle.Wave:
                return (num * 3.0);

            case BorderStyle.DoubleWave:
                return (num * 5.0);

            case BorderStyle.Emboss3D:
            case BorderStyle.Engrave3D:
                return (num * 1.5);
        }
        return num;
    }

    internal static string smethod_6(int A_0)
    {
        return Class1041.smethod_47(Class969.smethod_68(A_0));
    }

    internal static int smethod_60(BorderStyle A_0, double A_1)
    {
        double num;
        switch (A_0)
        {
            case BorderStyle.Double:
                num = A_1 / 3.0;
                break;

            case BorderStyle.Triple:
                num = A_1 / 5.0;
                break;

            case BorderStyle.ThinThickSmallGap:
            case BorderStyle.ThickThinSmallGap:
                num = A_1 / 2.5;
                break;

            case BorderStyle.ThinThickThinSmallGap:
                num = A_1 / 1.5;
                break;

            case BorderStyle.ThinThickMediumGap:
            case BorderStyle.ThickThinMediumGap:
                num = A_1 / 2.0;
                break;

            case BorderStyle.ThinThickThinMediumGap:
                num = A_1 / 3.0;
                break;

            case BorderStyle.ThinThickLargeGap:
            case BorderStyle.ThickThinLargeGap:
                num = A_1 / 3.25;
                break;

            case BorderStyle.ThinThickThinLargeGap:
                num = A_1 / 3.0;
                break;

            case BorderStyle.Wave:
                num = A_1 / 3.0;
                break;

            case BorderStyle.DoubleWave:
                num = A_1 / 5.0;
                break;

            case BorderStyle.Emboss3D:
            case BorderStyle.Engrave3D:
                num = A_1 / 1.5;
                break;

            default:
                num = A_1;
                break;
        }
        return smethod_61(num);
    }

    private static int smethod_61(double A_0)
    {
        int num = Class1133.smethod_5(A_0 * 8.0);
        if ((num == 0) && (A_0 > 0.0))
        {
            return 1;
        }
        return num;
    }

    internal static Class16 smethod_62(string A_0, Class16 A_1)
    {
        int num = 1;
        if (A_1 == null)
        {
            A_1 = new Class16();
        }
        if (A_0 == BookmarkStart.b("匦嬨䨪䌬尮䄰刲䜴制圸伺", num))
        {
            A_1.method_57(Color.Empty);
            return A_1;
        }
        A_1.method_57(smethod_76(A_0));
        return A_1;
    }

    internal static Class110 smethod_63(Class43 A_0, ArrowType A_1, bool A_2)
    {
        int num = 5;
        StrokeArrowLength medium = StrokeArrowLength.Medium;
        if (A_0.HasValue(A_2 ? 0x1d3 : 0x1d5))
        {
            medium = (StrokeArrowLength) A_0.method_31(A_2 ? 0x1d3 : 0x1d5);
        }
        string key = string.Format(BookmarkStart.b("倪ᴬ刮䨰Ȳ䠴", num), Class922.smethod_51(A_1), medium);
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_111 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x2d);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲昴弶嘸䤺䤼焾⁀ㅂ㝄⡆㹈", num), 0);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲破制崸刺䠼刾ཀ≂㝄㕆♈㱊", num), 1);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲礴堶圸尺猼帾㍀ㅂ⩄う", num), 2);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲昴弶嘸䤺䤼爾⑀❂ⱄ㉆⑈", num), 3);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲破制崸刺䠼刾ీ♂⅄⹆㱈♊", num), 4);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲礴堶圸尺瀼娾╀⩂い⩆", num), 5);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲昴弶嘸䤺䤼栾⡀❂⁄", num), 6);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲破制崸刺䠼刾ᙀ⩂⅄≆", num), 7);
                dictionary1.Add(BookmarkStart.b("横弬崮帰䐲礴堶圸尺樼嘾╀♂", num), 8);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶樸区刼䴾㕀โ⁄⍆⁈㹊⁌", num), 9);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶琸帺夼嘾㑀⹂ࡄ≆ⵈ≊㡌≎", num), 10);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶甸吺匼堾ཀ≂㝄㕆♈㱊", num), 11);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶樸区刼䴾㕀ൂ⑄㕆㭈⑊㩌", num), 12);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶琸帺夼嘾㑀⹂ୄ♆㭈㥊≌㡎", num), 13);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶琸帺夼嘾㑀⹂ቄ⹆ⵈ⹊", num), 14);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶樸区刼䴾㕀ᑂⱄ⍆ⱈ", num), 15);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶甸吺匼堾ీ♂⅄⹆㱈♊", num), 0x10);
                dictionary1.Add(BookmarkStart.b("漪䐬丮尰尲嬴匶甸吺匼堾ᙀ⩂⅄≆", num), 0x11);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰怲崴堶䬸伺瀼娾╀⩂い⩆", num), 0x12);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰縲倴匶倸为值爾⑀❂ⱄ㉆⑈", num), 0x13);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰缲娴夶常町尼䴾㍀ⱂ㉄", num), 20);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰怲崴堶䬸伺猼帾㍀ㅂ⩄う", num), 0x15);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰縲倴匶倸为值焾⁀ㅂ㝄⡆㹈", num), 0x16);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰縲倴匶倸为值栾⡀❂⁄", num), 0x17);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰怲崴堶䬸伺樼嘾╀♂", num), 0x18);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰缲娴夶常瘺堼嬾⡀㙂⡄", num), 0x19);
                dictionary1.Add(BookmarkStart.b("搪崬䨮弰缲娴夶常氺吼嬾⑀", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰怲崴堶䬸伺瀼娾╀⩂い⩆", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰縲倴匶倸为值爾⑀❂ⱄ㉆⑈", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰缲娴夶常町尼䴾㍀ⱂ㉄", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰怲崴堶䬸伺猼帾㍀ㅂ⩄う", num), 30);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰縲倴匶倸为值焾⁀ㅂ㝄⡆㹈", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰縲倴匶倸为值栾⡀❂⁄", num), 0x20);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰怲崴堶䬸伺樼嘾╀♂", num), 0x21);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰缲娴夶常瘺堼嬾⡀㙂⡄", num), 0x22);
                dictionary1.Add(BookmarkStart.b("搪嬬丮崰缲娴夶常氺吼嬾⑀", num), 0x23);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲昴弶嘸䤺䤼爾⑀❂ⱄ㉆⑈", num), 0x24);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲破制崸刺䠼刾ీ♂⅄⹆㱈♊", num), 0x25);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲礴堶圸尺猼帾㍀ㅂ⩄う", num), 0x26);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲昴弶嘸䤺䤼焾⁀ㅂ㝄⡆㹈", num), 0x27);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲破制崸刺䠼刾ཀ≂㝄㕆♈㱊", num), 40);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲破制崸刺䠼刾ᙀ⩂⅄≆", num), 0x29);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲昴弶嘸䤺䤼栾⡀❂⁄", num), 0x2a);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲礴堶圸尺瀼娾╀⩂い⩆", num), 0x2b);
                dictionary1.Add(BookmarkStart.b("椪䄬䀮到堲礴堶圸尺樼嘾╀♂", num), 0x2c);
                Class1160.dictionary_111 = dictionary1;
            }
            if (Class1160.dictionary_111.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ癆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ灀", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ਺़༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ఼ା煀⭂桄癆絈筊㝌", num));

                    case 1:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ畆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ獀", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ༼฾煀⭂桄癆絈筊㝌", num));

                    case 2:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ瑆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ牀", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ฼ਾ煀⭂桄癆絈筊㝌", num));

                    case 3:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ獆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ畀", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ਺़༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ灀睂畄⽆摈祊籌罎⭐", num));

                    case 4:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ牆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ瑀", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ獀牂畄⽆摈祊籌罎⭐", num));

                    case 5:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ煆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ着", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ牀療畄⽆摈祊籌罎⭐", num));

                    case 6:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ灆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ癀", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ਺़༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ灀睂畄⽆摈硊硌罎⭐", num));

                    case 7:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ罆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ祀", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ獀牂畄⽆摈硊硌罎⭐", num));

                    case 8:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ繆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ础", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ牀療畄⽆摈硊硌罎⭐", num));

                    case 9:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒摔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌繎", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ਺़༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ਼༾汀瑂畄杆繈筊恌硎慐繒扔杖⍘", num));

                    case 10:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒杔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌絎", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ఼༾瑀湂牄睆楈穊経穎籐摒敔穖桘歚桜╞", num));

                    case 11:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒晔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌籎", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ఼࠾瑀湂牄睆楈穊穌穎籐摒敔穖桘汚桜╞", num));

                    case 12:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒慔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌筎", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ਺़༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ癀獂桄癆祈繊浌硎慐繒摔杖汘癚橜潞᭠", num));

                    case 13:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒恔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌穎", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ灀獂灄橆硈筊硌潎恐捒恔穖桘歚桜牞偠卢偤ᵦ", num));

                    case 14:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒捔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌祎", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ灀瑂灄橆硈筊硌潎恐摒恔穖桘歚桜牞偠呢偤ᵦ", num));

                    case 15:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒扔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌硎", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ਺़༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ癀獂桄癆繈繊浌硎慐繒摔恖汘癚橜潞᭠", num));

                    case 0x10:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒浔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌睎", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ灀獂灄橆硈籊硌潎恐捒恔穖桘汚桜牞偠卢偤ᵦ", num));

                    case 0x11:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊ቌ絎慐౒汔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶紸刺尼刾⹀ⵂ⅄Ɇ❈⽊浌癎", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ灀瑂灄橆硈籊硌潎恐摒恔穖桘汚桜牞偠呢偤ᵦ", num));

                    case 0x12:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ繎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆硈", num), BookmarkStart.b("ᬪബἮᄰĲĴȶᤸऺ़ਾ", num), BookmarkStart.b("䘪ᰬᴮȰጲԴ᜶࠸ऺ༼Ἶ獀煂癄橆穈籊浌絎捐繒浔扖瑘橚桜桞䱠孢卤䝦塨幪婬䉮䉰䑲塴䕶䭸ź", num));

                    case 0x13:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ絎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆筈", num), BookmarkStart.b("ᬪബἮᄰĲĴȶᤸ࠺఼ਾ", num), BookmarkStart.b("䘪ᰬᴮȰጲԴ᜶࠸ऺ༼Ἶ獀筂牄橆穈籊浌絎楐繒浔扖瑘楚浜浞䱠孢卤䝦孨孪彬䉮䉰䑲塴䕶䅸ź", num));

                    case 20:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ籎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆穈", num), BookmarkStart.b("ᬪബἮᄰĲĴȶᤸ༺༼༾", num), BookmarkStart.b("䘪ᰬᴮȰጲԴ᜶࠸ऺ༼Ἶ牀筂睄橆穈籊浌籎楐繒浔扖瑘楚歜晞䱠孢卤䝦孨嵪呬䉮䉰䑲塴䑶䅸ź", num));

                    case 0x15:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ筎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆絈", num), BookmarkStart.b("ᬪബἮᄰ2дȶᤸऺ़ਾ", num), BookmarkStart.b("䘪ᰬᨮरጲԴ᜶࠸਼ฺἾ獀煂癄橆絈籊浌絎捐繒摔晖楘癚汜橞噠乢呤噦塨䭪屬婮䙰干䅴䁶呸䥺佼վ", num));

                    case 0x16:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ穎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆籈", num), BookmarkStart.b("ᬪബἮᄰ2дȶᤸ࠺఼ਾ", num), BookmarkStart.b("䘪ᰬᨮरጲԴ᜶࠸਼ฺἾ獀筂牄橆絈籊浌絎楐繒摔晖楘癚潜潞占乢呤噦塨䭪彬彮䍰干䅴䁶呸䥺䕼վ", num));

                    case 0x17:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ祎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆罈", num), BookmarkStart.b("ᬪബἮᄰ2дȶᤸ༺༼༾", num), BookmarkStart.b("䘪ᰬᨮरጲԴ᜶࠸਼ฺἾ牀筂睄橆絈籊浌籎楐繒摔晖楘癚潜楞塠乢呤噦塨䭪彬奮䡰干䅴䁶呸䡺䕼վ", num));

                    case 0x18:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ硎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆繈", num), BookmarkStart.b("ᬪബἮᄰܴܲܶᤸऺ़ਾ", num), BookmarkStart.b("䘪ἬḮİጲԴ᜶ସ਺഼Ἶ獀煂癄橆罈硊浌絎捐繒摔捖湘癚汜橞噠乢呤卦幨䭪屬婮䙰干䍴䑶呸䥺佼վ", num));

                    case 0x19:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ睎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆煈", num), BookmarkStart.b("ᬪബἮᄰܴܲܶᤸ࠺఼ਾ", num), BookmarkStart.b("䘪ἬḮİጲԴ᜶ସ਺഼Ἶ獀筂牄橆罈硊浌絎楐繒摔捖湘癚潜潞占乢呤卦幨䭪彬彮䍰干䍴䑶呸䥺䕼վ", num));

                    case 0x1a:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄ᡆ筈筊ቌ癎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䬺堼儾рⵂ⅄杆灈", num), BookmarkStart.b("ᬪബἮᄰܴܲܶᤸ༺༼༾", num), BookmarkStart.b("䘪ἬḮİጲԴ᜶ସ਺഼Ἶ牀筂睄橆罈硊浌籎楐繒摔捖湘癚潜楞塠乢呤卦幨䭪彬奮䡰干䍴䑶呸䡺䕼վ", num));

                    case 0x1b:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ繎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆硈", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ਺़༾", num), BookmarkStart.b("䘪ᰬᬮİጲԴ吶सᘺ฼ܾ汀灂睄橆繈筊恌硎慐繒扔杖⩘癚橜潞䅠偢坤䩦幨孪䵬塮䅰卲䙴䕶奸䱺䵼彾뚀뎂ꖄ낆릈ꮊ몌뾎벐ꂒꞔ랖꺘ꮚ난ꢞ醠\ud9a2", num));

                    case 0x1c:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ絎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆筈", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬᬮİጲԴ吶सᘺ࠼࠾汀灂睄橆硈筊硌扎晐捒硔晖楘湚⹜牞噠卢䕤卦全䙪婬彮兰䉲䕴䉶奸䡺佼彾낀뎂낄Ꞇ뺈뮊권뺎ꆐꚒ떔ꂖꦘ뚚ꦜꞞ膠钢閤誦風鮪颬햮", num));

                    case 0x1d:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ籎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆穈", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᰬᬮİጲԴ吶सᘺмा汀灂睄橆硈籊硌扎晐捒硔晖湘湚⹜牞噠卢䕤偦偨䙪婬彮兰䉲䉴䉶奸䡺佼彾낀뒂낄Ꞇ뺈뮊권뺎ꚐꚒ떔ꂖꦘ뚚ꪜꚞ膠钢閤誦風鲪颬햮", num));

                    case 30:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ筎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆絈", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ਺़༾", num), BookmarkStart.b("䘪ἬḮİጲԴ吶सᘺ฼ܾ汀睂組橆繈筊恌繎慐晒硔恖楘⡚灜湞兠噢䕤呦孨䙪屬彮䑰卲䉴䝶奸佺䕼彾뚀뎂ꖄ뚆릈뺊권뢎ꆐ뎒꒔Ꞗ겘뚚꺜궞膠銢閤銦蒨鲪鶬햮", num));

                    case 0x1f:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ穎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆籈", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸऺ఼༾", num), BookmarkStart.b("䘪ἬḮİጲԴ吶सᘺ࠼࠾汀睂組橆硈筊硌扎恐捒恔穖桘歚桜ⱞ䱠剢啤剦䥨彪啬䉮䁰䍲䁴坶䡸䭺䡼彾떀뮂ꖄ뚆릈뺊권뺎ꆐꚒ떔Ꚗꦘ꺚붜꺞醠隢袤鎦醨讪鲬龮蒰麲蒴螶貸솺", num));

                    case 0x20:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ祎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆罈", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ἬḮİጲԴ吶सᘺмा汀睂組橆硈籊硌扎恐捒恔穖桘汚桜ⱞ䱠剢啤剦䥨屪呬䉮䁰䍲䁴坶䡸䱺䡼彾떀뮂ꖄ뚆뺈뺊권뺎ꆐꚒ떔Ꚗ꺘꺚붜꺞醠隢袤邦邨讪鲬龮蒰麲蒴肶貸솺", num));

                    case 0x21:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ硎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆繈", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ਺़༾", num), BookmarkStart.b("䘪ḬᨮİጲԴ吶सᘺ฼ܾ汀瑂籄橆繈筊恌繎晐晒硔恖楘⡚灜湞噠噢䕤呦孨䙪屬塮䑰卲䉴䝶奸䱺䑼彾뚀뎂ꖄ뚆뺈뺊권뢎ꆐ뎒꒔ꂖ겘뚚꺜궞膠銢銤銦蒨鲪鶬햮", num));

                    case 0x22:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ睎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆煈", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸऺ఼༾", num), BookmarkStart.b("䘪ḬᨮİጲԴ吶सᘺ࠼࠾汀瑂籄橆硈筊硌扎恐摒恔穖桘歚桜ⱞ䱠剢剤剦䥨彪啬䉮䁰䑲䁴坶䡸䭺䡼彾뚀몂ꖄ뚆릈뺊권뺎ꚐꚒ떔Ꚗꦘ꺚붜꺞隠隢袤鎦醨讪鲬颮蒰麲蒴螶貸솺", num));

                    case 0x23:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄ᡆ筈筊ቌ癎", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶瘸䴺尼匾рⵂ⅄杆灈", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ḬᨮİጲԴ吶सᘺмा汀瑂籄橆硈籊硌扎恐摒恔穖桘汚桜ⱞ䱠剢剤剦䥨屪呬䉮䁰䑲䁴坶䡸䱺䡼彾뚀몂ꖄ뚆뺈뺊권뺎ꚐꚒ떔Ꚗ꺘꺚붜꺞隠隢袤邦邨讪鲬颮蒰麲蒴肶貸솺", num));

                    case 0x24:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒摔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌繎", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ਺़༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ఼ା煀湂牄睆摈繊筌扎晐捒畔扖潘⅚", num));

                    case 0x25:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒杔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌絎", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ༼฾煀湂牄睆摈獊祌扎晐捒畔潖浘⅚", num));

                    case 0x26:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒晔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌籎", num), BookmarkStart.b("ᬪബἮᄰȲĴܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᨬἮᄰ̲ᔴ6सᬺ฼ਾ煀湂牄睆摈穊祌罎籐摒敔睖桘潚浜╞", num));

                    case 0x27:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒慔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌筎", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ਺़༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ灀睂畄橆硈筊硌扎摐敒硔晖楘湚絜橞坠ᥢ", num));

                    case 40:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒恔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌穎", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ獀牂畄橆硈筊硌扎楐杒硔晖楘湚絜杞啠ᥢ", num));

                    case 0x29:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒捔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌祎", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ牀療畄橆硈筊硌扎恐杒敔穖桘歚桜罞偠坢啤ᵦ", num));

                    case 0x2a:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒扔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌硎", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ਺़༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ灀睂畄橆硈籊硌扎摐敒硔晖湘湚絜橞坠ᥢ", num));

                    case 0x2b:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒浔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌睎", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ獀牂畄橆硈籊硌扎楐杒硔晖湘湚絜杞啠ᥢ", num));

                    case 0x2c:
                        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊ቌ絎慐౒汔", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶樸伺堼帾ⵀ㝂ⵄɆ❈⽊浌癎", num), BookmarkStart.b("ᬪബἮᄰ24ܶᤸ࠺࠼༾", num), BookmarkStart.b("䘪ᰬᠮаጲԴ᜶࠸఺࠼Ἶ牀療畄橆硈籊硌扎恐杒敔穖桘汚桜罞偠坢啤ᵦ", num));
                }
            }
        }
        return smethod_64(BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼怾獀獂ᩄ牆", num), BookmarkStart.b("䘪帬渮䌰䄲娴䀶簸唺夼Ἶ瑀", num), BookmarkStart.b("ᬪബἮᄰĲдܶᤸऺ఼༾", num), BookmarkStart.b("䘪ᰬἮаጲԴ᜶࠸଺࠼Ἶ獀牂畄⽆摈祊籌罎⭐", num));
    }

    private static Class110 smethod_64(string A_0, string A_1, string A_2, string A_3)
    {
        Class110 class2 = new Class110();
        class2.method_1(A_0);
        class2.method_3(A_1);
        class2.method_5(A_2);
        class2.method_7(A_3);
        return class2;
    }

    internal static string smethod_65(object A_0)
    {
        return string.Format(BookmarkStart.b("唭/伱䐳䈵", 8), Class1041.smethod_44((double) ((float) A_0)));
    }

    internal static void smethod_66(string A_0, Class96 A_1, CharacterFormat A_2, int A_3)
    {
        int num = 9;
        if (A_0.EndsWith(BookmarkStart.b("ਮ", 9)))
        {
            A_1.method_18(Class1041.smethod_12(A_0.Replace(BookmarkStart.b("ਮ", num), "")));
        }
        else
        {
            A_2.SetAttr(A_3, smethod_68(A_0));
        }
    }

    internal static bool smethod_67(string A_0)
    {
        int num;
        return Class1041.smethod_24(A_0, out num);
    }

    internal static float smethod_68(string A_0)
    {
        double num3;
        int num = 0x10;
        if (smethod_67(A_0))
        {
            A_0 = string.Format(BookmarkStart.b("䴵࠷䜹䰻䨽", num), A_0);
        }
        if (!smethod_38(A_0))
        {
            return 0f;
        }
        double num2 = smethod_40(A_0);
        string str = smethod_39(A_0);
        if (str != null)
        {
            if (str != BookmarkStart.b("張嘷", num))
            {
                if (!(str == BookmarkStart.b("䘵䰷", num)))
                {
                    if (!(str == BookmarkStart.b("唵唷", num)))
                    {
                        goto Label_0093;
                    }
                    num3 = smethod_48(num2);
                }
                else
                {
                    num3 = num2;
                }
            }
            else
            {
                num3 = Class969.smethod_13(num2);
            }
            goto Label_00A4;
        }
    Label_0093:
        num3 = smethod_48(num2 / 10.0);
    Label_00A4:
        return (float) num3;
    }

    internal static bool smethod_69(string A_0)
    {
        int num = 4;
        if (!(A_0 == BookmarkStart.b("䌩堫伭尯嬱圳", 4)) && !(A_0 == BookmarkStart.b("䔩丫䈭夯䌱䄳匵", num)))
        {
            return false;
        }
        return true;
    }

    internal static int smethod_7(string A_0)
    {
        return Class969.smethod_71(Class1041.smethod_12(A_0));
    }

    internal static bool smethod_70(string A_0)
    {
        int num = 14;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_112 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                dictionary1.Add(BookmarkStart.b("娳夵䨷圹崻刽", num), 0);
                dictionary1.Add(BookmarkStart.b("嘳夵吷帹", num), 1);
                dictionary1.Add(BookmarkStart.b("Գص࠷", num), 2);
                dictionary1.Add(BookmarkStart.b("سص࠷", num), 3);
                dictionary1.Add(BookmarkStart.b("ܳص࠷", num), 4);
                dictionary1.Add(BookmarkStart.b("3ص࠷", num), 5);
                dictionary1.Add(BookmarkStart.b("ĳص࠷", num), 6);
                dictionary1.Add(BookmarkStart.b("ȳص࠷", num), 7);
                dictionary1.Add(BookmarkStart.b("̳ص࠷", num), 8);
                dictionary1.Add(BookmarkStart.b("ళص࠷", num), 9);
                dictionary1.Add(BookmarkStart.b("ളص࠷", num), 10);
                Class1160.dictionary_112 = dictionary1;
            }
            if (Class1160.dictionary_112.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return false;

                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        return true;
                }
            }
        }
        return false;
    }

    internal static string smethod_71(object A_0, object A_1)
    {
        int num = 8;
        float num2 = (((float) A_0) * 100f) / ((float) A_1);
        if (Math.Abs(num2) > 100f)
        {
            num2 = Math.Sign(num2) * 100;
        }
        return string.Format(BookmarkStart.b("唭/伱ᄳᘵषਹ఻ᬽ", num), Class1041.smethod_44((double) num2));
    }

    internal static int smethod_72(string A_0, int A_1)
    {
        return Class1133.smethod_5((double) smethod_72(A_0, A_1));
    }

    internal static float smethod_73(CharacterFormat A_0, string A_1, float A_2)
    {
        int num = 0x10;
        if (!A_1.StartsWith(BookmarkStart.b("䔵䴷䨹夻䰽", 0x10)) && !A_1.StartsWith(BookmarkStart.b("䔵䴷堹", num)))
        {
            string[] strArray = A_1.Split(new char[] { ' ' });
            if (strArray.Length > 1)
            {
                if (Class1041.smethod_12(strArray[1].Replace(BookmarkStart.b("ጵ", num), string.Empty)) > 67.0)
                {
                    return ((Class1041.smethod_13(strArray[0].Replace(BookmarkStart.b("ጵ", num), string.Empty)) * A_2) / 100f);
                }
                if (Class1041.smethod_12(strArray[0].Replace(BookmarkStart.b("ጵ", num), string.Empty).Replace(BookmarkStart.b("ጵ", num), string.Empty)) > 0.0)
                {
                    A_0.SetAttr(210, SubSuperScript.SuperScript);
                }
                else
                {
                    A_0.SetAttr(210, SubSuperScript.SubScript);
                }
                return 0f;
            }
            if (strArray.Length == 1)
            {
                if (Class1041.smethod_12(strArray[0].Replace(BookmarkStart.b("ጵ", num), string.Empty)) > 0.0)
                {
                    A_0.SetAttr(210, SubSuperScript.SuperScript);
                }
                else
                {
                    A_0.SetAttr(210, SubSuperScript.SubScript);
                }
            }
        }
        return 0f;
    }

    internal static string smethod_74(Color A_0, bool A_1)
    {
        int num = 0x13;
        if (A_1 && A_0.IsEmpty)
        {
            A_0 = Color.Black;
        }
        else
        {
            if (A_0 == Color.Transparent)
            {
                return BookmarkStart.b("䴸䤺尼儾㉀㍂⑄㕆ⱈ╊㥌", num);
            }
            if (A_0.IsEmpty)
            {
                return "";
            }
        }
        if (A_0 == Color.FromArgb(0xef, 240, 2, 0))
        {
            return BookmarkStart.b("ᨸ崺嬼夾❀╂⍄", num);
        }
        return string.Format(BookmarkStart.b("ᨸ䀺഼䈾㩀牂㡄㱆筈㙊㙌籎ⱐ", num), new object[] { ((A_0.A == 0xff) || (A_0.A == 0)) ? "" : Class1041.smethod_40(A_0.A), Class1041.smethod_40(A_0.R), Class1041.smethod_40(A_0.G), Class1041.smethod_40(A_0.B) });
    }

    internal static string smethod_75(Color A_0)
    {
        return smethod_74(A_0, true);
    }

    internal static Color smethod_76(string A_0)
    {
        if (A_0 == BookmarkStart.b("䐯䀱唳堵䬷䨹崻䰽┿ⱁぃ", 10))
        {
            return Color.Transparent;
        }
        if (A_0[0] == '#')
        {
            A_0 = A_0.TrimStart(new char[] { '#' });
            if (A_0.Length == 6)
            {
                return Color.FromArgb(Class1041.smethod_26(A_0.Substring(0, 2)), Class1041.smethod_26(A_0.Substring(2, 2)), Class1041.smethod_26(A_0.Substring(4, 2)));
            }
            if (A_0.Length == 8)
            {
                return Color.FromArgb(Class1041.smethod_26(A_0.Substring(0, 2)), Class1041.smethod_26(A_0.Substring(2, 2)), Class1041.smethod_26(A_0.Substring(4, 2)), Class1041.smethod_26(A_0.Substring(6, 2)));
            }
        }
        return Color.Empty;
    }

    private static int smethod_77(string A_0, bool A_1)
    {
        double num2;
        int num = 15;
        if (A_0.EndsWith(BookmarkStart.b("ဴ", 15)))
        {
            num2 = Class1041.smethod_12(A_0.Replace(BookmarkStart.b("ဴ", num), "")) / 100.0;
        }
        else
        {
            num2 = Class1041.smethod_12(A_0);
        }
        return Class969.smethod_71(A_1 ? (1.0 - num2) : num2);
    }

    internal static int smethod_78(string A_0)
    {
        return smethod_77(A_0, false);
    }

    internal static int smethod_79(string A_0)
    {
        return smethod_77(A_0, true);
    }

    internal static int smethod_8(string A_0)
    {
        int num = 3;
        if (A_0.EndsWith(BookmarkStart.b("丨太䰬䬮", 3)))
        {
            return Class969.smethod_71(Class1041.smethod_12(A_0.Replace(BookmarkStart.b("丨太䰬䬮", num), "")) * 0.9);
        }
        if (A_0.EndsWith(BookmarkStart.b("嬨䨪䤬", num)))
        {
            return Class969.smethod_71((Class1041.smethod_12(A_0.Replace(BookmarkStart.b("嬨䨪䤬", num), "")) * 180.0) / 3.1415926535897931);
        }
        if (A_0.EndsWith(BookmarkStart.b("䴨个䨬", num)))
        {
            return smethod_7(A_0.Replace(BookmarkStart.b("䴨个䨬", num), ""));
        }
        return smethod_7(A_0);
    }

    private static string smethod_80(int A_0, bool A_1)
    {
        double num = Math.Round((double) (Class969.smethod_68(A_0) * 100.0));
        return string.Format(BookmarkStart.b("䨰̲䠴ሶ", 11), Class1041.smethod_44(A_1 ? (100.0 - num) : num));
    }

    internal static string smethod_81(int A_0)
    {
        return smethod_80(A_0, false);
    }

    internal static string smethod_82(int A_0)
    {
        return smethod_80(A_0, true);
    }

    internal static string smethod_83(Class16 A_0)
    {
        int num = 8;
        Color color = A_0.method_60();
        Color color2 = A_0.method_56();
        if ((A_0.method_62() != TextureStyle.TextureNone) && (A_0.method_62() != TextureStyle.TextureNil))
        {
            double num2 = Class922.smethod_36(A_0.method_62());
            string str = ((color.A == 0xff) || (color.A == 0)) ? "" : smethod_84(color.A, color2.A, num2);
            string str2 = smethod_84(color.R, color2.R, num2);
            string str3 = smethod_84(color.G, color2.G, num2);
            string str4 = smethod_84(color.B, color2.B, num2);
            return string.Format(BookmarkStart.b("ഭ䬯ȱ䤳䴵ष䜹䜻ఽ㴿㥁睃㭅", num), new object[] { str, str2, str3, str4 });
        }
        if (!color2.IsEmpty && !(color2 == Color.Transparent))
        {
            return smethod_75(color2);
        }
        return null;
    }

    private static string smethod_84(int A_0, int A_1, double A_2)
    {
        if (A_2 == 1.0)
        {
            return Class1041.smethod_40(A_0);
        }
        if ((A_0 == 0) && (A_1 == 0))
        {
            return Class1041.smethod_40((byte) (255.0 - (255.0 * A_2)));
        }
        if (A_0 == 0xff)
        {
            return Class1041.smethod_40(A_1);
        }
        int num = Math.Max(A_0, A_1);
        int num2 = Math.Abs((int) (A_0 - A_1));
        int num3 = (byte) (num - (num2 * A_2));
        return Class1041.smethod_40(num3);
    }

    internal static string smethod_85(bool A_0, IRunAttrSource A_1, int A_2, string A_3)
    {
        return smethod_86(A_0, A_1, A_2, A_3, null);
    }

    internal static string smethod_86(bool A_0, IRunAttrSource A_1, int A_2, string A_3, string A_4)
    {
        object obj2 = new Class650(A_0).method_6(A_1, A_2);
        if (obj2 == null)
        {
            return null;
        }
        if (!((bool) obj2))
        {
            return A_4;
        }
        return A_3;
    }

    internal static string smethod_87(string A_0)
    {
        if (!Class567.smethod_16(A_0))
        {
            return A_0;
        }
        string str2 = A_0;
        foreach (Match match in regex_2.Matches(A_0))
        {
            string str = match.Value;
            if (Class567.smethod_16(str))
            {
                str2 = str2.Replace(str, ((char) Class1041.smethod_26(str.Trim(new char[] { '_' }))).ToString());
            }
        }
        return str2;
    }

    internal static string smethod_88(string A_0)
    {
        int num = 12;
        if (!Class567.smethod_16(A_0))
        {
            return A_0;
        }
        string str2 = A_0;
        string input = A_0.Substring(0, 1);
        MatchCollection matchs = regex_0.Matches(input);
        if (matchs.Count > 0)
        {
            Match match2 = matchs[0];
            string str4 = Class1041.smethod_37(match2.Value[0]);
            str2 = string.Format(BookmarkStart.b("䤱г䬵䌷ହ䄻", num), string.Format(BookmarkStart.b("洱伳ص䔷改", num), str4), A_0.Substring(1));
        }
        string str5 = A_0.Substring(1);
        foreach (Match match in regex_1.Matches(str5))
        {
            string str = Class1041.smethod_37(match.Value[0]);
            str2 = str2.Replace(match.Value, string.Format(BookmarkStart.b("洱伳ص䔷改", num), str));
        }
        return str2;
    }

    internal static string smethod_89(string A_0, string A_1, bool A_2)
    {
        int num = 4;
        string str = A_0;
        if (Class736.smethod_14(str))
        {
            return str;
        }
        if (!smethod_92(str))
        {
            return "";
        }
        if (!Class736.smethod_5(str))
        {
            str = str.TrimStart(char_2);
            str = Class736.smethod_0(A_1, str);
            str = string.Format(BookmarkStart.b("䰩䔫䈭唯࠱ᬳᤵ䌷ਹ䄻", num), str);
        }
        else
        {
            str = Class736.smethod_15(str);
        }
        return str.Replace(BookmarkStart.b("瘩", num), BookmarkStart.b("ԩ", num));
    }

    internal static string smethod_9(float A_0, LineSpacingRule A_1)
    {
        int num = 13;
        if (A_1 == LineSpacingRule.Multiple)
        {
            return string.Format(BookmarkStart.b("䠲Դ䨶᰸", num), Class1041.smethod_44(Math.Round((double) (Class969.smethod_35((int) A_0) * 100.0))));
        }
        return smethod_35(A_0);
    }

    internal static bool smethod_90(string A_0)
    {
        return ((A_0 != BookmarkStart.b("弰尲嬴制", 11)) && (smethod_36(A_0.Split(new char[] { ' ' })[1]) > 0));
    }

    internal static string smethod_91(string A_0)
    {
        return A_0.Replace(BookmarkStart.b("䨫䜭尯圱ำᤵ᜷", 6), "");
    }

    private static bool smethod_92(string A_0)
    {
        return (Class567.smethod_16(A_0) && (A_0.IndexOfAny(char_1) == -1));
    }

    public static double smethod_93()
    {
        return double_7;
    }

    public static void smethod_94(double A_0)
    {
        double_7 = A_0;
    }
}

