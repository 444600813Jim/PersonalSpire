using Spire.Doc;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

internal class Class804
{
    private bool bool_0;
    private bool bool_1;
    private Class806 class806_0 = new Class806();
    private Document document_0;
    private int[] int_0;
    private int int_1;
    private const string string_0 = "Spire.Doc.Resources.word2ml.xslt";
    private const string string_1 = "sections";
    private const string string_10 = "headers-footers";
    private const string string_11 = "items";
    private const string string_12 = "item";
    private const string string_13 = "wordml://{0}_{1}.png";
    private const string string_14 = "BreakCode";
    private const string string_15 = "NoBreak";
    private const string string_16 = "NewPage";
    private const string string_17 = "True";
    private const string string_18 = "type";
    private const string string_19 = "Table";
    private const string string_2 = "{0}/{1}";
    private const string string_20 = "Picture";
    private const string string_21 = "BookmarkStart";
    private const string string_22 = "BookmarkEnd";
    private const string string_3 = "section";
    private const string string_4 = "body";
    private const string string_5 = "paragraphs";
    private const string string_6 = "paragraph";
    private const string string_7 = "builtin-properties";
    private const string string_8 = "page-setup";
    private const string string_9 = "columns";
    private XmlDocument xmlDocument_0 = new XmlDocument();

    public void method_0(IDocument A_0, string A_1)
    {
        XslTransform transform = new XslTransform();
        transform.Load(smethod_0(), null, null);
        MemoryStream stream = new MemoryStream();
        this.document_0 = (Document) A_0;
        A_0.SaveToFile(stream, FileFormat.Xml);
        stream.Position = 0L;
        this.xmlDocument_0.Load(stream);
        this.method_2();
        XmlTextWriter writer = new XmlTextWriter(A_1, Encoding.UTF8);
        transform.Transform((IXPathNavigable) this.xmlDocument_0, null, (XmlWriter) writer, null);
        writer.Close();
    }

    public void method_1(IDocument A_0, Stream A_1)
    {
        XslTransform transform = new XslTransform();
        transform.Load(smethod_0(), null, null);
        MemoryStream stream = new MemoryStream();
        this.document_0 = (Document) A_0;
        A_0.SaveToFile(stream, FileFormat.Xml);
        stream.Position = 0L;
        this.xmlDocument_0.Load(stream);
        this.method_2();
        XmlTextWriter writer = new XmlTextWriter(A_1, Encoding.UTF8);
        transform.Transform((IXPathNavigable) this.xmlDocument_0, null, (XmlWriter) writer, null);
        writer.Close();
    }

    private byte[] method_10(XmlNode A_0)
    {
        XmlTextReader reader = new XmlTextReader(new StringReader(A_0.OuterXml));
        reader.Read();
        int length = 0;
        byte[] buffer = new byte[0];
        byte[] array = new byte[0x3e8];
    Label_0041:
        length = reader.ReadBase64(array, 0, array.Length);
        byte[] buffer3 = new byte[buffer.Length + length];
        buffer.CopyTo(buffer3, 0);
        Array.Copy(array, 0, buffer3, buffer.Length, length);
        buffer = buffer3;
        if (length >= array.Length)
        {
            array = new byte[buffer.Length * 2];
            if (reader.EOF)
            {
                return buffer;
            }
            goto Label_0041;
        }
        return buffer;
    }

    private Image method_11(XmlNode A_0, bool A_1)
    {
        byte[] buffer = this.method_10(A_0);
        Image image = null;
        if (buffer.Length <= 0)
        {
            return image;
        }
        MemoryStream stream = new MemoryStream(buffer);
        if (A_1)
        {
            return new Metafile(stream);
        }
        return new Bitmap(stream);
    }

    private void method_2()
    {
        this.method_3();
        this.method_8();
    }

    private void method_3()
    {
        int num = 5;
        XmlNodeList list = this.xmlDocument_0.DocumentElement.SelectNodes(string.Format(BookmarkStart.b("倪ᴬ刮Ḱ䠲д䨶", 5), BookmarkStart.b("堪䠬䰮䔰娲娴夶䨸", 5), BookmarkStart.b("堪䠬䰮䔰娲娴夶", 5)));
        int index = 0;
        this.int_0 = new int[list.Count];
        foreach (XmlNode node2 in list)
        {
            this.int_0[index] = 0;
            if ((node2.Attributes[BookmarkStart.b("椪弬䨮倰堲瘴堶崸帺", num)] != null) && (node2.Attributes[BookmarkStart.b("椪弬䨮倰堲瘴堶崸帺", num)].InnerText == BookmarkStart.b("攪䈬洮䌰嘲吴尶", num)))
            {
                this.int_0[index] = 1;
            }
            index++;
        }
        index = 1;
        foreach (XmlNode node in list)
        {
            this.method_4(node, list.Count, index);
            index++;
        }
    }

