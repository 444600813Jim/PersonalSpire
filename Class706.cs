using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;

internal class Class706
{
    protected const string string_0 = "Spire.Doc.Resources";
    private const string string_1 = "http://www.w3.org/2001/XMLSchema";
    private const string string_2 = "http://tempuri.org/DLSMetaSchema.xsd";
    private readonly string[] string_3 = new string[] { BookmarkStart.b("䄱䀳䐵儷吹嬻", 12), BookmarkStart.b("吱堳夵夷丹", 12), BookmarkStart.b("倱嬳夵吷弹崻倽", 12), BookmarkStart.b("嬱娳䈵", 12), BookmarkStart.b("嘱唳䈵崷丹唻匽┿", 12), BookmarkStart.b("倱唳䔵崷హ࠻簽⤿ⱁ╃㑅ㅇ", 12) };
    private XmlElement xmlElement_0;
    private XmlNamespaceManager xmlNamespaceManager_0;
    private XmlSchema xmlSchema_0;

    public XmlSchema method_0()
    {
        XmlDocument document = smethod_2(smethod_1(BookmarkStart.b("䴨䜪帬Ȯ尰嘲䄴嘶ᐸ䠺帼圾⑀⹂⑄楆ㅈ♊⅌", 3)));
        return this.method_1(document);
    }

    public XmlSchema method_1(XmlDocument A_0)
    {
        int num = 15;
        this.xmlNamespaceManager_0 = new XmlNamespaceManager(A_0.NameTable);
        this.xmlNamespaceManager_0.AddNamespace(BookmarkStart.b("場", 15), BookmarkStart.b("崴䌶䴸䬺ܼှ湀㝂⁄⩆㥈㹊㽌♎罐㱒❔ざ癘὚ᅜ౞Ⱡ٢ᅤ٦㩨ࡪլ੮ᱰቲ孴ྲྀ੸ὺ", 15));
        this.xmlElement_0 = A_0.DocumentElement;
        foreach (XmlNode node2 in this.xmlElement_0.SelectNodes(BookmarkStart.b("場ശ倸唺帼匾㑀❂⁄", 15), this.xmlNamespaceManager_0))
        {
            string str = node2.Attributes[BookmarkStart.b("嬴嘶吸帺", num)].Value;
            string str2 = node2.Attributes[BookmarkStart.b("嬴嘶吸帺丼伾⁀⁂⁄", num)].Value;
            XmlDocument document = smethod_2(this.vmethod_0(str, str2));
            this.method_8(A_0, document);
        }
        this.xmlSchema_0 = new XmlSchema();
        XmlElement element = this.xmlElement_0[BookmarkStart.b("場ശ䬸吺刼䬾", num)];
        XmlSchemaElement item = new XmlSchemaElement {
            Name = element.Attributes[BookmarkStart.b("嬴嘶吸帺", num)].Value,
            SchemaTypeName = new XmlQualifiedName(element.Attributes[BookmarkStart.b("䄴丶䤸帺", num)].Value)
        };
        this.xmlSchema_0.Items.Add(item);
        foreach (XmlNode node in this.xmlElement_0.SelectNodes(BookmarkStart.b("場ശ䴸䈺䴼娾", num), this.xmlNamespaceManager_0))
        {
            this.method_2(node);
        }
        return this.xmlSchema_0;
    }

    private void method_2(XmlNode A_0)
    {
        int num = 1;
        XmlAttribute attribute = A_0.Attributes[BookmarkStart.b("䨦䘨伪䠬", 1)];
        if (attribute != null)
        {
            string str = attribute.Value;
            if (str != null)
            {
                if (str != BookmarkStart.b("䐦䄨䐪䐬䰮吰", num))
                {
                    if (str != BookmarkStart.b("䀦嬨䐪堬弮堰崲刴", num))
                    {
                        if (str != BookmarkStart.b("䈦䜨帪䀬", num))
                        {
                            if (str != BookmarkStart.b("圦䠨弪夬䨮䌰崲", num))
                            {
                                if (str == BookmarkStart.b("否夨䨪丬䨮", num))
                                {
                                    this.method_3(A_0, ModeType.Space);
                                }
                            }
                            else
                            {
                                this.method_3(A_0, ModeType.Pattern);
                            }
                        }
                        else
                        {
                            this.method_3(A_0, ModeType.Enum);
                        }
                    }
                    else
                    {
                        this.method_4(new XmlSchemaSequence(), A_0, true);
                    }
                }
                else
                {
                    this.method_4(new XmlSchemaChoice(), A_0, false);
                }
            }
        }
        else
        {
            this.method_4(new XmlSchemaChoice(), A_0, false);
        }
    }

