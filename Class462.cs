using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;

internal class Class462
{
    private Class462()
    {
    }

    public static XmlTextWriter smethod_0(Stream A_0, Encoding A_1)
    {
        return new XmlTextWriter(new StreamWriter(A_0, A_1) { NewLine = BookmarkStart.b("‬┮", 7) });
    }

    public static XmlTextReader smethod_1(Stream A_0)
    {
        return new XmlTextReader(A_0) { XmlResolver = null };
    }

    public static XmlTextReader smethod_2(string A_0, Hashtable A_1)
    {
        NameTable nameTable = new NameTable();
        XmlNamespaceManager nsMgr = new XmlNamespaceManager(nameTable);
        if (A_1 != null)
        {
            foreach (DictionaryEntry entry in A_1)
            {
                nsMgr.AddNamespace((string) entry.Key, (string) entry.Value);
            }
        }
        return new XmlTextReader(A_0, XmlNodeType.Document, new XmlParserContext(nameTable, nsMgr, null, XmlSpace.Default)) { XmlResolver = null };
    }

    public static XmlDocument smethod_3(string A_0, bool A_1)
    {
        XmlDocument document = new XmlDocument {
            PreserveWhitespace = A_1
        };
        document.LoadXml(A_0);
        return document;
    }

    public static XmlDocument smethod_4(Stream A_0, bool A_1)
    {
        XmlDocument document = new XmlDocument {
            PreserveWhitespace = A_1
        };
        document.Load(A_0);
        return document;
    }

    public static void smethod_5(string A_0)
    {
        new XmlDocument { XmlResolver = null }.Load(A_0);
    }

    public static void smethod_6(XmlDocument A_0, Stream A_1)
    {
        A_0.Save(A_1);
    }

    public static string smethod_7(XmlDocument A_0)
    {
        return A_0.OuterXml;
    }

    public static IList smethod_8(XmlElement A_0, string A_1, Hashtable A_2)
    {
        XmlNodeList list2;
        ArrayList list = new ArrayList();
        if (A_2 != null)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
            foreach (DictionaryEntry entry in A_2)
            {
                nsmgr.AddNamespace((string) entry.Key, (string) entry.Value);
            }
            list2 = A_0.SelectNodes(A_1, nsmgr);
        }
        else
        {
            list2 = A_0.SelectNodes(A_1);
        }
        foreach (XmlNode node in list2)
        {
            list.Add(node);
        }
        return list;
    }

    public static XmlNode smethod_9(XmlElement A_0, string A_1, Hashtable A_2)
    {
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
}

