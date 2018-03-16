using Spire.Doc;
using Spire.Doc.Documents.Converters;
using System;
using System.Collections;

internal class Class330
{
    private static Hashtable hashtable_0 = new Hashtable();
    private static Hashtable hashtable_1 = new Hashtable();
    private static Hashtable hashtable_2 = new Hashtable();
    private static Hashtable hashtable_3 = new Hashtable();
    private static Hashtable hashtable_4 = new Hashtable();
    private static Hashtable hashtable_5 = new Hashtable();
    private static Hashtable hashtable_6 = new Hashtable();
    private static Hashtable hashtable_7 = new Hashtable();

    static Class330()
    {
        Class791.smethod_0(new object[] { BookmarkStart.b("帯崱娳匵", 10), ZoomType.None, BookmarkStart.b("嘯䜱堳娵ᔷ䨹崻夽┿", 10), ZoomType.FullPage, BookmarkStart.b("刯圱䜳䈵ᔷ尹唻䨽", 10), ZoomType.PageWidth, BookmarkStart.b("䐯圱䰳䈵ᔷ尹唻䨽", 10), ZoomType.TextFit }, hashtable_4, hashtable_5);
        Class791.smethod_0(new object[] { BookmarkStart.b("尯圱䀳䈵崷䠹", 10), AutoFormatDocumentType.Letter, BookmarkStart.b("唯ἱ夳圵儷嘹", 10), AutoFormatDocumentType.Email }, hashtable_6, hashtable_7);
        Class791.smethod_0(new object[] { BookmarkStart.b("猯崱夳䘵䨷弹伻䴽ဿ㝁⩃╅㱇㽉ⵋ㩍㥏㵑㩓", 10), CharacterSpacing.compressPunctuation, BookmarkStart.b("猯崱夳䘵䨷弹伻䴽ဿ㝁⩃╅㱇㽉ⵋ㩍㥏㵑㩓᝕㙗㹙ᙛ㽝ၟ͡੣ͥ᭧ཀྵ❫཭ṯ፱", 10), CharacterSpacing.compressPunctuationAndJapaneseKana, BookmarkStart.b("琯崱娳䈵笷唹儻丽㈿❁㝃㕅", 10), CharacterSpacing.doNotCompress }, hashtable_2, hashtable_3);
        Class791.smethod_0(new object[] { BookmarkStart.b("䐯䀱唳唵匷弹堻ጽ⌿⩁╃⡅⽇⽉㽋", 10), ProtectionType.AllowOnlyRevisions, BookmarkStart.b("匯崱夳嬵崷吹䠻䴽", 10), ProtectionType.AllowOnlyComments, BookmarkStart.b("嘯崱䘳嬵䬷", 10), ProtectionType.AllowOnlyFormFields, BookmarkStart.b("䈯圱唳刵ᔷ唹刻刽㤿", 10), ProtectionType.AllowOnlyReading, BookmarkStart.b("帯崱娳匵", 10), ProtectionType.NoProtection }, hashtable_0, hashtable_1);
    }

    internal static ProtectionType smethod_0(string A_0)
    {
        return (ProtectionType) Class791.smethod_3(hashtable_0, A_0, ProtectionType.NoProtection);
    }

    internal static string smethod_1(ProtectionType A_0)
    {
        return (string) Class791.smethod_3(hashtable_1, A_0, BookmarkStart.b("䔪䈬䄮吰", 5));
    }

    internal static AutoFormatDocumentType smethod_10(string A_0)
    {
        return (AutoFormatDocumentType) Class791.smethod_3(hashtable_6, A_0, AutoFormatDocumentType.Normal);
    }

    internal static string smethod_11(AutoFormatDocumentType A_0)
    {
        return (string) Class791.smethod_3(hashtable_7, A_0, "");
    }

    internal static CharacterSpacing smethod_2(string A_0)
    {
        return (CharacterSpacing) Class791.smethod_3(hashtable_2, A_0, CharacterSpacing.doNotCompress);
    }

    internal static string smethod_3(CharacterSpacing A_0)
    {
        return (string) Class791.smethod_3(hashtable_3, A_0, BookmarkStart.b("田尲嬴䌶稸吺值伾㍀♂㙄㑆", 11));
    }

    internal static ProofState smethod_4(string A_0)
    {
        string str;
        int num = 7;
        if (((str = A_0) != null) && (str == BookmarkStart.b("丬䌮吰刲嬴", num)))
        {
            return ProofState.Clean;
        }
        return ProofState.None;
    }

    internal static string smethod_5(ProofState A_0)
    {
        int num = 9;
        if (A_0 == ProofState.Clean)
        {
            return BookmarkStart.b("䰮崰嘲吴夶", num);
        }
        return "";
    }

    internal static DocumentViewType smethod_6(string A_0)
    {
        int num = 3;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䜨䐪弬䈮倰弲", num))
            {
                return DocumentViewType.NormalLayout;
            }
            if (str == BookmarkStart.b("夨太䐬䄮䔰", num))
            {
                return DocumentViewType.PrintLayout;
            }
            if (str == BookmarkStart.b("䘨帪夬䌮堰崲倴", num))
            {
                return DocumentViewType.OutlineLayout;
            }
            if (str == BookmarkStart.b("䐨䨪帬嬮吰䄲ᠴ䜶堸尺堼䰾", num))
            {
                return DocumentViewType.OutlineLayout;
            }
            if (str == BookmarkStart.b("帨个伬", num))
            {
                return DocumentViewType.WebLayout;
            }
        }
        return DocumentViewType.PrintLayout;
    }

    internal static string smethod_7(DocumentViewType A_0)
    {
        int num = 15;
        switch (A_0)
        {
            case DocumentViewType.PrintLayout:
                return BookmarkStart.b("䔴䔶倸唺䤼", num);

            case DocumentViewType.OutlineLayout:
                return BookmarkStart.b("場嘶䨸伺堼䴾汀㍂⑄⁆ⱈ㡊", num);

            case DocumentViewType.NormalLayout:
                return BookmarkStart.b("嬴堶䬸嘺尼匾", num);

            case DocumentViewType.WebLayout:
                return BookmarkStart.b("䈴制嬸", num);
        }
        return BookmarkStart.b("䔴䔶倸唺䤼", num);
    }

    internal static ZoomType smethod_8(string A_0)
    {
        return (ZoomType) Class791.smethod_3(hashtable_4, A_0, ZoomType.None);
    }

    internal static string smethod_9(ZoomType A_0)
    {
        return (string) Class791.smethod_3(hashtable_5, A_0, BookmarkStart.b("䤦䘨䔪䠬", 1));
    }
}