    private void method_3(XmlNode A_0, ModeType A_1)
    {
        int num = 5;
        XmlSchemaSimpleType item = new XmlSchemaSimpleType {
            Name = A_0.Attributes[BookmarkStart.b("䔪䰬䈮吰", 5)].Value
        };
        XmlSchemaSimpleTypeRestriction restriction = new XmlSchemaSimpleTypeRestriction {
            BaseTypeName = new XmlQualifiedName(BookmarkStart.b("堪夬崮堰崲刴", 5), BookmarkStart.b("䌪夬嬮䄰लᨴᠶ丸䰺䨼ᄾ㙀灂歄⡆㭈ⱊ扌絎慐捒摔硖Řᙚᅜ౞ɠୢd੦ࡨ", 5))
        };
        item.Content = restriction;
        switch (A_1)
        {
            case ModeType.Enum:
                foreach (XmlNode node2 in A_0.SelectNodes(BookmarkStart.b("䘪ᜬ䨮弰䘲場", num), this.xmlNamespaceManager_0))
                {
                    XmlSchemaEnumerationFacet facet2 = new XmlSchemaEnumerationFacet {
                        Value = node2.Attributes[BookmarkStart.b("崪䰬䌮䐰嘲", num)].Value
                    };
                    restriction.Facets.Add(facet2);
                }
                break;

            case ModeType.Pattern:
            {
                XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("䘪ᜬ弮倰䜲䄴制䬸唺", num), this.xmlNamespaceManager_0);
                XmlSchemaPatternFacet facet = new XmlSchemaPatternFacet {
                    Value = node.Attributes[BookmarkStart.b("崪䰬䌮䐰嘲", num)].Value
                };
                restriction.Facets.Add(facet);
                break;
            }
            case ModeType.Space:
            {
                XmlNode node3 = A_0.SelectSingleNode(BookmarkStart.b("䘪ᜬ堮夰娲䄴制䨸䬺尼尾⑀", num), this.xmlNamespaceManager_0);
                XmlSchemaWhiteSpaceFacet facet3 = new XmlSchemaWhiteSpaceFacet {
                    Value = node3.Attributes[BookmarkStart.b("崪䰬䌮䐰嘲", num)].Value
                };
                restriction.Facets.Add(facet3);
                break;
            }
        }
        this.xmlSchema_0.Items.Add(item);
    }

    private void method_4(XmlSchemaGroupBase A_0, XmlNode A_1, bool A_2)
    {
        int num = 8;
        XmlSchemaComplexType item = new XmlSchemaComplexType {
            Name = A_1.Attributes[BookmarkStart.b("䀭儯弱儳", 8)].Value
        };
        if (A_2)
        {
            string name = item.Name + BookmarkStart.b("椭䈯崱䄳䘵", num);
            XmlSchemaGroupRef ref2 = new XmlSchemaGroupRef {
                RefName = new XmlQualifiedName(name)
            };
            item.Particle = ref2;
            XmlSchemaGroup group = new XmlSchemaGroup {
                Name = name,
                Particle = A_0
            };
            this.xmlSchema_0.Items.Add(group);
        }
        else
        {
            item.Particle = A_0;
            item.Particle.MaxOccursString = BookmarkStart.b("嬭帯倱嬳䌵嘷帹夻娽", num);
            item.Particle.MinOccurs = 0M;
        }
        this.xmlSchema_0.Items.Add(item);
        foreach (XmlNode node4 in A_1.SelectNodes(BookmarkStart.b("䌭ਯ圱堳匵唷弹刻䨽", num), this.xmlNamespaceManager_0))
        {
            this.method_5(node4, A_0);
        }
        foreach (XmlNode node in A_1.SelectNodes(BookmarkStart.b("䌭ਯ唱䘳夵䴷䨹", num), this.xmlNamespaceManager_0))
        {
            XmlAttribute attribute = node.Attributes[BookmarkStart.b("尭唯吱", num)];
            if (attribute != null)
            {
                XmlNode node2 = this.xmlElement_0.SelectSingleNode(BookmarkStart.b("䌭ਯ唱䘳夵䴷䨹朻總⸿⍁⥃⍅畇浉", num) + attribute.Value + BookmarkStart.b("भ洯", num), this.xmlNamespaceManager_0);
                this.method_6(node2, A_0);
            }
            else
            {
                this.method_6(node, A_0);
            }
        }
        XmlSchemaObjectCollection attributes = item.Attributes;
        if (A_2)
        {
            string str2 = item.Name + BookmarkStart.b("漭䐯䘱䘳焵䨷唹䤻丽", num);
            XmlSchemaAttributeGroupRef ref3 = new XmlSchemaAttributeGroupRef {
                RefName = new XmlQualifiedName(str2)
            };
            item.Attributes.Add(ref3);
            XmlSchemaAttributeGroup group2 = new XmlSchemaAttributeGroup {
                Name = str2
            };
            this.xmlSchema_0.Items.Add(group2);
            attributes = group2.Attributes;
        }
        foreach (XmlNode node3 in A_1.SelectNodes(BookmarkStart.b("䌭ਯ匱䀳䈵䨷匹帻䬽㐿❁", num), this.xmlNamespaceManager_0))
        {
            this.method_7(node3, attributes);
        }
        XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
            Name = BookmarkStart.b("䜭启", num),
            SchemaTypeName = new XmlQualifiedName(BookmarkStart.b("䜭帯䘱", num), BookmarkStart.b("䘭䐯䘱䐳వ᜷ᔹ䬻䤽㜿汁㍃畅晇╉㹋⥍罏恑摓晕楗留ћ፝ⱟㅡݣ๥൧ݩ൫", num))
        };
        item.Attributes.Add(attribute2);
    }

    private void method_5(XmlNode A_0, XmlSchemaGroupBase A_1)
    {
        int num = 5;
        XmlSchemaElement item = new XmlSchemaElement {
            Name = A_0.Attributes[BookmarkStart.b("䔪䰬䈮吰", 5)].Value
        };
        XmlAttribute attribute = A_0.Attributes[BookmarkStart.b("弪听弮吰", 5)];
        if (this.string_3.Contains(attribute.Value))
        {
            item.SchemaTypeName = new XmlQualifiedName(attribute.Value, BookmarkStart.b("䌪夬嬮䄰लᨴᠶ丸䰺䨼ᄾ㙀灂歄⡆㭈ⱊ扌絎慐捒摔硖Řᙚᅜ౞ɠୢd੦ࡨ", num));
        }
        else
        {
            item.SchemaTypeName = new XmlQualifiedName(attribute.Value);
        }
        A_1.Items.Add(item);
    }

    private void method_6(XmlNode A_0, XmlSchemaGroupBase A_1)
    {
        XmlSchemaElement item = new XmlSchemaElement {
            Name = A_0.Attributes[BookmarkStart.b("崲吴娶尸", 13)].Value
        };
        A_1.Items.Add(item);
        XmlSchemaComplexType type = new XmlSchemaComplexType();
        item.SchemaType = type;
        XmlSchemaSequence sequence = new XmlSchemaSequence();
        type.Particle = sequence;
        type.Particle.MaxOccursString = BookmarkStart.b("䘲嬴唶嘸为匼嬾⑀❂", 13);
        type.Particle.MinOccurs = 0M;
        XmlSchemaElement element2 = new XmlSchemaElement {
            Name = A_0.Attributes[BookmarkStart.b("娲䄴制吸", 13)].Value,
            SchemaTypeName = new XmlQualifiedName(A_0.Attributes[BookmarkStart.b("䜲䰴䜶尸", 13)].Value)
        };
        sequence.Items.Add(element2);
    }

    private void method_7(XmlNode A_0, XmlSchemaObjectCollection A_1)
    {
        int num = 7;
        XmlSchemaAttribute item = new XmlSchemaAttribute {
            Name = A_0.Attributes[BookmarkStart.b("䌬丮尰嘲", 7)].Value
        };
        XmlAttribute attribute2 = A_0.Attributes[BookmarkStart.b("夬嘮䄰嘲", 7)];
        XmlAttribute attribute3 = A_0.Attributes[BookmarkStart.b("䬬䘮䤰嘲儴", 7)];
        if (this.string_3.Contains(attribute2.Value))
        {
            item.SchemaTypeName = new XmlQualifiedName(attribute2.Value, BookmarkStart.b("䔬嬮䔰䌲༴ᠶᘸ䰺䨼䠾潀㑂癄楆♈㥊⩌恎捐捒敔晖癘͚ၜ፞㉠b൤ɦѨ੪", num));
        }
        else
        {
            item.SchemaTypeName = new XmlQualifiedName(attribute2.Value);
        }
        if (attribute3 != null)
        {
            item.FixedValue = attribute3.Value;
        }
        A_1.Add(item);
    }

    private void method_8(XmlDocument A_0, XmlDocument A_1)
    {
        this.method_9(A_1, A_0, BookmarkStart.b("䔧ဩ堫圭䀯圱", 2));
        this.method_9(A_1, A_0, BookmarkStart.b("䔧ဩ䬫尭弯䜱䐳", 2));
    }

    private void method_9(XmlDocument A_0, XmlDocument A_1, string A_2)
    {
        int num = 0x13;
        foreach (XmlNode node in A_0.DocumentElement.SelectNodes(A_2, this.xmlNamespaceManager_0))
        {
            string str = node.Attributes[BookmarkStart.b("圸娺值娾", num)].Value;
            XmlNode node2 = A_1.DocumentElement.SelectSingleNode(A_2 + BookmarkStart.b("戸笺匼帾ⱀ♂硄恆", num) + str + BookmarkStart.b("Ḹ昺", num), this.xmlNamespaceManager_0);
            if (node2 == null)
            {
                XmlNode node3 = A_1.CreateNode(XmlNodeType.Element, BookmarkStart.b("䴸帺值伾", num), string.Empty);
                node3.InnerXml = node.OuterXml;
                A_1.DocumentElement.AppendChild(node3.FirstChild);
            }
            else
            {
                string innerXml = node2.InnerXml;
                node2.InnerXml = innerXml + node.InnerXml;
            }
        }
    }

    public static XmlSchema smethod_0()
    {
        return XmlSchema.Read(smethod_1(BookmarkStart.b("伪䄬尮ᰰ䀲嘴弶尸嘺尼ᄾ㥀あ⅄", 5)), new ValidationEventHandler(Class706.smethod_3));
    }

    protected static Stream smethod_1(string A_0)
    {
        return Assembly.GetExecutingAssembly().GetManifestResourceStream(BookmarkStart.b("怲䔴帶䬸帺ጼ笾⹀⁂歄ᕆⱈ㡊≌㩎⍐げご⑖睘", 13) + A_0);
    }

    protected static XmlDocument smethod_2(Stream A_0)
    {
        string xml = new StreamReader(A_0).ReadToEnd();
        XmlDocument document = new XmlDocument();
        document.LoadXml(xml);
        return document;
    }

    protected static void smethod_3(object sender, ValidationEventArgs e)
    {
        throw new DLSException(e.Message);
    }

    protected virtual Stream vmethod_0(string A_0, string A_1)
    {
        if (A_1 == BookmarkStart.b("缫席夯䀱儳ᠵ簷唹弻ွпแᝃ", 6))
        {
            return smethod_1(A_0);
        }
        return null;
    }
}

