using Spire.Doc;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;

internal class Class620
{
    private XmlReader xmlReader_0;
    private XmlWriter xmlWriter_0;

    public bool method_0(XmlWriter A_0, string A_1, object A_2)
    {
        this.xmlWriter_0 = A_0;
        if (A_2 is Matrix)
        {
            this.method_2(A_1, A_2 as Matrix);
        }
        if (A_2 is Color)
        {
            this.method_3(A_1, (Color) A_2);
        }
        else
        {
            if (!(A_2 is Font))
            {
                return false;
            }
            this.method_4(A_1, (Font) A_2);
        }
        return true;
    }

    public object method_1(XmlReader A_0, Type A_1)
    {
        this.xmlReader_0 = A_0;
        if (A_1.Equals(typeof(Matrix)))
        {
            return this.method_7();
        }
        if (A_1.Equals(typeof(Color)))
        {
            return this.method_7();
        }
        if (A_1.Equals(typeof(Color)))
        {
            return this.method_6();
        }
        if (A_1.Equals(typeof(Font)))
        {
            return this.method_5();
        }
        return null;
    }

    private void method_2(string A_0, Matrix A_1)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌬丮尰嘲", num));
        }
        if (A_0.Length == 0)
        {
            throw new ArgumentException(BookmarkStart.b("䌬丮尰嘲ᔴᨶᤸ䠺䤼䴾⡀ⵂ≄杆⩈⩊⍌潎㽐㱒⅔睖㭘㹚絜㩞ౠ።ᅤṦ", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀬丮䔰䄲尴伶", num));
        }
        this.xmlWriter_0.WriteStartElement(A_0);
        float[] elements = A_1.Elements;
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("䀬Ḯ0", num), XmlConvert.ToString(elements[0]));
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("䀬Ḭ̈́", num), XmlConvert.ToString(elements[1]));
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("䀬ᴮ0", num), XmlConvert.ToString(elements[2]));
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("䀬ᴮ̰", num), XmlConvert.ToString(elements[3]));
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("䤬Ḯ", num), XmlConvert.ToString(elements[4]));
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("䤬ᴮ", num), XmlConvert.ToString(elements[5]));
        this.xmlWriter_0.WriteEndElement();
    }

    private void method_3(string A_0, Color A_1)
    {
        this.xmlWriter_0.WriteStartElement(A_0);
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("嬮䠰䌲倴", 9), BookmarkStart.b("氮帰弲娴䔶", 9));
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("丮䌰吲圴", 9), XmlConvert.ToString(A_1.ToArgb()));
        this.xmlWriter_0.WriteEndElement();
    }

    private void method_4(string A_0, Font A_1)
    {
        this.xmlWriter_0.WriteStartElement(A_0);
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("匦倨嬪䠬", 1), BookmarkStart.b("愦䘨䔪夬", 1));
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("䄦䘨䔪夬愮倰帲倴", 1), A_1.Name);
        this.xmlWriter_0.WriteAttributeString(BookmarkStart.b("否䀨優䠬", 1), A_1.SizeInPoints.ToString());
        this.xmlWriter_0.WriteEndElement();
    }

    private Font method_5()
    {
        string attribute = this.xmlReader_0.GetAttribute(BookmarkStart.b("弸吺匼䬾ཀ≂⡄≆", 0x13));
        string s = this.xmlReader_0.GetAttribute(BookmarkStart.b("䨸刺䜼娾", 0x13));
        this.xmlReader_0.GetAttribute(BookmarkStart.b("䨸伺䐼匾⑀", 0x13));
        this.xmlReader_0.Read();
        return Class58.smethod_0(attribute, (float) int.Parse(s));
    }

    private Color method_6()
    {
        string attribute = this.xmlReader_0.GetAttribute(BookmarkStart.b("䘦嬨䰪伬", 1));
        this.xmlReader_0.Read();
        return Color.FromArgb(int.Parse(attribute));
    }

    private Matrix method_7()
    {
        float num = XmlConvert.ToSingle(this.xmlReader_0.GetAttribute(BookmarkStart.b("尰Ȳд", 11)));
        float num2 = XmlConvert.ToSingle(this.xmlReader_0.GetAttribute(BookmarkStart.b("尰Ȳܴ", 11)));
        float num3 = XmlConvert.ToSingle(this.xmlReader_0.GetAttribute(BookmarkStart.b("尰Ĳд", 11)));
        float num4 = XmlConvert.ToSingle(this.xmlReader_0.GetAttribute(BookmarkStart.b("尰Ĳܴ", 11)));
        float dx = XmlConvert.ToSingle(this.xmlReader_0.GetAttribute(BookmarkStart.b("唰Ȳ", 11)));
        float dy = XmlConvert.ToSingle(this.xmlReader_0.GetAttribute(BookmarkStart.b("唰Ĳ", 11)));
        Matrix matrix = new Matrix(num, num2, num3, num4, dx, dy);
        this.xmlReader_0.Read();
        return matrix;
    }
}

