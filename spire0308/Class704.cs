using Spire.CompoundFile.Doc;
using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal class Class704
{
    private BuiltinDocumentProperties builtinDocumentProperties_0;
    private Class520 class520_0;
    private Class520 class520_1;
    private Class520 class520_2;
    private CustomDocumentProperties customDocumentProperties_0;
    private static readonly DateTime dateTime_0 = new DateTime(0x641, 1, 1);
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private static readonly Hashtable hashtable_2 = new Hashtable();
    private static readonly Hashtable hashtable_3 = new Hashtable();
    private const int int_0 = 0x4b0;
    private const int int_1 = 0x1000000;
    private int int_2;
    private const string string_0 = "_PID_LINKBASE";

    static Class704()
    {
        Class791.smethod_0(new object[] { 
            0x17, BookmarkStart.b("縧伩師崭夯崱娳", 2), 0x11, BookmarkStart.b("欧䈩䴫尭儯儱䀳匵䨷䤹欻圽㐿⩁ᝃ㙅⥇⥉⥋㵍", 2), 2, BookmarkStart.b("欧䬩堫䬭圯崱䘳伵", 2), 4, BookmarkStart.b("樧匩堫䬭猯崱䄳堵䰷", 2), 5, BookmarkStart.b("搧䌩䈫䬭猯崱䄳堵䰷", 2), 6, BookmarkStart.b("砧䬩師伭圯䀱唳䘵倷礹医䬽⸿㙁", 2), 12, BookmarkStart.b("性伩䴫䨭夯就匳昵夷匹主", 2), 13, BookmarkStart.b("氧䔩伫縭儯䀱䀳䔵", 2), 
            14, BookmarkStart.b("攧䬩䈫伭圯圱䘳", 2), 15, BookmarkStart.b("欧䔩䄫席儯就䴳", 2), 0x10, BookmarkStart.b("搧䌩䈫䔭䌯瘱崳䐵䰷䌹", 2), 0x1b, BookmarkStart.b("欧䔩䈫娭唯就䀳攵䰷嬹䠻䬽㌿", 2), 0x1a, BookmarkStart.b("欧䔩䈫娭唯就䀳戵䄷䨹夻", 2)
         }, hashtable_0, hashtable_1);
        Class791.smethod_0(new object[] { 
            2, BookmarkStart.b("簧䌩堫䈭唯", 2), 3, BookmarkStart.b("笧弩丫䐭唯儱䀳", 2), 4, BookmarkStart.b("椧弩堫䘭弯䀱", 2), 5, BookmarkStart.b("挧伩唫夭弯䀱倳䔵", 2), 6, BookmarkStart.b("欧䔩䄫䌭唯就䀳䔵", 2), 7, BookmarkStart.b("簧伩䄫席尯匱䀳匵", 2), 8, BookmarkStart.b("搧䬩弫娭焯䜱䀳帵圷䠹", 2), 11, BookmarkStart.b("搧䬩弫娭怯䀱崳堵䰷弹堻", 2), 
            12, BookmarkStart.b("欧堩䤫伭䐯嬱嬳堵簷嬹䠻嬽", 2), 13, BookmarkStart.b("搧䬩弫娭振匱䈳匵簷嬹䠻嬽", 2), 14, BookmarkStart.b("砧䬩䬫䬭猯崱䄳堵䰷", 2), 15, BookmarkStart.b("缧䔩師䨭猯崱䄳堵䰷", 2), 0x10, BookmarkStart.b("欧䈩䴫尭猯崱䄳堵䰷", 2), 0x13, BookmarkStart.b("笧伩伫嬭䈯嬱䀳伵", 2), 0x12, BookmarkStart.b("椧娩尫䈭夯儱唳䈵儷唹刻瀽ℿ⽁⅃", 2)
         }, hashtable_2, hashtable_3);
    }

    internal void method_0(Class1089 A_0, BuiltinDocumentProperties A_1, CustomDocumentProperties A_2)
    {
        this.builtinDocumentProperties_0 = A_1;
        this.customDocumentProperties_0 = A_2;
        this.method_1(A_0);
        this.method_2(A_0);
    }

    private void method_1(Class1089 A_0)
    {
        int num = 2;
        Stream stream = A_0.method_4(BookmarkStart.b("ⴧ礩夫䌭崯匱䘳伵焷吹娻儽㈿⽁╃㉅ⅇ╉≋", 2));
        if (stream != null)
        {
            Class1046 class3 = new Class1046(stream);
            if (class3.method_0().Count != 0)
            {
                Class566 class4 = ((Class520) class3.method_0()[0]).method_0();
                for (int i = 0; i < class4.method_2(); i++)
                {
                    Class521 class2 = class4.method_0(i);
                    switch (class2.int_0)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 0x12:
                            this.method_4(smethod_0(class2.int_0), class2.object_0, PropertyValueType.String);
                            break;

                        case 9:
                            if (class2.object_0 is string)
                            {
                                this.method_4(BookmarkStart.b("稧伩娫䜭䌯嬱嬳堵瘷伹儻尽┿ぁ", num), class2.object_0, PropertyValueType.String);
                            }
                            break;

                        case 10:
                            if (class2.object_0 is DateTime)
                            {
                                this.method_4(BookmarkStart.b("簧䔩堫伭尯眱倳張䰷匹刻夽ᐿ⭁⥃⍅", num), TimeSpan.FromMinutes((double) smethod_4((DateTime) class2.object_0)), PropertyValueType.Other);
                            }
                            break;

                        case 11:
                        case 12:
                        case 13:
                            this.method_4(smethod_0(class2.int_0), class2.object_0, PropertyValueType.Date);
                            break;

                        case 14:
                        case 15:
                        case 0x10:
                        case 0x13:
                            this.method_4(smethod_0(class2.int_0), class2.object_0, PropertyValueType.Int);
                            break;
                    }
                }
            }
        }
    }

    private void method_10(int A_0, object A_1)
    {
        this.class520_0.method_0().method_5(new Class521(A_0, null, A_1));
    }

    private void method_11(int A_0, object A_1)
    {
        this.class520_1.method_0().method_5(new Class521(A_0, null, A_1));
    }

    private int method_12(string A_0, object A_1)
    {
        int num = this.int_2++;
        this.class520_2.method_0().method_5(new Class521(num, A_0, A_1));
        return num;
    }

    private void method_13()
    {
        foreach (string str in this.customDocumentProperties_0.CustomHash.Keys)
        {
            DocumentProperty property = this.customDocumentProperties_0.CustomHash[str];
            int num = this.method_12(property.Name, property.Value);
            if (Class567.smethod_16(property.LinkSource))
            {
                this.class520_2.method_0().method_5(new Class521(0x1000000 | num, null, property.LinkSource));
            }
        }
    }

    internal Class566 method_14()
    {
        return this.class520_2.method_0();
    }

    private void method_15(string A_0, params object[] A_1)
    {
    }

    private void method_2(Class1089 A_0)
    {
        Stream stream = A_0.method_4(BookmarkStart.b("㘲焴堶娸为值娾⽀㝂ᙄ㉆⑈♊ⱌ㵎⡐ᩒ㭔ㅖ㙘⥚ぜ㹞ᕠ੢੤०", 13));
        if (stream != null)
        {
            Class1046 class3 = new Class1046(stream);
            foreach (Class520 class2 in class3.method_0())
            {
                if (class2.method_1().Equals(Class520.guid_1))
                {
                    this.method_3(class2.method_0());
                }
                else
                {
                    this.method_5(class2.method_0());
                }
            }
        }
    }

    private void method_3(Class566 A_0)
    {
        int num = 2;
        for (int i = 0; i < A_0.method_2(); i++)
        {
            Class521 class2 = A_0.method_0(i);
            switch (class2.int_0)
            {
                case 2:
                case 14:
                case 15:
                case 0x1a:
                case 0x1b:
                    this.method_4(smethod_1(class2.int_0), class2.object_0, PropertyValueType.String);
                    break;

                case 4:
                case 5:
                case 6:
                case 0x11:
                case 0x17:
                    this.method_4(smethod_1(class2.int_0), class2.object_0, PropertyValueType.Int);
                    break;

                case 12:
                    this.method_4(BookmarkStart.b("性伩䴫䨭夯就匳昵夷匹主䴽", num), class2.object_0, PropertyValueType.ObjectArray);
                    break;

                case 13:
                    this.method_4(BookmarkStart.b("簧䌩堫䈭唯䄱笳倵样嬹主䨽㌿", num), class2.object_0, PropertyValueType.StringArray);
                    break;

                case 0x10:
                    this.method_4(BookmarkStart.b("搧䌩䈫䔭䌯朱䐳戵圷縹崻䨽┿", num), class2.object_0, PropertyValueType.Boolean);
                    break;
            }
        }
    }

    private void method_4(string A_0, object A_1, PropertyValueType A_2)
    {
        int num = 0x10;
        if (DocumentProperty.smethod_1(A_1) == A_2)
        {
            Class567.smethod_19(A_0, BookmarkStart.b("堵夷圹夻", num));
            Class567.smethod_20(A_1, BookmarkStart.b("䀵夷嘹䤻嬽", num));
            DocumentProperty property = new DocumentProperty(A_0, A_1);
            string key = A_0;
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_125 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1d);
                    dictionary1.Add(BookmarkStart.b("搵崷䰹唻䴽⤿ⵁ⩃ࡅ㵇❉⹋⭍≏", num), 0);
                    dictionary1.Add(BookmarkStart.b("戵儷丹倻嬽", num), 1);
                    dictionary1.Add(BookmarkStart.b("攵䴷堹嘻嬽⌿㙁", num), 2);
                    dictionary1.Add(BookmarkStart.b("眵䴷丹吻儽㈿", num), 3);
                    dictionary1.Add(BookmarkStart.b("紵崷䌹䬻儽㈿♁㝃", num), 4);
                    dictionary1.Add(BookmarkStart.b("电圷圹儻嬽⸿㙁㝃", num), 5);
                    dictionary1.Add(BookmarkStart.b("戵崷圹䰻刽ℿ㙁⅃", num), 6);
                    dictionary1.Add(BookmarkStart.b("稵夷䤹䠻缽㔿㙁ⱃ⥅㩇", num), 7);
                    dictionary1.Add(BookmarkStart.b("稵夷䤹䠻洽ℿ㑁⅃≅ੇ㍉", num), 8);
                    dictionary1.Add(BookmarkStart.b("稵夷䤹䠻渽㈿⭁⩃㉅ⵇ⹉", num), 9);
                    dictionary1.Add(BookmarkStart.b("电䨷弹崻䨽⤿ⵁ⩃Ʌ⥇㹉⥋", num), 10);
                    dictionary1.Add(BookmarkStart.b("电䨷弹崻䨽┿ف╃㉅ⵇ", num), 11);
                    dictionary1.Add(BookmarkStart.b("稵夷䤹䠻洽ℿ㑁⅃Ʌ⥇㹉⥋", num), 12);
                    dictionary1.Add(BookmarkStart.b("昵夷崹夻紽⼿㝁⩃㉅", num), 13);
                    dictionary1.Add(BookmarkStart.b("愵圷䠹堻紽⼿㝁⩃㉅", num), 14);
                    dictionary1.Add(BookmarkStart.b("戵倷伹儻尽⸿⍁ⵃ⩅", num), 15);
                    dictionary1.Add(BookmarkStart.b("电倷嬹主紽⼿㝁⩃㉅", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("攵崷夹䤻䰽⤿㙁㵃", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("眵䠷䨹倻圽⌿⍁ぃ⽅❇⑉ɋ⽍㵏㝑", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("猵尷匹䠻樽⤿⽁⅃", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("戵圷丹崻刽Կ♁ⵃ㉅ⅇ⑉⭋ᩍ㥏㽑ㅓ", num), 20);
                    dictionary1.Add(BookmarkStart.b("电倷嬹主弽⌿㙁⅃㑅㭇ᵉ╋㩍㡏ő⑓㝕㭗㽙⽛", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("縵崷嬹堻圽⸿╁ᑃ❅ⅇ㡉㽋", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("电夷丹夻夽⼿ぁ㵃", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("笵夷吹崻夽┿ぁ", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("电圷圹䰻弽⸿㭁", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("琵䄷丹夻紽⼿㝁⩃㉅", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("稵儷吹夻紽⼿㝁⩃㉅", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("昵夷䠹崻夽㈿⍁㑃⹅େ╉㥋⁍⑏", num), 0x1c);
                    Class1160.dictionary_125 = dictionary1;
                }
                if (Class1160.dictionary_125.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            this.builtinDocumentProperties_0.RevisionNumber = (string) A_1;
                            return;

                        case 1:
                            this.builtinDocumentProperties_0.Title = (string) A_1;
                            return;

                        case 2:
                            this.builtinDocumentProperties_0.Subject = (string) A_1;
                            return;

                        case 3:
                            this.builtinDocumentProperties_0.Author = (string) A_1;
                            return;

                        case 4:
                            this.builtinDocumentProperties_0.Keywords = (string) A_1;
                            return;

                        case 5:
                            this.builtinDocumentProperties_0.Comments = (string) A_1;
                            return;

                        case 6:
                            this.builtinDocumentProperties_0.Template = (string) A_1;
                            return;

                        case 7:
                        case 8:
                            this.builtinDocumentProperties_0.LastAuthor = (string) A_1;
                            return;

                        case 9:
                            this.builtinDocumentProperties_0.LastPrinted = (DateTime) A_1;
                            return;

                        case 10:
                        case 11:
                            this.builtinDocumentProperties_0.CreateDate = (DateTime) A_1;
                            return;

                        case 12:
                            this.builtinDocumentProperties_0.LastSaveDate = (DateTime) A_1;
                            return;

                        case 13:
                            this.builtinDocumentProperties_0.PageCount = (int) A_1;
                            return;

                        case 14:
                            this.builtinDocumentProperties_0.WordCount = (int) A_1;
                            return;

                        case 15:
                            this.builtinDocumentProperties_0.Thumbnail = (string) A_1;
                            return;

                        case 0x10:
                            this.builtinDocumentProperties_0.CharCount = (int) A_1;
                            return;

                        case 0x11:
                            this.builtinDocumentProperties_0.DocSecurity = (int) A_1;
                            return;

                        case 0x12:
                            this.builtinDocumentProperties_0.ApplicationName = (string) A_1;
                            return;

                        case 0x13:
                        case 20:
                            this.builtinDocumentProperties_0.TotalEditingTime = (TimeSpan) A_1;
                            return;

                        case 0x15:
                            this.builtinDocumentProperties_0.CharCountWithSpace = (int) A_1;
                            return;

                        case 0x16:
                            this.builtinDocumentProperties_0.DocumentHash.Add(12, property);
                            return;

                        case 0x17:
                            this.builtinDocumentProperties_0.Category = (string) A_1;
                            return;

                        case 0x18:
                            this.builtinDocumentProperties_0.Manager = (string) A_1;
                            return;

                        case 0x19:
                            this.builtinDocumentProperties_0.Company = (string) A_1;
                            return;

                        case 0x1a:
                            this.builtinDocumentProperties_0.BytesCount = (int) A_1;
                            return;

                        case 0x1b:
                            this.builtinDocumentProperties_0.LinesCount = (int) A_1;
                            return;

                        case 0x1c:
                            this.builtinDocumentProperties_0.ParagraphCount = (int) A_1;
                            break;

                        default:
                            return;
                    }
                }
            }
        }
    }

    private void method_5(Class566 A_0)
    {
        int num = 0x11;
        Hashtable hashtable = new Hashtable();
        Hashtable hashtable2 = new Hashtable();
        for (int i = 0; i < A_0.method_2(); i++)
        {
            Class521 class2 = A_0.method_0(i);
            if (class2.string_0 == BookmarkStart.b("栶椸爺礼怾ീੂୄెୈ੊Ṍ੎", num))
            {
                if (class2.object_0 is byte[])
                {
                }
            }
            else if ((class2.int_0 & 0x1000000) != 0)
            {
                int num4 = class2.int_0 & -16777217;
                hashtable2[num4] = class2.object_0;
            }
            else if (Class567.smethod_16(class2.string_0) && (class2.string_0 != BookmarkStart.b("栶椸爺礼怾ीགౄॆɈᡊ", num)))
            {
                DocumentProperty property = this.customDocumentProperties_0.Add(class2.string_0, class2.object_0);
                hashtable[class2.int_0] = property;
            }
        }
        foreach (DictionaryEntry entry in hashtable2)
        {
            int key = (int) entry.Key;
            DocumentProperty property2 = (DocumentProperty) hashtable[key];
            if (property2 != null)
            {
                property2.LinkSource = (string) entry.Value;
            }
        }
    }

    internal void method_6(BuiltinDocumentProperties A_0, CustomDocumentProperties A_1, Class1089 A_2)
    {
        int num = 0;
        this.builtinDocumentProperties_0 = A_0;
        this.customDocumentProperties_0 = A_1;
        Class1046 class2 = new Class1046();
        this.class520_0 = new Class520(Class520.guid_0, 0x4b0);
        class2.method_0().Add(this.class520_0);
        Class1046 class3 = new Class1046();
        this.class520_1 = new Class520(Class520.guid_1, 0x4b0);
        class3.method_0().Add(this.class520_1);
        this.class520_2 = new Class520(Class520.guid_2, 0x4b0);
        class3.method_0().Add(this.class520_2);
        this.int_2 = 2;
        this.method_7();
        this.method_13();
        if (this.class520_2.method_0().method_2() == 0)
        {
            class3.method_0().Remove(this.class520_2);
        }
        MemoryStream stream = new MemoryStream();
        class2.method_1(stream);
        A_2[BookmarkStart.b("⌥笧弩䄫䌭儯䀱䴳缵嘷尹医䰽ⴿ⍁ぃ⽅❇⑉", num)] = stream;
        MemoryStream stream2 = new MemoryStream();
        class3.method_1(stream2);
        A_2[BookmarkStart.b("⌥氧䔩伫嬭崯圱娳䈵欷伹儻匽ℿぁ㵃ཅ♇ⱉ⍋㱍㵏㍑⁓㽕㝗㑙", num)] = stream2;
    }

    private void method_7()
    {
        foreach (int num2 in this.builtinDocumentProperties_0.SummaryHash.Keys)
        {
            this.method_8(this.builtinDocumentProperties_0.SummaryHash[num2]);
        }
        foreach (int num in this.builtinDocumentProperties_0.DocumentHash.Keys)
        {
            this.method_9(this.builtinDocumentProperties_0.DocumentHash[num], true);
        }
    }

    private void method_8(DocumentProperty A_0)
    {
        this.method_9(A_0, false);
    }

    private void method_9(DocumentProperty A_0, bool A_1)
    {
        int num = 11;
        if (A_0 != null)
        {
            if (!A_1)
            {
                switch (A_0.PropertyId)
                {
                    case BuiltInProperty.Title:
                    case BuiltInProperty.Subject:
                    case BuiltInProperty.Author:
                    case BuiltInProperty.Comments:
                    case BuiltInProperty.Template:
                    case BuiltInProperty.LastAuthor:
                    case BuiltInProperty.LastPrinted:
                    case BuiltInProperty.CreationDate:
                    case BuiltInProperty.LastSaveDate:
                    case BuiltInProperty.PageCount:
                    case BuiltInProperty.WordCount:
                    case BuiltInProperty.CharCount:
                    case BuiltInProperty.ApplicationName:
                    case BuiltInProperty.Security:
                        this.method_10(smethod_2(A_0.Name), A_0.Value);
                        return;

                    case BuiltInProperty.Keywords:
                    case BuiltInProperty.Thumbnail:
                    case BuiltInProperty.PresentationTarget:
                    case BuiltInProperty.SlideCount:
                    case BuiltInProperty.NoteCount:
                    case BuiltInProperty.HiddenCount:
                    case BuiltInProperty.MultimediaClipCount:
                    case BuiltInProperty.ScaleCrop:
                    case BuiltInProperty.ShareDoc:
                    case BuiltInProperty.Hyperlinks:
                    case BuiltInProperty.HyperlinksChanged:
                    case BuiltInProperty.ExcelDigitalSignature:
                        return;

                    case BuiltInProperty.RevisionNumber:
                        this.method_10(9, A_0.Value.ToString());
                        return;

                    case BuiltInProperty.EditTime:
                    {
                        TimeSpan span = (TimeSpan) A_0.Value;
                        int num5 = int.Parse(span.TotalMinutes.ToString());
                        this.method_10(10, smethod_5(num5));
                        return;
                    }
                    case BuiltInProperty.Category:
                    case BuiltInProperty.ByteCount:
                    case BuiltInProperty.LineCount:
                    case BuiltInProperty.ParagraphCount:
                    case BuiltInProperty.HeadingPair:
                    case BuiltInProperty.DocParts:
                    case BuiltInProperty.Manager:
                    case BuiltInProperty.Company:
                    case BuiltInProperty.LinksDirty:
                    case BuiltInProperty.CharactersWithSpaces:
                    case BuiltInProperty.Version:
                    case BuiltInProperty.ContentType:
                    case BuiltInProperty.ContentStatus:
                        this.method_11(smethod_3(A_0.Name), A_0.Value);
                        return;

                    case BuiltInProperty.LinkBase:
                    {
                        string str = A_0.Value.ToString();
                        if (Class567.smethod_16(str))
                        {
                            int num2 = (str.Length * 2) + 2;
                            byte[] bytes = new byte[num2];
                            Encoding.Unicode.GetBytes(str, 0, str.Length, bytes, 0);
                            this.method_12(BookmarkStart.b("渰挲簴猶昸眺琼焾ੀłфᑆై", num), bytes);
                        }
                        return;
                    }
                }
            }
            else
            {
                switch (((PIDDSI) A_0.PropertyId))
                {
                    case PIDDSI.ByteCount:
                    case PIDDSI.LineCount:
                    case PIDDSI.ParCount:
                    case PIDDSI.HeadingPair:
                    case PIDDSI.DocParts:
                    case PIDDSI.Manager:
                    case PIDDSI.Company:
                    case PIDDSI.LinksDirty:
                    case PIDDSI.CharactersWithSpaces:
                    case PIDDSI.Version:
                    case PIDDSI.ContentType:
                    case PIDDSI.ContentStatus:
                    case ((PIDDSI) 0x3e8):
                        this.method_11((int) A_0.PropertyId, A_0.Value);
                        return;

                    case PIDDSI.SlideCount:
                    case PIDDSI.NoteCount:
                    case PIDDSI.HiddenCount:
                    case PIDDSI.MmclipCount:
                    case PIDDSI.Scale:
                    case (PIDDSI.LinksDirty | PIDDSI.Category):
                    case PIDDSI.ShareDoc:
                    case PIDDSI.Hyperlinks:
                    case PIDDSI.HyperlinksChanged:
                    case PIDDSI.ExcelDigitalSignature:
                    case ((PIDDSI) 0x19):
                        return;

                    case PIDDSI.LinkBase:
                    {
                        string str2 = A_0.Value.ToString();
                        if (Class567.smethod_16(str2))
                        {
                            int num3 = (str2.Length * 2) + 2;
                            byte[] buffer2 = new byte[num3];
                            Encoding.Unicode.GetBytes(str2, 0, str2.Length, buffer2, 0);
                            this.method_12(BookmarkStart.b("渰挲簴猶昸眺琼焾ੀłфᑆై", num), buffer2);
                        }
                        return;
                    }
                }
            }
        }
    }

    private static string smethod_0(int A_0)
    {
        return (string) Class791.smethod_5(hashtable_2, A_0);
    }

    private static string smethod_1(int A_0)
    {
        return (string) Class791.smethod_5(hashtable_0, A_0);
    }

    private static int smethod_2(string A_0)
    {
        return (int) Class791.smethod_5(hashtable_3, A_0);
    }

    private static int smethod_3(string A_0)
    {
        return (int) Class791.smethod_5(hashtable_1, A_0);
    }

    private static int smethod_4(DateTime A_0)
    {
        if (A_0 != DateTime.MinValue)
        {
            TimeSpan span = (TimeSpan) (A_0 - dateTime_0);
            double totalMinutes = span.TotalMinutes;
            if ((totalMinutes > 0.0) && (totalMinutes < 2147483647.0))
            {
                return (int) totalMinutes;
            }
        }
        return 0;
    }

    private static DateTime smethod_5(int A_0)
    {
        if (A_0 == 0)
        {
            return DateTime.MinValue;
        }
        TimeSpan span = TimeSpan.FromMinutes((double) A_0);
        return (dateTime_0 + span);
    }
}

