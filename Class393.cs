using Spire.Doc;
using Spire.Doc.Documents.Converters;
using System;
using System.Collections;
using System.IO;
using System.Xml;

internal class Class393
{
    private readonly XmlReader xmlReader_0;

    public Class393()
    {
    }

    public Class393(Stream A_0)
    {
        A_0.Position = 0L;
        this.xmlReader_0 = Class462.smethod_1(A_0);
        this.xmlReader_0.MoveToContent();
    }

    public Class393(string A_0, Hashtable A_1)
    {
        this.xmlReader_0 = Class462.smethod_2(A_0, A_1);
        this.xmlReader_0.MoveToContent();
    }

    public string method_0()
    {
        return this.xmlReader_0.Prefix;
    }

    public string method_1()
    {
        return this.xmlReader_0.LocalName;
    }

    public bool method_10(string A_0, XmlDocumentTextHandling A_1)
    {
        this.xmlReader_0.MoveToElement();
        if (!this.method_2() || !(this.method_1() == A_0))
        {
            while (this.xmlReader_0.Read())
            {
                switch (this.xmlReader_0.NodeType)
                {
                    case XmlNodeType.Element:
                        return true;

                    case XmlNodeType.Text:
                    case XmlNodeType.CDATA:
                        if ((A_1 & XmlDocumentTextHandling.Text) != XmlDocumentTextHandling.None)
                        {
                            return true;
                        }
                        break;

                    case XmlNodeType.Whitespace:
                        if ((A_1 & XmlDocumentTextHandling.Whitespace) == XmlDocumentTextHandling.None)
                        {
                            break;
                        }
                        return true;

                    case XmlNodeType.SignificantWhitespace:
                        if ((A_1 & XmlDocumentTextHandling.SignificantWhitespace) == XmlDocumentTextHandling.None)
                        {
                            break;
                        }
                        return true;

                    case XmlNodeType.EndElement:
                        if (!this.method_11(A_0))
                        {
                            break;
                        }
                        return false;
                }
            }
            return false;
        }
        return false;
    }

    public bool method_11(string A_0)
    {
        return ((this.xmlReader_0.NodeType == XmlNodeType.EndElement) && (this.method_1() == A_0));
    }

    public string method_12(string A_0, string A_1)
    {
        string str = A_1;
        while (this.xmlReader_0.MoveToNextAttribute())
        {
            if (this.method_1() == A_0)
            {
                str = this.xmlReader_0.Value;
                break;
            }
        }
        this.xmlReader_0.MoveToElement();
        return str;
    }

    public int method_13(string A_0, int A_1)
    {
        string str = this.method_12(A_0, null);
        if (str == null)
        {
            return A_1;
        }
        return Class1041.smethod_11(str);
    }

    public double method_14(string A_0, double A_1)
    {
        string str = this.method_12(A_0, null);
        if (str == null)
        {
            return A_1;
        }
        return (double) Class1041.smethod_13(str);
    }

    public bool method_15(string A_0, bool A_1)
    {
        string str = this.method_12(A_0, null);
        if (str == null)
        {
            return A_1;
        }
        return this.method_16(str);
    }

    private bool method_16(string A_0)
    {
        int num = 13;
        if (!(A_0 == BookmarkStart.b("Ȳ", 13)) && !(A_0 == BookmarkStart.b("䜲䜴䈶尸", num)))
        {
            return (A_0 == BookmarkStart.b("䜲", num));
        }
        return true;
    }

    public Guid method_17(string A_0, Guid A_1)
    {
        string g = this.method_12(A_0, null);
        if (g == null)
        {
            return A_1;
        }
        return new Guid(g);
    }

    public bool method_18()
    {
        return this.xmlReader_0.MoveToElement();
    }

    public bool method_19()
    {
        return this.method_20(true);
    }

    private bool method_2()
    {
        return this.xmlReader_0.IsEmptyElement;
    }

    public bool method_20(bool A_0)
    {
        int num = 0x11;
        while (this.xmlReader_0.MoveToNextAttribute())
        {
            if ((this.xmlReader_0.Prefix != BookmarkStart.b("伶吸场匼䰾", num)) || !A_0)
            {
                return true;
            }
        }
        return false;
    }

    public string method_21()
    {
        return this.xmlReader_0.ReadString();
    }

    public int method_22()
    {
        return Class1041.smethod_11(this.method_21());
    }

    public bool method_23()
    {
        return Class1041.smethod_28(this.method_21());
    }

    public string method_24()
    {
        string str = this.xmlReader_0.ReadOuterXml();
        while ((this.xmlReader_0.NodeType == XmlNodeType.Whitespace) || ((this.xmlReader_0.NodeType == XmlNodeType.Text) || (this.xmlReader_0.NodeType == XmlNodeType.Comment)))
        {
            this.xmlReader_0.Read();
        }
        return str;
    }

    public string method_25(string A_0)
    {
        return this.xmlReader_0.LookupNamespace(A_0);
    }

    public string method_3()
    {
        return this.xmlReader_0.Value;
    }

    public int method_4()
    {
        return Class1041.smethod_11(this.method_3());
    }

    public double method_5()
    {
        return (double) Class1041.smethod_13(this.method_3());
    }

    public int method_6()
    {
        return (int) (Class1041.smethod_25(this.xmlReader_0.Value) & 0xffffffffL);
    }

    public string method_7()
    {
        return this.xmlReader_0.NamespaceURI;
    }

    internal XmlReader method_8()
    {
        return this.xmlReader_0;
    }

    public bool method_9(string A_0)
    {
        return this.method_10(A_0, XmlDocumentTextHandling.None);
    }

    internal virtual bool vmethod_0()
    {
        return this.method_16(this.method_3());
    }

    public virtual void vmethod_1()
    {
        this.xmlReader_0.MoveToElement();
        if (!this.method_2())
        {
            string str = this.method_1();
            while (!this.method_11(str))
            {
                this.xmlReader_0.Read();
                if (this.xmlReader_0.NodeType == XmlNodeType.Element)
                {
                    this.xmlReader_0.Skip();
                }
            }
        }
    }
}

