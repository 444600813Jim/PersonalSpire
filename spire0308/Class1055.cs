using Spire.Doc;
using Spire.Doc.Documents.Converters.Encryption;
using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Xml;

internal class Class1055
{
    private readonly Class740 class740_0;
    private const string string_0 = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
    private const string string_1 = "http://schemas.openxmlformats.org/package/2006/RelationshipTransform";
    private readonly TransformType transformType_0;

    internal Class1055(Class393 A_0)
    {
        int num = 0x13;
        this.class740_0 = Class740.smethod_1();
        string str2 = A_0.method_12(BookmarkStart.b("砸场娼倾㍀⩂ㅄ⽆⑈", 0x13), null);
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("儸伺䤼伾筀求橄う㹈㱊捌㡎扐絒㩔╖㹘瑚ड़൞习兢啤坦塨䑪㽬⩮㉰干൴᩶ᕸ噺Ṽ乾떀ꢄ떆릈뮊벌뾎ꊐꊒꂔ", num))
            {
                this.transformType_0 = TransformType.C14n;
                return;
            }
            if (str2 == BookmarkStart.b("儸伺䤼伾筀求橄㑆⩈⍊⡌≎ぐ⁒答㡖⥘㹚㍜❞ౠརͤࡦ᭨٪౬᭮ɰ嵲ᩴնṸ呺ർṾꒊ뾌뾎ꆐꖒ몔얖ﲘﲜ좠첢쮤풦솨슪\uddac\ufbae쎰튲\udbb4\uc4b6\udfb8\ud4ba쾼튾", num))
            {
                this.transformType_0 = TransformType.Relationship;
                while (A_0.method_9(BookmarkStart.b("洸䤺尼儾㉀╂⩄㕆⑈", num)))
                {
                    if (A_0.method_1() == BookmarkStart.b("欸帺儼帾㕀⩂⩄⥆㩈⍊⑌㽎͐㙒㍔㉖⭘㹚㍜㱞Ѡ", num))
                    {
                        this.class740_0.Interface34.imethod_1(A_0.method_12(BookmarkStart.b("樸吺䠼䴾≀♂ౄ⍆", num), null));
                    }
                }
                return;
            }
        }
        this.transformType_0 = TransformType.Unknown;
    }

    internal MemoryStream method_0(Stream A_0)
    {
        int num = 6;
        MemoryStream outStream = null;
        A_0.Position = 0L;
        switch (this.transformType_0)
        {
            case TransformType.C14n:
            {
                XmlDsigC14NTransform transform = new XmlDsigC14NTransform();
                transform.LoadInput(A_0);
                return (MemoryStream) transform.GetOutput(typeof(MemoryStream));
            }
            case TransformType.Relationship:
            {
                XmlDocument document = this.method_1(A_0);
                A_0.Position = 0L;
                XmlDocument document2 = this.method_1(A_0);
                XmlNode node = document2.GetElementsByTagName(BookmarkStart.b("縫䬭尯匱䀳張圷吹伻嘽⤿㉁㝃", num))[0];
                node.RemoveAll();
                using (IEnumerator enumerator = this.class740_0.System.Collections.IEnumerable.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        string current = (string) enumerator.Current;
                        XmlNode node2 = document.SelectSingleNode(string.Format(BookmarkStart.b("̫ĭᨯ椱琳缵尷ܹᬻ䔽瀿㽁捃ᭅ", num), current));
                        XmlAttribute attribute = node2.OwnerDocument.CreateAttribute(BookmarkStart.b("砫伭䈯唱儳䈵男唹堻嬽", num));
                        attribute.Value = BookmarkStart.b("攫䀭䐯圱䘳堵夷嘹", num);
                        node2.Attributes.Append(attribute);
                        XmlNode newChild = document2.ImportNode(node2, true);
                        node.AppendChild(newChild);
                    }
                }
                outStream = new MemoryStream();
                document2.Save(outStream);
                return outStream;
            }
        }
        return outStream;
    }

    private XmlDocument method_1(Stream A_0)
    {
        XmlDocument document = new XmlDocument {
            PreserveWhitespace = true
        };
        document.Load(A_0);
        return document;
    }
}

