using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

internal class Class585
{
    private Class587 class587_0 = new Class587();
    private Hashtable hashtable_0 = new Hashtable();
    private Hashtable hashtable_1 = new Hashtable();
    private static Hashtable hashtable_2 = new Hashtable();
    private int int_0 = 2;
    private const string string_0 = "Spire.Doc.Resources.docxResources.dls-to-document-docx-converter.xslt";
    private const string string_1 = "Spire.Doc.Resources.docxResources.dls-to-styles-docx-converter.xslt";
    private const string string_10 = "Spire.Doc.Resources.docxResources.dls-to-core-props-docx-converter.xslt";
    private const string string_11 = "Spire.Doc.Resources.docxResources.dls-to-custom-props-docx-converter.xslt";
    private const string string_12 = "Spire.Doc.Resources.docxResources.dls-to-font-table-docx-converter.xslt";
    private const string string_13 = "{0}/{1}";
    private const string string_14 = "Symbol";
    private const string string_15 = "Field";
    private const string string_16 = "TOC";
    private const string string_17 = "TextFormField";
    private const string string_18 = "CheckBoxFormField";
    private const string string_19 = "DropDownFormField";
    private const string string_2 = "Spire.Doc.Resources.docxResources.dls-to-settings-docx-converter.xslt";
    private const string string_20 = "BookmarkStart";
    private const string string_21 = "BookmarkEnd";
    private const string string_22 = "Footnote";
    private const string string_23 = "Comment";
    private const string string_24 = "Picture";
    private const string string_25 = "TextBox";
    private const string string_26 = "CommentAnchorEnd";
    private const string string_27 = "CommentAnchorStart";
    private const string string_28 = "Table";
    private const string string_29 = "Paragraph";
    private const string string_3 = "Spire.Doc.Resources.docxResources.dls-to-web-settings-docx-converter.xslt";
    private const string string_30 = "Tab";
    private const string string_31 = "BookmarkName";
    private const string string_32 = "CharCode";
    private const string string_33 = "sections/section";
    private const string string_34 = "liststyles/style";
    private const string string_35 = "styles/style";
    private const string string_36 = "body/paragraphs/item";
    private const string string_37 = "headers-footers/";
    private const string string_38 = "paragraphs/item";
    private const string string_39 = "items/item";
    private const string string_4 = "Spire.Doc.Resources.docxResources.dls-to-numbering-docx-converter.xslt";
    private const string string_40 = "paragraphs/item";
    private const string string_41 = "rows/row";
    private const string string_42 = "cells/cell";
    private const string string_43 = "rows/row";
    private const string string_44 = "rows/row/cells/cell/paragraphs/item";
    private const string string_45 = "rows/row/table-format";
    private const string string_5 = "Spire.Doc.Resources.docxResources.dls-to-endnotes-docx-converter.xslt";
    private const string string_6 = "Spire.Doc.Resources.docxResources.dls-to-footnotes-docx-converter.xslt";
    private const string string_7 = "Spire.Doc.Resources.docxResources.dls-to-header-footer-docx-converter.xslt";
    private const string string_8 = "Spire.Doc.Resources.docxResources.dls-to-comments-docx-converter.xslt";
    private const string string_9 = "Spire.Doc.Resources.docxResources.dls-to-app-props-docx-converter.xslt";
    private XmlDocument xmlDocument_0 = new XmlDocument();
    private XmlDocument xmlDocument_1 = new XmlDocument();
    private XmlDocument xmlDocument_10;
    private XmlDocument xmlDocument_11 = new XmlDocument();
    private XmlDocument xmlDocument_2 = new XmlDocument();
    private XmlDocument xmlDocument_3 = new XmlDocument();
    private XmlDocument xmlDocument_4 = new XmlDocument();
    private XmlDocument xmlDocument_5;
    private XmlDocument xmlDocument_6;
    private XmlDocument xmlDocument_7;
    private XmlDocument xmlDocument_8;
    private XmlDocument xmlDocument_9;

    internal Class585()
    {
        this.xmlDocument_11.PreserveWhitespace = true;
    }

    internal XmlDocument method_0()
    {
        return this.xmlDocument_0;
    }

    internal XmlDocument method_1()
    {
        return this.xmlDocument_1;
    }

    internal XmlDocument method_10()
    {
        return this.xmlDocument_9;
    }

    internal Hashtable method_11()
    {
        return this.hashtable_1;
    }

    internal XmlDocument method_12()
    {
        return this.xmlDocument_10;
    }

