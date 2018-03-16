using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

internal class Class406 : Class403
{
    public Class406()
    {
    }

    public Class406(Stream A_0)
    {
        this.method_10(A_0);
    }

    public Class406(string A_0)
    {
        using (Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
        {
            this.method_10(stream);
        }
    }

    private void method_10(Stream A_0)
    {
        this.method_11(A_0);
        base.method_3();
    }

    private void method_11(Stream A_0)
    {
        int num = 9;
        Class393 class2 = new Class393(A_0);
        while (class2.method_9(BookmarkStart.b("弮倰倲帴嘶常帺", num)))
        {
            if (class2.method_1() != BookmarkStart.b("弮倰䄲䄴", num))
            {
                class2.vmethod_1();
            }
            else
            {
                Class467 class3 = smethod_4(class2);
                base.method_0().method_2(class3);
            }
        }
    }

    private static Class467 smethod_4(Class393 A_0)
    {
        int num = 6;
        string str = A_0.method_12(BookmarkStart.b("䈫伭崯圱", 6), "");
        string str2 = A_0.method_12(BookmarkStart.b("伫䄭帯䘱儳堵䰷渹䔻丽┿", 6), "");
        A_0.method_12(BookmarkStart.b("伫䄭崯䈱䘳匵䬷䤹唻儽⸿", 6), BookmarkStart.b("弫娭弯䀱儳", 6));
        Class467 class2 = new Class467(str, str2);
        A_0.method_9(BookmarkStart.b("尫伭䈯䘱", 6));
        string str3 = A_0.method_1();
        if (str3 != null)
        {
            if (!(str3 == BookmarkStart.b("含䌭尯瘱唳䈵夷", num)))
            {
                if (str3 == BookmarkStart.b("丫䜭帯匱䘳伵簷嬹䠻弽", num))
                {
                    byte[] buffer = Convert.FromBase64String(A_0.method_21());
                    class2.method_4().Write(buffer, 0, buffer.Length);
                }
            }
            else
            {
                StreamWriter writer = new StreamWriter(class2.method_4());
                A_0.method_9(BookmarkStart.b("含䌭尯瘱唳䈵夷", num));
                writer.Write(A_0.method_24());
                writer.Flush();
            }
        }
        class2.method_4().Position = 0L;
        return class2;
    }

    public override void vmethod_0(Stream A_0)
    {
        int num = 6;
        Class397 class2 = new Class397(A_0, true);
        class2.method_0().method_17(true);
        class2.method_0().method_19(BookmarkStart.b("䄫崭弯ἱ唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇", 6), BookmarkStart.b("尫尭弯唱崳刵Էᠹ欻儽㈿♁橃Ʌ❇⥉㥋⍍㕏㱑⁓瑕", 6));
        class2.method_4(BookmarkStart.b("尫䔭圯࠱䐳圵嬷儹崻夽┿", 6));
        class2.method_18(BookmarkStart.b("含䌭尯就䜳వ䠷儹嬻", 6), BookmarkStart.b("䐫娭䐯䈱ำᤵ᜷䤹弻嘽┿⽁╃㕅晇❉╋ⵍ≏㵑❓㥕㹗⹙牛㵝ཟཡ䭣॥๧౩ի൭ᕯ嵱䙳䙵䡷䱹卻ٽ풃", 6));
        foreach (Class467 class3 in (IEnumerable) base.method_0())
        {
            class3.method_4().Position = 0L;
            class2.method_4(BookmarkStart.b("尫䔭圯࠱䐳圵䨷丹", num));
            class2.method_18(BookmarkStart.b("尫䔭圯࠱娳圵唷弹", num), class3.method_0());
            class2.method_18(BookmarkStart.b("尫䔭圯࠱圳夵嘷丹夻倽㐿ᙁ㵃㙅ⵇ", num), class3.method_2());
            if (!class3.method_2().EndsWith(BookmarkStart.b("含䌭尯", num)))
            {
                class2.method_18(BookmarkStart.b("尫䔭圯࠱圳夵唷䨹主嬽㌿ㅁⵃ⥅♇", num), BookmarkStart.b("弫娭弯䀱儳", num));
                class2.method_4(BookmarkStart.b("尫䔭圯࠱嘳張嘷嬹主䜽п⍁ぃ❅", num));
                class2.method_19(class3.method_4());
                class2.method_5();
            }
            else
            {
                string input = new StreamReader(class3.method_4()).ReadToEnd();
                input = new Regex(BookmarkStart.b("ါ爭༯ᰱḳ樵ܷй", num)).Replace(input, "");
                class2.method_4(BookmarkStart.b("尫䔭圯࠱䰳嬵吷縹崻䨽ℿ", num));
                class2.method_9(input);
                class2.method_5();
            }
            class2.method_5();
        }
        class2.method_3();
    }
}

