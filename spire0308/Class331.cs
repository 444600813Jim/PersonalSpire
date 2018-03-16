using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class331
{
    private const string string_0 = "Import of element '{0}' is not supported.";

    private Class331()
    {
    }

    internal static ShapeObject smethod_0(Interface50 A_0)
    {
        int num = 8;
        Class1132 class2 = null;
        string str = "";
        string str2 = "";
        Class394 class3 = A_0.imethod_1();
        while (class3.method_19())
        {
            string str7 = class3.method_3();
            string str4 = class3.method_1();
            if (str4 != null)
            {
                if (str4 != BookmarkStart.b("䜭启", num))
                {
                    if (!(str4 == BookmarkStart.b("崭堯匱䐳匵儷帹", num)))
                    {
                        if (str4 == BookmarkStart.b("䀭儯弱儳", num))
                        {
                        }
                    }
                    else
                    {
                        str = str7;
                    }
                }
                else
                {
                    str2 = str7;
                }
            }
        }
        ShapeObject obj2 = (ShapeObject) A_0.imethod_8(str);
        obj2.SetShapeType(ShapeType.OleControl);
        Class467 class5 = new Class467(A_0.imethod_4(str2), string.Empty);
        Class394 class6 = new Class394(class5.method_4());
        string str6 = class6.method_12(BookmarkStart.b("席唯䀱䜳張䬷丹夻倽⌿❁", num), null);
        string g = class6.method_12(BookmarkStart.b("䴭尯匱䜳䔵儷帹", num), null);
        string str3 = str6;
        if (str3 != null)
        {
            if (str3 == BookmarkStart.b("席唯䀱䜳張䬷丹氻䰽⼿㉁⅃㑅㱇㍉๋⽍㝏", num))
            {
                return obj2;
            }
            if ((str3 == BookmarkStart.b("席唯䀱䜳張䬷丹漻䨽⼿ぁ╃ⅅⵇ", num)) || (str3 == BookmarkStart.b("席唯䀱䜳張䬷丹漻䨽㈿❁╃⭅", num)))
            {
                Class467 class4 = new Class467(class5.method_8(BookmarkStart.b("尭礯嘱Գ", num)), string.Empty);
                if (str6 == BookmarkStart.b("席唯䀱䜳張䬷丹漻䨽⼿ぁ╃ⅅⵇ", num))
                {
                    class2 = new Class1132(class4.method_10());
                    return obj2;
                }
                class2 = new Class1132(new Guid(g));
                class2.method_0().method_2(BookmarkStart.b("ⴭ缯焱氳爵礷渹紻", num), class4.method_10());
                return obj2;
            }
            if (str3 == BookmarkStart.b("席唯䀱䜳張䬷丹漻䨽㈿❁╃⭅Ň⑉╋㩍", num))
            {
                return obj2;
            }
        }
        throw new InvalidOperationException(BookmarkStart.b("札帯䐱唳娵儷帹᰻丽┿ぁ㝃⽅㭇㹉⥋⁍㍏㝑瑓⁕㥗㙙⥛㭝也", num));
    }

    internal static ShapeObject smethod_1(Interface50 A_0)
    {
        int num = 13;
        string str = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";
        string str5 = "";
        string str6 = "";
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string str7 = class2.method_3();
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_11 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("圲吴䌶堸", num), 0);
                    dictionary1.Add(BookmarkStart.b("娲儴", num), 1);
                    dictionary1.Add(BookmarkStart.b("崲吴娶尸", num), 2);
                    dictionary1.Add(BookmarkStart.b("倲头嘶䨸䠺吼嬾", num), 3);
                    dictionary1.Add(BookmarkStart.b("䀲崴嘶䤸帺吼嬾", num), 4);
                    dictionary1.Add(BookmarkStart.b("倲头嘶䨸䠺", num), 5);
                    dictionary1.Add(BookmarkStart.b("䐲", num), 6);
                    dictionary1.Add(BookmarkStart.b("嬲", num), 7);
                    dictionary1.Add(BookmarkStart.b("刲头帶常唺", num), 8);
                    dictionary1.Add(BookmarkStart.b("娲攴制䬸䠺吼䰾㕀ፂ㝄⡆㥈⹊㽌㭎⡐ᅒ㑔ざ", num), 9);
                    Class1160.dictionary_11 = dictionary1;
                }
                if (Class1160.dictionary_11.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            str = str7;
                            break;

                        case 2:
                            str2 = str7;
                            break;

                        case 3:
                            str6 = str7;
                            break;

                        case 4:
                            str3 = str7;
                            break;

                        case 6:
                            str4 = str7;
                            break;

                        case 7:
                            str5 = str7;
                            break;
                    }
                }
            }
        }
        ShapeObject obj2 = (ShapeObject) A_0.imethod_8(str3);
        if (obj2 == null)
        {
            obj2 = new ShapeObject(A_0.imethod_0());
            obj2.SetShapeType(ShapeType.OleControl);
            obj2.TextWrappingStyle = TextWrappingStyle.Inline;
        }
        if (!string.IsNullOrEmpty(str4))
        {
            obj2.method_37(Class509.smethod_2(Class1041.smethod_12(str4)));
        }
        if (!string.IsNullOrEmpty(str5))
        {
            obj2.method_39(Class509.smethod_2(Class1041.smethod_12(str5)));
        }
        Class1132 class3 = null;
        if (str.StartsWith(BookmarkStart.b("眲琴挶砸ĺ尼伾ㅀ⽂ⱄ⑆⡈㽊⑌⁎㽐籒ⵔ穖㙘㝚㡜ぞ͠ॢdѦᵨ偪⽬⹮≰㙲䍴䍶啸", num)))
        {
            byte[] buffer2 = Convert.FromBase64String(str.Substring(BookmarkStart.b("眲琴挶砸ĺ尼伾ㅀ⽂ⱄ⑆⡈㽊⑌⁎㽐籒ⵔ穖㙘㝚㡜ぞ͠ॢdѦᵨ偪⽬⹮≰㙲䍴䍶啸", num).Length));
            if (str6.StartsWith(BookmarkStart.b("瀲礴搶瀸缺ܼ", num)))
            {
                str6 = str6.Substring(BookmarkStart.b("瀲礴搶瀸缺ܼ", num).Length);
            }
            Guid guid = !string.IsNullOrEmpty(str6) ? new Guid(str6) : Guid.Empty;
            class3 = new Class1132(new Class1089(guid));
            class3.method_0().method_2(BookmarkStart.b("〲稴琶愸缺簼款@", num), new MemoryStream(buffer2));
        }
        else
        {
            byte[] buffer = A_0.imethod_3(str);
            if (buffer != null)
            {
                class3 = new Class1132(new MemoryStream(buffer));
            }
        }
        if (class3 != null)
        {
            Class627.smethod_6(class3.method_0(), new Class221(str2));
            Class627.smethod_6(class3.method_0(), new Class320(OdtPersist1.Ocx | OdtPersist1.RecomposeOnResize, OdtPersist2.QueriedEmf, OdtClipboardFormat.Metafile));
        }
        return obj2;
    }

    internal static void smethod_2(Interface50 A_0)
    {
        int num = 13;
        bool flag = false;
        string str = null;
        string str2 = null;
        string str3 = null;
        string str4 = "";
        bool flag2 = false;
        bool flag3 = false;
        string str5 = null;
        Class394 class2 = A_0.imethod_1();
        while (class2.method_19())
        {
            string key = class2.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_12 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                    dictionary1.Add(BookmarkStart.b("朲䰴䜶尸", num), 0);
                    dictionary1.Add(BookmarkStart.b("挲䜴堶常爺礼", num), 1);
                    dictionary1.Add(BookmarkStart.b("怲崴嘶䤸帺琼笾", num), 2);
                    dictionary1.Add(BookmarkStart.b("眲䜴嘶丸稺丼伾⑀⁂ㅄ", num), 3);
                    dictionary1.Add(BookmarkStart.b("簲圴崶尸堺䤼瘾Հ", num), 4);
                    dictionary1.Add(BookmarkStart.b("縲娴夶倸债堼䴾", num), 5);
                    dictionary1.Add(BookmarkStart.b("昲䔴匶堸伺堼爾⹀❂⁄", num), 6);
                    dictionary1.Add(BookmarkStart.b("娲儴", num), 7);
                    Class1160.dictionary_12 = dictionary1;
                }
                if (Class1160.dictionary_12.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            flag = Class567.smethod_41(class2.method_3(), BookmarkStart.b("缲尴夶券", num));
                            break;

                        case 1:
                            str = class2.method_3();
                            break;

                        case 2:
                            str2 = class2.method_3();
                            break;

                        case 3:
                            flag3 = Class567.smethod_41(class2.method_3(), BookmarkStart.b("稲嘴堶圸", num));
                            break;

                        case 4:
                            str3 = class2.method_3();
                            break;

                        case 5:
                            str4 = class2.method_3();
                            break;

                        case 6:
                            flag2 = Class567.smethod_41(class2.method_3(), BookmarkStart.b("爲头䀶堸䈺丼", num));
                            break;

                        case 7:
                            str5 = class2.method_3();
                            break;
                    }
                }
            }
        }
        ShapeObject obj2 = (ShapeObject) A_0.imethod_8(str2);
        if (obj2 != null)
        {
            obj2.SetShapeType(ShapeType.OleObject);
            DocOleObject oleFormat = obj2.OleFormat;
            oleFormat.AutoUpdate = flag2;
            oleFormat.Interface49.set_DisplayAsIcon(flag3);
            if (str != null)
            {
                oleFormat.Interface49.set_ObjectType(str);
            }
            if (flag)
            {
                oleFormat.method_86(OleLinkType.Link);
                if (!string.IsNullOrEmpty(str5))
                {
                    if (A_0.imethod_5(str5))
                    {
                        str4 = A_0.imethod_4(str5);
                    }
                    else
                    {
                        str4 = (A_0 as Class466).method_0().method_184(str5);
                        oleFormat.Interface49.set_LinkPath(str4);
                    }
                }
                if (!string.IsNullOrEmpty(str4))
                {
                    string[] strArray = str4.Split(new char[] { '!' }, 2);
                    oleFormat.SourceFullName = strArray[0];
                    if (strArray.Length > 1)
                    {
                        oleFormat.SourceItem = strArray[1];
                    }
                }
            }
            else
            {
                string str8 = !string.IsNullOrEmpty(str5) ? str5 : str3;
                A_0.imethod_2(str8, oleFormat);
            }
            while (class2.method_9(BookmarkStart.b("簲礴父瘸夺圼娾≀㝂", num)))
            {
                string str6;
                if (((str6 = class2.method_1()) != null) && (str6 != BookmarkStart.b("缲尴夶券漺䐼伾⑀", num)))
                {
                    if (!(str6 == BookmarkStart.b("缲娴吶券帺夼社⡀♂⥄⍆", num)))
                    {
                        if ((str6 == BookmarkStart.b("搲娴䔶崸紺吼娾ⵀ❂ل⡆ⵈ⹊㹌", num)) || (str6 == BookmarkStart.b("甲尴制唸强縼倾╀♂㙄", num)))
                        {
                        }
                    }
                    else
                    {
                        oleFormat.IsLocked = class2.method_33(true);
                    }
                }
            }
        }
    }
}

