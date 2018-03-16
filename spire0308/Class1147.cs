using Spire.Compression.Zip;
using Spire.Doc;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security;
using System.Text;
using System.Xml;

internal class Class1147
{
    private Class771 class771_0 = new Class771();
    private Dictionary<string, Stream> dictionary_0 = new Dictionary<string, Stream>();
    private Dictionary<string, string> dictionary_1;
    private DocPicture docPicture_0;
    private Document document_0;
    private int int_0 = 0;
    private int int_1 = 1;
    private string string_0;
    private string string_1 = Guid.NewGuid().ToString();
    private string string_2;
    private string string_3;

    internal DocPicture method_0()
    {
        return this.docPicture_0;
    }

    internal void method_1(DocPicture A_0)
    {
        this.docPicture_0 = A_0;
    }

    private void method_10()
    {
        int num = 6;
        MemoryStream w = new MemoryStream();
        XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8);
        writer.WriteStartDocument();
        writer.WriteDocType(BookmarkStart.b("䈫䴭䠯", 6), BookmarkStart.b("īĭἯ簱紳攵眷ᔹጻ稽ᐿف摃⡅⭇㉉汋籍恏扑慓筕楗留獛᭝⹟", 6), BookmarkStart.b("䐫娭䐯䈱ำᤵ᜷䴹䬻䤽渿♁╃⽅㭇㍉手⅍≏㕑筓ⱕ歗捙摛桝佟偡呣噥嵧䕩ɫ൭࡯影䙳䙵䡷佹养佽깿", 6), null);
        writer.WriteStartElement(BookmarkStart.b("䈫䴭䠯", 6), BookmarkStart.b("䐫娭䐯䈱ำᤵ᜷䴹䬻䤽渿♁╃⽅㭇㍉手⅍≏㕑筓ⱕ歗捙摛桝佟偡呣噥嵧䕩ɫ൭࡯嵱", 6));
        writer.WriteAttributeString(BookmarkStart.b("娫䬭䈯䄱崳夵嘷", 6), BookmarkStart.b("ḫḭ/ܱᤳܵ", 6));
        writer.WriteStartElement(BookmarkStart.b("䐫䬭儯嘱", 6));
        writer.WriteStartElement(BookmarkStart.b("䄫䬭䐯匱", 6));
        writer.WriteAttributeString(BookmarkStart.b("䈫伭崯圱", 6), string.Format(BookmarkStart.b("圫ḭ䴯࠱伳ܵ䔷", 6), BookmarkStart.b("䠫娭刯", 6), BookmarkStart.b("夫䜭启", 6)));
        writer.WriteAttributeString(BookmarkStart.b("伫䄭帯䘱儳堵䰷", 6), this.string_1);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("䠫䄭匯昱崳䈵吷弹", 6));
        writer.WriteStartElement(BookmarkStart.b("堫䬭䠯䘱", 6));
        writer.WriteValue(this.string_2);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("䠫䄭匯猱䄳䈵倷唹主", 6));
        writer.WriteStartElement(BookmarkStart.b("堫䬭䠯䘱", 6));
        writer.WriteValue(this.string_3);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("䈫伭䘯缱唳䘵", 6));
        writer.WriteStartElement(BookmarkStart.b("䈫伭䘯戱嬳張嘷丹", 6));
        writer.WriteAttributeString(BookmarkStart.b("䔫䨭", 6), Path.GetFileNameWithoutExtension(this.string_0));
        writer.WriteAttributeString(BookmarkStart.b("尫䈭儯䬱笳䐵尷弹主", 6), this.int_1++.ToString());
        writer.WriteStartElement(BookmarkStart.b("䈫伭䘯縱唳吵崷嘹", 6));
        writer.WriteStartElement(BookmarkStart.b("堫䬭䠯䘱", 6));
        writer.WriteValue(this.string_2);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("伫䄭帯䘱儳堵䰷", 6));
        writer.WriteAttributeString(BookmarkStart.b("弫尭匯", 6), this.string_0);
        writer.WriteEndElement();
        writer.WriteEndElement();
        if ((this.dictionary_1 != null) && (this.dictionary_1.Count > 0))
        {
            int num4 = 0;
            foreach (string str in this.dictionary_1.Keys)
            {
                string[] strArray = str.Split(new char[] { ';' });
                num4 = int.Parse(strArray[0]);
                if (num4 < this.int_0)
                {
                    goto Label_0325;
                }
                if (num4 == this.int_0)
                {
                    writer.WriteEndElement();
                }
                while (num4 > ++this.int_0)
                {
                    this.method_12(this.int_0 + BookmarkStart.b("ᜫ", num) + strArray[1], "", writer);
                }
                this.method_12(str, this.dictionary_1[str], writer);
                goto Label_0352;
            Label_031F:
                writer.WriteEndElement();
            Label_0325:
                if (num4 <= this.int_0--)
                {
                    goto Label_031F;
                }
                this.method_12(str, this.dictionary_1[str], writer);
            Label_0352:
                this.int_0 = num4;
            }
            while (num4-- != 0)
            {
                writer.WriteEndElement();
            }
        }
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.Flush();
        this.class771_0.method_14(BookmarkStart.b("堫䄭匯ᰱ娳唵䀷", num), w, true, FileAttributes.Archive);
        this.method_11();
    }

    private void method_11()
    {
        int num = 15;
        MemoryStream w = new MemoryStream();
        XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8);
        writer.WriteStartDocument();
        writer.WriteDocType(BookmarkStart.b("崴䌶吸场", 15), BookmarkStart.b("ᠴᠶᘸ氺฼簾湀求ńፆൈ歊ᕌݎՐṒᥔ睖桘畚汜灞习♢⭤", 15), BookmarkStart.b("崴䌶䴸䬺ܼှ湀㑂㉄う杈㱊繌慎㹐⅒㉔硖൘ग़牜❞ॠᝢࡤ୦塨婪䉬⭮╰㝲婴ྲྀᅸེၼ፾낀늂ꮄﶈ", 15), null);
        writer.WriteStartElement(BookmarkStart.b("崴䌶吸场", 15), BookmarkStart.b("崴䌶䴸䬺ܼှ湀㑂㉄う杈㱊繌慎㹐⅒㉔硖桘扚摜晞习᭢൤፦Ѩݪ", 15));
        writer.WriteStartElement(BookmarkStart.b("崴制堸强", 15));
        writer.WriteRaw(BookmarkStart.b("ऴ娶尸伺尼Ἶ⥀㝂ㅄ㝆摈⹊㱌㩎㡐╒桔畖ᩘ㑚㍜⭞Ѡൢᅤ䩦㵨ቪᵬ੮印卲ᙴᡶ᝸ེ᡼ᅾ뺂Ꞅ麗ﮊﺖ늜즠힢좤쮦芨펪사쎮誰鎲횴\udfb6\ud8b8즺캼\udabe\ub5c0ﻂ냄돆꿈ﳒ", 15));
        writer.WriteRaw(string.Format(BookmarkStart.b("ऴ䌶倸伺儼娾罀㡂畄㩆畈摊㥌♎═㽒ご楖", 15), BookmarkStart.b("愴砶稸", 15)));
        writer.WriteRaw(BookmarkStart.b("ऴ䐶䴸䈺儼娾慀㝂㱄㝆ⱈ癊潌㭎㑐⭒⅔硖㩘⡚⹜絞彠形䩤ᑦᵨቪŬ੮佰", 15));
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("圴堶崸䈺", 15));
        writer.WriteRaw(BookmarkStart.b("ऴ䜶ᤸ堺儼帾㉀あ硄敆㵈≊㥌⍎㑐煒歔͖㡘㥚ㅜ㩞䅠ౢͤ䝦੨Ѫͬ᭮ᑰᵲŴѶ䕸呺ർ䅾", 15));
        if ((this.dictionary_1 != null) && (this.dictionary_1.Count > 0))
        {
            foreach (string str in this.dictionary_1.Keys)
            {
                string[] strArray = str.Split(new char[] { ';' });
                int.Parse(strArray[0]);
                writer.WriteStartElement(BookmarkStart.b("䔴", num));
                writer.WriteStartElement(BookmarkStart.b("吴", num));
                writer.WriteAttributeString(BookmarkStart.b("崴䔶尸崺", num), this.string_0 + BookmarkStart.b("ᘴ", num) + strArray[1]);
                writer.WriteValue(this.dictionary_1[str]);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
        }
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.Flush();
        this.class771_0.method_14(BookmarkStart.b("䄴堶娸ᔺ唼䬾ⱀ⽂", num), w, true, FileAttributes.Archive);
    }

    private void method_12(string A_0, string A_1, XmlWriter A_2)
    {
        int num = 7;
        string[] strArray = A_0.Split(new char[] { ';' });
        string str = string.Empty;
        if (string.IsNullOrEmpty(A_1))
        {
            str = string.Format(BookmarkStart.b("䄬䨮䜰嘲头䰶स䘺戼䐾灀㹂", num), strArray[0], BookmarkStart.b("堬䄮娰崲娴䀶圸眺堼䤾⑀⽂", num));
        }
        else
        {
            str = string.Format(BookmarkStart.b("䄬䨮䜰嘲头䰶स䘺戼䐾灀㹂", num), strArray[0], strArray[1]);
        }
        A_2.WriteStartElement(BookmarkStart.b("䌬丮䜰挲娴帶圸伺", num));
        A_2.WriteAttributeString(BookmarkStart.b("䐬䬮", num), str);
        A_2.WriteAttributeString(BookmarkStart.b("崬䌮倰䨲稴䔶崸帺似", num), this.int_1++.ToString());
        A_2.WriteStartElement(BookmarkStart.b("䌬丮䜰缲吴唶尸场", num));
        A_2.WriteStartElement(BookmarkStart.b("夬䨮䤰䜲", num));
        if (string.IsNullOrEmpty(A_1))
        {
            A_1 = BookmarkStart.b("ܬԮᬰ", num);
            this.int_1--;
        }
        A_2.WriteValue(A_1);
        A_2.WriteEndElement();
        A_2.WriteEndElement();
        A_2.WriteStartElement(BookmarkStart.b("丬䀮弰䜲倴夶䴸", num));
        A_2.WriteAttributeString(BookmarkStart.b("帬崮到", num), this.string_0 + BookmarkStart.b("ฬ", num) + strArray[1]);
        A_2.WriteEndElement();
    }

    private void method_13()
    {
        int num = 13;
        MemoryStream w = new MemoryStream();
        XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8);
        writer.WriteStartDocument();
        writer.WriteStartElement(BookmarkStart.b("䌲吴吶券娺娼娾", 13), BookmarkStart.b("嬲䄴䌶䤸ĺሼှ㙀㑂㉄楆⁈⽊㵌⥎罐㱒❔ざ癘楚浜潞噠䱢੤ᝦཨ", 13));
        writer.WriteAttributeString(BookmarkStart.b("䔲倴䔶䨸刺刼儾", 13), BookmarkStart.b("Ĳ᬴ܶ", 13));
        writer.WriteAttributeString(BookmarkStart.b("䘲嬴帶䠸为堼ሾ⡀❂⁄⥆㵈≊⭌♎㑐⅒", 13), BookmarkStart.b("吲䀴帶崸", 13));
        writer.WriteAttributeString(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("䬲䘴帶", 13), null, BookmarkStart.b("嬲䄴䌶䤸ĺሼှ㙀㑂㉄楆㹈硊捌⁎⍐㑒穔敖楘歚汜灞㥠⹢⥤㑦੨ͪ࡬ɮၰ干ᱴ᥶੸ེᱼᅾ", 13));
        writer.WriteStartElement(BookmarkStart.b("帲倴䌶堸强尼䬾⁀", 13));
        writer.WriteAttributeString(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("圲嘴", 13), null, BookmarkStart.b("嬲䄴䌶䤸ĺሼှㅀ㙂㝄⭆杈⑊㽌⡎繐㝒㙔硖㱘㝚㡜㉞Ѡൢᅤᑦ䙨婪䍬幮幰", 13));
        writer.WriteAttributeString(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("尲䔴儶", 13), null, BookmarkStart.b("嬲䄴䌶䤸ĺሼှ㙀㑂㉄楆⁈⽊㵌⥎罐㱒❔ざ癘楚浜潞噠䱢੤ᝦཨ", 13));
        writer.WriteStartElement(string.Format(BookmarkStart.b("䠲Դ䨶̸䀺఼䈾", 13), BookmarkStart.b("圲嘴", 13), BookmarkStart.b("䜲尴䌶唸帺", 13)));
        writer.WriteValue(this.string_2);
        writer.WriteEndElement();
        writer.WriteStartElement(string.Format(BookmarkStart.b("䠲Դ䨶̸䀺఼䈾", 13), BookmarkStart.b("圲嘴", 13), BookmarkStart.b("倲䜴制堸伺刼䴾", 13)));
        this.string_3 = string.IsNullOrEmpty(this.document_0.BuiltinDocumentProperties.Author) ? BookmarkStart.b("爲儴娶倸唺吼䰾㕀ㅂ⑄㍆♈㥊", num) : this.document_0.BuiltinDocumentProperties.Author;
        writer.WriteValue(this.string_3);
        writer.WriteEndElement();
        writer.WriteStartElement(string.Format(BookmarkStart.b("䠲Դ䨶̸䀺఼䈾", num), BookmarkStart.b("圲嘴", num), BookmarkStart.b("娲儴制圸伺吼夾⡀♂㝄", num)));
        writer.WriteAttributeString(BookmarkStart.b("娲儴", num), BookmarkStart.b("吲䀴帶崸", num));
        writer.WriteValue(this.string_1);
        writer.WriteEndElement();
        writer.WriteStartElement(string.Format(BookmarkStart.b("䠲Դ䨶̸䀺఼䈾", num), BookmarkStart.b("圲嘴", num), BookmarkStart.b("弲吴夶常为尼堾⑀", num)));
        writer.WriteAttributeString(BookmarkStart.b("䬲䘴帶", num), BookmarkStart.b("䜲䰴䜶尸", num), null, string.Format(BookmarkStart.b("䠲Դ䨶̸䀺఼䈾", num), BookmarkStart.b("圲嘴䌶尸䤺值䰾", num), BookmarkStart.b("愲猴琶ਸ଺଼ा", num)));
        writer.WriteValue(BookmarkStart.b("嘲嬴ᨶ永栺", num));
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("帲吴夶倸崺堼䰾㕀", num));
        writer.WriteStartElement(BookmarkStart.b("娲䄴制吸", num));
        writer.WriteAttributeString(BookmarkStart.b("娲儴", num), BookmarkStart.b("崲嘴伶", num));
        writer.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), BookmarkStart.b("䜲娴吶᜸唺帼䜾", num));
        writer.WriteAttributeString(BookmarkStart.b("帲倴匶倸娺ြ䬾㡀㍂⁄", num), BookmarkStart.b("刲䔴䜶唸刺帼帾㕀⩂⩄⥆晈㍊恌⭎═ㅒ㭔㑖⅘灚╜㉞ൠ", num));
        writer.WriteEndElement();
        if (this.method_0() != null)
        {
            writer.WriteStartElement(BookmarkStart.b("娲䄴制吸", num));
            writer.WriteAttributeString(BookmarkStart.b("娲儴", num), BookmarkStart.b("倲娴䄶尸䤺ጼ圾㕀⹂⥄", num));
            writer.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), BookmarkStart.b("倲娴䄶尸䤺ጼ圾㕀⹂⥄", num));
            writer.WriteAttributeString(BookmarkStart.b("帲倴匶倸娺ြ䬾㡀㍂⁄", num), BookmarkStart.b("刲䔴䜶唸刺帼帾㕀⩂⩄⥆晈㍊╌㭎㱐㽒織⽖㑘㝚", num));
            writer.WriteEndElement();
        }
        writer.WriteStartElement(BookmarkStart.b("娲䄴制吸", num));
        writer.WriteAttributeString(BookmarkStart.b("娲儴", num), Path.GetFileNameWithoutExtension(this.string_0).Replace(' ', '_'));
        writer.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), this.string_0);
        writer.WriteAttributeString(BookmarkStart.b("帲倴匶倸娺ြ䬾㡀㍂⁄", num), BookmarkStart.b("刲䔴䜶唸刺帼帾㕀⩂⩄⥆晈㍊╌㭎㱐㽒織⽖㑘㝚", num));
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("娲䄴制吸", num));
        writer.WriteAttributeString(BookmarkStart.b("娲儴", num), BookmarkStart.b("䜲娴吶᜸区䤼刾ⵀ", num));
        writer.WriteAttributeString(BookmarkStart.b("嬲䜴制弸", num), BookmarkStart.b("䜲娴吶᜸区䤼刾ⵀ", num));
        writer.WriteAttributeString(BookmarkStart.b("帲倴匶倸娺ြ䬾㡀㍂⁄", num), BookmarkStart.b("刲䔴䜶唸刺帼帾㕀⩂⩄⥆晈㍊╌㭎㱐㽒織⽖㑘㝚", num));
        writer.WriteEndElement();
        this.method_14(writer);
        writer.WriteEndElement();
        writer.WriteStartElement(BookmarkStart.b("䀲䔴帶圸帺", num));
        writer.WriteAttributeString(Path.GetFileNameWithoutExtension(BookmarkStart.b("䜲娴吶᜸唺帼䜾", num)), BookmarkStart.b("崲嘴伶", num));
        writer.WriteStartElement(BookmarkStart.b("娲䄴制吸䤺堼夾", num));
        writer.WriteAttributeString(BookmarkStart.b("娲儴䔶尸崺", num), Path.GetFileNameWithoutExtension(this.string_0).Replace(' ', '_'));
        writer.WriteEndElement();
        foreach (string str in this.dictionary_0.Keys)
        {
            if (Path.GetExtension(str) == BookmarkStart.b("ᴲ崴䌶吸场", num))
            {
                writer.WriteStartElement(BookmarkStart.b("娲䄴制吸䤺堼夾", num));
                writer.WriteAttributeString(BookmarkStart.b("娲儴䔶尸崺", num), Path.GetFileNameWithoutExtension(str));
                writer.WriteEndElement();
            }
        }
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.Flush();
        this.class771_0.method_14(BookmarkStart.b("倲娴夶䴸帺匼䬾潀ⱂ㕄ⅆ", num), w, true, FileAttributes.Archive);
    }

    private void method_14(XmlTextWriter A_0)
    {
        int num = 12;
        if ((this.dictionary_0 != null) && (this.dictionary_0.Count > 0))
        {
            foreach (string str in this.dictionary_0.Keys)
            {
                A_0.WriteStartElement(BookmarkStart.b("嬱䀳匵唷", num));
                A_0.WriteAttributeString(BookmarkStart.b("嬱倳", num), Path.GetFileNameWithoutExtension(str));
                A_0.WriteAttributeString(BookmarkStart.b("娱䘳匵帷", num), str.Replace('\\', '/'));
                A_0.WriteAttributeString(BookmarkStart.b("弱儳刵儷嬹ᄻ䨽㤿㉁⅃", num), this.method_20(Path.GetExtension(str)));
                A_0.WriteEndElement();
            }
        }
    }

    private void method_15()
    {
        int num = 15;
        Class926 class2 = new Class926();
        class2.method_6(true);
        class2.method_8(true);
        class2.method_10(true);
        this.document_0.HtmlExportOptions.CssStyleSheetType = CssStyleSheetType.External;
        this.document_0.HtmlExportOptions.CssStyleSheetFileName = BookmarkStart.b("䘴䌶䀸场堼䰾潀⁂㙄㑆", 15);
        this.document_0.HtmlExportOptions.IsTextInputFormFieldAsText = true;
        if (this.document_0.HtmlExportOptions.EPubExportFont)
        {
            try
            {
                this.method_17();
            }
            catch (SecurityException)
            {
                throw new NotSupportedException(BookmarkStart.b("瀴娶嬸帺夼嬾⡀ⵂ≄杆⽈⑊⍌㭎煐㕒㱔㭖㱘⡚絜㙞በ䍢୤ࡦᵨ䭪ṬᩮŰͲᩴն൸Ṻ᥼彾ꖄ搜ﲐ뎒", num));
            }
        }
        this.method_18();
        this.string_0 = this.string_0 + BookmarkStart.b("᬴弶䴸嘺儼", num);
        MemoryStream stream2 = new MemoryStream();
        class2.method_16(this.document_0, stream2, true);
        stream2.Flush();
        this.method_16();
        this.class771_0.method_14(this.string_0, stream2, true, FileAttributes.Archive);
        if (class2.method_11() != null)
        {
            this.dictionary_0.Add(this.document_0.HtmlExportOptions.CssStyleSheetFileName, class2.method_11());
        }
        if ((class2.method_12() != null) && (class2.method_12().Count > 0))
        {
            foreach (string str2 in class2.method_12().Keys)
            {
                this.dictionary_0.Add(str2, class2.method_12()[str2]);
            }
        }
        if (this.method_0() != null)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(this.method_0().ImageBytes, 0, this.method_0().ImageBytes.Length);
            this.dictionary_0.Add(BookmarkStart.b("尴娶堸尺堼䰾湀⁂⩄ㅆⱈ㥊捌㽎㽐㑒", num), stream);
        }
        foreach (string str in this.dictionary_0.Keys)
        {
            this.class771_0.method_14(str, this.dictionary_0[str], true, FileAttributes.Archive);
        }
        if ((class2.method_13() != null) && (class2.method_13().Count > 0))
        {
            this.dictionary_1 = class2.method_13();
        }
    }

    private void method_16()
    {
        int num = 3;
        if (this.method_0() != null)
        {
            MemoryStream w = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteDocType(BookmarkStart.b("䄨弪䀬䌮", num), BookmarkStart.b("ШЪȬ砮Ȱ瀲ᨴᠶ紸漺礼Ἶ᥀ୂᅄ੆Ո歊籌慎恐籒穔ቖ᝘", num), BookmarkStart.b("䄨弪夬弮ରᰲᨴ䀶丸䰺ጼ䠾牀浂⩄㕆⹈摊᥌ᵎ繐⭒㵔⍖㑘㝚汜湞习❢ㅤ⍦䙨፪լ᭮ᱰὲ䑴䙶坸ὺॼ᭾", num), null);
            writer.WriteStartElement(BookmarkStart.b("䄨弪䀬䌮", num), BookmarkStart.b("䄨弪夬弮ରᰲᨴ䀶丸䰺ጼ䠾牀浂⩄㕆⹈摊籌癎桐橒穔⽖ㅘ⽚ぜ㍞", num));
            writer.WriteStartElement(BookmarkStart.b("䄨个䰬䬮", num));
            writer.WriteRaw(BookmarkStart.b("ᔨ䘪䠬嬮倰ጲ崴䌶䴸䬺ြ娾぀㙂ⱄㅆ瑈楊์⁎㽐❒ご㥖ⵘ癚ड़♞ᅠ٢䝤䝦੨Ѫͬ᭮ᑰᵲŴ䩶學᩺ർཾﶈ뺐ﶔ뚜철쾢麤螦쪨쎪첬\uddae\uc2b0횲솴誶첸쾺\udbbc\u92be燎", num));
            writer.WriteRaw(string.Format(BookmarkStart.b("ᔨ弪䐬嬮崰嘲଴䰶स䘺ļှ㕀⩂ㅄ⭆ⱈ畊", num), BookmarkStart.b("樨䐪嬬䨮䌰", num)));
            writer.WriteRaw(BookmarkStart.b("ᔨ堪夬嘮崰嘲ᔴ䌶䀸䬺堼Ⱦ捀㝂⁄㽆㵈摊⹌㱎≐煒歔歖癘⡚⥜♞ൠ٢孤", num));
            writer.WriteEndElement();
            writer.WriteStartElement(BookmarkStart.b("䬨䐪䤬嘮", num));
            writer.WriteStartElement(BookmarkStart.b("夨", num));
            writer.WriteRaw(string.Concat(new object[] { BookmarkStart.b("ᔨ䈪䀬䠮ᄰ嬲倴帶常区䤼Ⱦ捀", num), this.method_0().Height * 1.33, BookmarkStart.b("ନପ娬䘮唰䜲崴ਸ਼ᬸ", num), this.method_0().Width * 1.33, BookmarkStart.b("ନପ帬崮到า᜴ᤶ᜸ᐺ琼刾⁀⑂⁄㑆晈⡊≌㥎㑐⅒答❖㝘㱚罜罞习嵢", num) }));
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Flush();
            this.class771_0.method_14(BookmarkStart.b("䨨䐪嬬䨮䌰ᴲ崴䌶吸场", num), w, true, FileAttributes.Archive);
        }
    }

    private void method_17()
    {
        int num = 7;
        List<Font> usedFontNames = this.document_0.UsedFontNames;
        SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
        foreach (Font font in usedFontNames)
        {
            if (!(font.Name == BookmarkStart.b("礬䘮尰嘲䘴᜶眸帺䨼Ἶፀⱂ⡄♆❈", num)))
            {
                bool bold = font.Bold;
                bool italic = font.Italic;
                string str = (bold ? BookmarkStart.b("伬", num) : "") + (italic ? BookmarkStart.b("䰬", num) : "");
                string key = font.Name.ToLower().Replace(BookmarkStart.b("ബ", num), string.Empty) + str + BookmarkStart.b("̬嬮䔰唲", num);
                if (!this.dictionary_0.ContainsKey(key))
                {
                    IntPtr ptr = Class1102.CreateDC(BookmarkStart.b("椬昮戰挲礴瘶怸", num), null, null, IntPtr.Zero);
                    IntPtr ptr2 = font.ToHfont();
                    IntPtr ptr3 = Class1102.SelectObject(ptr, ptr2);
                    uint num2 = Class1102.GetFontData(ptr, 0, 0, null, 0);
                    byte[] buffer = new byte[num2];
                    num2 = Class1102.GetFontData(ptr, 0, 0, buffer, num2);
                    Class1102.SelectObject(ptr, ptr3);
                    Class1102.DeleteObject(ptr2);
                    Class1102.DeleteDC(ptr);
                    MemoryStream stream = new MemoryStream(buffer, 0, buffer.Length, false);
                    this.dictionary_0.Add(key, stream);
                    string str3 = (italic ? BookmarkStart.b("䬬䀮弰䜲ᠴ䐶䴸䈺儼娾筀⩂ㅄ♆╈≊⹌瑎煐", num) : "") + (bold ? BookmarkStart.b("䬬䀮弰䜲ᠴ䀶尸刺娼圾㕀祂❄⡆╈⽊癌潎", num) : "");
                    dictionary.Add(key, BookmarkStart.b("洬䤮帰崲䄴ᨶ弸娺帼娾慀㡂敄ⅆ♈╊㥌扎㝐㉒㡔㹖㕘≚杜硞", num) + font.Name + BookmarkStart.b("ਬᐮᄰ", num) + str3 + BookmarkStart.b("帬崮到ल䀴䔶唸ጺᨼ", num) + key + BookmarkStart.b("ਬخᄰ串", num));
                }
            }
        }
        if (dictionary.Count > 0)
        {
            this.document_0.HtmlExportOptions.FontFiles = new string[dictionary.Count];
            dictionary.Values.CopyTo(this.document_0.HtmlExportOptions.FontFiles, 0);
        }
    }

    private void method_18()
    {
        int num = 3;
        string str = string.Empty;
        this.string_2 = string.IsNullOrEmpty(this.document_0.BuiltinDocumentProperties.Title) ? BookmarkStart.b("尨䔪夬䘮䔰弲倴匶", num) : this.document_0.BuiltinDocumentProperties.Title;
        this.string_0 = string.IsNullOrEmpty(this.string_0) ? this.string_2 : this.string_0;
        if (this.string_0 != BookmarkStart.b("尨䔪夬䘮䔰弲倴匶", num))
        {
            Encoding aSCII = Encoding.ASCII;
            byte[] bytes = aSCII.GetBytes(this.string_0);
            this.string_0 = aSCII.GetString(bytes);
            str = this.string_0.Trim(new char[] { '?', ' ' }).Replace(BookmarkStart.b("ᘨ", num), string.Empty);
            if (str == string.Empty)
            {
                this.string_0 = BookmarkStart.b("尨䔪夬䘮䔰弲倴匶", num);
            }
            else
            {
                this.string_0 = str;
                str = string.Empty;
                foreach (char ch in this.string_0.ToCharArray())
                {
                    if ((char.IsLetterOrDigit(ch) || char.IsWhiteSpace(ch)) || (((ch == '_') || (ch == '-')) || (ch == '&')))
                    {
                        str = str + ch;
                    }
                }
                this.string_0 = str;
            }
        }
    }

    private void method_19()
    {
        Class814 class2 = new Class814(this.class771_0, BookmarkStart.b("尰娲場制䴸䈺䴼娾", 11), null, true, FileAttributes.Normal);
        class2.method_3(CompressionMethod.Stored);
        this.class771_0.method_16(class2);
        this.class771_0.method_22(BookmarkStart.b("尰娲場制䴸䈺䴼娾", 11), Encoding.Default.GetBytes(BookmarkStart.b("倰䌲䔴嬶倸堺尼䬾⡀ⱂ⭄框ⱈ㭊㡌ⵎ穐⥒㱔❖", 11)));
    }

    internal string method_2()
    {
        return this.string_0;
    }

    private string method_20(string A_0)
    {
        int num = 4;
        string str = string.Empty;
        string str2 = A_0;
        if (str2 == null)
        {
            return str;
        }
        if (str2 != BookmarkStart.b("Щ尫䀭圯", num))
        {
            if ((str2 != BookmarkStart.b("Щ䘫席唯唱", num)) && (str2 != BookmarkStart.b("Щ䘫席圯", num)))
            {
                if (!(str2 == BookmarkStart.b("Щ伫崭䌯", num)))
                {
                    if (str2 == BookmarkStart.b("Щ堫娭嘯", num))
                    {
                        str = BookmarkStart.b("䬩尫席尯嬱圳圵䰷匹医倽漿ⵁ❃㉅ⵇ㹉態㵍⑏⁑ㅓ㝕㕗", num);
                    }
                    return str;
                }
                return BookmarkStart.b("帩䤫嘭䐯ᴱ圳䔵䬷", num);
            }
            return BookmarkStart.b("䌩䄫伭圯圱ᬳ尵䠷弹嬻", num);
        }
        return BookmarkStart.b("䌩䄫伭圯圱ᬳ䘵嘷崹", num);
    }

    internal void method_3(string A_0)
    {
        this.string_0 = A_0;
    }

    public void method_4(string A_0, Document A_1)
    {
        this.document_0 = A_1;
        this.method_6();
        this.method_7(A_0);
    }

    public void method_5(Stream A_0, Document A_1)
    {
        this.document_0 = A_1;
        this.method_6();
        this.method_8(A_0);
    }

    private void method_6()
    {
        this.method_19();
        this.method_15();
        this.method_13();
        this.method_10();
        this.method_9();
    }

    private void method_7(string A_0)
    {
        this.class771_0.method_23(A_0);
        this.class771_0.method_28();
        this.class771_0.System.IDisposable.Dispose();
    }

    private void method_8(Stream A_0)
    {
        this.class771_0.method_25(A_0, false);
        this.class771_0.method_28();
        this.class771_0.System.IDisposable.Dispose();
    }

    private void method_9()
    {
        MemoryStream w = new MemoryStream();
        XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8);
        writer.WriteStartDocument();
        writer.WriteStartElement(BookmarkStart.b("匯崱娳䈵夷匹刻嬽㈿", 10), BookmarkStart.b("䔯䀱娳వ圷嬹伻圽㌿硁⩃❅╇⽉㽋瑍⑏ㅑ湓㥕⡗㽙㉛㩝ཟšᅣ୥൧ѩᡫ呭࡯άᡳᡵ୷䁹ύᅽﺋ", 10));
        writer.WriteAttributeString(BookmarkStart.b("䘯圱䘳䔵儷唹刻", 10), BookmarkStart.b("įᰱг", 10));
        writer.WriteStartElement(BookmarkStart.b("䈯崱嬳䈵帷匹倻嬽㌿", 10));
        writer.WriteStartElement(BookmarkStart.b("䈯崱嬳䈵帷匹倻嬽", 10));
        writer.WriteAttributeString(BookmarkStart.b("嘯䜱堳娵ᔷ䨹崻䨽⠿", 10), BookmarkStart.b("匯崱娳䈵崷吹䠻ွ⼿㉁≃", 10));
        writer.WriteAttributeString(BookmarkStart.b("崯圱倳張夷᜹䠻䜽〿❁", 10), BookmarkStart.b("儯䈱䐳娵儷夹崻䨽⤿ⵁ⩃楅❇⽉⹋㹍⍏网⑓㝕㭗ㅙ㵛㥝՟䥡ᱣ୥ѧ", 10));
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.Flush();
        this.class771_0.method_14(BookmarkStart.b("累眱怳眵ᔷ猹爻砽᰿⅁⭃⡅㱇⭉╋⁍㕏⁑穓⹕㕗㙙", 10), w, true, FileAttributes.Archive);
    }
}

