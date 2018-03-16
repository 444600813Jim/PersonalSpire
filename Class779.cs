using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;

internal class Class779
{
    private static volatile Hashtable hashtable_0;
    private static readonly object object_0 = new object();

    internal static Class1025 smethod_0(PageBorderArt A_0)
    {
        int num = 11;
        if (!smethod_2().Contains((int) A_0))
        {
            throw new InvalidOperationException(BookmarkStart.b("搰崲帴夶嘸䰺匼Ἶ⍀ⱂ㝄⍆ⱈ㥊浌⹎⍐❒答", num));
        }
        return (Class1025) smethod_2()[(int) A_0];
    }

    private static Hashtable smethod_1()
    {
        int num = 7;
        Hashtable hashtable = new Hashtable();
        using (Stream stream = sprἊ.ᜂ(BookmarkStart.b("縬弮堰䄲倴ᤶ紸吺帼ᄾፀ♂㙄⡆㱈㥊⹌⩎≐絒Ք㙖㹘㹚὜ぞ፠ݢdᕦ⡨ᥪᥬ䅮㕰ᙲ፴Ṷ᝸ቺॼᙾꦆ", 7)))
        {
            spr⋓ r⋓ = new spr⋓(stream);
            while (r⋓.ᜁ(BookmarkStart.b("漬䀮䌰圲倴䔶砸䤺䤼笾⑀╂ⱄ⥆⁈㽊⑌⁎㽐⁒", num)))
            {
                Class1025 class2 = new Class1025(Convert.ToInt32(r⋓.ᜀ(BookmarkStart.b("䐬䬮", num), BookmarkStart.b(",Ḯ", num))), Convert.ToInt32(r⋓.ᜀ(BookmarkStart.b("丬䀮弰䜲䜴嘶娸伺吼倾⽀", num), BookmarkStart.b("ᴬ", num))), Convert.ToInt32(r⋓.ᜀ(BookmarkStart.b("䔬䨮䤰䌲吴夶䨸刺刼儾", num), BookmarkStart.b("ᴬ", num))), Convert.ToInt32(r⋓.ᜀ(BookmarkStart.b("嬬䨮䤰䌲吴夶䨸刺刼儾", num), BookmarkStart.b("ᴬ", num))));
                class2.method_3(BorderType.Top, PageBorderArtElementPosition.First, smethod_3(r⋓.ᜀ(BookmarkStart.b("夬䌮", num), "")));
                class2.method_3(BorderType.Top, PageBorderArtElementPosition.Middle, smethod_3(r⋓.ᜀ(BookmarkStart.b("夬", num), "")));
                class2.method_3(BorderType.Top, PageBorderArtElementPosition.Last, smethod_3(r⋓.ᜀ(BookmarkStart.b("夬崮", num), "")));
                class2.method_3(BorderType.Left, PageBorderArtElementPosition.Middle, smethod_3(r⋓.ᜀ(BookmarkStart.b("䄬", num), "")));
                class2.method_3(BorderType.Right, PageBorderArtElementPosition.Middle, smethod_3(r⋓.ᜀ(BookmarkStart.b("弬", num), "")));
                class2.method_3(BorderType.Bottom, PageBorderArtElementPosition.First, smethod_3(r⋓.ᜀ(BookmarkStart.b("伬䌮", num), "")));
                class2.method_3(BorderType.Bottom, PageBorderArtElementPosition.Middle, smethod_3(r⋓.ᜀ(BookmarkStart.b("伬", num), "")));
                class2.method_3(BorderType.Bottom, PageBorderArtElementPosition.Last, smethod_3(r⋓.ᜀ(BookmarkStart.b("伬崮", num), "")));
                hashtable.Add(class2.method_0(), class2);
            }
        }
        return hashtable;
    }

    private static Hashtable smethod_2()
    {
        if (hashtable_0 == null)
        {
            lock (object_0)
            {
                if (hashtable_0 == null)
                {
                    hashtable_0 = smethod_1();
                }
            }
        }
        return hashtable_0;
    }

    internal static byte[] smethod_3(string A_0)
    {
        byte[] buffer;
        int num = 12;
        try
        {
            using (Stream stream = sprἊ.ᜂ(string.Format(BookmarkStart.b("愱䐳張䨷弹ሻ稽⼿⅁橃ᑅⵇ㥉⍋㭍≏ㅑㅓ╕癗ਖ਼㵛㥝՟⁡ୣᑥ౧ཀྵṫ⽭ɯٱ婳൵䡷ݹ", num), A_0)))
            {
                spr❯ r❯ = spr❯.ᜀ(1, 1, 96.0, 96.0);
                buffer = spr≨.ᜀ(sprḆ.ᜀ(stream), r❯);
            }
        }
        catch
        {
            buffer = new byte[0];
        }
        return buffer;
    }
}

