using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class533
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();

    static Class533()
    {
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("搰崲尴䘶䰸帺ᴼ瘾╀♂⭄㍆⁈ⵊ⑌⩎⍐", 11), PredefinedMergeFieldName.UniqueIdentifier, BookmarkStart.b("爰尲䀴䔶䴸帺丼䘾慀ᝂⱄ㍆╈⹊", 11), PredefinedMergeFieldName.CourtesyTitle, BookmarkStart.b("眰娲䜴䐶䴸ᬺ猼帾ⱀ♂", 11), PredefinedMergeFieldName.FirstName, BookmarkStart.b("簰娲儴匶唸帺ᴼ焾⁀⹂⁄", 11), PredefinedMergeFieldName.MiddleName, BookmarkStart.b("細刲䘴䌶ᤸ町尼刾⑀", 11), PredefinedMergeFieldName.LastName, BookmarkStart.b("戰䘲匴儶倸䌺", 11), PredefinedMergeFieldName.Suffix, BookmarkStart.b("缰娲嘴尶圸娺值娾", 11), PredefinedMergeFieldName.Nickname, BookmarkStart.b("笰尲圴᜶洸刺䤼匾⑀", 11), PredefinedMergeFieldName.JobTitle, 
            BookmarkStart.b("爰尲場䜶堸唺䐼", 11), PredefinedMergeFieldName.Company, BookmarkStart.b("瀰圲儴䔶尸䠺丼Ἶ灀", 11), PredefinedMergeFieldName.Address1, BookmarkStart.b("瀰圲儴䔶尸䠺丼Ἶ獀", 11), PredefinedMergeFieldName.Address2, BookmarkStart.b("爰娲䄴丶", 11), PredefinedMergeFieldName.City, BookmarkStart.b("戰䜲吴䌶尸", 11), PredefinedMergeFieldName.State, BookmarkStart.b("愰尲䘴䌶堸场ᴼ簾⹀❂⁄", 11), PredefinedMergeFieldName.PostalCode, BookmarkStart.b("爰尲䀴夶䴸䤺䐼Ἶ⹀ㅂ敄ᕆⱈⱊ⑌⁎㽐", 11), PredefinedMergeFieldName.CountryOrRegion, BookmarkStart.b("猰䘲䘴帶圸帺丼䰾慀ፂⵄ⡆❈⹊", 11), PredefinedMergeFieldName.BusinessPhone, 
            BookmarkStart.b("猰䘲䘴帶圸帺丼䰾慀Ղ⑄㽆", 11), PredefinedMergeFieldName.BusinessFax, BookmarkStart.b("礰尲場制ᤸ欺唼倾⽀♂", 11), PredefinedMergeFieldName.HomePhone, BookmarkStart.b("礰尲場制ᤸ紺尼䜾", 11), PredefinedMergeFieldName.HomeFax, BookmarkStart.b("琰Ḳ場嘶倸场ᴼ績╀❂㝄≆㩈㡊", 11), PredefinedMergeFieldName.EmailAddress, BookmarkStart.b("昰嘲圴᜶椸娺娼娾", 11), PredefinedMergeFieldName.WebPage, BookmarkStart.b("戰䌲娴䈶䨸帺ᴼ簾⹀㙂㝄㍆ⱈ㡊㑌潎Ր㩒⅔㭖㱘", 11), PredefinedMergeFieldName.SpouseCourtesyTitle, BookmarkStart.b("戰䌲娴䈶䨸帺ᴼ社⡀ㅂ㙄㍆楈Պⱌ≎㑐", 11), PredefinedMergeFieldName.SpouseFirstName, BookmarkStart.b("戰䌲娴䈶䨸帺ᴼ爾⡀❂⅄⭆ⱈ歊͌⹎㱐㙒", 11), PredefinedMergeFieldName.SpouseMiddleName, 
            BookmarkStart.b("戰䌲娴䈶䨸帺ᴼ猾⁀あㅄ杆݈⩊⁌⩎", 11), PredefinedMergeFieldName.SpouseLastName, BookmarkStart.b("戰䌲娴䈶䨸帺ᴼ焾⡀⁂⹄⥆⡈♊⡌", 11), PredefinedMergeFieldName.SpouseNickname, BookmarkStart.b("愰嬲娴夶尸伺吼尾慀тい⹆ⵈ⹊浌⥎㹐⅒畔ᅖじ⥚⹜⭞䅠ⵢѤ੦౨", 11), PredefinedMergeFieldName.PhoneticGuideForFirstName, BookmarkStart.b("愰嬲娴夶尸伺吼尾慀тい⹆ⵈ⹊浌⥎㹐⅒畔᭖㡘⡚⥜罞⽠ɢࡤɦ", 11), PredefinedMergeFieldName.PhoneticGuideForLastName, BookmarkStart.b("瀰圲儴䔶尸䠺丼Ἶ牀", 11), PredefinedMergeFieldName.Address3, BookmarkStart.b("田嘲䔴嘶䬸伺值娾⽀㝂", 11), PredefinedMergeFieldName.Department
         }, hashtable_0, hashtable_1);
    }

    private Class533()
    {
    }

    internal static MailMergeMainDocumentType smethod_0(string A_0)
    {
        int num = 7;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_47 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                dictionary1.Add(BookmarkStart.b("丬丮䔰刲头堶常", num), 0);
                dictionary1.Add(BookmarkStart.b("䠬䈮倰娲头", num), 1);
                dictionary1.Add(BookmarkStart.b("䠬䄮䜰嘲头堶䤸帺丼", num), 2);
                dictionary1.Add(BookmarkStart.b("䬬丮䤰", num), 3);
                dictionary1.Add(BookmarkStart.b("䬬䀮䌰帲礴制䴸伺堼䴾㉀", num), 4);
                dictionary1.Add(BookmarkStart.b("䬬䀮䌰帲ᠴ嬶尸伺䤼娾㍀あ", num), 5);
                dictionary1.Add(BookmarkStart.b("䀬丮堰弲尴夶常眺尼崾⑀⽂㙄", num), 6);
                dictionary1.Add(BookmarkStart.b("䀬丮堰弲尴夶常ᘺ儼帾⍀♂⥄㑆", num), 7);
                Class1160.dictionary_47 = dictionary1;
            }
            if (Class1160.dictionary_47.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return MailMergeMainDocumentType.Catalog;

                    case 1:
                        return MailMergeMainDocumentType.Email;

                    case 2:
                        return MailMergeMainDocumentType.Envelopes;

                    case 3:
                        return MailMergeMainDocumentType.Fax;

                    case 4:
                        return MailMergeMainDocumentType.FormLetters;

                    case 5:
                        return MailMergeMainDocumentType.FormLetters;

                    case 6:
                        return MailMergeMainDocumentType.MailingLabels;

                    case 7:
                        return MailMergeMainDocumentType.MailingLabels;
                }
            }
        }
        return MailMergeMainDocumentType.FormLetters;
    }

    internal static string smethod_1(MailMergeMainDocumentType A_0, bool A_1)
    {
        int num = 5;
        switch (A_0)
        {
            case MailMergeMainDocumentType.FormLetters:
                if (A_1)
                {
                    return BookmarkStart.b("䴪䈬崮尰缲倴䌶䴸帺似䰾", num);
                }
                return BookmarkStart.b("䴪䈬崮尰Ḳ头制䴸伺堼䴾㉀", num);

            case MailMergeMainDocumentType.MailingLabels:
                if (A_1)
                {
                    return BookmarkStart.b("䘪䰬䘮崰娲嬴倶甸娺弼娾ⵀあ", num);
                }
                return BookmarkStart.b("䘪䰬䘮崰娲嬴倶ᐸ场尼崾⑀⽂㙄", num);

            case MailMergeMainDocumentType.Envelopes:
                return BookmarkStart.b("个䌬央吰弲娴䜶尸䠺", num);

            case MailMergeMainDocumentType.Catalog:
                return BookmarkStart.b("䠪䰬嬮倰弲娴倶", num);

            case MailMergeMainDocumentType.Email:
                return BookmarkStart.b("个䀬丮堰弲", num);

            case MailMergeMainDocumentType.Fax:
                return BookmarkStart.b("䴪䰬圮", num);
        }
        throw new InvalidOperationException(BookmarkStart.b("縪䌬䐮弰尲䈴夶ᤸ嘺尼嘾ⵀ捂⡄≆㭈ⱊ⡌潎㱐㉒㱔㥖祘㽚㉜㱞ᑠ๢d०ᵨ䭪ᥬ᙮Űᙲ孴", num));
    }

    internal static PredefinedMergeFieldName smethod_10(string A_0)
    {
        return (PredefinedMergeFieldName) Class791.smethod_3(hashtable_0, A_0, PredefinedMergeFieldName.Invalid);
    }

    internal static string smethod_11(PredefinedMergeFieldName A_0)
    {
        return (string) Class791.smethod_3(hashtable_1, A_0, "");
    }

    internal static MailMergeDestination smethod_2(string A_0)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("帯圱䌳爵圷夹䤻匽┿ⱁぃ", num))
            {
                return MailMergeDestination.NewDocument;
            }
            if (str == BookmarkStart.b("帯圱䌳ᬵ尷唹弻䬽ⴿ❁⩃㉅", num))
            {
                return MailMergeDestination.NewDocument;
            }
            if (str == BookmarkStart.b("䀯䀱崳堵䰷弹主", num))
            {
                return MailMergeDestination.Printer;
            }
            if (str == BookmarkStart.b("唯弱唳張吷", num))
            {
                return MailMergeDestination.Email;
            }
            if (str == BookmarkStart.b("嘯匱䰳", num))
            {
                return MailMergeDestination.Fax;
            }
        }
        return MailMergeDestination.NewDocument;
    }

    internal static string smethod_3(MailMergeDestination A_0, bool A_1)
    {
        int num = 10;
        if (A_0 != MailMergeDestination.NewDocument)
        {
            switch (A_0)
            {
                case MailMergeDestination.NewDocument:
                    if (A_1)
                    {
                        return BookmarkStart.b("帯圱䌳爵圷夹䤻匽┿ⱁぃ", num);
                    }
                    return BookmarkStart.b("帯圱䌳ᬵ尷唹弻䬽ⴿ❁⩃㉅", num);

                case MailMergeDestination.Printer:
                    return BookmarkStart.b("䀯䀱崳堵䰷弹主", num);

                case MailMergeDestination.Email:
                    return BookmarkStart.b("唯弱唳張吷", num);

                case MailMergeDestination.Fax:
                    return BookmarkStart.b("嘯匱䰳", num);
            }
        }
        return "";
    }

    internal static MailMergeDataType smethod_4(string A_0)
    {
        int num = 4;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_48 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                dictionary1.Add(BookmarkStart.b("丩䴫娭儯倱唳䔵崷", num), 0);
                dictionary1.Add(BookmarkStart.b("欩伫䴭唯䄱䜳", num), 1);
                dictionary1.Add(BookmarkStart.b("䐩䴫娭夯䐱儳", num), 2);
                dictionary1.Add(BookmarkStart.b("攩栫紭缯", num), 3);
                dictionary1.Add(BookmarkStart.b("䔩䠫䰭匯", num), 4);
                dictionary1.Add(BookmarkStart.b("攩栫氭猯", num), 5);
                dictionary1.Add(BookmarkStart.b("嬩夫䬭䈯䬱", num), 6);
                dictionary1.Add(BookmarkStart.b("笩砫", num), 7);
                dictionary1.Add(BookmarkStart.b("天尫尭唯匱倳䔵倷弹夻䨽", num), 8);
                dictionary1.Add(BookmarkStart.b("漩含䴭唯帱", num), 9);
                dictionary1.Add(BookmarkStart.b("帩䤫嘭䐯琱崳娵崷", num), 10);
                dictionary1.Add(BookmarkStart.b("䰩䔫䈭唯", num), 11);
                Class1160.dictionary_48 = dictionary1;
            }
            if (Class1160.dictionary_48.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return MailMergeDataType.Database;

                    case 1:
                        return MailMergeDataType.Database;

                    case 2:
                        return MailMergeDataType.Native;

                    case 3:
                        return MailMergeDataType.Native;

                    case 4:
                        return MailMergeDataType.Odbc;

                    case 5:
                        return MailMergeDataType.Odbc;

                    case 6:
                        return MailMergeDataType.Query;

                    case 7:
                        return MailMergeDataType.Query;

                    case 8:
                        return MailMergeDataType.Spreadsheet;

                    case 9:
                        return MailMergeDataType.Spreadsheet;

                    case 10:
                        return MailMergeDataType.TextFile;

                    case 11:
                        return MailMergeDataType.TextFile;
                }
            }
        }
        return MailMergeDataType.None;
    }

    internal static string smethod_5(MailMergeDataType A_0, bool A_1)
    {
        int num = 11;
        switch (A_0)
        {
            case MailMergeDataType.TextFile:
                if (A_1)
                {
                    return BookmarkStart.b("䔰嘲䴴䌶缸刺儼娾", num);
                }
                return BookmarkStart.b("地娲头制", num);

            case MailMergeDataType.Database:
                if (A_1)
                {
                    return BookmarkStart.b("唰刲䄴嘶嬸娺丼娾", num);
                }
                return BookmarkStart.b("瀰倲嘴制䨸䠺", num);

            case MailMergeDataType.Spreadsheet:
                if (A_1)
                {
                    return BookmarkStart.b("䈰䌲䜴制堸强丼圾⑀♂ㅄ", num);
                }
                return BookmarkStart.b("琰䬲嘴制唸", num);

            case MailMergeDataType.Query:
                if (A_1)
                {
                    return BookmarkStart.b("䀰䘲倴䔶䀸", num);
                }
                return BookmarkStart.b("怰朲", num);

            case MailMergeDataType.Odbc:
                if (A_1)
                {
                    return BookmarkStart.b("帰圲圴吶", num);
                }
                return BookmarkStart.b("縰眲眴琶", num);

            case MailMergeDataType.Native:
                if (A_1)
                {
                    return BookmarkStart.b("弰刲䄴帶伸帺", num);
                }
                return BookmarkStart.b("縰眲昴砶", num);
        }
        throw new InvalidOperationException(BookmarkStart.b("搰崲帴夶嘸䰺匼Ἶⱀ≂ⱄ⭆楈♊⡌㵎㙐㙒畔㍖㡘⽚㱜罞በౢၤᕦ੨๪䵬᭮ࡰͲၴ奶", num));
    }

    internal static OdsoDataSourceType smethod_6(string A_0, bool A_1)
    {
        int num = 13;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_49 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                dictionary1.Add(BookmarkStart.b("刲儴匶䬸帺丼䰾̀ⱂ⩄ⱆ", num), 0);
                dictionary1.Add(BookmarkStart.b("圲吴䌶堸夺尼䰾⑀", num), 1);
                dictionary1.Add(BookmarkStart.b("圲娴吶䰸嘺堼儾㕀牂", num), 2);
                dictionary1.Add(BookmarkStart.b("圲娴吶䰸嘺堼儾㕀煂", num), 3);
                dictionary1.Add(BookmarkStart.b("嘲場嘶倸场", num), 4);
                dictionary1.Add(BookmarkStart.b("弲倴倶堸堺䐼", num), 5);
                dictionary1.Add(BookmarkStart.b("帲吴䐶䴸帺似", num), 6);
                dictionary1.Add(BookmarkStart.b("崲吴䌶倸䴺堼", num), 7);
                dictionary1.Add(BookmarkStart.b("䜲倴伶䴸", num), 8);
                Class1160.dictionary_49 = dictionary1;
            }
            if (Class1160.dictionary_49.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return OdsoDataSourceType.AddressBook;

                    case 1:
                        return OdsoDataSourceType.Database;

                    case 2:
                        return OdsoDataSourceType.Document1;

                    case 3:
                        return OdsoDataSourceType.Document2;

                    case 4:
                        return OdsoDataSourceType.Email;

                    case 5:
                        return OdsoDataSourceType.Legacy;

                    case 6:
                        return OdsoDataSourceType.Master;

                    case 7:
                        return OdsoDataSourceType.Native;

                    case 8:
                        return OdsoDataSourceType.Text;
                }
            }
        }
        int num3 = Class1041.smethod_18(A_0);
        if (num3 != -2147483648)
        {
            return (OdsoDataSourceType) num3;
        }
        return OdsoDataSourceType.None;
    }

    internal static string smethod_7(OdsoDataSourceType A_0, bool A_1)
    {
        int num = 9;
        if (A_0 != OdsoDataSourceType.None)
        {
            if (!A_1)
            {
                int num2 = (int) A_0;
                return num2.ToString();
            }
            switch (A_0)
            {
                case OdsoDataSourceType.Text:
                    return BookmarkStart.b("嬮吰䬲䄴", num);

                case OdsoDataSourceType.Database:
                    return BookmarkStart.b("䬮倰䜲吴唶堸䠺堼", num);

                case OdsoDataSourceType.AddressBook:
                    return BookmarkStart.b("丮唰圲䜴制䨸䠺缼倾⹀⡂", num);

                case OdsoDataSourceType.Document1:
                    return BookmarkStart.b("䬮帰倲䀴娶尸唺䤼฾", num);

                case OdsoDataSourceType.Document2:
                    return BookmarkStart.b("䬮帰倲䀴娶尸唺䤼ാ", num);

                case OdsoDataSourceType.Native:
                    return BookmarkStart.b("䄮倰䜲尴䄶尸", num);

                case OdsoDataSourceType.Email:
                    return BookmarkStart.b("䨮尰刲尴嬶", num);

                case OdsoDataSourceType.Legacy:
                    return BookmarkStart.b("䌮吰吲吴吶䀸", num);

                case OdsoDataSourceType.Master:
                    return BookmarkStart.b("䈮倰䀲䄴制䬸", num);
            }
        }
        return "";
    }

    internal static OdsoFieldMappingType smethod_8(string A_0)
    {
        int num = 8;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_50 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䨭刯焱嬳娵䴷圹刻", num), 0);
                dictionary1.Add(BookmarkStart.b("䨭刯ἱ圳夵吷伹儻倽", num), 1);
                dictionary1.Add(BookmarkStart.b("䀭䔯帱堳", num), 2);
                dictionary1.Add(BookmarkStart.b("伭启嘱䘳匵䬷䤹ᄻ尽ⰿⵁ❃ⵅ", num), 3);
                dictionary1.Add(BookmarkStart.b("崭儯帱䄳䈵夷丹唻儽⸿", num), 4);
                dictionary1.Add(BookmarkStart.b("䌭儯䈱䐳匵尷", num), 5);
                dictionary1.Add(BookmarkStart.b("䰭儯䀱圳夵尷弹", num), 6);
                Class1160.dictionary_50 = dictionary1;
            }
            if (Class1160.dictionary_50.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return OdsoFieldMappingType.Column;

                    case 1:
                        return OdsoFieldMappingType.Column;

                    case 2:
                        return OdsoFieldMappingType.Null;

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        return OdsoFieldMappingType.Null;
                }
            }
        }
        return OdsoFieldMappingType.Null;
    }

    internal static string smethod_9(OdsoFieldMappingType A_0, bool A_1)
    {
        int num = 8;
        if (A_0 != OdsoFieldMappingType.Null)
        {
            switch (A_0)
            {
                case OdsoFieldMappingType.Column:
                    if (A_1)
                    {
                        return BookmarkStart.b("䨭刯焱嬳娵䴷圹刻", num);
                    }
                    return BookmarkStart.b("䨭刯ἱ圳夵吷伹儻倽", num);

                case OdsoFieldMappingType.Null:
                    return BookmarkStart.b("䀭䔯帱堳", num);
            }
        }
        return "";
    }
}

