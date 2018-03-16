using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class627
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    internal const int int_0 = 0x501;
    internal const string string_0 = "\x0001Ole10Native";
    internal const string string_1 = "\x0003OCXNAME";
    internal const string string_2 = "\x0003ObjInfo";
    internal const string string_3 = "\x0003PRINT";
    internal const string string_4 = "\x0003OCXDATA";
    internal const string string_5 = "\x0001CompObj";
    internal const string string_6 = "\x0003LinkInfo";

    static Class627()
    {
        hashtable_0.Add(BookmarkStart.b("稶樸缺似帾㙀", 0x11), BookmarkStart.b("䰶स଺഼ా煀獂畄灆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶笸䤺䠼䰾⥀", 0x11), BookmarkStart.b("䰶स଺഼ా煀獂畄♆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䠸为尼䬾⡀ⱂ⭄", 0x11), BookmarkStart.b("䰶स଺഼ా煀獂畄Ն摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶堸堺嘼帾♀♂", 0x11), BookmarkStart.b("䰶स଺഼ా煀獂畄ц摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("搶嘸为匼嬾ፀ♂♄", 0x11), BookmarkStart.b("䰶स଺഼ా煀獂畄͆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("稶椸场尼䘾⑀ㅂ", 0x11), BookmarkStart.b("䰶स଺഼ా煀獂畄Ɇ摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶椸簺似帾ㅀ⭂ⱄ⑆筈穊", 0x11), BookmarkStart.b("䰶स଺഼ା≀筂⅄罆摈筊経罎慐繒敔杖楘歚灜㱞兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ❎㹐⑒答晖歘", 0x11), BookmarkStart.b("䰶稸紺़社瑀療̈́獆摈獊ୌ睎晐繒慔ፖ浘汚灜杞兠Ⅲ❤䩦屨卪嵬坮䁰䕲䅴㕶㭸䡺㭼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ❎㹐⑒答恖", 0x11), BookmarkStart.b("䰶簸稺਼紾@ق牄睆摈ൊཌ籎ፐ繒摔晖ᩘ὚灜Ṟ塠卢噤䩦奨孪ⱬ⹮䅰䍲䁴䙶䥸㹺㱼䱾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ❎㹐⑒答潖", 0x11), BookmarkStart.b("䰶༸༺Լ฾祀݂瑄睆摈罊ୌ癎ፐ繒摔晖ᩘᵚ灜杞坠♢⑤䩦奨孪ⱬ⹮䅰䍲㝴乶䭸䉺㡼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ❎㹐⑒ᡔ㙖㩘⥚㉜ᩞའɢݤ୦౨ཪ䍬幮䍰", 0x11), BookmarkStart.b("䰶紸砺഼ാ煀灂瑄灆摈๊筌੎捐繒慔ᙖ潘楚灜ᵞ塠╢⑤䩦⭨塪⡬⥮㑰䉲䍴䅶䭸䵺㭼䭾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ⍎㡐㝒ご祖桘楚", 0x11), BookmarkStart.b("䰶स༺Լ稾̀睂癄Ɇ摈祊経穎桐繒慔敖歘ᵚ灜晞呠♢啤䩦屨幪婬⭮ば䩲䍴䝶䩸䍺㱼㥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ⍎㡐㝒ご祖湘", 0x11), BookmarkStart.b("䰶簸稺਼紾@ق牄癆摈ൊཌ籎ፐ繒摔晖ᩘ὚灜Ṟ塠卢噤䩦奨孪ⱬ⹮䅰䍲䁴䙶䥸㹺㱼䱾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ⍎㡐㝒ご祖慘", 0x11), BookmarkStart.b("䰶༸༺Լ฾祀݂瑄癆摈罊ୌ癎ፐ繒摔晖ᩘᵚ灜杞坠♢⑤䩦奨孪ⱬ⹮䅰䍲㝴乶䭸䉺㡼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ⍎㡐㝒ごᩖ㡘㡚⽜ぞ①ൢѤզը๪६䅮䁰䅲", 0x11), BookmarkStart.b("䰶ਸ砺఼ܾрɂD獆摈ॊ์絎摐繒慔晖橘潚灜ᵞ噠❢⍤䩦塨⹪⹬⹮䁰䁲䙴䁶㵸㽺㥼㱾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ⍎㡐㝒ごіㅘ㑚⩜煞偠兢", 0x11), BookmarkStart.b("䰶稸紺़社瑀療̈́獆摈獊ୌ睎晐繒慔ፖ浘汚灜杞兠Ⅲ❤䩦屨卪嵬坮䁰䕲䅴㕶㭸䡺㭼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ⍎㡐㝒ごіㅘ㑚⩜煞奠", 0x11), BookmarkStart.b("䰶༸༺Լ฾祀݂瑄睆摈罊ୌ癎ፐ繒摔晖ᩘᵚ灜杞坠♢⑤䩦奨孪ⱬ⹮䅰䍲㝴乶䭸䉺㡼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ṍ⍎㡐㝒ごіㅘ㑚⩜቞`bᝤࡦⱨժ౬൮ᵰᙲᅴ奶䡸䥺", 0x11), BookmarkStart.b("䰶紸砺഼ാ煀灂瑄灆摈๊筌੎捐繒慔ᙖ潘楚灜ᵞ塠╢⑤䩦⭨塪⡬⥮㑰䉲䍴䅶䭸䵺㭼䭾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊᥌⩎㱐⍒㥔㙖ⵘ㹚獜湞占", 0x11), BookmarkStart.b("䰶ฺุ礼༾灀獂牄睆摈穊罌籎敐繒慔捖᱘扚灜杞占╢卤䩦⵨⥪塬⵮䉰䩲㑴䍶乸㡺䱼䱾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊᥌⩎㱐⍒㥔㙖ⵘ㹚獜杞", 0x11), BookmarkStart.b("䰶༸༺Լ฾祀݂瑄癆摈罊ୌ癎ፐ繒摔晖ᩘᵚ灜杞坠♢⑤䩦奨孪ⱬ⹮䅰䍲㝴乶䭸䉺㡼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊᥌⩎㱐⍒㥔㙖ⵘ㹚ၜ㹞ɠᅢ੤≦ݨ੪ཬͮᑰᝲ孴䙶䭸", 0x11), BookmarkStart.b("䰶砸稺఼ା݀穂ل繆摈絊罌ൎ摐繒慔慖橘汚灜杞⁠⁢兤䩦全⵪彬婮㍰㕲䝴乶㵸乺㱼䡾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊ᩌ♎⭐㉒❔㍖睘捚", 0x11), BookmarkStart.b("䰶༸༺Լ฾祀݂瑄睆摈罊ୌ癎ፐ繒摔晖ᩘᵚ灜杞坠♢⑤䩦奨孪ⱬ⹮䅰䍲㝴乶䭸䉺㡼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾՀⱂ♄㉆⑈⹊⍌㭎罐扒杔", 0x11), BookmarkStart.b("䰶缸༺਼ਾ畀B籄Ն摈絊祌ॎ摐繒慔ᕖ浘歚灜杞⁠╢兤䩦彨屪呬塮䉰䅲㑴㑶䥸䵺䵼䡾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾՀⱂ♄㉆⑈⹊⍌㭎罐敒", 0x11), BookmarkStart.b("䰶स଺഼ാ煀穂畄睆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾՀⱂ♄㉆⑈⹊⍌㭎罐歒", 0x11), BookmarkStart.b("䰶स଺഼ാ煀穂畄煆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾՀⱂ♄㉆⑈⹊⍌㭎᱐㉒㙔╖㙘Ṛ㍜㹞͠རdͦ䝨婪彬", 0x11), BookmarkStart.b("䰶࠸̺簼༾着ł獄Ն摈祊ୌ籎ᝐ繒慔ቖ歘ᥚ灜Ṟ坠剢呤䩦屨奪⽬⩮䝰䁲䑴㕶䭸㽺佼䵾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾเ㍂⁄⥆ൈ⑊⹌㩎㱐㙒㭔⍖൘㹚╜⭞你剢坤", 0x11), BookmarkStart.b("䰶࠸示༼ा灀ł睄畆摈੊์祎ၐ繒慔ቖ潘捚灜Ṟ奠呢啤䩦⡨⥪塬彮䥰䍲ぴ佶佸䍺䩼㵾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾᅀ⩂♄㍆㱈㥊⡌慎材", 0x11), BookmarkStart.b("䰶स଺഼ാ煀穂畄癆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾᅀ⩂♄㍆㱈㥊⡌慎楐", 0x11), BookmarkStart.b("䰶स଺഼ാ煀穂畄灆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾፀᝂ̈́楆煈", 0x11), BookmarkStart.b("䰶स଺഼ാ煀穂畄煆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾᕀ♂⡄㝆╈⩊㥌⩎罐扒杔", 0x11), BookmarkStart.b("䰶8਺༼績̀B灄畆摈硊筌੎捐繒慔恖桘潚灜杞①啢坤䩦⡨卪⽬塮䉰ひ㑴䉶㱸䡺䑼佾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾᕀ♂⡄㝆╈⩊㥌⩎罐歒", 0x11), BookmarkStart.b("䰶स଺഼ാ煀穂畄煆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("怶嘸䤺夼ᄾᕀ♂⡄㝆╈⩊㥌⩎᱐㉒㙔╖㙘Ṛ㍜㹞͠རdͦ䝨婪彬", 0x11), BookmarkStart.b("䰶ĸ稺଼ാ畀灂組罆摈੊ౌ絎晐繒慔摖᱘歚灜杞塠╢嵤䩦孨⩪屬嵮㍰㕲㍴䁶㭸㡺㹼㭾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀ɂ㕄㝆╈≊⹌⹎═㩒㩔㥖睘橚潜", 0x11), BookmarkStart.b("䰶स଺഼ാ畀療畄睆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀Bⵄ♆㭈㽊捌穎", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂瑄癆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀Bⵄ♆㭈㽊捌睎", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂睄癆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀Bᙄᅆ", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂癄畆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀ూ㕄≆❈ཊ≌ⱎ⑐㹒ご㥖ⵘ࡚ⵜⵞѠɢŤᑦŨ๪࡬᭮彰䉲䝴", 0x11), BookmarkStart.b("䰶簸稺缼簾рBńՆ摈ࡊ์繎ቐ繒慔ᙖ潘ᵚ灜ᵞ啠♢噤䩦幨⵪啬坮䥰㉲䁴㙶㵸㵺㹼䝾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀၂ⵄ≆ⱈ㽊捌繎捐", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂癄睆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀၂ⵄ≆ⱈ㽊捌穎", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂瑄睆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀၂ⵄ≆ⱈ㽊捌睎", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂睄睆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀၂ⵄ≆ⱈ㽊ཌ♎㽐㉒❔⹖ᑘ㩚㹜ⵞ๠♢୤٦୨ݪ࡬୮彰䉲䝴", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂癄瑆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀၂ⵄ≆ⱈ㽊L⹎㉐⅒㩔ቖ㝘㩚㽜㍞Ѡݢ䭤噦孨", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂癄畆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀ᝂ⁄⩆㥈❊ⱌ㭎㑐絒浔", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂睄睆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("父䄸堺堼匾潀ᝂ⁄⩆㥈❊ⱌ㭎㑐Ṓ㑔㑖⭘㑚ᡜㅞ`Ţ।ɦ൨", 0x11), BookmarkStart.b("䰶स଺഼ാ煀筂癄畆摈筊経罎慐繒敔杖楘歚灜ᱞ兠卢啤䩦奨孪嵬彮䅰䍲䕴䝶䥸䭺䥼䥾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶堸刺匼䬾潀ፂⱄ⑆㵈㹊㽌⩎", 0x11), BookmarkStart.b("䰶紸࠺砼ా畀ł睄癆摈牊ौ硎摐繒摔杖桘ᩚ灜杞≠偢Ⅴ䩦奨孪ⱬ⹮䅰䍲䑴㙶䡸䵺䡼䵾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("朶嘸䰺堼䴾ᅀⱂⱄ⥆㵈敊Ɍ㽎㑐㵒ᅔ㡖㩘⹚ぜ㩞འᝢ㕤ᕦ౨ᡪ࡬ŮհቲŴṶᙸᕺ卼乾뎀", 0x11), BookmarkStart.b("䰶娸ऺԼാ畀牂牄╆摈祊筌祎捐繒慔捖㭘捚灜杞`婢兤䩦婨४୬८䝰䉲ᙴ䉶䥸䉺䵼佾ﲀ", 0x11));
        hashtable_0.Add(BookmarkStart.b("堶䤸帺匼嬾⹀⁂い⩆ⱈ╊㥌慎ᕐ⅒㑔⁖ᵘ㑚㹜⩞ౠ٢୤፦䝨婪", 0x11), BookmarkStart.b("䰶സ༺Լ紾̀瑂牄癆摈ࡊୌ੎捐繒慔恖ᩘ潚灜ᵞ≠❢⍤䩦塨⵪⽬⥮䉰䑲䵴㉶䭸䭺佼㱾ﲀ", 0x11));
    }

    internal static MemoryStream smethod_0(string A_0, byte[] A_1)
    {
        Class1132 class2 = new Class1132(smethod_7(A_0));
        BinaryWriter writer = new BinaryWriter(new MemoryStream(A_1.Length + 4));
        writer.Write(A_1.Length);
        writer.Write(A_1);
        class2.method_0().Add(BookmarkStart.b("㌱笳娵崷ହ఻瀽ℿ㙁ⵃぅⵇ", 12), writer.BaseStream);
        MemoryStream stream = new MemoryStream();
        class2.method_5(stream);
        return stream;
    }

    internal static Class1089 smethod_1(Guid A_0, string A_1, DocOleObject A_2, bool A_3)
    {
        int num = 13;
        Class1089 class2 = new Class1089(A_0);
        if ((A_2.OleObjectType != OleObjectType.BitmapImage) && (A_2.OleObjectType != OleObjectType.WordPicture))
        {
            if (A_2.Interface49.get_NativeData() != null)
            {
                class2.method_2(BookmarkStart.b("挲吴吶券娺娼娾", num), new MemoryStream(A_2.Interface49.get_NativeData()));
            }
        }
        else
        {
            class2.method_2(BookmarkStart.b("挲吴吶券娺娼娾", num), new MemoryStream(A_2.Interface49.get_OlePicture().ImageBytes));
        }
        smethod_6(class2, new Class320(A_3 ? OdtPersist1.Icon : OdtPersist1.None, OdtPersist2.Emf, OdtClipboardFormat.Metafile));
        smethod_6(class2, new Class553(A_1));
        return class2;
    }

    internal static string smethod_2(BinaryReader A_0)
    {
        return smethod_3(A_0, A_0.ReadInt32());
    }

    internal static string smethod_3(BinaryReader A_0, int A_1)
    {
        string str = "";
        if (A_1 > 0)
        {
            byte[] bytes = A_0.ReadBytes(A_1 - 1);
            A_0.ReadByte();
            str = Encoding.GetEncoding(0x4e3).GetString(bytes);
        }
        return str;
    }

    internal static void smethod_4(BinaryWriter A_0, string A_1)
    {
        A_1 = (A_1 == null) ? "" : A_1;
        A_0.Write((int) (A_1.Length + 1));
        A_0.Write(Encoding.GetEncoding(0x4e3).GetBytes(A_1));
        A_0.Write((byte) 0);
    }

    internal static void smethod_5(BinaryWriter A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            smethod_4(A_0, A_1);
        }
        else
        {
            A_0.Write(0);
        }
    }

    internal static void smethod_6(Class1089 A_0, Interface24 A_1)
    {
        MemoryStream output = new MemoryStream();
        A_1.imethod_0(new BinaryWriter(output));
        A_0[A_1.imethod_1()] = output;
    }

    internal static Guid smethod_7(string A_0)
    {
        object obj2 = hashtable_0[A_0];
        if (obj2 == null)
        {
            return Guid.Empty;
        }
        return new Guid((string) obj2);
    }

    internal static void smethod_8(Stream A_0, Stream A_1)
    {
        int num = 8;
        if (A_0 != null)
        {
            A_0.Position = 0L;
            Class404 class2 = new Class404(A_0);
            Class467 class3 = class2.method_6(null, BookmarkStart.b("䘭䐯䘱䐳వ᜷ᔹ伻崽⠿❁⥃❅㭇摉⍋㹍㕏㱑ⱓ㭕㑗㱙㍛ⱝൟ͡ၣᕥ䙧թṫ७彯ᵱታၵᅷ᥹᥻㩽ꆍꊏꊑ꒓ꂕ랗鍊솟횡춣즥욧\ud9a9\uc4ab잭삯솱鮳\ud9b5\udeb7\udcb9\ud5bb\uddbd\ua5bf蛁ꯃꗅ뷇Ꟊ꧋ꃍ꓏", num));
            StreamReader reader = new StreamReader(class3.method_4());
            string str = reader.ReadToEnd().Replace(BookmarkStart.b("堭夯䄱崳吵儷嘹唻䨽㤿罁晃⹅ⅇ⹉⡋⭍㹏灑", num), "");
            class3.method_5(new MemoryStream());
            StreamWriter writer = new StreamWriter(class3.method_4(), reader.CurrentEncoding);
            writer.Write(str);
            writer.Flush();
            class2.vmethod_0(A_1);
        }
    }

    internal static void smethod_9(Stream A_0)
    {
        if (A_0 != null)
        {
            A_0.Position = 0L;
            BinaryReader reader = new BinaryReader(A_0);
            while (A_0.Position < A_0.Length)
            {
                int num2 = reader.ReadInt16();
                int num = reader.ReadInt16();
                if (num2 == 0x3d)
                {
                    reader.ReadInt16();
                    reader.ReadInt16();
                    reader.ReadInt16();
                    reader.ReadInt16();
                    int num3 = Class336.smethod_5(reader.ReadByte(), 1, false);
                    A_0.Position -= 1L;
                    A_0.WriteByte((byte) num3);
                    return;
                }
                A_0.Position += num;
            }
        }
    }
}