    private void method_4(XmlNode A_0, int A_1, int A_2)
    {
        int num = 2;
        if (A_0.Attributes[BookmarkStart.b("樧堩䤫伭嬯焱嬳刵崷", 2)] != null)
        {
            this.bool_0 = A_0.Attributes[BookmarkStart.b("樧堩䤫伭嬯焱嬳刵崷", num)].InnerText == BookmarkStart.b("昧伩嬫縭儯唱儳", num);
        }
        if (this.int_0[A_2 - 1] == 1)
        {
            this.bool_0 = true;
        }
        if ((A_1 == 1) || (A_2 == A_1))
        {
            this.bool_0 = false;
        }
        XmlAttribute attribute3 = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("砧堩䌫席礯就焳堵尷樹崻䰽", num));
        attribute3.InnerText = this.bool_0.ToString();
        A_0.Attributes.Append(attribute3);
        XmlNode node5 = A_0.SelectSingleNode(BookmarkStart.b("䨧䔩䠫圭", num)).SelectSingleNode(BookmarkStart.b("堧䬩師伭圯䀱唳䘵倷䤹", num));
        XmlNode oldChild = A_0.SelectSingleNode(BookmarkStart.b("堧䬩䬫䬭ᴯ䄱儳䈵䴷䨹", num));
        XmlNode node4 = A_0.SelectSingleNode(BookmarkStart.b("䬧䔩䀫嬭崯就䜳", num));
        XmlNode node3 = A_0.SelectSingleNode(BookmarkStart.b("䀧伩䴫䨭唯䀱䜳ᬵ帷唹医䨽┿ぁ㝃", num));
        if (node5 != null)
        {
            foreach (XmlNode node in node5.ChildNodes)
            {
                this.method_5(node);
            }
        }
        if (this.bool_0)
        {
            XmlElement newChild = this.xmlDocument_0.CreateElement(BookmarkStart.b("䄧帩䤫䌭", num));
            XmlAttribute attribute = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("尧匩尫䬭", num));
            attribute.InnerText = BookmarkStart.b("砧䬩師伭圯䀱唳䘵倷", num);
            XmlAttribute attribute2 = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("笧䤩堫縭䈯䈱", num));
            attribute2.InnerText = BookmarkStart.b("簧堩夫䬭", num);
            newChild.Attributes.Append(attribute);
            newChild.Attributes.Append(attribute2);
            if (this.int_0[A_2 - 1] == 1)
            {
                newChild.SetAttribute(BookmarkStart.b("欧䔩䈫娭夯就䄳匵", num), BookmarkStart.b("簧堩夫䬭", num));
            }
            newChild.AppendChild(oldChild.Clone());
            newChild.AppendChild(node3.Clone());
            if (node4 != null)
            {
                newChild.AppendChild(node4.Clone());
                node4.ParentNode.RemoveChild(node4);
            }
            node5.AppendChild(newChild);
            oldChild.ParentNode.RemoveChild(oldChild);
            node3.ParentNode.RemoveChild(node3);
        }
    }

    private void method_5(XmlNode A_0)
    {
        int num = 7;
        if (A_0.ChildNodes.Count > 0)
        {
            XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("崬丮䌰刲刴䔶堸䬺唼ሾ❀ⱂ㝄⩆⡈㽊", num));
            if (((node != null) && (node.Attributes.Count > 0)) && (node.Attributes[BookmarkStart.b("紬丮嘰嘲眴䔶尸娺嘼績❀㝂⁄㕆", num)] != null))
            {
                this.bool_1 = node.Attributes[BookmarkStart.b("紬丮嘰嘲眴䔶尸娺嘼績❀㝂⁄㕆", num)].InnerText == BookmarkStart.b("礬崮䐰嘲", num).ToLower();
            }
        }
        if (A_0.Attributes[BookmarkStart.b("夬嘮䄰嘲", num)].Value == BookmarkStart.b("礬丮匰弲倴", num))
        {
            this.method_6(A_0);
        }
        XmlNode node2 = A_0.SelectSingleNode(BookmarkStart.b("䐬嬮吰帲䘴", num));
        if (node2 != null)
        {
            this.method_7(node2);
        }
        if (this.bool_1)
        {
            XmlAttribute attribute = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("漬崮吰刲帴甶尸崺刼䴾⑀", num));
            attribute.InnerText = BookmarkStart.b("礬崮䐰嘲", num);
            A_0.Attributes.Append(attribute);
            this.bool_1 = false;
        }
    }

    private void method_6(XmlNode A_0)
    {
        Class810 class2 = new Class810();
        class2.method_0(A_0);
        class2.method_1();
    }

    private void method_7(XmlNode A_0)
    {
        int num = 3;
        foreach (XmlNode node in A_0.SelectNodes(BookmarkStart.b("䀨弪䠬䈮", 3)))
        {
            string str;
            if ((node.Attributes[BookmarkStart.b("崨刪崬䨮", num)] != null) && ((str = node.Attributes[BookmarkStart.b("崨刪崬䨮", num)].InnerText) != null))
            {
                if (str != BookmarkStart.b("礨䈪丬嬮䐰䄲倴", num))
                {
                    if (str != BookmarkStart.b("欨䐪䈬䐮尰刲䜴尶樸伺尼䴾㕀", num))
                    {
                        if (!(str == BookmarkStart.b("欨䐪䈬䐮尰刲䜴尶簸唺夼", num)))
                        {
                            if (str == BookmarkStart.b("欨太䠬丮娰", num))
                            {
                                this.bool_1 = true;
                            }
                        }
                        else
                        {
                            string str2 = this.class806_0.method_0(node.Attributes[BookmarkStart.b("欨䐪䈬䐮尰刲䜴尶眸娺值娾", num)].InnerText);
                            XmlAttribute attribute = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("䬨䐪䈬䐮尰刲䜴尶瀸缺", num));
                            attribute.InnerText = str2.ToString();
                            node.Attributes.Append(attribute);
                        }
                    }
                    else
                    {
                        int num2 = this.class806_0.method_2(node.Attributes[BookmarkStart.b("欨䐪䈬䐮尰刲䜴尶眸娺值娾", num)].InnerText);
                        XmlAttribute attribute2 = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("䬨䐪䈬䐮尰刲䜴尶瀸缺", num));
                        attribute2.InnerText = num2.ToString();
                        node.Attributes.Append(attribute2);
                    }
                }
                else
                {
                    this.method_9(node);
                }
            }
        }
    }

    private void method_8()
    {
        int num = 0;
        XmlNode node = this.xmlDocument_0.DocumentElement.SelectSingleNode(BookmarkStart.b("䐥崧䌩䀫娭夯就ᤳ䘵䨷唹䰻嬽㈿㙁ⵃ⍅㭇", 0));
        XmlAttribute attribute1 = node.Attributes[BookmarkStart.b("挥䰧䌩堫稭夯弱儳", 0)];
        if (node.Attributes[BookmarkStart.b("戥䜧䤩缫䬭匯䜱䘳張䰷䌹", 0)] != null)
        {
            int num2 = 8;
            if (node.Attributes[BookmarkStart.b("戥䜧䤩缫䬭匯䜱䘳張䰷䌹", num)].InnerText == num2.ToString())
            {
                XmlNode node2 = this.xmlDocument_0.SelectSingleNode(BookmarkStart.b("椥攧昩", num));
                XmlAttribute attribute = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("瘥娧䔩堫䬭匯䘱崳夵嘷渹䔻丽┿", num));
                attribute.InnerText = BookmarkStart.b("朥䐧䘩䌫夭缯就堳伵笷唹儻匽┿ⱁぃ㕅", num);
                node2.Attributes.Append(attribute);
            }
        }
    }

    private void method_9(XmlNode A_0)
    {
        int num = 5;
        NumberFormatInfo provider = new NumberFormatInfo {
            CurrencyDecimalSeparator = BookmarkStart.b("Ԫ", 5)
        };
        double num2 = 0.0;
        double num3 = 0.0;
        XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("䈪䀬丮嘰嘲", 5));
        bool flag = A_0.Attributes[BookmarkStart.b("截帬戮吰䜲吴儶倸场堼", 5)].InnerText == BookmarkStart.b("缪弬娮吰", 5).ToLower();
        XmlAttribute attribute = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("攪䰬䈮吰", 5));
        attribute.InnerText = string.Format(BookmarkStart.b("尪䈬崮唰帲头ശᘸᐺ䘼༾㱀᱂㹄癆㑈敊㵌ⅎ㙐", 5), this.int_1, flag ? BookmarkStart.b("䘪", num) : BookmarkStart.b("䐪", num));
        A_0.Attributes.Append(attribute);
        string str2 = string.Empty;
        Image image = null;
        if (node != null)
        {
            image = this.method_11(node, flag);
        }
        if (A_0.Attributes[BookmarkStart.b("尪䐬䬮䔰嬲", num)] != null)
        {
            num2 = Convert.ToDouble(A_0.Attributes[BookmarkStart.b("尪䐬䬮䔰嬲", num)].InnerText, provider);
        }
        if (((image != null) && (A_0.Attributes[BookmarkStart.b("簪䐬䬮䔰嬲昴吶堸场堼", num)] != null)) && !flag)
        {
            num2 = (Convert.ToDouble(A_0.Attributes[BookmarkStart.b("簪䐬䬮䔰嬲昴吶堸场堼", num)].InnerText, provider) / 100.0) * image.Width;
        }
        str2 = str2 + string.Format(BookmarkStart.b("尪䐬䬮䔰嬲༴᜶䈸଺䀼о", num), num2);
        if (A_0.Attributes[BookmarkStart.b("䌪䠬䘮嘰嬲䄴", num)] != null)
        {
            num3 = Convert.ToDouble(A_0.Attributes[BookmarkStart.b("䌪䠬䘮嘰嬲䄴", num)].InnerText, provider);
        }
        if (((image != null) && (A_0.Attributes[BookmarkStart.b("挪䠬䘮嘰嬲䄴搶娸娺儼娾", num)] != null)) && !flag)
        {
            num3 = (Convert.ToDouble(A_0.Attributes[BookmarkStart.b("挪䠬䘮嘰嬲䄴搶娸娺儼娾", num)].InnerText, provider) / 100.0) * image.Height;
        }
        str2 = str2 + string.Format(BookmarkStart.b("䌪䠬䘮嘰嬲䄴ശᤸ䀺഼䈾", num), num3);
        XmlAttribute attribute2 = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("堪夬嘮崰嘲", num));
        attribute2.InnerText = str2;
        A_0.Attributes.Append(attribute2);
        this.int_1++;
    }

    private static XmlReader smethod_0()
    {
        return new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(BookmarkStart.b("縬弮堰䄲倴ᤶ紸吺帼ᄾፀ♂㙄⡆㱈㥊⹌⩎≐絒≔㡖⭘㽚潜㉞ൠ䵢ᵤᑦըὪ", 7)));
    }

    internal class Class805
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
    internal class Class806 : List<Class804.Class805>
    {
        private int int_0;

        public string method_0(string A_0)
        {
            string str = string.Empty;
            using (List<Class804.Class805>.Enumerator enumerator = base.GetEnumerator())
            {
                Class804.Class805 current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.method_0() == A_0)
                    {
                        goto Label_0031;
                    }
                }
                return str;
            Label_0031:
                str = current.method_2();
            }
            return str;
        }

        public int method_1(Class804.Class805 A_0)
        {
            A_0.method_3(this.int_0.ToString());
            this.int_0++;
            base.Add(A_0);
            return (this.int_0 - 1);
        }

        public int method_2(string A_0)
        {
            Class804.Class805 item = new Class804.Class805();
            item.method_1(A_0);
            item.method_3(this.int_0.ToString());
            this.int_0++;
            base.Add(item);
            return (this.int_0 - 1);
        }
    }

    internal class Class807
    {
        private double double_0;

        public Class807()
        {
        }

        public Class807(double A_0)
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

    internal class Class808 : List<Class804.Class807>
    {
        public int method_0(Class804.Class807 A_0)
        {
            base.Add(A_0);
            return (base.Count - 1);
        }

        public int method_1(double A_0)
        {
            return this.method_0(new Class804.Class807(A_0));
        }

        public double method_2(double A_0)
        {
            double num2;
            double num = 0.0;
            using (List<Class804.Class807>.Enumerator enumerator = base.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class804.Class807 current = enumerator.Current;
                    num += current.method_0();
                    if (num > A_0)
                    {
                        goto Label_0034;
                    }
                }
                return 0.0;
            Label_0034:
                num2 = num - A_0;
            }
            return num2;
        }

        public int method_3(double A_0, double A_1)
        {
            int num3;
            int num = 1;
            double num2 = 0.0;
            using (List<Class804.Class807>.Enumerator enumerator = base.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class804.Class807 current = enumerator.Current;
                    num2 += current.method_0();
                    if (A_1 == num2)
                    {
                        goto Label_0040;
                    }
                    if (num2 > A_0)
                    {
                        num++;
                    }
                }
                return (num - 1);
            Label_0040:
                num3 = num;
            }
            return num3;
        }
    }

    internal class Class809 : List<Class804.Class808>
    {
        public int method_0(Class804.Class808 A_0)
        {
            int count = A_0.Count;
            base.Add(A_0);
            return count;
        }
    }

    internal class Class810
    {
        private Class804.Class808 class808_0 = new Class804.Class808();
        private Class804.Class809 class809_0 = new Class804.Class809();
        private NumberFormatInfo numberFormatInfo_0 = new NumberFormatInfo();
        private XmlNode xmlNode_0;

        public Class810()
        {
            this.numberFormatInfo_0.CurrencyDecimalSeparator = BookmarkStart.b("ᤶ", 0x11);
        }

        public void method_0(XmlNode A_0)
        {
            int num = 5;
            this.xmlNode_0 = A_0;
            XmlNodeList list = this.xmlNode_0.SelectNodes(string.Format(BookmarkStart.b("倪ᴬ刮Ḱ䠲д䨶", 5), BookmarkStart.b("太䈬堮䈰", 5), BookmarkStart.b("太䈬堮", 5)));
            if (list.Count > 0)
            {
                foreach (XmlNode node in list)
                {
                    XmlNodeList list2 = node.SelectNodes(string.Format(BookmarkStart.b("倪ᴬ刮Ḱ䠲д䨶", num), BookmarkStart.b("䠪䠬䌮崰䀲", num), BookmarkStart.b("䠪䠬䌮崰", num)));
                    if (list2.Count > 0)
                    {
                        Class804.Class808 class2 = new Class804.Class808();
                        foreach (XmlNode node2 in list2)
                        {
                            if (node2.Attributes[BookmarkStart.b("簪䐬䬮䔰嬲", num)] != null)
                            {
                                class2.method_1(Convert.ToDouble(node2.Attributes[BookmarkStart.b("簪䐬䬮䔰嬲", num)].InnerText, this.numberFormatInfo_0));
                            }
                        }
                        this.class809_0.method_0(class2);
                    }
                }
            }
        }

        public void method_1()
        {
            int num = 13;
            this.method_2();
            XmlElement newChild = this.xmlNode_0.OwnerDocument.CreateElement(BookmarkStart.b("䜲圴嬶縸䤺吼嬾", 13));
            foreach (Class804.Class807 class2 in this.class808_0)
            {
                XmlElement element2 = this.xmlNode_0.OwnerDocument.CreateElement(BookmarkStart.b("吲䜴帶崸砺刼匾", num));
                element2.SetAttribute(BookmarkStart.b("䐲", num), (class2.method_0() * 20.0).ToString());
                newChild.AppendChild(element2);
            }
            this.xmlNode_0.AppendChild(newChild);
            XmlNodeList list2 = this.xmlNode_0.SelectNodes(string.Format(BookmarkStart.b("䠲Դ䨶ᘸ䀺఼䈾", num), BookmarkStart.b("䄲娴䀶䨸", num), BookmarkStart.b("䄲娴䀶", num)));
            if (list2.Count > 0)
            {
                foreach (XmlNode node2 in list2)
                {
                    XmlNodeList list = node2.SelectNodes(string.Format(BookmarkStart.b("䠲Դ䨶ᘸ䀺఼䈾", num), BookmarkStart.b("倲倴嬶唸䠺", num), BookmarkStart.b("倲倴嬶唸", num)));
                    double num3 = 0.0;
                    double num4 = 0.0;
                    if (list.Count > 0)
                    {
                        foreach (XmlNode node in list)
                        {
                            double num2 = Convert.ToDouble(node.Attributes[BookmarkStart.b("搲尴匶䴸区", num)].InnerText, this.numberFormatInfo_0);
                            num4 = num3;
                            num3 += num2;
                            int num5 = this.class808_0.method_3(num4, num3);
                            if (num5 > 1)
                            {
                                XmlAttribute attribute = node.OwnerDocument.CreateAttribute(BookmarkStart.b("倲娴嬶唸堺刼䨾⽀㝂", num));
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
            if (this.class809_0.Count > 0)
            {
                bool flag = true;
                while (flag)
                {
                    maxValue = double.MaxValue;
                    foreach (Class804.Class808 class2 in this.class809_0)
                    {
                        double num3 = class2.method_2(num2);
                        maxValue = (maxValue > num3) ? num3 : maxValue;
                    }
                    if (maxValue == 0.0)
                    {
                        return;
                    }
                    num2 += maxValue;
                    this.class808_0.method_1(maxValue);
                }
            }
        }

        private void method_3(Class804.Class808 A_0)
        {
            this.class809_0.method_0(A_0);
        }
    }
}

