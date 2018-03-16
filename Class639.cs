using Spire.Doc;
using Spire.Doc.Converters.Sgml;
using System;
using System.Collections.Generic;
using System.Globalization;

internal class Class639
{
    private AttributePresence attributePresence_0;
    private AttributeType attributeType_0;
    private string string_0;
    private string[] string_1;
    private string string_2;

    public Class639(string A_0)
    {
        this.string_0 = A_0;
    }

    public string method_0()
    {
        return this.string_0;
    }

    public string method_1()
    {
        return this.string_2;
    }

    public void method_2(string A_0)
    {
        this.string_2 = A_0;
    }

    public AttributePresence method_3()
    {
        return this.attributePresence_0;
    }

    public string[] method_4()
    {
        return this.string_1;
    }

    public void method_5(string[] A_0, AttributeType A_1)
    {
        int num = 0x11;
        if ((A_1 != AttributeType.ENUMERATION) && (A_1 != AttributeType.NOTATION))
        {
            throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("瘶䴸伺似嘾⍀㙂ㅄ≆ᵈ㉊㵌⩎煐⡒敔⩖祘㉚⹜罞འౢᅤ䝦Ὠ੪Ŭٮᕰ卲፴ᡶ୸孺ᱼᅾꆀﮈ搜떔ﲘﶚ좠힢첤좦잨讪\udaac\uc6ae얰\udbb2\u95b4횶ힸ鮺\ud8bc\ud1be듀껂ꃄ뗆꣈뿊꣌ꯎꗒ듔믖곘뻚", num), new object[] { A_1 }));
        }
        this.string_1 = A_0;
        this.attributeType_0 = A_1;
    }

    public AttributeType method_6()
    {
        return this.attributeType_0;
    }

    public void method_7(string A_0)
    {
        int num = 6;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_117 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                dictionary1.Add(BookmarkStart.b("漫樭焯昱申", num), 0);
                dictionary1.Add(BookmarkStart.b("椫怭搯笱怳漵", num), 1);
                dictionary1.Add(BookmarkStart.b("椫怭搯笱怳缵紷椹", num), 2);
                dictionary1.Add(BookmarkStart.b("攫樭", num), 3);
                dictionary1.Add(BookmarkStart.b("攫樭戯眱爳", num), 4);
                dictionary1.Add(BookmarkStart.b("攫樭戯眱爳攵", num), 5);
                dictionary1.Add(BookmarkStart.b("戫漭累眱", num), 6);
                dictionary1.Add(BookmarkStart.b("戫漭累眱朳", num), 7);
                dictionary1.Add(BookmarkStart.b("戫挭搯紱缳猵瘷", num), 8);
                dictionary1.Add(BookmarkStart.b("戫挭搯紱缳猵瘷椹", num), 9);
                dictionary1.Add(BookmarkStart.b("戫笭累瀱焳搵", num), 10);
                dictionary1.Add(BookmarkStart.b("戫笭累瀱焳搵欷", num), 11);
                dictionary1.Add(BookmarkStart.b("戫笭搯紱缳猵瘷", num), 12);
                dictionary1.Add(BookmarkStart.b("戫笭搯紱缳猵瘷椹", num), 13);
                Class1160.dictionary_117 = dictionary1;
            }
            if (Class1160.dictionary_117.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.attributeType_0 = AttributeType.CDATA;
                        return;

                    case 1:
                        this.attributeType_0 = AttributeType.ENTITY;
                        return;

                    case 2:
                        this.attributeType_0 = AttributeType.ENTITIES;
                        return;

                    case 3:
                        this.attributeType_0 = AttributeType.ID;
                        return;

                    case 4:
                        this.attributeType_0 = AttributeType.IDREF;
                        return;

                    case 5:
                        this.attributeType_0 = AttributeType.IDREFS;
                        return;

                    case 6:
                        this.attributeType_0 = AttributeType.NAME;
                        return;

                    case 7:
                        this.attributeType_0 = AttributeType.NAMES;
                        return;

                    case 8:
                        this.attributeType_0 = AttributeType.NMTOKEN;
                        return;

                    case 9:
                        this.attributeType_0 = AttributeType.NMTOKENS;
                        return;

                    case 10:
                        this.attributeType_0 = AttributeType.NUMBER;
                        return;

                    case 11:
                        this.attributeType_0 = AttributeType.NUMBERS;
                        return;

                    case 12:
                        this.attributeType_0 = AttributeType.NUTOKEN;
                        return;

                    case 13:
                        this.attributeType_0 = AttributeType.NUTOKENS;
                        return;
                }
            }
        }
        throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("洫娭䐯䀱崳吵䴷丹夻ḽ㐿㭁㑃⍅桇浉㝋繍ⵏ畑瑓㽕⭗穙㉛ㅝᑟ䉡ᝣ፥ᡧᩩͫᱭѯ᝱ၳ", num), new object[] { A_0 }));
    }

    public bool method_8(string A_0)
    {
        int num = 5;
        bool flag = true;
        if (string.Equals(A_0, BookmarkStart.b("洪搬眮琰眲", 5), StringComparison.OrdinalIgnoreCase))
        {
            this.attributePresence_0 = AttributePresence.Fixed;
            return flag;
        }
        if (string.Equals(A_0, BookmarkStart.b("礪栬縮搰稲朴父紸", num), StringComparison.OrdinalIgnoreCase))
        {
            this.attributePresence_0 = AttributePresence.Required;
            return false;
        }
        if (!string.Equals(A_0, BookmarkStart.b("截怬缮細稲瀴猶", num), StringComparison.OrdinalIgnoreCase))
        {
            throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("横夬嬮䌰娲圴䈶䴸帺ᴼ䤾⁀⽂い≆楈汊㙌罎ⱐ瑒畔㥖㙘⽚絜ⱞᑠ።ᕤࡦ᭨Ὢ࡬୮", num), new object[] { A_0 }));
        }
        this.attributePresence_0 = AttributePresence.Implied;
        return false;
    }
}

