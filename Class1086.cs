using Spire.Doc;
using System;
using System.Collections;
using System.Drawing;

internal class Class1086
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();

    static Class1086()
    {
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("夶嘸唺堼", 0x11), Color.Transparent, BookmarkStart.b("娶堸䤺刼倾⽀", 0x11), Color.Maroon, BookmarkStart.b("䔶尸强", 0x11), Color.Red, BookmarkStart.b("堶䬸娺匼堾⑀", 0x11), Color.Orange, BookmarkStart.b("丶尸场儼倾㙀", 0x11), Color.Yellow, BookmarkStart.b("堶唸刺䬼娾", 0x11), Color.Olive, BookmarkStart.b("䜶䰸䤺䴼匾⑀", 0x11), Color.Purple, BookmarkStart.b("儶䰸堺唼䰾⡀≂", 0x11), Color.Fuchsia, 
            BookmarkStart.b("䀶儸刺䤼娾", 0x11), Color.White, BookmarkStart.b("嬶倸嘺堼", 0x11), Color.Lime, BookmarkStart.b("倶䬸帺堼儾", 0x11), Color.Green, BookmarkStart.b("夶堸䴺䐼", 0x11), Color.Navy, BookmarkStart.b("唶唸为堼", 0x11), Color.Blue, BookmarkStart.b("嘶䠸为尼", 0x11), Color.Aqua, BookmarkStart.b("䌶尸娺儼", 0x11), Color.Teal, BookmarkStart.b("唶唸娺帼吾", 0x11), Color.Black, 
            BookmarkStart.b("䐶倸场䬼娾㍀", 0x11), Color.Silver, BookmarkStart.b("倶䬸娺䐼", 0x11), Color.Gray
         }, hashtable_0, hashtable_1);
    }

    internal static Color smethod_0(string A_0)
    {
        return (Color) Class791.smethod_3(hashtable_0, A_0, Color.Empty);
    }

    internal static string smethod_1(Color A_0)
    {
        return (string) Class791.smethod_3(hashtable_1, A_0, "");
    }
}

