using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

internal abstract class Class697
{
    internal const char char_0 = '\x001e';
    internal const char char_1 = '\x001f';
    internal const char char_2 = '\x00a0';
    internal const int int_0 = 20;
    internal const int int_1 = 8;
    internal const string string_0 = "vbaProject.bin";
    internal const string string_1 = "vbaData.xml";
    internal const string string_10 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments";
    internal const string string_100 = "http://schemas.openxmlformats.org/markup-compatibility/2006";
    internal const string string_101 = "http://schemas.openxmlformats.org/officeDocument/2006/math";
    internal const string string_102 = "http://schemas.microsoft.com/office/word/2006/wordml";
    internal const string string_103 = "http://purl.org/dc/dcmitype/";
    internal const string string_104 = "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties";
    internal const string string_105 = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes";
    internal const string string_106 = "http://schemas.openxmlformats.org/drawingml/2006/chart";
    internal const string string_107 = "mso-fit-shape-to-text:t";
    internal const string string_108 = "mso-fit-text-to-shape:t";
    internal const string string_109 = "#whitespace";
    internal const string string_11 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image";
    internal const string string_110 = "#comment";
    private static readonly string string_111 = '\\'.ToString();
    internal readonly string string_112 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("圲娴吶䰸嘺堼儾㕀浂㵄⩆╈", 13));
    internal readonly string string_113 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("䀲䄴丶唸帺丼ᄾ㥀⹂⥄", 13));
    internal readonly string string_114 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("崲䀴娶嬸帺似嘾⽀⑂歄㽆⑈❊", 13));
    internal readonly string string_115 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("䀲倴䌶䴸刺匼堾㉀浂㵄⩆╈", 13));
    internal readonly string string_116 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("唲娴堶䴸唺刼䬾⑀あ歄㽆⑈❊", 13));
    internal readonly string string_117 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("嘲嬴匶圸吺䤼娾㉀浂㵄⩆╈", 13));
    internal readonly string string_118 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("嬲倴嘶崸帺似", 13));
    internal readonly string string_119 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("唲娴堶䴸帺似", 13));
    internal const string string_12 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink";
    internal readonly string string_120 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("倲娴娶吸帺匼䬾㉀浂㵄⩆╈", 13));
    internal readonly string string_121 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("帲倴匶倸娺", 13) + string_111 + BookmarkStart.b("娲場嘶常帺", 13));
    internal readonly string string_122 = (BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("ᴲ䜴制唸䠺", 13));
    internal readonly string string_123 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("圲娴吶䰸嘺堼儾㕀浂㵄⩆╈敊㽌⩎㵐⁒", 13));
    internal readonly string string_124 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("倲娴娶吸帺匼䬾㉀浂㵄⩆╈敊㽌⩎㵐⁒", 13));
    internal readonly string string_125 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("唲娴堶䴸唺刼䬾⑀あ歄㽆⑈❊捌㵎㑐㽒♔", 13));
    internal readonly string string_126 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("嘲嬴匶圸吺䤼娾㉀浂㵄⩆╈敊㽌⩎㵐⁒", 13));
    internal readonly string string_127 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("崲䀴娶嬸帺似嘾⽀⑂歄㽆⑈❊捌㵎㑐㽒♔", 13));
    internal readonly string string_128 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("嬲倴嘶崸帺似", 13));
    internal readonly string string_129 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("唲娴堶䴸帺似", 13));
    internal const string string_13 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties";
    internal readonly string string_130 = (BookmarkStart.b("圲娴吶椸䤺刼伾㉀", 13) + string_111 + BookmarkStart.b("刲䔴䜶᜸䌺值匾", 13));
    internal readonly string string_131 = (BookmarkStart.b("圲娴吶椸䤺刼伾㉀", 13) + string_111 + BookmarkStart.b("倲娴䔶尸ᔺ䔼刾ⵀ", 13));
    internal readonly string string_132 = (BookmarkStart.b("圲娴吶椸䤺刼伾㉀", 13) + string_111 + BookmarkStart.b("倲䀴䐶䴸吺值ᄾ㥀⹂⥄", 13));
    internal readonly string string_133 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("唲娴夶䴸漺尼崾ⵀ♂歄㽆⑈❊", 13));
    internal readonly string string_134 = BookmarkStart.b("栲瘴堶圸伺堼儾㕀᱂ᅄ㹆㥈⹊㹌቎罐⭒㡔㭖", 13);
    internal readonly string string_135 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("倲崴嘶䬸伺丼", 13) + string_111);
    internal readonly string string_136 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("嘲場唶尸强夼嘾⽀⑂㙄", 13) + string_111);
    internal readonly string string_137 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("圲䜴嘶丸刺匼堾㉀", 13) + string_111 + BookmarkStart.b("圲䜴嘶丸刺匼堾灀浂㵄⩆╈", 13));
    internal readonly string string_138 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("䀲倴䌶䴸刺匼堾㉀浂㵄⩆╈敊㽌⩎㵐⁒", 13));
    internal readonly string string_139 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("䔲圴嘶椸䤺刼唾⑀⁂ㅄ楆⭈≊⍌", 13));
    internal const string string_14 = "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties";
    internal readonly string string_140 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("氲䜴制唸䠺", 13) + string_111 + BookmarkStart.b("䔲圴嘶椸䤺刼唾⑀⁂ㅄ楆⭈≊⍌慎⍐㙒㥔⑖", 13));
    internal readonly string string_141 = (BookmarkStart.b("䐲娴䔶崸", 13) + string_111 + BookmarkStart.b("䔲圴嘶紸娺䤼帾潀㭂⡄⭆", 13));
    internal readonly string string_142 = (BookmarkStart.b("倲䀴䐶䴸吺值朾ⱀ⽂", 13) + string_111);
    internal const string string_15 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties";
    internal const string string_16 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable";
    internal const string string_17 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart";
    internal const string string_18 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme";
    internal const string string_19 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control";
    internal const string string_2 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
    internal const string string_20 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject";
    internal const string string_21 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package";
    internal const string string_22 = "http://schemas.microsoft.com/office/2006/relationships/vbaProject";
    internal const string string_23 = "http://schemas.microsoft.com/office/2006/relationships/wordVbaData";
    internal const string string_24 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml";
    internal const string string_25 = "http://schemas.microsoft.com/office/2006/relationships/ui/extensibility";
    internal const string string_26 = "application/xml";
    internal const string string_27 = "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml";
    internal const string string_28 = "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml";
    internal const string string_29 = "application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml";
    internal const string string_3 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles";
    internal const string string_30 = "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml";
    internal const string string_31 = "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml";
    internal const string string_32 = "application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml";
    internal const string string_33 = "application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml";
    internal const string string_34 = "application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml";
    internal const string string_35 = "application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml";
    internal const string string_36 = "application/vnd.openxmlformats-package.relationships+xml";
    internal const string string_37 = "application/vnd.openxmlformats-officedocument.extended-properties+xml";
    internal const string string_38 = "application/vnd.openxmlformats-package.core-properties+xml";
    internal const string string_39 = "application/vnd.openxmlformats-officedocument.custom-properties+xml";
    internal const string string_4 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering";
    internal const string string_40 = "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml";
    internal const string string_41 = "application/vnd.openxmlformats-officedocument.drawingml.chart+xml";
    internal const string string_42 = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
    internal const string string_43 = "application/vnd.openxmlformats-officedocument.theme+xml";
    internal const string string_44 = "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml";
    internal const string string_45 = "application/vnd.ms-office.activeX+xml";
    internal const string string_46 = "application/vnd.ms-office.activeX";
    internal const string string_47 = "application/vnd.ms-office.vbaProject";
    internal const string string_48 = "application/vnd.ms-word.vbaData+xml";
    internal const string string_49 = "application/vnd.ms-word.document.macroEnabled.main+xml";
    internal const string string_5 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings";
    internal const string string_50 = "application/vnd.ms-word.template.macroEnabledTemplate.main+xml";
    internal const string string_51 = "application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml";
    internal const string string_52 = "application/vnd.openxmlformats-officedocument.customXmlProperties+xml";
    internal const string string_53 = "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml";
    internal const string string_54 = "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml";
    internal const string string_55 = "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml";
    internal const string string_56 = "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml";
    internal const string string_57 = "http://schemas.openxmlformats.org/package/2006/content-types";
    internal const string string_58 = "Relationships";
    internal const string string_59 = "Relationship";
    internal const string string_6 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header";
    internal const string string_60 = "Types";
    internal const string string_61 = "Type";
    internal const string string_62 = "Target";
    internal const string string_63 = "TargetMode";
    internal const string string_64 = "Id";
    internal const string string_65 = "xmlns";
    internal const string string_66 = "Default";
    internal const string string_67 = "Override";
    internal const string string_68 = "Extension";
    internal const string string_69 = "ContentType";
    internal const string string_7 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer";
    internal const string string_70 = "PartName";
    internal const string string_71 = "Properties";
    internal const string string_72 = "coreProperties";
    internal const string string_73 = "styles";
    internal const string string_74 = "style";
    internal const string string_75 = "tblStylePr";
    internal const string string_76 = "tblPr";
    internal const string string_77 = "trPr";
    internal const string string_78 = "tcPr";
    internal const string string_79 = "pPr";
    internal const string string_8 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes";
    internal const string string_80 = "rPr";
    internal const string string_81 = "w:hdr";
    internal const string string_82 = "w:ftr";
    internal const string string_83 = "w:headerReference";
    internal const string string_84 = "w:footerReference";
    internal const string string_85 = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
    internal const string string_86 = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing";
    internal const string string_87 = "http://schemas.openxmlformats.org/drawingml/2006/picture";
    internal const string string_88 = "http://schemas.openxmlformats.org/drawingml/2006/main";
    internal const string string_89 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships";
    internal const string string_9 = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes";
    internal const string string_90 = "http://schemas.openxmlformats.org/package/2006/relationships";
    internal const string string_91 = "urn:schemas-microsoft-com:vml";
    internal const string string_92 = "urn:schemas-microsoft-com:office:office";
    internal const string string_93 = "http://www.w3.org/XML/1998/namespace";
    internal const string string_94 = "urn:schemas-microsoft-com:office:word";
    internal const string string_95 = "http://schemas.openxmlformats.org/package/2006/metadata/core-properties";
    internal const string string_96 = "http://purl.org/dc/elements/1.1/";
    internal const string string_97 = "http://purl.org/dc/terms/";
    internal const string string_98 = "http://www.w3.org/2001/XMLSchema-instance";
    internal const string string_99 = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties";

    protected Class697()
    {
    }

    internal static XmlAttribute smethod_0(XmlNode A_0, string A_1, string A_2, string A_3)
    {
        string localName = A_1;
        XmlAttribute attribute = null;
        int num = 0;
        int count = A_0.ChildNodes.Count;
        while (num < count)
        {
            XmlNode node = A_0.ChildNodes[num];
            if (A_1 == null)
            {
                localName = node.LocalName;
            }
            if (((node.Attributes != null) && (node.Attributes.Count > 0)) && (node.LocalName == localName))
            {
                if (A_3 == null)
                {
                    attribute = node.Attributes[A_2];
                }
                else
                {
                    attribute = node.Attributes[A_2, A_3];
                }
                if (attribute != null)
                {
                    return attribute;
                }
            }
            if (node.ChildNodes.Count > 0)
            {
                attribute = smethod_0(node, A_1, A_2, A_3);
                if (attribute != null)
                {
                    return attribute;
                }
            }
            num++;
        }
        return attribute;
    }

    internal static XmlNode smethod_1(XmlNode A_0, string A_1)
    {
        int num = 0;
        int count = A_0.ChildNodes.Count;
        while (num < count)
        {
            XmlNode node = A_0.ChildNodes[num];
            if (node.LocalName == A_1)
            {
                return node;
            }
            if (node.ChildNodes.Count > 0)
            {
                node = smethod_1(node, A_1);
                if (node != null)
                {
                    return node;
                }
            }
            num++;
        }
        return null;
    }

    internal static string smethod_2(XmlNode A_0)
    {
        XmlAttribute attribute = smethod_0(A_0, null, BookmarkStart.b("張尷", 0x10), BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ幯ᵱٳᅵ坷ᕹ᩻᡽슅曆ﲑ릕ꪗꪙ겛ꢝ辟킡솣쪥즧\udea9\uc5ab솭\udeaf\uc1b1\udcb3\udfb5좷즹", 0x10));
        if (attribute != null)
        {
            return attribute.Value;
        }
        return null;
    }

    internal static List<string> smethod_3(XmlNode A_0)
    {
        int num = 11;
        XmlTextReader reader = new XmlTextReader(A_0.OuterXml, XmlNodeType.Element, null);
        reader.Read();
        List<string> list = new List<string>();
        while (true)
        {
            reader.Read();
            if ((reader.LocalName == BookmarkStart.b("地娲头嬶", num)) || (((((reader.LocalName == BookmarkStart.b("匰弲尴䜶", num)) || (reader.LocalName == BookmarkStart.b("䌰嘲头縶崸䠺", num))) || ((reader.LocalName == BookmarkStart.b("到嬲吴䔶䴸", num)) || (reader.LocalName == BookmarkStart.b("堰帲吴倶尸强尼䬾⁀", num)))) || ((reader.LocalName == BookmarkStart.b("䈰䜲䜴堶券帺", num)) || (reader.LocalName == BookmarkStart.b("到尲嬴䌶䬸吺儼", num)))) || (reader.LocalName == BookmarkStart.b("縰缲瀴砶嬸儺堼尾㕀", num))))
            {
                list = smethod_4(reader, list);
            }
            if (reader.EOF)
            {
                return list;
            }
        }
    }

    internal static List<string> smethod_4(XmlTextReader A_0, List<string> A_1)
    {
        int num = 4;
        string item = string.Empty;
        string attribute = string.Empty;
        string localName = A_0.LocalName;
        if (localName != null)
        {
            int num2;
            if (Class1160.dictionary_124 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                dictionary1.Add(BookmarkStart.b("䰩䔫䈭尯", num), 0);
                dictionary1.Add(BookmarkStart.b("䤩䐫伭䈯䘱", num), 1);
                dictionary1.Add(BookmarkStart.b("䌩䄫伭圯圱倳圵䰷嬹", num), 2);
                dictionary1.Add(BookmarkStart.b("天堫尭弯失儳", num), 3);
                dictionary1.Add(BookmarkStart.b("䤩䌫䀭䐯䀱嬳娵", num), 4);
                dictionary1.Add(BookmarkStart.b("攩怫欭缯倱帳匵嬷丹", num), 5);
                dictionary1.Add(BookmarkStart.b("䠩䀫䜭䀯", num), 6);
                dictionary1.Add(BookmarkStart.b("堩䤫䈭礯嘱䜳", num), 7);
                Class1160.dictionary_124 = dictionary1;
            }
            if (Class1160.dictionary_124.TryGetValue(localName, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        item = A_0.GetAttribute(BookmarkStart.b("䌩䠫", num), BookmarkStart.b("䈩堫娭䀯࠱ᬳᤵ䬷夹吻嬽ⴿ⍁㝃桅❇㩉⥋⁍⡏㽑㡓さ㝗⡙ㅛ㽝ᑟᅡ䩣॥ᩧ൩䍫ŭᙯᑱᵳᕵᵷ㹹፻ᵽﲇꖉ뺋뺍ꂏ꒑뮓ﶗﶛ즟춡쪣향삧쎩\udcab\uddad", num));
                        attribute = A_0.GetAttribute(BookmarkStart.b("䈩師䬭嘯", num), BookmarkStart.b("䈩堫娭䀯࠱ᬳᤵ䬷夹吻嬽ⴿ⍁㝃桅❇㩉⥋⁍⡏㽑㡓さ㝗⡙ㅛ㽝ᑟᅡ䩣॥ᩧ൩䍫ŭᙯᑱᵳᕵᵷ㹹፻ᵽﲇꖉ뺋뺍ꂏ꒑뮓ﶗﶛ즟춡쪣향삧쎩\udcab\uddad", num));
                        break;

                    case 6:
                        item = A_0.GetAttribute(BookmarkStart.b("伩䄫䰭唯嘱", num), BookmarkStart.b("䈩堫娭䀯࠱ᬳᤵ䬷夹吻嬽ⴿ⍁㝃桅❇㩉⥋⁍⡏㽑㡓さ㝗⡙ㅛ㽝ᑟᅡ䩣॥ᩧ൩䍫ŭᙯᑱᵳᕵᵷ㹹፻ᵽﲇꖉ뺋뺍ꂏ꒑뮓ﶗﶛ즟춡쪣향삧쎩\udcab\uddad", num));
                        break;

                    case 7:
                        smethod_5(A_0, A_1);
                        break;
                }
            }
        }
        if ((item != null) && (item != string.Empty))
        {
            A_1.Add(item);
        }
        if ((attribute != null) && (attribute != string.Empty))
        {
            A_1.Add(attribute);
        }
        return A_1;
    }

    internal static void smethod_5(XmlTextReader A_0, List<string> A_1)
    {
        int num = 0x12;
        string item = string.Empty;
        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {
                case 0:
                    item = A_0.GetAttribute(BookmarkStart.b("尷圹", num), BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ山᭳ѵί啹፻᡽첇ﮍﶏ望랗ꢙ겛꺝隟趡횣쎥쒧쮩\ud8ab\uc7ad\udfaf\udcb1잳\udeb5\ud1b7쪹쾻", num));
                    break;

                case 1:
                    item = A_0.GetAttribute(BookmarkStart.b("吷唹", num), BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ山᭳ѵί啹፻᡽첇ﮍﶏ望랗ꢙ겛꺝隟趡횣쎥쒧쮩\ud8ab\uc7ad\udfaf\udcb1잳\udeb5\ud1b7쪹쾻", num));
                    break;

                case 2:
                    item = A_0.GetAttribute(BookmarkStart.b("䤷䤹", num), BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ山᭳ѵί啹፻᡽첇ﮍﶏ望랗ꢙ겛꺝隟趡횣쎥쒧쮩\ud8ab\uc7ad\udfaf\udcb1잳\udeb5\ud1b7쪹쾻", num));
                    break;

                case 3:
                    item = A_0.GetAttribute(BookmarkStart.b("嬷䤹", num), BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ山᭳ѵί啹፻᡽첇ﮍﶏ望랗ꢙ겛꺝隟趡횣쎥쒧쮩\ud8ab\uc7ad\udfaf\udcb1잳\udeb5\ud1b7쪹쾻", num));
                    break;
            }
            if ((item != null) && (item != string.Empty))
            {
                A_1.Add(item);
            }
        }
    }

    internal static Stream smethod_6(XmlReader A_0)
    {
        string s = A_0.ReadOuterXml();
        return new MemoryStream(Encoding.UTF8.GetBytes(s));
    }
}

