using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Xml;

internal class Class557
{
    private readonly Class740 class740_0;
    private const string string_0 = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
    private const string string_1 = "http://schemas.openxmlformats.org/package/2006/RelationshipTransform";
    private readonly TransformType transformType_0;

    internal Class557(Class393 A_0)
    {
        int num = 15;
        this.class740_0 = Class740.smethod_1();
        string str2 = A_0.method_12(BookmarkStart.b("琴嬶常吺似嘾㕀⭂⡄", 15), null);
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("崴䌶䴸䬺ܼှ湀㑂㉄う杈㱊繌慎㹐⅒㉔硖൘ग़牜浞兠卢呤䡦㭨⹪⹬䉮॰Ṳᥴ婶᩸䩺䥼ᅾ검놂떄랆뢈뮊뺌뺎꒐", num))
            {
                this.transformType_0 = TransformType.TransformC14n;
                return;
            }
            if (str2 == BookmarkStart.b("崴䌶䴸䬺ܼှ湀あ♄⽆ⱈ♊ⱌ㱎罐㱒╔㉖㝘⍚ぜ㍞ݠౢᝤ੦ࡨὪṬ䅮ṰŲቴ塶ॸ᩺Ṽᑾꢆ뮈뮊붌릎뺐솒ﮖ쾠킢춤캦\ud9a8\uffaa\udfac\uceae\udfb0\uc0b2펴\ud8b6\ucbb8횺", num))
            {
                this.transformType_0 = TransformType.TransformRelationship;
                while (A_0.method_9(BookmarkStart.b("愴䔶堸唺丼夾⹀ㅂ⡄", num)))
                {
                    if (A_0.method_1() == BookmarkStart.b("朴制唸娺䤼嘾⹀ⵂ㙄⽆⁈㭊Ὄ⩎㝐㙒❔㉖㝘㡚㡜", num))
                    {
                        this.class740_0.Interface34.imethod_1(A_0.method_12(BookmarkStart.b("昴堶䰸䤺帼娾ࡀ❂", num), null));
                    }
                }
                return;
            }
        }
        this.transformType_0 = TransformType.TransformUnknown;
    }

    internal MemoryStream method_0(Stream A_0)
    {
        int num = 15;
        MemoryStream outStream = null;
        A_0.Position = 0L;
        switch (this.transformType_0)
        {
            case TransformType.TransformC14n:
            {
                XmlDsigC14NTransform transform = new XmlDsigC14NTransform();
                transform.LoadInput(A_0);
                return (MemoryStream) transform.GetOutput(typeof(MemoryStream));
            }
            case TransformType.TransformRelationship:
            {
                XmlDocument document = this.method_1(A_0);
                A_0.Position = 0L;
                XmlDocument document2 = this.method_1(A_0);
                XmlNode node = document2.GetElementsByTagName(BookmarkStart.b("朴制唸娺䤼嘾⹀ⵂ㙄⽆⁈㭊㹌", num))[0];
                node.RemoveAll();
                using (IEnumerator enumerator = this.class740_0.System.Collections.IEnumerable.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        string current = (string) enumerator.Current;
                        XmlNode node2 = document.SelectSingleNode(string.Format(BookmarkStart.b("ᨴᠶጸ怺紼瘾╀繂扄㱆祈㙊橌቎", num), current));
                        XmlAttribute attribute = node2.OwnerDocument.CreateAttribute(BookmarkStart.b("愴嘶䬸尺堼䬾ీⱂ⅄≆", num));
                        attribute.Value = BookmarkStart.b("簴夶䴸帺似儾⁀⽂", num);
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