    internal void method_13(Document A_0)
    {
        int num = 14;
        MemoryStream stream = new MemoryStream();
        A_0.method_162(stream);
        stream.Position = 0L;
        this.xmlDocument_11.Load(stream);
        this.method_19();
        this.method_15(this.xmlDocument_0, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃ曆ﲑ뮕ﲗﾛ趟송쮣좥\udea7\ucfa9\udeab\udaad햯삱骳캵쮷횹좻", 14));
        this.method_15(this.xmlDocument_1, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃﲇ뾑秊ﮗ놛ﶝ쾟첡튣쎥\udaa7\udea9즫\udcad\u9eaf쪱잳\udab5\uccb7", 14));
        this.method_15(this.xmlDocument_2, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃﺉﺏ뮕ﲗﾛ趟송쮣좥\udea7\ucfa9\udeab\udaad햯삱骳캵쮷횹좻", 14));
        this.method_15(this.xmlDocument_3, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃ憎ꆋﺍ﶑떗ﺙﶝ\ud89f\u8fa1잣즥욧\udca9\uc9ab\udcad\uc4afힱ욳颵삷즹킻쪽", 14));
        this.method_15(this.xmlDocument_4, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃꎍﮓ랙쎟\udaa1\u89a3얥잧쒩\udaab\ucbad슯욱톳쒵隷승쾻튽뒿", 14));
        XmlNodeList list = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("倳匵䬷夹夻倽␿⍁⩃㉅片灉╋㩍㕏㽑ནᙕⱗ⍙ⱛ㭝䁟彡䑣䅥⹧թͫᩭṯᵱs፵彷婹ᵻၽꊁﲇꊉ겋캍\ud98f\ue191톓ﲗ얟킣튥\udaa7\u8aa9薫", 14));
        XmlNodeList list2 = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("倳匵䬷夹夻倽␿⍁⩃㉅片灉╋㩍㕏㽑ནᙕⱗ⍙ⱛ㭝䁟彡䑣䅥⹧թͫᩭṯᵱs፵彷婹ᵻၽꊁ쒃쾅ﮇ쾉ﺏ﶑\ud997\uee99肟ﾡ", 14));
        XmlNodeList list3 = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("倳匵䬷夹夻倽␿⍁⩃㉅片灉╋㩍㕏㽑ནᙕⱗ⍙ⱛ㭝䁟彡䑣䅥⭧թūͭᕯᱱs兵╷", 14));
        XmlNode node = this.xmlDocument_11.DocumentElement.SelectSingleNode(BookmarkStart.b("堳張䬷丹伻䨽㤿⹁⅃㕅", 14));
        XmlNodeList list4 = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("圳䌵䬷丹医匽洿㉁㙃⥅㡇⽉㹋㩍㥏㝑❓祕⡗⡙㍛⹝՟ၡၣὥ", 14));
        XmlNodeList list5 = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("倳匵䬷夹夻倽␿⍁⩃㉅片灉╋㩍㕏㽑ནᙕⱗ⍙ⱛ㭝䁟彡䑣䅥㭧፩ū౭Ὧṱ即⭵", 14));
        if (list.Count > 0)
        {
            this.xmlDocument_6 = new XmlDocument();
            this.method_15(this.xmlDocument_6, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃﾏ떗ﺙﶝ\ud89f\u8fa1잣즥욧\udca9\uc9ab\udcad\uc4afힱ욳颵삷즹킻쪽", num));
        }
        if (list2.Count > 0)
        {
            this.xmlDocument_7 = new XmlDocument();
            this.method_15(this.xmlDocument_7, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃ뮕ﲗﾛ趟송쮣좥\udea7\ucfa9\udeab\udaad햯삱骳캵쮷횹좻", num));
        }
        if (list3.Count > 0)
        {
            this.xmlDocument_8 = new XmlDocument();
            this.method_15(this.xmlDocument_8, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃﺏ뮕ﲗﾛ趟송쮣좥\udea7\ucfa9\udeab\udaad햯삱骳캵쮷횹좻", num));
        }
        if (node != null)
        {
            this.xmlDocument_5 = new XmlDocument();
            this.method_15(this.xmlDocument_5, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃﶇﮑ望떗ﺙﶝ\ud89f\u8fa1잣즥욧\udca9\uc9ab\udcad\uc4afힱ욳颵삷즹킻쪽", num));
        }
        if (list4.Count > 0)
        {
            this.xmlDocument_9 = new XmlDocument();
            this.method_15(this.xmlDocument_9, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃﶇ黎ﶏ뾑뎝쒟춡잣\udea5\u85a7즩쎫삭욯ힱ욳습\uddb7\uc8b9銻욽뎿껁냃", num));
        }
        if (list5.Count > 0)
        {
            this.xmlDocument_10 = new XmlDocument();
            this.method_15(this.xmlDocument_10, BookmarkStart.b("朳䘵儷䠹夻ွпⵁ❃桅ᩇ⽉㽋⅍╏⁑㝓㍕⭗瑙㡛ㅝ͟ᩡ㙣ͥ᭧թᥫᱭ፯᝱ݳ塵ᱷᙹཻ卽ꦃꎍ歹ﶗ랙쎟\udaa1\u89a3얥잧쒩\udaab\ucbad슯욱톳쒵隷승쾻튽뒿", num));
        }
        this.method_17();
    }

    private XmlReader method_14(string A_0)
    {
        return new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(A_0));
    }

    private void method_15(XmlDocument A_0, string A_1)
    {
        this.method_16(this.xmlDocument_11, A_0, A_1);
    }

    private void method_16(XmlDocument A_0, XmlDocument A_1, string A_2)
    {
        XslCompiledTransform transform;
        MemoryStream inStream = new MemoryStream();
        if (hashtable_2.Contains(A_2))
        {
            transform = (XslCompiledTransform) hashtable_2[A_2];
        }
        else
        {
            transform = new XslCompiledTransform();
            transform.Load(this.method_14(A_2), XsltSettings.Default, new XmlUrlResolver());
            hashtable_2.Add(A_2, transform);
        }
        transform.Transform((IXPathNavigable) A_0, null, (Stream) inStream);
        inStream.Position = 0L;
        A_1.Load(inStream);
    }

    private void method_17()
    {
        int num = 0x12;
        foreach (XmlNode node in this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("䬷弹弻䨽⤿ⵁ⩃㕅杇㥉⥋ⵍ⑏㭑㭓㡕", 0x12)))
        {
            this.method_18(node, BookmarkStart.b("帷匹主䴽㐿潁㑃❅⽇⽉態♍㕏㍑こ㍕⩗", num), BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝џൡݣṥ㩧ཀྵὫŭկqᝳ፵୷呹᡻ች꾁ꖇ뮕ﺗ얟킡覣슥잧즩풫莭펯\uddb1\udab3삵\uddb7\uc8b9좻\udbbd\ub2bf볃뗅꓇뻉", num));
            this.method_18(node, BookmarkStart.b("帷匹主䴽㐿潁㑃❅⽇⽉態⡍㽏㵑⁓㍕⩗", num), BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝џൡݣṥ㩧ཀྵὫŭկqᝳ፵୷呹᡻ች꾁ꖇ뮕ﺗ얟킡覣슥잧즩풫莭펯\uddb1\udab3삵\uddb7\uc8b9좻\udbbd\ub2bf볃뗅꓇뻉", num));
            this.method_18(node, BookmarkStart.b("圷帹堻ጽ⠿❁╃≅ⵇ㡉", num), BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝џൡݣṥ㩧ཀྵὫŭկqᝳ፵୷呹᡻ች꾁ꖇ뮕ﺗ얟킡覣슥잧즩풫莭펯\uddb1\udab3삵\uddb7\uc8b9좻\udbbd\ub2bf볃뗅꓇뻉", num));
            this.method_18(node, BookmarkStart.b("圷帹堻ጽ☿ⵁ⭃㉅ⵇ㡉", num), BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝џൡݣṥ㩧ཀྵὫŭկqᝳ፵୷呹᡻ች꾁ꖇ뮕ﺗ얟킡覣슥잧즩풫莭펯\uddb1\udab3삵\uddb7\uc8b9좻\udbbd\ub2bf볃뗅꓇뻉", num));
            this.method_18(node, BookmarkStart.b("崷䰹夻倽洿⩁⅃❅ⱇ⽉㹋", num), BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝џൡݣṥ㩧ཀྵὫŭկqᝳ፵୷呹᡻ች꾁ꖇ뮕ﺗ얟킡覣슥잧즩풫莭펯\uddb1\udab3삵\uddb7\uc8b9좻\udbbd\ub2bf볃뗅꓇뻉", num));
            this.method_18(node, BookmarkStart.b("崷䰹夻倽洿⑁⭃⥅㱇⽉㹋", num), BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝џൡݣṥ㩧ཀྵὫŭկqᝳ፵୷呹᡻ች꾁ꖇ뮕ﺗ얟킡覣슥잧즩풫莭펯\uddb1\udab3삵\uddb7\uc8b9좻\udbbd\ub2bf볃뗅꓇뻉", num));
        }
    }

    private void method_18(XmlNode A_0, string A_1, string A_2)
    {
        int num = 3;
        XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("䄨个䰬䬮吰䄲䘴ᨶ弸吺刼䬾⑀ㅂ㙄框", 3) + A_1);
        if (node.ChildNodes.Count > 0)
        {
            XmlDocument document = new XmlDocument {
                PreserveWhitespace = true
            };
            document.LoadXml(node.OuterXml);
            XmlDocument document2 = new XmlDocument();
            this.method_16(document, document2, A_2);
            this.hashtable_0.Add(node.Attributes[BookmarkStart.b("䀨伪", num)].Value, document2);
        }
    }

    private void method_19()
    {
        this.method_22();
        this.method_21();
        this.method_24();
        this.method_23();
        this.method_20();
    }

    internal XmlDocument method_2()
    {
        return this.xmlDocument_2;
    }

    private void method_20()
    {
        this.xmlDocument_11.InnerXml = Regex.Replace(this.xmlDocument_11.InnerXml, BookmarkStart.b("%ଧ利ᴫ欭ଯ", 0), BookmarkStart.b("ଥ", 0));
        this.xmlDocument_11.InnerXml = Regex.Replace(this.xmlDocument_11.InnerXml, BookmarkStart.b("%ଧ利眫ḭį1ܳȵഷహ଻ؽ礿́كՅేཉੋፍ⭏捑硓摕╗慙", 0), "");
    }

    private void method_21()
    {
        XmlNode node = this.xmlDocument_11.DocumentElement.SelectSingleNode(BookmarkStart.b("嬫伭䐯圱䘳嬵夷䠹圻ᄽ⤿⽁╃ⅅⵇ", 6));
        if (node != null)
        {
            this.method_35(node);
        }
    }

    private void method_22()
    {
        string str;
        int num = 8;
        XmlNode node = this.xmlDocument_11.DocumentElement.SelectSingleNode(BookmarkStart.b("䰭儯儱弳儵䨷唹䤻倽␿", 8));
        if ((node != null) && ((str = node.Attributes[BookmarkStart.b("稭䤯䈱儳", num)].Value) != null))
        {
            if (str != BookmarkStart.b("椭䈯匱倳張崷吹䠻", num))
            {
                if ((str == BookmarkStart.b("稭唯䨱䀳䌵䨷弹", num)) || (str == BookmarkStart.b("縭夯儱䀳䌵䨷弹", num)))
                {
                    this.method_35(node);
                }
            }
            else
            {
                XmlNode node2 = node.SelectSingleNode(BookmarkStart.b("䤭䈯匱倳張崷吹䠻ᄽ?сⵃ⩅⑇ࡉⵋⵍ㭏㕑♓㥕ⵗ㑙㡛ᵝཟ๡ୣᑥ", num));
                if ((node2 != null) && (node2.Value[1] == 'E'))
                {
                    int num2 = int.Parse(node2.Value.Substring(7), NumberStyles.HexNumber);
                    if (node2.Value[6] == '1')
                    {
                        node2.Value = BookmarkStart.b("䠭夯帱堳ᘵ尷嬹主唽┿ⱁ汃", num) + num2 + BookmarkStart.b("ܭ", num);
                    }
                    else
                    {
                        node2.Value = BookmarkStart.b("䠭夯帱堳ᘵ吷匹嬻嘽㐿❁⩃湅", num) + num2 + BookmarkStart.b("ܭ", num);
                    }
                }
            }
        }
    }

    private void method_23()
    {
        int num = 5;
        XmlNodeList list = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("䜪䐬尮䔰䀲䄴丶唸帺丼ှ㉀㝂㱄⭆ⱈ", 5));
        int num2 = 0;
        foreach (XmlNode node3 in list)
        {
            this.method_40(node3, num2);
            num2++;
        }
        XmlNodeList list3 = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("伪䠬尮到嘲嬴匶堸唺䤼Ծ筀⽂ⱄ㑆㵈晊⭌⁎⍐㹒㑔⍖ɘ᭚ᅜ㥞๠ぢᅤṦը๪⍬๮ᱰᙲ⡴", num));
        if (list3.Count != 0)
        {
            int count = list.Count;
            foreach (XmlNode node2 in list3)
            {
                string str = node2.Attributes[BookmarkStart.b("未䬬䀮戰䜲䰴嬶尸町尼刾⑀", num)].Value;
                string str2 = node2.Attributes[BookmarkStart.b("攪䰬䈮吰", num)].Value;
                string xpath = BookmarkStart.b("䴪䈬䌮崰尲䈴帶圸尺ܼԾⵀ⩂㙄㍆摈ⵊ≌㵎㱐㉒⅔ౖᥘ᝚㭜ぞ㉠ᝢᱤ୦౨╪౬ɮᑰ卲䡴坶幸", num) + str + BookmarkStart.b("పബ丮弰圲ᔴ眶眸娺值娾慀繂敄恆", num) + str2 + BookmarkStart.b("పബ丮弰圲ᔴ夶嘸伺ᔼ缾⡀❂汄ᩆ", num);
                XmlNodeList list2 = node2.SelectNodes(xpath);
                if (node2.Attributes[BookmarkStart.b("䈪䤬", num)] == null)
                {
                    this.method_40(node2, count);
                }
                if (list2.Count != 0)
                {
                    foreach (XmlNode node in list2)
                    {
                        this.method_40(node, count);
                    }
                }
                count++;
            }
        }
    }

    private void method_24()
    {
        XmlNodeList list = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("弫䬭匯䘱崳夵嘷䤹ጻ䴽┿⅁ぃ⽅❇⑉", 6));
        XmlNodeList list2 = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("弫䬭匯䘱崳夵嘷䤹ጻ䴽┿⅁ぃ⽅❇⑉捋ⱍ㽏㙑ⵓ祕⡗㭙⹛㽝ݟၡգᙥgᥩ䍫ݭѯ᝱ᥳ", 6));
        this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("䠫䬭䌯儱儳堵尷嬹刻䨽稿硁❃⹅⥇㡉ⵋⵍ⑏㝑♓筕㹗㕙⹛㍝şᙡ", 6));
        this.method_25(list);
        foreach (XmlNode node in list2)
        {
            this.method_27(node);
        }
    }

    private void method_25(XmlNodeList A_0)
    {
        int num = 0;
        int num2 = 0;
        foreach (XmlNode node in A_0)
        {
            this.method_26(node, BookmarkStart.b("䀥䄧堩弫娭ᴯ䈱唳儵崷᜹吻嬽ℿ♁⅃㑅", num), ref num2);
            this.method_26(node, BookmarkStart.b("䀥䄧堩弫娭ᴯ䈱唳儵崷᜹娻儽⼿㙁⅃㑅", num), ref num2);
            this.method_26(node, BookmarkStart.b("䤥䰧丩ī䘭唯匱倳匵䨷", num), ref num2);
            this.method_26(node, BookmarkStart.b("䤥䰧丩ī䠭弯崱䀳匵䨷", num), ref num2);
            this.method_26(node, BookmarkStart.b("䌥帧伩䈫̭堯圱唳刵崷䠹", num), ref num2);
            this.method_26(node, BookmarkStart.b("䌥帧伩䈫̭嘯崱嬳䈵崷䠹", num), ref num2);
        }
    }

    private void method_26(XmlNode A_0, string A_1, ref int A_2)
    {
        int num = 11;
        XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("夰嘲吴匶尸䤺丼ሾ❀ⱂ⩄㍆ⱈ㥊㹌恎", 11) + A_1);
        XmlNode newChild = this.xmlDocument_11.DocumentElement.SelectSingleNode(BookmarkStart.b("䘰刲䄴制䬸嘺尼䴾⩀", 11)).Clone();
        if (node != null)
        {
            XmlNodeList list = node.SelectNodes(BookmarkStart.b("䄰刲䜴嘶常䤺尼伾⥀あ橄⹆㵈⹊⁌", num));
            if (list != null)
            {
                foreach (XmlNode node3 in list)
                {
                    this.method_27(node3);
                }
            }
            if ((((A_1 == BookmarkStart.b("地娲䜴䐶䴸ᘺ䴼帾♀♂桄⽆ⱈ⩊⥌⩎⍐", num)) || (A_1 == BookmarkStart.b("吰䔲倴夶ᐸ区堼帾╀♂㝄", num))) || (A_1 == BookmarkStart.b("帰圲儴ᨶ儸帺尼嬾⑀ㅂ", num))) && (newChild.Attributes[BookmarkStart.b("昰刲䄴制䬸嘺尼䴾⩀ᝂ㱄㝆ⱈ", num)].Value != BookmarkStart.b("缰尲戴嘶䴸帺似刾⁀ㅂ⹄", num)))
            {
                if ((A_1 != BookmarkStart.b("地娲䜴䐶䴸ᘺ䴼帾♀♂桄⽆ⱈ⩊⥌⩎⍐", num)) && (newChild.SelectSingleNode(BookmarkStart.b("堰帲吴倶尸", num)) != null))
                {
                    XmlAttribute attribute = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("䘰刲䄴制䬸嘺尼䴾⩀", num));
                    attribute.Value = BookmarkStart.b("䔰䄲䀴制", num);
                    newChild.SelectSingleNode(BookmarkStart.b("堰帲吴倶尸", num)).Attributes.Append(attribute);
                }
                node.AppendChild(newChild);
            }
            this.method_40(node, A_2++);
        }
    }

    private void method_27(XmlNode A_0)
    {
        int num = 2;
        if (A_0.NodeType != XmlNodeType.Whitespace)
        {
            if (A_0.Attributes[BookmarkStart.b("尧匩尫䬭", num)].InnerText == BookmarkStart.b("砧䬩師伭圯䀱唳䘵倷", num))
            {
                this.method_30(A_0);
                this.method_29(A_0);
                this.method_28(A_0);
            }
            if (A_0.Attributes[BookmarkStart.b("尧匩尫䬭", num)].InnerText == BookmarkStart.b("簧䬩丫䈭唯", num))
            {
                this.method_39(A_0);
            }
        }
    }

    private void method_28(XmlNode A_0)
    {
        int num = 5;
        XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("堪夬嘮崰嘲", 5));
        XmlNodeList list = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("堪夬嘮崰嘲䘴ᠶ䨸伺䐼匾⑀", 5));
        if (node != null)
        {
            using (IEnumerator enumerator = list.GetEnumerator())
            {
                XmlNode current;
                while (enumerator.MoveNext())
                {
                    current = (XmlNode) enumerator.Current;
                    if (current.Attributes[BookmarkStart.b("䈪䤬", num)].Value == node.Attributes[BookmarkStart.b("太䠬䤮", num)].Value)
                    {
                        goto Label_0099;
                    }
                }
                return;
            Label_0099:
                node.Attributes[BookmarkStart.b("太䠬䤮", num)].Value = current.Attributes[BookmarkStart.b("攪䰬䈮吰", num)].Value.Replace(BookmarkStart.b("ପ", num), "");
            }
        }
    }

    private void method_29(XmlNode A_0)
    {
        int num = 0x12;
        XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("吷匹伻䨽洿⑁⭃㑅╇⭉㡋", 0x12));
        XmlNodeList list = this.xmlDocument_11.DocumentElement.SelectNodes(BookmarkStart.b("吷匹伻䨽㌿㙁㵃⩅ⵇ㥉捋㵍⑏⭑㡓㍕", 0x12));
        if ((node.Attributes[BookmarkStart.b("琷尹医洽㐿㭁⡃⍅ه⭉⅋⭍", 0x12)] == null) && (node.Attributes[BookmarkStart.b("瘷嬹儻嬽", num)] != null))
        {
            int num2 = 0;
            using (IEnumerator enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    XmlNode current = (XmlNode) enumerator.Current;
                    if (current.Attributes[BookmarkStart.b("瘷嬹儻嬽", num)].Value == node.Attributes[BookmarkStart.b("瘷嬹儻嬽", num)].Value)
                    {
                        goto Label_00D5;
                    }
                    num2++;
                }
                return;
            Label_00D5:
                this.method_40(node, num2);
            }
        }
    }

    internal XmlDocument method_3()
    {
        return this.xmlDocument_5;
    }

    private void method_30(XmlNode A_0)
    {
        int num = 12;
        XmlNodeList list = A_0.SelectNodes(BookmarkStart.b("嬱䀳匵唷䤹ጻ圽㐿❁⥃", 12));
        if (list != null)
        {
            int num2 = 0;
            using (IEnumerator enumerator = list.GetEnumerator())
            {
                string str;
            Label_0029:
                if (!enumerator.MoveNext())
                {
                    return;
                }
                XmlNode current = (XmlNode) enumerator.Current;
                if (current.Attributes[BookmarkStart.b("䘱䴳䘵崷", num)] == null)
                {
                    goto Label_032A;
                }
                string innerText = current.Attributes[BookmarkStart.b("䘱䴳䘵崷", num)].InnerText;
                if (innerText != null)
                {
                    int num3;
                    if (Class1160.dictionary_114 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                        dictionary1.Add(BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿ᅁぃ❅㩇㹉", num), 0);
                        dictionary1.Add(BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿݁⩃≅", num), 1);
                        dictionary1.Add(BookmarkStart.b("琱嬳夵䰷吹医䨽┿", num), 2);
                        dictionary1.Add(BookmarkStart.b("愱䴳嬵娷唹倻", num), 3);
                        dictionary1.Add(BookmarkStart.b("焱嬳嬵唷弹刻䨽", num), 4);
                        dictionary1.Add(BookmarkStart.b("戱崳唵䰷伹主嬽", num), 5);
                        dictionary1.Add(BookmarkStart.b("昱儳丵䰷砹医䘽", num), 6);
                        dictionary1.Add(BookmarkStart.b("琱崳匵吷帹", num), 7);
                        dictionary1.Add(BookmarkStart.b("焱尳匵嬷儹縻儽㠿с⭃㑅╇౉╋⭍㱏㙑", num), 8);
                        dictionary1.Add(BookmarkStart.b("瘱䘳夵䠷縹医䤽⸿с⭃㑅╇౉╋⭍㱏㙑", num), 9);
                        dictionary1.Add(BookmarkStart.b("昱儳丵䰷簹医䰽ⴿсⵃ⍅⑇⹉", num), 10);
                        dictionary1.Add(BookmarkStart.b("昱笳电", num), 11);
                        Class1160.dictionary_114 = dictionary1;
                    }
                    if (Class1160.dictionary_114.TryGetValue(innerText, out num3))
                    {
                        switch (num3)
                        {
                            case 0:
                            {
                                int num4 = this.class587_0.method_1(current.Attributes[BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿ు╃⭅ⵇ", num)].Value);
                                this.method_40(current, num4);
                                break;
                            }
                            case 1:
                                goto Label_01FF;

                            case 2:
                                goto Label_0246;

                            case 3:
                                current.Attributes[BookmarkStart.b("焱尳圵䨷礹医娽┿", num)].InnerText = BookmarkStart.b("琱г", num) + Convert.ToString(int.Parse(current.Attributes[BookmarkStart.b("焱尳圵䨷礹医娽┿", num)].InnerText), 0x10).ToUpper();
                                break;

                            case 4:
                                this.method_36(current);
                                break;

                            case 5:
                                this.method_35(current);
                                break;

                            case 6:
                                goto Label_02CA;

                            case 7:
                            case 8:
                            case 9:
                            case 10:
                            case 11:
                                goto Label_0320;
                        }
                    }
                }
                goto Label_0332;
            Label_01FF:
                str = this.class587_0.method_0(current.Attributes[BookmarkStart.b("瀱嬳夵匷圹崻䰽⬿ు╃⭅ⵇ", num)].Value);
                try
                {
                    int num5 = int.Parse(str);
                    this.method_40(current, num5);
                }
                catch (Exception)
                {
                }
                goto Label_0332;
            Label_0246:
                this.method_34(current);
                goto Label_0332;
            Label_02CA:
                foreach (XmlNode node2 in current.SelectNodes(BookmarkStart.b("倱嬳刵䄷ᔹ䰻弽㈿⍁⍃㑅⥇㩉⑋㵍罏㭑⁓㍕㕗", num)))
                {
                    this.method_27(node2);
                }
                goto Label_0332;
            Label_0320:
                this.method_32(current);
                goto Label_0332;
            Label_032A:
                this.method_31(current);
            Label_0332:
                num2++;
                goto Label_0029;
            }
        }
    }

    private void method_31(XmlNode A_0)
    {
        int num = 9;
        XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("嬮吰䬲䄴", 9));
        char[] separator = new char[] { '\r', '\n' };
        string[] strArray = node.InnerXml.Split(separator);
        if ((node != null) && (strArray.Length > 1))
        {
            XmlNode node6 = A_0.SelectSingleNode(BookmarkStart.b("丮弰倲倴䐶䴸吺似Ծ筀㍂⑄㕆⡈ⱊ㽌⹎⅐㭒♔ౖ桘ٚ", num));
            XmlNode refChild = A_0.SelectSingleNode(BookmarkStart.b("丮弰倲倴䐶䴸吺似Ծ筀⩂ㅄ≆⑈၊ൌ㭎⡐⍒ご睖摘筚穜ཞ`ᅢѤf᭨੪ᵬݮ噰⹲", num));
            for (int i = 0; i < strArray.Length; i++)
            {
                string str = strArray[i];
                if ((str.Length > 0) || (i == (strArray.Length - 1)))
                {
                    XmlNode newChild = this.xmlDocument_11.CreateElement(BookmarkStart.b("䘮䔰嘲場", num));
                    XmlAttribute attribute = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("嬮䠰䌲倴", num));
                    attribute.Value = BookmarkStart.b("缮倰䄲吴倶䬸娺䴼圾", num);
                    newChild.Attributes.Append(attribute);
                    newChild.AppendChild(refChild.SelectSingleNode(BookmarkStart.b("弮倰䄲吴倶䬸娺䴼圾汀╂⩄㕆⑈⩊㥌", num)).Clone());
                    newChild.AppendChild(refChild.SelectSingleNode(BookmarkStart.b("䰮夰刲䜴嘶娸伺堼䴾汀╂⩄㕆⑈⩊㥌", num)).Clone());
                    newChild.AppendChild(refChild.SelectSingleNode(BookmarkStart.b("䌮堰䀲䄴ᨶ弸吺似刾⁀㝂", num)).Clone());
                    XmlNode node4 = this.xmlDocument_11.CreateElement(BookmarkStart.b("䘮䔰嘲場䐶", num));
                    XmlNode node5 = A_0.Clone();
                    node5.SelectSingleNode(BookmarkStart.b("嬮吰䬲䄴", num)).InnerXml = str;
                    node4.AppendChild(node5);
                    newChild.AppendChild(node4);
                    node6.InsertBefore(newChild, refChild);
                }
            }
            node6.RemoveChild(refChild);
        }
    }

    private void method_32(XmlNode A_0)
    {
        int num = 4;
        int num2 = this.method_41();
        this.method_40(A_0, num2);
        XmlNodeList list = A_0.SelectNodes(BookmarkStart.b("䰩䌫䈭尯崱䌳張嘷崹ػн⤿㙁⅃⭅", 4));
        int num3 = 0;
        int num4 = 1;
        using (IEnumerator enumerator = list.GetEnumerator())
        {
            XmlNode current;
            while (enumerator.MoveNext())
            {
                current = (XmlNode) enumerator.Current;
                if ((current.Attributes[BookmarkStart.b("縩唫席唯", num)] != null) || ((current.Attributes[BookmarkStart.b("帩唫席唯", num)] != null) && (current.Attributes[BookmarkStart.b("帩唫席唯", num)].Value == BookmarkStart.b("縩挫洭", num))))
                {
                    num4++;
                }
                if ((current.Attributes[BookmarkStart.b("氩䔫䬭尯嘱礳圵䨷儹栻䜽〿❁", num)] != null) && (current.Attributes[BookmarkStart.b("氩䔫䬭尯嘱礳圵䨷儹栻䜽〿❁", num)].Value == BookmarkStart.b("氩䔫䬭尯嘱焳堵尷", num)))
                {
                    num3++;
                }
                if (num3 == num4)
                {
                    goto Label_0196;
                }
                if ((current.Attributes[BookmarkStart.b("氩䔫䬭尯嘱礳圵䨷儹栻䜽〿❁", num)] != null) && (current.Attributes[BookmarkStart.b("氩䔫䬭尯嘱礳圵䨷儹栻䜽〿❁", num)].Value == BookmarkStart.b("氩䔫䬭尯嘱朳匵䠷嬹主弽㐿ⵁ㙃", num)))
                {
                    this.method_40(current, num2);
                }
                XmlAttribute node = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("稩䴫尭唯就䀳瀵儷弹倻娽ि♁", num));
                node.Value = num2.ToString();
                current.Attributes.Append(node);
            }
            goto Label_01B6;
        Label_0196:
            this.method_40(current, num2);
        }
    Label_01B6:
        this.method_33(A_0);
    }

    private void method_33(XmlNode A_0)
    {
        int num = 2;
        XmlAttribute attribute = A_0.Attributes[BookmarkStart.b("砧䬩師伭崯䄱", 2)];
        if (attribute != null)
        {
            int num2 = int.Parse(attribute.Value);
            int num3 = (num2 & 0x7c) >> 2;
            if ((num2 & 0x80) == 0x80)
            {
                XmlAttribute node = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("性伩䀫席搯䬱䐳匵", num));
                node.Value = BookmarkStart.b("尧伩含娭", num);
                A_0.Attributes.Append(node);
            }
            if ((num2 & 0x100) == 0x100)
            {
                XmlAttribute attribute4 = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("笧帩䴫娭䔯䄱怳伵䠷弹", num));
                attribute4.Value = BookmarkStart.b("尧伩含娭", num);
                A_0.Attributes.Append(attribute4);
            }
            if ((num2 & 0x200) == 0)
            {
                XmlAttribute attribute7 = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("洧䐩䴫䰭尯圱倳", num));
                attribute7.Value = BookmarkStart.b("尧堩夫䬭", num);
                A_0.Attributes.Append(attribute7);
            }
            if ((num2 & 0x4000) == 0)
            {
                XmlAttribute attribute3 = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("欧䬩䀫䴭䔯帱唳䈵崷甹刻笽㠿⭁ぃ", num));
                attribute3.Value = BookmarkStart.b("丧䬩䀫崭唯", num);
                A_0.Attributes.Append(attribute3);
            }
            if ((num3 == 1) && (A_0.Attributes[BookmarkStart.b("尧匩尫䬭", num)].InnerText == BookmarkStart.b("欧䈩䤫䴭嬯瀱嬳丵縷唹主匽ؿ⭁⅃⩅ⱇ", num)))
            {
                XmlAttribute attribute2 = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("欧䈩䤫䴭嬯圱倳", num));
                attribute2.Value = BookmarkStart.b("尧堩夫䬭", num);
                A_0.Attributes.Append(attribute2);
            }
            if (A_0.Attributes[BookmarkStart.b("尧匩尫䬭", num)].InnerText == BookmarkStart.b("氧堩䌫席琯崱䌳堵縷唹主匽ؿ⭁⅃⩅ⱇ", num))
            {
                XmlAttribute attribute5 = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("氧堩䌫席琯崱䌳堵欷弹倻嬽⌿㙁⅃≅Ň⑉⡋⭍⡏", num));
                attribute5.Value = num3.ToString();
                A_0.Attributes.Append(attribute5);
            }
        }
    }

    private void method_34(XmlNode A_0)
    {
        int num = 1;
        this.method_40(A_0, this.method_41());
        XmlNodeList list = A_0.SelectNodes(BookmarkStart.b("䔦䘨伪听.䄰刲䜴嘶常䤺尼伾⥀あ橄⹆㵈⹊⁌", 1));
        if (list != null)
        {
            foreach (XmlNode node in list)
            {
                this.method_27(node);
            }
        }
        if (A_0.Attributes[BookmarkStart.b("琦倨䘪伬䀮崰瀲娴匶尸", num)] != null)
        {
            string str = Convert.ToString(int.Parse(A_0.Attributes[BookmarkStart.b("琦倨䘪伬䀮崰瀲娴匶尸", num)].InnerText), 0x10);
            A_0.Attributes[BookmarkStart.b("琦倨䘪伬䀮崰瀲娴匶尸", num)].InnerText = BookmarkStart.b("愦ᤨ", num) + str;
        }
        XmlNodeList list2 = A_0.SelectNodes(BookmarkStart.b("䌦䰨堪丬䨮弰圲吴夶䴸ĺܼ䬾⑀㭂ㅄ", num));
        int num2 = A_0.SelectNodes(BookmarkStart.b("圦嬨个丬䨮唰娲嬴倶̸ĺ吼䬾⑀⹂Ṅ݆㵈㉊㵌⩎煐湒畔灖὘㑚㉜⭞འౢᅤɦ乨㙪", num)).Count + 1;
        foreach (XmlNode node2 in list2)
        {
            if (node2.InnerXml == BookmarkStart.b("Ħਨ匪Ἤᐮ", num))
            {
                node2.InnerXml = num2.ToString();
            }
        }
    }

    private void method_35(XmlNode A_0)
    {
        Image image;
        int num = 0;
        int num2 = this.method_41();
        this.method_40(A_0, num2);
        MemoryStream stream = new MemoryStream(Convert.FromBase64String(A_0.SelectSingleNode(BookmarkStart.b("伥䔧䬩䬫䬭", 0)).InnerText));
        if ((A_0.Attributes[BookmarkStart.b("漥嬧朩䤫娭儯吱崳娵崷", 0)] != null) && (A_0.Attributes[BookmarkStart.b("漥嬧朩䤫娭儯吱崳娵崷", num)].Value == BookmarkStart.b("別娧弩䤫", num)))
        {
            image = new Metafile(stream);
        }
        else
        {
            image = new Bitmap(stream);
        }
        this.hashtable_1.Add(num2.ToString(), image);
    }

    private void method_36(XmlNode A_0)
    {
        int num = 0x11;
        int num2 = this.method_41();
        this.method_40(A_0, num2);
        int num3 = 0;
        XmlAttribute attribute = A_0.SelectSingleNode(BookmarkStart.b("吶嘸嘺值娾⽀㝂桄ⅆ♈㥊⁌⹎═", 0x11)).Attributes[BookmarkStart.b("甶嘸吺嘼刾⁀ㅂ⹄ᑆ㵈⩊㽌㭎Ő㱒♔", 0x11)];
        if (attribute != null)
        {
            num3 = int.Parse(attribute.Value);
        }
        if (num3 != 0)
        {
            this.method_37(A_0, BookmarkStart.b("甶嘸吺嘼刾⁀ㅂ⹄ᑆ㵈⩊㽌㭎Ő㱒♔", num), num2);
            if (A_0.SelectSingleNode(BookmarkStart.b("吶嘸嘺值娾⽀㝂桄ⅆ♈㥊⁌⹎═", num)).Attributes[BookmarkStart.b("甶嘸吺嘼刾⁀ㅂ⹄Ɇ❈⽊ᵌ⁎≐", num)] != null)
            {
                this.method_37(A_0, BookmarkStart.b("甶嘸吺嘼刾⁀ㅂ⹄Ɇ❈⽊ᵌ⁎≐", num), num2);
            }
            else
            {
                this.method_38(BookmarkStart.b("琶嘸嘺值娾⽀㝂ф⥆⩈⍊≌㵎ᑐ㵒ㅔ", num), A_0, 0, num2);
            }
        }
        foreach (XmlNode node in A_0.SelectNodes(BookmarkStart.b("唶嘸强䐼ှㅀ≂㝄♆⹈㥊ⱌ㽎㥐⁒穔㹖ⵘ㹚ぜ", num)))
        {
            this.method_27(node);
        }
    }

    private void method_37(XmlNode A_0, string A_1, int A_2)
    {
        int num = 9;
        int num2 = int.Parse(A_0.SelectSingleNode(BookmarkStart.b("䰮帰帲場制圸伺ြ夾⹀ㅂ⡄♆㵈", 9)).Attributes[A_1].Value);
        if (num2 < 0)
        {
            num2 *= -1;
        }
        if (num2 == 0)
        {
            this.method_38(BookmarkStart.b("氮帰帲場制圸伺簼儾≀⭂⩄㕆ై╊⥌", num), A_0, 0, A_2);
        }
        else
        {
            XmlNodeList list = A_0.SelectNodes(BookmarkStart.b("弮䌰嘲嘴制崸刺匼堾筀祂⭄⡆ⵈ⹊敌晎", num));
            XmlNode node5 = A_0.SelectSingleNode(BookmarkStart.b("丮弰倲倴䐶䴸吺似Ծ筀⩂ㅄ≆⑈၊ൌ㭎⡐⍒ご睖摘筚穜ཞ`ᅢѤf᭨੪ᵬݮ噰⹲", num));
            for (int i = list.Count - 1; i > 0; i--)
            {
                XmlNode node3;
                XmlNode node4;
                XmlNode node = list[i];
                int length = 0;
                if (node.SelectSingleNode(BookmarkStart.b("丮弰倲倴䐶䴸吺似Ծ筀⩂ㅄ≆⑈၊ൌ㭎⡐⍒ご睖摘筚穜ᱞ๠๢ࡤɦݨὪ䩬㉮", num)) != null)
                {
                    continue;
                }
                string name = node.Name;
                if (name == null)
                {
                    goto Label_0302;
                }
                if (name != BookmarkStart.b("䘮䔰嘲場", num))
                {
                    if ((name == BookmarkStart.b("崮帰䐲", num)) || (name == BookmarkStart.b("䰮吰弲头", num)))
                    {
                        length = 1;
                    }
                    goto Label_0302;
                }
                XmlAttribute attribute = node.Attributes[BookmarkStart.b("嬮䠰䌲倴", num)];
                if (attribute == null)
                {
                    goto Label_0283;
                }
                string str = attribute.Value;
                if (str != null)
                {
                    if ((str != BookmarkStart.b("簮䠰帲圴堶唸", num)) && (str != BookmarkStart.b("缮堰倲䄴䈶䬸帺", num)))
                    {
                        if (str != BookmarkStart.b("氮帰帲場制圸伺", num))
                        {
                            if (!(str == BookmarkStart.b("椮堰嘲头匶", num)))
                            {
                                goto Label_027F;
                            }
                            length = node.Attributes[BookmarkStart.b("笮䠰䌲倴", num)].Value.Length;
                            if (node.Attributes[BookmarkStart.b("礮倰弲䀴制", num)] != null)
                            {
                                length += node.Attributes[BookmarkStart.b("礮倰弲䀴制", num)].Value.Length;
                            }
                            if ((node.Attributes[BookmarkStart.b("笮吰䬲䄴然嘸䤺值帾㕀", num)] != null) && (node.Attributes[BookmarkStart.b("笮吰䬲䄴然嘸䤺值帾㕀", num)].Value != BookmarkStart.b("愮帰崲倴", num)))
                            {
                                length += node.Attributes[BookmarkStart.b("笮吰䬲䄴然嘸䤺值帾㕀", num)].Value.Length;
                            }
                            if (node.Attributes[BookmarkStart.b("椮堰嘲头匶缸吺似刾⁀㝂ㅄ⹆❈ⱊ", num)] != null)
                            {
                                length += node.Attributes[BookmarkStart.b("椮堰嘲头匶缸吺似刾⁀㝂ㅄ⹆❈ⱊ", num)].Value.Length;
                            }
                        }
                        else
                        {
                            length = 1;
                        }
                    }
                    else
                    {
                        length = 1;
                    }
                    goto Label_02A7;
                }
            Label_027F:
                length = 0;
                goto Label_02A7;
            Label_0283:
                node3 = node.SelectSingleNode(BookmarkStart.b("嬮吰䬲䄴", num));
                if (node3 != null)
                {
                    length = node3.InnerText.Length;
                }
            Label_02A7:
                node4 = node.SelectSingleNode(BookmarkStart.b("丮弰倲倴䐶䴸吺似Ծ筀⩂ㅄ≆⑈၊ൌ㭎⡐⍒ご橖繘୚㱜ⵞ`Ѣᝤ٦ᥨͪ䩬㉮", num));
                if ((node5 != node4) && (node4 != null))
                {
                    XmlNode node7 = node4.SelectSingleNode(BookmarkStart.b("丮弰倲倴䐶䴸吺似Ծ筀⁂⁄⭆╈", num));
                    XmlNode node2 = node5.SelectSingleNode(BookmarkStart.b("丮弰倲倴䐶䴸吺似Ծ筀⁂⁄⭆╈", num));
                    if ((node7 == node2) || ((node7 == null) && (node2 != null)))
                    {
                        num2--;
                    }
                    node5 = node4;
                }
            Label_0302:
                if (num2 <= length)
                {
                    if (A_1 == BookmarkStart.b("洮帰尲帴娶堸䤺嘼氾㕀≂㝄㍆᥈⑊㹌", num))
                    {
                        this.method_38(BookmarkStart.b("氮帰帲場制圸伺簼儾≀⭂⩄㕆ᩈ㽊ⱌ㵎═", num), node, num2, A_2);
                    }
                    if (A_1 == BookmarkStart.b("洮帰尲帴娶堸䤺嘼稾⽀❂ᕄ⡆㩈", num))
                    {
                        this.method_38(BookmarkStart.b("氮帰帲場制圸伺簼儾≀⭂⩄㕆ై╊⥌", num), node, num2, A_2);
                    }
                    return;
                }
                num2 -= length;
            }
        }
    }

    private void method_38(string A_0, XmlNode A_1, int A_2, int A_3)
    {
        XmlNode node3;
        int num = 6;
        XmlNode parentNode = A_1.ParentNode;
        XmlNode newChild = this.xmlDocument_11.CreateElement(BookmarkStart.b("䔫娭唯弱", 6));
        XmlAttribute node = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("堫圭䀯圱", 6));
        node.Value = A_0;
        XmlAttribute attribute2 = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("䔫䨭", 6));
        attribute2.Value = A_3.ToString();
        newChild.Attributes.Append(node);
        newChild.Attributes.Append(attribute2);
        if ((A_1.Name == BookmarkStart.b("䔫娭唯弱", 6)) && (A_1.Attributes[BookmarkStart.b("堫圭䀯圱", num)] == null))
        {
            string innerText = A_1.SelectSingleNode(BookmarkStart.b("堫䬭䠯䘱", num)).InnerText;
            string str2 = innerText.Substring(innerText.Length - A_2);
            node3 = A_1.Clone();
            node3.SelectSingleNode(BookmarkStart.b("堫䬭䠯䘱", num)).InnerText = str2;
            A_1.SelectSingleNode(BookmarkStart.b("堫䬭䠯䘱", num)).InnerText = innerText.Remove(innerText.Length - A_2, A_2);
            parentNode.InsertAfter(node3, A_1);
        }
        else
        {
            node3 = A_1;
        }
        parentNode.InsertBefore(newChild, node3);
    }

    private void method_39(XmlNode A_0)
    {
        int num = 0x12;
        XmlNodeList list = A_0.SelectNodes(BookmarkStart.b("䨷唹䬻䴽漿ぁ⭃ㅅ杇㹉ⵋⱍ㱏㝑祓さ㝗⡙ㅛ㽝ᑟ", 0x12));
        for (int i = 0; i < (list.Count - 1); i++)
        {
            if (list[i].InnerXml != list[i + 1].InnerXml)
            {
                XmlNodeList list4 = list[i].ParentNode.SelectNodes(BookmarkStart.b("帷唹倻刽⼿㕁ⵃ⡅⽇杉㽋❍㉏㹑㵓㡕㽗恙晛ⱝཟᕡ", num));
                XmlDocument ownerDocument = A_0.OwnerDocument;
                XmlNode newChild = ownerDocument.CreateElement(BookmarkStart.b("儷丹夻匽", num));
                XmlAttribute node = ownerDocument.CreateAttribute(BookmarkStart.b("䰷䌹䰻嬽", num));
                node.Value = BookmarkStart.b("氷嬹帻刽┿", num);
                newChild.Attributes.Append(node);
                XmlNode node2 = ownerDocument.CreateElement(BookmarkStart.b("䨷唹䬻䴽", num));
                foreach (XmlNode node3 in list4)
                {
                    node2.AppendChild(node3);
                }
                newChild.AppendChild(node2);
                A_0.ParentNode.InsertAfter(newChild, A_0);
                this.method_39(newChild);
            }
        }
        Class591 class2 = new Class591();
        class2.method_0(A_0);
        class2.method_1();
        for (int j = 1; j < list.Count; j++)
        {
            XmlAttribute attribute3 = list[j].Attributes[BookmarkStart.b("琷弹娻䨽༿⑁≃㕅ⵇ㹉", num)];
            XmlAttribute attribute4 = list[j - 1].Attributes[BookmarkStart.b("琷弹娻䨽༿⑁≃㕅ⵇ㹉", num)];
            if (attribute3 != null)
            {
                float num4 = float.Parse(attribute3.Value.Replace('.', ','));
                float num8 = 0f;
                if (attribute4 != null)
                {
                    num8 = float.Parse(attribute4.Value.Replace('.', ','));
                }
                if ((num8 == 0f) || (num4 > num8))
                {
                    XmlAttribute attribute2 = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("缷䠹唻娽ȿ❁≃⥅㩇⽉", num));
                    XmlNodeList list2 = A_0.SelectNodes(BookmarkStart.b("䰷堹倻礽㈿⭁⁃楅⽇㡉╋⩍ፏ㵑㡓", num));
                    float num3 = 0f;
                    int num6 = 0;
                    foreach (XmlNode node5 in list2)
                    {
                        float num9 = float.Parse(node5.Attributes[BookmarkStart.b("伷", num)].Value.Replace('.', ','));
                        num3 += num9;
                        if (num3 >= (num4 * 20f))
                        {
                            break;
                        }
                        num6++;
                    }
                    if (num3 < (num4 * 20f))
                    {
                        XmlElement element = this.xmlDocument_11.CreateElement(BookmarkStart.b("強䠹唻娽̿ⵁ⡃", num));
                        XmlAttribute attribute = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("伷", num));
                        attribute.Value = ((num4 * 20f) - num3).ToString();
                        element.Attributes.Append(attribute);
                        A_0.SelectSingleNode(BookmarkStart.b("䰷堹倻礽㈿⭁⁃", num)).AppendChild(element);
                        num6++;
                    }
                    attribute2.Value = num6.ToString();
                    list[j].Attributes.Append(attribute2);
                }
            }
        }
        foreach (XmlNode node4 in A_0.SelectNodes(BookmarkStart.b("䨷唹䬻䴽漿ぁ⭃ㅅ杇⥉⥋≍㱏⅑筓㕕㵗㙙せ煝ၟ͡ᙣݥཧᡩ൫ṭᡯű孳ή౷όᅻ", num)))
        {
            this.method_27(node4);
        }
    }

    internal XmlDocument method_4()
    {
        return this.xmlDocument_6;
    }

    private void method_40(XmlNode A_0, int A_1)
    {
        XmlAttribute node = this.xmlDocument_11.CreateAttribute(BookmarkStart.b("張尷", 0x10));
        node.Value = A_1.ToString();
        A_0.Attributes.Append(node);
    }

    private int method_41()
    {
        return this.int_0++;
    }

    internal XmlDocument method_5()
    {
        return this.xmlDocument_7;
    }

    internal XmlDocument method_6()
    {
        return this.xmlDocument_8;
    }

    internal Hashtable method_7()
    {
        return this.hashtable_0;
    }

    internal XmlDocument method_8()
    {
        return this.xmlDocument_3;
    }

    internal XmlDocument method_9()
    {
        return this.xmlDocument_4;
    }

    internal class Class586
    {
        private string string_0;
        private string string_1;

        public string method_0()
        {
            return this.string_0;
        }

        public void method_1(string A_0)
        {
            this.string_0 = A_0;
        }

        public string method_2()
        {
            return this.string_1;
        }

        public void method_3(string A_0)
        {
            this.string_1 = A_0;
        }
    }

    [DefaultMember("Item")]
    internal class Class587 : ArrayList
    {
        private int int_0;

        public override int Add(object value)
        {
            (value as Class585.Class586).method_3(this.int_0.ToString());
            this.int_0++;
            base.Add(value);
            return (this.int_0 - 1);
        }

        public string method_0(string A_0)
        {
            string str = string.Empty;
            using (IEnumerator enumerator = this.GetEnumerator())
            {
                Class585.Class586 current;
                while (enumerator.MoveNext())
                {
                    current = (Class585.Class586) enumerator.Current;
                    if (current.method_0() == A_0)
                    {
                        goto Label_0034;
                    }
                }
                return str;
            Label_0034:
                str = current.method_2();
            }
            return str;
        }

        public int method_1(string A_0)
        {
            Class585.Class586 class2 = new Class585.Class586();
            class2.method_1(A_0);
            class2.method_3(this.int_0.ToString());
            this.int_0++;
            base.Add(class2);
            return (this.int_0 - 1);
        }
    }

    internal class Class588
    {
        private double double_0;

        public Class588()
        {
        }

        public Class588(double A_0)
        {
            this.double_0 = A_0;
        }

        public double method_0()
        {
            return this.double_0;
        }

        public void method_1(double A_0)
        {
            this.double_0 = A_0;
        }
    }

    internal class Class589 : ArrayList
    {
        public int method_0(Class585.Class588 A_0)
        {
            return base.Add(A_0);
        }

        public int method_1(double A_0)
        {
            return this.method_0(new Class585.Class588(A_0));
        }

        public double method_2(double A_0)
        {
            double num2;
            double num = 0.0;
            using (IEnumerator enumerator = this.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class585.Class588 current = (Class585.Class588) enumerator.Current;
                    num += current.method_0();
                    if (num > A_0)
                    {
                        goto Label_0037;
                    }
                }
                return 0.0;
            Label_0037:
                num2 = num - A_0;
            }
            return num2;
        }

        public int method_3(double A_0, double A_1)
        {
            int num3;
            int num = 1;
            double num2 = 0.0;
            using (IEnumerator enumerator = this.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class585.Class588 current = (Class585.Class588) enumerator.Current;
                    num2 += current.method_0();
                    if (A_1 == num2)
                    {
                        goto Label_0043;
                    }
                    if (num2 > A_0)
                    {
                        num++;
                    }
                }
                return (num - 1);
            Label_0043:
                num3 = num;
            }
            return num3;
        }
    }

    internal class Class590 : ArrayList
    {
        public int method_0(Class585.Class589 A_0)
        {
            return base.Add(A_0);
        }
    }

    internal class Class591
    {
        private Class585.Class589 class589_0 = new Class585.Class589();
        private Class585.Class590 class590_0 = new Class585.Class590();
        private NumberFormatInfo numberFormatInfo_0 = new NumberFormatInfo();
        private XmlNode xmlNode_0;

        public Class591()
        {
            this.numberFormatInfo_0.CurrencyDecimalSeparator = BookmarkStart.b("᬴", 15);
        }

        public void method_0(XmlNode A_0)
        {
            int num = 1;
            this.xmlNode_0 = A_0;
            XmlNodeList list = this.xmlNode_0.SelectNodes(string.Format(BookmarkStart.b("尦ᤨ嘪Ȭ吮0串", 1), BookmarkStart.b("唦䘨尪帬", 1), BookmarkStart.b("唦䘨尪", 1)));
            if (list.Count > 0)
            {
                foreach (XmlNode node in list)
                {
                    XmlNodeList list2 = node.SelectNodes(string.Format(BookmarkStart.b("尦ᤨ嘪Ȭ吮0串", num), BookmarkStart.b("䐦䰨䜪䄬尮", num), BookmarkStart.b("䐦䰨䜪䄬", num)));
                    if (list2.Count > 0)
                    {
                        Class585.Class589 class2 = new Class585.Class589();
                        foreach (XmlNode node2 in list2)
                        {
                            class2.method_1(Convert.ToDouble(node2.Attributes[BookmarkStart.b("瀦䀨伪夬䜮", num)].InnerText, this.numberFormatInfo_0));
                        }
                        this.class590_0.method_0(class2);
                    }
                }
            }
        }

        public void method_1()
        {
            int num = 0x11;
            this.method_2();
            XmlElement newChild = this.xmlNode_0.OwnerDocument.CreateElement(BookmarkStart.b("䌶嬸场稼䴾⡀❂", 0x11));
            foreach (Class585.Class588 class2 in this.class589_0)
            {
                XmlElement element2 = this.xmlNode_0.OwnerDocument.CreateElement(BookmarkStart.b("倶䬸刺夼簾⹀⽂", num));
                element2.SetAttribute(BookmarkStart.b("䀶", num), ((int) (class2.method_0() * 20.0)).ToString());
                newChild.AppendChild(element2);
            }
            this.xmlNode_0.AppendChild(newChild);
            XmlNodeList list2 = this.xmlNode_0.SelectNodes(string.Format(BookmarkStart.b("䰶स䘺ሼ䐾灀㹂", num), BookmarkStart.b("䔶嘸䰺丼", num), BookmarkStart.b("䔶嘸䰺", num)));
            if (list2.Count > 0)
            {
                foreach (XmlNode node2 in list2)
                {
                    XmlNodeList list = node2.SelectNodes(string.Format(BookmarkStart.b("䰶स䘺ሼ䐾灀㹂", num), BookmarkStart.b("吶尸场儼䰾", num), BookmarkStart.b("吶尸场儼", num)));
                    double num3 = 0.0;
                    double num4 = 0.0;
                    if (list.Count > 0)
                    {
                        foreach (XmlNode node in list)
                        {
                            double num2 = Convert.ToDouble(node.Attributes[BookmarkStart.b("怶倸强䤼圾", num)].InnerText, this.numberFormatInfo_0);
                            num4 = num3;
                            num3 += num2;
                            int num5 = this.class589_0.method_3(num4, num3);
                            if (num5 > 1)
                            {
                                XmlAttribute attribute = node.OwnerDocument.CreateAttribute(BookmarkStart.b("吶嘸场儼尾⹀㙂⭄㍆", num));
                                attribute.InnerText = num5.ToString();
                                node.Attributes.Append(attribute);
                            }
                        }
                    }
                }
            }
        }

        private void method_2()
        {
            double maxValue = 0.0;
            double num2 = 0.0;
            if (this.class590_0.Count > 0)
            {
                bool flag = true;
                while (flag)
                {
                    maxValue = double.MaxValue;
                    foreach (Class585.Class589 class2 in this.class590_0)
                    {
                        double num3 = class2.method_2(num2);
                        maxValue = (maxValue > num3) ? num3 : maxValue;
                    }
                    if (maxValue == 0.0)
                    {
                        return;
                    }
                    num2 += maxValue;
                    this.class589_0.method_1(maxValue);
                }
            }
        }

        private void method_3(Class585.Class589 A_0)
        {
            this.class590_0.method_0(A_0);
        }
    }
}

