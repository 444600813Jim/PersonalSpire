using Spire.Doc;
using System;
using System.Xml;

[CLSCompliant(false)]
internal class Class189
{
    private Class190 class190_0 = new Class190();

    internal Class189()
    {
    }

    internal Class190 method_0()
    {
        return this.class190_0;
    }

    internal void method_1(XmlReader A_0)
    {
        int num = 0;
        A_0.Read();
        while (A_0.LocalName != BookmarkStart.b("䴥䴧匩椫䀭匯䀱䴳䘵䰷唹主䴽", num))
        {
            if (A_0.NodeType == XmlNodeType.Element)
            {
                string str;
                if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䌥䘧䤩師圭䀯䘱儳刵猷弹䔻", num)))
                {
                    this.class190_0.method_24(A_0);
                }
                A_0.Read();
            }
            else
            {
                A_0.Read();
            }
        }
    }

    internal void method_2(XmlWriter A_0)
    {
        A_0.WriteStartElement(BookmarkStart.b("帴制䀸縺匼尾㍀㩂㕄㍆♈㥊㹌", 15));
        A_0.WriteStartElement(BookmarkStart.b("帴制䀸縺匼尾㍀㩂㕄㍆♈㥊", 15));
        A_0.WriteAttributeString(BookmarkStart.b("䀴䔶倸", 15), BookmarkStart.b("崴䌶䴸䬺ܼှ湀あ♄⽆ⱈ♊ⱌ㱎罐㹒㱔㑖⭘㑚⹜ぞݠᝢ䭤Ѧ٨٪䉬nᝰᕲᱴᑶᱸ呺佼佾놀떂ꪄ좌낞토슢횤풦\udea8\uc4aa\udfac\ucbae", 15));
        this.class190_0.method_25(A_0);
        A_0.WriteEndElement();
        A_0.WriteEndElement();
    }
}

