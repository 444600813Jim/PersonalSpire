using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

internal class Class1092
{
    private Dictionary<string, string> dictionary_0;
    private XmlWriter xmlWriter_0;

    public Class1092(Stream A_0)
    {
        this.dictionary_0 = new Dictionary<string, string>();
        this.xmlWriter_0 = XmlWriter.Create(A_0);
        this.method_1().Clear();
    }

    public Class1092(Stream A_0, Dictionary<string, string> A_1)
    {
        this.dictionary_0 = new Dictionary<string, string>();
        this.xmlWriter_0 = XmlWriter.Create(A_0);
        this.method_1().Clear();
        this.dictionary_0 = A_1;
    }

    public Class1092(Stream A_0, XmlWriterSettings A_1, Dictionary<string, string> A_2)
    {
        this.dictionary_0 = new Dictionary<string, string>();
        this.xmlWriter_0 = XmlWriter.Create(A_0, A_1);
        this.method_1().Clear();
        this.dictionary_0 = A_2;
    }

    public XmlWriter method_0()
    {
        return this.xmlWriter_0;
    }

    public Dictionary<string, string> method_1()
    {
        return this.dictionary_0;
    }

    public void method_10(string A_0, string A_1)
    {
        this.xmlWriter_0.WriteStartElement(A_0, A_1);
    }

    public void method_11(string A_0, string A_1, string A_2)
    {
        this.xmlWriter_0.WriteStartElement(A_0, A_1, A_2);
    }

    public void method_12()
    {
        this.xmlWriter_0.WriteEndElement();
    }

    public void method_13()
    {
        this.xmlWriter_0.WriteFullEndElement();
    }

    public void method_14(string A_0)
    {
        this.xmlWriter_0.WriteComment(A_0);
    }

    public void method_15()
    {
        this.xmlWriter_0.Flush();
    }

    public void method_16()
    {
        this.xmlWriter_0.WriteStartDocument();
    }

    public void method_17(bool A_0)
    {
        this.xmlWriter_0.WriteStartDocument(A_0);
    }

    public void method_18()
    {
        this.xmlWriter_0.WriteEndDocument();
    }

    public void method_19(string A_0, string A_1)
    {
        this.xmlWriter_0.WriteProcessingInstruction(A_0, A_1);
    }

    public void method_2(Dictionary<string, string> A_0)
    {
        this.dictionary_0 = A_0;
    }

    public void method_20(string A_0)
    {
        this.xmlWriter_0.WriteRaw(A_0);
    }

    public void method_21(string A_0)
    {
        this.xmlWriter_0.WriteString(A_0);
    }

    public void method_22(string A_0)
    {
        this.xmlWriter_0.WriteWhitespace(A_0);
    }

    public void method_23(XmlReader A_0, bool A_1)
    {
        this.xmlWriter_0.WriteNode(A_0, A_1);
    }

    public void method_24(string A_0, string A_1)
    {
        if (!this.dictionary_0.ContainsKey(A_0))
        {
            this.dictionary_0.Add(A_0, A_1);
        }
        else
        {
            this.dictionary_0[A_0] = A_1;
        }
    }

    public void method_25(string A_0, string A_1, bool A_2)
    {
        if (A_2)
        {
            this.method_8(A_0, A_1, null);
        }
    }

    public void method_3(string A_0)
    {
        string prefix = Class398.smethod_11(A_0);
        if (prefix.Length != 0)
        {
            string localName = A_0.Substring(prefix.Length - 1);
            prefix = prefix.Substring(0, prefix.Length - 1);
            string ns = this.method_1()[prefix];
            this.xmlWriter_0.WriteStartElement(prefix, localName, ns);
        }
    }

    public void method_4(string A_0, string A_1)
    {
        int num = 1;
        string prefix = Class398.smethod_11(A_0);
        if (prefix.Length != 0)
        {
            string localName = A_0.Substring(prefix.Length);
            prefix = prefix.Substring(0, prefix.Length - 1);
            if (prefix == BookmarkStart.b("弦䐨䜪䌬尮", num))
            {
                this.xmlWriter_0.WriteAttributeString(prefix, localName, null, A_1);
            }
            else if (prefix == BookmarkStart.b("弦䐨䜪", num))
            {
                this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("弦䐨䜪", num), BookmarkStart.b("否夨䨪丬䨮", num), this.method_1()[prefix], BookmarkStart.b("圦嬨个帬䨮䌰䔲倴", num));
            }
            else
            {
                string ns = this.method_1()[prefix];
                this.xmlWriter_0.WriteAttributeString(localName, ns, A_1);
            }
        }
        else
        {
            this.xmlWriter_0.WriteAttributeString(A_0, A_1);
        }
    }

    public void method_5(string A_0, string A_1, string A_2)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, A_1, A_2);
    }

    public void method_6(string A_0, string A_1, string A_2, string A_3)
    {
        this.xmlWriter_0.WriteAttributeString(A_0, A_1, A_2, A_3);
    }

    public void method_7(string A_0, string A_1)
    {
        this.xmlWriter_0.WriteElementString(A_0, A_1);
    }

    public void method_8(string A_0, string A_1, string A_2)
    {
        this.xmlWriter_0.WriteElementString(A_0, A_1, A_2);
    }

    public void method_9(string A_0)
    {
        string prefix = Class398.smethod_11(A_0);
        if (prefix.Length != 0)
        {
            string localName = A_0.Substring(prefix.Length);
            prefix = prefix.Substring(0, prefix.Length - 1);
            string ns = this.method_1()[prefix];
            this.xmlWriter_0.WriteStartElement(prefix, localName, ns);
        }
        else
        {
            this.xmlWriter_0.WriteStartElement(A_0);
        }
    }
}

