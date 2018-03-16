using Spire.Doc;
using Spire.Doc.Documents.Markup;
using System;
using System.Collections;
using System.IO;
using System.Xml;

internal class Class443
{
    private string string_0;
    private string string_1;
    private string string_2;

    internal Class443(string A_0) : this(A_0, string.Empty)
    {
    }

    internal Class443(string A_0, string A_1) : this(string.Empty, A_0, A_1)
    {
    }

    internal Class443(string A_0, string A_1, string A_2)
    {
        this.string_0 = A_0;
        this.string_1 = A_1;
        this.string_2 = A_2;
    }

    internal Class443 method_0()
    {
        return (Class443) base.MemberwiseClone();
    }

    internal void method_1(string A_0)
    {
        this.string_1 = A_0;
    }

    internal string method_10(string A_0)
    {
        string str;
        using (IDictionaryEnumerator enumerator = this.method_9().GetEnumerator())
        {
            DictionaryEntry current;
            while (enumerator.MoveNext())
            {
                current = (DictionaryEntry) enumerator.Current;
                if (A_0.Equals(A_0))
                {
                    goto Label_002E;
                }
            }
            return string.Empty;
        Label_002E:
            str = (string) current.Key;
        }
        return str;
    }

    internal bool method_11()
    {
        return !string.IsNullOrEmpty(this.method_13());
    }

    internal string method_12()
    {
        return this.string_0;
    }

    internal string method_13()
    {
        return this.string_1;
    }

    internal string method_14()
    {
        return this.string_2;
    }

    internal XmlNode method_2(CustomXmlPartCollection A_0)
    {
        return this.method_3(A_0, this.method_13());
    }

    internal XmlNode method_3(CustomXmlPartCollection A_0, string A_1)
    {
        if (string.IsNullOrEmpty(this.method_14()) && string.IsNullOrEmpty(this.method_13()))
        {
            return null;
        }
        XmlNode node = null;
        if (A_0.GetById(this.method_14()) == null)
        {
            foreach (CustomXmlPart part in A_0)
            {
                node = this.method_4(part, A_1);
                if (node != null)
                {
                    return node;
                }
            }
            return node;
        }
        return this.method_4(A_0.GetById(this.method_14()), A_1);
    }

    private XmlNode method_4(CustomXmlPart A_0, string A_1)
    {
        XmlNode node = null;
        try
        {
            XmlDocument document = smethod_0(new MemoryStream(A_0.Data), false);
            node = this.method_7(document.DocumentElement, A_1, this.method_9());
        }
        catch (Exception)
        {
        }
        return node;
    }

    internal XmlNodeList method_5(CustomXmlPartCollection A_0, string A_1)
    {
        if (string.IsNullOrEmpty(this.method_14()))
        {
            return null;
        }
        XmlNodeList list = null;
        if (A_0.GetById(this.method_14()) == null)
        {
            foreach (CustomXmlPart part in A_0)
            {
                list = this.method_6(part, A_1);
                if (list != null)
                {
                    return list;
                }
            }
            return list;
        }
        return this.method_6(A_0.GetById(this.method_14()), A_1);
    }

    private XmlNodeList method_6(CustomXmlPart A_0, string A_1)
    {
        XmlNodeList list = null;
        try
        {
            XmlDocument document = smethod_0(new MemoryStream(A_0.Data), false);
            list = this.method_8(document.DocumentElement, A_1, this.method_9());
        }
        catch (Exception)
        {
        }
        return list;
    }

    public XmlNode method_7(XmlElement A_0, string A_1, Hashtable A_2)
    {
        if ((A_0 == null) || string.IsNullOrEmpty(A_1))
        {
            return null;
        }
        if (A_2 != null)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
            foreach (DictionaryEntry entry in A_2)
            {
                nsmgr.AddNamespace((string) entry.Key, (string) entry.Value);
            }
            return A_0.SelectSingleNode(A_1, nsmgr);
        }
        return A_0.SelectSingleNode(A_1);
    }

    public XmlNodeList method_8(XmlElement A_0, string A_1, Hashtable A_2)
    {
        XmlNodeList list;
        if ((A_0 == null) || string.IsNullOrEmpty(A_1))
        {
            return null;
        }
        if (A_2 != null)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
            foreach (DictionaryEntry entry in A_2)
            {
                nsmgr.AddNamespace((string) entry.Key, (string) entry.Value);
            }
            list = A_0.SelectNodes(A_1, nsmgr);
        }
        else
        {
            list = A_0.SelectNodes(A_1);
        }
        if (list.Count == 0)
        {
            return null;
        }
        return list;
    }

    private Hashtable method_9()
    {
        int num = 8;
        if (string.IsNullOrEmpty(this.method_12()))
        {
            return null;
        }
        Hashtable hashtable = new Hashtable();
        using (TextReader reader = new StringReader(BookmarkStart.b("ር༯䨱夳娵ᠷ䰹夻䰽㌿⭁⭃⡅畇浉絋恍恏畑瑓㍕㙗㥙㍛㩝य़ౡͣ孥佧Ὡᡫ࡭嵯䩱即噵୷๹ᵻၽ놋ꦍ놕ꞗ꒙ꂛ솟튡蒣", num) + this.method_12() + BookmarkStart.b("ĭฯ", num)))
        {
            using (XmlReader reader2 = XmlReader.Create(reader, null))
            {
                reader2.ReadToFollowing(BookmarkStart.b("䌭儯䈱", num));
                if (reader2.HasAttributes)
                {
                    while (reader2.MoveToNextAttribute())
                    {
                        hashtable.Add(reader2.LocalName, reader2.Value);
                    }
                }
                return hashtable;
            }
        }
    }

    public static XmlDocument smethod_0(Stream A_0, bool A_1)
    {
        XmlDocument document = new XmlDocument {
            PreserveWhitespace = A_1
        };
        document.Load(A_0);
        return document;
    }
}

