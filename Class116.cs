using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

internal class Class116
{
    private Class393 class393_0;
    private DigitalSignature digitalSignature_0;
    private static readonly string[] string_0 = new string[] { BookmarkStart.b("䤯䬱䴳伵ᔷ眹焻ጽ␿♁၃ๅG灉⅋⍍橏⅑❓穕ṗ᱙", 10), BookmarkStart.b("䤯䬱䴳伵ᔷ眹焻ጽ␿♁၃ๅG灉⅋⍍橏⅑❓ౕ", 10), BookmarkStart.b("䤯䬱䴳伵ᔷ眹焻ጽ␿♁၃ๅG灉⅋⍍橏⅑❓ⱕ≗⁙", 10) };

    private Class116()
    {
    }

    private DigitalSignature method_0(Interface12 A_0, bool A_1)
    {
        int num = 13;
        this.digitalSignature_0 = new DigitalSignature(DigitalSignatureType.XmlDsig);
        this.digitalSignature_0.SignedXmlResult = A_1;
        while (this.class393_0.method_9(BookmarkStart.b("怲尴倶圸娺䤼䨾㍀♂", num)))
        {
            string str = this.class393_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("怲尴倶圸帺夼瘾⽀╂⩄", num))
                {
                    if (!(str == BookmarkStart.b("砲倴丶瀸唺嬼倾", num)))
                    {
                        if (str == BookmarkStart.b("簲圴崶尸堺䤼", num))
                        {
                            this.method_3();
                        }
                    }
                    else
                    {
                        this.method_1();
                    }
                }
                else
                {
                    this.method_6();
                }
            }
        }
        bool flag = A_1;
        SHA1 sha = new SHA1CryptoServiceProvider();
        foreach (Class117 class2 in this.digitalSignature_0.References)
        {
            if (class2.method_6())
            {
                Stream stream = A_0.imethod_0(class2);
                foreach (Class1055 class3 in class2.method_5())
                {
                    stream = class3.method_0(stream);
                }
                stream.Position = 0L;
                bool flag2 = Convert.ToBase64String(sha.ComputeHash(stream)) == class2.method_3();
                class2.method_8(flag2);
                flag &= flag2;
            }
            else
            {
                class2.method_8(A_1);
            }
        }
        this.digitalSignature_0.method_2(flag);
        return this.digitalSignature_0;
    }

    private void method_1()
    {
        int num = 13;
        while (this.class393_0.method_9(BookmarkStart.b("砲倴丶瀸唺嬼倾", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("欲4ܶ8缺尼䬾⁀", num)))
            {
                this.method_2();
            }
        }
    }

    private void method_10()
    {
        int num = 3;
        while (this.class393_0.method_9(BookmarkStart.b("稨䈪䨬䄮倰䜲䀴䔶尸爺匼夾⹀ᕂ瑄", num)))
        {
            string str2 = this.class393_0.method_1();
            if (str2 != null)
            {
                if (str2 != BookmarkStart.b("稨䈪䨬䄮倰䜲䀴䔶尸砺刼刾ⱀ♂⭄㍆㩈", num))
                {
                    if (str2 != BookmarkStart.b("稨个夬娮䄰稲焴", num))
                    {
                        if (str2 != BookmarkStart.b("稨䈪䨬䄮倰䜲䀴䔶尸漺堼䜾㕀", num))
                        {
                            if (!(str2 == BookmarkStart.b("稨䈪䨬䄮倰䜲䀴䔶尸漺䐼伾⑀", num)))
                            {
                                if (str2 == BookmarkStart.b("稨䈪䨬䄮倰䜲䀴䔶尸爺值帾♀♂", num))
                                {
                                    string str = this.class393_0.method_21();
                                    this.digitalSignature_0.ImageBytes = Class567.smethod_16(str) ? Convert.FromBase64String(str) : null;
                                }
                            }
                            else
                            {
                                this.digitalSignature_0.Visible = this.class393_0.method_21() == BookmarkStart.b("ᬨ", num);
                            }
                        }
                        else
                        {
                            this.digitalSignature_0.Text = this.class393_0.method_21();
                        }
                    }
                    else
                    {
                        string str3 = this.class393_0.method_21();
                        this.digitalSignature_0.SetupId = Class567.smethod_16(str3) ? new Guid(str3) : Guid.Empty;
                    }
                }
                else
                {
                    this.digitalSignature_0.method_1(this.class393_0.method_21());
                }
            }
        }
    }

    private Class117 method_11()
    {
        int num = 8;
        string str = this.class393_0.method_12(BookmarkStart.b("笭戯笱", 8), null);
        ArrayList list = new ArrayList();
        string str2 = "";
        while (this.class393_0.method_9(BookmarkStart.b("簭唯吱儳䐵崷吹弻嬽", num)))
        {
            string str3 = this.class393_0.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("樭夯唱儳䔵䰷氹崻刽㔿❁", num)))
                {
                    if (str3 == BookmarkStart.b("稭䈯匱娳䔵帷唹主匽㌿", num))
                    {
                        this.method_12(list);
                    }
                }
                else
                {
                    str2 = this.class393_0.method_21();
                }
            }
        }
        return new Class117(str, list, str2);
    }

    private void method_12(ArrayList A_0)
    {
        int num = 5;
        while (this.class393_0.method_9(BookmarkStart.b("缪弬丮弰䀲匴堶䬸嘺丼", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("缪弬丮弰䀲匴堶䬸嘺", num)))
            {
                A_0.Add(new Class1055(this.class393_0));
            }
        }
    }

    private void method_2()
    {
        int num = 5;
        while (this.class393_0.method_9(BookmarkStart.b("猪ᠬἮ࠰眲吴䌶堸", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("猪ᠬἮ࠰瀲倴䔶䴸刺嬼嘾≀≂ㅄ≆", num)))
            {
                this.digitalSignature_0.method_3(new X509Certificate2(Encoding.UTF8.GetBytes(this.class393_0.method_21())));
            }
        }
    }

    private void method_3()
    {
        int num = 2;
        string str = this.class393_0.method_12(BookmarkStart.b("愧丩", 2), null);
        if (str == null)
        {
            this.method_4();
        }
        else
        {
            string str2 = str;
            if (str2 != null)
            {
                if (str2 == BookmarkStart.b("䄧丩簫伭匯失唳儵崷甹帻吽┿⅁ぃ", num))
                {
                    this.method_4();
                }
                else if (str2 == BookmarkStart.b("䄧丩挫䠭嘯嬱圳匵眷堹嘻嬽⌿㙁", num))
                {
                    this.method_5();
                }
                else if (str2 == BookmarkStart.b("䄧丩稫伭尯嬱倳攵儷崹瀻倽ि⽁⍃", num))
                {
                    this.digitalSignature_0.ImageBytesValid = Convert.FromBase64String(this.class393_0.method_21());
                }
                else if (str2 == BookmarkStart.b("䄧丩攫䀭䘯匱堳張尷椹唻夽ిⱁൃ⭅⽇", num))
                {
                    this.digitalSignature_0.ImageBytesInvalid = Convert.FromBase64String(this.class393_0.method_21());
                }
            }
        }
    }

    private void method_4()
    {
        int num = 1;
        while (this.class393_0.method_9(BookmarkStart.b("栦䬨䄪䠬䰮䔰", num)))
        {
            string str = this.class393_0.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("樦䠨䔪䐬䤮吰䀲䄴", num)))
                {
                    if (str == BookmarkStart.b("琦䀨䰪䌬丮䔰䘲䜴制椸䤺刼伾⑀ㅂㅄ⹆ⱈ㡊", num))
                    {
                        this.method_7();
                    }
                }
                else
                {
                    this.method_6();
                }
            }
        }
    }

    private void method_5()
    {
        int num = 0x11;
        while (this.class393_0.method_9(BookmarkStart.b("砶嬸儺堼尾㕀", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("搶倸尺匼帾㕀㙂㝄≆᥈㥊≌㽎㑐⅒⅔㹖㱘⡚", num)))
            {
                this.method_7();
            }
        }
    }

    private void method_6()
    {
        int num = 0x12;
        string str = this.class393_0.method_1();
        while (this.class393_0.method_9(str))
        {
            string str2;
            if (((str2 = this.class393_0.method_1()) != null) && (str2 == BookmarkStart.b("樷弹娻嬽㈿❁⩃╅ⵇ", num)))
            {
                this.digitalSignature_0.References.Add(this.method_11());
            }
        }
    }

    private void method_7()
    {
        int num = 0x13;
        while (this.class393_0.method_9(BookmarkStart.b("樸刺娼儾⁀㝂い㕆ⱈᭊ㽌⁎⅐㙒❔⍖じ㹚⹜", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("樸刺娼儾⁀㝂い㕆ⱈᭊ㽌⁎⅐㙒❔⍖⁘", num)))
            {
                this.method_8();
            }
        }
    }

    private void method_8()
    {
        int num = 0;
        while (this.class393_0.method_9(BookmarkStart.b("甥䄧䴩䈫伭䐯䜱䘳匵样䠹医丽┿ぁぃ㽅", num)))
        {
            string str = this.class393_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("甥䄧䴩䈫伭䐯䜱䘳匵氷匹儻嬽", num))
                {
                    if (!(str == BookmarkStart.b("甥䄧䴩䈫伭䐯䜱䘳匵焷吹娻儽ᘿ獁", num)))
                    {
                        if (str == BookmarkStart.b("䈥䤧帩䤫", num))
                        {
                            this.digitalSignature_0.method_0(smethod_1(this.class393_0.method_21()));
                        }
                    }
                    else
                    {
                        this.method_10();
                    }
                }
                else
                {
                    this.method_9();
                }
            }
        }
    }

    private void method_9()
    {
        int num = 12;
        while (this.class393_0.method_9(BookmarkStart.b("愱崳儵嘷嬹䠻䬽㈿❁၃⽅╇⽉", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("搱唳娵䴷弹", num)))
            {
                this.digitalSignature_0.method_0(smethod_1(this.class393_0.method_21()));
            }
        }
    }

    private static bool smethod_0(Stream A_0, int A_1)
    {
        int num = 12;
        long position = A_0.Position;
        A_0.Position = 0L;
        XmlDocument document = new XmlDocument {
            PreserveWhitespace = true
        };
        document.Load(A_0);
        XmlNodeList elementsByTagName = document.GetElementsByTagName(BookmarkStart.b("愱崳儵嘷嬹䠻䬽㈿❁", 12));
        if (elementsByTagName.Count <= 0)
        {
            return false;
        }
        SignedXml xml = new SignedXml();
        xml.LoadXml((XmlElement) elementsByTagName[A_1]);
        int index = 0;
        while (index < xml.SignedInfo.References.Count)
        {
            Reference reference = (Reference) xml.SignedInfo.References[index];
            if (!reference.Uri.StartsWith(BookmarkStart.b("ᄱ", num)))
            {
                xml.SignedInfo.References.RemoveAt(index);
            }
            else
            {
                index++;
            }
        }
        A_0.Position = position;
        return xml.CheckSignature();
    }

    private static DateTime smethod_1(string A_0)
    {
        return DateTime.ParseExact(A_0, string_0, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
}

