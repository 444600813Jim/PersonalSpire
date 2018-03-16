using Spire.Doc;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

internal class Class878
{
    private Class880 class880_0 = new Class880();
    private const string string_0 = "Spire.Doc.Resources.ml2word.xslt";
    private const string string_1 = "Word.Bookmark.Start";
    private const string string_2 = "Word.Bookmark.End";
    private XmlDocument xmlDocument_0 = new XmlDocument();
    private XmlNamespaceManager xmlNamespaceManager_0;

    public IDocument method_0(string A_0)
    {
        this.xmlDocument_0.Load(A_0);
        XslTransform transform = new XslTransform();
        transform.Load(smethod_0(), null, null);
        MemoryStream inStream = new MemoryStream();
        this.method_2();
        transform.Transform((IXPathNavigable) this.xmlDocument_0, null, (Stream) inStream, null);
        inStream.Position = 0L;
        IDocument document = new Document();
        XmlDocument document2 = new XmlDocument();
        document2.Load(inStream);
        inStream = new MemoryStream((int) inStream.Length);
        document2.Save(inStream);
        inStream.Position = 0L;
        document.LoadFromStream(inStream, FileFormat.Xml);
        return document;
    }

    public void method_1(Stream A_0, Document A_1)
    {
        this.xmlDocument_0.Load(A_0);
        XslTransform transform = new XslTransform();
        transform.Load(smethod_0(), null, null);
        MemoryStream inStream = new MemoryStream();
        this.method_2();
        transform.Transform((IXPathNavigable) this.xmlDocument_0, null, (Stream) inStream, null);
        inStream.Position = 0L;
        XmlDocument document = new XmlDocument();
        document.Load(inStream);
        inStream = new MemoryStream((int) inStream.Length);
        document.Save(inStream);
        inStream.Position = 0L;
        A_1.LoadFromStream(inStream, FileFormat.Xml);
    }

    private void method_2()
    {
        int num = 0;
        this.method_6();
        foreach (XmlNode node3 in this.xmlDocument_0.DocumentElement.SelectSingleNode(BookmarkStart.b("儥ሧ䠩䌫䨭䤯", 0), this.xmlNamespaceManager_0).SelectNodes(BookmarkStart.b("儥倧ဩ弫䬭匯䘱", 0), this.xmlNamespaceManager_0))
        {
            XmlNodeList list2 = node3.SelectNodes(BookmarkStart.b("儥ሧ娩", num), this.xmlNamespaceManager_0);
            if (list2.Count == 0)
            {
                XmlNode node2 = node3.SelectSingleNode(BookmarkStart.b("儥ሧ䠩䌫䨭䤯", num), this.xmlNamespaceManager_0);
                if (node2 != null)
                {
                    list2 = node2.SelectNodes(BookmarkStart.b("儥ሧ娩", num), this.xmlNamespaceManager_0);
                }
            }
            foreach (XmlNode node4 in list2)
            {
                this.method_3(node4);
            }
        }
    }

    private void method_3(XmlNode A_0)
    {
        XmlNodeList list = A_0.SelectNodes(BookmarkStart.b("嘶吸场ܼ帾⽀ⵂ⩄㍆⡈㽊⑌⁎㽐", 0x11), this.xmlNamespaceManager_0);
        XmlNodeList list2 = A_0.SelectNodes(BookmarkStart.b("䀶̸䬺吼尾㕀", 0x11), this.xmlNamespaceManager_0);
        foreach (XmlNode node2 in list)
        {
            this.method_4(node2);
        }
        foreach (XmlNode node in list2)
        {
            this.method_5(node);
        }
    }

