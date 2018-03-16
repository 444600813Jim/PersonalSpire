using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class819
{
    [ThreadStatic]
    private static Dictionary<string, FieldType> dictionary_0;
    [ThreadStatic]
    private static Dictionary<FieldType, string> dictionary_1;

    internal Class819()
    {
    }

    internal static Dictionary<string, FieldType> smethod_0()
    {
        if (dictionary_0 == null)
        {
            smethod_4();
        }
        return dictionary_0;
    }

    internal static Dictionary<FieldType, string> smethod_1()
    {
        if (dictionary_1 == null)
        {
            smethod_5();
        }
        return dictionary_1;
    }

    internal static FieldType smethod_2(string A_0)
    {
        int num = 2;
        char[] separator = new char[] { ' ', '\x00a0', '"' };
        string[] strArray = A_0.TrimStart(new char[0]).Split(separator);
        if (strArray.Length == 0)
        {
            throw new Exception(string.Format(BookmarkStart.b("笧娩䤫䴭夯吱崳匵尷ᨹ娻圽┿⹁⁃╅❇⹉⥋湍㥏⅑瑓㡕㝗⹙籛⡝ş๡ൣɥ䙧", num), A_0));
        }
        string key = strArray[0].ToUpper();
        if (key.StartsWith(BookmarkStart.b("ᔧ", num)))
        {
            return FieldType.FieldExpression;
        }
        if (smethod_0().ContainsKey(key))
        {
            return smethod_0()[key];
        }
        return FieldType.FieldUnknown;
    }

    internal static string smethod_3(FieldType A_0)
    {
        if (smethod_1().ContainsKey(A_0))
        {
            return smethod_1()[A_0];
        }
        return null;
    }

    private static void smethod_4()
    {
        dictionary_0 = new Dictionary<string, FieldType>();
        dictionary_0.Add(BookmarkStart.b("ᬥ", 0), FieldType.FieldFormula);
        dictionary_0.Add(BookmarkStart.b("朥氧簩洫怭猯眱", 0), FieldType.FieldAdvance);
        dictionary_0.Add(BookmarkStart.b("朥笧愩", 0), FieldType.FieldAsk);
        dictionary_0.Add(BookmarkStart.b("朥紧縩搫愭戯", 0), FieldType.FieldAuthor);
        dictionary_0.Add(BookmarkStart.b("朥紧縩挫怭支缱", 0), FieldType.FieldAutoNum);
        dictionary_0.Add(BookmarkStart.b("朥紧縩挫怭支缱砳焵琷", 0), FieldType.FieldAutoNumLegal);
        dictionary_0.Add(BookmarkStart.b("朥紧縩挫怭支缱笳挵氷", 0), FieldType.FieldAutoNumOutline);
        dictionary_0.Add(BookmarkStart.b("朥紧縩挫稭甯樱怳", 0), FieldType.FieldAutoText);
        dictionary_0.Add(BookmarkStart.b("朥紧縩挫稭甯樱怳稵焷椹栻", 0), FieldType.FieldAutoTextList);
        dictionary_0.Add(BookmarkStart.b("搥椧砩漫愭琯眱", 0), FieldType.FieldBarCode);
        dictionary_0.Add(BookmarkStart.b("攥朧朩愫欭縯昱朳", 0), FieldType.FieldComments);
        dictionary_0.Add(BookmarkStart.b("攥朧朩簫漭戯眱", 0), FieldType.FieldCompare);
        dictionary_0.Add(BookmarkStart.b("攥稧漩洫稭甯瘱申戵紷", 0), FieldType.FieldCreateDate);
        dictionary_0.Add(BookmarkStart.b("戥椧縩洫氭焯愱焳", 0), FieldType.FieldDatabase);
        dictionary_0.Add(BookmarkStart.b("戥椧縩椫", 0), FieldType.FieldDate);
        dictionary_0.Add(BookmarkStart.b("戥朧椩簫簭缯戱焳搵氷挹", 0), FieldType.FieldDocProperty);
        dictionary_0.Add(BookmarkStart.b("戥朧椩稫漭戯笱申琵琷缹", 0), FieldType.FieldDocVariable);
        dictionary_0.Add(BookmarkStart.b("挥氧挩砫稭礯缱焳", 0), FieldType.FieldEditTime);
        dictionary_0.Add(BookmarkStart.b("挥礧", 0), FieldType.FieldFormula);
        dictionary_0.Add(BookmarkStart.b("急愧昩椫怭焯缱焳", 0), FieldType.FieldFileName);
        dictionary_0.Add(BookmarkStart.b("急愧昩椫紭礯栱焳", 0), FieldType.FieldFileSize);
        dictionary_0.Add(BookmarkStart.b("急愧昩怫札縯", 0), FieldType.FieldFillIn);
        dictionary_0.Add(BookmarkStart.b("愥朧縩挫氭支昱怳礵瘷", 0), FieldType.FieldGoToButton);
        dictionary_0.Add(BookmarkStart.b("渥焧稩椫簭簯笱稳紵", 0), FieldType.FieldHyperlink);
        dictionary_0.Add(BookmarkStart.b("漥渧", 0), FieldType.FieldIf);
        dictionary_0.Add(BookmarkStart.b("漥昧椩怫笭琯眱怳猵怷渹", 0), FieldType.FieldIncludeText);
        dictionary_0.Add(BookmarkStart.b("漥昧椩怫笭琯眱搳缵笷渹椻氽Կ", 0), FieldType.FieldIncludePicture);
        dictionary_0.Add(BookmarkStart.b("漥昧温椫瘭", 0), FieldType.FieldIndex);
        dictionary_0.Add(BookmarkStart.b("漥昧氩挫", 0), FieldType.FieldInfo);
        dictionary_0.Add(BookmarkStart.b("津洧猩笫愭戯瘱朳", 0), FieldType.FieldKeyWord);
        dictionary_0.Add(BookmarkStart.b("樥椧礩砫紭焯搱焳爵稷挹", 0), FieldType.FieldLastSavedBy);
        dictionary_0.Add(BookmarkStart.b("樥愧搩末", 0), FieldType.FieldLink);
        dictionary_0.Add(BookmarkStart.b("樥愧礩砫怭支缱", 0), FieldType.FieldListNum);
        dictionary_0.Add(BookmarkStart.b("欥椧椩縫愭爯朱怳戵眷琹", 0), FieldType.FieldMacroButton);
        dictionary_0.Add(BookmarkStart.b("欥洧砩欫欭瘯笱焳稵簷", 0), FieldType.FieldMergeField);
        dictionary_0.Add(BookmarkStart.b("欥洧砩欫欭戯眱眳", 0), FieldType.FieldMergeRec);
        dictionary_0.Add(BookmarkStart.b("欥洧砩欫欭振眱攳", 0), FieldType.FieldMergeSeq);
        dictionary_0.Add(BookmarkStart.b("栥洧爩砫", 0), FieldType.FieldNext);
        dictionary_0.Add(BookmarkStart.b("栥洧爩砫札瘯", 0), FieldType.FieldNextIf);
        dictionary_0.Add(BookmarkStart.b("栥朧縩椫簭甯琱", 0), FieldType.FieldNoteRef);
        dictionary_0.Add(BookmarkStart.b("栥紧朩漫昭焯怱朳", 0), FieldType.FieldNumChars);
        dictionary_0.Add(BookmarkStart.b("栥紧朩簫漭眯眱朳", 0), FieldType.FieldNumPages);
        dictionary_0.Add(BookmarkStart.b("栥紧朩笫愭戯瘱朳", 0), FieldType.FieldNumWords);
        dictionary_0.Add(BookmarkStart.b("瘥椧洩椫", 0), FieldType.FieldPage);
        dictionary_0.Add(BookmarkStart.b("瘥椧洩椫簭甯琱", 0), FieldType.FieldPageRef);
        dictionary_0.Add(BookmarkStart.b("瘥稧挩戫稭", 0), FieldType.FieldPrint);
        dictionary_0.Add(BookmarkStart.b("瘥稧挩戫稭琯猱怳猵", 0), FieldType.FieldPrintDate);
        dictionary_0.Add(BookmarkStart.b("瘥稧挩稫漭搯眱", 0), FieldType.FieldPrivate);
        dictionary_0.Add(BookmarkStart.b("眥紧攩砫欭", 0), FieldType.FieldQuote);
        dictionary_0.Add(BookmarkStart.b("琥洧氩", 0), FieldType.FieldRef);
        dictionary_0.Add(BookmarkStart.b("琥氧", 0), FieldType.FieldRefDoc);
        dictionary_0.Add(BookmarkStart.b("琥洧簩戫笭累", 0), FieldType.FieldRevisionNum);
        dictionary_0.Add(BookmarkStart.b("甥椧簩椫樭焯昱焳", 0), FieldType.FieldSaveDate);
        dictionary_0.Add(BookmarkStart.b("甥洧椩砫札缯簱", 0), FieldType.FieldSection);
        dictionary_0.Add(BookmarkStart.b("甥洧椩砫札缯簱搳眵缷缹漻", 0), FieldType.FieldSectionPages);
        dictionary_0.Add(BookmarkStart.b("甥洧笩", 0), FieldType.FieldSequence);
        dictionary_0.Add(BookmarkStart.b("甥洧縩", 0), FieldType.FieldSet);
        dictionary_0.Add(BookmarkStart.b("甥挧挩簫札瘯", 0), FieldType.FieldSkipIf);
        dictionary_0.Add(BookmarkStart.b("甥簧猩怫欭戯眱爳", 0), FieldType.FieldStyleRef);
        dictionary_0.Add(BookmarkStart.b("甥紧栩昫欭猯昱", 0), FieldType.FieldSubject);
        dictionary_0.Add(BookmarkStart.b("甥焧朩渫愭簯", 0), FieldType.FieldSymbol);
        dictionary_0.Add(BookmarkStart.b("爥洧朩簫戭焯昱焳", 0), FieldType.FieldTemplate);
        dictionary_0.Add(BookmarkStart.b("爥愧朩椫", 0), FieldType.FieldTime);
        dictionary_0.Add(BookmarkStart.b("爥愧縩怫欭", 0), FieldType.FieldTitle);
        dictionary_0.Add(BookmarkStart.b("爥朧欩", 0), FieldType.FieldTOA);
        dictionary_0.Add(BookmarkStart.b("爥椧", 0), FieldType.FieldTOAEntry);
        dictionary_0.Add(BookmarkStart.b("爥朧椩", 0), FieldType.FieldTOC);
        dictionary_0.Add(BookmarkStart.b("爥欧", 0), FieldType.FieldTOCEntry);
        dictionary_0.Add(BookmarkStart.b("猥笧漩縫漭琯瘱昳猵欷椹", 0), FieldType.FieldUserAddress);
        dictionary_0.Add(BookmarkStart.b("猥笧漩縫札縯笱怳缵礷瘹漻", 0), FieldType.FieldUserInitials);
        dictionary_0.Add(BookmarkStart.b("猥笧漩縫怭焯缱焳", 0), FieldType.FieldUserName);
        dictionary_0.Add(BookmarkStart.b("縥洧", 0), FieldType.FieldIndexEntry);
        dictionary_0.Add(BookmarkStart.b("甥性欩簫欭", 0), FieldType.FieldShape);
        dictionary_0.Add(BookmarkStart.b("朥氧温攫怭", 0), FieldType.FieldAddin);
        dictionary_0.Add(BookmarkStart.b("急朧砩愫洭砯眱眳紵稷甹搻", 0), FieldType.FieldFormCheckBox);
        dictionary_0.Add(BookmarkStart.b("急朧砩愫樭戯紱搳爵眷洹爻", 0), FieldType.FieldFormDropDown);
        dictionary_0.Add(BookmarkStart.b("急朧砩愫稭甯樱怳", 0), FieldType.FieldFormTextInput);
        dictionary_0.Add(BookmarkStart.b("攥朧搩砫簭缯縱", 0), FieldType.FieldOCX);
        dictionary_0.Add(BookmarkStart.b("挥攧栩椫樭", 0), FieldType.FieldEmbed);
        dictionary_0.Add(BookmarkStart.b("朥氧温縫欭振愱瘳稵眷礹眻", 0), FieldType.FieldAddressBlock);
        dictionary_0.Add(BookmarkStart.b("搥愧温攫愭支昱砳缵瘷缹", 0), FieldType.FieldBidiOutline);
        dictionary_0.Add(BookmarkStart.b("攥愧縩洫稭礯紱稳", 0), FieldType.FieldCitation);
    }

    private static void smethod_5()
    {
        int num = 2;
        if (dictionary_0 != null)
        {
            dictionary_0.Clear();
            dictionary_0 = null;
        }
        dictionary_1 = new Dictionary<FieldType, string>();
        dictionary_1.Add(FieldType.FieldFormula, BookmarkStart.b("ᔧ", num));
        dictionary_1.Add(FieldType.FieldAdvance, BookmarkStart.b("椧温稫漭縯焱焳", num));
        dictionary_1.Add(FieldType.FieldAsk, BookmarkStart.b("椧礩末", num));
        dictionary_1.Add(FieldType.FieldAuthor, BookmarkStart.b("椧缩砫昭缯怱", num));
        dictionary_1.Add(FieldType.FieldAutoNum, BookmarkStart.b("椧缩砫愭縯朱礳", num));
        dictionary_1.Add(FieldType.FieldAutoNumLegal, BookmarkStart.b("椧缩砫愭縯朱礳稵缷瘹", num));
        dictionary_1.Add(FieldType.FieldAutoNumOutline, BookmarkStart.b("椧缩砫愭縯朱礳礵洷渹", num));
        dictionary_1.Add(FieldType.FieldAutoText, BookmarkStart.b("椧缩砫愭搯眱氳戵", num));
        dictionary_1.Add(FieldType.FieldAutoTextList, BookmarkStart.b("椧缩砫愭搯眱氳戵琷猹漻樽", num));
        dictionary_1.Add(FieldType.FieldBarCode, BookmarkStart.b("樧欩縫洭缯瘱焳", num));
        dictionary_1.Add(FieldType.FieldComments, BookmarkStart.b("欧攩愫挭甯簱怳攵", num));
        dictionary_1.Add(FieldType.FieldCompare, BookmarkStart.b("欧攩愫縭焯怱焳", num));
        dictionary_1.Add(FieldType.FieldCreateDate, BookmarkStart.b("欧砩椫漭搯眱瀳眵氷缹", num));
        dictionary_1.Add(FieldType.FieldDatabase, BookmarkStart.b("氧欩砫漭爯猱朳猵", num));
        dictionary_1.Add(FieldType.FieldDate, BookmarkStart.b("氧欩砫欭", num));
        dictionary_1.Add(FieldType.FieldDocProperty, BookmarkStart.b("氧攩漫縭戯紱搳猵樷渹攻", num));
        dictionary_1.Add(FieldType.FieldDocVariable, BookmarkStart.b("氧攩漫砭焯怱紳眵稷瘹礻", num));
        dictionary_1.Add(FieldType.FieldEditTime, BookmarkStart.b("洧温攫稭搯笱礳猵", num));
        dictionary_1.Add(FieldType.FieldExpression, BookmarkStart.b("洧笩", num));
        dictionary_1.Add(FieldType.FieldFileName, BookmarkStart.b("渧挩怫欭縯猱礳猵", num));
        dictionary_1.Add(FieldType.FieldFileSize, BookmarkStart.b("渧挩怫欭振笱渳猵", num));
        dictionary_1.Add(FieldType.FieldFillIn, BookmarkStart.b("渧挩怫戭礯簱", num));
        dictionary_1.Add(FieldType.FieldGoToButton, BookmarkStart.b("漧攩砫愭爯朱怳戵眷琹", num));
        dictionary_1.Add(FieldType.FieldHyperlink, BookmarkStart.b("性猩簫欭戯縱紳砵猷", num));
        dictionary_1.Add(FieldType.FieldIf, BookmarkStart.b("愧氩", num));
        dictionary_1.Add(FieldType.FieldIncludeText, BookmarkStart.b("愧搩漫戭支瘱焳戵紷戹栻", num));
        dictionary_1.Add(FieldType.FieldIncludePicture, BookmarkStart.b("愧搩漫戭支瘱焳昵焷礹栻欽ሿ݁", num));
        dictionary_1.Add(FieldType.FieldIndex, BookmarkStart.b("愧搩栫欭栯", num));
        dictionary_1.Add(FieldType.FieldInfo, BookmarkStart.b("愧搩樫愭", num));
        dictionary_1.Add(FieldType.FieldKeyWord, BookmarkStart.b("挧漩甫礭缯怱瀳攵", num));
        dictionary_1.Add(FieldType.FieldLastSavedBy, BookmarkStart.b("搧欩缫稭振猱戳猵簷砹攻", num));
        dictionary_1.Add(FieldType.FieldLink, BookmarkStart.b("搧挩戫攭", num));
        dictionary_1.Add(FieldType.FieldListNum, BookmarkStart.b("搧挩缫稭縯朱礳", num));
        dictionary_1.Add(FieldType.FieldMacroButton, BookmarkStart.b("攧欩漫簭缯瀱愳戵氷甹爻", num));
        dictionary_1.Add(FieldType.FieldMergeField, BookmarkStart.b("攧漩縫椭甯琱紳猵琷縹", num));
        dictionary_1.Add(FieldType.FieldMergeRec, BookmarkStart.b("攧漩縫椭甯怱焳电", num));
        dictionary_1.Add(FieldType.FieldMergeSeq, BookmarkStart.b("攧漩縫椭甯愱焳朵", num));
        dictionary_1.Add(FieldType.FieldNext, BookmarkStart.b("昧漩琫稭", num));
        dictionary_1.Add(FieldType.FieldNextIf, BookmarkStart.b("昧漩琫稭礯琱", num));
        dictionary_1.Add(FieldType.FieldNoteRef, BookmarkStart.b("昧攩砫欭戯眱爳", num));
        dictionary_1.Add(FieldType.FieldNumChars, BookmarkStart.b("昧缩愫洭砯猱昳攵", num));
        dictionary_1.Add(FieldType.FieldNumPages, BookmarkStart.b("昧缩愫縭焯由焳攵", num));
        dictionary_1.Add(FieldType.FieldNumWords, BookmarkStart.b("昧缩愫礭缯怱瀳攵", num));
        dictionary_1.Add(FieldType.FieldPage, BookmarkStart.b("砧欩欫欭", num));
        dictionary_1.Add(FieldType.FieldPageRef, BookmarkStart.b("砧欩欫欭戯眱爳", num));
        dictionary_1.Add(FieldType.FieldPrint, BookmarkStart.b("砧砩攫怭搯", num));
        dictionary_1.Add(FieldType.FieldPrintDate, BookmarkStart.b("砧砩攫怭搯瘱申戵紷", num));
        dictionary_1.Add(FieldType.FieldPrivate, BookmarkStart.b("砧砩攫砭焯昱焳", num));
        dictionary_1.Add(FieldType.FieldQuote, BookmarkStart.b("礧缩挫稭甯", num));
        dictionary_1.Add(FieldType.FieldRef, BookmarkStart.b("稧漩樫", num));
        dictionary_1.Add(FieldType.FieldRefDoc, BookmarkStart.b("稧温", num));
        dictionary_1.Add(FieldType.FieldRevisionNum, BookmarkStart.b("稧漩稫怭支缱", num));
        dictionary_1.Add(FieldType.FieldSaveDate, BookmarkStart.b("笧欩稫欭琯猱怳猵", num));
        dictionary_1.Add(FieldType.FieldSection, BookmarkStart.b("笧漩漫稭礯紱稳", num));
        dictionary_1.Add(FieldType.FieldSectionPages, BookmarkStart.b("笧漩漫稭礯紱稳昵礷紹礻洽", num));
        dictionary_1.Add(FieldType.FieldSequence, BookmarkStart.b("笧漩紫", num));
        dictionary_1.Add(FieldType.FieldSet, BookmarkStart.b("笧漩砫", num));
        dictionary_1.Add(FieldType.FieldSkipIf, BookmarkStart.b("笧愩攫縭礯琱", num));
        dictionary_1.Add(FieldType.FieldStyleRef, BookmarkStart.b("笧縩甫戭甯怱焳瀵", num));
        dictionary_1.Add(FieldType.FieldSubject, BookmarkStart.b("笧缩渫搭甯焱怳", num));
        dictionary_1.Add(FieldType.FieldSymbol, BookmarkStart.b("笧猩愫氭缯縱", num));
        dictionary_1.Add(FieldType.FieldTemplate, BookmarkStart.b("簧漩愫縭簯猱怳猵", num));
        dictionary_1.Add(FieldType.FieldTime, BookmarkStart.b("簧挩愫欭", num));
        dictionary_1.Add(FieldType.FieldTitle, BookmarkStart.b("簧挩砫戭甯", num));
        dictionary_1.Add(FieldType.FieldTOA, BookmarkStart.b("簧攩洫", num));
        dictionary_1.Add(FieldType.FieldTOAEntry, BookmarkStart.b("簧欩", num));
        dictionary_1.Add(FieldType.FieldTOC, BookmarkStart.b("簧攩漫", num));
        dictionary_1.Add(FieldType.FieldTOCEntry, BookmarkStart.b("簧椩", num));
        dictionary_1.Add(FieldType.FieldUserAddress, BookmarkStart.b("紧礩椫簭焯瘱瀳搵紷椹漻", num));
        dictionary_1.Add(FieldType.FieldUserInitials, BookmarkStart.b("紧礩椫簭礯簱紳戵焷笹瀻洽", num));
        dictionary_1.Add(FieldType.FieldUserName, BookmarkStart.b("紧礩椫簭縯猱礳猵", num));
        dictionary_1.Add(FieldType.FieldIndexEntry, BookmarkStart.b("瀧漩", num));
        dictionary_1.Add(FieldType.FieldShape, BookmarkStart.b("笧戩洫縭甯", num));
        dictionary_1.Add(FieldType.FieldAddin, BookmarkStart.b("椧温栫札縯", num));
        dictionary_1.Add(FieldType.FieldFormCheckBox, BookmarkStart.b("渧攩縫挭猯稱焳电猷砹猻昽", num));
        dictionary_1.Add(FieldType.FieldFormDropDown, BookmarkStart.b("渧攩縫挭琯怱笳昵簷甹欻瀽", num));
        dictionary_1.Add(FieldType.FieldFormTextInput, BookmarkStart.b("渧攩縫挭搯眱氳戵", num));
        dictionary_1.Add(FieldType.FieldOCX, BookmarkStart.b("欧攩戫稭戯紱砳", num));
        dictionary_1.Add(FieldType.FieldEmbed, BookmarkStart.b("洧朩渫欭琯", num));
    }
}

