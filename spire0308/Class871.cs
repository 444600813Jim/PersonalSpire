using Spire.Doc;
using Spire.Doc.Documents.Markup;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class871
{
    private Class871()
    {
    }

    internal static void smethod_0(Class1132 A_0, CustomXmlPartCollection A_1)
    {
        int num = 5;
        Class1089 class2 = A_0.method_0().method_6(BookmarkStart.b("昪帬䀮田刲䄴嘶樸伺刼䴾⑀", 5));
        if (class2 != null)
        {
            foreach (DictionaryEntry entry in class2)
            {
                CustomXmlPart part = new CustomXmlPart();
                Class1089 class3 = (Class1089) entry.Value;
                foreach (DictionaryEntry entry2 in class3)
                {
                    string key = (string) entry2.Key;
                    if (key != null)
                    {
                        if (!(key == BookmarkStart.b("截夬䨮尰", num)))
                        {
                            if (key == BookmarkStart.b("笪弬䀮䄰嘲䜴䌶倸帺丼", num))
                            {
                                smethod_1((Stream) entry2.Value, part);
                            }
                        }
                        else
                        {
                            part.Data = Class567.smethod_10((Stream) entry2.Value);
                        }
                    }
                }
                A_1.Add(part);
            }
        }
    }

    internal static void smethod_1(Stream A_0, CustomXmlPart A_1)
    {
        int num = 7;
        if (A_0.Length != 0L)
        {
            Class394 class2 = new Class394(A_0);
            while (class2.method_19())
            {
                string str;
                if (((str = class2.method_1()) != null) && (str == BookmarkStart.b("䐬嬮吰帲簴猶", num)))
                {
                    A_1.Id = class2.method_3();
                }
            }
            class2.method_18();
            while (class2.method_9(BookmarkStart.b("䤬丮䔰刲䘴䌶嘸䤺堼瘾㕀♂⡄", num)))
            {
                string str2;
                if (((str2 = class2.method_1()) != null) && (str2 == BookmarkStart.b("帬䰮夰嘲場嘶欸帺嬼䰾", num)))
                {
                    smethod_2(class2, A_1);
                }
                else
                {
                    class2.vmethod_1();
                }
            }
        }
    }

    private static void smethod_2(Class394 A_0, CustomXmlPart A_1)
    {
        int num = 6;
        while (A_0.method_9(BookmarkStart.b("弫䴭堯圱夳圵樷弹娻䴽", num)))
        {
            string str;
            if (((str = A_0.method_1()) != null) && (str == BookmarkStart.b("弫䴭堯圱夳圵樷弹娻", num)))
            {
                smethod_3(A_0, A_1);
            }
            else
            {
                A_0.vmethod_1();
            }
        }
    }

    private static void smethod_3(Class394 A_0, CustomXmlPart A_1)
    {
        int num = 9;
        while (A_0.method_19())
        {
            string str;
            if (((str = A_0.method_1()) != null) && (str == BookmarkStart.b("娮䌰娲", num)))
            {
                A_1.Schemas.method_3(A_0.method_3());
            }
        }
    }

    internal static Class1089 smethod_4(CustomXmlPartCollection A_0)
    {
        int num = 7;
        if (A_0.Count == 0)
        {
            return null;
        }
        Class1089 class4 = new Class1089();
        for (int i = 0; i < A_0.Count; i++)
        {
            CustomXmlPart part = A_0[i];
            Class1089 class3 = new Class1089();
            class3.method_2(BookmarkStart.b("搬嬮吰帲", num), new MemoryStream(part.Data));
            Stream stream = new MemoryStream();
            Class397 class2 = new Class397(stream, Encoding.UTF8, false);
            if (class2.method_0().method_1().Count == 0)
            {
                class2.method_0().method_1().Add(BookmarkStart.b("䤬尮", num), BookmarkStart.b("䔬嬮䔰䌲༴ᠶᘸ䠺帼圾⑀⹂⑄㑆杈⑊㵌⩎㽐⭒㡔㭖㽘㑚⽜㉞`ᝢᙤ䥦٨ᥪ੬䁮Ṱᕲ፴Ṷ᩸Ṻ㥼ၾﾊꊌ붎ꆐꎒꎔ뢖滛캠캢ﶤ쪦얨", num));
            }
            smethod_5(part, class2);
            class3.Add(BookmarkStart.b("紬崮帰䌲倴䔶䴸刺堼䰾", num), stream);
            class4.method_3(string.Format(BookmarkStart.b("丬圮唰䀲临ܶ䐸", num), i), class3);
        }
        return class4;
    }

    internal static void smethod_5(CustomXmlPart A_0, Class397 A_1)
    {
        int num = 11;
        A_1.method_2(BookmarkStart.b("唰䀲༴匶堸伺尼䰾㕀ⱂ㝄≆H㽊⡌≎", 11));
        A_1.method_18(BookmarkStart.b("唰䀲༴帶䴸帺值瘾Հ", 11), A_0.Id);
        A_1.method_18(BookmarkStart.b("䤰帲头夶䨸ĺ夼䰾", 11), BookmarkStart.b("夰䜲䄴䜶̸ᐺሼ䰾≀⭂⁄⩆⡈㡊捌⁎⅐㙒㭔⽖㑘㝚㭜ぞ፠๢Ѥ፦ᩨ䕪ɬᵮᙰ屲ᩴᅶὸቺṼ᩾얀ﮎ뺐ꆒꖔꞖ꾘뒚ﺜ튠힢쪤쪦욪솬", 11));
        A_1.method_4(BookmarkStart.b("唰䀲༴䐶娸区堼刾⁀ᅂ⁄ⅆ㩈", 11));
        using (IEnumerator enumerator = A_0.Schemas.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                string current = (string) enumerator.Current;
                A_1.method_4(BookmarkStart.b("唰䀲༴䐶娸区堼刾⁀ᅂ⁄ⅆ", num));
                A_1.method_18(BookmarkStart.b("唰䀲༴䈶䬸刺", num), current);
                A_1.method_6(BookmarkStart.b("唰䀲༴䐶娸区堼刾⁀ᅂ⁄ⅆ", num));
            }
        }
        A_1.method_6(BookmarkStart.b("唰䀲༴䐶娸区堼刾⁀ᅂ⁄ⅆ㩈", num));
        A_1.method_3();
    }
}

