using Spire.Doc;
using Spire.Doc.Documents.Converters;
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

internal class Class556
{
    private Class393 class393_0;
    private DigitalSignature digitalSignature_0;
    private static readonly string[] string_0 = new string[] { BookmarkStart.b("刪听嘮䠰Ḳ破稶ᐸ强夼款ीୂ罄⩆⑈煊㹌㱎結ᕒፔ", 5), BookmarkStart.b("刪听嘮䠰Ḳ破稶ᐸ强夼款ीୂ罄⩆⑈煊㹌㱎୐", 5), BookmarkStart.b("刪听嘮䠰Ḳ破稶ᐸ强夼款ीୂ罄⩆⑈煊㹌㱎⭐⥒⽔", 5) };

    private Class556()
    {
    }

    private void method_0(Stream A_0, Interface9 A_1, DigitalSignatures A_2)
    {
        int num = 9;
        if (A_0 != null)
        {
            this.class393_0 = new Class393(A_0);
            if (this.class393_0.method_1() == BookmarkStart.b("簮堰吲嬴嘶䴸为似娾", num))
            {
                bool flag = smethod_1(A_0, 0);
                A_2.method_0(this.method_1(A_1, flag));
            }
            else
            {
                int num2 = 0;
                while (this.class393_0.method_9(BookmarkStart.b("䬮帰倲䀴娶尸唺䤼ሾ㉀⩂≄⥆⡈㽊㡌㵎㑐⁒", num)))
                {
                    string str;
                    if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("簮堰吲嬴嘶䴸为似娾", num)))
                    {
                        bool flag2 = smethod_1(A_0, num2++);
                        A_2.method_0(this.method_1(A_1, flag2));
                    }
                    else
                    {
                        this.method_15();
                    }
                }
            }
        }
    }

    private DigitalSignature method_1(Interface9 A_0, bool A_1)
    {
        int num = 1;
        this.digitalSignature_0 = new DigitalSignature(DigitalSignatureType.XmlDsig);
        this.digitalSignature_0.SignedXmlResult = A_1;
        while (this.class393_0.method_9(BookmarkStart.b("琦䀨䰪䌬丮䔰䘲䜴制", num)))
        {
            string str = this.class393_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("琦䀨䰪䌬䨮唰稲嬴儶嘸", num))
                {
                    if (!(str == BookmarkStart.b("氦䰨刪搬䄮地尲", num)))
                    {
                        if (!(str == BookmarkStart.b("栦䬨䄪䠬䰮䔰", num)))
                        {
                            goto Label_0084;
                        }
                        this.method_4();
                    }
                    else
                    {
                        this.method_2();
                    }
                }
                else
                {
                    this.method_7();
                }
                continue;
            }
        Label_0084:
            this.method_15();
        }
        bool flag = A_1;
        SHA1 sha = new SHA1CryptoServiceProvider();
        foreach (Class731 class2 in this.digitalSignature_0.References)
        {
            if (class2.method_6())
            {
                Stream stream = A_0.imethod_0(class2);
                foreach (Class557 class3 in class2.method_5())
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

    private void method_10()
    {
        int num = 6;
        while (this.class393_0.method_9(BookmarkStart.b("缫䜭圯就唳䈵䴷䠹夻樽⤿⽁⅃", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("稫伭尯䜱儳", num)))
            {
                this.digitalSignature_0.method_0(smethod_2(this.class393_0.method_21()));
            }
            else
            {
                this.method_15();
            }
        }
    }

    private void method_11()
    {
        int num = 0x12;
        while (this.class393_0.method_9(BookmarkStart.b("欷匹嬻倽ℿ㙁ㅃ㑅ⵇ͉≋⡍㽏ё敓", num)))
        {
            string str2 = this.class393_0.method_1();
            if (str2 != null)
            {
                if (str2 != BookmarkStart.b("欷匹嬻倽ℿ㙁ㅃ㑅ⵇॉ⍋⍍㵏㝑㩓≕⭗", num))
                {
                    if (str2 != BookmarkStart.b("欷弹䠻䬽〿ୁC", num))
                    {
                        if (str2 != BookmarkStart.b("欷匹嬻倽ℿ㙁ㅃ㑅ⵇṉ⥋㙍⑏", num))
                        {
                            if (!(str2 == BookmarkStart.b("欷匹嬻倽ℿ㙁ㅃ㑅ⵇṉ㕋㹍㕏", num)))
                            {
                                if (!(str2 == BookmarkStart.b("欷匹嬻倽ℿ㙁ㅃ㑅ⵇ͉⅋⽍㝏㝑", num)))
                                {
                                    goto Label_0138;
                                }
                                string str = this.class393_0.method_21();
                                this.digitalSignature_0.ImageBytes = Class567.smethod_16(str) ? Convert.FromBase64String(str) : null;
                            }
                            else
                            {
                                this.digitalSignature_0.Visible = this.class393_0.method_21() == BookmarkStart.b("਷", num);
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
                continue;
            }
        Label_0138:
            this.method_15();
        }
    }

    private Class731 method_12()
    {
        int num = 0x10;
        string str = this.class393_0.method_12(BookmarkStart.b("挵樷猹", 0x10), null);
        ArrayList list = new ArrayList();
        string str2 = "";
        while (this.class393_0.method_9(BookmarkStart.b("搵崷尹夻䰽┿ⱁ❃⍅", num)))
        {
            string str3 = this.class393_0.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("爵儷崹夻䴽㐿ᑁ╃⩅㵇⽉", num)))
                {
                    if (!(str3 == BookmarkStart.b("戵䨷嬹刻䴽☿ⵁ㙃⭅㭇", num)))
                    {
                        goto Label_007C;
                    }
                    this.method_13(list);
                }
                else
                {
                    str2 = this.class393_0.method_21();
                }
                continue;
            }
        Label_007C:
            this.method_15();
        }
        return new Class731(str, list, str2);
    }

    private void method_13(ArrayList A_0)
    {
        int num = 0x10;
        while (this.class393_0.method_9(BookmarkStart.b("戵䨷嬹刻䴽☿ⵁ㙃⭅㭇", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("戵䨷嬹刻䴽☿ⵁ㙃⭅", num)))
            {
                A_0.Add(new Class557(this.class393_0));
            }
            else
            {
                this.method_15();
            }
        }
    }

    private void method_14(WarningTypeCore A_0, WarningSourceCore A_1, string A_2)
    {
    }

    private void method_15()
    {
        this.class393_0.vmethod_1();
    }

    private void method_2()
    {
        int num = 5;
        while (this.class393_0.method_9(BookmarkStart.b("怪䠬嘮砰崲匴堶", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("猪ᠬἮ࠰眲吴䌶堸", num)))
            {
                this.method_3();
            }
            else
            {
                this.method_15();
            }
        }
    }

    private void method_3()
    {
        int num = 2;
        while (this.class393_0.method_9(BookmarkStart.b("瀧Ἡᰫᜭ琯匱䀳圵", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("瀧Ἡᰫᜭ猯圱䘳䈵儷尹唻崽ℿ㙁⅃", num)))
            {
                this.digitalSignature_0.method_3(new X509Certificate2(Encoding.UTF8.GetBytes(this.class393_0.method_21())));
            }
            else
            {
                this.method_15();
            }
        }
    }

    private void method_4()
    {
        int num = 3;
        string str = this.class393_0.method_12(BookmarkStart.b("怨伪", 3), null);
        if (str == null)
        {
            this.method_5();
        }
        else
        {
            string str2 = str;
            if (str2 != null)
            {
                if (str2 == BookmarkStart.b("䀨伪紬丮到堲吴倶尸琺弼唾⑀⁂ㅄ", num))
                {
                    this.method_5();
                }
                else if (str2 == BookmarkStart.b("䀨伪戬䤮地娲嘴制瘸夺圼娾≀㝂", num))
                {
                    this.method_6();
                }
                else if (str2 == BookmarkStart.b("䀨伪第丮崰娲儴搶倸尺焼儾ࡀ⹂≄", num))
                {
                    this.digitalSignature_0.ImageBytesValid = Convert.FromBase64String(this.class393_0.method_21());
                }
                else if (str2 == BookmarkStart.b("䀨伪搬䄮䜰刲头帶崸栺吼堾ീⵂౄ⩆⹈", num))
                {
                    this.digitalSignature_0.ImageBytesInvalid = Convert.FromBase64String(this.class393_0.method_21());
                }
            }
        }
    }

    private void method_5()
    {
        int num = 7;
        while (this.class393_0.method_9(BookmarkStart.b("戬䴮嬰嘲嘴䌶", num)))
        {
            string str = this.class393_0.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("怬丮弰娲匴制䨸伺", num)))
                {
                    if (!(str == BookmarkStart.b("縬䘮嘰崲吴䌶䰸䤺堼漾㍀ⱂ㕄≆㭈㽊⑌⩎≐", num)))
                    {
                        goto Label_004D;
                    }
                    this.method_8();
                }
                else
                {
                    this.method_7();
                }
                continue;
            }
        Label_004D:
            this.method_15();
        }
    }

    private void method_6()
    {
        int num = 5;
        while (this.class393_0.method_9(BookmarkStart.b("搪伬䔮吰倲䄴", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("砪䐬䠮弰刲䄴䈶䬸帺洼䴾⹀㍂⁄㕆㵈≊⡌㱎", num)))
            {
                this.method_8();
            }
            else
            {
                this.method_15();
            }
        }
    }

    private void method_7()
    {
        int num = 2;
        string str = this.class393_0.method_1();
        while (this.class393_0.method_9(str))
        {
            string str2;
            if (((str2 = this.class393_0.method_1()) != null) && (str2 == BookmarkStart.b("稧伩䨫䬭䈯圱娳唵崷", num)))
            {
                this.digitalSignature_0.References.Add(this.method_12());
            }
            else
            {
                this.method_15();
            }
        }
    }

    private void method_8()
    {
        int num = 7;
        while (this.class393_0.method_9(BookmarkStart.b("縬䘮嘰崲吴䌶䰸䤺堼漾㍀ⱂ㕄≆㭈㽊⑌⩎≐", num)))
        {
            string str;
            if (((str = this.class393_0.method_1()) != null) && (str == BookmarkStart.b("縬䘮嘰崲吴䌶䰸䤺堼漾㍀ⱂ㕄≆㭈㽊㑌", num)))
            {
                this.method_9();
            }
            else
            {
                this.method_15();
            }
        }
    }

    private void method_9()
    {
        int num = 11;
        while (this.class393_0.method_9(BookmarkStart.b("戰娲刴夶堸伺䠼䴾⑀ፂ㝄⡆㥈⹊㽌㭎⡐", num)))
        {
            string str = this.class393_0.method_1();
            if (str != null)
            {
                if (str != BookmarkStart.b("戰娲刴夶堸伺䠼䴾⑀ᝂⱄ⩆ⱈ", num))
                {
                    if (!(str == BookmarkStart.b("戰娲刴夶堸伺䠼䴾⑀ੂ⭄ⅆ♈ᵊ籌", num)))
                    {
                        if (!(str == BookmarkStart.b("唰刲䄴制", num)))
                        {
                            goto Label_007D;
                        }
                        this.digitalSignature_0.method_0(smethod_2(this.class393_0.method_21()));
                    }
                    else
                    {
                        this.method_11();
                    }
                }
                else
                {
                    this.method_10();
                }
                continue;
            }
        Label_007D:
            this.method_15();
        }
    }

    internal static void smethod_0(Stream A_0, Interface9 A_1, DigitalSignatures A_2)
    {
        new Class556().method_0(A_0, A_1, A_2);
    }

    private static bool smethod_1(Stream A_0, int A_1)
    {
        int num = 11;
        long position = A_0.Position;
        A_0.Position = 0L;
        XmlDocument document = new XmlDocument {
            PreserveWhitespace = true
        };
        document.Load(A_0);
        XmlNodeList elementsByTagName = document.GetElementsByTagName(BookmarkStart.b("戰娲刴夶堸伺䠼䴾⑀", 11));
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
            if (!reference.Uri.StartsWith(BookmarkStart.b("ሰ", num)))
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

    private static DateTime smethod_2(string A_0)
    {
        return DateTime.ParseExact(A_0, string_0, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
}