    private void method_4(XmlNode A_0)
    {
        int num = 5;
        string innerText = A_0.Attributes[BookmarkStart.b("弪听弮吰", 5), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("尪", 5))].InnerText;
        string str2 = string.Empty;
        if (A_0.Attributes[BookmarkStart.b("䔪䰬䈮吰", 5), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("尪", 5))] != null)
        {
            str2 = A_0.Attributes[BookmarkStart.b("䔪䰬䈮吰", num), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("尪", num))].InnerText;
        }
        string str3 = A_0.Attributes[BookmarkStart.b("䈪䤬", num), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("䨪䀬䌮", num))].InnerText;
        string str4 = innerText;
        if (str4 != null)
        {
            if (str4 == BookmarkStart.b("簪䈬崮唰ᴲ眴堶嘸债值帾㍀⡂歄ᑆ㵈⩊㽌㭎", num))
            {
                this.class880_0.method_2(str2);
            }
            else if (str4 == BookmarkStart.b("簪䈬崮唰ᴲ眴堶嘸债值帾㍀⡂歄Ɇ❈⽊", num))
            {
                XmlAttribute node = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("尪ᜬ䄮倰帲倴", num), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("尪", num)));
                node.InnerText = this.class880_0.method_0(str3);
                A_0.Attributes.Append(node);
            }
        }
    }

    private void method_5(XmlNode A_0)
    {
        int num = 10;
        XmlNode node = A_0.SelectSingleNode(BookmarkStart.b("䜯࠱嘳張嘷縹崻䨽ℿ", 10), this.xmlNamespaceManager_0);
        XmlNode node2 = A_0.SelectSingleNode(BookmarkStart.b("䘯࠱䜳帵夷䨹夻", 10), this.xmlNamespaceManager_0);
        Image image = null;
        if (node != null)
        {
            image = this.method_8(node, false);
        }
        double width = image.Width;
        double height = image.Height;
        if (node2 != null)
        {
            XmlAttribute attribute = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("夯弱匳愵儷帹䠻嘽", num));
            attribute.InnerText = width.ToString();
            node2.Attributes.Append(attribute);
            XmlAttribute attribute2 = this.xmlDocument_0.CreateAttribute(BookmarkStart.b("夯弱匳縵崷匹嬻嘽㐿", num));
            attribute2.InnerText = height.ToString();
            node2.Attributes.Append(attribute2);
        }
    }

    private void method_6()
    {
        this.xmlNamespaceManager_0 = new XmlNamespaceManager(this.xmlDocument_0.NameTable);
        this.xmlNamespaceManager_0.AddNamespace(BookmarkStart.b("䌳", 14), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("䌳", 14)));
        this.xmlNamespaceManager_0.AddNamespace(BookmarkStart.b("䌳丵", 14), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("䌳丵", 14)));
        this.xmlNamespaceManager_0.AddNamespace(BookmarkStart.b("唳嬵吷", 14), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("唳嬵吷", 14)));
        this.xmlNamespaceManager_0.AddNamespace(BookmarkStart.b("䈳", 14), this.xmlDocument_0.DocumentElement.GetNamespaceOfPrefix(BookmarkStart.b("䈳", 14)));
    }

    private byte[] method_7(XmlNode A_0)
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

    private Image method_8(XmlNode A_0, bool A_1)
    {
        byte[] buffer = this.method_7(A_0);
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

    private static XmlReader smethod_0()
    {
        return new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(BookmarkStart.b("樸䬺吼䴾⑀浂ń⡆⩈敊Ὄ⩎≐㱒⁔╖㩘㹚⹜煞ౠར坤ၦ٨ᥪ६䅮॰rᥴͶ", 0x13)));
    }

    internal class Class879
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
    internal class Class880 : List<Class878.Class879>
    {
        private int int_0;

        public string method_0(string A_0)
        {
            string str = string.Empty;
            using (List<Class878.Class879>.Enumerator enumerator = base.GetEnumerator())
            {
                Class878.Class879 current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.method_2() == A_0)
                    {
                        goto Label_0031;
                    }
                }
                return str;
            Label_0031:
                str = current.method_0();
            }
            return str;
        }

        public int method_1(Class878.Class879 A_0)
        {
            A_0.method_3(this.int_0.ToString());
            this.int_0++;
            base.Add(A_0);
            return (this.int_0 - 1);
        }

        public int method_2(string A_0)
        {
            Class878.Class879 item = new Class878.Class879();
            item.method_1(A_0);
            item.method_3(this.int_0.ToString());
            this.int_0++;
            base.Add(item);
            return (this.int_0 - 1);
        }
    }
}

